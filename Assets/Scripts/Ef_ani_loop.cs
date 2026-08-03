// Namespace: 
// Type: Ef_ani_loop

    public class Ef_ani_loop {{

    public object uvAnimationTileX;
    public object uvAnimationTileY;
    public object framesPerSecond;
    public object impact;
    public object loop;
    public object sharedmtl;
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
    private object mycollider;

    public Ef_ani_loop() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: stfld 0x0400054E
    IL_0007: ldarg.0
    IL_0008: ldc.i4.4
    IL_000D: stfld 0x0400054F
    IL_000E: ldarg.0
    IL_0010: ldc.i4.s 20
    IL_0015: stfld 0x04000550
    IL_0016: ldarg.0
    IL_0017: ldc.i4.1
    IL_001C: stfld 0x04000551
    IL_001D: ldarg.0
    IL_001E: ldc.i4.m1
    IL_0023: stfld 0x04000555
    IL_0024: ldarg.0
    IL_0029: call 0x0A000001
    IL_002A: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_000B: stfld 0x0400055C
    IL_000C: ldarg.0
    IL_0011: call 0x0A000003
    IL_0016: call 0x0A00004A
    IL_001B: brfalse IL_0040
    IL_001C: ldarg.0
    IL_001D: ldarg.0
    IL_0022: call 0x0A000003
    IL_0027: stfld 0x0400055E
    IL_0028: ldarg.0
    IL_002D: ldfld 0x0400055E
    IL_002E: ldc.i4.0
    IL_002F: conv.r8
    IL_0031: ldc.i4.s 0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: ldfld 0x0400055E
    IL_003A: ldc.i4.1
    IL_003B: conv.r8
    IL_003C: conv.ovf.i4.un
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000556
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400054E
    IL_0012: ldarg.0
    IL_0017: ldfld 0x0400054F
    IL_0018: IL_5A
    IL_001D: stfld 0x04000557
    IL_001E: ldarg.0
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0026: stsfld 0x4E7B023F
    IL_0027: ldarg.3
    IL_0028: nop
    IL_0029: ldarg.2
    IL_002A: conv.i2
    IL_002B: add
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_0033: stsfld 0x4F7B023F
    IL_0034: ldarg.3
    IL_0035: nop
    IL_0036: ldarg.2
    IL_0037: conv.i2
    IL_0038: add
    IL_003D: newobj 0x0A000038
    IL_0042: stfld 0x04000558
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000553
    IL_004D: brfalse IL_0064
    IL_004E: ldarg.0
    IL_004F: ldarg.0
    IL_0054: ldfld 0x0400055C
    IL_0055: conv.r8
    IL_0056: neg
    IL_0057: nop
    IL_0058: nop
    IL_0059: stloc.0
    IL_005E: stfld 0x0400055D
    IL_0063: br IL_0075
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x0400055C
    IL_006B: conv.r8
    IL_006D: ldarg.s 0
    IL_006E: nop
    IL_006F: stloc.0
    IL_0074: stfld 0x0400055D
    IL_0075: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400055C
    IL_0006: conv.r8
    IL_0007: IL_C9
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: brfalse IL_0172
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x04000556
    IL_001B: call 0x0A000024
    IL_001C: IL_58
    IL_0021: stfld 0x04000556
    IL_0022: ldarg.0
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000556
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000550
    IL_002F: conv.i2
    IL_0030: IL_5A
    IL_0031: not
    IL_0036: stfld 0x04000554
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000552
    IL_0041: brfalse IL_0055
    IL_0042: ldarg.0
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000554
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000557
    IL_004F: mul
    IL_0054: stfld 0x04000554
    IL_0055: ldarg.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04000554
    IL_005C: ldarg.0
    IL_0061: ldfld 0x0400054E
    IL_0062: mul
    IL_0063: conv.i2
    IL_0068: stfld 0x0400055A
    IL_0069: ldarg.0
    IL_006A: ldarg.0
    IL_006F: ldfld 0x04000554
    IL_0070: ldarg.0
    IL_0075: ldfld 0x0400054E
    IL_0076: add
    IL_007B: stfld 0x0400055B
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000554
    IL_0082: ldarg.0
    IL_0087: ldfld 0x04000555
    IL_008C: beq IL_0172
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000554
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04000557
    IL_0099: IL_3F
    IL_009B: bge.s IL_009C
    IL_009C: nop
    IL_009D: nop
    IL_009E: ldarg.0
    IL_009F: IL_22
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: nop
    IL_00A8: stfld 0x04000556
    IL_00A9: ldarg.0
    IL_00AA: ldc.i4.m1
    IL_00AF: stfld 0x04000555
    IL_00B0: ldarg.0
    IL_00B5: call 0x0A00000A
    IL_00B6: ldc.i4.0
    IL_00B7: conv.r8
    IL_00B8: stloc.1
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: stloc.0
    IL_00BC: ldarg.0
    IL_00C1: ldfld 0x0400055E
    IL_00C2: ldc.i4.0
    IL_00C3: conv.r8
    IL_00C5: ldc.i4.s 0
    IL_00C6: nop
    IL_00C7: stloc.0
    IL_00CC: br IL_00EA
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000554
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000551
    IL_00D9: IL_3F
    IL_00DA: stloc.2
    IL_00DB: nop
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x0400055E
    IL_00E4: ldc.i4.1
    IL_00E5: conv.r8
    IL_00E7: ldc.i4.s 0
    IL_00E8: nop
    IL_00E9: stloc.0
    IL_00EA: ldarg.0
    IL_00EF: call 0x0A000082
    IL_00F0: ldarg.0
    IL_00F5: ldfld 0x0400055A
    IL_00FA: call 0x0A000083
    IL_00FB: ldarg.0
    IL_0100: ldflda 0x04000558
    IL_0105: ldfld 0x0A000059
    IL_010A: call 0x0A000083
    IL_010F: call 0x0A0000AA
    IL_0110: IL_22
    IL_0111: nop
    IL_0112: nop
    IL_0117: stsfld 0x587C023F
    IL_0118: ldarg.3
    IL_0119: nop
    IL_011A: ldarg.2
    IL_011F: ldfld 0x0A00005A
    IL_0120: IL_59
    IL_0121: ldarg.0
    IL_0126: ldfld 0x0400055B
    IL_0127: conv.i2
    IL_0128: ldarg.0
    IL_012D: ldflda 0x04000558
    IL_0132: ldfld 0x0A00005A
    IL_0133: IL_5A
    IL_0134: IL_59
    IL_0139: call 0x0A000083
    IL_013E: call 0x0A0000AB
    IL_0143: stfld 0x04000559
    IL_0144: ldarg.0
    IL_0149: ldfld 0x0400055D
    IL_014A: ldarg.0
    IL_014F: ldfld 0x04000559
    IL_0150: conv.r8
    IL_0151: IL_B4
    IL_0152: nop
    IL_0153: nop
    IL_0154: stloc.0
    IL_0155: ldarg.0
    IL_015A: ldfld 0x0400055D
    IL_015B: ldarg.0
    IL_0160: ldfld 0x04000558
    IL_0161: conv.r8
    IL_0162: conv.r8
    IL_0163: IL_01
    IL_0164: nop
    IL_0165: stloc.0
    IL_0166: ldarg.0
    IL_0167: ldarg.0
    IL_016C: ldfld 0x04000554
    IL_0171: stfld 0x04000555
    IL_0172: ret
    }

    }}
