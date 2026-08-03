// Namespace: 
// Type: Jin

    public class Jin {{

    private object finish_delay;
    private object mytransform;
    public object cyl;
    private object tune_time;
    private object cyl_mat;

    public Jin() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400079F
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040007A0
    IL_0013: conv.r8
    IL_0014: stloc.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: conv.r8
    IL_0019: neg
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_0021: stfld 0x040007A2
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040007A0
    IL_0034: conv.r8
    IL_0035: stloc.0
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldc.i4.0
    IL_003A: conv.r8
    IL_003B: stloc.1
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400079F
    IL_000A: call 0x0A00001B
    IL_000B: conv.r8
    IL_000C: IL_AF
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040007A0
    IL_0016: conv.r8
    IL_0017: stloc.0
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldc.i4.1
    IL_001C: conv.r8
    IL_001D: stloc.1
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ret
    }

    private void Update() {
    IL_0004: call 0x0A000093
    IL_0005: IL_22
    IL_0006: nop
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000E: beq IL_0020
    IL_000F: ldarg.0
    IL_0014: call 0x0A000024
    IL_0019: call 0x0A000093
    IL_001A: add
    IL_001F: stfld 0x040007A1
    IL_0020: ldarg.0
    IL_0021: dup
    IL_0026: ldfld 0x0400079E
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040007A1
    IL_002D: IL_58
    IL_0032: stfld 0x0400079E
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040007A2
    IL_0039: dup
    IL_003A: conv.r8
    IL_003F: newobj 0x280A0001
    IL_0040: IL_AA
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040007A1
    IL_004E: call 0x0A000083
    IL_004F: IL_22
    IL_0050: nop
    IL_0051: nop
    IL_20CA156: switch (8595520 cases)
    }

    }}
