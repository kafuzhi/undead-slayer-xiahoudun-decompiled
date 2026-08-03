// Namespace: 
// Type: Ef_swing1_ride

    public class Ef_swing1_ride {{

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
    private object size;
    private object offset;
    private object uIndex;
    private object vIndex;
    private object script_pthit;
    private object layerindex;
    private object layerchange;
    private object pton;
    private object rndefamount;
    private object addforce;
    private object myrenderer;
    private object mycollider;

    public Ef_swing1_ride() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 20
    IL_0007: stfld 0x04000623
    IL_0008: ldarg.0
    IL_0009: ldc.i4.m1
    IL_000E: stfld 0x04000625
    IL_000F: ldarg.0
    IL_0010: ldc.i4.1
    IL_0015: stfld 0x0400062A
    IL_0016: ldarg.0
    IL_001B: call 0x0A000001
    IL_001C: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_000B: stfld 0x04000637
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000638
    IL_0018: ret
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
    IL_001A: br.s IL_0021
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x0400062C
    IL_0024: conv.r8
    IL_0027: ldloc 0
    IL_0029: br.s IL_00A7
    IL_002B: ble.s IL_0032
    IL_002C: nop
    IL_002D: ldarg.2
    IL_002E: ldloc.0
    IL_002F: conv.r8
    IL_0030: IL_FF
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000638
    IL_003E: call 0x0A00017B
    IL_003F: ldarg.0
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0049: stfld 0x04000626
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000637
    IL_0050: ldc.i4.0
    IL_0051: conv.r8
    IL_0056: beq IL_20A0057
    IL_005B: ldfld 0x04000638
    IL_005C: ldc.i4.1
    IL_005D: conv.r8
    IL_005E: conv.ovf.i4.un
    IL_005F: nop
    IL_0060: nop
    IL_0061: stloc.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000638
    IL_0068: ldc.i4.0
    IL_0069: conv.r8
    IL_006B: ldc.i4.s 0
    IL_006C: nop
    IL_006D: stloc.0
    IL_006E: ldarg.0
    IL_006F: IL_22
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: nop
    IL_0078: stfld 0x04000629
    IL_0079: ldarg.0
    IL_007E: call 0x0A00000A
    IL_007F: ldc.i4.0
    IL_0080: conv.r8
    IL_0081: stloc.1
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0085: ret
    }

    public void SwingOn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0007: ldc.i4.s 20
    IL_0008: conv.r8
    IL_0009: ldc.i4.m1
    IL_000A: nop
    IL_000B: nop
    IL_000C: stloc.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000A
    IL_0013: ldc.i4.1
    IL_0014: conv.r8
    IL_0015: stloc.1
    IL_0016: nop
    IL_0017: nop
    IL_0018: stloc.0
    IL_0019: ldarg.0
    IL_001A: ldarg.1
    IL_001F: stfld 0x04000629
    IL_0020: ldarg.0
    IL_0021: ldc.i4.1
    IL_0026: stfld 0x04000628
    IL_0027: ldarg.0
    IL_0028: ldarg.2
    IL_002D: stfld 0x04000621
    IL_002E: ldarg.0
    IL_002F: ldarg.3
    IL_0034: stfld 0x04000622
    IL_0035: ldarg.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000621
    IL_003C: ldarg.0
    IL_0041: ldfld 0x04000622
    IL_0042: IL_5A
    IL_0047: stfld 0x04000627
    IL_0048: ldarg.0
    IL_004A: ldarg.s 4
    IL_004F: stfld 0x04000623
    IL_0050: ldarg.0
    IL_0052: ldarg.s 5
    IL_0057: stfld 0x0400062A
    IL_0058: ldarg.0
    IL_005A: ldarg.s 6
    IL_005F: stfld 0x04000636
    IL_0060: ldarg.0
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0068: stsfld 0x217B023F
    IL_0069: ldloc.0
    IL_006A: nop
    IL_006B: ldarg.2
    IL_006C: conv.i2
    IL_006D: add
    IL_006E: IL_22
    IL_006F: nop
    IL_0070: nop
    IL_0075: stsfld 0x227B023F
    IL_0076: ldloc.0
    IL_0077: nop
    IL_0078: ldarg.2
    IL_0079: conv.i2
    IL_007A: add
    IL_007F: newobj 0x0A000038
    IL_0084: stfld 0x0400062D
    IL_0085: ldarg.0
    IL_008A: ldfld 0x04000633
    IL_008F: brfalse IL_00B6
    IL_0090: ldc.i4.0
    IL_0092: ldc.i4.s 100
    IL_0097: call 0x0A000045
    IL_0098: stloc.0
    IL_0099: ldloc.0
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000635
    IL_00A0: IL_3C
    IL_00A2: ldloc.s 0
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: ldarg.0
    IL_00AA: call 0x0A00000A
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x04000632
    IL_00B1: conv.r8
    IL_00B2: ldc.i4.m1
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ret
    }

    public void SwingOff() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000628
    IL_0007: ldarg.0
    IL_000C: call 0x0A00000A
    IL_000D: ldc.i4.0
    IL_000E: conv.r8
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000637
    IL_0019: ldc.i4.0
    IL_001A: conv.r8
    IL_001F: beq IL_20A0020
    IL_0024: ldfld 0x04000638
    IL_0025: ldc.i4.0
    IL_0026: conv.r8
    IL_0028: ldc.i4.s 0
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_002C: ldc.i4.0
    IL_0031: stfld 0x04000634
    IL_0032: ldarg.0
    IL_0033: ldc.i4.m1
    IL_0038: stfld 0x04000625
    IL_0039: ldarg.0
    IL_003A: ldc.i4.0
    IL_003F: stfld 0x04000624
    IL_0040: ldarg.0
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_004A: stfld 0x04000626
    IL_004B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000628
    IL_000A: brfalse IL_0083
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000629
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
    IL_0021: ldfld 0x04000629
    IL_0026: call 0x0A000024
    IL_0027: IL_59
    IL_002C: stfld 0x04000629
    IL_0031: br IL_0083
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000636
    IL_0038: ldc.i4.0
    IL_0039: IL_3E
    IL_003A: IL_27
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: ldarg.0
    IL_0043: ldfld 0x0400062B
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
    IL_0059: ldfld 0x04000636
    IL_005A: conv.i2
    IL_005F: call 0x0A000008
    IL_0060: conv.r8
    IL_0061: IL_3E
    IL_0062: nop
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000637
    IL_006B: ldc.i4.1
    IL_006C: conv.r8
    IL_0071: beq IL_20A0072
    IL_0072: IL_22
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_0076: nop
    IL_007B: stfld 0x04000626
    IL_007C: ldarg.0
    IL_007D: ldc.i4.0
    IL_0082: stfld 0x04000628
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000637
    IL_0089: conv.r8
    IL_008A: IL_C9
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_0092: brfalse IL_022A
    IL_0093: ldarg.0
    IL_0094: dup
    IL_0099: ldfld 0x04000626
    IL_009E: call 0x0A000024
    IL_009F: IL_58
    IL_00A4: stfld 0x04000626
    IL_00A5: ldarg.0
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x04000626
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x04000623
    IL_00B2: conv.i2
    IL_00B3: IL_5A
    IL_00B4: not
    IL_00B9: stfld 0x04000624
    IL_00BA: ldarg.0
    IL_00BB: ldarg.0
    IL_00C0: ldfld 0x04000624
    IL_00C1: ldarg.0
    IL_00C6: ldfld 0x04000621
    IL_00C7: mul
    IL_00C8: conv.i2
    IL_00CD: stfld 0x0400062F
    IL_00CE: ldarg.0
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x04000624
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x04000621
    IL_00DB: add
    IL_00E0: stfld 0x04000630
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x04000624
    IL_00E7: ldarg.0
    IL_00EC: ldfld 0x04000625
    IL_00F1: beq IL_022A
    IL_00F2: ldarg.0
    IL_00F7: ldfld 0x04000624
    IL_00F8: ldarg.0
    IL_00FD: ldfld 0x04000627
    IL_00FE: IL_3F
    IL_00FF: IL_37
    IL_0100: nop
    IL_0101: nop
    IL_0102: nop
    IL_0103: ldarg.0
    IL_0108: ldfld 0x04000637
    IL_0109: ldc.i4.0
    IL_010A: conv.r8
    IL_010F: beq IL_20A0110
    IL_0114: call 0x0A00000A
    IL_0115: ldc.i4.0
    IL_0116: conv.r8
    IL_0117: stloc.1
    IL_0118: nop
    IL_0119: nop
    IL_011A: stloc.0
    IL_011B: ldarg.0
    IL_0120: ldfld 0x04000638
    IL_0121: ldc.i4.0
    IL_0122: conv.r8
    IL_0124: ldc.i4.s 0
    IL_0125: nop
    IL_0126: stloc.0
    IL_0127: ldarg.0
    IL_0128: ldc.i4.0
    IL_012D: stfld 0x04000634
    IL_012E: ldarg.0
    IL_012F: ldc.i4.m1
    IL_0134: stfld 0x04000625
    IL_0139: br IL_0198
    IL_013A: ldarg.0
    IL_013F: ldfld 0x04000624
    IL_0140: ldarg.0
    IL_0145: ldfld 0x0400062A
    IL_014A: beq IL_015E
    IL_014B: ldarg.0
    IL_0150: ldfld 0x04000624
    IL_0151: ldarg.0
    IL_0156: ldfld 0x0400062A
    IL_0157: ldc.i4.1
    IL_0158: IL_58
    IL_0215: switch (46 cases)
    IL_0216: ldloc.0
    IL_0217: nop
    IL_0218: ldarg.2
    IL_0219: conv.r8
    IL_021A: conv.r8
    IL_021B: IL_01
    IL_021C: nop
    IL_021D: stloc.0
    IL_021E: ldarg.0
    IL_021F: ldarg.0
    IL_0224: ldfld 0x04000624
    IL_0229: stfld 0x04000625
    IL_022A: ret
    }

    }}
