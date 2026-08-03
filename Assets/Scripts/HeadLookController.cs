// Namespace: 
// Type: HeadLookController

    public class HeadLookController {{

    public object rootNode;
    public object segments;
    public object nonAffectedJoints;
    public object headLookVector;
    public object headUpVector;
    public object target;
    public object effect;
    public object overrideAnimation;

    public HeadLookController() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000042
    IL_000A: stfld 0x040006B4
    IL_000B: ldarg.0
    IL_0010: call 0x0A000007
    IL_0015: stfld 0x040006B5
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001E: stsfld 0x06B77D3F
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0021: ldarg.0
    IL_0026: call 0x0A000001
    IL_0027: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006B1
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_001D
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: call 0x0A000002
    IL_001C: stfld 0x040006B1
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040006B2
    IL_0023: stloc.1
    IL_0024: ldc.i4.0
    IL_0025: stloc.2
    IL_002A: br IL_0166
    IL_002B: ldloc.1
    IL_002C: ldloc.2
    IL_002D: ldelem.i
    IL_002E: stloc.0
    IL_002F: ldloc.0
    IL_0034: ldfld 0x040006A1
    IL_0035: conv.r8
    IL_0036: IL_CD
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: conv.r8
    IL_003B: pop
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: stloc.3
    IL_0040: ldloc.3
    IL_0045: call 0x0A000193
    IL_0047: stloc.s 4
    IL_0048: ldloc.0
    IL_004A: ldloc.s 4
    IL_004B: ldarg.0
    IL_0050: ldfld 0x040006B1
    IL_0051: conv.r8
    IL_0052: pop
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_005A: call 0x0A000194
    IL_005B: ldarg.0
    IL_0060: ldflda 0x040006B4
    IL_0065: call 0x0A000195
    IL_006A: call 0x0A000196
    IL_006F: stfld 0x040006AB
    IL_0070: ldloc.0
    IL_0072: ldloc.s 4
    IL_0073: ldarg.0
    IL_0078: ldfld 0x040006B1
    IL_0079: conv.r8
    IL_007A: pop
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_0082: call 0x0A000194
    IL_0083: ldarg.0
    IL_0088: ldflda 0x040006B5
    IL_008D: call 0x0A000195
    IL_0092: call 0x0A000196
    IL_0097: stfld 0x040006AC
    IL_0098: ldloc.0
    IL_0099: IL_22
    IL_009A: nop
    IL_009B: nop
    IL_009C: nop
    IL_009D: nop
    IL_00A2: stfld 0x040006A8
    IL_00A3: ldloc.0
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: nop
    IL_00AD: stfld 0x040006A9
    IL_00AE: ldloc.0
    IL_00AF: ldloc.0
    IL_00B4: ldfld 0x040006AC
    IL_00B9: stfld 0x040006AA
    IL_00BA: ldloc.0
    IL_00BB: ldc.i4.1
    IL_00C0: stfld 0x040006AD
    IL_00C1: ldloc.0
    IL_00C6: ldfld 0x040006A2
    IL_00C8: stloc.s 5
    IL_00CD: br IL_00E5
    IL_00CE: ldloc.0
    IL_00CF: dup
    IL_00D4: ldfld 0x040006AD
    IL_00D5: ldc.i4.1
    IL_00D6: IL_58
    IL_00DB: stfld 0x040006AD
    IL_00DD: ldloc.s 5
    IL_00DE: conv.r8
    IL_00DF: IL_CD
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: stloc.0
    IL_00E4: stloc.s 5
    IL_00E6: ldloc.s 5
    IL_00E7: ldloc.0
    IL_00EC: ldfld 0x040006A1
    IL_00F1: call 0x0A000021
    IL_00F6: brfalse IL_010A
    IL_00F8: ldloc.s 5
    IL_00FA: ldloc.s 5
    IL_00FB: conv.r8
    IL_00FC: IL_44
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: stloc.0
    IL_0104: call 0x0A000021
    IL_0109: brtrue IL_00CE
    IL_010A: ldloc.0
    IL_010B: ldloc.0
    IL_0110: ldfld 0x040006AD
    IL_0115: newarr 0x0100000F
    IL_011A: stfld 0x040006AE
    IL_011B: ldloc.0
    IL_0120: ldfld 0x040006A2
    IL_0122: stloc.s 5
    IL_0123: ldloc.0
    IL_0128: ldfld 0x040006AD
    IL_0129: ldc.i4.1
    IL_012A: IL_59
    IL_012C: stloc.s 6
    IL_0131: br IL_015A
    IL_0132: ldloc.0
    IL_0137: ldfld 0x040006AE
    IL_0139: ldloc.s 6
    IL_013A: IL_8F
    IL_013C: ldarga.s 0
    IL_013D: nop
    IL_013E: IL_01
    IL_0140: ldloc.s 5
    IL_0141: conv.r8
    IL_0142: ldloc.1
    IL_0143: IL_01
    IL_0144: nop
    IL_0145: stloc.0
    IL_0146: IL_81
    IL_0148: ldarga.s 0
    IL_0149: nop
    IL_014A: IL_01
    IL_014C: ldloc.s 5
    IL_014D: conv.r8
    IL_014E: IL_CD
    IL_014F: nop
    IL_0150: nop
    IL_0151: stloc.0
    IL_0153: stloc.s 5
    IL_0155: ldloc.s 6
    IL_0156: ldc.i4.1
    IL_0157: IL_59
    IL_0159: stloc.s 6
    IL_015B: ldloc.s 6
    IL_015C: ldc.i4.0
    IL_015D: IL_3C
    IL_0162: ldtoken 0x08FFFFFF
    IL_0163: ldc.i4.1
    IL_0164: IL_58
    IL_0165: stloc.2
    IL_0166: ldloc.2
    IL_0167: ldloc.1
    IL_0168: len
    IL_0169: not
    IL_016A: IL_3F
    IL_016B: IL_BC
    IL_016D: 0xFE FF
    IL_016E: IL_FF
    IL_016F: ret
    }

    private void LateUpdate() {
    IL_0004: call 0x0A000024
    IL_0005: IL_22
    IL_0006: nop
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_0012: switch (1 cases)
    IL_0013: ldloc.0
    IL_0014: nop
    IL_0015: ldarg.2
    IL_0016: len
    IL_0017: not
    IL_001C: newarr 0x01000007
    IL_001D: stloc.0
    IL_001E: ldc.i4.0
    IL_001F: stloc.1
    IL_0024: br IL_00A0
    IL_0025: ldarg.0
    IL_002A: ldfld 0x040006B3
    IL_002B: ldloc.1
    IL_002C: ldelem.i
    IL_0031: ldfld 0x040006AF
    IL_0032: conv.r8
    IL_0033: IL_97
    IL_0034: IL_01
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: stloc.3
    IL_003C: br IL_0077
    IL_003D: ldloc.3
    IL_003E: conv.r8
    IL_003F: IL_98
    IL_0040: IL_01
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: conv.u4
    IL_0044: ldarg.1
    IL_0045: nop
    IL_0046: nop
    IL_0047: IL_01
    IL_0048: stloc.2
    IL_0049: ldloc.0
    IL_004A: ldloc.1
    IL_004B: IL_8F
    IL_004C: ldloc.1
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_01
    IL_0050: ldloc.2
    IL_0051: conv.r8
    IL_0052: ldc.i4.2
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x040006B3
    IL_005C: ldloc.1
    IL_005D: ldelem.i
    IL_0062: ldfld 0x040006AF
    IL_0063: conv.r8
    IL_0064: ldc.i4.2
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_006C: call 0x0A000019
    IL_006D: IL_81
    IL_006E: ldloc.1
    IL_006F: nop
    IL_0070: nop
    IL_0071: IL_01
    IL_0076: br IL_0082
    IL_0077: ldloc.3
    IL_0078: conv.r8
    IL_0079: IL_99
    IL_007A: IL_01
    IL_007B: nop
    IL_007C: stloc.0
    IL_0081: brtrue IL_003D
    IL_0082: IL_DD
    IL_0083: ldc.i4.m1
    IL_0084: nop
    IL_0085: nop
    IL_0086: nop
    IL_0087: ldloc.3
    IL_0088: conv.u8
    IL_008A: brfalse.s IL_008B
    IL_008B: nop
    IL_008C: IL_01
    IL_008E: stloc.s 30
    IL_0090: ldloc.s 30
    IL_0092: brtrue.s IL_0094
    IL_0093: IL_DC
    IL_0095: ldloc.s 30
    IL_0096: conv.r8
    IL_0097: ldelem.ref
    IL_0098: nop
    IL_0099: nop
    IL_009A: stloc.0
    IL_009B: IL_DC
    IL_009C: ldloc.1
    IL_009D: ldc.i4.1
    IL_009E: IL_58
    IL_009F: stloc.1
    IL_00A0: ldloc.1
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x040006B3
    IL_00A7: len
    IL_00A8: not
    IL_00A9: IL_3F
    IL_00AA: IL_77
    IL_00AB: IL_FF
    IL_00AC: IL_FF
    IL_00AD: IL_FF
    IL_00AE: ldarg.0
    IL_00B3: ldfld 0x040006B2
    IL_00B5: stloc.s 5
    IL_00B6: ldc.i4.0
    IL_00B8: stloc.s 6
    IL_00BD: br IL_0419
    IL_00BF: ldloc.s 5
    IL_00C1: ldloc.s 6
    IL_00C2: ldelem.i
    IL_00C4: stloc.s 4
    IL_00C6: ldloc.s 4
    IL_00CB: ldfld 0x040006A2
    IL_00CD: stloc.s 7
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x040006B8
    IL_00D8: brfalse IL_011A
    IL_00DA: ldloc.s 4
    IL_00DF: ldfld 0x040006AD
    IL_00E0: ldc.i4.1
    IL_00E1: IL_59
    IL_00E3: stloc.s 8
    IL_00E8: br IL_0112
    IL_00EA: ldloc.s 7
    IL_00EC: ldloc.s 4
    IL_00F1: ldfld 0x040006AE
    IL_00F3: ldloc.s 8
    IL_00F4: IL_8F
    IL_00F6: ldarga.s 0
    IL_00F7: nop
    IL_00F8: IL_01
    IL_00FD: ldobj 0x0100000F
    IL_00FE: conv.r8
    IL_0100: ldarga.s 1
    IL_0101: nop
    IL_0102: stloc.0
    IL_0104: ldloc.s 7
    IL_0105: conv.r8
    IL_0106: IL_CD
    IL_0107: nop
    IL_0108: nop
    IL_0109: stloc.0
    IL_010B: stloc.s 7
    IL_010D: ldloc.s 8
    IL_010E: ldc.i4.1
    IL_010F: IL_59
    IL_0111: stloc.s 8
    IL_0113: ldloc.s 8
    IL_0114: ldc.i4.0
    IL_0115: IL_3C
    IL_0116: IL_CF
    IL_0117: IL_FF
    IL_0118: IL_FF
    IL_0119: IL_FF
    IL_011B: ldloc.s 4
    IL_0120: ldfld 0x040006A1
    IL_0121: conv.r8
    IL_0122: IL_CD
    IL_0123: nop
    IL_0124: nop
    IL_0125: stloc.0
    IL_0126: conv.r8
    IL_0127: pop
    IL_0128: nop
    IL_0129: nop
    IL_012A: stloc.0
    IL_012C: stloc.s 9
    IL_012E: ldloc.s 9
    IL_0133: call 0x0A000193
    IL_0135: stloc.s 10
    IL_0136: ldarg.0
    IL_013B: ldfld 0x040006B6
    IL_013C: conv.r8
    IL_013D: ldc.i4.2
    IL_013E: nop
    IL_013F: nop
    IL_0140: stloc.0
    IL_0142: ldloc.s 4
    IL_0147: ldfld 0x040006A2
    IL_0148: conv.r8
    IL_0149: ldc.i4.2
    IL_014A: nop
    IL_014B: nop
    IL_014C: stloc.0
    IL_0151: call 0x0A000019
    IL_0153: stloc.s 31
    IL_0155: ldloca.s 31
    IL_015A: call 0x0A000195
    IL_015C: stloc.s 11
    IL_015E: ldloc.s 10
    IL_0160: ldloc.s 11
    IL_0165: call 0x0A000196
    IL_0167: stloc.s 12
    IL_0169: ldloc.s 4
    IL_016E: ldfld 0x040006AB
    IL_0170: ldloc.s 12
    IL_0172: ldloc.s 4
    IL_0177: ldfld 0x040006AC
    IL_017C: call 0x06000311
    IL_017E: stloc.s 13
    IL_0180: ldloc.s 4
    IL_0185: ldfld 0x040006AC
    IL_0187: ldloc.s 12
    IL_018C: call 0x0A00019A
    IL_018E: stloc.s 14
    IL_0190: ldloc.s 12
    IL_0192: ldloc.s 12
    IL_0194: ldloc.s 4
    IL_0199: ldfld 0x040006AC
    IL_019E: call 0x0A00019B
    IL_01A3: call 0x0A000019
    IL_01A5: stloc.s 15
    IL_01A7: ldloc.s 15
    IL_01A9: ldloc.s 12
    IL_01AB: ldloc.s 14
    IL_01B0: call 0x06000311
    IL_01B2: stloc.s 16
    IL_01B3: IL_22
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: nop
    IL_01B7: nop
    IL_01B9: ldloc.s 13
    IL_01BE: call 0x0A00007F
    IL_01C0: ldloc.s 4
    IL_01C5: ldfld 0x040006A3
    IL_01C6: IL_59
    IL_01CB: call 0x0A00019C
    IL_01CD: ldloc.s 13
    IL_01D2: call 0x0A00019D
    IL_01D3: IL_5A
    IL_01D5: stloc.s 17
    IL_01D6: IL_22
    IL_01D7: nop
    IL_01D8: nop
    IL_01D9: nop
    IL_01DA: nop
    IL_01DC: ldloc.s 16
    IL_01E1: call 0x0A00007F
    IL_01E3: ldloc.s 4
    IL_01E8: ldfld 0x040006A3
    IL_01E9: IL_59
    IL_01EE: call 0x0A00019C
    IL_01F0: ldloc.s 16
    IL_01F5: call 0x0A00019D
    IL_01F6: IL_5A
    IL_01F8: stloc.s 18
    IL_01FA: ldloc.s 17
    IL_01FF: call 0x0A00007F
    IL_0201: ldloc.s 4
    IL_0206: ldfld 0x040006A4
    IL_020B: call 0x0A00007F
    IL_020C: IL_5A
    IL_020E: ldloc.s 13
    IL_0213: call 0x0A00007F
    IL_0215: ldloc.s 4
    IL_021A: ldfld 0x040006A5
    IL_021B: IL_59
    IL_0220: call 0x0A00019C
    IL_0222: ldloc.s 13
    IL_0227: call 0x0A00019D
    IL_0228: IL_5A
    IL_022A: ldloc.s 4
    IL_022F: ldfld 0x040006A4
    IL_0234: call 0x0A00019D
    IL_0235: IL_5A
    IL_0237: stloc.s 13
    IL_0239: ldloc.s 18
    IL_023E: call 0x0A00007F
    IL_0240: ldloc.s 4
    IL_0245: ldfld 0x040006A4
    IL_024A: call 0x0A00007F
    IL_024B: IL_5A
    IL_024D: ldloc.s 16
    IL_0252: call 0x0A00007F
    IL_0254: ldloc.s 4
    IL_0259: ldfld 0x040006A5
    IL_025A: IL_59
    IL_025F: call 0x0A00019C
    IL_0261: ldloc.s 16
    IL_0266: call 0x0A00019D
    IL_0267: IL_5A
    IL_0269: ldloc.s 4
    IL_026E: ldfld 0x040006A4
    IL_0273: call 0x0A00019D
    IL_0274: IL_5A
    IL_0276: stloc.s 16
    IL_0278: ldloc.s 13
    IL_027A: ldloc.s 4
    IL_027F: ldfld 0x040006A6
    IL_0280: shl
    IL_0282: ldloc.s 4
    IL_0287: ldfld 0x040006A6
    IL_028C: call 0x0A0000D4
    IL_028E: stloc.s 13
    IL_0290: ldloc.s 16
    IL_0292: ldloc.s 4
    IL_0297: ldfld 0x040006A6
    IL_0298: shl
    IL_029A: ldloc.s 4
    IL_029F: ldfld 0x040006A6
    IL_02A4: call 0x0A0000D4
    IL_02A6: stloc.s 16
    IL_02A8: ldloc.s 4
    IL_02AD: ldfld 0x040006AC
    IL_02AF: ldloc.s 4
    IL_02B4: ldfld 0x040006AB
    IL_02B9: call 0x0A00019A
    IL_02BB: stloc.s 19
    IL_02BD: ldloc.s 4
    IL_02BF: ldloc.s 4
    IL_02C4: ldfld 0x040006A8
    IL_02C6: ldloc.s 13
    IL_02CB: call 0x0A000024
    IL_02CD: ldloc.s 4
    IL_02D2: ldfld 0x040006A7
    IL_02D3: IL_5A
    IL_02D8: call 0x0A000025
    IL_02DD: stfld 0x040006A8
    IL_02DF: ldloc.s 4
    IL_02E1: ldloc.s 4
    IL_02E6: ldfld 0x040006A9
    IL_02E8: ldloc.s 16
    IL_02ED: call 0x0A000024
    IL_02EF: ldloc.s 4
    IL_02F4: ldfld 0x040006A7
    IL_02F5: IL_5A
    IL_02FA: call 0x0A000025
    IL_02FF: stfld 0x040006A9
    IL_0301: ldloc.s 4
    IL_0306: ldfld 0x040006A8
    IL_0308: ldloc.s 4
    IL_030D: ldfld 0x040006AC
    IL_0312: call 0x0A00019E
    IL_0314: ldloc.s 4
    IL_0319: ldfld 0x040006A9
    IL_031B: ldloc.s 19
    IL_0320: call 0x0A00019E
    IL_0325: call 0x0A000194
    IL_0327: ldloc.s 4
    IL_032C: ldfld 0x040006AB
    IL_0331: call 0x0A000196
    IL_0333: stloc.s 12
    IL_0335: ldloc.s 4
    IL_033A: ldfld 0x040006AC
    IL_033C: stloc.s 20
    IL_033E: ldloca.s 12
    IL_0340: ldloca.s 20
    IL_0345: call 0x0A00019F
    IL_0347: ldloc.s 12
    IL_0349: stloc.s 21
    IL_034B: ldloc.s 4
    IL_034D: ldloc.s 4
    IL_0352: ldfld 0x040006AA
    IL_0354: ldloc.s 20
    IL_0359: call 0x0A000024
    IL_035A: IL_22
    IL_035B: nop
    IL_035C: nop
    IL_035D: ldelem.r8
    IL_680A4CA: switch (27273306 cases)
    }

    public static void AngleAroundAxis() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0007: call 0x0A00019B
    IL_000C: call 0x0A000019
    IL_000E: starg.s 0
    IL_000F: ldarg.1
    IL_0010: ldarg.1
    IL_0011: ldarg.2
    IL_0016: call 0x0A00019B
    IL_001B: call 0x0A000019
    IL_001D: starg.s 1
    IL_001E: ldarg.0
    IL_001F: ldarg.1
    IL_0024: call 0x0A0001A2
    IL_0025: stloc.0
    IL_0026: ldloc.0
    IL_0027: ldarg.2
    IL_0028: ldarg.0
    IL_0029: ldarg.1
    IL_002E: call 0x0A00019A
    IL_0033: call 0x0A000113
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: IL_41
    IL_003A: ldloc.0
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: ldc.i4.m1
    IL_0043: br IL_0045
    IL_0044: ldc.i4.1
    IL_0045: conv.i2
    IL_0046: IL_5A
    IL_0047: ret
    }

    }}
