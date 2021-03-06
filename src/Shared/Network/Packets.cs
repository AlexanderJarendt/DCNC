﻿using System.Reflection;

// ReSharper disable UnusedMember.Global

namespace Shared.Network
{
    public static class Packets
    {
        // Server -> Client
        public const ushort ErrorAck = 1;

        //public const ushort AreaListAck = 14;
        public const ushort UserAuthAck = 22;

        public const ushort ServerMessageAck = 25;

        public const ushort GameSettingsAck = 30;
        public const ushort CheckInLobbyAck = 42;
        public const ushort LobbyTimeAck = 47;
        public const ushort UserInfoAck = 61;
        public const ushort CharInfoAck = 62;
        public const ushort CheckCharNameAck = 81;
        public const ushort CreateCharAck = 83;
        public const ushort DeleteCharAck = 84;
        public const ushort BuyCarAck = 86;
        public const ushort SellCarAck = 88;
        public const ushort SelectCarAck = 90;
        public const ushort CheckInGameAck = 121;
        public const ushort LoadCharThreadAck = 124;
        public const ushort JoinChannelAck = 126;
        public const ushort ChatMsgAck = 147;
        public const ushort ChasePropose = 186;
        public const ushort FriendListAck = 231;
        public const ushort TutorialClearAck = 261;
        public const ushort QuestStartAck = 263;
        public const ushort QuestCompleteAck = 265;
        public const ushort QuestRewardAck = 267;
        public const ushort QuestGiveUpAck = 271;
        public const ushort MyQuestListAck = 273;

        public const ushort FriendStatus = 274;

        public const ushort JoinAreaAck = 301;
        
        public const ushort CharUpdateAck = 361;

        public const ushort ItemListAck = 401;
        public const ushort ItemModListAck = 402;
        public const ushort BuyItemAck = 406;
        public const ushort SellItemAck = 408;

        public const ushort RoomNotifyChangeAck = 467;

        public const ushort UdpTimeSyncAck = 540;
        public const ushort MoveVehicleAck = 542;
        public const ushort EnterAreaAck = 563;

        public const ushort WeatherAck = 640;

        public const ushort GameCharInfoAck = 661;

        public const ushort AreaStatusAck = 683;
        public const ushort UdpCastTcsAck = 701;
        public const ushort UdpCastTcsSignalAck = 706;
        public const ushort FuelChargeRes = 724;
        public const ushort StatUpdateAck = 760;
        public const ushort AreaListAck = 781;
        public const ushort MyCityPositionAck = 783; // MyPositionAck
        public const ushort GetDateTimeAck = 785;
        public const ushort GateListAck = 789; // GateListAck
        public const ushort PlayerInfoOldAck = 802;
        public const ushort MyTeamInfoAck = 841;
        public const ushort CreateTeamAck = 843;
        public const ushort CheckTeamNameAck = 852;
        public const ushort InstantStartAck = 993;
        public const ushort InstantGiveUpAck = 1000;
        public const ushort InstantGoalPlaceAck = 1002;
        public const ushort VisualUpdateAck = 1061;
        public const ushort BuyVisualItemThreadAck = 1204;
        public const ushort GetMyHancoinAck = 1401;
        //public const ushort VisualItemListAck = 1801;
        public const ushort VisualItemListAck = 1201;

        public const ushort CityLeaveCheckAck = 3201;
        
        public const ushort UnknownSyncAck = 3918;

        // 4010 -> Ranking Racing Team Info
        // 4001 -> Ranking Gameplay
        public const ushort RankingGameplayAck = 4001;

        public const ushort RankingRacingTeamInfoAck = 4010;

        // Client -> Server
        public const ushort CmdPing = 2;

