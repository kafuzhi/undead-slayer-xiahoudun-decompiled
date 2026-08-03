// Namespace: 
// Type: CamScroll

    public class CamScroll {{

    private object stopmove;
    private object scrollOn;
    private object isevent;
    public object drag;
    private object movedelay;
    private object tempx;
    private object tempy;
    private object prevMposX;
    private object prevMposY;
    private object currentCampos;
    private object targetpos;
    private object mytransform;
    private object target;
    private object current_camsize;
    private object camsize;
    private object camsizechange;
    private object movecamspeed;

    public CamScroll() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x021D7D3F
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: nop
    IL_000E: nop
    IL_0013: stsfld 0x021E7D3F
    IL_0014: nop
    IL_0015: ldarg.2
    IL_0016: ldarg.0
    IL_0017: ldc.i4.7
    IL_001C: stfld 0x04000220
    IL_001D: ldarg.0
    IL_0022: call 0x0A000001
    IL_0023: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400021B
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000D0
    IL_0006: IL_22
    IL_0007: shr
    IL_0008: shr
    IL_0009: IL_E6
    IL_000A: IL_BF
    IL_000B: IL_22
    IL_000C: shr
    IL_000D: shr
    IL_000E: IL_E6
    IL_000F: IL_3F
    IL_0010: IL_22
    IL_0011: ldelem.i
    IL_0012: IL_99
    IL_0013: IL_99
    IL_0014: IL_BF
    IL_0015: IL_22
    IL_0016: ldelem.i
    IL_0017: IL_99
    IL_0018: IL_99
    IL_0019: IL_3F
    IL_001A: IL_22
    IL_001B: ldelem.i
    IL_001C: IL_99
    IL_001D: IL_99
    IL_001E: IL_3E
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldelem.r8
    IL_344C7: switch (53544 cases)
    }

    public void DisableMove() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000210
    IL_0007: ret
    }

    public void EnableMove() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000210
    IL_0007: ret
    }

    public void Zoom() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000213
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x0400021F
    IL_000E: ldarg.0
    IL_000F: ldc.i4.0
    IL_0014: stfld 0x04000212
    IL_0015: ldarg.1
    IL_001A: brfalse IL_005E
    IL_001B: ldarg.0
    IL_001C: ldc.i4.1
    IL_0021: stfld 0x04000210
    IL_0022: ldarg.0
    IL_0023: IL_22
    IL_0025: bne.un.s IL_0059
    IL_0027: stloc.s 64
    IL_002C: stfld 0x0400021E
    IL_002D: ldarg.0
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_22
    IL_0034: IL_CD
    IL_0035: IL_CC
    IL_0036: IL_4C
    IL_0037: IL_BD
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003F: stsfld 0x0076733F
    IL_0040: nop
    IL_0041: stloc.0
    IL_0046: stfld 0x0400021A
    IL_0047: ldarg.0
    IL_0048: IL_22
    IL_0049: ldelem.i
    IL_004A: IL_99
    IL_004B: ldc.i4.3
    IL_004C: IL_3F
    IL_0051: stfld 0x04000214
    IL_0052: ldarg.0
    IL_0053: ldc.i4.7
    IL_0058: stfld 0x04000220
    IL_005D: br IL_00E8
    IL_005E: ldarg.0
    IL_005F: ldc.i4.0
    IL_0064: stfld 0x04000210
    IL_0065: ldarg.0
    IL_0066: IL_22
    IL_0067: ldelem.i
    IL_0068: IL_99
    IL_0069: IL_99
    IL_006A: IL_3F
    IL_006F: stfld 0x0400021E
    IL_0070: ldarg.0
    IL_0071: ldarg.2
    IL_0076: stfld 0x0400021A
    IL_0077: ldarg.0
    IL_007C: ldflda 0x0400021A
    IL_007D: ldc.i4.0
    IL_007E: ldarg.0
    IL_0083: ldflda 0x0400021A
    IL_0084: ldc.i4.0
    IL_0089: call 0x0A0000D3
    IL_008A: IL_22
    IL_008B: ldelem.i
    IL_008C: IL_99
    IL_008D: IL_D9
    IL_008E: IL_BF
    IL_008F: IL_22
    IL_0090: ldelem.i
    IL_0091: IL_99
    IL_0092: IL_D9
    IL_0093: IL_3F
    IL_0098: call 0x0A0000D4
    IL_009D: call 0x0A00001A
    IL_009E: ldarg.0
    IL_00A3: ldflda 0x0400021A
    IL_00A4: ldc.i4.1
    IL_00A5: ldarg.0
    IL_00AA: ldflda 0x0400021A
    IL_00AB: ldc.i4.1
    IL_00B0: call 0x0A0000D3
    IL_00B1: IL_22
    IL_00B3: bne.un.s IL_00E7
    IL_00B5: stloc.s 192
    IL_00B6: IL_22
    IL_00B8: bne.un.s IL_00EC
    IL_00BA: stloc.s 64
    IL_00BF: call 0x0A0000D4
    IL_00C4: call 0x0A00001A
    IL_00C5: ldarg.0
    IL_00CA: ldflda 0x0400021A
    IL_00CB: ldc.i4.2
    IL_00CC: IL_22
    IL_00CD: nop
    IL_00CE: nop
    IL_00D3: stsfld 0x001A283F
    IL_00D4: nop
    IL_00D5: stloc.0
    IL_00D6: ldarg.0
    IL_00D7: IL_22
    IL_00D8: IL_CD
    IL_00D9: IL_CC
    IL_00DA: IL_4C
    IL_00DB: IL_3F
    IL_00E0: stfld 0x04000214
    IL_00E1: ldarg.0
    IL_00E2: ldc.i4.3
    IL_00E7: stfld 0x04000220
    IL_00E8: ret
    }

    public void MoveTarget() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x0400021C
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: conv.r8
    IL_000A: ldc.i4.2
    IL_000B: nop
    IL_000C: nop
    IL_000D: stloc.0
    IL_0012: stfld 0x0400021A
    IL_0013: ldarg.0
    IL_0018: ldflda 0x0400021A
    IL_0019: ldc.i4.0
    IL_001A: ldarg.0
    IL_001F: ldflda 0x0400021A
    IL_0020: ldc.i4.0
    IL_0025: call 0x0A0000D3
    IL_0026: IL_22
    IL_0027: ldelem.i
    IL_0028: IL_99
    IL_0029: IL_D9
    IL_002A: IL_BF
    IL_002B: IL_22
    IL_002C: ldelem.i
    IL_002D: IL_99
    IL_002E: IL_D9
    IL_002F: IL_3F
    IL_0034: call 0x0A0000D4
    IL_0039: call 0x0A00001A
    IL_003A: ldarg.0
    IL_003F: ldflda 0x0400021A
    IL_0040: ldc.i4.1
    IL_0041: ldarg.0
    IL_0046: ldflda 0x0400021A
    IL_0047: ldc.i4.1
    IL_004C: call 0x0A0000D3
    IL_004D: IL_22
    IL_004F: bne.un.s IL_0083
    IL_0051: stloc.s 192
    IL_0052: IL_22
    IL_0054: bne.un.s IL_0088
    IL_0056: stloc.s 64
    IL_005B: call 0x0A0000D4
    IL_0060: call 0x0A00001A
    IL_0061: ldarg.0
    IL_0066: ldflda 0x0400021A
    IL_0067: ldc.i4.2
    IL_0068: IL_22
    IL_0069: nop
    IL_006A: nop
    IL_006F: stsfld 0x001A283F
    IL_0070: nop
    IL_0071: stloc.0
    IL_0072: ldarg.0
    IL_0073: IL_22
    IL_0074: ldelem.i
    IL_0075: IL_99
    IL_0076: ldc.i4.3
    IL_0077: IL_3F
    IL_007C: stfld 0x04000214
    IL_007D: ldarg.0
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0082: nop
    IL_0087: stfld 0x04000215
    IL_0088: ldarg.0
    IL_0089: IL_22
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: nop
    IL_0092: stfld 0x04000216
    IL_0097: ldstr 0x70000B7F
    IL_0098: ldarg.0
    IL_009D: ldfld 0x0400021A
    IL_00A2: call 0x060003F3
    IL_00A3: pop
    IL_00A4: ldarg.0
    IL_00A5: ldarg.2
    IL_00AA: stfld 0x04000212
    IL_00AB: ldarg.0
    IL_00AC: ldc.i4.7
    IL_00B1: stfld 0x04000220
    IL_00B2: ret
    }

    public void MoveTargetCancel() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000214
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x04000212
    IL_0012: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000214
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_43
    IL_000C: IL_88
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x04000214
    IL_001B: call 0x0A000024
    IL_001C: IL_59
    IL_0021: stfld 0x04000214
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400021B
    IL_0028: ldarg.0
    IL_002D: ldfld 0x0400021B
    IL_002E: conv.r8
    IL_002F: ldc.i4.2
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400021A
    IL_003D: call 0x0A000024
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000220
    IL_0044: conv.i2
    IL_0045: IL_5A
    IL_004A: call 0x0A000063
    IL_004B: conv.r8
    IL_004C: ldloc.3
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x0400021B
    IL_0057: conv.r8
    IL_0058: ldc.i4.2
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_0060: stfld 0x04000219
    IL_0061: ldarg.0
    IL_0062: ldc.i4.0
    IL_0067: stfld 0x04000211
    IL_0068: ldarg.0
    IL_006D: ldfld 0x04000212
    IL_0072: brfalse IL_0093
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000214
    IL_0079: IL_22
    IL_007A: nop
    IL_007B: nop
    IL_007C: nop
    IL_007D: nop
    IL_007E: IL_42
    IL_0080: starg.s 0
    IL_0081: nop
    IL_0082: nop
    IL_0083: ldarg.0
    IL_0088: ldfld 0x0400021C
    IL_0089: conv.r8
    IL_008B: ldc.i4.s 0
    IL_008C: nop
    IL_008E: br.s IL_00FE
    IL_008F: IL_4E
    IL_0090: ldarg.1
    IL_0091: nop
    IL_0092: ldloc.0
    IL_0097: br IL_010B
    IL_0098: ldarg.0
    IL_009D: ldfld 0x04000210
    IL_00A2: brfalse IL_00A4
    IL_00A3: ret
    IL_00A4: ldc.i4.0
    IL_00A9: call 0x0A0000D6
    IL_00AE: brfalse IL_00F9
    IL_00AF: ldarg.0
    IL_00B0: ldc.i4.0
    IL_00B5: stfld 0x04000213
    IL_00B6: ldarg.0
    IL_00B7: ldc.i4.1
    IL_00BC: stfld 0x04000211
    IL_00BD: ldarg.0
    IL_00C2: call 0x0A0000D7
    IL_00C3: stloc.0
    IL_00C5: ldloca.s 0
    IL_00CA: ldfld 0x0A00005E
    IL_00CF: stfld 0x04000217
    IL_00D0: ldarg.0
    IL_00D5: call 0x0A0000D7
    IL_00D6: stloc.1
    IL_00D8: ldloca.s 1
    IL_00DD: ldfld 0x0A000023
    IL_00E2: stfld 0x04000218
    IL_00E3: ldarg.0
    IL_00E4: ldarg.0
    IL_00E9: ldfld 0x0400021B
    IL_00EA: conv.r8
    IL_00EB: ldc.i4.2
    IL_00EC: nop
    IL_00ED: nop
    IL_00EE: stloc.0
    IL_00F3: stfld 0x04000219
    IL_00F8: br IL_010B
    IL_00F9: ldc.i4.0
    IL_00FE: call 0x0A0000D8
    IL_0103: brfalse IL_010B
    IL_0104: ldarg.0
    IL_0105: ldc.i4.0
    IL_010A: stfld 0x04000211
    IL_010B: ldarg.0
    IL_0110: ldfld 0x04000211
    IL_0115: brfalse IL_0228
    IL_0116: ldarg.0
    IL_0117: IL_22
    IL_011C: isinst 0x283BC49B
    IL_011D: IL_D7
    IL_011E: nop
    IL_011F: nop
    IL_0120: stloc.0
    IL_0121: stloc.2
    IL_0123: ldloca.s 2
    IL_0128: ldfld 0x0A00005E
    IL_0129: ldarg.0
    IL_012E: ldfld 0x04000217
    IL_012F: IL_59
    IL_0130: IL_5A
    IL_0131: IL_22
    IL_0132: nop
    IL_0133: nop
    IL_0134: IL_F0
    IL_0135: IL_43
    IL_013A: call 0x0A0000D9
    IL_013B: conv.i2
    IL_013C: add
    IL_013D: IL_5A
    IL_0142: stfld 0x04000215
    IL_0143: ldarg.0
    IL_0144: IL_22
    IL_0149: isinst 0x28BBC49B
    IL_014A: IL_D7
    IL_014B: nop
    IL_014C: nop
    IL_014D: stloc.0
    IL_014E: stloc.3
    IL_0150: ldloca.s 3
    IL_0155: ldfld 0x0A000023
    IL_0156: ldarg.0
    IL_015B: ldfld 0x04000218
    IL_015C: IL_59
    IL_015D: IL_5A
    IL_015E: IL_22
    IL_015F: nop
    IL_0160: nop
    IL_0161: ldelem.r8
    IL_0162: IL_43
    IL_0167: call 0x0A0000DA
    IL_0168: conv.i2
    IL_0169: add
    IL_016A: IL_5A
    IL_016F: stfld 0x04000216
    IL_0170: ldarg.0
    IL_0175: ldfld 0x04000215
    IL_017A: call 0x0A00007F
    IL_017B: IL_22
    IL_017C: IL_8F
    IL_017D: IL_C2
    IL_017E: conv.u8
    IL_017F: IL_3D
    IL_0180: IL_3D
    IL_0181: ldc.i4.m1
    IL_0182: nop
    IL_0183: nop
    IL_0184: nop
    IL_0185: ldarg.0
    IL_018A: ldfld 0x04000216
    IL_018F: call 0x0A00007F
    IL_0190: IL_22
    IL_0191: IL_8F
    IL_0192: IL_C2
    IL_0193: conv.u8
    IL_0194: IL_3D
    IL_0195: IL_43
    IL_0196: ldloc.1
    IL_0197: nop
    IL_0198: nop
    IL_0199: nop
    IL_019A: ldarg.0
    IL_019B: ldc.i4.1
    IL_01A0: stfld 0x04000213
    IL_01A1: ldarg.0
    IL_01A2: dup
    IL_01A7: ldfld 0x04000215
    IL_01A8: ldarg.0
    IL_01AD: ldflda 0x04000219
    IL_01B2: ldfld 0x0A00005E
    IL_01B3: IL_58
    IL_01B8: stfld 0x04000215
    IL_01B9: ldarg.0
    IL_01BA: dup
    IL_01BF: ldfld 0x04000216
    IL_01C0: ldarg.0
    IL_01C5: ldflda 0x04000219
    IL_01CA: ldfld 0x0A000023
    IL_01CB: IL_58
    IL_01D0: stfld 0x04000216
    IL_01D1: ldarg.0
    IL_01D2: ldarg.0
    IL_01D7: ldfld 0x04000215
    IL_01D8: IL_22
    IL_01D9: ldelem.i
    IL_01DA: IL_99
    IL_01DB: IL_D9
    IL_01DC: IL_BF
    IL_01DD: IL_22
    IL_01DE: ldelem.i
    IL_01DF: IL_99
    IL_01E0: IL_D9
    IL_01E1: IL_3F
    IL_01E6: call 0x0A0000D4
    IL_01EB: stfld 0x04000215
    IL_01EC: ldarg.0
    IL_01ED: ldarg.0
    IL_01F2: ldfld 0x04000216
    IL_01F3: IL_22
    IL_01F5: bne.un.s IL_0229
    IL_01F7: stloc.s 192
    IL_01F8: IL_22
    IL_01FA: bne.un.s IL_022E
    IL_01FC: stloc.s 64
    IL_0201: call 0x0A0000D4
    IL_0206: stfld 0x04000216
    IL_0207: ldarg.0
    IL_020C: ldfld 0x0400021B
    IL_020D: ldarg.0
    IL_0212: ldfld 0x04000215
    IL_0213: ldarg.0
    IL_0218: ldfld 0x04000216
    IL_0219: IL_22
    IL_021A: nop
    IL_021B: nop
    IL_0220: stsfld 0x0076733F
    IL_0221: nop
    IL_0222: stloc.0
    IL_0223: conv.r8
    IL_0224: ldloc.3
    IL_0225: nop
    IL_0226: nop
    IL_0227: stloc.0
    IL_0228: ldarg.0
    IL_022D: ldfld 0x0400021F
    IL_0232: brfalse IL_02AC
    IL_0233: ldarg.0
    IL_0238: ldfld 0x0400021D
    IL_0239: ldarg.0
    IL_023E: ldfld 0x0400021E
    IL_025F: switch (7 cases)
    IL_300A16B64: switch (3223870016 cases)
    }

    }}
