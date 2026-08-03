// Namespace: 
// Type: Bullet_Angel4

    public class Bullet_Angel4 {{

    private static object MAXBULLET;
    private object c_spear;
    private object mytransform;
    private object ef_splash;
    private object script_angel;
    private object dx;
    private object curFire;

    public Bullet_Angel4() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.6
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x0400016B
    IL_000C: ldarg.0
    IL_000D: ldc.i4.1
    IL_0012: stfld 0x0400016F
    IL_0013: ldarg.0
    IL_0018: call 0x0A000001
    IL_0019: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400016C
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000AFF
    IL_0016: call 0x0A000077
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_009A
    IL_001D: conv.r4
    IL_001E: IL_01
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0021: ldc.i4.0
    IL_0022: stloc.0
    IL_0027: br IL_0066
    IL_0028: ldarg.0
    IL_002D: ldfld 0x0400016B
    IL_002E: ldloc.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x0400016C
    IL_0035: ldloc.0
    IL_0036: conv.r8
    IL_003B: brtrue IL_-5DF5FFC4
    IL_003C: ldarg.0
    IL_0041: ldfld 0x0400016B
    IL_0042: ldloc.0
    IL_0043: ldelem.i
    IL_0044: conv.r8
    IL_0045: ldc.i4.5
    IL_0046: nop
    IL_0047: nop
    IL_0049: br.s IL_004C
    IL_004E: ldfld 0x0400016F
    IL_004F: conv.r8
    IL_0050: ldelem.i4
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldloc.0
    IL_0054: ldarg.0
    IL_0055: dup
    IL_005A: ldfld 0x0400016F
    IL_005B: ldc.i4.m1
    IL_005C: IL_5A
    IL_0061: stfld 0x0400016F
    IL_0062: ldloc.0
    IL_0063: ldc.i4.1
    IL_0064: IL_58
    IL_0065: stloc.0
    IL_0066: ldloc.0
    IL_0067: ldc.i4.6
    IL_0068: IL_3F
    IL_0069: IL_BB
    IL_006A: IL_FF
    IL_006B: IL_FF
    IL_006C: IL_FF
    IL_006D: ldarg.0
    IL_006E: ldarg.0
    IL_0073: ldfld 0x0400016C
    IL_0074: ldc.i4.6
    IL_0075: conv.r8
    IL_007A: brtrue IL_6F0A007B
    IL_007B: IL_B0
    IL_007C: nop
    IL_007D: nop
    IL_007E: stloc.0
    IL_0083: stfld 0x0400016D
    IL_0084: ldarg.0
    IL_0089: call 0x0A00000A
    IL_008A: ldc.i4.0
    IL_008B: conv.r8
    IL_008C: stloc.1
    IL_008D: nop
    IL_008E: nop
    IL_008F: stloc.0
    IL_0090: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000170
    IL_0007: ldarg.0
    IL_000C: ldstr 0x70000B0B
    IL_000D: IL_22
    IL_000E: IL_CD
    IL_000F: IL_CC
    IL_0010: IL_CC
    IL_0011: IL_3D
    IL_0012: IL_22
    IL_0013: IL_CD
    IL_0014: IL_CC
    IL_0015: IL_4C
    IL_0016: IL_3E
    IL_001B: call 0x0A000017
    IL_001C: ret
    }

    public void SplashOn() {
    IL_0001: ldarga.s 1
    IL_0002: IL_22
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_0006: nop
    IL_000B: stfld 0x0A000023
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400016D
    IL_0012: conv.r8
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.1
    IL_0018: conv.r8
    IL_0019: ldloc.3
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400016D
    IL_0023: conv.r8
    IL_0024: IL_B1
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ret
    }

    private void FireOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400016B
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000170
    IL_000C: ldelem.i
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400016C
    IL_0013: conv.r8
    IL_0014: ldc.i4.2
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: conv.r8
    IL_0019: ldloc.3
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400016B
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000170
    IL_0029: ldelem.i
    IL_002A: conv.r8
    IL_002B: stloc.0
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_002F: ldc.i4.1
    IL_0030: conv.r8
    IL_0031: stloc.1
    IL_0032: nop
    IL_0033: nop
    IL_0034: stloc.0
    IL_0035: ldarg.0
    IL_0036: dup
    IL_003B: ldfld 0x04000170
    IL_003C: ldc.i4.1
    IL_003D: IL_58
    IL_0042: stfld 0x04000170
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000170
    IL_0049: ldc.i4.6
    IL_004A: IL_3F
    IL_004B: ldc.i4.7
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: ldarg.0
    IL_0054: call 0x0A000081
    IL_0055: ldarg.0
    IL_005A: ldfld 0x0400016E
    IL_005B: conv.r8
    IL_005C: ldloc.2
    IL_005D: nop
    IL_005E: nop
    IL_005F: ldloc.0
    IL_0060: ldarg.0
    IL_0065: call 0x0A00000A
    IL_0066: ldc.i4.0
    IL_0067: conv.r8
    IL_0068: stloc.1
    IL_0069: nop
    IL_006A: nop
    IL_006B: stloc.0
    IL_006C: ret
    }

    private void Update() {
    IL_0000: ret
    }

    }}
