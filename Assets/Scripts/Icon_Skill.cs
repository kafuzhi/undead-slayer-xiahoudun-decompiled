// Namespace: 
// Type: Icon_Skill

    public class Icon_Skill {{

    private static object MAXSKILL;
    private static object MAXSLOT;
    private static object MAXPET;
    public object ef_activeskill;
    public object pack;
    public object icon_pet_folder;
    private object mytransform;
    private object icon_pause;
    private object icon_rotate;
    private object script_pack;
    private object soulamount;
    private object _duration;
    private object cur_skill_grade;
    private object pet_activeskill;
    private object pet_passiveskill;
    private object pet_hunger;
    private object item_slot;
    private object skill_slot;
    private object skillcount;
    private object skill_colltime;
    private object skill_soulcost;
    public object isskillready;
    public object ispetready;
    private object skill_use;
    private object pet_skill_use;
    private object clone_skillicon;
    private object clone_peticon;
    private object clone_itemicon;
    private object clone_fillbox;
    private object icon_shortsp;
    private object skill_iconpos;
    private object item_iconpos;
    private object movepos;
    private object pet_iconpos;
    private object duration_delay;
    private object timereduce;
    private object generalskill_exist;
    private object infinitymode;
    private object currentpetskill;
    private object page_skillset;
    private object max_skillset;
    private object lastlist_skill;
    private object startlist_skill;
    public object move_icon_skill;
    public object move_icon_pet;
    private object current_costume;
    private object script_cha;
    public object num_skill;
    private object generalSkillcount;

    public Icon_Skill() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100002F
    IL_000B: stfld 0x040006EE
    IL_000C: ldarg.0
    IL_000D: ldc.i4.5
    IL_0012: newarr 0x0100000B
    IL_0017: stfld 0x040006EF
    IL_0018: ldarg.0
    IL_0019: ldc.i4.2
    IL_001E: newarr 0x0100000B
    IL_0023: stfld 0x040006F0
    IL_0024: ldarg.0
    IL_0025: ldc.i4.2
    IL_002A: newarr 0x0100000B
    IL_002F: stfld 0x040006F1
    IL_0030: ldarg.0
    IL_0031: ldc.i4.2
    IL_0036: newarr 0x0100000B
    IL_003B: stfld 0x040006F2
    IL_003C: ldarg.0
    IL_003D: ldc.i4.5
    IL_0042: newarr 0x0100000B
    IL_0047: stfld 0x040006F3
    IL_0048: ldarg.0
    IL_004A: ldc.i4.s 20
    IL_004F: newarr 0x0100000B
    IL_0054: stfld 0x040006F4
    IL_0055: ldarg.0
    IL_0057: ldc.i4.s 20
    IL_005C: newarr 0x0100000B
    IL_0061: stfld 0x040006F5
    IL_0062: ldarg.0
    IL_0064: ldc.i4.s 20
    IL_0069: newarr 0x0100002F
    IL_006E: stfld 0x040006F6
    IL_006F: ldarg.0
    IL_0071: ldc.i4.s 21
    IL_0076: newarr 0x01000010
    IL_007B: stfld 0x040006F7
    IL_007C: ldarg.0
    IL_007E: ldc.i4.s 21
    IL_0083: newarr 0x0100000B
    IL_0084: dup
    IL_0089: ldtoken 0x040010B7
    IL_008E: call 0x0A00018C
    IL_0093: stfld 0x040006F8
    IL_0094: ldarg.0
    IL_0095: ldc.i4.2
    IL_009A: newarr 0x01000013
    IL_009F: stfld 0x040006F9
    IL_00A0: ldarg.0
    IL_00A2: ldc.i4.s 20
    IL_00A7: newarr 0x0100000B
    IL_00AC: stfld 0x040006FA
    IL_00AD: ldarg.0
    IL_00AE: ldc.i4.2
    IL_00B3: newarr 0x0100000B
    IL_00B8: stfld 0x040006FB
    IL_00B9: ldarg.0
    IL_00BB: ldc.i4.s 20
    IL_00C0: newarr 0x01000003
    IL_00C5: stfld 0x040006FC
    IL_00C6: ldarg.0
    IL_00C7: ldc.i4.2
    IL_00CC: newarr 0x01000003
    IL_00D1: stfld 0x040006FD
    IL_00D2: ldarg.0
    IL_00D3: ldc.i4.3
    IL_00D8: newarr 0x01000003
    IL_00DD: stfld 0x040006FE
    IL_00DE: ldarg.0
    IL_00E0: ldc.i4.s 21
    IL_00E5: newarr 0x01000003
    IL_00EA: stfld 0x040006FF
    IL_00EB: ldarg.0
    IL_00EC: IL_22
    IL_00EE: bne.un.s IL_0122
    IL_00EF: conv.ovf.i4.un
    IL_00F0: IL_3F
    IL_00F1: IL_22
    IL_00F2: shr
    IL_00F3: shr
    IL_00F4: pop
    IL_0181: switch (34 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040006E9
    IL_000C: ldarg.0
    IL_0011: ldstr 0x7000054F
    IL_0016: call 0x060003F9
    IL_001B: stfld 0x040006EF
    IL_001C: ldarg.0
    IL_0021: ldstr 0x70001EFD
    IL_0026: call 0x060003F9
    IL_002B: stfld 0x040006F0
    IL_002C: ldarg.0
    IL_0031: ldstr 0x70001F05
    IL_0036: call 0x060003F9
    IL_003B: stfld 0x040006F1
    IL_003C: ldarg.0
    IL_0041: ldstr 0x70001F0D
    IL_0046: call 0x060003F9
    IL_004B: stfld 0x040006F2
    IL_004C: ldarg.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x040006E7
    IL_0053: conv.r8
    IL_0054: IL_37
    IL_0055: nop
    IL_0056: nop
    IL_0058: br.s IL_00D6
    IL_0059: IL_EC
    IL_005A: ldloc.0
    IL_005B: nop
    IL_005C: ldarg.2
    IL_005D: ldarg.0
    IL_0062: ldstr 0x70000001
    IL_0067: call 0x0A000004
    IL_0068: conv.r8
    IL_0069: ldarg.2
    IL_006A: nop
    IL_006B: nop
    IL_006D: br.s IL_00EB
    IL_006F: ldloc.s 7
    IL_0070: nop
    IL_0071: ldarg.2
    IL_0072: ldarg.0
    IL_0077: ldstr 0x70000DD5
    IL_007C: call 0x06000220
    IL_0081: stfld 0x04000710
    IL_0082: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000063
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.0
    IL_000D: nop
    IL_000E: nop
    IL_0010: br.s IL_008C
    IL_0011: mul
    IL_0012: ldloc.3
    IL_0013: nop
    IL_0014: ldarg.2
    IL_0019: stfld 0x04000708
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000708
    IL_0024: brtrue IL_003A
    IL_0025: ldarg.0
    IL_002A: ldstr 0x70001F9B
    IL_002F: call 0x060003F9
    IL_0034: stfld 0x040006F4
    IL_0039: br IL_0047
    IL_003A: ldarg.0
    IL_003C: ldc.i4.s 20
    IL_0041: newarr 0x0100000B
    IL_0046: stfld 0x040006F4
    IL_0047: ldarg.0
    IL_004C: ldstr 0x700028DD
    IL_0051: call 0x060003F9
    IL_0056: stfld 0x040006F3
    IL_005B: ldstr 0x70000BD5
    IL_0060: call 0x0A000004
    IL_0061: conv.r8
    IL_0062: IL_4D
    IL_0063: nop
    IL_0064: nop
    IL_0066: br.s IL_0071
    IL_006B: ldstr 0x70000BD5
    IL_0070: call 0x0A000004
    IL_0071: conv.r8
    IL_0072: IL_3C
    IL_0073: nop
    IL_0074: nop
    IL_0076: br.s IL_0082
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000708
    IL_0081: brtrue IL_0422
    IL_0082: ldc.i4.0
    IL_0083: stloc.2
    IL_0088: br IL_0349
    IL_0089: ldarg.0
    IL_008E: ldfld 0x040006F4
    IL_008F: ldloc.2
    IL_0090: IL_94
    IL_0091: ldc.i4.0
    IL_0092: IL_3F
    IL_0093: IL_AE
    IL_0094: ldarg.0
    IL_0095: nop
    IL_0096: nop
    IL_0097: ldarg.0
    IL_009C: ldfld 0x040006F6
    IL_009D: ldloc.2
    IL_009E: ldloc.1
    IL_00A3: ldfld 0x04000505
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x040006F4
    IL_00AA: ldloc.2
    IL_00AB: IL_94
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x040006EF
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x040006F4
    IL_00B8: ldloc.2
    IL_00B9: IL_94
    IL_00BA: IL_94
    IL_00BF: call 0x0A000134
    IL_00C4: ldfld 0x04000504
    IL_00C5: ldelem.r8
    IL_00C6: ldarg.0
    IL_00CB: ldfld 0x04000710
    IL_00CD: ldc.i4.s 15
    IL_00D2: beq IL_0102
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x040006F7
    IL_00D9: ldloc.2
    IL_00DA: ldloc.1
    IL_00DF: ldfld 0x04000505
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x040006F4
    IL_00E6: ldloc.2
    IL_00E7: IL_94
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x040006EF
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x040006F4
    IL_00F4: ldloc.2
    IL_00F5: IL_94
    IL_00F6: IL_94
    IL_00FB: call 0x0A000134
    IL_0100: ldfld 0x04000502
    IL_0101: ldelem.i4
    IL_0103: ldloca.s 3
    IL_0104: IL_22
    IL_0105: nop
    IL_0106: nop
    IL_0107: nop
    IL_0108: IL_3E
    IL_0109: ldarg.0
    IL_010E: ldfld 0x040006F4
    IL_010F: ldloc.2
    IL_0110: IL_94
    IL_0111: ldc.i4.8
    IL_0112: mul
    IL_0113: conv.i2
    IL_0114: IL_5A
    IL_0115: IL_22
    IL_0116: nop
    IL_0117: nop
    IL_0118: nop
    IL_0119: IL_3E
    IL_011A: ldarg.0
    IL_011F: ldfld 0x040006F4
    IL_0120: ldloc.2
    IL_0121: IL_94
    IL_0122: ldc.i4.8
    IL_0123: add
    IL_0124: conv.i2
    IL_0125: IL_5A
    IL_012A: call 0x0A000038
    IL_012B: ldarg.0
    IL_0130: ldfld 0x040006FC
    IL_0131: ldloc.2
    IL_0132: ldarg.0
    IL_0137: ldfld 0x040006EC
    IL_013C: call 0x0A0000FA
    IL_013D: IL_22
    IL_013E: stloc.0
    IL_013F: IL_D7
    IL_0140: IL_23
    IL_0141: IL_3E
    IL_0146: call 0x0A000083
    IL_0147: IL_22
    IL_0148: ldelem.i
    IL_0149: IL_99
    IL_014A: ldc.i4.3
    IL_014B: IL_3E
    IL_014C: ldarg.0
    IL_0151: ldfld 0x04000701
    IL_0152: ldloc.3
    IL_0153: ldloc.3
    IL_0158: call 0x0A0000FA
    IL_0159: IL_22
    IL_015A: nop
    IL_015B: nop
    IL_015C: nop
    IL_015D: IL_3E
    IL_0162: call 0x0A000083
    IL_0167: call 0x0A0000AB
    IL_016C: ldstr 0x700028E5
    IL_0171: ldstr 0x700028FB
    IL_0172: IL_22
    IL_0173: nop
    IL_0174: nop
    IL_0175: nop
    IL_0176: nop
    IL_0177: ldc.i4.1
    IL_0178: conv.r8
    IL_0179: IL_95
    IL_017A: ldarg.1
    IL_017B: nop
    IL_017C: ldloc.0
    IL_0181: stelem 0x06FF7B02
    IL_0182: nop
    IL_0183: ldarg.2
    IL_0184: ldloc.2
    IL_0185: ldarg.0
    IL_018A: ldfld 0x040006EC
    IL_018F: call 0x0A0000FA
    IL_0190: IL_22
    IL_0191: stloc.0
    IL_0192: IL_D7
    IL_0193: IL_23
    IL_0194: IL_3E
    IL_0199: call 0x0A000083
    IL_019A: IL_22
    IL_019B: nop
    IL_019C: nop
    IL_019D: nop
    IL_019E: nop
    IL_019F: ldarg.0
    IL_01A4: ldfld 0x04000701
    IL_01A9: call 0x0A000042
    IL_01AA: IL_22
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: nop
    IL_01AE: IL_3F
    IL_01B3: call 0x0A000008
    IL_01B8: call 0x0A000019
    IL_01B9: IL_22
    IL_01BA: nop
    IL_01BB: nop
    IL_01C0: ldc.i4 8767
    IL_01C5: stsfld 0x0038733E
    IL_01C6: nop
    IL_01C7: stloc.0
    IL_01C8: IL_22
    IL_01C9: nop
    IL_01CA: nop
    IL_01CC: bgt.s IL_020C
    IL_01CD: IL_22
    IL_01CE: nop
    IL_01CF: nop
    IL_01D0: ldelem.r8
    IL_01D1: IL_3E
    IL_01D6: newobj 0x0A000038
    IL_01DB: ldstr 0x70002915
    IL_01E0: ldstr 0x70002931
    IL_01E1: IL_22
    IL_01E2: nop
    IL_01E3: nop
    IL_01E4: nop
    IL_01E5: nop
    IL_01E6: ldc.i4.1
    IL_01E7: conv.r8
    IL_01E8: IL_95
    IL_01E9: ldarg.1
    IL_01EA: nop
    IL_01EB: ldloc.0
    IL_01F0: stelem 0x06FC7B02
    IL_01F1: nop
    IL_01F2: ldarg.2
    IL_01F3: ldloc.2
    IL_01F4: ldelem.i
    IL_01F5: conv.r8
    IL_01F6: IL_4E
    IL_01F7: nop
    IL_01F8: nop
    IL_01FA: br.s IL_0203
    IL_01FB: ldarg.0
    IL_0200: ldfld 0x040006F4
    IL_0201: ldloc.2
    IL_0202: IL_94
    IL_0203: ldc.i4.0
    IL_0204: ldarg.0
    IL_0209: ldfld 0x040006F7
    IL_020A: ldloc.2
    IL_020B: IL_92
    IL_020C: conv.r8
    IL_020F: ldloca 3
    IL_0210: ldloc.0
    IL_0211: ldarg.0
    IL_0216: ldfld 0x040006FF
    IL_0217: ldloc.2
    IL_0218: ldelem.i
    IL_0219: conv.r8
    IL_021A: IL_4F
    IL_021B: nop
    IL_021C: nop
    IL_021E: br.s IL_0227
    IL_021F: ldarg.0
    IL_0224: ldfld 0x040006F6
    IL_0225: ldloc.2
    IL_0226: IL_98
    IL_0227: conv.r8
    IL_0229: br.s IL_022D
    IL_022A: nop
    IL_022B: ldloc.0
    IL_022C: ldarg.0
    IL_022D: dup
    IL_0232: ldfld 0x04000701
    IL_0237: call 0x0A000007
    IL_0238: IL_22
    IL_0239: stloc.0
    IL_023A: IL_D7
    IL_023B: stelem.i
    IL_023C: IL_3E
    IL_0241: call 0x0A000008
    IL_0246: call 0x0A000019
    IL_024B: stfld 0x04000701
    IL_024C: ldarg.0
    IL_0251: ldfld 0x04000712
    IL_0252: ldarg.0
    IL_0257: ldfld 0x040006FC
    IL_0258: ldloc.2
    IL_0259: ldelem.i
    IL_025A: conv.r8
    IL_025B: ldc.i4.2
    IL_025C: nop
    IL_025D: nop
    IL_025E: stloc.0
    IL_025F: IL_22
    IL_0260: stloc.0
    IL_0261: IL_D7
    IL_0262: IL_23
    IL_0263: IL_BC
    IL_0264: IL_22
    IL_0265: IL_EC
    IL_0266: IL_51
    IL_0267: IL_B8
    IL_0268: IL_3D
    IL_0269: IL_22
    IL_026A: IL_CD
    IL_026B: IL_CC
    IL_026C: IL_CC
    IL_026D: IL_BD
    IL_0272: newobj 0x0A000076
    IL_0277: call 0x0A000029
    IL_027C: call 0x0A000013
    IL_0281: call 0x0A000014
    IL_0282: conv.u4
    IL_0283: ldarg.1
    IL_0284: nop
    IL_0285: nop
    IL_0286: IL_01
    IL_0288: stloc.s 4
    IL_028A: ldloc.s 4
    IL_028B: ldarg.0
    IL_0290: ldfld 0x040006FC
    IL_0291: ldloc.2
    IL_0292: ldelem.i
    IL_0293: conv.r8
    IL_0294: IL_4E
    IL_0295: nop
    IL_0296: nop
    IL_0297: stloc.0
    IL_0299: ldloc.s 4
    IL_029A: conv.r8
    IL_029B: IL_24
    IL_029C: nop
    IL_029D: nop
    IL_029F: br.s IL_02B3
    IL_02A0: ldarg.3
    IL_02A2: ldloc.s 5
    IL_02A3: ldarg.0
    IL_02A8: ldfld 0x040006F7
    IL_02A9: ldloc.2
    IL_02AA: IL_8F
    IL_02AC: starg.s 0
    IL_02AD: nop
    IL_02AE: IL_01
    IL_02B3: call 0x0A000016
    IL_02B4: conv.r8
    IL_02B5: IL_FD
    IL_02B6: nop
    IL_02B7: nop
    IL_02B8: stloc.0
    IL_02BA: ldloc.s 5
    IL_02BB: IL_22
    IL_02BC: stloc.0
    IL_02BD: IL_D7
    IL_02BE: stelem.i
    IL_02BF: IL_3C
    IL_02C0: conv.r8
    IL_02C1: IL_B2
    IL_02C2: IL_01
    IL_02C3: nop
    IL_02C4: stloc.0
    IL_02C5: ldarg.0
    IL_02CA: ldfld 0x040006EC
    IL_02CB: IL_22
    IL_02CC: IL_CD
    IL_02CD: IL_CC
    IL_02CE: IL_4C
    IL_02CF: IL_3E
    IL_02D0: IL_22
    IL_02D1: IL_CD
    IL_02D2: IL_CC
    IL_02D3: IL_CC
    IL_02D4: IL_3D
    IL_02D9: newobj 0x0A000038
    IL_02DA: IL_22
    IL_02DB: nop
    IL_02DC: nop
    IL_02DD: nop
    IL_02DE: nop
    IL_02DF: ldarg.0
    IL_02E4: ldfld 0x040006FC
    IL_02E5: ldloc.2
    IL_02E6: ldelem.i
    IL_02E7: conv.r8
    IL_02E8: ldc.i4.2
    IL_02E9: nop
    IL_02EA: nop
    IL_02EB: stloc.0
    IL_02EC: IL_22
    IL_02ED: stloc.0
    IL_02EE: IL_D7
    IL_02EF: IL_23
    IL_02F0: IL_3C
    IL_02F1: IL_22
    IL_02F2: ldc.i4.5
    IL_02F4: bge.s IL_0352
    IL_02F5: IL_3D
    IL_02F6: IL_22
    IL_02F7: IL_CD
    IL_02F8: IL_CC
    IL_02F9: IL_4C
    IL_02FA: IL_BD
    IL_02FF: newobj 0x0A000076
    IL_0304: call 0x0A000029
    IL_0305: IL_22
    IL_0306: nop
    IL_0307: nop
    IL_030C: stsfld 0x0000223E
    IL_E1D00D: switch (3699519 cases)
    }

    public void Set_General() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006FF
    IL_0007: ldc.i4.s 20
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040006EC
    IL_0012: call 0x0A0000FA
    IL_0013: IL_22
    IL_0014: stloc.0
    IL_0015: IL_D7
    IL_0016: IL_23
    IL_0017: IL_3E
    IL_001C: call 0x0A000083
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0026: call 0x0A00004B
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: ldelem.r8
    IL_20CF: switch (2088 cases)
    }

    public void ResetCooltime_general() {
    IL_0000: ldc.i4.1
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0007: ldfld 0x04000708
    IL_000C: brtrue IL_002F
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040006F8
    IL_0014: ldc.i4.s 20
    IL_0015: ldc.i4.0
    IL_0016: ldelem.i8
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040006FF
    IL_001E: ldc.i4.s 20
    IL_001F: ldelem.i
    IL_0020: conv.r8
    IL_0021: IL_4F
    IL_0022: nop
    IL_0023: nop
    IL_0025: br.s IL_0095
    IL_0027: beq.s IL_002B
    IL_0028: nop
    IL_0029: ldloc.0
    IL_002E: br IL_0087
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000713
    IL_0035: ldc.i4.0
    IL_0036: IL_3D
    IL_0037: ldloc.1
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: ldc.i4.0
    IL_003C: stloc.0
    IL_0041: br IL_0087
    IL_0042: ldarg.0
    IL_0043: dup
    IL_0048: ldfld 0x04000713
    IL_0049: ldc.i4.1
    IL_004A: IL_59
    IL_004F: stfld 0x04000713
    IL_0050: ldarg.0
    IL_0055: ldfld 0x040006FF
    IL_0057: ldc.i4.s 20
    IL_0058: ldelem.i
    IL_0059: ldc.i4.0
    IL_005A: conv.r8
    IL_005F: brtrue IL_6F0A0060
    IL_0060: IL_24
    IL_0061: nop
    IL_0062: nop
    IL_0064: br.s IL_0067
    IL_0069: ldflda 0x04000713
    IL_006E: call 0x0A000010
    IL_006F: conv.r8
    IL_0070: IL_FD
    IL_0071: nop
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040006FF
    IL_007B: ldc.i4.s 20
    IL_007C: ldelem.i
    IL_007D: conv.r8
    IL_007E: IL_4F
    IL_007F: nop
    IL_0080: nop
    IL_0082: br.s IL_00F2
    IL_0084: beq.s IL_0088
    IL_0085: nop
    IL_0086: ldloc.0
    IL_0087: ldloc.0
    IL_0088: ret
    }

    public void RegenGeneralSkill() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000707
    IL_000A: brfalse IL_0036
    IL_000B: ldarg.0
    IL_000C: ldc.i4.1
    IL_0011: stfld 0x04000713
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040006FF
    IL_0019: ldc.i4.s 20
    IL_001A: ldelem.i
    IL_001B: ldc.i4.0
    IL_001C: conv.r8
    IL_0021: brtrue IL_6F0A0022
    IL_0022: IL_24
    IL_0023: nop
    IL_0024: nop
    IL_0026: br.s IL_0029
    IL_002B: ldflda 0x04000713
    IL_0030: call 0x0A000010
    IL_0031: conv.r8
    IL_0032: IL_FD
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ret
    }

    public void ShortSp() {
    IL_0000: ldarg.1
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 1459265
    IL_0009: nop
    IL_000A: nop
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000700
    IL_0011: conv.r8
    IL_0012: stloc.0
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldc.i4.0
    IL_0017: conv.r8
    IL_0018: stloc.1
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: br IL_0032
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000700
    IL_0027: conv.r8
    IL_0028: stloc.0
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_002C: ldc.i4.1
    IL_002D: conv.r8
    IL_002E: stloc.1
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ret
    }

    public void ItemUse() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006FE
    IL_0006: ldarg.1
    IL_0007: ldelem.i
    IL_0008: conv.r8
    IL_0009: stloc.0
    IL_000A: nop
    IL_000B: nop
    IL_000C: stloc.0
    IL_0011: call 0x0A000050
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000711
    IL_0019: ldc.i4.s 50
    IL_001A: conv.r8
    IL_001B: IL_92
    IL_001C: IL_01
    IL_001D: nop
    IL_001E: ldloc.0
    IL_001F: ret
    }

    public void ResetCooltime_skill() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000708
    IL_000A: brtrue IL_0043
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040006FA
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040006F4
    IL_0017: ldarg.1
    IL_0018: IL_94
    IL_0019: IL_8F
    IL_001A: stloc.1
    IL_001B: nop
    IL_001C: nop
    IL_001D: IL_01
    IL_001E: dup
    IL_0021: stloc 22551
    IL_0022: IL_54
    IL_0023: ldarg.0
    IL_0028: ldfld 0x040006F8
    IL_0029: ldarg.1
    IL_002A: ldc.i4.0
    IL_002B: ldelem.i8
    IL_002C: ldarg.0
    IL_0031: ldfld 0x040006FF
    IL_0032: ldarg.1
    IL_0033: ldelem.i
    IL_0034: conv.r8
    IL_0035: IL_4F
    IL_0036: nop
    IL_0037: nop
    IL_0039: br.s IL_00A9
    IL_003B: beq.s IL_003F
    IL_003C: nop
    IL_003D: ldloc.0
    IL_0042: br IL_0101
    IL_0043: ldarg.0
    IL_0048: ldfld 0x040006F5
    IL_0049: ldarg.1
    IL_004A: IL_8F
    IL_004B: stloc.1
    IL_004C: nop
    IL_004D: nop
    IL_004E: IL_01
    IL_004F: dup
    IL_0052: stloc 22807
    IL_0053: IL_54
    IL_0054: ldarg.0
    IL_0059: ldfld 0x040006FC
    IL_005A: ldarg.1
    IL_005B: ldelem.i
    IL_005C: ldc.i4.0
    IL_005D: conv.r8
    IL_0062: brtrue IL_6F0A0063
    IL_0063: IL_24
    IL_0064: nop
    IL_0065: nop
    IL_0067: br.s IL_006A
    IL_006C: ldfld 0x040006F5
    IL_006D: ldarg.1
    IL_006E: IL_8F
    IL_006F: stloc.1
    IL_0070: nop
    IL_0071: nop
    IL_0072: IL_01
    IL_0077: call 0x0A000010
    IL_0078: conv.r8
    IL_0079: IL_FD
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: ldarg.0
    IL_0082: ldfld 0x040006F5
    IL_0083: ldarg.1
    IL_0084: IL_94
    IL_0085: ldc.i4.0
    IL_0086: IL_3D
    IL_0087: add
    IL_0088: nop
    IL_0089: nop
    IL_008A: nop
    IL_008B: ldarg.0
    IL_0090: ldfld 0x040006FC
    IL_0091: ldarg.1
    IL_0092: ldelem.i
    IL_0097: call 0x0A00004B
    IL_0098: IL_22
    IL_0099: nop
    IL_009A: nop
    IL_009D: ldloc 10307
    IL_009E: ldloc.2
    IL_009F: nop
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: conv.r8
    IL_00A3: ldloc.3
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x040006FF
    IL_00AD: ldarg.1
    IL_00AE: ldelem.i
    IL_00B3: call 0x0A00004B
    IL_00B4: IL_22
    IL_00B5: nop
    IL_00B6: nop
    IL_00B9: ldloc 10307
    IL_00BA: ldloc.2
    IL_00BB: nop
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00BE: conv.r8
    IL_00BF: ldloc.3
    IL_00C0: nop
    IL_00C1: nop
    IL_00C2: stloc.0
    IL_00C3: ldarg.0
    IL_00C4: ldc.i4.0
    IL_00C9: stfld 0x0400070D
    IL_00CA: ldarg.0
    IL_00CB: ldc.i4.0
    IL_00D0: stfld 0x0400070A
    IL_00D1: ldarg.0
    IL_00D6: ldstr 0x700029CB
    IL_00D7: IL_22
    IL_00D8: IL_CD
    IL_00D9: IL_CC
    IL_00DA: IL_4C
    IL_00DB: IL_3E
    IL_00E0: call 0x0A00003F
    IL_00E5: br IL_0101
    IL_00E6: ldarg.0
    IL_00EB: ldfld 0x040006F8
    IL_00EC: ldarg.1
    IL_00ED: ldc.i4.0
    IL_00EE: ldelem.i8
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x040006FF
    IL_00F5: ldarg.1
    IL_00F6: ldelem.i
    IL_00F7: conv.r8
    IL_00F8: IL_4F
    IL_00F9: nop
    IL_00FA: nop
    IL_00FC: br.s IL_016C
    IL_00FE: beq.s IL_0102
    IL_00FF: nop
    IL_0100: ldloc.0
    IL_0101: ret
    }

    public void Skill_Possible() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006F7
    IL_0006: ldarg.1
    IL_0007: IL_92
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040006ED
    IL_000E: IL_3D
    IL_0010: ldarg.s 0
    IL_0011: nop
    IL_0012: nop
    IL_0013: ldarg.0
    IL_0018: ldfld 0x040006F8
    IL_0019: ldarg.1
    IL_001A: ldc.i4.2
    IL_001B: ldelem.i8
    IL_0020: br IL_003C
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040006F8
    IL_0027: ldarg.1
    IL_0028: ldc.i4.1
    IL_0029: ldelem.i8
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040006FF
    IL_0030: ldarg.1
    IL_0031: ldelem.i
    IL_0032: conv.r8
    IL_0033: IL_4F
    IL_0034: nop
    IL_0035: nop
    IL_0037: br.s IL_00A7
    IL_0039: brfalse.s IL_003D
    IL_003A: nop
    IL_003B: ldloc.0
    IL_003C: ret
    }

    public void Skillset_roll() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0043
    IL_0007: ldarg.0
    IL_000C: ldfld 0x040006FC
    IL_000D: ldloc.0
    IL_000E: ldelem.i
    IL_0013: call 0x0A00004B
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_0017: ldelem.r8
    IL_20BC: switch (2088 cases)
    }

    public void SkillPlus() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0007: ldfld 0x040006F5
    IL_0008: ldarg.1
    IL_0009: IL_94
    IL_000B: ldc.i4.s 9
    IL_000C: IL_3C
    IL_000D: IL_3F
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040006F5
    IL_0017: ldarg.1
    IL_0018: IL_8F
    IL_0019: stloc.1
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_01
    IL_001D: dup
    IL_0020: stloc 22551
    IL_0021: IL_54
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040006FC
    IL_0028: ldarg.1
    IL_0029: ldelem.i
    IL_002A: ldc.i4.0
    IL_002B: conv.r8
    IL_0030: brtrue IL_6F0A0031
    IL_0031: IL_24
    IL_0032: nop
    IL_0033: nop
    IL_0035: br.s IL_0038
    IL_003A: ldfld 0x040006F5
    IL_003B: ldarg.1
    IL_003C: IL_8F
    IL_003D: stloc.1
    IL_003E: nop
    IL_003F: nop
    IL_0040: IL_01
    IL_0045: call 0x0A000010
    IL_0046: conv.r8
    IL_0047: IL_FD
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004F: br IL_0052
    IL_0050: ldc.i4.1
    IL_0051: stloc.0
    IL_0052: ldarg.0
    IL_0057: call 0x0600033C
    IL_0058: ldloc.0
    IL_0059: ret
    }

    public void ArrayIcon() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: ldc.i4.0
    IL_0008: stfld 0x0400070B
    IL_0009: ldc.i4.0
    IL_000A: stloc.1
    IL_000F: br IL_00FE
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040006F5
    IL_0016: ldloc.1
    IL_0017: IL_94
    IL_0018: ldc.i4.0
    IL_0019: IL_3E
    IL_001A: IL_DC
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040006FC
    IL_0024: ldloc.1
    IL_0025: ldelem.i
    IL_002A: call 0x0A00004B
    IL_002B: IL_22
    IL_002C: nop
    IL_002D: nop
    IL_0030: ldloc 10307
    IL_0031: ldloc.2
    IL_0032: nop
    IL_0033: nop
    IL_0034: stloc.0
    IL_0035: conv.r8
    IL_0036: ldloc.3
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: ldarg.0
    IL_003F: ldfld 0x040006FF
    IL_0040: ldloc.1
    IL_0041: ldelem.i
    IL_0046: call 0x0A00004B
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004C: ldloc 10307
    IL_004D: ldloc.2
    IL_004E: nop
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: conv.r8
    IL_0052: ldloc.3
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldloc.1
    IL_0057: ldarg.0
    IL_005C: ldfld 0x0400070D
    IL_005D: IL_3F
    IL_005E: ldind.ref
    IL_005F: nop
    IL_0060: nop
    IL_0061: nop
    IL_0062: ldloc.0
    IL_0063: ldc.i4.5
    IL_0064: IL_3C
    IL_0065: IL_83
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: ldarg.0
    IL_006E: ldfld 0x040006FC
    IL_006F: ldloc.1
    IL_0070: ldelem.i
    IL_0071: IL_22
    IL_0073: bne.un.s IL_00A7
    IL_0074: conv.ovf.i4.un
    IL_0075: IL_3F
    IL_0076: IL_22
    IL_0077: shr
    IL_0078: shr
    IL_0079: pop
    IL_0106: switch (34 cases)
    IL_0107: ldarg.0
    IL_010C: ldfld 0x0400070B
    IL_010D: ldc.i4.1
    IL_010E: IL_59
    IL_010F: ldc.i4.5
    IL_0110: add
    IL_0111: ldc.i4.1
    IL_0112: IL_58
    IL_0117: stfld 0x0400070B
    IL_0118: ldarg.0
    IL_011D: ldfld 0x0400070B
    IL_011E: ldc.i4.1
    IL_011F: IL_3E
    IL_0120: IL_24
    IL_0121: nop
    IL_0122: nop
    IL_0123: nop
    IL_0124: ldarg.0
    IL_0129: ldfld 0x040006EB
    IL_012A: IL_22
    IL_012B: IL_C5
    IL_0130: ldc.i4 -2061353040
    IL_0131: IL_EB
    IL_0132: IL_91
    IL_0133: IL_3F
    IL_0134: IL_22
    IL_0135: nop
    IL_0136: nop
    IL_0137: nop
    IL_1DB08: switch (30323 cases)
    }

    public void SoulMeasure() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040006ED
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_006E
    IL_000E: ldarg.0
    IL_0013: ldfld 0x040006F8
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_0016: ldc.i4.0
    IL_0017: IL_3E
    IL_0018: IL_4E
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040006F7
    IL_0022: ldloc.0
    IL_0023: IL_92
    IL_0024: ldarg.0
    IL_0029: ldfld 0x040006ED
    IL_002A: IL_3D
    IL_002F: ldc.i4 33554432
    IL_0034: ldfld 0x040006F8
    IL_0035: ldloc.0
    IL_0036: ldc.i4.2
    IL_0037: ldelem.i8
    IL_0038: ldarg.0
    IL_003D: ldfld 0x040006FF
    IL_003E: ldloc.0
    IL_003F: ldelem.i
    IL_0040: conv.r8
    IL_0041: IL_4F
    IL_0042: nop
    IL_0043: nop
    IL_0045: br.s IL_00B5
    IL_0047: brtrue.s IL_004B
    IL_0048: nop
    IL_0049: ldloc.0
    IL_004E: br IL_006A
    IL_004F: ldarg.0
    IL_0054: ldfld 0x040006F8
    IL_0055: ldloc.0
    IL_0056: ldc.i4.1
    IL_0057: ldelem.i8
    IL_0058: ldarg.0
    IL_005D: ldfld 0x040006FF
    IL_005E: ldloc.0
    IL_005F: ldelem.i
    IL_0060: conv.r8
    IL_0061: IL_4F
    IL_0062: nop
    IL_0063: nop
    IL_0065: br.s IL_00D5
    IL_0067: brfalse.s IL_006B
    IL_0068: nop
    IL_0069: ldloc.0
    IL_006A: ldloc.0
    IL_006B: ldc.i4.1
    IL_006C: IL_58
    IL_006D: stloc.0
    IL_006E: ldloc.0
    IL_006F: ldc.i4.6
    IL_0070: IL_3F
    IL_0071: IL_99
    IL_0072: IL_FF
    IL_0073: IL_FF
    IL_0074: IL_FF
    IL_0075: ret
    }

    public void PetSkill_Generation() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0008: br IL_0066
    IL_0009: ldarg.0
    IL_000E: ldfld 0x040006F2
    IL_000F: ldloc.1
    IL_0010: IL_94
    IL_0011: ldc.i4.0
    IL_0012: IL_3E
    IL_0013: localloc
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040006FD
    IL_001D: ldloc.1
    IL_001E: ldelem.i
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000704
    IL_0029: call 0x0A000007
    IL_002A: IL_22
    IL_002B: stloc.0
    IL_002C: IL_D7
    IL_002D: stelem.i
    IL_002E: IL_BE
    IL_0033: call 0x0A000008
    IL_0034: ldloc.0
    IL_0035: conv.i2
    IL_003A: call 0x0A000008
    IL_003F: call 0x0A000029
    IL_0040: ldarg.0
    IL_0045: ldfld 0x040006E8
    IL_0046: conv.r8
    IL_0047: ldc.i4.2
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004F: call 0x0A000029
    IL_0050: conv.r8
    IL_0051: ldloc.3
    IL_0052: nop
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: ldarg.0
    IL_005A: ldfld 0x040006F9
    IL_005B: ldloc.1
    IL_005C: ldc.i4.1
    IL_005D: ldelem.i2
    IL_005E: ldloc.0
    IL_005F: ldc.i4.1
    IL_0060: IL_58
    IL_0061: stloc.0
    IL_0062: ldloc.1
    IL_0063: ldc.i4.1
    IL_0064: IL_58
    IL_0065: stloc.1
    IL_0066: ldloc.1
    IL_0067: ldc.i4.2
    IL_0068: IL_3F
    IL_0069: ldelem.i2
    IL_006A: IL_FF
    IL_006B: IL_FF
    IL_006C: IL_FF
    IL_006D: ret
    }

    public void Ef_SkillUse() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006E6
    IL_0006: ldarg.1
    IL_000B: call 0x0A000042
    IL_000C: IL_22
    IL_000D: ldelem.i
    IL_000E: IL_99
    IL_000F: IL_99
    IL_0010: IL_3F
    IL_0015: call 0x0A000008
    IL_001A: call 0x0A000019
    IL_001B: conv.r8
    IL_001C: ldloc.3
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0025: ldfld 0x040006E6
    IL_0026: conv.r8
    IL_002B: call 0x1A2B0000
    IL_002C: ldc.i4.4
    IL_002E: ldc.i4.s 20
    IL_002F: ldc.i4.0
    IL_0030: conv.r8
    IL_0031: IL_D7
    IL_0032: ldarg.0
    IL_0033: nop
    IL_0034: ldloc.0
    IL_0035: ret
    }

    public void Duration_reduce() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006FB
    IL_0006: ldarg.1
    IL_0007: IL_8F
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_01
    IL_000C: dup
    IL_000F: stloc 22551
    IL_0010: IL_54
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040006F9
    IL_0017: ldarg.1
    IL_0018: ldc.i4.0
    IL_0019: ldelem.i2
    IL_001A: ldarg.0
    IL_001B: ldc.i4.1
    IL_0020: stfld 0x04000706
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040006FD
    IL_0027: ldarg.1
    IL_0028: ldelem.i
    IL_002D: call 0x0A00004B
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0032: starg.s 65
    IL_0037: call 0x0A000008
    IL_0038: conv.r8
    IL_0039: ldloc.3
    IL_003A: nop
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: ldarg.0
    IL_003E: ldarg.1
    IL_0043: stfld 0x04000709
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040006F2
    IL_004A: ldarg.1
    IL_004B: IL_8F
    IL_004C: stloc.1
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_01
    IL_0050: dup
    IL_0053: stloc 22807
    IL_0054: IL_54
    IL_0059: ldstr 0x70001F0D
    IL_005A: ldarg.0
    IL_005F: ldfld 0x040006F2
    IL_0064: call 0x060003F8
    IL_0065: pop
    IL_0066: ret
    }

    public void SaveSkillUse() {
    IL_0004: ldstr 0x70002001
    IL_0005: ldarg.0
    IL_000A: ldfld 0x040006FA
    IL_000F: call 0x060003F8
    IL_0010: pop
    IL_0015: ldstr 0x70002015
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040006FB
    IL_0020: call 0x060003F8
    IL_0021: pop
    IL_0022: ret
    }

    public void SkillIcon_Move() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x0400070E
    IL_0007: ret
    }

    public void PetIcon_Move() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x0400070F
    IL_0007: ret
    }

    public void GeneralDead() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000700
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.0
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ret
    }

    public void GeneralSkillFillbox() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000707
    IL_000A: brfalse IL_0055
    IL_000B: ldarg.1
    IL_0010: brtrue IL_0033
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040006FF
    IL_0018: ldc.i4.s 20
    IL_0019: ldelem.i
    IL_001E: call 0x0A00004B
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldelem.r8
    IL_20C7: switch (2088 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000706
    IL_000A: brfalse IL_0058
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000705
    IL_0016: call 0x0A000024
    IL_0017: IL_58
    IL_001C: stfld 0x04000705
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000705
    IL_0023: ldarg.0
    IL_0028: ldfld 0x040006EE
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000709
    IL_002F: IL_98
    IL_0030: IL_44
    IL_0031: IL_23
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0035: ldarg.0
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003F: stfld 0x04000705
    IL_0040: ldarg.0
    IL_0041: ldc.i4.0
    IL_0046: stfld 0x04000706
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000711
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000709
    IL_0053: conv.r8
    IL_0058: ldflda 0x02060001
    IL_005D: ldfld 0x0400070E
    IL_0062: brfalse IL_0094
    IL_0063: ldarg.0
    IL_0068: ldfld 0x040006E9
    IL_0069: ldarg.0
    IL_006E: ldfld 0x040006E9
    IL_006F: conv.r8
    IL_0070: ldc.i4.2
    IL_0071: nop
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x04000703
    IL_007E: call 0x0A000024
    IL_007F: IL_22
    IL_0080: nop
    IL_0081: nop
    IL_0083: starg.s 65
    IL_0084: IL_5A
    IL_0089: call 0x0A000063
    IL_008A: conv.r8
    IL_008B: ldloc.3
    IL_008C: nop
    IL_008D: nop
    IL_008E: stloc.0
    IL_0093: br IL_00BF
    IL_0094: ldarg.0
    IL_0099: ldfld 0x040006E9
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040006E9
    IL_00A0: conv.r8
    IL_00A1: ldc.i4.2
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A9: call 0x0A00001B
    IL_00AE: call 0x0A000024
    IL_00AF: IL_22
    IL_00B0: nop
    IL_00B1: nop
    IL_18CA169BA: switch (1663588929 cases)
    }

    }}
