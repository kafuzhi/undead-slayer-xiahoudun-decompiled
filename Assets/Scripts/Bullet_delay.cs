// Namespace: 
// Type: Bullet_delay

    public class Bullet_delay {{

    public object show_delay;
    public object disable_delay;
    private object current_time;
    private object mycollider;
    private object renderOn;
    private object myrenderer;
    private object mytransform;
    private object originscale;

    public Bullet_delay() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001A2
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x0400019F
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040001A2
    IL_001F: conv.r8
    IL_0024: cpobj 0x7D0A0000
    IL_0025: stelem.i
    IL_0026: IL_01
    IL_0027: nop
    IL_0028: ldarg.2
    IL_0029: ldarg.0
    IL_002E: ldfld 0x040001A2
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040001A3
    IL_0035: IL_22
    IL_0036: IL_CD
    IL_0037: IL_CC
    IL_0038: IL_CC
    IL_0039: IL_3D
    IL_003E: call 0x0A000008
    IL_003F: conv.r8
    IL_0040: IL_AF
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldarg.0
    IL_0049: call 0x0A00000D
    IL_004E: call 0x0A00004A
    IL_0053: brfalse IL_0065
    IL_0054: ldarg.0
    IL_0055: ldarg.0
    IL_005A: call 0x0A00000D
    IL_005F: stfld 0x040001A1
    IL_0064: br IL_006C
    IL_0065: ldarg.0
    IL_0066: ldc.i4.1
    IL_006B: stfld 0x040001A0
    IL_006C: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x0400019E
    IL_000B: ldarg.0
    IL_0010: call 0x0A00000D
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0017: beq IL_20A0018
    IL_001C: ldfld 0x0400019F
    IL_001D: ldc.i4.0
    IL_001E: conv.r8
    IL_0020: ldc.i4.s 0
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x0400019E
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x0400019E
    IL_0012: ldarg.0
    IL_0017: ldfld 0x0400019E
    IL_0018: ldarg.0
    IL_001D: ldfld 0x0400019D
    IL_001E: IL_44
    IL_001F: IL_56
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: ldarg.0
    IL_0028: call 0x0A00000A
    IL_0029: ldc.i4.0
    IL_002A: conv.r8
    IL_002B: stloc.1
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_002F: ldarg.0
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0039: stfld 0x0400019E
    IL_003A: ldarg.0
    IL_003B: ldc.i4.0
    IL_0040: stfld 0x040001A0
    IL_0041: ldarg.0
    IL_0046: call 0x0A00000D
    IL_0047: ldc.i4.0
    IL_0048: conv.r8
    IL_004D: beq IL_20A004E
    IL_0052: ldfld 0x0400019F
    IL_0053: ldc.i4.0
    IL_0054: conv.r8
    IL_0056: ldc.i4.s 0
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x040001A2
    IL_005F: ldarg.0
    IL_0064: ldfld 0x040001A3
    IL_0065: IL_22
    IL_0066: IL_CD
    IL_0067: IL_CC
    IL_0068: IL_CC
    IL_0069: IL_3D
    IL_006E: call 0x0A000008
    IL_006F: conv.r8
    IL_0070: IL_AF
    IL_0071: nop
    IL_0072: nop
    IL_0073: stloc.0
    IL_0078: br IL_011B
    IL_0079: ldarg.0
    IL_007E: ldfld 0x040001A0
    IL_0083: brfalse IL_00DB
    IL_0084: ldarg.0
    IL_0089: ldfld 0x040001A2
    IL_008A: conv.r8
    IL_008F: cpobj 0x0A0A0000
    IL_0091: ldloca.s 0
    IL_0096: ldfld 0x0A00005E
    IL_0097: ldarg.0
    IL_009C: ldflda 0x040001A3
    IL_00A1: ldfld 0x0A00005E
    IL_00A2: IL_41
    IL_00A4: bge.s IL_00A5
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x040001A2
    IL_00AD: dup
    IL_00AE: conv.r8
    IL_00B3: cpobj 0x280A0000
    IL_00B4: localloc
    IL_00B5: nop
    IL_00B6: nop
    IL_00B7: stloc.0
    IL_00BC: call 0x0A000024
    IL_00C1: call 0x0A000008
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C9: stsfld 0x00082840
    IL_00CA: nop
    IL_00CB: stloc.0
    IL_00D0: call 0x0A000029
    IL_00D1: conv.r8
    IL_00D2: IL_AF
    IL_00D3: nop
    IL_00D4: nop
    IL_00D5: stloc.0
    IL_00DA: br IL_011B
    IL_00DB: ldarg.0
    IL_00E0: ldfld 0x0400019E
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x0400019C
    IL_00E7: IL_44
    IL_00E9: bge.s IL_00EA
    IL_00EA: nop
    IL_00EB: nop
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x0400019F
    IL_00F2: ldc.i4.1
    IL_00F3: conv.r8
    IL_00F5: ldc.i4.s 0
    IL_00F6: nop
    IL_00F7: stloc.0
    IL_00F8: ldarg.0
    IL_00FD: ldfld 0x040001A1
    IL_0102: call 0x0A00004A
    IL_0107: brfalse IL_011B
    IL_0108: ldarg.0
    IL_010D: ldfld 0x040001A1
    IL_010E: ldc.i4.1
    IL_010F: conv.r8
    IL_0114: beq IL_20A0115
    IL_0115: ldc.i4.1
    IL_011A: stfld 0x040001A0
    IL_011B: ret
    }

    }}
