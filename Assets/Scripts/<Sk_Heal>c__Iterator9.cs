// Namespace: 
// Type: <Sk_Heal>c__Iterator9

    internal sealed class <Sk_Heal>c__Iterator9 {{

    private object $PC;
    private object $current;
    private object <>f__this;

    public <Sk_Heal>c__Iterator9() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001021
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001021
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001020
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001020
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 245752659968
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: ldelem.i
    IL_0024: IL_99
    IL_0025: IL_99
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001021
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001020
    IL_003C: br IL_005C
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001022
    IL_0047: ldfld 0x040002E1
    IL_0048: conv.r8
    IL_0049: IL_B0
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldc.i4.0
    IL_004E: conv.r8
    IL_004F: IL_B6
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0054: ldc.i4.m1
    IL_0059: stfld 0x04001020
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
    IL_0006: stfld 0x04001020
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
