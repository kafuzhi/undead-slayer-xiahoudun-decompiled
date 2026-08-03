// Namespace: 
// Type: Sk_chainbreak

    public class Sk_chainbreak {{

    private object myparticleEmitter;
    private object mytransform;
    private object pt_exp;
    private object delay_exp;
    private object p_step;
    private object childcollider;
    private object mycollider;

    public Sk_chainbreak() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A0000B0
    IL_000B: stfld 0x040008DD
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000002
    IL_0017: stfld 0x040008DE
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A000003
    IL_0023: stfld 0x040008E3
    IL_0024: ldarg.0
    IL_0025: ldarg.0
    IL_002A: ldfld 0x040008DE
    IL_002B: ldc.i4.0
    IL_002C: conv.r8
    IL_0031: brtrue IL_7D0A0032
    IL_0032: IL_DF
    IL_0033: ldloc.2
    IL_0034: nop
    IL_0035: ldarg.2
    IL_0036: ldarg.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x040008DF
    IL_003D: conv.r8
    IL_003E: ldarg.1
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: conv.u8
    IL_0043: IL_35
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_01
    IL_004B: stfld 0x040008E2
    IL_004C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008DF
    IL_0006: conv.r8
    IL_0007: IL_3D
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: call 0x0A00003D
    IL_0011: conv.r8
    IL_0014: ldarga 0
    IL_0015: stloc.0
    IL_0016: conv.r8
    IL_0017: IL_84
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040008DF
    IL_0021: conv.r8
    IL_0022: stloc.0
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldc.i4.0
    IL_0027: conv.r8
    IL_0028: stloc.1
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_002C: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008DD
    IL_0006: conv.r8
    IL_0007: IL_BA
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040008E3
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0014: ldc.i4.s 0
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040008DD
    IL_001D: ldc.i4.1
    IL_001E: conv.r8
    IL_001F: IL_B6
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: ldarg.0
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_002D: stfld 0x040008E0
    IL_002E: ldarg.0
    IL_0033: ldstr 0x70022980
    IL_0034: IL_22
    IL_0035: IL_CD
    IL_0036: IL_CC
    IL_0037: IL_CC
    IL_0038: IL_3D
    IL_0039: IL_22
    IL_003A: IL_CD
    IL_003B: IL_CC
    IL_003C: IL_CC
    IL_003D: IL_3E
    IL_0042: call 0x0A000017
    IL_0043: ldarg.0
    IL_0044: ldc.i4.0
    IL_0049: stfld 0x040008E1
    IL_004A: ldarg.0
    IL_004F: call 0x0A00002B
    IL_0050: conv.r8
    IL_0051: IL_4D
    IL_0052: nop
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: ret
    }

    private void RepeatDamage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008E3
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008E3
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040008E0
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040008E0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008DE
    IL_0018: conv.r8
    IL_0019: ldc.i4.2
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: stloc.0
    IL_001F: ldloca.s 0
    IL_0024: ldfld 0x0A000023
    IL_0025: IL_22
    IL_0026: IL_CD
    IL_0027: IL_CC
    IL_0028: IL_CC
    IL_0029: IL_3D
    IL_002A: IL_41
    IL_002C: bge.s IL_002D
    IL_002D: nop
    IL_002E: nop
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040008DE
    IL_0035: dup
    IL_0036: conv.r8
    IL_0037: ldc.i4.2
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003F: call 0x0A000007
    IL_0040: IL_22
    IL_0041: ldelem.i
    IL_0042: IL_99
    IL_0043: ldc.i4.3
    IL_0044: IL_3F
    IL_0049: call 0x0A000008
    IL_004E: call 0x0A000024
    IL_0053: call 0x0A000008
    IL_0058: call 0x0A000029
    IL_0059: conv.r8
    IL_005A: ldloc.3
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040008E1
    IL_0064: ldc.i4.2
    IL_01B5: switch (83 cases)
    }

    }}
