// Namespace: 
// Type: UI_cashshop

    public class UI_cashshop {{

    public object bt_empty;
    public object bt_yesno;
    public object bt_back;
    public object bt_history;
    public object basicSkin;
    public object prt_shop;
    public object img_jade;
    public object img_coin;
    public object img_pr;
    public object img_weapon;
    public object img_armor;
    public object img_acce;
    public object img_etc;
    public object img_menu;
    private object icon_gem;
    public object bg_asset;
    public object bg_black;
    public object titlebase;
    public object icon_jade;
    public object icon_coin;
    public object pop_blank2;
    public object pop_blank3;
    public object bg_cashlist;
    public object icon_doller;
    public object icon_won;
    public object icon_yen;
    public object soldout;
    public object freejade;
    public object limitedSale;
    private object icon_cashcost;
    public object bg_item;
    public object bg_item_0;
    public object percent_image;
    public object weapon_kindicon;
    public object titlebase_w;
    public object txt_amount;
    public object weapon_dummy;
    public object spine_dummy;
    private object confirm;
    private object dragOn;
    private object scrollOn;
    private object dragposX;
    private object prevposX;
    private object currentX;
    private object dragrange;
    private object ui;
    private object ui2;
    private object language;
    private object select_itemidx;
    private object coin;
    private object jade;
    private object linecount;
    private object eventName;
    private object starttime;
    private object bg_posX_l;
    private object bg_posX_r;
    private object icon_posY;
    private object get_jade_amount;
    private object cost_jade;
    private object CT_ID;
    private object cost_acce;
    private object cost_coin;
    private object goods_coin;
    private object cost_weapon;
    private object cost_armor;
    private object cost_etc;
    private object reqLvFactor_weapon;
    private object reqLvFactor_equip;
    private object itemindex;
    private object unlock_costume;
    private object unlock_weapon;
    private object gem_inven;
    private object accessory;
    private object cashing;
    private object scrollPosition;
    private object prev_scrollPosition;
    private object startMousePosY;
    private object curMousePosY;
    private object popupOn;
    private object freecash;
    private object webshop;
    private object log_string;
    private object kind_cash;
    private object review;
    private object kakao;
    private object reviewURL;
    private object cur_weapon;
    private object cur_equip;
    private object selectweapon;
    private object selectequip;
    private object chalv;
    private object selweapon_meshkind;
    private object selweapon_kind;
    private object selweapon_grade;
    private object selweapon_name;
    private object selweapon_maxatk;
    private object selweapon_minatk;
    private object selweapon_spd;
    private object selweapon_special;
    private object selweapon_special_txt;
    private object selequip_index;
    private object selequip_special;
    private object selequip_hp;
    private object margin;
    private object script_name;
    private object script_weaponstat;
    private object script_costume;
    private object script_weapon;
    private object weapon_seed;
    private object costume_seed;
    private object scene_kind;
    private object st_cashkind;
    private object getItem;

    public UI_cashshop() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000C6D
    IL_000C: ldarg.0
    IL_000D: ldc.i4.6
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000C6E
    IL_0018: ldarg.0
    IL_0019: ldc.i4.6
    IL_001E: newarr 0x0100003C
    IL_0023: stfld 0x04000C6F
    IL_0024: ldarg.0
    IL_0026: ldc.i4.s 10
    IL_002B: newarr 0x0100003C
    IL_0030: stfld 0x04000C70
    IL_0031: ldarg.0
    IL_0033: ldc.i4.s 10
    IL_0038: newarr 0x0100003C
    IL_003D: stfld 0x04000C71
    IL_003E: ldarg.0
    IL_003F: ldc.i4.7
    IL_0044: newarr 0x0100003C
    IL_0049: stfld 0x04000C72
    IL_004A: ldarg.0
    IL_004B: ldc.i4.6
    IL_0050: newarr 0x0100003C
    IL_0055: stfld 0x04000C73
    IL_0056: ldarg.0
    IL_0057: ldc.i4.6
    IL_005C: newarr 0x0100003C
    IL_0061: stfld 0x04000C74
    IL_0062: ldarg.0
    IL_0063: ldc.i4.3
    IL_0068: newarr 0x0100003C
    IL_006D: stfld 0x04000C88
    IL_006E: ldarg.0
    IL_006F: ldc.i4.8
    IL_0074: newarr 0x0100003C
    IL_0079: stfld 0x04000C8A
    IL_007A: ldarg.0
    IL_007C: ldc.i4.s 10
    IL_0081: stfld 0x04000C9A
    IL_0082: ldarg.0
    IL_0087: ldstr 0x700237B3
    IL_008C: stfld 0x04000C9B
    IL_008D: ldarg.0
    IL_008E: IL_22
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_BE
    IL_0092: IL_C3
    IL_0097: stfld 0x04000C9D
    IL_0098: ldarg.0
    IL_0099: IL_22
    IL_009A: nop
    IL_009B: nop
    IL_009C: IL_F0
    IL_009D: IL_43
    IL_00A2: stfld 0x04000C9E
    IL_00A3: ldarg.0
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: IL_AA
    IL_00A8: IL_43
    IL_00AD: stfld 0x04000C9F
    IL_00AE: ldarg.0
    IL_00B0: ldc.i4.s 9
    IL_00B5: newarr 0x0100000B
    IL_00B6: dup
    IL_00BB: ldtoken 0x040010C1
    IL_00C0: call 0x0A00018C
    IL_00C5: stfld 0x04000CA0
    IL_00C6: ldarg.0
    IL_00C8: ldc.i4.s 9
    IL_00CD: newarr 0x0100002F
    IL_00CE: dup
    IL_00D3: ldtoken 0x040010C2
    IL_00D8: call 0x0A00018C
    IL_00DD: stfld 0x04000CA1
    IL_00DE: ldarg.0
    IL_00DF: ldc.i4.8
    IL_00E4: newarr 0x0100000B
    IL_00E5: dup
    IL_00EA: ldtoken 0x040010C3
    IL_00EF: call 0x0A00018C
    IL_00F4: stfld 0x04000CA2
    IL_00F5: ldarg.0
    IL_00F6: ldc.i4.6
    IL_00FB: newarr 0x0100000B
    IL_00FC: dup
    IL_0101: ldtoken 0x040010C4
    IL_0106: call 0x0A00018C
    IL_010B: stfld 0x04000CA3
    IL_010C: ldarg.0
    IL_010D: ldc.i4.6
    IL_0112: newarr 0x0100000B
    IL_0113: dup
    IL_0118: ldtoken 0x040010C5
    IL_011D: call 0x0A00018C
    IL_0122: stfld 0x04000CA4
    IL_0123: ldarg.0
    IL_0124: ldc.i4.6
    IL_0129: newarr 0x0100000B
    IL_012A: dup
    IL_012F: ldtoken 0x040010C6
    IL_0134: call 0x0A00018C
    IL_0139: stfld 0x04000CA5
    IL_013A: ldarg.0
    IL_013C: ldc.i4.s 10
    IL_0141: newarr 0x0100000B
    IL_0146: stfld 0x04000CA6
    IL_0147: ldarg.0
    IL_0149: ldc.i4.s 10
    IL_014E: newarr 0x0100000B
    IL_014F: dup
    IL_0154: ldtoken 0x040010C7
    IL_0159: call 0x0A00018C
    IL_015E: stfld 0x04000CA7
    IL_015F: ldarg.0
    IL_0160: ldc.i4.6
    IL_0165: newarr 0x0100000B
    IL_0166: dup
    IL_016B: ldtoken 0x040010C8
    IL_0170: call 0x0A00018C
    IL_0175: stfld 0x04000CA8
    IL_0176: ldarg.0
    IL_0178: ldc.i4.s 10
    IL_017D: newarr 0x0100000B
    IL_017E: dup
    IL_0183: ldtoken 0x040010C9
    IL_0188: call 0x0A00018C
    IL_018D: stfld 0x04000CA9
    IL_018E: ldarg.0
    IL_0190: ldc.i4.s 10
    IL_0195: newarr 0x0100000B
    IL_0196: dup
    IL_019B: ldtoken 0x040010CA
    IL_01A0: call 0x0A00018C
    IL_01A5: stfld 0x04000CAA
    IL_01A6: ldarg.0
    IL_01A8: ldc.i4.s 9
    IL_01AD: newarr 0x0100000C
    IL_01B2: stfld 0x04000CAB
    IL_01B3: ldarg.0
    IL_01B5: ldc.i4.s 20
    IL_01BA: newarr 0x0100000B
    IL_01BF: stfld 0x04000CAC
    IL_01C0: ldarg.0
    IL_01C2: ldc.i4.s 20
    IL_01C7: newarr 0x0100000B
    IL_01CC: stfld 0x04000CAD
    IL_01CD: ldarg.0
    IL_01CE: ldc.i4.5
    IL_01D3: newarr 0x0100000B
    IL_01D8: stfld 0x04000CAE
    IL_01D9: ldarg.0
    IL_01DA: ldc.i4.6
    IL_01DF: newarr 0x0100000B
    IL_01E4: stfld 0x04000CAF
    IL_01E5: ldarg.0
    IL_01EA: call 0x0A000057
    IL_01EF: stfld 0x04000CB1
    IL_01F0: ldarg.0
    IL_01F5: call 0x0A000057
    IL_01FA: stfld 0x04000CB2
    IL_01FB: ldarg.0
    IL_01FC: ldc.i4.m1
    IL_0201: stfld 0x04000CBD
    IL_0202: ldarg.0
    IL_0203: ldc.i4.m1
    IL_0208: stfld 0x04000CBE
    IL_0209: ldarg.0
    IL_020A: ldc.i4.m1
    IL_020F: stfld 0x04000CBF
    IL_0210: ldarg.0
    IL_0211: ldc.i4.m1
    IL_0216: stfld 0x04000CC0
    IL_0217: ldarg.0
    IL_0219: ldc.i4.s 26
    IL_021E: newarr 0x0100000B
    IL_0223: stfld 0x04000CD3
    IL_0224: ldarg.0
    IL_0226: ldc.i4.s 26
    IL_022B: newarr 0x0100000B
    IL_0230: stfld 0x04000CD4
    IL_0231: ldarg.0
    IL_0236: ldstr 0x70023855
    IL_023B: stfld 0x04000CD6
    IL_023C: ldarg.0
    IL_023D: ldc.i4.1
    IL_0242: stfld 0x04000CD7
    IL_0243: ldarg.0
    IL_0248: call 0x0A000001
    IL_0249: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000053
    IL_000B: stfld 0x04000CD0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000052
    IL_0017: stfld 0x04000CCF
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A000002
    IL_001F: ldc.i4.0
    IL_0020: conv.r8
    IL_0025: brtrue IL_160A0026
    IL_0026: conv.r8
    IL_002B: brtrue IL_6F0A002C
    IL_002C: IL_87
    IL_002D: nop
    IL_002E: nop
    IL_0030: br.s IL_00AE
    IL_0031: IL_D1
    IL_0032: stloc.2
    IL_0033: nop
    IL_0034: ldarg.2
    IL_0035: ldarg.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000C8B
    IL_003C: conv.r8
    IL_003D: pop
    IL_003E: nop
    IL_003F: nop
    IL_0041: br.s IL_00BF
    IL_0042: IL_D2
    IL_0043: stloc.2
    IL_0044: nop
    IL_0045: ldarg.2
    IL_0046: ldarg.0
    IL_004B: ldstr 0x70000DD5
    IL_0050: call 0x06000220
    IL_0055: stfld 0x04000CBE
    IL_0056: ldarg.0
    IL_005B: ldstr 0x70000DB9
    IL_0060: call 0x06000220
    IL_0065: stfld 0x04000CBD
    IL_0066: ldarg.0
    IL_006B: ldstr 0x70000DDD
    IL_0070: call 0x06000220
    IL_0075: stfld 0x04000CC1
    IL_0076: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000131
    IL_000A: stfld 0x04000C9C
    IL_000B: ldarg.0
    IL_0010: call 0x0A000002
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0017: brtrue IL_160A0018
    IL_0018: conv.r8
    IL_001D: brtrue IL_220A001E
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_00B2: switch (34 cases)
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000DA
    IL_0006: conv.i2
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_C0
    IL_000B: IL_3E
    IL_000C: IL_5A
    IL_0011: stfld 0x04000C93
    IL_0012: ldarg.0
    IL_0017: ldstr 0x70001E8B
    IL_001C: call 0x06000220
    IL_001D: neg
    IL_0022: stfld 0x04000CB9
    IL_0023: ldarg.0
    IL_0028: ldstr 0x70000DCD
    IL_002D: call 0x060003F9
    IL_0032: stfld 0x04000CAF
    IL_0033: ldarg.0
    IL_0038: ldstr 0x70000BB3
    IL_003D: call 0x0A000095
    IL_0042: stfld 0x04000C96
    IL_0043: ldarg.0
    IL_0048: ldstr 0x700020A5
    IL_004D: call 0x06000220
    IL_0052: stfld 0x04000CB0
    IL_0053: ldarg.0
    IL_0058: ldsfld 0x040007B2
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000C96
    IL_0060: ldc.i4.s 62
    IL_0065: call 0x0A0000E1
    IL_006A: stfld 0x04000CD6
    IL_006F: ldstr 0x70023859
    IL_0074: call 0x0A000077
    IL_0075: ldnull
    IL_007A: call 0x0A000021
    IL_007F: brfalse IL_009C
    IL_0080: ldarg.0
    IL_0085: ldstr 0x70023859
    IL_008A: call 0x0A000077
    IL_008F: stfld 0x04000C94
    IL_0090: ldarg.0
    IL_0091: ldc.i4.2
    IL_0096: stfld 0x04000CD5
    IL_009B: br IL_00EC
    IL_00A0: call 0x0A0000EB
    IL_00A5: ldstr 0x700017E3
    IL_00AA: call 0x0A0000EC
    IL_00AF: brfalse IL_00DC
    IL_00B0: ldarg.0
    IL_00B5: ldstr 0x70000BD5
    IL_00BA: call 0x0A000004
    IL_00BF: stfld 0x04000C94
    IL_00C0: ldarg.0
    IL_00C5: ldstr 0x70001675
    IL_00CA: call 0x0A000004
    IL_00CF: stfld 0x04000C95
    IL_00D0: ldarg.0
    IL_00D1: ldc.i4.2
    IL_00D6: stfld 0x04000CD5
    IL_00DB: br IL_00EC
    IL_00DC: ldarg.0
    IL_00E1: ldstr 0x70000BD5
    IL_00E6: call 0x0A000004
    IL_00EB: stfld 0x04000C94
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x04000C94
    IL_00F2: ldc.i4.0
    IL_00F3: conv.r8
    IL_00F4: stloc.1
    IL_00F5: nop
    IL_00F6: nop
    IL_00F7: stloc.0
    IL_00F8: ldarg.0
    IL_00FD: ldfld 0x04000C95
    IL_00FE: ldnull
    IL_0103: call 0x0A000021
    IL_0108: brfalse IL_0115
    IL_0109: ldarg.0
    IL_010E: ldfld 0x04000C95
    IL_010F: ldc.i4.0
    IL_0110: conv.r8
    IL_0111: stloc.1
    IL_0112: nop
    IL_0113: nop
    IL_0114: stloc.0
    IL_0115: ldarg.0
    IL_011A: ldstr 0x70001EA5
    IL_011F: call 0x06000220
    IL_0124: stfld 0x04000C98
    IL_0125: ldarg.0
    IL_012A: ldstr 0x700004D5
    IL_012F: call 0x06000220
    IL_0134: stfld 0x04000C99
    IL_0135: IL_22
    IL_0136: nop
    IL_0137: nop
    IL_0138: nop
    IL_0139: nop
    IL_013E: call 0x0A000111
    IL_013F: ldarg.0
    IL_0144: ldstr 0x70001EC5
    IL_0149: call 0x06000220
    IL_014E: stfld 0x04000CBA
    IL_014F: ldarg.0
    IL_0150: ldarg.0
    IL_0155: ldfld 0x04000C7E
    IL_015A: stfld 0x04000C84
    IL_015B: ldarg.0
    IL_0160: ldstr 0x70023875
    IL_0165: stfld 0x04000CBC
    IL_0166: ldarg.0
    IL_0168: ldc.i4.s 9
    IL_016D: newarr 0x0100000C
    IL_016E: dup
    IL_016F: ldc.i4.0
    IL_0174: ldstr 0x70023085
    IL_0179: stelem 0x00721725
    IL_017E: brfalse IL_25A27181
    IL_017F: ldc.i4.2
    IL_0184: ldstr 0x70002A2B
    IL_0189: stelem 0x27721925
    IL_018A: IL_34
    IL_018B: ldarg.0
    IL_0190: cpobj 0x721A25A2
    IL_0191: ldarg.2
    IL_0196: brfalse IL_25A27199
    IL_0197: ldc.i4.5
    IL_019C: ldstr 0x7000265B
    IL_01A1: stelem 0x08721C25
    IL_01A6: brfalse IL_25A271A9
    IL_01A7: ldc.i4.7
    IL_01AC: ldstr 0x7002390E
    IL_01B1: stelem 0x997E1E25
    IL_01B2: nop
    IL_01B3: nop
    IL_01B4: stloc.0
    IL_01B9: stelem 0x000CAB7D
    IL_01BA: ldarg.2
    IL_01BB: ldc.i4.0
    IL_01BC: stloc.0
    IL_01C1: br IL_01E3
    IL_01C2: ldarg.0
    IL_01C7: ldfld 0x04000CA6
    IL_01C8: ldloc.0
    IL_01C9: ldarg.0
    IL_01CE: ldfld 0x04000CD0
    IL_01CF: ldarg.0
    IL_01D4: ldfld 0x04000CD3
    IL_01D5: ldloc.0
    IL_01D6: ldc.i4.6
    IL_01D7: IL_58
    IL_01D8: IL_94
    IL_01D9: conv.r8
    IL_01DA: IL_FC
    IL_01DB: ldloc.0
    IL_01DC: nop
    IL_01DD: ldloc.0
    IL_01DE: ldelem.i8
    IL_01DF: ldloc.0
    IL_01E0: ldc.i4.1
    IL_01E1: IL_58
    IL_01E2: stloc.0
    IL_01E3: ldloc.0
    IL_01E5: ldc.i4.s 10
    IL_01E6: IL_3F
    IL_01E7: IL_D7
    IL_01E8: IL_FF
    IL_01E9: IL_FF
    IL_01EA: IL_FF
    IL_01EB: ldarg.0
    IL_01EC: ldarg.0
    IL_01F1: ldfld 0x04000CD3
    IL_01F2: ldarg.0
    IL_01F7: ldfld 0x04000CBD
    IL_01F8: IL_94
    IL_01FD: call 0x06000659
    IL_01FE: ldarg.0
    IL_01FF: ldarg.0
    IL_0204: ldfld 0x04000CD4
    IL_0205: ldarg.0
    IL_020A: ldfld 0x04000CBE
    IL_020B: IL_94
    IL_0210: call 0x0600065A
    IL_0211: ldarg.0
    IL_0212: ldarg.0
    IL_0217: ldfld 0x04000CBE
    IL_0218: ldc.i4.6
    IL_0219: IL_59
    IL_021E: stfld 0x04000CC0
    IL_021F: ldarg.0
    IL_0224: ldfld 0x04000CD2
    IL_0225: ldarg.0
    IL_022A: ldfld 0x04000CC2
    IL_022B: ldarg.0
    IL_0230: ldfld 0x04000CC3
    IL_0231: conv.r8
    IL_0232: IL_E8
    IL_0233: IL_01
    IL_0234: nop
    IL_0235: ldloc.0
    IL_0236: ldc.i4.0
    IL_0237: stloc.1
    IL_023C: br IL_0258
    IL_023D: ldarg.0
    IL_0242: ldfld 0x04000C8C
    IL_0243: ldloc.1
    IL_0244: conv.r8
    IL_0249: brtrue IL_6F0A024A
    IL_024A: stloc.0
    IL_024B: nop
    IL_024C: nop
    IL_024D: stloc.0
    IL_024E: ldc.i4.2
    IL_024F: conv.r8
    IL_0250: ldc.i4.m1
    IL_0251: nop
    IL_0252: nop
    IL_0253: stloc.0
    IL_0254: ldloc.1
    IL_0255: ldc.i4.1
    IL_0256: IL_58
    IL_0257: stloc.1
    IL_0258: ldloc.1
    IL_0259: ldarg.0
    IL_025E: ldfld 0x04000C8C
    IL_025F: conv.r8
    IL_0261: beq.s IL_0263
    IL_0262: nop
    IL_0263: stloc.0
    IL_0264: IL_3F
    IL_0265: IL_D4
    IL_0266: IL_FF
    IL_0267: IL_FF
    IL_0268: IL_FF
    IL_0269: ret
    }

    private void OnApplicationPause() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0026
    IL_0006: ldarg.0
    IL_000B: ldstr 0x70001EA5
    IL_0010: call 0x06000220
    IL_0015: stfld 0x04000C98
    IL_0016: ldarg.0
    IL_001B: ldstr 0x700004D5
    IL_0020: call 0x06000220
    IL_0025: stfld 0x04000C99
    IL_0026: ret
    }

    public void SetUpWeapon() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000CD0
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_FD
    IL_0009: ldloc.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000CD0
    IL_0017: ldfld 0x04000FED
    IL_001C: stfld 0x04000CC2
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000CD0
    IL_0028: ldfld 0x04000FEE
    IL_002D: stfld 0x04000CC3
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000CD0
    IL_0039: ldfld 0x04000FF4
    IL_003E: stfld 0x04000CC4
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000CD0
    IL_004A: ldfld 0x04000FEF
    IL_004F: stfld 0x04000CC5
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000CD0
    IL_005B: ldfld 0x04000FF0
    IL_0060: stfld 0x04000CC6
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000CD0
    IL_006C: ldfld 0x04000FF1
    IL_0071: stfld 0x04000CC7
    IL_0072: ldarg.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000CD0
    IL_007D: ldfld 0x04000FF2
    IL_0082: stfld 0x04000CC8
    IL_0083: ldarg.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000CD0
    IL_008E: ldfld 0x04000FF3
    IL_0093: stfld 0x04000CC9
    IL_0094: ldarg.0
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000CD0
    IL_009F: ldfld 0x04000FF6
    IL_00A4: stfld 0x04000CCA
    IL_00A5: ret
    }

    public void SetUpArmor() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0003: ldc.i4.s 100
    IL_0004: mul
    IL_0009: stfld 0x04000CCB
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
    IL_003E: stfld 0x04000CCC
    IL_003F: ldarg.0
    IL_0040: ldarg.1
    IL_0045: stfld 0x04000CCD
    IL_0046: ret
    }

    public void OnBillingResult() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x0600065D
    IL_0007: ret
    }

    private void PayCallBack() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: conv.r8
    IL_0004: ldelem.i1
    IL_0005: nop
    IL_0006: nop
    IL_0007: stloc.0
    IL_0008: ldc.i4.2
    IL_0009: IL_59
    IL_000A: conv.r8
    IL_000B: ldelem.i2
    IL_000C: nop
    IL_000D: nop
    IL_000E: stloc.0
    IL_000F: stloc.0
    IL_0010: ldloc.0
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x0100002A
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_001A: ldc.i4.s 44
    IL_001B: ldelem.i4
    IL_001C: conv.r8
    IL_001D: ldelem.i4
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: stloc.1
    IL_0022: ldloc.1
    IL_0023: ldc.i4.0
    IL_0024: ldelem.i
    IL_0025: stloc.2
    IL_0026: ldloc.2
    IL_0027: ldc.i4.1
    IL_002C: newarr 0x0100002A
    IL_002D: dup
    IL_002E: ldc.i4.0
    IL_0030: ldc.i4.s 58
    IL_0031: ldelem.i4
    IL_0032: conv.r8
    IL_0033: ldelem.i4
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: stloc.3
    IL_0038: ldloc.3
    IL_0039: ldc.i4.1
    IL_003A: ldelem.i
    IL_003B: ldc.i4.1
    IL_003C: ldloc.3
    IL_003D: ldc.i4.1
    IL_003E: ldelem.i
    IL_003F: conv.r8
    IL_0040: ldelem.i1
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldc.i4.2
    IL_0045: IL_59
    IL_0046: conv.r8
    IL_0047: ldelem.i2
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004F: call 0x0A00009E
    IL_0051: stloc.s 4
    IL_0052: ldloc.1
    IL_0053: ldc.i4.2
    IL_0054: ldelem.i
    IL_0056: stloc.s 5
    IL_0058: ldloc.s 5
    IL_0059: ldc.i4.1
    IL_005E: newarr 0x0100002A
    IL_005F: dup
    IL_0060: ldc.i4.0
    IL_0062: ldc.i4.s 58
    IL_0063: ldelem.i4
    IL_0064: conv.r8
    IL_0065: ldelem.i4
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_006A: stloc.s 6
    IL_006C: ldloc.s 6
    IL_006D: ldc.i4.1
    IL_006E: ldelem.i
    IL_006F: ldc.i4.1
    IL_0071: ldloc.s 6
    IL_0072: ldc.i4.1
    IL_0073: ldelem.i
    IL_0074: conv.r8
    IL_0075: ldelem.i1
    IL_0076: nop
    IL_0077: nop
    IL_0078: stloc.0
    IL_0079: ldc.i4.2
    IL_007A: IL_59
    IL_007B: conv.r8
    IL_007C: ldelem.i2
    IL_007D: nop
    IL_007E: nop
    IL_007F: stloc.0
    IL_0084: call 0x0A00009E
    IL_0086: stloc.s 7
    IL_0088: ldloc.s 4
    IL_0089: ldc.i4.1
    IL_036E: switch (184 cases)
    }

    public void ItemDelivery() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_00DC
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000CAB
    IL_000D: ldloc.0
    IL_000E: ldelem.i
    IL_000F: ldarg.1
    IL_0014: call 0x0A0000EC
    IL_0019: brfalse IL_00D8
    IL_001A: ldarg.0
    IL_001B: dup
    IL_0020: ldfld 0x04000CB0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000CA1
    IL_0027: ldloc.0
    IL_0028: IL_98
    IL_0029: IL_22
    IL_002A: IL_CD
    IL_002B: IL_CC
    IL_002C: IL_CC
    IL_002D: IL_3D
    IL_002E: IL_58
    IL_002F: not
    IL_0030: IL_58
    IL_0035: stfld 0x04000CB0
    IL_003A: ldstr 0x700020A5
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000CB0
    IL_0045: call 0x0600021F
    IL_0046: ldarg.0
    IL_0047: dup
    IL_004C: ldfld 0x04000C99
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000CA0
    IL_0053: ldloc.0
    IL_0054: IL_94
    IL_0055: IL_58
    IL_005A: stfld 0x04000C99
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000CA0
    IL_0061: ldloc.0
    IL_0062: IL_94
    IL_0063: ldc.i4.1
    IL_0068: call 0x0600021E
    IL_0069: pop
    IL_006A: ldc.i4.6
    IL_006F: newarr 0x0100000C
    IL_0070: dup
    IL_0071: ldc.i4.0
    IL_0076: ldsfld 0x040007B2
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000C96
    IL_0081: ldc.i4 233
    IL_0086: call 0x0A0000E1
    IL_008B: stelem 0x89721725
    IL_008C: IL_37
    IL_008D: ldarg.0
    IL_0092: cpobj 0x021825A2
    IL_0097: ldfld 0x04000CA0
    IL_0098: ldloc.0
    IL_0099: IL_8F
    IL_009A: stloc.1
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_01
    IL_00A2: call 0x0A000010
    IL_00A7: stelem 0x8F721925
    IL_00A8: IL_37
    IL_00A9: ldarg.0
    IL_00AE: cpobj 0x021A25A2
    IL_00B3: ldfld 0x04000CA1
    IL_00B4: ldloc.0
    IL_00B5: IL_8F
    IL_00B7: bge.s IL_00B8
    IL_00B8: nop
    IL_00B9: IL_01
    IL_00BE: call 0x0A000208
    IL_00C3: stelem 0x7B021B25
    IL_00C4: IL_D6
    IL_00C5: stloc.2
    IL_00C6: nop
    IL_00C7: ldarg.2
    IL_00CC: stelem 0x00024028
    IL_00CD: stloc.0
    IL_00D2: call 0x0600040D
    IL_00D7: br IL_00E3
    IL_00D8: ldloc.0
    IL_00D9: ldc.i4.1
    IL_00DA: IL_58
    IL_00DB: stloc.0
    IL_00DC: ldloc.0
    IL_00DD: ldc.i4.6
    IL_00DE: IL_3F
    IL_00DF: IL_24
    IL_00E0: IL_FF
    IL_00E1: IL_FF
    IL_00E2: IL_FF
    IL_00E3: ret
    }

    public void closePage() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_000A: call 0x0A000050
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000C94
    IL_0011: ldc.i4.1
    IL_0012: conv.r8
    IL_0013: stloc.1
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000C95
    IL_001D: ldnull
    IL_0022: call 0x0A000021
    IL_0027: brfalse IL_0034
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000C95
    IL_002E: ldc.i4.1
    IL_002F: conv.r8
    IL_0030: stloc.1
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_003B: stsfld 0x0111283F
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000C9D
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000E: stsfld 0x013128C2
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000C9C
    IL_0017: IL_59
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_FA
    IL_001C: IL_43
    IL_001D: IL_5A
    IL_0022: call 0x0A0000C0
    IL_0027: stfld 0x04000C9D
    IL_0028: ldarg.0
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_F0
    IL_002D: IL_43
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0037: call 0x0A000131
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000C9C
    IL_003E: IL_59
    IL_003F: IL_22
    IL_0040: nop
    IL_0045: stsfld 0x285A44BB
    IL_0046: IL_C0
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004E: stfld 0x04000C9E
    IL_004F: ldarg.0
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: IL_AA
    IL_0054: IL_43
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_0058: shr
    IL_0059: IL_43
    IL_005E: call 0x0A000131
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000C9C
    IL_0065: IL_59
    IL_0066: IL_22
    IL_0067: nop
    IL_0068: nop
    IL_0069: IL_FA
    IL_006A: IL_43
    IL_006B: IL_5A
    IL_0070: call 0x0A0000C0
    IL_0075: stfld 0x04000C9F
    IL_0076: ldc.i4.0
    IL_007B: call 0x0A0000D6
    IL_0080: brfalse IL_00C4
    IL_0085: call 0x0A0000D7
    IL_0086: stloc.2
    IL_0088: ldloca.s 2
    IL_008D: ldfld 0x0A000023
    IL_008E: ldarg.0
    IL_0093: ldfld 0x04000C93
    IL_0094: IL_41
    IL_0095: pop
    IL_0096: nop
    IL_0097: nop
    IL_0098: nop
    IL_0099: ldarg.0
    IL_009A: ldc.i4.1
    IL_009F: stfld 0x04000C8E
    IL_00A0: ldarg.0
    IL_00A5: call 0x0A0000D7
    IL_00A6: stloc.3
    IL_00A8: ldloca.s 3
    IL_00AD: ldfld 0x0A00005E
    IL_00B2: stfld 0x04000C91
    IL_00B3: ldarg.0
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x04000C90
    IL_00BE: stfld 0x04000C92
    IL_00C3: br IL_00DD
    IL_00C4: ldc.i4.0
    IL_00C9: call 0x0A0000D8
    IL_00CE: brfalse IL_00DD
    IL_00CF: ldarg.0
    IL_00D0: ldc.i4.0
    IL_00D5: stfld 0x04000C8E
    IL_00D6: ldarg.0
    IL_00D7: ldc.i4.0
    IL_00DC: stfld 0x04000C8F
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x04000C8E
    IL_00E7: brfalse IL_016E
    IL_00EC: call 0x0A0000D7
    IL_00EE: stloc.s 4
    IL_00F0: ldloca.s 4
    IL_00F5: ldfld 0x0A00005E
    IL_00F6: ldarg.0
    IL_00FB: ldfld 0x04000C91
    IL_00FC: IL_59
    IL_0101: call 0x0A00007F
    IL_0102: IL_22
    IL_0103: nop
    IL_0104: nop
    IL_0107: ldloc 17219
    IL_0108: ldloc.1
    IL_0109: nop
    IL_010A: nop
    IL_010B: nop
    IL_010C: ldarg.0
    IL_010D: ldc.i4.1
    IL_0112: stfld 0x04000C8F
    IL_0113: ldarg.0
    IL_0118: call 0x0A0000D7
    IL_011A: stloc.s 5
    IL_011C: ldloca.s 5
    IL_0121: ldfld 0x0A00005E
    IL_0122: ldarg.0
    IL_0127: ldfld 0x04000C91
    IL_0128: IL_59
    IL_0129: IL_22
    IL_012A: nop
    IL_012B: nop
    IL_012C: IL_F0
    IL_012D: IL_43
    IL_0132: call 0x0A0000D9
    IL_0133: conv.i2
    IL_0134: add
    IL_0135: IL_5A
    IL_0136: ldarg.0
    IL_013B: ldfld 0x04000C92
    IL_013C: IL_58
    IL_0141: stfld 0x04000C90
    IL_0142: ldarg.0
    IL_0143: ldarg.0
    IL_0148: ldfld 0x04000C90
    IL_0149: IL_22
    IL_014A: nop
    IL_014B: nop
    IL_014C: nop
    IL_014D: nop
    IL_0152: call 0x0A000114
    IL_0157: stfld 0x04000C90
    IL_0158: ldarg.0
    IL_0159: ldarg.0
    IL_015E: ldfld 0x04000C90
    IL_015F: IL_22
    IL_0160: nop
    IL_0161: nop
    IL_0162: IL_96
    IL_0163: IL_C3
    IL_0168: call 0x0A00019C
    IL_016D: stfld 0x04000C90
    IL_0172: ldstr 0x70000575
    IL_0177: call 0x0A000097
    IL_0178: stloc.0
    IL_0179: ldloc.0
    IL_017E: ldstr 0x70000583
    IL_017F: conv.r8
    IL_0180: len
    IL_0181: nop
    IL_0182: nop
    IL_0183: stloc.0
    IL_0188: brtrue IL_01B8
    IL_0189: ldarg.0
    IL_018E: ldstr 0x70001EA5
    IL_0193: call 0x06000220
    IL_0198: stfld 0x04000C98
    IL_0199: ldarg.0
    IL_019E: ldstr 0x700004D5
    IL_01A3: call 0x06000220
    IL_01A8: stfld 0x04000C99
    IL_01AD: ldstr 0x70000575
    IL_01B2: ldstr 0x70022ADA
    IL_01B7: call 0x0A00008F
    IL_01BC: ldstr 0x7000064F
    IL_01C1: call 0x0A000095
    IL_01C2: stloc.1
    IL_01C3: ldloc.1
    IL_01C4: ldc.i4.1
    IL_0275: switch (43 cases)
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
    IL_003B: ldfld 0x04000C6B
    IL_0040: call 0x0A0000DF
    IL_0042: ldc.i4.s -10
    IL_0047: call 0x0A0000EF
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_E0
    IL_004C: IL_42
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0059: stsfld 0x00002243
    IL_005A: nop
    IL_005B: IL_42
    IL_0060: call 0x0600021D
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000C76
    IL_006B: call 0x0A0000E0
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_0070: ldloca.s 67
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_C0
    IL_280000101: switch (2684354594 cases)
    }

    }}
