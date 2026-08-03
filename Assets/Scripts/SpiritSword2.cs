// Namespace: 
// Type: SpiritSword2

    public class SpiritSword2 {{

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

    public SpiritSword2() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x04000996
    IL_000C: ldarg.0
    IL_000D: ldc.i4.1
    IL_0012: stfld 0x0400099C
    IL_0013: ldarg.0
    IL_0018: call 0x0A000001
    IL_0019: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000994
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000995
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000001
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: ldarg.3
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x0400099B
    IL_002D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00003D
    IL_0007: conv.r8
    IL_000A: ldarga 0
    IL_000B: stloc.0
    IL_0010: stfld 0x04000999
    IL_0011: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000995
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
    IL_0016: stfld 0x0400099A
    IL_0017: ldarg.0
    IL_0018: ldc.i4.0
    IL_001D: stfld 0x04000998
    IL_001E: ldarg.0
    IL_001F: ldc.i4.0
    IL_0024: stfld 0x04000997
    IL_0025: ldarg.0
    IL_0026: ldc.i4.0
    IL_002B: stfld 0x0400099D
    IL_002C: ldarg.0
    IL_002D: ldc.i4.0
    IL_0032: stfld 0x0400099C
    IL_0033: ldarg.0
    IL_0034: ldc.i4.0
    IL_0039: stfld 0x0400099F
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
    IL_0005: ldfld 0x0400099D
    IL_000A: brtrue IL_01A1
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400099A
    IL_0011: IL_22
    IL_0012: IL_CD
    IL_0013: IL_CC
    IL_0014: IL_4C
    IL_0015: IL_3E
    IL_0016: IL_43
    IL_0017: conv.r8
    IL_0018: IL_01
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0025: stfld 0x0400099A
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000996
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000998
    IL_0032: ldelem.i
    IL_0033: ldnull
    IL_0038: call 0x0A000061
    IL_003D: brfalse IL_00DC
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000996
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000998
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000993
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000994
    IL_0056: conv.r8
    IL_0057: ldc.i4.2
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000994
    IL_0061: conv.r8
    IL_0062: pop
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_006A: call 0x0A000014
    IL_006B: conv.u4
    IL_006C: ldarg.1
    IL_006D: nop
    IL_006E: nop
    IL_006F: IL_01
    IL_0074: stelem 0x09967B02
    IL_0075: nop
    IL_0076: ldarg.2
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000998
    IL_007D: ldelem.i
    IL_007E: conv.r8
    IL_007F: IL_3D
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000999
    IL_0089: conv.r8
    IL_008A: IL_84
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: ldarg.0
    IL_0093: ldfld 0x04000996
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000998
    IL_009A: ldelem.i
    IL_009F: call 0x0A000007
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000994
    IL_00A6: conv.r8
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_22
    IL_00AC: ldelem.i
    IL_00AD: IL_99
    IL_00AE: ldc.i4.3
    IL_00AF: IL_3F
    IL_00B4: call 0x0A000008
    IL_00B9: call 0x0A000029
    IL_00BA: conv.r8
    IL_00BF: ldc.i4 34209792
    IL_00C4: ldfld 0x04000996
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04000998
    IL_00CB: ldelem.i
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x04000994
    IL_00D2: conv.r8
    IL_00D3: IL_4E
    IL_00D4: nop
    IL_00D5: nop
    IL_00D6: stloc.0
    IL_00DB: br IL_015F
    IL_00DC: ldarg.0
    IL_00E1: ldfld 0x04000996
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x04000998
    IL_00E8: ldelem.i
    IL_00E9: ldarg.0
    IL_00EE: ldfld 0x04000994
    IL_00EF: conv.r8
    IL_00F0: ldc.i4.2
    IL_00F1: nop
    IL_00F2: nop
    IL_00F3: stloc.0
    IL_00F4: conv.r8
    IL_00F5: ldloc.3
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: stloc.0
    IL_00F9: ldarg.0
    IL_00FE: ldfld 0x04000996
    IL_00FF: ldarg.0
    IL_0104: ldfld 0x04000998
    IL_0105: ldelem.i
    IL_0106: ldarg.0
    IL_010B: ldfld 0x04000994
    IL_010C: conv.r8
    IL_010D: pop
    IL_010E: nop
    IL_010F: nop
    IL_0110: stloc.0
    IL_0111: conv.r8
    IL_0116: call 0x020A0000
    IL_011B: ldfld 0x04000996
    IL_011C: ldarg.0
    IL_0121: ldfld 0x04000998
    IL_0122: ldelem.i
    IL_0123: conv.r8
    IL_0124: stloc.0
    IL_0125: nop
    IL_0126: nop
    IL_0127: stloc.0
    IL_0128: ldc.i4.1
    IL_0129: conv.r8
    IL_012A: stloc.1
    IL_012B: nop
    IL_012C: nop
    IL_012D: stloc.0
    IL_012E: ldarg.0
    IL_0133: ldfld 0x04000996
    IL_0134: ldarg.0
    IL_0139: ldfld 0x04000998
    IL_013A: ldelem.i
    IL_013F: call 0x0A000007
    IL_0140: ldarg.0
    IL_0145: ldfld 0x04000994
    IL_0146: conv.r8
    IL_0147: IL_22
    IL_0148: nop
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: IL_22
    IL_014C: ldelem.i
    IL_014D: IL_99
    IL_014E: ldc.i4.3
    IL_014F: IL_3F
    IL_0154: call 0x0A000008
    IL_0159: call 0x0A000029
    IL_015A: conv.r8
    IL_015F: ldc.i4 34209792
    IL_0164: ldfld 0x04000998
    IL_0165: ldc.i4.1
    IL_0166: IL_3C
    IL_0168: stloc.s 0
    IL_0169: nop
    IL_016A: nop
    IL_016B: ldarg.0
    IL_016C: dup
    IL_0171: ldfld 0x04000998
    IL_0172: ldc.i4.1
    IL_0173: IL_58
    IL_0178: stfld 0x04000998
    IL_017D: br IL_0185
    IL_017E: ldarg.0
    IL_017F: ldc.i4.1
    IL_0184: stfld 0x0400099D
    IL_0189: br IL_019C
    IL_018A: ldarg.0
    IL_018B: dup
    IL_0190: ldfld 0x0400099A
    IL_0195: call 0x0A000024
    IL_0196: IL_58
    IL_019B: stfld 0x0400099A
    IL_01A0: br IL_023C
    IL_01A1: ldarg.0
    IL_01A6: ldfld 0x0400099A
    IL_01A7: IL_22
    IL_01A8: IL_CD
    IL_01A9: IL_CC
    IL_01AA: IL_CC
    IL_01AB: IL_3E
    IL_01AC: IL_43
    IL_01AD: IL_23
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: ldarg.0
    IL_01B2: ldc.i4.0
    IL_01B7: stfld 0x0400099C
    IL_01B8: ldarg.0
    IL_01BD: ldfld 0x04000995
    IL_01BE: ldc.i4.1
    IL_01BF: conv.r8
    IL_01C1: ldc.i4.s 0
    IL_01C2: nop
    IL_01C3: stloc.0
    IL_01C4: ldarg.0
    IL_01C5: IL_22
    IL_01C6: nop
    IL_01C7: nop
    IL_01CC: stsfld 0x099A7DBF
    IL_01CD: nop
    IL_01CE: ldarg.2
    IL_01D3: br IL_023C
    IL_01D4: ldarg.0
    IL_01D9: ldfld 0x0400099A
    IL_01DA: IL_22
    IL_01DB: nop
    IL_01DC: nop
    IL_01E1: stsfld 0x001743BF
    IL_01E2: nop
    IL_01E3: nop
    IL_01E4: ldarg.0
    IL_01E5: dup
    IL_01EA: ldfld 0x0400099A
    IL_01EF: call 0x0A000024
    IL_01F0: IL_58
    IL_01F5: stfld 0x0400099A
    IL_01FA: br IL_023C
    IL_01FB: ldarg.0
    IL_01FC: dup
    IL_0201: ldfld 0x0400099A
    IL_0206: call 0x0A000024
    IL_0207: IL_59
    IL_020C: stfld 0x0400099A
    IL_020D: ldarg.0
    IL_0212: ldfld 0x0400099A
    IL_0213: IL_22
    IL_0214: nop
    IL_0215: nop
    IL_0216: nop
    IL_0217: IL_C0
    IL_0218: IL_41
    IL_021A: ldc.i4.s 0
    IL_021B: nop
    IL_021C: nop
    IL_021D: ldarg.0
    IL_0222: ldfld 0x04000995
    IL_0223: ldc.i4.0
    IL_0224: conv.r8
    IL_0226: ldc.i4.s 0
    IL_0227: nop
    IL_0228: stloc.0
    IL_0229: ldarg.0
    IL_022E: ldfld 0x04000995
    IL_022F: ldc.i4.1
    IL_0230: conv.r8
    IL_0232: ldc.i4.s 0
    IL_0233: nop
    IL_0234: stloc.0
    IL_0235: ldarg.0
    IL_0236: ldnull
    IL_023B: stfld 0x0400099E
    IL_023C: ldarg.0
    IL_0241: ldfld 0x04000994
    IL_0242: ldarg.0
    IL_0247: ldfld 0x0400099B
    IL_0248: conv.r8
    IL_0249: ldc.i4.2
    IL_024A: nop
    IL_024B: nop
    IL_024C: stloc.0
    IL_0251: call 0x0A000007
    IL_0252: IL_22
    IL_0253: IL_CD
    IL_0254: IL_CC
    IL_0255: IL_4C
    IL_0256: IL_3E
    IL_025B: call 0x0A000008
    IL_0260: call 0x0A000029
    IL_0261: conv.r8
    IL_0262: ldloc.3
    IL_0263: nop
    IL_0264: nop
    IL_0265: stloc.0
    IL_0266: ldarg.0
    IL_026B: ldfld 0x04000994
    IL_026C: ldarg.0
    IL_0271: ldfld 0x04000994
    IL_0272: conv.r8
    IL_0273: pop
    IL_0274: nop
    IL_0275: nop
    IL_0276: stloc.0
    IL_0277: ldarg.0
    IL_027C: ldfld 0x0400099B
    IL_027D: conv.r8
    IL_027E: pop
    IL_027F: nop
    IL_0280: nop
    IL_0281: stloc.0
    IL_0286: call 0x0A000024
    IL_0287: IL_22
    IL_0288: nop
    IL_0289: nop
    IL_9CA16B8E: switch (656955968 cases)
    }

    }}
