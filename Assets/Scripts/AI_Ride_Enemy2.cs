// Namespace: 
// Type: AI_Ride_Enemy2

    public class AI_Ride_Enemy2 {{

    private object mytransform;
    private object cha1;
    private object targetdir;
    private object state;
    private object rot_limit;
    private object rot_speed;
    private object impact;
    private object live;
    public object bullet;
    private object c_bullet;
    private object temp;

    public AI_Ride_Enemy2() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040000E9
    IL_000C: ret
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
    IL_0014: stfld 0x040000EA
    IL_0015: ldarg.0
    IL_001A: call 0x0A00002A
    IL_001F: ldstr 0x70000327
    IL_0020: conv.r8
    IL_0022: bge.s IL_0023
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: IL_22
    IL_0026: nop
    IL_0027: nop
    IL_002C: stsfld 0x00306F3E
    IL_002D: nop
    IL_002E: stloc.0
    IL_002F: ldarg.0
    IL_0034: call 0x0A00002A
    IL_0039: ldstr 0x70000339
    IL_003A: conv.r8
    IL_003C: bge.s IL_003D
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: IL_22
    IL_0040: nop
    IL_0041: nop
    IL_0046: stsfld 0x00306F3E
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: call 0x0A00002A
    IL_0053: ldstr 0x70000339
    IL_0054: conv.r8
    IL_0056: bge.s IL_0057
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldc.i4.1
    IL_005A: conv.r8
    IL_005C: ble.s IL_005D
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: ldarg.0
    IL_0064: call 0x0A00002A
    IL_0069: ldstr 0x70000327
    IL_006A: conv.r8
    IL_006B: IL_3C
    IL_006C: nop
    IL_006D: nop
    IL_006E: stloc.0
    IL_006F: pop
    IL_0070: ldarg.0
    IL_0075: ldstr 0x70000357
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_007D: stsfld 0x00002240
    IL_8982: switch (8768 cases)
    }

    public void Attack() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000F0
    IL_000A: brfalse IL_004E
    IL_000B: ldarg.0
    IL_0010: call 0x0A00002A
    IL_0015: ldstr 0x70000339
    IL_0016: conv.r8
    IL_0017: IL_3C
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: pop
    IL_001C: ldarg.0
    IL_001D: ldarg.0
    IL_0022: call 0x0A00002A
    IL_0027: ldstr 0x70000365
    IL_0028: conv.r8
    IL_002D: newobj 0x7D0A0000
    IL_002E: IL_F3
    IL_002F: nop
    IL_0030: nop
    IL_0031: ldarg.2
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040000F3
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003F: stsfld 0x00306F3E
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x040000F3
    IL_0048: ldc.i4.1
    IL_0049: conv.r8
    IL_004B: ble.s IL_004C
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ret
    }

    public void Wake() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040000F0
    IL_0007: ret
    }

    public void Defeat() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040000F0
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040000F0
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: call 0x0A00002A
    IL_0016: ldstr 0x70000365
    IL_0017: conv.r8
    IL_0018: IL_56
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: brfalse IL_009F
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: stsfld 0x00ED7DBF
    IL_002A: nop
    IL_002B: ldarg.2
    IL_002C: ldarg.0
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0031: IL_41
    IL_0036: stfld 0x040000EE
    IL_0037: ldarg.0
    IL_003C: ldfld 0x040000EF
    IL_0041: brtrue IL_009A
    IL_0042: ldarg.0
    IL_0047: ldfld 0x040000F2
    IL_0048: conv.r8
    IL_0049: stloc.0
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldc.i4.1
    IL_004E: conv.r8
    IL_004F: stloc.1
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0058: ldfld 0x040000F2
    IL_0059: ldarg.0
    IL_005E: ldfld 0x040000E9
    IL_005F: conv.r8
    IL_0060: ldc.i4.2
    IL_0061: nop
    IL_0062: nop
    IL_0063: stloc.0
    IL_0068: call 0x0A000007
    IL_0069: IL_22
    IL_006A: stloc.0
    IL_006B: IL_D7
    IL_006C: stelem.i
    IL_006D: IL_3D
    IL_0072: call 0x0A000008
    IL_0077: call 0x0A000029
    IL_0078: conv.r8
    IL_0079: ldloc.3
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: ldarg.0
    IL_0082: ldfld 0x040000F2
    IL_0083: ldarg.0
    IL_0088: ldfld 0x040000E9
    IL_0089: conv.r8
    IL_008A: pop
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: conv.r8
    IL_0093: call 0x020A0000
    IL_0094: ldc.i4.1
    IL_0099: stfld 0x040000EF
    IL_009E: br IL_0101
    IL_009F: ldarg.0
    IL_00A4: call 0x0A00002A
    IL_00A9: ldstr 0x70000339
    IL_00AA: conv.r8
    IL_00AB: IL_56
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: stloc.0
    IL_00B3: brfalse IL_00D6
    IL_00B4: ldarg.0
    IL_00B5: IL_22
    IL_00B6: nop
    IL_00B7: nop
    IL_00BC: stsfld 0x00ED7DBF
    IL_00BD: nop
    IL_00BE: ldarg.2
    IL_00BF: ldarg.0
    IL_00C0: IL_22
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: IL_41
    IL_00C9: stfld 0x040000EE
    IL_00CA: ldarg.0
    IL_00CB: ldc.i4.0
    IL_00D0: stfld 0x040000EF
    IL_00D5: br IL_0101
    IL_00D6: ldarg.0
    IL_00DB: call 0x0A00002A
    IL_00E0: ldstr 0x70000327
    IL_00E1: conv.r8
    IL_00E2: IL_56
    IL_00E3: nop
    IL_00E4: nop
    IL_00E5: stloc.0
    IL_00EA: brfalse IL_0101
    IL_00EB: ldarg.0
    IL_00EC: IL_22
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: nop
    IL_00F5: stfld 0x040000ED
    IL_00F6: ldarg.0
    IL_00F7: IL_22
    IL_00F8: nop
    IL_00F9: nop
    IL_00FE: stsfld 0x00EE7D40
    IL_00FF: nop
    IL_0100: ldarg.2
    IL_0101: ldarg.0
    IL_0102: ldarg.0
    IL_0107: ldfld 0x040000EA
    IL_0108: conv.r8
    IL_0109: ldc.i4.2
    IL_010A: nop
    IL_010B: nop
    IL_010C: stloc.0
    IL_010D: ldarg.0
    IL_0112: ldfld 0x040000E9
    IL_0113: conv.r8
    IL_0114: ldc.i4.2
    IL_0115: nop
    IL_0116: nop
    IL_0117: stloc.0
    IL_011C: call 0x0A000019
    IL_0121: stfld 0x040000EB
    IL_0122: ldarg.0
    IL_0127: ldflda 0x040000EB
    IL_0128: ldc.i4.1
    IL_0129: IL_22
    IL_012A: nop
    IL_012B: nop
    IL_012C: nop
    IL_012D: nop
    IL_0132: call 0x0A00001A
    IL_0133: ldarg.0
    IL_0134: ldarg.0
    IL_0139: ldfld 0x040000EB
    IL_013E: call 0x0A000040
    IL_0143: stfld 0x040000EB
    IL_0144: ldarg.0
    IL_0149: ldflda 0x040000EB
    IL_014E: ldfld 0x0A00005C
    IL_014F: ldarg.0
    IL_0154: ldfld 0x040000ED
    IL_0155: IL_43
    IL_0157: blt.s IL_0158
    IL_0158: nop
    IL_0159: nop
    IL_015A: ldarg.0
    IL_015F: ldfld 0x040000E9
    IL_0160: ldarg.0
    IL_0165: ldfld 0x040000E9
    IL_0166: conv.r8
    IL_0167: IL_22
    IL_0168: nop
    IL_0169: nop
    IL_016A: stloc.0
    IL_016B: ldarg.0
    IL_0170: ldfld 0x040000EB
    IL_0175: call 0x0A000024
    IL_0176: ldarg.0
    IL_017B: ldfld 0x040000EE
    IL_017C: IL_5A
    IL_0181: call 0x0A000063
    IL_0182: conv.r8
    IL_0187: ldc.i4 940179456
    IL_0189: br.s IL_018A
    IL_018A: nop
    IL_018B: nop
    IL_018C: ldarg.0
    IL_0191: ldfld 0x040000E9
    IL_0192: ldarg.0
    IL_0197: ldfld 0x040000E9
    IL_0198: conv.r8
    IL_0199: IL_22
    IL_019A: nop
    IL_019B: nop
    IL_019C: stloc.0
    IL_01A1: call 0x0A000042
    IL_01A6: call 0x0A000024
    IL_01A7: IL_22
    IL_01A8: nop
    IL_01A9: nop
    IL_01AA: IL_C0
    IL_18CA317: switch (6498394 cases)
    }

    }}
