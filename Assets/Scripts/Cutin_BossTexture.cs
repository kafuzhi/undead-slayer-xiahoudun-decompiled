// Namespace: 
// Type: Cutin_BossTexture

    public class Cutin_BossTexture {{

    private object starttime;
    private object namepos;
    private object nameimg;
    private object nameon;
    private object language;
    private object cutindex;
    public object basicSkin;

    public Cutin_BossTexture() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000490
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x04000491
    IL_000E: ldarg.0
    IL_0013: call 0x0A000001
    IL_0014: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000490
    IL_0010: ret
    }

    public void SetCutinTexture() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000491
    IL_0007: ldarg.0
    IL_000C: ldflda 0x04000491
    IL_0011: call 0x0A000010
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: call 0x0A00000D
    IL_0019: conv.r8
    IL_001B: ldarg.s 0
    IL_001C: nop
    IL_001D: stloc.0
    IL_0022: ldstr 0x700021F5
    IL_0023: ldloc.0
    IL_0028: call 0x0A000011
    IL_002D: call 0x0A000012
    IL_002E: conv.u8
    IL_002F: IL_01
    IL_0030: nop
    IL_0031: nop
    IL_0032: IL_01
    IL_0033: conv.r8
    IL_0035: ldarga.s 0
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ldarg.0
    IL_003D: ldstr 0x70002211
    IL_003E: ldloc.0
    IL_0043: call 0x0A000011
    IL_0048: call 0x0A000012
    IL_0049: conv.u8
    IL_004A: IL_3C
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_01
    IL_0052: stfld 0x0400048E
    IL_0053: ldarg.0
    IL_0058: call 0x0A000131
    IL_005D: stfld 0x0400048C
    IL_005E: ldarg.0
    IL_005F: ldc.i4.1
    IL_0064: stfld 0x0400048F
    IL_0065: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_C8
    IL_0005: IL_C2
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000D: ldc.i4 19998785
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: ldfld 0x0400048C
    IL_0016: IL_59
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: throw
    IL_001B: IL_44
    IL_001C: IL_5A
    IL_0021: call 0x0A0000C0
    IL_0026: stfld 0x0400048D
    IL_0027: ret
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
    IL_003B: ldfld 0x04000492
    IL_0040: call 0x0A0000DF
    IL_0042: ldc.i4.s -8
    IL_0047: call 0x0A0000EF
    IL_0048: ldarg.0
    IL_004D: ldfld 0x0400048F
    IL_0052: brfalse IL_00C0
    IL_0053: ldarg.0
    IL_0058: ldfld 0x0400048D
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005E: ldloc 8771
    IL_005F: nop
    IL_0060: nop
    IL_0063: ldloc 8771
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_C8
    IL_0067: IL_42
    IL_006C: call 0x0600021D
    IL_006D: ldarg.0
    IL_0072: ldfld 0x0400048E
    IL_0077: call 0x0A0000E0
    IL_0078: ldarg.0
    IL_007D: ldfld 0x0400048D
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0085: ldc.i4 2250818
    IL_0086: nop
    IL_0087: IL_93
    IL_0088: IL_43
    IL_0089: IL_22
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: IL_43
    IL_008E: IL_22
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_C0
    IL_0092: IL_41
    IL_0097: call 0x0600021D
    IL_009C: ldsfld 0x040007B2
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x04000490
    IL_00A4: ldc.i4.s 74
    IL_00A5: ldarg.0
    IL_00AA: ldfld 0x04000491
    IL_00AB: IL_58
    IL_00B0: call 0x0A0000E1
    IL_00B5: ldstr 0x70002225
    IL_00BA: call 0x0A0000E2
    IL_00BF: call 0x0A0000E3
    IL_00C0: ret
    }

    }}
