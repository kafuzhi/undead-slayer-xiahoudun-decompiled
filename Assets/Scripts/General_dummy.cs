// Namespace: 
// Type: General_dummy

    public class General_dummy {{

    public object shadow;
    public object r_hand;
    public object l_hand;
    private object general_weapon;
    private object mytransform;
    private object myanimation;
    private object script_cha;
    private object cha1;
    public object bip01;
    private object changeready;
    private object jumpatk;
    private object dead;
    private object generalkind;

    public General_dummy() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000684
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00002A
    IL_0017: stfld 0x04000685
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000685
    IL_0022: ldstr 0x70000F2B
    IL_0023: conv.r8
    IL_0025: bge.s IL_0026
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: IL_22
    IL_0029: ldelem.i
    IL_002A: IL_99
    IL_002B: IL_99
    IL_002C: IL_3E
    IL_002D: conv.r8
    IL_002F: bgt.s IL_0030
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000685
    IL_003C: ldstr 0x70000F15
    IL_003D: conv.r8
    IL_003F: bge.s IL_0040
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: IL_22
    IL_0043: IL_CD
    IL_0044: IL_CC
    IL_0045: IL_4C
    IL_0046: IL_3E
    IL_0047: conv.r8
    IL_0049: bgt.s IL_004A
    IL_004A: nop
    IL_004B: stloc.0
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000685
    IL_0056: ldstr 0x70000F3F
    IL_0057: conv.r8
    IL_0059: bge.s IL_005A
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: IL_22
    IL_005D: ldelem.i
    IL_005E: IL_99
    IL_005F: IL_99
    IL_0060: IL_3E
    IL_0061: conv.r8
    IL_0063: bgt.s IL_0064
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000685
    IL_0070: ldstr 0x70000EDB
    IL_0071: conv.r8
    IL_0073: bge.s IL_0074
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: IL_22
    IL_0077: ldelem.i
    IL_0078: IL_99
    IL_0079: IL_99
    IL_007A: IL_3E
    IL_007B: conv.r8
    IL_007D: bgt.s IL_007E
    IL_007E: nop
    IL_007F: stloc.0
    IL_0080: ldarg.0
    IL_0085: ldstr 0x70000001
    IL_008A: call 0x0A000004
    IL_008B: conv.r8
    IL_008C: ldarg.3
    IL_008D: nop
    IL_008E: nop
    IL_008F: stloc.0
    IL_0094: stfld 0x04000687
    IL_0095: ldarg.0
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000687
    IL_009C: conv.r8
    IL_009D: stloc.2
    IL_009E: nop
    IL_009F: nop
    IL_00A1: br.s IL_011F
    IL_00A2: IL_86
    IL_00A3: ldloc.0
    IL_00A4: nop
    IL_00A5: ldarg.2
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x04000680
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x04000684
    IL_00B2: conv.r8
    IL_00B3: ldc.i4.2
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: stloc.0
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000684
    IL_00BD: conv.r8
    IL_00BE: pop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: stloc.0
    IL_00C6: call 0x0A000014
    IL_00C7: conv.u4
    IL_00C8: ldarg.1
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: IL_01
    IL_00CC: stloc.0
    IL_00CD: ldloc.0
    IL_00CE: conv.r8
    IL_00D0: beq.s IL_00D1
    IL_00D1: nop
    IL_00D3: br.s IL_00D6
    IL_00D8: ldfld 0x04000688
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00E0: stsfld 0x04356F3F
    IL_00E1: nop
    IL_00E2: ldloc.0
    IL_00E3: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000684
    IL_0016: call 0x0A00004B
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_C0
    IL_20BF: switch (2088 cases)
    }

    public void SetCostume() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x0400068C
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000684
    IL_000D: ldarg.1
    IL_000E: ldc.i4.1
    IL_000F: IL_58
    IL_0010: conv.r8
    IL_0015: brtrue IL_6F0A0016
    IL_0016: stloc.0
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldc.i4.1
    IL_001B: conv.r8
    IL_001C: stloc.1
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0024: ldstr 0x70001BB3
    IL_0026: ldarga.s 2
    IL_002B: call 0x0A000010
    IL_0030: call 0x0A000011
    IL_0035: call 0x0A000012
    IL_0036: conv.u8
    IL_0037: ldloc.0
    IL_0038: nop
    IL_0039: nop
    IL_003A: IL_01
    IL_003B: stloc.0
    IL_003C: ldarg.0
    IL_003D: ldloc.0
    IL_003E: conv.r8
    IL_003F: ldarg.3
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000681
    IL_0049: conv.r8
    IL_004A: ldc.i4.2
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000681
    IL_0054: conv.r8
    IL_0055: pop
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_005D: call 0x0A000014
    IL_005E: conv.u4
    IL_005F: ldarg.1
    IL_0060: nop
    IL_0061: nop
    IL_0062: IL_01
    IL_0067: stfld 0x04000683
    IL_0068: ldarg.0
    IL_006D: ldfld 0x04000683
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000681
    IL_0074: conv.r8
    IL_0075: IL_4E
    IL_0076: nop
    IL_0077: nop
    IL_0078: stloc.0
    IL_0079: ldarg.1
    IL_007E: brtrue IL_00BC
    IL_007F: ldarg.0
    IL_0080: ldloc.0
    IL_0081: conv.r8
    IL_0082: ldarg.3
    IL_0083: nop
    IL_0084: nop
    IL_0085: stloc.0
    IL_0086: ldarg.0
    IL_008B: ldfld 0x04000682
    IL_008C: conv.r8
    IL_008D: ldc.i4.2
    IL_008E: nop
    IL_008F: nop
    IL_0090: stloc.0
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000682
    IL_0097: conv.r8
    IL_0098: pop
    IL_0099: nop
    IL_009A: nop
    IL_009B: stloc.0
    IL_00A0: call 0x0A000014
    IL_00A1: conv.u4
    IL_00A2: ldarg.1
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: IL_01
    IL_00AA: stfld 0x04000683
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x04000683
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000682
    IL_00B7: conv.r8
    IL_00B8: IL_4E
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: stloc.0
    IL_00BC: ret
    }

    public void ShowIn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000685
    IL_0016: ldstr 0x70000F2B
    IL_0017: conv.r8
    IL_0018: IL_3C
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: pop
    IL_001D: ldarg.0
    IL_001E: ldc.i4.1
    IL_0023: stfld 0x04000689
    IL_0024: ldarg.0
    IL_0029: ldfld 0x0400068C
    IL_002A: ldc.i4.4
    IL_0073: switch (17 cases)
    }

    public void ShowIn_atk() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000685
    IL_0016: ldstr 0x70000F3F
    IL_0017: conv.r8
    IL_0018: IL_3C
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: pop
    IL_001D: ldarg.0
    IL_001E: ldc.i4.1
    IL_0023: stfld 0x04000689
    IL_0024: ldarg.0
    IL_0025: ldc.i4.1
    IL_002A: stfld 0x0400068A
    IL_002B: ldarg.0
    IL_0030: ldfld 0x0400068C
    IL_0031: ldc.i4.4
    IL_007A: switch (17 cases)
    }

    public void ShowOut() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000685
    IL_0016: ldstr 0x70000F15
    IL_0017: conv.r8
    IL_0018: IL_3C
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: pop
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400068C
    IL_0023: ldc.i4.4
    IL_006C: switch (17 cases)
    }

    public void Dead() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: ldstr 0x70000063
    IL_0015: call 0x0A000004
    IL_0016: conv.r8
    IL_0017: ldarg.0
    IL_0018: nop
    IL_0019: nop
    IL_001B: br.s IL_008B
    IL_001C: ldarg.3
    IL_001D: ldarg.3
    IL_001E: nop
    IL_001F: ldloc.0
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000685
    IL_002A: ldstr 0x70000EDB
    IL_002B: conv.r8
    IL_002C: IL_3C
    IL_002D: nop
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: pop
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x0400068B
    IL_0038: ldarg.0
    IL_003D: call 0x0A00000A
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_1C4A145: switch (7415872 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400068B
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000685
    IL_0012: conv.r8
    IL_0013: IL_79
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: brtrue IL_0089
    IL_001C: ldarg.0
    IL_0021: ldfld 0x0400068C
    IL_0022: ldc.i4.4
    IL_006B: switch (17 cases)
    IL_0070: ldfld 0x0400068A
    IL_0071: conv.r8
    IL_0072: conv.r8
    IL_0073: IL_01
    IL_0074: nop
    IL_0075: ldloc.0
    IL_0076: ldarg.0
    IL_0077: ldc.i4.0
    IL_007C: stfld 0x04000689
    IL_007D: ldarg.0
    IL_007E: ldc.i4.0
    IL_0083: stfld 0x0400068A
    IL_0088: br IL_009F
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000684
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000687
    IL_0095: conv.r8
    IL_0096: ldc.i4.2
    IL_0097: nop
    IL_0098: nop
    IL_0099: stloc.0
    IL_009A: conv.r8
    IL_009B: ldloc.3
    IL_009C: nop
    IL_009D: nop
    IL_009E: stloc.0
    IL_009F: ret
    }

    }}
