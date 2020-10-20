﻿using System;

namespace ResourceTypes.M3.XBin
{
    [Flags]
    public enum EMenuAction
    {
        E_MA_UP = 0,
        E_MA_DOWN = 1,
        E_MA_LEFT = 2,
        E_MA_RIGHT = 3,
        E_MA_CURSOR_MOVE_X = 4,
        E_MA_CURSOR_MOVE_Y = 5,
        E_MA_START = 6,
        E_MA_ACCEPT = 7,
        E_MA_BACK = 8,
        E_MA_PAGE_UP = 9,
        E_MA_PAGE_DOWN = 10,
        E_MA_A = 11,
        E_MA_B = 12,
        E_MA_X = 13,
        E_MA_Y = 14,
        E_MA_MAP_JOURNAL = 15,
        E_MA_MAP_PLAYER = 16,
        E_MA_MAP_WAYPOINT = 17,
        E_MA_MAP_ZOOM_IN = 18,
        E_MA_MAP_ZOOM_OUT = 19,
        E_MA_MAP_PAN = 20,
        E_MA_MAP_NAVIGATE_X = 21,
        E_MA_MAP_NAVIGATE_Y = 22,
        E_MA_CLICK_LEFT = 23,
        E_MA_CLICK_RIGHT = 24,
        E_MA_SWITCH = 25,
        E_MA_MAP_CLOSE = 26,
        E_MA_ERASE = 27,
        E_MA_DELETE = 28,
        E_MA_SEARCH = 29,
        E_MA_PREVIOUS = 30,
        E_MA_NEXT = 31,
        E_MA_JOY_X = 32,
        E_MA_JOY_Y = 33,
        E_MA_JOY_RX = 34,
        E_MA_JOY_RY = 35,
        E_MA_RIGHT_JOY_UP = 36,
        E_MA_RIGHT_JOY_DOWN = 37,
        E_MA_LEFT_JOY_UP = 38,
        E_MA_LEFT_JOY_DOWN = 39,
        E_MA_TOUCH_BEGIN = 40,
        E_MA_TOUCH_END = 41,
        E_MA_TOUCH_TAP = 42,
        E_MA_TOUCH_LONG_BEGIN = 43,
        E_MA_TOUCH_MOVE_X = 44,
        E_MA_TOUCH_MOVE_Y = 45,
        E_MA_MAP_HIDEOUT_MAP = 46,
        E_MA_MAP_TELEPORT_PLAYER = 47,
        E_MA_LEFT_THUMB_CLICK = 48,
        E_MA_OVERRIDE_MAPPING = 49,
        E_MA_CLICK_MIDDLE = 50
    }

    [Flags]
    public enum EFlashDeviceIndex
    {
        E_FD_ORIGINAL_INDEX = 0,
        E_FD_INDEX1 = 1,
        E_FD_INDEX2 = 2,
        E_FD_INDEX3 = 3,
        E_FD_INDEX4 = 4
    }

    [Flags]
    public enum EFlashControlType
    {
        E_FCT_KEYBOARD_BUTTON = 0,
        E_FCT_MOUSE_AXIS = 1,
        E_FCT_MOUSE_BUTTON = 2,
        E_FCT_JOYSTICK = 3,
        E_FCT_TOUCH = 4,
        E_FCT_TOUCH_MOVE = 5,
        E_FCT_LAST = 6
    }

    [Flags]
    public enum EFontMapFlags
    {
        E_MFF_NORMAL = 0,
        E_MFF_ITALIC = 1,
        E_MFF_BOLD = 2,
        E_MFF_BOLD_ITALIC = 3,
        E_MFF_FAUX_ITALIC = 4,
        E_MFF_FAUX_BOLD = 8,
        E_MFF_FAUX_BOLD_ITALIC = 12,
        E_MFF_ORIGINAL = 10,
        E_MFF_NO_AUTO_FIT = 20
    }

    [Flags]
    public enum EFontMapPlatform
    {
        E_FMP_ALL = 0,
        E_FMP_PC = 1,
        E_FMP_XB1 = 2,
        E_FMP_PS4 = 3,
        E_FMP_LAST = 4
    }

    [Flags]
    public enum EFontMapLanguage
    {
        E_FML_ENGLISH = 0,
        E_FML_CHINESE_SIMPLIFIED = 1,
        E_FML_CHINESE_TRADITIONAL = 2,
        E_FML_JAPANESE = 3,
        E_FML_KOREAN = 4,
        E_FML_LAST = 5
    }

