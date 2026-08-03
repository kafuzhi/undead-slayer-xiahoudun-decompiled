// Namespace: 
// Type: Tower_base

    public class Tower_base {{

    private object script_hpbar;
    private object script_cha;
    private object script_cam;
    private object hpbar;
    private object mytransform;
    private object attackdir;
    private object damage;
    private object life;
    private object maxhp;
    private object hp;
    private object cur_stage_index;
    public object iscastle;
    public object mydestroy;
    private object istower;

    public Tower_base() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000A49
    IL_0007: ldarg.0
    IL_000C: call 0x0A000001
    IL_000D: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A46
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A46
    IL_0012: conv.r8
    IL_0013: IL_B8
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: brfalse IL_0023
    IL_001C: ldarg.0
    IL_001D: ldc.i4.1
    IL_0022: stfld 0x04000A4F
    IL_0023: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000CDD
    IL_000A: call 0x06000220
    IL_000B: neg
    IL_0010: stfld 0x04000A4C
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000A4D
    IL_001B: brfalse IL_005F
    IL_001C: ldarg.0
    IL_001D: dup
    IL_0022: ldfld 0x04000A4A
    IL_0023: IL_22
    IL_0024: IL_CF
    IL_0025: IL_F7
    IL_0027: stloc.s 62
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000A4C
    IL_002E: conv.i2
    IL_002F: IL_5A
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000A4C
    IL_0036: conv.i2
    IL_0037: IL_5A
    IL_0038: IL_22
    IL_0039: IL_C3
    IL_003A: xor
    IL_003B: IL_CC
    IL_2931EC48: switch (172784386 cases)
    }

    public void Grabed() {
    IL_0000: ret
    }

    public void CastleBreak() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000A49
    IL_0007: ldarg.0
    IL_000C: call 0x0A000003
    IL_000D: ldc.i4.0
    IL_000E: conv.r8
    IL_0010: ldc.i4.s 0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000A45
    IL_0019: conv.r8
    IL_001A: stloc.0
    IL_001B: nop
    IL_001C: nop
    IL_001D: stloc.0
    IL_0022: call 0x0A000050
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000A46
    IL_0029: ldc.i4.0
    IL_002A: conv.r8
    IL_002F: brtrue IL_6F0A0030
    IL_0030: stloc.0
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: call 0x0A000050
    IL_0039: ldarg.0
    IL_003E: ldfld 0x04000A4D
    IL_0043: brfalse IL_005A
    IL_0048: ldstr 0x70000BD5
    IL_004D: call 0x0A000004
    IL_004E: conv.r8
    IL_0057: ldc.i8 436971639665262592
    IL_0058: nop
    IL_0059: ldloc.0
    IL_005A: ret
    }

    public void TankDamage() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000A4B
    IL_0007: conv.i2
    IL_0008: ldarg.0
    IL_000D: ldfld 0x04000A4A
    IL_000E: conv.i2
    IL_000F: IL_22
    IL_0010: IL_CD
    IL_0011: IL_CC
    IL_0012: IL_CC
    IL_0013: IL_3D
    IL_0014: IL_5A
    IL_0015: IL_59
    IL_0016: neg
    IL_001B: stfld 0x04000A4B
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000A42
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000A4A
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000A4B
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000A46
    IL_0034: IL_22
    IL_0035: IL_CD
    IL_0036: IL_CC
    IL_0037: IL_4C
    IL_0038: IL_3E
    IL_0039: ldc.i4.m1
    IL_003A: conv.r8
    IL_003B: ldc.i4.3
    IL_003C: ldarg.1
    IL_003D: nop
    IL_003E: ldloc.0
    IL_003F: ldarg.0
    IL_0044: call 0x0A00002B
    IL_0045: conv.r8
    IL_0046: IL_4D
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000A4B
    IL_0050: ldc.i4.0
    IL_0051: IL_3D
    IL_0053: ldloc.s 0
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04000A49
    IL_0060: brfalse IL_0067
    IL_0061: ldarg.0
    IL_0066: call 0x060005B7
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000A49
    IL_006D: ret
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
    IL_000C: ldc.i4.s 20
    IL_000D: IL_3F
    IL_000E: IL_57
    IL_000F: ldarg.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: ldarg.1
    IL_0013: conv.r8
    IL_0014: stloc.0
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: conv.r8
    IL_0019: ldc.i4.8
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: stloc.1
    IL_001E: ldloc.1
    IL_0020: ldc.i4.s 18
    IL_0021: IL_59
    IL_0024: ldarg 14
    IL_0025: nop
    IL_0026: nop
    IL_0027: IL_D3
    IL_0028: IL_01
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_EA
    IL_002C: IL_01
    IL_002D: nop
    IL_002E: nop
    IL_002F: ldarg.3
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_8F
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: IL_B6
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_D7
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_0040: 0xFE 00
    IL_0041: nop
    IL_0042: nop
    IL_0044: ldc.i4.s 1
    IL_0045: nop
    IL_0046: nop
    IL_0047: IL_36
    IL_0048: IL_01
    IL_0049: nop
    IL_004A: nop
    IL_004B: rem.un
    IL_004C: IL_01
    IL_004D: nop
    IL_004E: nop
    IL_0053: ldobj 0x88000001
    IL_0054: IL_01
    IL_0055: nop
    IL_0056: nop
    IL_005B: castclass 0xBC000001
    IL_005C: IL_01
    IL_005D: nop
    IL_005E: nop
    IL_0063: br IL_0260
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000A46
    IL_006B: conv.r8
    IL_006C: ldc.i4.2
    IL_006D: nop
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: ldarg.1
    IL_0071: conv.r8
    IL_0072: ldarg.0
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: conv.r8
    IL_0077: ldc.i4.2
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007F: call 0x0A000019
    IL_0084: stfld 0x04000A47
    IL_0085: ldarg.0
    IL_008A: ldflda 0x04000A47
    IL_008B: ldc.i4.1
    IL_008C: IL_22
    IL_008D: nop
    IL_008E: nop
    IL_008F: nop
    IL_0090: nop
    IL_0095: call 0x0A00001A
    IL_0096: ldarg.0
    IL_0097: ldarg.0
    IL_009C: ldfld 0x04000A47
    IL_00A1: call 0x0A000040
    IL_00A6: stfld 0x04000A47
    IL_00A7: ldarg.1
    IL_00A8: conv.r8
    IL_00A9: ldarg.0
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: stloc.0
    IL_00AD: conv.r8
    IL_00AE: IL_44
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: stloc.0
    IL_00B2: conv.r8
    IL_00B3: IL_3D
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: stloc.0
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000A47
    IL_00BD: IL_22
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: IL_B4
    IL_00C1: IL_C2
    IL_00C6: call 0x0A000008
    IL_00C7: conv.r8
    IL_00C8: IL_3E
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: stloc.0
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000A43
    IL_00D7: ldfld 0x040002C6
    IL_00D8: conv.i2
    IL_00DD: stfld 0x04000A48
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x04000A44
    IL_00E4: conv.r8
    IL_00E5: IL_35
    IL_00E6: IL_01
    IL_00E7: nop
    IL_00E8: ldloc.0
    IL_00ED: br IL_0260
    IL_00EE: ldarg.0
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000A43
    IL_00F9: ldfld 0x040002C6
    IL_00FA: conv.i2
    IL_00FF: stfld 0x04000A48
    IL_0100: ldarg.0
    IL_0105: ldfld 0x04000A44
    IL_0106: IL_22
    IL_0107: nop
    IL_0108: nop
    IL_010D: stsfld 0x01366F3F
    IL_010E: nop
    IL_010F: ldloc.0
    IL_0114: br IL_0260
    IL_0115: ldarg.0
    IL_0116: ldarg.1
    IL_0117: conv.r8
    IL_0118: IL_3D
    IL_0119: nop
    IL_011A: nop
    IL_011B: stloc.0
    IL_011C: conv.r8
    IL_011F: ldarga 0
    IL_0120: stloc.0
    IL_0125: stfld 0x04000A48
    IL_0126: ldarg.0
    IL_012B: ldfld 0x04000A44
    IL_012C: conv.r8
    IL_012D: IL_35
    IL_012E: IL_01
    IL_012F: nop
    IL_0130: ldloc.0
    IL_0135: br IL_0260
    IL_0136: ldarg.0
    IL_0137: ldarg.1
    IL_0138: conv.r8
    IL_0139: IL_3D
    IL_013A: nop
    IL_013B: nop
    IL_013C: stloc.0
    IL_013D: conv.r8
    IL_0140: ldarga 0
    IL_0141: stloc.0
    IL_0142: IL_22
    IL_0143: nop
    IL_0144: nop
    IL_0145: nop
    IL_2921F6B2: switch (172522842 cases)
    }

    }}
