// Namespace: 
// Type: Gauge_UV

    public class Gauge_UV {{

    private object thismesh;
    private object originUV;

    public Gauge_UV() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: newarr 0x01000014
    IL_000B: stfld 0x04000673
    IL_000C: ldarg.0
    IL_0011: call 0x0A000001
    IL_0012: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000016
    IL_0007: conv.r8
    IL_0008: IL_A9
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x04000672
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000672
    IL_0018: conv.r8
    IL_0019: IL_8F
    IL_001A: IL_01
    IL_001B: nop
    IL_001C: stloc.0
    IL_0021: stfld 0x04000673
    IL_0022: ret
    }

    public void UvMove() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000672
    IL_0006: ldc.i4.4
    IL_000B: newarr 0x01000014
    IL_000C: dup
    IL_000D: ldc.i4.0
    IL_000E: IL_8F
    IL_000F: ldnull
    IL_0010: nop
    IL_0011: nop
    IL_0012: IL_01
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000673
    IL_0019: ldc.i4.0
    IL_001A: IL_8F
    IL_001B: ldnull
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_01
    IL_0023: ldobj 0x01000014
    IL_0024: ldarg.1
    IL_0029: call 0x0A0000AB
    IL_002A: IL_81
    IL_002B: ldnull
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_01
    IL_002F: dup
    IL_0030: ldc.i4.1
    IL_0031: IL_8F
    IL_0032: ldnull
    IL_0033: nop
    IL_0034: nop
    IL_0035: IL_01
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000673
    IL_003C: ldc.i4.1
    IL_003D: IL_8F
    IL_003E: ldnull
    IL_003F: nop
    IL_0040: nop
    IL_0041: IL_01
    IL_0046: ldobj 0x01000014
    IL_0047: ldarg.1
    IL_004C: call 0x0A0000AB
    IL_004D: IL_81
    IL_004E: ldnull
    IL_004F: nop
    IL_0050: nop
    IL_0051: IL_01
    IL_0052: dup
    IL_0053: ldc.i4.2
    IL_0054: IL_8F
    IL_0055: ldnull
    IL_0056: nop
    IL_0057: nop
    IL_0058: IL_01
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000673
    IL_005F: ldc.i4.2
    IL_0060: IL_8F
    IL_0061: ldnull
    IL_0062: nop
    IL_0063: nop
    IL_0064: IL_01
    IL_0069: ldobj 0x01000014
    IL_006A: ldarg.1
    IL_006F: call 0x0A0000AB
    IL_0070: IL_81
    IL_0071: ldnull
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_01
    IL_0075: dup
    IL_0076: ldc.i4.3
    IL_0077: IL_8F
    IL_0078: ldnull
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_01
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000673
    IL_0082: ldc.i4.3
    IL_0083: IL_8F
    IL_0084: ldnull
    IL_0085: nop
    IL_0086: nop
    IL_0087: IL_01
    IL_008C: ldobj 0x01000014
    IL_008D: ldarg.1
    IL_0092: call 0x0A0000AB
    IL_0093: IL_81
    IL_0094: ldnull
    IL_0095: nop
    IL_0096: nop
    IL_0097: IL_01
    IL_0098: conv.r8
    IL_0099: IL_AC
    IL_009A: nop
    IL_009B: nop
    IL_009C: stloc.0
    IL_009D: ret
    }

    }}
