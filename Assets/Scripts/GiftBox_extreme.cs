// Namespace: 
// Type: GiftBox_extreme

    public class GiftBox_extreme {{

    public object ef_risingitem;
    public object snd_drop;
    public object snd_open;
    private object drop_impact;
    private object itemrising;
    private object script_ingameUI;
    private object itemrate;

    public GiftBox_extreme() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 70
    IL_0007: stfld 0x0400069F
    IL_0008: ldarg.0
    IL_000D: call 0x0A000001
    IL_000E: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_000A: ldstr 0x7000259F
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0011: IL_8F
    IL_0012: IL_C2
    IL_0013: conv.u8
    IL_0014: IL_3D
    IL_0015: conv.r8
    IL_0017: bgt.s IL_0018
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: call 0x0A00002A
    IL_0024: ldstr 0x700025B3
    IL_0025: conv.r8
    IL_0027: bge.s IL_0028
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_0031: stsfld 0x00306F3E
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: call 0x0A00002A
    IL_003E: ldstr 0x700025C5
    IL_003F: conv.r8
    IL_0041: bge.s IL_0042
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: IL_22
    IL_0045: ldelem.i
    IL_0046: IL_99
    IL_0047: IL_99
    IL_0048: IL_3E
    IL_0049: conv.r8
    IL_004B: bgt.s IL_004C
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: call 0x0A00002A
    IL_0058: ldstr 0x7000259F
    IL_0059: conv.r8
    IL_005A: IL_3C
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: pop
    IL_005F: ldarg.0
    IL_0064: call 0x0A00000A
    IL_0065: ldc.i4.0
    IL_0066: conv.r8
    IL_0067: stloc.1
    IL_0068: nop
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: ldarg.0
    IL_0070: ldstr 0x700025DD
    IL_0075: call 0x0A000077
    IL_0076: conv.r8
    IL_007F: ldc.i8 288237653926281216
    IL_0080: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x0400069C
    IL_0007: ldarg.0
    IL_000C: call 0x0A00002A
    IL_0011: ldstr 0x700025C5
    IL_0012: conv.r8
    IL_0013: IL_3C
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: pop
    IL_0018: ldarg.0
    IL_001D: call 0x0A00002A
    IL_0022: ldstr 0x700025CF
    IL_0023: conv.r8
    IL_0028: newobj 0x0A0A0000
    IL_0029: ldloc.0
    IL_002A: IL_22
    IL_002B: ldelem.i
    IL_002C: IL_99
    IL_002D: IL_99
    IL_002E: IL_3E
    IL_002F: conv.r8
    IL_0031: bgt.s IL_0032
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000699
    IL_003A: ldarg.0
    IL_003F: call 0x0A000002
    IL_0040: conv.r8
    IL_0041: ldc.i4.2
    IL_0042: nop
    IL_0043: nop
    IL_0044: stloc.0
    IL_0045: conv.r8
    IL_0046: ldloc.3
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.0
    IL_0005: call 0x06000307
    IL_0006: ldarg.0
    IL_000B: call 0x0A000003
    IL_000C: ldc.i4.0
    IL_000D: conv.r8
    IL_000F: ldc.i4.s 0
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ret
    }

    private void OpenBox() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400069B
    IL_000C: conv.r8
    IL_000D: ldind.ref
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: call 0x0A00002A
    IL_001B: ldstr 0x700025B3
    IL_001C: conv.r8
    IL_001D: IL_3C
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: pop
    IL_0022: ldarg.0
    IL_0023: ldc.i4.1
    IL_0028: stfld 0x0400069D
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000699
    IL_002F: conv.r8
    IL_0030: IL_B0
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldc.i4.1
    IL_0035: conv.r8
    IL_0036: IL_B6
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: ldarg.0
    IL_003F: ldfld 0x0400069E
    IL_0044: ldfld 0x04000B8E
    IL_0049: brfalse IL_005A
    IL_004A: ldarg.0
    IL_004F: ldfld 0x0400069E
    IL_0050: conv.r8
    IL_0052: ldloc.s 6
    IL_0053: nop
    IL_0054: ldloc.0
    IL_0059: br IL_009F
    IL_005A: ldc.i4.0
    IL_005C: ldc.i4.s 100
    IL_0061: call 0x0A000045
    IL_0062: ldarg.0
    IL_0067: ldfld 0x0400069F
    IL_0068: IL_3E
    IL_0069: ldc.i4.2
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: ldarg.0
    IL_006F: ldc.i4.s 70
    IL_0074: stfld 0x0400069F
    IL_0075: ldarg.0
    IL_007A: ldfld 0x0400069E
    IL_007B: conv.r8
    IL_007C: ldc.i4.0
    IL_007D: ldloc.0
    IL_007E: nop
    IL_007F: ldloc.0
    IL_0084: br IL_009F
    IL_0085: ldarg.0
    IL_0086: dup
    IL_008B: ldfld 0x0400069F
    IL_008D: ldc.i4.s 10
    IL_008E: IL_59
    IL_0093: stfld 0x0400069F
    IL_0094: ldarg.0
    IL_0099: ldfld 0x0400069E
    IL_009A: conv.r8
    IL_009B: ldc.i4.m1
    IL_009C: ldloc.0
    IL_009D: nop
    IL_009E: ldloc.0
    IL_009F: ldarg.0
    IL_00A4: ldfld 0x0400069E
    IL_00A5: conv.r8
    IL_00A6: ldc.i4.1
    IL_00A7: ldloc.0
    IL_00A8: nop
    IL_00A9: ldloc.0
    IL_00AA: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400069C
    IL_000A: brtrue IL_0049
    IL_000B: ldarg.0
    IL_0010: call 0x0A00002A
    IL_0015: ldstr 0x700025CF
    IL_0016: conv.r8
    IL_0017: IL_56
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001F: brfalse IL_0044
    IL_0020: ldarg.0
    IL_0021: ldc.i4.1
    IL_0026: stfld 0x0400069C
    IL_0027: ldarg.0
    IL_002C: call 0x0A00002B
    IL_002D: ldarg.0
    IL_0032: ldfld 0x0400069A
    IL_0033: conv.r8
    IL_0034: ldind.ref
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ldarg.0
    IL_003D: call 0x0A000003
    IL_003E: ldc.i4.1
    IL_003F: conv.r8
    IL_0041: ldc.i4.s 0
    IL_0042: nop
    IL_0043: stloc.0
    IL_0048: br IL_00B3
    IL_0049: ldarg.0
    IL_004E: ldfld 0x0400069D
    IL_0053: brfalse IL_00B3
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000699
    IL_005A: conv.r8
    IL_005B: ldc.i4.2
    IL_005C: nop
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: stloc.0
    IL_0061: ldloca.s 0
    IL_0066: ldfld 0x0A000023
    IL_0067: IL_22
    IL_0068: nop
    IL_0069: nop
    IL_006E: stsfld 0x002A413F
    IL_006F: nop
    IL_0070: nop
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000699
    IL_0077: dup
    IL_0078: conv.r8
    IL_0079: ldc.i4.2
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_0081: call 0x0A000007
    IL_0086: call 0x0A000024
    IL_008B: call 0x0A000008
    IL_0090: call 0x0A000029
    IL_0091: conv.r8
    IL_0092: ldloc.3
    IL_0093: nop
    IL_0094: nop
    IL_0095: stloc.0
    IL_009A: br IL_00B3
    IL_009B: ldarg.0
    IL_009C: ldc.i4.0
    IL_00A1: stfld 0x0400069D
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000699
    IL_00A8: conv.r8
    IL_00A9: IL_B0
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: stloc.0
    IL_00AD: ldc.i4.0
    IL_00AE: conv.r8
    IL_00AF: IL_B6
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: stloc.0
    IL_00B3: ret
    }

    }}
