// Namespace: 
// Type: Ef_boom

    public class Ef_boom {{

    private object mytransform;
    private object myparticle;
    private object mymaterial;
    private object mycollider;
    public object pttex;

    public Ef_boom() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000591
    IL_000C: ldarg.0
    IL_0011: call 0x0A000001
    IL_0012: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400058D
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A0000B0
    IL_0017: stfld 0x0400058E
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A00000D
    IL_001F: conv.r8
    IL_0020: neg
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0028: stfld 0x0400058F
    IL_0029: ldarg.0
    IL_002A: ldarg.0
    IL_002F: call 0x0A000003
    IL_0034: stfld 0x04000590
    IL_0035: ret
    }

    public void SetTex() {
    IL_0001: ldarga.s 2
    IL_0002: ldc.i4.1
    IL_0003: IL_22
    IL_0004: stloc.0
    IL_0005: IL_D7
    IL_0006: stelem.i
    IL_0007: IL_3C
    IL_000C: call 0x0A00001A
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400058D
    IL_0013: ldarg.2
    IL_0014: conv.r8
    IL_0015: ldloc.3
    IL_0016: nop
    IL_0017: nop
    IL_0018: stloc.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x0400058E
    IL_001F: ldc.i4.0
    IL_0020: conv.r8
    IL_0021: IL_B6
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldarg.0
    IL_002A: ldfld 0x0400058E
    IL_002B: conv.r8
    IL_002C: IL_BA
    IL_002D: nop
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x0400058E
    IL_0036: ldc.i4.1
    IL_0037: conv.r8
    IL_0038: IL_B6
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_003C: ldarg.0
    IL_0041: ldfld 0x0400058F
    IL_0046: ldstr 0x700023C1
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000591
    IL_004D: ldarg.1
    IL_004E: ldelem.i
    IL_004F: conv.r8
    IL_0050: conv.u8
    IL_0051: IL_01
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: ldarg.3
    IL_0059: brfalse IL_0066
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000590
    IL_0060: ldc.i4.1
    IL_0061: conv.r8
    IL_0063: ldc.i4.s 0
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ldarg.0
    IL_006B: ldstr 0x70002485
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_006F: nop
    IL_0070: IL_3F
    IL_0075: call 0x0A00003F
    IL_0076: ret
    }

    private void EmitStop() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400058E
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: IL_B6
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000590
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_001D: ldfld 0x0400058D
    IL_0022: call 0x0A000007
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0027: bgt.s IL_0069
    IL_002C: call 0x0A000008
    IL_002D: conv.r8
    IL_002E: ldloc.3
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ret
    }

    }}
