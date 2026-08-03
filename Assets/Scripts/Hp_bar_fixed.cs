// Namespace: 
// Type: Hp_bar_fixed

    public class Hp_bar_fixed {{

    private object thismesh;
    private object originUV;
    private object mytransform;
    private object _amount;
    private object amountU;
    private object amuontV;
    private object oldstatus;

    public Hp_bar_fixed() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: newarr 0x01000014
    IL_000B: stfld 0x040006C3
    IL_000C: ldarg.0
    IL_0011: call 0x0A000001
    IL_0012: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040006C4
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000016
    IL_0013: conv.r8
    IL_0014: IL_A9
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x040006C2
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040006C2
    IL_0024: conv.r8
    IL_0025: IL_8F
    IL_0026: IL_01
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: stfld 0x040006C3
    IL_002E: ldarg.0
    IL_0033: call 0x0A0000AA
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_003B: stsfld 0x0083283E
    IL_003C: nop
    IL_003D: stloc.0
    IL_0042: stfld 0x040006C7
    IL_0043: ret
    }

    public void Damaged() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0140
    IL_0006: ldarg.0
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000E: stsfld 0x036B043F
    IL_000F: conv.i2
    IL_0010: add
    IL_0011: IL_59
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: IL_3F
    IL_0017: IL_5A
    IL_001C: stfld 0x040006C5
    IL_001D: ldarg.0
    IL_0022: call 0x0A000082
    IL_0023: ldarg.0
    IL_0028: ldfld 0x040006C5
    IL_002D: call 0x0A000083
    IL_0032: stfld 0x040006C6
    IL_0034: ldarg.s 5
    IL_0035: ldc.i4.m1
    IL_005A: switch (8 cases)
    IL_005B: ldarg.2
    IL_005C: ldc.i4.0
    IL_005D: IL_8F
    IL_005E: ldnull
    IL_005F: nop
    IL_0060: nop
    IL_0061: IL_01
    IL_0066: ldobj 0x01000014
    IL_0067: ldarg.0
    IL_006C: ldfld 0x040006C6
    IL_0071: call 0x0A0000AB
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040006C7
    IL_0079: ldarg.s 5
    IL_007A: conv.i2
    IL_007F: call 0x0A000083
    IL_0084: call 0x0A0000AB
    IL_0085: IL_81
    IL_0086: ldnull
    IL_0087: nop
    IL_0088: nop
    IL_0089: IL_01
    IL_008A: dup
    IL_008B: ldc.i4.1
    IL_008C: IL_8F
    IL_008D: ldnull
    IL_008E: nop
    IL_008F: nop
    IL_0090: IL_01
    IL_0091: ldarg.0
    IL_0096: ldfld 0x040006C3
    IL_0097: ldc.i4.1
    IL_0098: IL_8F
    IL_0099: ldnull
    IL_009A: nop
    IL_009B: nop
    IL_009C: IL_01
    IL_00A1: ldobj 0x01000014
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x040006C6
    IL_00AC: call 0x0A0000AB
    IL_00AD: ldarg.0
    IL_00B2: ldfld 0x040006C7
    IL_00B4: ldarg.s 5
    IL_00B5: conv.i2
    IL_00BA: call 0x0A000083
    IL_00BF: call 0x0A0000AB
    IL_00C0: IL_81
    IL_00C1: ldnull
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: IL_01
    IL_00C5: dup
    IL_00C6: ldc.i4.2
    IL_00C7: IL_8F
    IL_00C8: ldnull
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: IL_01
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x040006C3
    IL_00D2: ldc.i4.2
    IL_00D3: IL_8F
    IL_00D4: ldnull
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: IL_01
    IL_00DC: ldobj 0x01000014
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x040006C6
    IL_00E7: call 0x0A0000AB
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x040006C7
    IL_00EF: ldarg.s 5
    IL_00F0: conv.i2
    IL_00F5: call 0x0A000083
    IL_00FA: call 0x0A0000AB
    IL_00FB: IL_81
    IL_00FC: ldnull
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: IL_01
    IL_0100: dup
    IL_0101: ldc.i4.3
    IL_0102: IL_8F
    IL_0103: ldnull
    IL_0104: nop
    IL_0105: nop
    IL_0106: IL_01
    IL_0107: ldarg.0
    IL_010C: ldfld 0x040006C3
    IL_010D: ldc.i4.3
    IL_010E: IL_8F
    IL_010F: ldnull
    IL_0110: nop
    IL_0111: nop
    IL_0112: IL_01
    IL_0117: ldobj 0x01000014
    IL_0118: ldarg.0
    IL_011D: ldfld 0x040006C6
    IL_0122: call 0x0A0000AB
    IL_0123: ldarg.0
    IL_0128: ldfld 0x040006C7
    IL_012A: ldarg.s 5
    IL_012B: conv.i2
    IL_0130: call 0x0A000083
    IL_0135: call 0x0A0000AB
    IL_0136: IL_81
    IL_0137: ldnull
    IL_0138: nop
    IL_0139: nop
    IL_013A: IL_01
    IL_013B: conv.r8
    IL_013C: IL_AC
    IL_013D: nop
    IL_013E: nop
    IL_013F: stloc.0
    IL_0140: ldarg.0
    IL_0142: ldarg.s 5
    IL_0147: stfld 0x040006C8
    IL_0148: ret
    }

    public void FreeSelect() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006C4
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_0012: stsfld 0x00082840
    IL_0013: nop
    IL_0014: stloc.0
    IL_0015: conv.r8
    IL_0016: ldloc.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ret
    }

    }}
