// Namespace: 
// Type: CaveGetCoinNum

    public class CaveGetCoinNum {{

    private object mytransform;
    private object imgnum;
    private object oldnum;
    private object targetcoin;
    private object tt;
    private object finishdelay;
    private object movefisnish;

    public CaveGetCoinNum() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000295
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000024
    IL_0017: stfld 0x04000299
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000295
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0018: brtrue IL_6F0A0019
    IL_0019: stloc.0
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldc.i4.0
    IL_001E: conv.r8
    IL_001F: stloc.1
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: ret
    }

    public void GetOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000295
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_C0
    IL_30000009B: switch (3221225506 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000295
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: brtrue IL_280A000D
    IL_000D: ldloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: call 0x0A000024
    IL_001A: call 0x0A000008
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: ldc.i4.0
    IL_001F: IL_44
    IL_0024: call 0x0A000008
    IL_0025: conv.r8
    IL_0026: IL_B5
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x0400029B
    IL_0034: brfalse IL_00FB
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000296
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000298
    IL_0041: conv.i2
    IL_0042: IL_41
    IL_0043: ldc.i4.7
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: ldarg.0
    IL_0048: dup
    IL_004D: ldfld 0x04000296
    IL_0052: call 0x0A000024
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0058: ldloc 23106
    IL_0059: IL_58
    IL_005E: stfld 0x04000296
    IL_0063: br IL_00C1
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000298
    IL_006B: conv.i2
    IL_0070: stfld 0x04000296
    IL_0071: ldarg.0
    IL_0072: dup
    IL_0077: ldfld 0x0400029A
    IL_007C: call 0x0A000024
    IL_007D: IL_58
    IL_0082: stfld 0x0400029A
    IL_0083: ldarg.0
    IL_0088: ldfld 0x0400029A
    IL_0089: IL_22
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_B99D: switch (11843 cases)
    }

    }}
