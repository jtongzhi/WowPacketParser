using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V4_3_4_15595
{
    public static class Opcodes_4_3_4
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ACCEPT_LEVEL_GRANT, 0x0205},
            {Opcode.CMSG_ACCEPT_TRADE, 0x07110},
            {Opcode.CMSG_ADD_FRIEND, 0x6C29},
            {Opcode.CMSG_ADD_VOICE_IGNORE, 0x0F06},
            {Opcode.CMSG_ADDON_REGISTERED_PREFIXES, 0x0954},
            {Opcode.CMSG_ALTER_APPEARANCE, 0x0914},
            {Opcode.CMSG_AREA_SPIRIT_HEALER_QUERY, 0x4907},
            {Opcode.CMSG_AREATRIGGER, 0x0937},
            {Opcode.CMSG_ARENA_TEAM_DISBAND, 0x6504},
            {Opcode.CMSG_ARENA_TEAM_INVITE, 0x2F27},
            {Opcode.CMSG_ARENA_TEAM_LEADER, 0x4204},
            {Opcode.CMSG_ARENA_TEAM_LEAVE, 0x0E16},
            {Opcode.CMSG_ARENA_TEAM_REMOVE, 0x2F05},
            {Opcode.CMSG_ATTACKSWING, 0x0926},
            {Opcode.CMSG_AUCTION_LIST_ITEMS, 0x0324},
            {Opcode.CMSG_AUCTION_PLACE_BID, 0x2306},
            {Opcode.CMSG_AUCTION_REMOVE_ITEM, 0x6426},
            {Opcode.CMSG_AUCTION_SELL_ITEM, 0x4A06},
            {Opcode.CMSG_AUTH_SESSION, 0x0449},
            {Opcode.CMSG_AUTO_DECLINE_GUILD_INVITES, 0x2034},
            {Opcode.CMSG_AUTOEQUIP_ITEM, 0x4304},
            {Opcode.CMSG_AUTOSTORE_LOOT_ITEM, 0x0E34},
            {Opcode.CMSG_BINDER_ACTIVATE, 0x4006},
            {Opcode.CMSG_BATTLEFIELD_LIST, 0x3814},
            {Opcode.CMSG_BATTLEFIELD_STATUS, 0x2500},
            {Opcode.CMSG_BUG, 0x4035},
            {Opcode.CMSG_BUY_BANK_SLOT, 0x0425},
            {Opcode.CMSG_BUY_ITEM, 0x0736},
            {Opcode.CMSG_BUYBACK_ITEM, 0x6C17},
            {Opcode.CMSG_CALENDAR_EVENT_INVITE, 0x0227},
            {Opcode.CMSG_CANCEL_AUTO_REPEAT_SPELL, 0x6C35},
            {Opcode.CMSG_CANCEL_CAST, 0x0115},
            {Opcode.CMSG_CANCEL_CHANNELLING, 0x6C25},
            {Opcode.CMSG_CANCEL_MOUNT_AURA, 0x0635},
            {Opcode.CMSG_CANCEL_TRADE, 0x731E},
            {Opcode.CMSG_CAST_SPELL, 0x4C07},
            {Opcode.CMSG_CHANNEL_ANNOUNCEMENTS, 0x1146},
            {Opcode.CMSG_CHANNEL_BAN, 0x3D56},
            {Opcode.CMSG_CHANNEL_DISPLAY_LIST, 0x2144},
            {Opcode.CMSG_CHANNEL_INVITE, 0x0144},
            {Opcode.CMSG_CHANNEL_KICK, 0x3156},
            {Opcode.CMSG_CHANNEL_LIST, 0x1556},
            {Opcode.CMSG_CHANNEL_MODERATOR, 0x2944},
            {Opcode.CMSG_CHANNEL_MUTE, 0x2554},
            {Opcode.CMSG_CHANNEL_OWNER, 0x3D44},
            {Opcode.CMSG_CHANNEL_PASSWORD, 0x9558},
            {Opcode.CMSG_CHANNEL_ROSTER_INFO, 0x3546},
            {Opcode.CMSG_CHANNEL_SET_OWNER, 0x3556},
            {Opcode.CMSG_CHANNEL_UNBAN, 0x2D46},
            {Opcode.CMSG_CHANNEL_UNMODERATOR, 0x1954},
            {Opcode.CMSG_CHANNEL_UNMUTE, 0x3554},
            {Opcode.CMSG_CHAR_CREATE, 0x4A36},
            {Opcode.CMSG_CHAR_DELETE, 0x6425},
            {Opcode.CMSG_CHAR_ENUM, 0x0502},
            {Opcode.CMSG_CHAR_FACTION_CHANGE, 0x2735},
            {Opcode.CMSG_CHAR_RACE_CHANGE, 0x0D24},
            {Opcode.CMSG_CHAR_RENAME, 0x2327},
            {Opcode.CMSG_CLEAR_CHANNEL_WATCH, 0x2604},
            {Opcode.CMSG_COMMENTATOR_ENABLE, 0x0B07},
            {Opcode.CMSG_COMMENTATOR_ENTER_INSTANCE, 0x4105},
            {Opcode.CMSG_COMMENTATOR_EXIT_INSTANCE, 0x6136},
            {Opcode.CMSG_COMMENTATOR_GET_MAP_INFO, 0x0026},
            {Opcode.CMSG_COMMENTATOR_GET_PLAYER_INFO, 0x0D14},
            {Opcode.CMSG_COMMENTATOR_INSTANCE_COMMAND, 0x0917},
            {Opcode.CMSG_COMMENTATOR_SKIRMISH_QUEUE_COMMAND, 0x0025},
            {Opcode.CMSG_COMPLETE_CINEMATIC, 0x0A16},
            {Opcode.CMSG_CONTACT_LIST, 0x4534},
            {Opcode.CMSG_CREATURE_QUERY, 0x2706},
            {Opcode.CMSG_DEL_FRIEND, 0x6A15},
            {Opcode.CMSG_DEL_IGNORE, 0x4727},
            {Opcode.CMSG_DEL_VOICE_IGNORE, 0x0024},
            {Opcode.CMSG_DUNGEON_FINDER_GET_SYSTEM_INFO, 0x0412},
            {Opcode.CMSG_DESTROY_ITEMS, 0x4A27},
            {Opcode.CMSG_EMOTE, 0x4C26},
            {Opcode.CMSG_FORCE_MOVE_UNROOT_ACK, 0x7DB4},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x4017},
            {Opcode.CMSG_GET_MAIL_LIST, 0x4D37},
            {Opcode.CMSG_GET_MIRRORIMAGE_DATA, 0x0C25},
            {Opcode.CMSG_GMTICKET_UPDATETEXT, 0x0636},
            {Opcode.CMSG_GOSSIP_HELLO, 0x4525},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x0216},
            {Opcode.CMSG_GROUP_SET_LEADER, 0x4C17},
            {Opcode.CMSG_GROUP_ASSISTANT_LEADER, 0x6025},
            {Opcode.CMSG_GROUP_CHANGE_SUB_GROUP, 0x4124},
            {Opcode.CMSG_GROUP_RAID_CONVERT, 0x6E27},
            {Opcode.CMSG_GROUP_SWAP_SUB_GROUP, 0x0034},
            {Opcode.CMSG_GUILD_ACCEPT, 0x2531},
            {Opcode.CMSG_GUILD_BANK_QUERY_TAB, 0x2E35},
            {Opcode.CMSG_GUILD_BANK_SWAP_ITEMS, 0x2315},
            {Opcode.CMSG_GUILD_BANK_UPDATE_TAB, 0x0106},
            {Opcode.CMSG_GUILD_BANK_REM_MONEY_WITHDRAW_QUERY, 0x1225},
            {Opcode.CMSG_GUILD_BANKER_ACTIVATE, 0x2E37},
            {Opcode.CMSG_GUILD_INFO_TEXT, 0x3227},
            {Opcode.CMSG_GUILD_MOTD, 0x1035},
            {Opcode.CMSG_GUILD_QUERY, 0x4426},
            {Opcode.CMSG_GUILD_ROSTER, 0x1026},
            {Opcode.CMSG_GUILD_RANKS, 0x1226},
            {Opcode.CMSG_GUILD_SET_ACHIEVEMENT_TRACKING, 0x1027},
            {Opcode.CMSG_HEARTH_AND_RESURRECT, 0x4B34},
            {Opcode.CMSG_INSPECT, 0x0927},
            {Opcode.CMSG_INSTANCE_LOCK_WARNING_RESPONSE, 0x6234},
            {Opcode.CMSG_ITEM_REFUND, 0x6134},
            {Opcode.CMSG_ITEM_REFUND_INFO, 0x2206},
            {Opcode.CMSG_JOIN_CHANNEL, 0x0156},
            {Opcode.CMSG_LEARN_PREVIEW_TALENTS, 0x2415},
            {Opcode.CMSG_LEARN_TALENT, 0x6E24},
            {Opcode.CMSG_LFG_JOIN, 0x2581},
            {Opcode.CMSG_LFG_SET_ROLES, 0x25B1},
            {Opcode.CMSG_LIST_INVENTORY, 0x2806},
            {Opcode.CMSG_LOAD_SCREEN, 0x2422},
            {Opcode.CMSG_LOG_DISCONNECT, 0x446D},
            {Opcode.CMSG_LOGOUT_CANCEL, 0x2324},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x0A25},
            {Opcode.CMSG_LOOT, 0x0127},
            {Opcode.CMSG_LOOT_METHOD, 0x2F24},
            {Opcode.CMSG_LOOT_MONEY, 0x6227},
            {Opcode.CMSG_LOOT_RELEASE, 0x2007},
            {Opcode.CMSG_MAIL_CREATE_TEXT_ITEM, 0x0B14},
            {Opcode.CMSG_MAIL_TAKE_ITEM, 0x2B06},
            {Opcode.CMSG_MAIL_TAKE_MONEY, 0x4034},
            {Opcode.CMSG_MESSAGECHAT_ADDON_GUILD, 0x0544},
            {Opcode.CMSG_MESSAGECHAT_ADDON_PARTY, 0x0546},
            {Opcode.CMSG_MESSAGECHAT_CHANNEL, 0x1D44},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x3956},
            {Opcode.CMSG_MESSAGECHAT_OFFICER, 0x1946},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x1154},
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x0D56},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x3544},
            {Opcode.CMSG_MOVE_KNOCK_BACK_ACK, 0x5CB4},
            {Opcode.CMSG_MOVE_TIME_SKIPPED, 0x7A0A},
            {Opcode.CMSG_NAME_QUERY, 0x2224},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x4E24},
            {Opcode.CMSG_OFFER_PETITION, 0x4817},
            {Opcode.CMSG_PET_ACTION, 0x0226},
            {Opcode.CMSG_PET_CAST_SPELL, 0x6337},
            {Opcode.CMSG_PETITION_BUY, 0x4E05},
            {Opcode.CMSG_PETITION_SIGN, 0x0E04},
            {Opcode.CMSG_PING, 0x444D},
            {Opcode.CMSG_PLAYED_TIME, 0x0804},
            {Opcode.CMSG_PLAYER_LOGIN, 0x05B1},
            {Opcode.CMSG_PUSHQUESTTOPARTY, 0x4B14},
            {Opcode.CMSG_QUERY_QUESTS_COMPLETED, 0x2317},
            {Opcode.CMSG_QUERY_TIME, 0x0A36},
            {Opcode.CMSG_QUEST_POI_QUERY, 0x4037},
            {Opcode.CMSG_QUEST_QUERY, 0x0D06},
            {Opcode.CMSG_QUESTGIVER_COMPLETE_QUEST, 0x7302},
            {Opcode.CMSG_QUESTGIVER_STATUS_MULTIPLE_QUERY, 0x6305},
            {Opcode.CMSG_QUESTGIVER_STATUS_QUERY, 0x4407},
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x2413},
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0x2B16},
            {Opcode.CMSG_REALM_SPLIT, 0x2906},
            {Opcode.CMSG_RECLAIM_CORPSE, 0x4036},
            {Opcode.CMSG_REDIRECTION_AUTH_PROOF, 0x044D},
            {Opcode.CMSG_REPAIR_ITEM, 0x2917},
            {Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x6505},
            {Opcode.CMSG_REQUEST_CATEGORY_COOLDOWNS, 0x7102},
            {Opcode.CMSG_REQUEST_HOTFIX, 0x2401},
            {Opcode.CMSG_REQUEST_PET_INFO, 0x4924},
            {Opcode.CMSG_REQUEST_RAID_INFO, 0x2F26},
            {Opcode.CMSG_REQUEST_RATED_BG_INFO, 0x34A1},
            {Opcode.CMSG_REQUEST_CEMETERY_LIST, 0x720A},
            {Opcode.CMSG_RESET_FACTION_CHEAT, 0x4469},
            {Opcode.CMSG_RESET_INSTANCES, 0x6E14},
            {Opcode.CMSG_RESURRECT_RESPONSE, 0x6827},
            {Opcode.CMSG_SELF_RES, 0x6115},
            {Opcode.CMSG_SELL_ITEM, 0x4E15},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x6F06},
            {Opcode.CMSG_SET_ACTIONBAR_TOGGLES, 0x2506},
            {Opcode.CMSG_SET_ACTIVE_MOVER, 0x3314},
            {Opcode.CMSG_SET_ACTIVE_VOICE_CHANNEL, 0x4305},
            {Opcode.CMSG_SET_ALLOW_LOW_LEVEL_RAID1, 0x4435},
            {Opcode.CMSG_SET_ALLOW_LOW_LEVEL_RAID2, 0x0536},
            {Opcode.CMSG_SET_PRIMARY_TALENT_TREE, 0x4524},
            {Opcode.CMSG_SET_SAVED_INSTANCE_EXTEND, 0x6706},
            {Opcode.CMSG_SET_SELECTION, 0x0506},
            {Opcode.CMSG_SET_TAXI_BENCHMARK_MODE, 0x4314},
            {Opcode.CMSG_SET_TITLE, 0x2117},
            {Opcode.CMSG_SETSHEATHED, 0x4326},
            {Opcode.CMSG_SHOWING_CLOAK, 0x4135},
            {Opcode.CMSG_SHOWING_HELM, 0x0735},
            {Opcode.CMSG_SOCKET_GEMS, 0x2F04},
            {Opcode.CMSG_SPIRIT_HEALER_ACTIVATE, 0x2E26},
            {Opcode.CMSG_STANDSTATECHANGE, 0x0535},
            {Opcode.CMSG_SUSPEND_TOKEN, 0x046D},
            {Opcode.CMSG_SWAP_INV_ITEM, 0x2614},
            {Opcode.CMSG_SWAP_ITEM, 0x6326},
            {Opcode.CMSG_TAXINODE_STATUS_QUERY, 0x2F25},
            {Opcode.CMSG_TEXT_EMOTE, 0x2E24},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x3B0C},
            {Opcode.CMSG_TOGGLE_PVP, 0x6815},
            {Opcode.CMSG_TRAINER_BUY_SPELL, 0x4415},
            {Opcode.CMSG_TRAINER_LIST, 0x2336},
            {Opcode.CMSG_UNREGISTER_ALL_ADDON_PREFIXES, 0x3D54},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x4736},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x7816},
            {Opcode.CMSG_WARDEN_DATA, 0x25A2},
            {Opcode.CMSG_WHO, 0x6C15},
            {Opcode.CMSG_WHOIS, 0x6B05},
            {Opcode.CMSG_WORLD_STATE_UI_TIMER_UPDATE, 0x4605},
            {Opcode.CMSG_WORLD_TELEPORT, 0x3330},
            {Opcode.CMSG_ZONEUPDATE, 0x4F37},
            {Opcode.MSG_AUCTION_HELLO, 0x2307},
            {Opcode.MSG_MINIMAP_PING, 0x6635},
            {Opcode.MSG_MOVE_ENABLE_TRANSITION_BETWEEN_SWIM_AND_FLY, 0x3014},
            {Opcode.MSG_MOVE_FALL_LAND, 0x380A},
            {Opcode.MSG_MOVE_FORCE_FLIGHT_SPEED_CHANGE_ACK, 0x7314},
            {Opcode.MSG_MOVE_FORCE_RUN_SPEED_CHANGE_ACK, 0x7818},
            {Opcode.MSG_MOVE_JUMP, 0x7A06},
            {Opcode.MSG_MOVE_REQUEST_STATUS, 0x3914},
            {Opcode.MSG_MOVE_SET_CAN_FLY_ACK, 0x790C},
            {Opcode.MSG_MOVE_SET_COLLISION_HEIGHT_ACK, 0x7114},
            {Opcode.MSG_MOVE_SKIP_TIME, 0x19B3},
            {Opcode.MSG_MOVE_SPLINE_DONE, 0X790E},
            {Opcode.MSG_MOVE_SPLINE_SET_RUN_SPEED, 0x51B7},
            {Opcode.MSG_MOVE_START_ASCEND, 0x390A},
            {Opcode.MSG_MOVE_START_BACKWARD, 0x330A},
            {Opcode.MSG_MOVE_START_DESCEND, 0x3800},
            {Opcode.MSG_MOVE_START_FORWARD, 0x7814},
            {Opcode.MSG_MOVE_START_PITCH_DOWN, 0x3908},
            {Opcode.MSG_MOVE_START_PITCH_UP, 0x3304},
            {Opcode.MSG_MOVE_START_SWIM, 0x3206},
            {Opcode.MSG_MOVE_START_TURN_LEFT, 0x700C},
            {Opcode.MSG_MOVE_START_TURN_RIGHT, 0x7000},
            {Opcode.MSG_MOVE_STOP, 0x320A},
            {Opcode.MSG_MOVE_STOP_ASCEND, 0x7B00},
            {Opcode.MSG_MOVE_STOP_TURN, 0x331E},
            {Opcode.MSG_MOVE_STOP_PITCH, 0x7312},
            {Opcode.MSG_MOVE_STOP_SWIM, 0x3802},
            {Opcode.MSG_MOVE_TOGGLE_COLLISION_CHEAT, 0x7B04},
            {Opcode.MSG_MOVE_UPDATE_MOUSE, 0x7914},
            {Opcode.MSG_PETITION_DECLINE, 0x31E0},
            {Opcode.MSG_PETITION_RENAME, 0x4005},
            {Opcode.MSG_PVP_LOG_DATA, 0x5CB2},
            {Opcode.MSG_QUERY_NEXT_MAIL_TIME, 0x0F04},
            {Opcode.MSG_RANDOM_ROLL, 0x0905},
            {Opcode.MSG_RAID_TARGET_UPDATE, 0x2C36},
            {Opcode.MSG_SAVE_GUILD_EMBLEM, 0x2404},
            {Opcode.MSG_SET_RAID_DIFFICULTY, 0x0614},
            {Opcode.MSG_MOVE_SET_RUN_SPEED, 0x3DB5},
            {Opcode.MSG_SET_DUNGEON_DIFFICULTY, 0x4925},
            {Opcode.MSG_TABARDVENDOR_ACTIVATE, 0x6926},
            {Opcode.MSG_VERIFY_CONNECTIVITY, 0x4F57},
            {Opcode.SMSG_ACHIEVEMENT_EARNED, 0x4405},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x4B05},
            {Opcode.SMSG_ACTION_BUTTONS, 0x38B5},
            {Opcode.SMSG_ADDON_INFO, 0x2C14},
            {Opcode.SMSG_AI_REACTION, 0x0637},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x58B1},
            {Opcode.SMSG_ALL_GUILD_ACHIEVEMENTS, 0x54B7},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x0B25},
            {Opcode.SMSG_ATTACKSTART, 0x2D15},
            {Opcode.SMSG_ATTACKSTOP, 0x0934},
            {Opcode.SMSG_ATTACKSWING_BADFACING, 0x0B36},
            {Opcode.SMSG_ATTACKSWING_CANT_ATTACK, 0x0016},
            {Opcode.SMSG_AURA_UPDATE, 0x4707},
            {Opcode.SMSG_AURA_UPDATE_ALL, 0x6916},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x4542},
            {Opcode.SMSG_AUTH_RESPONSE, 0x5DB6},
            {Opcode.SMSG_BARBER_SHOP_RESULT, 0x6125},
            {Opcode.SMSG_BATTLEFIELD_LIST, 0x71B5},
            {Opcode.SMSG_BATTLEFIELD_STATUS, 0x7202},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x0527},
            {Opcode.SMSG_BUY_ITEM, 0x0F26},
            {Opcode.SMSG_CALENDAR_COMMAND_RESULT, 0x6F36},
            {Opcode.SMSG_CANCEL_AUTO_REPEAT, 0x6436},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x0825},
            {Opcode.SMSG_CHAR_CREATE, 0x2D05},
            {Opcode.SMSG_CHAR_DELETE, 0x0304},
            {Opcode.SMSG_CHAR_ENUM, 0x10B0},
            {Opcode.SMSG_CLEAR_TARGET, 0x4B26},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x2734},
            {Opcode.SMSG_CONTACT_LIST, 0x6017},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x0D34},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x6024},
            {Opcode.SMSG_CRITERIA_UPDATE, 0x6E37},
            {Opcode.SMSG_DB_REPLY, 0x38A4},
            {Opcode.SMSG_DEFENSE_MESSAGE,  0x0314},
            {Opcode.SMSG_DESTROY_OBJECT, 0x4724},
            {Opcode.SMSG_DUEL_REQUESTED, 0x4504},
            {Opcode.SMSG_DUEL_WINNER, 0x2527},
            {Opcode.SMSG_EMOTE, 0x0A34},
            {Opcode.SMSG_ENCHANTMENTLOG, 0x6035},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x2E04},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x3DB7},
            {Opcode.SMSG_FLIGHT_SPLINE_SYNC, 0x0924},
            {Opcode.SMSG_FORCE_SEND_QUEUED_PACKETS, 0x0140},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x0915},
            {Opcode.SMSG_GM_MESSAGECHAT, 0x6434},
            {Opcode.SMSG_GOSSIP_COMPLETE, 0x0806},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x2035},
            {Opcode.SMSG_GOSSIP_POI, 0x4316},
            {Opcode.SMSG_GUILD_XP, 0x3DB0},
            {Opcode.SMSG_GROUP_LIST, 0x4C24},
            {Opcode.SMSG_GROUP_SET_LEADER, 0x0526},
            {Opcode.SMSG_GROUP_SET_ROLE, 0x39A6},
            {Opcode.SMSG_GUILD_BANK_LIST, 0x78A5},
            {Opcode.SMSG_GUILD_EVENT, 0x0705},
            {Opcode.SMSG_GUILD_INVITE, 0x14A2},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x0E06},
            {Opcode.SMSG_GUILD_RANK, 0x30B4},
            {Opcode.SMSG_GUILD_ROSTER, 0x3DA3},
            {Opcode.SMSG_GUILD_UPDATE_ROSTER, 0x18B0},
            {Opcode.SMSG_HOTFIX_INFO, 0x19B5},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x4634},
            {Opcode.SMSG_INITIAL_SPELLS, 0x0104},
            {Opcode.SMSG_INIT_CURRENCY, 0x15A5},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x4C15},
            {Opcode.SMSG_INSPECT_RESULTS_UPDATE, 0x4014},
            {Opcode.SMSG_INVALIDATE_PLAYER, 0x6325},
            {Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0x0F27},
            {Opcode.SMSG_LEARNED_DANCE_MOVES, 0x0E05},
            {Opcode.SMSG_LFG_PLAYER_INFO, 0x4B36},
            {Opcode.SMSG_LIST_INVENTORY, 0x7CB0},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x50B1},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x4D15},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x2005},
            {Opcode.SMSG_LOG_XPGAIN, 0x4514},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x2137},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x0524},
            {Opcode.SMSG_LOOT_ALL_PASSED, 0x6237},
            {Opcode.SMSG_LOOT_ITEM_NOTIFY, 0x6D15},
            {Opcode.SMSG_LOOT_RELEASE_RESPONSE, 0x6D25},
            {Opcode.SMSG_LOOT_REMOVED, 0x6817},
            {Opcode.SMSG_LOOT_RESPONSE, 0x4C16},
            {Opcode.SMSG_LOOT_ROLL, 0x6507},
            {Opcode.SMSG_LOOT_ROLL_WON, 0x6617},
            {Opcode.SMSG_MAIL_COMMAND_RESULT, 0x4927},
            {Opcode.SMSG_MAIL_LIST_RESULT, 0x4217},
            {Opcode.SMSG_MESSAGECHAT, 0x2026},
            {Opcode.SMSG_MONSTER_MOVE, 0x6E17},
            {Opcode.SMSG_MOTD, 0x0A35},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x6E04},
            {Opcode.SMSG_NEW_WORLD, 0x031A2},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x4436},
            {Opcode.SMSG_PERIODICAURALOG, 0x0416},
            {Opcode.SMSG_PET_GUIDS, 0x2D26},
            {Opcode.SMSG_PET_MODE, 0x2235},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0x4C37},
            {Opcode.SMSG_PET_SPELLS, 0x4114},
            {Opcode.SMSG_PLAY_SOUND, 0x2134},
            {Opcode.SMSG_PLAYED_TIME, 0x6037},
            {Opcode.SMSG_PLAYER_MOVE, 0x79A2},
            {Opcode.SMSG_PONG, 0x4D42},
            {Opcode.SMSG_POWER_UPDATE, 0x4A07},
            {Opcode.SMSG_PVP_LOG_DATA, 0x54A3},
            {Opcode.SMSG_QUERY_TIME_RESPONSE, 0x2124},
            {Opcode.SMSG_QUERY_QUESTS_COMPLETED_RESPONSE, 0x6314},
            {Opcode.SMSG_QUESTGIVER_QUEST_COMPLETE, 0x55A4},
            {Opcode.SMSG_QUESTGIVER_OFFER_REWARD, 0x2427},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x2425},
            {Opcode.SMSG_QUESTGIVER_STATUS, 0x2115},
            {Opcode.SMSG_QUESTGIVER_STATUS_MULTIPLE, 0x4F25},
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x6304},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x6936},
            {Opcode.SMSG_QUESTUPDATE_ADD_KILL, 0x0D27},
            {Opcode.SMSG_RAID_INSTANCE_INFO, 0x6626},
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0x38B1},
            {Opcode.SMSG_REALM_SPLIT, 0x2714},
            {Opcode.SMSG_RECEIVED_MAIL, 0x4927},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x0942},
            {Opcode.SMSG_REMOVED_SPELL, 0x4804},
            {Opcode.SMSG_SELL_ITEM, 0x6105},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x4E25},
            {Opcode.SMSG_SERVER_MESSAGE, 0x6C04},
            {Opcode.SMSG_SET_FACTION_STANDING, 0x0126},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x0224},
            {Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x2834},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x70A0},
            {Opcode.SMSG_SET_PROFICIENCY, 0x6207},
            {Opcode.SMSG_SPELL_COOLDOWN, 0x4B16},
            {Opcode.SMSG_SPELL_GO, 0x6E16},
            {Opcode.SMSG_SPELL_START, 0x6415},
            {Opcode.SMSG_SPELLDAMAGESHIELD, 0x2927},
            {Opcode.SMSG_SPELLENERGIZELOG, 0x0414},
            {Opcode.SMSG_SPELLHEALLOG, 0x2816},
            {Opcode.SMSG_SPELLLOGEXECUTE, 0x0626},
            {Opcode.SMSG_SPELLLOGMISS, 0x0625},
            {Opcode.SMSG_SPELLNONMELEEDAMAGELOG, 0x4315},
            {Opcode.SMSG_SPELLORDAMAGE_IMMUNE, 0x4507},
            {Opcode.SMSG_STANDSTATE_UPDATE, 0x6F04},
            {Opcode.SMSG_SUSPEND_TOKEN_RESPONSE, 0x14B1},
            {Opcode.SMSG_SUSPEND_COMMS, 0x4140},
            {Opcode.SMSG_TALENTS_INFO, 0x6F26},
            {Opcode.SMSG_TAXINODE_STATUS, 0x2936},
            {Opcode.SMSG_TEXT_EMOTE, 0x0B05},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x3CA4},
            {Opcode.SMSG_TRAINER_BUY_SUCCEEDED, 0x6A05},
            {Opcode.SMSG_TRAINER_LIST, 0x4414},
            {Opcode.SMSG_TRIGGER_CINEMATIC, 0x6C27},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x0B35},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA, 0x6837},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA_COMPLETE, 0x2015},
            {Opcode.SMSG_UPDATE_CURRENCY_WEEK_LIMIT, 0x70A7},
            {Opcode.SMSG_UPDATE_OBJECT, 0x4715},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x4816},
            {Opcode.SMSG_USERLIST_REMOVE, 0x2006},
            {Opcode.SMSG_USERLIST_UPDATE, 0x0135},
            {Opcode.SMSG_WARDEN_DATA, 0x31A0},
            {Opcode.SMSG_WHO, 0x6907},
            {Opcode.SMSG_WORLD_STATE_UI_TIMER_UPDATE, 0x4A14}

            // 0x2915 Contains Criteria achievement - Received after SMSG_ACHIEVEMENT_EARNED
            // 0x6236 SMSG_QUESTUPDATE_COMPLETE?
        };
    }
}
