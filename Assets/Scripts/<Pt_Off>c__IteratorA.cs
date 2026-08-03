// Namespace: 
// Type: <Pt_Off>c__IteratorA

    internal sealed class <Pt_Off>c__IteratorA {{

    private object _pt;
    private object $PC;
    private object $current;
    private object <$>_pt;
    private object <>f__this;

    public <Pt_Off>c__IteratorA() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001025
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001025
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001024
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001024
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_27
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_005B
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001027
    IL_002C: ldfld 0x040003C0
    IL_0031: newobj 0x0A000066
    IL_0036: stfld 0x04001025
    IL_0037: ldarg.0
    IL_0038: ldc.i4.1
    IL_003D: stfld 0x04001024
    IL_0042: br IL_005D
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04001023
    IL_0049: conv.r8
    IL_004A: IL_B0
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldc.i4.0
    IL_004F: conv.r8
    IL_0050: IL_B6
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: ldarg.0
    IL_0055: ldc.i4.m1
    IL_005A: stfld 0x04001024
    IL_005B: ldc.i4.0
    IL_005C: ret
    IL_005D: ldc.i4.1
    IL_005E: ret
    IL_005F: ldloc.1
    IL_0060: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001024
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
