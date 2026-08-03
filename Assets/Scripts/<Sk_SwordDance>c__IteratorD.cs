// Namespace: 
// Type: <Sk_SwordDance>c__IteratorD

    internal sealed class <Sk_SwordDance>c__IteratorD {{

    private object <comein>__0;
    private object $PC;
    private object $current;
    private object <>f__this;

    public <Sk_SwordDance>c__IteratorD() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001030
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001030
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400102F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400102F
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 542105403392
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001030
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x0400102F
    IL_003C: br IL_00A1
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001031
    IL_0047: ldfld 0x040003E4
    IL_0048: conv.r8
    IL_004B: ldloc 0
    IL_004C: stloc.0
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04001031
    IL_0058: ldfld 0x040003E4
    IL_005D: ldstr 0x70000F3F
    IL_005E: conv.r8
    IL_0063: newobj 0x7D0A0000
    IL_0065: beq.s IL_0076
    IL_0066: nop
    IL_0067: ldarg.2
    IL_0068: ldarg.0
    IL_006D: ldfld 0x0400102E
    IL_006E: IL_22
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: IL_3F
    IL_0073: conv.r8
    IL_0075: bgt.s IL_0076
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04001031
    IL_0082: ldfld 0x040003B1
    IL_0083: conv.r8
    IL_0084: IL_C7
    IL_0085: IL_01
    IL_0086: nop
    IL_0087: ldloc.0
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04001031
    IL_0092: ldfld 0x040003B0
    IL_0093: conv.r8
    IL_0094: conv.u4
    IL_0095: IL_01
    IL_0096: nop
    IL_0097: ldloc.0
    IL_0098: ldarg.0
    IL_0099: ldc.i4.m1
    IL_009E: stfld 0x0400102F
    IL_009F: ldc.i4.0
    IL_00A0: ret
    IL_00A1: ldc.i4.1
    IL_00A2: ret
    IL_00A3: ldloc.1
    IL_00A4: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400102F
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
