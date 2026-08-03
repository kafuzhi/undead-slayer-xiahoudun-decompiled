// Namespace: 
// Type: Cam_island

    public class Cam_island {{

    private object mytransform;
    public object bg;
    public object txt_loading;
    private object async;

    public Cam_island() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400027F
    IL_000C: ret
    }

    private void Start() {
    IL_0004: newobj 0x06000737
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x0400101F
    IL_000D: ldloc.0
    IL_000E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400027F
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: call 0x0A000042
    IL_0015: call 0x0A000024
    IL_001A: call 0x0A000008
    IL_001B: IL_22
    IL_001C: IL_8F
    IL_001D: IL_C2
    IL_001E: IL_F5
    IL_001F: IL_3D
    IL_0024: call 0x0A000008
    IL_0029: call 0x0A000019
    IL_002A: conv.r8
    IL_002B: ldloc.3
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x0400027F
    IL_0035: conv.r8
    IL_0036: ldc.i4.2
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: stloc.0
    IL_003C: ldloca.s 0
    IL_0041: ldfld 0x0A00005C
    IL_0042: IL_22
    IL_0043: ldelem.i
    IL_0044: IL_99
    IL_0045: ldc.i4.3
    IL_0046: IL_BF
    IL_0047: IL_41
    IL_0048: IL_54
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000282
    IL_0052: conv.r8
    IL_0053: IL_F6
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_005B: brfalse IL_00A0
    IL_005C: ldarg.0
    IL_0061: ldfld 0x0400027F
    IL_0062: conv.r8
    IL_0063: IL_44
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: conv.r8
    IL_0068: stloc.0
    IL_0069: nop
    IL_006A: nop
    IL_006B: stloc.0
    IL_0070: call 0x0A000050
    IL_0075: call 0x0A000035
    IL_0076: conv.r8
    IL_0077: ldarg.0
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldc.i4.0
    IL_007C: conv.r8
    IL_0081: brtrue IL_6F0A0082
    IL_0082: stloc.0
    IL_0083: nop
    IL_0084: nop
    IL_0085: stloc.0
    IL_0086: ldc.i4.1
    IL_0087: conv.r8
    IL_0088: stloc.1
    IL_0089: nop
    IL_008A: nop
    IL_008B: stloc.0
    IL_0090: ldstr 0x70000BD5
    IL_0095: call 0x0A000004
    IL_009A: ldstr 0x70000CB5
    IL_009B: conv.r8
    IL_009C: IL_F7
    IL_009D: nop
    IL_009E: nop
    IL_009F: stloc.0
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000280
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x04000280
    IL_00AC: conv.r8
    IL_00AD: ldc.i4.2
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: stloc.0
    IL_00B5: call 0x0A000007
    IL_00B6: IL_22
    IL_00B7: nop
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: IL_3F
    IL_00BF: call 0x0A000008
    IL_00C4: call 0x0A000024
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: IL_3F
    IL_00CA: IL_5A
    IL_00CF: call 0x0A000063
    IL_00D0: conv.r8
    IL_00D1: ldloc.3
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: stloc.0
    IL_00D5: ret
    }

    private void OnGUI() {
    IL_0004: call 0x0A0000D9
    IL_0005: conv.i2
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000D: cpobj 0xDA285B44
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.i2
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0019: ldc.i4 2251588
    IL_001A: nop
    IL_001F: stsfld 0x0076733F
    IL_0020: nop
    IL_0021: stloc.0
    IL_0026: call 0x0A0000F8
    IL_002B: call 0x0A0000DE
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_002F: IL_B9
    IL_0030: IL_43
    IL_0031: IL_22
    IL_0032: nop
    IL_0033: nop
    IL_0034: IL_8F
    IL_0035: IL_43
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_0039: IL_C8
    IL_003A: IL_42
    IL_003B: IL_22
    IL_003C: nop
    IL_003D: nop
    IL_003E: IL_C8
    IL_003F: IL_41
    IL_0044: call 0x0600021D
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000281
    IL_004F: call 0x0A0000E0
    IL_0050: ret
    }

    }}
