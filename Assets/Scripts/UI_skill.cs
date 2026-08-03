// Namespace: 
// Type: UI_skill

    public class UI_skill {{

    private static object MAXSKILL;
    public object bg_skill;
    public object txt_name;
    public object bg_black;
    public object bg_black100;
    public object pop_detail;
    public object pop_blank;
    public object pop_blank2;
    private object cost_icon;
    public object bg_asset;
    public object titlebase;
    public object titlebase_w;
    public object arrow;
    public object active_slot;
    public object icon_jade;
    public object icon_coin;
    public object icon_soul;
    public object please_touch;
    public object skillicon;
    public object icon_diamond;
    public object bt_skill;
    public object bt_yesno;
    public object bt_back;
    public object bt_skill_slot;
    public object bt_empty;
    public object basicSkin;
    public object sound_dummy;
    private object cashshop;
    private object sound_UI;
    private object script_soundUI;
    private object bg_posX_l;
    private object bg_posX_r;
    private object icon_posY;
    private object selectskill;
    private object popupOn;
    private object b_delay;
    private object f_delay;
    private object confirm;
    private object dragOn;
    private object scrollOn;
    private object dragposX;
    private object prevposX;
    private object currentX;
    private object dragrange;
    private object chalevel;
    private object coin;
    private object jade;
    private object updatestring;
    private object imagemovefinish;
    public object cur_skill_grade;
    private object ss;
    private object skill_slot;
    private object language;
    private object emptyslot;
    private object tutorial;
    private object icon_size;
    private object ss_url;
    private object ss_skill;
    private object imageloading;
    private object showimg;
    private object www;

    public UI_skill() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 20
    IL_0007: newarr 0x0100003C
    IL_000C: stfld 0x04000F81
    IL_000D: ldarg.0
    IL_000E: ldc.i4.3
    IL_0013: newarr 0x0100003C
    IL_0018: stfld 0x04000F82
    IL_0019: ldarg.0
    IL_001B: ldc.i4.s 20
    IL_0020: newarr 0x0100000B
    IL_0025: stfld 0x04000FA0
    IL_0026: ldarg.0
    IL_0028: ldc.i4.s 20
    IL_0029: ldc.i4.5
    IL_002E: newobj 0x0A00016D
    IL_0033: stfld 0x04000FA1
    IL_0034: ldarg.0
    IL_0035: ldc.i4.5
    IL_003A: newarr 0x0100000B
    IL_003F: stfld 0x04000FA2
    IL_0040: ldarg.0
    IL_0041: ldc.i4.m1
    IL_0046: stfld 0x04000FA4
    IL_0047: ldarg.0
    IL_0049: ldc.i4.s 20
    IL_004E: newarr 0x0100000C
    IL_0053: stfld 0x04000FA7
    IL_0054: ldarg.0
    IL_0059: call 0x0A000001
    IL_005A: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FA7
    IL_0006: ldc.i4.0
    IL_000B: ldstr 0x700241C6
    IL_0010: stelem 0x0FA77B02
    IL_0011: nop
    IL_0012: ldarg.2
    IL_0013: ldc.i4.1
    IL_0018: ldstr 0x70024234
    IL_001D: stelem 0x0FA77B02
    IL_001E: nop
    IL_001F: ldarg.2
    IL_0020: ldc.i4.2
    IL_0025: ldstr 0x700242A2
    IL_002A: stelem 0x0FA77B02
    IL_002B: nop
    IL_002C: ldarg.2
    IL_002D: ldc.i4.3
    IL_0032: ldstr 0x70024310
    IL_0037: stelem 0x0FA77B02
    IL_0038: nop
    IL_0039: ldarg.2
    IL_003A: ldc.i4.4
    IL_003F: ldstr 0x7002437E
    IL_0044: stelem 0x0FA77B02
    IL_0045: nop
    IL_0046: ldarg.2
    IL_0047: ldc.i4.5
    IL_004C: ldstr 0x700243EC
    IL_0051: stelem 0x0FA77B02
    IL_0052: nop
    IL_0053: ldarg.2
    IL_0054: ldc.i4.6
    IL_0059: ldstr 0x7002445A
    IL_005E: stelem 0x0FA77B02
    IL_005F: nop
    IL_0060: ldarg.2
    IL_0061: ldc.i4.7
    IL_0066: ldstr 0x700244C8
    IL_006B: stelem 0x0FA77B02
    IL_006C: nop
    IL_006D: ldarg.2
    IL_006E: ldc.i4.8
    IL_0073: ldstr 0x70024536
    IL_0078: stelem 0x0FA77B02
    IL_0079: nop
    IL_007A: ldarg.2
    IL_007C: ldc.i4.s 9
    IL_0081: ldstr 0x700245A4
    IL_0086: stelem 0x0FA77B02
    IL_0087: nop
    IL_0088: ldarg.2
    IL_008A: ldc.i4.s 10
    IL_008F: ldstr 0x70024612
    IL_0094: stelem 0x0FA77B02
    IL_0095: nop
    IL_0096: ldarg.2
    IL_0098: ldc.i4.s 11
    IL_009D: ldstr 0x70024680
    IL_00A2: stelem 0x0FA77B02
    IL_00A3: nop
    IL_00A4: ldarg.2
    IL_00A6: ldc.i4.s 12
    IL_00AB: ldstr 0x700246EE
    IL_00B0: stelem 0x0FA77B02
    IL_00B1: nop
    IL_00B2: ldarg.2
    IL_00B4: ldc.i4.s 13
    IL_00B9: ldstr 0x7002475C
    IL_00BE: stelem 0x0FA77B02
    IL_00BF: nop
    IL_00C0: ldarg.2
    IL_00C2: ldc.i4.s 14
    IL_00C7: ldstr 0x700247CA
    IL_00CC: stelem 0x0FA77B02
    IL_00CD: nop
    IL_00CE: ldarg.2
    IL_00D0: ldc.i4.s 15
    IL_00D5: ldstr 0x70024838
    IL_00DA: stelem 0x0FA77B02
    IL_00DB: nop
    IL_00DC: ldarg.2
    IL_00DE: ldc.i4.s 16
    IL_00E3: ldstr 0x700248A6
    IL_00E8: stelem 0x0FA77B02
    IL_00E9: nop
    IL_00EA: ldarg.2
    IL_00EC: ldc.i4.s 17
    IL_00F1: ldstr 0x70024914
    IL_00F6: stelem 0x0FA77B02
    IL_00F7: nop
    IL_00F8: ldarg.2
    IL_00FA: ldc.i4.s 18
    IL_00FF: ldstr 0x70024982
    IL_0104: stelem 0x0FA77B02
    IL_0105: nop
    IL_0106: ldarg.2
    IL_0108: ldc.i4.s 19
    IL_010D: ldstr 0x700249F0
    IL_0112: stelem 0x00000000
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F9C
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F9D
    IL_0020: ret
    }

    private void ShotLoading() {
    IL_0004: newobj 0x060007D5
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x040010B0
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x040010B3
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_001A: stfld 0x040010B4
    IL_001B: ldloc.0
    IL_001C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001F9B
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x04000FA2
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000DDD
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F9B
    IL_0020: ldarg.0
    IL_0025: call 0x0A0000DA
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: IL_C0
    IL_002B: IL_3E
    IL_002C: IL_5A
    IL_0031: stfld 0x04000F9A
    IL_0032: ldarg.0
    IL_0037: ldstr 0x70000BB3
    IL_003C: call 0x0A000095
    IL_0041: stfld 0x04000FA3
    IL_0042: ldarg.0
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_BE
    IL_0047: IL_C3
    IL_004C: stfld 0x04000F8D
    IL_004D: ldarg.0
    IL_004E: IL_22
    IL_004F: nop
    IL_0050: nop
    IL_0051: IL_F0
    IL_0052: IL_43
    IL_0057: stfld 0x04000F8E
    IL_0058: ldarg.0
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: IL_AA
    IL_005D: IL_43
    IL_0062: stfld 0x04000F8F
    IL_0063: ldarg.0
    IL_0064: ldarg.0
    IL_0069: call 0x2B00008F
    IL_006E: ldfld 0x04000505
    IL_0073: stfld 0x04000FA1
    IL_0074: ldarg.0
    IL_0079: ldstr 0x70002093
    IL_007E: call 0x06000220
    IL_0083: stfld 0x04000FA5
    IL_0084: ldarg.0
    IL_0089: ldstr 0x7000054F
    IL_008E: call 0x060003F9
    IL_0093: stfld 0x04000FA0
    IL_0098: ldstr 0x70000121
    IL_009D: call 0x0A000004
    IL_009E: ldnull
    IL_00A3: call 0x0A000061
    IL_00A8: brfalse IL_00CE
    IL_00A9: ldarg.0
    IL_00AA: ldarg.0
    IL_00AF: ldfld 0x04000F89
    IL_00B4: call 0x0A00001B
    IL_00B9: call 0x0A000013
    IL_00BE: call 0x0A000014
    IL_00BF: conv.u4
    IL_00C0: ldarg.1
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: IL_01
    IL_00C8: stfld 0x04000F8B
    IL_00CD: br IL_00E3
    IL_00CE: ldarg.0
    IL_00D3: ldstr 0x70000121
    IL_00D8: call 0x0A000004
    IL_00D9: conv.r8
    IL_00DA: ldarg.3
    IL_00DB: nop
    IL_00DC: nop
    IL_00DD: stloc.0
    IL_00E2: stfld 0x04000F8B
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000F8B
    IL_00E9: ldnull
    IL_00EE: call 0x0A000021
    IL_00F3: brfalse IL_0105
    IL_00F4: ldarg.0
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x04000F8B
    IL_00FB: conv.r8
    IL_0100: ldsfld 0x7D2B0000
    IL_0105: newobj 0x1604000F
    IL_0106: stloc.0
    IL_010B: br IL_0145
    IL_010C: ldarg.0
    IL_0111: ldfld 0x04000FA0
    IL_0112: ldloc.0
    IL_0113: IL_94
    IL_0115: ldc.i4.s -2
    IL_01B2: switch (38 cases)
    }

    public void UpdateSkillStat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FA1
    IL_0006: ldarg.1
    IL_0007: ldc.i4.0
    IL_000C: call 0x0A000134
    IL_0011: ldfld 0x040004FC
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000FA0
    IL_0019: ldarg.1
    IL_001A: IL_94
    IL_001B: ldc.i4.4
    IL_001C: IL_3F
    IL_001D: IL_01
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ret
    IL_0022: ldloc.0
    IL_0023: ldc.i4.1
    IL_00A8: switch (32 cases)
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000FA6
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000FA6
    IL_0010: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F92
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000F93
    IL_000E: ret
    }

    public void FindEmptySlot() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000FA4
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002C
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000FA2
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_0016: ldc.i4.m1
    IL_004B: switch (12 cases)
    }

    public void ShortCut() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F90
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000FA2
    IL_000C: ldarg.1
    IL_000D: IL_94
    IL_00C6: switch (45 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F92
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000F93
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000F93
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000F93
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
    IL_0033: stfld 0x04000F92
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000F93
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000F9F
    IL_0049: brtrue IL_0111
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000F8D
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x002941C2
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000F8D
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000F8D
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
    IL_007D: stfld 0x04000F8D
    IL_0082: br IL_0111
    IL_0083: ldarg.0
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_008B: stsfld 0x0F8D7DC2
    IL_008C: nop
    IL_008D: ldarg.2
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000F8E
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000F8E
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00B0: stfld 0x04000F8E
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000F8E
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
    IL_00CB: stfld 0x04000F8E
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000F8F
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000F8F
    IL_00DD: call 0x0A000024
    IL_00DE: IL_22
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_FA
    IL_00E2: IL_43
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000114
    IL_00E9: IL_59
    IL_00EE: stfld 0x04000F8F
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000F8F
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
    IL_0109: stfld 0x04000F8F
    IL_010A: ldarg.0
    IL_010B: ldc.i4.1
    IL_0110: stfld 0x04000F9F
    IL_0111: ldc.i4.0
    IL_0116: call 0x0A0000D6
    IL_011B: brfalse IL_015F
    IL_0120: call 0x0A0000D7
    IL_0121: stloc.1
    IL_0123: ldloca.s 1
    IL_0128: ldfld 0x0A000023
    IL_0129: ldarg.0
    IL_012E: ldfld 0x04000F9A
    IL_012F: IL_41
    IL_0130: pop
    IL_0131: nop
    IL_0132: nop
    IL_0133: nop
    IL_0134: ldarg.0
    IL_0135: ldc.i4.1
    IL_013A: stfld 0x04000F95
    IL_013B: ldarg.0
    IL_0140: call 0x0A0000D7
    IL_0141: stloc.2
    IL_0143: ldloca.s 2
    IL_0148: ldfld 0x0A00005E
    IL_014D: stfld 0x04000F98
    IL_014E: ldarg.0
    IL_014F: ldarg.0
    IL_0154: ldfld 0x04000F97
    IL_0159: stfld 0x04000F99
    IL_015E: br IL_0178
    IL_015F: ldc.i4.0
    IL_0164: call 0x0A0000D8
    IL_0169: brfalse IL_0178
    IL_016A: ldarg.0
    IL_016B: ldc.i4.0
    IL_0170: stfld 0x04000F95
    IL_0171: ldarg.0
    IL_0172: ldc.i4.0
    IL_0177: stfld 0x04000F96
    IL_0178: ldarg.0
    IL_017D: ldfld 0x04000F95
    IL_0182: brfalse IL_0208
    IL_0187: call 0x0A0000D7
    IL_0188: stloc.3
    IL_018A: ldloca.s 3
    IL_018F: ldfld 0x0A00005E
    IL_0190: ldarg.0
    IL_0195: ldfld 0x04000F98
    IL_0196: IL_59
    IL_019B: call 0x0A00007F
    IL_019C: IL_22
    IL_019D: nop
    IL_019E: nop
    IL_019F: nop
    IL_01A0: IL_41
    IL_01A1: IL_43
    IL_01A2: ldloc.1
    IL_01A3: nop
    IL_01A4: nop
    IL_01A5: nop
    IL_01A6: ldarg.0
    IL_01A7: ldc.i4.1
    IL_01AC: stfld 0x04000F96
    IL_01AD: ldarg.0
    IL_01B2: call 0x0A0000D7
    IL_01B4: stloc.s 4
    IL_01B6: ldloca.s 4
    IL_01BB: ldfld 0x0A00005E
    IL_01BC: ldarg.0
    IL_01C1: ldfld 0x04000F98
    IL_01C2: IL_59
    IL_01C3: IL_22
    IL_01C4: nop
    IL_01C5: nop
    IL_01C6: IL_F0
    IL_01C7: IL_43
    IL_01CC: call 0x0A0000D9
    IL_01CD: conv.i2
    IL_01CE: add
    IL_01CF: IL_5A
    IL_01D0: ldarg.0
    IL_01D5: ldfld 0x04000F99
    IL_01D6: IL_58
    IL_01DB: stfld 0x04000F97
    IL_01DC: ldarg.0
    IL_01DD: ldarg.0
    IL_01E2: ldfld 0x04000F97
    IL_01E3: IL_22
    IL_01E4: nop
    IL_01E5: nop
    IL_01E6: nop
    IL_01E7: nop
    IL_01EC: call 0x0A000114
    IL_01F1: stfld 0x04000F97
    IL_01F2: ldarg.0
    IL_01F3: ldarg.0
    IL_01F8: ldfld 0x04000F97
    IL_01F9: IL_22
    IL_01FA: nop
    IL_01FF: stsfld 0x9C28C484
    IL_0200: IL_01
    IL_0201: nop
    IL_0202: stloc.0
    IL_0207: stfld 0x04000F97
    IL_020C: ldstr 0x7000064F
    IL_0211: call 0x0A000095
    IL_0212: stloc.0
    IL_0213: ldloc.0
    IL_0214: ldc.i4.1
    IL_02C5: switch (43 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F8A
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
    IL_0025: stfld 0x04000F8A
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000F8A
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

    public void jumpSence() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000F91
    IL_0007: ldarg.1
    IL_000C: brtrue IL_001C
    IL_0011: ldstr 0x70022F87
    IL_0016: call 0x0A000128
    IL_001B: br IL_002D
    IL_001C: ldarg.1
    IL_001D: ldc.i4.1
    IL_004A: switch (10 cases)
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F88
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
    IL_0046: ldfld 0x04000F94
    IL_0047: ldc.i4.0
    IL_0048: IL_3D
    IL_0049: stloc.1
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000FAA
    IL_0057: brfalse IL_005E
    IL_0058: ldc.i4.0
    IL_005D: call 0x0A0001B9
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000F8D
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: ldelem.r8
    IL_006D: IL_43
    IL_006E: IL_22
    IL_006F: nop
    IL_0070: nop
    IL_0071: ldelem.r8
    IL_0072: IL_43
    IL_0077: call 0x0600021D
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000F70
    IL_0082: call 0x0A0000E0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000F8E
    IL_0089: IL_22
    IL_008A: nop
    IL_008B: nop
    IL_008C: rem
    IL_008D: IL_43
    IL_008E: IL_22
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_F0
    IL_0092: IL_43
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_C8
    IL_0097: IL_42
    IL_009C: call 0x0600021D
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x04000F72
    IL_00A7: call 0x0A0000E0
    IL_00A8: IL_22
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: IL_F0
    IL_00AC: IL_42
    IL_00AD: IL_22
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: IL_F0
    IL_00B1: IL_41
    IL_00B2: IL_22
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: IL_C8
    IL_00B6: IL_42
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BC: ldloc 10306
    IL_00BD: ldc.i4.7
    IL_00BE: ldarg.0
    IL_00BF: nop
    IL_00C0: ldloc.0
    IL_00C1: ldarg.0
    IL_00C6: ldfld 0x04000F71
    IL_00CB: call 0x0A0000E0
    IL_00CC: IL_22
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: IL_3E
    IL_00D0: IL_43
    IL_00D1: IL_22
    IL_00D2: nop
    IL_00D3: nop
    IL_00D8: newobj 0x00002242
    IL_00D9: ldelem.r8
    IL_00DA: IL_42
    IL_00DB: IL_22
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: IL_C0
    IL_00DF: IL_41
    IL_00E4: call 0x0600021D
    IL_00E9: ldsfld 0x040007B2
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000FA3
    IL_00F1: ldc.i4.s 68
    IL_00F6: call 0x0A0000E1
    IL_00FB: call 0x0A0002EA
    IL_00FC: IL_22
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: IL_E0
    IL_0100: IL_42
    IL_0101: IL_22
    IL_0102: nop
    IL_0103: nop
    IL_0104: nop
    IL_0105: nop
    IL_0106: IL_22
    IL_0107: nop
    IL_0108: nop
    IL_010D: stsfld 0x00002243
    IL_010E: nop
    IL_010F: IL_42
    IL_0114: call 0x0600021D
    IL_0115: ldarg.0
    IL_011A: ldfld 0x04000F78
    IL_011F: call 0x0A0000E0
    IL_0120: IL_22
    IL_0121: nop
    IL_0122: nop
    IL_0124: ldloca.s 67
    IL_0125: IL_22
    IL_0126: nop
    IL_0127: nop
    IL_0128: IL_C0
    IL_2800001B5: switch (2684354594 cases)
    }

    }}
