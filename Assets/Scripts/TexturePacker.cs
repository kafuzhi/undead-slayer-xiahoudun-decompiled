// Namespace: 
// Type: TexturePacker

    public class TexturePacker {{

    public object generateLightMapUVs;
    public object generateColorTextures;
    public object generatedMaterialColor;
    private object shaderToMaterial;
    private object generatedMaterials;
    private object generatedUVs;
    private object generatedUV2s;

    public TexturePacker() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000A09
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x04000A0A
    IL_000E: ldarg.0
    IL_0013: call 0x0A00017C
    IL_0018: stfld 0x04000A0B
    IL_0019: ldarg.0
    IL_001E: newobj 0x0A000265
    IL_0023: stfld 0x04000A0C
    IL_0024: ldarg.0
    IL_0029: newobj 0x0A000266
    IL_002E: stfld 0x04000A0D
    IL_002F: ldarg.0
    IL_0034: newobj 0x0A000267
    IL_0039: stfld 0x04000A0E
    IL_003A: ldarg.0
    IL_003F: newobj 0x0A000267
    IL_0044: stfld 0x04000A0F
    IL_0045: ldarg.0
    IL_004A: call 0x0A000001
    IL_004B: ret
    }

    private void Start() {
    IL_0004: newobj 0x0A000268
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: ldtoken 0x01000030
    IL_0011: call 0x0A0000A2
    IL_0016: call 0x0A000269
    IL_0017: conv.r8
    IL_0018: conv.i1
    IL_0019: ldarg.0
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.3
    IL_0022: br IL_0339
    IL_0023: ldloc.0
    IL_0024: ldloc.3
    IL_0025: conv.r8
    IL_0026: conv.i2
    IL_0027: ldarg.0
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: conv.r8
    IL_002B: stloc.3
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_0030: stloc.s 4
    IL_0031: ldloc.0
    IL_0032: ldloc.3
    IL_0033: conv.r8
    IL_0034: conv.i2
    IL_0035: ldarg.0
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: conv.u4
    IL_003A: bgt.s IL_003B
    IL_003B: nop
    IL_003C: IL_01
    IL_003D: conv.r8
    IL_003E: IL_A9
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: conv.r8
    IL_0043: conv.i4
    IL_0044: ldarg.0
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: stloc.2
    IL_0048: ldloc.2
    IL_004D: brfalse IL_0056
    IL_004E: ldloc.2
    IL_004F: len
    IL_0050: not
    IL_0055: brtrue IL_00A2
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04000A09
    IL_0060: brfalse IL_00A2
    IL_0061: ldloc.0
    IL_0062: ldloc.3
    IL_0063: conv.r8
    IL_0064: conv.i2
    IL_0065: ldarg.0
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: conv.u4
    IL_006A: bgt.s IL_006B
    IL_006B: nop
    IL_006C: IL_01
    IL_006D: conv.r8
    IL_006E: IL_A9
    IL_006F: nop
    IL_0070: nop
    IL_0071: stloc.0
    IL_0072: conv.r8
    IL_0073: IL_8F
    IL_0074: IL_01
    IL_0075: nop
    IL_0076: stloc.0
    IL_0077: stloc.1
    IL_0078: ldloc.1
    IL_0079: len
    IL_007A: not
    IL_007F: newarr 0x01000014
    IL_0080: stloc.2
    IL_0081: ldloc.1
    IL_0082: ldloc.2
    IL_0083: ldloc.1
    IL_0084: len
    IL_0085: not
    IL_008A: call 0x0A00026D
    IL_008B: ldloc.0
    IL_008C: ldloc.3
    IL_008D: conv.r8
    IL_008E: conv.i2
    IL_008F: ldarg.0
    IL_0090: nop
    IL_0091: stloc.0
    IL_0092: conv.u4
    IL_0094: bgt.s IL_0095
    IL_0095: nop
    IL_0096: IL_01
    IL_0097: conv.r8
    IL_0098: IL_A9
    IL_0099: nop
    IL_009A: nop
    IL_009B: stloc.0
    IL_009C: ldloc.2
    IL_009D: conv.r8
    IL_009E: conv.r4
    IL_009F: ldarg.0
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: ldc.i4.1
    IL_00A4: stloc.s 5
    IL_00A6: ldloc.s 4
    IL_00A7: ldnull
    IL_00AC: call 0x0A000021
    IL_00B1: brfalse IL_0335
    IL_00B3: ldloc.s 4
    IL_00B4: conv.r8
    IL_00B5: IL_C9
    IL_00B6: nop
    IL_00B7: nop
    IL_00B8: stloc.0
    IL_00BD: brfalse IL_0335
    IL_00BF: ldloc.s 4
    IL_00C0: conv.r8
    IL_00C2: ldarg.s 0
    IL_00C3: nop
    IL_00C4: stloc.0
    IL_00C5: ldnull
    IL_00CA: call 0x0A000021
    IL_00CF: brfalse IL_0335
    IL_00D1: ldloc.s 4
    IL_00D2: conv.r8
    IL_00D3: conv.r8
    IL_00D4: ldarg.0
    IL_00D5: nop
    IL_00D6: stloc.0
    IL_00D8: stloc.s 6
    IL_00DA: ldloc.s 6
    IL_00DF: brfalse IL_0335
    IL_00E1: ldloc.s 6
    IL_00E3: stloc.s 8
    IL_00E4: ldc.i4.0
    IL_00E6: stloc.s 9
    IL_00EB: br IL_02B2
    IL_00ED: ldloc.s 8
    IL_00EF: ldloc.s 9
    IL_00F0: ldelem.i
    IL_00F2: stloc.s 7
    IL_00F3: ldarg.0
    IL_00F8: ldfld 0x04000A0A
    IL_00FD: brfalse IL_018C
    IL_00FF: ldloc.s 7
    IL_0100: conv.r8
    IL_0102: blt.s IL_0103
    IL_0103: nop
    IL_0104: stloc.0
    IL_0105: ldnull
    IL_010A: call 0x0A000061
    IL_010F: brfalse IL_0189
    IL_0110: ldc.i4.4
    IL_0111: ldc.i4.4
    IL_0116: newobj 0x0A000270
    IL_0118: stloc.s 10
    IL_0119: ldc.i4.0
    IL_011B: stloc.s 11
    IL_0120: br IL_0155
    IL_0121: ldc.i4.0
    IL_0123: stloc.s 12
    IL_0128: br IL_0141
    IL_012A: ldloc.s 10
    IL_012C: ldloc.s 12
    IL_012E: ldloc.s 11
    IL_0130: ldloc.s 7
    IL_0131: conv.r8
    IL_0136: ldobj 0x6F0A0002
    IL_013B: ldstr 0x110A0002
    IL_013C: stloc.2
    IL_013D: ldc.i4.1
    IL_013E: IL_58
    IL_0140: stloc.s 12
    IL_0142: ldloc.s 12
    IL_0144: ldloc.s 10
    IL_0145: conv.r8
    IL_014A: newobj 0x3F0A0002
    IL_014B: IL_DA
    IL_014C: IL_FF
    IL_014D: IL_FF
    IL_014E: IL_FF
    IL_0150: ldloc.s 11
    IL_0151: ldc.i4.1
    IL_0152: IL_58
    IL_0154: stloc.s 11
    IL_0156: ldloc.s 11
    IL_0158: ldloc.s 10
    IL_0159: conv.r8
    IL_015A: conv.u4
    IL_015B: ldarg.0
    IL_015C: nop
    IL_015D: stloc.0
    IL_015E: IL_3F
    IL_015F: IL_BE
    IL_0160: IL_FF
    IL_0161: IL_FF
    IL_0162: IL_FF
    IL_0164: ldloc.s 10
    IL_0165: conv.r8
    IL_0166: conv.u8
    IL_0167: ldarg.0
    IL_0168: nop
    IL_0169: stloc.0
    IL_016B: ldloc.s 7
    IL_0170: ldstr 0x700023C1
    IL_0172: ldloc.s 10
    IL_0173: conv.r8
    IL_0174: conv.u8
    IL_0175: IL_01
    IL_0176: nop
    IL_0177: stloc.0
    IL_0179: ldloc.s 7
    IL_017E: call 0x0A00017C
    IL_017F: conv.r8
    IL_0180: IL_85
    IL_0181: IL_01
    IL_0182: nop
    IL_0183: stloc.0
    IL_0188: br IL_018C
    IL_0189: ldc.i4.0
    IL_018B: stloc.s 5
    IL_018D: ldloc.s 7
    IL_0192: ldstr 0x70022E0F
    IL_0193: conv.r8
    IL_0194: conv.r.un
    IL_0195: ldarg.0
    IL_0196: nop
    IL_0197: stloc.0
    IL_019C: brfalse IL_01DC
    IL_019D: ldloc.0
    IL_019E: ldloc.3
    IL_019F: conv.r8
    IL_01A0: conv.i2
    IL_01A1: ldarg.0
    IL_01A2: nop
    IL_01A3: stloc.0
    IL_01A4: conv.u4
    IL_01A6: bgt.s IL_01A7
    IL_01A7: nop
    IL_01A8: IL_01
    IL_01A9: conv.r8
    IL_01AA: IL_A9
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: stloc.0
    IL_01AE: conv.r8
    IL_01AF: conv.i4
    IL_01B0: ldarg.0
    IL_01B1: nop
    IL_01B2: stloc.0
    IL_01B3: len
    IL_01B4: not
    IL_01B9: brtrue IL_01C5
    IL_01BA: ldarg.0
    IL_01BF: ldfld 0x04000A09
    IL_01C4: brfalse IL_01DC
    IL_01C6: ldloc.s 7
    IL_01CB: ldstr 0x70022E0F
    IL_01CC: conv.r8
    IL_01CD: IL_77
    IL_01CE: ldarg.0
    IL_01CF: nop
    IL_01D0: stloc.0
    IL_01D1: ldnull
    IL_01D6: call 0x0A000021
    IL_01DB: brtrue IL_01ED
    IL_01DD: ldloc.s 7
    IL_01E2: ldstr 0x70022E0F
    IL_01E3: conv.r8
    IL_01E4: conv.r.un
    IL_01E5: ldarg.0
    IL_01E6: nop
    IL_01E7: stloc.0
    IL_01EC: brtrue IL_02AC
    IL_01EE: ldloc.s 7
    IL_01EF: conv.r8
    IL_01F0: IL_78
    IL_01F1: ldarg.0
    IL_01F2: nop
    IL_01F3: stloc.0
    IL_01F4: IL_22
    IL_01F5: nop
    IL_01F6: nop
    IL_01FB: stsfld 0x0000223F
    IL_0200: stsfld 0x0038733F
    IL_0201: nop
    IL_0202: stloc.0
    IL_0207: call 0x0A000279
    IL_020C: brfalse IL_02AC
    IL_020E: ldloc.s 7
    IL_020F: conv.r8
    IL_0214: newobj 0x280A0001
    IL_0215: IL_57
    IL_0216: nop
    IL_0217: nop
    IL_0218: stloc.0
    IL_021D: call 0x0A000279
    IL_0222: brfalse IL_02AC
    IL_0224: ldloc.s 7
    IL_0225: conv.r8
    IL_0226: throw
    IL_0227: ldarg.0
    IL_0228: nop
    IL_0229: stloc.0
    IL_022A: ldnull
    IL_022F: call 0x0A000021
    IL_0234: brfalse IL_02AC
    IL_0236: ldloc.s 7
    IL_0237: conv.r8
    IL_0239: blt.s IL_023A
    IL_023A: nop
    IL_023B: stloc.0
    IL_023C: ldnull
    IL_0241: call 0x0A000021
    IL_0246: brfalse IL_02AC
    IL_0247: ldarg.0
    IL_024C: ldfld 0x04000A0C
    IL_024E: ldloc.s 7
    IL_024F: conv.r8
    IL_0250: throw
    IL_0251: ldarg.0
    IL_0252: nop
    IL_0253: stloc.0
    IL_0254: conv.r8
    IL_0259: ldfld 0x390A0002
    IL_025A: ldc.i4.8
    IL_025B: nop
    IL_025C: nop
    IL_025D: nop
    IL_025E: ldarg.0
    IL_0263: ldfld 0x04000A0C
    IL_0265: ldloc.s 7
    IL_0266: conv.r8
    IL_0267: throw
    IL_0268: ldarg.0
    IL_0269: nop
    IL_026A: stloc.0
    IL_026B: conv.r8
    IL_0270: ldflda 0x110A0002
    IL_0271: ldloc.1
    IL_0272: conv.r8
    IL_0277: stfld 0x380A0002
    IL_0279: bgt.s IL_027A
    IL_027A: nop
    IL_027B: nop
    IL_027C: ldarg.0
    IL_0281: ldfld 0x04000A0C
    IL_0283: ldloc.s 7
    IL_0284: conv.r8
    IL_0285: throw
    IL_0286: ldarg.0
    IL_0287: nop
    IL_0288: stloc.0
    IL_028D: newobj 0x0A00027E
    IL_028E: conv.r8
    IL_0293: ldsflda 0x020A0002
    IL_0298: ldfld 0x04000A0C
    IL_029A: ldloc.s 7
    IL_029B: conv.r8
    IL_029C: throw
    IL_029D: ldarg.0
    IL_029E: nop
    IL_029F: stloc.0
    IL_02A0: conv.r8
    IL_02A5: ldflda 0x110A0002
    IL_02A6: ldloc.1
    IL_02A7: conv.r8
    IL_02AC: stfld 0x110A0002
    IL_02AD: ldloc.3
    IL_02AE: ldc.i4.1
    IL_02AF: IL_58
    IL_02B1: stloc.s 9
    IL_02B3: ldloc.s 9
    IL_02B5: ldloc.s 8
    IL_02B6: len
    IL_02B7: not
    IL_02B8: IL_3F
    IL_02BA: bge.s IL_02B9
    IL_02BB: IL_FF
    IL_02BC: IL_FF
    IL_02BD: ldarg.0
    IL_02C2: ldfld 0x04000A0A
    IL_02C7: brfalse IL_0335
    IL_02C9: ldloc.s 5
    IL_02CE: brfalse IL_0335
    IL_02CF: ldloc.0
    IL_02D0: ldloc.3
    IL_02D1: conv.r8
    IL_02D2: conv.i2
    IL_02D3: ldarg.0
    IL_02D4: nop
    IL_02D5: stloc.0
    IL_02D6: conv.u4
    IL_02D8: bgt.s IL_02D9
    IL_02D9: nop
    IL_02DA: IL_01
    IL_02DB: conv.r8
    IL_02DC: IL_A9
    IL_02DD: nop
    IL_02DE: nop
    IL_02DF: stloc.0
    IL_02E0: conv.r8
    IL_02E1: IL_8F
    IL_02E2: IL_01
    IL_02E3: nop
    IL_02E4: stloc.0
    IL_02E6: stloc.s 13
    IL_02E7: ldc.i4.0
    IL_02E9: stloc.s 14
    IL_02EE: br IL_0312
    IL_02F0: ldloc.s 13
    IL_02F2: ldloc.s 14
    IL_02F3: IL_8F
    IL_02F4: ldnull
    IL_02F5: nop
    IL_02F6: nop
    IL_02F7: IL_01
    IL_02F8: IL_22
    IL_02F9: nop
    IL_02FA: nop
    IL_02FB: nop
    IL_02FC: IL_3F
    IL_02FD: IL_22
    IL_02FE: nop
    IL_02FF: nop
    IL_0300: nop
    IL_0301: IL_3F
    IL_0306: newobj 0x0A000038
    IL_0307: IL_81
    IL_0308: ldnull
    IL_0309: nop
    IL_030A: nop
    IL_030B: IL_01
    IL_030D: ldloc.s 14
    IL_030E: ldc.i4.1
    IL_030F: IL_58
    IL_0311: stloc.s 14
    IL_0313: ldloc.s 14
    IL_0315: ldloc.s 13
    IL_0316: len
    IL_0317: not
    IL_0318: IL_3F
    IL_0319: IL_D2
    IL_031A: IL_FF
    IL_031B: IL_FF
    IL_031C: IL_FF
    IL_031D: ldloc.0
    IL_031E: ldloc.3
    IL_031F: conv.r8
    IL_0320: conv.i2
    IL_0321: ldarg.0
    IL_0322: nop
    IL_0323: stloc.0
    IL_0324: conv.u4
    IL_0326: bgt.s IL_0327
    IL_0327: nop
    IL_0328: IL_01
    IL_0329: conv.r8
    IL_032A: IL_A9
    IL_032B: nop
    IL_032C: nop
    IL_032D: stloc.0
    IL_032F: ldloc.s 13
    IL_0330: conv.r8
    IL_0331: IL_AC
    IL_0332: nop
    IL_0333: nop
    IL_0334: stloc.0
    IL_0335: ldloc.3
    IL_0336: ldc.i4.1
    IL_0337: IL_58
    IL_0338: stloc.3
    IL_0339: ldloc.3
    IL_033A: ldloc.0
    IL_033B: conv.r8
    IL_0340: stsfld 0x3F0A0002
    IL_0341: IL_DE
    IL_0342: IL_FC
    IL_0343: IL_FF
    IL_0344: IL_FF
    IL_0345: ldarg.0
    IL_034A: ldfld 0x04000A0C
    IL_034B: conv.r8
    IL_034C: IL_81
    IL_034D: ldarg.0
    IL_034E: nop
    IL_034F: stloc.0
    IL_0350: conv.r8
    IL_0351: IL_82
    IL_0352: ldarg.0
    IL_0353: nop
    IL_0354: stloc.0
    IL_0356: stloc.s 16
    IL_035B: br IL_057D
    IL_035D: ldloca.s 16
    IL_0362: call 0x0A000283
    IL_0364: stloc.s 15
    IL_0369: ldc.i4 1024
    IL_036E: ldc.i4 1024
    IL_0373: newobj 0x0A000270
    IL_0375: stloc.s 17
    IL_0376: ldarg.0
    IL_037B: ldfld 0x04000A0C
    IL_037D: ldloc.s 15
    IL_037E: conv.r8
    IL_0383: ldflda 0x6F0A0002
    IL_0384: IL_84
    IL_0385: ldarg.0
    IL_0386: nop
    IL_0387: stloc.0
    IL_038C: newarr 0x0100003C
    IL_038E: stloc.s 18
    IL_038F: ldarg.0
    IL_0394: ldfld 0x04000A0D
    IL_0396: ldloc.s 15
    IL_0398: ldloc.s 15
    IL_039D: newobj 0x0A000285
    IL_039E: conv.r8
    IL_039F: IL_86
    IL_03A0: ldarg.0
    IL_03A1: nop
    IL_03A2: stloc.0
    IL_03A3: ldc.i4.0
    IL_03A5: stloc.s 19
    IL_03AA: br IL_03D4
    IL_03AC: ldloc.s 18
    IL_03AE: ldloc.s 19
    IL_03AF: ldarg.0
    IL_03B4: ldfld 0x04000A0C
    IL_03B6: ldloc.s 15
    IL_03B7: conv.r8
    IL_03BC: ldflda 0x110A0002
    IL_03BE: stloc.s 111
    IL_03BF: IL_87
    IL_03C0: ldarg.0
    IL_03C1: nop
    IL_03C2: stloc.0
    IL_03C3: conv.r8
    IL_03C5: blt.s IL_03C6
    IL_03C6: nop
    IL_03C7: stloc.0
    IL_03C8: conv.u8
    IL_03C9: IL_3C
    IL_03CA: nop
    IL_03CB: nop
    IL_03CC: IL_01
    IL_03D1: stelem 0x58171311
    IL_03D3: stloc.s 19
    IL_03D5: ldloc.s 19
    IL_03D7: ldloc.s 18
    IL_03D8: len
    IL_03D9: not
    IL_03DA: IL_3F
    IL_03DB: IL_CC
    IL_03DC: IL_FF
    IL_03DD: IL_FF
    IL_03DE: IL_FF
    IL_03E0: ldloc.s 17
    IL_03E2: ldloc.s 18
    IL_03E3: ldc.i4.0
    IL_03E8: ldc.i4 2048
    IL_03E9: conv.r8
    IL_03EA: IL_88
    IL_03EB: ldarg.0
    IL_03EC: nop
    IL_03ED: stloc.0
    IL_03EF: stloc.s 20
    IL_03F1: ldloc.s 17
    IL_03F2: conv.r8
    IL_03F3: conv.u8
    IL_03F4: ldarg.0
    IL_03F5: nop
    IL_03F6: stloc.0
    IL_03F7: ldarg.0
    IL_03FC: ldfld 0x04000A0D
    IL_03FE: ldloc.s 15
    IL_03FF: conv.r8
    IL_0400: IL_89
    IL_0401: ldarg.0
    IL_0402: nop
    IL_0403: stloc.0
    IL_0404: ldarg.0
    IL_0409: ldfld 0x04000A0C
    IL_040B: ldloc.s 15
    IL_040C: conv.r8
    IL_0411: ldflda 0x160A0002
    IL_0412: conv.r8
    IL_0413: IL_87
    IL_0414: ldarg.0
    IL_0415: nop
    IL_0416: stloc.0
    IL_0417: conv.r8
    IL_0418: ldind.ref
    IL_0419: ldarg.0
    IL_041A: nop
    IL_041B: stloc.0
    IL_041C: ldarg.0
    IL_0421: ldfld 0x04000A0D
    IL_0423: ldloc.s 15
    IL_0424: conv.r8
    IL_0425: IL_89
    IL_0426: ldarg.0
    IL_0427: nop
    IL_0428: stloc.0
    IL_042A: ldloc.s 17
    IL_042B: conv.r8
    IL_042D: ldarga.s 0
    IL_042E: nop
    IL_042F: stloc.0
    IL_0430: ldarg.0
    IL_0435: ldfld 0x04000A0D
    IL_0437: ldloc.s 15
    IL_0438: conv.r8
    IL_0439: IL_89
    IL_043A: ldarg.0
    IL_043B: nop
    IL_043C: stloc.0
    IL_043D: ldarg.0
    IL_0442: ldfld 0x04000A0B
    IL_0443: conv.r8
    IL_0444: IL_85
    IL_0445: IL_01
    IL_0446: nop
    IL_0447: stloc.0
    IL_0448: ldc.i4.0
    IL_044A: stloc.s 21
    IL_044F: br IL_04A1
    IL_0450: ldarg.0
    IL_0455: ldfld 0x04000A0C
    IL_0457: ldloc.s 15
    IL_0458: conv.r8
    IL_045D: ldflda 0x110A0002
    IL_045E: ldc.i4.m1
    IL_045F: conv.r8
    IL_0460: IL_87
    IL_0461: ldarg.0
    IL_0462: nop
    IL_0463: stloc.0
    IL_0468: ldstr 0x70022E0F
    IL_0469: conv.r8
    IL_046A: conv.r.un
    IL_046B: ldarg.0
    IL_046C: nop
    IL_046D: stloc.0
    IL_0472: brfalse IL_049B
    IL_0474: ldloc.s 18
    IL_0476: ldloc.s 21
    IL_0477: ldarg.0
    IL_047C: ldfld 0x04000A0C
    IL_047E: ldloc.s 15
    IL_047F: conv.r8
    IL_0484: ldflda 0x110A0002
    IL_0485: ldc.i4.m1
    IL_0486: conv.r8
    IL_0487: IL_87
    IL_0488: ldarg.0
    IL_0489: nop
    IL_048A: stloc.0
    IL_048F: ldstr 0x70022E0F
    IL_0490: conv.r8
    IL_0491: IL_77
    IL_0492: ldarg.0
    IL_0493: nop
    IL_0494: stloc.0
    IL_0495: conv.u8
    IL_0496: IL_3C
    IL_0497: nop
    IL_0498: nop
    IL_0499: IL_01
    IL_049E: stelem 0x58171511
    IL_04A0: stloc.s 21
    IL_04A2: ldloc.s 21
    IL_04A4: ldloc.s 18
    IL_04A5: len
    IL_04A6: not
    IL_04A7: IL_3F
    IL_04A8: IL_A4
    IL_04A9: IL_FF
    IL_04AA: IL_FF
    IL_04AB: IL_FF
    IL_04B0: ldc.i4 1024
    IL_04B5: ldc.i4 1024
    IL_04BA: newobj 0x0A000270
    IL_04BC: stloc.s 17
    IL_04BE: ldloc.s 17
    IL_04C0: ldloc.s 18
    IL_04C1: ldc.i4.0
    IL_04C6: ldc.i4 2048
    IL_04C7: conv.r8
    IL_04C8: IL_88
    IL_04C9: ldarg.0
    IL_04CA: nop
    IL_04CB: stloc.0
    IL_04CD: stloc.s 22
    IL_04CF: ldloc.s 17
    IL_04D0: conv.r8
    IL_04D1: conv.u8
    IL_04D2: ldarg.0
    IL_04D3: nop
    IL_04D4: stloc.0
    IL_04D5: ldarg.0
    IL_04DA: ldfld 0x04000A0D
    IL_04DC: ldloc.s 15
    IL_04DD: conv.r8
    IL_04DE: IL_89
    IL_04DF: ldarg.0
    IL_04E0: nop
    IL_04E1: stloc.0
    IL_04E6: ldstr 0x70022E0F
    IL_04E7: conv.r8
    IL_04E8: conv.r.un
    IL_04E9: ldarg.0
    IL_04EA: nop
    IL_04EB: stloc.0
    IL_04F0: brfalse IL_050A
    IL_04F1: ldarg.0
    IL_04F6: ldfld 0x04000A0D
    IL_04F8: ldloc.s 15
    IL_04F9: conv.r8
    IL_04FA: IL_89
    IL_04FB: ldarg.0
    IL_04FC: nop
    IL_04FD: stloc.0
    IL_0502: ldstr 0x70022E0F
    IL_0504: ldloc.s 17
    IL_0505: conv.r8
    IL_0506: conv.u8
    IL_0507: IL_01
    IL_0508: nop
    IL_0509: stloc.0
    IL_050A: ldc.i4.0
    IL_050C: stloc.s 23
    IL_0511: br IL_0572
    IL_0512: ldarg.0
    IL_0517: ldfld 0x04000A0E
    IL_0518: ldarg.0
    IL_051D: ldfld 0x04000A0C
    IL_051F: ldloc.s 15
    IL_0520: conv.r8
    IL_0525: ldflda 0x110A0002
    IL_0526: ldc.i4.1
    IL_0527: conv.r8
    IL_0528: IL_87
    IL_0529: ldarg.0
    IL_052A: nop
    IL_052B: stloc.0
    IL_052D: ldloc.s 20
    IL_052F: ldloc.s 23
    IL_0530: IL_8F
    IL_0535: brtrue IL_71010536
    IL_053A: brtrue IL_6F01053B
    IL_053B: stind.i
    IL_053C: ldarg.0
    IL_053D: nop
    IL_053E: stloc.0
    IL_053F: ldarg.0
    IL_0544: ldfld 0x04000A0F
    IL_0545: ldarg.0
    IL_054A: ldfld 0x04000A0C
    IL_054C: ldloc.s 15
    IL_054D: conv.r8
    IL_0552: ldflda 0x110A0002
    IL_0553: ldc.i4.1
    IL_0554: conv.r8
    IL_0555: IL_87
    IL_0556: ldarg.0
    IL_0557: nop
    IL_0558: stloc.0
    IL_055A: ldloc.s 22
    IL_055C: ldloc.s 23
    IL_055D: IL_8F
    IL_0562: brtrue IL_71010563
    IL_0567: brtrue IL_6F010568
    IL_0568: stind.i
    IL_0569: ldarg.0
    IL_056A: nop
    IL_056B: stloc.0
    IL_056D: ldloc.s 23
    IL_056E: ldc.i4.1
    IL_056F: IL_58
    IL_0571: stloc.s 23
    IL_0573: ldloc.s 23
    IL_0575: ldloc.s 18
    IL_0576: len
    IL_0577: not
    IL_0578: IL_3F
    IL_0579: IL_95
    IL_057A: IL_FF
    IL_057B: IL_FF
    IL_057C: IL_FF
    IL_057E: ldloca.s 16
    IL_0583: call 0x0A00028C
    IL_0588: brtrue IL_035C
    IL_0589: IL_DD
    IL_058A: stloc.3
    IL_058B: nop
    IL_058C: nop
    IL_058D: nop
    IL_058F: ldloc.s 16
    IL_0594: newobj 0x1B00001A
    IL_0595: conv.r8
    IL_0596: ldelem.ref
    IL_0597: nop
    IL_0598: nop
    IL_0599: stloc.0
    IL_059A: IL_DC
    IL_059B: ldc.i4.0
    IL_059D: stloc.s 24
    IL_05A2: br IL_07D0
    IL_05A3: ldloc.0
    IL_05A5: ldloc.s 24
    IL_05A6: conv.r8
    IL_05A7: conv.i2
    IL_05A8: ldarg.0
    IL_05A9: nop
    IL_05AA: stloc.0
    IL_05AB: conv.u4
    IL_05AD: bgt.s IL_05AE
    IL_05AE: nop
    IL_05AF: IL_01
    IL_05B0: conv.r8
    IL_05B1: IL_A9
    IL_05B2: nop
    IL_05B3: nop
    IL_05B4: stloc.0
    IL_05B5: conv.r8
    IL_05BA: newarr 0x130A0002
    IL_05BB: ldc.i4.3
    IL_05BC: ldloc.0
    IL_05BE: ldloc.s 24
    IL_05BF: conv.r8
    IL_05C0: conv.i2
    IL_05C1: ldarg.0
    IL_05C2: nop
    IL_05C3: stloc.0
    IL_05C4: conv.r8
    IL_05C5: stloc.0
    IL_05C6: nop
    IL_05C7: nop
    IL_05C8: stloc.0
    IL_05C9: conv.r8
    IL_05CA: ldind.ref
    IL_05CB: IL_01
    IL_05CC: nop
    IL_05CD: stloc.0
    IL_05CE: conv.r8
    IL_05CF: conv.r8
    IL_05D0: ldarg.0
    IL_05D1: nop
    IL_05D2: stloc.0
    IL_05D4: stloc.s 26
    IL_05D5: ldloc.0
    IL_05D7: ldloc.s 24
    IL_05D8: conv.r8
    IL_05D9: conv.i2
    IL_05DA: ldarg.0
    IL_05DB: nop
    IL_05DC: stloc.0
    IL_05DD: conv.u4
    IL_05DF: bgt.s IL_05E0
    IL_05E0: nop
    IL_05E1: IL_01
    IL_05E2: conv.r8
    IL_05E3: IL_A9
    IL_05E4: nop
    IL_05E5: nop
    IL_05E6: stloc.0
    IL_05E7: conv.r8
    IL_05E8: IL_8F
    IL_05E9: IL_01
    IL_05EA: nop
    IL_05EB: stloc.0
    IL_05EC: stloc.1
    IL_05ED: ldloc.0
    IL_05EF: ldloc.s 24
    IL_05F0: conv.r8
    IL_05F1: conv.i2
    IL_05F2: ldarg.0
    IL_05F3: nop
    IL_05F4: stloc.0
    IL_05F5: conv.u4
    IL_05F7: bgt.s IL_05F8
    IL_05F8: nop
    IL_05F9: IL_01
    IL_05FA: conv.r8
    IL_05FB: IL_A9
    IL_05FC: nop
    IL_05FD: nop
    IL_05FE: stloc.0
    IL_05FF: conv.r8
    IL_0600: conv.i4
    IL_0601: ldarg.0
    IL_0602: nop
    IL_0603: stloc.0
    IL_0604: stloc.2
    IL_0605: ldc.i4.0
    IL_0607: stloc.s 27
    IL_060C: br IL_076A
    IL_060D: ldarg.0
    IL_0612: ldfld 0x04000A0E
    IL_0614: ldloc.s 26
    IL_0616: ldloc.s 27
    IL_0617: ldelem.i
    IL_0618: conv.r8
    IL_0619: len
    IL_061A: ldarg.0
    IL_061B: nop
    IL_061C: stloc.0
    IL_0621: brfalse IL_0764
    IL_0622: ldarg.0
    IL_0627: ldfld 0x04000A0E
    IL_0629: ldloc.s 26
    IL_062B: ldloc.s 27
    IL_062C: ldelem.i
    IL_062D: conv.r8
    IL_062E: IL_8F
    IL_062F: ldarg.0
    IL_0630: nop
    IL_0631: stloc.0
    IL_0633: stloc.s 28
    IL_0634: ldarg.0
    IL_0639: ldfld 0x04000A0F
    IL_063B: ldloc.s 26
    IL_063D: ldloc.s 27
    IL_063E: ldelem.i
    IL_063F: conv.r8
    IL_0640: IL_8F
    IL_0641: ldarg.0
    IL_0642: nop
    IL_0643: stloc.0
    IL_0645: stloc.s 29
    IL_0646: ldloc.0
    IL_0648: ldloc.s 24
    IL_0649: conv.r8
    IL_064A: conv.i2
    IL_064B: ldarg.0
    IL_064C: nop
    IL_064D: stloc.0
    IL_064E: conv.u4
    IL_0650: bgt.s IL_0651
    IL_0651: nop
    IL_0652: IL_01
    IL_0653: conv.r8
    IL_0654: IL_A9
    IL_0655: nop
    IL_0656: nop
    IL_0657: stloc.0
    IL_0659: ldloc.s 27
    IL_065A: conv.r8
    IL_065F: ldobj 0x280A0002
    IL_0660: neg
    IL_0661: ldarg.3
    IL_0662: nop
    IL_0663: ldloc.0
    IL_0664: conv.u8
    IL_0665: ldc.i4.5
    IL_0666: nop
    IL_0667: nop
    IL_0668: ldc.i4.5
    IL_066A: stloc.s 30
    IL_066C: ldloc.s 26
    IL_066E: ldloc.s 27
    IL_066F: ldarg.0
    IL_0674: ldfld 0x04000A0D
    IL_0675: ldloc.0
    IL_0677: ldloc.s 24
    IL_0678: conv.r8
    IL_0679: conv.i2
    IL_067A: ldarg.0
    IL_067B: nop
    IL_067C: stloc.0
    IL_067D: conv.r8
    IL_067E: stloc.0
    IL_067F: nop
    IL_0680: nop
    IL_0681: stloc.0
    IL_0682: conv.r8
    IL_0683: ldind.ref
    IL_0684: IL_01
    IL_0685: nop
    IL_0686: stloc.0
    IL_0687: conv.r8
    IL_0688: conv.r8
    IL_0689: ldarg.0
    IL_068A: nop
    IL_068B: stloc.0
    IL_068D: ldloc.s 27
    IL_068E: ldelem.i
    IL_068F: conv.r8
    IL_0690: throw
    IL_0691: ldarg.0
    IL_0692: nop
    IL_0693: stloc.0
    IL_0694: conv.r8
    IL_0695: IL_89
    IL_0696: ldarg.0
    IL_0697: nop
    IL_0698: stloc.0
    IL_069D: stelem 0x20131E11
    IL_069E: ldc.i4.0
    IL_06A0: stloc.s 33
    IL_06A5: br IL_0759
    IL_06A7: ldloc.s 32
    IL_06A9: ldloc.s 33
    IL_06AA: IL_94
    IL_06AC: stloc.s 31
    IL_06AD: ldloc.1
    IL_06AF: ldloc.s 31
    IL_06B0: IL_8F
    IL_06B1: ldnull
    IL_06B2: nop
    IL_06B3: nop
    IL_06B4: IL_01
    IL_06B5: ldloc.1
    IL_06B7: ldloc.s 31
    IL_06B8: IL_8F
    IL_06B9: ldnull
    IL_06BA: nop
    IL_06BB: nop
    IL_06BC: IL_01
    IL_06C1: ldfld 0x0A000059
    IL_06C3: ldloca.s 28
    IL_06C8: call 0x0A000291
    IL_06C9: IL_5A
    IL_06CB: ldloca.s 28
    IL_06D0: call 0x0A000292
    IL_06D1: IL_58
    IL_06D2: ldloc.1
    IL_06D4: ldloc.s 31
    IL_06D5: IL_8F
    IL_06D6: ldnull
    IL_06D7: nop
    IL_06D8: nop
    IL_06D9: IL_01
    IL_06DE: ldfld 0x0A00005A
    IL_06E0: ldloca.s 28
    IL_06E5: call 0x0A000293
    IL_06E6: IL_5A
    IL_06E8: ldloca.s 28
    IL_06ED: call 0x0A000294
    IL_06EE: IL_58
    IL_06F3: newobj 0x0A000038
    IL_06F4: IL_81
    IL_06F5: ldnull
    IL_06F6: nop
    IL_06F7: nop
    IL_06F8: IL_01
    IL_06F9: ldloc.2
    IL_06FE: brfalse IL_0753
    IL_06FF: ldloc.2
    IL_0700: len
    IL_0701: not
    IL_0706: brfalse IL_0753
    IL_0707: ldloc.2
    IL_0709: ldloc.s 31
    IL_070A: IL_8F
    IL_070B: ldnull
    IL_070C: nop
    IL_070D: nop
    IL_070E: IL_01
    IL_070F: ldloc.2
    IL_0711: ldloc.s 31
    IL_0712: IL_8F
    IL_0713: ldnull
    IL_0714: nop
    IL_0715: nop
    IL_0716: IL_01
    IL_071B: ldfld 0x0A000059
    IL_071D: ldloca.s 29
    IL_0722: call 0x0A000291
    IL_0723: IL_5A
    IL_0725: ldloca.s 29
    IL_072A: call 0x0A000292
    IL_072B: IL_58
    IL_072C: ldloc.2
    IL_072E: ldloc.s 31
    IL_072F: IL_8F
    IL_0730: ldnull
    IL_0731: nop
    IL_0732: nop
    IL_0733: IL_01
    IL_0738: ldfld 0x0A00005A
    IL_073A: ldloca.s 29
    IL_073F: call 0x0A000293
    IL_0740: IL_5A
    IL_0742: ldloca.s 29
    IL_0747: call 0x0A000294
    IL_0748: IL_58
    IL_074D: newobj 0x0A000038
    IL_074E: IL_81
    IL_074F: ldnull
    IL_0750: nop
    IL_0751: nop
    IL_0752: IL_01
    IL_0754: ldloc.s 33
    IL_0755: ldc.i4.1
    IL_0756: IL_58
    IL_0758: stloc.s 33
    IL_075A: ldloc.s 33
    IL_075C: ldloc.s 32
    IL_075D: len
    IL_075E: not
    IL_075F: IL_3F
    IL_0760: IL_42
    IL_0761: IL_FF
    IL_0762: IL_FF
    IL_0763: IL_FF
    IL_0765: ldloc.s 27
    IL_0766: ldc.i4.1
    IL_0767: IL_58
    IL_0769: stloc.s 27
    IL_076B: ldloc.s 27
    IL_076D: ldloc.s 25
    IL_076E: IL_3F
    IL_076F: ldelem.i
    IL_0771: 0xFE FF
    IL_0772: IL_FF
    IL_0773: ldloc.0
    IL_0775: ldloc.s 24
    IL_0776: conv.r8
    IL_0777: conv.i2
    IL_0778: ldarg.0
    IL_0779: nop
    IL_077A: stloc.0
    IL_077B: conv.r8
    IL_077C: stloc.0
    IL_077D: nop
    IL_077E: nop
    IL_077F: stloc.0
    IL_0780: conv.r8
    IL_0781: ldind.ref
    IL_0782: IL_01
    IL_0783: nop
    IL_0784: stloc.0
    IL_0786: ldloc.s 26
    IL_0787: conv.r8
    IL_0788: IL_95
    IL_0789: ldarg.0
    IL_078A: nop
    IL_078B: stloc.0
    IL_078C: ldloc.0
    IL_078E: ldloc.s 24
    IL_078F: conv.r8
    IL_0790: conv.i2
    IL_0791: ldarg.0
    IL_0792: nop
    IL_0793: stloc.0
    IL_0794: conv.u4
    IL_0796: bgt.s IL_0797
    IL_0797: nop
    IL_0798: IL_01
    IL_0799: conv.r8
    IL_079A: IL_A9
    IL_079B: nop
    IL_079C: nop
    IL_079D: stloc.0
    IL_079E: ldloc.1
    IL_079F: conv.r8
    IL_07A0: IL_AC
    IL_07A1: nop
    IL_07A2: nop
    IL_07A3: stloc.0
    IL_07A4: ldloc.2
    IL_07A9: brfalse IL_07CA
    IL_07AA: ldloc.2
    IL_07AB: len
    IL_07AC: not
    IL_07B1: brfalse IL_07CA
    IL_07B2: ldloc.0
    IL_07B4: ldloc.s 24
    IL_07B5: conv.r8
    IL_07B6: conv.i2
    IL_07B7: ldarg.0
    IL_07B8: nop
    IL_07B9: stloc.0
    IL_07BA: conv.u4
    IL_07BC: bgt.s IL_07BD
    IL_07BD: nop
    IL_07BE: IL_01
    IL_07BF: conv.r8
    IL_07C0: IL_A9
    IL_07C1: nop
    IL_07C2: nop
    IL_07C3: stloc.0
    IL_07C4: ldloc.2
    IL_07C5: conv.r8
    IL_07C6: conv.r4
    IL_07C7: ldarg.0
    IL_07C8: nop
    IL_07C9: stloc.0
    IL_07CB: ldloc.s 24
    IL_07CC: ldc.i4.1
    IL_07CD: IL_58
    IL_07CF: stloc.s 24
    IL_07D1: ldloc.s 24
    IL_07D2: ldloc.0
    IL_07D3: conv.r8
    IL_07D8: stsfld 0x3F0A0002
    IL_07D9: IL_C6
    IL_07DA: IL_FD
    IL_07DB: IL_FF
    IL_07DC: IL_FF
    IL_07DD: ret
    }

    public static void DeleteDuplicates() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_96
    IL_0003: ldarg.0
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldc.i4.1
    IL_000B: beq IL_0017
    IL_0010: ldstr 0x70022FFB
    IL_0015: newobj 0x0A000297
    IL_0016: throw
    IL_0017: ldarg.0
    IL_0018: conv.r8
    IL_0019: IL_98
    IL_001A: ldarg.0
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldc.i4.2
    IL_001E: IL_5A
    IL_0023: newobj 0x0A000299
    IL_0024: stloc.0
    IL_0029: newobj 0x0A00029A
    IL_002A: stloc.1
    IL_002B: ldarg.0
    IL_002C: conv.r8
    IL_002D: ldelem.i1
    IL_002E: ldarg.0
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: stloc.3
    IL_0036: br IL_005A
    IL_0037: ldloc.3
    IL_0038: conv.r8
    IL_0039: IL_98
    IL_003A: IL_01
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: stloc.2
    IL_003E: ldloc.0
    IL_003F: ldloc.2
    IL_0040: conv.r8
    IL_0041: ldelem.i2
    IL_0042: ldarg.0
    IL_0043: nop
    IL_0044: stloc.0
    IL_0049: brtrue IL_005A
    IL_004A: ldloc.1
    IL_004B: ldloc.2
    IL_004C: conv.r8
    IL_004D: ldelem.i4
    IL_004E: ldarg.0
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: pop
    IL_0052: ldloc.0
    IL_0053: ldloc.2
    IL_0054: ldnull
    IL_0055: conv.r8
    IL_0056: ldelem.i8
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldloc.3
    IL_005B: conv.r8
    IL_005C: IL_99
    IL_005D: IL_01
    IL_005E: nop
    IL_005F: stloc.0
    IL_0064: brtrue IL_0037
    IL_0065: IL_DD
    IL_0066: ldc.i4.m1
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: ldloc.3
    IL_006B: conv.u8
    IL_006D: brfalse.s IL_006E
    IL_006E: nop
    IL_006F: IL_01
    IL_0071: stloc.s 4
    IL_0073: ldloc.s 4
    IL_0075: brtrue.s IL_0077
    IL_0076: IL_DC
    IL_0078: ldloc.s 4
    IL_0079: conv.r8
    IL_007A: ldelem.ref
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: IL_DC
    IL_007F: ldloc.1
    IL_0080: ldarg.0
    IL_0081: conv.r8
    IL_0082: ldelem.r4
    IL_0083: ldarg.0
    IL_0084: nop
    IL_0085: stloc.0
    IL_0086: conv.r8
    IL_0087: ldelem.r8
    IL_0088: ldarg.0
    IL_0089: nop
    IL_008A: stloc.0
    IL_008B: conv.r8
    IL_008C: ldelem.ref
    IL_008D: ldarg.0
    IL_008E: nop
    IL_008F: stloc.0
    IL_0090: ret
    }

    }}
