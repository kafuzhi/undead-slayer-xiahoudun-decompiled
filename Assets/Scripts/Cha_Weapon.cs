// Namespace: 
// Type: Cha_Weapon

    public class Cha_Weapon {{

    private object blade;
    private object mytransform;
    public object bowgun;
    public object spear;
    public object dummy_spine;
    public object sub_hand;
    private object current_blade;
    private object current_blade2;
    private object general_blade;
    private object general_blade2;
    private object current_weapon;
    private object showdelay;
    private object changestart;
    private object c_bowgun;
    private object c_spear;
    private object finishtime;
    private object changespd;
    public object dock;

    public Cha_Weapon() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000412
    IL_0007: ldarg.0
    IL_000C: call 0x0A000001
    IL_000D: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000403
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000413
    IL_0006: ldc.i4.2
    IL_0007: IL_3C
    IL_0008: ldloc.0
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: call 0x060001E5
    IL_0012: ret
    }

    public void SetStoryBlade() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001BA1
    IL_000A: call 0x0A000012
    IL_000B: conv.u8
    IL_000C: ldloc.0
    IL_000D: nop
    IL_000E: nop
    IL_000F: IL_01
    IL_0014: stfld 0x04000402
    IL_0015: ldarg.0
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000402
    IL_001C: conv.r8
    IL_001D: ldarg.3
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000406
    IL_0027: conv.r8
    IL_0028: ldc.i4.2
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000406
    IL_0032: conv.r8
    IL_0033: pop
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A000014
    IL_003C: conv.u4
    IL_003D: ldarg.1
    IL_003E: nop
    IL_003F: nop
    IL_0040: IL_01
    IL_0045: stfld 0x04000408
    IL_0046: ret
    }

    public void SetStageWeapon() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000408
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_0021
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000408
    IL_0017: conv.r8
    IL_0018: stloc.0
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000050
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000409
    IL_0027: ldnull
    IL_002C: call 0x0A000021
    IL_0031: brfalse IL_0042
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000409
    IL_0038: conv.r8
    IL_0039: stloc.0
    IL_003A: nop
    IL_003B: nop
    IL_003C: stloc.0
    IL_0041: call 0x0A000050
    IL_0046: ldstr 0x700014B5
    IL_004B: call 0x06000220
    IL_004C: stloc.0
    IL_004D: ldloc.0
    IL_004E: conv.i2
    IL_004F: IL_22
    IL_0050: stloc.0
    IL_0051: IL_D7
    IL_0052: IL_23
    IL_0053: IL_3C
    IL_0054: IL_5A
    IL_0055: not
    IL_0056: stloc.1
    IL_0057: ldloc.0
    IL_0059: ldc.i4.s 100
    IL_005A: mul
    IL_005B: stloc.0
    IL_005C: ldarg.0
    IL_0061: ldstr 0x70001BAB
    IL_0063: ldloca.s 0
    IL_0068: call 0x0A000010
    IL_006D: call 0x0A000011
    IL_0072: call 0x0A000012
    IL_0073: conv.u8
    IL_0074: ldloc.0
    IL_0075: nop
    IL_0076: nop
    IL_0077: IL_01
    IL_007C: stfld 0x04000402
    IL_007D: ldarg.0
    IL_007E: ldarg.0
    IL_0083: ldfld 0x04000402
    IL_0084: conv.r8
    IL_0085: ldarg.3
    IL_0086: nop
    IL_0087: nop
    IL_0088: stloc.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000406
    IL_008F: conv.r8
    IL_0090: ldc.i4.2
    IL_0091: nop
    IL_0092: nop
    IL_0093: stloc.0
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000406
    IL_009A: conv.r8
    IL_009B: pop
    IL_009C: nop
    IL_009D: nop
    IL_009E: stloc.0
    IL_00A3: call 0x0A000014
    IL_00A4: conv.u4
    IL_00A5: ldarg.1
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: IL_01
    IL_00AD: stfld 0x04000408
    IL_00AE: ldarg.0
    IL_00B3: ldfld 0x04000408
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x04000406
    IL_00BA: conv.r8
    IL_00BB: IL_4E
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: stloc.0
    IL_00BF: ldloc.1
    IL_00C0: ldc.i4.1
    IL_042D: switch (218 cases)
    }

    public void GeneralWeaponOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000408
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
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000409
    IL_0017: ldnull
    IL_001C: call 0x0A000021
    IL_0021: brfalse IL_0033
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000409
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
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400040A
    IL_0039: ldnull
    IL_003E: call 0x0A000061
    IL_0043: brfalse IL_00F5
    IL_0044: ldarg.0
    IL_0049: ldstr 0x70001BB3
    IL_004B: ldarga.s 2
    IL_0050: call 0x0A000010
    IL_0055: call 0x0A000011
    IL_005A: call 0x0A000012
    IL_005B: conv.u8
    IL_005C: ldloc.0
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_01
    IL_0064: stfld 0x04000402
    IL_0065: ldarg.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000402
    IL_006C: conv.r8
    IL_006D: ldarg.3
    IL_006E: nop
    IL_006F: nop
    IL_0070: stloc.0
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000403
    IL_0077: conv.r8
    IL_0078: ldc.i4.2
    IL_0079: nop
    IL_007A: nop
    IL_007B: stloc.0
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000403
    IL_0082: conv.r8
    IL_0083: pop
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_008B: call 0x0A000014
    IL_008C: conv.u4
    IL_008D: ldarg.1
    IL_008E: nop
    IL_008F: nop
    IL_0090: IL_01
    IL_0095: stfld 0x0400040A
    IL_0096: ldarg.0
    IL_009B: ldfld 0x0400040A
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x04000403
    IL_00A2: conv.r8
    IL_00A3: IL_4E
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00A7: ldarg.1
    IL_00A8: ldc.i4.1
    IL_01B5: switch (66 cases)
    }

    public void GeneralWeaponOff() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400040A
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_0022
    IL_0011: ldarg.0
    IL_0016: ldfld 0x0400040A
    IL_0017: conv.r8
    IL_0018: stloc.0
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: conv.r8
    IL_001E: stloc.1
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400040B
    IL_0028: ldnull
    IL_002D: call 0x0A000021
    IL_0032: brfalse IL_0044
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400040B
    IL_0039: conv.r8
    IL_003A: stloc.0
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldc.i4.0
    IL_003F: conv.r8
    IL_0040: stloc.1
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000408
    IL_004A: conv.r8
    IL_004B: stloc.0
    IL_004C: nop
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: ldc.i4.1
    IL_0050: conv.r8
    IL_0051: stloc.1
    IL_0052: nop
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000409
    IL_005B: ldnull
    IL_0060: call 0x0A000021
    IL_0065: brfalse IL_0077
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000409
    IL_006C: conv.r8
    IL_006D: stloc.0
    IL_006E: nop
    IL_006F: nop
    IL_0070: stloc.0
    IL_0071: ldc.i4.1
    IL_0072: conv.r8
    IL_0073: stloc.1
    IL_0074: nop
    IL_0075: nop
    IL_0076: stloc.0
    IL_0077: ret
    }

    public void SetWeapon() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000408
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_0021
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000408
    IL_0017: conv.r8
    IL_0018: stloc.0
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000050
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000409
    IL_0027: ldnull
    IL_002C: call 0x0A000021
    IL_0031: brfalse IL_0042
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000409
    IL_0038: conv.r8
    IL_0039: stloc.0
    IL_003A: nop
    IL_003B: nop
    IL_003C: stloc.0
    IL_0041: call 0x0A000050
    IL_0042: ldarg.0
    IL_0047: ldstr 0x70001BAB
    IL_0049: ldarga.s 1
    IL_004E: call 0x0A000010
    IL_0053: call 0x0A000011
    IL_0058: call 0x0A000012
    IL_0059: conv.u8
    IL_005A: ldloc.0
    IL_005B: nop
    IL_005C: nop
    IL_005D: IL_01
    IL_0062: stfld 0x04000402
    IL_0063: ldarg.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000402
    IL_006A: conv.r8
    IL_006B: ldarg.3
    IL_006C: nop
    IL_006D: nop
    IL_006E: stloc.0
    IL_006F: ldarg.0
    IL_0074: ldfld 0x04000406
    IL_0075: conv.r8
    IL_0076: ldc.i4.2
    IL_0077: nop
    IL_0078: nop
    IL_0079: stloc.0
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000406
    IL_0080: conv.r8
    IL_0081: pop
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0089: call 0x0A000014
    IL_008A: conv.u4
    IL_008B: ldarg.1
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_01
    IL_0093: stfld 0x04000408
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000408
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000408
    IL_00A0: conv.r8
    IL_00A5: cpobj 0x220A0000
    IL_00A6: nop
    IL_00A7: nop
    IL_00AC: ldobj 0x00082840
    IL_00AD: nop
    IL_00AE: stloc.0
    IL_00AF: conv.r8
    IL_00B0: IL_AF
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: stloc.0
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x04000408
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000406
    IL_00C0: conv.r8
    IL_00C1: IL_4E
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: stloc.0
    IL_00C5: ldarg.2
    IL_00C6: ldc.i4.1
    IL_04B3: switch (250 cases)
    }

    public void SwitchWepon() {
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0006: stfld 0x04000412
    IL_0007: ldarg.0
    IL_0008: ldarg.3
    IL_000D: stfld 0x04000411
    IL_000E: ldarg.0
    IL_0010: ldarg.s 4
    IL_0015: stfld 0x0400040D
    IL_0016: ldarg.1
    IL_001B: brtrue IL_00BC
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000410
    IL_0022: ldnull
    IL_0027: call 0x0A000061
    IL_002C: brfalse IL_005E
    IL_002D: ldarg.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000405
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000403
    IL_003A: conv.r8
    IL_003B: ldc.i4.2
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000403
    IL_0045: conv.r8
    IL_0046: pop
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004E: call 0x0A000014
    IL_004F: conv.u4
    IL_0050: ldarg.1
    IL_0051: nop
    IL_0052: nop
    IL_0053: IL_01
    IL_0058: stfld 0x04000410
    IL_005D: br IL_00AB
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000410
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000403
    IL_006A: conv.r8
    IL_006B: ldc.i4.2
    IL_006C: nop
    IL_006D: nop
    IL_006E: stloc.0
    IL_006F: conv.r8
    IL_0070: ldloc.3
    IL_0071: nop
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x04000410
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000403
    IL_0080: conv.r8
    IL_0081: pop
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0085: conv.r8
    IL_008A: call 0x020A0000
    IL_008F: ldfld 0x04000410
    IL_0090: conv.r8
    IL_0091: ldloc.3
    IL_0092: nop
    IL_0093: nop
    IL_0095: br.s IL_0105
    IL_0096: IL_F5
    IL_0097: ldloc.0
    IL_0098: nop
    IL_0099: ldloc.0
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000410
    IL_00A0: conv.r8
    IL_00A1: stloc.0
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A5: ldc.i4.1
    IL_00A6: conv.r8
    IL_00A7: stloc.1
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: ldarg.0
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x04000410
    IL_00B6: stfld 0x0400040C
    IL_00BB: br IL_016A
    IL_00BC: ldarg.1
    IL_00BD: ldc.i4.1
    IL_0342: switch (160 cases)
    }

    public void ReturnBlade() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400040C
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_002E
    IL_0011: ldarg.0
    IL_0016: ldfld 0x0400040C
    IL_0017: ldnull
    IL_0018: conv.r8
    IL_0019: IL_4E
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400040C
    IL_0023: conv.r8
    IL_0024: ldloc.3
    IL_0025: nop
    IL_0026: nop
    IL_0028: br.s IL_003F
    IL_0029: conv.r8
    IL_002A: IL_F6
    IL_002B: ldloc.0
    IL_002C: nop
    IL_002D: ldloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000408
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000403
    IL_003A: conv.r8
    IL_003B: ldc.i4.2
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: conv.r8
    IL_0040: ldloc.3
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000408
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000403
    IL_0050: conv.r8
    IL_0051: pop
    IL_0052: nop
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_005A: call 0x020A0000
    IL_005F: ldfld 0x04000408
    IL_0060: ldarg.0
    IL_0065: ldfld 0x04000403
    IL_0066: conv.r8
    IL_0067: IL_4E
    IL_0068: nop
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04000409
    IL_0071: ldnull
    IL_0076: call 0x0A000021
    IL_007B: brfalse IL_00B9
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000409
    IL_0082: ldarg.0
    IL_0087: ldfld 0x04000407
    IL_0088: conv.r8
    IL_0089: ldc.i4.2
    IL_008A: nop
    IL_008B: nop
    IL_008C: stloc.0
    IL_008D: conv.r8
    IL_008E: ldloc.3
    IL_008F: nop
    IL_0090: nop
    IL_0091: stloc.0
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000409
    IL_0098: ldarg.0
    IL_009D: ldfld 0x04000407
    IL_009E: conv.r8
    IL_009F: pop
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: conv.r8
    IL_00A8: call 0x020A0000
    IL_00AD: ldfld 0x04000409
    IL_00AE: ldarg.0
    IL_00B3: ldfld 0x04000407
    IL_00B4: conv.r8
    IL_00B5: IL_4E
    IL_00B6: nop
    IL_00B7: nop
    IL_00B8: stloc.0
    IL_00B9: ret
    }

    public void HideBlade() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000408
    IL_0006: conv.r8
    IL_0007: stloc.3
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.0
    IL_000C: conv.r8
    IL_0011: beq IL_20A0012
    IL_0016: ldfld 0x04000409
    IL_0017: ldnull
    IL_001C: call 0x0A000021
    IL_0021: brfalse IL_0033
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000409
    IL_0028: conv.r8
    IL_0029: stloc.3
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.0
    IL_002E: conv.r8
    IL_0033: beq IL_20A0034
    IL_0038: ldfld 0x0400040A
    IL_0039: ldnull
    IL_003E: call 0x0A000021
    IL_0043: brfalse IL_0055
    IL_0044: ldarg.0
    IL_0049: ldfld 0x0400040A
    IL_004A: conv.r8
    IL_004B: stloc.3
    IL_004C: nop
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: ldc.i4.0
    IL_0050: conv.r8
    IL_0055: beq IL_20A0056
    IL_005A: ldfld 0x0400040B
    IL_005B: ldnull
    IL_0060: call 0x0A000021
    IL_0065: brfalse IL_0077
    IL_0066: ldarg.0
    IL_006B: ldfld 0x0400040B
    IL_006C: conv.r8
    IL_006D: stloc.3
    IL_006E: nop
    IL_006F: nop
    IL_0070: stloc.0
    IL_0071: ldc.i4.0
    IL_0072: conv.r8
    IL_0077: beq IL_2A0A0078
    }

    public void ShowBlade() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000408
    IL_0006: conv.r8
    IL_0007: stloc.3
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_0011: beq IL_20A0012
    IL_0016: ldfld 0x04000409
    IL_0017: ldnull
    IL_001C: call 0x0A000021
    IL_0021: brfalse IL_0033
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000409
    IL_0028: conv.r8
    IL_0029: stloc.3
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.1
    IL_002E: conv.r8
    IL_0033: beq IL_20A0034
    IL_0038: ldfld 0x0400040A
    IL_0039: ldnull
    IL_003E: call 0x0A000021
    IL_0043: brfalse IL_0055
    IL_0044: ldarg.0
    IL_0049: ldfld 0x0400040A
    IL_004A: conv.r8
    IL_004B: stloc.3
    IL_004C: nop
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: ldc.i4.1
    IL_0050: conv.r8
    IL_0055: beq IL_20A0056
    IL_005A: ldfld 0x0400040B
    IL_005B: ldnull
    IL_0060: call 0x0A000021
    IL_0065: brfalse IL_0077
    IL_0066: ldarg.0
    IL_006B: ldfld 0x0400040B
    IL_006C: conv.r8
    IL_006D: stloc.3
    IL_006E: nop
    IL_006F: nop
    IL_0070: stloc.0
    IL_0071: ldc.i4.1
    IL_0072: conv.r8
    IL_0077: beq IL_2A0A0078
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400040E
    IL_000A: brfalse IL_00AC
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400040C
    IL_0011: conv.r8
    IL_0016: cpobj 0x0A0A0000
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A00005E
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0025: stsfld 0x0027443F
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_002D: ldfld 0x0400040C
    IL_0032: call 0x0A00004B
    IL_0033: conv.r8
    IL_0034: IL_AF
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ldarg.0
    IL_0039: ldc.i4.0
    IL_003E: stfld 0x0400040E
    IL_003F: ldarg.0
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0049: stfld 0x0400040D
    IL_004E: br IL_00A7
    IL_004F: ldarg.0
    IL_0054: ldfld 0x0400040D
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_005C: stsfld 0x0036433F
    IL_005D: nop
    IL_005E: nop
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400040C
    IL_0065: dup
    IL_0066: conv.r8
    IL_006B: cpobj 0x280A0000
    IL_006C: localloc
    IL_006D: nop
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: ldarg.0
    IL_0075: ldfld 0x04000412
    IL_0076: conv.i2
    IL_007B: call 0x0A000008
    IL_0080: call 0x0A000024
    IL_0085: call 0x0A000008
    IL_008A: call 0x0A000029
    IL_008B: conv.r8
    IL_008C: IL_AF
    IL_008D: nop
    IL_008E: nop
    IL_008F: stloc.0
    IL_0094: br IL_00A7
    IL_0095: ldarg.0
    IL_0096: dup
    IL_009B: ldfld 0x0400040D
    IL_00A0: call 0x0A000024
    IL_00A1: IL_58
    IL_00A6: stfld 0x0400040D
    IL_00AB: br IL_00E4
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x04000411
    IL_00B2: IL_22
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: nop
    IL_00B7: IL_43
    IL_00BC: call 0x02000000
    IL_00BD: dup
    IL_00C2: ldfld 0x04000411
    IL_00C7: call 0x0A000024
    IL_00C8: IL_59
    IL_00CD: stfld 0x04000411
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x04000411
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: IL_41
    IL_00DA: ldloc.0
    IL_00DB: nop
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: ldarg.0
    IL_00E3: call 0x060001EA
    IL_00E4: ret
    }

    }}
