// Namespace: 
// Type: SwordDance

    public class SwordDance {{

    public object uvspeed;
    public object hitrate;
    public object startdelay;
    private object mymaterial;
    private object mycollider;
    private object offset;

    public SwordDance() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x09E07D3F
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: IL_CD
    IL_000E: IL_CC
    IL_000F: IL_4C
    IL_0010: IL_3E
    IL_0015: stfld 0x040009E1
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: IL_CD
    IL_0019: IL_CC
    IL_001A: IL_CC
    IL_001B: IL_3D
    IL_0020: stfld 0x040009E2
    IL_0021: ldarg.0
    IL_0026: call 0x0A000001
    IL_0027: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_0007: conv.r8
    IL_0008: neg
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x040009E3
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: call 0x0A000003
    IL_001C: stfld 0x040009E4
    IL_001D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000057
    IL_000A: stfld 0x040009E5
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009E3
    IL_0015: call 0x0A000057
    IL_0016: conv.r8
    IL_0017: IL_B4
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_0020: ldstr 0x70000AC3
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040009E2
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040009E1
    IL_0031: call 0x0A000017
    IL_0032: ret
    }

    private void DanceHit() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009E4
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040009E4
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
    IL_0006: ldfld 0x040009E5
    IL_000B: call 0x0A000082
    IL_0010: call 0x0A000024
    IL_0015: call 0x0A000083
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040009E0
    IL_0020: call 0x0A000083
    IL_0025: call 0x0A0000AB
    IL_002A: stfld 0x040009E5
    IL_002B: ldarg.0
    IL_0030: ldflda 0x040009E5
    IL_0035: ldfld 0x0A000059
    IL_0036: IL_22
    IL_0037: shr
    IL_0038: shr
    IL_0039: shr
    IL_003A: IL_3F
    IL_003B: IL_44
    IL_003C: IL_3D
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: ldarg.0
    IL_0045: call 0x0A000081
    IL_0046: ldarg.0
    IL_004B: ldfld 0x040009E4
    IL_004C: ldc.i4.0
    IL_004D: conv.r8
    IL_004F: ldc.i4.s 0
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ldarg.0
    IL_0057: call 0x0A000002
    IL_005C: call 0x0A00004B
    IL_005D: IL_22
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldc.i4.2
    IL_0061: IL_42
    IL_0066: call 0x0A000008
    IL_0067: conv.r8
    IL_0068: ldloc.3
    IL_0069: nop
    IL_006A: nop
    IL_006B: stloc.0
    IL_006C: ldarg.0
    IL_0071: call 0x0A00000A
    IL_0072: ldc.i4.0
    IL_0073: conv.r8
    IL_0074: stloc.1
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_007C: br IL_008E
    IL_007D: ldarg.0
    IL_0082: ldfld 0x040009E3
    IL_0083: ldarg.0
    IL_0088: ldfld 0x040009E5
    IL_0089: conv.r8
    IL_008A: IL_B4
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: ret
    }

    }}
