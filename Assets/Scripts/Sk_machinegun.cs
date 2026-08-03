// Namespace: 
// Type: Sk_machinegun

    public class Sk_machinegun {{

    private object mytransform;
    private object delay;
    private object mycollider;
    private object shooton;
    public object beam1;
    public object beam2;

    public Sk_machinegun() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008EE
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040008F0
    IL_0018: ldarg.0
    IL_001D: call 0x0A00002A
    IL_0022: ldstr 0x70022DBF
    IL_0023: conv.r8
    IL_0025: bge.s IL_0026
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: IL_22
    IL_0029: IL_CD
    IL_002A: IL_CC
    IL_002B: IL_4C
    IL_002C: IL_3E
    IL_002D: conv.r8
    IL_002F: bgt.s IL_0030
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0037: call 0x0A00002A
    IL_003C: ldstr 0x70022D49
    IL_003D: conv.r8
    IL_003F: bge.s IL_0040
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: IL_22
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_3F
    IL_0047: conv.r8
    IL_0049: bgt.s IL_004A
    IL_004A: nop
    IL_004B: stloc.0
    IL_004C: ldarg.0
    IL_0051: call 0x0A00002A
    IL_0056: ldstr 0x70022D55
    IL_0057: conv.r8
    IL_0059: bge.s IL_005A
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: IL_22
    IL_005D: IL_CD
    IL_005E: IL_CC
    IL_005F: IL_CC
    IL_0060: IL_3E
    IL_0061: conv.r8
    IL_0063: bgt.s IL_0064
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ret
    }

    private void Start() {
    IL_0000: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040008F1
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x040008EF
    IL_0012: ldarg.0
    IL_0017: ldstr 0x70022D6F
    IL_0018: IL_22
    IL_0019: IL_CD
    IL_001A: IL_CC
    IL_001B: IL_4C
    IL_001C: IL_3F
    IL_001D: IL_22
    IL_001E: IL_CD
    IL_001F: IL_CC
    IL_0020: IL_4C
    IL_0021: IL_3E
    IL_0026: call 0x0A000017
    IL_0027: ldarg.0
    IL_002C: call 0x0A00002A
    IL_0031: ldstr 0x70022D49
    IL_0032: conv.r8
    IL_0033: IL_3C
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: pop
    IL_0038: ldarg.0
    IL_003D: ldfld 0x040008F2
    IL_003E: conv.r8
    IL_003F: IL_B0
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ldc.i4.0
    IL_0044: conv.r8
    IL_0045: IL_B6
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x040008F3
    IL_004F: conv.r8
    IL_0050: IL_B0
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: ldc.i4.0
    IL_0055: conv.r8
    IL_0056: IL_B6
    IL_0057: nop
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x040008F0
    IL_0060: ldc.i4.0
    IL_0061: conv.r8
    IL_0063: ldc.i4.s 0
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ret
    }

    public void Shoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008F0
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008F0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040008EF
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040008EF
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008EF
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001F: ldobj 0x00374340
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040008EE
    IL_0038: call 0x0A00004B
    IL_0039: IL_22
    IL_003A: nop
    IL_003B: nop
    IL_0040: ldc.i4 534594
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: conv.r8
    IL_0044: ldloc.3
    IL_0045: nop
    IL_0046: nop
    IL_0047: stloc.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x040008EE
    IL_004E: ldnull
    IL_004F: conv.r8
    IL_0050: IL_4E
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0058: br IL_010D
    IL_0059: ldarg.0
    IL_005E: ldfld 0x040008EF
    IL_005F: IL_22
    IL_0060: nop
    IL_0061: nop
    IL_0066: stsfld 0x004F4340
    IL_0067: nop
    IL_0068: nop
    IL_0069: ldarg.0
    IL_006E: ldfld 0x040008F2
    IL_006F: conv.r8
    IL_0070: IL_B0
    IL_0071: nop
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldc.i4.0
    IL_0075: conv.r8
    IL_0076: IL_B6
    IL_0077: nop
    IL_0078: nop
    IL_0079: stloc.0
    IL_007A: ldarg.0
    IL_007F: ldfld 0x040008F3
    IL_0080: conv.r8
    IL_0081: IL_B0
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0085: ldc.i4.0
    IL_0086: conv.r8
    IL_0087: IL_B6
    IL_0088: nop
    IL_0089: nop
    IL_008A: stloc.0
    IL_008B: ldarg.0
    IL_0090: call 0x0A00002A
    IL_0095: ldstr 0x70022D55
    IL_0096: conv.r8
    IL_0097: IL_3C
    IL_0098: nop
    IL_0099: nop
    IL_009A: stloc.0
    IL_009B: pop
    IL_009C: ldarg.0
    IL_00A1: ldstr 0x70022D6F
    IL_00A6: call 0x0A00007B
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x040008F0
    IL_00AD: ldc.i4.0
    IL_00AE: conv.r8
    IL_00B0: ldc.i4.s 0
    IL_00B1: nop
    IL_00B2: stloc.0
    IL_00B7: br IL_010D
    IL_00B8: ldarg.0
    IL_00BD: ldfld 0x040008EF
    IL_00BE: IL_22
    IL_00BF: ldelem.i
    IL_00C0: IL_99
    IL_00C1: ldc.i4.3
    IL_00C2: IL_3F
    IL_00C3: IL_43
    IL_00C6: ldarg 0
    IL_00C7: nop
    IL_00C8: ldarg.0
    IL_00CD: ldfld 0x040008F1
    IL_00D2: brtrue IL_010D
    IL_00D3: ldarg.0
    IL_00D4: ldc.i4.1
    IL_00D9: stfld 0x040008F1
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x040008F2
    IL_00E0: conv.r8
    IL_00E1: IL_B0
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: stloc.0
    IL_00E5: ldc.i4.1
    IL_00E6: conv.r8
    IL_00E7: IL_B6
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: stloc.0
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x040008F3
    IL_00F1: conv.r8
    IL_00F2: IL_B0
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: stloc.0
    IL_00F6: ldc.i4.1
    IL_00F7: conv.r8
    IL_00F8: IL_B6
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: stloc.0
    IL_00FC: ldarg.0
    IL_0101: call 0x0A00002A
    IL_0106: ldstr 0x70022DBF
    IL_0107: conv.r8
    IL_0108: IL_3C
    IL_0109: nop
    IL_010A: nop
    IL_010B: stloc.0
    IL_010C: pop
    IL_010D: ret
    }

    }}
