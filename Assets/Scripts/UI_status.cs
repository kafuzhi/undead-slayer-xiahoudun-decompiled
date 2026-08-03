// Namespace: 
// Type: UI_status

    public class UI_status {{

    public object bg_shop;
    public object bg_black;
    public object pop_detail;
    public object pop_blank;
    public object pop_blank2;
    public object cost_icon;
    public object bg_asset;
    public object arrow_upgrade;
    public object titlebase;
    public object gauge_exp;
    public object equipicon;
    public object img_acce;
    public object bt_equip;
    public object bt_yesno;
    public object bt_back;
    public object titlebase2;
    public object bt_prev;
    public object bt_next;
    public object bt_empty;
    public object bt_acce;
    public object basicSkin;
    private object cashshop;
    private object sound_UI;
    public object sound_dummy;
    private object script_soundUI;
    private object bg_posX_l;
    private object bg_posX_r;
    private object icon_posY;
    private object selectequip;
    private object confirm;
    private object popup_equip_select;
    private object imagemovefinish;
    private object coin;
    private object jade;
    private object rollstat;
    private object level;
    private object maxhp;
    private object exp;
    private object select_itemidx;
    private object thisitemStat;
    private object b_delay;
    private object f_delay;
    private object cur_equip_grade;
    private object ei;
    private object language;
    private object statinfo;
    private object statname_idx;
    private object hpplus;
    private object hitrate;
    private object evasion;
    private object endurance;
    private object critical;
    private object accessory;

    public UI_status() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.6
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000FB6
    IL_000C: ldarg.0
    IL_000D: ldc.i4.6
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000FB7
    IL_0018: ldarg.0
    IL_0019: ldc.i4.6
    IL_001E: newarr 0x0100000C
    IL_0023: stfld 0x04000FD3
    IL_0024: ldarg.0
    IL_0025: ldc.i4.6
    IL_002A: newarr 0x0100000B
    IL_002F: stfld 0x04000FD6
    IL_0030: ldarg.0
    IL_0031: ldc.i4.6
    IL_0033: ldc.i4.s 11
    IL_0038: newobj 0x0A000167
    IL_003D: stfld 0x04000FD7
    IL_003E: ldarg.0
    IL_0043: ldc.i4 161
    IL_0048: stfld 0x04000FD9
    IL_0049: ldarg.0
    IL_004A: ldc.i4.6
    IL_004F: newarr 0x0100000B
    IL_0054: stfld 0x04000FE0
    IL_0055: ldarg.0
    IL_005A: call 0x0A000001
    IL_005B: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000DDD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000FCF
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000E05
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000FDB
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000E0D
    IL_002A: call 0x06000220
    IL_002F: stfld 0x04000FDC
    IL_0030: ldarg.0
    IL_0035: ldstr 0x70000E1D
    IL_003A: call 0x06000220
    IL_003F: stfld 0x04000FDD
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70000E25
    IL_004A: call 0x06000220
    IL_004F: stfld 0x04000FDE
    IL_0050: ldarg.0
    IL_0055: ldstr 0x70000E2D
    IL_005A: call 0x06000220
    IL_005F: stfld 0x04000FDF
    IL_0060: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000FCC
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000FCD
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000DCD
    IL_002A: call 0x060003F9
    IL_002F: stfld 0x04000FE0
    IL_0030: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000FD8
    IL_0010: ldarg.0
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_BE
    IL_0015: IL_C3
    IL_001A: stfld 0x04000FC5
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_F0
    IL_0020: IL_43
    IL_0025: stfld 0x04000FC6
    IL_0026: ldarg.0
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: IL_AA
    IL_002B: IL_43
    IL_0030: stfld 0x04000FC7
    IL_0031: ldarg.0
    IL_0032: ldarg.0
    IL_0037: call 0x2B000090
    IL_003C: ldfld 0x040004CF
    IL_0041: stfld 0x04000FD7
    IL_0042: ldarg.0
    IL_0044: ldc.i4.s 95
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000FCF
    IL_004B: ldc.i4.5
    IL_004C: IL_5A
    IL_004D: IL_58
    IL_0052: stfld 0x04000FD0
    IL_0053: ldarg.0
    IL_0058: ldstr 0x70000DE5
    IL_005D: call 0x06000220
    IL_005E: conv.i2
    IL_0063: stfld 0x04000FD1
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000FD1
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04000FCF
    IL_0072: ldc.i4.s 100
    IL_0073: IL_5A
    IL_0074: conv.i2
    IL_0075: add
    IL_007A: stfld 0x04000FD1
    IL_007B: ldarg.0
    IL_0080: ldstr 0x70001EF5
    IL_0085: call 0x060003F9
    IL_008A: stfld 0x04000FD6
    IL_008F: ldstr 0x70000121
    IL_0094: call 0x0A000004
    IL_0095: ldnull
    IL_009A: call 0x0A000061
    IL_009F: brfalse IL_00C5
    IL_00A0: ldarg.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000FC3
    IL_00AB: call 0x0A00001B
    IL_00B0: call 0x0A000013
    IL_00B5: call 0x0A000014
    IL_00B6: conv.u4
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: IL_01
    IL_00BF: stfld 0x04000FC2
    IL_00C4: br IL_00DA
    IL_00C5: ldarg.0
    IL_00CA: ldstr 0x70000121
    IL_00CF: call 0x0A000004
    IL_00D0: conv.r8
    IL_00D1: ldarg.3
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: stloc.0
    IL_00D9: stfld 0x04000FC2
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000FC2
    IL_00E0: ldnull
    IL_00E5: call 0x0A000021
    IL_00EA: brfalse IL_00FC
    IL_00EB: ldarg.0
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x04000FC2
    IL_00F2: conv.r8
    IL_00F7: ldsfld 0x7D2B0000
    IL_00F8: IL_C4
    IL_00FA: ldarga.s 0
    IL_00FB: ldarg.2
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x04000FD3
    IL_0102: ldc.i4.0
    IL_0107: ldsfld 0x040007B2
    IL_0108: ldarg.0
    IL_010D: ldfld 0x04000FD8
    IL_0112: ldc.i4 143
    IL_0117: call 0x0A0000E1
    IL_011C: stelem 0x0FD37B02
    IL_011D: nop
    IL_011E: ldarg.2
    IL_011F: ldc.i4.1
    IL_0124: ldsfld 0x040007B2
    IL_0125: ldarg.0
    IL_012A: ldfld 0x04000FD8
    IL_012F: ldc.i4 147
    IL_0134: call 0x0A0000E1
    IL_0139: stelem 0x0FD37B02
    IL_013A: nop
    IL_013B: ldarg.2
    IL_013C: ldc.i4.2
    IL_0141: ldsfld 0x040007B2
    IL_0142: ldarg.0
    IL_0147: ldfld 0x04000FD8
    IL_014C: ldc.i4 148
    IL_0151: call 0x0A0000E1
    IL_0156: stelem 0x0FD37B02
    IL_0157: nop
    IL_0158: ldarg.2
    IL_0159: ldc.i4.3
    IL_015E: ldsfld 0x040007B2
    IL_015F: ldarg.0
    IL_0164: ldfld 0x04000FD8
    IL_0169: ldc.i4 146
    IL_016E: call 0x0A0000E1
    IL_0173: stelem 0x0FD37B02
    IL_0174: nop
    IL_0175: ldarg.2
    IL_0176: ldc.i4.4
    IL_017B: ldsfld 0x040007B2
    IL_017C: ldarg.0
    IL_0181: ldfld 0x04000FD8
    IL_0186: ldc.i4 154
    IL_018B: call 0x0A0000E1
    IL_0190: stelem 0x0FD37B02
    IL_0191: nop
    IL_0192: ldarg.2
    IL_0193: ldc.i4.5
    IL_0198: ldsfld 0x040007B2
    IL_0199: ldarg.0
    IL_019E: ldfld 0x04000FD8
    IL_01A3: ldc.i4 145
    IL_01A8: call 0x0A0000E1
    IL_01AD: stelem 0x00061772
    IL_01B2: cpobj 0x009F281B
    IL_01B3: nop
    IL_01B4: stloc.0
    IL_01B5: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000FD4
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000FD5
    IL_000E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FD4
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000FD5
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000FD5
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000FD5
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_42
    IL_002A: ldloca.s 0
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000FD4
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000FD5
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000FCB
    IL_0049: brtrue IL_0111
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000FC5
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x002941C2
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000FC5
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000FC5
    IL_0067: shl
    IL_006C: call 0x0A000024
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0070: ldc.i4.0
    IL_0071: IL_44
    IL_0072: IL_5A
    IL_0077: call 0x0A000114
    IL_0078: IL_58
    IL_007D: stfld 0x04000FC5
    IL_0082: br IL_0111
    IL_0083: ldarg.0
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_008B: stsfld 0x0FC57DC2
    IL_008C: nop
    IL_008D: ldarg.2
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000FC6
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000FC6
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00B0: stfld 0x04000FC6
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000FC6
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: IL_42
    IL_00BD: IL_50
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: nop
    IL_00CB: stfld 0x04000FC6
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000FC7
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000FC7
    IL_00DD: call 0x0A000024
    IL_00DE: IL_22
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_FA
    IL_00E2: IL_43
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000114
    IL_00E9: IL_59
    IL_00EE: stfld 0x04000FC7
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000FC7
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: shr
    IL_00F9: IL_43
    IL_00FA: IL_42
    IL_00FC: ldloca.s 0
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: ldarg.0
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: shr
    IL_0104: IL_43
    IL_0109: stfld 0x04000FC7
    IL_010A: ldarg.0
    IL_010B: ldc.i4.1
    IL_0110: stfld 0x04000FCB
    IL_0115: ldstr 0x7000064F
    IL_011A: call 0x0A000095
    IL_011B: stloc.0
    IL_011C: ldloc.0
    IL_011D: ldc.i4.1
    IL_01CE: switch (43 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    public void StatInfo_detail() {
    IL_0000: ldarg.1
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0005: ldarg 6
    IL_0006: nop
    IL_0007: nop
    IL_0008: ldarg.3
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldc.i4.m1
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: dup
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_35
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_001A: ldarg 0
    IL_001B: nop
    IL_001C: IL_55
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0024: br IL_0085
    IL_0025: ldarg.0
    IL_002A: ldc.i4 163
    IL_002F: stfld 0x04000FD9
    IL_0034: br IL_0085
    IL_0035: ldarg.0
    IL_003A: ldc.i4 162
    IL_003F: stfld 0x04000FD9
    IL_0044: br IL_0085
    IL_0045: ldarg.0
    IL_004A: ldc.i4 167
    IL_004F: stfld 0x04000FD9
    IL_0054: br IL_0085
    IL_0055: ldarg.0
    IL_005A: ldc.i4 165
    IL_005F: stfld 0x04000FD9
    IL_0064: br IL_0085
    IL_0065: ldarg.0
    IL_006A: ldc.i4 161
    IL_006F: stfld 0x04000FD9
    IL_0074: br IL_0085
    IL_0075: ldarg.0
    IL_007A: ldc.i4 170
    IL_007F: stfld 0x04000FD9
    IL_0084: br IL_0085
    IL_0085: ret
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FC1
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000FC1
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000FC1
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FC0
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
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000FC9
    IL_0047: ldc.i4.0
    IL_0048: IL_3E
    IL_0049: ldloc.0
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldc.i4.0
    IL_0052: call 0x0A0001B9
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000FC5
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_22
    IL_005F: nop
    IL_0060: nop
    IL_0061: ldelem.r8
    IL_0062: IL_43
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: ldelem.r8
    IL_0067: IL_43
    IL_006C: call 0x0600021D
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000FAC
    IL_0077: call 0x0A0000E0
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000FC6
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: IL_54
    IL_0082: IL_43
    IL_0083: IL_22
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_F0
    IL_0087: IL_43
    IL_0088: IL_22
    IL_0089: nop
    IL_008A: nop
    IL_008B: IL_C8
    IL_008C: IL_42
    IL_0091: call 0x0600021D
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000FAD
    IL_009C: call 0x0A0000E0
    IL_009D: IL_22
    IL_009E: nop
    IL_009F: nop
    IL_00A0: IL_E0
    IL_00A1: IL_42
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AE: stsfld 0x00002243
    IL_00AF: nop
    IL_00B0: IL_42
    IL_00B5: call 0x0600021D
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x04000FB2
    IL_00C0: call 0x0A0000E0
    IL_00C1: IL_22
    IL_00C2: nop
    IL_00C3: nop
    IL_00C5: ldloca.s 67
    IL_00C6: IL_22
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: IL_C0
    IL_280000156: switch (2684354594 cases)
    }

    }}
