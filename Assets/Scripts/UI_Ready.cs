// Namespace: 
// Type: UI_Ready

    public class UI_Ready {{

    public object ci;
    public object review_icon;
    public object txt_loading;
    public object basicSkin;
    private object step;
    private object language;
    public object coco_bg;
    public object coco_cha;
    public object duoku_bg;
    public object uc_bg;
    public object jinshan_bg;
    public object menhu_bg;
    public object anzhi_bg;
    public object black_bg;
    public object coco_logo;
    public object muzhiwan_bg;
    private object channelId;
    private object usimCheck;

    public UI_Ready() {
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

    }}
