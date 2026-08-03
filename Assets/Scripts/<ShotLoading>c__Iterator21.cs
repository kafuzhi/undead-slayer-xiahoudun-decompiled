// Namespace: 
// Type: <ShotLoading>c__Iterator21

    internal sealed class <ShotLoading>c__Iterator21 {{

    private object _index;
    private object $PC;
    private object $current;
    private object <$>_index;
    private object <>f__this;

    public <ShotLoading>c__Iterator21() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010B2
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010B2
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010B1
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010B1
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_44
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00A3
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040010B4
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040010B4
    IL_0031: ldfld 0x04000FA7
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040010B0
    IL_0038: ldelem.i
    IL_003D: newobj 0x0A0001FB
    IL_0042: stfld 0x04000FAB
    IL_0043: ldarg.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040010B4
    IL_004E: ldfld 0x04000FAB
    IL_0053: stfld 0x040010B2
    IL_0054: ldarg.0
    IL_0055: ldc.i4.1
    IL_005A: stfld 0x040010B1
    IL_005F: br IL_00A5
    IL_0060: ldarg.0
    IL_0065: ldfld 0x040010B4
    IL_006A: ldfld 0x04000FAB
    IL_006B: conv.r8
    IL_006C: IL_AD
    IL_006D: IL_01
    IL_006E: nop
    IL_006F: stloc.0
    IL_0074: brtrue IL_0090
    IL_0075: ldarg.0
    IL_007A: ldfld 0x040010B4
    IL_007B: ldarg.0
    IL_0080: ldfld 0x040010B4
    IL_0085: ldfld 0x04000FAB
    IL_0086: conv.r8
    IL_0087: IL_FC
    IL_0088: IL_01
    IL_0089: nop
    IL_008A: stloc.0
    IL_008F: stfld 0x04000FA8
    IL_0090: ldarg.0
    IL_0095: ldfld 0x040010B4
    IL_0096: ldc.i4.1
    IL_009B: stfld 0x04000FA9
    IL_009C: ldarg.0
    IL_009D: ldc.i4.m1
    IL_00A2: stfld 0x040010B1
    IL_00A3: ldc.i4.0
    IL_00A4: ret
    IL_00A5: ldc.i4.1
    IL_00A6: ret
    IL_00A7: ldloc.1
    IL_00A8: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010B1
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
