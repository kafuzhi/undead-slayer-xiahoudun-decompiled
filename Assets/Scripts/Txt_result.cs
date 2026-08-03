// Namespace: 
// Type: Txt_result

    public class Txt_result {{

    private object thismesh;
    private object destroydelay;
    private object originpos;
    private object mytransform;
    private object originscale;

    public Txt_result() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A75
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000016
    IL_0013: conv.r8
    IL_0014: IL_A9
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000A72
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000A75
    IL_0024: conv.r8
    IL_0025: ldc.i4.2
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: stfld 0x04000A74
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000A75
    IL_0035: conv.r8
    IL_003A: cpobj 0x7D0A0000
    IL_003B: conv.r.un
    IL_003C: stloc.0
    IL_003D: nop
    IL_003E: ldarg.2
    IL_003F: ret
    }

    private void Start() {
    IL_0000: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000A73
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000A75
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000A74
    IL_0017: conv.r8
    IL_0018: ldloc.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000A75
    IL_0026: call 0x0A00004B
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_20A12E: switch (534592 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A75
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A75
    IL_000C: conv.r8
    IL_0011: cpobj 0x020A0000
    IL_0016: ldfld 0x04000A76
    IL_001B: call 0x0A000024
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_18CA16927: switch (1663588929 cases)
    }

    public void UvMove() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A72
    IL_0006: ldc.i4.4
    IL_000B: newarr 0x01000014
    IL_000C: dup
    IL_000D: ldc.i4.0
    IL_000E: IL_8F
    IL_000F: ldnull
    IL_0010: nop
    IL_0011: nop
    IL_0012: IL_01
    IL_0013: ldarg.1
    IL_0018: call 0x0A0000AA
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_0020: stsfld 0x0083283E
    IL_0021: nop
    IL_0022: stloc.0
    IL_0027: call 0x0A0000AB
    IL_0028: IL_81
    IL_0029: ldnull
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_01
    IL_002D: dup
    IL_002E: ldc.i4.1
    IL_002F: IL_8F
    IL_0030: ldnull
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_01
    IL_0034: ldarg.1
    IL_0039: call 0x0A000082
    IL_003E: call 0x0A0000AB
    IL_0043: call 0x0A0000AA
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_004B: stsfld 0x0083283E
    IL_004C: nop
    IL_004D: stloc.0
    IL_0052: call 0x0A0000AB
    IL_0053: IL_81
    IL_0054: ldnull
    IL_0055: nop
    IL_0056: nop
    IL_0057: IL_01
    IL_0058: dup
    IL_0059: ldc.i4.2
    IL_005A: IL_8F
    IL_005B: ldnull
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_01
    IL_005F: ldarg.1
    IL_0060: IL_81
    IL_0061: ldnull
    IL_0062: nop
    IL_0063: nop
    IL_0064: IL_01
    IL_0065: dup
    IL_0066: ldc.i4.3
    IL_0067: IL_8F
    IL_0068: ldnull
    IL_0069: nop
    IL_006A: nop
    IL_006B: IL_01
    IL_006C: ldarg.1
    IL_0071: call 0x0A000082
    IL_0076: call 0x0A0000AB
    IL_0077: IL_81
    IL_0078: ldnull
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_01
    IL_007C: conv.r8
    IL_007D: IL_AC
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ret
    }

    }}
