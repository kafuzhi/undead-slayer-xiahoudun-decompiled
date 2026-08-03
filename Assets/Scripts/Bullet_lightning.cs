// Namespace: 
// Type: Bullet_lightning

    public class Bullet_lightning {{

    private object cha1;
    private object mytransform;

    public Bullet_lightning() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001C2
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000001
    IL_0016: call 0x0A000004
    IL_0017: conv.r8
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: stfld 0x040001C1
    IL_0021: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001C2
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040001C1
    IL_000C: conv.r8
    IL_000D: ldarg.0
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: IL_22
    IL_0017: stloc.0
    IL_0018: IL_D7
    IL_0019: stelem.i
    IL_001A: IL_BC
    IL_001B: IL_22
    IL_001C: stloc.0
    IL_001D: IL_D7
    IL_001E: IL_23
    IL_001F: IL_3D
    IL_0024: call 0x0A000075
    IL_0025: IL_22
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_C0
    IL_0029: IL_3F
    IL_002A: IL_22
    IL_002B: stloc.0
    IL_002C: IL_D7
    IL_002D: stelem.i
    IL_002E: IL_BC
    IL_002F: IL_22
    IL_0030: stloc.0
    IL_0031: IL_D7
    IL_0032: IL_23
    IL_0033: IL_3D
    IL_0038: call 0x0A000075
    IL_003D: newobj 0x0A000076
    IL_0042: call 0x0A000029
    IL_0043: conv.r8
    IL_0044: ldloc.3
    IL_0045: nop
    IL_0046: nop
    IL_0047: stloc.0
    IL_0048: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000D
    IL_0006: conv.r8
    IL_0007: IL_C9
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: brfalse IL_00AB
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040001C2
    IL_0016: conv.r8
    IL_0017: ldc.i4.2
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: stloc.0
    IL_001D: ldloca.s 0
    IL_0022: ldfld 0x0A000023
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_43
    IL_0029: IL_34
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_0032: ldfld 0x040001C2
    IL_0033: dup
    IL_0034: conv.r8
    IL_0035: ldc.i4.2
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_003D: call 0x0A000007
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: ldelem.r8
    IL_20E6: switch (2088 cases)
    }

    }}
