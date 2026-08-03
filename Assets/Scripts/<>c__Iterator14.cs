// Namespace: 
// Type: <>c__Iterator14

    internal sealed class <>c__Iterator14 {{

    private object <$s_12>__0;
    private object <N>__1;
    private object $PC;
    private object $current;
    private object <>f__this;

    public <>c__Iterator14() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001065
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001065
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_87
    IL_0003: ldloc.1
    IL_0004: nop
    IL_0005: ldloc.0
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x04001064
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x06000783
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04001066
    IL_0025: stfld 0x04001066
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001064
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001064
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_00A9
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001066
    IL_002E: ldfld 0x040008D8
    IL_002F: conv.r8
    IL_0030: ret
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x04001062
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0045: bgt.s IL_0046
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_0078
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x04001062
    IL_0058: call 0x0A00022B
    IL_005D: stfld 0x04001063
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04001063
    IL_0069: stfld 0x04001065
    IL_006A: ldarg.0
    IL_006B: ldc.i4.1
    IL_0070: stfld 0x04001064
    IL_0071: ldc.i4.1
    IL_0072: stloc.1
    IL_0073: IL_DD
    IL_0075: bne.un.s IL_0076
    IL_0076: nop
    IL_0077: nop
    IL_0078: ldarg.0
    IL_007D: ldflda 0x04001062
    IL_0082: call 0x0A00022C
    IL_0087: brtrue IL_004D
    IL_0088: IL_DD
    IL_0089: ldc.i4.m1
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: ldloc.1
    IL_008F: brfalse.s IL_0091
    IL_0090: IL_DC
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04001062
    IL_009B: newobj 0x1B00000D
    IL_009C: conv.r8
    IL_009D: ldelem.ref
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: IL_DC
    IL_00A2: ldarg.0
    IL_00A3: ldc.i4.m1
    IL_00A8: stfld 0x04001064
    IL_00A9: ldc.i4.0
    IL_00AA: ret
    IL_00AB: ldc.i4.1
    IL_00AC: ret
    IL_00AD: ldloc.2
    IL_00AE: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001064
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001064
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.5
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0037
    IL_0021: IL_DD
    IL_0023: ldloc.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04001062
    IL_0030: newobj 0x1B00000D
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
