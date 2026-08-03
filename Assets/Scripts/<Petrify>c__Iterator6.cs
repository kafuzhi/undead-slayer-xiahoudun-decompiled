// Namespace: 
// Type: <Petrify>c__Iterator6

    internal sealed class <Petrify>c__Iterator6 {{

    private object <_rate>__0;
    private object $PC;
    private object $current;
    private object <>f__this;

    public <Petrify>c__Iterator6() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001018
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001018
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001017
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001017
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
    IL_0020: br IL_00F3
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0024: ldc.i4.s 100
    IL_0029: call 0x0A000045
    IL_002E: stfld 0x04001016
    IL_002F: ldarg.0
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0037: ldc.i4 6714176
    IL_0038: nop
    IL_0039: stloc.0
    IL_003E: stfld 0x04001018
    IL_003F: ldarg.0
    IL_0040: ldc.i4.1
    IL_0045: stfld 0x04001017
    IL_004A: br IL_00F5
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04001019
    IL_0055: ldfld 0x0400007D
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04001016
    IL_005C: IL_3E
    IL_005E: ldloc.s 0
    IL_005F: nop
    IL_0060: nop
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04001019
    IL_0067: ldc.i4.0
    IL_006C: call 0x06000027
    IL_0071: br IL_00EC
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04001019
    IL_007C: call 0x0A00000A
    IL_007D: ldc.i4.8
    IL_007E: conv.r8
    IL_007F: ldc.i4.m1
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04001019
    IL_008D: ldfld 0x040000AA
    IL_008E: conv.r8
    IL_0090: ldarg.s 0
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04001019
    IL_009D: ldfld 0x0400006B
    IL_009E: conv.r8
    IL_00A0: ldarga.s 0
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04001019
    IL_00A9: ldc.i4.1
    IL_00AE: stfld 0x0400006C
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04001019
    IL_00B9: ldfld 0x0400009E
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04001019
    IL_00C4: ldfld 0x04000084
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04001019
    IL_00CF: ldfld 0x04000082
    IL_00D0: ldarg.0
    IL_00D5: ldfld 0x04001019
    IL_00DA: ldfld 0x040000A7
    IL_00DB: ldarg.0
    IL_00E0: ldfld 0x04001019
    IL_00E5: ldfld 0x04000080
    IL_00E6: ldc.i4.0
    IL_00E7: conv.r8
    IL_00E8: ldnull
    IL_00E9: ldarg.1
    IL_00EA: nop
    IL_00EB: ldloc.0
    IL_00EC: ldarg.0
    IL_00ED: ldc.i4.m1
    IL_00F2: stfld 0x04001017
    IL_00F3: ldc.i4.0
    IL_00F4: ret
    IL_00F5: ldc.i4.1
    IL_00F6: ret
    IL_00F7: ldloc.1
    IL_00F8: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001017
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