    [Flags]
    public enum EInputControlFlags : uint
    {
        E_F_FULL_AXIS = 0x00000001,
        E_F_NEGATIVE_AXIS = 0x00000002,
        E_F_POSITIVE_AXIS = 0x00000004,
        E_F_FULL_AXIS_INV = 0x00000008,
        E_F_UP = 0x00000010,
        E_F_DOWN = 0x00000020,
        E_F_DOWN_ONCE = 0x00000040,
        E_F_UP_ONCE = 0x00000080,
        E_F_DOWN_UP_ONCE = 0x00000100,
        E_F_DOWN_ONCE_REPEAT = 0x00000200,
        E_F_UP_ONCE_REPEAT = 0x00000400,
        E_F_DOWN_REPEAT_UP_ONCE = 0x00000800,
        E_F_DOWN_LONG = 0x00001000,
        E_F_DOWN_LONG_BEGIN = 0x00002000,
        E_F_TAP = 0x00004000,
        E_F_TAP_REPEATED_DIGITAL = 0x00008000,
        E_F_TOGGLE_DIGITAL_DOWN = 0x00010000,
        E_F_TOGGLE_DIGITAL_TAP = 0x00020000,
        E_F_TOGGLE_DIGITAL_LONG_BEGIN = 0x00040000,
        E_F_ANYTIME = 0x80000000
    }

    [Flags]
    public enum EInputDeviceType
    {
        E_DT_UNDEFINED = 0,
        E_DT_MOUSE = 1,
        E_DT_KEYBOARD = 2,
        E_DT_JOYSTICK = 3,
        E_DT_GAMEPAD = 4,
        E_DT_DRIVING = 5,
        E_DT_TOUCH = 6
    }

