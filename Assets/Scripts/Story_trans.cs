// Namespace: 
// Type: Story_trans

    public class Story_trans {{

    public object black2;
    private object b_delay;
    private object cinema_window;
    private object f_delay;
    private object color_alpha;
    private object story_index;
    private object cha1;
    private object horse;
    private object script_cha;
    public object basicSkin;
    public object bt_skip;
    private object storytxt;
    private object language;
    private object max_stage_index;

    public Story_trans() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040009D3
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x040009D4
    IL_000E: ldarg.0
    IL_000F: IL_22
    IL_0010: nop
    IL_0011: nop
    IL_0012: nop
    IL_27560B: switch (644477 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A000090
    IL_0010: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x040009DE
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000001
    IL_001A: call 0x0A000004
    IL_001F: stfld 0x040009D8
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70022EF5
    IL_002A: call 0x0A000077
    IL_002F: stfld 0x040009D9
    IL_0030: ldarg.0
    IL_0031: ldarg.0
    IL_0036: ldfld 0x040009D8
    IL_0037: conv.r8
    IL_0038: ldarg.2
    IL_0039: nop
    IL_003A: nop
    IL_003C: br.s IL_00BA
    IL_003D: IL_DA
    IL_003E: ldloc.3
    IL_003F: nop
    IL_0040: ldarg.2
    IL_0041: ldarg.0
    IL_0046: ldstr 0x700004DD
    IL_004B: call 0x06000220
    IL_0050: stfld 0x040009DF
    IL_0051: ldarg.0
    IL_0056: ldfld 0x040009DF
    IL_0057: ldc.i4.m1
    IL_037C: switch (200 cases)
    }

    public void ScreenOn() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040009D3
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x040009D5
    IL_000E: ret
    }

    public void Story_Contents() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009D7
    IL_0007: stloc.s 4
    IL_0009: ldloc.s 4
    IL_000C: ldarg 8
    IL_000D: nop
    IL_000E: nop
    IL_000F: ldarg.3
    IL_0010: nop
    IL_0011: nop
    IL_0012: nop
    IL_0014: ldloc.s 0
    IL_0015: nop
    IL_0016: nop
    IL_001B: call 0xA7000000
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_B6
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_ED
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_002B: call 0x5A000001
    IL_002C: IL_01
    IL_002D: nop
    IL_002E: nop
    IL_0033: br IL_0205
    IL_0034: ldarg.0
    IL_0035: ldc.i4.1
    IL_003A: stfld 0x040009D4
    IL_003F: br IL_0205
    IL_0040: ldarg.0
    IL_0041: ldc.i4.0
    IL_0046: stfld 0x040009D4
    IL_0047: ldarg.0
    IL_004C: call 0x0A00002B
    IL_004D: conv.r8
    IL_004E: IL_4D
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0056: br IL_0205
    IL_0057: ldarg.0
    IL_0058: ldc.i4.1
    IL_005D: stfld 0x040009D4
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040009D8
    IL_0064: conv.r8
    IL_0065: ldarg.3
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_006D: call 0x0A00001B
    IL_006E: conv.r8
    IL_006F: ldloc.3
    IL_0070: nop
    IL_0071: nop
    IL_0072: stloc.0
    IL_0077: ldstr 0x70022F0D
    IL_007C: call 0x0A000077
    IL_007D: stloc.0
    IL_007E: ldloc.0
    IL_007F: conv.r8
    IL_0080: ldarg.3
    IL_0081: nop
    IL_0082: nop
    IL_0083: stloc.0
    IL_0088: call 0x0A000062
    IL_0089: IL_22
    IL_008A: IL_CD
    IL_008B: IL_CC
    IL_008C: IL_CC
    IL_008D: IL_BD
    IL_0092: call 0x0A000008
    IL_0093: conv.r8
    IL_0094: ldloc.3
    IL_0095: nop
    IL_0096: nop
    IL_0097: stloc.0
    IL_009C: call 0x0A000035
    IL_009D: conv.r8
    IL_009E: ldloc.0
    IL_009F: nop
    IL_00A0: nop
    IL_00A2: br.s IL_00A9
    IL_00A3: conv.r8
    IL_00A4: ldarg.3
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: stloc.0
    IL_00A9: ldc.i4.s 25
    IL_00AA: IL_22
    IL_00AB: nop
    IL_00AC: nop
    IL_00B1: ldc.i4 19820353
    IL_00B2: nop
    IL_00B3: ldloc.0
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x040009DA
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x040009D9
    IL_00C0: conv.r8
    IL_00C1: ldarg.3
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: stloc.0
    IL_00C5: conv.r8
    IL_00C6: ldc.i4.2
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: stloc.0
    IL_00CA: ldc.i4.0
    IL_00CB: ldc.i4.1
    IL_00CC: conv.r8
    IL_00D1: stfld 0x38060001
    IL_00D3: bge.s IL_00D5
    IL_00D4: nop
    IL_00D5: nop
    IL_00DA: ldstr 0x70022F15
    IL_00DF: call 0x0A000128
    IL_00E4: br IL_0205
    IL_00E9: ldstr 0x700016D7
    IL_00EE: call 0x0A000077
    IL_00EF: conv.r8
    IL_00F4: newobj 0x6F2B0000
    IL_00F5: IL_AD
    IL_00F6: IL_01
    IL_00F7: nop
    IL_00F8: ldloc.0
    IL_00FD: ldstr 0x70000B91
    IL_0102: call 0x0A000077
    IL_0103: conv.r8
    IL_0104: conv.u4
    IL_0105: nop
    IL_0106: nop
    IL_0108: br.s IL_0178
    IL_0109: IL_BD
    IL_010A: IL_01
    IL_010B: nop
    IL_010C: ldloc.0
    IL_0111: ldstr 0x70001799
    IL_0116: call 0x0A000128
    IL_011B: br IL_0205
    IL_0120: ldstr 0x70000B91
    IL_0125: call 0x0A000077
    IL_012A: call 0x0A000050
    IL_012F: ldstr 0x700016D7
    IL_0134: call 0x0A000077
    IL_0135: stloc.1
    IL_0136: ldloc.1
    IL_0137: conv.r8
    IL_013C: newobj 0x282B0000
    IL_013D: IL_50
    IL_013E: nop
    IL_013F: nop
    IL_0140: stloc.0
    IL_0141: ldloc.1
    IL_0142: conv.r8
    IL_0143: conv.u8
    IL_0144: nop
    IL_0145: nop
    IL_0147: br.s IL_016E
    IL_014C: ldstr 0x70022F25
    IL_0151: call 0x0A000128
    IL_0156: br IL_0205
    IL_015B: ldstr 0x70022F35
    IL_0160: call 0x0A000077
    IL_0161: conv.r8
    IL_0162: conv.r.un
    IL_0163: nop
    IL_0164: nop
    IL_0166: br.s IL_01D6
    IL_0167: IL_43
    IL_0168: IL_01
    IL_0169: nop
    IL_016A: ldloc.0
    IL_016F: ldstr 0x700016D7
    IL_0174: call 0x0A000077
    IL_0179: call 0x0A000050
    IL_017E: ldstr 0x70000BEF
    IL_0183: call 0x0A000128
    IL_0188: br IL_0205
    IL_018D: ldstr 0x70022F35
    IL_0192: call 0x0A000077
    IL_0193: conv.r8
    IL_0194: IL_77
    IL_0195: nop
    IL_0196: nop
    IL_0198: br.s IL_0208
    IL_0199: IL_3E
    IL_019A: IL_01
    IL_019B: nop
    IL_019C: ldloc.0
    IL_019D: ldarg.0
    IL_01A2: ldfld 0x040009DF
    IL_01A3: ldc.i4.m1
    IL_0214: switch (27 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009D3
    IL_000A: brfalse IL_008B
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x040009D6
    IL_0016: call 0x0A000024
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_359F56187: switch (3598538842 cases)
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009DB
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldc.i4.m1
    IL_0046: call 0x0A0000EF
    IL_0047: ldarg.0
    IL_004C: ldfld 0x040009D4
    IL_0051: brfalse IL_009A
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: nop
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: nop
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_F0
    IL_0060: IL_43
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0068: stsfld 0x021D2842
    IL_0069: nop
    IL_006A: ldloc.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040009D2
    IL_0075: call 0x0A0000E0
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_22
    IL_007C: nop
    IL_007D: nop
    IL_0082: stsfld 0x00002243
    IL_0083: IL_F0
    IL_0084: IL_43
    IL_0085: IL_22
    IL_0086: nop
    IL_0087: nop
    IL_0088: IL_94
    IL_0089: IL_42
    IL_008E: call 0x0600021D
    IL_008F: ldarg.0
    IL_0094: ldfld 0x040009D2
    IL_0099: call 0x0A0000E0
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040009D6
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_0245: switch (103 cases)
    }

    }}
