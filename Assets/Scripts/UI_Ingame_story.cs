// Namespace: 
// Type: UI_Ingame_story

    public class UI_Ingame_story {{

    private object chahp;
    private object chamaxhp;
    private object chasp;
    private object chamaxsp;
    private object chaexp;
    private object chalv;
    private object soul;
    private object coin;
    private object guide;
    public object pop_blank;
    public object pack;
    private object g_power;
    private object script_pack;
    private object gauge_hp;
    private object gauge_sp;
    private object gauge_exp;
    private object gauge_power;
    private object guide_txt;
    public object guide_img;
    public object yesno;
    private object exp_height;
    private object shootdir;
    private object uistart;
    private object f_charge;
    private object chargeon;
    public object basicSkin;
    private object cha1;
    private object script_cha;
    private object script_horse;
    private object language;

    public UI_Ingame_story() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: stfld 0x04000BDE
    IL_0008: ldarg.0
    IL_0009: IL_22
    IL_000A: nop
    IL_000B: nop
    IL_000C: IL_C8
    IL_000D: IL_42
    IL_0012: stfld 0x04000BE0
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0019: stfld 0x04000BE2
    IL_001A: ldarg.0
    IL_001B: ldc.i4.m1
    IL_0020: stfld 0x04000BE5
    IL_0021: ldarg.0
    IL_0022: ldc.i4.4
    IL_0027: newarr 0x0100000C
    IL_002C: stfld 0x04000BEE
    IL_002D: ldarg.0
    IL_002E: ldc.i4.4
    IL_0033: newarr 0x0100003C
    IL_0038: stfld 0x04000BEF
    IL_0039: ldarg.0
    IL_003A: ldc.i4.1
    IL_003F: stfld 0x04000BF3
    IL_0040: ldarg.0
    IL_0045: call 0x0A000001
    IL_0046: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000BFA
    IL_0010: ldarg.0
    IL_0012: ldc.i4.s 100
    IL_0017: stfld 0x04000BDE
    IL_0018: ldarg.0
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_C8
    IL_001D: IL_42
    IL_0022: stfld 0x04000BE0
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000BE7
    IL_002A: conv.r8
    IL_002B: IL_37
    IL_002C: nop
    IL_002D: nop
    IL_002F: br.s IL_00AD
    IL_0030: IL_E9
    IL_0031: stloc.1
    IL_0032: nop
    IL_0033: ldarg.2
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000BE9
    IL_003A: IL_22
    IL_003B: nop
    IL_003C: nop
    IL_0041: stsfld 0x0000223E
    IL_0046: stsfld 0x0038733E
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: IL_22
    IL_004F: IL_CD
    IL_0050: IL_CC
    IL_0051: IL_AC
    IL_0052: IL_BF
    IL_0053: IL_22
    IL_0054: shr
    IL_0055: shr
    IL_0056: IL_36
    IL_00E3: switch (34 cases)
    IL_00E4: IL_FF
    IL_00E5: ldarg.0
    IL_00E6: nop
    IL_00EB: cpobj 0x4CCCCD22
    IL_00EC: IL_3E
    IL_00ED: ldc.i4.0
    IL_00EE: conv.r8
    IL_00EF: IL_95
    IL_00F0: ldarg.1
    IL_00F1: nop
    IL_00F2: ldloc.0
    IL_00F3: stloc.0
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x04000BE9
    IL_00FA: IL_22
    IL_00FB: ldnull
    IL_00FC: IL_AE
    IL_00FD: IL_87
    IL_00FE: IL_3F
    IL_00FF: IL_22
    IL_0100: IL_CD
    IL_0101: IL_CC
    IL_0102: IL_4C
    IL_0103: IL_3D
    IL_0108: newobj 0x0A000038
    IL_0109: IL_22
    IL_010A: nop
    IL_010B: nop
    IL_010C: nop
    IL_010D: nop
    IL_010E: IL_22
    IL_010F: IL_A4
    IL_0114: cpobj 0x6622BF2D
    IL_0115: shr
    IL_0116: IL_36
    IL_3999999A3: switch (3865470498 cases)
    }

    public void ResetPower() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000BF5
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x04000BF4
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BED
    IL_001C: call 0x0A000057
    IL_001D: conv.r8
    IL_001E: IL_F3
    IL_001F: ldarg.0
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000BE8
    IL_0028: conv.r8
    IL_0029: stloc.0
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.0
    IL_002E: conv.r8
    IL_002F: stloc.1
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ret
    }

    public void PowerCharge() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000BF5
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BE8
    IL_000D: conv.r8
    IL_000E: stloc.0
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    public void GainCoin() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BE4
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000BE4
    IL_000E: ret
    }

    public void GainSoul() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BE3
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000BE3
    IL_000E: ldarg.0
    IL_000F: ldarg.0
    IL_0014: ldfld 0x04000BF8
    IL_0019: ldfld 0x040002EF
    IL_001E: stfld 0x04000BE1
    IL_001F: ldarg.0
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0xE17B023F
    IL_0028: stloc.1
    IL_0029: nop
    IL_002A: ldarg.2
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000BE2
    IL_0032: ldc.i4.s 100
    IL_0033: IL_5A
    IL_0034: conv.i2
    IL_0035: add
    IL_0036: IL_59
    IL_0037: IL_22
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_3E
    IL_003C: IL_5A
    IL_0041: stfld 0x04000BF1
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000BEC
    IL_004C: call 0x0A0000AA
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000BF1
    IL_0057: call 0x0A000083
    IL_0058: conv.r8
    IL_0059: IL_F3
    IL_005A: ldarg.0
    IL_005B: nop
    IL_005C: ldloc.0
    IL_005D: ret
    }

    public void StatUpdate() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000BDD
    IL_0007: ldarg.0
    IL_0008: ldarg.3
    IL_000D: stfld 0x04000BDF
    IL_000E: ldarg.0
    IL_000F: ldarg.2
    IL_0014: stfld 0x04000BDE
    IL_0015: IL_22
    IL_0016: nop
    IL_0017: nop
    IL_001C: stsfld 0xDD7B023F
    IL_001D: stloc.1
    IL_001E: nop
    IL_001F: ldarg.2
    IL_0020: conv.i2
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000BDE
    IL_0027: conv.i2
    IL_0028: add
    IL_0029: IL_59
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_3F
    IL_002F: IL_5A
    IL_0030: stloc.0
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000BEA
    IL_0037: ldloc.0
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_0041: newobj 0x0A000038
    IL_0042: conv.r8
    IL_0043: IL_F3
    IL_0044: ldarg.0
    IL_0045: nop
    IL_0046: ldloc.0
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004E: stsfld 0xDF7B023F
    IL_004F: stloc.1
    IL_0050: nop
    IL_0051: ldarg.2
    IL_0052: conv.i2
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000BE0
    IL_0059: conv.i2
    IL_005A: add
    IL_005B: IL_59
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_3F
    IL_0061: IL_5A
    IL_0062: stloc.1
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000BDF
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006E: ldloc 17474
    IL_006F: ldc.i4.5
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000BEB
    IL_007D: call 0x0A000082
    IL_007E: ldloc.1
    IL_0083: call 0x0A000083
    IL_0084: conv.r8
    IL_0085: IL_F3
    IL_0086: ldarg.0
    IL_0087: nop
    IL_0088: ldloc.0
    IL_008D: br IL_00B8
    IL_008E: ldarg.0
    IL_0093: ldfld 0x04000BEB
    IL_0098: call 0x0A000082
    IL_0099: ldloc.1
    IL_009E: call 0x0A000083
    IL_00A3: call 0x0A0000AA
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: IL_3D
    IL_00AD: call 0x0A000083
    IL_00B2: call 0x0A000174
    IL_00B3: conv.r8
    IL_00B4: IL_F3
    IL_00B5: ldarg.0
    IL_00B6: nop
    IL_00B7: ldloc.0
    IL_00B8: ret
    }

    public void GuideOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BF8
    IL_0006: conv.r8
    IL_000B: newobj 0x22060001
    IL_000C: nop
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0014: call 0x0A000111
    IL_0015: ldarg.0
    IL_0016: ldarg.1
    IL_001B: stfld 0x04000BE5
    IL_001C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BF5
    IL_000A: brfalse IL_0082
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000BF4
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_3F
    IL_0016: IL_41
    IL_0017: ldc.i4.7
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x04000BF4
    IL_0026: call 0x0A000024
    IL_0027: IL_22
    IL_0028: ldelem.i
    IL_0029: IL_99
    IL_002A: ldc.i4.3
    IL_002B: IL_3F
    IL_002C: IL_5A
    IL_002D: IL_58
    IL_0032: stfld 0x04000BF4
    IL_0037: br IL_0066
    IL_0038: ldarg.0
    IL_0039: IL_22
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_0042: stfld 0x04000BF4
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000BF8
    IL_0049: conv.r8
    IL_004A: ldelem.i1
    IL_004B: IL_01
    IL_004C: nop
    IL_004D: ldloc.0
    IL_004E: ldarg.0
    IL_004F: ldc.i4.0
    IL_0054: stfld 0x04000BF5
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000BE8
    IL_005B: conv.r8
    IL_005C: stloc.0
    IL_005D: nop
    IL_005E: nop
    IL_005F: stloc.0
    IL_0060: ldc.i4.0
    IL_0061: conv.r8
    IL_0062: stloc.1
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000BED
    IL_0070: call 0x0A000082
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000BF4
    IL_0077: shl
    IL_007C: call 0x0A000083
    IL_007D: conv.r8
    IL_007E: IL_F3
    IL_007F: ldarg.0
    IL_0080: nop
    IL_0081: ldloc.0
    IL_0082: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BF3
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000BF6
    IL_0016: call 0x0A0000DF
    IL_001B: call 0x0A00001B
    IL_0020: call 0x0A000013
    IL_0025: call 0x0A0000D9
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: cpobj 0xDA285B44
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: conv.i2
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_003A: ldc.i4 2251588
    IL_003B: nop
    IL_0040: stsfld 0x0076733F
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: call 0x0A0000DD
    IL_004C: call 0x0A0000DE
    IL_004D: ldc.i4.0
    IL_0052: call 0x0A0000EF
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000BE5
    IL_0059: ldc.i4.0
    IL_005A: IL_3F
    IL_005B: IL_82
    IL_005C: IL_01
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_22
    IL_0060: nop
    IL_0061: nop
    IL_0062: IL_E0
    IL_0063: IL_42
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_0067: IL_C0
    IL_0068: IL_42
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_0070: stsfld 0x00002243
    IL_0071: nop
    IL_0072: IL_43
    IL_0077: call 0x0600021D
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000BE6
    IL_0082: call 0x0A0000E0
    IL_0083: IL_22
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_F8
    IL_0087: IL_42
    IL_0088: IL_22
    IL_0089: nop
    IL_008A: nop
    IL_008F: ldtoken 0x00002242
    IL_0090: neg
    IL_0091: IL_43
    IL_0092: IL_22
    IL_0093: nop
    IL_0094: nop
    IL_0096: starg.s 66
    IL_009B: call 0x0600021D
    IL_00A0: ldsfld 0x0A000099
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000BEE
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000BE5
    IL_00AD: ldelem.i
    IL_00B2: call 0x0A000011
    IL_00B7: ldstr 0x70000C43
    IL_00BC: call 0x0A0000E2
    IL_00C1: call 0x0A0000E3
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_EC
    IL_00C6: IL_42
    IL_00C7: IL_22
    IL_00C8: nop
    IL_00C9: nop
    IL_00CC: ldloc 8771
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: conv.u4
    IL_00D0: IL_43
    IL_00D1: IL_22
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: rem
    IL_00D5: IL_41
    IL_00DA: call 0x0600021D
    IL_00DF: ldsfld 0x0A000099
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000BE5
    IL_00E6: ldc.i4.1
    IL_00E7: IL_58
    IL_00EC: newobj 0x0100000B
    IL_00F1: ldstr 0x700237E1
    IL_00F6: call 0x0A000098
    IL_00FB: ldstr 0x70000C43
    IL_0100: call 0x0A0000E2
    IL_0105: call 0x0A0000E3
    IL_0106: IL_22
    IL_0107: nop
    IL_0108: nop
    IL_0109: ret
    IL_010A: IL_43
    IL_010B: IL_22
    IL_010C: nop
    IL_010D: nop
    IL_010E: stloc.0
    IL_010F: IL_43
    IL_0110: IL_22
    IL_0111: nop
    IL_0112: nop
    IL_0113: nop
    IL_0114: IL_43
    IL_0115: IL_22
    IL_0116: nop
    IL_0117: nop
    IL_011C: stsfld 0x021D2842
    IL_011D: nop
    IL_011E: ldloc.0
    IL_011F: ldarg.0
    IL_0124: ldfld 0x04000BEF
    IL_0125: ldarg.0
    IL_012A: ldfld 0x04000BE5
    IL_012B: ldelem.i
    IL_0130: call 0x0A0000E0
    IL_0131: ldarg.0
    IL_0136: ldfld 0x04000BE5
    IL_0137: ldc.i4.3
    IL_02A8: switch (91 cases)
    }

    }}
