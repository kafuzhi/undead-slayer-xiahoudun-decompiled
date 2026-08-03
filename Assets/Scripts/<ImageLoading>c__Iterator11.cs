// Namespace: 
// Type: <ImageLoading>c__Iterator11

    internal sealed class <ImageLoading>c__Iterator11 {{

    private object _url;
    private object <www>__0;
    private object _imagecount;
    private object $PC;
    private object $current;
    private object <$>_url;
    private object <$>_imagecount;
    private object <>f__this;

    public <ImageLoading>c__Iterator11() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001055
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001055
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001054
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001054
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
    IL_0020: br IL_00A2
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001051
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x04001052
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04001052
    IL_003D: stfld 0x04001055
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x04001054
    IL_0049: br IL_00A4
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04001052
    IL_0050: conv.r8
    IL_0051: IL_AD
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0059: brtrue IL_0077
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04001058
    IL_0064: ldfld 0x04000882
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04001053
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04001052
    IL_0071: conv.r8
    IL_0072: IL_FC
    IL_0073: IL_01
    IL_0074: nop
    IL_0075: stloc.0
    IL_007A: stelem 0x10587B02
    IL_007B: nop
    IL_007C: ldarg.2
    IL_0081: ldfld 0x04000888
    IL_0082: ldc.i4.1
    IL_0083: IL_59
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04001053
    IL_00BE: switch (12 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001054
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
