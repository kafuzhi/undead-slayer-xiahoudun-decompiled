// Namespace: 
// Type: Icon_Stage

    public class Icon_Stage {{

    public object _index;
    public object _kind;
    public object _play;
    private object _name;
    private object _isclear;

    public Icon_Stage() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    public void IconDown() {
    IL_0004: ldstr 0x70000BD5
    IL_0009: call 0x0A000004
    IL_000A: conv.r8
    IL_000D: ldarg 0
    IL_000F: br.s IL_0012
    IL_0014: ldfld 0x04000722
    IL_0015: ldarg.0
    IL_001A: ldfld 0x04000723
    IL_001B: ldarg.0
    IL_0020: call 0x0A000002
    IL_0021: conv.r8
    IL_0022: ldc.i4.2
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000724
    IL_002C: conv.r8
    IL_0031: castclass 0x2A060006
    }

    }}
