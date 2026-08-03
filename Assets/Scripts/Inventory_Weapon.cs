// Namespace: 
// Type: Inventory_Weapon

    public class Inventory_Weapon {{

    private object popupOn;
    public object basicSkin;
    public object bg_black;
    public object bg_weapon;
    public object bg_weapon_l;
    public object titlebase;
    public object titlebase2;
    public object icon_lock;
    public object icon_unlock;
    public object icon_coin;
    public object icon_jade;
    public object pop_blank2;
    public object weapon_kindicon;
    public object weaponicon;
    public object armoricon;
    private object bottom_icon;
    public object c_equip;
    public object pop_blank;
    public object star_grade;
    public object icon_new;
    public object bt_yesno;
    public object bt_equip;
    public object erase;
    private object imagemovefinish;
    private object getitem;
    private object nextstart;
    private object bg_posX_r;
    private object icon_posY;
    private object selectslot;
    private object getitem_seed;
    private object slot_item;
    private object cur_difficulty;
    private object cur_stage_index;
    private object cur_item;
    private object confirm;
    private object nextdelay;
    private object b_delay;
    private object f_delay;
    private object stopgui;
    private object rewardkind;
    private object getweapon_meshkind;
    private object getitem_grade;
    private object getweapon_name;
    private object getweapon_maxatk;
    private object getweapon_minatk;
    private object getweapon_kind;
    private object getweapon_spd;
    private object getweapon_special;
    private object getweapon_special_txt;
    private object getweapon_index;
    private object getequip_hp;
    private object getequip_index;
    private object getequip_special;
    private object selequip_index;
    private object selequip_special;
    private object selequip_hp;
    private object selweapon_index;
    private object selweapon_grade;
    private object selweapon_name;
    private object selweapon_maxatk;
    private object selweapon_minatk;
    private object selweapon_kind;
    private object selweapon_spd;
    private object selweapon_special_txt;
    private object sellcost_get;
    private object sellcost_sel;
    private object icon_size;
    private object icon_delay;
    private object posX;
    private object posY;
    private object posX2;
    private object posY2;
    private object language;
    private object _getslot;
    private object script_ui;
    private object script_name;
    private object script_weaponstat;
    private object item_seed;
    private object weapon_plusup;

    public Inventory_Weapon() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000752
    IL_000C: ldarg.0
    IL_000E: ldc.i4.s 20
    IL_0013: newarr 0x0100003C
    IL_0018: stfld 0x04000753
    IL_0019: ldarg.0
    IL_001A: ldc.i4.7
    IL_001F: newarr 0x0100003C
    IL_0024: stfld 0x04000754
    IL_0025: ldarg.0
    IL_0026: ldc.i4.6
    IL_002B: newarr 0x0100000B
    IL_0030: stfld 0x04000755
    IL_0031: ldarg.0
    IL_0036: ldc.i4 480
    IL_003B: stfld 0x04000760
    IL_003C: ldarg.0
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0040: ldelem.r8
    IL_0041: IL_43
    IL_0046: stfld 0x04000761
    IL_0047: ldarg.0
    IL_0048: ldc.i4.m1
    IL_004D: stfld 0x04000762
    IL_004E: ldarg.0
    IL_004F: ldc.i4.3
    IL_0054: stfld 0x04000764
    IL_0055: ldarg.0
    IL_0056: IL_22
    IL_0057: nop
    IL_0058: nop
    IL_0059: nop
    IL_005A: IL_3F
    IL_005F: stfld 0x04000769
    IL_0060: ldarg.0
    IL_0062: ldc.i4.s 32
    IL_0067: stfld 0x04000788
    IL_0068: ldarg.0
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: IL_E0
    IL_006D: IL_42
    IL_0072: stfld 0x0400078A
    IL_0073: ldarg.0
    IL_0075: ldc.i4.s 90
    IL_007A: stfld 0x0400078B
    IL_007B: ldarg.0
    IL_007C: ldc.i4.m1
    IL_0081: stfld 0x0400078F
    IL_0082: ldarg.0
    IL_0084: ldc.i4.s 26
    IL_0089: newarr 0x0100000B
    IL_008E: stfld 0x04000793
    IL_008F: ldarg.0
    IL_0091: ldc.i4.s 26
    IL_0096: newarr 0x0100000B
    IL_009B: stfld 0x04000794
    IL_009C: ldarg.0
    IL_00A1: call 0x0A000001
    IL_00A2: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000CDD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000766
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000BD5
    IL_001A: call 0x0A000004
    IL_001B: conv.r8
    IL_0020: brtrue IL_7D2B0021
    IL_0025: ldobj 0x02040007
    IL_002A: ldstr 0x70000BB3
    IL_002F: call 0x0A000095
    IL_0034: stfld 0x0400078E
    IL_0035: ldarg.0
    IL_0036: ldarg.0
    IL_003B: call 0x2B000052
    IL_0040: stfld 0x04000791
    IL_0041: ldarg.0
    IL_0046: ldstr 0x70001ED5
    IL_004B: call 0x06000220
    IL_0050: stfld 0x04000765
    IL_0051: ret
    }

    private void Start_Weapon() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000053
    IL_000B: stfld 0x04000792
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000DB9
    IL_0016: call 0x06000220
    IL_001B: stfld 0x04000767
    IL_001C: ldarg.0
    IL_0021: ldstr 0x70001EB5
    IL_0026: call 0x06000220
    IL_002B: stfld 0x04000764
    IL_002C: ldarg.0
    IL_0031: ldstr 0x70001FB1
    IL_0036: call 0x060003F9
    IL_003B: stfld 0x04000793
    IL_003C: ldarg.0
    IL_0041: ldstr 0x70001FB9
    IL_0046: call 0x060003F9
    IL_004B: stfld 0x04000794
    IL_004C: ldc.i4.0
    IL_004D: stloc.0
    IL_0052: br IL_0072
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000755
    IL_0059: ldloc.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000792
    IL_0060: ldarg.0
    IL_0065: ldfld 0x04000793
    IL_0066: ldloc.0
    IL_0067: IL_94
    IL_0068: conv.r8
    IL_0069: IL_FB
    IL_006A: ldloc.0
    IL_006B: nop
    IL_006C: ldloc.0
    IL_006D: ldelem.i8
    IL_006E: ldloc.0
    IL_006F: ldc.i4.1
    IL_0070: IL_58
    IL_0071: stloc.0
    IL_0072: ldloc.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000764
    IL_0079: IL_3F
    IL_007A: IL_D5
    IL_007B: IL_FF
    IL_007C: IL_FF
    IL_007D: IL_FF
    IL_007E: ret
    }

    private void Start_Armor() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000DD5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000767
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70001EBD
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000764
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70001563
    IL_002A: call 0x060003F9
    IL_002F: stfld 0x04000793
    IL_0030: ldc.i4.0
    IL_0031: stloc.0
    IL_0036: br IL_004E
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000755
    IL_003D: ldloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000793
    IL_0044: ldloc.0
    IL_0045: IL_94
    IL_0047: ldc.i4.s 100
    IL_0048: mul
    IL_0049: ldelem.i8
    IL_004A: ldloc.0
    IL_004B: ldc.i4.1
    IL_004C: IL_58
    IL_004D: stloc.0
    IL_004E: ldloc.0
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000764
    IL_0055: IL_3F
    IL_0056: IL_DD
    IL_0057: IL_FF
    IL_0058: IL_FF
    IL_0059: IL_FF
    IL_005A: ret
    }

    public void EnableGUI() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x0400076C
    IL_0007: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x0400076A
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x0400076B
    IL_000E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400076A
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x0400076B
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x0400076B
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400076B
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_42
    IL_002A: ldloca.s 0
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x0400076A
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x0400076B
    IL_003F: ldarg.0
    IL_0044: ldfld 0x0400075D
    IL_0049: brtrue IL_00CD
    IL_004A: ldarg.0
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000760
    IL_0051: conv.i2
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000760
    IL_0058: conv.i2
    IL_005D: call 0x0A000024
    IL_005E: IL_22
    IL_005F: nop
    IL_0064: stsfld 0x285A44BB
    IL_0065: ldnull
    IL_0066: IL_01
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: IL_59
    IL_006A: not
    IL_006F: stfld 0x04000760
    IL_0070: ldarg.0
    IL_0075: ldfld 0x04000760
    IL_0076: ldc.i4.0
    IL_0077: IL_3D
    IL_0078: IL_4C
    IL_0079: nop
    IL_007A: nop
    IL_007B: nop
    IL_007C: ldarg.0
    IL_007D: ldc.i4.0
    IL_0082: stfld 0x04000760
    IL_0083: ldarg.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000761
    IL_008A: ldarg.0
    IL_008F: ldfld 0x04000761
    IL_0094: call 0x0A000024
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: IL_FA
    IL_0099: IL_43
    IL_009A: IL_5A
    IL_009F: call 0x0A000114
    IL_00A0: IL_59
    IL_00A5: stfld 0x04000761
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x04000761
    IL_00AC: IL_22
    IL_00AD: nop
    IL_00AE: nop
    IL_00B3: cpobj 0x00124243
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: ldarg.0
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BE: cpobj 0x07617D43
    IL_00BF: nop
    IL_00C0: ldarg.2
    IL_00C1: ldarg.0
    IL_00C2: ldc.i4.1
    IL_00C7: stfld 0x0400075D
    IL_00CC: br IL_01A5
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x0400075E
    IL_00D7: brfalse IL_0133
    IL_00D8: ldarg.0
    IL_00D9: dup
    IL_00DE: ldfld 0x04000789
    IL_00E3: call 0x0A000024
    IL_00E4: IL_58
    IL_00E9: stfld 0x04000789
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000789
    IL_00F0: conv.i4
    IL_00F1: IL_23
    IL_00F2: ldelem.i
    IL_00F3: IL_99
    IL_00F4: IL_99
    IL_00F5: IL_99
    IL_00F6: IL_99
    IL_00F7: IL_99
    IL_00F8: IL_E9
    IL_00F9: IL_3F
    IL_00FA: IL_43
    IL_00FB: ldc.i4.2
    IL_00FC: nop
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: ldarg.0
    IL_0101: ldc.i4.s 32
    IL_0106: stfld 0x04000788
    IL_0107: ldarg.0
    IL_0108: IL_22
    IL_0109: nop
    IL_010A: nop
    IL_010B: nop
    IL_010C: nop
    IL_0111: stfld 0x04000789
    IL_0116: br IL_012E
    IL_0117: ldarg.0
    IL_011C: ldfld 0x04000789
    IL_011D: IL_22
    IL_011E: IL_CD
    IL_011F: IL_CC
    IL_0120: IL_CC
    IL_0121: IL_3E
    IL_0122: IL_43
    IL_0123: ldloc.1
    IL_0124: nop
    IL_0125: nop
    IL_0126: nop
    IL_0127: ldarg.0
    IL_0128: ldc.i4.0
    IL_012D: stfld 0x04000788
    IL_0132: br IL_01A5
    IL_0133: ldarg.0
    IL_0138: ldfld 0x0400075F
    IL_013D: brfalse IL_01A5
    IL_013E: ldarg.0
    IL_013F: dup
    IL_0144: ldfld 0x04000769
    IL_0149: call 0x0A000024
    IL_014A: IL_59
    IL_014F: stfld 0x04000769
    IL_0150: ldarg.0
    IL_0155: ldfld 0x04000769
    IL_0156: IL_22
    IL_0157: nop
    IL_0158: nop
    IL_0159: nop
    IL_015A: nop
    IL_015B: IL_42
    IL_015E: ldarg 0
    IL_015F: nop
    IL_0160: ldarg.0
    IL_0161: IL_22
    IL_0162: nop
    IL_0163: nop
    IL_0164: nop
    IL_0165: nop
    IL_016A: stfld 0x04000769
    IL_016B: ldarg.0
    IL_016C: dup
    IL_0171: ldfld 0x04000761
    IL_0172: IL_22
    IL_0173: nop
    IL_0174: nop
    IL_0175: IL_FA
    IL_0176: IL_43
    IL_017B: call 0x0A000024
    IL_017C: IL_5A
    IL_017D: IL_58
    IL_0182: stfld 0x04000761
    IL_0183: ldarg.0
    IL_0188: ldfld 0x04000761
    IL_0189: IL_22
    IL_018A: nop
    IL_018B: nop
    IL_018C: ldelem.r8
    IL_018D: IL_43
    IL_018E: IL_43
    IL_0190: ldloca.s 0
    IL_0191: nop
    IL_0192: nop
    IL_0193: ldarg.0
    IL_0194: ldc.i4.0
    IL_0199: stfld 0x0400075F
    IL_019A: ldarg.0
    IL_019F: ldfld 0x04000790
    IL_01A0: conv.r8
    IL_01A1: IL_BF
    IL_01A2: ldloc.0
    IL_01A3: nop
    IL_01A4: ldloc.0
    IL_01A5: ldarg.0
    IL_01AA: ldfld 0x04000746
    IL_01AF: brfalse IL_01D6
    IL_01B0: ldarg.0
    IL_01B1: ldarg.0
    IL_01B6: ldfld 0x0400078A
    IL_01B7: IL_22
    IL_01B8: nop
    IL_01B9: nop
    IL_01BA: ldelem.r8
    IL_01BB: IL_41
    IL_01C0: call 0x0A000024
    IL_01C1: IL_22
    IL_01C2: nop
    IL_01C3: nop
    IL_01C6: ldloc 23108
    IL_01CB: call 0x0A0000C0
    IL_01D0: stfld 0x0400078A
    IL_01D5: br IL_01F7
    IL_01D6: ldarg.0
    IL_01D7: ldarg.0
    IL_01DC: ldfld 0x0400078A
    IL_01DD: IL_22
    IL_01DE: nop
    IL_01DF: nop
    IL_01E0: IL_E0
    IL_01E1: IL_42
    IL_01E6: call 0x0A000024
    IL_01E7: IL_22
    IL_01E8: nop
    IL_01E9: nop
    IL_01EC: ldloc 23108
    IL_01F1: call 0x0A0000C0
    IL_01F6: stfld 0x0400078A
    IL_01F7: ret
    }

    public void SetUpArmor() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0003: ldc.i4.s 100
    IL_0004: mul
    IL_0009: stfld 0x0400077B
    IL_000A: ldarg.1
    IL_000C: ldc.i4.s 100
    IL_000D: add
    IL_000F: starg.s 1
    IL_0010: ldc.i4.2
    IL_0015: newarr 0x0100000B
    IL_0016: stloc.0
    IL_0017: ldc.i4.0
    IL_0018: stloc.1
    IL_001D: br IL_002F
    IL_001E: ldloc.0
    IL_001F: ldloc.1
    IL_0020: ldarg.1
    IL_0022: ldc.i4.s 10
    IL_0023: mul
    IL_0024: ldelem.i8
    IL_0025: ldarg.1
    IL_0027: ldc.i4.s 10
    IL_0028: add
    IL_002A: starg.s 1
    IL_002B: ldloc.1
    IL_002C: ldc.i4.1
    IL_002D: IL_58
    IL_002E: stloc.1
    IL_002F: ldloc.1
    IL_0030: ldc.i4.2
    IL_0031: IL_3F
    IL_0032: IL_E8
    IL_0033: IL_FF
    IL_0034: IL_FF
    IL_0035: IL_FF
    IL_0036: ldarg.0
    IL_0037: ldloc.0
    IL_0038: ldc.i4.1
    IL_0039: IL_94
    IL_003E: stfld 0x0400077C
    IL_003F: ldarg.0
    IL_0040: ldarg.1
    IL_0045: stfld 0x0400077D
    IL_0046: ldarg.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x0400077D
    IL_004D: ldc.i4.5
    IL_004E: IL_5A
    IL_0053: stfld 0x04000787
    IL_0054: ret
    }

    public void SetUpWeapon() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000792
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_FD
    IL_0009: ldloc.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000792
    IL_0017: ldfld 0x04000FEC
    IL_001C: stfld 0x0400077E
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000792
    IL_0028: ldfld 0x04000FF4
    IL_002D: stfld 0x0400077F
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000792
    IL_0039: ldfld 0x04000FEF
    IL_003E: stfld 0x04000780
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000792
    IL_004A: ldfld 0x04000FF0
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000794
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000762
    IL_0057: IL_94
    IL_0058: IL_58
    IL_005D: stfld 0x04000781
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000792
    IL_0069: ldfld 0x04000FF1
    IL_006A: ldarg.0
    IL_006F: ldfld 0x04000794
    IL_0070: ldarg.0
    IL_0075: ldfld 0x04000762
    IL_0076: IL_94
    IL_0077: IL_58
    IL_007C: stfld 0x04000782
    IL_007D: ldarg.0
    IL_007E: ldarg.0
    IL_0083: ldfld 0x04000792
    IL_0088: ldfld 0x04000FEE
    IL_008D: stfld 0x04000783
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000792
    IL_0099: ldfld 0x04000FF2
    IL_009E: stfld 0x04000784
    IL_009F: ldarg.0
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000792
    IL_00AA: ldfld 0x04000FF6
    IL_00AF: stfld 0x04000785
    IL_00B0: ldarg.0
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x0400077E
    IL_00B7: conv.i2
    IL_00B8: ldarg.0
    IL_00BD: ldfld 0x0400077F
    IL_00BE: conv.i2
    IL_00BF: IL_22
    IL_00C0: IL_CD
    IL_00C1: IL_CC
    IL_00C2: IL_CC
    IL_00C3: IL_3D
    IL_00C4: IL_5A
    IL_00C5: IL_58
    IL_00C6: IL_22
    IL_00C7: nop
    IL_00C8: nop
    IL_00CD: ldc.i4 2104056385
    IL_00CE: IL_87
    IL_00CF: ldloc.1
    IL_00D0: nop
    IL_00D1: ldarg.2
    IL_00D2: ret
    }

    public void GetArmor() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: stfld 0x0400076D
    IL_0007: ldarg.0
    IL_000C: call 0x0600035F
    IL_000D: ldarg.0
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000766
    IL_0014: ldc.i4.1
    IL_0015: IL_58
    IL_0016: conv.i2
    IL_0017: IL_22
    IL_0018: IL_CD
    IL_0019: IL_CC
    IL_001A: IL_CC
    IL_001B: IL_3E
    IL_001C: IL_5A
    IL_001D: ldc.i4.0
    IL_001E: ldc.i4.2
    IL_0023: call 0x0A000045
    IL_0024: conv.i2
    IL_0025: IL_58
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400076F
    IL_002C: conv.i2
    IL_002D: IL_58
    IL_002E: not
    IL_0033: stfld 0x04000778
    IL_0034: ldarg.0
    IL_0035: ldc.i4.1
    IL_0036: ldc.i4.7
    IL_003B: call 0x0A000045
    IL_0040: stfld 0x04000779
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000779
    IL_0049: ldc.i4.s 100
    IL_004A: IL_58
    IL_004B: ldarg.0
    IL_0050: ldfld 0x0400077A
    IL_0055: ldc.i4 1000
    IL_0056: IL_5A
    IL_0057: IL_58
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000778
    IL_0062: ldc.i4 10000
    IL_0063: IL_5A
    IL_0064: IL_58
    IL_0069: stfld 0x04000763
    IL_006A: ldarg.0
    IL_006B: ldc.i4.1
    IL_0070: stfld 0x0400075E
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000790
    IL_0077: conv.r8
    IL_0078: IL_C5
    IL_0079: ldloc.0
    IL_007A: nop
    IL_007B: ldloc.0
    IL_007C: ldarg.0
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000778
    IL_0083: ldc.i4.5
    IL_0084: IL_5A
    IL_0089: stfld 0x04000786
    IL_008A: ret
    }

    public void GetWeapon() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x0400076D
    IL_0007: ldarg.0
    IL_000C: call 0x0600035E
    IL_000D: ldarg.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x04000777
    IL_0014: ldarg.0
    IL_0015: ldc.i4.0
    IL_001A: ldc.i4 1000
    IL_001F: call 0x0A000045
    IL_0024: stfld 0x0400076F
    IL_0025: ldarg.0
    IL_002A: ldfld 0x04000765
    IL_002B: stloc.1
    IL_002C: ldloc.1
    IL_002F: ldarg 3
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldarg.3
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: shl
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: IL_C5
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_0042: br IL_0160
    IL_0043: ldarg.0
    IL_0048: ldfld 0x0400076F
    IL_004D: ldc.i4 900
    IL_004E: IL_3E
    IL_004F: stloc.2
    IL_0050: nop
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldarg.0
    IL_0054: ldc.i4.4
    IL_0059: stfld 0x0400076F
    IL_005E: br IL_009E
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400076F
    IL_0069: ldc.i4 700
    IL_006A: IL_3E
    IL_006B: stloc.2
    IL_006C: nop
    IL_006D: nop
    IL_006E: nop
    IL_006F: ldarg.0
    IL_0070: ldc.i4.3
    IL_0075: stfld 0x0400076F
    IL_007A: br IL_009E
    IL_007B: ldarg.0
    IL_0080: ldfld 0x0400076F
    IL_0085: ldc.i4 300
    IL_0086: IL_3E
    IL_0087: stloc.2
    IL_0088: nop
    IL_0089: nop
    IL_008A: nop
    IL_008B: ldarg.0
    IL_008C: ldc.i4.2
    IL_0091: stfld 0x0400076F
    IL_0096: br IL_009E
    IL_0097: ldarg.0
    IL_0098: ldc.i4.1
    IL_009D: stfld 0x0400076F
    IL_00A2: br IL_0160
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x0400076F
    IL_00AD: ldc.i4 900
    IL_00AE: IL_3E
    IL_00AF: stloc.2
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: ldarg.0
    IL_00B4: ldc.i4.4
    IL_00B9: stfld 0x0400076F
    IL_00BE: br IL_00FE
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x0400076F
    IL_00C9: ldc.i4 500
    IL_00CA: IL_3E
    IL_00CB: stloc.2
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: ldarg.0
    IL_00D0: ldc.i4.3
    IL_00D5: stfld 0x0400076F
    IL_00DA: br IL_00FE
    IL_00DB: ldarg.0
    IL_00E0: ldfld 0x0400076F
    IL_00E5: ldc.i4 200
    IL_00E6: IL_3E
    IL_00E7: stloc.2
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: nop
    IL_00EB: ldarg.0
    IL_00EC: ldc.i4.2
    IL_00F1: stfld 0x0400076F
    IL_00F6: br IL_00FE
    IL_00F7: ldarg.0
    IL_00F8: ldc.i4.1
    IL_00FD: stfld 0x0400076F
    IL_0102: br IL_0160
    IL_0103: ldarg.0
    IL_0108: ldfld 0x0400076F
    IL_010D: ldc.i4 800
    IL_010E: IL_3E
    IL_010F: stloc.2
    IL_0110: nop
    IL_0111: nop
    IL_0112: nop
    IL_0113: ldarg.0
    IL_0114: ldc.i4.4
    IL_0119: stfld 0x0400076F
    IL_011E: br IL_015B
    IL_011F: ldarg.0
    IL_0124: ldfld 0x0400076F
    IL_0129: ldc.i4 300
    IL_012A: IL_3E
    IL_012B: stloc.2
    IL_012C: nop
    IL_012D: nop
    IL_012E: nop
    IL_012F: ldarg.0
    IL_0130: ldc.i4.3
    IL_0135: stfld 0x0400076F
    IL_013A: br IL_015B
    IL_013B: ldarg.0
    IL_0140: ldfld 0x0400076F
    IL_0142: ldc.i4.s 100
    IL_0143: IL_3E
    IL_0144: stloc.2
    IL_0145: nop
    IL_0146: nop
    IL_0147: nop
    IL_0148: ldarg.0
    IL_0149: ldc.i4.2
    IL_014E: stfld 0x0400076F
    IL_0153: br IL_015B
    IL_0154: ldarg.0
    IL_0155: ldc.i4.1
    IL_015A: stfld 0x0400076F
    IL_015F: br IL_0160
    IL_0161: ldc.i4.s 10
    IL_0166: ldc.i4 9987
    IL_016B: call 0x0A000045
    IL_016C: ldarg.0
    IL_0171: ldfld 0x0400076F
    IL_0172: ldc.i4.1
    IL_0173: IL_59
    IL_0174: ldc.i4.3
    IL_0175: IL_5A
    IL_0176: IL_58
    IL_0177: ldc.i4.0
    IL_0178: ldc.i4.4
    IL_017D: call 0x0A000045
    IL_017E: IL_58
    IL_017F: stloc.0
    IL_0180: ldarg.0
    IL_0181: ldarg.0
    IL_0186: ldfld 0x04000777
    IL_018B: ldc.i4 1000000
    IL_018C: IL_5A
    IL_018D: ldarg.0
    IL_0192: ldfld 0x0400076F
    IL_0197: ldc.i4 10000
    IL_0198: IL_5A
    IL_0199: IL_58
    IL_019A: ldloc.0
    IL_019B: IL_58
    IL_01A0: stfld 0x04000763
    IL_01A1: ldarg.0
    IL_01A6: ldfld 0x04000792
    IL_01A7: ldarg.0
    IL_01AC: ldfld 0x04000763
    IL_01AD: conv.r8
    IL_01AE: IL_FD
    IL_01AF: ldloc.0
    IL_01B0: nop
    IL_01B1: ldloc.0
    IL_01B2: ldarg.0
    IL_01B3: ldarg.0
    IL_01B8: ldfld 0x04000792
    IL_01BD: ldfld 0x04000FED
    IL_01C2: stfld 0x0400076E
    IL_01C3: ldarg.0
    IL_01C4: ldarg.0
    IL_01C9: ldfld 0x04000792
    IL_01CE: ldfld 0x04000FF4
    IL_01D3: stfld 0x0400076F
    IL_01D4: ldarg.0
    IL_01D5: ldarg.0
    IL_01DA: ldfld 0x04000792
    IL_01DF: ldfld 0x04000FEF
    IL_01E4: stfld 0x04000770
    IL_01E5: ldarg.0
    IL_01E6: ldarg.0
    IL_01EB: ldfld 0x04000792
    IL_01F0: ldfld 0x04000FF0
    IL_01F5: stfld 0x04000771
    IL_01F6: ldarg.0
    IL_01F7: ldarg.0
    IL_01FC: ldfld 0x04000792
    IL_0201: ldfld 0x04000FF1
    IL_0206: stfld 0x04000772
    IL_0207: ldarg.0
    IL_0208: ldarg.0
    IL_020D: ldfld 0x04000792
    IL_0212: ldfld 0x04000FEE
    IL_0217: stfld 0x04000773
    IL_0218: ldarg.0
    IL_0219: ldarg.0
    IL_021E: ldfld 0x04000792
    IL_0223: ldfld 0x04000FF2
    IL_0228: stfld 0x04000774
    IL_0229: ldarg.0
    IL_022A: ldarg.0
    IL_022F: ldfld 0x04000792
    IL_0234: ldfld 0x04000FF3
    IL_0239: stfld 0x04000775
    IL_023A: ldarg.0
    IL_023B: ldarg.0
    IL_0240: ldfld 0x04000792
    IL_0245: ldfld 0x04000FF6
    IL_024A: stfld 0x04000776
    IL_024B: ldarg.0
    IL_024C: ldc.i4.1
    IL_0251: stfld 0x0400075E
    IL_0252: ldarg.0
    IL_0253: ldarg.0
    IL_0258: ldfld 0x04000777
    IL_0259: conv.i2
    IL_025A: ldarg.0
    IL_025F: ldfld 0x0400076F
    IL_0260: conv.i2
    IL_0261: IL_22
    IL_0262: IL_CD
    IL_0263: IL_CC
    IL_0264: IL_CC
    IL_0265: IL_3D
    IL_0266: IL_5A
    IL_0267: IL_58
    IL_0268: IL_22
    IL_0269: nop
    IL_026A: nop
    IL_026F: ldc.i4 2104056385
    IL_0270: IL_86
    IL_0271: ldloc.1
    IL_0272: nop
    IL_0273: ldarg.2
    IL_0274: ldarg.0
    IL_0279: ldfld 0x04000790
    IL_027A: conv.r8
    IL_027B: IL_C5
    IL_027C: ldloc.0
    IL_027D: nop
    IL_027E: ldloc.0
    IL_027F: ret
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000747
    IL_0040: call 0x0A0000DF
    IL_0042: ldc.i4.s -5
    IL_0047: call 0x0A0000EF
    IL_0048: ldarg.0
    IL_004D: ldfld 0x0400076C
    IL_0052: brfalse IL_0054
    IL_0053: ret
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000768
    IL_005A: ldc.i4.0
    IL_005B: IL_3D
    IL_005C: stloc.1
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400075F
    IL_006A: brfalse IL_0071
    IL_006B: ldc.i4.0
    IL_0070: call 0x0A0001B9
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000760
    IL_0077: conv.i2
    IL_0078: IL_22
    IL_0079: nop
    IL_007A: nop
    IL_007B: shr
    IL_007C: IL_43
    IL_007D: IL_22
    IL_007E: nop
    IL_007F: nop
    IL_0080: IL_F0
    IL_0081: IL_43
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0085: IL_A8
    IL_0086: IL_42
    IL_008B: call 0x0600021D
    IL_008C: ldarg.0
    IL_0091: ldfld 0x04000748
    IL_0096: call 0x0A0000E0
    IL_0097: ldarg.0
    IL_009C: ldfld 0x0400075E
    IL_00A1: brfalse IL_071C
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x0400078A
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x0400078B
    IL_00AE: conv.i2
    IL_00AF: IL_22
    IL_00B0: nop
    IL_00B1: nop
    IL_00B6: stsfld 0x00002243
    IL_00B7: nop
    IL_00B8: IL_43
    IL_00BD: call 0x0600021D
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x0400074A
    IL_00C8: call 0x0A0000E0
    IL_00C9: ldarg.0
    IL_00CE: ldfld 0x0400078A
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x0400078B
    IL_00D5: conv.i2
    IL_00D6: ldarg.0
    IL_00DB: ldfld 0x04000788
    IL_00DC: ldc.i4.8
    IL_00DD: IL_5A
    IL_00DE: conv.i2
    IL_00DF: ldarg.0
    IL_00E4: ldfld 0x04000788
    IL_00E5: ldc.i4.4
    IL_00E6: IL_5A
    IL_00E7: conv.i2
    IL_00EC: call 0x0600021D
    IL_00F1: ldsfld 0x0A000099
    IL_00F6: ldstr 0x700029EB
    IL_00FB: call 0x0A0000E2
    IL_0100: call 0x0A0001BA
    IL_0101: ldarg.0
    IL_0106: ldfld 0x0400076D
    IL_0107: ldc.i4.1
    IL_0A30: switch (585 cases)
    IL_0A31: ldarg.0
    IL_0A36: ldfld 0x0400078E
    IL_0A37: ldarg.0
    IL_0A3C: ldfld 0x04000785
    IL_0A41: call 0x0A0000E1
    IL_0A46: ldstr 0x70000C43
    IL_0A4B: call 0x0A0000E2
    IL_0A50: call 0x0A0000E3
    IL_0A55: br IL_0B9D
    IL_0A56: ldarg.0
    IL_0A5B: ldfld 0x0400078C
    IL_0A5D: ldc.i4.s 26
    IL_0A5E: IL_58
    IL_0A5F: conv.i2
    IL_0A60: ldarg.0
    IL_0A65: ldfld 0x0400078D
    IL_0A67: ldc.i4.s 10
    IL_0A68: IL_58
    IL_0A69: conv.i2
    IL_0A6A: IL_22
    IL_0A6B: nop
    IL_0A6C: nop
    IL_0A6D: nop
    IL_0A6E: IL_43
    IL_0A6F: IL_22
    IL_0A70: nop
    IL_0A71: nop
    IL_0A76: stsfld 0x021D2841
    IL_0A77: nop
    IL_0A78: ldloc.0
    IL_0A79: ldarg.0
    IL_0A7E: ldfld 0x04000791
    IL_0A83: ldfld 0x040007B4
    IL_0A84: ldarg.0
    IL_0A89: ldfld 0x0400078E
    IL_0A8A: ldarg.0
    IL_0A8F: ldfld 0x0400077B
    IL_0A90: ldc.i4.1
    IL_0A91: IL_58
    IL_0A96: call 0x0A0000E1
    IL_0A9B: ldstr 0x70000BC5
    IL_0AA0: call 0x0A0000E2
    IL_0AA5: call 0x0A0000E3
    IL_0AA6: ldc.i4.0
    IL_0AA8: stloc.s 6
    IL_0AAD: br IL_0AE8
    IL_0AAE: ldarg.0
    IL_0AB3: ldfld 0x0400078C
    IL_0AB5: ldc.i4.s 24
    IL_0AB6: IL_58
    IL_0AB7: conv.i2
    IL_0AB8: ldarg.0
    IL_0ABD: ldfld 0x0400078D
    IL_0ABF: ldc.i4.s 33
    IL_0AC0: IL_58
    IL_0AC2: ldloc.s 6
    IL_0AC4: ldc.i4.s 20
    IL_0AC5: IL_5A
    IL_0AC6: IL_58
    IL_0AC7: conv.i2
    IL_0AC8: IL_22
    IL_0AC9: nop
    IL_0ACA: nop
    IL_0ACB: stloc.2
    IL_0ACC: IL_43
    IL_0ACD: IL_22
    IL_0ACE: nop
    IL_0ACF: nop
    IL_0AD4: stsfld 0x021D2841
    IL_0AD5: nop
    IL_0AD6: ldloc.0
    IL_0AD7: ldarg.0
    IL_0ADC: ldfld 0x0400074B
    IL_0AE1: call 0x0A0000E0
    IL_0AE3: ldloc.s 6
    IL_0AE4: ldc.i4.1
    IL_0AE5: IL_58
    IL_0AE7: stloc.s 6
    IL_0AE9: ldloc.s 6
    IL_0AEA: ldc.i4.2
    IL_0AEB: IL_3F
    IL_0AEC: IL_BE
    IL_0AED: IL_FF
    IL_0AEE: IL_FF
    IL_0AEF: IL_FF
    IL_0AF0: ldarg.0
    IL_0AF5: ldfld 0x0400078C
    IL_0AF7: ldc.i4.s 30
    IL_0AF8: IL_58
    IL_0AF9: conv.i2
    IL_0AFA: ldarg.0
    IL_0AFF: ldfld 0x0400078D
    IL_0B01: ldc.i4.s 33
    IL_0B02: IL_58
    IL_0B03: conv.i2
    IL_0B04: IL_22
    IL_0B05: nop
    IL_0B06: nop
    IL_0B07: nop
    IL_0B08: IL_43
    IL_0B09: IL_22
    IL_0B0A: nop
    IL_0B0B: nop
    IL_0B10: stsfld 0x021D2841
    IL_0B11: nop
    IL_0B12: ldloc.0
    IL_0B17: ldsfld 0x040007B2
    IL_0B18: ldarg.0
    IL_0B1D: ldfld 0x0400078E
    IL_0B22: ldc.i4 142
    IL_0B27: call 0x0A0000E1
    IL_0B2C: ldstr 0x70002A13
    IL_0B2D: ldarg.0
    IL_0B32: ldfld 0x0400077D
    IL_0B37: newobj 0x0100000B
    IL_0B3C: call 0x0A000098
    IL_0B41: ldstr 0x70000C43
    IL_0B46: call 0x0A0000E2
    IL_0B4B: call 0x0A0000E3
    IL_0B4C: ldarg.0
    IL_0B51: ldfld 0x0400078C
    IL_0B53: ldc.i4.s 30
    IL_0B54: IL_58
    IL_0B55: conv.i2
    IL_0B56: ldarg.0
    IL_0B5B: ldfld 0x0400078D
    IL_0B5D: ldc.i4.s 53
    IL_0B5E: IL_58
    IL_0B5F: conv.i2
    IL_0B60: IL_22
    IL_0B61: nop
    IL_0B62: nop
    IL_0B63: nop
    IL_0B64: IL_43
    IL_0B65: IL_22
    IL_0B66: nop
    IL_0B67: nop
    IL_0B6C: stsfld 0x021D2841
    IL_0B6D: nop
    IL_0B6E: ldloc.0
    IL_0B6F: ldarg.0
    IL_0B74: ldfld 0x04000791
    IL_0B79: ldfld 0x040007B4
    IL_0B7A: ldarg.0
    IL_0B7F: ldfld 0x0400078E
    IL_0B80: ldarg.0
    IL_0B85: ldfld 0x0400077C
    IL_0B87: ldc.i4.s 21
    IL_0B88: IL_58
    IL_0B8D: call 0x0A0000E1
    IL_0B92: ldstr 0x70000C43
    IL_0B97: call 0x0A0000E2
    IL_0B9C: call 0x0A0000E3
    IL_0B9D: ldarg.0
    IL_0BA2: ldfld 0x0400078C
    IL_0BA4: ldc.i4.s 62
    IL_0BA5: IL_58
    IL_0BA6: conv.i2
    IL_0BA7: ldarg.0
    IL_0BAC: ldfld 0x0400078D
    IL_0BAE: ldc.i4.s 90
    IL_0BAF: IL_58
    IL_0BB0: conv.i2
    IL_0BB1: IL_22
    IL_0BB2: nop
    IL_0BB3: nop
    IL_0BB4: nop
    IL_0BB5: IL_42
    IL_0BB6: IL_22
    IL_0BB7: nop
    IL_0BB8: nop
    IL_0BB9: nop
    IL_0BBA: IL_42
    IL_0BBF: call 0x0600021D
    IL_0BC4: ldsfld 0x0A000099
    IL_0BC5: ldarg.0
    IL_0BCA: ldfld 0x0400075C
    IL_0BCF: call 0x0A0000F1
    IL_0BD4: brfalse IL_0C09
    IL_0BD5: ldarg.0
    IL_0BDA: ldfld 0x04000762
    IL_0BDB: ldarg.0
    IL_0BE0: ldfld 0x04000767
    IL_0C41: switch (23 cases)
    IL_0C42: ldarg.2
    IL_0C47: call 0x0A0000F1
    IL_0C4C: brfalse IL_0C5B
    IL_0C4D: ldarg.0
    IL_0C4E: ldc.i4.0
    IL_0C53: stfld 0x04000746
    IL_0C54: ldarg.0
    IL_0C55: ldc.i4.m1
    IL_0C5A: stfld 0x04000762
    IL_0C5B: ldc.i4.0
    IL_0C5D: stloc.s 7
    IL_0C62: br IL_0E3A
    IL_0C64: ldloc.s 7
    IL_0C66: ldc.i4.s 76
    IL_0C67: IL_5A
    IL_0C69: ldc.i4.s 18
    IL_0C6A: IL_58
    IL_0C6B: conv.i2
    IL_0C6C: ldarg.0
    IL_0C71: ldfld 0x04000761
    IL_0C72: IL_22
    IL_0C73: nop
    IL_0C74: nop
    IL_0C79: stsfld 0x00002242
    IL_0C7E: stsfld 0x021D2842
    IL_0C7F: nop
    IL_0C80: ldloc.0
    IL_0C85: ldsfld 0x0A000099
    IL_0C86: ldarg.0
    IL_0C8B: ldfld 0x0400075B
    IL_0C90: call 0x0A0000F1
    IL_0C95: brfalse IL_0D11
    IL_0C97: ldloc.s 7
    IL_0C98: ldarg.0
    IL_0C9D: ldfld 0x04000764
    IL_0C9E: IL_3F
    IL_0C9F: stloc.2
    IL_0CA0: nop
    IL_0CA1: nop
    IL_0CA2: nop
    IL_0CA3: ldarg.0
    IL_0CA4: ldc.i4.3
    IL_0CA9: stfld 0x04000768
    IL_0CAE: br IL_0D11
    IL_0CAF: ldarg.0
    IL_0CB4: ldfld 0x04000793
    IL_0CB6: ldloc.s 7
    IL_0CB7: IL_94
    IL_0CB8: ldc.i4.0
    IL_0CB9: IL_3E
    IL_0CBA: IL_53
    IL_0CBB: nop
    IL_0CBC: nop
    IL_0CBD: nop
    IL_0CBE: ldarg.0
    IL_0CC3: ldfld 0x04000762
    IL_0CC5: ldloc.s 7
    IL_0CCA: beq IL_0D11
    IL_0CCB: ldarg.0
    IL_0CCD: ldloc.s 7
    IL_0CD2: stfld 0x04000762
    IL_0CD3: ldarg.0
    IL_0CD8: ldfld 0x0400076D
    IL_0CD9: ldc.i4.1
    IL_0D3E: switch (24 cases)
    IL_0D3F: IL_42
    IL_0D40: IL_22
    IL_0D41: nop
    IL_0D42: nop
    IL_0D47: stsfld 0x021D2842
    IL_0D48: nop
    IL_0D49: ldloc.0
    IL_0D4A: ldarg.0
    IL_0D4F: ldfld 0x04000753
    IL_0D50: ldarg.0
    IL_0D55: ldfld 0x04000755
    IL_0D57: ldloc.s 7
    IL_0D58: IL_94
    IL_0D59: ldelem.i
    IL_0D5E: call 0x0A0000E0
    IL_0D63: br IL_0D97
    IL_0D65: ldloc.s 7
    IL_0D67: ldc.i4.s 76
    IL_0D68: IL_5A
    IL_0D6A: ldc.i4.s 18
    IL_0D6B: IL_58
    IL_0D6C: conv.i2
    IL_0D6D: ldarg.0
    IL_0D72: ldfld 0x04000761
    IL_0D73: IL_22
    IL_0D74: nop
    IL_0D75: nop
    IL_0D7A: stsfld 0x00002242
    IL_0D7F: stsfld 0x021D2842
    IL_0D80: nop
    IL_0D81: ldloc.0
    IL_0D82: ldarg.0
    IL_0D87: ldfld 0x04000754
    IL_0D88: ldarg.0
    IL_0D8D: ldfld 0x04000755
    IL_0D8F: ldloc.s 7
    IL_0D90: IL_94
    IL_0D91: ldelem.i
    IL_0D96: call 0x0A0000E0
    IL_0D9B: br IL_0DD2
    IL_0D9D: ldloc.s 7
    IL_0D9E: ldarg.0
    IL_0DA3: ldfld 0x04000764
    IL_0DA4: IL_3F
    IL_0DA5: IL_29
    IL_0DA6: nop
    IL_0DA7: nop
    IL_0DA8: nop
    IL_0DAA: ldloc.s 7
    IL_0DAC: ldc.i4.s 76
    IL_0DAD: IL_5A
    IL_0DAF: ldc.i4.s 18
    IL_0DB0: IL_58
    IL_0DB1: conv.i2
    IL_0DB2: ldarg.0
    IL_0DB7: ldfld 0x04000761
    IL_0DB8: IL_22
    IL_0DB9: nop
    IL_0DBA: nop
    IL_0DBF: stsfld 0x00002242
    IL_0DC4: stsfld 0x021D2842
    IL_0DC5: nop
    IL_0DC6: ldloc.0
    IL_0DC7: ldarg.0
    IL_0DCC: ldfld 0x0400074D
    IL_0DD1: call 0x0A0000E0
    IL_0DD3: ldloc.s 7
    IL_0DD4: ldarg.0
    IL_0DD9: ldfld 0x04000767
    IL_0F32: switch (85 cases)
    IL_0F33: nop
    IL_9840: switch (8770 cases)
    }

    }}
