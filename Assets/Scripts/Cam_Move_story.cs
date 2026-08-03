// Namespace: 
// Type: Cam_Move_story

    public class Cam_Move_story {{

    public object cha_cutin;
    public object txt_box;
    private object mytransform;
    private object trans;
    private object updelay;
    private object color_alpha;
    private object showcut;
    private object story_final;
    public object basic;
    private object chaname;
    private object speech;
    private object language;

    public Cam_Move_story() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000261
    IL_000C: ret
    }

    private void Start() {
    IL_0004: call 0x0A0000EB
    IL_0009: ldstr 0x70000BEF
    IL_000E: call 0x0A0000EC
    IL_0013: brfalse IL_012E
    IL_0014: ldarg.0
    IL_0019: call 0x0A0000D0
    IL_001A: IL_22
    IL_001B: nop
    IL_001C: nop
    IL_001D: IL_C0
    IL_001E: IL_BF
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0022: IL_C0
    IL_0023: IL_3F
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_002B: stsfld 0x000022BF
    IL_0030: stsfld 0xD70A223F
    IL_0031: IL_23
    IL_0032: IL_3C
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_003A: ldc.i4 13707329
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: conv.r8
    IL_003E: IL_D2
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0043: ldc.i4.1
    IL_0048: stfld 0x04000266
    IL_0049: ldarg.0
    IL_004E: ldstr 0x70000BB3
    IL_0053: call 0x0A000095
    IL_0058: stfld 0x0400026A
    IL_005D: ldstr 0x700004DD
    IL_0062: call 0x06000220
    IL_0063: stloc.0
    IL_0064: ldloc.0
    IL_0065: ldc.i4.m1
    IL_006A: beq IL_00DA
    IL_006B: ldarg.0
    IL_0070: ldstr 0x70000BFF
    IL_0075: call 0x0A000012
    IL_0076: conv.u8
    IL_0077: IL_3C
    IL_0078: nop
    IL_0079: nop
    IL_007A: IL_01
    IL_007F: stfld 0x0400025F
    IL_0080: ldarg.0
    IL_0085: ldsfld 0x040007B2
    IL_0086: ldarg.0
    IL_008B: ldfld 0x0400026A
    IL_0090: ldc.i4 372
    IL_0095: call 0x0A0000E1
    IL_009A: ldstr 0x70000C0F
    IL_009F: ldsfld 0x040007B2
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x0400026A
    IL_00AA: ldc.i4 361
    IL_00AF: call 0x0A0000E1
    IL_00B4: call 0x0A0000ED
    IL_00B9: stfld 0x04000268
    IL_00BA: ldarg.0
    IL_00BF: ldsfld 0x040007B2
    IL_00C0: ldarg.0
    IL_00C5: ldfld 0x0400026A
    IL_00CA: ldc.i4 374
    IL_00CF: call 0x0A0000E1
    IL_00D4: stfld 0x04000269
    IL_00D9: br IL_0129
    IL_00DA: ldarg.0
    IL_00DF: ldsfld 0x040007B2
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x0400026A
    IL_00E7: ldc.i4.s 72
    IL_00EC: call 0x0A0000E1
    IL_00F1: ldstr 0x70000C1D
    IL_00F6: ldsfld 0x040007B2
    IL_00F7: ldarg.0
    IL_00FC: ldfld 0x0400026A
    IL_0101: ldc.i4 361
    IL_0106: call 0x0A0000E1
    IL_010B: call 0x0A0000ED
    IL_0110: stfld 0x04000268
    IL_0111: ldarg.0
    IL_0116: ldsfld 0x040007B2
    IL_0117: ldarg.0
    IL_011C: ldfld 0x0400026A
    IL_011E: ldc.i4.s 50
    IL_0123: call 0x0A0000E1
    IL_0128: stfld 0x04000269
    IL_012D: br IL_015D
    IL_012E: ldarg.0
    IL_0133: ldfld 0x04000261
    IL_0134: ldc.i4.0
    IL_0135: conv.r8
    IL_013A: brtrue IL_6F0A013B
    IL_013F: ldtoken 0x220A0000
    IL_0140: nop
    IL_0141: nop
    IL_0146: cpobj 0x00002242
    IL_0147: IL_C0
    IL_0148: IL_3F
    IL_0149: IL_22
    IL_014A: stloc.0
    IL_014B: IL_D7
    IL_014C: IL_23
    IL_014D: IL_3C
    IL_014E: IL_22
    IL_014F: nop
    IL_0150: nop
    IL_0151: ldelem.r8
    IL_36DF6: switch (56104 cases)
    }

    public void ShowOff() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000264
    IL_000B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000263
    IL_000B: call 0x0A000024
    IL_000C: IL_22
    IL_000D: stloc.0
    IL_000E: IL_D7
    IL_000F: IL_23
    IL_0010: IL_3D
    IL_0011: IL_5A
    IL_0012: IL_58
    IL_0017: stfld 0x04000263
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000261
    IL_001E: dup
    IL_001F: conv.r8
    IL_0020: ldc.i4.2
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0028: call 0x0A000007
    IL_002D: call 0x0A000024
    IL_0032: call 0x0A000008
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000263
    IL_003D: call 0x0A000008
    IL_0042: call 0x0A000029
    IL_0043: conv.r8
    IL_0044: ldloc.3
    IL_0045: nop
    IL_0046: nop
    IL_0047: stloc.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000261
    IL_004E: conv.r8
    IL_004F: ldc.i4.2
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: stloc.0
    IL_0055: ldloca.s 0
    IL_005A: ldfld 0x0A000023
    IL_005B: IL_22
    IL_005C: nop
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_3F
    IL_0060: IL_43
    IL_0062: br.s IL_0063
    IL_0063: nop
    IL_0064: nop
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000262
    IL_006F: brtrue IL_0090
    IL_0074: ldstr 0x70000C2B
    IL_0079: call 0x0A000077
    IL_007A: conv.r8
    IL_007B: IL_22
    IL_007C: nop
    IL_007D: nop
    IL_007F: br.s IL_00A2
    IL_0080: nop
    IL_0081: nop
    IL_0082: nop
    IL_151A43: switch (345711 cases)
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
    IL_003B: ldfld 0x04000267
    IL_0040: call 0x0A0000DF
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000266
    IL_004B: brfalse IL_0163
    IL_004D: ldc.i4.s -5
    IL_0052: call 0x0A0000EF
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_005A: stsfld 0x0000223F
    IL_005F: stsfld 0x0000223F
    IL_0064: stsfld 0x647B023F
    IL_0065: ldarg.0
    IL_0066: nop
    IL_0067: ldarg.2
    IL_006C: newobj 0x0A0000C4
    IL_0071: call 0x0A0000F0
    IL_0072: IL_22
    IL_0073: nop
    IL_0074: nop
    IL_0079: stsfld 0x000022C2
    IL_007A: nop
    IL_007B: nop
    IL_007C: IL_22
    IL_007D: nop
    IL_007E: nop
    IL_007F: ldelem.r8
    IL_0080: IL_43
    IL_0081: IL_22
    IL_0082: nop
    IL_0083: nop
    IL_0084: ldelem.r8
    IL_0085: IL_43
    IL_008A: call 0x0600021D
    IL_008B: ldarg.0
    IL_0090: ldfld 0x0400025F
    IL_0095: call 0x0A0000E0
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000261
    IL_009C: conv.r8
    IL_009D: ldc.i4.2
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: stloc.0
    IL_00A3: ldloca.s 0
    IL_00A8: ldfld 0x0A000023
    IL_00A9: IL_22
    IL_00AA: ldelem.i
    IL_00AB: IL_99
    IL_00AC: IL_99
    IL_00AD: IL_3E
    IL_00AE: IL_43
    IL_00AF: stloc.2
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: ldarg.0
    IL_00B4: ldc.i4.0
    IL_00B9: stfld 0x04000265
    IL_00BE: br IL_0163
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x04000261
    IL_00C5: conv.r8
    IL_00C6: ldc.i4.2
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: stloc.0
    IL_00CA: stloc.1
    IL_00CC: ldloca.s 1
    IL_00D1: ldfld 0x0A000023
    IL_00D2: IL_22
    IL_00D3: shr
    IL_00D4: shr
    IL_00D5: shr
    IL_00D6: IL_BF
    IL_00D7: IL_43
    IL_00D8: IL_87
    IL_00D9: nop
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: ldarg.0
    IL_00DD: ldc.i4.1
    IL_00E2: stfld 0x04000265
    IL_00E3: IL_22
    IL_00E4: nop
    IL_00E5: nop
    IL_00E6: nop
    IL_00E7: nop
    IL_00E8: IL_22
    IL_00E9: nop
    IL_00EA: nop
    IL_00EF: newobj 0x00002243
    IL_00F0: IL_F0
    IL_00F1: IL_43
    IL_00F2: IL_22
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: ldelem.r8
    IL_00F6: IL_41
    IL_00FB: call 0x0600021D
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x04000268
    IL_0106: ldstr 0x70000BC5
    IL_010B: call 0x0A0000E2
    IL_0110: call 0x0A0000E3
    IL_0111: IL_22
    IL_0112: nop
    IL_0113: nop
    IL_0114: ldc.i4.0
    IL_0115: IL_43
    IL_0116: IL_22
    IL_0117: nop
    IL_0118: nop
    IL_011D: ldc.i4 8770
    IL_0122: stsfld 0x00002243
    IL_0127: stsfld 0x021D2842
    IL_0128: nop
    IL_0129: ldloc.0
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000260
    IL_0134: call 0x0A0000E0
    IL_0135: IL_22
    IL_0136: nop
    IL_0137: nop
    IL_0138: ldc.i4.8
    IL_0139: IL_43
    IL_013A: IL_22
    IL_013B: nop
    IL_013C: nop
    IL_0141: cpobj 0x00002242
    IL_0146: cpobj 0x00002243
    IL_0147: ldelem.r8
    IL_0148: IL_41
    IL_014D: call 0x0600021D
    IL_014E: ldarg.0
    IL_0153: ldfld 0x04000269
    IL_0158: ldstr 0x70000C43
    IL_015D: call 0x0A0000E2
    IL_0162: call 0x0A0000E3
    IL_0163: ret
    }

    }}
