// Namespace: 
// Type: AI_Ride_Enemy

    public class AI_Ride_Enemy {{

    private object mytransform;
    private object cha1;
    private object rndposition;
    private object life;
    private object attackrangeZ;
    private object attackrangeX;
    private object attackdelay;
    private object ef_hit;
    public object mon;
    private object script_sound;
    private object script_cam;
    private object script_cha1;
    private object script_mon;

    public AI_Ride_Enemy() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00001B
    IL_000A: stfld 0x040000DE
    IL_000B: ldarg.0
    IL_000C: ldc.i4.1
    IL_0011: stfld 0x040000DF
    IL_0012: ldarg.0
    IL_0017: call 0x0A000001
    IL_0018: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040000DC
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040000E4
    IL_0013: conv.r8
    IL_0015: ldarga.s 0
    IL_0016: nop
    IL_0018: br.s IL_0096
    IL_0019: IL_E8
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x040000DD
    IL_0015: ldarg.0
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040000DD
    IL_001C: conv.r8
    IL_001E: starg.s 0
    IL_001F: nop
    IL_0021: br.s IL_009F
    IL_0022: IL_E7
    IL_0023: nop
    IL_0024: nop
    IL_0025: ldarg.2
    IL_0026: ldarg.0
    IL_002B: call 0x0A00002A
    IL_0030: ldstr 0x70000177
    IL_0031: conv.r8
    IL_0033: bge.s IL_0034
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_22
    IL_0037: ldelem.i
    IL_0038: IL_99
    IL_0039: IL_99
    IL_003A: IL_3E
    IL_003B: conv.r8
    IL_003D: bgt.s IL_003E
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: call 0x0A00002A
    IL_004A: ldstr 0x7000016D
    IL_004B: conv.r8
    IL_004C: IL_3C
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: pop
    IL_0051: ldarg.0
    IL_0056: ldstr 0x700002BD
    IL_0057: IL_22
    IL_0058: IL_CD
    IL_0059: IL_CC
    IL_005A: IL_CC
    IL_005B: IL_3D
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_1D4A163: switch (7678016 cases)
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_000A: ldstr 0x7000016D
    IL_000B: conv.r8
    IL_000C: IL_3C
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: pop
    IL_0011: ldarg.0
    IL_0012: ldc.i4.1
    IL_0017: stfld 0x040000DF
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040000E8
    IL_001E: conv.r8
    IL_001F: IL_43
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldloc.0
    IL_0023: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: ldarg.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040000DD
    IL_000C: conv.r8
    IL_000D: IL_88
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: brfalse IL_0097
    IL_0016: ldarg.0
    IL_0017: ldc.i4.0
    IL_001C: stfld 0x040000DF
    IL_001D: ldarg.0
    IL_0022: call 0x0A00002A
    IL_0027: ldstr 0x70000177
    IL_0028: conv.r8
    IL_0029: IL_3C
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: pop
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040000E5
    IL_0034: ldc.i4.3
    IL_0035: conv.r8
    IL_0036: IL_EC
    IL_0037: ldarg.2
    IL_0038: nop
    IL_0039: ldloc.0
    IL_003A: ldarg.0
    IL_003F: ldfld 0x040000E6
    IL_0040: conv.r8
    IL_0045: brfalse IL_2060047
    IL_004A: ldfld 0x040000E3
    IL_004B: conv.r8
    IL_004C: stloc.0
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: ldc.i4.1
    IL_0051: conv.r8
    IL_0052: stloc.1
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x040000E3
    IL_005C: ldarg.0
    IL_0061: ldfld 0x040000DC
    IL_0062: conv.r8
    IL_0063: ldc.i4.2
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_006B: call 0x0A000007
    IL_006C: IL_22
    IL_006D: IL_CD
    IL_006E: IL_CC
    IL_006F: IL_4C
    IL_0070: IL_3D
    IL_0075: call 0x0A000008
    IL_007A: call 0x0A000029
    IL_007B: conv.r8
    IL_007C: ldloc.3
    IL_007D: nop
    IL_007E: nop
    IL_007F: stloc.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x040000E7
    IL_0086: ldc.i4.3
    IL_0087: conv.r8
    IL_0088: IL_A4
    IL_0089: IL_01
    IL_008A: nop
    IL_008B: ldloc.0
    IL_008C: ldarg.0
    IL_0091: ldfld 0x040000E8
    IL_0092: conv.r8
    IL_0093: IL_44
    IL_0094: nop
    IL_0095: nop
    IL_0096: ldloc.0
    IL_0097: ret
    }

    public void SetRndPosition() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000062
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000D: stsfld 0x000022BF
    IL_0012: stsfld 0x0075283F
    IL_0013: nop
    IL_0014: stloc.0
    IL_0019: call 0x0A000008
    IL_001E: call 0x0A000042
    IL_001F: IL_22
    IL_0020: IL_CD
    IL_0021: IL_CC
    IL_0022: IL_CC
    IL_0023: IL_BE
    IL_0024: IL_22
    IL_0025: ldelem.i
    IL_0026: IL_99
    IL_0027: ldc.i4.3
    IL_0028: IL_3F
    IL_002D: call 0x0A000075
    IL_0032: call 0x0A000008
    IL_0037: call 0x0A000029
    IL_003C: stfld 0x040000DE
    IL_003D: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000DF
    IL_000A: brfalse IL_003C
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040000DC
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040000DC
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040000DE
    IL_0026: call 0x0A000024
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_3F
    IL_002C: IL_5A
    IL_0031: call 0x0A000063
    IL_0032: conv.r8
    IL_0033: ldloc.3
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: br IL_00AE
    IL_003C: ldarg.0
    IL_0041: ldfld 0x040000DC
    IL_0042: dup
    IL_0043: conv.r8
    IL_0044: ldc.i4.2
    IL_0045: nop
    IL_0046: nop
    IL_0047: stloc.0
    IL_004C: call 0x0A000042
    IL_0051: call 0x0A000024
    IL_0056: call 0x0A000008
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005E: stsfld 0x0008283F
    IL_005F: nop
    IL_0060: stloc.0
    IL_0065: call 0x0A000019
    IL_0066: conv.r8
    IL_0067: ldloc.3
    IL_0068: nop
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040000DC
    IL_0071: conv.r8
    IL_0072: ldc.i4.2
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: stloc.0
    IL_0078: ldloca.s 0
    IL_007D: ldfld 0x0A00005C
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0085: stsfld 0x002641BF
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldarg.0
    IL_008D: ldfld 0x040000DC
    IL_0092: call 0x0A00004B
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_009A: stsfld 0x00082840
    IL_009B: nop
    IL_009C: stloc.0
    IL_009D: conv.r8
    IL_009E: ldloc.3
    IL_009F: nop
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: ldarg.0
    IL_00A7: call 0x0A00000A
    IL_00A8: ldc.i4.0
    IL_00A9: conv.r8
    IL_00AA: stloc.1
    IL_00AB: nop
    IL_00AC: nop
    IL_00AD: stloc.0
    IL_00AE: ldarg.0
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x040000DC
    IL_00B5: conv.r8
    IL_00B6: ldc.i4.2
    IL_00B7: nop
    IL_00B8: nop
    IL_00B9: stloc.0
    IL_00BA: stloc.1
    IL_00BC: ldloca.s 1
    IL_00C1: ldfld 0x0A00005C
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x040000DD
    IL_00C8: conv.r8
    IL_00C9: ldc.i4.2
    IL_00CA: nop
    IL_00CB: nop
    IL_00CC: stloc.0
    IL_00CD: stloc.2
    IL_00CF: ldloca.s 2
    IL_00D4: ldfld 0x0A00005C
    IL_00D5: IL_59
    IL_00DA: stfld 0x040000E0
    IL_00DB: ldarg.0
    IL_00E0: ldfld 0x040000E2
    IL_00E1: IL_22
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: nop
    IL_00E5: nop
    IL_00E6: IL_43
    IL_00E7: ldc.i4.1
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: nop
    IL_00EB: ldarg.0
    IL_00EC: dup
    IL_00F1: ldfld 0x040000E2
    IL_00F6: call 0x0A000024
    IL_00F7: IL_59
    IL_00FC: stfld 0x040000E2
    IL_0101: br IL_0192
    IL_0102: ldarg.0
    IL_0107: ldfld 0x040000E0
    IL_010C: call 0x0A00007F
    IL_010D: IL_22
    IL_010E: ldelem.i
    IL_010F: IL_99
    IL_0110: ldc.i4.3
    IL_0111: IL_3E
    IL_0112: IL_41
    IL_0117: ldfld 0x02000000
    IL_0118: ldarg.0
    IL_011D: ldfld 0x040000DC
    IL_011E: conv.r8
    IL_011F: ldc.i4.2
    IL_0120: nop
    IL_0121: nop
    IL_0122: stloc.0
    IL_0123: stloc.3
    IL_0125: ldloca.s 3
    IL_012A: ldfld 0x0A00005E
    IL_012B: ldarg.0
    IL_0130: ldfld 0x040000DD
    IL_0131: conv.r8
    IL_0132: ldc.i4.2
    IL_0133: nop
    IL_0134: nop
    IL_0135: stloc.0
    IL_0137: stloc.s 4
    IL_0139: ldloca.s 4
    IL_013E: ldfld 0x0A00005E
    IL_013F: IL_59
    IL_0144: stfld 0x040000E1
    IL_0145: ldarg.0
    IL_014A: ldfld 0x040000E1
    IL_014F: call 0x0A00007F
    IL_0150: IL_22
    IL_0151: nop
    IL_0152: nop
    IL_0157: stsfld 0x0038413E
    IL_0158: nop
    IL_0159: nop
    IL_015A: ldarg.0
    IL_015F: ldfld 0x040000E1
    IL_0160: IL_22
    IL_0161: nop
    IL_0162: nop
    IL_0163: nop
    IL_0164: nop
    IL_0165: IL_43
    IL_0167: ldloc.s 0
    IL_0168: nop
    IL_0169: nop
    IL_016A: ldarg.0
    IL_016F: ldfld 0x040000E7
    IL_0170: ldc.i4.1
    IL_0171: conv.r8
    IL_0172: stelem.i
    IL_0173: IL_01
    IL_0174: nop
    IL_0175: ldloc.0
    IL_017A: br IL_0187
    IL_017B: ldarg.0
    IL_0180: ldfld 0x040000E7
    IL_0181: ldc.i4.0
    IL_0182: conv.r8
    IL_0183: stelem.i
    IL_0184: IL_01
    IL_0185: nop
    IL_0186: ldloc.0
    IL_0187: ldarg.0
    IL_0188: IL_22
    IL_0189: IL_CD
    IL_018A: IL_CC
    IL_018B: IL_4C
    IL_018C: IL_3E
    IL_0191: stfld 0x040000E2
    IL_0192: ret
    }

    }}