    [Flags]
    public enum ESoundEvent
    {
        E_SE_MENU_SELECT_ITEM = 0,
        E_SE_HUD_BUSINESS_MONEY = 1,
        E_SE_HUD_MONEY_WALLET = 2,
        E_SE_HUD_QUEST_COMPLETED = 3,
        E_SE_HUD_BUSINESS_UPGRADE = 4,
        E_SE_HUD_WARNING_SOUND = 5,
        E_SE_HUD_GENERAL_NOTIFICATION = 6,
        E_SE_HUD_RACE_CHECKPOINT = 7,
        E_SE_HUD_RACE_FINISH = 8,
        E_SE_HUD_AMMO_PICKUP = 9,
        E_SE_HUD_AMMO_LOW = 10,
        E_SE_HUD_HEALTH_CRITICAL_ENTERED = 11,
        E_SE_HUD_HEALTH_CRITICAL_EXITED = 12,
        E_SE_HUD_HEALTH_RESTORED = 13,
        E_SE_HUD_HEALTH_RECHARGE_STARTED = 14,
        E_SE_HUD_HEALTH_USE_MEDKIT = 15,
        E_SE_HUD_HEALTH_SEGMENT_DEPLETED = 16,
        E_SE_HUD_HEALTH_DEAD = 17,
        E_SE_WEAPON_SELECTION_ENTER = 18,
        E_SE_WEAPON_SELECTION_EXIT = 19,
        E_SE_WEAPON_SELECTION_HIGHLIGHT_NORMAL = 20,
        E_SE_WEAPON_SELECTION_HIGHLIGHT_RESET = 21,
        E_SE_WEAPON_SELECTION_DROP = 22,
        E_SE_HUD_OBJECTIVE_ADDED = 23,
        E_SE_HUD_PERK_UNLOCKED = 24,
        E_SE_WEAPON_AIM_SHAKE_REDUCE_ENTER = 25,
        E_SE_WEAPON_AIM_SHAKE_REDUCE_EXIT = 26,
        E_SE_ENTER_COVERAGE = 27,
        E_SE_EXIT_COVERAGE = 28,
        E_SE_TRESPASS_ZONE_ENTER = 29,
        E_SE_TRESPASS_ZONE_EXIT = 30,
        E_SE_RESTRICTED_ZONE_ENTER = 31,
        E_SE_RESTRICTED_ZONE_EXIT = 32,
        E_SE_SERVICE_MENU_ENTER = 33,
        E_SE_SERVICE_MENU_EXIT = 34,
        E_SE_SERVICE_MENU_MOVE = 35,
        E_SE_SERVICE_MENU_SELECT = 36,
        E_SE_SERVICE_MENU_BACK = 37,
        E_SE_HIDEOUT_ASSIGNMENT_MENU_ENTER = 38,
        E_SE_HIDEOUT_ASSIGNMENT_MENU_EXIT = 39,
        E_SE_HIDEOUT_CONQUERED_SHOW = 40,
        E_SE_HIDEOUT_CONQUERED_HIDE = 41,
        E_SE_RETALIATION_SHOW = 42,
        E_SE_RETALIATION_HIDE = 43,
        E_SE_RETALIATION_FLASH = 44,
        E_SE_DLAMM_SHOW = 45,
        E_SE_DLAMM_HIDE = 46,
        E_SE_HIDEOUT_ASSIGNMENT_MENU_SELECT = 47,
        E_SE_GENERIC_SELECT = 48,
        E_SE_GENERIC_BACK = 49,
        E_SE_PRESS_START = 50,
        E_SE_SCROLL_DOWN = 51,
        E_SE_SCROLL_UP = 52,
        E_SE_SCROLL_LEFT = 53,
        E_SE_SCROLL_RIGHT = 54,
        E_SE_ADJUST_VALUE = 55,
        E_SE_MAP_NAVIGATE_START = 56,
        E_SE_MAP_NAVIGATE_STOP = 57,
        E_SE_MAP_HOVER_ON = 58,
        E_SE_MAP_HOVER_OFF = 59,
        E_SE_MAP_OBJECTIVE_ACTIVATE = 60,
        E_SE_MAP_OBJECTIVE_DEACTIVATE = 61,
        E_SE_MAP_WAYPOINT_SET = 62,
        E_SE_MAP_WAYPOINT_REMOVE = 63,
        E_SE_SLIDE_RIGHT = 64,
        E_SE_SLIDE_LEFT = 65,
        E_SE_NAVIGATE_ALL = 66,
        E_SE_SUB_NAVIGATE_RIGHT = 67,
        E_SE_SUB_NAVIGATE_LEFT = 68,
        E_SE_TEXT_NAVIGATE_START = 69,
        E_SE_TEXT_NAVIGATE_STOP = 70,
        E_SE_PURCHASE = 71,
        E_SE_BUTTON_DISABLED = 72,
        E_SE_ERROR = 73,
        E_SE_DEBUG_RETRY = 74,
        E_SE_FLAK_JACKET_EQUIP = 75,
        E_SE_MED_KIT_PICKUP = 76,
        E_SE_FUSE_PICKUP = 77,
        E_SE_FUSE_POLICECAR_PICKUP = 78,
        E_SE_PLAYBOY_PICKUP = 79,
        E_SE_PINUP_POSTER_PICKUP = 80,
        E_SE_ALBUM_PICKUP = 81,
        E_SE_INFORMANT_ESCAPE = 82,
        E_SE_OBJECTIVE_SELECTED = 83,
        E_SE_OBJECTIVE_COMPLETE = 84,
        E_SE_DISTRICT_ASSIGNMENT_MENU_ENTER = 85,
        E_SE_DISTRICT_ASSIGNMENT_MENU_EXIT = 86,
        E_SE_DISTRICT_ASSIGNMENT_MENU_SELECT = 87,
        E_SE_CHAPTER_ADDED = 88,
        E_SE_QUEST_ADDED = 89,
        E_SE_QUEST_COMPLETE = 90,
        E_SE_RACQUET_DAMAGE = 91,
        E_SE_DAMAGE_COMPLETE = 92,
        E_SE_GERS_SEARCH = 93,
        E_SE_GERS_COMBAT = 94,
        E_SE_MAIN_MENU_START_PAGE_ENTER = 95,
        E_SE_MAIN_MENU_START_PAGE_EXIT = 96,
        E_SE_HUD_SWITCH_EXPLOSIVES = 97,
        E_SE_CAR_CUSTOMIZATION_ENTER = 98,
        E_SE_CAR_CUSTOMIZATION_EXIT = 99,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_PAINT = 100,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_DECAL = 101,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_INTERIOR = 102,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_TINTS = 103,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_WHEELS = 104,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_ACCESSORY = 105,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_PERFORMANCE = 106,
        E_SE_RACE_COUNTDOWN_1 = 107,
        E_SE_RACE_COUNTDOWN_2 = 108,
        E_SE_RACE_COUNTDOWN_3 = 109,
        E_SE_RACE_FINISH_FIRST = 110,
        E_SE_RACE_FINISH_NOT_FIRST = 111,
        E_SE_RACE_ACCEPT = 112,
        E_SE_RACE_DECLINE = 113,
        E_SE_RACE_FAILED = 114,
        E_SE_RACE_CHECKPOINT = 115,
        E_SE_RACE_COUNTDOWN_0 = 116,
        E_SE_RACE_TIME_REMAINING = 117,
        E_SE_RACE_END_SCREEN_ENTER = 118,
        E_SE_RACE_END_SCREEN_EXIT = 119,
        E_SE_RACE_AWARDS = 120,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_ENGINE = 121,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_EXHAUST = 122,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_BODYKIT = 123,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_ROOF = 124,
        E_SE_CAR_CUSTOMIZATION_PURCHASE_EXTRAS = 125,
        E_SE_REAL_ESTATE_ENTER = 126,
        E_SE_REAL_ESTATE_EXIT = 127,
        E_SE_REAL_ESTATE_PURCHASE_BAR = 128,
        E_SE_REAL_ESTATE_PURCHASE_CENTERPIECE = 129,
        E_SE_REAL_ESTATE_PURCHASE_KITCHEN = 130,
        E_SE_REAL_ESTATE_PURCHASE_MUSIC = 131,
        E_SE_REAL_ESTATE_PURCHASE_REPAIR = 132,
        E_SE_REAL_ESTATE_PURCHASE_UPSTAIRS = 133,
        E_SE_REAL_ESTATE_PURCHASE_MURAL = 134,
        E_SE_REAL_ESTATE_PURCHASE_BOUNCER = 135,
        E_SE_REAL_ESTATE_PURCHASE_STAFF = 136,
        E_SE_REAL_ESTATE_PURCHASE_DOWNSTAIRS = 137,
        E_SE_REAL_ESTATE_PURCHASE_BARTENDER = 138,
        E_SE_REAL_ESTATE_PURCHASE_OFFICE = 139,
        E_SE_REAL_ESTATE_PURCHASE_REC_ROOM = 140,
        E_SE_REAL_ESTATE_SELECT_BAR_ENTER = 141,
        E_SE_REAL_ESTATE_SELECT_BAR_EXIT = 142,
        E_SE_REAL_ESTATE_SELECT_BARTENDER_ENTER = 143,
        E_SE_REAL_ESTATE_SELECT_BARTENDER_EXIT = 144,
        E_SE_REAL_ESTATE_SELECT_BOUNCER_ENTER = 145,
        E_SE_REAL_ESTATE_SELECT_BOUNCER_EXIT = 146,
        E_SE_REAL_ESTATE_SELECT_CENTERPIECE_ENTER = 147,
        E_SE_REAL_ESTATE_SELECT_CENTERPIECE_EXIT = 148,
        E_SE_REAL_ESTATE_SELECT_DOWNSTAIRS_ENTER = 149,
        E_SE_REAL_ESTATE_SELECT_DOWNSTAIRS_EXIT = 150,
        E_SE_REAL_ESTATE_SELECT_KITCHEN_ENTER = 151,
        E_SE_REAL_ESTATE_SELECT_KITCHEN_EXIT = 152,
        E_SE_REAL_ESTATE_SELECT_MURAL_ENTER = 153,
        E_SE_REAL_ESTATE_SELECT_MURAL_EXIT = 154,
        E_SE_REAL_ESTATE_SELECT_MUSIC_ENTER = 155,
        E_SE_REAL_ESTATE_SELECT_MUSIC_EXIT = 156,
        E_SE_REAL_ESTATE_SELECT_OFFICE_ENTER = 157,
        E_SE_REAL_ESTATE_SELECT_OFFICE_EXIT = 158,
        E_SE_REAL_ESTATE_SELECT_REC_ROOM_ENTER = 159,
        E_SE_REAL_ESTATE_SELECT_REC_ROOM_EXIT = 160,
        E_SE_REAL_ESTATE_SELECT_REPAIR_ENTER = 161,
        E_SE_REAL_ESTATE_SELECT_REPAIR_EXIT = 162,
        E_SE_REAL_ESTATE_SELECT_STAFF_ENTER = 163,
        E_SE_REAL_ESTATE_SELECT_STAFF_EXIT = 164,
        E_SE_REAL_ESTATE_SELECT_UPSTAIRS_ENTER = 165,
        E_SE_REAL_ESTATE_SELECT_UPSTAIRS_EXIT = 166
    }

