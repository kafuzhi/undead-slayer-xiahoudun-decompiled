// Namespace: 
// Type: UI_result_ride

    public class UI_result_ride {{

    private object show_delay;
    private object posX;
    private object show_ui;
    private object getpoint;
    private object movefinish;
    private object coin;
    private object jade;
    private object getcoin;
    private object getcoin_og;
    private object count_coin;
    private object count_monster;
    private object count_behit;
    private object count_loss;
    private object getcoin_f;
    private object language;
    private object gonext;
    public object basicSkin;
    public object bg_asset;
    public object bg_list;
    public object img_map;
    public object bt_empty;
    private object pet_passiveskill;
    private object script_cha;

    public UI_result_ride() {
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

    }}
