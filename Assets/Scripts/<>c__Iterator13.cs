// Namespace: 
// Type: <>c__Iterator13

    internal sealed class <>c__Iterator13 {{

    private object <$s_8>__0;
    private object <C>__1;
    private object <$s_9>__2;
    private object <D>__3;
    private object $PC;
    private object $current;
    private object <>f__this;

    public <>c__Iterator13() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001060
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001060
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0006: ldsflda 0x2A060007
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x0400105F
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x0600077B
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04001061
    IL_0025: stfld 0x04001061
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400105F
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
    IL_0022: br IL_0116
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001061
    IL_002A: conv.r8
    IL_002D: ldloca 4
    IL_002E: ldloc.0
    IL_002F: conv.r8
    IL_0038: ldc.i8 288248361277587458
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0045: bge.s IL_0046
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_00E1
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x0400105B
    IL_0054: conv.r8
    IL_0055: IL_22
    IL_0056: ldarg.0
    IL_0057: nop
    IL_0058: stloc.0
    IL_005D: stfld 0x0400105C
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400105C
    IL_0065: conv.r8
    IL_0068: stloc 4
    IL_0069: ldloc.0
    IL_006A: conv.r8
    IL_0073: ldc.i8 288248369867522050
    IL_0075: ldc.i4.s -3
    IL_0076: stloc.0
    IL_0077: ldloc.0
    IL_0078: ldc.i4.1
    IL_0079: IL_59
    IL_007C: ldarg 1
    IL_007D: nop
    IL_007E: nop
    IL_0080: bgt.s IL_0081
    IL_0081: nop
    IL_0082: nop
    IL_0087: br IL_00B3
    IL_0088: ldarg.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x0400105D
    IL_008F: conv.r8
    IL_0090: IL_22
    IL_0091: ldarg.0
    IL_0092: nop
    IL_0093: stloc.0
    IL_0098: stfld 0x0400105E
    IL_0099: ldarg.0
    IL_009A: ldarg.0
    IL_009F: ldfld 0x0400105E
    IL_00A4: stfld 0x04001060
    IL_00A5: ldarg.0
    IL_00A6: ldc.i4.1
    IL_00AB: stfld 0x0400105F
    IL_00AC: ldc.i4.1
    IL_00AD: stloc.1
    IL_00AE: IL_DD
    IL_00AF: shl
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x0400105D
    IL_00B9: conv.r8
    IL_00BA: IL_99
    IL_00BB: IL_01
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00C2: brtrue IL_0088
    IL_00C3: IL_DD
    IL_00C4: ldc.i4.3
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: ldloc.1
    IL_00CA: brfalse.s IL_00CC
    IL_00CB: IL_DC
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x0400105D
    IL_00D3: brtrue.s IL_00D5
    IL_00D4: IL_DC
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x0400105D
    IL_00DB: conv.r8
    IL_00DC: ldelem.ref
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: stloc.0
    IL_00E0: IL_DC
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x0400105B
    IL_00E7: conv.r8
    IL_00E8: IL_99
    IL_00E9: IL_01
    IL_00EA: nop
    IL_00EB: stloc.0
    IL_00F0: brtrue IL_004D
    IL_00F1: IL_DD
    IL_00F2: ldc.i4.3
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: nop
    IL_00F6: ldloc.1
    IL_00F8: brfalse.s IL_00FA
    IL_00F9: IL_DC
    IL_00FA: ldarg.0
    IL_00FF: ldfld 0x0400105B
    IL_0101: brtrue.s IL_0103
    IL_0102: IL_DC
    IL_0103: ldarg.0
    IL_0108: ldfld 0x0400105B
    IL_0109: conv.r8
    IL_010A: ldelem.ref
    IL_010B: nop
    IL_010C: nop
    IL_010D: stloc.0
    IL_010E: IL_DC
    IL_010F: ldarg.0
    IL_0110: ldc.i4.m1
    IL_0115: stfld 0x0400105F
    IL_0116: ldc.i4.0
    IL_0117: ret
    IL_0118: ldc.i4.1
    IL_0119: ret
    IL_011A: ldloc.2
    IL_011B: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400105F
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0018: brfalse IL_5000019
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0055
    IL_0021: IL_DD
    IL_0022: ldc.i4.m1
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400105D
    IL_002D: brtrue.s IL_002F
    IL_002E: IL_DC
    IL_002F: ldarg.0
    IL_0034: ldfld 0x0400105D
    IL_0035: conv.r8
    IL_0036: ldelem.ref
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: IL_DC
    IL_003B: IL_DD
    IL_003C: ldc.i4.m1
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400105B
    IL_0047: brtrue.s IL_0049
    IL_0048: IL_DC
    IL_0049: ldarg.0
    IL_004E: ldfld 0x0400105B
    IL_004F: conv.r8
    IL_0050: ldelem.ref
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: IL_DC
    IL_0055: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    }}
