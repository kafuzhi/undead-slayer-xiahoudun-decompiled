// Namespace: 
// Type: Ef_stepfog

    public class Ef_stepfog {{

    public object fogheight;
    public object fogspeed;
    public object fogalpha;
    public object smoothfactor;
    public object xyratio;
    private object dt;
    private object myrenderer;
    private object mytransform;
    private object growVector;
    private object smoothgrowVector;
    private object currentColor;
    private object targetColor;
    private object transColor;
    private object originScale;

    public Ef_stepfog() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000600
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0017: stfld 0x040005FF
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000600
    IL_0007: conv.r8
    IL_000C: cpobj 0x7D0A0000
    IL_000D: ldloc.0
    IL_000E: ldloc.0
    IL_000F: nop
    IL_0010: ldarg.2
    IL_0011: ldarg.0
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: IL_3F
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
    IL_0021: IL_22
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_002A: newobj 0x0A0000C4
    IL_002F: stfld 0x04000604
    IL_0030: ldarg.0
    IL_0035: ldfld 0x040005FF
    IL_0036: ldc.i4.0
    IL_0037: conv.r8
    IL_003C: beq IL_20A003D
    IL_0041: ldfld 0x040005FF
    IL_0042: conv.r8
    IL_0044: ldarg.s 0
    IL_0045: nop
    IL_0046: stloc.0
    IL_004B: ldstr 0x70000B47
    IL_0050: call 0x0A0000C5
    IL_0051: conv.r8
    IL_0052: IL_C6
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldarg.0
    IL_0057: ldarg.0
    IL_005C: ldfld 0x040005FA
    IL_005D: ldarg.0
    IL_0062: ldfld 0x040005FA
    IL_0063: ldarg.0
    IL_0068: ldfld 0x040005FD
    IL_0069: IL_5A
    IL_006A: ldarg.0
    IL_006F: ldfld 0x040005FA
    IL_0074: newobj 0x0A000076
    IL_0079: stfld 0x04000601
    IL_007A: ldarg.0
    IL_007B: ldarg.0
    IL_0080: ldfld 0x040005FA
    IL_0081: ldarg.0
    IL_0086: ldfld 0x040005FC
    IL_0087: IL_5A
    IL_0088: ldarg.0
    IL_008D: ldfld 0x040005FA
    IL_008E: ldarg.0
    IL_0093: ldfld 0x040005FC
    IL_0094: IL_5A
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: nop
    IL_0099: IL_3F
    IL_009A: IL_5A
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x040005FA
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x040005FC
    IL_00A7: IL_5A
    IL_00AC: newobj 0x0A000076
    IL_00B1: stfld 0x04000602
    IL_00B2: ldarg.0
    IL_00B7: call 0x0A00000A
    IL_00B8: ldc.i4.0
    IL_00B9: conv.r8
    IL_00BA: stloc.1
    IL_00BB: nop
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00BE: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040005FE
    IL_0006: IL_22
    IL_0007: IL_CD
    IL_0008: IL_CC
    IL_0009: IL_CC
    IL_000A: IL_3D
    IL_000B: IL_41
    IL_000C: ldc.i4.1
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x040005FE
    IL_001B: call 0x0A000024
    IL_001C: IL_58
    IL_0021: stfld 0x040005FE
    IL_0026: br IL_0033
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040005FF
    IL_002D: ldc.i4.1
    IL_002E: conv.r8
    IL_0033: beq IL_20A0034
    IL_0038: ldfld 0x040005FF
    IL_0039: conv.r8
    IL_003A: IL_C9
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_0042: brfalse IL_019D
    IL_0043: ldarg.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040005FF
    IL_004A: conv.r8
    IL_004C: ldarg.s 0
    IL_004D: nop
    IL_004E: stloc.0
    IL_0053: ldstr 0x70000B47
    IL_0054: conv.r8
    IL_0055: IL_C7
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_005D: stfld 0x04000603
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000603
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000604
    IL_006F: call 0x0A000024
    IL_0070: ldarg.0
    IL_0075: ldfld 0x040005FB
    IL_0076: conv.i2
    IL_0077: IL_5A
    IL_007C: call 0x0A0000C8
    IL_0081: stfld 0x04000605
    IL_0082: ldarg.0
    IL_0087: ldfld 0x040005FF
    IL_0088: conv.r8
    IL_008A: ldarg.s 0
    IL_008B: nop
    IL_008C: stloc.0
    IL_0091: ldstr 0x70000B47
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000605
    IL_0098: conv.r8
    IL_0099: IL_C6
    IL_009A: nop
    IL_009B: nop
    IL_009C: stloc.0
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x04000600
    IL_00A3: conv.r8
    IL_00A8: cpobj 0x0A0A0000
    IL_00AA: ldloca.s 0
    IL_00AF: ldfld 0x0A000023
    IL_00B0: ldarg.0
    IL_00B5: ldfld 0x040005F9
    IL_00B6: IL_43
    IL_00B7: conv.i8
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: ldarg.0
    IL_00C0: ldfld 0x04000600
    IL_00C5: call 0x0A00004B
    IL_00C6: IL_22
    IL_00C7: nop
    IL_00C8: nop
    IL_00CD: stsfld 0x00082840
    IL_00CE: nop
    IL_00CF: stloc.0
    IL_00D0: conv.r8
    IL_00D1: ldloc.3
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: stloc.0
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x040005FF
    IL_00DB: ldc.i4.0
    IL_00DC: conv.r8
    IL_00E1: beq IL_20A00E2
    IL_00E6: call 0x0A00000A
    IL_00E7: ldc.i4.0
    IL_00E8: conv.r8
    IL_00E9: stloc.1
    IL_00EA: nop
    IL_00EB: nop
    IL_00EC: stloc.0
    IL_00ED: ldarg.0
    IL_00EE: IL_22
    IL_00EF: nop
    IL_00F0: nop
    IL_00F1: nop
    IL_00F2: nop
    IL_00F7: stfld 0x040005FE
    IL_00F8: ldarg.0
    IL_00FD: ldfld 0x040005FF
    IL_00FE: conv.r8
    IL_0100: ldarg.s 0
    IL_0101: nop
    IL_0102: stloc.0
    IL_0107: ldstr 0x70000B47
    IL_010C: call 0x0A0000C5
    IL_010D: conv.r8
    IL_010E: IL_C6
    IL_010F: nop
    IL_0110: nop
    IL_0111: stloc.0
    IL_0112: ldarg.0
    IL_0117: ldfld 0x04000600
    IL_0118: ldarg.0
    IL_011D: ldfld 0x04000606
    IL_011E: conv.r8
    IL_011F: IL_AF
    IL_0120: nop
    IL_0121: nop
    IL_0122: stloc.0
    IL_0127: br IL_019D
    IL_0128: ldarg.0
    IL_012D: ldfld 0x04000600
    IL_012E: conv.r8
    IL_0133: cpobj 0x0B0A0000
    IL_0135: ldloca.s 1
    IL_013A: ldfld 0x0A000023
    IL_013B: ldarg.0
    IL_0140: ldfld 0x040005F9
    IL_0141: IL_22
    IL_0142: IL_CD
    IL_0143: IL_CC
    IL_0144: IL_4C
    IL_0145: IL_3F
    IL_0146: IL_5A
    IL_0147: IL_43
    IL_0149: br.s IL_014A
    IL_014A: nop
    IL_014B: nop
    IL_014C: ldarg.0
    IL_0151: ldfld 0x04000600
    IL_0152: dup
    IL_0153: conv.r8
    IL_0158: cpobj 0x020A0000
    IL_015D: ldfld 0x04000602
    IL_0162: call 0x0A000024
    IL_0167: call 0x0A000008
    IL_016C: call 0x0A000029
    IL_016D: conv.r8
    IL_016E: IL_AF
    IL_016F: nop
    IL_0170: nop
    IL_0171: stloc.0
    IL_0176: br IL_019D
    IL_0177: ldarg.0
    IL_017C: ldfld 0x04000600
    IL_017D: dup
    IL_017E: conv.r8
    IL_0183: cpobj 0x020A0000
    IL_0188: ldfld 0x04000601
    IL_018D: call 0x0A000024
    IL_0192: call 0x0A000008
    IL_0197: call 0x0A000029
    IL_0198: conv.r8
    IL_0199: IL_AF
    IL_019A: nop
    IL_019B: nop
    IL_019C: stloc.0
    IL_019D: ret
    }

    }}
