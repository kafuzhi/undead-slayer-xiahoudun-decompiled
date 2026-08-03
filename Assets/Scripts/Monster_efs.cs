// Namespace: 
// Type: Monster_efs

    public class Monster_efs {{

    private static object MONNUM;
    private static object SHORTMONNUM;
    public object shadow;
    public object ef_hit;
    public object ef_blood;
    public object ef_block;
    public object arrowmark;
    public object num_damage;
    public object pt_itemdrop;
    public object attribute_tex;
    public object blood_mat;
    public object split_material;
    public object item_material;
    public object main_material;
    public object hp_bar;
    public object begrab;
    public object bethrust;
    public object bekicked;
    public object getup;
    public object pierce;
    public object summon;
    public object speed_begrab;
    public object speed_bethrust;
    public object speed_bekicked;
    public object speed_getup;
    public object force_grab;
    public object force_kick;
    public object snd_move;
    public object snd_scream;
    private object mytransform;
    private object c_shadow;
    private object selectshadow;
    private object grab_blood;
    private object c_damagenum;
    private object c_ef_hit;
    private object c_ef_blood;
    private object c_ef_split;
    private object c_hpbar;
    private object c_item;
    private object m_item;
    private object selecthpbar;
    private object hpsize;
    private object count_item;
    private object count_damagenum;
    private object ef_attribute;
    private object originpos;
    public object story;
    private object infinitymode;
    private object index_ef;
    private object index_destroy;
    private object script_spawn;
    private object script_spawn_story;
    private object limit_x;
    private object limit_y_b;
    private object limit_y_f;

    public Monster_efs() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: newarr 0x01000001
    IL_000B: stfld 0x0400080F
    IL_000C: ldarg.0
    IL_000D: ldc.i4.5
    IL_0012: newarr 0x0100000A
    IL_0017: stfld 0x04000810
    IL_0018: ldarg.0
    IL_0019: ldc.i4.6
    IL_001E: newarr 0x01000023
    IL_0023: stfld 0x04000815
    IL_0024: ldarg.0
    IL_0025: ldc.i4.6
    IL_002A: newarr 0x01000023
    IL_002F: stfld 0x04000816
    IL_0030: ldarg.0
    IL_0031: ldc.i4.6
    IL_0036: newarr 0x01000023
    IL_003B: stfld 0x04000817
    IL_003C: ldarg.0
    IL_003D: ldc.i4.6
    IL_0042: newarr 0x01000023
    IL_0047: stfld 0x04000818
    IL_0048: ldarg.0
    IL_0049: ldc.i4.2
    IL_004E: newarr 0x01000023
    IL_0053: stfld 0x0400081A
    IL_0054: ldarg.0
    IL_0055: ldc.i4.7
    IL_005A: newarr 0x0100002F
    IL_005F: stfld 0x0400081B
    IL_0060: ldarg.0
    IL_0061: ldc.i4.7
    IL_0066: newarr 0x0100002F
    IL_006B: stfld 0x0400081C
    IL_006C: ldarg.0
    IL_006D: ldc.i4.7
    IL_0072: newarr 0x0100002F
    IL_0077: stfld 0x0400081D
    IL_0078: ldarg.0
    IL_0079: ldc.i4.7
    IL_007E: newarr 0x0100002F
    IL_0083: stfld 0x0400081E
    IL_0084: ldarg.0
    IL_0085: ldc.i4.7
    IL_008A: newarr 0x0100000B
    IL_008F: stfld 0x0400081F
    IL_0090: ldarg.0
    IL_0091: ldc.i4.7
    IL_0096: newarr 0x0100000B
    IL_009B: stfld 0x04000820
    IL_009C: ldarg.0
    IL_009D: ldc.i4.3
    IL_00A2: newarr 0x0100001E
    IL_00A7: stfld 0x04000821
    IL_00A8: ldarg.0
    IL_00A9: ldc.i4.4
    IL_00AE: newarr 0x0100001E
    IL_00B3: stfld 0x04000822
    IL_00B4: ldarg.0
    IL_00B6: ldc.i4.s 15
    IL_00BB: newarr 0x01000003
    IL_00C0: stfld 0x04000824
    IL_00C1: ldarg.0
    IL_00C3: ldc.i4.s 10
    IL_00C8: newarr 0x01000003
    IL_00CD: stfld 0x04000827
    IL_00CE: ldarg.0
    IL_00D0: ldc.i4.s 10
    IL_00D5: newarr 0x01000003
    IL_00DA: stfld 0x04000828
    IL_00DB: ldarg.0
    IL_00DD: ldc.i4.s 10
    IL_00E2: newarr 0x01000003
    IL_00E7: stfld 0x04000829
    IL_00E8: ldarg.0
    IL_00EA: ldc.i4.s 10
    IL_00EF: newarr 0x01000003
    IL_00F4: stfld 0x0400082A
    IL_00F5: ldarg.0
    IL_00F7: ldc.i4.s 15
    IL_00FC: newarr 0x01000003
    IL_0101: stfld 0x0400082B
    IL_0102: ldarg.0
    IL_0104: ldc.i4.s 15
    IL_0109: newarr 0x01000003
    IL_010E: stfld 0x0400082C
    IL_010F: ldarg.0
    IL_0111: ldc.i4.s 15
    IL_0116: newarr 0x01000031
    IL_011B: stfld 0x0400082D
    IL_011C: ldarg.0
    IL_011D: IL_22
    IL_011E: IL_CD
    IL_011F: IL_CC
    IL_0120: IL_4C
    IL_0121: IL_3D
    IL_0122: IL_22
    IL_0123: stloc.0
    IL_0124: IL_D7
    IL_0125: IL_23
    IL_0126: IL_3C
    IL_012B: newobj 0x0A000038
    IL_0130: stfld 0x0400082F
    IL_0131: ldarg.0
    IL_0136: call 0x0A00004B
    IL_0137: IL_22
    IL_0138: nop
    IL_0139: nop
    IL_20A23E: switch (534592 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000823
    IL_000C: ldc.i4.0
    IL_000D: stloc.0
    IL_0012: br IL_007F
    IL_0013: ldarg.0
    IL_0018: ldfld 0x0400082B
    IL_0019: ldloc.0
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x0400082F
    IL_0021: ldc.i4.0
    IL_0022: ldc.i4.0
    IL_0027: call 0x060003BE
    IL_002C: stelem 0x082B7B02
    IL_002D: nop
    IL_002E: ldarg.2
    IL_002F: ldloc.0
    IL_0030: ldelem.i
    IL_0035: call 0x0A00004B
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_003D: stsfld 0x00082840
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: conv.r8
    IL_0041: ldloc.3
    IL_0042: nop
    IL_0043: nop
    IL_0044: stloc.0
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000824
    IL_004B: ldloc.0
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000808
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000833
    IL_005C: call 0x0A000013
    IL_0061: call 0x0A000014
    IL_0062: conv.u4
    IL_0063: ldarg.1
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_01
    IL_006B: stelem 0x08247B02
    IL_006C: nop
    IL_006D: ldarg.2
    IL_006E: ldloc.0
    IL_006F: ldelem.i
    IL_0070: conv.r8
    IL_0071: stloc.0
    IL_0072: nop
    IL_0073: nop
    IL_0074: stloc.0
    IL_0075: ldc.i4.0
    IL_0076: conv.r8
    IL_0077: stloc.1
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldloc.0
    IL_007C: ldc.i4.1
    IL_007D: IL_58
    IL_007E: stloc.0
    IL_007F: ldloc.0
    IL_0081: ldc.i4.s 15
    IL_0082: IL_3F
    IL_0087: newobj 0x16FFFFFF
    IL_0088: stloc.1
    IL_008D: br IL_018A
    IL_008E: ldarg.0
    IL_0093: ldfld 0x04000827
    IL_0094: ldloc.1
    IL_0095: ldarg.0
    IL_009A: ldfld 0x0400080D
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000833
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x0400080D
    IL_00A7: conv.r8
    IL_00A8: pop
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: stloc.0
    IL_00B0: call 0x0A000014
    IL_00B1: conv.u4
    IL_00B2: ldarg.1
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: IL_01
    IL_00BA: stelem 0x08287B02
    IL_00BB: nop
    IL_00BC: ldarg.2
    IL_00BD: ldloc.1
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x04000809
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x04000833
    IL_00CE: call 0x0A000013
    IL_00D3: call 0x0A000014
    IL_00D4: conv.u4
    IL_00D5: ldarg.1
    IL_00D6: nop
    IL_00D7: nop
    IL_00D8: IL_01
    IL_00DD: stelem 0x08297B02
    IL_00DE: nop
    IL_00DF: ldarg.2
    IL_00E0: ldloc.1
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x0400080A
    IL_00E7: ldarg.0
    IL_00EC: ldfld 0x04000833
    IL_00F1: call 0x0A000013
    IL_00F6: call 0x0A000014
    IL_00F7: conv.u4
    IL_00F8: ldarg.1
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: IL_01
    IL_0100: stelem 0x082A7B02
    IL_0101: nop
    IL_0102: ldarg.2
    IL_0103: ldloc.1
    IL_0104: ldarg.0
    IL_0105: ldloc.1
    IL_0106: ldc.i4.1
    IL_0107: IL_58
    IL_0108: ldc.i4.4
    IL_0109: mul
    IL_010E: call 0x060003BB
    IL_0113: stelem 0x082A7B02
    IL_0114: nop
    IL_0115: ldarg.2
    IL_0116: ldloc.1
    IL_0117: ldelem.i
    IL_0118: ldarg.0
    IL_011D: ldfld 0x04000833
    IL_011E: conv.r8
    IL_011F: ldloc.3
    IL_0120: nop
    IL_0121: nop
    IL_0122: stloc.0
    IL_0123: ldarg.0
    IL_0128: ldfld 0x04000828
    IL_0129: ldloc.1
    IL_012A: ldelem.i
    IL_012B: ldarg.0
    IL_0130: ldfld 0x04000823
    IL_0131: conv.r8
    IL_0132: IL_4E
    IL_0133: nop
    IL_0134: nop
    IL_0135: stloc.0
    IL_0136: ldarg.0
    IL_013B: ldfld 0x04000829
    IL_013C: ldloc.1
    IL_013D: ldelem.i
    IL_013E: ldarg.0
    IL_0143: ldfld 0x04000823
    IL_0144: conv.r8
    IL_0145: IL_4E
    IL_0146: nop
    IL_0147: nop
    IL_0148: stloc.0
    IL_0149: ldarg.0
    IL_014E: ldfld 0x0400082A
    IL_014F: ldloc.1
    IL_0150: ldelem.i
    IL_0151: ldarg.0
    IL_0156: ldfld 0x04000823
    IL_0157: conv.r8
    IL_0158: IL_4E
    IL_0159: nop
    IL_015A: nop
    IL_015B: stloc.0
    IL_015C: ldarg.0
    IL_0161: ldfld 0x0400082C
    IL_0162: ldloc.1
    IL_0163: ldarg.0
    IL_0168: call 0x060003C0
    IL_016D: stelem 0x082C7B02
    IL_016E: nop
    IL_016F: ldarg.2
    IL_0170: ldloc.1
    IL_0171: ldelem.i
    IL_0176: call 0x0A00004B
    IL_0177: IL_22
    IL_0178: nop
    IL_0179: nop
    IL_017A: ldelem.r8
    IL_221F: switch (2088 cases)
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000834
    IL_000A: brtrue IL_0036
    IL_000B: ldarg.0
    IL_0010: ldstr 0x70000063
    IL_0015: call 0x0A000004
    IL_0016: conv.r8
    IL_0017: ldarg.0
    IL_0018: nop
    IL_0019: nop
    IL_001B: br.s IL_0099
    IL_0020: br IL_2040029
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000838
    IL_002B: ldfld 0x0400095D
    IL_0030: stfld 0x04000835
    IL_0035: br IL_004B
    IL_0036: ldarg.0
    IL_003B: ldstr 0x70000063
    IL_0040: call 0x0A000004
    IL_0041: conv.r8
    IL_0043: stloc.s 0
    IL_0044: nop
    IL_0046: br.s IL_00C4
    IL_004B: brfalse IL_2040054
    IL_004C: ldarg.0
    IL_0051: ldfld 0x0400080A
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000833
    IL_005C: call 0x0A000013
    IL_0061: call 0x0A000014
    IL_0062: conv.u4
    IL_0063: ldarg.1
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_01
    IL_006B: stfld 0x04000826
    IL_006C: ldarg.0
    IL_0071: ldfld 0x04000826
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04000823
    IL_0078: conv.r8
    IL_0079: IL_4E
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000826
    IL_0083: IL_22
    IL_0084: nop
    IL_0085: nop
    IL_0086: nop
    IL_0087: IL_3F
    IL_0088: IL_22
    IL_0089: ldelem.i
    IL_008A: IL_99
    IL_008B: IL_99
    IL_008C: IL_3F
    IL_008D: IL_22
    IL_008E: ldelem.i
    IL_008F: IL_99
    IL_0090: IL_99
    IL_0091: IL_3F
    IL_0096: newobj 0x0A000076
    IL_0097: conv.r8
    IL_0098: IL_AF
    IL_0099: nop
    IL_009A: nop
    IL_009B: stloc.0
    IL_009C: ldarg.0
    IL_009D: ldc.i4.0
    IL_00A2: stfld 0x04000830
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x0400081B
    IL_00A9: ldc.i4.0
    IL_00AA: IL_22
    IL_00AB: nop
    IL_00AC: nop
    IL_00B1: stsfld 0x7B02A03E
    IL_00B2: ldc.i4.6
    IL_00B3: ldloc.2
    IL_00B4: nop
    IL_00B5: ldarg.2
    IL_00B6: ldc.i4.0
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: IL_3F
    IL_00BC: ldelem.r8
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x0400081D
    IL_00C3: ldc.i4.0
    IL_00C4: IL_22
    IL_00C5: IL_CD
    IL_00C6: IL_CC
    IL_00C7: IL_4C
    IL_00C8: IL_3E
    IL_00C9: ldelem.r8
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x0400081E
    IL_00D0: ldc.i4.0
    IL_00D1: IL_22
    IL_00D2: nop
    IL_00D3: nop
    IL_00D8: stsfld 0x7B02A03E
    IL_00D9: ldc.i4.5
    IL_00DA: ldloc.2
    IL_00DB: nop
    IL_00DC: ldarg.2
    IL_00DD: ldc.i4.1
    IL_00DE: IL_22
    IL_00DF: IL_29
    IL_00E0: sub
    IL_00E1: IL_8F
    IL_00E2: IL_3E
    IL_00E3: ldelem.r8
    IL_00E4: ldarg.0
    IL_00E9: ldfld 0x0400081C
    IL_00EA: ldc.i4.1
    IL_00EB: IL_22
    IL_00EC: IL_29
    IL_00ED: sub
    IL_00EE: IL_8F
    IL_00EF: IL_3E
    IL_00F0: ldelem.r8
    IL_00F1: ldarg.0
    IL_00F6: ldfld 0x0400081D
    IL_00F7: ldc.i4.1
    IL_00F8: IL_22
    IL_00F9: nop
    IL_00FA: nop
    IL_00FF: stsfld 0x7B02A03E
    IL_0100: ldc.i4.8
    IL_0101: ldloc.2
    IL_0102: nop
    IL_0103: ldarg.2
    IL_0104: ldc.i4.1
    IL_0105: IL_22
    IL_0106: nop
    IL_0107: nop
    IL_010C: stsfld 0x7B02A03E
    IL_010D: ldc.i4.5
    IL_010E: ldloc.2
    IL_010F: nop
    IL_0110: ldarg.2
    IL_0111: ldc.i4.2
    IL_0112: IL_22
    IL_0113: IL_8F
    IL_0114: IL_C2
    IL_0115: conv.u8
    IL_0116: IL_3E
    IL_0117: ldelem.r8
    IL_0118: ldarg.0
    IL_011D: ldfld 0x0400081C
    IL_011E: ldc.i4.2
    IL_011F: IL_22
    IL_0120: IL_29
    IL_0121: sub
    IL_0122: IL_8F
    IL_0123: IL_3E
    IL_0124: ldelem.r8
    IL_0125: ldarg.0
    IL_012A: ldfld 0x0400081D
    IL_012B: ldc.i4.2
    IL_012C: IL_22
    IL_012D: nop
    IL_012E: nop
    IL_0133: stsfld 0x7B02A03E
    IL_0134: ldc.i4.8
    IL_0135: ldloc.2
    IL_0136: nop
    IL_0137: ldarg.2
    IL_0138: ldc.i4.2
    IL_0139: IL_22
    IL_013A: nop
    IL_013B: nop
    IL_0140: stsfld 0x7B02A03E
    IL_0141: ldc.i4.5
    IL_0142: ldloc.2
    IL_0143: nop
    IL_0144: ldarg.2
    IL_0145: ldc.i4.3
    IL_0146: IL_22
    IL_0148: bne.un.s IL_017C
    IL_0149: conv.ovf.i4.un
    IL_014A: IL_3E
    IL_014B: ldelem.r8
    IL_014C: ldarg.0
    IL_0151: ldfld 0x0400081C
    IL_0152: ldc.i4.3
    IL_0153: IL_22
    IL_0154: nop
    IL_0155: nop
    IL_015A: stsfld 0x7B02A03E
    IL_015B: ldc.i4.7
    IL_015C: ldloc.2
    IL_015D: nop
    IL_015E: ldarg.2
    IL_015F: ldc.i4.3
    IL_0160: IL_22
    IL_0161: ldelem.i
    IL_0162: IL_99
    IL_0163: IL_99
    IL_0164: IL_3E
    IL_0165: ldelem.r8
    IL_0166: ldarg.0
    IL_016B: ldfld 0x0400081E
    IL_016C: ldc.i4.3
    IL_016D: IL_22
    IL_016E: nop
    IL_016F: nop
    IL_0174: stsfld 0x7B02A03E
    IL_0175: ldc.i4.5
    IL_0176: ldloc.2
    IL_0177: nop
    IL_0178: ldarg.2
    IL_0179: ldc.i4.4
    IL_017A: IL_22
    IL_017B: IL_CD
    IL_017C: IL_CC
    IL_017D: IL_CC
    IL_017E: IL_3E
    IL_017F: ldelem.r8
    IL_0180: ldarg.0
    IL_0185: ldfld 0x0400081C
    IL_0186: ldc.i4.4
    IL_0187: IL_22
    IL_0188: nop
    IL_0189: nop
    IL_018E: stsfld 0x7B02A03E
    IL_018F: ldc.i4.7
    IL_0190: ldloc.2
    IL_0191: nop
    IL_0192: ldarg.2
    IL_0193: ldc.i4.4
    IL_0194: IL_22
    IL_0195: nop
    IL_0196: nop
    IL_019B: stsfld 0x7B02A03E
    IL_019C: ldc.i4.8
    IL_019D: ldloc.2
    IL_019E: nop
    IL_019F: ldarg.2
    IL_01A0: ldc.i4.4
    IL_01A1: IL_22
    IL_01A2: nop
    IL_01A3: nop
    IL_01A8: stsfld 0x7B02A03E
    IL_01A9: ldc.i4.5
    IL_01AA: ldloc.2
    IL_01AB: nop
    IL_01AC: ldarg.2
    IL_01AD: ldc.i4.5
    IL_01AE: IL_22
    IL_01AF: IL_AE
    IL_01B2: starg 15969
    IL_01B3: ldelem.r8
    IL_01B4: ldarg.0
    IL_01B9: ldfld 0x0400081C
    IL_01BA: ldc.i4.5
    IL_01BB: IL_22
    IL_01BC: nop
    IL_01BD: nop
    IL_01C2: stsfld 0x7B02A03E
    IL_01C3: ldc.i4.7
    IL_01C4: ldloc.2
    IL_01C5: nop
    IL_01C6: ldarg.2
    IL_01C7: ldc.i4.5
    IL_01C8: IL_22
    IL_01C9: IL_29
    IL_01CA: sub
    IL_01CB: IL_8F
    IL_01CC: IL_3E
    IL_01CD: ldelem.r8
    IL_01CE: ldarg.0
    IL_01D3: ldfld 0x0400081E
    IL_01D4: ldc.i4.5
    IL_01D5: IL_22
    IL_01D6: nop
    IL_01D7: nop
    IL_01DC: stsfld 0x7B02A03E
    IL_01DD: ldc.i4.5
    IL_01DE: ldloc.2
    IL_01DF: nop
    IL_01E0: ldarg.2
    IL_01E1: ldc.i4.6
    IL_01E2: IL_22
    IL_01E4: bne.un.s IL_0218
    IL_01E5: conv.ovf.i4.un
    IL_01E6: IL_3E
    IL_01E7: ldelem.r8
    IL_01E8: ldarg.0
    IL_01ED: ldfld 0x0400081C
    IL_01EE: ldc.i4.6
    IL_01EF: IL_22
    IL_01F1: bne.un.s IL_0225
    IL_01F2: conv.ovf.i4.un
    IL_01F3: IL_3E
    IL_01F4: ldelem.r8
    IL_01F5: ldarg.0
    IL_01FA: ldfld 0x0400081D
    IL_01FB: ldc.i4.6
    IL_01FC: IL_22
    IL_01FD: nop
    IL_01FE: nop
    IL_0203: stsfld 0x7B02A03E
    IL_0204: ldc.i4.8
    IL_0205: ldloc.2
    IL_0206: nop
    IL_0207: ldarg.2
    IL_0208: ldc.i4.6
    IL_0209: IL_22
    IL_020A: nop
    IL_020B: nop
    IL_0210: stsfld 0x7B02A03E
    IL_0212: ldc.i4.s 8
    IL_0213: nop
    IL_0214: ldarg.2
    IL_0215: ldc.i4.0
    IL_0217: ldc.i4.s 40
    IL_0218: ldelem.i8
    IL_0219: ldarg.0
    IL_021E: ldfld 0x0400081F
    IL_021F: ldc.i4.1
    IL_0221: ldc.i4.s 40
    IL_0222: ldelem.i8
    IL_0223: ldarg.0
    IL_0228: ldfld 0x0400081F
    IL_0229: ldc.i4.2
    IL_022B: ldc.i4.s 30
    IL_022C: ldelem.i8
    IL_022D: ldarg.0
    IL_0232: ldfld 0x0400081F
    IL_0233: ldc.i4.3
    IL_0235: ldc.i4.s 80
    IL_0236: ldelem.i8
    IL_0237: ldarg.0
    IL_023C: ldfld 0x0400081F
    IL_023D: ldc.i4.4
    IL_023F: ldc.i4.s 60
    IL_0240: ldelem.i8
    IL_0241: ldarg.0
    IL_0246: ldfld 0x0400081F
    IL_0247: ldc.i4.5
    IL_0249: ldc.i4.s 80
    IL_024A: ldelem.i8
    IL_024B: ldarg.0
    IL_0250: ldfld 0x0400081F
    IL_0251: ldc.i4.6
    IL_0253: ldc.i4.s 60
    IL_0254: ldelem.i8
    IL_0255: ldarg.0
    IL_025A: ldfld 0x04000820
    IL_025B: ldc.i4.0
    IL_0260: ldc.i4 -200
    IL_0261: ldelem.i8
    IL_0262: ldarg.0
    IL_0267: ldfld 0x04000820
    IL_0268: ldc.i4.1
    IL_026A: ldc.i4.s -10
    IL_026B: ldelem.i8
    IL_026C: ldarg.0
    IL_0271: ldfld 0x04000820
    IL_0272: ldc.i4.2
    IL_0274: ldc.i4.s -10
    IL_0275: ldelem.i8
    IL_0276: ldarg.0
    IL_027B: ldfld 0x04000820
    IL_027C: ldc.i4.3
    IL_0281: ldc.i4 240
    IL_0282: ldelem.i8
    IL_0283: ldarg.0
    IL_0288: ldfld 0x04000820
    IL_0289: ldc.i4.4
    IL_028B: ldc.i4.s 20
    IL_028C: ldelem.i8
    IL_028D: ldarg.0
    IL_0292: ldfld 0x04000820
    IL_0293: ldc.i4.5
    IL_0298: ldc.i4 -160
    IL_0299: ldelem.i8
    IL_029A: ldarg.0
    IL_029F: ldfld 0x04000820
    IL_02A0: ldc.i4.6
    IL_02A2: ldc.i4.s -100
    IL_02A3: ldelem.i8
    IL_02A4: ret
    }

    public void FinishEfs() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_002F
    IL_0007: ldarg.0
    IL_000C: ldfld 0x0400082A
    IL_000D: ldloc.0
    IL_000E: ldelem.i
    IL_000F: conv.r8
    IL_0010: add
    IL_0011: nop
    IL_0012: nop
    IL_0014: br.s IL_0084
    IL_0015: IL_B8
    IL_0016: ldarg.0
    IL_0017: nop
    IL_0018: ldloc.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x0400082C
    IL_001F: ldloc.0
    IL_0020: ldelem.i
    IL_0021: conv.r8
    IL_0022: sub
    IL_0023: nop
    IL_0024: nop
    IL_0026: br.s IL_0096
    IL_0027: conv.i8
    IL_0028: ldarg.1
    IL_0029: nop
    IL_002A: ldloc.0
    IL_002B: ldloc.0
    IL_002C: ldc.i4.1
    IL_002D: IL_58
    IL_002E: stloc.0
    IL_002F: ldloc.0
    IL_0031: ldc.i4.s 10
    IL_0032: IL_3F
    IL_0037: ldtoken 0x2AFFFFFF
    }

    public void RestrictArea() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x0400083A
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_000D: stfld 0x0400083B
    IL_000E: ldarg.0
    IL_000F: ldarg.3
    IL_0014: stfld 0x0400083C
    IL_0015: ret
    }

    public void ScreamSFX() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000822
    IL_0006: ldc.i4.0
    IL_0007: ldc.i4.4
    IL_000C: call 0x0A000045
    IL_000D: ldelem.i
    IL_000E: stloc.0
    IL_000F: ldloc.0
    IL_0010: ret
    }

    public void BloodAttribute() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000832
    IL_0006: ldarg.1
    IL_000B: beq IL_0039
    IL_000C: ldc.i4.0
    IL_000D: stloc.0
    IL_0012: br IL_0031
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000829
    IL_0019: ldloc.0
    IL_001A: ldelem.i
    IL_001B: conv.r8
    IL_001C: stloc.3
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000810
    IL_0026: ldarg.1
    IL_0027: ldelem.i
    IL_0028: conv.r8
    IL_0029: IL_AD
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldloc.0
    IL_002E: ldc.i4.1
    IL_002F: IL_58
    IL_0030: stloc.0
    IL_0031: ldloc.0
    IL_0033: ldc.i4.s 10
    IL_0034: IL_3F
    IL_0035: IL_DA
    IL_0036: IL_FF
    IL_0037: IL_FF
    IL_0038: IL_FF
    IL_0039: ldarg.0
    IL_003A: ldarg.1
    IL_003F: stfld 0x04000832
    IL_0040: ret
    }

    public void EnemyDead() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000834
    IL_000A: brtrue IL_0022
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000838
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: ldarg.3
    IL_0015: ldarg.s 4
    IL_0017: ldarg.s 5
    IL_0018: conv.r8
    IL_0019: IL_F6
    IL_001A: ldarg.2
    IL_001B: nop
    IL_001C: ldloc.0
    IL_0021: br IL_0034
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000839
    IL_0028: ldarg.1
    IL_0029: ldarg.2
    IL_002A: ldarg.3
    IL_002C: ldarg.s 4
    IL_002E: ldarg.s 5
    IL_002F: conv.r8
    IL_0030: stloc.2
    IL_0031: ldarg.3
    IL_0032: nop
    IL_0033: ldloc.0
    IL_0035: ldarga.s 2
    IL_0036: ldc.i4.1
    IL_0037: IL_22
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_0040: call 0x0A00001A
    IL_0041: ldarg.0
    IL_0046: ldfld 0x0400082A
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000837
    IL_004D: ldelem.i
    IL_004E: conv.r8
    IL_004F: stloc.0
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldc.i4.1
    IL_0054: conv.r8
    IL_0055: stloc.1
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x0400082A
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000837
    IL_0065: ldelem.i
    IL_0066: ldarg.2
    IL_0068: ldarg.s 5
    IL_0069: IL_22
    IL_006A: IL_CD
    IL_006B: IL_CC
    IL_006C: IL_4C
    IL_006D: IL_3E
    IL_0072: call 0x0A000008
    IL_0077: call 0x0A000029
    IL_0078: conv.r8
    IL_0079: ldloc.3
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: ldarg.0
    IL_0082: ldfld 0x0400082A
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000837
    IL_0089: ldelem.i
    IL_008E: call 0x0A000007
    IL_008F: ldc.i4.0
    IL_0094: ldc.i4 360
    IL_0099: call 0x0A000045
    IL_009A: conv.i2
    IL_009F: call 0x0A000008
    IL_00A4: call 0x0A0001DA
    IL_00A5: conv.r8
    IL_00AA: call 0x020A0000
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x04000837
    IL_00B1: ldc.i4.1
    IL_00B2: IL_58
    IL_00B4: ldc.i4.s 10
    IL_00B5: mul
    IL_00BA: stfld 0x04000837
    IL_00BB: ret
    }

    public void CreatShadow() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0036
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000824
    IL_000D: ldloc.0
    IL_000E: ldelem.i
    IL_000F: conv.r8
    IL_0010: ldc.i4.2
    IL_0011: nop
    IL_0012: nop
    IL_0013: stloc.0
    IL_0014: stloc.1
    IL_0016: ldloca.s 1
    IL_001B: ldfld 0x0A000023
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_3130: switch (3139 cases)
    }

    public void DestroyShadow() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000824
    IL_0006: ldarg.1
    IL_0007: ldelem.i
    IL_0008: conv.r8
    IL_000A: beq.s IL_000B
    IL_000B: nop
    IL_000D: br.s IL_007D
    IL_000E: IL_36
    IL_000F: ldarg.2
    IL_0010: nop
    IL_0011: ldloc.0
    IL_0012: ret
    }

    public void SetDamageNum() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000827
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000831
    IL_000C: ldelem.i
    IL_000D: conv.r8
    IL_000E: mul
    IL_000F: nop
    IL_0010: nop
    IL_0012: br.s IL_0016
    IL_0013: ldarg.2
    IL_0014: ldarg.3
    IL_0015: conv.r8
    IL_0016: IL_4F
    IL_0017: ldarg.0
    IL_0018: nop
    IL_0019: ldloc.0
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04000831
    IL_0021: ldc.i4.1
    IL_0022: IL_58
    IL_0024: ldc.i4.s 10
    IL_0025: mul
    IL_002A: stfld 0x04000831
    IL_002B: ret
    }

    public void CreatBlood() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000829
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000836
    IL_000C: ldelem.i
    IL_000D: conv.r8
    IL_000E: stloc.0
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000829
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000836
    IL_0024: ldelem.i
    IL_0025: ldarg.1
    IL_002A: call 0x0A000007
    IL_002B: IL_22
    IL_002C: IL_CD
    IL_002D: IL_CC
    IL_002E: IL_4C
    IL_002F: IL_3D
    IL_0034: call 0x0A000008
    IL_0039: call 0x0A000029
    IL_003A: conv.r8
    IL_003B: ldloc.3
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.2
    IL_0044: call 0x0A00001B
    IL_0049: call 0x0A00001C
    IL_004E: brfalse IL_006C
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000829
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000836
    IL_005B: ldelem.i
    IL_005C: ldarg.2
    IL_0061: call 0x0A000043
    IL_0066: call 0x0A00001D
    IL_0067: conv.r8
    IL_006C: call 0x020A0000
    IL_0071: ldfld 0x04000828
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04000836
    IL_0078: ldelem.i
    IL_0079: conv.r8
    IL_007A: stloc.0
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: ldc.i4.1
    IL_007F: conv.r8
    IL_0080: stloc.1
    IL_0081: nop
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000828
    IL_008A: ldarg.0
    IL_008F: ldfld 0x04000836
    IL_0090: ldelem.i
    IL_0091: ldarg.1
    IL_0092: ldarg.2
    IL_0093: IL_22
    IL_0094: IL_CD
    IL_0095: IL_CC
    IL_0096: IL_CC
    IL_0097: IL_3D
    IL_009C: call 0x0A000008
    IL_00A1: call 0x0A000029
    IL_00A6: call 0x0A000007
    IL_00A7: IL_22
    IL_00A8: IL_CD
    IL_00A9: IL_CC
    IL_00AA: IL_4C
    IL_00AB: IL_3D
    IL_00B0: call 0x0A000008
    IL_00B5: call 0x0A000029
    IL_00B6: conv.r8
    IL_00B7: ldloc.3
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: stloc.0
    IL_00BB: ldarg.0
    IL_00C0: ldfld 0x04000828
    IL_00C1: ldarg.0
    IL_00C6: ldfld 0x04000836
    IL_00C7: ldelem.i
    IL_00CC: call 0x0A000007
    IL_00CD: ldc.i4.0
    IL_00D2: ldc.i4 360
    IL_00D7: call 0x0A000045
    IL_00D8: conv.i2
    IL_00DD: call 0x0A000008
    IL_00E2: call 0x0A0001DA
    IL_00E3: conv.r8
    IL_00E8: call 0x020A0000
    IL_00E9: ldarg.0
    IL_00EE: ldfld 0x04000836
    IL_00EF: ldc.i4.1
    IL_00F0: IL_58
    IL_00F2: ldc.i4.s 10
    IL_00F3: mul
    IL_00F8: stfld 0x04000836
    IL_00F9: ret
    }

    public void CreatBlood_Only() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000828
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000836
    IL_000C: ldelem.i
    IL_000D: conv.r8
    IL_000E: stloc.0
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000828
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000836
    IL_0024: ldelem.i
    IL_0025: ldarg.1
    IL_0026: ldarg.2
    IL_0027: IL_22
    IL_0028: IL_CD
    IL_0029: IL_CC
    IL_002A: IL_CC
    IL_002B: IL_BD
    IL_0030: call 0x0A000008
    IL_0035: call 0x0A000029
    IL_003A: call 0x0A000007
    IL_003B: IL_22
    IL_003C: IL_CD
    IL_003D: IL_CC
    IL_003E: IL_4C
    IL_003F: IL_3D
    IL_0044: call 0x0A000008
    IL_0049: call 0x0A000029
    IL_004A: conv.r8
    IL_004B: ldloc.3
    IL_004C: nop
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000828
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000836
    IL_005B: ldelem.i
    IL_0060: call 0x0A000007
    IL_0061: ldc.i4.0
    IL_0066: ldc.i4 360
    IL_006B: call 0x0A000045
    IL_006C: conv.i2
    IL_0071: call 0x0A000008
    IL_0076: call 0x0A0001DA
    IL_0077: conv.r8
    IL_007C: call 0x020A0000
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000836
    IL_0083: ldc.i4.1
    IL_0084: IL_58
    IL_0086: ldc.i4.s 10
    IL_0087: mul
    IL_008C: stfld 0x04000836
    IL_008D: ret
    }

    public void CreatGrabBlood() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000826
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
    IL_0016: ldfld 0x04000826
    IL_0017: ldarg.1
    IL_0018: conv.r8
    IL_0019: ldloc.3
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000826
    IL_0023: ldarg.2
    IL_0024: conv.r8
    IL_0029: call 0x2A0A0000
    }

    public void SplitOn() {
    IL_0004: call 0x0A000057
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0008: stloc.s 6
    IL_000A: ldloc.s 6
    IL_000D: ldarg 4
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.3
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.4
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_44
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0024: br IL_0079
    IL_0029: call 0x0A0000AA
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_3F
    IL_0033: call 0x0A000083
    IL_0034: stloc.0
    IL_0039: br IL_0079
    IL_003E: call 0x0A0000FA
    IL_003F: IL_22
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0043: IL_3F
    IL_0048: call 0x0A000083
    IL_0049: stloc.0
    IL_004E: br IL_0079
    IL_0053: call 0x0A000057
    IL_0054: IL_22
    IL_0055: nop
    IL_0056: nop
    IL_0057: nop
    IL_0058: IL_3F
    IL_005D: call 0x0A000083
    IL_005E: stloc.0
    IL_0063: br IL_0079
    IL_0068: call 0x0A000082
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_3F
    IL_0072: call 0x0A000083
    IL_0073: stloc.0
    IL_0078: br IL_0079
    IL_007D: ldstr 0x70001E71
    IL_0082: newobj 0x0A00013F
    IL_0083: stloc.1
    IL_0084: ldloc.1
    IL_0085: conv.r8
    IL_0086: IL_43
    IL_0087: nop
    IL_0088: nop
    IL_008A: br.s IL_0097
    IL_008F: newobj 0x0A000145
    IL_0090: stloc.3
    IL_0091: ldloc.1
    IL_0092: conv.r8
    IL_0095: ldloca 0
    IL_0097: br.s IL_00BE
    IL_0098: IL_22
    IL_0099: ldelem.i
    IL_009A: IL_99
    IL_009B: ldc.i4.3
    IL_009C: IL_3E
    IL_009D: IL_22
    IL_009E: IL_CD
    IL_009F: IL_CC
    IL_00A0: IL_4C
    IL_00A1: IL_3E
    IL_00A6: call 0x0A000075
    IL_00A8: stloc.s 4
    IL_00A9: ldloc.3
    IL_00AA: ldc.i4.4
    IL_00AF: newarr 0x01000007
    IL_00B0: dup
    IL_00B1: ldc.i4.0
    IL_00B2: IL_8F
    IL_00B3: ldloc.1
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: IL_01
    IL_00B8: ldloc.s 4
    IL_00B9: shl
    IL_00BA: IL_22
    IL_00BB: stloc.0
    IL_00BC: IL_D7
    IL_00BD: stelem.i
    IL_00C2: beq IL_767304D4
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: stloc.0
    IL_00C6: IL_81
    IL_00C7: ldloc.1
    IL_00C8: nop
    IL_00C9: nop
    IL_00CA: IL_01
    IL_00CB: dup
    IL_00CC: ldc.i4.1
    IL_00CD: IL_8F
    IL_00CE: ldloc.1
    IL_00CF: nop
    IL_00D0: nop
    IL_00D1: IL_01
    IL_00D3: ldloc.s 4
    IL_00D4: IL_22
    IL_00D5: stloc.0
    IL_00D6: IL_D7
    IL_00D7: stelem.i
    IL_00DC: beq IL_767304EE
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: stloc.0
    IL_00E0: IL_81
    IL_00E1: ldloc.1
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: IL_01
    IL_00E5: dup
    IL_00E6: ldc.i4.2
    IL_00E7: IL_8F
    IL_00E8: ldloc.1
    IL_00E9: nop
    IL_00EA: nop
    IL_00EB: IL_01
    IL_00ED: ldloc.s 4
    IL_00EE: shl
    IL_00EF: IL_22
    IL_00F0: stloc.0
    IL_00F1: IL_D7
    IL_00F2: stelem.i
    IL_00F7: beq IL_73650509
    IL_00F8: conv.r.un
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: stloc.0
    IL_00FC: IL_81
    IL_00FD: ldloc.1
    IL_00FE: nop
    IL_00FF: nop
    IL_0100: IL_01
    IL_0101: dup
    IL_0102: ldc.i4.3
    IL_0103: IL_8F
    IL_0104: ldloc.1
    IL_0105: nop
    IL_0106: nop
    IL_0107: IL_01
    IL_0109: ldloc.s 4
    IL_010A: IL_22
    IL_010B: stloc.0
    IL_010C: IL_D7
    IL_010D: stelem.i
    IL_0112: beq IL_73650524
    IL_0113: conv.r.un
    IL_0114: nop
    IL_0115: nop
    IL_0116: stloc.0
    IL_0117: IL_81
    IL_0118: ldloc.1
    IL_0119: nop
    IL_011A: nop
    IL_011B: IL_01
    IL_011C: conv.r8
    IL_011D: IL_89
    IL_011E: IL_01
    IL_011F: nop
    IL_0120: stloc.0
    IL_0121: ldloc.3
    IL_0126: ldstr 0x7002283C
    IL_0127: conv.r8
    IL_0128: IL_DC
    IL_0129: IL_01
    IL_012A: nop
    IL_012B: stloc.0
    IL_012C: ldloc.3
    IL_012D: ldc.i4.4
    IL_0132: newarr 0x01000014
    IL_0133: dup
    IL_0134: ldc.i4.0
    IL_0135: IL_8F
    IL_0136: ldnull
    IL_0137: nop
    IL_0138: nop
    IL_0139: IL_01
    IL_013E: call 0x0A0000AA
    IL_013F: IL_22
    IL_0140: nop
    IL_0141: nop
    IL_0142: nop
    IL_0143: IL_3F
    IL_0148: call 0x0A000083
    IL_0149: ldloc.0
    IL_014E: call 0x0A0000AB
    IL_014F: IL_81
    IL_0150: ldnull
    IL_0151: nop
    IL_0152: nop
    IL_0153: IL_01
    IL_0154: dup
    IL_0155: ldc.i4.1
    IL_0156: IL_8F
    IL_0157: ldnull
    IL_0158: nop
    IL_0159: nop
    IL_015A: IL_01
    IL_015F: call 0x0A0000FA
    IL_0160: IL_22
    IL_0161: nop
    IL_0162: nop
    IL_0163: nop
    IL_0164: IL_3F
    IL_0169: call 0x0A000083
    IL_016A: ldloc.0
    IL_016F: call 0x0A0000AB
    IL_0170: IL_81
    IL_0171: ldnull
    IL_0172: nop
    IL_0173: nop
    IL_0174: IL_01
    IL_0175: dup
    IL_0176: ldc.i4.2
    IL_0177: IL_8F
    IL_0178: ldnull
    IL_0179: nop
    IL_017A: nop
    IL_017B: IL_01
    IL_0180: call 0x0A000057
    IL_0181: ldloc.0
    IL_0186: call 0x0A0000AB
    IL_0187: IL_81
    IL_0188: ldnull
    IL_0189: nop
    IL_018A: nop
    IL_018B: IL_01
    IL_018C: dup
    IL_018D: ldc.i4.3
    IL_018E: IL_8F
    IL_018F: ldnull
    IL_0190: nop
    IL_0191: nop
    IL_0192: IL_01
    IL_0197: call 0x0A000082
    IL_0198: IL_22
    IL_0199: nop
    IL_019A: nop
    IL_019B: nop
    IL_019C: IL_3F
    IL_01A1: call 0x0A000083
    IL_01A2: ldloc.0
    IL_01A7: call 0x0A0000AB
    IL_01A8: IL_81
    IL_01A9: ldnull
    IL_01AA: nop
    IL_01AB: nop
    IL_01AC: IL_01
    IL_01AD: conv.r8
    IL_01AE: IL_AC
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: stloc.0
    IL_01B2: ldloc.3
    IL_01B3: ldc.i4.6
    IL_01B8: newarr 0x0100000B
    IL_01B9: dup
    IL_01BE: ldtoken 0x040010BB
    IL_01C3: call 0x0A00018C
    IL_01C4: conv.r8
    IL_01C9: newarr 0x090A0001
    IL_01CA: conv.r8
    IL_01CB: len
    IL_01CC: IL_01
    IL_01CD: nop
    IL_01CE: stloc.0
    IL_01CF: ldloc.1
    IL_01D0: conv.r8
    IL_01D1: ldind.ref
    IL_01D2: IL_01
    IL_01D3: nop
    IL_01D4: stloc.0
    IL_01D6: stloc.s 5
    IL_01D8: ldloc.s 5
    IL_01D9: ldc.i4.0
    IL_01DA: conv.r8
    IL_01DB: IL_C5
    IL_01DC: IL_01
    IL_01DD: nop
    IL_01DE: stloc.0
    IL_01E0: ldloc.s 5
    IL_01E1: ldc.i4.0
    IL_01E2: conv.r8
    IL_01E3: IL_C6
    IL_01E4: IL_01
    IL_01E5: nop
    IL_01E6: stloc.0
    IL_01E8: ldloc.s 5
    IL_01E9: ldarg.0
    IL_01EE: ldfld 0x04000811
    IL_01EF: conv.r8
    IL_01F0: stind.i
    IL_01F1: IL_01
    IL_01F2: nop
    IL_01F3: stloc.0
    IL_01F5: ldloc.s 5
    IL_01F6: conv.r8
    IL_01F7: neg
    IL_01F8: nop
    IL_01F9: nop
    IL_01FA: stloc.0
    IL_01FF: ldc.i4 2002
    IL_0200: conv.r8
    IL_0201: IL_77
    IL_0202: IL_01
    IL_0203: nop
    IL_0204: stloc.0
    IL_0205: ldloc.2
    IL_0206: ldloc.3
    IL_0207: conv.r8
    IL_0208: IL_41
    IL_0209: IL_01
    IL_020A: nop
    IL_020B: stloc.0
    IL_020C: ldloc.1
    IL_0211: ldstr 0x70022850
    IL_0212: conv.r8
    IL_0213: IL_C7
    IL_0214: IL_01
    IL_0215: nop
    IL_0216: stloc.0
    IL_0217: pop
    IL_0218: ldloc.1
    IL_0219: conv.r8
    IL_021A: ldarg.3
    IL_021B: nop
    IL_021C: nop
    IL_021D: stloc.0
    IL_021E: ret
    }

    public void DirectionArrow() {
    IL_0000: ret
    }

    public void SetHpbar() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_003D
    IL_0007: ldarg.0
    IL_000C: ldfld 0x0400082B
    IL_000D: ldloc.0
    IL_000E: ldelem.i
    IL_000F: conv.r8
    IL_0010: ldc.i4.2
    IL_0011: nop
    IL_0012: nop
    IL_0013: stloc.0
    IL_0014: stloc.1
    IL_0016: ldloca.s 1
    IL_001B: ldfld 0x0A000023
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_4D30: switch (4931 cases)
    }

    public void CreatHpbar() {
    IL_0004: ldstr 0x70022864
    IL_0009: newobj 0x0A00013F
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: conv.r8
    IL_000D: IL_43
    IL_000E: nop
    IL_000F: nop
    IL_0011: br.s IL_001D
    IL_0016: newobj 0x0A000145
    IL_0017: stloc.2
    IL_0018: ldloc.0
    IL_0019: conv.r8
    IL_001C: ldloca 0
    IL_001E: br.s IL_0045
    IL_001F: ldloc.2
    IL_0020: ldc.i4.4
    IL_0025: newarr 0x01000007
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_0028: IL_8F
    IL_0029: ldloc.1
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_01
    IL_002E: ldarga.s 1
    IL_0033: ldfld 0x0A000059
    IL_0034: shl
    IL_0036: ldarga.s 1
    IL_003B: ldfld 0x0A00005A
    IL_003C: IL_22
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0045: newobj 0x0A000076
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: IL_3F
    IL_004F: call 0x0A000008
    IL_0050: IL_81
    IL_0051: ldloc.1
    IL_0052: nop
    IL_0053: nop
    IL_0054: IL_01
    IL_0055: dup
    IL_0056: ldc.i4.1
    IL_0057: IL_8F
    IL_0058: ldloc.1
    IL_0059: nop
    IL_005A: nop
    IL_005B: IL_01
    IL_005D: ldarga.s 1
    IL_0062: ldfld 0x0A000059
    IL_0064: ldarga.s 1
    IL_0069: ldfld 0x0A00005A
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_006D: nop
    IL_006E: nop
    IL_0073: newobj 0x0A000076
    IL_0074: IL_22
    IL_0075: nop
    IL_0076: nop
    IL_0077: nop
    IL_0078: IL_3F
    IL_007D: call 0x0A000008
    IL_007E: IL_81
    IL_007F: ldloc.1
    IL_0080: nop
    IL_0081: nop
    IL_0082: IL_01
    IL_0083: dup
    IL_0084: ldc.i4.2
    IL_0085: IL_8F
    IL_0086: ldloc.1
    IL_0087: nop
    IL_0088: nop
    IL_0089: IL_01
    IL_008B: ldarga.s 1
    IL_0090: ldfld 0x0A000059
    IL_0091: shl
    IL_0093: ldarga.s 1
    IL_0098: ldfld 0x0A00005A
    IL_0099: shl
    IL_009A: IL_22
    IL_009B: stloc.0
    IL_009C: IL_D7
    IL_009D: stelem.i
    IL_009E: IL_BC
    IL_00A3: newobj 0x0A000076
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: IL_3F
    IL_00AD: call 0x0A000008
    IL_00AE: IL_81
    IL_00AF: ldloc.1
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: IL_01
    IL_00B3: dup
    IL_00B4: ldc.i4.3
    IL_00B5: IL_8F
    IL_00B6: ldloc.1
    IL_00B7: nop
    IL_00B8: nop
    IL_00B9: IL_01
    IL_00BB: ldarga.s 1
    IL_00C0: ldfld 0x0A000059
    IL_00C2: ldarga.s 1
    IL_00C7: ldfld 0x0A00005A
    IL_00C8: shl
    IL_00C9: IL_22
    IL_00CA: stloc.0
    IL_00CB: IL_D7
    IL_00CC: stelem.i
    IL_00CD: IL_BC
    IL_00D2: newobj 0x0A000076
    IL_00D3: IL_22
    IL_00D4: nop
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: IL_3F
    IL_00DC: call 0x0A000008
    IL_00DD: IL_81
    IL_00DE: ldloc.1
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_01
    IL_00E2: conv.r8
    IL_00E3: IL_89
    IL_00E4: IL_01
    IL_00E5: nop
    IL_00E6: stloc.0
    IL_00E7: IL_22
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: nop
    IL_00EB: nop
    IL_00EC: stloc.3
    IL_00ED: ldarg.3
    IL_00F2: brfalse IL_00F9
    IL_00F3: IL_22
    IL_00F4: nop
    IL_00F5: nop
    IL_682035F6: switch (436735295 cases)
    }

    public void SetItemBox() {
    IL_0000: ldc.i4.0
    IL_0005: ldc.i4 1000
    IL_000A: call 0x0A000045
    IL_000B: stloc.0
    IL_000C: ldc.i4.m1
    IL_000D: stloc.1
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000835
    IL_0018: brfalse IL_00AB
    IL_0019: ldloc.0
    IL_001B: ldc.i4.s 20
    IL_001C: IL_3C
    IL_001F: ldloc 0
    IL_0020: nop
    IL_0022: ldc.i4.s 100
    IL_0024: ldc.i4.s 120
    IL_0029: call 0x0A000045
    IL_002A: stloc.1
    IL_002B: ldarg.0
    IL_0030: ldfld 0x0400082C
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000830
    IL_0037: ldelem.i
    IL_0038: conv.r8
    IL_0039: stloc.3
    IL_003A: nop
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000813
    IL_0043: conv.r8
    IL_0044: IL_AD
    IL_0045: nop
    IL_0046: nop
    IL_0047: stloc.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x0400080E
    IL_004E: ldarg.2
    IL_004F: conv.r8
    IL_0050: ldloc.3
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: ldarg.0
    IL_0059: ldfld 0x0400080E
    IL_005A: conv.r8
    IL_005B: IL_B0
    IL_005C: nop
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: conv.r8
    IL_0060: IL_B1
    IL_0061: nop
    IL_0062: nop
    IL_0063: stloc.0
    IL_0068: br IL_00A6
    IL_0069: ldloc.0
    IL_006B: ldc.i4.s 70
    IL_006C: IL_3C
    IL_006E: bne.un.s IL_006F
    IL_006F: nop
    IL_0070: nop
    IL_0071: ldarg.0
    IL_0076: ldfld 0x0400082C
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000830
    IL_007D: ldelem.i
    IL_007E: conv.r8
    IL_007F: stloc.3
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000812
    IL_0089: conv.r8
    IL_008A: IL_AD
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: ldloc.0
    IL_0090: ldc.i4.s 35
    IL_0091: IL_3C
    IL_0092: ldloc.1
    IL_0093: nop
    IL_0094: nop
    IL_0095: nop
    IL_0096: ldc.i4.2
    IL_0097: stloc.1
    IL_009C: br IL_009F
    IL_009D: ldc.i4.1
    IL_009E: stloc.1
    IL_00A3: br IL_00A6
    IL_00A4: ldc.i4.m1
    IL_00A5: stloc.1
    IL_00AA: br IL_0105
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x04000834
    IL_00B5: brtrue IL_0105
    IL_00B6: ldloc.0
    IL_00B7: ldc.i4.2
    IL_00B8: IL_3C
    IL_00B9: ldloc.1
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: nop
    IL_00BD: ldc.i4.4
    IL_00BE: stloc.1
    IL_00C3: br IL_0105
    IL_00C4: ldloc.0
    IL_00C6: ldc.i4.s 30
    IL_00C7: IL_3C
    IL_00C8: ldloc.1
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: nop
    IL_00CC: ldc.i4.3
    IL_00CD: stloc.1
    IL_00D2: br IL_0105
    IL_00D3: ldloc.0
    IL_00D5: ldc.i4.s 70
    IL_00D6: IL_3C
    IL_00D7: ldloc.1
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: nop
    IL_00DB: ldc.i4.2
    IL_00DC: stloc.1
    IL_00E1: br IL_0105
    IL_00E2: ldloc.0
    IL_00E4: ldc.i4.s 120
    IL_00E5: IL_3C
    IL_00E6: ldloc.1
    IL_00E7: nop
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: ldc.i4.1
    IL_00EB: stloc.1
    IL_00F0: br IL_0105
    IL_00F1: ldloc.0
    IL_00F6: ldc.i4 200
    IL_00F7: IL_3C
    IL_00F8: ldloc.1
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: nop
    IL_00FC: ldc.i4.0
    IL_00FD: stloc.1
    IL_0102: br IL_0105
    IL_0103: ldc.i4.m1
    IL_0104: stloc.1
    IL_0105: ldloc.1
    IL_0106: ldc.i4.0
    IL_0107: IL_3F
    IL_0108: IL_99
    IL_0109: IL_01
    IL_010A: nop
    IL_010B: nop
    IL_0110: call 0x0A000057
    IL_0111: stloc.2
    IL_0112: IL_22
    IL_0113: nop
    IL_0114: nop
    IL_0115: nop
    IL_0116: nop
    IL_0117: stloc.3
    IL_0118: ldloc.1
    IL_011A: ldc.i4.s 100
    IL_011B: IL_3F
    IL_011D: beq.s IL_011E
    IL_011E: nop
    IL_011F: nop
    IL_0120: ldloc.1
    IL_0122: ldc.i4.s 100
    IL_0123: IL_59
    IL_0125: stloc.s 4
    IL_0127: ldloca.s 2
    IL_0128: IL_22
    IL_0129: nop
    IL_012A: nop
    IL_012B: nop
    IL_012C: IL_3E
    IL_012E: ldloc.s 4
    IL_012F: ldc.i4.8
    IL_0130: mul
    IL_0131: conv.i2
    IL_0132: IL_5A
    IL_0133: IL_22
    IL_0134: nop
    IL_0135: nop
    IL_0136: nop
    IL_0137: IL_3E
    IL_0139: ldloc.s 4
    IL_013A: ldc.i4.8
    IL_013B: add
    IL_013C: conv.i2
    IL_013D: IL_5A
    IL_0142: call 0x0A000038
    IL_0143: IL_22
    IL_0144: nop
    IL_0145: nop
    IL_0146: nop
    IL_0147: IL_3E
    IL_0148: stloc.3
    IL_014D: br IL_017D
    IL_014E: ldloc.1
    IL_014F: ldc.i4.4
    IL_0150: mul
    IL_0152: stloc.s 5
    IL_0153: ldloc.1
    IL_0154: ldc.i4.4
    IL_0155: add
    IL_0157: stloc.s 6
    IL_0159: ldloca.s 2
    IL_015B: ldloc.s 5
    IL_015C: conv.i2
    IL_015D: IL_22
    IL_015E: nop
    IL_015F: nop
    IL_0164: stsfld 0x00225A3E
    IL_0165: nop
    IL_1AC184666: switch (1795559743 cases)
    }

    public void CreatItemBox() {
    IL_0004: ldstr 0x7002289A
    IL_0009: newobj 0x0A00013F
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: conv.r8
    IL_000D: IL_43
    IL_000E: nop
    IL_000F: nop
    IL_0011: br.s IL_001D
    IL_0016: newobj 0x0A000145
    IL_0017: stloc.2
    IL_0018: ldloc.0
    IL_0019: conv.r8
    IL_001C: ldloca 0
    IL_001E: br.s IL_0045
    IL_001F: ldloc.2
    IL_0020: ldc.i4.4
    IL_0025: newarr 0x01000007
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_0028: IL_8F
    IL_0029: ldloc.1
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_01
    IL_002D: IL_22
    IL_002E: IL_29
    IL_002F: sub
    IL_0031: ldarga.s 189
    IL_0032: IL_22
    IL_0033: IL_CD
    IL_0034: IL_CC
    IL_0035: IL_4C
    IL_0036: IL_3D
    IL_0037: IL_22
    IL_0038: IL_CD
    IL_0039: IL_CC
    IL_003A: IL_4C
    IL_003B: IL_3D
    IL_0040: newobj 0x0A000076
    IL_0041: IL_81
    IL_0042: ldloc.1
    IL_0043: nop
    IL_0044: nop
    IL_0045: IL_01
    IL_0046: dup
    IL_0047: ldc.i4.1
    IL_0048: IL_8F
    IL_0049: ldloc.1
    IL_004A: nop
    IL_004B: nop
    IL_004C: IL_01
    IL_004D: IL_22
    IL_004E: IL_29
    IL_004F: sub
    IL_0051: ldarga.s 61
    IL_0052: IL_22
    IL_0053: IL_CD
    IL_0054: IL_CC
    IL_0055: IL_4C
    IL_0056: IL_3D
    IL_0057: IL_22
    IL_0058: IL_CD
    IL_0059: IL_CC
    IL_005A: IL_4C
    IL_005B: IL_3D
    IL_0060: newobj 0x0A000076
    IL_0061: IL_81
    IL_0062: ldloc.1
    IL_0063: nop
    IL_0064: nop
    IL_0065: IL_01
    IL_0066: dup
    IL_0067: ldc.i4.2
    IL_0068: IL_8F
    IL_0069: ldloc.1
    IL_006A: nop
    IL_006B: nop
    IL_006C: IL_01
    IL_0071: call 0x0A000062
    IL_0072: IL_22
    IL_0073: IL_29
    IL_0074: sub
    IL_0076: ldarga.s 189
    IL_007B: call 0x0A000008
    IL_007C: IL_81
    IL_007D: ldloc.1
    IL_007E: nop
    IL_007F: nop
    IL_0080: IL_01
    IL_0081: dup
    IL_0082: ldc.i4.3
    IL_0083: IL_8F
    IL_0084: ldloc.1
    IL_0085: nop
    IL_0086: nop
    IL_0087: IL_01
    IL_008C: call 0x0A000062
    IL_008D: IL_22
    IL_008E: IL_29
    IL_008F: sub
    IL_0091: ldarga.s 61
    IL_0096: call 0x0A000008
    IL_0097: IL_81
    IL_0098: ldloc.1
    IL_0099: nop
    IL_009A: nop
    IL_009B: IL_01
    IL_009C: conv.r8
    IL_009D: IL_89
    IL_009E: IL_01
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: ldloc.2
    IL_00A2: ldc.i4.4
    IL_00A7: newarr 0x01000014
    IL_00A8: dup
    IL_00A9: ldc.i4.0
    IL_00AA: IL_8F
    IL_00AB: ldnull
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: IL_01
    IL_00B3: call 0x0A0000AA
    IL_00B4: IL_81
    IL_00B5: ldnull
    IL_00B6: nop
    IL_00B7: nop
    IL_00B8: IL_01
    IL_00B9: dup
    IL_00BA: ldc.i4.1
    IL_00BB: IL_8F
    IL_00BC: ldnull
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: IL_01
    IL_00C4: call 0x0A0000FA
    IL_00C5: IL_81
    IL_00C6: ldnull
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: IL_01
    IL_00CA: dup
    IL_00CB: ldc.i4.2
    IL_00CC: IL_8F
    IL_00CD: ldnull
    IL_00CE: nop
    IL_00CF: nop
    IL_00D0: IL_01
    IL_00D5: call 0x0A000057
    IL_00D6: IL_81
    IL_00D7: ldnull
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: IL_01
    IL_00DB: dup
    IL_00DC: ldc.i4.3
    IL_00DD: IL_8F
    IL_00DE: ldnull
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_01
    IL_00E6: call 0x0A000082
    IL_00E7: IL_81
    IL_00E8: ldnull
    IL_00E9: nop
    IL_00EA: nop
    IL_00EB: IL_01
    IL_00EC: conv.r8
    IL_00ED: IL_AC
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: stloc.0
    IL_00F1: ldloc.0
    IL_00F2: conv.r8
    IL_00F3: ldind.ref
    IL_00F4: IL_01
    IL_00F5: nop
    IL_00F6: stloc.0
    IL_00F7: stloc.3
    IL_00F8: ldloc.3
    IL_00F9: ldc.i4.0
    IL_00FA: conv.r8
    IL_00FB: IL_C5
    IL_00FC: IL_01
    IL_00FD: nop
    IL_00FE: stloc.0
    IL_00FF: ldloc.3
    IL_0100: ldc.i4.0
    IL_0101: conv.r8
    IL_0102: IL_C6
    IL_0103: IL_01
    IL_0104: nop
    IL_0105: stloc.0
    IL_0106: ldloc.3
    IL_0107: ldarg.0
    IL_010C: ldfld 0x04000812
    IL_010D: conv.r8
    IL_010E: stind.i
    IL_010F: IL_01
    IL_0110: nop
    IL_0111: stloc.0
    IL_0112: ldloc.0
    IL_0113: conv.r8
    IL_0114: IL_58
    IL_0115: nop
    IL_0116: nop
    IL_0118: br.s IL_012C
    IL_0119: ldarg.2
    IL_011B: ldloc.s 4
    IL_011C: IL_22
    IL_011D: stloc.0
    IL_011E: IL_D7
    IL_011F: stelem.i
    IL_0120: IL_3D
    IL_0121: conv.r8
    IL_0122: IL_CB
    IL_0123: nop
    IL_0124: nop
    IL_0125: stloc.0
    IL_0127: ldloc.s 4
    IL_0128: ldc.i4.0
    IL_0129: conv.r8
    IL_012B: ldc.i4.s 0
    IL_012C: nop
    IL_012D: stloc.0
    IL_012F: ldloc.s 4
    IL_0130: ldc.i4.1
    IL_0131: conv.r8
    IL_0132: conv.ovf.i4.un
    IL_0133: nop
    IL_0134: nop
    IL_0135: stloc.0
    IL_0136: ldloc.2
    IL_0137: ldc.i4.6
    IL_013C: newarr 0x0100000B
    IL_013D: dup
    IL_0142: ldtoken 0x040010BD
    IL_0147: call 0x0A00018C
    IL_0148: conv.r8
    IL_014D: newarr 0x080A0001
    IL_014E: conv.r8
    IL_014F: len
    IL_0150: IL_01
    IL_0151: nop
    IL_0152: stloc.0
    IL_0153: ldloc.1
    IL_0154: ldloc.2
    IL_0155: conv.r8
    IL_0156: IL_41
    IL_0157: IL_01
    IL_0158: nop
    IL_0159: stloc.0
    IL_015A: ldarg.0
    IL_015F: ldfld 0x0400082D
    IL_0160: ldarg.0
    IL_0165: ldfld 0x04000830
    IL_0166: ldloc.2
    IL_016B: stelem 0x307B2502
    IL_016C: ldloc.2
    IL_016D: nop
    IL_016E: ldarg.2
    IL_016F: ldc.i4.1
    IL_0170: IL_58
    IL_0175: stfld 0x04000830
    IL_0176: ldloc.0
    IL_0177: conv.r8
    IL_0178: ldarg.3
    IL_0179: nop
    IL_017A: nop
    IL_017B: stloc.0
    IL_017C: ldarg.0
    IL_0181: ldfld 0x04000823
    IL_0182: conv.r8
    IL_0183: IL_4E
    IL_0184: nop
    IL_0185: nop
    IL_0186: stloc.0
    IL_0187: ldloc.0
    IL_0189: ldc.i4.s 13
    IL_018A: conv.r8
    IL_018B: ldc.i4.m1
    IL_018C: nop
    IL_018D: nop
    IL_018E: stloc.0
    IL_018F: ldloc.0
    IL_0194: ldstr 0x700228AA
    IL_0195: conv.r8
    IL_0196: IL_C7
    IL_0197: IL_01
    IL_0198: nop
    IL_0199: stloc.0
    IL_019A: pop
    IL_019B: ldloc.0
    IL_019C: conv.r8
    IL_019D: ldarg.3
    IL_019E: nop
    IL_019F: nop
    IL_01A0: stloc.0
    IL_01A1: ret
    }

    }}
