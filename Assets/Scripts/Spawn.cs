// Namespace: 
// Type: Spawn

    public class Spawn {{

    private static object ENEMY_POOL;
    private static object BOSS_POOL;
    public object stage;
    private object restrictArea;
    public object mon_destroy;
    public object enemy_source;
    public object boss;
    public object general_portrait;
    public object collider_ground;
    public object cart;
    public object tower;
    public object barrack;
    public object basecamp;
    public object tank;
    public object plane_staff;
    public object pt_soul;
    private object prt_general;
    private object prt_cha;
    private object c_basecamp;
    private object c_tower;
    private object c_barrack;
    private object c_tank;
    private object spawnenemy;
    private object clone_enemy;
    private object clone_Boss;
    private object c_stage;
    private object c_extraunit;
    private object enemyset;
    private object clone_destroy;
    private object clone_soul;
    public object cut_boss;
    public object monnum;
    public object rewardkind;
    public object pt_summonfog;
    private object c_dun_door;
    private object WAVEEMEMYNUM;
    private object totalEnemyNum;
    private object maxEnemyNum;
    private object regen;
    public object wave;
    public object finalstage;
    private object spawndelay;
    private object set_spawndelay;
    private object g_hp_length;
    private object countdown;
    private object stagefinish;
    private object play_kind;
    private object bosscount;
    private object cur_stage_index;
    private object infinity_stage_index;
    private object destroy_human_kind;
    private object destroy_beast_kind;
    private object destroy_last_kind;
    private object enemykind;
    private object cur_difficulty;
    private object oldstageindex;
    private object summon_amount;
    public object enemykill;
    public object grappling;
    private object summonpos;
    private object rndpos;
    private object temprndpos;
    private object rndpoint;
    private object rndoldpoint;
    private object allycount;
    private object general_index;
    private object g_grade;
    private object soulcount;
    private object barrack_count;
    private object tower_count;
    private object last_mon;
    public object infinitymode;
    private object script_stageDB;
    private object script_IngameUI;
    private object script_generalstat;
    private object script_g_hpgauge;
    private object script_DBgeneral;
    private object script_iconskill;
    private object script_cha;
    private object g_hpgauge;
    public object icon_dead;
    private object spawpoint;
    private object general_hp;
    private object bossindex;
    private object negativefactor;
    public object lightmap_tank;
    private object bosskill;
    public object cur_general;
    private object bossremain;
    private object restrict_Factor;

    public Spawn() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 10
    IL_0007: newarr 0x01000003
    IL_000C: stfld 0x04000918
    IL_000D: ldarg.0
    IL_000E: ldc.i4.8
    IL_0013: newarr 0x0100002F
    IL_0014: dup
    IL_0019: ldtoken 0x040010BE
    IL_001E: call 0x0A00018C
    IL_0023: stfld 0x04000919
    IL_0024: ldarg.0
    IL_0025: ldc.i4.4
    IL_002A: newarr 0x01000003
    IL_002F: stfld 0x0400091A
    IL_0030: ldarg.0
    IL_0032: ldc.i4.s 16
    IL_0037: newarr 0x01000003
    IL_003C: stfld 0x0400091B
    IL_003D: ldarg.0
    IL_003F: ldc.i4.s 11
    IL_0044: newarr 0x01000003
    IL_0049: stfld 0x0400091C
    IL_004A: ldarg.0
    IL_004B: ldc.i4.6
    IL_0050: newarr 0x01000003
    IL_0055: stfld 0x04000929
    IL_0056: ldarg.0
    IL_0057: ldc.i4.6
    IL_005C: newarr 0x01000003
    IL_0061: stfld 0x0400092A
    IL_0062: ldarg.0
    IL_0063: ldc.i4.4
    IL_0068: newarr 0x01000003
    IL_006D: stfld 0x04000931
    IL_006E: ldarg.0
    IL_006F: ldc.i4.6
    IL_0074: newarr 0x01000003
    IL_0079: stfld 0x04000932
    IL_007A: ldarg.0
    IL_007B: ldc.i4.3
    IL_0080: newarr 0x01000003
    IL_0085: stfld 0x04000933
    IL_0086: ldarg.0
    IL_0088: ldc.i4.s 40
    IL_008D: stfld 0x04000939
    IL_008E: ldarg.0
    IL_0090: ldc.i4.s 15
    IL_0095: stfld 0x0400093B
    IL_0096: ldarg.0
    IL_0097: ldc.i4.m1
    IL_009C: stfld 0x0400093C
    IL_009D: ldarg.0
    IL_009E: ldc.i4.1
    IL_00A3: stfld 0x0400093D
    IL_00A4: ldarg.0
    IL_00A5: ldc.i4.3
    IL_00AA: stfld 0x0400093E
    IL_00AB: ldarg.0
    IL_00AC: IL_22
    IL_00AD: nop
    IL_00AE: nop
    IL_00B3: stsfld 0x093F7D3F
    IL_00B4: nop
    IL_00B5: ldarg.2
    IL_00B6: ldarg.0
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BE: stsfld 0x09407D3F
    IL_00BF: nop
    IL_00C0: ldarg.2
    IL_00C1: ldarg.0
    IL_00C2: ldc.i4.3
    IL_00C7: stfld 0x04000949
    IL_00C8: ldarg.0
    IL_00C9: ldc.i4.m1
    IL_00CE: stfld 0x0400094D
    IL_00CF: ldarg.0
    IL_00D4: call 0x0A00001B
    IL_00D9: stfld 0x04000951
    IL_00DA: ldarg.0
    IL_00DB: ldc.i4.m1
    IL_00E0: stfld 0x04000955
    IL_00E1: ldarg.0
    IL_00E2: ldc.i4.6
    IL_00E7: stfld 0x0400095A
    IL_00E8: ldarg.0
    IL_00E9: ldc.i4.6
    IL_00EE: stfld 0x0400095B
    IL_00EF: ldarg.0
    IL_00F0: ldc.i4.8
    IL_00F5: newarr 0x01000007
    IL_00FA: stfld 0x04000967
    IL_00FB: ldarg.0
    IL_00FD: ldc.i4.s 12
    IL_0102: newarr 0x0100000B
    IL_0107: stfld 0x04000968
    IL_0108: ldarg.0
    IL_0109: ldc.i4.3
    IL_010E: newarr 0x01000010
    IL_0113: stfld 0x04000969
    IL_0114: ldarg.0
    IL_0115: ldc.i4.1
    IL_011A: stfld 0x0400096A
    IL_011B: ldarg.0
    IL_011D: ldc.i4.s 12
    IL_0122: newarr 0x0100000B
    IL_0127: stfld 0x0400096C
    IL_0128: ldarg.0
    IL_0129: ldc.i4.m1
    IL_012E: stfld 0x0400096D
    IL_012F: ldarg.0
    IL_0130: IL_22
    IL_0131: nop
    IL_0132: nop
    IL_0133: IL_C8
    IL_0134: IL_42
    IL_0139: stfld 0x0400096F
    IL_013A: ldarg.0
    IL_013F: call 0x0A000001
    IL_0140: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001FEF
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x0400096C
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70001ED5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x0400094C
    IL_0020: ldarg.0
    IL_0021: ldarg.0
    IL_0026: call 0x2B000066
    IL_002B: stfld 0x0400095E
    IL_0030: ldstr 0x7000174B
    IL_0035: call 0x06000220
    IL_0036: stloc.0
    IL_0037: ldarg.0
    IL_003C: ldstr 0x70000CDD
    IL_0041: call 0x06000220
    IL_0042: neg
    IL_0047: stfld 0x04000946
    IL_0048: ldarg.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000946
    IL_0050: ldc.i4.s 90
    IL_0051: mul
    IL_0052: neg
    IL_0057: stfld 0x04000947
    IL_0058: ldarg.0
    IL_005D: ldstr 0x70000BDB
    IL_0062: call 0x06000220
    IL_0067: stfld 0x04000944
    IL_0068: ldarg.0
    IL_006D: ldstr 0x70001F2D
    IL_0072: call 0x06000220
    IL_0077: stfld 0x0400096D
    IL_007C: ldstr 0x70000001
    IL_0081: call 0x0A000004
    IL_0082: stloc.1
    IL_0083: ldarg.0
    IL_0084: ldloc.1
    IL_0085: conv.r8
    IL_0086: ldarg.2
    IL_0087: nop
    IL_0088: nop
    IL_008A: br.s IL_0108
    IL_008B: xor
    IL_008C: ldloc.3
    IL_008D: nop
    IL_008E: ldarg.2
    IL_008F: ldarg.0
    IL_0090: ldarg.0
    IL_0095: call 0x2B000067
    IL_009A: stfld 0x04000960
    IL_009B: ldarg.0
    IL_00A0: ldstr 0x70000311
    IL_00A5: call 0x0A000004
    IL_00A6: conv.r8
    IL_00AB: ldc.i4 2099970048
    IL_00AC: or
    IL_00AD: ldloc.3
    IL_00AE: nop
    IL_00AF: ldarg.2
    IL_00B0: ldloc.0
    IL_00B2: ldc.i4.s 11
    IL_032F: switch (158 cases)
    IL_0330: rem
    IL_0331: nop
    IL_0332: nop
    IL_0333: stloc.0
    IL_0338: call 0x0A000014
    IL_0339: conv.u4
    IL_033A: ldarg.1
    IL_033B: nop
    IL_033C: nop
    IL_033D: IL_01
    IL_0342: stelem 0x09297B02
    IL_0343: nop
    IL_0344: ldarg.2
    IL_0345: ldc.i4.2
    IL_0346: ldloc.3
    IL_0347: IL_5A
    IL_0348: ldc.i4.1
    IL_0349: IL_58
    IL_034A: ldarg.0
    IL_034F: ldfld 0x04000920
    IL_0354: call 0x0A000042
    IL_0355: ldloc.3
    IL_0356: ldc.i4.3
    IL_0357: IL_5A
    IL_0358: conv.i2
    IL_035D: call 0x0A000008
    IL_0362: call 0x0A000042
    IL_0363: IL_22
    IL_0364: nop
    IL_0365: nop
    IL_20A46A: switch (534592 cases)
    }

    private void Start() {
    IL_0000: ldc.i4.1
    IL_0001: ldc.i4.4
    IL_0006: call 0x0A000045
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_000D: call 0x0A00002B
    IL_0012: ldstr 0x70022E5F
    IL_0014: ldloca.s 0
    IL_0019: call 0x0A000010
    IL_001E: call 0x0A000011
    IL_0023: call 0x0A000012
    IL_0024: conv.u8
    IL_0025: ldc.i4.8
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_01
    IL_0029: conv.r8
    IL_002A: IL_4C
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: call 0x0A00002B
    IL_0034: conv.r8
    IL_0035: IL_4D
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldarg.0
    IL_003E: call 0x0A00002B
    IL_0043: ldstr 0x70022774
    IL_0048: call 0x0A0001C1
    IL_0049: conv.r8
    IL_004A: IL_C9
    IL_004B: IL_01
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldc.i4.0
    IL_004F: stloc.1
    IL_0054: br IL_00E3
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000932
    IL_005B: ldloc.1
    IL_005C: ldarg.0
    IL_0061: ldfld 0x0400091A
    IL_0062: ldloc.1
    IL_0063: ldelem.i
    IL_0068: call 0x0A00004B
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: IL_C0
    IL_2111: switch (2088 cases)
    }

    public void SetMapStory() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.2
    IL_0007: brfalse IL_000A
    IL_0008: ldc.i4.5
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000918
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: IL_59
    IL_0014: ldloc.0
    IL_0015: IL_58
    IL_0016: ldelem.i
    IL_001B: call 0x0A00001B
    IL_0020: call 0x0A000013
    IL_0025: call 0x0A000014
    IL_0026: conv.u4
    IL_0027: ldarg.1
    IL_0028: nop
    IL_0029: nop
    IL_002A: IL_01
    IL_002F: stfld 0x0400092F
    IL_0030: ldarg.0
    IL_0035: ldfld 0x0400092F
    IL_003A: ldstr 0x70022E73
    IL_003B: conv.r8
    IL_003C: IL_DC
    IL_003D: IL_01
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.2
    IL_0045: brtrue IL_0080
    IL_0046: ldc.i4.0
    IL_0047: stloc.1
    IL_004C: br IL_0079
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000967
    IL_0053: ldloc.1
    IL_0054: IL_8F
    IL_0055: ldloc.1
    IL_0056: nop
    IL_0057: nop
    IL_0058: IL_01
    IL_0059: ldarg.0
    IL_005E: ldfld 0x0400092F
    IL_005F: ldc.i4.0
    IL_0060: conv.r8
    IL_0065: brtrue IL_70A0066
    IL_0066: conv.r8
    IL_006B: brtrue IL_6F0A006C
    IL_006C: ldc.i4.2
    IL_006D: nop
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: IL_81
    IL_0071: ldloc.1
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_01
    IL_0075: ldloc.1
    IL_0076: ldc.i4.1
    IL_0077: IL_58
    IL_0078: stloc.1
    IL_0079: ldloc.1
    IL_007A: ldc.i4.8
    IL_007B: IL_3F
    IL_007C: IL_CD
    IL_007D: IL_FF
    IL_007E: IL_FF
    IL_007F: IL_FF
    IL_0080: ret
    }

    public void SetMapExtreme() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_003E
    IL_0006: ldc.i4.0
    IL_0007: stloc.0
    IL_000C: br IL_0023
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000932
    IL_0013: ldloc.0
    IL_0014: ldelem.i
    IL_0015: conv.r8
    IL_0016: not
    IL_0017: nop
    IL_0018: nop
    IL_001A: br.s IL_008A
    IL_001B: IL_A9
    IL_001C: ldarg.1
    IL_001D: nop
    IL_001E: ldloc.0
    IL_001F: ldloc.0
    IL_0020: ldc.i4.1
    IL_0021: IL_58
    IL_0022: stloc.0
    IL_0023: ldloc.0
    IL_0024: ldc.i4.6
    IL_0025: IL_3F
    IL_0026: IL_E3
    IL_0027: IL_FF
    IL_0028: IL_FF
    IL_0029: IL_FF
    IL_002E: ldstr 0x7000012D
    IL_0033: call 0x0A000004
    IL_0034: conv.r8
    IL_0035: ldloc.1
    IL_0036: nop
    IL_0037: nop
    IL_0039: br.s IL_00A9
    IL_003A: IL_B0
    IL_003B: ldarg.1
    IL_003C: nop
    IL_003D: ldloc.0
    IL_003E: ldc.i4.0
    IL_003F: stloc.1
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400093D
    IL_0046: ldc.i4.1
    IL_0047: IL_59
    IL_0048: ldc.i4.8
    IL_0049: add
    IL_004A: stloc.1
    IL_004B: ldloc.1
    IL_004C: ldarg.0
    IL_0051: ldfld 0x0400094D
    IL_00B2: switch (23 cases)
    IL_00B3: ldloc.0
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: IL_01
    IL_00B7: stloc.2
    IL_00B8: ldarg.0
    IL_00B9: ldloc.2
    IL_00BA: conv.r8
    IL_00BB: ldarg.3
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: stloc.0
    IL_00C3: call 0x0A00001B
    IL_00C4: IL_22
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: ldc.i4.0
    IL_00CE: ldc.i4 360
    IL_00D3: call 0x0A000045
    IL_00D4: conv.i2
    IL_00D5: IL_22
    IL_00D6: nop
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: nop
    IL_00DE: call 0x0A000060
    IL_00E3: call 0x0A000014
    IL_00E4: conv.u4
    IL_00E5: ldarg.1
    IL_00E6: nop
    IL_00E7: nop
    IL_00E8: IL_01
    IL_00ED: stfld 0x0400092F
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x0400092F
    IL_00F8: ldstr 0x70022E73
    IL_00F9: conv.r8
    IL_00FA: IL_DC
    IL_00FB: IL_01
    IL_00FC: nop
    IL_00FD: stloc.0
    IL_00FE: ldarg.0
    IL_0103: ldfld 0x0400092F
    IL_0104: conv.r8
    IL_0105: conv.i1
    IL_0106: nop
    IL_0107: nop
    IL_0109: br.s IL_010C
    IL_010E: ldfld 0x0400093D
    IL_010F: conv.r8
    IL_0110: ldelem.i8
    IL_0111: ldarg.1
    IL_0112: nop
    IL_0113: ldloc.0
    IL_0114: ldarg.0
    IL_0119: ldfld 0x0400092F
    IL_011A: conv.r8
    IL_011F: cpobj 0x130A0000
    IL_0120: ldloc.0
    IL_0122: ldloca.s 6
    IL_0127: ldfld 0x0A00005E
    IL_0128: stloc.3
    IL_0129: ldarg.0
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000919
    IL_0130: ldloc.1
    IL_0131: IL_98
    IL_0132: ldloc.3
    IL_0133: IL_5A
    IL_0138: stfld 0x0400096F
    IL_0139: ldarg.0
    IL_013E: ldfld 0x04000938
    IL_013F: ldarg.0
    IL_0144: ldfld 0x0400092F
    IL_0145: conv.r8
    IL_0146: IL_22
    IL_0147: nop
    IL_0148: nop
    IL_0149: stloc.0
    IL_014E: call 0x0A000043
    IL_014F: ldarg.0
    IL_0154: ldfld 0x0400096F
    IL_0159: call 0x0A000008
    IL_015A: conv.r8
    IL_015B: ldloc.3
    IL_015C: nop
    IL_015D: nop
    IL_015E: stloc.0
    IL_015F: ldarg.0
    IL_0164: ldfld 0x04000938
    IL_0165: ldarg.0
    IL_016A: ldfld 0x04000938
    IL_016B: conv.r8
    IL_016C: ldc.i4.2
    IL_016D: nop
    IL_016E: nop
    IL_016F: stloc.0
    IL_0174: call 0x0A000043
    IL_0179: call 0x0A00001D
    IL_017A: conv.r8
    IL_017F: call 0x020A0000
    IL_0184: ldfld 0x04000938
    IL_0185: conv.r8
    IL_0186: stloc.0
    IL_0187: nop
    IL_0188: nop
    IL_0189: stloc.0
    IL_018A: ldc.i4.0
    IL_018B: conv.r8
    IL_018C: stloc.1
    IL_018D: nop
    IL_018E: nop
    IL_018F: stloc.0
    IL_0190: ldarg.0
    IL_0195: ldfld 0x0400092F
    IL_019A: ldstr 0x70022E93
    IL_019B: conv.r8
    IL_019D: brfalse.s IL_019E
    IL_019E: nop
    IL_019F: stloc.0
    IL_01A0: IL_22
    IL_01A1: nop
    IL_01A2: nop
    IL_01A3: nop
    IL_01A4: nop
    IL_01A5: IL_22
    IL_01A6: nop
    IL_01A7: nop
    IL_01A8: IL_F0
    IL_01A9: IL_42
    IL_01AA: IL_22
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: nop
    IL_01AE: nop
    IL_01B3: call 0x0A000060
    IL_01B4: conv.r8
    IL_01B9: call 0x020A0000
    IL_01BA: ldloc.1
    IL_01BF: stfld 0x0400094D
    IL_01C0: ldarg.0
    IL_01C5: ldfld 0x04000964
    IL_01C6: ldarg.0
    IL_01CB: ldfld 0x0400096F
    IL_01CC: conv.r8
    IL_01CD: ldelem.i8
    IL_01CE: IL_01
    IL_01CF: nop
    IL_01D0: ldloc.0
    IL_01D1: ldc.i4.0
    IL_01D3: stloc.s 4
    IL_01D8: br IL_0209
    IL_01D9: ldarg.0
    IL_01DE: ldfld 0x04000967
    IL_01E0: ldloc.s 4
    IL_01E1: IL_8F
    IL_01E2: ldloc.1
    IL_01E3: nop
    IL_01E4: nop
    IL_01E5: IL_01
    IL_01E6: ldarg.0
    IL_01EB: ldfld 0x0400092F
    IL_01EC: ldc.i4.0
    IL_01ED: conv.r8
    IL_01F2: brtrue IL_110A01F3
    IL_01F3: ldarg.2
    IL_01F4: conv.r8
    IL_01F9: brtrue IL_6F0A01FA
    IL_01FA: ldc.i4.2
    IL_01FB: nop
    IL_01FC: nop
    IL_01FD: stloc.0
    IL_01FE: IL_81
    IL_01FF: ldloc.1
    IL_0200: nop
    IL_0201: nop
    IL_0202: IL_01
    IL_0204: ldloc.s 4
    IL_0205: ldc.i4.1
    IL_0206: IL_58
    IL_0208: stloc.s 4
    IL_020A: ldloc.s 4
    IL_020B: ldc.i4.8
    IL_020C: IL_3F
    IL_020D: IL_C8
    IL_020E: IL_FF
    IL_020F: IL_FF
    IL_0210: IL_FF
    IL_0211: ret
    }

    public void TowerBreak() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_001A
    IL_0006: ldarg.0
    IL_0007: dup
    IL_000C: ldfld 0x0400095B
    IL_000D: ldc.i4.1
    IL_000E: IL_59
    IL_000F: neg
    IL_0014: stfld 0x0400095B
    IL_0019: br IL_0029
    IL_001A: ldarg.0
    IL_001B: dup
    IL_0020: ldfld 0x0400095A
    IL_0021: ldc.i4.1
    IL_0022: IL_59
    IL_0023: neg
    IL_0028: stfld 0x0400095A
    IL_0029: ldarg.0
    IL_002E: ldfld 0x0400095B
    IL_002F: ldc.i4.0
    IL_0030: IL_3D
    IL_0031: ldc.i4.6
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0035: ldarg.0
    IL_003A: ldfld 0x0400095A
    IL_003B: ldc.i4.0
    IL_003C: IL_3D
    IL_003E: starg.s 0
    IL_003F: nop
    IL_0040: nop
    IL_0041: ldarg.0
    IL_0046: ldfld 0x0400092B
    IL_0047: conv.r8
    IL_0048: conv.i2
    IL_0049: nop
    IL_004A: nop
    IL_004C: br.s IL_00BC
    IL_004D: div.un
    IL_004E: ldarg.3
    IL_004F: nop
    IL_0050: ldloc.0
    IL_0051: ret
    }

    public void SetRndPoint() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000944
    IL_0006: ldc.i4.6
    IL_0177: switch (91 cases)
    IL_0178: nop
    IL_0179: ldarg.2
    IL_017A: ret
    }

    public void OpenDundoor() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000938
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ret
    }

    public void EnemyDead() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000935
    IL_0007: ldc.i4.1
    IL_0008: IL_59
    IL_000D: stfld 0x04000935
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000943
    IL_0018: brtrue IL_0073
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000935
    IL_001F: ldc.i4.0
    IL_0020: IL_3D
    IL_0021: IL_4E
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0025: ldarg.0
    IL_002A: ldfld 0x0400093C
    IL_002C: ldc.i4.s -2
    IL_0135: switch (65 cases)
    IL_0136: IL_22
    IL_0137: ldelem.i
    IL_0138: IL_99
    IL_0139: ldc.i4.3
    IL_013A: IL_3E
    IL_013F: call 0x0A000008
    IL_0144: call 0x0A000029
    IL_0145: conv.r8
    IL_0146: ldloc.3
    IL_0147: nop
    IL_0148: nop
    IL_0149: stloc.0
    IL_014A: ldarg.0
    IL_014F: ldfld 0x04000932
    IL_0150: ldarg.0
    IL_0155: ldfld 0x04000949
    IL_0156: ldelem.i
    IL_0157: IL_22
    IL_0158: nop
    IL_0159: nop
    IL_015A: nop
    IL_015B: nop
    IL_015C: ldc.i4.0
    IL_0161: ldc.i4 360
    IL_0166: call 0x0A000045
    IL_0167: conv.i2
    IL_0168: IL_22
    IL_0169: nop
    IL_016A: nop
    IL_016B: nop
    IL_016C: nop
    IL_0171: call 0x0A000060
    IL_0172: conv.r8
    IL_0177: call 0x020A0000
    IL_017C: ldfld 0x04000932
    IL_017D: ldarg.0
    IL_0182: ldfld 0x04000949
    IL_0183: ldelem.i
    IL_0184: conv.r8
    IL_0185: not
    IL_0186: nop
    IL_0187: nop
    IL_0189: br.s IL_018F
    IL_018B: ldarg.s 4
    IL_018C: ldarg.1
    IL_018D: conv.r8
    IL_018E: IL_AA
    IL_018F: ldarg.1
    IL_0190: nop
    IL_0191: ldloc.0
    IL_0192: ldarg.0
    IL_0197: ldfld 0x04000932
    IL_0198: ldarg.0
    IL_019D: ldfld 0x04000949
    IL_019E: ldelem.i
    IL_019F: conv.r8
    IL_01A0: stloc.0
    IL_01A1: nop
    IL_01A2: nop
    IL_01A3: stloc.0
    IL_01A4: ldc.i4.1
    IL_01A5: conv.r8
    IL_01A6: stloc.1
    IL_01A7: nop
    IL_01A8: nop
    IL_01A9: stloc.0
    IL_01AA: ldarg.0
    IL_01AB: ldarg.0
    IL_01B0: ldfld 0x04000949
    IL_01B1: ldc.i4.1
    IL_01B2: IL_58
    IL_01B3: ldc.i4.3
    IL_01B4: mul
    IL_01B5: ldc.i4.3
    IL_01B6: IL_58
    IL_01BB: stfld 0x04000949
    IL_01BC: ldarg.0
    IL_01BD: ldarg.0
    IL_01C2: ldfld 0x04000949
    IL_01C7: stfld 0x0400094A
    IL_01CC: br IL_0281
    IL_01CD: ldarg.1
    IL_01CE: ldc.i4.3
    IL_044F: switch (159 cases)
    }

    public void CallGeneral() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0049
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400091D
    IL_000C: conv.r8
    IL_000D: stloc.3
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0013: ldarg.s 0
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000926
    IL_001C: conv.r8
    IL_001E: ldarga.s 0
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000958
    IL_0027: ldc.i4.2
    IL_0028: IL_3F
    IL_0029: ldc.i4.1
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_0032: ldfld 0x0400091D
    IL_0033: ldc.i4.0
    IL_0034: conv.r8
    IL_0039: brtrue IL_6F0A003A
    IL_003A: stloc.0
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldc.i4.0
    IL_003F: conv.r8
    IL_0040: stloc.1
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0048: br IL_0087
    IL_0049: ldarg.0
    IL_004E: ldfld 0x0400091D
    IL_004F: conv.r8
    IL_0050: stloc.3
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: conv.r8
    IL_0056: ldarg.s 0
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000927
    IL_005F: conv.r8
    IL_0061: ldarga.s 0
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000958
    IL_006A: ldc.i4.2
    IL_006B: IL_3F
    IL_006C: ldc.i4.1
    IL_006D: nop
    IL_006E: nop
    IL_006F: nop
    IL_0070: ldarg.0
    IL_0075: ldfld 0x0400091D
    IL_0076: ldc.i4.0
    IL_0077: conv.r8
    IL_007C: brtrue IL_6F0A007D
    IL_007D: stloc.0
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ldc.i4.1
    IL_0082: conv.r8
    IL_0083: stloc.1
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_0087: ldarg.0
    IL_008C: ldfld 0x0400094C
    IL_008D: ldc.i4.2
    IL_0092: beq IL_00C5
    IL_0093: ldarg.0
    IL_0094: IL_22
    IL_0095: nop
    IL_0096: nop
    IL_009B: stsfld 0x056B043F
    IL_009C: conv.i2
    IL_009D: add
    IL_009E: IL_59
    IL_009F: IL_22
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: IL_3E
    IL_00A4: IL_5A
    IL_00A9: stfld 0x04000941
    IL_00AA: ldarg.0
    IL_00AF: ldfld 0x04000961
    IL_00B4: call 0x0A000082
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x04000941
    IL_00BF: call 0x0A000083
    IL_00C0: conv.r8
    IL_00C1: IL_F3
    IL_00C2: ldarg.0
    IL_00C3: nop
    IL_00C4: ldloc.0
    IL_00C5: ret
    }

    public void SetBGM() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_C9
    IL_0009: IL_01
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: ldstr 0x70022774
    IL_0011: ldarg.1
    IL_0016: call 0x0A000255
    IL_0017: ret
    }

    public void ChangeBGM() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0025
    IL_0006: ldarg.0
    IL_000B: call 0x0A00002B
    IL_0010: ldstr 0x70022EA9
    IL_0015: call 0x0A000012
    IL_0016: conv.u8
    IL_0017: ldc.i4.8
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_01
    IL_001B: conv.r8
    IL_001C: IL_4C
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0024: br IL_0053
    IL_0025: ldc.i4.1
    IL_0026: ldc.i4.4
    IL_002B: call 0x0A000045
    IL_002C: stloc.0
    IL_002D: ldarg.0
    IL_0032: call 0x0A00002B
    IL_0037: ldstr 0x70022E5F
    IL_0039: ldloca.s 0
    IL_003E: call 0x0A000010
    IL_0043: call 0x0A000011
    IL_0048: call 0x0A000012
    IL_0049: conv.u8
    IL_004A: ldc.i4.8
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_01
    IL_004E: conv.r8
    IL_004F: IL_4C
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0058: call 0x0A00002B
    IL_0059: conv.r8
    IL_005A: IL_4D
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ret
    }

    public void RegenStart() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000935
    IL_0007: ldarg.0
    IL_0008: ldc.i4.0
    IL_000D: stfld 0x04000943
    IL_000E: ldarg.0
    IL_000F: ldarg.0
    IL_0014: ldfld 0x0400095E
    IL_0019: ldfld 0x04000512
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000947
    IL_0020: IL_8F
    IL_0021: not
    IL_0022: nop
    IL_0023: nop
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000507
    IL_002E: stfld 0x04000945
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000945
    IL_0035: ldc.i4.0
    IL_0036: IL_3E
    IL_0037: not
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000969
    IL_0041: ldc.i4.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x0400095E
    IL_004C: ldfld 0x04000512
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000947
    IL_0053: IL_8F
    IL_0054: not
    IL_0055: nop
    IL_0056: nop
    IL_0057: ldarg.0
    IL_005C: ldfld 0x0400050C
    IL_005D: ldelem.i4
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000969
    IL_0064: ldc.i4.1
    IL_0065: ldarg.0
    IL_006A: ldfld 0x0400095E
    IL_006F: ldfld 0x04000512
    IL_0070: ldarg.0
    IL_0075: ldfld 0x04000947
    IL_0076: IL_8F
    IL_0077: not
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldarg.0
    IL_007F: ldfld 0x0400050D
    IL_0080: ldelem.i4
    IL_0081: ldarg.0
    IL_0086: ldfld 0x04000969
    IL_0087: ldc.i4.2
    IL_0088: ldarg.0
    IL_008D: ldfld 0x0400095E
    IL_0092: ldfld 0x04000512
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04000947
    IL_0099: IL_8F
    IL_009A: not
    IL_009B: nop
    IL_009C: nop
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x0400050E
    IL_00A3: ldelem.i4
    IL_00A4: ldarg.0
    IL_00A5: ldarg.0
    IL_00AA: ldfld 0x04000939
    IL_00AF: stfld 0x0400093A
    IL_00B0: ldarg.0
    IL_00B1: ldc.i4.0
    IL_00B6: stfld 0x0400093C
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000931
    IL_00BD: ldc.i4.0
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x0400091B
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x0400095E
    IL_00CE: ldfld 0x04000512
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x04000947
    IL_00D5: IL_8F
    IL_00D6: not
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: ldarg.0
    IL_00DE: ldfld 0x04000508
    IL_00DF: ldelem.i
    IL_00E4: stelem 0x09317B02
    IL_00E5: nop
    IL_00E6: ldarg.2
    IL_00E7: ldc.i4.1
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x0400091B
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x0400095E
    IL_00F8: ldfld 0x04000512
    IL_00F9: ldarg.0
    IL_00FE: ldfld 0x04000947
    IL_00FF: IL_8F
    IL_0100: not
    IL_0101: nop
    IL_0102: nop
    IL_0103: ldarg.0
    IL_0108: ldfld 0x04000509
    IL_0109: ldelem.i
    IL_010E: stelem 0x09317B02
    IL_010F: nop
    IL_0110: ldarg.2
    IL_0111: ldc.i4.2
    IL_0112: ldarg.0
    IL_0117: ldfld 0x0400091B
    IL_0118: ldarg.0
    IL_011D: ldfld 0x0400095E
    IL_0122: ldfld 0x04000512
    IL_0123: ldarg.0
    IL_0128: ldfld 0x04000947
    IL_0129: IL_8F
    IL_012A: not
    IL_012B: nop
    IL_012C: nop
    IL_012D: ldarg.0
    IL_0132: ldfld 0x0400050A
    IL_0133: ldelem.i
    IL_0138: stelem 0x00000000
    }

    public void EnemyChange() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000940
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_3F
    IL_000B: IL_43
    IL_000D: ldloca.s 0
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x04000940
    IL_0017: IL_22
    IL_0018: ldelem.i
    IL_0019: IL_99
    IL_001A: IL_99
    IL_001B: IL_3E
    IL_001C: IL_59
    IL_0021: stfld 0x04000940
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400093D
    IL_0028: ldc.i4.5
    IL_0029: IL_3C
    IL_002B: ldarg.s 0
    IL_002C: nop
    IL_002D: nop
    IL_002E: ldarg.0
    IL_002F: dup
    IL_0034: ldfld 0x0400093D
    IL_0035: ldc.i4.1
    IL_0036: IL_58
    IL_003B: stfld 0x0400093D
    IL_003C: ldc.i4.0
    IL_003D: stloc.0
    IL_0042: br IL_006C
    IL_0043: ldarg.0
    IL_0048: ldfld 0x0400093D
    IL_0049: ldloc.0
    IL_004A: IL_58
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000946
    IL_0052: ldc.i4.s 10
    IL_0053: mul
    IL_0054: IL_58
    IL_0055: ldc.i4.1
    IL_0056: IL_59
    IL_0057: stloc.1
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000931
    IL_005E: ldloc.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400091B
    IL_0065: ldloc.1
    IL_0066: ldelem.i
    IL_006B: stelem 0x0A581706
    IL_006C: ldloc.0
    IL_006D: ldc.i4.3
    IL_006E: IL_3F
    IL_0073: ldtoken 0x2AFFFFFF
    }

    public void ChangeBoss() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x0400091C
    IL_0007: ldc.i4.0
    IL_0008: ldelem.i
    IL_0009: ldarg.1
    IL_000A: ldarg.2
    IL_000F: call 0x0A000014
    IL_0010: conv.u4
    IL_0011: ldarg.1
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_01
    IL_0019: stfld 0x0400092E
    IL_001A: ldarg.0
    IL_001F: ldfld 0x0400092E
    IL_0020: conv.r8
    IL_0021: conv.i4
    IL_0022: nop
    IL_0023: nop
    IL_0025: br.s IL_0028
    IL_002A: ldfld 0x04000946
    IL_002B: ldarg.0
    IL_0030: ldfld 0x0400096F
    IL_0031: conv.r8
    IL_0033: starg.s 0
    IL_0034: nop
    IL_0035: ldloc.0
    IL_0036: ret
    }

    public void BossAppear() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x060004F4
    IL_000B: stfld 0x04000952
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400091C
    IL_0013: ldarg.1
    IL_0014: ldelem.i
    IL_0015: ldarg.0
    IL_001A: ldfld 0x04000952
    IL_001F: call 0x0A000013
    IL_0024: call 0x0A000014
    IL_0025: conv.u4
    IL_0026: ldarg.1
    IL_0027: nop
    IL_0028: nop
    IL_0029: IL_01
    IL_002E: stfld 0x0400092E
    IL_002F: ldarg.0
    IL_0034: ldfld 0x0400092E
    IL_0035: conv.r8
    IL_0036: conv.i4
    IL_0037: nop
    IL_0038: nop
    IL_003A: br.s IL_003D
    IL_003F: ldfld 0x04000946
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400096F
    IL_0046: conv.r8
    IL_0048: starg.s 0
    IL_0049: nop
    IL_004A: ldloc.0
    IL_004B: ldarg.0
    IL_004C: dup
    IL_0051: ldfld 0x04000935
    IL_0052: ldc.i4.1
    IL_0053: IL_58
    IL_0058: stfld 0x04000935
    IL_0059: ldarg.0
    IL_005A: ldc.i4.1
    IL_005F: stfld 0x04000942
    IL_0060: ret
    }

    public void BossCutin() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000934
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000934
    IL_0017: conv.r8
    IL_0018: conv.i8
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_0020
    IL_001D: conv.r8
    IL_001F: beq.s IL_0022
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000934
    IL_0028: conv.r8
    IL_0029: stloc.0
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.1
    IL_002E: conv.r8
    IL_002F: stloc.1
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000934
    IL_0039: conv.r8
    IL_003A: conv.r4
    IL_003B: nop
    IL_003C: nop
    IL_003E: br.s IL_0061
    IL_003F: nop
    IL_0040: nop
    IL_8945: switch (8768 cases)
    }

    public void BossKill_Cheat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400092E
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_002F
    IL_0011: ldarg.0
    IL_0016: ldfld 0x0400092E
    IL_0017: conv.r8
    IL_0018: stloc.0
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000050
    IL_0021: ldarg.0
    IL_0022: dup
    IL_0027: ldfld 0x04000935
    IL_0028: ldc.i4.1
    IL_0029: IL_59
    IL_002E: stfld 0x04000935
    IL_002F: ret
    }

    public void Summon() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400094E
    IL_0006: ldc.i4.0
    IL_0007: IL_3D
    IL_0008: IL_23
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x0400094E
    IL_0013: ldarg.0
    IL_0014: ldarg.2
    IL_0019: stfld 0x04000951
    IL_001A: ldarg.0
    IL_001F: ldstr 0x70022EBB
    IL_0020: IL_22
    IL_0021: IL_CD
    IL_0022: IL_CC
    IL_0023: IL_CC
    IL_0024: IL_3D
    IL_0025: IL_22
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_0029: IL_3F
    IL_002E: call 0x0A000017
    IL_002F: ret
    }

    private void Summon_p() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000935
    IL_0006: ldc.i4.0
    IL_0007: IL_3E
    IL_0008: IL_DE
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000951
    IL_0016: call 0x0A00007E
    IL_0017: IL_22
    IL_0018: ldelem.i
    IL_0019: IL_99
    IL_001A: IL_99
    IL_001B: IL_3E
    IL_0020: call 0x0A000008
    IL_0025: call 0x0A000029
    IL_0026: stloc.0
    IL_0028: ldloca.s 0
    IL_0029: ldc.i4.1
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: nop
    IL_0033: call 0x0A00001A
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000937
    IL_003A: ldloc.0
    IL_003B: conv.r8
    IL_003C: ldloc.3
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000937
    IL_0046: conv.r8
    IL_0047: stloc.2
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: conv.r8
    IL_004C: IL_B9
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000931
    IL_0057: ldc.i4.0
    IL_0058: ldc.i4.2
    IL_005D: call 0x0A000045
    IL_005E: ldelem.i
    IL_0063: stfld 0x0400092C
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x0400092C
    IL_006B: ldloc.0
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_006F: nop
    IL_0070: nop
    IL_0071: ldc.i4.0
    IL_0076: ldc.i4 360
    IL_007B: call 0x0A000045
    IL_007C: conv.i2
    IL_007D: IL_22
    IL_007E: nop
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0086: call 0x0A000060
    IL_008B: call 0x0A000014
    IL_008C: conv.u4
    IL_008D: ldarg.1
    IL_008E: nop
    IL_008F: nop
    IL_0090: IL_01
    IL_0095: stfld 0x0400092D
    IL_0096: ldarg.0
    IL_009B: ldfld 0x0400092D
    IL_00A0: ldstr 0x70022ECD
    IL_00A1: conv.r8
    IL_00A2: IL_DC
    IL_00A3: IL_01
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x0400092D
    IL_00AC: conv.r8
    IL_00AD: ldc.i4.8
    IL_00AE: nop
    IL_00AF: nop
    IL_00B1: br.s IL_00B4
    IL_00B6: ldfld 0x04000946
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000944
    IL_00BD: ldc.i4.1
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x0400096F
    IL_00C4: conv.r8
    IL_00C5: ldc.i4.8
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: ldloc.0
    IL_00C9: ldarg.0
    IL_00CA: dup
    IL_00CF: ldfld 0x04000935
    IL_00D0: ldc.i4.1
    IL_00D1: IL_58
    IL_00D6: stfld 0x04000935
    IL_00D7: ldarg.0
    IL_00D8: dup
    IL_00DD: ldfld 0x0400094E
    IL_00DE: ldc.i4.1
    IL_00DF: IL_59
    IL_00E4: stfld 0x0400094E
    IL_00E9: br IL_00FC
    IL_00EA: ldarg.0
    IL_00EB: ldc.i4.0
    IL_00F0: stfld 0x0400094E
    IL_00F1: ldarg.0
    IL_00F6: ldstr 0x70022EBB
    IL_00FB: call 0x0A00007B
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x0400094E
    IL_0102: ldc.i4.0
    IL_0103: IL_3D
    IL_0105: ldloca.s 0
    IL_0106: nop
    IL_0107: nop
    IL_0108: ldarg.0
    IL_0109: ldc.i4.0
    IL_010E: stfld 0x0400094E
    IL_010F: ldarg.0
    IL_0114: ldstr 0x70022EBB
    IL_0119: call 0x0A00007B
    IL_011A: ret
    }

    public void BossKill() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_001D
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400096C
    IL_000D: ldc.i4.s 9
    IL_000E: IL_8F
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: IL_01
    IL_0013: dup
    IL_0016: stloc 22551
    IL_0017: IL_54
    IL_001C: br IL_002E
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400096C
    IL_0023: ldarg.1
    IL_0024: IL_8F
    IL_0025: stloc.1
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_01
    IL_0029: dup
    IL_002C: stloc 22551
    IL_002D: IL_54
    IL_0032: ldstr 0x70001FEF
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400096C
    IL_003D: call 0x060003F8
    IL_003E: pop
    IL_003F: ldarg.0
    IL_0044: ldfld 0x0400095D
    IL_0049: brfalse IL_004F
    IL_004E: br IL_0083
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000945
    IL_0055: ldc.i4.0
    IL_0056: IL_3D
    IL_005B: call 0x02000000
    IL_005C: dup
    IL_0061: ldfld 0x0400096E
    IL_0062: ldc.i4.1
    IL_0063: IL_59
    IL_0064: neg
    IL_0069: stfld 0x0400096E
    IL_006A: ldarg.0
    IL_006F: ldfld 0x0400096E
    IL_0070: ldc.i4.0
    IL_0071: IL_3D
    IL_0072: stloc.3
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_0076: ldarg.0
    IL_007B: ldfld 0x0400095F
    IL_007D: ldc.i4.s 100
    IL_007E: conv.r8
    IL_0080: starg.s 6
    IL_0081: nop
    IL_0082: ldloc.0
    IL_0083: ldarg.0
    IL_0084: ldc.i4.0
    IL_0089: call 0x060004F9
    IL_008A: ret
    }

    public void FinalWave() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400095F
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400093E
    IL_000C: ldc.i4.1
    IL_000D: IL_59
    IL_000E: conv.r8
    IL_0010: starg.s 6
    IL_0011: nop
    IL_0012: ldloc.0
    IL_0013: ldarg.0
    IL_0014: ldarg.0
    IL_0019: ldfld 0x0400093E
    IL_001E: stfld 0x0400093D
    IL_001F: ret
    }

    public void GeneralHP() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400096D
    IL_0006: ldc.i4.m1
    IL_000B: beq IL_0075
    IL_000C: ldc.i4.1
    IL_0011: call 0x0600056F
    IL_0012: stloc.0
    IL_0013: ldc.i4.0
    IL_0014: stloc.1
    IL_0019: br IL_0038
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000968
    IL_0020: ldloc.1
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000968
    IL_0027: ldloc.1
    IL_0028: IL_94
    IL_0029: ldloc.0
    IL_002A: conv.i2
    IL_002B: IL_22
    IL_002C: IL_CD
    IL_002D: IL_CC
    IL_002E: IL_4C
    IL_002F: IL_3E
    IL_0030: IL_5A
    IL_0031: not
    IL_0032: IL_58
    IL_0033: ldelem.i8
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: IL_58
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_003A: ldc.i4.s 12
    IL_003B: IL_3F
    IL_003C: IL_DA
    IL_003D: IL_FF
    IL_003E: IL_FF
    IL_003F: IL_FF
    IL_0040: ldarg.1
    IL_0045: brtrue IL_005E
    IL_0046: ldarg.0
    IL_004B: ldfld 0x04000968
    IL_004C: ldarg.0
    IL_0051: ldfld 0x0400096D
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000964
    IL_005C: ldfld 0x040002CB
    IL_005D: ldelem.i8
    IL_0062: ldstr 0x70001F1D
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000968
    IL_006D: call 0x060003F8
    IL_006E: pop
    IL_006F: ldc.i4.1
    IL_0074: call 0x0600056B
    IL_0075: ret
    }

    public void GeneralDead() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000958
    IL_0006: ldc.i4.2
    IL_0007: IL_3F
    IL_0008: ldc.i4.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400091D
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0018: brtrue IL_6F0A0019
    IL_0019: stloc.0
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldc.i4.0
    IL_001E: conv.r8
    IL_001F: stloc.1
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: ldarg.0
    IL_0024: ldc.i4.0
    IL_0029: call 0x06000504
    IL_002A: ldarg.0
    IL_002F: ldfld 0x0400094C
    IL_0030: ldc.i4.2
    IL_0035: beq IL_0047
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000965
    IL_003C: conv.r8
    IL_003D: stloc.0
    IL_003E: nop
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: ldc.i4.0
    IL_0042: conv.r8
    IL_0043: stloc.1
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000966
    IL_004D: conv.r8
    IL_004E: stloc.0
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ldc.i4.1
    IL_0053: conv.r8
    IL_0054: stloc.1
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ret
    }

    public void RegenAlly() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000956
    IL_000A: brtrue IL_0058
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400092B
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0025: ldc.i4 2835521
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_002D: ldfld 0x0400092B
    IL_0032: call 0x0A000042
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: IL_BF
    IL_003C: call 0x0A000008
    IL_003D: conv.r8
    IL_003E: ldloc.3
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x0400092B
    IL_0048: conv.r8
    IL_0049: stloc.0
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldc.i4.1
    IL_004E: conv.r8
    IL_004F: stloc.1
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0057: br IL_00D6
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000956
    IL_005E: ldc.i4.8
    IL_005F: IL_3C
    IL_0060: div
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldarg.0
    IL_0065: dup
    IL_006A: ldfld 0x0400096A
    IL_006B: ldc.i4.m1
    IL_006C: IL_5A
    IL_006D: neg
    IL_0072: stfld 0x0400096A
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000924
    IL_007D: call 0x0A000062
    IL_007E: IL_22
    IL_007F: IL_CD
    IL_0080: IL_CC
    IL_0081: IL_CC
    IL_0082: IL_3D
    IL_0083: IL_22
    IL_0084: ldelem.i
    IL_0085: IL_99
    IL_0086: IL_99
    IL_0087: IL_3E
    IL_008C: call 0x0A000075
    IL_0091: call 0x0A000008
    IL_0092: ldarg.0
    IL_0097: ldfld 0x0400096A
    IL_0098: conv.i2
    IL_009D: call 0x0A000008
    IL_00A2: call 0x0A000042
    IL_00A3: IL_22
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: IL_3F
    IL_00AC: call 0x0A000008
    IL_00B1: call 0x0A000019
    IL_00B6: call 0x0A000013
    IL_00BB: call 0x0A000014
    IL_00BC: pop
    IL_00C1: br IL_00D6
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x04000956
    IL_00C9: ldc.i4.s 12
    IL_00CA: IL_3E
    IL_00CB: ldloc.1
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: ldarg.0
    IL_00D0: ldc.i4.m1
    IL_00D5: stfld 0x04000956
    IL_00D6: ldarg.0
    IL_00D7: dup
    IL_00DC: ldfld 0x04000956
    IL_00DD: ldc.i4.1
    IL_00DE: IL_58
    IL_00DF: neg
    IL_00E4: stfld 0x04000956
    IL_00E5: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400093C
    IL_000A: brtrue IL_00EB
    IL_000B: ldc.i4.0
    IL_000C: stloc.0
    IL_0011: br IL_00D1
    IL_0012: ldarg.0
    IL_0013: ldarg.0
    IL_0018: call 0x060004F4
    IL_001D: stfld 0x04000952
    IL_001E: ldarg.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000931
    IL_0025: ldloc.0
    IL_0026: ldelem.i
    IL_002B: stfld 0x0400092C
    IL_002C: ldarg.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x0400092C
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000952
    IL_003D: call 0x0A000013
    IL_0042: call 0x0A000014
    IL_0043: conv.u4
    IL_0044: ldarg.1
    IL_0045: nop
    IL_0046: nop
    IL_0047: IL_01
    IL_004C: stfld 0x0400092D
    IL_004D: ldarg.0
    IL_0052: ldfld 0x0400092D
    IL_0057: ldstr 0x70022ECD
    IL_0058: conv.r8
    IL_0059: IL_DC
    IL_005A: IL_01
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x0400092D
    IL_0063: conv.r8
    IL_0064: ldc.i4.8
    IL_0065: nop
    IL_0066: nop
    IL_0068: br.s IL_006B
    IL_006D: ldfld 0x04000946
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000944
    IL_0074: ldarg.0
    IL_0079: ldfld 0x0400095D
    IL_007A: ldarg.0
    IL_007F: ldfld 0x0400096F
    IL_0080: conv.r8
    IL_0081: ldc.i4.8
    IL_0082: nop
    IL_0083: nop
    IL_0084: ldloc.0
    IL_0085: ldarg.0
    IL_008A: ldfld 0x0400095D
    IL_008F: brfalse IL_00B1
    IL_0090: ldarg.0
    IL_0095: ldfld 0x04000937
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000952
    IL_009C: conv.r8
    IL_009D: ldloc.3
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000937
    IL_00A7: conv.r8
    IL_00A8: stloc.2
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: stloc.0
    IL_00AC: conv.r8
    IL_00AD: IL_B9
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: stloc.0
    IL_00B1: ldarg.0
    IL_00B2: dup
    IL_00B7: ldfld 0x04000935
    IL_00B8: ldc.i4.1
    IL_00B9: IL_58
    IL_00BE: stfld 0x04000935
    IL_00BF: ldarg.0
    IL_00C0: dup
    IL_00C5: ldfld 0x0400093A
    IL_00C6: ldc.i4.1
    IL_00C7: IL_59
    IL_00CC: stfld 0x0400093A
    IL_00CD: ldloc.0
    IL_00CE: ldc.i4.1
    IL_00CF: IL_58
    IL_00D0: stloc.0
    IL_00D1: ldloc.0
    IL_00D2: ldc.i4.3
    IL_00D3: IL_3F
    IL_00D8: brtrue IL_30000D8
    IL_00D9: ldc.i4.1
    IL_00DE: stfld 0x0400093C
    IL_00DF: ldarg.0
    IL_00E0: ldc.i4.0
    IL_00E5: stfld 0x04000942
    IL_00EA: br IL_0414
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x0400093C
    IL_00F1: ldc.i4.0
    IL_00F2: IL_3E
    IL_00F3: IL_B8
    IL_00F4: ldarg.0
    IL_00F5: nop
    IL_00F6: nop
    IL_00F7: ldarg.0
    IL_00FC: ldfld 0x0400093F
    IL_00FD: IL_22
    IL_00FE: nop
    IL_00FF: nop
    IL_0100: nop
    IL_0101: nop
    IL_0102: IL_43
    IL_0103: ldc.i4.1
    IL_0104: nop
    IL_0105: nop
    IL_0106: nop
    IL_0107: ldarg.0
    IL_0108: dup
    IL_010D: ldfld 0x0400093F
    IL_0112: call 0x0A000024
    IL_0113: IL_59
    IL_0118: stfld 0x0400093F
    IL_011D: br IL_03AA
    IL_011E: ldarg.0
    IL_0123: ldfld 0x0400093A
    IL_0124: ldc.i4.0
    IL_0125: IL_3E
    IL_0126: IL_29
    IL_0127: IL_01
    IL_0128: nop
    IL_0129: nop
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000935
    IL_0130: ldarg.0
    IL_0135: ldfld 0x0400093B
    IL_0136: IL_3C
    IL_0138: stloc.s 1
    IL_0139: nop
    IL_013A: nop
    IL_013B: ldarg.0
    IL_013C: ldarg.0
    IL_0141: call 0x060004F4
    IL_0146: stfld 0x04000952
    IL_0147: ldarg.0
    IL_0148: ldc.i4.0
    IL_014A: ldc.i4.s 100
    IL_014F: call 0x0A000045
    IL_0154: stfld 0x0400094B
    IL_0155: ldarg.0
    IL_015A: ldfld 0x0400094B
    IL_015C: ldc.i4.s 45
    IL_015D: IL_3C
    IL_015E: stloc.2
    IL_015F: nop
    IL_0160: nop
    IL_0161: nop
    IL_0162: ldarg.0
    IL_0163: ldc.i4.0
    IL_0168: stfld 0x0400094B
    IL_016D: br IL_018E
    IL_016E: ldarg.0
    IL_0173: ldfld 0x0400094B
    IL_0175: ldc.i4.s 80
    IL_0176: IL_3C
    IL_0177: stloc.2
    IL_0178: nop
    IL_0179: nop
    IL_017A: nop
    IL_017B: ldarg.0
    IL_017C: ldc.i4.1
    IL_0181: stfld 0x0400094B
    IL_0186: br IL_018E
    IL_0187: ldarg.0
    IL_0188: ldc.i4.2
    IL_018D: stfld 0x0400094B
    IL_018E: ldarg.0
    IL_018F: ldarg.0
    IL_0194: ldfld 0x04000931
    IL_0195: ldarg.0
    IL_019A: ldfld 0x0400094B
    IL_019B: ldelem.i
    IL_01A0: stfld 0x0400092C
    IL_01A1: ldarg.0
    IL_01A2: ldarg.0
    IL_01A7: ldfld 0x0400092C
    IL_01A8: ldarg.0
    IL_01AD: ldfld 0x04000952
    IL_01B2: call 0x0A000013
    IL_01B7: call 0x0A000014
    IL_01B8: conv.u4
    IL_01B9: ldarg.1
    IL_01BA: nop
    IL_01BB: nop
    IL_01BC: IL_01
    IL_01C1: stfld 0x0400092D
    IL_01C2: ldarg.0
    IL_01C7: ldfld 0x0400092D
    IL_01CC: ldstr 0x70022ECD
    IL_01CD: conv.r8
    IL_01CE: IL_DC
    IL_01CF: IL_01
    IL_01D0: nop
    IL_01D1: stloc.0
    IL_01D2: ldarg.0
    IL_01D7: ldfld 0x0400092D
    IL_01D8: conv.r8
    IL_01D9: ldc.i4.8
    IL_01DA: nop
    IL_01DB: nop
    IL_01DD: br.s IL_01E0
    IL_01E2: ldfld 0x04000946
    IL_01E3: ldarg.0
    IL_01E8: ldfld 0x04000944
    IL_01E9: ldarg.0
    IL_01EE: ldfld 0x0400095D
    IL_01EF: ldarg.0
    IL_01F4: ldfld 0x0400096F
    IL_01F5: conv.r8
    IL_01F6: ldc.i4.8
    IL_01F7: nop
    IL_01F8: nop
    IL_01F9: ldloc.0
    IL_01FA: ldarg.0
    IL_01FF: ldfld 0x0400095D
    IL_0204: brfalse IL_0226
    IL_0205: ldarg.0
    IL_020A: ldfld 0x04000937
    IL_020B: ldarg.0
    IL_0210: ldfld 0x04000952
    IL_0211: conv.r8
    IL_0212: ldloc.3
    IL_0213: nop
    IL_0214: nop
    IL_0215: stloc.0
    IL_0216: ldarg.0
    IL_021B: ldfld 0x04000937
    IL_021C: conv.r8
    IL_021D: stloc.2
    IL_021E: nop
    IL_021F: nop
    IL_0220: stloc.0
    IL_0221: conv.r8
    IL_0222: IL_B9
    IL_0223: nop
    IL_0224: nop
    IL_0225: stloc.0
    IL_0226: ldarg.0
    IL_0227: dup
    IL_022C: ldfld 0x04000935
    IL_022D: ldc.i4.1
    IL_022E: IL_58
    IL_0233: stfld 0x04000935
    IL_0234: ldarg.0
    IL_0235: dup
    IL_023A: ldfld 0x0400093A
    IL_023B: ldc.i4.1
    IL_023C: IL_59
    IL_0241: stfld 0x0400093A
    IL_0242: ldarg.0
    IL_0243: ldarg.0
    IL_0248: ldfld 0x04000940
    IL_024D: stfld 0x0400093F
    IL_0252: br IL_03AA
    IL_0253: ldarg.0
    IL_0258: ldfld 0x0400093A
    IL_0259: ldc.i4.0
    IL_025A: IL_3D
    IL_025B: localloc
    IL_025C: IL_01
    IL_025D: nop
    IL_025E: nop
    IL_025F: ldarg.0
    IL_0264: ldfld 0x0400093D
    IL_0265: ldarg.0
    IL_026A: ldfld 0x0400093E
    IL_026B: IL_3F
    IL_026C: throw
    IL_026D: nop
    IL_026E: nop
    IL_026F: nop
    IL_0270: ldarg.0
    IL_0275: ldfld 0x04000945
    IL_0276: ldc.i4.0
    IL_0277: IL_3E
    IL_0278: rem.un
    IL_0279: nop
    IL_027A: nop
    IL_027B: nop
    IL_027C: ldarg.0
    IL_027D: IL_22
    IL_027E: nop
    IL_027F: nop
    IL_0284: stsfld 0x093F7D3F
    IL_0285: nop
    IL_0286: ldarg.2
    IL_0287: ldarg.0
    IL_0288: ldarg.0
    IL_028D: ldfld 0x04000969
    IL_028E: ldarg.0
    IL_0293: ldfld 0x0400095E
    IL_0298: ldfld 0x04000512
    IL_0299: ldarg.0
    IL_029E: ldfld 0x04000947
    IL_029F: IL_8F
    IL_02A0: not
    IL_02A1: nop
    IL_02A2: nop
    IL_02A3: ldarg.0
    IL_02A8: ldfld 0x04000507
    IL_02A9: ldarg.0
    IL_02AE: ldfld 0x04000945
    IL_02AF: IL_59
    IL_02B0: IL_92
    IL_02B5: call 0x060004FD
    IL_02B6: ldarg.0
    IL_02B7: dup
    IL_02BC: ldfld 0x04000945
    IL_02BD: ldc.i4.1
    IL_02BE: IL_59
    IL_02C3: stfld 0x04000945
    IL_02C4: ldarg.0
    IL_02C9: ldfld 0x04000945
    IL_02CA: ldc.i4.0
    IL_02CB: IL_3D
    IL_02CC: ldloc.2
    IL_02CD: nop
    IL_02CE: nop
    IL_02CF: nop
    IL_02D0: ldarg.0
    IL_02D2: ldc.i4.s -2
    IL_02D7: stfld 0x0400093C
    IL_02DC: br IL_02E5
    IL_02DD: ldarg.0
    IL_02DF: ldc.i4.s -2
    IL_02E4: stfld 0x0400093C
    IL_02E9: br IL_03AA
    IL_02EA: ldarg.0
    IL_02EF: ldfld 0x0400095D
    IL_02F4: brfalse IL_03A2
    IL_02F5: ldarg.0
    IL_02FA: ldfld 0x04000945
    IL_02FB: ldc.i4.0
    IL_02FC: IL_3E
    IL_02FD: conv.u8
    IL_02FE: nop
    IL_02FF: nop
    IL_0300: nop
    IL_0301: ldarg.0
    IL_0302: ldarg.0
    IL_0307: ldfld 0x04000969
    IL_0308: ldarg.0
    IL_030D: ldfld 0x0400095E
    IL_0312: ldfld 0x04000512
    IL_0313: ldarg.0
    IL_0318: ldfld 0x04000947
    IL_0319: IL_8F
    IL_031A: not
    IL_031B: nop
    IL_031C: nop
    IL_031D: ldarg.0
    IL_0322: ldfld 0x04000507
    IL_0323: ldarg.0
    IL_0328: ldfld 0x04000945
    IL_0329: IL_59
    IL_032A: IL_92
    IL_032F: call 0x060004FD
    IL_0330: ldarg.0
    IL_0331: dup
    IL_0336: ldfld 0x04000945
    IL_0337: ldc.i4.1
    IL_0338: IL_59
    IL_033D: stfld 0x04000945
    IL_033E: ldarg.0
    IL_0343: ldfld 0x04000945
    IL_0344: ldc.i4.0
    IL_0345: IL_3D
    IL_0346: IL_27
    IL_0347: nop
    IL_0348: nop
    IL_0349: nop
    IL_034A: ldarg.0
    IL_034B: ldarg.0
    IL_0350: ldfld 0x04000946
    IL_0351: ldc.i4.3
    IL_0352: IL_58
    IL_0353: neg
    IL_0358: stfld 0x04000946
    IL_0359: ldarg.0
    IL_035A: ldarg.0
    IL_035F: ldfld 0x04000946
    IL_0361: ldc.i4.s 90
    IL_0362: mul
    IL_0363: neg
    IL_0368: stfld 0x04000947
    IL_0369: ldarg.0
    IL_036B: ldc.i4.s -2
    IL_0370: stfld 0x0400093C
    IL_0375: br IL_039D
    IL_0376: ldarg.0
    IL_0377: ldarg.0
    IL_037C: ldfld 0x04000946
    IL_037D: ldc.i4.3
    IL_037E: IL_58
    IL_037F: neg
    IL_0384: stfld 0x04000946
    IL_0385: ldarg.0
    IL_0386: ldarg.0
    IL_038B: ldfld 0x04000946
    IL_038D: ldc.i4.s 90
    IL_038E: mul
    IL_038F: neg
    IL_0394: stfld 0x04000947
    IL_0395: ldarg.0
    IL_0397: ldc.i4.s -2
    IL_039C: stfld 0x0400093C
    IL_03A1: br IL_03AA
    IL_03A2: ldarg.0
    IL_03A4: ldc.i4.s -2
    IL_03A9: stfld 0x0400093C
    IL_03AE: br IL_0414
    IL_03AF: ldarg.0
    IL_03B4: ldfld 0x04000935
    IL_03B5: ldc.i4.5
    IL_03B6: IL_3D
    IL_03B7: IL_59
    IL_03B8: nop
    IL_03B9: nop
    IL_03BA: nop
    IL_03BB: ldarg.0
    IL_03C0: ldfld 0x04000942
    IL_03C5: brtrue IL_0414
    IL_03C6: ldc.i4.0
    IL_03C7: stloc.1
    IL_03CC: br IL_0401
    IL_03CD: ldarg.0
    IL_03D2: ldstr 0x70022ECD
    IL_03D7: call 0x0A000077
    IL_03DC: stfld 0x0400095C
    IL_03DD: ldarg.0
    IL_03E2: ldfld 0x0400095C
    IL_03E3: conv.r8
    IL_03E4: conv.r8
    IL_03E5: nop
    IL_03E6: nop
    IL_03E8: br.s IL_0458
    IL_03E9: IL_29
    IL_03EA: nop
    IL_03EB: nop
    IL_03EC: ldloc.0
    IL_03ED: ldarg.0
    IL_03F2: ldfld 0x0400095C
    IL_03F7: ldstr 0x70022ED9
    IL_03F8: conv.r8
    IL_03F9: IL_DC
    IL_03FA: IL_01
    IL_03FB: nop
    IL_03FC: stloc.0
    IL_03FD: ldloc.1
    IL_03FE: ldc.i4.1
    IL_03FF: IL_58
    IL_0400: stloc.1
    IL_0401: ldloc.1
    IL_0402: ldarg.0
    IL_0407: ldfld 0x04000935
    IL_0408: IL_3F
    IL_0409: IL_C0
    IL_040A: IL_FF
    IL_040B: IL_FF
    IL_040C: IL_FF
    IL_040D: ldarg.0
    IL_040E: ldc.i4.1
    IL_0413: stfld 0x04000942
    IL_0414: ret
    }

    }}
