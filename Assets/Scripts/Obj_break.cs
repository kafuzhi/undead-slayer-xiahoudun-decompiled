// Namespace: 
// Type: Obj_break

    public class Obj_break {{

    public object isrunning;

    public Obj_break() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_000A: ldstr 0x70022924
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: stsfld 0x00306F3E
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000846
    IL_0024: brtrue IL_0035
    IL_0025: ldarg.0
    IL_002A: call 0x0A00000A
    IL_002B: IL_22
    IL_002C: ldelem.i
    IL_002D: IL_99
    IL_002E: IL_99
    IL_002F: IL_3F
    IL_0034: call 0x0A000071
    IL_0035: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000846
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: call 0x0A000002
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: stloc.0
    IL_0019: ldloca.s 0
    IL_001E: ldfld 0x0A00005C
    IL_001F: IL_22
    IL_0020: ldelem.i
    IL_0021: IL_99
    IL_0022: ldc.i4.3
    IL_0023: IL_BF
    IL_0024: IL_43
    IL_0025: IL_34
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_0029: ldarg.0
    IL_002E: call 0x0A000002
    IL_002F: dup
    IL_0030: conv.r8
    IL_0031: ldc.i4.2
    IL_0032: nop
    IL_0033: nop
    IL_0034: stloc.0
    IL_0039: call 0x0A000042
    IL_003A: IL_22
    IL_003B: shr
    IL_003C: shr
    IL_003D: IL_E6
    IL_003E: IL_BF
    IL_0043: call 0x0A000008
    IL_0048: call 0x0A000024
    IL_004D: call 0x0A000008
    IL_0052: call 0x0A000029
    IL_0053: conv.r8
    IL_0054: ldloc.3
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_005C: br IL_0068
    IL_005D: ldarg.0
    IL_0062: call 0x0A00000A
    IL_0067: call 0x0A000050
    IL_0068: ret
    }

    }}
