// Namespace: 
// Type: LoopArchive

    public class LoopArchive {{

    private static object MAXSKILL;
    private static object MAXARCHIVE;
    private static object MAXGENERALPOOL;
    private object script_archive;
    private object gift_archive;
    private object temp_staff;
    private object temp_treasure;
    private object complete_archive;
    private object unlock_costume;
    private object bosskill;
    private object skill_use;
    private object pet_skill_use;
    private object cur_skill_grade;
    private object enemykill;
    private object grappling;
    private object exattack;
    private object death;
    private object resurrection;
    private object cashing;
    private object max_stage_index;
    private object remain_arch;
    private object generalsearch;
    private object caveplay;
    private object perfectplay;

    public LoopArchive() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 30
    IL_0007: newarr 0x0100000B
    IL_000C: stfld 0x040007C5
    IL_000D: ldarg.0
    IL_000F: ldc.i4.s 24
    IL_0014: newarr 0x0100000B
    IL_0019: stfld 0x040007C6
    IL_001A: ldarg.0
    IL_001C: ldc.i4.s 76
    IL_0021: newarr 0x0100000B
    IL_0026: stfld 0x040007C7
    IL_0027: ldarg.0
    IL_0029: ldc.i4.s 20
    IL_002E: newarr 0x0100000B
    IL_0033: stfld 0x040007C8
    IL_0034: ldarg.0
    IL_0036: ldc.i4.s 12
    IL_003B: newarr 0x0100000B
    IL_0040: stfld 0x040007C9
    IL_0041: ldarg.0
    IL_0043: ldc.i4.s 20
    IL_0048: newarr 0x0100000B
    IL_004D: stfld 0x040007CA
    IL_004E: ldarg.0
    IL_004F: ldc.i4.2
    IL_0054: newarr 0x0100000B
    IL_0059: stfld 0x040007CB
    IL_005A: ldarg.0
    IL_005C: ldc.i4.s 20
    IL_0061: newarr 0x0100000B
    IL_0066: stfld 0x040007CC
    IL_0067: ldarg.0
    IL_0068: ldc.i4.m1
    IL_006D: stfld 0x040007D3
    IL_006E: ldarg.0
    IL_0073: call 0x0A000001
    IL_0074: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001FDF
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x040007C7
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70001FEF
    IL_001A: call 0x060003F9
    IL_001F: stfld 0x040007C9
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70002001
    IL_002A: call 0x060003F9
    IL_002F: stfld 0x040007CA
    IL_0030: ldarg.0
    IL_0035: ldstr 0x70002015
    IL_003A: call 0x060003F9
    IL_003F: stfld 0x040007CB
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70002031
    IL_004A: call 0x06000220
    IL_004F: stfld 0x040007CD
    IL_0050: ldarg.0
    IL_0055: ldstr 0x70002045
    IL_005A: call 0x06000220
    IL_005F: stfld 0x040007CE
    IL_0060: ldarg.0
    IL_0065: ldstr 0x70000EC9
    IL_006A: call 0x06000220
    IL_006F: stfld 0x040007CF
    IL_0070: ldarg.0
    IL_0075: ldstr 0x70002059
    IL_007A: call 0x06000220
    IL_007F: stfld 0x040007D0
    IL_0080: ldarg.0
    IL_0085: ldstr 0x700015BF
    IL_008A: call 0x06000220
    IL_008F: stfld 0x040007D1
    IL_0090: ldarg.0
    IL_0095: ldstr 0x700004DD
    IL_009A: call 0x06000220
    IL_009F: stfld 0x040007D3
    IL_00A0: ldarg.0
    IL_00A5: ldstr 0x70001EE5
    IL_00AA: call 0x060003F9
    IL_00AF: stfld 0x040007C8
    IL_00B0: ldarg.0
    IL_00B1: ldarg.0
    IL_00B6: call 0x2B000057
    IL_00BB: stfld 0x040007C3
    IL_00BC: ldarg.0
    IL_00C1: ldstr 0x7000054F
    IL_00C6: call 0x060003F9
    IL_00CB: stfld 0x040007CC
    IL_00CC: ldarg.0
    IL_00D1: ldstr 0x70001F71
    IL_00D6: call 0x06000220
    IL_00DB: stfld 0x040007D6
    IL_00DC: ldarg.0
    IL_00E1: ldstr 0x70001F83
    IL_00E6: call 0x06000220
    IL_00EB: stfld 0x040007D7
    IL_00EC: ret
    }

    public void FindArchive() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001FD3
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x040007C5
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70001F55
    IL_001A: call 0x06000220
    IL_001F: stfld 0x040007D5
    IL_0020: ldarg.0
    IL_0025: ldstr 0x700020A5
    IL_002A: call 0x06000220
    IL_002F: stfld 0x040007D2
    IL_0030: ldc.i4.0
    IL_0031: stloc.0
    IL_0036: br IL_04E6
    IL_0037: ldarg.0
    IL_003C: ldfld 0x040007C7
    IL_003D: ldloc.0
    IL_003E: IL_94
    IL_0043: brtrue IL_04E2
    IL_0044: ldarg.0
    IL_0045: dup
    IL_004A: ldfld 0x040007D4
    IL_004B: ldc.i4.1
    IL_004C: IL_58
    IL_0051: stfld 0x040007D4
    IL_0052: ldarg.0
    IL_0057: ldfld 0x040007C3
    IL_005C: ldfld 0x0400049F
    IL_005D: ldloc.0
    IL_005E: IL_8F
    IL_005F: IL_57
    IL_0060: nop
    IL_0061: nop
    IL_0062: ldarg.0
    IL_0067: ldfld 0x0400049C
    IL_0069: stloc.s 10
    IL_006B: ldloc.s 10
    IL_006C: ldc.i4.1
    IL_006D: IL_59
    IL_0070: ldarg 20
    IL_0071: nop
    IL_0072: nop
    IL_0073: ldarg.3
    IL_0074: nop
    IL_0075: nop
    IL_0076: nop
    IL_0078: blt.s IL_0079
    IL_0079: nop
    IL_007A: nop
    IL_007B: div.un
    IL_007C: nop
    IL_007D: nop
    IL_007E: nop
    IL_0083: newobj 0xB9000000
    IL_0084: nop
    IL_0085: nop
    IL_0086: nop
    IL_0087: IL_E6
    IL_0088: nop
    IL_0089: nop
    IL_008A: nop
    IL_008B: ldc.i4.2
    IL_008C: IL_01
    IL_008D: nop
    IL_008E: nop
    IL_0091: ldarg 1
    IL_0092: nop
    IL_0093: IL_89
    IL_0094: IL_01
    IL_0095: nop
    IL_0096: nop
    IL_0097: IL_CD
    IL_0098: IL_01
    IL_0099: nop
    IL_009A: nop
    IL_009C: ldloc.s 2
    IL_009D: nop
    IL_009E: nop
    IL_009F: IL_3E
    IL_00A0: ldarg.0
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: IL_78
    IL_00A4: ldarg.0
    IL_00A5: nop
    IL_00A6: nop
    IL_00AB: ldtoken 0x28000002
    IL_00AC: ldarg.1
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: IL_55
    IL_00B0: ldarg.1
    IL_00B1: nop
    IL_00B2: nop
    IL_00B4: ldc.i4.s 4
    IL_00B5: nop
    IL_00B6: nop
    IL_00B7: IL_82
    IL_00B8: ldarg.1
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: IL_AF
    IL_00BC: ldarg.1
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: ldloc.1
    IL_00C0: ldarg.2
    IL_00C1: nop
    IL_00C2: nop
    IL_00C7: br IL_04E2
    IL_00C8: ldarg.0
    IL_00CD: ldfld 0x040007CD
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x040007C3
    IL_00D8: ldfld 0x0400049F
    IL_00D9: ldloc.0
    IL_00DA: IL_8F
    IL_00DB: IL_57
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x0400049E
    IL_00E4: IL_3F
    IL_00E5: ldloc.1
    IL_00E6: nop
    IL_00E7: nop
    IL_00E8: nop
    IL_00E9: ldarg.0
    IL_00EA: ldc.i4.1
    IL_00EF: stfld 0x040007C4
    IL_00F4: br IL_04E2
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x040007CE
    IL_00FB: ldarg.0
    IL_0100: ldfld 0x040007C3
    IL_0105: ldfld 0x0400049F
    IL_0106: ldloc.0
    IL_0107: IL_8F
    IL_0108: IL_57
    IL_0109: nop
    IL_010A: nop
    IL_010B: ldarg.0
    IL_0110: ldfld 0x0400049E
    IL_0111: IL_3F
    IL_0112: ldloc.1
    IL_0113: nop
    IL_0114: nop
    IL_0115: nop
    IL_0116: ldarg.0
    IL_0117: ldc.i4.1
    IL_011C: stfld 0x040007C4
    IL_0121: br IL_04E2
    IL_0122: ldarg.0
    IL_0127: ldfld 0x040007D0
    IL_0128: ldarg.0
    IL_012D: ldfld 0x040007C3
    IL_0132: ldfld 0x0400049F
    IL_0133: ldloc.0
    IL_0134: IL_8F
    IL_0135: IL_57
    IL_0136: nop
    IL_0137: nop
    IL_0138: ldarg.0
    IL_013D: ldfld 0x0400049E
    IL_013E: IL_3F
    IL_013F: ldloc.1
    IL_0140: nop
    IL_0141: nop
    IL_0142: nop
    IL_0143: ldarg.0
    IL_0144: ldc.i4.1
    IL_0149: stfld 0x040007C4
    IL_014E: br IL_04E2
    IL_014F: ldarg.0
    IL_0154: ldfld 0x040007D1
    IL_0155: ldarg.0
    IL_015A: ldfld 0x040007C3
    IL_015F: ldfld 0x0400049F
    IL_0160: ldloc.0
    IL_0161: IL_8F
    IL_0162: IL_57
    IL_0163: nop
    IL_0164: nop
    IL_0165: ldarg.0
    IL_016A: ldfld 0x0400049E
    IL_016B: IL_3F
    IL_016C: ldloc.1
    IL_016D: nop
    IL_016E: nop
    IL_016F: nop
    IL_0170: ldarg.0
    IL_0171: ldc.i4.1
    IL_0176: stfld 0x040007C4
    IL_017B: br IL_04E2
    IL_017C: ldarg.0
    IL_0181: ldfld 0x040007CF
    IL_0182: ldarg.0
    IL_0187: ldfld 0x040007C3
    IL_018C: ldfld 0x0400049F
    IL_018D: ldloc.0
    IL_018E: IL_8F
    IL_018F: IL_57
    IL_0190: nop
    IL_0191: nop
    IL_0192: ldarg.0
    IL_0197: ldfld 0x0400049E
    IL_0198: IL_3F
    IL_0199: ldloc.1
    IL_019A: nop
    IL_019B: nop
    IL_019C: nop
    IL_019D: ldarg.0
    IL_019E: ldc.i4.1
    IL_01A3: stfld 0x040007C4
    IL_01A8: br IL_04E2
    IL_01A9: ldc.i4.0
    IL_01AA: stloc.1
    IL_01AF: br IL_01CE
    IL_01B0: ldarg.0
    IL_01B5: ldfld 0x040007C5
    IL_01B6: ldloc.1
    IL_01B7: IL_94
    IL_01B8: ldc.i4.5
    IL_01ED: switch (12 cases)
    IL_01EE: IL_57
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: ldarg.0
    IL_01F6: ldfld 0x0400049E
    IL_01F7: IL_3F
    IL_01F8: ldloc.1
    IL_01F9: nop
    IL_01FA: nop
    IL_01FB: nop
    IL_01FC: ldarg.0
    IL_01FD: ldc.i4.1
    IL_0202: stfld 0x040007C4
    IL_0207: br IL_04E2
    IL_0208: ldarg.0
    IL_020D: ldfld 0x040007C9
    IL_020E: ldarg.0
    IL_0213: ldfld 0x040007C3
    IL_0218: ldfld 0x0400049F
    IL_0219: ldloc.0
    IL_021A: IL_8F
    IL_021B: IL_57
    IL_021C: nop
    IL_021D: nop
    IL_021E: ldarg.0
    IL_0223: ldfld 0x0400049D
    IL_0224: IL_94
    IL_0225: ldarg.0
    IL_022A: ldfld 0x040007C3
    IL_022F: ldfld 0x0400049F
    IL_0230: ldloc.0
    IL_0231: IL_8F
    IL_0232: IL_57
    IL_0233: nop
    IL_0234: nop
    IL_0235: ldarg.0
    IL_023A: ldfld 0x0400049E
    IL_023B: IL_3F
    IL_023C: ldloc.1
    IL_023D: nop
    IL_023E: nop
    IL_023F: nop
    IL_0240: ldarg.0
    IL_0241: ldc.i4.1
    IL_0246: stfld 0x040007C4
    IL_024B: br IL_04E2
    IL_024C: ldarg.0
    IL_0251: ldfld 0x040007CB
    IL_0252: ldarg.0
    IL_0257: ldfld 0x040007C3
    IL_025C: ldfld 0x0400049F
    IL_025D: ldloc.0
    IL_025E: IL_8F
    IL_025F: IL_57
    IL_0260: nop
    IL_0261: nop
    IL_0262: ldarg.0
    IL_0267: ldfld 0x0400049D
    IL_0268: IL_94
    IL_0269: ldarg.0
    IL_026E: ldfld 0x040007C3
    IL_0273: ldfld 0x0400049F
    IL_0274: ldloc.0
    IL_0275: IL_8F
    IL_0276: IL_57
    IL_0277: nop
    IL_0278: nop
    IL_0279: ldarg.0
    IL_027E: ldfld 0x0400049E
    IL_027F: IL_3F
    IL_0280: ldloc.1
    IL_0281: nop
    IL_0282: nop
    IL_0283: nop
    IL_0284: ldarg.0
    IL_0285: ldc.i4.1
    IL_028A: stfld 0x040007C4
    IL_028F: br IL_04E2
    IL_0290: ldarg.0
    IL_0295: ldfld 0x040007CA
    IL_0296: ldarg.0
    IL_029B: ldfld 0x040007C3
    IL_02A0: ldfld 0x0400049F
    IL_02A1: ldloc.0
    IL_02A2: IL_8F
    IL_02A3: IL_57
    IL_02A4: nop
    IL_02A5: nop
    IL_02A6: ldarg.0
    IL_02AB: ldfld 0x0400049D
    IL_02AC: IL_94
    IL_02AD: ldarg.0
    IL_02B2: ldfld 0x040007C3
    IL_02B7: ldfld 0x0400049F
    IL_02B8: ldloc.0
    IL_02B9: IL_8F
    IL_02BA: IL_57
    IL_02BB: nop
    IL_02BC: nop
    IL_02BD: ldarg.0
    IL_02C2: ldfld 0x0400049E
    IL_02C3: IL_3F
    IL_02C4: ldloc.1
    IL_02C5: nop
    IL_02C6: nop
    IL_02C7: nop
    IL_02C8: ldarg.0
    IL_02C9: ldc.i4.1
    IL_02CE: stfld 0x040007C4
    IL_02D3: br IL_04E2
    IL_02D4: ldarg.0
    IL_02D9: ldfld 0x040007D5
    IL_02DA: ldarg.0
    IL_02DF: ldfld 0x040007C3
    IL_02E4: ldfld 0x0400049F
    IL_02E5: ldloc.0
    IL_02E6: IL_8F
    IL_02E7: IL_57
    IL_02E8: nop
    IL_02E9: nop
    IL_02EA: ldarg.0
    IL_02EF: ldfld 0x0400049E
    IL_02F0: IL_3F
    IL_02F1: ldloc.1
    IL_02F2: nop
    IL_02F3: nop
    IL_02F4: nop
    IL_02F5: ldarg.0
    IL_02F6: ldc.i4.1
    IL_02FB: stfld 0x040007C4
    IL_0300: br IL_04E2
    IL_0301: ldc.i4.0
    IL_0302: stloc.2
    IL_0303: ldc.i4.0
    IL_0304: stloc.3
    IL_0309: br IL_0320
    IL_030A: ldarg.0
    IL_030F: ldfld 0x040007C5
    IL_0310: ldloc.3
    IL_0311: IL_94
    IL_0312: ldc.i4.4
    IL_0313: IL_3F
    IL_0314: ldarg.2
    IL_0315: nop
    IL_0316: nop
    IL_0317: nop
    IL_0318: ldloc.2
    IL_0319: ldc.i4.1
    IL_031A: IL_58
    IL_031B: stloc.2
    IL_031C: ldloc.3
    IL_031D: ldc.i4.1
    IL_031E: IL_58
    IL_031F: stloc.3
    IL_0320: ldloc.3
    IL_0322: ldc.i4.s 30
    IL_0323: IL_3F
    IL_0324: IL_E2
    IL_0325: IL_FF
    IL_0326: IL_FF
    IL_0327: IL_FF
    IL_0328: ldloc.2
    IL_0329: ldc.i4.5
    IL_032A: IL_3F
    IL_032B: ldloc.1
    IL_032C: nop
    IL_032D: nop
    IL_032E: nop
    IL_032F: ldarg.0
    IL_0330: ldc.i4.1
    IL_0335: stfld 0x040007C4
    IL_033A: br IL_04E2
    IL_033B: ldc.i4.0
    IL_033D: stloc.s 4
    IL_033E: ldc.i4.0
    IL_0340: stloc.s 5
    IL_0345: br IL_0361
    IL_0346: ldarg.0
    IL_034B: ldfld 0x040007CC
    IL_034D: ldloc.s 5
    IL_034E: IL_94
    IL_034F: ldc.i4.0
    IL_0350: IL_3F
    IL_0351: ldloc.0
    IL_0352: nop
    IL_0353: nop
    IL_0354: nop
    IL_0356: ldloc.s 4
    IL_0357: ldc.i4.1
    IL_0358: IL_58
    IL_035A: stloc.s 4
    IL_035C: ldloc.s 5
    IL_035D: ldc.i4.1
    IL_035E: IL_58
    IL_0360: stloc.s 5
    IL_0362: ldloc.s 5
    IL_0364: ldc.i4.s 20
    IL_0365: IL_3F
    IL_0366: IL_DC
    IL_0367: IL_FF
    IL_0368: IL_FF
    IL_0369: IL_FF
    IL_036B: ldloc.s 4
    IL_036C: ldarg.0
    IL_0371: ldfld 0x040007C3
    IL_0376: ldfld 0x0400049F
    IL_0377: ldloc.0
    IL_0378: IL_8F
    IL_0379: IL_57
    IL_037A: nop
    IL_037B: nop
    IL_037C: ldarg.0
    IL_0381: ldfld 0x0400049E
    IL_0382: IL_3F
    IL_0383: ldloc.1
    IL_0384: nop
    IL_0385: nop
    IL_0386: nop
    IL_0387: ldarg.0
    IL_0388: ldc.i4.1
    IL_038D: stfld 0x040007C4
    IL_0392: br IL_04E2
    IL_0393: ldc.i4.0
    IL_0395: stloc.s 6
    IL_0396: ldc.i4.0
    IL_0398: stloc.s 7
    IL_039D: br IL_03B9
    IL_039E: ldarg.0
    IL_03A3: ldfld 0x040007CC
    IL_03A5: ldloc.s 7
    IL_03A6: IL_94
    IL_03A7: ldc.i4.4
    IL_03A8: IL_3F
    IL_03A9: ldloc.0
    IL_03AA: nop
    IL_03AB: nop
    IL_03AC: nop
    IL_03AE: ldloc.s 6
    IL_03AF: ldc.i4.1
    IL_03B0: IL_58
    IL_03B2: stloc.s 6
    IL_03B4: ldloc.s 7
    IL_03B5: ldc.i4.1
    IL_03B6: IL_58
    IL_03B8: stloc.s 7
    IL_03BA: ldloc.s 7
    IL_03BC: ldc.i4.s 20
    IL_03BD: IL_3F
    IL_03BE: IL_DC
    IL_03BF: IL_FF
    IL_03C0: IL_FF
    IL_03C1: IL_FF
    IL_03C3: ldloc.s 6
    IL_03C4: ldarg.0
    IL_03C9: ldfld 0x040007C3
    IL_03CE: ldfld 0x0400049F
    IL_03CF: ldloc.0
    IL_03D0: IL_8F
    IL_03D1: IL_57
    IL_03D2: nop
    IL_03D3: nop
    IL_03D4: ldarg.0
    IL_03D9: ldfld 0x0400049E
    IL_03DA: IL_3F
    IL_03DB: ldloc.1
    IL_03DC: nop
    IL_03DD: nop
    IL_03DE: nop
    IL_03DF: ldarg.0
    IL_03E0: ldc.i4.1
    IL_03E5: stfld 0x040007C4
    IL_03EA: br IL_04E2
    IL_03EB: ldarg.0
    IL_03F0: ldfld 0x040007D6
    IL_03F1: ldarg.0
    IL_03F6: ldfld 0x040007C3
    IL_03FB: ldfld 0x0400049F
    IL_03FC: ldloc.0
    IL_03FD: IL_8F
    IL_03FE: IL_57
    IL_03FF: nop
    IL_0400: nop
    IL_0401: ldarg.0
    IL_0406: ldfld 0x0400049E
    IL_0407: IL_3F
    IL_0408: ldloc.1
    IL_0409: nop
    IL_040A: nop
    IL_040B: nop
    IL_040C: ldarg.0
    IL_040D: ldc.i4.1
    IL_0412: stfld 0x040007C4
    IL_0417: br IL_04E2
    IL_0418: ldarg.0
    IL_041D: ldfld 0x040007D7
    IL_041E: ldarg.0
    IL_0423: ldfld 0x040007C3
    IL_0428: ldfld 0x0400049F
    IL_0429: ldloc.0
    IL_042A: IL_8F
    IL_042B: IL_57
    IL_042C: nop
    IL_042D: nop
    IL_042E: ldarg.0
    IL_0433: ldfld 0x0400049E
    IL_0434: IL_3F
    IL_0435: ldloc.1
    IL_0436: nop
    IL_0437: nop
    IL_0438: nop
    IL_0439: ldarg.0
    IL_043A: ldc.i4.1
    IL_043F: stfld 0x040007C4
    IL_0444: br IL_04E2
    IL_0445: ldarg.0
    IL_044A: ldfld 0x040007D2
    IL_044B: ldarg.0
    IL_0450: ldfld 0x040007C3
    IL_0455: ldfld 0x0400049F
    IL_0456: ldloc.0
    IL_0457: IL_8F
    IL_0458: IL_57
    IL_0459: nop
    IL_045A: nop
    IL_045B: ldarg.0
    IL_0460: ldfld 0x0400049E
    IL_0461: IL_3F
    IL_0462: ldloc.1
    IL_0463: nop
    IL_0464: nop
    IL_0465: nop
    IL_0466: ldarg.0
    IL_0467: ldc.i4.1
    IL_046C: stfld 0x040007C4
    IL_0471: br IL_04E2
    IL_0472: ldc.i4.0
    IL_0474: stloc.s 8
    IL_0475: ldc.i4.0
    IL_0477: stloc.s 9
    IL_047C: br IL_0498
    IL_047D: ldarg.0
    IL_0482: ldfld 0x040007C8
    IL_0484: ldloc.s 9
    IL_0485: IL_94
    IL_0486: ldc.i4.0
    IL_0487: IL_3E
    IL_0488: ldloc.0
    IL_0489: nop
    IL_048A: nop
    IL_048B: nop
    IL_048D: ldloc.s 8
    IL_048E: ldc.i4.1
    IL_048F: IL_58
    IL_0491: stloc.s 8
    IL_0493: ldloc.s 9
    IL_0494: ldc.i4.1
    IL_0495: IL_58
    IL_0497: stloc.s 9
    IL_0499: ldloc.s 9
    IL_049B: ldc.i4.s 20
    IL_049C: IL_3F
    IL_049D: IL_DC
    IL_049E: IL_FF
    IL_049F: IL_FF
    IL_04A0: IL_FF
    IL_04A2: ldloc.s 8
    IL_04A3: ldarg.0
    IL_04A8: ldfld 0x040007C3
    IL_04AD: ldfld 0x0400049F
    IL_04AE: ldloc.0
    IL_04AF: IL_8F
    IL_04B0: IL_57
    IL_04B1: nop
    IL_04B2: nop
    IL_04B3: ldarg.0
    IL_04B8: ldfld 0x0400049E
    IL_04B9: IL_3F
    IL_04BA: ldloc.1
    IL_04BB: nop
    IL_04BC: nop
    IL_04BD: nop
    IL_04BE: ldarg.0
    IL_04BF: ldc.i4.1
    IL_04C4: stfld 0x040007C4
    IL_04C9: br IL_04E2
    IL_04CA: ldarg.0
    IL_04CF: ldfld 0x040007D4
    IL_04D0: ldc.i4.0
    IL_04D1: IL_3D
    IL_04D2: ldloc.1
    IL_04D3: nop
    IL_04D4: nop
    IL_04D5: nop
    IL_04D6: ldarg.0
    IL_04D7: ldc.i4.1
    IL_04DC: stfld 0x040007C4
    IL_04E1: br IL_04E2
    IL_04E2: ldloc.0
    IL_04E3: ldc.i4.1
    IL_04E4: IL_58
    IL_04E5: stloc.0
    IL_04E6: ldloc.0
    IL_04E8: ldc.i4.s 76
    IL_04E9: IL_3F
    IL_04EC: ldloca 65531
    IL_04ED: IL_FF
    IL_04EE: ldarg.0
    IL_04F3: ldfld 0x040007C4
    IL_04F4: ret
    }

    public void FindTreasure() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001FC1
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x040007C6
    IL_0010: ldc.i4.0
    IL_0011: stloc.0
    IL_0012: ldc.i4.0
    IL_0013: stloc.1
    IL_0018: br IL_0083
    IL_0019: ldc.i4.0
    IL_001A: stloc.2
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040007C6
    IL_0021: ldc.i4.4
    IL_0022: ldloc.1
    IL_0023: IL_5A
    IL_0024: IL_94
    IL_0025: ldc.i4.0
    IL_0026: IL_3E
    IL_0027: ldarg.2
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldloc.2
    IL_002C: ldc.i4.1
    IL_002D: IL_58
    IL_002E: stloc.2
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040007C6
    IL_0035: ldc.i4.4
    IL_0036: ldloc.1
    IL_0037: IL_5A
    IL_0038: ldc.i4.1
    IL_0039: IL_58
    IL_003A: IL_94
    IL_003B: ldc.i4.0
    IL_003C: IL_3E
    IL_003D: ldarg.2
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0041: ldloc.2
    IL_0042: ldc.i4.1
    IL_0043: IL_58
    IL_0044: stloc.2
    IL_0045: ldarg.0
    IL_004A: ldfld 0x040007C6
    IL_004B: ldc.i4.4
    IL_004C: ldloc.1
    IL_004D: IL_5A
    IL_004E: ldc.i4.2
    IL_004F: IL_58
    IL_0050: IL_94
    IL_0051: ldc.i4.0
    IL_0052: IL_3E
    IL_0053: ldarg.2
    IL_0054: nop
    IL_0055: nop
    IL_0056: nop
    IL_0057: ldloc.2
    IL_0058: ldc.i4.1
    IL_0059: IL_58
    IL_005A: stloc.2
    IL_005B: ldarg.0
    IL_0060: ldfld 0x040007C6
    IL_0061: ldc.i4.4
    IL_0062: ldloc.1
    IL_0063: IL_5A
    IL_0064: ldc.i4.3
    IL_0065: IL_58
    IL_0066: IL_94
    IL_0067: ldc.i4.0
    IL_0068: IL_3E
    IL_0069: ldarg.2
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: ldloc.2
    IL_006E: ldc.i4.1
    IL_006F: IL_58
    IL_0070: stloc.2
    IL_0071: ldloc.2
    IL_0072: ldc.i4.4
    IL_0093: switch (7 cases)
    }

    }}
