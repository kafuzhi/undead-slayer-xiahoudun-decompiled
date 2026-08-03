// Namespace: 
// Type: UI_result

    public class UI_result {{

    private object show_delay;
    private object openbox;
    private object getpoint;
    private object startexpgain;
    public object isclear;
    private object clear_grade;
    private object cur_stage_index;
    public object max_stage_index;
    private object coin;
    private object dropcoin;
    private object jade;
    private object dropjade;
    private object getcoin;
    private object getexp;
    private object chalv;
    private object chaexp;
    private object language;
    private object getcoin_f;
    private object getexp_f;
    private object gonext;
    private object starmove;
    public object basicSkin;
    public object bg_asset;
    public object gauge_exp;
    public object bg_list;
    public object bg_gauge;
    public object icon_coin;
    public object icon_jade;
    public object star_big;
    public object bg_speech2;
    public object img_bts;
    public object icon_mission;
    public object bt_empty;
    public object pt_star;
    public object inven_weapon;
    private object icon_size;
    private object posX;
    private object cashshop;
    private object movefinish;
    private object b_getgem;
    private object changelevel;
    private object icon_pluspos;
    private object ranking;
    private object b_openshop;
    private object mission_archive_current;
    private object mission_archive_already;
    private object efon;
    private object curtraining;
    private object trainmax;
    public object bgm_victory;
    public object bgm_defeat;
    private object cur_difficulty;

    public UI_result() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F17
    IL_0007: ldarg.0
    IL_0008: ldc.i4.5
    IL_000D: newarr 0x0100003C
    IL_0012: stfld 0x04000F33
    IL_0013: ldarg.0
    IL_0014: ldc.i4.3
    IL_0019: newarr 0x0100003C
    IL_001E: stfld 0x04000F34
    IL_001F: ldarg.0
    IL_0020: ldc.i4.3
    IL_0025: newarr 0x0100002F
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_96
    IL_002C: IL_43
    IL_002D: ldelem.r8
    IL_002E: dup
    IL_002F: ldc.i4.1
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_96
    IL_0034: IL_43
    IL_0035: ldelem.r8
    IL_0036: dup
    IL_0037: ldc.i4.2
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_96
    IL_003C: IL_43
    IL_003D: ldelem.r8
    IL_0042: stfld 0x04000F38
    IL_0043: ldarg.0
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_0047: throw
    IL_0048: IL_44
    IL_004D: stfld 0x04000F39
    IL_004E: ldarg.0
    IL_004F: ldc.i4.3
    IL_0054: newarr 0x01000010
    IL_0059: stfld 0x04000F41
    IL_005A: ldarg.0
    IL_005B: ldc.i4.3
    IL_0060: newarr 0x01000010
    IL_0065: stfld 0x04000F42
    IL_0066: ldarg.0
    IL_0067: ldc.i4.3
    IL_006C: newarr 0x01000013
    IL_0071: stfld 0x04000F43
    IL_0072: ldarg.0
    IL_0073: ldc.i4.6
    IL_0078: newarr 0x0100000B
    IL_007D: stfld 0x04000F44
    IL_007E: ldarg.0
    IL_0083: call 0x0A000001
    IL_0084: ret
    }

    private void Awake() {
    IL_0004: ldstr 0x700236B1
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldstr 0x70001ED5
    IL_0015: call 0x06000220
    IL_001A: stfld 0x04000F48
    IL_001B: ldarg.0
    IL_001C: ldloc.0
    IL_0021: ldc.i4 1000
    IL_0022: add
    IL_0023: neg
    IL_0028: stfld 0x04000F19
    IL_0029: ldarg.0
    IL_002A: ldloc.0
    IL_002F: ldc.i4 1000
    IL_0030: mul
    IL_0035: stfld 0x04000F1A
    IL_0036: ldc.i4.0
    IL_0037: stloc.1
    IL_003C: br IL_0062
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000F41
    IL_0043: ldloc.1
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000F1A
    IL_004B: ldc.i4.s 10
    IL_004C: mul
    IL_004D: neg
    IL_004E: ldelem.i4
    IL_004F: ldarg.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000F1A
    IL_0057: ldc.i4.s 10
    IL_0058: add
    IL_005D: stfld 0x04000F1A
    IL_005E: ldloc.1
    IL_005F: ldc.i4.1
    IL_0060: IL_58
    IL_0061: stloc.1
    IL_0062: ldloc.1
    IL_0063: ldc.i4.3
    IL_0064: IL_3F
    IL_0065: IL_D4
    IL_0066: IL_FF
    IL_0067: IL_FF
    IL_0068: IL_FF
    IL_006D: ldstr 0x70001EDD
    IL_0072: call 0x060003F9
    IL_0073: stloc.2
    IL_0074: ldarg.0
    IL_0079: ldstr 0x70000CDD
    IL_007E: call 0x06000220
    IL_0083: stfld 0x04000F1B
    IL_0084: ldarg.0
    IL_0089: ldstr 0x700004DD
    IL_008E: call 0x06000220
    IL_0093: stfld 0x04000F1C
    IL_0094: ldc.i4.0
    IL_0095: stloc.3
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000F1C
    IL_009C: ldc.i4.5
    IL_009D: IL_3C
    IL_009F: ldarga.s 0
    IL_00A0: nop
    IL_00A1: nop
    IL_00A6: ldstr 0x70024190
    IL_00AB: call 0x0A000077
    IL_00B0: call 0x0A000050
    IL_00B1: ldloc.2
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x04000F1B
    IL_00B8: IL_94
    IL_00B9: stloc.3
    IL_00BA: ldc.i4.0
    IL_00BC: stloc.s 4
    IL_00C1: br IL_00DB
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x04000F42
    IL_00C9: ldloc.s 4
    IL_00CA: ldloc.3
    IL_00CC: ldc.i4.s 10
    IL_00CD: mul
    IL_00CE: neg
    IL_00CF: ldelem.i4
    IL_00D0: ldloc.3
    IL_00D2: ldc.i4.s 10
    IL_00D3: add
    IL_00D4: stloc.3
    IL_00D6: ldloc.s 4
    IL_00D7: ldc.i4.1
    IL_00D8: IL_58
    IL_00DA: stloc.s 4
    IL_00DC: ldloc.s 4
    IL_00DD: ldc.i4.3
    IL_00DE: IL_3F
    IL_00DF: IL_DF
    IL_00E0: IL_FF
    IL_00E1: IL_FF
    IL_00E2: IL_FF
    IL_00E3: ldc.i4.0
    IL_00E5: stloc.s 5
    IL_00E6: ldarg.0
    IL_00EB: ldfld 0x04000F42
    IL_00EC: ldc.i4.2
    IL_00ED: IL_92
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x04000F41
    IL_00F4: ldc.i4.2
    IL_00F5: IL_92
    IL_00F6: IL_58
    IL_00F7: ldc.i4.0
    IL_00F8: IL_3E
    IL_00F9: ldloc.1
    IL_00FA: nop
    IL_00FB: nop
    IL_00FC: nop
    IL_00FE: ldloc.s 5
    IL_0100: ldc.i4.s 100
    IL_0101: IL_58
    IL_0103: stloc.s 5
    IL_0104: ldarg.0
    IL_0109: ldfld 0x04000F42
    IL_010A: ldc.i4.1
    IL_010B: IL_92
    IL_010C: ldarg.0
    IL_0111: ldfld 0x04000F41
    IL_0112: ldc.i4.1
    IL_0113: IL_92
    IL_0114: IL_58
    IL_0115: ldc.i4.0
    IL_0116: IL_3E
    IL_0117: ldloc.1
    IL_0118: nop
    IL_0119: nop
    IL_011A: nop
    IL_011C: ldloc.s 5
    IL_011E: ldc.i4.s 10
    IL_011F: IL_58
    IL_0121: stloc.s 5
    IL_0122: ldarg.0
    IL_0127: ldfld 0x04000F42
    IL_0128: ldc.i4.0
    IL_0129: IL_92
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000F41
    IL_0130: ldc.i4.0
    IL_0131: IL_92
    IL_0132: IL_58
    IL_0133: ldc.i4.0
    IL_0134: IL_3E
    IL_0135: ldloc.0
    IL_0136: nop
    IL_0137: nop
    IL_0138: nop
    IL_013A: ldloc.s 5
    IL_013B: ldc.i4.1
    IL_013C: IL_58
    IL_013E: stloc.s 5
    IL_013F: ldloc.2
    IL_0140: ldarg.0
    IL_0145: ldfld 0x04000F1B
    IL_0147: ldloc.s 5
    IL_0148: ldelem.i8
    IL_014D: ldstr 0x70001EDD
    IL_014E: ldloc.2
    IL_0153: call 0x060003F8
    IL_0154: pop
    IL_0155: IL_22
    IL_0156: nop
    IL_0157: nop
    IL_015C: stsfld 0x0111283F
    IL_015D: nop
    IL_015E: stloc.0
    IL_015F: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F1D
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F1F
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000F37
    IL_0026: conv.r8
    IL_0027: stloc.0
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: conv.r8
    IL_002C: len
    IL_002D: nop
    IL_002E: nop
    IL_0030: br.s IL_00A0
    IL_0031: rem
    IL_0032: ldarg.1
    IL_0033: nop
    IL_0034: ldloc.0
    IL_0035: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000F25
    IL_0010: ldarg.0
    IL_0015: call 0x0A00002B
    IL_001A: ldstr 0x70022774
    IL_001F: call 0x0A0001C1
    IL_0020: conv.r8
    IL_0021: IL_C9
    IL_0022: IL_01
    IL_0023: nop
    IL_0024: stloc.0
    IL_0029: ldstr 0x7002270C
    IL_002E: call 0x0A0001C1
    IL_0033: call 0x0A0001C2
    IL_0034: ldarg.0
    IL_0039: ldstr 0x70023257
    IL_003E: call 0x06000220
    IL_0043: stfld 0x04000F20
    IL_0044: ldarg.0
    IL_0049: ldstr 0x7002325F
    IL_004E: call 0x06000220
    IL_0053: stfld 0x04000F1E
    IL_0058: ldstr 0x70023257
    IL_0059: ldc.i4.0
    IL_005E: call 0x0600021F
    IL_0063: ldstr 0x7002325F
    IL_0064: ldc.i4.0
    IL_0069: call 0x0600021F
    IL_006A: ldarg.0
    IL_006B: dup
    IL_0070: ldfld 0x04000F1D
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000F1E
    IL_0077: IL_59
    IL_007C: stfld 0x04000F1D
    IL_007D: ldarg.0
    IL_007E: dup
    IL_0083: ldfld 0x04000F1F
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000F20
    IL_008A: IL_59
    IL_008F: stfld 0x04000F1F
    IL_0090: ldarg.0
    IL_0095: ldstr 0x70000DDD
    IL_009A: call 0x06000220
    IL_009F: stfld 0x04000F23
    IL_00A0: ldarg.0
    IL_00A5: ldstr 0x70000DE5
    IL_00AA: call 0x06000220
    IL_00AF: stfld 0x04000F24
    IL_00B0: ldarg.0
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000F24
    IL_00B7: conv.i2
    IL_00BC: stfld 0x04000F27
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x04000F23
    IL_00C4: ldc.i4.s 19
    IL_00C5: IL_3C
    IL_00C6: IL_3D
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: nop
    IL_00CA: ldarg.0
    IL_00CF: ldstr 0x70002065
    IL_00D4: call 0x06000220
    IL_00D9: stfld 0x04000F3D
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000F3D
    IL_00E0: ldc.i4.1
    IL_014D: switch (26 cases)
    IL_014E: IL_F9
    IL_014F: ldarg.1
    IL_0150: nop
    IL_0151: ldloc.0
    IL_0156: stfld 0x04000F44
    IL_0157: ldc.i4.0
    IL_0158: stloc.0
    IL_0159: ldc.i4.0
    IL_015A: stloc.1
    IL_015F: br IL_0181
    IL_0160: ldarg.0
    IL_0165: ldfld 0x04000F44
    IL_0166: ldloc.1
    IL_0167: IL_94
    IL_0169: ldc.i4.s 10
    IL_016A: IL_3F
    IL_016B: ldloc.3
    IL_016C: nop
    IL_016D: nop
    IL_016E: nop
    IL_016F: ldloc.0
    IL_0170: ldc.i4.1
    IL_0171: IL_58
    IL_0172: stloc.0
    IL_0177: br IL_017D
    IL_017C: br IL_0188
    IL_017D: ldloc.1
    IL_017E: ldc.i4.1
    IL_017F: IL_58
    IL_0180: stloc.1
    IL_0181: ldloc.1
    IL_0182: ldc.i4.6
    IL_0183: IL_3F
    IL_0184: IL_D8
    IL_0185: IL_FF
    IL_0186: IL_FF
    IL_0187: IL_FF
    IL_0188: ldloc.0
    IL_0189: ldc.i4.6
    IL_01AA: switch (7 cases)
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: nop
    IL_01AE: ldarg.3
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: nop
    IL_01B3: starg.s 0
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: ldc.i4.5
    IL_01B7: nop
    IL_01B8: nop
    IL_01B9: nop
    IL_01BE: br IL_01E0
    IL_01BF: IL_22
    IL_01C0: nop
    IL_01C1: nop
    IL_01C6: stsfld 0x16380C3F
    IL_01C7: nop
    IL_01C8: nop
    IL_01C9: nop
    IL_01CA: IL_22
    IL_01CB: IL_CD
    IL_01CC: IL_CC
    IL_01D1: newobj 0x0B380C3F
    IL_01D2: nop
    IL_01D3: nop
    IL_01D4: nop
    IL_01D5: IL_22
    IL_01D6: nop
    IL_01D7: nop
    IL_01D8: IL_C0
    IL_01D9: IL_3F
    IL_01DA: stloc.2
    IL_01DF: br IL_01E0
    IL_01E0: ldarg.0
    IL_01E1: ldarg.0
    IL_01E6: ldfld 0x04000F1B
    IL_01E7: ldc.i4.2
    IL_01E8: IL_5A
    IL_01EA: ldc.i4.s 100
    IL_01EB: IL_58
    IL_01EC: conv.i2
    IL_01ED: ldloc.2
    IL_01EE: IL_5A
    IL_01EF: not
    IL_01F4: stfld 0x04000F21
    IL_01F5: ldarg.0
    IL_01F6: ldarg.0
    IL_01FB: ldfld 0x04000F1B
    IL_01FC: ldc.i4.5
    IL_01FD: IL_58
    IL_01FF: ldc.i4.s 20
    IL_0200: IL_5A
    IL_0205: stfld 0x04000F22
    IL_0206: ldarg.0
    IL_020B: call 0x0A00002B
    IL_020C: ldarg.0
    IL_0211: ldfld 0x04000F46
    IL_0212: conv.r8
    IL_0213: IL_4C
    IL_0214: nop
    IL_0215: nop
    IL_0216: stloc.0
    IL_0217: ldarg.0
    IL_021C: call 0x0A00002B
    IL_021D: conv.r8
    IL_021E: IL_4D
    IL_021F: nop
    IL_0220: nop
    IL_0221: stloc.0
    IL_0222: ret
    }

    public void GoNext() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F28
    IL_0007: ret
    }

    public void AmountJade() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000F1F
    IL_0007: ret
    }

    public void AmountCoin() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000F1D
    IL_0007: ret
    }

    public void GetGem() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F3C
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F3B
    IL_000A: brtrue IL_0202
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000F39
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_87
    IL_0016: IL_43
    IL_001B: call 0x0A000024
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_96
    IL_0020: IL_44
    IL_0021: IL_5A
    IL_0026: call 0x0A0000C0
    IL_002B: stfld 0x04000F39
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000F39
    IL_0032: IL_22
    IL_0033: nop
    IL_0034: nop
    IL_0035: IL_87
    IL_0036: IL_43
    IL_0753: switch (454 cases)
    }

    public void CashshopOpen() {
    IL_0004: ldstr 0x70001E8B
    IL_0005: ldarg.1
    IL_000A: call 0x0600021F
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000F3A
    IL_0011: ldnull
    IL_0016: call 0x0A000061
    IL_001B: brfalse IL_0031
    IL_001C: ldarg.0
    IL_0021: ldstr 0x700232DD
    IL_0026: call 0x0A000012
    IL_0027: conv.u8
    IL_0028: ldloc.0
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_01
    IL_0030: stfld 0x04000F3A
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000F3A
    IL_0037: conv.r8
    IL_0038: ldarg.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_0040: call 0x0A00001B
    IL_0045: call 0x0A000013
    IL_004A: call 0x0A000014
    IL_004B: pop
    IL_004C: ret
    }

    public void OpenShop() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F40
    IL_0007: ret
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000F2A
    IL_0040: call 0x0A0000DF
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_BE
    IL_0045: IL_43
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_004D: stsfld 0x00002240
    IL_004E: ldelem.r8
    IL_004F: IL_42
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldelem.r8
    IL_0054: IL_41
    IL_0059: call 0x0600021D
    IL_005E: ldsfld 0x040007B2
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000F25
    IL_0066: ldc.i4.s 64
    IL_006B: call 0x0A0000E1
    IL_0070: ldstr 0x70022F09
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000F1B
    IL_0077: ldc.i4.1
    IL_0078: IL_58
    IL_007D: newobj 0x0100000B
    IL_0082: call 0x0A000098
    IL_0087: call 0x0A0002EA
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04000F40
    IL_0092: brfalse IL_019B
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_E0
    IL_0097: IL_42
    IL_0098: IL_22
    IL_0099: nop
    IL_009A: nop
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_22
    IL_009E: nop
    IL_009F: nop
    IL_00A4: stsfld 0x00002243
    IL_00A5: nop
    IL_00A6: IL_42
    IL_00AB: call 0x0600021D
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x04000F2B
    IL_00B6: call 0x0A0000E0
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BB: ldloca.s 67
    IL_00BC: IL_22
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: IL_C0
    IL_28000014C: switch (2684354594 cases)
    }

    }}
