// Namespace: 
// Type: Ef_swing1

    public class Ef_swing1 {{

    private object uvAnimationTileX;
    private object uvAnimationTileY;
    private object framesPerSecond;
    private object index;
    private object oldindex;
    private object starttime;
    private object lastframe;
    private object efon;
    private object delay;
    private object impactframe;
    private object cha_rigidbody;
    public object pt_hit;
    private object script_cha;
    private object size;
    private object offset;
    private object uIndex;
    private object vIndex;
    private object originlayer;
    private object script_pthit;
    private object layerindex;
    private object layerchange;
    private object pton;
    private object rndefamount;
    private object addforce;
    private object myrenderer;
    private object mycollider;

    public Ef_swing1() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 20
    IL_0007: stfld 0x04000609
    IL_0008: ldarg.0
    IL_0009: ldc.i4.m1
    IL_000E: stfld 0x0400060B
    IL_000F: ldarg.0
    IL_0010: ldc.i4.1
    IL_0015: stfld 0x04000610
    IL_0016: ldarg.0
    IL_0018: ldc.i4.s 20
    IL_001D: stfld 0x04000618
    IL_001E: ldarg.0
    IL_0023: call 0x0A000001
    IL_0024: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_000B: stfld 0x0400061F
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000620
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A00000A
    IL_001F: conv.r8
    IL_0020: ldc.i4.8
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0028: stfld 0x04000618
    IL_0029: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: IL_44
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: conv.r8
    IL_000C: stloc.0
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: ldloc.0
    IL_0013: conv.r8
    IL_0018: ldsfld 0x7D0A0001
    IL_001A: ldloc.s 6
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000612
    IL_0024: conv.r8
    IL_0027: ldloc 0
    IL_0029: br.s IL_00A7
    IL_002A: ldc.i4.3
    IL_002B: ldloc.0
    IL_002C: nop
    IL_002D: ldarg.2
    IL_002E: ldarg.0
    IL_002F: ldloc.0
    IL_0030: conv.r8
    IL_0031: ldarg.2
    IL_0032: nop
    IL_0033: nop
    IL_0035: br.s IL_00B3
    IL_0037: stloc.s 6
    IL_0038: nop
    IL_0039: ldarg.2
    IL_003A: ldloc.0
    IL_003B: conv.r8
    IL_003C: IL_FF
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000620
    IL_004A: call 0x0A00017B
    IL_004B: ldarg.0
    IL_004C: IL_22
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0055: stfld 0x0400060C
    IL_0056: ldarg.0
    IL_005B: ldfld 0x0400061F
    IL_005C: ldc.i4.0
    IL_005D: conv.r8
    IL_0062: beq IL_20A0063
    IL_0067: ldfld 0x04000620
    IL_0068: ldc.i4.1
    IL_0069: conv.r8
    IL_006A: conv.ovf.i4.un
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000620
    IL_0074: ldc.i4.0
    IL_0075: conv.r8
    IL_0077: ldc.i4.s 0
    IL_0078: nop
    IL_0079: stloc.0
    IL_007A: ldarg.0
    IL_007B: IL_22
    IL_007C: nop
    IL_007D: nop
    IL_007E: nop
    IL_007F: nop
    IL_0084: stfld 0x0400060F
    IL_0085: ldarg.0
    IL_008A: call 0x0A00000A
    IL_008B: ldc.i4.0
    IL_008C: conv.r8
    IL_008D: stloc.1
    IL_008E: nop
    IL_008F: nop
    IL_0090: stloc.0
    IL_0091: ret
    }

    public void SwingOn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000618
    IL_000C: conv.r8
    IL_000D: ldc.i4.m1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: call 0x0A00000A
    IL_0017: ldc.i4.1
    IL_0018: conv.r8
    IL_0019: stloc.1
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_001E: ldarg.1
    IL_0023: stfld 0x0400060F
    IL_0024: ldarg.0
    IL_0025: ldc.i4.1
    IL_002A: stfld 0x0400060E
    IL_002B: ldarg.0
    IL_002C: ldarg.2
    IL_0031: stfld 0x04000607
    IL_0032: ldarg.0
    IL_0033: ldarg.3
    IL_0038: stfld 0x04000608
    IL_0039: ldarg.0
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000607
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000608
    IL_0046: IL_5A
    IL_004B: stfld 0x0400060D
    IL_004C: ldarg.0
    IL_004E: ldarg.s 4
    IL_0053: stfld 0x04000609
    IL_0054: ldarg.0
    IL_0056: ldarg.s 5
    IL_005B: stfld 0x04000610
    IL_005C: ldarg.0
    IL_005E: ldarg.s 6
    IL_0063: stfld 0x0400061E
    IL_0064: ldarg.0
    IL_0065: IL_22
    IL_0066: nop
    IL_0067: nop
    IL_006C: stsfld 0x077B023F
    IL_006D: ldloc.0
    IL_006E: nop
    IL_006F: ldarg.2
    IL_0070: conv.i2
    IL_0071: add
    IL_0072: IL_22
    IL_0073: nop
    IL_0074: nop
    IL_0079: stsfld 0x087B023F
    IL_007A: ldloc.0
    IL_007B: nop
    IL_007C: ldarg.2
    IL_007D: conv.i2
    IL_007E: add
    IL_0083: newobj 0x0A000038
    IL_0088: stfld 0x04000614
    IL_0089: ldarg.0
    IL_008E: ldfld 0x0400061B
    IL_0093: brfalse IL_00BA
    IL_0094: ldc.i4.0
    IL_0096: ldc.i4.s 100
    IL_009B: call 0x0A000045
    IL_009C: stloc.0
    IL_009D: ldloc.0
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x0400061D
    IL_00A4: IL_3C
    IL_00A6: ldloc.s 0
    IL_00A7: nop
    IL_00A8: nop
    IL_00A9: ldarg.0
    IL_00AE: call 0x0A00000A
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x0400061A
    IL_00B5: conv.r8
    IL_00B6: ldc.i4.m1
    IL_00B7: nop
    IL_00B8: nop
    IL_00B9: stloc.0
    IL_00BA: ret
    }

    public void SwingOff() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x0400060E
    IL_0007: ldarg.0
    IL_000C: call 0x0A00000A
    IL_000D: ldc.i4.0
    IL_000E: conv.r8
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x0400061F
    IL_0019: ldc.i4.0
    IL_001A: conv.r8
    IL_001F: beq IL_20A0020
    IL_0024: ldfld 0x04000620
    IL_0025: ldc.i4.0
    IL_0026: conv.r8
    IL_0028: ldc.i4.s 0
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_002C: ldc.i4.0
    IL_0031: stfld 0x0400061C
    IL_0032: ldarg.0
    IL_0033: ldc.i4.m1
    IL_0038: stfld 0x0400060B
    IL_0039: ldarg.0
    IL_003A: ldc.i4.0
    IL_003F: stfld 0x0400060A
    IL_0040: ldarg.0
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_004A: stfld 0x0400060C
    IL_004B: ret
    }

    public void RndEfOn() {
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: neg
    IL_0007: stfld 0x0400061D
    IL_0008: ldarg.2
    IL_0009: stloc.0
    IL_000A: ldloc.0
    IL_000B: ldc.i4.2
    IL_000C: IL_59
    IL_000F: ldarg 3
    IL_0010: nop
    IL_0011: nop
    IL_0012: ldarg.3
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0017: ldloc.s 0
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_0049
    IL_0023: ldarg.0
    IL_0024: ldc.i4.5
    IL_0029: stfld 0x0400061D
    IL_002E: br IL_0049
    IL_002F: ldarg.0
    IL_0031: ldc.i4.s 10
    IL_0036: stfld 0x0400061D
    IL_003B: br IL_0049
    IL_003C: ldarg.0
    IL_003E: ldc.i4.s 20
    IL_0043: stfld 0x0400061D
    IL_0048: br IL_0049
    IL_0049: ldarg.0
    IL_004A: ldc.i4.1
    IL_004F: stfld 0x0400061B
    IL_0050: ldarg.1
    IL_0051: stloc.0
    IL_0052: ldloc.0
    IL_0055: ldarg 5
    IL_0056: nop
    IL_0057: nop
    IL_0058: ldarg.3
    IL_0059: nop
    IL_005A: nop
    IL_005B: nop
    IL_005C: ldc.i4.3
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: pop
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0065: bne.un.s IL_0066
    IL_0066: nop
    IL_0067: nop
    IL_E000006C: switch (939524096 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400060E
    IL_000A: brfalse IL_008E
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400060F
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: IL_43
    IL_0017: ldc.i4.1
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x0400060F
    IL_0026: call 0x0A000024
    IL_0027: IL_59
    IL_002C: stfld 0x0400060F
    IL_0031: br IL_008E
    IL_0032: ldarg.0
    IL_0037: ldfld 0x0400061E
    IL_0038: ldc.i4.0
    IL_0039: IL_3E
    IL_003A: IL_27
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000611
    IL_0044: ldarg.0
    IL_0049: call 0x0A000002
    IL_004A: conv.r8
    IL_004B: IL_44
    IL_004C: nop
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: conv.r8
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: ldarg.0
    IL_0059: ldfld 0x0400061E
    IL_005A: conv.i2
    IL_005F: call 0x0A000008
    IL_0060: conv.r8
    IL_0061: IL_3E
    IL_0062: nop
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x0400061F
    IL_006B: ldc.i4.1
    IL_006C: conv.r8
    IL_0071: beq IL_20A0072
    IL_0072: IL_22
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_0076: nop
    IL_007B: stfld 0x0400060C
    IL_007C: ldarg.0
    IL_007D: ldc.i4.0
    IL_0082: stfld 0x0400060E
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000613
    IL_0089: conv.r8
    IL_008A: conv.i8
    IL_008B: IL_01
    IL_008C: nop
    IL_008D: ldloc.0
    IL_008E: ldarg.0
    IL_0093: ldfld 0x0400061F
    IL_0094: conv.r8
    IL_0095: IL_C9
    IL_0096: nop
    IL_0097: nop
    IL_0098: stloc.0
    IL_009D: brfalse IL_0235
    IL_009E: ldarg.0
    IL_009F: dup
    IL_00A4: ldfld 0x0400060C
    IL_00A9: call 0x0A000024
    IL_00AA: IL_58
    IL_00AF: stfld 0x0400060C
    IL_00B0: ldarg.0
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x0400060C
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000609
    IL_00BD: conv.i2
    IL_00BE: IL_5A
    IL_00BF: not
    IL_00C4: stfld 0x0400060A
    IL_00C5: ldarg.0
    IL_00C6: ldarg.0
    IL_00CB: ldfld 0x0400060A
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x04000607
    IL_00D2: mul
    IL_00D3: conv.i2
    IL_00D8: stfld 0x04000616
    IL_00D9: ldarg.0
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x0400060A
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000607
    IL_00E6: add
    IL_00EB: stfld 0x04000617
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x0400060A
    IL_00F2: ldarg.0
    IL_00F7: ldfld 0x0400060B
    IL_00FC: beq IL_0235
    IL_00FD: ldarg.0
    IL_0102: ldfld 0x0400060A
    IL_0103: ldarg.0
    IL_0108: ldfld 0x0400060D
    IL_0109: IL_3F
    IL_010A: IL_37
    IL_010B: nop
    IL_010C: nop
    IL_010D: nop
    IL_010E: ldarg.0
    IL_0113: ldfld 0x0400061F
    IL_0114: ldc.i4.0
    IL_0115: conv.r8
    IL_011A: beq IL_20A011B
    IL_011F: call 0x0A00000A
    IL_0120: ldc.i4.0
    IL_0121: conv.r8
    IL_0122: stloc.1
    IL_0123: nop
    IL_0124: nop
    IL_0125: stloc.0
    IL_0126: ldarg.0
    IL_012B: ldfld 0x04000620
    IL_012C: ldc.i4.0
    IL_012D: conv.r8
    IL_012F: ldc.i4.s 0
    IL_0130: nop
    IL_0131: stloc.0
    IL_0132: ldarg.0
    IL_0133: ldc.i4.0
    IL_0138: stfld 0x0400061C
    IL_0139: ldarg.0
    IL_013A: ldc.i4.m1
    IL_013F: stfld 0x0400060B
    IL_0144: br IL_01A3
    IL_0145: ldarg.0
    IL_014A: ldfld 0x0400060A
    IL_014B: ldarg.0
    IL_0150: ldfld 0x04000610
    IL_0155: beq IL_0169
    IL_0156: ldarg.0
    IL_015B: ldfld 0x0400060A
    IL_015C: ldarg.0
    IL_0161: ldfld 0x04000610
    IL_0162: ldc.i4.1
    IL_0163: IL_58
    IL_0220: switch (46 cases)
    IL_0221: ldloc.0
    IL_0222: nop
    IL_0223: ldarg.2
    IL_0224: conv.r8
    IL_0225: conv.r8
    IL_0226: IL_01
    IL_0227: nop
    IL_0228: stloc.0
    IL_0229: ldarg.0
    IL_022A: ldarg.0
    IL_022F: ldfld 0x0400060A
    IL_0234: stfld 0x0400060B
    IL_0235: ret
    }

    }}
