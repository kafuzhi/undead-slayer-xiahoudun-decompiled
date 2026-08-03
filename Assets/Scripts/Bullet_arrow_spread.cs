// Namespace: 
// Type: Bullet_arrow_spread

    public class Bullet_arrow_spread {{

    private object mytransform;
    public object bullet_speed;
    public object spread_count;
    public object spread_angle;
    public object sub_arrow;
    private object sub1;
    private object sub2;
    private object a;
    private object b;
    private object damage;

    public Bullet_arrow_spread() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000188
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B00000A
    IL_0017: ldfld 0x04000FE2
    IL_001C: stfld 0x04000191
    IL_001D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400018A
    IL_0006: ldc.i4.0
    IL_0007: IL_3E
    IL_58000010: switch (369098753 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000188
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: stloc.0
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A000023
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_43
    IL_0019: IL_36
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000188
    IL_0023: dup
    IL_0024: conv.r8
    IL_0025: ldc.i4.2
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000188
    IL_002F: conv.r8
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: call 0x0A000024
    IL_003D: call 0x0A000008
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000189
    IL_0048: call 0x0A000008
    IL_004D: call 0x0A000029
    IL_004E: conv.r8
    IL_004F: ldloc.3
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ret
    }

    }}
