// Namespace: 
// Type: Ani_meshUV

    public class Ani_meshUV {{

    private object thismesh;
    private object tempUV;
    private object uvAnimationTileX;
    private object uvAnimationTileY;
    private object framesPerSecond;
    private object index;
    private object oldindex;
    private object impact;
    private object starttime;
    private object length;
    private object loop;
    private object dead;
    private object attack;
    private object damaged;
    private object visible;
    private object loopattack;
    private object size;
    private object offset;
    private object uIndex;
    private object vIndex;
    private object startframe;
    private object mytransform;
    private object myrenderer;
    private object mymaterial;
    private object mycollider;

    public Ani_meshUV() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: newarr 0x01000014
    IL_000B: stfld 0x0400011F
    IL_000C: ldarg.0
    IL_000D: ldc.i4.5
    IL_0012: stfld 0x04000120
    IL_0013: ldarg.0
    IL_0014: ldc.i4.5
    IL_0019: stfld 0x04000121
    IL_001A: ldarg.0
    IL_001C: ldc.i4.s 20
    IL_0021: stfld 0x04000122
    IL_0022: ldarg.0
    IL_0023: ldc.i4.m1
    IL_0028: stfld 0x04000124
    IL_0029: ldarg.0
    IL_002B: ldc.i4.s 18
    IL_0030: stfld 0x04000125
    IL_0031: ldarg.0
    IL_0033: ldc.i4.s 14
    IL_0038: stfld 0x04000127
    IL_0039: ldarg.0
    IL_003A: ldc.i4.1
    IL_003F: stfld 0x04000128
    IL_0040: ldarg.0
    IL_0045: call 0x0A000001
    IL_0046: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000016
    IL_0007: conv.r8
    IL_0008: IL_A9
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x0400011E
    IL_0011: ldarg.0
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_001B: stfld 0x04000126
    IL_001C: ldarg.0
    IL_001D: ldarg.0
    IL_0022: call 0x0A000002
    IL_0027: stfld 0x04000133
    IL_0028: ldarg.0
    IL_0029: ldarg.0
    IL_002E: call 0x0A000003
    IL_0033: stfld 0x04000136
    IL_0034: ldarg.0
    IL_0035: ldarg.0
    IL_003A: call 0x0A00000D
    IL_003F: stfld 0x04000134
    IL_0040: ldarg.0
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0048: stsfld 0x207B023F
    IL_0049: IL_01
    IL_004A: nop
    IL_004B: ldarg.2
    IL_004C: conv.i2
    IL_004D: add
    IL_004E: IL_22
    IL_004F: nop
    IL_0050: nop
    IL_0055: stsfld 0x217B023F
    IL_0056: IL_01
    IL_0057: nop
    IL_0058: ldarg.2
    IL_0059: conv.i2
    IL_005A: add
    IL_005F: newobj 0x0A000038
    IL_0064: stfld 0x0400012E
    IL_0065: ret
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400012B
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_000D: ldc.i4.0
    IL_0012: stfld 0x04000123
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: nop
    IL_001D: stfld 0x04000126
    IL_001E: ldarg.0
    IL_0020: ldc.i4.s 22
    IL_0025: stfld 0x04000132
    IL_0026: ldarg.0
    IL_0027: ldc.i4.3
    IL_002C: stfld 0x04000127
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000128
    IL_0034: ldarg.0
    IL_0035: ldc.i4.1
    IL_003A: stfld 0x0400012B
    IL_003B: ldarg.0
    IL_003C: ldc.i4.0
    IL_0041: stfld 0x0400012A
    IL_0042: ldarg.0
    IL_0044: ldc.i4.s 10
    IL_0049: stfld 0x04000122
    IL_004A: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400012B
    IL_000A: brtrue IL_0016
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400012A
    IL_0015: brfalse IL_0017
    IL_0016: ret
    IL_0017: ldarg.1
    IL_0018: conv.r8
    IL_0019: stloc.0
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: conv.r8
    IL_001E: ldc.i4.8
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: ldc.i4.8
    IL_0137: switch (68 cases)
    }

    public void ColliderOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000136
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000129
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000134
    IL_0013: conv.r8
    IL_0014: conv.u4
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x0400012C
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400012A
    IL_0027: brtrue IL_00C1
    IL_0028: ldarg.0
    IL_002D: ldfld 0x0400012B
    IL_0032: brtrue IL_00C1
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000133
    IL_0039: conv.r8
    IL_003A: ldc.i4.2
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: stloc.0
    IL_0040: ldloca.s 0
    IL_0045: ldfld 0x0A00005C
    IL_0046: IL_22
    IL_0047: shr
    IL_0048: shr
    IL_0049: ldc.i4.0
    IL_004A: IL_41
    IL_004B: IL_41
    IL_004C: IL_34
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000133
    IL_0056: dup
    IL_0057: conv.r8
    IL_0058: ldc.i4.2
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_0060: call 0x0A000042
    IL_0065: call 0x0A000024
    IL_006A: call 0x0A000008
    IL_006B: IL_22
    IL_006C: IL_CD
    IL_006D: IL_CC
    IL_006E: IL_4C
    IL_006F: IL_3E
    IL_0074: call 0x0A000008
    IL_0079: call 0x0A000029
    IL_007A: conv.r8
    IL_007B: ldloc.3
    IL_007C: nop
    IL_007D: nop
    IL_007E: stloc.0
    IL_0083: br IL_00B5
    IL_0084: ldarg.0
    IL_0089: ldfld 0x0400012D
    IL_008E: brtrue IL_00B5
    IL_008F: ldarg.0
    IL_0091: ldc.i4.s 14
    IL_0096: stfld 0x04000132
    IL_0097: ldarg.0
    IL_0099: ldc.i4.s 9
    IL_009E: stfld 0x04000127
    IL_009F: ldarg.0
    IL_00A0: ldc.i4.0
    IL_00A5: stfld 0x04000128
    IL_00A6: ldarg.0
    IL_00A7: ldc.i4.1
    IL_00AC: stfld 0x0400012A
    IL_00AD: ldarg.0
    IL_00AF: ldc.i4.s 12
    IL_00B4: stfld 0x04000122
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x0400012C
    IL_00BF: brtrue IL_00C1
    IL_00C0: ret
    IL_00C1: ldarg.0
    IL_00C2: dup
    IL_00C7: ldfld 0x04000126
    IL_00CC: call 0x0A000024
    IL_00CD: IL_58
    IL_00D2: stfld 0x04000126
    IL_00D3: ldarg.0
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000126
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000122
    IL_00E0: conv.i2
    IL_00E1: IL_5A
    IL_00E2: not
    IL_00E7: stfld 0x04000123
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x04000128
    IL_00F2: brfalse IL_0112
    IL_00F3: ldarg.0
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x04000123
    IL_00FA: ldarg.0
    IL_00FF: ldfld 0x04000127
    IL_0100: mul
    IL_0101: ldarg.0
    IL_0106: ldfld 0x04000132
    IL_0107: IL_58
    IL_010C: stfld 0x04000123
    IL_0111: br IL_0125
    IL_0112: ldarg.0
    IL_0113: ldarg.0
    IL_0118: ldfld 0x04000123
    IL_0119: ldarg.0
    IL_011E: ldfld 0x04000132
    IL_011F: IL_58
    IL_0124: stfld 0x04000123
    IL_0125: ldarg.0
    IL_0126: ldarg.0
    IL_012B: ldfld 0x04000123
    IL_012C: ldarg.0
    IL_0131: ldfld 0x04000120
    IL_0132: mul
    IL_0133: conv.i2
    IL_0138: stfld 0x04000130
    IL_0139: ldarg.0
    IL_013A: ldarg.0
    IL_013F: ldfld 0x04000121
    IL_0140: ldc.i4.1
    IL_0141: IL_59
    IL_0142: ldarg.0
    IL_0147: ldfld 0x04000123
    IL_0148: ldarg.0
    IL_014D: ldfld 0x04000120
    IL_014E: add
    IL_014F: IL_59
    IL_0154: stfld 0x04000131
    IL_0155: ldarg.0
    IL_015A: ldfld 0x04000123
    IL_015B: ldarg.0
    IL_0160: ldfld 0x04000124
    IL_0165: beq IL_03BE
    IL_0166: ldarg.0
    IL_016B: ldfld 0x04000123
    IL_016C: ldarg.0
    IL_0171: ldfld 0x04000132
    IL_0172: ldarg.0
    IL_0177: ldfld 0x04000127
    IL_0178: IL_58
    IL_0179: IL_3F
    IL_017A: IL_DE
    IL_017B: nop
    IL_017C: nop
    IL_017D: nop
    IL_017E: ldarg.0
    IL_0183: ldfld 0x0400012A
    IL_0188: brfalse IL_01E9
    IL_0189: ldarg.0
    IL_018A: ldc.i4.0
    IL_018F: stfld 0x04000123
    IL_0190: ldarg.0
    IL_0191: IL_22
    IL_0192: nop
    IL_0193: nop
    IL_0194: nop
    IL_0195: nop
    IL_019A: stfld 0x04000126
    IL_019B: ldarg.0
    IL_019C: ldc.i4.0
    IL_01A1: stfld 0x04000132
    IL_01A2: ldarg.0
    IL_01A3: ldc.i4.m1
    IL_01A8: stfld 0x04000124
    IL_01A9: ldarg.0
    IL_01AB: ldc.i4.s 14
    IL_01B0: stfld 0x04000127
    IL_01B1: ldarg.0
    IL_01B2: ldc.i4.1
    IL_01B7: stfld 0x04000128
    IL_01B8: ldarg.0
    IL_01B9: ldc.i4.0
    IL_01BE: stfld 0x0400012A
    IL_01BF: ldarg.0
    IL_01C1: ldc.i4.s 20
    IL_01C6: stfld 0x04000122
    IL_01C7: ldarg.0
    IL_01CC: call 0x0A00000A
    IL_01CE: ldc.i4.s 15
    IL_01CF: conv.r8
    IL_01D0: ldc.i4.m1
    IL_01D1: nop
    IL_01D2: nop
    IL_01D3: stloc.0
    IL_01D4: ldarg.0
    IL_01D9: ldstr 0x70000AAD
    IL_01DA: IL_22
    IL_01DB: nop
    IL_01DC: nop
    IL_01DD: nop
    IL_01DE: IL_3F
    IL_01E3: call 0x0A00003F
    IL_01E8: br IL_0220
    IL_01E9: ldarg.0
    IL_01EE: ldfld 0x0400012B
    IL_01F3: brfalse IL_0220
    IL_01F4: ldarg.0
    IL_01F5: ldarg.0
    IL_01FA: ldfld 0x04000132
    IL_01FB: ldarg.0
    IL_0200: ldfld 0x04000127
    IL_0201: IL_58
    IL_0202: ldc.i4.1
    IL_0203: IL_59
    IL_0208: stfld 0x04000123
    IL_0209: ldarg.0
    IL_020A: ldc.i4.1
    IL_020F: stfld 0x04000129
    IL_0210: ldarg.0
    IL_0215: call 0x0A00000A
    IL_0216: IL_22
    IL_0217: nop
    IL_0218: nop
    IL_0219: nop
    IL_1C6BE: switch (28968 cases)
    }

    }}
