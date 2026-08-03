// Namespace: 
// Type: <GetFaceBookMe>c__Iterator1A

    internal sealed class <GetFaceBookMe>c__Iterator1A {{

    private object <url>__0;
    private object <www>__1;
    private object <myprofile>__2;
    private object <aa>__3;
    private object $PC;
    private object $current;
    private object <>f__this;

    public <GetFaceBookMe>c__Iterator1A() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001087
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001087
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001086
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001086
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_001C: brfalse IL_3800001D
    IL_001D: ldelem.i4
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ldarg.0
    IL_0026: ldstr 0x70023451
    IL_002B: stfld 0x04001082
    IL_002C: ldarg.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04001082
    IL_0037: newobj 0x0A0001FB
    IL_003C: stfld 0x04001083
    IL_003D: ldarg.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04001083
    IL_0048: stfld 0x04001087
    IL_0049: ldarg.0
    IL_004A: ldc.i4.1
    IL_004F: stfld 0x04001086
    IL_0054: br IL_00C0
    IL_0055: ldarg.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04001083
    IL_005C: conv.r8
    IL_005D: IL_AE
    IL_005E: IL_01
    IL_005F: nop
    IL_0060: stloc.0
    IL_0065: stfld 0x04001084
    IL_0066: ldarg.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04001084
    IL_0071: call 0x0A0002FC
    IL_0076: stfld 0x04001085
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04001088
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04001088
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04001085
    IL_008D: ldstr 0x700234BB
    IL_008E: conv.r8
    IL_008F: IL_FD
    IL_0090: ldarg.0
    IL_0091: nop
    IL_0092: stloc.0
    IL_0097: ldstr 0x700234CB
    IL_0098: conv.r8
    IL_0099: IL_FD
    IL_009A: ldarg.0
    IL_009B: nop
    IL_009C: stloc.0
    IL_00A1: ldstr 0x700234D5
    IL_00A2: conv.r8
    IL_00A3: IL_FD
    IL_00A4: ldarg.0
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00AB: call 0x0A0002FE
    IL_00B0: call 0x060005FA
    IL_00B5: call 0x0A000047
    IL_00B6: pop
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4.m1
    IL_00BD: stfld 0x04001086
    IL_00BE: ldc.i4.0
    IL_00BF: ret
    IL_00C0: ldc.i4.1
    IL_00C1: ret
    IL_00C2: ldloc.1
    IL_00C3: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001086
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
