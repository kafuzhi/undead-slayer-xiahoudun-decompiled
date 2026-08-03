// Namespace: 
// Type: Cha_Control_ride_cha

    public class Cha_Control_ride_cha {{

    public object horseSpine;
    public object horse;
    public object dummy_weapon;
    public object ef_souleat;
    public object ef_damage;
    public object ef_twirl;
    public object screen_effect;
    public object spear;
    public object coin;
    private object mytransform;
    private object ef_swing;
    private object gauge_navi;
    private object isfinish;
    private object stage_num;
    private object script_swing;
    private object script_horse;
    private object script_twirl;
    private object pack;
    private object script_pack;
    private object script_cam;
    private object script_coin;
    private object myanimation;
    private object attackdelay;
    private object particledelay;
    private object falldowndelay;
    public object amount_soulstone;
    public object count_coin;
    public object count_monster;
    public object count_behit;

    public Cha_Control_ride_cha() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_000A: call 0x0A000090
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: call 0x0A000002
    IL_0016: stfld 0x04000370
    IL_0017: ldarg.0
    IL_0018: ldarg.0
    IL_001D: call 0x0A00002A
    IL_0022: stfld 0x0400037C
    IL_0023: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000035
    IL_0006: conv.r8
    IL_0008: ldloc.s 0
    IL_0009: nop
    IL_000B: br.s IL_0089
    IL_000C: throw
    IL_000D: ldarg.1
    IL_000E: nop
    IL_000F: ldarg.2
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000370
    IL_001B: ldstr 0x70000E35
    IL_001C: conv.r8
    IL_001E: brfalse.s IL_001F
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: stfld 0x04000371
    IL_0026: ldarg.0
    IL_002B: ldstr 0x700002DB
    IL_0030: call 0x0A000004
    IL_0031: conv.r8
    IL_0032: ldarg.3
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_003A: stfld 0x04000378
    IL_003B: ldarg.0
    IL_003C: ldarg.0
    IL_0041: ldfld 0x0400036F
    IL_0042: conv.r8
    IL_0043: IL_34
    IL_0044: nop
    IL_0045: nop
    IL_0047: br.s IL_00C5
    IL_004C: ldfld 0x02040003
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000371
    IL_0053: conv.r8
    IL_0054: IL_35
    IL_0055: nop
    IL_0056: nop
    IL_0058: br.s IL_00D6
    IL_0059: conv.u8
    IL_005A: ldarg.1
    IL_005B: nop
    IL_005C: ldarg.2
    IL_005D: ldarg.0
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000368
    IL_0064: conv.r8
    IL_0065: IL_36
    IL_0066: nop
    IL_0067: nop
    IL_0069: br.s IL_00E7
    IL_006A: conv.r.un
    IL_006B: ldarg.1
    IL_006C: nop
    IL_006D: ldarg.2
    IL_006E: ldarg.0
    IL_006F: ldarg.0
    IL_0074: ldfld 0x0400036C
    IL_0075: conv.r8
    IL_007A: call 0x7D2B0000
    IL_007B: IL_77
    IL_007C: ldarg.1
    IL_007D: nop
    IL_007E: ldarg.2
    IL_007F: ldarg.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000378
    IL_0086: conv.r8
    IL_0087: IL_37
    IL_0088: nop
    IL_0089: nop
    IL_008B: br.s IL_0109
    IL_008C: IL_79
    IL_008D: ldarg.1
    IL_008E: nop
    IL_008F: ldarg.2
    IL_0090: ldarg.0
    IL_0095: ldfld 0x0400037C
    IL_009A: ldstr 0x700012D7
    IL_009B: conv.r8
    IL_009D: bge.s IL_009E
    IL_009E: nop
    IL_009F: stloc.0
    IL_00A0: IL_22
    IL_00A2: bne.un.s IL_00D6
    IL_00A4: bne.un.s IL_00E4
    IL_00A5: conv.r8
    IL_00A7: bgt.s IL_00A8
    IL_00A8: nop
    IL_00A9: stloc.0
    IL_00AA: ldarg.0
    IL_00AF: ldfld 0x0400037C
    IL_00B4: ldstr 0x700012D7
    IL_00B5: conv.r8
    IL_00B6: IL_3C
    IL_00B7: nop
    IL_00B8: nop
    IL_00B9: stloc.0
    IL_00BA: pop
    IL_00BB: ldarg.0
    IL_00C0: ldfld 0x0400037C
    IL_00C5: ldstr 0x700012F1
    IL_00C6: conv.r8
    IL_00C8: bge.s IL_00C9
    IL_00C9: nop
    IL_00CA: stloc.0
    IL_00CB: IL_22
    IL_00CC: ldelem.i
    IL_00CD: IL_99
    IL_00CE: IL_99
    IL_00CF: IL_3E
    IL_00D0: conv.r8
    IL_00D2: bgt.s IL_00D3
    IL_00D3: nop
    IL_00D4: stloc.0
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x0400037C
    IL_00DF: ldstr 0x7000130B
    IL_00E0: conv.r8
    IL_00E2: bge.s IL_00E3
    IL_00E3: nop
    IL_00E4: stloc.0
    IL_00E5: IL_22
    IL_00E6: ldelem.i
    IL_00E7: IL_99
    IL_00E8: IL_99
    IL_00E9: IL_3E
    IL_00EA: conv.r8
    IL_00EC: bgt.s IL_00ED
    IL_00ED: nop
    IL_00EE: stloc.0
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x0400037C
    IL_00F9: ldstr 0x700012F1
    IL_00FA: conv.r8
    IL_00FC: bge.s IL_00FD
    IL_00FD: nop
    IL_00FE: stloc.0
    IL_00FF: ldc.i4.1
    IL_0100: conv.r8
    IL_0102: ble.s IL_0103
    IL_0103: nop
    IL_0104: stloc.0
    IL_0105: ldarg.0
    IL_010A: ldfld 0x0400037C
    IL_010F: ldstr 0x7000130B
    IL_0110: conv.r8
    IL_0112: bge.s IL_0113
    IL_0113: nop
    IL_0114: stloc.0
    IL_0115: ldc.i4.1
    IL_0116: conv.r8
    IL_0118: ble.s IL_0119
    IL_0119: nop
    IL_011A: stloc.0
    IL_011B: ldarg.0
    IL_011C: ldarg.0
    IL_0121: ldfld 0x04000379
    IL_0126: call 0x0A0000FA
    IL_0127: IL_22
    IL_0128: IL_8F
    IL_0129: IL_C2
    IL_012A: IL_F5
    IL_012B: IL_3D
    IL_0130: call 0x0A000083
    IL_0131: IL_22
    IL_0132: nop
    IL_0133: nop
    IL_0134: nop
    IL_0135: nop
    IL_0136: IL_22
    IL_013B: ldfld 0x22BFAE14
    IL_013C: ldelem.i
    IL_013D: IL_99
    IL_0142: brfalse IL_2383
    IL_0143: IL_C0
    IL_0144: IL_3F
    IL_0149: newobj 0x0A000076
    IL_014A: IL_22
    IL_014B: nop
    IL_014C: nop
    IL_014D: IL_50
    IL_014E: IL_3F
    IL_014F: IL_22
    IL_0150: nop
    IL_0151: nop
    IL_0156: cpobj 0x0038733F
    IL_0157: nop
    IL_0158: stloc.0
    IL_0159: IL_22
    IL_015A: nop
    IL_015B: nop
    IL_015C: rem
    IL_015D: IL_3F
    IL_015E: IL_22
    IL_015F: nop
    IL_0160: nop
    IL_0165: stsfld 0x0038733F
    IL_0166: nop
    IL_0167: stloc.0
    IL_016C: ldstr 0x70000CFD
    IL_016D: ldnull
    IL_016E: IL_22
    IL_016F: nop
    IL_0170: nop
    IL_0171: nop
    IL_0172: nop
    IL_0173: ldc.i4.0
    IL_0174: conv.r8
    IL_0175: IL_95
    IL_0176: ldarg.1
    IL_0177: nop
    IL_0178: ldloc.0
    IL_017D: stfld 0x04000372
    IL_017E: ldarg.0
    IL_0183: ldfld 0x04000379
    IL_0184: IL_22
    IL_0185: IL_CD
    IL_0186: IL_CC
    IL_0187: IL_CC
    IL_0188: IL_3F
    IL_0189: IL_22
    IL_018A: IL_CD
    IL_018B: IL_CC
    IL_018C: IL_CC
    IL_018D: IL_3D
    IL_0192: newobj 0x0A000038
    IL_0193: IL_22
    IL_0194: nop
    IL_0195: nop
    IL_0196: nop
    IL_0197: nop
    IL_0198: IL_22
    IL_0199: stloc.0
    IL_019A: IL_D7
    IL_019B: IL_23
    IL_019C: IL_BF
    IL_019D: IL_22
    IL_019E: ldelem.i
    IL_019F: IL_99
    IL_01A4: brfalse IL_666623E5
    IL_01A5: IL_E6
    IL_01A6: IL_3F
    IL_01AB: newobj 0x0A000076
    IL_01AC: IL_22
    IL_01AD: nop
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: IL_22
    IL_01B2: nop
    IL_01B3: nop
    IL_01B4: IL_C0
    IL_01B5: IL_3E
    IL_01BA: newobj 0x0A000038
    IL_01BB: IL_22
    IL_01BC: nop
    IL_01BD: nop
    IL_01C2: stsfld 0x0000223F
    IL_01C3: IL_E0
    IL_01C4: IL_3E
    IL_01C9: newobj 0x0A000038
    IL_01CE: ldstr 0x70000D13
    IL_01CF: ldnull
    IL_01D0: IL_22
    IL_01D1: nop
    IL_01D2: nop
    IL_01D3: nop
    IL_01D4: nop
    IL_01D5: ldc.i4.0
    IL_01D6: conv.r8
    IL_01D7: IL_95
    IL_01D8: ldarg.1
    IL_01D9: nop
    IL_01DA: ldloc.0
    IL_01DB: pop
    IL_01DC: ldarg.0
    IL_01E1: ldfld 0x04000379
    IL_01E6: call 0x0A0000FA
    IL_01E7: IL_22
    IL_01E8: ldelem.i
    IL_01E9: IL_99
    IL_01EA: ldc.i4.3
    IL_01EB: IL_3E
    IL_01F0: call 0x0A000083
    IL_01F1: IL_22
    IL_01F2: nop
    IL_01F3: nop
    IL_01F4: nop
    IL_01F5: nop
    IL_01F6: IL_22
    IL_01F7: ldnull
    IL_01F8: IL_AE
    IL_01F9: ldloc.1
    IL_01FA: IL_3F
    IL_01FB: IL_22
    IL_01FC: ldelem.i
    IL_01FD: IL_99
    IL_0202: brfalse IL_66662443
    IL_0203: ldloc.0
    IL_1DBD4: switch (30323 cases)
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000373
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_000E: ldc.i4.s -3
    IL_0013: call 0x060001A4
    IL_0014: ret
    }

    public void Attack() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400037D
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_42
    IL_000C: IL_BF
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000370
    IL_0016: conv.r8
    IL_0017: ldc.i4.2
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: stloc.0
    IL_001D: ldloca.s 0
    IL_0022: ldfld 0x0A000023
    IL_0023: IL_22
    IL_0024: stloc.0
    IL_0025: IL_D7
    IL_0026: IL_23
    IL_0027: IL_3C
    IL_0028: IL_41
    IL_002D: stelem 0x03000000
    IL_0032: brfalse IL_007E
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400037C
    IL_003D: ldstr 0x700012F1
    IL_003E: conv.r8
    IL_003F: IL_3C
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: pop
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000371
    IL_004A: IL_22
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldelem.r8
    IL_004E: IL_41
    IL_004F: IL_22
    IL_0050: nop
    IL_0051: nop
    IL_0056: cpobj 0x00002242
    IL_0057: ret
    IL_0058: IL_43
    IL_005D: call 0x0A000060
    IL_005E: conv.r8
    IL_0060: ldarga.s 1
    IL_0061: nop
    IL_0062: stloc.0
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000375
    IL_0069: IL_22
    IL_006A: stloc.0
    IL_006B: IL_D7
    IL_006C: IL_23
    IL_006D: IL_3E
    IL_006E: ldc.i4.2
    IL_006F: ldc.i4.2
    IL_0071: ldc.i4.s 18
    IL_0072: ldc.i4.1
    IL_0073: ldc.i4.0
    IL_0074: conv.r8
    IL_0075: IL_C8
    IL_0076: ldarg.0
    IL_0077: nop
    IL_0078: ldloc.0
    IL_007D: br IL_00C4
    IL_007E: ldarg.0
    IL_0083: ldfld 0x0400037C
    IL_0088: ldstr 0x7000130B
    IL_0089: conv.r8
    IL_008A: IL_3C
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: pop
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000371
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: ldelem.r8
    IL_0099: IL_41
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_00A1: cpobj 0x000022C2
    IL_00A6: ldc.i4 6301761
    IL_00A7: nop
    IL_00A8: stloc.0
    IL_00A9: conv.r8
    IL_00AB: ldarga.s 1
    IL_00AC: nop
    IL_00AD: stloc.0
    IL_00AE: ldarg.0
    IL_00B3: ldfld 0x04000375
    IL_00B4: IL_22
    IL_00B5: stloc.0
    IL_00B6: IL_D7
    IL_00B7: IL_23
    IL_00B8: IL_3E
    IL_00B9: ldc.i4.2
    IL_00BA: ldc.i4.2
    IL_00BC: ldc.i4.s 18
    IL_00BD: ldc.i4.1
    IL_00BE: ldc.i4.0
    IL_00BF: conv.r8
    IL_00C0: IL_C8
    IL_00C1: ldarg.0
    IL_00C2: nop
    IL_00C3: ldloc.0
    IL_00C4: ldarg.0
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00CC: stsfld 0x037D7D3F
    IL_00CD: nop
    IL_00CE: ldarg.2
    IL_00CF: ret
    }

    public void GetSoulStone() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.0
    IL_0007: ldfld 0x04000380
    IL_0008: ldarg.1
    IL_0009: IL_58
    IL_000E: call 0x0A000080
    IL_0013: stfld 0x04000380
    IL_0014: ldarg.1
    IL_0015: ldc.i4.1
    IL_016E: switch (85 cases)
    }

    public void FallDown() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000373
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400037F
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: IL_42
    IL_0018: ldc.i4.8
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000376
    IL_0022: conv.r8
    IL_0023: IL_B7
    IL_0024: IL_01
    IL_0025: nop
    IL_0026: ldloc.0
    IL_0027: ldarg.0
    IL_0029: ldc.i4.s -3
    IL_002E: call 0x060001A4
    IL_002F: ldarg.0
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0037: stsfld 0x037F7D3F
    IL_0038: nop
    IL_0039: ldarg.2
    IL_003A: ret
    }

    public void Finish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000373
    IL_0007: ret
    }

    public void RisePocket() {
    IL_0004: ldstr 0x70001675
    IL_0009: call 0x0A000004
    IL_000A: conv.r8
    IL_000F: br IL_6F2B0010
    IL_0010: IL_C8
    IL_0011: ldarg.1
    IL_0012: nop
    IL_0013: ldloc.0
    IL_0014: ret
    }

    public void CrynStop() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000377
    IL_0006: conv.r8
    IL_0007: IL_D8
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: ldloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400036E
    IL_0011: conv.r8
    IL_0012: stloc.0
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_001A: call 0x0A000050
    IL_001B: ldarg.0
    IL_0020: ldfld 0x0400037C
    IL_0021: conv.r8
    IL_0024: ldloc 0
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400037C
    IL_0030: ldstr 0x70001681
    IL_0031: conv.r8
    IL_0033: bge.s IL_0034
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_22
    IL_0037: stloc.0
    IL_0038: IL_D7
    IL_0039: IL_23
    IL_003A: IL_3E
    IL_003B: conv.r8
    IL_003D: bgt.s IL_003E
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400037C
    IL_004A: ldstr 0x70001681
    IL_004B: conv.r8
    IL_004D: bge.s IL_004E
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: ldc.i4.1
    IL_0051: conv.r8
    IL_0056: ldstr 0x020A0000
    IL_005B: ldfld 0x0400037C
    IL_0060: ldstr 0x70001681
    IL_0061: conv.r8
    IL_0062: IL_3C
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: pop
    IL_0067: ldarg.0
    IL_006C: ldfld 0x0400037C
    IL_0071: ldstr 0x7000168D
    IL_0072: conv.r8
    IL_0077: newobj 0x0A0A0000
    IL_0078: ldloc.0
    IL_0079: IL_22
    IL_007A: ldelem.i
    IL_007B: IL_99
    IL_007C: ldc.i4.3
    IL_007D: IL_3E
    IL_007E: conv.r8
    IL_0080: bgt.s IL_0081
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x0400037C
    IL_008D: ldstr 0x700016A7
    IL_008E: conv.r8
    IL_0093: newobj 0x0A0A0000
    IL_0094: ldloc.0
    IL_0095: IL_22
    IL_0096: IL_CD
    IL_0097: IL_CC
    IL_0098: IL_4C
    IL_0099: IL_3E
    IL_009A: conv.r8
    IL_009C: bgt.s IL_009D
    IL_009D: nop
    IL_009E: stloc.0
    IL_009F: ldarg.0
    IL_00A4: ldfld 0x0400037C
    IL_00A9: ldstr 0x700016B9
    IL_00AA: conv.r8
    IL_00AF: newobj 0x0A0A0000
    IL_00B0: ldloc.0
    IL_00B1: IL_22
    IL_00B2: IL_CD
    IL_00B3: IL_CC
    IL_00B4: IL_CC
    IL_00B5: IL_3D
    IL_00B6: conv.r8
    IL_00B8: bgt.s IL_00B9
    IL_00B9: nop
    IL_00BA: stloc.0
    IL_00BB: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000373
    IL_000A: brtrue IL_003A
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000372
    IL_0011: dup
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000062
    IL_0020: call 0x0A000024
    IL_0025: call 0x0A000008
    IL_0026: IL_22
    IL_0027: ldarg.0
    IL_0029: br.s IL_0031
    IL_002A: IL_3D
    IL_002F: call 0x0A000008
    IL_0034: call 0x0A000029
    IL_0035: conv.r8
    IL_0036: ldloc.3
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000370
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000367
    IL_0046: conv.r8
    IL_0047: ldc.i4.2
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004F: call 0x0A000007
    IL_0050: IL_22
    IL_0055: ldfld 0x28BDAE14
    IL_0056: ldloc.2
    IL_0057: nop
    IL_0058: nop
    IL_0059: stloc.0
    IL_005E: call 0x0A000029
    IL_005F: conv.r8
    IL_0060: ldloc.3
    IL_0061: nop
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000370
    IL_006A: ldarg.0
    IL_006F: ldfld 0x04000368
    IL_0070: conv.r8
    IL_0071: pop
    IL_0072: nop
    IL_0073: nop
    IL_0074: stloc.0
    IL_0075: conv.r8
    IL_007A: call 0x020A0000
    IL_007F: ldfld 0x0400037F
    IL_0080: IL_22
    IL_0081: nop
    IL_0082: nop
    IL_0083: nop
    IL_0084: nop
    IL_0085: IL_43
    IL_0086: ldc.i4.1
    IL_0087: nop
    IL_0088: nop
    IL_0089: nop
    IL_008A: ldarg.0
    IL_008B: dup
    IL_0090: ldfld 0x0400037F
    IL_0095: call 0x0A000024
    IL_0096: IL_59
    IL_009B: stfld 0x0400037F
    IL_00A0: br IL_00C3
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x0400037D
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: IL_43
    IL_00AE: ldloca.s 0
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: ldarg.0
    IL_00B2: dup
    IL_00B7: ldfld 0x0400037D
    IL_00BC: call 0x0A000024
    IL_00BD: IL_59
    IL_00C2: stfld 0x0400037D
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x0400037E
    IL_00C9: IL_22
    IL_00CA: nop
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: IL_43
    IL_00CF: IL_4F
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: ldarg.0
    IL_00D4: dup
    IL_00D9: ldfld 0x0400037E
    IL_00DE: call 0x0A000024
    IL_00DF: IL_59
    IL_00E4: stfld 0x0400037E
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x0400037E
    IL_00EB: IL_22
    IL_00EC: nop
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: IL_41
    IL_00F2: brtrue.s IL_00F3
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x0400036A
    IL_00FB: conv.r8
    IL_00FC: IL_B0
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: stloc.0
    IL_0100: ldc.i4.0
    IL_0101: conv.r8
    IL_0102: IL_B6
    IL_0103: nop
    IL_0104: nop
    IL_0105: stloc.0
    IL_0106: ldarg.0
    IL_010B: ldfld 0x0400036B
    IL_010C: conv.r8
    IL_010D: IL_B0
    IL_010E: nop
    IL_010F: nop
    IL_0110: stloc.0
    IL_0111: ldc.i4.0
    IL_0112: conv.r8
    IL_0113: IL_B6
    IL_0114: nop
    IL_0115: nop
    IL_0116: stloc.0
    IL_0117: ldarg.0
    IL_0118: IL_22
    IL_0119: nop
    IL_011A: nop
    IL_011B: nop
    IL_011C: nop
    IL_0121: stfld 0x0400037E
    IL_0122: ret
    }

    }}
