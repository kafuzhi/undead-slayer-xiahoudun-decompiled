// Namespace: 
// Type: <GetFacebookImg>c__Iterator1D

    internal sealed class <GetFacebookImg>c__Iterator1D {{

    private object _url;
    private object <www>__0;
    private object _index;
    private object $PC;
    private object $current;
    private object <$>_url;
    private object <$>_index;
    private object <>f__this;

    public <GetFacebookImg>c__Iterator1D() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400109B
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400109B
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400109A
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400109A
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
    IL_0020: br IL_008D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001097
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x04001098
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04001098
    IL_003D: stfld 0x0400109B
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x0400109A
    IL_0049: br IL_008F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04001098
    IL_0050: conv.r8
    IL_0051: IL_FC
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_0056: conv.u4
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldc.i4.8
    IL_005B: IL_3E
    IL_005C: pop
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400109E
    IL_006A: ldfld 0x04000B20
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04001099
    IL_0071: IL_8F
    IL_0073: ldarg.s 1
    IL_0074: nop
    IL_0075: ldarg.0
    IL_0076: ldarg.0
    IL_007B: ldfld 0x04001098
    IL_007C: conv.r8
    IL_007D: IL_FC
    IL_007E: IL_01
    IL_007F: nop
    IL_0080: stloc.0
    IL_0085: stfld 0x04000B4D
    IL_0086: ldarg.0
    IL_0087: ldc.i4.m1
    IL_008C: stfld 0x0400109A
    IL_008D: ldc.i4.0
    IL_008E: ret
    IL_008F: ldc.i4.1
    IL_0090: ret
    IL_0091: ldloc.1
    IL_0092: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400109A
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
