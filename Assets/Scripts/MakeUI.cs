// Namespace: 
// Type: MakeUI

    public class MakeUI {{

    public object main_material;
    public object mat_txtresult;
    private object skillicon_folder;
    public object peticon_folder;

    public MakeUI() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000311
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x040007DA
    IL_0015: ret
    }

    public void CreatCustomPlane() {
    IL_0001: ldarg.s 6
    IL_0006: newobj 0x0A00013F
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: conv.r8
    IL_000A: IL_43
    IL_000B: nop
    IL_000C: nop
    IL_000E: br.s IL_001A
    IL_0013: newobj 0x0A000145
    IL_0014: stloc.2
    IL_0015: ldarg.2
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_43
    IL_001C: ldc.i4.m1
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: ldloc.0
    IL_0021: conv.r8
    IL_0022: IL_58
    IL_0023: nop
    IL_0024: nop
    IL_0026: br.s IL_0034
    IL_0027: ldloc.3
    IL_0028: ldarg.2
    IL_0029: conv.r8
    IL_002A: IL_CB
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldloc.3
    IL_002F: ldc.i4.1
    IL_0030: conv.r8
    IL_0031: conv.ovf.i4.un
    IL_0032: nop
    IL_0033: nop
    IL_0034: stloc.0
    IL_0035: ldloc.0
    IL_0036: conv.r8
    IL_0039: ldloca 0
    IL_003B: br.s IL_0062
    IL_003C: ldloc.2
    IL_003D: ldc.i4.4
    IL_0042: newarr 0x01000007
    IL_0043: dup
    IL_0044: ldc.i4.0
    IL_0045: IL_8F
    IL_0046: ldloc.1
    IL_0047: nop
    IL_0048: nop
    IL_0049: IL_01
    IL_004B: ldarga.s 1
    IL_0050: ldfld 0x0A000059
    IL_0051: shl
    IL_0053: ldarg.s 8
    IL_0054: IL_58
    IL_0056: ldarga.s 1
    IL_005B: ldfld 0x0A00005A
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: nop
    IL_0065: newobj 0x0A000076
    IL_0066: IL_22
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_3F
    IL_006F: call 0x0A000008
    IL_0070: IL_81
    IL_0071: ldloc.1
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_01
    IL_0075: dup
    IL_0076: ldc.i4.1
    IL_0077: IL_8F
    IL_0078: ldloc.1
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_01
    IL_007D: ldarga.s 1
    IL_0082: ldfld 0x0A000059
    IL_0084: ldarg.s 8
    IL_0085: IL_58
    IL_0087: ldarga.s 1
    IL_008C: ldfld 0x0A00005A
    IL_008D: IL_22
    IL_008E: nop
    IL_008F: nop
    IL_0090: nop
    IL_0091: nop
    IL_0096: newobj 0x0A000076
    IL_0097: IL_22
    IL_0098: nop
    IL_0099: nop
    IL_009A: nop
    IL_009B: IL_3F
    IL_00A0: call 0x0A000008
    IL_00A1: IL_81
    IL_00A2: ldloc.1
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: IL_01
    IL_00A6: dup
    IL_00A7: ldc.i4.2
    IL_00A8: IL_8F
    IL_00A9: ldloc.1
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: IL_01
    IL_00AE: ldarga.s 1
    IL_00B3: ldfld 0x0A000059
    IL_00B4: shl
    IL_00B6: ldarga.s 1
    IL_00BB: ldfld 0x0A00005A
    IL_00BC: shl
    IL_00BD: IL_22
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: nop
    IL_00C6: newobj 0x0A000076
    IL_00C7: IL_22
    IL_00C8: nop
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: IL_3F
    IL_00D0: call 0x0A000008
    IL_00D1: IL_81
    IL_00D2: ldloc.1
    IL_00D3: nop
    IL_00D4: nop
    IL_00D5: IL_01
    IL_00D6: dup
    IL_00D7: ldc.i4.3
    IL_00D8: IL_8F
    IL_00D9: ldloc.1
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: IL_01
    IL_00DE: ldarga.s 1
    IL_00E3: ldfld 0x0A000059
    IL_00E5: ldarga.s 1
    IL_00EA: ldfld 0x0A00005A
    IL_00EB: shl
    IL_00EC: IL_22
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: nop
    IL_00F5: newobj 0x0A000076
    IL_00F6: IL_22
    IL_00F7: nop
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: IL_3F
    IL_00FF: call 0x0A000008
    IL_0100: IL_81
    IL_0101: ldloc.1
    IL_0102: nop
    IL_0103: nop
    IL_0104: IL_01
    IL_0105: conv.r8
    IL_0106: IL_89
    IL_0107: IL_01
    IL_0108: nop
    IL_0109: stloc.0
    IL_010A: ldloc.2
    IL_010B: ldc.i4.4
    IL_0110: newarr 0x01000014
    IL_0111: dup
    IL_0112: ldc.i4.0
    IL_0113: IL_8F
    IL_0114: ldnull
    IL_0115: nop
    IL_0116: nop
    IL_0117: IL_01
    IL_0119: ldarga.s 4
    IL_011E: ldfld 0x0A000059
    IL_0120: ldarga.s 5
    IL_0125: ldfld 0x0A00005A
    IL_012A: newobj 0x0A000038
    IL_012B: IL_81
    IL_012C: ldnull
    IL_012D: nop
    IL_012E: nop
    IL_012F: IL_01
    IL_0130: dup
    IL_0131: ldc.i4.1
    IL_0132: IL_8F
    IL_0133: ldnull
    IL_0134: nop
    IL_0135: nop
    IL_0136: IL_01
    IL_0138: ldarga.s 5
    IL_013D: ldfld 0x0A000059
    IL_013F: ldarga.s 5
    IL_0144: ldfld 0x0A00005A
    IL_0149: newobj 0x0A000038
    IL_014A: IL_81
    IL_014B: ldnull
    IL_014C: nop
    IL_014D: nop
    IL_014E: IL_01
    IL_014F: dup
    IL_0150: ldc.i4.2
    IL_0151: IL_8F
    IL_0152: ldnull
    IL_0153: nop
    IL_0154: nop
    IL_0155: IL_01
    IL_0157: ldarga.s 4
    IL_015C: ldfld 0x0A000059
    IL_015E: ldarga.s 4
    IL_0163: ldfld 0x0A00005A
    IL_0168: newobj 0x0A000038
    IL_0169: IL_81
    IL_016A: ldnull
    IL_016B: nop
    IL_016C: nop
    IL_016D: IL_01
    IL_016E: dup
    IL_016F: ldc.i4.3
    IL_0170: IL_8F
    IL_0171: ldnull
    IL_0172: nop
    IL_0173: nop
    IL_0174: IL_01
    IL_0176: ldarga.s 5
    IL_017B: ldfld 0x0A000059
    IL_017D: ldarga.s 4
    IL_0182: ldfld 0x0A00005A
    IL_0187: newobj 0x0A000038
    IL_0188: IL_81
    IL_0189: ldnull
    IL_018A: nop
    IL_018B: nop
    IL_018C: IL_01
    IL_018D: conv.r8
    IL_018E: IL_AC
    IL_018F: nop
    IL_0190: nop
    IL_0191: stloc.0
    IL_0192: ldloc.0
    IL_0193: conv.r8
    IL_0194: ldind.ref
    IL_0195: IL_01
    IL_0196: nop
    IL_0197: stloc.0
    IL_0199: stloc.s 4
    IL_019B: ldloc.s 4
    IL_019C: ldc.i4.0
    IL_019D: conv.r8
    IL_019E: IL_C5
    IL_019F: IL_01
    IL_01A0: nop
    IL_01A1: stloc.0
    IL_01A3: ldloc.s 4
    IL_01A4: ldc.i4.0
    IL_01A5: conv.r8
    IL_01A6: IL_C6
    IL_01A7: IL_01
    IL_01A8: nop
    IL_01A9: stloc.0
    IL_01AB: ldloc.s 4
    IL_01AC: ldarg.0
    IL_01B1: ldfld 0x040007D8
    IL_01B2: conv.r8
    IL_01B3: stind.i
    IL_01B4: IL_01
    IL_01B5: nop
    IL_01B6: stloc.0
    IL_01B7: ldloc.2
    IL_01B8: ldc.i4.6
    IL_01BD: newarr 0x0100000B
    IL_01BE: dup
    IL_01C3: ldtoken 0x040010B8
    IL_01C8: call 0x0A00018C
    IL_01C9: conv.r8
    IL_01CE: newarr 0x080A0001
    IL_01CF: conv.r8
    IL_01D0: len
    IL_01D1: IL_01
    IL_01D2: nop
    IL_01D3: stloc.0
    IL_01D4: ldloc.1
    IL_01D5: ldloc.2
    IL_01D6: conv.r8
    IL_01D7: IL_41
    IL_01D8: IL_01
    IL_01D9: nop
    IL_01DA: stloc.0
    IL_01DB: ldloc.0
    IL_01DC: conv.r8
    IL_01DD: ldarg.3
    IL_01DE: nop
    IL_01DF: nop
    IL_01E0: stloc.0
    IL_01E1: dup
    IL_01E2: conv.r8
    IL_01E3: ldc.i4.2
    IL_01E4: nop
    IL_01E5: nop
    IL_01E6: stloc.0
    IL_01E7: ldarg.3
    IL_01EC: call 0x0A000029
    IL_01ED: conv.r8
    IL_01EE: ldloc.3
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: stloc.0
    IL_01F3: ldarg.s 9
    IL_01F8: brtrue IL_020F
    IL_01F9: ldloc.0
    IL_01FA: conv.r8
    IL_01FB: ldarg.3
    IL_01FC: nop
    IL_01FD: nop
    IL_01FE: stloc.0
    IL_01FF: ldarg.0
    IL_0204: call 0x0A000002
    IL_0205: conv.r8
    IL_0206: IL_4E
    IL_0207: nop
    IL_0208: nop
    IL_0209: stloc.0
    IL_020E: br IL_0246
    IL_0210: ldarg.s 9
    IL_0211: ldc.i4.1
    IL_026E: switch (22 cases)
    }

    public void Creat_result() {
    IL_0000: ldarg.3
    IL_0005: newobj 0x0A00013F
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: conv.r8
    IL_0009: IL_43
    IL_000A: nop
    IL_000B: nop
    IL_000D: br.s IL_0019
    IL_0012: newobj 0x0A000145
    IL_0013: stloc.2
    IL_0014: ldloc.0
    IL_0015: conv.r8
    IL_0018: ldloca 0
    IL_001A: br.s IL_0041
    IL_001B: ldloc.2
    IL_001C: ldc.i4.4
    IL_0021: newarr 0x01000007
    IL_0022: dup
    IL_0023: ldc.i4.0
    IL_0024: IL_8F
    IL_0025: ldloc.1
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_01
    IL_002A: ldarga.s 1
    IL_002F: ldfld 0x0A000059
    IL_0030: shl
    IL_0032: ldarga.s 1
    IL_0037: ldfld 0x0A00005A
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_0041: newobj 0x0A000076
    IL_0042: IL_22
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_3F
    IL_004B: call 0x0A000008
    IL_004C: IL_81
    IL_004D: ldloc.1
    IL_004E: nop
    IL_004F: nop
    IL_0050: IL_01
    IL_0051: dup
    IL_0052: ldc.i4.1
    IL_0053: IL_8F
    IL_0054: ldloc.1
    IL_0055: nop
    IL_0056: nop
    IL_0057: IL_01
    IL_0059: ldarga.s 1
    IL_005E: ldfld 0x0A000059
    IL_0060: ldarga.s 1
    IL_0065: ldfld 0x0A00005A
    IL_0066: IL_22
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: nop
    IL_006F: newobj 0x0A000076
    IL_0070: IL_22
    IL_0071: nop
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_3F
    IL_0079: call 0x0A000008
    IL_007A: IL_81
    IL_007B: ldloc.1
    IL_007C: nop
    IL_007D: nop
    IL_007E: IL_01
    IL_007F: dup
    IL_0080: ldc.i4.2
    IL_0081: IL_8F
    IL_0082: ldloc.1
    IL_0083: nop
    IL_0084: nop
    IL_0085: IL_01
    IL_0087: ldarga.s 1
    IL_008C: ldfld 0x0A000059
    IL_008D: shl
    IL_008F: ldarga.s 1
    IL_0094: ldfld 0x0A00005A
    IL_0095: shl
    IL_0096: IL_22
    IL_0097: nop
    IL_0098: nop
    IL_0099: nop
    IL_009A: nop
    IL_009F: newobj 0x0A000076
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: IL_3F
    IL_00A9: call 0x0A000008
    IL_00AA: IL_81
    IL_00AB: ldloc.1
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: IL_01
    IL_00AF: dup
    IL_00B0: ldc.i4.3
    IL_00B1: IL_8F
    IL_00B2: ldloc.1
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: IL_01
    IL_00B7: ldarga.s 1
    IL_00BC: ldfld 0x0A000059
    IL_00BE: ldarga.s 1
    IL_00C3: ldfld 0x0A00005A
    IL_00C4: shl
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: nop
    IL_00CE: newobj 0x0A000076
    IL_00CF: IL_22
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: IL_3F
    IL_00D8: call 0x0A000008
    IL_00D9: IL_81
    IL_00DA: ldloc.1
    IL_00DB: nop
    IL_00DC: nop
    IL_00DD: IL_01
    IL_00DE: conv.r8
    IL_00DF: IL_89
    IL_00E0: IL_01
    IL_00E1: nop
    IL_00E2: stloc.0
    IL_00E3: ldloc.2
    IL_00E4: ldc.i4.4
    IL_00E9: newarr 0x01000014
    IL_00EA: dup
    IL_00EB: ldc.i4.0
    IL_00EC: IL_8F
    IL_00ED: ldnull
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: IL_01
    IL_00F5: call 0x0A000057
    IL_00F6: IL_81
    IL_00F7: ldnull
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: IL_01
    IL_00FB: dup
    IL_00FC: ldc.i4.1
    IL_00FD: IL_8F
    IL_00FE: ldnull
    IL_00FF: nop
    IL_0100: nop
    IL_0101: IL_01
    IL_0106: call 0x0A000057
    IL_0107: IL_81
    IL_0108: ldnull
    IL_0109: nop
    IL_010A: nop
    IL_010B: IL_01
    IL_010C: dup
    IL_010D: ldc.i4.2
    IL_010E: IL_8F
    IL_010F: ldnull
    IL_0110: nop
    IL_0111: nop
    IL_0112: IL_01
    IL_0117: call 0x0A000057
    IL_0118: IL_81
    IL_0119: ldnull
    IL_011A: nop
    IL_011B: nop
    IL_011C: IL_01
    IL_011D: dup
    IL_011E: ldc.i4.3
    IL_011F: IL_8F
    IL_0120: ldnull
    IL_0121: nop
    IL_0122: nop
    IL_0123: IL_01
    IL_0128: call 0x0A000057
    IL_0129: IL_81
    IL_012A: ldnull
    IL_012B: nop
    IL_012C: nop
    IL_012D: IL_01
    IL_012E: conv.r8
    IL_012F: IL_AC
    IL_0130: nop
    IL_0131: nop
    IL_0132: stloc.0
    IL_0133: ldloc.0
    IL_0134: conv.r8
    IL_0135: ldind.ref
    IL_0136: IL_01
    IL_0137: nop
    IL_0138: stloc.0
    IL_0139: stloc.3
    IL_013A: ldloc.3
    IL_013B: ldc.i4.0
    IL_013C: conv.r8
    IL_013D: IL_C5
    IL_013E: IL_01
    IL_013F: nop
    IL_0140: stloc.0
    IL_0141: ldloc.3
    IL_0142: ldc.i4.0
    IL_0143: conv.r8
    IL_0144: IL_C6
    IL_0145: IL_01
    IL_0146: nop
    IL_0147: stloc.0
    IL_0148: ldloc.3
    IL_0149: ldarg.0
    IL_014E: ldfld 0x040007D9
    IL_014F: conv.r8
    IL_0150: stind.i
    IL_0151: IL_01
    IL_0152: nop
    IL_0153: stloc.0
    IL_0154: ldloc.2
    IL_0155: ldc.i4.6
    IL_015A: newarr 0x0100000B
    IL_015B: dup
    IL_0160: ldtoken 0x040010B9
    IL_0165: call 0x0A00018C
    IL_0166: conv.r8
    IL_016B: newarr 0x080A0001
    IL_016C: conv.r8
    IL_016D: len
    IL_016E: IL_01
    IL_016F: nop
    IL_0170: stloc.0
    IL_0171: ldloc.1
    IL_0172: ldloc.2
    IL_0173: conv.r8
    IL_0174: IL_41
    IL_0175: IL_01
    IL_0176: nop
    IL_0177: stloc.0
    IL_0178: ldloc.0
    IL_0179: conv.r8
    IL_017A: ldarg.3
    IL_017B: nop
    IL_017C: nop
    IL_017D: stloc.0
    IL_017E: dup
    IL_017F: conv.r8
    IL_0180: ldc.i4.2
    IL_0181: nop
    IL_0182: nop
    IL_0183: stloc.0
    IL_0184: ldarg.2
    IL_0189: call 0x0A000029
    IL_018A: conv.r8
    IL_018B: ldloc.3
    IL_018C: nop
    IL_018D: nop
    IL_018E: stloc.0
    IL_018F: ldloc.0
    IL_0190: conv.r8
    IL_0191: ldarg.3
    IL_0192: nop
    IL_0193: nop
    IL_0194: stloc.0
    IL_0195: ldarg.0
    IL_019A: call 0x0A000002
    IL_019B: conv.r8
    IL_019C: IL_4E
    IL_019D: nop
    IL_019E: nop
    IL_019F: stloc.0
    IL_01A0: ldloc.0
    IL_01A1: ldarg.0
    IL_01A6: call 0x0A00000A
    IL_01A7: conv.r8
    IL_01A8: ldc.i4.8
    IL_01A9: nop
    IL_01AA: nop
    IL_01AB: stloc.0
    IL_01AC: conv.r8
    IL_01AD: ldc.i4.m1
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: stloc.0
    IL_01B1: ldloc.0
    IL_01B6: ldstr 0x7002272E
    IL_01B7: conv.r8
    IL_01B8: IL_C7
    IL_01B9: IL_01
    IL_01BA: nop
    IL_01BB: stloc.0
    IL_01BC: pop
    IL_01BD: ldloc.0
    IL_01BE: conv.r8
    IL_01BF: ldarg.3
    IL_01C0: nop
    IL_01C1: nop
    IL_01C2: stloc.0
    IL_01C3: ret
    }

    public void Creat_star() {
    IL_0004: ldstr 0x70022744
    IL_0009: newobj 0x0A00013F
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: conv.r8
    IL_000D: IL_43
    IL_000E: nop
    IL_000F: nop
    IL_0011: br.s IL_001D
    IL_0016: newobj 0x0A000145
    IL_0017: stloc.2
    IL_0018: ldloc.0
    IL_0019: conv.r8
    IL_001C: ldloca 0
    IL_001E: br.s IL_0045
    IL_001F: ldloc.2
    IL_0020: ldc.i4.4
    IL_0025: newarr 0x01000007
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_0028: IL_8F
    IL_0029: ldloc.1
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_01
    IL_002E: ldarga.s 1
    IL_0033: ldfld 0x0A000059
    IL_0034: shl
    IL_0036: ldarga.s 1
    IL_003B: ldfld 0x0A00005A
    IL_003C: IL_22
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0045: newobj 0x0A000076
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: IL_3F
    IL_004F: call 0x0A000008
    IL_0050: IL_81
    IL_0051: ldloc.1
    IL_0052: nop
    IL_0053: nop
    IL_0054: IL_01
    IL_0055: dup
    IL_0056: ldc.i4.1
    IL_0057: IL_8F
    IL_0058: ldloc.1
    IL_0059: nop
    IL_005A: nop
    IL_005B: IL_01
    IL_005D: ldarga.s 1
    IL_0062: ldfld 0x0A000059
    IL_0064: ldarga.s 1
    IL_0069: ldfld 0x0A00005A
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_006D: nop
    IL_006E: nop
    IL_0073: newobj 0x0A000076
    IL_0074: IL_22
    IL_0075: nop
    IL_0076: nop
    IL_0077: nop
    IL_0078: IL_3F
    IL_007D: call 0x0A000008
    IL_007E: IL_81
    IL_007F: ldloc.1
    IL_0080: nop
    IL_0081: nop
    IL_0082: IL_01
    IL_0083: dup
    IL_0084: ldc.i4.2
    IL_0085: IL_8F
    IL_0086: ldloc.1
    IL_0087: nop
    IL_0088: nop
    IL_0089: IL_01
    IL_008B: ldarga.s 1
    IL_0090: ldfld 0x0A000059
    IL_0091: shl
    IL_0093: ldarga.s 1
    IL_0098: ldfld 0x0A00005A
    IL_0099: shl
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_009D: nop
    IL_009E: nop
    IL_00A3: newobj 0x0A000076
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: IL_3F
    IL_00AD: call 0x0A000008
    IL_00AE: IL_81
    IL_00AF: ldloc.1
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: IL_01
    IL_00B3: dup
    IL_00B4: ldc.i4.3
    IL_00B5: IL_8F
    IL_00B6: ldloc.1
    IL_00B7: nop
    IL_00B8: nop
    IL_00B9: IL_01
    IL_00BB: ldarga.s 1
    IL_00C0: ldfld 0x0A000059
    IL_00C2: ldarga.s 1
    IL_00C7: ldfld 0x0A00005A
    IL_00C8: shl
    IL_00C9: IL_22
    IL_00CA: nop
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: nop
    IL_00D2: newobj 0x0A000076
    IL_00D3: IL_22
    IL_00D4: nop
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: IL_3F
    IL_00DC: call 0x0A000008
    IL_00DD: IL_81
    IL_00DE: ldloc.1
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_01
    IL_00E2: conv.r8
    IL_00E3: IL_89
    IL_00E4: IL_01
    IL_00E5: nop
    IL_00E6: stloc.0
    IL_00E7: ldloc.2
    IL_00E8: ldc.i4.4
    IL_00ED: newarr 0x01000014
    IL_00EE: dup
    IL_00EF: ldc.i4.0
    IL_00F0: IL_8F
    IL_00F1: ldnull
    IL_00F2: nop
    IL_00F3: nop
    IL_00F4: IL_01
    IL_00F9: call 0x0A0000AA
    IL_00FA: IL_22
    IL_00FB: nop
    IL_00FC: nop
    IL_0101: stsfld 0x0083283E
    IL_0102: nop
    IL_0103: stloc.0
    IL_0104: IL_81
    IL_0105: ldnull
    IL_0106: nop
    IL_0107: nop
    IL_0108: IL_01
    IL_0109: dup
    IL_010A: ldc.i4.1
    IL_010B: IL_8F
    IL_010C: ldnull
    IL_010D: nop
    IL_010E: nop
    IL_010F: IL_01
    IL_0110: IL_22
    IL_0111: nop
    IL_0112: nop
    IL_0117: stsfld 0x0000223F
    IL_011C: stsfld 0x0038733E
    IL_011D: nop
    IL_011E: stloc.0
    IL_011F: IL_81
    IL_0120: ldnull
    IL_0121: nop
    IL_0122: nop
    IL_0123: IL_01
    IL_0124: dup
    IL_0125: ldc.i4.2
    IL_0126: IL_8F
    IL_0127: ldnull
    IL_0128: nop
    IL_0129: nop
    IL_012A: IL_01
    IL_012F: call 0x0A000057
    IL_0130: IL_81
    IL_0131: ldnull
    IL_0132: nop
    IL_0133: nop
    IL_0134: IL_01
    IL_0135: dup
    IL_0136: ldc.i4.3
    IL_0137: IL_8F
    IL_0138: ldnull
    IL_0139: nop
    IL_013A: nop
    IL_013B: IL_01
    IL_0140: call 0x0A000082
    IL_0141: IL_81
    IL_0142: ldnull
    IL_0143: nop
    IL_0144: nop
    IL_0145: IL_01
    IL_0146: conv.r8
    IL_0147: IL_AC
    IL_0148: nop
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: ldloc.0
    IL_014C: conv.r8
    IL_014D: ldind.ref
    IL_014E: IL_01
    IL_014F: nop
    IL_0150: stloc.0
    IL_0151: stloc.3
    IL_0152: ldloc.3
    IL_0153: ldc.i4.0
    IL_0154: conv.r8
    IL_0155: IL_C5
    IL_0156: IL_01
    IL_0157: nop
    IL_0158: stloc.0
    IL_0159: ldloc.3
    IL_015A: ldc.i4.0
    IL_015B: conv.r8
    IL_015C: IL_C6
    IL_015D: IL_01
    IL_015E: nop
    IL_015F: stloc.0
    IL_0160: ldloc.3
    IL_0161: ldarg.0
    IL_0166: ldfld 0x040007D9
    IL_0167: conv.r8
    IL_0168: stind.i
    IL_0169: IL_01
    IL_016A: nop
    IL_016B: stloc.0
    IL_016C: ldloc.2
    IL_016D: ldc.i4.6
    IL_0172: newarr 0x0100000B
    IL_0173: dup
    IL_0178: ldtoken 0x040010BA
    IL_017D: call 0x0A00018C
    IL_017E: conv.r8
    IL_0183: newarr 0x080A0001
    IL_0184: conv.r8
    IL_0185: len
    IL_0186: IL_01
    IL_0187: nop
    IL_0188: stloc.0
    IL_0189: ldloc.1
    IL_018A: ldloc.2
    IL_018B: conv.r8
    IL_018C: IL_41
    IL_018D: IL_01
    IL_018E: nop
    IL_018F: stloc.0
    IL_0190: ldloc.0
    IL_0191: conv.r8
    IL_0192: ldarg.3
    IL_0193: nop
    IL_0194: nop
    IL_0195: stloc.0
    IL_0196: dup
    IL_0197: conv.r8
    IL_0198: ldc.i4.2
    IL_0199: nop
    IL_019A: nop
    IL_019B: stloc.0
    IL_019C: IL_22
    IL_019D: nop
    IL_019E: nop
    IL_019F: nop
    IL_01A0: nop
    IL_01A1: IL_22
    IL_01A2: nop
    IL_01A3: nop
    IL_01A8: ldc.i4 8768
    IL_01A9: nop
    IL_1DB7A: switch (30323 cases)
    }

    }}
