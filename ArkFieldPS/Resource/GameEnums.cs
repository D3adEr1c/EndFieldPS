﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkFieldPS.Resource
{
    public enum MissionState : int// TypeDefIndex: 33630
    {
        None = 0,
        Available = 1,
        Processing = 2,
        Completed = 3,
        Failed = 4
    }
    public enum InteractiveComponentType
    {
        TriggerObserver = 0,
        Animator = 1,
        ElectricNode = 2,
        WireModel = 3,
        LinkEffectModel = 4,
        KeepRelativeOffset = 5,
        PhysicsBody = 7,
        PlayerInteract = 8,
        ModelScaler = 9,
        FactoryBuildingWrapper = 10,
        AbilitySystemForIntResource = 11,
        TravelLinkEffectModel = 12,
        AbilitySystemForInt = 13,
        DynamicModel = 14,
        ArtRefModel = 15,
        AddExtraBornTag = 16,
        PushableComponent = 18,
        TriggerObserverAllEntity = 19,
        RotatePlatform = 20,
        IntFacSoil = 21,
        Observer = 22,
        Scanable = 23,
        CoinPuzzle = 24,
        InteractHighlight = 26,
        DropItemBehaviour = 27,
        FactoryUnBuildableArea = 28,
        InteractiveLogicController = 29,
        BattleBuilding = 30,
        AirWall = 31,
        InteractiveMovement = 32,
        InteractiveRotate = 33,
        AbandonPackBehaviour = 34,
        AllowTeammateAssist = 35,
        InteractiveLogicStartArea = 36,
        CanBeBombed = 37,
        Hittable = 38,
        BelongToWaterVolume = 39,
        InteractiveAudio = 40,
        CurveMovePlatform = 41,
        SummonTeam = 42,
        InteractiveBehitPerform = 43,
        ExitPerformance = 44,
        MoveControlLogic = 45,
        CommonLuaUICall = 46,
        PlayerInteractPerform = 47,
        CanSetVisible = 48,
        BattleBaseCore = 49,
        ShowGuide = 50,
        ChangeTeammateAIMode = 51,
        StopRecordingLocation = 52
    }
    public enum ParamRealType
    {
        Invalid = 0,
        Bool = 1,
        BoolList = 2,
        Int = 3,
        IntList = 4,
        Float = 5,
        FloatList = 6,
        String = 7,
        StringList = 8,
        Path = 9,
        PathList = 10,
        Vector3 = 11,
        Vector3List = 12,
        EntityPtr = 13,
        EntityPtrList = 14,
        Tag = 15,
        TagList = 16,
        UInt = 17,
        UIntList = 18,
        FromContextCurrent = 19,
        FromContextMsg = 20,
        FromContextInteractive1 = 21,
        FromContextInteractive2 = 22,
        FromContextInteractive3 = 23,
        LevelScriptPtr = 24,
        LevelScriptPtrList = 25,
        UInt64 = 26,
        UInt64List = 27,
        LangKey = 28,
        LangKeyList = 29,
        Node = 30,
        NodeList = 31,
        Buff = 32,
        BuffList = 33,
        Bytes = 34,
        EventArgs = 35,
        ServerRegister1 = 36,
        ServerRegister2 = 37,
        ServerRegister3 = 38,
        ServerRegister4 = 39,
        ServerRegister5 = 40,
        ServerRegister6 = 41,
        CameraPosePtr = 42,
        CameraPosePtrList = 43,
        AirWallPtr = 44,
        AirWallPtrList = 45,
        LsmPtr = 46,
        LsmPtrList = 47,
        EnvironmentVolumePtr = 48,
        EnvironmentVolumePtrList = 49,
        SpawnerPtr = 50,
        SpawnerPtrList = 51,
        Int64 = 52,
        Int64List = 53,
        ScriptTaskPtr = 54,
        ScriptTaskPtrList = 55,
        WaterVolumePtr = 56,
        WaterVolumePtrList = 57,
        FunctionAreaPtr = 58,
        FunctionAreaPtrList = 59,
        E_NUM = 60
    }
    public enum SelfInfoReasonType // TypeDefIndex: 27123
    {
        SlrEnterScene = 0,
        SlrReviveDead = 1,
        SlrReviveRest = 2,
        SlrChangeTeam = 3,
        SlrReviveByItem = 4,
        SlrResetDungeon = 5,
        SlrSeamlesslyEnterScene = 6,
        SlrSeamlesslyTouchScene = 7
    }
    public enum TalentNodeType // TypeDefIndex: 33688
    {
        None = 0,
        CharBreak = 1,
        EquipBreak = 2,
        Attr = 3,
        PassiveSkill = 4,
        FactorySkill = 5
    }
    public enum GuideState // TypeDefIndex: 33634
    {
        None = 0,
        Processing = 1,
        KeyStepFinish = 2,
        Completed = 3
    }
    public enum AdventureTaskState // TypeDefIndex: 33702
    {
        None = 0,
        Processing = 1,
        Completed = 2,
        Rewarded = 3
    }
    public enum EntryState // TypeDefIndex: 24402
    {
        Empty = 0,
        DifferentMap = 1,
        SameMap = 2,
        LevelLoaded = 3,
        Invalid = 4
    }
    public enum AdventureTaskType // TypeDefIndex: 33687
    {
        None = 0,
        Daily = 1,
        AdventureBook = 2
    }
    public enum ItemStorageSpace // TypeDefIndex: 33575
    {
        None = 0,
        Isolate = 1,
        ValuableDepot = 2,
        BagAndFactoryDepot = 3
    }
    public enum ItemValuableDepotType : int // TypeDefIndex: 33573
    {
        Invalid = 0, //
        Weapon = 1,//
        WeaponGem = 2,//
        Equip = 3,//
        SpecialItem = 4,//
        MissionItem = 5,//
        Factory = 6,//
        HiddenItem = 7,//
        TDItem = 8,//
        TrialCharItem = 9,
        CommercialItem = 10
    }
    public enum ActorType // TypeDefIndex: 17934
    {
        None = 0,
        Character = 1,
        Interactive = 2,
        TmpObject = 3,
        Effect = 4
    }
    public enum ObjectType // TypeDefIndex: 24769
    {
        Invalid = 1,
        Character = 8,
        Enemy = 16,
        Interactive = 32,
        Projectile = 64,
        FactoryRegion = 128,
        Npc = 256,
        AbilityEntity = 512,
        CinematicEntity = 1024,
        RemoteFactoryEntity = 2048,
        Creature = 4096
    }
enum ParamValueType
{

    Invalid = 0,
    Bool = 1,
    BoolList = 2,
    Int = 3,
    IntList = 4,
    Float = 5,
    FloatList = 6,
    String = 7,
    StringList = 8,

}
public enum EntityDataType // TypeDefIndex: 24999
    {
        Character = 0,
        Enemy = 1,
        Interactive = 2,
        Npc = 3,
        AbilityEntity = 4,
        Count = 5
    }
    public enum ObjectTypeIndex // TypeDefIndex: 24768
    {
        Invalid = 0,
        Character = 3,
        Enemy = 4,
        Interactive = 5,
        Projectile = 6,
        FactoryRegion = 7,
        Npc = 8,
        AbilityEntity = 9,
        CinematicEntity = 10,
        RemoteFactoryEntity = 11,
        Creature = 12,
        Enum = 13
    }
    public enum ForbidType // TypeDefIndex: 18780
    {
        ForbidSetSquad = 0,
        ForbidFactoryMode = 1,
        ForbidUseItem = 2,
        NoLoot = 3,
        ForbidCharSkill = 4,
        ForbidCharLvUp = 5,
        ForbidCharStageBreak = 6,
        ForbidChangeWeapon = 7,
        ForbidWeaponLvUp = 8,
        ForbidWeaponLvBreakthrough = 9,
        ForbidChangeGem = 10,
        ForbidChangeEquip = 11,
        ForbidChangeEquipMedicine = 12,
        HideSquadIcon = 13,
        ForbidAttack = 14,
        ForbidSprint = 15,
        ForbidWeaponRefineUpgrade = 16,
        OnlyClientEndmin = 17,
        HideMissionHud = 18,
        ForbidUseItemType = 19,
        NoRepatriateDamage = 20,
        DisableSwitchMode = 21,
        ShowEmptySwitchModeBtn = 22,
        HideGeneralAbility = 23,
        ForbidBattleEnterExitBark = 24,
        EnumMax = 25
    }
    public enum ScopeName // TypeDefIndex: 33636
    {
        None = 0,
        Main = 1,
        Blackbox = 2,
        RpgDungeon = 4,
        Training = 8,
        All = 15
    }
    public enum GlobalAttributeType // TypeDefIndex: 23556
    {
        AtbRecover = 0,
        AtbGainEfficiency = 1,
        DashChargeCount = 2,
        DashRecover = 3,
        ExtraAtbEfficiencyNormalAttack = 4,
        ExtraAtbEfficiencyPowerAttack = 5,
        Enum = 6
    }
    public enum ScopeNameIndex // TypeDefIndex: 33635
    {
        Main = 0,
        Blackbox = 1,
        RpgDungeon = 2,
        Training = 3
    }
    public enum StatType // TypeDefIndex: 33663
    {
        None = 0,
        StatTest = 1,
        GemAttachNum = 2,
        UnlockTechNum = 3,
        TierLevelEquipProdeceNum = 4,
        MinerBuildNum = 5,
        ChestOpenNum = 6,
        DungeonSeriesCompleteNum = 7,
        EuqipSuitEffectNum = 8,
        ItemGainNum = 9,
        RacingPassNum = 10,
        GameCategoryPassNum = 11,
        EquipPutonNum = 12,
        CampRestNum = 13,
        ItemUseNum = 14,
        ChangeSceneGrade = 15,
        EquipMedicine = 16,
        DoodadTotalGot = 17,
        DoodadIdGot = 18,
        obtainCharNum = 19,
        GemForgeNum = 20,
        StatEnd = 499,
        DailyStatBegin = 500,
        DailyLogin = 501,
        DailyMissionComplete = 502,
        DailyStaminaCost = 503,
        DailyCharLevelUp = 504,
        DailyWeapeonLevelUp = 505,
        DailyCharSkillLevelUp = 507,
        DailyDungeonSeriesCompleteNum = 508,
        DailyEquipProduce = 509,
        DailyTraderOrderComplete = 510,
        DailySpaceshipShopBuy = 511,
        DailyDoodadTotalGot = 512,
        DailyManuallyWork = 513,
        DailyRacingPassNum = 514,
        DailyPresentGift = 515,
        DailyMonsterKillNum = 516,
        DailyGameCategoryPassNum = 517,
        DailyDoodadIdGot = 518,
        DailyStatEnd = 1000,
        WeeklyStatBegin = 1001,
        WeeklyStatEnd = 1500
    }
    public enum ServerGameVarEnum // TypeDefIndex: 33657
    {
        ServerGameVarCommonBegin = 100000,
        ServerTest1 = 100001,
        ServerTest2 = 100002,
        ServerGameVarAlreadySetGender = 100003,
        ServerGameVarEnhanceBean = 100004,
        ServerGameVarEnhanceBeanLastReplenishTime = 100005,
        ServerGameVarDashEnergyLimit = 100006,
        ServerGameVarAlreadySetName = 100007,
        ServerGameVarCommonEnd = 109999,
        ServerGameVarDailyRefreshBegin = 110000,
        RecoverApByMoneyCount = 110001,
        ServerGameVarDailyRefreshEnd = 119999,
        ServerGameVarWeeklyRefreshBegin = 120000,
        ServerGameVarWeeklyRefreshEnd = 129999,
        ServerGameVarMonthlyRefreshBegin = 130000,
        ServerGameVarMonthlyRefreshEnd = 139999
    }
    public enum ModifierType // TypeDefIndex: 33568
    {
        Addition = 0,
        Multiplier = 1,
        FinalAddition = 3,
        FinalMultiplier = 4,
        BaseAddition = 5,
        BaseMultiplier = 6,
        BaseFinalAddition = 7,
        BaseFinalMultiplier = 8,
        Enum = 9,
        None = 99999
    }
    public enum MailSubType // TypeDefIndex: 33718
    {
        Default = 0,
        Questionnaire = 1
    }
    public enum MailType // TypeDefIndex: 33549
    {
        Mail = 0,
        ItemCache = 1,
        SpItemCache = 2
    }
    public enum BitsetType // TypeDefIndex: 33649
    {
        None = 0,
        FoundItem = 1,
        Wiki = 2,
        UnreadWiki = 3,
        MonsterDrop = 4,
        GotItem = 5,
        AreaFirstView = 6,
        UnreadGotItem = 7,
        PRTS = 8,
        UnreadPRTS = 9,
        PRTSFirstLv = 10,
        PRTSTerminalContent = 11,
        LevelHaveBeen = 12,
        LevelMapFirstView = 13,
        UnreadFormula = 14,
        NewChar = 15,
        ElogChannel = 16,
        FMVWatched = 17,
        TimeLineWatched = 18,
        MapFilter = 19,
        FriendHasRequest = 20,
        EquipTechFormula = 21,
        RadioTrigger = 22,
        RemoteCommunicationFinish = 23,
        ChapterFirstView = 25,
        AdventureLevelRewardDone = 26,
        DungeonEntranceTouched = 27,
        EquipTechTier = 28,
        CharDoc = 30,
        CharVoice = 31,
        ReadingPop = 32,
        RewardIdDone = 33,
        PrtsInvestigate = 34,
        RacingReceivedBPNode = 35,
        RacingCompleteAchievement = 36,
        RacingReceivedAchievement = 37,
        NewSceneGradeUnlocked = 38,
        InteractiveActive = 39,
        MinePointFirstTimeCollect = 40,
        UnreadCharDoc = 41,
        UnreadCharVoice = 42,
        ItemSubmitRecycle = 43,
        AreaToastOnce = 44,
        UnreadEquipTechFormula = 45,
        PrtsInvestigateUnreadNote = 46,
        PrtsInvestigateNote = 47,
        GameMechanicRead = 48,
        ReadActiveBlackbox = 49,
        ReadLevel = 50,
        FactroyPlacedBuilding = 51,
        EnumMax = 52
    }
    
    public enum UnlockSystemType // TypeDefIndex: 33602
    {
        Map = 0,
        Inventory = 1,
        Watch = 2,
        ValuableDepot = 3,
        Shop = 4,
        CharTeam = 5,
        Gacha = 51,
        Dungeon = 52,
        BlocMission = 53,
        Mail = 54,
        Wiki = 55,
        PRTS = 56,
        SubmitEther = 57,
        Scan = 58,
        CharUI = 59,
        Friend = 60,
        DailyMission = 61,
        GeneralAbilityBomb = 62,
        GeneralAbilityFluidInteract = 63,
        GeneralAbility = 64,
        SNS = 65,
        EquipTech = 66,
        EquipProduce = 67,
        ItemSubmitRecycle = 68,
        DungeonFactory = 69,
        EnemySpawner = 70,
        FacBuildingPin = 101,
        FacCraftPin = 102,
        FacMode = 103,
        FacTechTree = 104,
        FacOverview = 105,
        FacYieldStats = 106,
        FacConveyor = 107,
        FacTransferPort = 108,
        FacBridge = 109,
        FacSplitter = 110,
        FacMerger = 111,
        FacBUS = 112,
        FacZone = 113,
        FacSystem = 114,
        FacPipe = 115,
        FacPipeSplitter = 116,
        FacPipeConnector = 117,
        FacPipeConverger = 118,
        FacHub = 119,
        ManualCraft = 201,
        ItemUse = 202,
        ItemQuickBar = 203,
        ProductManual = 204,
        Weapon = 251,
        Equip = 252,
        EquipEnhance = 253,
        NormalAttack = 301,
        NormalSkill = 302,
        UltimateSkill = 303,
        TeamSkill = 304,
        ComboSkill = 305,
        TeamSwitch = 306,
        Dash = 307,
        Jump = 308,
        SpaceshipPresentGift = 401,
        SpaceshipManufacturingStation = 402,
        SpaceshipControlCenter = 403,
        SpaceshipSystem = 404,
        SpaceshipGrowCabin = 405,
        SpaceshipShop = 406,
        Settlement = 501,
        RacingDungeon = 601,
        BattleTraining = 602,
        AdventureExpAndLv = 651,
        AdventureBook = 652,
        GuidanceManul = 661,
        AIBark = 670,
        CheckIn = 1113,
        None = 10000000
    }
    public enum AttributeType // TypeDefIndex: 33566
    {
        Level = 0,
        MaxHp = 1,
        Atk = 2,
        Def = 3,
        PhysicalDamageTakenScalar = 4,
        FireDamageTakenScalar = 5,
        PulseDamageTakenScalar = 6,
        CrystDamageTakenScalar = 7,
        Weight = 8,
        CriticalRate = 9,
        CriticalDamageIncrease = 10,
        Hatred = 11,
        NormalAttackRange = 12,
        MoveSpeedScalar = 13,
        TurnRateScalar = 14,
        AttackRate = 15,
        SkillCooldownScalar = 16,
        NormalAttackDamageIncrease = 17,
        HpRecoveryPerSec = 18,
        HpRecoveryPerSecByMaxHpRatio = 19,
        MaxPoise = 20,
        PoiseRecTime = 21,
        MaxUltimateSp = 22,
        DamageTakenScalarWithPoise = 23,
        PoiseDamageTakenScalar = 24,
        PoiseProtectTime = 25,
        PoiseDamageOutputScalar = 26,
        BreakingAttackDamageTakenScalar = 27,
        UltimateSkillDamageIncrease = 28,
        HealOutputIncrease = 29,
        HealTakenIncrease = 30,
        PoiseRecTimeScalar = 31,
        NormalSkillDamageIncrease = 32,
        ComboSkillDamageIncrease = 33,
        KnockDownTimeAddition = 34,
        FireBurstDamageIncrease = 35,
        PulseBurstDamageIncrease = 36,
        CrystBurstDamageIncrease = 37,
        NaturalBurstDamageIncrease = 38,
        Str = 39,
        Agi = 40,
        Wisd = 41,
        Will = 42,
        LifeSteal = 43,
        UltimateSpGainScalar = 44,
        AtbCostAddition = 45,
        SkillCooldownAddition = 46,
        ComboSkillCooldownScalar = 47,
        NaturalDamageTakenScalar = 48,
        IgniteDamageScalar = 49,
        PhysicalDamageIncrease = 50,
        FireDamageIncrease = 51,
        PulseDamageIncrease = 52,
        CrystDamageIncrease = 53,
        NaturalDamageIncrease = 54,
        EtherDamageIncrease = 55,
        FireAbnormalDamageIncrease = 56,
        PulseAbnormalDamageIncrease = 57,
        CrystAbnormalDamageIncrease = 58,
        NaturalAbnormalDamageIncrease = 59,
        EtherDamageTakenScalar = 60,
        DamageToBrokenUnitIncrease = 61,
        Enum = 62
    }
    public enum CODE // TypeDefIndex: 27682
    {
        ErrUnknown = -1,
        ErrSuccess = 0,
        ErrCommonBegin = 1,
        ErrCommonUidFailed = 2,
        ErrCommonAllocFailed = 3,
        ErrCommonParamInvalid = 4,
        ErrCommonMsgClosed = 5,
        ErrCommonMsgFrequencyBlocked = 6,
        ErrCommonSensitive = 7,
        ErrCommonGameModeForbid = 14,
        ErrCommonActionInvokeFailed = 15,
        ErrCommonSystemLocked = 16,
        ErrCommonServerOverload = 17,
        ErrCommonParamError = 18,
        ErrCommonEnd = 20,
        ErrKickSessionBegin = 30,
        ErrServerClosed = 31,
        ErrCommonServerVersionTooLow = 32,
        ErrCommonClientVersionNotEqual = 33,
        ErrCommonClientResVersionNotEqual = 34,
        ErrCommonGmkickSession = 35,
        ErrCommonGmkickRole = 36,
        ErrLoginMultipleSession = 37,
        ErrArchiveLoadFailed = 38,
        ErrLoginFirstPackage = 39,
        ErrLoginTokenInvalid = 40,
        ErrLoginMsgFormatInvalid = 41,
        ErrLoginProcessLogin = 42,
        ErrLoginSendMsg = 43,
        ErrCommonPlatformInvalid = 44,
        ErrKickMinorLimit = 45,
        ErrSessionTimeout = 46,
        ErrLuaScriptFailed = 47,
        ErrDbsaveFailed = 48,
        ErrGenShortIdFailed = 49,
        ErrMultipleCreateRole = 50,
        ErrMsgRateLimit = 51,
        ErrLoginQueueTimeout = 52,
        ErrLoginQueueFull = 53,
        ErrLoginButTransferringGs = 54,
        ErrTransferGsfailed = 55,
        ErrTransferWorkRoutineFailed = 56,
        ErrUnrecoverable = 57,
        ErrDuplicateSetGender = 58,
        ErrCreateRoleFailed = 59,
        ErrMigrateDbFailed = 60,
        ErrAfkTimeout = 61,
        ErrLoginLocUnmatch = 62,
        ErrCheckAreaWhiteListFailed = 63,
        ErrKickSessionEnd = 64,
        ErrAchieveBegin = 101,
        ErrAchieveAlreadyComplete = 102,
        ErrAchieveAlearyTakeReward = 103,
        ErrAchieveNotComplete = 104,
        ErrAchiveEnd = 109,
        ErrCharBagBegin = 110,
        ErrCharBagSetTeamFailed = 111,
        ErrCharBagFindTeamFailed = 112,
        ErrCharBagSetTeamButLeaderDead = 113,
        ErrCharBagTeamChanging = 114,
        ErrCharBagEnd = 119,
        ErrCharBegin = 120,
        ErrCharLevelUpLackItem = 121,
        ErrCharUnlockTalentNodeLackItem = 122,
        ErrCharCanNotUnlockTalentNode = 123,
        ErrCharBreakLevelLimit = 124,
        ErrCharLevelUpNeedBreak = 125,
        ErrCharLevelUpCanNotUseItem = 126,
        ErrCharLevelUpExpTypeNotMatch = 127,
        ErrCharBreakStageNotNext = 128,
        ErrCharNotFound = 129,
        ErrCharSkillUpLevelLimit = 130,
        ErrCharSkillUpLevelNotGeneric = 131,
        ErrCharIsDead = 132,
        ErrCharEnd = 133,
        ErrSceneBegin = 201,
        ErrSceneRoleNil = 202,
        ErrSceneRoleHasInWorld = 203,
        ErrSceneAllocFailed = 204,
        ErrSceneHasExist = 205,
        ErrSceneHasInTargetScene = 206,
        ErrSceneRoleNotExist = 207,
        ErrSceneRoleHasInScene = 209,
        ErrSceneCharNil = 210,
        ErrSceneCharHasInScene = 211,
        ErrSceneNameNotExist = 212,
        ErrSceneHostNotExist = 213,
        ErrSceneLevelNotExist = 214,
        ErrSceneLevelMonsterNotExist = 215,
        ErrSceneLevelMonsterExist = 216,
        ErrSceneLevelInteractiveExist = 217,
        ErrSceneRecordRepeated = 218,
        ErrSceneInteractivePropertyKeyNotExist = 219,
        ErrSceneAoiobjectExist = 220,
        ErrSceneAoiobjectPosError = 221,
        ErrSceneAoiobjectNotExist = 222,
        ErrSceneLevelNpcExist = 223,
        ErrSceneResNotFound = 224,
        ErrSceneLevelInteractiveNotExist = 225,
        ErrSceneInteractiveDuplicatedCollected = 226,
        ErrSceneNotImpl = 227,
        ErrSceneRoleChanging = 228,
        ErrSceneLevelNpcNotExist = 229,
        ErrSceneCharNotDead = 230,
        ErrSceneSpInteractiveOpErr = 231,
        ErrSceneInBattle = 232,
        ErrSceneTeleportPosInvalid = 233,
        ErrSceneAoiupdateFailed = 234,
        ErrSceneInteractiveTriggerCustomEventFailed = 235,
        ErrSceneLevelScriptEventRecursionDepth = 236,
        ErrSceneGradeModifyAtCoolDownTime = 237,
        ErrSceneGradeModifyNotUnlock = 238,
        ErrSceneGradeModifyProsperityNotEnough = 239,
        ErrSceneInteractivePropertyAccessDeny = 240,
        ErrSceneInteractiveTemplateNotExist = 241,
        ErrSceneLevelScriptAlreadyDone = 242,
        ErrSceneUpdateMonsterDecoFailed = 243,
        ErrSceneDecoMonsterFailed = 244,
        ErrSceneImplNotFound = 245,
        ErrSceneCheckPointInvalid = 246,
        ErrSceneDoodadPickBagSpaceNotEnough = 247,
        ErrSceneEnd = 300,
        ErrWalletBegin = 301,
        ErrMoneyNotEnough = 302,
        ErrMoneyChangeOutOfMax = 303,
        ErrMoneyChangeUndefineCombi = 304,
        ErrMoneyCannotCost = 305,
        ErrWalletEnd = 350,
        ErrItemBagBegin = 351,
        ErrItemBagItemNotEnough = 352,
        ErrItemBagBagSpaceNotEnough = 353,
        ErrItemBagDepotSpaceNotEnough = 354,
        ErrItemBagItemCanNotUse = 355,
        ErrItemBagBagGridIsFull = 356,
        ErrItemBagItemLocked = 357,
        ErrItemBagItemInstNotFound = 358,
        ErrItemBagItemCannotDiscard = 359,
        ErrItemBagItemCannotCost = 360,
        ErrItemBagItemNotFoundInDepot = 361,
        ErrItemBagAbandonReject = 362,
        ErrAdventureLevelNotEnough = 363,
        ErrItemBagBagAndDepotSpaceNotEnough = 364,
        ErrItemBagDepotSpaceNotEnoughByDumpFluid = 365,
        ErrItemBagBagOverflowToFactoryDepot = 366,
        ErrItemBagEnd = 400,
        ErrFactoryBegin = 501,
        ErrFactoryTimeExpired = 502,
        ErrFactorySttcanNotUnlock = 503,
        ErrFactoryProductManualCanNotUnlock = 504,
        ErrFactoryFormulaNotUnlock = 505,
        ErrFactoryNoMatchBuilding = 520,
        ErrFactoryOpFail = 521,
        ErrFactoryOpInvalid = 522,
        ErrFactoryOpResourceNotEnough = 523,
        ErrFactoryOpOverPlaceLimitBuilding = 524,
        ErrFactoryOpOverPlaceLimitNode = 525,
        ErrFactoryHubTransportRouteSetNotUnlockQuest = 527,
        ErrFactoryHubTransportRouteSetNotUnlockHub = 528,
        ErrFactoryHubTransportRouteSetNotUnlockTargetHub = 529,
        ErrFactoryHubTransportRouteReSetTargetDepotIsFull = 530,
        ErrFactoryOpHasNoBattery = 531,
        ErrFactoryOpLiquidNotEqual = 532,
        ErrFactoryOpMeshConflict = 533,
        ErrFactoryOpLiquidSewageCannotDump = 534,
        ErrFactoryOpOverPlaceLimitFluidConveyor = 535,
        ErrFactoryOpOverPlaceLimitFluidReapter = 536,
        ErrFactoryOpOverPlaceLimitFluidRouter = 537,
        ErrFactoryOpCannotMoveToDiffScene = 538,
        ErrFactoryEnd = 550,
        ErrMailBegin = 551,
        ErrMailNotExist = 552,
        ErrMailTimeExpired = 553,
        ErrMailEnd = 600,
        ErrDialogBegin = 601,
        ErrDialogInValid = 602,
        ErrDialogEnd = 610,
        ErrWeaponBegin = 700,
        ErrWeaponNotNeedBreakthrough = 701,
        ErrWeaponNotFound = 702,
        ErrWeaponRefineLvInvalid = 703,
        ErrWeaponResNotFound = 704,
        ErrWeaponRefineResNotFound = 705,
        ErrWeaponRefineCostInstIdInvalid = 706,
        ErrWeaponRefineCostItemNotFound = 707,
        ErrWeaponRefineCostWithGem = 708,
        ErrWeaponRefineCostWithChar = 709,
        ErrWeaponRefineCostNotEnough = 710,
        ErrWeaponRefineCostFailed = 711,
        ErrWeaponMaxLevel = 712,
        ErrWeaponNeedBreakthrough = 713,
        ErrWeaponAddExpCostInvalidItem = 714,
        ErrWeaponAddExpCostFailed = 715,
        ErrWeaponAddExpFailed = 716,
        ErrWeaponAddExpCostItSelf = 717,
        ErrWeaponEnd = 750,
        ErrRewardBegin = 751,
        ErrRewardInValid = 752,
        ErrRewardEnd = 760,
        ErrEquipBegin = 800,
        ErrEquipLvNotEnough = 801,
        ErrEquipNotFound = 802,
        ErrEquipCheckCostFailed = 803,
        ErrEquipCannotRecycle = 804,
        ErrEquipCostFailed = 805,
        ErrEquipEnhanceBeanNotEnough = 806,
        ErrEquipEnhancePartTypeNotEqual = 807,
        ErrEquipEnhanceLackOfResource = 808,
        ErrEquipTechIdInvalid = 809,
        ErrEquipPreTechNodeLocked = 810,
        ErrEquipTechCostItemNotEnough = 811,
        ErrEquipTechCostItemFailed = 812,
        ErrEquipTechUnlockFailed = 813,
        ErrEquipFormulaInvalid = 814,
        ErrEquipTechNodeLocked = 815,
        ErrEquipTechConfigInvalid = 816,
        ErrEquipMakeCostItemNotEnough = 817,
        ErrEquipMakeCostItemFailed = 818,
        ErrEquipMakeFailed = 819,
        ErrEquipRepeatedTech = 820,
        ErrEquipRedeemInvalidTicket = 821,
        ErrEquipRedeemInvalidRatio = 822,
        ErrEquipRedeemNotEnough = 823,
        ErrEquipRedeemCostTicketFailed = 824,
        ErrEquipRedeemTicketFailed = 825,
        ErrEquipNotInSafeZone = 826,
        ErrEquipEnd = 850,
        ErrBlocBegin = 851,
        ErrBlocNotFound = 852,
        ErrBlocLevelNotEnough = 853,
        ErrBlocRewardAlreadyTaken = 854,
        ErrBlocRewardIdNotExist = 855,
        ErrBlocShopNotFound = 856,
        ErrBlocShopGoodNotFound = 857,
        ErrBlocShopGoodSellOut = 858,
        ErrBlocEnd = 880,
        ErrDungeonBegin = 901,
        ErrDungeonStaminaNotEnough = 902,
        ErrDungeonIsNotPass = 903,
        ErrDungeonPassButNotGainReward = 904,
        ErrDungeonNotMetUnlockCond = 905,
        ErrDungeonRecoverApExceedsLimit = 906,
        ErrDungeonFullStaminaCapacity = 907,
        ErrDungeonEnd = 950,
        ErrNameBegin = 1000,
        ErrNameLengthIllegal = 1001,
        ErrNameIllegalChar = 1002,
        ErrNameSensitiveWord = 1003,
        ErrNameEmptyString = 1004,
        ErrNameLengthTooShort = 1005,
        ErrNameLengthTooLong = 1006,
        ErrNameCheckSensitiveFail = 1007,
        ErrNameAllMarkOrDigital = 1008,
        ErrNameAlreadySetName = 1009,
        ErrNameEnd = 1030,
        ErrFriendBegin = 1051,
        ErrFriendServerRequestFail = 1052,
        ErrFriendRepeatedSubmit = 1053,
        ErrFriendSendMsgTooFrequent = 1054,
        ErrFriendFriendListFull = 1055,
        ErrFriendTargetFriendListFull = 1056,
        ErrFriendInFriendList = 1057,
        ErrFriendNotInFriendList = 1058,
        ErrFriendTargetRequestListFull = 1059,
        ErrFriendInTargetRequestList = 1060,
        ErrFriendNotInRequestList = 1061,
        ErrFriendTargetNotExist = 1062,
        ErrFriendEnd = 1100,
        ErrMiniGameBegin = 1101,
        ErrMiniGameCompletedCheckFailed = 1102,
        ErrMiniGameEnd = 1110,
        ErrRpgdgdungeonIdInvalid = 1200,
        ErrRpgdgequipIdInvalid = 1201,
        ErrRpgdgcostNotEnough = 1202,
        ErrRpgdggoldNotEnough = 1203,
        ErrRpgdgcostItemFailed = 1204,
        ErrRpgdgaddItemFailed = 1205,
        ErrRpgdgequipNotFind = 1206,
        ErrRpgdgaddGoldFailed = 1207,
        ErrRpgdgequipSlotInvalid = 1208,
        ErrRpgdgputOnEquipFailed = 1209,
        ErrRpgdgabilitySelectInvalid = 1210,
        ErrRpgdgabilityLevelInvalid = 1211,
        ErrRpgdgabilityNotExist = 1212,
        ErrRpgdgnotInDungeon = 1213,
        ErrGemRecastRandomFailed = 1251,
        ErrSpaceshipNotInBase = 1252,
        ErrSpaceshipCanNotFoundChar = 1253,
        ErrSpaceshipHasPresentedGiftToday = 1254,
        ErrSpaceshipCanNotFoundRewardId = 1255,
        ErrSpaceshipNoCharPresentCnt = 1256,
        ErrSpaceshipNoCharRecvCnt = 1257,
        ErrSpaceshipPresentGiftToCharNotUnlock = 1258,
        ErrSpaceshipPhysicalStrengthNotEnoughToWork = 1259,
        ErrSpaceshipPhysicalStrengthTooHighToRest = 1260,
        ErrSpaceshipManufacturingStationNoProduct = 1261,
        ErrSpaceshipManufacturingStationFormulaIdInvalid = 1262,
        ErrSpaceshipManufacturingStationHasOtherFormulaProducing = 1263,
        ErrSpaceshipManufacturingStationOverLoad = 1264,
        ErrSpaceshipRoomIdInvalid = 1265,
        ErrSpaceshipBagNoSpaceToReciveGift = 1266,
        ErrSpaceshipFavIsFull = 1267,
        ErrSpaceshipRoomLevelNotEnoughToProduceFormula = 1268,
        ErrSnsinternalError = 1300,
        ErrSnsmomentRepeatedOption = 1301,
        ErrSnsmomentOptionInvalid = 1302,
        ErrSnsmomentNotExist = 1303,
        ErrSnschatNotExist = 1304,
        ErrSnsdialogNotExist = 1305,
        ErrSnsjumpContentFailed = 1306,
        ErrSnsdialogOptionFailed = 1307,
        ErrSnsmomentOptionTypeInvalid = 1308,
        ErrMissionTrackNotExist = 1351,
        ErrMissionCustomEventFailed = 1352,
        ErrTdinvalidId = 1401,
        ErrTdmoneyNotEnough = 1402,
        ErrTdbuyFailed = 1403,
        ErrTdgetConfigFailed = 1404,
        ErrTdcheckCurrIdfailed = 1405,
        ErrTdlockSettlementLv = 1406,
        ErrTdlockPreNode = 1407,
        ErrTdlockQuest = 1408,
        ErrTdinvalidBuildingId = 1409,
        ErrTdaddBuildingFailed = 1410,
        ErrTdinvalidScene = 1411,
        ErrTdcannotGetStronghold = 1412,
        ErrTdpickDropItemFailed = 1413,
        ErrTdpickDropInvalid = 1414,
        ErrTdclosed = 1415,
        ErrAdventureBookRewardNotMet = 1451,
        ErrAdventureBookRewardAlreadyTaken = 1452,
        ErrAdventureBookInvalidId = 1453,
        ErrAdventureHasNowRewardCanTake = 1454,
        ErrAdventureDailyActivationReachLimit = 1455,
        ErrGameMechanicsUnlocked = 1501,
        ErrGameMechanicsInCoolDown = 1502,
        ErrGameMechanicsStillInGame = 1503,
        ErrPrtsCanNotFinish = 1531,
        ErrGeneralAbilityAtCoolDownTime = 1541,
        ErrGeneralAbilityNotUnlocked = 1542,
        ErrRacingDungeonSystemLocked = 1561,
        ErrRacingDungeonLevelLocked = 1562,
        ErrRacingDungeonInvalidId = 1563,
        ErrRacingDungeonInvalidTactics = 1564,
        ErrRacingDungeonGetInvalidReward = 1565,
        ErrRacingDungeonAddRewardFailed = 1566,
        ErrRacingDungeonBpexpNotEnough = 1567,
        ErrRacingDungeonRewardRecived = 1568,
        ErrRacingDungeonRewardLocked = 1569,
        ErrRacingDungeonBpnotFound = 1570,
        ErrRacingDungeonInvalidAchievement = 1571,
        ErrRacingDungeonSetBitsetFailed = 1572,
        ErrRacingDungeonTacticsLocked = 1573,
        ErrRacingDungeonMechanicsCheckFailed = 1574,
        ErrRacingDungeonSceneError = 1575,
        ErrSubmitInvalid = 1600,
        ErrSubmitDuplicate = 1601,
        ErrSubmitNotMatch = 1602,
        ErrCurModeIsTargetMode = 1650,
        ErrSettlementManualSubmitInCd = 1651,
        ErrGachaPoolNotOpen = 1660,
        ErrGachaConsumeCostNotEnough = 1661,
        ErrGachaConsumeItemsCountNotMatch = 1662,
        ErrGachaPoolCloseByGm = 1663,
        ErrActivityNotFound = 1700,
        ErrActivityConfigNotFound = 1701,
        ErrActivityNotAvailable = 1702,
        ErrActivityNotMatch = 1703,
        ErrActivityCheckinAlreadyRewardAll = 1721,
        ErrActivityCheckinRewardNotEnough = 1722,
        ErrSensitiveCheckContentTooLong = 1730,
        ErrSensitiveCheckContentSpace = 1731
    }
}
