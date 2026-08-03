// Namespace: LitJson
// Type: LitJson.JSONData

namespace LitJson {
    public class JSONData {{

    private object m_Data;

    public JSONData() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x040008DA
    IL_000D: ret
    }

    public JSONData() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_0009: IL_50
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public JSONData() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_0009: IL_52
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public JSONData() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_0009: IL_54
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public JSONData() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_0009: IL_4E
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public virtual void get_Value() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008DA
    IL_0006: ret
    }

    public virtual void set_Value() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040008DA
    IL_0007: ret
    }

    public virtual void ToString() {
    IL_0000: ldarg.0
    IL_0005: ldsfld 0x0A000099
    IL_0006: conv.r8
    IL_0007: IL_94
    IL_0008: ldarg.2
    IL_0009: nop
    IL_000A: ldloc.0
    IL_000B: ret
    }

    public virtual void ToString() {
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040008DA
    IL_000B: call 0x06000459
    IL_000C: ldarg.1
    IL_0011: call 0x0A0000ED
    IL_0012: ret
    }

    public virtual void Serialize() {
    IL_0004: ldsfld 0x0A000099
    IL_0009: newobj 0x0600048C
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: conv.r8
    IL_000E: IL_4D
    IL_000F: ldarg.2
    IL_0010: nop
    IL_0011: ldloc.0
    IL_0012: conv.r8
    IL_0013: IL_4E
    IL_0014: ldarg.2
    IL_0015: nop
    IL_0016: ldloc.0
    IL_0017: ldloc.0
    IL_001C: ldfld 0x040008DA
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040008DA
    IL_0027: call 0x0A0000EC
    IL_002C: brfalse IL_0041
    IL_002D: ldarg.1
    IL_002E: ldc.i4.4
    IL_002F: conv.r8
    IL_0031: brtrue.s IL_0034
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.1
    IL_0035: ldarg.0
    IL_0036: conv.r8
    IL_0037: IL_4D
    IL_0038: ldarg.2
    IL_0039: nop
    IL_003A: ldloc.0
    IL_003B: conv.r8
    IL_003D: beq.s IL_0040
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ret
    IL_0041: ldloc.0
    IL_0042: ldarg.0
    IL_0043: conv.r8
    IL_0044: IL_4F
    IL_0045: ldarg.2
    IL_0046: nop
    IL_0047: ldloc.0
    IL_0048: conv.r8
    IL_0049: IL_50
    IL_004A: ldarg.2
    IL_004B: nop
    IL_004C: ldloc.0
    IL_004D: ldloc.0
    IL_0052: ldfld 0x040008DA
    IL_0053: ldarg.0
    IL_0058: ldfld 0x040008DA
    IL_005D: call 0x0A0000EC
    IL_0062: brfalse IL_0077
    IL_0063: ldarg.1
    IL_0064: ldc.i4.7
    IL_0065: conv.r8
    IL_0067: brtrue.s IL_006A
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: ldarg.1
    IL_006B: ldarg.0
    IL_006C: conv.r8
    IL_006D: IL_4F
    IL_006E: ldarg.2
    IL_006F: nop
    IL_0070: ldloc.0
    IL_0071: conv.r8
    IL_0074: starg 2
    IL_0075: stloc.0
    IL_0076: ret
    IL_0077: ldloc.0
    IL_0078: ldarg.0
    IL_0079: conv.r8
    IL_007A: IL_51
    IL_007B: ldarg.2
    IL_007C: nop
    IL_007D: ldloc.0
    IL_007E: conv.r8
    IL_007F: IL_52
    IL_0080: ldarg.2
    IL_0081: nop
    IL_0082: ldloc.0
    IL_0083: ldloc.0
    IL_0088: ldfld 0x040008DA
    IL_0089: ldarg.0
    IL_008E: ldfld 0x040008DA
    IL_0093: call 0x0A0000EC
    IL_0098: brfalse IL_00AD
    IL_0099: ldarg.1
    IL_009A: ldc.i4.5
    IL_009B: conv.r8
    IL_009D: brtrue.s IL_00A0
    IL_009E: nop
    IL_009F: stloc.0
    IL_00A0: ldarg.1
    IL_00A1: ldarg.0
    IL_00A2: conv.r8
    IL_00A3: IL_51
    IL_00A4: ldarg.2
    IL_00A5: nop
    IL_00A6: ldloc.0
    IL_00A7: conv.r8
    IL_00AA: ldloc 2
    IL_00AB: stloc.0
    IL_00AC: ret
    IL_00AD: ldloc.0
    IL_00AE: ldarg.0
    IL_00AF: conv.r8
    IL_00B0: IL_53
    IL_00B1: ldarg.2
    IL_00B2: nop
    IL_00B3: ldloc.0
    IL_00B4: conv.r8
    IL_00B5: IL_54
    IL_00B6: ldarg.2
    IL_00B7: nop
    IL_00B8: ldloc.0
    IL_00B9: ldloc.0
    IL_00BE: ldfld 0x040008DA
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x040008DA
    IL_00C9: call 0x0A0000EC
    IL_00CE: brfalse IL_00E3
    IL_00CF: ldarg.1
    IL_00D0: ldc.i4.6
    IL_00D1: conv.r8
    IL_00D3: brtrue.s IL_00D6
    IL_00D4: nop
    IL_00D5: stloc.0
    IL_00D6: ldarg.1
    IL_00D7: ldarg.0
    IL_00D8: conv.r8
    IL_00D9: IL_53
    IL_00DA: ldarg.2
    IL_00DB: nop
    IL_00DC: ldloc.0
    IL_00DD: conv.r8
    IL_00E0: ldloca 2
    IL_00E1: stloc.0
    IL_00E2: ret
    IL_00E3: ldarg.1
    IL_00E4: ldc.i4.3
    IL_00E5: conv.r8
    IL_00E7: brtrue.s IL_00EA
    IL_00E8: nop
    IL_00E9: stloc.0
    IL_00EA: ldarg.1
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x040008DA
    IL_00F1: conv.r8
    IL_00F4: ldarg 2
    IL_00F5: stloc.0
    IL_00F6: ret
    }

    }}
}}
