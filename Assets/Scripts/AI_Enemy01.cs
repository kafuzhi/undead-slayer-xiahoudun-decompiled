// Namespace: 
// Type: AI_Enemy01

    public class AI_Enemy01 {{

    public object enemykind;
    public object ef_weapon;
    public object monmovestat;
    private object snd_move;
    public object snd_attack;
    public object direction_arrow;
    private object clone_weapon;
    private object clone_arrow;
    private object cha1;
    private object target;
    private object target_onlyone;
    private object hpbar;
    private object originTex;
    private object life;
    private object spawn_ing;
    private object pierce;
    private object impact;
    private object attackstart;
    private object attach_weaponEf;
    private object showme;
    private object lastmon;
    private object targetreset;
    private object kind;
    private object shadow_index;
    private object target_fix;
    private object poison;
    private object poison_delay;
    private object magnitude_behitdir;
    private object old_delay;
    private object poison_damage;
    private object petrify_rate;
    private object movespeed;
    private object behaviour_delay;
    private object hpbar_height;
    private object behaviour;
    private object hp;
    private object level;
    private object maxhp;
    private object power;
    private object haveExp;
    private object block;
    private object sizekind;
    private object runspeed;
    private object backspeed;
    private object firerange;
    private object moving_atk;
    private object grabstyle;
    private object grabed;
    private object downhigh;
    private object risedrop;
    private object f_risefactor;
    private object chamovestat;
    private object directionVector;
    private object attackstartVector;
    private object attackdir;
    private object damage;
    private object accuracy;
    private object speed_idle;
    private object attackrange;
    private object dash;
    private object script_cha;
    private object script_sound;
    private object script_cam;
    private object script_hpbar;
    private object script_monEf;
    private object bethrust;
    private object bekicked;
    private object attack_impact;
    private object getup;
    private object lookrotation;
    private object attackforce;
    private object playkind;
    private object mytransform;
    private object myanimation;
    private object myaudio;
    private object monrender;
    private object att_status;
    private object restrictArea;
    private object enemy;

    public AI_Enemy01() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x0400006C
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_1FE04: switch (32637 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040000A7
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00002A
    IL_0017: stfld 0x040000A8
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A00002B
    IL_0023: stfld 0x040000A9
    IL_0024: ldarg.0
    IL_0029: ldstr 0x7000012D
    IL_002E: call 0x0A000004
    IL_002F: conv.r8
    IL_0030: ldloc.1
    IL_0031: nop
    IL_0032: nop
    IL_0034: br.s IL_00B2
    IL_0035: ldelem.r4
    IL_0036: nop
    IL_0037: nop
    IL_0038: ldarg.2
    IL_0039: ldarg.0
    IL_003E: ldstr 0x70000063
    IL_0043: call 0x0A000004
    IL_0044: conv.r8
    IL_0045: stloc.1
    IL_0046: nop
    IL_0047: nop
    IL_0049: br.s IL_00C5
    IL_004A: IL_EC
    IL_004B: ldarg.2
    IL_004C: nop
    IL_004D: ldarg.2
    IL_004E: ldarg.0
    IL_0053: ldfld 0x0400005F
    IL_0054: IL_8F
    IL_0055: rem.un
    IL_0056: nop
    IL_0057: nop
    IL_0058: ldarg.0
    IL_005D: ldobj 0x02000061
    IL_0062: stfld 0x040000AD
    IL_0063: ldarg.0
    IL_0068: ldstr 0x70000001
    IL_006D: call 0x0A000004
    IL_006E: conv.r8
    IL_006F: ldarg.3
    IL_0070: nop
    IL_0071: nop
    IL_0072: stloc.0
    IL_0077: stfld 0x04000067
    IL_0078: ldarg.0
    IL_0079: ldarg.0
    IL_007E: ldfld 0x04000067
    IL_007F: conv.r8
    IL_0080: stloc.2
    IL_0081: nop
    IL_0082: nop
    IL_0084: br.s IL_0102
    IL_0085: ldelem.i1
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldarg.2
    IL_0089: ldarg.0
    IL_008E: ldstr 0x70000121
    IL_0093: call 0x0A000004
    IL_0094: conv.r8
    IL_0095: ldarg.3
    IL_0096: nop
    IL_0097: nop
    IL_0099: br.s IL_0117
    IL_009A: ldelem.i2
    IL_009B: nop
    IL_009C: nop
    IL_009D: ldarg.2
    IL_009E: ldarg.0
    IL_00A3: call 0x0A000035
    IL_00A4: conv.r8
    IL_00A5: ldloc.0
    IL_00A6: nop
    IL_00A7: nop
    IL_00A9: br.s IL_0127
    IL_00AA: ldelem.i4
    IL_00AB: nop
    IL_00AC: nop
    IL_00AD: ldarg.2
    IL_00AE: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000084
    IL_0007: ldarg.0
    IL_000C: ldflda 0x040000AD
    IL_0011: ldfld 0x040004DB
    IL_0012: IL_58
    IL_0013: neg
    IL_0018: stfld 0x04000084
    IL_0019: ldarg.0
    IL_001A: dup
    IL_001F: ldfld 0x04000085
    IL_0020: ldarg.0
    IL_0025: ldflda 0x040000AD
    IL_002A: ldfld 0x040004DC
    IL_002B: IL_58
    IL_002C: neg
    IL_0031: stfld 0x04000085
    IL_0032: ldarg.0
    IL_0033: dup
    IL_0038: ldfld 0x04000086
    IL_0039: ldarg.0
    IL_003E: ldflda 0x040000AD
    IL_0043: ldfld 0x040004DD
    IL_0044: conv.i2
    IL_0045: IL_58
    IL_004A: stfld 0x04000086
    IL_004B: ldarg.0
    IL_004C: dup
    IL_0051: ldfld 0x04000087
    IL_0052: ldarg.0
    IL_0057: ldflda 0x040000AD
    IL_005C: ldfld 0x040004DE
    IL_005D: IL_58
    IL_005E: neg
    IL_0063: stfld 0x04000087
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldflda 0x040000AD
    IL_006F: ldfld 0x040004DF
    IL_0074: stfld 0x04000088
    IL_0075: ldarg.0
    IL_0076: ldarg.0
    IL_007B: ldflda 0x040000AD
    IL_0080: ldfld 0x040004E0
    IL_0085: stfld 0x04000089
    IL_0086: ldarg.0
    IL_0087: ldarg.0
    IL_008C: ldflda 0x040000AD
    IL_0091: ldfld 0x040004E1
    IL_0096: stfld 0x0400008A
    IL_0097: ldarg.0
    IL_0098: ldarg.0
    IL_009D: ldflda 0x040000AD
    IL_00A2: ldfld 0x040004E2
    IL_00A7: stfld 0x0400008B
    IL_00A8: ldarg.0
    IL_00A9: ldarg.0
    IL_00AE: ldflda 0x040000AD
    IL_00B3: ldfld 0x040004E3
    IL_00B8: stfld 0x0400008C
    IL_00B9: ldarg.0
    IL_00BA: ldarg.0
    IL_00BF: ldflda 0x040000AD
    IL_00C4: ldfld 0x040004EA
    IL_00C9: stfld 0x04000075
    IL_00CA: ldarg.0
    IL_00CB: ldarg.0
    IL_00D0: ldflda 0x040000AD
    IL_00D5: ldfld 0x040004E5
    IL_00DA: stfld 0x0400009A
    IL_00DB: ldarg.0
    IL_00DC: ldarg.0
    IL_00E1: ldflda 0x040000AD
    IL_00E6: ldfld 0x040004E4
    IL_00EB: stfld 0x04000071
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x040000A8
    IL_00F6: ldstr 0x7000016D
    IL_00F7: conv.r8
    IL_00F9: bge.s IL_00FA
    IL_00FA: nop
    IL_00FB: stloc.0
    IL_00FC: ldarg.0
    IL_0101: ldflda 0x040000AD
    IL_0106: ldfld 0x040004E6
    IL_0107: conv.r8
    IL_0109: bgt.s IL_010A
    IL_010A: nop
    IL_010B: stloc.0
    IL_010C: ldarg.0
    IL_0111: ldfld 0x040000A8
    IL_0116: ldstr 0x70000177
    IL_0117: conv.r8
    IL_0119: bge.s IL_011A
    IL_011A: nop
    IL_011B: stloc.0
    IL_011C: IL_22
    IL_011D: IL_8F
    IL_011E: IL_C2
    IL_011F: conv.u8
    IL_0120: IL_3E
    IL_0121: conv.r8
    IL_0123: bgt.s IL_0124
    IL_0124: nop
    IL_0125: stloc.0
    IL_0126: ldarg.0
    IL_012B: ldfld 0x040000A8
    IL_0130: ldstr 0x70000181
    IL_0131: conv.r8
    IL_0133: bge.s IL_0134
    IL_0134: nop
    IL_0135: stloc.0
    IL_0136: IL_22
    IL_0137: IL_29
    IL_0138: sub
    IL_0139: IL_8F
    IL_013A: IL_3E
    IL_013B: conv.r8
    IL_013D: bgt.s IL_013E
    IL_013E: nop
    IL_013F: stloc.0
    IL_0140: ldarg.0
    IL_0145: ldfld 0x040000A8
    IL_014A: ldstr 0x70000195
    IL_014B: conv.r8
    IL_014D: bge.s IL_014E
    IL_014E: nop
    IL_014F: stloc.0
    IL_0150: ldarg.0
    IL_0155: ldflda 0x040000AD
    IL_015A: ldfld 0x040004E7
    IL_015B: conv.r8
    IL_015D: bgt.s IL_015E
    IL_015E: nop
    IL_015F: stloc.0
    IL_0160: ldarg.0
    IL_0165: ldfld 0x040000A8
    IL_016A: ldstr 0x700001A9
    IL_016B: conv.r8
    IL_016D: bge.s IL_016E
    IL_016E: nop
    IL_016F: stloc.0
    IL_0170: ldarg.0
    IL_0175: ldflda 0x040000AD
    IL_017A: ldfld 0x040004E8
    IL_017B: conv.r8
    IL_017D: bgt.s IL_017E
    IL_017E: nop
    IL_017F: stloc.0
    IL_0180: ldarg.0
    IL_0185: ldfld 0x040000A8
    IL_018A: ldstr 0x700001C1
    IL_018B: conv.r8
    IL_018D: bge.s IL_018E
    IL_018E: nop
    IL_018F: stloc.0
    IL_0190: ldarg.0
    IL_0195: ldflda 0x040000AD
    IL_019A: ldfld 0x040004E9
    IL_019B: IL_22
    IL_019C: IL_CD
    IL_019D: IL_CC
    IL_019E: IL_4C
    IL_019F: IL_3D
    IL_01A0: IL_59
    IL_01A1: conv.r8
    IL_01A3: bgt.s IL_01A4
    IL_01A4: nop
    IL_01A5: stloc.0
    IL_01A6: ldarg.0
    IL_01A7: ldarg.0
    IL_01AC: ldfld 0x040000A8
    IL_01B1: ldstr 0x700001C1
    IL_01B2: conv.r8
    IL_01B4: bge.s IL_01B5
    IL_01B5: nop
    IL_01B6: stloc.0
    IL_01B7: conv.r8
    IL_01B8: IL_54
    IL_01B9: nop
    IL_01BA: nop
    IL_01BB: stloc.0
    IL_01C0: stfld 0x04000098
    IL_01C1: ldarg.0
    IL_01C6: ldfld 0x040000A8
    IL_01CB: ldstr 0x70000177
    IL_01CC: conv.r8
    IL_01CE: bge.s IL_01CF
    IL_01CF: nop
    IL_01D0: stloc.0
    IL_01D1: ldc.i4.2
    IL_01D2: conv.r8
    IL_01D4: ble.s IL_01D5
    IL_01D5: nop
    IL_01D6: stloc.0
    IL_01D7: ldarg.0
    IL_01DC: ldfld 0x040000A8
    IL_01E1: ldstr 0x70000181
    IL_01E2: conv.r8
    IL_01E4: bge.s IL_01E5
    IL_01E5: nop
    IL_01E6: stloc.0
    IL_01E7: ldc.i4.2
    IL_01E8: conv.r8
    IL_01EA: ble.s IL_01EB
    IL_01EB: nop
    IL_01EC: stloc.0
    IL_01ED: ldarg.0
    IL_01F2: ldfld 0x040000A8
    IL_01F7: ldstr 0x7000016D
    IL_01F8: conv.r8
    IL_01FA: bge.s IL_01FB
    IL_01FB: nop
    IL_01FC: stloc.0
    IL_01FD: ldc.i4.0
    IL_01FE: conv.r8
    IL_0200: ble.s IL_0201
    IL_0201: nop
    IL_0202: stloc.0
    IL_0203: ldarg.0
    IL_0208: ldfld 0x040000A8
    IL_020D: ldstr 0x70000195
    IL_020E: conv.r8
    IL_0210: bge.s IL_0211
    IL_0211: nop
    IL_0212: stloc.0
    IL_0213: ldc.i4.1
    IL_0214: conv.r8
    IL_0216: ble.s IL_0217
    IL_0217: nop
    IL_0218: stloc.0
    IL_0219: ldarg.0
    IL_021E: ldfld 0x040000A8
    IL_0223: ldstr 0x700001A9
    IL_0224: conv.r8
    IL_0226: bge.s IL_0227
    IL_0227: nop
    IL_0228: stloc.0
    IL_0229: ldc.i4.1
    IL_022A: conv.r8
    IL_022C: ble.s IL_022D
    IL_022D: nop
    IL_022E: stloc.0
    IL_022F: ldarg.0
    IL_0234: ldfld 0x040000A8
    IL_0239: ldstr 0x700001C1
    IL_023A: conv.r8
    IL_023C: bge.s IL_023D
    IL_023D: nop
    IL_023E: stloc.0
    IL_023F: ldc.i4.0
    IL_0240: conv.r8
    IL_0242: ble.s IL_0243
    IL_0243: nop
    IL_0244: stloc.0
    IL_0245: ldarg.0
    IL_0246: ldc.i4.0
    IL_024B: stfld 0x04000061
    IL_024C: ldarg.0
    IL_024D: ldarg.0
    IL_0252: ldfld 0x040000A7
    IL_0253: ldc.i4.1
    IL_0254: conv.r8
    IL_0259: brtrue IL_6F0A025A
    IL_025A: stloc.3
    IL_025B: nop
    IL_025C: nop
    IL_025D: stloc.0
    IL_0262: stfld 0x040000AA
    IL_0263: ldarg.0
    IL_0264: ldarg.0
    IL_0269: ldfld 0x040000AA
    IL_026A: conv.r8
    IL_026C: ldarg.s 0
    IL_026D: nop
    IL_026E: stloc.0
    IL_026F: conv.r8
    IL_0271: blt.s IL_0272
    IL_0272: nop
    IL_0273: stloc.0
    IL_0278: stfld 0x0400006B
    IL_0279: ldarg.0
    IL_027E: ldstr 0x7000015F
    IL_027F: IL_22
    IL_0280: IL_CD
    IL_0281: IL_CC
    IL_0282: IL_CC
    IL_0283: IL_3D
    IL_0284: IL_22
    IL_0285: nop
    IL_0286: nop
    IL_0287: nop
    IL_0288: IL_3F
    IL_028D: call 0x0A000017
    IL_028E: ldarg.0
    IL_028F: ldarg.0
    IL_0294: ldfld 0x04000084
    IL_0299: stfld 0x04000082
    IL_029A: ldarg.0
    IL_029B: ldarg.0
    IL_02A0: ldfld 0x0400009B
    IL_02A5: ldfld 0x040002BF
    IL_02AA: stfld 0x04000097
    IL_02AB: ldarg.0
    IL_02AC: ldarg.0
    IL_02B1: ldfld 0x0400009F
    IL_02B6: ldfld 0x04000821
    IL_02B7: ldc.i4.0
    IL_02B8: ldc.i4.3
    IL_02BD: call 0x0A000045
    IL_02BE: ldelem.i
    IL_02C3: stfld 0x04000062
    IL_02C4: ldarg.0
    IL_02C5: ldarg.0
    IL_02CA: ldfld 0x0400009F
    IL_02CB: conv.r8
    IL_02CC: IL_BD
    IL_02CD: ldarg.1
    IL_02CE: nop
    IL_02CF: ldloc.0
    IL_02D4: stfld 0x0400006A
    IL_02D5: ldarg.0
    IL_02DA: ldfld 0x0400006A
    IL_02DB: ldarg.0
    IL_02E0: ldfld 0x040000A7
    IL_02E1: conv.r8
    IL_02E2: ldc.i4.2
    IL_02E3: nop
    IL_02E4: nop
    IL_02E5: stloc.0
    IL_02E6: conv.r8
    IL_02E7: ldloc.3
    IL_02E8: nop
    IL_02E9: nop
    IL_02EA: stloc.0
    IL_02EB: ldarg.0
    IL_02EC: IL_22
    IL_02ED: IL_CD
    IL_02EE: IL_CC
    IL_02EF: IL_CC
    IL_02F0: IL_3D
    IL_02F1: ldarg.0
    IL_02F6: ldfld 0x04000088
    IL_02F7: conv.i2
    IL_02F8: IL_22
    IL_02F9: IL_42
    IL_02FA: rem
    IL_02FB: IL_E5
    IL_0300: beq IL_-7F82A4A5
    IL_0301: nop
    IL_0302: nop
    IL_0303: ldarg.2
    IL_0304: ldarg.0
    IL_0305: ldarg.0
    IL_030A: ldfld 0x0400006A
    IL_030B: conv.r8
    IL_030C: ldloc.2
    IL_030D: nop
    IL_030E: nop
    IL_0310: br.s IL_038E
    IL_0311: ldelem.i8
    IL_0312: nop
    IL_0313: nop
    IL_0314: ldarg.2
    IL_0315: ldarg.0
    IL_031A: ldfld 0x0400009E
    IL_031B: ldarg.0
    IL_0320: ldfld 0x04000084
    IL_0321: ldarg.0
    IL_0326: ldfld 0x04000082
    IL_0327: ldarg.0
    IL_032C: ldfld 0x040000A7
    IL_032D: ldarg.0
    IL_0332: ldfld 0x04000080
    IL_0333: ldc.i4.0
    IL_0334: conv.r8
    IL_0335: ldnull
    IL_0336: ldarg.1
    IL_0337: nop
    IL_0338: ldloc.0
    IL_0339: ldarg.0
    IL_033A: ldarg.0
    IL_033F: ldfld 0x0400009F
    IL_0340: ldarg.0
    IL_0345: ldfld 0x040000A7
    IL_0346: ldc.i4.0
    IL_0347: conv.r8
    IL_034C: brtrue IL_220A034D
    IL_034D: nop
    IL_034E: nop
    IL_0353: stsfld 0x03B56F3F
    IL_0354: nop
    IL_0355: ldloc.0
    IL_035A: stfld 0x04000076
    IL_035B: ret
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
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400008E
    IL_0016: brtrue IL_0022
    IL_0017: ldarg.0
    IL_001C: ldfld 0x0400006C
    IL_0021: brtrue IL_0023
    IL_0022: ret
    IL_0023: ldloc.0
    IL_0025: ldc.i4.s 16
    IL_0026: IL_3F
    IL_0027: IL_99
    IL_0028: stloc.2
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldarg.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x0400009B
    IL_0036: ldfld 0x040002BF
    IL_003B: stfld 0x04000097
    IL_003C: ldarg.0
    IL_003D: ldarg.0
    IL_0042: ldfld 0x0400009B
    IL_0047: ldfld 0x04000357
    IL_004C: stfld 0x0400008F
    IL_004D: ldloc.0
    IL_004F: ldc.i4.s 28
    IL_0170: switch (71 cases)
    IL_0171: nop
    IL_0172: nop
    IL_0174: ble.s IL_0178
    IL_0175: nop
    IL_0176: nop
    IL_0177: ldloc.3
    IL_0178: ldarg.2
    IL_0179: nop
    IL_017A: nop
    IL_017B: rem
    IL_017C: ldarg.2
    IL_017D: nop
    IL_017E: nop
    IL_017F: IL_B5
    IL_0180: ldarg.2
    IL_0181: nop
    IL_0182: nop
    IL_0185: ldloca 5
    IL_0186: nop
    IL_0187: stloc.1
    IL_0188: ldloc.0
    IL_0189: nop
    IL_018A: nop
    IL_018F: br IL_0AED
    IL_0190: ldarg.0
    IL_0191: IL_22
    IL_0192: nop
    IL_0193: nop
    IL_0198: ldc.i4 10845506
    IL_0199: nop
    IL_019A: ldarg.2
    IL_019B: ldc.i4.0
    IL_019D: ldc.i4.s 100
    IL_01A2: call 0x0A000045
    IL_01A3: stloc.1
    IL_01A4: ldloc.1
    IL_01A5: ldarg.0
    IL_01AA: ldfld 0x04000087
    IL_01AB: ldarg.0
    IL_01B0: ldfld 0x04000097
    IL_01B1: IL_59
    IL_01B2: IL_3C
    IL_01B3: IL_3E
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: nop
    IL_01B7: ldarg.0
    IL_01BC: ldfld 0x04000061
    IL_01BD: ldc.i4.0
    IL_01BE: IL_3F
    IL_01C0: blt.s IL_01C1
    IL_01C1: nop
    IL_01C2: nop
    IL_01C3: ldarg.0
    IL_01C8: ldfld 0x0400009B
    IL_01C9: ldarg.0
    IL_01CE: ldfld 0x040000A7
    IL_01CF: conv.r8
    IL_01D0: ldc.i4.2
    IL_01D1: nop
    IL_01D2: nop
    IL_01D3: stloc.0
    IL_01D4: conv.r8
    IL_01D5: len
    IL_01D6: IL_01
    IL_01D7: nop
    IL_01D8: ldloc.0
    IL_01D9: ldarg.0
    IL_01DE: call 0x0A00003D
    IL_01DF: ldarg.0
    IL_01E4: ldfld 0x04000095
    IL_01E5: IL_22
    IL_01E6: nop
    IL_01E7: nop
    IL_01EC: ldc.i4 534593
    IL_01ED: nop
    IL_01EE: stloc.0
    IL_01EF: conv.r8
    IL_01F0: IL_3E
    IL_01F1: nop
    IL_01F2: nop
    IL_01F3: stloc.0
    IL_01F4: ret
    IL_01F5: ldarg.0
    IL_01F6: ldarg.0
    IL_01FB: ldfld 0x0400009B
    IL_0200: ldfld 0x040002C6
    IL_0201: conv.i2
    IL_0206: stfld 0x04000096
    IL_0207: ldarg.0
    IL_020C: ldfld 0x0400009D
    IL_020D: conv.r8
    IL_020E: IL_35
    IL_020F: IL_01
    IL_0210: nop
    IL_0211: ldloc.0
    IL_0212: ldarg.0
    IL_0213: ldarg.0
    IL_0218: ldfld 0x04000067
    IL_021D: stfld 0x04000068
    IL_021E: ldarg.0
    IL_0223: ldfld 0x0400009F
    IL_0224: ldarg.0
    IL_0229: ldfld 0x040000A7
    IL_022A: conv.r8
    IL_022B: ldc.i4.2
    IL_022C: nop
    IL_022D: nop
    IL_022E: stloc.0
    IL_022F: ldarg.0
    IL_0234: ldfld 0x04000095
    IL_0235: conv.r8
    IL_0236: IL_B8
    IL_0237: ldarg.1
    IL_0238: nop
    IL_0239: ldloc.0
    IL_023E: br IL_0AED
    IL_023F: ldarg.0
    IL_0240: IL_22
    IL_0241: nop
    IL_0242: nop
    IL_0243: IL_F0
    IL_0244: IL_41
    IL_0249: stfld 0x040000A5
    IL_024A: ldarg.0
    IL_024B: ldarg.0
    IL_0250: ldfld 0x0400009B
    IL_0255: ldfld 0x040002C6
    IL_0256: conv.i2
    IL_025B: stfld 0x04000096
    IL_025C: ldarg.0
    IL_0261: ldfld 0x0400009D
    IL_0262: IL_22
    IL_0263: nop
    IL_0264: nop
    IL_0269: stsfld 0x01366F3F
    IL_026A: nop
    IL_026B: ldloc.0
    IL_026C: ldarg.0
    IL_026D: ldc.i4.1
    IL_0272: stfld 0x0400008F
    IL_0273: ldarg.0
    IL_0274: ldarg.0
    IL_0279: ldfld 0x04000067
    IL_027E: stfld 0x04000068
    IL_027F: ldarg.0
    IL_0284: ldfld 0x0400009F
    IL_0285: ldarg.0
    IL_028A: ldfld 0x040000A7
    IL_028B: conv.r8
    IL_028C: ldc.i4.2
    IL_028D: nop
    IL_028E: nop
    IL_028F: stloc.0
    IL_0290: ldarg.0
    IL_0295: ldfld 0x04000095
    IL_0296: conv.r8
    IL_0297: IL_B9
    IL_0298: ldarg.1
    IL_0299: nop
    IL_029A: ldloc.0
    IL_029F: br IL_0AED
    IL_02A0: ldarg.0
    IL_02A1: IL_22
    IL_02A2: nop
    IL_02A3: nop
    IL_02A8: ldc.i4 10845505
    IL_02A9: nop
    IL_02AA: ldarg.2
    IL_02AB: ldarg.0
    IL_02AC: ldarg.1
    IL_02AD: conv.r8
    IL_02AE: IL_3D
    IL_02AF: nop
    IL_02B0: nop
    IL_02B1: stloc.0
    IL_02B2: conv.r8
    IL_02B5: ldarga 0
    IL_02B6: stloc.0
    IL_02BB: stfld 0x04000096
    IL_02BC: ldarg.0
    IL_02C1: ldfld 0x0400009D
    IL_02C2: conv.r8
    IL_02C3: IL_35
    IL_02C4: IL_01
    IL_02C5: nop
    IL_02C6: ldloc.0
    IL_02C7: ldarg.0
    IL_02C8: ldc.i4.1
    IL_02CD: stfld 0x0400008F
    IL_02CE: ldarg.0
    IL_02CF: ldarg.0
    IL_02D4: ldfld 0x04000067
    IL_02D9: stfld 0x04000068
    IL_02DA: ldarg.0
    IL_02DF: ldfld 0x0400009F
    IL_02E0: ldarg.0
    IL_02E5: ldfld 0x040000A7
    IL_02E6: conv.r8
    IL_02E7: ldc.i4.2
    IL_02E8: nop
    IL_02E9: nop
    IL_02EA: stloc.0
    IL_02EB: ldarg.0
    IL_02F0: ldfld 0x04000095
    IL_02F1: conv.r8
    IL_02F2: IL_B9
    IL_02F3: ldarg.1
    IL_02F4: nop
    IL_02F5: ldloc.0
    IL_02FA: br IL_0AED
    IL_02FB: ldarg.0
    IL_02FC: IL_22
    IL_02FD: nop
    IL_02FE: nop
    IL_0303: ldc.i4 10845505
    IL_0304: nop
    IL_0305: ldarg.2
    IL_0306: ldarg.1
    IL_0307: conv.r8
    IL_0308: IL_3D
    IL_0309: nop
    IL_030A: nop
    IL_030B: stloc.0
    IL_030C: conv.r8
    IL_030F: ldarga 0
    IL_0310: stloc.0
    IL_0311: stloc.2
    IL_0312: ldloc.2
    IL_0313: IL_22
    IL_0314: IL_CD
    IL_0315: IL_CC
    IL_0316: IL_CC
    IL_0317: IL_3D
    IL_0440: switch (73 cases)
    IL_0441: ldarg.2
    IL_0442: ldarg.0
    IL_0447: ldfld 0x0400009E
    IL_0448: ldarg.0
    IL_044D: ldfld 0x04000084
    IL_044E: ldarg.0
    IL_0453: ldfld 0x04000082
    IL_0454: ldarg.0
    IL_0459: ldfld 0x040000A7
    IL_045A: ldarg.0
    IL_045F: ldfld 0x04000080
    IL_0460: ldc.i4.2
    IL_0461: conv.r8
    IL_0462: ldnull
    IL_0463: ldarg.1
    IL_0464: nop
    IL_0465: ldloc.0
    IL_046A: br IL_0AED
    IL_046B: ldarg.0
    IL_046C: IL_22
    IL_046D: nop
    IL_046E: nop
    IL_0473: cpobj 0x00A57D42
    IL_0474: nop
    IL_0475: ldarg.2
    IL_0476: ldarg.0
    IL_0477: ldarg.0
    IL_047C: ldfld 0x0400009B
    IL_0481: ldfld 0x040002C6
    IL_0482: conv.i2
    IL_0487: stfld 0x04000096
    IL_0488: ldarg.0
    IL_0489: ldarg.0
    IL_048E: ldfld 0x04000067
    IL_0493: stfld 0x04000068
    IL_0494: ldarg.0
    IL_0499: ldfld 0x0400009F
    IL_049A: ldarg.0
    IL_049F: ldfld 0x040000A7
    IL_04A0: conv.r8
    IL_04A1: ldc.i4.2
    IL_04A2: nop
    IL_04A3: nop
    IL_04A4: stloc.0
    IL_04A5: ldarg.0
    IL_04AA: ldfld 0x04000095
    IL_04AB: conv.r8
    IL_04AC: IL_B9
    IL_04AD: ldarg.1
    IL_04AE: nop
    IL_04AF: ldloc.0
    IL_04B0: ldarg.0
    IL_04B1: ldc.i4.0
    IL_04B6: stfld 0x0400008F
    IL_04BB: br IL_0AED
    IL_04BC: ldarg.0
    IL_04C1: ldfld 0x040000A8
    IL_04C2: ldarg.0
    IL_04C7: ldfld 0x0400009F
    IL_04CC: ldfld 0x04000819
    IL_04D1: ldstr 0x700001CB
    IL_04D2: conv.r8
    IL_04D3: conv.i8
    IL_04D4: nop
    IL_04D5: nop
    IL_04D6: stloc.0
    IL_04D7: ldarg.0
    IL_04DC: ldfld 0x040000A8
    IL_04E1: ldstr 0x700001CB
    IL_04E2: conv.r8
    IL_04E4: bge.s IL_04E5
    IL_04E5: nop
    IL_04E6: stloc.0
    IL_04E7: IL_22
    IL_04E8: ldelem.i
    IL_04E9: IL_99
    IL_04EA: IL_99
    IL_04EB: IL_3E
    IL_04EC: conv.r8
    IL_04EE: bgt.s IL_04EF
    IL_04EF: nop
    IL_04F0: stloc.0
    IL_04F1: ldarg.0
    IL_04F2: ldarg.0
    IL_04F7: call 0x06000026
    IL_04FC: call 0x0A000047
    IL_04FD: pop
    IL_04FE: ldarg.0
    IL_04FF: IL_22
    IL_0500: nop
    IL_0501: nop
    IL_0502: nop
    IL_0503: nop
    IL_0508: stfld 0x040000A5
    IL_0509: ldarg.0
    IL_050A: ldc.i4.1
    IL_050F: stfld 0x0400006E
    IL_0510: ldarg.0
    IL_0511: ldc.i4.0
    IL_0516: stfld 0x0400006C
    IL_0517: ldarg.0
    IL_051C: call 0x0A000003
    IL_051D: ldc.i4.0
    IL_051E: conv.r8
    IL_0520: ldc.i4.s 0
    IL_0521: nop
    IL_0522: stloc.0
    IL_0523: ldarg.0
    IL_0524: ldarg.1
    IL_0525: conv.r8
    IL_0526: IL_3D
    IL_0527: nop
    IL_0528: nop
    IL_0529: stloc.0
    IL_052A: conv.r8
    IL_052D: ldarga 0
    IL_052E: stloc.0
    IL_0533: stfld 0x04000096
    IL_0534: ldarg.0
    IL_0535: dup
    IL_053A: ldfld 0x04000082
    IL_053B: ldarg.0
    IL_0540: ldfld 0x04000096
    IL_0541: neg
    IL_0542: IL_59
    IL_0543: neg
    IL_0548: stfld 0x04000082
    IL_0549: ldarg.0
    IL_054A: ldarg.0
    IL_054F: ldfld 0x04000067
    IL_0554: stfld 0x04000068
    IL_0555: ldarg.0
    IL_055A: ldfld 0x0400009E
    IL_055B: ldarg.0
    IL_0560: ldfld 0x04000084
    IL_0561: ldc.i4.0
    IL_0562: ldarg.0
    IL_0567: ldfld 0x040000A7
    IL_0568: IL_22
    IL_0569: nop
    IL_056A: nop
    IL_056C: starg.s 65
    IL_056D: ldc.i4.0
    IL_056E: conv.r8
    IL_056F: ldnull
    IL_0570: ldarg.1
    IL_0571: nop
    IL_0572: ldloc.0
    IL_0573: ldarg.0
    IL_0578: ldfld 0x0400009F
    IL_0579: ldarg.0
    IL_057E: ldfld 0x040000A7
    IL_057F: conv.r8
    IL_0580: ldc.i4.2
    IL_0581: nop
    IL_0582: nop
    IL_0583: stloc.0
    IL_0584: ldarg.0
    IL_0589: ldfld 0x04000095
    IL_058A: conv.r8
    IL_058B: IL_B9
    IL_058C: ldarg.1
    IL_058D: nop
    IL_058E: ldloc.0
    IL_0593: br IL_0AED
    IL_0594: ldarg.0
    IL_0595: IL_22
    IL_0596: nop
    IL_0597: nop
    IL_059C: ldc.i4 10845505
    IL_059D: nop
    IL_059E: ldarg.2
    IL_059F: ldarg.0
    IL_05A0: ldarg.1
    IL_05A1: conv.r8
    IL_05A2: IL_3D
    IL_05A3: nop
    IL_05A4: nop
    IL_05A5: stloc.0
    IL_05A6: conv.r8
    IL_05A9: ldarga 0
    IL_05AA: stloc.0
    IL_05AF: stfld 0x04000096
    IL_05B0: ldarg.0
    IL_05B1: ldarg.1
    IL_05B2: conv.r8
    IL_05B3: ldarg.0
    IL_05B4: nop
    IL_05B5: nop
    IL_05B6: stloc.0
    IL_05BB: stfld 0x04000068
    IL_05BC: ldarg.0
    IL_05C1: ldfld 0x0400009F
    IL_05C2: ldarg.0
    IL_05C7: ldfld 0x040000A7
    IL_05C8: conv.r8
    IL_05C9: ldc.i4.2
    IL_05CA: nop
    IL_05CB: nop
    IL_05CC: stloc.0
    IL_05CD: ldarg.0
    IL_05D2: ldfld 0x04000095
    IL_05D3: conv.r8
    IL_05D4: IL_B9
    IL_05D5: ldarg.1
    IL_05D6: nop
    IL_05D7: ldloc.0
    IL_05D8: ldarg.0
    IL_05D9: ldc.i4.1
    IL_05DE: stfld 0x04000074
    IL_05DF: ldarg.0
    IL_05E0: ldc.i4.0
    IL_05E5: stfld 0x0400008F
    IL_05EA: br IL_0AED
    IL_05EB: ldarg.0
    IL_05EC: IL_22
    IL_05ED: nop
    IL_05EE: nop
    IL_05F3: ldc.i4 10845506
    IL_05F4: nop
    IL_05F5: ldarg.2
    IL_05F6: ldarg.0
    IL_05F7: ldarg.0
    IL_05FC: ldfld 0x0400009B
    IL_0601: ldfld 0x040002C6
    IL_0602: conv.i2
    IL_0607: stfld 0x04000096
    IL_0608: ldarg.0
    IL_060D: ldfld 0x0400009D
    IL_060E: conv.r8
    IL_060F: IL_35
    IL_0610: IL_01
    IL_0611: nop
    IL_0612: ldloc.0
    IL_0613: ldarg.0
    IL_0614: ldarg.0
    IL_0619: ldfld 0x04000067
    IL_061E: stfld 0x04000068
    IL_061F: ldarg.0
    IL_0624: ldfld 0x0400009F
    IL_0625: ldarg.0
    IL_062A: ldfld 0x040000A7
    IL_062B: conv.r8
    IL_062C: ldc.i4.2
    IL_062D: nop
    IL_062E: nop
    IL_062F: stloc.0
    IL_0630: ldarg.0
    IL_0635: ldfld 0x04000095
    IL_0636: conv.r8
    IL_0637: IL_B8
    IL_0638: ldarg.1
    IL_0639: nop
    IL_063A: ldloc.0
    IL_063F: br IL_0AED
    IL_0640: ldarg.0
    IL_0641: IL_22
    IL_0642: nop
    IL_0643: nop
    IL_0644: nop
    IL_0645: nop
    IL_064A: stfld 0x040000A5
    IL_064B: ldarg.0
    IL_064C: ldarg.0
    IL_0651: ldfld 0x0400009B
    IL_0656: ldfld 0x040002C6
    IL_0657: conv.i2
    IL_0658: IL_22
    IL_0659: IL_CD
    IL_065A: IL_CC
    IL_065B: IL_CC
    IL_065C: IL_3E
    IL_065D: IL_5A
    IL_0662: stfld 0x04000096
    IL_0663: ldarg.0
    IL_0664: ldc.i4.0
    IL_0669: stfld 0x0400008F
    IL_066A: ldarg.0
    IL_066F: ldfld 0x04000090
    IL_0674: brfalse IL_0685
    IL_0675: ldarg.0
    IL_0676: IL_22
    IL_0677: ldelem.i
    IL_0678: IL_99
    IL_0679: ldc.i4.3
    IL_067A: IL_3F
    IL_067F: stfld 0x04000091
    IL_0684: br IL_06A0
    IL_0685: ldarg.0
    IL_068A: ldfld 0x040000A7
    IL_068F: call 0x0A00006E
    IL_0690: conv.r8
    IL_0695: call 0x020A0000
    IL_0696: IL_22
    IL_0697: ldelem.i
    IL_0698: IL_99
    IL_0699: IL_59
    IL_24C92: switch (37245 cases)
    }

    public void SummonStart() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: IL_C0
    IL_0004: IL_3F
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldflda 0x040000AD
    IL_0010: ldfld 0x040004EA
    IL_0011: ldc.i4.2
    IL_0106: switch (60 cases)
    }

    public void SummonFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x0400006D
    IL_0007: ret
    }

    public void SetLevel() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.1
    IL_0003: IL_58
    IL_0004: neg
    IL_0009: stfld 0x04000083
    IL_000A: ldarg.0
    IL_000C: ldarg.s 4
    IL_0011: stfld 0x040000AC
    IL_0012: ldarg.0
    IL_0013: dup
    IL_0018: ldfld 0x04000084
    IL_0019: IL_22
    IL_001A: IL_CF
    IL_001B: IL_F7
    IL_001D: stloc.s 62
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000083
    IL_0024: conv.i2
    IL_0025: IL_5A
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000083
    IL_002C: conv.i2
    IL_002D: IL_5A
    IL_002E: IL_22
    IL_002F: IL_C3
    IL_0030: xor
    IL_0031: IL_CC
    IL_20DEC3E: switch (8616706 cases)
    }

    private void BurnDamage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400009B
    IL_000A: ldfld 0x040002C6
    IL_000C: ldc.i4.s 10
    IL_000D: add
    IL_000E: neg
    IL_000F: stloc.0
    IL_0010: ldloc.0
    IL_0011: ldc.i4.1
    IL_0012: IL_3C
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: ldc.i4.1
    IL_0018: stloc.0
    IL_0019: ldarg.0
    IL_001A: dup
    IL_001F: ldfld 0x04000082
    IL_0020: ldloc.0
    IL_0021: IL_59
    IL_0022: neg
    IL_0027: stfld 0x04000082
    IL_0028: ldarg.0
    IL_002D: ldfld 0x0400009F
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040000A7
    IL_0034: conv.r8
    IL_0035: ldc.i4.2
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldloc.0
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000095
    IL_0040: conv.r8
    IL_0041: IL_B7
    IL_0042: ldarg.1
    IL_0043: nop
    IL_0044: ldloc.0
    IL_0045: ldarg.0
    IL_004A: ldfld 0x0400009E
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000084
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000082
    IL_0057: ldarg.0
    IL_005C: ldfld 0x040000A7
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000080
    IL_0063: ldc.i4.m1
    IL_0064: conv.r8
    IL_0065: ldnull
    IL_0066: ldarg.1
    IL_0067: nop
    IL_0068: ldloc.0
    IL_0069: ldarg.0
    IL_006E: ldfld 0x04000082
    IL_006F: ldc.i4.0
    IL_0070: IL_3D
    IL_0071: ldloc.1
    IL_0072: nop
    IL_0073: nop
    IL_0074: nop
    IL_0075: ldarg.0
    IL_0076: ldc.i4.0
    IL_007B: call 0x06000027
    IL_007C: ret
    }

    private void ShockDamage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000A8
    IL_0006: conv.r8
    IL_0009: ldloc 0
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040000A8
    IL_0015: ldstr 0x70000177
    IL_0016: conv.r8
    IL_0017: IL_3C
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: pop
    IL_001C: ret
    }

    public void Freeze() {
    IL_0004: newobj 0x06000713
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x0400100C
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void Burn() {
    IL_0004: newobj 0x06000719
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x0400100F
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void Shock() {
    IL_0004: newobj 0x0600071F
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001012
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void Darken() {
    IL_0004: newobj 0x06000725
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001015
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void Petrify() {
    IL_0004: newobj 0x0600072B
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001019
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void Pierced() {
    IL_0004: newobj 0x06000731
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x0400101C
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void Dead() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s -4
    IL_0007: stfld 0x04000061
    IL_0008: ldarg.0
    IL_0009: ldc.i4.0
    IL_000E: stfld 0x0400006C
    IL_000F: ldarg.0
    IL_0014: ldfld 0x0400009E
    IL_0015: conv.r8
    IL_0016: ldc.i4.m1
    IL_0017: ldarg.1
    IL_0018: nop
    IL_0019: ldloc.0
    IL_001A: ldarg.0
    IL_001B: ldc.i4.0
    IL_0020: stfld 0x04000073
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0027: stfld 0x04000082
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040000A7
    IL_002E: conv.r8
    IL_002F: ldc.i4.2
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: ldflda 0x04000095
    IL_003A: ldc.i4.1
    IL_003B: IL_22
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0044: call 0x0A00001A
    IL_0045: ldarg.1
    IL_0046: ldc.i4.2
    IL_0187: switch (79 cases)
    IL_0188: ldarg.0
    IL_018D: ldfld 0x04000083
    IL_018E: ldarg.0
    IL_0193: ldfld 0x040000A7
    IL_0194: conv.r8
    IL_0195: ldc.i4.2
    IL_0196: nop
    IL_0197: nop
    IL_0198: stloc.0
    IL_0199: conv.r8
    IL_019A: IL_BF
    IL_019B: ldarg.1
    IL_019C: nop
    IL_019D: ldloc.0
    IL_019E: ldarg.0
    IL_01A3: ldfld 0x04000066
    IL_01A4: ldnull
    IL_01A9: call 0x0A000021
    IL_01AE: brfalse IL_01C6
    IL_01AF: ldarg.0
    IL_01B4: ldfld 0x04000066
    IL_01B5: conv.r8
    IL_01B6: stloc.0
    IL_01B7: nop
    IL_01B8: nop
    IL_01B9: stloc.0
    IL_01BE: call 0x0A000050
    IL_01BF: ldarg.0
    IL_01C0: ldnull
    IL_01C5: stfld 0x04000066
    IL_01C6: ldarg.0
    IL_01CB: ldfld 0x04000065
    IL_01CC: ldnull
    IL_01D1: call 0x0A000021
    IL_01D6: brfalse IL_01EE
    IL_01D7: ldarg.0
    IL_01DC: ldfld 0x04000065
    IL_01DD: conv.r8
    IL_01DE: stloc.0
    IL_01DF: nop
    IL_01E0: nop
    IL_01E1: stloc.0
    IL_01E6: call 0x0A000050
    IL_01E7: ldarg.0
    IL_01E8: ldnull
    IL_01ED: stfld 0x04000065
    IL_01EE: ret
    }

    public void Grabed() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000AB
    IL_0006: ldc.i4.0
    IL_0007: IL_3E
    IL_0008: IL_01
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ret
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400008E
    IL_0017: brtrue IL_0295
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040000A7
    IL_001F: conv.r8
    IL_0020: ldc.i4.2
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0028: call 0x0A000062
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000067
    IL_002F: conv.r8
    IL_0030: ldc.i4.2
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: stloc.0
    IL_0036: ldloca.s 0
    IL_003B: ldfld 0x0A00005E
    IL_0040: call 0x0A000008
    IL_0045: call 0x0A000019
    IL_004A: call 0x0A000042
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000067
    IL_0051: conv.r8
    IL_0052: ldc.i4.2
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: stloc.1
    IL_0058: ldloca.s 1
    IL_005D: ldfld 0x0A00005C
    IL_0062: call 0x0A000008
    IL_0067: call 0x0A000019
    IL_006C: call 0x0A000040
    IL_0071: stfld 0x04000095
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040000A7
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000095
    IL_0082: call 0x0A000043
    IL_0083: conv.r8
    IL_0088: ldc.i4 34209792
    IL_008D: ldfld 0x040000A8
    IL_008E: conv.r8
    IL_0091: ldloc 0
    IL_0092: stloc.0
    IL_0093: ldarg.0
    IL_0094: ldc.i4.0
    IL_0095: ldc.i4.3
    IL_009A: call 0x0A000045
    IL_009F: stfld 0x0400008D
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000088
    IL_00A7: ldc.i4.s 20
    IL_00F8: switch (19 cases)
    IL_00F9: nop
    IL_00FA: ldarg.2
    IL_00FB: ldarg.0
    IL_0100: ldfld 0x0400008D
    IL_0101: ldelem.i
    IL_0106: ldstr 0x70000241
    IL_0107: conv.r8
    IL_0108: conv.i8
    IL_0109: nop
    IL_010A: nop
    IL_010B: stloc.0
    IL_010C: ldarg.0
    IL_0111: ldfld 0x040000A8
    IL_0112: ldarg.0
    IL_0117: ldfld 0x0400009F
    IL_011C: ldfld 0x04000816
    IL_011D: ldarg.0
    IL_0122: ldfld 0x0400008D
    IL_0123: ldelem.i
    IL_0128: ldstr 0x70000259
    IL_0129: conv.r8
    IL_012A: conv.i8
    IL_012B: nop
    IL_012C: nop
    IL_012D: stloc.0
    IL_012E: ldarg.0
    IL_0133: ldfld 0x040000A8
    IL_0134: ldarg.0
    IL_0139: ldfld 0x0400009F
    IL_013E: ldfld 0x04000817
    IL_013F: ldarg.0
    IL_0144: ldfld 0x0400008D
    IL_0145: ldelem.i
    IL_014A: ldstr 0x7000026B
    IL_014B: conv.r8
    IL_014C: conv.i8
    IL_014D: nop
    IL_014E: nop
    IL_014F: stloc.0
    IL_0150: ldarg.0
    IL_0155: ldfld 0x040000A8
    IL_0156: ldarg.0
    IL_015B: ldfld 0x0400009F
    IL_0160: ldfld 0x04000818
    IL_0161: ldarg.0
    IL_0166: ldfld 0x0400008D
    IL_0167: ldelem.i
    IL_016C: ldstr 0x7000027D
    IL_016D: conv.r8
    IL_016E: conv.i8
    IL_016F: nop
    IL_0170: nop
    IL_0171: stloc.0
    IL_0172: ldarg.0
    IL_0177: ldfld 0x040000A8
    IL_017C: ldstr 0x70000241
    IL_017D: conv.r8
    IL_017E: IL_3C
    IL_017F: nop
    IL_0180: nop
    IL_0181: stloc.0
    IL_0182: pop
    IL_0183: ldarg.0
    IL_0188: ldfld 0x040000A8
    IL_018D: ldstr 0x70000241
    IL_018E: conv.r8
    IL_0190: bge.s IL_0191
    IL_0191: nop
    IL_0192: stloc.0
    IL_0193: ldarg.0
    IL_0198: ldfld 0x0400009F
    IL_019D: ldfld 0x0400081B
    IL_019E: ldarg.0
    IL_01A3: ldfld 0x0400008D
    IL_01A4: IL_98
    IL_01A5: conv.r8
    IL_01A7: bgt.s IL_01A8
    IL_01A8: nop
    IL_01A9: stloc.0
    IL_01AA: ldarg.0
    IL_01AF: ldfld 0x040000A8
    IL_01B4: ldstr 0x70000241
    IL_01B5: conv.r8
    IL_01B7: bge.s IL_01B8
    IL_01B8: nop
    IL_01B9: stloc.0
    IL_01BA: ldc.i4.3
    IL_01BB: conv.r8
    IL_01BD: ble.s IL_01BE
    IL_01BE: nop
    IL_01BF: stloc.0
    IL_01C0: ldarg.0
    IL_01C1: ldarg.0
    IL_01C6: ldfld 0x040000A8
    IL_01CB: ldstr 0x70000259
    IL_01CC: conv.r8
    IL_01D1: newobj 0x7D0A0000
    IL_01D2: ldelem.r8
    IL_01D3: nop
    IL_01D4: nop
    IL_01D5: ldarg.2
    IL_01D6: ldarg.0
    IL_01DB: ldfld 0x040000A0
    IL_01DC: ldarg.0
    IL_01E1: ldfld 0x0400009F
    IL_01E6: ldfld 0x0400081C
    IL_01E7: ldarg.0
    IL_01EC: ldfld 0x0400008D
    IL_01ED: IL_98
    IL_01EE: conv.r8
    IL_01F0: bgt.s IL_01F1
    IL_01F1: nop
    IL_01F2: stloc.0
    IL_01F3: ldarg.0
    IL_01F8: ldfld 0x040000A0
    IL_01F9: ldc.i4.3
    IL_01FA: conv.r8
    IL_01FC: ble.s IL_01FD
    IL_01FD: nop
    IL_01FE: stloc.0
    IL_01FF: ldarg.0
    IL_0200: ldarg.0
    IL_0205: ldfld 0x040000A8
    IL_020A: ldstr 0x7000026B
    IL_020B: conv.r8
    IL_0210: newobj 0x7D0A0000
    IL_0211: ldelem.ref
    IL_0212: nop
    IL_0213: nop
    IL_0214: ldarg.2
    IL_0215: ldarg.0
    IL_021A: ldfld 0x040000A1
    IL_021B: ldarg.0
    IL_0220: ldfld 0x0400009F
    IL_0225: ldfld 0x0400081D
    IL_0226: ldarg.0
    IL_022B: ldfld 0x0400008D
    IL_022C: IL_98
    IL_022D: conv.r8
    IL_022F: bgt.s IL_0230
    IL_0230: nop
    IL_0231: stloc.0
    IL_0232: ldarg.0
    IL_0237: ldfld 0x040000A1
    IL_0238: ldc.i4.3
    IL_0239: conv.r8
    IL_023B: ble.s IL_023C
    IL_023C: nop
    IL_023D: stloc.0
    IL_023E: ldarg.0
    IL_0243: call 0x0A00003D
    IL_0244: ldarg.0
    IL_0249: ldfld 0x04000095
    IL_024A: ldarg.0
    IL_024F: ldfld 0x0400009F
    IL_0254: ldfld 0x0400081F
    IL_0255: ldarg.0
    IL_025A: ldfld 0x0400008D
    IL_025B: IL_94
    IL_025C: conv.i2
    IL_0261: call 0x0A000008
    IL_0262: conv.r8
    IL_0263: IL_3E
    IL_0264: nop
    IL_0265: nop
    IL_0266: stloc.0
    IL_0267: ldarg.0
    IL_026C: ldfld 0x0400009B
    IL_026D: ldarg.0
    IL_0272: ldfld 0x0400008D
    IL_0273: ldarg.0
    IL_0278: ldfld 0x040000A7
    IL_0279: conv.r8
    IL_027A: ldc.i4.2
    IL_027B: nop
    IL_027C: nop
    IL_027D: stloc.0
    IL_027E: conv.r8
    IL_027F: IL_88
    IL_0280: IL_01
    IL_0281: nop
    IL_0282: ldloc.0
    IL_0283: ldarg.0
    IL_0284: ldc.i4.1
    IL_0289: stfld 0x0400008E
    IL_028A: ldarg.0
    IL_028B: IL_22
    IL_028C: nop
    IL_028D: nop
    IL_0292: stsfld 0x00797DBF
    IL_0293: nop
    IL_0294: ldarg.2
    IL_0295: ret
    }

    public void CountDown() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400006C
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000064
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000067
    IL_0018: conv.r8
    IL_0019: ldc.i4.2
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_0021: call 0x0A000013
    IL_0026: call 0x0A000014
    IL_0027: conv.u4
    IL_0028: ldarg.1
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_01
    IL_0030: stfld 0x04000066
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04000072
    IL_0038: ldarg.0
    IL_0039: ldc.i4.1
    IL_003E: stfld 0x04000073
    IL_003F: ret
    }

    public void SetDir() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400006C
    IL_0006: ldc.i4.0
    IL_0008: ceq
    IL_0009: ldarg.0
    IL_000E: ldfld 0x0400006D
    IL_000F: rem
    IL_0014: brfalse IL_0016
    IL_0015: ret
    IL_0016: ldarg.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x0400009B
    IL_0021: ldfld 0x040002BC
    IL_0026: stfld 0x04000092
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000068
    IL_002D: ldnull
    IL_0032: call 0x0A000061
    IL_0037: brfalse IL_0044
    IL_0038: ldarg.0
    IL_0039: ldarg.0
    IL_003E: ldfld 0x04000067
    IL_0043: stfld 0x04000068
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040000AB
    IL_004A: stloc.0
    IL_004B: ldloc.0
    IL_004C: ldc.i4.2
    IL_004D: IL_59
    IL_0050: ldarg 3
    IL_0051: nop
    IL_0052: nop
    IL_0057: ldsfld 0x58000000
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: ldarg.3
    IL_005C: nop
    IL_005D: nop
    IL_005E: nop
    IL_0063: br IL_00F8
    IL_0064: ldarg.0
    IL_0065: IL_22
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_26661: switch (39293 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400006C
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000090
    IL_0016: brfalse IL_0162
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040000A7
    IL_001D: dup
    IL_001E: conv.r8
    IL_001F: ldc.i4.2
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0027: call 0x0A000007
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000091
    IL_0032: call 0x0A000008
    IL_0037: call 0x0A000024
    IL_003C: call 0x0A000008
    IL_0041: call 0x0A000029
    IL_0042: conv.r8
    IL_0043: ldloc.3
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_0048: dup
    IL_004D: ldfld 0x04000091
    IL_0052: call 0x0A000024
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldelem.r8
    IL_245F565C3: switch (2440911194 cases)
    }

    }}
