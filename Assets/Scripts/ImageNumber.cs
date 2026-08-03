// Namespace: 
// Type: ImageNumber

    public class ImageNumber {{

    private static object NUMBERSCALE;
    private object imagesetUV;
    private object imagenumber;
    public object number;
    private object finalnum;
    private object size_a;
    private object thismesh;

    public ImageNumber() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 11
    IL_0007: newarr 0x01000014
    IL_0008: dup
    IL_0009: ldc.i4.0
    IL_000A: IL_8F
    IL_000B: ldnull
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_01
    IL_000F: IL_22
    IL_0010: nop
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_0017: rem
    IL_0018: IL_3F
    IL_001D: newobj 0x0A000038
    IL_001E: IL_81
    IL_001F: ldnull
    IL_0020: nop
    IL_0021: nop
    IL_0022: IL_01
    IL_0023: dup
    IL_0024: ldc.i4.1
    IL_0025: IL_8F
    IL_0026: ldnull
    IL_0027: nop
    IL_0028: nop
    IL_0029: IL_01
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_3E
    IL_002F: IL_22
    IL_0030: nop
    IL_0031: nop
    IL_0032: rem
    IL_0033: IL_3F
    IL_0038: newobj 0x0A000038
    IL_0039: IL_81
    IL_003A: ldnull
    IL_003B: nop
    IL_003C: nop
    IL_003D: IL_01
    IL_003E: dup
    IL_003F: ldc.i4.2
    IL_0040: IL_8F
    IL_0041: ldnull
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_01
    IL_0045: IL_22
    IL_0046: nop
    IL_0047: nop
    IL_004C: stsfld 0x0000223E
    IL_004D: rem
    IL_004E: IL_3F
    IL_0053: newobj 0x0A000038
    IL_0054: IL_81
    IL_0055: ldnull
    IL_0056: nop
    IL_0057: nop
    IL_0058: IL_01
    IL_0059: dup
    IL_005A: ldc.i4.3
    IL_005B: IL_8F
    IL_005C: ldnull
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_01
    IL_0060: IL_22
    IL_0061: nop
    IL_0062: nop
    IL_0063: IL_C0
    IL_0064: IL_3E
    IL_0065: IL_22
    IL_0066: nop
    IL_0067: nop
    IL_0068: rem
    IL_0069: IL_3F
    IL_006E: newobj 0x0A000038
    IL_006F: IL_81
    IL_0070: ldnull
    IL_0071: nop
    IL_0072: nop
    IL_0073: IL_01
    IL_0074: dup
    IL_0075: ldc.i4.4
    IL_0076: IL_8F
    IL_0077: ldnull
    IL_0078: nop
    IL_0079: nop
    IL_007A: IL_01
    IL_007B: IL_22
    IL_007C: nop
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_3F
    IL_0080: IL_22
    IL_0081: nop
    IL_0082: nop
    IL_0083: rem
    IL_0084: IL_3F
    IL_0089: newobj 0x0A000038
    IL_008A: IL_81
    IL_008B: ldnull
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_01
    IL_008F: dup
    IL_0090: ldc.i4.5
    IL_0091: IL_8F
    IL_0092: ldnull
    IL_0093: nop
    IL_0094: nop
    IL_0095: IL_01
    IL_0096: IL_22
    IL_0097: nop
    IL_0098: nop
    IL_0099: nop
    IL_009A: nop
    IL_009B: IL_22
    IL_009C: nop
    IL_009D: nop
    IL_E1CD9E: switch (3699519 cases)
    }

    private void Start() {
    IL_0000: ret
    }

    public void ImageNum() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000016
    IL_0007: conv.r8
    IL_0008: IL_A9
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x04000730
    IL_0011: ldarg.0
    IL_0012: ldc.i4.0
    IL_0017: stfld 0x0400072F
    IL_0018: ldc.i4.0
    IL_0019: stloc.0
    IL_001E: br IL_004A
    IL_001F: ldarg.0
    IL_0024: ldfld 0x0400072D
    IL_0025: ldloc.0
    IL_0026: ldarg.1
    IL_0028: ldc.i4.s 10
    IL_0029: mul
    IL_002A: ldelem.i8
    IL_002B: ldarg.1
    IL_002D: ldc.i4.s 10
    IL_002E: add
    IL_0030: starg.s 1
    IL_0031: ldarg.1
    IL_0036: brfalse IL_0046
    IL_0037: ldarg.0
    IL_0038: dup
    IL_003D: ldfld 0x0400072F
    IL_003E: ldc.i4.1
    IL_003F: IL_58
    IL_0040: neg
    IL_0045: stfld 0x0400072F
    IL_0046: ldloc.0
    IL_0047: ldc.i4.1
    IL_0048: IL_58
    IL_0049: stloc.0
    IL_004A: ldloc.0
    IL_004B: ldc.i4.3
    IL_004C: IL_3F
    IL_004D: IL_CE
    IL_004E: IL_FF
    IL_004F: IL_FF
    IL_0050: IL_FF
    IL_0051: ldarg.0
    IL_0052: ldarg.0
    IL_0057: ldfld 0x0400072D
    IL_0058: ldarg.2
    IL_0059: IL_94
    IL_005E: stfld 0x0400072E
    IL_005F: ldarg.0
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400072B
    IL_0066: ldarg.0
    IL_006B: ldfld 0x0400072E
    IL_006C: IL_8F
    IL_006D: ldnull
    IL_006E: nop
    IL_006F: nop
    IL_0070: IL_01
    IL_0075: ldobj 0x01000014
    IL_007A: stfld 0x0400072C
    IL_007B: ldarg.1
    IL_0080: brtrue IL_008C
    IL_0081: ldarg.2
    IL_0086: brtrue IL_008C
    IL_008B: br IL_00BB
    IL_008C: ldarg.2
    IL_008D: ldarg.0
    IL_0092: ldfld 0x0400072F
    IL_0093: IL_3F
    IL_0094: IL_23
    IL_0095: nop
    IL_0096: nop
    IL_0097: nop
    IL_0098: ldarg.0
    IL_009D: ldfld 0x0400072E
    IL_00A2: brtrue IL_00BB
    IL_00A3: ldarg.0
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x0400072B
    IL_00AB: ldc.i4.s 10
    IL_00AC: IL_8F
    IL_00AD: ldnull
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: IL_01
    IL_00B5: ldobj 0x01000014
    IL_00BA: stfld 0x0400072C
    IL_00BB: ldarg.3
    IL_00BC: stloc.1
    IL_00BD: ldloc.1
    IL_00C2: brfalse IL_00CF
    IL_00C3: ldloc.1
    IL_00C4: ldc.i4.1
    IL_00C9: beq IL_0169
    IL_00CE: br IL_027B
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x04000730
    IL_00D5: ldc.i4.4
    IL_00DA: newarr 0x01000014
    IL_00DB: dup
    IL_00DC: ldc.i4.0
    IL_00DD: IL_8F
    IL_00DE: ldnull
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_01
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x0400072C
    IL_00EC: call 0x0A0000AA
    IL_00ED: IL_22
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: nop
    IL_00F1: IL_3E
    IL_00F6: call 0x0A000083
    IL_00FB: call 0x0A0000AB
    IL_00FC: IL_81
    IL_00FD: ldnull
    IL_00FE: nop
    IL_00FF: nop
    IL_0100: IL_01
    IL_0101: dup
    IL_0102: ldc.i4.1
    IL_0103: IL_8F
    IL_0104: ldnull
    IL_0105: nop
    IL_0106: nop
    IL_0107: IL_01
    IL_0108: ldarg.0
    IL_010D: ldfld 0x0400072C
    IL_0112: call 0x0A0000FA
    IL_0113: IL_22
    IL_0114: nop
    IL_0115: nop
    IL_0116: nop
    IL_0117: IL_3E
    IL_011C: call 0x0A000083
    IL_0121: call 0x0A0000AB
    IL_0122: IL_81
    IL_0123: ldnull
    IL_0124: nop
    IL_0125: nop
    IL_0126: IL_01
    IL_0127: dup
    IL_0128: ldc.i4.2
    IL_0129: IL_8F
    IL_012A: ldnull
    IL_012B: nop
    IL_012C: nop
    IL_012D: IL_01
    IL_012E: ldarg.0
    IL_0133: ldfld 0x0400072C
    IL_0134: IL_81
    IL_0135: ldnull
    IL_0136: nop
    IL_0137: nop
    IL_0138: IL_01
    IL_0139: dup
    IL_013A: ldc.i4.3
    IL_013B: IL_8F
    IL_013C: ldnull
    IL_013D: nop
    IL_013E: nop
    IL_013F: IL_01
    IL_0140: ldarg.0
    IL_0145: ldfld 0x0400072C
    IL_014A: call 0x0A000082
    IL_014B: IL_22
    IL_014C: nop
    IL_014D: nop
    IL_014E: nop
    IL_014F: IL_3E
    IL_0154: call 0x0A000083
    IL_0159: call 0x0A0000AB
    IL_015A: IL_81
    IL_015B: ldnull
    IL_015C: nop
    IL_015D: nop
    IL_015E: IL_01
    IL_015F: conv.r8
    IL_0160: IL_AC
    IL_0161: nop
    IL_0162: nop
    IL_0163: stloc.0
    IL_0168: br IL_027B
    IL_0169: ldarg.0
    IL_016E: ldfld 0x04000730
    IL_016F: ldc.i4.4
    IL_0174: newarr 0x01000014
    IL_0175: dup
    IL_0176: ldc.i4.0
    IL_0177: IL_8F
    IL_0178: ldnull
    IL_0179: nop
    IL_017A: nop
    IL_017B: IL_01
    IL_017C: ldarg.0
    IL_0181: ldfld 0x0400072C
    IL_0182: IL_22
    IL_0183: nop
    IL_0184: nop
    IL_0185: nop
    IL_0186: IL_3F
    IL_018B: call 0x0A000083
    IL_0190: call 0x0A0000AA
    IL_0191: IL_22
    IL_0192: nop
    IL_0193: nop
    IL_0198: stsfld 0x0083283D
    IL_0199: nop
    IL_019A: stloc.0
    IL_019F: call 0x0A0000AB
    IL_01A4: call 0x0A0000AA
    IL_01A5: IL_22
    IL_01A6: nop
    IL_01A7: nop
    IL_01AC: stsfld 0x0083283E
    IL_01AD: nop
    IL_01AE: stloc.0
    IL_01B3: call 0x0A0000AB
    IL_01B4: IL_81
    IL_01B5: ldnull
    IL_01B6: nop
    IL_01B7: nop
    IL_01B8: IL_01
    IL_01B9: dup
    IL_01BA: ldc.i4.1
    IL_01BB: IL_8F
    IL_01BC: ldnull
    IL_01BD: nop
    IL_01BE: nop
    IL_01BF: IL_01
    IL_01C0: ldarg.0
    IL_01C5: ldfld 0x0400072C
    IL_01C6: IL_22
    IL_01C7: nop
    IL_01C8: nop
    IL_01C9: nop
    IL_01CA: IL_3F
    IL_01CF: call 0x0A000083
    IL_01D4: call 0x0A0000FA
    IL_01D5: IL_22
    IL_01D6: nop
    IL_01D7: nop
    IL_01DC: stsfld 0x0083283D
    IL_01DD: nop
    IL_01DE: stloc.0
    IL_01E3: call 0x0A0000AB
    IL_01E8: call 0x0A0000AA
    IL_01E9: IL_22
    IL_01EA: nop
    IL_01EB: nop
    IL_01F0: stsfld 0x0083283E
    IL_01F1: nop
    IL_01F2: stloc.0
    IL_01F7: call 0x0A0000AB
    IL_01F8: IL_81
    IL_01F9: ldnull
    IL_01FA: nop
    IL_01FB: nop
    IL_01FC: IL_01
    IL_01FD: dup
    IL_01FE: ldc.i4.2
    IL_01FF: IL_8F
    IL_0200: ldnull
    IL_0201: nop
    IL_0202: nop
    IL_0203: IL_01
    IL_0204: ldarg.0
    IL_0209: ldfld 0x0400072C
    IL_020A: IL_22
    IL_020B: nop
    IL_020C: nop
    IL_020D: nop
    IL_020E: IL_3F
    IL_0213: call 0x0A000083
    IL_0218: call 0x0A0000AA
    IL_0219: IL_22
    IL_021A: nop
    IL_021B: nop
    IL_0220: stsfld 0x0083283E
    IL_0221: nop
    IL_0222: stloc.0
    IL_0227: call 0x0A0000AB
    IL_0228: IL_81
    IL_0229: ldnull
    IL_022A: nop
    IL_022B: nop
    IL_022C: IL_01
    IL_022D: dup
    IL_022E: ldc.i4.3
    IL_022F: IL_8F
    IL_0230: ldnull
    IL_0231: nop
    IL_0232: nop
    IL_0233: IL_01
    IL_0234: ldarg.0
    IL_0239: ldfld 0x0400072C
    IL_023A: IL_22
    IL_023B: nop
    IL_023C: nop
    IL_023D: nop
    IL_023E: IL_3F
    IL_0243: call 0x0A000083
    IL_0248: call 0x0A000082
    IL_0249: IL_22
    IL_024A: nop
    IL_024B: nop
    IL_0250: stsfld 0x0083283D
    IL_0251: nop
    IL_0252: stloc.0
    IL_0257: call 0x0A0000AB
    IL_025C: call 0x0A0000AA
    IL_025D: IL_22
    IL_025E: nop
    IL_025F: nop
    IL_0264: stsfld 0x0083283E
    IL_0265: nop
    IL_0266: stloc.0
    IL_026B: call 0x0A0000AB
    IL_026C: IL_81
    IL_026D: ldnull
    IL_026E: nop
    IL_026F: nop
    IL_0270: IL_01
    IL_0271: conv.r8
    IL_0272: IL_AC
    IL_0273: nop
    IL_0274: nop
    IL_0275: stloc.0
    IL_027A: br IL_027B
    IL_027B: ret
    }

    }}
