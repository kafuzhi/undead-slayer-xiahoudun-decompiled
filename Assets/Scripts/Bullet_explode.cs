// Namespace: 
// Type: Bullet_explode

    public class Bullet_explode {{

    private object pt1;
    private object pt2;
    private object ptm;
    private object c_delay;
    private object mytransform;
    private object c_emit;
    public object distance;

    public Bullet_explode() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001AC
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040001AC
    IL_0013: ldc.i4.1
    IL_0014: conv.r8
    IL_0019: brtrue IL_7D0A001A
    IL_001A: IL_A8
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: ldarg.2
    IL_001E: ldarg.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040001AC
    IL_0025: ldc.i4.2
    IL_0026: conv.r8
    IL_002B: brtrue IL_7D0A002C
    IL_002C: IL_A9
    IL_002D: IL_01
    IL_002E: nop
    IL_002F: ldarg.2
    IL_0030: ldarg.0
    IL_0031: ldarg.0
    IL_0036: ldfld 0x040001AC
    IL_0037: ldc.i4.0
    IL_0038: conv.r8
    IL_003D: brtrue IL_7D0A003E
    IL_003E: IL_AA
    IL_003F: IL_01
    IL_0040: nop
    IL_0041: ldarg.2
    IL_0042: ldarg.0
    IL_0047: ldfld 0x040001AA
    IL_0048: conv.r8
    IL_0049: ret
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_0051: ldstr 0x70000B3F
    IL_0052: conv.r8
    IL_0054: bge.s IL_0055
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: IL_22
    IL_0059: bne.un.s IL_008D
    IL_005A: conv.ovf.i4.un
    IL_005B: IL_3E
    IL_005C: conv.r8
    IL_005E: bgt.s IL_005F
    IL_005F: nop
    IL_0060: stloc.0
    IL_0061: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001A8
    IL_0006: conv.r8
    IL_0007: IL_B0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: IL_B6
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040001A9
    IL_0017: conv.r8
    IL_0018: IL_B0
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldc.i4.1
    IL_001D: conv.r8
    IL_001E: IL_B6
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040001AA
    IL_0028: conv.r8
    IL_0029: ret
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_0031: ldstr 0x70000B3F
    IL_0032: conv.r8
    IL_0033: IL_3C
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: pop
    IL_0038: ldarg.0
    IL_003D: call 0x0A000003
    IL_003E: ldc.i4.1
    IL_003F: conv.r8
    IL_0041: ldc.i4.s 0
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040001AC
    IL_004A: dup
    IL_004B: conv.r8
    IL_004C: ldc.i4.2
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x040001AC
    IL_0056: conv.r8
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x040001AE
    IL_0065: call 0x0A000008
    IL_006A: call 0x0A000029
    IL_006B: conv.r8
    IL_006C: ldloc.3
    IL_006D: nop
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040001AB
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040001AB
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040001AB
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_C0
    IL_001C: IL_3F
    IL_001D: IL_43
    IL_001E: IL_52
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040001AA
    IL_0028: conv.r8
    IL_0029: ret
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_0031: ldstr 0x70000B3F
    IL_0032: conv.r8
    IL_0033: IL_C3
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: ldarg.0
    IL_003C: call 0x0A00000A
    IL_003D: ldc.i4.0
    IL_003E: conv.r8
    IL_003F: stloc.1
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ldarg.0
    IL_0048: ldfld 0x040001AC
    IL_004D: call 0x0A00004B
    IL_004E: IL_22
    IL_004F: nop
    IL_0050: nop
    IL_0051: IL_C8
    IL_0052: IL_41
    IL_0057: call 0x0A000008
    IL_0058: conv.r8
    IL_0059: ldloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_005E: IL_22
    IL_005F: nop
    IL_0060: nop
    IL_0061: nop
    IL_0062: nop
    IL_0067: stfld 0x040001AB
    IL_0068: ldarg.0
    IL_0069: ldc.i4.0
    IL_006E: stfld 0x040001AD
    IL_0073: br IL_00C9
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040001AD
    IL_007E: brfalse IL_0084
    IL_0083: br IL_00C9
    IL_0084: ldarg.0
    IL_0089: ldfld 0x040001AB
    IL_008A: IL_22
    IL_008B: nop
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_3F
    IL_008F: IL_43
    IL_0090: IL_35
    IL_0091: nop
    IL_0092: nop
    IL_0093: nop
    IL_0094: ldarg.0
    IL_0099: ldfld 0x040001A8
    IL_009A: conv.r8
    IL_009B: IL_B0
    IL_009C: nop
    IL_009D: nop
    IL_009E: stloc.0
    IL_009F: ldc.i4.0
    IL_00A0: conv.r8
    IL_00A1: IL_B6
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A5: ldarg.0
    IL_00AA: ldfld 0x040001A9
    IL_00AB: conv.r8
    IL_00AC: IL_B0
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B0: ldc.i4.0
    IL_00B1: conv.r8
    IL_00B2: IL_B6
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00BB: call 0x0A000003
    IL_00BC: ldc.i4.0
    IL_00BD: conv.r8
    IL_00BF: ldc.i4.s 0
    IL_00C0: nop
    IL_00C1: stloc.0
    IL_00C2: ldarg.0
    IL_00C3: ldc.i4.1
    IL_00C8: stfld 0x040001AD
    IL_00C9: ret
    }

    }}
