// Namespace: 
// Type: Bullet_delay2

    public class Bullet_delay2 {{

    public object show_delay;
    public object disable_delay;
    public object moveleft;
    private object mytransform;

    public Bullet_delay2() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001A7
    IL_000C: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000B19
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040001A4
    IL_0010: call 0x0A00003F
    IL_0011: ldarg.0
    IL_0016: ldstr 0x70000B2B
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040001A5
    IL_0021: call 0x0A00003F
    IL_0022: ldarg.0
    IL_0027: call 0x0A000003
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002B: ldc.i4.s 0
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ret
    }

    private void StartObj() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: call 0x0A000003
    IL_0012: ldc.i4.1
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
    IL_000C: ldarg.0
    IL_0011: call 0x0A000003
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001A6
    IL_000A: brfalse IL_0040
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040001A7
    IL_0011: dup
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040001A7
    IL_001D: conv.r8
    IL_001E: mul
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0026: call 0x0A000024
    IL_002B: call 0x0A000008
    IL_002C: IL_22
    IL_002D: IL_CD
    IL_002E: IL_CC
    IL_002F: IL_4C
    IL_0030: IL_3E
    IL_0035: call 0x0A000008
    IL_003A: call 0x0A000019
    IL_003B: conv.r8
    IL_003C: ldloc.3
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ret
    }

    }}