    [Flags]
    public enum EInputControlUnified : uint
    {
        E_VIK_UNDEFINED = 0xFFFFFFFF,
        E_VIK_ESCAPE = 1,
        E_VIK_1 = 2,
        E_VIK_2 = 3,
        E_VIK_3 = 4,
        E_VIK_4 = 5,
        E_VIK_5 = 6,
        E_VIK_6 = 7,
        E_VIK_7 = 8,
        E_VIK_8 = 9,
        E_VIK_9 = 10,
        E_VIK_0 = 11,
        E_VIK_MINUS = 12,
        E_VIK_EQUALS = 13,
        E_VIK_BACK = 14,
        E_VIK_TAB = 15,
        E_VIK_Q = 16,
        E_VIK_W = 17,
        E_VIK_E = 18,
        E_VIK_R = 19,
        E_VIK_T = 20,
        E_VIK_Y = 21,
        E_VIK_U = 22,
        E_VIK_I = 23,
        E_VIK_O = 24,
        E_VIK_P = 25,
        E_VIK_LBRACKET = 26,
        E_VIK_RBRACKET = 27,
        E_VIK_RETURN = 28,
        E_VIK_LCONTROL = 29,
        E_VIK_A = 30,
        E_VIK_S = 31,
        E_VIK_D = 32,
        E_VIK_F = 33,
        E_VIK_G = 34,
        E_VIK_H = 35,
        E_VIK_J = 36,
        E_VIK_K = 37,
        E_VIK_L = 38,
        E_VIK_SEMICOLON = 39,
        E_VIK_APOSTROPHE = 40,
        E_VIK_GRAVE = 41,
        E_VIK_LSHIFT = 42,
        E_VIK_BACKSLASH = 43,
        E_VIK_Z = 44,
        E_VIK_X = 45,
        E_VIK_C = 46,
        E_VIK_V = 47,
        E_VIK_B = 48,
        E_VIK_N = 49,
        E_VIK_M = 50,
        E_VIK_COMMA = 51,
        E_VIK_PERIOD = 52,
        E_VIK_SLASH = 53,
        E_VIK_RSHIFT = 54,
        E_VIK_MULTIPLY = 55,
        E_VIK_LMENU = 56,
        E_VIK_SPACE = 57,
        E_VIK_CAPITAL = 58,
        E_VIK_F1 = 59,
        E_VIK_F2 = 60,
        E_VIK_F3 = 61,
        E_VIK_F4 = 62,
        E_VIK_F5 = 63,
        E_VIK_F6 = 64,
        E_VIK_F7 = 65,
        E_VIK_F8 = 66,
        E_VIK_F9 = 67,
        E_VIK_F10 = 68,
        E_VIK_NUMLOCK = 69,
        E_VIK_SCROLL = 70,
        E_VIK_NUMPAD7 = 71,
        E_VIK_NUMPAD8 = 72,
        E_VIK_NUMPAD9 = 73,
        E_VIK_SUBTRACT = 74,
        E_VIK_NUMPAD4 = 75,
        E_VIK_NUMPAD5 = 76,
        E_VIK_NUMPAD6 = 77,
        E_VIK_ADD = 78,
        E_VIK_NUMPAD1 = 79,
        E_VIK_NUMPAD2 = 80,
        E_VIK_NUMPAD3 = 81,
        E_VIK_NUMPAD0 = 82,
        E_VIK_DECIMAL = 83,
        E_VIK_OEM_102 = 86,
        E_VIK_F11 = 87,
        E_VIK_F12 = 88,
        E_VIK_F13 = 100,
        E_VIK_F14 = 101,
        E_VIK_F15 = 102,
        E_VIK_KANA = 112,
        E_VIK_ABNT_C1 = 115,
        E_VIK_CONVERT = 121,
        E_VIK_NOCONVERT = 123,
        E_VIK_YEN = 125,
        E_VIK_ABNT_C2 = 126,
        E_VIK_NUMPADEQUALS = 141,
        E_VIK_PREVTRACK = 144,
        E_VIK_AT = 145,
        E_VIK_COLON = 146,
        E_VIK_UNDERLINE = 147,
        E_VIK_KANJI = 148,
        E_VIK_STOP = 149,
        E_VIK_AX = 150,
        E_VIK_UNLABELED = 151,
        E_VIK_NEXTTRACK = 153,
        E_VIK_NUMPADENTER = 156,
        E_VIK_RCONTROL = 157,
        E_VIK_MUTE = 160,
        E_VIK_CALCULATOR = 161,
        E_VIK_PLAYPAUSE = 162,
        E_VIK_MEDIASTOP = 164,
        E_VIK_VOLUMEDOWN = 174,
        E_VIK_VOLUMEUP = 176,
        E_VIK_WEBHOME = 178,
        E_VIK_NUMPADCOMMA = 179,
        E_VIK_DIVIDE = 181,
        E_VIK_SYSRQ = 183,
        E_VIK_RMENU = 184,
        E_VIK_PAUSE = 197,
        E_VIK_HOME = 199,
        E_VIK_UP = 200,
        E_VIK_PRIOR = 201,
        E_VIK_LEFT = 203,
        E_VIK_RIGHT = 205,
        E_VIK_END = 207,
        E_VIK_DOWN = 208,
        E_VIK_NEXT = 209,
        E_VIK_INSERT = 210,
        E_VIK_DELETE = 211,
        E_VIK_LWIN = 219,
        E_VIK_RWIN = 220,
        E_VIK_APPS = 221,
        E_VIK_POWER = 222,
        E_VIK_SLEEP = 223,
        E_VIK_WAKE = 227,
        E_VIK_WEBSEARCH = 229,
        E_VIK_WEBFAVORITES = 230,
        E_VIK_WEBREFRESH = 231,
        E_VIK_WEBSTOP = 232,
        E_VIK_WEBFORWARD = 233,
        E_VIK_WEBBACK = 234,
        E_VIK_MYCOMPUTER = 235,
        E_VIK_MAIL = 236,
        E_VIK_MEDIASELECT = 237,
        E_AXIS_X = 300,
        E_AXIS_Y = 301,
        E_AXIS_Z = 302,
        E_AXIS_RX = 303,
        E_AXIS_RY = 304,
        E_AXIS_RZ = 305,
        E_AXIS_U = 306,
        E_AXIS_V = 307,
        E_AXIS_GYRO = 308,
        E_CB_LEFT = 400,
        E_CB_RIGHT = 401,
        E_CB_MIDDLE = 402,
        E_GPB_START = 500,
        E_GPB_BACK = 501,
        E_GPB_LEFT_THUMB = 502,
        E_GPB_RIGHT_THUMB = 503,
        E_GPB_LEFT_SHOULDER = 504,
        E_GPB_RIGHT_SHOULDER = 505,
        E_GPB_BUTT_A = 506,
        E_GPB_BUTT_B = 507,
        E_GPB_BUTT_X = 508,
        E_GPB_BUTT_Y = 509,
        E_GPB_DPAD_UP = 510,
        E_GPB_DPAD_DOWN = 511,
        E_GPB_DPAD_LEFT = 512,
        E_GPB_DPAD_RIGHT = 513,
        E_GPB_LEFT_GRIP = 514,
        E_GPB_RIGHT_GRIP = 515,
        E_DF_LEFT = 600,
        E_DF_RIGHT = 601,
        E_DF_UP = 602,
        E_DF_DOWN = 603,
        E_DF_HORISONTAL = 604,
        E_DF_VERTICAL = 605,
        E_TOUCH = 700,
        E_TOUCH_MOVE_X = 701,
        E_TOUCH_MOVE_Y = 702
    }

