// Namespace: 
// Type: WeaponDrop

    public class WeaponDrop {{

    private object mytransform;
    private object maxy;
    private object drop;
    private object rotateaxis;

    public WeaponDrop() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: ldelem.i
    IL_0003: IL_99
    IL_0004: IL_D9
    IL_0005: IL_3F
    IL_000A: stfld 0x04000FE9
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FE8
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000FE8
    IL_0013: conv.r8
    IL_0014: mul
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000FEB
    IL_001D: ret
    }

    public void DropCancel() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70024A98
    IL_000A: call 0x0A00007B
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x04000FEA
    IL_0012: ret
    }

    public void Drop() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70024A98
    IL_000A: call 0x0A00007B
    IL_000B: ldarg.1
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: call 0x0A00000A
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001E: ldc.i4 7415872
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: br IL_0036
    IL_0026: ldarg.0
    IL_002B: ldstr 0x70024A98
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_002F: rem
    IL_FCD4: switch (16168 cases)
    }

    private void Disappear() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FE8
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_0012: stsfld 0x00082840
    IL_0013: nop
    IL_0014: stloc.0
    IL_0015: conv.r8
    IL_0016: ldloc.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: call 0x0A00000A
    IL_0020: ldc.i4.0
    IL_0021: conv.r8
    IL_0022: stloc.1
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FEA
    IL_000A: brfalse IL_00EB
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000FE8
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0028: ldstr 0x02000000
    IL_002D: ldfld 0x04000FE8
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000FEB
    IL_0038: call 0x0A000024
    IL_003D: call 0x0A000008
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: IL_34
    IL_0042: IL_44
    IL_0047: call 0x0A000008
    IL_0048: conv.r8
    IL_0049: IL_B5
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldarg.0
    IL_004E: dup
    IL_0053: ldfld 0x04000FE9
    IL_0054: IL_22
    IL_0055: nop
    IL_0056: nop
    IL_0057: rem
    IL_90FC: switch (9256 cases)
    }

    }}
