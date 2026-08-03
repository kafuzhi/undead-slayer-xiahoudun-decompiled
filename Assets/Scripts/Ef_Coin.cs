// Namespace: 
// Type: Ef_Coin

    public class Ef_Coin {{

    private object mytransform;
    private object d_finish;
    private object targetpos;

    public Ef_Coin() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400054B
    IL_000C: ldarg.0
    IL_0011: call 0x0A00000A
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    public void GetCoin() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400054B
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: ldloc.3
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x0400054D
    IL_0013: ldarg.0
    IL_0018: ldflda 0x0400054D
    IL_0019: ldc.i4.1
    IL_001A: IL_22
    IL_001B: ldelem.i
    IL_001C: IL_99
    IL_001D: ldc.i4.3
    IL_001E: IL_3E
    IL_0023: call 0x0A00001A
    IL_0024: ldarg.0
    IL_0025: IL_22
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002E: stfld 0x0400054C
    IL_002F: ldarg.0
    IL_0034: call 0x0A00000A
    IL_0035: ldc.i4.1
    IL_0036: conv.r8
    IL_0037: stloc.1
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x0400054C
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x0400054C
    IL_0012: ldarg.0
    IL_0017: ldfld 0x0400054C
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_3F
    IL_001D: IL_43
    IL_001F: ldloc.s 0
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_0032: br IL_0083
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400054B
    IL_0039: ldarg.0
    IL_003E: ldfld 0x0400054B
    IL_003F: conv.r8
    IL_0040: ldc.i4.2
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x0400054D
    IL_004E: call 0x0A000024
    IL_004F: IL_22
    IL_0050: nop
    IL_0051: nop
    IL_0056: cpobj 0x63285A41
    IL_0057: nop
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: conv.r8
    IL_005B: ldloc.3
    IL_005C: nop
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400054B
    IL_0069: call 0x0A000007
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_96
    IL_006E: IL_44
    IL_0073: call 0x0A000008
    IL_0078: call 0x0A000024
    IL_007D: call 0x0A000008
    IL_007E: conv.r8
    IL_007F: IL_B5
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: ret
    }

    }}
