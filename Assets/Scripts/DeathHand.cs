// Namespace: 
// Type: DeathHand

    public class DeathHand {{

    private object finish_delay;
    private object start_delay;
    private object current_time;
    private object mycollider;
    private object mytransform;
    private object myparent;
    private object myrenderer;
    private object dash;
    private object pt;
    private object script_cha;
    private object fogdelay;

    public DeathHand() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: ldelem.i
    IL_0003: IL_99
    IL_0004: IL_99
    IL_0005: IL_3F
    IL_000A: stfld 0x04000526
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: IL_CD
    IL_000E: IL_CC
    IL_000F: IL_CC
    IL_0010: IL_3E
    IL_0015: stfld 0x04000527
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: IL_CD
    IL_0019: IL_CC
    IL_001A: IL_4C
    IL_001B: IL_3E
    IL_0020: stfld 0x04000530
    IL_0021: ldarg.0
    IL_0026: call 0x0A000001
    IL_0027: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400052A
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000529
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A00000D
    IL_0023: stfld 0x0400052C
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000529
    IL_002A: ldc.i4.0
    IL_002B: conv.r8
    IL_002D: ldc.i4.s 0
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400052C
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: beq IL_20A000D
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400052A
    IL_0013: ldc.i4.0
    IL_0014: conv.r8
    IL_0019: brtrue IL_7D0A001A
    IL_001B: beq.s IL_0021
    IL_001C: nop
    IL_001D: ldarg.2
    IL_001E: ldarg.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x0400052A
    IL_0025: conv.r8
    IL_0026: IL_CD
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002E: stfld 0x0400052B
    IL_002F: ldarg.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x0400052B
    IL_0036: conv.r8
    IL_0037: stloc.2
    IL_0038: nop
    IL_0039: nop
    IL_003B: br.s IL_00B9
    IL_003D: bge.s IL_0043
    IL_003E: nop
    IL_003F: ldarg.2
    IL_0040: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000528
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04000528
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000528
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000526
    IL_001E: IL_43
    IL_001F: IL_4C
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: ldarg.0
    IL_0028: call 0x0A00000A
    IL_0029: ldc.i4.0
    IL_002A: conv.r8
    IL_002B: stloc.1
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_002F: ldarg.0
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0039: stfld 0x04000528
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000529
    IL_0040: ldc.i4.0
    IL_0041: conv.r8
    IL_0043: ldc.i4.s 0
    IL_0044: nop
    IL_0045: stloc.0
    IL_0046: ldarg.0
    IL_004B: ldfld 0x0400052C
    IL_004C: ldc.i4.0
    IL_004D: conv.r8
    IL_0052: beq IL_20A0053
    IL_0053: ldc.i4.0
    IL_0058: stfld 0x0400052D
    IL_0059: ldarg.0
    IL_005E: ldfld 0x0400052E
    IL_005F: conv.r8
    IL_0060: IL_B0
    IL_0061: nop
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldc.i4.0
    IL_0065: conv.r8
    IL_0066: IL_B6
    IL_0067: nop
    IL_0068: nop
    IL_0069: stloc.0
    IL_006E: br IL_011E
    IL_006F: ldarg.0
    IL_0074: ldfld 0x04000528
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000527
    IL_007B: IL_43
    IL_007C: ldelem.i8
    IL_007D: nop
    IL_007E: nop
    IL_007F: nop
    IL_0080: ldarg.0
    IL_0085: ldfld 0x0400052D
    IL_008A: brtrue IL_00E0
    IL_008B: ldarg.0
    IL_008C: ldc.i4.1
    IL_0091: stfld 0x0400052D
    IL_0092: ldarg.0
    IL_0097: ldfld 0x0400052B
    IL_0098: conv.r8
    IL_0099: IL_3D
    IL_009A: nop
    IL_009B: nop
    IL_009C: stloc.0
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x0400052B
    IL_00A3: conv.r8
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: stloc.0
    IL_00A8: IL_22
    IL_00A9: nop
    IL_00AA: nop
    IL_00AD: ldloc 10307
    IL_00AE: ldloc.2
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: stloc.0
    IL_00B2: conv.r8
    IL_00B3: IL_3E
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: stloc.0
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x0400052C
    IL_00BD: ldc.i4.1
    IL_00BE: conv.r8
    IL_00C3: beq IL_20A00C4
    IL_00C8: ldfld 0x04000529
    IL_00C9: ldc.i4.1
    IL_00CA: conv.r8
    IL_00CC: ldc.i4.s 0
    IL_00CD: nop
    IL_00CE: stloc.0
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x0400052E
    IL_00D5: conv.r8
    IL_00D6: IL_B0
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: stloc.0
    IL_00DA: ldc.i4.1
    IL_00DB: conv.r8
    IL_00DC: IL_B6
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: stloc.0
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000530
    IL_00E6: IL_22
    IL_00E7: IL_CD
    IL_00E8: IL_CC
    IL_00E9: IL_4C
    IL_00EA: IL_3E
    IL_00EB: IL_44
    IL_00EC: ldc.i4.6
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: ldarg.0
    IL_00F5: ldfld 0x0400052F
    IL_00F6: ldc.i4.1
    IL_00F7: conv.r8
    IL_00F8: throw
    IL_00F9: IL_01
    IL_00FA: nop
    IL_00FB: ldloc.0
    IL_00FC: ldarg.0
    IL_00FD: IL_22
    IL_00FE: nop
    IL_00FF: nop
    IL_0100: nop
    IL_0101: nop
    IL_0106: stfld 0x04000530
    IL_010B: br IL_011E
    IL_010C: ldarg.0
    IL_010D: dup
    IL_0112: ldfld 0x04000530
    IL_0117: call 0x0A000024
    IL_0118: IL_58
    IL_011D: stfld 0x04000530
    IL_011E: ret
    }

    }}
