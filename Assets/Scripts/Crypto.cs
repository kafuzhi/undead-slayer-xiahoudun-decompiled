// Namespace: 
// Type: Crypto

    public sealed class Crypto /* abstract */ {{

    private static object KEY;
    private static object IV;
    private static object deviceid;
    public static object memberNo;
    public static object usimsIndex;
    public static object telecomPayCode;
    private static object KEY2;

    static Crypto() {
    IL_0004: ldstr 0x700020B5
    IL_0009: stsfld 0x04000477
    IL_000E: ldstr 0x700020C7
    IL_0013: stsfld 0x04000478
    IL_0018: ldstr 0x70002109
    IL_001D: stsfld 0x04000479
    IL_0022: ldstr 0x7000211B
    IL_0027: stsfld 0x0400047B
    IL_002C: ldsfld 0x0A000099
    IL_0031: stsfld 0x0400047D
    IL_0032: ret
    }

    public static void Init() {
    IL_0004: call 0x0A00013E
    IL_0009: stsfld 0x04000479
    IL_000E: ldsfld 0x04000479
    IL_0013: ldstr 0x70002121
    IL_0018: call 0x0A000011
    IL_001D: stsfld 0x04000479
    IL_0022: ldsfld 0x04000479
    IL_0023: ldc.i4.0
    IL_0024: ldc.i4.8
    IL_0025: conv.r8
    IL_0026: ldelem.i2
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002E: stsfld 0x04000477
    IL_0033: call 0x0600004E
    IL_0034: conv.r8
    IL_0035: shl
    IL_0036: nop
    IL_0037: nop
    IL_0038: ldloc.0
    IL_0039: stloc.0
    IL_003A: ldloc.0
    IL_003F: stsfld 0x04000479
    IL_0044: ldsfld 0x04000479
    IL_0049: ldstr 0x70002121
    IL_004E: call 0x0A000011
    IL_0053: stsfld 0x04000479
    IL_0058: ldsfld 0x04000479
    IL_0059: ldc.i4.0
    IL_005A: ldc.i4.8
    IL_005B: conv.r8
    IL_005C: ldelem.i2
    IL_005D: nop
    IL_005E: nop
    IL_005F: stloc.0
    IL_0064: stsfld 0x0400047D
    IL_0065: ret
    }

    public static void SetUsim() {
    IL_0000: ldarg.0
    IL_0005: stsfld 0x0400047B
    IL_0006: ret
    }

    public static void SetTelecomPayCode() {
    IL_0000: ldarg.0
    IL_0005: stsfld 0x0400047C
    IL_0006: ret
    }

    public static void Rect2() {
    IL_0001: ldloca.s 0
    IL_0002: ldarg.0
    IL_0003: IL_22
    IL_0004: nop
    IL_0005: nop
    IL_0006: nop
    IL_880D73: switch (2229082 cases)
    }

    public static void Property_change() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.1
    IL_0007: brfalse IL_0018
    IL_000C: ldstr 0x700004D5
    IL_0011: call 0x06000220
    IL_0012: stloc.0
    IL_0017: br IL_0023
    IL_001C: ldstr 0x70001EA5
    IL_0021: call 0x06000220
    IL_0022: stloc.0
    IL_0023: ldarg.0
    IL_0024: ldc.i4.0
    IL_0025: IL_3C
    IL_0026: stloc.1
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002A: ldloc.0
    IL_002B: ldarg.0
    IL_002C: ldc.i4.m1
    IL_002D: IL_5A
    IL_002E: IL_3C
    IL_002F: ldarg.0
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: ldc.i4.0
    IL_0034: ret
    IL_0035: ldarg.1
    IL_003A: brfalse IL_004D
    IL_003F: ldstr 0x700004D5
    IL_0040: ldloc.0
    IL_0041: ldarg.0
    IL_0042: IL_58
    IL_0047: call 0x0600021F
    IL_004C: br IL_005A
    IL_0051: ldstr 0x70001EA5
    IL_0052: ldloc.0
    IL_0053: ldarg.0
    IL_0054: IL_58
    IL_0059: call 0x0600021F
    IL_005A: ldc.i4.1
    IL_005B: ret
    }

    public static void Save_int_key() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70002133
    IL_000A: call 0x0A000011
    IL_000B: stloc.0
    IL_000D: ldarga.s 1
    IL_0012: call 0x0A000010
    IL_0017: ldsfld 0x04000477
    IL_0018: ldloc.0
    IL_0019: ldc.i4.0
    IL_001A: ldc.i4.8
    IL_001B: conv.r8
    IL_001C: ldelem.i2
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0024: call 0x0A000011
    IL_0029: ldsfld 0x04000478
    IL_002E: call 0x06000225
    IL_002F: stloc.1
    IL_0030: ldarg.0
    IL_0031: ldloc.1
    IL_0036: call 0x0A00008F
    IL_0037: ret
    }

    public static void Load_int_key() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70002133
    IL_000A: call 0x0A000011
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: call 0x0A000097
    IL_0012: stloc.1
    IL_0017: ldsfld 0x0A000099
    IL_0018: stloc.2
    IL_0019: ldloc.1
    IL_001E: call 0x06000223
    IL_0023: ldsfld 0x04000477
    IL_0024: ldloc.0
    IL_0025: ldc.i4.0
    IL_0026: ldc.i4.8
    IL_0027: conv.r8
    IL_0028: ldelem.i2
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A000011
    IL_0035: ldsfld 0x04000478
    IL_003A: call 0x06000224
    IL_003B: stloc.2
    IL_003C: ldloc.2
    IL_003D: conv.r8
    IL_0040: ldloc 1
    IL_0041: stloc.0
    IL_0042: stloc.3
    IL_0043: ldc.i4.0
    IL_0045: stloc.s 4
    IL_0046: ldc.i4.0
    IL_0048: stloc.s 5
    IL_004D: br IL_0082
    IL_004E: ldloc.3
    IL_0050: ldloc.s 5
    IL_0051: IL_8F
    IL_0052: ret
    IL_0053: nop
    IL_0054: nop
    IL_0055: IL_01
    IL_005A: call 0x0A000149
    IL_005F: call 0x0A00014A
    IL_0061: stloc.s 6
    IL_0063: ldloc.s 6
    IL_0065: ldc.i4.s 33
    IL_0066: IL_3F
    IL_0067: ldloc.3
    IL_0068: nop
    IL_0069: nop
    IL_006A: nop
    IL_006C: ldloc.s 6
    IL_006E: ldc.i4.s 126
    IL_006F: IL_3E
    IL_0070: ldloc.2
    IL_0071: nop
    IL_0072: nop
    IL_0073: nop
    IL_0074: ldc.i4.1
    IL_0076: stloc.s 4
    IL_007B: br IL_008C
    IL_007D: ldloc.s 5
    IL_007E: ldc.i4.1
    IL_007F: IL_58
    IL_0081: stloc.s 5
    IL_0083: ldloc.s 5
    IL_0084: ldloc.3
    IL_0085: len
    IL_0086: not
    IL_0087: IL_3F
    IL_0088: IL_C2
    IL_0089: IL_FF
    IL_008A: IL_FF
    IL_008B: IL_FF
    IL_008D: ldloc.s 4
    IL_0092: brfalse IL_00B6
    IL_0093: ldloc.1
    IL_0098: call 0x06000223
    IL_009D: ldsfld 0x0400047D
    IL_009E: ldloc.0
    IL_009F: ldc.i4.0
    IL_00A0: ldc.i4.8
    IL_00A1: conv.r8
    IL_00A2: ldelem.i2
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00AA: call 0x0A000011
    IL_00AF: ldsfld 0x04000478
    IL_00B4: call 0x06000224
    IL_00B5: stloc.2
    IL_00B6: IL_DD
    IL_00B7: ret
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BC: stloc.s 7
    IL_00BD: ldloc.1
    IL_00C2: call 0x06000223
    IL_00C7: ldsfld 0x0400047D
    IL_00C8: ldloc.0
    IL_00C9: ldc.i4.0
    IL_00CA: ldc.i4.8
    IL_00CB: conv.r8
    IL_00CC: ldelem.i2
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: stloc.0
    IL_00D4: call 0x0A000011
    IL_00D9: ldsfld 0x04000478
    IL_00DE: call 0x06000224
    IL_00DF: stloc.2
    IL_00E0: IL_DD
    IL_00E1: nop
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: nop
    IL_00E5: ldloc.2
    IL_00EA: call 0x0A00014B
    IL_00EC: stloc.s 8
    IL_00EE: ldloc.s 8
    IL_00EF: ret
    }

    public static void Save_string_key() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70002133
    IL_000A: call 0x0A000011
    IL_000B: stloc.0
    IL_000C: ldarg.1
    IL_0011: ldsfld 0x04000477
    IL_0012: ldloc.0
    IL_0013: ldc.i4.0
    IL_0014: ldc.i4.8
    IL_0015: conv.r8
    IL_0016: ldelem.i2
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001E: call 0x0A000011
    IL_0023: ldsfld 0x04000478
    IL_0028: call 0x06000225
    IL_0029: stloc.1
    IL_002A: ldarg.0
    IL_002B: ldloc.1
    IL_0030: call 0x0A00008F
    IL_0031: ret
    }

    public static void Load_string_key() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70002133
    IL_000A: call 0x0A000011
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: call 0x0A000097
    IL_0012: stloc.1
    IL_0017: ldsfld 0x0A000099
    IL_0018: stloc.2
    IL_0019: ldloc.1
    IL_001E: call 0x06000223
    IL_0023: ldsfld 0x04000477
    IL_0024: ldloc.0
    IL_0025: ldc.i4.0
    IL_0026: ldc.i4.8
    IL_0027: conv.r8
    IL_0028: ldelem.i2
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A000011
    IL_0035: ldsfld 0x04000478
    IL_003A: call 0x06000224
    IL_003B: stloc.3
    IL_003C: ldloc.3
    IL_003D: ldc.i4.0
    IL_003E: ldc.i4.1
    IL_003F: conv.r8
    IL_0040: ldelem.i2
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0045: stloc.s 4
    IL_0047: ldloc.s 4
    IL_004C: call 0x0A00014A
    IL_004E: stloc.s 5
    IL_0050: ldloc.s 5
    IL_0052: ldc.i4.s 33
    IL_0053: IL_3F
    IL_0055: starg.s 0
    IL_0056: nop
    IL_0057: nop
    IL_0059: ldloc.s 5
    IL_005B: ldc.i4.s 126
    IL_005C: IL_3D
    IL_005D: ldloc.1
    IL_005E: nop
    IL_005F: nop
    IL_0060: nop
    IL_0061: ldloc.3
    IL_0062: stloc.2
    IL_0067: br IL_008F
    IL_0068: ldloc.1
    IL_006D: call 0x06000223
    IL_0072: ldsfld 0x0400047D
    IL_0073: ldloc.0
    IL_0074: ldc.i4.0
    IL_0075: ldc.i4.8
    IL_0076: conv.r8
    IL_0077: ldelem.i2
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007F: call 0x0A000011
    IL_0084: ldsfld 0x04000478
    IL_0089: call 0x06000224
    IL_008B: stloc.s 6
    IL_008D: ldloc.s 6
    IL_008E: stloc.2
    IL_008F: IL_DD
    IL_0090: ret
    IL_0091: nop
    IL_0092: nop
    IL_0093: nop
    IL_0095: stloc.s 7
    IL_0096: ldloc.1
    IL_009B: call 0x06000223
    IL_00A0: ldsfld 0x0400047D
    IL_00A1: ldloc.0
    IL_00A2: ldc.i4.0
    IL_00A3: ldc.i4.8
    IL_00A4: conv.r8
    IL_00A5: ldelem.i2
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: stloc.0
    IL_00AD: call 0x0A000011
    IL_00B2: ldsfld 0x04000478
    IL_00B7: call 0x06000224
    IL_00B8: stloc.2
    IL_00B9: IL_DD
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: ldloc.2
    IL_00BF: ret
    }

    public static void Decode() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00014C
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ret
    }

    public static void DecryptRJ256() {
    IL_0004: newobj 0x0A00014D
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_0009: IL_4E
    IL_000A: IL_01
    IL_000B: nop
    IL_000C: stloc.0
    IL_000D: stloc.1
    IL_000E: ldloc.0
    IL_000F: ldarg.2
    IL_0010: conv.r8
    IL_0011: IL_4E
    IL_0012: IL_01
    IL_0013: nop
    IL_0014: stloc.0
    IL_0015: stloc.2
    IL_001A: ldsfld 0x0A000099
    IL_001B: stloc.3
    IL_0020: newobj 0x0A00014F
    IL_0022: stloc.s 4
    IL_0024: ldloc.s 4
    IL_0025: ldc.i4.1
    IL_0026: conv.r8
    IL_0027: IL_50
    IL_0028: IL_01
    IL_0029: nop
    IL_002A: stloc.0
    IL_002C: ldloc.s 4
    IL_0031: ldc.i4 256
    IL_0032: conv.r8
    IL_0033: IL_51
    IL_0034: IL_01
    IL_0035: nop
    IL_0036: stloc.0
    IL_0038: ldloc.s 4
    IL_003D: ldc.i4 256
    IL_003E: conv.r8
    IL_003F: IL_52
    IL_0040: IL_01
    IL_0041: nop
    IL_0042: stloc.0
    IL_0044: ldloc.s 4
    IL_0045: ldloc.1
    IL_0046: conv.r8
    IL_0047: IL_53
    IL_0048: IL_01
    IL_0049: nop
    IL_004A: stloc.0
    IL_004C: ldloc.s 4
    IL_004D: ldloc.2
    IL_004E: conv.r8
    IL_004F: IL_54
    IL_0050: IL_01
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0058: newobj 0x0A000155
    IL_005A: stloc.s 5
    IL_005C: ldloc.s 5
    IL_005E: ldloc.s 4
    IL_005F: ldloc.1
    IL_0060: ldloc.2
    IL_0061: conv.r8
    IL_0062: IL_56
    IL_0063: IL_01
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ldc.i4.0
    IL_006B: newobj 0x0A000157
    IL_006D: stloc.s 6
    IL_006F: ldloc.s 6
    IL_0074: newobj 0x0A000158
    IL_0076: stloc.s 7
    IL_0078: ldloc.s 7
    IL_0079: conv.r8
    IL_007A: IL_59
    IL_007B: IL_01
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: stloc.3
    IL_007F: IL_DD
    IL_0081: ldarga.s 0
    IL_0082: nop
    IL_0083: nop
    IL_0085: ldloc.s 7
    IL_008A: brfalse IL_0092
    IL_008C: ldloc.s 7
    IL_008D: conv.r8
    IL_008E: ldelem.ref
    IL_008F: nop
    IL_0090: nop
    IL_0091: stloc.0
    IL_0092: IL_DC
    IL_0094: ldloc.s 6
    IL_0095: conv.r8
    IL_0096: IL_5A
    IL_0097: IL_01
    IL_0098: nop
    IL_0099: stloc.0
    IL_009A: IL_DD
    IL_009C: ldarga.s 0
    IL_009D: nop
    IL_009E: nop
    IL_00A0: ldloc.s 6
    IL_00A5: brfalse IL_00AD
    IL_00A7: ldloc.s 6
    IL_00A8: conv.r8
    IL_00A9: ldelem.ref
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: stloc.0
    IL_00AD: IL_DC
    IL_00AE: IL_DD
    IL_00AF: ldloc.2
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: nop
    IL_00B4: ldloc.s 4
    IL_00B5: conv.r8
    IL_00B6: add
    IL_00B7: IL_01
    IL_00B8: nop
    IL_00B9: stloc.0
    IL_00BA: IL_DC
    IL_00BB: ldloc.3
    IL_00BC: ret
    }

    public static void EncryptString() {
    IL_0004: call 0x0A00015C
    IL_0005: ldarg.1
    IL_0006: conv.r8
    IL_0007: IL_4E
    IL_0008: IL_01
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: stloc.0
    IL_0010: call 0x0A00015C
    IL_0011: ldarg.2
    IL_0012: conv.r8
    IL_0013: IL_4E
    IL_0014: IL_01
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: stloc.1
    IL_0018: ldnull
    IL_0019: stloc.2
    IL_001E: newobj 0x0A00014F
    IL_001F: stloc.3
    IL_0020: ldloc.3
    IL_0025: ldc.i4 256
    IL_0026: conv.r8
    IL_0027: IL_52
    IL_0028: IL_01
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldloc.3
    IL_002C: ldloc.0
    IL_002D: conv.r8
    IL_002E: IL_53
    IL_002F: IL_01
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldloc.3
    IL_0033: ldloc.1
    IL_0034: conv.r8
    IL_0035: IL_54
    IL_0036: IL_01
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldloc.3
    IL_003A: ldc.i4.1
    IL_003B: conv.r8
    IL_003C: IL_50
    IL_003D: IL_01
    IL_003E: nop
    IL_003F: stloc.0
    IL_0044: newobj 0x0A00015D
    IL_0046: stloc.s 4
    IL_0048: ldloc.s 4
    IL_0049: ldloc.3
    IL_004A: ldloc.0
    IL_004B: ldloc.1
    IL_004C: conv.r8
    IL_004D: div
    IL_004E: IL_01
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: ldc.i4.1
    IL_0056: newobj 0x0A000157
    IL_0058: stloc.s 5
    IL_005A: ldloc.s 5
    IL_005F: newobj 0x0A00015F
    IL_0061: stloc.s 6
    IL_0063: ldloc.s 6
    IL_0064: ldarg.0
    IL_0065: conv.r8
    IL_0066: rem
    IL_0067: IL_01
    IL_0068: nop
    IL_0069: stloc.0
    IL_006B: ldloc.s 6
    IL_006C: conv.r8
    IL_006D: rem.un
    IL_006E: IL_01
    IL_006F: nop
    IL_0070: stloc.0
    IL_0071: IL_DD
    IL_0073: ldarga.s 0
    IL_0074: nop
    IL_0075: nop
    IL_0077: ldloc.s 6
    IL_007C: brfalse IL_0084
    IL_007E: ldloc.s 6
    IL_007F: conv.r8
    IL_0080: ldelem.ref
    IL_0081: nop
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: IL_DC
    IL_0086: ldloc.s 5
    IL_0087: conv.r8
    IL_0088: IL_5A
    IL_0089: IL_01
    IL_008A: nop
    IL_008B: stloc.0
    IL_008C: IL_DD
    IL_008E: ldarga.s 0
    IL_008F: nop
    IL_0090: nop
    IL_0092: ldloc.s 5
    IL_0097: brfalse IL_009F
    IL_0099: ldloc.s 5
    IL_009A: conv.r8
    IL_009B: ldelem.ref
    IL_009C: nop
    IL_009D: nop
    IL_009E: stloc.0
    IL_009F: IL_DC
    IL_00A1: ldloc.s 4
    IL_00A2: conv.r8
    IL_00A3: and
    IL_00A4: IL_01
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00A8: stloc.s 7
    IL_00AA: ldloc.s 7
    IL_00AF: call 0x0A000163
    IL_00B0: stloc.2
    IL_00B2: ldloc.s 4
    IL_00B3: conv.r8
    IL_00B4: xor
    IL_00B5: IL_01
    IL_00B6: nop
    IL_00B7: stloc.0
    IL_00B8: IL_DD
    IL_00B9: div.un
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: nop
    IL_00BE: stloc.s 8
    IL_00C3: ldstr 0x70002149
    IL_00C5: ldloc.s 8
    IL_00C6: conv.r8
    IL_00C7: shl
    IL_00C8: IL_01
    IL_00C9: nop
    IL_00CA: stloc.0
    IL_00CF: call 0x0A000166
    IL_00D0: ldnull
    IL_00D2: stloc.s 11
    IL_00D3: IL_DD
    IL_00D6: ldarga 0
    IL_00D7: nop
    IL_00D8: IL_DD
    IL_00D9: IL_3F
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: nop
    IL_00DE: stloc.s 9
    IL_00E3: ldstr 0x70002191
    IL_00E5: ldloc.s 9
    IL_00E6: conv.r8
    IL_00E7: shl
    IL_00E8: IL_01
    IL_00E9: nop
    IL_00EA: stloc.0
    IL_00EF: call 0x0A000166
    IL_00F0: ldnull
    IL_00F2: stloc.s 11
    IL_00F3: IL_DD
    IL_00F4: pop
    IL_00F5: nop
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: IL_DD
    IL_00FA: ldc.i4.s 0
    IL_00FB: nop
    IL_00FC: nop
    IL_00FE: stloc.s 10
    IL_0103: ldstr 0x700021C7
    IL_0105: ldloc.s 10
    IL_0106: conv.r8
    IL_0107: shl
    IL_0108: IL_01
    IL_0109: nop
    IL_010A: stloc.0
    IL_010F: call 0x0A000166
    IL_0110: IL_DD
    IL_0111: ldloc.1
    IL_0112: nop
    IL_0113: nop
    IL_0114: nop
    IL_0115: ldloc.3
    IL_0116: conv.r8
    IL_0117: add
    IL_0118: IL_01
    IL_0119: nop
    IL_011A: stloc.0
    IL_011B: IL_DC
    IL_011C: ldloc.2
    IL_011D: ret
    IL_011F: ldloc.s 11
    IL_0120: ret
    }

    }}
