// Namespace: 
// Type: DunGate

    public class DunGate {{

    private object mytransform;
    private object arrow;
    private object cha1;
    private object delay_open;

    public DunGate() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400053C
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400053C
    IL_0013: ldc.i4.0
    IL_0014: conv.r8
    IL_0019: brtrue IL_7D0A001A
    IL_001A: IL_3D
    IL_001B: ldarg.3
    IL_001C: nop
    IL_001D: ldarg.2
    IL_001E: ldarg.0
    IL_0023: ldfld 0x0400053D
    IL_0028: call 0x0A00004B
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_B0
    IL_002D: IL_41
    IL_0032: call 0x0A000008
    IL_0033: conv.r8
    IL_0034: ldloc.3
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000003
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: IL_C0
    IL_0011: IL_3F
    IL_0016: stfld 0x0400053F
    IL_0017: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x0400053E
    IL_0015: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: ldarg.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: IL_44
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400053E
    IL_0015: call 0x0A000061
    IL_001A: brfalse IL_005C
    IL_001B: ldarg.0
    IL_0020: ldfld 0x0400053E
    IL_0021: conv.r8
    IL_0022: stloc.2
    IL_0023: nop
    IL_0024: nop
    IL_0026: br.s IL_0029
    IL_002B: call 0x0A000002
    IL_002C: conv.r8
    IL_002D: ldc.i4.2
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: conv.r8
    IL_0036: ldsfld 0x02060001
    IL_003B: call 0x0A00000A
    IL_003C: ldc.i4.0
    IL_003D: conv.r8
    IL_003E: stloc.1
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x0400053D
    IL_004C: call 0x0A00004B
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: IL_B0
    IL_0051: IL_41
    IL_0056: call 0x0A000008
    IL_0057: conv.r8
    IL_0058: ldloc.3
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400053F
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_43
    IL_000D: beq.s IL_000E
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x0400053F
    IL_001B: call 0x0A000024
    IL_001C: IL_59
    IL_0021: stfld 0x0400053F
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400053F
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_42
    IL_002E: stloc.2
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldarg.0
    IL_0037: call 0x0A000003
    IL_0038: ldc.i4.1
    IL_0039: conv.r8
    IL_003B: ldc.i4.s 0
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x0400053C
    IL_0044: conv.r8
    IL_0045: ldc.i4.2
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x0400053E
    IL_004F: conv.r8
    IL_0050: ldc.i4.2
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0058: call 0x0A000019
    IL_005D: call 0x0A000040
    IL_005E: stloc.0
    IL_005F: ldloc.0
    IL_0064: call 0x0A00001B
    IL_0069: call 0x0A00001C
    IL_006E: brfalse IL_0080
    IL_006F: ldarg.0
    IL_0074: ldfld 0x0400053D
    IL_0075: ldloc.0
    IL_007A: call 0x0A00001D
    IL_007B: conv.r8
    IL_0080: call 0x020A0000
    IL_0085: ldfld 0x0400053E
    IL_0086: conv.r8
    IL_0087: ldc.i4.2
    IL_0088: nop
    IL_0089: nop
    IL_008A: stloc.0
    IL_008F: call 0x0A000007
    IL_0090: IL_22
    IL_0091: stloc.0
    IL_0092: IL_D7
    IL_0093: stelem.i
    IL_0094: IL_3C
    IL_0099: call 0x0A000008
    IL_009E: call 0x0A000029
    IL_009F: ldloc.0
    IL_00A0: IL_22
    IL_00A1: ldelem.i
    IL_00A2: IL_99
    IL_00A3: IL_99
    IL_00A4: IL_3E
    IL_00A9: call 0x0A000008
    IL_00AE: call 0x0A000029
    IL_00AF: stloc.0
    IL_00B0: ldarg.0
    IL_00B5: ldfld 0x0400053D
    IL_00B6: ldloc.0
    IL_00B7: conv.r8
    IL_00B8: ldloc.3
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: stloc.0
    IL_00BC: ret
    }

    }}
