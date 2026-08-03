// Namespace: 
// Type: Ef_ani_walk

    public class Ef_ani_walk {{

    private object framesPerSecond;
    private object uvAnimationTileX;
    private object uvAnimationTileY;
    private object index;
    private object oldindex;
    private object starttime;
    private object lastframe;
    private object mytransform;
    private object size;
    private object offset;
    private object uIndex;
    private object vIndex;
    private object loopcount;
    private object targetloopcount;
    private object mymaterial;
    private object anistart;
    private object ani_img;
    private object script_ui;
    private object ani_index;

    public Ef_ani_walk() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 16
    IL_0007: stfld 0x0400056F
    IL_0008: ldarg.0
    IL_0009: ldc.i4.4
    IL_000E: stfld 0x04000570
    IL_000F: ldarg.0
    IL_0010: ldc.i4.4
    IL_0015: stfld 0x04000571
    IL_0016: ldarg.0
    IL_0017: ldc.i4.m1
    IL_001C: stfld 0x04000573
    IL_001D: ldarg.0
    IL_0022: call 0x0A000001
    IL_0023: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000576
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0013: conv.r8
    IL_0015: ldarg.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x0400057D
    IL_001D: ldarg.0
    IL_0022: ldstr 0x70000BD5
    IL_0027: call 0x0A000004
    IL_0028: conv.r8
    IL_002B: ldarg 0
    IL_002D: br.s IL_00AB
    IL_0032: stsfld 0x2A040005
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000574
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000570
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000571
    IL_0018: IL_5A
    IL_001D: stfld 0x04000575
    IL_001E: ldarg.0
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0026: stsfld 0x707B023F
    IL_0027: ldarg.3
    IL_0028: nop
    IL_0029: ldarg.2
    IL_002A: conv.i2
    IL_002B: add
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_0033: stsfld 0x717B023F
    IL_0034: ldarg.3
    IL_0035: nop
    IL_0036: ldarg.2
    IL_0037: conv.i2
    IL_0038: add
    IL_003D: newobj 0x0A000038
    IL_0042: stfld 0x04000577
    IL_0043: ldarg.0
    IL_0048: call 0x0A00000A
    IL_0049: ldc.i4.0
    IL_004A: conv.r8
    IL_004B: stloc.1
    IL_004C: nop
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: ret
    }

    public void AniStart() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x04000581
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: nop
    IL_001D: stfld 0x04000574
    IL_001E: ldarg.0
    IL_001F: ldc.i4.0
    IL_0024: stfld 0x04000572
    IL_0025: ldarg.0
    IL_0026: ldc.i4.m1
    IL_002B: stfld 0x04000573
    IL_002C: ldarg.0
    IL_0031: call 0x0A0000AA
    IL_0032: IL_22
    IL_0033: nop
    IL_0034: nop
    IL_0039: stsfld 0x777C023F
    IL_003A: ldarg.3
    IL_003B: nop
    IL_003C: ldarg.2
    IL_0041: ldfld 0x0A00005A
    IL_0042: IL_59
    IL_0047: call 0x0A000083
    IL_004C: stfld 0x04000578
    IL_004D: ldarg.0
    IL_0052: ldfld 0x0400057D
    IL_0057: ldstr 0x700023C1
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000578
    IL_005E: conv.r8
    IL_0063: ldobj 0x030A0001
    IL_0068: brtrue IL_00B0
    IL_0069: ldarg.0
    IL_006E: ldstr 0x700023D3
    IL_0073: call 0x0A000012
    IL_0074: conv.u8
    IL_0075: IL_3C
    IL_0076: nop
    IL_0077: nop
    IL_0078: IL_01
    IL_007D: stfld 0x0400057F
    IL_007E: ldarg.0
    IL_0083: call 0x0A00000D
    IL_0084: conv.r8
    IL_0086: ldarg.s 0
    IL_0087: nop
    IL_0088: stloc.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x0400057F
    IL_008F: conv.r8
    IL_0091: ldarga.s 0
    IL_0092: nop
    IL_0093: stloc.0
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000576
    IL_009E: call 0x0A00001B
    IL_009F: conv.r8
    IL_00A0: IL_AF
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A4: ldarg.0
    IL_00A5: ldc.i4.3
    IL_00AA: stfld 0x0400057C
    IL_00AF: br IL_020C
    IL_00B0: ldarg.1
    IL_00B1: ldc.i4.2
    IL_01FA: switch (81 cases)
    IL_01FB: ldloc.2
    IL_01FC: nop
    IL_01FD: nop
    IL_01FE: stloc.0
    IL_01FF: conv.r8
    IL_0200: IL_AF
    IL_0201: nop
    IL_0202: nop
    IL_0203: stloc.0
    IL_0204: ldarg.0
    IL_0206: ldc.i4.s 100
    IL_020B: stfld 0x0400057C
    IL_020C: ldarg.0
    IL_020D: ldc.i4.1
    IL_0212: stfld 0x0400057E
    IL_0213: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000576
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000576
    IL_000C: conv.r8
    IL_0011: cpobj 0x280A0000
    IL_0012: localloc
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_20BE: switch (2088 cases)
    }

    }}