        public const ushort CmdGlobalTime = 3;
        public const ushort CmdLatency = 4;
        public const ushort CmdLog = 5;
        public const ushort CmdServerPing = 6;
        public const ushort CmdNullPing = 7;
        public const ushort CmdUserAuth__ = 10;
        public const ushort CmdUserAuth = 20;
        public const ushort CmdUserAuth2 = 21;
        public const ushort CmdServerMessage = 24;
        public const ushort CmdCheckInLobby = 41;
        public const ushort CmdCheckOutLobby = 43;
        public const ushort CmdClientAuth = 44;
        public const ushort CmdLobbyChat = 45;
        public const ushort CmdLobbyTime = 46;
        public const ushort CmdDeleteChar = 50;
        public const ushort CmdUserInfo = 60;
        public const ushort CmdGetImage = 64;
        public const ushort CmdPushImageData = 67;
        public const ushort CmdStickerUpload = 71;
        public const ushort CmdStickerList = 73;
        public const ushort CmdStickerSmallImage = 75;
        public const ushort CmdStickerReportAttach = 76;
        public const ushort CmdStickerSearch = 77;
        public const ushort CmdCheckCharName = 80;

        public const ushort CmdCreateChar = 82;

        //public const ushort CmdDeleteChar = 84;
        public const ushort CmdBuyCar = 85;

