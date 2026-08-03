// Namespace: 
// Type: Cha_Costume

    public class Cha_Costume {{

    private object prevCostum;
    private object curCostum;
    private object current_costume;

    public Cha_Costume() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700017DB
    IL_000A: call 0x06000220
    IL_000F: stfld 0x040003A7
    IL_0010: ret
    }

    private void Start() {
    IL_0004: call 0x0A0000EB
    IL_0009: ldstr 0x700017E3
    IL_000E: call 0x0A0000EC
    IL_0013: brfalse IL_00A7
    IL_0018: ldstr 0x700017F1
    IL_001D: call 0x0A000077
    IL_001E: conv.r8
    IL_0023: brtrue IL_7B2B0024
    IL_0024: ldc.i4.3
    IL_0026: ldarga.s 0
    IL_0027: ldarg.2
    IL_0028: stloc.0
    IL_0029: ldloc.0
    IL_002A: ldc.i4.0
    IL_002B: IL_3E
    IL_002D: bgt.s IL_002E
    IL_002E: nop
    IL_002F: nop
    IL_0030: ldarg.0
    IL_0035: call 0x0A00002A
    IL_003A: ldstr 0x70001805
    IL_003B: conv.r8
    IL_003D: bge.s IL_003E
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: IL_22
    IL_0041: IL_8F
    IL_0042: IL_C2
    IL_0043: conv.u8
    IL_0044: IL_3E
    IL_0045: conv.r8
    IL_0047: bgt.s IL_0048
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ldarg.0
    IL_004F: call 0x0A00002A
    IL_0054: ldstr 0x70001805
    IL_0055: conv.r8
    IL_0056: IL_3C
    IL_0057: nop
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: pop
    IL_005F: br IL_00A7
    IL_0060: ldarg.0
    IL_0065: call 0x0A00002A
    IL_006A: ldstr 0x70001815
    IL_006B: conv.r8
    IL_006D: bge.s IL_006E
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: IL_22
    IL_0071: IL_8F
    IL_0072: IL_C2
    IL_0073: conv.u8
    IL_0074: IL_3E
    IL_0075: conv.r8
    IL_0077: bgt.s IL_0078
    IL_0078: nop
    IL_0079: stloc.0
    IL_007A: ldarg.0
    IL_007F: call 0x0A00002A
    IL_0084: ldstr 0x70001815
    IL_0085: conv.r8
    IL_0086: IL_3C
    IL_0087: nop
    IL_0088: nop
    IL_0089: stloc.0
    IL_008A: pop
    IL_008B: ldarg.0
    IL_0090: call 0x0A00002A
    IL_0095: ldstr 0x7000181F
    IL_0096: conv.r8
    IL_009B: newobj 0x0B0A0000
    IL_009C: ldloc.1
    IL_009D: IL_22
    IL_009E: IL_CD
    IL_009F: IL_CC
    IL_00A0: IL_4C
    IL_00A1: IL_3E
    IL_00A2: conv.r8
    IL_00A4: bgt.s IL_00A5
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00A7: ldarg.0
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x040003A7
    IL_00B2: call 0x060001C3
    IL_00B3: ret
    }

    public void ResetCostume() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040003A7
    IL_000B: call 0x060001C3
    IL_000C: ret
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
    IL_002B: stfld 0x040003A6
    IL_002C: ldarg.0
    IL_0031: ldfld 0x040003A5
    IL_0032: ldnull
    IL_0037: call 0x0A000021
    IL_003C: brfalse IL_0049
    IL_003D: ldarg.0
    IL_0042: ldfld 0x040003A5
    IL_0043: ldc.i4.0
    IL_0044: conv.r8
    IL_0045: stloc.1
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x040003A6
    IL_004F: ldc.i4.1
    IL_0050: conv.r8
    IL_0051: stloc.1
    IL_0052: nop
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: ldarg.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x040003A6
    IL_0060: stfld 0x040003A5
    IL_0061: ret
    }

    public void OpenGiftBox() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_000A: ldstr 0x70001833
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: stsfld 0x00306F3E
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: call 0x0A00002A
    IL_0024: ldstr 0x70001833
    IL_0025: conv.r8
    IL_0027: bge.s IL_0028
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldc.i4.1
    IL_002B: conv.r8
    IL_002D: ble.s IL_002E
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldarg.0
    IL_0035: call 0x0A00002A
    IL_003A: ldstr 0x70001833
    IL_003B: conv.r8
    IL_003C: IL_3C
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: pop
    IL_0041: ldarg.0
    IL_0046: call 0x0A00002A
    IL_004B: ldstr 0x70001805
    IL_004C: IL_22
    IL_004D: stloc.0
    IL_004E: IL_D7
    IL_004F: IL_23
    IL_0050: IL_3C
    IL_0051: ldc.i4.0
    IL_0052: conv.r8
    IL_0054: bge.s IL_0056
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: stloc.0
    IL_0058: ldloc.0
    IL_0059: IL_22
    IL_005A: IL_8F
    IL_005B: IL_C2
    IL_005C: conv.u8
    IL_005D: IL_3E
    IL_005E: conv.r8
    IL_0060: bgt.s IL_0061
    IL_0061: nop
    IL_0062: stloc.0
    IL_0063: ldloc.0
    IL_0064: ldc.i4.1
    IL_0065: conv.r8
    IL_0067: ble.s IL_0068
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: ret
    }

    public void OpenImpact() {
    IL_0004: ldstr 0x7000183D
    IL_0009: call 0x0A000077
    IL_000A: conv.r8
    IL_000F: beq IL_6F2B0010
    IL_0010: IL_01
    IL_0011: ldarg.1
    IL_0012: nop
    IL_0013: ldloc.0
    IL_0014: ret
    }

    public void Disappear() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003A6
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    public void Appear() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003A6
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    }}