    [Flags]
    public enum EKeyModifiers
    {
        E_KM_LCONTROL = 0x00000001,
        E_KM_RCONTROL = 0x00000002,
        E_KM_CONTROL = 0x00001000,
        E_KM_LSHIFT = 0x00000004,
        E_KM_RSHIFT = 0x00000008,
        E_KM_SHIFT = 0x00002000,
        E_KM_LALT = 0x00000010,
        E_KM_RALT = 0x00000020,
        E_KM_ALT = 0x00004000,
        E_KM_LWIN = 0x00000040,
        E_KM_RWIN = 0x00000080,
        E_KM_WIN = 0x00008000,
        E_KM_CAPS_LOCK = 0x00000100,
        E_KM_NUM_LOCK = 0x00000200,
        E_KM_SCROLL_LOCK = 0x00000400
    }

    [Flags]
    public enum EPlayerControllerDeviceType
    {
        E_PCDT_KEYBOARD_MOUSE = 0,
        E_PCDT_JOYSTICK_CLASS = 1
    }

    [Flags]
    public enum EAxisMode
    {
        E_AM_FULL_AXIS = 0,
        E_AM_NEGATIVE_AXIS = 1,
        E_AM_POSITIVE_AXIS = 2,
        E_AM_FULL_AXIS_INV = 3,
        E_AM_LAST = 4
    }

