// Namespace: 
// Type: <>c__Iterator16

    internal sealed class <>c__Iterator16 {{

    private object <$s_16>__0;
    private object <N>__1;
    private object $PC;
    private object $current;
    private object <>f__this;

    public <>c__Iterator16() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_95
    IL_0003: ldloc.1
    IL_0004: nop
    IL_0005: ldloc.0
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x0400106E
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x06000791
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04001070
    IL_0025: stfld 0x04001070
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400106E
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
    IL_0022: br IL_00AE
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001070
    IL_002E: ldfld 0x040008D9
    IL_002F: conv.r8
    IL_0030: IL_3E
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x0400106C
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_35
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_007D
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x0400106C
    IL_0058: call 0x0A00023F
    IL_005D: stfld 0x0400106D
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldflda 0x0400106D
    IL_0069: call 0x0A000236
    IL_006E: stfld 0x0400106F
    IL_006F: ldarg.0
    IL_0070: ldc.i4.1
    IL_0075: stfld 0x0400106E
    IL_0076: ldc.i4.1
    IL_0077: stloc.1
    IL_0078: IL_DD
    IL_007A: bne.un.s IL_007B
    IL_007B: nop
    IL_007C: nop
    IL_007D: ldarg.0
    IL_0082: ldflda 0x0400106C
    IL_0087: call 0x0A000241
    IL_008C: brtrue IL_004D
    IL_008D: IL_DD
    IL_008E: ldc.i4.m1
    IL_008F: nop
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldloc.1
    IL_0094: brfalse.s IL_0096
    IL_0095: IL_DC
    IL_0096: ldarg.0
    IL_009B: ldfld 0x0400106C
    IL_00A0: newobj 0x1B000011
    IL_00A1: conv.r8
    IL_00A2: ldelem.ref
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00A6: IL_DC
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4.m1
    IL_00AD: stfld 0x0400106E
    IL_00AE: ldc.i4.0
    IL_00AF: ret
    IL_00B0: ldc.i4.1
    IL_00B1: ret
    IL_00B2: ldloc.2
    IL_00B3: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400106E
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
    IL_002B: ldfld 0x0400106C
    IL_0030: newobj 0x1B000011
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
