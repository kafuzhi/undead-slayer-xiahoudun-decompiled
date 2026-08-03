// Namespace: 
// Type: Cam_Loading

    public class Cam_Loading {{

    public object txt_loading;
    public object black;
    public object basicSkin;
    private object stopCam;
    private object horse;
    private object tip_idx;
    private object language;

    public Cam_Loading() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000D0
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000B: ldloc 8770
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_C0
    IL_000F: IL_3F
    IL_0010: IL_22
    IL_0011: stloc.0
    IL_0012: IL_D7
    IL_0013: IL_23
    IL_0014: IL_3C
    IL_0015: IL_22
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldelem.r8
    IL_0019: IL_41
    IL_001E: call 0x0A0000DB
    IL_001F: conv.r8
    IL_0020: IL_D2
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ldarg.0
    IL_0029: ldstr 0x70000B91
    IL_002E: call 0x0A000077
    IL_002F: conv.r8
    IL_0030: ldarg.3
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x04000234
    IL_0039: ldarg.0
    IL_003E: ldstr 0x70000BB3
    IL_0043: call 0x0A000095
    IL_0048: stfld 0x04000236
    IL_0049: ldarg.0
    IL_004E: ldc.i4 311
    IL_0053: ldc.i4 331
    IL_0058: call 0x0A000045
    IL_005D: stfld 0x04000235
    IL_005E: ret
    }

    public void DisappearCam() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000233
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000233
    IL_000A: brtrue IL_003A
    IL_000B: ldarg.0
    IL_0010: call 0x0A000002
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000234
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_22
    IL_001D: IL_CD
    IL_001E: IL_CC
    IL_001F: IL_CC
    IL_0020: IL_BE
    IL_0021: IL_22
    IL_0022: stloc.0
    IL_0023: IL_D7
    IL_0024: IL_23
    IL_0025: IL_3E
    IL_0026: IL_22
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002F: newobj 0x0A000076
    IL_0034: call 0x0A000029
    IL_0035: conv.r8
    IL_0036: IL_DC
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: ret
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
    IL_003B: ldfld 0x04000232
    IL_0040: call 0x0A0000DF
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_004E: IL_F0
    IL_004F: IL_43
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x021D2842
    IL_0058: nop
    IL_0059: ldloc.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000231
    IL_0064: call 0x0A0000E0
    IL_0065: IL_22
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_0071: stsfld 0x00002243
    IL_0072: IL_F0
    IL_0073: IL_43
    IL_0074: IL_22
    IL_0075: nop
    IL_0076: nop
    IL_0077: IL_94
    IL_0078: IL_42
    IL_007D: call 0x0600021D
    IL_007E: ldarg.0
    IL_0083: ldfld 0x04000231
    IL_0088: call 0x0A0000E0
    IL_0089: IL_22
    IL_008A: nop
    IL_008B: nop
    IL_008C: IL_B9
    IL_008D: IL_43
    IL_008E: IL_22
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_92
    IL_0092: IL_43
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_C8
    IL_0097: IL_42
    IL_0098: IL_22
    IL_0099: nop
    IL_009A: nop
    IL_009B: IL_C8
    IL_009C: IL_41
    IL_00A1: call 0x0600021D
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000230
    IL_00AC: call 0x0A0000E0
    IL_00AD: IL_22
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: IL_22
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: IL_85
    IL_00B6: IL_43
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: IL_F0
    IL_00BB: IL_43
    IL_00BC: IL_22
    IL_00BD: nop
    IL_00BE: nop
    IL_00C3: stsfld 0x021D2841
    IL_00C4: nop
    IL_00C5: ldloc.0
    IL_00CA: ldsfld 0x040007B2
    IL_00CB: ldarg.0
    IL_00D0: ldfld 0x04000236
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x04000235
    IL_00DB: call 0x0A0000E1
    IL_00E0: ldstr 0x70000BC5
    IL_00E5: call 0x0A0000E2
    IL_00EA: call 0x0A0000E3
    IL_00EB: ret
    }

    }}
