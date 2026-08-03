// Namespace: 
// Type: Ef_rotfog

    public class Ef_rotfog {{

    private object fogheight;
    private object fogspeed;
    private object fogrotation;
    private object fogalpha;
    private object xyratio;
    private object transColor;
    private object targetColor;
    private object currentColor;
    private object plusV;
    private object mytransform;
    private object mymaterial;

    public Ef_rotfog() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040005DB
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0013: conv.r8
    IL_0015: ldarg.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x040005DC
    IL_001D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040005DB
    IL_000A: call 0x0A00001B
    IL_000B: conv.r8
    IL_000C: IL_AF
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_3F
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_3F
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_3F
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0029: newobj 0x0A0000C4
    IL_002E: stfld 0x040005D8
    IL_002F: ret
    }

    public void RotfogOn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040005DB
    IL_0016: call 0x0A00004B
    IL_0017: IL_22
    IL_0018: ldelem.i
    IL_0019: IL_99
    IL_001A: IL_99
    IL_001B: IL_3E
    IL_0020: call 0x0A000008
    IL_0021: conv.r8
    IL_0022: IL_AF
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_0027: ldarg.1
    IL_002C: stfld 0x040005D2
    IL_002D: ldarg.0
    IL_002E: ldarg.2
    IL_0033: stfld 0x040005D3
    IL_0034: ldarg.0
    IL_0035: ldarg.3
    IL_003A: stfld 0x040005D4
    IL_003B: ldarg.0
    IL_003D: ldarg.s 4
    IL_0042: stfld 0x040005D5
    IL_0043: ldarg.0
    IL_0045: ldarg.s 5
    IL_004A: stfld 0x040005D6
    IL_004B: ldarg.0
    IL_0050: ldfld 0x040005DC
    IL_0055: ldstr 0x70000B47
    IL_005A: call 0x0A0000C5
    IL_005B: conv.r8
    IL_005C: IL_C6
    IL_005D: nop
    IL_005E: nop
    IL_005F: stloc.0
    IL_0060: ldarg.0
    IL_0061: ldarg.0
    IL_0066: ldfld 0x040005D3
    IL_0067: ldarg.0
    IL_006C: ldfld 0x040005D3
    IL_006D: ldarg.0
    IL_0072: ldfld 0x040005D6
    IL_0073: IL_5A
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040005D3
    IL_007E: newobj 0x0A000076
    IL_0083: stfld 0x040005DA
    IL_0084: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040005DC
    IL_000B: ldstr 0x70000B47
    IL_000C: conv.r8
    IL_000D: IL_C7
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: stfld 0x040005D9
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040005DB
    IL_001C: conv.r8
    IL_0021: cpobj 0x0A0A0000
    IL_0023: ldloca.s 0
    IL_0028: ldfld 0x0A000023
    IL_0029: ldarg.0
    IL_002E: ldfld 0x040005D2
    IL_002F: IL_43
    IL_0031: ldloc.s 0
    IL_0032: nop
    IL_0033: nop
    IL_0034: ldarg.0
    IL_0039: call 0x0A00000A
    IL_003A: ldc.i4.0
    IL_003B: conv.r8
    IL_003C: stloc.1
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0044: br IL_0125
    IL_0045: ldarg.0
    IL_004A: ldfld 0x040005DB
    IL_004B: conv.r8
    IL_0050: cpobj 0x0B0A0000
    IL_0052: ldloca.s 1
    IL_0057: ldfld 0x0A000023
    IL_0058: ldarg.0
    IL_005D: ldfld 0x040005D2
    IL_005E: IL_22
    IL_005F: nop
    IL_0060: nop
    IL_0061: nop
    IL_0062: IL_3F
    IL_0063: IL_5A
    IL_0064: IL_43
    IL_0065: shl
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: ldarg.0
    IL_006E: ldfld 0x040005DB
    IL_006F: dup
    IL_0070: conv.r8
    IL_0075: cpobj 0x020A0000
    IL_007A: ldfld 0x040005DA
    IL_007F: call 0x0A000024
    IL_0084: call 0x0A000008
    IL_0089: call 0x0A000029
    IL_008A: conv.r8
    IL_008B: IL_AF
    IL_008C: nop
    IL_008D: nop
    IL_008E: stloc.0
    IL_008F: ldarg.0
    IL_0090: ldarg.0
    IL_0095: ldfld 0x040005D9
    IL_0096: ldarg.0
    IL_009B: ldfld 0x040005D8
    IL_00A0: call 0x0A000024
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x040005D5
    IL_00A7: conv.i2
    IL_00A8: IL_5A
    IL_00AD: call 0x0A0000C8
    IL_00B2: stfld 0x040005D7
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x040005DC
    IL_00BD: ldstr 0x70000B47
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x040005D7
    IL_00C4: conv.r8
    IL_00C5: IL_C6
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: stloc.0
    IL_00CD: br IL_0125
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x040005DB
    IL_00D4: dup
    IL_00D5: conv.r8
    IL_00DA: cpobj 0x020A0000
    IL_00DF: ldfld 0x040005DA
    IL_00E4: call 0x0A000024
    IL_00E9: call 0x0A000008
    IL_00EE: call 0x0A000029
    IL_00EF: conv.r8
    IL_00F0: IL_AF
    IL_00F1: nop
    IL_00F2: nop
    IL_00F3: stloc.0
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x040005DB
    IL_00FA: dup
    IL_00FB: conv.r8
    IL_00FC: div.un
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: stloc.0
    IL_0104: call 0x0A000007
    IL_0105: ldarg.0
    IL_010A: ldfld 0x040005D4
    IL_010B: conv.i2
    IL_0110: call 0x0A000008
    IL_0115: call 0x0A000024
    IL_011A: call 0x0A000008
    IL_011F: call 0x0A000029
    IL_0120: conv.r8
    IL_0121: IL_78
    IL_0122: IL_01
    IL_0123: nop
    IL_0124: stloc.0
    IL_0125: ret
    }

    }}
