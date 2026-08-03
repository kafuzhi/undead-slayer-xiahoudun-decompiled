// Namespace: 
// Type: Map_Compose

    public class Map_Compose {{

    private static object MAXCOIN;
    private static object MAXOBJ;
    private static object MAXENEMY;
    public object map;
    public object soulstone;
    public object barricate;
    public object enemy;
    public object dummy_gui;
    private object mapposZ;
    private object clone_pmap;
    private object c_soulstone;
    private object c_barricate;
    private object c_enemy;
    private object count_soulstone;
    private object count_barricate;
    private object maplength;
    private object ss_creat_delay;
    private object ss_creat_time;
    public object finalmap;
    private object clone_obj;
    private object ss_posX;
    private object barricate_posX;
    private object negative_factor;
    private object tutorial;

    public Map_Compose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.5
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x040007DF
    IL_000C: ldarg.0
    IL_000D: ldc.i4.2
    IL_0012: newarr 0x0100002F
    IL_0017: stfld 0x040007E4
    IL_0018: ldarg.0
    IL_0019: ldc.i4.2
    IL_001E: newarr 0x01000003
    IL_0023: stfld 0x040007E5
    IL_0024: ldarg.0
    IL_0026: ldc.i4.s 14
    IL_002B: newarr 0x01000003
    IL_0030: stfld 0x040007E6
    IL_0031: ldarg.0
    IL_0032: ldc.i4.7
    IL_0037: newarr 0x01000003
    IL_003C: stfld 0x040007E7
    IL_003D: ldarg.0
    IL_003E: ldc.i4.3
    IL_0043: newarr 0x01000003
    IL_0048: stfld 0x040007E8
    IL_0049: ldarg.0
    IL_004A: IL_22
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_C8
    IL_004E: IL_42
    IL_0053: stfld 0x040007ED
    IL_0054: ldarg.0
    IL_0055: ldc.i4.1
    IL_005A: stfld 0x040007EE
    IL_005B: ldarg.0
    IL_005C: ldc.i4.m1
    IL_0061: stfld 0x040007F3
    IL_0062: ldarg.0
    IL_0067: call 0x0A000001
    IL_0068: ret
    }

    private void Awake() {
    IL_0004: ldstr 0x70022760
    IL_0009: call 0x0A000077
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldnull
    IL_0011: call 0x0A000061
    IL_0016: brfalse IL_0038
    IL_0017: ldarg.0
    IL_001C: call 0x0600039A
    IL_0021: call 0x0A000035
    IL_0022: conv.r8
    IL_0023: ldarg.0
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: ldc.i4.0
    IL_0028: conv.r8
    IL_002D: brtrue IL_6F0A002E
    IL_002E: stloc.0
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldc.i4.1
    IL_0033: conv.r8
    IL_0034: stloc.1
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ret
    }

    public void LoadingFinish() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_C0
    IL_0005: IL_3F
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_1D4AE: switch (29992 cases)
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
    IL_0019: ldstr 0x7002270C
    IL_001E: call 0x0A0001C1
    IL_0023: call 0x0A0001C2
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002E: ldstr 0x7000174B
    IL_0033: call 0x06000220
    IL_0034: stloc.1
    IL_0035: ldc.i4.0
    IL_0036: stloc.2
    IL_003B: br IL_008C
    IL_003C: ldarg.0
    IL_0041: ldfld 0x040007E4
    IL_0042: ldloc.2
    IL_0043: IL_8F
    IL_0045: bge.s IL_0046
    IL_0046: nop
    IL_0047: IL_01
    IL_0048: dup
    IL_0049: IL_4E
    IL_004A: ldloc.0
    IL_004B: IL_58
    IL_004C: IL_56
    IL_004D: ldloc.0
    IL_004E: IL_22
    IL_004F: nop
    IL_0050: nop
    IL_0055: ldc.i4 34232386
    IL_005A: ldfld 0x040007E5
    IL_005B: ldloc.2
    IL_005C: ldarg.0
    IL_0061: ldfld 0x040007DF
    IL_0062: ldloc.1
    IL_0063: ldc.i4.1
    IL_0064: IL_59
    IL_0065: ldelem.i
    IL_006A: call 0x0A000042
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040007E4
    IL_0071: ldloc.2
    IL_0072: IL_98
    IL_0077: call 0x0A000008
    IL_007C: call 0x0A000013
    IL_0081: call 0x0A000014
    IL_0082: conv.u4
    IL_0083: ldarg.1
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_01
    IL_008B: stelem 0x0C581708
    IL_008C: ldloc.2
    IL_008D: ldc.i4.2
    IL_008E: IL_3F
    IL_008F: IL_A9
    IL_0090: IL_FF
    IL_0091: IL_FF
    IL_0092: IL_FF
    IL_0093: ldc.i4.0
    IL_0094: stloc.3
    IL_0099: br IL_00C9
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040007E8
    IL_00A0: ldloc.3
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x040007E2
    IL_00A7: ldc.i4.3
    IL_00A8: ldloc.3
    IL_00A9: IL_58
    IL_00AA: conv.i2
    IL_00AF: call 0x0A00004B
    IL_00B4: call 0x0A0000C2
    IL_00B9: call 0x0A000013
    IL_00BE: call 0x0A000014
    IL_00BF: conv.u4
    IL_00C0: ldarg.1
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: IL_01
    IL_00C8: stelem 0x0D581709
    IL_00C9: ldloc.3
    IL_00CA: ldc.i4.3
    IL_00CB: IL_3F
    IL_00CC: IL_CA
    IL_00CD: IL_FF
    IL_00CE: IL_FF
    IL_00CF: IL_FF
    IL_00D0: ldc.i4.0
    IL_00D2: stloc.s 4
    IL_00D7: br IL_010B
    IL_00D8: ldarg.0
    IL_00DD: ldfld 0x040007E7
    IL_00DF: ldloc.s 4
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x040007E1
    IL_00E6: IL_22
    IL_00E7: nop
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: IL_C0
    IL_00EF: call 0x0A000042
    IL_00F4: call 0x0A0000C2
    IL_00F9: call 0x0A000013
    IL_00FE: call 0x0A000014
    IL_00FF: conv.u4
    IL_0100: ldarg.1
    IL_0101: nop
    IL_0102: nop
    IL_0103: IL_01
    IL_0108: stelem 0x58170411
    IL_010A: stloc.s 4
    IL_010C: ldloc.s 4
    IL_010D: ldc.i4.7
    IL_010E: IL_3F
    IL_010F: IL_C5
    IL_0110: IL_FF
    IL_0111: IL_FF
    IL_0112: IL_FF
    IL_0113: ldc.i4.0
    IL_0115: stloc.s 5
    IL_011A: br IL_014E
    IL_011B: ldarg.0
    IL_0120: ldfld 0x040007E6
    IL_0122: ldloc.s 5
    IL_0123: ldarg.0
    IL_0128: ldfld 0x040007E0
    IL_0129: IL_22
    IL_012A: nop
    IL_012B: nop
    IL_012C: nop
    IL_012D: IL_C0
    IL_0132: call 0x0A000042
    IL_0137: call 0x0A0000C2
    IL_013C: call 0x0A000013
    IL_0141: call 0x0A000014
    IL_0142: conv.u4
    IL_0143: ldarg.1
    IL_0144: nop
    IL_0145: nop
    IL_0146: IL_01
    IL_014B: stelem 0x58170511
    IL_014D: stloc.s 5
    IL_014F: ldloc.s 5
    IL_0151: ldc.i4.s 14
    IL_0152: IL_3F
    IL_0153: IL_C4
    IL_0154: IL_FF
    IL_0155: IL_FF
    IL_0156: IL_FF
    IL_0157: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040007EC
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040007EC
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040007EC
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040007ED
    IL_001E: IL_44
    IL_001F: IL_A9
    IL_0020: ldarg.0
    IL_0021: nop
    IL_0022: nop
    IL_0023: ldc.i4.0
    IL_0025: ldc.i4.s 20
    IL_002A: call 0x0A000045
    IL_002B: stloc.0
    IL_002C: ldloc.0
    IL_002D: ldc.i4.2
    IL_002E: IL_3C
    IL_002F: ldarg.0
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: ldc.i4.2
    IL_0034: stloc.0
    IL_0035: ldloc.0
    IL_0037: ldc.i4.s 12
    IL_0038: IL_3F
    IL_0039: ldelem.i1
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: ldarg.0
    IL_003E: IL_22
    IL_003F: IL_8F
    IL_0040: IL_C2
    IL_0041: conv.u8
    IL_0042: IL_BD
    IL_0043: IL_22
    IL_0044: IL_8F
    IL_0045: IL_C2
    IL_0046: conv.u8
    IL_0047: IL_3D
    IL_004C: call 0x0A000075
    IL_0051: stfld 0x040007F1
    IL_0052: ldarg.0
    IL_0053: IL_22
    IL_0054: ldelem.i
    IL_0055: IL_99
    IL_0056: IL_99
    IL_0057: IL_BE
    IL_0058: IL_22
    IL_0059: ldelem.i
    IL_005A: IL_99
    IL_005B: IL_99
    IL_005C: IL_3E
    IL_0061: call 0x0A000075
    IL_0066: stfld 0x040007F0
    IL_0067: ldc.i4.0
    IL_0068: stloc.1
    IL_006D: br IL_00CC
    IL_006E: ldarg.0
    IL_0073: ldfld 0x040007E6
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040007E9
    IL_007A: ldelem.i
    IL_007F: call 0x0A000062
    IL_0080: ldarg.0
    IL_0085: ldfld 0x040007F0
    IL_0086: ldarg.0
    IL_008B: ldfld 0x040007F1
    IL_008C: ldloc.1
    IL_008D: conv.i2
    IL_008E: IL_5A
    IL_008F: IL_58
    IL_0094: call 0x0A000008
    IL_0099: call 0x0A000042
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_009D: nop
    IL_26666692A: switch (2576980514 cases)
    }

    }}
