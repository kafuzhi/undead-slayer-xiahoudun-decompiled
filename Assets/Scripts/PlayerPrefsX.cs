// Namespace: 
// Type: PlayerPrefsX

    public sealed class PlayerPrefsX /* abstract */ {{

    public static void SetVector3() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100002F
    IL_0007: dup
    IL_0008: ldc.i4.0
    IL_000A: ldarga.s 1
    IL_000F: ldfld 0x0A00005E
    IL_0010: ldelem.r8
    IL_0011: dup
    IL_0012: ldc.i4.1
    IL_0014: ldarga.s 1
    IL_0019: ldfld 0x0A000023
    IL_001A: ldelem.r8
    IL_001B: dup
    IL_001C: ldc.i4.2
    IL_001E: ldarga.s 1
    IL_0023: ldfld 0x0A00005C
    IL_0024: ldelem.r8
    IL_0029: call 0x060003FB
    IL_002A: ret
    }

    public static void GetVector3() {
    IL_0000: ldarg.0
    IL_0005: call 0x060003FC
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: len
    IL_0009: not
    IL_000A: ldc.i4.3
    IL_000B: IL_3C
    IL_000C: ldloc.0
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0014: call 0x0A00001B
    IL_0015: ret
    IL_0016: ldloc.0
    IL_0017: ldc.i4.0
    IL_0018: IL_98
    IL_0019: ldloc.0
    IL_001A: ldc.i4.1
    IL_001B: IL_98
    IL_001C: ldloc.0
    IL_001D: ldc.i4.2
    IL_001E: IL_98
    IL_0023: newobj 0x0A000076
    IL_0024: ret
    }

    public static void SetBoolArray() {
    IL_0000: ldarg.1
    IL_0001: len
    IL_0002: not
    IL_0007: brtrue IL_000A
    IL_0008: ldc.i4.0
    IL_0009: ret
    IL_000E: newobj 0x0A0001DD
    IL_000F: stloc.0
    IL_0010: ldc.i4.0
    IL_0011: stloc.1
    IL_0016: br IL_002F
    IL_0017: ldloc.0
    IL_0018: ldarg.1
    IL_0019: ldloc.1
    IL_001A: IL_91
    IL_001B: conv.r8
    IL_001C: IL_DE
    IL_001D: IL_01
    IL_001E: nop
    IL_001F: stloc.0
    IL_0024: ldstr 0x700229C0
    IL_0025: conv.r8
    IL_0026: IL_DF
    IL_0027: IL_01
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: pop
    IL_002B: ldloc.1
    IL_002C: ldc.i4.1
    IL_002D: IL_58
    IL_002E: stloc.1
    IL_002F: ldloc.1
    IL_0030: ldarg.1
    IL_0031: len
    IL_0032: not
    IL_0033: ldc.i4.1
    IL_0034: IL_59
    IL_0035: IL_3F
    IL_0036: IL_DD
    IL_0037: IL_FF
    IL_0038: IL_FF
    IL_0039: IL_FF
    IL_003A: ldloc.0
    IL_003B: ldarg.1
    IL_003C: ldarg.1
    IL_003D: len
    IL_003E: not
    IL_003F: ldc.i4.1
    IL_0040: IL_59
    IL_0041: IL_91
    IL_0042: conv.r8
    IL_0043: IL_DE
    IL_0044: IL_01
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: pop
    IL_0048: ldarg.0
    IL_0049: ldloc.0
    IL_004A: conv.r8
    IL_004B: IL_E0
    IL_004C: IL_01
    IL_004D: nop
    IL_004E: stloc.0
    IL_0053: call 0x0A00008F
    IL_0054: IL_DD
    IL_0055: stloc.3
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: pop
    IL_005A: ldc.i4.0
    IL_005B: stloc.2
    IL_005C: IL_DD
    IL_005D: ldloc.1
    IL_005E: nop
    IL_005F: nop
    IL_0060: nop
    IL_0061: IL_DD
    IL_0062: nop
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: ldc.i4.1
    IL_0067: ret
    IL_0068: ldloc.2
    IL_0069: ret
    }

    public static void GetBoolArray() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_000A: brfalse IL_0055
    IL_000B: ldarg.0
    IL_0010: call 0x0A000097
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x0100002A
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_001D: ldstr 0x700229C0
    IL_001E: ldc.i4.0
    IL_001F: conv.r8
    IL_0020: IL_E2
    IL_0021: IL_01
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ldelem.i4
    IL_0025: conv.r8
    IL_0026: ldelem.i4
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: stloc.0
    IL_002B: ldloc.0
    IL_002C: len
    IL_002D: not
    IL_0032: newarr 0x01000013
    IL_0033: stloc.1
    IL_0034: ldc.i4.0
    IL_0035: stloc.2
    IL_003A: br IL_004A
    IL_003B: ldloc.1
    IL_003C: ldloc.2
    IL_003D: ldloc.0
    IL_003E: ldloc.2
    IL_003F: ldelem.i
    IL_0044: call 0x0A0001E3
    IL_0045: ldelem.i2
    IL_0046: ldloc.2
    IL_0047: ldc.i4.1
    IL_0048: IL_58
    IL_0049: stloc.2
    IL_004A: ldloc.2
    IL_004B: ldloc.0
    IL_004C: len
    IL_004D: not
    IL_004E: IL_3F
    IL_004F: IL_E8
    IL_0050: IL_FF
    IL_0051: IL_FF
    IL_0052: IL_FF
    IL_0053: ldloc.1
    IL_0054: ret
    IL_0055: ldc.i4.0
    IL_005A: newarr 0x01000013
    IL_005B: ret
    }

    public static void GetBoolArray() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_000A: brfalse IL_0012
    IL_000B: ldarg.0
    IL_0010: call 0x060003F6
    IL_0011: ret
    IL_0012: ldarg.2
    IL_0017: newarr 0x01000013
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001F: br IL_0028
    IL_0020: ldloc.0
    IL_0021: ldloc.1
    IL_0022: ldarg.1
    IL_0023: ldelem.i2
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: IL_58
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldarg.2
    IL_002A: IL_3F
    IL_002B: IL_F1
    IL_002C: IL_FF
    IL_002D: IL_FF
    IL_002E: IL_FF
    IL_002F: ldloc.0
    IL_0030: ret
    }

    public static void SetIntArray() {
    IL_0000: ldarg.1
    IL_0001: len
    IL_0002: not
    IL_0007: brtrue IL_000A
    IL_0008: ldc.i4.0
    IL_0009: ret
    IL_000E: newobj 0x0A0001DD
    IL_000F: stloc.0
    IL_0010: ldc.i4.0
    IL_0011: stloc.1
    IL_0016: br IL_002F
    IL_0017: ldloc.0
    IL_0018: ldarg.1
    IL_0019: ldloc.1
    IL_001A: IL_94
    IL_001B: conv.r8
    IL_001C: IL_E4
    IL_001D: IL_01
    IL_001E: nop
    IL_001F: stloc.0
    IL_0024: ldstr 0x700229C0
    IL_0025: conv.r8
    IL_0026: IL_DF
    IL_0027: IL_01
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: pop
    IL_002B: ldloc.1
    IL_002C: ldc.i4.1
    IL_002D: IL_58
    IL_002E: stloc.1
    IL_002F: ldloc.1
    IL_0030: ldarg.1
    IL_0031: len
    IL_0032: not
    IL_0033: ldc.i4.1
    IL_0034: IL_59
    IL_0035: IL_3F
    IL_0036: IL_DD
    IL_0037: IL_FF
    IL_0038: IL_FF
    IL_0039: IL_FF
    IL_003A: ldloc.0
    IL_003B: ldarg.1
    IL_003C: ldarg.1
    IL_003D: len
    IL_003E: not
    IL_003F: ldc.i4.1
    IL_0040: IL_59
    IL_0041: IL_94
    IL_0042: conv.r8
    IL_0043: IL_E4
    IL_0044: IL_01
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: pop
    IL_0048: ldarg.0
    IL_0049: ldloc.0
    IL_004A: conv.r8
    IL_004B: IL_E0
    IL_004C: IL_01
    IL_004D: nop
    IL_004E: stloc.0
    IL_0053: call 0x06000221
    IL_0054: IL_DD
    IL_0055: stloc.3
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: pop
    IL_005A: ldc.i4.0
    IL_005B: stloc.2
    IL_005C: IL_DD
    IL_005D: ldloc.1
    IL_005E: nop
    IL_005F: nop
    IL_0060: nop
    IL_0061: IL_DD
    IL_0062: nop
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: ldc.i4.1
    IL_0067: ret
    IL_0068: ldloc.2
    IL_0069: ret
    }

    public static void GetIntArray() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_000A: brfalse IL_0055
    IL_000B: ldarg.0
    IL_0010: call 0x06000222
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x0100002A
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_001D: ldstr 0x700229C0
    IL_001E: ldc.i4.0
    IL_001F: conv.r8
    IL_0020: IL_E2
    IL_0021: IL_01
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ldelem.i4
    IL_0025: conv.r8
    IL_0026: ldelem.i4
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: stloc.0
    IL_002B: ldloc.0
    IL_002C: len
    IL_002D: not
    IL_0032: newarr 0x0100000B
    IL_0033: stloc.1
    IL_0034: ldc.i4.0
    IL_0035: stloc.2
    IL_003A: br IL_004A
    IL_003B: ldloc.1
    IL_003C: ldloc.2
    IL_003D: ldloc.0
    IL_003E: ldloc.2
    IL_003F: ldelem.i
    IL_0044: call 0x0A00014B
    IL_0045: ldelem.i8
    IL_0046: ldloc.2
    IL_0047: ldc.i4.1
    IL_0048: IL_58
    IL_0049: stloc.2
    IL_004A: ldloc.2
    IL_004B: ldloc.0
    IL_004C: len
    IL_004D: not
    IL_004E: IL_3F
    IL_004F: IL_E8
    IL_0050: IL_FF
    IL_0051: IL_FF
    IL_0052: IL_FF
    IL_0053: ldloc.1
    IL_0054: ret
    IL_0055: ldc.i4.0
    IL_005A: newarr 0x0100000B
    IL_005B: ret
    }

    public static void GetIntArray() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_000A: brfalse IL_0012
    IL_000B: ldarg.0
    IL_0010: call 0x060003F9
    IL_0011: ret
    IL_0012: ldarg.2
    IL_0017: newarr 0x0100000B
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001F: br IL_0028
    IL_0020: ldloc.0
    IL_0021: ldloc.1
    IL_0022: ldarg.1
    IL_0023: ldelem.i8
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: IL_58
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldarg.2
    IL_002A: IL_3F
    IL_002B: IL_F1
    IL_002C: IL_FF
    IL_002D: IL_FF
    IL_002E: IL_FF
    IL_002F: ldloc.0
    IL_0030: ret
    }

    public static void SetFloatArray() {
    IL_0000: ldarg.1
    IL_0001: len
    IL_0002: not
    IL_0007: brtrue IL_000A
    IL_0008: ldc.i4.0
    IL_0009: ret
    IL_000E: newobj 0x0A0001DD
    IL_000F: stloc.0
    IL_0010: ldc.i4.0
    IL_0011: stloc.1
    IL_0016: br IL_002F
    IL_0017: ldloc.0
    IL_0018: ldarg.1
    IL_0019: ldloc.1
    IL_001A: IL_98
    IL_001B: conv.r8
    IL_001C: IL_E5
    IL_001D: IL_01
    IL_001E: nop
    IL_001F: stloc.0
    IL_0024: ldstr 0x700229C0
    IL_0025: conv.r8
    IL_0026: IL_DF
    IL_0027: IL_01
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: pop
    IL_002B: ldloc.1
    IL_002C: ldc.i4.1
    IL_002D: IL_58
    IL_002E: stloc.1
    IL_002F: ldloc.1
    IL_0030: ldarg.1
    IL_0031: len
    IL_0032: not
    IL_0033: ldc.i4.1
    IL_0034: IL_59
    IL_0035: IL_3F
    IL_0036: IL_DD
    IL_0037: IL_FF
    IL_0038: IL_FF
    IL_0039: IL_FF
    IL_003A: ldloc.0
    IL_003B: ldarg.1
    IL_003C: ldarg.1
    IL_003D: len
    IL_003E: not
    IL_003F: ldc.i4.1
    IL_0040: IL_59
    IL_0041: IL_98
    IL_0042: conv.r8
    IL_0043: IL_E5
    IL_0044: IL_01
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: pop
    IL_0048: ldarg.0
    IL_0049: ldloc.0
    IL_004A: conv.r8
    IL_004B: IL_E0
    IL_004C: IL_01
    IL_004D: nop
    IL_004E: stloc.0
    IL_0053: call 0x0A00008F
    IL_0054: IL_DD
    IL_0055: stloc.3
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: pop
    IL_005A: ldc.i4.0
    IL_005B: stloc.2
    IL_005C: IL_DD
    IL_005D: ldloc.1
    IL_005E: nop
    IL_005F: nop
    IL_0060: nop
    IL_0061: IL_DD
    IL_0062: nop
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: ldc.i4.1
    IL_0067: ret
    IL_0068: ldloc.2
    IL_0069: ret
    }

    public static void GetFloatArray() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_000A: brfalse IL_0055
    IL_000B: ldarg.0
    IL_0010: call 0x0A000097
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x0100002A
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_001D: ldstr 0x700229C0
    IL_001E: ldc.i4.0
    IL_001F: conv.r8
    IL_0020: IL_E2
    IL_0021: IL_01
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ldelem.i4
    IL_0025: conv.r8
    IL_0026: ldelem.i4
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: stloc.0
    IL_002B: ldloc.0
    IL_002C: len
    IL_002D: not
    IL_0032: newarr 0x0100002F
    IL_0033: stloc.1
    IL_0034: ldc.i4.0
    IL_0035: stloc.2
    IL_003A: br IL_004A
    IL_003B: ldloc.1
    IL_003C: ldloc.2
    IL_003D: ldloc.0
    IL_003E: ldloc.2
    IL_003F: ldelem.i
    IL_0044: call 0x0A0001E6
    IL_0045: ldelem.r8
    IL_0046: ldloc.2
    IL_0047: ldc.i4.1
    IL_0048: IL_58
    IL_0049: stloc.2
    IL_004A: ldloc.2
    IL_004B: ldloc.0
    IL_004C: len
    IL_004D: not
    IL_004E: IL_3F
    IL_004F: IL_E8
    IL_0050: IL_FF
    IL_0051: IL_FF
    IL_0052: IL_FF
    IL_0053: ldloc.1
    IL_0054: ret
    IL_0055: ldc.i4.0
    IL_005A: newarr 0x0100002F
    IL_005B: ret
    }

    public static void GetFloatArray() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_000A: brfalse IL_0012
    IL_000B: ldarg.0
    IL_0010: call 0x060003FC
    IL_0011: ret
    IL_0012: ldarg.2
    IL_0017: newarr 0x0100002F
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001F: br IL_0028
    IL_0020: ldloc.0
    IL_0021: ldloc.1
    IL_0022: ldarg.1
    IL_0023: ldelem.r8
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: IL_58
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldarg.2
    IL_002A: IL_3F
    IL_002B: IL_F1
    IL_002C: IL_FF
    IL_002D: IL_FF
    IL_002E: IL_FF
    IL_002F: ldloc.0
    IL_0030: ret
    }

    public static void SetStringArray() {
    IL_0000: ldarg.2
    IL_0001: len
    IL_0002: not
    IL_0007: brtrue IL_000A
    IL_0008: ldc.i4.0
    IL_0009: ret
    IL_000A: ldarg.0
    IL_000C: ldarga.s 1
    IL_0011: call 0x0A000149
    IL_0012: ldarg.2
    IL_0017: call 0x0A0001E7
    IL_001C: call 0x0A00008F
    IL_001D: IL_DD
    IL_001E: stloc.3
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: pop
    IL_0023: ldc.i4.0
    IL_0024: stloc.0
    IL_0025: IL_DD
    IL_0026: ldloc.1
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002A: IL_DD
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: nop
    IL_002F: ldc.i4.1
    IL_0030: ret
    IL_0031: ldloc.0
    IL_0032: ret
    }

    public static void SetStringArray() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700229C4
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: IL_E2
    IL_0009: IL_01
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.1
    IL_0011: call 0x060003FE
    IL_0016: brtrue IL_0019
    IL_0017: ldc.i4.0
    IL_0018: ret
    IL_0019: ldc.i4.1
    IL_001A: ret
    }

    public static void GetStringArray() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_000A: brfalse IL_0021
    IL_000B: ldarg.0
    IL_0010: call 0x0A000097
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x0100002A
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_0019: ldarg.1
    IL_001A: ldelem.i4
    IL_001B: conv.r8
    IL_001C: ldelem.i4
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ret
    IL_0021: ldc.i4.0
    IL_0026: newarr 0x0100000C
    IL_0027: ret
    }

    public static void GetStringArray() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_000A: brfalse IL_002B
    IL_000B: ldarg.0
    IL_0010: call 0x0A000097
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x0100002A
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_001D: ldstr 0x700229C4
    IL_001E: ldc.i4.0
    IL_001F: conv.r8
    IL_0020: IL_E2
    IL_0021: IL_01
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ldelem.i4
    IL_0025: conv.r8
    IL_0026: ldelem.i4
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ret
    IL_002B: ldc.i4.0
    IL_0030: newarr 0x0100000C
    IL_0031: ret
    }

    public static void GetStringArray() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_000A: brfalse IL_0021
    IL_000B: ldarg.0
    IL_0010: call 0x0A000097
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x0100002A
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_0019: ldarg.1
    IL_001A: ldelem.i4
    IL_001B: conv.r8
    IL_001C: ldelem.i4
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ret
    IL_0021: ldarg.3
    IL_0026: newarr 0x0100000C
    IL_0027: stloc.0
    IL_0028: ldc.i4.0
    IL_0029: stloc.1
    IL_002E: br IL_0037
    IL_002F: ldloc.0
    IL_0030: ldloc.1
    IL_0031: ldarg.2
    IL_0036: stelem 0x0B581707
    IL_0037: ldloc.1
    IL_0038: ldarg.3
    IL_0039: IL_3F
    IL_003A: IL_F1
    IL_003B: IL_FF
    IL_003C: IL_FF
    IL_003D: IL_FF
    IL_003E: ldloc.0
    IL_003F: ret
    }

    public static void GetStringArray() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700229C4
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: IL_E2
    IL_0009: IL_01
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.1
    IL_000D: ldarg.2
    IL_0012: call 0x06000402
    IL_0013: ret
    }

    }}
