// Namespace: 
// Type: RiseAttack

    public class RiseAttack {{

    public object emitfinish_time;
    public object destroy_time;
    public object movespeed;
    private object mytransform;
    private object mycollider;

    public RiseAttack() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008AB
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040008AC
    IL_0018: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x7002294C
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008A8
    IL_0010: call 0x0A00003F
    IL_0011: ldarg.0
    IL_0016: ldstr 0x70022962
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040008A9
    IL_0021: call 0x0A00003F
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040008AC
    IL_0028: ldc.i4.1
    IL_0029: conv.r8
    IL_002B: ldc.i4.s 0
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: call 0x0A0000B0
    IL_0034: ldc.i4.1
    IL_0035: conv.r8
    IL_0036: IL_B6
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: ret
    }

    public void EmitFinish() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000B0
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: IL_B6
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008AC
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    public void DestroyEmitter() {
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
    IL_0005: ldfld 0x040008AB
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008AB
    IL_0012: conv.r8
    IL_0017: brtrue IL_280A0019
    IL_0018: IL_24
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000008
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040008AA
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
