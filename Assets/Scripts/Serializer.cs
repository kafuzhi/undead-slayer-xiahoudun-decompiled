// Namespace: 
// Type: Serializer

    internal sealed class Serializer {{

    private object builder;

    private Serializer() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ldarg.0
    IL_000B: newobj 0x0A0001DD
    IL_0010: stfld 0x04000A38
    IL_0011: ret
    }

    public static void Serialize() {
    IL_0004: newobj 0x060005A4
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_0008: conv.r8
    IL_000D: isinst 0x06060005
    IL_0012: ldfld 0x04000A38
    IL_0013: conv.r8
    IL_0014: IL_E0
    IL_0015: IL_01
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void SerializeValue() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_001C
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A38
    IL_0010: ldstr 0x700230EB
    IL_0011: conv.r8
    IL_0012: IL_DF
    IL_0013: IL_01
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: pop
    IL_001B: br IL_00C6
    IL_001C: ldarg.1
    IL_001D: conv.u8
    IL_001E: stloc.2
    IL_001F: nop
    IL_0020: nop
    IL_0021: IL_01
    IL_0022: dup
    IL_0023: stloc.2
    IL_0028: brfalse IL_0035
    IL_0029: ldarg.0
    IL_002A: ldloc.2
    IL_002F: call 0x060005A9
    IL_0034: br IL_00C6
    IL_0035: ldarg.1
    IL_0036: conv.u8
    IL_0038: stloc.s 0
    IL_0039: nop
    IL_003A: IL_01
    IL_003F: brfalse IL_006B
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000A38
    IL_0046: ldarg.1
    IL_004B: castclass 0x01000013
    IL_0050: brfalse IL_005B
    IL_0055: ldstr 0x70000583
    IL_005A: br IL_0060
    IL_005F: ldstr 0x70022ADA
    IL_0060: conv.r8
    IL_0061: IL_DF
    IL_0062: IL_01
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: pop
    IL_006A: br IL_00C6
    IL_006B: ldarg.1
    IL_006C: conv.u8
    IL_006D: IL_86
    IL_006E: nop
    IL_006F: nop
    IL_0070: IL_01
    IL_0071: dup
    IL_0072: stloc.0
    IL_0077: brfalse IL_0084
    IL_0078: ldarg.0
    IL_0079: ldloc.0
    IL_007E: call 0x060005A8
    IL_0083: br IL_00C6
    IL_0084: ldarg.1
    IL_0085: conv.u8
    IL_0086: IL_87
    IL_0087: nop
    IL_0088: nop
    IL_0089: IL_01
    IL_008A: dup
    IL_008B: stloc.1
    IL_0090: brfalse IL_009D
    IL_0091: ldarg.0
    IL_0092: ldloc.1
    IL_0097: call 0x060005A7
    IL_009C: br IL_00C6
    IL_009D: ldarg.1
    IL_009E: conv.u8
    IL_009F: ret
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: IL_01
    IL_00A7: brfalse IL_00BF
    IL_00A8: ldarg.0
    IL_00A9: ldarg.1
    IL_00AE: castclass 0x0100002A
    IL_00AF: ldc.i4.1
    IL_00B4: newobj 0x0A0002D2
    IL_00B9: call 0x060005A9
    IL_00BE: br IL_00C6
    IL_00BF: ldarg.0
    IL_00C0: ldarg.1
    IL_00C5: call 0x060005AA
    IL_00C6: ret
    }

    private void SerializeObject() {
    IL_0000: ldc.i4.1
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0007: ldfld 0x04000A38
    IL_0009: ldc.i4.s 123
    IL_000A: conv.r8
    IL_000B: IL_C6
    IL_000C: ldarg.0
    IL_000D: nop
    IL_000E: stloc.0
    IL_000F: pop
    IL_0010: ldarg.1
    IL_0011: conv.r8
    IL_0012: IL_D3
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: conv.r8
    IL_0017: IL_D4
    IL_0018: ldarg.0
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: stloc.2
    IL_0020: br IL_0065
    IL_0021: ldloc.2
    IL_0022: conv.r8
    IL_0023: IL_98
    IL_0024: IL_01
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: stloc.1
    IL_0028: ldloc.0
    IL_002D: brtrue IL_003C
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000A38
    IL_0035: ldc.i4.s 44
    IL_0036: conv.r8
    IL_0037: IL_C6
    IL_0038: ldarg.0
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: pop
    IL_003C: ldarg.0
    IL_003D: ldloc.1
    IL_003E: conv.r8
    IL_003F: IL_B8
    IL_0040: ldarg.0
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: call 0x060005A9
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000A38
    IL_004F: ldc.i4.s 58
    IL_0050: conv.r8
    IL_0051: IL_C6
    IL_0052: ldarg.0
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: pop
    IL_0056: ldarg.0
    IL_0057: ldarg.1
    IL_0058: ldloc.1
    IL_0059: conv.r8
    IL_005A: IL_D5
    IL_005B: ldarg.0
    IL_005C: nop
    IL_005D: stloc.0
    IL_0062: call 0x060005A6
    IL_0063: ldc.i4.0
    IL_0064: stloc.0
    IL_0065: ldloc.2
    IL_0066: conv.r8
    IL_0067: IL_99
    IL_0068: IL_01
    IL_0069: nop
    IL_006A: stloc.0
    IL_006F: brtrue IL_0021
    IL_0070: IL_DD
    IL_0072: ldloca.s 0
    IL_0073: nop
    IL_0074: nop
    IL_0075: ldloc.2
    IL_0076: conv.u8
    IL_0078: brfalse.s IL_0079
    IL_0079: nop
    IL_007A: IL_01
    IL_007B: stloc.3
    IL_007C: ldloc.3
    IL_007E: brtrue.s IL_0080
    IL_007F: IL_DC
    IL_0080: ldloc.3
    IL_0081: conv.r8
    IL_0082: ldelem.ref
    IL_0083: nop
    IL_0084: nop
    IL_0085: stloc.0
    IL_0086: IL_DC
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000A38
    IL_008E: ldc.i4.s 125
    IL_008F: conv.r8
    IL_0090: IL_C6
    IL_0091: ldarg.0
    IL_0092: nop
    IL_0093: stloc.0
    IL_0094: pop
    IL_0095: ret
    }

    private void SerializeArray() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A38
    IL_0007: ldc.i4.s 91
    IL_0008: conv.r8
    IL_0009: IL_C6
    IL_000A: ldarg.0
    IL_000B: nop
    IL_000C: stloc.0
    IL_000D: pop
    IL_000E: ldc.i4.1
    IL_000F: stloc.0
    IL_0010: ldarg.1
    IL_0011: conv.r8
    IL_0012: IL_D4
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.2
    IL_001B: br IL_0040
    IL_001C: ldloc.2
    IL_001D: conv.r8
    IL_001E: IL_98
    IL_001F: IL_01
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: stloc.1
    IL_0023: ldloc.0
    IL_0028: brtrue IL_0037
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000A38
    IL_0030: ldc.i4.s 44
    IL_0031: conv.r8
    IL_0032: IL_C6
    IL_0033: ldarg.0
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: pop
    IL_0037: ldarg.0
    IL_0038: ldloc.1
    IL_003D: call 0x060005A6
    IL_003E: ldc.i4.0
    IL_003F: stloc.0
    IL_0040: ldloc.2
    IL_0041: conv.r8
    IL_0042: IL_99
    IL_0043: IL_01
    IL_0044: nop
    IL_0045: stloc.0
    IL_004A: brtrue IL_001C
    IL_004B: IL_DD
    IL_004D: ldloca.s 0
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldloc.2
    IL_0051: conv.u8
    IL_0053: brfalse.s IL_0054
    IL_0054: nop
    IL_0055: IL_01
    IL_0056: stloc.3
    IL_0057: ldloc.3
    IL_0059: brtrue.s IL_005B
    IL_005A: IL_DC
    IL_005B: ldloc.3
    IL_005C: conv.r8
    IL_005D: ldelem.ref
    IL_005E: nop
    IL_005F: nop
    IL_0060: stloc.0
    IL_0061: IL_DC
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000A38
    IL_0069: ldc.i4.s 93
    IL_006A: conv.r8
    IL_006B: IL_C6
    IL_006C: ldarg.0
    IL_006D: nop
    IL_006E: stloc.0
    IL_006F: pop
    IL_0070: ret
    }

    private void SerializeString() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A38
    IL_0007: ldc.i4.s 34
    IL_0008: conv.r8
    IL_0009: IL_C6
    IL_000A: ldarg.0
    IL_000B: nop
    IL_000C: stloc.0
    IL_000D: pop
    IL_000E: ldarg.1
    IL_000F: conv.r8
    IL_0012: ldloc 1
    IL_0013: stloc.0
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: stloc.2
    IL_0017: ldc.i4.0
    IL_0018: stloc.3
    IL_001D: br IL_0155
    IL_001E: ldloc.2
    IL_001F: ldloc.3
    IL_0020: IL_93
    IL_0021: stloc.1
    IL_0022: ldloc.1
    IL_0024: stloc.s 5
    IL_0026: ldloc.s 5
    IL_0027: ldc.i4.8
    IL_0028: IL_59
    IL_002B: ldarg 6
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_43
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldelem.i1
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: conv.r8
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: IL_59
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: IL_85
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0047: ldloc.s 5
    IL_0049: ldc.i4.s 34
    IL_004E: beq IL_005D
    IL_0050: ldloc.s 5
    IL_0052: ldc.i4.s 92
    IL_0057: beq IL_0073
    IL_005C: br IL_00F7
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000A38
    IL_0067: ldstr 0x70022AFE
    IL_0068: conv.r8
    IL_0069: IL_DF
    IL_006A: IL_01
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: pop
    IL_0072: br IL_0151
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000A38
    IL_007D: ldstr 0x70022AF8
    IL_007E: conv.r8
    IL_007F: IL_DF
    IL_0080: IL_01
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: pop
    IL_0088: br IL_0151
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000A38
    IL_0093: ldstr 0x70022B16
    IL_0094: conv.r8
    IL_0095: IL_DF
    IL_0096: IL_01
    IL_0097: nop
    IL_0098: stloc.0
    IL_0099: pop
    IL_009E: br IL_0151
    IL_009F: ldarg.0
    IL_00A4: ldfld 0x04000A38
    IL_00A9: ldstr 0x70022B1C
    IL_00AA: conv.r8
    IL_00AB: IL_DF
    IL_00AC: IL_01
    IL_00AD: nop
    IL_00AE: stloc.0
    IL_00AF: pop
    IL_00B4: br IL_0151
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x04000A38
    IL_00BF: ldstr 0x70022B04
    IL_00C0: conv.r8
    IL_00C1: IL_DF
    IL_00C2: IL_01
    IL_00C3: nop
    IL_00C4: stloc.0
    IL_00C5: pop
    IL_00CA: br IL_0151
    IL_00CB: ldarg.0
    IL_00D0: ldfld 0x04000A38
    IL_00D5: ldstr 0x70022B0A
    IL_00D6: conv.r8
    IL_00D7: IL_DF
    IL_00D8: IL_01
    IL_00D9: nop
    IL_00DA: stloc.0
    IL_00DB: pop
    IL_00E0: br IL_0151
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x04000A38
    IL_00EB: ldstr 0x70022B10
    IL_00EC: conv.r8
    IL_00ED: IL_DF
    IL_00EE: IL_01
    IL_00EF: nop
    IL_00F0: stloc.0
    IL_00F1: pop
    IL_00F6: br IL_0151
    IL_00F7: ldloc.1
    IL_00FC: call 0x0A0002D6
    IL_00FE: stloc.s 4
    IL_0100: ldloc.s 4
    IL_0102: ldc.i4.s 32
    IL_0103: IL_3F
    IL_0104: ldc.i4.5
    IL_0105: nop
    IL_0106: nop
    IL_0107: nop
    IL_0109: ldloc.s 4
    IL_010B: ldc.i4.s 126
    IL_010C: IL_3D
    IL_010E: ldloca.s 0
    IL_010F: nop
    IL_0110: nop
    IL_0111: ldarg.0
    IL_0116: ldfld 0x04000A38
    IL_0117: ldloc.1
    IL_0118: conv.r8
    IL_0119: IL_C6
    IL_011A: ldarg.0
    IL_011B: nop
    IL_011C: stloc.0
    IL_011D: pop
    IL_0122: br IL_014C
    IL_0123: ldarg.0
    IL_0128: ldfld 0x04000A38
    IL_012D: ldstr 0x70023105
    IL_012E: conv.r8
    IL_012F: IL_DF
    IL_0130: IL_01
    IL_0131: nop
    IL_0132: stloc.0
    IL_0133: pop
    IL_0134: ldarg.0
    IL_0139: ldfld 0x04000A38
    IL_013B: ldloca.s 4
    IL_0140: ldstr 0x7002310B
    IL_0145: call 0x0A0002D7
    IL_0146: conv.r8
    IL_0147: IL_DF
    IL_0148: IL_01
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: pop
    IL_0150: br IL_0151
    IL_0151: ldloc.3
    IL_0152: ldc.i4.1
    IL_0153: IL_58
    IL_0154: stloc.3
    IL_0155: ldloc.3
    IL_0156: ldloc.2
    IL_0157: len
    IL_0158: not
    IL_0159: IL_3F
    IL_015A: IL_C0
    IL_015C: 0xFE FF
    IL_015D: IL_FF
    IL_015E: ldarg.0
    IL_0163: ldfld 0x04000A38
    IL_0165: ldc.i4.s 34
    IL_0166: conv.r8
    IL_0167: IL_C6
    IL_0168: ldarg.0
    IL_0169: nop
    IL_016A: stloc.0
    IL_016B: pop
    IL_016C: ret
    }

    private void SerializeOther() {
    IL_0000: ldarg.1
    IL_0001: conv.u8
    IL_0003: bge.s IL_0004
    IL_0004: nop
    IL_0005: IL_01
    IL_000A: brfalse IL_002F
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000A38
    IL_0011: ldarg.1
    IL_0016: castclass 0x0100002F
    IL_0017: stloc.0
    IL_0019: ldloca.s 0
    IL_001E: ldstr 0x70023111
    IL_0023: call 0x0A0001BB
    IL_0024: conv.r8
    IL_0025: IL_DF
    IL_0026: IL_01
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: pop
    IL_002E: br IL_00DF
    IL_002F: ldarg.1
    IL_0030: conv.u8
    IL_0031: stloc.1
    IL_0032: nop
    IL_0033: nop
    IL_0034: IL_01
    IL_0039: brtrue IL_0087
    IL_003A: ldarg.1
    IL_003B: conv.u8
    IL_003C: ldind.ref
    IL_003D: nop
    IL_003E: nop
    IL_003F: IL_01
    IL_0044: brtrue IL_0087
    IL_0045: ldarg.1
    IL_0046: conv.u8
    IL_0049: ldarg 0
    IL_004A: IL_01
    IL_004F: brtrue IL_0087
    IL_0050: ldarg.1
    IL_0051: conv.u8
    IL_0052: stind.i
    IL_0053: nop
    IL_0054: nop
    IL_0055: IL_01
    IL_005A: brtrue IL_0087
    IL_005B: ldarg.1
    IL_005C: conv.u8
    IL_005D: IL_83
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_01
    IL_0065: brtrue IL_0087
    IL_0066: ldarg.1
    IL_0067: conv.u8
    IL_0069: starg.s 0
    IL_006A: nop
    IL_006B: IL_01
    IL_0070: brtrue IL_0087
    IL_0071: ldarg.1
    IL_0072: conv.u8
    IL_0077: newobj 0x3A010000
    IL_0078: stloc.1
    IL_0079: nop
    IL_007A: nop
    IL_007B: nop
    IL_007C: ldarg.1
    IL_007D: conv.u8
    IL_0082: newarr 0x39010000
    IL_0084: ldloca.s 0
    IL_0085: nop
    IL_0086: nop
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000A38
    IL_008D: ldarg.1
    IL_008E: conv.r8
    IL_008F: IL_D8
    IL_0090: ldarg.0
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: pop
    IL_0098: br IL_00DF
    IL_0099: ldarg.1
    IL_009A: conv.u8
    IL_009B: not
    IL_009C: nop
    IL_009D: nop
    IL_009E: IL_01
    IL_00A3: brtrue IL_00AF
    IL_00A4: ldarg.1
    IL_00A5: conv.u8
    IL_00A6: len
    IL_00A7: nop
    IL_00A8: nop
    IL_00A9: IL_01
    IL_00AE: brfalse IL_00D3
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000A38
    IL_00B5: ldarg.1
    IL_00BA: call 0x0A0002D9
    IL_00BB: stloc.1
    IL_00BD: ldloca.s 1
    IL_00C2: ldstr 0x70023111
    IL_00C7: call 0x0A0002DA
    IL_00C8: conv.r8
    IL_00C9: IL_DF
    IL_00CA: IL_01
    IL_00CB: nop
    IL_00CC: stloc.0
    IL_00CD: pop
    IL_00D2: br IL_00DF
    IL_00D3: ldarg.0
    IL_00D4: ldarg.1
    IL_00D5: conv.r8
    IL_00D6: IL_B8
    IL_00D7: ldarg.0
    IL_00D8: nop
    IL_00D9: stloc.0
    IL_00DE: call 0x060005A9
    IL_00DF: ret
    }

    }}
