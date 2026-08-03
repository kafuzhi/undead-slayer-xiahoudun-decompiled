// Namespace: 
// Type: Hp_bar

    public class Hp_bar {{

    private object thismesh;
    private object originUV;
    private object mytransform;
    private object parentmon;
    private object _amount;
    private object amountU;
    private object amuontV;
    private object posY;
    private object oldstatus;

    public Hp_bar() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: newarr 0x01000014
    IL_000B: stfld 0x040006BA
    IL_000C: ldarg.0
    IL_0011: call 0x0A000001
    IL_0012: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040006BB
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000016
    IL_0013: conv.r8
    IL_0014: IL_A9
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x040006B9
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040006B9
    IL_0024: conv.r8
    IL_0025: IL_8F
    IL_0026: IL_01
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: stfld 0x040006BA
    IL_002E: ldarg.0
    IL_0033: call 0x0A0000AA
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_003B: stsfld 0x0083283E
    IL_003C: nop
    IL_003D: stloc.0
    IL_0042: stfld 0x040006BF
    IL_0043: ret
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0001: ldarg.3
    IL_0006: stfld 0x040006BC
    IL_0007: ldarg.1
    IL_000C: brfalse IL_0147
    IL_000D: ldarg.0
    IL_000E: IL_22
    IL_000F: nop
    IL_0010: nop
    IL_0015: stsfld 0x036B043F
    IL_0016: conv.i2
    IL_0017: add
    IL_0018: IL_59
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: IL_3F
    IL_001E: IL_5A
    IL_0023: stfld 0x040006BD
    IL_0024: ldarg.0
    IL_0029: call 0x0A000082
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040006BD
    IL_0034: call 0x0A000083
    IL_0039: stfld 0x040006BE
    IL_003B: ldarg.s 5
    IL_003C: ldc.i4.m1
    IL_0061: switch (8 cases)
    IL_0062: ldarg.2
    IL_0063: ldc.i4.0
    IL_0064: IL_8F
    IL_0065: ldnull
    IL_0066: nop
    IL_0067: nop
    IL_0068: IL_01
    IL_006D: ldobj 0x01000014
    IL_006E: ldarg.0
    IL_0073: ldfld 0x040006BE
    IL_0078: call 0x0A0000AB
    IL_0079: ldarg.0
    IL_007E: ldfld 0x040006BF
    IL_0080: ldarg.s 5
    IL_0081: conv.i2
    IL_0086: call 0x0A000083
    IL_008B: call 0x0A0000AB
    IL_008C: IL_81
    IL_008D: ldnull
    IL_008E: nop
    IL_008F: nop
    IL_0090: IL_01
    IL_0091: dup
    IL_0092: ldc.i4.1
    IL_0093: IL_8F
    IL_0094: ldnull
    IL_0095: nop
    IL_0096: nop
    IL_0097: IL_01
    IL_0098: ldarg.0
    IL_009D: ldfld 0x040006BA
    IL_009E: ldc.i4.1
    IL_009F: IL_8F
    IL_00A0: ldnull
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: IL_01
    IL_00A8: ldobj 0x01000014
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x040006BE
    IL_00B3: call 0x0A0000AB
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x040006BF
    IL_00BB: ldarg.s 5
    IL_00BC: conv.i2
    IL_00C1: call 0x0A000083
    IL_00C6: call 0x0A0000AB
    IL_00C7: IL_81
    IL_00C8: ldnull
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: IL_01
    IL_00CC: dup
    IL_00CD: ldc.i4.2
    IL_00CE: IL_8F
    IL_00CF: ldnull
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: IL_01
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x040006BA
    IL_00D9: ldc.i4.2
    IL_00DA: IL_8F
    IL_00DB: ldnull
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: IL_01
    IL_00E3: ldobj 0x01000014
    IL_00E4: ldarg.0
    IL_00E9: ldfld 0x040006BE
    IL_00EE: call 0x0A0000AB
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x040006BF
    IL_00F6: ldarg.s 5
    IL_00F7: conv.i2
    IL_00FC: call 0x0A000083
    IL_0101: call 0x0A0000AB
    IL_0102: IL_81
    IL_0103: ldnull
    IL_0104: nop
    IL_0105: nop
    IL_0106: IL_01
    IL_0107: dup
    IL_0108: ldc.i4.3
    IL_0109: IL_8F
    IL_010A: ldnull
    IL_010B: nop
    IL_010C: nop
    IL_010D: IL_01
    IL_010E: ldarg.0
    IL_0113: ldfld 0x040006BA
    IL_0114: ldc.i4.3
    IL_0115: IL_8F
    IL_0116: ldnull
    IL_0117: nop
    IL_0118: nop
    IL_0119: IL_01
    IL_011E: ldobj 0x01000014
    IL_011F: ldarg.0
    IL_0124: ldfld 0x040006BE
    IL_0129: call 0x0A0000AB
    IL_012A: ldarg.0
    IL_012F: ldfld 0x040006BF
    IL_0131: ldarg.s 5
    IL_0132: conv.i2
    IL_0137: call 0x0A000083
    IL_013C: call 0x0A0000AB
    IL_013D: IL_81
    IL_013E: ldnull
    IL_013F: nop
    IL_0140: nop
    IL_0141: IL_01
    IL_0142: conv.r8
    IL_0143: IL_AC
    IL_0144: nop
    IL_0145: nop
    IL_0146: stloc.0
    IL_0147: ldarg.0
    IL_0149: ldarg.s 4
    IL_014E: stfld 0x040006C0
    IL_014F: ldarg.0
    IL_0151: ldarg.s 5
    IL_0156: stfld 0x040006C1
    IL_0157: ret
    }

    public void FreeSelect() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006BB
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
    IL_001A: ldarg.0
    IL_001B: ldnull
    IL_0020: stfld 0x040006BC
    IL_0021: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006BC
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_0041
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040006BB
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040006BC
    IL_001D: conv.r8
    IL_001E: ldc.i4.2
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040006C0
    IL_002D: IL_22
    IL_002E: stloc.0
    IL_002F: IL_D7
    IL_0030: stelem.i
    IL_0031: IL_BC
    IL_0036: newobj 0x0A000076
    IL_003B: call 0x0A000029
    IL_003C: conv.r8
    IL_003D: ldloc.3
    IL_003E: nop
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: ret
    }

    }}
