// Namespace: 
// Type: Splash_angel_poison

    public class Splash_angel_poison {{

    private object mytransform;
    private object delay;

    public Splash_angel_poison() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164724032
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009D0
    IL_000C: ldarg.0
    IL_0011: call 0x0A00000A
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164724032
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009D1
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_41
    IL_000C: mul
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040009D0
    IL_0016: dup
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000007
    IL_0025: call 0x0A000024
    IL_002A: call 0x0A000008
    IL_002B: IL_22
    IL_002C: IL_CD
    IL_002D: IL_CC
    IL_002E: IL_4C
    IL_002F: IL_3D
    IL_0034: call 0x0A000008
    IL_0039: call 0x0A000019
    IL_003A: conv.r8
    IL_003B: ldloc.3
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x040009D0
    IL_0045: conv.r8
    IL_0046: ldc.i4.2
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: stloc.0
    IL_004C: ldloca.s 0
    IL_0051: ldfld 0x0A000023
    IL_0052: IL_22
    IL_0053: IL_CD
    IL_0054: IL_CC
    IL_0055: IL_4C
    IL_0056: IL_BD
    IL_0057: IL_41
    IL_0058: stloc.2
    IL_0059: nop
    IL_005A: nop
    IL_005B: nop
    IL_005C: ldarg.0
    IL_0061: call 0x0A00000A
    IL_0062: ldc.i4.0
    IL_0063: conv.r8
    IL_0064: stloc.1
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_006C: br IL_007F
    IL_006D: ldarg.0
    IL_006E: dup
    IL_0073: ldfld 0x040009D1
    IL_0078: call 0x0A000024
    IL_0079: IL_59
    IL_007E: stfld 0x040009D1
    IL_007F: ret
    }

    }}
