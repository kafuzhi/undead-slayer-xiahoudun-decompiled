// Namespace: 
// Type: CamScroll_Extreme

    public class CamScroll_Extreme {{

    private object cover;
    private object below;
    private object stopmove;
    private object scrollOn;
    private object isevent;
    public object drag;
    private object movedelay;
    private object tempx;
    private object prevMposX;
    private object currentCampos;
    private object mytransform;
    private object current_camsize;
    private object camsize;
    private object camsizechange;
    private object movecamspeed;

    public CamScroll_Extreme() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x022C7D3F
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: nop
    IL_000E: nop
    IL_0013: stsfld 0x022D7D3F
    IL_0014: nop
    IL_0015: ldarg.2
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_E0
    IL_8BE13: switch (143229 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400022B
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000D0
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: IL_C0
    IL_000A: IL_BF
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_C0
    IL_000F: IL_3F
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: stsfld 0x000022BF
    IL_001C: stsfld 0x999A223F
    IL_001D: IL_99
    IL_001E: IL_3E
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldelem.r8
    IL_344C7: switch (53544 cases)
    }

    public void SetCover() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000221
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_000D: stfld 0x04000222
    IL_000E: ldarg.0
    IL_000F: ldarg.3
    IL_0014: stfld 0x04000228
    IL_0015: ldarg.0
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000228
    IL_001C: IL_22
    IL_001D: shr
    IL_001E: shr
    IL_001F: pop
    IL_0020: IL_C1
    IL_0021: IL_22
    IL_0022: shr
    IL_0023: shr
    IL_0024: pop
    IL_0025: IL_41
    IL_002A: call 0x0A0000D4
    IL_002F: stfld 0x04000228
    IL_0031: ldarg.s 4
    IL_0036: brfalse IL_00B6
    IL_0037: ldarg.0
    IL_003C: ldfld 0x0400022B
    IL_003D: IL_22
    IL_003E: shr
    IL_003F: shr
    IL_0040: pop
    IL_0041: IL_41
    IL_0042: IL_22
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004E: stsfld 0x0076733F
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: conv.r8
    IL_0052: ldloc.3
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04000221
    IL_005C: conv.r8
    IL_005D: ldarg.0
    IL_005E: nop
    IL_005F: nop
    IL_0060: stloc.0
    IL_0061: IL_22
    IL_0062: shr
    IL_0063: shr
    IL_0064: pop
    IL_0065: IL_C1
    IL_0066: IL_22
    IL_0067: ldelem.i
    IL_0068: IL_99
    IL_0069: ldc.i4.3
    IL_006A: IL_BE
    IL_006B: IL_22
    IL_006C: nop
    IL_006D: nop
    IL_006E: nop
    IL_006F: IL_BF
    IL_0074: newobj 0x0A000076
    IL_0075: conv.r8
    IL_0076: ldloc.3
    IL_0077: nop
    IL_0078: nop
    IL_0079: stloc.0
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000222
    IL_0080: conv.r8
    IL_0081: ldarg.0
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0085: IL_22
    IL_0086: stloc.2
    IL_0087: ldarg.0
    IL_0088: IL_CB
    IL_66666915: switch (429496866 cases)
    }

    public void DisableMove() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000223
    IL_0007: ret
    }

    public void EnableMove() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000223
    IL_0007: ret
    }

    public void MoveTargetCancel() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000227
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x04000225
    IL_0012: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000227
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_43
    IL_000C: IL_D9
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x04000227
    IL_001B: call 0x0A000024
    IL_001C: IL_59
    IL_0021: stfld 0x04000227
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400022B
    IL_0028: conv.r8
    IL_0029: ldc.i4.2
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: stloc.1
    IL_002F: ldloca.s 1
    IL_0034: ldfld 0x0A00005E
    IL_0035: stloc.0
    IL_0036: ldloc.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000228
    IL_0041: call 0x0A000024
    IL_0042: ldarg.0
    IL_0047: ldfld 0x0400022F
    IL_0048: IL_5A
    IL_004D: call 0x0A000025
    IL_004E: stloc.0
    IL_004F: ldarg.0
    IL_0054: ldfld 0x0400022B
    IL_0055: ldloc.0
    IL_0056: IL_22
    IL_0057: nop
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: IL_22
    IL_005C: nop
    IL_005D: nop
    IL_0062: stsfld 0x0076733F
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: conv.r8
    IL_0066: ldloc.3
    IL_0067: nop
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: ldarg.0
    IL_006F: ldfld 0x04000221
    IL_0070: conv.r8
    IL_0071: ldarg.0
    IL_0072: nop
    IL_0073: nop
    IL_0074: stloc.0
    IL_0075: ldloc.0
    IL_0076: shl
    IL_0077: IL_22
    IL_0078: ldelem.i
    IL_0079: IL_99
    IL_007A: ldc.i4.3
    IL_007B: IL_BE
    IL_007C: IL_22
    IL_007D: nop
    IL_007E: nop
    IL_007F: nop
    IL_0080: IL_BF
    IL_0085: newobj 0x0A000076
    IL_0086: conv.r8
    IL_0087: ldloc.3
    IL_0088: nop
    IL_0089: nop
    IL_008A: stloc.0
    IL_008B: ldarg.0
    IL_0090: ldfld 0x04000222
    IL_0091: conv.r8
    IL_0092: ldarg.0
    IL_0093: nop
    IL_0094: nop
    IL_0095: stloc.0
    IL_0096: ldloc.0
    IL_0097: IL_22
    IL_0098: IL_F6
    IL_009D: call 0x225A3F1C
    IL_009E: ldelem.i
    IL_009F: IL_99
    IL_00A0: ldc.i4.3
    IL_00A1: IL_BE
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: IL_C0
    IL_00A6: IL_BF
    IL_00AB: newobj 0x0A000076
    IL_00AC: conv.r8
    IL_00AD: ldloc.3
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: stloc.0
    IL_00B1: ldarg.0
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x0400022B
    IL_00B8: conv.r8
    IL_00B9: ldc.i4.2
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: stloc.0
    IL_00C1: stfld 0x0400022A
    IL_00C2: ldarg.0
    IL_00C3: ldc.i4.0
    IL_00C8: stfld 0x04000224
    IL_00C9: ldarg.0
    IL_00CE: ldfld 0x04000225
    IL_00D3: brfalse IL_00E4
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000227
    IL_00DA: IL_22
    IL_00DB: nop
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: IL_42
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: nop
    IL_00E3: nop
    IL_00E8: br IL_0149
    IL_00E9: ldarg.0
    IL_00EE: ldfld 0x04000223
    IL_00F3: brfalse IL_00F5
    IL_00F4: ret
    IL_00F5: ldc.i4.0
    IL_00FA: call 0x0A0000D6
    IL_00FF: brfalse IL_0137
    IL_0100: ldarg.0
    IL_0101: ldc.i4.0
    IL_0106: stfld 0x04000226
    IL_0107: ldarg.0
    IL_0108: ldc.i4.1
    IL_010D: stfld 0x04000224
    IL_010E: ldarg.0
    IL_0113: call 0x0A0000D7
    IL_0114: stloc.2
    IL_0116: ldloca.s 2
    IL_011B: ldfld 0x0A00005E
    IL_0120: stfld 0x04000229
    IL_0121: ldarg.0
    IL_0122: ldarg.0
    IL_0127: ldfld 0x0400022B
    IL_0128: conv.r8
    IL_0129: ldc.i4.2
    IL_012A: nop
    IL_012B: nop
    IL_012C: stloc.0
    IL_0131: stfld 0x0400022A
    IL_0136: br IL_0149
    IL_0137: ldc.i4.0
    IL_013C: call 0x0A0000D8
    IL_0141: brfalse IL_0149
    IL_0142: ldarg.0
    IL_0143: ldc.i4.0
    IL_0148: stfld 0x04000224
    IL_0149: ldarg.0
    IL_014E: ldfld 0x04000224
    IL_0153: brfalse IL_0241
    IL_0154: ldarg.0
    IL_0155: IL_22
    IL_015A: isinst 0x283BC49B
    IL_015B: IL_D7
    IL_015C: nop
    IL_015D: nop
    IL_015E: stloc.0
    IL_015F: stloc.3
    IL_0161: ldloca.s 3
    IL_0166: ldfld 0x0A00005E
    IL_0167: ldarg.0
    IL_016C: ldfld 0x04000229
    IL_016D: IL_59
    IL_016E: IL_5A
    IL_016F: IL_22
    IL_0170: nop
    IL_0171: nop
    IL_0172: IL_F0
    IL_0173: IL_43
    IL_0178: call 0x0A0000D9
    IL_0179: conv.i2
    IL_017A: add
    IL_017B: IL_5A
    IL_0180: stfld 0x04000228
    IL_0181: ldarg.0
    IL_0186: ldfld 0x04000228
    IL_018B: call 0x0A00007F
    IL_018C: IL_22
    IL_018D: IL_8F
    IL_018E: IL_C2
    IL_018F: conv.u8
    IL_0190: IL_3D
    IL_0191: IL_43
    IL_0192: ldloc.1
    IL_0193: nop
    IL_0194: nop
    IL_0195: nop
    IL_0196: ldarg.0
    IL_0197: ldc.i4.1
    IL_019C: stfld 0x04000226
    IL_019D: ldarg.0
    IL_019E: dup
    IL_01A3: ldfld 0x04000228
    IL_01A4: ldarg.0
    IL_01A9: ldflda 0x0400022A
    IL_01AE: ldfld 0x0A00005E
    IL_01AF: IL_58
    IL_01B4: stfld 0x04000228
    IL_01B5: ldarg.0
    IL_01B6: ldarg.0
    IL_01BB: ldfld 0x04000228
    IL_01BC: IL_22
    IL_01BD: shr
    IL_01BE: shr
    IL_01BF: pop
    IL_01C0: IL_C1
    IL_01C1: IL_22
    IL_01C2: shr
    IL_01C3: shr
    IL_01C4: pop
    IL_01C5: IL_41
    IL_01CA: call 0x0A0000D4
    IL_01CF: stfld 0x04000228
    IL_01D0: ldarg.0
    IL_01D5: ldfld 0x0400022B
    IL_01D6: ldarg.0
    IL_01DB: ldfld 0x04000228
    IL_01DC: IL_22
    IL_01DD: nop
    IL_01DE: nop
    IL_01DF: nop
    IL_01E0: nop
    IL_01E1: IL_22
    IL_01E2: nop
    IL_01E3: nop
    IL_01E8: stsfld 0x0076733F
    IL_01E9: nop
    IL_01EA: stloc.0
    IL_01EB: conv.r8
    IL_01EC: ldloc.3
    IL_01ED: nop
    IL_01EE: nop
    IL_01EF: stloc.0
    IL_01F0: ldarg.0
    IL_01F5: ldfld 0x04000221
    IL_01F6: conv.r8
    IL_01F7: ldarg.0
    IL_01F8: nop
    IL_01F9: nop
    IL_01FA: stloc.0
    IL_01FB: ldarg.0
    IL_0200: ldfld 0x04000228
    IL_0201: shl
    IL_0202: IL_22
    IL_0203: ldelem.i
    IL_0204: IL_99
    IL_0205: ldc.i4.3
    IL_0206: IL_BE
    IL_0207: IL_22
    IL_0208: nop
    IL_0209: nop
    IL_020A: nop
    IL_020B: IL_BF
    IL_0210: newobj 0x0A000076
    IL_0211: conv.r8
    IL_0212: ldloc.3
    IL_0213: nop
    IL_0214: nop
    IL_0215: stloc.0
    IL_0216: ldarg.0
    IL_021B: ldfld 0x04000222
    IL_021C: conv.r8
    IL_021D: ldarg.0
    IL_021E: nop
    IL_021F: nop
    IL_0220: stloc.0
    IL_0221: ldarg.0
    IL_0226: ldfld 0x04000228
    IL_0227: IL_22
    IL_0228: IL_F6
    IL_022D: call 0x225A3F1C
    IL_022E: ldelem.i
    IL_022F: IL_99
    IL_0230: ldc.i4.3
    IL_0231: IL_BE
    IL_0232: IL_22
    IL_0233: nop
    IL_0234: nop
    IL_0235: IL_C0
    IL_0236: IL_BF
    IL_023B: newobj 0x0A000076
    IL_023C: conv.r8
    IL_023D: ldloc.3
    IL_023E: nop
    IL_023F: nop
    IL_0240: stloc.0
    IL_0241: ldarg.0
    IL_0246: ldfld 0x0400022E
    IL_024B: brfalse IL_02C5
    IL_024C: ldarg.0
    IL_0251: ldfld 0x0400022C
    IL_0252: ldarg.0
    IL_0257: ldfld 0x0400022D
    IL_0278: switch (7 cases)
    IL_300A16B7D: switch (3223870016 cases)
    }

    }}
