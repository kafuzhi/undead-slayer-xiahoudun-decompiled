// Namespace: 
// Type: <GetProfileImg>c__Iterator1E

    internal sealed class <GetProfileImg>c__Iterator1E {{

    private object _url;
    private object <www>__0;
    private object _index;
    private object $PC;
    private object $current;
    private object <$>_url;
    private object <$>_index;
    private object <>f__this;

    public <GetProfileImg>c__Iterator1E() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A3
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A3
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A2
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010A2
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
    IL_0020: br IL_00D5
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400109F
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x040010A0
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040010A0
    IL_003D: stfld 0x040010A3
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x040010A2
    IL_0049: br IL_00D7
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040010A0
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
    IL_005C: conv.r4
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x040010A6
    IL_006A: ldfld 0x04000B44
    IL_006B: stloc.1
    IL_006C: ldloc.1
    IL_006D: ldc.i4.0
    IL_0072: beq IL_0078
    IL_0077: br IL_00A3
    IL_0078: ldarg.0
    IL_007D: ldfld 0x040010A6
    IL_0082: ldfld 0x04000B21
    IL_0083: ldarg.0
    IL_0088: ldfld 0x040010A1
    IL_0089: IL_8F
    IL_008B: ldarga.s 1
    IL_008C: nop
    IL_008D: ldarg.0
    IL_008E: ldarg.0
    IL_0093: ldfld 0x040010A0
    IL_0094: conv.r8
    IL_0095: IL_FC
    IL_0096: IL_01
    IL_0097: nop
    IL_0098: stloc.0
    IL_009D: stfld 0x04000B51
    IL_00A2: br IL_00CE
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x040010A6
    IL_00AD: ldfld 0x04000B22
    IL_00AE: ldarg.0
    IL_00B3: ldfld 0x040010A1
    IL_00B4: IL_8F
    IL_00B6: starg.s 1
    IL_00B7: nop
    IL_00B8: ldarg.0
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x040010A0
    IL_00BF: conv.r8
    IL_00C0: IL_FC
    IL_00C1: IL_01
    IL_00C2: nop
    IL_00C3: stloc.0
    IL_00C8: stfld 0x04000B54
    IL_00CD: br IL_00CE
    IL_00CE: ldarg.0
    IL_00CF: ldc.i4.m1
    IL_00D4: stfld 0x040010A2
    IL_00D5: ldc.i4.0
    IL_00D6: ret
    IL_00D7: ldc.i4.1
    IL_00D8: ret
    IL_00D9: ldloc.2
    IL_00DA: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010A2
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
