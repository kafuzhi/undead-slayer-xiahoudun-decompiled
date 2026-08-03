// Namespace: 
// Type: Sk_fincanon

    public class Sk_fincanon {{

    public object beam;
    private object mytransform;
    private object delay;
    private object beamcollider;
    private object originscale;
    private object stat;

    public Sk_fincanon() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x0000223F
    IL_000D: stsfld 0xCCCD223F
    IL_000E: IL_CC
    IL_000F: IL_3D
    IL_0014: newobj 0x0A000076
    IL_0019: stfld 0x040008E8
    IL_001A: ldarg.0
    IL_001F: call 0x0A000001
    IL_0020: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008E5
    IL_000C: ldarg.0
    IL_0011: call 0x0A00002A
    IL_0016: ldstr 0x70022D3F
    IL_0017: conv.r8
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_22
    IL_001D: ldelem.i
    IL_001E: IL_99
    IL_001F: IL_99
    IL_0020: IL_3F
    IL_0021: conv.r8
    IL_0023: bgt.s IL_0024
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_002B: call 0x0A00002A
    IL_0030: ldstr 0x70022D49
    IL_0031: conv.r8
    IL_0033: bge.s IL_0034
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_003D: stsfld 0x00306F3E
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: call 0x0A00002A
    IL_004A: ldstr 0x70022D55
    IL_004B: conv.r8
    IL_004D: bge.s IL_004E
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x00306F3E
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005F: call 0x0A00002A
    IL_0064: ldstr 0x70022D65
    IL_0065: conv.r8
    IL_0067: bge.s IL_0068
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: IL_22
    IL_006B: IL_CD
    IL_006C: IL_CC
    IL_006D: IL_4C
    IL_006E: IL_3F
    IL_006F: conv.r8
    IL_0071: bgt.s IL_0072
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040008E4
    IL_007A: conv.r8
    IL_007B: stloc.0
    IL_007C: nop
    IL_007D: nop
    IL_007E: stloc.0
    IL_007F: ldc.i4.0
    IL_0080: conv.r8
    IL_0081: stloc.1
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0085: ldarg.0
    IL_0086: ldarg.0
    IL_008B: ldfld 0x040008E4
    IL_008C: conv.r8
    IL_008D: ldarg.1
    IL_008E: nop
    IL_008F: nop
    IL_0090: stloc.0
    IL_0091: conv.u4
    IL_0092: throw
    IL_0093: nop
    IL_0094: nop
    IL_0095: IL_01
    IL_009A: stfld 0x040008E7
    IL_009B: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008E4
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
    IL_001B: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008E5
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_C0
    IL_000F: IL_3F
    IL_0014: call 0x0A000008
    IL_0015: conv.r8
    IL_0016: IL_AF
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001B: ldc.i4.0
    IL_0020: stfld 0x040008E9
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040008E4
    IL_002B: call 0x0A00001B
    IL_002C: conv.r8
    IL_002D: IL_AF
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: ldarg.0
    IL_0032: IL_22
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_003B: stfld 0x040008E6
    IL_003C: ldarg.0
    IL_0041: ldfld 0x040008E7
    IL_0042: ldc.i4.0
    IL_0043: conv.r8
    IL_0045: ldc.i4.s 0
    IL_0046: nop
    IL_0047: stloc.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x040008E7
    IL_004E: IL_22
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: nop
    IL_0053: conv.r8
    IL_0056: stloc 2
    IL_0057: stloc.0
    IL_0058: ldarg.0
    IL_005D: ldstr 0x70022D6F
    IL_005E: IL_22
    IL_005F: IL_CD
    IL_0060: IL_CC
    IL_0061: IL_CC
    IL_0062: IL_3D
    IL_0063: IL_22
    IL_0064: IL_CD
    IL_0065: IL_CC
    IL_0066: IL_4C
    IL_0067: IL_3E
    IL_006C: call 0x0A000017
    IL_006D: ldarg.0
    IL_0072: ldfld 0x040008E4
    IL_0073: conv.r8
    IL_0074: stloc.0
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: ldc.i4.1
    IL_0079: conv.r8
    IL_007A: stloc.1
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: ldarg.0
    IL_0083: call 0x0A00002A
    IL_0088: ldstr 0x70022D3F
    IL_0089: conv.r8
    IL_008A: IL_3C
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: pop
    IL_008F: ret
    }

    public void Shoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008E6
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_3F
    IL_000B: IL_43
    IL_000C: ldc.i4.2
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040008E7
    IL_0016: ldc.i4.0
    IL_0017: conv.r8
    IL_0019: ldc.i4.s 0
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040008E7
    IL_0022: ldc.i4.1
    IL_0023: conv.r8
    IL_0025: ldc.i4.s 0
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040008E6
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040008E6
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008E6
    IL_0018: IL_22
    IL_0019: ldelem.i
    IL_001A: IL_99
    IL_001B: IL_59
    IL_F52C: switch (15683 cases)
    }

    }}
