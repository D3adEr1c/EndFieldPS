﻿using BeyondTools.VFS.Crypto;
using ArkFieldPS.Database;
using ArkFieldPS.Game;
using ArkFieldPS.Network;
using ArkFieldPS.Packets.Sc;
using ArkFieldPS.Protocol;
using ArkFieldPS.Resource;
using System.Security.Cryptography;
using static ArkFieldPS.Resource.ResourceManager;

namespace ArkFieldPS.Packets.Cs
{
    public class HandleCsLogin
    {
        [Server.Handler(CsMessageId.CsCreateRole)]
        public static void HandleCsCreateRole(Player session, CsMessageId cmdId, Packet packet)
        {
            CsCreateRole req = packet.DecodeBody<CsCreateRole>();

            
        }
        [Server.Handler(CsMessageId.CsLogin)]
        public static void Handle(Player session, CsMessageId cmdId, Packet packet)
        {
            CsLogin req = packet.DecodeBody<CsLogin>();
            if(Server.clients.Count > Server.config.serverOptions.maxPlayers)
            {
                session.Send(ScMessageId.ScNtfErrorCode, new ScNtfErrorCode()
                {
                    Details = "Server Full",
                    ErrorCode = (int)CODE.ErrCommonServerOverload,
                });
                session.Disconnect();
                return;
            }
            Account account = DatabaseManager.db.GetAccountByTokenGrant(req.Token);
            ScLogin rsp = new()
            {
                IsEnc = false,
                Uid = req.Uid,
                IsFirstLogin = false,
                IsReconnect=false,
                LastRecvUpSeqid = packet.csHead.UpSeqid,
                
            };
            byte[] encKey = GenerateRandomBytes(32);
            string serverPublicKeyPem = req.ClientPublicKey.ToStringUtf8();
            byte[] serverPublicKey = ConvertPemToBytes(serverPublicKeyPem);
            byte[] encryptedEncKey = EncryptWithRsa(encKey, serverPublicKey);
            byte[] serverEncrypNonce = GenerateRandomBytes(12);
           // rsp.ServerEncrypNonce = ByteString.CopyFrom(serverEncrypNonce);
           // rsp.ServerPublicKey = ByteString.CopyFrom(encryptedEncKey);
       
            CSChaCha20 cipher = new CSChaCha20(encKey, serverEncrypNonce, 1);
            if (req.ClientVersion == GameConstants.GAME_VERSION)
            {
                if (account == null)
                {
                    session.Send(ScMessageId.ScNtfErrorCode, new ScNtfErrorCode()
                    {
                        Details = "Account error",
                        ErrorCode = (int)CODE.ErrLoginProcessLogin,
                    });
                    session.Disconnect();
                    return;
                }
                session.Load(account.id);
                
                rsp.Uid = ""+session.accountId;
                session.Send(ScMessageId.ScLogin, rsp);
                
            }
            else
            {
                session.Send(ScMessageId.ScNtfErrorCode, new ScNtfErrorCode()
                {
                    Details="Unsupported client version",
                    ErrorCode= (int)CODE.ErrCommonClientVersionNotEqual
                });
                session.Disconnect();
                return;
            }
            session.Send(new PacketScSyncBaseData(session));
            ScItemBagCommonSync common = new()
            {
                LostAndFound =
                {

                },

            };
            session.Send(ScMessageId.ScItemBagCommonSync, common);
            session.Send(new PacketScItemBagScopeSync(session, ItemValuableDepotType.Weapon));
            session.Send(new PacketScItemBagScopeSync(session, ItemValuableDepotType.WeaponGem));
            session.Send(new PacketScItemBagScopeSync(session, ItemValuableDepotType.Equip));
            session.Send(new PacketScItemBagScopeSync(session, ItemValuableDepotType.CommercialItem));
            session.Send(new PacketScItemBagScopeSync(session, ItemValuableDepotType.Factory));
            session.Send(new PacketScItemBagScopeSync(session, ItemValuableDepotType.SpecialItem));
            session.Send(new PacketScSyncAllMail(session));
            session.Send(new PacketScSceneCollectionSync(session));
            ScSyncAllMission missions = new()
            {
                Missions =
                {
                    {"f1m15", 
                        new Mission()
                        {
                            MissionId="f1m15",
                            MissionState=(int)MissionState.Available,
                            
                        } 
                    }
                },
                
            };
            session.Send(ScMessageId.ScSyncAllMission, missions);

            session.Send(new PacketScGachaSync(session));
            ScSettlementSyncAll settlements = new ScSettlementSyncAll()
            {
                LastTickTime = DateTime.UtcNow.ToUnixTimestampMilliseconds(),
                
            };
            int stid = 3;
            foreach (var item in settlementBasicDataTable)
            {
                settlements.Settlements.Add(new Settlement()
                {
                    Level = 1,
                    SettlementId = item.Value.settlementId,
                    RequireId = "item_plant_grass_powder_2",
                    Exp = 1,
                    Reports =
                    {

                    },
                    UnlockTs = DateTime.UtcNow.AddHours(1).ToUnixTimestampMilliseconds(),
                    AutoSubmit = false,
                    LastManualSubmitTime = DateTime.UtcNow.ToUnixTimestampMilliseconds(),
                    
                    OfficerCharTemplateId = characterTable.Values.ToList()[stid].charId,

                    
                });
                stid++;
            }
            
            session.Send(ScMessageId.ScSettlementSyncAll, settlements);
            session.Send(new PacketScSyncAllRoleScene(session));
            session.Send(new PacketScGameMechanicsSync(session));
            session.Send(new PacketScSyncAllBloc(session));
            session.Send(new PacketScSyncWallet(session));
            session.Send(new PacketScSyncAllGameVar(session));
            session.Send(new PacketScSyncAllUnlock(session));
            session.Send(new PacketScSyncAllBitset(session));
            session.Send(new PacketScSyncAllMiniGame(session));
           
            string json = File.ReadAllText("93_ScSceneMapMarkSync.json");
            ScSceneMapMarkSync chapter = Newtonsoft.Json.JsonConvert.DeserializeObject<ScSceneMapMarkSync>(json);
            session.Send(ScMessageId.ScSceneMapMarkSync, chapter);
            session.Send(new PacketScAdventureSyncAll(session));
            ScFactorySync fsync = new()
            {
                Stt = new()
                {
                    Layers =
                    {
                        new ScdFactorySttLayer()
                        {
                            Id="tech_group_tundra_quartz",
                            State=1,
                        }
                    },

                },
                FormulaMan = new()
                {
                    
                }
                
            };
            
            session.Send(ScMessageId.ScFactorySync, fsync);
            //session.Send(new PacketScFactorySync(session));
            session.Send(new PacketScFactorySyncScope(session));
            session.Send(new PacketScFactorySyncChapter(session, "domain_1"));
            session.Send(new PacketScFactorySyncChapter(session, "domain_2"));
            session.Send(new PacketScSyncCharBagInfo(session));
            session.Send(new PacketScSyncAllDialog(session));
            session.Send(new PacketScSpaceshipSync(session));
            session.Send(new PacketScSyncFullDungeonStatus(session));
            session.Send(new PacketScActivitySync(session));
            string json1 = File.ReadAllText("44_ScSyncAllMission.json");
            ScSyncAllMission m = Newtonsoft.Json.JsonConvert.DeserializeObject<ScSyncAllMission>(json1);
            
            session.Send(ScMessageId.ScSyncAllMission, m);
            session.Send(ScMessageId.ScSyncFullDataEnd, new ScSyncFullDataEnd());
            session.EnterScene();
            session.Initialized = true;
            session.Update();
            
            
        }
        static byte[] GenerateRandomBytes(int length)
        {
            using var rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[length];
            rng.GetBytes(bytes);
            return bytes;
        }
        static byte[] ConvertPemToBytes(string pem)
        {
            string base64Key = pem
                .Replace("-----BEGIN PUBLIC KEY-----", "")
                .Replace("-----END PUBLIC KEY-----", "")
                .Replace("\n", "")
                .Replace("\r", "");
            return Convert.FromBase64String(base64Key);
        }

        // Crittografare con RSA (PKCS#1)
        static byte[] EncryptWithRsa(byte[] data, byte[] publicKeyBytes)
        {
            var rsa = RSA.Create();
            rsa.ImportSubjectPublicKeyInfo(publicKeyBytes, out _);
            return rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
        }

    }
}
