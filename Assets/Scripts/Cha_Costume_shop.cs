// Namespace: 
// Type: Cha_Costume_shop

    public class Cha_Costume_shop {{

    private object mytransform;
    private object prevCostum;
    private object curCostum;
    private object current_costume;
    private object tt;

    public Cha_Costume_shop() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040003A8
    IL_000C: ldarg.0
    IL_0011: ldstr 0x700017DB
    IL_0016: call 0x06000220
    IL_001B: stfld 0x040003AB
    IL_001C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00002A
    IL_000B: ldstr 0x70001805
    IL_000C: conv.r8
    IL_000E: bge.s IL_000F
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: stfld 0x040003AC
    IL_0016: ldarg.0
    IL_001B: call 0x0A000002
    IL_001C: conv.r8
    IL_001D: IL_B8
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: stloc.0
    IL_0022: ldc.i4.1
    IL_0023: stloc.1
    IL_0028: br IL_0044
    IL_0029: ldarg.0
    IL_002E: ldfld 0x040003A8
    IL_002F: ldloc.1
    IL_0030: conv.r8
    IL_0035: brtrue IL_6F0A0036
    IL_0036: stloc.0
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: ldc.i4.0
    IL_003B: conv.r8
    IL_003C: stloc.1
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: IL_58
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: IL_3F
    IL_0047: IL_DE
    IL_0048: IL_FF
    IL_0049: IL_FF
    IL_004A: IL_FF
    IL_004B: ldarg.0
    IL_004C: ldarg.0
    IL_0051: ldfld 0x040003AB
    IL_0056: call 0x060001CC
    IL_0057: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003AC
    IL_000A: call 0x0A000131
    IL_000B: IL_22
    IL_000C: IL_8F
    IL_000D: IL_C2
    IL_000E: conv.u8
    IL_000F: IL_3E
    IL_0010: IL_5A
    IL_0011: conv.r8
    IL_0013: blt.s IL_0015
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ret
    }

    public void Costume() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: IL_58
    IL_0003: ldarg.0
    IL_0008: call 0x0A000002
    IL_0009: conv.r8
    IL_000B: beq.s IL_000D
    IL_000C: nop
    IL_000D: stloc.0
    IL_000E: IL_3C
    IL_000F: IL_4E
    IL_0010: nop
    IL_0011: nop
    IL_0012: nop
    IL_0013: ldarg.0
    IL_0014: ldarg.0
    IL_0019: call 0x0A000002
    IL_001A: ldarg.1
    IL_001B: ldc.i4.1
    IL_001C: IL_58
    IL_001D: conv.r8
    IL_0022: brtrue IL_6F0A0023
    IL_0023: stloc.0
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_002B: stfld 0x040003AA
    IL_002C: ldarg.0
    IL_0031: ldfld 0x040003A9
    IL_0032: ldnull
    IL_0037: call 0x0A000021
    IL_003C: brfalse IL_0049
    IL_003D: ldarg.0
    IL_0042: ldfld 0x040003A9
    IL_0043: ldc.i4.0
    IL_0044: conv.r8
    IL_0045: stloc.1
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x040003AA
    IL_004F: ldc.i4.1
    IL_0050: conv.r8
    IL_0051: stloc.1
    IL_0052: nop
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: ldarg.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x040003AA
    IL_0060: stfld 0x040003A9
    IL_0061: ret
    }

    }}
