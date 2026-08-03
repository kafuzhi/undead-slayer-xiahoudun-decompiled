// Namespace: 
// Type: Ef_meteo

    public class Ef_meteo {{

    private object splash;
    private object thisIsOrigin;
    public object meteosplash;

    public Ef_meteo() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: stloc.0
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A000023
    IL_0013: IL_22
    IL_0015: bne.un.s IL_0049
    IL_0016: IL_93
    IL_6127: switch (6211 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040005B7
    IL_000A: brtrue IL_0130
    IL_000B: ldarg.0
    IL_0010: call 0x0A000002
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.1
    IL_0018: ldloca.s 1
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0024: conv.i8
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_002D: call 0x0A000002
    IL_002E: dup
    IL_002F: conv.r8
    IL_0030: div.un
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: IL_22
    IL_003A: nop
    IL_003B: nop
    IL_003C: IL_C8
    IL_003D: IL_43
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0047: newobj 0x0A000076
    IL_004C: call 0x0A000024
    IL_0051: call 0x0A000008
    IL_0056: call 0x0A000019
    IL_0057: conv.r8
    IL_0058: IL_78
    IL_0059: IL_01
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ldarg.0
    IL_0061: call 0x0A000002
    IL_0062: dup
    IL_0063: conv.r8
    IL_0064: ldc.i4.2
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: IL_22
    IL_0069: nop
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_22
    IL_006E: ldelem.i
    IL_006F: IL_99
    IL_0070: ldc.i4.3
    IL_0071: IL_C0
    IL_0072: IL_22
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_0076: nop
    IL_007B: newobj 0x0A000076
    IL_0080: call 0x0A000024
    IL_0085: call 0x0A000008
    IL_008A: call 0x0A000029
    IL_008B: conv.r8
    IL_008C: ldloc.3
    IL_008D: nop
    IL_008E: nop
    IL_008F: stloc.0
    IL_0094: br IL_0130
    IL_0095: ldarg.0
    IL_009A: ldfld 0x040005B6
    IL_009F: brtrue IL_0130
    IL_00A0: ldarg.0
    IL_00A5: call 0x0A000002
    IL_00A6: IL_22
    IL_00A7: nop
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: IL_22
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: IL_22
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: nop
    IL_00B4: nop
    IL_00B9: newobj 0x0A000076
    IL_00BA: conv.r8
    IL_00BB: IL_AF
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: stloc.0
    IL_00C3: ldstr 0x70002497
    IL_00C8: call 0x0A000077
    IL_00C9: conv.r8
    IL_00CC: starg 0
    IL_00CE: br.s IL_013E
    IL_00CF: IL_35
    IL_00D0: IL_01
    IL_00D1: nop
    IL_00D2: ldloc.0
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x040005B8
    IL_00D9: ldarg.0
    IL_00DE: call 0x0A000002
    IL_00DF: conv.r8
    IL_00E0: ldc.i4.2
    IL_00E1: nop
    IL_00E2: nop
    IL_00E3: stloc.0
    IL_00E4: stloc.2
    IL_00E6: ldloca.s 2
    IL_00EB: ldfld 0x0A00005E
    IL_00EC: IL_22
    IL_00ED: IL_CD
    IL_00EE: IL_CC
    IL_00EF: IL_4C
    IL_00F0: IL_3D
    IL_00F1: ldarg.0
    IL_00F6: call 0x0A000002
    IL_00F7: conv.r8
    IL_00F8: ldc.i4.2
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: stloc.0
    IL_00FC: stloc.3
    IL_00FE: ldloca.s 3
    IL_0103: ldfld 0x0A00005C
    IL_0108: newobj 0x0A000076
    IL_010D: call 0x0A000013
    IL_0112: call 0x0A000014
    IL_0113: conv.u4
    IL_0114: ldarg.1
    IL_0115: nop
    IL_0116: nop
    IL_0117: IL_01
    IL_0118: stloc.0
    IL_0119: ldloc.0
    IL_011A: conv.r8
    IL_011B: stloc.0
    IL_011C: nop
    IL_011D: nop
    IL_011E: stloc.0
    IL_011F: IL_22
    IL_0120: ldelem.i
    IL_0121: IL_99
    IL_0122: IL_99
    IL_0123: IL_3E
    IL_0128: call 0x0A000071
    IL_0129: ldarg.0
    IL_012A: ldc.i4.1
    IL_012F: stfld 0x040005B6
    IL_0130: ret
    }

    }}
