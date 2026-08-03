// Namespace: 
// Type: Beam_boss11

    public class Beam_boss11 {{

    public object uvspeed;
    public object finishdelay;
    private object delay;
    private object mymaterial;
    private object offset;
    private object mytransform;
    private object rotatefactor;

    public Beam_boss11() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x01457D3F
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: nop
    IL_000E: nop
    IL_519F513: switch (21396800 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400014A
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0013: conv.r8
    IL_0014: neg
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000148
    IL_001D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000057
    IL_000A: stfld 0x04000149
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000148
    IL_0015: call 0x0A000057
    IL_0016: conv.r8
    IL_0017: IL_B4
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x0400014A
    IL_0025: call 0x0A00001B
    IL_0026: conv.r8
    IL_0027: IL_AF
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0035: stfld 0x04000147
    IL_0036: ldarg.0
    IL_0037: IL_22
    IL_0038: nop
    IL_0039: nop
    IL_003E: stsfld 0x014B7D3F
    IL_003F: nop
    IL_0040: ldarg.2
    IL_0041: ret
    }

    private void DanceHit() {
    IL_0000: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000149
    IL_000B: call 0x0A0000AA
    IL_0010: call 0x0A000024
    IL_0015: call 0x0A000083
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000145
    IL_0020: call 0x0A000083
    IL_0025: call 0x0A0000AB
    IL_002A: stfld 0x04000149
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000147
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000146
    IL_0037: IL_43
    IL_0038: IL_36
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: ldarg.0
    IL_0041: ldfld 0x0400014A
    IL_0046: call 0x0A00004B
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004A: ldc.i4.2
    IL_004B: IL_42
    IL_0050: call 0x0A000008
    IL_0051: conv.r8
    IL_0052: ldloc.3
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldarg.0
    IL_005B: call 0x0A00000A
    IL_005C: ldc.i4.0
    IL_005D: conv.r8
    IL_005E: stloc.1
    IL_005F: nop
    IL_0060: nop
    IL_0061: stloc.0
    IL_0062: ldarg.0
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: nop
    IL_0067: nop
    IL_006C: stfld 0x04000147
    IL_0071: br IL_0111
    IL_0072: ldarg.0
    IL_0073: dup
    IL_0078: ldfld 0x0400014B
    IL_007D: call 0x0A000024
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: IL_C8
    IL_0082: IL_42
    IL_0083: IL_5A
    IL_0084: IL_58
    IL_0089: stfld 0x0400014B
    IL_008A: ldarg.0
    IL_008B: dup
    IL_0090: ldfld 0x04000147
    IL_0095: call 0x0A000024
    IL_0096: IL_58
    IL_009B: stfld 0x04000147
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x04000148
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000149
    IL_00A8: conv.r8
    IL_00A9: IL_B4
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: stloc.0
    IL_00AD: ldarg.0
    IL_00B2: ldfld 0x0400014A
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x0400014A
    IL_00B9: conv.r8
    IL_00BE: cpobj 0x220A0000
    IL_00C0: bne.un.s IL_00F4
    IL_00C1: conv.ovf.i4.un
    IL_00C2: IL_3F
    IL_00C3: IL_22
    IL_00C5: bne.un.s IL_00F9
    IL_00C6: conv.ovf.i4.un
    IL_00C7: IL_3F
    IL_00C8: IL_22
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: nop
    IL_1DA9C: switch (30323 cases)
    }

    }}
