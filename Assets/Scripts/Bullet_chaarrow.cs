// Namespace: 
// Type: Bullet_chaarrow

    public class Bullet_chaarrow {{

    private object mytransform;

    public Bullet_chaarrow() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000199
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000199
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: IL_22
    IL_000D: nop
    IL_000E: nop
    IL_0013: stsfld 0x02280240
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: conv.r8
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A0000C2
    IL_0025: call 0x0A000024
    IL_002A: call 0x0A000008
    IL_002F: call 0x0A000029
    IL_0030: conv.r8
    IL_0031: ldloc.3
    IL_0032: nop
    IL_0033: nop
    IL_0034: stloc.0
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000199
    IL_003B: conv.r8
    IL_003C: ldc.i4.2
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: stloc.0
    IL_0042: ldloca.s 0
    IL_0047: ldfld 0x0A000023
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_41
    IL_004E: stloc.2
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: ldarg.0
    IL_0057: call 0x0A00000A
    IL_0058: ldc.i4.0
    IL_0059: conv.r8
    IL_005A: stloc.1
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ret
    }

    }}
