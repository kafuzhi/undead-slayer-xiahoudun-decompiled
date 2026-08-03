// Namespace: 
// Type: Cha_Control

    public class Cha_Control {{

    private object rotate;
    private object directionVector;
    private object tempdir;
    private object attackVector;
    private object chapos;
    private object arrowpos;
    private object magnitude_attackdir;
    private object combotime;
    private object speedfactor;
    private object dubbleclick;
    private object curruntattack;
    private object currentPet;
    private object autorate;
    private object attack_horse;
    private object attack_eagle;
    private object damage;
    private object special_kind;
    private object special_kind_origin;
    private object special_amount;
    private object guard_break;
    private object battlestyle;
    private object isplaycha;
    private object storyrun;
    private object exstart;
    private object grabstart;
    private object dunenter;
    private object pressdelay;
    private object fogdelay;
    private object expboost;
    private object itemboolst;
    public object screen_effect;
    public object rideon;
    public object chamovestat;
    public object maxatk;
    public object defence;
    public object hitrate;
    public object vitality;
    public object evasion;
    public object minatk;
    public object endurance;
    public object critical;
    public object resist;
    public object atk;
    private object hp;
    private object cha_hp;
    private object cha_maxhp;
    private object maxhp;
    public object g_hp;
    private object g_maxhp;
    private object general_kind;
    private object general_weapon;
    public object g_atk;
    private object g_def;
    private object g_atkspd;
    public object sp;
    private object atkspd;
    private object atkspd_origin;
    private object grabheal_factor;
    private object origin_maxattack;
    private object origin_minattack;
    private object origin_hitrate;
    private object origin_defence;
    private object origin_endurance;
    private object hpplus;
    private object cur_weapon;
    public object maxsp;
    public object shadow;
    public object ef_arrow_multy;
    public object ef_arrow_single;
    public object pt_heal;
    public object pt_rising;
    public object ef_riseattack;
    public object ef_swordExtreme;
    public object ef_linehit;
    private object weaponweight;
    private object movespeed;
    private object movespeed_origin;
    private object longdash;
    private object restrictArea;
    public object limit_x;
    public object limit_y_b;
    public object limit_y_f;
    public object level;
    public object exp;
    public object yell;
    public object skillyell;
    private object g_yell;
    private object g_skillyell;
    public object footstep;
    public object snd_getitem;
    public object boom;
    public object snd_dodge;
    public object snd_swing;
    public object snd_skillstart;
    public object snd_riseattack;
    public object guicam;
    private object ef_swing1;
    private object ef_swing2;
    private object ef_swingex1;
    private object ef_swingex2;
    private object myaudio;
    private object mapcollider;
    private object general;
    public object dummy_weapon;
    public object ef_blur;
    public object txtef;
    public object ef_block;
    public object ef_blockbreak;
    public object dummy_general;
    public object ef_punch;
    public object ef_firesplash;
    public object guide_circle;
    public object ef_super;
    public object magicspear;
    private object script_weapon;
    private object script_cam;
    private object script_spawn;
    private object script_punch;
    private object script_txtef;
    private object script_swing;
    private object script_swing_sub;
    private object script_swingex1;
    private object script_swingex2;
    private object script_getitem;
    private object script_skill;
    private object script_thrust;
    private object script_splash;
    private object script_rotfog;
    private object script_eagle;
    private object script_horse;
    private object script_sound;
    private object script_ui;
    private object script_ui_story;
    private object isinvincibility;
    private object delay_invincibility;
    private object target_invincibility;
    private object grab_ing;
    private object pet_ing;
    private object skill_ing;
    private object commendDelay;
    private object helper;
    private object story_scene;
    private object change_cha;
    private object extremeStageHeal;
    public object pet_eagle;
    public object pet_horse;
    private object nowstep;
    private object nowthrust;
    public object ef_splash;
    public object ef_stepfog;
    public object ef_thrustfog;
    public object ef_rotfog;
    private object c_stepfog;
    private object c_thrustfog;
    private object bip01;
    private object targetenemy;
    private object mytransform;
    private object currentTouchPos;
    private object prevPoint;
    private object targetpos;
    private object collider_center;
    private object collider_dodge;
    private object collider_fly;
    private object collider_horse;
    private object collider_radius;
    private object myrigidbody;
    private object mycollider;
    private object clone_ride;
    private object grabfinish;
    private object impact;
    private object tempani;
    private object temp_fly;
    private object temp_attack;
    private object myanimation;
    private object casthit;
    private object ray;
    private object attackDot;
    private object magnitude_temp;
    private object spplus_amount;
    private object keydown;
    private object savetouchposition;
    private object skillicondown;
    public object life;
    private object noeagle;
    public object exattack;
    public object weapon_kind;
    private object attackkind_factor;
    public object attack_rising;
    private object infinitymode;
    public object attack_blade;
    public object attack_dual;
    public object attack_spear;
    public object attack_bow;
    public object attack_staff;
    public object attack_magic;
    private object skillboost;
    private object cur_difficulty;
    private object current_costume;
    private object accessory;
    private object selequip_grade;
    private object selequip_special;
    private object selequip_hp;
    private object superMode;

    public Cha_Control() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_E0
    IL_A91FD: switch (173181 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00002A
    IL_000B: stfld 0x04000349
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000002
    IL_0017: stfld 0x04000338
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A00003D
    IL_0023: stfld 0x04000341
    IL_0024: ldarg.0
    IL_0025: ldarg.0
    IL_002A: call 0x0A000003
    IL_002B: conv.u8
    IL_002C: IL_35
    IL_002D: nop
    IL_002E: nop
    IL_002F: IL_01
    IL_0034: stfld 0x04000342
    IL_0035: ldarg.0
    IL_0036: ldarg.0
    IL_003B: call 0x0A00002B
    IL_0040: stfld 0x04000300
    IL_0041: ldarg.0
    IL_0046: ldstr 0x70000DB9
    IL_004B: call 0x06000220
    IL_0050: stfld 0x040002DC
    IL_0055: ldstr 0x70000BDB
    IL_005A: call 0x06000220
    IL_005B: stloc.0
    IL_0060: call 0x0A0000EB
    IL_0065: ldstr 0x70000DC1
    IL_006A: call 0x0A0000EC
    IL_006F: brfalse IL_0077
    IL_0070: ldarg.0
    IL_0071: ldc.i4.1
    IL_0076: stfld 0x04000329
    IL_0077: ldloc.0
    IL_0078: ldc.i4.7
    IL_0115: switch (38 cases)
    IL_0116: nop
    IL_0117: ldloc.0
    IL_0118: ldarg.0
    IL_011D: ldstr 0x70000DCD
    IL_0122: call 0x060003F9
    IL_0127: stfld 0x04000362
    IL_0128: ldarg.0
    IL_012D: ldstr 0x70000DD5
    IL_0132: call 0x06000220
    IL_0137: stfld 0x04000361
    IL_0138: ldarg.0
    IL_013D: ldstr 0x70000DDD
    IL_0142: call 0x06000220
    IL_0147: stfld 0x040002EE
    IL_0148: ldarg.0
    IL_014D: ldstr 0x70000DE5
    IL_0152: call 0x06000220
    IL_0153: conv.i2
    IL_0158: stfld 0x040002EF
    IL_0159: ldarg.0
    IL_015E: ldstr 0x70000DED
    IL_0163: call 0x06000220
    IL_0168: stfld 0x040002BD
    IL_0169: ldarg.0
    IL_016A: ldarg.0
    IL_016F: ldfld 0x040002BD
    IL_0170: conv.i2
    IL_0175: stfld 0x0400035F
    IL_0176: ldarg.0
    IL_017B: ldstr 0x70000DF5
    IL_0180: call 0x06000220
    IL_0185: stfld 0x040002C2
    IL_0186: ldarg.0
    IL_018B: ldstr 0x70000DFD
    IL_0190: call 0x06000220
    IL_0191: conv.i2
    IL_0192: IL_22
    IL_0193: stloc.0
    IL_0194: IL_D7
    IL_0195: IL_23
    IL_0196: IL_3C
    IL_0197: IL_5A
    IL_019C: stfld 0x040002D3
    IL_019D: ldarg.0
    IL_01A2: ldstr 0x70000E05
    IL_01A7: call 0x06000220
    IL_01AC: stfld 0x040002DB
    IL_01AD: ldarg.0
    IL_01B2: ldstr 0x70000E0D
    IL_01B7: call 0x06000220
    IL_01BC: stfld 0x040002BF
    IL_01BD: ldarg.0
    IL_01C2: ldstr 0x70000E15
    IL_01C7: call 0x06000220
    IL_01CC: stfld 0x040002C0
    IL_01CD: ldarg.0
    IL_01D2: ldstr 0x70000E1D
    IL_01D7: call 0x06000220
    IL_01DC: stfld 0x040002C1
    IL_01DD: ldarg.0
    IL_01E2: ldstr 0x70000E25
    IL_01E7: call 0x06000220
    IL_01EC: stfld 0x040002C3
    IL_01ED: ldarg.0
    IL_01F2: ldstr 0x70000E2D
    IL_01F7: call 0x06000220
    IL_01FC: stfld 0x040002C4
    IL_01FD: ldarg.0
    IL_01FE: ldarg.0
    IL_0203: ldfld 0x040002C0
    IL_0204: conv.i2
    IL_0209: stfld 0x040002DD
    IL_020A: ldarg.0
    IL_020F: call 0x0A000035
    IL_0210: conv.r8
    IL_0211: ldloc.0
    IL_0212: nop
    IL_0213: nop
    IL_0215: br.s IL_0293
    IL_0217: ldarga.s 3
    IL_0218: nop
    IL_0219: ldarg.2
    IL_021A: ldarg.0
    IL_021F: ldstr 0x70000063
    IL_0224: call 0x0A000004
    IL_0225: conv.r8
    IL_0226: ldarg.0
    IL_0227: nop
    IL_0228: nop
    IL_022A: br.s IL_02A8
    IL_022C: starg.s 3
    IL_022D: nop
    IL_022E: ldarg.2
    IL_022F: ldarg.0
    IL_0234: ldfld 0x04000329
    IL_0239: brtrue IL_030E
    IL_023A: ldarg.0
    IL_023F: ldstr 0x70000BD5
    IL_0244: call 0x0A000004
    IL_0245: conv.r8
    IL_024E: ldc.i8 288233809930551296
    IL_024F: ldarg.0
    IL_0254: ldfld 0x04000362
    IL_0255: ldc.i4.0
    IL_0256: IL_94
    IL_0257: ldc.i4.0
    IL_0258: IL_3E
    IL_025D: call 0x02000000
    IL_025E: ldarg.0
    IL_0263: ldfld 0x040002BD
    IL_0264: conv.i2
    IL_0265: IL_22
    IL_0266: IL_CD
    IL_0267: IL_CC
    IL_026C: newobj 0x7D695A3F
    IL_026D: IL_BD
    IL_026E: ldarg.0
    IL_026F: nop
    IL_0270: ldarg.2
    IL_0271: ldarg.0
    IL_0272: ldarg.0
    IL_0277: ldfld 0x040002C2
    IL_0278: conv.i2
    IL_0279: IL_22
    IL_027A: IL_CD
    IL_027B: IL_CC
    IL_0280: newobj 0x7D695A3F
    IL_0281: IL_C2
    IL_0282: ldarg.0
    IL_0283: nop
    IL_0284: ldarg.2
    IL_0285: ldarg.0
    IL_028A: ldfld 0x04000362
    IL_028B: ldc.i4.1
    IL_028C: IL_94
    IL_028D: ldc.i4.0
    IL_028E: IL_3E
    IL_028F: ldnull
    IL_0290: nop
    IL_0291: nop
    IL_0292: nop
    IL_0293: ldarg.0
    IL_0294: ldarg.0
    IL_0299: ldfld 0x040002BE
    IL_029A: conv.i2
    IL_029B: IL_22
    IL_029C: ldelem.i
    IL_029D: IL_99
    IL_029E: IL_99
    IL_029F: IL_3F
    IL_02A0: IL_5A
    IL_02A1: not
    IL_02A6: stfld 0x040002BE
    IL_02A7: ldarg.0
    IL_02AC: ldfld 0x04000362
    IL_02AD: ldc.i4.2
    IL_02AE: IL_94
    IL_02AF: ldc.i4.0
    IL_02B0: IL_3E
    IL_02B1: stloc.1
    IL_02B2: nop
    IL_02B3: nop
    IL_02B4: nop
    IL_02B5: ldarg.0
    IL_02BA: ldfld 0x0400031F
    IL_02BB: conv.r8
    IL_02BC: stloc.3
    IL_02BD: ldloc.0
    IL_02BE: nop
    IL_02BF: ldloc.0
    IL_02C0: ldarg.0
    IL_02C5: ldfld 0x04000362
    IL_02C6: ldc.i4.4
    IL_02C7: IL_94
    IL_02C8: ldc.i4.0
    IL_02C9: IL_3E
    IL_02CB: starg.s 0
    IL_02CC: nop
    IL_02CD: nop
    IL_02CE: ldarg.0
    IL_02CF: IL_22
    IL_02D0: ldelem.i
    IL_02D1: IL_99
    IL_02D2: IL_99
    IL_02D3: IL_3F
    IL_02D8: stfld 0x0400034E
    IL_02DD: br IL_02E9
    IL_02DE: ldarg.0
    IL_02DF: IL_22
    IL_02E0: nop
    IL_02E1: nop
    IL_02E6: stsfld 0x034E7D3F
    IL_02E7: nop
    IL_02E8: ldarg.2
    IL_02E9: ldarg.0
    IL_02EE: ldfld 0x04000362
    IL_02EF: ldc.i4.5
    IL_02F0: IL_94
    IL_02F1: ldc.i4.0
    IL_02F2: IL_3E
    IL_02F4: ldloca.s 0
    IL_02F5: nop
    IL_02F6: nop
    IL_02F7: ldarg.0
    IL_02F8: dup
    IL_02FD: ldfld 0x040002D3
    IL_02FE: IL_22
    IL_02FF: stloc.0
    IL_0300: IL_D7
    IL_0301: stelem.i
    IL_0302: IL_3C
    IL_0303: IL_58
    IL_0308: stfld 0x040002D3
    IL_030D: br IL_033A
    IL_030E: ldarg.0
    IL_0313: ldstr 0x70000BD5
    IL_0318: call 0x0A000004
    IL_0319: conv.r8
    IL_031A: dup
    IL_031B: nop
    IL_031C: nop
    IL_031E: br.s IL_039C
    IL_0323: ldc.i4 33816579
    IL_0328: ldfld 0x0400030F
    IL_0329: ldc.i4.1
    IL_032A: conv.r8
    IL_032C: bgt.s IL_032E
    IL_032D: nop
    IL_032E: ldloc.0
    IL_032F: ldarg.0
    IL_0334: ldfld 0x0400030F
    IL_0335: conv.r8
    IL_0337: bge.s IL_0339
    IL_0338: nop
    IL_0339: ldloc.0
    IL_033A: ldarg.0
    IL_033B: ldarg.0
    IL_0340: ldfld 0x040002BD
    IL_0345: stfld 0x040002D6
    IL_0346: ldarg.0
    IL_0347: ldarg.0
    IL_034C: ldfld 0x040002C2
    IL_0351: stfld 0x040002D7
    IL_0352: ldarg.0
    IL_0353: ldarg.0
    IL_0358: ldfld 0x040002BF
    IL_035D: stfld 0x040002D8
    IL_035E: ldarg.0
    IL_035F: ldarg.0
    IL_0364: ldfld 0x040002BE
    IL_0369: stfld 0x040002D9
    IL_036A: ldarg.0
    IL_036B: ldarg.0
    IL_0370: ldfld 0x040002C3
    IL_0375: stfld 0x040002DA
    IL_0376: ldarg.0
    IL_0377: ldarg.0
    IL_037C: ldfld 0x040002D3
    IL_0381: stfld 0x040002D4
    IL_0382: ldarg.0
    IL_0383: ldarg.0
    IL_0388: ldfld 0x04000338
    IL_038D: ldstr 0x70000E35
    IL_038E: conv.r8
    IL_0390: brfalse.s IL_0391
    IL_0391: nop
    IL_0392: stloc.0
    IL_0397: stfld 0x040002FC
    IL_0398: ldarg.0
    IL_0399: ldarg.0
    IL_039E: ldfld 0x04000338
    IL_03A3: ldstr 0x70000E49
    IL_03A4: conv.r8
    IL_03A6: brfalse.s IL_03A7
    IL_03A7: nop
    IL_03A8: stloc.0
    IL_03AD: stfld 0x040002FD
    IL_03AE: ldarg.0
    IL_03AF: ldarg.0
    IL_03B4: ldfld 0x04000338
    IL_03B9: ldstr 0x70000E5D
    IL_03BA: conv.r8
    IL_03BC: brfalse.s IL_03BD
    IL_03BD: nop
    IL_03BE: stloc.0
    IL_03C3: stfld 0x040002FE
    IL_03C4: ldarg.0
    IL_03C5: ldarg.0
    IL_03CA: ldfld 0x04000338
    IL_03CF: ldstr 0x70000E77
    IL_03D0: conv.r8
    IL_03D2: brfalse.s IL_03D3
    IL_03D3: nop
    IL_03D4: stloc.0
    IL_03D9: stfld 0x040002FF
    IL_03DA: ldarg.0
    IL_03DF: ldstr 0x70000E91
    IL_03E4: call 0x0A000077
    IL_03E5: conv.r8
    IL_03E6: IL_FF
    IL_03E7: nop
    IL_03E8: nop
    IL_03E9: stloc.0
    IL_03EE: stfld 0x04000301
    IL_03EF: ldarg.0
    IL_03F0: ldarg.0
    IL_03F5: ldfld 0x04000303
    IL_03F6: conv.r8
    IL_03F7: pop
    IL_03F8: nop
    IL_03F9: nop
    IL_03FB: br.s IL_0479
    IL_03FD: ldarg.s 3
    IL_03FE: nop
    IL_03FF: ldarg.2
    IL_0400: ldarg.0
    IL_0401: ldarg.0
    IL_0406: ldfld 0x040002FC
    IL_0407: conv.r8
    IL_0408: ldc.i4.1
    IL_0409: nop
    IL_040A: nop
    IL_040C: br.s IL_048A
    IL_040E: stloc.s 3
    IL_040F: nop
    IL_0410: ldarg.2
    IL_0411: ldarg.0
    IL_0412: ldarg.0
    IL_0417: ldfld 0x040002FD
    IL_0418: conv.r8
    IL_0419: ldc.i4.1
    IL_041A: nop
    IL_041B: nop
    IL_041D: br.s IL_049B
    IL_041E: ldnull
    IL_041F: ldarg.1
    IL_0420: nop
    IL_0421: ldarg.2
    IL_0422: ldarg.0
    IL_0423: ldarg.0
    IL_0428: ldfld 0x04000338
    IL_042D: ldstr 0x70000E9F
    IL_042E: conv.r8
    IL_0430: brfalse.s IL_0431
    IL_0431: nop
    IL_0432: stloc.0
    IL_0433: conv.r8
    IL_0434: ldc.i4.1
    IL_0435: nop
    IL_0436: nop
    IL_0438: br.s IL_04B6
    IL_0439: ldc.i4.3
    IL_043A: ldarg.1
    IL_043B: nop
    IL_043C: ldarg.2
    IL_043D: ldarg.0
    IL_043E: ldarg.0
    IL_0443: ldfld 0x040002FE
    IL_0444: conv.r8
    IL_0445: ldc.i4.1
    IL_0446: nop
    IL_0447: nop
    IL_0449: br.s IL_04C7
    IL_044A: ldc.i4.m1
    IL_044B: ldarg.1
    IL_044C: nop
    IL_044D: ldarg.2
    IL_044E: ldarg.0
    IL_044F: ldarg.0
    IL_0454: ldfld 0x040002FF
    IL_0455: conv.r8
    IL_0456: ldc.i4.1
    IL_0457: nop
    IL_0458: nop
    IL_045A: br.s IL_04D8
    IL_045B: ldc.i4.0
    IL_045C: ldarg.1
    IL_045D: nop
    IL_045E: ldarg.2
    IL_045F: ldarg.0
    IL_0460: ldarg.0
    IL_0465: call 0x2B00001D
    IL_046A: stfld 0x04000318
    IL_046B: ldarg.0
    IL_046C: ldarg.0
    IL_0471: ldfld 0x04000309
    IL_0472: conv.r8
    IL_0473: IL_27
    IL_0474: nop
    IL_0475: nop
    IL_0477: br.s IL_04F5
    IL_0479: ldloc.s 3
    IL_047A: nop
    IL_047B: ldarg.2
    IL_047C: ldarg.0
    IL_047D: ldarg.0
    IL_0482: ldfld 0x04000338
    IL_0487: ldstr 0x70000EB3
    IL_0488: conv.r8
    IL_048A: brfalse.s IL_048B
    IL_048B: nop
    IL_048C: stloc.0
    IL_048D: conv.r8
    IL_0492: call 0x7D2B0000
    IL_0493: ldc.i4.1
    IL_0494: ldarg.1
    IL_0495: nop
    IL_0496: ldarg.2
    IL_0497: ldarg.0
    IL_0498: ldarg.0
    IL_049D: ldfld 0x04000330
    IL_049E: conv.r8
    IL_049F: IL_29
    IL_04A0: nop
    IL_04A1: nop
    IL_04A3: br.s IL_0521
    IL_04A4: ldc.i4.4
    IL_04A5: ldarg.1
    IL_04A6: nop
    IL_04A7: ldarg.2
    IL_04A8: ldarg.0
    IL_04A9: ldarg.0
    IL_04AE: ldfld 0x04000333
    IL_04AF: conv.r8
    IL_04B0: ret
    IL_04B1: nop
    IL_04B2: nop
    IL_04B4: br.s IL_0532
    IL_04B5: ldc.i4.5
    IL_04B6: ldarg.1
    IL_04B7: nop
    IL_04B8: ldarg.2
    IL_04B9: ldarg.0
    IL_04BA: ldarg.0
    IL_04BF: ldfld 0x0400032C
    IL_04C0: conv.r8
    IL_04C2: br.s IL_04C3
    IL_04C3: nop
    IL_04C5: br.s IL_0543
    IL_04C6: ldc.i4.6
    IL_04C7: ldarg.1
    IL_04C8: nop
    IL_04C9: ldarg.2
    IL_04CA: ldarg.0
    IL_04CB: ldarg.0
    IL_04D0: ldfld 0x0400032D
    IL_04D1: conv.r8
    IL_04D3: brfalse.s IL_04D4
    IL_04D4: nop
    IL_04D6: br.s IL_0554
    IL_04D7: ldc.i4.7
    IL_04D8: ldarg.1
    IL_04D9: nop
    IL_04DA: ldarg.2
    IL_04DB: ldarg.0
    IL_04E0: ldstr 0x70000121
    IL_04E5: call 0x0A000004
    IL_04E6: conv.r8
    IL_04E7: ldarg.3
    IL_04E8: nop
    IL_04E9: nop
    IL_04EB: br.s IL_0569
    IL_04EC: ldc.i4.8
    IL_04ED: ldarg.1
    IL_04EE: nop
    IL_04EF: ldarg.2
    IL_04F0: ldarg.0
    IL_04F2: ldc.i4.s 95
    IL_04F3: ldarg.0
    IL_04F8: ldfld 0x040002EE
    IL_04F9: ldc.i4.5
    IL_04FA: IL_5A
    IL_04FB: IL_58
    IL_0500: stfld 0x040002C9
    IL_0501: ldarg.0
    IL_0502: dup
    IL_0507: ldfld 0x040002C9
    IL_0508: ldarg.0
    IL_050D: ldfld 0x040002DB
    IL_050E: IL_58
    IL_0513: stfld 0x040002C9
    IL_0514: ldarg.0
    IL_0515: ldarg.0
    IL_051A: ldfld 0x040002C9
    IL_051F: stfld 0x040002CA
    IL_0520: ldarg.0
    IL_0521: ldarg.0
    IL_0526: ldfld 0x040002CA
    IL_052B: stfld 0x040002C7
    IL_052C: ldarg.0
    IL_052D: ldarg.0
    IL_0532: ldfld 0x040002C7
    IL_0537: stfld 0x040002C8
    IL_0538: ldarg.0
    IL_0539: ldarg.0
    IL_053E: ldfld 0x040002DD
    IL_0543: stfld 0x040002D2
    IL_0544: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000318
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000303
    IL_000C: conv.r8
    IL_000D: IL_D2
    IL_000E: IL_01
    IL_000F: nop
    IL_0010: ldloc.0
    IL_0011: ldarg.0
    IL_0016: ldstr 0x70000EC9
    IL_001B: call 0x06000220
    IL_0020: stfld 0x04000354
    IL_0021: ldc.i4.0
    IL_0022: stloc.0
    IL_0027: br IL_0095
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000334
    IL_002E: ldloc.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000331
    IL_0039: call 0x0A00004B
    IL_003A: IL_22
    IL_003B: nop
    IL_003C: nop
    IL_0041: stsfld 0x00082840
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldarg.0
    IL_0049: call 0x0A000002
    IL_004A: conv.r8
    IL_004B: IL_44
    IL_004C: nop
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: conv.r8
    IL_0050: pop
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0058: call 0x0A000014
    IL_0059: conv.u4
    IL_005A: ldarg.1
    IL_005B: nop
    IL_005C: nop
    IL_005D: IL_01
    IL_0062: stelem 0x03357B02
    IL_0063: nop
    IL_0064: ldarg.2
    IL_0065: ldloc.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000332
    IL_0070: call 0x0A00004B
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0078: stsfld 0x00082840
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldarg.0
    IL_0080: ldfld 0x04000332
    IL_0081: conv.r8
    IL_0082: ldloc.1
    IL_0083: IL_01
    IL_0084: nop
    IL_0085: stloc.0
    IL_008A: call 0x0A000014
    IL_008B: conv.u4
    IL_008C: ldarg.1
    IL_008D: nop
    IL_008E: nop
    IL_008F: IL_01
    IL_0094: stelem 0x0A581706
    IL_0095: ldloc.0
    IL_0096: ldc.i4.3
    IL_0097: IL_3F
    IL_009C: newobj 0x02FFFFFF
    IL_00A1: call 0x0A00001B
    IL_00A6: stfld 0x0400029D
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000349
    IL_00B1: ldstr 0x70000EDB
    IL_00B2: conv.r8
    IL_00B4: bge.s IL_00B5
    IL_00B5: nop
    IL_00B6: stloc.0
    IL_00B7: ldc.i4.8
    IL_00B8: conv.r8
    IL_00BD: ldstr 0x020A0000
    IL_00C2: ldfld 0x04000349
    IL_00C7: ldstr 0x70000EE5
    IL_00C8: conv.r8
    IL_00CA: bge.s IL_00CB
    IL_00CB: nop
    IL_00CC: stloc.0
    IL_00CD: ldc.i4.8
    IL_00CE: conv.r8
    IL_00D3: ldstr 0x020A0000
    IL_00D8: ldfld 0x04000349
    IL_00DD: ldstr 0x70000EF1
    IL_00DE: conv.r8
    IL_00E0: bge.s IL_00E1
    IL_00E1: nop
    IL_00E2: stloc.0
    IL_00E3: ldc.i4.8
    IL_00E4: conv.r8
    IL_00E9: ldstr 0x020A0000
    IL_00EE: ldfld 0x04000349
    IL_00F3: ldstr 0x70000EFD
    IL_00F4: conv.r8
    IL_00F6: bge.s IL_00F7
    IL_00F7: nop
    IL_00F8: stloc.0
    IL_00F9: ldc.i4.8
    IL_00FA: conv.r8
    IL_00FF: ldstr 0x020A0000
    IL_0104: ldfld 0x04000349
    IL_0109: ldstr 0x70000F09
    IL_010A: conv.r8
    IL_010C: bge.s IL_010D
    IL_010D: nop
    IL_010E: stloc.0
    IL_010F: ldc.i4.8
    IL_0110: conv.r8
    IL_0115: ldstr 0x020A0000
    IL_011A: ldfld 0x04000349
    IL_011F: ldstr 0x70000F15
    IL_0120: conv.r8
    IL_0122: bge.s IL_0123
    IL_0123: nop
    IL_0124: stloc.0
    IL_0125: IL_22
    IL_0126: IL_CD
    IL_0127: IL_CC
    IL_0128: IL_4C
    IL_0129: IL_3E
    IL_012A: conv.r8
    IL_012C: bgt.s IL_012D
    IL_012D: nop
    IL_012E: stloc.0
    IL_012F: ldarg.0
    IL_0134: ldfld 0x04000349
    IL_0139: ldstr 0x70000F2B
    IL_013A: conv.r8
    IL_013C: bge.s IL_013D
    IL_013D: nop
    IL_013E: stloc.0
    IL_013F: IL_22
    IL_0140: ldelem.i
    IL_0141: IL_99
    IL_0142: IL_99
    IL_0143: IL_3E
    IL_0144: conv.r8
    IL_0146: bgt.s IL_0147
    IL_0147: nop
    IL_0148: stloc.0
    IL_0149: ldarg.0
    IL_014E: ldfld 0x04000349
    IL_0153: ldstr 0x70000F3F
    IL_0154: conv.r8
    IL_0156: bge.s IL_0157
    IL_0157: nop
    IL_0158: stloc.0
    IL_0159: IL_22
    IL_015A: ldelem.i
    IL_015B: IL_99
    IL_015C: IL_99
    IL_015D: IL_3E
    IL_015E: conv.r8
    IL_0160: bgt.s IL_0161
    IL_0161: nop
    IL_0162: stloc.0
    IL_0163: ldarg.0
    IL_0168: ldfld 0x04000349
    IL_016D: ldstr 0x70000F5B
    IL_016E: conv.r8
    IL_0170: bge.s IL_0171
    IL_0171: nop
    IL_0172: stloc.0
    IL_0173: IL_22
    IL_0174: IL_CD
    IL_0175: IL_CC
    IL_0176: IL_CC
    IL_0177: IL_3E
    IL_0178: conv.r8
    IL_017A: bgt.s IL_017B
    IL_017B: nop
    IL_017C: stloc.0
    IL_017D: ldarg.0
    IL_0182: ldfld 0x04000349
    IL_0187: ldstr 0x70000F67
    IL_0188: conv.r8
    IL_018A: bge.s IL_018B
    IL_018B: nop
    IL_018C: stloc.0
    IL_018D: IL_22
    IL_018E: ldelem.i
    IL_018F: IL_99
    IL_0190: IL_99
    IL_0191: IL_3E
    IL_0192: conv.r8
    IL_0194: bgt.s IL_0195
    IL_0195: nop
    IL_0196: stloc.0
    IL_0197: ldarg.0
    IL_019C: ldfld 0x04000349
    IL_01A1: ldstr 0x70000F7B
    IL_01A2: conv.r8
    IL_01A4: bge.s IL_01A5
    IL_01A5: nop
    IL_01A6: stloc.0
    IL_01A7: IL_22
    IL_01A8: nop
    IL_01A9: nop
    IL_01AE: stsfld 0x00306F3E
    IL_01AF: nop
    IL_01B0: stloc.0
    IL_01B1: ldarg.0
    IL_01B6: ldfld 0x04000349
    IL_01BB: ldstr 0x70000F89
    IL_01BC: conv.r8
    IL_01BE: bge.s IL_01BF
    IL_01BF: nop
    IL_01C0: stloc.0
    IL_01C1: IL_22
    IL_01C2: nop
    IL_01C3: nop
    IL_01C4: nop
    IL_01C5: IL_3F
    IL_01C6: conv.r8
    IL_01C8: bgt.s IL_01C9
    IL_01C9: nop
    IL_01CA: stloc.0
    IL_01CB: ldarg.0
    IL_01D0: ldfld 0x04000349
    IL_01D5: ldstr 0x70000FA5
    IL_01D6: conv.r8
    IL_01D8: bge.s IL_01D9
    IL_01D9: nop
    IL_01DA: stloc.0
    IL_01DB: IL_22
    IL_01DC: nop
    IL_01DD: nop
    IL_01E2: stsfld 0x00306F3E
    IL_01E3: nop
    IL_01E4: stloc.0
    IL_01E5: ldarg.0
    IL_01EA: ldfld 0x04000349
    IL_01EF: ldstr 0x70000FC3
    IL_01F0: conv.r8
    IL_01F2: bge.s IL_01F3
    IL_01F3: nop
    IL_01F4: stloc.0
    IL_01F5: IL_22
    IL_01F6: IL_29
    IL_01F7: sub
    IL_01F8: IL_8F
    IL_01F9: IL_3E
    IL_01FA: conv.r8
    IL_01FC: bgt.s IL_01FD
    IL_01FD: nop
    IL_01FE: stloc.0
    IL_01FF: ldarg.0
    IL_0204: ldfld 0x04000349
    IL_0209: ldstr 0x70000FD1
    IL_020A: conv.r8
    IL_020C: bge.s IL_020D
    IL_020D: nop
    IL_020E: stloc.0
    IL_020F: IL_22
    IL_0210: IL_29
    IL_0211: sub
    IL_0212: IL_8F
    IL_0213: IL_3E
    IL_0214: conv.r8
    IL_0216: bgt.s IL_0217
    IL_0217: nop
    IL_0218: stloc.0
    IL_0219: ldarg.0
    IL_021E: ldfld 0x04000349
    IL_0223: ldstr 0x70000FED
    IL_0224: conv.r8
    IL_0226: bge.s IL_0227
    IL_0227: nop
    IL_0228: stloc.0
    IL_0229: IL_22
    IL_022A: nop
    IL_022B: nop
    IL_0230: stsfld 0x00306F3E
    IL_0231: nop
    IL_0232: stloc.0
    IL_0233: ldarg.0
    IL_0238: ldfld 0x04000349
    IL_023D: ldstr 0x7000100B
    IL_023E: conv.r8
    IL_0240: bge.s IL_0241
    IL_0241: nop
    IL_0242: stloc.0
    IL_0243: IL_22
    IL_0244: IL_8F
    IL_0245: IL_C2
    IL_0246: conv.u8
    IL_0247: IL_3E
    IL_0248: conv.r8
    IL_024A: bgt.s IL_024B
    IL_024B: nop
    IL_024C: stloc.0
    IL_024D: ldarg.0
    IL_0252: ldfld 0x04000349
    IL_0257: ldstr 0x70001019
    IL_0258: conv.r8
    IL_025A: bge.s IL_025B
    IL_025B: nop
    IL_025C: stloc.0
    IL_025D: IL_22
    IL_025E: IL_29
    IL_025F: sub
    IL_0260: IL_8F
    IL_0261: IL_3E
    IL_0262: conv.r8
    IL_0264: bgt.s IL_0265
    IL_0265: nop
    IL_0266: stloc.0
    IL_0267: ldarg.0
    IL_026C: ldfld 0x04000349
    IL_0271: ldstr 0x70001035
    IL_0272: conv.r8
    IL_0274: bge.s IL_0275
    IL_0275: nop
    IL_0276: stloc.0
    IL_0277: IL_22
    IL_0278: nop
    IL_0279: nop
    IL_027E: stsfld 0x00306F3E
    IL_027F: nop
    IL_0280: stloc.0
    IL_0281: ldarg.0
    IL_0286: ldfld 0x04000349
    IL_028B: ldstr 0x70001053
    IL_028C: conv.r8
    IL_028E: bge.s IL_028F
    IL_028F: nop
    IL_0290: stloc.0
    IL_0291: IL_22
    IL_0293: bne.un.s IL_02C7
    IL_0294: conv.ovf.i4.un
    IL_0295: IL_3E
    IL_0296: conv.r8
    IL_0298: bgt.s IL_0299
    IL_0299: nop
    IL_029A: stloc.0
    IL_029B: ldarg.0
    IL_02A0: ldfld 0x04000349
    IL_02A5: ldstr 0x70001061
    IL_02A6: conv.r8
    IL_02A8: bge.s IL_02A9
    IL_02A9: nop
    IL_02AA: stloc.0
    IL_02AB: IL_22
    IL_02AC: nop
    IL_02AD: nop
    IL_02B2: stsfld 0x00306F3E
    IL_02B3: nop
    IL_02B4: stloc.0
    IL_02B5: ldarg.0
    IL_02BA: ldfld 0x04000349
    IL_02BF: ldstr 0x7000107D
    IL_02C0: conv.r8
    IL_02C2: bge.s IL_02C3
    IL_02C3: nop
    IL_02C4: stloc.0
    IL_02C5: IL_22
    IL_02C6: nop
    IL_02C7: nop
    IL_02CC: stsfld 0x00306F3E
    IL_02CD: nop
    IL_02CE: stloc.0
    IL_02CF: ldarg.0
    IL_02D4: ldfld 0x04000349
    IL_02D9: ldstr 0x7000109B
    IL_02DA: conv.r8
    IL_02DC: bge.s IL_02DD
    IL_02DD: nop
    IL_02DE: stloc.0
    IL_02DF: IL_22
    IL_02E0: IL_CD
    IL_02E1: IL_CC
    IL_02E2: IL_CC
    IL_02E3: IL_3E
    IL_02E4: conv.r8
    IL_02E6: bgt.s IL_02E7
    IL_02E7: nop
    IL_02E8: stloc.0
    IL_02E9: ldarg.0
    IL_02EE: ldfld 0x04000349
    IL_02F3: ldstr 0x700010A9
    IL_02F4: conv.r8
    IL_02F6: bge.s IL_02F7
    IL_02F7: nop
    IL_02F8: stloc.0
    IL_02F9: IL_22
    IL_02FA: nop
    IL_02FB: nop
    IL_0300: stsfld 0x00306F3E
    IL_0301: nop
    IL_0302: stloc.0
    IL_0303: ldarg.0
    IL_0308: ldfld 0x04000349
    IL_030D: ldstr 0x700010C5
    IL_030E: conv.r8
    IL_0310: bge.s IL_0311
    IL_0311: nop
    IL_0312: stloc.0
    IL_0313: IL_22
    IL_0314: IL_CD
    IL_0315: IL_CC
    IL_0316: IL_4C
    IL_0317: IL_3E
    IL_0318: conv.r8
    IL_031A: bgt.s IL_031B
    IL_031B: nop
    IL_031C: stloc.0
    IL_031D: ldarg.0
    IL_0322: ldfld 0x04000349
    IL_0327: ldstr 0x700010E3
    IL_0328: conv.r8
    IL_032A: bge.s IL_032B
    IL_032B: nop
    IL_032C: stloc.0
    IL_032D: IL_22
    IL_032E: IL_AE
    IL_0331: starg 15969
    IL_0332: conv.r8
    IL_0334: bgt.s IL_0335
    IL_0335: nop
    IL_0336: stloc.0
    IL_0337: ldarg.0
    IL_033C: ldfld 0x04000349
    IL_0341: ldstr 0x700010F1
    IL_0342: conv.r8
    IL_0344: bge.s IL_0345
    IL_0345: nop
    IL_0346: stloc.0
    IL_0347: IL_22
    IL_0348: nop
    IL_0349: nop
    IL_034E: stsfld 0x00306F3E
    IL_034F: nop
    IL_0350: stloc.0
    IL_0351: ldarg.0
    IL_0356: ldfld 0x04000349
    IL_035B: ldstr 0x7000110D
    IL_035C: conv.r8
    IL_035E: bge.s IL_035F
    IL_035F: nop
    IL_0360: stloc.0
    IL_0361: IL_22
    IL_0362: IL_29
    IL_0363: sub
    IL_0364: IL_8F
    IL_0365: IL_3E
    IL_0366: conv.r8
    IL_0368: bgt.s IL_0369
    IL_0369: nop
    IL_036A: stloc.0
    IL_036B: ldarg.0
    IL_0370: ldfld 0x04000349
    IL_0375: ldstr 0x7000112B
    IL_0376: conv.r8
    IL_0378: bge.s IL_0379
    IL_0379: nop
    IL_037A: stloc.0
    IL_037B: IL_22
    IL_037D: bne.un.s IL_03B1
    IL_037E: conv.ovf.i4.un
    IL_037F: IL_3E
    IL_0380: conv.r8
    IL_0382: bgt.s IL_0383
    IL_0383: nop
    IL_0384: stloc.0
    IL_0385: ldarg.0
    IL_038A: ldfld 0x04000349
    IL_038F: ldstr 0x70001139
    IL_0390: conv.r8
    IL_0392: bge.s IL_0393
    IL_0393: nop
    IL_0394: stloc.0
    IL_0395: IL_22
    IL_0397: bne.un.s IL_03CB
    IL_0398: conv.ovf.i4.un
    IL_0399: IL_3E
    IL_039A: conv.r8
    IL_039C: bgt.s IL_039D
    IL_039D: nop
    IL_039E: stloc.0
    IL_039F: ldarg.0
    IL_03A4: ldfld 0x04000349
    IL_03A9: ldstr 0x70001155
    IL_03AA: conv.r8
    IL_03AC: bge.s IL_03AD
    IL_03AD: nop
    IL_03AE: stloc.0
    IL_03AF: IL_22
    IL_03B0: nop
    IL_03B1: nop
    IL_03B6: stsfld 0x00306F3E
    IL_03B7: nop
    IL_03B8: stloc.0
    IL_03B9: ldarg.0
    IL_03BE: ldfld 0x04000349
    IL_03C3: ldstr 0x70001173
    IL_03C4: conv.r8
    IL_03C6: bge.s IL_03C7
    IL_03C7: nop
    IL_03C8: stloc.0
    IL_03C9: IL_22
    IL_03CB: bne.un.s IL_03FF
    IL_03CD: bne.un.s IL_040D
    IL_03CE: conv.r8
    IL_03D0: bgt.s IL_03D1
    IL_03D1: nop
    IL_03D2: stloc.0
    IL_03D3: ldarg.0
    IL_03D8: ldfld 0x04000349
    IL_03DD: ldstr 0x70000EDB
    IL_03DE: conv.r8
    IL_03E0: bge.s IL_03E1
    IL_03E1: nop
    IL_03E2: stloc.0
    IL_03E3: IL_22
    IL_03E4: nop
    IL_03E5: nop
    IL_03E6: nop
    IL_03E7: IL_3F
    IL_03E8: conv.r8
    IL_03EA: bgt.s IL_03EB
    IL_03EB: nop
    IL_03EC: stloc.0
    IL_03ED: ldarg.0
    IL_03F2: ldfld 0x04000349
    IL_03F7: ldstr 0x70001187
    IL_03F8: conv.r8
    IL_03FA: bge.s IL_03FB
    IL_03FB: nop
    IL_03FC: stloc.0
    IL_03FD: IL_22
    IL_03FE: nop
    IL_03FF: nop
    IL_0404: stsfld 0x00306F3E
    IL_0405: nop
    IL_0406: stloc.0
    IL_0407: ldarg.0
    IL_040C: ldfld 0x04000349
    IL_0411: ldstr 0x7000119B
    IL_0412: conv.r8
    IL_0414: bge.s IL_0415
    IL_0415: nop
    IL_0416: stloc.0
    IL_0417: IL_22
    IL_0418: nop
    IL_0419: nop
    IL_041E: stsfld 0x00306F3E
    IL_041F: nop
    IL_0420: stloc.0
    IL_0421: ldarg.0
    IL_0426: ldfld 0x04000349
    IL_042B: ldstr 0x700011BD
    IL_042C: conv.r8
    IL_042E: bge.s IL_042F
    IL_042F: nop
    IL_0430: stloc.0
    IL_0431: IL_22
    IL_0432: IL_8F
    IL_0433: IL_C2
    IL_0434: conv.u8
    IL_0435: IL_3E
    IL_0436: conv.r8
    IL_0438: bgt.s IL_0439
    IL_0439: nop
    IL_043A: stloc.0
    IL_043B: ldarg.0
    IL_0440: ldfld 0x04000349
    IL_0445: ldstr 0x700011D1
    IL_0446: conv.r8
    IL_0448: bge.s IL_0449
    IL_0449: nop
    IL_044A: stloc.0
    IL_044B: IL_22
    IL_044C: nop
    IL_044D: nop
    IL_0452: stsfld 0x00306F3E
    IL_0453: nop
    IL_0454: stloc.0
    IL_0455: ldarg.0
    IL_045A: ldfld 0x04000349
    IL_045F: ldstr 0x700011F3
    IL_0460: conv.r8
    IL_0462: bge.s IL_0463
    IL_0463: nop
    IL_0464: stloc.0
    IL_0465: IL_22
    IL_0466: shr
    IL_0467: shr
    IL_0468: ldc.i4.0
    IL_C629: switch (12399 cases)
    }

    public void LoadingFinish() {
    IL_0004: ldstr 0x700004DD
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000358
    IL_0015: brtrue IL_004F
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000338
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: IL_22
    IL_0022: nop
    IL_0023: nop
    IL_0028: ldc.i4 8770
    IL_0029: nop
    IL_002A: nop
    IL_002F: call 0x0A000060
    IL_0030: conv.r8
    IL_0035: call 0x020A0000
    IL_0036: ldc.i4.1
    IL_003B: stfld 0x04000325
    IL_003C: ldarg.0
    IL_003D: ldc.i4.0
    IL_0042: call 0x0600017C
    IL_0043: ldarg.0
    IL_0044: ldc.i4.1
    IL_0049: stfld 0x040002B1
    IL_004E: br IL_006C
    IL_004F: ldarg.0
    IL_0054: ldfld 0x0400032C
    IL_0055: conv.r8
    IL_0056: stloc.0
    IL_0057: nop
    IL_0058: nop
    IL_0059: stloc.0
    IL_005E: call 0x0A000050
    IL_005F: ldarg.0
    IL_0060: ldc.i4.1
    IL_0065: stfld 0x04000353
    IL_0066: ldarg.0
    IL_006B: call 0x06000165
    IL_006C: ldloc.0
    IL_006D: ldc.i4.5
    IL_006E: IL_3C
    IL_006F: ldc.i4.1
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: ldarg.0
    IL_0078: ldfld 0x0400032C
    IL_0079: conv.r8
    IL_007A: stloc.0
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_0082: call 0x0A000050
    IL_0083: ldarg.0
    IL_0084: ldc.i4.1
    IL_0089: stfld 0x04000353
    IL_008A: ldarg.0
    IL_008B: ldarg.0
    IL_0090: ldfld 0x0400031F
    IL_0095: ldfld 0x04000B8D
    IL_009A: stfld 0x04000360
    IL_009B: ret
    }

    public void EnterDun() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00001B
    IL_000A: stfld 0x040002A0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000338
    IL_0015: call 0x0A000042
    IL_0016: conv.r8
    IL_001B: ldc.i4 34209792
    IL_0020: ldfld 0x04000349
    IL_0025: ldstr 0x70000F2B
    IL_0026: conv.r8
    IL_0027: IL_3C
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: pop
    IL_002C: ldarg.0
    IL_0031: call 0x0A000042
    IL_0032: IL_22
    IL_0033: stloc.0
    IL_0034: IL_D7
    IL_0035: IL_23
    IL_0036: IL_3C
    IL_003B: call 0x0A000008
    IL_0040: stfld 0x0400033B
    IL_0041: ldarg.0
    IL_0046: ldfld 0x0400031F
    IL_0047: conv.r8
    IL_0048: ldc.i4.2
    IL_0049: ldloc.0
    IL_004A: nop
    IL_004B: ldloc.0
    IL_004C: ret
    }

    public void SpRecover() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x0400034E
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_260A1690E: switch (2552781376 cases)
    }

    public void AttackSpeedUp() {
    IL_0000: ldarg.1
    IL_0001: IL_22
    IL_0002: stloc.0
    IL_0003: IL_D7
    IL_0004: stelem.i
    IL_0005: IL_3C
    IL_0006: IL_5A
    IL_0008: starg.s 1
    IL_0009: ldarg.0
    IL_000E: ldfld 0x04000349
    IL_0013: ldstr 0x700014C5
    IL_0014: conv.r8
    IL_0016: bge.s IL_0017
    IL_0017: nop
    IL_0018: stloc.0
    IL_0019: dup
    IL_001A: conv.r8
    IL_001B: IL_54
    IL_001C: nop
    IL_001D: nop
    IL_001E: stloc.0
    IL_001F: ldarg.1
    IL_0020: IL_58
    IL_0021: conv.r8
    IL_0023: bgt.s IL_0024
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000349
    IL_0030: ldstr 0x700014D5
    IL_0031: conv.r8
    IL_0033: bge.s IL_0034
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: dup
    IL_0037: conv.r8
    IL_0038: IL_54
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_003C: ldarg.1
    IL_003D: IL_58
    IL_003E: conv.r8
    IL_0040: bgt.s IL_0041
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000349
    IL_004D: ldstr 0x700014E5
    IL_004E: conv.r8
    IL_0050: bge.s IL_0051
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: dup
    IL_0054: conv.r8
    IL_0055: IL_54
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.1
    IL_005A: IL_58
    IL_005B: conv.r8
    IL_005D: bgt.s IL_005E
    IL_005E: nop
    IL_005F: stloc.0
    IL_0060: ldarg.0
    IL_0065: ldfld 0x04000349
    IL_006A: ldstr 0x700014F5
    IL_006B: conv.r8
    IL_006D: bge.s IL_006E
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: dup
    IL_0071: conv.r8
    IL_0072: IL_54
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: ldarg.1
    IL_0077: IL_58
    IL_0078: conv.r8
    IL_007A: bgt.s IL_007B
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000349
    IL_0087: ldstr 0x70001505
    IL_0088: conv.r8
    IL_008A: bge.s IL_008B
    IL_008B: nop
    IL_008C: stloc.0
    IL_008D: dup
    IL_008E: conv.r8
    IL_008F: IL_54
    IL_0090: nop
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: ldarg.1
    IL_0094: IL_58
    IL_0095: conv.r8
    IL_0097: bgt.s IL_0098
    IL_0098: nop
    IL_0099: stloc.0
    IL_009A: ret
    }

    public void MoveSpeedUp() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000349
    IL_000A: ldstr 0x7000151F
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.1
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldelem.r8
    IL_0015: IL_3F
    IL_0016: IL_5A
    IL_0017: conv.r8
    IL_0019: bgt.s IL_001A
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_001D: ldarg.1
    IL_0022: stfld 0x040002E8
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x040002E8
    IL_002E: stfld 0x040002E7
    IL_002F: ret
    }

    public void SetUpArmor() {
    IL_0000: ldarg.1
    IL_0002: ldc.i4.s 100
    IL_0003: add
    IL_0005: starg.s 1
    IL_0006: ldc.i4.2
    IL_000B: newarr 0x0100000B
    IL_000C: stloc.0
    IL_000D: ldc.i4.0
    IL_000E: stloc.1
    IL_0013: br IL_0025
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: ldarg.1
    IL_0018: ldc.i4.s 10
    IL_0019: mul
    IL_001A: ldelem.i8
    IL_001B: ldarg.1
    IL_001D: ldc.i4.s 10
    IL_001E: add
    IL_0020: starg.s 1
    IL_0021: ldloc.1
    IL_0022: ldc.i4.1
    IL_0023: IL_58
    IL_0024: stloc.1
    IL_0025: ldloc.1
    IL_0026: ldc.i4.2
    IL_0027: IL_3F
    IL_0028: IL_E8
    IL_0029: IL_FF
    IL_002A: IL_FF
    IL_002B: IL_FF
    IL_002C: ldarg.0
    IL_002D: ldloc.0
    IL_002E: ldc.i4.0
    IL_002F: IL_94
    IL_0034: stfld 0x04000363
    IL_0035: ldarg.0
    IL_0036: ldloc.0
    IL_0037: ldc.i4.1
    IL_0038: IL_94
    IL_003D: stfld 0x04000364
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0044: stfld 0x04000365
    IL_0045: ret
    }

    public void Costume_Special() {
    IL_0004: ldstr 0x70001563
    IL_0009: call 0x060003F9
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000361
    IL_0012: IL_94
    IL_0013: stloc.1
    IL_0014: ldarg.0
    IL_0015: ldloc.1
    IL_001A: call 0x06000169
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x040002BE
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000365
    IL_0028: IL_58
    IL_002D: stfld 0x040002BE
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040002BE
    IL_0039: stfld 0x040002D9
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000364
    IL_0040: stloc.2
    IL_0041: ldloc.2
    IL_0042: ldc.i4.1
    IL_0043: IL_59
    IL_0046: ldarg 3
    IL_0047: nop
    IL_0048: nop
    IL_0049: ldarg.3
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_0055: ldc.i8 4035225267214483456
    IL_0056: rem.un
    IL_0057: nop
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000363
    IL_0061: ldc.i4.1
    IL_0062: IL_59
    IL_0063: conv.i2
    IL_0064: IL_22
    IL_0065: IL_CD
    IL_0066: IL_CC
    IL_0067: IL_CC
    IL_0068: IL_3D
    IL_0069: IL_5A
    IL_006A: neg
    IL_006B: conv.i2
    IL_0070: stfld 0x040002B9
    IL_0075: br IL_00BB
    IL_0076: ldarg.0
    IL_0077: IL_22
    IL_0078: ldelem.i
    IL_0079: IL_99
    IL_007A: IL_99
    IL_007B: IL_3F
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000363
    IL_0082: ldc.i4.1
    IL_0083: IL_59
    IL_0084: conv.i2
    IL_0085: IL_22
    IL_0086: IL_CD
    IL_0087: IL_CC
    IL_0088: IL_CC
    IL_0089: IL_3D
    IL_008A: IL_5A
    IL_008B: IL_58
    IL_0090: stfld 0x040002B8
    IL_0095: br IL_00BB
    IL_0096: ldarg.0
    IL_0097: dup
    IL_009C: ldfld 0x040002D4
    IL_009D: IL_22
    IL_009E: stloc.0
    IL_009F: IL_D7
    IL_00A0: stelem.i
    IL_00A5: beq IL_3637BA8
    IL_00A6: nop
    IL_00A7: ldarg.2
    IL_00A8: conv.i2
    IL_00A9: IL_22
    IL_00AA: stloc.0
    IL_00AB: IL_D7
    IL_00AC: stelem.i
    IL_00B1: beq IL_7D58590C
    IL_00B2: IL_D4
    IL_00B3: ldarg.0
    IL_00B4: nop
    IL_00B5: ldarg.2
    IL_00BA: br IL_00BB
    IL_00BB: ret
    }

    public void Weapon_Special() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002AC
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldc.i4.1
    IL_0009: IL_58
    IL_000C: ldarg 8
    IL_000D: nop
    IL_000E: nop
    IL_000F: ldarg.3
    IL_0010: nop
    IL_0011: nop
    IL_0012: nop
    IL_0013: IL_43
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: stind.i
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_D3
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: ldc.i4.5
    IL_0020: IL_01
    IL_0021: nop
    IL_0022: nop
    IL_0023: or
    IL_0024: IL_01
    IL_0025: nop
    IL_0026: nop
    IL_0027: IL_D4
    IL_0028: IL_01
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_77
    IL_002C: IL_01
    IL_002D: nop
    IL_002E: nop
    IL_0033: br IL_0203
    IL_0034: ldarg.0
    IL_0039: ldfld 0x040002FC
    IL_003A: conv.r8
    IL_003C: bgt.s IL_003D
    IL_003D: nop
    IL_003F: br.s IL_0056
    IL_0040: ldc.i4.0
    IL_0041: conv.r8
    IL_0046: newobj 0x02060000
    IL_004B: ldfld 0x040002FD
    IL_004C: conv.r8
    IL_004E: bgt.s IL_004F
    IL_004F: nop
    IL_0051: br.s IL_0068
    IL_0052: ldc.i4.0
    IL_0053: conv.r8
    IL_0058: newobj 0x72060000
    IL_005A: brtrue.s IL_005C
    IL_005B: nop
    IL_0060: cpobj 0x00000428
    IL_0061: stloc.0
    IL_0062: conv.r8
    IL_0063: ldloc.1
    IL_0064: nop
    IL_0065: nop
    IL_0067: br.s IL_007E
    IL_0068: conv.r8
    IL_0069: conv.ovf.i4.un
    IL_006A: ldarg.1
    IL_006B: nop
    IL_006C: ldloc.0
    IL_0071: br IL_0203
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040002FC
    IL_0078: conv.r8
    IL_007A: bgt.s IL_007B
    IL_007B: nop
    IL_007D: br.s IL_0095
    IL_007E: ldarg.0
    IL_0083: ldfld 0x040002AE
    IL_0084: conv.r8
    IL_0089: newobj 0x02060000
    IL_008E: ldfld 0x040002FD
    IL_008F: conv.r8
    IL_0091: bgt.s IL_0092
    IL_0092: nop
    IL_0094: br.s IL_00AC
    IL_0095: ldarg.0
    IL_009A: ldfld 0x040002AE
    IL_009B: conv.r8
    IL_00A0: newobj 0x72060000
    IL_00A2: brtrue.s IL_00A4
    IL_00A3: nop
    IL_00A8: cpobj 0x00000428
    IL_00A9: stloc.0
    IL_00AA: conv.r8
    IL_00AB: ldloc.1
    IL_00AC: nop
    IL_00AD: nop
    IL_00AF: br.s IL_00C7
    IL_00B0: conv.r8
    IL_00B1: conv.ovf.i4.un
    IL_00B2: ldarg.1
    IL_00B3: nop
    IL_00B4: ldloc.0
    IL_00B9: br IL_0203
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x040002FC
    IL_00C0: conv.r8
    IL_00C2: bgt.s IL_00C3
    IL_00C3: nop
    IL_00C5: br.s IL_00DE
    IL_00C6: ldarg.0
    IL_00CB: ldfld 0x040002AE
    IL_00CC: conv.r8
    IL_00D1: newobj 0x02060000
    IL_00D6: ldfld 0x040002FD
    IL_00D7: conv.r8
    IL_00D9: bgt.s IL_00DA
    IL_00DA: nop
    IL_00DC: br.s IL_00F5
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x040002AE
    IL_00E3: conv.r8
    IL_00E8: newobj 0x72060000
    IL_00EA: brtrue.s IL_00EC
    IL_00EB: nop
    IL_00F0: cpobj 0x00000428
    IL_00F1: stloc.0
    IL_00F2: conv.r8
    IL_00F3: ldloc.1
    IL_00F4: nop
    IL_00F5: nop
    IL_00F7: br.s IL_0110
    IL_00F8: conv.r8
    IL_00F9: conv.ovf.i4.un
    IL_00FA: ldarg.1
    IL_00FB: nop
    IL_00FC: ldloc.0
    IL_0101: br IL_0203
    IL_0102: ldarg.0
    IL_0107: ldfld 0x040002FC
    IL_0108: conv.r8
    IL_010A: bgt.s IL_010B
    IL_010B: nop
    IL_010D: br.s IL_0127
    IL_010E: ldarg.0
    IL_0113: ldfld 0x040002AE
    IL_0114: conv.r8
    IL_0119: newobj 0x02060000
    IL_011E: ldfld 0x040002FD
    IL_011F: conv.r8
    IL_0121: bgt.s IL_0122
    IL_0122: nop
    IL_0124: br.s IL_013E
    IL_0125: ldarg.0
    IL_012A: ldfld 0x040002AE
    IL_012B: conv.r8
    IL_0130: newobj 0x72060000
    IL_0132: brtrue.s IL_0134
    IL_0133: nop
    IL_0138: cpobj 0x00000428
    IL_0139: stloc.0
    IL_013A: conv.r8
    IL_013B: ldloc.1
    IL_013C: nop
    IL_013D: nop
    IL_013F: br.s IL_0159
    IL_0140: conv.r8
    IL_0141: conv.ovf.i4.un
    IL_0142: ldarg.1
    IL_0143: nop
    IL_0144: ldloc.0
    IL_0149: br IL_0203
    IL_014A: ldarg.0
    IL_014F: ldfld 0x040002FC
    IL_0150: conv.r8
    IL_0152: bgt.s IL_0153
    IL_0153: nop
    IL_0155: br.s IL_0170
    IL_0156: ldarg.0
    IL_015B: ldfld 0x040002AE
    IL_015C: conv.r8
    IL_0161: newobj 0x02060000
    IL_0166: ldfld 0x040002FD
    IL_0167: conv.r8
    IL_0169: bgt.s IL_016A
    IL_016A: nop
    IL_016C: br.s IL_0187
    IL_016D: ldarg.0
    IL_0172: ldfld 0x040002AE
    IL_0173: conv.r8
    IL_0178: newobj 0x72060000
    IL_017A: brtrue.s IL_017C
    IL_017B: nop
    IL_0180: cpobj 0x00000428
    IL_0181: stloc.0
    IL_0182: conv.r8
    IL_0183: ldloc.1
    IL_0184: nop
    IL_0185: nop
    IL_0187: br.s IL_019E
    IL_0188: conv.r8
    IL_0189: conv.ovf.i4.un
    IL_018A: ldarg.1
    IL_018B: nop
    IL_018C: ldloc.0
    IL_0191: br IL_0203
    IL_0192: ldarg.0
    IL_0193: ldarg.0
    IL_0198: ldfld 0x040002AE
    IL_019A: ldc.i4.s 20
    IL_019B: IL_5A
    IL_01A0: stfld 0x040002AF
    IL_01A5: br IL_0203
    IL_01A6: ldarg.0
    IL_01AB: ldfld 0x040002AE
    IL_01AC: ldc.i4.4
    IL_020D: switch (23 cases)
    }

    public void ItemBuff() {
    IL_0000: ldarg.1
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0003: ldc.i4.1
    IL_0004: IL_59
    IL_0007: ldarg 6
    IL_0008: nop
    IL_0009: nop
    IL_000A: ldarg.3
    IL_000B: nop
    IL_000C: nop
    IL_000D: nop
    IL_0010: stloc 0
    IL_0011: nop
    IL_0012: conv.r8
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldelem.r8
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_C8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_D4
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0026: br IL_0106
    IL_0027: ldarg.0
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040002D6
    IL_002E: conv.i2
    IL_002F: IL_22
    IL_0030: IL_CD
    IL_0031: IL_CC
    IL_0036: newobj 0x7D695A3F
    IL_0037: IL_D6
    IL_0038: ldarg.0
    IL_0039: nop
    IL_003A: ldarg.2
    IL_003B: ldarg.0
    IL_003C: ldarg.0
    IL_0041: ldfld 0x040002D7
    IL_0042: conv.i2
    IL_0043: IL_22
    IL_0044: IL_CD
    IL_0045: IL_CC
    IL_004A: newobj 0x7D695A3F
    IL_004B: IL_D7
    IL_004C: ldarg.0
    IL_004D: nop
    IL_004E: ldarg.2
    IL_004F: ldarg.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x040002D6
    IL_005A: stfld 0x040002BD
    IL_005B: ldarg.0
    IL_005C: ldarg.0
    IL_0061: ldfld 0x040002D7
    IL_0066: stfld 0x040002C2
    IL_006B: br IL_0106
    IL_006C: ldarg.0
    IL_006D: ldarg.0
    IL_0072: ldfld 0x040002D9
    IL_0073: conv.i2
    IL_0074: IL_22
    IL_0075: ldelem.i
    IL_0076: IL_99
    IL_0077: IL_99
    IL_0078: IL_3F
    IL_0079: IL_5A
    IL_007A: not
    IL_007F: stfld 0x040002D9
    IL_0080: ldarg.0
    IL_0081: ldarg.0
    IL_0086: ldfld 0x040002D9
    IL_008B: stfld 0x040002BE
    IL_0090: br IL_0106
    IL_0091: ldarg.0
    IL_0092: ldarg.0
    IL_0097: ldfld 0x040002C9
    IL_0098: conv.i2
    IL_0099: IL_22
    IL_009B: bne.un.s IL_00CF
    IL_009C: IL_93
    IL_009D: IL_3F
    IL_009E: IL_5A
    IL_009F: not
    IL_00A4: stfld 0x040002C9
    IL_00A5: ldarg.0
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x040002C9
    IL_00B0: stfld 0x040002C8
    IL_00B1: ldarg.0
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x040002C8
    IL_00BC: stfld 0x040002C7
    IL_00C1: br IL_0106
    IL_00C2: ldarg.0
    IL_00C3: dup
    IL_00C8: ldfld 0x0400035F
    IL_00C9: IL_22
    IL_00CA: IL_CD
    IL_00CB: IL_CC
    IL_00D0: newobj 0x5F7D5A3F
    IL_00D1: ldarg.1
    IL_00D2: nop
    IL_00D3: ldarg.2
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000318
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x0400035F
    IL_00E0: conv.r8
    IL_00E5: ldtoken 0x38060001
    IL_00E6: ldc.i4.6
    IL_00E7: nop
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: ldarg.0
    IL_00EB: ldc.i4.1
    IL_00F0: stfld 0x0400032B
    IL_00F5: br IL_0106
    IL_00F6: ldarg.0
    IL_00F7: IL_22
    IL_00F8: IL_CD
    IL_00F9: IL_CC
    IL_00FA: IL_4C
    IL_00FB: IL_3E
    IL_0100: stfld 0x040002D5
    IL_0105: br IL_0106
    IL_0106: ret
    }

    public void SwingStart() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000300
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040002F8
    IL_000C: conv.r8
    IL_000D: ldind.ref
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ret
    }

    public void Set_General() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040002CE
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_000D: stfld 0x040002CD
    IL_000E: ldarg.0
    IL_000F: ldarg.3
    IL_0014: stfld 0x040002CC
    IL_0015: ldarg.0
    IL_0017: ldarg.s 4
    IL_001C: stfld 0x040002CF
    IL_001D: ldarg.0
    IL_001F: ldarg.s 5
    IL_0024: stfld 0x040002D0
    IL_0025: ldarg.0
    IL_0027: ldarg.s 6
    IL_002C: stfld 0x040002D1
    IL_002D: ldarg.0
    IL_002F: ldarg.s 8
    IL_0034: stfld 0x040002CB
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000308
    IL_003B: conv.r8
    IL_003D: ble.s IL_003E
    IL_003E: nop
    IL_0040: br.s IL_0043
    IL_0045: ldfld 0x040002CD
    IL_0046: ldarg.0
    IL_004B: ldfld 0x040002CE
    IL_004C: conv.r8
    IL_004D: IL_F9
    IL_004E: ldarg.0
    IL_004F: nop
    IL_0050: ldloc.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x040002CD
    IL_0057: ldc.i4.1
    IL_00D8: switch (31 cases)
    IL_00D9: ldc.i4.m1
    IL_00DA: nop
    IL_00DF: cpobj 0x0000ED28
    IL_00E0: stloc.0
    IL_00E5: call 0x0A000012
    IL_00E6: conv.u8
    IL_00E7: ldc.i4.8
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: IL_01
    IL_00EF: stelem 0x02F27B02
    IL_00F0: nop
    IL_00F1: ldarg.2
    IL_00F2: ldc.i4.1
    IL_00F7: ldstr 0x7000156B
    IL_00F9: ldarga.s 9
    IL_00FE: call 0x0A000016
    IL_0103: ldstr 0x70001589
    IL_0108: call 0x0A0000ED
    IL_010D: call 0x0A000012
    IL_010E: conv.u8
    IL_010F: ldc.i4.8
    IL_0110: nop
    IL_0111: nop
    IL_0112: IL_01
    IL_0117: stelem 0x02F37B02
    IL_0118: nop
    IL_0119: ldarg.2
    IL_011A: ldc.i4.0
    IL_011F: ldstr 0x7000158D
    IL_0121: ldarga.s 9
    IL_0126: call 0x0A000016
    IL_012B: ldstr 0x70001585
    IL_0130: call 0x0A0000ED
    IL_0135: call 0x0A000012
    IL_0136: conv.u8
    IL_0137: ldc.i4.8
    IL_0138: nop
    IL_0139: nop
    IL_013A: IL_01
    IL_013F: stelem 0x02F37B02
    IL_0140: nop
    IL_0141: ldarg.2
    IL_0142: ldc.i4.1
    IL_0147: ldstr 0x7000158D
    IL_0149: ldarga.s 9
    IL_014E: call 0x0A000016
    IL_0153: ldstr 0x70001589
    IL_0158: call 0x0A0000ED
    IL_015D: call 0x0A000012
    IL_015E: conv.u8
    IL_015F: ldc.i4.8
    IL_0160: nop
    IL_0161: nop
    IL_0162: IL_01
    IL_0167: stelem 0x00000000
    }

    public void ChangeFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x0400032A
    IL_0007: ldarg.0
    IL_0008: ldc.i4.5
    IL_000D: stfld 0x040002BC
    IL_000E: ldarg.1
    IL_0013: brfalse IL_00E4
    IL_0014: ldarg.0
    IL_0019: ldfld 0x04000349
    IL_001A: conv.r8
    IL_001D: ldloc 0
    IL_001E: stloc.0
    IL_001F: ldarg.2
    IL_0024: brfalse IL_0055
    IL_0025: ldarg.0
    IL_002A: ldfld 0x04000349
    IL_002F: ldstr 0x7000154B
    IL_0030: conv.r8
    IL_0032: bge.s IL_0033
    IL_0033: nop
    IL_0034: stloc.0
    IL_0035: IL_22
    IL_0036: IL_8F
    IL_0037: IL_C2
    IL_0038: conv.u8
    IL_0039: IL_3E
    IL_003A: conv.r8
    IL_003C: bgt.s IL_003D
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000349
    IL_0049: ldstr 0x7000154B
    IL_004A: conv.r8
    IL_004B: IL_3C
    IL_004C: nop
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: pop
    IL_0054: br IL_0066
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000349
    IL_005F: ldstr 0x700001C1
    IL_0060: conv.r8
    IL_0061: IL_3C
    IL_0062: nop
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: pop
    IL_0066: ldarg.0
    IL_006B: ldfld 0x0400030E
    IL_006C: ldarg.0
    IL_0071: ldfld 0x040002CD
    IL_0072: ldc.i4.1
    IL_0073: IL_58
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040002CE
    IL_007A: conv.r8
    IL_007B: IL_E6
    IL_007C: IL_01
    IL_007D: nop
    IL_007E: ldloc.0
    IL_007F: ldarg.0
    IL_0084: call 0x2B000032
    IL_0085: ldarg.0
    IL_008A: ldfld 0x040002CD
    IL_008C: ldc.i4.s 17
    IL_008D: IL_58
    IL_008E: conv.r8
    IL_008F: IL_C3
    IL_0090: IL_01
    IL_0091: nop
    IL_0092: ldloc.0
    IL_0093: ldarg.0
    IL_0098: ldfld 0x040002CD
    IL_0099: ldc.i4.1
    IL_011A: switch (31 cases)
    }

    public void MissionFail() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000349
    IL_000A: ldstr 0x70000EDB
    IL_000B: conv.r8
    IL_000C: IL_3C
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: pop
    IL_0011: ldarg.0
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0019: ldc.i4 26290241
    IL_001A: nop
    IL_001B: ldloc.0
    IL_001C: ldarg.0
    IL_001D: ldc.i4.0
    IL_0022: stfld 0x04000352
    IL_0023: ret
    }

    public void GeneralOnOff() {
    IL_0000: ldarg.2
    IL_0005: brtrue IL_0011
    IL_0006: ldarg.0
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000E: ldc.i4 26749121
    IL_000F: nop
    IL_0010: ldloc.0
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0017: stfld 0x04000302
    IL_0018: ldarg.0
    IL_0019: ldc.i4.1
    IL_001E: stfld 0x0400032A
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000349
    IL_0025: conv.r8
    IL_0028: ldloc 0
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x0400030F
    IL_0030: ldc.i4.3
    IL_0032: ldc.i4.s 16
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: IL_3F
    IL_0038: conv.r8
    IL_0039: IL_34
    IL_003A: IL_01
    IL_003B: nop
    IL_003C: ldloc.0
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000338
    IL_0047: call 0x0A00004B
    IL_0048: conv.r8
    IL_0049: IL_AF
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000302
    IL_0057: brtrue IL_027D
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000300
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040002F0
    IL_0064: ldc.i4.0
    IL_0065: ldelem.i
    IL_0066: conv.r8
    IL_0067: IL_4C
    IL_0068: nop
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: ldarg.0
    IL_0070: call 0x0A00002B
    IL_0071: conv.r8
    IL_0072: IL_4D
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: ldarg.0
    IL_0077: ldarg.0
    IL_007C: ldfld 0x040002AD
    IL_0081: stfld 0x040002AC
    IL_0082: ldarg.0
    IL_0087: ldfld 0x0400030F
    IL_0088: ldc.i4.0
    IL_0089: conv.r8
    IL_008B: bgt.s IL_008D
    IL_008C: nop
    IL_008D: ldloc.0
    IL_008E: ldarg.0
    IL_0093: ldfld 0x0400030E
    IL_0094: conv.r8
    IL_0095: IL_E7
    IL_0096: IL_01
    IL_0097: nop
    IL_0098: ldloc.0
    IL_0099: ldarg.0
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040002C9
    IL_00A4: stfld 0x040002CA
    IL_00A5: ldarg.0
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x040002D6
    IL_00B0: stfld 0x040002BD
    IL_00B1: ldarg.0
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x040002D7
    IL_00BC: stfld 0x040002C2
    IL_00BD: ldarg.0
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x040002D8
    IL_00C8: stfld 0x040002BF
    IL_00C9: ldarg.0
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x040002D9
    IL_00D4: stfld 0x040002BE
    IL_00D5: ldarg.0
    IL_00D6: ldarg.0
    IL_00DB: ldfld 0x040002D4
    IL_00E0: stfld 0x040002D3
    IL_00E1: ldarg.0
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x040002C8
    IL_00EC: stfld 0x040002C7
    IL_00ED: ldarg.0
    IL_00F2: ldfld 0x040002BC
    IL_00F4: ldc.i4.s 10
    IL_00F5: IL_3C
    IL_00F6: IL_22
    IL_00F7: nop
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: ldarg.0
    IL_00FF: ldfld 0x040002BC
    IL_0100: ldc.i4.0
    IL_0101: IL_3F
    IL_0102: ldc.i4.0
    IL_0103: nop
    IL_0104: nop
    IL_0105: nop
    IL_0106: ldarg.0
    IL_010B: ldfld 0x04000349
    IL_0110: ldstr 0x70000F2B
    IL_0111: conv.r8
    IL_0112: IL_3C
    IL_0113: nop
    IL_0114: nop
    IL_0115: stloc.0
    IL_0116: pop
    IL_011B: br IL_01E6
    IL_011C: ldarg.0
    IL_0121: ldfld 0x04000349
    IL_0126: ldstr 0x70000F3F
    IL_0127: conv.r8
    IL_0128: IL_3C
    IL_0129: nop
    IL_012A: nop
    IL_012B: stloc.0
    IL_012C: pop
    IL_012D: ldarg.0
    IL_012E: ldarg.0
    IL_0133: ldfld 0x04000349
    IL_0138: ldstr 0x7000154B
    IL_0139: ldc.i4.0
    IL_013A: conv.r8
    IL_013B: IL_53
    IL_013C: nop
    IL_013D: nop
    IL_013E: stloc.0
    IL_0143: stfld 0x04000348
    IL_0144: ldarg.0
    IL_0149: ldfld 0x04000348
    IL_014A: IL_22
    IL_014B: IL_8F
    IL_014C: IL_C2
    IL_014D: conv.u8
    IL_014E: IL_3E
    IL_014F: conv.r8
    IL_0151: bgt.s IL_0152
    IL_0152: nop
    IL_0153: stloc.0
    IL_0154: ldarg.0
    IL_0159: ldfld 0x04000348
    IL_015A: ldc.i4.1
    IL_015B: conv.r8
    IL_015D: ble.s IL_015E
    IL_015E: nop
    IL_015F: stloc.0
    IL_0160: ldarg.0
    IL_0165: ldfld 0x040002FE
    IL_016A: call 0x0A00004B
    IL_016B: IL_22
    IL_016C: nop
    IL_016D: nop
    IL_016E: nop
    IL_2213: switch (2088 cases)
    }

    public void ChangeCharacter() {
    IL_0000: ldarg.1
    IL_0002: stloc.s 6
    IL_0004: ldloc.s 6
    IL_0007: ldarg 6
    IL_0008: nop
    IL_0009: nop
    IL_000A: ldarg.3
    IL_000B: nop
    IL_000C: nop
    IL_000D: nop
    IL_000E: conv.r4
    IL_000F: IL_01
    IL_0010: nop
    IL_0011: nop
    IL_0012: IL_EA
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldelem.i4
    IL_0017: ldarg.2
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_FA
    IL_001B: ldarg.3
    IL_001C: nop
    IL_001D: nop
    IL_001E: mul
    IL_001F: ldloc.1
    IL_0020: nop
    IL_0021: nop
    IL_0026: br IL_0901
    IL_0027: ldarg.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_22
    IL_002E: IL_CD
    IL_002F: IL_CC
    IL_0030: IL_4C
    IL_0031: IL_3D
    IL_0032: IL_22
    IL_0037: ldfld 0x733E2E14
    IL_0038: conv.r.un
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_0040: stfld 0x0400033C
    IL_0041: ldarg.0
    IL_0042: IL_22
    IL_0043: IL_B8
    IL_0044: ldc.i4.8
    IL_0045: ldarg.3
    IL_0046: IL_3E
    IL_004B: stfld 0x04000340
    IL_004C: ldc.i4.0
    IL_004D: stloc.0
    IL_0052: br IL_0080
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000349
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000359
    IL_005F: ldloc.0
    IL_0060: ldelem.i
    IL_0065: ldstr 0x700015B1
    IL_0066: ldloc.0
    IL_0067: ldc.i4.1
    IL_0068: IL_58
    IL_006A: stloc.s 7
    IL_006C: ldloca.s 7
    IL_0071: call 0x0A000010
    IL_0076: call 0x0A000011
    IL_0077: conv.r8
    IL_0078: conv.i8
    IL_0079: nop
    IL_007A: nop
    IL_007B: stloc.0
    IL_007C: ldloc.0
    IL_007D: ldc.i4.1
    IL_007E: IL_58
    IL_007F: stloc.0
    IL_0080: ldloc.0
    IL_0081: ldc.i4.5
    IL_0082: IL_3F
    IL_0083: IL_CC
    IL_0084: IL_FF
    IL_0085: IL_FF
    IL_0086: IL_FF
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000349
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000359
    IL_0093: ldc.i4.5
    IL_0094: ldelem.i
    IL_0099: ldstr 0x7000154B
    IL_009A: conv.r8
    IL_009B: conv.i8
    IL_009C: nop
    IL_009D: nop
    IL_009E: stloc.0
    IL_009F: ldarg.0
    IL_00A4: ldfld 0x04000349
    IL_00A5: ldarg.0
    IL_00AA: ldfld 0x04000359
    IL_00AB: ldc.i4.6
    IL_00AC: ldelem.i
    IL_00B1: ldstr 0x70001551
    IL_00B2: conv.r8
    IL_00B3: conv.i8
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: stloc.0
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000349
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x04000359
    IL_00C3: ldc.i4.7
    IL_00C4: ldelem.i
    IL_00C9: ldstr 0x70001557
    IL_00CA: conv.r8
    IL_00CB: conv.i8
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: stloc.0
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x04000349
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x04000359
    IL_00DB: ldc.i4.8
    IL_00DC: ldelem.i
    IL_00E1: ldstr 0x7000155D
    IL_00E2: conv.r8
    IL_00E3: conv.i8
    IL_00E4: nop
    IL_00E5: nop
    IL_00E6: stloc.0
    IL_00E7: ldarg.0
    IL_00EC: ldfld 0x04000349
    IL_00ED: ldarg.0
    IL_00F2: ldfld 0x04000359
    IL_00F4: ldc.i4.s 9
    IL_00F5: ldelem.i
    IL_00FA: ldstr 0x7000151F
    IL_00FB: conv.r8
    IL_00FC: conv.i8
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: stloc.0
    IL_0100: ldarg.0
    IL_0105: ldfld 0x04000349
    IL_0106: ldarg.0
    IL_010B: ldfld 0x04000359
    IL_010D: ldc.i4.s 10
    IL_010E: ldelem.i
    IL_0113: ldstr 0x70001515
    IL_0114: conv.r8
    IL_0115: conv.i8
    IL_0116: nop
    IL_0117: nop
    IL_0118: stloc.0
    IL_0119: ldarg.0
    IL_011E: ldfld 0x04000349
    IL_011F: ldarg.0
    IL_0124: ldfld 0x04000359
    IL_0126: ldc.i4.s 11
    IL_0127: ldelem.i
    IL_012C: ldstr 0x700001C1
    IL_012D: conv.r8
    IL_012E: conv.i8
    IL_012F: nop
    IL_0130: nop
    IL_0131: stloc.0
    IL_0132: ldarg.0
    IL_0137: ldfld 0x04000349
    IL_0138: ldarg.0
    IL_013D: ldfld 0x04000359
    IL_013F: ldc.i4.s 12
    IL_0140: ldelem.i
    IL_0145: ldstr 0x70001527
    IL_0146: conv.r8
    IL_0147: conv.i8
    IL_0148: nop
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: ldarg.0
    IL_0150: ldfld 0x040002FC
    IL_0151: IL_22
    IL_0152: IL_CD
    IL_0153: IL_CC
    IL_0154: IL_CC
    IL_0155: IL_3F
    IL_0156: IL_22
    IL_0157: nop
    IL_0158: nop
    IL_0159: nop
    IL_01E6: switch (34 cases)
    IL_01E7: IL_58
    IL_01E8: stloc.1
    IL_01E9: ldloc.1
    IL_01EA: ldc.i4.5
    IL_01EB: IL_3F
    IL_01EC: IL_CC
    IL_01ED: IL_FF
    IL_01EE: IL_FF
    IL_01EF: IL_FF
    IL_01F0: ldarg.0
    IL_01F5: ldfld 0x04000349
    IL_01F6: ldarg.0
    IL_01FB: ldfld 0x0400035A
    IL_01FC: ldc.i4.5
    IL_01FD: ldelem.i
    IL_0202: ldstr 0x7000154B
    IL_0203: conv.r8
    IL_0204: conv.i8
    IL_0205: nop
    IL_0206: nop
    IL_0207: stloc.0
    IL_0208: ldarg.0
    IL_020D: ldfld 0x04000349
    IL_020E: ldarg.0
    IL_0213: ldfld 0x0400035A
    IL_0214: ldc.i4.6
    IL_0215: ldelem.i
    IL_021A: ldstr 0x70001551
    IL_021B: conv.r8
    IL_021C: conv.i8
    IL_021D: nop
    IL_021E: nop
    IL_021F: stloc.0
    IL_0220: ldarg.0
    IL_0225: ldfld 0x04000349
    IL_0226: ldarg.0
    IL_022B: ldfld 0x0400035A
    IL_022C: ldc.i4.7
    IL_022D: ldelem.i
    IL_0232: ldstr 0x70001557
    IL_0233: conv.r8
    IL_0234: conv.i8
    IL_0235: nop
    IL_0236: nop
    IL_0237: stloc.0
    IL_0238: ldarg.0
    IL_023D: ldfld 0x04000349
    IL_023E: ldarg.0
    IL_0243: ldfld 0x0400035A
    IL_0244: ldc.i4.8
    IL_0245: ldelem.i
    IL_024A: ldstr 0x7000155D
    IL_024B: conv.r8
    IL_024C: conv.i8
    IL_024D: nop
    IL_024E: nop
    IL_024F: stloc.0
    IL_0250: ldarg.0
    IL_0255: ldfld 0x04000349
    IL_0256: ldarg.0
    IL_025B: ldfld 0x0400035A
    IL_025D: ldc.i4.s 9
    IL_025E: ldelem.i
    IL_0263: ldstr 0x7000151F
    IL_0264: conv.r8
    IL_0265: conv.i8
    IL_0266: nop
    IL_0267: nop
    IL_0268: stloc.0
    IL_0269: ldarg.0
    IL_026E: ldfld 0x04000349
    IL_026F: ldarg.0
    IL_0274: ldfld 0x0400035A
    IL_0276: ldc.i4.s 10
    IL_0277: ldelem.i
    IL_027C: ldstr 0x70001515
    IL_027D: conv.r8
    IL_027E: conv.i8
    IL_027F: nop
    IL_0280: nop
    IL_0281: stloc.0
    IL_0282: ldarg.0
    IL_0287: ldfld 0x04000349
    IL_0288: ldarg.0
    IL_028D: ldfld 0x0400035A
    IL_028F: ldc.i4.s 11
    IL_0290: ldelem.i
    IL_0295: ldstr 0x700001C1
    IL_0296: conv.r8
    IL_0297: conv.i8
    IL_0298: nop
    IL_0299: nop
    IL_029A: stloc.0
    IL_029B: ldarg.0
    IL_02A0: ldfld 0x04000349
    IL_02A1: ldarg.0
    IL_02A6: ldfld 0x0400035A
    IL_02A8: ldc.i4.s 12
    IL_02A9: ldelem.i
    IL_02AE: ldstr 0x70001527
    IL_02AF: conv.r8
    IL_02B0: conv.i8
    IL_02B1: nop
    IL_02B2: nop
    IL_02B3: stloc.0
    IL_02B4: ldarg.0
    IL_02B6: ldc.i4.s 10
    IL_02BB: stfld 0x04000356
    IL_02BC: ldarg.0
    IL_02C1: ldfld 0x040002FC
    IL_02C2: IL_22
    IL_02C3: shr
    IL_02C4: shr
    IL_02C9: isinst 0x999A223F
    IL_02CA: IL_D9
    IL_02CB: IL_3F
    IL_02CC: IL_22
    IL_02CD: ldelem.i
    IL_02CE: IL_99
    IL_02CF: IL_D9
    IL_02D0: IL_3F
    IL_02D5: newobj 0x0A000076
    IL_02D6: conv.r8
    IL_02D7: IL_AF
    IL_02D8: nop
    IL_02D9: nop
    IL_02DA: stloc.0
    IL_02DB: ldarg.0
    IL_02DC: dup
    IL_02E1: ldfld 0x040002D3
    IL_02E2: IL_22
    IL_02E3: stloc.0
    IL_02E4: IL_D7
    IL_02E5: stelem.i
    IL_02E6: IL_3C
    IL_02E7: IL_59
    IL_02EC: stfld 0x040002D3
    IL_02ED: ldarg.0
    IL_02F2: ldfld 0x04000349
    IL_02F7: ldstr 0x7000151F
    IL_02F8: conv.r8
    IL_02FA: bge.s IL_02FB
    IL_02FB: nop
    IL_02FC: stloc.0
    IL_02FD: IL_22
    IL_02FE: ldelem.i
    IL_02FF: IL_99
    IL_0300: ldc.i4.3
    IL_0301: IL_3F
    IL_0302: conv.r8
    IL_0304: bgt.s IL_0305
    IL_0305: nop
    IL_0306: stloc.0
    IL_030B: br IL_0901
    IL_030C: ldarg.0
    IL_030D: IL_22
    IL_030E: nop
    IL_030F: nop
    IL_0310: nop
    IL_0311: nop
    IL_0312: IL_22
    IL_0313: IL_CD
    IL_0314: IL_CC
    IL_0315: IL_4C
    IL_0316: IL_3D
    IL_0317: IL_22
    IL_0318: IL_CD
    IL_0319: IL_CC
    IL_031A: IL_4C
    IL_031B: IL_3E
    IL_0320: newobj 0x0A000076
    IL_0325: stfld 0x0400033C
    IL_0326: ldarg.0
    IL_0327: IL_22
    IL_0328: ldelem.i
    IL_0329: IL_99
    IL_032A: ldc.i4.3
    IL_032B: IL_3E
    IL_0330: stfld 0x04000340
    IL_0331: ldc.i4.0
    IL_0332: stloc.2
    IL_0337: br IL_0365
    IL_0338: ldarg.0
    IL_033D: ldfld 0x04000349
    IL_033E: ldarg.0
    IL_0343: ldfld 0x0400035B
    IL_0344: ldloc.2
    IL_0345: ldelem.i
    IL_034A: ldstr 0x700015B1
    IL_034B: ldloc.2
    IL_034C: ldc.i4.1
    IL_034D: IL_58
    IL_034F: stloc.s 9
    IL_0351: ldloca.s 9
    IL_0356: call 0x0A000010
    IL_035B: call 0x0A000011
    IL_035C: conv.r8
    IL_035D: conv.i8
    IL_035E: nop
    IL_035F: nop
    IL_0360: stloc.0
    IL_0361: ldloc.2
    IL_0362: ldc.i4.1
    IL_0363: IL_58
    IL_0364: stloc.2
    IL_0365: ldloc.2
    IL_0366: ldc.i4.5
    IL_0367: IL_3F
    IL_0368: IL_CC
    IL_0369: IL_FF
    IL_036A: IL_FF
    IL_036B: IL_FF
    IL_036C: ldarg.0
    IL_0371: ldfld 0x04000349
    IL_0372: ldarg.0
    IL_0377: ldfld 0x0400035B
    IL_0378: ldc.i4.5
    IL_0379: ldelem.i
    IL_037E: ldstr 0x7000154B
    IL_037F: conv.r8
    IL_0380: conv.i8
    IL_0381: nop
    IL_0382: nop
    IL_0383: stloc.0
    IL_0384: ldarg.0
    IL_0389: ldfld 0x04000349
    IL_038A: ldarg.0
    IL_038F: ldfld 0x0400035B
    IL_0390: ldc.i4.6
    IL_0391: ldelem.i
    IL_0396: ldstr 0x70001551
    IL_0397: conv.r8
    IL_0398: conv.i8
    IL_0399: nop
    IL_039A: nop
    IL_039B: stloc.0
    IL_039C: ldarg.0
    IL_03A1: ldfld 0x04000349
    IL_03A2: ldarg.0
    IL_03A7: ldfld 0x0400035B
    IL_03A8: ldc.i4.7
    IL_03A9: ldelem.i
    IL_03AE: ldstr 0x70001557
    IL_03AF: conv.r8
    IL_03B0: conv.i8
    IL_03B1: nop
    IL_03B2: nop
    IL_03B3: stloc.0
    IL_03B4: ldarg.0
    IL_03B9: ldfld 0x04000349
    IL_03BA: ldarg.0
    IL_03BF: ldfld 0x0400035B
    IL_03C0: ldc.i4.8
    IL_03C1: ldelem.i
    IL_03C6: ldstr 0x7000155D
    IL_03C7: conv.r8
    IL_03C8: conv.i8
    IL_03C9: nop
    IL_03CA: nop
    IL_03CB: stloc.0
    IL_03CC: ldarg.0
    IL_03D1: ldfld 0x04000349
    IL_03D2: ldarg.0
    IL_03D7: ldfld 0x0400035B
    IL_03D9: ldc.i4.s 9
    IL_03DA: ldelem.i
    IL_03DF: ldstr 0x7000151F
    IL_03E0: conv.r8
    IL_03E1: conv.i8
    IL_03E2: nop
    IL_03E3: nop
    IL_03E4: stloc.0
    IL_03E5: ldarg.0
    IL_03EA: ldfld 0x04000349
    IL_03EB: ldarg.0
    IL_03F0: ldfld 0x0400035B
    IL_03F2: ldc.i4.s 10
    IL_03F3: ldelem.i
    IL_03F8: ldstr 0x70001515
    IL_03F9: conv.r8
    IL_03FA: conv.i8
    IL_03FB: nop
    IL_03FC: nop
    IL_03FD: stloc.0
    IL_03FE: ldarg.0
    IL_0403: ldfld 0x04000349
    IL_0404: ldarg.0
    IL_0409: ldfld 0x0400035B
    IL_040B: ldc.i4.s 11
    IL_040C: ldelem.i
    IL_0411: ldstr 0x700001C1
    IL_0412: conv.r8
    IL_0413: conv.i8
    IL_0414: nop
    IL_0415: nop
    IL_0416: stloc.0
    IL_0417: ldarg.0
    IL_041C: ldfld 0x04000349
    IL_041D: ldarg.0
    IL_0422: ldfld 0x0400035B
    IL_0424: ldc.i4.s 12
    IL_0425: ldelem.i
    IL_042A: ldstr 0x70001527
    IL_042B: conv.r8
    IL_042C: conv.i8
    IL_042D: nop
    IL_042E: nop
    IL_042F: stloc.0
    IL_0430: ldarg.0
    IL_0432: ldc.i4.s 20
    IL_0437: stfld 0x04000356
    IL_0438: ldarg.0
    IL_043D: ldfld 0x04000302
    IL_0442: brtrue IL_0481
    IL_0443: ldarg.0
    IL_0448: ldfld 0x040002FC
    IL_0449: IL_22
    IL_044A: nop
    IL_044B: nop
    IL_044C: nop
    IL_99999CD9: switch (644245026 cases)
    }

    public void StopControl() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040002B1
    IL_0007: ldarg.0
    IL_000C: call 0x0A00001B
    IL_0011: stfld 0x0400029D
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040002BB
    IL_001C: brfalse IL_0039
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400031D
    IL_0023: ldc.i4.0
    IL_0024: conv.r8
    IL_0025: IL_E8
    IL_0026: ldarg.1
    IL_0027: nop
    IL_0028: ldloc.0
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000343
    IL_002F: IL_22
    IL_0030: IL_CD
    IL_0031: IL_CC
    IL_0032: IL_CC
    IL_0033: IL_3D
    IL_0034: conv.r8
    IL_0036: bgt.s IL_0037
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldarg.0
    IL_003E: ldc.i4 300
    IL_0043: stfld 0x040002BC
    IL_0044: ldarg.0
    IL_0049: ldfld 0x0400030E
    IL_004A: conv.r8
    IL_004B: IL_EB
    IL_004C: IL_01
    IL_004D: nop
    IL_004E: ldloc.0
    IL_004F: ldarg.0
    IL_0050: ldc.i4.1
    IL_0055: stfld 0x04000321
    IL_0056: ldarg.0
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005E: ldc.i4 52657473
    IL_005F: nop
    IL_0060: ldarg.2
    IL_0061: ret
    }

    public void StartControl() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040002B1
    IL_0007: ldarg.0
    IL_000C: ldfld 0x0400030E
    IL_000D: conv.r8
    IL_000E: IL_EC
    IL_000F: IL_01
    IL_0010: nop
    IL_0011: ldloc.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000353
    IL_001C: brtrue IL_002E
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400032C
    IL_0023: conv.r8
    IL_0024: stloc.0
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ldc.i4.1
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_002F: ldc.i4.0
    IL_0034: stfld 0x04000321
    IL_0035: ldarg.0
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003F: stfld 0x04000323
    IL_0040: ret
    }

    public void Resurection() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000352
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000E: stsfld 0x0111283F
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: ldc.i4.1
    IL_0017: stfld 0x040002B1
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040002C9
    IL_0023: stfld 0x040002CA
    IL_0024: ldarg.0
    IL_0025: ldarg.0
    IL_002A: ldfld 0x040002CA
    IL_002F: stfld 0x040002C8
    IL_0030: ldarg.0
    IL_0031: ldarg.0
    IL_0036: ldfld 0x040002CA
    IL_003B: stfld 0x040002C7
    IL_003C: ldarg.0
    IL_003D: ldarg.0
    IL_0042: ldfld 0x040002DD
    IL_0047: stfld 0x040002D2
    IL_0048: ldarg.0
    IL_004D: ldfld 0x0400031F
    IL_004E: ldarg.0
    IL_0053: ldfld 0x040002C7
    IL_0054: ldarg.0
    IL_0059: ldfld 0x040002CA
    IL_005A: conv.r8
    IL_005C: brfalse.s IL_0063
    IL_005D: nop
    IL_005E: ldloc.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400031F
    IL_0065: ldarg.0
    IL_006A: ldfld 0x040002D2
    IL_006B: conv.r8
    IL_006D: br.s IL_0074
    IL_006E: nop
    IL_006F: ldloc.0
    IL_0070: ldarg.0
    IL_0075: ldfld 0x04000302
    IL_007A: brfalse IL_0098
    IL_007B: ldarg.0
    IL_007C: IL_22
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_C8
    IL_0080: IL_42
    IL_0085: call 0x06000198
    IL_0086: ldarg.0
    IL_008B: ldfld 0x0400031F
    IL_008C: ldc.i4.1
    IL_008D: conv.r8
    IL_008F: ldarg.s 6
    IL_0090: nop
    IL_0091: ldloc.0
    IL_0092: pop
    IL_0097: br IL_00B3
    IL_0098: ldarg.0
    IL_009D: call 0x0A00002A
    IL_009E: conv.r8
    IL_00A1: ldloc 0
    IL_00A2: stloc.0
    IL_00A3: ldarg.0
    IL_00A8: call 0x0A00002A
    IL_00AD: ldstr 0x700001C1
    IL_00AE: conv.r8
    IL_00AF: IL_55
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: stloc.0
    IL_00B3: ldarg.0
    IL_00B4: IL_22
    IL_00B5: nop
    IL_00B6: nop
    IL_00B7: nop
    IL_00B8: nop
    IL_00BD: stfld 0x04000323
    IL_00BE: ldarg.0
    IL_00BF: ldc.i4.0
    IL_00C4: stfld 0x04000321
    IL_00C5: ldarg.0
    IL_00C6: IL_22
    IL_00C7: nop
    IL_00C8: nop
    IL_644A1CD: switch (26290240 cases)
    }

    public void Fly() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000300
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040002F9
    IL_000C: conv.r8
    IL_000D: ldind.ref
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: ldc.i4.1
    IL_0017: stfld 0x04000325
    IL_0018: ldarg.0
    IL_0019: ldc.i4.1
    IL_001E: stfld 0x040002A7
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000349
    IL_0025: conv.r8
    IL_0028: ldloc 0
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x04000349
    IL_0034: ldstr 0x70001335
    IL_0035: conv.r8
    IL_0036: IL_3C
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: pop
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000349
    IL_0045: ldstr 0x70001359
    IL_0046: conv.r8
    IL_004B: newobj 0x0A0A0000
    IL_004C: ldloc.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000349
    IL_0057: ldstr 0x70001359
    IL_0058: conv.r8
    IL_005A: bge.s IL_005B
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: conv.r8
    IL_005E: IL_54
    IL_005F: nop
    IL_0060: nop
    IL_0061: stloc.0
    IL_0062: conv.r8
    IL_0064: bgt.s IL_0065
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000349
    IL_0071: ldstr 0x700013A3
    IL_0072: conv.r8
    IL_0077: newobj 0x0A0A0000
    IL_0078: ldloc.0
    IL_0079: ldarg.0
    IL_007E: ldfld 0x04000349
    IL_0083: ldstr 0x700013A3
    IL_0084: conv.r8
    IL_0086: bge.s IL_0087
    IL_0087: nop
    IL_0088: stloc.0
    IL_0089: conv.r8
    IL_008A: IL_54
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: conv.r8
    IL_0090: bgt.s IL_0091
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04000349
    IL_009D: ldstr 0x70001397
    IL_009E: conv.r8
    IL_00A3: newobj 0x0A0A0000
    IL_00A4: ldloc.0
    IL_00A5: ldarg.0
    IL_00AA: ldfld 0x04000349
    IL_00AF: ldstr 0x70001397
    IL_00B0: conv.r8
    IL_00B2: bge.s IL_00B3
    IL_00B3: nop
    IL_00B4: stloc.0
    IL_00B5: conv.r8
    IL_00B6: IL_54
    IL_00B7: nop
    IL_00B8: nop
    IL_00B9: stloc.0
    IL_00BA: conv.r8
    IL_00BC: bgt.s IL_00BD
    IL_00BD: nop
    IL_00BE: stloc.0
    IL_00BF: ldloc.0
    IL_00C0: ldc.i4.2
    IL_00C1: conv.r8
    IL_00C6: ldstr 0x020A0000
    IL_00C7: IL_22
    IL_00C8: ldelem.i
    IL_00C9: IL_99
    IL_00CA: IL_99
    IL_00CB: IL_3E
    IL_00D0: stfld 0x040002E7
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x04000353
    IL_00DB: brtrue IL_00F8
    IL_00DC: ldarg.0
    IL_00E1: ldfld 0x0400032C
    IL_00E2: conv.r8
    IL_00E3: stloc.0
    IL_00E4: nop
    IL_00E5: nop
    IL_00E6: stloc.0
    IL_00E7: ldc.i4.1
    IL_00E8: conv.r8
    IL_00E9: stloc.1
    IL_00EA: nop
    IL_00EB: nop
    IL_00EC: stloc.0
    IL_00ED: ldarg.0
    IL_00F2: ldfld 0x0400031C
    IL_00F3: conv.r8
    IL_00F4: IL_DB
    IL_00F5: ldarg.1
    IL_00F6: nop
    IL_00F7: ldloc.0
    IL_00F8: ldarg.0
    IL_00F9: ldarg.0
    IL_00FE: ldfld 0x040002AA
    IL_00FF: conv.i2
    IL_0100: IL_22
    IL_0101: stloc.0
    IL_0102: IL_D7
    IL_0103: IL_23
    IL_0104: IL_3C
    IL_0105: IL_5A
    IL_010A: call 0x06000194
    IL_010B: ldarg.0
    IL_0110: ldfld 0x04000342
    IL_0111: ldarg.0
    IL_0116: ldfld 0x04000340
    IL_0117: conv.r8
    IL_0118: IL_CB
    IL_0119: nop
    IL_011A: nop
    IL_011B: stloc.0
    IL_011C: ldarg.0
    IL_0121: ldfld 0x04000342
    IL_0122: ldarg.0
    IL_0127: ldfld 0x0400033E
    IL_0128: conv.r8
    IL_012A: starg.s 1
    IL_012B: nop
    IL_012C: stloc.0
    IL_012D: ret
    }

    public void RndAtk() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040002C2
    IL_0007: ldarg.0
    IL_000C: ldfld 0x040002BD
    IL_000D: ldc.i4.1
    IL_000E: IL_58
    IL_0013: call 0x0A000045
    IL_0018: stfld 0x040002C6
    IL_0019: ldarg.1
    IL_001E: brfalse IL_004A
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040002C4
    IL_0025: ldc.i4.0
    IL_0027: ldc.i4.s 100
    IL_002C: call 0x0A000045
    IL_002D: IL_3F
    IL_002E: ldc.i4.2
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000312
    IL_0038: ldc.i4.2
    IL_0039: conv.r8
    IL_003A: IL_CD
    IL_003B: ldarg.3
    IL_003C: nop
    IL_003D: ldloc.0
    IL_003E: ldarg.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x040002BD
    IL_0049: stfld 0x040002C6
    IL_004A: ret
    }

    public void SetPetSkillLV() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040002A8
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_000D: stfld 0x040002A9
    IL_000E: ldarg.0
    IL_000F: ldarg.3
    IL_0014: stfld 0x040002AA
    IL_0015: ret
    }

    public void FindItem() {
    IL_0000: ldc.i4.0
    IL_0002: ldc.i4.s 100
    IL_0007: call 0x0A000045
    IL_0008: stloc.0
    IL_0009: ldloc.0
    IL_000A: ldarg.0
    IL_000F: ldfld 0x040002A8
    IL_0010: IL_3C
    IL_0015: call 0x02000000
    IL_001A: ldfld 0x04000353
    IL_001F: brtrue IL_003D
    IL_0020: ldarg.0
    IL_0025: ldfld 0x0400032C
    IL_0026: conv.r8
    IL_0027: stloc.0
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldc.i4.1
    IL_002C: conv.r8
    IL_002D: stloc.1
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: ldarg.0
    IL_0036: ldfld 0x0400031C
    IL_0037: ldarg.1
    IL_0038: conv.r8
    IL_0039: IL_DD
    IL_003A: ldarg.1
    IL_003B: nop
    IL_003C: ldloc.0
    IL_003D: ret
    }

    public void FogOn() {
    IL_0000: ldarg.1
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0005: ldarg 3
    IL_0006: nop
    IL_0007: nop
    IL_0008: ldarg.3
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: conv.i4
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ret
    IL_0011: IL_01
    IL_0012: nop
    IL_0013: nop
    IL_0018: br IL_01FC
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000334
    IL_001F: ldarg.0
    IL_0024: ldfld 0x0400032E
    IL_0025: ldelem.i
    IL_0026: conv.r8
    IL_0027: stloc.0
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldc.i4.1
    IL_002C: conv.r8
    IL_002D: stloc.1
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000334
    IL_0037: ldarg.0
    IL_003C: ldfld 0x0400032E
    IL_003D: ldelem.i
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000338
    IL_0044: conv.r8
    IL_0045: ldc.i4.2
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: conv.r8
    IL_004A: ldloc.3
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000334
    IL_0054: ldarg.0
    IL_0059: ldfld 0x0400032E
    IL_005A: ldelem.i
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000338
    IL_0061: conv.r8
    IL_0062: pop
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: conv.r8
    IL_006B: call 0x020A0000
    IL_006C: ldarg.0
    IL_0071: ldfld 0x0400032E
    IL_0072: ldc.i4.1
    IL_0073: IL_58
    IL_0074: ldc.i4.3
    IL_0075: mul
    IL_007A: stfld 0x0400032E
    IL_007F: br IL_01FC
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000335
    IL_0086: ldarg.0
    IL_008B: ldfld 0x0400032F
    IL_008C: ldelem.i
    IL_008D: conv.r8
    IL_008E: stloc.0
    IL_008F: nop
    IL_0090: nop
    IL_0091: stloc.0
    IL_0092: ldc.i4.1
    IL_0093: conv.r8
    IL_0094: stloc.1
    IL_0095: nop
    IL_0096: nop
    IL_0097: stloc.0
    IL_0098: ldarg.0
    IL_009D: ldfld 0x04000335
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x0400032F
    IL_00A4: ldelem.i
    IL_00A5: ldarg.0
    IL_00AA: ldfld 0x04000338
    IL_00AB: conv.r8
    IL_00AC: ldc.i4.2
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B0: ldarg.0
    IL_00B5: ldfld 0x04000338
    IL_00B6: conv.r8
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: stloc.0
    IL_00BB: IL_22
    IL_00BC: IL_CD
    IL_00BD: IL_CC
    IL_00BE: IL_4C
    IL_00BF: IL_3E
    IL_00C4: call 0x0A000008
    IL_00C9: call 0x0A000029
    IL_00CE: call 0x0A000007
    IL_00CF: IL_22
    IL_00D0: ldelem.i
    IL_00D1: IL_99
    IL_00D2: ldc.i4.3
    IL_00D3: IL_3E
    IL_00D8: call 0x0A000008
    IL_00DD: call 0x0A000029
    IL_00DE: conv.r8
    IL_00DF: ldloc.3
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: stloc.0
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000335
    IL_00E9: ldarg.0
    IL_00EE: ldfld 0x0400032F
    IL_00EF: ldelem.i
    IL_00F0: ldarg.0
    IL_00F5: ldfld 0x04000338
    IL_00F6: conv.r8
    IL_00F7: IL_22
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FB: conv.r8
    IL_00FC: IL_CC
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: stloc.0
    IL_0100: ldarg.0
    IL_0105: ldfld 0x04000335
    IL_0106: ldarg.0
    IL_010B: ldfld 0x0400032F
    IL_010C: ldelem.i
    IL_010D: ldarg.0
    IL_0112: ldfld 0x04000338
    IL_0113: conv.r8
    IL_0114: IL_22
    IL_0115: nop
    IL_0116: nop
    IL_0117: stloc.0
    IL_0118: ldc.i4.0
    IL_011D: ldc.i4 360
    IL_0122: call 0x0A000045
    IL_0123: conv.i2
    IL_0124: conv.r8
    IL_0126: ldloca.s 1
    IL_0127: nop
    IL_0128: stloc.0
    IL_0129: ldarg.0
    IL_012A: ldarg.0
    IL_012F: ldfld 0x0400032F
    IL_0130: ldc.i4.1
    IL_0131: IL_58
    IL_0132: ldc.i4.3
    IL_0133: mul
    IL_0138: stfld 0x0400032F
    IL_013D: br IL_01FC
    IL_013E: ldarg.0
    IL_0143: ldfld 0x04000335
    IL_0144: ldarg.0
    IL_0149: ldfld 0x0400032F
    IL_014A: ldelem.i
    IL_014B: conv.r8
    IL_014C: stloc.0
    IL_014D: nop
    IL_014E: nop
    IL_014F: stloc.0
    IL_0150: ldc.i4.1
    IL_0151: conv.r8
    IL_0152: stloc.1
    IL_0153: nop
    IL_0154: nop
    IL_0155: stloc.0
    IL_0156: ldarg.0
    IL_015B: ldfld 0x04000335
    IL_015C: ldarg.0
    IL_0161: ldfld 0x0400032F
    IL_0162: ldelem.i
    IL_0163: ldarg.0
    IL_0168: ldfld 0x04000336
    IL_0169: conv.r8
    IL_016A: ldc.i4.2
    IL_016B: nop
    IL_016C: nop
    IL_016D: stloc.0
    IL_016E: ldarg.0
    IL_0173: ldfld 0x04000336
    IL_0174: conv.r8
    IL_0175: IL_22
    IL_0176: nop
    IL_0177: nop
    IL_0178: stloc.0
    IL_0179: IL_22
    IL_017A: IL_CD
    IL_017B: IL_CC
    IL_017C: IL_4C
    IL_017D: IL_3E
    IL_0182: call 0x0A000008
    IL_0187: call 0x0A000029
    IL_018C: call 0x0A000007
    IL_018D: IL_22
    IL_018E: ldelem.i
    IL_018F: IL_99
    IL_0190: ldc.i4.3
    IL_0191: IL_3E
    IL_0196: call 0x0A000008
    IL_019B: call 0x0A000029
    IL_019C: conv.r8
    IL_019D: ldloc.3
    IL_019E: nop
    IL_019F: nop
    IL_01A0: stloc.0
    IL_01A1: ldarg.0
    IL_01A6: ldfld 0x04000335
    IL_01A7: ldarg.0
    IL_01AC: ldfld 0x0400032F
    IL_01AD: ldelem.i
    IL_01AE: ldarg.0
    IL_01B3: ldfld 0x04000336
    IL_01B4: conv.r8
    IL_01B5: IL_22
    IL_01B6: nop
    IL_01B7: nop
    IL_01B8: stloc.0
    IL_01B9: conv.r8
    IL_01BA: IL_CC
    IL_01BB: nop
    IL_01BC: nop
    IL_01BD: stloc.0
    IL_01BE: ldarg.0
    IL_01C3: ldfld 0x04000335
    IL_01C4: ldarg.0
    IL_01C9: ldfld 0x0400032F
    IL_01CA: ldelem.i
    IL_01CB: ldarg.0
    IL_01D0: ldfld 0x04000336
    IL_01D1: conv.r8
    IL_01D2: IL_22
    IL_01D3: nop
    IL_01D4: nop
    IL_01D5: stloc.0
    IL_01D6: ldc.i4.0
    IL_01DB: ldc.i4 360
    IL_01E0: call 0x0A000045
    IL_01E1: conv.i2
    IL_01E2: conv.r8
    IL_01E4: ldloca.s 1
    IL_01E5: nop
    IL_01E6: stloc.0
    IL_01E7: ldarg.0
    IL_01E8: ldarg.0
    IL_01ED: ldfld 0x0400032F
    IL_01EE: ldc.i4.1
    IL_01EF: IL_58
    IL_01F0: ldc.i4.3
    IL_01F1: mul
    IL_01F6: stfld 0x0400032F
    IL_01FB: br IL_01FC
    IL_01FC: ret
    }

    public void CallHorse() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000300
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040002F9
    IL_000C: conv.r8
    IL_000D: ldind.ref
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: ldc.i4.1
    IL_0017: stfld 0x04000325
    IL_0018: ldarg.0
    IL_0019: ldc.i4.0
    IL_001E: stfld 0x040002A7
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000349
    IL_0025: conv.r8
    IL_0028: ldloc 0
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x04000349
    IL_0034: ldstr 0x70001335
    IL_0035: conv.r8
    IL_0036: IL_3C
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: pop
    IL_003B: ldarg.0
    IL_003C: ldarg.0
    IL_0041: ldfld 0x04000349
    IL_0046: ldstr 0x70001359
    IL_0047: conv.r8
    IL_004C: newobj 0x7D0A0000
    IL_004D: IL_43
    IL_004E: ldarg.1
    IL_004F: nop
    IL_0050: ldarg.2
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000343
    IL_0057: ldarg.0
    IL_005C: ldfld 0x04000349
    IL_0061: ldstr 0x70001359
    IL_0062: conv.r8
    IL_0064: bge.s IL_0065
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: conv.r8
    IL_0068: IL_54
    IL_0069: nop
    IL_006A: nop
    IL_006B: stloc.0
    IL_006C: conv.r8
    IL_006E: bgt.s IL_006F
    IL_006F: nop
    IL_0070: stloc.0
    IL_0071: ldarg.0
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04000349
    IL_007C: ldstr 0x700013ED
    IL_007D: conv.r8
    IL_0082: newobj 0x7D0A0000
    IL_0083: IL_43
    IL_0084: ldarg.1
    IL_0085: nop
    IL_0086: ldarg.2
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000343
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000349
    IL_0097: ldstr 0x700013ED
    IL_0098: conv.r8
    IL_009A: bge.s IL_009B
    IL_009B: nop
    IL_009C: stloc.0
    IL_009D: conv.r8
    IL_009E: IL_54
    IL_009F: nop
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: conv.r8
    IL_00A4: bgt.s IL_00A5
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00A7: ldarg.0
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x04000349
    IL_00B2: ldstr 0x7000141F
    IL_00B3: conv.r8
    IL_00B8: newobj 0x7D0A0000
    IL_00B9: IL_43
    IL_00BA: ldarg.1
    IL_00BB: nop
    IL_00BC: ldarg.2
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x04000343
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000349
    IL_00CD: ldstr 0x7000141F
    IL_00CE: conv.r8
    IL_00D0: bge.s IL_00D1
    IL_00D1: nop
    IL_00D2: stloc.0
    IL_00D3: conv.r8
    IL_00D4: IL_54
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: stloc.0
    IL_00D8: conv.r8
    IL_00DA: bgt.s IL_00DB
    IL_00DB: nop
    IL_00DC: stloc.0
    IL_00DD: ldarg.0
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x04000349
    IL_00E8: ldstr 0x700012D7
    IL_00E9: conv.r8
    IL_00EE: newobj 0x7D0A0000
    IL_00EF: IL_43
    IL_00F0: ldarg.1
    IL_00F1: nop
    IL_00F2: ldarg.2
    IL_00F3: ldarg.0
    IL_00F8: ldfld 0x04000343
    IL_00F9: ldc.i4.2
    IL_00FA: conv.r8
    IL_00FF: ldstr 0x020A0000
    IL_0104: ldfld 0x04000343
    IL_0105: IL_22
    IL_0106: IL_CD
    IL_0107: IL_CC
    IL_0108: IL_4C
    IL_0109: IL_3D
    IL_010A: conv.r8
    IL_010C: bgt.s IL_010D
    IL_010D: nop
    IL_010E: stloc.0
    IL_010F: ldarg.0
    IL_0114: ldfld 0x0400031D
    IL_0115: conv.r8
    IL_0116: IL_EA
    IL_0117: ldarg.1
    IL_0118: nop
    IL_0119: ldloc.0
    IL_011A: ldarg.0
    IL_011B: IL_22
    IL_011C: IL_CD
    IL_011D: IL_CC
    IL_011E: IL_4C
    IL_011F: IL_3F
    IL_0124: stfld 0x040002E7
    IL_0125: ldarg.0
    IL_0126: ldarg.0
    IL_012B: ldfld 0x040002A9
    IL_012C: conv.i2
    IL_012D: IL_22
    IL_012E: stloc.0
    IL_012F: IL_D7
    IL_0130: IL_23
    IL_0131: IL_3C
    IL_0132: IL_5A
    IL_0137: call 0x06000194
    IL_0138: ldarg.0
    IL_013D: ldfld 0x04000342
    IL_013E: ldarg.0
    IL_0143: ldfld 0x04000340
    IL_0144: conv.r8
    IL_0145: IL_CB
    IL_0146: nop
    IL_0147: nop
    IL_0148: stloc.0
    IL_0149: ldarg.0
    IL_014E: ldfld 0x04000342
    IL_014F: ldarg.0
    IL_0154: ldfld 0x0400033F
    IL_0155: conv.r8
    IL_0157: starg.s 1
    IL_0158: nop
    IL_0159: stloc.0
    IL_015A: ret
    }

    public void PetSkillFinish() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000356
    IL_000B: stfld 0x040002A6
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000349
    IL_0012: conv.r8
    IL_0015: ldloc 0
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldflda 0x040002A0
    IL_001D: ldc.i4.1
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0027: call 0x0A00001A
    IL_0028: ldarg.0
    IL_002D: ldc.i4 180
    IL_0032: stfld 0x040002BC
    IL_0033: ldarg.1
    IL_0034: ldc.i4.1
    IL_01C5: switch (99 cases)
    }

    public void WakToward() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000349
    IL_0006: conv.r8
    IL_0009: ldloc 0
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x040002B1
    IL_0012: ldarg.2
    IL_0017: brtrue IL_005F
    IL_0018: ldarg.0
    IL_001D: ldfld 0x0400030E
    IL_001E: ldc.i4.3
    IL_001F: ldc.i4.3
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0025: IL_22
    IL_0026: nop
    IL_0027: nop
    IL_002C: stsfld 0x01E96F3F
    IL_002D: nop
    IL_002E: ldloc.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000349
    IL_0039: ldstr 0x700015D9
    IL_003A: conv.r8
    IL_003C: bge.s IL_003D
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: IL_22
    IL_0040: shr
    IL_0041: shr
    IL_0042: IL_E6
    IL_0043: IL_3E
    IL_0044: conv.r8
    IL_0046: bgt.s IL_0047
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000349
    IL_0053: ldstr 0x700015D9
    IL_0054: conv.r8
    IL_0055: IL_3C
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: pop
    IL_005E: br IL_008D
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400030E
    IL_0065: conv.r8
    IL_0066: IL_E4
    IL_0067: IL_01
    IL_0068: nop
    IL_0069: ldloc.0
    IL_006A: ldarg.0
    IL_006F: ldfld 0x0400030E
    IL_0070: conv.r8
    IL_0071: IL_EA
    IL_0072: IL_01
    IL_0073: nop
    IL_0074: ldloc.0
    IL_0075: ldarg.0
    IL_0076: ldc.i4.2
    IL_007B: stfld 0x040002BC
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000349
    IL_0086: ldstr 0x7000151F
    IL_0087: conv.r8
    IL_0088: IL_3C
    IL_0089: nop
    IL_008A: nop
    IL_008B: stloc.0
    IL_008C: pop
    IL_008D: ldarg.0
    IL_008E: ldarg.1
    IL_0093: stfld 0x0400033B
    IL_0094: ldarg.0
    IL_0095: ldarg.2
    IL_009A: stfld 0x040002B2
    IL_009B: ldarg.0
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x0400033B
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000338
    IL_00A8: conv.r8
    IL_00A9: ldc.i4.2
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: stloc.0
    IL_00B1: call 0x0A000019
    IL_00B6: stfld 0x0400029D
    IL_00B7: ret
    }

    public void GateEnter() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000338
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400033B
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000338
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000019
    IL_001C: conv.r8
    IL_0021: ldc.i4 34209792
    IL_0022: ldc.i4.0
    IL_0027: stfld 0x040002B1
    IL_0028: ldarg.0
    IL_0029: ldc.i4.1
    IL_002E: stfld 0x040002B5
    IL_002F: ldarg.0
    IL_0030: ldarg.1
    IL_0035: stfld 0x0400033B
    IL_0036: ret
    }

    public void RideHorse() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000325
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000349
    IL_000D: conv.r8
    IL_0010: ldloc 0
    IL_0011: stloc.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000349
    IL_001C: ldstr 0x700012E3
    IL_001D: conv.r8
    IL_001E: IL_3C
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: pop
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000349
    IL_002D: ldstr 0x700012D7
    IL_002E: conv.r8
    IL_0033: newobj 0x0A0A0000
    IL_0034: ldloc.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: conv.r8
    IL_003C: bgt.s IL_003D
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0040: IL_22
    IL_0041: IL_CD
    IL_0042: IL_CC
    IL_0043: IL_4C
    IL_0044: IL_3F
    IL_0049: stfld 0x040002E7
    IL_004A: ret
    }

    public void MaxCombo() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000366
    IL_0007: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.8
    IL_0310: switch (192 cases)
    }

    public void AttackOn() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000357
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: ldarg.0
    IL_000E: ldfld 0x04000338
    IL_000F: conv.r8
    IL_0010: ldc.i4.2
    IL_0011: nop
    IL_0012: nop
    IL_0013: stloc.0
    IL_0018: call 0x0A000019
    IL_001D: stfld 0x0400029F
    IL_001E: ldarg.0
    IL_0023: ldflda 0x0400029F
    IL_0024: ldc.i4.1
    IL_0025: IL_22
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002E: call 0x0A00001A
    IL_002F: ldarg.0
    IL_0030: ldarg.0
    IL_0035: ldflda 0x0400029F
    IL_003A: call 0x0A00006B
    IL_003F: stfld 0x040002A2
    IL_0040: ldarg.0
    IL_0041: ldarg.0
    IL_0046: ldfld 0x0400029F
    IL_0047: ldarg.0
    IL_004C: ldfld 0x040002A2
    IL_0051: call 0x0A00006C
    IL_0056: stfld 0x0400029F
    IL_0057: ldarg.0
    IL_0058: ldarg.0
    IL_005D: ldfld 0x0400029F
    IL_005E: ldarg.0
    IL_0063: ldfld 0x0400029D
    IL_0068: call 0x0A000113
    IL_006D: stfld 0x0400034C
    IL_006E: ldarg.0
    IL_0073: ldfld 0x040002A2
    IL_0074: IL_22
    IL_0075: IL_CD
    IL_0076: IL_CC
    IL_0077: IL_4C
    IL_0078: IL_3E
    IL_0079: IL_43
    IL_007A: ret
    IL_007B: nop
    IL_007C: nop
    IL_007D: nop
    IL_007E: ldarg.0
    IL_0083: ldfld 0x0400034C
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_0087: nop
    IL_0088: IL_3F
    IL_0089: IL_41
    IL_008A: ldc.i4.m1
    IL_008B: nop
    IL_008C: nop
    IL_008D: nop
    IL_008E: ldarg.0
    IL_0090: ldc.i4.s 17
    IL_0095: stfld 0x040002BC
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000342
    IL_009C: ldc.i4.1
    IL_009D: conv.r8
    IL_009F: ldc.i4.s 0
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: ret
    IL_00A7: br IL_00CD
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x0400034C
    IL_00AE: IL_22
    IL_00AF: IL_CD
    IL_00B0: IL_CC
    IL_00B1: IL_4C
    IL_00B2: IL_BE
    IL_00B3: IL_41
    IL_00B4: ldc.i4.m1
    IL_00B5: nop
    IL_00B6: nop
    IL_00B7: nop
    IL_00B8: ldarg.0
    IL_00BA: ldc.i4.s 17
    IL_00BF: stfld 0x040002BC
    IL_00C0: ldarg.0
    IL_00C5: ldfld 0x04000342
    IL_00C6: ldc.i4.1
    IL_00C7: conv.r8
    IL_00C9: ldc.i4.s 0
    IL_00CA: nop
    IL_00CB: stloc.0
    IL_00CC: ret
    IL_00CD: ldarg.0
    IL_00CE: ldc.i4.1
    IL_00D3: call 0x06000177
    IL_00D4: ldarg.0
    IL_00D5: IL_22
    IL_00D6: shr
    IL_00D7: shr
    IL_00DC: isinst 0x02A47D40
    IL_00DD: nop
    IL_00DE: ldarg.2
    IL_00DF: ldarg.0
    IL_00E4: ldfld 0x040002BC
    IL_00E5: ldc.i4.3
    IL_0146: switch (23 cases)
    IL_014B: ldfld 0x04000356
    IL_0150: stfld 0x040002A6
    IL_0151: ldc.i4.0
    IL_0152: ldc.i4.5
    IL_0157: call 0x0A000045
    IL_0158: stloc.0
    IL_0159: ldloc.0
    IL_015A: ldc.i4.2
    IL_015B: IL_3C
    IL_015C: IL_41
    IL_015D: nop
    IL_015E: nop
    IL_015F: nop
    IL_0160: ldarg.0
    IL_0165: ldfld 0x04000302
    IL_016A: brtrue IL_0183
    IL_016B: ldarg.0
    IL_0170: ldfld 0x04000300
    IL_0171: ldarg.0
    IL_0176: ldfld 0x040002F0
    IL_0177: ldloc.0
    IL_0178: ldelem.i
    IL_0179: conv.r8
    IL_017A: IL_4C
    IL_017B: nop
    IL_017C: nop
    IL_017D: stloc.0
    IL_0182: br IL_0196
    IL_0183: ldarg.0
    IL_0188: ldfld 0x04000300
    IL_0189: ldarg.0
    IL_018E: ldfld 0x040002F2
    IL_018F: ldloc.0
    IL_0190: ldelem.i
    IL_0191: conv.r8
    IL_0192: IL_4C
    IL_0193: nop
    IL_0194: nop
    IL_0195: stloc.0
    IL_0196: ldarg.0
    IL_019B: ldfld 0x04000300
    IL_019C: conv.r8
    IL_019D: IL_4D
    IL_019E: nop
    IL_019F: nop
    IL_01A0: stloc.0
    IL_01A1: ldarg.0
    IL_01A6: ldfld 0x04000338
    IL_01A7: ldarg.0
    IL_01AC: ldfld 0x0400029F
    IL_01B1: call 0x0A00001D
    IL_01B2: conv.r8
    IL_01B7: call 0x020A0000
    IL_01B8: ldc.i4.0
    IL_01BD: call 0x0600017A
    IL_01BE: ldarg.0
    IL_01C3: ldfld 0x040002A6
    IL_01C4: stloc.1
    IL_01C5: ldloc.1
    IL_01C6: ldc.i4.1
    IL_01C7: IL_58
    IL_01CA: ldarg 56
    IL_01CB: nop
    IL_01CC: nop
    IL_01CD: ldarg.3
    IL_01CE: nop
    IL_01CF: nop
    IL_01D0: nop
    IL_01D1: ldc.i4.m1
    IL_01D2: IL_01
    IL_01D3: nop
    IL_01D4: nop
    IL_01D5: IL_E7
    IL_01D6: IL_01
    IL_01D7: nop
    IL_01D8: nop
    IL_01D9: IL_C0
    IL_01DA: ldarg.0
    IL_01DB: nop
    IL_01DC: nop
    IL_01DD: IL_92
    IL_01DE: ldarg.1
    IL_01DF: nop
    IL_01E0: nop
    IL_01E1: ldc.i4.6
    IL_01E2: ldarg.2
    IL_01E3: nop
    IL_01E4: nop
    IL_01E5: IL_E1
    IL_01E6: ldc.i4.m1
    IL_01E7: nop
    IL_01E8: nop
    IL_01E9: IL_E1
    IL_01EA: ldc.i4.m1
    IL_01EB: nop
    IL_01EC: nop
    IL_01ED: IL_E1
    IL_01EE: ldc.i4.m1
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: IL_E1
    IL_01F2: ldc.i4.m1
    IL_01F3: nop
    IL_01F4: nop
    IL_01F5: IL_E1
    IL_01F6: ldc.i4.m1
    IL_01F7: nop
    IL_01F8: nop
    IL_01F9: ldelem.i2
    IL_01FA: ldarg.2
    IL_01FB: nop
    IL_01FC: nop
    IL_01FD: IL_D5
    IL_01FE: ldarg.3
    IL_01FF: nop
    IL_0200: nop
    IL_0202: ldarg.s 7
    IL_0203: nop
    IL_0204: nop
    IL_0205: IL_37
    IL_0206: ldloc.2
    IL_0207: nop
    IL_0208: nop
    IL_0209: ldloc.3
    IL_020A: ldloc.3
    IL_020B: nop
    IL_020C: nop
    IL_020D: IL_E1
    IL_020E: ldc.i4.m1
    IL_020F: nop
    IL_0210: nop
    IL_0211: IL_E1
    IL_0212: ldc.i4.m1
    IL_0213: nop
    IL_0214: nop
    IL_0215: IL_E1
    IL_0216: ldc.i4.m1
    IL_0217: nop
    IL_0218: nop
    IL_0219: IL_E1
    IL_021A: ldc.i4.m1
    IL_021B: nop
    IL_021C: nop
    IL_021D: IL_E1
    IL_021E: ldc.i4.m1
    IL_021F: nop
    IL_0220: nop
    IL_0222: blt.s IL_022D
    IL_0223: nop
    IL_0224: nop
    IL_0225: IL_FC
    IL_0226: stloc.0
    IL_0227: nop
    IL_0228: nop
    IL_0229: IL_F2
    IL_022A: stloc.1
    IL_022B: nop
    IL_022C: nop
    IL_022D: IL_C5
    IL_022E: stloc.2
    IL_022F: nop
    IL_0230: nop
    IL_0231: ldelem.i8
    IL_0232: stloc.3
    IL_0233: nop
    IL_0234: nop
    IL_0235: IL_E1
    IL_0236: ldc.i4.m1
    IL_0237: nop
    IL_0238: nop
    IL_0239: IL_E1
    IL_023A: ldc.i4.m1
    IL_023B: nop
    IL_023C: nop
    IL_023D: IL_E1
    IL_023E: ldc.i4.m1
    IL_023F: nop
    IL_0240: nop
    IL_0241: IL_E1
    IL_0242: ldc.i4.m1
    IL_0243: nop
    IL_0244: nop
    IL_0245: IL_E1
    IL_0246: ldc.i4.m1
    IL_0247: nop
    IL_0248: nop
    IL_024A: brtrue.s IL_0259
    IL_024B: nop
    IL_024C: nop
    IL_024D: IL_B0
    IL_024F: ldarg.s 0
    IL_0250: nop
    IL_0252: bne.un.s IL_0262
    IL_0253: nop
    IL_0254: nop
    IL_0255: IL_BD
    IL_0257: ldarga.s 0
    IL_0258: nop
    IL_025B: starg 16
    IL_025C: nop
    IL_025D: IL_E1
    IL_025E: ldc.i4.m1
    IL_025F: nop
    IL_0260: nop
    IL_0261: IL_E1
    IL_0262: ldc.i4.m1
    IL_0263: nop
    IL_0264: nop
    IL_0265: IL_E1
    IL_0266: ldc.i4.m1
    IL_0267: nop
    IL_0268: nop
    IL_0269: IL_E1
    IL_026A: ldc.i4.m1
    IL_026B: nop
    IL_026C: nop
    IL_026D: IL_E1
    IL_026E: ldc.i4.m1
    IL_026F: nop
    IL_0270: nop
    IL_0271: ldelem.i8
    IL_0273: starg.s 0
    IL_0274: nop
    IL_0279: beq IL_-30FFFD75
    IL_027B: ldloc.s 0
    IL_027C: nop
    IL_027D: conv.i4
    IL_027F: ldloca.s 0
    IL_0280: nop
    IL_0282: ldloc.s 19
    IL_0283: nop
    IL_0284: nop
    IL_0285: IL_E1
    IL_0286: ldc.i4.m1
    IL_0287: nop
    IL_0288: nop
    IL_0289: IL_E1
    IL_028A: ldc.i4.m1
    IL_028B: nop
    IL_028C: nop
    IL_028D: IL_E1
    IL_028E: ldc.i4.m1
    IL_028F: nop
    IL_0290: nop
    IL_0291: IL_E1
    IL_0292: ldc.i4.m1
    IL_0293: nop
    IL_0294: nop
    IL_0295: IL_E1
    IL_0296: ldc.i4.m1
    IL_0297: nop
    IL_0298: nop
    IL_0299: IL_85
    IL_029B: stloc.s 0
    IL_029C: nop
    IL_029D: ldloc.2
    IL_029E: ldnull
    IL_029F: nop
    IL_02A0: nop
    IL_02A1: stind.i
    IL_02A2: ldnull
    IL_02A3: nop
    IL_02A4: nop
    IL_02A6: ldarg.s 21
    IL_02A7: nop
    IL_02A8: nop
    IL_02A9: IL_91
    IL_02AA: ldc.i4.m1
    IL_02AB: nop
    IL_02AC: nop
    IL_02B1: br IL_188E
    IL_02B2: ldarg.0
    IL_02B4: ldc.i4.s 19
    IL_02B9: stfld 0x040002BC
    IL_02BA: ldarg.0
    IL_02BB: IL_22
    IL_02BC: nop
    IL_02BD: nop
    IL_02BE: nop
    IL_02BF: nop
    IL_02C4: stfld 0x040002B6
    IL_02C5: ldarg.0
    IL_02CA: ldfld 0x04000349
    IL_02CF: ldstr 0x70001229
    IL_02D0: conv.r8
    IL_02D1: IL_3C
    IL_02D2: nop
    IL_02D3: nop
    IL_02D4: stloc.0
    IL_02D5: pop
    IL_02D6: ldarg.0
    IL_02D7: ldarg.0
    IL_02DC: ldfld 0x04000349
    IL_02E1: ldstr 0x7000154B
    IL_02E2: ldc.i4.0
    IL_02E3: conv.r8
    IL_02E4: IL_53
    IL_02E5: nop
    IL_02E6: nop
    IL_02E7: stloc.0
    IL_02EC: stfld 0x04000348
    IL_02ED: ldarg.0
    IL_02F2: ldfld 0x04000348
    IL_02F3: IL_22
    IL_02F4: IL_8F
    IL_02F5: IL_C2
    IL_02F6: conv.u8
    IL_02F7: IL_3E
    IL_02F8: conv.r8
    IL_02FA: bgt.s IL_02FB
    IL_02FB: nop
    IL_02FC: stloc.0
    IL_02FD: ldarg.0
    IL_0302: ldfld 0x04000348
    IL_0303: ldc.i4.1
    IL_0304: conv.r8
    IL_0306: ble.s IL_0307
    IL_0307: nop
    IL_0308: stloc.0
    IL_0309: ldarg.0
    IL_030E: ldfld 0x040002FE
    IL_0313: call 0x0A00004B
    IL_0314: IL_22
    IL_0315: ldelem.i
    IL_0316: IL_99
    IL_0317: ldc.i4.3
    IL_23BC: switch (2088 cases)
    }

    public void FireSplash() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400030A
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
    IL_0016: ldfld 0x0400030A
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000338
    IL_001D: conv.r8
    IL_001E: ldc.i4.2
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000338
    IL_0028: conv.r8
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: IL_22
    IL_002E: IL_CD
    IL_002F: IL_CC
    IL_0030: IL_CC
    IL_0031: IL_3E
    IL_0036: call 0x0A000008
    IL_003B: call 0x0A000029
    IL_003C: conv.r8
    IL_003D: ldloc.3
    IL_003E: nop
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: ret
    }

    public void Arrow_shoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002DF
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000338
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: call 0x0A000007
    IL_0016: IL_22
    IL_0017: IL_CD
    IL_0018: IL_CC
    IL_0019: IL_4C
    IL_001A: IL_3D
    IL_001F: call 0x0A000008
    IL_0024: call 0x0A000029
    IL_0025: conv.r8
    IL_0026: ldloc.3
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040002DF
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000338
    IL_0036: conv.r8
    IL_0037: pop
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: conv.r8
    IL_0040: call 0x020A0000
    IL_0045: ldfld 0x040002DF
    IL_0046: conv.r8
    IL_0047: stloc.0
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: ldc.i4.1
    IL_004C: conv.r8
    IL_004D: stloc.1
    IL_004E: nop
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: ret
    }

    public void Magic_shoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400030D
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000338
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: call 0x0A000007
    IL_0016: IL_22
    IL_0017: IL_CD
    IL_0018: IL_CC
    IL_0019: IL_4C
    IL_001A: IL_3D
    IL_001F: call 0x0A000008
    IL_0024: call 0x0A000029
    IL_0025: conv.r8
    IL_0026: ldloc.3
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x0400030D
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000338
    IL_0036: conv.r8
    IL_0037: pop
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: conv.r8
    IL_0040: call 0x020A0000
    IL_0045: ldfld 0x0400030D
    IL_0046: conv.r8
    IL_0047: stloc.0
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: ldc.i4.1
    IL_004C: conv.r8
    IL_004D: stloc.1
    IL_004E: nop
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: ret
    }

    public void Attack_spear() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002BC
    IL_000A: ldc.i4 212
    IL_0883: switch (541 cases)
    }

    public void Attack_arrow() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002BC
    IL_000A: ldc.i4 203
    IL_0497: switch (290 cases)
    }

    public void Grab() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_0007: ldc.i4.1
    IL_000C: stfld 0x04000324
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400030F
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000336
    IL_0019: ldc.i4.0
    IL_001A: IL_22
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: conv.r8
    IL_0021: beq.s IL_0023
    IL_0022: nop
    IL_0023: ldloc.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000349
    IL_002A: conv.r8
    IL_002D: ldloc 0
    IL_002E: stloc.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000342
    IL_0035: ldc.i4.0
    IL_0036: conv.r8
    IL_0038: ldc.i4.s 0
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ldarg.0
    IL_003C: IL_22
    IL_003D: nop
    IL_003E: nop
    IL_0041: ldloc 10434
    IL_0042: IL_98
    IL_0043: IL_01
    IL_0044: nop
    IL_0045: ldloc.0
    IL_0046: ldarg.0
    IL_004B: ldfld 0x04000329
    IL_0050: brtrue IL_0061
    IL_0051: ldarg.0
    IL_0056: ldfld 0x0400031F
    IL_0057: IL_22
    IL_0058: IL_CD
    IL_0059: IL_CC
    IL_005A: IL_CC
    IL_005B: IL_3D
    IL_005C: conv.r8
    IL_005E: stloc.s 6
    IL_005F: nop
    IL_0060: ldloc.0
    IL_0061: ldarg.0
    IL_0063: ldc.i4.s 112
    IL_0068: stfld 0x040002BC
    IL_0069: ldarg.2
    IL_006A: ldarg.0
    IL_006F: ldfld 0x04000338
    IL_0070: conv.r8
    IL_0071: ldc.i4.2
    IL_0072: nop
    IL_0073: nop
    IL_0074: stloc.0
    IL_0079: call 0x0A000019
    IL_007A: stloc.1
    IL_007B: ldloc.1
    IL_0080: call 0x0A00001B
    IL_0085: call 0x0A00001C
    IL_008A: brfalse IL_00AE
    IL_008B: ldarg.0
    IL_0090: ldfld 0x04000338
    IL_0092: ldloca.s 1
    IL_0097: ldfld 0x0A00005E
    IL_0098: IL_22
    IL_0099: nop
    IL_009A: nop
    IL_009B: nop
    IL_009C: nop
    IL_009E: ldloca.s 1
    IL_00A3: ldfld 0x0A00005C
    IL_00A8: newobj 0x0A000076
    IL_00A9: conv.r8
    IL_00AE: ldc.i4 34209792
    IL_00B3: call 0x0600016D
    IL_00B4: ldarg.1
    IL_00B5: stloc.2
    IL_00B6: ldloc.2
    IL_00B9: ldarg 7
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: ldarg.3
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: IL_8F
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: ldc.i4.3
    IL_00C5: IL_01
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: stelem.i
    IL_00C9: IL_01
    IL_00CA: nop
    IL_00CB: nop
    IL_00CD: brtrue.s IL_00D0
    IL_00CE: nop
    IL_00CF: nop
    IL_00D0: IL_B7
    IL_00D1: ldarg.0
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: IL_41
    IL_00D5: ldarg.1
    IL_00D6: nop
    IL_00D7: nop
    IL_00DC: br IL_04A3
    IL_00DD: IL_22
    IL_00DE: IL_CD
    IL_00DF: IL_CC
    IL_00E0: IL_CC
    IL_00E1: IL_3F
    IL_00E2: stloc.0
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000349
    IL_00ED: ldstr 0x70000F7B
    IL_00EE: conv.r8
    IL_00EF: IL_3C
    IL_00F0: nop
    IL_00F1: nop
    IL_00F2: stloc.0
    IL_00F3: pop
    IL_00F4: ldarg.0
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x04000349
    IL_00FF: ldstr 0x70000F89
    IL_0100: ldc.i4.0
    IL_0101: conv.r8
    IL_0102: IL_53
    IL_0103: nop
    IL_0104: nop
    IL_0105: stloc.0
    IL_010A: stfld 0x04000344
    IL_010B: ldarg.0
    IL_0110: ldfld 0x04000344
    IL_0111: ldarg.0
    IL_0116: ldfld 0x04000349
    IL_011B: ldstr 0x70000F89
    IL_011C: conv.r8
    IL_011E: bge.s IL_011F
    IL_011F: nop
    IL_0120: stloc.0
    IL_0121: conv.r8
    IL_0122: IL_54
    IL_0123: nop
    IL_0124: nop
    IL_0125: stloc.0
    IL_0126: conv.r8
    IL_0128: bgt.s IL_0129
    IL_0129: nop
    IL_012A: stloc.0
    IL_012B: ldarg.0
    IL_012C: ldarg.0
    IL_0131: ldfld 0x04000349
    IL_0136: ldstr 0x70000FA5
    IL_0137: ldc.i4.0
    IL_0138: conv.r8
    IL_0139: IL_53
    IL_013A: nop
    IL_013B: nop
    IL_013C: stloc.0
    IL_0141: stfld 0x04000344
    IL_0142: ldarg.0
    IL_0147: ldfld 0x04000344
    IL_0148: ldarg.0
    IL_014D: ldfld 0x04000349
    IL_0152: ldstr 0x70000FA5
    IL_0153: conv.r8
    IL_0155: bge.s IL_0156
    IL_0156: nop
    IL_0157: stloc.0
    IL_0158: conv.r8
    IL_0159: IL_54
    IL_015A: nop
    IL_015B: nop
    IL_015C: stloc.0
    IL_015D: conv.r8
    IL_015F: bgt.s IL_0160
    IL_0160: nop
    IL_0161: stloc.0
    IL_0166: br IL_04A3
    IL_0167: IL_22
    IL_0168: IL_CD
    IL_0169: IL_CC
    IL_016A: IL_CC
    IL_016B: IL_3F
    IL_016C: stloc.0
    IL_016D: ldarg.0
    IL_0172: ldfld 0x04000349
    IL_0177: ldstr 0x70000FC3
    IL_0178: conv.r8
    IL_0179: IL_3C
    IL_017A: nop
    IL_017B: nop
    IL_017C: stloc.0
    IL_017D: pop
    IL_017E: ldarg.0
    IL_017F: ldarg.0
    IL_0184: ldfld 0x04000349
    IL_0189: ldstr 0x70000FD1
    IL_018A: ldc.i4.0
    IL_018B: conv.r8
    IL_018C: IL_53
    IL_018D: nop
    IL_018E: nop
    IL_018F: stloc.0
    IL_0194: stfld 0x04000344
    IL_0195: ldarg.0
    IL_019A: ldfld 0x04000344
    IL_019B: ldarg.0
    IL_01A0: ldfld 0x04000349
    IL_01A5: ldstr 0x70000FD1
    IL_01A6: conv.r8
    IL_01A8: bge.s IL_01A9
    IL_01A9: nop
    IL_01AA: stloc.0
    IL_01AB: conv.r8
    IL_01AC: IL_54
    IL_01AD: nop
    IL_01AE: nop
    IL_01AF: stloc.0
    IL_01B0: conv.r8
    IL_01B2: bgt.s IL_01B3
    IL_01B3: nop
    IL_01B4: stloc.0
    IL_01B5: ldarg.0
    IL_01B6: ldarg.0
    IL_01BB: ldfld 0x04000349
    IL_01C0: ldstr 0x70000FED
    IL_01C1: ldc.i4.0
    IL_01C2: conv.r8
    IL_01C3: IL_53
    IL_01C4: nop
    IL_01C5: nop
    IL_01C6: stloc.0
    IL_01CB: stfld 0x04000344
    IL_01CC: ldarg.0
    IL_01D1: ldfld 0x04000344
    IL_01D2: ldarg.0
    IL_01D7: ldfld 0x04000349
    IL_01DC: ldstr 0x70000FED
    IL_01DD: conv.r8
    IL_01DF: bge.s IL_01E0
    IL_01E0: nop
    IL_01E1: stloc.0
    IL_01E2: conv.r8
    IL_01E3: IL_54
    IL_01E4: nop
    IL_01E5: nop
    IL_01E6: stloc.0
    IL_01E7: conv.r8
    IL_01E9: bgt.s IL_01EA
    IL_01EA: nop
    IL_01EB: stloc.0
    IL_01F0: br IL_04A3
    IL_01F1: IL_22
    IL_01F2: nop
    IL_01F3: nop
    IL_01F4: nop
    IL_125EC0A21: switch (1232798218 cases)
    }

    public void Grabfinish() {
    IL_0001: ldarga.s 1
    IL_0002: IL_22
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_0006: nop
    IL_000B: stfld 0x0A000023
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000338
    IL_0012: ldarg.0
    IL_0017: call 0x0A000002
    IL_0018: conv.r8
    IL_0019: ldc.i4.2
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.1
    IL_0022: call 0x0A000024
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_002A: cpobj 0x63285A41
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: conv.r8
    IL_002F: ldloc.3
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000338
    IL_003A: ldarga.s 2
    IL_003F: ldfld 0x0A00005E
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0046: ldarga.s 2
    IL_004B: ldfld 0x0A00005C
    IL_0050: newobj 0x0A000076
    IL_0055: call 0x0A000043
    IL_0056: conv.r8
    IL_005B: ldc.i4 705298432
    }

    private void StepOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002BC
    IL_0007: ldc.i4.s 10
    IL_0008: IL_3D
    IL_0009: ldc.i4.6
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000300
    IL_0013: ldarg.0
    IL_0018: ldfld 0x040002F4
    IL_0019: conv.r8
    IL_001A: IL_4C
    IL_001B: nop
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000300
    IL_0024: conv.r8
    IL_0025: IL_4D
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: ret
    }

    public void SkillStart() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000326
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000300
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040002F9
    IL_0013: conv.r8
    IL_0014: ldind.ref
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000302
    IL_0022: brtrue IL_003B
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000300
    IL_0029: ldarg.0
    IL_002E: ldfld 0x040002F1
    IL_002F: ldc.i4.1
    IL_0030: ldelem.i
    IL_0031: conv.r8
    IL_0032: ldind.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_003A: br IL_004E
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000300
    IL_0041: ldarg.0
    IL_0046: ldfld 0x040002F3
    IL_0047: ldc.i4.0
    IL_0048: ldelem.i
    IL_0049: conv.r8
    IL_004A: ldind.ref
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ret
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000321
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040002BC
    IL_0013: ldc.i4.s 50
    IL_0014: IL_3E
    IL_0015: IL_01
    IL_0016: nop
    IL_0017: nop
    IL_0018: nop
    IL_0019: ret
    IL_001A: ldc.i4.0
    IL_001C: ldc.i4.s 100
    IL_0021: call 0x0A000045
    IL_0022: stloc.0
    IL_0023: ldarg.0
    IL_0025: ldarga.s 1
    IL_002A: ldfld 0x0A000023
    IL_002B: not
    IL_0030: stfld 0x040002AB
    IL_0032: ldarga.s 1
    IL_0033: ldc.i4.1
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_003D: call 0x0A00001A
    IL_003E: ldarg.0
    IL_0043: ldfld 0x040002C1
    IL_0044: ldloc.0
    IL_0045: IL_3F
    IL_0046: ldelem.i1
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040002BC
    IL_0050: ldc.i4.0
    IL_0051: IL_3F
    IL_0052: IL_8F
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldarg.0
    IL_0057: ldc.i4.m1
    IL_005C: stfld 0x040002BC
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000312
    IL_0063: ldc.i4.1
    IL_0064: conv.r8
    IL_0065: IL_CD
    IL_0066: ldarg.3
    IL_0067: nop
    IL_0068: ldloc.0
    IL_0069: ldarg.0
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_0071: stsfld 0x0191283F
    IL_0072: nop
    IL_0073: ldloc.0
    IL_0074: ldarg.1
    IL_0079: call 0x0A00001B
    IL_007E: call 0x0A00001C
    IL_0083: brfalse IL_0095
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000338
    IL_008A: ldarg.1
    IL_008F: call 0x0A00001D
    IL_0090: conv.r8
    IL_0095: call 0x020A0000
    IL_009A: ldfld 0x04000341
    IL_009B: ldarg.1
    IL_009C: IL_22
    IL_009D: nop
    IL_009E: nop
    IL_009F: stloc.2
    IL_00A0: IL_43
    IL_00A5: call 0x0A000008
    IL_00A6: conv.r8
    IL_00A7: IL_3E
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x0400030F
    IL_00B1: ldc.i4.5
    IL_00B3: ldc.i4.s 22
    IL_00B4: IL_22
    IL_00B5: IL_CD
    IL_00B6: IL_CC
    IL_00B7: IL_4C
    IL_00B8: IL_3E
    IL_00B9: conv.r8
    IL_00BA: IL_34
    IL_00BB: IL_01
    IL_00BC: nop
    IL_00BD: ldloc.0
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x04000349
    IL_00C8: ldstr 0x700012B7
    IL_00C9: conv.r8
    IL_00CA: IL_3C
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: stloc.0
    IL_00CE: pop
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x04000349
    IL_00D9: ldstr 0x700001C1
    IL_00DA: conv.r8
    IL_00DF: newobj 0x260A0000
    IL_00E4: br IL_0316
    IL_00E5: ldarg.0
    IL_00E6: ldc.i4.m1
    IL_00EB: stfld 0x040002BC
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x040002BA
    IL_00F2: conv.r8
    IL_00F3: stloc.0
    IL_00F4: nop
    IL_00F5: nop
    IL_00F6: stloc.0
    IL_00F7: ldc.i4.1
    IL_00F8: conv.r8
    IL_00F9: stloc.1
    IL_00FA: nop
    IL_00FB: nop
    IL_00FC: stloc.0
    IL_00FD: ldarg.0
    IL_0102: ldfld 0x04000360
    IL_0103: ldc.i4.2
    IL_0148: switch (16 cases)
    IL_0149: nop
    IL_014A: ldarg.2
    IL_014F: stfld 0x040002C7
    IL_0154: br IL_0197
    IL_0155: ldarg.0
    IL_0156: ldarg.0
    IL_015B: ldfld 0x040002C8
    IL_015C: ldc.i4.1
    IL_015D: ldarg.0
    IL_0162: ldfld 0x040002AB
    IL_0163: ldarg.0
    IL_0168: ldfld 0x040002BE
    IL_0169: IL_59
    IL_016E: call 0x0A000080
    IL_016F: IL_59
    IL_0174: stfld 0x040002C8
    IL_0175: ldarg.0
    IL_0176: ldarg.0
    IL_017B: ldfld 0x040002C8
    IL_0180: stfld 0x040002C7
    IL_0181: ldarg.0
    IL_0186: ldfld 0x04000358
    IL_018B: brfalse IL_0197
    IL_018C: ldarg.0
    IL_0191: ldfld 0x0400031F
    IL_0192: conv.r8
    IL_0197: call 0x16060006
    IL_0199: ldc.i4.s 100
    IL_019E: call 0x0A000045
    IL_019F: stloc.1
    IL_01A0: ldarg.0
    IL_01A5: ldfld 0x0400030F
    IL_01A6: ldc.i4.5
    IL_01A8: ldc.i4.s 22
    IL_01A9: IL_22
    IL_01AA: IL_CD
    IL_01AB: IL_CC
    IL_01AC: IL_4C
    IL_01AD: IL_3E
    IL_01AE: conv.r8
    IL_01AF: IL_34
    IL_01B0: IL_01
    IL_01B1: nop
    IL_01B2: ldloc.0
    IL_01B3: ldarg.0
    IL_01B8: ldfld 0x04000341
    IL_01B9: IL_22
    IL_01BA: nop
    IL_01BB: nop
    IL_01BC: nop
    IL_2137D: switch (33903 cases)
    }

    public void CancelAtk() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002B0
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_000A: ldarg 6
    IL_000B: nop
    IL_000C: nop
    IL_000D: ldarg.3
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0015: ldc.i4 989855744
    IL_0016: nop
    IL_0017: nop
    IL_0018: nop
    IL_0019: IL_56
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: shr
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0025: newobj 0x38000000
    IL_0026: IL_AD
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002A: ldarg.0
    IL_002F: ldfld 0x04000313
    IL_0030: conv.r8
    IL_0031: IL_C2
    IL_0032: ldarg.0
    IL_0033: nop
    IL_0034: ldloc.0
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000319
    IL_003B: conv.r8
    IL_003C: IL_C2
    IL_003D: ldarg.0
    IL_003E: nop
    IL_003F: ldloc.0
    IL_0044: br IL_00D7
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000313
    IL_004B: conv.r8
    IL_004C: IL_C2
    IL_004D: ldarg.0
    IL_004E: nop
    IL_004F: ldloc.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000314
    IL_0056: conv.r8
    IL_0057: IL_C2
    IL_0058: ldarg.0
    IL_0059: nop
    IL_005A: ldloc.0
    IL_005F: br IL_00D7
    IL_0060: ldarg.0
    IL_0065: ldfld 0x04000313
    IL_0066: conv.r8
    IL_0067: IL_C2
    IL_0068: ldarg.0
    IL_0069: nop
    IL_006A: ldloc.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x0400031A
    IL_0071: conv.r8
    IL_0072: IL_AE
    IL_0073: ldarg.0
    IL_0074: nop
    IL_0075: ldloc.0
    IL_007A: br IL_00D7
    IL_007B: ldarg.0
    IL_0080: ldstr 0x700015FB
    IL_0085: call 0x0A00007B
    IL_008A: br IL_00D7
    IL_008B: ldarg.0
    IL_0090: ldfld 0x04000319
    IL_0091: conv.r8
    IL_0092: IL_C2
    IL_0093: ldarg.0
    IL_0094: nop
    IL_0095: ldloc.0
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000311
    IL_009C: conv.r8
    IL_009D: IL_EA
    IL_009E: nop
    IL_009F: nop
    IL_00A0: ldloc.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x0400031A
    IL_00A7: conv.r8
    IL_00A8: IL_AE
    IL_00A9: ldarg.0
    IL_00AA: nop
    IL_00AB: ldloc.0
    IL_00B0: br IL_00D7
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x0400031A
    IL_00B7: conv.r8
    IL_00B8: IL_AE
    IL_00B9: ldarg.0
    IL_00BA: nop
    IL_00BB: ldloc.0
    IL_00BC: ldarg.0
    IL_00C1: ldstr 0x70001613
    IL_00C6: call 0x0A00007B
    IL_00C7: ldarg.0
    IL_00CC: ldstr 0x7000162B
    IL_00D1: call 0x0A00007B
    IL_00D6: br IL_00D7
    IL_00D7: ret
    }

    public void Blocked() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002BC
    IL_0006: ldc.i4.0
    IL_0007: IL_3F
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040002BB
    IL_0016: brfalse IL_0018
    IL_0017: ret
    IL_0018: ldarg.0
    IL_0019: ldc.i4.m1
    IL_001E: stfld 0x040002BC
    IL_001F: ldarg.0
    IL_0020: ldarg.1
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000338
    IL_0027: conv.r8
    IL_0028: ldc.i4.2
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A000019
    IL_0035: call 0x0A000040
    IL_003A: stfld 0x0400029D
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000338
    IL_0041: ldarg.0
    IL_0046: ldfld 0x0400029D
    IL_004B: call 0x0A00001D
    IL_004C: conv.r8
    IL_0051: call 0x020A0000
    IL_0056: ldfld 0x040002AF
    IL_0057: ldc.i4.0
    IL_0059: ldc.i4.s 100
    IL_005E: call 0x0A000045
    IL_005F: IL_3E
    IL_0064: newobj 0x02000000
    IL_0069: ldfld 0x0400031E
    IL_006A: ldc.i4.m1
    IL_006B: conv.r8
    IL_006C: IL_EC
    IL_006D: ldarg.2
    IL_006E: nop
    IL_006F: ldloc.0
    IL_0070: ldarg.0
    IL_0075: ldfld 0x04000307
    IL_0076: conv.r8
    IL_0077: stloc.0
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldc.i4.1
    IL_007C: conv.r8
    IL_007D: stloc.1
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ldarg.0
    IL_0086: ldfld 0x04000307
    IL_0087: ldarg.1
    IL_008C: call 0x0A000007
    IL_008D: IL_22
    IL_008E: IL_CD
    IL_008F: IL_CC
    IL_0090: IL_4C
    IL_0091: IL_3D
    IL_0096: call 0x0A000008
    IL_009B: call 0x0A000029
    IL_009C: conv.r8
    IL_009D: ldloc.3
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000306
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000338
    IL_00AD: conv.r8
    IL_00AE: pop
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: stloc.0
    IL_00B2: conv.r8
    IL_00B7: call 0x020A0000
    IL_00BC: ldfld 0x04000341
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x0400029D
    IL_00C3: IL_22
    IL_00C4: nop
    IL_00C5: nop
    IL_00CA: ldc.i4 534721
    IL_00CB: nop
    IL_00CC: stloc.0
    IL_00CD: conv.r8
    IL_00CE: IL_3E
    IL_00CF: nop
    IL_00D0: nop
    IL_00D1: stloc.0
    IL_00D6: br IL_0169
    IL_00D7: ldarg.0
    IL_00DC: ldfld 0x0400031E
    IL_00DD: ldc.i4.0
    IL_00DE: conv.r8
    IL_00DF: IL_EC
    IL_00E0: ldarg.2
    IL_00E1: nop
    IL_00E2: ldloc.0
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000306
    IL_00E9: conv.r8
    IL_00EA: stloc.0
    IL_00EB: nop
    IL_00EC: nop
    IL_00ED: stloc.0
    IL_00EE: ldc.i4.1
    IL_00EF: conv.r8
    IL_00F0: stloc.1
    IL_00F1: nop
    IL_00F2: nop
    IL_00F3: stloc.0
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x04000306
    IL_00FA: ldarg.0
    IL_00FF: ldfld 0x04000338
    IL_0100: conv.r8
    IL_0101: ldc.i4.2
    IL_0102: nop
    IL_0103: nop
    IL_0104: stloc.0
    IL_0105: conv.r8
    IL_0106: ldloc.3
    IL_0107: nop
    IL_0108: nop
    IL_0109: stloc.0
    IL_010A: ldarg.0
    IL_010F: ldfld 0x04000306
    IL_0110: ldarg.0
    IL_0115: ldfld 0x04000338
    IL_0116: conv.r8
    IL_0117: pop
    IL_0118: nop
    IL_0119: nop
    IL_011A: stloc.0
    IL_011B: conv.r8
    IL_0120: call 0x020A0000
    IL_0125: call 0x0600018D
    IL_0126: ldarg.0
    IL_012B: ldfld 0x04000312
    IL_012C: ldc.i4.3
    IL_012D: conv.r8
    IL_012E: IL_CD
    IL_012F: ldarg.3
    IL_0130: nop
    IL_0131: ldloc.0
    IL_0132: ldarg.0
    IL_0137: ldfld 0x04000349
    IL_0138: conv.r8
    IL_013B: ldloc 0
    IL_013C: stloc.0
    IL_013D: ldarg.0
    IL_0142: ldfld 0x04000349
    IL_0147: ldstr 0x70001325
    IL_0148: conv.r8
    IL_0149: IL_3C
    IL_014A: nop
    IL_014B: nop
    IL_014C: stloc.0
    IL_014D: pop
    IL_014E: ldarg.0
    IL_0153: ldfld 0x04000341
    IL_0154: ldarg.0
    IL_0159: ldfld 0x0400029D
    IL_015A: IL_22
    IL_015B: nop
    IL_015C: nop
    IL_015D: ldelem.r8
    IL_015E: IL_C2
    IL_0163: call 0x0A000008
    IL_0164: conv.r8
    IL_0165: IL_3E
    IL_0166: nop
    IL_0167: nop
    IL_0168: stloc.0
    IL_0169: ret
    }

    public void GetItem() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000317
    IL_0006: ldc.i4.4
    IL_0007: ldc.i4.4
    IL_0009: ldc.i4.s 20
    IL_000A: ldc.i4.0
    IL_000B: conv.r8
    IL_000C: IL_D7
    IL_000D: ldarg.0
    IL_000E: nop
    IL_000F: ldloc.0
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000300
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040002F5
    IL_001C: conv.r8
    IL_001D: ldind.ref
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldarg.1
    IL_0022: stloc.1
    IL_0023: ldloc.1
    IL_0026: ldarg 5
    IL_0027: nop
    IL_0028: nop
    IL_0029: ldarg.3
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: pop
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0031: IL_3D
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0035: and
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: IL_78
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_0041: br IL_00C6
    IL_0042: IL_22
    IL_0044: ldc.i4.s -123
    IL_0045: IL_AB
    IL_0046: IL_3F
    IL_0047: ldarg.2
    IL_0048: conv.i2
    IL_0049: IL_5A
    IL_004A: IL_22
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_829A1B2: switch (34236504 cases)
    }

    public void GainExp() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002EE
    IL_000A: ldc.i4 199
    IL_000B: IL_3F
    IL_000C: stloc.2
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_001A: stfld 0x040002EF
    IL_001B: ret
    IL_001C: ldarg.0
    IL_001D: dup
    IL_0022: ldfld 0x040002EF
    IL_0023: ldarg.1
    IL_0024: ldarg.0
    IL_0029: ldfld 0x040002B8
    IL_002A: IL_5A
    IL_002B: IL_58
    IL_0030: stfld 0x040002EF
    IL_0031: ldarg.0
    IL_0036: ldfld 0x040002EF
    IL_0037: ldarg.0
    IL_003C: ldfld 0x040002EE
    IL_003E: ldc.i4.s 100
    IL_003F: IL_5A
    IL_0040: conv.i2
    IL_0041: IL_43
    IL_0042: IL_53
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: ldarg.0
    IL_0047: dup
    IL_004C: ldfld 0x040002EE
    IL_004D: ldc.i4.1
    IL_004E: IL_58
    IL_0053: stfld 0x040002EE
    IL_0054: ldarg.0
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: nop
    IL_005E: stfld 0x040002EF
    IL_005F: ldarg.0
    IL_0060: dup
    IL_0065: ldfld 0x040002C9
    IL_0066: ldc.i4.5
    IL_0067: IL_58
    IL_006C: stfld 0x040002C9
    IL_0071: ldstr 0x70000DDD
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040002EE
    IL_007C: call 0x0600021F
    IL_0081: ldstr 0x7000052B
    IL_0082: ldc.i4.1
    IL_0087: call 0x0A00009F
    IL_008C: ldstr 0x70000DE5
    IL_008D: ldarg.0
    IL_0092: ldfld 0x040002EF
    IL_0093: not
    IL_0098: call 0x0600021F
    IL_0099: ret
    }

    public void Invincibility() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000352
    IL_000A: brfalse IL_001C
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400030C
    IL_0011: conv.r8
    IL_0012: stloc.0
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldc.i4.1
    IL_0017: conv.r8
    IL_0018: stloc.1
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_001D: ldc.i4.1
    IL_0022: stfld 0x04000321
    IL_0023: ldarg.0
    IL_0024: ldarg.1
    IL_0029: stfld 0x04000323
    IL_002A: ldarg.0
    IL_002F: ldc.i4 200
    IL_0034: stfld 0x040002BF
    IL_0035: ret
    }

    public void Heal() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002E1
    IL_0006: conv.r8
    IL_0007: IL_B0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: IL_B6
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: call 0x06000193
    IL_001C: call 0x0A000047
    IL_001D: pop
    IL_001E: ldarg.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040002C7
    IL_0025: ldarg.1
    IL_0026: IL_58
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040002CA
    IL_0031: call 0x0A00010B
    IL_0036: stfld 0x040002C7
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000302
    IL_0041: brfalse IL_0053
    IL_0042: ldarg.0
    IL_0043: ldarg.0
    IL_0048: ldfld 0x040002C7
    IL_004D: stfld 0x040002CB
    IL_0052: br IL_005F
    IL_0053: ldarg.0
    IL_0054: ldarg.0
    IL_0059: ldfld 0x040002C7
    IL_005E: stfld 0x040002C8
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000329
    IL_0069: brtrue IL_0086
    IL_006A: ldarg.0
    IL_006F: ldfld 0x0400031F
    IL_0070: ldarg.0
    IL_0075: ldfld 0x040002C7
    IL_0076: ldarg.0
    IL_007B: ldfld 0x040002CA
    IL_007C: conv.r8
    IL_007E: brfalse.s IL_0085
    IL_007F: nop
    IL_0080: ldloc.0
    IL_0085: br IL_00A3
    IL_0086: ldarg.0
    IL_008B: ldfld 0x04000320
    IL_008C: ldarg.0
    IL_0091: ldfld 0x040002C7
    IL_0092: ldarg.0
    IL_0097: ldfld 0x040002CA
    IL_0098: ldarg.0
    IL_009D: ldfld 0x040002D2
    IL_009E: conv.r8
    IL_009F: IL_3E
    IL_00A0: ldloc.0
    IL_00A1: nop
    IL_00A2: ldloc.0
    IL_00A3: ret
    }

    public void Sk_Heal() {
    IL_0004: newobj 0x0600073D
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001022
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void AttakUp() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040002C2
    IL_0007: ldarg.0
    IL_000C: ldfld 0x040002BD
    IL_000D: IL_58
    IL_000E: conv.i2
    IL_000F: IL_22
    IL_0010: nop
    IL_0011: nop
    IL_0012: nop
    IL_0013: IL_3F
    IL_0014: IL_5A
    IL_0015: ldarg.1
    IL_0016: IL_5A
    IL_0017: not
    IL_001C: stfld 0x040002BD
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040002BD
    IL_0024: ldc.i4.1
    IL_0025: IL_59
    IL_002A: stfld 0x040002C2
    IL_002B: ldarg.0
    IL_0030: ldc.i4 200
    IL_0035: stfld 0x040002BF
    IL_0036: ret
    }

    public void ResetAtk() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000302
    IL_000A: brtrue IL_0034
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040002D6
    IL_0016: stfld 0x040002BD
    IL_0017: ldarg.0
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040002D7
    IL_0022: stfld 0x040002C2
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x040002D8
    IL_002E: stfld 0x040002BF
    IL_0033: br IL_005C
    IL_0034: ldarg.0
    IL_0035: ldarg.0
    IL_003A: ldfld 0x040002CF
    IL_003F: stfld 0x040002BD
    IL_0040: ldarg.0
    IL_0041: ldarg.0
    IL_0046: ldfld 0x040002CF
    IL_0047: conv.i2
    IL_0048: IL_22
    IL_0049: IL_CD
    IL_004A: IL_CC
    IL_004B: IL_4C
    IL_004C: IL_3F
    IL_004D: IL_5A
    IL_004E: not
    IL_0053: stfld 0x040002C2
    IL_0054: ldarg.0
    IL_0056: ldc.i4.s 100
    IL_005B: stfld 0x040002BF
    IL_005C: ret
    }

    public void DefenceUp() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040002BE
    IL_0007: conv.i2
    IL_0008: IL_22
    IL_0009: ldelem.i
    IL_000A: IL_99
    IL_000B: ldc.i4.3
    IL_2F9F5A578: switch (3195890010 cases)
    }

    public void ResetDef() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040002D9
    IL_000B: stfld 0x040002BE
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040002DA
    IL_0017: stfld 0x040002C3
    IL_0018: ret
    }

    public void Spcharge() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040002D2
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_0009: ldarg.0
    IL_000E: ldfld 0x040002DD
    IL_0013: call 0x0A000114
    IL_0018: stfld 0x040002D2
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000329
    IL_0023: brtrue IL_003A
    IL_0024: ldarg.0
    IL_0029: ldfld 0x0400031F
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040002D2
    IL_0030: conv.r8
    IL_0032: br.s IL_0039
    IL_0033: nop
    IL_0034: ldloc.0
    IL_0039: br IL_0057
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000320
    IL_0040: ldarg.0
    IL_0045: ldfld 0x040002C7
    IL_0046: ldarg.0
    IL_004B: ldfld 0x040002CA
    IL_004C: ldarg.0
    IL_0051: ldfld 0x040002D2
    IL_0052: conv.r8
    IL_0053: IL_3E
    IL_0054: ldloc.0
    IL_0055: nop
    IL_0056: ldloc.0
    IL_0057: ret
    }

    public void KillEnemy() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040002AC
    IL_0006: ldc.i4.5
    IL_0047: switch (15 cases)
    }

    public void Exstart() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000302
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: call 0x0600018D
    IL_0012: ldarg.0
    IL_0017: call 0x0A00002B
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040002F1
    IL_001E: ldc.i4.0
    IL_001F: ldelem.i
    IL_0020: conv.r8
    IL_0021: IL_4C
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldarg.0
    IL_002A: call 0x0A00002B
    IL_002B: conv.r8
    IL_002C: IL_4D
    IL_002D: nop
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldarg.0
    IL_0031: ldc.i4.1
    IL_0036: stfld 0x040002B3
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000349
    IL_0041: ldstr 0x700011BD
    IL_0042: conv.r8
    IL_0043: IL_3C
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: pop
    IL_0048: ldarg.0
    IL_004D: ldfld 0x0400029D
    IL_0052: call 0x0A00001B
    IL_0057: call 0x0A00001C
    IL_005C: brfalse IL_006E
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000338
    IL_0063: ldarg.0
    IL_0068: ldfld 0x0400029D
    IL_0069: conv.r8
    IL_006E: ldc.i4 34209792
    IL_006F: IL_22
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: nop
    IL_0078: stfld 0x04000327
    IL_0079: ldarg.0
    IL_007A: ldc.i4.0
    IL_007F: stfld 0x04000328
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000329
    IL_008A: brtrue IL_009B
    IL_008B: ldarg.0
    IL_0090: ldfld 0x0400031F
    IL_0091: conv.r8
    IL_0096: ldc.i4 939917318
    IL_0097: stloc.1
    IL_0098: nop
    IL_0099: nop
    IL_009A: nop
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000320
    IL_00A1: conv.r8
    IL_00A6: beq IL_2A0600AD
    }

    public void Eximpact() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000316
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: ldc.i4.2
    IL_000C: ldc.i4.2
    IL_000E: ldc.i4.s 20
    IL_000F: ldc.i4.1
    IL_0010: ldc.i4.0
    IL_0011: conv.r8
    IL_0012: IL_C1
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: ldloc.0
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000349
    IL_0020: ldstr 0x700011D1
    IL_0021: conv.r8
    IL_0022: IL_3C
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: pop
    IL_0027: ldarg.0
    IL_0028: ldc.i4.0
    IL_002D: stfld 0x040002B3
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000300
    IL_0034: ldarg.0
    IL_0039: ldfld 0x040002F6
    IL_003A: conv.r8
    IL_003B: IL_4C
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000300
    IL_0045: conv.r8
    IL_0046: IL_4D
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000341
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000338
    IL_0056: conv.r8
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: IL_22
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_F0
    IL_005F: IL_41
    IL_0064: call 0x0A000008
    IL_0065: conv.r8
    IL_0066: IL_3E
    IL_0067: nop
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: ldarg.0
    IL_006B: ldc.i4.0
    IL_0070: stfld 0x0400034F
    IL_0071: ldarg.0
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04000339
    IL_007C: stfld 0x0400033A
    IL_007D: ret
    }

    public void ResetPower() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000302
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040002B3
    IL_0016: brfalse IL_0076
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000329
    IL_0021: brtrue IL_0032
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400031F
    IL_0028: conv.r8
    IL_002A: ldc.i4.s 6
    IL_002B: nop
    IL_002C: ldloc.0
    IL_0031: br IL_003D
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000320
    IL_0038: conv.r8
    IL_003D: brtrue IL_2060044
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0047: stfld 0x040002B6
    IL_0048: ldarg.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000339
    IL_0053: stfld 0x0400033A
    IL_0054: ldarg.0
    IL_0055: ldc.i4.0
    IL_005A: stfld 0x040002B3
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000316
    IL_0061: conv.r8
    IL_0062: IL_C2
    IL_0063: ldarg.0
    IL_0064: nop
    IL_0065: ldloc.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000349
    IL_0070: ldstr 0x700012B7
    IL_0071: conv.r8
    IL_0072: IL_55
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000338
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x040002A0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000321
    IL_001B: brfalse IL_0073
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000322
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000323
    IL_0028: IL_41
    IL_0029: ldc.i4.1
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_002E: dup
    IL_0033: ldfld 0x04000322
    IL_0038: call 0x0A000024
    IL_0039: IL_58
    IL_003E: stfld 0x04000322
    IL_0043: br IL_0073
    IL_0044: ldarg.0
    IL_0045: ldarg.0
    IL_004A: ldfld 0x040002D8
    IL_004F: stfld 0x040002BF
    IL_0050: ldarg.0
    IL_0055: ldfld 0x0400030C
    IL_0056: conv.r8
    IL_0057: stloc.0
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: ldc.i4.0
    IL_005C: conv.r8
    IL_005D: stloc.1
    IL_005E: nop
    IL_005F: nop
    IL_0060: stloc.0
    IL_0061: ldarg.0
    IL_0062: ldc.i4.0
    IL_0067: stfld 0x04000321
    IL_0068: ldarg.0
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: nop
    IL_0072: stfld 0x04000322
    IL_0073: ldarg.0
    IL_0078: ldfld 0x040002B1
    IL_007D: brtrue IL_033D
    IL_007E: ldarg.0
    IL_0083: ldfld 0x0400033B
    IL_0088: call 0x0A00001B
    IL_008D: call 0x0A00001C
    IL_0092: brfalse IL_032D
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04000358
    IL_009D: brfalse IL_0198
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x040002B5
    IL_00A8: brfalse IL_011B
    IL_00A9: ldarg.0
    IL_00AA: ldarg.0
    IL_00AF: ldfld 0x040002A0
    IL_00B0: ldarg.0
    IL_00B5: ldfld 0x0400033B
    IL_00BA: call 0x0A000024
    IL_00BF: call 0x0A0000B2
    IL_00C4: stfld 0x040002A0
    IL_00C5: ldarg.0
    IL_00C6: ldarg.0
    IL_00CB: ldfld 0x0400033B
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x040002A0
    IL_00D6: call 0x0A000019
    IL_00DB: stfld 0x0400029D
    IL_00DC: ldarg.0
    IL_00E1: ldfld 0x040002A0
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x0400033B
    IL_00EC: call 0x0A000041
    IL_00F1: brfalse IL_0116
    IL_00F2: ldarg.0
    IL_00F3: ldc.i4.0
    IL_00F8: stfld 0x040002B5
    IL_00F9: ldarg.0
    IL_00FE: call 0x0A00001B
    IL_0103: stfld 0x0400033B
    IL_0104: ldarg.0
    IL_0109: ldfld 0x04000310
    IL_010A: ldc.i4.1
    IL_010B: conv.r8
    IL_010C: IL_F2
    IL_010D: ldarg.2
    IL_010E: nop
    IL_010F: ldloc.0
    IL_0110: ldarg.0
    IL_0115: call 0x06000165
    IL_011A: br IL_0193
    IL_011B: ldarg.0
    IL_0120: ldfld 0x04000349
    IL_0125: ldstr 0x70000F2B
    IL_0126: conv.r8
    IL_0127: IL_56
    IL_0128: nop
    IL_0129: nop
    IL_012A: stloc.0
    IL_012F: brtrue IL_0193
    IL_0130: ldarg.0
    IL_0135: ldfld 0x04000349
    IL_013A: ldstr 0x70001527
    IL_013B: conv.r8
    IL_013C: IL_3C
    IL_013D: nop
    IL_013E: nop
    IL_013F: stloc.0
    IL_0140: pop
    IL_0141: ldarg.0
    IL_0146: ldfld 0x0400030E
    IL_0147: conv.r8
    IL_0148: IL_EA
    IL_0149: IL_01
    IL_014A: nop
    IL_014B: ldloc.0
    IL_014C: ldarg.0
    IL_0151: call 0x0A00001B
    IL_0156: stfld 0x0400033B
    IL_0157: ldarg.0
    IL_0158: ldc.i4.1
    IL_015D: stfld 0x040002B1
    IL_015E: ldarg.0
    IL_0163: ldfld 0x04000310
    IL_0164: conv.r8
    IL_0165: IL_FA
    IL_0166: ldarg.2
    IL_0167: nop
    IL_0168: ldloc.0
    IL_0169: ldarg.0
    IL_016E: ldfld 0x0400031F
    IL_016F: conv.r8
    IL_0170: stloc.1
    IL_0171: ldloc.0
    IL_0172: nop
    IL_0173: ldloc.0
    IL_0174: ldarg.0
    IL_0179: ldfld 0x0400032B
    IL_017E: brfalse IL_0193
    IL_017F: ldarg.0
    IL_0180: ldarg.0
    IL_0185: ldfld 0x040002C9
    IL_0186: conv.i2
    IL_0187: IL_22
    IL_0188: IL_CD
    IL_0189: IL_CC
    IL_018A: IL_CC
    IL_018B: IL_3D
    IL_018C: IL_5A
    IL_018D: not
    IL_0192: call 0x06000192
    IL_0197: br IL_032D
    IL_0198: ldarg.0
    IL_019D: ldfld 0x040002B2
    IL_01A2: brtrue IL_0281
    IL_01A3: ldarg.0
    IL_01A4: ldarg.0
    IL_01A9: ldfld 0x0400033B
    IL_01AA: ldarg.0
    IL_01AF: ldfld 0x040002A0
    IL_01B4: call 0x0A000019
    IL_01B9: stfld 0x0400029D
    IL_01BA: ldarg.0
    IL_01BB: ldc.i4.1
    IL_01C0: stfld 0x040002BC
    IL_01C1: ldarg.0
    IL_01C6: ldfld 0x04000338
    IL_01C7: ldarg.0
    IL_01CC: ldfld 0x04000338
    IL_01CD: conv.r8
    IL_01CE: ldc.i4.2
    IL_01CF: nop
    IL_01D0: nop
    IL_01D1: stloc.0
    IL_01D2: ldarg.0
    IL_01D7: ldfld 0x0400033B
    IL_01DC: call 0x0A000024
    IL_01DD: IL_22
    IL_01DE: IL_CD
    IL_01DF: IL_CC
    IL_01E0: IL_CC
    IL_01E1: IL_3D
    IL_01E2: IL_5A
    IL_01E7: call 0x0A0000B2
    IL_01E8: conv.r8
    IL_01E9: ldloc.3
    IL_01EA: nop
    IL_01EB: nop
    IL_01EC: stloc.0
    IL_01ED: ldarg.0
    IL_01F2: ldfld 0x04000349
    IL_01F7: ldstr 0x700012E3
    IL_01F8: conv.r8
    IL_01F9: IL_56
    IL_01FA: nop
    IL_01FB: nop
    IL_01FC: stloc.0
    IL_0201: brfalse IL_0207
    IL_0206: br IL_027C
    IL_0207: ldarg.0
    IL_020C: ldfld 0x04000349
    IL_0211: ldstr 0x700012D7
    IL_0212: conv.r8
    IL_0213: IL_56
    IL_0214: nop
    IL_0215: nop
    IL_0216: stloc.0
    IL_021B: brfalse IL_0245
    IL_0220: ldstr 0x70000C2B
    IL_0225: call 0x0A000077
    IL_0226: conv.r8
    IL_0227: IL_22
    IL_0228: nop
    IL_0229: nop
    IL_022B: br.s IL_024E
    IL_022C: nop
    IL_022D: nop
    IL_022E: nop
    IL_151BEF: switch (345711 cases)
    }

    public void SetRestrictArea() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040002EA
    IL_0007: ret
    }

    }}
