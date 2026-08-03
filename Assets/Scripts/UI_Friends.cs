// Namespace: 
// Type: UI_Friends

    public class UI_Friends {{

    private static object MAX_FB_FRIENDS;
    private static object MAX_HSP_FRIENDS;
    private static object RECOMMEND_FRIENDS;
    private object mykeyboard;
    private object ff;
    private object hf;
    private object rf;
    private object fb_friend_num;
    private object hsp_friend_num;
    private object recommend_num;
    public object bg_title;
    public object bg_title_me;
    public object icon_key;
    public object toggle_active;
    public object errorimg;
    public object icon_ranktab;
    public object please_touch;
    private object myimage;
    public object bt_empty;
    public object bt_start;
    public object bt_back;
    public object bt_plus;
    public object bt_remove;
    public object bt_yesno;
    public object basicSkin;
    private object curMousePosY;
    private object startMousePosY;
    private object scrollPosition;
    private object prev_scrollPosition;
    private object language;
    private object posX_l;
    private object posX_r;
    private object posY;
    private object ui;
    private object reload;
    private object facebooklogin;
    private object facebook_load;
    private object keyboardactive;
    private object tempnick;
    private object mode;
    private object currenttab;
    private object icon_size;
    private object confirm;
    private object version;
    private object access_token;
    private object detail_count;

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: ldc.i4 5000
    IL_000A: newarr 0x0200010E
    IL_000F: stfld 0x04000B20
    IL_0010: ldarg.0
    IL_0012: ldc.i4.s 100
    IL_0017: newarr 0x0200010F
    IL_001C: stfld 0x04000B21
    IL_001D: ldarg.0
    IL_001F: ldc.i4.s 100
    IL_0024: newarr 0x02000110
    IL_0029: stfld 0x04000B22
    IL_002A: ldarg.0
    IL_002B: ldc.i4.5
    IL_0030: stfld 0x04000B23
    IL_0031: ldarg.0
    IL_0032: ldc.i4.5
    IL_0037: newarr 0x0100003C
    IL_003C: stfld 0x04000B2B
    IL_003D: ldarg.0
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: IL_C8
    IL_0042: IL_C2
    IL_0047: stfld 0x04000B3A
    IL_0048: ldarg.0
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: IL_FA
    IL_004D: IL_43
    IL_0052: stfld 0x04000B3B
    IL_0053: ldarg.0
    IL_0054: IL_22
    IL_0055: nop
    IL_0056: nop
    IL_0057: IL_E4
    IL_0058: IL_42
    IL_005D: stfld 0x04000B3C
    IL_005E: ldarg.0
    IL_0063: ldstr 0x7002342B
    IL_0068: stfld 0x04000B48
    IL_0069: ldarg.0
    IL_006E: call 0x0A000001
    IL_006F: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000B39
    IL_0010: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x060005FE
    IL_0006: ldarg.0
    IL_0007: ldc.i4.0
    IL_000C: call 0x060005F6
    IL_000D: ldarg.0
    IL_0012: ldstr 0x70023285
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_001A: stsfld 0x147B223F
    IL_001B: IL_AE
    IL_001C: IL_3E
    IL_0021: call 0x0A000017
    IL_0022: ret
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000B45
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000B45
    IL_0010: ret
    }

    public void SetMyImage() {
    IL_0000: ret
    }

    private void MyImageLoading() {
    IL_0004: newobj 0x060007A5
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x0400107C
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x04001080
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_001A: stfld 0x04001081
    IL_001B: ldloc.0
    IL_001C: ret
    }

    public void FaceLoginFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B3F
    IL_0007: ldarg.0
    IL_0008: ldarg.0
    IL_000D: call 0x060005FB
    IL_0012: call 0x0A000047
    IL_0013: pop
    IL_0014: ret
    }

    private void GetFaceBookMe() {
    IL_0004: newobj 0x060007AB
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001088
    IL_000D: ldloc.0
    IL_000E: ret
    }

    private void GetMyFacebookImg() {
    IL_0004: newobj 0x060007B1
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x04001089
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x0400108D
    IL_0014: ldloc.0
    IL_0015: ret
    }

    private void GetFaceBookFriends() {
    IL_0004: newobj 0x060007B7
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001096
    IL_000D: ldloc.0
    IL_000E: ret
    }

    private void GetFacebookImg() {
    IL_0004: newobj 0x060007BD
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x04001097
    IL_000D: ldloc.0
    IL_000E: ldarg.2
    IL_0013: stfld 0x04001099
    IL_0014: ldloc.0
    IL_0015: ldarg.1
    IL_001A: stfld 0x0400109C
    IL_001B: ldloc.0
    IL_001C: ldarg.2
    IL_0021: stfld 0x0400109D
    IL_0022: ldloc.0
    IL_0023: ldarg.0
    IL_0028: stfld 0x0400109E
    IL_0029: ldloc.0
    IL_002A: ret
    }

    public void ChangeNickName() {
    IL_0000: ret
    }

    public void GetHSPFriends() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: newarr 0x0200010F
    IL_000C: stfld 0x04000B21
    IL_000D: ldarg.0
    IL_000E: ldc.i4.1
    IL_0013: stfld 0x04000B3E
    IL_0014: ret
    }

    public void RemoveHSPFriends() {
    IL_0000: ldc.i4.1
    IL_0005: newobj 0x0A0002EF
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldarg.1
    IL_0009: conv.r8
    IL_000A: IL_F0
    IL_000B: ldarg.0
    IL_000C: nop
    IL_000D: stloc.0
    IL_000E: ret
    }

    public void SetMemberNos() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: newarr 0x02000110
    IL_000C: stfld 0x04000B22
    IL_000D: ldarg.0
    IL_000E: ldc.i4.0
    IL_0013: stfld 0x04000B25
    IL_0014: ldc.i4.0
    IL_0015: stloc.0
    IL_0016: ldarg.1
    IL_0017: conv.r8
    IL_0018: IL_F1
    IL_0019: ldarg.0
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: stloc.2
    IL_0021: br IL_0081
    IL_0023: ldloca.s 2
    IL_0028: call 0x0A0002F2
    IL_0029: stloc.1
    IL_002A: ldarg.0
    IL_002F: ldfld 0x04000B44
    IL_0030: stloc.3
    IL_0031: ldloc.3
    IL_0032: ldc.i4.0
    IL_0037: beq IL_003D
    IL_003C: br IL_005F
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000B21
    IL_0043: ldloc.0
    IL_0044: IL_8F
    IL_0046: ldarga.s 1
    IL_0047: nop
    IL_0048: ldarg.0
    IL_0049: ldloc.1
    IL_004E: stfld 0x04000B4F
    IL_004F: ldloc.0
    IL_0050: ldc.i4.1
    IL_0051: IL_58
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0054: ldloc.0
    IL_0059: stfld 0x04000B24
    IL_005E: br IL_0081
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000B22
    IL_0065: ldloc.0
    IL_0066: IL_8F
    IL_0068: starg.s 1
    IL_0069: nop
    IL_006A: ldarg.0
    IL_006B: ldloc.1
    IL_0070: stfld 0x04000B52
    IL_0071: ldloc.0
    IL_0072: ldc.i4.1
    IL_0073: IL_58
    IL_0074: stloc.0
    IL_0075: ldarg.0
    IL_0076: ldloc.0
    IL_007B: stfld 0x04000B25
    IL_0080: br IL_0081
    IL_0082: ldloca.s 2
    IL_0087: call 0x0A0002F3
    IL_008C: brtrue IL_0022
    IL_008D: IL_DD
    IL_008E: stloc.2
    IL_008F: nop
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldloc.2
    IL_0097: newobj 0x1B000021
    IL_0098: conv.r8
    IL_0099: ldelem.ref
    IL_009A: nop
    IL_009B: nop
    IL_009C: stloc.0
    IL_009D: IL_DC
    IL_009E: ret
    }

    public void JudgeFriend() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B22
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000B49
    IL_000C: IL_8F
    IL_000E: starg.s 1
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0016: stfld 0x04000B55
    IL_0017: ldarg.0
    IL_0018: dup
    IL_001D: ldfld 0x04000B49
    IL_001E: ldc.i4.1
    IL_001F: IL_58
    IL_0024: stfld 0x04000B49
    IL_0025: ret
    }

    public void HSPFriendsImg() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.1
    IL_0003: conv.r8
    IL_0004: IL_F4
    IL_0005: ldarg.0
    IL_0006: nop
    IL_0007: stloc.0
    IL_0008: stloc.2
    IL_000D: br IL_0029
    IL_000F: ldloca.s 2
    IL_0014: call 0x0A0002F5
    IL_0015: stloc.1
    IL_0016: ldarg.0
    IL_0017: ldarg.0
    IL_0018: ldloc.1
    IL_0019: ldloc.0
    IL_001E: call 0x06000603
    IL_0023: call 0x0A000047
    IL_0024: pop
    IL_0025: ldloc.0
    IL_0026: ldc.i4.1
    IL_0027: IL_58
    IL_0028: stloc.0
    IL_002A: ldloca.s 2
    IL_002F: call 0x0A0002F6
    IL_0034: brtrue IL_000E
    IL_0035: IL_DD
    IL_0036: stloc.2
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: ldloc.2
    IL_003F: newobj 0x1B000023
    IL_0040: conv.r8
    IL_0041: ldelem.ref
    IL_0042: nop
    IL_0043: nop
    IL_0044: stloc.0
    IL_0045: IL_DC
    IL_0046: ret
    }

    private void GetProfileImg() {
    IL_0004: newobj 0x060007C3
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x0400109F
    IL_000D: ldloc.0
    IL_000E: ldarg.2
    IL_0013: stfld 0x040010A1
    IL_0014: ldloc.0
    IL_0015: ldarg.1
    IL_001A: stfld 0x040010A4
    IL_001B: ldloc.0
    IL_001C: ldarg.2
    IL_0021: stfld 0x040010A5
    IL_0022: ldloc.0
    IL_0023: ldarg.0
    IL_0028: stfld 0x040010A6
    IL_0029: ldloc.0
    IL_002A: ret
    }

    private void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000B46
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000B3A
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_C8
    IL_000B: IL_42
    IL_0010: call 0x0A000024
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: throw
    IL_0015: IL_44
    IL_0016: IL_5A
    IL_001B: call 0x0A0000C0
    IL_0020: stfld 0x04000B3A
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000B3B
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: len
    IL_002C: IL_43
    IL_0031: call 0x0A000024
    IL_0032: IL_22
    IL_0033: nop
    IL_0034: nop
    IL_0035: throw
    IL_0036: IL_44
    IL_0037: IL_5A
    IL_003C: call 0x0A0000C0
    IL_0041: stfld 0x04000B3B
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000B41
    IL_0048: ldc.i4.0
    IL_0049: IL_3E
    IL_004A: IL_BA
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000B1F
    IL_0054: conv.r8
    IL_0055: IL_F7
    IL_0056: ldarg.0
    IL_0057: nop
    IL_0058: stloc.0
    IL_005D: brfalse IL_0108
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000B1F
    IL_0064: conv.r8
    IL_0065: IL_F8
    IL_0066: ldarg.0
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: stloc.0
    IL_006E: call 0x0A0002EE
    IL_006F: ldloc.0
    IL_0070: conv.r8
    IL_0071: IL_4E
    IL_0072: IL_01
    IL_0073: nop
    IL_0074: stloc.0
    IL_0075: len
    IL_0076: not
    IL_0077: stloc.1
    IL_0078: ldloc.1
    IL_0079: ldc.i4.4
    IL_007A: IL_3C
    IL_007C: bge.s IL_007D
    IL_007D: nop
    IL_007E: nop
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000B41
    IL_0085: ldc.i4.2
    IL_00A6: switch (7 cases)
    IL_00A7: nop
    IL_00A8: stloc.0
    IL_00AD: br IL_0101
    IL_00AE: ldloc.0
    IL_00B3: ldsfld 0x0A000099
    IL_00B8: call 0x0A0000A6
    IL_00BD: brfalse IL_00EE
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x04000B41
    IL_00C4: stloc.2
    IL_00C5: ldloc.2
    IL_00C6: ldc.i4.1
    IL_00CB: beq IL_00D8
    IL_00CC: ldloc.2
    IL_00CD: ldc.i4.2
    IL_00D2: beq IL_00E4
    IL_00D7: br IL_00E9
    IL_00D8: ldarg.0
    IL_00D9: ldloc.0
    IL_00DE: stfld 0x04000B42
    IL_00E3: br IL_00E9
    IL_00E8: br IL_00E9
    IL_00ED: br IL_0101
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x04000B41
    IL_00F4: ldc.i4.2
    IL_0115: switch (7 cases)
    }

    private void OnGUI() {
    IL_0001: ldc.i4.s -8
    IL_0006: call 0x0A0000EF
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B34
    IL_0011: call 0x0A0000DF
    IL_0016: call 0x0A00001B
    IL_001B: call 0x0A000013
    IL_0020: call 0x0A0000D9
    IL_0021: conv.i2
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: cpobj 0xDA285B44
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: conv.i2
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0035: ldc.i4 2251588
    IL_0036: nop
    IL_003B: stsfld 0x0076733F
    IL_003C: nop
    IL_003D: stloc.0
    IL_0042: call 0x0A0000DD
    IL_0047: call 0x0A0000DE
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000B46
    IL_004E: ldc.i4.0
    IL_004F: IL_3E
    IL_0050: ldloc.0
    IL_0051: nop
    IL_0052: nop
    IL_0053: nop
    IL_0054: ldc.i4.0
    IL_0059: call 0x0A0001B9
    IL_005A: IL_22
    IL_005B: nop
    IL_005C: nop
    IL_0061: ldtoken 0x00002243
    IL_0062: nop
    IL_0063: nop
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_006B: stsfld 0x00002242
    IL_0070: stsfld 0x021D2842
    IL_0071: nop
    IL_0072: ldloc.0
    IL_0077: ldsfld 0x0A000099
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000B30
    IL_0082: call 0x0A0000F1
    IL_0087: brfalse IL_0092
    IL_008C: ldstr 0x70022F8F
    IL_0091: call 0x0A000128
    IL_0096: call 0x0A000115
    IL_009B: brfalse IL_0100
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x04000B3B
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: IL_94
    IL_00A6: IL_42
    IL_00A7: IL_59
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x04000B3C
    IL_00AE: IL_22
    IL_00AF: nop
    IL_00B0: nop
    IL_00B5: ldtoken 0x00225941
    IL_00B6: nop
    IL_00B7: IL_81
    IL_00B8: IL_43
    IL_00B9: IL_22
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: IL_5A
    IL_00BD: IL_43
    IL_00C2: call 0x0600021D
    IL_00C4: stloc.s 7
    IL_00C6: ldloca.s 7
    IL_00CB: call 0x0A0001FE
    IL_00CC: conv.r8
    IL_00CD: IL_FF
    IL_00CE: IL_01
    IL_00CF: nop
    IL_00D0: stloc.0
    IL_00D5: call 0x0A000200
    IL_00DA: brfalse IL_00FB
    IL_00DB: ldarg.0
    IL_00E0: call 0x0A0000D7
    IL_00E2: stloc.s 8
    IL_00E4: ldloca.s 8
    IL_00E9: ldfld 0x0A000023
    IL_00EE: stfld 0x04000B36
    IL_00EF: ldarg.0
    IL_00F0: ldarg.0
    IL_00F5: ldfld 0x04000B37
    IL_00FA: stfld 0x04000B38
    IL_00FF: br IL_0196
    IL_0104: call 0x0A00011A
    IL_0109: brfalse IL_0196
    IL_010A: ldarg.0
    IL_010F: ldfld 0x04000B3B
    IL_0110: IL_22
    IL_0111: nop
    IL_0112: nop
    IL_0113: IL_94
    IL_0114: IL_42
    IL_0115: IL_59
    IL_0116: ldarg.0
    IL_011B: ldfld 0x04000B3C
    IL_011C: IL_22
    IL_011D: nop
    IL_011E: nop
    IL_0123: ldtoken 0x00225941
    IL_0124: nop
    IL_0125: IL_81
    IL_0126: IL_43
    IL_0127: IL_22
    IL_0128: nop
    IL_0129: nop
    IL_012A: IL_5A
    IL_012B: IL_43
    IL_0130: call 0x0600021D
    IL_0132: stloc.s 9
    IL_0134: ldloca.s 9
    IL_0139: call 0x0A0001FE
    IL_013A: conv.r8
    IL_013B: IL_FF
    IL_013C: IL_01
    IL_013D: nop
    IL_013E: stloc.0
    IL_0143: call 0x0A000200
    IL_0148: brfalse IL_0196
    IL_0149: ldarg.0
    IL_014E: call 0x0A0000D7
    IL_0150: stloc.s 10
    IL_0152: ldloca.s 10
    IL_0157: ldfld 0x0A000023
    IL_015C: stfld 0x04000B35
    IL_015D: ldarg.0
    IL_015E: ldarg.0
    IL_0163: ldfld 0x04000B38
    IL_0168: call 0x0A0000AA
    IL_0169: ldarg.0
    IL_016E: ldfld 0x04000B35
    IL_016F: ldarg.0
    IL_0174: ldfld 0x04000B36
    IL_0175: IL_59
    IL_017A: call 0x0A000083
    IL_017B: IL_22
    IL_017C: nop
    IL_017D: nop
    IL_0182: ldc.i4 14297156
    IL_0183: nop
    IL_0184: stloc.0
    IL_0185: conv.i2
    IL_0186: add
    IL_018B: call 0x0A000083
    IL_0190: call 0x0A0000AB
    IL_0195: stfld 0x04000B37
    IL_0196: ldarg.0
    IL_019B: ldfld 0x04000B3B
    IL_019C: IL_22
    IL_019D: nop
    IL_019E: nop
    IL_019F: IL_94
    IL_01A0: IL_42
    IL_01A1: IL_59
    IL_01A2: ldarg.0
    IL_01A7: ldfld 0x04000B3C
    IL_01A8: IL_22
    IL_01A9: nop
    IL_01AA: nop
    IL_01AF: call 0x00225942
    IL_01B0: nop
    IL_01B1: IL_83
    IL_01B2: IL_43
    IL_01B3: IL_22
    IL_01B4: nop
    IL_01B5: nop
    IL_01BA: cpobj 0x021D2843
    IL_01BB: nop
    IL_01BC: ldloc.0
    IL_01C1: ldsfld 0x0A000099
    IL_01C6: ldstr 0x70022A46
    IL_01CB: call 0x0A0000E2
    IL_01D0: call 0x0A0001BA
    IL_01D1: ldarg.0
    IL_01D6: ldfld 0x04000B3B
    IL_01D7: IL_22
    IL_01D8: nop
    IL_01D9: nop
    IL_01DA: ldind.ref
    IL_01DB: IL_42
    IL_01DC: IL_59
    IL_01DD: ldarg.0
    IL_01E2: ldfld 0x04000B3C
    IL_01E3: IL_22
    IL_01E4: nop
    IL_01E5: nop
    IL_01E6: IL_94
    IL_01E7: IL_42
    IL_01E8: IL_59
    IL_01E9: IL_22
    IL_01EA: nop
    IL_01EB: nop
    IL_01EC: IL_C0
    IL_01ED: IL_42
    IL_01EE: IL_22
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: nop
    IL_01F2: IL_42
    IL_01F7: call 0x0600021D
    IL_01FC: ldsfld 0x0A000099
    IL_0201: ldstr 0x70022A6C
    IL_0206: call 0x0A0000E2
    IL_020B: call 0x0A0001BA
    IL_020C: ldarg.0
    IL_0211: ldfld 0x04000B3B
    IL_0212: IL_22
    IL_0213: nop
    IL_0214: nop
    IL_0215: ldind.ref
    IL_0216: IL_42
    IL_0217: IL_59
    IL_0218: ldarg.0
    IL_021D: ldfld 0x04000B3C
    IL_021E: IL_22
    IL_021F: nop
    IL_0220: nop
    IL_0221: IL_94
    IL_0222: IL_42
    IL_0223: IL_59
    IL_0224: IL_22
    IL_0225: nop
    IL_0226: nop
    IL_0227: IL_C0
    IL_0228: IL_42
    IL_0229: IL_22
    IL_022A: nop
    IL_022B: nop
    IL_022C: nop
    IL_022D: IL_42
    IL_0232: call 0x0600021D
    IL_0237: ldsfld 0x0A000099
    IL_0238: ldarg.0
    IL_023D: ldfld 0x04000B2E
    IL_0242: call 0x0A0000F1
    IL_0247: brfalse IL_0260
    IL_0248: ldarg.0
    IL_0249: ldc.i4.0
    IL_024E: stfld 0x04000B44
    IL_024F: ldarg.0
    IL_0254: ldfld 0x04000B3E
    IL_0259: brtrue IL_0260
    IL_025A: ldarg.0
    IL_025F: call 0x060005FE
    IL_0260: ldarg.0
    IL_0265: ldfld 0x04000B44
    IL_026A: brtrue IL_0444
    IL_026B: ldarg.0
    IL_026C: ldarg.0
    IL_0271: ldfld 0x04000B3B
    IL_0272: IL_22
    IL_0273: nop
    IL_0274: nop
    IL_0275: IL_94
    IL_0276: IL_42
    IL_0277: IL_59
    IL_0278: ldarg.0
    IL_027D: ldfld 0x04000B3C
    IL_027E: IL_22
    IL_027F: nop
    IL_0280: nop
    IL_0285: ldtoken 0x00225941
    IL_0286: nop
    IL_0287: IL_81
    IL_0288: IL_43
    IL_0289: IL_22
    IL_028A: nop
    IL_028B: nop
    IL_028C: IL_5A
    IL_028D: IL_43
    IL_0292: call 0x0600021D
    IL_0293: ldarg.0
    IL_0298: ldfld 0x04000B37
    IL_0299: IL_22
    IL_029A: nop
    IL_029B: nop
    IL_029C: nop
    IL_029D: nop
    IL_029E: IL_22
    IL_029F: nop
    IL_02A0: nop
    IL_02A1: nop
    IL_02A2: nop
    IL_02A3: IL_22
    IL_02A4: nop
    IL_02A5: nop
    IL_02AA: ldstr 0x247B0243
    IL_02AB: stloc.1
    IL_02AC: nop
    IL_02AD: ldarg.2
    IL_02AF: ldc.i4.s 44
    IL_02B0: IL_5A
    IL_02B1: conv.i2
    IL_02B6: call 0x0600021D
    IL_02BB: call 0x0A000201
    IL_02C0: stfld 0x04000B37
    IL_02C1: ldc.i4.0
    IL_02C2: stloc.0
    IL_02C7: br IL_03FC
    IL_02C8: ldarg.0
    IL_02CD: ldflda 0x04000B37
    IL_02D2: ldfld 0x0A00005A
    IL_02D3: ldloc.0
    IL_02D5: ldc.i4.s 88
    IL_02D6: IL_5A
    IL_02D7: conv.i2
    IL_02D8: IL_59
    IL_02D9: IL_22
    IL_02DA: nop
    IL_02DB: nop
    IL_02DC: ldelem.r8
    IL_02DD: IL_42
    IL_02DE: IL_3D
    IL_02DF: ldc.i4.5
    IL_02E0: nop
    IL_02E1: nop
    IL_02E2: nop
    IL_02E3: ldarg.0
    IL_02E8: ldflda 0x04000B37
    IL_02ED: ldfld 0x0A00005A
    IL_02EE: ldloc.0
    IL_02F0: ldc.i4.s 88
    IL_02F1: IL_5A
    IL_02F2: conv.i2
    IL_02F3: IL_59
    IL_02F4: IL_22
    IL_02F5: nop
    IL_02F6: nop
    IL_02F7: IL_DB
    IL_02F8: IL_C3
    IL_02F9: IL_41
    IL_02FA: ldarg.3
    IL_02FB: nop
    IL_02FC: nop
    IL_02FD: nop
    IL_0302: br IL_03F7
    IL_0303: IL_22
    IL_0304: nop
    IL_0305: nop
    IL_B07C1C0E: switch (740230721 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: stfld 0x04000B56
    IL_0008: ldarg.0
    IL_000A: ldc.i4.s 100
    IL_000F: stfld 0x04000B57
    IL_0010: ldarg.0
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_C8
    IL_0015: IL_42
    IL_001A: stfld 0x04000B58
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_C8
    IL_0020: IL_42
    IL_0025: stfld 0x04000B59
    IL_0026: ldarg.0
    IL_0027: ldc.i4.1
    IL_002C: stfld 0x04000B5B
    IL_002D: ldarg.0
    IL_002E: ldc.i4.1
    IL_0033: stfld 0x04000B63
    IL_0034: ldarg.0
    IL_0035: ldc.i4.2
    IL_003A: newarr 0x01000003
    IL_003F: stfld 0x04000B70
    IL_0040: ldarg.0
    IL_0041: ldc.i4.3
    IL_0046: newarr 0x0100003C
    IL_004B: stfld 0x04000B71
    IL_004C: ldarg.0
    IL_004D: ldc.i4.m1
    IL_0052: stfld 0x04000B8C
    IL_0053: ldarg.0
    IL_0054: ldc.i4.m1
    IL_0059: stfld 0x04000B9B
    IL_005A: ldarg.0
    IL_005B: ldc.i4.1
    IL_0060: stfld 0x04000BAE
    IL_0061: ldarg.0
    IL_0066: call 0x0A000001
    IL_0067: ret
    }

    private void OnApplicationPause() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0007
    IL_0006: ret
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BA5
    IL_000D: ldnull
    IL_0012: call 0x0A000021
    IL_0017: brfalse IL_0033
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000B72
    IL_001E: conv.r8
    IL_001F: stloc.0
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: conv.r8
    IL_0024: IL_CA
    IL_0025: IL_01
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: brtrue IL_0033
    IL_002D: ldarg.0
    IL_0032: call 0x06000626
    IL_0033: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700004DD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000B99
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000DDD
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000B5B
    IL_0020: ldarg.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000B5B
    IL_002B: stfld 0x04000B80
    IL_002C: ldarg.0
    IL_0031: ldstr 0x70000DE5
    IL_0036: call 0x06000220
    IL_0037: conv.i2
    IL_003C: stfld 0x04000B5A
    IL_003D: ldarg.0
    IL_0042: ldstr 0x70023585
    IL_0047: call 0x0A000095
    IL_004C: stfld 0x04000BA0
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000B72
    IL_0054: conv.r8
    IL_0059: stsfld 0x7D2B0000
    IL_005E: castclass 0x0204000B
    IL_0063: ldstr 0x70000001
    IL_0068: call 0x0A000004
    IL_0069: conv.r8
    IL_006A: ldarg.3
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_0072: stfld 0x04000B7E
    IL_0073: ldarg.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x04000B7E
    IL_007A: conv.r8
    IL_007B: stloc.2
    IL_007C: nop
    IL_007D: nop
    IL_007F: br.s IL_00FD
    IL_0084: stelem 0x0204000B
    IL_0089: ldstr 0x70000311
    IL_008E: call 0x0A000004
    IL_008F: conv.r8
    IL_0094: ldc.i4 2099970048
    IL_0099: isinst 0x0204000B
    IL_009E: ldstr 0x70000063
    IL_00A3: call 0x0A000004
    IL_00A4: conv.r8
    IL_00A5: ldarg.0
    IL_00A6: nop
    IL_00A7: nop
    IL_00A9: br.s IL_0127
    IL_00AA: IL_A4
    IL_00AB: stloc.1
    IL_00AC: nop
    IL_00AD: ldarg.2
    IL_00AE: ldarg.0
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000B6C
    IL_00B5: conv.r8
    IL_00B6: IL_37
    IL_00B7: nop
    IL_00B8: nop
    IL_00BA: br.s IL_0138
    IL_00BB: stelem.i
    IL_00BC: stloc.1
    IL_00BD: nop
    IL_00BE: ldarg.2
    IL_00BF: ldarg.0
    IL_00C0: ldarg.0
    IL_00C5: ldfld 0x04000BA4
    IL_00CA: ldfld 0x0400095D
    IL_00CF: stfld 0x04000B61
    IL_00D0: ldarg.0
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x04000BA4
    IL_00DB: ldfld 0x0400093E
    IL_00E0: stfld 0x04000B97
    IL_00E1: ldarg.0
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x04000B5B
    IL_00E8: conv.i2
    IL_00E9: IL_22
    IL_00EE: isinst 0x5A3B449B
    IL_00EF: IL_22
    IL_00F0: IL_CD
    IL_00F1: IL_CC
    IL_00F2: IL_4C
    IL_00F3: IL_3D
    IL_00F4: IL_58
    IL_00F9: stfld 0x04000B6B
    IL_00FA: ldarg.0
    IL_00FF: ldstr 0x70000BDB
    IL_0104: call 0x06000220
    IL_0109: stfld 0x04000B90
    IL_010A: ldarg.0
    IL_010F: ldstr 0x70001ED5
    IL_0114: call 0x06000220
    IL_0119: stfld 0x04000B8D
    IL_011E: ldstr 0x70001655
    IL_0123: call 0x0A000012
    IL_0124: conv.u8
    IL_0125: ldloc.0
    IL_0126: nop
    IL_0127: nop
    IL_0128: IL_01
    IL_0129: stloc.0
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000B61
    IL_0134: brfalse IL_0408
    IL_0135: ldarg.0
    IL_013A: ldstr 0x70022DD9
    IL_013F: call 0x06000220
    IL_0144: stfld 0x04000B94
    IL_0145: ldloc.0
    IL_0146: conv.r8
    IL_0147: ldarg.3
    IL_0148: nop
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: ldloc.0
    IL_014C: conv.r8
    IL_014D: ldarg.3
    IL_014E: nop
    IL_014F: nop
    IL_0150: stloc.0
    IL_0151: conv.r8
    IL_0152: add
    IL_0153: nop
    IL_0154: nop
    IL_0155: stloc.0
    IL_0156: IL_22
    IL_0157: IL_8F
    IL_0158: IL_C2
    IL_0159: IL_F5
    IL_015A: IL_3C
    IL_015B: IL_22
    IL_015C: stloc.0
    IL_015D: IL_D7
    IL_015E: stelem.i
    IL_015F: IL_BC
    IL_0160: IL_22
    IL_0161: nop
    IL_0162: nop
    IL_0163: nop
    IL_0164: nop
    IL_0169: newobj 0x0A000076
    IL_016E: call 0x0A000029
    IL_0173: call 0x0A000013
    IL_0178: call 0x0A000014
    IL_0179: conv.u4
    IL_017A: ldarg.1
    IL_017B: nop
    IL_017C: nop
    IL_017D: IL_01
    IL_017E: stloc.1
    IL_017F: ldarg.0
    IL_0180: ldloc.1
    IL_0181: conv.r8
    IL_0182: IL_24
    IL_0183: nop
    IL_0184: nop
    IL_0186: br.s IL_0204
    IL_018B: ldfld 0x0204000B
    IL_0190: ldfld 0x04000B7B
    IL_0191: IL_22
    IL_0192: IL_8F
    IL_0193: IL_C2
    IL_0194: IL_F5
    IL_0195: IL_3C
    IL_0196: conv.r8
    IL_0197: IL_B2
    IL_0198: IL_01
    IL_0199: nop
    IL_019A: stloc.0
    IL_019B: ldarg.0
    IL_01A0: ldfld 0x04000B7B
    IL_01A1: ldarg.0
    IL_01A6: ldflda 0x04000B94
    IL_01AB: call 0x0A000010
    IL_01AC: conv.r8
    IL_01AD: IL_FD
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: stloc.0
    IL_01B5: ldstr 0x70023599
    IL_01BA: call 0x0A000012
    IL_01BB: conv.u8
    IL_01BC: ldloc.0
    IL_01BD: nop
    IL_01BE: nop
    IL_01BF: IL_01
    IL_01C0: stloc.2
    IL_01C1: ldarg.0
    IL_01C2: ldloc.2
    IL_01C3: conv.r8
    IL_01C4: ldarg.3
    IL_01C5: nop
    IL_01C6: nop
    IL_01C7: stloc.0
    IL_01C8: ldloc.2
    IL_01C9: conv.r8
    IL_01CA: ldarg.3
    IL_01CB: nop
    IL_01CC: nop
    IL_01CD: stloc.0
    IL_01CE: conv.r8
    IL_01CF: add
    IL_01D0: nop
    IL_01D1: nop
    IL_01D2: stloc.0
    IL_01D7: call 0x0A000013
    IL_01DC: call 0x0A000014
    IL_01DD: conv.u4
    IL_01DE: ldarg.1
    IL_01DF: nop
    IL_01E0: nop
    IL_01E1: IL_01
    IL_01E6: stfld 0x04000B7C
    IL_01E7: ldarg.0
    IL_01E8: ldc.i4.0
    IL_01ED: stfld 0x04000B8D
    IL_01EE: ldarg.0
    IL_01F3: ldfld 0x04000BA3
    IL_01F4: IL_22
    IL_01F5: IL_EC
    IL_01F6: IL_51
    IL_01FB: br IL_-28F5DBC5
    IL_01FC: IL_23
    IL_01FD: IL_3E
    IL_0202: newobj 0x0A000038
    IL_0203: IL_22
    IL_0204: nop
    IL_0205: nop
    IL_0206: nop
    IL_0207: nop
    IL_0208: IL_22
    IL_0209: shr
    IL_020A: shr
    IL_020B: shr
    IL_020C: IL_3F
    IL_020D: IL_22
    IL_020E: stloc.0
    IL_020F: IL_D7
    IL_0211: bne.un.s IL_0252
    IL_0212: IL_22
    IL_0213: shr
    IL_0214: shr
    IL_0215: ldloc.0
    IL_1DBE6: switch (30323 cases)
    }

    public void SkillPlus() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BA6
    IL_0006: ldarg.1
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B89
    IL_000D: conv.r8
    IL_0012: beq IL_26060016
    IL_0013: ret
    }

    public void ResetTime() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B7B
    IL_0006: ldarg.0
    IL_000B: ldflda 0x04000B94
    IL_0010: call 0x0A000010
    IL_0011: conv.r8
    IL_0012: IL_FD
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: stfld 0x04000B88
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0027: stfld 0x04000B81
    IL_0028: ldarg.0
    IL_002D: ldstr 0x700235C7
    IL_002E: IL_22
    IL_002F: IL_CD
    IL_0030: IL_CC
    IL_0031: IL_CC
    IL_0032: IL_3D
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_003A: stsfld 0x0017283F
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: ldarg.0
    IL_003E: ldc.i4.1
    IL_0043: stfld 0x04000BAE
    IL_0044: ret
    }

    private void CountDown() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B88
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000D: cpobj 0x0A695B42
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000B88
    IL_0014: not
    IL_0016: ldc.i4.s 60
    IL_0017: mul
    IL_0018: stloc.1
    IL_001D: ldstr 0x7002369F
    IL_001E: stloc.2
    IL_001F: ldloc.1
    IL_0021: ldc.i4.s 10
    IL_0022: IL_3C
    IL_0023: ldloc.0
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_002B: ldstr 0x700236A7
    IL_002C: stloc.2
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000B79
    IL_0033: ldloc.0
    IL_0038: newobj 0x0100000B
    IL_0039: ldloc.2
    IL_003A: ldloc.1
    IL_003F: newobj 0x0100000B
    IL_0044: call 0x0A000098
    IL_0045: conv.r8
    IL_0046: IL_FD
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ret
    }

    public void SoulStartplus() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.5
    IL_0006: stfld 0x04000B63
    IL_0007: ret
    }

    public void CallGeneral() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B8C
    IL_0006: ldc.i4.0
    IL_0007: IL_3C
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldc.i4.0
    IL_000D: ret
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000BA2
    IL_0018: ldfld 0x04000352
    IL_001D: brfalse IL_0029
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000B8A
    IL_0028: brfalse IL_002B
    IL_0029: ldc.i4.0
    IL_002A: ret
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000B58
    IL_0031: IL_22
    IL_0032: nop
    IL_0033: nop
    IL_0038: ldc.i4 11748417
    IL_0039: nop
    IL_003A: nop
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000B89
    IL_0045: brtrue IL_0076
    IL_0046: ldarg.0
    IL_0047: ldc.i4.1
    IL_004C: stfld 0x04000B89
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000BA6
    IL_0053: ldc.i4.1
    IL_0054: conv.r8
    IL_0055: IL_42
    IL_0056: ldarg.1
    IL_0057: nop
    IL_0058: ldloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000BA6
    IL_005F: ldc.i4.1
    IL_0060: conv.r8
    IL_0061: IL_43
    IL_0062: ldarg.1
    IL_0063: nop
    IL_0064: ldloc.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000BA6
    IL_006B: ldc.i4.1
    IL_006C: conv.r8
    IL_006F: ldarg 3
    IL_0070: ldloc.0
    IL_0075: br IL_00A1
    IL_0076: ldarg.0
    IL_0077: ldc.i4.0
    IL_007C: stfld 0x04000B89
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000BA6
    IL_0083: ldc.i4.0
    IL_0084: conv.r8
    IL_0085: IL_42
    IL_0086: ldarg.1
    IL_0087: nop
    IL_0088: ldloc.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000BA6
    IL_008F: ldc.i4.0
    IL_0090: conv.r8
    IL_0091: IL_43
    IL_0092: ldarg.1
    IL_0093: nop
    IL_0094: ldloc.0
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000BA6
    IL_009B: ldc.i4.0
    IL_009C: conv.r8
    IL_009F: ldarg 3
    IL_00A0: ldloc.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000B77
    IL_00AB: call 0x0A00004B
    IL_00B0: call 0x0A000043
    IL_00B1: conv.r8
    IL_00B2: IL_AF
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00B7: ldc.i4.1
    IL_00BC: stfld 0x04000B8B
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x04000BA4
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000B89
    IL_00C9: ldarg.0
    IL_00CE: ldfld 0x04000B57
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x04000B56
    IL_00D5: conv.r8
    IL_00D6: IL_F7
    IL_00D7: ldarg.2
    IL_00D8: nop
    IL_00D9: ldloc.0
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000BA2
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000B89
    IL_00E6: ldarg.1
    IL_00E7: conv.r8
    IL_00EC: ldobj 0x17060001
    IL_00ED: ret
    IL_00EE: ldc.i4.0
    IL_00EF: ret
    }

    public void GeneralDead() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000B89
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x04000B8A
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000BA6
    IL_0014: ldc.i4.0
    IL_0015: conv.r8
    IL_0016: IL_42
    IL_0017: ldarg.1
    IL_0018: nop
    IL_0019: ldloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000BA6
    IL_0020: ldc.i4.0
    IL_0021: conv.r8
    IL_0022: IL_43
    IL_0023: ldarg.1
    IL_0024: nop
    IL_0025: ldloc.0
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000BA6
    IL_002C: ldc.i4.0
    IL_002D: conv.r8
    IL_0030: ldarg 3
    IL_0031: ldloc.0
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000BA6
    IL_0038: conv.r8
    IL_0039: IL_44
    IL_003A: ldarg.1
    IL_003B: nop
    IL_003C: ldloc.0
    IL_003D: ret
    }

    public void WaveSet() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000BA4
    IL_000B: ldfld 0x0400094F
    IL_0010: stfld 0x04000B95
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BA4
    IL_001C: ldfld 0x04000950
    IL_0021: stfld 0x04000B96
    IL_0022: ldarg.0
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000BA2
    IL_002D: ldfld 0x04000354
    IL_0032: stfld 0x04000B98
    IL_0037: ldstr 0x70002031
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000B95
    IL_0042: call 0x0600021F
    IL_0047: ldstr 0x70002045
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000B96
    IL_0052: call 0x0600021F
    IL_0057: ldstr 0x70000EC9
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000B98
    IL_0062: call 0x0600021F
    IL_0067: ldstr 0x70023257
    IL_0068: ldarg.0
    IL_006D: ldfld 0x04000B69
    IL_0072: call 0x0600021F
    IL_0077: ldstr 0x7002325F
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000B68
    IL_0082: call 0x0600021F
    IL_0087: ldstr 0x70000DDD
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04000B5B
    IL_0092: call 0x0600021F
    IL_0097: ldstr 0x7000052B
    IL_0098: ldc.i4.1
    IL_009D: call 0x0A00009F
    IL_00A2: ldstr 0x70000DE5
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04000B5A
    IL_00A9: not
    IL_00AE: call 0x0600021F
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000BA6
    IL_00B5: conv.r8
    IL_00B6: IL_41
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: ldloc.0
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000BA4
    IL_00C0: ldc.i4.0
    IL_00C1: conv.r8
    IL_00C2: ldarg.2
    IL_00C3: ldarg.3
    IL_00C4: nop
    IL_00C5: ldloc.0
    IL_00C6: ldarg.1
    IL_00C7: ldc.i4.m1
    IL_0310: switch (145 cases)
    IL_0311: ldarg.3
    IL_0316: call 0x060003F8
    IL_0317: pop
    IL_0318: ldarg.0
    IL_0319: ldc.i4.0
    IL_031E: stfld 0x04000BA1
    IL_031F: ldarg.0
    IL_0320: ldc.i4.0
    IL_0325: stfld 0x04000B9D
    IL_0326: ldarg.0
    IL_0327: ldarg.1
    IL_0328: ldc.i4.1
    IL_0329: IL_58
    IL_032E: stfld 0x04000B94
    IL_0333: ldstr 0x70023247
    IL_0338: call 0x06000220
    IL_033A: stloc.s 6
    IL_033B: ldarg.0
    IL_0340: ldfld 0x04000B94
    IL_0342: ldloc.s 6
    IL_0343: IL_3E
    IL_0344: IL_4E
    IL_0345: nop
    IL_0346: nop
    IL_0347: nop
    IL_0348: ldarg.0
    IL_034D: ldfld 0x04000B94
    IL_034E: ldc.i4.1
    IL_034F: IL_59
    IL_0350: ldc.i4.8
    IL_0351: mul
    IL_0356: brtrue IL_037F
    IL_0357: ldarg.0
    IL_035C: ldfld 0x04000B94
    IL_035D: ldc.i4.1
    IL_0362: beq IL_037A
    IL_0363: ldarg.0
    IL_0364: ldc.i4.1
    IL_0369: stfld 0x04000B8E
    IL_036A: ldarg.0
    IL_036B: ldarg.0
    IL_0370: ldfld 0x04000B94
    IL_0371: ldc.i4.1
    IL_0372: IL_59
    IL_0373: ldc.i4.8
    IL_0374: add
    IL_0379: stfld 0x04000B8F
    IL_037E: br IL_0386
    IL_037F: ldarg.0
    IL_0380: ldc.i4.0
    IL_0385: stfld 0x04000B8E
    IL_038A: ldstr 0x70023247
    IL_038B: ldarg.0
    IL_0390: ldfld 0x04000B94
    IL_0395: call 0x0600021F
    IL_0396: ldarg.0
    IL_0397: ldc.i4.0
    IL_039C: call 0x06000619
    IL_039D: ldarg.0
    IL_03A2: ldstr 0x700235C7
    IL_03A7: call 0x0A00007B
    IL_03A8: ldarg.0
    IL_03A9: ldc.i4.0
    IL_03AE: stfld 0x04000BAE
    IL_03AF: ldarg.0
    IL_03B0: ldarg.0
    IL_03B5: call 0x0600061C
    IL_03BA: call 0x0A000047
    IL_03BB: pop
    IL_03BC: ret
    }

    public void GetAngel() {
    IL_0004: ldstr 0x700236C9
    IL_0005: ldarg.0
    IL_000A: ldflda 0x04000B8F
    IL_000F: call 0x0A000010
    IL_0014: call 0x0A000011
    IL_0019: call 0x0A000012
    IL_001A: conv.u8
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_01
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000B6F
    IL_0026: conv.r8
    IL_0027: stloc.3
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: conv.r8
    IL_002D: ldarg.s 0
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldloc.0
    IL_0031: conv.r8
    IL_0033: ldarga.s 0
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000B6F
    IL_003C: conv.r8
    IL_003D: stloc.0
    IL_003E: nop
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: ldc.i4.1
    IL_0042: conv.r8
    IL_0043: stloc.1
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000B6F
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldelem.r8
    IL_3000000E2: switch (3221225506 cases)
    }

    private void GetAngel_GUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B72
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
    IL_0016: ldfld 0x04000BA5
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000B8F
    IL_001D: conv.r8
    IL_001F: blt.s IL_0026
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ret
    }

    public void ComboPlus() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B93
    IL_000A: brtrue IL_00E4
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000B87
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_3F
    IL_0016: IL_41
    IL_0017: IL_C9
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x04000B87
    IL_0022: ldarg.1
    IL_0023: IL_58
    IL_0028: stfld 0x04000B87
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000BAD
    IL_0033: call 0x0A000082
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000B87
    IL_003A: shl
    IL_003F: call 0x0A000083
    IL_0040: conv.r8
    IL_0041: IL_F3
    IL_0042: ldarg.0
    IL_0043: nop
    IL_0044: ldloc.0
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000B87
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_3F
    IL_0050: IL_44
    IL_0051: IL_8F
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldarg.0
    IL_0056: ldc.i4.1
    IL_005B: stfld 0x04000B93
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000B73
    IL_0062: conv.r8
    IL_0063: stloc.0
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldc.i4.1
    IL_0068: conv.r8
    IL_0069: stloc.1
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000B73
    IL_0073: ldc.i4.0
    IL_0074: conv.r8
    IL_0079: brtrue IL_6F0A007A
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
    IL_0089: ldfld 0x04000B7F
    IL_008E: call 0x0A000007
    IL_008F: IL_22
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldelem.r8
    IL_2137: switch (2088 cases)
    }

    public void SuperModeOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B70
    IL_0006: ldc.i4.0
    IL_0007: ldelem.i
    IL_0008: conv.r8
    IL_0009: stloc.0
    IL_000A: nop
    IL_000B: nop
    IL_000C: stloc.0
    IL_000D: ldc.i4.1
    IL_000E: conv.r8
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000B70
    IL_0019: ldc.i4.1
    IL_001A: ldelem.i
    IL_001B: conv.r8
    IL_001C: stloc.0
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ldc.i4.1
    IL_0021: conv.r8
    IL_0022: stloc.1
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_0027: ldc.i4.0
    IL_002C: stfld 0x04000B93
    IL_002D: ldarg.0
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0037: stfld 0x04000B87
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000BAD
    IL_0042: call 0x0A000082
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000B87
    IL_0049: shl
    IL_004E: call 0x0A000083
    IL_004F: conv.r8
    IL_0050: IL_F3
    IL_0051: ldarg.0
    IL_0052: nop
    IL_0053: ldloc.0
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000B73
    IL_005A: conv.r8
    IL_005B: stloc.0
    IL_005C: nop
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: ldc.i4.0
    IL_0060: conv.r8
    IL_0061: stloc.1
    IL_0062: nop
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000B73
    IL_006B: ldc.i4.0
    IL_006C: conv.r8
    IL_0071: brtrue IL_6F0A0072
    IL_0072: stloc.0
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: ldc.i4.1
    IL_0077: conv.r8
    IL_0078: stloc.1
    IL_0079: nop
    IL_007A: nop
    IL_007B: stloc.0
    IL_007C: ret
    }

    public void GetCoin() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B9C
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B94
    IL_000D: ldc.i4.4
    IL_000E: IL_5A
    IL_0010: ldc.i4.s 80
    IL_0011: IL_58
    IL_0012: conv.i2
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000B6A
    IL_0019: conv.i2
    IL_001A: IL_22
    IL_001B: IL_CD
    IL_001C: IL_CC
    IL_001D: IL_CC
    IL_001E: IL_3D
    IL_001F: IL_5A
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0x695A583F
    IL_0028: IL_58
    IL_002D: stfld 0x04000B9C
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000B9C
    IL_0034: ldc.i4.0
    IL_0039: call 0x0600021E
    IL_003A: pop
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000B7C
    IL_0041: conv.r8
    IL_0042: IL_81
    IL_0043: nop
    IL_0044: nop
    IL_0046: br.s IL_0049
    IL_004B: ldfld 0x04000B9C
    IL_004C: conv.r8
    IL_004D: div.un
    IL_004E: IL_01
    IL_004F: nop
    IL_0050: ldloc.0
    IL_0051: ret
    }

    public void GetGeneral() {
    IL_0004: ldstr 0x700236FF
    IL_0009: call 0x060003F9
    IL_000A: stloc.0
    IL_000B: ldc.i4.m1
    IL_000C: stloc.1
    IL_000D: ldc.i4.0
    IL_0012: ldc.i4 720
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000B94
    IL_001A: ldc.i4.s 12
    IL_001B: IL_5A
    IL_001C: IL_58
    IL_0021: call 0x0A000045
    IL_0022: stloc.2
    IL_0023: ldloc.2
    IL_0028: ldc.i4 990
    IL_0029: IL_3E
    IL_002A: ldloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: ldc.i4.4
    IL_002F: stloc.2
    IL_0034: br IL_006D
    IL_0035: ldloc.2
    IL_003A: ldc.i4 970
    IL_003B: IL_3E
    IL_003C: ldloc.1
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: ldc.i4.3
    IL_0041: stloc.2
    IL_0046: br IL_006D
    IL_0047: ldloc.2
    IL_004C: ldc.i4 800
    IL_004D: IL_3E
    IL_004E: ldloc.1
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: ldc.i4.2
    IL_0053: stloc.2
    IL_0058: br IL_006D
    IL_0059: ldloc.2
    IL_005E: ldc.i4 500
    IL_005F: IL_3E
    IL_0060: ldloc.1
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldc.i4.1
    IL_0065: stloc.2
    IL_006A: br IL_006D
    IL_006B: ldc.i4.0
    IL_006C: stloc.2
    IL_006D: ldc.i4.0
    IL_006E: stloc.3
    IL_006F: ldloc.2
    IL_0074: ldc.i4 850
    IL_0075: IL_3E
    IL_0076: ldloc.1
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldc.i4.3
    IL_007B: stloc.3
    IL_0080: br IL_0095
    IL_0081: ldloc.2
    IL_0086: ldc.i4 600
    IL_0087: IL_3E
    IL_0088: ldloc.1
    IL_0089: nop
    IL_008A: nop
    IL_008B: nop
    IL_008C: ldc.i4.2
    IL_008D: stloc.3
    IL_0092: br IL_0095
    IL_0093: ldc.i4.1
    IL_0094: stloc.3
    IL_0095: ldc.i4.0
    IL_0097: ldc.i4.s 90
    IL_009C: call 0x0A000045
    IL_009E: stloc.s 4
    IL_009F: ldloc.2
    IL_00A0: ldc.i4.2
    IL_00A1: IL_3F
    IL_00A2: stloc.2
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_00A7: ldloc.s 4
    IL_00A9: ldc.i4.s 20
    IL_00AA: mul
    IL_00AC: stloc.s 4
    IL_00B1: br IL_00B9
    IL_00B3: ldloc.s 4
    IL_00B5: ldc.i4.s 30
    IL_00B6: mul
    IL_00B8: stloc.s 4
    IL_00BA: ldloc.s 4
    IL_00BF: ldc.i4 100000
    IL_00C0: IL_5A
    IL_00C2: stloc.s 4
    IL_00C3: ldc.i4.0
    IL_00C8: ldc.i4 10000
    IL_00CD: call 0x0A000045
    IL_00CE: ldloc.2
    IL_00D3: ldc.i4 10000
    IL_00D4: IL_5A
    IL_00D5: IL_58
    IL_00D6: ldloc.3
    IL_00DB: ldc.i4 10000000
    IL_00DC: IL_5A
    IL_00DD: IL_58
    IL_00DF: ldloc.s 4
    IL_00E0: IL_58
    IL_00E2: stloc.s 5
    IL_00E3: ldc.i4.0
    IL_00E5: stloc.s 6
    IL_00EA: br IL_0114
    IL_00EB: ldloc.0
    IL_00ED: ldloc.s 6
    IL_00EE: IL_94
    IL_00F3: brtrue IL_010E
    IL_00F5: ldloc.s 6
    IL_00F6: stloc.1
    IL_00F7: ldloc.0
    IL_00F9: ldloc.s 6
    IL_00FB: ldloc.s 5
    IL_00FC: ldelem.i8
    IL_0101: ldstr 0x700236FF
    IL_0102: ldloc.0
    IL_0107: call 0x060003F8
    IL_0108: pop
    IL_010D: br IL_011D
    IL_010F: ldloc.s 6
    IL_0110: ldc.i4.1
    IL_0111: IL_58
    IL_0113: stloc.s 6
    IL_0115: ldloc.s 6
    IL_0117: ldc.i4.s 50
    IL_0118: IL_3F
    IL_0119: IL_CE
    IL_011A: IL_FF
    IL_011B: IL_FF
    IL_011C: IL_FF
    IL_011D: ldarg.0
    IL_0122: ldfld 0x04000B6F
    IL_0123: conv.r8
    IL_0124: stloc.3
    IL_0125: nop
    IL_0126: nop
    IL_0127: stloc.0
    IL_0128: conv.r8
    IL_012A: ldarg.s 0
    IL_012B: nop
    IL_012C: stloc.0
    IL_012D: ldarg.0
    IL_0132: ldfld 0x04000B71
    IL_0133: ldloc.3
    IL_0134: ldc.i4.1
    IL_0135: IL_59
    IL_0136: ldelem.i
    IL_0137: conv.r8
    IL_0139: ldarga.s 0
    IL_013A: nop
    IL_013B: stloc.0
    IL_013C: ldarg.0
    IL_0141: ldfld 0x04000B6F
    IL_0142: conv.r8
    IL_0143: stloc.0
    IL_0144: nop
    IL_0145: nop
    IL_0146: stloc.0
    IL_0147: ldc.i4.1
    IL_0148: conv.r8
    IL_0149: stloc.1
    IL_014A: nop
    IL_014B: nop
    IL_014C: stloc.0
    IL_014D: ldarg.0
    IL_0152: ldfld 0x04000B6F
    IL_0153: IL_22
    IL_0154: nop
    IL_0155: nop
    IL_0156: nop
    IL_0157: nop
    IL_0158: IL_22
    IL_0159: nop
    IL_015A: nop
    IL_015B: ldelem.r8
    IL_3000001E8: switch (3221225506 cases)
    }

    public void IntermissionOff() {
    IL_0004: call 0x0A000303
    IL_0005: ldarg.0
    IL_000A: ldfld 0x04000BA4
    IL_000B: conv.r8
    IL_000C: IL_F5
    IL_000D: ldarg.2
    IL_000E: nop
    IL_000F: ldloc.0
    IL_0010: ret
    }

    public void ResetExtreme() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B7D
    IL_0006: conv.r8
    IL_0007: ldarg.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A000007
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0x00082842
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: conv.r8
    IL_001B: ldloc.3
    IL_001C: nop
    IL_001D: nop
    IL_001E: stloc.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000B7D
    IL_0025: conv.r8
    IL_0026: stloc.0
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldc.i4.0
    IL_002B: conv.r8
    IL_002C: stloc.1
    IL_002D: nop
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000BAC
    IL_003A: call 0x0A000057
    IL_003B: conv.r8
    IL_003C: IL_F3
    IL_003D: ldarg.0
    IL_003E: nop
    IL_003F: ldloc.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000BA6
    IL_0046: conv.r8
    IL_0047: IL_35
    IL_0048: ldarg.1
    IL_0049: nop
    IL_004A: ldloc.0
    IL_004B: ret
    }

    public void ShowTxt() {
    IL_0004: call 0x0A0000AA
    IL_0005: IL_22
    IL_0006: nop
    IL_0007: nop
    IL_0008: nop
    IL_0009: IL_3F
    IL_000E: call 0x0A000083
    IL_0013: call 0x0A0000AA
    IL_0014: ldarg.1
    IL_0015: conv.i2
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_001D: stsfld 0x83285A3E
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: call 0x0A0000AB
    IL_0026: stloc.0
    IL_0027: ldarg.1
    IL_002C: brtrue IL_00EA
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000B75
    IL_0033: conv.r8
    IL_0034: stloc.0
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ldc.i4.1
    IL_0039: conv.r8
    IL_003A: stloc.1
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000B75
    IL_0044: conv.r8
    IL_0045: IL_82
    IL_0046: nop
    IL_0047: nop
    IL_0049: br.s IL_004C
    IL_004E: ldfld 0x04000B6A
    IL_004F: conv.r8
    IL_0050: IL_D9
    IL_0051: ldarg.3
    IL_0052: nop
    IL_0053: ldloc.0
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000B94
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000B6A
    IL_0060: IL_5A
    IL_0062: ldc.i4.s 15
    IL_0063: IL_5A
    IL_0064: stloc.1
    IL_0065: ldarg.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000B67
    IL_006C: conv.i2
    IL_0071: stfld 0x04000BAF
    IL_0072: ldarg.0
    IL_0073: dup
    IL_0078: ldfld 0x04000B67
    IL_0079: ldloc.1
    IL_007A: IL_58
    IL_007F: stfld 0x04000B67
    IL_0080: ldarg.0
    IL_0085: ldstr 0x70023707
    IL_0086: IL_22
    IL_0087: nop
    IL_0088: nop
    IL_0089: nop
    IL_008A: IL_3F
    IL_008B: IL_22
    IL_008C: IL_CD
    IL_008D: IL_CC
    IL_008E: IL_4C
    IL_008F: IL_3D
    IL_0094: call 0x0A000017
    IL_0099: ldstr 0x70002687
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000B7B
    IL_00A0: conv.r8
    IL_00A1: ldarg.3
    IL_00A2: ldarg.1
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A9: call 0x06000221
    IL_00AE: ldstr 0x700026AB
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000B7A
    IL_00B5: conv.r8
    IL_00B6: ldarg.3
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: stloc.0
    IL_00BE: call 0x06000221
    IL_00C3: ldstr 0x7000269B
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x04000B79
    IL_00CA: conv.r8
    IL_00CB: ldarg.3
    IL_00CC: ldarg.1
    IL_00CD: nop
    IL_00CE: stloc.0
    IL_00D3: call 0x06000221
    IL_00D8: ldstr 0x7002371B
    IL_00D9: ldc.i4.1
    IL_00DE: call 0x0A00009F
    IL_00E3: ldstr 0x7000052B
    IL_00E4: ldc.i4.1
    IL_00E9: call 0x0A00009F
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000B74
    IL_00F0: conv.r8
    IL_00F1: stloc.0
    IL_00F2: nop
    IL_00F3: nop
    IL_00F4: stloc.0
    IL_00F5: ldc.i4.1
    IL_00F6: conv.r8
    IL_00F7: stloc.1
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FB: ldarg.0
    IL_0100: ldfld 0x04000B74
    IL_0101: conv.r8
    IL_0102: IL_83
    IL_0103: nop
    IL_0104: nop
    IL_0106: br.s IL_010D
    IL_0107: conv.r8
    IL_0108: IL_D4
    IL_0109: ldarg.3
    IL_010A: nop
    IL_010B: ldloc.0
    IL_010C: ret
    }

    private void ScorePlus() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B67
    IL_0006: conv.i2
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BAF
    IL_000D: IL_59
    IL_000E: stloc.0
    IL_000F: ldloc.0
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: stsfld 0x0057433F
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04000BAF
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000B67
    IL_0027: conv.i2
    IL_002C: call 0x0A000024
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_0030: ldelem.r8
    IL_94A19D: switch (2435162 cases)
    }

    public void Stagefinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B62
    IL_0007: ret
    }

    public void WaveClear() {
    IL_0004: newobj 0x060007C9
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x040010A9
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void IntermissionOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B7E
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000B7E
    IL_0011: conv.r8
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: IL_22
    IL_0017: IL_CD
    IL_0018: IL_CC
    IL_0019: IL_4C
    IL_001A: IL_3D
    IL_001F: call 0x0A000008
    IL_0024: call 0x0A000029
    IL_0025: stloc.0
    IL_0026: ldloc.0
    IL_002B: call 0x0A000064
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_0033: stsfld 0x0011433F
    IL_0034: nop
    IL_0035: nop
    IL_0036: ldloc.0
    IL_003B: call 0x0A000040
    IL_003C: IL_22
    IL_003E: bne.un.s IL_0072
    IL_0043: newobj 0x0008283F
    IL_0044: nop
    IL_0045: stloc.0
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000B7D
    IL_004D: conv.r8
    IL_004E: stloc.0
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: conv.r8
    IL_0053: ldarg.3
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: ldloc.0
    IL_0058: conv.r8
    IL_0059: ldloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000B7D
    IL_0063: conv.r8
    IL_0064: stloc.0
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ldc.i4.1
    IL_0069: conv.r8
    IL_006A: stloc.1
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_006E: ret
    }

    public void LoadingFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B92
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BA2
    IL_000D: conv.r8
    IL_000E: xor
    IL_000F: IL_01
    IL_0010: nop
    IL_0011: ldloc.0
    IL_0012: ldarg.0
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_001A: stsfld 0x5A7B023F
    IL_001B: stloc.1
    IL_001C: nop
    IL_001D: ldarg.2
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000B5B
    IL_0025: ldc.i4.s 100
    IL_0026: IL_5A
    IL_0027: conv.i2
    IL_0028: add
    IL_0029: IL_59
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_3E
    IL_002F: IL_5A
    IL_0034: stfld 0x04000B86
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000BAA
    IL_003F: call 0x0A0000AA
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000B86
    IL_004A: call 0x0A000083
    IL_004B: conv.r8
    IL_004C: IL_F3
    IL_004D: ldarg.0
    IL_004E: nop
    IL_004F: ldloc.0
    IL_0050: ldarg.0
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0058: stsfld 0x647B023F
    IL_0059: stloc.1
    IL_005A: nop
    IL_005B: ldarg.2
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_41
    IL_0061: add
    IL_0062: IL_59
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: nop
    IL_0067: IL_3F
    IL_0068: IL_5A
    IL_006D: stfld 0x04000B85
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000B6E
    IL_0074: conv.r8
    IL_0075: IL_24
    IL_0076: nop
    IL_0077: nop
    IL_0079: br.s IL_007C
    IL_007E: ldflda 0x04000B5B
    IL_0083: call 0x0A000010
    IL_0084: conv.r8
    IL_0085: IL_FD
    IL_0086: nop
    IL_0087: nop
    IL_0088: stloc.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000B61
    IL_0093: brtrue IL_015E
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000B76
    IL_009E: call 0x0A00004B
    IL_009F: conv.r8
    IL_00A0: IL_AF
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x04000BA9
    IL_00AE: call 0x0A000082
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000B85
    IL_00B9: call 0x0A000083
    IL_00BA: conv.r8
    IL_00BB: IL_F3
    IL_00BC: ldarg.0
    IL_00BD: nop
    IL_00BE: ldloc.0
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x04000BA4
    IL_00C5: conv.r8
    IL_00C6: IL_FA
    IL_00C7: ldarg.2
    IL_00C8: nop
    IL_00C9: ldloc.0
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04000B9B
    IL_00D0: stloc.0
    IL_00D1: ldloc.0
    IL_00D2: ldc.i4.4
    IL_00D3: IL_58
    IL_00D6: ldarg 3
    IL_00D7: nop
    IL_00D8: nop
    IL_00DD: call 0x4B000000
    IL_00DE: nop
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: ldarg.3
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: nop
    IL_00E9: br IL_0153
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000B72
    IL_00F0: conv.r8
    IL_00F1: stloc.0
    IL_00F2: nop
    IL_00F3: nop
    IL_00F4: stloc.0
    IL_00F5: ldc.i4.1
    IL_00F6: conv.r8
    IL_00F7: stloc.1
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FB: ldarg.0
    IL_0100: ldfld 0x04000BA5
    IL_0101: ldc.i4.1
    IL_0102: ldc.i4.0
    IL_0103: conv.r8
    IL_0104: IL_36
    IL_0105: ldloc.0
    IL_0106: nop
    IL_0107: ldloc.0
    IL_010C: br IL_0153
    IL_010D: ldarg.0
    IL_0112: ldfld 0x04000B72
    IL_0113: conv.r8
    IL_0114: stloc.0
    IL_0115: nop
    IL_0116: nop
    IL_0117: stloc.0
    IL_0118: ldc.i4.1
    IL_0119: conv.r8
    IL_011A: stloc.1
    IL_011B: nop
    IL_011C: nop
    IL_011D: stloc.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x04000BA5
    IL_0124: ldc.i4.5
    IL_0125: ldc.i4.0
    IL_0126: conv.r8
    IL_0127: IL_36
    IL_0128: ldloc.0
    IL_0129: nop
    IL_012A: ldloc.0
    IL_012F: br IL_0153
    IL_0130: ldarg.0
    IL_0135: ldfld 0x04000B72
    IL_0136: conv.r8
    IL_0137: stloc.0
    IL_0138: nop
    IL_0139: nop
    IL_013A: stloc.0
    IL_013B: ldc.i4.1
    IL_013C: conv.r8
    IL_013D: stloc.1
    IL_013E: nop
    IL_013F: nop
    IL_0140: stloc.0
    IL_0141: ldarg.0
    IL_0146: ldfld 0x04000BA5
    IL_0147: ldc.i4.6
    IL_0148: ldc.i4.0
    IL_0149: conv.r8
    IL_014A: IL_36
    IL_014B: ldloc.0
    IL_014C: nop
    IL_014D: ldloc.0
    IL_0152: br IL_0153
    IL_0157: ldstr 0x70002093
    IL_0158: ldc.i4.m1
    IL_015D: call 0x0600021F
    IL_015E: ret
    }

    public void ResetPower() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000B60
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x04000B91
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BAB
    IL_001C: call 0x0A000057
    IL_001D: conv.r8
    IL_001E: IL_F3
    IL_001F: ldarg.0
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000B78
    IL_0028: conv.r8
    IL_0029: stloc.0
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.0
    IL_002E: conv.r8
    IL_002F: stloc.1
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ret
    }

    public void PowerCharge() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B60
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B78
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
    IL_0018: ret
    }

    public void GrabCharge() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B78
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
    IL_0012: dup
    IL_0017: ldfld 0x04000B91
    IL_0018: IL_22
    IL_0019: stloc.0
    IL_001A: IL_D7
    IL_001B: stelem.i
    IL_001C: IL_3C
    IL_001D: IL_58
    IL_0022: stfld 0x04000B91
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000BAB
    IL_002D: call 0x0A000082
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000B91
    IL_0034: shl
    IL_0039: call 0x0A000083
    IL_003A: conv.r8
    IL_003B: IL_F3
    IL_003C: ldarg.0
    IL_003D: nop
    IL_003E: ldloc.0
    IL_003F: ret
    }

    public void GainCoin() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B66
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000B66
    IL_000E: ldarg.0
    IL_000F: dup
    IL_0014: ldfld 0x04000B68
    IL_0015: ldarg.1
    IL_0016: IL_58
    IL_001B: stfld 0x04000B68
    IL_001C: ldarg.1
    IL_001D: ldc.i4.0
    IL_0022: call 0x0600021E
    IL_0023: pop
    IL_0024: ret
    }

    public void GainJade() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B65
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000B65
    IL_000E: ldarg.0
    IL_000F: dup
    IL_0014: ldfld 0x04000B69
    IL_0015: ldarg.1
    IL_0016: IL_58
    IL_001B: stfld 0x04000B69
    IL_001C: ldarg.1
    IL_001D: ldc.i4.1
    IL_0022: call 0x0600021E
    IL_0023: pop
    IL_0024: ret
    }

    public void GainSoul() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: dup
    IL_0008: ldfld 0x04000B64
    IL_0009: ldarg.1
    IL_000A: IL_58
    IL_000F: stfld 0x04000B64
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000B61
    IL_001A: brtrue IL_0036
    IL_001B: ldarg.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000B64
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_41
    IL_0030: call 0x0A0000D4
    IL_0035: stfld 0x04000B64
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000B64
    IL_003C: not
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000B63
    IL_0047: beq IL_009C
    IL_0048: ldarg.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000B64
    IL_004F: not
    IL_0054: stfld 0x04000B63
    IL_0055: ldarg.0
    IL_0056: IL_22
    IL_0057: nop
    IL_0058: nop
    IL_005D: stsfld 0x637B023F
    IL_005E: stloc.1
    IL_005F: nop
    IL_0060: ldarg.2
    IL_0061: conv.i2
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_41
    IL_0067: add
    IL_0068: IL_59
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_3F
    IL_006E: IL_5A
    IL_0073: stfld 0x04000B85
    IL_0074: ldarg.0
    IL_0079: ldfld 0x04000B61
    IL_007E: brtrue IL_009A
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000BA9
    IL_0089: call 0x0A000082
    IL_008A: ldarg.0
    IL_008F: ldfld 0x04000B85
    IL_0094: call 0x0A000083
    IL_0095: conv.r8
    IL_0096: IL_F3
    IL_0097: ldarg.0
    IL_0098: nop
    IL_0099: ldloc.0
    IL_009A: ldc.i4.1
    IL_009B: stloc.0
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x04000BA6
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000B63
    IL_00A8: conv.r8
    IL_00A9: IL_3D
    IL_00AA: ldarg.1
    IL_00AB: nop
    IL_00AC: ldloc.0
    IL_00AD: ldloc.0
    IL_00AE: ret
    }

    public void GetExp() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0007: ldfld 0x04000BA2
    IL_0008: conv.r8
    IL_0009: IL_99
    IL_000A: IL_01
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000B61
    IL_0017: brtrue IL_002A
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000B6B
    IL_0023: call 0x06000624
    IL_0024: stloc.0
    IL_0029: br IL_0059
    IL_002A: ldarg.0
    IL_002B: dup
    IL_0030: ldfld 0x04000B67
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000B94
    IL_003B: ldc.i4 200
    IL_003C: IL_5A
    IL_003D: IL_58
    IL_0042: stfld 0x04000B67
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000B7A
    IL_0049: ldarg.0
    IL_004E: ldflda 0x04000B67
    IL_0053: call 0x0A000010
    IL_0054: conv.r8
    IL_0055: IL_FD
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000BA2
    IL_0064: ldfld 0x040002EF
    IL_0069: stfld 0x04000B5A
    IL_006A: ldarg.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04000BA2
    IL_0075: ldfld 0x040002EE
    IL_007A: stfld 0x04000B5B
    IL_007B: ldarg.0
    IL_007C: dup
    IL_0081: ldfld 0x04000B9D
    IL_0082: ldc.i4.1
    IL_0083: IL_58
    IL_0084: neg
    IL_0089: stfld 0x04000B9D
    IL_008A: ldarg.0
    IL_008B: dup
    IL_0090: ldfld 0x04000B9F
    IL_0091: ldc.i4.1
    IL_0092: IL_58
    IL_0097: stfld 0x04000B9F
    IL_0098: ldarg.0
    IL_009D: ldfld 0x04000B90
    IL_009E: ldc.i4.5
    IL_009F: IL_3E
    IL_00A0: ldarg.3
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: nop
    IL_00A8: br IL_014B
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000B61
    IL_00B3: brfalse IL_0102
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x04000B9D
    IL_00BB: ldc.i4.s 10
    IL_00BC: IL_3F
    IL_00BD: IL_3C
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: dup
    IL_00C7: ldfld 0x04000BA1
    IL_00C8: ldc.i4.1
    IL_00C9: IL_59
    IL_00CA: neg
    IL_00CF: stfld 0x04000BA1
    IL_00D0: ldarg.0
    IL_00D5: ldfld 0x04000BAC
    IL_00DA: call 0x0A000082
    IL_00DB: IL_22
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: IL_3D
    IL_00E4: call 0x0A000083
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x04000BA1
    IL_00EB: conv.i2
    IL_00F0: call 0x0A000083
    IL_00F1: conv.r8
    IL_00F2: IL_F3
    IL_00F3: ldarg.0
    IL_00F4: nop
    IL_00F5: ldloc.0
    IL_00F6: ldarg.0
    IL_00F7: ldc.i4.0
    IL_00FC: stfld 0x04000B9D
    IL_0101: br IL_014B
    IL_0102: ldarg.0
    IL_0107: ldfld 0x04000B9D
    IL_0109: ldc.i4.s 15
    IL_010A: IL_3F
    IL_010B: IL_3C
    IL_010C: nop
    IL_010D: nop
    IL_010E: nop
    IL_010F: ldarg.0
    IL_0110: dup
    IL_0115: ldfld 0x04000BA1
    IL_0116: ldc.i4.1
    IL_0117: IL_59
    IL_0118: neg
    IL_011D: stfld 0x04000BA1
    IL_011E: ldarg.0
    IL_0123: ldfld 0x04000BAC
    IL_0128: call 0x0A000082
    IL_0129: IL_22
    IL_012A: nop
    IL_012B: nop
    IL_012C: nop
    IL_012D: IL_3D
    IL_0132: call 0x0A000083
    IL_0133: ldarg.0
    IL_0138: ldfld 0x04000BA1
    IL_0139: conv.i2
    IL_013E: call 0x0A000083
    IL_013F: conv.r8
    IL_0140: IL_F3
    IL_0141: ldarg.0
    IL_0142: nop
    IL_0143: ldloc.0
    IL_0144: ldarg.0
    IL_0145: ldc.i4.0
    IL_014A: stfld 0x04000B9D
    IL_014B: ldarg.0
    IL_014C: IL_22
    IL_014D: nop
    IL_014E: nop
    IL_0153: stsfld 0x5A7B023F
    IL_0154: stloc.1
    IL_0155: nop
    IL_0156: ldarg.2
    IL_0157: conv.i2
    IL_0158: ldarg.0
    IL_015D: ldfld 0x04000B5B
    IL_015F: ldc.i4.s 100
    IL_0160: IL_5A
    IL_0161: conv.i2
    IL_0162: add
    IL_0163: IL_59
    IL_0164: IL_22
    IL_0165: nop
    IL_0166: nop
    IL_0167: nop
    IL_0168: IL_3E
    IL_0169: IL_5A
    IL_016E: stfld 0x04000B86
    IL_016F: ldarg.0
    IL_0174: ldfld 0x04000BAA
    IL_0179: call 0x0A0000AA
    IL_017A: ldarg.0
    IL_017F: ldfld 0x04000B86
    IL_0184: call 0x0A000083
    IL_0185: conv.r8
    IL_0186: IL_F3
    IL_0187: ldarg.0
    IL_0188: nop
    IL_0189: ldloc.0
    IL_018A: ldarg.0
    IL_018F: ldfld 0x04000B5B
    IL_0190: ldarg.0
    IL_0195: ldfld 0x04000B80
    IL_019A: beq IL_01F2
    IL_019B: ldarg.0
    IL_01A0: ldfld 0x04000B6D
    IL_01A1: IL_22
    IL_01A2: IL_CD
    IL_01A3: IL_CC
    IL_01A4: IL_AC
    IL_01A5: IL_BF
    IL_01A6: IL_22
    IL_01A7: IL_8F
    IL_01A8: IL_C2
    IL_01A9: IL_35
    IL_200000236: switch (2147483682 cases)
    }

    public void PauseOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B92
    IL_000A: brfalse IL_0016
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000BA5
    IL_0011: conv.r8
    IL_0012: IL_35
    IL_0013: ldloc.0
    IL_0014: nop
    IL_0015: ldloc.0
    IL_0016: ret
    }

    public void Resurrection() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000B66
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000B65
    IL_0020: ret
    }

    public void Damaged_Extreme() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B81
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000B81
    IL_000E: ret
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000B83
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000E: stsfld 0x837D583D
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: ldarg.2
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BA7
    IL_001C: call 0x0A000082
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000B83
    IL_0027: call 0x0A000083
    IL_0028: conv.r8
    IL_0029: IL_F3
    IL_002A: ldarg.0
    IL_002B: nop
    IL_002C: ldloc.0
    IL_002D: ldarg.0
    IL_002E: dup
    IL_0033: ldfld 0x04000B81
    IL_0034: ldc.i4.1
    IL_0035: IL_58
    IL_003A: stfld 0x04000B81
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000B81
    IL_0041: ldc.i4.3
    IL_0042: IL_3F
    IL_0043: ldc.i4.7
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: ldarg.0
    IL_0048: ldc.i4.m1
    IL_004D: call 0x06000610
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000BA2
    IL_0054: conv.r8
    IL_0059: cpobj 0x02060001
    IL_005E: ldfld 0x04000BA2
    IL_005F: conv.r8
    IL_0064: newobj 0x2A060001
    }

    public void GameOver() {
    IL_0004: ldstr 0x70002059
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_000D: IL_58
    IL_000E: stloc.0
    IL_0013: ldstr 0x70002059
    IL_0014: ldloc.0
    IL_0019: call 0x0600021F
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000B72
    IL_0020: conv.r8
    IL_0021: stloc.0
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldc.i4.1
    IL_0026: conv.r8
    IL_0027: stloc.1
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000BA5
    IL_0031: conv.r8
    IL_0032: IL_34
    IL_0033: ldloc.0
    IL_0034: nop
    IL_0035: ldloc.0
    IL_0036: ret
    }

    public void StatUpdate_sp() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000B58
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000F: stsfld 0x587B023F
    IL_0010: stloc.1
    IL_0011: nop
    IL_0012: ldarg.2
    IL_0013: conv.i2
    IL_0014: ldarg.0
    IL_0019: ldfld 0x04000B59
    IL_001A: conv.i2
    IL_001B: add
    IL_001C: IL_59
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: IL_3F
    IL_0022: IL_5A
    IL_0027: stfld 0x04000B84
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000B58
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0033: ldloc 17474
    IL_0038: ldc.i4 33554432
    IL_003D: ldfld 0x04000BA8
    IL_0042: call 0x0A000082
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000B84
    IL_004D: call 0x0A000083
    IL_004E: conv.r8
    IL_004F: IL_F3
    IL_0050: ldarg.0
    IL_0051: nop
    IL_0052: ldloc.0
    IL_0057: br IL_0087
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000BA8
    IL_0062: call 0x0A000082
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000B84
    IL_006D: call 0x0A000083
    IL_0072: call 0x0A0000AA
    IL_0073: IL_22
    IL_0074: nop
    IL_0075: nop
    IL_0076: nop
    IL_0077: IL_3D
    IL_007C: call 0x0A000083
    IL_0081: call 0x0A000174
    IL_0082: conv.r8
    IL_0083: IL_F3
    IL_0084: ldarg.0
    IL_0085: nop
    IL_0086: ldloc.0
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000B8C
    IL_008D: ldc.i4.m1
    IL_0092: beq IL_00AF
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04000B8A
    IL_009D: brtrue IL_00AF
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x04000BA6
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x04000B58
    IL_00AA: conv.r8
    IL_00AB: IL_36
    IL_00AC: ldarg.1
    IL_00AD: nop
    IL_00AE: ldloc.0
    IL_00AF: ret
    }

    public void StatUpdate_hp() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000B8D
    IL_000C: ldc.i4.2
    IL_0011: beq IL_005E
    IL_0012: ldarg.0
    IL_0013: ldarg.1
    IL_0018: stfld 0x04000B57
    IL_0019: ldarg.0
    IL_001A: ldarg.2
    IL_001F: stfld 0x04000B56
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0x577B023F
    IL_0028: stloc.1
    IL_0029: nop
    IL_002A: ldarg.2
    IL_002B: conv.i2
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000B56
    IL_0032: conv.i2
    IL_0033: add
    IL_0034: IL_59
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_0037: ldloc.0
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: IL_3F
    IL_003D: IL_5A
    IL_0042: stfld 0x04000B83
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000BA7
    IL_004D: call 0x0A000082
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000B83
    IL_0058: call 0x0A000083
    IL_0059: conv.r8
    IL_005A: IL_F3
    IL_005B: ldarg.0
    IL_005C: nop
    IL_005D: ldloc.0
    IL_005E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B93
    IL_000A: brfalse IL_0010
    IL_000F: br IL_009D
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000B87
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_43
    IL_001C: or
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000BAE
    IL_002A: brfalse IL_007E
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000B7F
    IL_0031: IL_22
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_22
    IL_0037: IL_29
    IL_0038: sub
    IL_003A: bge.s IL_007B
    IL_003B: IL_22
    IL_003C: shr
    IL_003D: shr
    IL_003E: ldloc.0
    IL_1DA0F: switch (30323 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000BBA
    IL_0007: ldarg.0
    IL_000C: call 0x0A000057
    IL_0011: stfld 0x04000BBE
    IL_0012: ldarg.0
    IL_0014: ldc.i4.s 10
    IL_0019: stfld 0x04000BD3
    IL_001A: ldarg.0
    IL_001B: ldc.i4.1
    IL_0020: stfld 0x04000BD4
    IL_0021: ldarg.0
    IL_0026: call 0x0A000001
    IL_0027: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700004D5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000BD5
    IL_0010: ret
    }

    private void Start() {
    IL_0000: ldc.i4.0
    IL_0005: call 0x0A0002E9
    IL_0006: ldarg.0
    IL_000B: ldstr 0x70000BB3
    IL_0010: call 0x0A000095
    IL_0015: stfld 0x04000BD9
    IL_0016: ldarg.0
    IL_001B: ldstr 0x70000BD5
    IL_0020: call 0x0A000004
    IL_0021: conv.r8
    IL_002A: ldc.i8 288243409182457856
    IL_002B: ldarg.0
    IL_0030: ldstr 0x70000001
    IL_0035: call 0x0A000004
    IL_0036: conv.r8
    IL_0037: ldarg.2
    IL_0038: nop
    IL_0039: nop
    IL_003B: br.s IL_00B9
    IL_003C: IL_CE
    IL_003D: stloc.1
    IL_003E: nop
    IL_003F: ldarg.2
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70000063
    IL_004A: call 0x0A000004
    IL_004B: conv.r8
    IL_004C: ldarg.0
    IL_004D: nop
    IL_004E: nop
    IL_0050: br.s IL_00CE
    IL_0051: IL_CF
    IL_0052: stloc.1
    IL_0053: nop
    IL_0054: ldarg.2
    IL_0055: ldarg.0
    IL_005A: ldstr 0x70022774
    IL_005F: call 0x0A0001C1
    IL_0064: stfld 0x04000BC7
    IL_0065: ldarg.0
    IL_006A: ldstr 0x7002270C
    IL_006F: call 0x0A0001C1
    IL_0074: stfld 0x04000BC8
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000BC8
    IL_007F: call 0x0A0001C2
    IL_0080: ldarg.0
    IL_0081: ldarg.0
    IL_0086: ldfld 0x04000BCF
    IL_008B: ldfld 0x0400095D
    IL_0090: stfld 0x04000BC5
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000BC5
    IL_009B: brfalse IL_00A3
    IL_009C: ldarg.0
    IL_009D: ldc.i4.3
    IL_00A2: stfld 0x04000BD4
    IL_00A3: ldarg.0
    IL_00A8: ldstr 0x70001E7D
    IL_00AD: call 0x06000220
    IL_00B2: stfld 0x04000BDC
    IL_00B7: call 0x0A000035
    IL_00B8: conv.r8
    IL_00B9: ldloc.0
    IL_00BA: nop
    IL_00BB: nop
    IL_00BD: br.s IL_00C0
    IL_00C2: ldfld 0x04000BDC
    IL_00C4: ldc.i4.s -2
    IL_00C5: IL_5A
    IL_00C7: ldc.i4.s 30
    IL_00C8: IL_58
    IL_00C9: conv.i2
    IL_00CA: conv.r8
    IL_00CC: blt.s IL_00CE
    IL_00CD: nop
    IL_00CE: ldloc.0
    IL_00CF: ldarg.0
    IL_00D4: call 0x0A00000A
    IL_00D5: ldc.i4.0
    IL_00D6: conv.r8
    IL_00D7: stloc.1
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: stloc.0
    IL_00DF: call 0x0600004E
    IL_00E0: conv.r8
    IL_00E1: neg
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: ldloc.0
    IL_00E5: ret
    }

    public void CountDown() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BD3
    IL_0007: ldc.i4.1
    IL_0008: IL_59
    IL_000D: stfld 0x04000BD3
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000BD3
    IL_0014: ldc.i4.0
    IL_0015: IL_3D
    IL_0016: ldc.i4.7
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldarg.0
    IL_001B: ldc.i4.0
    IL_0020: stfld 0x04000BD8
    IL_0021: IL_22
    IL_0022: nop
    IL_0023: nop
    IL_0028: stsfld 0x0111283F
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000BDA
    IL_0031: ldc.i4.m1
    IL_0032: conv.r8
    IL_0034: starg.s 6
    IL_0035: nop
    IL_0036: ldloc.0
    IL_0037: ret
    }

    public void GetAngel() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000BC0
    IL_000B: ldstr 0x7000000F
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000BC0
    IL_0016: call 0x0600021F
    IL_0017: ldarg.0
    IL_0018: ldc.i4.1
    IL_001D: stfld 0x04000BCC
    IL_001E: ldarg.0
    IL_0023: ldstr 0x7002374B
    IL_0024: IL_22
    IL_0025: ldelem.i
    IL_0026: IL_99
    IL_0027: ldc.i4.3
    IL_FCCC: switch (16168 cases)
    }

    private void GetAngelFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000BCC
    IL_0007: ldarg.0
    IL_000C: call 0x0A00000A
    IL_000D: ldc.i4.0
    IL_000E: conv.r8
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: stloc.0
    IL_0017: call 0x0A000303
    IL_0018: ret
    }

    public void ChanceOn() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_3F
    IL_0009: call 0x0A000111
    IL_000A: ldarg.0
    IL_000B: ldc.i4.1
    IL_0010: stfld 0x04000BD8
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700235C7
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_3F
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_3F
    IL_0025: call 0x0A000017
    IL_0026: ret
    }

    public void PauseOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BD2
    IL_000A: brfalse IL_0018
    IL_000B: ldarg.0
    IL_0010: call 0x0A00000A
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0013: stloc.1
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ret
    IL_0018: ldarg.0
    IL_001D: call 0x0A00000A
    IL_001E: ldc.i4.1
    IL_001F: conv.r8
    IL_0020: stloc.1
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_002D: call 0x0A000111
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000BCE
    IL_0034: conv.r8
    IL_0039: newobj 0x02060001
    IL_003A: ldc.i4.1
    IL_003F: stfld 0x04000BD6
    IL_0044: call 0x060001EF
    IL_0045: conv.r8
    IL_0046: IL_F5
    IL_0047: IL_01
    IL_0048: nop
    IL_0049: ldloc.0
    IL_004A: stloc.0
    IL_004B: ldloc.0
    IL_0050: ldstr 0x700233A9
    IL_0055: call 0x0A0000EC
    IL_005A: brfalse IL_006C
    IL_005F: call 0x0600004E
    IL_0060: conv.r8
    IL_0061: or
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldloc.0
    IL_0065: ldarg.0
    IL_0066: ldc.i4.0
    IL_006B: stfld 0x04000BCD
    IL_006C: ret
    }

    public void SetTutorial() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0009: call 0x0A000111
    IL_000A: ldarg.0
    IL_000F: ldfld 0x04000BCE
    IL_0010: conv.r8
    IL_0015: newobj 0x02060001
    IL_0016: ldc.i4.1
    IL_001B: stfld 0x04000BB8
    IL_001C: ldarg.0
    IL_001D: ldc.i4.0
    IL_0022: stfld 0x04000BBC
    IL_0023: ldarg.0
    IL_0024: ldarg.2
    IL_0029: stfld 0x04000BBB
    IL_002A: ldarg.0
    IL_002B: ldarg.1
    IL_0030: stfld 0x04000BB9
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000BB9
    IL_0038: ldc.i4.s 10
    IL_0039: IL_5A
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000BBB
    IL_0040: IL_58
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0047: ldstr 0x70023769
    IL_0049: ldloca.s 0
    IL_004E: call 0x0A000010
    IL_0053: call 0x0A000011
    IL_0058: call 0x0A000012
    IL_0059: conv.u8
    IL_005A: IL_3C
    IL_005B: nop
    IL_005C: nop
    IL_005D: IL_01
    IL_0062: stfld 0x04000BB7
    IL_0063: ldloc.0
    IL_0064: stloc.1
    IL_0065: ldloc.1
    IL_0067: ldc.i4.s 10
    IL_0068: IL_59
    IL_006B: ldarg 3
    IL_006C: nop
    IL_006D: nop
    IL_006E: and
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldelem.r4
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_0076: IL_D5
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldloc.1
    IL_007C: ldc.i4.s 50
    IL_007D: IL_59
    IL_0080: ldarg 3
    IL_0081: nop
    IL_0082: nop
    IL_0083: IL_5A
    IL_0084: ldarg.0
    IL_0085: nop
    IL_0086: nop
    IL_0087: IL_AC
    IL_0088: ldarg.0
    IL_0089: nop
    IL_008A: nop
    IL_008B: IL_E2
    IL_008C: ldarg.0
    IL_008D: nop
    IL_008E: nop
    IL_008F: ldloc.1
    IL_0091: ldc.i4.s 20
    IL_0096: beq IL_0185
    IL_0097: ldloc.1
    IL_0099: ldc.i4.s 21
    IL_009E: beq IL_01C2
    IL_009F: ldloc.1
    IL_00A1: ldc.i4.s 30
    IL_00A6: beq IL_01F1
    IL_00A7: ldloc.1
    IL_00A9: ldc.i4.s 31
    IL_00AE: beq IL_022B
    IL_00AF: ldloc.1
    IL_00B1: ldc.i4.s 40
    IL_00B6: beq IL_0261
    IL_00B7: ldloc.1
    IL_00B9: ldc.i4.s 41
    IL_00BE: beq IL_02B3
    IL_00BF: ldloc.1
    IL_00C1: ldc.i4.s 60
    IL_00C6: beq IL_03A7
    IL_00C7: ldloc.1
    IL_00C9: ldc.i4.s 61
    IL_00CE: beq IL_03E4
    IL_00CF: ldloc.1
    IL_00D1: ldc.i4.s 70
    IL_00D6: beq IL_041A
    IL_00DB: br IL_0457
    IL_00DC: ldarg.0
    IL_00E1: ldc.i4 338
    IL_00E6: stfld 0x04000BBC
    IL_00E7: ldarg.0
    IL_00E8: ldc.i4.3
    IL_00ED: stfld 0x04000BBA
    IL_00EE: ldarg.0
    IL_00EF: ldc.i4.0
    IL_00F4: stfld 0x04000BBD
    IL_00F5: ldarg.0
    IL_00F6: IL_22
    IL_00F7: nop
    IL_00F8: nop
    IL_00F9: ret
    IL_00FA: IL_43
    IL_00FB: IL_22
    IL_00FC: nop
    IL_00FD: nop
    IL_00FE: ldloc.0
    IL_00FF: IL_43
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: nop
    IL_0104: IL_43
    IL_0105: IL_22
    IL_0106: nop
    IL_0107: nop
    IL_010C: stsfld 0x021D2842
    IL_010D: nop
    IL_010E: ldloc.0
    IL_0113: stfld 0x04000BBF
    IL_0118: br IL_0457
    IL_0119: ldarg.0
    IL_011E: ldc.i4 339
    IL_0123: stfld 0x04000BBC
    IL_0124: ldarg.0
    IL_0125: ldc.i4.0
    IL_012A: stfld 0x04000BBD
    IL_012B: ldarg.0
    IL_012C: IL_22
    IL_012D: nop
    IL_012E: nop
    IL_012F: ret
    IL_0130: IL_43
    IL_0131: IL_22
    IL_0132: nop
    IL_0133: nop
    IL_0134: ldloc.0
    IL_0135: IL_43
    IL_0136: IL_22
    IL_0137: nop
    IL_0138: nop
    IL_0139: nop
    IL_013A: IL_43
    IL_013B: IL_22
    IL_013C: nop
    IL_013D: nop
    IL_0142: stsfld 0x021D2842
    IL_0143: nop
    IL_0144: ldloc.0
    IL_0149: stfld 0x04000BBF
    IL_014E: br IL_0457
    IL_014F: ldarg.0
    IL_0154: ldc.i4 340
    IL_0159: stfld 0x04000BBC
    IL_015A: ldarg.0
    IL_015B: ldc.i4.0
    IL_0160: stfld 0x04000BBD
    IL_0161: ldarg.0
    IL_0162: IL_22
    IL_0163: nop
    IL_0164: nop
    IL_0165: ret
    IL_0166: IL_43
    IL_0167: IL_22
    IL_0168: nop
    IL_0169: nop
    IL_016A: ldloc.0
    IL_016B: IL_43
    IL_016C: IL_22
    IL_016D: nop
    IL_016E: nop
    IL_016F: nop
    IL_0170: IL_43
    IL_0171: IL_22
    IL_0172: nop
    IL_0173: nop
    IL_0178: stsfld 0x021D2842
    IL_0179: nop
    IL_017A: ldloc.0
    IL_017F: stfld 0x04000BBF
    IL_0184: br IL_0457
    IL_0185: ldarg.0
    IL_018A: ldc.i4 341
    IL_018F: stfld 0x04000BBC
    IL_0190: ldarg.0
    IL_0191: ldc.i4.2
    IL_0196: stfld 0x04000BBA
    IL_0197: ldarg.0
    IL_0198: ldc.i4.0
    IL_019D: stfld 0x04000BBD
    IL_019E: ldarg.0
    IL_019F: IL_22
    IL_01A0: nop
    IL_01A1: nop
    IL_01A2: ret
    IL_01A3: IL_43
    IL_01A4: IL_22
    IL_01A5: nop
    IL_01A6: nop
    IL_01A7: ldloc.0
    IL_01A8: IL_43
    IL_01A9: IL_22
    IL_01AA: nop
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: IL_43
    IL_01AE: IL_22
    IL_01AF: nop
    IL_01B0: nop
    IL_01B5: stsfld 0x021D2842
    IL_01B6: nop
    IL_01B7: ldloc.0
    IL_01BC: stfld 0x04000BBF
    IL_01C1: br IL_0457
    IL_01C2: ldarg.0
    IL_01C7: ldc.i4 342
    IL_01CC: stfld 0x04000BBC
    IL_01CD: ldarg.0
    IL_01CE: IL_22
    IL_01CF: nop
    IL_01D0: nop
    IL_01D1: ldc.i4.0
    IL_01D2: IL_43
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01D6: IL_DC
    IL_01D7: IL_42
    IL_01D8: IL_22
    IL_01D9: nop
    IL_01DA: nop
    IL_01DF: ldc.i4 8770
    IL_01E0: ldelem.r8
    IL_01E1: IL_42
    IL_01E6: call 0x0600021D
    IL_01EB: stfld 0x04000BBF
    IL_01F0: br IL_0457
    IL_01F1: ldarg.0
    IL_01F3: ldc.i4.s 36
    IL_01F8: stfld 0x04000BBC
    IL_01F9: ldarg.0
    IL_01FA: ldc.i4.2
    IL_01FF: stfld 0x04000BBA
    IL_0200: ldarg.0
    IL_0201: ldc.i4.0
    IL_0206: stfld 0x04000BBD
    IL_0207: ldarg.0
    IL_0208: IL_22
    IL_0209: nop
    IL_020A: nop
    IL_020B: ret
    IL_020C: IL_43
    IL_020D: IL_22
    IL_020E: nop
    IL_020F: nop
    IL_0210: ldloc.0
    IL_0211: IL_43
    IL_0212: IL_22
    IL_0213: nop
    IL_0214: nop
    IL_0215: nop
    IL_0216: IL_43
    IL_0217: IL_22
    IL_0218: nop
    IL_0219: nop
    IL_021E: stsfld 0x021D2842
    IL_021F: nop
    IL_0220: ldloc.0
    IL_0225: stfld 0x04000BBF
    IL_022A: br IL_0457
    IL_022B: ldarg.0
    IL_0230: ldc.i4 359
    IL_0235: stfld 0x04000BBC
    IL_0236: ldarg.0
    IL_0237: ldc.i4.0
    IL_023C: stfld 0x04000BBD
    IL_023D: ldarg.0
    IL_023E: IL_22
    IL_023F: nop
    IL_0240: nop
    IL_0241: ret
    IL_0242: IL_43
    IL_0243: IL_22
    IL_0244: nop
    IL_0245: nop
    IL_0246: ldloc.0
    IL_0247: IL_43
    IL_0248: IL_22
    IL_0249: nop
    IL_024A: nop
    IL_024B: nop
    IL_024C: IL_43
    IL_024D: IL_22
    IL_024E: nop
    IL_024F: nop
    IL_0254: stsfld 0x021D2842
    IL_0255: nop
    IL_0256: ldloc.0
    IL_025B: stfld 0x04000BBF
    IL_0260: br IL_0457
    IL_0261: ldarg.0
    IL_0266: ldc.i4 346
    IL_026B: stfld 0x04000BBC
    IL_026C: ldarg.0
    IL_026D: ldc.i4.2
    IL_0272: stfld 0x04000BBA
    IL_0273: ldarg.0
    IL_0274: ldc.i4.1
    IL_0279: stfld 0x04000BBD
    IL_027A: ldarg.0
    IL_027B: IL_22
    IL_027C: nop
    IL_027D: nop
    IL_0282: ldc.i4 8769
    IL_0287: ldc.i4 3699522
    IL_0288: nop
    IL_0289: stloc.0
    IL_028E: stfld 0x04000BBE
    IL_028F: ldarg.0
    IL_0290: IL_22
    IL_0291: nop
    IL_0292: nop
    IL_0293: ret
    IL_0294: IL_43
    IL_0295: IL_22
    IL_0296: nop
    IL_0297: nop
    IL_0298: ldloc.0
    IL_0299: IL_43
    IL_029A: IL_22
    IL_029B: nop
    IL_029C: nop
    IL_029D: nop
    IL_029E: IL_43
    IL_029F: IL_22
    IL_02A0: nop
    IL_02A1: nop
    IL_02A6: stsfld 0x021D2842
    IL_02A7: nop
    IL_02A8: ldloc.0
    IL_02AD: stfld 0x04000BBF
    IL_02B2: br IL_0457
    IL_02B3: ldarg.0
    IL_02B8: ldc.i4 347
    IL_02BD: stfld 0x04000BBC
    IL_02BE: ldarg.0
    IL_02BF: ldc.i4.0
    IL_02C4: stfld 0x04000BBD
    IL_02C5: ldarg.0
    IL_02C6: IL_22
    IL_02C7: nop
    IL_02C8: nop
    IL_02C9: ret
    IL_02CA: IL_43
    IL_02CB: IL_22
    IL_02CC: nop
    IL_02CD: nop
    IL_02CE: ldloc.0
    IL_02CF: IL_43
    IL_02D0: IL_22
    IL_02D1: nop
    IL_02D2: nop
    IL_02D3: nop
    IL_02D4: IL_43
    IL_02D5: IL_22
    IL_02D6: nop
    IL_02D7: nop
    IL_02DC: stsfld 0x021D2842
    IL_02DD: nop
    IL_02DE: ldloc.0
    IL_02E3: stfld 0x04000BBF
    IL_02E8: br IL_0457
    IL_02E9: ldarg.0
    IL_02EE: ldc.i4 343
    IL_02F3: stfld 0x04000BBC
    IL_02F4: ldarg.0
    IL_02F5: ldc.i4.3
    IL_02FA: stfld 0x04000BBA
    IL_02FB: ldarg.0
    IL_02FC: ldc.i4.0
    IL_0301: stfld 0x04000BBD
    IL_0302: ldarg.0
    IL_0303: IL_22
    IL_0304: nop
    IL_0305: nop
    IL_030A: ldc.i4 8769
    IL_030F: ldc.i4 3699522
    IL_0310: nop
    IL_0311: stloc.0
    IL_0316: stfld 0x04000BBE
    IL_0317: ldarg.0
    IL_0318: IL_22
    IL_0319: nop
    IL_031A: nop
    IL_031B: ret
    IL_031C: IL_43
    IL_031D: IL_22
    IL_031E: nop
    IL_031F: nop
    IL_0320: ldloc.0
    IL_0321: IL_43
    IL_0322: IL_22
    IL_0323: nop
    IL_0324: nop
    IL_0325: nop
    IL_0326: IL_43
    IL_0327: IL_22
    IL_0328: nop
    IL_0329: nop
    IL_032E: stsfld 0x021D2842
    IL_032F: nop
    IL_0330: ldloc.0
    IL_0335: stfld 0x04000BBF
    IL_033A: br IL_0457
    IL_033B: ldarg.0
    IL_0340: ldc.i4 344
    IL_0345: stfld 0x04000BBC
    IL_0346: ldarg.0
    IL_0347: ldc.i4.0
    IL_034C: stfld 0x04000BBD
    IL_034D: ldarg.0
    IL_034E: IL_22
    IL_034F: nop
    IL_0350: nop
    IL_0351: ret
    IL_0352: IL_43
    IL_0353: IL_22
    IL_0354: nop
    IL_0355: nop
    IL_0356: ldloc.0
    IL_0357: IL_43
    IL_0358: IL_22
    IL_0359: nop
    IL_035A: nop
    IL_035B: nop
    IL_035C: IL_43
    IL_035D: IL_22
    IL_035E: nop
    IL_035F: nop
    IL_0364: stsfld 0x021D2842
    IL_0365: nop
    IL_0366: ldloc.0
    IL_036B: stfld 0x04000BBF
    IL_0370: br IL_0457
    IL_0371: ldarg.0
    IL_0376: ldc.i4 345
    IL_037B: stfld 0x04000BBC
    IL_037C: ldarg.0
    IL_037D: ldc.i4.0
    IL_0382: stfld 0x04000BBD
    IL_0383: ldarg.0
    IL_0384: IL_22
    IL_0385: nop
    IL_0386: nop
    IL_0387: ret
    IL_0388: IL_43
    IL_0389: IL_22
    IL_038A: nop
    IL_038B: nop
    IL_038C: ldloc.0
    IL_038D: IL_43
    IL_038E: IL_22
    IL_038F: nop
    IL_0390: nop
    IL_0391: nop
    IL_0392: IL_43
    IL_0393: IL_22
    IL_0394: nop
    IL_0395: nop
    IL_039A: stsfld 0x021D2842
    IL_039B: nop
    IL_039C: ldloc.0
    IL_03A1: stfld 0x04000BBF
    IL_03A6: br IL_0457
    IL_03A7: ldarg.0
    IL_03AC: ldc.i4 348
    IL_03B1: stfld 0x04000BBC
    IL_03B2: ldarg.0
    IL_03B3: ldc.i4.2
    IL_03B8: stfld 0x04000BBA
    IL_03B9: ldarg.0
    IL_03BA: ldc.i4.0
    IL_03BF: stfld 0x04000BBD
    IL_03C0: ldarg.0
    IL_03C1: IL_22
    IL_03C2: nop
    IL_03C3: nop
    IL_03C4: ret
    IL_03C5: IL_43
    IL_03C6: IL_22
    IL_03C7: nop
    IL_03C8: nop
    IL_03C9: ldloc.0
    IL_03CA: IL_43
    IL_03CB: IL_22
    IL_03CC: nop
    IL_03CD: nop
    IL_03CE: nop
    IL_03CF: IL_43
    IL_03D0: IL_22
    IL_03D1: nop
    IL_03D2: nop
    IL_03D7: stsfld 0x021D2842
    IL_03D8: nop
    IL_03D9: ldloc.0
    IL_03DE: stfld 0x04000BBF
    IL_03E3: br IL_0457
    IL_03E4: ldarg.0
    IL_03E9: ldc.i4 349
    IL_03EE: stfld 0x04000BBC
    IL_03EF: ldarg.0
    IL_03F0: ldc.i4.0
    IL_03F5: stfld 0x04000BBD
    IL_03F6: ldarg.0
    IL_03F7: IL_22
    IL_03F8: nop
    IL_03F9: nop
    IL_03FA: ret
    IL_03FB: IL_43
    IL_03FC: IL_22
    IL_03FD: nop
    IL_03FE: nop
    IL_03FF: ldloc.0
    IL_0400: IL_43
    IL_0401: IL_22
    IL_0402: nop
    IL_0403: nop
    IL_0404: nop
    IL_0405: IL_43
    IL_0406: IL_22
    IL_0407: nop
    IL_0408: nop
    IL_040D: stsfld 0x021D2842
    IL_040E: nop
    IL_040F: ldloc.0
    IL_0414: stfld 0x04000BBF
    IL_0419: br IL_0457
    IL_041A: ldarg.0
    IL_041F: ldc.i4 433
    IL_0424: stfld 0x04000BBC
    IL_0425: ldarg.0
    IL_0426: ldc.i4.1
    IL_042B: stfld 0x04000BBA
    IL_042C: ldarg.0
    IL_042D: ldc.i4.0
    IL_0432: stfld 0x04000BBD
    IL_0433: ldarg.0
    IL_0434: IL_22
    IL_0435: nop
    IL_0436: nop
    IL_0437: ret
    IL_0438: IL_43
    IL_0439: IL_22
    IL_043A: nop
    IL_043B: nop
    IL_043C: ldloc.0
    IL_043D: IL_43
    IL_043E: IL_22
    IL_043F: nop
    IL_0440: nop
    IL_0441: nop
    IL_0442: IL_43
    IL_0443: IL_22
    IL_0444: nop
    IL_0445: nop
    IL_044A: stsfld 0x021D2842
    IL_044B: nop
    IL_044C: ldloc.0
    IL_0451: stfld 0x04000BBF
    IL_0456: br IL_0457
    IL_0457: ret
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
    IL_003B: ldfld 0x04000BDB
    IL_0040: call 0x0A0000DF
    IL_0041: ldc.i4.0
    IL_0046: call 0x0A0000EF
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000BD8
    IL_0051: brfalse IL_050B
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000BC5
    IL_005C: brfalse IL_0088
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000BD4
    IL_0064: ldc.i4.s 15
    IL_0065: IL_3E
    IL_0066: ldc.i4.8
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: ldarg.0
    IL_006B: ldc.i4.0
    IL_0070: stfld 0x04000BD8
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0078: stsfld 0x0111283F
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldarg.0
    IL_0080: ldfld 0x04000BDA
    IL_0081: ldc.i4.m1
    IL_0082: conv.r8
    IL_0084: starg.s 6
    IL_0085: nop
    IL_0086: ldloc.0
    IL_0087: ret
    IL_0088: ldarg.0
    IL_0089: dup
    IL_008E: ldfld 0x04000BC9
    IL_0093: call 0x0A000024
    IL_0094: IL_58
    IL_0099: stfld 0x04000BC9
    IL_009A: ldarg.0
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000BC9
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: IL_22
    IL_00A7: nop
    IL_00A8: nop
    IL_00AD: stsfld 0x00D4283F
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B4: stfld 0x04000BC9
    IL_00B9: call 0x0A0000F4
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000BC9
    IL_00C4: call 0x0A000307
    IL_00C9: call 0x0A0000F0
    IL_00CA: IL_22
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: IL_22
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: IL_F0
    IL_00D8: IL_43
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: ldelem.r8
    IL_00DD: IL_43
    IL_00E2: call 0x0600021D
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000BB1
    IL_00ED: call 0x0A0000E0
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x04000BD3
    IL_00F5: ldc.i4.s 9
    IL_00F6: IL_3D
    IL_00F7: stloc.1
    IL_00F8: ldarg.2
    IL_00F9: nop
    IL_00FA: nop
    IL_00FF: call 0x0A00017C
    IL_0104: call 0x0A0000F0
    IL_0105: IL_22
    IL_0106: nop
    IL_0107: nop
    IL_0108: nop
    IL_0109: nop
    IL_010A: IL_22
    IL_010B: nop
    IL_010C: nop
    IL_010D: ldarg.0
    IL_010E: IL_43
    IL_010F: IL_22
    IL_0110: nop
    IL_0111: nop
    IL_0112: IL_F0
    IL_0113: IL_43
    IL_0114: IL_22
    IL_0115: nop
    IL_0116: nop
    IL_011B: stsfld 0x021D2841
    IL_011C: nop
    IL_011D: ldloc.0
    IL_0122: ldsfld 0x040007B2
    IL_0123: ldarg.0
    IL_0128: ldfld 0x04000BD9
    IL_012D: ldc.i4 203
    IL_0132: call 0x0A0000E1
    IL_0137: ldstr 0x70023775
    IL_0138: ldarg.0
    IL_013D: ldfld 0x04000BD3
    IL_0142: newobj 0x0100000B
    IL_0147: call 0x0A000098
    IL_014C: ldstr 0x70002225
    IL_0151: call 0x0A0000E2
    IL_0156: call 0x0A0000E3
    IL_0157: IL_22
    IL_0158: nop
    IL_0159: nop
    IL_015A: conv.r.un
    IL_015B: IL_43
    IL_015C: IL_22
    IL_015D: nop
    IL_015E: nop
    IL_015F: ldc.i4.0
    IL_0160: IL_43
    IL_0161: IL_22
    IL_0162: nop
    IL_0163: nop
    IL_0164: nop
    IL_0165: IL_42
    IL_0166: IL_22
    IL_0167: nop
    IL_0168: nop
    IL_016D: stsfld 0x021D2841
    IL_016E: nop
    IL_016F: ldloc.0
    IL_0174: ldsfld 0x0A000099
    IL_0175: ldarg.0
    IL_017A: ldfld 0x04000BD4
    IL_017F: newobj 0x0100000B
    IL_0184: call 0x0A00009A
    IL_0189: ldstr 0x70002225
    IL_018E: call 0x0A0000E2
    IL_0193: call 0x0A0000E3
    IL_0194: IL_22
    IL_0195: nop
    IL_0196: nop
    IL_0197: shr
    IL_0198: IL_43
    IL_0199: IL_22
    IL_019A: nop
    IL_019B: nop
    IL_019C: ldc.i4.0
    IL_019D: IL_43
    IL_019E: IL_22
    IL_019F: nop
    IL_01A0: nop
    IL_01A5: stsfld 0x00002241
    IL_01AA: stsfld 0x021D2841
    IL_01AB: nop
    IL_01AC: ldloc.0
    IL_01AD: ldarg.0
    IL_01B2: ldfld 0x04000BB4
    IL_01B7: call 0x0A0000E0
    IL_01B8: ldarg.0
    IL_01BD: ldfld 0x04000BD5
    IL_01BE: ldarg.0
    IL_01C3: ldfld 0x04000BD4
    IL_01C4: IL_3F
    IL_01C5: IL_E4
    IL_01C6: IL_01
    IL_01C7: nop
    IL_01C8: nop
    IL_01C9: IL_22
    IL_01CA: nop
    IL_01CB: nop
    IL_01CC: IL_E0
    IL_01CD: IL_42
    IL_01CE: IL_22
    IL_01CF: nop
    IL_01D0: nop
    IL_01D1: ret
    IL_01D2: IL_43
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01DA: stsfld 0x00002243
    IL_01DF: stsfld 0x021D2841
    IL_01E0: nop
    IL_01E1: ldloc.0
    IL_01E2: ldc.i4.5
    IL_01E7: newarr 0x01000020
    IL_01E8: dup
    IL_01E9: ldc.i4.0
    IL_01EE: ldstr 0x70023781
    IL_01F3: stelem 0xB27E1725
    IL_01F4: ldloc.1
    IL_01F5: nop
    IL_01F6: ldarg.2
    IL_01F7: ldarg.0
    IL_01FC: ldfld 0x04000BD9
    IL_0201: ldc.i4 204
    IL_0206: call 0x0A0000E1
    IL_020B: stelem 0x80721825
    IL_020C: ret
    IL_020D: ldarg.0
    IL_0212: cpobj 0x021925A2
    IL_0217: ldfld 0x04000BD5
    IL_021C: newobj 0x0100000B
    IL_0221: stelem 0x85721A25
    IL_0222: IL_37
    IL_0223: ldarg.0
    IL_0228: cpobj 0x009628A2
    IL_0229: nop
    IL_022A: stloc.0
    IL_022F: ldstr 0x70000BC5
    IL_0234: call 0x0A0000E2
    IL_0239: call 0x0A0000E3
    IL_023A: IL_22
    IL_023B: nop
    IL_023C: nop
    IL_023D: ret
    IL_023E: IL_43
    IL_023F: IL_22
    IL_0240: nop
    IL_0241: nop
    IL_0242: IL_3E
    IL_0243: IL_43
    IL_0244: IL_22
    IL_0245: nop
    IL_0246: nop
    IL_024B: stsfld 0x00002242
    IL_024C: nop
    IL_024D: IL_42
    IL_0252: call 0x0600021D
    IL_0257: ldsfld 0x040007B2
    IL_0258: ldarg.0
    IL_025D: ldfld 0x04000BD9
    IL_025E: ldc.i4.1
    IL_0263: call 0x0A0000E1
    IL_0264: ldarg.0
    IL_0269: ldfld 0x04000BC4
    IL_026E: call 0x0A0000F1
    IL_0273: brfalse IL_03A8
    IL_0274: ldarg.0
    IL_0279: ldfld 0x04000BD4
    IL_027A: shl
    IL_027B: ldc.i4.1
    IL_0280: call 0x0600021E
    IL_0285: brfalse IL_03A3
    IL_0286: ldarg.0
    IL_0287: ldc.i4.0
    IL_028C: stfld 0x04000BD8
    IL_028D: ldarg.0
    IL_028E: IL_22
    IL_028F: nop
    IL_0290: nop
    IL_0291: nop
    IL_0292: nop
    IL_0297: stfld 0x04000BC9
    IL_0298: ldarg.0
    IL_029A: ldc.i4.s 10
    IL_029F: stfld 0x04000BD3
    IL_02A0: IL_22
    IL_02A1: nop
    IL_02A2: nop
    IL_02A7: stsfld 0x0111283F
    IL_02A8: nop
    IL_02A9: stloc.0
    IL_02AA: ldarg.0
    IL_02AF: ldfld 0x04000BCE
    IL_02B0: conv.r8
    IL_02B1: conv.u8
    IL_02B2: IL_01
    IL_02B3: nop
    IL_02B4: ldloc.0
    IL_02B5: ldarg.0
    IL_02BA: ldfld 0x04000BDA
    IL_02BB: conv.r8
    IL_02BC: IL_27
    IL_02BD: ldloc.0
    IL_02BE: nop
    IL_02BF: ldloc.0
    IL_02C0: ldarg.0
    IL_02C5: call 0x0A00000A
    IL_02C6: ldc.i4.0
    IL_02C7: conv.r8
    IL_02C8: stloc.1
    IL_02C9: nop
    IL_02CA: nop
    IL_02CB: stloc.0
    IL_02CC: ldarg.0
    IL_02CD: ldc.i4.0
    IL_02D2: stfld 0x04000BD2
    IL_02D3: ldarg.0
    IL_02D8: call 0x0A000081
    IL_02D9: ldarg.0
    IL_02DE: ldfld 0x04000BD4
    IL_02DF: stloc.0
    IL_02E0: ldc.i4.5
    IL_02E5: newarr 0x0100000C
    IL_02E6: dup
    IL_02E7: ldc.i4.0
    IL_02EC: ldsfld 0x040007B2
    IL_02ED: ldarg.0
    IL_02F2: ldfld 0x04000BD9
    IL_02F7: ldc.i4 234
    IL_02FC: call 0x0A0000E1
    IL_0301: stelem 0x89721725
    IL_0302: IL_37
    IL_0303: ldarg.0
    IL_0308: cpobj 0x021825A2
    IL_030D: ldflda 0x04000BD4
    IL_0312: call 0x0A000010
    IL_0317: stelem 0x8F721925
    IL_0318: IL_37
    IL_0319: ldarg.0
    IL_031E: cpobj 0x7E1A25A2
    IL_031F: IL_B2
    IL_0320: ldloc.1
    IL_0321: nop
    IL_0322: ldarg.2
    IL_0323: ldarg.0
    IL_0328: ldfld 0x04000BD9
    IL_032D: ldc.i4 239
    IL_0332: call 0x0A0000E1
    IL_0337: stelem 0x00024028
    IL_0338: stloc.0
    IL_033D: call 0x0600040D
    IL_033E: ldarg.0
    IL_033F: dup
    IL_0344: ldfld 0x04000BD5
    IL_0345: ldarg.0
    IL_034A: ldfld 0x04000BD4
    IL_034B: IL_59
    IL_0350: stfld 0x04000BD5
    IL_0351: ldarg.0
    IL_0356: ldfld 0x04000BC5
    IL_035B: brfalse IL_036F
    IL_035C: ldarg.0
    IL_035D: ldarg.0
    IL_0362: ldfld 0x04000BD4
    IL_0363: ldc.i4.3
    IL_0364: IL_58
    IL_0369: stfld 0x04000BD4
    IL_036E: br IL_037D
    IL_036F: ldarg.0
    IL_0370: ldarg.0
    IL_0375: ldfld 0x04000BD4
    IL_0376: ldc.i4.2
    IL_0377: IL_5A
    IL_037C: stfld 0x04000BD4
    IL_0381: ldstr 0x700004E5
    IL_0382: ldloc.0
    IL_0387: newobj 0x0100000B
    IL_038C: ldstr 0x70023795
    IL_0391: call 0x0A000098
    IL_0392: stloc.1
    IL_0397: call 0x0600004E
    IL_039C: ldstr 0x700237B3
    IL_039D: ldloc.1
    IL_039E: conv.r8
    IL_039F: IL_59
    IL_03A0: nop
    IL_03A1: nop
    IL_03A2: ldloc.0
    IL_03A7: call 0x0A000303
    IL_03AC: br IL_04AF
    IL_03AD: IL_22
    IL_03AE: nop
    IL_03AF: nop
    IL_03B0: IL_E0
    IL_03B1: IL_42
    IL_03B2: IL_22
    IL_03B3: nop
    IL_03B4: nop
    IL_03B5: ret
    IL_03B6: IL_43
    IL_03B7: IL_22
    IL_03B8: nop
    IL_03B9: nop
    IL_03BE: stsfld 0x00002243
    IL_03C3: stsfld 0x021D2841
    IL_03C4: nop
    IL_03C5: ldloc.0
    IL_03C6: ldc.i4.5
    IL_03CB: newarr 0x01000020
    IL_03CC: dup
    IL_03CD: ldc.i4.0
    IL_03D2: ldstr 0x70023781
    IL_03D7: stelem 0xB27E1725
    IL_03D8: ldloc.1
    IL_03D9: nop
    IL_03DA: ldarg.2
    IL_03DB: ldarg.0
    IL_03E0: ldfld 0x04000BD9
    IL_03E5: ldc.i4 204
    IL_03EA: call 0x0A0000E1
    IL_03EF: stelem 0x80721825
    IL_03F0: ret
    IL_03F1: ldarg.0
    IL_03F6: cpobj 0x021925A2
    IL_03FB: ldfld 0x04000BD5
    IL_0400: newobj 0x0100000B
    IL_0405: stelem 0x85721A25
    IL_0406: IL_37
    IL_0407: ldarg.0
    IL_040C: cpobj 0x009628A2
    IL_040D: nop
    IL_040E: stloc.0
    IL_0413: ldstr 0x70023389
    IL_0418: call 0x0A0000E2
    IL_041D: call 0x0A0000E3
    IL_041E: IL_22
    IL_041F: nop
    IL_0420: nop
    IL_0421: ret
    IL_0422: IL_43
    IL_0423: IL_22
    IL_0424: nop
    IL_0425: nop
    IL_0426: IL_3E
    IL_0427: IL_43
    IL_0428: IL_22
    IL_0429: nop
    IL_042A: nop
    IL_042F: stsfld 0x00002242
    IL_0430: nop
    IL_0431: IL_42
    IL_0436: call 0x0600021D
    IL_043B: ldsfld 0x040007B2
    IL_043C: ldarg.0
    IL_0441: ldfld 0x04000BD9
    IL_0446: ldc.i4 207
    IL_044B: call 0x0A0000E1
    IL_044C: ldarg.0
    IL_0451: ldfld 0x04000BC4
    IL_0456: call 0x0A0000F1
    IL_045B: brfalse IL_04AF
    IL_0460: ldstr 0x70001E8B
    IL_0461: ldc.i4.1
    IL_0466: call 0x0600021F
    IL_0467: ldarg.0
    IL_046C: ldfld 0x04000BD1
    IL_046D: ldnull
    IL_0472: call 0x0A000061
    IL_0477: brfalse IL_048D
    IL_0478: ldarg.0
    IL_047D: ldstr 0x700232DD
    IL_0482: call 0x0A000012
    IL_0483: conv.u8
    IL_0484: ldloc.0
    IL_0485: nop
    IL_0486: nop
    IL_0487: IL_01
    IL_048C: stfld 0x04000BD1
    IL_048D: ldarg.0
    IL_0492: ldfld 0x04000BD1
    IL_0493: conv.r8
    IL_0494: ldarg.3
    IL_0495: nop
    IL_0496: nop
    IL_0497: stloc.0
    IL_049C: call 0x0A00001B
    IL_04A1: call 0x0A000013
    IL_04A6: call 0x0A000014
    IL_04A7: pop
    IL_04A8: ldarg.0
    IL_04A9: ldc.i4.1
    IL_04AE: stfld 0x04000BD2
    IL_04AF: IL_22
    IL_04B0: nop
    IL_04B1: nop
    IL_04B2: conv.r.un
    IL_04B3: IL_43
    IL_04B4: IL_22
    IL_04B5: nop
    IL_04B6: nop
    IL_04B7: IL_3E
    IL_04B8: IL_43
    IL_04B9: IL_22
    IL_04BA: nop
    IL_04BB: nop
    IL_04C0: stsfld 0x00002242
    IL_04C1: nop
    IL_04C2: IL_42
    IL_04C7: call 0x0600021D
    IL_04CC: ldsfld 0x040007B2
    IL_04CD: ldarg.0
    IL_04D2: ldfld 0x04000BD9
    IL_04D3: ldc.i4.2
    IL_04D8: call 0x0A0000E1
    IL_04D9: ldarg.0
    IL_04DE: ldfld 0x04000BC4
    IL_04E3: call 0x0A0000F1
    IL_04E8: brfalse IL_0506
    IL_04E9: ldarg.0
    IL_04EA: ldc.i4.0
    IL_04EF: stfld 0x04000BD8
    IL_04F0: IL_22
    IL_04F1: nop
    IL_04F2: nop
    IL_04F7: stsfld 0x0111283F
    IL_04F8: nop
    IL_04F9: stloc.0
    IL_04FA: ldarg.0
    IL_04FF: ldfld 0x04000BDA
    IL_0500: ldc.i4.m1
    IL_0501: conv.r8
    IL_0503: starg.s 6
    IL_0504: nop
    IL_0505: ldloc.0
    IL_050A: br IL_0BB0
    IL_050B: ldarg.0
    IL_0510: ldfld 0x04000BCC
    IL_0515: brfalse IL_0581
    IL_0516: IL_22
    IL_0517: nop
    IL_0518: nop
    IL_0519: IL_E0
    IL_051A: IL_42
    IL_051B: IL_22
    IL_051C: nop
    IL_051D: nop
    IL_051E: IL_B4
    IL_051F: IL_42
    IL_0520: IL_22
    IL_0521: nop
    IL_0522: nop
    IL_0527: stsfld 0x00002243
    IL_0528: rem
    IL_0529: IL_41
    IL_052E: call 0x0600021D
    IL_0533: ldsfld 0x040007B2
    IL_0534: ldarg.0
    IL_0539: ldfld 0x04000BD9
    IL_053E: ldc.i4 434
    IL_0543: call 0x0A0000E1
    IL_0548: call 0x0A0002EA
    IL_0549: IL_22
    IL_054A: nop
    IL_054B: nop
    IL_054C: IL_E0
    IL_054D: IL_42
    IL_054E: IL_22
    IL_054F: nop
    IL_0550: nop
    IL_0552: bgt.s IL_0596
    IL_0553: IL_22
    IL_0554: nop
    IL_0555: nop
    IL_055A: stsfld 0x00002243
    IL_055C: starg.s 66
    IL_0561: call 0x0600021D
    IL_0566: ldsfld 0x040007B2
    IL_0567: ldarg.0
    IL_056C: ldfld 0x04000BD9
    IL_0571: ldc.i4 435
    IL_0576: call 0x0A0000E1
    IL_057B: call 0x0A0002EA
    IL_0580: br IL_0BB0
    IL_0581: ldarg.0
    IL_0586: ldfld 0x04000BD7
    IL_058B: brfalse IL_0A75
    IL_058C: ldarg.0
    IL_0591: ldfld 0x04000BCA
    IL_0596: brfalse IL_05E3
    IL_0597: ldarg.0
    IL_059C: call 0x0A0000D7
    IL_059D: stloc.3
    IL_059F: ldloca.s 3
    IL_05A4: ldfld 0x0A00005E
    IL_05A5: IL_22
    IL_05A6: nop
    IL_05A7: nop
    IL_05A8: IL_F0
    IL_05A9: IL_43
    IL_05AE: call 0x0A0000D9
    IL_05AF: conv.i2
    IL_05B0: add
    IL_05B1: IL_5A
    IL_05B2: IL_22
    IL_05B3: nop
    IL_05B4: nop
    IL_05B5: IL_56
    IL_05B6: IL_43
    IL_05B7: IL_59
    IL_05B8: IL_22
    IL_05B9: nop
    IL_05BA: nop
    IL_05BB: IL_FC
    IL_05BC: IL_42
    IL_05BD: add
    IL_05C2: stfld 0x04000BC7
    IL_05C3: ldarg.0
    IL_05C4: ldarg.0
    IL_05C9: ldfld 0x04000BC7
    IL_05CA: IL_22
    IL_05CB: nop
    IL_05CC: nop
    IL_05CD: nop
    IL_05CE: nop
    IL_05CF: IL_22
    IL_05D0: nop
    IL_05D1: nop
    IL_05D6: stsfld 0x00D4283F
    IL_05D7: nop
    IL_05D8: stloc.0
    IL_05DD: stfld 0x04000BC7
    IL_05E2: br IL_0636
    IL_05E3: ldarg.0
    IL_05E8: ldfld 0x04000BCB
    IL_05ED: brfalse IL_0636
    IL_05EE: ldarg.0
    IL_05F3: call 0x0A0000D7
    IL_05F5: stloc.s 4
    IL_05F7: ldloca.s 4
    IL_05FC: ldfld 0x0A00005E
    IL_05FD: IL_22
    IL_05FE: nop
    IL_05FF: nop
    IL_0600: IL_F0
    IL_0601: IL_43
    IL_0606: call 0x0A0000D9
    IL_0607: conv.i2
    IL_0608: add
    IL_0609: IL_5A
    IL_060A: IL_22
    IL_060B: nop
    IL_060C: nop
    IL_060D: IL_56
    IL_060E: IL_43
    IL_060F: IL_59
    IL_0610: IL_22
    IL_0611: nop
    IL_0612: nop
    IL_0613: IL_FC
    IL_0614: IL_42
    IL_0615: add
    IL_061A: stfld 0x04000BC8
    IL_061B: ldarg.0
    IL_061C: ldarg.0
    IL_0621: ldfld 0x04000BC8
    IL_0622: IL_22
    IL_0623: nop
    IL_0624: nop
    IL_0625: nop
    IL_0626: nop
    IL_0627: IL_22
    IL_0628: nop
    IL_0629: nop
    IL_062E: stsfld 0x00D4283F
    IL_062F: nop
    IL_0630: stloc.0
    IL_0635: stfld 0x04000BC8
    IL_0636: IL_22
    IL_0637: nop
    IL_0638: nop
    IL_0639: nop
    IL_063A: nop
    IL_063B: IL_22
    IL_063C: nop
    IL_063D: nop
    IL_063E: nop
    IL_063F: nop
    IL_0640: IL_22
    IL_0641: nop
    IL_0642: nop
    IL_0643: IL_F0
    IL_0644: IL_43
    IL_0645: IL_22
    IL_0646: nop
    IL_0647: nop
    IL_0648: ldelem.r8
    IL_0649: IL_43
    IL_064E: call 0x0600021D
    IL_064F: ldarg.0
    IL_0654: ldfld 0x04000BB1
    IL_0659: call 0x0A0000E0
    IL_065A: IL_22
    IL_065B: nop
    IL_065C: nop
    IL_065D: IL_E0
    IL_065E: IL_42
    IL_065F: IL_22
    IL_0660: nop
    IL_0661: nop
    IL_0666: cpobj 0x00002242
    IL_066B: stsfld 0x00002243
    IL_0670: stsfld 0x021D2843
    IL_0671: nop
    IL_0672: ldloc.0
    IL_0673: ldarg.0
    IL_0678: ldfld 0x04000BB2
    IL_067D: call 0x0A0000E0
    IL_067E: IL_22
    IL_067F: nop
    IL_0680: nop
    IL_0681: nop
    IL_0682: IL_43
    IL_0683: IL_22
    IL_0684: nop
    IL_0685: nop
    IL_068A: isinst 0x00002242
    IL_068F: newobj 0x00002242
    IL_0694: stsfld 0x021D2841
    IL_0695: nop
    IL_0696: ldloc.0
    IL_069B: ldsfld 0x040007B2
    IL_069C: ldarg.0
    IL_06A1: ldfld 0x04000BD9
    IL_06A6: ldc.i4 302
    IL_06AB: call 0x0A0000E1
    IL_06B0: ldstr 0x70000BC5
    IL_06B5: call 0x0A0000E2
    IL_06BA: call 0x0A0000E3
    IL_06BB: IL_22
    IL_06BC: nop
    IL_06BD: nop
    IL_06BE: nop
    IL_06BF: IL_43
    IL_06C0: IL_22
    IL_06C1: nop
    IL_06C2: nop
    IL_06C3: IL_EC
    IL_06C4: IL_42
    IL_06C5: IL_22
    IL_06C6: nop
    IL_06C7: nop
    IL_06CC: newobj 0x00002242
    IL_06D1: stsfld 0x021D2841
    IL_06D2: nop
    IL_06D3: ldloc.0
    IL_06D8: ldsfld 0x040007B2
    IL_06D9: ldarg.0
    IL_06DE: ldfld 0x04000BD9
    IL_06E3: ldc.i4 244
    IL_06E8: call 0x0A0000E1
    IL_06ED: ldstr 0x70000BC5
    IL_06F2: call 0x0A0000E2
    IL_06F7: call 0x0A0000E3
    IL_06F8: IL_22
    IL_06F9: nop
    IL_06FA: nop
    IL_06FB: nop
    IL_06FC: IL_43
    IL_06FD: IL_22
    IL_06FE: nop
    IL_06FF: nop
    IL_0700: ldc.i4.5
    IL_0701: IL_43
    IL_0702: IL_22
    IL_0703: nop
    IL_0704: nop
    IL_0709: newobj 0x00002242
    IL_070E: stsfld 0x021D2841
    IL_070F: nop
    IL_0710: ldloc.0
    IL_0715: ldsfld 0x040007B2
    IL_0716: ldarg.0
    IL_071B: ldfld 0x04000BD9
    IL_071D: ldc.i4.s 90
    IL_0722: call 0x0A0000E1
    IL_0727: ldstr 0x70000BC5
    IL_072C: call 0x0A0000E2
    IL_0731: call 0x0A0000E3
    IL_0732: IL_22
    IL_0733: nop
    IL_0734: nop
    IL_0735: nop
    IL_0736: IL_43
    IL_0737: IL_22
    IL_0738: nop
    IL_0739: nop
    IL_073A: IL_42
    IL_073B: IL_43
    IL_073C: IL_22
    IL_073D: nop
    IL_073E: nop
    IL_0743: newobj 0x00002242
    IL_0748: stsfld 0x021D2841
    IL_0749: nop
    IL_074A: ldloc.0
    IL_074F: ldsfld 0x040007B2
    IL_0750: ldarg.0
    IL_0755: ldfld 0x04000BD9
    IL_075A: ldc.i4 245
    IL_075F: call 0x0A0000E1
    IL_0764: ldstr 0x70000BC5
    IL_0769: call 0x0A0000E2
    IL_076E: call 0x0A0000E3
    IL_076F: IL_22
    IL_0770: nop
    IL_0771: nop
    IL_0772: IL_54
    IL_0773: IL_43
    IL_0774: IL_22
    IL_0775: nop
    IL_0776: nop
    IL_077B: brtrue IL_29BF
    IL_077C: nop
    IL_077D: IL_43
    IL_077E: IL_22
    IL_077F: nop
    IL_0780: nop
    IL_0781: nop
    IL_0782: IL_42
    IL_0787: call 0x0600021D
    IL_078C: ldsfld 0x040007B2
    IL_078D: ldarg.0
    IL_0792: ldfld 0x04000BD9
    IL_0797: ldc.i4 246
    IL_079C: call 0x0A0000E1
    IL_079D: ldarg.0
    IL_07A2: ldfld 0x04000BC2
    IL_07A7: call 0x0A0000F1
    IL_07AC: brfalse IL_07CF
    IL_07AD: ldc.i4.2
    IL_07AE: stloc.2
    IL_07AF: ldarg.0
    IL_07B0: ldarg.0
    IL_07B5: ldfld 0x04000BD9
    IL_07B6: ldc.i4.1
    IL_07B7: IL_58
    IL_07B8: ldloc.2
    IL_07B9: mul
    IL_07BE: stfld 0x04000BD9
    IL_07C3: ldstr 0x70000BB3
    IL_07C4: ldarg.0
    IL_07C9: ldfld 0x04000BD9
    IL_07CE: call 0x0A00009F
    IL_07CF: IL_22
    IL_07D0: nop
    IL_07D1: nop
    IL_07D4: ldloc 8771
    IL_07D5: nop
    IL_07D6: nop
    IL_07D7: IL_98
    IL_07D8: IL_42
    IL_07D9: IL_22
    IL_07DA: nop
    IL_07DB: nop
    IL_07DC: ldc.i4.2
    IL_07DD: IL_43
    IL_07DE: IL_22
    IL_07DF: nop
    IL_07E0: nop
    IL_07E1: nop
    IL_07E2: IL_42
    IL_07E7: call 0x0600021D
    IL_07EC: ldsfld 0x0A000099
    IL_07ED: ldarg.0
    IL_07F2: ldfld 0x04000BC3
    IL_07F7: call 0x0A0002E8
    IL_07FC: brfalse IL_0809
    IL_07FD: ldarg.0
    IL_07FE: ldc.i4.1
    IL_0803: stfld 0x04000BCB
    IL_0808: br IL_0826
    IL_0809: ldarg.0
    IL_080E: ldfld 0x04000BCB
    IL_0813: brfalse IL_0826
    IL_0814: ldarg.0
    IL_0819: ldfld 0x04000BC8
    IL_081E: call 0x0A0001C2
    IL_081F: ldarg.0
    IL_0820: ldc.i4.0
    IL_0825: stfld 0x04000BCB
    IL_0826: ldarg.0
    IL_082B: ldfld 0x04000BC8
    IL_082C: IL_22
    IL_082D: nop
    IL_082E: nop
    IL_082F: IL_FC
    IL_0830: IL_42
    IL_0831: IL_5A
    IL_0832: IL_22
    IL_0833: nop
    IL_0834: nop
    IL_0835: IL_4E
    IL_0836: IL_43
    IL_0837: IL_58
    IL_0838: IL_22
    IL_0839: nop
    IL_083A: nop
    IL_083B: IL_A8
    IL_083C: IL_42
    IL_083D: IL_22
    IL_083E: nop
    IL_083F: nop
    IL_0844: stsfld 0x00002241
    IL_0849: stsfld 0x021D2841
    IL_084A: nop
    IL_084B: ldloc.0
    IL_084C: ldarg.0
    IL_0851: ldfld 0x04000BB3
    IL_0856: call 0x0A0000E0
    IL_0857: IL_22
    IL_0858: nop
    IL_0859: nop
    IL_085C: ldloc 8771
    IL_085D: nop
    IL_085E: nop
    IL_085F: IL_DE
    IL_0860: IL_42
    IL_0861: IL_22
    IL_0862: nop
    IL_0863: nop
    IL_0864: ldc.i4.2
    IL_0865: IL_43
    IL_0866: IL_22
    IL_0867: nop
    IL_0868: nop
    IL_0869: nop
    IL_086A: IL_42
    IL_086F: call 0x0600021D
    IL_0874: ldsfld 0x0A000099
    IL_0875: ldarg.0
    IL_087A: ldfld 0x04000BC3
    IL_087F: call 0x0A0002E8
    IL_0884: brfalse IL_0891
    IL_0885: ldarg.0
    IL_0886: ldc.i4.1
    IL_088B: stfld 0x04000BCA
    IL_0890: br IL_08B4
    IL_0891: ldarg.0
    IL_0896: ldfld 0x04000BCA
    IL_089B: brfalse IL_08B4
    IL_089C: ldarg.0
    IL_08A1: ldfld 0x04000BCF
    IL_08A2: ldarg.0
    IL_08A7: ldfld 0x04000BC7
    IL_08A8: conv.r8
    IL_08A9: IL_F8
    IL_08AA: ldarg.2
    IL_08AB: nop
    IL_08AC: ldloc.0
    IL_08AD: ldarg.0
    IL_08AE: ldc.i4.0
    IL_08B3: stfld 0x04000BCA
    IL_08B4: ldarg.0
    IL_08B9: ldfld 0x04000BC7
    IL_08BA: IL_22
    IL_08BB: nop
    IL_08BC: nop
    IL_08BD: IL_FC
    IL_08BE: IL_42
    IL_08BF: IL_5A
    IL_08C0: IL_22
    IL_08C1: nop
    IL_08C2: nop
    IL_08C3: IL_4E
    IL_08C4: IL_43
    IL_08C5: IL_58
    IL_08C6: IL_22
    IL_08C7: nop
    IL_08C8: nop
    IL_08C9: IL_EE
    IL_08CA: IL_42
    IL_08CB: IL_22
    IL_08CC: nop
    IL_08CD: nop
    IL_08D2: stsfld 0x00002241
    IL_08D7: stsfld 0x021D2841
    IL_08D8: nop
    IL_08D9: ldloc.0
    IL_08DA: ldarg.0
    IL_08DF: ldfld 0x04000BB3
    IL_08E4: call 0x0A0000E0
    IL_08E5: IL_22
    IL_08E6: nop
    IL_08E7: nop
    IL_08E8: IL_50
    IL_08E9: IL_43
    IL_08EA: IL_22
    IL_08EB: nop
    IL_08EC: nop
    IL_08ED: div.un
    IL_08EE: IL_43
    IL_08EF: IL_22
    IL_08F0: nop
    IL_08F1: nop
    IL_08F6: stsfld 0x00002242
    IL_08F7: nop
    IL_08F8: IL_42
    IL_08FD: call 0x0600021D
    IL_0902: ldsfld 0x040007B2
    IL_0903: ldarg.0
    IL_0908: ldfld 0x04000BD9
    IL_0909: ldc.i4.0
    IL_090E: call 0x0A0000E1
    IL_090F: ldarg.0
    IL_0914: ldfld 0x04000BC4
    IL_0919: call 0x0A0000F1
    IL_091E: brfalse IL_0946
    IL_091F: ldarg.0
    IL_0920: ldc.i4.0
    IL_0925: stfld 0x04000BD7
    IL_092A: ldstr 0x70022774
    IL_092B: ldarg.0
    IL_0930: ldfld 0x04000BC7
    IL_0935: call 0x0A000255
    IL_093A: ldstr 0x7002270C
    IL_093B: ldarg.0
    IL_0940: ldfld 0x04000BC8
    IL_0945: call 0x0A000255
    IL_0946: IL_22
    IL_0947: nop
    IL_0948: nop
    IL_0949: IL_56
    IL_094A: IL_43
    IL_094B: IL_22
    IL_094C: nop
    IL_094D: nop
    IL_094F: stloc.s 67
    IL_0950: IL_22
    IL_0951: nop
    IL_0952: nop
    IL_0953: nop
    IL_0954: IL_42
    IL_0955: IL_22
    IL_0956: nop
    IL_0957: nop
    IL_0958: nop
    IL_0959: IL_42
    IL_095E: call 0x0600021D
    IL_0963: ldstr 0x700237CB
    IL_0964: ldarg.0
    IL_0969: ldfld 0x04000BC1
    IL_096E: call 0x0A0000F1
    IL_0973: brfalse IL_09BF
    IL_0974: ldarg.0
    IL_0979: ldfld 0x04000BDC
    IL_097A: ldc.i4.0
    IL_097B: IL_3E
    IL_0980: brtrue IL_2000981
    IL_0981: dup
    IL_0986: ldfld 0x04000BDC
    IL_0987: ldc.i4.1
    IL_0988: IL_59
    IL_098D: stfld 0x04000BDC
    IL_0992: call 0x0A000035
    IL_0993: conv.r8
    IL_0994: ldloc.0
    IL_0995: nop
    IL_0996: nop
    IL_0998: br.s IL_099B
    IL_099D: ldfld 0x04000BDC
    IL_099F: ldc.i4.s -2
    IL_09A0: IL_5A
    IL_09A2: ldc.i4.s 30
    IL_09A3: IL_58
    IL_09A4: conv.i2
    IL_09A5: conv.r8
    IL_09A7: blt.s IL_09A9
    IL_09A8: nop
    IL_09A9: ldloc.0
    IL_09AE: ldstr 0x70001E7D
    IL_09AF: ldarg.0
    IL_09B4: ldfld 0x04000BDC
    IL_09B9: call 0x0600021F
    IL_09BE: br IL_0A33
    IL_09BF: IL_22
    IL_09C0: nop
    IL_09C1: nop
    IL_09C2: ldelem.i
    IL_09C3: IL_43
    IL_09C4: IL_22
    IL_09C5: nop
    IL_09C6: nop
    IL_09C8: stloc.s 67
    IL_09C9: IL_22
    IL_09CA: nop
    IL_09CB: nop
    IL_09CC: nop
    IL_09CD: IL_42
    IL_09CE: IL_22
    IL_09CF: nop
    IL_09D0: nop
    IL_09D1: nop
    IL_09D2: IL_42
    IL_09D7: call 0x0600021D
    IL_09DC: ldstr 0x700237CF
    IL_09DD: ldarg.0
    IL_09E2: ldfld 0x04000BC1
    IL_09E7: call 0x0A0000F1
    IL_09EC: brfalse IL_0A33
    IL_09ED: ldarg.0
    IL_09F2: ldfld 0x04000BDC
    IL_09F3: ldc.i4.5
    IL_09F4: IL_3C
    IL_09F9: brtrue IL_20009FA
    IL_09FA: dup
    IL_09FF: ldfld 0x04000BDC
    IL_0A00: ldc.i4.1
    IL_0A01: IL_58
    IL_0A06: stfld 0x04000BDC
    IL_0A0B: call 0x0A000035
    IL_0A0C: conv.r8
    IL_0A0D: ldloc.0
    IL_0A0E: nop
    IL_0A0F: nop
    IL_0A11: br.s IL_0A14
    IL_0A16: ldfld 0x04000BDC
    IL_0A18: ldc.i4.s -2
    IL_0A19: IL_5A
    IL_0A1B: ldc.i4.s 30
    IL_0A1C: IL_58
    IL_0A1D: conv.i2
    IL_0A1E: conv.r8
    IL_0A20: blt.s IL_0A22
    IL_0A21: nop
    IL_0A22: ldloc.0
    IL_0A27: ldstr 0x70001E7D
    IL_0A28: ldarg.0
    IL_0A2D: ldfld 0x04000BDC
    IL_0A32: call 0x0600021F
    IL_0A33: IL_22
    IL_0A34: nop
    IL_0A35: nop
    IL_0A36: IL_82
    IL_0A37: IL_43
    IL_0A38: IL_22
    IL_0A39: nop
    IL_0A3A: nop
    IL_0A3C: stloc.s 67
    IL_0A3D: IL_22
    IL_0A3E: nop
    IL_0A3F: nop
    IL_0A40: nop
    IL_0A41: IL_42
    IL_0A42: IL_22
    IL_0A43: nop
    IL_0A44: nop
    IL_0A45: nop
    IL_0A46: IL_42
    IL_0A4B: call 0x0600021D
    IL_0A50: ldstr 0x700237D3
    IL_0A51: ldarg.0
    IL_0A56: ldfld 0x04000BDC
    IL_0A5B: newobj 0x0100000B
    IL_0A60: call 0x0A00009A
    IL_0A65: ldstr 0x70000BC5
    IL_0A6A: call 0x0A0000E2
    IL_0A6F: call 0x0A0000E3
    IL_0A74: br IL_0BB0
    IL_0A75: ldarg.0
    IL_0A7A: ldfld 0x04000BD6
    IL_0A7F: brfalse IL_0BB0
    IL_0A80: IL_22
    IL_0A81: nop
    IL_0A82: nop
    IL_0A83: nop
    IL_0A84: nop
    IL_0A85: IL_22
    IL_0A86: nop
    IL_0A87: nop
    IL_0A88: nop
    IL_0A89: nop
    IL_0A8A: IL_22
    IL_0A8B: nop
    IL_0A8C: nop
    IL_0A8D: IL_F0
    IL_0A8E: IL_43
    IL_0A8F: IL_22
    IL_0A90: nop
    IL_0A91: nop
    IL_0A92: ldelem.r8
    IL_0A93: IL_43
    IL_0A98: call 0x0600021D
    IL_0A99: ldarg.0
    IL_0A9E: ldfld 0x04000BB1
    IL_0AA3: call 0x0A0000E0
    IL_0AA4: IL_22
    IL_0AA5: nop
    IL_0AA6: nop
    IL_0AA7: IL_E0
    IL_0AA8: IL_42
    IL_0AA9: IL_22
    IL_0AAA: nop
    IL_0AAB: nop
    IL_0AAC: ldelem.r8
    IL_0AAD: IL_42
    IL_0AAE: IL_22
    IL_0AAF: nop
    IL_0AB0: nop
    IL_0AB5: stsfld 0x00002243
    IL_0ABA: stsfld 0x021D2842
    IL_0ABB: nop
    IL_0ABC: ldloc.0
    IL_0AC1: ldsfld 0x040007B2
    IL_0AC2: ldarg.0
    IL_0AC7: ldfld 0x04000BD9
    IL_0AC9: ldc.i4.s 30
    IL_0ACE: call 0x0A0000E1
    IL_0ACF: ldarg.0
    IL_0AD4: ldfld 0x04000BB0
    IL_0AD9: call 0x0A0000F1
    IL_0ADE: brfalse IL_0B11
    IL_0ADF: IL_22
    IL_0AE0: nop
    IL_0AE1: nop
    IL_0AE6: stsfld 0x0111283F
    IL_0AE7: nop
    IL_0AE8: stloc.0
    IL_0AE9: ldarg.0
    IL_0AEA: ldc.i4.0
    IL_0AEF: stfld 0x04000BD6
    IL_0AF0: ldarg.0
    IL_0AF5: ldfld 0x04000BCE
    IL_0AF6: conv.r8
    IL_0AF7: conv.u4
    IL_0AF8: IL_01
    IL_0AF9: nop
    IL_0AFA: ldloc.0
    IL_0AFB: ldarg.0
    IL_0B00: call 0x0A00000A
    IL_0B01: ldc.i4.0
    IL_0B02: conv.r8
    IL_0B03: stloc.1
    IL_0B04: nop
    IL_0B05: nop
    IL_0B06: stloc.0
    IL_0B0B: call 0x0A000303
    IL_0B10: br IL_0BB0
    IL_0B11: IL_22
    IL_0B12: nop
    IL_0B13: nop
    IL_0B14: IL_E0
    IL_0B15: IL_42
    IL_0B16: IL_22
    IL_0B17: nop
    IL_0B18: nop
    IL_0B19: ldarg.0
    IL_0B1A: IL_43
    IL_0B1B: IL_22
    IL_0B1C: nop
    IL_0B1D: nop
    IL_0B22: stsfld 0x00002243
    IL_0B27: stsfld 0x021D2842
    IL_0B28: nop
    IL_0B29: ldloc.0
    IL_0B2E: ldsfld 0x040007B2
    IL_0B2F: ldarg.0
    IL_0B34: ldfld 0x04000BD9
    IL_0B36: ldc.i4.s 31
    IL_0B3B: call 0x0A0000E1
    IL_0B3C: ldarg.0
    IL_0B41: ldfld 0x04000BB0
    IL_0B46: call 0x0A0000F1
    IL_0B4B: brfalse IL_0B58
    IL_0B4C: ldarg.0
    IL_0B4D: ldc.i4.1
    IL_0B52: stfld 0x04000BD7
    IL_0B57: br IL_0BB0
    IL_0B58: IL_22
    IL_0B59: nop
    IL_0B5A: nop
    IL_0B5B: IL_E0
    IL_0B5C: IL_42
    IL_0B5D: IL_22
    IL_0B5E: nop
    IL_0B5F: nop
    IL_0B60: IL_34
    IL_0B61: IL_43
    IL_0B62: IL_22
    IL_0B63: nop
    IL_0B64: nop
    IL_0B69: stsfld 0x00002243
    IL_0B6E: stsfld 0x021D2842
    IL_0B6F: nop
    IL_0B70: ldloc.0
    IL_0B75: ldsfld 0x040007B2
    IL_0B76: ldarg.0
    IL_0B7B: ldfld 0x04000BD9
    IL_0B7D: ldc.i4.s 59
    IL_0B82: call 0x0A0000E1
    IL_0B83: ldarg.0
    IL_0B88: ldfld 0x04000BB0
    IL_0B8D: call 0x0A0000F1
    IL_0B92: brfalse IL_0BB0
    IL_0B93: IL_22
    IL_0B94: nop
    IL_0B95: nop
    IL_0B9A: stsfld 0x0111283F
    IL_0B9B: nop
    IL_0B9C: stloc.0
    IL_0B9D: ldarg.0
    IL_0B9E: ldc.i4.0
    IL_0BA3: stfld 0x04000BD6
    IL_0BA4: ldarg.0
    IL_0BA9: ldfld 0x04000BDA
    IL_0BAA: ldc.i4.m1
    IL_0BAB: conv.r8
    IL_0BAD: starg.s 6
    IL_0BAE: nop
    IL_0BAF: ldloc.0
    IL_0BB0: ldarg.0
    IL_0BB5: ldfld 0x04000BB8
    IL_0BBA: brfalse IL_0DA9
    IL_0BBB: IL_22
    IL_0BBC: nop
    IL_0BBD: nop
    IL_0BBE: IL_E0
    IL_0BBF: IL_42
    IL_0BC0: IL_22
    IL_0BC1: nop
    IL_0BC2: nop
    IL_0BC3: IL_C0
    IL_0BC4: IL_42
    IL_0BC5: IL_22
    IL_0BC6: nop
    IL_0BC7: nop
    IL_0BCC: stsfld 0x00002243
    IL_0BCD: nop
    IL_0BCE: IL_43
    IL_0BD3: call 0x0600021D
    IL_0BD4: ldarg.0
    IL_0BD9: ldfld 0x04000BB5
    IL_0BDE: call 0x0A0000E0
    IL_0BDF: IL_22
    IL_0BE0: nop
    IL_0BE1: nop
    IL_0BE2: IL_F0
    IL_0BE3: IL_42
    IL_0BE4: IL_22
    IL_0BE5: nop
    IL_0BE6: nop
    IL_0BE7: IL_CC
    IL_0BE8: IL_42
    IL_0BE9: IL_22
    IL_0BEA: nop
    IL_0BEB: nop
    IL_0BF0: cpobj 0x00002243
    IL_0BF2: starg.s 66
    IL_0BF7: call 0x0600021D
    IL_0BFC: ldsfld 0x0A000099
    IL_0C01: ldsfld 0x040007B2
    IL_0C02: ldarg.0
    IL_0C07: ldfld 0x04000BD9
    IL_0C08: ldarg.0
    IL_0C0D: ldfld 0x04000BBC
    IL_0C12: call 0x0A0000E1
    IL_0C17: call 0x0A000011
    IL_0C1C: ldstr 0x70000C43
    IL_0C21: call 0x0A0000E2
    IL_0C26: call 0x0A0000E3
    IL_0C27: IL_22
    IL_0C28: nop
    IL_0C29: nop
    IL_0C2A: IL_EC
    IL_0C2B: IL_42
    IL_0C2C: IL_22
    IL_0C2D: nop
    IL_0C2E: nop
    IL_0C31: ldloc 8771
    IL_0C32: nop
    IL_0C33: nop
    IL_0C34: conv.u4
    IL_0C35: IL_43
    IL_0C36: IL_22
    IL_0C37: nop
    IL_0C38: nop
    IL_0C39: rem
    IL_0C3A: IL_41
    IL_0C3F: call 0x0600021D
    IL_0C40: ldc.i4.4
    IL_0C45: newarr 0x01000020
    IL_0C46: dup
    IL_0C47: ldc.i4.0
    IL_0C4C: ldsfld 0x0A000099
    IL_0C51: stelem 0x7B021725
    IL_0C52: IL_BB
    IL_0C53: stloc.1
    IL_0C54: nop
    IL_0C55: ldarg.2
    IL_0C56: ldc.i4.1
    IL_0C57: IL_58
    IL_0C5C: newobj 0x0100000B
    IL_0C61: stelem 0xD9721825
    IL_0C62: IL_37
    IL_0C63: ldarg.0
    IL_0C68: cpobj 0x021925A2
    IL_0C6D: ldfld 0x04000BBA
    IL_0C72: newobj 0x0100000B
    IL_0C77: stelem 0x00009628
    IL_0C78: stloc.0
    IL_0C7D: ldstr 0x70000C43
    IL_0C82: call 0x0A0000E2
    IL_0C87: call 0x0A0000E3
    IL_0C88: ldarg.0
    IL_0C8D: ldfld 0x04000BBF
    IL_0C8E: ldarg.0
    IL_0C93: ldfld 0x04000BB7
    IL_0C98: call 0x0A0000E0
    IL_0C99: ldarg.0
    IL_0C9E: ldfld 0x04000BBD
    IL_0CA3: brfalse IL_0CD4
    IL_0CA4: ldarg.0
    IL_0CA9: ldflda 0x04000BBE
    IL_0CAE: ldfld 0x0A000059
    IL_0CAF: ldarg.0
    IL_0CB4: ldflda 0x04000BBE
    IL_0CB9: ldfld 0x0A00005A
    IL_0CBA: IL_22
    IL_0CBB: nop
    IL_0CBC: nop
    IL_0CC1: stsfld 0x00002242
    IL_0CC6: stsfld 0x021D2842
    IL_0CC7: nop
    IL_0CC8: ldloc.0
    IL_0CC9: ldarg.0
    IL_0CCE: ldfld 0x04000BB6
    IL_0CD3: call 0x0A0000E0
    IL_0CD4: ldarg.0
    IL_0CD9: ldfld 0x04000BBA
    IL_0CDA: ldc.i4.1
    IL_0CDB: IL_59
    IL_0CDC: ldarg.0
    IL_0CE1: ldfld 0x04000BBB
    IL_0CE2: IL_3D
    IL_0CE3: shr.un
    IL_0CE4: nop
    IL_0CE5: nop
    IL_0CE6: nop
    IL_0CE7: IL_22
    IL_0CE8: nop
    IL_0CE9: nop
    IL_0CEA: IL_91
    IL_0CEB: IL_43
    IL_0CEC: IL_22
    IL_0CED: nop
    IL_0CEE: nop
    IL_0CF3: br IL_2F37
    IL_0CF8: stsfld 0x00002242
    IL_0CF9: nop
    IL_0CFA: IL_42
    IL_0CFF: call 0x0600021D
    IL_0D04: ldsfld 0x040007B2
    IL_0D05: ldarg.0
    IL_0D0A: ldfld 0x04000BD9
    IL_0D0B: ldc.i4.4
    IL_0D10: call 0x0A0000E1
    IL_0D11: ldarg.0
    IL_0D16: ldfld 0x04000BC4
    IL_0D1B: call 0x0A0000F1
    IL_0D20: brfalse IL_0D49
    IL_0D21: ldarg.0
    IL_0D22: ldc.i4.0
    IL_0D27: stfld 0x04000BB8
    IL_0D28: IL_22
    IL_0D29: nop
    IL_0D2A: nop
    IL_0D2F: stsfld 0x0111283F
    IL_0D30: nop
    IL_0D31: stloc.0
    IL_0D32: ldarg.0
    IL_0D37: call 0x0A00000A
    IL_0D38: ldc.i4.0
    IL_0D39: conv.r8
    IL_0D3A: stloc.1
    IL_0D3B: nop
    IL_0D3C: nop
    IL_0D3D: stloc.0
    IL_0D3E: ldarg.0
    IL_0D43: ldfld 0x04000BCE
    IL_0D44: conv.r8
    IL_0D45: conv.u4
    IL_0D46: IL_01
    IL_0D47: nop
    IL_0D48: ldloc.0
    IL_0D4D: br IL_0DA9
    IL_0D4E: IL_22
    IL_0D4F: nop
    IL_0D50: nop
    IL_0D51: IL_91
    IL_0D52: IL_43
    IL_0D53: IL_22
    IL_0D54: nop
    IL_0D55: nop
    IL_0D5A: br IL_2F9E
    IL_0D5F: stsfld 0x00002242
    IL_0D60: nop
    IL_0D61: IL_42
    IL_0D66: call 0x0600021D
    IL_0D6B: ldsfld 0x040007B2
    IL_0D6C: ldarg.0
    IL_0D71: ldfld 0x04000BD9
    IL_0D73: ldc.i4.s 47
    IL_0D78: call 0x0A0000E1
    IL_0D79: ldarg.0
    IL_0D7E: ldfld 0x04000BC4
    IL_0D83: call 0x0A0000F1
    IL_0D88: brfalse IL_0DA9
    IL_0D89: ldarg.0
    IL_0D8A: dup
    IL_0D8F: ldfld 0x04000BBB
    IL_0D90: ldc.i4.1
    IL_0D91: IL_58
    IL_0D96: stfld 0x04000BBB
    IL_0D97: ldarg.0
    IL_0D98: ldarg.0
    IL_0D9D: ldfld 0x04000BB9
    IL_0D9E: ldarg.0
    IL_0DA3: ldfld 0x04000BBB
    IL_0DA8: call 0x06000636
    IL_0DA9: ret
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: stfld 0x04000BDE
    IL_0008: ldarg.0
    IL_0009: IL_22
    IL_000A: nop
    IL_000B: nop
    IL_000C: IL_C8
    IL_000D: IL_42
    IL_0012: stfld 0x04000BE0
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0019: stfld 0x04000BE2
    IL_001A: ldarg.0
    IL_001B: ldc.i4.m1
    IL_0020: stfld 0x04000BE5
    IL_0021: ldarg.0
    IL_0022: ldc.i4.4
    IL_0027: newarr 0x0100000C
    IL_002C: stfld 0x04000BEE
    IL_002D: ldarg.0
    IL_002E: ldc.i4.4
    IL_0033: newarr 0x0100003C
    IL_0038: stfld 0x04000BEF
    IL_0039: ldarg.0
    IL_003A: ldc.i4.1
    IL_003F: stfld 0x04000BF3
    IL_0040: ldarg.0
    IL_0045: call 0x0A000001
    IL_0046: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000BFA
    IL_0010: ldarg.0
    IL_0012: ldc.i4.s 100
    IL_0017: stfld 0x04000BDE
    IL_0018: ldarg.0
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_C8
    IL_001D: IL_42
    IL_0022: stfld 0x04000BE0
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000BE7
    IL_002A: conv.r8
    IL_002B: IL_37
    IL_002C: nop
    IL_002D: nop
    IL_002F: br.s IL_00AD
    IL_0030: IL_E9
    IL_0031: stloc.1
    IL_0032: nop
    IL_0033: ldarg.2
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000BE9
    IL_003A: IL_22
    IL_003B: nop
    IL_003C: nop
    IL_0041: stsfld 0x0000223E
    IL_0046: stsfld 0x0038733E
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: IL_22
    IL_004F: IL_CD
    IL_0050: IL_CC
    IL_0051: IL_AC
    IL_0052: IL_BF
    IL_0053: IL_22
    IL_0054: shr
    IL_0055: shr
    IL_0056: IL_36
    IL_00E3: switch (34 cases)
    IL_00E4: IL_FF
    IL_00E5: ldarg.0
    IL_00E6: nop
    IL_00EB: cpobj 0x4CCCCD22
    IL_00EC: IL_3E
    IL_00ED: ldc.i4.0
    IL_00EE: conv.r8
    IL_00EF: IL_95
    IL_00F0: ldarg.1
    IL_00F1: nop
    IL_00F2: ldloc.0
    IL_00F3: stloc.0
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x04000BE9
    IL_00FA: IL_22
    IL_00FB: ldnull
    IL_00FC: IL_AE
    IL_00FD: IL_87
    IL_00FE: IL_3F
    IL_00FF: IL_22
    IL_0100: IL_CD
    IL_0101: IL_CC
    IL_0102: IL_4C
    IL_0103: IL_3D
    IL_0108: newobj 0x0A000038
    IL_0109: IL_22
    IL_010A: nop
    IL_010B: nop
    IL_010C: nop
    IL_010D: nop
    IL_010E: IL_22
    IL_010F: IL_A4
    IL_0114: cpobj 0x6622BF2D
    IL_0115: shr
    IL_0116: IL_36
    IL_3999999A3: switch (3865470498 cases)
    }

    public void ResetPower() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000BF5
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x04000BF4
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BED
    IL_001C: call 0x0A000057
    IL_001D: conv.r8
    IL_001E: IL_F3
    IL_001F: ldarg.0
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000BE8
    IL_0028: conv.r8
    IL_0029: stloc.0
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.0
    IL_002E: conv.r8
    IL_002F: stloc.1
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ret
    }

    public void PowerCharge() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000BF5
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BE8
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
    IL_0018: ret
    }

    public void GainCoin() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BE4
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000BE4
    IL_000E: ret
    }

    public void GainSoul() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BE3
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000BE3
    IL_000E: ldarg.0
    IL_000F: ldarg.0
    IL_0014: ldfld 0x04000BF8
    IL_0019: ldfld 0x040002EF
    IL_001E: stfld 0x04000BE1
    IL_001F: ldarg.0
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0xE17B023F
    IL_0028: stloc.1
    IL_0029: nop
    IL_002A: ldarg.2
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000BE2
    IL_0032: ldc.i4.s 100
    IL_0033: IL_5A
    IL_0034: conv.i2
    IL_0035: add
    IL_0036: IL_59
    IL_0037: IL_22
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_3E
    IL_003C: IL_5A
    IL_0041: stfld 0x04000BF1
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000BEC
    IL_004C: call 0x0A0000AA
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000BF1
    IL_0057: call 0x0A000083
    IL_0058: conv.r8
    IL_0059: IL_F3
    IL_005A: ldarg.0
    IL_005B: nop
    IL_005C: ldloc.0
    IL_005D: ret
    }

    public void StatUpdate() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000BDD
    IL_0007: ldarg.0
    IL_0008: ldarg.3
    IL_000D: stfld 0x04000BDF
    IL_000E: ldarg.0
    IL_000F: ldarg.2
    IL_0014: stfld 0x04000BDE
    IL_0015: IL_22
    IL_0016: nop
    IL_0017: nop
    IL_001C: stsfld 0xDD7B023F
    IL_001D: stloc.1
    IL_001E: nop
    IL_001F: ldarg.2
    IL_0020: conv.i2
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000BDE
    IL_0027: conv.i2
    IL_0028: add
    IL_0029: IL_59
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_3F
    IL_002F: IL_5A
    IL_0030: stloc.0
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000BEA
    IL_0037: ldloc.0
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_0041: newobj 0x0A000038
    IL_0042: conv.r8
    IL_0043: IL_F3
    IL_0044: ldarg.0
    IL_0045: nop
    IL_0046: ldloc.0
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004E: stsfld 0xDF7B023F
    IL_004F: stloc.1
    IL_0050: nop
    IL_0051: ldarg.2
    IL_0052: conv.i2
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000BE0
    IL_0059: conv.i2
    IL_005A: add
    IL_005B: IL_59
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_3F
    IL_0061: IL_5A
    IL_0062: stloc.1
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000BDF
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006E: ldloc 17474
    IL_006F: ldc.i4.5
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000BEB
    IL_007D: call 0x0A000082
    IL_007E: ldloc.1
    IL_0083: call 0x0A000083
    IL_0084: conv.r8
    IL_0085: IL_F3
    IL_0086: ldarg.0
    IL_0087: nop
    IL_0088: ldloc.0
    IL_008D: br IL_00B8
    IL_008E: ldarg.0
    IL_0093: ldfld 0x04000BEB
    IL_0098: call 0x0A000082
    IL_0099: ldloc.1
    IL_009E: call 0x0A000083
    IL_00A3: call 0x0A0000AA
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: IL_3D
    IL_00AD: call 0x0A000083
    IL_00B2: call 0x0A000174
    IL_00B3: conv.r8
    IL_00B4: IL_F3
    IL_00B5: ldarg.0
    IL_00B6: nop
    IL_00B7: ldloc.0
    IL_00B8: ret
    }

    public void GuideOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BF8
    IL_0006: conv.r8
    IL_000B: newobj 0x22060001
    IL_000C: nop
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0014: call 0x0A000111
    IL_0015: ldarg.0
    IL_0016: ldarg.1
    IL_001B: stfld 0x04000BE5
    IL_001C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BF5
    IL_000A: brfalse IL_0082
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000BF4
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_3F
    IL_0016: IL_41
    IL_0017: ldc.i4.7
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x04000BF4
    IL_0026: call 0x0A000024
    IL_0027: IL_22
    IL_0028: ldelem.i
    IL_0029: IL_99
    IL_002A: ldc.i4.3
    IL_002B: IL_3F
    IL_002C: IL_5A
    IL_002D: IL_58
    IL_0032: stfld 0x04000BF4
    IL_0037: br IL_0066
    IL_0038: ldarg.0
    IL_0039: IL_22
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_0042: stfld 0x04000BF4
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000BF8
    IL_0049: conv.r8
    IL_004A: ldelem.i1
    IL_004B: IL_01
    IL_004C: nop
    IL_004D: ldloc.0
    IL_004E: ldarg.0
    IL_004F: ldc.i4.0
    IL_0054: stfld 0x04000BF5
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000BE8
    IL_005B: conv.r8
    IL_005C: stloc.0
    IL_005D: nop
    IL_005E: nop
    IL_005F: stloc.0
    IL_0060: ldc.i4.0
    IL_0061: conv.r8
    IL_0062: stloc.1
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000BED
    IL_0070: call 0x0A000082
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000BF4
    IL_0077: shl
    IL_007C: call 0x0A000083
    IL_007D: conv.r8
    IL_007E: IL_F3
    IL_007F: ldarg.0
    IL_0080: nop
    IL_0081: ldloc.0
    IL_0082: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BF3
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000BF6
    IL_0016: call 0x0A0000DF
    IL_001B: call 0x0A00001B
    IL_0020: call 0x0A000013
    IL_0025: call 0x0A0000D9
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: cpobj 0xDA285B44
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: conv.i2
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_003A: ldc.i4 2251588
    IL_003B: nop
    IL_0040: stsfld 0x0076733F
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: call 0x0A0000DD
    IL_004C: call 0x0A0000DE
    IL_004D: ldc.i4.0
    IL_0052: call 0x0A0000EF
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000BE5
    IL_0059: ldc.i4.0
    IL_005A: IL_3F
    IL_005B: IL_82
    IL_005C: IL_01
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_22
    IL_0060: nop
    IL_0061: nop
    IL_0062: IL_E0
    IL_0063: IL_42
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_0067: IL_C0
    IL_0068: IL_42
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_0070: stsfld 0x00002243
    IL_0071: nop
    IL_0072: IL_43
    IL_0077: call 0x0600021D
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000BE6
    IL_0082: call 0x0A0000E0
    IL_0083: IL_22
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_F8
    IL_0087: IL_42
    IL_0088: IL_22
    IL_0089: nop
    IL_008A: nop
    IL_008F: ldtoken 0x00002242
    IL_0090: neg
    IL_0091: IL_43
    IL_0092: IL_22
    IL_0093: nop
    IL_0094: nop
    IL_0096: starg.s 66
    IL_009B: call 0x0600021D
    IL_00A0: ldsfld 0x0A000099
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000BEE
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000BE5
    IL_00AD: ldelem.i
    IL_00B2: call 0x0A000011
    IL_00B7: ldstr 0x70000C43
    IL_00BC: call 0x0A0000E2
    IL_00C1: call 0x0A0000E3
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_EC
    IL_00C6: IL_42
    IL_00C7: IL_22
    IL_00C8: nop
    IL_00C9: nop
    IL_00CC: ldloc 8771
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: conv.u4
    IL_00D0: IL_43
    IL_00D1: IL_22
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: rem
    IL_00D5: IL_41
    IL_00DA: call 0x0600021D
    IL_00DF: ldsfld 0x0A000099
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000BE5
    IL_00E6: ldc.i4.1
    IL_00E7: IL_58
    IL_00EC: newobj 0x0100000B
    IL_00F1: ldstr 0x700237E1
    IL_00F6: call 0x0A000098
    IL_00FB: ldstr 0x70000C43
    IL_0100: call 0x0A0000E2
    IL_0105: call 0x0A0000E3
    IL_0106: IL_22
    IL_0107: nop
    IL_0108: nop
    IL_0109: ret
    IL_010A: IL_43
    IL_010B: IL_22
    IL_010C: nop
    IL_010D: nop
    IL_010E: stloc.0
    IL_010F: IL_43
    IL_0110: IL_22
    IL_0111: nop
    IL_0112: nop
    IL_0113: nop
    IL_0114: IL_43
    IL_0115: IL_22
    IL_0116: nop
    IL_0117: nop
    IL_011C: stsfld 0x021D2842
    IL_011D: nop
    IL_011E: ldloc.0
    IL_011F: ldarg.0
    IL_0124: ldfld 0x04000BEF
    IL_0125: ldarg.0
    IL_012A: ldfld 0x04000BE5
    IL_012B: ldelem.i
    IL_0130: call 0x0A0000E0
    IL_0131: ldarg.0
    IL_0136: ldfld 0x04000BE5
    IL_0137: ldc.i4.3
    IL_02A8: switch (91 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: ldsfld 0x0A000099
    IL_000A: stfld 0x04000C0B
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000C00
    IL_0010: ret
    }

    private void Start() {
    IL_0004: call 0x0600021A
    IL_0009: ldstr 0x70022F71
    IL_000E: call 0x0A000095
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700237EB
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_3000000A6: switch (3221225506 cases)
    }

    private void NextScreen() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BFF
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000BFF
    IL_000E: ret
    }

    public void GetUsim() {
    IL_0000: ldarg.1
    IL_0005: call 0x0600021B
    IL_0006: ldarg.0
    IL_0007: ldc.i4.1
    IL_000C: stfld 0x04000C0C
    IL_000D: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BFE
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000BFF
    IL_0047: ldc.i4.1
    IL_0134: switch (58 cases)
    IL_0135: nop
    IL_0136: nop
    IL_0137: nop
    IL_0138: IL_22
    IL_0139: nop
    IL_013A: nop
    IL_013B: nop
    IL_013C: nop
    IL_013D: IL_22
    IL_013E: nop
    IL_013F: nop
    IL_0140: IL_F0
    IL_0141: IL_43
    IL_0142: IL_22
    IL_0143: nop
    IL_0144: nop
    IL_0145: ldelem.r8
    IL_0146: IL_43
    IL_014B: call 0x0600021D
    IL_014C: ldarg.0
    IL_0151: ldfld 0x04000C04
    IL_0156: call 0x0A0000E0
    IL_015B: br IL_024F
    IL_015C: ldarg.0
    IL_0161: ldfld 0x04000C0B
    IL_0166: ldstr 0x7002382B
    IL_016B: call 0x0A0000EC
    IL_0170: brfalse IL_019A
    IL_0171: IL_22
    IL_0172: nop
    IL_0173: nop
    IL_0174: nop
    IL_0175: nop
    IL_0176: IL_22
    IL_0177: nop
    IL_0178: nop
    IL_0179: nop
    IL_017A: nop
    IL_017B: IL_22
    IL_017C: nop
    IL_017D: nop
    IL_017E: IL_F0
    IL_017F: IL_43
    IL_0180: IL_22
    IL_0181: nop
    IL_0182: nop
    IL_0183: ldelem.r8
    IL_0184: IL_43
    IL_0189: call 0x0600021D
    IL_018A: ldarg.0
    IL_018F: ldfld 0x04000C05
    IL_0194: call 0x0A0000E0
    IL_0199: br IL_024F
    IL_019A: ldarg.0
    IL_019F: ldfld 0x04000C0B
    IL_01A4: ldstr 0x70023839
    IL_01A9: call 0x0A0000EC
    IL_01AE: brfalse IL_01D8
    IL_01AF: IL_22
    IL_01B0: nop
    IL_01B1: nop
    IL_01B2: nop
    IL_01B3: nop
    IL_01B4: IL_22
    IL_01B5: nop
    IL_01B6: nop
    IL_01B7: nop
    IL_01B8: nop
    IL_01B9: IL_22
    IL_01BA: nop
    IL_01BB: nop
    IL_01BC: IL_F0
    IL_01BD: IL_43
    IL_01BE: IL_22
    IL_01BF: nop
    IL_01C0: nop
    IL_01C1: ldelem.r8
    IL_01C2: IL_43
    IL_01C7: call 0x0600021D
    IL_01C8: ldarg.0
    IL_01CD: ldfld 0x04000C06
    IL_01D2: call 0x0A0000E0
    IL_01D7: br IL_024F
    IL_01D8: ldarg.0
    IL_01DD: ldfld 0x04000C0B
    IL_01E2: ldstr 0x70000A4B
    IL_01E7: call 0x0A0000EC
    IL_01EC: brfalse IL_0216
    IL_01ED: IL_22
    IL_01EE: nop
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: nop
    IL_01F2: IL_22
    IL_01F3: nop
    IL_01F4: nop
    IL_01F5: nop
    IL_01F6: nop
    IL_01F7: IL_22
    IL_01F8: nop
    IL_01F9: nop
    IL_01FA: IL_F0
    IL_01FB: IL_43
    IL_01FC: IL_22
    IL_01FD: nop
    IL_01FE: nop
    IL_01FF: ldelem.r8
    IL_0200: IL_43
    IL_0205: call 0x0600021D
    IL_0206: ldarg.0
    IL_020B: ldfld 0x04000C07
    IL_0210: call 0x0A0000E0
    IL_0215: br IL_024F
    IL_0216: ldarg.0
    IL_021B: ldfld 0x04000C0B
    IL_0220: ldstr 0x70023847
    IL_0225: call 0x0A0000EC
    IL_022A: brfalse IL_024F
    IL_022B: IL_22
    IL_022C: nop
    IL_022D: nop
    IL_022E: nop
    IL_022F: nop
    IL_0230: IL_22
    IL_0231: nop
    IL_0232: nop
    IL_0233: nop
    IL_0234: nop
    IL_0235: IL_22
    IL_0236: nop
    IL_0237: nop
    IL_0238: IL_F0
    IL_0239: IL_43
    IL_023A: IL_22
    IL_023B: nop
    IL_023C: nop
    IL_023D: ldelem.r8
    IL_023E: IL_43
    IL_0243: call 0x0600021D
    IL_0244: ldarg.0
    IL_0249: ldfld 0x04000C0A
    IL_024E: call 0x0A0000E0
    IL_024F: ret
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000C25
    IL_000C: ldarg.0
    IL_000E: ldc.i4.s 30
    IL_0013: newarr 0x0100003C
    IL_0018: stfld 0x04000C26
    IL_0019: ldarg.0
    IL_001B: ldc.i4.s 24
    IL_0020: newarr 0x0100003C
    IL_0025: stfld 0x04000C27
    IL_0026: ldarg.0
    IL_0027: ldc.i4.6
    IL_002C: newarr 0x0100003C
    IL_0031: stfld 0x04000C28
    IL_0032: ldarg.0
    IL_0033: ldc.i4.6
    IL_0038: newarr 0x01000013
    IL_003D: stfld 0x04000C29
    IL_003E: ldarg.0
    IL_003F: ldc.i4.m1
    IL_0044: stfld 0x04000C30
    IL_0045: ldarg.0
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: IL_3F
    IL_005E: newobj 0x0A0000C4
    IL_0063: stfld 0x04000C31
    IL_0064: ldarg.0
    IL_0069: call 0x0A000057
    IL_006E: stfld 0x04000C38
    IL_006F: ldarg.0
    IL_0074: call 0x0A000057
    IL_0079: stfld 0x04000C39
    IL_007A: ldarg.0
    IL_007B: ldc.i4.m1
    IL_0080: stfld 0x04000C43
    IL_0081: ldarg.0
    IL_0082: ldc.i4.m1
    IL_0087: stfld 0x04000C46
    IL_0088: ldarg.0
    IL_008A: ldc.i4.s 24
    IL_008F: newarr 0x0100000B
    IL_0094: stfld 0x04000C4D
    IL_0095: ldarg.0
    IL_0097: ldc.i4.s 30
    IL_009C: newarr 0x0100000B
    IL_00A1: stfld 0x04000C4E
    IL_00A2: ldarg.0
    IL_00A4: ldc.i4.s 76
    IL_00A9: newarr 0x0100000B
    IL_00AE: stfld 0x04000C4F
    IL_00AF: ldarg.0
    IL_00B1: ldc.i4.s 76
    IL_00B6: newarr 0x0100000B
    IL_00BB: stfld 0x04000C50
    IL_00BC: ldarg.0
    IL_00BE: ldc.i4.s 76
    IL_00C3: newarr 0x0100000B
    IL_00C8: stfld 0x04000C51
    IL_00C9: ldarg.0
    IL_00CB: ldc.i4.s 76
    IL_00D0: newarr 0x01000013
    IL_00D5: stfld 0x04000C52
    IL_00D6: ldarg.0
    IL_00D8: ldc.i4.s 20
    IL_00DD: newarr 0x0100000B
    IL_00E2: stfld 0x04000C55
    IL_00E3: ldarg.0
    IL_00E5: ldc.i4.s 12
    IL_00EA: newarr 0x0100000B
    IL_00EF: stfld 0x04000C56
    IL_00F0: ldarg.0
    IL_00F2: ldc.i4.s 20
    IL_00F7: newarr 0x0100000B
    IL_00FC: stfld 0x04000C57
    IL_00FD: ldarg.0
    IL_00FE: ldc.i4.2
    IL_0103: newarr 0x0100000B
    IL_0108: stfld 0x04000C58
    IL_0109: ldarg.0
    IL_010A: ldc.i4.m1
    IL_010F: stfld 0x04000C5F
    IL_0110: ldarg.0
    IL_0112: ldc.i4.s 20
    IL_0117: newarr 0x0100000B
    IL_011C: stfld 0x04000C64
    IL_011D: ldarg.0
    IL_0122: call 0x0A000001
    IL_0123: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000C44
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000C45
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000C49
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: call 0x2B000057
    IL_001B: stfld 0x04000C37
    IL_001C: ldarg.0
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_BE
    IL_0021: IL_C3
    IL_0026: stfld 0x04000C3C
    IL_0027: ldarg.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_F0
    IL_002C: IL_43
    IL_0031: stfld 0x04000C3D
    IL_0032: ldarg.0
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_AA
    IL_0037: IL_43
    IL_003C: stfld 0x04000C3E
    IL_003D: ldarg.0
    IL_0042: ldstr 0x70001FC1
    IL_0047: call 0x060003F9
    IL_004C: stfld 0x04000C4D
    IL_004D: ldarg.0
    IL_0052: ldstr 0x70001FD3
    IL_0057: call 0x060003F9
    IL_005C: stfld 0x04000C4E
    IL_005D: ldarg.0
    IL_0062: ldstr 0x70002093
    IL_0067: call 0x06000220
    IL_006C: stfld 0x04000C62
    IL_006D: ldarg.0
    IL_0072: ldstr 0x70000121
    IL_0077: call 0x0A000004
    IL_007C: stfld 0x04000C33
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000C33
    IL_0083: ldnull
    IL_0088: call 0x0A000021
    IL_008D: brfalse IL_009F
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000C33
    IL_0095: conv.r8
    IL_0096: IL_84
    IL_0097: nop
    IL_0098: nop
    IL_009A: br.s IL_0118
    IL_009B: IL_34
    IL_009C: stloc.2
    IL_009D: nop
    IL_009E: ldarg.2
    IL_009F: ldarg.0
    IL_00A0: ldarg.0
    IL_00A5: call 0x2B000085
    IL_00AA: stfld 0x04000C36
    IL_00AB: ldarg.0
    IL_00AC: ldarg.0
    IL_00B1: call 0x2B000086
    IL_00B6: stfld 0x04000C35
    IL_00B7: ldarg.0
    IL_00BC: ldstr 0x70001FDF
    IL_00C1: call 0x060003F9
    IL_00C6: stfld 0x04000C4F
    IL_00C7: ldarg.0
    IL_00CC: ldstr 0x70001FEF
    IL_00D1: call 0x060003F9
    IL_00D6: stfld 0x04000C56
    IL_00D7: ldarg.0
    IL_00DC: ldstr 0x70002001
    IL_00E1: call 0x060003F9
    IL_00E6: stfld 0x04000C57
    IL_00E7: ldarg.0
    IL_00EC: ldstr 0x70002015
    IL_00F1: call 0x060003F9
    IL_00F6: stfld 0x04000C58
    IL_00F7: ldarg.0
    IL_00FC: ldstr 0x70002031
    IL_0101: call 0x06000220
    IL_0106: stfld 0x04000C59
    IL_0107: ldarg.0
    IL_010C: ldstr 0x70002045
    IL_0111: call 0x06000220
    IL_0116: stfld 0x04000C5A
    IL_0117: ldarg.0
    IL_011C: ldstr 0x70000EC9
    IL_0121: call 0x06000220
    IL_0126: stfld 0x04000C5B
    IL_0127: ldarg.0
    IL_012C: ldstr 0x70002059
    IL_0131: call 0x06000220
    IL_0136: stfld 0x04000C5C
    IL_0137: ldarg.0
    IL_013C: ldstr 0x700015BF
    IL_0141: call 0x06000220
    IL_0146: stfld 0x04000C5D
    IL_0147: ldarg.0
    IL_014C: ldstr 0x700004DD
    IL_0151: call 0x06000220
    IL_0156: stfld 0x04000C5F
    IL_0157: ldarg.0
    IL_015C: ldstr 0x70001EE5
    IL_0161: call 0x060003F9
    IL_0166: stfld 0x04000C55
    IL_0167: ldarg.0
    IL_016C: ldstr 0x700020A5
    IL_0171: call 0x06000220
    IL_0176: stfld 0x04000C5E
    IL_0177: ldarg.0
    IL_017C: ldstr 0x70001F55
    IL_0181: call 0x06000220
    IL_0186: stfld 0x04000C63
    IL_0187: ldarg.0
    IL_018C: ldstr 0x7000054F
    IL_0191: call 0x060003F9
    IL_0196: stfld 0x04000C64
    IL_0197: ldarg.0
    IL_019C: ldstr 0x70001F71
    IL_01A1: call 0x06000220
    IL_01A6: stfld 0x04000C65
    IL_01A7: ldarg.0
    IL_01AC: ldstr 0x70001F83
    IL_01B1: call 0x06000220
    IL_01B6: stfld 0x04000C66
    IL_01B7: ldc.i4.0
    IL_01B8: stloc.0
    IL_01BD: br IL_0AD3
    IL_01BE: ldarg.0
    IL_01C3: ldfld 0x04000C4F
    IL_01C4: ldloc.0
    IL_01C5: IL_94
    IL_01CA: brtrue IL_0ACF
    IL_01CB: ldarg.0
    IL_01CC: dup
    IL_01D1: ldfld 0x04000C60
    IL_01D2: ldc.i4.1
    IL_01D3: IL_58
    IL_01D8: stfld 0x04000C60
    IL_01D9: ldarg.0
    IL_01DE: ldfld 0x04000C37
    IL_01E3: ldfld 0x0400049F
    IL_01E4: ldloc.0
    IL_01E5: IL_8F
    IL_01E6: IL_57
    IL_01E7: nop
    IL_01E8: nop
    IL_01E9: ldarg.0
    IL_01EE: ldfld 0x0400049C
    IL_01F0: stloc.s 10
    IL_01F2: ldloc.s 10
    IL_01F3: ldc.i4.1
    IL_01F4: IL_59
    IL_01F7: ldarg 20
    IL_01F8: nop
    IL_01F9: nop
    IL_01FA: ldarg.3
    IL_01FB: nop
    IL_01FC: nop
    IL_01FD: nop
    IL_01FE: conv.r4
    IL_01FF: nop
    IL_0200: nop
    IL_0201: nop
    IL_0202: IL_D7
    IL_0203: nop
    IL_0204: nop
    IL_0205: nop
    IL_2A400020E: switch (2835349505 cases)
    }

    public void FindNewTreasure() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0008: br IL_0085
    IL_0009: ldc.i4.0
    IL_000A: stloc.2
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000C4D
    IL_0011: ldc.i4.4
    IL_0012: ldloc.1
    IL_0013: IL_5A
    IL_0014: IL_94
    IL_0015: ldc.i4.0
    IL_0016: IL_3E
    IL_0017: ldarg.2
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldloc.2
    IL_001C: ldc.i4.1
    IL_001D: IL_58
    IL_001E: stloc.2
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000C4D
    IL_0025: ldc.i4.4
    IL_0026: ldloc.1
    IL_0027: IL_5A
    IL_0028: ldc.i4.1
    IL_0029: IL_58
    IL_002A: IL_94
    IL_002B: ldc.i4.0
    IL_002C: IL_3E
    IL_002D: ldarg.2
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0031: ldloc.2
    IL_0032: ldc.i4.1
    IL_0033: IL_58
    IL_0034: stloc.2
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000C4D
    IL_003B: ldc.i4.4
    IL_003C: ldloc.1
    IL_003D: IL_5A
    IL_003E: ldc.i4.2
    IL_003F: IL_58
    IL_0040: IL_94
    IL_0041: ldc.i4.0
    IL_0042: IL_3E
    IL_0043: ldarg.2
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: ldloc.2
    IL_0048: ldc.i4.1
    IL_0049: IL_58
    IL_004A: stloc.2
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000C4D
    IL_0051: ldc.i4.4
    IL_0052: ldloc.1
    IL_0053: IL_5A
    IL_0054: ldc.i4.3
    IL_0055: IL_58
    IL_0056: IL_94
    IL_0057: ldc.i4.0
    IL_0058: IL_3E
    IL_0059: ldarg.2
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: ldloc.2
    IL_005E: ldc.i4.1
    IL_005F: IL_58
    IL_0060: stloc.2
    IL_0061: ldloc.2
    IL_0062: ldc.i4.4
    IL_00A7: switch (16 cases)
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000C61
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000C61
    IL_0010: ret
    }

    public void IsWarning() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_001A
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000C52
    IL_000D: ldloc.0
    IL_000E: IL_91
    IL_0013: brfalse IL_0016
    IL_0014: ldc.i4.1
    IL_0015: ret
    IL_0016: ldloc.0
    IL_0017: ldc.i4.1
    IL_0018: IL_58
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001C: ldc.i4.s 76
    IL_001D: IL_3F
    IL_001E: IL_E5
    IL_001F: IL_FF
    IL_0020: IL_FF
    IL_0021: IL_FF
    IL_0022: ldc.i4.0
    IL_0023: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000C40
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000C41
    IL_000E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000C40
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000C41
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000C41
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000C41
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
    IL_0033: stfld 0x04000C40
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000C41
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000C3F
    IL_0049: brtrue IL_0111
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000C3C
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x002941C2
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000C3C
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000C3C
    IL_0067: shl
    IL_006C: call 0x0A000024
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0070: ldc.i4.0
    IL_0071: IL_44
    IL_0072: IL_5A
    IL_0077: call 0x0A000114
    IL_0078: IL_58
    IL_007D: stfld 0x04000C3C
    IL_0082: br IL_0111
    IL_0083: ldarg.0
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_008B: stsfld 0x0C3C7DC2
    IL_008C: nop
    IL_008D: ldarg.2
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000C3D
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000C3D
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00B0: stfld 0x04000C3D
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000C3D
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: IL_42
    IL_00BD: IL_50
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: nop
    IL_00CB: stfld 0x04000C3D
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000C3E
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000C3E
    IL_00DD: call 0x0A000024
    IL_00DE: IL_22
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_FA
    IL_00E2: IL_43
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000114
    IL_00E9: IL_59
    IL_00EE: stfld 0x04000C3E
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000C3E
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: shr
    IL_00F9: IL_43
    IL_00FA: IL_42
    IL_00FC: ldloca.s 0
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: ldarg.0
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: shr
    IL_0104: IL_43
    IL_0109: stfld 0x04000C3E
    IL_010A: ldarg.0
    IL_010B: ldc.i4.1
    IL_0110: stfld 0x04000C3F
    IL_0115: ldstr 0x7000064F
    IL_011A: call 0x0A000095
    IL_011B: stloc.0
    IL_011C: ldloc.0
    IL_011D: ldc.i4.1
    IL_01CE: switch (43 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000C32
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000C32
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000C32
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
    }

    public void sortAchieve() {
    IL_0001: ldc.i4.s 76
    IL_0006: newarr 0x0100000B
    IL_0007: stloc.0
    IL_000C: newobj 0x0A00030B
    IL_000D: stloc.1
    IL_0012: newobj 0x0A00030B
    IL_0013: stloc.2
    IL_0018: newobj 0x0A00030B
    IL_0019: stloc.3
    IL_001A: ldc.i4.0
    IL_001C: stloc.s 4
    IL_0021: br IL_0067
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000C52
    IL_0029: ldloc.s 4
    IL_002A: IL_91
    IL_002F: brfalse IL_003D
    IL_0030: ldloc.1
    IL_0032: ldloc.s 4
    IL_0033: conv.r8
    IL_0034: stloc.2
    IL_0035: ldarg.1
    IL_0036: nop
    IL_0037: stloc.0
    IL_003C: br IL_0061
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000C4F
    IL_0044: ldloc.s 4
    IL_0045: IL_94
    IL_0046: ldc.i4.1
    IL_007F: switch (13 cases)
    IL_0081: ldarg.s 3
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldloc.3
    IL_0085: conv.r8
    IL_0087: ldarg.s 3
    IL_0088: nop
    IL_0089: stloc.0
    IL_008A: ldarg.0
    IL_008B: ldloc.1
    IL_008C: conv.r8
    IL_008E: ldarga.s 3
    IL_008F: nop
    IL_0090: stloc.0
    IL_0095: stfld 0x04000C50
    IL_0096: ldloc.1
    IL_0097: conv.r8
    IL_0099: ldarg.s 3
    IL_009A: nop
    IL_009B: stloc.0
    IL_009C: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000C2F
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000C42
    IL_0047: ldc.i4.0
    IL_0048: IL_3E
    IL_0049: ldloc.0
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldc.i4.0
    IL_0052: call 0x0A0001B9
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000C3C
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_22
    IL_005F: nop
    IL_0060: nop
    IL_0061: ldelem.r8
    IL_0062: IL_43
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: ldelem.r8
    IL_0067: IL_43
    IL_006C: call 0x0600021D
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000C12
    IL_0077: call 0x0A0000E0
    IL_0078: IL_22
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_F0
    IL_007C: IL_42
    IL_007D: IL_22
    IL_007E: nop
    IL_007F: nop
    IL_0080: IL_F0
    IL_0081: IL_41
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0085: IL_C8
    IL_0086: IL_42
    IL_0087: IL_22
    IL_0088: nop
    IL_0089: nop
    IL_008C: ldloc 10306
    IL_008D: ldc.i4.7
    IL_008E: ldarg.0
    IL_008F: nop
    IL_0090: ldloc.0
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000C13
    IL_009B: call 0x0A0000E0
    IL_009C: IL_22
    IL_009D: nop
    IL_009E: nop
    IL_009F: IL_58
    IL_00A0: IL_43
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: IL_50
    IL_00A5: IL_42
    IL_00A6: IL_22
    IL_00A7: nop
    IL_00A8: nop
    IL_00A9: ldelem.r8
    IL_00AA: IL_42
    IL_00AB: IL_22
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: IL_C0
    IL_00AF: IL_41
    IL_00B4: call 0x0600021D
    IL_00B9: ldsfld 0x040007B2
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000C49
    IL_00C4: ldc.i4 195
    IL_00C9: call 0x0A0000E1
    IL_00CE: call 0x0A0002EA
    IL_00CF: IL_22
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: IL_E0
    IL_00D3: IL_42
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00E0: stsfld 0x00002243
    IL_00E1: nop
    IL_00E2: IL_42
    IL_00E7: call 0x0600021D
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x04000C1D
    IL_00F2: call 0x0A0000E0
    IL_00F3: IL_22
    IL_00F4: nop
    IL_00F5: nop
    IL_00F7: ldloca.s 67
    IL_00F8: IL_22
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: IL_C0
    IL_280000188: switch (2684354594 cases)
    }

    public UI_Friends() {
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

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000CED
    IL_000C: ldarg.0
    IL_000D: ldc.i4.5
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000CEE
    IL_0018: ldarg.0
    IL_0019: ldc.i4.4
    IL_001E: newarr 0x0100003C
    IL_0023: stfld 0x04000CF1
    IL_0024: ldarg.0
    IL_0026: ldc.i4.s 17
    IL_002B: newarr 0x0100003C
    IL_0030: stfld 0x04000CF9
    IL_0031: ldarg.0
    IL_0033: ldc.i4.s 35
    IL_0038: newarr 0x0100003C
    IL_003D: stfld 0x04000CFA
    IL_003E: ldarg.0
    IL_003F: ldc.i4.6
    IL_0044: newarr 0x0100000B
    IL_0049: stfld 0x04000CFB
    IL_004A: ldarg.0
    IL_004B: ldc.i4.6
    IL_0050: newarr 0x0100000B
    IL_0055: stfld 0x04000CFC
    IL_0056: ldarg.0
    IL_0057: ldc.i4.6
    IL_005C: newarr 0x01000010
    IL_0061: stfld 0x04000CFD
    IL_0062: ldarg.0
    IL_0063: ldc.i4.2
    IL_0068: newarr 0x0100003C
    IL_006D: stfld 0x04000CFE
    IL_006E: ldarg.0
    IL_006F: IL_22
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_22
    IL_0075: nop
    IL_0076: nop
    IL_0077: nop
    IL_0078: nop
    IL_0079: IL_22
    IL_007A: nop
    IL_007B: nop
    IL_007C: nop
    IL_007D: nop
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0082: IL_3F
    IL_0087: newobj 0x0A0000C4
    IL_008C: stfld 0x04000D0F
    IL_008D: ldarg.0
    IL_008E: IL_22
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_93
    IL_0092: IL_43
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_A4
    IL_0097: IL_42
    IL_009C: newobj 0x0A000038
    IL_00A1: stfld 0x04000D2F
    IL_00A2: ldarg.0
    IL_00A3: IL_22
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: ldelem.i1
    IL_00A7: IL_43
    IL_00A8: IL_22
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: IL_C0
    IL_00AC: IL_42
    IL_00B1: newobj 0x0A000038
    IL_00B6: stfld 0x04000D30
    IL_00B7: ldarg.0
    IL_00B9: ldc.i4.s 20
    IL_00BE: newarr 0x0100000B
    IL_00C3: stfld 0x04000D4C
    IL_00C4: ldarg.0
    IL_00C6: ldc.i4.s 20
    IL_00CB: newarr 0x0100000B
    IL_00D0: stfld 0x04000D4D
    IL_00D1: ldarg.0
    IL_00D3: ldc.i4.s 16
    IL_00D8: newarr 0x0100000B
    IL_00D9: dup
    IL_00DE: ldtoken 0x040010CB
    IL_00E3: call 0x0A00018C
    IL_00E8: stfld 0x04000D4E
    IL_00E9: ldarg.0
    IL_00EB: ldc.i4.s 10
    IL_00F0: newarr 0x0100000B
    IL_00F1: dup
    IL_00F6: ldtoken 0x040010CC
    IL_00FB: call 0x0A00018C
    IL_0100: stfld 0x04000D4F
    IL_0101: ldarg.0
    IL_0103: ldc.i4.s 10
    IL_0108: newarr 0x0100000B
    IL_0109: dup
    IL_010E: ldtoken 0x040010CD
    IL_0113: call 0x0A00018C
    IL_0118: stfld 0x04000D50
    IL_0119: ldarg.0
    IL_011B: ldc.i4.s 26
    IL_0120: newarr 0x0100000B
    IL_0125: stfld 0x04000D51
    IL_0126: ldarg.0
    IL_0128: ldc.i4.s 26
    IL_012D: newarr 0x0100000B
    IL_0132: stfld 0x04000D52
    IL_0133: ldarg.0
    IL_0135: ldc.i4.s 26
    IL_013A: newarr 0x0100000B
    IL_013F: stfld 0x04000D53
    IL_0140: ldarg.0
    IL_0141: ldc.i4.5
    IL_0146: newarr 0x0100000B
    IL_014B: stfld 0x04000D54
    IL_014C: ldarg.0
    IL_0151: call 0x0A000001
    IL_0152: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x04000D08
    IL_0015: ldarg.0
    IL_001A: ldstr 0x70001FB1
    IL_001F: call 0x060003F9
    IL_0024: stfld 0x04000D51
    IL_0025: ldarg.0
    IL_002A: ldstr 0x70001563
    IL_002F: call 0x060003F9
    IL_0034: stfld 0x04000D52
    IL_0035: ldarg.0
    IL_003A: ldstr 0x70000DDD
    IL_003F: call 0x06000220
    IL_0044: stfld 0x04000D21
    IL_0045: ldarg.0
    IL_0046: ldarg.0
    IL_004B: ldfld 0x04000D0B
    IL_004C: conv.r8
    IL_004D: IL_88
    IL_004E: nop
    IL_004F: nop
    IL_0051: br.s IL_00CF
    IL_0053: ldloca.s 13
    IL_0054: nop
    IL_0055: ldarg.2
    IL_0056: ldarg.0
    IL_0057: ldarg.0
    IL_005C: call 0x2B000053
    IL_0061: stfld 0x04000D56
    IL_0062: ldarg.0
    IL_0063: ldarg.0
    IL_0068: call 0x2B000052
    IL_006D: stfld 0x04000D17
    IL_006E: ldarg.0
    IL_006F: ldarg.0
    IL_0074: ldfld 0x04000D08
    IL_0075: conv.r8
    IL_0077: blt.s IL_0078
    IL_0078: nop
    IL_007A: br.s IL_00F8
    IL_007C: starg.s 13
    IL_007D: nop
    IL_007E: ldarg.2
    IL_007F: ldarg.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000D0A
    IL_0086: conv.r8
    IL_0087: pop
    IL_0088: nop
    IL_0089: nop
    IL_008B: br.s IL_0109
    IL_008D: ldloc.s 13
    IL_008E: nop
    IL_008F: ldarg.2
    IL_0090: ldarg.0
    IL_0095: ldstr 0x70001EB5
    IL_009A: call 0x06000220
    IL_009F: stfld 0x04000D34
    IL_00A0: ldarg.0
    IL_00A5: ldstr 0x70001EBD
    IL_00AA: call 0x06000220
    IL_00AF: stfld 0x04000D35
    IL_00B0: ldarg.0
    IL_00B5: ldstr 0x70000BB3
    IL_00BA: call 0x0A000095
    IL_00BF: stfld 0x04000D31
    IL_00C0: ldarg.0
    IL_00C5: ldstr 0x70001FB9
    IL_00CA: call 0x060003F9
    IL_00CF: stfld 0x04000D53
    IL_00D0: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000D24
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000D25
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000667
    IL_002A: call 0x060003F9
    IL_002F: stfld 0x04000D54
    IL_0030: ldarg.0
    IL_0035: ldstr 0x70001EE5
    IL_003A: call 0x060003F9
    IL_003F: stfld 0x04000D4C
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70001EED
    IL_004A: call 0x060003F9
    IL_004F: stfld 0x04000D4D
    IL_0050: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70002093
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000D5B
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000D5B
    IL_0016: ldc.i4.3
    IL_006F: switch (21 cases)
    IL_0070: IL_94
    IL_0075: call 0x06000668
    IL_0076: ldarg.0
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000D52
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000D1E
    IL_0083: IL_94
    IL_0088: call 0x06000669
    IL_0089: ldarg.0
    IL_008A: ldarg.0
    IL_008F: ldfld 0x04000D3B
    IL_0094: stfld 0x04000D4A
    IL_0095: ldarg.0
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000D3C
    IL_00A0: stfld 0x04000D4B
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000D11
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000D3B
    IL_00AD: ldarg.0
    IL_00B2: ldfld 0x04000D3C
    IL_00B3: conv.r8
    IL_00B4: IL_E8
    IL_00B5: IL_01
    IL_00B6: nop
    IL_00B7: ldloc.0
    IL_00B8: ldarg.0
    IL_00BD: call 0x0A0000DA
    IL_00BE: conv.i2
    IL_00BF: IL_22
    IL_00C0: nop
    IL_00C1: nop
    IL_00C2: IL_C0
    IL_00C3: IL_3E
    IL_00C4: IL_5A
    IL_00C9: stfld 0x04000D38
    IL_00CA: ldarg.0
    IL_00CF: ldc.i4 -380
    IL_00D4: stfld 0x04000D18
    IL_00D5: ldarg.0
    IL_00DA: ldc.i4 480
    IL_00DF: stfld 0x04000D19
    IL_00E0: ldarg.0
    IL_00E5: ldc.i4 320
    IL_00EA: stfld 0x04000D1A
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x04000D08
    IL_00F1: conv.r8
    IL_00F2: ret
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: stloc.0
    IL_00FA: ldstr 0x70001805
    IL_00FB: conv.r8
    IL_00FC: IL_3C
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: stloc.0
    IL_0100: pop
    IL_0105: ldstr 0x70000121
    IL_010A: call 0x0A000004
    IL_010B: ldnull
    IL_0110: call 0x0A000061
    IL_0115: brfalse IL_013B
    IL_0116: ldarg.0
    IL_0117: ldarg.0
    IL_011C: ldfld 0x04000D15
    IL_0121: call 0x0A00001B
    IL_0126: call 0x0A000013
    IL_012B: call 0x0A000014
    IL_012C: conv.u4
    IL_012D: ldarg.1
    IL_012E: nop
    IL_012F: nop
    IL_0130: IL_01
    IL_0135: stfld 0x04000D14
    IL_013A: br IL_0150
    IL_013B: ldarg.0
    IL_0140: ldstr 0x70000121
    IL_0145: call 0x0A000004
    IL_0146: conv.r8
    IL_0147: ldarg.3
    IL_0148: nop
    IL_0149: nop
    IL_014A: stloc.0
    IL_014F: stfld 0x04000D14
    IL_0150: ldarg.0
    IL_0155: ldfld 0x04000D14
    IL_0156: ldnull
    IL_015B: call 0x0A000021
    IL_0160: brfalse IL_0172
    IL_0161: ldarg.0
    IL_0162: ldarg.0
    IL_0167: ldfld 0x04000D14
    IL_0168: conv.r8
    IL_016D: ldsfld 0x7D2B0000
    IL_016E: ldc.i4.0
    IL_016F: stloc.3
    IL_0170: nop
    IL_0171: ldarg.2
    IL_0172: ldc.i4.0
    IL_0173: stloc.0
    IL_0178: br IL_01B5
    IL_0179: ldarg.0
    IL_017E: ldfld 0x04000CFB
    IL_017F: ldloc.0
    IL_0180: ldarg.0
    IL_0185: ldfld 0x04000D56
    IL_0186: ldarg.0
    IL_018B: ldfld 0x04000D51
    IL_018C: ldloc.0
    IL_018D: IL_94
    IL_018E: conv.r8
    IL_018F: IL_FB
    IL_0190: ldloc.0
    IL_0191: nop
    IL_0192: ldloc.0
    IL_0193: ldelem.i8
    IL_0194: ldarg.0
    IL_0199: ldfld 0x04000CFD
    IL_019A: ldloc.0
    IL_019B: ldarg.0
    IL_01A0: ldfld 0x04000D51
    IL_01A1: ldloc.0
    IL_01A2: IL_94
    IL_01A7: ldc.i4 100000
    IL_01A8: mul
    IL_01AD: ldc.i4 10000
    IL_01AE: add
    IL_01AF: neg
    IL_01B0: ldelem.i4
    IL_01B1: ldloc.0
    IL_01B2: ldc.i4.1
    IL_01B3: IL_58
    IL_01B4: stloc.0
    IL_01B5: ldloc.0
    IL_01B6: ldarg.0
    IL_01BB: ldfld 0x04000D34
    IL_01BC: IL_3F
    IL_01BD: IL_B8
    IL_01BE: IL_FF
    IL_01BF: IL_FF
    IL_01C0: IL_FF
    IL_01C1: ldc.i4.0
    IL_01C2: stloc.1
    IL_01C7: br IL_01DF
    IL_01C8: ldarg.0
    IL_01CD: ldfld 0x04000CFC
    IL_01CE: ldloc.1
    IL_01CF: ldarg.0
    IL_01D4: ldfld 0x04000D52
    IL_01D5: ldloc.1
    IL_01D6: IL_94
    IL_01D8: ldc.i4.s 100
    IL_01D9: mul
    IL_01DA: ldelem.i8
    IL_01DB: ldloc.1
    IL_01DC: ldc.i4.1
    IL_01DD: IL_58
    IL_01DE: stloc.1
    IL_01DF: ldloc.1
    IL_01E0: ldarg.0
    IL_01E5: ldfld 0x04000D35
    IL_01E6: IL_3F
    IL_01E7: IL_DD
    IL_01E8: IL_FF
    IL_01E9: IL_FF
    IL_01EA: IL_FF
    IL_01EB: ldarg.0
    IL_01F0: ldfld 0x04000D09
    IL_01F5: call 0x0A00001B
    IL_01F6: conv.r8
    IL_01F7: IL_AF
    IL_01F8: nop
    IL_01F9: nop
    IL_01FA: stloc.0
    IL_01FF: ldstr 0x70000617
    IL_0200: ldc.i4.6
    IL_0205: call 0x0A00009F
    IL_0206: ret
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000D5C
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000D5C
    IL_0010: ret
    }

    public void Cost_upgrade() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D5B
    IL_0006: ldc.i4.3
    IL_000B: beq IL_0046
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000D39
    IL_0014: ldc.i4.s 12
    IL_0015: IL_5A
    IL_0016: ldc.i4.7
    IL_0017: IL_58
    IL_0018: conv.i2
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: IL_3F
    IL_001E: IL_5A
    IL_001F: IL_22
    IL_0020: IL_CD
    IL_0021: IL_CC
    IL_0022: IL_CC
    IL_0023: IL_3E
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000D57
    IL_002A: ldc.i4.1
    IL_002B: IL_58
    IL_002C: conv.i2
    IL_002D: IL_5A
    IL_002E: IL_22
    IL_002F: ldelem.i
    IL_0030: IL_99
    IL_0031: ldc.i4.3
    IL_0032: IL_3F
    IL_0033: IL_58
    IL_0034: IL_5A
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: IL_50
    IL_0039: IL_41
    IL_003A: IL_5A
    IL_003B: not
    IL_0040: stfld 0x04000D55
    IL_0045: br IL_004D
    IL_0046: ldarg.0
    IL_0047: ldc.i4.0
    IL_004C: stfld 0x04000D55
    IL_004D: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000D36
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000D37
    IL_000E: ret
    }

    public void SetUpWeapon() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D56
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_FD
    IL_0009: ldloc.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000D56
    IL_0017: ldfld 0x04000FEC
    IL_001C: stfld 0x04000D39
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000D56
    IL_0028: ldfld 0x04000FF7
    IL_002D: stfld 0x04000D3A
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000D56
    IL_0039: ldfld 0x04000FED
    IL_003E: stfld 0x04000D3B
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000D56
    IL_004A: ldfld 0x04000FEE
    IL_004F: stfld 0x04000D3C
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000D56
    IL_005B: ldfld 0x04000FF4
    IL_0060: stfld 0x04000D3D
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000D56
    IL_006C: ldfld 0x04000FEF
    IL_0071: stfld 0x04000D3E
    IL_0072: ldarg.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000D56
    IL_007D: ldfld 0x04000FF0
    IL_007E: ldarg.0
    IL_0083: ldfld 0x04000D53
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000D1F
    IL_008A: IL_94
    IL_008B: IL_58
    IL_0090: stfld 0x04000D3F
    IL_0091: ldarg.0
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000D56
    IL_009C: ldfld 0x04000FF1
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x04000D53
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04000D1F
    IL_00A9: IL_94
    IL_00AA: IL_58
    IL_00AF: stfld 0x04000D40
    IL_00B0: ldarg.0
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000D56
    IL_00BB: ldfld 0x04000FF2
    IL_00C0: stfld 0x04000D41
    IL_00C1: ldarg.0
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x04000D56
    IL_00CC: ldfld 0x04000FF3
    IL_00D1: stfld 0x04000D42
    IL_00D2: ldarg.0
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000D56
    IL_00DD: ldfld 0x04000FF6
    IL_00E2: stfld 0x04000D43
    IL_00E3: ldarg.0
    IL_00E4: ldarg.0
    IL_00E9: ldfld 0x04000D56
    IL_00EE: ldfld 0x04000FF5
    IL_00F3: stfld 0x04000D44
    IL_00F4: ldarg.0
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x04000D3D
    IL_00FB: ldc.i4.2
    IL_00FC: IL_58
    IL_00FD: ldc.i4.6
    IL_0102: call 0x0A00010B
    IL_0107: stfld 0x04000D45
    IL_0108: ret
    }

    public void SetUpArmor() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0003: ldc.i4.s 100
    IL_0004: mul
    IL_0009: stfld 0x04000D47
    IL_000A: ldarg.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000D4E
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000D1D
    IL_0017: IL_94
    IL_001C: stfld 0x04000D46
    IL_001D: ldarg.1
    IL_001F: ldc.i4.s 100
    IL_0020: add
    IL_0022: starg.s 1
    IL_0023: ldc.i4.2
    IL_0028: newarr 0x0100000B
    IL_0029: stloc.0
    IL_002A: ldc.i4.0
    IL_002B: stloc.1
    IL_0030: br IL_0042
    IL_0031: ldloc.0
    IL_0032: ldloc.1
    IL_0033: ldarg.1
    IL_0035: ldc.i4.s 10
    IL_0036: mul
    IL_0037: ldelem.i8
    IL_0038: ldarg.1
    IL_003A: ldc.i4.s 10
    IL_003B: add
    IL_003D: starg.s 1
    IL_003E: ldloc.1
    IL_003F: ldc.i4.1
    IL_0040: IL_58
    IL_0041: stloc.1
    IL_0042: ldloc.1
    IL_0043: ldc.i4.2
    IL_0044: IL_3F
    IL_0045: IL_E8
    IL_0046: IL_FF
    IL_0047: IL_FF
    IL_0048: IL_FF
    IL_0049: ldarg.0
    IL_004A: ldloc.0
    IL_004B: ldc.i4.1
    IL_004C: IL_94
    IL_0051: stfld 0x04000D48
    IL_0052: ldarg.0
    IL_0053: ldarg.1
    IL_0058: stfld 0x04000D49
    IL_0059: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D2C
    IL_000A: brtrue IL_00CD
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000D18
    IL_0012: ldc.i4.s -64
    IL_0013: IL_3C
    IL_0015: brfalse.s IL_0016
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000D18
    IL_001F: conv.i2
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000D18
    IL_0026: shl
    IL_0027: conv.i2
    IL_002C: call 0x0A000024
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_0030: ldc.i4.0
    IL_0031: IL_44
    IL_0032: IL_5A
    IL_0037: call 0x0A000114
    IL_0038: IL_58
    IL_0039: not
    IL_003E: stfld 0x04000D18
    IL_0043: br IL_00CD
    IL_0044: ldarg.0
    IL_0046: ldc.i4.s -64
    IL_004B: stfld 0x04000D18
    IL_004C: ldarg.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000D19
    IL_0053: conv.i2
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000D19
    IL_005A: conv.i2
    IL_005F: call 0x0A000024
    IL_0060: IL_22
    IL_0061: nop
    IL_0066: stsfld 0x285A44BB
    IL_0067: ldnull
    IL_0068: IL_01
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: IL_59
    IL_006C: not
    IL_0071: stfld 0x04000D19
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04000D19
    IL_0078: ldc.i4.0
    IL_0079: IL_3D
    IL_007A: IL_4F
    IL_007B: nop
    IL_007C: nop
    IL_007D: nop
    IL_007E: ldarg.0
    IL_007F: ldc.i4.0
    IL_0084: stfld 0x04000D19
    IL_0085: ldarg.0
    IL_0086: ldarg.0
    IL_008B: ldfld 0x04000D1A
    IL_008C: conv.i2
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000D1A
    IL_0093: conv.i2
    IL_0098: call 0x0A000024
    IL_0099: IL_22
    IL_009A: nop
    IL_009B: nop
    IL_009C: IL_FA
    IL_009D: IL_43
    IL_009E: IL_5A
    IL_00A3: call 0x0A000114
    IL_00A4: IL_59
    IL_00A5: not
    IL_00AA: stfld 0x04000D1A
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x04000D1A
    IL_00B5: ldc.i4 240
    IL_00B6: IL_3D
    IL_00B8: ldloca.s 0
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: ldarg.0
    IL_00C0: ldc.i4 240
    IL_00C5: stfld 0x04000D1A
    IL_00C6: ldarg.0
    IL_00C7: ldc.i4.1
    IL_00CC: stfld 0x04000D2C
    IL_00CD: ldc.i4.0
    IL_00D2: call 0x0A0000D6
    IL_00D7: brfalse IL_011B
    IL_00DC: call 0x0A0000D7
    IL_00DD: stloc.1
    IL_00DF: ldloca.s 1
    IL_00E4: ldfld 0x0A000023
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x04000D38
    IL_00EB: IL_41
    IL_00EC: pop
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: ldarg.0
    IL_00F1: ldc.i4.1
    IL_00F6: stfld 0x04000D27
    IL_00F7: ldarg.0
    IL_00FC: call 0x0A0000D7
    IL_00FD: stloc.2
    IL_00FF: ldloca.s 2
    IL_0104: ldfld 0x0A00005E
    IL_0109: stfld 0x04000D2A
    IL_010A: ldarg.0
    IL_010B: ldarg.0
    IL_0110: ldfld 0x04000D29
    IL_0115: stfld 0x04000D2B
    IL_011A: br IL_0134
    IL_011B: ldc.i4.0
    IL_0120: call 0x0A0000D8
    IL_0125: brfalse IL_0134
    IL_0126: ldarg.0
    IL_0127: ldc.i4.0
    IL_012C: stfld 0x04000D27
    IL_012D: ldarg.0
    IL_012E: ldc.i4.0
    IL_0133: stfld 0x04000D28
    IL_0134: ldarg.0
    IL_0139: ldfld 0x04000D27
    IL_013E: brfalse IL_01C4
    IL_0143: call 0x0A0000D7
    IL_0144: stloc.3
    IL_0146: ldloca.s 3
    IL_014B: ldfld 0x0A00005E
    IL_014C: ldarg.0
    IL_0151: ldfld 0x04000D2A
    IL_0152: IL_59
    IL_0157: call 0x0A00007F
    IL_0158: IL_22
    IL_0159: nop
    IL_015A: nop
    IL_015B: nop
    IL_015C: IL_41
    IL_015D: IL_43
    IL_015E: ldloc.1
    IL_015F: nop
    IL_0160: nop
    IL_0161: nop
    IL_0162: ldarg.0
    IL_0163: ldc.i4.1
    IL_0168: stfld 0x04000D28
    IL_0169: ldarg.0
    IL_016E: call 0x0A0000D7
    IL_0170: stloc.s 4
    IL_0172: ldloca.s 4
    IL_0177: ldfld 0x0A00005E
    IL_0178: ldarg.0
    IL_017D: ldfld 0x04000D2A
    IL_017E: IL_59
    IL_017F: IL_22
    IL_0180: nop
    IL_0181: nop
    IL_0182: IL_F0
    IL_0183: IL_43
    IL_0188: call 0x0A0000D9
    IL_0189: conv.i2
    IL_018A: add
    IL_018B: IL_5A
    IL_018C: ldarg.0
    IL_0191: ldfld 0x04000D2B
    IL_0192: IL_58
    IL_0197: stfld 0x04000D29
    IL_0198: ldarg.0
    IL_0199: ldarg.0
    IL_019E: ldfld 0x04000D29
    IL_019F: IL_22
    IL_01A0: nop
    IL_01A1: nop
    IL_01A2: nop
    IL_01A3: nop
    IL_01A8: call 0x0A000114
    IL_01AD: stfld 0x04000D29
    IL_01AE: ldarg.0
    IL_01AF: ldarg.0
    IL_01B4: ldfld 0x04000D29
    IL_01B5: IL_22
    IL_01B6: nop
    IL_01B7: nop
    IL_01B8: IL_96
    IL_01B9: IL_C3
    IL_01BE: call 0x0A00019C
    IL_01C3: stfld 0x04000D29
    IL_01C4: ldarg.0
    IL_01C9: ldfld 0x04000D36
    IL_01CE: brfalse IL_0203
    IL_01CF: ldarg.0
    IL_01D0: dup
    IL_01D5: ldfld 0x04000D37
    IL_01DA: call 0x0A000024
    IL_01DB: IL_59
    IL_01E0: stfld 0x04000D37
    IL_01E1: ldarg.0
    IL_01E6: ldfld 0x04000D37
    IL_01E7: IL_22
    IL_01E8: nop
    IL_01E9: nop
    IL_01EA: nop
    IL_01EB: nop
    IL_01EC: IL_42
    IL_01EE: ldloca.s 0
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: ldarg.0
    IL_01F2: ldc.i4.0
    IL_01F7: stfld 0x04000D36
    IL_01F8: ldarg.0
    IL_01F9: IL_22
    IL_01FA: nop
    IL_01FB: nop
    IL_01FC: nop
    IL_01FD: nop
    IL_0202: stfld 0x04000D37
    IL_0203: ldarg.0
    IL_0208: ldfld 0x04000D1B
    IL_0209: ldc.i4.1
    IL_02AA: switch (39 cases)
    IL_02AB: IL_58
    IL_02B0: stfld 0x04000D58
    IL_02B1: ldarg.0
    IL_02B2: IL_22
    IL_02B3: ldelem.i
    IL_02B4: IL_99
    IL_02B5: IL_99
    IL_02B6: IL_3F
    IL_02BB: stfld 0x04000D37
    IL_02C0: br IL_03AC
    IL_02C1: ldarg.0
    IL_02C6: ldfld 0x04000D0C
    IL_02C7: conv.r8
    IL_02C8: stloc.0
    IL_02C9: nop
    IL_02CA: nop
    IL_02CB: stloc.0
    IL_02CC: ldc.i4.1
    IL_02CD: conv.r8
    IL_02CE: stloc.1
    IL_02CF: nop
    IL_02D0: nop
    IL_02D1: stloc.0
    IL_02D2: ldarg.0
    IL_02D7: ldfld 0x04000D0C
    IL_02DC: call 0x0A00001B
    IL_02DD: conv.r8
    IL_02DE: IL_AF
    IL_02DF: nop
    IL_02E0: nop
    IL_02E1: stloc.0
    IL_02E2: ldarg.0
    IL_02E3: ldc.i4.4
    IL_02E8: stfld 0x04000D1B
    IL_02E9: ldarg.0
    IL_02EA: ldc.i4.0
    IL_02EF: stfld 0x04000D58
    IL_02F0: ldarg.0
    IL_02F1: IL_22
    IL_02F2: nop
    IL_02F3: nop
    IL_02F4: nop
    IL_02F5: nop
    IL_02FA: stfld 0x04000D37
    IL_02FB: ldarg.0
    IL_02FC: IL_22
    IL_02FD: nop
    IL_02FE: nop
    IL_0303: stsfld 0x0667283F
    IL_0304: nop
    IL_0305: ldloc.0
    IL_0306: ldarg.0
    IL_030B: ldfld 0x04000D53
    IL_030C: ldarg.0
    IL_0311: ldfld 0x04000D1F
    IL_0312: IL_8F
    IL_0313: stloc.1
    IL_0314: nop
    IL_0315: nop
    IL_0316: IL_01
    IL_0317: dup
    IL_031A: stloc 31490
    IL_031C: blt.s IL_032A
    IL_031D: nop
    IL_031E: ldarg.2
    IL_031F: IL_58
    IL_0320: IL_54
    IL_0321: ldarg.0
    IL_0326: ldfld 0x04000D51
    IL_0327: ldarg.0
    IL_032C: ldfld 0x04000D1F
    IL_032D: IL_8F
    IL_032E: stloc.1
    IL_032F: nop
    IL_0330: nop
    IL_0331: IL_01
    IL_0332: dup
    IL_0335: stloc 40992
    IL_0336: IL_86
    IL_0337: IL_01
    IL_0338: nop
    IL_0339: IL_58
    IL_033A: IL_54
    IL_033B: ldarg.0
    IL_033C: ldarg.0
    IL_0341: ldfld 0x04000D51
    IL_0342: ldarg.0
    IL_0347: ldfld 0x04000D1F
    IL_0348: IL_94
    IL_034D: call 0x06000668
    IL_0352: ldstr 0x70001FB9
    IL_0353: ldarg.0
    IL_0358: ldfld 0x04000D53
    IL_035D: call 0x060003F8
    IL_035E: pop
    IL_0363: ldstr 0x70001FB1
    IL_0364: ldarg.0
    IL_0369: ldfld 0x04000D51
    IL_036E: call 0x060003F8
    IL_036F: pop
    IL_0370: ldarg.0
    IL_0375: ldfld 0x04000D1F
    IL_0376: ldarg.0
    IL_037B: ldfld 0x04000D20
    IL_042C: switch (43 cases)
    IL_042D: IL_22
    IL_042E: stloc.3
    IL_042F: nop
    IL_0430: ldarg.2
    IL_0431: ldc.i4.1
    IL_051E: switch (58 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    public void Impact() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: conv.r8
    IL_0007: IL_4D
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_000C: ldc.i4.6
    IL_000E: ldc.i4.s 32
    IL_0013: call 0x0A000045
    IL_0014: conv.i2
    IL_0015: ldarg.0
    IL_001A: ldfld 0x04000D59
    IL_001B: IL_58
    IL_0020: stfld 0x04000D5A
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000D5A
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_50
    IL_002C: IL_43
    IL_0031: call 0x0A000114
    IL_0036: stfld 0x04000D5A
    IL_0037: ret
    }

    public void HideCha() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_003A
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000D08
    IL_000C: IL_22
    IL_000D: IL_8F
    IL_000E: IL_C2
    IL_000F: IL_F5
    IL_0010: IL_BC
    IL_0011: IL_22
    IL_0012: IL_29
    IL_0013: sub
    IL_0014: IL_8F
    IL_0015: IL_BE
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_1D9EA: switch (30323 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D13
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000D13
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000D13
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
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
    IL_003B: ldfld 0x04000D0E
    IL_0040: call 0x0A0000DF
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000D18
    IL_0047: conv.i2
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldelem.r8
    IL_0051: IL_43
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldelem.r8
    IL_0056: IL_43
    IL_005B: call 0x0600021D
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000CD8
    IL_0066: call 0x0A0000E0
    IL_0067: IL_22
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_F0
    IL_006B: IL_42
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_006F: IL_F0
    IL_0070: IL_41
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_C8
    IL_0075: IL_42
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_007B: ldloc 10306
    IL_007C: ldc.i4.7
    IL_007D: ldarg.0
    IL_007E: nop
    IL_007F: ldloc.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000CD9
    IL_008A: call 0x0A0000E0
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_54
    IL_008F: IL_43
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0093: stloc.2
    IL_0094: IL_42
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: ldelem.r8
    IL_0099: IL_42
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_C0
    IL_009E: IL_41
    IL_00A3: call 0x0600021D
    IL_00A8: ldsfld 0x040007B2
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000D31
    IL_00B0: ldc.i4.s 73
    IL_00B5: call 0x0A0000E1
    IL_00BA: call 0x0A0002EA
    IL_00BB: IL_22
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: IL_E0
    IL_00BF: IL_42
    IL_00C0: IL_22
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00CC: stsfld 0x00002243
    IL_00CD: nop
    IL_00CE: IL_42
    IL_00D3: call 0x0600021D
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000CE7
    IL_00DE: call 0x0A0000E0
    IL_00DF: IL_22
    IL_00E0: nop
    IL_00E1: nop
    IL_00E3: ldloca.s 67
    IL_00E4: IL_22
    IL_00E5: nop
    IL_00E6: nop
    IL_00E7: IL_C0
    IL_280000174: switch (2684354594 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000D63
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04000D64
    IL_000E: ldarg.0
    IL_000F: ldc.i4.m1
    IL_0014: stfld 0x04000D65
    IL_0015: ldarg.0
    IL_0017: ldc.i4.s 12
    IL_001C: newarr 0x0100003C
    IL_0021: stfld 0x04000D6A
    IL_0022: ldarg.0
    IL_0024: ldc.i4.s 12
    IL_0029: newarr 0x0100000B
    IL_002E: stfld 0x04000D6C
    IL_002F: ldarg.0
    IL_0031: ldc.i4.s 12
    IL_0036: newarr 0x0100000B
    IL_003B: stfld 0x04000D6D
    IL_003C: ldarg.0
    IL_003E: ldc.i4.s 12
    IL_0043: newarr 0x0100000B
    IL_0048: stfld 0x04000D6E
    IL_0049: ldarg.0
    IL_004B: ldc.i4.s 12
    IL_0050: newarr 0x0100000B
    IL_0055: stfld 0x04000D6F
    IL_0056: ldarg.0
    IL_0058: ldc.i4.s 12
    IL_005D: newarr 0x01000010
    IL_0062: stfld 0x04000D70
    IL_0063: ldarg.0
    IL_0065: ldc.i4.s 12
    IL_006A: newarr 0x01000010
    IL_006F: stfld 0x04000D71
    IL_0070: ldarg.0
    IL_0072: ldc.i4.s 12
    IL_0077: newarr 0x01000013
    IL_007C: stfld 0x04000D72
    IL_007D: ldarg.0
    IL_007E: ldc.i4.2
    IL_0083: newarr 0x0100000B
    IL_0088: stfld 0x04000D73
    IL_0089: ldarg.0
    IL_008B: ldc.i4.s 50
    IL_0090: newarr 0x0100000B
    IL_0095: stfld 0x04000D74
    IL_0096: ldarg.0
    IL_0097: ldc.i4.3
    IL_009C: newarr 0x0100000B
    IL_00A1: stfld 0x04000D75
    IL_00A2: ldarg.0
    IL_00A4: ldc.i4.s 50
    IL_00A9: newarr 0x0100000B
    IL_00AE: stfld 0x04000D76
    IL_00AF: ldarg.0
    IL_00B0: ldc.i4.5
    IL_00B5: newarr 0x0100003C
    IL_00BA: stfld 0x04000D77
    IL_00BB: ldarg.0
    IL_00BC: ldc.i4.3
    IL_00C1: newarr 0x0100003C
    IL_00C6: stfld 0x04000D78
    IL_00C7: ldarg.0
    IL_00C8: ldc.i4.3
    IL_00CD: newarr 0x0100003C
    IL_00D2: stfld 0x04000D91
    IL_00D3: ldarg.0
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: IL_F0
    IL_00D8: IL_43
    IL_00DD: stfld 0x04000DBD
    IL_00DE: ldarg.0
    IL_00DF: IL_22
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: IL_AA
    IL_00E3: IL_43
    IL_00E8: stfld 0x04000DBE
    IL_00E9: ldarg.0
    IL_00EA: IL_22
    IL_00EB: nop
    IL_00F0: stsfld 0xC17D44BB
    IL_00F1: stloc.3
    IL_00F2: nop
    IL_00F3: ldarg.2
    IL_00F4: ldarg.0
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: IL_C8
    IL_00F9: IL_C2
    IL_00FE: stfld 0x04000DC3
    IL_00FF: ldarg.0
    IL_0100: ldc.i4.m1
    IL_0105: stfld 0x04000DD2
    IL_0106: ldarg.0
    IL_0107: ldc.i4.m1
    IL_010C: stfld 0x04000DD5
    IL_010D: ldarg.0
    IL_0112: call 0x0A000001
    IL_0113: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000085
    IL_000B: stfld 0x04000DC9
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000067
    IL_0017: stfld 0x04000DCA
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000BB3
    IL_0022: call 0x0A000095
    IL_0027: stfld 0x04000D6B
    IL_0028: ldarg.0
    IL_002D: ldstr 0x70001F2D
    IL_0032: call 0x06000220
    IL_0037: stfld 0x04000D63
    IL_0038: ldarg.0
    IL_003D: ldstr 0x70001F15
    IL_0042: call 0x060003F9
    IL_0047: stfld 0x04000D6C
    IL_0048: ldarg.0
    IL_004D: ldstr 0x70001F25
    IL_0052: call 0x060003F9
    IL_0057: stfld 0x04000D6F
    IL_0058: ldarg.0
    IL_005D: ldstr 0x70001F1D
    IL_0062: call 0x060003F9
    IL_0067: stfld 0x04000D6D
    IL_0068: ldarg.0
    IL_006D: ldstr 0x70001EAD
    IL_0072: call 0x06000220
    IL_0077: stfld 0x04000D69
    IL_0078: ldarg.0
    IL_007D: ldstr 0x70002093
    IL_0082: call 0x06000220
    IL_0087: stfld 0x04000DD2
    IL_0088: ldarg.0
    IL_008D: ldstr 0x700236FF
    IL_0092: call 0x060003F9
    IL_0097: stfld 0x04000D74
    IL_0098: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000D67
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000D66
    IL_0020: ret
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
    IL_0011: stfld 0x04000DD1
    IL_0016: ldstr 0x70000121
    IL_001B: call 0x0A000004
    IL_001C: ldnull
    IL_0021: call 0x0A000061
    IL_0026: brfalse IL_004C
    IL_0027: ldarg.0
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000D9C
    IL_0032: call 0x0A00001B
    IL_0037: call 0x0A000013
    IL_003C: call 0x0A000014
    IL_003D: conv.u4
    IL_003E: ldarg.1
    IL_003F: nop
    IL_0040: nop
    IL_0041: IL_01
    IL_0046: stfld 0x04000DA4
    IL_004B: br IL_0061
    IL_004C: ldarg.0
    IL_0051: ldstr 0x70000121
    IL_0056: call 0x0A000004
    IL_0057: conv.r8
    IL_0058: ldarg.3
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_0060: stfld 0x04000DA4
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000DA4
    IL_0068: conv.r8
    IL_006D: ldsfld 0x7D2B0000
    IL_006E: IL_CB
    IL_006F: stloc.3
    IL_0070: nop
    IL_0071: ldarg.2
    IL_0072: ldarg.0
    IL_0077: call 0x0600067B
    IL_0078: ldarg.0
    IL_0079: ldc.i4.1
    IL_007E: call 0x06000679
    IL_007F: ldarg.0
    IL_0084: call 0x06000674
    IL_0085: ldarg.0
    IL_008A: ldstr 0x700232A7
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_E8
    IL_008F: IL_41
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0093: IL_F0
    IL_0094: IL_41
    IL_0099: call 0x0A000017
    IL_009E: ldstr 0x70023EF1
    IL_00A3: call 0x0A000095
    IL_00A4: stloc.0
    IL_00A5: ldloc.0
    IL_00A6: ldc.i4.1
    IL_0107: switch (23 cases)
    IL_0108: IL_CC
    IL_0109: IL_CC
    IL_010A: IL_3E
    IL_010F: newobj 0x0A000076
    IL_0110: conv.r8
    IL_0111: conv.ovf.i4.un
    IL_0112: IL_01
    IL_0113: nop
    IL_0114: stloc.0
    IL_0115: ldarg.0
    IL_011A: ldfld 0x04000D9D
    IL_011F: call 0x0A00004B
    IL_0120: IL_22
    IL_0121: shr
    IL_0122: shr
    IL_0127: isinst 0x00082840
    IL_0128: nop
    IL_0129: stloc.0
    IL_012A: conv.r8
    IL_012B: IL_AF
    IL_012C: nop
    IL_012D: nop
    IL_012E: stloc.0
    IL_012F: ldarg.0
    IL_0134: ldstr 0x70023285
    IL_0135: IL_22
    IL_0136: nop
    IL_0137: nop
    IL_013C: stsfld 0x147B223F
    IL_013D: IL_AE
    IL_013E: IL_3E
    IL_0143: call 0x0A000017
    IL_0144: ldarg.0
    IL_0149: call 0x0600067D
    IL_014E: ldstr 0x70000617
    IL_014F: ldc.i4.8
    IL_0154: call 0x0A00009F
    IL_0155: ret
    }

    private void SetServerTime() {
    IL_0004: call 0x0600056E
    IL_0005: ldarg.0
    IL_000A: call 0x06000675
    IL_000B: ret
    }

    public void DelayWorkTime() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0019
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000D73
    IL_000D: ldloc.0
    IL_000E: ldloc.0
    IL_0013: call 0x0600056F
    IL_0014: ldelem.i8
    IL_0015: ldloc.0
    IL_0016: ldc.i4.1
    IL_0017: IL_58
    IL_0018: stloc.0
    IL_0019: ldloc.0
    IL_001A: ldc.i4.2
    IL_001B: IL_3F
    IL_001C: IL_E7
    IL_001D: IL_FF
    IL_001E: IL_FF
    IL_001F: IL_FF
    IL_0020: ldc.i4.0
    IL_0021: stloc.1
    IL_0026: br IL_0059
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000D72
    IL_002D: ldloc.1
    IL_002E: IL_91
    IL_0033: brtrue IL_0055
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000D6E
    IL_003A: ldloc.1
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000D6D
    IL_0041: ldloc.1
    IL_0042: IL_94
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000D73
    IL_0049: ldc.i4.1
    IL_004A: IL_94
    IL_004B: conv.i2
    IL_004C: IL_22
    IL_004D: IL_CD
    IL_004E: IL_CC
    IL_004F: IL_4C
    IL_0050: IL_3E
    IL_0051: IL_5A
    IL_0052: not
    IL_0053: IL_58
    IL_0054: ldelem.i8
    IL_0055: ldloc.1
    IL_0056: ldc.i4.1
    IL_0057: IL_58
    IL_0058: stloc.1
    IL_0059: ldloc.1
    IL_005B: ldc.i4.s 12
    IL_005C: IL_3F
    IL_005D: IL_C6
    IL_005E: IL_FF
    IL_005F: IL_FF
    IL_0060: IL_FF
    IL_0061: ret
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000DD3
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000DD3
    IL_0010: ret
    }

    public void GeneralStat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DCA
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_F5
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000DCA
    IL_0017: ldfld 0x04000675
    IL_001C: stfld 0x04000DA8
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000DCA
    IL_0028: ldfld 0x04000676
    IL_002D: stfld 0x04000DA9
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000DCA
    IL_0039: ldfld 0x04000678
    IL_003E: stfld 0x04000DAA
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000DCA
    IL_004A: ldfld 0x04000679
    IL_004F: stfld 0x04000DAB
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000DCA
    IL_005B: ldfld 0x04000677
    IL_0060: stfld 0x04000DAC
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000DCA
    IL_006C: ldfld 0x0400067A
    IL_0071: stfld 0x04000DB7
    IL_0072: ldarg.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000DCA
    IL_007D: ldfld 0x0400067D
    IL_0082: stfld 0x04000DAD
    IL_0083: ldarg.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000DCA
    IL_008E: ldfld 0x0400067C
    IL_0093: stfld 0x04000DAE
    IL_0094: ldarg.2
    IL_0099: brtrue IL_0110
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000D6D
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000D68
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x04000DAC
    IL_00AC: ldelem.i8
    IL_00AD: ldarg.0
    IL_00B2: ldfld 0x04000D6E
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x04000D68
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x04000DAC
    IL_00BF: ldelem.i8
    IL_00C4: ldstr 0x70001F1D
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04000D6E
    IL_00CF: call 0x060003F8
    IL_00D0: pop
    IL_00D1: ldc.i4.1
    IL_00D6: call 0x0600056B
    IL_00DB: ldstr 0x70001FD3
    IL_00E0: call 0x060003F9
    IL_00E1: stloc.0
    IL_00E2: ldloc.0
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000DA8
    IL_00E9: ldloc.0
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000DA8
    IL_00F0: IL_94
    IL_00F1: ldarg.0
    IL_00F6: ldfld 0x04000DAD
    IL_00F7: ldc.i4.1
    IL_00F8: IL_58
    IL_00FD: call 0x0A000080
    IL_00FE: ldelem.i8
    IL_0103: ldstr 0x70001FD3
    IL_0104: ldloc.0
    IL_0109: call 0x060003F8
    IL_010A: pop
    IL_010F: br IL_01A7
    IL_0110: ldarg.0
    IL_0115: ldfld 0x04000D6E
    IL_0116: ldarg.0
    IL_011B: ldfld 0x04000D64
    IL_011C: IL_94
    IL_011D: ldarg.0
    IL_0122: ldfld 0x04000DAC
    IL_0123: IL_3F
    IL_0124: pop
    IL_0125: nop
    IL_0126: nop
    IL_0127: nop
    IL_0128: ldarg.0
    IL_012D: ldfld 0x04000D6E
    IL_012E: ldarg.0
    IL_0133: ldfld 0x04000D64
    IL_0134: ldarg.0
    IL_0139: ldfld 0x04000DAC
    IL_013A: ldelem.i8
    IL_013B: ldarg.0
    IL_0140: ldfld 0x04000D72
    IL_0141: ldarg.0
    IL_0146: ldfld 0x04000D64
    IL_0147: ldc.i4.1
    IL_0148: ldelem.i2
    IL_014D: br IL_016F
    IL_014E: ldarg.0
    IL_0153: ldfld 0x04000D6E
    IL_0154: ldarg.0
    IL_0159: ldfld 0x04000D64
    IL_015A: IL_94
    IL_015B: ldc.i4.0
    IL_015C: IL_3D
    IL_015E: ldarg.s 0
    IL_015F: nop
    IL_0160: nop
    IL_0161: ldarg.0
    IL_0166: ldfld 0x04000D6E
    IL_0167: ldarg.0
    IL_016C: ldfld 0x04000D64
    IL_016D: ldc.i4.1
    IL_016E: ldelem.i8
    IL_016F: ldarg.0
    IL_0170: ldarg.0
    IL_0175: ldfld 0x04000D6F
    IL_0176: ldarg.0
    IL_017B: ldfld 0x04000D64
    IL_017C: IL_94
    IL_017E: ldc.i4.s 58
    IL_017F: IL_5A
    IL_0180: conv.i2
    IL_0182: ldc.i4.s 100
    IL_0183: ldarg.0
    IL_0188: ldfld 0x04000DAE
    IL_0189: ldc.i4.6
    IL_018A: IL_5A
    IL_018B: IL_58
    IL_018C: conv.i2
    IL_018D: IL_22
    IL_018E: nop
    IL_018F: nop
    IL_0194: stsfld 0xAD7B023F
    IL_0195: stloc.3
    IL_0196: nop
    IL_0197: ldarg.2
    IL_0198: conv.i2
    IL_0199: IL_22
    IL_019A: IL_CD
    IL_019B: IL_CC
    IL_019C: IL_4C
    IL_019D: IL_3E
    IL_019E: IL_5A
    IL_019F: IL_58
    IL_01A0: IL_5A
    IL_01A1: add
    IL_01A6: stfld 0x04000DB9
    IL_01A7: ret
    }

    public void FortuneTell() {
    IL_0000: ldc.i4.4
    IL_0005: newarr 0x0100000B
    IL_0006: stloc.0
    IL_0007: ldc.i4.4
    IL_000C: newarr 0x0100000B
    IL_000D: stloc.1
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000D6C
    IL_0014: ldarg.0
    IL_0019: ldfld 0x04000D64
    IL_001A: IL_94
    IL_001B: stloc.2
    IL_001C: ldc.i4.0
    IL_001D: stloc.3
    IL_0022: br IL_004C
    IL_0023: ldloc.1
    IL_0024: ldloc.3
    IL_0025: ldloc.2
    IL_0027: ldc.i4.s 10
    IL_0028: mul
    IL_0029: ldelem.i8
    IL_002A: ldloc.2
    IL_002C: ldc.i4.s 10
    IL_002D: add
    IL_002E: stloc.2
    IL_002F: ldloc.0
    IL_0030: ldloc.1
    IL_0031: ldloc.3
    IL_0032: ldc.i4.4
    IL_0033: mul
    IL_0034: IL_94
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000DA8
    IL_003B: IL_58
    IL_003C: ldc.i4.4
    IL_003D: mul
    IL_003E: IL_8F
    IL_003F: stloc.1
    IL_0040: nop
    IL_0041: nop
    IL_0042: IL_01
    IL_0043: dup
    IL_0046: stloc 22551
    IL_0047: IL_54
    IL_0048: ldloc.3
    IL_0049: ldc.i4.1
    IL_004A: IL_58
    IL_004B: stloc.3
    IL_004C: ldloc.3
    IL_004D: ldc.i4.4
    IL_004E: IL_3F
    IL_0053: ldtoken 0x02FFFFFF
    IL_0058: ldfld 0x04000D9B
    IL_0059: conv.r8
    IL_005A: stloc.0
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ldc.i4.1
    IL_005F: conv.r8
    IL_0060: stloc.1
    IL_0061: nop
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000D9B
    IL_006A: conv.r8
    IL_006B: IL_89
    IL_006C: nop
    IL_006D: nop
    IL_006F: br.s IL_0076
    IL_0070: ldc.i4.0
    IL_0071: IL_94
    IL_0072: ldc.i4.1
    IL_0073: IL_58
    IL_0074: ldloc.0
    IL_0075: ldc.i4.1
    IL_0076: IL_94
    IL_0077: ldc.i4.1
    IL_0078: IL_58
    IL_0079: ldloc.0
    IL_007A: ldc.i4.2
    IL_007B: IL_94
    IL_007C: ldc.i4.1
    IL_007D: IL_58
    IL_007E: ldloc.0
    IL_007F: ldc.i4.3
    IL_0080: IL_94
    IL_0081: ldc.i4.1
    IL_0082: IL_58
    IL_0083: conv.r8
    IL_0084: IL_EF
    IL_0085: ldarg.0
    IL_0086: nop
    IL_0087: ldloc.0
    IL_0088: ret
    }

    public void CurGeneralStat() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0041
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000D63
    IL_000C: ldc.i4.m1
    IL_0011: beq IL_003C
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000DCA
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000D6C
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000D63
    IL_0024: IL_94
    IL_0025: conv.r8
    IL_0026: IL_F5
    IL_0027: ldarg.0
    IL_0028: nop
    IL_0029: ldloc.0
    IL_002A: ldarg.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000DCA
    IL_0035: ldfld 0x04000677
    IL_0036: conv.i2
    IL_003B: stfld 0x04000DC1
    IL_0040: br IL_004E
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000DAC
    IL_0048: conv.i2
    IL_004D: stfld 0x04000DC1
    IL_004E: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000DC7
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000DC2
    IL_000E: ret
    }

    public void GeneralKindOnly() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0008: br IL_008C
    IL_0009: ldarg.0
    IL_000E: ldfld 0x04000D6C
    IL_000F: ldloc.1
    IL_0010: IL_94
    IL_0011: ldc.i4.0
    IL_0012: IL_3E
    IL_0017: ldobj 0x02000000
    IL_001C: ldfld 0x04000D6C
    IL_001D: ldloc.1
    IL_001E: IL_94
    IL_0023: ldc.i4 10000000
    IL_0024: mul
    IL_0029: ldc.i4 100000
    IL_002A: add
    IL_002B: stloc.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000D70
    IL_0032: ldloc.1
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000D6C
    IL_0039: ldloc.1
    IL_003A: IL_94
    IL_003F: ldc.i4 100000
    IL_0040: mul
    IL_0045: ldc.i4 10000
    IL_0046: add
    IL_0047: neg
    IL_0048: ldelem.i4
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000D71
    IL_004F: ldloc.1
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000D6C
    IL_0056: ldloc.1
    IL_0057: IL_94
    IL_0058: conv.i2
    IL_0059: IL_22
    IL_005E: stsfld 0x5B4B1896
    IL_005F: neg
    IL_0060: ldelem.i4
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000D6A
    IL_0067: ldloc.1
    IL_006C: ldstr 0x70022E37
    IL_006D: ldloc.0
    IL_006E: ldc.i4.1
    IL_006F: IL_58
    IL_0070: stloc.2
    IL_0072: ldloca.s 2
    IL_0077: call 0x0A000010
    IL_007C: call 0x0A000011
    IL_0081: call 0x0A000012
    IL_0082: conv.u8
    IL_0083: IL_3C
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_01
    IL_008B: stelem 0x0B581707
    IL_008C: ldloc.1
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000D69
    IL_0093: IL_3F
    IL_0098: ldobj 0x2AFFFFFF
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DC7
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000DC2
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000DC2
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000DC2
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
    IL_0033: stfld 0x04000DC7
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000DC2
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000DD7
    IL_0045: ldc.i4.0
    IL_0046: IL_3E
    IL_0047: IL_F6
    IL_0048: IL_01
    IL_0049: nop
    IL_004A: nop
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000DD7
    IL_0051: ldc.i4.3
    IL_03FA: switch (233 cases)
    IL_03FB: IL_22
    IL_03FC: nop
    IL_03FD: nop
    IL_03FE: nop
    IL_03FF: nop
    IL_0784: switch (224 cases)
    IL_0785: nop
    IL_0786: ldarg.2
    IL_0787: ldc.i4.1
    IL_0788: IL_58
    IL_078A: ldc.i4.s 20
    IL_078B: IL_5A
    IL_078C: IL_3F
    IL_078D: stloc.1
    IL_078E: nop
    IL_078F: nop
    IL_0790: nop
    IL_0791: ldarg.0
    IL_0792: IL_22
    IL_0793: nop
    IL_0794: nop
    IL_0795: nop
    IL_0796: nop
    IL_079B: stfld 0x04000DBC
    IL_079C: ldarg.0
    IL_07A1: ldfld 0x04000DBC
    IL_07A2: IL_22
    IL_07A3: nop
    IL_07A4: nop
    IL_07A5: nop
    IL_07A6: nop
    IL_07A7: IL_42
    IL_07A8: IL_3C
    IL_07A9: nop
    IL_07AA: nop
    IL_07AB: nop
    IL_07AC: ldarg.0
    IL_07B1: ldfld 0x04000D6F
    IL_07B2: ldarg.0
    IL_07B7: ldfld 0x04000D65
    IL_07B8: ldarg.0
    IL_07BD: ldfld 0x04000DBB
    IL_07BE: not
    IL_07BF: ldelem.i8
    IL_07C0: ldarg.0
    IL_07C5: ldfld 0x04000D6C
    IL_07C6: ldarg.0
    IL_07CB: ldfld 0x04000D65
    IL_07CC: IL_8F
    IL_07CD: stloc.1
    IL_07CE: nop
    IL_07CF: nop
    IL_07D0: IL_01
    IL_07D1: dup
    IL_07D4: stloc 32800
    IL_07D5: IL_96
    IL_07D6: IL_98
    IL_07D7: nop
    IL_07D8: ldarg.0
    IL_07DD: ldfld 0x04000DB4
    IL_07DE: IL_5A
    IL_07DF: IL_58
    IL_07E0: IL_54
    IL_07E1: ldarg.0
    IL_07E2: ldc.i4.1
    IL_07E7: stfld 0x04000DC5
    IL_07E8: ldarg.0
    IL_07E9: ldarg.0
    IL_07EE: ldfld 0x04000DBB
    IL_07EF: IL_22
    IL_07F0: nop
    IL_07F1: nop
    IL_07F2: neg
    IL_07F3: IL_42
    IL_07F4: IL_5A
    IL_07F6: ldc.i4.s 100
    IL_07F7: ldarg.0
    IL_07FC: ldfld 0x04000DB0
    IL_07FD: ldc.i4.6
    IL_07FE: IL_5A
    IL_07FF: IL_58
    IL_0800: conv.i2
    IL_0801: IL_22
    IL_0802: nop
    IL_0803: nop
    IL_0808: stsfld 0xAF7B023F
    IL_0809: stloc.3
    IL_080A: nop
    IL_080B: ldarg.2
    IL_080C: conv.i2
    IL_080D: IL_22
    IL_080E: IL_CD
    IL_080F: IL_CC
    IL_0810: IL_4C
    IL_0811: IL_3E
    IL_0812: IL_5A
    IL_0813: IL_58
    IL_0814: IL_5A
    IL_0815: add
    IL_081A: stfld 0x04000DBA
    IL_081B: ldarg.0
    IL_0820: ldfld 0x04000DC2
    IL_0821: IL_22
    IL_0822: nop
    IL_0823: nop
    IL_0824: nop
    IL_0825: nop
    IL_0A1E: switch (125 cases)
    }

    private void SetGiftCount() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000DD6
    IL_0007: ldarg.0
    IL_0009: ldc.i4.s 50
    IL_000E: newarr 0x0100000B
    IL_0013: stfld 0x04000D76
    IL_0014: ldarg.0
    IL_0015: ldc.i4.3
    IL_001A: newarr 0x0100000B
    IL_001F: stfld 0x04000D75
    IL_0020: ldc.i4.0
    IL_0021: stloc.0
    IL_0026: br IL_0071
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000D74
    IL_002D: ldloc.0
    IL_002E: IL_94
    IL_0033: brfalse IL_006D
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000D74
    IL_003A: ldloc.0
    IL_003B: IL_94
    IL_0040: ldc.i4 10000000
    IL_0041: add
    IL_0042: stloc.1
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000D76
    IL_0049: ldloc.0
    IL_004A: ldloc.1
    IL_004B: ldelem.i8
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000D75
    IL_0052: ldloc.1
    IL_0053: ldc.i4.1
    IL_0054: IL_59
    IL_0055: IL_8F
    IL_0056: stloc.1
    IL_0057: nop
    IL_0058: nop
    IL_0059: IL_01
    IL_005A: dup
    IL_005D: stloc 22551
    IL_005E: IL_54
    IL_005F: ldarg.0
    IL_0060: dup
    IL_0065: ldfld 0x04000DD6
    IL_0066: ldc.i4.1
    IL_0067: IL_58
    IL_006C: stfld 0x04000DD6
    IL_006D: ldloc.0
    IL_006E: ldc.i4.1
    IL_006F: IL_58
    IL_0070: stloc.0
    IL_0071: ldloc.0
    IL_0073: ldc.i4.s 50
    IL_0074: IL_3F
    IL_0075: IL_AE
    IL_0076: IL_FF
    IL_0077: IL_FF
    IL_0078: IL_FF
    IL_0079: ret
    }

    private void FindCardType() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000DD5
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002C
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000D76
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_0016: ldarg.1
    IL_004B: switch (12 cases)
    }

    private void GiftMode() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: IL_DC
    IL_0004: IL_42
    IL_0005: ldarg.0
    IL_000A: ldfld 0x04000DC3
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_0012: ldc.i4 2251074
    IL_0013: nop
    IL_0014: IL_82
    IL_0015: IL_43
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: ldloc.2
    IL_001A: IL_42
    IL_001F: call 0x0600021D
    IL_0020: ldc.i4.4
    IL_0025: newarr 0x01000020
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_002C: ldsfld 0x040007B2
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000D6B
    IL_0037: ldc.i4 421
    IL_003C: call 0x0A0000E1
    IL_0041: stelem 0xF9721725
    IL_0042: IL_3E
    IL_0043: ldarg.0
    IL_0048: cpobj 0x021825A2
    IL_004D: ldfld 0x04000DD6
    IL_0052: newobj 0x0100000B
    IL_0057: stelem 0x01721925
    IL_0058: IL_3F
    IL_0059: ldarg.0
    IL_005E: cpobj 0x009628A2
    IL_005F: nop
    IL_0060: stloc.0
    IL_0065: ldstr 0x70023325
    IL_006A: call 0x0A0000E2
    IL_006F: call 0x0A0000E3
    IL_0070: ldc.i4.0
    IL_0071: stloc.0
    IL_0076: br IL_0229
    IL_0078: ldc.i4.s 90
    IL_0079: ldloc.0
    IL_007B: ldc.i4.s 110
    IL_007C: IL_5A
    IL_007D: IL_58
    IL_007E: conv.i2
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000DC3
    IL_0085: IL_22
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldelem.r8
    IL_0089: IL_42
    IL_008A: IL_22
    IL_008B: nop
    IL_008C: nop
    IL_008D: ldelem.r8
    IL_008E: IL_42
    IL_0093: call 0x0600021D
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000D91
    IL_009A: ldloc.0
    IL_009B: ldelem.i
    IL_00A0: call 0x0A0000E0
    IL_00A2: ldc.i4.s 90
    IL_00A3: ldloc.0
    IL_00A5: ldc.i4.s 110
    IL_00A6: IL_5A
    IL_00A7: IL_58
    IL_00A8: conv.i2
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000DC3
    IL_00AF: IL_22
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: ldelem.r8
    IL_00B3: IL_42
    IL_00B4: IL_22
    IL_00B5: nop
    IL_00B6: nop
    IL_00B7: ldelem.r8
    IL_00B8: IL_42
    IL_00BD: call 0x0600021D
    IL_00C2: ldsfld 0x0A000099
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000D98
    IL_00CD: call 0x0A0000F1
    IL_00D2: brfalse IL_01A5
    IL_00D3: ldarg.0
    IL_00D4: ldarg.0
    IL_00D5: ldloc.0
    IL_00D6: ldc.i4.1
    IL_00D7: IL_58
    IL_00DC: call 0x0600067E
    IL_00E1: stfld 0x04000DD5
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x04000DD5
    IL_00E8: ldc.i4.m1
    IL_00ED: beq IL_01A5
    IL_00EE: ldarg.0
    IL_00F3: call 0x06000680
    IL_00F4: ldc.i4.m1
    IL_00F9: beq IL_016E
    IL_00FA: ldarg.0
    IL_00FF: ldfld 0x04000D9E
    IL_0100: conv.r8
    IL_0101: stloc.3
    IL_0102: nop
    IL_0103: nop
    IL_0104: stloc.0
    IL_0105: conv.r8
    IL_0107: ldarg.s 0
    IL_0108: nop
    IL_0109: stloc.0
    IL_010A: ldarg.0
    IL_010F: ldfld 0x04000D91
    IL_0110: ldloc.0
    IL_0111: ldelem.i
    IL_0112: conv.r8
    IL_0114: ldarga.s 0
    IL_0115: nop
    IL_0116: stloc.0
    IL_0117: ldarg.0
    IL_011C: ldfld 0x04000D9E
    IL_011D: conv.r8
    IL_011E: stloc.0
    IL_011F: nop
    IL_0120: nop
    IL_0121: stloc.0
    IL_0122: ldc.i4.1
    IL_0123: conv.r8
    IL_0124: stloc.1
    IL_0125: nop
    IL_0126: nop
    IL_0127: stloc.0
    IL_0128: ldarg.0
    IL_012D: ldfld 0x04000D9E
    IL_012E: ldloc.0
    IL_012F: ldc.i4.1
    IL_0130: IL_59
    IL_0131: conv.i2
    IL_0132: IL_22
    IL_0133: nop
    IL_0134: nop
    IL_0135: nop
    IL_0136: IL_BF
    IL_0137: IL_5A
    IL_0138: IL_22
    IL_0139: IL_CD
    IL_013A: IL_CC
    IL_013B: IL_4C
    IL_013C: IL_3D
    IL_013D: IL_22
    IL_013E: nop
    IL_013F: nop
    IL_0140: nop
    IL_0141: IL_3F
    IL_0146: newobj 0x0A000076
    IL_0147: conv.r8
    IL_0148: ldloc.3
    IL_0149: nop
    IL_014A: nop
    IL_014B: stloc.0
    IL_014C: ldarg.0
    IL_014D: IL_22
    IL_014E: nop
    IL_014F: nop
    IL_0150: IL_C8
    IL_0151: IL_C2
    IL_0156: stfld 0x04000DC3
    IL_0157: ldarg.0
    IL_0158: ldc.i4.1
    IL_015D: stfld 0x04000DD7
    IL_015E: ldarg.0
    IL_015F: IL_22
    IL_0160: nop
    IL_0161: nop
    IL_0162: nop
    IL_0163: IL_3F
    IL_0168: stfld 0x04000DC4
    IL_016D: br IL_0230
    IL_016E: ldarg.0
    IL_0173: ldfld 0x04000D69
    IL_0175: ldc.i4.s 12
    IL_0176: IL_3F
    IL_0177: ldc.i4.2
    IL_0178: nop
    IL_0179: nop
    IL_017A: nop
    IL_017B: ldarg.0
    IL_017D: ldc.i4.s 9
    IL_0182: stfld 0x04000DB6
    IL_0183: ldarg.0
    IL_0184: IL_22
    IL_0185: nop
    IL_0186: nop
    IL_018B: stsfld 0x067A283F
    IL_018C: nop
    IL_018D: ldloc.0
    IL_0192: br IL_01A5
    IL_0193: ldarg.0
    IL_0194: IL_22
    IL_0195: nop
    IL_0196: nop
    IL_019B: stsfld 0x067A283F
    IL_019C: nop
    IL_019D: ldloc.0
    IL_019E: ldarg.0
    IL_019F: ldc.i4.3
    IL_01A4: stfld 0x04000DB6
    IL_01A6: ldc.i4.s 94
    IL_01A7: ldloc.0
    IL_01A9: ldc.i4.s 110
    IL_01AA: IL_5A
    IL_01AB: IL_58
    IL_01AC: conv.i2
    IL_01AD: ldarg.0
    IL_01B2: ldfld 0x04000DC3
    IL_01B3: IL_22
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: ldelem.r8
    IL_01B7: IL_42
    IL_01B8: IL_58
    IL_01B9: IL_22
    IL_01BA: nop
    IL_01BB: nop
    IL_01C0: ldobj 0x00002242
    IL_01C1: IL_C0
    IL_01C2: IL_41
    IL_01C7: call 0x0600021D
    IL_01CC: ldsfld 0x0A000099
    IL_01D1: ldstr 0x70022A46
    IL_01D6: call 0x0A0000E2
    IL_01DB: call 0x0A0001BA
    IL_01DD: ldc.i4.s 90
    IL_01DE: ldloc.0
    IL_01E0: ldc.i4.s 110
    IL_01E1: IL_5A
    IL_01E2: IL_58
    IL_01E3: conv.i2
    IL_01E4: ldarg.0
    IL_01E9: ldfld 0x04000DC3
    IL_01EA: IL_22
    IL_01EB: nop
    IL_01EC: nop
    IL_01ED: IL_98
    IL_01EE: IL_42
    IL_01EF: IL_58
    IL_01F0: IL_22
    IL_01F1: nop
    IL_01F2: nop
    IL_01F3: ldelem.r8
    IL_01F4: IL_42
    IL_01F5: IL_22
    IL_01F6: nop
    IL_01F7: nop
    IL_01F8: nop
    IL_01F9: IL_42
    IL_01FE: call 0x0600021D
    IL_0203: ldsfld 0x0A000099
    IL_0204: ldarg.0
    IL_0209: ldfld 0x04000D75
    IL_020A: ldloc.0
    IL_020B: IL_94
    IL_0210: newobj 0x0100000B
    IL_0215: call 0x0A00009A
    IL_021A: ldstr 0x70022A5A
    IL_021F: call 0x0A0000E2
    IL_0224: call 0x0A0000E3
    IL_0225: ldloc.0
    IL_0226: ldc.i4.1
    IL_0227: IL_58
    IL_0228: stloc.0
    IL_0229: ldloc.0
    IL_022A: ldc.i4.3
    IL_022B: IL_3F
    IL_022E: starg 65534
    IL_022F: IL_FF
    IL_0230: ret
    }

    private void GetGeneral() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000D68
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002B
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000D6C
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_001A: brtrue IL_0027
    IL_001B: ldarg.0
    IL_001C: ldloc.0
    IL_0021: stfld 0x04000D68
    IL_0026: br IL_0037
    IL_0027: ldloc.0
    IL_0028: ldc.i4.1
    IL_0029: IL_58
    IL_002A: stloc.0
    IL_002B: ldloc.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000D69
    IL_0032: IL_3F
    IL_0033: IL_D7
    IL_0034: IL_FF
    IL_0035: IL_FF
    IL_0036: IL_FF
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000D68
    IL_003D: ret
    }

    private void GeneralMode() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D64
    IL_0006: ldc.i4.0
    IL_0007: IL_3C
    IL_0009: ldloc.s 0
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000D63
    IL_0017: stfld 0x04000D64
    IL_001C: br IL_0047
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000D6C
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000D64
    IL_0029: IL_94
    IL_002E: brtrue IL_0047
    IL_002F: ldarg.0
    IL_0030: ldc.i4.0
    IL_0035: stfld 0x04000DA7
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000D9D
    IL_0040: call 0x0A00001B
    IL_0041: conv.r8
    IL_0042: IL_AF
    IL_0043: nop
    IL_0044: nop
    IL_0045: stloc.0
    IL_0046: ret
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000DA7
    IL_004D: ldc.i4.4
    IL_004E: IL_3C
    IL_0050: blt.s IL_0061
    IL_0051: nop
    IL_0052: nop
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldarg.0
    IL_0057: IL_43
    IL_0058: IL_22
    IL_0059: nop
    IL_005A: nop
    IL_005B: IL_58
    IL_005C: IL_42
    IL_005D: IL_22
    IL_005E: nop
    IL_005F: nop
    IL_0060: sub
    IL_0061: IL_43
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0069: ldobj 0x021D2841
    IL_006A: nop
    IL_006B: ldloc.0
    IL_006C: ldarg.0
    IL_0071: ldfld 0x04000D79
    IL_0076: call 0x0A0000E0
    IL_0077: IL_22
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.2
    IL_007B: IL_43
    IL_007C: IL_22
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_C2
    IL_0080: IL_42
    IL_0081: IL_22
    IL_0082: nop
    IL_0083: nop
    IL_0088: stsfld 0x00002242
    IL_008D: stsfld 0x021D2842
    IL_008E: nop
    IL_008F: ldloc.0
    IL_0090: ldarg.0
    IL_0095: ldfld 0x04000D6A
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000D64
    IL_009C: ldelem.i
    IL_00A1: call 0x0A0000E0
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.2
    IL_00A6: IL_43
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: IL_A4
    IL_00AB: IL_42
    IL_00AC: IL_22
    IL_00AD: nop
    IL_00AE: nop
    IL_00B3: stsfld 0x00002242
    IL_00B4: IL_DC
    IL_00B5: IL_42
    IL_00BA: call 0x0600021D
    IL_00BB: ldarg.0
    IL_00C0: ldfld 0x04000D7A
    IL_00C5: call 0x0A0000E0
    IL_00C6: IL_22
    IL_00C7: nop
    IL_00C8: nop
    IL_00CA: starg.s 67
    IL_00CB: IL_22
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: IL_23
    IL_00CF: IL_43
    IL_00D0: IL_22
    IL_00D1: nop
    IL_00D2: nop
    IL_00D7: newobj 0x00002242
    IL_00DC: stsfld 0x021D2841
    IL_00DD: nop
    IL_00DE: ldloc.0
    IL_00DF: ldc.i4.4
    IL_00E4: newarr 0x01000020
    IL_00E5: dup
    IL_00E6: ldc.i4.0
    IL_00EB: ldsfld 0x0A000099
    IL_00F0: stelem 0x7B021725
    IL_00F1: IL_AE
    IL_00F2: stloc.3
    IL_00F3: nop
    IL_00F4: ldarg.2
    IL_00F9: newobj 0x01000010
    IL_00FE: stelem 0xD9721825
    IL_00FF: IL_37
    IL_0100: ldarg.0
    IL_0105: cpobj 0x021925A2
    IL_010A: ldfld 0x04000DAD
    IL_010B: ldc.i4.1
    IL_010C: IL_58
    IL_010E: ldc.i4.s 20
    IL_010F: IL_5A
    IL_0114: newobj 0x0100000B
    IL_0119: stelem 0x00009628
    IL_011A: stloc.0
    IL_011F: ldstr 0x70000BC5
    IL_0124: call 0x0A0000E2
    IL_0129: call 0x0A0000E3
    IL_012A: IL_22
    IL_012B: nop
    IL_012C: nop
    IL_012E: ldarga.s 67
    IL_012F: IL_22
    IL_0130: nop
    IL_0131: nop
    IL_0136: br IL_-4684FC86
    IL_0137: stloc.3
    IL_0138: nop
    IL_0139: ldarg.2
    IL_013A: IL_22
    IL_013B: nop
    IL_013C: nop
    IL_013D: ldelem.r8
    IL_875E2: switch (138536 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DA5
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000DA5
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000DA5
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000D9D
    IL_004B: call 0x0A00001B
    IL_004C: conv.r8
    IL_004D: IL_AF
    IL_004E: nop
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: ret
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D62
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000DBD
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004E: cpobj 0x00002243
    IL_004F: IL_F0
    IL_0050: IL_43
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0054: IL_C8
    IL_0055: IL_42
    IL_005A: call 0x0600021D
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000D84
    IL_0065: call 0x0A0000E0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000DB6
    IL_006C: ldc.i4.0
    IL_006D: IL_3E
    IL_006E: ldloc.0
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldc.i4.0
    IL_0077: call 0x0A0001B9
    IL_0078: IL_22
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_E0
    IL_007C: IL_42
    IL_007D: IL_22
    IL_007E: nop
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0089: stsfld 0x00002243
    IL_008A: nop
    IL_008B: IL_42
    IL_0090: call 0x0600021D
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000D93
    IL_009B: call 0x0A0000E0
    IL_009C: IL_22
    IL_009D: nop
    IL_009E: nop
    IL_00A0: ldloca.s 67
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: IL_C0
    IL_280000131: switch (2684354594 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000E05
    IL_000C: ldarg.0
    IL_000E: ldc.i4.s 20
    IL_0013: newarr 0x0100000B
    IL_0018: stfld 0x04000E16
    IL_0019: ldarg.0
    IL_001E: ldsfld 0x0A000099
    IL_0023: stfld 0x04000E18
    IL_0024: ldarg.0
    IL_0025: ldc.i4.1
    IL_002A: stfld 0x04000E1A
    IL_002B: ldarg.0
    IL_002C: ldc.i4.1
    IL_0031: stfld 0x04000E1B
    IL_0032: ldarg.0
    IL_0037: ldsfld 0x0A000099
    IL_003C: stfld 0x04000E1D
    IL_003D: ldarg.0
    IL_0042: call 0x0A000001
    IL_0043: ret
    }

    private void Start() {
    IL_0000: ldc.i4.0
    IL_0005: call 0x0A0002E9
    IL_0007: ldc.i4.s 60
    IL_000C: call 0x0A000318
    IL_000D: ldarg.0
    IL_0012: ldstr 0x70022F71
    IL_0017: call 0x0A000095
    IL_001C: stfld 0x04000DDF
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000DDF
    IL_0023: ldc.i4.0
    IL_0024: IL_3E
    IL_0025: IL_AA
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_0029: ldarg.0
    IL_002E: ldstr 0x70022774
    IL_0033: call 0x0A0001C1
    IL_0038: stfld 0x04000DE0
    IL_0039: ldarg.0
    IL_003E: ldstr 0x7002270C
    IL_0043: call 0x0A0001C1
    IL_0048: stfld 0x04000DE1
    IL_0049: ldarg.0
    IL_004E: call 0x0A00002B
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000DE0
    IL_0055: conv.r8
    IL_0056: IL_C9
    IL_0057: IL_01
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000DE1
    IL_0064: call 0x0A0001C2
    IL_0065: ldarg.0
    IL_006A: ldstr 0x70000BB3
    IL_006F: call 0x0A000095
    IL_0074: stfld 0x04000DE2
    IL_0079: ldsfld 0x040007B2
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000DE2
    IL_0080: ldc.i4.1
    IL_0085: call 0x0A0000E1
    IL_0086: stloc.0
    IL_0087: IL_DD
    IL_0088: ldc.i4.7
    IL_0089: nop
    IL_008A: nop
    IL_008B: nop
    IL_008C: stloc.1
    IL_008D: ldarg.0
    IL_008E: ldc.i4.0
    IL_0093: stfld 0x04000DE2
    IL_0098: ldstr 0x70000BB3
    IL_0099: ldarg.0
    IL_009E: ldfld 0x04000DE2
    IL_00A3: call 0x0A00009F
    IL_00A4: IL_DD
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: nop
    IL_00AD: call 0x060001EF
    IL_00AE: conv.r8
    IL_00AF: IL_F5
    IL_00B0: IL_01
    IL_00B1: nop
    IL_00B2: ldloc.0
    IL_00B3: stloc.2
    IL_00B4: ldloc.2
    IL_00B9: ldstr 0x70000A3D
    IL_00BE: call 0x0A0000EC
    IL_00C3: brfalse IL_00CE
    IL_00C8: call 0x0600004E
    IL_00C9: conv.r8
    IL_00CA: mul
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: ldloc.0
    IL_00D2: br IL_0134
    IL_00D7: call 0x060001EF
    IL_00D8: conv.r8
    IL_00D9: IL_F5
    IL_00DA: IL_01
    IL_00DB: nop
    IL_00DC: ldloc.0
    IL_00DD: stloc.3
    IL_00DE: ldloc.3
    IL_00E3: ldstr 0x70000A3D
    IL_00E8: call 0x0A0000EC
    IL_00ED: brfalse IL_00F8
    IL_00F2: call 0x0600004E
    IL_00F3: conv.r8
    IL_00F4: mul
    IL_00F5: nop
    IL_00F6: nop
    IL_00F7: ldloc.0
    IL_00F8: ldarg.0
    IL_00F9: ldc.i4.1
    IL_00FE: stfld 0x04000DE2
    IL_0103: ldstr 0x70000BB3
    IL_0104: ldarg.0
    IL_0109: ldfld 0x04000DE2
    IL_010E: call 0x0A00009F
    IL_010F: ldloc.3
    IL_0114: ldstr 0x700009B3
    IL_0119: call 0x0A0000EC
    IL_011E: brfalse IL_0134
    IL_011F: ldarg.0
    IL_0124: call 0x0A00002B
    IL_0129: ldstr 0x70022774
    IL_012E: call 0x0A0001C1
    IL_012F: conv.r8
    IL_0130: IL_C9
    IL_0131: IL_01
    IL_0132: nop
    IL_0133: stloc.0
    IL_0138: ldstr 0x70023F1D
    IL_013D: call 0x0A000012
    IL_013E: conv.u8
    IL_013F: IL_91
    IL_0140: nop
    IL_0141: nop
    IL_0142: IL_01
    IL_0144: stloc.s 4
    IL_0145: ldarg.0
    IL_0147: ldloc.s 4
    IL_0148: conv.r8
    IL_0149: IL_EC
    IL_014A: ldarg.0
    IL_014B: nop
    IL_014C: stloc.0
    IL_0151: stfld 0x04000E18
    IL_0156: ldstr 0x700026F3
    IL_015B: call 0x06000220
    IL_015D: stloc.s 5
    IL_015E: IL_DD
    IL_0160: ldloca.s 0
    IL_0161: nop
    IL_0162: nop
    IL_0164: stloc.s 6
    IL_0169: ldstr 0x700026F3
    IL_016A: ldc.i4.0
    IL_016F: call 0x0600021F
    IL_0170: IL_DD
    IL_0171: nop
    IL_0172: nop
    IL_0173: nop
    IL_0174: nop
    IL_0179: call 0x0600004E
    IL_017A: conv.r8
    IL_017B: shr
    IL_017C: nop
    IL_017D: nop
    IL_017E: ldloc.0
    IL_0183: ldstr 0x70000617
    IL_0184: ldc.i4.0
    IL_0189: call 0x0A00009F
    IL_018A: ret
    }

    private void OnApplicationPause() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0007
    IL_0006: ret
    IL_0007: ret
    }

    public void CGPButtonLoadStart() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0007: call 0x0600068A
    IL_000C: call 0x0A000047
    IL_000D: pop
    IL_000E: ret
    }

    public void GetCGPReward() {
    IL_0000: ldarg.1
    IL_0005: ldstr 0x70023F35
    IL_000A: call 0x0A0000EC
    IL_000F: brfalse IL_001D
    IL_0010: ldarg.2
    IL_0011: ldc.i4.0
    IL_0016: call 0x0600021E
    IL_0017: pop
    IL_001C: br IL_0035
    IL_001D: ldarg.1
    IL_0022: ldstr 0x70023F3F
    IL_0027: call 0x0A0000EC
    IL_002C: brfalse IL_0035
    IL_002D: ldarg.2
    IL_002E: ldc.i4.1
    IL_0033: call 0x0600021E
    IL_0034: pop
    IL_0035: ret
    }

    private void ImageLoading() {
    IL_0004: newobj 0x060007CF
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x040010AA
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x040010AE
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_001A: stfld 0x040010AF
    IL_001B: ldloc.0
    IL_001C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DE3
    IL_000A: brfalse IL_002C
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000E15
    IL_0016: call 0x0A00017C
    IL_001B: call 0x0A000024
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_320A16923: switch (3358087744 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0056
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000DDF
    IL_0010: brtrue IL_0031
    IL_0011: ldarg.0
    IL_0016: call 0x0600068D
    IL_001B: ldstr 0x70022F5F
    IL_001C: ldc.i4.0
    IL_0021: call 0x0600021F
    IL_0026: ldstr 0x70000DC1
    IL_002B: call 0x0A000128
    IL_0030: br IL_0051
    IL_0031: ldarg.0
    IL_0036: call 0x0600068F
    IL_003B: brfalse IL_0051
    IL_0040: ldstr 0x70022F5F
    IL_0041: ldc.i4.0
    IL_0046: call 0x0600021F
    IL_004B: ldstr 0x70022F87
    IL_0050: call 0x0A000128
    IL_0055: br IL_00A8
    IL_0056: ldarg.1
    IL_0057: ldc.i4.1
    IL_0188: switch (75 cases)
    }

    public void InitStat() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000DDF
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_001C
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000E16
    IL_0014: ldloc.0
    IL_0016: ldc.i4.s -2
    IL_0017: ldelem.i8
    IL_0018: ldloc.0
    IL_0019: ldc.i4.1
    IL_001A: IL_58
    IL_001B: stloc.0
    IL_001C: ldloc.0
    IL_001E: ldc.i4.s 20
    IL_001F: IL_3F
    IL_0020: IL_EA
    IL_0021: IL_FF
    IL_0022: IL_FF
    IL_0023: IL_FF
    IL_0028: ldstr 0x700004AB
    IL_0029: ldc.i4.1
    IL_002E: call 0x0A00009F
    IL_0033: ldstr 0x70023F55
    IL_0038: ldstr 0x70023F63
    IL_003D: call 0x0A00008F
    IL_0042: ldstr 0x7002270C
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_004A: stsfld 0x0255283F
    IL_004B: nop
    IL_004C: stloc.0
    IL_0051: ldstr 0x70022774
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0059: stsfld 0x0255283F
    IL_005A: nop
    IL_005B: stloc.0
    IL_0060: ldstr 0x70000575
    IL_0065: ldstr 0x70022ADA
    IL_006A: call 0x0A00008F
    IL_006F: ldstr 0x70000541
    IL_0070: ldc.i4.0
    IL_0075: call 0x0A00009F
    IL_007A: ldstr 0x70001E7D
    IL_007B: ldc.i4.0
    IL_0080: call 0x0600021F
    IL_0085: ldstr 0x70001E8B
    IL_0086: ldc.i4.0
    IL_008B: call 0x0600021F
    IL_0090: ldstr 0x70000B7F
    IL_0091: IL_22
    IL_0092: nop
    IL_0093: nop
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_22
    IL_0097: ldelem.i
    IL_0098: IL_99
    IL_0099: ldc.i4.3
    IL_009A: IL_3F
    IL_009B: IL_22
    IL_009C: nop
    IL_009D: nop
    IL_00A2: stsfld 0x0076733F
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A9: call 0x060003F3
    IL_00AA: pop
    IL_00AF: ldstr 0x70000C8F
    IL_00B4: call 0x0A00001B
    IL_00B9: call 0x060003F3
    IL_00BA: pop
    IL_00BF: ldstr 0x70022F71
    IL_00C0: ldc.i4.0
    IL_00C5: call 0x0A00009F
    IL_00CA: ldstr 0x70000DDD
    IL_00CB: ldc.i4.1
    IL_00D0: call 0x0600021F
    IL_00D5: ldstr 0x70000DE5
    IL_00D6: ldc.i4.0
    IL_00DB: call 0x0600021F
    IL_00E0: ldstr 0x70001EA5
    IL_00E5: ldc.i4 1200
    IL_00EA: call 0x0600021F
    IL_00EF: ldstr 0x700004D5
    IL_00F0: ldc.i4.5
    IL_00F5: call 0x0600021F
    IL_00FA: ldstr 0x70001EAD
    IL_00FB: ldc.i4.4
    IL_0100: call 0x0600021F
    IL_0105: ldstr 0x70001EB5
    IL_0106: ldc.i4.3
    IL_010B: call 0x0600021F
    IL_0110: ldstr 0x70001EBD
    IL_0111: ldc.i4.3
    IL_0116: call 0x0600021F
    IL_011B: ldstr 0x700004DD
    IL_011C: ldc.i4.m1
    IL_0121: call 0x0600021F
    IL_0126: ldstr 0x7000066F
    IL_0127: ldc.i4.5
    IL_012C: call 0x0600021F
    IL_0131: ldstr 0x70001EC5
    IL_0132: ldc.i4.1
    IL_0137: call 0x0600021F
    IL_013C: ldstr 0x70001ECD
    IL_013D: ldc.i4.3
    IL_0142: call 0x0600021F
    IL_0147: ldstr 0x70001ED5
    IL_0148: ldc.i4.0
    IL_014D: call 0x0600021F
    IL_0152: ldstr 0x70001EDD
    IL_0154: ldc.i4.s 90
    IL_0159: newarr 0x0100000B
    IL_015E: call 0x060003F8
    IL_015F: pop
    IL_0164: ldstr 0x70001EE5
    IL_0166: ldc.i4.s 20
    IL_016B: newarr 0x0100000B
    IL_0170: call 0x060003F8
    IL_0171: pop
    IL_0176: ldstr 0x70001EED
    IL_0178: ldc.i4.s 20
    IL_017D: newarr 0x0100000B
    IL_0182: call 0x060003F8
    IL_0183: pop
    IL_0188: ldstr 0x70001EF5
    IL_0189: ldc.i4.6
    IL_018E: newarr 0x0100000B
    IL_0193: call 0x060003F8
    IL_0194: pop
    IL_0199: ldstr 0x7000054F
    IL_019A: ldarg.0
    IL_019F: ldfld 0x04000E16
    IL_01A4: call 0x060003F8
    IL_01A5: pop
    IL_01AA: ldstr 0x70001EFD
    IL_01AB: ldc.i4.2
    IL_01B0: newarr 0x0100000B
    IL_01B5: call 0x060003F8
    IL_01B6: pop
    IL_01BB: ldstr 0x70001F05
    IL_01BC: ldc.i4.2
    IL_01C1: newarr 0x0100000B
    IL_01C6: call 0x060003F8
    IL_01C7: pop
    IL_01CC: ldstr 0x70001F0D
    IL_01CD: ldc.i4.2
    IL_01D2: newarr 0x0100000B
    IL_01D7: call 0x060003F8
    IL_01D8: pop
    IL_01DD: ldstr 0x70000E0D
    IL_01DE: ldc.i4.1
    IL_01E3: call 0x0600021F
    IL_01E8: ldstr 0x70000E05
    IL_01E9: ldc.i4.1
    IL_01EE: call 0x0600021F
    IL_01F3: ldstr 0x70000E25
    IL_01F4: ldc.i4.1
    IL_01F9: call 0x0600021F
    IL_01FE: ldstr 0x70000E15
    IL_0200: ldc.i4.s 100
    IL_0205: call 0x0600021F
    IL_020A: ldstr 0x70000E1D
    IL_020B: ldc.i4.1
    IL_0210: call 0x0600021F
    IL_0215: ldstr 0x70000E2D
    IL_0216: ldc.i4.5
    IL_021B: call 0x0600021F
    IL_0220: ldstr 0x70000DD5
    IL_0221: ldc.i4.0
    IL_0226: call 0x0600021F
    IL_022B: ldstr 0x70000DB9
    IL_022C: ldc.i4.0
    IL_0231: call 0x0600021F
    IL_0236: ldstr 0x700017DB
    IL_0237: ldc.i4.0
    IL_023C: call 0x0600021F
    IL_0241: ldstr 0x70001F15
    IL_0243: ldc.i4.s 12
    IL_0248: newarr 0x0100000B
    IL_0249: dup
    IL_024A: ldc.i4.0
    IL_024F: ldc.i4 12707979
    IL_0250: ldelem.i8
    IL_0255: call 0x060003F8
    IL_0256: pop
    IL_025B: ldstr 0x70001F1D
    IL_025D: ldc.i4.s 12
    IL_0262: newarr 0x0100000B
    IL_0263: dup
    IL_0264: ldc.i4.0
    IL_0266: ldc.i4.s 100
    IL_0267: ldelem.i8
    IL_026C: call 0x060003F8
    IL_026D: pop
    IL_0272: ldstr 0x70001F25
    IL_0274: ldc.i4.s 12
    IL_0279: newarr 0x0100000B
    IL_027E: call 0x060003F8
    IL_027F: pop
    IL_0284: ldstr 0x70000DCD
    IL_0285: ldc.i4.6
    IL_028A: newarr 0x0100000B
    IL_028F: call 0x060003F8
    IL_0290: pop
    IL_0295: ldstr 0x70001F2D
    IL_0296: ldc.i4.0
    IL_029B: call 0x0600021F
    IL_02A0: ldstr 0x700014B5
    IL_02A1: ldc.i4.0
    IL_02A6: call 0x0600021F
    IL_02AB: ldstr 0x70000DED
    IL_02AD: ldc.i4.s 10
    IL_02B2: call 0x0600021F
    IL_02B7: ldstr 0x70000DF5
    IL_02B8: ldc.i4.8
    IL_02BD: call 0x0600021F
    IL_02C2: ldstr 0x70000DFD
    IL_02C3: ldc.i4.2
    IL_02C8: call 0x0600021F
    IL_02CD: ldstr 0x700014BD
    IL_02CE: ldc.i4.0
    IL_02D3: call 0x0600021F
    IL_02D8: ldstr 0x70000CDD
    IL_02D9: ldc.i4.0
    IL_02DE: call 0x0600021F
    IL_02E3: ldstr 0x70000BDB
    IL_02E4: ldc.i4.0
    IL_02E9: call 0x0600021F
    IL_02EE: ldstr 0x70001F45
    IL_02EF: ldc.i4.m1
    IL_02F4: call 0x0600021F
    IL_02F9: ldstr 0x70001F4D
    IL_02FA: ldc.i4.3
    IL_02FF: call 0x0600021F
    IL_0304: ldstr 0x70023247
    IL_0305: ldc.i4.1
    IL_030A: call 0x0600021F
    IL_030F: ldstr 0x70022DD9
    IL_0310: ldc.i4.1
    IL_0315: call 0x0600021F
    IL_031A: ldstr 0x700026F3
    IL_031B: ldc.i4.0
    IL_0320: call 0x0600021F
    IL_0325: ldstr 0x700028DD
    IL_0326: ldc.i4.3
    IL_032B: newarr 0x0100000B
    IL_0330: call 0x060003F8
    IL_0331: pop
    IL_0336: ldstr 0x7002305B
    IL_0337: ldc.i4.2
    IL_033C: newarr 0x0100000B
    IL_0341: call 0x060003F8
    IL_0342: pop
    IL_0347: ldstr 0x7002323F
    IL_0349: ldc.i4.s 100
    IL_034E: newarr 0x0100000B
    IL_0353: call 0x060003F8
    IL_0354: pop
    IL_0359: ldstr 0x700236FF
    IL_035B: ldc.i4.s 50
    IL_0360: newarr 0x0100000B
    IL_0365: call 0x060003F8
    IL_0366: pop
    IL_036B: ldstr 0x7002324F
    IL_036C: ldc.i4.0
    IL_0371: call 0x0600021F
    IL_0376: ldstr 0x70024004
    IL_0377: ldc.i4.0
    IL_037C: call 0x0600021F
    IL_0381: ldstr 0x7002400C
    IL_0382: ldc.i4.0
    IL_0387: call 0x0600021F
    IL_038C: ldstr 0x70023257
    IL_038D: ldc.i4.0
    IL_0392: call 0x0600021F
    IL_0397: ldstr 0x7002325F
    IL_0398: ldc.i4.0
    IL_039D: call 0x0600021F
    IL_03A2: ldstr 0x7000000F
    IL_03A3: ldc.i4.0
    IL_03A8: call 0x0600021F
    IL_03AD: ldstr 0x70001F55
    IL_03AE: ldc.i4.0
    IL_03B3: call 0x0600021F
    IL_03B8: ldstr 0x70001F71
    IL_03B9: ldc.i4.0
    IL_03BE: call 0x0600021F
    IL_03C3: ldstr 0x70001F83
    IL_03C4: ldc.i4.0
    IL_03C9: call 0x0600021F
    IL_03CE: ldstr 0x70001F9B
    IL_03CF: ldc.i4.5
    IL_03D4: newarr 0x0100000B
    IL_03D5: dup
    IL_03DA: ldtoken 0x040010CE
    IL_03DF: call 0x0A00018C
    IL_03E4: call 0x060003F8
    IL_03E5: pop
    IL_03EA: ldstr 0x70001FB1
    IL_03EC: ldc.i4.s 26
    IL_03F1: newarr 0x0100000B
    IL_03F2: dup
    IL_03F7: ldtoken 0x040010CF
    IL_03FC: call 0x0A00018C
    IL_0401: call 0x060003F8
    IL_0402: pop
    IL_0407: ldstr 0x70001563
    IL_0409: ldc.i4.s 26
    IL_040E: newarr 0x0100000B
    IL_040F: dup
    IL_0414: ldtoken 0x040010D0
    IL_0419: call 0x0A00018C
    IL_041E: call 0x060003F8
    IL_041F: pop
    IL_0424: ldstr 0x70001FB9
    IL_0426: ldc.i4.s 26
    IL_042B: newarr 0x0100000B
    IL_0430: call 0x060003F8
    IL_0431: pop
    IL_0436: ldstr 0x70000667
    IL_0437: ldc.i4.5
    IL_043C: newarr 0x0100000B
    IL_043D: dup
    IL_043E: ldc.i4.0
    IL_043F: ldc.i4.1
    IL_0440: ldelem.i8
    IL_0445: call 0x060003F8
    IL_0446: pop
    IL_044B: ldstr 0x70001FC1
    IL_044D: ldc.i4.s 24
    IL_0452: newarr 0x0100000B
    IL_0457: call 0x060003F8
    IL_0458: pop
    IL_045D: ldstr 0x70001FD3
    IL_045F: ldc.i4.s 30
    IL_0464: newarr 0x0100000B
    IL_0465: dup
    IL_0467: ldc.i4.s 27
    IL_0468: ldc.i4.1
    IL_0469: ldelem.i8
    IL_046E: call 0x060003F8
    IL_046F: pop
    IL_0474: ldstr 0x70001FDF
    IL_0476: ldc.i4.s 76
    IL_047B: newarr 0x0100000B
    IL_0480: call 0x060003F8
    IL_0481: pop
    IL_0486: ldstr 0x70001FEF
    IL_0488: ldc.i4.s 12
    IL_048D: newarr 0x0100000B
    IL_0492: call 0x060003F8
    IL_0493: pop
    IL_0498: ldstr 0x70002001
    IL_049A: ldc.i4.s 20
    IL_049F: newarr 0x0100000B
    IL_04A4: call 0x060003F8
    IL_04A5: pop
    IL_04AA: ldstr 0x70002015
    IL_04AB: ldc.i4.2
    IL_04B0: newarr 0x0100000B
    IL_04B5: call 0x060003F8
    IL_04B6: pop
    IL_04BB: ldstr 0x70002031
    IL_04BC: ldc.i4.0
    IL_04C1: call 0x0600021F
    IL_04C6: ldstr 0x70002045
    IL_04C7: ldc.i4.0
    IL_04CC: call 0x0600021F
    IL_04D1: ldstr 0x70000EC9
    IL_04D2: ldc.i4.0
    IL_04D7: call 0x0600021F
    IL_04DC: ldstr 0x70002059
    IL_04DD: ldc.i4.0
    IL_04E2: call 0x0600021F
    IL_04E7: ldstr 0x700015BF
    IL_04E8: ldc.i4.0
    IL_04ED: call 0x0600021F
    IL_04F2: ldstr 0x70002065
    IL_04F3: ldc.i4.0
    IL_04F8: call 0x0600021F
    IL_04FD: ldstr 0x7000207D
    IL_04FE: ldc.i4.2
    IL_0503: call 0x0600021F
    IL_0508: ldstr 0x70002093
    IL_0509: ldc.i4.0
    IL_050E: call 0x0600021F
    IL_0513: ldstr 0x700020A5
    IL_0514: ldc.i4.0
    IL_0519: call 0x0600021F
    IL_051E: call 0x0600056D
    IL_0523: call 0x0600056A
    IL_0528: call 0x0600040C
    IL_052D: ldstr 0x70000541
    IL_052E: ldc.i4.0
    IL_0533: call 0x0A00009F
    IL_0538: ldstr 0x70000541
    IL_053D: call 0x0A000095
    IL_0542: newobj 0x0100000B
    IL_0547: call 0x0A00013D
    IL_054C: ldstr 0x7000263B
    IL_0551: ldsfld 0x0A000099
    IL_0556: call 0x0A00008F
    IL_055B: ldstr 0x70002687
    IL_0560: ldstr 0x70001671
    IL_0565: call 0x06000221
    IL_056A: ldstr 0x700026AB
    IL_056F: ldstr 0x70001671
    IL_0574: call 0x06000221
    IL_0579: ldstr 0x7000269B
    IL_057E: ldstr 0x7002341D
    IL_0583: call 0x06000221
    IL_0588: ldstr 0x7000052B
    IL_0589: ldc.i4.0
    IL_058E: call 0x0A00009F
    IL_058F: ldarg.0
    IL_0590: ldc.i4.0
    IL_0595: stfld 0x04000E12
    IL_0596: ret
    }

    public void StartGUI() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000DE3
    IL_0007: ret
    }

    public void SetVersionStart() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DDF
    IL_0006: ldc.i4.3
    IL_0007: IL_3C
    IL_0008: mul
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_000D: ldc.i4.3
    IL_0012: stfld 0x04000DDF
    IL_0017: ldstr 0x70001F4D
    IL_0018: ldc.i4.3
    IL_001D: call 0x0600021F
    IL_0022: ldstr 0x70022F71
    IL_0023: ldc.i4.3
    IL_0028: call 0x0A00009F
    IL_002D: ldstr 0x70024014
    IL_0032: call 0x06000220
    IL_0033: stloc.0
    IL_0034: ldloc.0
    IL_0036: ldc.i4.s 99
    IL_0037: IL_3E
    IL_0038: ldc.i4.1
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003D: ldc.i4.s 99
    IL_003E: ldloc.0
    IL_0040: ldc.i4.s 99
    IL_0041: IL_59
    IL_0043: ldc.i4.s 100
    IL_0044: add
    IL_0045: IL_58
    IL_0046: stloc.0
    IL_0047: ldloc.0
    IL_004C: ldc.i4 199
    IL_0051: call 0x0A00010B
    IL_0052: stloc.0
    IL_0057: ldstr 0x70000DDD
    IL_0058: ldloc.0
    IL_005D: call 0x0600021F
    IL_0062: ldstr 0x7000052B
    IL_0063: ldc.i4.1
    IL_0068: call 0x0A00009F
    IL_0069: ldarg.0
    IL_006E: ldfld 0x04000DDF
    IL_006F: ldc.i4.4
    IL_0070: IL_3C
    IL_0071: IL_C5
    IL_0072: nop
    IL_0073: nop
    IL_0074: nop
    IL_0075: ldarg.0
    IL_0076: ldc.i4.4
    IL_007B: stfld 0x04000DDF
    IL_0080: ldstr 0x70023247
    IL_0081: ldc.i4.1
    IL_0086: call 0x0600021F
    IL_008B: ldstr 0x70022DD9
    IL_008C: ldc.i4.1
    IL_0091: call 0x0600021F
    IL_0096: ldstr 0x700028DD
    IL_0097: ldc.i4.3
    IL_009C: newarr 0x0100000B
    IL_00A1: call 0x060003F8
    IL_00A2: pop
    IL_00A7: ldstr 0x7002305B
    IL_00A8: ldc.i4.2
    IL_00AD: newarr 0x0100000B
    IL_00B2: call 0x060003F8
    IL_00B3: pop
    IL_00B8: ldstr 0x70000C8F
    IL_00BD: call 0x0A00001B
    IL_00C2: call 0x060003F3
    IL_00C3: pop
    IL_00C8: ldstr 0x7002323F
    IL_00CA: ldc.i4.s 100
    IL_00CF: newarr 0x0100000B
    IL_00D4: call 0x060003F8
    IL_00D5: pop
    IL_00DA: ldstr 0x700236FF
    IL_00DC: ldc.i4.s 50
    IL_00E1: newarr 0x0100000B
    IL_00E6: call 0x060003F8
    IL_00E7: pop
    IL_00EC: ldstr 0x7002324F
    IL_00ED: ldc.i4.0
    IL_00F2: call 0x0600021F
    IL_00F7: ldstr 0x70024004
    IL_00F8: ldc.i4.0
    IL_00FD: call 0x0600021F
    IL_0102: ldstr 0x7002400C
    IL_0103: ldc.i4.0
    IL_0108: call 0x0600021F
    IL_010D: ldstr 0x70023257
    IL_010E: ldc.i4.0
    IL_0113: call 0x0600021F
    IL_0118: ldstr 0x7002325F
    IL_0119: ldc.i4.0
    IL_011E: call 0x0600021F
    IL_0123: call 0x0600056D
    IL_0128: ldstr 0x70022F71
    IL_0129: ldc.i4.4
    IL_012E: call 0x0A00009F
    IL_0133: ldstr 0x70022F71
    IL_0134: ldc.i4.4
    IL_0139: call 0x0A00009F
    IL_013A: ldarg.0
    IL_013F: ldfld 0x04000DDF
    IL_0140: ldc.i4.6
    IL_0141: IL_3C
    IL_0142: IL_C9
    IL_0143: nop
    IL_0144: nop
    IL_0145: nop
    IL_014A: ldstr 0x70023247
    IL_014B: ldc.i4.1
    IL_0150: call 0x0600021F
    IL_0155: ldstr 0x70022DD9
    IL_0156: ldc.i4.1
    IL_015B: call 0x0600021F
    IL_0160: ldstr 0x700028DD
    IL_0161: ldc.i4.3
    IL_0166: newarr 0x0100000B
    IL_016B: call 0x060003F8
    IL_016C: pop
    IL_0171: ldstr 0x7002305B
    IL_0172: ldc.i4.2
    IL_0177: newarr 0x0100000B
    IL_017C: call 0x060003F8
    IL_017D: pop
    IL_0182: ldstr 0x70000C8F
    IL_0187: call 0x0A00001B
    IL_018C: call 0x060003F3
    IL_018D: pop
    IL_0192: ldstr 0x7002323F
    IL_0194: ldc.i4.s 100
    IL_0199: newarr 0x0100000B
    IL_019E: call 0x060003F8
    IL_019F: pop
    IL_01A4: ldstr 0x700236FF
    IL_01A6: ldc.i4.s 50
    IL_01AB: newarr 0x0100000B
    IL_01B0: call 0x060003F8
    IL_01B1: pop
    IL_01B6: ldstr 0x7002324F
    IL_01B7: ldc.i4.0
    IL_01BC: call 0x0600021F
    IL_01C1: ldstr 0x70024004
    IL_01C2: ldc.i4.0
    IL_01C7: call 0x0600021F
    IL_01CC: ldstr 0x7002400C
    IL_01CD: ldc.i4.0
    IL_01D2: call 0x0600021F
    IL_01D7: ldstr 0x70023257
    IL_01D8: ldc.i4.0
    IL_01DD: call 0x0600021F
    IL_01E2: ldstr 0x7002325F
    IL_01E3: ldc.i4.0
    IL_01E8: call 0x0600021F
    IL_01ED: ldstr 0x7000000F
    IL_01EE: ldc.i4.0
    IL_01F3: call 0x0600021F
    IL_01F8: ldstr 0x70001ECD
    IL_01F9: ldc.i4.3
    IL_01FE: call 0x0600021F
    IL_0203: call 0x0600056D
    IL_0208: ldstr 0x70022F71
    IL_0209: ldc.i4.6
    IL_020E: call 0x0A00009F
    IL_0213: call 0x0600056A
    IL_0214: ldc.i4.1
    IL_0215: ret
    }

    public void ItemDelivery() {
    IL_0000: ldc.i4.7
    IL_0005: newarr 0x0100000C
    IL_0006: dup
    IL_0007: ldc.i4.0
    IL_000C: ldstr 0x7002401C
    IL_0011: stelem 0x28721725
    IL_9689C01E: switch (631402498 cases)
    }

    private void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000E19
    IL_0007: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000E06
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000DE3
    IL_004B: brtrue IL_004D
    IL_004C: ret
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000E19
    IL_0053: ldc.i4.0
    IL_0054: IL_3E
    IL_0055: ldloc.0
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: ldc.i4.0
    IL_005E: call 0x0A0001B9
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000E15
    IL_0069: call 0x0A0000F0
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_D8
    IL_006E: IL_42
    IL_006F: IL_22
    IL_0070: nop
    IL_0071: nop
    IL_0072: IL_C0
    IL_2000000FF: switch (2147483682 cases)
    }

    private void getTexture() {
    IL_0000: ldarg.1
    IL_0002: ldc.i4.s 49
    IL_0023: switch (7 cases)
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000DFB
    IL_002C: ret
    IL_002D: ldarg.1
    IL_002F: ldc.i4.s 52
    IL_0050: switch (7 cases)
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000DFE
    IL_0059: ret
    IL_005A: ldarg.1
    IL_005C: ldc.i4.s 55
    IL_007D: switch (7 cases)
    IL_007E: nop
    IL_007F: nop
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000E01
    IL_0086: ret
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000DF8
    IL_008D: ret
    }

    private static void ValidateMobile() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00020C
    IL_000A: brfalse IL_000D
    IL_000B: ldc.i4.0
    IL_000C: ret
    IL_000D: ldarg.0
    IL_0012: ldstr 0x70024074
    IL_0017: call 0x0A00031D
    IL_0018: ret
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_000A: ldstr 0x70022774
    IL_000F: call 0x0A0001C1
    IL_0010: conv.r8
    IL_0011: IL_C9
    IL_0012: IL_01
    IL_0013: nop
    IL_0014: stloc.0
    IL_0015: ret
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000E34
    IL_000C: ldarg.0
    IL_000D: ldc.i4.5
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000E3B
    IL_0018: ldarg.0
    IL_0019: ldc.i4.5
    IL_001E: newarr 0x0100003C
    IL_0023: stfld 0x04000E49
    IL_0024: ldarg.0
    IL_0025: ldc.i4.5
    IL_002A: newarr 0x0100003C
    IL_002F: stfld 0x04000E4A
    IL_0030: ldarg.0
    IL_0031: ldc.i4.2
    IL_0036: newarr 0x0100003C
    IL_003B: stfld 0x04000E4D
    IL_003C: ldarg.0
    IL_003D: ldc.i4.5
    IL_0042: newarr 0x0100003C
    IL_0047: stfld 0x04000E58
    IL_0048: ldarg.0
    IL_0049: ldc.i4.3
    IL_004E: newarr 0x01000003
    IL_0053: stfld 0x04000E5C
    IL_0054: ldarg.0
    IL_0055: ldc.i4.1
    IL_005A: stfld 0x04000E7F
    IL_005B: ldarg.0
    IL_005C: ldc.i4.m1
    IL_0061: stfld 0x04000E96
    IL_0062: ldarg.0
    IL_0063: ldc.i4.m1
    IL_0068: stfld 0x04000E97
    IL_0069: ldarg.0
    IL_006E: ldc.i4 480
    IL_0073: stfld 0x04000E9A
    IL_0074: ldarg.0
    IL_0075: IL_22
    IL_0076: nop
    IL_007B: stsfld 0x9C7D44BB
    IL_007D: ldarg.s 0
    IL_007E: ldarg.2
    IL_007F: ldarg.0
    IL_0081: ldc.i4.s 90
    IL_0086: newarr 0x0100000B
    IL_008B: stfld 0x04000EB6
    IL_008C: ldarg.0
    IL_008E: ldc.i4.s 12
    IL_0093: newarr 0x0100000B
    IL_0098: stfld 0x04000EB7
    IL_0099: ldarg.0
    IL_009A: ldc.i4.m1
    IL_009F: stfld 0x04000EBC
    IL_00A0: ldarg.0
    IL_00A1: ldc.i4.1
    IL_00A6: stfld 0x04000EBE
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4.5
    IL_00AD: newarr 0x0100000B
    IL_00AE: dup
    IL_00B3: ldtoken 0x040010D2
    IL_00B8: call 0x0A00018C
    IL_00BD: stfld 0x04000EBF
    IL_00BE: ldarg.0
    IL_00BF: ldc.i4.2
    IL_00C4: newarr 0x0100000B
    IL_00C9: stfld 0x04000EC0
    IL_00CA: ldarg.0
    IL_00CB: ldc.i4.2
    IL_00D0: newarr 0x0100000B
    IL_00D5: stfld 0x04000EC1
    IL_00D6: ldarg.0
    IL_00D7: ldc.i4.5
    IL_00DC: newarr 0x0100000B
    IL_00E1: stfld 0x04000EC2
    IL_00E2: ldarg.0
    IL_00E3: ldc.i4.m1
    IL_00E8: stfld 0x04000ECA
    IL_00E9: ldarg.0
    IL_00EE: call 0x0A000001
    IL_00EF: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70022774
    IL_000A: call 0x0A0001C1
    IL_000F: stfld 0x04000EAB
    IL_0010: ldarg.0
    IL_0015: ldstr 0x7002270C
    IL_001A: call 0x0A0001C1
    IL_001F: stfld 0x04000EAC
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000EAC
    IL_002A: call 0x0A0001C2
    IL_002F: call 0x0600056A
    IL_0030: ldarg.0
    IL_0035: call 0x0A000035
    IL_0036: conv.r8
    IL_0037: ldarg.0
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003F: stfld 0x04000E76
    IL_0040: ldarg.0
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000E76
    IL_0047: conv.r8
    IL_0048: ldind.ref
    IL_0049: nop
    IL_004A: nop
    IL_004C: br.s IL_00CA
    IL_004D: IL_78
    IL_004F: ldarg.s 0
    IL_0050: ldarg.2
    IL_0051: ldarg.0
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: IL_E0
    IL_0056: IL_42
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: IL_4C
    IL_005B: IL_43
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_0063: stsfld 0x00002243
    IL_0064: IL_C8
    IL_0065: IL_42
    IL_006A: call 0x0600021D
    IL_006F: stfld 0x04000ECF
    IL_0070: ldarg.0
    IL_0075: ldstr 0x70022DCB
    IL_007A: call 0x0A000004
    IL_007B: conv.r8
    IL_0080: stfld 0x7D2B0000
    IL_0085: ldfld 0x0204000E
    IL_008A: ldstr 0x70000557
    IL_008B: ldc.i4.0
    IL_0090: call 0x0A0002BB
    IL_0095: stfld 0x04000ECB
    IL_0096: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x7000066F
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000EA3
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70001EA5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000EA2
    IL_0020: ldarg.0
    IL_0025: ldstr 0x700004D5
    IL_002A: call 0x06000220
    IL_002F: stfld 0x04000EA1
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000E90
    IL_0036: ldc.i4.2
    IL_0037: IL_3F
    IL_0038: IL_3E
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: ldarg.0
    IL_0041: ldfld 0x04000E60
    IL_0046: call 0x0A00004B
    IL_0047: IL_22
    IL_0048: shr
    IL_0049: shr
    IL_004E: isinst 0x00082840
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: conv.r8
    IL_0052: IL_AF
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04000E60
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: nop
    IL_0061: IL_22
    IL_0062: IL_8F
    IL_0063: IL_C2
    IL_0064: conv.u8
    IL_0065: IL_BE
    IL_0066: IL_22
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_3F
    IL_006F: newobj 0x0A000076
    IL_0070: conv.r8
    IL_0071: conv.ovf.i4.un
    IL_0072: IL_01
    IL_0073: nop
    IL_0074: stloc.0
    IL_0079: br IL_0085
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000E78
    IL_0080: conv.r8
    IL_0081: ldnull
    IL_0082: IL_01
    IL_0083: nop
    IL_0084: ldloc.0
    IL_0085: ret
    }

    private void Start() {
    IL_0004: ldstr 0x70023257
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000F: ldstr 0x7002325F
    IL_0014: call 0x06000220
    IL_0015: stloc.1
    IL_0016: ldloc.0
    IL_001B: brfalse IL_0034
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_0022: call 0x0600021E
    IL_0023: pop
    IL_0028: ldstr 0x70023257
    IL_0029: ldc.i4.0
    IL_002E: call 0x0600021F
    IL_0033: br IL_004D
    IL_0034: ldloc.1
    IL_0039: brfalse IL_004D
    IL_003A: ldloc.1
    IL_003B: ldc.i4.0
    IL_0040: call 0x0600021E
    IL_0041: pop
    IL_0046: ldstr 0x7002325F
    IL_0047: ldc.i4.0
    IL_004C: call 0x0600021F
    IL_0051: ldstr 0x700231E5
    IL_0056: call 0x0A000077
    IL_0057: stloc.2
    IL_0058: ldloc.2
    IL_0059: ldnull
    IL_005E: call 0x0A000061
    IL_0063: brfalse IL_00A9
    IL_0068: ldstr 0x700231E5
    IL_006D: call 0x0A000012
    IL_006E: conv.u8
    IL_006F: ldloc.0
    IL_0070: nop
    IL_0071: nop
    IL_0072: IL_01
    IL_0073: stloc.3
    IL_0074: ldarg.0
    IL_0075: ldloc.3
    IL_0076: conv.r8
    IL_0077: ldarg.3
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007F: call 0x0A00001B
    IL_0084: call 0x0A000013
    IL_0089: call 0x0A000014
    IL_008A: conv.u4
    IL_008B: ldarg.1
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_01
    IL_0093: stfld 0x04000E62
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000E62
    IL_009E: ldstr 0x700231E5
    IL_009F: conv.r8
    IL_00A0: IL_DC
    IL_00A1: IL_01
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A8: br IL_00B5
    IL_00A9: ldarg.0
    IL_00AA: ldloc.2
    IL_00AB: conv.r8
    IL_00AC: ldarg.3
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B4: stfld 0x04000E62
    IL_00B5: ldarg.0
    IL_00BA: ldstr 0x70001EDD
    IL_00BF: call 0x060003F9
    IL_00C4: stfld 0x04000EB6
    IL_00C5: ldarg.0
    IL_00C6: ldarg.0
    IL_00CB: call 0x2B000085
    IL_00D0: stfld 0x04000E79
    IL_00D1: ldarg.0
    IL_00D2: ldarg.0
    IL_00D7: call 0x2B000067
    IL_00DC: stfld 0x04000E7A
    IL_00DD: ldarg.0
    IL_00E2: ldstr 0x70000BB3
    IL_00E7: call 0x0A000095
    IL_00EC: stfld 0x04000EA8
    IL_00ED: ldarg.0
    IL_00F2: ldstr 0x70002093
    IL_00F7: call 0x06000220
    IL_00FC: stfld 0x04000ECA
    IL_00FD: ldarg.0
    IL_0102: ldstr 0x70000DDD
    IL_0107: call 0x06000220
    IL_010C: stfld 0x04000EBB
    IL_010D: ldarg.0
    IL_0112: ldstr 0x70000DE5
    IL_0117: call 0x06000220
    IL_011C: stfld 0x04000ECE
    IL_011D: ldarg.0
    IL_0122: ldstr 0x70001F9B
    IL_0127: call 0x060003F9
    IL_012C: stfld 0x04000EC2
    IL_012D: ldarg.0
    IL_0132: ldstr 0x70001EAD
    IL_0137: call 0x06000220
    IL_013C: stfld 0x04000EA7
    IL_013D: ldarg.0
    IL_0142: ldstr 0x70001F0D
    IL_0147: call 0x060003F9
    IL_014C: stfld 0x04000EC1
    IL_014D: ldarg.0
    IL_0152: ldstr 0x700004DD
    IL_0157: call 0x06000220
    IL_015C: stfld 0x04000E93
    IL_015D: ldarg.0
    IL_0162: ldstr 0x7000207D
    IL_0167: call 0x06000220
    IL_016C: stfld 0x04000E8C
    IL_016D: ldarg.0
    IL_0172: ldstr 0x70001F2D
    IL_0177: call 0x06000220
    IL_017C: stfld 0x04000E96
    IL_017D: ldarg.0
    IL_0182: ldstr 0x70001F15
    IL_0187: call 0x060003F9
    IL_018C: stfld 0x04000EB7
    IL_018D: ldarg.0
    IL_0192: ldfld 0x04000E96
    IL_0193: ldc.i4.0
    IL_0194: IL_3F
    IL_0199: call 0x72000000
    IL_019A: ldc.i4.7
    IL_019C: ldc.i4.s 0
    IL_01A1: cpobj 0x0003F928
    IL_01A2: ldloc.0
    IL_01A4: stloc.s 4
    IL_01A5: ldarg.0
    IL_01A7: ldloc.s 4
    IL_01A8: ldarg.0
    IL_01AD: ldfld 0x04000E96
    IL_01AE: IL_94
    IL_01B3: stfld 0x04000EB8
    IL_01B4: ldarg.0
    IL_01B9: call 0x0600069D
    IL_01BA: ldarg.0
    IL_01BB: ldc.i4.1
    IL_01C0: call 0x0600069C
    IL_01C1: ldarg.0
    IL_01C2: ldarg.0
    IL_01C7: ldfld 0x04000ECE
    IL_01C8: conv.i2
    IL_01C9: ldarg.0
    IL_01CE: ldfld 0x04000EBB
    IL_01D0: ldc.i4.s 100
    IL_01D1: IL_5A
    IL_01D2: conv.i2
    IL_01D3: add
    IL_01D4: IL_22
    IL_01D5: nop
    IL_01D6: nop
    IL_01D9: ldloc 23106
    IL_01DE: stfld 0x04000EBD
    IL_01DF: ldc.i4.0
    IL_01E1: stloc.s 5
    IL_01E6: br IL_022D
    IL_01E7: ldarg.0
    IL_01EC: ldfld 0x04000EC2
    IL_01EE: ldloc.s 5
    IL_01EF: IL_94
    IL_01F0: ldc.i4.0
    IL_01F1: IL_3F
    IL_01F3: ble.s IL_01F4
    IL_01F4: nop
    IL_01F5: nop
    IL_01F6: ldarg.0
    IL_01FB: ldfld 0x04000E3B
    IL_01FD: ldloc.s 5
    IL_0202: ldstr 0x700232C3
    IL_0203: ldarg.0
    IL_0208: ldfld 0x04000EC2
    IL_020A: ldloc.s 5
    IL_020B: IL_94
    IL_020C: ldc.i4.1
    IL_020D: IL_58
    IL_020F: stloc.s 10
    IL_0211: ldloca.s 10
    IL_0216: call 0x0A000010
    IL_021B: call 0x0A000011
    IL_0220: call 0x0A000012
    IL_0221: conv.u8
    IL_0222: IL_3C
    IL_0223: nop
    IL_0224: nop
    IL_0225: IL_01
    IL_022A: stelem 0x58170511
    IL_022C: stloc.s 5
    IL_022E: ldloc.s 5
    IL_022F: ldc.i4.5
    IL_0230: IL_3F
    IL_0231: IL_B2
    IL_0232: IL_FF
    IL_0233: IL_FF
    IL_0234: IL_FF
    IL_0235: ldarg.0
    IL_023A: ldfld 0x04000E93
    IL_023B: ldc.i4.6
    IL_023C: IL_3E
    IL_023E: br.s IL_023F
    IL_023F: nop
    IL_0240: nop
    IL_0241: ldc.i4.0
    IL_0243: stloc.s 6
    IL_0248: br IL_0264
    IL_0249: ldarg.0
    IL_024E: ldfld 0x04000EC1
    IL_0250: ldloc.s 6
    IL_0251: IL_94
    IL_0256: brtrue IL_025E
    IL_0257: ldarg.0
    IL_0258: ldc.i4.1
    IL_025D: stfld 0x04000E85
    IL_025F: ldloc.s 6
    IL_0260: ldc.i4.1
    IL_0261: IL_58
    IL_0263: stloc.s 6
    IL_0265: ldloc.s 6
    IL_0266: ldc.i4.2
    IL_0267: IL_3F
    IL_0268: IL_DD
    IL_0269: IL_FF
    IL_026A: IL_FF
    IL_026B: IL_FF
    IL_0270: ldstr 0x70000121
    IL_0275: call 0x0A000004
    IL_0276: ldnull
    IL_027B: call 0x0A000061
    IL_0280: brfalse IL_02A6
    IL_0281: ldarg.0
    IL_0282: ldarg.0
    IL_0287: ldfld 0x04000E5D
    IL_028C: call 0x0A00001B
    IL_0291: call 0x0A000013
    IL_0296: call 0x0A000014
    IL_0297: conv.u4
    IL_0298: ldarg.1
    IL_0299: nop
    IL_029A: nop
    IL_029B: IL_01
    IL_02A0: stfld 0x04000E75
    IL_02A5: br IL_02BB
    IL_02A6: ldarg.0
    IL_02AB: ldstr 0x70000121
    IL_02B0: call 0x0A000004
    IL_02B1: conv.r8
    IL_02B2: ldarg.3
    IL_02B3: nop
    IL_02B4: nop
    IL_02B5: stloc.0
    IL_02BA: stfld 0x04000E75
    IL_02BB: ldarg.0
    IL_02C0: ldfld 0x04000E8C
    IL_02C1: ldc.i4.0
    IL_02C2: IL_3E
    IL_02C3: IL_27
    IL_02C4: nop
    IL_02C5: nop
    IL_02C6: nop
    IL_02C7: ldarg.0
    IL_02CC: ldstr 0x700240AA
    IL_02CD: IL_22
    IL_02CE: nop
    IL_02CF: nop
    IL_02D4: stsfld 0x003F283F
    IL_02D5: nop
    IL_02D6: stloc.0
    IL_02D7: ldarg.0
    IL_02D8: ldc.i4.1
    IL_02DD: stfld 0x04000E8D
    IL_02DE: ldarg.0
    IL_02E3: ldfld 0x04000E78
    IL_02E4: conv.r8
    IL_02E6: stloc.s 1
    IL_02E7: nop
    IL_02E8: ldloc.0
    IL_02ED: br IL_030B
    IL_02EE: ldarg.0
    IL_02F3: ldfld 0x04000E93
    IL_02F4: ldc.i4.1
    IL_02F5: IL_3F
    IL_02F7: ldloc.s 0
    IL_02F8: nop
    IL_02F9: nop
    IL_02FA: ldarg.0
    IL_02FB: ldarg.0
    IL_0300: ldfld 0x04000E7B
    IL_0301: conv.r8
    IL_0302: IL_91
    IL_0303: ldarg.1
    IL_0304: nop
    IL_0305: ldloc.0
    IL_030A: stfld 0x04000E87
    IL_030B: ldarg.0
    IL_0310: ldstr 0x70001F45
    IL_0315: call 0x06000220
    IL_031A: stfld 0x04000EBC
    IL_031B: ldarg.0
    IL_0320: ldfld 0x04000ECA
    IL_0321: ldc.i4.5
    IL_0342: switch (7 cases)
    IL_0344: ldloc.s 9
    IL_0345: conv.r8
    IL_034A: brtrue IL_6F0A034B
    IL_034B: ldc.i4.2
    IL_034C: nop
    IL_034D: nop
    IL_034E: stloc.0
    IL_0353: call 0x0A000042
    IL_0354: IL_22
    IL_0355: IL_CD
    IL_0356: IL_CC
    IL_0357: IL_4C
    IL_0358: IL_3E
    IL_035D: call 0x0A000008
    IL_0362: call 0x0A000029
    IL_0367: call 0x0A000007
    IL_0368: IL_22
    IL_0369: IL_EC
    IL_036A: IL_51
    IL_036B: IL_B8
    IL_036C: IL_3D
    IL_0371: call 0x0A000008
    IL_0376: call 0x0A000029
    IL_037B: stfld 0x04000E7D
    IL_037D: ldloc.s 9
    IL_037E: ldarg.0
    IL_0383: ldfld 0x04000E93
    IL_06BC: switch (205 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_00B6: switch (44 cases)
    }

    public void CurGeneralStat() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0041
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000E96
    IL_000C: ldc.i4.m1
    IL_0011: beq IL_003C
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000E7A
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000EB7
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000E96
    IL_0024: IL_94
    IL_0025: conv.r8
    IL_0026: IL_F5
    IL_0027: ldarg.0
    IL_0028: nop
    IL_0029: ldloc.0
    IL_002A: ldarg.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000E7A
    IL_0035: ldfld 0x04000677
    IL_0036: conv.i2
    IL_003B: stfld 0x04000E9C
    IL_0040: br IL_004E
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000EB2
    IL_0048: conv.i2
    IL_004D: stfld 0x04000E9C
    IL_004E: ret
    }

    public void GeneralKindOnly() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000EB7
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000E96
    IL_000C: IL_94
    IL_0011: ldc.i4 10000000
    IL_0012: mul
    IL_0017: ldc.i4 100000
    IL_0018: add
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldstr 0x70022E37
    IL_0020: ldloc.0
    IL_0021: ldc.i4.1
    IL_0022: IL_58
    IL_0023: stloc.1
    IL_0025: ldloca.s 1
    IL_002A: call 0x0A000010
    IL_002F: call 0x0A000011
    IL_0034: call 0x0A000012
    IL_0035: conv.u8
    IL_0036: IL_3C
    IL_0037: nop
    IL_0038: nop
    IL_0039: IL_01
    IL_003E: stfld 0x04000E39
    IL_003F: ret
    }

    public void GeneralStat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000E7A
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_F5
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000E7A
    IL_0017: ldfld 0x04000675
    IL_001C: stfld 0x04000EAE
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000E7A
    IL_0028: ldfld 0x04000676
    IL_002D: stfld 0x04000EAF
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000E7A
    IL_0039: ldfld 0x04000678
    IL_003E: stfld 0x04000EB0
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000E7A
    IL_004A: ldfld 0x04000679
    IL_004F: stfld 0x04000EB1
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000E7A
    IL_005B: ldfld 0x04000677
    IL_0060: stfld 0x04000EB2
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000E7A
    IL_006C: ldfld 0x0400067A
    IL_0071: stfld 0x04000EB5
    IL_0072: ldarg.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000E7A
    IL_007D: ldfld 0x0400067D
    IL_0082: stfld 0x04000EB3
    IL_0083: ldarg.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000E7A
    IL_008E: ldfld 0x0400067C
    IL_0093: stfld 0x04000EB4
    IL_0094: ldarg.2
    IL_0099: brtrue IL_0132
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000EB7
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000E9B
    IL_00A6: IL_94
    IL_00AB: ldc.i4 10000000
    IL_00AC: mul
    IL_00B1: ldc.i4 100000
    IL_00B2: add
    IL_00B3: stloc.0
    IL_00B4: ldarg.0
    IL_00B9: ldstr 0x70022E37
    IL_00BA: ldloc.0
    IL_00BB: ldc.i4.1
    IL_00BC: IL_58
    IL_00BD: stloc.3
    IL_00BF: ldloca.s 3
    IL_00C4: call 0x0A000010
    IL_00C9: call 0x0A000011
    IL_00CE: call 0x0A000012
    IL_00CF: conv.u8
    IL_00D0: IL_3C
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: IL_01
    IL_00D8: stfld 0x04000E3A
    IL_00DD: ldstr 0x70001F1D
    IL_00E2: call 0x060003F9
    IL_00E3: stloc.1
    IL_00E4: ldloc.1
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x04000E9B
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x04000EB2
    IL_00F1: ldelem.i8
    IL_00F6: ldstr 0x70001F1D
    IL_00F7: ldloc.1
    IL_00FC: call 0x060003F8
    IL_00FD: pop
    IL_0102: ldstr 0x70001FD3
    IL_0107: call 0x060003F9
    IL_0108: stloc.2
    IL_0109: ldloc.2
    IL_010A: ldarg.0
    IL_010F: ldfld 0x04000EAE
    IL_0110: ldloc.2
    IL_0111: ldarg.0
    IL_0116: ldfld 0x04000EAE
    IL_0117: IL_94
    IL_0118: ldarg.0
    IL_011D: ldfld 0x04000EB3
    IL_011E: ldc.i4.1
    IL_011F: IL_58
    IL_0124: call 0x0A000080
    IL_0125: ldelem.i8
    IL_012A: ldstr 0x70001FD3
    IL_012B: ldloc.2
    IL_0130: call 0x060003F8
    IL_0131: pop
    IL_0132: ret
    }

    private void SetServerTime() {
    IL_0004: call 0x0600056E
    IL_0005: ldarg.0
    IL_000A: call 0x060006A0
    IL_000B: ret
    }

    public void DelayWorkTime() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0019
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000EC0
    IL_000D: ldloc.0
    IL_000E: ldloc.0
    IL_0013: call 0x0600056F
    IL_0014: ldelem.i8
    IL_0015: ldloc.0
    IL_0016: ldc.i4.1
    IL_0017: IL_58
    IL_0018: stloc.0
    IL_0019: ldloc.0
    IL_001A: ldc.i4.2
    IL_001B: IL_3F
    IL_001C: IL_E7
    IL_001D: IL_FF
    IL_001E: IL_FF
    IL_001F: IL_FF
    IL_0020: ldarg.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000EB8
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000EC0
    IL_002D: ldc.i4.1
    IL_002E: IL_94
    IL_002F: conv.i2
    IL_0030: IL_22
    IL_0031: IL_CD
    IL_0032: IL_CC
    IL_0033: IL_4C
    IL_0034: IL_3E
    IL_0035: IL_5A
    IL_0036: not
    IL_0037: IL_58
    IL_003C: stfld 0x04000EB9
    IL_003D: ldarg.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000EB9
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000E9C
    IL_004A: not
    IL_004F: call 0x0A00010B
    IL_0054: stfld 0x04000EB9
    IL_0055: ret
    }

    public void Zoom_finger() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_000B
    IL_000A: br IL_000B
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x04000E7E
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000E78
    IL_0018: ldarg.1
    IL_0019: ldarg.2
    IL_001A: conv.r8
    IL_001B: ldc.i4.m1
    IL_001C: IL_01
    IL_001D: nop
    IL_001E: ldloc.0
    IL_001F: ret
    }

    public void ExploreIconArray() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000E8E
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000EC3
    IL_0011: call 0x0A00004B
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0019: ldc.i4 534593
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: conv.r8
    IL_001D: ldloc.3
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000EC5
    IL_002B: call 0x0A00004B
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_002F: ldelem.r8
    IL_0030: IL_41
    IL_0035: call 0x0A000008
    IL_0036: conv.r8
    IL_0037: ldloc.3
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ldarg.0
    IL_003C: ldc.i4.1
    IL_0041: call 0x0A00001B
    IL_0046: call 0x060006A1
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000EC4
    IL_0051: call 0x0A00001B
    IL_0052: conv.r8
    IL_0053: ldloc.3
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: ret
    }

    public void ExploreIconFinish() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000EC3
    IL_000A: call 0x0A00001B
    IL_000B: conv.r8
    IL_000C: ldloc.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000EC5
    IL_001A: call 0x0A00001B
    IL_001B: conv.r8
    IL_001C: ldloc.3
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0021: ldc.i4.0
    IL_0026: stfld 0x04000E8E
    IL_0027: ldarg.0
    IL_0028: ldc.i4.0
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000EC3
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000E93
    IL_0035: conv.r8
    IL_003A: brtrue IL_6F0A003B
    IL_003B: ldc.i4.2
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_0043: call 0x060006A1
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000EC4
    IL_004E: call 0x0A00004B
    IL_004F: IL_22
    IL_0050: nop
    IL_0051: nop
    IL_0054: ldloc 10306
    IL_0055: ldloc.2
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: conv.r8
    IL_005A: ldloc.3
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ret
    }

    public void AniFinish() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_002C
    IL_0006: ldarg.0
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_C0
    IL_000B: IL_3F
    IL_0010: call 0x060006A8
    IL_0011: ldarg.0
    IL_0012: ldc.i4.5
    IL_0017: stfld 0x04000E90
    IL_0018: ldarg.0
    IL_001A: ldc.i4.s 92
    IL_001C: ldc.i4.s 96
    IL_0021: call 0x0A000045
    IL_0026: stfld 0x04000EA4
    IL_002B: br IL_0033
    IL_002C: ldarg.0
    IL_002D: ldc.i4.7
    IL_0032: stfld 0x04000E90
    IL_0033: ret
    }

    public void SetStage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000ECA
    IL_0006: ldc.i4.5
    IL_007F: switch (29 cases)
    IL_0084: call 0x0A0000E1
    IL_0089: stfld 0x04000E98
    IL_008A: ldarg.0
    IL_008B: ldc.i4.1
    IL_0090: stfld 0x04000E90
    IL_0095: br IL_018D
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000EBC
    IL_009C: ldarg.1
    IL_0165: switch (49 cases)
    IL_0166: IL_79
    IL_0168: ldarg.s 0
    IL_0169: ldarg.2
    IL_016E: ldfld 0x040007B5
    IL_016F: ldarg.0
    IL_0174: ldfld 0x04000EA8
    IL_0176: ldc.i4.s 63
    IL_017B: call 0x0A0000E1
    IL_0180: stfld 0x04000E98
    IL_0185: br IL_0186
    IL_0186: ldarg.0
    IL_0187: ldc.i4.1
    IL_018C: stfld 0x04000E7E
    IL_0191: br IL_01BE
    IL_0192: ldarg.0
    IL_0193: ldc.i4.1
    IL_0198: stfld 0x04000E8F
    IL_0199: ldarg.0
    IL_019E: ldfld 0x04000E62
    IL_019F: conv.r8
    IL_01A0: stloc.0
    IL_01A1: nop
    IL_01A2: nop
    IL_01A3: stloc.0
    IL_01A8: call 0x0A000050
    IL_01AD: ldstr 0x70022F5F
    IL_01AE: ldc.i4.1
    IL_01B3: call 0x0600021F
    IL_01B8: ldstr 0x70022F8F
    IL_01BD: call 0x0A000128
    IL_01BE: ret
    }

    public void GetGeneral() {
    IL_0004: ldstr 0x70001F55
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_000D: IL_58
    IL_000E: stloc.0
    IL_0013: ldstr 0x70001F55
    IL_0014: ldloc.0
    IL_0019: call 0x0600021F
    IL_001A: ldc.i4.0
    IL_001F: ldc.i4 1000
    IL_0024: call 0x0A000045
    IL_0025: stloc.1
    IL_0026: ldc.i4.0
    IL_0027: stloc.2
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000ECA
    IL_002E: ldc.i4.4
    IL_00BF: switch (35 cases)
    IL_00C0: nop
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: IL_3E
    IL_00C4: ldloc.1
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: ldc.i4.0
    IL_00C9: stloc.1
    IL_00CE: br IL_00D1
    IL_00CF: ldc.i4.0
    IL_00D0: ret
    IL_00D1: ldc.i4.0
    IL_00D3: ldc.i4.s 90
    IL_00D8: call 0x0A000045
    IL_00D9: stloc.3
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000EA5
    IL_00E0: ldc.i4.1
    IL_010D: switch (10 cases)
    IL_010E: ldc.i4.0
    IL_0113: ldc.i4 10000
    IL_0118: call 0x0A000045
    IL_0119: ldloc.1
    IL_011E: ldc.i4 10000
    IL_011F: IL_5A
    IL_0120: IL_58
    IL_0125: ldc.i4 10000000
    IL_0126: IL_58
    IL_0127: ldloc.3
    IL_0128: IL_58
    IL_0129: stloc.2
    IL_012A: ldc.i4.0
    IL_012C: stloc.s 4
    IL_0131: br IL_0176
    IL_0132: ldarg.0
    IL_0137: ldfld 0x04000EB7
    IL_0139: ldloc.s 4
    IL_013A: IL_94
    IL_013F: brtrue IL_0170
    IL_0140: ldarg.0
    IL_0142: ldloc.s 4
    IL_0147: stfld 0x04000E9B
    IL_0148: ldarg.0
    IL_014D: ldfld 0x04000EB7
    IL_014F: ldloc.s 4
    IL_0150: ldloc.2
    IL_0151: ldelem.i8
    IL_0156: ldstr 0x70001F15
    IL_0157: ldarg.0
    IL_015C: ldfld 0x04000EB7
    IL_0161: call 0x060003F8
    IL_0162: pop
    IL_0163: ldarg.0
    IL_0164: ldloc.2
    IL_0165: ldc.i4.0
    IL_016A: call 0x0600069E
    IL_016F: br IL_0183
    IL_0171: ldloc.s 4
    IL_0172: ldc.i4.1
    IL_0173: IL_58
    IL_0175: stloc.s 4
    IL_0177: ldloc.s 4
    IL_0178: ldarg.0
    IL_017D: ldfld 0x04000EA7
    IL_017E: IL_3F
    IL_017F: IL_AF
    IL_0180: IL_FF
    IL_0181: IL_FF
    IL_0182: IL_FF
    IL_0183: ldarg.0
    IL_0184: ldarg.0
    IL_0189: ldfld 0x04000E7B
    IL_018A: conv.r8
    IL_018B: IL_91
    IL_018C: ldarg.1
    IL_018D: nop
    IL_018E: ldloc.0
    IL_0193: stfld 0x04000E87
    IL_0194: ldc.i4.1
    IL_0195: ret
    }

    public void GetTreasure() {
    IL_0000: ldc.i4.0
    IL_0002: ldc.i4.s 100
    IL_0007: call 0x0A000045
    IL_0008: stloc.0
    IL_0009: ldloc.0
    IL_000B: ldc.i4.s 55
    IL_000C: IL_3C
    IL_000D: IL_95
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: ldarg.0
    IL_0012: ldc.i4.1
    IL_0017: stfld 0x04000E92
    IL_0018: ldarg.0
    IL_0019: ldc.i4.0
    IL_001B: ldc.i4.s 24
    IL_0020: call 0x0A000045
    IL_0025: stfld 0x04000E9F
    IL_0026: ldarg.0
    IL_002B: ldstr 0x70001FC1
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000E9F
    IL_0032: ldc.i4.1
    IL_0033: IL_58
    IL_0034: stloc.2
    IL_0036: ldloca.s 2
    IL_003B: call 0x0A000010
    IL_0040: call 0x0A000011
    IL_0045: call 0x0A000012
    IL_0046: conv.u8
    IL_0047: IL_3C
    IL_0048: nop
    IL_0049: nop
    IL_004A: IL_01
    IL_004F: stfld 0x04000E38
    IL_0054: ldstr 0x70001FC1
    IL_0059: call 0x060003F9
    IL_005A: stloc.1
    IL_005B: ldloc.1
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000E9F
    IL_0062: IL_8F
    IL_0063: stloc.1
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_01
    IL_0067: dup
    IL_006A: stloc 22551
    IL_006B: IL_54
    IL_0070: ldstr 0x70001FC1
    IL_0071: ldloc.1
    IL_0076: call 0x060003F8
    IL_0077: pop
    IL_0078: ldarg.0
    IL_0079: ldc.i4.4
    IL_007E: stfld 0x04000E90
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000E61
    IL_0085: conv.r8
    IL_0086: stind.i
    IL_0087: nop
    IL_0088: nop
    IL_008A: br.s IL_00A5
    IL_008B: conv.r8
    IL_0090: stfld 0x02060002
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000E7B
    IL_0097: conv.r8
    IL_0098: IL_92
    IL_0099: ldarg.1
    IL_009A: nop
    IL_009B: ldloc.0
    IL_00A0: stfld 0x04000E88
    IL_00A5: br IL_015D
    IL_00A6: ldloc.0
    IL_00A8: ldc.i4.s 57
    IL_00A9: IL_3C
    IL_00AC: ldarga 0
    IL_00AD: nop
    IL_00AE: ldarg.0
    IL_00AF: ldc.i4.2
    IL_00B4: stfld 0x04000E92
    IL_00B5: ldarg.0
    IL_00B6: ldc.i4.1
    IL_00BB: stfld 0x04000E9F
    IL_00BC: ldarg.0
    IL_00BD: dup
    IL_00C2: ldfld 0x04000EA1
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000E9F
    IL_00C9: IL_58
    IL_00CE: stfld 0x04000EA1
    IL_00CF: ldc.i4.1
    IL_00D0: ldc.i4.1
    IL_00D5: call 0x0600021E
    IL_00D6: pop
    IL_00D7: ldarg.0
    IL_00D8: ldc.i4.4
    IL_00DD: stfld 0x04000E90
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x04000E61
    IL_00E4: conv.r8
    IL_00E5: stind.i
    IL_00E6: nop
    IL_00E7: nop
    IL_00E9: br.s IL_0104
    IL_00EA: conv.r8
    IL_00EF: stfld 0x38060002
    IL_00F0: not
    IL_00F1: nop
    IL_00F2: nop
    IL_00F3: nop
    IL_00F4: ldloc.0
    IL_00F6: ldc.i4.s 70
    IL_00F7: IL_3C
    IL_00FA: ldloca 0
    IL_00FB: nop
    IL_00FC: ldarg.0
    IL_00FD: ldc.i4.3
    IL_0102: stfld 0x04000E92
    IL_0103: ldarg.0
    IL_0104: ldc.i4.1
    IL_0109: stfld 0x04000E9F
    IL_010A: ldarg.0
    IL_010B: dup
    IL_0110: ldfld 0x04000EA3
    IL_0111: ldc.i4.1
    IL_0112: IL_58
    IL_0117: stfld 0x04000EA3
    IL_011C: ldstr 0x7000066F
    IL_011D: ldarg.0
    IL_0122: ldfld 0x04000EA3
    IL_0127: call 0x0600021F
    IL_0128: ldarg.0
    IL_0129: ldc.i4.4
    IL_012E: stfld 0x04000E90
    IL_012F: ldarg.0
    IL_0134: ldfld 0x04000E61
    IL_0135: conv.r8
    IL_0136: stind.i
    IL_0137: nop
    IL_0138: nop
    IL_013A: br.s IL_0155
    IL_013B: conv.r8
    IL_0140: stfld 0x38060002
    IL_0141: ldc.i4.2
    IL_0142: nop
    IL_0143: nop
    IL_0144: nop
    IL_0145: ldarg.0
    IL_0146: ldc.i4.8
    IL_014B: stfld 0x04000E90
    IL_014C: ldarg.0
    IL_0151: ldfld 0x04000E61
    IL_0152: conv.r8
    IL_0153: stloc.0
    IL_0154: nop
    IL_0155: nop
    IL_0156: stloc.0
    IL_0157: ldc.i4.0
    IL_0158: conv.r8
    IL_0159: stloc.1
    IL_015A: nop
    IL_015B: nop
    IL_015C: stloc.0
    IL_015D: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000EA9
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000EAA
    IL_000E: ret
    }

    public void ScenarioFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000E8D
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000EBA
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000E8C
    IL_0014: ldc.i4.1
    IL_0049: switch (12 cases)
    IL_004A: nop
    IL_004B: stloc.0
    IL_0050: call 0x0A000007
    IL_0051: IL_22
    IL_0052: IL_EC
    IL_0053: IL_51
    IL_0054: IL_B8
    IL_0055: IL_3D
    IL_005A: call 0x0A000008
    IL_005F: call 0x0A000029
    IL_0064: stfld 0x04000E7D
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000EC3
    IL_006B: ldc.i4.0
    IL_006C: conv.r8
    IL_0071: brtrue IL_6F0A0072
    IL_0072: ldarg.1
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: ldc.i4.1
    IL_0077: conv.r8
    IL_0079: ldc.i4.s 0
    IL_007A: nop
    IL_007B: stloc.0
    IL_007C: ldarg.0
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000E5B
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000E7D
    IL_008D: call 0x0A000007
    IL_008E: IL_22
    IL_008F: stloc.0
    IL_0090: IL_D7
    IL_0091: stelem.i
    IL_0092: IL_3D
    IL_0097: call 0x0A000008
    IL_009C: call 0x0A000019
    IL_00A1: call 0x0A000013
    IL_00A6: call 0x0A000014
    IL_00A7: conv.u4
    IL_00A8: ldarg.1
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: IL_01
    IL_00B0: stfld 0x04000E71
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000EC3
    IL_00B7: ldc.i4.0
    IL_00B8: conv.r8
    IL_00BD: brtrue IL_280A00BE
    IL_00BE: localloc
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: stloc.0
    IL_00C2: conv.r8
    IL_00C3: IL_AF
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: stloc.0
    IL_00C7: ldarg.0
    IL_00CC: ldfld 0x04000E78
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000EC3
    IL_00D3: ldc.i4.0
    IL_00D4: conv.r8
    IL_00D9: brtrue IL_160A00DA
    IL_00DA: conv.r8
    IL_00DB: ldc.i4.0
    IL_00DC: IL_01
    IL_00DD: nop
    IL_00DE: ldloc.0
    IL_00DF: ldarg.0
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000E59
    IL_00E6: ldarg.0
    IL_00EB: ldfld 0x04000E7D
    IL_00EC: IL_22
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: nop
    IL_00F1: IL_22
    IL_00F2: IL_CD
    IL_00F3: IL_CC
    IL_00F4: IL_CC
    IL_00F5: IL_BD
    IL_00F6: IL_22
    IL_00F7: ldelem.i
    IL_00F8: IL_99
    IL_00F9: IL_99
    IL_00FA: IL_BE
    IL_00FF: newobj 0x0A000076
    IL_0104: call 0x0A000029
    IL_0109: call 0x0A000013
    IL_010E: call 0x0A000014
    IL_010F: conv.u4
    IL_0110: ldarg.1
    IL_0111: nop
    IL_0112: nop
    IL_0113: IL_01
    IL_0118: stfld 0x04000E72
    IL_0119: ldarg.0
    IL_011A: ldc.i4.0
    IL_011F: stfld 0x04000E8A
    IL_0120: ldarg.0
    IL_0125: ldfld 0x04000E78
    IL_0126: conv.r8
    IL_0127: ldnull
    IL_0128: IL_01
    IL_0129: nop
    IL_012A: ldloc.0
    IL_012B: ldarg.0
    IL_012C: dup
    IL_0131: ldfld 0x04000E93
    IL_0132: ldc.i4.1
    IL_0133: IL_58
    IL_0138: stfld 0x04000E93
    IL_013D: ldstr 0x700004DD
    IL_013E: ldarg.0
    IL_0143: ldfld 0x04000E93
    IL_0148: call 0x0600021F
    IL_014D: ldstr 0x7000207D
    IL_014E: ldc.i4.0
    IL_0153: call 0x0600021F
    IL_0154: ldarg.0
    IL_0159: call 0x060006AB
    IL_015A: ldarg.0
    IL_015C: ldc.i4.s 14
    IL_0161: stfld 0x04000E91
    IL_0162: ldarg.0
    IL_0163: IL_22
    IL_0164: nop
    IL_0165: nop
    IL_0166: nop
    IL_1AA20B: switch (436264 cases)
    }

    private void SceneStart_Delay() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000EC6
    IL_0006: conv.r8
    IL_000B: newobj 0x022B0000
    IL_0010: ldfld 0x04000E93
    IL_0011: ldc.i4.1
    IL_0012: IL_58
    IL_0013: conv.r8
    IL_0014: IL_29
    IL_0015: ldarg.2
    IL_0016: nop
    IL_0017: ldloc.0
    IL_0018: ret
    }

    public void SetMenuOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000E93
    IL_0006: ldc.i4.7
    IL_0007: IL_3F
    IL_0009: stloc.s 0
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_000D: ldc.i4.5
    IL_0012: stfld 0x04000EBE
    IL_0013: ldarg.0
    IL_0014: ldc.i4.0
    IL_0019: stfld 0x04000E86
    IL_001E: br IL_00C8
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000E93
    IL_0025: ldc.i4.6
    IL_0026: IL_3F
    IL_0028: stloc.s 0
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldarg.0
    IL_002C: ldc.i4.5
    IL_0031: stfld 0x04000EBE
    IL_0032: ldarg.0
    IL_0033: ldc.i4.1
    IL_0038: stfld 0x04000E86
    IL_003D: br IL_00C8
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000E93
    IL_0044: ldc.i4.4
    IL_0045: IL_3F
    IL_0047: stloc.s 0
    IL_0048: nop
    IL_0049: nop
    IL_004A: ldarg.0
    IL_004B: ldc.i4.4
    IL_0050: stfld 0x04000EBE
    IL_0051: ldarg.0
    IL_0052: ldc.i4.0
    IL_0057: stfld 0x04000E86
    IL_005C: br IL_00C8
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000E93
    IL_0063: ldc.i4.3
    IL_0064: IL_3F
    IL_0066: stloc.s 0
    IL_0067: nop
    IL_0068: nop
    IL_0069: ldarg.0
    IL_006A: ldc.i4.4
    IL_006F: stfld 0x04000EBE
    IL_0070: ldarg.0
    IL_0071: ldc.i4.0
    IL_0076: stfld 0x04000E86
    IL_007B: br IL_00C8
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000E93
    IL_0082: ldc.i4.2
    IL_0083: IL_3F
    IL_0085: stloc.s 0
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldarg.0
    IL_0089: ldc.i4.3
    IL_008E: stfld 0x04000EBE
    IL_008F: ldarg.0
    IL_0090: ldc.i4.1
    IL_0095: stfld 0x04000E86
    IL_009A: br IL_00C8
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000E93
    IL_00A1: ldc.i4.1
    IL_00A2: IL_3F
    IL_00A4: stloc.s 0
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4.2
    IL_00AD: stfld 0x04000EBE
    IL_00AE: ldarg.0
    IL_00AF: ldc.i4.0
    IL_00B4: stfld 0x04000E86
    IL_00B9: br IL_00C8
    IL_00BA: ldarg.0
    IL_00BB: ldc.i4.1
    IL_00C0: stfld 0x04000EBE
    IL_00C1: ldarg.0
    IL_00C2: ldc.i4.0
    IL_00C7: stfld 0x04000E86
    IL_00C8: ret
    }

    private void Update() {
    IL_0004: ldstr 0x7000064F
    IL_0009: call 0x0A000095
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_00BD: switch (43 cases)
    IL_00BF: ldarg.s 0
    IL_00C0: ldarg.2
    IL_00C1: ldc.i4.0
    IL_00C2: IL_3E
    IL_00C3: IL_F8
    IL_00C4: ldarg.1
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: ldarg.0
    IL_00CC: ldfld 0x04000E9D
    IL_00CD: IL_22
    IL_00CE: nop
    IL_00CF: nop
    IL_00D4: stsfld 0x0017413F
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: ldarg.0
    IL_00D8: dup
    IL_00DD: ldfld 0x04000E9D
    IL_00E2: call 0x0A000024
    IL_00E3: IL_58
    IL_00E8: stfld 0x04000E9D
    IL_00ED: br IL_0108
    IL_00EE: ldarg.0
    IL_00EF: IL_22
    IL_00F0: nop
    IL_00F1: nop
    IL_00F2: nop
    IL_00F3: nop
    IL_00F8: stfld 0x04000E9D
    IL_00F9: ldarg.0
    IL_00FA: dup
    IL_00FF: ldfld 0x04000E8A
    IL_0100: ldc.i4.1
    IL_0101: IL_58
    IL_0102: neg
    IL_0107: stfld 0x04000E8A
    IL_0108: ldarg.0
    IL_010D: ldfld 0x04000E8A
    IL_010E: ldc.i4.2
    IL_07FF: switch (443 cases)
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000EA0
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000EA0
    IL_0010: ret
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000ECC
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000ECC
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000ECC
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000E78
    IL_0047: conv.r8
    IL_0049: stloc.s 1
    IL_004A: nop
    IL_004B: ldloc.0
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000E60
    IL_0056: call 0x0A00001B
    IL_0057: conv.r8
    IL_0058: IL_AF
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000E8D
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000E8A
    IL_0012: ldc.i4.0
    IL_0013: IL_3E
    IL_0014: IL_01
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ret
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000E25
    IL_0023: call 0x0A0000DF
    IL_0028: call 0x0A00001B
    IL_002D: call 0x0A000013
    IL_0032: call 0x0A0000D9
    IL_0033: conv.i2
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_003B: cpobj 0xDA285B44
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: conv.i2
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0047: ldc.i4 2251588
    IL_0048: nop
    IL_004D: stsfld 0x0076733F
    IL_004E: nop
    IL_004F: stloc.0
    IL_0054: call 0x0A0000DD
    IL_0059: call 0x0A0000DE
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000E89
    IL_0060: ldc.i4.0
    IL_0061: IL_3E
    IL_0062: IL_01
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: ret
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000E91
    IL_006D: ldc.i4.0
    IL_006E: IL_3E
    IL_006F: stloc.3
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: ldarg.0
    IL_0074: ldc.i4.0
    IL_0079: stfld 0x04000E7F
    IL_007A: ldc.i4.0
    IL_007F: call 0x0A0001B9
    IL_0080: IL_22
    IL_0081: nop
    IL_0082: nop
    IL_0083: IL_E0
    IL_0084: IL_42
    IL_0085: IL_22
    IL_0086: nop
    IL_0087: nop
    IL_0088: nop
    IL_0089: nop
    IL_008A: IL_22
    IL_008B: nop
    IL_008C: nop
    IL_0091: stsfld 0x00002243
    IL_0092: nop
    IL_0093: IL_42
    IL_0098: call 0x0600021D
    IL_0099: ldarg.0
    IL_009E: ldfld 0x04000E46
    IL_00A3: call 0x0A0000E0
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A8: ldloca.s 67
    IL_00A9: IL_22
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: IL_C0
    IL_280000139: switch (2684354594 cases)
    }

    public void BattleStart() {
    IL_0004: ldstr 0x70000B7F
    IL_0005: ldarg.0
    IL_000A: ldfld 0x04000E76
    IL_000B: conv.r8
    IL_000C: ldc.i4.2
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: call 0x060003F3
    IL_0015: pop
    IL_0016: ldc.i4.1
    IL_001B: call 0x0600056B
    IL_0020: ldstr 0x70000CDD
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000E95
    IL_002B: call 0x0600021F
    IL_0030: ldstr 0x7000174B
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000E99
    IL_003B: call 0x0600021F
    IL_0040: ldstr 0x70001F45
    IL_0041: ldc.i4.m1
    IL_0046: call 0x0600021F
    IL_004B: ldstr 0x70000BDB
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000EC9
    IL_0056: call 0x0600021F
    IL_0057: ldarg.0
    IL_005C: ldfld 0x04000E75
    IL_005D: conv.r8
    IL_005E: stloc.0
    IL_005F: nop
    IL_0060: nop
    IL_0061: stloc.0
    IL_0066: call 0x0A000050
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000E62
    IL_006D: conv.r8
    IL_006E: stloc.0
    IL_006F: nop
    IL_0070: nop
    IL_0071: stloc.0
    IL_0076: call 0x0A000050
    IL_0077: ret
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000EDC
    IL_000C: ldarg.0
    IL_000D: ldc.i4.4
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000EDD
    IL_0018: ldarg.0
    IL_0019: ldc.i4.8
    IL_001E: newarr 0x0100003C
    IL_0023: stfld 0x04000EDE
    IL_0024: ldarg.0
    IL_0025: ldc.i4.3
    IL_002A: newarr 0x0100003C
    IL_002F: stfld 0x04000EEE
    IL_0030: ldarg.0
    IL_0031: ldc.i4.2
    IL_0033: ldc.i4.s 10
    IL_0038: newobj 0x0A000169
    IL_003D: stfld 0x04000EF5
    IL_003E: ldarg.0
    IL_003F: ldc.i4.2
    IL_0044: newarr 0x01000003
    IL_0049: stfld 0x04000F00
    IL_004A: ldarg.0
    IL_004B: ldc.i4.2
    IL_0050: newarr 0x0100000B
    IL_0055: stfld 0x04000F02
    IL_0056: ldarg.0
    IL_0057: ldc.i4.2
    IL_005C: newarr 0x0100000B
    IL_0061: stfld 0x04000F03
    IL_0062: ldarg.0
    IL_0063: ldc.i4.2
    IL_0068: newarr 0x0100000B
    IL_006D: stfld 0x04000F04
    IL_006E: ldarg.0
    IL_006F: ldc.i4.1
    IL_0074: stfld 0x04000F0F
    IL_0075: ldarg.0
    IL_007A: ldsfld 0x0A000099
    IL_007F: stfld 0x04000F13
    IL_0080: ldarg.0
    IL_0085: ldsfld 0x0A000099
    IL_008A: stfld 0x04000F14
    IL_008B: ldarg.0
    IL_0090: call 0x0A000001
    IL_0091: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000EFC
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000EFD
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70023247
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F0F
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000F0F
    IL_0017: ldc.i4.1
    IL_0018: IL_59
    IL_0019: ldc.i4.8
    IL_001A: add
    IL_001F: stfld 0x04000F0F
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000BB3
    IL_002A: call 0x0A000095
    IL_002F: stfld 0x04000F01
    IL_0030: ldarg.0
    IL_0031: ldarg.0
    IL_0036: call 0x2B00008D
    IL_003B: ldfld 0x040004F3
    IL_0040: stfld 0x04000EF5
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: call 0x2B000001
    IL_004C: stfld 0x04000EF1
    IL_004D: ldarg.0
    IL_0052: ldstr 0x7000000F
    IL_0057: call 0x06000220
    IL_005C: stfld 0x04000F10
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000F10
    IL_0067: brfalse IL_0082
    IL_0068: ldarg.0
    IL_0069: ldarg.0
    IL_006E: ldfld 0x04000F10
    IL_0073: stfld 0x04000F11
    IL_0074: ldarg.0
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000F11
    IL_007B: ldc.i4.1
    IL_007C: IL_59
    IL_0081: call 0x060006B6
    IL_0082: ldarg.0
    IL_0087: ldc.i4 -380
    IL_008C: stfld 0x04000EF6
    IL_008D: ldarg.0
    IL_0092: ldc.i4 480
    IL_0097: stfld 0x04000EF7
    IL_0098: ldarg.0
    IL_009D: ldc.i4 340
    IL_00A2: stfld 0x04000EF8
    IL_00A3: ldarg.0
    IL_00A5: ldc.i4.s 20
    IL_00AA: stfld 0x04000EFE
    IL_00AB: ldarg.0
    IL_00B0: call 0x0A0000DA
    IL_00B1: conv.i2
    IL_00B2: IL_22
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: IL_C0
    IL_00B6: IL_3E
    IL_00B7: IL_5A
    IL_00BC: stfld 0x04000F0D
    IL_00BD: ldarg.0
    IL_00C2: ldstr 0x70001EFD
    IL_00C7: call 0x060003F9
    IL_00CC: stfld 0x04000F02
    IL_00CD: ldarg.0
    IL_00D2: ldstr 0x70001F05
    IL_00D7: call 0x060003F9
    IL_00DC: stfld 0x04000F03
    IL_00DD: ldarg.0
    IL_00E2: ldstr 0x70001F0D
    IL_00E7: call 0x060003F9
    IL_00EC: stfld 0x04000F04
    IL_00ED: ldc.i4.0
    IL_00EE: stloc.0
    IL_00F3: br IL_010D
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x04000F04
    IL_00FA: ldloc.0
    IL_00FB: IL_94
    IL_00FC: ldc.i4.0
    IL_00FD: IL_3D
    IL_00FE: ldloc.1
    IL_00FF: nop
    IL_0100: nop
    IL_0101: nop
    IL_0102: ldarg.0
    IL_0103: ldc.i4.1
    IL_0108: stfld 0x04000F07
    IL_0109: ldloc.0
    IL_010A: ldc.i4.1
    IL_010B: IL_58
    IL_010C: stloc.0
    IL_010D: ldloc.0
    IL_010E: ldc.i4.2
    IL_010F: IL_3F
    IL_0110: IL_E0
    IL_0111: IL_FF
    IL_0112: IL_FF
    IL_0113: IL_FF
    IL_0114: ldarg.0
    IL_0119: ldstr 0x70023285
    IL_011A: IL_22
    IL_011B: nop
    IL_011C: nop
    IL_011D: nop
    IL_011E: IL_3F
    IL_011F: IL_22
    IL_0124: ldfld 0x283EAE14
    IL_0125: ldc.i4.1
    IL_0126: nop
    IL_0127: nop
    IL_0128: stloc.0
    IL_0129: ldarg.0
    IL_012E: ldstr 0x70000121
    IL_0133: call 0x0A000004
    IL_0138: stfld 0x04000EF3
    IL_0139: ldarg.0
    IL_013E: ldfld 0x04000EF3
    IL_013F: ldnull
    IL_0144: call 0x0A000021
    IL_0149: brfalse IL_015B
    IL_014A: ldarg.0
    IL_014B: ldarg.0
    IL_0150: ldfld 0x04000EF3
    IL_0151: conv.r8
    IL_0152: IL_84
    IL_0153: nop
    IL_0154: nop
    IL_0156: br.s IL_01D4
    IL_0157: IL_F4
    IL_0159: ldarg.s 0
    IL_015A: ldarg.2
    IL_015B: ldarg.0
    IL_0160: ldstr 0x70022F5F
    IL_0165: call 0x06000220
    IL_016A: stfld 0x04000F08
    IL_016F: ldstr 0x70000617
    IL_0170: ldc.i4.7
    IL_0175: call 0x0A00009F
    IL_0176: ret
    }

    private void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000EFB
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000EFB
    IL_0010: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F05
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000F06
    IL_000E: ret
    }

    private void SetAngel() {
    IL_0000: ldarg.0
    IL_0005: ldsfld 0x040007B2
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000F01
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000EF1
    IL_0016: ldfld 0x04000521
    IL_0017: ldarg.1
    IL_0018: IL_8F
    IL_0019: conv.i8
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.0
    IL_0021: ldfld 0x0400051B
    IL_0026: call 0x0A0000E1
    IL_002B: stfld 0x04000F13
    IL_002C: ldarg.0
    IL_0031: ldsfld 0x040007B2
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000F01
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000EF1
    IL_0042: ldfld 0x04000521
    IL_0043: ldarg.1
    IL_0044: IL_8F
    IL_0045: conv.i8
    IL_0046: nop
    IL_0047: nop
    IL_0048: ldarg.0
    IL_004D: ldfld 0x0400051C
    IL_0052: call 0x0A0000E1
    IL_0057: stfld 0x04000F14
    IL_0058: ldarg.0
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_0060: ldc.i4 -243596735
    IL_0062: ldarg.s 0
    IL_0063: ldarg.2
    IL_0068: ldfld 0x04000521
    IL_0069: ldarg.1
    IL_006A: IL_8F
    IL_006B: conv.i8
    IL_006C: nop
    IL_006D: nop
    IL_006E: ldarg.0
    IL_0073: ldfld 0x0400051D
    IL_0074: IL_59
    IL_0079: stfld 0x04000F12
    IL_007A: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F05
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000F06
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000F06
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000F06
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
    IL_0033: stfld 0x04000F05
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000F06
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000EF6
    IL_0046: ldc.i4.s -64
    IL_0047: IL_3C
    IL_0049: brfalse.s IL_004A
    IL_004A: nop
    IL_004B: nop
    IL_004C: ldarg.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000EF6
    IL_0053: conv.i2
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000EF6
    IL_005A: shl
    IL_005B: conv.i2
    IL_0060: call 0x0A000024
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldc.i4.0
    IL_0065: IL_44
    IL_0066: IL_5A
    IL_006B: call 0x0A000114
    IL_006C: IL_58
    IL_006D: not
    IL_0072: stfld 0x04000EF6
    IL_0077: br IL_0080
    IL_0078: ldarg.0
    IL_007A: ldc.i4.s -64
    IL_007F: stfld 0x04000EF6
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000EFF
    IL_0086: ldc.i4.0
    IL_0087: IL_3E
    IL_008C: ldsflda 0x02000000
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000EF7
    IL_0093: conv.i2
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000EF7
    IL_009A: conv.i2
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00AC: not
    IL_00B1: stfld 0x04000EF7
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x04000EF7
    IL_00B8: ldc.i4.0
    IL_00B9: IL_3D
    IL_00BC: ldloc 0
    IL_00BD: nop
    IL_00BE: ldarg.0
    IL_00BF: ldc.i4.0
    IL_00C4: stfld 0x04000EF7
    IL_00C5: ldarg.0
    IL_00C6: ldarg.0
    IL_00CB: ldfld 0x04000EF8
    IL_00CC: conv.i2
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000EF8
    IL_00D3: conv.i2
    IL_00D8: call 0x0A000024
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: IL_FA
    IL_00DD: IL_43
    IL_00DE: IL_5A
    IL_00E3: call 0x0A000114
    IL_00E4: IL_59
    IL_00E5: not
    IL_00EA: stfld 0x04000EF8
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x04000EF8
    IL_00F5: ldc.i4 230
    IL_00F6: IL_3D
    IL_00F7: stloc.1
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: ldarg.0
    IL_0100: ldc.i4 230
    IL_0105: stfld 0x04000EF8
    IL_010A: br IL_0121
    IL_010B: ldarg.0
    IL_0110: ldc.i4 480
    IL_0115: stfld 0x04000EF7
    IL_0116: ldarg.0
    IL_011B: ldc.i4 340
    IL_0120: stfld 0x04000EF8
    IL_0121: ldc.i4.0
    IL_0126: call 0x0A0000D6
    IL_012B: brfalse IL_016F
    IL_0130: call 0x0A0000D7
    IL_0131: stloc.1
    IL_0133: ldloca.s 1
    IL_0138: ldfld 0x0A000023
    IL_0139: ldarg.0
    IL_013E: ldfld 0x04000F0D
    IL_013F: IL_41
    IL_0140: pop
    IL_0141: nop
    IL_0142: nop
    IL_0143: nop
    IL_0144: ldarg.0
    IL_0145: ldc.i4.1
    IL_014A: stfld 0x04000F09
    IL_014B: ldarg.0
    IL_0150: call 0x0A0000D7
    IL_0151: stloc.2
    IL_0153: ldloca.s 2
    IL_0158: ldfld 0x0A00005E
    IL_015D: stfld 0x04000F0B
    IL_015E: ldarg.0
    IL_015F: ldarg.0
    IL_0164: ldfld 0x04000F0E
    IL_0169: stfld 0x04000F0C
    IL_016E: br IL_0188
    IL_016F: ldc.i4.0
    IL_0174: call 0x0A0000D8
    IL_0179: brfalse IL_0188
    IL_017A: ldarg.0
    IL_017B: ldc.i4.0
    IL_0180: stfld 0x04000F09
    IL_0181: ldarg.0
    IL_0182: ldc.i4.0
    IL_0187: stfld 0x04000F0A
    IL_0188: ldarg.0
    IL_018D: ldfld 0x04000F09
    IL_0192: brfalse IL_0218
    IL_0197: call 0x0A0000D7
    IL_0198: stloc.3
    IL_019A: ldloca.s 3
    IL_019F: ldfld 0x0A00005E
    IL_01A0: ldarg.0
    IL_01A5: ldfld 0x04000F0B
    IL_01A6: IL_59
    IL_01AB: call 0x0A00007F
    IL_01AC: IL_22
    IL_01AD: nop
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: IL_41
    IL_01B1: IL_43
    IL_01B2: ldloc.1
    IL_01B3: nop
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: ldarg.0
    IL_01B7: ldc.i4.1
    IL_01BC: stfld 0x04000F0A
    IL_01BD: ldarg.0
    IL_01C2: call 0x0A0000D7
    IL_01C4: stloc.s 4
    IL_01C6: ldloca.s 4
    IL_01CB: ldfld 0x0A00005E
    IL_01CC: ldarg.0
    IL_01D1: ldfld 0x04000F0B
    IL_01D2: IL_59
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01D6: IL_F0
    IL_01D7: IL_43
    IL_01DC: call 0x0A0000D9
    IL_01DD: conv.i2
    IL_01DE: add
    IL_01DF: IL_5A
    IL_01E0: ldarg.0
    IL_01E5: ldfld 0x04000F0C
    IL_01E6: IL_58
    IL_01EB: stfld 0x04000F0E
    IL_01EC: ldarg.0
    IL_01ED: ldarg.0
    IL_01F2: ldfld 0x04000F0E
    IL_01F3: IL_22
    IL_01F4: nop
    IL_01F5: nop
    IL_01F6: nop
    IL_01F7: nop
    IL_01FC: call 0x0A000114
    IL_0201: stfld 0x04000F0E
    IL_0202: ldarg.0
    IL_0203: ldarg.0
    IL_0208: ldfld 0x04000F0E
    IL_0209: IL_22
    IL_020A: nop
    IL_020B: nop
    IL_020C: ldc.i4.0
    IL_020D: IL_C3
    IL_0212: call 0x0A00019C
    IL_0217: stfld 0x04000F0E
    IL_021C: ldstr 0x7000064F
    IL_0221: call 0x0A000095
    IL_0222: stloc.0
    IL_0223: ldloc.0
    IL_0224: ldc.i4.1
    IL_02D5: switch (43 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000EF2
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000EF2
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000EF2
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
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
    IL_003B: ldfld 0x04000EEF
    IL_0040: call 0x0A0000DF
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000EF6
    IL_0047: conv.i2
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldelem.r8
    IL_0051: IL_43
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldelem.r8
    IL_0056: IL_43
    IL_005B: call 0x0600021D
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000ED5
    IL_0066: call 0x0A0000E0
    IL_0067: IL_22
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_FC
    IL_006B: IL_42
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_006F: IL_F0
    IL_0070: IL_41
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_C8
    IL_0075: IL_42
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_007B: ldloc 10306
    IL_007C: ldc.i4.7
    IL_007D: ldarg.0
    IL_007E: nop
    IL_007F: ldloc.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000ED6
    IL_008A: call 0x0A0000E0
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_58
    IL_008F: IL_43
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0093: IL_50
    IL_0094: IL_42
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: ldelem.r8
    IL_0099: IL_42
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_C0
    IL_009E: IL_41
    IL_00A3: call 0x0600021D
    IL_00A8: ldsfld 0x040007B2
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000F01
    IL_00B0: ldc.i4.s 74
    IL_00B5: call 0x0A0000E1
    IL_00BA: call 0x0A0002EA
    IL_00BB: IL_22
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: IL_E0
    IL_00BF: IL_42
    IL_00C0: IL_22
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00CC: stsfld 0x00002243
    IL_00CD: nop
    IL_00CE: IL_42
    IL_00D3: call 0x0600021D
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000EE4
    IL_00DE: call 0x0A0000E0
    IL_00DF: IL_22
    IL_00E0: nop
    IL_00E1: nop
    IL_00E3: ldloca.s 67
    IL_00E4: IL_22
    IL_00E5: nop
    IL_00E6: nop
    IL_00E7: IL_C0
    IL_280000174: switch (2684354594 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F17
    IL_0007: ldarg.0
    IL_0008: ldc.i4.5
    IL_000D: newarr 0x0100003C
    IL_0012: stfld 0x04000F33
    IL_0013: ldarg.0
    IL_0014: ldc.i4.3
    IL_0019: newarr 0x0100003C
    IL_001E: stfld 0x04000F34
    IL_001F: ldarg.0
    IL_0020: ldc.i4.3
    IL_0025: newarr 0x0100002F
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_96
    IL_002C: IL_43
    IL_002D: ldelem.r8
    IL_002E: dup
    IL_002F: ldc.i4.1
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_96
    IL_0034: IL_43
    IL_0035: ldelem.r8
    IL_0036: dup
    IL_0037: ldc.i4.2
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_96
    IL_003C: IL_43
    IL_003D: ldelem.r8
    IL_0042: stfld 0x04000F38
    IL_0043: ldarg.0
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_0047: throw
    IL_0048: IL_44
    IL_004D: stfld 0x04000F39
    IL_004E: ldarg.0
    IL_004F: ldc.i4.3
    IL_0054: newarr 0x01000010
    IL_0059: stfld 0x04000F41
    IL_005A: ldarg.0
    IL_005B: ldc.i4.3
    IL_0060: newarr 0x01000010
    IL_0065: stfld 0x04000F42
    IL_0066: ldarg.0
    IL_0067: ldc.i4.3
    IL_006C: newarr 0x01000013
    IL_0071: stfld 0x04000F43
    IL_0072: ldarg.0
    IL_0073: ldc.i4.6
    IL_0078: newarr 0x0100000B
    IL_007D: stfld 0x04000F44
    IL_007E: ldarg.0
    IL_0083: call 0x0A000001
    IL_0084: ret
    }

    private void Awake() {
    IL_0004: ldstr 0x700236B1
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldstr 0x70001ED5
    IL_0015: call 0x06000220
    IL_001A: stfld 0x04000F48
    IL_001B: ldarg.0
    IL_001C: ldloc.0
    IL_0021: ldc.i4 1000
    IL_0022: add
    IL_0023: neg
    IL_0028: stfld 0x04000F19
    IL_0029: ldarg.0
    IL_002A: ldloc.0
    IL_002F: ldc.i4 1000
    IL_0030: mul
    IL_0035: stfld 0x04000F1A
    IL_0036: ldc.i4.0
    IL_0037: stloc.1
    IL_003C: br IL_0062
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000F41
    IL_0043: ldloc.1
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000F1A
    IL_004B: ldc.i4.s 10
    IL_004C: mul
    IL_004D: neg
    IL_004E: ldelem.i4
    IL_004F: ldarg.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000F1A
    IL_0057: ldc.i4.s 10
    IL_0058: add
    IL_005D: stfld 0x04000F1A
    IL_005E: ldloc.1
    IL_005F: ldc.i4.1
    IL_0060: IL_58
    IL_0061: stloc.1
    IL_0062: ldloc.1
    IL_0063: ldc.i4.3
    IL_0064: IL_3F
    IL_0065: IL_D4
    IL_0066: IL_FF
    IL_0067: IL_FF
    IL_0068: IL_FF
    IL_006D: ldstr 0x70001EDD
    IL_0072: call 0x060003F9
    IL_0073: stloc.2
    IL_0074: ldarg.0
    IL_0079: ldstr 0x70000CDD
    IL_007E: call 0x06000220
    IL_0083: stfld 0x04000F1B
    IL_0084: ldarg.0
    IL_0089: ldstr 0x700004DD
    IL_008E: call 0x06000220
    IL_0093: stfld 0x04000F1C
    IL_0094: ldc.i4.0
    IL_0095: stloc.3
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000F1C
    IL_009C: ldc.i4.5
    IL_009D: IL_3C
    IL_009F: ldarga.s 0
    IL_00A0: nop
    IL_00A1: nop
    IL_00A6: ldstr 0x70024190
    IL_00AB: call 0x0A000077
    IL_00B0: call 0x0A000050
    IL_00B1: ldloc.2
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x04000F1B
    IL_00B8: IL_94
    IL_00B9: stloc.3
    IL_00BA: ldc.i4.0
    IL_00BC: stloc.s 4
    IL_00C1: br IL_00DB
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x04000F42
    IL_00C9: ldloc.s 4
    IL_00CA: ldloc.3
    IL_00CC: ldc.i4.s 10
    IL_00CD: mul
    IL_00CE: neg
    IL_00CF: ldelem.i4
    IL_00D0: ldloc.3
    IL_00D2: ldc.i4.s 10
    IL_00D3: add
    IL_00D4: stloc.3
    IL_00D6: ldloc.s 4
    IL_00D7: ldc.i4.1
    IL_00D8: IL_58
    IL_00DA: stloc.s 4
    IL_00DC: ldloc.s 4
    IL_00DD: ldc.i4.3
    IL_00DE: IL_3F
    IL_00DF: IL_DF
    IL_00E0: IL_FF
    IL_00E1: IL_FF
    IL_00E2: IL_FF
    IL_00E3: ldc.i4.0
    IL_00E5: stloc.s 5
    IL_00E6: ldarg.0
    IL_00EB: ldfld 0x04000F42
    IL_00EC: ldc.i4.2
    IL_00ED: IL_92
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x04000F41
    IL_00F4: ldc.i4.2
    IL_00F5: IL_92
    IL_00F6: IL_58
    IL_00F7: ldc.i4.0
    IL_00F8: IL_3E
    IL_00F9: ldloc.1
    IL_00FA: nop
    IL_00FB: nop
    IL_00FC: nop
    IL_00FE: ldloc.s 5
    IL_0100: ldc.i4.s 100
    IL_0101: IL_58
    IL_0103: stloc.s 5
    IL_0104: ldarg.0
    IL_0109: ldfld 0x04000F42
    IL_010A: ldc.i4.1
    IL_010B: IL_92
    IL_010C: ldarg.0
    IL_0111: ldfld 0x04000F41
    IL_0112: ldc.i4.1
    IL_0113: IL_92
    IL_0114: IL_58
    IL_0115: ldc.i4.0
    IL_0116: IL_3E
    IL_0117: ldloc.1
    IL_0118: nop
    IL_0119: nop
    IL_011A: nop
    IL_011C: ldloc.s 5
    IL_011E: ldc.i4.s 10
    IL_011F: IL_58
    IL_0121: stloc.s 5
    IL_0122: ldarg.0
    IL_0127: ldfld 0x04000F42
    IL_0128: ldc.i4.0
    IL_0129: IL_92
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000F41
    IL_0130: ldc.i4.0
    IL_0131: IL_92
    IL_0132: IL_58
    IL_0133: ldc.i4.0
    IL_0134: IL_3E
    IL_0135: ldloc.0
    IL_0136: nop
    IL_0137: nop
    IL_0138: nop
    IL_013A: ldloc.s 5
    IL_013B: ldc.i4.1
    IL_013C: IL_58
    IL_013E: stloc.s 5
    IL_013F: ldloc.2
    IL_0140: ldarg.0
    IL_0145: ldfld 0x04000F1B
    IL_0147: ldloc.s 5
    IL_0148: ldelem.i8
    IL_014D: ldstr 0x70001EDD
    IL_014E: ldloc.2
    IL_0153: call 0x060003F8
    IL_0154: pop
    IL_0155: IL_22
    IL_0156: nop
    IL_0157: nop
    IL_015C: stsfld 0x0111283F
    IL_015D: nop
    IL_015E: stloc.0
    IL_015F: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F1D
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F1F
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000F37
    IL_0026: conv.r8
    IL_0027: stloc.0
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: conv.r8
    IL_002C: len
    IL_002D: nop
    IL_002E: nop
    IL_0030: br.s IL_00A0
    IL_0031: rem
    IL_0032: ldarg.1
    IL_0033: nop
    IL_0034: ldloc.0
    IL_0035: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000F25
    IL_0010: ldarg.0
    IL_0015: call 0x0A00002B
    IL_001A: ldstr 0x70022774
    IL_001F: call 0x0A0001C1
    IL_0020: conv.r8
    IL_0021: IL_C9
    IL_0022: IL_01
    IL_0023: nop
    IL_0024: stloc.0
    IL_0029: ldstr 0x7002270C
    IL_002E: call 0x0A0001C1
    IL_0033: call 0x0A0001C2
    IL_0034: ldarg.0
    IL_0039: ldstr 0x70023257
    IL_003E: call 0x06000220
    IL_0043: stfld 0x04000F20
    IL_0044: ldarg.0
    IL_0049: ldstr 0x7002325F
    IL_004E: call 0x06000220
    IL_0053: stfld 0x04000F1E
    IL_0058: ldstr 0x70023257
    IL_0059: ldc.i4.0
    IL_005E: call 0x0600021F
    IL_0063: ldstr 0x7002325F
    IL_0064: ldc.i4.0
    IL_0069: call 0x0600021F
    IL_006A: ldarg.0
    IL_006B: dup
    IL_0070: ldfld 0x04000F1D
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000F1E
    IL_0077: IL_59
    IL_007C: stfld 0x04000F1D
    IL_007D: ldarg.0
    IL_007E: dup
    IL_0083: ldfld 0x04000F1F
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000F20
    IL_008A: IL_59
    IL_008F: stfld 0x04000F1F
    IL_0090: ldarg.0
    IL_0095: ldstr 0x70000DDD
    IL_009A: call 0x06000220
    IL_009F: stfld 0x04000F23
    IL_00A0: ldarg.0
    IL_00A5: ldstr 0x70000DE5
    IL_00AA: call 0x06000220
    IL_00AF: stfld 0x04000F24
    IL_00B0: ldarg.0
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000F24
    IL_00B7: conv.i2
    IL_00BC: stfld 0x04000F27
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x04000F23
    IL_00C4: ldc.i4.s 19
    IL_00C5: IL_3C
    IL_00C6: IL_3D
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: nop
    IL_00CA: ldarg.0
    IL_00CF: ldstr 0x70002065
    IL_00D4: call 0x06000220
    IL_00D9: stfld 0x04000F3D
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000F3D
    IL_00E0: ldc.i4.1
    IL_014D: switch (26 cases)
    IL_014E: IL_F9
    IL_014F: ldarg.1
    IL_0150: nop
    IL_0151: ldloc.0
    IL_0156: stfld 0x04000F44
    IL_0157: ldc.i4.0
    IL_0158: stloc.0
    IL_0159: ldc.i4.0
    IL_015A: stloc.1
    IL_015F: br IL_0181
    IL_0160: ldarg.0
    IL_0165: ldfld 0x04000F44
    IL_0166: ldloc.1
    IL_0167: IL_94
    IL_0169: ldc.i4.s 10
    IL_016A: IL_3F
    IL_016B: ldloc.3
    IL_016C: nop
    IL_016D: nop
    IL_016E: nop
    IL_016F: ldloc.0
    IL_0170: ldc.i4.1
    IL_0171: IL_58
    IL_0172: stloc.0
    IL_0177: br IL_017D
    IL_017C: br IL_0188
    IL_017D: ldloc.1
    IL_017E: ldc.i4.1
    IL_017F: IL_58
    IL_0180: stloc.1
    IL_0181: ldloc.1
    IL_0182: ldc.i4.6
    IL_0183: IL_3F
    IL_0184: IL_D8
    IL_0185: IL_FF
    IL_0186: IL_FF
    IL_0187: IL_FF
    IL_0188: ldloc.0
    IL_0189: ldc.i4.6
    IL_01AA: switch (7 cases)
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: nop
    IL_01AE: ldarg.3
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: nop
    IL_01B3: starg.s 0
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: ldc.i4.5
    IL_01B7: nop
    IL_01B8: nop
    IL_01B9: nop
    IL_01BE: br IL_01E0
    IL_01BF: IL_22
    IL_01C0: nop
    IL_01C1: nop
    IL_01C6: stsfld 0x16380C3F
    IL_01C7: nop
    IL_01C8: nop
    IL_01C9: nop
    IL_01CA: IL_22
    IL_01CB: IL_CD
    IL_01CC: IL_CC
    IL_01D1: newobj 0x0B380C3F
    IL_01D2: nop
    IL_01D3: nop
    IL_01D4: nop
    IL_01D5: IL_22
    IL_01D6: nop
    IL_01D7: nop
    IL_01D8: IL_C0
    IL_01D9: IL_3F
    IL_01DA: stloc.2
    IL_01DF: br IL_01E0
    IL_01E0: ldarg.0
    IL_01E1: ldarg.0
    IL_01E6: ldfld 0x04000F1B
    IL_01E7: ldc.i4.2
    IL_01E8: IL_5A
    IL_01EA: ldc.i4.s 100
    IL_01EB: IL_58
    IL_01EC: conv.i2
    IL_01ED: ldloc.2
    IL_01EE: IL_5A
    IL_01EF: not
    IL_01F4: stfld 0x04000F21
    IL_01F5: ldarg.0
    IL_01F6: ldarg.0
    IL_01FB: ldfld 0x04000F1B
    IL_01FC: ldc.i4.5
    IL_01FD: IL_58
    IL_01FF: ldc.i4.s 20
    IL_0200: IL_5A
    IL_0205: stfld 0x04000F22
    IL_0206: ldarg.0
    IL_020B: call 0x0A00002B
    IL_020C: ldarg.0
    IL_0211: ldfld 0x04000F46
    IL_0212: conv.r8
    IL_0213: IL_4C
    IL_0214: nop
    IL_0215: nop
    IL_0216: stloc.0
    IL_0217: ldarg.0
    IL_021C: call 0x0A00002B
    IL_021D: conv.r8
    IL_021E: IL_4D
    IL_021F: nop
    IL_0220: nop
    IL_0221: stloc.0
    IL_0222: ret
    }

    public void GoNext() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F28
    IL_0007: ret
    }

    public void AmountJade() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000F1F
    IL_0007: ret
    }

    public void AmountCoin() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000F1D
    IL_0007: ret
    }

    public void GetGem() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F3C
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F3B
    IL_000A: brtrue IL_0202
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000F39
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_87
    IL_0016: IL_43
    IL_001B: call 0x0A000024
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_96
    IL_0020: IL_44
    IL_0021: IL_5A
    IL_0026: call 0x0A0000C0
    IL_002B: stfld 0x04000F39
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000F39
    IL_0032: IL_22
    IL_0033: nop
    IL_0034: nop
    IL_0035: IL_87
    IL_0036: IL_43
    IL_0753: switch (454 cases)
    }

    public void CashshopOpen() {
    IL_0004: ldstr 0x70001E8B
    IL_0005: ldarg.1
    IL_000A: call 0x0600021F
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000F3A
    IL_0011: ldnull
    IL_0016: call 0x0A000061
    IL_001B: brfalse IL_0031
    IL_001C: ldarg.0
    IL_0021: ldstr 0x700232DD
    IL_0026: call 0x0A000012
    IL_0027: conv.u8
    IL_0028: ldloc.0
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_01
    IL_0030: stfld 0x04000F3A
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000F3A
    IL_0037: conv.r8
    IL_0038: ldarg.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_0040: call 0x0A00001B
    IL_0045: call 0x0A000013
    IL_004A: call 0x0A000014
    IL_004B: pop
    IL_004C: ret
    }

    public void OpenShop() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F40
    IL_0007: ret
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
    IL_003B: ldfld 0x04000F2A
    IL_0040: call 0x0A0000DF
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_BE
    IL_0045: IL_43
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_004D: stsfld 0x00002240
    IL_004E: ldelem.r8
    IL_004F: IL_42
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldelem.r8
    IL_0054: IL_41
    IL_0059: call 0x0600021D
    IL_005E: ldsfld 0x040007B2
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000F25
    IL_0066: ldc.i4.s 64
    IL_006B: call 0x0A0000E1
    IL_0070: ldstr 0x70022F09
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000F1B
    IL_0077: ldc.i4.1
    IL_0078: IL_58
    IL_007D: newobj 0x0100000B
    IL_0082: call 0x0A000098
    IL_0087: call 0x0A0002EA
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04000F40
    IL_0092: brfalse IL_019B
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_E0
    IL_0097: IL_42
    IL_0098: IL_22
    IL_0099: nop
    IL_009A: nop
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_22
    IL_009E: nop
    IL_009F: nop
    IL_00A4: stsfld 0x00002243
    IL_00A5: nop
    IL_00A6: IL_42
    IL_00AB: call 0x0600021D
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x04000F2B
    IL_00B6: call 0x0A0000E0
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BB: ldloca.s 67
    IL_00BC: IL_22
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: IL_C0
    IL_28000014C: switch (2684354594 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F4F
    IL_0007: ldarg.0
    IL_0008: ldc.i4.5
    IL_000D: newarr 0x0100003C
    IL_0012: stfld 0x04000F52
    IL_0013: ldarg.0
    IL_0018: call 0x0A000001
    IL_0019: ret
    }

    private void Awake() {
    IL_0000: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F4B
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F4C
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000F4E
    IL_0010: ldarg.0
    IL_0015: call 0x0A00002B
    IL_001A: ldstr 0x70022774
    IL_001F: call 0x0A0001C1
    IL_0020: conv.r8
    IL_0021: IL_C9
    IL_0022: IL_01
    IL_0023: nop
    IL_0024: stloc.0
    IL_0029: ldstr 0x7002270C
    IL_002E: call 0x0A0001C1
    IL_0033: call 0x0A0001C2
    IL_0034: ldarg.0
    IL_0039: ldstr 0x70000DDD
    IL_003E: call 0x06000220
    IL_0043: stfld 0x04000F4D
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000F4D
    IL_004B: ldc.i4.s 19
    IL_004C: IL_3C
    IL_004D: IL_3D
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: ldarg.0
    IL_0056: ldstr 0x70002065
    IL_005B: call 0x06000220
    IL_0060: stfld 0x04000F55
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000F55
    IL_0067: ldc.i4.1
    IL_00D4: switch (26 cases)
    }

    private void GoNext() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F4F
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ret
    }

    public void CashshopOpen() {
    IL_0004: ldstr 0x70001E8B
    IL_0005: ldarg.1
    IL_000A: call 0x0600021F
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000F54
    IL_0011: ldnull
    IL_0016: call 0x0A000061
    IL_001B: brfalse IL_0031
    IL_001C: ldarg.0
    IL_0021: ldstr 0x700232DD
    IL_0026: call 0x0A000012
    IL_0027: conv.u8
    IL_0028: ldloc.0
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_01
    IL_0030: stfld 0x04000F54
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000F54
    IL_0037: conv.r8
    IL_0038: ldarg.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_0040: call 0x0A00001B
    IL_0045: call 0x0A000013
    IL_004A: call 0x0A000014
    IL_004B: pop
    IL_004C: ret
    }

    public void OpenShop() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F57
    IL_0007: ret
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
    IL_003B: ldfld 0x04000F50
    IL_0040: call 0x0A0000DF
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000F57
    IL_004B: brfalse IL_0154
    IL_004C: IL_22
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_E0
    IL_0050: IL_42
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: IL_22
    IL_0057: nop
    IL_0058: nop
    IL_005D: stsfld 0x00002243
    IL_005E: nop
    IL_005F: IL_42
    IL_0064: call 0x0600021D
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000F51
    IL_006F: call 0x0A0000E0
    IL_0070: IL_22
    IL_0071: nop
    IL_0072: nop
    IL_0074: ldloca.s 67
    IL_0075: IL_22
    IL_0076: nop
    IL_0077: nop
    IL_0078: IL_C0
    IL_280000105: switch (2684354594 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: throw
    IL_0005: IL_44
    IL_000A: stfld 0x04000F59
    IL_000B: ldarg.0
    IL_000C: ldc.i4.2
    IL_0011: newarr 0x0100000B
    IL_0016: stfld 0x04000F6D
    IL_0017: ldarg.0
    IL_001C: call 0x0A000001
    IL_001D: ret
    }

    private void Awake() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0007: stsfld 0x0111283F
    IL_0008: nop
    IL_0009: stloc.0
    IL_000A: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001F05
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x04000F6D
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000BB3
    IL_001A: call 0x0A000095
    IL_001F: stfld 0x04000F66
    IL_0020: ldarg.0
    IL_0025: call 0x0A00002B
    IL_002A: ldstr 0x70022774
    IL_002F: call 0x0A0001C1
    IL_0030: conv.r8
    IL_0031: IL_C9
    IL_0032: IL_01
    IL_0033: nop
    IL_0034: stloc.0
    IL_0039: ldstr 0x7002270C
    IL_003E: call 0x0A0001C1
    IL_0043: call 0x0A0001C2
    IL_0044: ldarg.0
    IL_0049: ldstr 0x70001EA5
    IL_004E: call 0x06000220
    IL_0053: stfld 0x04000F5D
    IL_0054: ldarg.0
    IL_0059: ldstr 0x700004D5
    IL_005E: call 0x06000220
    IL_0063: stfld 0x04000F5E
    IL_0064: ldarg.0
    IL_0069: ldstr 0x70000001
    IL_006E: call 0x0A000004
    IL_006F: conv.r8
    IL_0070: shl
    IL_0071: nop
    IL_0072: nop
    IL_0074: br.s IL_00F2
    IL_0075: conv.r4
    IL_0077: ldarga.s 0
    IL_0078: ldarg.2
    IL_0079: ldarg.0
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000F6E
    IL_0084: ldfld 0x04000380
    IL_0089: stfld 0x04000F5F
    IL_008A: ldarg.0
    IL_008B: ldarg.0
    IL_0090: ldfld 0x04000F5F
    IL_0095: stfld 0x04000F60
    IL_0096: ldarg.0
    IL_0097: ldarg.0
    IL_009C: ldfld 0x04000F6E
    IL_00A1: ldfld 0x04000382
    IL_00A6: stfld 0x04000F62
    IL_00A7: ldarg.0
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x04000F6E
    IL_00B2: ldfld 0x04000381
    IL_00B7: stfld 0x04000F61
    IL_00B8: ldarg.0
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x04000F6E
    IL_00C3: ldfld 0x04000383
    IL_00C8: stfld 0x04000F63
    IL_00C9: ldarg.0
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04000F62
    IL_00D0: ldc.i4.3
    IL_00D1: IL_5A
    IL_00D2: ldarg.0
    IL_00D7: ldfld 0x04000F61
    IL_00D8: IL_58
    IL_00D9: ldarg.0
    IL_00DE: ldfld 0x04000F5F
    IL_00DF: IL_59
    IL_00E4: stfld 0x04000F64
    IL_00E5: ldarg.0
    IL_00E6: ldc.i4.0
    IL_00E7: ldarg.0
    IL_00EC: ldfld 0x04000F64
    IL_00F1: call 0x0A000080
    IL_00F6: stfld 0x04000F64
    IL_00F7: ldarg.0
    IL_00F8: dup
    IL_00FD: ldfld 0x04000F5F
    IL_00FE: ldarg.0
    IL_0103: ldfld 0x04000F5F
    IL_0104: ldarg.0
    IL_0109: ldfld 0x04000F6D
    IL_010A: ldc.i4.0
    IL_010B: IL_94
    IL_010C: IL_5A
    IL_010D: conv.i2
    IL_010E: IL_22
    IL_010F: IL_CD
    IL_0110: IL_CC
    IL_0111: IL_CC
    IL_0112: IL_3D
    IL_0113: IL_5A
    IL_0114: not
    IL_0115: IL_58
    IL_011A: stfld 0x04000F5F
    IL_011B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F5B
    IL_000A: brfalse IL_0075
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000F65
    IL_0016: call 0x0A000024
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldelem.r8
    IL_001B: IL_41
    IL_001C: IL_5A
    IL_001D: IL_58
    IL_0022: stfld 0x04000F65
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000F65
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000F5F
    IL_002F: conv.i2
    IL_0030: IL_44
    IL_0035: beq IL_2000036
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000F5F
    IL_003C: conv.i2
    IL_0041: stfld 0x04000F65
    IL_0042: ldarg.0
    IL_0043: ldc.i4.0
    IL_0048: stfld 0x04000F5B
    IL_0049: ldarg.0
    IL_004A: dup
    IL_004F: ldfld 0x04000F5D
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000F5F
    IL_0056: IL_58
    IL_005B: stfld 0x04000F5D
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000F5F
    IL_0062: ldc.i4.0
    IL_0067: call 0x0600021E
    IL_0068: pop
    IL_0069: ldarg.0
    IL_006A: ldc.i4.1
    IL_006F: stfld 0x04000F67
    IL_0074: br IL_00B0
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000F5A
    IL_007F: brtrue IL_00B0
    IL_0080: ldarg.0
    IL_0081: dup
    IL_0086: ldfld 0x04000F58
    IL_008B: call 0x0A000024
    IL_008C: IL_58
    IL_0091: stfld 0x04000F58
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000F58
    IL_0098: IL_22
    IL_0099: nop
    IL_009A: nop
    IL_009F: stsfld 0x000E433F
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: ldarg.0
    IL_00A3: ldc.i4.1
    IL_00A8: stfld 0x04000F5B
    IL_00A9: ldarg.0
    IL_00AA: ldc.i4.1
    IL_00AF: stfld 0x04000F5A
    IL_00B0: ldarg.0
    IL_00B5: ldfld 0x04000F5C
    IL_00BA: brtrue IL_00F3
    IL_00BB: ldarg.0
    IL_00BC: ldarg.0
    IL_00C1: ldfld 0x04000F59
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_87
    IL_00C6: IL_43
    IL_00CB: call 0x0A000024
    IL_00CC: IL_22
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: IL_96
    IL_00D0: IL_44
    IL_00D1: IL_5A
    IL_00D6: call 0x0A0000C0
    IL_00DB: stfld 0x04000F59
    IL_00DC: ldarg.0
    IL_00E1: ldfld 0x04000F59
    IL_00E2: IL_22
    IL_00E3: nop
    IL_00E4: nop
    IL_00E5: IL_87
    IL_00E6: IL_43
    IL_0107: switch (7 cases)
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
    IL_003B: ldfld 0x04000F68
    IL_0040: call 0x0A0000DF
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_E0
    IL_0045: IL_42
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_0052: stsfld 0x00002243
    IL_0053: nop
    IL_0054: IL_42
    IL_0059: call 0x0600021D
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000F69
    IL_0064: call 0x0A0000E0
    IL_0065: IL_22
    IL_0066: nop
    IL_0067: nop
    IL_0069: ldloca.s 67
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_C0
    IL_2800000FA: switch (2684354594 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 20
    IL_0007: newarr 0x0100003C
    IL_000C: stfld 0x04000F81
    IL_000D: ldarg.0
    IL_000E: ldc.i4.3
    IL_0013: newarr 0x0100003C
    IL_0018: stfld 0x04000F82
    IL_0019: ldarg.0
    IL_001B: ldc.i4.s 20
    IL_0020: newarr 0x0100000B
    IL_0025: stfld 0x04000FA0
    IL_0026: ldarg.0
    IL_0028: ldc.i4.s 20
    IL_0029: ldc.i4.5
    IL_002E: newobj 0x0A00016D
    IL_0033: stfld 0x04000FA1
    IL_0034: ldarg.0
    IL_0035: ldc.i4.5
    IL_003A: newarr 0x0100000B
    IL_003F: stfld 0x04000FA2
    IL_0040: ldarg.0
    IL_0041: ldc.i4.m1
    IL_0046: stfld 0x04000FA4
    IL_0047: ldarg.0
    IL_0049: ldc.i4.s 20
    IL_004E: newarr 0x0100000C
    IL_0053: stfld 0x04000FA7
    IL_0054: ldarg.0
    IL_0059: call 0x0A000001
    IL_005A: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FA7
    IL_0006: ldc.i4.0
    IL_000B: ldstr 0x700241C6
    IL_0010: stelem 0x0FA77B02
    IL_0011: nop
    IL_0012: ldarg.2
    IL_0013: ldc.i4.1
    IL_0018: ldstr 0x70024234
    IL_001D: stelem 0x0FA77B02
    IL_001E: nop
    IL_001F: ldarg.2
    IL_0020: ldc.i4.2
    IL_0025: ldstr 0x700242A2
    IL_002A: stelem 0x0FA77B02
    IL_002B: nop
    IL_002C: ldarg.2
    IL_002D: ldc.i4.3
    IL_0032: ldstr 0x70024310
    IL_0037: stelem 0x0FA77B02
    IL_0038: nop
    IL_0039: ldarg.2
    IL_003A: ldc.i4.4
    IL_003F: ldstr 0x7002437E
    IL_0044: stelem 0x0FA77B02
    IL_0045: nop
    IL_0046: ldarg.2
    IL_0047: ldc.i4.5
    IL_004C: ldstr 0x700243EC
    IL_0051: stelem 0x0FA77B02
    IL_0052: nop
    IL_0053: ldarg.2
    IL_0054: ldc.i4.6
    IL_0059: ldstr 0x7002445A
    IL_005E: stelem 0x0FA77B02
    IL_005F: nop
    IL_0060: ldarg.2
    IL_0061: ldc.i4.7
    IL_0066: ldstr 0x700244C8
    IL_006B: stelem 0x0FA77B02
    IL_006C: nop
    IL_006D: ldarg.2
    IL_006E: ldc.i4.8
    IL_0073: ldstr 0x70024536
    IL_0078: stelem 0x0FA77B02
    IL_0079: nop
    IL_007A: ldarg.2
    IL_007C: ldc.i4.s 9
    IL_0081: ldstr 0x700245A4
    IL_0086: stelem 0x0FA77B02
    IL_0087: nop
    IL_0088: ldarg.2
    IL_008A: ldc.i4.s 10
    IL_008F: ldstr 0x70024612
    IL_0094: stelem 0x0FA77B02
    IL_0095: nop
    IL_0096: ldarg.2
    IL_0098: ldc.i4.s 11
    IL_009D: ldstr 0x70024680
    IL_00A2: stelem 0x0FA77B02
    IL_00A3: nop
    IL_00A4: ldarg.2
    IL_00A6: ldc.i4.s 12
    IL_00AB: ldstr 0x700246EE
    IL_00B0: stelem 0x0FA77B02
    IL_00B1: nop
    IL_00B2: ldarg.2
    IL_00B4: ldc.i4.s 13
    IL_00B9: ldstr 0x7002475C
    IL_00BE: stelem 0x0FA77B02
    IL_00BF: nop
    IL_00C0: ldarg.2
    IL_00C2: ldc.i4.s 14
    IL_00C7: ldstr 0x700247CA
    IL_00CC: stelem 0x0FA77B02
    IL_00CD: nop
    IL_00CE: ldarg.2
    IL_00D0: ldc.i4.s 15
    IL_00D5: ldstr 0x70024838
    IL_00DA: stelem 0x0FA77B02
    IL_00DB: nop
    IL_00DC: ldarg.2
    IL_00DE: ldc.i4.s 16
    IL_00E3: ldstr 0x700248A6
    IL_00E8: stelem 0x0FA77B02
    IL_00E9: nop
    IL_00EA: ldarg.2
    IL_00EC: ldc.i4.s 17
    IL_00F1: ldstr 0x70024914
    IL_00F6: stelem 0x0FA77B02
    IL_00F7: nop
    IL_00F8: ldarg.2
    IL_00FA: ldc.i4.s 18
    IL_00FF: ldstr 0x70024982
    IL_0104: stelem 0x0FA77B02
    IL_0105: nop
    IL_0106: ldarg.2
    IL_0108: ldc.i4.s 19
    IL_010D: ldstr 0x700249F0
    IL_0112: stelem 0x00000000
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F9C
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F9D
    IL_0020: ret
    }

    private void ShotLoading() {
    IL_0004: newobj 0x060007D5
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x040010B0
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x040010B3
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_001A: stfld 0x040010B4
    IL_001B: ldloc.0
    IL_001C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001F9B
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x04000FA2
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000DDD
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F9B
    IL_0020: ldarg.0
    IL_0025: call 0x0A0000DA
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: IL_C0
    IL_002B: IL_3E
    IL_002C: IL_5A
    IL_0031: stfld 0x04000F9A
    IL_0032: ldarg.0
    IL_0037: ldstr 0x70000BB3
    IL_003C: call 0x0A000095
    IL_0041: stfld 0x04000FA3
    IL_0042: ldarg.0
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_BE
    IL_0047: IL_C3
    IL_004C: stfld 0x04000F8D
    IL_004D: ldarg.0
    IL_004E: IL_22
    IL_004F: nop
    IL_0050: nop
    IL_0051: IL_F0
    IL_0052: IL_43
    IL_0057: stfld 0x04000F8E
    IL_0058: ldarg.0
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: IL_AA
    IL_005D: IL_43
    IL_0062: stfld 0x04000F8F
    IL_0063: ldarg.0
    IL_0064: ldarg.0
    IL_0069: call 0x2B00008F
    IL_006E: ldfld 0x04000505
    IL_0073: stfld 0x04000FA1
    IL_0074: ldarg.0
    IL_0079: ldstr 0x70002093
    IL_007E: call 0x06000220
    IL_0083: stfld 0x04000FA5
    IL_0084: ldarg.0
    IL_0089: ldstr 0x7000054F
    IL_008E: call 0x060003F9
    IL_0093: stfld 0x04000FA0
    IL_0098: ldstr 0x70000121
    IL_009D: call 0x0A000004
    IL_009E: ldnull
    IL_00A3: call 0x0A000061
    IL_00A8: brfalse IL_00CE
    IL_00A9: ldarg.0
    IL_00AA: ldarg.0
    IL_00AF: ldfld 0x04000F89
    IL_00B4: call 0x0A00001B
    IL_00B9: call 0x0A000013
    IL_00BE: call 0x0A000014
    IL_00BF: conv.u4
    IL_00C0: ldarg.1
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: IL_01
    IL_00C8: stfld 0x04000F8B
    IL_00CD: br IL_00E3
    IL_00CE: ldarg.0
    IL_00D3: ldstr 0x70000121
    IL_00D8: call 0x0A000004
    IL_00D9: conv.r8
    IL_00DA: ldarg.3
    IL_00DB: nop
    IL_00DC: nop
    IL_00DD: stloc.0
    IL_00E2: stfld 0x04000F8B
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000F8B
    IL_00E9: ldnull
    IL_00EE: call 0x0A000021
    IL_00F3: brfalse IL_0105
    IL_00F4: ldarg.0
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x04000F8B
    IL_00FB: conv.r8
    IL_0100: ldsfld 0x7D2B0000
    IL_0105: newobj 0x1604000F
    IL_0106: stloc.0
    IL_010B: br IL_0145
    IL_010C: ldarg.0
    IL_0111: ldfld 0x04000FA0
    IL_0112: ldloc.0
    IL_0113: IL_94
    IL_0115: ldc.i4.s -2
    IL_01B2: switch (38 cases)
    }

    public void UpdateSkillStat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FA1
    IL_0006: ldarg.1
    IL_0007: ldc.i4.0
    IL_000C: call 0x0A000134
    IL_0011: ldfld 0x040004FC
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000FA0
    IL_0019: ldarg.1
    IL_001A: IL_94
    IL_001B: ldc.i4.4
    IL_001C: IL_3F
    IL_001D: IL_01
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ret
    IL_0022: ldloc.0
    IL_0023: ldc.i4.1
    IL_00A8: switch (32 cases)
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000FA6
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000FA6
    IL_0010: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F92
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000F93
    IL_000E: ret
    }

    public void FindEmptySlot() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000FA4
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002C
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000FA2
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_0016: ldc.i4.m1
    IL_004B: switch (12 cases)
    }

    public void ShortCut() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F90
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000FA2
    IL_000C: ldarg.1
    IL_000D: IL_94
    IL_00C6: switch (45 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F92
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000F93
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000F93
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000F93
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
    IL_0033: stfld 0x04000F92
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000F93
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000F9F
    IL_0049: brtrue IL_0111
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000F8D
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x002941C2
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000F8D
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000F8D
    IL_0067: shl
    IL_006C: call 0x0A000024
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0070: ldc.i4.0
    IL_0071: IL_44
    IL_0072: IL_5A
    IL_0077: call 0x0A000114
    IL_0078: IL_58
    IL_007D: stfld 0x04000F8D
    IL_0082: br IL_0111
    IL_0083: ldarg.0
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_008B: stsfld 0x0F8D7DC2
    IL_008C: nop
    IL_008D: ldarg.2
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000F8E
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000F8E
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00B0: stfld 0x04000F8E
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000F8E
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: IL_42
    IL_00BD: IL_50
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: nop
    IL_00CB: stfld 0x04000F8E
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000F8F
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000F8F
    IL_00DD: call 0x0A000024
    IL_00DE: IL_22
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_FA
    IL_00E2: IL_43
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000114
    IL_00E9: IL_59
    IL_00EE: stfld 0x04000F8F
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000F8F
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: shr
    IL_00F9: IL_43
    IL_00FA: IL_42
    IL_00FC: ldloca.s 0
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: ldarg.0
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: shr
    IL_0104: IL_43
    IL_0109: stfld 0x04000F8F
    IL_010A: ldarg.0
    IL_010B: ldc.i4.1
    IL_0110: stfld 0x04000F9F
    IL_0111: ldc.i4.0
    IL_0116: call 0x0A0000D6
    IL_011B: brfalse IL_015F
    IL_0120: call 0x0A0000D7
    IL_0121: stloc.1
    IL_0123: ldloca.s 1
    IL_0128: ldfld 0x0A000023
    IL_0129: ldarg.0
    IL_012E: ldfld 0x04000F9A
    IL_012F: IL_41
    IL_0130: pop
    IL_0131: nop
    IL_0132: nop
    IL_0133: nop
    IL_0134: ldarg.0
    IL_0135: ldc.i4.1
    IL_013A: stfld 0x04000F95
    IL_013B: ldarg.0
    IL_0140: call 0x0A0000D7
    IL_0141: stloc.2
    IL_0143: ldloca.s 2
    IL_0148: ldfld 0x0A00005E
    IL_014D: stfld 0x04000F98
    IL_014E: ldarg.0
    IL_014F: ldarg.0
    IL_0154: ldfld 0x04000F97
    IL_0159: stfld 0x04000F99
    IL_015E: br IL_0178
    IL_015F: ldc.i4.0
    IL_0164: call 0x0A0000D8
    IL_0169: brfalse IL_0178
    IL_016A: ldarg.0
    IL_016B: ldc.i4.0
    IL_0170: stfld 0x04000F95
    IL_0171: ldarg.0
    IL_0172: ldc.i4.0
    IL_0177: stfld 0x04000F96
    IL_0178: ldarg.0
    IL_017D: ldfld 0x04000F95
    IL_0182: brfalse IL_0208
    IL_0187: call 0x0A0000D7
    IL_0188: stloc.3
    IL_018A: ldloca.s 3
    IL_018F: ldfld 0x0A00005E
    IL_0190: ldarg.0
    IL_0195: ldfld 0x04000F98
    IL_0196: IL_59
    IL_019B: call 0x0A00007F
    IL_019C: IL_22
    IL_019D: nop
    IL_019E: nop
    IL_019F: nop
    IL_01A0: IL_41
    IL_01A1: IL_43
    IL_01A2: ldloc.1
    IL_01A3: nop
    IL_01A4: nop
    IL_01A5: nop
    IL_01A6: ldarg.0
    IL_01A7: ldc.i4.1
    IL_01AC: stfld 0x04000F96
    IL_01AD: ldarg.0
    IL_01B2: call 0x0A0000D7
    IL_01B4: stloc.s 4
    IL_01B6: ldloca.s 4
    IL_01BB: ldfld 0x0A00005E
    IL_01BC: ldarg.0
    IL_01C1: ldfld 0x04000F98
    IL_01C2: IL_59
    IL_01C3: IL_22
    IL_01C4: nop
    IL_01C5: nop
    IL_01C6: IL_F0
    IL_01C7: IL_43
    IL_01CC: call 0x0A0000D9
    IL_01CD: conv.i2
    IL_01CE: add
    IL_01CF: IL_5A
    IL_01D0: ldarg.0
    IL_01D5: ldfld 0x04000F99
    IL_01D6: IL_58
    IL_01DB: stfld 0x04000F97
    IL_01DC: ldarg.0
    IL_01DD: ldarg.0
    IL_01E2: ldfld 0x04000F97
    IL_01E3: IL_22
    IL_01E4: nop
    IL_01E5: nop
    IL_01E6: nop
    IL_01E7: nop
    IL_01EC: call 0x0A000114
    IL_01F1: stfld 0x04000F97
    IL_01F2: ldarg.0
    IL_01F3: ldarg.0
    IL_01F8: ldfld 0x04000F97
    IL_01F9: IL_22
    IL_01FA: nop
    IL_01FF: stsfld 0x9C28C484
    IL_0200: IL_01
    IL_0201: nop
    IL_0202: stloc.0
    IL_0207: stfld 0x04000F97
    IL_020C: ldstr 0x7000064F
    IL_0211: call 0x0A000095
    IL_0212: stloc.0
    IL_0213: ldloc.0
    IL_0214: ldc.i4.1
    IL_02C5: switch (43 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F8A
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000F8A
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000F8A
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
    }

    public void jumpSence() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000F91
    IL_0007: ldarg.1
    IL_000C: brtrue IL_001C
    IL_0011: ldstr 0x70022F87
    IL_0016: call 0x0A000128
    IL_001B: br IL_002D
    IL_001C: ldarg.1
    IL_001D: ldc.i4.1
    IL_004A: switch (10 cases)
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F88
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000F94
    IL_0047: ldc.i4.0
    IL_0048: IL_3D
    IL_0049: stloc.1
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000FAA
    IL_0057: brfalse IL_005E
    IL_0058: ldc.i4.0
    IL_005D: call 0x0A0001B9
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000F8D
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: ldelem.r8
    IL_006D: IL_43
    IL_006E: IL_22
    IL_006F: nop
    IL_0070: nop
    IL_0071: ldelem.r8
    IL_0072: IL_43
    IL_0077: call 0x0600021D
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000F70
    IL_0082: call 0x0A0000E0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000F8E
    IL_0089: IL_22
    IL_008A: nop
    IL_008B: nop
    IL_008C: rem
    IL_008D: IL_43
    IL_008E: IL_22
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_F0
    IL_0092: IL_43
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_C8
    IL_0097: IL_42
    IL_009C: call 0x0600021D
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x04000F72
    IL_00A7: call 0x0A0000E0
    IL_00A8: IL_22
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: IL_F0
    IL_00AC: IL_42
    IL_00AD: IL_22
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: IL_F0
    IL_00B1: IL_41
    IL_00B2: IL_22
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: IL_C8
    IL_00B6: IL_42
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BC: ldloc 10306
    IL_00BD: ldc.i4.7
    IL_00BE: ldarg.0
    IL_00BF: nop
    IL_00C0: ldloc.0
    IL_00C1: ldarg.0
    IL_00C6: ldfld 0x04000F71
    IL_00CB: call 0x0A0000E0
    IL_00CC: IL_22
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: IL_3E
    IL_00D0: IL_43
    IL_00D1: IL_22
    IL_00D2: nop
    IL_00D3: nop
    IL_00D8: newobj 0x00002242
    IL_00D9: ldelem.r8
    IL_00DA: IL_42
    IL_00DB: IL_22
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: IL_C0
    IL_00DF: IL_41
    IL_00E4: call 0x0600021D
    IL_00E9: ldsfld 0x040007B2
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000FA3
    IL_00F1: ldc.i4.s 68
    IL_00F6: call 0x0A0000E1
    IL_00FB: call 0x0A0002EA
    IL_00FC: IL_22
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: IL_E0
    IL_0100: IL_42
    IL_0101: IL_22
    IL_0102: nop
    IL_0103: nop
    IL_0104: nop
    IL_0105: nop
    IL_0106: IL_22
    IL_0107: nop
    IL_0108: nop
    IL_010D: stsfld 0x00002243
    IL_010E: nop
    IL_010F: IL_42
    IL_0114: call 0x0600021D
    IL_0115: ldarg.0
    IL_011A: ldfld 0x04000F78
    IL_011F: call 0x0A0000E0
    IL_0120: IL_22
    IL_0121: nop
    IL_0122: nop
    IL_0124: ldloca.s 67
    IL_0125: IL_22
    IL_0126: nop
    IL_0127: nop
    IL_0128: IL_C0
    IL_2800001B5: switch (2684354594 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.6
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000FB6
    IL_000C: ldarg.0
    IL_000D: ldc.i4.6
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000FB7
    IL_0018: ldarg.0
    IL_0019: ldc.i4.6
    IL_001E: newarr 0x0100000C
    IL_0023: stfld 0x04000FD3
    IL_0024: ldarg.0
    IL_0025: ldc.i4.6
    IL_002A: newarr 0x0100000B
    IL_002F: stfld 0x04000FD6
    IL_0030: ldarg.0
    IL_0031: ldc.i4.6
    IL_0033: ldc.i4.s 11
    IL_0038: newobj 0x0A000167
    IL_003D: stfld 0x04000FD7
    IL_003E: ldarg.0
    IL_0043: ldc.i4 161
    IL_0048: stfld 0x04000FD9
    IL_0049: ldarg.0
    IL_004A: ldc.i4.6
    IL_004F: newarr 0x0100000B
    IL_0054: stfld 0x04000FE0
    IL_0055: ldarg.0
    IL_005A: call 0x0A000001
    IL_005B: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000DDD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000FCF
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000E05
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000FDB
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000E0D
    IL_002A: call 0x06000220
    IL_002F: stfld 0x04000FDC
    IL_0030: ldarg.0
    IL_0035: ldstr 0x70000E1D
    IL_003A: call 0x06000220
    IL_003F: stfld 0x04000FDD
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70000E25
    IL_004A: call 0x06000220
    IL_004F: stfld 0x04000FDE
    IL_0050: ldarg.0
    IL_0055: ldstr 0x70000E2D
    IL_005A: call 0x06000220
    IL_005F: stfld 0x04000FDF
    IL_0060: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000FCC
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000FCD
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000DCD
    IL_002A: call 0x060003F9
    IL_002F: stfld 0x04000FE0
    IL_0030: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000FD8
    IL_0010: ldarg.0
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_BE
    IL_0015: IL_C3
    IL_001A: stfld 0x04000FC5
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_F0
    IL_0020: IL_43
    IL_0025: stfld 0x04000FC6
    IL_0026: ldarg.0
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: IL_AA
    IL_002B: IL_43
    IL_0030: stfld 0x04000FC7
    IL_0031: ldarg.0
    IL_0032: ldarg.0
    IL_0037: call 0x2B000090
    IL_003C: ldfld 0x040004CF
    IL_0041: stfld 0x04000FD7
    IL_0042: ldarg.0
    IL_0044: ldc.i4.s 95
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000FCF
    IL_004B: ldc.i4.5
    IL_004C: IL_5A
    IL_004D: IL_58
    IL_0052: stfld 0x04000FD0
    IL_0053: ldarg.0
    IL_0058: ldstr 0x70000DE5
    IL_005D: call 0x06000220
    IL_005E: conv.i2
    IL_0063: stfld 0x04000FD1
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000FD1
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04000FCF
    IL_0072: ldc.i4.s 100
    IL_0073: IL_5A
    IL_0074: conv.i2
    IL_0075: add
    IL_007A: stfld 0x04000FD1
    IL_007B: ldarg.0
    IL_0080: ldstr 0x70001EF5
    IL_0085: call 0x060003F9
    IL_008A: stfld 0x04000FD6
    IL_008F: ldstr 0x70000121
    IL_0094: call 0x0A000004
    IL_0095: ldnull
    IL_009A: call 0x0A000061
    IL_009F: brfalse IL_00C5
    IL_00A0: ldarg.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000FC3
    IL_00AB: call 0x0A00001B
    IL_00B0: call 0x0A000013
    IL_00B5: call 0x0A000014
    IL_00B6: conv.u4
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: IL_01
    IL_00BF: stfld 0x04000FC2
    IL_00C4: br IL_00DA
    IL_00C5: ldarg.0
    IL_00CA: ldstr 0x70000121
    IL_00CF: call 0x0A000004
    IL_00D0: conv.r8
    IL_00D1: ldarg.3
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: stloc.0
    IL_00D9: stfld 0x04000FC2
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000FC2
    IL_00E0: ldnull
    IL_00E5: call 0x0A000021
    IL_00EA: brfalse IL_00FC
    IL_00EB: ldarg.0
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x04000FC2
    IL_00F2: conv.r8
    IL_00F7: ldsfld 0x7D2B0000
    IL_00F8: IL_C4
    IL_00FA: ldarga.s 0
    IL_00FB: ldarg.2
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x04000FD3
    IL_0102: ldc.i4.0
    IL_0107: ldsfld 0x040007B2
    IL_0108: ldarg.0
    IL_010D: ldfld 0x04000FD8
    IL_0112: ldc.i4 143
    IL_0117: call 0x0A0000E1
    IL_011C: stelem 0x0FD37B02
    IL_011D: nop
    IL_011E: ldarg.2
    IL_011F: ldc.i4.1
    IL_0124: ldsfld 0x040007B2
    IL_0125: ldarg.0
    IL_012A: ldfld 0x04000FD8
    IL_012F: ldc.i4 147
    IL_0134: call 0x0A0000E1
    IL_0139: stelem 0x0FD37B02
    IL_013A: nop
    IL_013B: ldarg.2
    IL_013C: ldc.i4.2
    IL_0141: ldsfld 0x040007B2
    IL_0142: ldarg.0
    IL_0147: ldfld 0x04000FD8
    IL_014C: ldc.i4 148
    IL_0151: call 0x0A0000E1
    IL_0156: stelem 0x0FD37B02
    IL_0157: nop
    IL_0158: ldarg.2
    IL_0159: ldc.i4.3
    IL_015E: ldsfld 0x040007B2
    IL_015F: ldarg.0
    IL_0164: ldfld 0x04000FD8
    IL_0169: ldc.i4 146
    IL_016E: call 0x0A0000E1
    IL_0173: stelem 0x0FD37B02
    IL_0174: nop
    IL_0175: ldarg.2
    IL_0176: ldc.i4.4
    IL_017B: ldsfld 0x040007B2
    IL_017C: ldarg.0
    IL_0181: ldfld 0x04000FD8
    IL_0186: ldc.i4 154
    IL_018B: call 0x0A0000E1
    IL_0190: stelem 0x0FD37B02
    IL_0191: nop
    IL_0192: ldarg.2
    IL_0193: ldc.i4.5
    IL_0198: ldsfld 0x040007B2
    IL_0199: ldarg.0
    IL_019E: ldfld 0x04000FD8
    IL_01A3: ldc.i4 145
    IL_01A8: call 0x0A0000E1
    IL_01AD: stelem 0x00061772
    IL_01B2: cpobj 0x009F281B
    IL_01B3: nop
    IL_01B4: stloc.0
    IL_01B5: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000FD4
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000FD5
    IL_000E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FD4
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000FD5
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000FD5
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000FD5
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
    IL_0033: stfld 0x04000FD4
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000FD5
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000FCB
    IL_0049: brtrue IL_0111
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000FC5
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x002941C2
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000FC5
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000FC5
    IL_0067: shl
    IL_006C: call 0x0A000024
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0070: ldc.i4.0
    IL_0071: IL_44
    IL_0072: IL_5A
    IL_0077: call 0x0A000114
    IL_0078: IL_58
    IL_007D: stfld 0x04000FC5
    IL_0082: br IL_0111
    IL_0083: ldarg.0
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_008B: stsfld 0x0FC57DC2
    IL_008C: nop
    IL_008D: ldarg.2
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000FC6
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000FC6
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00B0: stfld 0x04000FC6
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000FC6
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: IL_42
    IL_00BD: IL_50
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: nop
    IL_00CB: stfld 0x04000FC6
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000FC7
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000FC7
    IL_00DD: call 0x0A000024
    IL_00DE: IL_22
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_FA
    IL_00E2: IL_43
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000114
    IL_00E9: IL_59
    IL_00EE: stfld 0x04000FC7
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000FC7
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: shr
    IL_00F9: IL_43
    IL_00FA: IL_42
    IL_00FC: ldloca.s 0
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: ldarg.0
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: shr
    IL_0104: IL_43
    IL_0109: stfld 0x04000FC7
    IL_010A: ldarg.0
    IL_010B: ldc.i4.1
    IL_0110: stfld 0x04000FCB
    IL_0115: ldstr 0x7000064F
    IL_011A: call 0x0A000095
    IL_011B: stloc.0
    IL_011C: ldloc.0
    IL_011D: ldc.i4.1
    IL_01CE: switch (43 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    public void StatInfo_detail() {
    IL_0000: ldarg.1
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0005: ldarg 6
    IL_0006: nop
    IL_0007: nop
    IL_0008: ldarg.3
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldc.i4.m1
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: dup
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_35
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_001A: ldarg 0
    IL_001B: nop
    IL_001C: IL_55
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0024: br IL_0085
    IL_0025: ldarg.0
    IL_002A: ldc.i4 163
    IL_002F: stfld 0x04000FD9
    IL_0034: br IL_0085
    IL_0035: ldarg.0
    IL_003A: ldc.i4 162
    IL_003F: stfld 0x04000FD9
    IL_0044: br IL_0085
    IL_0045: ldarg.0
    IL_004A: ldc.i4 167
    IL_004F: stfld 0x04000FD9
    IL_0054: br IL_0085
    IL_0055: ldarg.0
    IL_005A: ldc.i4 165
    IL_005F: stfld 0x04000FD9
    IL_0064: br IL_0085
    IL_0065: ldarg.0
    IL_006A: ldc.i4 161
    IL_006F: stfld 0x04000FD9
    IL_0074: br IL_0085
    IL_0075: ldarg.0
    IL_007A: ldc.i4 170
    IL_007F: stfld 0x04000FD9
    IL_0084: br IL_0085
    IL_0085: ret
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FC1
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000FC1
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000FC1
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FC0
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000FC9
    IL_0047: ldc.i4.0
    IL_0048: IL_3E
    IL_0049: ldloc.0
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldc.i4.0
    IL_0052: call 0x0A0001B9
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000FC5
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_22
    IL_005F: nop
    IL_0060: nop
    IL_0061: ldelem.r8
    IL_0062: IL_43
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: ldelem.r8
    IL_0067: IL_43
    IL_006C: call 0x0600021D
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000FAC
    IL_0077: call 0x0A0000E0
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000FC6
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: IL_54
    IL_0082: IL_43
    IL_0083: IL_22
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_F0
    IL_0087: IL_43
    IL_0088: IL_22
    IL_0089: nop
    IL_008A: nop
    IL_008B: IL_C8
    IL_008C: IL_42
    IL_0091: call 0x0600021D
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000FAD
    IL_009C: call 0x0A0000E0
    IL_009D: IL_22
    IL_009E: nop
    IL_009F: nop
    IL_00A0: IL_E0
    IL_00A1: IL_42
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AE: stsfld 0x00002243
    IL_00AF: nop
    IL_00B0: IL_42
    IL_00B5: call 0x0600021D
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x04000FB2
    IL_00C0: call 0x0A0000E0
    IL_00C1: IL_22
    IL_00C2: nop
    IL_00C3: nop
    IL_00C5: ldloca.s 67
    IL_00C6: IL_22
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: IL_C0
    IL_280000156: switch (2684354594 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FE1
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000FE7
    IL_0018: ldarg.0
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: stfld 0x04000FE6
    IL_0023: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000FE6
    IL_000B: ret
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
    IL_000C: ldc.i4.s 15
    IL_0225: switch (133 cases)
    }

    public void PressDamage() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000FE2
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FE4
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_43
    IL_0010: newarr 0x02000000
    IL_0011: dup
    IL_0016: ldfld 0x04000FE6
    IL_001B: call 0x0A000024
    IL_001C: IL_58
    IL_0021: stfld 0x04000FE6
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000FE5
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_43
    IL_002E: ldc.i4.7
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000FE6
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000FE5
    IL_003E: IL_44
    IL_003F: stloc.2
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000FE7
    IL_0049: ldc.i4.0
    IL_004A: conv.r8
    IL_004C: ldc.i4.s 0
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000FE6
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000FE4
    IL_005B: IL_44
    IL_005C: IL_3D
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_006A: stfld 0x04000FE6
    IL_006B: ldarg.0
    IL_0070: call 0x0A00000A
    IL_0071: ldc.i4.0
    IL_0072: conv.r8
    IL_0073: stloc.1
    IL_0074: nop
    IL_0075: nop
    IL_0076: stloc.0
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000FE1
    IL_0081: call 0x0A00004B
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0085: ldelem.r8
    IL_212A: switch (2088 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: ldelem.i
    IL_0003: IL_99
    IL_0004: IL_D9
    IL_0005: IL_3F
    IL_000A: stfld 0x04000FE9
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FE8
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000FE8
    IL_0013: conv.r8
    IL_0014: mul
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000FEB
    IL_001D: ret
    }

    public void DropCancel() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70024A98
    IL_000A: call 0x0A00007B
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x04000FEA
    IL_0012: ret
    }

    public void Drop() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70024A98
    IL_000A: call 0x0A00007B
    IL_000B: ldarg.1
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: call 0x0A00000A
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001E: ldc.i4 7415872
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: br IL_0036
    IL_0026: ldarg.0
    IL_002B: ldstr 0x70024A98
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_002F: rem
    IL_FCD4: switch (16168 cases)
    }

    private void Disappear() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FE8
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_0012: stsfld 0x00082840
    IL_0013: nop
    IL_0014: stloc.0
    IL_0015: conv.r8
    IL_0016: ldloc.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: call 0x0A00000A
    IL_0020: ldc.i4.0
    IL_0021: conv.r8
    IL_0022: stloc.1
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FEA
    IL_000A: brfalse IL_00EB
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000FE8
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0028: ldstr 0x02000000
    IL_002D: ldfld 0x04000FE8
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000FEB
    IL_0038: call 0x0A000024
    IL_003D: call 0x0A000008
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: IL_34
    IL_0042: IL_44
    IL_0047: call 0x0A000008
    IL_0048: conv.r8
    IL_0049: IL_B5
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldarg.0
    IL_004E: dup
    IL_0053: ldfld 0x04000FE9
    IL_0054: IL_22
    IL_0055: nop
    IL_0056: nop
    IL_0057: rem
    IL_90FC: switch (9256 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 25
    IL_0007: newarr 0x0200006B
    IL_000C: stfld 0x04000FF9
    IL_000D: ldarg.0
    IL_000E: ldc.i4.6
    IL_0013: newarr 0x0100000B
    IL_0018: stfld 0x04000FFA
    IL_0019: ldarg.0
    IL_001E: call 0x0A000001
    IL_001F: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000091
    IL_000B: ldfld 0x0400051A
    IL_0010: stfld 0x04000FF9
    IL_0011: ret
    }

    public void IconImage_Only() {
    IL_0000: ldarg.1
    IL_0005: ldc.i4 1000000
    IL_0006: add
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldarg.0
    IL_000E: ldfld 0x04000FF9
    IL_000F: ldloc.0
    IL_0010: IL_8F
    IL_0011: conv.i2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.0
    IL_0019: ldfld 0x04000517
    IL_001E: stfld 0x04000FF8
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000FF8
    IL_0025: ret
    }

    public void Cost_only() {
    IL_0000: ldarg.1
    IL_0005: ldc.i4 1000000
    IL_0006: add
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_000D: ldfld 0x04000FF9
    IL_000E: ldloc.0
    IL_000F: IL_8F
    IL_0010: conv.i2
    IL_0011: nop
    IL_0012: nop
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000519
    IL_0019: stloc.1
    IL_001A: ldloc.1
    IL_001B: ret
    }

    public void SetStat() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_001D
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000FFA
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0010: ldc.i4.s 10
    IL_0011: mul
    IL_0012: ldelem.i8
    IL_0013: ldarg.1
    IL_0015: ldc.i4.s 10
    IL_0016: add
    IL_0018: starg.s 1
    IL_0019: ldloc.0
    IL_001A: ldc.i4.1
    IL_001B: IL_58
    IL_001C: stloc.0
    IL_001D: ldloc.0
    IL_001E: ldc.i4.6
    IL_001F: IL_3F
    IL_0020: IL_E3
    IL_0021: IL_FF
    IL_0022: IL_FF
    IL_0023: IL_FF
    IL_0024: ldarg.0
    IL_0025: ldarg.1
    IL_002A: stfld 0x04000FEC
    IL_002B: ldarg.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000FF9
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000FEC
    IL_0038: IL_8F
    IL_0039: conv.i2
    IL_003A: nop
    IL_003B: nop
    IL_003C: ldarg.0
    IL_0041: ldfld 0x04000517
    IL_0046: stfld 0x04000FED
    IL_0047: ldarg.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000FF9
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000FEC
    IL_0054: IL_8F
    IL_0055: conv.i2
    IL_0056: nop
    IL_0057: nop
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000518
    IL_0062: stfld 0x04000FEE
    IL_0063: ldarg.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000FFA
    IL_006A: ldc.i4.4
    IL_006B: IL_94
    IL_0070: stfld 0x04000FF4
    IL_0071: ldarg.0
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04000FFA
    IL_0078: ldc.i4.5
    IL_0079: IL_94
    IL_007E: stfld 0x04000FF5
    IL_007F: ldarg.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000FF9
    IL_0086: ldarg.0
    IL_008B: ldfld 0x04000FEC
    IL_008C: IL_8F
    IL_008D: conv.i2
    IL_008E: nop
    IL_008F: nop
    IL_0090: ldarg.0
    IL_0095: ldfld 0x04000513
    IL_009A: stfld 0x04000FEF
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000FF4
    IL_00A1: ldc.i4.4
    IL_00A6: beq IL_00FD
    IL_00A7: ldarg.0
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x04000FFA
    IL_00AE: ldc.i4.0
    IL_00AF: IL_94
    IL_00B0: ldarg.0
    IL_00B5: ldfld 0x04000FEC
    IL_00B6: IL_5A
    IL_00B7: conv.i2
    IL_00B8: IL_22
    IL_00B9: IL_CD
    IL_00BA: IL_CC
    IL_00BB: IL_4C
    IL_00BC: IL_3D
    IL_00BD: IL_5A
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x04000FF4
    IL_00C4: conv.i2
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: nop
    IL_3FB1ECD5: switch (267156226 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FFB
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000001
    IL_0016: call 0x0A000004
    IL_0017: conv.r8
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: stfld 0x04000FFC
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000FFB
    IL_0028: conv.r8
    IL_002D: cpobj 0x7D0A0000
    IL_002E: IL_FD
    IL_0030: ldarga.s 0
    IL_0031: ldarg.2
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000FFB
    IL_0038: ldc.i4.0
    IL_0039: conv.r8
    IL_003E: brtrue IL_6F0A003F
    IL_003F: ret
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: ldstr 0x70000B6F
    IL_0048: conv.r8
    IL_004A: bge.s IL_004B
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: IL_22
    IL_004E: IL_CD
    IL_004F: IL_CC
    IL_0050: IL_4C
    IL_0051: IL_3E
    IL_0052: conv.r8
    IL_0054: bgt.s IL_0055
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FFB
    IL_000A: call 0x0A00001B
    IL_000B: conv.r8
    IL_000C: IL_AF
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000FFB
    IL_0016: ldc.i4.0
    IL_0017: conv.r8
    IL_001C: brtrue IL_6F0A001D
    IL_001D: stloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldc.i4.1
    IL_0022: conv.r8
    IL_0023: stloc.1
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_0031: stfld 0x04000FFE
    IL_0032: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FFB
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000FFC
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: ldloc.3
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_0017: dup
    IL_001C: ldfld 0x04000FFE
    IL_0021: call 0x0A000024
    IL_0022: IL_58
    IL_0027: stfld 0x04000FFE
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000FFE
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: IL_C0
    IL_0032: IL_3F
    IL_0033: IL_43
    IL_0035: bgt.s IL_0036
    IL_0036: nop
    IL_0037: nop
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000FFB
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000FFB
    IL_0044: conv.r8
    IL_0049: cpobj 0x280A0000
    IL_004A: ldc.i4.5
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_0052: call 0x0A000024
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldelem.r8
    IL_2C8A1C3: switch (11675738 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FFF
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00002A
    IL_0017: stfld 0x04001002
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000FFF
    IL_001F: ldc.i4.2
    IL_0020: conv.r8
    IL_0025: brtrue IL_7D0A0026
    IL_0026: nop
    IL_0028: starg.s 0
    IL_0029: ldarg.2
    IL_002A: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001000
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
    IL_0016: ldfld 0x04001002
    IL_001B: ldstr 0x70024AAC
    IL_001C: conv.r8
    IL_001D: IL_3C
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: pop
    IL_0022: ldarg.0
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_002C: stfld 0x04001001
    IL_002D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001002
    IL_000A: ldstr 0x70000AD5
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_3F
    IL_0015: conv.r8
    IL_0017: bgt.s IL_0018
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04001002
    IL_0024: ldstr 0x70000AE7
    IL_0025: conv.r8
    IL_0027: bge.s IL_0028
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_0031: stsfld 0x00306F3E
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04001002
    IL_003E: ldstr 0x70024AAC
    IL_003F: conv.r8
    IL_0041: bge.s IL_0042
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: IL_22
    IL_0045: IL_CD
    IL_0046: IL_CC
    IL_0047: stloc.2
    IL_C208: switch (12399 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04001001
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04001001
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04001001
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001F: stsfld 0x002D4340
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04001000
    IL_0034: conv.r8
    IL_0035: stloc.0
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldc.i4.0
    IL_003A: conv.r8
    IL_003B: stloc.1
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04001002
    IL_0045: conv.r8
    IL_0048: ldloc 0
    IL_0049: stloc.0
    IL_004E: br IL_0095
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04001001
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_550D5C: switch (1393472 cases)
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001004
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001004
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001003
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001003
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 275817431040
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001003
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001008
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001008
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001007
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001007
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00FD
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0024: ldc.i4.s 100
    IL_0029: call 0x0A000045
    IL_002E: stfld 0x04001006
    IL_002F: ldarg.0
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0037: ldc.i4 6714176
    IL_0038: nop
    IL_0039: stloc.0
    IL_003E: stfld 0x04001008
    IL_003F: ldarg.0
    IL_0040: ldc.i4.1
    IL_0045: stfld 0x04001007
    IL_004A: br IL_00FF
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04001009
    IL_0055: ldfld 0x04000032
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04001006
    IL_005C: conv.i2
    IL_005D: IL_43
    IL_005F: ldloc.s 0
    IL_0060: nop
    IL_0061: nop
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04001009
    IL_0068: ldc.i4.0
    IL_006D: call 0x06000013
    IL_0072: br IL_00F6
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04001009
    IL_007D: call 0x0A00000A
    IL_007E: ldc.i4.8
    IL_007F: conv.r8
    IL_0080: ldc.i4.m1
    IL_0081: nop
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04001009
    IL_008E: ldfld 0x0400001E
    IL_0093: ldstr 0x7000005B
    IL_0094: conv.r8
    IL_0096: brfalse.s IL_0097
    IL_0097: nop
    IL_0098: stloc.0
    IL_0099: conv.r8
    IL_009A: stloc.3
    IL_009B: nop
    IL_009C: nop
    IL_009D: stloc.0
    IL_009E: conv.r8
    IL_009F: neg
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04001009
    IL_00AD: ldfld 0x04000016
    IL_00AE: conv.r8
    IL_00B0: ldarga.s 0
    IL_00B1: nop
    IL_00B2: stloc.0
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x04001009
    IL_00B9: ldc.i4.1
    IL_00BE: stfld 0x04000022
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x04001009
    IL_00C9: ldfld 0x0400005B
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04001009
    IL_00D4: ldfld 0x0400002B
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x04001009
    IL_00DF: ldfld 0x0400002C
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04001009
    IL_00EA: ldfld 0x0400001E
    IL_00EB: IL_22
    IL_00EC: IL_CD
    IL_00ED: IL_CC
    IL_00EE: IL_CC
    IL_00EF: IL_3E
    IL_00F0: ldc.i4.0
    IL_00F1: conv.r8
    IL_00F2: ldnull
    IL_00F3: ldarg.1
    IL_00F4: nop
    IL_00F5: ldloc.0
    IL_00F6: ldarg.0
    IL_00F7: ldc.i4.m1
    IL_00FC: stfld 0x04001007
    IL_00FD: ldc.i4.0
    IL_00FE: ret
    IL_00FF: ldc.i4.1
    IL_0100: ret
    IL_0101: ldloc.1
    IL_0102: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001007
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100B
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100B
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100A
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400100A
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 413256384512
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400100A
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100E
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100E
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100D
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400100D
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 408961417216
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_199CD29: switch (6714176 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400100D
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001011
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001011
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001010
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001010
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 408961417216
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: ldelem.i
    IL_0024: IL_99
    IL_0025: IL_99
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001011
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001010
    IL_003C: br IL_0082
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001012
    IL_0043: ldc.i4.0
    IL_0048: stfld 0x040000AB
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04001012
    IL_0053: ldfld 0x040000AA
    IL_0054: conv.r8
    IL_0056: ldarg.s 0
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04001012
    IL_0063: ldfld 0x0400006B
    IL_0064: conv.r8
    IL_0066: ldarga.s 0
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: ldarg.0
    IL_006E: ldfld 0x04001012
    IL_0073: ldstr 0x700001F1
    IL_0078: call 0x0A00007B
    IL_0079: ldarg.0
    IL_007A: ldc.i4.m1
    IL_007F: stfld 0x04001010
    IL_0080: ldc.i4.0
    IL_0081: ret
    IL_0082: ldc.i4.1
    IL_0083: ret
    IL_0084: ldloc.1
    IL_0085: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001010
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001014
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001014
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001013
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001013
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 340241940480
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001013
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001018
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001018
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001017
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001017
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00F3
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0024: ldc.i4.s 100
    IL_0029: call 0x0A000045
    IL_002E: stfld 0x04001016
    IL_002F: ldarg.0
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0037: ldc.i4 6714176
    IL_0038: nop
    IL_0039: stloc.0
    IL_003E: stfld 0x04001018
    IL_003F: ldarg.0
    IL_0040: ldc.i4.1
    IL_0045: stfld 0x04001017
    IL_004A: br IL_00F5
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04001019
    IL_0055: ldfld 0x0400007D
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04001016
    IL_005C: IL_3E
    IL_005E: ldloc.s 0
    IL_005F: nop
    IL_0060: nop
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04001019
    IL_0067: ldc.i4.0
    IL_006C: call 0x06000027
    IL_0071: br IL_00EC
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04001019
    IL_007C: call 0x0A00000A
    IL_007D: ldc.i4.8
    IL_007E: conv.r8
    IL_007F: ldc.i4.m1
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04001019
    IL_008D: ldfld 0x040000AA
    IL_008E: conv.r8
    IL_0090: ldarg.s 0
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04001019
    IL_009D: ldfld 0x0400006B
    IL_009E: conv.r8
    IL_00A0: ldarga.s 0
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04001019
    IL_00A9: ldc.i4.1
    IL_00AE: stfld 0x0400006C
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04001019
    IL_00B9: ldfld 0x0400009E
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04001019
    IL_00C4: ldfld 0x04000084
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04001019
    IL_00CF: ldfld 0x04000082
    IL_00D0: ldarg.0
    IL_00D5: ldfld 0x04001019
    IL_00DA: ldfld 0x040000A7
    IL_00DB: ldarg.0
    IL_00E0: ldfld 0x04001019
    IL_00E5: ldfld 0x04000080
    IL_00E6: ldc.i4.0
    IL_00E7: conv.r8
    IL_00E8: ldnull
    IL_00E9: ldarg.1
    IL_00EA: nop
    IL_00EB: ldloc.0
    IL_00EC: ldarg.0
    IL_00ED: ldc.i4.m1
    IL_00F2: stfld 0x04001017
    IL_00F3: ldc.i4.0
    IL_00F4: ret
    IL_00F5: ldc.i4.1
    IL_00F6: ret
    IL_00F7: ldloc.1
    IL_00F8: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001017
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101B
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101B
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101A
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400101A
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 1242185072640
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: stsfld 0x00667340
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: stfld 0x0400101B
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x0400101A
    IL_003C: br IL_0144
    IL_003D: ldarg.0
    IL_0042: ldfld 0x0400101C
    IL_0047: ldfld 0x04000082
    IL_0048: ldc.i4.0
    IL_0049: IL_3D
    IL_004B: ldloc.s 0
    IL_004C: nop
    IL_004D: nop
    IL_004E: ldarg.0
    IL_0053: ldfld 0x0400101C
    IL_0054: ldc.i4.0
    IL_0059: call 0x06000027
    IL_005E: br IL_009C
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400101C
    IL_0069: ldfld 0x0400009E
    IL_006A: ldarg.0
    IL_006F: ldfld 0x0400101C
    IL_0074: ldfld 0x04000084
    IL_0075: ldarg.0
    IL_007A: ldfld 0x0400101C
    IL_007F: ldfld 0x04000082
    IL_0080: ldarg.0
    IL_0085: ldfld 0x0400101C
    IL_008A: ldfld 0x040000A7
    IL_008B: ldarg.0
    IL_0090: ldfld 0x0400101C
    IL_0095: ldfld 0x04000080
    IL_0096: ldc.i4.0
    IL_0097: conv.r8
    IL_0098: ldnull
    IL_0099: ldarg.1
    IL_009A: nop
    IL_009B: ldloc.0
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x0400101C
    IL_00A6: ldfld 0x040000A8
    IL_00A7: conv.r8
    IL_00AA: ldloc 0
    IL_00AB: stloc.0
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x0400101C
    IL_00B6: ldfld 0x040000A8
    IL_00BB: ldstr 0x70000177
    IL_00BC: conv.r8
    IL_00BD: IL_3C
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: stloc.0
    IL_00C1: pop
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x0400101C
    IL_00CC: ldfld 0x0400009D
    IL_00CD: conv.r8
    IL_00CE: IL_35
    IL_00CF: IL_01
    IL_00D0: nop
    IL_00D1: ldloc.0
    IL_00D2: ldarg.0
    IL_00D7: ldfld 0x0400101C
    IL_00DC: ldfld 0x0400009F
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x0400101C
    IL_00E7: ldfld 0x040000A7
    IL_00E8: conv.r8
    IL_00E9: ldc.i4.2
    IL_00EA: nop
    IL_00EB: nop
    IL_00EC: stloc.0
    IL_00ED: ldarg.0
    IL_00F2: ldfld 0x0400101C
    IL_00F7: ldfld 0x04000095
    IL_00F8: conv.r8
    IL_00F9: IL_B9
    IL_00FA: ldarg.1
    IL_00FB: nop
    IL_00FC: ldloc.0
    IL_00FD: ldarg.0
    IL_0102: ldfld 0x0400101C
    IL_0103: IL_22
    IL_0104: nop
    IL_0105: nop
    IL_0106: nop
    IL_0107: nop
    IL_010C: stfld 0x0400007E
    IL_010D: ldarg.0
    IL_0112: ldfld 0x0400101C
    IL_0117: ldfld 0x0400009C
    IL_0118: ldc.i4.1
    IL_0119: conv.r8
    IL_011A: IL_EC
    IL_011B: ldarg.2
    IL_011C: nop
    IL_011D: ldloc.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x0400101C
    IL_0128: call 0x0A000003
    IL_0129: ldc.i4.1
    IL_012A: conv.r8
    IL_012C: ldc.i4.s 0
    IL_012D: nop
    IL_012E: stloc.0
    IL_012F: ldarg.0
    IL_0134: ldfld 0x0400101C
    IL_0135: ldc.i4.1
    IL_013A: stfld 0x0400006C
    IL_013B: ldarg.0
    IL_013C: ldc.i4.m1
    IL_0141: stfld 0x0400101A
    IL_0142: ldc.i4.0
    IL_0143: ret
    IL_0144: ldc.i4.1
    IL_0145: ret
    IL_0146: ldloc.1
    IL_0147: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400101A
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101E
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101E
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101D
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400101D
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_37
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_005A
    IL_0021: ldarg.0
    IL_0026: ldfld 0x0400101F
    IL_002B: ldstr 0x70000CD1
    IL_0030: call 0x0A0000F9
    IL_0035: stfld 0x04000282
    IL_0036: ldarg.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x0400101F
    IL_0041: ldfld 0x04000282
    IL_0046: stfld 0x0400101E
    IL_0047: ldarg.0
    IL_0048: ldc.i4.1
    IL_004D: stfld 0x0400101D
    IL_0052: br IL_005C
    IL_0053: ldarg.0
    IL_0054: ldc.i4.m1
    IL_0059: stfld 0x0400101D
    IL_005A: ldc.i4.0
    IL_005B: ret
    IL_005C: ldc.i4.1
    IL_005D: ret
    IL_005E: ldloc.1
    IL_005F: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400101D
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001021
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001021
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001020
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001020
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 245752659968
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: ldelem.i
    IL_0024: IL_99
    IL_0025: IL_99
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001021
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001020
    IL_003C: br IL_005C
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001022
    IL_0047: ldfld 0x040002E1
    IL_0048: conv.r8
    IL_0049: IL_B0
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldc.i4.0
    IL_004E: conv.r8
    IL_004F: IL_B6
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0054: ldc.i4.m1
    IL_0059: stfld 0x04001020
    IL_005A: ldc.i4.0
    IL_005B: ret
    IL_005C: ldc.i4.1
    IL_005D: ret
    IL_005E: ldloc.1
    IL_005F: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001020
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001025
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001025
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001024
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001024
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_27
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_005B
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001027
    IL_002C: ldfld 0x040003C0
    IL_0031: newobj 0x0A000066
    IL_0036: stfld 0x04001025
    IL_0037: ldarg.0
    IL_0038: ldc.i4.1
    IL_003D: stfld 0x04001024
    IL_0042: br IL_005D
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04001023
    IL_0049: conv.r8
    IL_004A: IL_B0
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldc.i4.0
    IL_004F: conv.r8
    IL_0050: IL_B6
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: ldarg.0
    IL_0055: ldc.i4.m1
    IL_005A: stfld 0x04001024
    IL_005B: ldc.i4.0
    IL_005C: ret
    IL_005D: ldc.i4.1
    IL_005E: ret
    IL_005F: ldloc.1
    IL_0060: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001024
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001029
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001029
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001028
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001028
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 361716776960
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001029
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001028
    IL_003C: br IL_0077
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0044: stsfld 0x0111283F
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x0400102A
    IL_0051: ldfld 0x040003CC
    IL_0052: conv.r8
    IL_0053: IL_3E
    IL_0054: nop
    IL_0055: nop
    IL_0057: br.s IL_006E
    IL_0058: ldarg.0
    IL_005D: ldfld 0x0400102A
    IL_0062: ldfld 0x040003E3
    IL_0063: conv.r8
    IL_0064: ldc.i4.2
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ldc.i4.0
    IL_0069: conv.r8
    IL_006A: ldind.ref
    IL_006B: ldarg.0
    IL_006C: nop
    IL_006D: ldloc.0
    IL_006E: ldarg.0
    IL_006F: ldc.i4.m1
    IL_0074: stfld 0x04001028
    IL_0075: ldc.i4.0
    IL_0076: ret
    IL_0077: ldc.i4.1
    IL_0078: ret
    IL_0079: ldloc.1
    IL_007A: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001028
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400102C
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400102C
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400102B
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400102B
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 340241940480
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: rem
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400102B
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001030
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001030
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400102F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400102F
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 542105403392
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001030
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x0400102F
    IL_003C: br IL_00A1
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001031
    IL_0047: ldfld 0x040003E4
    IL_0048: conv.r8
    IL_004B: ldloc 0
    IL_004C: stloc.0
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04001031
    IL_0058: ldfld 0x040003E4
    IL_005D: ldstr 0x70000F3F
    IL_005E: conv.r8
    IL_0063: newobj 0x7D0A0000
    IL_0065: beq.s IL_0076
    IL_0066: nop
    IL_0067: ldarg.2
    IL_0068: ldarg.0
    IL_006D: ldfld 0x0400102E
    IL_006E: IL_22
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: IL_3F
    IL_0073: conv.r8
    IL_0075: bgt.s IL_0076
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04001031
    IL_0082: ldfld 0x040003B1
    IL_0083: conv.r8
    IL_0084: IL_C7
    IL_0085: IL_01
    IL_0086: nop
    IL_0087: ldloc.0
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04001031
    IL_0092: ldfld 0x040003B0
    IL_0093: conv.r8
    IL_0094: conv.u4
    IL_0095: IL_01
    IL_0096: nop
    IL_0097: ldloc.0
    IL_0098: ldarg.0
    IL_0099: ldc.i4.m1
    IL_009E: stfld 0x0400102F
    IL_009F: ldc.i4.0
    IL_00A0: ret
    IL_00A1: ldc.i4.1
    IL_00A2: ret
    IL_00A3: ldloc.1
    IL_00A4: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400102F
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001033
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001033
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001032
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001032
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 383191613440
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: stsfld 0x0066733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: stfld 0x04001033
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001032
    IL_003C: br IL_007C
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001034
    IL_0047: ldfld 0x040003B1
    IL_0048: conv.r8
    IL_0049: IL_C7
    IL_004A: IL_01
    IL_004B: nop
    IL_004C: ldloc.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04001034
    IL_0057: ldfld 0x040003B0
    IL_0058: conv.r8
    IL_0059: conv.u4
    IL_005A: IL_01
    IL_005B: nop
    IL_005C: ldloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04001034
    IL_0067: call 0x0A00002A
    IL_006C: ldstr 0x700011D1
    IL_006D: conv.r8
    IL_006E: IL_3C
    IL_006F: nop
    IL_0070: nop
    IL_0071: stloc.0
    IL_0072: pop
    IL_0073: ldarg.0
    IL_0074: ldc.i4.m1
    IL_0079: stfld 0x04001032
    IL_007A: ldc.i4.0
    IL_007B: ret
    IL_007C: ldc.i4.1
    IL_007D: ret
    IL_007E: ldloc.1
    IL_007F: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001032
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104A
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104A
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001049
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001049
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_AD
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_043E
    IL_0021: ldarg.0
    IL_0026: newobj 0x0A0001A5
    IL_002B: stfld 0x04001035
    IL_002C: ldarg.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04001036
    IL_0033: conv.r8
    IL_0038: isinst 0x7D0A0001
    IL_0039: IL_37
    IL_003B: starg.s 0
    IL_003C: ldarg.2
    IL_0041: br IL_0074
    IL_0042: ldarg.0
    IL_0043: ldarg.0
    IL_0048: ldflda 0x04001037
    IL_004D: call 0x0A0001A7
    IL_0052: stfld 0x04001038
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04001035
    IL_0059: ldarg.0
    IL_005E: ldflda 0x04001038
    IL_0063: call 0x0A0001A8
    IL_0064: ldarg.0
    IL_0069: ldflda 0x04001038
    IL_006E: call 0x0A0001A9
    IL_006F: conv.r8
    IL_0070: IL_AA
    IL_0071: IL_01
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldarg.0
    IL_0079: ldflda 0x04001037
    IL_007E: call 0x0A0001AB
    IL_0083: brtrue IL_0042
    IL_0084: IL_DD
    IL_0086: ldloc.s 0
    IL_0087: nop
    IL_0088: nop
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04001037
    IL_0093: newobj 0x1B000007
    IL_0094: conv.r8
    IL_0095: ldelem.ref
    IL_0096: nop
    IL_0097: nop
    IL_0098: stloc.0
    IL_0099: IL_DC
    IL_009A: ldarg.0
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04001039
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04001035
    IL_00AB: newobj 0x0A0001AC
    IL_00B0: stfld 0x0400103A
    IL_00B1: ldarg.0
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x0400103A
    IL_00BC: stfld 0x0400104A
    IL_00BD: ldarg.0
    IL_00BE: ldc.i4.1
    IL_00C3: stfld 0x04001049
    IL_00C8: br IL_0440
    IL_00C9: ldarg.0
    IL_00CE: ldfld 0x0400103A
    IL_00CF: conv.r8
    IL_00D0: IL_AD
    IL_00D1: IL_01
    IL_00D2: nop
    IL_00D3: stloc.0
    IL_00D8: brfalse IL_0107
    IL_00DD: ldstr 0x70002783
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x0400103A
    IL_00E4: conv.r8
    IL_00E5: IL_AD
    IL_00E6: IL_01
    IL_00E7: nop
    IL_00E8: stloc.0
    IL_00ED: call 0x0A000011
    IL_00F2: call 0x0A00013D
    IL_00F7: call 0x0600004E
    IL_00FC: ldstr 0x70002799
    IL_00FD: conv.r8
    IL_00FE: xor
    IL_00FF: nop
    IL_0100: nop
    IL_0101: ldloc.0
    IL_0106: br IL_0437
    IL_0107: ldarg.0
    IL_0108: ldarg.0
    IL_010D: ldfld 0x0400103A
    IL_010E: conv.r8
    IL_010F: IL_AE
    IL_0110: IL_01
    IL_0111: nop
    IL_0112: stloc.0
    IL_0117: call 0x060004AF
    IL_011C: stfld 0x0400103B
    IL_011D: ldarg.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x0400103B
    IL_0128: ldstr 0x7000279D
    IL_0129: conv.r8
    IL_1BC18013E: switch (1862664196 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001049
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104F
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400104E
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: and
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0085
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04001050
    IL_002B: ldfld 0x040007BE
    IL_002C: ldc.i4.4
    IL_0099: switch (26 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400104E
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001055
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001055
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001054
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001054
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00A2
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001051
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x04001052
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04001052
    IL_003D: stfld 0x04001055
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x04001054
    IL_0049: br IL_00A4
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04001052
    IL_0050: conv.r8
    IL_0051: IL_AD
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0059: brtrue IL_0077
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04001058
    IL_0064: ldfld 0x04000882
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04001053
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04001052
    IL_0071: conv.r8
    IL_0072: IL_FC
    IL_0073: IL_01
    IL_0074: nop
    IL_0075: stloc.0
    IL_007A: stelem 0x10587B02
    IL_007B: nop
    IL_007C: ldarg.2
    IL_0081: ldfld 0x04000888
    IL_0082: ldc.i4.1
    IL_0083: IL_59
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04001053
    IL_00BE: switch (12 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001054
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105A
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105A
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_77
    IL_0003: ldloc.1
    IL_0004: nop
    IL_0005: ldloc.0
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x04001059
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x06000773
    IL_0019: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001059
    IL_0006: ldarg.0
    IL_0007: ldc.i4.m1
    IL_000C: stfld 0x04001059
    IL_0011: brtrue IL_0017
    IL_0016: br IL_0017
    IL_0017: ldc.i4.0
    IL_0018: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001059
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001060
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001060
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0006: ldsflda 0x2A060007
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x0400105F
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x0600077B
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04001061
    IL_0025: stfld 0x04001061
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400105F
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_0116
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001061
    IL_002A: conv.r8
    IL_002D: ldloca 4
    IL_002E: ldloc.0
    IL_002F: conv.r8
    IL_0038: ldc.i8 288248361277587458
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0045: bge.s IL_0046
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_00E1
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x0400105B
    IL_0054: conv.r8
    IL_0055: IL_22
    IL_0056: ldarg.0
    IL_0057: nop
    IL_0058: stloc.0
    IL_005D: stfld 0x0400105C
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400105C
    IL_0065: conv.r8
    IL_0068: stloc 4
    IL_0069: ldloc.0
    IL_006A: conv.r8
    IL_0073: ldc.i8 288248369867522050
    IL_0075: ldc.i4.s -3
    IL_0076: stloc.0
    IL_0077: ldloc.0
    IL_0078: ldc.i4.1
    IL_0079: IL_59
    IL_007C: ldarg 1
    IL_007D: nop
    IL_007E: nop
    IL_0080: bgt.s IL_0081
    IL_0081: nop
    IL_0082: nop
    IL_0087: br IL_00B3
    IL_0088: ldarg.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x0400105D
    IL_008F: conv.r8
    IL_0090: IL_22
    IL_0091: ldarg.0
    IL_0092: nop
    IL_0093: stloc.0
    IL_0098: stfld 0x0400105E
    IL_0099: ldarg.0
    IL_009A: ldarg.0
    IL_009F: ldfld 0x0400105E
    IL_00A4: stfld 0x04001060
    IL_00A5: ldarg.0
    IL_00A6: ldc.i4.1
    IL_00AB: stfld 0x0400105F
    IL_00AC: ldc.i4.1
    IL_00AD: stloc.1
    IL_00AE: IL_DD
    IL_00AF: shl
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x0400105D
    IL_00B9: conv.r8
    IL_00BA: IL_99
    IL_00BB: IL_01
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00C2: brtrue IL_0088
    IL_00C3: IL_DD
    IL_00C4: ldc.i4.3
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: ldloc.1
    IL_00CA: brfalse.s IL_00CC
    IL_00CB: IL_DC
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x0400105D
    IL_00D3: brtrue.s IL_00D5
    IL_00D4: IL_DC
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x0400105D
    IL_00DB: conv.r8
    IL_00DC: ldelem.ref
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: stloc.0
    IL_00E0: IL_DC
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x0400105B
    IL_00E7: conv.r8
    IL_00E8: IL_99
    IL_00E9: IL_01
    IL_00EA: nop
    IL_00EB: stloc.0
    IL_00F0: brtrue IL_004D
    IL_00F1: IL_DD
    IL_00F2: ldc.i4.3
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: nop
    IL_00F6: ldloc.1
    IL_00F8: brfalse.s IL_00FA
    IL_00F9: IL_DC
    IL_00FA: ldarg.0
    IL_00FF: ldfld 0x0400105B
    IL_0101: brtrue.s IL_0103
    IL_0102: IL_DC
    IL_0103: ldarg.0
    IL_0108: ldfld 0x0400105B
    IL_0109: conv.r8
    IL_010A: ldelem.ref
    IL_010B: nop
    IL_010C: nop
    IL_010D: stloc.0
    IL_010E: IL_DC
    IL_010F: ldarg.0
    IL_0110: ldc.i4.m1
    IL_0115: stfld 0x0400105F
    IL_0116: ldc.i4.0
    IL_0117: ret
    IL_0118: ldc.i4.1
    IL_0119: ret
    IL_011A: ldloc.2
    IL_011B: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400105F
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0018: brfalse IL_5000019
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0055
    IL_0021: IL_DD
    IL_0022: ldc.i4.m1
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400105D
    IL_002D: brtrue.s IL_002F
    IL_002E: IL_DC
    IL_002F: ldarg.0
    IL_0034: ldfld 0x0400105D
    IL_0035: conv.r8
    IL_0036: ldelem.ref
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: IL_DC
    IL_003B: IL_DD
    IL_003C: ldc.i4.m1
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400105B
    IL_0047: brtrue.s IL_0049
    IL_0048: IL_DC
    IL_0049: ldarg.0
    IL_004E: ldfld 0x0400105B
    IL_004F: conv.r8
    IL_0050: ldelem.ref
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: IL_DC
    IL_0055: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001065
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001065
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_87
    IL_0003: ldloc.1
    IL_0004: nop
    IL_0005: ldloc.0
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x04001064
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x06000783
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04001066
    IL_0025: stfld 0x04001066
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001064
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001064
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_00A9
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001066
    IL_002E: ldfld 0x040008D8
    IL_002F: conv.r8
    IL_0030: ret
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x04001062
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0045: bgt.s IL_0046
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_0078
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x04001062
    IL_0058: call 0x0A00022B
    IL_005D: stfld 0x04001063
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04001063
    IL_0069: stfld 0x04001065
    IL_006A: ldarg.0
    IL_006B: ldc.i4.1
    IL_0070: stfld 0x04001064
    IL_0071: ldc.i4.1
    IL_0072: stloc.1
    IL_0073: IL_DD
    IL_0075: bne.un.s IL_0076
    IL_0076: nop
    IL_0077: nop
    IL_0078: ldarg.0
    IL_007D: ldflda 0x04001062
    IL_0082: call 0x0A00022C
    IL_0087: brtrue IL_004D
    IL_0088: IL_DD
    IL_0089: ldc.i4.m1
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: ldloc.1
    IL_008F: brfalse.s IL_0091
    IL_0090: IL_DC
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04001062
    IL_009B: newobj 0x1B00000D
    IL_009C: conv.r8
    IL_009D: ldelem.ref
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: IL_DC
    IL_00A2: ldarg.0
    IL_00A3: ldc.i4.m1
    IL_00A8: stfld 0x04001064
    IL_00A9: ldc.i4.0
    IL_00AA: ret
    IL_00AB: ldc.i4.1
    IL_00AC: ret
    IL_00AD: ldloc.2
    IL_00AE: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001064
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001064
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.5
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0037
    IL_0021: IL_DD
    IL_0023: ldloc.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04001062
    IL_0030: newobj 0x1B00000D
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106A
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106A
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001069
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001069
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_00A9
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x0400106B
    IL_002E: ldfld 0x040008D8
    IL_002F: conv.r8
    IL_0030: ret
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x04001067
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0045: bgt.s IL_0046
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_0078
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x04001067
    IL_0058: call 0x0A00022B
    IL_005D: stfld 0x04001068
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04001068
    IL_0069: stfld 0x0400106A
    IL_006A: ldarg.0
    IL_006B: ldc.i4.1
    IL_0070: stfld 0x04001069
    IL_0071: ldc.i4.1
    IL_0072: stloc.1
    IL_0073: IL_DD
    IL_0075: bne.un.s IL_0076
    IL_0076: nop
    IL_0077: nop
    IL_0078: ldarg.0
    IL_007D: ldflda 0x04001067
    IL_0082: call 0x0A00022C
    IL_0087: brtrue IL_004D
    IL_0088: IL_DD
    IL_0089: ldc.i4.m1
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: ldloc.1
    IL_008F: brfalse.s IL_0091
    IL_0090: IL_DC
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04001067
    IL_009B: newobj 0x1B00000D
    IL_009C: conv.r8
    IL_009D: ldelem.ref
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: IL_DC
    IL_00A2: ldarg.0
    IL_00A3: ldc.i4.m1
    IL_00A8: stfld 0x04001069
    IL_00A9: ldc.i4.0
    IL_00AA: ret
    IL_00AB: ldc.i4.1
    IL_00AC: ret
    IL_00AD: ldloc.2
    IL_00AE: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001069
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001069
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.5
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0037
    IL_0021: IL_DD
    IL_0023: ldloc.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04001067
    IL_0030: newobj 0x1B00000D
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_95
    IL_0003: ldloc.1
    IL_0004: nop
    IL_0005: ldloc.0
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x0400106E
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x06000791
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04001070
    IL_0025: stfld 0x04001070
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400106E
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_00AE
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001070
    IL_002E: ldfld 0x040008D9
    IL_002F: conv.r8
    IL_0030: IL_3E
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x0400106C
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_35
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_007D
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x0400106C
    IL_0058: call 0x0A00023F
    IL_005D: stfld 0x0400106D
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldflda 0x0400106D
    IL_0069: call 0x0A000236
    IL_006E: stfld 0x0400106F
    IL_006F: ldarg.0
    IL_0070: ldc.i4.1
    IL_0075: stfld 0x0400106E
    IL_0076: ldc.i4.1
    IL_0077: stloc.1
    IL_0078: IL_DD
    IL_007A: bne.un.s IL_007B
    IL_007B: nop
    IL_007C: nop
    IL_007D: ldarg.0
    IL_0082: ldflda 0x0400106C
    IL_0087: call 0x0A000241
    IL_008C: brtrue IL_004D
    IL_008D: IL_DD
    IL_008E: ldc.i4.m1
    IL_008F: nop
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldloc.1
    IL_0094: brfalse.s IL_0096
    IL_0095: IL_DC
    IL_0096: ldarg.0
    IL_009B: ldfld 0x0400106C
    IL_00A0: newobj 0x1B000011
    IL_00A1: conv.r8
    IL_00A2: ldelem.ref
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00A6: IL_DC
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4.m1
    IL_00AD: stfld 0x0400106E
    IL_00AE: ldc.i4.0
    IL_00AF: ret
    IL_00B0: ldc.i4.1
    IL_00B1: ret
    IL_00B2: ldloc.2
    IL_00B3: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400106E
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.5
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0037
    IL_0021: IL_DD
    IL_0023: ldloc.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400106C
    IL_0030: newobj 0x1B000011
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001074
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001074
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001073
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001073
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_00AE
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001075
    IL_002E: ldfld 0x040008D9
    IL_002F: conv.r8
    IL_0030: IL_3E
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x04001071
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_35
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_007D
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x04001071
    IL_0058: call 0x0A00023F
    IL_005D: stfld 0x04001072
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04001072
    IL_0069: newobj 0x1B00000F
    IL_006E: stfld 0x04001074
    IL_006F: ldarg.0
    IL_0070: ldc.i4.1
    IL_0075: stfld 0x04001073
    IL_0076: ldc.i4.1
    IL_0077: stloc.1
    IL_0078: IL_DD
    IL_007A: bne.un.s IL_007B
    IL_007B: nop
    IL_007C: nop
    IL_007D: ldarg.0
    IL_0082: ldflda 0x04001071
    IL_0087: call 0x0A000241
    IL_008C: brtrue IL_004D
    IL_008D: IL_DD
    IL_008E: ldc.i4.m1
    IL_008F: nop
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldloc.1
    IL_0094: brfalse.s IL_0096
    IL_0095: IL_DC
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04001071
    IL_00A0: newobj 0x1B000011
    IL_00A1: conv.r8
    IL_00A2: ldelem.ref
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00A6: IL_DC
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4.m1
    IL_00AD: stfld 0x04001073
    IL_00AE: ldc.i4.0
    IL_00AF: ret
    IL_00B0: ldc.i4.1
    IL_00B1: ret
    IL_00B2: ldloc.2
    IL_00B3: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001073
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001073
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.5
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0037
    IL_0021: IL_DD
    IL_0023: ldloc.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04001071
    IL_0030: newobj 0x1B000011
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001079
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001079
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001078
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001078
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_007D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001076
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x04001077
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04001077
    IL_003D: stfld 0x04001079
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x04001078
    IL_0049: br IL_007F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04001077
    IL_0050: conv.r8
    IL_0051: IL_FC
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_0056: conv.u4
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldc.i4.8
    IL_005B: IL_3E
    IL_005C: ldc.i4.0
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400107B
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04001077
    IL_006C: conv.r8
    IL_006D: IL_FC
    IL_006E: IL_01
    IL_006F: nop
    IL_0070: stloc.0
    IL_0075: stfld 0x04000ABA
    IL_0076: ldarg.0
    IL_0077: ldc.i4.m1
    IL_007C: stfld 0x04001078
    IL_007D: ldc.i4.0
    IL_007E: ret
    IL_007F: ldc.i4.1
    IL_0080: ret
    IL_0081: ldloc.1
    IL_0082: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001078
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400107F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400107F
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400107E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400107E
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_007D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400107C
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x0400107D
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400107D
    IL_003D: stfld 0x0400107F
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x0400107E
    IL_0049: br IL_007F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x0400107D
    IL_0050: conv.r8
    IL_0051: IL_FC
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_0056: conv.u4
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldc.i4.8
    IL_005B: IL_3E
    IL_005C: ldc.i4.0
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x04001081
    IL_0066: ldarg.0
    IL_006B: ldfld 0x0400107D
    IL_006C: conv.r8
    IL_006D: IL_FC
    IL_006E: IL_01
    IL_006F: nop
    IL_0070: stloc.0
    IL_0075: stfld 0x04000B2D
    IL_0076: ldarg.0
    IL_0077: ldc.i4.m1
    IL_007C: stfld 0x0400107E
    IL_007D: ldc.i4.0
    IL_007E: ret
    IL_007F: ldc.i4.1
    IL_0080: ret
    IL_0081: ldloc.1
    IL_0082: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400107E
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001087
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001087
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001086
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001086
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_001C: brfalse IL_3800001D
    IL_001D: ldelem.i4
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ldarg.0
    IL_0026: ldstr 0x70023451
    IL_002B: stfld 0x04001082
    IL_002C: ldarg.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04001082
    IL_0037: newobj 0x0A0001FB
    IL_003C: stfld 0x04001083
    IL_003D: ldarg.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04001083
    IL_0048: stfld 0x04001087
    IL_0049: ldarg.0
    IL_004A: ldc.i4.1
    IL_004F: stfld 0x04001086
    IL_0054: br IL_00C0
    IL_0055: ldarg.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04001083
    IL_005C: conv.r8
    IL_005D: IL_AE
    IL_005E: IL_01
    IL_005F: nop
    IL_0060: stloc.0
    IL_0065: stfld 0x04001084
    IL_0066: ldarg.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04001084
    IL_0071: call 0x0A0002FC
    IL_0076: stfld 0x04001085
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04001088
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04001088
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04001085
    IL_008D: ldstr 0x700234BB
    IL_008E: conv.r8
    IL_008F: IL_FD
    IL_0090: ldarg.0
    IL_0091: nop
    IL_0092: stloc.0
    IL_0097: ldstr 0x700234CB
    IL_0098: conv.r8
    IL_0099: IL_FD
    IL_009A: ldarg.0
    IL_009B: nop
    IL_009C: stloc.0
    IL_00A1: ldstr 0x700234D5
    IL_00A2: conv.r8
    IL_00A3: IL_FD
    IL_00A4: ldarg.0
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00AB: call 0x0A0002FE
    IL_00B0: call 0x060005FA
    IL_00B5: call 0x0A000047
    IL_00B6: pop
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4.m1
    IL_00BD: stfld 0x04001086
    IL_00BE: ldc.i4.0
    IL_00BF: ret
    IL_00C0: ldc.i4.1
    IL_00C1: ret
    IL_00C2: ldloc.1
    IL_00C3: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001086
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400108C
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400108C
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400108B
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400108B
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0051
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001089
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x0400108A
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400108A
    IL_003D: stfld 0x0400108C
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x0400108B
    IL_0049: br IL_0053
    IL_004A: ldarg.0
    IL_004B: ldc.i4.m1
    IL_0050: stfld 0x0400108B
    IL_0051: ldc.i4.0
    IL_0052: ret
    IL_0053: ldc.i4.1
    IL_0054: ret
    IL_0055: ldloc.1
    IL_0056: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400108B
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001095
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001095
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001094
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001094
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_4E
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_01F9
    IL_0021: ldarg.0
    IL_0026: ldstr 0x700234DD
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04001096
    IL_0031: ldfld 0x04000B48
    IL_0036: ldstr 0x70023545
    IL_003B: call 0x0A0000ED
    IL_0040: stfld 0x0400108E
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x0400108E
    IL_004C: newobj 0x0A0001FB
    IL_0051: stfld 0x0400108F
    IL_0052: ldarg.0
    IL_0053: ldarg.0
    IL_0058: ldfld 0x0400108F
    IL_005D: stfld 0x04001095
    IL_005E: ldarg.0
    IL_005F: ldc.i4.1
    IL_0064: stfld 0x04001094
    IL_0069: br IL_01FB
    IL_006A: ldarg.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x0400108F
    IL_0071: conv.r8
    IL_0072: IL_AE
    IL_0073: IL_01
    IL_0074: nop
    IL_0075: stloc.0
    IL_007A: stfld 0x04001090
    IL_007B: ldarg.0
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04001090
    IL_0086: call 0x0A0002FC
    IL_008B: stfld 0x04001091
    IL_008C: ldarg.0
    IL_0091: ldfld 0x04001096
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04001091
    IL_009C: ldstr 0x700234CB
    IL_009D: conv.r8
    IL_009E: IL_FD
    IL_009F: ldarg.0
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: conv.r8
    IL_00A3: IL_FF
    IL_00A4: ldarg.0
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00AB: stfld 0x04000B23
    IL_00AC: ldarg.0
    IL_00B1: newobj 0x0A0002F9
    IL_00B6: stfld 0x04001092
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4.0
    IL_00BD: stfld 0x04001093
    IL_00C2: br IL_01DC
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04001096
    IL_00CD: ldfld 0x04000B20
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x04001093
    IL_00D4: IL_8F
    IL_00D6: ldarg.s 1
    IL_00D7: nop
    IL_00D8: ldarg.0
    IL_00D9: ldarg.0
    IL_00DE: ldfld 0x04001091
    IL_00E3: ldstr 0x700234CB
    IL_00E4: conv.r8
    IL_00E5: IL_FD
    IL_00E6: ldarg.0
    IL_00E7: nop
    IL_00E8: stloc.0
    IL_00E9: ldarg.0
    IL_00EE: ldfld 0x04001093
    IL_00EF: conv.r8
    IL_00F0: nop
    IL_00F1: ldarg.1
    IL_00F2: nop
    IL_00F3: stloc.0
    IL_00F8: ldstr 0x70023575
    IL_00F9: conv.r8
    IL_00FA: IL_FD
    IL_00FB: ldarg.0
    IL_00FC: nop
    IL_00FD: stloc.0
    IL_0102: call 0x0A0002FE
    IL_0107: stfld 0x04000B4A
    IL_0108: ldarg.0
    IL_010D: ldfld 0x04001096
    IL_0112: ldfld 0x04000B20
    IL_0113: ldarg.0
    IL_0118: ldfld 0x04001093
    IL_0119: IL_8F
    IL_011B: ldarg.s 1
    IL_011C: nop
    IL_011D: ldarg.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x04001091
    IL_0128: ldstr 0x700234CB
    IL_0129: conv.r8
    IL_012A: IL_FD
    IL_012B: ldarg.0
    IL_012C: nop
    IL_012D: stloc.0
    IL_012E: ldarg.0
    IL_0133: ldfld 0x04001093
    IL_0134: conv.r8
    IL_0135: nop
    IL_0136: ldarg.1
    IL_0137: nop
    IL_0138: stloc.0
    IL_013D: ldstr 0x7002357B
    IL_013E: conv.r8
    IL_013F: IL_FD
    IL_0140: ldarg.0
    IL_0141: nop
    IL_0142: stloc.0
    IL_0147: call 0x0A0002FE
    IL_014C: stfld 0x04000B4C
    IL_014D: ldarg.0
    IL_0152: ldfld 0x04001096
    IL_0153: ldarg.0
    IL_0158: ldfld 0x04001096
    IL_0159: ldarg.0
    IL_015E: ldfld 0x04001091
    IL_0163: ldstr 0x700234CB
    IL_0164: conv.r8
    IL_0165: IL_FD
    IL_0166: ldarg.0
    IL_0167: nop
    IL_0168: stloc.0
    IL_0169: ldarg.0
    IL_016E: ldfld 0x04001093
    IL_016F: conv.r8
    IL_0170: nop
    IL_0171: ldarg.1
    IL_0172: nop
    IL_0173: stloc.0
    IL_0178: ldstr 0x700234BB
    IL_0179: conv.r8
    IL_017A: IL_FD
    IL_017B: ldarg.0
    IL_017C: nop
    IL_017D: stloc.0
    IL_0182: ldstr 0x700234CB
    IL_0183: conv.r8
    IL_0184: IL_FD
    IL_0185: ldarg.0
    IL_0186: nop
    IL_0187: stloc.0
    IL_018C: ldstr 0x700234D5
    IL_018D: conv.r8
    IL_018E: IL_FD
    IL_018F: ldarg.0
    IL_0190: nop
    IL_0191: stloc.0
    IL_0196: call 0x0A0002FE
    IL_0197: ldarg.0
    IL_019C: ldfld 0x04001093
    IL_01A1: call 0x060005FC
    IL_01A6: call 0x0A000047
    IL_01A7: pop
    IL_01A8: ldarg.0
    IL_01AD: ldfld 0x04001092
    IL_01AE: ldarg.0
    IL_01B3: ldfld 0x04001096
    IL_01B8: ldfld 0x04000B20
    IL_01B9: ldarg.0
    IL_01BE: ldfld 0x04001093
    IL_01BF: IL_8F
    IL_01C1: ldarg.s 1
    IL_01C2: nop
    IL_01C3: ldarg.0
    IL_01C8: ldfld 0x04000B4A
    IL_01C9: conv.r8
    IL_01CA: IL_FA
    IL_01CB: ldarg.0
    IL_01CC: nop
    IL_01CD: stloc.0
    IL_01CE: ldarg.0
    IL_01CF: ldarg.0
    IL_01D4: ldfld 0x04001093
    IL_01D5: ldc.i4.1
    IL_01D6: IL_58
    IL_01DB: stfld 0x04001093
    IL_01DC: ldarg.0
    IL_01E1: ldfld 0x04001093
    IL_01E2: ldarg.0
    IL_01E7: ldfld 0x04001096
    IL_01EC: ldfld 0x04000B23
    IL_01ED: IL_3F
    IL_01EE: IL_D1
    IL_01F0: 0xFE FF
    IL_01F1: IL_FF
    IL_01F2: ldarg.0
    IL_01F3: ldc.i4.m1
    IL_01F8: stfld 0x04001094
    IL_01F9: ldc.i4.0
    IL_01FA: ret
    IL_01FB: ldc.i4.1
    IL_01FC: ret
    IL_01FD: ldloc.1
    IL_01FE: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001094
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400109B
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400109B
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400109A
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400109A
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_008D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001097
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x04001098
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04001098
    IL_003D: stfld 0x0400109B
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x0400109A
    IL_0049: br IL_008F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04001098
    IL_0050: conv.r8
    IL_0051: IL_FC
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_0056: conv.u4
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldc.i4.8
    IL_005B: IL_3E
    IL_005C: pop
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400109E
    IL_006A: ldfld 0x04000B20
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04001099
    IL_0071: IL_8F
    IL_0073: ldarg.s 1
    IL_0074: nop
    IL_0075: ldarg.0
    IL_0076: ldarg.0
    IL_007B: ldfld 0x04001098
    IL_007C: conv.r8
    IL_007D: IL_FC
    IL_007E: IL_01
    IL_007F: nop
    IL_0080: stloc.0
    IL_0085: stfld 0x04000B4D
    IL_0086: ldarg.0
    IL_0087: ldc.i4.m1
    IL_008C: stfld 0x0400109A
    IL_008D: ldc.i4.0
    IL_008E: ret
    IL_008F: ldc.i4.1
    IL_0090: ret
    IL_0091: ldloc.1
    IL_0092: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400109A
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A3
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A3
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A2
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010A2
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00D5
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400109F
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x040010A0
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040010A0
    IL_003D: stfld 0x040010A3
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x040010A2
    IL_0049: br IL_00D7
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040010A0
    IL_0050: conv.r8
    IL_0051: IL_FC
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_0056: conv.u4
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldc.i4.8
    IL_005B: IL_3E
    IL_005C: conv.r4
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x040010A6
    IL_006A: ldfld 0x04000B44
    IL_006B: stloc.1
    IL_006C: ldloc.1
    IL_006D: ldc.i4.0
    IL_0072: beq IL_0078
    IL_0077: br IL_00A3
    IL_0078: ldarg.0
    IL_007D: ldfld 0x040010A6
    IL_0082: ldfld 0x04000B21
    IL_0083: ldarg.0
    IL_0088: ldfld 0x040010A1
    IL_0089: IL_8F
    IL_008B: ldarga.s 1
    IL_008C: nop
    IL_008D: ldarg.0
    IL_008E: ldarg.0
    IL_0093: ldfld 0x040010A0
    IL_0094: conv.r8
    IL_0095: IL_FC
    IL_0096: IL_01
    IL_0097: nop
    IL_0098: stloc.0
    IL_009D: stfld 0x04000B51
    IL_00A2: br IL_00CE
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x040010A6
    IL_00AD: ldfld 0x04000B22
    IL_00AE: ldarg.0
    IL_00B3: ldfld 0x040010A1
    IL_00B4: IL_8F
    IL_00B6: starg.s 1
    IL_00B7: nop
    IL_00B8: ldarg.0
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x040010A0
    IL_00BF: conv.r8
    IL_00C0: IL_FC
    IL_00C1: IL_01
    IL_00C2: nop
    IL_00C3: stloc.0
    IL_00C8: stfld 0x04000B54
    IL_00CD: br IL_00CE
    IL_00CE: ldarg.0
    IL_00CF: ldc.i4.m1
    IL_00D4: stfld 0x040010A2
    IL_00D5: ldc.i4.0
    IL_00D6: ret
    IL_00D7: ldc.i4.1
    IL_00D8: ret
    IL_00D9: ldloc.2
    IL_00DA: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010A2
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A8
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A8
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A7
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010A7
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 1096156184576
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010A7
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010AD
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010AD
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010AC
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010AC
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_007D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040010AA
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x040010AB
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040010AB
    IL_003D: stfld 0x040010AD
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x040010AC
    IL_0049: br IL_007F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040010AF
    IL_0054: ldfld 0x04000E0E
    IL_0055: conv.r8
    IL_0056: ldc.i4.8
    IL_0057: ldarg.1
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x040010AB
    IL_0060: conv.r8
    IL_0061: IL_FC
    IL_0062: IL_01
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: conv.r8
    IL_0067: ldc.i4.s 3
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: ldarg.0
    IL_006F: ldfld 0x040010AF
    IL_0070: ldc.i4.1
    IL_0075: stfld 0x04000E14
    IL_0076: ldarg.0
    IL_0077: ldc.i4.m1
    IL_007C: stfld 0x040010AC
    IL_007D: ldc.i4.0
    IL_007E: ret
    IL_007F: ldc.i4.1
    IL_0080: ret
    IL_0081: ldloc.1
    IL_0082: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010AC
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010B2
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010B2
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010B1
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010B1
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_44
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00A3
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040010B4
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040010B4
    IL_0031: ldfld 0x04000FA7
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040010B0
    IL_0038: ldelem.i
    IL_003D: newobj 0x0A0001FB
    IL_0042: stfld 0x04000FAB
    IL_0043: ldarg.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040010B4
    IL_004E: ldfld 0x04000FAB
    IL_0053: stfld 0x040010B2
    IL_0054: ldarg.0
    IL_0055: ldc.i4.1
    IL_005A: stfld 0x040010B1
    IL_005F: br IL_00A5
    IL_0060: ldarg.0
    IL_0065: ldfld 0x040010B4
    IL_006A: ldfld 0x04000FAB
    IL_006B: conv.r8
    IL_006C: IL_AD
    IL_006D: IL_01
    IL_006E: nop
    IL_006F: stloc.0
    IL_0074: brtrue IL_0090
    IL_0075: ldarg.0
    IL_007A: ldfld 0x040010B4
    IL_007B: ldarg.0
    IL_0080: ldfld 0x040010B4
    IL_0085: ldfld 0x04000FAB
    IL_0086: conv.r8
    IL_0087: IL_FC
    IL_0088: IL_01
    IL_0089: nop
    IL_008A: stloc.0
    IL_008F: stfld 0x04000FA8
    IL_0090: ldarg.0
    IL_0095: ldfld 0x040010B4
    IL_0096: ldc.i4.1
    IL_009B: stfld 0x04000FA9
    IL_009C: ldarg.0
    IL_009D: ldc.i4.m1
    IL_00A2: stfld 0x040010B1
    IL_00A3: ldc.i4.0
    IL_00A4: ret
    IL_00A5: ldc.i4.1
    IL_00A6: ret
    IL_00A7: ldloc.1
    IL_00A8: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010B1
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    public UI_Friends() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private void <>m__0() {
    IL_0001: ldarga.s 1
    IL_0006: call 0x0A000236
    IL_0007: ldarg.0
    IL_000C: ldfld 0x040010D3
    IL_0011: call 0x0600046B
    IL_0012: ret
    }

    }}
