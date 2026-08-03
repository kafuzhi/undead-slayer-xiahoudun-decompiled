// Namespace: 
// Type: Bullet_sword

    public class Bullet_sword {{

    private object mytransform;

    public Bullet_sword() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001F9
    IL_000C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001F9
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: call 0x0A000007
    IL_0015: call 0x0A000024
    IL_001A: call 0x0A000008
    IL_001B: IL_22
    IL_001C: IL_CD
    IL_001D: IL_CC
    IL_001E: IL_CC
    IL_001F: IL_3D
    IL_0024: call 0x0A000008
    IL_0029: call 0x0A000029
    IL_002A: conv.r8
    IL_002B: ldloc.3
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_002F: ret
    }

    }}
