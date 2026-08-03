// Namespace: 
// Type: Cha_Skill

    public class Cha_Skill {{

    private static object MAXSKILL;
    private object script_rotfog;
    private object script_cam;
    private object script_cha1;
    private object script_costume;
    private object script_DBskill;
    public object snd_jin;
    private object cur_skill_grade;
    private object skill_index;
    private object castingdelay;
    private object skillatk;
    private object repeatatk;
    private object motionkind;
    private object g_skillatk;
    private object g_motionkind;
    private object repeattime;
    private object repeatkind;
    private object repeatdelay;
    private object currentdelay;
    private object pt_off_delay;
    private object repeat;
    private object basedamage;
    private object tempradian;
    public object swordwind;
    public object rapidstab;
    public object wheelwind;
    public object meteo;
    public object supersword;
    public object energypillar;
    public object pt_attackup;
    public object pt_defenceup;
    public object pt_boom;
    public object sworddance;
    public object pt_poison;
    public object ef_gather;
    public object deathhand;
    public object chosun;
    public object junwui;
    public object jin;
    public object dragonhead;
    public object ef_rotfog;
    public object fincanon;
    public object bamboo;
    public object crow;
    public object bamboobase;
    public object swordrain_b;
    public object swordrain_s;
    public object swordrain;
    public object wing;
    public object ef_groundbreak;
    public object bombsphere;
    public object lightningblade;
    private object directionArrow;
    private object pt_ki;
    private object mytransform;
    private object myanimation;
    private object c_defenceup;
    private object c_sworddance;
    private object c_poison;
    private object c_rapidstab;
    private object c_wheelwind;
    private object c_hand;
    private object c_chosun;
    private object c_junwui;
    private object c_dragonhead;
    private object c_swordwind;
    private object c_fincanon;
    private object c_crow;
    private object c_bamboobase;
    private object c_swordrain_b;
    private object c_swordrain_s;
    private object c_swordrain;
    private object c_wing;
    private object c_groundbreak;
    private object c_bombsphere;
    private object c_icespear;
    private object c_lightningblade;
    private object c_bamboo;
    private object c_energypillar;
    private object c_supersword;
    private object r_hand;
    private object c_generalskill;
    private object load_skobj;
    private object rndpos;
    private object temp;

    public Cha_Skill() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 20
    IL_0007: newarr 0x0100000B
    IL_000C: stfld 0x040003B4
    IL_000D: ldarg.0
    IL_000E: ldc.i4.m1
    IL_0013: stfld 0x040003B5
    IL_0014: ldarg.0
    IL_0015: IL_22
    IL_0016: nop
    IL_0017: nop
    IL_001C: ldc.i4 62881089
    IL_001D: nop
    IL_001E: ldarg.2
    IL_001F: ldarg.0
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: ldc.i4 62946625
    IL_0028: nop
    IL_0029: ldarg.2
    IL_002A: ldarg.0
    IL_002B: IL_22
    IL_002C: nop
    IL_002D: nop
    IL_0032: stsfld 0x03C27D3F
    IL_0033: nop
    IL_0034: ldarg.2
    IL_0035: ldarg.0
    IL_0036: ldc.i4.3
    IL_003B: newarr 0x01000003
    IL_0040: stfld 0x040003FA
    IL_0041: ldarg.0
    IL_0042: ldc.i4.7
    IL_0047: newarr 0x01000003
    IL_004C: stfld 0x040003FE
    IL_004D: ldarg.0
    IL_0052: call 0x0A000001
    IL_0053: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040003E3
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00002A
    IL_0017: stfld 0x040003E4
    IL_0018: ret
    }

    private void Start() {
    IL_0004: ldstr 0x70000BD5
    IL_0009: call 0x0A000004
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_000C: ldloc.0
    IL_000D: conv.r8
    IL_000E: IL_3C
    IL_000F: nop
    IL_0010: nop
    IL_0012: br.s IL_0090
    IL_0013: IL_B2
    IL_0014: ldarg.1
    IL_0015: nop
    IL_0016: ldarg.2
    IL_0017: ldarg.0
    IL_001C: ldstr 0x7000054F
    IL_0021: call 0x060003F9
    IL_0026: stfld 0x040003B4
    IL_0027: ldarg.0
    IL_0028: ldarg.0
    IL_002D: call 0x2B00000C
    IL_0032: stfld 0x040003B0
    IL_0033: ldarg.0
    IL_0034: ldarg.0
    IL_0039: call 0x2B000032
    IL_003E: stfld 0x040003B1
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x040003D5
    IL_0046: conv.r8
    IL_0047: ret
    IL_0048: nop
    IL_0049: nop
    IL_004B: br.s IL_00C9
    IL_004C: IL_AE
    IL_004D: ldarg.1
    IL_004E: nop
    IL_004F: ldarg.2
    IL_0050: ldarg.0
    IL_0055: call 0x0A000035
    IL_0056: conv.r8
    IL_0057: ldloc.0
    IL_0058: nop
    IL_0059: nop
    IL_005B: br.s IL_00D9
    IL_005C: IL_AF
    IL_005D: ldarg.1
    IL_005E: nop
    IL_005F: ldarg.2
    IL_0060: ldarg.0
    IL_0061: ldarg.0
    IL_0066: ldfld 0x040003E3
    IL_006B: ldstr 0x7000184D
    IL_006C: conv.r8
    IL_006E: brfalse.s IL_006F
    IL_006F: nop
    IL_0070: stloc.0
    IL_0075: stfld 0x040003E2
    IL_0076: ldarg.0
    IL_0077: ldarg.0
    IL_007C: ldfld 0x040003E3
    IL_0081: ldstr 0x70001859
    IL_0082: conv.r8
    IL_0084: brfalse.s IL_0085
    IL_0085: nop
    IL_0086: stloc.0
    IL_008B: stfld 0x040003E1
    IL_008C: ret
    }

    public void SetBaseDamage() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040003C2
    IL_0007: ret
    }

    public void Set_General_Skill() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: IL_5A
    IL_0004: conv.i2
    IL_0005: IL_22
    IL_0006: stloc.0
    IL_0007: IL_D7
    IL_0008: IL_23
    IL_0009: IL_3C
    IL_000A: IL_5A
    IL_000B: neg
    IL_0010: stfld 0x040003BA
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040003BA
    IL_0018: ldc.i4.1
    IL_001D: call 0x0A000080
    IL_001E: neg
    IL_0023: stfld 0x040003BA
    IL_0024: ldarg.0
    IL_0025: ldarg.3
    IL_002A: stfld 0x040003BB
    IL_002B: ret
    }

    public void Set_R_hand() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040003FD
    IL_0007: ret
    }

    public void PetSkillOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003D5
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040003E3
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: ldloc.3
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040003AE
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_8923: switch (8768 cases)
    }

    public void SkillOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003B0
    IL_0006: conv.r8
    IL_0007: stind.i
    IL_0008: IL_01
    IL_0009: nop
    IL_000A: ldloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040003E2
    IL_0011: conv.r8
    IL_0012: IL_B0
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldc.i4.1
    IL_0017: conv.r8
    IL_0018: IL_B6
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: call 0x0A00003D
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: ldelem.r8
    IL_0026: IL_41
    IL_0027: conv.r8
    IL_0028: ldc.i4.8
    IL_0029: IL_01
    IL_002A: nop
    IL_002B: stloc.0
    IL_002C: ldarg.0
    IL_002D: ldarg.1
    IL_0032: stfld 0x040003B5
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040003D5
    IL_0039: ldarg.0
    IL_003E: ldfld 0x040003E3
    IL_003F: conv.r8
    IL_0040: ldc.i4.2
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: conv.r8
    IL_0045: ldloc.3
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x040003AE
    IL_004F: IL_22
    IL_0050: nop
    IL_0051: nop
    IL_0052: IL_C0
    IL_0053: IL_3F
    IL_0054: IL_22
    IL_0055: nop
    IL_0056: nop
    IL_005B: ldc.i4 52437058
    IL_005C: nop
    IL_005D: nop
    IL_0062: ldc.i4 150
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: nop
    IL_0067: IL_3F
    IL_0068: conv.r8
    IL_0069: IL_A8
    IL_006A: ldarg.0
    IL_006B: nop
    IL_006C: ldloc.0
    IL_006D: IL_22
    IL_006E: IL_CD
    IL_006F: IL_CC
    IL_0070: IL_CC
    IL_0071: IL_3D
    IL_0076: call 0x0A000111
    IL_0077: ldarg.2
    IL_007C: brtrue IL_00F3
    IL_007D: ldarg.0
    IL_007E: ldarg.0
    IL_0083: ldfld 0x040003B2
    IL_0088: ldfld 0x04000505
    IL_0089: ldarg.0
    IL_008E: ldfld 0x040003B5
    IL_008F: ldc.i4.0
    IL_0094: call 0x0A000134
    IL_0099: ldfld 0x04000503
    IL_009E: stfld 0x040003B9
    IL_009F: ldarg.0
    IL_00A4: ldfld 0x040003B4
    IL_00A5: ldarg.0
    IL_00AA: ldfld 0x040003B5
    IL_00AB: ldc.i4.0
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x040003B4
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x040003B5
    IL_00B8: IL_94
    IL_00BD: call 0x0A000080
    IL_00BE: ldelem.i8
    IL_00BF: ldarg.0
    IL_00C0: ldarg.0
    IL_00C5: ldfld 0x040003B2
    IL_00CA: ldfld 0x04000505
    IL_00CB: ldarg.0
    IL_00D0: ldfld 0x040003B5
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x040003B4
    IL_00D7: ldarg.0
    IL_00DC: ldfld 0x040003B5
    IL_00DD: IL_94
    IL_00E2: call 0x0A000134
    IL_00E7: ldfld 0x040004FF
    IL_00E8: conv.i2
    IL_00ED: stfld 0x040003B7
    IL_00F2: br IL_011B
    IL_00F3: ldarg.0
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x040003BB
    IL_00FE: stfld 0x040003B9
    IL_00FF: ldarg.0
    IL_0100: ldarg.0
    IL_0105: ldfld 0x040003BA
    IL_0106: conv.i2
    IL_010B: stfld 0x040003B7
    IL_010C: ldarg.0
    IL_010D: dup
    IL_0112: ldfld 0x040003B5
    IL_0114: ldc.i4.s 21
    IL_0115: IL_58
    IL_011A: stfld 0x040003B5
    IL_011B: ldarg.0
    IL_0120: ldfld 0x040003B9
    IL_0121: ldc.i4.1
    IL_01C2: switch (39 cases)
    IL_01C3: IL_E3
    IL_01C4: ldarg.1
    IL_01C5: nop
    IL_01C6: ldarg.2
    IL_01C7: conv.r8
    IL_01C8: ldc.i4.2
    IL_01C9: nop
    IL_01CA: nop
    IL_01CB: stloc.0
    IL_01CC: ldarg.0
    IL_01D1: ldfld 0x040003E3
    IL_01D2: conv.r8
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01D6: stloc.0
    IL_01D7: IL_22
    IL_01D8: IL_CD
    IL_01D9: IL_CC
    IL_01DA: IL_4C
    IL_01DB: IL_3E
    IL_01E0: call 0x0A000008
    IL_01E5: call 0x0A000029
    IL_01EA: call 0x0A000007
    IL_01EB: IL_22
    IL_01EC: stloc.0
    IL_01ED: IL_D7
    IL_01EE: IL_23
    IL_01EF: IL_3C
    IL_01F4: call 0x0A000008
    IL_01F9: call 0x0A000029
    IL_01FA: conv.r8
    IL_01FB: ldloc.3
    IL_01FC: nop
    IL_01FD: nop
    IL_01FE: stloc.0
    IL_0203: br IL_0222
    IL_0204: ldarg.0
    IL_0209: ldfld 0x040003B5
    IL_020B: ldc.i4.s 19
    IL_0254: switch (17 cases)
    IL_0255: ldarg.0
    IL_025A: ldfld 0x040003B5
    IL_025B: ldc.i4.8
    IL_03B8: switch (86 cases)
    IL_03B9: conv.r8
    IL_03BA: pop
    IL_03BB: nop
    IL_03BC: nop
    IL_03BD: stloc.0
    IL_03C2: call 0x0A000014
    IL_03C3: conv.u4
    IL_03C4: ldarg.1
    IL_03C5: nop
    IL_03C6: nop
    IL_03C7: IL_01
    IL_03CC: stfld 0x040003EF
    IL_03CD: ldarg.0
    IL_03D2: ldfld 0x040003EF
    IL_03D3: conv.r8
    IL_03D4: IL_3D
    IL_03D5: nop
    IL_03D6: nop
    IL_03D7: stloc.0
    IL_03D8: ldarg.0
    IL_03DD: ldfld 0x040003B7
    IL_03DE: ldarg.0
    IL_03E3: ldfld 0x040003C2
    IL_03E4: IL_5A
    IL_03E5: IL_22
    IL_03E6: stloc.0
    IL_03E7: IL_D7
    IL_03E8: IL_23
    IL_03E9: IL_3C
    IL_03EA: IL_5A
    IL_03EB: conv.r8
    IL_03EC: IL_84
    IL_03ED: nop
    IL_03EE: nop
    IL_03EF: stloc.0
    IL_03F0: ldarg.0
    IL_03F5: ldfld 0x040003EF
    IL_03F6: ldarg.0
    IL_03FB: ldfld 0x040003E3
    IL_03FC: conv.r8
    IL_03FD: IL_4E
    IL_03FE: nop
    IL_03FF: nop
    IL_0400: stloc.0
    IL_0405: br IL_0454
    IL_0406: ldarg.0
    IL_040B: ldfld 0x040003EF
    IL_040C: conv.r8
    IL_040D: stloc.0
    IL_040E: nop
    IL_040F: nop
    IL_0410: stloc.0
    IL_0411: ldc.i4.1
    IL_0412: conv.r8
    IL_0413: stloc.1
    IL_0414: nop
    IL_0415: nop
    IL_0416: stloc.0
    IL_0417: ldarg.0
    IL_041C: ldfld 0x040003EF
    IL_041D: ldarg.0
    IL_0422: ldfld 0x040003E3
    IL_0423: conv.r8
    IL_0424: ldc.i4.2
    IL_0425: nop
    IL_0426: nop
    IL_0427: stloc.0
    IL_0428: conv.r8
    IL_0429: ldloc.3
    IL_042A: nop
    IL_042B: nop
    IL_042C: stloc.0
    IL_042D: ldarg.0
    IL_0432: ldfld 0x040003EF
    IL_0433: ldarg.0
    IL_0438: ldfld 0x040003E3
    IL_0439: conv.r8
    IL_043A: pop
    IL_043B: nop
    IL_043C: nop
    IL_043D: stloc.0
    IL_043E: conv.r8
    IL_0443: call 0x020A0000
    IL_0448: ldfld 0x040003EF
    IL_0449: ldarg.0
    IL_044E: ldfld 0x040003E3
    IL_044F: conv.r8
    IL_0450: IL_4E
    IL_0451: nop
    IL_0452: nop
    IL_0453: stloc.0
    IL_0454: ret
    }

    public void LaunchSkill() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040003B3
    IL_000C: conv.r8
    IL_000D: ldind.ref
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040003E2
    IL_0017: conv.r8
    IL_0018: IL_B0
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: conv.r8
    IL_001E: IL_B6
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: ldarg.1
    IL_0023: stloc.3
    IL_0024: ldloc.3
    IL_0027: ldarg 41
    IL_0028: nop
    IL_0029: nop
    IL_002A: ldarg.3
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_BD
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: IL_EF
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_A9
    IL_0037: IL_01
    IL_0038: nop
    IL_0039: nop
    IL_003A: IL_3F
    IL_003B: ldarg.0
    IL_003C: nop
    IL_003D: nop
    IL_003E: IL_53
    IL_003F: ldarg.1
    IL_0040: nop
    IL_0041: nop
    IL_0042: IL_44
    IL_0043: ldarg.2
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_34
    IL_0047: ldarg.3
    IL_0048: nop
    IL_0049: nop
    IL_004A: IL_B6
    IL_004B: ldarg.3
    IL_004C: nop
    IL_004D: nop
    IL_004E: not
    IL_004F: ldloc.0
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.3
    IL_0053: ldloc.1
    IL_0054: nop
    IL_0055: nop
    IL_0056: IL_C0
    IL_0057: ldloc.1
    IL_0058: nop
    IL_0059: nop
    IL_005B: ldloc.s 8
    IL_005C: nop
    IL_005D: nop
    IL_0060: ldloc 9
    IL_0061: nop
    IL_0062: conv.i8
    IL_0063: stloc.0
    IL_0064: nop
    IL_0065: nop
    IL_006A: newobj 0xB100000B
    IL_006B: stloc.2
    IL_006C: nop
    IL_006D: nop
    IL_006E: IL_ED
    IL_006F: stloc.2
    IL_0070: nop
    IL_0071: nop
    IL_0072: IL_99
    IL_0074: ldarg.s 0
    IL_0075: nop
    IL_0076: IL_57
    IL_0078: starg.s 0
    IL_0079: nop
    IL_007E: br IL_-6CFFFF5C
    IL_0080: starg.s 0
    IL_0081: nop
    IL_0082: ldind.ref
    IL_0084: ldloc.s 0
    IL_0085: nop
    IL_0086: IL_95
    IL_0088: ldloca.s 0
    IL_0089: nop
    IL_008A: IL_56
    IL_008C: stloc.s 0
    IL_008D: nop
    IL_008E: dup
    IL_008F: ldnull
    IL_0090: nop
    IL_0091: nop
    IL_0092: IL_81
    IL_0093: ldc.i4.m1
    IL_0094: nop
    IL_0095: nop
    IL_0097: blt.s IL_00AE
    IL_0098: nop
    IL_0099: nop
    IL_009A: IL_E9
    IL_009B: ldc.i4.0
    IL_009C: nop
    IL_009D: nop
    IL_00A6: ldc.i8 -6485183353975734247
    IL_00A7: ldc.i4.4
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: IL_23
    IL_00AB: ldc.i4.5
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: IL_D2
    IL_00AF: ldc.i4.6
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: IL_DF
    IL_00B3: ldc.i4.7
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: IL_D6
    IL_00B7: ldc.i4.8
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: IL_E7
    IL_00BC: ldc.i4.s 0
    IL_00BD: nop
    IL_00BE: IL_DE
    IL_00C3: ldc.i4 565641216
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: IL_E2
    IL_00C7: IL_22
    IL_00C8: nop
    IL_00C9: nop
    IL_00CA: stloc.3
    IL_00CB: IL_24
    IL_00CC: nop
    IL_00CD: nop
    IL_00D2: br IL_2606
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x040003E4
    IL_00DD: ldstr 0x70001259
    IL_00DE: conv.r8
    IL_00DF: IL_3C
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: stloc.0
    IL_00E3: pop
    IL_00E4: ldarg.0
    IL_00E9: ldfld 0x040003EE
    IL_00EA: ldnull
    IL_00EF: call 0x0A000061
    IL_00F4: brfalse IL_0149
    IL_00F5: ldarg.0
    IL_00F6: ldarg.0
    IL_00FB: ldfld 0x040003C4
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x040003E3
    IL_0102: conv.r8
    IL_0103: ldc.i4.2
    IL_0104: nop
    IL_0105: nop
    IL_0106: stloc.0
    IL_0107: ldarg.0
    IL_010C: ldfld 0x040003E3
    IL_010D: conv.r8
    IL_010E: pop
    IL_010F: nop
    IL_0110: nop
    IL_0111: stloc.0
    IL_0116: call 0x0A000014
    IL_0117: conv.u4
    IL_0118: ldarg.1
    IL_0119: nop
    IL_011A: nop
    IL_011B: IL_01
    IL_0120: stfld 0x040003EE
    IL_0121: ldarg.0
    IL_0126: ldfld 0x040003EE
    IL_0127: conv.r8
    IL_0128: IL_3D
    IL_0129: nop
    IL_012A: nop
    IL_012B: stloc.0
    IL_012C: ldarg.0
    IL_0131: ldfld 0x040003B7
    IL_0132: ldarg.0
    IL_0137: ldfld 0x040003C2
    IL_0138: IL_5A
    IL_0139: IL_22
    IL_013A: stloc.0
    IL_013B: IL_D7
    IL_013C: IL_23
    IL_013D: IL_3C
    IL_013E: IL_5A
    IL_013F: conv.r8
    IL_0140: IL_84
    IL_0141: nop
    IL_0142: nop
    IL_0143: stloc.0
    IL_0148: br IL_0186
    IL_0149: ldarg.0
    IL_014E: ldfld 0x040003EE
    IL_014F: conv.r8
    IL_0150: stloc.0
    IL_0151: nop
    IL_0152: nop
    IL_0153: stloc.0
    IL_0154: ldc.i4.1
    IL_0155: conv.r8
    IL_0156: stloc.1
    IL_0157: nop
    IL_0158: nop
    IL_0159: stloc.0
    IL_015A: ldarg.0
    IL_015F: ldfld 0x040003EE
    IL_0160: ldarg.0
    IL_0165: ldfld 0x040003E3
    IL_0166: conv.r8
    IL_0167: ldc.i4.2
    IL_0168: nop
    IL_0169: nop
    IL_016A: stloc.0
    IL_016B: conv.r8
    IL_016C: ldloc.3
    IL_016D: nop
    IL_016E: nop
    IL_016F: stloc.0
    IL_0170: ldarg.0
    IL_0175: ldfld 0x040003EE
    IL_0176: ldarg.0
    IL_017B: ldfld 0x040003E3
    IL_017C: conv.r8
    IL_017D: pop
    IL_017E: nop
    IL_017F: nop
    IL_0180: stloc.0
    IL_0181: conv.r8
    IL_0186: call 0x380A0000
    IL_018B: ldfld 0x02000024
    IL_0190: ldfld 0x040003E4
    IL_0195: ldstr 0x70001299
    IL_0196: conv.r8
    IL_0197: IL_3C
    IL_0198: nop
    IL_0199: nop
    IL_019A: stloc.0
    IL_019B: pop
    IL_019C: ldarg.0
    IL_01A1: ldfld 0x040003E4
    IL_01A6: ldstr 0x70001471
    IL_01A7: conv.r8
    IL_01AC: newobj 0x0A0A0000
    IL_01AD: ldloc.0
    IL_01AE: IL_22
    IL_01AF: nop
    IL_01B0: nop
    IL_01B5: stsfld 0x00306F3E
    IL_01B6: nop
    IL_01B7: stloc.0
    IL_01BC: br IL_2606
    IL_01BD: ldarg.0
    IL_01C2: ldfld 0x040003E4
    IL_01C7: ldstr 0x700012C3
    IL_01C8: conv.r8
    IL_01C9: IL_3C
    IL_01CA: nop
    IL_01CB: nop
    IL_01CC: stloc.0
    IL_01CD: pop
    IL_01CE: ldarg.0
    IL_01D3: ldfld 0x040003E9
    IL_01D4: ldnull
    IL_01D9: call 0x0A000061
    IL_01DE: brfalse IL_0261
    IL_01DF: ldarg.0
    IL_01E0: ldarg.0
    IL_01E5: ldfld 0x040003C6
    IL_01E6: ldarg.0
    IL_01EB: ldfld 0x040003E3
    IL_01EC: conv.r8
    IL_01ED: ldc.i4.2
    IL_01EE: nop
    IL_01EF: nop
    IL_01F0: stloc.0
    IL_01F5: call 0x0A000007
    IL_01F6: IL_22
    IL_01F7: IL_CD
    IL_01F8: IL_CC
    IL_01F9: IL_CC
    IL_01FA: IL_3D
    IL_01FF: call 0x0A000008
    IL_0204: call 0x0A000029
    IL_0205: IL_22
    IL_0206: nop
    IL_0207: nop
    IL_0208: IL_34
    IL_0209: IL_43
    IL_020A: IL_22
    IL_020B: nop
    IL_020C: nop
    IL_020D: nop
    IL_020E: nop
    IL_020F: IL_22
    IL_0210: nop
    IL_0211: nop
    IL_0212: nop
    IL_0213: nop
    IL_0218: call 0x0A000060
    IL_021D: call 0x0A000014
    IL_021E: conv.u4
    IL_021F: ldarg.1
    IL_0220: nop
    IL_0221: nop
    IL_0222: IL_01
    IL_0227: stfld 0x040003E9
    IL_0228: ldarg.0
    IL_022D: ldfld 0x040003E9
    IL_022E: conv.r8
    IL_022F: IL_3D
    IL_0230: nop
    IL_0231: nop
    IL_0232: stloc.0
    IL_0233: ldarg.0
    IL_0238: ldfld 0x040003B7
    IL_0239: ldarg.0
    IL_023E: ldfld 0x040003C2
    IL_023F: IL_5A
    IL_0240: IL_22
    IL_0241: stloc.0
    IL_0242: IL_D7
    IL_0243: IL_23
    IL_0244: IL_3C
    IL_0245: IL_5A
    IL_0246: conv.r8
    IL_0247: IL_84
    IL_0248: nop
    IL_0249: nop
    IL_024A: stloc.0
    IL_024B: ldarg.0
    IL_0250: ldfld 0x040003E9
    IL_0251: ldarg.0
    IL_0256: ldfld 0x040003E3
    IL_0257: conv.r8
    IL_0258: IL_4E
    IL_0259: nop
    IL_025A: nop
    IL_025B: stloc.0
    IL_0260: br IL_0272
    IL_0261: ldarg.0
    IL_0266: ldfld 0x040003E9
    IL_0267: conv.r8
    IL_0268: stloc.0
    IL_0269: nop
    IL_026A: nop
    IL_026B: stloc.0
    IL_026C: ldc.i4.1
    IL_026D: conv.r8
    IL_026E: stloc.1
    IL_026F: nop
    IL_0270: nop
    IL_0271: stloc.0
    IL_0276: br IL_2606
    IL_0277: ldarg.0
    IL_027C: ldfld 0x040003E4
    IL_0281: ldstr 0x70001279
    IL_0282: conv.r8
    IL_0283: IL_3C
    IL_0284: nop
    IL_0285: nop
    IL_0286: stloc.0
    IL_0287: pop
    IL_0288: ldarg.0
    IL_028D: ldfld 0x040003E5
    IL_028E: ldnull
    IL_0293: call 0x0A000061
    IL_0298: brfalse IL_02C4
    IL_0299: ldarg.0
    IL_029A: ldarg.0
    IL_029F: ldfld 0x040003CB
    IL_02A0: ldarg.0
    IL_02A5: ldfld 0x040003E3
    IL_02A6: conv.r8
    IL_02A7: ldc.i4.2
    IL_02A8: nop
    IL_02A9: nop
    IL_02AA: stloc.0
    IL_02AF: call 0x0A000013
    IL_02B4: call 0x0A000014
    IL_02B5: conv.u4
    IL_02B6: ldarg.1
    IL_02B7: nop
    IL_02B8: nop
    IL_02B9: IL_01
    IL_02BE: stfld 0x040003E5
    IL_02C3: br IL_02CF
    IL_02C4: ldarg.0
    IL_02C9: ldstr 0x70001877
    IL_02CE: call 0x0A00007B
    IL_02CF: ldarg.0
    IL_02D4: ldfld 0x040003CC
    IL_02D5: conv.r8
    IL_02D6: IL_3E
    IL_02D7: nop
    IL_02D8: nop
    IL_02DA: br.s IL_02F2
    IL_02DB: ldarg.0
    IL_02E0: ldfld 0x040003E3
    IL_02E1: conv.r8
    IL_02E2: ldc.i4.2
    IL_02E3: nop
    IL_02E4: nop
    IL_02E5: stloc.0
    IL_02E6: ldc.i4.1
    IL_02E7: conv.r8
    IL_02E8: ldind.ref
    IL_02E9: ldarg.0
    IL_02EA: nop
    IL_02EB: ldloc.0
    IL_02EC: ldarg.0
    IL_02F1: ldfld 0x040003B0
    IL_02F2: conv.r8
    IL_02F3: IL_96
    IL_02F4: IL_01
    IL_02F5: nop
    IL_02F6: ldloc.0
    IL_02F7: ldarg.0
    IL_02FC: ldstr 0x70001877
    IL_02FD: ldarg.0
    IL_0302: ldfld 0x040003B7
    IL_0307: call 0x0A00003F
    IL_030C: br IL_2606
    IL_030D: ldarg.0
    IL_0312: ldfld 0x040003E4
    IL_0317: ldstr 0x70001439
    IL_0318: conv.r8
    IL_0319: IL_3C
    IL_031A: nop
    IL_031B: nop
    IL_031C: stloc.0
    IL_031D: pop
    IL_031E: ldarg.0
    IL_0323: ldfld 0x040003E8
    IL_0324: ldnull
    IL_0329: call 0x0A000061
    IL_032E: brfalse IL_03B1
    IL_032F: ldarg.0
    IL_0330: ldarg.0
    IL_0335: ldfld 0x040003C5
    IL_0336: ldarg.0
    IL_033B: ldfld 0x040003E3
    IL_033C: conv.r8
    IL_033D: ldc.i4.2
    IL_033E: nop
    IL_033F: nop
    IL_0340: stloc.0
    IL_0341: ldarg.0
    IL_0346: ldfld 0x040003E3
    IL_0347: conv.r8
    IL_0348: IL_22
    IL_0349: nop
    IL_034A: nop
    IL_034B: stloc.0
    IL_034C: IL_22
    IL_034D: nop
    IL_034E: nop
    IL_0353: stsfld 0x0008283E
    IL_0354: nop
    IL_0355: stloc.0
    IL_035A: call 0x0A000029
    IL_035F: call 0x0A000007
    IL_0360: IL_22
    IL_0361: stloc.0
    IL_0362: IL_D7
    IL_0363: IL_23
    IL_0364: IL_3D
    IL_0369: call 0x0A000008
    IL_036E: call 0x0A000029
    IL_036F: ldarg.0
    IL_0374: ldfld 0x040003E3
    IL_0375: conv.r8
    IL_0376: pop
    IL_0377: nop
    IL_0378: nop
    IL_0379: stloc.0
    IL_037E: call 0x0A000014
    IL_037F: conv.u4
    IL_0380: ldarg.1
    IL_0381: nop
    IL_0382: nop
    IL_0383: IL_01
    IL_0388: stfld 0x040003E8
    IL_0389: ldarg.0
    IL_038E: ldfld 0x040003E8
    IL_038F: conv.r8
    IL_0390: IL_3D
    IL_0391: nop
    IL_0392: nop
    IL_0393: stloc.0
    IL_0394: ldarg.0
    IL_0399: ldfld 0x040003B7
    IL_039A: ldarg.0
    IL_039F: ldfld 0x040003C2
    IL_03A0: IL_5A
    IL_03A1: IL_22
    IL_03A2: stloc.0
    IL_03A3: IL_D7
    IL_03A4: IL_23
    IL_03A5: IL_3C
    IL_03A6: IL_5A
    IL_03A7: conv.r8
    IL_03A8: IL_84
    IL_03A9: nop
    IL_03AA: nop
    IL_03AB: stloc.0
    IL_03B0: br IL_041C
    IL_03B1: ldarg.0
    IL_03B6: ldfld 0x040003E8
    IL_03B7: conv.r8
    IL_03B8: stloc.0
    IL_03B9: nop
    IL_03BA: nop
    IL_03BB: stloc.0
    IL_03BC: ldc.i4.1
    IL_03BD: conv.r8
    IL_03BE: stloc.1
    IL_03BF: nop
    IL_03C0: nop
    IL_03C1: stloc.0
    IL_03C2: ldarg.0
    IL_03C7: ldfld 0x040003E8
    IL_03C8: ldarg.0
    IL_03CD: ldfld 0x040003E3
    IL_03CE: conv.r8
    IL_03CF: ldc.i4.2
    IL_03D0: nop
    IL_03D1: nop
    IL_03D2: stloc.0
    IL_03D3: ldarg.0
    IL_03D8: ldfld 0x040003E3
    IL_03D9: conv.r8
    IL_03DA: IL_22
    IL_03DB: nop
    IL_03DC: nop
    IL_03DD: stloc.0
    IL_03DE: IL_22
    IL_03DF: nop
    IL_03E0: nop
    IL_03E5: stsfld 0x0008283E
    IL_03E6: nop
    IL_03E7: stloc.0
    IL_03EC: call 0x0A000029
    IL_03F1: call 0x0A000007
    IL_03F2: IL_22
    IL_03F3: stloc.0
    IL_03F4: IL_D7
    IL_03F5: IL_23
    IL_03F6: IL_3D
    IL_03FB: call 0x0A000008
    IL_0400: call 0x0A000029
    IL_0401: conv.r8
    IL_0402: ldloc.3
    IL_0403: nop
    IL_0404: nop
    IL_0405: stloc.0
    IL_0406: ldarg.0
    IL_040B: ldfld 0x040003E8
    IL_040C: ldarg.0
    IL_0411: ldfld 0x040003E3
    IL_0412: conv.r8
    IL_0413: pop
    IL_0414: nop
    IL_0415: nop
    IL_0416: stloc.0
    IL_0417: conv.r8
    IL_041C: call 0x380A0000
    IL_041D: IL_E5
    IL_0426: ldc.i8 288234656002867200
    IL_042B: ldstr 0x700011F3
    IL_042C: conv.r8
    IL_042E: bge.s IL_042F
    IL_042F: nop
    IL_0430: stloc.0
    IL_0431: IL_22
    IL_0433: bne.un.s IL_0467
    IL_0434: conv.ovf.i4.un
    IL_0435: IL_3E
    IL_0436: conv.r8
    IL_0438: bgt.s IL_0439
    IL_0439: nop
    IL_043A: stloc.0
    IL_043B: ldarg.0
    IL_0440: ldfld 0x040003E4
    IL_0445: ldstr 0x700011F3
    IL_0446: conv.r8
    IL_0447: IL_3C
    IL_0448: nop
    IL_0449: nop
    IL_044A: stloc.0
    IL_044B: pop
    IL_044C: ldarg.0
    IL_044D: ldarg.0
    IL_0452: ldfld 0x040003E4
    IL_0457: ldstr 0x70001207
    IL_0458: conv.r8
    IL_045D: newobj 0x7D0A0000
    IL_045E: IL_01
    IL_045F: ldarg.2
    IL_0460: nop
    IL_0461: ldarg.2
    IL_0462: ldarg.0
    IL_0467: ldfld 0x04000401
    IL_0468: IL_22
    IL_0469: nop
    IL_046A: nop
    IL_046F: stsfld 0x00306F3E
    IL_0470: nop
    IL_0471: stloc.0
    IL_0472: ldarg.0
    IL_0477: ldfld 0x040003F9
    IL_0478: ldnull
    IL_047D: call 0x0A000061
    IL_0482: brfalse IL_04FC
    IL_0483: ldarg.0
    IL_0484: ldarg.0
    IL_0489: ldfld 0x040003E0
    IL_048A: ldarg.0
    IL_048F: ldfld 0x040003E3
    IL_0490: conv.r8
    IL_0491: ldc.i4.2
    IL_0492: nop
    IL_0493: nop
    IL_0494: stloc.0
    IL_0499: call 0x0A000007
    IL_049A: IL_22
    IL_049B: IL_CD
    IL_049C: IL_CC
    IL_049D: IL_4C
    IL_049E: IL_3D
    IL_04A3: call 0x0A000008
    IL_04A8: call 0x0A000029
    IL_04A9: ldarg.0
    IL_04AE: ldfld 0x040003E3
    IL_04AF: conv.r8
    IL_04B0: pop
    IL_04B1: nop
    IL_04B2: nop
    IL_04B3: stloc.0
    IL_04B8: call 0x0A000014
    IL_04B9: conv.u4
    IL_04BA: ldarg.1
    IL_04BB: nop
    IL_04BC: nop
    IL_04BD: IL_01
    IL_04C2: stfld 0x040003F9
    IL_04C3: ldarg.0
    IL_04C8: ldfld 0x040003F9
    IL_04C9: ldarg.0
    IL_04CE: ldfld 0x040003E3
    IL_04CF: conv.r8
    IL_04D0: IL_4E
    IL_04D1: nop
    IL_04D2: nop
    IL_04D3: stloc.0
    IL_04D4: ldarg.0
    IL_04D9: ldfld 0x040003F9
    IL_04DA: conv.r8
    IL_04DB: IL_3D
    IL_04DC: nop
    IL_04DD: nop
    IL_04DE: stloc.0
    IL_04DF: ldarg.0
    IL_04E4: ldfld 0x040003B7
    IL_04E5: ldarg.0
    IL_04EA: ldfld 0x040003C2
    IL_04EB: IL_5A
    IL_04EC: IL_22
    IL_04ED: stloc.0
    IL_04EE: IL_D7
    IL_04EF: IL_23
    IL_04F0: IL_3C
    IL_04F1: IL_5A
    IL_04F2: conv.r8
    IL_04F3: IL_84
    IL_04F4: nop
    IL_04F5: nop
    IL_04F6: stloc.0
    IL_04FB: br IL_050D
    IL_04FC: ldarg.0
    IL_0501: ldfld 0x040003F9
    IL_0502: conv.r8
    IL_0503: stloc.0
    IL_0504: nop
    IL_0505: nop
    IL_0506: stloc.0
    IL_0507: ldc.i4.1
    IL_0508: conv.r8
    IL_0509: stloc.1
    IL_050A: nop
    IL_050B: nop
    IL_050C: stloc.0
    IL_0511: br IL_2606
    IL_0512: ldarg.0
    IL_0517: ldfld 0x040003E4
    IL_051C: ldstr 0x70001279
    IL_051D: conv.r8
    IL_051E: IL_3C
    IL_051F: nop
    IL_0520: nop
    IL_0521: stloc.0
    IL_0522: pop
    IL_0523: ldarg.0
    IL_0528: ldfld 0x040003F8
    IL_0529: ldnull
    IL_052E: call 0x0A000061
    IL_0533: brfalse IL_059C
    IL_0534: ldarg.0
    IL_0535: ldarg.0
    IL_053A: ldfld 0x040003C7
    IL_053B: ldarg.0
    IL_0540: ldfld 0x040003E3
    IL_0541: conv.r8
    IL_0542: ldc.i4.2
    IL_0543: nop
    IL_0544: nop
    IL_0545: stloc.0
    IL_054A: call 0x0A000007
    IL_054B: IL_22
    IL_054C: IL_CD
    IL_054D: IL_CC
    IL_054E: IL_4C
    IL_054F: IL_3E
    IL_0554: call 0x0A000008
    IL_0559: call 0x0A000029
    IL_055A: ldarg.0
    IL_055F: ldfld 0x040003E3
    IL_0560: conv.r8
    IL_0561: pop
    IL_0562: nop
    IL_0563: nop
    IL_0564: stloc.0
    IL_0569: call 0x0A000014
    IL_056A: conv.u4
    IL_056B: ldarg.1
    IL_056C: nop
    IL_056D: nop
    IL_056E: IL_01
    IL_0573: stfld 0x040003F8
    IL_0574: ldarg.0
    IL_0579: ldfld 0x040003F8
    IL_057A: conv.r8
    IL_057B: IL_3D
    IL_057C: nop
    IL_057D: nop
    IL_057E: stloc.0
    IL_057F: ldarg.0
    IL_0584: ldfld 0x040003B7
    IL_0585: ldarg.0
    IL_058A: ldfld 0x040003C2
    IL_058B: IL_5A
    IL_058C: IL_22
    IL_058D: stloc.0
    IL_058E: IL_D7
    IL_058F: IL_23
    IL_0590: IL_3C
    IL_0591: IL_5A
    IL_0592: conv.r8
    IL_0593: IL_84
    IL_0594: nop
    IL_0595: nop
    IL_0596: stloc.0
    IL_059B: br IL_05FD
    IL_059C: ldarg.0
    IL_05A1: ldfld 0x040003F8
    IL_05A2: conv.r8
    IL_05A3: IL_3F
    IL_05A4: nop
    IL_05A5: nop
    IL_05A7: br.s IL_0617
    IL_05A8: ldnull
    IL_05A9: ldarg.3
    IL_05AA: nop
    IL_05AB: ldloc.0
    IL_05AC: ldarg.0
    IL_05B1: ldfld 0x040003F8
    IL_05B2: ldarg.0
    IL_05B7: ldfld 0x040003E3
    IL_05B8: conv.r8
    IL_05B9: ldc.i4.2
    IL_05BA: nop
    IL_05BB: nop
    IL_05BC: stloc.0
    IL_05C1: call 0x0A000007
    IL_05C2: IL_22
    IL_05C3: IL_CD
    IL_05C4: IL_CC
    IL_05C5: IL_4C
    IL_05C6: IL_3E
    IL_05CB: call 0x0A000008
    IL_05D0: call 0x0A000029
    IL_05D1: conv.r8
    IL_05D2: ldloc.3
    IL_05D3: nop
    IL_05D4: nop
    IL_05D5: stloc.0
    IL_05D6: ldarg.0
    IL_05DB: ldfld 0x040003F8
    IL_05DC: ldarg.0
    IL_05E1: ldfld 0x040003E3
    IL_05E2: conv.r8
    IL_05E3: pop
    IL_05E4: nop
    IL_05E5: nop
    IL_05E6: stloc.0
    IL_05E7: conv.r8
    IL_05EC: call 0x020A0000
    IL_05F1: ldfld 0x040003F8
    IL_05F2: conv.r8
    IL_05F3: stloc.0
    IL_05F4: nop
    IL_05F5: nop
    IL_05F6: stloc.0
    IL_05F7: ldc.i4.1
    IL_05F8: conv.r8
    IL_05F9: stloc.1
    IL_05FA: nop
    IL_05FB: nop
    IL_05FC: stloc.0
    IL_0601: br IL_2606
    IL_0602: ldarg.0
    IL_0607: ldfld 0x040003E4
    IL_060C: ldstr 0x70001279
    IL_060D: conv.r8
    IL_060E: IL_3C
    IL_060F: nop
    IL_0610: nop
    IL_0611: stloc.0
    IL_0612: pop
    IL_0613: ldarg.0
    IL_0618: ldfld 0x040003CA
    IL_0619: conv.r8
    IL_061A: IL_B0
    IL_061B: nop
    IL_061C: nop
    IL_061D: stloc.0
    IL_061E: stloc.1
    IL_061F: ldloc.1
    IL_0620: conv.r8
    IL_0625: br IL_3A0A0627
    IL_0626: stloc.2
    IL_0627: nop
    IL_0628: nop
    IL_0629: nop
    IL_062A: ldloc.1
    IL_062B: ldc.i4.1
    IL_062C: conv.r8
    IL_062D: IL_B6
    IL_062E: nop
    IL_062F: nop
    IL_0630: stloc.0
    IL_0635: br IL_0641
    IL_0636: ldarg.0
    IL_063B: ldstr 0x70001891
    IL_0640: call 0x0A00007B
    IL_0641: ldarg.0
    IL_0646: ldfld 0x040003CC
    IL_0647: conv.r8
    IL_0648: IL_3E
    IL_0649: nop
    IL_064A: nop
    IL_064C: br.s IL_0663
    IL_064D: ldarg.0
    IL_0652: ldfld 0x040003E3
    IL_0653: conv.r8
    IL_0654: ldc.i4.2
    IL_0655: nop
    IL_0656: nop
    IL_0657: stloc.0
    IL_0658: ldc.i4.1
    IL_0659: conv.r8
    IL_065A: ldind.ref
    IL_065B: ldarg.0
    IL_065C: nop
    IL_065D: ldloc.0
    IL_065E: ldarg.0
    IL_0663: ldfld 0x040003B0
    IL_0664: IL_22
    IL_0665: nop
    IL_0666: nop
    IL_0667: IL_C0
    IL_0668: IL_3F
    IL_0669: conv.r8
    IL_066A: IL_94
    IL_066B: IL_01
    IL_066C: nop
    IL_066D: ldloc.0
    IL_066E: ldarg.0
    IL_0673: ldstr 0x70001891
    IL_0674: ldarg.0
    IL_0679: ldfld 0x040003B7
    IL_067E: call 0x0A00003F
    IL_0683: br IL_2606
    IL_0684: ldarg.0
    IL_0689: ldfld 0x040003E4
    IL_068E: ldstr 0x70001269
    IL_068F: conv.r8
    IL_0690: IL_3C
    IL_0691: nop
    IL_0692: nop
    IL_0693: stloc.0
    IL_0694: pop
    IL_0695: ldarg.0
    IL_0696: ldarg.0
    IL_069B: ldfld 0x040003CE
    IL_069C: ldarg.0
    IL_06A1: ldfld 0x040003E3
    IL_06A2: conv.r8
    IL_06A3: ldc.i4.2
    IL_06A4: nop
    IL_06A5: nop
    IL_06A6: stloc.0
    IL_06AB: call 0x0A000007
    IL_06AC: IL_22
    IL_06AD: IL_AE
    IL_06B0: starg 15969
    IL_06B5: call 0x0A000008
    IL_06BA: call 0x0A000029
    IL_06BF: call 0x0A000013
    IL_06C4: call 0x0A000014
    IL_06C5: conv.u4
    IL_06C6: ldarg.1
    IL_06C7: nop
    IL_06C8: nop
    IL_06C9: IL_01
    IL_06CE: stfld 0x040003E7
    IL_06CF: ldarg.0
    IL_06D4: ldfld 0x040003E7
    IL_06D5: conv.r8
    IL_06D6: IL_3D
    IL_06D7: nop
    IL_06D8: nop
    IL_06D9: stloc.0
    IL_06DA: ldarg.0
    IL_06DF: ldfld 0x040003B7
    IL_06E0: ldarg.0
    IL_06E5: ldfld 0x040003C2
    IL_06E6: IL_5A
    IL_06E7: IL_22
    IL_06E8: stloc.0
    IL_06E9: IL_D7
    IL_06EA: IL_23
    IL_06EB: IL_3C
    IL_06EC: IL_5A
    IL_06ED: conv.r8
    IL_06EE: IL_84
    IL_06EF: nop
    IL_06F0: nop
    IL_06F1: stloc.0
    IL_06F2: ldarg.0
    IL_06F7: ldfld 0x040003E7
    IL_06F8: conv.r8
    IL_06F9: IL_3D
    IL_06FA: nop
    IL_06FB: nop
    IL_06FC: stloc.0
    IL_06FD: conv.r8
    IL_0700: ldarga 0
    IL_0701: stloc.0
    IL_0702: IL_22
    IL_0703: nop
    IL_0704: nop
    IL_0709: stsfld 0x0015413F
    IL_070A: nop
    IL_070B: nop
    IL_070C: ldarg.0
    IL_0711: ldfld 0x040003E7
    IL_0712: conv.r8
    IL_0713: IL_3D
    IL_0714: nop
    IL_0715: nop
    IL_0716: stloc.0
    IL_0717: IL_22
    IL_0718: nop
    IL_0719: nop
    IL_071E: stsfld 0x00846F3F
    IL_071F: nop
    IL_0720: stloc.0
    IL_0721: ldarg.0
    IL_0726: ldfld 0x040003E7
    IL_0727: ldarg.0
    IL_072C: ldfld 0x040003E3
    IL_072D: conv.r8
    IL_072E: IL_4E
    IL_072F: nop
    IL_0730: nop
    IL_0731: stloc.0
    IL_0736: br IL_2606
    IL_0737: ldarg.0
    IL_073C: ldfld 0x040003E4
    IL_0741: ldstr 0x70001289
    IL_0742: conv.r8
    IL_0743: IL_3C
    IL_0744: nop
    IL_0745: nop
    IL_0746: stloc.0
    IL_0747: pop
    IL_0748: ldarg.0
    IL_074D: ldfld 0x040003EA
    IL_074E: ldnull
    IL_0753: call 0x0A000061
    IL_0758: brfalse IL_07C5
    IL_0759: ldarg.0
    IL_075A: ldarg.0
    IL_075F: ldfld 0x040003D0
    IL_0760: ldarg.0
    IL_0765: ldfld 0x040003E3
    IL_0766: conv.r8
    IL_0767: ldc.i4.2
    IL_0768: nop
    IL_0769: nop
    IL_076A: stloc.0
    IL_076F: call 0x0A000007
    IL_0770: IL_22
    IL_0771: IL_CD
    IL_0772: IL_CC
    IL_0773: IL_4C
    IL_0774: IL_3D
    IL_0779: call 0x0A000008
    IL_077E: call 0x0A000029
    IL_077F: ldarg.0
    IL_0784: ldfld 0x040003E3
    IL_0785: conv.r8
    IL_0786: pop
    IL_0787: nop
    IL_0788: nop
    IL_0789: stloc.0
    IL_078E: call 0x0A000014
    IL_078F: conv.u4
    IL_0790: ldarg.1
    IL_0791: nop
    IL_0792: nop
    IL_0793: IL_01
    IL_0798: stfld 0x040003EA
    IL_0799: ldarg.0
    IL_079E: ldfld 0x040003EA
    IL_079F: conv.r8
    IL_07A0: IL_3D
    IL_07A1: nop
    IL_07A2: nop
    IL_07A3: stloc.0
    IL_07A4: ldarg.0
    IL_07A9: ldfld 0x040003B7
    IL_07AA: conv.r8
    IL_07AB: IL_84
    IL_07AC: nop
    IL_07AD: nop
    IL_07AE: stloc.0
    IL_07AF: ldarg.0
    IL_07B4: ldfld 0x040003EA
    IL_07B5: ldarg.0
    IL_07BA: ldfld 0x040003E3
    IL_07BB: conv.r8
    IL_07BC: IL_4E
    IL_07BD: nop
    IL_07BE: nop
    IL_07BF: stloc.0
    IL_07C4: br IL_07D6
    IL_07C5: ldarg.0
    IL_07CA: ldfld 0x040003EA
    IL_07CB: conv.r8
    IL_07CC: stloc.0
    IL_07CD: nop
    IL_07CE: nop
    IL_07CF: stloc.0
    IL_07D0: ldc.i4.1
    IL_07D1: conv.r8
    IL_07D2: stloc.1
    IL_07D3: nop
    IL_07D4: nop
    IL_07D5: stloc.0
    IL_07DA: br IL_2606
    IL_07DB: ldarg.0
    IL_07E0: ldfld 0x040003E4
    IL_07E5: ldstr 0x7000144D
    IL_07E6: conv.r8
    IL_07E7: IL_3C
    IL_07E8: nop
    IL_07E9: nop
    IL_07EA: stloc.0
    IL_07EB: pop
    IL_07EC: ldarg.0
    IL_07F1: ldfld 0x040003FC
    IL_07F2: ldnull
    IL_07F7: call 0x0A000061
    IL_07FC: brfalse IL_0878
    IL_07FD: ldarg.0
    IL_07FE: ldarg.0
    IL_0803: ldfld 0x040003C8
    IL_0804: ldarg.0
    IL_0809: ldfld 0x040003FD
    IL_080A: conv.r8
    IL_080B: ldc.i4.2
    IL_080C: nop
    IL_080D: nop
    IL_080E: stloc.0
    IL_080F: ldarg.0
    IL_0814: ldfld 0x040003FD
    IL_0815: conv.r8
    IL_0816: pop
    IL_0817: nop
    IL_0818: nop
    IL_0819: stloc.0
    IL_081E: call 0x0A000014
    IL_081F: conv.u4
    IL_0820: ldarg.1
    IL_0821: nop
    IL_0822: nop
    IL_0823: IL_01
    IL_0828: stfld 0x040003FC
    IL_0829: ldarg.0
    IL_082E: ldfld 0x040003FC
    IL_082F: ldarg.0
    IL_0834: ldfld 0x040003FD
    IL_0835: conv.r8
    IL_0836: IL_22
    IL_0837: nop
    IL_0838: nop
    IL_0839: stloc.0
    IL_083A: conv.r8
    IL_083B: IL_CC
    IL_083C: nop
    IL_083D: nop
    IL_083E: stloc.0
    IL_083F: ldarg.0
    IL_0844: ldfld 0x040003FC
    IL_0845: ldarg.0
    IL_084A: ldfld 0x040003FD
    IL_084B: conv.r8
    IL_084C: IL_4E
    IL_084D: nop
    IL_084E: nop
    IL_084F: stloc.0
    IL_0850: ldarg.0
    IL_0855: ldfld 0x040003FC
    IL_0856: conv.r8
    IL_0857: IL_3D
    IL_0858: nop
    IL_0859: nop
    IL_085A: stloc.0
    IL_085B: ldarg.0
    IL_0860: ldfld 0x040003B7
    IL_0861: ldarg.0
    IL_0866: ldfld 0x040003C2
    IL_0867: IL_5A
    IL_0868: IL_22
    IL_0869: stloc.0
    IL_086A: IL_D7
    IL_086B: IL_23
    IL_086C: IL_3C
    IL_086D: IL_5A
    IL_086E: conv.r8
    IL_086F: IL_84
    IL_0870: nop
    IL_0871: nop
    IL_0872: stloc.0
    IL_0877: br IL_0889
    IL_0878: ldarg.0
    IL_087D: ldfld 0x040003FC
    IL_087E: conv.r8
    IL_087F: stloc.0
    IL_0880: nop
    IL_0881: nop
    IL_0882: stloc.0
    IL_0883: ldc.i4.1
    IL_0884: conv.r8
    IL_0885: stloc.1
    IL_0886: nop
    IL_0887: nop
    IL_0888: stloc.0
    IL_088D: br IL_2606
    IL_088E: ldarg.0
    IL_0893: ldfld 0x040003B0
    IL_0894: IL_22
    IL_0895: nop
    IL_0896: nop
    IL_0897: ldelem.r8
    IL_64E58: switch (102767 cases)
    }

    public void DelaySkill() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003F6
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_003C
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040003DE
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040003E3
    IL_001E: conv.r8
    IL_001F: ldc.i4.2
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0027: call 0x0A000013
    IL_002C: call 0x0A000014
    IL_002D: conv.u4
    IL_002E: ldarg.1
    IL_002F: nop
    IL_0030: nop
    IL_0031: IL_01
    IL_0036: stfld 0x040003F6
    IL_003B: br IL_0063
    IL_003C: ldarg.0
    IL_0041: ldfld 0x040003F6
    IL_0042: ldarg.0
    IL_0047: ldfld 0x040003E3
    IL_0048: conv.r8
    IL_0049: ldc.i4.2
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: conv.r8
    IL_004E: ldloc.3
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ldarg.0
    IL_0057: ldfld 0x040003F6
    IL_0058: conv.r8
    IL_0059: stloc.0
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldc.i4.1
    IL_005E: conv.r8
    IL_005F: stloc.1
    IL_0060: nop
    IL_0061: nop
    IL_0062: stloc.0
    IL_0063: ldarg.0
    IL_0068: ldfld 0x040003F6
    IL_0069: conv.r8
    IL_006A: IL_3D
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_006E: ldarg.0
    IL_0073: ldfld 0x040003B7
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040003C2
    IL_007A: IL_5A
    IL_007B: IL_22
    IL_007C: stloc.0
    IL_007D: IL_D7
    IL_007E: IL_23
    IL_007F: IL_3C
    IL_0080: IL_5A
    IL_0081: conv.r8
    IL_0082: IL_84
    IL_0083: nop
    IL_0084: nop
    IL_0085: stloc.0
    IL_0086: ldarg.1
    IL_0087: stloc.0
    IL_0088: ldloc.0
    IL_0089: ldc.i4.2
    IL_008E: beq IL_009C
    IL_008F: ldloc.0
    IL_0091: ldc.i4.s 19
    IL_0096: beq IL_00CB
    IL_009B: br IL_014C
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x040003F6
    IL_00A6: call 0x0A00004B
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: IL_3F
    IL_00B0: call 0x0A000008
    IL_00B1: conv.r8
    IL_00B2: IL_AF
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x040003AF
    IL_00BC: IL_22
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: nop
    IL_4DA80: switch (79471 cases)
    }

    public void Repeatskill() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040003C1
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x040003BD
    IL_000E: ldarg.0
    IL_000F: ldarg.2
    IL_0014: stfld 0x040003BC
    IL_0015: ldarg.0
    IL_0016: ldarg.3
    IL_001B: stfld 0x040003BE
    IL_001C: ldarg.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040003BE
    IL_0027: stfld 0x040003BF
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040003BD
    IL_002E: stloc.0
    IL_002F: ldloc.0
    IL_0031: ldc.i4.s 29
    IL_0032: IL_59
    IL_0035: ldarg 3
    IL_0036: nop
    IL_0037: nop
    IL_0038: IL_23
    IL_0039: ldarg.2
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0042: ldarg 5
    IL_0043: nop
    IL_0044: ldloc.0
    IL_0046: ldc.i4.s 11
    IL_004B: beq IL_0061
    IL_004C: ldloc.0
    IL_004E: ldc.i4.s 17
    IL_0053: beq IL_0122
    IL_0054: ldloc.0
    IL_0056: ldc.i4.s 25
    IL_005B: beq IL_0257
    IL_0060: br IL_066E
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x040003E3
    IL_0068: conv.r8
    IL_0069: ldc.i4.2
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: ldarg.0
    IL_0072: ldfld 0x040003E3
    IL_0073: conv.r8
    IL_0074: IL_22
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: IL_22
    IL_0079: ldelem.i
    IL_007A: IL_99
    IL_007B: IL_99
    IL_007C: IL_3E
    IL_0081: call 0x0A000008
    IL_0086: call 0x0A000029
    IL_0087: ldarg.0
    IL_008C: ldfld 0x040003E3
    IL_008D: conv.r8
    IL_008E: mul
    IL_008F: nop
    IL_0090: nop
    IL_0091: stloc.0
    IL_0092: IL_22
    IL_0093: IL_CD
    IL_0094: IL_CC
    IL_0095: IL_4C
    IL_0096: IL_BE
    IL_0097: IL_22
    IL_0098: IL_CD
    IL_0099: IL_CC
    IL_009A: IL_4C
    IL_009B: IL_3E
    IL_00A0: call 0x0A000075
    IL_00A5: call 0x0A000008
    IL_00AA: call 0x0A000029
    IL_00AF: stfld 0x04000400
    IL_00B0: ldarg.0
    IL_00B5: ldflda 0x04000400
    IL_00B6: ldc.i4.1
    IL_00B7: IL_22
    IL_00B8: stloc.0
    IL_00B9: IL_D7
    IL_00BA: IL_23
    IL_00BB: IL_3C
    IL_00C0: call 0x0A00001A
    IL_00C1: ldarg.0
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x040003C9
    IL_00C8: ldarg.0
    IL_00CD: ldfld 0x04000400
    IL_00D2: call 0x0A000013
    IL_00D7: call 0x0A000014
    IL_00D8: conv.u4
    IL_00D9: ldarg.1
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: IL_01
    IL_00E1: stfld 0x040003FB
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x040003FB
    IL_00E8: conv.r8
    IL_00E9: IL_3D
    IL_00EA: nop
    IL_00EB: nop
    IL_00EC: stloc.0
    IL_00ED: ldarg.0
    IL_00F2: ldfld 0x040003B8
    IL_00F3: conv.r8
    IL_00F4: IL_84
    IL_00F5: nop
    IL_00F6: nop
    IL_00F7: stloc.0
    IL_00F8: ldarg.0
    IL_00FD: ldfld 0x040003FB
    IL_00FE: conv.r8
    IL_00FF: stloc.0
    IL_0100: nop
    IL_0101: nop
    IL_0102: stloc.0
    IL_0103: IL_22
    IL_0104: nop
    IL_0105: nop
    IL_0106: IL_C0
    IL_0107: IL_3F
    IL_010C: call 0x0A000071
    IL_010D: ldarg.0
    IL_0112: ldfld 0x040003AF
    IL_0113: IL_22
    IL_0114: nop
    IL_0115: nop
    IL_0116: IL_C0
    IL_0117: IL_3F
    IL_0118: conv.r8
    IL_0119: IL_36
    IL_011A: IL_01
    IL_011B: nop
    IL_011C: ldloc.0
    IL_0121: br IL_066E
    IL_0122: ldarg.0
    IL_0123: ldarg.0
    IL_0128: ldfld 0x040003E3
    IL_0129: conv.r8
    IL_012A: ldc.i4.2
    IL_012B: nop
    IL_012C: nop
    IL_012D: stloc.0
    IL_012E: ldarg.0
    IL_0133: ldfld 0x040003E3
    IL_0134: conv.r8
    IL_0135: IL_22
    IL_0136: nop
    IL_0137: nop
    IL_0138: stloc.0
    IL_0139: IL_22
    IL_013A: ldelem.i
    IL_013B: IL_99
    IL_013C: IL_99
    IL_013D: IL_3E
    IL_013E: IL_22
    IL_013F: shr
    IL_0140: shr
    IL_0141: IL_E6
    IL_0142: IL_3E
    IL_0147: call 0x0A000075
    IL_014C: call 0x0A000008
    IL_0151: call 0x0A000029
    IL_0152: ldarg.0
    IL_0157: ldfld 0x040003E3
    IL_0158: conv.r8
    IL_0159: mul
    IL_015A: nop
    IL_015B: nop
    IL_015C: stloc.0
    IL_015D: ldc.i4.2
    IL_015E: ldarg.0
    IL_0163: ldfld 0x040003BC
    IL_0164: IL_59
    IL_0165: conv.i2
    IL_016A: call 0x0A000008
    IL_016B: IL_22
    IL_016C: nop
    IL_016D: nop
    IL_016E: nop
    IL_016F: IL_3F
    IL_0174: call 0x0A000008
    IL_0179: call 0x0A000029
    IL_017E: stfld 0x04000400
    IL_017F: ldarg.0
    IL_0184: ldflda 0x04000400
    IL_0185: ldc.i4.1
    IL_0186: IL_22
    IL_0187: nop
    IL_0188: nop
    IL_018D: stsfld 0x001A28BF
    IL_018E: nop
    IL_018F: stloc.0
    IL_0190: ldarg.0
    IL_0195: ldfld 0x040003FA
    IL_0196: ldc.i4.3
    IL_0197: ldarg.0
    IL_019C: ldfld 0x040003BC
    IL_019D: IL_59
    IL_019E: ldelem.i
    IL_019F: ldnull
    IL_01A4: call 0x0A000061
    IL_01A9: brfalse IL_020E
    IL_01AA: ldarg.0
    IL_01AF: ldfld 0x040003FA
    IL_01B0: ldc.i4.3
    IL_01B1: ldarg.0
    IL_01B6: ldfld 0x040003BC
    IL_01B7: IL_59
    IL_01B8: ldarg.0
    IL_01BD: ldfld 0x040003D7
    IL_01BE: ldarg.0
    IL_01C3: ldfld 0x04000400
    IL_01C4: IL_22
    IL_01C5: nop
    IL_01C6: nop
    IL_01C7: nop
    IL_01C8: nop
    IL_01C9: ldc.i4.0
    IL_01CE: ldc.i4 360
    IL_01D3: call 0x0A000045
    IL_01D4: conv.i2
    IL_01D5: IL_22
    IL_01D6: nop
    IL_01D7: nop
    IL_01D8: nop
    IL_01D9: nop
    IL_01DE: call 0x0A000060
    IL_01E3: call 0x0A000014
    IL_01E4: conv.u4
    IL_01E5: ldarg.1
    IL_01E6: nop
    IL_01E7: nop
    IL_01E8: IL_01
    IL_01ED: stelem 0x03FA7B02
    IL_01EE: nop
    IL_01EF: ldarg.2
    IL_01F0: ldc.i4.3
    IL_01F1: ldarg.0
    IL_01F6: ldfld 0x040003BC
    IL_01F7: IL_59
    IL_01F8: ldelem.i
    IL_01F9: conv.r8
    IL_01FA: IL_3D
    IL_01FB: nop
    IL_01FC: nop
    IL_01FD: stloc.0
    IL_01FE: ldarg.0
    IL_0203: ldfld 0x040003B8
    IL_0204: conv.r8
    IL_0205: IL_84
    IL_0206: nop
    IL_0207: nop
    IL_0208: stloc.0
    IL_020D: br IL_0242
    IL_020E: ldarg.0
    IL_0213: ldfld 0x040003FA
    IL_0214: ldc.i4.3
    IL_0215: ldarg.0
    IL_021A: ldfld 0x040003BC
    IL_021B: IL_59
    IL_021C: ldelem.i
    IL_021D: ldarg.0
    IL_0222: ldfld 0x04000400
    IL_0223: conv.r8
    IL_0224: ldloc.3
    IL_0225: nop
    IL_0226: nop
    IL_0227: stloc.0
    IL_0228: ldarg.0
    IL_022D: ldfld 0x040003FA
    IL_022E: ldc.i4.3
    IL_022F: ldarg.0
    IL_0234: ldfld 0x040003BC
    IL_0235: IL_59
    IL_0236: ldelem.i
    IL_0237: conv.r8
    IL_0238: stloc.0
    IL_0239: nop
    IL_023A: nop
    IL_023B: stloc.0
    IL_023C: ldc.i4.1
    IL_023D: conv.r8
    IL_023E: stloc.1
    IL_023F: nop
    IL_0240: nop
    IL_0241: stloc.0
    IL_0242: ldarg.0
    IL_0247: ldfld 0x040003AF
    IL_0248: IL_22
    IL_0249: nop
    IL_024A: nop
    IL_024B: IL_C0
    IL_024C: IL_3F
    IL_024D: conv.r8
    IL_024E: IL_36
    IL_024F: IL_01
    IL_0250: nop
    IL_0251: ldloc.0
    IL_0256: br IL_066E
    IL_0257: ldarg.0
    IL_0258: ldc.i4.3
    IL_0259: ldarg.0
    IL_025E: ldfld 0x040003BC
    IL_025F: IL_59
    IL_0261: ldc.i4.s 45
    IL_0262: IL_5A
    IL_0263: conv.i2
    IL_0264: ldarg.0
    IL_0269: ldfld 0x040003E3
    IL_026A: conv.r8
    IL_026B: div.un
    IL_026C: nop
    IL_026D: nop
    IL_026E: stloc.0
    IL_026F: stloc.1
    IL_0271: ldloca.s 1
    IL_0276: ldfld 0x0A000023
    IL_0277: IL_59
    IL_0278: IL_22
    IL_0279: nop
    IL_027A: nop
    IL_027B: IL_B4
    IL_027C: IL_42
    IL_027D: IL_58
    IL_027E: IL_22
    IL_027F: IL_4D
    IL_0280: IL_F3
    IL_0281: len
    IL_0282: IL_3C
    IL_0283: IL_5A
    IL_0288: stfld 0x040003C3
    IL_0289: ldarg.0
    IL_028A: ldarg.0
    IL_028F: ldfld 0x040003E3
    IL_0290: conv.r8
    IL_0291: ldc.i4.2
    IL_0292: nop
    IL_0293: nop
    IL_0294: stloc.0
    IL_0295: IL_22
    IL_0296: ldelem.i
    IL_0297: IL_99
    IL_0298: IL_99
    IL_0299: IL_3E
    IL_029E: call 0x0A000062
    IL_02A3: call 0x0A0000C2
    IL_02A4: ldarg.0
    IL_02A9: ldfld 0x040003C3
    IL_02AE: call 0x0A0000CF
    IL_02B3: call 0x0A000008
    IL_02B8: call 0x0A000029
    IL_02B9: IL_22
    IL_02BA: ldelem.i
    IL_02BB: IL_99
    IL_02BC: IL_99
    IL_02BD: IL_3E
    IL_02C2: call 0x0A000042
    IL_02C7: call 0x0A0000C2
    IL_02C8: ldarg.0
    IL_02CD: ldfld 0x040003C3
    IL_02D2: call 0x0A0000EA
    IL_02D7: call 0x0A000008
    IL_02DC: call 0x0A000029
    IL_02E1: stfld 0x04000400
    IL_02E2: ldarg.0
    IL_02E7: ldflda 0x04000400
    IL_02E8: ldc.i4.1
    IL_02E9: IL_22
    IL_02EA: nop
    IL_02EB: nop
    IL_02F0: stsfld 0x001A28BF
    IL_02F1: nop
    IL_02F2: stloc.0
    IL_02F3: ldarg.0
    IL_02F8: ldfld 0x040003FE
    IL_02F9: ldarg.0
    IL_02FE: ldfld 0x040003BC
    IL_02FF: ldelem.i
    IL_0300: ldnull
    IL_0305: call 0x0A000061
    IL_030A: brfalse IL_03D1
    IL_030B: ldarg.0
    IL_0310: ldfld 0x040003FE
    IL_0311: ldarg.0
    IL_0316: ldfld 0x040003BC
    IL_0317: ldarg.0
    IL_031C: ldfld 0x040003FF
    IL_031D: conv.r8
    IL_031E: ldarg.3
    IL_031F: nop
    IL_0320: nop
    IL_0321: stloc.0
    IL_0322: ldarg.0
    IL_0327: ldfld 0x04000400
    IL_0328: IL_22
    IL_0329: nop
    IL_032A: nop
    IL_032B: nop
    IL_032C: nop
    IL_032D: ldc.i4.0
    IL_0332: ldc.i4 360
    IL_0337: call 0x0A000045
    IL_0338: conv.i2
    IL_0339: IL_22
    IL_033A: nop
    IL_033B: nop
    IL_033C: nop
    IL_033D: nop
    IL_0342: call 0x0A000060
    IL_0347: call 0x0A000014
    IL_0348: conv.u4
    IL_0349: ldarg.1
    IL_034A: nop
    IL_034B: nop
    IL_034C: IL_01
    IL_0351: stelem 0x03FE7B02
    IL_0352: nop
    IL_0353: ldarg.2
    IL_0354: ldarg.0
    IL_0359: ldfld 0x040003BC
    IL_035A: ldelem.i
    IL_035F: call 0x0A00004B
    IL_0364: call 0x0A000007
    IL_0365: IL_22
    IL_0366: IL_CD
    IL_0367: IL_CC
    IL_0368: IL_CC
    IL_0369: IL_BD
    IL_036A: IL_22
    IL_036B: nop
    IL_036C: nop
    IL_036D: nop
    IL_036E: IL_3F
    IL_0373: call 0x0A000075
    IL_0378: call 0x0A000008
    IL_037D: call 0x0A000029
    IL_037E: conv.r8
    IL_037F: IL_AF
    IL_0380: nop
    IL_0381: nop
    IL_0382: stloc.0
    IL_0383: ldarg.0
    IL_0388: ldfld 0x040003FE
    IL_0389: ldarg.0
    IL_038E: ldfld 0x040003BC
    IL_038F: ldelem.i
    IL_0390: dup
    IL_0391: conv.r8
    IL_0396: cpobj 0x220A0000
    IL_0398: bne.un.s IL_03CC
    IL_039A: bne.un.s IL_03DA
    IL_039B: IL_22
    IL_039C: ldelem.i
    IL_039D: IL_99
    IL_039E: IL_99
    IL_039F: IL_3F
    IL_03A4: call 0x0A000075
    IL_03A9: call 0x0A000008
    IL_03AA: conv.r8
    IL_03AB: IL_AF
    IL_03AC: nop
    IL_03AD: nop
    IL_03AE: stloc.0
    IL_03AF: ldarg.0
    IL_03B4: ldfld 0x040003FE
    IL_03B5: ldarg.0
    IL_03BA: ldfld 0x040003BC
    IL_03BB: ldelem.i
    IL_03BC: conv.r8
    IL_03BD: IL_3D
    IL_03BE: nop
    IL_03BF: nop
    IL_03C0: stloc.0
    IL_03C1: ldarg.0
    IL_03C6: ldfld 0x040003B8
    IL_03C7: conv.r8
    IL_03C8: IL_84
    IL_03C9: nop
    IL_03CA: nop
    IL_03CB: stloc.0
    IL_03D0: br IL_0462
    IL_03D1: ldarg.0
    IL_03D6: ldfld 0x040003FE
    IL_03D7: ldarg.0
    IL_03DC: ldfld 0x040003BC
    IL_03DD: ldelem.i
    IL_03E2: call 0x0A00004B
    IL_03E7: call 0x0A000007
    IL_03E8: IL_22
    IL_03E9: IL_CD
    IL_03EA: IL_CC
    IL_03EB: IL_CC
    IL_03EC: IL_BD
    IL_03ED: IL_22
    IL_03EE: nop
    IL_03EF: nop
    IL_03F0: nop
    IL_03F1: IL_3F
    IL_03F6: call 0x0A000075
    IL_03FB: call 0x0A000008
    IL_0400: call 0x0A000029
    IL_0401: conv.r8
    IL_0402: IL_AF
    IL_0403: nop
    IL_0404: nop
    IL_0405: stloc.0
    IL_0406: ldarg.0
    IL_040B: ldfld 0x040003FE
    IL_040C: ldarg.0
    IL_0411: ldfld 0x040003BC
    IL_0412: ldelem.i
    IL_0413: dup
    IL_0414: conv.r8
    IL_0419: cpobj 0x220A0000
    IL_041B: bne.un.s IL_044F
    IL_041D: bne.un.s IL_045D
    IL_041E: IL_22
    IL_041F: ldelem.i
    IL_0420: IL_99
    IL_0421: IL_99
    IL_0422: IL_3F
    IL_0427: call 0x0A000075
    IL_042C: call 0x0A000008
    IL_042D: conv.r8
    IL_042E: IL_AF
    IL_042F: nop
    IL_0430: nop
    IL_0431: stloc.0
    IL_0432: ldarg.0
    IL_0437: ldfld 0x040003FE
    IL_0438: ldarg.0
    IL_043D: ldfld 0x040003BC
    IL_043E: ldelem.i
    IL_043F: ldarg.0
    IL_0444: ldfld 0x04000400
    IL_0445: conv.r8
    IL_0446: ldloc.3
    IL_0447: nop
    IL_0448: nop
    IL_0449: stloc.0
    IL_044A: ldarg.0
    IL_044F: ldfld 0x040003FE
    IL_0450: ldarg.0
    IL_0455: ldfld 0x040003BC
    IL_0456: ldelem.i
    IL_0457: conv.r8
    IL_0458: stloc.0
    IL_0459: nop
    IL_045A: nop
    IL_045B: stloc.0
    IL_045C: ldc.i4.1
    IL_045D: conv.r8
    IL_045E: stloc.1
    IL_045F: nop
    IL_0460: nop
    IL_0461: stloc.0
    IL_0466: br IL_066E
    IL_0467: ldarg.0
    IL_0468: ldarg.0
    IL_046D: ldfld 0x040003E3
    IL_046E: conv.r8
    IL_046F: ldc.i4.2
    IL_0470: nop
    IL_0471: nop
    IL_0472: stloc.0
    IL_0473: ldarg.0
    IL_0478: ldfld 0x040003E3
    IL_0479: conv.r8
    IL_047A: IL_22
    IL_047B: nop
    IL_047C: nop
    IL_047D: stloc.0
    IL_047E: IL_22
    IL_047F: IL_CD
    IL_0480: IL_CC
    IL_0481: IL_CC
    IL_0482: IL_3D
    IL_0483: IL_22
    IL_0484: IL_29
    IL_0485: sub
    IL_0487: ldarga.s 62
    IL_0488: ldc.i4.6
    IL_0489: ldarg.0
    IL_048E: ldfld 0x040003BC
    IL_048F: IL_59
    IL_0490: conv.i2
    IL_0491: IL_5A
    IL_0492: IL_58
    IL_0497: call 0x0A000008
    IL_049C: call 0x0A000029
    IL_049D: ldarg.0
    IL_04A2: ldfld 0x040003E3
    IL_04A3: conv.r8
    IL_04A4: mul
    IL_04A5: nop
    IL_04A6: nop
    IL_04A7: stloc.0
    IL_04A8: IL_22
    IL_04A9: IL_CD
    IL_04AA: IL_CC
    IL_04AB: IL_CC
    IL_04AC: IL_BD
    IL_04AD: IL_22
    IL_04AE: IL_CD
    IL_04AF: IL_CC
    IL_04B0: IL_CC
    IL_04B1: IL_3D
    IL_04B6: call 0x0A000075
    IL_04BB: call 0x0A000008
    IL_04C0: call 0x0A000029
    IL_04C5: stfld 0x04000400
    IL_04C6: ldarg.0
    IL_04CB: ldflda 0x04000400
    IL_04CC: ldc.i4.1
    IL_04CD: IL_22
    IL_04CE: nop
    IL_04CF: nop
    IL_04D4: stsfld 0x001A28BF
    IL_04D5: nop
    IL_04D6: stloc.0
    IL_04D7: ldarg.0
    IL_04DC: ldfld 0x040003FE
    IL_04DD: ldarg.0
    IL_04E2: ldfld 0x040003BC
    IL_04E3: ldelem.i
    IL_04E4: ldnull
    IL_04E9: call 0x0A000061
    IL_04EE: brfalse IL_0554
    IL_04EF: ldarg.0
    IL_04F4: ldfld 0x040003FE
    IL_04F5: ldarg.0
    IL_04FA: ldfld 0x040003BC
    IL_04FB: ldarg.0
    IL_0500: ldfld 0x040003FF
    IL_0501: conv.r8
    IL_0502: ldarg.3
    IL_0503: nop
    IL_0504: nop
    IL_0505: stloc.0
    IL_0506: ldarg.0
    IL_050B: ldfld 0x04000400
    IL_050C: IL_22
    IL_050D: nop
    IL_050E: nop
    IL_050F: nop
    IL_0510: nop
    IL_0511: ldc.i4.0
    IL_0516: ldc.i4 360
    IL_051B: call 0x0A000045
    IL_051C: conv.i2
    IL_051D: IL_22
    IL_051E: nop
    IL_051F: nop
    IL_0520: nop
    IL_0521: nop
    IL_0526: call 0x0A000060
    IL_052B: call 0x0A000014
    IL_052C: conv.u4
    IL_052D: ldarg.1
    IL_052E: nop
    IL_052F: nop
    IL_0530: IL_01
    IL_0535: stelem 0x03FE7B02
    IL_0536: nop
    IL_0537: ldarg.2
    IL_0538: ldarg.0
    IL_053D: ldfld 0x040003BC
    IL_053E: ldelem.i
    IL_053F: conv.r8
    IL_0540: IL_3D
    IL_0541: nop
    IL_0542: nop
    IL_0543: stloc.0
    IL_0544: ldarg.0
    IL_0549: ldfld 0x040003B8
    IL_054A: conv.r8
    IL_054B: IL_84
    IL_054C: nop
    IL_054D: nop
    IL_054E: stloc.0
    IL_0553: br IL_0584
    IL_0554: ldarg.0
    IL_0559: ldfld 0x040003FE
    IL_055A: ldarg.0
    IL_055F: ldfld 0x040003BC
    IL_0560: ldelem.i
    IL_0561: ldarg.0
    IL_0566: ldfld 0x04000400
    IL_0567: conv.r8
    IL_0568: ldloc.3
    IL_0569: nop
    IL_056A: nop
    IL_056B: stloc.0
    IL_056C: ldarg.0
    IL_0571: ldfld 0x040003FE
    IL_0572: ldarg.0
    IL_0577: ldfld 0x040003BC
    IL_0578: ldelem.i
    IL_0579: conv.r8
    IL_057A: stloc.0
    IL_057B: nop
    IL_057C: nop
    IL_057D: stloc.0
    IL_057E: ldc.i4.1
    IL_057F: conv.r8
    IL_0580: stloc.1
    IL_0581: nop
    IL_0582: nop
    IL_0583: stloc.0
    IL_0588: br IL_066E
    IL_0589: ldarg.0
    IL_058E: ldfld 0x040003FE
    IL_058F: ldarg.0
    IL_0594: ldfld 0x040003BC
    IL_0595: ldelem.i
    IL_0596: ldnull
    IL_059B: call 0x0A000061
    IL_05A0: brfalse IL_0609
    IL_05A1: ldarg.0
    IL_05A6: ldfld 0x040003FE
    IL_05A7: ldarg.0
    IL_05AC: ldfld 0x040003BC
    IL_05AD: ldarg.0
    IL_05B2: ldfld 0x040003FF
    IL_05B3: conv.r8
    IL_05B4: ldarg.3
    IL_05B5: nop
    IL_05B6: nop
    IL_05B7: stloc.0
    IL_05B8: ldarg.0
    IL_05BD: ldfld 0x040003E3
    IL_05BE: conv.r8
    IL_05BF: ldc.i4.2
    IL_05C0: nop
    IL_05C1: nop
    IL_05C2: stloc.0
    IL_05C3: IL_22
    IL_05C4: nop
    IL_05C5: nop
    IL_05C6: nop
    IL_05C7: nop
    IL_05C8: ldarg.0
    IL_05CD: ldfld 0x040003BC
    IL_05CF: ldc.i4.s 60
    IL_05D0: IL_5A
    IL_05D1: conv.i2
    IL_05D2: IL_22
    IL_05D3: nop
    IL_05D4: nop
    IL_05D5: nop
    IL_05D6: nop
    IL_05DB: call 0x0A000060
    IL_05E0: call 0x0A000014
    IL_05E1: conv.u4
    IL_05E2: ldarg.1
    IL_05E3: nop
    IL_05E4: nop
    IL_05E5: IL_01
    IL_05EA: stelem 0x03FE7B02
    IL_05EB: nop
    IL_05EC: ldarg.2
    IL_05ED: ldarg.0
    IL_05F2: ldfld 0x040003BC
    IL_05F3: ldelem.i
    IL_05F4: conv.r8
    IL_05F5: IL_3D
    IL_05F6: nop
    IL_05F7: nop
    IL_05F8: stloc.0
    IL_05F9: ldarg.0
    IL_05FE: ldfld 0x040003B8
    IL_05FF: conv.r8
    IL_0600: IL_84
    IL_0601: nop
    IL_0602: nop
    IL_0603: stloc.0
    IL_0608: br IL_0669
    IL_0609: ldarg.0
    IL_060E: ldfld 0x040003FE
    IL_060F: ldarg.0
    IL_0614: ldfld 0x040003BC
    IL_0615: ldelem.i
    IL_0616: ldarg.0
    IL_061B: ldfld 0x040003E3
    IL_061C: conv.r8
    IL_061D: ldc.i4.2
    IL_061E: nop
    IL_061F: nop
    IL_0620: stloc.0
    IL_0621: conv.r8
    IL_0622: ldloc.3
    IL_0623: nop
    IL_0624: nop
    IL_0625: stloc.0
    IL_0626: ldarg.0
    IL_062B: ldfld 0x040003FE
    IL_062C: ldarg.0
    IL_0631: ldfld 0x040003BC
    IL_0632: ldelem.i
    IL_0633: IL_22
    IL_0634: nop
    IL_0635: nop
    IL_0636: nop
    IL_0637: nop
    IL_0638: ldarg.0
    IL_063D: ldfld 0x040003BC
    IL_063F: ldc.i4.s 60
    IL_0640: IL_5A
    IL_0641: conv.i2
    IL_0642: IL_22
    IL_0643: nop
    IL_0644: nop
    IL_0645: nop
    IL_0646: nop
    IL_064B: call 0x0A000060
    IL_064C: conv.r8
    IL_0651: call 0x020A0000
    IL_0656: ldfld 0x040003FE
    IL_0657: ldarg.0
    IL_065C: ldfld 0x040003BC
    IL_065D: ldelem.i
    IL_065E: conv.r8
    IL_065F: stloc.0
    IL_0660: nop
    IL_0661: nop
    IL_0662: stloc.0
    IL_0663: ldc.i4.1
    IL_0664: conv.r8
    IL_0665: stloc.1
    IL_0666: nop
    IL_0667: nop
    IL_0668: stloc.0
    IL_066D: br IL_066E
    IL_066E: ret
    }

    public void Pt_Off() {
    IL_0004: newobj 0x06000743
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x04001023
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x04001026
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_001A: stfld 0x04001027
    IL_001B: ldloc.0
    IL_001C: ret
    }

    public void BoomOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003CC
    IL_0006: conv.r8
    IL_0007: IL_3E
    IL_0008: nop
    IL_0009: nop
    IL_000B: br.s IL_000F
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040003E3
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.2
    IL_0018: conv.r8
    IL_0019: ldind.ref
    IL_001A: ldarg.0
    IL_001B: nop
    IL_001C: ldloc.0
    IL_001D: ret
    }

    public void ResetTimeScale() {
    IL_0004: newobj 0x06000749
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x0400102A
    IL_000D: ldloc.0
    IL_000E: ret
    }

    private void Sk_AttackUp() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003CA
    IL_0006: conv.r8
    IL_0007: IL_B0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.0
    IL_000C: conv.r8
    IL_000D: IL_B6
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040003B0
    IL_0017: conv.r8
    IL_0018: IL_95
    IL_0019: IL_01
    IL_001A: nop
    IL_001B: ldloc.0
    IL_001C: ret
    }

    public void BambooFin() {
    IL_0004: newobj 0x0600074F
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x0400102D
    IL_000D: ldloc.0
    IL_000E: ret
    }

    private void Sk_DefenceUp() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003E5
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A000050
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040003B0
    IL_0016: conv.r8
    IL_0017: IL_97
    IL_0018: IL_01
    IL_0019: nop
    IL_001A: ldloc.0
    IL_001B: ret
    }

    public void Sk_SwordDance() {
    IL_0004: newobj 0x06000755
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001031
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void Sk_Mirage() {
    IL_0004: newobj 0x0600075B
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001034
    IL_000D: ldloc.0
    IL_000E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003B5
    IL_0006: ldc.i4.m1
    IL_000B: beq IL_007B
    IL_000C: ldarg.0
    IL_000D: dup
    IL_0012: ldfld 0x040003B6
    IL_0017: call 0x0A000024
    IL_0018: IL_58
    IL_001D: stfld 0x040003B6
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040003B6
    IL_0024: IL_22
    IL_0025: IL_EC
    IL_0026: IL_51
    IL_002B: br IL_4D436A
    IL_002C: nop
    IL_002D: nop
    IL_002E: ldarg.0
    IL_0033: call 0x0A00003D
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: ldelem.r8
    IL_479F8: switch (73327 cases)
    }

    }}
