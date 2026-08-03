// Namespace: 
// Type: ImageNumber_temp

    public class ImageNumber_temp {{

    private static object SIZE;
    public object imagenumber;
    public object number;
    public object num;
    private object index;
    private object uvAnimationTileX;
    private object uvAnimationTileY;
    private object size_a;

    public ImageNumber_temp() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.6
    IL_0006: newarr 0x01000014
    IL_000B: stfld 0x04000732
    IL_000C: ldarg.0
    IL_000D: ldc.i4.6
    IL_0012: newarr 0x0100000B
    IL_0017: stfld 0x04000733
    IL_0018: ldarg.0
    IL_0019: ldc.i4.5
    IL_001E: stfld 0x04000736
    IL_001F: ldarg.0
    IL_0020: ldc.i4.2
    IL_0025: stfld 0x04000737
    IL_0026: ldarg.0
    IL_002B: call 0x0A000001
    IL_002C: ret
    }

    private void Start() {
    IL_0000: ret
    }

    private void Update() {
    IL_0000: ret
    }

    public void ImageNum() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000738
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_0039
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000733
    IL_0014: ldloc.0
    IL_0015: ldarg.1
    IL_0017: ldc.i4.s 10
    IL_0018: mul
    IL_0019: ldelem.i8
    IL_001A: ldarg.1
    IL_001C: ldc.i4.s 10
    IL_001D: add
    IL_001F: starg.s 1
    IL_0020: ldarg.1
    IL_0025: brfalse IL_0035
    IL_0026: ldarg.0
    IL_0027: dup
    IL_002C: ldfld 0x04000738
    IL_002D: ldc.i4.1
    IL_002E: IL_58
    IL_002F: neg
    IL_0034: stfld 0x04000738
    IL_0035: ldloc.0
    IL_0036: ldc.i4.1
    IL_0037: IL_58
    IL_0038: stloc.0
    IL_0039: ldloc.0
    IL_003A: ldc.i4.4
    IL_003B: IL_3F
    IL_003C: IL_CE
    IL_003D: IL_FF
    IL_003E: IL_FF
    IL_003F: IL_FF
    IL_0040: ldc.i4.0
    IL_0041: stloc.1
    IL_0046: br IL_00D0
    IL_0047: ldarg.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000733
    IL_004E: ldloc.1
    IL_004F: IL_94
    IL_0054: stfld 0x04000735
    IL_0056: ldloca.s 2
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005E: stsfld 0x367B023F
    IL_005F: ldloc.1
    IL_0060: nop
    IL_0061: ldarg.2
    IL_0062: conv.i2
    IL_0063: add
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_006B: stsfld 0x377B023F
    IL_006C: ldloc.1
    IL_006D: nop
    IL_006E: ldarg.2
    IL_006F: conv.i2
    IL_0070: add
    IL_0075: call 0x0A000038
    IL_0076: ldarg.0
    IL_007B: ldfld 0x04000735
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000736
    IL_0082: mul
    IL_0083: conv.i2
    IL_0084: stloc.3
    IL_0085: ldarg.0
    IL_008A: ldfld 0x04000735
    IL_008B: ldarg.0
    IL_0090: ldfld 0x04000736
    IL_0091: add
    IL_0093: stloc.s 4
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000732
    IL_009A: ldloc.1
    IL_009B: IL_8F
    IL_009C: ldnull
    IL_009D: nop
    IL_009E: nop
    IL_009F: IL_01
    IL_00A0: ldloc.3
    IL_00A2: ldloca.s 2
    IL_00A7: ldfld 0x0A000059
    IL_00A8: IL_5A
    IL_00A9: IL_22
    IL_00AA: nop
    IL_00AB: nop
    IL_00B0: stsfld 0x7B02123F
    IL_00B1: IL_5A
    IL_00B2: nop
    IL_00B3: nop
    IL_00B4: stloc.0
    IL_00B5: IL_59
    IL_00B7: ldloc.s 4
    IL_00B8: conv.i2
    IL_00BA: ldloca.s 2
    IL_00BF: ldfld 0x0A00005A
    IL_00C0: IL_5A
    IL_00C1: IL_59
    IL_00C6: newobj 0x0A000038
    IL_00C7: IL_81
    IL_00C8: ldnull
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: IL_01
    IL_00CC: ldloc.1
    IL_00CD: ldc.i4.1
    IL_00CE: IL_58
    IL_00CF: stloc.1
    IL_00D0: ldloc.1
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x04000738
    IL_00D7: IL_3F
    IL_00D8: conv.i2
    IL_00D9: IL_FF
    IL_00DA: IL_FF
    IL_00DB: IL_FF
    IL_00DC: ldarg.0
    IL_00E1: ldfld 0x04000732
    IL_00E2: ret
    }

    }}
