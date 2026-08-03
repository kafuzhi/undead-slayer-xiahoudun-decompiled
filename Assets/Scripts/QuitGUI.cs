// Namespace: 
// Type: QuitGUI

    public class QuitGUI {{

    public object pop_blank;
    public object bg_black;
    public object bt_yesno;
    public object basicSkin;
    private object language;
    private object timescale;
    private object ui;
    private object ui2;

    public QuitGUI() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x0400087C
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000F: stsfld 0x087D7D3F
    IL_0010: nop
    IL_0011: ldarg.2
    IL_0012: ldarg.0
    IL_0017: call 0x0A000001
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70022A06
    IL_000A: call 0x0A000077
    IL_000F: stfld 0x0400087E
    IL_0010: ldarg.0
    IL_0015: ldfld 0x0400087E
    IL_0016: ldnull
    IL_001B: call 0x0A000061
    IL_0020: brfalse IL_0031
    IL_0021: ldarg.0
    IL_0026: ldstr 0x70000BD5
    IL_002B: call 0x0A000004
    IL_0030: stfld 0x0400087E
    IL_0031: ldarg.0
    IL_0036: ldfld 0x0400087E
    IL_0037: ldnull
    IL_003C: call 0x0A000021
    IL_0041: brfalse IL_004E
    IL_0042: ldarg.0
    IL_0047: ldfld 0x0400087E
    IL_0048: ldc.i4.0
    IL_0049: conv.r8
    IL_004A: stloc.1
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: ldstr 0x70022A18
    IL_0058: call 0x0A000004
    IL_005D: stfld 0x0400087F
    IL_005E: ldarg.0
    IL_0063: ldfld 0x0400087F
    IL_0064: ldnull
    IL_0069: call 0x0A000021
    IL_006E: brfalse IL_007B
    IL_006F: ldarg.0
    IL_0074: ldfld 0x0400087F
    IL_0075: ldc.i4.0
    IL_0076: conv.r8
    IL_0077: stloc.1
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldarg.0
    IL_0080: call 0x0A000093
    IL_0085: stfld 0x0400087D
    IL_0086: IL_22
    IL_0087: nop
    IL_0088: nop
    IL_0089: nop
    IL_008A: nop
    IL_008F: call 0x0A000111
    IL_0090: ldarg.0
    IL_0095: ldstr 0x70000BB3
    IL_009A: call 0x0A000095
    IL_009F: stfld 0x0400087C
    IL_00A0: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400087B
    IL_000A: call 0x0A0000DF
    IL_000C: ldc.i4.s -100
    IL_0011: call 0x0A0000EF
    IL_0016: call 0x0A0000D9
    IL_0017: conv.i2
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001F: cpobj 0xDA285B44
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: conv.i2
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_002B: ldc.i4 2251588
    IL_002C: nop
    IL_0031: stsfld 0x0076733F
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: call 0x0A0000F8
    IL_003D: call 0x0A0000DE
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_F0
    IL_004C: IL_43
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldelem.r8
    IL_0051: IL_43
    IL_0056: call 0x0600021D
    IL_0057: ldarg.0
    IL_005C: ldfld 0x04000879
    IL_0061: call 0x0A0000E0
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0065: IL_E0
    IL_0066: IL_42
    IL_0067: IL_22
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_DC
    IL_006B: IL_42
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_0073: stsfld 0x00002243
    IL_0078: stsfld 0x021D2842
    IL_0079: nop
    IL_007A: ldloc.0
    IL_007B: ldarg.0
    IL_0080: ldfld 0x04000878
    IL_0085: call 0x0A0000E0
    IL_0086: IL_22
    IL_0087: nop
    IL_0088: nop
    IL_0089: IL_E0
    IL_008A: IL_42
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_F0
    IL_008F: IL_42
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0097: stsfld 0x00002243
    IL_0098: rem
    IL_0099: IL_41
    IL_009E: call 0x0600021D
    IL_00A3: ldsfld 0x040007B2
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x0400087C
    IL_00AE: ldc.i4 260
    IL_00B3: call 0x0A0000E1
    IL_00B8: ldstr 0x70000C43
    IL_00BD: call 0x0A0000E2
    IL_00C2: call 0x0A0000E3
    IL_00C3: IL_22
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: ret
    IL_00C7: IL_43
    IL_00C8: IL_22
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: stloc.0
    IL_00CC: IL_43
    IL_00CD: IL_22
    IL_00CE: nop
    IL_00CF: nop
    IL_00D4: stsfld 0x00002242
    IL_00D5: nop
    IL_00D6: IL_42
    IL_00DB: call 0x0600021D
    IL_00E0: ldsfld 0x040007B2
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x0400087C
    IL_00E7: ldc.i4.1
    IL_00EC: call 0x0A0000E1
    IL_00ED: ldarg.0
    IL_00F2: ldfld 0x0400087A
    IL_00F7: call 0x0A0000F1
    IL_00FC: brfalse IL_0111
    IL_00FD: IL_22
    IL_00FE: nop
    IL_00FF: nop
    IL_0100: nop
    IL_0101: nop
    IL_0106: call 0x0A000111
    IL_010B: call 0x0A0001EF
    IL_0110: br IL_019B
    IL_0111: IL_22
    IL_0112: nop
    IL_0113: nop
    IL_0118: cpobj 0x00002243
    IL_0119: stloc.0
    IL_011A: IL_43
    IL_011B: IL_22
    IL_011C: nop
    IL_011D: nop
    IL_0122: stsfld 0x00002242
    IL_0123: nop
    IL_0124: IL_42
    IL_0129: call 0x0600021D
    IL_012E: ldsfld 0x040007B2
    IL_012F: ldarg.0
    IL_0134: ldfld 0x0400087C
    IL_0135: ldc.i4.2
    IL_013A: call 0x0A0000E1
    IL_013B: ldarg.0
    IL_0140: ldfld 0x0400087A
    IL_0145: call 0x0A0000F1
    IL_014A: brfalse IL_019B
    IL_014B: ldarg.0
    IL_0150: ldfld 0x0400087D
    IL_0155: call 0x0A000111
    IL_0156: ldarg.0
    IL_015B: ldfld 0x0400087E
    IL_015C: ldnull
    IL_0161: call 0x0A000021
    IL_0166: brfalse IL_0173
    IL_0167: ldarg.0
    IL_016C: ldfld 0x0400087E
    IL_016D: ldc.i4.1
    IL_016E: conv.r8
    IL_016F: stloc.1
    IL_0170: nop
    IL_0171: nop
    IL_0172: stloc.0
    IL_0173: ldarg.0
    IL_0178: ldfld 0x0400087F
    IL_0179: ldnull
    IL_017E: call 0x0A000021
    IL_0183: brfalse IL_0190
    IL_0184: ldarg.0
    IL_0189: ldfld 0x0400087F
    IL_018A: ldc.i4.1
    IL_018B: conv.r8
    IL_018C: stloc.1
    IL_018D: nop
    IL_018E: nop
    IL_018F: stloc.0
    IL_0190: ldarg.0
    IL_0195: call 0x0A00000A
    IL_019A: call 0x0A000050
    IL_019B: ret
    }

    }}
