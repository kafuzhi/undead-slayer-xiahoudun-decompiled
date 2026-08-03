// Namespace: 
// Type: UI_general

    public class UI_general {{

    private static object MAXGENERAL;
    private static object MAXGENERALPOOL;
    private static object SLOTPRICE;
    private static object MAXWORK;
    private static object MAXTEMPGENERAL;
    public object basicSkin;
    private object cur_general;
    private object sel_general;
    private object comb_general;
    private object jade;
    private object coin;
    private object getslot;
    private object slot_general;
    private object prt_general;
    private object language;
    private object general_seed;
    private object general_hp;
    private object general_cur_hp;
    private object general_exp;
    private object general_grade;
    private object general_level;
    private object ismaxhp;
    private object cur_workdelay;
    private object temp_general;
    private object cardtype_count;
    private object temp_general_cardtype;
    public object general_weapon;
    public object icon_popgeneralkind;
    public object bg_titlename;
    public object bg_general;
    public object star_grade;
    public object gauge_hp;
    public object titlebase;
    public object titlebase3;
    public object hpbase;
    public object icon_jade;
    public object icon_coin;
    public object gauge_exp;
    public object black_all;
    public object black;
    public object arrow_combine;
    public object bg_inherit;
    public object please_touch;
    public object pop_blank;
    public object pop_blank2;
    public object icon_unlock;
    public object bg_speech;
    public object sel_mark;
    public object ico_lock;
    public object bg_red;
    public object empty;
    public object bt_general_small;
    public object card_general;
    public object icon_alarm;
    public object bg_asset;
    public object pausemenu;
    public object bt_dismiss;
    public object bt_general;
    public object bt_roll;
    public object bt_empty;
    public object bt_back;
    public object bt_yesno;
    public object fortune_teller;
    public object sound_dummy;
    public object bg_popui;
    public object bg_card;
    public object bg_combine;
    public object ef_card_l;
    public object ef_card_r;
    public object ef_card_dis;
    public object ani_walk;
    private object sound_UI;
    private object cashshop;
    private object iconmove;
    private object pop_general;
    private object general_index;
    private object general_kind;
    private object g_maxatk;
    private object g_def;
    private object g_maxhp;
    private object g_grade;
    private object g_level;
    private object comb_grade;
    private object comb_level;
    private object comb_maxatk;
    private object comb_def;
    private object comb_maxhp;
    private object comb_get_level;
    private object show_fortune_teller;
    private object confirm;
    private object g_atkspd;
    private object comb_atkspd;
    private object g_exp_length;
    private object comb_exp_length;
    private object comb_exp;
    private object get_exp;
    private object bg_posX_r;
    private object icon_posY;
    private object posX1;
    private object posX2;
    private object cur_generalmaxhp;
    private object f_delay;
    private object cardposY;
    private object showcard_delay;
    private object gaugeup;
    private object changemode;
    private object b_delay;
    private object giftmode;
    private object script_name;
    private object script_generalstat;
    private object script_soundUI;
    private object dragOn;
    private object scrollOn;
    private object prevposX;
    private object currentX;
    private object dragposX;
    private object dragrange;
    private object tutorial;
    private object icon_size;
    private object rnd_speech;
    private object typeslot;
    private object totalcount;
    private object showcard;

    public UI_general() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000D63
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04000D64
    IL_000E: ldarg.0
    IL_000F: ldc.i4.m1
    IL_0014: stfld 0x04000D65
    IL_0015: ldarg.0
    IL_0017: ldc.i4.s 12
    IL_001C: newarr 0x0100003C
    IL_0021: stfld 0x04000D6A
    IL_0022: ldarg.0
    IL_0024: ldc.i4.s 12
    IL_0029: newarr 0x0100000B
    IL_002E: stfld 0x04000D6C
    IL_002F: ldarg.0
    IL_0031: ldc.i4.s 12
    IL_0036: newarr 0x0100000B
    IL_003B: stfld 0x04000D6D
    IL_003C: ldarg.0
    IL_003E: ldc.i4.s 12
    IL_0043: newarr 0x0100000B
    IL_0048: stfld 0x04000D6E
    IL_0049: ldarg.0
    IL_004B: ldc.i4.s 12
    IL_0050: newarr 0x0100000B
    IL_0055: stfld 0x04000D6F
    IL_0056: ldarg.0
    IL_0058: ldc.i4.s 12
    IL_005D: newarr 0x01000010
    IL_0062: stfld 0x04000D70
    IL_0063: ldarg.0
    IL_0065: ldc.i4.s 12
    IL_006A: newarr 0x01000010
    IL_006F: stfld 0x04000D71
    IL_0070: ldarg.0
    IL_0072: ldc.i4.s 12
    IL_0077: newarr 0x01000013
    IL_007C: stfld 0x04000D72
    IL_007D: ldarg.0
    IL_007E: ldc.i4.2
    IL_0083: newarr 0x0100000B
    IL_0088: stfld 0x04000D73
    IL_0089: ldarg.0
    IL_008B: ldc.i4.s 50
    IL_0090: newarr 0x0100000B
    IL_0095: stfld 0x04000D74
    IL_0096: ldarg.0
    IL_0097: ldc.i4.3
    IL_009C: newarr 0x0100000B
    IL_00A1: stfld 0x04000D75
    IL_00A2: ldarg.0
    IL_00A4: ldc.i4.s 50
    IL_00A9: newarr 0x0100000B
    IL_00AE: stfld 0x04000D76
    IL_00AF: ldarg.0
    IL_00B0: ldc.i4.5
    IL_00B5: newarr 0x0100003C
    IL_00BA: stfld 0x04000D77
    IL_00BB: ldarg.0
    IL_00BC: ldc.i4.3
    IL_00C1: newarr 0x0100003C
    IL_00C6: stfld 0x04000D78
    IL_00C7: ldarg.0
    IL_00C8: ldc.i4.3
    IL_00CD: newarr 0x0100003C
    IL_00D2: stfld 0x04000D91
    IL_00D3: ldarg.0
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: IL_F0
    IL_00D8: IL_43
    IL_00DD: stfld 0x04000DBD
    IL_00DE: ldarg.0
    IL_00DF: IL_22
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: IL_AA
    IL_00E3: IL_43
    IL_00E8: stfld 0x04000DBE
    IL_00E9: ldarg.0
    IL_00EA: IL_22
    IL_00EB: nop
    IL_00F0: stsfld 0xC17D44BB
    IL_00F1: stloc.3
    IL_00F2: nop
    IL_00F3: ldarg.2
    IL_00F4: ldarg.0
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: IL_C8
    IL_00F9: IL_C2
    IL_00FE: stfld 0x04000DC3
    IL_00FF: ldarg.0
    IL_0100: ldc.i4.m1
    IL_0105: stfld 0x04000DD2
    IL_0106: ldarg.0
    IL_0107: ldc.i4.m1
    IL_010C: stfld 0x04000DD5
    IL_010D: ldarg.0
    IL_0112: call 0x0A000001
    IL_0113: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000085
    IL_000B: stfld 0x04000DC9
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000067
    IL_0017: stfld 0x04000DCA
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000BB3
    IL_0022: call 0x0A000095
    IL_0027: stfld 0x04000D6B
    IL_0028: ldarg.0
    IL_002D: ldstr 0x70001F2D
    IL_0032: call 0x06000220
    IL_0037: stfld 0x04000D63
    IL_0038: ldarg.0
    IL_003D: ldstr 0x70001F15
    IL_0042: call 0x060003F9
    IL_0047: stfld 0x04000D6C
    IL_0048: ldarg.0
    IL_004D: ldstr 0x70001F25
    IL_0052: call 0x060003F9
    IL_0057: stfld 0x04000D6F
    IL_0058: ldarg.0
    IL_005D: ldstr 0x70001F1D
    IL_0062: call 0x060003F9
    IL_0067: stfld 0x04000D6D
    IL_0068: ldarg.0
    IL_006D: ldstr 0x70001EAD
    IL_0072: call 0x06000220
    IL_0077: stfld 0x04000D69
    IL_0078: ldarg.0
    IL_007D: ldstr 0x70002093
    IL_0082: call 0x06000220
    IL_0087: stfld 0x04000DD2
    IL_0088: ldarg.0
    IL_008D: ldstr 0x700236FF
    IL_0092: call 0x060003F9
    IL_0097: stfld 0x04000D74
    IL_0098: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000D67
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000D66
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000DA
    IL_0006: conv.i2
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_C0
    IL_000B: IL_3E
    IL_000C: IL_5A
    IL_0011: stfld 0x04000DD1
    IL_0016: ldstr 0x70000121
    IL_001B: call 0x0A000004
    IL_001C: ldnull
    IL_0021: call 0x0A000061
    IL_0026: brfalse IL_004C
    IL_0027: ldarg.0
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000D9C
    IL_0032: call 0x0A00001B
    IL_0037: call 0x0A000013
    IL_003C: call 0x0A000014
    IL_003D: conv.u4
    IL_003E: ldarg.1
    IL_003F: nop
    IL_0040: nop
    IL_0041: IL_01
    IL_0046: stfld 0x04000DA4
    IL_004B: br IL_0061
    IL_004C: ldarg.0
    IL_0051: ldstr 0x70000121
    IL_0056: call 0x0A000004
    IL_0057: conv.r8
    IL_0058: ldarg.3
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_0060: stfld 0x04000DA4
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000DA4
    IL_0068: conv.r8
    IL_006D: ldsfld 0x7D2B0000
    IL_006E: IL_CB
    IL_006F: stloc.3
    IL_0070: nop
    IL_0071: ldarg.2
    IL_0072: ldarg.0
    IL_0077: call 0x0600067B
    IL_0078: ldarg.0
    IL_0079: ldc.i4.1
    IL_007E: call 0x06000679
    IL_007F: ldarg.0
    IL_0084: call 0x06000674
    IL_0085: ldarg.0
    IL_008A: ldstr 0x700232A7
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_E8
    IL_008F: IL_41
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0093: IL_F0
    IL_0094: IL_41
    IL_0099: call 0x0A000017
    IL_009E: ldstr 0x70023EF1
    IL_00A3: call 0x0A000095
    IL_00A4: stloc.0
    IL_00A5: ldloc.0
    IL_00A6: ldc.i4.1
    IL_0107: switch (23 cases)
    IL_0108: IL_CC
    IL_0109: IL_CC
    IL_010A: IL_3E
    IL_010F: newobj 0x0A000076
    IL_0110: conv.r8
    IL_0111: conv.ovf.i4.un
    IL_0112: IL_01
    IL_0113: nop
    IL_0114: stloc.0
    IL_0115: ldarg.0
    IL_011A: ldfld 0x04000D9D
    IL_011F: call 0x0A00004B
    IL_0120: IL_22
    IL_0121: shr
    IL_0122: shr
    IL_0127: isinst 0x00082840
    IL_0128: nop
    IL_0129: stloc.0
    IL_012A: conv.r8
    IL_012B: IL_AF
    IL_012C: nop
    IL_012D: nop
    IL_012E: stloc.0
    IL_012F: ldarg.0
    IL_0134: ldstr 0x70023285
    IL_0135: IL_22
    IL_0136: nop
    IL_0137: nop
    IL_013C: stsfld 0x147B223F
    IL_013D: IL_AE
    IL_013E: IL_3E
    IL_0143: call 0x0A000017
    IL_0144: ldarg.0
    IL_0149: call 0x0600067D
    IL_014E: ldstr 0x70000617
    IL_014F: ldc.i4.8
    IL_0154: call 0x0A00009F
    IL_0155: ret
    }

    private void SetServerTime() {
    IL_0004: call 0x0600056E
    IL_0005: ldarg.0
    IL_000A: call 0x06000675
    IL_000B: ret
    }

    public void DelayWorkTime() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0019
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000D73
    IL_000D: ldloc.0
    IL_000E: ldloc.0
    IL_0013: call 0x0600056F
    IL_0014: ldelem.i8
    IL_0015: ldloc.0
    IL_0016: ldc.i4.1
    IL_0017: IL_58
    IL_0018: stloc.0
    IL_0019: ldloc.0
    IL_001A: ldc.i4.2
    IL_001B: IL_3F
    IL_001C: IL_E7
    IL_001D: IL_FF
    IL_001E: IL_FF
    IL_001F: IL_FF
    IL_0020: ldc.i4.0
    IL_0021: stloc.1
    IL_0026: br IL_0059
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000D72
    IL_002D: ldloc.1
    IL_002E: IL_91
    IL_0033: brtrue IL_0055
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000D6E
    IL_003A: ldloc.1
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000D6D
    IL_0041: ldloc.1
    IL_0042: IL_94
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000D73
    IL_0049: ldc.i4.1
    IL_004A: IL_94
    IL_004B: conv.i2
    IL_004C: IL_22
    IL_004D: IL_CD
    IL_004E: IL_CC
    IL_004F: IL_4C
    IL_0050: IL_3E
    IL_0051: IL_5A
    IL_0052: not
    IL_0053: IL_58
    IL_0054: ldelem.i8
    IL_0055: ldloc.1
    IL_0056: ldc.i4.1
    IL_0057: IL_58
    IL_0058: stloc.1
    IL_0059: ldloc.1
    IL_005B: ldc.i4.s 12
    IL_005C: IL_3F
    IL_005D: IL_C6
    IL_005E: IL_FF
    IL_005F: IL_FF
    IL_0060: IL_FF
    IL_0061: ret
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000DD3
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000DD3
    IL_0010: ret
    }

    public void GeneralStat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DCA
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_F5
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000DCA
    IL_0017: ldfld 0x04000675
    IL_001C: stfld 0x04000DA8
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000DCA
    IL_0028: ldfld 0x04000676
    IL_002D: stfld 0x04000DA9
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000DCA
    IL_0039: ldfld 0x04000678
    IL_003E: stfld 0x04000DAA
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000DCA
    IL_004A: ldfld 0x04000679
    IL_004F: stfld 0x04000DAB
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000DCA
    IL_005B: ldfld 0x04000677
    IL_0060: stfld 0x04000DAC
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000DCA
    IL_006C: ldfld 0x0400067A
    IL_0071: stfld 0x04000DB7
    IL_0072: ldarg.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000DCA
    IL_007D: ldfld 0x0400067D
    IL_0082: stfld 0x04000DAD
    IL_0083: ldarg.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000DCA
    IL_008E: ldfld 0x0400067C
    IL_0093: stfld 0x04000DAE
    IL_0094: ldarg.2
    IL_0099: brtrue IL_0110
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000D6D
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000D68
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x04000DAC
    IL_00AC: ldelem.i8
    IL_00AD: ldarg.0
    IL_00B2: ldfld 0x04000D6E
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x04000D68
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x04000DAC
    IL_00BF: ldelem.i8
    IL_00C4: ldstr 0x70001F1D
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04000D6E
    IL_00CF: call 0x060003F8
    IL_00D0: pop
    IL_00D1: ldc.i4.1
    IL_00D6: call 0x0600056B
    IL_00DB: ldstr 0x70001FD3
    IL_00E0: call 0x060003F9
    IL_00E1: stloc.0
    IL_00E2: ldloc.0
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000DA8
    IL_00E9: ldloc.0
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000DA8
    IL_00F0: IL_94
    IL_00F1: ldarg.0
    IL_00F6: ldfld 0x04000DAD
    IL_00F7: ldc.i4.1
    IL_00F8: IL_58
    IL_00FD: call 0x0A000080
    IL_00FE: ldelem.i8
    IL_0103: ldstr 0x70001FD3
    IL_0104: ldloc.0
    IL_0109: call 0x060003F8
    IL_010A: pop
    IL_010F: br IL_01A7
    IL_0110: ldarg.0
    IL_0115: ldfld 0x04000D6E
    IL_0116: ldarg.0
    IL_011B: ldfld 0x04000D64
    IL_011C: IL_94
    IL_011D: ldarg.0
    IL_0122: ldfld 0x04000DAC
    IL_0123: IL_3F
    IL_0124: pop
    IL_0125: nop
    IL_0126: nop
    IL_0127: nop
    IL_0128: ldarg.0
    IL_012D: ldfld 0x04000D6E
    IL_012E: ldarg.0
    IL_0133: ldfld 0x04000D64
    IL_0134: ldarg.0
    IL_0139: ldfld 0x04000DAC
    IL_013A: ldelem.i8
    IL_013B: ldarg.0
    IL_0140: ldfld 0x04000D72
    IL_0141: ldarg.0
    IL_0146: ldfld 0x04000D64
    IL_0147: ldc.i4.1
    IL_0148: ldelem.i2
    IL_014D: br IL_016F
    IL_014E: ldarg.0
    IL_0153: ldfld 0x04000D6E
    IL_0154: ldarg.0
    IL_0159: ldfld 0x04000D64
    IL_015A: IL_94
    IL_015B: ldc.i4.0
    IL_015C: IL_3D
    IL_015E: ldarg.s 0
    IL_015F: nop
    IL_0160: nop
    IL_0161: ldarg.0
    IL_0166: ldfld 0x04000D6E
    IL_0167: ldarg.0
    IL_016C: ldfld 0x04000D64
    IL_016D: ldc.i4.1
    IL_016E: ldelem.i8
    IL_016F: ldarg.0
    IL_0170: ldarg.0
    IL_0175: ldfld 0x04000D6F
    IL_0176: ldarg.0
    IL_017B: ldfld 0x04000D64
    IL_017C: IL_94
    IL_017E: ldc.i4.s 58
    IL_017F: IL_5A
    IL_0180: conv.i2
    IL_0182: ldc.i4.s 100
    IL_0183: ldarg.0
    IL_0188: ldfld 0x04000DAE
    IL_0189: ldc.i4.6
    IL_018A: IL_5A
    IL_018B: IL_58
    IL_018C: conv.i2
    IL_018D: IL_22
    IL_018E: nop
    IL_018F: nop
    IL_0194: stsfld 0xAD7B023F
    IL_0195: stloc.3
    IL_0196: nop
    IL_0197: ldarg.2
    IL_0198: conv.i2
    IL_0199: IL_22
    IL_019A: IL_CD
    IL_019B: IL_CC
    IL_019C: IL_4C
    IL_019D: IL_3E
    IL_019E: IL_5A
    IL_019F: IL_58
    IL_01A0: IL_5A
    IL_01A1: add
    IL_01A6: stfld 0x04000DB9
    IL_01A7: ret
    }

    public void FortuneTell() {
    IL_0000: ldc.i4.4
    IL_0005: newarr 0x0100000B
    IL_0006: stloc.0
    IL_0007: ldc.i4.4
    IL_000C: newarr 0x0100000B
    IL_000D: stloc.1
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000D6C
    IL_0014: ldarg.0
    IL_0019: ldfld 0x04000D64
    IL_001A: IL_94
    IL_001B: stloc.2
    IL_001C: ldc.i4.0
    IL_001D: stloc.3
    IL_0022: br IL_004C
    IL_0023: ldloc.1
    IL_0024: ldloc.3
    IL_0025: ldloc.2
    IL_0027: ldc.i4.s 10
    IL_0028: mul
    IL_0029: ldelem.i8
    IL_002A: ldloc.2
    IL_002C: ldc.i4.s 10
    IL_002D: add
    IL_002E: stloc.2
    IL_002F: ldloc.0
    IL_0030: ldloc.1
    IL_0031: ldloc.3
    IL_0032: ldc.i4.4
    IL_0033: mul
    IL_0034: IL_94
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000DA8
    IL_003B: IL_58
    IL_003C: ldc.i4.4
    IL_003D: mul
    IL_003E: IL_8F
    IL_003F: stloc.1
    IL_0040: nop
    IL_0041: nop
    IL_0042: IL_01
    IL_0043: dup
    IL_0046: stloc 22551
    IL_0047: IL_54
    IL_0048: ldloc.3
    IL_0049: ldc.i4.1
    IL_004A: IL_58
    IL_004B: stloc.3
    IL_004C: ldloc.3
    IL_004D: ldc.i4.4
    IL_004E: IL_3F
    IL_0053: ldtoken 0x02FFFFFF
    IL_0058: ldfld 0x04000D9B
    IL_0059: conv.r8
    IL_005A: stloc.0
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ldc.i4.1
    IL_005F: conv.r8
    IL_0060: stloc.1
    IL_0061: nop
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000D9B
    IL_006A: conv.r8
    IL_006B: IL_89
    IL_006C: nop
    IL_006D: nop
    IL_006F: br.s IL_0076
    IL_0070: ldc.i4.0
    IL_0071: IL_94
    IL_0072: ldc.i4.1
    IL_0073: IL_58
    IL_0074: ldloc.0
    IL_0075: ldc.i4.1
    IL_0076: IL_94
    IL_0077: ldc.i4.1
    IL_0078: IL_58
    IL_0079: ldloc.0
    IL_007A: ldc.i4.2
    IL_007B: IL_94
    IL_007C: ldc.i4.1
    IL_007D: IL_58
    IL_007E: ldloc.0
    IL_007F: ldc.i4.3
    IL_0080: IL_94
    IL_0081: ldc.i4.1
    IL_0082: IL_58
    IL_0083: conv.r8
    IL_0084: IL_EF
    IL_0085: ldarg.0
    IL_0086: nop
    IL_0087: ldloc.0
    IL_0088: ret
    }

    public void CurGeneralStat() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0041
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000D63
    IL_000C: ldc.i4.m1
    IL_0011: beq IL_003C
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000DCA
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000D6C
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000D63
    IL_0024: IL_94
    IL_0025: conv.r8
    IL_0026: IL_F5
    IL_0027: ldarg.0
    IL_0028: nop
    IL_0029: ldloc.0
    IL_002A: ldarg.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000DCA
    IL_0035: ldfld 0x04000677
    IL_0036: conv.i2
    IL_003B: stfld 0x04000DC1
    IL_0040: br IL_004E
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000DAC
    IL_0048: conv.i2
    IL_004D: stfld 0x04000DC1
    IL_004E: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000DC7
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000DC2
    IL_000E: ret
    }

    public void GeneralKindOnly() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0008: br IL_008C
    IL_0009: ldarg.0
    IL_000E: ldfld 0x04000D6C
    IL_000F: ldloc.1
    IL_0010: IL_94
    IL_0011: ldc.i4.0
    IL_0012: IL_3E
    IL_0017: ldobj 0x02000000
    IL_001C: ldfld 0x04000D6C
    IL_001D: ldloc.1
    IL_001E: IL_94
    IL_0023: ldc.i4 10000000
    IL_0024: mul
    IL_0029: ldc.i4 100000
    IL_002A: add
    IL_002B: stloc.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000D70
    IL_0032: ldloc.1
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000D6C
    IL_0039: ldloc.1
    IL_003A: IL_94
    IL_003F: ldc.i4 100000
    IL_0040: mul
    IL_0045: ldc.i4 10000
    IL_0046: add
    IL_0047: neg
    IL_0048: ldelem.i4
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000D71
    IL_004F: ldloc.1
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000D6C
    IL_0056: ldloc.1
    IL_0057: IL_94
    IL_0058: conv.i2
    IL_0059: IL_22
    IL_005E: stsfld 0x5B4B1896
    IL_005F: neg
    IL_0060: ldelem.i4
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000D6A
    IL_0067: ldloc.1
    IL_006C: ldstr 0x70022E37
    IL_006D: ldloc.0
    IL_006E: ldc.i4.1
    IL_006F: IL_58
    IL_0070: stloc.2
    IL_0072: ldloca.s 2
    IL_0077: call 0x0A000010
    IL_007C: call 0x0A000011
    IL_0081: call 0x0A000012
    IL_0082: conv.u8
    IL_0083: IL_3C
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_01
    IL_008B: stelem 0x0B581707
    IL_008C: ldloc.1
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000D69
    IL_0093: IL_3F
    IL_0098: ldobj 0x2AFFFFFF
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DC7
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000DC2
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000DC2
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000DC2
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_42
    IL_002A: ldloca.s 0
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000DC7
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000DC2
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000DD7
    IL_0045: ldc.i4.0
    IL_0046: IL_3E
    IL_0047: IL_F6
    IL_0048: IL_01
    IL_0049: nop
    IL_004A: nop
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000DD7
    IL_0051: ldc.i4.3
    IL_03FA: switch (233 cases)
    IL_03FB: IL_22
    IL_03FC: nop
    IL_03FD: nop
    IL_03FE: nop
    IL_03FF: nop
    IL_0784: switch (224 cases)
    IL_0785: nop
    IL_0786: ldarg.2
    IL_0787: ldc.i4.1
    IL_0788: IL_58
    IL_078A: ldc.i4.s 20
    IL_078B: IL_5A
    IL_078C: IL_3F
    IL_078D: stloc.1
    IL_078E: nop
    IL_078F: nop
    IL_0790: nop
    IL_0791: ldarg.0
    IL_0792: IL_22
    IL_0793: nop
    IL_0794: nop
    IL_0795: nop
    IL_0796: nop
    IL_079B: stfld 0x04000DBC
    IL_079C: ldarg.0
    IL_07A1: ldfld 0x04000DBC
    IL_07A2: IL_22
    IL_07A3: nop
    IL_07A4: nop
    IL_07A5: nop
    IL_07A6: nop
    IL_07A7: IL_42
    IL_07A8: IL_3C
    IL_07A9: nop
    IL_07AA: nop
    IL_07AB: nop
    IL_07AC: ldarg.0
    IL_07B1: ldfld 0x04000D6F
    IL_07B2: ldarg.0
    IL_07B7: ldfld 0x04000D65
    IL_07B8: ldarg.0
    IL_07BD: ldfld 0x04000DBB
    IL_07BE: not
    IL_07BF: ldelem.i8
    IL_07C0: ldarg.0
    IL_07C5: ldfld 0x04000D6C
    IL_07C6: ldarg.0
    IL_07CB: ldfld 0x04000D65
    IL_07CC: IL_8F
    IL_07CD: stloc.1
    IL_07CE: nop
    IL_07CF: nop
    IL_07D0: IL_01
    IL_07D1: dup
    IL_07D4: stloc 32800
    IL_07D5: IL_96
    IL_07D6: IL_98
    IL_07D7: nop
    IL_07D8: ldarg.0
    IL_07DD: ldfld 0x04000DB4
    IL_07DE: IL_5A
    IL_07DF: IL_58
    IL_07E0: IL_54
    IL_07E1: ldarg.0
    IL_07E2: ldc.i4.1
    IL_07E7: stfld 0x04000DC5
    IL_07E8: ldarg.0
    IL_07E9: ldarg.0
    IL_07EE: ldfld 0x04000DBB
    IL_07EF: IL_22
    IL_07F0: nop
    IL_07F1: nop
    IL_07F2: neg
    IL_07F3: IL_42
    IL_07F4: IL_5A
    IL_07F6: ldc.i4.s 100
    IL_07F7: ldarg.0
    IL_07FC: ldfld 0x04000DB0
    IL_07FD: ldc.i4.6
    IL_07FE: IL_5A
    IL_07FF: IL_58
    IL_0800: conv.i2
    IL_0801: IL_22
    IL_0802: nop
    IL_0803: nop
    IL_0808: stsfld 0xAF7B023F
    IL_0809: stloc.3
    IL_080A: nop
    IL_080B: ldarg.2
    IL_080C: conv.i2
    IL_080D: IL_22
    IL_080E: IL_CD
    IL_080F: IL_CC
    IL_0810: IL_4C
    IL_0811: IL_3E
    IL_0812: IL_5A
    IL_0813: IL_58
    IL_0814: IL_5A
    IL_0815: add
    IL_081A: stfld 0x04000DBA
    IL_081B: ldarg.0
    IL_0820: ldfld 0x04000DC2
    IL_0821: IL_22
    IL_0822: nop
    IL_0823: nop
    IL_0824: nop
    IL_0825: nop
    IL_0A1E: switch (125 cases)
    }

    private void SetGiftCount() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000DD6
    IL_0007: ldarg.0
    IL_0009: ldc.i4.s 50
    IL_000E: newarr 0x0100000B
    IL_0013: stfld 0x04000D76
    IL_0014: ldarg.0
    IL_0015: ldc.i4.3
    IL_001A: newarr 0x0100000B
    IL_001F: stfld 0x04000D75
    IL_0020: ldc.i4.0
    IL_0021: stloc.0
    IL_0026: br IL_0071
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000D74
    IL_002D: ldloc.0
    IL_002E: IL_94
    IL_0033: brfalse IL_006D
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000D74
    IL_003A: ldloc.0
    IL_003B: IL_94
    IL_0040: ldc.i4 10000000
    IL_0041: add
    IL_0042: stloc.1
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000D76
    IL_0049: ldloc.0
    IL_004A: ldloc.1
    IL_004B: ldelem.i8
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000D75
    IL_0052: ldloc.1
    IL_0053: ldc.i4.1
    IL_0054: IL_59
    IL_0055: IL_8F
    IL_0056: stloc.1
    IL_0057: nop
    IL_0058: nop
    IL_0059: IL_01
    IL_005A: dup
    IL_005D: stloc 22551
    IL_005E: IL_54
    IL_005F: ldarg.0
    IL_0060: dup
    IL_0065: ldfld 0x04000DD6
    IL_0066: ldc.i4.1
    IL_0067: IL_58
    IL_006C: stfld 0x04000DD6
    IL_006D: ldloc.0
    IL_006E: ldc.i4.1
    IL_006F: IL_58
    IL_0070: stloc.0
    IL_0071: ldloc.0
    IL_0073: ldc.i4.s 50
    IL_0074: IL_3F
    IL_0075: IL_AE
    IL_0076: IL_FF
    IL_0077: IL_FF
    IL_0078: IL_FF
    IL_0079: ret
    }

    private void FindCardType() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000DD5
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002C
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000D76
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_0016: ldarg.1
    IL_004B: switch (12 cases)
    }

    private void GiftMode() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: IL_DC
    IL_0004: IL_42
    IL_0005: ldarg.0
    IL_000A: ldfld 0x04000DC3
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_0012: ldc.i4 2251074
    IL_0013: nop
    IL_0014: IL_82
    IL_0015: IL_43
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: ldloc.2
    IL_001A: IL_42
    IL_001F: call 0x0600021D
    IL_0020: ldc.i4.4
    IL_0025: newarr 0x01000020
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_002C: ldsfld 0x040007B2
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000D6B
    IL_0037: ldc.i4 421
    IL_003C: call 0x0A0000E1
    IL_0041: stelem 0xF9721725
    IL_0042: IL_3E
    IL_0043: ldarg.0
    IL_0048: cpobj 0x021825A2
    IL_004D: ldfld 0x04000DD6
    IL_0052: newobj 0x0100000B
    IL_0057: stelem 0x01721925
    IL_0058: IL_3F
    IL_0059: ldarg.0
    IL_005E: cpobj 0x009628A2
    IL_005F: nop
    IL_0060: stloc.0
    IL_0065: ldstr 0x70023325
    IL_006A: call 0x0A0000E2
    IL_006F: call 0x0A0000E3
    IL_0070: ldc.i4.0
    IL_0071: stloc.0
    IL_0076: br IL_0229
    IL_0078: ldc.i4.s 90
    IL_0079: ldloc.0
    IL_007B: ldc.i4.s 110
    IL_007C: IL_5A
    IL_007D: IL_58
    IL_007E: conv.i2
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000DC3
    IL_0085: IL_22
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldelem.r8
    IL_0089: IL_42
    IL_008A: IL_22
    IL_008B: nop
    IL_008C: nop
    IL_008D: ldelem.r8
    IL_008E: IL_42
    IL_0093: call 0x0600021D
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000D91
    IL_009A: ldloc.0
    IL_009B: ldelem.i
    IL_00A0: call 0x0A0000E0
    IL_00A2: ldc.i4.s 90
    IL_00A3: ldloc.0
    IL_00A5: ldc.i4.s 110
    IL_00A6: IL_5A
    IL_00A7: IL_58
    IL_00A8: conv.i2
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000DC3
    IL_00AF: IL_22
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: ldelem.r8
    IL_00B3: IL_42
    IL_00B4: IL_22
    IL_00B5: nop
    IL_00B6: nop
    IL_00B7: ldelem.r8
    IL_00B8: IL_42
    IL_00BD: call 0x0600021D
    IL_00C2: ldsfld 0x0A000099
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000D98
    IL_00CD: call 0x0A0000F1
    IL_00D2: brfalse IL_01A5
    IL_00D3: ldarg.0
    IL_00D4: ldarg.0
    IL_00D5: ldloc.0
    IL_00D6: ldc.i4.1
    IL_00D7: IL_58
    IL_00DC: call 0x0600067E
    IL_00E1: stfld 0x04000DD5
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x04000DD5
    IL_00E8: ldc.i4.m1
    IL_00ED: beq IL_01A5
    IL_00EE: ldarg.0
    IL_00F3: call 0x06000680
    IL_00F4: ldc.i4.m1
    IL_00F9: beq IL_016E
    IL_00FA: ldarg.0
    IL_00FF: ldfld 0x04000D9E
    IL_0100: conv.r8
    IL_0101: stloc.3
    IL_0102: nop
    IL_0103: nop
    IL_0104: stloc.0
    IL_0105: conv.r8
    IL_0107: ldarg.s 0
    IL_0108: nop
    IL_0109: stloc.0
    IL_010A: ldarg.0
    IL_010F: ldfld 0x04000D91
    IL_0110: ldloc.0
    IL_0111: ldelem.i
    IL_0112: conv.r8
    IL_0114: ldarga.s 0
    IL_0115: nop
    IL_0116: stloc.0
    IL_0117: ldarg.0
    IL_011C: ldfld 0x04000D9E
    IL_011D: conv.r8
    IL_011E: stloc.0
    IL_011F: nop
    IL_0120: nop
    IL_0121: stloc.0
    IL_0122: ldc.i4.1
    IL_0123: conv.r8
    IL_0124: stloc.1
    IL_0125: nop
    IL_0126: nop
    IL_0127: stloc.0
    IL_0128: ldarg.0
    IL_012D: ldfld 0x04000D9E
    IL_012E: ldloc.0
    IL_012F: ldc.i4.1
    IL_0130: IL_59
    IL_0131: conv.i2
    IL_0132: IL_22
    IL_0133: nop
    IL_0134: nop
    IL_0135: nop
    IL_0136: IL_BF
    IL_0137: IL_5A
    IL_0138: IL_22
    IL_0139: IL_CD
    IL_013A: IL_CC
    IL_013B: IL_4C
    IL_013C: IL_3D
    IL_013D: IL_22
    IL_013E: nop
    IL_013F: nop
    IL_0140: nop
    IL_0141: IL_3F
    IL_0146: newobj 0x0A000076
    IL_0147: conv.r8
    IL_0148: ldloc.3
    IL_0149: nop
    IL_014A: nop
    IL_014B: stloc.0
    IL_014C: ldarg.0
    IL_014D: IL_22
    IL_014E: nop
    IL_014F: nop
    IL_0150: IL_C8
    IL_0151: IL_C2
    IL_0156: stfld 0x04000DC3
    IL_0157: ldarg.0
    IL_0158: ldc.i4.1
    IL_015D: stfld 0x04000DD7
    IL_015E: ldarg.0
    IL_015F: IL_22
    IL_0160: nop
    IL_0161: nop
    IL_0162: nop
    IL_0163: IL_3F
    IL_0168: stfld 0x04000DC4
    IL_016D: br IL_0230
    IL_016E: ldarg.0
    IL_0173: ldfld 0x04000D69
    IL_0175: ldc.i4.s 12
    IL_0176: IL_3F
    IL_0177: ldc.i4.2
    IL_0178: nop
    IL_0179: nop
    IL_017A: nop
    IL_017B: ldarg.0
    IL_017D: ldc.i4.s 9
    IL_0182: stfld 0x04000DB6
    IL_0183: ldarg.0
    IL_0184: IL_22
    IL_0185: nop
    IL_0186: nop
    IL_018B: stsfld 0x067A283F
    IL_018C: nop
    IL_018D: ldloc.0
    IL_0192: br IL_01A5
    IL_0193: ldarg.0
    IL_0194: IL_22
    IL_0195: nop
    IL_0196: nop
    IL_019B: stsfld 0x067A283F
    IL_019C: nop
    IL_019D: ldloc.0
    IL_019E: ldarg.0
    IL_019F: ldc.i4.3
    IL_01A4: stfld 0x04000DB6
    IL_01A6: ldc.i4.s 94
    IL_01A7: ldloc.0
    IL_01A9: ldc.i4.s 110
    IL_01AA: IL_5A
    IL_01AB: IL_58
    IL_01AC: conv.i2
    IL_01AD: ldarg.0
    IL_01B2: ldfld 0x04000DC3
    IL_01B3: IL_22
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: ldelem.r8
    IL_01B7: IL_42
    IL_01B8: IL_58
    IL_01B9: IL_22
    IL_01BA: nop
    IL_01BB: nop
    IL_01C0: ldobj 0x00002242
    IL_01C1: IL_C0
    IL_01C2: IL_41
    IL_01C7: call 0x0600021D
    IL_01CC: ldsfld 0x0A000099
    IL_01D1: ldstr 0x70022A46
    IL_01D6: call 0x0A0000E2
    IL_01DB: call 0x0A0001BA
    IL_01DD: ldc.i4.s 90
    IL_01DE: ldloc.0
    IL_01E0: ldc.i4.s 110
    IL_01E1: IL_5A
    IL_01E2: IL_58
    IL_01E3: conv.i2
    IL_01E4: ldarg.0
    IL_01E9: ldfld 0x04000DC3
    IL_01EA: IL_22
    IL_01EB: nop
    IL_01EC: nop
    IL_01ED: IL_98
    IL_01EE: IL_42
    IL_01EF: IL_58
    IL_01F0: IL_22
    IL_01F1: nop
    IL_01F2: nop
    IL_01F3: ldelem.r8
    IL_01F4: IL_42
    IL_01F5: IL_22
    IL_01F6: nop
    IL_01F7: nop
    IL_01F8: nop
    IL_01F9: IL_42
    IL_01FE: call 0x0600021D
    IL_0203: ldsfld 0x0A000099
    IL_0204: ldarg.0
    IL_0209: ldfld 0x04000D75
    IL_020A: ldloc.0
    IL_020B: IL_94
    IL_0210: newobj 0x0100000B
    IL_0215: call 0x0A00009A
    IL_021A: ldstr 0x70022A5A
    IL_021F: call 0x0A0000E2
    IL_0224: call 0x0A0000E3
    IL_0225: ldloc.0
    IL_0226: ldc.i4.1
    IL_0227: IL_58
    IL_0228: stloc.0
    IL_0229: ldloc.0
    IL_022A: ldc.i4.3
    IL_022B: IL_3F
    IL_022E: starg 65534
    IL_022F: IL_FF
    IL_0230: ret
    }

    private void GetGeneral() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000D68
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002B
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000D6C
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_001A: brtrue IL_0027
    IL_001B: ldarg.0
    IL_001C: ldloc.0
    IL_0021: stfld 0x04000D68
    IL_0026: br IL_0037
    IL_0027: ldloc.0
    IL_0028: ldc.i4.1
    IL_0029: IL_58
    IL_002A: stloc.0
    IL_002B: ldloc.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000D69
    IL_0032: IL_3F
    IL_0033: IL_D7
    IL_0034: IL_FF
    IL_0035: IL_FF
    IL_0036: IL_FF
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000D68
    IL_003D: ret
    }

    private void GeneralMode() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D64
    IL_0006: ldc.i4.0
    IL_0007: IL_3C
    IL_0009: ldloc.s 0
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000D63
    IL_0017: stfld 0x04000D64
    IL_001C: br IL_0047
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000D6C
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000D64
    IL_0029: IL_94
    IL_002E: brtrue IL_0047
    IL_002F: ldarg.0
    IL_0030: ldc.i4.0
    IL_0035: stfld 0x04000DA7
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000D9D
    IL_0040: call 0x0A00001B
    IL_0041: conv.r8
    IL_0042: IL_AF
    IL_0043: nop
    IL_0044: nop
    IL_0045: stloc.0
    IL_0046: ret
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000DA7
    IL_004D: ldc.i4.4
    IL_004E: IL_3C
    IL_0050: blt.s IL_0061
    IL_0051: nop
    IL_0052: nop
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldarg.0
    IL_0057: IL_43
    IL_0058: IL_22
    IL_0059: nop
    IL_005A: nop
    IL_005B: IL_58
    IL_005C: IL_42
    IL_005D: IL_22
    IL_005E: nop
    IL_005F: nop
    IL_0060: sub
    IL_0061: IL_43
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0069: ldobj 0x021D2841
    IL_006A: nop
    IL_006B: ldloc.0
    IL_006C: ldarg.0
    IL_0071: ldfld 0x04000D79
    IL_0076: call 0x0A0000E0
    IL_0077: IL_22
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.2
    IL_007B: IL_43
    IL_007C: IL_22
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_C2
    IL_0080: IL_42
    IL_0081: IL_22
    IL_0082: nop
    IL_0083: nop
    IL_0088: stsfld 0x00002242
    IL_008D: stsfld 0x021D2842
    IL_008E: nop
    IL_008F: ldloc.0
    IL_0090: ldarg.0
    IL_0095: ldfld 0x04000D6A
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000D64
    IL_009C: ldelem.i
    IL_00A1: call 0x0A0000E0
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.2
    IL_00A6: IL_43
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: IL_A4
    IL_00AB: IL_42
    IL_00AC: IL_22
    IL_00AD: nop
    IL_00AE: nop
    IL_00B3: stsfld 0x00002242
    IL_00B4: IL_DC
    IL_00B5: IL_42
    IL_00BA: call 0x0600021D
    IL_00BB: ldarg.0
    IL_00C0: ldfld 0x04000D7A
    IL_00C5: call 0x0A0000E0
    IL_00C6: IL_22
    IL_00C7: nop
    IL_00C8: nop
    IL_00CA: starg.s 67
    IL_00CB: IL_22
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: IL_23
    IL_00CF: IL_43
    IL_00D0: IL_22
    IL_00D1: nop
    IL_00D2: nop
    IL_00D7: newobj 0x00002242
    IL_00DC: stsfld 0x021D2841
    IL_00DD: nop
    IL_00DE: ldloc.0
    IL_00DF: ldc.i4.4
    IL_00E4: newarr 0x01000020
    IL_00E5: dup
    IL_00E6: ldc.i4.0
    IL_00EB: ldsfld 0x0A000099
    IL_00F0: stelem 0x7B021725
    IL_00F1: IL_AE
    IL_00F2: stloc.3
    IL_00F3: nop
    IL_00F4: ldarg.2
    IL_00F9: newobj 0x01000010
    IL_00FE: stelem 0xD9721825
    IL_00FF: IL_37
    IL_0100: ldarg.0
    IL_0105: cpobj 0x021925A2
    IL_010A: ldfld 0x04000DAD
    IL_010B: ldc.i4.1
    IL_010C: IL_58
    IL_010E: ldc.i4.s 20
    IL_010F: IL_5A
    IL_0114: newobj 0x0100000B
    IL_0119: stelem 0x00009628
    IL_011A: stloc.0
    IL_011F: ldstr 0x70000BC5
    IL_0124: call 0x0A0000E2
    IL_0129: call 0x0A0000E3
    IL_012A: IL_22
    IL_012B: nop
    IL_012C: nop
    IL_012E: ldarga.s 67
    IL_012F: IL_22
    IL_0130: nop
    IL_0131: nop
    IL_0136: br IL_-4684FC86
    IL_0137: stloc.3
    IL_0138: nop
    IL_0139: ldarg.2
    IL_013A: IL_22
    IL_013B: nop
    IL_013C: nop
    IL_013D: ldelem.r8
    IL_875E2: switch (138536 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DA5
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000DA5
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000DA5
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000D9D
    IL_004B: call 0x0A00001B
    IL_004C: conv.r8
    IL_004D: IL_AF
    IL_004E: nop
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: ret
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D62
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000DBD
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004E: cpobj 0x00002243
    IL_004F: IL_F0
    IL_0050: IL_43
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0054: IL_C8
    IL_0055: IL_42
    IL_005A: call 0x0600021D
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000D84
    IL_0065: call 0x0A0000E0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000DB6
    IL_006C: ldc.i4.0
    IL_006D: IL_3E
    IL_006E: ldloc.0
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldc.i4.0
    IL_0077: call 0x0A0001B9
    IL_0078: IL_22
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_E0
    IL_007C: IL_42
    IL_007D: IL_22
    IL_007E: nop
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0089: stsfld 0x00002243
    IL_008A: nop
    IL_008B: IL_42
    IL_0090: call 0x0600021D
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000D93
    IL_009B: call 0x0A0000E0
    IL_009C: IL_22
    IL_009D: nop
    IL_009E: nop
    IL_00A0: ldloca.s 67
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: IL_C0
    IL_280000131: switch (2684354594 cases)
    }

    }}
