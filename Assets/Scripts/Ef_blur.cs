// Namespace: 
// Type: Ef_blur

    public class Ef_blur {{

    private object mymat;

    public Ef_blur() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_0007: conv.r8
    IL_0008: neg
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x0400058C
    IL_0011: ldarg.0
    IL_0016: ldfld 0x0400058C
    IL_001B: call 0x0A000057
    IL_001C: conv.r8
    IL_001D: IL_B4
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldarg.0
    IL_0026: call 0x0A00000A
    IL_0027: ldc.i4.0
    IL_0028: conv.r8
    IL_0029: stloc.1
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400058C
    IL_0006: conv.r8
    IL_000B: newobj 0x0A0A0001
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A00005A
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_001A: stsfld 0x003443BF
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400058C
    IL_0023: dup
    IL_0024: conv.r8
    IL_0029: newobj 0x280A0001
    IL_002A: IL_AA
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_0032: call 0x0A000024
    IL_0037: call 0x0A000083
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_20CE0: switch (33576 cases)
    }

    }}
