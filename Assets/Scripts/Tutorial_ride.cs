// Namespace: 
// Type: Tutorial_ride

    public class Tutorial_ride {{

    private object guide_img;
    public object pop_blank;
    private object guide_curent_subindex;
    private object language;
    public object basicSkin;
    public object bt_yesno;

    public Tutorial_ride() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700231CD
    IL_0006: ldarg.0
    IL_000B: ldflda 0x04000A68
    IL_0010: call 0x0A000010
    IL_0015: call 0x0A000011
    IL_001A: call 0x0A000012
    IL_001B: conv.u8
    IL_001C: IL_3C
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_01
    IL_0024: stfld 0x04000A66
    IL_0025: ldarg.0
    IL_002A: ldstr 0x70000BB3
    IL_002F: call 0x0A000095
    IL_0034: stfld 0x04000A69
    IL_0035: ret
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
    IL_003B: ldfld 0x04000A6A
    IL_0040: call 0x0A0000DF
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_E0
    IL_0045: IL_42
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: IL_C0
    IL_004A: IL_42
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_0052: stsfld 0x00002243
    IL_0053: nop
    IL_0054: IL_43
    IL_0059: call 0x0600021D
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000A67
    IL_0064: call 0x0A0000E0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000A68
    IL_006F: newobj 0x0100000B
    IL_0074: call 0x0A00013D
    IL_0075: IL_22
    IL_0076: nop
    IL_0077: nop
    IL_0078: IL_F8
    IL_0079: IL_42
    IL_007A: IL_22
    IL_007B: nop
    IL_007C: nop
    IL_007D: IL_CC
    IL_007E: IL_42
    IL_007F: IL_22
    IL_0080: nop
    IL_0081: nop
    IL_0082: neg
    IL_0083: IL_43
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_0088: starg.s 66
    IL_008D: call 0x0600021D
    IL_0092: ldsfld 0x0A000099
    IL_0097: ldsfld 0x040007B2
    IL_0098: ldarg.0
    IL_009D: ldfld 0x04000A69
    IL_00A2: ldc.i4 389
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04000A68
    IL_00A9: IL_58
    IL_00AE: call 0x0A0000E1
    IL_00B3: call 0x0A000011
    IL_00B8: ldstr 0x70000C43
    IL_00BD: call 0x0A0000E2
    IL_00C2: call 0x0A0000E3
    IL_00C3: IL_22
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: IL_F8
    IL_00C7: IL_42
    IL_00C8: IL_22
    IL_00C9: nop
    IL_00CA: nop
    IL_00CD: ldloc 8771
    IL_00CE: nop
    IL_00CF: nop
    IL_00D0: neg
    IL_00D1: IL_43
    IL_00D2: IL_22
    IL_00D3: nop
    IL_00D4: nop
    IL_00D5: rem
    IL_00D6: IL_41
    IL_00DB: call 0x0600021D
    IL_00E0: ldsfld 0x0A000099
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x04000A68
    IL_00E7: ldc.i4.1
    IL_00E8: IL_58
    IL_00ED: newobj 0x0100000B
    IL_00F2: ldstr 0x700231DB
    IL_00F7: call 0x0A000098
    IL_00FC: ldstr 0x70000C43
    IL_0101: call 0x0A0000E2
    IL_0106: call 0x0A0000E3
    IL_0107: IL_22
    IL_0108: nop
    IL_0109: nop
    IL_010A: ret
    IL_010B: IL_43
    IL_010C: IL_22
    IL_010D: nop
    IL_010E: nop
    IL_010F: ldloc.0
    IL_0110: IL_43
    IL_0111: IL_22
    IL_0112: nop
    IL_0113: nop
    IL_0114: nop
    IL_0115: IL_43
    IL_0116: IL_22
    IL_0117: nop
    IL_0118: nop
    IL_011D: stsfld 0x021D2842
    IL_011E: nop
    IL_011F: ldloc.0
    IL_0120: ldarg.0
    IL_0125: ldfld 0x04000A66
    IL_012A: call 0x0A0000E0
    IL_012B: ldarg.0
    IL_0130: ldfld 0x04000A68
    IL_0131: ldc.i4.1
    IL_0132: IL_3F
    IL_0137: ldsflda 0x7E000000
    IL_0138: IL_B2
    IL_0139: ldloc.1
    IL_013A: nop
    IL_013B: ldarg.2
    IL_013C: ldarg.0
    IL_0141: ldfld 0x04000A69
    IL_0142: ldc.i4.4
    IL_0147: call 0x0A0000E1
    IL_014C: call 0x0A00013D
    IL_014D: IL_22
    IL_014E: nop
    IL_014F: nop
    IL_0150: IL_91
    IL_0151: IL_43
    IL_0152: IL_22
    IL_0153: nop
    IL_0154: nop
    IL_0159: br IL_239D
    IL_015E: stsfld 0x00002242
    IL_015F: nop
    IL_0160: IL_42
    IL_0165: call 0x0600021D
    IL_016A: ldsfld 0x040007B2
    IL_016B: ldarg.0
    IL_0170: ldfld 0x04000A69
    IL_0171: ldc.i4.4
    IL_0176: call 0x0A0000E1
    IL_0177: ldarg.0
    IL_017C: ldfld 0x04000A6B
    IL_0181: call 0x0A0000F1
    IL_0186: brfalse IL_01B1
    IL_0187: IL_22
    IL_0188: nop
    IL_0189: nop
    IL_018E: stsfld 0x0111283F
    IL_018F: nop
    IL_0190: stloc.0
    IL_0191: ldarg.0
    IL_0196: call 0x0A00000A
    IL_0197: ldc.i4.0
    IL_0198: conv.r8
    IL_0199: stloc.1
    IL_019A: nop
    IL_019B: nop
    IL_019C: stloc.0
    IL_01A1: ldstr 0x70000231
    IL_01A6: call 0x0A000004
    IL_01A7: conv.r8
    IL_01A8: IL_C8
    IL_01A9: IL_01
    IL_01AA: nop
    IL_01AB: stloc.0
    IL_01AC: conv.r8
    IL_01AD: IL_4D
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: stloc.0
    IL_01B5: br IL_023B
    IL_01BA: ldsfld 0x040007B2
    IL_01BB: ldarg.0
    IL_01C0: ldfld 0x04000A69
    IL_01C2: ldc.i4.s 47
    IL_01C7: call 0x0A0000E1
    IL_01CC: call 0x0A00013D
    IL_01CD: IL_22
    IL_01CE: nop
    IL_01CF: nop
    IL_01D0: IL_91
    IL_01D1: IL_43
    IL_01D2: IL_22
    IL_01D3: nop
    IL_01D4: nop
    IL_01D9: br IL_241D
    IL_01DE: stsfld 0x00002242
    IL_01DF: nop
    IL_01E0: IL_42
    IL_01E5: call 0x0600021D
    IL_01EA: ldsfld 0x040007B2
    IL_01EB: ldarg.0
    IL_01F0: ldfld 0x04000A69
    IL_01F2: ldc.i4.s 47
    IL_01F7: call 0x0A0000E1
    IL_01F8: ldarg.0
    IL_01FD: ldfld 0x04000A6B
    IL_0202: call 0x0A0000F1
    IL_0207: brfalse IL_023B
    IL_0208: ldarg.0
    IL_0209: dup
    IL_020E: ldfld 0x04000A68
    IL_020F: ldc.i4.1
    IL_0210: IL_58
    IL_0215: stfld 0x04000A68
    IL_0216: ldarg.0
    IL_021B: ldstr 0x700231CD
    IL_021C: ldarg.0
    IL_0221: ldflda 0x04000A68
    IL_0226: call 0x0A000010
    IL_022B: call 0x0A000011
    IL_0230: call 0x0A000012
    IL_0231: conv.u8
    IL_0232: IL_3C
    IL_0233: nop
    IL_0234: nop
    IL_0235: IL_01
    IL_023A: stfld 0x04000A66
    IL_023B: ret
    }

    }}
