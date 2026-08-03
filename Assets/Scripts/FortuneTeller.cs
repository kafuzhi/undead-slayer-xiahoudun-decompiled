// Namespace: 
// Type: FortuneTeller

    public class FortuneTeller {{

    private object mytransform;
    public object main_material;
    public object ef_shuffle;
    private object c_plane;
    private object creatrender;
    private object creat_delay;
    private object efon;
    private object targetVector;

    public FortuneTeller() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400066A
    IL_000C: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400066C
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
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: IL_22
    IL_0018: IL_CD
    IL_0019: IL_CC
    IL_001A: IL_4C
    IL_001B: IL_3E
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_3F
    IL_0025: newobj 0x0A000076
    IL_002A: stfld 0x04000671
    IL_002B: ldarg.0
    IL_0030: ldfld 0x0400066A
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000671
    IL_003B: call 0x0A000007
    IL_003C: IL_22
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_20E4: switch (2088 cases)
    }

    public void FortuneMesh() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70002587
    IL_000A: newobj 0x0A00013F
    IL_000F: stfld 0x0400066D
    IL_0010: ldarg.0
    IL_0015: ldfld 0x0400066D
    IL_0016: conv.r8
    IL_0017: IL_43
    IL_0018: nop
    IL_0019: nop
    IL_001B: br.s IL_0026
    IL_0020: newobj 0x0A000145
    IL_0021: stloc.1
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400066D
    IL_0028: conv.r8
    IL_002B: ldloca 0
    IL_002D: br.s IL_0054
    IL_002E: ldloc.1
    IL_002F: ldc.i4.4
    IL_0034: newarr 0x01000007
    IL_0035: dup
    IL_0036: ldc.i4.0
    IL_0037: IL_8F
    IL_0038: ldloc.1
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_01
    IL_0040: call 0x0A000007
    IL_0041: ldarg.1
    IL_0042: conv.i2
    IL_0047: call 0x0A000008
    IL_0048: IL_22
    IL_0049: IL_CD
    IL_004A: IL_CC
    IL_004B: IL_CC
    IL_004C: IL_3D
    IL_0051: call 0x0A000008
    IL_0052: IL_81
    IL_0053: ldloc.1
    IL_0054: nop
    IL_0055: nop
    IL_0056: IL_01
    IL_0057: dup
    IL_0058: ldc.i4.1
    IL_0059: IL_8F
    IL_005A: ldloc.1
    IL_005B: nop
    IL_005C: nop
    IL_005D: IL_01
    IL_0062: call 0x0A000062
    IL_0063: ldarg.2
    IL_0064: conv.i2
    IL_0069: call 0x0A000008
    IL_006A: IL_22
    IL_006B: IL_CD
    IL_006C: IL_CC
    IL_006D: IL_CC
    IL_006E: IL_3D
    IL_0073: call 0x0A000008
    IL_0074: IL_81
    IL_0075: ldloc.1
    IL_0076: nop
    IL_0077: nop
    IL_0078: IL_01
    IL_0079: dup
    IL_007A: ldc.i4.2
    IL_007B: IL_8F
    IL_007C: ldloc.1
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_01
    IL_0084: call 0x0A000062
    IL_0089: call 0x0A000043
    IL_008B: ldarg.s 4
    IL_008C: conv.i2
    IL_0091: call 0x0A000008
    IL_0092: IL_22
    IL_0093: IL_CD
    IL_0094: IL_CC
    IL_0095: IL_CC
    IL_0096: IL_3D
    IL_009B: call 0x0A000008
    IL_009C: IL_81
    IL_009D: ldloc.1
    IL_009E: nop
    IL_009F: nop
    IL_00A0: IL_01
    IL_00A1: dup
    IL_00A2: ldc.i4.3
    IL_00A3: IL_8F
    IL_00A4: ldloc.1
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: IL_01
    IL_00AC: call 0x0A000007
    IL_00B1: call 0x0A000043
    IL_00B2: ldarg.3
    IL_00B3: conv.i2
    IL_00B8: call 0x0A000008
    IL_00B9: IL_22
    IL_00BA: IL_CD
    IL_00BB: IL_CC
    IL_00BC: IL_CC
    IL_00BD: IL_3D
    IL_00C2: call 0x0A000008
    IL_00C3: IL_81
    IL_00C4: ldloc.1
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: IL_01
    IL_00C8: conv.r8
    IL_00C9: IL_89
    IL_00CA: IL_01
    IL_00CB: nop
    IL_00CC: stloc.0
    IL_00CD: ldloc.1
    IL_00CE: ldc.i4.4
    IL_00D3: newarr 0x01000014
    IL_00D4: dup
    IL_00D5: ldc.i4.0
    IL_00D6: IL_8F
    IL_00D7: ldnull
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: IL_01
    IL_00DF: call 0x0A0000AA
    IL_00E0: IL_81
    IL_00E1: ldnull
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: IL_01
    IL_00E5: dup
    IL_00E6: ldc.i4.1
    IL_00E7: IL_8F
    IL_00E8: ldnull
    IL_00E9: nop
    IL_00EA: nop
    IL_00EB: IL_01
    IL_00F0: call 0x0A0000FA
    IL_00F1: IL_81
    IL_00F2: ldnull
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: IL_01
    IL_00F6: dup
    IL_00F7: ldc.i4.2
    IL_00F8: IL_8F
    IL_00F9: ldnull
    IL_00FA: nop
    IL_00FB: nop
    IL_00FC: IL_01
    IL_0101: call 0x0A000057
    IL_0102: IL_81
    IL_0103: ldnull
    IL_0104: nop
    IL_0105: nop
    IL_0106: IL_01
    IL_0107: dup
    IL_0108: ldc.i4.3
    IL_0109: IL_8F
    IL_010A: ldnull
    IL_010B: nop
    IL_010C: nop
    IL_010D: IL_01
    IL_0112: call 0x0A000082
    IL_0113: IL_81
    IL_0114: ldnull
    IL_0115: nop
    IL_0116: nop
    IL_0117: IL_01
    IL_0118: conv.r8
    IL_0119: IL_AC
    IL_011A: nop
    IL_011B: nop
    IL_011C: stloc.0
    IL_011D: ldarg.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x0400066D
    IL_0124: conv.r8
    IL_0125: ldind.ref
    IL_0126: IL_01
    IL_0127: nop
    IL_0128: stloc.0
    IL_012D: stfld 0x0400066E
    IL_012E: ldarg.0
    IL_0133: ldfld 0x0400066E
    IL_0134: ldc.i4.0
    IL_0135: conv.r8
    IL_013A: beq IL_20A013B
    IL_013F: ldfld 0x0400066E
    IL_0140: ldarg.0
    IL_0145: ldfld 0x0400066B
    IL_0146: conv.r8
    IL_0147: stind.i
    IL_0148: IL_01
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: ldloc.1
    IL_014C: ldc.i4.6
    IL_0151: newarr 0x0100000B
    IL_0152: dup
    IL_0157: ldtoken 0x040010B5
    IL_015C: call 0x0A00018C
    IL_015D: conv.r8
    IL_0162: newarr 0x070A0001
    IL_0163: conv.r8
    IL_0164: len
    IL_0165: IL_01
    IL_0166: nop
    IL_0167: stloc.0
    IL_0168: ldloc.0
    IL_0169: ldloc.1
    IL_016A: conv.r8
    IL_016B: IL_41
    IL_016C: IL_01
    IL_016D: nop
    IL_016E: stloc.0
    IL_016F: ldarg.0
    IL_0174: ldfld 0x0400066D
    IL_0175: conv.r8
    IL_0176: ldarg.3
    IL_0177: nop
    IL_0178: nop
    IL_0179: stloc.0
    IL_017A: ldarg.0
    IL_017F: ldfld 0x0400066A
    IL_0180: conv.r8
    IL_0181: ldc.i4.2
    IL_0182: nop
    IL_0183: nop
    IL_0184: stloc.0
    IL_0189: call 0x0A000042
    IL_018A: IL_22
    IL_018B: IL_CD
    IL_018C: IL_CC
    IL_018D: IL_CC
    IL_018E: IL_3D
    IL_0193: call 0x0A000008
    IL_0198: call 0x0A000029
    IL_019D: call 0x0A000007
    IL_019E: IL_22
    IL_019F: stloc.0
    IL_01A0: IL_D7
    IL_01A1: stelem.i
    IL_01A2: IL_BE
    IL_01A7: call 0x0A000008
    IL_01AC: call 0x0A000029
    IL_01AD: conv.r8
    IL_01AE: ldloc.3
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: stloc.0
    IL_01B2: ldarg.0
    IL_01B7: ldfld 0x0400066D
    IL_01B8: conv.r8
    IL_01B9: ldarg.3
    IL_01BA: nop
    IL_01BB: nop
    IL_01BC: stloc.0
    IL_01BD: ldarg.0
    IL_01C2: ldfld 0x0400066A
    IL_01C3: conv.r8
    IL_01C4: IL_4E
    IL_01C5: nop
    IL_01C6: nop
    IL_01C7: stloc.0
    IL_01C8: ldarg.0
    IL_01CD: ldfld 0x0400066D
    IL_01CE: ldarg.0
    IL_01D3: ldfld 0x0400066A
    IL_01D4: conv.r8
    IL_01D5: stloc.0
    IL_01D6: nop
    IL_01D7: nop
    IL_01D8: stloc.0
    IL_01D9: conv.r8
    IL_01DA: ldc.i4.8
    IL_01DB: nop
    IL_01DC: nop
    IL_01DD: stloc.0
    IL_01DE: conv.r8
    IL_01DF: ldc.i4.m1
    IL_01E0: nop
    IL_01E1: nop
    IL_01E2: stloc.0
    IL_01E3: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400066F
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_E90D0D: switch (3818304 cases)
    }

    }}
