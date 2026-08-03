// Namespace: 
// Type: RankingUI

    public class RankingUI {{

    private object MAXRANKING;
    public object bg_title;
    public object bg_title_me;
    public object icon_key;
    public object toggle_active;
    public object errorimg;
    public object icon_ranktab;
    public object icon_toprank;
    private object myimage;
    public object bt_empty;
    public object bt_start;
    public object bt_back;
    public object basicSkin;
    private object curMousePosY;
    private object startMousePosY;
    private object scrollPosition;
    private object prev_scrollPosition;
    private object language;
    private object posX;
    private object posY;
    private object ui;
    private object scopemode;
    private object script_ranking;

    public RankingUI() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 50
    IL_0007: stfld 0x0400088E
    IL_0008: ldarg.0
    IL_0009: ldc.i4.3
    IL_000E: newarr 0x0100003C
    IL_0013: stfld 0x04000894
    IL_0014: ldarg.0
    IL_0015: ldc.i4.3
    IL_001A: newarr 0x0100003C
    IL_001F: stfld 0x04000895
    IL_0020: ldarg.0
    IL_0021: IL_22
    IL_0022: nop
    IL_0023: nop
    IL_0024: IL_E0
    IL_0025: IL_42
    IL_002A: stfld 0x040008A0
    IL_002B: ldarg.0
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_002F: IL_E4
    IL_0030: IL_42
    IL_0035: stfld 0x040008A1
    IL_0036: ldarg.0
    IL_003B: call 0x0A000001
    IL_003C: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x0400089F
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70022A18
    IL_001A: call 0x0A000004
    IL_001B: conv.r8
    IL_001C: div
    IL_001D: nop
    IL_001E: nop
    IL_0020: br.s IL_009E
    IL_0021: IL_A4
    IL_0022: ldloc.2
    IL_0023: nop
    IL_0024: ldarg.2
    IL_0025: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008A4
    IL_0006: ldc.i4.1
    IL_0007: ldc.i4.0
    IL_0009: ldc.i4.s 30
    IL_000A: conv.r8
    IL_000B: ldnull
    IL_000C: ldarg.2
    IL_000D: nop
    IL_000E: ldloc.0
    IL_000F: ret
    }

    public void RankingOn() {
    IL_0000: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040008A0
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_37
    IL_000B: IL_43
    IL_0010: call 0x0A000024
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: throw
    IL_0015: IL_44
    IL_0016: IL_5A
    IL_001B: call 0x0A0000C0
    IL_0020: stfld 0x040008A0
    IL_0021: ret
    }

    private void OnGUI() {
    IL_0001: ldc.i4.s -8
    IL_0006: call 0x0A0000EF
    IL_0007: ldarg.0
    IL_000C: ldfld 0x0400089A
    IL_0011: call 0x0A0000DF
    IL_0016: call 0x0A00001B
    IL_001B: call 0x0A000013
    IL_0020: call 0x0A0000D9
    IL_0021: conv.i2
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: cpobj 0xDA285B44
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: conv.i2
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0035: ldc.i4 2251588
    IL_0036: nop
    IL_003B: stsfld 0x0076733F
    IL_003C: nop
    IL_003D: stloc.0
    IL_0042: call 0x0A0000DD
    IL_0047: call 0x0A0000DE
    IL_004C: call 0x0A000115
    IL_0051: brfalse IL_00AE
    IL_0052: ldarg.0
    IL_0057: ldfld 0x040008A0
    IL_0058: ldarg.0
    IL_005D: ldfld 0x040008A1
    IL_005E: IL_22
    IL_005F: nop
    IL_0060: nop
    IL_0065: ldc.i4 2250818
    IL_0066: nop
    IL_006B: stsfld 0x00002243
    IL_006D: ldarg.s 67
    IL_0072: call 0x0600021D
    IL_0073: stloc.2
    IL_0075: ldloca.s 2
    IL_007A: call 0x0A0001FE
    IL_007B: conv.r8
    IL_007C: IL_FF
    IL_007D: IL_01
    IL_007E: nop
    IL_007F: stloc.0
    IL_0084: call 0x0A000200
    IL_0089: brfalse IL_00A9
    IL_008A: ldarg.0
    IL_008F: call 0x0A0000D7
    IL_0090: stloc.3
    IL_0092: ldloca.s 3
    IL_0097: ldfld 0x0A000023
    IL_009C: stfld 0x0400089C
    IL_009D: ldarg.0
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x0400089D
    IL_00A8: stfld 0x0400089E
    IL_00AD: br IL_013E
    IL_00B2: call 0x0A00011A
    IL_00B7: brfalse IL_013E
    IL_00B8: ldarg.0
    IL_00BD: ldfld 0x040008A0
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x040008A1
    IL_00C4: IL_22
    IL_00C5: nop
    IL_00C6: nop
    IL_00CB: ldc.i4 2250818
    IL_00CC: nop
    IL_00D1: stsfld 0x00002243
    IL_00D3: ldarg.s 67
    IL_00D8: call 0x0600021D
    IL_00DA: stloc.s 4
    IL_00DC: ldloca.s 4
    IL_00E1: call 0x0A0001FE
    IL_00E2: conv.r8
    IL_00E3: IL_FF
    IL_00E4: IL_01
    IL_00E5: nop
    IL_00E6: stloc.0
    IL_00EB: call 0x0A000200
    IL_00F0: brfalse IL_013E
    IL_00F1: ldarg.0
    IL_00F6: call 0x0A0000D7
    IL_00F8: stloc.s 5
    IL_00FA: ldloca.s 5
    IL_00FF: ldfld 0x0A000023
    IL_0104: stfld 0x0400089B
    IL_0105: ldarg.0
    IL_0106: ldarg.0
    IL_010B: ldfld 0x0400089E
    IL_0110: call 0x0A0000AA
    IL_0111: ldarg.0
    IL_0116: ldfld 0x0400089B
    IL_0117: ldarg.0
    IL_011C: ldfld 0x0400089C
    IL_011D: IL_59
    IL_0122: call 0x0A000083
    IL_0123: IL_22
    IL_0124: nop
    IL_0125: nop
    IL_012A: ldc.i4 14297156
    IL_012B: nop
    IL_012C: stloc.0
    IL_012D: conv.i2
    IL_012E: add
    IL_0133: call 0x0A000083
    IL_0138: call 0x0A0000AB
    IL_013D: stfld 0x0400089D
    IL_013E: ldarg.0
    IL_0143: ldfld 0x040008A0
    IL_0144: IL_22
    IL_0145: nop
    IL_0146: nop
    IL_0147: IL_94
    IL_0148: IL_42
    IL_0149: IL_59
    IL_014A: ldarg.0
    IL_014F: ldfld 0x040008A1
    IL_0150: IL_22
    IL_0151: nop
    IL_0152: nop
    IL_0157: call 0x00225942
    IL_0158: nop
    IL_0159: IL_83
    IL_015A: IL_43
    IL_015B: IL_22
    IL_015C: nop
    IL_015D: nop
    IL_0162: cpobj 0x021D2843
    IL_0163: nop
    IL_0164: ldloc.0
    IL_0169: ldsfld 0x0A000099
    IL_016E: ldstr 0x70022A46
    IL_0173: call 0x0A0000E2
    IL_0178: call 0x0A0001BA
    IL_0179: ldarg.0
    IL_017E: ldfld 0x040008A4
    IL_0183: ldfld 0x0400088B
    IL_0188: brfalse IL_05E3
    IL_0189: ldarg.0
    IL_018E: ldfld 0x040008A4
    IL_0193: ldfld 0x04000888
    IL_0194: stloc.0
    IL_0195: ldarg.0
    IL_0196: ldarg.0
    IL_019B: ldfld 0x040008A0
    IL_019C: IL_22
    IL_019D: nop
    IL_019E: nop
    IL_019F: IL_94
    IL_01A0: IL_42
    IL_01A1: IL_59
    IL_01A2: ldarg.0
    IL_01A7: ldfld 0x040008A1
    IL_01A8: IL_22
    IL_01A9: nop
    IL_01AA: nop
    IL_01AF: ldobj 0x00225841
    IL_01B0: nop
    IL_01B1: IL_81
    IL_01B2: IL_43
    IL_01B3: IL_22
    IL_01B4: nop
    IL_01B5: nop
    IL_01B7: beq.s IL_01FB
    IL_01BC: call 0x0600021D
    IL_01BD: ldarg.0
    IL_01C2: ldfld 0x0400089D
    IL_01C3: IL_22
    IL_01C4: nop
    IL_01C5: nop
    IL_01C6: nop
    IL_01C7: nop
    IL_01C8: IL_22
    IL_01C9: nop
    IL_01CA: nop
    IL_01CB: nop
    IL_01CC: nop
    IL_01CD: IL_22
    IL_01CE: nop
    IL_01CF: nop
    IL_01D4: ldstr 0x2C1F0643
    IL_01D5: IL_5A
    IL_01D6: conv.i2
    IL_01DB: call 0x0600021D
    IL_01E0: call 0x0A000201
    IL_01E5: stfld 0x0400089D
    IL_01E6: ldc.i4.0
    IL_01E7: stloc.1
    IL_01EC: br IL_03C7
    IL_01ED: ldarg.0
    IL_01F2: ldflda 0x0400089D
    IL_01F7: ldfld 0x0A00005A
    IL_01F8: ldloc.1
    IL_01FA: ldc.i4.s 88
    IL_01FB: IL_5A
    IL_01FC: conv.i2
    IL_01FD: IL_59
    IL_01FE: IL_22
    IL_01FF: nop
    IL_0200: nop
    IL_0201: ldelem.r8
    IL_0202: IL_42
    IL_0203: IL_3D
    IL_0204: ldc.i4.5
    IL_0205: nop
    IL_0206: nop
    IL_0207: nop
    IL_0208: ldarg.0
    IL_020D: ldflda 0x0400089D
    IL_0212: ldfld 0x0A00005A
    IL_0213: ldloc.1
    IL_0215: ldc.i4.s 88
    IL_0216: IL_5A
    IL_0217: conv.i2
    IL_0218: IL_59
    IL_0219: IL_22
    IL_021A: nop
    IL_021B: nop
    IL_021C: IL_AF
    IL_021D: IL_C3
    IL_021E: IL_41
    IL_021F: ldarg.3
    IL_0220: nop
    IL_0221: nop
    IL_0222: nop
    IL_0227: br IL_03C2
    IL_0228: ldarg.0
    IL_022D: ldfld 0x040008A4
    IL_0232: ldfld 0x04000882
    IL_0233: ldloc.1
    IL_0234: ldelem.i
    IL_0235: ldnull
    IL_023A: call 0x0A000021
    IL_023F: brfalse IL_0272
    IL_0240: IL_22
    IL_0241: nop
    IL_0242: nop
    IL_0243: IL_44
    IL_0244: IL_42
    IL_0245: ldloc.1
    IL_0247: ldc.i4.s 44
    IL_0248: IL_5A
    IL_0249: ldc.i4.2
    IL_024A: IL_58
    IL_024B: conv.i2
    IL_024C: IL_22
    IL_024D: nop
    IL_024E: nop
    IL_0250: starg.s 66
    IL_0251: IL_22
    IL_0252: nop
    IL_0253: nop
    IL_0255: starg.s 66
    IL_025A: call 0x0600021D
    IL_025B: ldarg.0
    IL_0260: ldfld 0x040008A4
    IL_0265: ldfld 0x04000882
    IL_0266: ldloc.1
    IL_0267: ldelem.i
    IL_026C: call 0x0A0000E0
    IL_0271: br IL_0298
    IL_0272: IL_22
    IL_0273: nop
    IL_0274: nop
    IL_0275: IL_44
    IL_0276: IL_42
    IL_0277: ldloc.1
    IL_0279: ldc.i4.s 44
    IL_027A: IL_5A
    IL_027B: ldc.i4.2
    IL_027C: IL_58
    IL_027D: conv.i2
    IL_027E: IL_22
    IL_027F: nop
    IL_0280: nop
    IL_0282: starg.s 66
    IL_0283: IL_22
    IL_0284: nop
    IL_0285: nop
    IL_0287: starg.s 66
    IL_028C: call 0x0600021D
    IL_028D: ldarg.0
    IL_0292: ldfld 0x04000893
    IL_0297: call 0x0A0000E0
    IL_0298: IL_22
    IL_0299: nop
    IL_029A: nop
    IL_B07C1FA3: switch (740230977 cases)
    }

    }}
