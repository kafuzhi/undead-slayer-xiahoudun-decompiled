// Namespace: 
// Type: UI_Ingame_GUI

    public class UI_Ingame_GUI {{

    public object pausemenu;
    public object bg_pause;
    public object bg_option;
    public object ico_slide;
    public object icon_jade;
    public object pop_blank;
    public object touchthis;
    private object guide_img;
    private object guidestart;
    private object guide_index;
    private object guide_maxindex;
    private object guide_curent_subindex;
    private object guide_txt;
    private object guide_point;
    private object guide_point_pos;
    private object guide_img_rect;
    private object getAngelIndex;
    public object zoom;
    public object sel_lang;
    public object bar_slide;
    public object bt_yesno;
    private object infinitymode;
    public object angel;
    private object vol_bgm;
    private object vol_master;
    private object color_alpha;
    private object slideon;
    private object slideon2;
    private object angelOn;
    private object showAds;
    private object script_cha;
    private object script_spawn;
    private object script_generalstat;
    private object cashshop;
    private object cashshopOn;
    private object count;
    private object require_jade;
    private object jade;
    private object pause;
    private object option;
    private object chance;
    private object language;
    private object script_UI;
    public object basicSkin;
    private object tempcamfov;

    public UI_Ingame_GUI() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000BBA
    IL_0007: ldarg.0
    IL_000C: call 0x0A000057
    IL_0011: stfld 0x04000BBE
    IL_0012: ldarg.0
    IL_0014: ldc.i4.s 10
    IL_0019: stfld 0x04000BD3
    IL_001A: ldarg.0
    IL_001B: ldc.i4.1
    IL_0020: stfld 0x04000BD4
    IL_0021: ldarg.0
    IL_0026: call 0x0A000001
    IL_0027: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700004D5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000BD5
    IL_0010: ret
    }

    private void Start() {
    IL_0000: ldc.i4.0
    IL_0005: call 0x0A0002E9
    IL_0006: ldarg.0
    IL_000B: ldstr 0x70000BB3
    IL_0010: call 0x0A000095
    IL_0015: stfld 0x04000BD9
    IL_0016: ldarg.0
    IL_001B: ldstr 0x70000BD5
    IL_0020: call 0x0A000004
    IL_0021: conv.r8
    IL_002A: ldc.i8 288243409182457856
    IL_002B: ldarg.0
    IL_0030: ldstr 0x70000001
    IL_0035: call 0x0A000004
    IL_0036: conv.r8
    IL_0037: ldarg.2
    IL_0038: nop
    IL_0039: nop
    IL_003B: br.s IL_00B9
    IL_003C: IL_CE
    IL_003D: stloc.1
    IL_003E: nop
    IL_003F: ldarg.2
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70000063
    IL_004A: call 0x0A000004
    IL_004B: conv.r8
    IL_004C: ldarg.0
    IL_004D: nop
    IL_004E: nop
    IL_0050: br.s IL_00CE
    IL_0051: IL_CF
    IL_0052: stloc.1
    IL_0053: nop
    IL_0054: ldarg.2
    IL_0055: ldarg.0
    IL_005A: ldstr 0x70022774
    IL_005F: call 0x0A0001C1
    IL_0064: stfld 0x04000BC7
    IL_0065: ldarg.0
    IL_006A: ldstr 0x7002270C
    IL_006F: call 0x0A0001C1
    IL_0074: stfld 0x04000BC8
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000BC8
    IL_007F: call 0x0A0001C2
    IL_0080: ldarg.0
    IL_0081: ldarg.0
    IL_0086: ldfld 0x04000BCF
    IL_008B: ldfld 0x0400095D
    IL_0090: stfld 0x04000BC5
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000BC5
    IL_009B: brfalse IL_00A3
    IL_009C: ldarg.0
    IL_009D: ldc.i4.3
    IL_00A2: stfld 0x04000BD4
    IL_00A3: ldarg.0
    IL_00A8: ldstr 0x70001E7D
    IL_00AD: call 0x06000220
    IL_00B2: stfld 0x04000BDC
    IL_00B7: call 0x0A000035
    IL_00B8: conv.r8
    IL_00B9: ldloc.0
    IL_00BA: nop
    IL_00BB: nop
    IL_00BD: br.s IL_00C0
    IL_00C2: ldfld 0x04000BDC
    IL_00C4: ldc.i4.s -2
    IL_00C5: IL_5A
    IL_00C7: ldc.i4.s 30
    IL_00C8: IL_58
    IL_00C9: conv.i2
    IL_00CA: conv.r8
    IL_00CC: blt.s IL_00CE
    IL_00CD: nop
    IL_00CE: ldloc.0
    IL_00CF: ldarg.0
    IL_00D4: call 0x0A00000A
    IL_00D5: ldc.i4.0
    IL_00D6: conv.r8
    IL_00D7: stloc.1
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: stloc.0
    IL_00DF: call 0x0600004E
    IL_00E0: conv.r8
    IL_00E1: neg
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: ldloc.0
    IL_00E5: ret
    }

    public void CountDown() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BD3
    IL_0007: ldc.i4.1
    IL_0008: IL_59
    IL_000D: stfld 0x04000BD3
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000BD3
    IL_0014: ldc.i4.0
    IL_0015: IL_3D
    IL_0016: ldc.i4.7
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldarg.0
    IL_001B: ldc.i4.0
    IL_0020: stfld 0x04000BD8
    IL_0021: IL_22
    IL_0022: nop
    IL_0023: nop
    IL_0028: stsfld 0x0111283F
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000BDA
    IL_0031: ldc.i4.m1
    IL_0032: conv.r8
    IL_0034: starg.s 6
    IL_0035: nop
    IL_0036: ldloc.0
    IL_0037: ret
    }

    public void GetAngel() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000BC0
    IL_000B: ldstr 0x7000000F
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000BC0
    IL_0016: call 0x0600021F
    IL_0017: ldarg.0
    IL_0018: ldc.i4.1
    IL_001D: stfld 0x04000BCC
    IL_001E: ldarg.0
    IL_0023: ldstr 0x7002374B
    IL_0024: IL_22
    IL_0025: ldelem.i
    IL_0026: IL_99
    IL_0027: ldc.i4.3
    IL_FCCC: switch (16168 cases)
    }

    private void GetAngelFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000BCC
    IL_0007: ldarg.0
    IL_000C: call 0x0A00000A
    IL_000D: ldc.i4.0
    IL_000E: conv.r8
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: stloc.0
    IL_0017: call 0x0A000303
    IL_0018: ret
    }

    public void ChanceOn() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_3F
    IL_0009: call 0x0A000111
    IL_000A: ldarg.0
    IL_000B: ldc.i4.1
    IL_0010: stfld 0x04000BD8
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700235C7
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_3F
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_3F
    IL_0025: call 0x0A000017
    IL_0026: ret
    }

    public void PauseOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BD2
    IL_000A: brfalse IL_0018
    IL_000B: ldarg.0
    IL_0010: call 0x0A00000A
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0013: stloc.1
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ret
    IL_0018: ldarg.0
    IL_001D: call 0x0A00000A
    IL_001E: ldc.i4.1
    IL_001F: conv.r8
    IL_0020: stloc.1
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_002D: call 0x0A000111
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000BCE
    IL_0034: conv.r8
    IL_0039: newobj 0x02060001
    IL_003A: ldc.i4.1
    IL_003F: stfld 0x04000BD6
    IL_0044: call 0x060001EF
    IL_0045: conv.r8
    IL_0046: IL_F5
    IL_0047: IL_01
    IL_0048: nop
    IL_0049: ldloc.0
    IL_004A: stloc.0
    IL_004B: ldloc.0
    IL_0050: ldstr 0x700233A9
    IL_0055: call 0x0A0000EC
    IL_005A: brfalse IL_006C
    IL_005F: call 0x0600004E
    IL_0060: conv.r8
    IL_0061: or
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldloc.0
    IL_0065: ldarg.0
    IL_0066: ldc.i4.0
    IL_006B: stfld 0x04000BCD
    IL_006C: ret
    }

    public void SetTutorial() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0009: call 0x0A000111
    IL_000A: ldarg.0
    IL_000F: ldfld 0x04000BCE
    IL_0010: conv.r8
    IL_0015: newobj 0x02060001
    IL_0016: ldc.i4.1
    IL_001B: stfld 0x04000BB8
    IL_001C: ldarg.0
    IL_001D: ldc.i4.0
    IL_0022: stfld 0x04000BBC
    IL_0023: ldarg.0
    IL_0024: ldarg.2
    IL_0029: stfld 0x04000BBB
    IL_002A: ldarg.0
    IL_002B: ldarg.1
    IL_0030: stfld 0x04000BB9
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000BB9
    IL_0038: ldc.i4.s 10
    IL_0039: IL_5A
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000BBB
    IL_0040: IL_58
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0047: ldstr 0x70023769
    IL_0049: ldloca.s 0
    IL_004E: call 0x0A000010
    IL_0053: call 0x0A000011
    IL_0058: call 0x0A000012
    IL_0059: conv.u8
    IL_005A: IL_3C
    IL_005B: nop
    IL_005C: nop
    IL_005D: IL_01
    IL_0062: stfld 0x04000BB7
    IL_0063: ldloc.0
    IL_0064: stloc.1
    IL_0065: ldloc.1
    IL_0067: ldc.i4.s 10
    IL_0068: IL_59
    IL_006B: ldarg 3
    IL_006C: nop
    IL_006D: nop
    IL_006E: and
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldelem.r4
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_0076: IL_D5
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldloc.1
    IL_007C: ldc.i4.s 50
    IL_007D: IL_59
    IL_0080: ldarg 3
    IL_0081: nop
    IL_0082: nop
    IL_0083: IL_5A
    IL_0084: ldarg.0
    IL_0085: nop
    IL_0086: nop
    IL_0087: IL_AC
    IL_0088: ldarg.0
    IL_0089: nop
    IL_008A: nop
    IL_008B: IL_E2
    IL_008C: ldarg.0
    IL_008D: nop
    IL_008E: nop
    IL_008F: ldloc.1
    IL_0091: ldc.i4.s 20
    IL_0096: beq IL_0185
    IL_0097: ldloc.1
    IL_0099: ldc.i4.s 21
    IL_009E: beq IL_01C2
    IL_009F: ldloc.1
    IL_00A1: ldc.i4.s 30
    IL_00A6: beq IL_01F1
    IL_00A7: ldloc.1
    IL_00A9: ldc.i4.s 31
    IL_00AE: beq IL_022B
    IL_00AF: ldloc.1
    IL_00B1: ldc.i4.s 40
    IL_00B6: beq IL_0261
    IL_00B7: ldloc.1
    IL_00B9: ldc.i4.s 41
    IL_00BE: beq IL_02B3
    IL_00BF: ldloc.1
    IL_00C1: ldc.i4.s 60
    IL_00C6: beq IL_03A7
    IL_00C7: ldloc.1
    IL_00C9: ldc.i4.s 61
    IL_00CE: beq IL_03E4
    IL_00CF: ldloc.1
    IL_00D1: ldc.i4.s 70
    IL_00D6: beq IL_041A
    IL_00DB: br IL_0457
    IL_00DC: ldarg.0
    IL_00E1: ldc.i4 338
    IL_00E6: stfld 0x04000BBC
    IL_00E7: ldarg.0
    IL_00E8: ldc.i4.3
    IL_00ED: stfld 0x04000BBA
    IL_00EE: ldarg.0
    IL_00EF: ldc.i4.0
    IL_00F4: stfld 0x04000BBD
    IL_00F5: ldarg.0
    IL_00F6: IL_22
    IL_00F7: nop
    IL_00F8: nop
    IL_00F9: ret
    IL_00FA: IL_43
    IL_00FB: IL_22
    IL_00FC: nop
    IL_00FD: nop
    IL_00FE: ldloc.0
    IL_00FF: IL_43
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: nop
    IL_0104: IL_43
    IL_0105: IL_22
    IL_0106: nop
    IL_0107: nop
    IL_010C: stsfld 0x021D2842
    IL_010D: nop
    IL_010E: ldloc.0
    IL_0113: stfld 0x04000BBF
    IL_0118: br IL_0457
    IL_0119: ldarg.0
    IL_011E: ldc.i4 339
    IL_0123: stfld 0x04000BBC
    IL_0124: ldarg.0
    IL_0125: ldc.i4.0
    IL_012A: stfld 0x04000BBD
    IL_012B: ldarg.0
    IL_012C: IL_22
    IL_012D: nop
    IL_012E: nop
    IL_012F: ret
    IL_0130: IL_43
    IL_0131: IL_22
    IL_0132: nop
    IL_0133: nop
    IL_0134: ldloc.0
    IL_0135: IL_43
    IL_0136: IL_22
    IL_0137: nop
    IL_0138: nop
    IL_0139: nop
    IL_013A: IL_43
    IL_013B: IL_22
    IL_013C: nop
    IL_013D: nop
    IL_0142: stsfld 0x021D2842
    IL_0143: nop
    IL_0144: ldloc.0
    IL_0149: stfld 0x04000BBF
    IL_014E: br IL_0457
    IL_014F: ldarg.0
    IL_0154: ldc.i4 340
    IL_0159: stfld 0x04000BBC
    IL_015A: ldarg.0
    IL_015B: ldc.i4.0
    IL_0160: stfld 0x04000BBD
    IL_0161: ldarg.0
    IL_0162: IL_22
    IL_0163: nop
    IL_0164: nop
    IL_0165: ret
    IL_0166: IL_43
    IL_0167: IL_22
    IL_0168: nop
    IL_0169: nop
    IL_016A: ldloc.0
    IL_016B: IL_43
    IL_016C: IL_22
    IL_016D: nop
    IL_016E: nop
    IL_016F: nop
    IL_0170: IL_43
    IL_0171: IL_22
    IL_0172: nop
    IL_0173: nop
    IL_0178: stsfld 0x021D2842
    IL_0179: nop
    IL_017A: ldloc.0
    IL_017F: stfld 0x04000BBF
    IL_0184: br IL_0457
    IL_0185: ldarg.0
    IL_018A: ldc.i4 341
    IL_018F: stfld 0x04000BBC
    IL_0190: ldarg.0
    IL_0191: ldc.i4.2
    IL_0196: stfld 0x04000BBA
    IL_0197: ldarg.0
    IL_0198: ldc.i4.0
    IL_019D: stfld 0x04000BBD
    IL_019E: ldarg.0
    IL_019F: IL_22
    IL_01A0: nop
    IL_01A1: nop
    IL_01A2: ret
    IL_01A3: IL_43
    IL_01A4: IL_22
    IL_01A5: nop
    IL_01A6: nop
    IL_01A7: ldloc.0
    IL_01A8: IL_43
    IL_01A9: IL_22
    IL_01AA: nop
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: IL_43
    IL_01AE: IL_22
    IL_01AF: nop
    IL_01B0: nop
    IL_01B5: stsfld 0x021D2842
    IL_01B6: nop
    IL_01B7: ldloc.0
    IL_01BC: stfld 0x04000BBF
    IL_01C1: br IL_0457
    IL_01C2: ldarg.0
    IL_01C7: ldc.i4 342
    IL_01CC: stfld 0x04000BBC
    IL_01CD: ldarg.0
    IL_01CE: IL_22
    IL_01CF: nop
    IL_01D0: nop
    IL_01D1: ldc.i4.0
    IL_01D2: IL_43
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01D6: IL_DC
    IL_01D7: IL_42
    IL_01D8: IL_22
    IL_01D9: nop
    IL_01DA: nop
    IL_01DF: ldc.i4 8770
    IL_01E0: ldelem.r8
    IL_01E1: IL_42
    IL_01E6: call 0x0600021D
    IL_01EB: stfld 0x04000BBF
    IL_01F0: br IL_0457
    IL_01F1: ldarg.0
    IL_01F3: ldc.i4.s 36
    IL_01F8: stfld 0x04000BBC
    IL_01F9: ldarg.0
    IL_01FA: ldc.i4.2
    IL_01FF: stfld 0x04000BBA
    IL_0200: ldarg.0
    IL_0201: ldc.i4.0
    IL_0206: stfld 0x04000BBD
    IL_0207: ldarg.0
    IL_0208: IL_22
    IL_0209: nop
    IL_020A: nop
    IL_020B: ret
    IL_020C: IL_43
    IL_020D: IL_22
    IL_020E: nop
    IL_020F: nop
    IL_0210: ldloc.0
    IL_0211: IL_43
    IL_0212: IL_22
    IL_0213: nop
    IL_0214: nop
    IL_0215: nop
    IL_0216: IL_43
    IL_0217: IL_22
    IL_0218: nop
    IL_0219: nop
    IL_021E: stsfld 0x021D2842
    IL_021F: nop
    IL_0220: ldloc.0
    IL_0225: stfld 0x04000BBF
    IL_022A: br IL_0457
    IL_022B: ldarg.0
    IL_0230: ldc.i4 359
    IL_0235: stfld 0x04000BBC
    IL_0236: ldarg.0
    IL_0237: ldc.i4.0
    IL_023C: stfld 0x04000BBD
    IL_023D: ldarg.0
    IL_023E: IL_22
    IL_023F: nop
    IL_0240: nop
    IL_0241: ret
    IL_0242: IL_43
    IL_0243: IL_22
    IL_0244: nop
    IL_0245: nop
    IL_0246: ldloc.0
    IL_0247: IL_43
    IL_0248: IL_22
    IL_0249: nop
    IL_024A: nop
    IL_024B: nop
    IL_024C: IL_43
    IL_024D: IL_22
    IL_024E: nop
    IL_024F: nop
    IL_0254: stsfld 0x021D2842
    IL_0255: nop
    IL_0256: ldloc.0
    IL_025B: stfld 0x04000BBF
    IL_0260: br IL_0457
    IL_0261: ldarg.0
    IL_0266: ldc.i4 346
    IL_026B: stfld 0x04000BBC
    IL_026C: ldarg.0
    IL_026D: ldc.i4.2
    IL_0272: stfld 0x04000BBA
    IL_0273: ldarg.0
    IL_0274: ldc.i4.1
    IL_0279: stfld 0x04000BBD
    IL_027A: ldarg.0
    IL_027B: IL_22
    IL_027C: nop
    IL_027D: nop
    IL_0282: ldc.i4 8769
    IL_0287: ldc.i4 3699522
    IL_0288: nop
    IL_0289: stloc.0
    IL_028E: stfld 0x04000BBE
    IL_028F: ldarg.0
    IL_0290: IL_22
    IL_0291: nop
    IL_0292: nop
    IL_0293: ret
    IL_0294: IL_43
    IL_0295: IL_22
    IL_0296: nop
    IL_0297: nop
    IL_0298: ldloc.0
    IL_0299: IL_43
    IL_029A: IL_22
    IL_029B: nop
    IL_029C: nop
    IL_029D: nop
    IL_029E: IL_43
    IL_029F: IL_22
    IL_02A0: nop
    IL_02A1: nop
    IL_02A6: stsfld 0x021D2842
    IL_02A7: nop
    IL_02A8: ldloc.0
    IL_02AD: stfld 0x04000BBF
    IL_02B2: br IL_0457
    IL_02B3: ldarg.0
    IL_02B8: ldc.i4 347
    IL_02BD: stfld 0x04000BBC
    IL_02BE: ldarg.0
    IL_02BF: ldc.i4.0
    IL_02C4: stfld 0x04000BBD
    IL_02C5: ldarg.0
    IL_02C6: IL_22
    IL_02C7: nop
    IL_02C8: nop
    IL_02C9: ret
    IL_02CA: IL_43
    IL_02CB: IL_22
    IL_02CC: nop
    IL_02CD: nop
    IL_02CE: ldloc.0
    IL_02CF: IL_43
    IL_02D0: IL_22
    IL_02D1: nop
    IL_02D2: nop
    IL_02D3: nop
    IL_02D4: IL_43
    IL_02D5: IL_22
    IL_02D6: nop
    IL_02D7: nop
    IL_02DC: stsfld 0x021D2842
    IL_02DD: nop
    IL_02DE: ldloc.0
    IL_02E3: stfld 0x04000BBF
    IL_02E8: br IL_0457
    IL_02E9: ldarg.0
    IL_02EE: ldc.i4 343
    IL_02F3: stfld 0x04000BBC
    IL_02F4: ldarg.0
    IL_02F5: ldc.i4.3
    IL_02FA: stfld 0x04000BBA
    IL_02FB: ldarg.0
    IL_02FC: ldc.i4.0
    IL_0301: stfld 0x04000BBD
    IL_0302: ldarg.0
    IL_0303: IL_22
    IL_0304: nop
    IL_0305: nop
    IL_030A: ldc.i4 8769
    IL_030F: ldc.i4 3699522
    IL_0310: nop
    IL_0311: stloc.0
    IL_0316: stfld 0x04000BBE
    IL_0317: ldarg.0
    IL_0318: IL_22
    IL_0319: nop
    IL_031A: nop
    IL_031B: ret
    IL_031C: IL_43
    IL_031D: IL_22
    IL_031E: nop
    IL_031F: nop
    IL_0320: ldloc.0
    IL_0321: IL_43
    IL_0322: IL_22
    IL_0323: nop
    IL_0324: nop
    IL_0325: nop
    IL_0326: IL_43
    IL_0327: IL_22
    IL_0328: nop
    IL_0329: nop
    IL_032E: stsfld 0x021D2842
    IL_032F: nop
    IL_0330: ldloc.0
    IL_0335: stfld 0x04000BBF
    IL_033A: br IL_0457
    IL_033B: ldarg.0
    IL_0340: ldc.i4 344
    IL_0345: stfld 0x04000BBC
    IL_0346: ldarg.0
    IL_0347: ldc.i4.0
    IL_034C: stfld 0x04000BBD
    IL_034D: ldarg.0
    IL_034E: IL_22
    IL_034F: nop
    IL_0350: nop
    IL_0351: ret
    IL_0352: IL_43
    IL_0353: IL_22
    IL_0354: nop
    IL_0355: nop
    IL_0356: ldloc.0
    IL_0357: IL_43
    IL_0358: IL_22
    IL_0359: nop
    IL_035A: nop
    IL_035B: nop
    IL_035C: IL_43
    IL_035D: IL_22
    IL_035E: nop
    IL_035F: nop
    IL_0364: stsfld 0x021D2842
    IL_0365: nop
    IL_0366: ldloc.0
    IL_036B: stfld 0x04000BBF
    IL_0370: br IL_0457
    IL_0371: ldarg.0
    IL_0376: ldc.i4 345
    IL_037B: stfld 0x04000BBC
    IL_037C: ldarg.0
    IL_037D: ldc.i4.0
    IL_0382: stfld 0x04000BBD
    IL_0383: ldarg.0
    IL_0384: IL_22
    IL_0385: nop
    IL_0386: nop
    IL_0387: ret
    IL_0388: IL_43
    IL_0389: IL_22
    IL_038A: nop
    IL_038B: nop
    IL_038C: ldloc.0
    IL_038D: IL_43
    IL_038E: IL_22
    IL_038F: nop
    IL_0390: nop
    IL_0391: nop
    IL_0392: IL_43
    IL_0393: IL_22
    IL_0394: nop
    IL_0395: nop
    IL_039A: stsfld 0x021D2842
    IL_039B: nop
    IL_039C: ldloc.0
    IL_03A1: stfld 0x04000BBF
    IL_03A6: br IL_0457
    IL_03A7: ldarg.0
    IL_03AC: ldc.i4 348
    IL_03B1: stfld 0x04000BBC
    IL_03B2: ldarg.0
    IL_03B3: ldc.i4.2
    IL_03B8: stfld 0x04000BBA
    IL_03B9: ldarg.0
    IL_03BA: ldc.i4.0
    IL_03BF: stfld 0x04000BBD
    IL_03C0: ldarg.0
    IL_03C1: IL_22
    IL_03C2: nop
    IL_03C3: nop
    IL_03C4: ret
    IL_03C5: IL_43
    IL_03C6: IL_22
    IL_03C7: nop
    IL_03C8: nop
    IL_03C9: ldloc.0
    IL_03CA: IL_43
    IL_03CB: IL_22
    IL_03CC: nop
    IL_03CD: nop
    IL_03CE: nop
    IL_03CF: IL_43
    IL_03D0: IL_22
    IL_03D1: nop
    IL_03D2: nop
    IL_03D7: stsfld 0x021D2842
    IL_03D8: nop
    IL_03D9: ldloc.0
    IL_03DE: stfld 0x04000BBF
    IL_03E3: br IL_0457
    IL_03E4: ldarg.0
    IL_03E9: ldc.i4 349
    IL_03EE: stfld 0x04000BBC
    IL_03EF: ldarg.0
    IL_03F0: ldc.i4.0
    IL_03F5: stfld 0x04000BBD
    IL_03F6: ldarg.0
    IL_03F7: IL_22
    IL_03F8: nop
    IL_03F9: nop
    IL_03FA: ret
    IL_03FB: IL_43
    IL_03FC: IL_22
    IL_03FD: nop
    IL_03FE: nop
    IL_03FF: ldloc.0
    IL_0400: IL_43
    IL_0401: IL_22
    IL_0402: nop
    IL_0403: nop
    IL_0404: nop
    IL_0405: IL_43
    IL_0406: IL_22
    IL_0407: nop
    IL_0408: nop
    IL_040D: stsfld 0x021D2842
    IL_040E: nop
    IL_040F: ldloc.0
    IL_0414: stfld 0x04000BBF
    IL_0419: br IL_0457
    IL_041A: ldarg.0
    IL_041F: ldc.i4 433
    IL_0424: stfld 0x04000BBC
    IL_0425: ldarg.0
    IL_0426: ldc.i4.1
    IL_042B: stfld 0x04000BBA
    IL_042C: ldarg.0
    IL_042D: ldc.i4.0
    IL_0432: stfld 0x04000BBD
    IL_0433: ldarg.0
    IL_0434: IL_22
    IL_0435: nop
    IL_0436: nop
    IL_0437: ret
    IL_0438: IL_43
    IL_0439: IL_22
    IL_043A: nop
    IL_043B: nop
    IL_043C: ldloc.0
    IL_043D: IL_43
    IL_043E: IL_22
    IL_043F: nop
    IL_0440: nop
    IL_0441: nop
    IL_0442: IL_43
    IL_0443: IL_22
    IL_0444: nop
    IL_0445: nop
    IL_044A: stsfld 0x021D2842
    IL_044B: nop
    IL_044C: ldloc.0
    IL_0451: stfld 0x04000BBF
    IL_0456: br IL_0457
    IL_0457: ret
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
    IL_003B: ldfld 0x04000BDB
    IL_0040: call 0x0A0000DF
    IL_0041: ldc.i4.0
    IL_0046: call 0x0A0000EF
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000BD8
    IL_0051: brfalse IL_050B
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000BC5
    IL_005C: brfalse IL_0088
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000BD4
    IL_0064: ldc.i4.s 15
    IL_0065: IL_3E
    IL_0066: ldc.i4.8
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: ldarg.0
    IL_006B: ldc.i4.0
    IL_0070: stfld 0x04000BD8
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0078: stsfld 0x0111283F
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldarg.0
    IL_0080: ldfld 0x04000BDA
    IL_0081: ldc.i4.m1
    IL_0082: conv.r8
    IL_0084: starg.s 6
    IL_0085: nop
    IL_0086: ldloc.0
    IL_0087: ret
    IL_0088: ldarg.0
    IL_0089: dup
    IL_008E: ldfld 0x04000BC9
    IL_0093: call 0x0A000024
    IL_0094: IL_58
    IL_0099: stfld 0x04000BC9
    IL_009A: ldarg.0
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000BC9
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: IL_22
    IL_00A7: nop
    IL_00A8: nop
    IL_00AD: stsfld 0x00D4283F
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B4: stfld 0x04000BC9
    IL_00B9: call 0x0A0000F4
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000BC9
    IL_00C4: call 0x0A000307
    IL_00C9: call 0x0A0000F0
    IL_00CA: IL_22
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: IL_22
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: IL_F0
    IL_00D8: IL_43
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: ldelem.r8
    IL_00DD: IL_43
    IL_00E2: call 0x0600021D
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000BB1
    IL_00ED: call 0x0A0000E0
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x04000BD3
    IL_00F5: ldc.i4.s 9
    IL_00F6: IL_3D
    IL_00F7: stloc.1
    IL_00F8: ldarg.2
    IL_00F9: nop
    IL_00FA: nop
    IL_00FF: call 0x0A00017C
    IL_0104: call 0x0A0000F0
    IL_0105: IL_22
    IL_0106: nop
    IL_0107: nop
    IL_0108: nop
    IL_0109: nop
    IL_010A: IL_22
    IL_010B: nop
    IL_010C: nop
    IL_010D: ldarg.0
    IL_010E: IL_43
    IL_010F: IL_22
    IL_0110: nop
    IL_0111: nop
    IL_0112: IL_F0
    IL_0113: IL_43
    IL_0114: IL_22
    IL_0115: nop
    IL_0116: nop
    IL_011B: stsfld 0x021D2841
    IL_011C: nop
    IL_011D: ldloc.0
    IL_0122: ldsfld 0x040007B2
    IL_0123: ldarg.0
    IL_0128: ldfld 0x04000BD9
    IL_012D: ldc.i4 203
    IL_0132: call 0x0A0000E1
    IL_0137: ldstr 0x70023775
    IL_0138: ldarg.0
    IL_013D: ldfld 0x04000BD3
    IL_0142: newobj 0x0100000B
    IL_0147: call 0x0A000098
    IL_014C: ldstr 0x70002225
    IL_0151: call 0x0A0000E2
    IL_0156: call 0x0A0000E3
    IL_0157: IL_22
    IL_0158: nop
    IL_0159: nop
    IL_015A: conv.r.un
    IL_015B: IL_43
    IL_015C: IL_22
    IL_015D: nop
    IL_015E: nop
    IL_015F: ldc.i4.0
    IL_0160: IL_43
    IL_0161: IL_22
    IL_0162: nop
    IL_0163: nop
    IL_0164: nop
    IL_0165: IL_42
    IL_0166: IL_22
    IL_0167: nop
    IL_0168: nop
    IL_016D: stsfld 0x021D2841
    IL_016E: nop
    IL_016F: ldloc.0
    IL_0174: ldsfld 0x0A000099
    IL_0175: ldarg.0
    IL_017A: ldfld 0x04000BD4
    IL_017F: newobj 0x0100000B
    IL_0184: call 0x0A00009A
    IL_0189: ldstr 0x70002225
    IL_018E: call 0x0A0000E2
    IL_0193: call 0x0A0000E3
    IL_0194: IL_22
    IL_0195: nop
    IL_0196: nop
    IL_0197: shr
    IL_0198: IL_43
    IL_0199: IL_22
    IL_019A: nop
    IL_019B: nop
    IL_019C: ldc.i4.0
    IL_019D: IL_43
    IL_019E: IL_22
    IL_019F: nop
    IL_01A0: nop
    IL_01A5: stsfld 0x00002241
    IL_01AA: stsfld 0x021D2841
    IL_01AB: nop
    IL_01AC: ldloc.0
    IL_01AD: ldarg.0
    IL_01B2: ldfld 0x04000BB4
    IL_01B7: call 0x0A0000E0
    IL_01B8: ldarg.0
    IL_01BD: ldfld 0x04000BD5
    IL_01BE: ldarg.0
    IL_01C3: ldfld 0x04000BD4
    IL_01C4: IL_3F
    IL_01C5: IL_E4
    IL_01C6: IL_01
    IL_01C7: nop
    IL_01C8: nop
    IL_01C9: IL_22
    IL_01CA: nop
    IL_01CB: nop
    IL_01CC: IL_E0
    IL_01CD: IL_42
    IL_01CE: IL_22
    IL_01CF: nop
    IL_01D0: nop
    IL_01D1: ret
    IL_01D2: IL_43
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01DA: stsfld 0x00002243
    IL_01DF: stsfld 0x021D2841
    IL_01E0: nop
    IL_01E1: ldloc.0
    IL_01E2: ldc.i4.5
    IL_01E7: newarr 0x01000020
    IL_01E8: dup
    IL_01E9: ldc.i4.0
    IL_01EE: ldstr 0x70023781
    IL_01F3: stelem 0xB27E1725
    IL_01F4: ldloc.1
    IL_01F5: nop
    IL_01F6: ldarg.2
    IL_01F7: ldarg.0
    IL_01FC: ldfld 0x04000BD9
    IL_0201: ldc.i4 204
    IL_0206: call 0x0A0000E1
    IL_020B: stelem 0x80721825
    IL_020C: ret
    IL_020D: ldarg.0
    IL_0212: cpobj 0x021925A2
    IL_0217: ldfld 0x04000BD5
    IL_021C: newobj 0x0100000B
    IL_0221: stelem 0x85721A25
    IL_0222: IL_37
    IL_0223: ldarg.0
    IL_0228: cpobj 0x009628A2
    IL_0229: nop
    IL_022A: stloc.0
    IL_022F: ldstr 0x70000BC5
    IL_0234: call 0x0A0000E2
    IL_0239: call 0x0A0000E3
    IL_023A: IL_22
    IL_023B: nop
    IL_023C: nop
    IL_023D: ret
    IL_023E: IL_43
    IL_023F: IL_22
    IL_0240: nop
    IL_0241: nop
    IL_0242: IL_3E
    IL_0243: IL_43
    IL_0244: IL_22
    IL_0245: nop
    IL_0246: nop
    IL_024B: stsfld 0x00002242
    IL_024C: nop
    IL_024D: IL_42
    IL_0252: call 0x0600021D
    IL_0257: ldsfld 0x040007B2
    IL_0258: ldarg.0
    IL_025D: ldfld 0x04000BD9
    IL_025E: ldc.i4.1
    IL_0263: call 0x0A0000E1
    IL_0264: ldarg.0
    IL_0269: ldfld 0x04000BC4
    IL_026E: call 0x0A0000F1
    IL_0273: brfalse IL_03A8
    IL_0274: ldarg.0
    IL_0279: ldfld 0x04000BD4
    IL_027A: shl
    IL_027B: ldc.i4.1
    IL_0280: call 0x0600021E
    IL_0285: brfalse IL_03A3
    IL_0286: ldarg.0
    IL_0287: ldc.i4.0
    IL_028C: stfld 0x04000BD8
    IL_028D: ldarg.0
    IL_028E: IL_22
    IL_028F: nop
    IL_0290: nop
    IL_0291: nop
    IL_0292: nop
    IL_0297: stfld 0x04000BC9
    IL_0298: ldarg.0
    IL_029A: ldc.i4.s 10
    IL_029F: stfld 0x04000BD3
    IL_02A0: IL_22
    IL_02A1: nop
    IL_02A2: nop
    IL_02A7: stsfld 0x0111283F
    IL_02A8: nop
    IL_02A9: stloc.0
    IL_02AA: ldarg.0
    IL_02AF: ldfld 0x04000BCE
    IL_02B0: conv.r8
    IL_02B1: conv.u8
    IL_02B2: IL_01
    IL_02B3: nop
    IL_02B4: ldloc.0
    IL_02B5: ldarg.0
    IL_02BA: ldfld 0x04000BDA
    IL_02BB: conv.r8
    IL_02BC: IL_27
    IL_02BD: ldloc.0
    IL_02BE: nop
    IL_02BF: ldloc.0
    IL_02C0: ldarg.0
    IL_02C5: call 0x0A00000A
    IL_02C6: ldc.i4.0
    IL_02C7: conv.r8
    IL_02C8: stloc.1
    IL_02C9: nop
    IL_02CA: nop
    IL_02CB: stloc.0
    IL_02CC: ldarg.0
    IL_02CD: ldc.i4.0
    IL_02D2: stfld 0x04000BD2
    IL_02D3: ldarg.0
    IL_02D8: call 0x0A000081
    IL_02D9: ldarg.0
    IL_02DE: ldfld 0x04000BD4
    IL_02DF: stloc.0
    IL_02E0: ldc.i4.5
    IL_02E5: newarr 0x0100000C
    IL_02E6: dup
    IL_02E7: ldc.i4.0
    IL_02EC: ldsfld 0x040007B2
    IL_02ED: ldarg.0
    IL_02F2: ldfld 0x04000BD9
    IL_02F7: ldc.i4 234
    IL_02FC: call 0x0A0000E1
    IL_0301: stelem 0x89721725
    IL_0302: IL_37
    IL_0303: ldarg.0
    IL_0308: cpobj 0x021825A2
    IL_030D: ldflda 0x04000BD4
    IL_0312: call 0x0A000010
    IL_0317: stelem 0x8F721925
    IL_0318: IL_37
    IL_0319: ldarg.0
    IL_031E: cpobj 0x7E1A25A2
    IL_031F: IL_B2
    IL_0320: ldloc.1
    IL_0321: nop
    IL_0322: ldarg.2
    IL_0323: ldarg.0
    IL_0328: ldfld 0x04000BD9
    IL_032D: ldc.i4 239
    IL_0332: call 0x0A0000E1
    IL_0337: stelem 0x00024028
    IL_0338: stloc.0
    IL_033D: call 0x0600040D
    IL_033E: ldarg.0
    IL_033F: dup
    IL_0344: ldfld 0x04000BD5
    IL_0345: ldarg.0
    IL_034A: ldfld 0x04000BD4
    IL_034B: IL_59
    IL_0350: stfld 0x04000BD5
    IL_0351: ldarg.0
    IL_0356: ldfld 0x04000BC5
    IL_035B: brfalse IL_036F
    IL_035C: ldarg.0
    IL_035D: ldarg.0
    IL_0362: ldfld 0x04000BD4
    IL_0363: ldc.i4.3
    IL_0364: IL_58
    IL_0369: stfld 0x04000BD4
    IL_036E: br IL_037D
    IL_036F: ldarg.0
    IL_0370: ldarg.0
    IL_0375: ldfld 0x04000BD4
    IL_0376: ldc.i4.2
    IL_0377: IL_5A
    IL_037C: stfld 0x04000BD4
    IL_0381: ldstr 0x700004E5
    IL_0382: ldloc.0
    IL_0387: newobj 0x0100000B
    IL_038C: ldstr 0x70023795
    IL_0391: call 0x0A000098
    IL_0392: stloc.1
    IL_0397: call 0x0600004E
    IL_039C: ldstr 0x700237B3
    IL_039D: ldloc.1
    IL_039E: conv.r8
    IL_039F: IL_59
    IL_03A0: nop
    IL_03A1: nop
    IL_03A2: ldloc.0
    IL_03A7: call 0x0A000303
    IL_03AC: br IL_04AF
    IL_03AD: IL_22
    IL_03AE: nop
    IL_03AF: nop
    IL_03B0: IL_E0
    IL_03B1: IL_42
    IL_03B2: IL_22
    IL_03B3: nop
    IL_03B4: nop
    IL_03B5: ret
    IL_03B6: IL_43
    IL_03B7: IL_22
    IL_03B8: nop
    IL_03B9: nop
    IL_03BE: stsfld 0x00002243
    IL_03C3: stsfld 0x021D2841
    IL_03C4: nop
    IL_03C5: ldloc.0
    IL_03C6: ldc.i4.5
    IL_03CB: newarr 0x01000020
    IL_03CC: dup
    IL_03CD: ldc.i4.0
    IL_03D2: ldstr 0x70023781
    IL_03D7: stelem 0xB27E1725
    IL_03D8: ldloc.1
    IL_03D9: nop
    IL_03DA: ldarg.2
    IL_03DB: ldarg.0
    IL_03E0: ldfld 0x04000BD9
    IL_03E5: ldc.i4 204
    IL_03EA: call 0x0A0000E1
    IL_03EF: stelem 0x80721825
    IL_03F0: ret
    IL_03F1: ldarg.0
    IL_03F6: cpobj 0x021925A2
    IL_03FB: ldfld 0x04000BD5
    IL_0400: newobj 0x0100000B
    IL_0405: stelem 0x85721A25
    IL_0406: IL_37
    IL_0407: ldarg.0
    IL_040C: cpobj 0x009628A2
    IL_040D: nop
    IL_040E: stloc.0
    IL_0413: ldstr 0x70023389
    IL_0418: call 0x0A0000E2
    IL_041D: call 0x0A0000E3
    IL_041E: IL_22
    IL_041F: nop
    IL_0420: nop
    IL_0421: ret
    IL_0422: IL_43
    IL_0423: IL_22
    IL_0424: nop
    IL_0425: nop
    IL_0426: IL_3E
    IL_0427: IL_43
    IL_0428: IL_22
    IL_0429: nop
    IL_042A: nop
    IL_042F: stsfld 0x00002242
    IL_0430: nop
    IL_0431: IL_42
    IL_0436: call 0x0600021D
    IL_043B: ldsfld 0x040007B2
    IL_043C: ldarg.0
    IL_0441: ldfld 0x04000BD9
    IL_0446: ldc.i4 207
    IL_044B: call 0x0A0000E1
    IL_044C: ldarg.0
    IL_0451: ldfld 0x04000BC4
    IL_0456: call 0x0A0000F1
    IL_045B: brfalse IL_04AF
    IL_0460: ldstr 0x70001E8B
    IL_0461: ldc.i4.1
    IL_0466: call 0x0600021F
    IL_0467: ldarg.0
    IL_046C: ldfld 0x04000BD1
    IL_046D: ldnull
    IL_0472: call 0x0A000061
    IL_0477: brfalse IL_048D
    IL_0478: ldarg.0
    IL_047D: ldstr 0x700232DD
    IL_0482: call 0x0A000012
    IL_0483: conv.u8
    IL_0484: ldloc.0
    IL_0485: nop
    IL_0486: nop
    IL_0487: IL_01
    IL_048C: stfld 0x04000BD1
    IL_048D: ldarg.0
    IL_0492: ldfld 0x04000BD1
    IL_0493: conv.r8
    IL_0494: ldarg.3
    IL_0495: nop
    IL_0496: nop
    IL_0497: stloc.0
    IL_049C: call 0x0A00001B
    IL_04A1: call 0x0A000013
    IL_04A6: call 0x0A000014
    IL_04A7: pop
    IL_04A8: ldarg.0
    IL_04A9: ldc.i4.1
    IL_04AE: stfld 0x04000BD2
    IL_04AF: IL_22
    IL_04B0: nop
    IL_04B1: nop
    IL_04B2: conv.r.un
    IL_04B3: IL_43
    IL_04B4: IL_22
    IL_04B5: nop
    IL_04B6: nop
    IL_04B7: IL_3E
    IL_04B8: IL_43
    IL_04B9: IL_22
    IL_04BA: nop
    IL_04BB: nop
    IL_04C0: stsfld 0x00002242
    IL_04C1: nop
    IL_04C2: IL_42
    IL_04C7: call 0x0600021D
    IL_04CC: ldsfld 0x040007B2
    IL_04CD: ldarg.0
    IL_04D2: ldfld 0x04000BD9
    IL_04D3: ldc.i4.2
    IL_04D8: call 0x0A0000E1
    IL_04D9: ldarg.0
    IL_04DE: ldfld 0x04000BC4
    IL_04E3: call 0x0A0000F1
    IL_04E8: brfalse IL_0506
    IL_04E9: ldarg.0
    IL_04EA: ldc.i4.0
    IL_04EF: stfld 0x04000BD8
    IL_04F0: IL_22
    IL_04F1: nop
    IL_04F2: nop
    IL_04F7: stsfld 0x0111283F
    IL_04F8: nop
    IL_04F9: stloc.0
    IL_04FA: ldarg.0
    IL_04FF: ldfld 0x04000BDA
    IL_0500: ldc.i4.m1
    IL_0501: conv.r8
    IL_0503: starg.s 6
    IL_0504: nop
    IL_0505: ldloc.0
    IL_050A: br IL_0BB0
    IL_050B: ldarg.0
    IL_0510: ldfld 0x04000BCC
    IL_0515: brfalse IL_0581
    IL_0516: IL_22
    IL_0517: nop
    IL_0518: nop
    IL_0519: IL_E0
    IL_051A: IL_42
    IL_051B: IL_22
    IL_051C: nop
    IL_051D: nop
    IL_051E: IL_B4
    IL_051F: IL_42
    IL_0520: IL_22
    IL_0521: nop
    IL_0522: nop
    IL_0527: stsfld 0x00002243
    IL_0528: rem
    IL_0529: IL_41
    IL_052E: call 0x0600021D
    IL_0533: ldsfld 0x040007B2
    IL_0534: ldarg.0
    IL_0539: ldfld 0x04000BD9
    IL_053E: ldc.i4 434
    IL_0543: call 0x0A0000E1
    IL_0548: call 0x0A0002EA
    IL_0549: IL_22
    IL_054A: nop
    IL_054B: nop
    IL_054C: IL_E0
    IL_054D: IL_42
    IL_054E: IL_22
    IL_054F: nop
    IL_0550: nop
    IL_0552: bgt.s IL_0596
    IL_0553: IL_22
    IL_0554: nop
    IL_0555: nop
    IL_055A: stsfld 0x00002243
    IL_055C: starg.s 66
    IL_0561: call 0x0600021D
    IL_0566: ldsfld 0x040007B2
    IL_0567: ldarg.0
    IL_056C: ldfld 0x04000BD9
    IL_0571: ldc.i4 435
    IL_0576: call 0x0A0000E1
    IL_057B: call 0x0A0002EA
    IL_0580: br IL_0BB0
    IL_0581: ldarg.0
    IL_0586: ldfld 0x04000BD7
    IL_058B: brfalse IL_0A75
    IL_058C: ldarg.0
    IL_0591: ldfld 0x04000BCA
    IL_0596: brfalse IL_05E3
    IL_0597: ldarg.0
    IL_059C: call 0x0A0000D7
    IL_059D: stloc.3
    IL_059F: ldloca.s 3
    IL_05A4: ldfld 0x0A00005E
    IL_05A5: IL_22
    IL_05A6: nop
    IL_05A7: nop
    IL_05A8: IL_F0
    IL_05A9: IL_43
    IL_05AE: call 0x0A0000D9
    IL_05AF: conv.i2
    IL_05B0: add
    IL_05B1: IL_5A
    IL_05B2: IL_22
    IL_05B3: nop
    IL_05B4: nop
    IL_05B5: IL_56
    IL_05B6: IL_43
    IL_05B7: IL_59
    IL_05B8: IL_22
    IL_05B9: nop
    IL_05BA: nop
    IL_05BB: IL_FC
    IL_05BC: IL_42
    IL_05BD: add
    IL_05C2: stfld 0x04000BC7
    IL_05C3: ldarg.0
    IL_05C4: ldarg.0
    IL_05C9: ldfld 0x04000BC7
    IL_05CA: IL_22
    IL_05CB: nop
    IL_05CC: nop
    IL_05CD: nop
    IL_05CE: nop
    IL_05CF: IL_22
    IL_05D0: nop
    IL_05D1: nop
    IL_05D6: stsfld 0x00D4283F
    IL_05D7: nop
    IL_05D8: stloc.0
    IL_05DD: stfld 0x04000BC7
    IL_05E2: br IL_0636
    IL_05E3: ldarg.0
    IL_05E8: ldfld 0x04000BCB
    IL_05ED: brfalse IL_0636
    IL_05EE: ldarg.0
    IL_05F3: call 0x0A0000D7
    IL_05F5: stloc.s 4
    IL_05F7: ldloca.s 4
    IL_05FC: ldfld 0x0A00005E
    IL_05FD: IL_22
    IL_05FE: nop
    IL_05FF: nop
    IL_0600: IL_F0
    IL_0601: IL_43
    IL_0606: call 0x0A0000D9
    IL_0607: conv.i2
    IL_0608: add
    IL_0609: IL_5A
    IL_060A: IL_22
    IL_060B: nop
    IL_060C: nop
    IL_060D: IL_56
    IL_060E: IL_43
    IL_060F: IL_59
    IL_0610: IL_22
    IL_0611: nop
    IL_0612: nop
    IL_0613: IL_FC
    IL_0614: IL_42
    IL_0615: add
    IL_061A: stfld 0x04000BC8
    IL_061B: ldarg.0
    IL_061C: ldarg.0
    IL_0621: ldfld 0x04000BC8
    IL_0622: IL_22
    IL_0623: nop
    IL_0624: nop
    IL_0625: nop
    IL_0626: nop
    IL_0627: IL_22
    IL_0628: nop
    IL_0629: nop
    IL_062E: stsfld 0x00D4283F
    IL_062F: nop
    IL_0630: stloc.0
    IL_0635: stfld 0x04000BC8
    IL_0636: IL_22
    IL_0637: nop
    IL_0638: nop
    IL_0639: nop
    IL_063A: nop
    IL_063B: IL_22
    IL_063C: nop
    IL_063D: nop
    IL_063E: nop
    IL_063F: nop
    IL_0640: IL_22
    IL_0641: nop
    IL_0642: nop
    IL_0643: IL_F0
    IL_0644: IL_43
    IL_0645: IL_22
    IL_0646: nop
    IL_0647: nop
    IL_0648: ldelem.r8
    IL_0649: IL_43
    IL_064E: call 0x0600021D
    IL_064F: ldarg.0
    IL_0654: ldfld 0x04000BB1
    IL_0659: call 0x0A0000E0
    IL_065A: IL_22
    IL_065B: nop
    IL_065C: nop
    IL_065D: IL_E0
    IL_065E: IL_42
    IL_065F: IL_22
    IL_0660: nop
    IL_0661: nop
    IL_0666: cpobj 0x00002242
    IL_066B: stsfld 0x00002243
    IL_0670: stsfld 0x021D2843
    IL_0671: nop
    IL_0672: ldloc.0
    IL_0673: ldarg.0
    IL_0678: ldfld 0x04000BB2
    IL_067D: call 0x0A0000E0
    IL_067E: IL_22
    IL_067F: nop
    IL_0680: nop
    IL_0681: nop
    IL_0682: IL_43
    IL_0683: IL_22
    IL_0684: nop
    IL_0685: nop
    IL_068A: isinst 0x00002242
    IL_068F: newobj 0x00002242
    IL_0694: stsfld 0x021D2841
    IL_0695: nop
    IL_0696: ldloc.0
    IL_069B: ldsfld 0x040007B2
    IL_069C: ldarg.0
    IL_06A1: ldfld 0x04000BD9
    IL_06A6: ldc.i4 302
    IL_06AB: call 0x0A0000E1
    IL_06B0: ldstr 0x70000BC5
    IL_06B5: call 0x0A0000E2
    IL_06BA: call 0x0A0000E3
    IL_06BB: IL_22
    IL_06BC: nop
    IL_06BD: nop
    IL_06BE: nop
    IL_06BF: IL_43
    IL_06C0: IL_22
    IL_06C1: nop
    IL_06C2: nop
    IL_06C3: IL_EC
    IL_06C4: IL_42
    IL_06C5: IL_22
    IL_06C6: nop
    IL_06C7: nop
    IL_06CC: newobj 0x00002242
    IL_06D1: stsfld 0x021D2841
    IL_06D2: nop
    IL_06D3: ldloc.0
    IL_06D8: ldsfld 0x040007B2
    IL_06D9: ldarg.0
    IL_06DE: ldfld 0x04000BD9
    IL_06E3: ldc.i4 244
    IL_06E8: call 0x0A0000E1
    IL_06ED: ldstr 0x70000BC5
    IL_06F2: call 0x0A0000E2
    IL_06F7: call 0x0A0000E3
    IL_06F8: IL_22
    IL_06F9: nop
    IL_06FA: nop
    IL_06FB: nop
    IL_06FC: IL_43
    IL_06FD: IL_22
    IL_06FE: nop
    IL_06FF: nop
    IL_0700: ldc.i4.5
    IL_0701: IL_43
    IL_0702: IL_22
    IL_0703: nop
    IL_0704: nop
    IL_0709: newobj 0x00002242
    IL_070E: stsfld 0x021D2841
    IL_070F: nop
    IL_0710: ldloc.0
    IL_0715: ldsfld 0x040007B2
    IL_0716: ldarg.0
    IL_071B: ldfld 0x04000BD9
    IL_071D: ldc.i4.s 90
    IL_0722: call 0x0A0000E1
    IL_0727: ldstr 0x70000BC5
    IL_072C: call 0x0A0000E2
    IL_0731: call 0x0A0000E3
    IL_0732: IL_22
    IL_0733: nop
    IL_0734: nop
    IL_0735: nop
    IL_0736: IL_43
    IL_0737: IL_22
    IL_0738: nop
    IL_0739: nop
    IL_073A: IL_42
    IL_073B: IL_43
    IL_073C: IL_22
    IL_073D: nop
    IL_073E: nop
    IL_0743: newobj 0x00002242
    IL_0748: stsfld 0x021D2841
    IL_0749: nop
    IL_074A: ldloc.0
    IL_074F: ldsfld 0x040007B2
    IL_0750: ldarg.0
    IL_0755: ldfld 0x04000BD9
    IL_075A: ldc.i4 245
    IL_075F: call 0x0A0000E1
    IL_0764: ldstr 0x70000BC5
    IL_0769: call 0x0A0000E2
    IL_076E: call 0x0A0000E3
    IL_076F: IL_22
    IL_0770: nop
    IL_0771: nop
    IL_0772: IL_54
    IL_0773: IL_43
    IL_0774: IL_22
    IL_0775: nop
    IL_0776: nop
    IL_077B: brtrue IL_29BF
    IL_077C: nop
    IL_077D: IL_43
    IL_077E: IL_22
    IL_077F: nop
    IL_0780: nop
    IL_0781: nop
    IL_0782: IL_42
    IL_0787: call 0x0600021D
    IL_078C: ldsfld 0x040007B2
    IL_078D: ldarg.0
    IL_0792: ldfld 0x04000BD9
    IL_0797: ldc.i4 246
    IL_079C: call 0x0A0000E1
    IL_079D: ldarg.0
    IL_07A2: ldfld 0x04000BC2
    IL_07A7: call 0x0A0000F1
    IL_07AC: brfalse IL_07CF
    IL_07AD: ldc.i4.2
    IL_07AE: stloc.2
    IL_07AF: ldarg.0
    IL_07B0: ldarg.0
    IL_07B5: ldfld 0x04000BD9
    IL_07B6: ldc.i4.1
    IL_07B7: IL_58
    IL_07B8: ldloc.2
    IL_07B9: mul
    IL_07BE: stfld 0x04000BD9
    IL_07C3: ldstr 0x70000BB3
    IL_07C4: ldarg.0
    IL_07C9: ldfld 0x04000BD9
    IL_07CE: call 0x0A00009F
    IL_07CF: IL_22
    IL_07D0: nop
    IL_07D1: nop
    IL_07D4: ldloc 8771
    IL_07D5: nop
    IL_07D6: nop
    IL_07D7: IL_98
    IL_07D8: IL_42
    IL_07D9: IL_22
    IL_07DA: nop
    IL_07DB: nop
    IL_07DC: ldc.i4.2
    IL_07DD: IL_43
    IL_07DE: IL_22
    IL_07DF: nop
    IL_07E0: nop
    IL_07E1: nop
    IL_07E2: IL_42
    IL_07E7: call 0x0600021D
    IL_07EC: ldsfld 0x0A000099
    IL_07ED: ldarg.0
    IL_07F2: ldfld 0x04000BC3
    IL_07F7: call 0x0A0002E8
    IL_07FC: brfalse IL_0809
    IL_07FD: ldarg.0
    IL_07FE: ldc.i4.1
    IL_0803: stfld 0x04000BCB
    IL_0808: br IL_0826
    IL_0809: ldarg.0
    IL_080E: ldfld 0x04000BCB
    IL_0813: brfalse IL_0826
    IL_0814: ldarg.0
    IL_0819: ldfld 0x04000BC8
    IL_081E: call 0x0A0001C2
    IL_081F: ldarg.0
    IL_0820: ldc.i4.0
    IL_0825: stfld 0x04000BCB
    IL_0826: ldarg.0
    IL_082B: ldfld 0x04000BC8
    IL_082C: IL_22
    IL_082D: nop
    IL_082E: nop
    IL_082F: IL_FC
    IL_0830: IL_42
    IL_0831: IL_5A
    IL_0832: IL_22
    IL_0833: nop
    IL_0834: nop
    IL_0835: IL_4E
    IL_0836: IL_43
    IL_0837: IL_58
    IL_0838: IL_22
    IL_0839: nop
    IL_083A: nop
    IL_083B: IL_A8
    IL_083C: IL_42
    IL_083D: IL_22
    IL_083E: nop
    IL_083F: nop
    IL_0844: stsfld 0x00002241
    IL_0849: stsfld 0x021D2841
    IL_084A: nop
    IL_084B: ldloc.0
    IL_084C: ldarg.0
    IL_0851: ldfld 0x04000BB3
    IL_0856: call 0x0A0000E0
    IL_0857: IL_22
    IL_0858: nop
    IL_0859: nop
    IL_085C: ldloc 8771
    IL_085D: nop
    IL_085E: nop
    IL_085F: IL_DE
    IL_0860: IL_42
    IL_0861: IL_22
    IL_0862: nop
    IL_0863: nop
    IL_0864: ldc.i4.2
    IL_0865: IL_43
    IL_0866: IL_22
    IL_0867: nop
    IL_0868: nop
    IL_0869: nop
    IL_086A: IL_42
    IL_086F: call 0x0600021D
    IL_0874: ldsfld 0x0A000099
    IL_0875: ldarg.0
    IL_087A: ldfld 0x04000BC3
    IL_087F: call 0x0A0002E8
    IL_0884: brfalse IL_0891
    IL_0885: ldarg.0
    IL_0886: ldc.i4.1
    IL_088B: stfld 0x04000BCA
    IL_0890: br IL_08B4
    IL_0891: ldarg.0
    IL_0896: ldfld 0x04000BCA
    IL_089B: brfalse IL_08B4
    IL_089C: ldarg.0
    IL_08A1: ldfld 0x04000BCF
    IL_08A2: ldarg.0
    IL_08A7: ldfld 0x04000BC7
    IL_08A8: conv.r8
    IL_08A9: IL_F8
    IL_08AA: ldarg.2
    IL_08AB: nop
    IL_08AC: ldloc.0
    IL_08AD: ldarg.0
    IL_08AE: ldc.i4.0
    IL_08B3: stfld 0x04000BCA
    IL_08B4: ldarg.0
    IL_08B9: ldfld 0x04000BC7
    IL_08BA: IL_22
    IL_08BB: nop
    IL_08BC: nop
    IL_08BD: IL_FC
    IL_08BE: IL_42
    IL_08BF: IL_5A
    IL_08C0: IL_22
    IL_08C1: nop
    IL_08C2: nop
    IL_08C3: IL_4E
    IL_08C4: IL_43
    IL_08C5: IL_58
    IL_08C6: IL_22
    IL_08C7: nop
    IL_08C8: nop
    IL_08C9: IL_EE
    IL_08CA: IL_42
    IL_08CB: IL_22
    IL_08CC: nop
    IL_08CD: nop
    IL_08D2: stsfld 0x00002241
    IL_08D7: stsfld 0x021D2841
    IL_08D8: nop
    IL_08D9: ldloc.0
    IL_08DA: ldarg.0
    IL_08DF: ldfld 0x04000BB3
    IL_08E4: call 0x0A0000E0
    IL_08E5: IL_22
    IL_08E6: nop
    IL_08E7: nop
    IL_08E8: IL_50
    IL_08E9: IL_43
    IL_08EA: IL_22
    IL_08EB: nop
    IL_08EC: nop
    IL_08ED: div.un
    IL_08EE: IL_43
    IL_08EF: IL_22
    IL_08F0: nop
    IL_08F1: nop
    IL_08F6: stsfld 0x00002242
    IL_08F7: nop
    IL_08F8: IL_42
    IL_08FD: call 0x0600021D
    IL_0902: ldsfld 0x040007B2
    IL_0903: ldarg.0
    IL_0908: ldfld 0x04000BD9
    IL_0909: ldc.i4.0
    IL_090E: call 0x0A0000E1
    IL_090F: ldarg.0
    IL_0914: ldfld 0x04000BC4
    IL_0919: call 0x0A0000F1
    IL_091E: brfalse IL_0946
    IL_091F: ldarg.0
    IL_0920: ldc.i4.0
    IL_0925: stfld 0x04000BD7
    IL_092A: ldstr 0x70022774
    IL_092B: ldarg.0
    IL_0930: ldfld 0x04000BC7
    IL_0935: call 0x0A000255
    IL_093A: ldstr 0x7002270C
    IL_093B: ldarg.0
    IL_0940: ldfld 0x04000BC8
    IL_0945: call 0x0A000255
    IL_0946: IL_22
    IL_0947: nop
    IL_0948: nop
    IL_0949: IL_56
    IL_094A: IL_43
    IL_094B: IL_22
    IL_094C: nop
    IL_094D: nop
    IL_094F: stloc.s 67
    IL_0950: IL_22
    IL_0951: nop
    IL_0952: nop
    IL_0953: nop
    IL_0954: IL_42
    IL_0955: IL_22
    IL_0956: nop
    IL_0957: nop
    IL_0958: nop
    IL_0959: IL_42
    IL_095E: call 0x0600021D
    IL_0963: ldstr 0x700237CB
    IL_0964: ldarg.0
    IL_0969: ldfld 0x04000BC1
    IL_096E: call 0x0A0000F1
    IL_0973: brfalse IL_09BF
    IL_0974: ldarg.0
    IL_0979: ldfld 0x04000BDC
    IL_097A: ldc.i4.0
    IL_097B: IL_3E
    IL_0980: brtrue IL_2000981
    IL_0981: dup
    IL_0986: ldfld 0x04000BDC
    IL_0987: ldc.i4.1
    IL_0988: IL_59
    IL_098D: stfld 0x04000BDC
    IL_0992: call 0x0A000035
    IL_0993: conv.r8
    IL_0994: ldloc.0
    IL_0995: nop
    IL_0996: nop
    IL_0998: br.s IL_099B
    IL_099D: ldfld 0x04000BDC
    IL_099F: ldc.i4.s -2
    IL_09A0: IL_5A
    IL_09A2: ldc.i4.s 30
    IL_09A3: IL_58
    IL_09A4: conv.i2
    IL_09A5: conv.r8
    IL_09A7: blt.s IL_09A9
    IL_09A8: nop
    IL_09A9: ldloc.0
    IL_09AE: ldstr 0x70001E7D
    IL_09AF: ldarg.0
    IL_09B4: ldfld 0x04000BDC
    IL_09B9: call 0x0600021F
    IL_09BE: br IL_0A33
    IL_09BF: IL_22
    IL_09C0: nop
    IL_09C1: nop
    IL_09C2: ldelem.i
    IL_09C3: IL_43
    IL_09C4: IL_22
    IL_09C5: nop
    IL_09C6: nop
    IL_09C8: stloc.s 67
    IL_09C9: IL_22
    IL_09CA: nop
    IL_09CB: nop
    IL_09CC: nop
    IL_09CD: IL_42
    IL_09CE: IL_22
    IL_09CF: nop
    IL_09D0: nop
    IL_09D1: nop
    IL_09D2: IL_42
    IL_09D7: call 0x0600021D
    IL_09DC: ldstr 0x700237CF
    IL_09DD: ldarg.0
    IL_09E2: ldfld 0x04000BC1
    IL_09E7: call 0x0A0000F1
    IL_09EC: brfalse IL_0A33
    IL_09ED: ldarg.0
    IL_09F2: ldfld 0x04000BDC
    IL_09F3: ldc.i4.5
    IL_09F4: IL_3C
    IL_09F9: brtrue IL_20009FA
    IL_09FA: dup
    IL_09FF: ldfld 0x04000BDC
    IL_0A00: ldc.i4.1
    IL_0A01: IL_58
    IL_0A06: stfld 0x04000BDC
    IL_0A0B: call 0x0A000035
    IL_0A0C: conv.r8
    IL_0A0D: ldloc.0
    IL_0A0E: nop
    IL_0A0F: nop
    IL_0A11: br.s IL_0A14
    IL_0A16: ldfld 0x04000BDC
    IL_0A18: ldc.i4.s -2
    IL_0A19: IL_5A
    IL_0A1B: ldc.i4.s 30
    IL_0A1C: IL_58
    IL_0A1D: conv.i2
    IL_0A1E: conv.r8
    IL_0A20: blt.s IL_0A22
    IL_0A21: nop
    IL_0A22: ldloc.0
    IL_0A27: ldstr 0x70001E7D
    IL_0A28: ldarg.0
    IL_0A2D: ldfld 0x04000BDC
    IL_0A32: call 0x0600021F
    IL_0A33: IL_22
    IL_0A34: nop
    IL_0A35: nop
    IL_0A36: IL_82
    IL_0A37: IL_43
    IL_0A38: IL_22
    IL_0A39: nop
    IL_0A3A: nop
    IL_0A3C: stloc.s 67
    IL_0A3D: IL_22
    IL_0A3E: nop
    IL_0A3F: nop
    IL_0A40: nop
    IL_0A41: IL_42
    IL_0A42: IL_22
    IL_0A43: nop
    IL_0A44: nop
    IL_0A45: nop
    IL_0A46: IL_42
    IL_0A4B: call 0x0600021D
    IL_0A50: ldstr 0x700237D3
    IL_0A51: ldarg.0
    IL_0A56: ldfld 0x04000BDC
    IL_0A5B: newobj 0x0100000B
    IL_0A60: call 0x0A00009A
    IL_0A65: ldstr 0x70000BC5
    IL_0A6A: call 0x0A0000E2
    IL_0A6F: call 0x0A0000E3
    IL_0A74: br IL_0BB0
    IL_0A75: ldarg.0
    IL_0A7A: ldfld 0x04000BD6
    IL_0A7F: brfalse IL_0BB0
    IL_0A80: IL_22
    IL_0A81: nop
    IL_0A82: nop
    IL_0A83: nop
    IL_0A84: nop
    IL_0A85: IL_22
    IL_0A86: nop
    IL_0A87: nop
    IL_0A88: nop
    IL_0A89: nop
    IL_0A8A: IL_22
    IL_0A8B: nop
    IL_0A8C: nop
    IL_0A8D: IL_F0
    IL_0A8E: IL_43
    IL_0A8F: IL_22
    IL_0A90: nop
    IL_0A91: nop
    IL_0A92: ldelem.r8
    IL_0A93: IL_43
    IL_0A98: call 0x0600021D
    IL_0A99: ldarg.0
    IL_0A9E: ldfld 0x04000BB1
    IL_0AA3: call 0x0A0000E0
    IL_0AA4: IL_22
    IL_0AA5: nop
    IL_0AA6: nop
    IL_0AA7: IL_E0
    IL_0AA8: IL_42
    IL_0AA9: IL_22
    IL_0AAA: nop
    IL_0AAB: nop
    IL_0AAC: ldelem.r8
    IL_0AAD: IL_42
    IL_0AAE: IL_22
    IL_0AAF: nop
    IL_0AB0: nop
    IL_0AB5: stsfld 0x00002243
    IL_0ABA: stsfld 0x021D2842
    IL_0ABB: nop
    IL_0ABC: ldloc.0
    IL_0AC1: ldsfld 0x040007B2
    IL_0AC2: ldarg.0
    IL_0AC7: ldfld 0x04000BD9
    IL_0AC9: ldc.i4.s 30
    IL_0ACE: call 0x0A0000E1
    IL_0ACF: ldarg.0
    IL_0AD4: ldfld 0x04000BB0
    IL_0AD9: call 0x0A0000F1
    IL_0ADE: brfalse IL_0B11
    IL_0ADF: IL_22
    IL_0AE0: nop
    IL_0AE1: nop
    IL_0AE6: stsfld 0x0111283F
    IL_0AE7: nop
    IL_0AE8: stloc.0
    IL_0AE9: ldarg.0
    IL_0AEA: ldc.i4.0
    IL_0AEF: stfld 0x04000BD6
    IL_0AF0: ldarg.0
    IL_0AF5: ldfld 0x04000BCE
    IL_0AF6: conv.r8
    IL_0AF7: conv.u4
    IL_0AF8: IL_01
    IL_0AF9: nop
    IL_0AFA: ldloc.0
    IL_0AFB: ldarg.0
    IL_0B00: call 0x0A00000A
    IL_0B01: ldc.i4.0
    IL_0B02: conv.r8
    IL_0B03: stloc.1
    IL_0B04: nop
    IL_0B05: nop
    IL_0B06: stloc.0
    IL_0B0B: call 0x0A000303
    IL_0B10: br IL_0BB0
    IL_0B11: IL_22
    IL_0B12: nop
    IL_0B13: nop
    IL_0B14: IL_E0
    IL_0B15: IL_42
    IL_0B16: IL_22
    IL_0B17: nop
    IL_0B18: nop
    IL_0B19: ldarg.0
    IL_0B1A: IL_43
    IL_0B1B: IL_22
    IL_0B1C: nop
    IL_0B1D: nop
    IL_0B22: stsfld 0x00002243
    IL_0B27: stsfld 0x021D2842
    IL_0B28: nop
    IL_0B29: ldloc.0
    IL_0B2E: ldsfld 0x040007B2
    IL_0B2F: ldarg.0
    IL_0B34: ldfld 0x04000BD9
    IL_0B36: ldc.i4.s 31
    IL_0B3B: call 0x0A0000E1
    IL_0B3C: ldarg.0
    IL_0B41: ldfld 0x04000BB0
    IL_0B46: call 0x0A0000F1
    IL_0B4B: brfalse IL_0B58
    IL_0B4C: ldarg.0
    IL_0B4D: ldc.i4.1
    IL_0B52: stfld 0x04000BD7
    IL_0B57: br IL_0BB0
    IL_0B58: IL_22
    IL_0B59: nop
    IL_0B5A: nop
    IL_0B5B: IL_E0
    IL_0B5C: IL_42
    IL_0B5D: IL_22
    IL_0B5E: nop
    IL_0B5F: nop
    IL_0B60: IL_34
    IL_0B61: IL_43
    IL_0B62: IL_22
    IL_0B63: nop
    IL_0B64: nop
    IL_0B69: stsfld 0x00002243
    IL_0B6E: stsfld 0x021D2842
    IL_0B6F: nop
    IL_0B70: ldloc.0
    IL_0B75: ldsfld 0x040007B2
    IL_0B76: ldarg.0
    IL_0B7B: ldfld 0x04000BD9
    IL_0B7D: ldc.i4.s 59
    IL_0B82: call 0x0A0000E1
    IL_0B83: ldarg.0
    IL_0B88: ldfld 0x04000BB0
    IL_0B8D: call 0x0A0000F1
    IL_0B92: brfalse IL_0BB0
    IL_0B93: IL_22
    IL_0B94: nop
    IL_0B95: nop
    IL_0B9A: stsfld 0x0111283F
    IL_0B9B: nop
    IL_0B9C: stloc.0
    IL_0B9D: ldarg.0
    IL_0B9E: ldc.i4.0
    IL_0BA3: stfld 0x04000BD6
    IL_0BA4: ldarg.0
    IL_0BA9: ldfld 0x04000BDA
    IL_0BAA: ldc.i4.m1
    IL_0BAB: conv.r8
    IL_0BAD: starg.s 6
    IL_0BAE: nop
    IL_0BAF: ldloc.0
    IL_0BB0: ldarg.0
    IL_0BB5: ldfld 0x04000BB8
    IL_0BBA: brfalse IL_0DA9
    IL_0BBB: IL_22
    IL_0BBC: nop
    IL_0BBD: nop
    IL_0BBE: IL_E0
    IL_0BBF: IL_42
    IL_0BC0: IL_22
    IL_0BC1: nop
    IL_0BC2: nop
    IL_0BC3: IL_C0
    IL_0BC4: IL_42
    IL_0BC5: IL_22
    IL_0BC6: nop
    IL_0BC7: nop
    IL_0BCC: stsfld 0x00002243
    IL_0BCD: nop
    IL_0BCE: IL_43
    IL_0BD3: call 0x0600021D
    IL_0BD4: ldarg.0
    IL_0BD9: ldfld 0x04000BB5
    IL_0BDE: call 0x0A0000E0
    IL_0BDF: IL_22
    IL_0BE0: nop
    IL_0BE1: nop
    IL_0BE2: IL_F0
    IL_0BE3: IL_42
    IL_0BE4: IL_22
    IL_0BE5: nop
    IL_0BE6: nop
    IL_0BE7: IL_CC
    IL_0BE8: IL_42
    IL_0BE9: IL_22
    IL_0BEA: nop
    IL_0BEB: nop
    IL_0BF0: cpobj 0x00002243
    IL_0BF2: starg.s 66
    IL_0BF7: call 0x0600021D
    IL_0BFC: ldsfld 0x0A000099
    IL_0C01: ldsfld 0x040007B2
    IL_0C02: ldarg.0
    IL_0C07: ldfld 0x04000BD9
    IL_0C08: ldarg.0
    IL_0C0D: ldfld 0x04000BBC
    IL_0C12: call 0x0A0000E1
    IL_0C17: call 0x0A000011
    IL_0C1C: ldstr 0x70000C43
    IL_0C21: call 0x0A0000E2
    IL_0C26: call 0x0A0000E3
    IL_0C27: IL_22
    IL_0C28: nop
    IL_0C29: nop
    IL_0C2A: IL_EC
    IL_0C2B: IL_42
    IL_0C2C: IL_22
    IL_0C2D: nop
    IL_0C2E: nop
    IL_0C31: ldloc 8771
    IL_0C32: nop
    IL_0C33: nop
    IL_0C34: conv.u4
    IL_0C35: IL_43
    IL_0C36: IL_22
    IL_0C37: nop
    IL_0C38: nop
    IL_0C39: rem
    IL_0C3A: IL_41
    IL_0C3F: call 0x0600021D
    IL_0C40: ldc.i4.4
    IL_0C45: newarr 0x01000020
    IL_0C46: dup
    IL_0C47: ldc.i4.0
    IL_0C4C: ldsfld 0x0A000099
    IL_0C51: stelem 0x7B021725
    IL_0C52: IL_BB
    IL_0C53: stloc.1
    IL_0C54: nop
    IL_0C55: ldarg.2
    IL_0C56: ldc.i4.1
    IL_0C57: IL_58
    IL_0C5C: newobj 0x0100000B
    IL_0C61: stelem 0xD9721825
    IL_0C62: IL_37
    IL_0C63: ldarg.0
    IL_0C68: cpobj 0x021925A2
    IL_0C6D: ldfld 0x04000BBA
    IL_0C72: newobj 0x0100000B
    IL_0C77: stelem 0x00009628
    IL_0C78: stloc.0
    IL_0C7D: ldstr 0x70000C43
    IL_0C82: call 0x0A0000E2
    IL_0C87: call 0x0A0000E3
    IL_0C88: ldarg.0
    IL_0C8D: ldfld 0x04000BBF
    IL_0C8E: ldarg.0
    IL_0C93: ldfld 0x04000BB7
    IL_0C98: call 0x0A0000E0
    IL_0C99: ldarg.0
    IL_0C9E: ldfld 0x04000BBD
    IL_0CA3: brfalse IL_0CD4
    IL_0CA4: ldarg.0
    IL_0CA9: ldflda 0x04000BBE
    IL_0CAE: ldfld 0x0A000059
    IL_0CAF: ldarg.0
    IL_0CB4: ldflda 0x04000BBE
    IL_0CB9: ldfld 0x0A00005A
    IL_0CBA: IL_22
    IL_0CBB: nop
    IL_0CBC: nop
    IL_0CC1: stsfld 0x00002242
    IL_0CC6: stsfld 0x021D2842
    IL_0CC7: nop
    IL_0CC8: ldloc.0
    IL_0CC9: ldarg.0
    IL_0CCE: ldfld 0x04000BB6
    IL_0CD3: call 0x0A0000E0
    IL_0CD4: ldarg.0
    IL_0CD9: ldfld 0x04000BBA
    IL_0CDA: ldc.i4.1
    IL_0CDB: IL_59
    IL_0CDC: ldarg.0
    IL_0CE1: ldfld 0x04000BBB
    IL_0CE2: IL_3D
    IL_0CE3: shr.un
    IL_0CE4: nop
    IL_0CE5: nop
    IL_0CE6: nop
    IL_0CE7: IL_22
    IL_0CE8: nop
    IL_0CE9: nop
    IL_0CEA: IL_91
    IL_0CEB: IL_43
    IL_0CEC: IL_22
    IL_0CED: nop
    IL_0CEE: nop
    IL_0CF3: br IL_2F37
    IL_0CF8: stsfld 0x00002242
    IL_0CF9: nop
    IL_0CFA: IL_42
    IL_0CFF: call 0x0600021D
    IL_0D04: ldsfld 0x040007B2
    IL_0D05: ldarg.0
    IL_0D0A: ldfld 0x04000BD9
    IL_0D0B: ldc.i4.4
    IL_0D10: call 0x0A0000E1
    IL_0D11: ldarg.0
    IL_0D16: ldfld 0x04000BC4
    IL_0D1B: call 0x0A0000F1
    IL_0D20: brfalse IL_0D49
    IL_0D21: ldarg.0
    IL_0D22: ldc.i4.0
    IL_0D27: stfld 0x04000BB8
    IL_0D28: IL_22
    IL_0D29: nop
    IL_0D2A: nop
    IL_0D2F: stsfld 0x0111283F
    IL_0D30: nop
    IL_0D31: stloc.0
    IL_0D32: ldarg.0
    IL_0D37: call 0x0A00000A
    IL_0D38: ldc.i4.0
    IL_0D39: conv.r8
    IL_0D3A: stloc.1
    IL_0D3B: nop
    IL_0D3C: nop
    IL_0D3D: stloc.0
    IL_0D3E: ldarg.0
    IL_0D43: ldfld 0x04000BCE
    IL_0D44: conv.r8
    IL_0D45: conv.u4
    IL_0D46: IL_01
    IL_0D47: nop
    IL_0D48: ldloc.0
    IL_0D4D: br IL_0DA9
    IL_0D4E: IL_22
    IL_0D4F: nop
    IL_0D50: nop
    IL_0D51: IL_91
    IL_0D52: IL_43
    IL_0D53: IL_22
    IL_0D54: nop
    IL_0D55: nop
    IL_0D5A: br IL_2F9E
    IL_0D5F: stsfld 0x00002242
    IL_0D60: nop
    IL_0D61: IL_42
    IL_0D66: call 0x0600021D
    IL_0D6B: ldsfld 0x040007B2
    IL_0D6C: ldarg.0
    IL_0D71: ldfld 0x04000BD9
    IL_0D73: ldc.i4.s 47
    IL_0D78: call 0x0A0000E1
    IL_0D79: ldarg.0
    IL_0D7E: ldfld 0x04000BC4
    IL_0D83: call 0x0A0000F1
    IL_0D88: brfalse IL_0DA9
    IL_0D89: ldarg.0
    IL_0D8A: dup
    IL_0D8F: ldfld 0x04000BBB
    IL_0D90: ldc.i4.1
    IL_0D91: IL_58
    IL_0D96: stfld 0x04000BBB
    IL_0D97: ldarg.0
    IL_0D98: ldarg.0
    IL_0D9D: ldfld 0x04000BB9
    IL_0D9E: ldarg.0
    IL_0DA3: ldfld 0x04000BBB
    IL_0DA8: call 0x06000636
    IL_0DA9: ret
    }

    }}
