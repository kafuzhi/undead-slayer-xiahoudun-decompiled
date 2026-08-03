// Namespace: 
// Type: FPS

    public class FPS {{

    public object updateInterval;
    private object accum;
    private object frames;
    private object timeleft;

    public FPS() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: IL_3F
    IL_000A: stfld 0x04000656
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000180
    IL_000A: call 0x0A00004A
    IL_000F: brtrue IL_0022
    IL_0014: ldstr 0x700024E7
    IL_0019: call 0x0A00013D
    IL_001A: ldarg.0
    IL_001B: ldc.i4.0
    IL_0020: call 0x0A000049
    IL_0021: ret
    IL_0022: ldarg.0
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000656
    IL_002D: stfld 0x04000659
    IL_002E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000659
    IL_000B: call 0x0A000024
    IL_000C: IL_59
    IL_0011: stfld 0x04000659
    IL_0012: ldarg.0
    IL_0013: dup
    IL_0018: ldfld 0x04000657
    IL_001D: call 0x0A000093
    IL_0022: call 0x0A000024
    IL_0023: add
    IL_0024: IL_58
    IL_0029: stfld 0x04000657
    IL_002A: ldarg.0
    IL_002B: dup
    IL_0030: ldfld 0x04000658
    IL_0031: ldc.i4.1
    IL_0032: IL_58
    IL_0037: stfld 0x04000658
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000659
    IL_003E: conv.i4
    IL_003F: IL_23
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: IL_42
    IL_0049: IL_A9
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000657
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000658
    IL_0059: conv.i2
    IL_005A: add
    IL_005B: stloc.0
    IL_0060: ldstr 0x7000254B
    IL_0061: ldloc.0
    IL_0066: newobj 0x0100002F
    IL_006B: call 0x0A000181
    IL_006C: stloc.1
    IL_006D: ldarg.0
    IL_0072: call 0x0A000180
    IL_0073: ldloc.1
    IL_0074: conv.r8
    IL_0075: IL_82
    IL_0076: IL_01
    IL_0077: nop
    IL_0078: stloc.0
    IL_0079: ldloc.0
    IL_007A: IL_22
    IL_007B: nop
    IL_007C: nop
    IL_007D: IL_F0
    IL_007E: IL_41
    IL_007F: IL_41
    IL_0080: ldc.i4.4
    IL_0081: nop
    IL_0082: nop
    IL_0083: nop
    IL_0084: ldarg.0
    IL_0089: call 0x0A000180
    IL_008A: conv.r8
    IL_008B: IL_83
    IL_008C: IL_01
    IL_008D: nop
    IL_008E: stloc.0
    IL_0093: call 0x0A000184
    IL_0094: conv.r8
    IL_0095: IL_85
    IL_0096: IL_01
    IL_0097: nop
    IL_0098: stloc.0
    IL_009D: br IL_00D8
    IL_009E: ldloc.0
    IL_009F: IL_22
    IL_00A0: nop
    IL_00A1: nop
    IL_00A6: ldc.i4 1720641
    IL_00A7: nop
    IL_00A8: nop
    IL_00A9: ldarg.0
    IL_00AE: call 0x0A000180
    IL_00AF: conv.r8
    IL_00B0: IL_83
    IL_00B1: IL_01
    IL_00B2: nop
    IL_00B3: stloc.0
    IL_00B8: call 0x0A000186
    IL_00B9: conv.r8
    IL_00BA: IL_85
    IL_00BB: IL_01
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00C2: br IL_00D8
    IL_00C3: ldarg.0
    IL_00C8: call 0x0A000180
    IL_00C9: conv.r8
    IL_00CA: IL_83
    IL_00CB: IL_01
    IL_00CC: nop
    IL_00CD: stloc.0
    IL_00D2: call 0x0A000187
    IL_00D3: conv.r8
    IL_00D4: IL_85
    IL_00D5: IL_01
    IL_00D6: nop
    IL_00D7: stloc.0
    IL_00D8: ldarg.0
    IL_00D9: ldarg.0
    IL_00DE: ldfld 0x04000656
    IL_00E3: stfld 0x04000659
    IL_00E4: ldarg.0
    IL_00E5: IL_22
    IL_00E6: nop
    IL_00E7: nop
    IL_00E8: nop
    IL_00E9: nop
    IL_00EE: stfld 0x04000657
    IL_00EF: ldarg.0
    IL_00F0: ldc.i4.0
    IL_00F5: stfld 0x04000658
    IL_00F6: ret
    }

    }}
