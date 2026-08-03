// Namespace: 
// Type: Ef_ani_loop_simple

    public class Ef_ani_loop_simple {{

    public object uvAnimationTileX;
    public object uvAnimationTileY;
    public object framesPerSecond;
    public object loop;
    public object instance_material;
    public object timetune;
    private object index;
    private object oldindex;
    private object starttime;
    private object lastframe;
    private object size;
    private object offset;
    private object uIndex;
    private object vIndex;
    private object myrenderer;
    private object mymaterial;

    public Ef_ani_loop_simple() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: stfld 0x0400055F
    IL_0007: ldarg.0
    IL_0008: ldc.i4.4
    IL_000D: stfld 0x04000560
    IL_000E: ldarg.0
    IL_0010: ldc.i4.s 20
    IL_0015: stfld 0x04000561
    IL_0016: ldarg.0
    IL_0017: ldc.i4.m1
    IL_001C: stfld 0x04000566
    IL_001D: ldarg.0
    IL_0022: call 0x0A000001
    IL_0023: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_000B: stfld 0x0400056D
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000567
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400055F
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000560
    IL_0018: IL_5A
    IL_001D: stfld 0x04000568
    IL_001E: ldarg.0
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0026: stsfld 0x5F7B023F
    IL_0027: ldarg.3
    IL_0028: nop
    IL_0029: ldarg.2
    IL_002A: conv.i2
    IL_002B: add
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_0033: stsfld 0x607B023F
    IL_0034: ldarg.3
    IL_0035: nop
    IL_0036: ldarg.2
    IL_0037: conv.i2
    IL_0038: add
    IL_003D: newobj 0x0A000038
    IL_0042: stfld 0x04000569
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000563
    IL_004D: brtrue IL_0064
    IL_004E: ldarg.0
    IL_004F: ldarg.0
    IL_0054: ldfld 0x0400056D
    IL_0055: conv.r8
    IL_0056: neg
    IL_0057: nop
    IL_0058: nop
    IL_0059: stloc.0
    IL_005E: stfld 0x0400056E
    IL_0063: br IL_0075
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x0400056D
    IL_006B: conv.r8
    IL_006D: ldarg.s 0
    IL_006E: nop
    IL_006F: stloc.0
    IL_0074: stfld 0x0400056E
    IL_0075: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400056D
    IL_0006: conv.r8
    IL_0007: IL_C9
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: brfalse IL_017B
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000564
    IL_001A: brtrue IL_0032
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x04000567
    IL_0026: call 0x0A000024
    IL_0027: IL_58
    IL_002C: stfld 0x04000567
    IL_0031: br IL_0059
    IL_0036: call 0x0A000093
    IL_0037: IL_22
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_0040: beq IL_0059
    IL_0041: ldarg.0
    IL_0042: dup
    IL_0047: ldfld 0x04000567
    IL_004C: call 0x0A000024
    IL_0051: call 0x0A000093
    IL_0052: add
    IL_0053: IL_58
    IL_0058: stfld 0x04000567
    IL_0059: ldarg.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000567
    IL_0060: ldarg.0
    IL_0065: ldfld 0x04000561
    IL_0066: conv.i2
    IL_0067: IL_5A
    IL_0068: not
    IL_006D: stfld 0x04000565
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000562
    IL_0078: brfalse IL_008C
    IL_0079: ldarg.0
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000565
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000568
    IL_0086: mul
    IL_008B: stfld 0x04000565
    IL_008C: ldarg.0
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000565
    IL_0093: ldarg.0
    IL_0098: ldfld 0x0400055F
    IL_0099: mul
    IL_009A: conv.i2
    IL_009F: stfld 0x0400056B
    IL_00A0: ldarg.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000565
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x0400055F
    IL_00AD: add
    IL_00B2: stfld 0x0400056C
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x04000565
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x04000566
    IL_00C3: beq IL_017B
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x04000565
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04000568
    IL_00D0: IL_3F
    IL_00D1: ldc.i4.8
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: nop
    IL_00D5: ldarg.0
    IL_00D6: IL_22
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: nop
    IL_00DF: stfld 0x04000567
    IL_00E0: ldarg.0
    IL_00E1: ldc.i4.m1
    IL_00E6: stfld 0x04000566
    IL_00E7: ldarg.0
    IL_00EC: call 0x0A00000A
    IL_00ED: ldc.i4.0
    IL_00EE: conv.r8
    IL_00EF: stloc.1
    IL_00F0: nop
    IL_00F1: nop
    IL_00F2: stloc.0
    IL_00F3: ldarg.0
    IL_00F8: call 0x0A000082
    IL_00F9: ldarg.0
    IL_00FE: ldfld 0x0400056B
    IL_0103: call 0x0A000083
    IL_0104: ldarg.0
    IL_0109: ldflda 0x04000569
    IL_010E: ldfld 0x0A000059
    IL_0113: call 0x0A000083
    IL_0118: call 0x0A0000AA
    IL_0119: IL_22
    IL_011A: nop
    IL_011B: nop
    IL_0120: stsfld 0x697C023F
    IL_0121: ldarg.3
    IL_0122: nop
    IL_0123: ldarg.2
    IL_0128: ldfld 0x0A00005A
    IL_0129: IL_59
    IL_012A: ldarg.0
    IL_012F: ldfld 0x0400056C
    IL_0130: conv.i2
    IL_0131: ldarg.0
    IL_0136: ldflda 0x04000569
    IL_013B: ldfld 0x0A00005A
    IL_013C: IL_5A
    IL_013D: IL_59
    IL_0142: call 0x0A000083
    IL_0147: call 0x0A0000AB
    IL_014C: stfld 0x0400056A
    IL_014D: ldarg.0
    IL_0152: ldfld 0x0400056E
    IL_0153: ldarg.0
    IL_0158: ldfld 0x0400056A
    IL_0159: conv.r8
    IL_015A: IL_B4
    IL_015B: nop
    IL_015C: nop
    IL_015D: stloc.0
    IL_015E: ldarg.0
    IL_0163: ldfld 0x0400056E
    IL_0164: ldarg.0
    IL_0169: ldfld 0x04000569
    IL_016A: conv.r8
    IL_016B: conv.r8
    IL_016C: IL_01
    IL_016D: nop
    IL_016E: stloc.0
    IL_016F: ldarg.0
    IL_0170: ldarg.0
    IL_0175: ldfld 0x04000565
    IL_017A: stfld 0x04000566
    IL_017B: ret
    }

    }}
