// Namespace: 
// Type: <ResetTimeScale>c__IteratorB

    internal sealed class <ResetTimeScale>c__IteratorB {{

    private object $PC;
    private object $current;
    private object <>f__this;

    public <ResetTimeScale>c__IteratorB() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001029
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001029
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001028
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001028
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 361716776960
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001029
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001028
    IL_003C: br IL_0077
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0044: stsfld 0x0111283F
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x0400102A
    IL_0051: ldfld 0x040003CC
    IL_0052: conv.r8
    IL_0053: IL_3E
    IL_0054: nop
    IL_0055: nop
    IL_0057: br.s IL_006E
    IL_0058: ldarg.0
    IL_005D: ldfld 0x0400102A
    IL_0062: ldfld 0x040003E3
    IL_0063: conv.r8
    IL_0064: ldc.i4.2
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ldc.i4.0
    IL_0069: conv.r8
    IL_006A: ldind.ref
    IL_006B: ldarg.0
    IL_006C: nop
    IL_006D: ldloc.0
    IL_006E: ldarg.0
    IL_006F: ldc.i4.m1
    IL_0074: stfld 0x04001028
    IL_0075: ldc.i4.0
    IL_0076: ret
    IL_0077: ldc.i4.1
    IL_0078: ret
    IL_0079: ldloc.1
    IL_007A: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001028
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
