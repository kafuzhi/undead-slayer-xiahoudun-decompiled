// Namespace: 
// Type: Ef_twirl

    public class Ef_twirl {{

    private object uvAnimationTileX;
    private object uvAnimationTileY;
    private object framesPerSecond;
    private object index;
    private object oldindex;
    private object starttime;
    private object lastframe;
    private object isloop;
    private object myrenderer;
    private object size;
    private object offset;
    private object uIndex;
    private object vIndex;

    public Ef_twirl() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: stfld 0x0400063F
    IL_0007: ldarg.0
    IL_0008: ldc.i4.4
    IL_000D: stfld 0x04000640
    IL_000E: ldarg.0
    IL_0013: ldc.i4 180
    IL_0018: stfld 0x04000641
    IL_0019: ldarg.0
    IL_001E: call 0x0A000001
    IL_001F: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_000B: stfld 0x04000647
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000644
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400063F
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000640
    IL_0018: IL_5A
    IL_001D: stfld 0x04000645
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000647
    IL_0024: ldc.i4.0
    IL_0025: conv.r8
    IL_002A: beq IL_2A0A002B
    }

    public void TwirlOn() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x0400063F
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_000D: stfld 0x04000640
    IL_000E: ldarg.0
    IL_000F: ldarg.3
    IL_0014: stfld 0x04000641
    IL_0015: ldarg.0
    IL_001A: ldfld 0x04000647
    IL_001B: ldc.i4.1
    IL_001C: conv.r8
    IL_0021: beq IL_20A0022
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_002B: stfld 0x04000644
    IL_002C: ldarg.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x0400063F
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000640
    IL_0039: IL_5A
    IL_003E: stfld 0x04000645
    IL_003F: ldarg.0
    IL_0041: ldarg.s 4
    IL_0046: stfld 0x04000646
    IL_0047: ldarg.0
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004F: stsfld 0x3F7B023F
    IL_0050: ldloc.0
    IL_0051: nop
    IL_0052: ldarg.2
    IL_0053: conv.i2
    IL_0054: add
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_005C: stsfld 0x407B023F
    IL_005D: ldloc.0
    IL_005E: nop
    IL_005F: ldarg.2
    IL_0060: conv.i2
    IL_0061: add
    IL_0066: newobj 0x0A000038
    IL_006B: stfld 0x04000648
    IL_006C: ret
    }

    public void TwirlOff() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000647
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: beq IL_2A0A000D
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000647
    IL_0006: conv.r8
    IL_0007: IL_C9
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: brfalse IL_0135
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x04000644
    IL_001B: call 0x0A000024
    IL_001C: IL_58
    IL_0021: stfld 0x04000644
    IL_0022: ldarg.0
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000644
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000641
    IL_002F: conv.i2
    IL_0030: IL_5A
    IL_0031: not
    IL_0036: stfld 0x04000642
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000646
    IL_0041: brfalse IL_0055
    IL_0042: ldarg.0
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000642
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000645
    IL_004F: mul
    IL_0054: stfld 0x04000642
    IL_0055: ldarg.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04000642
    IL_005C: ldarg.0
    IL_0061: ldfld 0x0400063F
    IL_0062: mul
    IL_0063: conv.i2
    IL_0068: stfld 0x0400064A
    IL_0069: ldarg.0
    IL_006A: ldarg.0
    IL_006F: ldfld 0x04000642
    IL_0070: ldarg.0
    IL_0075: ldfld 0x0400063F
    IL_0076: add
    IL_007B: stfld 0x0400064B
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000642
    IL_0082: ldarg.0
    IL_0087: ldfld 0x04000643
    IL_008C: beq IL_0135
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000642
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04000645
    IL_0099: IL_3F
    IL_009B: stloc.s 0
    IL_009C: nop
    IL_009D: nop
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x04000647
    IL_00A4: ldc.i4.0
    IL_00A5: conv.r8
    IL_00AA: beq IL_20A00AB
    IL_00AB: ldc.i4.m1
    IL_00B0: stfld 0x04000643
    IL_00B1: ldarg.0
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x0400064A
    IL_00B8: ldarg.0
    IL_00BD: ldflda 0x04000648
    IL_00C2: ldfld 0x0A000059
    IL_00C3: IL_5A
    IL_00C4: IL_22
    IL_00C5: nop
    IL_00C6: nop
    IL_00CB: stsfld 0x487C023F
    IL_00CC: ldloc.0
    IL_00CD: nop
    IL_00CE: ldarg.2
    IL_00D3: ldfld 0x0A00005A
    IL_00D4: IL_59
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x0400064B
    IL_00DB: conv.i2
    IL_00DC: ldarg.0
    IL_00E1: ldflda 0x04000648
    IL_00E6: ldfld 0x0A00005A
    IL_00E7: IL_5A
    IL_00E8: IL_59
    IL_00ED: newobj 0x0A000038
    IL_00F2: stfld 0x04000649
    IL_00F3: ldarg.0
    IL_00F8: ldfld 0x04000647
    IL_00F9: conv.r8
    IL_00FA: neg
    IL_00FB: nop
    IL_00FC: nop
    IL_00FD: stloc.0
    IL_0102: ldstr 0x700023C1
    IL_0103: ldarg.0
    IL_0108: ldfld 0x04000649
    IL_0109: conv.r8
    IL_010E: ldobj 0x020A0001
    IL_0113: ldfld 0x04000647
    IL_0114: conv.r8
    IL_0115: neg
    IL_0116: nop
    IL_0117: nop
    IL_0118: stloc.0
    IL_011D: ldstr 0x700023C1
    IL_011E: ldarg.0
    IL_0123: ldfld 0x04000648
    IL_0124: conv.r8
    IL_0129: ldstr 0x020A0001
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000642
    IL_0134: stfld 0x04000643
    IL_0135: ret
    }

    }}
