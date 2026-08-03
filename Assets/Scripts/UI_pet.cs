// Namespace: 
// Type: UI_pet

    public class UI_pet {{

    private static object MAXPET;
    private static object MAXANGEL;
    public object bg_pet;
    public object txt_name;
    public object bg_black;
    public object pop_detail;
    public object pop_blank;
    public object pop_blank2;
    public object c_equip;
    public object item_stat;
    public object skill_stat;
    public object angel;
    public object bt_yesno;
    public object bt_back;
    public object bt_petkind;
    public object bt_info;
    public object bt_empty;
    public object bg_asset;
    public object cost_icon;
    public object jade_icon;
    public object titlebase;
    public object icon_unlock;
    public object ico_feed;
    public object ico_arrow;
    public object ico_stamina;
    public object ico_stamina_empty;
    public object ico_warn;
    public object petkind;
    public object basicSkin;
    private object script_costume;
    private object script_dbangel;
    private object cashshop;
    private object sound_UI;
    private object script_soundUI;
    private object ps;
    private object bg_posX_l;
    private object bg_posX_r;
    private object icon_posY;
    private object currentpet;
    private object confirm;
    private object icon_size;
    private object coin;
    private object jade;
    private object cost_feed;
    private object menu_kind;
    public object pet_mesh;
    private object language;
    private object pet_activeskill;
    private object pet_passiveskill;
    private object pet_hunger;
    private object b_delay;
    private object f_delay;
    private object warning_hungry;
    private object gamemode;
    private object dragOn;
    private object scrollOn;
    private object prevposX;
    private object currentX;
    private object dragrange;
    private object dragposX;
    private object maxExtremeStage;
    private object cur_angel;
    private object sel_angel;
    private object angel_firerate;
    private object angel_name;
    private object angel_info;

    public UI_pet() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000EDC
    IL_000C: ldarg.0
    IL_000D: ldc.i4.4
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000EDD
    IL_0018: ldarg.0
    IL_0019: ldc.i4.8
    IL_001E: newarr 0x0100003C
    IL_0023: stfld 0x04000EDE
    IL_0024: ldarg.0
    IL_0025: ldc.i4.3
    IL_002A: newarr 0x0100003C
    IL_002F: stfld 0x04000EEE
    IL_0030: ldarg.0
    IL_0031: ldc.i4.2
    IL_0033: ldc.i4.s 10
    IL_0038: newobj 0x0A000169
    IL_003D: stfld 0x04000EF5
    IL_003E: ldarg.0
    IL_003F: ldc.i4.2
    IL_0044: newarr 0x01000003
    IL_0049: stfld 0x04000F00
    IL_004A: ldarg.0
    IL_004B: ldc.i4.2
    IL_0050: newarr 0x0100000B
    IL_0055: stfld 0x04000F02
    IL_0056: ldarg.0
    IL_0057: ldc.i4.2
    IL_005C: newarr 0x0100000B
    IL_0061: stfld 0x04000F03
    IL_0062: ldarg.0
    IL_0063: ldc.i4.2
    IL_0068: newarr 0x0100000B
    IL_006D: stfld 0x04000F04
    IL_006E: ldarg.0
    IL_006F: ldc.i4.1
    IL_0074: stfld 0x04000F0F
    IL_0075: ldarg.0
    IL_007A: ldsfld 0x0A000099
    IL_007F: stfld 0x04000F13
    IL_0080: ldarg.0
    IL_0085: ldsfld 0x0A000099
    IL_008A: stfld 0x04000F14
    IL_008B: ldarg.0
    IL_0090: call 0x0A000001
    IL_0091: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000EFC
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000EFD
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70023247
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F0F
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000F0F
    IL_0017: ldc.i4.1
    IL_0018: IL_59
    IL_0019: ldc.i4.8
    IL_001A: add
    IL_001F: stfld 0x04000F0F
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000BB3
    IL_002A: call 0x0A000095
    IL_002F: stfld 0x04000F01
    IL_0030: ldarg.0
    IL_0031: ldarg.0
    IL_0036: call 0x2B00008D
    IL_003B: ldfld 0x040004F3
    IL_0040: stfld 0x04000EF5
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: call 0x2B000001
    IL_004C: stfld 0x04000EF1
    IL_004D: ldarg.0
    IL_0052: ldstr 0x7000000F
    IL_0057: call 0x06000220
    IL_005C: stfld 0x04000F10
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000F10
    IL_0067: brfalse IL_0082
    IL_0068: ldarg.0
    IL_0069: ldarg.0
    IL_006E: ldfld 0x04000F10
    IL_0073: stfld 0x04000F11
    IL_0074: ldarg.0
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000F11
    IL_007B: ldc.i4.1
    IL_007C: IL_59
    IL_0081: call 0x060006B6
    IL_0082: ldarg.0
    IL_0087: ldc.i4 -380
    IL_008C: stfld 0x04000EF6
    IL_008D: ldarg.0
    IL_0092: ldc.i4 480
    IL_0097: stfld 0x04000EF7
    IL_0098: ldarg.0
    IL_009D: ldc.i4 340
    IL_00A2: stfld 0x04000EF8
    IL_00A3: ldarg.0
    IL_00A5: ldc.i4.s 20
    IL_00AA: stfld 0x04000EFE
    IL_00AB: ldarg.0
    IL_00B0: call 0x0A0000DA
    IL_00B1: conv.i2
    IL_00B2: IL_22
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: IL_C0
    IL_00B6: IL_3E
    IL_00B7: IL_5A
    IL_00BC: stfld 0x04000F0D
    IL_00BD: ldarg.0
    IL_00C2: ldstr 0x70001EFD
    IL_00C7: call 0x060003F9
    IL_00CC: stfld 0x04000F02
    IL_00CD: ldarg.0
    IL_00D2: ldstr 0x70001F05
    IL_00D7: call 0x060003F9
    IL_00DC: stfld 0x04000F03
    IL_00DD: ldarg.0
    IL_00E2: ldstr 0x70001F0D
    IL_00E7: call 0x060003F9
    IL_00EC: stfld 0x04000F04
    IL_00ED: ldc.i4.0
    IL_00EE: stloc.0
    IL_00F3: br IL_010D
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x04000F04
    IL_00FA: ldloc.0
    IL_00FB: IL_94
    IL_00FC: ldc.i4.0
    IL_00FD: IL_3D
    IL_00FE: ldloc.1
    IL_00FF: nop
    IL_0100: nop
    IL_0101: nop
    IL_0102: ldarg.0
    IL_0103: ldc.i4.1
    IL_0108: stfld 0x04000F07
    IL_0109: ldloc.0
    IL_010A: ldc.i4.1
    IL_010B: IL_58
    IL_010C: stloc.0
    IL_010D: ldloc.0
    IL_010E: ldc.i4.2
    IL_010F: IL_3F
    IL_0110: IL_E0
    IL_0111: IL_FF
    IL_0112: IL_FF
    IL_0113: IL_FF
    IL_0114: ldarg.0
    IL_0119: ldstr 0x70023285
    IL_011A: IL_22
    IL_011B: nop
    IL_011C: nop
    IL_011D: nop
    IL_011E: IL_3F
    IL_011F: IL_22
    IL_0124: ldfld 0x283EAE14
    IL_0125: ldc.i4.1
    IL_0126: nop
    IL_0127: nop
    IL_0128: stloc.0
    IL_0129: ldarg.0
    IL_012E: ldstr 0x70000121
    IL_0133: call 0x0A000004
    IL_0138: stfld 0x04000EF3
    IL_0139: ldarg.0
    IL_013E: ldfld 0x04000EF3
    IL_013F: ldnull
    IL_0144: call 0x0A000021
    IL_0149: brfalse IL_015B
    IL_014A: ldarg.0
    IL_014B: ldarg.0
    IL_0150: ldfld 0x04000EF3
    IL_0151: conv.r8
    IL_0152: IL_84
    IL_0153: nop
    IL_0154: nop
    IL_0156: br.s IL_01D4
    IL_0157: IL_F4
    IL_0159: ldarg.s 0
    IL_015A: ldarg.2
    IL_015B: ldarg.0
    IL_0160: ldstr 0x70022F5F
    IL_0165: call 0x06000220
    IL_016A: stfld 0x04000F08
    IL_016F: ldstr 0x70000617
    IL_0170: ldc.i4.7
    IL_0175: call 0x0A00009F
    IL_0176: ret
    }

    private void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000EFB
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000EFB
    IL_0010: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F05
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000F06
    IL_000E: ret
    }

    private void SetAngel() {
    IL_0000: ldarg.0
    IL_0005: ldsfld 0x040007B2
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000F01
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000EF1
    IL_0016: ldfld 0x04000521
    IL_0017: ldarg.1
    IL_0018: IL_8F
    IL_0019: conv.i8
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.0
    IL_0021: ldfld 0x0400051B
    IL_0026: call 0x0A0000E1
    IL_002B: stfld 0x04000F13
    IL_002C: ldarg.0
    IL_0031: ldsfld 0x040007B2
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000F01
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000EF1
    IL_0042: ldfld 0x04000521
    IL_0043: ldarg.1
    IL_0044: IL_8F
    IL_0045: conv.i8
    IL_0046: nop
    IL_0047: nop
    IL_0048: ldarg.0
    IL_004D: ldfld 0x0400051C
    IL_0052: call 0x0A0000E1
    IL_0057: stfld 0x04000F14
    IL_0058: ldarg.0
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_0060: ldc.i4 -243596735
    IL_0062: ldarg.s 0
    IL_0063: ldarg.2
    IL_0068: ldfld 0x04000521
    IL_0069: ldarg.1
    IL_006A: IL_8F
    IL_006B: conv.i8
    IL_006C: nop
    IL_006D: nop
    IL_006E: ldarg.0
    IL_0073: ldfld 0x0400051D
    IL_0074: IL_59
    IL_0079: stfld 0x04000F12
    IL_007A: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F05
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000F06
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000F06
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000F06
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
    IL_0033: stfld 0x04000F05
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000F06
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000EF6
    IL_0046: ldc.i4.s -64
    IL_0047: IL_3C
    IL_0049: brfalse.s IL_004A
    IL_004A: nop
    IL_004B: nop
    IL_004C: ldarg.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000EF6
    IL_0053: conv.i2
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000EF6
    IL_005A: shl
    IL_005B: conv.i2
    IL_0060: call 0x0A000024
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldc.i4.0
    IL_0065: IL_44
    IL_0066: IL_5A
    IL_006B: call 0x0A000114
    IL_006C: IL_58
    IL_006D: not
    IL_0072: stfld 0x04000EF6
    IL_0077: br IL_0080
    IL_0078: ldarg.0
    IL_007A: ldc.i4.s -64
    IL_007F: stfld 0x04000EF6
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000EFF
    IL_0086: ldc.i4.0
    IL_0087: IL_3E
    IL_008C: ldsflda 0x02000000
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000EF7
    IL_0093: conv.i2
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000EF7
    IL_009A: conv.i2
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00AC: not
    IL_00B1: stfld 0x04000EF7
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x04000EF7
    IL_00B8: ldc.i4.0
    IL_00B9: IL_3D
    IL_00BC: ldloc 0
    IL_00BD: nop
    IL_00BE: ldarg.0
    IL_00BF: ldc.i4.0
    IL_00C4: stfld 0x04000EF7
    IL_00C5: ldarg.0
    IL_00C6: ldarg.0
    IL_00CB: ldfld 0x04000EF8
    IL_00CC: conv.i2
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000EF8
    IL_00D3: conv.i2
    IL_00D8: call 0x0A000024
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: IL_FA
    IL_00DD: IL_43
    IL_00DE: IL_5A
    IL_00E3: call 0x0A000114
    IL_00E4: IL_59
    IL_00E5: not
    IL_00EA: stfld 0x04000EF8
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x04000EF8
    IL_00F5: ldc.i4 230
    IL_00F6: IL_3D
    IL_00F7: stloc.1
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: ldarg.0
    IL_0100: ldc.i4 230
    IL_0105: stfld 0x04000EF8
    IL_010A: br IL_0121
    IL_010B: ldarg.0
    IL_0110: ldc.i4 480
    IL_0115: stfld 0x04000EF7
    IL_0116: ldarg.0
    IL_011B: ldc.i4 340
    IL_0120: stfld 0x04000EF8
    IL_0121: ldc.i4.0
    IL_0126: call 0x0A0000D6
    IL_012B: brfalse IL_016F
    IL_0130: call 0x0A0000D7
    IL_0131: stloc.1
    IL_0133: ldloca.s 1
    IL_0138: ldfld 0x0A000023
    IL_0139: ldarg.0
    IL_013E: ldfld 0x04000F0D
    IL_013F: IL_41
    IL_0140: pop
    IL_0141: nop
    IL_0142: nop
    IL_0143: nop
    IL_0144: ldarg.0
    IL_0145: ldc.i4.1
    IL_014A: stfld 0x04000F09
    IL_014B: ldarg.0
    IL_0150: call 0x0A0000D7
    IL_0151: stloc.2
    IL_0153: ldloca.s 2
    IL_0158: ldfld 0x0A00005E
    IL_015D: stfld 0x04000F0B
    IL_015E: ldarg.0
    IL_015F: ldarg.0
    IL_0164: ldfld 0x04000F0E
    IL_0169: stfld 0x04000F0C
    IL_016E: br IL_0188
    IL_016F: ldc.i4.0
    IL_0174: call 0x0A0000D8
    IL_0179: brfalse IL_0188
    IL_017A: ldarg.0
    IL_017B: ldc.i4.0
    IL_0180: stfld 0x04000F09
    IL_0181: ldarg.0
    IL_0182: ldc.i4.0
    IL_0187: stfld 0x04000F0A
    IL_0188: ldarg.0
    IL_018D: ldfld 0x04000F09
    IL_0192: brfalse IL_0218
    IL_0197: call 0x0A0000D7
    IL_0198: stloc.3
    IL_019A: ldloca.s 3
    IL_019F: ldfld 0x0A00005E
    IL_01A0: ldarg.0
    IL_01A5: ldfld 0x04000F0B
    IL_01A6: IL_59
    IL_01AB: call 0x0A00007F
    IL_01AC: IL_22
    IL_01AD: nop
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: IL_41
    IL_01B1: IL_43
    IL_01B2: ldloc.1
    IL_01B3: nop
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: ldarg.0
    IL_01B7: ldc.i4.1
    IL_01BC: stfld 0x04000F0A
    IL_01BD: ldarg.0
    IL_01C2: call 0x0A0000D7
    IL_01C4: stloc.s 4
    IL_01C6: ldloca.s 4
    IL_01CB: ldfld 0x0A00005E
    IL_01CC: ldarg.0
    IL_01D1: ldfld 0x04000F0B
    IL_01D2: IL_59
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01D6: IL_F0
    IL_01D7: IL_43
    IL_01DC: call 0x0A0000D9
    IL_01DD: conv.i2
    IL_01DE: add
    IL_01DF: IL_5A
    IL_01E0: ldarg.0
    IL_01E5: ldfld 0x04000F0C
    IL_01E6: IL_58
    IL_01EB: stfld 0x04000F0E
    IL_01EC: ldarg.0
    IL_01ED: ldarg.0
    IL_01F2: ldfld 0x04000F0E
    IL_01F3: IL_22
    IL_01F4: nop
    IL_01F5: nop
    IL_01F6: nop
    IL_01F7: nop
    IL_01FC: call 0x0A000114
    IL_0201: stfld 0x04000F0E
    IL_0202: ldarg.0
    IL_0203: ldarg.0
    IL_0208: ldfld 0x04000F0E
    IL_0209: IL_22
    IL_020A: nop
    IL_020B: nop
    IL_020C: ldc.i4.0
    IL_020D: IL_C3
    IL_0212: call 0x0A00019C
    IL_0217: stfld 0x04000F0E
    IL_021C: ldstr 0x7000064F
    IL_0221: call 0x0A000095
    IL_0222: stloc.0
    IL_0223: ldloc.0
    IL_0224: ldc.i4.1
    IL_02D5: switch (43 cases)
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

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000EF2
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
    IL_0025: stfld 0x04000EF2
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000EF2
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
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000EEF
    IL_0040: call 0x0A0000DF
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000EF6
    IL_0047: conv.i2
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldelem.r8
    IL_0051: IL_43
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldelem.r8
    IL_0056: IL_43
    IL_005B: call 0x0600021D
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000ED5
    IL_0066: call 0x0A0000E0
    IL_0067: IL_22
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_FC
    IL_006B: IL_42
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_006F: IL_F0
    IL_0070: IL_41
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_C8
    IL_0075: IL_42
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_007B: ldloc 10306
    IL_007C: ldc.i4.7
    IL_007D: ldarg.0
    IL_007E: nop
    IL_007F: ldloc.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000ED6
    IL_008A: call 0x0A0000E0
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_58
    IL_008F: IL_43
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0093: IL_50
    IL_0094: IL_42
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: ldelem.r8
    IL_0099: IL_42
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_C0
    IL_009E: IL_41
    IL_00A3: call 0x0600021D
    IL_00A8: ldsfld 0x040007B2
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000F01
    IL_00B0: ldc.i4.s 74
    IL_00B5: call 0x0A0000E1
    IL_00BA: call 0x0A0002EA
    IL_00BB: IL_22
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: IL_E0
    IL_00BF: IL_42
    IL_00C0: IL_22
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00CC: stsfld 0x00002243
    IL_00CD: nop
    IL_00CE: IL_42
    IL_00D3: call 0x0600021D
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000EE4
    IL_00DE: call 0x0A0000E0
    IL_00DF: IL_22
    IL_00E0: nop
    IL_00E1: nop
    IL_00E3: ldloca.s 67
    IL_00E4: IL_22
    IL_00E5: nop
    IL_00E6: nop
    IL_00E7: IL_C0
    IL_280000174: switch (2684354594 cases)
    }

    }}
