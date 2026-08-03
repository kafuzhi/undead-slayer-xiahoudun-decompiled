// Namespace: LitJson
// Type: LitJson.JSONArray

namespace LitJson {
    public class JSONArray {{

    private object m_List;

    public JSONArray() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x0A000223
    IL_000A: stfld 0x040008D8
    IL_000B: ldarg.0
    IL_0010: call 0x0600043C
    IL_0011: ret
    }

    public virtual void get_Item() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D8
    IL_000E: conv.r8
    IL_000F: IL_24
    IL_0010: ldarg.0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0014: ldloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.0
    IL_001D: newobj 0x06000496
    IL_001E: ret
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040008D8
    IL_0025: ldarg.1
    IL_0026: conv.r8
    IL_0027: dup
    IL_0028: ldarg.0
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ret
    }

    public virtual void set_Item() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D8
    IL_000E: conv.r8
    IL_000F: IL_24
    IL_0010: ldarg.0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0015: ldloc.s 0
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040008D8
    IL_001E: ldarg.2
    IL_001F: conv.r8
    IL_0020: pop
    IL_0021: ldarg.0
    IL_0022: nop
    IL_0023: stloc.0
    IL_0028: br IL_0036
    IL_0029: ldarg.0
    IL_002E: ldfld 0x040008D8
    IL_002F: ldarg.1
    IL_0030: ldarg.2
    IL_0031: conv.r8
    IL_0032: IL_27
    IL_0033: ldarg.0
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ret
    }

    public virtual void get_Item() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x06000496
    IL_0006: ret
    }

    public virtual void set_Item() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D8
    IL_0006: ldarg.2
    IL_0007: conv.r8
    IL_0008: pop
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    public virtual void get_Count() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D8
    IL_0006: conv.r8
    IL_0007: IL_24
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ret
    }

    public virtual void Add() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D8
    IL_0006: ldarg.2
    IL_0007: conv.r8
    IL_0008: pop
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    public virtual void Remove() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D8
    IL_000E: conv.r8
    IL_000F: IL_24
    IL_0010: ldarg.0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0014: ldarg.0
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldnull
    IL_0019: ret
    IL_001A: ldarg.0
    IL_001F: ldfld 0x040008D8
    IL_0020: ldarg.1
    IL_0021: conv.r8
    IL_0022: dup
    IL_0023: ldarg.0
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040008D8
    IL_002D: ldarg.1
    IL_002E: conv.r8
    IL_0033: call 0x060A0002
    IL_0034: ret
    }

    public virtual void Remove() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D8
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_29
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: pop
    IL_000D: ldarg.1
    IL_000E: ret
    }

    public virtual void get_Childs() {
    IL_0004: newobj 0x06000783
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001066
    IL_000D: ldloc.0
    IL_000E: dup
    IL_0010: ldc.i4.s -2
    IL_0015: stfld 0x04001064
    IL_0016: ret
    }

    public virtual void GetEnumerator() {
    IL_0004: newobj 0x0600078B
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x0400106B
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022D0B
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008D8
    IL_000C: conv.r8
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: stloc.2
    IL_0016: br IL_0044
    IL_0018: ldloca.s 2
    IL_001D: call 0x0A00022B
    IL_001E: stloc.1
    IL_001F: ldloc.0
    IL_0020: conv.r8
    IL_0021: ldelem.i1
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldc.i4.2
    IL_0026: IL_3E
    IL_0027: stloc.2
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldloc.0
    IL_0030: ldstr 0x70022D11
    IL_0035: call 0x0A000011
    IL_0036: stloc.0
    IL_0037: ldloc.0
    IL_0038: ldloc.1
    IL_0039: conv.r8
    IL_003A: localloc
    IL_003B: ldarg.2
    IL_003C: nop
    IL_003D: ldloc.0
    IL_0042: call 0x0A000011
    IL_0043: stloc.0
    IL_0045: ldloca.s 2
    IL_004A: call 0x0A00022C
    IL_004F: brtrue IL_0017
    IL_0050: IL_DD
    IL_0051: stloc.2
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldloc.2
    IL_005A: newobj 0x1B00000D
    IL_005B: conv.r8
    IL_005C: ldelem.ref
    IL_005D: nop
    IL_005E: nop
    IL_005F: stloc.0
    IL_0060: IL_DC
    IL_0061: ldloc.0
    IL_0066: ldstr 0x70022D17
    IL_006B: call 0x0A000011
    IL_006C: stloc.0
    IL_006D: ldloc.0
    IL_006E: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022D0B
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008D8
    IL_000C: conv.r8
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: stloc.2
    IL_0016: br IL_0061
    IL_0018: ldloca.s 2
    IL_001D: call 0x0A00022B
    IL_001E: stloc.1
    IL_001F: ldloc.0
    IL_0020: conv.r8
    IL_0021: ldelem.i1
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldc.i4.3
    IL_0026: IL_3E
    IL_0027: stloc.2
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldloc.0
    IL_0030: ldstr 0x70022D11
    IL_0035: call 0x0A000011
    IL_0036: stloc.0
    IL_0037: ldloc.0
    IL_003C: ldstr 0x700229C4
    IL_003D: ldarg.1
    IL_0042: ldstr 0x700029FD
    IL_0047: call 0x0A0001EE
    IL_0048: stloc.0
    IL_0049: ldloc.0
    IL_004A: ldloc.1
    IL_004B: ldarg.1
    IL_0050: ldstr 0x700029FD
    IL_0055: call 0x0A000011
    IL_0056: conv.r8
    IL_0057: IL_4C
    IL_0058: ldarg.2
    IL_0059: nop
    IL_005A: ldloc.0
    IL_005F: call 0x0A000011
    IL_0060: stloc.0
    IL_0062: ldloca.s 2
    IL_0067: call 0x0A00022C
    IL_006C: brtrue IL_0017
    IL_006D: IL_DD
    IL_006E: stloc.2
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldloc.2
    IL_0077: newobj 0x1B00000D
    IL_0078: conv.r8
    IL_0079: ldelem.ref
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: IL_DC
    IL_007E: ldloc.0
    IL_0083: ldstr 0x700229C4
    IL_0084: ldarg.1
    IL_0089: ldstr 0x70022D1D
    IL_008E: call 0x0A0001EE
    IL_008F: stloc.0
    IL_0090: ldloc.0
    IL_0091: ret
    }

    public virtual void Serialize() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: conv.r8
    IL_0004: brtrue.s IL_0007
    IL_0005: nop
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D8
    IL_000E: conv.r8
    IL_000F: IL_24
    IL_0010: ldarg.0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: conv.r8
    IL_0015: beq.s IL_0018
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldc.i4.0
    IL_0019: stloc.0
    IL_001E: br IL_0035
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040008D8
    IL_0025: ldloc.0
    IL_0026: conv.r8
    IL_0027: dup
    IL_0028: ldarg.0
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.1
    IL_002C: conv.r8
    IL_002D: add
    IL_002E: ldarg.2
    IL_002F: nop
    IL_0030: ldloc.0
    IL_0031: ldloc.0
    IL_0032: ldc.i4.1
    IL_0033: IL_58
    IL_0034: stloc.0
    IL_0035: ldloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x040008D8
    IL_003C: conv.r8
    IL_003D: IL_24
    IL_003E: ldarg.0
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: IL_3F
    IL_0042: IL_D9
    IL_0043: IL_FF
    IL_0044: IL_FF
    IL_0045: IL_FF
    IL_0046: ret
    }

    }}
}}
