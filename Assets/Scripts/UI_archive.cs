// Namespace: 
// Type: UI_archive

    public class UI_archive {{

    private static object MAXSKILL;
    private static object MAXARCHIVE;
    private static object MAXGENERALPOOL;
    private static object MAXTREASURE;
    public object icon_warning;
    public object bg_archive;
    public object txt_name;
    public object archive_complete;
    public object archive_gift;
    public object bg_archiverate;
    public object gauge_rate;
    public object bg_black;
    public object bg_title;
    public object pop_blank2;
    public object icon_jade;
    public object icon_coin;
    public object bg_asset;
    public object bg_scroll;
    public object titlebase;
    public object numberbase;
    public object please_touch;
    public object bg_general_detail;
    public object bt_roullete;
    public object bt_roullete_active;
    public object img_kind;
    public object prt_general;
    public object icon_treasure;
    public object gifticon;
    private object treasure_gift;
    public object bt_yesno;
    public object bt_back;
    public object bt_kind;
    public object bt_general;
    public object bt_empty;
    public object basicSkin;
    private object select_index;
    private object inactive;
    private object cashshop;
    private object sound_UI;
    private object script_soundUI;
    private object script_archname;
    private object script_name;
    private object script_archive;
    private object scrollPosition;
    private object prev_scrollPosition;
    private object startMousePosY;
    private object curMousePosY;
    private object bg_posX_l;
    private object bg_posX_r;
    private object icon_posY;
    private object imagemovefinish;
    private object b_delay;
    private object f_delay;
    private object confirm;
    private object selectgeneral;
    private object coin;
    private object jade;
    private object selectblank;
    private object expand_height;
    private object expand_height2;
    private object language;
    private object step;
    private object count_staff;
    private object count_treasure;
    private object temp_treasure;
    private object temp_staff;
    private object complete_archive;
    private object current_archive;
    private object rate_archive;
    private object gift_archive;
    private object warning_newarchive;
    private object warning_newtreasure;
    private object unlock_costume;
    private object bosskill;
    private object skill_use;
    private object pet_skill_use;
    private object enemykill;
    private object grappling;
    private object exattack;
    private object death;
    private object resurrection;
    private object cashing;
    private object max_stage_index;
    private object remain_arch;
    private object icon_size;
    private object tutorial;
    private object generalsearch;
    private object cur_skill_grade;
    private object caveplay;
    private object perfectplay;

    public UI_archive() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000C25
    IL_000C: ldarg.0
    IL_000E: ldc.i4.s 30
    IL_0013: newarr 0x0100003C
    IL_0018: stfld 0x04000C26
    IL_0019: ldarg.0
    IL_001B: ldc.i4.s 24
    IL_0020: newarr 0x0100003C
    IL_0025: stfld 0x04000C27
    IL_0026: ldarg.0
    IL_0027: ldc.i4.6
    IL_002C: newarr 0x0100003C
    IL_0031: stfld 0x04000C28
    IL_0032: ldarg.0
    IL_0033: ldc.i4.6
    IL_0038: newarr 0x01000013
    IL_003D: stfld 0x04000C29
    IL_003E: ldarg.0
    IL_003F: ldc.i4.m1
    IL_0044: stfld 0x04000C30
    IL_0045: ldarg.0
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: IL_3F
    IL_005E: newobj 0x0A0000C4
    IL_0063: stfld 0x04000C31
    IL_0064: ldarg.0
    IL_0069: call 0x0A000057
    IL_006E: stfld 0x04000C38
    IL_006F: ldarg.0
    IL_0074: call 0x0A000057
    IL_0079: stfld 0x04000C39
    IL_007A: ldarg.0
    IL_007B: ldc.i4.m1
    IL_0080: stfld 0x04000C43
    IL_0081: ldarg.0
    IL_0082: ldc.i4.m1
    IL_0087: stfld 0x04000C46
    IL_0088: ldarg.0
    IL_008A: ldc.i4.s 24
    IL_008F: newarr 0x0100000B
    IL_0094: stfld 0x04000C4D
    IL_0095: ldarg.0
    IL_0097: ldc.i4.s 30
    IL_009C: newarr 0x0100000B
    IL_00A1: stfld 0x04000C4E
    IL_00A2: ldarg.0
    IL_00A4: ldc.i4.s 76
    IL_00A9: newarr 0x0100000B
    IL_00AE: stfld 0x04000C4F
    IL_00AF: ldarg.0
    IL_00B1: ldc.i4.s 76
    IL_00B6: newarr 0x0100000B
    IL_00BB: stfld 0x04000C50
    IL_00BC: ldarg.0
    IL_00BE: ldc.i4.s 76
    IL_00C3: newarr 0x0100000B
    IL_00C8: stfld 0x04000C51
    IL_00C9: ldarg.0
    IL_00CB: ldc.i4.s 76
    IL_00D0: newarr 0x01000013
    IL_00D5: stfld 0x04000C52
    IL_00D6: ldarg.0
    IL_00D8: ldc.i4.s 20
    IL_00DD: newarr 0x0100000B
    IL_00E2: stfld 0x04000C55
    IL_00E3: ldarg.0
    IL_00E5: ldc.i4.s 12
    IL_00EA: newarr 0x0100000B
    IL_00EF: stfld 0x04000C56
    IL_00F0: ldarg.0
    IL_00F2: ldc.i4.s 20
    IL_00F7: newarr 0x0100000B
    IL_00FC: stfld 0x04000C57
    IL_00FD: ldarg.0
    IL_00FE: ldc.i4.2
    IL_0103: newarr 0x0100000B
    IL_0108: stfld 0x04000C58
    IL_0109: ldarg.0
    IL_010A: ldc.i4.m1
    IL_010F: stfld 0x04000C5F
    IL_0110: ldarg.0
    IL_0112: ldc.i4.s 20
    IL_0117: newarr 0x0100000B
    IL_011C: stfld 0x04000C64
    IL_011D: ldarg.0
    IL_0122: call 0x0A000001
    IL_0123: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000C44
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000C45
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000C49
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: call 0x2B000057
    IL_001B: stfld 0x04000C37
    IL_001C: ldarg.0
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_BE
    IL_0021: IL_C3
    IL_0026: stfld 0x04000C3C
    IL_0027: ldarg.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_F0
    IL_002C: IL_43
    IL_0031: stfld 0x04000C3D
    IL_0032: ldarg.0
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_AA
    IL_0037: IL_43
    IL_003C: stfld 0x04000C3E
    IL_003D: ldarg.0
    IL_0042: ldstr 0x70001FC1
    IL_0047: call 0x060003F9
    IL_004C: stfld 0x04000C4D
    IL_004D: ldarg.0
    IL_0052: ldstr 0x70001FD3
    IL_0057: call 0x060003F9
    IL_005C: stfld 0x04000C4E
    IL_005D: ldarg.0
    IL_0062: ldstr 0x70002093
    IL_0067: call 0x06000220
    IL_006C: stfld 0x04000C62
    IL_006D: ldarg.0
    IL_0072: ldstr 0x70000121
    IL_0077: call 0x0A000004
    IL_007C: stfld 0x04000C33
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000C33
    IL_0083: ldnull
    IL_0088: call 0x0A000021
    IL_008D: brfalse IL_009F
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000C33
    IL_0095: conv.r8
    IL_0096: IL_84
    IL_0097: nop
    IL_0098: nop
    IL_009A: br.s IL_0118
    IL_009B: IL_34
    IL_009C: stloc.2
    IL_009D: nop
    IL_009E: ldarg.2
    IL_009F: ldarg.0
    IL_00A0: ldarg.0
    IL_00A5: call 0x2B000085
    IL_00AA: stfld 0x04000C36
    IL_00AB: ldarg.0
    IL_00AC: ldarg.0
    IL_00B1: call 0x2B000086
    IL_00B6: stfld 0x04000C35
    IL_00B7: ldarg.0
    IL_00BC: ldstr 0x70001FDF
    IL_00C1: call 0x060003F9
    IL_00C6: stfld 0x04000C4F
    IL_00C7: ldarg.0
    IL_00CC: ldstr 0x70001FEF
    IL_00D1: call 0x060003F9
    IL_00D6: stfld 0x04000C56
    IL_00D7: ldarg.0
    IL_00DC: ldstr 0x70002001
    IL_00E1: call 0x060003F9
    IL_00E6: stfld 0x04000C57
    IL_00E7: ldarg.0
    IL_00EC: ldstr 0x70002015
    IL_00F1: call 0x060003F9
    IL_00F6: stfld 0x04000C58
    IL_00F7: ldarg.0
    IL_00FC: ldstr 0x70002031
    IL_0101: call 0x06000220
    IL_0106: stfld 0x04000C59
    IL_0107: ldarg.0
    IL_010C: ldstr 0x70002045
    IL_0111: call 0x06000220
    IL_0116: stfld 0x04000C5A
    IL_0117: ldarg.0
    IL_011C: ldstr 0x70000EC9
    IL_0121: call 0x06000220
    IL_0126: stfld 0x04000C5B
    IL_0127: ldarg.0
    IL_012C: ldstr 0x70002059
    IL_0131: call 0x06000220
    IL_0136: stfld 0x04000C5C
    IL_0137: ldarg.0
    IL_013C: ldstr 0x700015BF
    IL_0141: call 0x06000220
    IL_0146: stfld 0x04000C5D
    IL_0147: ldarg.0
    IL_014C: ldstr 0x700004DD
    IL_0151: call 0x06000220
    IL_0156: stfld 0x04000C5F
    IL_0157: ldarg.0
    IL_015C: ldstr 0x70001EE5
    IL_0161: call 0x060003F9
    IL_0166: stfld 0x04000C55
    IL_0167: ldarg.0
    IL_016C: ldstr 0x700020A5
    IL_0171: call 0x06000220
    IL_0176: stfld 0x04000C5E
    IL_0177: ldarg.0
    IL_017C: ldstr 0x70001F55
    IL_0181: call 0x06000220
    IL_0186: stfld 0x04000C63
    IL_0187: ldarg.0
    IL_018C: ldstr 0x7000054F
    IL_0191: call 0x060003F9
    IL_0196: stfld 0x04000C64
    IL_0197: ldarg.0
    IL_019C: ldstr 0x70001F71
    IL_01A1: call 0x06000220
    IL_01A6: stfld 0x04000C65
    IL_01A7: ldarg.0
    IL_01AC: ldstr 0x70001F83
    IL_01B1: call 0x06000220
    IL_01B6: stfld 0x04000C66
    IL_01B7: ldc.i4.0
    IL_01B8: stloc.0
    IL_01BD: br IL_0AD3
    IL_01BE: ldarg.0
    IL_01C3: ldfld 0x04000C4F
    IL_01C4: ldloc.0
    IL_01C5: IL_94
    IL_01CA: brtrue IL_0ACF
    IL_01CB: ldarg.0
    IL_01CC: dup
    IL_01D1: ldfld 0x04000C60
    IL_01D2: ldc.i4.1
    IL_01D3: IL_58
    IL_01D8: stfld 0x04000C60
    IL_01D9: ldarg.0
    IL_01DE: ldfld 0x04000C37
    IL_01E3: ldfld 0x0400049F
    IL_01E4: ldloc.0
    IL_01E5: IL_8F
    IL_01E6: IL_57
    IL_01E7: nop
    IL_01E8: nop
    IL_01E9: ldarg.0
    IL_01EE: ldfld 0x0400049C
    IL_01F0: stloc.s 10
    IL_01F2: ldloc.s 10
    IL_01F3: ldc.i4.1
    IL_01F4: IL_59
    IL_01F7: ldarg 20
    IL_01F8: nop
    IL_01F9: nop
    IL_01FA: ldarg.3
    IL_01FB: nop
    IL_01FC: nop
    IL_01FD: nop
    IL_01FE: conv.r4
    IL_01FF: nop
    IL_0200: nop
    IL_0201: nop
    IL_0202: IL_D7
    IL_0203: nop
    IL_0204: nop
    IL_0205: nop
    IL_2A400020E: switch (2835349505 cases)
    }

    public void FindNewTreasure() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0008: br IL_0085
    IL_0009: ldc.i4.0
    IL_000A: stloc.2
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000C4D
    IL_0011: ldc.i4.4
    IL_0012: ldloc.1
    IL_0013: IL_5A
    IL_0014: IL_94
    IL_0015: ldc.i4.0
    IL_0016: IL_3E
    IL_0017: ldarg.2
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldloc.2
    IL_001C: ldc.i4.1
    IL_001D: IL_58
    IL_001E: stloc.2
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000C4D
    IL_0025: ldc.i4.4
    IL_0026: ldloc.1
    IL_0027: IL_5A
    IL_0028: ldc.i4.1
    IL_0029: IL_58
    IL_002A: IL_94
    IL_002B: ldc.i4.0
    IL_002C: IL_3E
    IL_002D: ldarg.2
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0031: ldloc.2
    IL_0032: ldc.i4.1
    IL_0033: IL_58
    IL_0034: stloc.2
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000C4D
    IL_003B: ldc.i4.4
    IL_003C: ldloc.1
    IL_003D: IL_5A
    IL_003E: ldc.i4.2
    IL_003F: IL_58
    IL_0040: IL_94
    IL_0041: ldc.i4.0
    IL_0042: IL_3E
    IL_0043: ldarg.2
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: ldloc.2
    IL_0048: ldc.i4.1
    IL_0049: IL_58
    IL_004A: stloc.2
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000C4D
    IL_0051: ldc.i4.4
    IL_0052: ldloc.1
    IL_0053: IL_5A
    IL_0054: ldc.i4.3
    IL_0055: IL_58
    IL_0056: IL_94
    IL_0057: ldc.i4.0
    IL_0058: IL_3E
    IL_0059: ldarg.2
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: ldloc.2
    IL_005E: ldc.i4.1
    IL_005F: IL_58
    IL_0060: stloc.2
    IL_0061: ldloc.2
    IL_0062: ldc.i4.4
    IL_00A7: switch (16 cases)
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000C61
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000C61
    IL_0010: ret
    }

    public void IsWarning() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_001A
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000C52
    IL_000D: ldloc.0
    IL_000E: IL_91
    IL_0013: brfalse IL_0016
    IL_0014: ldc.i4.1
    IL_0015: ret
    IL_0016: ldloc.0
    IL_0017: ldc.i4.1
    IL_0018: IL_58
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001C: ldc.i4.s 76
    IL_001D: IL_3F
    IL_001E: IL_E5
    IL_001F: IL_FF
    IL_0020: IL_FF
    IL_0021: IL_FF
    IL_0022: ldc.i4.0
    IL_0023: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000C40
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000C41
    IL_000E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000C40
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000C41
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000C41
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000C41
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
    IL_0033: stfld 0x04000C40
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000C41
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000C3F
    IL_0049: brtrue IL_0111
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000C3C
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x002941C2
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000C3C
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000C3C
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
    IL_007D: stfld 0x04000C3C
    IL_0082: br IL_0111
    IL_0083: ldarg.0
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_008B: stsfld 0x0C3C7DC2
    IL_008C: nop
    IL_008D: ldarg.2
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000C3D
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000C3D
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00B0: stfld 0x04000C3D
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000C3D
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
    IL_00CB: stfld 0x04000C3D
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000C3E
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000C3E
    IL_00DD: call 0x0A000024
    IL_00DE: IL_22
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_FA
    IL_00E2: IL_43
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000114
    IL_00E9: IL_59
    IL_00EE: stfld 0x04000C3E
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000C3E
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
    IL_0109: stfld 0x04000C3E
    IL_010A: ldarg.0
    IL_010B: ldc.i4.1
    IL_0110: stfld 0x04000C3F
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

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000C32
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
    IL_0025: stfld 0x04000C32
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000C32
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

    public void sortAchieve() {
    IL_0001: ldc.i4.s 76
    IL_0006: newarr 0x0100000B
    IL_0007: stloc.0
    IL_000C: newobj 0x0A00030B
    IL_000D: stloc.1
    IL_0012: newobj 0x0A00030B
    IL_0013: stloc.2
    IL_0018: newobj 0x0A00030B
    IL_0019: stloc.3
    IL_001A: ldc.i4.0
    IL_001C: stloc.s 4
    IL_0021: br IL_0067
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000C52
    IL_0029: ldloc.s 4
    IL_002A: IL_91
    IL_002F: brfalse IL_003D
    IL_0030: ldloc.1
    IL_0032: ldloc.s 4
    IL_0033: conv.r8
    IL_0034: stloc.2
    IL_0035: ldarg.1
    IL_0036: nop
    IL_0037: stloc.0
    IL_003C: br IL_0061
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000C4F
    IL_0044: ldloc.s 4
    IL_0045: IL_94
    IL_0046: ldc.i4.1
    IL_007F: switch (13 cases)
    IL_0081: ldarg.s 3
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldloc.3
    IL_0085: conv.r8
    IL_0087: ldarg.s 3
    IL_0088: nop
    IL_0089: stloc.0
    IL_008A: ldarg.0
    IL_008B: ldloc.1
    IL_008C: conv.r8
    IL_008E: ldarga.s 3
    IL_008F: nop
    IL_0090: stloc.0
    IL_0095: stfld 0x04000C50
    IL_0096: ldloc.1
    IL_0097: conv.r8
    IL_0099: ldarg.s 3
    IL_009A: nop
    IL_009B: stloc.0
    IL_009C: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000C2F
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
    IL_0046: ldfld 0x04000C42
    IL_0047: ldc.i4.0
    IL_0048: IL_3E
    IL_0049: ldloc.0
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldc.i4.0
    IL_0052: call 0x0A0001B9
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000C3C
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
    IL_0072: ldfld 0x04000C12
    IL_0077: call 0x0A0000E0
    IL_0078: IL_22
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_F0
    IL_007C: IL_42
    IL_007D: IL_22
    IL_007E: nop
    IL_007F: nop
    IL_0080: IL_F0
    IL_0081: IL_41
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0085: IL_C8
    IL_0086: IL_42
    IL_0087: IL_22
    IL_0088: nop
    IL_0089: nop
    IL_008C: ldloc 10306
    IL_008D: ldc.i4.7
    IL_008E: ldarg.0
    IL_008F: nop
    IL_0090: ldloc.0
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000C13
    IL_009B: call 0x0A0000E0
    IL_009C: IL_22
    IL_009D: nop
    IL_009E: nop
    IL_009F: IL_58
    IL_00A0: IL_43
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: IL_50
    IL_00A5: IL_42
    IL_00A6: IL_22
    IL_00A7: nop
    IL_00A8: nop
    IL_00A9: ldelem.r8
    IL_00AA: IL_42
    IL_00AB: IL_22
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: IL_C0
    IL_00AF: IL_41
    IL_00B4: call 0x0600021D
    IL_00B9: ldsfld 0x040007B2
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000C49
    IL_00C4: ldc.i4 195
    IL_00C9: call 0x0A0000E1
    IL_00CE: call 0x0A0002EA
    IL_00CF: IL_22
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: IL_E0
    IL_00D3: IL_42
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00E0: stsfld 0x00002243
    IL_00E1: nop
    IL_00E2: IL_42
    IL_00E7: call 0x0600021D
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x04000C1D
    IL_00F2: call 0x0A0000E0
    IL_00F3: IL_22
    IL_00F4: nop
    IL_00F5: nop
    IL_00F7: ldloca.s 67
    IL_00F8: IL_22
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: IL_C0
    IL_280000188: switch (2684354594 cases)
    }

    }}
