// Namespace: 
// Type: GiftBox

    public class GiftBox {{

    public object ef_risingitem;
    private object itemrising;
    public object spbox;
    public object inven_gem;
    public object inven_weapon;
    public object snd_drop;
    public object snd_open;
    private object targetpos;
    private object directionVector;
    private object isclear;
    private object homingdelay;
    private object drop_impact;

    public GiftBox() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000007
    IL_000A: call 0x0A000043
    IL_000B: IL_22
    IL_000C: ldelem.i
    IL_000D: IL_99
    IL_000E: ldc.i4.3
    IL_000F: IL_3F
    IL_0014: call 0x0A000008
    IL_0019: call 0x0A000042
    IL_001A: IL_22
    IL_001B: IL_CD
    IL_001C: IL_CC
    IL_001D: IL_4C
    IL_001E: IL_3E
    IL_0023: call 0x0A000008
    IL_0028: call 0x0A000029
    IL_002D: stfld 0x04000694
    IL_002E: ldarg.0
    IL_0033: call 0x0A000007
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: IL_3F
    IL_003D: call 0x0A000008
    IL_0042: stfld 0x04000695
    IL_0043: ldarg.0
    IL_0048: call 0x0A00002A
    IL_004D: ldstr 0x7000259F
    IL_004E: conv.r8
    IL_0050: bge.s IL_0051
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: IL_22
    IL_0054: IL_8F
    IL_0055: IL_C2
    IL_0056: conv.u8
    IL_0057: IL_3D
    IL_0058: conv.r8
    IL_005A: bgt.s IL_005B
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_0062: call 0x0A00002A
    IL_0067: ldstr 0x700025B3
    IL_0068: conv.r8
    IL_006A: bge.s IL_006B
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0074: stsfld 0x00306F3E
    IL_0075: nop
    IL_0076: stloc.0
    IL_0077: ldarg.0
    IL_007C: ldstr 0x70000BD5
    IL_0081: call 0x0A000004
    IL_0082: conv.r8
    IL_0087: brtrue IL_7B2B0088
    IL_0088: ldc.i4.3
    IL_008A: ldarga.s 0
    IL_008B: ldarg.2
    IL_0090: stfld 0x04000696
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000696
    IL_0097: ldc.i4.0
    IL_0098: IL_3D
    IL_009D: call 0x02000000
    IL_00A2: call 0x0A00002A
    IL_00A7: ldstr 0x7000259F
    IL_00A8: conv.r8
    IL_00AA: bge.s IL_00AB
    IL_00AB: nop
    IL_00AC: stloc.0
    IL_00AD: ldc.i4.8
    IL_00AE: conv.r8
    IL_00B3: ldstr 0x020A0000
    IL_00B8: call 0x0A00002A
    IL_00BD: ldstr 0x7000259F
    IL_00BE: conv.r8
    IL_00BF: IL_3C
    IL_00C0: nop
    IL_00C1: nop
    IL_00C2: stloc.0
    IL_00C3: pop
    IL_00C4: ret
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04000696
    IL_00CC: ldc.i4.s 100
    IL_00CD: IL_3E
    IL_00CF: ble.s IL_00D0
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: ldarg.0
    IL_00D7: call 0x0A000002
    IL_00D8: ldc.i4.2
    IL_00D9: conv.r8
    IL_00DE: brtrue IL_6F0A00DF
    IL_00DF: stloc.3
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: stloc.0
    IL_00E3: conv.r8
    IL_00E5: ldarg.s 0
    IL_00E6: nop
    IL_00E7: stloc.0
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x0400068F
    IL_00EE: conv.r8
    IL_00F0: ldarga.s 0
    IL_00F1: nop
    IL_00F2: stloc.0
    IL_00F3: ldarg.0
    IL_00F8: call 0x0A000002
    IL_00FD: call 0x0A00004B
    IL_00FE: conv.r8
    IL_00FF: IL_AF
    IL_0100: nop
    IL_0101: nop
    IL_0102: stloc.0
    IL_0103: ldarg.0
    IL_0108: call 0x0A00002A
    IL_010D: ldstr 0x7000259F
    IL_010E: conv.r8
    IL_010F: IL_3C
    IL_0110: nop
    IL_0111: nop
    IL_0112: stloc.0
    IL_0113: pop
    IL_0114: ldarg.0
    IL_0119: call 0x0A00002A
    IL_011E: ldstr 0x700025C5
    IL_011F: conv.r8
    IL_0124: newobj 0x0A0A0000
    IL_0125: ldloc.0
    IL_0126: IL_22
    IL_0127: ldelem.i
    IL_0128: IL_99
    IL_0129: IL_99
    IL_012A: IL_3E
    IL_012B: conv.r8
    IL_012D: bgt.s IL_012E
    IL_012E: nop
    IL_012F: stloc.0
    IL_0130: ldarg.0
    IL_0135: call 0x0A00002A
    IL_013A: ldstr 0x700025CF
    IL_013B: conv.r8
    IL_0140: newobj 0x0A0A0000
    IL_0141: ldloc.0
    IL_0142: IL_22
    IL_0143: ldelem.i
    IL_0144: IL_99
    IL_0145: IL_99
    IL_0146: IL_3E
    IL_0147: conv.r8
    IL_0149: bgt.s IL_014A
    IL_014A: nop
    IL_014B: stloc.0
    IL_014C: ret
    }

    public void OpenBox() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000693
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
    IL_0028: stfld 0x0400068E
    IL_0029: ldarg.0
    IL_002E: ldfld 0x0400068D
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
    IL_003A: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000698
    IL_000A: brtrue IL_003D
    IL_000B: ldarg.0
    IL_0010: call 0x0A00002A
    IL_0015: ldstr 0x700025CF
    IL_0016: conv.r8
    IL_0017: IL_56
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001F: brfalse IL_0038
    IL_0020: ldarg.0
    IL_0021: ldc.i4.1
    IL_0026: stfld 0x04000698
    IL_0027: ldarg.0
    IL_002C: call 0x0A00002B
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000692
    IL_0033: conv.r8
    IL_0034: ldind.ref
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_003C: br IL_0195
    IL_003D: ldarg.0
    IL_0042: ldfld 0x0400068E
    IL_0047: brfalse IL_0195
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000697
    IL_004E: IL_22
    IL_004F: nop
    IL_0050: nop
    IL_0051: IL_C0
    IL_0052: IL_3F
    IL_0053: IL_41
    IL_0054: div
    IL_0055: nop
    IL_0056: nop
    IL_0057: nop
    IL_0058: ldarg.0
    IL_0059: dup
    IL_005E: ldfld 0x04000697
    IL_0063: call 0x0A000024
    IL_0064: IL_58
    IL_0069: stfld 0x04000697
    IL_006A: ldarg.0
    IL_006F: ldfld 0x0400068D
    IL_0070: dup
    IL_0071: conv.r8
    IL_0072: ldc.i4.2
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: ldarg.0
    IL_007B: ldfld 0x04000695
    IL_0080: call 0x0A000024
    IL_0085: call 0x0A000008
    IL_008A: call 0x0A000029
    IL_008B: conv.r8
    IL_008C: ldloc.3
    IL_008D: nop
    IL_008E: nop
    IL_008F: stloc.0
    IL_0090: ldarg.0
    IL_0091: dup
    IL_0096: ldfld 0x04000695
    IL_0097: ldarg.0
    IL_009C: ldfld 0x04000694
    IL_00A1: call 0x0A000024
    IL_00A6: call 0x0A000008
    IL_00AB: call 0x0A000029
    IL_00B0: stfld 0x04000695
    IL_00B5: br IL_0195
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x04000696
    IL_00BD: ldc.i4.s 100
    IL_00BE: IL_3E
    IL_00BF: div
    IL_00C0: nop
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000691
    IL_00C9: conv.r8
    IL_00CA: stloc.0
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: stloc.0
    IL_00CE: ldc.i4.1
    IL_00CF: conv.r8
    IL_00D0: stloc.1
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: stloc.0
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000696
    IL_00DB: ldc.i4.s 100
    IL_00DC: add
    IL_00DD: stloc.0
    IL_00DE: ldloc.0
    IL_00DF: ldc.i4.1
    IL_015C: switch (30 cases)
    IL_015D: IL_CC
    IL_015E: IL_4C
    IL_015F: IL_3E
    IL_0160: ldarg.0
    IL_0165: ldfld 0x0400068D
    IL_0166: conv.r8
    IL_0167: ldc.i4.2
    IL_0168: nop
    IL_0169: nop
    IL_016A: stloc.0
    IL_016B: stloc.2
    IL_016D: ldloca.s 2
    IL_0172: ldfld 0x0A00005C
    IL_0177: newobj 0x0A000076
    IL_0178: conv.r8
    IL_0179: ldloc.3
    IL_017A: nop
    IL_017B: nop
    IL_017C: stloc.0
    IL_017D: ldarg.0
    IL_0182: ldfld 0x0400068D
    IL_0183: conv.r8
    IL_0184: IL_B0
    IL_0185: nop
    IL_0186: nop
    IL_0187: stloc.0
    IL_0188: ldc.i4.0
    IL_0189: conv.r8
    IL_018A: IL_B6
    IL_018B: nop
    IL_018C: nop
    IL_018D: stloc.0
    IL_018E: ldarg.0
    IL_018F: ldc.i4.0
    IL_0194: stfld 0x0400068E
    IL_0195: ret
    }

    }}
