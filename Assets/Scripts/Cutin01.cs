// Namespace: 
// Type: Cutin01

    public class Cutin01 {{

    private object starttime;
    private object prevtimescale;
    private object originscale;
    private object originpos;
    private object startlerp;
    private object endlerp;
    private object cinematicMode;
    private object script_cha;
    private object script_cam;
    private object mytransform;
    public object bg_black;

    public Cutin01() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x04827D3F
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_0010: call 0x0A00001B
    IL_0015: stfld 0x04000483
    IL_0016: ldarg.0
    IL_001B: call 0x0A00001B
    IL_0020: stfld 0x04000484
    IL_0021: ldarg.0
    IL_0026: call 0x0A000001
    IL_0027: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400048A
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.2
    IL_000D: nop
    IL_000E: nop
    IL_0010: br.s IL_008E
    IL_0011: IL_88
    IL_0012: ldarg.2
    IL_0013: nop
    IL_0014: ldarg.2
    IL_0015: ldarg.0
    IL_001A: call 0x0A000035
    IL_001B: conv.r8
    IL_001C: ldloc.0
    IL_001D: nop
    IL_001E: nop
    IL_0020: br.s IL_009E
    IL_0021: IL_89
    IL_0022: ldarg.2
    IL_0023: nop
    IL_0024: ldarg.2
    IL_0025: ldarg.0
    IL_002A: call 0x0A00000D
    IL_002B: ldc.i4.0
    IL_002C: conv.r8
    IL_0031: beq IL_20A0032
    IL_0036: call 0x0A00000A
    IL_0037: ldc.i4.0
    IL_0038: conv.r8
    IL_0039: stloc.1
    IL_003A: nop
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: ret
    }

    public void CutinOn() {
    IL_0000: ldarg.0
    IL_0001: ldarg.3
    IL_0006: stfld 0x04000483
    IL_0007: ldarg.0
    IL_000C: call 0x0A00000D
    IL_000D: ldc.i4.1
    IL_000E: conv.r8
    IL_0013: beq IL_20A0014
    IL_0018: call 0x0A000093
    IL_001D: stfld 0x04000482
    IL_001E: ldarg.0
    IL_0023: call 0x0A000131
    IL_0028: stfld 0x04000481
    IL_0029: ldarg.0
    IL_002E: ldfld 0x0400048A
    IL_002F: ldarg.1
    IL_0030: conv.r8
    IL_0031: ldloc.3
    IL_0032: nop
    IL_0033: nop
    IL_0034: stloc.0
    IL_0035: ldarg.0
    IL_003A: ldfld 0x0400048A
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000483
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0048: ldc.i4 534593
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: conv.r8
    IL_004C: IL_AF
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0051: ldarg.s 4
    IL_0056: call 0x0A000111
    IL_0057: ldarg.0
    IL_0058: ldarg.2
    IL_005D: stfld 0x04000484
    IL_005E: ldarg.0
    IL_0060: ldarg.s 5
    IL_0065: stfld 0x04000485
    IL_0066: ldarg.0
    IL_0068: ldarg.s 6
    IL_006D: stfld 0x04000486
    IL_006E: ldarg.0
    IL_0070: ldarg.s 7
    IL_0075: stfld 0x04000487
    IL_0076: ldarg.0
    IL_007B: ldfld 0x0400048B
    IL_007C: conv.r8
    IL_007D: stloc.0
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ldc.i4.1
    IL_0082: conv.r8
    IL_0083: stloc.1
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_0087: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000D
    IL_0006: conv.r8
    IL_0007: IL_C9
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: brfalse IL_019C
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000487
    IL_001A: brfalse IL_002D
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04000488
    IL_0021: conv.r8
    IL_0026: newobj 0x02060001
    IL_0027: ldc.i4.0
    IL_002C: stfld 0x04000487
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000481
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_003C: beq IL_019C
    IL_0041: call 0x0A000131
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000481
    IL_0048: IL_59
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000485
    IL_004F: IL_41
    IL_0050: mul
    IL_0051: nop
    IL_0052: nop
    IL_0053: nop
    IL_0054: ldarg.0
    IL_0059: ldfld 0x0400048A
    IL_005A: ldarg.0
    IL_005F: ldfld 0x0400048A
    IL_0060: conv.r8
    IL_0061: ldc.i4.2
    IL_0062: nop
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000484
    IL_006F: call 0x0A000024
    IL_0070: IL_22
    IL_0071: nop
    IL_0072: nop
    IL_0073: IL_F0
    IL_0074: IL_41
    IL_0075: IL_5A
    IL_007A: call 0x0A000063
    IL_007B: conv.r8
    IL_007C: ldloc.3
    IL_007D: nop
    IL_007E: nop
    IL_007F: stloc.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x0400048A
    IL_0086: ldarg.0
    IL_008B: ldfld 0x0400048A
    IL_008C: conv.r8
    IL_0091: cpobj 0x020A0000
    IL_0096: ldfld 0x04000483
    IL_009B: call 0x0A000024
    IL_009C: IL_22
    IL_009D: nop
    IL_009E: nop
    IL_00A1: ldloc 23106
    IL_00A6: call 0x0A000063
    IL_00A7: conv.r8
    IL_00A8: IL_AF
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: stloc.0
    IL_00B0: br IL_019C
    IL_00B5: call 0x0A000131
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x04000481
    IL_00BC: IL_59
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x04000486
    IL_00C3: IL_41
    IL_00C6: ldarga 0
    IL_00C7: nop
    IL_00C8: ldarg.0
    IL_00CD: ldfld 0x04000482
    IL_00D2: call 0x0A000111
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x0400048A
    IL_00D9: ldarg.0
    IL_00DE: ldfld 0x0400048A
    IL_00DF: conv.r8
    IL_00E4: cpobj 0x020A0000
    IL_00E9: ldfld 0x04000483
    IL_00EA: IL_22
    IL_00EB: nop
    IL_00EC: nop
    IL_00F1: ldc.i4 534593
    IL_00F2: nop
    IL_00F3: stloc.0
    IL_00F8: call 0x0A000024
    IL_00F9: IL_22
    IL_00FB: bne.un.s IL_012F
    IL_00FC: conv.ovf.i4.un
    IL_18CA269: switch (6498394 cases)
    }

    }}
