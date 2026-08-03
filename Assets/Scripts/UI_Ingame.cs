// Namespace: 
// Type: UI_Ingame

    public class UI_Ingame {{

    private object chamaxhp;
    private object chahp;
    private object chasp;
    private object chamaxsp;
    private object chaexp;
    private object chalv;
    private object atk;
    private object def;
    private object hit;
    private object spr;
    private object chargeon;
    private object infinitymode;
    private object returnmap;
    private object soul;
    private object f_soul;
    private object jade;
    private object coin;
    private object extreme_point;
    private object dropcoin;
    private object dropjade;
    private object total_star;
    private object soulgain;
    public object pack;
    public object pt_levelup;
    public object num_level;
    public object bg_popui;
    public object cut_extreme;
    public object card;
    public object ui_ingame_gui;
    public object txt_maxcombo;
    private object txt_result;
    private object txt_star;
    private object g_mp;
    private object g_hp;
    private object g_power;
    private object stage_num;
    private object point_num;
    private object extreme_num;
    private object getcoin_num;
    private object giftbox;
    private object cha1;
    private object g_combo;
    private object chaprevlv;
    private object damagecount;
    private object finishdelay;
    private object hp_length;
    private object sp_length;
    private object mp_length;
    private object exp_height;
    private object combo_length;
    private object playtime;
    private object general;
    private object generaldead;
    private object gauge_scalechange;
    private object cur_general;
    public object cur_difficulty;
    public object angelOn;
    private object cur_angel;
    private object play_kind;
    private object f_charge;
    private object loadingfinish;
    private object supermode;
    private object wave;
    private object enemykill;
    private object grappling;
    private object finalstage;
    private object exattack;
    private object max_stage_index;
    private object cur_stage_index;
    private object tutorial;
    private object getcoin;
    private object killcount;
    private object rewardkind;
    private object totalkillcount;
    private object tutorial_maxcombo;
    private object stage_progress;
    private object script_cha;
    private object script_pack;
    private object script_spawn;
    private object script_OnGUI;
    private object script_icon;
    private object gauge_hp;
    private object gauge_sp;
    private object gauge_mp;
    private object gauge_exp;
    private object gauge_power;
    private object gauge_stage;
    private object gauge_combo;
    private object stageRegen;
    private object extreme_point_cur;

    public UI_Ingame() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: stfld 0x04000B56
    IL_0008: ldarg.0
    IL_000A: ldc.i4.s 100
    IL_000F: stfld 0x04000B57
    IL_0010: ldarg.0
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_C8
    IL_0015: IL_42
    IL_001A: stfld 0x04000B58
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_C8
    IL_0020: IL_42
    IL_0025: stfld 0x04000B59
    IL_0026: ldarg.0
    IL_0027: ldc.i4.1
    IL_002C: stfld 0x04000B5B
    IL_002D: ldarg.0
    IL_002E: ldc.i4.1
    IL_0033: stfld 0x04000B63
    IL_0034: ldarg.0
    IL_0035: ldc.i4.2
    IL_003A: newarr 0x01000003
    IL_003F: stfld 0x04000B70
    IL_0040: ldarg.0
    IL_0041: ldc.i4.3
    IL_0046: newarr 0x0100003C
    IL_004B: stfld 0x04000B71
    IL_004C: ldarg.0
    IL_004D: ldc.i4.m1
    IL_0052: stfld 0x04000B8C
    IL_0053: ldarg.0
    IL_0054: ldc.i4.m1
    IL_0059: stfld 0x04000B9B
    IL_005A: ldarg.0
    IL_005B: ldc.i4.1
    IL_0060: stfld 0x04000BAE
    IL_0061: ldarg.0
    IL_0066: call 0x0A000001
    IL_0067: ret
    }

    private void OnApplicationPause() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0007
    IL_0006: ret
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BA5
    IL_000D: ldnull
    IL_0012: call 0x0A000021
    IL_0017: brfalse IL_0033
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000B72
    IL_001E: conv.r8
    IL_001F: stloc.0
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: conv.r8
    IL_0024: IL_CA
    IL_0025: IL_01
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: brtrue IL_0033
    IL_002D: ldarg.0
    IL_0032: call 0x06000626
    IL_0033: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700004DD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000B99
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000DDD
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000B5B
    IL_0020: ldarg.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000B5B
    IL_002B: stfld 0x04000B80
    IL_002C: ldarg.0
    IL_0031: ldstr 0x70000DE5
    IL_0036: call 0x06000220
    IL_0037: conv.i2
    IL_003C: stfld 0x04000B5A
    IL_003D: ldarg.0
    IL_0042: ldstr 0x70023585
    IL_0047: call 0x0A000095
    IL_004C: stfld 0x04000BA0
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000B72
    IL_0054: conv.r8
    IL_0059: stsfld 0x7D2B0000
    IL_005E: castclass 0x0204000B
    IL_0063: ldstr 0x70000001
    IL_0068: call 0x0A000004
    IL_0069: conv.r8
    IL_006A: ldarg.3
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_0072: stfld 0x04000B7E
    IL_0073: ldarg.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x04000B7E
    IL_007A: conv.r8
    IL_007B: stloc.2
    IL_007C: nop
    IL_007D: nop
    IL_007F: br.s IL_00FD
    IL_0084: stelem 0x0204000B
    IL_0089: ldstr 0x70000311
    IL_008E: call 0x0A000004
    IL_008F: conv.r8
    IL_0094: ldc.i4 2099970048
    IL_0099: isinst 0x0204000B
    IL_009E: ldstr 0x70000063
    IL_00A3: call 0x0A000004
    IL_00A4: conv.r8
    IL_00A5: ldarg.0
    IL_00A6: nop
    IL_00A7: nop
    IL_00A9: br.s IL_0127
    IL_00AA: IL_A4
    IL_00AB: stloc.1
    IL_00AC: nop
    IL_00AD: ldarg.2
    IL_00AE: ldarg.0
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000B6C
    IL_00B5: conv.r8
    IL_00B6: IL_37
    IL_00B7: nop
    IL_00B8: nop
    IL_00BA: br.s IL_0138
    IL_00BB: stelem.i
    IL_00BC: stloc.1
    IL_00BD: nop
    IL_00BE: ldarg.2
    IL_00BF: ldarg.0
    IL_00C0: ldarg.0
    IL_00C5: ldfld 0x04000BA4
    IL_00CA: ldfld 0x0400095D
    IL_00CF: stfld 0x04000B61
    IL_00D0: ldarg.0
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x04000BA4
    IL_00DB: ldfld 0x0400093E
    IL_00E0: stfld 0x04000B97
    IL_00E1: ldarg.0
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x04000B5B
    IL_00E8: conv.i2
    IL_00E9: IL_22
    IL_00EE: isinst 0x5A3B449B
    IL_00EF: IL_22
    IL_00F0: IL_CD
    IL_00F1: IL_CC
    IL_00F2: IL_4C
    IL_00F3: IL_3D
    IL_00F4: IL_58
    IL_00F9: stfld 0x04000B6B
    IL_00FA: ldarg.0
    IL_00FF: ldstr 0x70000BDB
    IL_0104: call 0x06000220
    IL_0109: stfld 0x04000B90
    IL_010A: ldarg.0
    IL_010F: ldstr 0x70001ED5
    IL_0114: call 0x06000220
    IL_0119: stfld 0x04000B8D
    IL_011E: ldstr 0x70001655
    IL_0123: call 0x0A000012
    IL_0124: conv.u8
    IL_0125: ldloc.0
    IL_0126: nop
    IL_0127: nop
    IL_0128: IL_01
    IL_0129: stloc.0
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000B61
    IL_0134: brfalse IL_0408
    IL_0135: ldarg.0
    IL_013A: ldstr 0x70022DD9
    IL_013F: call 0x06000220
    IL_0144: stfld 0x04000B94
    IL_0145: ldloc.0
    IL_0146: conv.r8
    IL_0147: ldarg.3
    IL_0148: nop
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: ldloc.0
    IL_014C: conv.r8
    IL_014D: ldarg.3
    IL_014E: nop
    IL_014F: nop
    IL_0150: stloc.0
    IL_0151: conv.r8
    IL_0152: add
    IL_0153: nop
    IL_0154: nop
    IL_0155: stloc.0
    IL_0156: IL_22
    IL_0157: IL_8F
    IL_0158: IL_C2
    IL_0159: IL_F5
    IL_015A: IL_3C
    IL_015B: IL_22
    IL_015C: stloc.0
    IL_015D: IL_D7
    IL_015E: stelem.i
    IL_015F: IL_BC
    IL_0160: IL_22
    IL_0161: nop
    IL_0162: nop
    IL_0163: nop
    IL_0164: nop
    IL_0169: newobj 0x0A000076
    IL_016E: call 0x0A000029
    IL_0173: call 0x0A000013
    IL_0178: call 0x0A000014
    IL_0179: conv.u4
    IL_017A: ldarg.1
    IL_017B: nop
    IL_017C: nop
    IL_017D: IL_01
    IL_017E: stloc.1
    IL_017F: ldarg.0
    IL_0180: ldloc.1
    IL_0181: conv.r8
    IL_0182: IL_24
    IL_0183: nop
    IL_0184: nop
    IL_0186: br.s IL_0204
    IL_018B: ldfld 0x0204000B
    IL_0190: ldfld 0x04000B7B
    IL_0191: IL_22
    IL_0192: IL_8F
    IL_0193: IL_C2
    IL_0194: IL_F5
    IL_0195: IL_3C
    IL_0196: conv.r8
    IL_0197: IL_B2
    IL_0198: IL_01
    IL_0199: nop
    IL_019A: stloc.0
    IL_019B: ldarg.0
    IL_01A0: ldfld 0x04000B7B
    IL_01A1: ldarg.0
    IL_01A6: ldflda 0x04000B94
    IL_01AB: call 0x0A000010
    IL_01AC: conv.r8
    IL_01AD: IL_FD
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: stloc.0
    IL_01B5: ldstr 0x70023599
    IL_01BA: call 0x0A000012
    IL_01BB: conv.u8
    IL_01BC: ldloc.0
    IL_01BD: nop
    IL_01BE: nop
    IL_01BF: IL_01
    IL_01C0: stloc.2
    IL_01C1: ldarg.0
    IL_01C2: ldloc.2
    IL_01C3: conv.r8
    IL_01C4: ldarg.3
    IL_01C5: nop
    IL_01C6: nop
    IL_01C7: stloc.0
    IL_01C8: ldloc.2
    IL_01C9: conv.r8
    IL_01CA: ldarg.3
    IL_01CB: nop
    IL_01CC: nop
    IL_01CD: stloc.0
    IL_01CE: conv.r8
    IL_01CF: add
    IL_01D0: nop
    IL_01D1: nop
    IL_01D2: stloc.0
    IL_01D7: call 0x0A000013
    IL_01DC: call 0x0A000014
    IL_01DD: conv.u4
    IL_01DE: ldarg.1
    IL_01DF: nop
    IL_01E0: nop
    IL_01E1: IL_01
    IL_01E6: stfld 0x04000B7C
    IL_01E7: ldarg.0
    IL_01E8: ldc.i4.0
    IL_01ED: stfld 0x04000B8D
    IL_01EE: ldarg.0
    IL_01F3: ldfld 0x04000BA3
    IL_01F4: IL_22
    IL_01F5: IL_EC
    IL_01F6: IL_51
    IL_01FB: br IL_-28F5DBC5
    IL_01FC: IL_23
    IL_01FD: IL_3E
    IL_0202: newobj 0x0A000038
    IL_0203: IL_22
    IL_0204: nop
    IL_0205: nop
    IL_0206: nop
    IL_0207: nop
    IL_0208: IL_22
    IL_0209: shr
    IL_020A: shr
    IL_020B: shr
    IL_020C: IL_3F
    IL_020D: IL_22
    IL_020E: stloc.0
    IL_020F: IL_D7
    IL_0211: bne.un.s IL_0252
    IL_0212: IL_22
    IL_0213: shr
    IL_0214: shr
    IL_0215: ldloc.0
    IL_1DBE6: switch (30323 cases)
    }

    public void SkillPlus() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BA6
    IL_0006: ldarg.1
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B89
    IL_000D: conv.r8
    IL_0012: beq IL_26060016
    IL_0013: ret
    }

    public void ResetTime() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B7B
    IL_0006: ldarg.0
    IL_000B: ldflda 0x04000B94
    IL_0010: call 0x0A000010
    IL_0011: conv.r8
    IL_0012: IL_FD
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: stfld 0x04000B88
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0027: stfld 0x04000B81
    IL_0028: ldarg.0
    IL_002D: ldstr 0x700235C7
    IL_002E: IL_22
    IL_002F: IL_CD
    IL_0030: IL_CC
    IL_0031: IL_CC
    IL_0032: IL_3D
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_003A: stsfld 0x0017283F
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: ldarg.0
    IL_003E: ldc.i4.1
    IL_0043: stfld 0x04000BAE
    IL_0044: ret
    }

    private void CountDown() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B88
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000D: cpobj 0x0A695B42
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000B88
    IL_0014: not
    IL_0016: ldc.i4.s 60
    IL_0017: mul
    IL_0018: stloc.1
    IL_001D: ldstr 0x7002369F
    IL_001E: stloc.2
    IL_001F: ldloc.1
    IL_0021: ldc.i4.s 10
    IL_0022: IL_3C
    IL_0023: ldloc.0
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_002B: ldstr 0x700236A7
    IL_002C: stloc.2
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000B79
    IL_0033: ldloc.0
    IL_0038: newobj 0x0100000B
    IL_0039: ldloc.2
    IL_003A: ldloc.1
    IL_003F: newobj 0x0100000B
    IL_0044: call 0x0A000098
    IL_0045: conv.r8
    IL_0046: IL_FD
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ret
    }

    public void SoulStartplus() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.5
    IL_0006: stfld 0x04000B63
    IL_0007: ret
    }

    public void CallGeneral() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B8C
    IL_0006: ldc.i4.0
    IL_0007: IL_3C
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldc.i4.0
    IL_000D: ret
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000BA2
    IL_0018: ldfld 0x04000352
    IL_001D: brfalse IL_0029
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000B8A
    IL_0028: brfalse IL_002B
    IL_0029: ldc.i4.0
    IL_002A: ret
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000B58
    IL_0031: IL_22
    IL_0032: nop
    IL_0033: nop
    IL_0038: ldc.i4 11748417
    IL_0039: nop
    IL_003A: nop
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000B89
    IL_0045: brtrue IL_0076
    IL_0046: ldarg.0
    IL_0047: ldc.i4.1
    IL_004C: stfld 0x04000B89
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000BA6
    IL_0053: ldc.i4.1
    IL_0054: conv.r8
    IL_0055: IL_42
    IL_0056: ldarg.1
    IL_0057: nop
    IL_0058: ldloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000BA6
    IL_005F: ldc.i4.1
    IL_0060: conv.r8
    IL_0061: IL_43
    IL_0062: ldarg.1
    IL_0063: nop
    IL_0064: ldloc.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000BA6
    IL_006B: ldc.i4.1
    IL_006C: conv.r8
    IL_006F: ldarg 3
    IL_0070: ldloc.0
    IL_0075: br IL_00A1
    IL_0076: ldarg.0
    IL_0077: ldc.i4.0
    IL_007C: stfld 0x04000B89
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000BA6
    IL_0083: ldc.i4.0
    IL_0084: conv.r8
    IL_0085: IL_42
    IL_0086: ldarg.1
    IL_0087: nop
    IL_0088: ldloc.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000BA6
    IL_008F: ldc.i4.0
    IL_0090: conv.r8
    IL_0091: IL_43
    IL_0092: ldarg.1
    IL_0093: nop
    IL_0094: ldloc.0
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000BA6
    IL_009B: ldc.i4.0
    IL_009C: conv.r8
    IL_009F: ldarg 3
    IL_00A0: ldloc.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000B77
    IL_00AB: call 0x0A00004B
    IL_00B0: call 0x0A000043
    IL_00B1: conv.r8
    IL_00B2: IL_AF
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00B7: ldc.i4.1
    IL_00BC: stfld 0x04000B8B
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x04000BA4
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000B89
    IL_00C9: ldarg.0
    IL_00CE: ldfld 0x04000B57
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x04000B56
    IL_00D5: conv.r8
    IL_00D6: IL_F7
    IL_00D7: ldarg.2
    IL_00D8: nop
    IL_00D9: ldloc.0
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000BA2
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000B89
    IL_00E6: ldarg.1
    IL_00E7: conv.r8
    IL_00EC: ldobj 0x17060001
    IL_00ED: ret
    IL_00EE: ldc.i4.0
    IL_00EF: ret
    }

    public void GeneralDead() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000B89
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x04000B8A
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000BA6
    IL_0014: ldc.i4.0
    IL_0015: conv.r8
    IL_0016: IL_42
    IL_0017: ldarg.1
    IL_0018: nop
    IL_0019: ldloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000BA6
    IL_0020: ldc.i4.0
    IL_0021: conv.r8
    IL_0022: IL_43
    IL_0023: ldarg.1
    IL_0024: nop
    IL_0025: ldloc.0
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000BA6
    IL_002C: ldc.i4.0
    IL_002D: conv.r8
    IL_0030: ldarg 3
    IL_0031: ldloc.0
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000BA6
    IL_0038: conv.r8
    IL_0039: IL_44
    IL_003A: ldarg.1
    IL_003B: nop
    IL_003C: ldloc.0
    IL_003D: ret
    }

    public void WaveSet() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000BA4
    IL_000B: ldfld 0x0400094F
    IL_0010: stfld 0x04000B95
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BA4
    IL_001C: ldfld 0x04000950
    IL_0021: stfld 0x04000B96
    IL_0022: ldarg.0
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000BA2
    IL_002D: ldfld 0x04000354
    IL_0032: stfld 0x04000B98
    IL_0037: ldstr 0x70002031
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000B95
    IL_0042: call 0x0600021F
    IL_0047: ldstr 0x70002045
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000B96
    IL_0052: call 0x0600021F
    IL_0057: ldstr 0x70000EC9
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000B98
    IL_0062: call 0x0600021F
    IL_0067: ldstr 0x70023257
    IL_0068: ldarg.0
    IL_006D: ldfld 0x04000B69
    IL_0072: call 0x0600021F
    IL_0077: ldstr 0x7002325F
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000B68
    IL_0082: call 0x0600021F
    IL_0087: ldstr 0x70000DDD
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04000B5B
    IL_0092: call 0x0600021F
    IL_0097: ldstr 0x7000052B
    IL_0098: ldc.i4.1
    IL_009D: call 0x0A00009F
    IL_00A2: ldstr 0x70000DE5
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04000B5A
    IL_00A9: not
    IL_00AE: call 0x0600021F
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000BA6
    IL_00B5: conv.r8
    IL_00B6: IL_41
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: ldloc.0
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000BA4
    IL_00C0: ldc.i4.0
    IL_00C1: conv.r8
    IL_00C2: ldarg.2
    IL_00C3: ldarg.3
    IL_00C4: nop
    IL_00C5: ldloc.0
    IL_00C6: ldarg.1
    IL_00C7: ldc.i4.m1
    IL_0310: switch (145 cases)
    IL_0311: ldarg.3
    IL_0316: call 0x060003F8
    IL_0317: pop
    IL_0318: ldarg.0
    IL_0319: ldc.i4.0
    IL_031E: stfld 0x04000BA1
    IL_031F: ldarg.0
    IL_0320: ldc.i4.0
    IL_0325: stfld 0x04000B9D
    IL_0326: ldarg.0
    IL_0327: ldarg.1
    IL_0328: ldc.i4.1
    IL_0329: IL_58
    IL_032E: stfld 0x04000B94
    IL_0333: ldstr 0x70023247
    IL_0338: call 0x06000220
    IL_033A: stloc.s 6
    IL_033B: ldarg.0
    IL_0340: ldfld 0x04000B94
    IL_0342: ldloc.s 6
    IL_0343: IL_3E
    IL_0344: IL_4E
    IL_0345: nop
    IL_0346: nop
    IL_0347: nop
    IL_0348: ldarg.0
    IL_034D: ldfld 0x04000B94
    IL_034E: ldc.i4.1
    IL_034F: IL_59
    IL_0350: ldc.i4.8
    IL_0351: mul
    IL_0356: brtrue IL_037F
    IL_0357: ldarg.0
    IL_035C: ldfld 0x04000B94
    IL_035D: ldc.i4.1
    IL_0362: beq IL_037A
    IL_0363: ldarg.0
    IL_0364: ldc.i4.1
    IL_0369: stfld 0x04000B8E
    IL_036A: ldarg.0
    IL_036B: ldarg.0
    IL_0370: ldfld 0x04000B94
    IL_0371: ldc.i4.1
    IL_0372: IL_59
    IL_0373: ldc.i4.8
    IL_0374: add
    IL_0379: stfld 0x04000B8F
    IL_037E: br IL_0386
    IL_037F: ldarg.0
    IL_0380: ldc.i4.0
    IL_0385: stfld 0x04000B8E
    IL_038A: ldstr 0x70023247
    IL_038B: ldarg.0
    IL_0390: ldfld 0x04000B94
    IL_0395: call 0x0600021F
    IL_0396: ldarg.0
    IL_0397: ldc.i4.0
    IL_039C: call 0x06000619
    IL_039D: ldarg.0
    IL_03A2: ldstr 0x700235C7
    IL_03A7: call 0x0A00007B
    IL_03A8: ldarg.0
    IL_03A9: ldc.i4.0
    IL_03AE: stfld 0x04000BAE
    IL_03AF: ldarg.0
    IL_03B0: ldarg.0
    IL_03B5: call 0x0600061C
    IL_03BA: call 0x0A000047
    IL_03BB: pop
    IL_03BC: ret
    }

    public void GetAngel() {
    IL_0004: ldstr 0x700236C9
    IL_0005: ldarg.0
    IL_000A: ldflda 0x04000B8F
    IL_000F: call 0x0A000010
    IL_0014: call 0x0A000011
    IL_0019: call 0x0A000012
    IL_001A: conv.u8
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_01
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000B6F
    IL_0026: conv.r8
    IL_0027: stloc.3
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: conv.r8
    IL_002D: ldarg.s 0
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldloc.0
    IL_0031: conv.r8
    IL_0033: ldarga.s 0
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000B6F
    IL_003C: conv.r8
    IL_003D: stloc.0
    IL_003E: nop
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: ldc.i4.1
    IL_0042: conv.r8
    IL_0043: stloc.1
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000B6F
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldelem.r8
    IL_3000000E2: switch (3221225506 cases)
    }

    private void GetAngel_GUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B72
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000BA5
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000B8F
    IL_001D: conv.r8
    IL_001F: blt.s IL_0026
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ret
    }

    public void ComboPlus() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B93
    IL_000A: brtrue IL_00E4
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000B87
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_3F
    IL_0016: IL_41
    IL_0017: IL_C9
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x04000B87
    IL_0022: ldarg.1
    IL_0023: IL_58
    IL_0028: stfld 0x04000B87
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000BAD
    IL_0033: call 0x0A000082
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000B87
    IL_003A: shl
    IL_003F: call 0x0A000083
    IL_0040: conv.r8
    IL_0041: IL_F3
    IL_0042: ldarg.0
    IL_0043: nop
    IL_0044: ldloc.0
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000B87
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_3F
    IL_0050: IL_44
    IL_0051: IL_8F
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldarg.0
    IL_0056: ldc.i4.1
    IL_005B: stfld 0x04000B93
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000B73
    IL_0062: conv.r8
    IL_0063: stloc.0
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldc.i4.1
    IL_0068: conv.r8
    IL_0069: stloc.1
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000B73
    IL_0073: ldc.i4.0
    IL_0074: conv.r8
    IL_0079: brtrue IL_6F0A007A
    IL_007A: stloc.0
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: ldc.i4.1
    IL_007F: conv.r8
    IL_0080: stloc.1
    IL_0081: nop
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000B7F
    IL_008E: call 0x0A000007
    IL_008F: IL_22
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldelem.r8
    IL_2137: switch (2088 cases)
    }

    public void SuperModeOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B70
    IL_0006: ldc.i4.0
    IL_0007: ldelem.i
    IL_0008: conv.r8
    IL_0009: stloc.0
    IL_000A: nop
    IL_000B: nop
    IL_000C: stloc.0
    IL_000D: ldc.i4.1
    IL_000E: conv.r8
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000B70
    IL_0019: ldc.i4.1
    IL_001A: ldelem.i
    IL_001B: conv.r8
    IL_001C: stloc.0
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ldc.i4.1
    IL_0021: conv.r8
    IL_0022: stloc.1
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_0027: ldc.i4.0
    IL_002C: stfld 0x04000B93
    IL_002D: ldarg.0
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0037: stfld 0x04000B87
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000BAD
    IL_0042: call 0x0A000082
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000B87
    IL_0049: shl
    IL_004E: call 0x0A000083
    IL_004F: conv.r8
    IL_0050: IL_F3
    IL_0051: ldarg.0
    IL_0052: nop
    IL_0053: ldloc.0
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000B73
    IL_005A: conv.r8
    IL_005B: stloc.0
    IL_005C: nop
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: ldc.i4.0
    IL_0060: conv.r8
    IL_0061: stloc.1
    IL_0062: nop
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000B73
    IL_006B: ldc.i4.0
    IL_006C: conv.r8
    IL_0071: brtrue IL_6F0A0072
    IL_0072: stloc.0
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: ldc.i4.1
    IL_0077: conv.r8
    IL_0078: stloc.1
    IL_0079: nop
    IL_007A: nop
    IL_007B: stloc.0
    IL_007C: ret
    }

    public void GetCoin() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B9C
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B94
    IL_000D: ldc.i4.4
    IL_000E: IL_5A
    IL_0010: ldc.i4.s 80
    IL_0011: IL_58
    IL_0012: conv.i2
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000B6A
    IL_0019: conv.i2
    IL_001A: IL_22
    IL_001B: IL_CD
    IL_001C: IL_CC
    IL_001D: IL_CC
    IL_001E: IL_3D
    IL_001F: IL_5A
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0x695A583F
    IL_0028: IL_58
    IL_002D: stfld 0x04000B9C
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000B9C
    IL_0034: ldc.i4.0
    IL_0039: call 0x0600021E
    IL_003A: pop
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000B7C
    IL_0041: conv.r8
    IL_0042: IL_81
    IL_0043: nop
    IL_0044: nop
    IL_0046: br.s IL_0049
    IL_004B: ldfld 0x04000B9C
    IL_004C: conv.r8
    IL_004D: div.un
    IL_004E: IL_01
    IL_004F: nop
    IL_0050: ldloc.0
    IL_0051: ret
    }

    public void GetGeneral() {
    IL_0004: ldstr 0x700236FF
    IL_0009: call 0x060003F9
    IL_000A: stloc.0
    IL_000B: ldc.i4.m1
    IL_000C: stloc.1
    IL_000D: ldc.i4.0
    IL_0012: ldc.i4 720
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000B94
    IL_001A: ldc.i4.s 12
    IL_001B: IL_5A
    IL_001C: IL_58
    IL_0021: call 0x0A000045
    IL_0022: stloc.2
    IL_0023: ldloc.2
    IL_0028: ldc.i4 990
    IL_0029: IL_3E
    IL_002A: ldloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: ldc.i4.4
    IL_002F: stloc.2
    IL_0034: br IL_006D
    IL_0035: ldloc.2
    IL_003A: ldc.i4 970
    IL_003B: IL_3E
    IL_003C: ldloc.1
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: ldc.i4.3
    IL_0041: stloc.2
    IL_0046: br IL_006D
    IL_0047: ldloc.2
    IL_004C: ldc.i4 800
    IL_004D: IL_3E
    IL_004E: ldloc.1
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: ldc.i4.2
    IL_0053: stloc.2
    IL_0058: br IL_006D
    IL_0059: ldloc.2
    IL_005E: ldc.i4 500
    IL_005F: IL_3E
    IL_0060: ldloc.1
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldc.i4.1
    IL_0065: stloc.2
    IL_006A: br IL_006D
    IL_006B: ldc.i4.0
    IL_006C: stloc.2
    IL_006D: ldc.i4.0
    IL_006E: stloc.3
    IL_006F: ldloc.2
    IL_0074: ldc.i4 850
    IL_0075: IL_3E
    IL_0076: ldloc.1
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldc.i4.3
    IL_007B: stloc.3
    IL_0080: br IL_0095
    IL_0081: ldloc.2
    IL_0086: ldc.i4 600
    IL_0087: IL_3E
    IL_0088: ldloc.1
    IL_0089: nop
    IL_008A: nop
    IL_008B: nop
    IL_008C: ldc.i4.2
    IL_008D: stloc.3
    IL_0092: br IL_0095
    IL_0093: ldc.i4.1
    IL_0094: stloc.3
    IL_0095: ldc.i4.0
    IL_0097: ldc.i4.s 90
    IL_009C: call 0x0A000045
    IL_009E: stloc.s 4
    IL_009F: ldloc.2
    IL_00A0: ldc.i4.2
    IL_00A1: IL_3F
    IL_00A2: stloc.2
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_00A7: ldloc.s 4
    IL_00A9: ldc.i4.s 20
    IL_00AA: mul
    IL_00AC: stloc.s 4
    IL_00B1: br IL_00B9
    IL_00B3: ldloc.s 4
    IL_00B5: ldc.i4.s 30
    IL_00B6: mul
    IL_00B8: stloc.s 4
    IL_00BA: ldloc.s 4
    IL_00BF: ldc.i4 100000
    IL_00C0: IL_5A
    IL_00C2: stloc.s 4
    IL_00C3: ldc.i4.0
    IL_00C8: ldc.i4 10000
    IL_00CD: call 0x0A000045
    IL_00CE: ldloc.2
    IL_00D3: ldc.i4 10000
    IL_00D4: IL_5A
    IL_00D5: IL_58
    IL_00D6: ldloc.3
    IL_00DB: ldc.i4 10000000
    IL_00DC: IL_5A
    IL_00DD: IL_58
    IL_00DF: ldloc.s 4
    IL_00E0: IL_58
    IL_00E2: stloc.s 5
    IL_00E3: ldc.i4.0
    IL_00E5: stloc.s 6
    IL_00EA: br IL_0114
    IL_00EB: ldloc.0
    IL_00ED: ldloc.s 6
    IL_00EE: IL_94
    IL_00F3: brtrue IL_010E
    IL_00F5: ldloc.s 6
    IL_00F6: stloc.1
    IL_00F7: ldloc.0
    IL_00F9: ldloc.s 6
    IL_00FB: ldloc.s 5
    IL_00FC: ldelem.i8
    IL_0101: ldstr 0x700236FF
    IL_0102: ldloc.0
    IL_0107: call 0x060003F8
    IL_0108: pop
    IL_010D: br IL_011D
    IL_010F: ldloc.s 6
    IL_0110: ldc.i4.1
    IL_0111: IL_58
    IL_0113: stloc.s 6
    IL_0115: ldloc.s 6
    IL_0117: ldc.i4.s 50
    IL_0118: IL_3F
    IL_0119: IL_CE
    IL_011A: IL_FF
    IL_011B: IL_FF
    IL_011C: IL_FF
    IL_011D: ldarg.0
    IL_0122: ldfld 0x04000B6F
    IL_0123: conv.r8
    IL_0124: stloc.3
    IL_0125: nop
    IL_0126: nop
    IL_0127: stloc.0
    IL_0128: conv.r8
    IL_012A: ldarg.s 0
    IL_012B: nop
    IL_012C: stloc.0
    IL_012D: ldarg.0
    IL_0132: ldfld 0x04000B71
    IL_0133: ldloc.3
    IL_0134: ldc.i4.1
    IL_0135: IL_59
    IL_0136: ldelem.i
    IL_0137: conv.r8
    IL_0139: ldarga.s 0
    IL_013A: nop
    IL_013B: stloc.0
    IL_013C: ldarg.0
    IL_0141: ldfld 0x04000B6F
    IL_0142: conv.r8
    IL_0143: stloc.0
    IL_0144: nop
    IL_0145: nop
    IL_0146: stloc.0
    IL_0147: ldc.i4.1
    IL_0148: conv.r8
    IL_0149: stloc.1
    IL_014A: nop
    IL_014B: nop
    IL_014C: stloc.0
    IL_014D: ldarg.0
    IL_0152: ldfld 0x04000B6F
    IL_0153: IL_22
    IL_0154: nop
    IL_0155: nop
    IL_0156: nop
    IL_0157: nop
    IL_0158: IL_22
    IL_0159: nop
    IL_015A: nop
    IL_015B: ldelem.r8
    IL_3000001E8: switch (3221225506 cases)
    }

    public void IntermissionOff() {
    IL_0004: call 0x0A000303
    IL_0005: ldarg.0
    IL_000A: ldfld 0x04000BA4
    IL_000B: conv.r8
    IL_000C: IL_F5
    IL_000D: ldarg.2
    IL_000E: nop
    IL_000F: ldloc.0
    IL_0010: ret
    }

    public void ResetExtreme() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B7D
    IL_0006: conv.r8
    IL_0007: ldarg.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A000007
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0x00082842
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: conv.r8
    IL_001B: ldloc.3
    IL_001C: nop
    IL_001D: nop
    IL_001E: stloc.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000B7D
    IL_0025: conv.r8
    IL_0026: stloc.0
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldc.i4.0
    IL_002B: conv.r8
    IL_002C: stloc.1
    IL_002D: nop
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000BAC
    IL_003A: call 0x0A000057
    IL_003B: conv.r8
    IL_003C: IL_F3
    IL_003D: ldarg.0
    IL_003E: nop
    IL_003F: ldloc.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000BA6
    IL_0046: conv.r8
    IL_0047: IL_35
    IL_0048: ldarg.1
    IL_0049: nop
    IL_004A: ldloc.0
    IL_004B: ret
    }

    public void ShowTxt() {
    IL_0004: call 0x0A0000AA
    IL_0005: IL_22
    IL_0006: nop
    IL_0007: nop
    IL_0008: nop
    IL_0009: IL_3F
    IL_000E: call 0x0A000083
    IL_0013: call 0x0A0000AA
    IL_0014: ldarg.1
    IL_0015: conv.i2
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_001D: stsfld 0x83285A3E
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: call 0x0A0000AB
    IL_0026: stloc.0
    IL_0027: ldarg.1
    IL_002C: brtrue IL_00EA
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000B75
    IL_0033: conv.r8
    IL_0034: stloc.0
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ldc.i4.1
    IL_0039: conv.r8
    IL_003A: stloc.1
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000B75
    IL_0044: conv.r8
    IL_0045: IL_82
    IL_0046: nop
    IL_0047: nop
    IL_0049: br.s IL_004C
    IL_004E: ldfld 0x04000B6A
    IL_004F: conv.r8
    IL_0050: IL_D9
    IL_0051: ldarg.3
    IL_0052: nop
    IL_0053: ldloc.0
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000B94
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000B6A
    IL_0060: IL_5A
    IL_0062: ldc.i4.s 15
    IL_0063: IL_5A
    IL_0064: stloc.1
    IL_0065: ldarg.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000B67
    IL_006C: conv.i2
    IL_0071: stfld 0x04000BAF
    IL_0072: ldarg.0
    IL_0073: dup
    IL_0078: ldfld 0x04000B67
    IL_0079: ldloc.1
    IL_007A: IL_58
    IL_007F: stfld 0x04000B67
    IL_0080: ldarg.0
    IL_0085: ldstr 0x70023707
    IL_0086: IL_22
    IL_0087: nop
    IL_0088: nop
    IL_0089: nop
    IL_008A: IL_3F
    IL_008B: IL_22
    IL_008C: IL_CD
    IL_008D: IL_CC
    IL_008E: IL_4C
    IL_008F: IL_3D
    IL_0094: call 0x0A000017
    IL_0099: ldstr 0x70002687
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000B7B
    IL_00A0: conv.r8
    IL_00A1: ldarg.3
    IL_00A2: ldarg.1
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A9: call 0x06000221
    IL_00AE: ldstr 0x700026AB
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000B7A
    IL_00B5: conv.r8
    IL_00B6: ldarg.3
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: stloc.0
    IL_00BE: call 0x06000221
    IL_00C3: ldstr 0x7000269B
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x04000B79
    IL_00CA: conv.r8
    IL_00CB: ldarg.3
    IL_00CC: ldarg.1
    IL_00CD: nop
    IL_00CE: stloc.0
    IL_00D3: call 0x06000221
    IL_00D8: ldstr 0x7002371B
    IL_00D9: ldc.i4.1
    IL_00DE: call 0x0A00009F
    IL_00E3: ldstr 0x7000052B
    IL_00E4: ldc.i4.1
    IL_00E9: call 0x0A00009F
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000B74
    IL_00F0: conv.r8
    IL_00F1: stloc.0
    IL_00F2: nop
    IL_00F3: nop
    IL_00F4: stloc.0
    IL_00F5: ldc.i4.1
    IL_00F6: conv.r8
    IL_00F7: stloc.1
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FB: ldarg.0
    IL_0100: ldfld 0x04000B74
    IL_0101: conv.r8
    IL_0102: IL_83
    IL_0103: nop
    IL_0104: nop
    IL_0106: br.s IL_010D
    IL_0107: conv.r8
    IL_0108: IL_D4
    IL_0109: ldarg.3
    IL_010A: nop
    IL_010B: ldloc.0
    IL_010C: ret
    }

    private void ScorePlus() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B67
    IL_0006: conv.i2
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BAF
    IL_000D: IL_59
    IL_000E: stloc.0
    IL_000F: ldloc.0
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: stsfld 0x0057433F
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04000BAF
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000B67
    IL_0027: conv.i2
    IL_002C: call 0x0A000024
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_0030: ldelem.r8
    IL_94A19D: switch (2435162 cases)
    }

    public void Stagefinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B62
    IL_0007: ret
    }

    public void WaveClear() {
    IL_0004: newobj 0x060007C9
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x040010A9
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void IntermissionOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B7E
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000B7E
    IL_0011: conv.r8
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: IL_22
    IL_0017: IL_CD
    IL_0018: IL_CC
    IL_0019: IL_4C
    IL_001A: IL_3D
    IL_001F: call 0x0A000008
    IL_0024: call 0x0A000029
    IL_0025: stloc.0
    IL_0026: ldloc.0
    IL_002B: call 0x0A000064
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_0033: stsfld 0x0011433F
    IL_0034: nop
    IL_0035: nop
    IL_0036: ldloc.0
    IL_003B: call 0x0A000040
    IL_003C: IL_22
    IL_003E: bne.un.s IL_0072
    IL_0043: newobj 0x0008283F
    IL_0044: nop
    IL_0045: stloc.0
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000B7D
    IL_004D: conv.r8
    IL_004E: stloc.0
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: conv.r8
    IL_0053: ldarg.3
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: ldloc.0
    IL_0058: conv.r8
    IL_0059: ldloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000B7D
    IL_0063: conv.r8
    IL_0064: stloc.0
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ldc.i4.1
    IL_0069: conv.r8
    IL_006A: stloc.1
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_006E: ret
    }

    public void LoadingFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B92
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BA2
    IL_000D: conv.r8
    IL_000E: xor
    IL_000F: IL_01
    IL_0010: nop
    IL_0011: ldloc.0
    IL_0012: ldarg.0
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_001A: stsfld 0x5A7B023F
    IL_001B: stloc.1
    IL_001C: nop
    IL_001D: ldarg.2
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000B5B
    IL_0025: ldc.i4.s 100
    IL_0026: IL_5A
    IL_0027: conv.i2
    IL_0028: add
    IL_0029: IL_59
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_3E
    IL_002F: IL_5A
    IL_0034: stfld 0x04000B86
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000BAA
    IL_003F: call 0x0A0000AA
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000B86
    IL_004A: call 0x0A000083
    IL_004B: conv.r8
    IL_004C: IL_F3
    IL_004D: ldarg.0
    IL_004E: nop
    IL_004F: ldloc.0
    IL_0050: ldarg.0
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0058: stsfld 0x647B023F
    IL_0059: stloc.1
    IL_005A: nop
    IL_005B: ldarg.2
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_41
    IL_0061: add
    IL_0062: IL_59
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: nop
    IL_0067: IL_3F
    IL_0068: IL_5A
    IL_006D: stfld 0x04000B85
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000B6E
    IL_0074: conv.r8
    IL_0075: IL_24
    IL_0076: nop
    IL_0077: nop
    IL_0079: br.s IL_007C
    IL_007E: ldflda 0x04000B5B
    IL_0083: call 0x0A000010
    IL_0084: conv.r8
    IL_0085: IL_FD
    IL_0086: nop
    IL_0087: nop
    IL_0088: stloc.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000B61
    IL_0093: brtrue IL_015E
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000B76
    IL_009E: call 0x0A00004B
    IL_009F: conv.r8
    IL_00A0: IL_AF
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x04000BA9
    IL_00AE: call 0x0A000082
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000B85
    IL_00B9: call 0x0A000083
    IL_00BA: conv.r8
    IL_00BB: IL_F3
    IL_00BC: ldarg.0
    IL_00BD: nop
    IL_00BE: ldloc.0
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x04000BA4
    IL_00C5: conv.r8
    IL_00C6: IL_FA
    IL_00C7: ldarg.2
    IL_00C8: nop
    IL_00C9: ldloc.0
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04000B9B
    IL_00D0: stloc.0
    IL_00D1: ldloc.0
    IL_00D2: ldc.i4.4
    IL_00D3: IL_58
    IL_00D6: ldarg 3
    IL_00D7: nop
    IL_00D8: nop
    IL_00DD: call 0x4B000000
    IL_00DE: nop
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: ldarg.3
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: nop
    IL_00E9: br IL_0153
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000B72
    IL_00F0: conv.r8
    IL_00F1: stloc.0
    IL_00F2: nop
    IL_00F3: nop
    IL_00F4: stloc.0
    IL_00F5: ldc.i4.1
    IL_00F6: conv.r8
    IL_00F7: stloc.1
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FB: ldarg.0
    IL_0100: ldfld 0x04000BA5
    IL_0101: ldc.i4.1
    IL_0102: ldc.i4.0
    IL_0103: conv.r8
    IL_0104: IL_36
    IL_0105: ldloc.0
    IL_0106: nop
    IL_0107: ldloc.0
    IL_010C: br IL_0153
    IL_010D: ldarg.0
    IL_0112: ldfld 0x04000B72
    IL_0113: conv.r8
    IL_0114: stloc.0
    IL_0115: nop
    IL_0116: nop
    IL_0117: stloc.0
    IL_0118: ldc.i4.1
    IL_0119: conv.r8
    IL_011A: stloc.1
    IL_011B: nop
    IL_011C: nop
    IL_011D: stloc.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x04000BA5
    IL_0124: ldc.i4.5
    IL_0125: ldc.i4.0
    IL_0126: conv.r8
    IL_0127: IL_36
    IL_0128: ldloc.0
    IL_0129: nop
    IL_012A: ldloc.0
    IL_012F: br IL_0153
    IL_0130: ldarg.0
    IL_0135: ldfld 0x04000B72
    IL_0136: conv.r8
    IL_0137: stloc.0
    IL_0138: nop
    IL_0139: nop
    IL_013A: stloc.0
    IL_013B: ldc.i4.1
    IL_013C: conv.r8
    IL_013D: stloc.1
    IL_013E: nop
    IL_013F: nop
    IL_0140: stloc.0
    IL_0141: ldarg.0
    IL_0146: ldfld 0x04000BA5
    IL_0147: ldc.i4.6
    IL_0148: ldc.i4.0
    IL_0149: conv.r8
    IL_014A: IL_36
    IL_014B: ldloc.0
    IL_014C: nop
    IL_014D: ldloc.0
    IL_0152: br IL_0153
    IL_0157: ldstr 0x70002093
    IL_0158: ldc.i4.m1
    IL_015D: call 0x0600021F
    IL_015E: ret
    }

    public void ResetPower() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000B60
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x04000B91
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BAB
    IL_001C: call 0x0A000057
    IL_001D: conv.r8
    IL_001E: IL_F3
    IL_001F: ldarg.0
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000B78
    IL_0028: conv.r8
    IL_0029: stloc.0
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.0
    IL_002E: conv.r8
    IL_002F: stloc.1
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ret
    }

    public void PowerCharge() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B60
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B78
    IL_000D: conv.r8
    IL_000E: stloc.0
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    public void GrabCharge() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B78
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: dup
    IL_0017: ldfld 0x04000B91
    IL_0018: IL_22
    IL_0019: stloc.0
    IL_001A: IL_D7
    IL_001B: stelem.i
    IL_001C: IL_3C
    IL_001D: IL_58
    IL_0022: stfld 0x04000B91
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000BAB
    IL_002D: call 0x0A000082
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000B91
    IL_0034: shl
    IL_0039: call 0x0A000083
    IL_003A: conv.r8
    IL_003B: IL_F3
    IL_003C: ldarg.0
    IL_003D: nop
    IL_003E: ldloc.0
    IL_003F: ret
    }

    public void GainCoin() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B66
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000B66
    IL_000E: ldarg.0
    IL_000F: dup
    IL_0014: ldfld 0x04000B68
    IL_0015: ldarg.1
    IL_0016: IL_58
    IL_001B: stfld 0x04000B68
    IL_001C: ldarg.1
    IL_001D: ldc.i4.0
    IL_0022: call 0x0600021E
    IL_0023: pop
    IL_0024: ret
    }

    public void GainJade() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B65
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000B65
    IL_000E: ldarg.0
    IL_000F: dup
    IL_0014: ldfld 0x04000B69
    IL_0015: ldarg.1
    IL_0016: IL_58
    IL_001B: stfld 0x04000B69
    IL_001C: ldarg.1
    IL_001D: ldc.i4.1
    IL_0022: call 0x0600021E
    IL_0023: pop
    IL_0024: ret
    }

    public void GainSoul() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: dup
    IL_0008: ldfld 0x04000B64
    IL_0009: ldarg.1
    IL_000A: IL_58
    IL_000F: stfld 0x04000B64
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000B61
    IL_001A: brtrue IL_0036
    IL_001B: ldarg.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000B64
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_41
    IL_0030: call 0x0A0000D4
    IL_0035: stfld 0x04000B64
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000B64
    IL_003C: not
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000B63
    IL_0047: beq IL_009C
    IL_0048: ldarg.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000B64
    IL_004F: not
    IL_0054: stfld 0x04000B63
    IL_0055: ldarg.0
    IL_0056: IL_22
    IL_0057: nop
    IL_0058: nop
    IL_005D: stsfld 0x637B023F
    IL_005E: stloc.1
    IL_005F: nop
    IL_0060: ldarg.2
    IL_0061: conv.i2
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_41
    IL_0067: add
    IL_0068: IL_59
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_3F
    IL_006E: IL_5A
    IL_0073: stfld 0x04000B85
    IL_0074: ldarg.0
    IL_0079: ldfld 0x04000B61
    IL_007E: brtrue IL_009A
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000BA9
    IL_0089: call 0x0A000082
    IL_008A: ldarg.0
    IL_008F: ldfld 0x04000B85
    IL_0094: call 0x0A000083
    IL_0095: conv.r8
    IL_0096: IL_F3
    IL_0097: ldarg.0
    IL_0098: nop
    IL_0099: ldloc.0
    IL_009A: ldc.i4.1
    IL_009B: stloc.0
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x04000BA6
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000B63
    IL_00A8: conv.r8
    IL_00A9: IL_3D
    IL_00AA: ldarg.1
    IL_00AB: nop
    IL_00AC: ldloc.0
    IL_00AD: ldloc.0
    IL_00AE: ret
    }

    public void GetExp() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0007: ldfld 0x04000BA2
    IL_0008: conv.r8
    IL_0009: IL_99
    IL_000A: IL_01
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000B61
    IL_0017: brtrue IL_002A
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000B6B
    IL_0023: call 0x06000624
    IL_0024: stloc.0
    IL_0029: br IL_0059
    IL_002A: ldarg.0
    IL_002B: dup
    IL_0030: ldfld 0x04000B67
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000B94
    IL_003B: ldc.i4 200
    IL_003C: IL_5A
    IL_003D: IL_58
    IL_0042: stfld 0x04000B67
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000B7A
    IL_0049: ldarg.0
    IL_004E: ldflda 0x04000B67
    IL_0053: call 0x0A000010
    IL_0054: conv.r8
    IL_0055: IL_FD
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000BA2
    IL_0064: ldfld 0x040002EF
    IL_0069: stfld 0x04000B5A
    IL_006A: ldarg.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04000BA2
    IL_0075: ldfld 0x040002EE
    IL_007A: stfld 0x04000B5B
    IL_007B: ldarg.0
    IL_007C: dup
    IL_0081: ldfld 0x04000B9D
    IL_0082: ldc.i4.1
    IL_0083: IL_58
    IL_0084: neg
    IL_0089: stfld 0x04000B9D
    IL_008A: ldarg.0
    IL_008B: dup
    IL_0090: ldfld 0x04000B9F
    IL_0091: ldc.i4.1
    IL_0092: IL_58
    IL_0097: stfld 0x04000B9F
    IL_0098: ldarg.0
    IL_009D: ldfld 0x04000B90
    IL_009E: ldc.i4.5
    IL_009F: IL_3E
    IL_00A0: ldarg.3
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: nop
    IL_00A8: br IL_014B
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000B61
    IL_00B3: brfalse IL_0102
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x04000B9D
    IL_00BB: ldc.i4.s 10
    IL_00BC: IL_3F
    IL_00BD: IL_3C
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: dup
    IL_00C7: ldfld 0x04000BA1
    IL_00C8: ldc.i4.1
    IL_00C9: IL_59
    IL_00CA: neg
    IL_00CF: stfld 0x04000BA1
    IL_00D0: ldarg.0
    IL_00D5: ldfld 0x04000BAC
    IL_00DA: call 0x0A000082
    IL_00DB: IL_22
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: IL_3D
    IL_00E4: call 0x0A000083
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x04000BA1
    IL_00EB: conv.i2
    IL_00F0: call 0x0A000083
    IL_00F1: conv.r8
    IL_00F2: IL_F3
    IL_00F3: ldarg.0
    IL_00F4: nop
    IL_00F5: ldloc.0
    IL_00F6: ldarg.0
    IL_00F7: ldc.i4.0
    IL_00FC: stfld 0x04000B9D
    IL_0101: br IL_014B
    IL_0102: ldarg.0
    IL_0107: ldfld 0x04000B9D
    IL_0109: ldc.i4.s 15
    IL_010A: IL_3F
    IL_010B: IL_3C
    IL_010C: nop
    IL_010D: nop
    IL_010E: nop
    IL_010F: ldarg.0
    IL_0110: dup
    IL_0115: ldfld 0x04000BA1
    IL_0116: ldc.i4.1
    IL_0117: IL_59
    IL_0118: neg
    IL_011D: stfld 0x04000BA1
    IL_011E: ldarg.0
    IL_0123: ldfld 0x04000BAC
    IL_0128: call 0x0A000082
    IL_0129: IL_22
    IL_012A: nop
    IL_012B: nop
    IL_012C: nop
    IL_012D: IL_3D
    IL_0132: call 0x0A000083
    IL_0133: ldarg.0
    IL_0138: ldfld 0x04000BA1
    IL_0139: conv.i2
    IL_013E: call 0x0A000083
    IL_013F: conv.r8
    IL_0140: IL_F3
    IL_0141: ldarg.0
    IL_0142: nop
    IL_0143: ldloc.0
    IL_0144: ldarg.0
    IL_0145: ldc.i4.0
    IL_014A: stfld 0x04000B9D
    IL_014B: ldarg.0
    IL_014C: IL_22
    IL_014D: nop
    IL_014E: nop
    IL_0153: stsfld 0x5A7B023F
    IL_0154: stloc.1
    IL_0155: nop
    IL_0156: ldarg.2
    IL_0157: conv.i2
    IL_0158: ldarg.0
    IL_015D: ldfld 0x04000B5B
    IL_015F: ldc.i4.s 100
    IL_0160: IL_5A
    IL_0161: conv.i2
    IL_0162: add
    IL_0163: IL_59
    IL_0164: IL_22
    IL_0165: nop
    IL_0166: nop
    IL_0167: nop
    IL_0168: IL_3E
    IL_0169: IL_5A
    IL_016E: stfld 0x04000B86
    IL_016F: ldarg.0
    IL_0174: ldfld 0x04000BAA
    IL_0179: call 0x0A0000AA
    IL_017A: ldarg.0
    IL_017F: ldfld 0x04000B86
    IL_0184: call 0x0A000083
    IL_0185: conv.r8
    IL_0186: IL_F3
    IL_0187: ldarg.0
    IL_0188: nop
    IL_0189: ldloc.0
    IL_018A: ldarg.0
    IL_018F: ldfld 0x04000B5B
    IL_0190: ldarg.0
    IL_0195: ldfld 0x04000B80
    IL_019A: beq IL_01F2
    IL_019B: ldarg.0
    IL_01A0: ldfld 0x04000B6D
    IL_01A1: IL_22
    IL_01A2: IL_CD
    IL_01A3: IL_CC
    IL_01A4: IL_AC
    IL_01A5: IL_BF
    IL_01A6: IL_22
    IL_01A7: IL_8F
    IL_01A8: IL_C2
    IL_01A9: IL_35
    IL_200000236: switch (2147483682 cases)
    }

    public void PauseOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B92
    IL_000A: brfalse IL_0016
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000BA5
    IL_0011: conv.r8
    IL_0012: IL_35
    IL_0013: ldloc.0
    IL_0014: nop
    IL_0015: ldloc.0
    IL_0016: ret
    }

    public void Resurrection() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000B66
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000B65
    IL_0020: ret
    }

    public void Damaged_Extreme() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B81
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000B81
    IL_000E: ret
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000B83
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000E: stsfld 0x837D583D
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: ldarg.2
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BA7
    IL_001C: call 0x0A000082
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000B83
    IL_0027: call 0x0A000083
    IL_0028: conv.r8
    IL_0029: IL_F3
    IL_002A: ldarg.0
    IL_002B: nop
    IL_002C: ldloc.0
    IL_002D: ldarg.0
    IL_002E: dup
    IL_0033: ldfld 0x04000B81
    IL_0034: ldc.i4.1
    IL_0035: IL_58
    IL_003A: stfld 0x04000B81
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000B81
    IL_0041: ldc.i4.3
    IL_0042: IL_3F
    IL_0043: ldc.i4.7
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: ldarg.0
    IL_0048: ldc.i4.m1
    IL_004D: call 0x06000610
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000BA2
    IL_0054: conv.r8
    IL_0059: cpobj 0x02060001
    IL_005E: ldfld 0x04000BA2
    IL_005F: conv.r8
    IL_0064: newobj 0x2A060001
    }

    public void GameOver() {
    IL_0004: ldstr 0x70002059
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_000D: IL_58
    IL_000E: stloc.0
    IL_0013: ldstr 0x70002059
    IL_0014: ldloc.0
    IL_0019: call 0x0600021F
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000B72
    IL_0020: conv.r8
    IL_0021: stloc.0
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldc.i4.1
    IL_0026: conv.r8
    IL_0027: stloc.1
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000BA5
    IL_0031: conv.r8
    IL_0032: IL_34
    IL_0033: ldloc.0
    IL_0034: nop
    IL_0035: ldloc.0
    IL_0036: ret
    }

    public void StatUpdate_sp() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000B58
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000F: stsfld 0x587B023F
    IL_0010: stloc.1
    IL_0011: nop
    IL_0012: ldarg.2
    IL_0013: conv.i2
    IL_0014: ldarg.0
    IL_0019: ldfld 0x04000B59
    IL_001A: conv.i2
    IL_001B: add
    IL_001C: IL_59
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: IL_3F
    IL_0022: IL_5A
    IL_0027: stfld 0x04000B84
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000B58
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0033: ldloc 17474
    IL_0038: ldc.i4 33554432
    IL_003D: ldfld 0x04000BA8
    IL_0042: call 0x0A000082
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000B84
    IL_004D: call 0x0A000083
    IL_004E: conv.r8
    IL_004F: IL_F3
    IL_0050: ldarg.0
    IL_0051: nop
    IL_0052: ldloc.0
    IL_0057: br IL_0087
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000BA8
    IL_0062: call 0x0A000082
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000B84
    IL_006D: call 0x0A000083
    IL_0072: call 0x0A0000AA
    IL_0073: IL_22
    IL_0074: nop
    IL_0075: nop
    IL_0076: nop
    IL_0077: IL_3D
    IL_007C: call 0x0A000083
    IL_0081: call 0x0A000174
    IL_0082: conv.r8
    IL_0083: IL_F3
    IL_0084: ldarg.0
    IL_0085: nop
    IL_0086: ldloc.0
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000B8C
    IL_008D: ldc.i4.m1
    IL_0092: beq IL_00AF
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04000B8A
    IL_009D: brtrue IL_00AF
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x04000BA6
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x04000B58
    IL_00AA: conv.r8
    IL_00AB: IL_36
    IL_00AC: ldarg.1
    IL_00AD: nop
    IL_00AE: ldloc.0
    IL_00AF: ret
    }

    public void StatUpdate_hp() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000B8D
    IL_000C: ldc.i4.2
    IL_0011: beq IL_005E
    IL_0012: ldarg.0
    IL_0013: ldarg.1
    IL_0018: stfld 0x04000B57
    IL_0019: ldarg.0
    IL_001A: ldarg.2
    IL_001F: stfld 0x04000B56
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0x577B023F
    IL_0028: stloc.1
    IL_0029: nop
    IL_002A: ldarg.2
    IL_002B: conv.i2
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000B56
    IL_0032: conv.i2
    IL_0033: add
    IL_0034: IL_59
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_0037: ldloc.0
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: IL_3F
    IL_003D: IL_5A
    IL_0042: stfld 0x04000B83
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000BA7
    IL_004D: call 0x0A000082
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000B83
    IL_0058: call 0x0A000083
    IL_0059: conv.r8
    IL_005A: IL_F3
    IL_005B: ldarg.0
    IL_005C: nop
    IL_005D: ldloc.0
    IL_005E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B93
    IL_000A: brfalse IL_0010
    IL_000F: br IL_009D
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000B87
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_43
    IL_001C: or
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000BAE
    IL_002A: brfalse IL_007E
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000B7F
    IL_0031: IL_22
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_22
    IL_0037: IL_29
    IL_0038: sub
    IL_003A: bge.s IL_007B
    IL_003B: IL_22
    IL_003C: shr
    IL_003D: shr
    IL_003E: ldloc.0
    IL_1DA0F: switch (30323 cases)
    }

    }}
