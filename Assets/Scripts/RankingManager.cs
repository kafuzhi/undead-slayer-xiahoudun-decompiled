// Namespace: 
// Type: RankingManager

    public class RankingManager {{

    private static object MAXRANKING;
    private object scopemode;
    public object userimg;
    public object userpoint;
    public object username;
    public object mypoint;
    public object mygrade;
    public object resettime;
    public object maxfriend;
    private object factor;
    private object range;
    public object loadfinish;
    public object imagefinish;
    private object gameNo;

    public RankingManager() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 50
    IL_0007: newarr 0x0100003C
    IL_000C: stfld 0x04000882
    IL_000D: ldarg.0
    IL_000F: ldc.i4.s 50
    IL_0014: newarr 0x0100000B
    IL_0019: stfld 0x04000883
    IL_001A: ldarg.0
    IL_001C: ldc.i4.s 50
    IL_0021: newarr 0x0100000C
    IL_0026: stfld 0x04000884
    IL_0027: ldarg.0
    IL_0028: ldc.i4.2
    IL_002D: stfld 0x04000889
    IL_002E: ldarg.0
    IL_002F: ldc.i4.1
    IL_0034: stfld 0x0400088A
    IL_0035: ldarg.0
    IL_003A: call 0x0A000001
    IL_003B: ret
    }

    private void Awake() {
    IL_0000: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_000A: call 0x0A000090
    IL_000B: ret
    }

    public void S_LoadRanking() {
    IL_0004: call 0x0A0001EC
    IL_0005: stloc.0
    IL_0007: ldloca.s 0
    IL_000C: call 0x0A0001F0
    IL_000D: stloc.0
    IL_000F: ldloca.s 0
    IL_0011: ldloca.s 0
    IL_0016: call 0x0A0001F1
    IL_0017: shl
    IL_0019: ldc.i4.s 21
    IL_001A: IL_58
    IL_001B: conv.i4
    IL_0020: call 0x0A0001F2
    IL_0021: stloc.0
    IL_0023: ldloca.s 0
    IL_0025: ldloca.s 0
    IL_002A: call 0x0A0001F3
    IL_002B: shl
    IL_002C: conv.i4
    IL_0031: call 0x0A0001F4
    IL_0032: stloc.0
    IL_0034: ldloca.s 0
    IL_0036: ldloca.s 0
    IL_003B: call 0x0A0001F5
    IL_003C: shl
    IL_003D: conv.i4
    IL_0042: call 0x0A0001F6
    IL_0043: stloc.0
    IL_0044: ldarg.0
    IL_0045: ldarg.1
    IL_004A: stfld 0x04000889
    IL_004C: ldloca.s 0
    IL_0051: call 0x0A0001F7
    IL_0052: stloc.1
    IL_0053: ldc.i4.0
    IL_0054: ldloc.1
    IL_0055: IL_59
    IL_0056: stloc.2
    IL_0057: ldloc.2
    IL_0058: ldc.i4.0
    IL_0059: IL_3C
    IL_005B: ldloc.s 0
    IL_005C: nop
    IL_005D: nop
    IL_005F: ldloca.s 0
    IL_0060: ldloc.2
    IL_0061: ldc.i4.7
    IL_0062: IL_58
    IL_0063: conv.i4
    IL_0068: call 0x0A0001F8
    IL_0069: stloc.0
    IL_006E: br IL_0079
    IL_0070: ldloca.s 0
    IL_0071: ldloc.2
    IL_0072: conv.i4
    IL_0077: call 0x0A0001F8
    IL_0078: stloc.0
    IL_007A: ldloca.s 0
    IL_007F: call 0x0A0001F9
    IL_0080: stloc.0
    IL_0081: ldarg.0
    IL_0083: ldloca.s 0
    IL_0088: ldstr 0x70022A28
    IL_008D: call 0x0A0001FA
    IL_0092: stfld 0x04000887
    IL_0093: ldarg.0
    IL_0094: ldc.i4.0
    IL_0099: stfld 0x0400088B
    IL_009A: ldarg.0
    IL_009B: ldc.i4.0
    IL_00A0: stfld 0x0400088C
    IL_00A1: ldarg.0
    IL_00A2: ldarg.2
    IL_00A7: stfld 0x04000881
    IL_00A8: ldarg.0
    IL_00A9: ldarg.3
    IL_00AE: stfld 0x0400088A
    IL_00AF: ret
    }

    private void ImageLoading() {
    IL_0004: newobj 0x0600076D
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.2
    IL_000C: stfld 0x04001051
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x04001053
    IL_0014: ldloc.0
    IL_0015: ldarg.2
    IL_001A: stfld 0x04001056
    IL_001B: ldloc.0
    IL_001C: ldarg.1
    IL_0021: stfld 0x04001057
    IL_0022: ldloc.0
    IL_0023: ldarg.0
    IL_0028: stfld 0x04001058
    IL_0029: ldloc.0
    IL_002A: ret
    }

    }}
