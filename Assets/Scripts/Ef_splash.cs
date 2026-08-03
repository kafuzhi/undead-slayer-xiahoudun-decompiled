// Namespace: 
// Type: Ef_splash

    public class Ef_splash {{

    public object rising_fire;
    private object cha1;
    private object mytransform;
    private object mycollider;
    private object myrenderer;
    private object showtime;
    private object dis;
    private object originTintcolor;
    private object collidsionOn;
    private object showon;
    private object tintcolor;
    private object transColor;

    public Ef_splash() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_C0
    IL_0005: IL_3F
    IL_000A: stfld 0x040005E2
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040005DF
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040005E0
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A00000D
    IL_0023: stfld 0x040005E1
    IL_0024: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x040005DE
    IL_0015: ldarg.0
    IL_001A: ldfld 0x040005E1
    IL_001B: ldc.i4.0
    IL_001C: conv.r8
    IL_0021: beq IL_20A0022
    IL_0026: ldfld 0x040005E0
    IL_0027: ldc.i4.0
    IL_0028: conv.r8
    IL_002A: ldc.i4.s 0
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldarg.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040005E1
    IL_0034: conv.r8
    IL_0036: ldarg.s 0
    IL_0037: nop
    IL_0038: stloc.0
    IL_003D: ldstr 0x70000B47
    IL_003E: conv.r8
    IL_003F: IL_C7
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: stfld 0x040005E4
    IL_0048: ldarg.0
    IL_004D: call 0x0A00000A
    IL_004E: ldc.i4.0
    IL_004F: conv.r8
    IL_0050: stloc.1
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: ret
    }

    public void SplashOn() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040005E5
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_C0
    IL_000C: IL_3F
    IL_0011: stfld 0x040005E2
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040005E1
    IL_0018: conv.r8
    IL_001A: ldarg.s 0
    IL_001B: nop
    IL_001C: stloc.0
    IL_0021: ldstr 0x70000B47
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040005E4
    IL_0028: conv.r8
    IL_0029: IL_C6
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldarg.0
    IL_002E: ldarg.2
    IL_0033: stfld 0x040005E3
    IL_0034: ldarg.0
    IL_0039: ldstr 0x700024BD
    IL_003A: ldarg.3
    IL_003F: call 0x0A00003F
    IL_0040: ret
    }

    public void SplashOff() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040005E0
    IL_0006: conv.r8
    IL_0007: throw
    IL_0008: IL_01
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: brfalse IL_001C
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040005E0
    IL_0016: ldc.i4.0
    IL_0017: conv.r8
    IL_0019: ldc.i4.s 0
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: call 0x0A00000A
    IL_0022: ldc.i4.0
    IL_0023: conv.r8
    IL_0024: stloc.1
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ldarg.0
    IL_002D: ldstr 0x700024BD
    IL_0032: call 0x0A00007B
    IL_0033: ret
    }

    public void ShowOn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040005DD
    IL_0012: conv.r8
    IL_0013: stloc.0
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldc.i4.1
    IL_0018: conv.r8
    IL_0019: stloc.1
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040005E1
    IL_0023: ldc.i4.1
    IL_0024: conv.r8
    IL_0029: beq IL_20A002A
    IL_002E: ldfld 0x040005E5
    IL_0033: brfalse IL_0040
    IL_0034: ldarg.0
    IL_0039: ldfld 0x040005E0
    IL_003A: ldc.i4.1
    IL_003B: conv.r8
    IL_003D: ldc.i4.s 0
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x040005DF
    IL_0046: ldarg.0
    IL_004B: ldfld 0x040005DE
    IL_004C: conv.r8
    IL_004D: pop
    IL_004E: nop
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: conv.r8
    IL_0056: call 0x020A0000
    IL_005B: ldfld 0x040005DF
    IL_005C: ldarg.0
    IL_0061: ldfld 0x040005DE
    IL_0062: conv.r8
    IL_0063: ldc.i4.2
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_006B: call 0x0A000007
    IL_006C: IL_22
    IL_006D: stloc.0
    IL_006E: IL_D7
    IL_006F: stelem.i
    IL_0070: IL_3C
    IL_0075: call 0x0A000008
    IL_007A: call 0x0A000029
    IL_007B: ldarg.0
    IL_0080: ldfld 0x040005DE
    IL_0081: conv.r8
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0085: stloc.0
    IL_0086: ldarg.0
    IL_008B: ldfld 0x040005E3
    IL_0090: call 0x0A000008
    IL_0095: call 0x0A000029
    IL_0096: conv.r8
    IL_0097: ldloc.3
    IL_0098: nop
    IL_0099: nop
    IL_009A: stloc.0
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x040005DF
    IL_00A5: call 0x0A000013
    IL_00A6: conv.r8
    IL_00A8: ldarga.s 1
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: ldarg.0
    IL_00AC: ldc.i4.1
    IL_00B1: stfld 0x040005E6
    IL_00B2: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040005E6
    IL_000A: brfalse IL_010D
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x040005E2
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x040005E2
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040005E2
    IL_0023: IL_22
    IL_0024: shr
    IL_0025: shr
    IL_002A: isinst 0x0001433F
    IL_002B: nop
    IL_002C: nop
    IL_002D: ret
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040005E2
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: IL_3F
    IL_0039: IL_43
    IL_0042: ldc.i8 1654193802706944
    IL_0043: ldarg.2
    IL_0044: conv.r8
    IL_0045: throw
    IL_0046: IL_01
    IL_0047: nop
    IL_0048: stloc.0
    IL_004D: brfalse IL_005A
    IL_004E: ldarg.0
    IL_0053: ldfld 0x040005E0
    IL_0054: ldc.i4.0
    IL_0055: conv.r8
    IL_0057: ldc.i4.s 0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005E: br IL_010D
    IL_005F: ldarg.0
    IL_0064: ldfld 0x040005E2
    IL_0065: IL_22
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_43
    IL_006B: IL_78
    IL_006C: nop
    IL_006D: nop
    IL_006E: nop
    IL_006F: ldarg.0
    IL_0074: ldfld 0x040005E0
    IL_0075: conv.r8
    IL_0076: throw
    IL_0077: IL_01
    IL_0078: nop
    IL_0079: stloc.0
    IL_007E: brfalse IL_008B
    IL_007F: ldarg.0
    IL_0084: ldfld 0x040005E0
    IL_0085: ldc.i4.0
    IL_0086: conv.r8
    IL_0088: ldc.i4.s 0
    IL_0089: nop
    IL_008A: stloc.0
    IL_008B: ldarg.0
    IL_008C: ldarg.0
    IL_0091: ldfld 0x040005E1
    IL_0092: conv.r8
    IL_0094: ldarg.s 0
    IL_0095: nop
    IL_0096: stloc.0
    IL_009B: ldstr 0x70000B47
    IL_009C: conv.r8
    IL_009D: IL_C7
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A5: stfld 0x040005E7
    IL_00A6: ldarg.0
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x040005E7
    IL_00B1: call 0x0A0000F3
    IL_00B6: call 0x0A000024
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: rem
    IL_00BB: IL_41
    IL_00BC: IL_5A
    IL_00C1: call 0x0A0000C8
    IL_00C6: stfld 0x040005E8
    IL_00C7: ldarg.0
    IL_00CC: ldfld 0x040005E1
    IL_00CD: conv.r8
    IL_00CF: ldarg.s 0
    IL_00D0: nop
    IL_00D1: stloc.0
    IL_00D6: ldstr 0x70000B47
    IL_00D7: ldarg.0
    IL_00DC: ldfld 0x040005E8
    IL_00DD: conv.r8
    IL_00DE: IL_C6
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: stloc.0
    IL_00E6: br IL_010D
    IL_00E7: ldarg.0
    IL_00EC: call 0x0A00000A
    IL_00ED: ldc.i4.0
    IL_00EE: conv.r8
    IL_00EF: stloc.1
    IL_00F0: nop
    IL_00F1: nop
    IL_00F2: stloc.0
    IL_00F3: ldarg.0
    IL_00F8: ldfld 0x040005DF
    IL_00FD: call 0x0A00004B
    IL_00FE: IL_22
    IL_00FF: nop
    IL_0100: nop
    IL_0101: rem
    IL_0102: IL_41
    IL_0107: call 0x0A000008
    IL_0108: conv.r8
    IL_0109: ldloc.3
    IL_010A: nop
    IL_010B: nop
    IL_010C: stloc.0
    IL_010D: ret
    }

    }}
