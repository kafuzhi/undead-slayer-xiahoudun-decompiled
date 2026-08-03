// Namespace: 
// Type: AI_General

    public class AI_General {{

    private object mytransform;
    private object myanimation;
    private object mycollider;
    private object maxhp;
    public object hp;
    private object power;
    private object defence;
    private object dash;
    private object runspeed;
    private object atkspeed;
    private object distance_cha;
    private object hp_length;
    private object fb;
    private object life;
    private object call;
    private object disable;
    private object delay_invicibility;
    private object delay_call;
    private object rndpos;
    private object directionVector;
    private object behitdir;
    private object cha1;
    private object g_hp;
    private object c_weapon;
    private object c_spweapon;
    private object sp_selweapon;
    private object attack_i;
    private object attack_start;
    private object superarmor;
    private object showme;
    private object generalmovestat;
    private object grade;
    private object atkcount;
    private object damage;
    private object unique;
    private object efattach;
    public object snd_attack;
    public object ef_weapon;
    public object sp_weapon;
    public object direction_arrow;
    private object efpos;
    private object arrowTargetVector;
    private object arrowRotVector;
    private object efrot;
    private object gauge_hp;
    private object script_cam;

    public AI_General() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040000BB
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040000D0
    IL_000E: ldarg.0
    IL_000F: ldc.i4.2
    IL_0014: newarr 0x01000003
    IL_0019: stfld 0x040000D4
    IL_001A: ldarg.0
    IL_001F: call 0x0A000001
    IL_0020: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040000AE
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00002A
    IL_0017: stfld 0x040000AF
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A000003
    IL_0023: stfld 0x040000B0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x040000AF
    IL_002E: ldstr 0x7000016D
    IL_002F: conv.r8
    IL_0031: bge.s IL_0032
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: IL_3F
    IL_0039: conv.r8
    IL_003B: bgt.s IL_003C
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x040000AF
    IL_0048: ldstr 0x70000177
    IL_0049: conv.r8
    IL_004B: bge.s IL_004C
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: IL_22
    IL_004F: IL_CD
    IL_0050: IL_CC
    IL_0051: IL_4C
    IL_0052: IL_3E
    IL_0053: conv.r8
    IL_0055: bgt.s IL_0056
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ldarg.0
    IL_005D: ldfld 0x040000AF
    IL_0062: ldstr 0x700002A3
    IL_0063: conv.r8
    IL_0065: bge.s IL_0066
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: IL_22
    IL_0069: IL_CD
    IL_006A: IL_CC
    IL_006B: IL_4C
    IL_006C: IL_3E
    IL_006D: conv.r8
    IL_006F: bgt.s IL_0070
    IL_0070: nop
    IL_0071: stloc.0
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040000AF
    IL_007C: ldstr 0x700001C1
    IL_007D: conv.r8
    IL_007F: bge.s IL_0080
    IL_0080: nop
    IL_0081: stloc.0
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0089: stsfld 0x00306F3E
    IL_008A: nop
    IL_008B: stloc.0
    IL_008C: ldarg.0
    IL_0091: ldfld 0x040000AF
    IL_0096: ldstr 0x70000177
    IL_0097: conv.r8
    IL_0099: bge.s IL_009A
    IL_009A: nop
    IL_009B: stloc.0
    IL_009C: ldc.i4.4
    IL_009D: conv.r8
    IL_009F: ble.s IL_00A0
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x040000AF
    IL_00AC: ldstr 0x700002A3
    IL_00AD: conv.r8
    IL_00AF: bge.s IL_00B0
    IL_00B0: nop
    IL_00B1: stloc.0
    IL_00B2: ldc.i4.4
    IL_00B3: conv.r8
    IL_00B5: ble.s IL_00B6
    IL_00B6: nop
    IL_00B7: stloc.0
    IL_00B8: ldarg.0
    IL_00BD: ldfld 0x040000AF
    IL_00C2: ldstr 0x70000195
    IL_00C3: conv.r8
    IL_00C5: bge.s IL_00C6
    IL_00C6: nop
    IL_00C7: stloc.0
    IL_00C8: ldc.i4.1
    IL_00C9: conv.r8
    IL_00CB: ble.s IL_00CC
    IL_00CC: nop
    IL_00CD: stloc.0
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x040000AF
    IL_00D8: ldstr 0x700001A9
    IL_00D9: conv.r8
    IL_00DB: bge.s IL_00DC
    IL_00DC: nop
    IL_00DD: stloc.0
    IL_00DE: ldc.i4.1
    IL_00DF: conv.r8
    IL_00E1: ble.s IL_00E2
    IL_00E2: nop
    IL_00E3: stloc.0
    IL_00E4: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x040000C3
    IL_0015: ldarg.0
    IL_001A: ldstr 0x700002BD
    IL_001B: IL_22
    IL_001C: IL_CD
    IL_001D: IL_CC
    IL_001E: IL_CC
    IL_001F: IL_3D
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0x0017283F
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040000AF
    IL_0034: ldstr 0x700001C1
    IL_0035: conv.r8
    IL_0036: IL_3C
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: pop
    IL_003B: ldarg.0
    IL_0040: ldstr 0x700002DB
    IL_0045: call 0x0A000004
    IL_0046: conv.r8
    IL_0047: stloc.3
    IL_0048: nop
    IL_0049: nop
    IL_004B: br.s IL_006E
    IL_004C: IL_CD
    IL_004D: IL_CC
    IL_004E: IL_4C
    IL_004F: IL_3E
    IL_0050: IL_22
    IL_0051: IL_8F
    IL_0052: IL_C2
    IL_0053: conv.u8
    IL_0054: IL_3D
    IL_0059: newobj 0x0A000038
    IL_005A: IL_22
    IL_005B: nop
    IL_005C: nop
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_22
    IL_0061: bne.un.s IL_0095
    IL_0062: conv.ovf.i4.un
    IL_0063: IL_BF
    IL_0064: IL_22
    IL_0065: IL_3D
    IL_0066: stloc.0
    IL_0067: ldc.i4.1
    IL_3999998F4: switch (3865470498 cases)
    }

    public void Set_stat() {
    IL_0000: ldarg.0
    IL_0002: ldarg.s 8
    IL_0007: stfld 0x040000CD
    IL_0008: ldarg.0
    IL_000A: ldarg.s 9
    IL_000F: stfld 0x040000D0
    IL_0010: ldarg.0
    IL_0012: ldarg.s 10
    IL_0017: stfld 0x040000D1
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040000D0
    IL_001E: ldc.i4.m1
    IL_003F: switch (7 cases)
    IL_0040: ldelem.i
    IL_0045: stfld 0x040000C7
    IL_0046: ldarg.0
    IL_0048: ldarg.s 7
    IL_004D: stfld 0x040000B7
    IL_004E: ldarg.0
    IL_0053: ldfld 0x040000AF
    IL_0058: ldstr 0x70000195
    IL_0059: conv.r8
    IL_005B: bge.s IL_005C
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040000B7
    IL_0064: conv.r8
    IL_0066: bgt.s IL_0067
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: ldarg.0
    IL_006E: ldfld 0x040000AF
    IL_0073: ldstr 0x700001A9
    IL_0074: conv.r8
    IL_0076: bge.s IL_0077
    IL_0077: nop
    IL_0078: stloc.0
    IL_0079: ldarg.0
    IL_007E: ldfld 0x040000B7
    IL_007F: conv.r8
    IL_0081: bgt.s IL_0082
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0085: IL_22
    IL_0086: nop
    IL_0087: nop
    IL_008C: stsfld 0x226B033F
    IL_008D: nop
    IL_008E: nop
    IL_008F: nop
    IL_0090: IL_3F
    IL_0091: IL_5A
    IL_0092: IL_58
    IL_0097: stfld 0x040000B3
    IL_0098: ldarg.0
    IL_0099: ldc.i4.1
    IL_009A: ldarg.2
    IL_009B: IL_58
    IL_00A0: stfld 0x040000B4
    IL_00A1: ldarg.0
    IL_00A2: ldarg.3
    IL_00A7: stfld 0x040000B1
    IL_00A8: ldarg.0
    IL_00AA: ldarg.s 4
    IL_00AF: stfld 0x040000B2
    IL_00B0: ldarg.0
    IL_00B5: ldfld 0x040000B2
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x040000B1
    IL_00BC: IL_3E
    IL_00BD: stloc.2
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x040000B1
    IL_00CC: stfld 0x040000B2
    IL_00CD: ldarg.0
    IL_00CF: ldarg.s 6
    IL_00D4: stfld 0x040000B6
    IL_00D5: ldarg.0
    IL_00D7: ldarg.s 5
    IL_00DC: stfld 0x040000B5
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x040000AF
    IL_00E7: ldstr 0x7000016D
    IL_00E8: conv.r8
    IL_00EA: bge.s IL_00EB
    IL_00EB: nop
    IL_00EC: stloc.0
    IL_00ED: ldarg.0
    IL_00F2: ldfld 0x040000B6
    IL_00F3: conv.r8
    IL_00F5: bgt.s IL_00F6
    IL_00F6: nop
    IL_00F7: stloc.0
    IL_00F8: ret
    }

    public void CallGeneral() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000DB
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040000AE
    IL_000D: ldc.i4.s 30
    IL_000E: IL_22
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_4B9D2: switch (77423 cases)
    }

    public void SetRndPosition() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00007E
    IL_0006: IL_22
    IL_0007: IL_CD
    IL_0008: IL_CC
    IL_0009: IL_4C
    IL_000A: IL_3E
    IL_000F: call 0x0A000008
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040000C3
    IL_0016: conv.r8
    IL_0017: ldc.i4.2
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001F: call 0x0A000029
    IL_0020: ldarg.0
    IL_0025: ldfld 0x040000C3
    IL_0026: conv.r8
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: IL_22
    IL_002C: ldelem.i
    IL_002D: IL_99
    IL_002E: IL_99
    IL_002F: IL_3E
    IL_0034: call 0x0A000008
    IL_0039: call 0x0A000029
    IL_003E: stfld 0x040000C0
    IL_003F: ldarg.0
    IL_0044: ldflda 0x040000C0
    IL_0045: ldc.i4.1
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004F: call 0x0A00001A
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x040000AE
    IL_0057: conv.r8
    IL_0058: ldc.i4.2
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ldarg.0
    IL_0061: ldfld 0x040000C3
    IL_0062: conv.r8
    IL_0063: ldc.i4.2
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_006B: call 0x0A000052
    IL_0070: stfld 0x040000B8
    IL_0071: ldarg.0
    IL_0076: ldfld 0x040000B8
    IL_0077: IL_22
    IL_0079: bne.un.s IL_00AD
    IL_007A: conv.ovf.i4.un
    IL_007B: IL_3E
    IL_007C: IL_43
    IL_007D: ldc.i4.6
    IL_007E: nop
    IL_007F: nop
    IL_0080: nop
    IL_0081: ldarg.0
    IL_0086: ldfld 0x040000AF
    IL_008B: ldstr 0x7000016D
    IL_008C: conv.r8
    IL_008D: IL_55
    IL_008E: nop
    IL_008F: nop
    IL_0090: stloc.0
    IL_0091: ldarg.0
    IL_0092: ldc.i4.1
    IL_0097: stfld 0x040000CB
    IL_009C: br IL_00C0
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x040000B0
    IL_00A3: ldc.i4.1
    IL_00A4: conv.r8
    IL_00A6: ldc.i4.s 0
    IL_00A7: nop
    IL_00A8: stloc.0
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x040000AF
    IL_00B3: ldstr 0x700001C1
    IL_00B4: conv.r8
    IL_00B5: IL_55
    IL_00B6: nop
    IL_00B7: nop
    IL_00B8: stloc.0
    IL_00B9: ldarg.0
    IL_00BA: ldc.i4.0
    IL_00BF: stfld 0x040000CB
    IL_00C0: ldarg.0
    IL_00C5: ldfld 0x040000AE
    IL_00C6: conv.r8
    IL_00C7: ldc.i4.2
    IL_00C8: nop
    IL_00C9: nop
    IL_00CA: stloc.0
    IL_00CB: stloc.0
    IL_00CD: ldloca.s 0
    IL_00D2: ldfld 0x0A00005E
    IL_00D7: call 0x0A00007F
    IL_00D8: conv.i4
    IL_00D9: IL_23
    IL_00DA: IL_CD
    IL_00DB: IL_CC
    IL_00DC: IL_CC
    IL_00DD: IL_CC
    IL_00DE: IL_CC
    IL_00DF: IL_CC
    IL_00E0: ldarg.2
    IL_1D5F1: switch (30019 cases)
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000CA
    IL_000A: brtrue IL_0016
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040000BB
    IL_0015: brtrue IL_0017
    IL_0016: ret
    IL_0017: ldarg.0
    IL_0019: ldarga.s 1
    IL_001E: ldfld 0x0A000023
    IL_001F: not
    IL_0024: stfld 0x040000CF
    IL_0026: ldarga.s 1
    IL_0027: ldc.i4.1
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_0031: call 0x0A00001A
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040000AF
    IL_0038: conv.r8
    IL_003B: ldloc 0
    IL_003C: stloc.0
    IL_003D: ldarg.0
    IL_0042: call 0x0A00003D
    IL_0043: ldarg.1
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_004B: cpobj 0x00082842
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: conv.r8
    IL_004F: IL_3E
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0054: ldc.i4.1
    IL_0055: ldarg.0
    IL_005A: ldfld 0x040000CF
    IL_005B: ldarg.0
    IL_0060: ldfld 0x040000B4
    IL_0061: IL_59
    IL_0066: call 0x0A000080
    IL_006B: stfld 0x040000CF
    IL_006C: ldarg.0
    IL_006D: dup
    IL_0072: ldfld 0x040000B2
    IL_0073: ldarg.0
    IL_0078: ldfld 0x040000CF
    IL_0079: IL_59
    IL_007E: stfld 0x040000B2
    IL_007F: ldarg.0
    IL_0084: ldfld 0x040000B0
    IL_0085: ldc.i4.0
    IL_0086: conv.r8
    IL_0088: ldc.i4.s 0
    IL_0089: nop
    IL_008A: stloc.0
    IL_008B: ldarg.0
    IL_008C: IL_22
    IL_008D: nop
    IL_008E: nop
    IL_008F: rem
    IL_2FA88: switch (48765 cases)
    }

    public void HPgaugeSet() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0xB27B023F
    IL_0009: nop
    IL_000A: nop
    IL_000B: ldarg.2
    IL_000C: conv.i2
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040000B1
    IL_0013: conv.i2
    IL_0014: add
    IL_0015: IL_59
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_001D: stsfld 0xB97D5A3E
    IL_001E: nop
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040000DA
    IL_002B: call 0x0A000082
    IL_002C: ldarg.0
    IL_0031: ldfld 0x040000B9
    IL_0036: call 0x0A000083
    IL_0037: conv.r8
    IL_0038: IL_F3
    IL_0039: ldarg.0
    IL_003A: nop
    IL_003B: ldloc.0
    IL_003C: ret
    }

    public void HPfull() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000C4
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
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040000B1
    IL_001C: stfld 0x040000B2
    IL_001D: ldarg.0
    IL_0022: call 0x06000033
    IL_0023: ldarg.0
    IL_0028: ldstr 0x700002BD
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0035: stsfld 0x0017283F
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ldarg.0
    IL_0039: ldc.i4.0
    IL_003E: stfld 0x040000BD
    IL_003F: ldarg.0
    IL_0040: ldc.i4.1
    IL_0045: stfld 0x040000BB
    IL_0046: ldarg.0
    IL_0047: ldc.i4.0
    IL_004C: stfld 0x040000CA
    IL_004D: ldarg.0
    IL_0052: ldfld 0x040000AE
    IL_0053: ldarg.0
    IL_0058: ldfld 0x040000C3
    IL_0059: conv.r8
    IL_005A: ldc.i4.2
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: stloc.0
    IL_0060: ldloca.s 0
    IL_0065: ldfld 0x0A00005E
    IL_0066: IL_22
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: nop
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040000C3
    IL_0071: conv.r8
    IL_0072: ldc.i4.2
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: stloc.1
    IL_0078: ldloca.s 1
    IL_007D: ldfld 0x0A00005C
    IL_0082: newobj 0x0A000076
    IL_0083: conv.r8
    IL_0084: ldloc.3
    IL_0085: nop
    IL_0086: nop
    IL_0087: stloc.0
    IL_0088: ldarg.0
    IL_008D: ldfld 0x040000AF
    IL_0092: ldstr 0x700001C1
    IL_0093: conv.r8
    IL_0094: IL_3C
    IL_0095: nop
    IL_0096: nop
    IL_0097: stloc.0
    IL_0098: pop
    IL_0099: ldarg.0
    IL_009E: ldfld 0x040000B0
    IL_009F: ldc.i4.1
    IL_00A0: conv.r8
    IL_00A2: ldc.i4.s 0
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A5: ret
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
    IL_000B: ldc.i4.8
    IL_0084: switch (29 cases)
    }

    public void AttackOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000BB
    IL_000A: brfalse IL_0021
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040000CB
    IL_0015: brtrue IL_0021
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040000BC
    IL_0020: brfalse IL_002E
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040000B0
    IL_0027: ldc.i4.0
    IL_0028: conv.r8
    IL_002A: ldc.i4.s 0
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ret
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040000C9
    IL_0038: brtrue IL_00D4
    IL_0039: ldarg.0
    IL_003E: ldfld 0x040000D0
    IL_003F: ldc.i4.0
    IL_0040: IL_3F
    IL_0041: ldc.i4.1
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0045: ldarg.0
    IL_0046: ldarg.0
    IL_004B: ldfld 0x040000CE
    IL_004C: ldc.i4.1
    IL_004D: IL_58
    IL_004E: ldc.i4.5
    IL_004F: ldarg.0
    IL_0054: ldfld 0x040000CD
    IL_0055: IL_59
    IL_0056: mul
    IL_005B: stfld 0x040000CE
    IL_005C: ldarg.0
    IL_005D: ldarg.1
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040000AE
    IL_0064: conv.r8
    IL_0065: ldc.i4.2
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_006D: call 0x0A000019
    IL_0072: stfld 0x040000C1
    IL_0073: ldarg.0
    IL_0078: ldfld 0x040000AF
    IL_007D: ldstr 0x70000195
    IL_007E: conv.r8
    IL_007F: IL_3C
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: pop
    IL_0084: ldarg.0
    IL_0085: ldarg.0
    IL_008A: ldfld 0x040000AF
    IL_008F: ldstr 0x700001A9
    IL_0090: conv.r8
    IL_0095: newobj 0x7D0A0000
    IL_0096: IL_C8
    IL_0097: nop
    IL_0098: nop
    IL_0099: ldarg.2
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040000C8
    IL_00A0: ldc.i4.1
    IL_00A1: conv.r8
    IL_00A3: ble.s IL_00A4
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x040000C8
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x040000B7
    IL_00B2: conv.r8
    IL_00B4: bgt.s IL_00B5
    IL_00B5: nop
    IL_00B6: stloc.0
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4.1
    IL_00BD: stfld 0x040000C9
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x040000AE
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x040000C1
    IL_00CE: call 0x0A00001D
    IL_00CF: conv.r8
    IL_00D4: call 0x2A0A0000
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000BD
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040000BB
    IL_0016: brtrue IL_007C
    IL_0017: ldarg.0
    IL_0018: dup
    IL_001D: ldfld 0x040000BE
    IL_0022: call 0x0A000024
    IL_0023: IL_58
    IL_0028: stfld 0x040000BE
    IL_0029: ldarg.0
    IL_002E: ldfld 0x040000BE
    IL_002F: IL_22
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_10943: switch (16963 cases)
    }

    }}
