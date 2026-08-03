// Namespace: 
// Type: <ImageLoading>c__Iterator20

    internal sealed class <ImageLoading>c__Iterator20 {{

    private object _url;
    private object <www>__0;
    private object $PC;
    private object $current;
    private object <$>_url;
    private object <>f__this;

    public <ImageLoading>c__Iterator20() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010AD
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010AD
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010AC
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010AC
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
    IL_0020: br IL_007D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040010AA
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x040010AB
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040010AB
    IL_003D: stfld 0x040010AD
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x040010AC
    IL_0049: br IL_007F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040010AF
    IL_0054: ldfld 0x04000E0E
    IL_0055: conv.r8
    IL_0056: ldc.i4.8
    IL_0057: ldarg.1
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x040010AB
    IL_0060: conv.r8
    IL_0061: IL_FC
    IL_0062: IL_01
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: conv.r8
    IL_0067: ldc.i4.s 3
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: ldarg.0
    IL_006F: ldfld 0x040010AF
    IL_0070: ldc.i4.1
    IL_0075: stfld 0x04000E14
    IL_0076: ldarg.0
    IL_0077: ldc.i4.m1
    IL_007C: stfld 0x040010AC
    IL_007D: ldc.i4.0
    IL_007E: ret
    IL_007F: ldc.i4.1
    IL_0080: ret
    IL_0081: ldloc.1
    IL_0082: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010AC
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
