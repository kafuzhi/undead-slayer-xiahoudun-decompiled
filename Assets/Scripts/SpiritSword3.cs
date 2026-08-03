// Namespace: 
// Type: SpiritSword3

    public class SpiritSword3 {{

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
    private object hitcount;

    public SpiritSword3() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x040009A3
    IL_000C: ldarg.0
    IL_000D: ldc.i4.1
    IL_0012: stfld 0x040009A9
    IL_0013: ldarg.0
    IL_0018: call 0x0A000001
    IL_0019: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009A1
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040009A2
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000001
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: ldarg.3
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x040009A8
    IL_002D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00003D
    IL_0007: conv.r8
    IL_000A: ldarga 0
    IL_000B: stloc.0
    IL_0010: stfld 0x040009A6
    IL_0011: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009A2
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
    IL_0016: stfld 0x040009A7
    IL_0017: ldarg.0
    IL_0018: ldc.i4.0
    IL_001D: stfld 0x040009A5
    IL_001E: ldarg.0
    IL_001F: ldc.i4.0
    IL_0024: stfld 0x040009A4
    IL_0025: ldarg.0
    IL_0026: ldc.i4.0
    IL_002B: stfld 0x040009AA
    IL_002C: ldarg.0
    IL_002D: ldc.i4.0
    IL_0032: stfld 0x040009A9
    IL_0033: ldarg.0
    IL_0034: ldc.i4.0
    IL_0039: stfld 0x040009AC
    IL_003A: ret
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
    IL_03A4: switch (229 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009AA
    IL_000A: brtrue IL_017C
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009A7
    IL_0011: IL_22
    IL_0012: IL_CD
    IL_0013: IL_CC
    IL_0014: IL_4C
    IL_0015: IL_3E
    IL_0016: IL_43
    IL_0019: stloc 1
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0025: stfld 0x040009A7
    IL_0026: ldarg.0
    IL_002B: ldfld 0x040009A3
    IL_002C: ldarg.0
    IL_0031: ldfld 0x040009A5
    IL_0032: ldelem.i
    IL_0033: ldnull
    IL_0038: call 0x0A000061
    IL_003D: brfalse IL_00D8
    IL_003E: ldarg.0
    IL_0043: ldfld 0x040009A3
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040009A5
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040009A0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x040009A1
    IL_0056: conv.r8
    IL_0057: ldc.i4.2
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x040009A1
    IL_0061: conv.r8
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_006A: call 0x0A000019
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040009A1
    IL_0071: conv.r8
    IL_0072: pop
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_007A: call 0x0A000014
    IL_007B: conv.u4
    IL_007C: ldarg.1
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_01
    IL_0084: stelem 0x09A37B02
    IL_0085: nop
    IL_0086: ldarg.2
    IL_0087: ldarg.0
    IL_008C: ldfld 0x040009A5
    IL_008D: ldelem.i
    IL_008E: conv.r8
    IL_008F: IL_3D
    IL_0090: nop
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: ldarg.0
    IL_0098: ldfld 0x040009A6
    IL_0099: conv.r8
    IL_009A: IL_84
    IL_009B: nop
    IL_009C: nop
    IL_009D: stloc.0
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x040009A3
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x040009A5
    IL_00AA: ldelem.i
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x040009A1
    IL_00B1: conv.r8
    IL_00B2: IL_4E
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x040009A3
    IL_00BC: ldarg.0
    IL_00C1: ldfld 0x040009A5
    IL_00C2: ldelem.i
    IL_00C3: conv.r8
    IL_00C8: ldstr 0x022B0000
    IL_00CD: ldfld 0x040009A5
    IL_00CE: conv.r8
    IL_00CF: IL_35
    IL_00D0: ldarg.3
    IL_00D1: nop
    IL_00D2: ldloc.0
    IL_00D7: br IL_013A
    IL_00D8: ldarg.0
    IL_00DD: ldfld 0x040009A3
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x040009A5
    IL_00E4: ldelem.i
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x040009A1
    IL_00EB: conv.r8
    IL_00EC: ldc.i4.2
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: stloc.0
    IL_00F0: ldarg.0
    IL_00F5: ldfld 0x040009A1
    IL_00F6: conv.r8
    IL_00F7: IL_22
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FF: call 0x0A000019
    IL_0100: conv.r8
    IL_0101: ldloc.3
    IL_0102: nop
    IL_0103: nop
    IL_0104: stloc.0
    IL_0105: ldarg.0
    IL_010A: ldfld 0x040009A3
    IL_010B: ldarg.0
    IL_0110: ldfld 0x040009A5
    IL_0111: ldelem.i
    IL_0112: ldarg.0
    IL_0117: ldfld 0x040009A1
    IL_0118: conv.r8
    IL_0119: pop
    IL_011A: nop
    IL_011B: nop
    IL_011C: stloc.0
    IL_011D: conv.r8
    IL_0122: call 0x020A0000
    IL_0127: ldfld 0x040009A3
    IL_0128: ldarg.0
    IL_012D: ldfld 0x040009A5
    IL_012E: ldelem.i
    IL_012F: conv.r8
    IL_0130: stloc.0
    IL_0131: nop
    IL_0132: nop
    IL_0133: stloc.0
    IL_0134: ldc.i4.1
    IL_0135: conv.r8
    IL_0136: stloc.1
    IL_0137: nop
    IL_0138: nop
    IL_0139: stloc.0
    IL_013A: ldarg.0
    IL_013F: ldfld 0x040009A5
    IL_0140: ldc.i4.3
    IL_0141: IL_3C
    IL_0143: stloc.s 0
    IL_0144: nop
    IL_0145: nop
    IL_0146: ldarg.0
    IL_0147: dup
    IL_014C: ldfld 0x040009A5
    IL_014D: ldc.i4.1
    IL_014E: IL_58
    IL_0153: stfld 0x040009A5
    IL_0158: br IL_0160
    IL_0159: ldarg.0
    IL_015A: ldc.i4.1
    IL_015F: stfld 0x040009AA
    IL_0164: br IL_0177
    IL_0165: ldarg.0
    IL_0166: dup
    IL_016B: ldfld 0x040009A7
    IL_0170: call 0x0A000024
    IL_0171: IL_58
    IL_0176: stfld 0x040009A7
    IL_017B: br IL_0217
    IL_017C: ldarg.0
    IL_0181: ldfld 0x040009A7
    IL_0182: IL_22
    IL_0183: ldelem.i
    IL_0184: IL_99
    IL_0185: IL_99
    IL_0186: IL_3E
    IL_0187: IL_43
    IL_0188: IL_23
    IL_0189: nop
    IL_018A: nop
    IL_018B: nop
    IL_018C: ldarg.0
    IL_018D: ldc.i4.0
    IL_0192: stfld 0x040009A9
    IL_0193: ldarg.0
    IL_0198: ldfld 0x040009A2
    IL_0199: ldc.i4.1
    IL_019A: conv.r8
    IL_019C: ldc.i4.s 0
    IL_019D: nop
    IL_019E: stloc.0
    IL_019F: ldarg.0
    IL_01A0: IL_22
    IL_01A1: nop
    IL_01A2: nop
    IL_01A7: stsfld 0x09A77DBF
    IL_01A8: nop
    IL_01A9: ldarg.2
    IL_01AE: br IL_0217
    IL_01AF: ldarg.0
    IL_01B4: ldfld 0x040009A7
    IL_01B5: IL_22
    IL_01B6: nop
    IL_01B7: nop
    IL_01BC: stsfld 0x001743BF
    IL_01BD: nop
    IL_01BE: nop
    IL_01BF: ldarg.0
    IL_01C0: dup
    IL_01C5: ldfld 0x040009A7
    IL_01CA: call 0x0A000024
    IL_01CB: IL_58
    IL_01D0: stfld 0x040009A7
    IL_01D5: br IL_0217
    IL_01D6: ldarg.0
    IL_01D7: dup
    IL_01DC: ldfld 0x040009A7
    IL_01E1: call 0x0A000024
    IL_01E2: IL_59
    IL_01E7: stfld 0x040009A7
    IL_01E8: ldarg.0
    IL_01ED: ldfld 0x040009A7
    IL_01EE: IL_22
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: nop
    IL_01F2: IL_C0
    IL_01F3: IL_41
    IL_01F5: ldc.i4.s 0
    IL_01F6: nop
    IL_01F7: nop
    IL_01F8: ldarg.0
    IL_01FD: ldfld 0x040009A2
    IL_01FE: ldc.i4.0
    IL_01FF: conv.r8
    IL_0201: ldc.i4.s 0
    IL_0202: nop
    IL_0203: stloc.0
    IL_0204: ldarg.0
    IL_0209: ldfld 0x040009A2
    IL_020A: ldc.i4.1
    IL_020B: conv.r8
    IL_020D: ldc.i4.s 0
    IL_020E: nop
    IL_020F: stloc.0
    IL_0210: ldarg.0
    IL_0211: ldnull
    IL_0216: stfld 0x040009AB
    IL_0217: ldarg.0
    IL_021C: ldfld 0x040009A1
    IL_021D: ldarg.0
    IL_0222: ldfld 0x040009A8
    IL_0223: conv.r8
    IL_0224: ldc.i4.2
    IL_0225: nop
    IL_0226: nop
    IL_0227: stloc.0
    IL_022C: call 0x0A000007
    IL_022D: IL_22
    IL_022E: IL_CD
    IL_022F: IL_CC
    IL_0230: IL_CC
    IL_0231: IL_3D
    IL_0236: call 0x0A000008
    IL_023B: call 0x0A000029
    IL_023C: conv.r8
    IL_023D: ldloc.3
    IL_023E: nop
    IL_023F: nop
    IL_0240: stloc.0
    IL_0241: ldarg.0
    IL_0246: ldfld 0x040009A1
    IL_0247: ldarg.0
    IL_024C: ldfld 0x040009A1
    IL_024D: conv.r8
    IL_024E: pop
    IL_024F: nop
    IL_0250: nop
    IL_0251: stloc.0
    IL_0252: ldarg.0
    IL_0257: ldfld 0x040009A8
    IL_0258: conv.r8
    IL_0259: pop
    IL_025A: nop
    IL_025B: nop
    IL_025C: stloc.0
    IL_0261: call 0x0A000024
    IL_0262: IL_22
    IL_0263: nop
    IL_0264: nop
    IL_9CA16B69: switch (656955968 cases)
    }

    }}
