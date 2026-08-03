// Namespace: 
// Type: CombineMesh

    public class CombineMesh {{

    private object meshFilter;
    private object mytransform;
    public object splitmesh;

    public CombineMesh() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400042A
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000016
    IL_0017: stfld 0x04000429
    IL_0018: ret
    }

    public void CreatSplitMesh() {
    IL_0004: ldstr 0x70001E71
    IL_0009: newobj 0x0A00013F
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: conv.r8
    IL_000D: ldarg.3
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: stloc.1
    IL_0012: ldloc.0
    IL_0013: conv.r8
    IL_0014: IL_43
    IL_0015: nop
    IL_0016: nop
    IL_0018: br.s IL_0025
    IL_0019: ldc.i4.0
    IL_001A: ldc.i4.2
    IL_001F: call 0x0A000045
    IL_0020: stloc.3
    IL_0021: ldc.i4.0
    IL_0022: ldc.i4.2
    IL_0027: call 0x0A000045
    IL_0029: stloc.s 4
    IL_002A: ldarg.0
    IL_002F: ldfld 0x0400042B
    IL_0030: ldc.i4.4
    IL_0035: newarr 0x01000014
    IL_0036: dup
    IL_0037: ldc.i4.0
    IL_0038: IL_8F
    IL_0039: ldnull
    IL_003A: nop
    IL_003B: nop
    IL_003C: IL_01
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: ldloc.3
    IL_0043: conv.i2
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: IL_3F
    IL_0049: IL_5A
    IL_004A: IL_58
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_3F
    IL_0051: ldloc.s 4
    IL_0052: conv.i2
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0056: nop
    IL_0057: IL_3F
    IL_0058: IL_5A
    IL_0059: IL_58
    IL_005E: newobj 0x0A000038
    IL_005F: IL_81
    IL_0060: ldnull
    IL_0061: nop
    IL_0062: nop
    IL_0063: IL_01
    IL_0064: dup
    IL_0065: ldc.i4.1
    IL_0066: IL_8F
    IL_0067: ldnull
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_01
    IL_006B: IL_22
    IL_006C: nop
    IL_006D: nop
    IL_006E: nop
    IL_006F: IL_3F
    IL_0070: ldloc.3
    IL_0071: conv.i2
    IL_0072: IL_22
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_0076: IL_3F
    IL_0077: IL_5A
    IL_0078: IL_58
    IL_0079: IL_22
    IL_007A: nop
    IL_007B: nop
    IL_007C: nop
    IL_007D: IL_3F
    IL_007F: ldloc.s 4
    IL_0080: conv.i2
    IL_0081: IL_22
    IL_0082: nop
    IL_0083: nop
    IL_0084: nop
    IL_0085: IL_3F
    IL_0086: IL_5A
    IL_0087: IL_58
    IL_008C: newobj 0x0A000038
    IL_008D: IL_81
    IL_008E: ldnull
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_01
    IL_0092: dup
    IL_0093: ldc.i4.2
    IL_0094: IL_8F
    IL_0095: ldnull
    IL_0096: nop
    IL_0097: nop
    IL_0098: IL_01
    IL_0099: IL_22
    IL_009A: nop
    IL_009B: nop
    IL_009C: nop
    IL_009D: nop
    IL_009E: ldloc.3
    IL_009F: conv.i2
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: IL_3F
    IL_00A5: IL_5A
    IL_00A6: IL_58
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: nop
    IL_00AD: ldloc.s 4
    IL_00AE: conv.i2
    IL_00AF: IL_22
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: IL_3F
    IL_00B4: IL_5A
    IL_00B5: IL_58
    IL_00BA: newobj 0x0A000038
    IL_00BB: IL_81
    IL_00BC: ldnull
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: IL_01
    IL_00C0: dup
    IL_00C1: ldc.i4.3
    IL_00C2: IL_8F
    IL_00C3: ldnull
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: IL_01
    IL_00C7: IL_22
    IL_00C8: nop
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: IL_3F
    IL_00CC: ldloc.3
    IL_00CD: conv.i2
    IL_00CE: IL_22
    IL_00CF: nop
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: IL_3F
    IL_00D3: IL_5A
    IL_00D4: IL_58
    IL_00D5: IL_22
    IL_00D6: nop
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: nop
    IL_00DB: ldloc.s 4
    IL_00DC: conv.i2
    IL_00DD: IL_22
    IL_00DE: nop
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_3F
    IL_00E2: IL_5A
    IL_00E3: IL_58
    IL_00E8: newobj 0x0A000038
    IL_00E9: IL_81
    IL_00EA: ldnull
    IL_00EB: nop
    IL_00EC: nop
    IL_00ED: IL_01
    IL_00EE: conv.r8
    IL_00EF: IL_AC
    IL_00F0: nop
    IL_00F1: nop
    IL_00F2: stloc.0
    IL_00F3: ldloc.2
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x0400042B
    IL_00FA: conv.r8
    IL_00FB: IL_41
    IL_00FC: IL_01
    IL_00FD: nop
    IL_00FE: stloc.0
    IL_00FF: ldloc.1
    IL_0100: ldarg.1
    IL_0101: conv.r8
    IL_0102: ldloc.3
    IL_0103: nop
    IL_0104: nop
    IL_0105: stloc.0
    IL_0106: ldloc.1
    IL_0107: IL_22
    IL_0108: nop
    IL_0109: nop
    IL_010A: nop
    IL_010B: nop
    IL_010C: ldc.i4.0
    IL_0111: ldc.i4 360
    IL_0116: call 0x0A000045
    IL_0117: conv.i2
    IL_0118: IL_22
    IL_0119: nop
    IL_011A: nop
    IL_011B: nop
    IL_011C: nop
    IL_0121: call 0x0A000060
    IL_0122: conv.r8
    IL_0127: call 0x070A0000
    IL_0128: IL_22
    IL_012A: bne.un.s IL_015E
    IL_012C: bne.un.s IL_016C
    IL_012D: IL_22
    IL_012E: nop
    IL_012F: nop
    IL_0134: stsfld 0x0075283F
    IL_0135: nop
    IL_0136: stloc.0
    IL_0137: ldarg.2
    IL_013C: call 0x0A0000C2
    IL_013D: conv.r8
    IL_013E: IL_AF
    IL_013F: nop
    IL_0140: nop
    IL_0141: stloc.0
    IL_0142: ldloc.1
    IL_0143: ldarg.0
    IL_0148: ldfld 0x0400042A
    IL_0149: conv.r8
    IL_014A: IL_4E
    IL_014B: nop
    IL_014C: nop
    IL_014D: stloc.0
    IL_014E: ldarg.0
    IL_014F: ldarg.0
    IL_0154: ldfld 0x0400042B
    IL_0155: ldloc.1
    IL_015A: call 0x06000212
    IL_015B: ret
    }

    public void Merge() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: ldarg.0
    IL_000B: call 0x0A000002
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: call 0x0A000013
    IL_001A: call 0x0A000014
    IL_001B: conv.u4
    IL_001C: ldarg.1
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_01
    IL_0020: stloc.0
    IL_0021: ldc.i4.2
    IL_0026: newarr 0x01000046
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldc.i4.0
    IL_002A: IL_8F
    IL_002D: ldarga 0
    IL_002E: IL_01
    IL_002F: ldloc.0
    IL_0030: conv.r8
    IL_0031: ldc.i4.0
    IL_0032: nop
    IL_0033: nop
    IL_0035: br.s IL_00A5
    IL_0036: IL_A9
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003E: call 0x0A000142
    IL_003F: ldloc.1
    IL_0040: ldc.i4.1
    IL_0041: IL_8F
    IL_0044: ldarga 0
    IL_0045: IL_01
    IL_0046: ldarg.1
    IL_004B: call 0x0A000142
    IL_004C: ldloc.1
    IL_004D: ldc.i4.1
    IL_004E: IL_8F
    IL_0051: ldarga 0
    IL_0052: IL_01
    IL_0053: ldarg.2
    IL_0054: conv.r8
    IL_0055: IL_43
    IL_0056: IL_01
    IL_0057: nop
    IL_0058: stloc.0
    IL_005D: call 0x0A000144
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000429
    IL_0068: newobj 0x0A000145
    IL_0069: conv.r8
    IL_006A: IL_41
    IL_006B: IL_01
    IL_006C: nop
    IL_006D: stloc.0
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000429
    IL_0074: conv.r8
    IL_0075: IL_A9
    IL_0076: nop
    IL_0077: nop
    IL_0078: stloc.0
    IL_0079: ldloc.1
    IL_007A: conv.r8
    IL_007D: ldarga 1
    IL_007E: stloc.0
    IL_007F: ldarg.0
    IL_0084: call 0x0A000002
    IL_0085: conv.r8
    IL_0086: stloc.0
    IL_0087: nop
    IL_0088: nop
    IL_0089: stloc.0
    IL_008A: ldc.i4.1
    IL_008B: conv.r8
    IL_008C: stloc.1
    IL_008D: nop
    IL_008E: nop
    IL_008F: stloc.0
    IL_0090: ret
    }

    }}
