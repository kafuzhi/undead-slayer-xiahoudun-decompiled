// Namespace: 
// Type: Bullet_arrow

    public class Bullet_arrow {{

    public object bullet_speed;
    private object mytransform;

    public Bullet_arrow() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400017A
    IL_000C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400017A
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400017A
    IL_0012: conv.r8
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000024
    IL_0020: call 0x0A000008
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000179
    IL_002B: call 0x0A000008
    IL_0030: call 0x0A000029
    IL_0031: conv.r8
    IL_0032: ldloc.3
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ret
    }

    }}
