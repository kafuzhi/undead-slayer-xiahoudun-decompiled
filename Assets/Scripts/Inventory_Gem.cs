// Namespace: 
// Type: Inventory_Gem

    public class Inventory_Gem {{

    public object jeweltex;
    private object getitem_tex;
    public object bt_yesno;
    public object bg_material;
    public object icon_key;
    public object basicSkin;
    private object getitem_grade;
    private object getitem;
    private object cur_stage_index;
    private object language;
    private object posX;
    private object posY;
    private object script_ui;

    public Inventory_Gem() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.5
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000739
    IL_000C: ldarg.0
    IL_0011: ldc.i4 176
    IL_0016: stfld 0x04000743
    IL_0017: ldarg.0
    IL_0019: ldc.i4.s 94
    IL_001E: stfld 0x04000744
    IL_001F: ldarg.0
    IL_0024: call 0x0A000001
    IL_0025: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000742
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000BD5
    IL_001A: call 0x0A000004
    IL_001B: conv.r8
    IL_0020: brtrue IL_7D2B0021
    IL_0023: ldarg 7
    IL_0024: ldarg.2
    IL_0025: ldarg.0
    IL_002A: ldstr 0x70000CDD
    IL_002F: call 0x06000220
    IL_0034: stfld 0x04000741
    IL_0035: ret
    }

    public void GetItem() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000745
    IL_000A: ldfld 0x04000F1C
    IL_000B: stloc.0
    IL_000C: ldc.i4.0
    IL_000D: stloc.1
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000741
    IL_0014: ldloc.0
    IL_0059: switch (16 cases)
    IL_1C810007A: switch (1912864775 cases)
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
    IL_003B: ldfld 0x0400073E
    IL_0040: call 0x0A0000DF
    IL_0042: ldc.i4.s -5
    IL_0047: call 0x0A0000EF
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000740
    IL_004E: ldc.i4.0
    IL_004F: IL_3E
    IL_0050: IL_BE
    IL_0051: IL_01
    IL_0052: nop
    IL_0053: nop
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000743
    IL_005A: conv.i2
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000744
    IL_0061: conv.i2
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_43
    IL_0067: IL_22
    IL_0068: nop
    IL_0069: nop
    IL_006A: nop
    IL_006B: IL_43
    IL_0070: call 0x0600021D
    IL_0071: ldarg.0
    IL_0076: ldfld 0x0400073C
    IL_007B: call 0x0A0000E0
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000743
    IL_0083: ldc.i4.s 48
    IL_0084: IL_58
    IL_0085: conv.i2
    IL_0086: ldarg.0
    IL_008B: ldfld 0x04000744
    IL_008D: ldc.i4.s 46
    IL_008E: IL_58
    IL_008F: conv.i2
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0093: nop
    IL_0094: IL_42
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: nop
    IL_0099: IL_42
    IL_009E: call 0x0600021D
    IL_009F: ldarg.0
    IL_00A4: ldfld 0x0400073A
    IL_00A9: call 0x0A0000E0
    IL_00AA: ldarg.0
    IL_00AF: ldfld 0x04000743
    IL_00B1: ldc.i4.s 32
    IL_00B2: IL_58
    IL_00B3: conv.i2
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x04000744
    IL_00BB: ldc.i4.s 92
    IL_00BC: IL_58
    IL_00BD: conv.i2
    IL_00BE: IL_22
    IL_00BF: nop
    IL_00C0: nop
    IL_00C5: stsfld 0x00002242
    IL_00C6: nop
    IL_00C7: IL_42
    IL_00CC: call 0x0600021D
    IL_00D1: ldsfld 0x040007B2
    IL_00D2: ldarg.0
    IL_00D7: ldfld 0x04000742
    IL_00D9: ldc.i4.s 45
    IL_00DE: call 0x0A0000E1
    IL_00DF: ldarg.0
    IL_00E4: ldfld 0x0400073B
    IL_00E9: call 0x0A0000F1
    IL_00EE: brfalse IL_0101
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000745
    IL_00F5: conv.r8
    IL_00F6: IL_BF
    IL_00F7: ldloc.0
    IL_00F8: nop
    IL_00F9: ldloc.0
    IL_00FA: ldarg.0
    IL_00FB: ldc.i4.0
    IL_0100: stfld 0x04000740
    IL_0101: ldarg.0
    IL_0106: ldfld 0x04000740
    IL_0107: ldc.i4.1
    IL_028C: switch (96 cases)
    }

    }}
