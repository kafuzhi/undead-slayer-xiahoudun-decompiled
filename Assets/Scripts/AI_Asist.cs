// Namespace: 
// Type: AI_Asist

    public class AI_Asist {{

    private object delay_atack;
    private object firerate;
    private object mytransform;
    private object cha1;
    private object mycollider;
    private object directionVector;
    private object rotate;
    private object shoot;
    private object speed;
    private object cur_speed;
    private object m_arrow;
    public object a_mesh;
    private object ef_splash;
    public object tex_pt;
    public object tex_grade;
    private object a_index;
    private object targetPos;
    private object script_db;

    public AI_Asist() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x00027D3F
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: ldelem.i
    IL_000E: IL_99
    IL_000F: IL_99
    IL_0010: IL_3E
    IL_0015: stfld 0x04000009
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: ldelem.i
    IL_0019: IL_99
    IL_001A: IL_99
    IL_001B: IL_3E
    IL_0020: stfld 0x0400000A
    IL_0021: ldarg.0
    IL_0022: ldc.i4.8
    IL_0027: newarr 0x01000001
    IL_002C: stfld 0x0400000E
    IL_002D: ldarg.0
    IL_002E: ldc.i4.8
    IL_0033: newarr 0x01000001
    IL_0038: stfld 0x0400000F
    IL_0039: ldarg.0
    IL_003E: call 0x0A000001
    IL_003F: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000003
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000005
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000001
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: ldarg.3
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x04000004
    IL_002D: ldarg.0
    IL_0032: ldstr 0x7000000F
    IL_0037: call 0x06000220
    IL_003C: stfld 0x04000010
    IL_003D: ldarg.0
    IL_003E: ldarg.0
    IL_0043: call 0x2B000001
    IL_0048: stfld 0x04000012
    IL_0049: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000010
    IL_000A: brtrue IL_0036
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000003
    IL_0015: call 0x0A000007
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: IL_A8
    IL_001A: IL_41
    IL_001F: call 0x0A000008
    IL_0020: conv.r8
    IL_0021: ldloc.3
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldarg.0
    IL_002A: call 0x0A00000A
    IL_002B: ldc.i4.0
    IL_002C: conv.r8
    IL_002D: stloc.1
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: br IL_01D1
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000003
    IL_0040: call 0x0A000007
    IL_0041: IL_22
    IL_0042: IL_CD
    IL_0043: IL_CC
    IL_0044: IL_4C
    IL_0045: IL_3E
    IL_004A: call 0x0A000008
    IL_004B: conv.r8
    IL_004C: ldloc.3
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: ldarg.0
    IL_0055: call 0x0A00000C
    IL_0056: conv.r8
    IL_0057: stloc.3
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: conv.r8
    IL_005D: ldarg.s 0
    IL_005E: nop
    IL_005F: stloc.0
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400000E
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000010
    IL_006C: ldc.i4.1
    IL_006D: IL_59
    IL_006E: ldelem.i
    IL_006F: conv.r8
    IL_0071: ldarga.s 0
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x0400000C
    IL_007A: conv.r8
    IL_007B: stloc.3
    IL_007C: nop
    IL_007D: nop
    IL_007E: stloc.0
    IL_007F: conv.r8
    IL_0081: ldarg.s 0
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x0400000F
    IL_008A: ldarg.0
    IL_008F: ldfld 0x04000010
    IL_0090: ldc.i4.1
    IL_0091: IL_59
    IL_0092: ldelem.i
    IL_0093: conv.r8
    IL_0095: ldarga.s 0
    IL_0096: nop
    IL_0097: stloc.0
    IL_0099: ldc.i4.s 25
    IL_009A: stloc.0
    IL_009B: ldarg.0
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x04000012
    IL_00A6: ldfld 0x04000521
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000010
    IL_00AD: ldc.i4.1
    IL_00AE: IL_59
    IL_00AF: IL_8F
    IL_00B0: conv.i8
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x0400051E
    IL_00BD: stfld 0x04000009
    IL_00BE: ldarg.0
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x04000012
    IL_00C9: ldfld 0x04000521
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04000010
    IL_00D0: ldc.i4.1
    IL_00D1: IL_59
    IL_00D2: IL_8F
    IL_00D3: conv.i8
    IL_00D4: nop
    IL_00D5: nop
    IL_00D6: ldarg.0
    IL_00DB: ldfld 0x0400051D
    IL_00E0: stfld 0x04000002
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x04000012
    IL_00EB: ldfld 0x04000521
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x04000010
    IL_00F2: ldc.i4.1
    IL_00F3: IL_59
    IL_00F4: IL_8F
    IL_00F5: conv.i8
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: ldarg.0
    IL_00FD: ldfld 0x0400051F
    IL_00FE: stloc.0
    IL_0103: ldstr 0x70000017
    IL_0104: ldarg.0
    IL_0109: ldflda 0x04000010
    IL_010E: call 0x0A000010
    IL_0113: call 0x0A000011
    IL_0118: call 0x0A000012
    IL_0119: conv.u8
    IL_011A: ldloc.0
    IL_011B: nop
    IL_011C: nop
    IL_011D: IL_01
    IL_011E: stloc.1
    IL_011F: ldarg.0
    IL_0120: ldloc.1
    IL_0121: conv.r8
    IL_0122: ldarg.3
    IL_0123: nop
    IL_0124: nop
    IL_0125: stloc.0
    IL_012A: call 0x0A000007
    IL_012B: IL_22
    IL_012C: nop
    IL_012D: nop
    IL_0132: stsfld 0x00082840
    IL_0133: nop
    IL_0134: stloc.0
    IL_0139: call 0x0A000013
    IL_013E: call 0x0A000014
    IL_013F: conv.u4
    IL_0140: ldarg.1
    IL_0141: nop
    IL_0142: nop
    IL_0143: IL_01
    IL_0148: stfld 0x0400000B
    IL_0149: ldarg.0
    IL_014E: ldfld 0x0400000B
    IL_014F: conv.r8
    IL_0150: stloc.0
    IL_0151: nop
    IL_0152: nop
    IL_0153: stloc.0
    IL_0154: ldloc.0
    IL_0155: conv.r8
    IL_0156: ldc.i4.m1
    IL_0157: nop
    IL_0158: nop
    IL_0159: stloc.0
    IL_015A: ldarg.0
    IL_015F: ldfld 0x04000012
    IL_0164: ldfld 0x04000521
    IL_0165: ldarg.0
    IL_016A: ldfld 0x04000010
    IL_016B: ldc.i4.1
    IL_016C: IL_59
    IL_016D: IL_8F
    IL_016E: conv.i8
    IL_016F: nop
    IL_0170: nop
    IL_0171: ldarg.0
    IL_0176: ldfld 0x04000520
    IL_0177: stloc.2
    IL_0178: ldloc.2
    IL_0179: ldc.i4.0
    IL_017A: IL_3E
    IL_017B: localloc
    IL_017C: nop
    IL_017D: nop
    IL_017E: nop
    IL_0183: ldstr 0x70000031
    IL_0185: ldloca.s 2
    IL_018A: call 0x0A000016
    IL_018F: call 0x0A000011
    IL_0194: call 0x0A000012
    IL_0195: conv.u8
    IL_0196: ldloc.0
    IL_0197: nop
    IL_0198: nop
    IL_0199: IL_01
    IL_019A: stloc.3
    IL_019B: ldarg.0
    IL_019C: ldloc.3
    IL_019D: conv.r8
    IL_019E: ldarg.3
    IL_019F: nop
    IL_01A0: nop
    IL_01A1: stloc.0
    IL_01A6: call 0x0A000007
    IL_01A7: IL_22
    IL_01A8: nop
    IL_01A9: nop
    IL_01AE: stsfld 0x00082840
    IL_01AF: nop
    IL_01B0: stloc.0
    IL_01B5: call 0x0A000013
    IL_01BA: call 0x0A000014
    IL_01BB: conv.u4
    IL_01BC: ldarg.1
    IL_01BD: nop
    IL_01BE: nop
    IL_01BF: IL_01
    IL_01C4: stfld 0x0400000D
    IL_01C9: br IL_01D1
    IL_01CA: ldarg.0
    IL_01CB: ldnull
    IL_01D0: stfld 0x0400000D
    IL_01D1: ldarg.0
    IL_01D6: ldstr 0x7000004B
    IL_01D7: IL_22
    IL_01D8: IL_CD
    IL_01D9: IL_CC
    IL_01DA: IL_CC
    IL_01DB: IL_3D
    IL_01DC: IL_22
    IL_01DD: IL_CD
    IL_01DE: IL_CC
    IL_01DF: IL_CC
    IL_01E0: IL_3D
    IL_01E5: call 0x0A000017
    IL_01E6: ret
    }

    public void SetIndex() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000010
    IL_0007: ldarg.0
    IL_000C: call 0x06000003
    IL_000D: ret
    }

    public void LoadDir() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000004
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000003
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000019
    IL_0020: stfld 0x04000006
    IL_0021: ldarg.0
    IL_0026: ldflda 0x04000006
    IL_0027: ldc.i4.1
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_0031: call 0x0A00001A
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000006
    IL_003C: call 0x0A00001B
    IL_0041: call 0x0A00001C
    IL_0046: brfalse IL_0058
    IL_0047: ldarg.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000006
    IL_0052: call 0x0A00001D
    IL_0057: stfld 0x04000007
    IL_0058: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000008
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.1
    IL_000D: conv.r8
    IL_000E: stloc.0
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: conv.r8
    IL_0013: ldc.i4.8
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: stloc.0
    IL_0018: ldarg.1
    IL_0019: conv.r8
    IL_001A: stloc.0
    IL_001B: nop
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: conv.r8
    IL_001F: ldc.i4.8
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: ldc.i4.8
    IL_00E4: switch (47 cases)
    }

    private void AttackOn() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000011
    IL_0007: ldarg.0
    IL_000C: ldfld 0x0400000B
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000011
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000003
    IL_0019: conv.r8
    IL_001A: ldc.i4.2
    IL_001B: nop
    IL_001C: nop
    IL_001D: stloc.0
    IL_0022: call 0x0A000019
    IL_0023: conv.r8
    IL_0028: ldc.i4 34209792
    IL_002D: ldfld 0x0400000B
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000003
    IL_0034: conv.r8
    IL_0035: ldc.i4.2
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: conv.r8
    IL_003A: ldloc.3
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x0400000B
    IL_0044: conv.r8
    IL_0045: stloc.0
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldc.i4.1
    IL_004A: conv.r8
    IL_004B: stloc.1
    IL_004C: nop
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: ret
    }

    public void AttackFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000008
    IL_0007: ldarg.0
    IL_000C: ldfld 0x0400000D
    IL_000D: ldnull
    IL_0012: call 0x0A000021
    IL_0017: brfalse IL_006E
    IL_0018: ldarg.0
    IL_001D: ldfld 0x0400000B
    IL_001E: conv.r8
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: stloc.0
    IL_0025: ldloca.s 0
    IL_0026: IL_22
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002F: stfld 0x0A000023
    IL_0030: ldarg.0
    IL_0035: ldflda 0x04000011
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003F: stfld 0x0A000023
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400000D
    IL_0046: ldloc.0
    IL_0047: conv.r8
    IL_004C: ldc.i4 34209792
    IL_0051: ldfld 0x0400000D
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000011
    IL_0058: conv.r8
    IL_0059: ldloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x0400000D
    IL_0063: conv.r8
    IL_0064: stloc.0
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ldc.i4.1
    IL_0069: conv.r8
    IL_006A: stloc.1
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_006E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000008
    IL_000A: brfalse IL_0031
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400000A
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_001B: call 0x0A000024
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: stsfld 0x25285A40
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_002B: stfld 0x0400000A
    IL_0030: br IL_0092
    IL_0031: ldarg.0
    IL_0032: ldarg.0
    IL_0037: ldfld 0x0400000A
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000009
    IL_0042: call 0x0A000024
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_004A: stsfld 0x25285A40
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_0052: stfld 0x0400000A
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000001
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000002
    IL_005F: IL_43
    IL_0060: ldc.i4.6
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000005
    IL_006A: ldc.i4.1
    IL_006B: conv.r8
    IL_006D: ldc.i4.s 0
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: ldarg.0
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_007A: stfld 0x04000001
    IL_007F: br IL_0092
    IL_0080: ldarg.0
    IL_0081: dup
    IL_0086: ldfld 0x04000001
    IL_008B: call 0x0A000024
    IL_008C: IL_58
    IL_0091: stfld 0x04000001
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000003
    IL_0098: ldarg.0
    IL_009D: ldfld 0x04000003
    IL_009E: conv.r8
    IL_009F: pop
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04000007
    IL_00AD: call 0x0A000024
    IL_00AE: ldarg.0
    IL_00B3: ldfld 0x0400000A
    IL_00B4: IL_5A
    IL_00B5: IL_22
    IL_00B6: nop
    IL_00B7: nop
    IL_00BC: stsfld 0x27285A40
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: stloc.0
    IL_00C0: conv.r8
    IL_00C5: call 0x020A0000
    IL_00CA: ldfld 0x04000003
    IL_00CB: dup
    IL_00CC: conv.r8
    IL_00CD: ldc.i4.2
    IL_00CE: nop
    IL_00CF: nop
    IL_00D0: stloc.0
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x04000003
    IL_00D7: conv.r8
    IL_00D8: IL_22
    IL_00D9: nop
    IL_00DA: nop
    IL_00DB: stloc.0
    IL_00E0: call 0x0A000024
    IL_00E5: call 0x0A000008
    IL_00E6: ldarg.0
    IL_00EB: ldfld 0x0400000A
    IL_00F0: call 0x0A000008
    IL_00F5: call 0x0A000029
    IL_00F6: conv.r8
    IL_00F7: ldloc.3
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FB: ret
    }

    }}
