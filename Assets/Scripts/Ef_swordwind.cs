// Namespace: 
// Type: Ef_swordwind

    public class Ef_swordwind {{

    private object movestart;
    private object mytransform;
    private object myrenderer;
    private object delay;
    private object originscale;

    public Ef_swordwind() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400063A
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0017: stfld 0x0400063B
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_0007: conv.r8
    IL_000C: cpobj 0x7D0A0000
    IL_000D: IL_3D
    IL_000E: ldloc.0
    IL_000F: nop
    IL_0010: ldarg.2
    IL_0011: ldarg.0
    IL_0016: ldfld 0x0400063B
    IL_0017: ldc.i4.0
    IL_0018: conv.r8
    IL_001D: beq IL_2A0A001E
    }

    private void OnEnable() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0022
    IL_0007: ldarg.0
    IL_000C: call 0x0A000002
    IL_000D: ldloc.0
    IL_000E: conv.r8
    IL_0013: brtrue IL_6F0A0014
    IL_0014: stloc.0
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldc.i4.1
    IL_0019: conv.r8
    IL_001A: stloc.1
    IL_001B: nop
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldloc.0
    IL_001F: ldc.i4.1
    IL_0020: IL_58
    IL_0021: stloc.0
    IL_0022: ldloc.0
    IL_0023: ldc.i4.2
    IL_0024: IL_3F
    IL_0025: IL_DE
    IL_0026: IL_FF
    IL_0027: IL_FF
    IL_0028: IL_FF
    IL_0029: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000639
    IL_000A: brtrue IL_0055
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400063C
    IL_0011: IL_22
    IL_0012: IL_CD
    IL_0013: IL_CC
    IL_0014: IL_4C
    IL_0015: IL_3F
    IL_0016: IL_41
    IL_0017: ldc.i4.1
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x0400063C
    IL_0026: call 0x0A000024
    IL_0027: IL_58
    IL_002C: stfld 0x0400063C
    IL_0031: br IL_0050
    IL_0032: ldarg.0
    IL_0033: ldc.i4.1
    IL_0038: stfld 0x04000639
    IL_0039: ldarg.0
    IL_003E: ldfld 0x0400063B
    IL_003F: ldc.i4.1
    IL_0040: conv.r8
    IL_0045: beq IL_20A0046
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004F: stfld 0x0400063C
    IL_0054: br IL_011B
    IL_0055: ldarg.0
    IL_005A: ldfld 0x0400063A
    IL_005B: conv.r8
    IL_0060: cpobj 0x0A0A0000
    IL_0062: ldloca.s 0
    IL_0067: ldfld 0x0A00005C
    IL_0068: IL_22
    IL_0069: nop
    IL_006A: nop
    IL_006F: stsfld 0x005F433F
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldarg.0
    IL_0077: ldfld 0x0400063A
    IL_0078: dup
    IL_0079: conv.r8
    IL_007A: ldc.i4.2
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: ldarg.0
    IL_0083: ldfld 0x0400063A
    IL_0084: conv.r8
    IL_0085: IL_22
    IL_0086: nop
    IL_0087: nop
    IL_0088: stloc.0
    IL_008D: call 0x0A000024
    IL_0092: call 0x0A000008
    IL_0097: call 0x0A000029
    IL_0098: conv.r8
    IL_0099: ldloc.3
    IL_009A: nop
    IL_009B: nop
    IL_009C: stloc.0
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x0400063A
    IL_00A3: dup
    IL_00A4: conv.r8
    IL_00A9: cpobj 0x280A0000
    IL_00AA: IL_42
    IL_00AB: nop
    IL_00AC: nop
    IL_00AD: stloc.0
    IL_00AE: IL_22
    IL_00AF: nop
    IL_00B0: nop
    IL_20A1B5: switch (534592 cases)
    }

    }}
