// Namespace: 
// Type: <Start>c__Iterator8

    internal sealed class <Start>c__Iterator8 {{

    private object $PC;
    private object $current;
    private object <>f__this;

    public <Start>c__Iterator8() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101E
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101E
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101D
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400101D
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_37
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_005A
    IL_0021: ldarg.0
    IL_0026: ldfld 0x0400101F
    IL_002B: ldstr 0x70000CD1
    IL_0030: call 0x0A0000F9
    IL_0035: stfld 0x04000282
    IL_0036: ldarg.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x0400101F
    IL_0041: ldfld 0x04000282
    IL_0046: stfld 0x0400101E
    IL_0047: ldarg.0
    IL_0048: ldc.i4.1
    IL_004D: stfld 0x0400101D
    IL_0052: br IL_005C
    IL_0053: ldarg.0
    IL_0054: ldc.i4.m1
    IL_0059: stfld 0x0400101D
    IL_005A: ldc.i4.0
    IL_005B: ret
    IL_005C: ldc.i4.1
    IL_005D: ret
    IL_005E: ldloc.1
    IL_005F: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400101D
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
