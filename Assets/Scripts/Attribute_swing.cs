// Namespace: 
// Type: Attribute_swing

    public class Attribute_swing {{

    public object attribute_mat;

    public Attribute_swing() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.5
    IL_0006: newarr 0x0100000A
    IL_000B: stfld 0x04000139
    IL_000C: ldarg.0
    IL_0011: call 0x0A000001
    IL_0012: ret
    }

    public void ChangeAttribute() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000D
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000139
    IL_000C: ldarg.1
    IL_000D: ldelem.i
    IL_000E: conv.r8
    IL_000F: IL_AD
    IL_0010: nop
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: call 0x2B000017
    IL_0019: ldarg.1
    IL_001A: ldarg.2
    IL_001B: conv.r8
    IL_001C: IL_C3
    IL_001D: ldarg.0
    IL_001E: nop
    IL_001F: ldloc.0
    IL_0020: ret
    }

    }}
