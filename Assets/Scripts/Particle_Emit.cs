// Namespace: 
// Type: Particle_Emit

    public class Particle_Emit {{

    public object emitfinish_time;
    public object destroy_time;
    public object show_time;
    public object movespeed;
    public object ismoveup;
    private object move;
    private object mytransform;
    private object mycollider;
    private object colliderexist;

    public Particle_Emit() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400084D
    IL_000C: ldarg.0
    IL_0011: call 0x0A000003
    IL_0012: ldnull
    IL_0017: call 0x0A000021
    IL_001C: brfalse IL_0030
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: call 0x0A000003
    IL_0028: stfld 0x0400084E
    IL_0029: ldarg.0
    IL_002A: ldc.i4.1
    IL_002F: stfld 0x0400084F
    IL_0030: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70022938
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000849
    IL_0010: call 0x0A00003F
    IL_0011: ldarg.0
    IL_0016: ldstr 0x7002294C
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000847
    IL_0021: call 0x0A00003F
    IL_0022: ldarg.0
    IL_0027: ldstr 0x70022962
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000848
    IL_0032: call 0x0A00003F
    IL_0033: ldarg.0
    IL_0034: ldc.i4.0
    IL_0039: stfld 0x0400084C
    IL_003A: ret
    }

    public void EmitStart() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000B0
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: IL_B6
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldc.i4.1
    IL_0012: stfld 0x0400084C
    IL_0013: ldarg.0
    IL_0018: ldfld 0x0400084F
    IL_001D: brfalse IL_0033
    IL_001E: ldarg.0
    IL_0023: ldstr 0x70022980
    IL_0024: IL_22
    IL_0025: IL_CD
    IL_0026: IL_CC
    IL_0027: IL_CC
    IL_0028: IL_3D
    IL_0029: IL_22
    IL_002A: ldelem.i
    IL_002B: IL_99
    IL_002C: IL_99
    IL_002D: IL_3E
    IL_0032: call 0x0A000017
    IL_0033: ret
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
    IL_0011: ldfld 0x0400084F
    IL_0016: brfalse IL_002E
    IL_0017: ldarg.0
    IL_001C: ldstr 0x70022980
    IL_0021: call 0x0A00007B
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400084E
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002B: ldc.i4.s 0
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ret
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

    private void RepeatDamage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400084E
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400084E
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400084C
    IL_000A: brfalse IL_0081
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400084B
    IL_0015: brtrue IL_0051
    IL_0016: ldarg.0
    IL_001B: ldfld 0x0400084D
    IL_001C: dup
    IL_001D: conv.r8
    IL_001E: ldc.i4.2
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400084D
    IL_0028: conv.r8
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_0031: call 0x0A000024
    IL_0036: call 0x0A000008
    IL_0037: ldarg.0
    IL_003C: ldfld 0x0400084A
    IL_0041: call 0x0A000008
    IL_0046: call 0x0A000029
    IL_0047: conv.r8
    IL_0048: ldloc.3
    IL_0049: nop
    IL_004A: nop
    IL_004B: stloc.0
    IL_0050: br IL_0081
    IL_0051: ldarg.0
    IL_0056: ldfld 0x0400084D
    IL_0057: dup
    IL_0058: conv.r8
    IL_0059: ldc.i4.2
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_0061: call 0x0A000007
    IL_0066: call 0x0A000024
    IL_006B: call 0x0A000008
    IL_006C: ldarg.0
    IL_0071: ldfld 0x0400084A
    IL_0076: call 0x0A000008
    IL_007B: call 0x0A000029
    IL_007C: conv.r8
    IL_007D: ldloc.3
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ret
    }

    }}
