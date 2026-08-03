// Namespace: 
// Type: <GetMyFacebookImg>c__Iterator1B

    internal sealed class <GetMyFacebookImg>c__Iterator1B {{

    private object _url;
    private object <www>__0;
    private object $PC;
    private object $current;
    private object <$>_url;

    public <GetMyFacebookImg>c__Iterator1B() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400108C
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400108C
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400108B
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400108B
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0051
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001089
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x0400108A
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400108A
    IL_003D: stfld 0x0400108C
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x0400108B
    IL_0049: br IL_0053
    IL_004A: ldarg.0
    IL_004B: ldc.i4.m1
    IL_0050: stfld 0x0400108B
    IL_0051: ldc.i4.0
    IL_0052: ret
    IL_0053: ldc.i4.1
    IL_0054: ret
    IL_0055: ldloc.1
    IL_0056: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400108B
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
