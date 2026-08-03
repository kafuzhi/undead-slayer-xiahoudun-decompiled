// Namespace: 
// Type: Footstep

    public class Footstep {{

    private object script_cha;
    private object chamovestat;
    private object turnon;
    private object s_delay;
    private object myparticle;

    public Footstep() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A0000B0
    IL_000B: stfld 0x04000669
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000002
    IL_0013: conv.r8
    IL_0014: IL_CD
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: conv.r8
    IL_0019: stloc.2
    IL_001A: nop
    IL_001B: nop
    IL_001D: br.s IL_009B
    IL_001E: shl
    IL_001F: ldloc.0
    IL_0020: nop
    IL_0021: ldarg.2
    IL_0022: ldarg.0
    IL_0027: call 0x0A0000B0
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: IL_B6
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000668
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_3F
    IL_000B: IL_43
    IL_000C: IL_58
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000665
    IL_001B: ldfld 0x040002BC
    IL_0020: stfld 0x04000666
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000666
    IL_0027: ldc.i4.2
    IL_00B8: switch (35 cases)
    }

    }}
