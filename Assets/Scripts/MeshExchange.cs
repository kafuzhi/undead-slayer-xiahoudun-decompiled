// Namespace: 
// Type: MeshExchange

    public class MeshExchange {{

    public object getcha;
    private object myskin;
    private object getskin;
    private object mybindPoses;

    public MeshExchange() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 24
    IL_0007: newarr 0x01000036
    IL_000C: stfld 0x040007F8
    IL_000D: ldarg.0
    IL_0012: call 0x0A000001
    IL_0013: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040007F5
    IL_0007: conv.r8
    IL_0008: IL_5A
    IL_0009: nop
    IL_000A: nop
    IL_000C: br.s IL_008A
    IL_000D: IL_F7
    IL_000E: ldloc.1
    IL_000F: nop
    IL_0010: ldarg.2
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: call 0x2B00005A
    IL_001C: stfld 0x040007F6
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040007F6
    IL_0023: ldarg.0
    IL_0028: ldfld 0x040007F7
    IL_0029: conv.r8
    IL_002A: IL_CF
    IL_002B: IL_01
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: conv.r8
    IL_0033: ldtoken 0x160A0001
    IL_0034: stloc.0
    IL_0039: br IL_0071
    IL_003A: ldarg.0
    IL_003F: ldfld 0x040007F8
    IL_0040: ldloc.0
    IL_0041: IL_8F
    IL_0042: IL_36
    IL_0043: nop
    IL_0044: nop
    IL_0045: IL_01
    IL_0046: ldarg.0
    IL_004B: ldfld 0x040007F6
    IL_004C: conv.r8
    IL_004D: IL_D1
    IL_004E: IL_01
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: ldloc.0
    IL_0052: ldelem.i
    IL_0053: conv.r8
    IL_0054: IL_D2
    IL_0055: IL_01
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ldarg.0
    IL_005D: ldfld 0x040007F5
    IL_005E: conv.r8
    IL_005F: IL_43
    IL_0060: IL_01
    IL_0061: nop
    IL_0062: stloc.0
    IL_0067: call 0x0A0001D3
    IL_0068: IL_81
    IL_0069: IL_36
    IL_006A: nop
    IL_006B: nop
    IL_006C: IL_01
    IL_006D: ldloc.0
    IL_006E: ldc.i4.1
    IL_006F: IL_58
    IL_0070: stloc.0
    IL_0071: ldloc.0
    IL_0073: ldc.i4.s 24
    IL_0074: IL_3F
    IL_0075: IL_C1
    IL_0076: IL_FF
    IL_0077: IL_FF
    IL_0078: IL_FF
    IL_0079: ldarg.0
    IL_007E: ldfld 0x040007F6
    IL_007F: conv.r8
    IL_0080: IL_CF
    IL_0081: IL_01
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x040007F8
    IL_008A: conv.r8
    IL_008B: IL_D4
    IL_008C: IL_01
    IL_008D: nop
    IL_008E: stloc.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x040007F6
    IL_0095: conv.r8
    IL_0096: IL_CF
    IL_0097: IL_01
    IL_0098: nop
    IL_0099: stloc.0
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040007F7
    IL_00A0: conv.r8
    IL_00A1: IL_CF
    IL_00A2: IL_01
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A5: conv.r8
    IL_00A6: IL_D5
    IL_00A7: IL_01
    IL_00A8: nop
    IL_00A9: stloc.0
    IL_00AA: conv.r8
    IL_00AB: IL_D6
    IL_00AC: IL_01
    IL_00AD: nop
    IL_00AE: stloc.0
    IL_00B3: ldstr 0x700227AE
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x040007F6
    IL_00BA: conv.r8
    IL_00BB: IL_CF
    IL_00BC: IL_01
    IL_00BD: nop
    IL_00BE: stloc.0
    IL_00BF: conv.r8
    IL_00C0: IL_D7
    IL_00C1: IL_01
    IL_00C2: nop
    IL_00C3: stloc.0
    IL_00C4: len
    IL_00C5: not
    IL_00C6: stloc.1
    IL_00C8: ldloca.s 1
    IL_00CD: call 0x0A000010
    IL_00D2: call 0x0A000011
    IL_00D7: call 0x0A00013D
    IL_00DC: ldstr 0x700227FE
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x040007F6
    IL_00E3: conv.r8
    IL_00E4: IL_D1
    IL_00E5: IL_01
    IL_00E6: nop
    IL_00E7: stloc.0
    IL_00E8: len
    IL_00E9: not
    IL_00EA: stloc.2
    IL_00EC: ldloca.s 2
    IL_00F1: call 0x0A000010
    IL_00F6: call 0x0A000011
    IL_00FB: call 0x0A00013D
    IL_00FC: ret
    }

    private void Update() {
    IL_0000: ret
    }

    }}
