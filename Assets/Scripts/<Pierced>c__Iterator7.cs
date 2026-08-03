// Namespace: 
// Type: <Pierced>c__Iterator7

    internal sealed class <Pierced>c__Iterator7 {{

    private object $PC;
    private object $current;
    private object <>f__this;

    public <Pierced>c__Iterator7() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101B
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101B
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101A
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400101A
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 1242185072640
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: stsfld 0x00667340
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: stfld 0x0400101B
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x0400101A
    IL_003C: br IL_0144
    IL_003D: ldarg.0
    IL_0042: ldfld 0x0400101C
    IL_0047: ldfld 0x04000082
    IL_0048: ldc.i4.0
    IL_0049: IL_3D
    IL_004B: ldloc.s 0
    IL_004C: nop
    IL_004D: nop
    IL_004E: ldarg.0
    IL_0053: ldfld 0x0400101C
    IL_0054: ldc.i4.0
    IL_0059: call 0x06000027
    IL_005E: br IL_009C
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400101C
    IL_0069: ldfld 0x0400009E
    IL_006A: ldarg.0
    IL_006F: ldfld 0x0400101C
    IL_0074: ldfld 0x04000084
    IL_0075: ldarg.0
    IL_007A: ldfld 0x0400101C
    IL_007F: ldfld 0x04000082
    IL_0080: ldarg.0
    IL_0085: ldfld 0x0400101C
    IL_008A: ldfld 0x040000A7
    IL_008B: ldarg.0
    IL_0090: ldfld 0x0400101C
    IL_0095: ldfld 0x04000080
    IL_0096: ldc.i4.0
    IL_0097: conv.r8
    IL_0098: ldnull
    IL_0099: ldarg.1
    IL_009A: nop
    IL_009B: ldloc.0
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x0400101C
    IL_00A6: ldfld 0x040000A8
    IL_00A7: conv.r8
    IL_00AA: ldloc 0
    IL_00AB: stloc.0
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x0400101C
    IL_00B6: ldfld 0x040000A8
    IL_00BB: ldstr 0x70000177
    IL_00BC: conv.r8
    IL_00BD: IL_3C
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: stloc.0
    IL_00C1: pop
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x0400101C
    IL_00CC: ldfld 0x0400009D
    IL_00CD: conv.r8
    IL_00CE: IL_35
    IL_00CF: IL_01
    IL_00D0: nop
    IL_00D1: ldloc.0
    IL_00D2: ldarg.0
    IL_00D7: ldfld 0x0400101C
    IL_00DC: ldfld 0x0400009F
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x0400101C
    IL_00E7: ldfld 0x040000A7
    IL_00E8: conv.r8
    IL_00E9: ldc.i4.2
    IL_00EA: nop
    IL_00EB: nop
    IL_00EC: stloc.0
    IL_00ED: ldarg.0
    IL_00F2: ldfld 0x0400101C
    IL_00F7: ldfld 0x04000095
    IL_00F8: conv.r8
    IL_00F9: IL_B9
    IL_00FA: ldarg.1
    IL_00FB: nop
    IL_00FC: ldloc.0
    IL_00FD: ldarg.0
    IL_0102: ldfld 0x0400101C
    IL_0103: IL_22
    IL_0104: nop
    IL_0105: nop
    IL_0106: nop
    IL_0107: nop
    IL_010C: stfld 0x0400007E
    IL_010D: ldarg.0
    IL_0112: ldfld 0x0400101C
    IL_0117: ldfld 0x0400009C
    IL_0118: ldc.i4.1
    IL_0119: conv.r8
    IL_011A: IL_EC
    IL_011B: ldarg.2
    IL_011C: nop
    IL_011D: ldloc.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x0400101C
    IL_0128: call 0x0A000003
    IL_0129: ldc.i4.1
    IL_012A: conv.r8
    IL_012C: ldc.i4.s 0
    IL_012D: nop
    IL_012E: stloc.0
    IL_012F: ldarg.0
    IL_0134: ldfld 0x0400101C
    IL_0135: ldc.i4.1
    IL_013A: stfld 0x0400006C
    IL_013B: ldarg.0
    IL_013C: ldc.i4.m1
    IL_0141: stfld 0x0400101A
    IL_0142: ldc.i4.0
    IL_0143: ret
    IL_0144: ldc.i4.1
    IL_0145: ret
    IL_0146: ldloc.1
    IL_0147: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400101A
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
