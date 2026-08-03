// Namespace: 
// Type: SpiritSword

    public class SpiritSword {{

    public object sword;
    private object mytransform;
    private object mycollider;
    private object c_sword;
    private object swordindex;
    private object creatindex;
    private object power;
    private object start_delay;
    private object cha1;
    private object homing;
    private object creatfinish;
    private object oldtarget;

    public SpiritSword() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.7
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x0400098A
    IL_000C: ldarg.0
    IL_000D: ldc.i4.1
    IL_0012: stfld 0x04000990
    IL_0013: ldarg.0
    IL_0018: call 0x0A000001
    IL_0019: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000988
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000989
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000001
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: ldarg.3
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x0400098F
    IL_002D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00003D
    IL_0007: conv.r8
    IL_000A: ldarga 0
    IL_000B: stloc.0
    IL_0010: stfld 0x0400098D
    IL_0011: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000989
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0016: stfld 0x0400098E
    IL_0017: ldarg.0
    IL_0018: ldc.i4.0
    IL_001D: stfld 0x0400098C
    IL_001E: ldarg.0
    IL_001F: ldc.i4.0
    IL_0024: stfld 0x0400098B
    IL_0025: ldarg.0
    IL_0026: ldc.i4.0
    IL_002B: stfld 0x04000991
    IL_002C: ldarg.0
    IL_002D: ldc.i4.0
    IL_0032: stfld 0x04000990
    IL_0033: ret
    }

    public void Init() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000989
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0016: stfld 0x0400098E
    IL_0017: ldarg.0
    IL_0018: ldc.i4.0
    IL_001D: stfld 0x0400098C
    IL_001E: ldarg.0
    IL_001F: ldc.i4.0
    IL_0024: stfld 0x0400098B
    IL_0025: ldarg.0
    IL_0026: ldc.i4.0
    IL_002B: stfld 0x04000991
    IL_002C: ldarg.0
    IL_002D: ldc.i4.0
    IL_0032: stfld 0x04000990
    IL_0033: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.8
    IL_02B4: switch (169 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000991
    IL_000A: brtrue IL_0263
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400098E
    IL_0011: IL_22
    IL_0012: IL_CD
    IL_0013: IL_CC
    IL_0014: IL_CC
    IL_0015: IL_3D
    IL_0016: IL_43
    IL_0018: ble.s IL_001B
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0025: stfld 0x0400098E
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400098A
    IL_002C: ldarg.0
    IL_0031: ldfld 0x0400098C
    IL_0032: ldelem.i
    IL_0033: ldnull
    IL_0038: call 0x0A000061
    IL_003D: brfalse IL_0125
    IL_003E: ldarg.0
    IL_0043: ldfld 0x0400098A
    IL_0044: ldarg.0
    IL_0049: ldfld 0x0400098C
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000987
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000988
    IL_0056: conv.r8
    IL_0057: ldc.i4.2
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: IL_22
    IL_005C: nop
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0061: ldc.i4.s 30
    IL_0062: ldarg.0
    IL_0067: ldfld 0x0400098C
    IL_0068: IL_5A
    IL_0069: conv.i2
    IL_006A: ldarg.0
    IL_006F: ldfld 0x04000988
    IL_0070: conv.r8
    IL_0071: div.un
    IL_0072: nop
    IL_0073: nop
    IL_0074: stloc.0
    IL_0075: stloc.0
    IL_0077: ldloca.s 0
    IL_007C: ldfld 0x0A000023
    IL_007D: IL_58
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: IL_87
    IL_0082: IL_43
    IL_0083: IL_59
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_0087: nop
    IL_0088: nop
    IL_008D: call 0x0A000060
    IL_0092: call 0x0A000014
    IL_0093: conv.u4
    IL_0094: ldarg.1
    IL_0095: nop
    IL_0096: nop
    IL_0097: IL_01
    IL_009C: stelem 0x098A7B02
    IL_009D: nop
    IL_009E: ldarg.2
    IL_009F: ldarg.0
    IL_00A4: ldfld 0x0400098C
    IL_00A5: ldelem.i
    IL_00A6: conv.r8
    IL_00A7: IL_3D
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x0400098D
    IL_00B1: conv.r8
    IL_00B2: IL_84
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x0400098A
    IL_00BC: ldarg.0
    IL_00C1: ldfld 0x0400098C
    IL_00C2: ldelem.i
    IL_00C3: dup
    IL_00C4: conv.r8
    IL_00C5: ldc.i4.2
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: stloc.0
    IL_00C9: ldarg.0
    IL_00CE: ldfld 0x0400098A
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x0400098C
    IL_00D5: ldelem.i
    IL_00D6: conv.r8
    IL_00D7: IL_22
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: stloc.0
    IL_00DB: IL_22
    IL_00DC: IL_CD
    IL_00DD: IL_CC
    IL_00DE: IL_CC
    IL_00DF: IL_3D
    IL_00E4: call 0x0A000008
    IL_00E9: call 0x0A000029
    IL_00EA: conv.r8
    IL_00EB: ldloc.3
    IL_00EC: nop
    IL_00ED: nop
    IL_00EE: stloc.0
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x0400098A
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x0400098C
    IL_00FB: ldelem.i
    IL_0100: call 0x0A000007
    IL_0101: ldarg.0
    IL_0106: ldfld 0x04000988
    IL_0107: conv.r8
    IL_0108: IL_22
    IL_0109: nop
    IL_010A: nop
    IL_010B: stloc.0
    IL_010C: IL_22
    IL_010D: ldelem.i
    IL_010E: IL_99
    IL_010F: ldc.i4.3
    IL_0110: IL_3F
    IL_0115: call 0x0A000008
    IL_011A: call 0x0A000029
    IL_011B: conv.r8
    IL_0120: ldc.i4 940179456
    IL_0121: IL_E4
    IL_0122: nop
    IL_0123: nop
    IL_0124: nop
    IL_0125: ldarg.0
    IL_012A: ldfld 0x0400098A
    IL_012B: ldarg.0
    IL_0130: ldfld 0x0400098C
    IL_0131: ldelem.i
    IL_0132: ldarg.0
    IL_0137: ldfld 0x04000988
    IL_0138: conv.r8
    IL_0139: ldc.i4.2
    IL_013A: nop
    IL_013B: nop
    IL_013C: stloc.0
    IL_013D: conv.r8
    IL_013E: ldloc.3
    IL_013F: nop
    IL_0140: nop
    IL_0141: stloc.0
    IL_0142: ldarg.0
    IL_0147: ldfld 0x0400098A
    IL_0148: ldarg.0
    IL_014D: ldfld 0x0400098C
    IL_014E: ldelem.i
    IL_014F: IL_22
    IL_0150: nop
    IL_0151: nop
    IL_0152: nop
    IL_0153: nop
    IL_0155: ldc.i4.s 30
    IL_0156: ldarg.0
    IL_015B: ldfld 0x0400098C
    IL_015C: IL_5A
    IL_015D: conv.i2
    IL_015E: ldarg.0
    IL_0163: ldfld 0x04000988
    IL_0164: conv.r8
    IL_0165: div.un
    IL_0166: nop
    IL_0167: nop
    IL_0168: stloc.0
    IL_0169: stloc.1
    IL_016B: ldloca.s 1
    IL_0170: ldfld 0x0A000023
    IL_0171: IL_58
    IL_0172: IL_22
    IL_0173: nop
    IL_0174: nop
    IL_0175: IL_87
    IL_0176: IL_43
    IL_0177: IL_59
    IL_0178: IL_22
    IL_0179: nop
    IL_017A: nop
    IL_017B: nop
    IL_017C: nop
    IL_0181: call 0x0A000060
    IL_0182: conv.r8
    IL_0187: call 0x020A0000
    IL_018C: ldfld 0x0400098A
    IL_018D: ldarg.0
    IL_0192: ldfld 0x0400098C
    IL_0193: ldelem.i
    IL_0194: conv.r8
    IL_0195: stloc.0
    IL_0196: nop
    IL_0197: nop
    IL_0198: stloc.0
    IL_0199: ldc.i4.1
    IL_019A: conv.r8
    IL_019B: stloc.1
    IL_019C: nop
    IL_019D: nop
    IL_019E: stloc.0
    IL_019F: ldarg.0
    IL_01A4: ldfld 0x0400098A
    IL_01A5: ldarg.0
    IL_01AA: ldfld 0x0400098C
    IL_01AB: ldelem.i
    IL_01AC: dup
    IL_01AD: conv.r8
    IL_01AE: ldc.i4.2
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: stloc.0
    IL_01B2: ldarg.0
    IL_01B7: ldfld 0x0400098A
    IL_01B8: ldarg.0
    IL_01BD: ldfld 0x0400098C
    IL_01BE: ldelem.i
    IL_01BF: conv.r8
    IL_01C0: IL_22
    IL_01C1: nop
    IL_01C2: nop
    IL_01C3: stloc.0
    IL_01C4: IL_22
    IL_01C5: IL_CD
    IL_01C6: IL_CC
    IL_01C7: IL_CC
    IL_01C8: IL_3D
    IL_01CD: call 0x0A000008
    IL_01D2: call 0x0A000029
    IL_01D3: conv.r8
    IL_01D4: ldloc.3
    IL_01D5: nop
    IL_01D6: nop
    IL_01D7: stloc.0
    IL_01D8: ldarg.0
    IL_01DD: ldfld 0x0400098A
    IL_01DE: ldarg.0
    IL_01E3: ldfld 0x0400098C
    IL_01E4: ldelem.i
    IL_01E9: call 0x0A000007
    IL_01EA: ldarg.0
    IL_01EF: ldfld 0x04000988
    IL_01F0: conv.r8
    IL_01F1: IL_22
    IL_01F2: nop
    IL_01F3: nop
    IL_01F4: stloc.0
    IL_01F5: IL_22
    IL_01F6: ldelem.i
    IL_01F7: IL_99
    IL_01F8: ldc.i4.3
    IL_01F9: IL_3F
    IL_01FE: call 0x0A000008
    IL_0203: call 0x0A000029
    IL_0204: conv.r8
    IL_0209: ldc.i4 34209792
    IL_020E: ldfld 0x0400098A
    IL_020F: ldarg.0
    IL_0214: ldfld 0x0400098C
    IL_0215: ldelem.i
    IL_0216: ldarg.0
    IL_021B: ldfld 0x04000988
    IL_021C: conv.r8
    IL_021D: IL_4E
    IL_021E: nop
    IL_021F: nop
    IL_0220: stloc.0
    IL_0221: ldarg.0
    IL_0226: ldfld 0x0400098C
    IL_0227: ldc.i4.6
    IL_0228: IL_3C
    IL_022A: stloc.s 0
    IL_022B: nop
    IL_022C: nop
    IL_022D: ldarg.0
    IL_022E: dup
    IL_0233: ldfld 0x0400098C
    IL_0234: ldc.i4.1
    IL_0235: IL_58
    IL_023A: stfld 0x0400098C
    IL_023F: br IL_0247
    IL_0240: ldarg.0
    IL_0241: ldc.i4.1
    IL_0246: stfld 0x04000991
    IL_024B: br IL_025E
    IL_024C: ldarg.0
    IL_024D: dup
    IL_0252: ldfld 0x0400098E
    IL_0257: call 0x0A000024
    IL_0258: IL_58
    IL_025D: stfld 0x0400098E
    IL_0262: br IL_02FE
    IL_0263: ldarg.0
    IL_0268: ldfld 0x0400098E
    IL_0269: IL_22
    IL_026A: IL_CD
    IL_026B: IL_CC
    IL_026C: IL_CC
    IL_026D: IL_3E
    IL_026E: IL_43
    IL_026F: IL_23
    IL_0270: nop
    IL_0271: nop
    IL_0272: nop
    IL_0273: ldarg.0
    IL_0274: ldc.i4.0
    IL_0279: stfld 0x04000990
    IL_027A: ldarg.0
    IL_027F: ldfld 0x04000989
    IL_0280: ldc.i4.1
    IL_0281: conv.r8
    IL_0283: ldc.i4.s 0
    IL_0284: nop
    IL_0285: stloc.0
    IL_0286: ldarg.0
    IL_0287: IL_22
    IL_0288: nop
    IL_0289: nop
    IL_028E: stsfld 0x098E7DBF
    IL_028F: nop
    IL_0290: ldarg.2
    IL_0295: br IL_02FE
    IL_0296: ldarg.0
    IL_029B: ldfld 0x0400098E
    IL_029C: IL_22
    IL_029D: nop
    IL_029E: nop
    IL_02A3: stsfld 0x001743BF
    IL_02A4: nop
    IL_02A5: nop
    IL_02A6: ldarg.0
    IL_02A7: dup
    IL_02AC: ldfld 0x0400098E
    IL_02B1: call 0x0A000024
    IL_02B2: IL_58
    IL_02B7: stfld 0x0400098E
    IL_02BC: br IL_02FE
    IL_02BD: ldarg.0
    IL_02BE: dup
    IL_02C3: ldfld 0x0400098E
    IL_02C8: call 0x0A000024
    IL_02C9: IL_59
    IL_02CE: stfld 0x0400098E
    IL_02CF: ldarg.0
    IL_02D4: ldfld 0x0400098E
    IL_02D5: IL_22
    IL_02D6: nop
    IL_02D7: nop
    IL_02D8: nop
    IL_02D9: IL_C0
    IL_02DA: IL_41
    IL_02DC: ldc.i4.s 0
    IL_02DD: nop
    IL_02DE: nop
    IL_02DF: ldarg.0
    IL_02E4: ldfld 0x04000989
    IL_02E5: ldc.i4.0
    IL_02E6: conv.r8
    IL_02E8: ldc.i4.s 0
    IL_02E9: nop
    IL_02EA: stloc.0
    IL_02EB: ldarg.0
    IL_02F0: ldfld 0x04000989
    IL_02F1: ldc.i4.1
    IL_02F2: conv.r8
    IL_02F4: ldc.i4.s 0
    IL_02F5: nop
    IL_02F6: stloc.0
    IL_02F7: ldarg.0
    IL_02F8: ldnull
    IL_02FD: stfld 0x04000992
    IL_02FE: ldarg.0
    IL_0303: ldfld 0x04000988
    IL_0304: ldarg.0
    IL_0309: ldfld 0x0400098F
    IL_030A: conv.r8
    IL_030B: ldc.i4.2
    IL_030C: nop
    IL_030D: nop
    IL_030E: stloc.0
    IL_0313: call 0x0A000007
    IL_0314: IL_22
    IL_0315: IL_CD
    IL_0316: IL_CC
    IL_0317: IL_4C
    IL_0318: IL_3E
    IL_031D: call 0x0A000008
    IL_0322: call 0x0A000029
    IL_0323: conv.r8
    IL_0324: ldloc.3
    IL_0325: nop
    IL_0326: nop
    IL_0327: stloc.0
    IL_0328: ldarg.0
    IL_032D: ldfld 0x04000988
    IL_032E: ldarg.0
    IL_0333: ldfld 0x04000988
    IL_0334: conv.r8
    IL_0335: pop
    IL_0336: nop
    IL_0337: nop
    IL_0338: stloc.0
    IL_0339: ldarg.0
    IL_033E: ldfld 0x0400098F
    IL_033F: conv.r8
    IL_0340: pop
    IL_0341: nop
    IL_0342: nop
    IL_0343: stloc.0
    IL_0348: call 0x0A000024
    IL_0349: IL_22
    IL_034A: nop
    IL_034B: nop
    IL_9CA16C50: switch (656955968 cases)
    }

    }}
