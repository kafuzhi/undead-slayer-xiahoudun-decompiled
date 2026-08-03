// Namespace: 
// Type: AndroidScript

    public class AndroidScript {{

    private static object _i;
    private object jcBI;

    public AndroidScript() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    public static void get_i() {
    IL_0004: ldsfld 0x0400011C
    IL_0005: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: stsfld 0x0400011C
    IL_000A: ldstr 0x7000045D
    IL_000F: ldstr 0x7000046D
    IL_0014: call 0x0A00008D
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_001B: ldstr 0x7000046D
    IL_001C: conv.r8
    IL_001D: len
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: brtrue IL_0035
    IL_002A: ldstr 0x7000045D
    IL_002F: ldstr 0x70000477
    IL_0034: call 0x0A00008F
    IL_0035: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_000A: call 0x0A000090
    IL_000B: ldarg.0
    IL_0010: ldstr 0x7000047F
    IL_0015: newobj 0x0A000091
    IL_001A: stfld 0x0400011D
    IL_001B: ret
    }

    private void Update() {
    IL_0001: ldc.i4.s 27
    IL_0006: call 0x0A000092
    IL_000B: brfalse IL_0117
    IL_0010: call 0x0A000093
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_001E: switch (1 cases)
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: brtrue IL_0027
    IL_0026: ret
    IL_002B: ldstr 0x700004AB
    IL_0030: call 0x0A000095
    IL_0031: stloc.0
    IL_0032: ldc.i4.0
    IL_0033: stloc.1
    IL_0034: ldc.i4.0
    IL_0035: stloc.2
    IL_003A: ldstr 0x700004B9
    IL_003B: stloc.3
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_009A: switch (22 cases)
    IL_009B: nop
    IL_009C: nop
    IL_009D: ldloc.0
    IL_009E: ldloc.3
    IL_00A0: ldloc.s 4
    IL_00A1: conv.r8
    IL_00A2: IL_59
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: ldloc.0
    IL_00AA: ldstr 0x7000045D
    IL_00AF: call 0x0A000097
    IL_00B1: stloc.s 5
    IL_00B3: ldloc.s 5
    IL_00B8: ldstr 0x70000477
    IL_00B9: conv.r8
    IL_00BA: len
    IL_00BB: nop
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00C2: brtrue IL_00EF
    IL_00C7: ldstr 0x70000507
    IL_00C9: stloc.s 6
    IL_00CE: ldstr 0x7000051B
    IL_00CF: ldloc.1
    IL_00D4: newobj 0x0100000B
    IL_00D9: ldstr 0x70000503
    IL_00DE: call 0x0A000098
    IL_00E0: stloc.s 7
    IL_00E5: call 0x0600004E
    IL_00E7: ldloc.s 6
    IL_00E9: ldloc.s 7
    IL_00EA: conv.r8
    IL_00EB: IL_59
    IL_00EC: nop
    IL_00ED: nop
    IL_00EE: ldloc.0
    IL_00EF: ldarg.0
    IL_00F0: ldloc.2
    IL_00F5: newobj 0x0100000B
    IL_00FA: ldsfld 0x0A000099
    IL_00FF: call 0x0A00009A
    IL_0100: ldloc.1
    IL_0105: newobj 0x0100000B
    IL_010A: ldsfld 0x0A000099
    IL_010F: call 0x0A00009A
    IL_0111: ldloc.s 5
    IL_0116: call 0x0600005A
    IL_011B: ldstr 0x7000052B
    IL_0120: call 0x0A000095
    IL_0122: stloc.s 8
    IL_0127: ldstr 0x70000541
    IL_012C: call 0x0A000095
    IL_012E: stloc.s 9
    IL_0130: ldloc.s 8
    IL_0131: ldc.i4.1
    IL_0156: switch (8 cases)
    }

    private void PayCallBack() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: conv.r8
    IL_0004: ldelem.i1
    IL_0005: nop
    IL_0006: nop
    IL_0007: stloc.0
    IL_0008: ldc.i4.2
    IL_0009: IL_59
    IL_000A: conv.r8
    IL_000B: ldelem.i2
    IL_000C: nop
    IL_000D: nop
    IL_000E: stloc.0
    IL_000F: stloc.0
    IL_0010: ldloc.0
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x0100002A
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_001A: ldc.i4.s 44
    IL_001B: ldelem.i4
    IL_001C: conv.r8
    IL_001D: ldelem.i4
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: stloc.1
    IL_0022: ldloc.1
    IL_0023: ldc.i4.0
    IL_0024: ldelem.i
    IL_0025: stloc.2
    IL_0026: ldloc.2
    IL_0027: ldc.i4.1
    IL_002C: newarr 0x0100002A
    IL_002D: dup
    IL_002E: ldc.i4.0
    IL_0030: ldc.i4.s 58
    IL_0031: ldelem.i4
    IL_0032: conv.r8
    IL_0033: ldelem.i4
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: stloc.3
    IL_0038: ldloc.3
    IL_0039: ldc.i4.1
    IL_003A: ldelem.i
    IL_003B: ldc.i4.1
    IL_003C: ldloc.3
    IL_003D: ldc.i4.1
    IL_003E: ldelem.i
    IL_003F: conv.r8
    IL_0040: ldelem.i1
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldc.i4.2
    IL_0045: IL_59
    IL_0046: conv.r8
    IL_0047: ldelem.i2
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004F: call 0x0A00009E
    IL_0051: stloc.s 4
    IL_0052: ldloc.1
    IL_0053: ldc.i4.2
    IL_0054: ldelem.i
    IL_0056: stloc.s 5
    IL_0058: ldloc.s 5
    IL_0059: ldc.i4.1
    IL_005E: newarr 0x0100002A
    IL_005F: dup
    IL_0060: ldc.i4.0
    IL_0062: ldc.i4.s 58
    IL_0063: ldelem.i4
    IL_0064: conv.r8
    IL_0065: ldelem.i4
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_006A: stloc.s 6
    IL_006C: ldloc.s 6
    IL_006D: ldc.i4.1
    IL_006E: ldelem.i
    IL_006F: ldc.i4.1
    IL_0071: ldloc.s 6
    IL_0072: ldc.i4.1
    IL_0073: ldelem.i
    IL_0074: conv.r8
    IL_0075: ldelem.i1
    IL_0076: nop
    IL_0077: nop
    IL_0078: stloc.0
    IL_0079: ldc.i4.2
    IL_007A: IL_59
    IL_007B: conv.r8
    IL_007C: ldelem.i2
    IL_007D: nop
    IL_007E: nop
    IL_007F: stloc.0
    IL_0084: call 0x0A00009E
    IL_0086: stloc.s 7
    IL_0088: ldloc.s 4
    IL_0089: ldc.i4.1
    IL_0296: switch (130 cases)
    }

    public void StartRedeemService() {
    IL_0004: ldstr 0x7000058D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x700005B3
    IL_0011: ldc.i4.0
    IL_0016: newarr 0x01000020
    IL_0017: conv.r8
    IL_0018: ldelem.r8
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_DD
    IL_001D: stloc.3
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0026: brfalse IL_002D
    IL_0027: ldloc.0
    IL_0028: conv.r8
    IL_0029: ldelem.ref
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: IL_DC
    IL_002E: ret
    }

    public void StartFeedBack() {
    IL_0004: ldstr 0x700005C7
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70000605
    IL_0011: ldc.i4.0
    IL_0016: newarr 0x01000020
    IL_0017: conv.r8
    IL_0018: ldelem.r8
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_DD
    IL_001D: stloc.3
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0026: brfalse IL_002D
    IL_0027: ldloc.0
    IL_0028: conv.r8
    IL_0029: ldelem.ref
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: IL_DC
    IL_002E: ret
    }

    public void jumpSence() {
    IL_0004: ldtoken 0x02000116
    IL_0009: call 0x0A0000A2
    IL_000E: call 0x0A0000A3
    IL_000F: conv.u4
    IL_0010: ldc.i4.0
    IL_0011: IL_01
    IL_0012: nop
    IL_0013: ldarg.0
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_001A: call 0x0A00004A
    IL_001F: brfalse IL_0026
    IL_0020: ldloc.0
    IL_0021: conv.r8
    IL_0022: div
    IL_0023: ldloc.0
    IL_0024: nop
    IL_0025: ldloc.0
    IL_0026: ldarg.1
    IL_002B: call 0x0A00009E
    IL_002C: stloc.1
    IL_0031: ldstr 0x70000617
    IL_0036: call 0x0A000095
    IL_0037: stloc.2
    IL_003C: ldstr 0x70000631
    IL_003D: ldc.i4.1
    IL_0042: call 0x0A00009F
    IL_0043: ldloc.2
    IL_0048: brtrue IL_0075
    IL_004D: ldtoken 0x02000119
    IL_0052: call 0x0A0000A2
    IL_0057: call 0x0A0000A3
    IL_0058: conv.u4
    IL_0059: ldc.i4.3
    IL_005A: IL_01
    IL_005B: nop
    IL_005C: ldarg.0
    IL_005D: stloc.3
    IL_005E: ldloc.3
    IL_0063: call 0x0A00004A
    IL_0068: brfalse IL_0070
    IL_0069: ldloc.3
    IL_006A: ldloc.1
    IL_006B: conv.r8
    IL_0070: newobj 0x38060006
    IL_0071: IL_AB
    IL_0072: IL_01
    IL_0073: nop
    IL_0074: nop
    IL_0075: ldloc.2
    IL_0076: ldc.i4.1
    IL_0137: switch (47 cases)
    IL_0138: nop
    IL_0139: nop
    IL_013A: stloc.0
    IL_013F: brfalse IL_0148
    IL_0141: ldloc.s 7
    IL_0142: ldloc.1
    IL_0143: conv.r8
    IL_0144: IL_50
    IL_0145: ldloc.0
    IL_0146: nop
    IL_0147: ldloc.0
    IL_014C: br IL_0220
    IL_014D: ldloc.2
    IL_014E: ldc.i4.5
    IL_020F: switch (47 cases)
    IL_0210: nop
    IL_0211: nop
    IL_0212: stloc.0
    IL_0217: brfalse IL_0220
    IL_0219: ldloc.s 11
    IL_021A: ldloc.1
    IL_021B: conv.r8
    IL_021C: IL_83
    IL_021D: ldloc.0
    IL_021E: nop
    IL_021F: ldloc.0
    IL_0220: ret
    }

    public void RedeemFeedbackSuc() {
    IL_0000: ldarg.1
    IL_0005: call 0x0A00009E
    IL_0006: stloc.0
    IL_0007: ldc.i4.0
    IL_0008: stloc.1
    IL_0009: ldc.i4.0
    IL_000A: stloc.2
    IL_000B: ldc.i4.0
    IL_000C: stloc.3
    IL_000D: ldc.i4.0
    IL_000F: stloc.s 4
    IL_0010: ldc.i4.0
    IL_0012: stloc.s 5
    IL_0013: ldloc.0
    IL_0015: stloc.s 13
    IL_0017: ldloc.s 13
    IL_001C: ldc.i4 10001
    IL_001D: IL_59
    IL_0020: ldarg 16
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_96
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: IL_A4
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_B2
    IL_002C: nop
    IL_002D: nop
    IL_002E: nop
    IL_002F: IL_C0
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0037: ldtoken 0xE1000000
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0043: IL_4D
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_55
    IL_0060: nop
    IL_0061: nop
    IL_0062: nop
    IL_0064: ldloc.s 13
    IL_0069: ldc.i4 10036
    IL_006E: beq IL_00C0
    IL_0070: ldloc.s 13
    IL_0075: ldc.i4 10060
    IL_007A: beq IL_00C8
    IL_007C: ldloc.s 13
    IL_0081: ldc.i4 10120
    IL_0086: beq IL_00D0
    IL_0088: ldloc.s 13
    IL_008D: ldc.i4 10200
    IL_0092: beq IL_00D8
    IL_0094: ldloc.s 13
    IL_0099: ldc.i4 10360
    IL_009E: beq IL_00E3
    IL_00A0: ldloc.s 13
    IL_00A5: ldc.i4 10900
    IL_00AA: beq IL_00EE
    IL_00AF: br IL_01B3
    IL_00B1: ldc.i4.s 9
    IL_00B2: stloc.1
    IL_00B7: br IL_01B3
    IL_00B9: ldc.i4.s 16
    IL_00BA: stloc.1
    IL_00BF: br IL_01B3
    IL_00C1: ldc.i4.s 36
    IL_00C2: stloc.1
    IL_00C7: br IL_01B3
    IL_00C9: ldc.i4.s 60
    IL_00CA: stloc.1
    IL_00CF: br IL_01B3
    IL_00D1: ldc.i4.s 120
    IL_00D2: stloc.1
    IL_00D7: br IL_01B3
    IL_00DC: ldc.i4 200
    IL_00DD: stloc.1
    IL_00E2: br IL_01B3
    IL_00E7: ldc.i4 360
    IL_00E8: stloc.1
    IL_00ED: br IL_01B3
    IL_00F2: ldc.i4 900
    IL_00F3: stloc.1
    IL_00F8: br IL_01B3
    IL_00F9: ldc.i4.1
    IL_00FB: stloc.s 5
    IL_0100: ldc.i4 2100
    IL_0101: stloc.2
    IL_0106: br IL_01B3
    IL_0107: ldc.i4.1
    IL_0109: stloc.s 5
    IL_010E: ldc.i4 4300
    IL_010F: stloc.2
    IL_0114: br IL_01B3
    IL_0115: ldc.i4.1
    IL_0117: stloc.s 5
    IL_011C: ldc.i4 8700
    IL_011D: stloc.2
    IL_0122: br IL_01B3
    IL_0123: ldc.i4.1
    IL_0125: stloc.s 5
    IL_012A: ldc.i4 1000
    IL_012B: stloc.2
    IL_012C: ldc.i4.1
    IL_012D: stloc.3
    IL_0132: br IL_01B3
    IL_0133: ldc.i4.1
    IL_0135: stloc.s 5
    IL_013A: ldc.i4 1000
    IL_013B: stloc.2
    IL_013C: ldc.i4.1
    IL_013E: stloc.s 4
    IL_0143: br IL_01B3
    IL_0145: ldc.i4.s 20
    IL_014A: newarr 0x0100000B
    IL_014C: stloc.s 6
    IL_0151: ldstr 0x7000054F
    IL_0156: call 0x060003F9
    IL_0158: stloc.s 6
    IL_015A: ldloc.s 6
    IL_015C: ldc.i4.s 14
    IL_015D: IL_94
    IL_015F: stloc.s 7
    IL_0161: ldloc.s 7
    IL_0162: ldc.i4.0
    IL_0163: IL_3F
    IL_0165: ldloc.s 0
    IL_0166: nop
    IL_0167: nop
    IL_016C: ldc.i4 10000
    IL_016D: ldc.i4.0
    IL_0172: call 0x0600021E
    IL_0173: pop
    IL_0178: br IL_01A3
    IL_017A: ldloc.s 6
    IL_017C: ldc.i4.s 14
    IL_017D: ldc.i4.0
    IL_017E: ldelem.i8
    IL_0183: ldstr 0x7000054F
    IL_0185: ldloc.s 6
    IL_018A: call 0x060003F8
    IL_018B: pop
    IL_0190: ldstr 0x7000052B
    IL_0191: ldc.i4.1
    IL_0196: call 0x0A00009F
    IL_019B: ldc.i4 8000
    IL_019C: ldc.i4.0
    IL_01A1: call 0x0600021E
    IL_01A2: pop
    IL_01A7: ldstr 0x70000557
    IL_01A8: ldc.i4.1
    IL_01AD: call 0x0A00009F
    IL_01B2: br IL_01B3
    IL_01B3: ldloc.1
    IL_01B4: ldc.i4.0
    IL_01B5: IL_3E
    IL_01B7: stloc.s 0
    IL_01B8: nop
    IL_01B9: nop
    IL_01BA: ldloc.1
    IL_01BB: ldc.i4.1
    IL_01C0: call 0x0600021E
    IL_01C1: pop
    IL_01C6: ldstr 0x7000064F
    IL_01C7: ldc.i4.1
    IL_01CC: call 0x0A00009F
    IL_01CE: ldloc.s 5
    IL_01D3: brfalse IL_01E7
    IL_01D4: ldloc.2
    IL_01D5: ldc.i4.0
    IL_01DA: call 0x0600021E
    IL_01DB: pop
    IL_01E0: ldstr 0x7000064F
    IL_01E1: ldc.i4.1
    IL_01E6: call 0x0A00009F
    IL_01E7: ldloc.3
    IL_01EC: brfalse IL_0268
    IL_01F1: ldstr 0x70000667
    IL_01F6: call 0x060003F9
    IL_01F8: stloc.s 8
    IL_01F9: ldc.i4.0
    IL_01FB: ldc.i4.s 100
    IL_0200: call 0x0A000045
    IL_0202: stloc.s 9
    IL_0203: ldc.i4.0
    IL_0205: stloc.s 10
    IL_0207: ldloc.s 9
    IL_0209: ldc.i4.s 96
    IL_020A: IL_3E
    IL_020B: ldloc.2
    IL_020C: nop
    IL_020D: nop
    IL_020E: nop
    IL_020F: ldc.i4.4
    IL_0211: stloc.s 10
    IL_0216: br IL_024D
    IL_0218: ldloc.s 9
    IL_021A: ldc.i4.s 88
    IL_021B: IL_3E
    IL_021C: ldloc.2
    IL_021D: nop
    IL_021E: nop
    IL_021F: nop
    IL_0220: ldc.i4.3
    IL_0222: stloc.s 10
    IL_0227: br IL_024D
    IL_0229: ldloc.s 9
    IL_022B: ldc.i4.s 68
    IL_022C: IL_3E
    IL_022D: ldloc.2
    IL_022E: nop
    IL_022F: nop
    IL_0230: nop
    IL_0231: ldc.i4.2
    IL_0233: stloc.s 10
    IL_0238: br IL_024D
    IL_023A: ldloc.s 9
    IL_023C: ldc.i4.s 40
    IL_023D: IL_3E
    IL_023E: ldloc.2
    IL_023F: nop
    IL_0240: nop
    IL_0241: nop
    IL_0242: ldc.i4.1
    IL_0244: stloc.s 10
    IL_0249: br IL_024D
    IL_024A: ldc.i4.0
    IL_024C: stloc.s 10
    IL_024E: ldloc.s 8
    IL_0250: ldloc.s 10
    IL_0251: IL_8F
    IL_0252: stloc.1
    IL_0253: nop
    IL_0254: nop
    IL_0255: IL_01
    IL_0256: dup
    IL_0259: stloc 22551
    IL_025A: IL_54
    IL_025F: ldstr 0x70000667
    IL_0261: ldloc.s 8
    IL_0266: call 0x060003F8
    IL_0267: pop
    IL_0269: ldloc.s 4
    IL_026E: brfalse IL_028D
    IL_0273: ldstr 0x7000066F
    IL_0278: call 0x06000220
    IL_027A: stloc.s 11
    IL_027C: ldloc.s 11
    IL_027D: ldc.i4.1
    IL_027E: IL_58
    IL_0280: stloc.s 11
    IL_0285: ldstr 0x7000066F
    IL_0287: ldloc.s 11
    IL_028C: call 0x0600021F
    IL_0291: ldstr 0x7000058D
    IL_0296: newobj 0x0A000091
    IL_0298: stloc.s 12
    IL_029A: ldloc.s 12
    IL_029F: ldstr 0x70000677
    IL_02A0: ldc.i4.1
    IL_02A5: newarr 0x01000020
    IL_02A6: dup
    IL_02A7: ldc.i4.0
    IL_02A8: ldc.i4.1
    IL_02AD: newobj 0x01000013
    IL_02B2: stelem 0x0000A06F
    IL_02B3: stloc.0
    IL_02B4: IL_DD
    IL_02B6: ldarga.s 0
    IL_02B7: nop
    IL_02B8: nop
    IL_02BA: ldloc.s 12
    IL_02BF: brfalse IL_02C7
    IL_02C1: ldloc.s 12
    IL_02C2: conv.r8
    IL_02C3: ldelem.ref
    IL_02C4: nop
    IL_02C5: nop
    IL_02C6: stloc.0
    IL_02C7: IL_DC
    IL_02C8: ret
    }

    public void RedeemFeedbackFail() {
    IL_0004: ldstr 0x7000058D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70000677
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x01000020
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_0019: ldc.i4.0
    IL_001E: newobj 0x01000013
    IL_0023: stelem 0x0000A06F
    IL_0024: stloc.0
    IL_0025: IL_DD
    IL_0026: stloc.3
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002A: ldloc.0
    IL_002F: brfalse IL_0036
    IL_0030: ldloc.0
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public void LogEvent() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400011D
    IL_000A: ldstr 0x70000689
    IL_000B: ldc.i4.1
    IL_0010: newarr 0x01000020
    IL_0011: dup
    IL_0012: ldc.i4.0
    IL_0013: ldarg.1
    IL_0018: stelem 0x0000A06F
    IL_0019: stloc.0
    IL_001A: ret
    }

    public void LogEvent() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400011D
    IL_000A: ldstr 0x70000689
    IL_000B: ldc.i4.2
    IL_0010: newarr 0x01000020
    IL_0011: dup
    IL_0012: ldc.i4.0
    IL_0013: ldarg.1
    IL_0018: stelem 0xA2041725
    IL_0019: conv.r8
    IL_001A: ldelem.r8
    IL_001B: nop
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ret
    }

    public void QuitGame() {
    IL_0004: call 0x060001EF
    IL_0005: conv.r8
    IL_0006: IL_F2
    IL_0007: IL_01
    IL_0008: nop
    IL_0009: ldloc.0
    IL_000E: brfalse IL_004E
    IL_0013: ldstr 0x7000069B
    IL_0018: newobj 0x0A000091
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001F: ldstr 0x700006D3
    IL_0020: ldc.i4.3
    IL_0025: newarr 0x01000020
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_0028: ldarg.1
    IL_002D: stelem 0xA2041725
    IL_002E: dup
    IL_002F: ldc.i4.2
    IL_0030: ldarg.3
    IL_0035: stelem 0x0000A06F
    IL_0036: stloc.0
    IL_0037: IL_DD
    IL_0038: stloc.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: ldloc.0
    IL_0041: brfalse IL_0048
    IL_0042: ldloc.0
    IL_0043: conv.r8
    IL_0044: ldelem.ref
    IL_0045: nop
    IL_0046: nop
    IL_0047: stloc.0
    IL_0048: IL_DC
    IL_004D: br IL_0088
    IL_0052: ldstr 0x700005C7
    IL_0057: newobj 0x0A000091
    IL_0058: stloc.1
    IL_0059: ldloc.1
    IL_005E: ldstr 0x700006D3
    IL_005F: ldc.i4.3
    IL_0064: newarr 0x01000020
    IL_0065: dup
    IL_0066: ldc.i4.0
    IL_0067: ldarg.1
    IL_006C: stelem 0xA2041725
    IL_006D: dup
    IL_006E: ldc.i4.2
    IL_006F: ldarg.3
    IL_0074: stelem 0x0000A06F
    IL_0075: stloc.0
    IL_0076: IL_DD
    IL_0077: stloc.3
    IL_0078: nop
    IL_0079: nop
    IL_007A: nop
    IL_007B: ldloc.1
    IL_0080: brfalse IL_0087
    IL_0081: ldloc.1
    IL_0082: conv.r8
    IL_0083: ldelem.ref
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_0087: IL_DC
    IL_008C: ldstr 0x7000045D
    IL_0091: call 0x0A000097
    IL_0092: stloc.2
    IL_0093: ldloc.2
    IL_0098: ldstr 0x70000477
    IL_0099: conv.r8
    IL_009A: len
    IL_009B: nop
    IL_009C: nop
    IL_009D: stloc.0
    IL_00A2: brtrue IL_00B2
    IL_00A7: ldstr 0x7000045D
    IL_00AC: ldstr 0x700006E5
    IL_00B1: call 0x0A00008F
    IL_00B2: ret
    }

    public void MoreGames() {
    IL_0004: call 0x060001EF
    IL_0005: conv.r8
    IL_0006: IL_F1
    IL_0007: IL_01
    IL_0008: nop
    IL_0009: ldloc.0
    IL_000E: brfalse IL_003D
    IL_0013: ldstr 0x700006EB
    IL_0018: newobj 0x0A000091
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001F: ldstr 0x7000070D
    IL_0020: ldc.i4.0
    IL_0025: newarr 0x01000020
    IL_0026: conv.r8
    IL_0027: ldelem.r8
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: IL_DD
    IL_002C: stloc.3
    IL_002D: nop
    IL_002E: nop
    IL_002F: nop
    IL_0030: ldloc.0
    IL_0035: brfalse IL_003C
    IL_0036: ldloc.0
    IL_0037: conv.r8
    IL_0038: ldelem.ref
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_003C: IL_DC
    IL_0041: call 0x060001EF
    IL_0042: conv.r8
    IL_0043: IL_F2
    IL_0044: IL_01
    IL_0045: nop
    IL_0046: ldloc.0
    IL_004B: brfalse IL_007A
    IL_0050: ldstr 0x7000069B
    IL_0055: newobj 0x0A000091
    IL_0056: stloc.1
    IL_0057: ldloc.1
    IL_005C: ldstr 0x7000070D
    IL_005D: ldc.i4.0
    IL_0062: newarr 0x01000020
    IL_0063: conv.r8
    IL_0064: ldelem.r8
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: IL_DD
    IL_0069: stloc.3
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: ldloc.1
    IL_0072: brfalse IL_0079
    IL_0073: ldloc.1
    IL_0074: conv.r8
    IL_0075: ldelem.ref
    IL_0076: nop
    IL_0077: nop
    IL_0078: stloc.0
    IL_0079: IL_DC
    IL_007A: ret
    }

    public void changeLoginState() {
    IL_0004: ldstr 0x7000045D
    IL_0009: ldstr 0x700006E5
    IL_000E: call 0x0A00008F
    IL_0013: ldstr 0x7000045D
    IL_0018: call 0x0A000097
    IL_0019: stloc.0
    IL_001A: ret
    }

    public void loginQihoo() {
    IL_0004: ldstr 0x7000071F
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x7000074D
    IL_0011: ldc.i4.0
    IL_0016: newarr 0x01000020
    IL_0017: conv.r8
    IL_0018: ldelem.r8
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_DD
    IL_001D: stloc.3
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0026: brfalse IL_002D
    IL_0027: ldloc.0
    IL_0028: conv.r8
    IL_0029: ldelem.ref
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: IL_DC
    IL_002E: ret
    }

    public void isScreenLocked() {
    IL_0004: ldstr 0x700005C7
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70000767
    IL_0011: ldc.i4.0
    IL_0016: newarr 0x01000020
    IL_0017: conv.r8
    IL_0018: ldnull
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_0028
    IL_001D: IL_DD
    IL_001F: ldloca.s 0
    IL_0020: nop
    IL_0021: nop
    IL_0022: IL_DD
    IL_0023: stloc.3
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: ldloc.0
    IL_002C: brfalse IL_0033
    IL_002D: ldloc.0
    IL_002E: conv.r8
    IL_002F: ldelem.ref
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: IL_DC
    IL_0034: ldloc.1
    IL_0035: ret
    }

    public void MusicEnabled() {
    IL_0004: call 0x060001EF
    IL_0005: conv.r8
    IL_0006: IL_F1
    IL_0007: IL_01
    IL_0008: nop
    IL_0009: ldloc.0
    IL_000E: brfalse IL_0043
    IL_0013: ldstr 0x700006EB
    IL_0018: newobj 0x0A000091
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001F: ldstr 0x70000785
    IL_0020: ldc.i4.0
    IL_0025: newarr 0x01000020
    IL_0026: conv.r8
    IL_0027: ldnull
    IL_0028: nop
    IL_0029: nop
    IL_002B: br.s IL_0037
    IL_002C: IL_DD
    IL_002D: ldnull
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0031: IL_DD
    IL_0032: stloc.3
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: ldloc.0
    IL_003B: brfalse IL_0042
    IL_003C: ldloc.0
    IL_003D: conv.r8
    IL_003E: ldelem.ref
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: IL_DC
    IL_0043: ldc.i4.1
    IL_0044: ret
    IL_0045: ldloc.1
    IL_0046: ret
    }

    public void onPause() {
    IL_0004: ldstr 0x700005C7
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x7000079F
    IL_0011: ldc.i4.0
    IL_0016: newarr 0x01000020
    IL_0017: conv.r8
    IL_0018: ldelem.r8
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_DD
    IL_001D: stloc.3
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0026: brfalse IL_002D
    IL_0027: ldloc.0
    IL_0028: conv.r8
    IL_0029: ldelem.ref
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: IL_DC
    IL_002E: ret
    }

    public void SetPushOnOff() {
    IL_0004: ldstr 0x700007AF
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x700007E3
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x01000020
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_0019: ldarg.1
    IL_001E: newobj 0x01000013
    IL_0023: stelem 0x0000A06F
    IL_0024: stloc.0
    IL_0025: IL_DD
    IL_0026: stloc.3
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002A: ldloc.0
    IL_002F: brfalse IL_0036
    IL_0030: ldloc.0
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public void pay() {
    IL_0001: ldc.i4.s 21
    IL_0006: newarr 0x01000020
    IL_0007: dup
    IL_0008: ldc.i4.0
    IL_000D: ldstr 0x700007FB
    IL_0012: stelem 0xA2031725
    IL_0013: dup
    IL_0014: ldc.i4.2
    IL_0019: ldstr 0x7000080F
    IL_001E: stelem 0xA2041925
    IL_001F: dup
    IL_0020: ldc.i4.4
    IL_0025: ldstr 0x70000821
    IL_002A: stelem 0x8C051B25
    IL_002C: bge.s IL_002D
    IL_002D: nop
    IL_002E: IL_01
    IL_0033: stelem 0x35721C25
    IL_0034: ldloc.2
    IL_0035: nop
    IL_003A: cpobj 0x0E1D25A2
    IL_003B: ldarg.2
    IL_0040: newobj 0x0100000B
    IL_0045: stelem 0x45721E25
    IL_0046: ldloc.2
    IL_0047: nop
    IL_004C: cpobj 0x091F25A2
    IL_004E: ldarg.s 5
    IL_0053: stelem 0x720A1F25
    IL_0054: mul
    IL_0055: ldloc.2
    IL_0056: nop
    IL_005B: cpobj 0x0B1F25A2
    IL_005D: ldarg.s 6
    IL_0062: stelem 0x720C1F25
    IL_0067: ldobj 0xA2700008
    IL_0068: dup
    IL_006A: ldc.i4.s 13
    IL_006C: ldarg.s 7
    IL_0071: stelem 0x720E1F25
    IL_0072: IL_85
    IL_0073: ldloc.2
    IL_0074: nop
    IL_0079: cpobj 0x0F1F25A2
    IL_007B: ldarg.s 8
    IL_0080: stelem 0x72101F25
    IL_0081: IL_99
    IL_0082: ldloc.2
    IL_0083: nop
    IL_0088: cpobj 0x111F25A2
    IL_008A: ldarg.s 9
    IL_008F: stelem 0x72121F25
    IL_0090: IL_AF
    IL_0091: ldloc.2
    IL_0092: nop
    IL_0097: cpobj 0x131F25A2
    IL_0099: ldarg.s 10
    IL_009E: stelem 0x72141F25
    IL_009F: ldarg.1
    IL_00A0: ldarg.3
    IL_00A1: nop
    IL_00A6: cpobj 0x009628A2
    IL_00A7: nop
    IL_00A8: stloc.0
    IL_00A9: stloc.0
    IL_00AE: ldstr 0x700008CB
    IL_00B3: newobj 0x0A000091
    IL_00B4: stloc.1
    IL_00B5: ldloc.1
    IL_00BA: ldstr 0x70000925
    IL_00BB: ldc.i4.1
    IL_00C0: newarr 0x01000020
    IL_00C1: dup
    IL_00C2: ldc.i4.0
    IL_00C3: ldloc.0
    IL_00C8: stelem 0x0000A06F
    IL_00C9: stloc.0
    IL_00CA: IL_DD
    IL_00CB: stloc.3
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: ldloc.1
    IL_00D4: brfalse IL_00DB
    IL_00D5: ldloc.1
    IL_00D6: conv.r8
    IL_00D7: ldelem.ref
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: stloc.0
    IL_00DB: IL_DC
    IL_00DC: ret
    }

    public void loadWDJAds() {
    IL_0004: ldstr 0x7000092D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70000963
    IL_0011: ldc.i4.0
    IL_0016: newarr 0x01000020
    IL_0017: conv.r8
    IL_0018: ldelem.r8
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_DD
    IL_001D: stloc.3
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0026: brfalse IL_002D
    IL_0027: ldloc.0
    IL_0028: conv.r8
    IL_0029: ldelem.ref
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: IL_DC
    IL_002E: ret
    }

    public void showNotice() {
    IL_0004: ldstr 0x700005C7
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70000985
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x01000020
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_0019: ldarg.1
    IL_001E: stelem 0x0000A06F
    IL_001F: stloc.0
    IL_0020: IL_DD
    IL_0021: stloc.3
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0025: ldloc.0
    IL_002A: brfalse IL_0031
    IL_002B: ldloc.0
    IL_002C: conv.r8
    IL_002D: ldelem.ref
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: IL_DC
    IL_0032: ret
    }

    public void getDeviceId() {
    IL_0004: ldstr 0x700005C7
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x7000099B
    IL_0011: ldc.i4.0
    IL_0016: newarr 0x01000020
    IL_0017: conv.r8
    IL_0018: ldc.i4.m1
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_0028
    IL_001D: IL_DD
    IL_001F: ldloca.s 0
    IL_0020: nop
    IL_0021: nop
    IL_0022: IL_DD
    IL_0023: stloc.3
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: ldloc.0
    IL_002C: brfalse IL_0033
    IL_002D: ldloc.0
    IL_002E: conv.r8
    IL_002F: ldelem.ref
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: IL_DC
    IL_0034: ldloc.1
    IL_0035: ret
    }

    public void showCCPlay() {
    IL_0004: call 0x060001EF
    IL_0005: conv.r8
    IL_0006: IL_F5
    IL_0007: IL_01
    IL_0008: nop
    IL_0009: ldloc.0
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x700009B3
    IL_0015: call 0x0A0000A6
    IL_001A: brfalse IL_0079
    IL_001B: ldloc.0
    IL_0020: ldstr 0x700009C1
    IL_0025: call 0x0A0000A6
    IL_002A: brfalse IL_0079
    IL_002B: ldloc.0
    IL_0030: ldstr 0x700009CF
    IL_0035: call 0x0A0000A6
    IL_003A: brfalse IL_0079
    IL_003B: ldloc.0
    IL_0040: ldstr 0x700009DD
    IL_0045: call 0x0A0000A6
    IL_004A: brfalse IL_0079
    IL_004F: ldstr 0x700005C7
    IL_0054: newobj 0x0A000091
    IL_0055: stloc.1
    IL_0056: ldloc.1
    IL_005B: ldstr 0x700009EB
    IL_005C: ldc.i4.0
    IL_0061: newarr 0x01000020
    IL_0062: conv.r8
    IL_0063: ldelem.r8
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: IL_DD
    IL_0068: stloc.3
    IL_0069: nop
    IL_006A: nop
    IL_006B: nop
    IL_006C: ldloc.1
    IL_0071: brfalse IL_0078
    IL_0072: ldloc.1
    IL_0073: conv.r8
    IL_0074: ldelem.ref
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: IL_DC
    IL_0079: ret
    }

    public void showCCPlayAndForce() {
    IL_0004: call 0x060001EF
    IL_0005: conv.r8
    IL_0006: IL_F5
    IL_0007: IL_01
    IL_0008: nop
    IL_0009: ldloc.0
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x700009B3
    IL_0015: call 0x0A0000A6
    IL_001A: brfalse IL_0079
    IL_001B: ldloc.0
    IL_0020: ldstr 0x700009C1
    IL_0025: call 0x0A0000A6
    IL_002A: brfalse IL_0079
    IL_002B: ldloc.0
    IL_0030: ldstr 0x700009CF
    IL_0035: call 0x0A0000A6
    IL_003A: brfalse IL_0079
    IL_003B: ldloc.0
    IL_0040: ldstr 0x700009DD
    IL_0045: call 0x0A0000A6
    IL_004A: brfalse IL_0079
    IL_004F: ldstr 0x700005C7
    IL_0054: newobj 0x0A000091
    IL_0055: stloc.1
    IL_0056: ldloc.1
    IL_005B: ldstr 0x70000A01
    IL_005C: ldc.i4.0
    IL_0061: newarr 0x01000020
    IL_0062: conv.r8
    IL_0063: ldelem.r8
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: IL_DD
    IL_0068: stloc.3
    IL_0069: nop
    IL_006A: nop
    IL_006B: nop
    IL_006C: ldloc.1
    IL_0071: brfalse IL_0078
    IL_0072: ldloc.1
    IL_0073: conv.r8
    IL_0074: ldelem.ref
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: IL_DC
    IL_0079: ret
    }

    public void hideCCPlay() {
    IL_0004: call 0x060001EF
    IL_0005: conv.r8
    IL_0006: IL_F5
    IL_0007: IL_01
    IL_0008: nop
    IL_0009: ldloc.0
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x700009B3
    IL_0015: call 0x0A0000A6
    IL_001A: brfalse IL_0079
    IL_001B: ldloc.0
    IL_0020: ldstr 0x700009C1
    IL_0025: call 0x0A0000A6
    IL_002A: brfalse IL_0079
    IL_002B: ldloc.0
    IL_0030: ldstr 0x700009CF
    IL_0035: call 0x0A0000A6
    IL_003A: brfalse IL_0079
    IL_003B: ldloc.0
    IL_0040: ldstr 0x700009DD
    IL_0045: call 0x0A0000A6
    IL_004A: brfalse IL_0079
    IL_004F: ldstr 0x700005C7
    IL_0054: newobj 0x0A000091
    IL_0055: stloc.1
    IL_0056: ldloc.1
    IL_005B: ldstr 0x70000A27
    IL_005C: ldc.i4.0
    IL_0061: newarr 0x01000020
    IL_0062: conv.r8
    IL_0063: ldelem.r8
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: IL_DD
    IL_0068: stloc.3
    IL_0069: nop
    IL_006A: nop
    IL_006B: nop
    IL_006C: ldloc.1
    IL_0071: brfalse IL_0078
    IL_0072: ldloc.1
    IL_0073: conv.r8
    IL_0074: ldelem.ref
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: IL_DC
    IL_0079: ret
    }

    public void getItemSwitch() {
    IL_0004: call 0x060001EF
    IL_0005: conv.r8
    IL_0006: IL_F5
    IL_0007: IL_01
    IL_0008: nop
    IL_0009: ldloc.0
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x700009B3
    IL_0015: call 0x0A0000A6
    IL_001A: brfalse IL_0099
    IL_001B: ldloc.0
    IL_0020: ldstr 0x700009CF
    IL_0025: call 0x0A0000A6
    IL_002A: brfalse IL_0099
    IL_002B: ldloc.0
    IL_0030: ldstr 0x700009DD
    IL_0035: call 0x0A0000A6
    IL_003A: brfalse IL_0099
    IL_003B: ldloc.0
    IL_0040: ldstr 0x700009C1
    IL_0045: call 0x0A0000A6
    IL_004A: brfalse IL_0099
    IL_004B: ldloc.0
    IL_0050: ldstr 0x70000A3D
    IL_0055: call 0x0A0000A6
    IL_005A: brfalse IL_0099
    IL_005B: ldloc.0
    IL_0060: ldstr 0x70000A4B
    IL_0065: call 0x0A0000A6
    IL_006A: brfalse IL_0099
    IL_006F: ldstr 0x70000A59
    IL_0074: newobj 0x0A000091
    IL_0075: stloc.1
    IL_0076: ldloc.1
    IL_007B: ldstr 0x70000A91
    IL_007C: ldc.i4.0
    IL_0081: newarr 0x01000020
    IL_0082: conv.r8
    IL_0083: IL_A7
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_0087: IL_DD
    IL_0088: stloc.3
    IL_0089: nop
    IL_008A: nop
    IL_008B: nop
    IL_008C: ldloc.1
    IL_0091: brfalse IL_0098
    IL_0092: ldloc.1
    IL_0093: conv.r8
    IL_0094: ldelem.ref
    IL_0095: nop
    IL_0096: nop
    IL_0097: stloc.0
    IL_0098: IL_DC
    IL_0099: ret
    }

    }}
