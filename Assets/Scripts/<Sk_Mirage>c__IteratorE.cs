// Namespace: 
// Type: <Sk_Mirage>c__IteratorE

    internal sealed class <Sk_Mirage>c__IteratorE {{

    private object $PC;
    private object $current;
    private object <>f__this;

    public <Sk_Mirage>c__IteratorE() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001033
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001033
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001032
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001032
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 383191613440
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: stsfld 0x0066733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: stfld 0x04001033
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001032
    IL_003C: br IL_007C
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001034
    IL_0047: ldfld 0x040003B1
    IL_0048: conv.r8
    IL_0049: IL_C7
    IL_004A: IL_01
    IL_004B: nop
    IL_004C: ldloc.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04001034
    IL_0057: ldfld 0x040003B0
    IL_0058: conv.r8
    IL_0059: conv.u4
    IL_005A: IL_01
    IL_005B: nop
    IL_005C: ldloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04001034
    IL_0067: call 0x0A00002A
    IL_006C: ldstr 0x700011D1
    IL_006D: conv.r8
    IL_006E: IL_3C
    IL_006F: nop
    IL_0070: nop
    IL_0071: stloc.0
    IL_0072: pop
    IL_0073: ldarg.0
    IL_0074: ldc.i4.m1
    IL_0079: stfld 0x04001032
    IL_007A: ldc.i4.0
    IL_007B: ret
    IL_007C: ldc.i4.1
    IL_007D: ret
    IL_007E: ldloc.1
    IL_007F: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001032
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
