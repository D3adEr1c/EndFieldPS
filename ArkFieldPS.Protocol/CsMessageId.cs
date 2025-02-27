﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkFieldPS.Protocol
{
public enum CsMessageId : int
{
     CsMessageBegin = 0,
     CsLogin = 1,
     CsCreateRole = 2,
     CsLogout = 3,
     CsGmCommand = 4,
     CsPing = 5,
     CsFlushSync = 6,
     CsSetName = 7,
     CsSetGender = 8,
     CsCheckName = 9,
     CsCheckSensitive = 10,
     CsAchieveBegin = 20,
     CsAchieveComplete = 21,
     CsAchieveTakeReward = 22,
     CsAchieveEnd = 29,
     CsCharBagBegin = 30,
     CsCharBagTeamBegin = 31,
     CsCharBagSetTeam = 32,
     CsCharBagSetCurrTeamIndex = 33,
     CsCharBagSetTeamName = 34,
     CsCharBagSetTeamLeader = 35,
     CsCharBagTeamChangeFinish = 36,
     CsCharBagTeamEnd = 37,
     CsCharBagEnd = 39,
     CsCharBegin = 40,
     CsCharLevelUp = 41,
     CsCharSetNormalSkill = 43,
     CsCharSkillLevelUp = 45,
     CsCharSetTeamSkill = 46,
     CsCharPotentialUnlock = 47,
     CsCharEnd = 49,
     CsEquipBegin = 50,
     CsEquipPuton = 51,
     CsEquipPutoff = 52,
     CsEquipMedicineModify = 53,
     CsEquipRecycle = 54,
     CsEquipEnhance = 55,
     CsEquipProduce = 57,
     CsEquipEnd = 59,
     CsSceneBegin = 80,
     CsEnterScene = 81,
     CsMoveObjectMove = 82,
     CsSceneSetLastRecordCampid = 83,
     CsSceneInteractiveEventTrigger = 84,
     CsSceneSetVar = 85,
     CsSceneRest = 86,
     CsSceneLoadFinish = 88,
     CsSceneSetSafeZone = 95,
     CsSceneQueryEntityExist = 96,
     CsSceneQueryInteractiveProperty = 97,
     CsSceneSetTrackPoint = 99,
     CsSceneInteractTree = 100,
     CsSceneStaticMapMarkUpdate = 101,
     CsSceneTeleport = 103,
     CsSceneMoveStateSet = 104,
     CsSceneSubmitItem = 105,
     CsSceneSubmitEther = 106,
     CsSceneSetLevelScriptActive = 107,
     CsSceneLevelScriptEventTrigger = 109,
     CsSceneCommitLevelScriptCacheStep = 110,
     CsSceneRepatriate = 115,
     CsSceneInteractSpInteractive = 116,
     CsSceneSetLastSafeZone = 117,
     CsSceneSetBattle = 118,
     CsSceneRevival = 119,
     CsSceneSetLevelScriptStart = 120,
     CsSceneMonsterSpawnerBeginWave = 121,
     CsSceneSpawnSummon = 122,
     CsSceneLeavePlane = 123,
     CsSceneGradeModify = 124,
     CsSceneUpdateScriptTaskProgress = 125,
     CsSceneTeleportFinish = 126,
     CsSceneSetStorySafeZone = 127,
     CsSceneSubmitRecycle = 128,
     CsSceneEnd = 199,
     CsFactoryBegin = 200,
     CsFactorySttUnlockNode = 201,
     CsFactorySttUnlockLayer = 202,
     CsFactoryManuallyWorkExec = 211,
     CsFactoryProductManualUnlock = 212,
     CsFactoryQuickbarSetOne = 215,
     CsFactoryQuickbarMoveOne = 216,
     CsFactorySoilReclaim = 217,
     CsFactorySoilWater = 218,
     CsFactorySoilCancel = 219,
     CsFactorySoilHarvest = 220,
     CsFactorySoilFarmlandLevelUp = 221,
     CsFactoryHubWorkshopMake = 222,
     CsFactoryHubTransportRouteSet = 223,
     CsFactoryHubTransportRouteReset = 224,
     CsFactoryHubTransportRouteRestart = 225,
     CsFactoryHsFb = 232,
     CsFactoryStatisticSetBookmarkItemIds = 234,
     CsFactoryStatisticRequire = 235,
     CsFactoryPinSet = 236,
     CsFactoryOp = 251,
     CsFactoryObserverOp = 268,
     CsFactoryEnd = 269,
     CsWeaponBegin = 270,
     CsWeaponPuton = 271,
     CsWeaponBreakthrough = 273,
     CsWeaponAddExp = 274,
     CsWeaponAttachGem = 275,
     CsWeaponDetachGem = 276,
     CsWeaponRefineUpgrade = 277,
     CsWeaponEnd = 279,
     CsWikiBegin = 290,
     CsUnlockWiki = 291,
     CsMarkWikiRead = 292,
     CsWikiEnd = 299,
     CsMissionBegin = 310,
     CsFailMission = 311,
     CsTrackMission = 313,
     CsStopTrackingMission = 314,
     CsUpdateQuestObjective = 315,
     CsAcceptMission = 316,
     CsRollBlocMission = 317,
     CsMissionEventTrigger = 318,
     CsMissionClientTriggerDone = 319,
     CsSetNewMissionTagDone = 320,
     CsMissionEnd = 329,
     CsGuideBegin = 330,
     CsCompleteGuideGroupKeyStep = 331,
     CsCompleteGuideGroup = 332,
     CsGuideEnd = 339,
     CsDialogBegin = 340,
     CsFinishDialog = 341,
     CsDialogEnd = 349,
     CsBlocBegin = 350,
     CsBlocTakeLevelReward = 351,
     CsBlocShopBuy = 352,
     CsBlocEnd = 360,
     CsDungeonBegin = 370,
     CsEnterDungeon = 371,
     CsRestartDungeon = 372,
     CsLeaveDungeon = 373,
     CsDungeonRecoverAp = 375,
     CsDungeonTouchEntrance = 377,
     CsDungeonEnd = 378,
     CsEnterTrainDungeon = 379,
     CsGameMechanicsBegin = 380,
     CsGameMechanicsReqActive = 381,
     CsGameMechanicsReqReward = 382,
     CsGameMechanicsNtfInstPrepareFinish = 383,
     CsGameMechanicsEnd = 399,
     CsMailBegin = 400,
     CsGetMail = 401,
     CsReadMail = 402,
     CsDeleteMail = 403,
     CsDeleteAllMail = 404,
     CsGetMailAttachment = 405,
     CsGetAllMailAttachment = 406,
     CsMarkStarMail = 407,
     CsMailEnd = 419,
     CsRedDotBegin = 430,
     CsRemoveItemNewTags = 431,
     CsRedDotReadFormula = 432,
     CsRedDotReadCharDoc = 433,
     CsRedDotReadCharVoice = 434,
     CsRedDotReadEquipFormula = 435,
     CsRedDotEnd = 440,
     CsPrtsBegin = 441,
     CsPrtsMarkRead = 442,
     CsPrtsMarkTerminalRead = 443,
     CsPrtsRichContentRead = 444,
     CsPrtsFinishInvestigate = 445,
     CsPrtsEnd = 449,
     CsBitsetBegin = 480,
     CsBitsetAdd = 481,
     CsBitsetRemove = 482,
     CsBitsetRemoveAll = 483,
     CsBitsetEnd = 499,
     CsMergeMsg = 500,
     CsPayBegin = 510,
     CsCreateOrder = 511,
     CsPayEnd = 529,
     CsFriendBegin = 530,
     CsFriendRequestSubmit = 531,
     CsFriendRequestReject = 532,
     CsFriendRequestAccept = 533,
     CsFriendDelete = 534,
     CsFriendSearchName = 535,
     CsFriendRequestListSync = 536,
     CsFriendListSync = 537,
     CsFriendEnd = 570,
     CsWalletBegin = 600,
     CsMoneyChange = 601,
     CsWalletEnd = 630,
     CsGameVarBegin = 631,
     CsUpdateClientGameVar = 632,
     CsGameVarEnd = 640,
     CsMiniGameBegin = 641,
     CsCompleteMiniGame = 642,
     CsMiniGameEnd = 650,
     CsRpgDungeonBegin = 651,
     CsRpgDungeonBuy = 652,
     CsRpgDungeonSell = 653,
     CsRpgDungeonEquipPuton = 654,
     CsRpgDungeonEquipPutoff = 655,
     CsRpgDungeonPickLvAbility = 656,
     CsRpgDungeonTimeStop = 657,
     CsRpgDungeonAbilityChange = 658,
     CsRpgDungeonEnd = 700,
     CsGemBegin = 801,
     CsGemRecast = 802,
     CsGemEnd = 820,
     CsSnsBegin = 701,
     CsSnsGetList = 702,
     CsSnsMomentOption = 703,
     CsSnsChatDialogOption = 704,
     CsSnsMomentRead = 705,
     CsSnsFinishDialog = 706,
     CsSnsReadDialog = 707,
     CsSnsEnd = 730,
     CsSpaceshipBegin = 751,
     CsSpaceshipBuildRoom = 752,
     CsSpaceshipLevelUpRoom = 753,
     CsSpaceshipStationChar = 754,
     CsSpaceshipStationCharChangeWorkState = 755,
     CsSpaceshipPresentGiftToChar = 756,
     CsSpaceshipRecvGiftFromChar = 757,
     CsSpaceshipManufacturingBegin = 771,
     CsSpaceshipManufacturingStationStart = 772,
     CsSpaceshipManufacturingStationCollect = 775,
     CsSpaceshipManufacturingStationCancel = 776,
     CsSpaceshipManufacturingStationChangeOrder = 777,
     CsSpaceshipManufacturingEnd = 785,
     CsSpaceshipGrowCabinBegin = 786,
     CsSpaceshipGrowCabinBreed = 787,
     CsSpaceshipGrowCabinSow = 788,
     CsSpaceshipGrowCabinHarvest = 789,
     CsSpaceshipGrowCabinCancel = 790,
     CsSpaceshipGrowCabinClearPreviewRecipe = 791,
     CsSpaceshipGrowCabinEnd = 799,
     CsSpaceshipEnd = 800,
     CsTdBegin = 821,
     CsTdGetTdList = 822,
     CsTdStart = 823,
     CsTdLeave = 825,
     CsTdBuyBuilding = 826,
     CsTdPickDropItem = 827,
     CsTdDropExpired = 828,
     CsTdEnd = 899,
     CsBuffBegin = 900,
     CsBattleOp = 901,
     CsDevClearBattleInfo = 902,
     CsBuffEnd = 950,
     CsSkillBegin = 960,
     CsCastSkill = 961,
     CsCastSkillEnd = 962,
     CsCastSkillEffect = 963,
     CsSkillEnd = 999,
     CsItemBagBegin = 1000,
     CsItemBagTidyInBag = 1001,
     CsItemBagMoveInBag = 1002,
     CsItemBagSplitInBag = 1003,
     CsItemBagFactoryDepotToBag = 1004,
     CsItemBagBagToFactoryDepot = 1005,
     CsItemBagFactoryDepotToBagGrid = 1006,
     CsItemBagUseItem = 1007,
     CsItemBagSetQuickBar = 1008,
     CsItemBagSetQuickBarPos = 1009,
     CsItemBagSetItemLock = 1010,
     CsItemBagAbandonInBag = 1011,
     CsItemBagDestroyInDepot = 1012,
     CsItemBagDestroyInFactoryDepot = 1013,
     CsItemBagDumpBottleInBag = 1014,
     CsItemBagDumpBottleInFactoryDepot = 1015,
     CsItemBagTakeoutLostAndFound = 1031,
     CsItemBagUseItemCase = 1032,
     CsItemBagChgSpaceshipChapter = 1033,
     CsItemBagEnd = 1049,
     CsSettlementBegin = 1050,
     CsSettlementSelectRequire = 1051,
     CsSettlementSetOfficer = 1052,
     CsSettlementSetSubmitMode = 1053,
     CsSettlementSubmitRequire = 1054,
     CsSettlementEnd = 1099,
     CsShopBegin = 1100,
     CsShopBuy = 1111,
     CsShopSwapMoney = 1112,
     CsShopEnd = 1149,
     CsAdventureBegin = 1150,
     CsAdventureTakeRewardAll = 1151,
     CsAdventureEnd = 1179,
     CsAdventureBookBegin = 1250,
     CsTakeAllAdventureTaskReward = 1251,
     CsTakeAdventureTaskReward = 1252,
     CsTakeAdventureBookStageReward = 1253,
     CsAdventureBookEnd = 1299,
     CsTalentBegin = 1300,
     CsCharUnlockTalentNode = 1301,
     CsTalentEnd = 1329,
     CsRacingDungeonBegin = 1330,
     CsRacingDungeonBattlePassReceiveReward = 1332,
     CsRacingDungeonGetBattlePass = 1333,
     CsRacingDungeonGetAchievement = 1334,
     CsRacingDungeonAchievementReceiveReward = 1335,
     CsRacingDungeonLeave = 1336,
     CsRacingDungeonUpdateBattleInfo = 1337,
     CsRacingDungeonEnd = 1400,
     CsTrialCharacterBegin = 1401,
     CsUseTrialCharacterEquipMedicine = 1402,
     CsTrialCharacterEnd = 1403,
     CsGachaBegin = 1431,
     CsGachaSinglePullReq = 1432,
     CsGachaTenPullReq = 1433,
     CsGachaEnd = 1450,
     CsGameTimeFreezeBegin = 1451,
     CsGameTimeFreezeStartReq = 1452,
     CsGameTimeFreezeEndReq = 1453,
     CsGameTimeFreezeEnd = 1460,
     CsActivityBegin = 1461,
     CsDailyCheckin = 1471,
     CsActivityEnd = 1510,
     CsMessageEnd = 4095,

}
}
