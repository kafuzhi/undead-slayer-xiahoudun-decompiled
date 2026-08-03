// Namespace: 
// Type: General_Stat

    public class General_Stat {{

    private static object GENERALKIND;
    public object general_index;
    public object general_kind;
    public object g_maxhp;
    public object g_maxatk;
    public object g_def;
    public object g_atkspd;
    public object g_unique;
    public object g_level;
    public object g_grade;
    private object rndkey;
    private object rndkey_og;

    public General_Stat() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400067B
    IL_0007: ldarg.0
    IL_0008: ldc.i4.8
    IL_000D: newarr 0x0100000B
    IL_0012: stfld 0x0400067E
    IL_0013: ldarg.0
    IL_0014: ldc.i4.8
    IL_0019: newarr 0x0100000B
    IL_001E: stfld 0x0400067F
    IL_001F: ldarg.0
    IL_0024: call 0x0A000001
    IL_0025: ret
    }

    public void SetGeneral() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: ldc.i4 10000000
    IL_0007: mul
    IL_000C: ldc.i4 100000
    IL_000D: add
    IL_000E: neg
    IL_0013: stfld 0x04000675
    IL_0014: ldarg.0
    IL_0015: ldarg.0
    IL_001A: ldfld 0x04000675
    IL_001B: ldc.i4.5
    IL_001C: mul
    IL_001D: neg
    IL_0022: stfld 0x04000676
    IL_0023: ldarg.0
    IL_0024: ldarg.1
    IL_0025: conv.i2
    IL_0026: IL_22
    IL_002B: stsfld 0x5B4B1896
    IL_002C: neg
    IL_0031: stfld 0x0400067C
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000675
    IL_0039: ldc.i4.s 10
    IL_003A: IL_3C
    IL_003C: ldloc.s 0
    IL_003D: nop
    IL_003E: nop
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000675
    IL_004A: stfld 0x0400067B
    IL_004F: br IL_0057
    IL_0050: ldarg.0
    IL_0051: ldc.i4.m1
    IL_0056: stfld 0x0400067B
    IL_0057: ldc.i4.0
    IL_0058: stloc.0
    IL_005D: br IL_0084
    IL_005E: ldarg.0
    IL_0063: ldfld 0x0400067F
    IL_0064: ldloc.0
    IL_0065: ldarg.1
    IL_0067: ldc.i4.s 10
    IL_0068: mul
    IL_0069: ldelem.i8
    IL_006A: ldarg.1
    IL_006C: ldc.i4.s 10
    IL_006D: add
    IL_006F: starg.s 1
    IL_0070: ldarg.0
    IL_0075: ldfld 0x0400067E
    IL_0076: ldloc.0
    IL_0077: ldarg.0
    IL_007C: ldfld 0x0400067F
    IL_007D: ldloc.0
    IL_007E: IL_94
    IL_007F: ldelem.i8
    IL_0080: ldloc.0
    IL_0081: ldc.i4.1
    IL_0082: IL_58
    IL_0083: stloc.0
    IL_0084: ldloc.0
    IL_0085: ldc.i4.8
    IL_0086: IL_3F
    IL_0087: IL_D3
    IL_0088: IL_FF
    IL_0089: IL_FF
    IL_008A: IL_FF
    IL_008B: ldarg.0
    IL_008C: ldarg.0
    IL_0091: ldfld 0x0400067F
    IL_0092: ldc.i4.4
    IL_0093: IL_94
    IL_0094: neg
    IL_0099: stfld 0x0400067D
    IL_009A: ldc.i4.0
    IL_009B: stloc.1
    IL_00A0: br IL_00E9
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x0400067E
    IL_00A7: ldloc.1
    IL_00A8: ldc.i4.4
    IL_00A9: mul
    IL_00AA: IL_8F
    IL_00AB: stloc.1
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: IL_01
    IL_00AF: dup
    IL_00B2: stloc 22551
    IL_00B3: IL_54
    IL_00B4: ldloc.1
    IL_00B9: brfalse IL_00E5
    IL_00BA: ldloc.1
    IL_00BB: ldc.i4.4
    IL_00BC: mul
    IL_00C1: brtrue IL_00E5
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x0400067E
    IL_00C8: ldarg.0
    IL_00CD: ldfld 0x0400067F
    IL_00CE: ldloc.1
    IL_00CF: ldc.i4.4
    IL_00D0: mul
    IL_00D1: IL_94
    IL_00D2: ldarg.0
    IL_00D7: ldfld 0x04000675
    IL_00D8: IL_58
    IL_00D9: ldc.i4.4
    IL_00DA: mul
    IL_00DB: IL_8F
    IL_00DC: stloc.1
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: IL_01
    IL_00E0: dup
    IL_00E3: stloc 22551
    IL_00E4: IL_54
    IL_00E5: ldloc.1
    IL_00E6: ldc.i4.1
    IL_00E7: IL_58
    IL_00E8: stloc.1
    IL_00E9: ldloc.1
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x0400067C
    IL_00F0: ldc.i4.1
    IL_00F1: IL_59
    IL_00F2: IL_3F
    IL_00F3: IL_AA
    IL_00F4: IL_FF
    IL_00F5: IL_FF
    IL_00F6: IL_FF
    IL_00F7: ldarg.0
    IL_00F8: ldarg.0
    IL_00FD: ldfld 0x0400067F
    IL_00FE: ldc.i4.0
    IL_00FF: IL_94
    IL_0100: conv.i2
    IL_0101: IL_22
    IL_0102: nop
    IL_0103: nop
    IL_0104: nop
    IL_0105: IL_3F
    IL_0106: IL_5A
    IL_0107: ldarg.0
    IL_010C: ldfld 0x0400067E
    IL_010D: ldc.i4.0
    IL_010E: IL_94
    IL_010F: ldarg.0
    IL_0114: ldfld 0x0400067F
    IL_0115: ldc.i4.0
    IL_0116: IL_94
    IL_0117: IL_59
    IL_0118: conv.i2
    IL_0119: IL_58
    IL_011A: ldarg.0
    IL_011F: ldfld 0x0400067C
    IL_0120: conv.i2
    IL_0121: IL_58
    IL_0122: IL_22
    IL_0123: nop
    IL_0124: nop
    IL_1EC096229: switch (2063751232 cases)
    }

    }}
