// Namespace: 
// Type: AI_StoryEnemy

    public class AI_StoryEnemy {{

    public object enemykind;
    private object originTex;
    public object monmovestat;
    public object move;
    public object scream;
    public object death;
    public object stab;
    public object kick;
    private object mon_destroy;
    private object mytransform;
    private object hpbar;
    private object chapos;
    private object targetpos;
    private object life;
    private object impact;
    private object attackstart;
    private object dash;
    private object currentattack;
    private object movespeed;
    private object attackrange;
    private object downhigh;
    private object downhigh2;
    private object hp;
    private object maxhp;
    private object block;
    private object runspeed;
    private object firerange;
    public object target;
    private object cha1;
    private object lookrotation;
    private object directionVector;
    private object damage;
    private object accuracy;
    private object script_cha;
    private object script_sound;
    private object script_cam;
    private object script_hpbar;
    private object script_npc;
    private object script_monEf;
    private object enemy;

    public AI_StoryEnemy() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000101
    IL_0007: ldarg.0
    IL_000C: call 0x0A000001
    IL_000D: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040000FD
    IL_000C: ret
    }

    private void Start() {
    IL_0004: ldstr 0x70000063
    IL_0009: call 0x0A000004
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_000C: ldloc.0
    IL_000D: conv.r8
    IL_000E: stloc.1
    IL_000F: nop
    IL_0010: nop
    IL_0012: br.s IL_008E
    IL_0013: IL_EC
    IL_0014: ldarg.2
    IL_0015: nop
    IL_0016: ldarg.2
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040000F4
    IL_001D: IL_8F
    IL_001E: rem.un
    IL_001F: nop
    IL_0020: nop
    IL_0021: ldarg.0
    IL_0026: ldobj 0x02000061
    IL_002B: stfld 0x0400011B
    IL_002C: ldarg.0
    IL_002D: ldc.i4.5
    IL_0032: stfld 0x0400010B
    IL_0033: ldarg.0
    IL_0034: ldarg.0
    IL_0039: ldflda 0x0400011B
    IL_003E: ldfld 0x040004DE
    IL_0043: stfld 0x0400010C
    IL_0044: ldarg.0
    IL_0045: ldarg.0
    IL_004A: ldflda 0x0400011B
    IL_004F: ldfld 0x040004E0
    IL_0054: stfld 0x0400010D
    IL_0055: ldarg.0
    IL_0056: IL_22
    IL_0057: IL_AE
    IL_005A: starg 15969
    IL_005F: stfld 0x0400010E
    IL_0060: ldarg.0
    IL_0065: call 0x0A00002A
    IL_006A: ldstr 0x7000016D
    IL_006B: conv.r8
    IL_006D: bge.s IL_006E
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: ldarg.0
    IL_0075: ldflda 0x0400011B
    IL_007A: ldfld 0x040004E6
    IL_007B: conv.r8
    IL_007D: bgt.s IL_007E
    IL_007E: nop
    IL_007F: stloc.0
    IL_0080: ldarg.0
    IL_0085: call 0x0A00002A
    IL_008A: ldstr 0x70000177
    IL_008B: conv.r8
    IL_008D: bge.s IL_008E
    IL_008E: nop
    IL_008F: stloc.0
    IL_0090: IL_22
    IL_0091: IL_8F
    IL_0092: IL_C2
    IL_0093: conv.u8
    IL_0094: IL_3E
    IL_0095: conv.r8
    IL_0097: bgt.s IL_0098
    IL_0098: nop
    IL_0099: stloc.0
    IL_009A: ldarg.0
    IL_009F: call 0x0A00002A
    IL_00A4: ldstr 0x70000181
    IL_00A5: conv.r8
    IL_00A7: bge.s IL_00A8
    IL_00A8: nop
    IL_00A9: stloc.0
    IL_00AA: IL_22
    IL_00AB: IL_29
    IL_00AC: sub
    IL_00AD: IL_8F
    IL_00AE: IL_3E
    IL_00AF: conv.r8
    IL_00B1: bgt.s IL_00B2
    IL_00B2: nop
    IL_00B3: stloc.0
    IL_00B4: ldarg.0
    IL_00B9: call 0x0A00002A
    IL_00BE: ldstr 0x70000387
    IL_00BF: conv.r8
    IL_00C1: bge.s IL_00C2
    IL_00C2: nop
    IL_00C3: stloc.0
    IL_00C4: IL_22
    IL_00C5: IL_CD
    IL_00C6: IL_CC
    IL_00C7: IL_CC
    IL_00C8: IL_3D
    IL_00C9: conv.r8
    IL_00CB: bgt.s IL_00CC
    IL_00CC: nop
    IL_00CD: stloc.0
    IL_00CE: ldarg.0
    IL_00D3: call 0x0A00002A
    IL_00D8: ldstr 0x70000391
    IL_00D9: conv.r8
    IL_00DB: bge.s IL_00DC
    IL_00DC: nop
    IL_00DD: stloc.0
    IL_00DE: IL_22
    IL_00DF: ldelem.i
    IL_00E0: IL_99
    IL_00E1: IL_99
    IL_00E2: IL_3E
    IL_00E3: conv.r8
    IL_00E5: bgt.s IL_00E6
    IL_00E6: nop
    IL_00E7: stloc.0
    IL_00E8: ldarg.0
    IL_00ED: call 0x0A00002A
    IL_00F2: ldstr 0x700003AD
    IL_00F3: conv.r8
    IL_00F5: bge.s IL_00F6
    IL_00F6: nop
    IL_00F7: stloc.0
    IL_00F8: IL_22
    IL_00F9: ldelem.i
    IL_00FA: IL_99
    IL_00FB: IL_99
    IL_00FC: IL_3E
    IL_00FD: conv.r8
    IL_00FF: bgt.s IL_0100
    IL_0100: nop
    IL_0101: stloc.0
    IL_0102: ldarg.0
    IL_0107: call 0x0A00002A
    IL_010C: ldstr 0x700003CD
    IL_010D: conv.r8
    IL_010F: bge.s IL_0110
    IL_0110: nop
    IL_0111: stloc.0
    IL_0112: IL_22
    IL_0113: ldelem.i
    IL_0114: IL_99
    IL_0115: IL_99
    IL_0116: IL_3E
    IL_0117: conv.r8
    IL_0119: bgt.s IL_011A
    IL_011A: nop
    IL_011B: stloc.0
    IL_011C: ldarg.0
    IL_0121: call 0x0A00002A
    IL_0126: ldstr 0x700003E9
    IL_0127: conv.r8
    IL_0129: bge.s IL_012A
    IL_012A: nop
    IL_012B: stloc.0
    IL_012C: IL_22
    IL_012D: ldelem.i
    IL_012E: IL_99
    IL_012F: IL_99
    IL_0130: IL_3E
    IL_0131: conv.r8
    IL_0133: bgt.s IL_0134
    IL_0134: nop
    IL_0135: stloc.0
    IL_0136: ldarg.0
    IL_013B: call 0x0A00002A
    IL_0140: ldstr 0x70000409
    IL_0141: conv.r8
    IL_0143: bge.s IL_0144
    IL_0144: nop
    IL_0145: stloc.0
    IL_0146: IL_22
    IL_0147: ldelem.i
    IL_0148: IL_99
    IL_0149: IL_99
    IL_014A: IL_3E
    IL_014B: conv.r8
    IL_014D: bgt.s IL_014E
    IL_014E: nop
    IL_014F: stloc.0
    IL_0150: ldarg.0
    IL_0155: call 0x0A00002A
    IL_015A: ldstr 0x70000425
    IL_015B: conv.r8
    IL_015D: bge.s IL_015E
    IL_015E: nop
    IL_015F: stloc.0
    IL_0160: IL_22
    IL_0161: ldelem.i
    IL_0162: IL_99
    IL_0163: IL_99
    IL_0164: IL_3E
    IL_0165: conv.r8
    IL_0167: bgt.s IL_0168
    IL_0168: nop
    IL_0169: stloc.0
    IL_016A: ldarg.0
    IL_016F: call 0x0A00002A
    IL_0174: ldstr 0x700001C1
    IL_0175: conv.r8
    IL_0177: bge.s IL_0178
    IL_0178: nop
    IL_0179: stloc.0
    IL_017A: ldarg.0
    IL_017F: ldflda 0x0400011B
    IL_0184: ldfld 0x040004E9
    IL_0185: conv.r8
    IL_0187: bgt.s IL_0188
    IL_0188: nop
    IL_0189: stloc.0
    IL_018A: ldarg.0
    IL_018F: call 0x0A00002A
    IL_0194: ldstr 0x70000177
    IL_0195: conv.r8
    IL_0197: bge.s IL_0198
    IL_0198: nop
    IL_0199: stloc.0
    IL_019A: ldc.i4.2
    IL_019B: conv.r8
    IL_019D: ble.s IL_019E
    IL_019E: nop
    IL_019F: stloc.0
    IL_01A0: ldarg.0
    IL_01A5: call 0x0A00002A
    IL_01AA: ldstr 0x70000181
    IL_01AB: conv.r8
    IL_01AD: bge.s IL_01AE
    IL_01AE: nop
    IL_01AF: stloc.0
    IL_01B0: ldc.i4.2
    IL_01B1: conv.r8
    IL_01B3: ble.s IL_01B4
    IL_01B4: nop
    IL_01B5: stloc.0
    IL_01B6: ldarg.0
    IL_01BB: call 0x0A00002A
    IL_01C0: ldstr 0x7000016D
    IL_01C1: conv.r8
    IL_01C3: bge.s IL_01C4
    IL_01C4: nop
    IL_01C5: stloc.0
    IL_01C6: ldc.i4.0
    IL_01C7: conv.r8
    IL_01C9: ble.s IL_01CA
    IL_01CA: nop
    IL_01CB: stloc.0
    IL_01CC: ldarg.0
    IL_01D1: call 0x0A00002A
    IL_01D6: ldstr 0x70000387
    IL_01D7: conv.r8
    IL_01D9: bge.s IL_01DA
    IL_01DA: nop
    IL_01DB: stloc.0
    IL_01DC: ldc.i4.0
    IL_01DD: conv.r8
    IL_01DF: ble.s IL_01E0
    IL_01E0: nop
    IL_01E1: stloc.0
    IL_01E2: ldarg.0
    IL_01E7: call 0x0A00002A
    IL_01EC: ldstr 0x70000391
    IL_01ED: conv.r8
    IL_01EF: bge.s IL_01F0
    IL_01F0: nop
    IL_01F1: stloc.0
    IL_01F2: ldc.i4.1
    IL_01F3: conv.r8
    IL_01F5: ble.s IL_01F6
    IL_01F6: nop
    IL_01F7: stloc.0
    IL_01F8: ldarg.0
    IL_01FD: call 0x0A00002A
    IL_0202: ldstr 0x700003AD
    IL_0203: conv.r8
    IL_0205: bge.s IL_0206
    IL_0206: nop
    IL_0207: stloc.0
    IL_0208: ldc.i4.1
    IL_0209: conv.r8
    IL_020B: ble.s IL_020C
    IL_020C: nop
    IL_020D: stloc.0
    IL_020E: ldarg.0
    IL_0213: call 0x0A00002A
    IL_0218: ldstr 0x700003CD
    IL_0219: conv.r8
    IL_021B: bge.s IL_021C
    IL_021C: nop
    IL_021D: stloc.0
    IL_021E: ldc.i4.1
    IL_021F: conv.r8
    IL_0221: ble.s IL_0222
    IL_0222: nop
    IL_0223: stloc.0
    IL_0224: ldarg.0
    IL_0229: call 0x0A00002A
    IL_022E: ldstr 0x700003E9
    IL_022F: conv.r8
    IL_0231: bge.s IL_0232
    IL_0232: nop
    IL_0233: stloc.0
    IL_0234: ldc.i4.1
    IL_0235: conv.r8
    IL_0237: ble.s IL_0238
    IL_0238: nop
    IL_0239: stloc.0
    IL_023A: ldarg.0
    IL_023F: call 0x0A00002A
    IL_0244: ldstr 0x70000409
    IL_0245: conv.r8
    IL_0247: bge.s IL_0248
    IL_0248: nop
    IL_0249: stloc.0
    IL_024A: ldc.i4.1
    IL_024B: conv.r8
    IL_024D: ble.s IL_024E
    IL_024E: nop
    IL_024F: stloc.0
    IL_0250: ldarg.0
    IL_0255: call 0x0A00002A
    IL_025A: ldstr 0x70000425
    IL_025B: conv.r8
    IL_025D: bge.s IL_025E
    IL_025E: nop
    IL_025F: stloc.0
    IL_0260: ldc.i4.1
    IL_0261: conv.r8
    IL_0263: ble.s IL_0264
    IL_0264: nop
    IL_0265: stloc.0
    IL_0266: ldarg.0
    IL_026B: call 0x0A00002A
    IL_0270: ldstr 0x700001C1
    IL_0271: conv.r8
    IL_0273: bge.s IL_0274
    IL_0274: nop
    IL_0275: stloc.0
    IL_0276: ldc.i4.0
    IL_0277: conv.r8
    IL_0279: ble.s IL_027A
    IL_027A: nop
    IL_027B: stloc.0
    IL_027C: ldarg.0
    IL_027D: ldc.i4.0
    IL_0282: stfld 0x040000F6
    IL_0283: ldarg.0
    IL_0284: ldarg.0
    IL_0289: ldfld 0x040000FD
    IL_028E: ldstr 0x7000005B
    IL_028F: conv.r8
    IL_0291: brfalse.s IL_0292
    IL_0292: nop
    IL_0293: stloc.0
    IL_0294: conv.r8
    IL_0295: stloc.3
    IL_0296: nop
    IL_0297: nop
    IL_0298: stloc.0
    IL_0299: conv.r8
    IL_029B: ldarg.s 0
    IL_029C: nop
    IL_029D: stloc.0
    IL_029E: conv.r8
    IL_02A0: blt.s IL_02A1
    IL_02A1: nop
    IL_02A2: stloc.0
    IL_02A7: stfld 0x040000F5
    IL_02A8: ldarg.0
    IL_02AD: ldstr 0x70000001
    IL_02B2: call 0x0A000004
    IL_02B3: conv.r8
    IL_02B4: ldarg.3
    IL_02B5: nop
    IL_02B6: nop
    IL_02B7: stloc.0
    IL_02BC: stfld 0x04000110
    IL_02BD: ldarg.0
    IL_02BE: ldarg.0
    IL_02C3: ldfld 0x04000110
    IL_02C4: conv.r8
    IL_02C5: stloc.0
    IL_02C6: nop
    IL_02C7: nop
    IL_02C8: stloc.0
    IL_02C9: conv.r8
    IL_02CA: ldarg.2
    IL_02CB: nop
    IL_02CC: nop
    IL_02CE: br.s IL_034C
    IL_02CF: ldc.i4.m1
    IL_02D0: IL_01
    IL_02D1: nop
    IL_02D2: ldarg.2
    IL_02D3: ldarg.0
    IL_02D8: ldstr 0x70000121
    IL_02DD: call 0x0A000004
    IL_02DE: conv.r8
    IL_02DF: ldarg.3
    IL_02E0: nop
    IL_02E1: nop
    IL_02E3: br.s IL_0361
    IL_02E4: ldc.i4.0
    IL_02E5: IL_01
    IL_02E6: nop
    IL_02E7: ldarg.2
    IL_02E8: ldarg.0
    IL_02ED: call 0x0A000035
    IL_02EE: conv.r8
    IL_02EF: ldloc.0
    IL_02F0: nop
    IL_02F1: nop
    IL_02F3: br.s IL_0371
    IL_02F4: ldc.i4.1
    IL_02F5: IL_01
    IL_02F6: nop
    IL_02F7: ldarg.2
    IL_02F8: ldarg.0
    IL_02FD: ldstr 0x7000012D
    IL_0302: call 0x0A000004
    IL_0303: conv.r8
    IL_0304: ldloc.1
    IL_0305: nop
    IL_0306: nop
    IL_0308: br.s IL_0386
    IL_0309: ldc.i4.4
    IL_030A: IL_01
    IL_030B: nop
    IL_030C: ldarg.2
    IL_030D: ldarg.0
    IL_030E: ldarg.0
    IL_0313: ldfld 0x0400011A
    IL_0314: IL_22
    IL_0315: IL_CD
    IL_0316: IL_CC
    IL_0317: IL_4C
    IL_0318: IL_3D
    IL_0319: IL_22
    IL_031A: stloc.0
    IL_031B: IL_D7
    IL_031C: IL_23
    IL_031D: IL_3C
    IL_0322: newobj 0x0A000038
    IL_0323: ldc.i4.0
    IL_0324: ldc.i4.0
    IL_0325: conv.r8
    IL_0326: IL_BE
    IL_0327: ldarg.1
    IL_0328: nop
    IL_0329: ldloc.0
    IL_032E: stfld 0x040000FE
    IL_032F: ldarg.0
    IL_0330: ldarg.0
    IL_0335: ldfld 0x0400010F
    IL_0336: conv.r8
    IL_0338: ldloca.s 0
    IL_0339: nop
    IL_033B: br.s IL_03B9
    IL_033C: ldc.i4.3
    IL_033D: IL_01
    IL_033E: nop
    IL_033F: ldarg.2
    IL_0340: ldarg.0
    IL_0341: ldarg.0
    IL_0346: ldfld 0x040000FE
    IL_0347: conv.r8
    IL_0348: ldloc.2
    IL_0349: nop
    IL_034A: nop
    IL_034C: br.s IL_03CA
    IL_034D: ldc.i4.2
    IL_034E: IL_01
    IL_034F: nop
    IL_0350: ldarg.2
    IL_0351: ldarg.0
    IL_0352: ldarg.0
    IL_0357: ldfld 0x0400010B
    IL_035C: stfld 0x0400010A
    IL_035D: ldarg.0
    IL_035E: ldarg.0
    IL_0363: ldfld 0x04000115
    IL_0368: ldfld 0x040002BF
    IL_036D: stfld 0x04000114
    IL_036E: ldarg.0
    IL_0373: ldfld 0x04000118
    IL_0374: ldarg.0
    IL_0379: ldfld 0x0400010B
    IL_037A: ldarg.0
    IL_037F: ldfld 0x0400010A
    IL_0380: ldarg.0
    IL_0385: ldfld 0x040000FD
    IL_0386: IL_22
    IL_0387: ldelem.i
    IL_0388: IL_99
    IL_0389: ldc.i4.3
    IL_038A: IL_3E
    IL_038B: ldc.i4.0
    IL_038C: conv.r8
    IL_038D: ldnull
    IL_038E: ldarg.1
    IL_038F: nop
    IL_0390: ldloc.0
    IL_0391: ldarg.0
    IL_0396: ldfld 0x0400011A
    IL_0397: ldarg.0
    IL_039C: ldfld 0x040000FD
    IL_03A1: ldstr 0x70000445
    IL_03A2: conv.r8
    IL_03A4: brfalse.s IL_03A5
    IL_03A5: nop
    IL_03A6: stloc.0
    IL_03A7: IL_22
    IL_03A8: nop
    IL_03A9: nop
    IL_03AE: stsfld 0x03B56F3F
    IL_03AF: nop
    IL_03B0: ldloc.0
    IL_03B1: pop
    IL_03B2: ldarg.0
    IL_03B7: ldfld 0x040000FE
    IL_03B8: conv.r8
    IL_03B9: stloc.3
    IL_03BA: nop
    IL_03BB: nop
    IL_03BC: stloc.0
    IL_03BD: ldc.i4.0
    IL_03BE: conv.r8
    IL_03C3: beq IL_20A03C4
    IL_03C8: call 0x0A00002A
    IL_03CD: ldstr 0x7000016D
    IL_03CE: conv.r8
    IL_03CF: IL_3C
    IL_03D0: nop
    IL_03D1: nop
    IL_03D2: stloc.0
    IL_03D3: pop
    IL_03D4: ret
    }

    public void Grabed() {
    IL_0000: ret
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
    IL_000C: ldc.i4.s 20
    IL_000D: IL_3F
    IL_000E: ldloc.2
    IL_000F: ldarg.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: ldarg.0
    IL_0013: ldc.i4.0
    IL_0018: stfld 0x04000105
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040000FE
    IL_001F: conv.r8
    IL_0020: stloc.3
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ldc.i4.1
    IL_0025: conv.r8
    IL_002A: beq IL_20A002B
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000115
    IL_0035: ldfld 0x040002BF
    IL_003A: stfld 0x04000114
    IL_003B: ldarg.0
    IL_003C: ldc.i4.0
    IL_0041: stfld 0x04000103
    IL_0042: ldarg.0
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000115
    IL_004D: ldfld 0x04000357
    IL_0052: stfld 0x04000109
    IL_0053: ldarg.0
    IL_0058: ldfld 0x040000FD
    IL_0059: conv.r8
    IL_005A: ldc.i4.2
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040000FF
    IL_0068: call 0x0A000019
    IL_006D: call 0x0A000040
    IL_006E: stloc.0
    IL_006F: IL_22
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: nop
    IL_0074: stloc.1
    IL_0075: ldc.i4.0
    IL_0076: stloc.2
    IL_0077: ldarg.1
    IL_0078: conv.r8
    IL_0079: stloc.0
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: conv.r8
    IL_007E: ldc.i4.8
    IL_007F: nop
    IL_0080: nop
    IL_0081: stloc.0
    IL_0083: stloc.s 4
    IL_0085: ldloc.s 4
    IL_0087: ldc.i4.s 20
    IL_008C: beq IL_00A4
    IL_008E: ldloc.s 4
    IL_0090: ldc.i4.s 21
    IL_0095: beq IL_00DC
    IL_0097: ldloc.s 4
    IL_0099: ldc.i4.s 28
    IL_009E: beq IL_0113
    IL_00A3: br IL_0146
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A9: ldloc 2882
    IL_00AA: ldc.i4.0
    IL_00AC: ldc.i4.s 100
    IL_00B1: call 0x0A000045
    IL_00B2: stloc.2
    IL_00B3: ldarg.0
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x04000115
    IL_00BE: ldfld 0x040002C6
    IL_00BF: conv.i2
    IL_00C4: stfld 0x04000113
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04000117
    IL_00CB: conv.r8
    IL_00CC: IL_35
    IL_00CD: IL_01
    IL_00CE: nop
    IL_00CF: ldloc.0
    IL_00D0: ldarg.0
    IL_00D1: ldc.i4.0
    IL_00D6: stfld 0x04000108
    IL_00DB: br IL_0146
    IL_00DC: IL_22
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: IL_F0
    IL_00E0: IL_41
    IL_00E1: stloc.1
    IL_00E3: ldc.i4.s 100
    IL_00E4: stloc.2
    IL_00E5: ldarg.0
    IL_00E6: ldarg.0
    IL_00EB: ldfld 0x04000115
    IL_00F0: ldfld 0x040002C6
    IL_00F1: conv.i2
    IL_00F6: stfld 0x04000113
    IL_00F7: ldarg.0
    IL_00FC: ldfld 0x04000117
    IL_00FD: IL_22
    IL_00FE: nop
    IL_00FF: nop
    IL_0104: stsfld 0x01366F3F
    IL_0105: nop
    IL_0106: ldloc.0
    IL_0107: ldarg.0
    IL_0108: ldc.i4.1
    IL_010D: stfld 0x04000108
    IL_0112: br IL_0146
    IL_0113: IL_22
    IL_0114: nop
    IL_0115: nop
    IL_0118: ldloc 2882
    IL_0119: ldarg.0
    IL_011A: ldarg.0
    IL_011F: ldfld 0x04000115
    IL_0124: ldfld 0x040002C6
    IL_0125: conv.i2
    IL_012A: stfld 0x04000113
    IL_012B: ldarg.0
    IL_0130: ldfld 0x04000117
    IL_0131: conv.r8
    IL_0132: IL_35
    IL_0133: IL_01
    IL_0134: nop
    IL_0135: ldloc.0
    IL_0136: ldarg.0
    IL_0137: IL_22
    IL_0138: nop
    IL_0139: nop
    IL_013A: nop
    IL_013B: nop
    IL_0140: stfld 0x04000106
    IL_0145: br IL_0146
    IL_0146: ldloc.2
    IL_0147: ldarg.0
    IL_014C: ldfld 0x0400010C
    IL_014D: ldarg.0
    IL_0152: ldfld 0x04000114
    IL_0153: IL_59
    IL_0154: IL_3C
    IL_0155: IL_3D
    IL_0156: nop
    IL_0157: nop
    IL_0158: nop
    IL_0159: ldarg.0
    IL_015E: ldfld 0x040000F6
    IL_015F: ldc.i4.0
    IL_0160: IL_3F
    IL_0162: ble.s IL_0163
    IL_0163: nop
    IL_0164: nop
    IL_0165: ldarg.0
    IL_016A: ldfld 0x04000115
    IL_016B: ldarg.0
    IL_0170: ldfld 0x040000FD
    IL_0171: conv.r8
    IL_0172: ldc.i4.2
    IL_0173: nop
    IL_0174: nop
    IL_0175: stloc.0
    IL_0176: conv.r8
    IL_0177: len
    IL_0178: IL_01
    IL_0179: nop
    IL_017A: ldloc.0
    IL_017B: ldarg.0
    IL_0180: call 0x0A00003D
    IL_0181: ldloc.0
    IL_0182: IL_22
    IL_0183: nop
    IL_0184: nop
    IL_0189: ldc.i4 534593
    IL_018A: nop
    IL_018B: stloc.0
    IL_018C: conv.r8
    IL_018D: IL_3E
    IL_018E: nop
    IL_018F: nop
    IL_0190: stloc.0
    IL_0195: br IL_0281
    IL_0196: ldarg.0
    IL_019B: ldfld 0x04000116
    IL_019C: ldc.i4.1
    IL_019D: conv.r8
    IL_019E: IL_EC
    IL_019F: ldarg.2
    IL_01A0: nop
    IL_01A1: ldloc.0
    IL_01A2: ldarg.0
    IL_01A7: call 0x0A00002A
    IL_01A8: conv.r8
    IL_01AB: ldloc 0
    IL_01AC: stloc.0
    IL_01AD: ldarg.0
    IL_01B2: ldfld 0x04000108
    IL_01B7: brtrue IL_01C3
    IL_01B8: ldarg.0
    IL_01BD: ldfld 0x04000109
    IL_01C2: brfalse IL_01FA
    IL_01C3: ldarg.0
    IL_01C8: ldfld 0x040000FD
    IL_01C9: IL_22
    IL_01CA: nop
    IL_01CB: nop
    IL_01CC: nop
    IL_01CD: nop
    IL_01CE: ldc.i4.0
    IL_01D3: ldc.i4 360
    IL_01D8: call 0x0A000045
    IL_01D9: conv.i2
    IL_01DA: IL_22
    IL_01DB: nop
    IL_01DC: nop
    IL_01DD: nop
    IL_01DE: nop
    IL_01DF: conv.r8
    IL_01E0: conv.r8
    IL_01E1: nop
    IL_01E2: nop
    IL_01E3: stloc.0
    IL_01E4: ldarg.0
    IL_01E9: call 0x0A00002A
    IL_01EE: ldstr 0x70000181
    IL_01EF: conv.r8
    IL_01F0: IL_3C
    IL_01F1: nop
    IL_01F2: nop
    IL_01F3: stloc.0
    IL_01F4: pop
    IL_01F9: br IL_020B
    IL_01FA: ldarg.0
    IL_01FF: call 0x0A00002A
    IL_0204: ldstr 0x70000177
    IL_0205: conv.r8
    IL_0206: IL_3C
    IL_0207: nop
    IL_0208: nop
    IL_0209: stloc.0
    IL_020A: pop
    IL_020B: ldarg.0
    IL_0210: call 0x0A00003D
    IL_0211: ldloc.0
    IL_0212: ldloc.1
    IL_0217: call 0x0A000008
    IL_0218: conv.r8
    IL_0219: IL_3E
    IL_021A: nop
    IL_021B: nop
    IL_021C: stloc.0
    IL_021D: ldarg.0
    IL_0222: ldfld 0x0400011A
    IL_0223: ldarg.0
    IL_0228: ldfld 0x040000FD
    IL_0229: conv.r8
    IL_022A: ldc.i4.2
    IL_022B: nop
    IL_022C: nop
    IL_022D: stloc.0
    IL_022E: ldarg.0
    IL_0233: ldfld 0x04000112
    IL_0234: conv.r8
    IL_0235: IL_B8
    IL_0236: ldarg.1
    IL_0237: nop
    IL_0238: ldloc.0
    IL_0239: ldarg.0
    IL_023A: dup
    IL_023F: ldfld 0x0400010A
    IL_0240: ldarg.0
    IL_0245: ldfld 0x04000113
    IL_0246: not
    IL_0247: IL_59
    IL_024C: stfld 0x0400010A
    IL_024D: ldarg.0
    IL_0252: ldfld 0x04000118
    IL_0253: ldarg.0
    IL_0258: ldfld 0x0400010B
    IL_0259: ldarg.0
    IL_025E: ldfld 0x0400010A
    IL_025F: ldarg.0
    IL_0264: ldfld 0x040000FD
    IL_0265: IL_22
    IL_0266: ldelem.i
    IL_0267: IL_99
    IL_0268: ldc.i4.3
    IL_0269: IL_3E
    IL_026A: ldc.i4.0
    IL_026B: conv.r8
    IL_026C: ldnull
    IL_026D: ldarg.1
    IL_026E: nop
    IL_026F: ldloc.0
    IL_0270: ldarg.0
    IL_0275: call 0x0A00002B
    IL_0276: ldarg.0
    IL_027B: ldfld 0x040000F8
    IL_027C: conv.r8
    IL_027D: ldind.ref
    IL_027E: nop
    IL_027F: nop
    IL_0280: stloc.0
    IL_0281: ldarg.0
    IL_0286: ldfld 0x0400010A
    IL_0287: ldc.i4.0
    IL_0288: IL_3D
    IL_028D: newarr 0x02000000
    IL_0292: ldfld 0x04000101
    IL_0297: brfalse IL_031A
    IL_0298: ldarg.0
    IL_029A: ldc.i4.s -4
    IL_029F: stfld 0x040000F6
    IL_02A0: ldarg.0
    IL_02A1: ldc.i4.0
    IL_02A6: stfld 0x04000101
    IL_02A7: ldarg.0
    IL_02AC: ldfld 0x04000116
    IL_02AD: ldc.i4.4
    IL_02AE: conv.r8
    IL_02AF: IL_EC
    IL_02B0: ldarg.2
    IL_02B1: nop
    IL_02B2: ldloc.0
    IL_02B3: ldarg.0
    IL_02B8: call 0x0A00000A
    IL_02BD: call 0x0A000050
    IL_02BE: ldarg.0
    IL_02C3: ldfld 0x040000FE
    IL_02C4: conv.r8
    IL_02C5: stloc.0
    IL_02C6: nop
    IL_02C7: nop
    IL_02C8: stloc.0
    IL_02CD: call 0x0A000050
    IL_02CE: ldarg.0
    IL_02D3: ldfld 0x040000FD
    IL_02D4: conv.r8
    IL_02D5: ldc.i4.2
    IL_02D6: nop
    IL_02D7: nop
    IL_02D8: stloc.0
    IL_02D9: stloc.3
    IL_02DB: ldloca.s 3
    IL_02DC: ldc.i4.1
    IL_02DD: IL_22
    IL_02DE: nop
    IL_02DF: nop
    IL_02E0: nop
    IL_02E1: nop
    IL_02E6: call 0x0A00001A
    IL_02E7: ldarg.0
    IL_02EC: ldfld 0x0400011A
    IL_02ED: ldc.i4.2
    IL_02EE: ldloc.3
    IL_02EF: ldarg.0
    IL_02F4: ldfld 0x040000F5
    IL_02F5: ldarg.0
    IL_02FA: ldfld 0x040000FD
    IL_02FB: conv.r8
    IL_0300: cpobj 0x060A0000
    IL_0301: conv.r8
    IL_0302: IL_B4
    IL_0303: ldarg.1
    IL_0304: nop
    IL_0305: ldloc.0
    IL_030A: ldstr 0x70000063
    IL_030F: call 0x0A000004
    IL_0310: conv.r8
    IL_0312: stloc.s 0
    IL_0313: nop
    IL_0315: br.s IL_0385
    IL_0316: stloc.1
    IL_0317: ldarg.3
    IL_0318: nop
    IL_0319: ldloc.0
    IL_031A: ret
    }

    public void Attack() {
    IL_0000: ldarg.1
    IL_0001: stloc.3
    IL_0002: ldloc.3
    IL_0005: ldarg 3
    IL_0006: nop
    IL_0007: nop
    IL_0008: ldarg.3
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000E: ldloc 0
    IL_000F: nop
    IL_0010: stind.i
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0018: br IL_00E2
    IL_0019: ldarg.0
    IL_001E: call 0x0A00002A
    IL_0023: ldstr 0x70000391
    IL_0024: conv.r8
    IL_0025: IL_3C
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: pop
    IL_002A: ldarg.0
    IL_002F: call 0x0A00002A
    IL_0034: ldstr 0x700003AD
    IL_0035: ldc.i4.0
    IL_0036: conv.r8
    IL_0037: IL_53
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldarg.0
    IL_0042: call 0x0A00002A
    IL_0047: ldstr 0x700003AD
    IL_0048: conv.r8
    IL_004A: bge.s IL_004B
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: conv.r8
    IL_004E: IL_54
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: conv.r8
    IL_0054: bgt.s IL_0055
    IL_0055: nop
    IL_0056: stloc.0
    IL_005B: br IL_00E2
    IL_005C: ldarg.0
    IL_0061: call 0x0A00002A
    IL_0066: ldstr 0x700003CD
    IL_0067: conv.r8
    IL_0068: IL_3C
    IL_0069: nop
    IL_006A: nop
    IL_006B: stloc.0
    IL_006C: pop
    IL_006D: ldarg.0
    IL_0072: call 0x0A00002A
    IL_0077: ldstr 0x700003E9
    IL_0078: ldc.i4.0
    IL_0079: conv.r8
    IL_007A: IL_53
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: stloc.1
    IL_007F: ldloc.1
    IL_0080: ldarg.0
    IL_0085: call 0x0A00002A
    IL_008A: ldstr 0x700003E9
    IL_008B: conv.r8
    IL_008D: bge.s IL_008E
    IL_008E: nop
    IL_008F: stloc.0
    IL_0090: conv.r8
    IL_0091: IL_54
    IL_0092: nop
    IL_0093: nop
    IL_0094: stloc.0
    IL_0095: conv.r8
    IL_0097: bgt.s IL_0098
    IL_0098: nop
    IL_0099: stloc.0
    IL_009E: br IL_00E2
    IL_009F: ldarg.0
    IL_00A4: call 0x0A00002A
    IL_00A9: ldstr 0x70000409
    IL_00AA: conv.r8
    IL_00AB: IL_3C
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: stloc.0
    IL_00AF: pop
    IL_00B0: ldarg.0
    IL_00B5: call 0x0A00002A
    IL_00BA: ldstr 0x70000425
    IL_00BB: ldc.i4.0
    IL_00BC: conv.r8
    IL_00BD: IL_53
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: stloc.0
    IL_00C1: stloc.2
    IL_00C2: ldloc.2
    IL_00C3: ldarg.0
    IL_00C8: call 0x0A00002A
    IL_00CD: ldstr 0x70000425
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
    IL_00E1: br IL_00E2
    IL_00E2: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000101
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400010F
    IL_0013: conv.r8
    IL_0014: ldc.i4.2
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000100
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000110
    IL_0024: conv.r8
    IL_0025: ldc.i4.2
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: stfld 0x040000FF
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040000FD
    IL_0035: conv.r8
    IL_0036: ldc.i4.2
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000100
    IL_0044: call 0x0A000052
    IL_0049: stfld 0x04000107
    IL_004A: ldarg.0
    IL_004F: call 0x0A00002A
    IL_0054: ldstr 0x70000181
    IL_0055: conv.r8
    IL_0056: IL_56
    IL_0057: nop
    IL_0058: nop
    IL_0059: stloc.0
    IL_005E: brfalse IL_008C
    IL_005F: ldarg.0
    IL_0060: ldarg.0
    IL_0065: ldfld 0x04000100
    IL_0066: ldarg.0
    IL_006B: ldfld 0x040000FD
    IL_006C: conv.r8
    IL_006D: ldc.i4.2
    IL_006E: nop
    IL_006F: nop
    IL_0070: stloc.0
    IL_0075: call 0x0A000019
    IL_007A: call 0x0A000040
    IL_007F: stfld 0x04000112
    IL_0080: ldarg.0
    IL_0081: ldc.i4.m1
    IL_0086: stfld 0x040000F6
    IL_008B: br IL_03F1
    IL_008C: ldarg.0
    IL_0091: call 0x0A00002A
    IL_0096: ldstr 0x70000177
    IL_0097: conv.r8
    IL_0098: IL_56
    IL_0099: nop
    IL_009A: nop
    IL_009B: stloc.0
    IL_00A0: brfalse IL_00CE
    IL_00A1: ldarg.0
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000100
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x040000FD
    IL_00AE: conv.r8
    IL_00AF: ldc.i4.2
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: stloc.0
    IL_00B7: call 0x0A000019
    IL_00BC: call 0x0A000040
    IL_00C1: stfld 0x04000112
    IL_00C2: ldarg.0
    IL_00C3: ldc.i4.m1
    IL_00C8: stfld 0x040000F6
    IL_00CD: br IL_03F1
    IL_00CE: ldarg.0
    IL_00D3: call 0x0A00002A
    IL_00D8: ldstr 0x70000391
    IL_00D9: conv.r8
    IL_00DA: IL_56
    IL_00DB: nop
    IL_00DC: nop
    IL_00DD: stloc.0
    IL_00E2: brtrue IL_010D
    IL_00E3: ldarg.0
    IL_00E8: call 0x0A00002A
    IL_00ED: ldstr 0x700003CD
    IL_00EE: conv.r8
    IL_00EF: IL_56
    IL_00F0: nop
    IL_00F1: nop
    IL_00F2: stloc.0
    IL_00F7: brtrue IL_010D
    IL_00F8: ldarg.0
    IL_00FD: call 0x0A00002A
    IL_0102: ldstr 0x70000409
    IL_0103: conv.r8
    IL_0104: IL_56
    IL_0105: nop
    IL_0106: nop
    IL_0107: stloc.0
    IL_010C: brfalse IL_0205
    IL_010D: ldarg.0
    IL_010E: ldarg.0
    IL_0113: ldfld 0x04000100
    IL_0114: ldarg.0
    IL_0119: ldfld 0x040000FD
    IL_011A: conv.r8
    IL_011B: ldc.i4.2
    IL_011C: nop
    IL_011D: nop
    IL_011E: stloc.0
    IL_0123: call 0x0A000019
    IL_0128: call 0x0A000040
    IL_012D: stfld 0x04000112
    IL_012E: ldarg.0
    IL_012F: ldc.i4.0
    IL_0134: stfld 0x04000102
    IL_0135: ldarg.0
    IL_0137: ldc.i4.s 11
    IL_013C: stfld 0x040000F6
    IL_013D: ldarg.0
    IL_0142: ldfld 0x04000112
    IL_0147: call 0x0A00001B
    IL_014C: call 0x0A00001C
    IL_0151: brfalse IL_018F
    IL_0152: ldarg.0
    IL_0153: ldarg.0
    IL_0158: ldfld 0x04000112
    IL_015D: call 0x0A00001D
    IL_0162: stfld 0x04000111
    IL_0163: ldarg.0
    IL_0168: ldfld 0x040000FD
    IL_0169: ldarg.0
    IL_016E: ldfld 0x040000FD
    IL_016F: conv.r8
    IL_0170: pop
    IL_0171: nop
    IL_0172: nop
    IL_0173: stloc.0
    IL_0174: ldarg.0
    IL_0179: ldfld 0x04000111
    IL_017E: call 0x0A000024
    IL_017F: IL_22
    IL_0180: nop
    IL_0181: nop
    IL_0182: IL_C0
    IL_230A2EF: switch (9185370 cases)
    }

    }}
