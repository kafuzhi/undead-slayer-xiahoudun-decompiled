// Namespace: 
// Type: HttpMsgManager

    public class HttpMsgManager {{

    private static object MSG_GETRANK;
    private static object MSG_REGIST;
    private static object MSG_CHECK;
    private static object MSG_OWNRANKING;
    private static object MSG_GETREWARD;
    private static object MSG_BEARTHEPALM;
    private static object MSG_FINALRANKING;
    private static object MSG_SAVETELNUMBER;
    private object httpHost;
    private object showErrorWindow;
    private object errorString;
    private object userName;
    private object password;
    public object pop_blank;

    public HttpMsgManager() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700025F1
    IL_000A: stfld 0x040006D1
    IL_000B: ldarg.0
    IL_0010: ldsfld 0x0A000099
    IL_0015: stfld 0x040006D3
    IL_0016: ldarg.0
    IL_001B: ldsfld 0x0A000099
    IL_0020: stfld 0x040006D4
    IL_0021: ldarg.0
    IL_0026: ldsfld 0x0A000099
    IL_002B: stfld 0x040006D5
    IL_002C: ldarg.0
    IL_0031: call 0x0A000001
    IL_0032: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_000A: call 0x0A000090
    IL_000B: ret
    }

    private void Update() {
    IL_0000: ret
    }

    public void check() {
    IL_0004: newobj 0x0A0001A3
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_000B: ldstr 0x7000262F
    IL_0010: ldc.i4 10003
    IL_0011: stloc.1
    IL_0013: ldloca.s 1
    IL_0018: call 0x0A000010
    IL_0019: conv.r8
    IL_001A: IL_A4
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldloc.0
    IL_0023: ldstr 0x7000263B
    IL_0024: ldarg.1
    IL_0025: conv.r8
    IL_0026: IL_A4
    IL_0027: IL_01
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002B: ldarg.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x040006D1
    IL_0036: ldstr 0x7000264D
    IL_003B: call 0x0A000011
    IL_003C: ldloc.0
    IL_0041: call 0x06000327
    IL_0046: call 0x0A000047
    IL_0047: pop
    IL_0048: ret
    }

    public void regist() {
    IL_0004: ldstr 0x700004D5
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldc.i4 4000
    IL_0011: IL_3F
    IL_0013: starg.s 0
    IL_0014: nop
    IL_0015: nop
    IL_001A: call 0x0600004E
    IL_001F: ldstr 0x7000265B
    IL_0020: conv.r8
    IL_0021: xor
    IL_0022: nop
    IL_0023: nop
    IL_0024: ldloc.0
    IL_0025: ret
    IL_002A: newobj 0x0A0001A3
    IL_002B: stloc.1
    IL_002C: ldloc.1
    IL_0031: ldstr 0x7000262F
    IL_0036: ldc.i4 10002
    IL_0038: stloc.s 4
    IL_003A: ldloca.s 4
    IL_003F: call 0x0A000010
    IL_0040: conv.r8
    IL_0041: IL_A4
    IL_0042: IL_01
    IL_0043: nop
    IL_0044: stloc.0
    IL_0045: ldloc.1
    IL_004A: ldstr 0x7000265F
    IL_004F: call 0x0A00013E
    IL_0050: conv.r8
    IL_0051: IL_A4
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0059: ldsfld 0x0A000099
    IL_005A: stloc.2
    IL_005B: ldarg.1
    IL_0060: ldsfld 0x0A000099
    IL_0065: call 0x0A0000EC
    IL_006A: brfalse IL_0076
    IL_006F: ldstr 0x70002667
    IL_0070: stloc.2
    IL_0075: br IL_0078
    IL_0076: ldarg.1
    IL_0077: stloc.2
    IL_0078: ldloc.1
    IL_007D: ldstr 0x7000263B
    IL_007E: ldloc.2
    IL_007F: conv.r8
    IL_0080: IL_A4
    IL_0081: IL_01
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldloc.1
    IL_0089: ldstr 0x7000266F
    IL_008E: ldstr 0x70000DDD
    IL_0093: call 0x06000220
    IL_0095: stloc.s 5
    IL_0097: ldloca.s 5
    IL_009C: call 0x0A000010
    IL_009D: conv.r8
    IL_009E: IL_A4
    IL_009F: IL_01
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: ldarg.0
    IL_00A7: call 0x06000322
    IL_00A8: stloc.3
    IL_00A9: ldloc.1
    IL_00AE: ldstr 0x7000267B
    IL_00B0: ldloca.s 3
    IL_00B5: call 0x0A000010
    IL_00B6: conv.r8
    IL_00B7: IL_A4
    IL_00B8: IL_01
    IL_00B9: nop
    IL_00BA: stloc.0
    IL_00BB: ldloc.1
    IL_00C0: ldstr 0x70002687
    IL_00C5: ldstr 0x70002687
    IL_00CA: call 0x06000222
    IL_00CB: conv.r8
    IL_00CC: IL_A4
    IL_00CD: IL_01
    IL_00CE: nop
    IL_00CF: stloc.0
    IL_00D0: ldloc.1
    IL_00D5: ldstr 0x7000269B
    IL_00DA: ldstr 0x7000269B
    IL_00DF: call 0x06000222
    IL_00E0: conv.r8
    IL_00E1: IL_A4
    IL_00E2: IL_01
    IL_00E3: nop
    IL_00E4: stloc.0
    IL_00E5: ldloc.1
    IL_00EA: ldstr 0x700026AB
    IL_00EF: ldstr 0x700026AB
    IL_00F4: call 0x06000222
    IL_00F5: conv.r8
    IL_00F6: IL_A4
    IL_00F7: IL_01
    IL_00F8: nop
    IL_00F9: stloc.0
    IL_00FA: ldarg.0
    IL_00FB: ldarg.0
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x040006D1
    IL_0106: ldstr 0x700026BF
    IL_010B: call 0x0A000011
    IL_010C: ldloc.1
    IL_0111: call 0x06000327
    IL_0116: call 0x0A000047
    IL_0117: pop
    IL_0118: ret
    }

    public void getRankList() {
    IL_0004: newobj 0x0A0001A3
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_000B: ldstr 0x7000262F
    IL_0010: ldc.i4 10001
    IL_0011: stloc.1
    IL_0013: ldloca.s 1
    IL_0018: call 0x0A000010
    IL_0019: conv.r8
    IL_001A: IL_A4
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldarg.0
    IL_001F: ldarg.0
    IL_0020: ldarg.0
    IL_0025: ldfld 0x040006D1
    IL_002A: ldstr 0x700026CF
    IL_002F: call 0x0A000011
    IL_0030: ldloc.0
    IL_0035: call 0x06000327
    IL_003A: call 0x0A000047
    IL_003B: pop
    IL_003C: ret
    }

    public void getOwnRanking() {
    IL_0004: newobj 0x0A0001A3
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_000B: ldstr 0x7000262F
    IL_0010: ldc.i4 10004
    IL_0011: stloc.1
    IL_0013: ldloca.s 1
    IL_0018: call 0x0A000010
    IL_0019: conv.r8
    IL_001A: IL_A4
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldloc.0
    IL_0023: ldstr 0x7000265F
    IL_0028: call 0x0A00013E
    IL_0029: conv.r8
    IL_002A: IL_A4
    IL_002B: IL_01
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x040006D1
    IL_003A: ldstr 0x700026DB
    IL_003F: call 0x0A000011
    IL_0040: ldloc.0
    IL_0045: call 0x06000327
    IL_004A: call 0x0A000047
    IL_004B: pop
    IL_004C: ret
    }

    private void getFight() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: ldstr 0x70000DDD
    IL_000B: call 0x06000220
    IL_000C: stloc.1
    IL_0011: ldstr 0x70000E0D
    IL_0016: call 0x06000220
    IL_0017: stloc.2
    IL_001C: ldstr 0x70000E25
    IL_0021: call 0x06000220
    IL_0022: stloc.3
    IL_0027: ldstr 0x70000E2D
    IL_002C: call 0x06000220
    IL_002E: stloc.s 4
    IL_0033: ldstr 0x70000E1D
    IL_0038: call 0x06000220
    IL_003A: stloc.s 5
    IL_003F: ldstr 0x70000E05
    IL_0044: call 0x06000220
    IL_0046: stloc.s 6
    IL_004B: ldstr 0x70000E15
    IL_0050: call 0x06000220
    IL_0052: stloc.s 7
    IL_0057: ldstr 0x70000DED
    IL_005C: call 0x06000220
    IL_005E: stloc.s 8
    IL_0063: ldstr 0x70000DF5
    IL_0068: call 0x06000220
    IL_006A: stloc.s 9
    IL_006F: ldstr 0x70000DFD
    IL_0074: call 0x06000220
    IL_0076: stloc.s 10
    IL_007B: ldstr 0x700026F3
    IL_0080: call 0x06000220
    IL_0082: stloc.s 11
    IL_0083: ldc.i4.0
    IL_0085: stloc.s 12
    IL_0086: ldc.i4.6
    IL_008B: newarr 0x0100000B
    IL_008C: dup
    IL_0091: ldtoken 0x040010B6
    IL_0096: call 0x0A00018C
    IL_0098: stloc.s 13
    IL_009D: ldstr 0x70000DCD
    IL_00A2: call 0x060003F9
    IL_00A4: stloc.s 14
    IL_00A5: ldc.i4.0
    IL_00A7: stloc.s 15
    IL_00AC: br IL_00C8
    IL_00AE: ldloc.s 14
    IL_00B0: ldloc.s 15
    IL_00B1: IL_94
    IL_00B2: ldc.i4.1
    IL_00DF: switch (10 cases)
    IL_00E0: ldarg.1
    IL_00E1: nop
    IL_00E2: ldloc.0
    IL_00E4: stloc.s 16
    IL_00E5: ldc.i4.0
    IL_00E7: stloc.s 17
    IL_00E8: ldc.i4.0
    IL_00EA: stloc.s 18
    IL_00EF: br IL_0119
    IL_00F1: ldloc.s 16
    IL_00F3: ldloc.s 18
    IL_00F4: IL_94
    IL_00F5: ldc.i4.0
    IL_00F6: IL_3F
    IL_00F7: ldc.i4.2
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: nop
    IL_00FC: ldloc.s 16
    IL_00FE: ldloc.s 18
    IL_00FF: IL_8F
    IL_0100: stloc.1
    IL_0101: nop
    IL_0102: nop
    IL_0103: IL_01
    IL_0104: dup
    IL_0107: stloc 22551
    IL_0108: IL_54
    IL_010A: ldloc.s 17
    IL_010C: ldloc.s 16
    IL_010E: ldloc.s 18
    IL_010F: IL_94
    IL_0110: IL_58
    IL_0112: stloc.s 17
    IL_0114: ldloc.s 18
    IL_0115: ldc.i4.1
    IL_0116: IL_58
    IL_0118: stloc.s 18
    IL_011A: ldloc.s 18
    IL_011C: ldloc.s 16
    IL_011D: len
    IL_011E: not
    IL_011F: IL_3F
    IL_0120: IL_CC
    IL_0121: IL_FF
    IL_0122: IL_FF
    IL_0123: IL_FF
    IL_0124: ldloc.1
    IL_0126: ldc.i4.s 25
    IL_0127: IL_5A
    IL_0128: ldloc.2
    IL_0129: ldloc.3
    IL_012A: IL_58
    IL_012C: ldloc.s 4
    IL_012D: IL_58
    IL_012F: ldloc.s 5
    IL_0130: IL_58
    IL_0132: ldloc.s 6
    IL_0133: IL_58
    IL_0135: ldloc.s 7
    IL_0136: IL_58
    IL_0138: ldc.i4.s 75
    IL_0139: IL_5A
    IL_013A: IL_58
    IL_013C: ldloc.s 8
    IL_013E: ldloc.s 9
    IL_013F: IL_58
    IL_0140: ldc.i4.2
    IL_0141: add
    IL_0143: ldc.i4.s 50
    IL_0144: IL_5A
    IL_0145: IL_58
    IL_0147: ldloc.s 10
    IL_0149: ldc.i4.s 100
    IL_014A: IL_5A
    IL_014C: ldc.i4.s 15
    IL_014D: IL_5A
    IL_014E: IL_58
    IL_0150: ldloc.s 11
    IL_0152: ldc.i4.s 35
    IL_0153: IL_5A
    IL_0154: IL_58
    IL_0156: ldloc.s 12
    IL_0158: ldc.i4.s 15
    IL_0159: IL_5A
    IL_015A: IL_58
    IL_015C: ldloc.s 17
    IL_015E: ldc.i4.s 70
    IL_015F: IL_5A
    IL_0160: IL_58
    IL_0161: stloc.0
    IL_0162: ldloc.0
    IL_0163: ret
    }

    public void getReward() {
    IL_0004: newobj 0x0A0001A3
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_000B: ldstr 0x7000262F
    IL_0010: ldc.i4 10005
    IL_0011: stloc.1
    IL_0013: ldloca.s 1
    IL_0018: call 0x0A000010
    IL_0019: conv.r8
    IL_001A: IL_A4
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldloc.0
    IL_0023: ldstr 0x7000265F
    IL_0028: call 0x0A00013E
    IL_0029: conv.r8
    IL_002A: IL_A4
    IL_002B: IL_01
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x040006D1
    IL_003A: ldstr 0x7000270B
    IL_003F: call 0x0A000011
    IL_0040: ldloc.0
    IL_0045: call 0x06000327
    IL_004A: call 0x0A000047
    IL_004B: pop
    IL_004C: ret
    }

    public void getFinalRanking() {
    IL_0004: newobj 0x0A0001A3
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_000B: ldstr 0x7000262F
    IL_0010: ldc.i4 10007
    IL_0011: stloc.1
    IL_0013: ldloca.s 1
    IL_0018: call 0x0A000010
    IL_0019: conv.r8
    IL_001A: IL_A4
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldloc.0
    IL_0023: ldstr 0x7000265F
    IL_0028: call 0x0A00013E
    IL_0029: conv.r8
    IL_002A: IL_A4
    IL_002B: IL_01
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x040006D1
    IL_003A: ldstr 0x7000271B
    IL_003F: call 0x0A000011
    IL_0040: ldloc.0
    IL_0045: call 0x06000327
    IL_004A: call 0x0A000047
    IL_004B: pop
    IL_004C: ret
    }

    public void bearThePalm() {
    IL_0004: newobj 0x0A0001A3
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_000B: ldstr 0x7000262F
    IL_0010: ldc.i4 10006
    IL_0011: stloc.1
    IL_0013: ldloca.s 1
    IL_0018: call 0x0A000010
    IL_0019: conv.r8
    IL_001A: IL_A4
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldloc.0
    IL_0023: ldstr 0x7000265F
    IL_0028: call 0x0A00013E
    IL_0029: conv.r8
    IL_002A: IL_A4
    IL_002B: IL_01
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x040006D1
    IL_003A: ldstr 0x70002737
    IL_003F: call 0x0A000011
    IL_0040: ldloc.0
    IL_0045: call 0x06000327
    IL_004A: call 0x0A000047
    IL_004B: pop
    IL_004C: ret
    }

    public void saveTelNumber() {
    IL_0004: newobj 0x0A0001A3
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_000B: ldstr 0x7000262F
    IL_0010: ldc.i4 10008
    IL_0011: stloc.1
    IL_0013: ldloca.s 1
    IL_0018: call 0x0A000010
    IL_0019: conv.r8
    IL_001A: IL_A4
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldloc.0
    IL_0023: ldstr 0x7000265F
    IL_0028: call 0x0A00013E
    IL_0029: conv.r8
    IL_002A: IL_A4
    IL_002B: IL_01
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldloc.0
    IL_0033: ldstr 0x7000263B
    IL_0034: ldarg.2
    IL_0035: conv.r8
    IL_0036: IL_A4
    IL_0037: IL_01
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: ldloc.0
    IL_003F: ldstr 0x70002751
    IL_0040: ldarg.1
    IL_0041: conv.r8
    IL_0042: IL_A4
    IL_0043: IL_01
    IL_0044: nop
    IL_0045: stloc.0
    IL_0046: ldarg.0
    IL_0047: ldarg.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x040006D1
    IL_0052: ldstr 0x70002765
    IL_0057: call 0x0A000011
    IL_0058: ldloc.0
    IL_005D: call 0x06000327
    IL_0062: call 0x0A000047
    IL_0063: pop
    IL_0064: ret
    }

    private void POST() {
    IL_0004: newobj 0x06000761
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.2
    IL_000C: stfld 0x04001036
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x04001039
    IL_0014: ldloc.0
    IL_0015: ldarg.2
    IL_001A: stfld 0x0400104B
    IL_001B: ldloc.0
    IL_001C: ldarg.1
    IL_0021: stfld 0x0400104C
    IL_0022: ldloc.0
    IL_0023: ldarg.0
    IL_0028: stfld 0x0400104D
    IL_0029: ldloc.0
    IL_002A: ret
    }

    private void errorParse() {
    IL_0000: ret
    }

    }}
