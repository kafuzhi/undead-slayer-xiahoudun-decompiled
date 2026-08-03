// Namespace: 
// Type: <Petrify>c__Iterator1

    internal sealed class <Petrify>c__Iterator1 {{

    private object <_rate>__0;
    private object $PC;
    private object $current;
    private object <>f__this;

    public <Petrify>c__Iterator1() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001008
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001008
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001007
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001007
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00FD
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0024: ldc.i4.s 100
    IL_0029: call 0x0A000045
    IL_002E: stfld 0x04001006
    IL_002F: ldarg.0
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0037: ldc.i4 6714176
    IL_0038: nop
    IL_0039: stloc.0
    IL_003E: stfld 0x04001008
    IL_003F: ldarg.0
    IL_0040: ldc.i4.1
    IL_0045: stfld 0x04001007
    IL_004A: br IL_00FF
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04001009
    IL_0055: ldfld 0x04000032
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04001006
    IL_005C: conv.i2
    IL_005D: IL_43
    IL_005F: ldloc.s 0
    IL_0060: nop
    IL_0061: nop
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04001009
    IL_0068: ldc.i4.0
    IL_006D: call 0x06000013
    IL_0072: br IL_00F6
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04001009
    IL_007D: call 0x0A00000A
    IL_007E: ldc.i4.8
    IL_007F: conv.r8
    IL_0080: ldc.i4.m1
    IL_0081: nop
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04001009
    IL_008E: ldfld 0x0400001E
    IL_0093: ldstr 0x7000005B
    IL_0094: conv.r8
    IL_0096: brfalse.s IL_0097
    IL_0097: nop
    IL_0098: stloc.0
    IL_0099: conv.r8
    IL_009A: stloc.3
    IL_009B: nop
    IL_009C: nop
    IL_009D: stloc.0
    IL_009E: conv.r8
    IL_009F: neg
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04001009
    IL_00AD: ldfld 0x04000016
    IL_00AE: conv.r8
    IL_00B0: ldarga.s 0
    IL_00B1: nop
    IL_00B2: stloc.0
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x04001009
    IL_00B9: ldc.i4.1
    IL_00BE: stfld 0x04000022
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x04001009
    IL_00C9: ldfld 0x0400005B
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04001009
    IL_00D4: ldfld 0x0400002B
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x04001009
    IL_00DF: ldfld 0x0400002C
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04001009
    IL_00EA: ldfld 0x0400001E
    IL_00EB: IL_22
    IL_00EC: IL_CD
    IL_00ED: IL_CC
    IL_00EE: IL_CC
    IL_00EF: IL_3E
    IL_00F0: ldc.i4.0
    IL_00F1: conv.r8
    IL_00F2: ldnull
    IL_00F3: ldarg.1
    IL_00F4: nop
    IL_00F5: ldloc.0
    IL_00F6: ldarg.0
    IL_00F7: ldc.i4.m1
    IL_00FC: stfld 0x04001007
    IL_00FD: ldc.i4.0
    IL_00FE: ret
    IL_00FF: ldc.i4.1
    IL_0100: ret
    IL_0101: ldloc.1
    IL_0102: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001007
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