    [Flags]
    public enum EControllerType
    {
        E_CT_PRIMARY = 0,
        E_CT_SECONDARY = 1
    }

    [Flags]
    public enum EControls
    {
        E_CTRL_UP = 0,
        E_CTRL_DOWN = 1,
        E_CTRL_LEFT = 2,
        E_CTRL_RIGHT = 3,
        E_CTRL_AIM_X = 4,
        E_CTRL_AIM_Y = 5,
        E_CTRL_RUN = 6,
        E_CTRL_RUN_SWITCH = 7,
        E_CTRL_SPRINT = 8,
        E_CTRL_WALK = 9,
        E_CTRL_WALK_SWITCH = 10,
        E_CTRL_CLIMB = 11,
        E_CTRL_CROUCH = 12,
        E_CTRL_STALK = 13,
        E_CTRL_COVER_ENTER = 14,
        E_CTRL_COVER_SWITCH = 15,
        E_CTRL_AWARENESS = 16,
        E_CTRL_FIRE = 17,
        E_CTRL_RELOAD = 18,
        E_CTRL_PICKUP_WEAPON = 19,
        E_CTRL_ACTION = 20,
        E_CTRL_ACTIONPRESS = 21,
        E_CTRL_BREAK = 22,
        E_CTRL_ENTER_CAR = 23,
        E_CTRL_GENERIC_ACTION_1 = 24,
        E_CTRL_GENERIC_ACTION_2 = 25,
        E_CTRL_INTERACT_LONG = 26,
        E_CTRL_INTERACT_LONG_2 = 27,
        E_CTRL_INTERACT_LONG_3 = 28,
        E_CTRL_INTERACT_SPECIAL_LONG = 29,
        E_CTRL_INTERACT_SPECIAL_LONG_2 = 30,
        E_CTRL_INTERACT_VERY_LONG = 31,
        E_CTRL_INTERACT_VEHICLE = 32,
        E_CTRL_INTERACT_VEHICLE_2 = 33,
        E_CTRL_ZOOM = 34,
        E_CTRL_CAMERASIDE = 35,
        E_CTRL_SHARPSHOOTER = 36,
        E_CTRL_PREV_WEAPON = 37,
        E_CTRL_NEXT_WEAPON = 38,
        E_CTRL_HOLSTER = 39,
        E_CTRL_DROP = 40,
        E_CTRL_WEAPON_SELECT_UP = 41,
        E_CTRL_WEAPON_SELECT_DOWN = 42,
        E_CTRL_WEAPON_SELECT_LEFT = 43,
        E_CTRL_WEAPON_SELECT_RIGHT = 44,
        E_CTRL_PERK_SELECT_OPEN = 45,
        E_CTRL_PERK_SELECT_NEXT = 46,
        E_CTRL_PERK_SELECT_PREV = 47,
        E_CTRL_PERK_SELECT_CLOSE = 48,
        E_CTRL_MAP = 49,
        E_CTRL_MENU = 50,
        E_CTRL_HIT_1 = 51,
        E_CTRL_HIT_2 = 52,
        E_CTRL_HIT_3 = 53,
        E_CTRL_HIT_4 = 54,
        E_CTRL_BLOCK = 55,
        E_CTRL_TAUNT = 56,
        E_CTRL_WEAPON_TAKEDOWN = 57,
        E_CTRL_DRAW_ATTENTION = 58,
        E_CTRL_COVER_CORNER_TURN = 59,
        E_CTRL_WEAPON_SELECTION_OPEN = 60,
        E_CTRL_WEAPON_SELECTION_CLOSE = 61,
        E_CTRL_WEAPON_SELECTION_AXIS_X = 62,
        E_CTRL_WEAPON_SELECTION_AXIS_Y = 63,
        E_CTRL_WEAPON_SELECTION_DROP = 64,
        E_CTRL_WEAPON_SELECTION_ACCEPT = 65,
        E_CTRL_WEAPON_SELECTION_SWITCH_WHEELS = 66,
        E_CTRL_SPRINT_OLD = 67,
        E_CTRL_COVER_EXIT_FORWARD = 68,
        E_CTRL_WEAPON_GRENADE_AIM = 69,
        E_CTRL_WEAPON_GRENADE_CANCEL = 70,
        E_CTRL_WEAPON_SATCHEL_AIM = 71,
        E_CTRL_WEAPON_SATCHEL_PLACE = 72,
        E_CTRL_WEAPON_SATCHEL_DETONATE = 73,
        E_CTRL_COVER_EXIT = 74,
        E_CTRL_USE_MEDKIT = 75,
        E_CTRL_COVER_DOWN = 76,
        E_CTRL_AIM_ZOOM_MODE = 77,
        E_CTRL_AIM_SHAKE_REDUCE = 78,
        E_CTRL_LOCKPULL_ROTATE = 79,
        E_CTRL_LOCKPULL_SET_POSITION = 80,
        E_CTRL_LOCKPULL_PRY = 81,
        E_CTRL_LOCKPULL_CANCEL = 82,
        E_CTRL_PICKUP_BODY = 83,
        E_CTRL_DROP_BODY = 84,
        E_CTRL_INTEL_VIEW_OPEN = 85,
        E_CTRL_SWITCH_EXPLOSIVES = 86,
        E_CTRL_WEAPON_SELECTION_HOLSTER = 87,
        E_CTRL_WEAPON_SELECTION_USE_MEDKIT = 88,
        E_CTRL_WEAPON_SELECTION_CANCEL = 89,
        E_CTRL_WEAPON_SELECTION_SWITCH_EXPLOSIVES = 90,
        E_CTRL_TAKE_PICTURE = 91,
        E_CTRL_TURRET_MOUNT = 92,
        E_CTRL_TURRET_DISMOUNT = 93,
        E_CTRL_ONFOOT_SLOW_MOTION = 94,
        E_CTRL_PLAYER_CONTROL_ACTIONS_END = 99,
        E_CTRL_CAR_UP = 100,
        E_CTRL_CAR_DOWN = 101,
        E_CTRL_CAR_LEFT = 102,
        E_CTRL_CAR_RIGHT = 103,
        E_CTRL_HANDBRAKE = 104,
        E_CTRL_CAR_DRIVERAIM = 105,
        E_CTRL_CAR_FIRE = 106,
        E_CTRL_CAR_EXIT = 107,
        E_CTRL_CALL_TAXI = 108,
        E_CTRL_ENTER_TAXI = 109,
        E_CTRL_TAXI_SKIP = 110,
        E_CTRL_TAXI_SETLOC = 111,
        E_CTRL_TAXI_BTW = 112,
        E_CTRL_TAXI_STOP = 113,
        E_CTRL_HORN = 114,
        E_CTRL_CAMERA = 115,
        E_CTRL_RADIO = 116,
        E_CTRL_PREV_RADIO = 117,
        E_CTRL_DRIVING_STYLE = 118,
        E_CTRL_LOOKBACK = 119,
        E_CTRL_LOOKBACK_TOGGLE = 120,
        E_CTRL_CAR_BAILOUT = 121,
        E_CTRL_CAR_RAMACTION = 122,
        E_CTRL_VEHICLE_AIM_MODE = 123,
        E_CTRL_VEHICLE_MARKED_TARGET_CYCLE = 124,
        E_CTRL_VEHICLE_WEAPON_GRENADE_AIM = 125,
        E_CTRL_VEHICLE_WEAPON_GRENADE_CANCEL = 126,
        E_CTRL_WEAPON_SATCHEL_DETONATE_CAR = 127,
        E_CTRL_VEHICLE_SLOW_MOTION = 128,
        E_CTRL_CAR_CONTROL_ACTIONS_END = 149,
        E_CTRL_EXIT = 150,
        E_CTRL_SKIP_CUTSCENE = 151,
        E_CTRL_HIT_1_HOLD = 152,
        E_CTRL_HIT_2_HOLD = 153,
        E_CTRL_HIT_3_HOLD = 154,
        E_CTRL_HIT_4_HOLD = 155,
        E_CTRL_LAST = 156
    }
}