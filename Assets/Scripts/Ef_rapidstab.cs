// Namespace: 
// Type: Ef_rapidstab

    public class Ef_rapidstab {{

    private object index;
    private object oldindex;
    private object starttime;
    private object mytransform;
    private object myrenderer;
    private object mycollider;
    private object size;
    private object offset;
    public object showtime;
    public object uvAnimationTileX;
    public object uvAnimationTileY;
    public object framesPerSecond;
    public object damagerate;
    public object loopcount;
    private object count;
    private object lastframe;
    private object show;

    public Ef_rapidstab() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040005C2
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: ldelem.i
    IL_000A: IL_99
    IL_000B: ldc.i4.3
    IL_000C: IL_3E
    IL_0011: stfld 0x040005C9
    IL_0012: ldarg.0
    IL_0013: ldc.i4.4
    IL_0018: stfld 0x040005CA
    IL_0019: ldarg.0
    IL_001A: ldc.i4.4
    IL_001F: stfld 0x040005CB
    IL_0020: ldarg.0
    IL_0022: ldc.i4.s 18
    IL_0027: stfld 0x040005CC
    IL_0028: ldarg.0
    IL_0029: ldc.i4.2
    IL_002E: stfld 0x040005CD
    IL_002F: ldarg.0
    IL_0034: call 0x0A000001
    IL_0035: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040005C4
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0017: stfld 0x040005C5
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A000003
    IL_0023: stfld 0x040005C6
    IL_0024: ldarg.0
    IL_0029: ldfld 0x040005C6
    IL_002A: ldc.i4.0
    IL_002B: conv.r8
    IL_002D: ldc.i4.s 0
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040005C5
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: beq IL_20A000D
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0014: stsfld 0xCA7B023F
    IL_0015: ldarg.3
    IL_0016: nop
    IL_0017: ldarg.2
    IL_0018: conv.i2
    IL_0019: add
    IL_001A: IL_22
    IL_001B: nop
    IL_001C: nop
    IL_0021: stsfld 0xCB7B023F
    IL_0022: ldarg.3
    IL_0023: nop
    IL_0024: ldarg.2
    IL_0025: conv.i2
    IL_0026: add
    IL_002B: newobj 0x0A000038
    IL_0030: stfld 0x040005C7
    IL_0031: ldarg.0
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040005CA
    IL_0038: ldarg.0
    IL_003D: ldfld 0x040005CB
    IL_003E: IL_5A
    IL_0043: stfld 0x040005D0
    IL_0044: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040005D1
    IL_000A: brtrue IL_0056
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040005C3
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040005C9
    IL_0017: IL_41
    IL_0018: ldc.i4.1
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.0
    IL_001D: dup
    IL_0022: ldfld 0x040005C3
    IL_0027: call 0x0A000024
    IL_0028: IL_58
    IL_002D: stfld 0x040005C3
    IL_0032: br IL_0051
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040005C5
    IL_0039: ldc.i4.1
    IL_003A: conv.r8
    IL_003F: beq IL_20A0040
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0049: stfld 0x040005C3
    IL_004A: ldarg.0
    IL_004B: ldc.i4.1
    IL_0050: stfld 0x040005D1
    IL_0055: br IL_0236
    IL_0056: ldarg.0
    IL_005B: ldfld 0x040005C4
    IL_005C: dup
    IL_005D: conv.r8
    IL_005E: ldc.i4.2
    IL_005F: nop
    IL_0060: nop
    IL_0061: stloc.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x040005C4
    IL_0068: conv.r8
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_0071: call 0x0A000024
    IL_0076: call 0x0A000008
    IL_0077: IL_22
    IL_0078: IL_CD
    IL_0079: IL_CC
    IL_007A: IL_CC
    IL_007B: IL_3D
    IL_0080: call 0x0A000008
    IL_0085: call 0x0A000029
    IL_0086: conv.r8
    IL_0087: ldloc.3
    IL_0088: nop
    IL_0089: nop
    IL_008A: stloc.0
    IL_008B: ldarg.0
    IL_008C: dup
    IL_0091: ldfld 0x040005C3
    IL_0096: call 0x0A000024
    IL_0097: IL_58
    IL_009C: stfld 0x040005C3
    IL_009D: ldarg.0
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x040005C3
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x040005CC
    IL_00AA: conv.i2
    IL_00AB: IL_5A
    IL_00AC: not
    IL_00B1: stfld 0x040005C1
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x040005C1
    IL_00B8: ldarg.0
    IL_00BD: ldfld 0x040005CA
    IL_00BE: mul
    IL_00BF: conv.i2
    IL_00C0: stloc.0
    IL_00C1: ldarg.0
    IL_00C6: ldfld 0x040005C1
    IL_00C7: ldarg.0
    IL_00CC: ldfld 0x040005CA
    IL_00CD: add
    IL_00CE: stloc.1
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x040005C1
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x040005C2
    IL_00DF: beq IL_0236
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x040005C1
    IL_00E6: ldarg.0
    IL_00EB: ldfld 0x040005CD
    IL_00EC: mul
    IL_00ED: ldc.i4.1
    IL_0136: switch (17 cases)
    IL_0137: ldarg.2
    IL_0138: ldc.i4.0
    IL_0139: conv.r8
    IL_013E: beq IL_20A013F
    IL_0143: ldfld 0x040005C6
    IL_0144: ldc.i4.0
    IL_0145: conv.r8
    IL_0147: ldc.i4.s 0
    IL_0148: nop
    IL_0149: stloc.0
    IL_014A: ldarg.0
    IL_014F: call 0x0A00000A
    IL_0150: ldc.i4.0
    IL_0151: conv.r8
    IL_0152: stloc.1
    IL_0153: nop
    IL_0154: nop
    IL_0155: stloc.0
    IL_0156: ldarg.0
    IL_015B: ldfld 0x040005C4
    IL_0160: call 0x0A00004B
    IL_0161: IL_22
    IL_0162: nop
    IL_0163: nop
    IL_0168: ldc.i4 534593
    IL_0169: nop
    IL_016A: stloc.0
    IL_016B: conv.r8
    IL_016C: ldloc.3
    IL_016D: nop
    IL_016E: nop
    IL_016F: stloc.0
    IL_0170: ldarg.0
    IL_0171: ldc.i4.m1
    IL_0176: stfld 0x040005C2
    IL_0177: ldarg.0
    IL_0178: IL_22
    IL_0179: nop
    IL_017A: nop
    IL_017B: nop
    IL_017C: nop
    IL_0181: stfld 0x040005C3
    IL_0182: ldarg.0
    IL_0183: ldc.i4.0
    IL_0188: stfld 0x040005CF
    IL_0189: ldarg.0
    IL_018A: ldc.i4.0
    IL_018F: stfld 0x040005D1
    IL_0194: br IL_01A3
    IL_0195: ldarg.0
    IL_0196: dup
    IL_019B: ldfld 0x040005CF
    IL_019C: ldc.i4.1
    IL_019D: IL_58
    IL_01A2: stfld 0x040005CF
    IL_01A3: ldarg.0
    IL_01A4: ldc.i4.0
    IL_01A9: stfld 0x040005C1
    IL_01AA: ldarg.0
    IL_01AB: ldc.i4.m1
    IL_01B0: stfld 0x040005C2
    IL_01B1: ldarg.0
    IL_01B2: IL_22
    IL_01B3: nop
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: nop
    IL_01BB: stfld 0x040005C3
    IL_01BC: ldarg.0
    IL_01BD: ldloc.0
    IL_01BE: ldarg.0
    IL_01C3: ldflda 0x040005C7
    IL_01C8: ldfld 0x0A000059
    IL_01C9: IL_5A
    IL_01CA: IL_22
    IL_01CB: nop
    IL_01CC: nop
    IL_01D1: stsfld 0xC77C023F
    IL_01D2: ldarg.3
    IL_01D3: nop
    IL_01D4: ldarg.2
    IL_01D9: ldfld 0x0A00005A
    IL_01DA: IL_59
    IL_01DB: ldloc.1
    IL_01DC: conv.i2
    IL_01DD: ldarg.0
    IL_01E2: ldflda 0x040005C7
    IL_01E7: ldfld 0x0A00005A
    IL_01E8: IL_5A
    IL_01E9: IL_59
    IL_01EE: newobj 0x0A000038
    IL_01F3: stfld 0x040005C8
    IL_01F4: ldarg.0
    IL_01F9: ldfld 0x040005C5
    IL_01FA: conv.r8
    IL_01FB: neg
    IL_01FC: nop
    IL_01FD: nop
    IL_01FE: stloc.0
    IL_0203: ldstr 0x700023C1
    IL_0204: ldarg.0
    IL_0209: ldfld 0x040005C8
    IL_020A: conv.r8
    IL_020F: ldobj 0x020A0001
    IL_0214: ldfld 0x040005C5
    IL_0215: conv.r8
    IL_0216: neg
    IL_0217: nop
    IL_0218: nop
    IL_0219: stloc.0
    IL_021E: ldstr 0x700023C1
    IL_021F: ldarg.0
    IL_0224: ldfld 0x040005C7
    IL_0225: conv.r8
    IL_022A: ldstr 0x020A0001
    IL_022B: ldarg.0
    IL_0230: ldfld 0x040005C1
    IL_0235: stfld 0x040005C2
    IL_0236: ret
    }

    }}
