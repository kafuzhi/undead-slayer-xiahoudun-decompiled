// Namespace: 
// Type: AI_Boss01

    public class AI_Boss01 {{

    public object enemykind;
    public object ef_weapon;
    public object ef_secondweapon;
    private object originTex;
    public object monmovestat;
    public object snd_move;
    public object snd_scream;
    public object snd_attack;
    public object direction_arrow;
    private object attack_impact;
    private object clone_weapon;
    private object mytransform;
    private object myanimation;
    private object hpbar;
    public object weapon;
    private object life;
    private object impact;
    private object attackstart;
    private object bosscutin;
    private object attach_weaponEf;
    private object collideroff;
    private object turnspeed;
    private object behaviour_delay;
    private object level;
    private object maxhp;
    private object hp;
    private object power;
    private object haveExp;
    private object block;
    private object behaviour;
    private object currentAtk;
    private object petrify_rate;
    private object runspeed;
    private object firerange1;
    private object firerange2;
    private object firerange3;
    private object dash;
    private object moving_atk;
    private object arrowTargetVector;
    private object m_atk_delay;
    private object attackrange;
    private object attackforce;
    private object blockrate;
    private object poison;
    private object poison_delay;
    private object old_delay;
    private object poison_damage;
    private object showme;
    private object jump;
    private object setattackkind;
    private object atkkind;
    private object mycollider;
    private object pluspower;
    private object plusmaxhp;
    private object restrictArea;
    private object invince;
    private object att_status;
    private object chamovestat;
    private object cha1;
    private object target;
    private object clone_arrow;
    private object attackdir;
    private object directionVector;
    private object lookrotation;
    private object damage;
    private object atk;
    private object accuracy;
    private object myaudio;
    private object monrender;
    private object script_cha;
    private object script_sound;
    private object script_cam;
    private object script_hpbar;
    private object script_monEf;
    private object script_spawn;
    private object enemy;

    public AI_Boss01() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x04000014
    IL_000C: ldarg.0
    IL_000D: ldc.i4.3
    IL_0012: newarr 0x01000003
    IL_0017: stfld 0x0400001D
    IL_0018: ldarg.0
    IL_0019: ldc.i4.1
    IL_001E: stfld 0x04000022
    IL_001F: ldarg.0
    IL_0020: ldc.i4.3
    IL_0025: newarr 0x01000010
    IL_002A: stfld 0x04000026
    IL_002B: ldarg.0
    IL_002C: ldc.i4.3
    IL_0031: newarr 0x01000013
    IL_0036: stfld 0x04000027
    IL_0037: ldarg.0
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_A634: switch (10621 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400001E
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00002A
    IL_0017: stfld 0x0400001F
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A00002B
    IL_0023: stfld 0x04000056
    IL_0024: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x0400001E
    IL_000B: ldstr 0x7000005B
    IL_000C: conv.r8
    IL_000E: brfalse.s IL_000F
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: stloc.3
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_001A: stfld 0x04000057
    IL_001F: ldstr 0x70000063
    IL_0024: call 0x0A000004
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_0027: ldloc.0
    IL_0028: conv.r8
    IL_0029: ldarg.0
    IL_002A: nop
    IL_002B: nop
    IL_002D: br.s IL_00AB
    IL_002E: mul
    IL_002F: nop
    IL_0030: nop
    IL_0031: ldarg.2
    IL_0032: ldarg.0
    IL_0033: ldloc.0
    IL_0034: conv.r8
    IL_0035: ldarg.1
    IL_0036: nop
    IL_0037: nop
    IL_0039: br.s IL_00B5
    IL_003A: IL_C4
    IL_003B: ldarg.2
    IL_003C: nop
    IL_003D: ldarg.2
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000013
    IL_0044: IL_8F
    IL_0045: IL_59
    IL_0046: nop
    IL_0047: nop
    IL_0048: ldarg.0
    IL_004D: ldobj 0x02000059
    IL_0052: stfld 0x0400005E
    IL_0053: ldarg.0
    IL_0054: ldarg.0
    IL_0059: call 0x0A000003
    IL_005E: stfld 0x04000046
    IL_005F: ldarg.0
    IL_0060: ldarg.0
    IL_0065: ldflda 0x0400005E
    IL_006A: ldfld 0x040004A1
    IL_006B: conv.i2
    IL_006C: ldarg.0
    IL_0071: ldfld 0x04000048
    IL_0072: IL_5A
    IL_0073: neg
    IL_0078: stfld 0x0400002B
    IL_0079: ldarg.0
    IL_007E: ldfld 0x0400002D
    IL_007F: ldc.i4.0
    IL_0080: ldarg.0
    IL_0085: ldflda 0x0400005E
    IL_008A: ldfld 0x040004A2
    IL_008B: conv.i2
    IL_008C: ldarg.0
    IL_0091: ldfld 0x04000047
    IL_0092: IL_5A
    IL_0093: neg
    IL_0094: ldelem.i4
    IL_0095: ldarg.0
    IL_009A: ldfld 0x0400002D
    IL_009B: ldc.i4.1
    IL_009C: ldarg.0
    IL_00A1: ldflda 0x0400005E
    IL_00A6: ldfld 0x040004A3
    IL_00A7: conv.i2
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x04000047
    IL_00AE: IL_5A
    IL_00AF: neg
    IL_00B0: ldelem.i4
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x0400002D
    IL_00B7: ldc.i4.2
    IL_00B8: ldarg.0
    IL_00BD: ldflda 0x0400005E
    IL_00C2: ldfld 0x040004A4
    IL_00C3: conv.i2
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x04000047
    IL_00CA: IL_5A
    IL_00CB: neg
    IL_00CC: ldelem.i4
    IL_00CD: ldarg.0
    IL_00CE: dup
    IL_00D3: ldfld 0x0400002E
    IL_00D4: ldarg.0
    IL_00D9: ldflda 0x0400005E
    IL_00DE: ldfld 0x040004A5
    IL_00DF: conv.i2
    IL_00E0: IL_58
    IL_00E5: stfld 0x0400002E
    IL_00E6: ldarg.0
    IL_00E7: dup
    IL_00EC: ldfld 0x0400002F
    IL_00ED: ldarg.0
    IL_00F2: ldflda 0x0400005E
    IL_00F7: ldfld 0x040004A6
    IL_00F8: IL_58
    IL_00F9: neg
    IL_00FE: stfld 0x0400002F
    IL_00FF: ldarg.0
    IL_0100: ldarg.0
    IL_0105: ldflda 0x0400005E
    IL_010A: ldfld 0x040004A8
    IL_010F: stfld 0x04000033
    IL_0110: ldarg.0
    IL_0111: ldarg.0
    IL_0116: ldflda 0x0400005E
    IL_011B: ldfld 0x040004A9
    IL_0120: stfld 0x04000028
    IL_0121: ldarg.0
    IL_0122: ldarg.0
    IL_0127: ldflda 0x0400005E
    IL_012C: ldfld 0x040004AA
    IL_0131: stfld 0x04000034
    IL_0132: ldarg.0
    IL_0133: ldarg.0
    IL_0138: ldflda 0x0400005E
    IL_013D: ldfld 0x040004AB
    IL_0142: stfld 0x04000035
    IL_0143: ldarg.0
    IL_0144: ldarg.0
    IL_0149: ldflda 0x0400005E
    IL_014E: ldfld 0x040004AC
    IL_0153: stfld 0x04000036
    IL_0154: ldarg.0
    IL_0159: ldfld 0x04000037
    IL_015A: ldc.i4.0
    IL_015B: ldarg.0
    IL_0160: ldflda 0x0400005E
    IL_0165: ldfld 0x040004AD
    IL_0166: ldelem.i4
    IL_0167: ldarg.0
    IL_016C: ldfld 0x04000037
    IL_016D: ldc.i4.1
    IL_016E: ldarg.0
    IL_0173: ldflda 0x0400005E
    IL_0178: ldfld 0x040004AE
    IL_0179: ldelem.i4
    IL_017A: ldarg.0
    IL_017F: ldfld 0x04000037
    IL_0180: ldc.i4.2
    IL_0181: ldarg.0
    IL_0186: ldflda 0x0400005E
    IL_018B: ldfld 0x040004AF
    IL_018C: ldelem.i4
    IL_018D: ldarg.0
    IL_0192: ldfld 0x04000038
    IL_0193: ldc.i4.0
    IL_0194: IL_8F
    IL_0195: ldnull
    IL_0196: nop
    IL_0197: nop
    IL_0198: IL_01
    IL_0199: ldarg.0
    IL_019E: ldflda 0x0400005E
    IL_01A3: ldfld 0x040004B0
    IL_01A4: IL_81
    IL_01A5: ldnull
    IL_01A6: nop
    IL_01A7: nop
    IL_01A8: IL_01
    IL_01A9: ldarg.0
    IL_01AE: ldfld 0x04000038
    IL_01AF: ldc.i4.1
    IL_01B0: IL_8F
    IL_01B1: ldnull
    IL_01B2: nop
    IL_01B3: nop
    IL_01B4: IL_01
    IL_01B5: ldarg.0
    IL_01BA: ldflda 0x0400005E
    IL_01BF: ldfld 0x040004B1
    IL_01C0: IL_81
    IL_01C1: ldnull
    IL_01C2: nop
    IL_01C3: nop
    IL_01C4: IL_01
    IL_01C5: ldarg.0
    IL_01CA: ldfld 0x04000038
    IL_01CB: ldc.i4.2
    IL_01CC: IL_8F
    IL_01CD: ldnull
    IL_01CE: nop
    IL_01CF: nop
    IL_01D0: IL_01
    IL_01D1: ldarg.0
    IL_01D6: ldflda 0x0400005E
    IL_01DB: ldfld 0x040004B2
    IL_01DC: IL_81
    IL_01DD: ldnull
    IL_01DE: nop
    IL_01DF: nop
    IL_01E0: IL_01
    IL_01E1: ldarg.0
    IL_01E6: ldfld 0x04000026
    IL_01E7: ldc.i4.0
    IL_01E8: ldarg.0
    IL_01ED: ldflda 0x0400005E
    IL_01F2: ldfld 0x040004B3
    IL_01F3: ldelem.i4
    IL_01F4: ldarg.0
    IL_01F9: ldfld 0x04000026
    IL_01FA: ldc.i4.1
    IL_01FB: ldarg.0
    IL_0200: ldflda 0x0400005E
    IL_0205: ldfld 0x040004B4
    IL_0206: ldelem.i4
    IL_0207: ldarg.0
    IL_020C: ldfld 0x04000026
    IL_020D: ldc.i4.2
    IL_020E: ldarg.0
    IL_0213: ldflda 0x0400005E
    IL_0218: ldfld 0x040004B5
    IL_0219: ldelem.i4
    IL_021A: ldarg.0
    IL_021F: ldfld 0x04000027
    IL_0220: ldc.i4.0
    IL_0221: ldarg.0
    IL_0226: ldflda 0x0400005E
    IL_022B: ldfld 0x040004B6
    IL_022C: ldelem.i2
    IL_022D: ldarg.0
    IL_0232: ldfld 0x04000027
    IL_0233: ldc.i4.1
    IL_0234: ldarg.0
    IL_0239: ldflda 0x0400005E
    IL_023E: ldfld 0x040004B7
    IL_023F: ldelem.i2
    IL_0240: ldarg.0
    IL_0245: ldfld 0x04000027
    IL_0246: ldc.i4.2
    IL_0247: ldarg.0
    IL_024C: ldflda 0x0400005E
    IL_0251: ldfld 0x040004B8
    IL_0252: ldelem.i2
    IL_0253: ldarg.0
    IL_0258: ldfld 0x0400001F
    IL_025D: ldstr 0x70000073
    IL_025E: conv.r8
    IL_0260: bge.s IL_0261
    IL_0261: nop
    IL_0262: stloc.0
    IL_0263: ldarg.0
    IL_0268: ldflda 0x0400005E
    IL_026D: ldfld 0x040004B9
    IL_026E: conv.r8
    IL_0270: bgt.s IL_0271
    IL_0271: nop
    IL_0272: stloc.0
    IL_0273: ldarg.0
    IL_0278: ldfld 0x0400001F
    IL_027D: ldstr 0x70000081
    IL_027E: conv.r8
    IL_0280: bge.s IL_0281
    IL_0281: nop
    IL_0282: stloc.0
    IL_0283: ldarg.0
    IL_0288: ldflda 0x0400005E
    IL_028D: ldfld 0x040004BA
    IL_028E: conv.r8
    IL_0290: bgt.s IL_0291
    IL_0291: nop
    IL_0292: stloc.0
    IL_0293: ldarg.0
    IL_0298: ldfld 0x0400001F
    IL_029D: ldstr 0x7000008F
    IL_029E: conv.r8
    IL_02A0: bge.s IL_02A1
    IL_02A1: nop
    IL_02A2: stloc.0
    IL_02A3: ldarg.0
    IL_02A8: ldflda 0x0400005E
    IL_02AD: ldfld 0x040004BC
    IL_02AE: conv.r8
    IL_02B0: bgt.s IL_02B1
    IL_02B1: nop
    IL_02B2: stloc.0
    IL_02B3: ldarg.0
    IL_02B8: ldfld 0x0400001F
    IL_02BD: ldstr 0x700000A3
    IL_02BE: conv.r8
    IL_02C0: bge.s IL_02C1
    IL_02C1: nop
    IL_02C2: stloc.0
    IL_02C3: ldarg.0
    IL_02C8: ldflda 0x0400005E
    IL_02CD: ldfld 0x040004BD
    IL_02CE: conv.r8
    IL_02D0: bgt.s IL_02D1
    IL_02D1: nop
    IL_02D2: stloc.0
    IL_02D3: ldarg.0
    IL_02D8: ldfld 0x0400001F
    IL_02DD: ldstr 0x700000BB
    IL_02DE: conv.r8
    IL_02E0: bge.s IL_02E1
    IL_02E1: nop
    IL_02E2: stloc.0
    IL_02E3: ldarg.0
    IL_02E8: ldflda 0x0400005E
    IL_02ED: ldfld 0x040004BE
    IL_02EE: conv.r8
    IL_02F0: bgt.s IL_02F1
    IL_02F1: nop
    IL_02F2: stloc.0
    IL_02F3: ldarg.0
    IL_02F8: ldfld 0x0400001F
    IL_02FD: ldstr 0x700000CF
    IL_02FE: conv.r8
    IL_0300: bge.s IL_0301
    IL_0301: nop
    IL_0302: stloc.0
    IL_0303: ldarg.0
    IL_0308: ldflda 0x0400005E
    IL_030D: ldfld 0x040004BF
    IL_030E: conv.r8
    IL_0310: bgt.s IL_0311
    IL_0311: nop
    IL_0312: stloc.0
    IL_0313: ldarg.0
    IL_0318: ldfld 0x0400001F
    IL_031D: ldstr 0x700000E7
    IL_031E: conv.r8
    IL_0320: bge.s IL_0321
    IL_0321: nop
    IL_0322: stloc.0
    IL_0323: ldarg.0
    IL_0328: ldflda 0x0400005E
    IL_032D: ldfld 0x040004C0
    IL_032E: conv.r8
    IL_0330: bgt.s IL_0331
    IL_0331: nop
    IL_0332: stloc.0
    IL_0333: ldarg.0
    IL_0338: ldfld 0x0400001F
    IL_033D: ldstr 0x700000FB
    IL_033E: conv.r8
    IL_0340: bge.s IL_0341
    IL_0341: nop
    IL_0342: stloc.0
    IL_0343: ldarg.0
    IL_0348: ldflda 0x0400005E
    IL_034D: ldfld 0x040004C1
    IL_034E: conv.r8
    IL_0350: bgt.s IL_0351
    IL_0351: nop
    IL_0352: stloc.0
    IL_0353: ldarg.0
    IL_0358: ldfld 0x0400001F
    IL_035D: ldstr 0x70000113
    IL_035E: conv.r8
    IL_0360: bge.s IL_0361
    IL_0361: nop
    IL_0362: stloc.0
    IL_0363: ldarg.0
    IL_0368: ldflda 0x0400005E
    IL_036D: ldfld 0x040004C2
    IL_036E: conv.r8
    IL_0370: bgt.s IL_0371
    IL_0371: nop
    IL_0372: stloc.0
    IL_0373: ldarg.0
    IL_0378: ldfld 0x0400001F
    IL_037D: ldstr 0x70000081
    IL_037E: conv.r8
    IL_0380: bge.s IL_0381
    IL_0381: nop
    IL_0382: stloc.0
    IL_0383: ldc.i4.2
    IL_0384: conv.r8
    IL_0386: ble.s IL_0387
    IL_0387: nop
    IL_0388: stloc.0
    IL_0389: ldarg.0
    IL_038E: ldfld 0x0400001F
    IL_0393: ldstr 0x70000073
    IL_0394: conv.r8
    IL_0396: bge.s IL_0397
    IL_0397: nop
    IL_0398: stloc.0
    IL_0399: ldc.i4.1
    IL_039A: conv.r8
    IL_039C: ble.s IL_039D
    IL_039D: nop
    IL_039E: stloc.0
    IL_039F: ldarg.0
    IL_03A4: ldfld 0x0400001F
    IL_03A9: ldstr 0x7000008F
    IL_03AA: conv.r8
    IL_03AC: bge.s IL_03AD
    IL_03AD: nop
    IL_03AE: stloc.0
    IL_03AF: ldc.i4.1
    IL_03B0: conv.r8
    IL_03B2: ble.s IL_03B3
    IL_03B3: nop
    IL_03B4: stloc.0
    IL_03B5: ldarg.0
    IL_03BA: ldfld 0x0400001F
    IL_03BF: ldstr 0x700000A3
    IL_03C0: conv.r8
    IL_03C2: bge.s IL_03C3
    IL_03C3: nop
    IL_03C4: stloc.0
    IL_03C5: ldc.i4.1
    IL_03C6: conv.r8
    IL_03C8: ble.s IL_03C9
    IL_03C9: nop
    IL_03CA: stloc.0
    IL_03CB: ldarg.0
    IL_03D0: ldfld 0x0400001F
    IL_03D5: ldstr 0x700000BB
    IL_03D6: conv.r8
    IL_03D8: bge.s IL_03D9
    IL_03D9: nop
    IL_03DA: stloc.0
    IL_03DB: ldc.i4.1
    IL_03DC: conv.r8
    IL_03DE: ble.s IL_03DF
    IL_03DF: nop
    IL_03E0: stloc.0
    IL_03E1: ldarg.0
    IL_03E6: ldfld 0x0400001F
    IL_03EB: ldstr 0x700000CF
    IL_03EC: conv.r8
    IL_03EE: bge.s IL_03EF
    IL_03EF: nop
    IL_03F0: stloc.0
    IL_03F1: ldc.i4.1
    IL_03F2: conv.r8
    IL_03F4: ble.s IL_03F5
    IL_03F5: nop
    IL_03F6: stloc.0
    IL_03F7: ldarg.0
    IL_03FC: ldfld 0x0400001F
    IL_0401: ldstr 0x700000E7
    IL_0402: conv.r8
    IL_0404: bge.s IL_0405
    IL_0405: nop
    IL_0406: stloc.0
    IL_0407: ldc.i4.1
    IL_0408: conv.r8
    IL_040A: ble.s IL_040B
    IL_040B: nop
    IL_040C: stloc.0
    IL_040D: ldarg.0
    IL_0412: ldfld 0x0400001F
    IL_0417: ldstr 0x700000FB
    IL_0418: conv.r8
    IL_041A: bge.s IL_041B
    IL_041B: nop
    IL_041C: stloc.0
    IL_041D: ldc.i4.1
    IL_041E: conv.r8
    IL_0420: ble.s IL_0421
    IL_0421: nop
    IL_0422: stloc.0
    IL_0423: ldarg.0
    IL_0428: ldfld 0x0400001F
    IL_042D: ldstr 0x70000113
    IL_042E: conv.r8
    IL_0430: bge.s IL_0431
    IL_0431: nop
    IL_0432: stloc.0
    IL_0433: ldc.i4.1
    IL_0434: conv.r8
    IL_0436: ble.s IL_0437
    IL_0437: nop
    IL_0438: stloc.0
    IL_0439: ldarg.0
    IL_043A: ldc.i4.0
    IL_043F: stfld 0x04000017
    IL_0440: ldarg.0
    IL_0441: ldarg.0
    IL_0446: ldfld 0x04000057
    IL_0447: conv.r8
    IL_0449: ldarg.s 0
    IL_044A: nop
    IL_044B: stloc.0
    IL_044C: conv.r8
    IL_044E: blt.s IL_044F
    IL_044F: nop
    IL_0450: stloc.0
    IL_0455: stfld 0x04000016
    IL_0456: ldarg.0
    IL_045B: ldstr 0x70000001
    IL_0460: call 0x0A000004
    IL_0461: conv.r8
    IL_0462: ldarg.3
    IL_0463: nop
    IL_0464: nop
    IL_0465: stloc.0
    IL_046A: stfld 0x0400004D
    IL_046B: ldarg.0
    IL_046C: ldarg.0
    IL_0471: ldfld 0x0400002B
    IL_0476: stfld 0x0400002C
    IL_0477: ldarg.0
    IL_0478: ldarg.0
    IL_047D: ldfld 0x0400004D
    IL_047E: conv.r8
    IL_047F: stloc.0
    IL_0480: nop
    IL_0481: nop
    IL_0482: stloc.0
    IL_0483: conv.r8
    IL_0484: ldarg.2
    IL_0485: nop
    IL_0486: nop
    IL_0488: br.s IL_0506
    IL_0489: IL_58
    IL_048A: nop
    IL_048B: nop
    IL_048C: ldarg.2
    IL_048D: ldarg.0
    IL_0492: ldstr 0x70000121
    IL_0497: call 0x0A000004
    IL_0498: conv.r8
    IL_0499: ldarg.3
    IL_049A: nop
    IL_049B: nop
    IL_049D: br.s IL_051B
    IL_049E: IL_59
    IL_049F: nop
    IL_04A0: nop
    IL_04A1: ldarg.2
    IL_04A2: ldarg.0
    IL_04A7: call 0x0A000035
    IL_04A8: conv.r8
    IL_04A9: ldloc.0
    IL_04AA: nop
    IL_04AB: nop
    IL_04AD: br.s IL_052B
    IL_04AE: IL_5A
    IL_04AF: nop
    IL_04B0: nop
    IL_04B1: ldarg.2
    IL_04B2: ldarg.0
    IL_04B7: ldstr 0x7000012D
    IL_04BC: call 0x0A000004
    IL_04BD: conv.r8
    IL_04BE: ldloc.1
    IL_04BF: nop
    IL_04C0: nop
    IL_04C2: br.s IL_0540
    IL_04C3: sub
    IL_04C4: nop
    IL_04C5: nop
    IL_04C6: ldarg.2
    IL_04C7: ldarg.0
    IL_04C8: ldarg.0
    IL_04CD: ldfld 0x0400005C
    IL_04CE: IL_22
    IL_04CF: IL_CD
    IL_04D0: IL_CC
    IL_04D1: IL_CC
    IL_04D2: IL_3D
    IL_04D3: IL_22
    IL_04D4: stloc.0
    IL_04D5: IL_D7
    IL_04D6: stelem.i
    IL_04D7: IL_3C
    IL_04DC: newobj 0x0A000038
    IL_04DD: ldc.i4.0
    IL_04DE: ldc.i4.0
    IL_04DF: conv.r8
    IL_04E0: IL_BE
    IL_04E1: ldarg.1
    IL_04E2: nop
    IL_04E3: ldloc.0
    IL_04E8: stfld 0x04000020
    IL_04E9: ldarg.0
    IL_04EE: ldfld 0x04000020
    IL_04EF: ldarg.0
    IL_04F4: ldfld 0x0400001E
    IL_04F5: conv.r8
    IL_04F6: ldc.i4.2
    IL_04F7: nop
    IL_04F8: nop
    IL_04F9: stloc.0
    IL_04FA: conv.r8
    IL_04FB: ldloc.3
    IL_04FC: nop
    IL_04FD: nop
    IL_04FE: stloc.0
    IL_04FF: ldarg.0
    IL_0500: ldarg.0
    IL_0505: ldfld 0x04000020
    IL_0506: conv.r8
    IL_0507: ldloc.2
    IL_0508: nop
    IL_0509: nop
    IL_050B: br.s IL_0589
    IL_050C: add
    IL_050D: nop
    IL_050E: nop
    IL_050F: ldarg.2
    IL_0510: ldarg.0
    IL_0515: ldfld 0x0400005B
    IL_0516: ldarg.0
    IL_051B: ldfld 0x0400002B
    IL_051C: ldarg.0
    IL_0521: ldfld 0x0400002C
    IL_0522: ldarg.0
    IL_0527: ldfld 0x0400001E
    IL_0528: IL_22
    IL_0529: IL_CD
    IL_052A: IL_CC
    IL_052B: IL_CC
    IL_052C: IL_3E
    IL_052D: ldc.i4.0
    IL_052E: conv.r8
    IL_052F: ldnull
    IL_0530: ldarg.1
    IL_0531: nop
    IL_0532: ldloc.0
    IL_0533: ldarg.0
    IL_0534: ldarg.0
    IL_0539: ldfld 0x04000058
    IL_053E: ldfld 0x040002BF
    IL_0543: stfld 0x04000055
    IL_0544: ldarg.0
    IL_0545: ldarg.0
    IL_054A: ldfld 0x04000058
    IL_054F: ldfld 0x040002C6
    IL_0554: stfld 0x04000054
    IL_0555: ldarg.0
    IL_055A: ldfld 0x0400005C
    IL_055B: ldarg.0
    IL_0560: ldfld 0x0400001E
    IL_0561: ldc.i4.0
    IL_0562: conv.r8
    IL_0567: brtrue IL_220A0568
    IL_0568: IL_CD
    IL_0569: IL_CC
    IL_056A: stloc.2
    IL_EDB2B: switch (243055 cases)
    }

    private void TurnNormal() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x0400004A
    IL_0007: ldarg.0
    IL_000C: ldstr 0x7000015F
    IL_000D: IL_22
    IL_000E: IL_CD
    IL_000F: IL_CC
    IL_0010: IL_CC
    IL_0011: IL_3D
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: IL_3F
    IL_001B: call 0x0A000017
    IL_001C: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400004A
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.1
    IL_000D: conv.r8
    IL_000E: stloc.0
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: conv.r8
    IL_0013: ldc.i4.8
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: stloc.0
    IL_0018: ldloc.0
    IL_001A: ldc.i4.s 16
    IL_001B: IL_3F
    IL_001C: IL_84
    IL_001D: ldloc.3
    IL_001E: nop
    IL_001F: nop
    IL_0020: ldarg.0
    IL_0021: ldc.i4.1
    IL_0026: stfld 0x04000044
    IL_0027: ldarg.0
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000058
    IL_0032: ldfld 0x040002BF
    IL_0037: stfld 0x04000055
    IL_0038: ldarg.0
    IL_0039: ldarg.0
    IL_003E: ldfld 0x04000058
    IL_0043: ldfld 0x040002C6
    IL_0048: stfld 0x04000054
    IL_0049: ldloc.0
    IL_004B: ldc.i4.s 28
    IL_0170: switch (72 cases)
    IL_0171: ldelem.r8
    IL_0172: IL_42
    IL_0177: call 0x0A000008
    IL_0178: conv.r8
    IL_0179: IL_3E
    IL_017A: nop
    IL_017B: nop
    IL_017C: stloc.0
    IL_017D: ldarg.0
    IL_0182: ldfld 0x0400005A
    IL_0183: conv.r8
    IL_0184: IL_35
    IL_0185: IL_01
    IL_0186: nop
    IL_0187: ldloc.0
    IL_0188: ldarg.0
    IL_0189: IL_22
    IL_018A: nop
    IL_018B: nop
    IL_0190: cpobj 0x003C7D42
    IL_0191: nop
    IL_0192: ldarg.2
    IL_0193: ldarg.0
    IL_0194: ldc.i4.0
    IL_0196: ldc.i4.s 100
    IL_019B: call 0x0A000045
    IL_01A0: stfld 0x0400003D
    IL_01A1: ldarg.0
    IL_01A6: ldfld 0x0400003D
    IL_01A7: ldarg.0
    IL_01AC: ldfld 0x0400002F
    IL_01AD: ldarg.0
    IL_01B2: ldfld 0x04000055
    IL_01B3: IL_59
    IL_01B4: IL_3C
    IL_01B5: IL_3E
    IL_01B6: nop
    IL_01B7: nop
    IL_01B8: nop
    IL_01B9: ldarg.0
    IL_01BE: ldfld 0x04000017
    IL_01BF: ldc.i4.0
    IL_01C0: IL_3F
    IL_01C2: blt.s IL_01C3
    IL_01C3: nop
    IL_01C4: nop
    IL_01C5: ldarg.0
    IL_01CA: call 0x0A00003D
    IL_01CB: ldarg.0
    IL_01D0: ldfld 0x04000050
    IL_01D1: IL_22
    IL_01D2: nop
    IL_01D3: nop
    IL_01D8: ldc.i4 534593
    IL_01D9: nop
    IL_01DA: stloc.0
    IL_01DB: conv.r8
    IL_01DC: IL_3E
    IL_01DD: nop
    IL_01DE: nop
    IL_01DF: stloc.0
    IL_01E0: ldarg.0
    IL_01E5: ldfld 0x04000058
    IL_01E6: ldarg.0
    IL_01EB: ldfld 0x0400001E
    IL_01EC: conv.r8
    IL_01ED: ldc.i4.2
    IL_01EE: nop
    IL_01EF: nop
    IL_01F0: stloc.0
    IL_01F1: conv.r8
    IL_01F2: len
    IL_01F3: IL_01
    IL_01F4: nop
    IL_01F5: ldloc.0
    IL_01F6: ret
    IL_01F7: ldarg.0
    IL_01F8: ldarg.0
    IL_01FD: ldfld 0x04000054
    IL_01FE: conv.i2
    IL_0203: stfld 0x04000053
    IL_0204: ldarg.0
    IL_0205: ldarg.0
    IL_020A: ldfld 0x0400004D
    IL_020F: stfld 0x0400004E
    IL_0210: ldarg.0
    IL_0215: ldfld 0x0400005C
    IL_0216: ldarg.0
    IL_021B: ldfld 0x0400001E
    IL_021C: conv.r8
    IL_021D: ldc.i4.2
    IL_021E: nop
    IL_021F: nop
    IL_0220: stloc.0
    IL_0221: ldarg.0
    IL_0226: ldfld 0x04000050
    IL_0227: conv.r8
    IL_0228: IL_B8
    IL_0229: ldarg.1
    IL_022A: nop
    IL_022B: ldloc.0
    IL_0230: br IL_07CB
    IL_0231: ldarg.0
    IL_0236: ldfld 0x0400005A
    IL_0237: IL_22
    IL_0238: nop
    IL_0239: nop
    IL_023E: stsfld 0x01366F3F
    IL_023F: nop
    IL_0240: ldloc.0
    IL_0241: ldarg.0
    IL_0242: IL_22
    IL_0243: nop
    IL_0244: nop
    IL_0245: IL_C8
    IL_0246: IL_42
    IL_024B: stfld 0x0400003C
    IL_024C: ldarg.0
    IL_024D: ldarg.0
    IL_0252: ldfld 0x04000054
    IL_0253: conv.i2
    IL_0258: stfld 0x04000053
    IL_0259: ldarg.0
    IL_025A: ldarg.0
    IL_025F: ldfld 0x0400004D
    IL_0264: stfld 0x0400004E
    IL_0265: ldarg.0
    IL_026A: ldfld 0x0400005C
    IL_026B: ldarg.0
    IL_0270: ldfld 0x0400001E
    IL_0271: conv.r8
    IL_0272: ldc.i4.2
    IL_0273: nop
    IL_0274: nop
    IL_0275: stloc.0
    IL_0276: ldarg.0
    IL_027B: ldfld 0x04000050
    IL_027C: conv.r8
    IL_027D: IL_B9
    IL_027E: ldarg.1
    IL_027F: nop
    IL_0280: ldloc.0
    IL_0285: br IL_07CB
    IL_0286: ldarg.0
    IL_028B: ldfld 0x0400005A
    IL_028C: conv.r8
    IL_028D: IL_35
    IL_028E: IL_01
    IL_028F: nop
    IL_0290: ldloc.0
    IL_0291: ldarg.0
    IL_0292: IL_22
    IL_0293: nop
    IL_0294: nop
    IL_0297: ldloc 32066
    IL_0298: IL_3C
    IL_0299: nop
    IL_029A: nop
    IL_029B: ldarg.2
    IL_029C: ldarg.0
    IL_029D: ldarg.1
    IL_029E: conv.r8
    IL_029F: IL_3D
    IL_02A0: nop
    IL_02A1: nop
    IL_02A2: stloc.0
    IL_02A3: conv.r8
    IL_02A6: ldarga 0
    IL_02A7: stloc.0
    IL_02AC: stfld 0x04000053
    IL_02AD: ldarg.0
    IL_02AE: ldarg.0
    IL_02B3: ldfld 0x0400004D
    IL_02B8: stfld 0x0400004E
    IL_02B9: ldarg.0
    IL_02BE: ldfld 0x0400005C
    IL_02BF: ldarg.0
    IL_02C4: ldfld 0x0400001E
    IL_02C5: conv.r8
    IL_02C6: ldc.i4.2
    IL_02C7: nop
    IL_02C8: nop
    IL_02C9: stloc.0
    IL_02CA: ldarg.0
    IL_02CF: ldfld 0x04000050
    IL_02D0: conv.r8
    IL_02D1: IL_B8
    IL_02D2: ldarg.1
    IL_02D3: nop
    IL_02D4: ldloc.0
    IL_02D9: br IL_07CB
    IL_02DA: ldarg.1
    IL_02DB: conv.r8
    IL_02DC: IL_3D
    IL_02DD: nop
    IL_02DE: nop
    IL_02DF: stloc.0
    IL_02E0: conv.r8
    IL_02E3: ldarga 0
    IL_02E4: stloc.0
    IL_02E5: stloc.1
    IL_02E6: ldloc.1
    IL_02E7: IL_22
    IL_02E8: IL_CD
    IL_02E9: IL_CC
    IL_02EA: IL_CC
    IL_02EB: IL_3D
    IL_03F8: switch (66 cases)
    IL_03F9: nop
    IL_03FA: nop
    IL_03FB: stloc.0
    IL_03FC: ldarg.0
    IL_0401: ldfld 0x0400005C
    IL_0406: ldfld 0x0400080F
    IL_0407: ldc.i4.1
    IL_0408: ldelem.i
    IL_0409: conv.r8
    IL_040B: ldarga.s 0
    IL_040C: nop
    IL_040D: stloc.0
    IL_040E: ldarg.0
    IL_0413: ldfld 0x0400005B
    IL_0414: ldarg.0
    IL_0419: ldfld 0x0400002B
    IL_041A: ldarg.0
    IL_041F: ldfld 0x0400002C
    IL_0420: ldarg.0
    IL_0425: ldfld 0x0400001E
    IL_0426: IL_22
    IL_0427: IL_CD
    IL_0428: IL_CC
    IL_0429: IL_CC
    IL_042A: IL_3E
    IL_042B: ldc.i4.2
    IL_042C: conv.r8
    IL_042D: ldnull
    IL_042E: ldarg.1
    IL_042F: nop
    IL_0430: ldloc.0
    IL_0431: ldarg.0
    IL_0432: ldarg.0
    IL_0437: ldfld 0x0400004D
    IL_043C: stfld 0x0400004E
    IL_0441: br IL_07CB
    IL_0442: ldarg.0
    IL_0443: IL_22
    IL_0444: nop
    IL_0445: nop
    IL_044A: cpobj 0x003C7D42
    IL_044B: nop
    IL_044C: ldarg.2
    IL_044D: ldarg.0
    IL_044E: ldarg.0
    IL_0453: ldfld 0x04000054
    IL_0454: conv.i2
    IL_0459: stfld 0x04000053
    IL_045A: ldarg.0
    IL_045B: ldarg.0
    IL_0460: ldfld 0x0400004D
    IL_0465: stfld 0x0400004E
    IL_0466: ldarg.0
    IL_046B: ldfld 0x0400005C
    IL_046C: ldarg.0
    IL_0471: ldfld 0x0400001E
    IL_0472: conv.r8
    IL_0473: ldc.i4.2
    IL_0474: nop
    IL_0475: nop
    IL_0476: stloc.0
    IL_0477: ldarg.0
    IL_047C: ldfld 0x04000050
    IL_047D: conv.r8
    IL_047E: IL_B9
    IL_047F: ldarg.1
    IL_0480: nop
    IL_0481: ldloc.0
    IL_0486: br IL_07CB
    IL_0487: ldarg.0
    IL_048C: ldfld 0x0400001F
    IL_048D: conv.r8
    IL_0490: ldloc 0
    IL_0491: stloc.0
    IL_0492: ldarg.0
    IL_0493: IL_22
    IL_0494: nop
    IL_0495: nop
    IL_049A: ldc.i4 3964225
    IL_049B: nop
    IL_049C: ldarg.2
    IL_049D: ldarg.0
    IL_049E: ldarg.1
    IL_049F: conv.r8
    IL_04A0: IL_3D
    IL_04A1: nop
    IL_04A2: nop
    IL_04A3: stloc.0
    IL_04A4: conv.r8
    IL_04A7: ldarga 0
    IL_04A8: stloc.0
    IL_04AD: stfld 0x04000053
    IL_04AE: ldarg.0
    IL_04AF: dup
    IL_04B4: ldfld 0x0400002C
    IL_04B5: ldarg.0
    IL_04BA: ldfld 0x04000053
    IL_04BB: neg
    IL_04BC: IL_59
    IL_04BD: neg
    IL_04C2: stfld 0x0400002C
    IL_04C3: ldarg.0
    IL_04C8: ldfld 0x0400005B
    IL_04C9: ldarg.0
    IL_04CE: ldfld 0x0400002B
    IL_04CF: ldc.i4.0
    IL_04D0: ldarg.0
    IL_04D5: ldfld 0x0400001E
    IL_04D6: IL_22
    IL_04D7: nop
    IL_04D8: nop
    IL_04DA: starg.s 65
    IL_04DB: ldc.i4.0
    IL_04DC: conv.r8
    IL_04DD: ldnull
    IL_04DE: ldarg.1
    IL_04DF: nop
    IL_04E0: ldloc.0
    IL_04E1: ldarg.0
    IL_04E2: ldarg.0
    IL_04E7: ldfld 0x0400004D
    IL_04EC: stfld 0x0400004E
    IL_04ED: ldarg.0
    IL_04F2: ldfld 0x0400005C
    IL_04F3: ldarg.0
    IL_04F8: ldfld 0x0400001E
    IL_04F9: conv.r8
    IL_04FA: ldc.i4.2
    IL_04FB: nop
    IL_04FC: nop
    IL_04FD: stloc.0
    IL_04FE: ldarg.0
    IL_0503: ldfld 0x04000050
    IL_0504: conv.r8
    IL_0505: IL_B9
    IL_0506: ldarg.1
    IL_0507: nop
    IL_0508: ldloc.0
    IL_0509: ldarg.0
    IL_050E: ldfld 0x0400001F
    IL_0513: ldstr 0x70000081
    IL_0514: conv.r8
    IL_0515: IL_3C
    IL_0516: nop
    IL_0517: nop
    IL_0518: stloc.0
    IL_0519: pop
    IL_051E: br IL_07CB
    IL_051F: ldarg.0
    IL_0520: IL_22
    IL_0521: nop
    IL_0522: nop
    IL_0523: IL_C8
    IL_0524: IL_42
    IL_0529: stfld 0x0400003C
    IL_052A: ldarg.0
    IL_052B: ldarg.0
    IL_0530: ldfld 0x04000058
    IL_0535: ldfld 0x040002C6
    IL_0536: conv.i2
    IL_053B: stfld 0x04000053
    IL_053C: ldarg.0
    IL_0541: ldfld 0x0400005A
    IL_0542: conv.r8
    IL_0543: IL_35
    IL_0544: IL_01
    IL_0545: nop
    IL_0546: ldloc.0
    IL_0547: ldarg.0
    IL_0548: ldarg.0
    IL_054D: ldfld 0x0400004D
    IL_0552: stfld 0x0400004E
    IL_0553: ldarg.0
    IL_0558: ldfld 0x0400005C
    IL_0559: ldarg.0
    IL_055E: ldfld 0x0400001E
    IL_055F: conv.r8
    IL_0560: ldc.i4.2
    IL_0561: nop
    IL_0562: nop
    IL_0563: stloc.0
    IL_0564: ldarg.0
    IL_0569: ldfld 0x04000050
    IL_056A: conv.r8
    IL_056B: IL_B8
    IL_056C: ldarg.1
    IL_056D: nop
    IL_056E: ldloc.0
    IL_0573: br IL_07CB
    IL_0574: ldarg.0
    IL_0575: IL_22
    IL_0576: nop
    IL_0577: nop
    IL_057A: ldloc 32066
    IL_057B: IL_3C
    IL_057C: nop
    IL_057D: nop
    IL_057E: ldarg.2
    IL_057F: ldarg.0
    IL_0580: ldarg.0
    IL_0585: ldfld 0x04000058
    IL_058A: ldfld 0x040002C6
    IL_058B: conv.i2
    IL_058C: IL_22
    IL_058D: IL_CD
    IL_058E: IL_CC
    IL_058F: IL_CC
    IL_0590: IL_3E
    IL_0591: IL_5A
    IL_0596: stfld 0x04000053
    IL_0597: ldarg.0
    IL_0598: ldarg.0
    IL_059D: ldfld 0x0400004D
    IL_05A2: stfld 0x0400004E
    IL_05A3: ldarg.0
    IL_05A8: ldfld 0x0400005C
    IL_05A9: ldarg.0
    IL_05AE: ldfld 0x0400001E
    IL_05AF: conv.r8
    IL_05B0: ldc.i4.2
    IL_05B1: nop
    IL_05B2: nop
    IL_05B3: stloc.0
    IL_05B4: ldarg.0
    IL_05B9: ldfld 0x04000050
    IL_05BA: conv.r8
    IL_05BB: IL_B8
    IL_05BC: ldarg.1
    IL_05BD: nop
    IL_05BE: ldloc.0
    IL_05C3: br IL_07CB
    IL_05C4: ldarg.0
    IL_05C5: IL_22
    IL_05C6: nop
    IL_05C7: nop
    IL_05C8: IL_C8
    IL_05C9: IL_42
    IL_05CE: stfld 0x0400003C
    IL_05CF: ldarg.0
    IL_05D0: ldarg.0
    IL_05D5: ldfld 0x04000058
    IL_05DA: ldfld 0x040002C6
    IL_05DB: conv.i2
    IL_05E0: stfld 0x04000053
    IL_05E1: ldarg.0
    IL_05E6: ldfld 0x0400005A
    IL_05E7: conv.r8
    IL_05E8: IL_35
    IL_05E9: IL_01
    IL_05EA: nop
    IL_05EB: ldloc.0
    IL_05EC: ldarg.0
    IL_05ED: ldarg.0
    IL_05F2: ldfld 0x0400004D
    IL_05F7: stfld 0x0400004E
    IL_05F8: ldarg.0
    IL_05FD: ldfld 0x0400005C
    IL_05FE: ldarg.0
    IL_0603: ldfld 0x0400001E
    IL_0604: conv.r8
    IL_0605: ldc.i4.2
    IL_0606: nop
    IL_0607: nop
    IL_0608: stloc.0
    IL_0609: ldarg.0
    IL_060E: ldfld 0x04000050
    IL_060F: conv.r8
    IL_0610: IL_B8
    IL_0611: ldarg.1
    IL_0612: nop
    IL_0613: ldloc.0
    IL_0618: br IL_07CB
    IL_0619: ldarg.0
    IL_061A: IL_22
    IL_061B: nop
    IL_061C: nop
    IL_061D: IL_C8
    IL_061E: IL_42
    IL_0623: stfld 0x0400003C
    IL_0624: ldarg.0
    IL_0625: ldarg.0
    IL_062A: ldfld 0x04000058
    IL_062F: ldfld 0x040002C6
    IL_0630: conv.i2
    IL_0635: stfld 0x04000053
    IL_0636: ldarg.0
    IL_063B: ldfld 0x0400005A
    IL_063C: conv.r8
    IL_063D: IL_35
    IL_063E: IL_01
    IL_063F: nop
    IL_0640: ldloc.0
    IL_0641: ldarg.0
    IL_0642: ldarg.0
    IL_0647: ldfld 0x0400004D
    IL_064C: stfld 0x0400004E
    IL_064D: ldarg.0
    IL_0652: ldfld 0x0400005C
    IL_0653: ldarg.0
    IL_0658: ldfld 0x0400001E
    IL_0659: conv.r8
    IL_065A: ldc.i4.2
    IL_065B: nop
    IL_065C: nop
    IL_065D: stloc.0
    IL_065E: ldarg.0
    IL_0663: ldfld 0x04000050
    IL_0664: conv.r8
    IL_0665: IL_B8
    IL_0666: ldarg.1
    IL_0667: nop
    IL_0668: ldloc.0
    IL_066D: br IL_07CB
    IL_066E: ldarg.0
    IL_066F: IL_22
    IL_0670: nop
    IL_0671: nop
    IL_0674: ldloc 32194
    IL_0675: IL_3C
    IL_0676: nop
    IL_0677: nop
    IL_0678: ldarg.2
    IL_0679: ldarg.0
    IL_067A: IL_22
    IL_067B: nop
    IL_067C: nop
    IL_067D: nop
    IL_067E: nop
    IL_0683: stfld 0x04000053
    IL_0684: ldarg.0
    IL_0685: ldarg.0
    IL_068A: ldfld 0x0400004D
    IL_068F: stfld 0x0400004E
    IL_0690: ldarg.0
    IL_0695: ldfld 0x0400004B
    IL_0696: ldc.i4.1
    IL_069B: beq IL_06C3
    IL_069C: ldarg.0
    IL_06A1: ldfld 0x0400001F
    IL_06A2: ldc.i4.0
    IL_06A3: conv.r8
    IL_06A6: ldloca 0
    IL_06A7: stloc.0
    IL_06A8: ldarg.0
    IL_06A9: ldarg.0
    IL_06AA: ldarg.0
    IL_06AF: ldfld 0x04000053
    IL_06B0: neg
    IL_06B5: call 0x06000011
    IL_06BA: call 0x0A000047
    IL_06BB: pop
    IL_06BC: ldarg.0
    IL_06BD: ldc.i4.2
    IL_06C2: stfld 0x0400004B
    IL_06C7: br IL_07CB
    IL_06C8: ldarg.0
    IL_06C9: IL_22
    IL_06CA: nop
    IL_06CB: nop
    IL_06D0: ldc.i4 3964226
    IL_06D1: nop
    IL_06D2: ldarg.2
    IL_06D3: ldarg.0
    IL_06D4: ldarg.1
    IL_06D5: conv.r8
    IL_06D6: IL_3D
    IL_06D7: nop
    IL_06D8: nop
    IL_06D9: stloc.0
    IL_06DA: conv.r8
    IL_06DD: ldarga 0
    IL_06DE: stloc.0
    IL_06E3: stfld 0x04000053
    IL_06E4: ldarg.0
    IL_06E9: ldfld 0x0400005A
    IL_06EA: IL_22
    IL_06EB: IL_CD
    IL_06EC: IL_CC
    IL_06ED: IL_4C
    IL_06EE: IL_3E
    IL_06EF: conv.r8
    IL_06F0: IL_36
    IL_06F1: IL_01
    IL_06F2: nop
    IL_06F3: ldloc.0
    IL_06F4: ldarg.0
    IL_06F5: ldarg.0
    IL_06FA: ldfld 0x0400004D
    IL_06FF: stfld 0x0400004E
    IL_0700: ldarg.0
    IL_0705: ldfld 0x0400005C
    IL_0706: ldarg.0
    IL_070B: ldfld 0x0400001E
    IL_070C: conv.r8
    IL_070D: ldc.i4.2
    IL_070E: nop
    IL_070F: nop
    IL_0710: stloc.0
    IL_0711: ldarg.0
    IL_0716: ldfld 0x04000050
    IL_0717: conv.r8
    IL_0718: IL_B8
    IL_0719: ldarg.1
    IL_071A: nop
    IL_071B: ldloc.0
    IL_0720: br IL_07CB
    IL_0721: ldarg.0
    IL_0722: IL_22
    IL_0723: nop
    IL_0724: nop
    IL_0725: IL_C8
    IL_0726: IL_42
    IL_072B: stfld 0x0400003C
    IL_072C: ldarg.0
    IL_072D: ldarg.0
    IL_0732: ldfld 0x04000058
    IL_0737: ldfld 0x040002C6
    IL_0738: conv.i2
    IL_073D: stfld 0x04000053
    IL_073E: ldarg.0
    IL_0743: ldfld 0x0400005A
    IL_0744: conv.r8
    IL_0745: IL_35
    IL_0746: IL_01
    IL_0747: nop
    IL_0748: ldloc.0
    IL_0749: ldarg.0
    IL_074A: ldarg.0
    IL_074F: ldfld 0x0400004D
    IL_0754: stfld 0x0400004E
    IL_0755: ldarg.0
    IL_075A: ldfld 0x0400005C
    IL_075B: ldarg.0
    IL_0760: ldfld 0x0400001E
    IL_0761: conv.r8
    IL_0762: ldc.i4.2
    IL_0763: nop
    IL_0764: nop
    IL_0765: stloc.0
    IL_0766: ldarg.0
    IL_076B: ldfld 0x04000050
    IL_076C: conv.r8
    IL_076D: IL_B8
    IL_076E: ldarg.1
    IL_076F: nop
    IL_0770: ldloc.0
    IL_0775: br IL_07CB
    IL_0776: ldarg.0
    IL_0777: IL_22
    IL_0778: nop
    IL_0779: nop
    IL_077A: IL_C8
    IL_077B: IL_42
    IL_0780: stfld 0x0400003C
    IL_0781: ldarg.0
    IL_0782: ldarg.0
    IL_0787: ldfld 0x04000058
    IL_078C: ldfld 0x040002C6
    IL_078D: conv.i2
    IL_0792: stfld 0x04000053
    IL_0793: ldarg.0
    IL_0798: ldfld 0x0400005A
    IL_0799: conv.r8
    IL_079A: IL_35
    IL_079B: IL_01
    IL_079C: nop
    IL_079D: ldloc.0
    IL_079E: ldarg.0
    IL_079F: ldarg.0
    IL_07A4: ldfld 0x0400004D
    IL_07A9: stfld 0x0400004E
    IL_07AA: ldarg.0
    IL_07AF: ldfld 0x0400005C
    IL_07B0: ldarg.0
    IL_07B5: ldfld 0x0400001E
    IL_07B6: conv.r8
    IL_07B7: ldc.i4.2
    IL_07B8: nop
    IL_07B9: nop
    IL_07BA: stloc.0
    IL_07BB: ldarg.0
    IL_07C0: ldfld 0x04000050
    IL_07C1: conv.r8
    IL_07C2: IL_B8
    IL_07C3: ldarg.1
    IL_07C4: nop
    IL_07C5: ldloc.0
    IL_07CA: br IL_07CB
    IL_07CB: ldarg.0
    IL_07D0: ldfld 0x04000022
    IL_07D5: brtrue IL_07F2
    IL_07D6: ldarg.0
    IL_07DB: ldfld 0x04000059
    IL_07DC: ldc.i4.1
    IL_07DD: conv.r8
    IL_07DE: IL_EC
    IL_07DF: ldarg.2
    IL_07E0: nop
    IL_07E1: ldloc.0
    IL_07E2: ldarg.0
    IL_07E7: ldfld 0x0400001F
    IL_07E8: conv.r8
    IL_07EB: ldloc 0
    IL_07EC: stloc.0
    IL_07F1: br IL_09A4
    IL_07F2: ldarg.0
    IL_07F7: ldfld 0x04000059
    IL_07F8: ldc.i4.1
    IL_07F9: conv.r8
    IL_07FA: IL_EC
    IL_07FB: ldarg.2
    IL_07FC: nop
    IL_07FD: ldloc.0
    IL_07FE: ldarg.0
    IL_0803: ldfld 0x0400002B
    IL_0804: conv.i2
    IL_0805: IL_22
    IL_0806: ldelem.i
    IL_0807: IL_99
    IL_0808: IL_99
    IL_0809: IL_3E
    IL_080A: IL_5A
    IL_080B: not
    IL_080C: stloc.2
    IL_080D: ldarg.0
    IL_0812: ldfld 0x0400002C
    IL_0813: ldloc.2
    IL_0814: add
    IL_0815: stloc.3
    IL_0816: ldarg.0
    IL_081B: ldfld 0x0400002C
    IL_081C: ldarg.0
    IL_0821: ldfld 0x0400002B
    IL_0836: switch (4 cases)
    IL_0837: ldarg.2
    IL_0838: neg
    IL_0839: IL_59
    IL_083A: neg
    IL_083F: stfld 0x0400002C
    IL_0840: ldarg.0
    IL_0845: ldfld 0x0400005C
    IL_0846: ldarg.0
    IL_084B: ldfld 0x0400001E
    IL_084C: conv.r8
    IL_084D: ldc.i4.2
    IL_084E: nop
    IL_084F: nop
    IL_0850: stloc.0
    IL_0851: ldarg.0
    IL_0856: ldfld 0x04000053
    IL_0857: neg
    IL_0858: ldarg.0
    IL_085D: ldfld 0x04000050
    IL_085E: conv.r8
    IL_085F: IL_B7
    IL_0860: ldarg.1
    IL_0861: nop
    IL_0862: ldloc.0
    IL_0863: ldarg.0
    IL_0868: ldfld 0x0400005B
    IL_0869: ldarg.0
    IL_086E: ldfld 0x0400002B
    IL_086F: ldarg.0
    IL_0874: ldfld 0x0400002C
    IL_0875: ldarg.0
    IL_087A: ldfld 0x0400001E
    IL_087B: IL_22
    IL_087C: IL_CD
    IL_087D: IL_CC
    IL_087E: IL_CC
    IL_087F: IL_3E
    IL_0880: ldc.i4.m1
    IL_0881: conv.r8
    IL_0882: ldnull
    IL_0883: ldarg.1
    IL_0884: nop
    IL_0885: ldloc.0
    IL_0886: ldarg.0
    IL_088B: ldfld 0x0400002C
    IL_088C: ldc.i4.0
    IL_088D: IL_3D
    IL_088E: ldc.i4.1
    IL_088F: nop
    IL_0890: nop
    IL_0891: nop
    IL_0892: ldarg.0
    IL_0897: ldfld 0x04000022
    IL_089C: brfalse IL_08A9
    IL_089D: ldarg.0
    IL_089E: ldc.i4.2
    IL_08A3: call 0x06000013
    IL_08A8: br IL_0988
    IL_08A9: ldarg.0
    IL_08AE: ldfld 0x0400002C
    IL_08AF: ldloc.2
    IL_08B0: ldloc.3
    IL_08B1: IL_5A
    IL_08B2: IL_3C
    IL_08B3: IL_D1
    IL_08B4: nop
    IL_08B5: nop
    IL_08B6: nop
    IL_08B7: ldarg.0
    IL_08B8: IL_22
    IL_08B9: nop
    IL_08BA: nop
    IL_08BB: IL_96
    IL_08BC: IL_43
    IL_08C1: stfld 0x0400003C
    IL_08C2: ldarg.0
    IL_08C7: ldfld 0x0400001F
    IL_08C8: conv.r8
    IL_08CB: ldloc 0
    IL_08CC: stloc.0
    IL_08CD: ldarg.0
    IL_08D2: ldfld 0x0400001F
    IL_08D7: ldstr 0x70000081
    IL_08D8: conv.r8
    IL_08D9: IL_3C
    IL_08DA: nop
    IL_08DB: nop
    IL_08DC: stloc.0
    IL_08DD: pop
    IL_08DE: ldarg.0
    IL_08E3: ldfld 0x0400005D
    IL_08E4: ldc.i4.4
    IL_08E5: ldarg.0
    IL_08EA: ldfld 0x0400001E
    IL_08EB: conv.r8
    IL_08EC: ldc.i4.2
    IL_08ED: nop
    IL_08EE: nop
    IL_08EF: stloc.0
    IL_08F0: conv.r8
    IL_08F1: nop
    IL_08F2: ldarg.3
    IL_08F3: nop
    IL_08F4: ldloc.0
    IL_08F5: ldarg.0
    IL_08FA: ldfld 0x0400001D
    IL_08FB: ldarg.0
    IL_0900: ldfld 0x04000031
    IL_0901: ldelem.i
    IL_0906: call 0x0A00004A
    IL_090B: brfalse IL_0945
    IL_090C: ldarg.0
    IL_0911: ldfld 0x0400001D
    IL_0912: ldarg.0
    IL_0917: ldfld 0x04000031
    IL_0918: ldelem.i
    IL_0919: conv.r8
    IL_091A: stloc.0
    IL_091B: nop
    IL_091C: nop
    IL_091D: stloc.0
    IL_091E: ldc.i4.0
    IL_091F: conv.r8
    IL_0920: stloc.1
    IL_0921: nop
    IL_0922: nop
    IL_0923: stloc.0
    IL_0924: ldarg.0
    IL_0929: ldfld 0x0400001D
    IL_092A: ldarg.0
    IL_092F: ldfld 0x04000031
    IL_0930: ldelem.i
    IL_0935: call 0x0A00004B
    IL_0936: IL_22
    IL_0937: nop
    IL_0938: nop
    IL_0939: nop
    IL_093A: IL_41
    IL_093F: call 0x0A000008
    IL_0940: conv.r8
    IL_0941: ldloc.3
    IL_0942: nop
    IL_0943: nop
    IL_0944: stloc.0
    IL_0945: ldarg.0
    IL_094A: ldfld 0x04000015
    IL_094B: ldnull
    IL_0950: call 0x0A000021
    IL_0955: brfalse IL_0967
    IL_0956: ldarg.0
    IL_095B: ldfld 0x04000015
    IL_095C: conv.r8
    IL_095D: stloc.0
    IL_095E: nop
    IL_095F: nop
    IL_0960: stloc.0
    IL_0961: ldc.i4.0
    IL_0962: conv.r8
    IL_0963: stloc.1
    IL_0964: nop
    IL_0965: nop
    IL_0966: stloc.0
    IL_0967: ldarg.0
    IL_096C: ldfld 0x04000056
    IL_096D: ldarg.0
    IL_0972: ldfld 0x04000019
    IL_0973: conv.r8
    IL_0974: IL_4C
    IL_0975: nop
    IL_0976: nop
    IL_0977: stloc.0
    IL_0978: ldarg.0
    IL_097D: ldfld 0x04000056
    IL_097E: conv.r8
    IL_097F: IL_4D
    IL_0980: nop
    IL_0981: nop
    IL_0982: stloc.0
    IL_0987: br IL_0988
    IL_0988: ldarg.0
    IL_098D: call 0x0A00003D
    IL_098E: ldarg.0
    IL_0993: ldfld 0x04000050
    IL_0994: ldarg.0
    IL_0999: ldfld 0x0400003C
    IL_099E: call 0x0A000008
    IL_099F: conv.r8
    IL_09A0: IL_3E
    IL_09A1: nop
    IL_09A2: nop
    IL_09A3: stloc.0
    IL_09A4: ret
    }

    public void Grabed() {
    IL_0000: ret
    }

    public void SetLevel() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.1
    IL_0003: IL_58
    IL_0004: neg
    IL_0009: stfld 0x0400002A
    IL_000A: ldarg.0
    IL_000B: ldarg.2
    IL_0010: stfld 0x04000049
    IL_0011: ldarg.0
    IL_0012: IL_22
    IL_0013: IL_CD
    IL_0014: IL_CC
    IL_0015: stloc.2
    IL_0016: IL_3F
    IL_0017: ldarg.0
    IL_001C: ldfld 0x0400002A
    IL_001D: conv.i2
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_89696D25: switch (576346944 cases)
    }

    public void Freeze() {
    IL_0004: newobj 0x06000707
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001005
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void Petrify() {
    IL_0004: newobj 0x0600070D
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001009
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void Dead() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s -4
    IL_0007: stfld 0x04000017
    IL_0008: ldarg.0
    IL_0009: ldc.i4.0
    IL_000E: stfld 0x04000022
    IL_000F: ldarg.0
    IL_0014: ldfld 0x0400005B
    IL_0015: conv.r8
    IL_0016: ldc.i4.m1
    IL_0017: ldarg.1
    IL_0018: nop
    IL_0019: ldloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000021
    IL_0020: ldnull
    IL_0025: call 0x0A000021
    IL_002A: brfalse IL_0048
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000021
    IL_0031: ldnull
    IL_0032: conv.r8
    IL_0033: IL_4E
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000021
    IL_003D: conv.r8
    IL_003E: ldloc.3
    IL_003F: nop
    IL_0040: nop
    IL_0042: br.s IL_005A
    IL_0043: conv.r8
    IL_0044: IL_F6
    IL_0045: ldloc.0
    IL_0046: nop
    IL_0047: ldloc.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000059
    IL_004E: ldc.i4.4
    IL_004F: conv.r8
    IL_0050: IL_EC
    IL_0051: ldarg.2
    IL_0052: nop
    IL_0053: ldloc.0
    IL_0054: ldarg.0
    IL_0059: call 0x0A00000A
    IL_005E: call 0x0A000050
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000020
    IL_0065: conv.r8
    IL_0066: stloc.0
    IL_0067: nop
    IL_0068: nop
    IL_0069: stloc.0
    IL_006E: call 0x0A000050
    IL_006F: ldarg.0
    IL_0074: ldfld 0x0400004F
    IL_0075: conv.r8
    IL_0076: stloc.0
    IL_0077: nop
    IL_0078: nop
    IL_0079: stloc.0
    IL_007E: call 0x0A000050
    IL_007F: ldc.i4.0
    IL_0080: stloc.0
    IL_0085: br IL_00AF
    IL_0086: ldarg.0
    IL_008B: ldfld 0x0400001D
    IL_008C: ldloc.0
    IL_008D: ldelem.i
    IL_008E: ldnull
    IL_0093: call 0x0A000021
    IL_0098: brfalse IL_00AB
    IL_0099: ldarg.0
    IL_009E: ldfld 0x0400001D
    IL_009F: ldloc.0
    IL_00A0: ldelem.i
    IL_00A1: conv.r8
    IL_00A2: stloc.0
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00AA: call 0x0A000050
    IL_00AB: ldloc.0
    IL_00AC: ldc.i4.1
    IL_00AD: IL_58
    IL_00AE: stloc.0
    IL_00AF: ldloc.0
    IL_00B0: ldc.i4.3
    IL_00B1: IL_3F
    IL_00B6: ldtoken 0x02FFFFFF
    IL_00BB: ldfld 0x04000015
    IL_00BC: ldnull
    IL_00C1: call 0x0A000021
    IL_00C6: brfalse IL_00D7
    IL_00C7: ldarg.0
    IL_00CC: ldfld 0x04000015
    IL_00CD: conv.r8
    IL_00CE: stloc.0
    IL_00CF: nop
    IL_00D0: nop
    IL_00D1: stloc.0
    IL_00D6: call 0x0A000050
    IL_00D7: ldarg.0
    IL_00DC: ldfld 0x04000013
    IL_00DE: ldc.i4.s 9
    IL_00E3: beq IL_0159
    IL_00E4: ldarg.0
    IL_00E9: ldfld 0x04000058
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x0400002E
    IL_00F0: conv.r8
    IL_00F5: ldobj 0x02060001
    IL_00FA: ldfld 0x0400005C
    IL_00FB: ldarg.1
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x0400001E
    IL_0102: conv.r8
    IL_0103: ldc.i4.2
    IL_0104: nop
    IL_0105: nop
    IL_0106: stloc.0
    IL_0107: ldarg.0
    IL_010C: ldfld 0x04000016
    IL_0111: call 0x0A00004B
    IL_0112: IL_22
    IL_0113: nop
    IL_0114: nop
    IL_0119: ldc.i4 534592
    IL_011A: nop
    IL_011B: stloc.0
    IL_011C: ldarg.0
    IL_0121: ldfld 0x04000050
    IL_0122: conv.r8
    IL_0123: IL_B4
    IL_0124: ldarg.1
    IL_0125: nop
    IL_0126: ldloc.0
    IL_0127: ldarg.0
    IL_012C: ldfld 0x0400005C
    IL_012D: ldarg.0
    IL_0132: ldfld 0x0400002A
    IL_0133: ldarg.0
    IL_0138: ldfld 0x0400001E
    IL_0139: conv.r8
    IL_013A: ldc.i4.2
    IL_013B: nop
    IL_013C: nop
    IL_013D: stloc.0
    IL_013E: conv.r8
    IL_013F: IL_BF
    IL_0140: ldarg.1
    IL_0141: nop
    IL_0142: ldloc.0
    IL_0143: ldarg.0
    IL_0148: ldfld 0x0400005D
    IL_0149: ldarg.0
    IL_014E: ldfld 0x04000013
    IL_014F: conv.r8
    IL_0150: ldarg.0
    IL_0151: ldarg.3
    IL_0152: nop
    IL_0153: ldloc.0
    IL_0158: br IL_017A
    IL_0159: ldarg.0
    IL_015E: ldfld 0x0400005D
    IL_015F: ldarg.0
    IL_0164: ldfld 0x0400001E
    IL_0165: conv.r8
    IL_0166: ldc.i4.2
    IL_0167: nop
    IL_0168: nop
    IL_0169: stloc.0
    IL_016A: ldarg.0
    IL_016F: ldfld 0x0400001E
    IL_0170: conv.r8
    IL_0171: pop
    IL_0172: nop
    IL_0173: nop
    IL_0174: stloc.0
    IL_0175: conv.r8
    IL_0176: IL_FC
    IL_0177: ldarg.2
    IL_0178: nop
    IL_0179: ldloc.0
    IL_017A: ret
    }

    public void Impact2() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000015
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000B: br.s IL_000E
    IL_0010: ldfld 0x0400002D
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000031
    IL_0017: IL_92
    IL_0018: conv.r8
    IL_0019: IL_F1
    IL_001A: ldloc.0
    IL_001B: nop
    IL_001C: ldloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000015
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
    IL_0033: ldfld 0x0400005A
    IL_0034: conv.r8
    IL_0035: IL_35
    IL_0036: IL_01
    IL_0037: nop
    IL_0038: ldloc.0
    IL_0039: ret
    }

    public void Impact() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000015
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000B: br.s IL_000E
    IL_0010: ldfld 0x0400002D
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000031
    IL_0017: IL_92
    IL_0018: conv.r8
    IL_0019: IL_F1
    IL_001A: ldloc.0
    IL_001B: nop
    IL_001C: ldloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000015
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
    IL_002E: ret
    }

    public void SetDir() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000022
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000029
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: IL_41
    IL_001A: stloc 0
    IL_001B: nop
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000025
    IL_0026: brfalse IL_0066
    IL_0027: ldarg.0
    IL_0028: ldc.i4.0
    IL_0029: ldc.i4.6
    IL_002E: call 0x0A000045
    IL_0033: stfld 0x04000030
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000030
    IL_003E: brtrue IL_005B
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000056
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000018
    IL_004B: conv.r8
    IL_004C: IL_4C
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000056
    IL_0056: conv.r8
    IL_0057: IL_4D
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: ldarg.0
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_0063: stsfld 0x00297D3F
    IL_0064: nop
    IL_0065: ldarg.2
    IL_0066: ldarg.0
    IL_006B: ldfld 0x0400004E
    IL_006C: conv.r8
    IL_006D: ldc.i4.2
    IL_006E: nop
    IL_006F: nop
    IL_0070: stloc.0
    IL_0071: stloc.0
    IL_0073: ldloca.s 0
    IL_0078: ldfld 0x0A000023
    IL_0079: IL_22
    IL_007A: nop
    IL_007B: nop
    IL_007C: nop
    IL_318D: switch (3139 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000022
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_000D: dup
    IL_0012: ldfld 0x04000029
    IL_0017: call 0x0A000024
    IL_0018: IL_59
    IL_001D: stfld 0x04000029
    IL_001E: ldarg.0
    IL_0023: ldfld 0x0400001F
    IL_0028: ldstr 0x7000013D
    IL_0029: conv.r8
    IL_002A: IL_56
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_0032: brfalse IL_0034
    IL_0033: ret
    IL_0034: ldarg.0
    IL_0039: ldfld 0x0400001F
    IL_003E: ldstr 0x70000081
    IL_003F: conv.r8
    IL_0040: IL_56
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0048: brfalse IL_0055
    IL_0049: ldarg.0
    IL_004A: ldc.i4.m1
    IL_004F: stfld 0x04000017
    IL_0054: br IL_05C7
    IL_0055: ldarg.0
    IL_005A: ldfld 0x0400001F
    IL_005F: ldstr 0x7000008F
    IL_0060: conv.r8
    IL_0061: IL_56
    IL_0062: nop
    IL_0063: nop
    IL_0064: stloc.0
    IL_0069: brtrue IL_0094
    IL_006A: ldarg.0
    IL_006F: ldfld 0x0400001F
    IL_0074: ldstr 0x700000BB
    IL_0075: conv.r8
    IL_0076: IL_56
    IL_0077: nop
    IL_0078: nop
    IL_0079: stloc.0
    IL_007E: brtrue IL_0094
    IL_007F: ldarg.0
    IL_0084: ldfld 0x0400001F
    IL_0089: ldstr 0x700000E7
    IL_008A: conv.r8
    IL_008B: IL_56
    IL_008C: nop
    IL_008D: nop
    IL_008E: stloc.0
    IL_0093: brfalse IL_01FA
    IL_0094: ldarg.0
    IL_0095: ldc.i4.0
    IL_009A: stfld 0x04000023
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000051
    IL_00A5: call 0x0A00001B
    IL_00AA: call 0x0A00001C
    IL_00AF: brfalse IL_00C1
    IL_00B0: ldarg.0
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000051
    IL_00BB: call 0x0A00001D
    IL_00C0: stfld 0x04000052
    IL_00C1: ldarg.0
    IL_00C6: ldfld 0x0400001E
    IL_00C7: ldarg.0
    IL_00CC: ldfld 0x0400001E
    IL_00CD: conv.r8
    IL_00CE: pop
    IL_00CF: nop
    IL_00D0: nop
    IL_00D1: stloc.0
    IL_00D2: ldarg.0
    IL_00D7: ldfld 0x04000052
    IL_00DC: call 0x0A000024
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x04000028
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000027
    IL_00E9: conv.r8
    IL_00EE: call 0x020A0000
    IL_00F3: ldfld 0x04000017
    IL_00F5: ldc.i4.s 11
    IL_00FA: beq IL_014F
    IL_00FB: ldarg.0
    IL_0100: ldfld 0x04000027
    IL_0101: ldarg.0
    IL_0106: ldfld 0x04000031
    IL_0107: IL_91
    IL_010C: brfalse IL_012B
    IL_010D: ldarg.0
    IL_0112: ldfld 0x04000043
    IL_0117: brtrue IL_012B
    IL_0118: ldarg.0
    IL_011D: ldfld 0x04000046
    IL_011E: ldc.i4.0
    IL_011F: conv.r8
    IL_0121: ldc.i4.s 0
    IL_0122: nop
    IL_0123: stloc.0
    IL_0124: ldarg.0
    IL_0125: ldc.i4.1
    IL_012A: stfld 0x04000043
    IL_012B: ldarg.0
    IL_0130: ldfld 0x04000026
    IL_0131: ldarg.0
    IL_0136: ldfld 0x04000031
    IL_0137: IL_92
    IL_0138: ldc.i4.2
    IL_0181: switch (17 cases)
    IL_0183: ble.s IL_0184
    IL_0184: nop
    IL_0185: ldarg.2
    IL_0186: IL_8F
    IL_0187: ldnull
    IL_0188: nop
    IL_0189: nop
    IL_018A: IL_01
    IL_018F: ldfld 0x0A000059
    IL_0190: IL_43
    IL_0193: ldarga 0
    IL_0194: nop
    IL_0195: ldarg.0
    IL_019A: ldfld 0x0400001E
    IL_019B: dup
    IL_019C: conv.r8
    IL_019D: ldc.i4.2
    IL_019E: nop
    IL_019F: nop
    IL_01A0: stloc.0
    IL_01A1: ldarg.0
    IL_01A6: ldfld 0x04000051
    IL_01AB: call 0x0A000024
    IL_01B0: call 0x0A000008
    IL_01B1: ldarg.0
    IL_01B6: ldfld 0x04000038
    IL_01B7: ldarg.0
    IL_01BC: ldfld 0x04000031
    IL_01BD: IL_8F
    IL_01BE: ldnull
    IL_01BF: nop
    IL_01C0: nop
    IL_01C1: IL_01
    IL_01C6: ldfld 0x0A00005A
    IL_01CB: call 0x0A000008
    IL_01D0: call 0x0A000029
    IL_01D1: conv.r8
    IL_01D2: ldloc.3
    IL_01D3: nop
    IL_01D4: nop
    IL_01D5: stloc.0
    IL_01DA: br IL_01ED
    IL_01DB: ldarg.0
    IL_01DC: dup
    IL_01E1: ldfld 0x0400003A
    IL_01E6: call 0x0A000024
    IL_01E7: IL_58
    IL_01EC: stfld 0x0400003A
    IL_01ED: ldarg.0
    IL_01EF: ldc.i4.s 11
    IL_01F4: stfld 0x04000017
    IL_01F9: br IL_05C7
    IL_01FA: ldarg.0
    IL_01FF: ldfld 0x0400001F
    IL_0204: ldstr 0x700000A3
    IL_0205: conv.r8
    IL_0206: IL_56
    IL_0207: nop
    IL_0208: nop
    IL_0209: stloc.0
    IL_020E: brtrue IL_0239
    IL_020F: ldarg.0
    IL_0214: ldfld 0x0400001F
    IL_0219: ldstr 0x700000CF
    IL_021A: conv.r8
    IL_021B: IL_56
    IL_021C: nop
    IL_021D: nop
    IL_021E: stloc.0
    IL_0223: brtrue IL_0239
    IL_0224: ldarg.0
    IL_0229: ldfld 0x0400001F
    IL_022E: ldstr 0x700000FB
    IL_022F: conv.r8
    IL_0230: IL_56
    IL_0231: nop
    IL_0232: nop
    IL_0233: stloc.0
    IL_0238: brfalse IL_050E
    IL_0239: ldarg.0
    IL_023B: ldc.i4.s 12
    IL_0240: stfld 0x04000017
    IL_0241: ldarg.0
    IL_0246: ldfld 0x04000023
    IL_024B: brtrue IL_0509
    IL_024C: ldarg.0
    IL_0251: ldfld 0x04000043
    IL_0256: brfalse IL_026A
    IL_0257: ldarg.0
    IL_025C: ldfld 0x04000046
    IL_025D: ldc.i4.1
    IL_025E: conv.r8
    IL_0260: ldc.i4.s 0
    IL_0261: nop
    IL_0262: stloc.0
    IL_0263: ldarg.0
    IL_0264: ldc.i4.0
    IL_0269: stfld 0x04000043
    IL_026A: ldarg.0
    IL_026F: call 0x0A00003D
    IL_0270: ldarg.0
    IL_0275: ldfld 0x0400001E
    IL_0276: conv.r8
    IL_0277: IL_22
    IL_0278: nop
    IL_0279: nop
    IL_027A: stloc.0
    IL_027B: ldarg.0
    IL_0280: ldfld 0x04000037
    IL_0281: ldarg.0
    IL_0286: ldfld 0x04000031
    IL_0287: IL_92
    IL_0288: conv.i2
    IL_028D: call 0x0A000008
    IL_028E: conv.r8
    IL_028F: IL_3E
    IL_0290: nop
    IL_0291: nop
    IL_0292: stloc.0
    IL_0293: ldarg.0
    IL_0294: ldc.i4.1
    IL_0299: stfld 0x04000023
    IL_029A: ldarg.0
    IL_029F: ldfld 0x0400001E
    IL_02A0: conv.r8
    IL_02A1: ldc.i4.2
    IL_02A2: nop
    IL_02A3: nop
    IL_02A4: stloc.0
    IL_02A9: call 0x0A000007
    IL_02AA: ldarg.0
    IL_02AF: ldfld 0x04000014
    IL_02B0: ldarg.0
    IL_02B5: ldfld 0x04000031
    IL_02B6: ldelem.i
    IL_02B7: conv.r8
    IL_02B8: add
    IL_02B9: nop
    IL_02BA: nop
    IL_02BB: stloc.0
    IL_02BC: stloc.2
    IL_02BE: ldloca.s 2
    IL_02C3: ldfld 0x0A000023
    IL_02C8: call 0x0A000008
    IL_02CD: call 0x0A000029
    IL_02CE: ldarg.0
    IL_02D3: ldfld 0x0400001E
    IL_02D4: conv.r8
    IL_02D5: IL_22
    IL_02D6: nop
    IL_02D7: nop
    IL_02D8: stloc.0
    IL_02D9: ldarg.0
    IL_02DE: ldfld 0x04000014
    IL_02DF: ldarg.0
    IL_02E4: ldfld 0x04000031
    IL_02E5: ldelem.i
    IL_02E6: conv.r8
    IL_02E7: add
    IL_02E8: nop
    IL_02E9: nop
    IL_02EA: stloc.0
    IL_02EB: stloc.3
    IL_02ED: ldloca.s 3
    IL_02F2: ldfld 0x0A00005C
    IL_02F7: call 0x0A000008
    IL_02FC: call 0x0A000029
    IL_02FD: ldarg.0
    IL_0302: ldfld 0x0400001E
    IL_0303: conv.r8
    IL_0304: mul
    IL_0305: nop
    IL_0306: nop
    IL_0307: stloc.0
    IL_0308: ldarg.0
    IL_030D: ldfld 0x04000014
    IL_030E: ldarg.0
    IL_0313: ldfld 0x04000031
    IL_0314: ldelem.i
    IL_0315: conv.r8
    IL_0316: add
    IL_0317: nop
    IL_0318: nop
    IL_0319: stloc.0
    IL_031B: stloc.s 4
    IL_031D: ldloca.s 4
    IL_0322: ldfld 0x0A00005E
    IL_0327: call 0x0A000008
    IL_032C: call 0x0A000029
    IL_032D: stloc.0
    IL_032E: ldarg.0
    IL_0333: ldfld 0x04000014
    IL_0334: ldarg.0
    IL_0339: ldfld 0x04000031
    IL_033A: ldelem.i
    IL_033B: conv.r8
    IL_033C: div.un
    IL_033D: nop
    IL_033E: nop
    IL_033F: stloc.0
    IL_0341: stloc.s 5
    IL_0343: ldloca.s 5
    IL_0348: ldfld 0x0A00005E
    IL_0349: ldarg.0
    IL_034E: ldfld 0x04000014
    IL_034F: ldarg.0
    IL_0354: ldfld 0x04000031
    IL_0355: ldelem.i
    IL_0356: conv.r8
    IL_0357: div.un
    IL_0358: nop
    IL_0359: nop
    IL_035A: stloc.0
    IL_035C: stloc.s 6
    IL_035E: ldloca.s 6
    IL_0363: ldfld 0x0A000023
    IL_0364: ldarg.0
    IL_0369: ldfld 0x0400001E
    IL_036A: conv.r8
    IL_036B: div.un
    IL_036C: nop
    IL_036D: nop
    IL_036E: stloc.0
    IL_0370: stloc.s 7
    IL_0372: ldloca.s 7
    IL_0377: ldfld 0x0A000023
    IL_0378: IL_58
    IL_0379: ldarg.0
    IL_037E: ldfld 0x04000014
    IL_037F: ldarg.0
    IL_0384: ldfld 0x04000031
    IL_0385: ldelem.i
    IL_0386: conv.r8
    IL_0387: div.un
    IL_0388: nop
    IL_0389: nop
    IL_038A: stloc.0
    IL_038C: stloc.s 8
    IL_038E: ldloca.s 8
    IL_0393: ldfld 0x0A00005C
    IL_0398: call 0x0A000060
    IL_0399: stloc.1
    IL_039A: ldarg.0
    IL_039F: ldfld 0x0400001D
    IL_03A0: ldarg.0
    IL_03A5: ldfld 0x04000031
    IL_03A6: ldelem.i
    IL_03A7: ldnull
    IL_03AC: call 0x0A000061
    IL_03B1: brfalse IL_0474
    IL_03B2: ldarg.0
    IL_03B7: ldfld 0x0400001D
    IL_03B8: ldarg.0
    IL_03BD: ldfld 0x04000031
    IL_03BE: ldarg.0
    IL_03C3: ldfld 0x04000014
    IL_03C4: ldarg.0
    IL_03C9: ldfld 0x04000031
    IL_03CA: ldelem.i
    IL_03CB: ldloc.0
    IL_03CC: ldloc.1
    IL_03D1: call 0x0A000014
    IL_03D2: conv.u4
    IL_03D3: ldarg.1
    IL_03D4: nop
    IL_03D5: nop
    IL_03D6: IL_01
    IL_03DB: stelem 0x001D7B02
    IL_03DC: nop
    IL_03DD: ldarg.2
    IL_03DE: ldarg.0
    IL_03E3: ldfld 0x04000031
    IL_03E4: ldelem.i
    IL_03E5: conv.r8
    IL_03E6: stloc.0
    IL_03E7: nop
    IL_03E8: nop
    IL_03E9: stloc.0
    IL_03EA: ldc.i4.1
    IL_03EB: conv.r8
    IL_03EC: stloc.1
    IL_03ED: nop
    IL_03EE: nop
    IL_03EF: stloc.0
    IL_03F0: ldarg.0
    IL_03F5: ldfld 0x0400001D
    IL_03F6: ldarg.0
    IL_03FB: ldfld 0x04000031
    IL_03FC: ldelem.i
    IL_03FD: conv.r8
    IL_03FE: stloc.0
    IL_03FF: nop
    IL_0400: nop
    IL_0402: br.s IL_0405
    IL_0407: ldfld 0x0400002D
    IL_0408: ldarg.0
    IL_040D: ldfld 0x04000031
    IL_040E: IL_92
    IL_040F: conv.r8
    IL_0410: IL_F1
    IL_0411: ldloc.0
    IL_0412: nop
    IL_0413: ldloc.0
    IL_0414: ldarg.0
    IL_0419: ldfld 0x04000026
    IL_041A: ldarg.0
    IL_041F: ldfld 0x04000031
    IL_0420: IL_92
    IL_0421: ldc.i4.1
    IL_0422: IL_3F
    IL_0425: ldloc 0
    IL_0426: nop
    IL_0427: ldarg.0
    IL_042C: ldfld 0x0400001D
    IL_042D: ldarg.0
    IL_0432: ldfld 0x04000031
    IL_0433: ldelem.i
    IL_0434: ldarg.0
    IL_0439: ldfld 0x0400001E
    IL_043A: conv.r8
    IL_043B: IL_4E
    IL_043C: nop
    IL_043D: nop
    IL_043E: stloc.0
    IL_043F: ldarg.0
    IL_0444: ldfld 0x04000026
    IL_0445: ldarg.0
    IL_044A: ldfld 0x04000031
    IL_044B: IL_92
    IL_044C: ldc.i4.2
    IL_04C5: switch (29 cases)
    IL_04C6: nop
    IL_04C7: stloc.0
    IL_04C8: ldarg.0
    IL_04CD: ldfld 0x0400001E
    IL_04CE: conv.r8
    IL_04CF: ldc.i4.2
    IL_04D0: nop
    IL_04D1: nop
    IL_04D2: stloc.0
    IL_04D4: stloc.s 9
    IL_04D6: ldloca.s 9
    IL_04DB: ldfld 0x0A00005E
    IL_04E0: call 0x0A000008
    IL_04E5: call 0x0A000042
    IL_04E6: ldarg.0
    IL_04EB: ldfld 0x0400001E
    IL_04EC: conv.r8
    IL_04ED: ldc.i4.2
    IL_04EE: nop
    IL_04EF: nop
    IL_04F0: stloc.0
    IL_04F2: stloc.s 10
    IL_04F4: ldloca.s 10
    IL_04F9: ldfld 0x0A00005C
    IL_04FE: call 0x0A000008
    IL_0503: call 0x0A000029
    IL_0504: conv.r8
    IL_0505: ldloc.3
    IL_0506: nop
    IL_0507: nop
    IL_0508: stloc.0
    IL_050D: br IL_05C7
    IL_050E: ldarg.0
    IL_0513: ldfld 0x0400001F
    IL_0518: ldstr 0x70000073
    IL_0519: conv.r8
    IL_051A: IL_56
    IL_051B: nop
    IL_051C: nop
    IL_051D: stloc.0
    IL_0522: brfalse IL_05B9
    IL_0523: ldarg.0
    IL_0524: ldc.i4.0
    IL_0529: stfld 0x04000024
    IL_052A: ldarg.0
    IL_052B: ldc.i4.1
    IL_0530: stfld 0x04000017
    IL_0531: ldarg.0
    IL_0536: ldfld 0x0400001E
    IL_0537: dup
    IL_0538: conv.r8
    IL_0539: ldc.i4.2
    IL_053A: nop
    IL_053B: nop
    IL_053C: stloc.0
    IL_053D: ldarg.0
    IL_0542: ldfld 0x04000051
    IL_0547: call 0x0A000024
    IL_054C: call 0x0A000008
    IL_054D: ldarg.0
    IL_0552: ldfld 0x04000033
    IL_0557: call 0x0A000008
    IL_055C: call 0x0A000029
    IL_055D: conv.r8
    IL_055E: ldloc.3
    IL_055F: nop
    IL_0560: nop
    IL_0561: stloc.0
    IL_0562: ldarg.0
    IL_0567: ldfld 0x04000051
    IL_056C: call 0x0A00001B
    IL_0571: call 0x0A00001C
    IL_0576: brfalse IL_0588
    IL_0577: ldarg.0
    IL_0578: ldarg.0
    IL_057D: ldfld 0x04000051
    IL_0582: call 0x0A00001D
    IL_0587: stfld 0x04000052
    IL_0588: ldarg.0
    IL_058D: ldfld 0x0400001E
    IL_058E: ldarg.0
    IL_0593: ldfld 0x0400001E
    IL_0594: conv.r8
    IL_0595: pop
    IL_0596: nop
    IL_0597: nop
    IL_0598: stloc.0
    IL_0599: ldarg.0
    IL_059E: ldfld 0x04000052
    IL_05A3: call 0x0A000024
    IL_05A4: IL_22
    IL_05A5: nop
    IL_05A6: nop
    IL_9CA16EAB: switch (656955968 cases)
    }

    }}
