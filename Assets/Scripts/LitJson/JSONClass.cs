// Namespace: LitJson
// Type: LitJson.JSONClass

namespace LitJson {
    public class JSONClass {{

    private object m_Dict;

    public JSONClass() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x0A00022F
    IL_000A: stfld 0x040008D9
    IL_000B: ldarg.0
    IL_0010: call 0x0600043C
    IL_0011: ret
    }

    public virtual void get_Item() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0009: ble.s IL_000C
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: brfalse IL_001E
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040008D9
    IL_0017: ldarg.1
    IL_0018: conv.r8
    IL_001A: blt.s IL_001D
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ret
    IL_001E: ldarg.0
    IL_001F: ldarg.1
    IL_0024: newobj 0x06000497
    IL_0025: ret
    }

    public virtual void set_Item() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0009: ble.s IL_000C
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: brfalse IL_0023
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040008D9
    IL_0017: ldarg.1
    IL_0018: ldarg.2
    IL_0019: conv.r8
    IL_001B: bne.un.s IL_001E
    IL_001C: nop
    IL_001D: stloc.0
    IL_0022: br IL_0030
    IL_0023: ldarg.0
    IL_0028: ldfld 0x040008D9
    IL_0029: ldarg.1
    IL_002A: ldarg.2
    IL_002B: conv.r8
    IL_002C: IL_34
    IL_002D: ldarg.0
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ret
    }

    public void hasKey() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0009: ble.s IL_000C
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
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
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
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
    IL_001F: ldfld 0x040008D9
    IL_0020: ldarg.1
    IL_0025: call 0x2B000061
    IL_0026: stloc.0
    IL_0028: ldloca.s 0
    IL_002D: call 0x0A000236
    IL_002E: ret
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
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0014: IL_01
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ret
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040008D9
    IL_001F: ldarg.1
    IL_0024: call 0x2B000061
    IL_0025: stloc.1
    IL_0027: ldloca.s 1
    IL_002C: call 0x0A000237
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040008D9
    IL_0034: ldloc.0
    IL_0035: ldarg.2
    IL_0036: conv.r8
    IL_0038: bne.un.s IL_003B
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ret
    }

    public virtual void get_Count() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: conv.r8
    IL_0008: bgt.s IL_000B
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ret
    }

    public void key() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
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
    IL_001F: ldfld 0x040008D9
    IL_0020: ldarg.1
    IL_0025: call 0x2B000061
    IL_0026: stloc.0
    IL_0028: ldloca.s 0
    IL_002D: call 0x0A000237
    IL_002E: ret
    }

    public virtual void Add() {
    IL_0000: ldarg.1
    IL_0005: call 0x0A00020C
    IL_000A: brtrue IL_0040
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040008D9
    IL_0011: ldarg.1
    IL_0012: conv.r8
    IL_0014: ble.s IL_0017
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: brfalse IL_002E
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040008D9
    IL_0022: ldarg.1
    IL_0023: ldarg.2
    IL_0024: conv.r8
    IL_0026: bne.un.s IL_0029
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: br IL_003B
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040008D9
    IL_0034: ldarg.1
    IL_0035: ldarg.2
    IL_0036: conv.r8
    IL_0037: IL_34
    IL_0038: ldarg.0
    IL_0039: nop
    IL_003A: stloc.0
    IL_003F: br IL_0059
    IL_0040: ldarg.0
    IL_0045: ldfld 0x040008D9
    IL_004A: call 0x0A000238
    IL_004B: stloc.0
    IL_004D: ldloca.s 0
    IL_0052: call 0x0A000239
    IL_0053: ldarg.2
    IL_0054: conv.r8
    IL_0055: IL_34
    IL_0056: ldarg.0
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ret
    }

    public virtual void Remove() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0009: ble.s IL_000C
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: brtrue IL_0013
    IL_0011: ldnull
    IL_0012: ret
    IL_0013: ldarg.0
    IL_0018: ldfld 0x040008D9
    IL_0019: ldarg.1
    IL_001A: conv.r8
    IL_001C: blt.s IL_001F
    IL_001D: nop
    IL_001E: stloc.0
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0025: ldfld 0x040008D9
    IL_0026: ldarg.1
    IL_0027: conv.r8
    IL_002C: brtrue IL_260A002F
    IL_002D: ldloc.0
    IL_002E: ret
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
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
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
    IL_001F: ldfld 0x040008D9
    IL_0020: ldarg.1
    IL_0025: call 0x2B000061
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040008D9
    IL_002E: ldloca.s 0
    IL_0033: call 0x0A000237
    IL_0034: conv.r8
    IL_0039: brtrue IL_260A003C
    IL_003B: ldloca.s 0
    IL_0040: call 0x0A000236
    IL_0041: ret
    }

    public virtual void Remove() {
    IL_0004: newobj 0x060007DC
    IL_0005: stloc.1
    IL_0006: ldloc.1
    IL_0007: ldarg.1
    IL_000C: stfld 0x040010D3
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040008D9
    IL_0013: ldloc.1
    IL_0015: 0xFE 06
    IL_0016: IL_DD
    IL_0017: ldloc.1
    IL_0018: nop
    IL_0019: ldloc.0
    IL_001E: newobj 0x0A00023B
    IL_0023: call 0x2B000062
    IL_0028: call 0x2B000063
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040008D9
    IL_0031: ldloca.s 0
    IL_0036: call 0x0A000237
    IL_0037: conv.r8
    IL_003C: brtrue IL_260A003F
    IL_003D: ldloc.1
    IL_0042: ldfld 0x040010D3
    IL_0043: stloc.2
    IL_0044: IL_DD
    IL_0046: ldloca.s 0
    IL_0047: nop
    IL_0048: nop
    IL_0049: IL_DD
    IL_004A: stloc.3
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: pop
    IL_004F: ldnull
    IL_0050: stloc.2
    IL_0051: IL_DD
    IL_0052: ldarg.3
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: IL_DD
    IL_0057: nop
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: ldloc.2
    IL_005C: ret
    }

    public virtual void get_Childs() {
    IL_0004: newobj 0x06000791
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001070
    IL_000D: ldloc.0
    IL_000E: dup
    IL_0010: ldc.i4.s -2
    IL_0015: stfld 0x0400106E
    IL_0016: ret
    }

    public virtual void GetEnumerator() {
    IL_0004: newobj 0x06000799
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001075
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022D21
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008D9
    IL_000C: conv.r8
    IL_000D: IL_3E
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: stloc.2
    IL_0016: br IL_0077
    IL_0018: ldloca.s 2
    IL_001D: call 0x0A00023F
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
    IL_0038: stloc.3
    IL_0039: ldc.i4.5
    IL_003E: newarr 0x0100000C
    IL_003F: dup
    IL_0040: ldc.i4.0
    IL_0041: ldloc.3
    IL_0046: stelem 0x25721725
    IL_0048: brtrue.s IL_004B
    IL_004D: cpobj 0x121825A2
    IL_004E: IL_01
    IL_0053: call 0x0A000237
    IL_0058: call 0x06000459
    IL_005D: stelem 0x29721925
    IL_005F: brtrue.s IL_0062
    IL_0064: cpobj 0x121A25A2
    IL_0065: IL_01
    IL_006A: call 0x0A000236
    IL_006B: conv.r8
    IL_006C: localloc
    IL_006D: ldarg.2
    IL_006E: nop
    IL_006F: ldloc.0
    IL_0074: stelem 0x00024028
    IL_0075: stloc.0
    IL_0076: stloc.0
    IL_0078: ldloca.s 2
    IL_007D: call 0x0A000241
    IL_0082: brtrue IL_0017
    IL_0083: IL_DD
    IL_0084: stloc.2
    IL_0085: nop
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldloc.2
    IL_008D: newobj 0x1B000011
    IL_008E: conv.r8
    IL_008F: ldelem.ref
    IL_0090: nop
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: IL_DC
    IL_0094: ldloc.0
    IL_0099: ldstr 0x70000503
    IL_009E: call 0x0A000011
    IL_009F: stloc.0
    IL_00A0: ldloc.0
    IL_00A1: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022D2F
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008D9
    IL_000C: conv.r8
    IL_000D: IL_3E
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: stloc.2
    IL_0016: br IL_0094
    IL_0018: ldloca.s 2
    IL_001D: call 0x0A00023F
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
    IL_004A: stloc.3
    IL_004B: ldc.i4.5
    IL_0050: newarr 0x0100000C
    IL_0051: dup
    IL_0052: ldc.i4.0
    IL_0053: ldloc.3
    IL_0058: stelem 0x25721725
    IL_005A: brtrue.s IL_005D
    IL_005F: cpobj 0x121825A2
    IL_0060: IL_01
    IL_0065: call 0x0A000237
    IL_006A: call 0x06000459
    IL_006F: stelem 0x35721925
    IL_0071: brtrue.s IL_0074
    IL_0076: cpobj 0x121A25A2
    IL_0077: IL_01
    IL_007C: call 0x0A000236
    IL_007D: ldarg.1
    IL_0082: ldstr 0x700029FD
    IL_0087: call 0x0A000011
    IL_0088: conv.r8
    IL_0089: IL_4C
    IL_008A: ldarg.2
    IL_008B: nop
    IL_008C: ldloc.0
    IL_0091: stelem 0x00024028
    IL_0092: stloc.0
    IL_0093: stloc.0
    IL_0095: ldloca.s 2
    IL_009A: call 0x0A000241
    IL_009F: brtrue IL_0017
    IL_00A0: IL_DD
    IL_00A1: stloc.2
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: ldloc.2
    IL_00AA: newobj 0x1B000011
    IL_00AB: conv.r8
    IL_00AC: ldelem.ref
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B0: IL_DC
    IL_00B1: ldloc.0
    IL_00B6: ldstr 0x700229C4
    IL_00B7: ldarg.1
    IL_00BC: ldstr 0x70000503
    IL_00C1: call 0x0A0001EE
    IL_00C2: stloc.0
    IL_00C3: ldloc.0
    IL_00C4: ret
    }

    public virtual void Serialize() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.2
    IL_0002: conv.r8
    IL_0004: brtrue.s IL_0007
    IL_0005: nop
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: conv.r8
    IL_0015: beq.s IL_0018
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040008D9
    IL_001E: conv.r8
    IL_001F: IL_42
    IL_0020: ldarg.0
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: conv.r8
    IL_0024: IL_43
    IL_0025: ldarg.0
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: stloc.1
    IL_002D: br IL_004F
    IL_002F: ldloca.s 1
    IL_0034: call 0x0A000244
    IL_0035: stloc.0
    IL_0036: ldarg.1
    IL_0037: ldloc.0
    IL_0038: conv.r8
    IL_003B: ldarg 2
    IL_003C: stloc.0
    IL_003D: ldarg.0
    IL_0042: ldfld 0x040008D9
    IL_0043: ldloc.0
    IL_0044: conv.r8
    IL_0046: blt.s IL_0049
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.1
    IL_004A: conv.r8
    IL_004B: add
    IL_004C: ldarg.2
    IL_004D: nop
    IL_004E: ldloc.0
    IL_0050: ldloca.s 1
    IL_0055: call 0x0A000246
    IL_005A: brtrue IL_002E
    IL_005B: IL_DD
    IL_005C: stloc.2
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldloc.1
    IL_0065: newobj 0x1B000013
    IL_0066: conv.r8
    IL_0067: ldelem.ref
    IL_0068: nop
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: IL_DC
    IL_006C: ret
    }

    }}
}}
