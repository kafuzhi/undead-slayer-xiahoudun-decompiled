// Namespace: 
// Type: Bullet_Angel1

    public class Bullet_Angel1 {{

    public object bullet_speed;
    private object mytransform;
    private object mychild;
    private object script_angel;

    public Bullet_Angel1() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_55DFD: switch (87933 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000158
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000AFF
    IL_0016: call 0x0A000077
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_009A
    IL_001D: IL_5A
    IL_001E: IL_01
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0021: ldarg.0
    IL_0026: call 0x0A00000A
    IL_0027: ldc.i4.0
    IL_0028: conv.r8
    IL_0029: stloc.1
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000158
    IL_0033: conv.r8
    IL_0034: IL_B8
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ldc.i4.0
    IL_0039: IL_3E
    IL_003A: ldc.i4.1
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: ldarg.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000158
    IL_0045: ldc.i4.0
    IL_0046: conv.r8
    IL_004B: brtrue IL_6F0A004C
    IL_004C: stloc.2
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0054: stfld 0x04000159
    IL_0055: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000159
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_001C
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000159
    IL_0017: conv.r8
    IL_0018: IL_B9
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000158
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000158
    IL_0012: conv.r8
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000024
    IL_0020: call 0x0A000008
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000157
    IL_002B: call 0x0A000008
    IL_0030: call 0x0A000029
    IL_0031: conv.r8
    IL_0032: ldloc.3
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000158
    IL_003C: conv.r8
    IL_003D: ldc.i4.2
    IL_003E: nop
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: stloc.0
    IL_0043: ldloca.s 0
    IL_0048: ldfld 0x0A000023
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: IL_41
    IL_004F: ldc.i4.1
    IL_0050: nop
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldarg.0
    IL_0058: ldfld 0x0400015A
    IL_0059: conv.r8
    IL_005A: ldloc.2
    IL_005B: nop
    IL_005C: nop
    IL_005D: ldloc.0
    IL_005E: ldarg.0
    IL_0063: call 0x0A00000A
    IL_0064: ldc.i4.0
    IL_0065: conv.r8
    IL_0066: stloc.1
    IL_0067: nop
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: ret
    }

    }}
