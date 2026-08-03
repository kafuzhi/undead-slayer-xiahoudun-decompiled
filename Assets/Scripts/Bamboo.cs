// Namespace: 
// Type: Bamboo

    public class Bamboo {{

    private object mytransform;
    public object collideroff;
    public object finishdelay;
    private object delay;
    private object mycollider;
    private object originpos;
    private object next;

    public Bamboo() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: shr
    IL_0003: shr
    IL_0004: IL_86
    IL_501FD: switch (82045 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400013E
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000142
    IL_0018: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x0400013E
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x04000143
    IL_0011: ldarg.0
    IL_0016: ldflda 0x04000143
    IL_0017: ldc.i4.1
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_0021: call 0x0A00001A
    IL_0022: ldarg.0
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_002C: stfld 0x04000141
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000142
    IL_0033: ldc.i4.1
    IL_0034: conv.r8
    IL_0036: ldc.i4.s 0
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldarg.0
    IL_003E: ldfld 0x04000142
    IL_003F: ldc.i4.1
    IL_0040: conv.r8
    IL_0041: conv.ovf.i4.un
    IL_0042: nop
    IL_0043: nop
    IL_0044: stloc.0
    IL_0045: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000141
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04000141
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000141
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000140
    IL_001E: IL_43
    IL_0023: ldsfld 0x02000000
    IL_0028: ldfld 0x0400013E
    IL_0029: dup
    IL_002A: conv.r8
    IL_002B: ldc.i4.2
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_0033: call 0x0A000007
    IL_0038: call 0x0A000024
    IL_003D: call 0x0A000008
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_20E6: switch (2088 cases)
    }

    }}
