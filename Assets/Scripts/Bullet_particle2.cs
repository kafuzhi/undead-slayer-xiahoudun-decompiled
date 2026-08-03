// Namespace: 
// Type: Bullet_particle2

    public class Bullet_particle2 {{

    public object emitfinishdelay;
    public object disable_delay;
    public object expand_factor;
    private object mytransform;
    private object originscale;

    public Bullet_particle2() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001D7
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040001D7
    IL_0013: conv.r8
    IL_0018: cpobj 0x7D0A0000
    IL_0019: IL_D8
    IL_001A: IL_01
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000B5D
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040001D4
    IL_0010: call 0x0A00003F
    IL_0011: ldarg.0
    IL_0016: ldstr 0x70000B2B
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040001D5
    IL_0021: call 0x0A00003F
    IL_0022: ldarg.0
    IL_0027: call 0x0A0000B0
    IL_0028: ldc.i4.1
    IL_0029: conv.r8
    IL_002A: IL_B6
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040001D7
    IL_0034: ldarg.0
    IL_0039: ldfld 0x040001D8
    IL_003A: conv.r8
    IL_003B: IL_AF
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: call 0x0A000003
    IL_0045: ldc.i4.1
    IL_0046: conv.r8
    IL_0048: ldc.i4.s 0
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: ret
    }

    private void StopEmit() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000B0
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: IL_B6
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: call 0x0A000003
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void finishObj() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001D7
    IL_0006: dup
    IL_0007: conv.r8
    IL_000C: cpobj 0x280A0000
    IL_000D: localloc
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: call 0x0A000024
    IL_001A: call 0x0A000008
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040001D6
    IL_0025: call 0x0A000008
    IL_002A: call 0x0A000029
    IL_002B: conv.r8
    IL_002C: IL_AF
    IL_002D: nop
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ret
    }

    }}
