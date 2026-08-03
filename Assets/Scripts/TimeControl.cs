// Namespace: 
// Type: TimeControl

    public sealed class TimeControl /* abstract */ {{

    private static object MAXWORK;
    public static object work_starttime;
    public static object string_starttime;
    public static object difference;
    public static object servertime;

    static TimeControl() {
    IL_0000: ldc.i4.2
    IL_0005: newarr 0x01000066
    IL_000A: stsfld 0x04000A11
    IL_000B: ldc.i4.2
    IL_0010: newarr 0x0100000C
    IL_0015: stsfld 0x04000A12
    IL_0016: ret
    }

    public static void InitStart() {
    IL_0004: ldstr 0x70023053
    IL_0009: call 0x06000401
    IL_000E: stsfld 0x04000A12
    IL_000F: ldc.i4.2
    IL_0014: newarr 0x01000045
    IL_0015: stloc.0
    IL_0016: ldc.i4.0
    IL_0017: stloc.1
    IL_001C: br IL_0068
    IL_001D: ldloc.0
    IL_001E: ldloc.1
    IL_0023: ldsfld 0x04000A12
    IL_0024: ldloc.1
    IL_0025: ldelem.i
    IL_002A: call 0x0A0002A2
    IL_002B: ldelem.r4
    IL_0030: ldsfld 0x04000A11
    IL_0031: ldloc.1
    IL_0032: IL_8F
    IL_0033: shr
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_01
    IL_0037: ldloc.0
    IL_0038: ldloc.1
    IL_0039: IL_96
    IL_003E: call 0x0A0002A3
    IL_003F: IL_81
    IL_0040: shr
    IL_0041: nop
    IL_0042: nop
    IL_0043: IL_01
    IL_0044: IL_DD
    IL_0045: ldc.i4.5
    IL_0046: nop
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.2
    IL_004E: ldsfld 0x04000A11
    IL_004F: ldloc.1
    IL_0050: IL_8F
    IL_0051: shr
    IL_0052: nop
    IL_0053: nop
    IL_0054: IL_01
    IL_0059: call 0x0A0001EC
    IL_005A: IL_81
    IL_005B: shr
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_01
    IL_005F: IL_DD
    IL_0060: nop
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldloc.1
    IL_0065: ldc.i4.1
    IL_0066: IL_58
    IL_0067: stloc.1
    IL_0068: ldloc.1
    IL_0069: ldc.i4.2
    IL_006A: IL_3F
    IL_006B: IL_AE
    IL_006C: IL_FF
    IL_006D: IL_FF
    IL_006E: IL_FF
    IL_006F: ret
    }

    public static void SetDelay() {
    IL_0004: ldsfld 0x04000A14
    IL_0006: ldloca.s 0
    IL_000D: constrained 0x01000066
    IL_0012: call 0x0A0002A4
    IL_0017: brfalse IL_0019
    IL_0018: ret
    IL_001D: ldsfld 0x04000A11
    IL_001E: ldarg.0
    IL_001F: IL_8F
    IL_0020: shr
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_01
    IL_0028: ldsfld 0x04000A14
    IL_0029: IL_81
    IL_002A: shr
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_01
    IL_0032: ldsfld 0x04000A12
    IL_0033: ldarg.0
    IL_0038: ldsfld 0x04000A11
    IL_0039: ldarg.0
    IL_003A: IL_8F
    IL_003B: shr
    IL_003C: nop
    IL_003D: nop
    IL_003E: IL_01
    IL_0043: call 0x0A0002A5
    IL_0044: stloc.1
    IL_0046: ldloca.s 1
    IL_004B: call 0x0A0002A6
    IL_0050: stelem 0x02305372
    IL_0055: cpobj 0x000A127E
    IL_0056: ldarg.2
    IL_005B: call 0x060003FF
    IL_005C: pop
    IL_005D: ret
    }

    public static void SetRemain() {
    IL_0004: ldstr 0x7002305B
    IL_0005: ldc.i4.1
    IL_000A: newarr 0x0100000B
    IL_000B: dup
    IL_000C: ldc.i4.0
    IL_000D: ldarg.0
    IL_000E: ldelem.i8
    IL_0013: call 0x060003F8
    IL_0014: pop
    IL_0015: ret
    }

    public static void EraseAll() {
    IL_0000: ldc.i4.2
    IL_0005: newarr 0x0100000C
    IL_000A: stsfld 0x04000A12
    IL_000B: ldc.i4.2
    IL_0010: newarr 0x01000066
    IL_0015: stsfld 0x04000A11
    IL_0016: ldc.i4.0
    IL_0017: stloc.0
    IL_001C: br IL_0087
    IL_0021: ldsfld 0x04000A14
    IL_0023: ldloca.s 1
    IL_002A: constrained 0x01000066
    IL_002F: call 0x0A0002A4
    IL_0034: brfalse IL_004F
    IL_0039: ldsfld 0x04000A11
    IL_003A: ldloc.0
    IL_003B: IL_8F
    IL_003C: shr
    IL_003D: nop
    IL_003E: nop
    IL_003F: IL_01
    IL_0044: call 0x0A0002A7
    IL_0045: IL_81
    IL_0046: shr
    IL_0047: nop
    IL_0048: nop
    IL_0049: IL_01
    IL_004E: br IL_0064
    IL_0053: ldsfld 0x04000A11
    IL_0054: ldloc.0
    IL_0055: IL_8F
    IL_0056: shr
    IL_0057: nop
    IL_0058: nop
    IL_0059: IL_01
    IL_005E: ldsfld 0x04000A14
    IL_005F: IL_81
    IL_0060: shr
    IL_0061: nop
    IL_0062: nop
    IL_0063: IL_01
    IL_0068: ldsfld 0x04000A12
    IL_0069: ldloc.0
    IL_006E: ldsfld 0x04000A11
    IL_006F: ldloc.0
    IL_0070: IL_8F
    IL_0071: shr
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_01
    IL_0079: call 0x0A0002A5
    IL_007A: stloc.2
    IL_007C: ldloca.s 2
    IL_0081: call 0x0A0002A6
    IL_0086: stelem 0x0A581706
    IL_0087: ldloc.0
    IL_0088: ldc.i4.2
    IL_0089: IL_3F
    IL_008A: IL_8F
    IL_008B: IL_FF
    IL_008C: IL_FF
    IL_008D: IL_FF
    IL_0092: ldstr 0x70023053
    IL_0097: ldsfld 0x04000A12
    IL_009C: call 0x060003FF
    IL_009D: pop
    IL_009E: ret
    }

    public static void RequestServerTime() {
    IL_0004: call 0x0A0001EC
    IL_0009: stsfld 0x04000A14
    IL_000A: ret
    }

    public static void SubtractDelay() {
    IL_0004: ldsfld 0x04000A14
    IL_0006: ldloca.s 1
    IL_000D: constrained 0x01000066
    IL_0012: call 0x0A0002A4
    IL_0017: brfalse IL_001A
    IL_0018: ldc.i4.0
    IL_0019: ret
    IL_001E: ldsflda 0x04000A14
    IL_0023: ldsfld 0x04000A11
    IL_0024: ldarg.0
    IL_0025: IL_8F
    IL_0026: shr
    IL_0027: nop
    IL_0028: nop
    IL_0029: IL_01
    IL_002E: ldobj 0x01000066
    IL_0033: call 0x0A0002A8
    IL_0038: stsfld 0x04000A13
    IL_0039: ldc.i4.0
    IL_003A: stloc.0
    IL_003F: ldsflda 0x04000A13
    IL_0044: call 0x0A0002A9
    IL_0045: not
    IL_0046: stloc.0
    IL_0047: ldloc.0
    IL_0048: ldc.i4.0
    IL_004D: ldc.i4 10000
    IL_0052: call 0x0A0002AA
    IL_0053: stloc.0
    IL_0054: ldloc.0
    IL_0055: ret
    }

    private static void GameQuit() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_002A
    IL_000B: ldsfld 0x04000A12
    IL_000C: ldloc.0
    IL_0011: ldsfld 0x04000A11
    IL_0012: ldloc.0
    IL_0013: IL_8F
    IL_0014: shr
    IL_0015: nop
    IL_0016: nop
    IL_0017: IL_01
    IL_001C: call 0x0A0002A5
    IL_001D: stloc.1
    IL_001F: ldloca.s 1
    IL_0024: call 0x0A0002A6
    IL_0029: stelem 0x0A581706
    IL_002A: ldloc.0
    IL_002B: ldc.i4.2
    IL_002C: IL_3F
    IL_002D: IL_D6
    IL_002E: IL_FF
    IL_002F: IL_FF
    IL_0030: IL_FF
    IL_0035: ldstr 0x70023053
    IL_003A: ldsfld 0x04000A12
    IL_003F: call 0x060003FF
    IL_0040: pop
    IL_0041: ret
    }

    }}
