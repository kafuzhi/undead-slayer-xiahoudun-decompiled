// Namespace: 
// Type: WeaponStat

    public class WeaponStat {{

    public object weapon_index;
    public object weapon_meshkind;
    public object weapon_kind;
    public object weapon_name;
    public object weapon_maxatk;
    public object weapon_minatk;
    public object weapon_spd;
    public object weapon_special;
    public object weapon_grade;
    public object weapon_upgrade;
    public object weapon_special_txt;
    public object weapon_cost;
    private object bottom_weaponicon;
    public object wi;
    private object extractseed;

    public WeaponStat() {
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

    }}