        public const ushort CmdSellCar = 87;
        public const ushort CmdSelectCar = 89;
        public const ushort CmdUpgradeCarThread = 91;
        public const ushort CmdStickerNameCheck = 93;
        public const ushort CmdDeleteStickerCatalog = 95;
        public const ushort CmdChannelList = 100;
        public const ushort CmdChannelInfo = 102;
        public const ushort CmdCheckInGame = 120;
        public const ushort CmdCheckOutGame = 122;
        public const ushort CmdLoadCharThread = 123;
        public const ushort CmdJoinChannel = 125;
        public const ushort CmdLeaveChannel = 127;
        public const ushort CmdLoadDummyChar = 129;
        public const ushort CmdGameStream = 130;
        public const ushort CmdMailSet = 133;
        public const ushort CmdGetMail = 134;
        public const ushort CmdCheckEvent = 135;
        public const ushort CmdOpenChat = 140;
        public const ushort CmdCloseChat = 141;
        public const ushort CmdJoinChat = 142;
        public const ushort CmdLeaveChat = 144;
        public const ushort CmdChatMsg = 146;
        public const ushort CmdWhisper = 148;
        public const ushort CmdPrivateChatMsg = 149;
        public const ushort CmdRecommendFriend = 152;
        public const ushort CmdReqCouponItem = 157;
        public const ushort CmdCarPos = 160;
        public const ushort CmdSaveCarPos = 162;
        public const ushort CmdDormantAccept = 171;
        public const ushort CmdChaseBegin = 180;
        public const ushort CmdChaseEnd = 183;
        public const ushort CmdChaseProgress = 185;
        public const ushort CmdChaseHit = 187;
        public const ushort CmdChaseRequest = 189;
        public const ushort CmdHuvReq = 190;
        public const ushort CmdHuvHit = 192;
        public const ushort CmdHuvParam = 194;
        public const ushort CmdHuvTimeBonus = 196;
        public const ushort CmdBattleReq = 200;
        public const ushort CmdBattleEnd = 203;
        public const ushort CmdRegisterChannelAdmin = 220;
        public const ushort CmdBlockDel = 223;
        public const ushort CmdBlockAddByName = 226;
        public const ushort CmdPartyPreCheck = 228;
        public const ushort CmdFriendList = 230;
        public const ushort CmdFriendAddByName = 232;
        public const ushort CmdFriendDel = 235;
        public const ushort CmdFriendRequest = 239;
        public const ushort CmdPartyInvite = 240;
        public const ushort CmdPartyReject = 241;
        public const ushort CmdPartyJoin = 242;
        public const ushort CmdPartyLeave = 244;
        public const ushort CmdPartyBanish = 245;
        public const ushort CmdPartyApply = 246;
        public const ushort CmdPartyAccept = 247;
        public const ushort CmdUnderCityStage = 250;
        public const ushort CmdUnderCitySuggest = 252;
        public const ushort CmdUnderCityAgree = 253;
        public const ushort CmdUnderCityReject = 254;
        public const ushort CmdExitUnderCity = 257;
        public const ushort CmdTutorialClear = 260;
        public const ushort CmdQuestStart = 262;
        public const ushort CmdQuestComplete = 264;
        public const ushort CmdQuestReward = 266;
        public const ushort CmdQuestFail = 268;
        public const ushort CmdQuestGiveUp = 270;
        public const ushort CmdMyQuestList = 272;
        public const ushort CmdQuestGoalPlace = 274;
        public const ushort CmdJoinArea = 300;
        public const ushort CmdLeaveArea = 302;
        public const ushort CmdArbeitList = 321;
        public const ushort CmdArbeitStart = 323;
        public const ushort CmdArbeitReward = 325;
        public const ushort CmdArbeitGiveUp = 329;
        public const ushort CmdArbeitGoalPlace = 331;
        public const ushort CmdArbeitReady = 335;
        public const ushort CmdArbeitGo = 337;
        public const ushort CmdArbeitRankList = 339;
        public const ushort CmdItemList = 400;
        public const ushort CmdDropItem = 403;
        public const ushort CmdBuyItem = 405;
        public const ushort CmdSellItem = 407;
        public const ushort CmdEquipItem = 409;
        public const ushort CmdUnEquipItem = 411;
        public const ushort CmdUpgradeItem = 413;
        public const ushort CmdItemUnion = 415;
        public const ushort CmdItemUse = 417;
        public const ushort CmdItemUseEx = 419;
        public const ushort CmdPackItem = 422;
        public const ushort CmdUnPackItem = 424;
        public const ushort CmdModifyItem = 426;
        public const ushort CmdCombiItem = 428;
        public const ushort CmdUpgradeItemDouble = 430;
        public const ushort CmdReplenishItem = 432;
        public const ushort CmdCheckStat = 434;
        public const ushort CmdRepairItem = 435;
        public const ushort CmdRegisterRoomObserver = 440;
        public const ushort CmdUnregisterRoomObserver = 442;
        public const ushort CmdRoomDirectJoin = 443;
        public const ushort CmdRoomSecureJoin = 444;
        public const ushort CmdRoomIdDirectJoin = 445;
        public const ushort CmdInviteeList = 450;
        public const ushort CmdGetRoomInfo = 457;
        public const ushort CmdRoomCreate = 460;
        public const ushort CmdRoomList = 463;
        public const ushort CmdRoomInvite = 465;
        public const ushort CmdRoomJoin = 468;
        public const ushort CmdRoomLeave = 469;
        public const ushort CmdRoomBanish = 470;
        public const ushort CmdChannelRoomJoin = 471;
        public const ushort CmdChannelRoomSecureJoin = 472;
        public const ushort CmdSecureJoinObs = 473;
        public const ushort CmdSwitchToObs = 475;
        public const ushort CmdSwitchToPlayer = 476;
        public const ushort CmdSecureSwitchToPlayer = 477;
        public const ushort CmdJoinObs = 478;
        public const ushort CmdLeaveObs = 480;
        public const ushort CmdPvpReadyState = 485;
        public const ushort CmdPvpStartReq = 486;
        public const ushort CmdPvpLoadingStatus = 488;
        public const ushort CmdPvpLoadComplete = 489;
        public const ushort CmdPvpEnd = 491;
        public const ushort CmdPvpGate = 493;
        public const ushort CmdTradeOpen = 500;
        public const ushort CmdTradeProposeAck = 503;
        public const ushort CmdTradeItemOn = 504;
        public const ushort CmdTradeItemOff = 506;
        public const ushort CmdTradeLock = 508;
        public const ushort CmdTradeClose = 510;
        public const ushort CmdTradeComplete = 512;
        public const ushort CmdSetGameMode = 520;
        public const ushort CmdUdpTimeSync = 540;
        public const ushort CmdMoveVehicle = 541;
        public const ushort CmdJumpFreeTrafficVehicle = 544;
        public const ushort CmdMoveVehiclePlus = 546;
        public const ushort CmdMoveFreeTrafficVehicle = 547;
        public const ushort CmdJumpVehicle = 549;
        public const ushort CmdRemoveVehicle = 550;
        public const ushort CmdEnterArea = 562;
        public const ushort CmdExitArea = 564;
        public const ushort CmdEnterGroup = 566;
        public const ushort CmdExitGroup = 567;
        public const ushort CmdSetAreaMap = 568;
        public const ushort CmdBlockList = 569;
        public const ushort CmdClearAreaMap = 570;
        public const ushort CmdAreaChat = 571;
        public const ushort CmdGroupCombo = 572;
        public const ushort CmdRequestCar = 573;
        public const ushort CmdGroupComboReset = 575;
        public const ushort CmdReplaceCar = 576;
        public const ushort CmdMyAuctionList = 580;
        public const ushort CmdAuctionOn = 582;
        public const ushort CmdAuctionCancel = 584;
        public const ushort CmdAuctionComplete = 586;
        public const ushort CmdAuctionList = 588;
        public const ushort CmdAuctionBuy = 592;
        public const ushort CmdAuctionSearch = 595;
        public const ushort CmdRoomModify = 620;
        public const ushort CmdRoomChangeTeam = 623;
        public const ushort CmdGameCharInfo = 660;
        public const ushort CmdGameCharInfoEx = 662;
        public const ushort CmdUdpSync = 681;
        public const ushort CmdAreaStatus = 682;
        public const ushort CmdAllAreaStatus = 684;
        public const ushort CmdUdpCastTraffic = 700;
        public const ushort CmdUdpCastTcs = 702;
        public const ushort CmdUdpFlushCast = 704;
        public const ushort CmdRegisterAgent = 705;
        public const ushort CmdUdpCastTcsSignal = 707;
        public const ushort CmdGroupTcs = 710;
        public const ushort CmdGroupTcsSignal = 711;
        public const ushort CmdGroupUpdate = 712;
        public const ushort CmdObjectUpdate = 720;
        public const ushort CmdDriveInfoUpdate = 721;
        public const ushort CmdFuelChargeReq = 723;
        public const ushort CmdTrafficItemEvent = 740;
        public const ushort CmdAreaList = 780;
        public const ushort CmdFirstPosition = 782;
        public const ushort CmdGetDateTime = 784;
        public const ushort CmdQuestPosition = 786;
        public const ushort CmdMyCityPosition = 788;
        public const ushort CmdPlayerInfoReq = 801;
        public const ushort CmdSetVisualItem = 805;
        public const ushort CmdSilentMove = 821;
        public const ushort CmdObserveMode = 822;
        public const ushort CmdSetTeamMark = 830;
        public const ushort CmdGetTeamMark = 832;
        public const ushort CmdSetTeamUrl = 834;
        public const ushort CmdMyTeamInfo = 840;
        public const ushort CmdCreateTeam = 842;
        public const ushort CmdCloseTeam = 844;
        public const ushort CmdLeaveTeam = 848;
        public const ushort CmdDelegateTeamMaster = 850;
        public const ushort CmdCheckTeamName = 851;
        public const ushort CmdCancelCloseTeam = 853;
        public const ushort CmdTeamMembers = 855;
        public const ushort CmdCharTeamInfo = 858;
        public const ushort CmdCBattleInfo = 860;
        public const ushort CmdGetCBattleTime = 862;
        public const ushort CmdCheckTeamUrl = 868;
        public const ushort CmdJoinTeamApplyByName = 870;
        public const ushort CmdJoinTeamApply = 871;
        public const ushort CmdJoinTeamConfirm = 872;
        public const ushort CmdLeaveTeamRequest = 873;
        public const ushort CmdLeaveTeamConfirm = 874;
        public const ushort CmdBanishTeamMember = 875;
        public const ushort CmdRejectTeamApply = 876;
        public const ushort CmdCBattleRoomCreate = 880;
        public const ushort CmdCBattleRoomJoin = 881;
        public const ushort CmdEnterCBattleChannel = 882;
        public const ushort CmdExitCBattleChannel = 883;
        public const ushort CmdAssignTeamRank = 884;
        public const ushort CmdCBattleRoomReady = 900;
        public const ushort CmdCBattleInstance = 903;
        public const ushort CmdCBattleSet = 906;
        public const ushort CmdCBattleJoinObs = 907;
        public const ushort CmdCBattleItems = 908;
        public const ushort CmdCBattleGetSetting = 910;
        public const ushort CmdObserverSupport = 916;
        public const ushort CmdInstantRequest = 990;
        public const ushort CmdInstantStart = 992;
        public const ushort CmdInstantComplete = 994;
        public const ushort CmdInstantGiveUp = 999;
        public const ushort CmdInstantGoalPlace = 1001;
        public const ushort CmdUpdateCouponForVar = 1010;
        public const ushort CmdGetCouponForVar = 1011;
        public const ushort CmdGetCouponStampList = 1013;
        public const ushort CmdMarkCoupon = 1015;
        public const ushort CmdOpenCoupon = 1017;
        public const ushort CmdGetCoupon = 1019;
        public const ushort CmdImageRequest = 1080;
        public const ushort CmdImageSave = 1082;
        public const ushort CmdEnterRushZone = 1110;
        public const ushort CmdExitRushZone = 1112;
        public const ushort CmdRushHitPoint = 1114;
        public const ushort CmdNotifyRushHuv = 1118;
        public const ushort CmdCastRushEvent = 1122;
        public const ushort CmdRushObjectUpdate = 1123;
        public const ushort CmdRequestSwitchRushHuv = 1125;
        public const ushort CmdMita500Get = 1151;
        public const ushort CmdMita500GetBuff = 1154;
        public const ushort CmdInventoryRequest = 1156; // Unsure. Might be something else?
        public const ushort CmdDayMissionGetReward = 1162;
        public const ushort CmdDayMileageGetReward = 1163;
        public const ushort CmdDayEventGetItem = 1170;
        public const ushort CmdDayEventComplete = 1172;
        public const ushort CmdVisualItemList = 1200;
        public const ushort CmdBuyVisualItemThread = 1203;
        public const ushort CmdEquipVisualItem = 1205;
        public const ushort CmdUnEquipVisualItem = 1207;
        public const ushort CmdVisualItemUse = 1209;
        public const ushort CmdDropVisualItem = 1211;
        public const ushort CmdBuyHistoryList = 1300;
        public const ushort CmdSendVisualItemThread = 1302;
        public const ushort CmdGetVisualItemThread = 1304;
        public const ushort CmdIsValidCharName = 1306;
        public const ushort CmdTestPlayerAnswer = 1311;
        public const ushort CmdLapTimeReady = 1321;
        public const ushort CmdLapTimeGate = 1323;
        public const ushort CmdLapTimeRecord = 1324;
        public const ushort CmdMyStickerList = 1350;
        public const ushort CmdAttachSticker = 1352;
        public const ushort CmdDetachSticker = 1354;
        public const ushort CmdEndingUserRecord = 1360;
        public const ushort CmdSendMail = 1486;
        public const ushort CmdGetMyHancoinThread = 1400;
        public const ushort CmdNotifyDelCharacter = 1410;
        public const ushort CmdNotifyDelCharacterAck = 1411;
        public const ushort CmdNotifyServerIp = 1412;
        public const ushort CmdReportHack = 1413;
        public const ushort CmdItemExpireCmd = 1500;
        public const ushort CmdMyAuctionCarList = 1700;
        public const ushort CmdAuctionCarOn = 1702;
        public const ushort CmdAuctionCarCancel = 1704;
        public const ushort CmdAuctionCarComplete = 1706;
        public const ushort CmdAuctionCarList = 1708;
        public const ushort CmdAuctionCarBuy = 1710;
        public const ushort CmdAuctionCarSearch = 1713;
        public const ushort CmdSelectGuild = 1900;
        public const ushort CmdUpdateQuickSlot = 2000;
        public const ushort CmdUcPatrolStart = 3000;
        public const ushort CmdUcPatrolGiveUp = 3002;
        public const ushort CmdUcPatrolGoalPlace = 3004;
        public const ushort CmdUcBossPatrolStart = 3010;
        public const ushort CmdUcBossPatrolGiveUp = 3012;
        public const ushort CmdUcBossPatrolGoalPlace = 3014;
        public const ushort CmdCityLeaveCheck = 3200;
        public const ushort CmdUnknownSync = 3917;

        public static string GetName(ushort packetId)
        {
            // Login/Channel
            foreach (var field in typeof(Packets).GetFields(BindingFlags.Public | BindingFlags.Static))
                if ((ushort) field.GetValue(null) == packetId)
                    return field.Name;

            return "?";
        }

        [Packet(CmdNullPing)]
        public static void NullPing(Packet packet)
        {
        }
    }
}