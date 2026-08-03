// Namespace: 
// Type: Ef_splash_uv

    public class Ef_splash_uv {{

    private object uvAnimationTileX;
    private object uvAnimationTileY;
    private object framesPerSecond;
    private object index;
    private object starttime;
    private object currenttime;
    private object lastframe;
    private object var;
    private object cha1;
    private object ascraps;

    public Ef_splash_uv() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: stfld 0x040005E9
    IL_0007: ldarg.0
    IL_0008: ldc.i4.4
    IL_000D: stfld 0x040005EA
    IL_000E: ldarg.0
    IL_0010: ldc.i4.s 30
    IL_0015: stfld 0x040005EB
    IL_0016: ldarg.0
    IL_001B: call 0x0A000001
    IL_001C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_0007: conv.r8
    IL_0008: IL_44
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: conv.r8
    IL_000D: stloc.0
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: stfld 0x040005F1
    IL_0016: ldarg.0
    IL_001B: ldstr 0x700024CB
    IL_0020: call 0x0A000077
    IL_0025: stfld 0x040005F2
    IL_0026: ldarg.0
    IL_002B: ldfld 0x040005F1
    IL_002C: conv.r8
    IL_002D: IL_FF
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: ldarg.0
    IL_0036: call 0x0A000003
    IL_003B: call 0x0A00017B
    IL_003C: ldarg.0
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0046: stfld 0x040005EE
    IL_0047: ldarg.0
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_0051: stfld 0x040005ED
    IL_0052: ldarg.0
    IL_0053: ldarg.0
    IL_0058: ldfld 0x040005E9
    IL_0059: ldarg.0
    IL_005E: ldfld 0x040005EA
    IL_005F: IL_5A
    IL_0064: stfld 0x040005EF
    IL_0065: ldarg.0
    IL_006A: call 0x0A00000D
    IL_006B: ldc.i4.0
    IL_006C: conv.r8
    IL_0071: beq IL_20A0072
    IL_0076: call 0x0A000002
    IL_007B: call 0x0A00001B
    IL_007C: conv.r8
    IL_007D: IL_AF
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ldarg.0
    IL_0086: call 0x0A000003
    IL_0087: ldc.i4.1
    IL_0088: conv.r8
    IL_0089: conv.ovf.i4.un
    IL_008A: nop
    IL_008B: nop
    IL_008C: stloc.0
    IL_008D: ldarg.0
    IL_0092: call 0x0A000003
    IL_0093: ldc.i4.0
    IL_0094: conv.r8
    IL_0096: ldc.i4.s 0
    IL_0097: nop
    IL_0098: stloc.0
    IL_0099: ret
    }

    public void SplashOn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040005F2
    IL_000C: conv.r8
    IL_000D: ldarg.3
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: IL_4E
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_001B: call 0x0A000002
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_00AC: switch (34 cases)
    IL_00AD: conv.r8
    IL_00AE: IL_22
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: stloc.0
    IL_00B2: IL_22
    IL_00B3: IL_CD
    IL_00B4: IL_CC
    IL_00B5: IL_CC
    IL_00B6: IL_3D
    IL_00BB: call 0x0A000008
    IL_00C0: call 0x0A000029
    IL_00C1: conv.r8
    IL_00C2: ldloc.3
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: stloc.0
    IL_00C6: ldarg.0
    IL_00CB: call 0x0A000002
    IL_00D0: call 0x0A000013
    IL_00D1: conv.r8
    IL_00D3: ldarga.s 1
    IL_00D4: nop
    IL_00D5: stloc.0
    IL_00D6: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000D
    IL_0006: conv.r8
    IL_0007: IL_C9
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: brfalse IL_01C1
    IL_0010: ldarg.0
    IL_0015: call 0x0A0000E9
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040005ED
    IL_001C: IL_59
    IL_0021: stfld 0x040005EE
    IL_0022: ldarg.0
    IL_0023: ldarg.0
    IL_0028: ldfld 0x040005EE
    IL_0029: ldarg.0
    IL_002E: ldfld 0x040005EB
    IL_002F: conv.i2
    IL_0030: IL_5A
    IL_0035: stfld 0x040005EC
    IL_0036: ldarg.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x040005EC
    IL_003D: ldarg.0
    IL_0042: ldfld 0x040005EF
    IL_0043: conv.i2
    IL_0044: mul
    IL_0045: not
    IL_0046: conv.i2
    IL_004B: stfld 0x040005EC
    IL_004C: ldarg.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x040005F0
    IL_0053: ldarg.0
    IL_0058: ldfld 0x040005EC
    IL_0059: not
    IL_005A: IL_59
    IL_005F: stfld 0x040005F0
    IL_0061: ldloca.s 0
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0069: stsfld 0xE97B023F
    IL_006A: ldarg.3
    IL_006B: nop
    IL_006C: ldarg.2
    IL_006D: conv.i2
    IL_006E: add
    IL_006F: IL_22
    IL_0070: nop
    IL_0071: nop
    IL_0076: stsfld 0xEA7B023F
    IL_0077: ldarg.3
    IL_0078: nop
    IL_0079: ldarg.2
    IL_007A: conv.i2
    IL_007B: add
    IL_0080: call 0x0A000038
    IL_0081: ldarg.0
    IL_0086: ldfld 0x040005EC
    IL_0087: ldarg.0
    IL_008C: ldfld 0x040005E9
    IL_008D: conv.i2
    IL_008E: mul
    IL_008F: stloc.1
    IL_0090: ldarg.0
    IL_0095: ldfld 0x040005EC
    IL_0096: not
    IL_0097: ldarg.0
    IL_009C: ldfld 0x040005E9
    IL_009D: add
    IL_009E: stloc.2
    IL_00A0: ldloca.s 3
    IL_00A1: ldloc.1
    IL_00A3: ldloca.s 0
    IL_00A8: ldfld 0x0A000059
    IL_00A9: IL_5A
    IL_00AA: IL_22
    IL_00AB: nop
    IL_00AC: nop
    IL_00B1: stsfld 0x7B00123F
    IL_00B2: IL_5A
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: IL_59
    IL_00B7: ldloc.2
    IL_00B8: conv.i2
    IL_00BA: ldloca.s 0
    IL_00BF: ldfld 0x0A00005A
    IL_00C0: IL_5A
    IL_00C1: IL_59
    IL_00C6: call 0x0A000038
    IL_00C7: ldarg.0
    IL_00CC: ldfld 0x040005EC
    IL_00CD: IL_22
    IL_00CE: nop
    IL_00CF: nop
    IL_00D0: nop
    IL_00D1: nop
    IL_03CE: switch (190 cases)
    }

    }}
