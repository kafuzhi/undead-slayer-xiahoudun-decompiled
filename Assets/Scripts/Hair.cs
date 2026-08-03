// Namespace: 
// Type: Hair

    public class Hair {{

    private object chamovestat;

    public Hair() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x2B00004A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_000C: beq IL_2A0A000D
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_0007: conv.r8
    IL_0008: IL_44
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: conv.r8
    IL_000D: stloc.2
    IL_000E: nop
    IL_000F: nop
    IL_0011: br.s IL_008D
    IL_0012: IL_BC
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: ldarg.2
    IL_001A: stfld 0x040006A0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040006A0
    IL_0021: ldc.i4.2
    IL_0022: IL_3C
    IL_0024: ldloc.s 0
    IL_0025: nop
    IL_0026: nop
    IL_0027: ldarg.0
    IL_002C: call 0x2B00004A
    IL_002D: ldc.i4.0
    IL_002E: conv.r8
    IL_0033: beq IL_380A0034
    IL_0034: stloc.2
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: ldarg.0
    IL_003D: call 0x2B00004A
    IL_003E: ldc.i4.1
    IL_003F: conv.r8
    IL_0044: beq IL_2A0A0045
    }

    }}
