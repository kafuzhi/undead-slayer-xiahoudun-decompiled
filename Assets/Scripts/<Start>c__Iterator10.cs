// Namespace: 
// Type: <Start>c__Iterator10

    internal sealed class <Start>c__Iterator10 {{

    private object $PC;
    private object $current;
    private object <>f__this;

    public <Start>c__Iterator10() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104F
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400104E
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: and
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0085
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04001050
    IL_002B: ldfld 0x040007BE
    IL_002C: ldc.i4.4
    IL_0099: switch (26 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400104E
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
