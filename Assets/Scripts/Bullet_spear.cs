// Namespace: 
// Type: Bullet_spear

    public class Bullet_spear {{

    private object mytransform;
    private object originscale;
    public object tune;

    public Bullet_spear() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001F2
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040001F2
    IL_0013: conv.r8
    IL_0018: cpobj 0x7D0A0000
    IL_0019: IL_F3
    IL_001A: IL_01
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001F2
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040001F2
    IL_0012: conv.r8
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040001F4
    IL_0021: call 0x0A000008
    IL_0026: call 0x0A000029
    IL_0027: conv.r8
    IL_0028: ldloc.3
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_002C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001F2
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040001F2
    IL_0012: conv.r8
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000024
    IL_0020: call 0x0A000008
    IL_0021: IL_22
    IL_0022: IL_CD
    IL_0023: IL_CC
    IL_0024: IL_4C
    IL_0025: IL_3E
    IL_0026: ldarg.0
    IL_002B: ldfld 0x040001F4
    IL_002C: IL_58
    IL_0031: call 0x0A000008
    IL_0036: call 0x0A000029
    IL_0037: conv.r8
    IL_0038: ldloc.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_003C: ldarg.0
    IL_0041: ldfld 0x040001F2
    IL_0042: dup
    IL_0043: conv.r8
    IL_0048: cpobj 0x280A0000
    IL_0049: and
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: IL_22
    IL_004E: ldelem.i
    IL_004F: IL_99
    IL_0050: ldc.i4.3
    IL_0051: IL_3F
    IL_0056: call 0x0A000008
    IL_005B: call 0x0A000024
    IL_0060: call 0x0A000008
    IL_0065: call 0x0A000019
    IL_0066: conv.r8
    IL_0067: IL_AF
    IL_0068: nop
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040001F2
    IL_0071: conv.r8
    IL_0076: cpobj 0x0A0A0000
    IL_0078: ldloca.s 0
    IL_007D: ldfld 0x0A00005E
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0082: nop
    IL_0083: IL_41
    IL_0084: ldc.i4.7
    IL_0085: nop
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldarg.0
    IL_008D: call 0x0A00000A
    IL_008E: ldc.i4.0
    IL_008F: conv.r8
    IL_0090: stloc.1
    IL_0091: nop
    IL_0092: nop
    IL_0093: stloc.0
    IL_0094: ldarg.0
    IL_0099: ldfld 0x040001F2
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040001F3
    IL_00A0: conv.r8
    IL_00A1: IL_AF
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A5: ret
    }

    }}
