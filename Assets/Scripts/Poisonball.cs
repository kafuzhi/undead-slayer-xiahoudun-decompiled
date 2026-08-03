// Namespace: 
// Type: Poisonball

    public class Poisonball {{

    private object mytransform;
    private object shoot_delay;
    private object shootdir;
    private object explode;
    private object myparticle;
    private object boom;

    public Poisonball() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400086F
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A0000B0
    IL_0017: stfld 0x04000873
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x0400086F
    IL_0007: conv.r8
    IL_0008: IL_CD
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: conv.r8
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: call 0x0A000007
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_3F
    IL_001F: call 0x0A000008
    IL_0024: call 0x0A000019
    IL_0029: stfld 0x04000871
    IL_002A: ldarg.0
    IL_002F: ldfld 0x0400086F
    IL_0030: ldnull
    IL_0031: conv.r8
    IL_0032: IL_4E
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_003B: ldstr 0x700229C8
    IL_0040: call 0x0A000004
    IL_0041: conv.r8
    IL_0042: ldarg.3
    IL_0043: nop
    IL_0044: nop
    IL_0045: stloc.0
    IL_004A: stfld 0x04000874
    IL_004B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000872
    IL_000A: brtrue IL_00DF
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000870
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0018: stsfld 0x00B2433F
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_0020: ldfld 0x0400086F
    IL_0021: dup
    IL_0022: conv.r8
    IL_0023: ldc.i4.2
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000871
    IL_0031: call 0x0A000024
    IL_0036: call 0x0A000008
    IL_0037: IL_22
    IL_0038: nop
    IL_0039: nop
    IL_003E: ldc.i4 534592
    IL_003F: nop
    IL_0040: stloc.0
    IL_0045: call 0x0A000029
    IL_0046: conv.r8
    IL_0047: ldloc.3
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: ldarg.0
    IL_0050: ldfld 0x0400086F
    IL_0051: conv.r8
    IL_0052: ldc.i4.2
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: stloc.0
    IL_0058: ldloca.s 0
    IL_005D: ldfld 0x0A000023
    IL_005E: IL_22
    IL_005F: nop
    IL_0060: nop
    IL_0061: nop
    IL_0062: nop
    IL_0063: IL_42
    IL_0064: rem
    IL_0065: nop
    IL_0066: nop
    IL_0067: nop
    IL_0068: ldarg.0
    IL_006D: call 0x0A000003
    IL_006E: ldc.i4.1
    IL_006F: conv.r8
    IL_0071: ldc.i4.s 0
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldarg.0
    IL_0079: call 0x0A000003
    IL_007A: IL_22
    IL_007B: IL_CD
    IL_007C: IL_CC
    IL_007D: IL_CC
    IL_007E: IL_3E
    IL_0083: call 0x0A000071
    IL_0084: ldarg.0
    IL_0089: call 0x0A00000A
    IL_008A: IL_22
    IL_008B: ldelem.i
    IL_008C: IL_99
    IL_008D: IL_99
    IL_008E: IL_3F
    IL_0093: call 0x0A000071
    IL_0094: ldarg.0
    IL_0095: ldc.i4.1
    IL_009A: stfld 0x04000872
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000873
    IL_00A5: call 0x0A00004B
    IL_00A6: conv.r8
    IL_00A7: IL_E8
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x04000874
    IL_00B1: conv.r8
    IL_00B2: IL_3E
    IL_00B3: nop
    IL_00B4: nop
    IL_00B6: br.s IL_00CF
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x0400086F
    IL_00BD: conv.r8
    IL_00BE: ldc.i4.2
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: stloc.0
    IL_00C2: ldc.i4.1
    IL_00C3: conv.r8
    IL_00C4: ldind.ref
    IL_00C5: ldarg.0
    IL_00C6: nop
    IL_00C7: ldloc.0
    IL_00CC: br IL_00DF
    IL_00CD: ldarg.0
    IL_00CE: dup
    IL_00D3: ldfld 0x04000870
    IL_00D8: call 0x0A000024
    IL_00D9: IL_58
    IL_00DE: stfld 0x04000870
    IL_00DF: ret
    }

    }}
