// Namespace: 
// Type: <Shock>c__Iterator4

    internal sealed class <Shock>c__Iterator4 {{

    private object $PC;
    private object $current;
    private object <>f__this;

    public <Shock>c__Iterator4() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001011
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001011
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001010
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001010
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 408961417216
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: ldelem.i
    IL_0024: IL_99
    IL_0025: IL_99
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001011
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001010
    IL_003C: br IL_0082
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001012
    IL_0043: ldc.i4.0
    IL_0048: stfld 0x040000AB
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04001012
    IL_0053: ldfld 0x040000AA
    IL_0054: conv.r8
    IL_0056: ldarg.s 0
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04001012
    IL_0063: ldfld 0x0400006B
    IL_0064: conv.r8
    IL_0066: ldarga.s 0
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: ldarg.0
    IL_006E: ldfld 0x04001012
    IL_0073: ldstr 0x700001F1
    IL_0078: call 0x0A00007B
    IL_0079: ldarg.0
    IL_007A: ldc.i4.m1
    IL_007F: stfld 0x04001010
    IL_0080: ldc.i4.0
    IL_0081: ret
    IL_0082: ldc.i4.1
    IL_0083: ret
    IL_0084: ldloc.1
    IL_0085: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001010
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
