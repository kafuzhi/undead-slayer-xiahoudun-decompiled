// Namespace: 
// Type: UI_result_extreme

    public class UI_result_extreme {{

    public object isclear;
    public object max_stage_index;
    private object coin;
    private object jade;
    private object chalv;
    private object language;
    private object gonext;
    public object basicSkin;
    public object bg_asset;
    public object img_bts;
    public object bt_empty;
    private object cashshop;
    private object changelevel;
    private object icon_pluspos;
    private object b_openshop;

    public UI_result_extreme() {
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

    }}
