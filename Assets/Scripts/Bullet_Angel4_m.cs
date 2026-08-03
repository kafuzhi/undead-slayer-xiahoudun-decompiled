// Namespace: 
// Type: Bullet_Angel4_m

    public class Bullet_Angel4_m {{

    private object bullet_speed;
    private object side_speed;
    private object mytransform;
    private object originScale;
    private object myPos;
    private object dir;
    private object sidedir;
    private object side;

    public Bullet_Angel4_m() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x01717DBF
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000173
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000173
    IL_0013: conv.r8
    IL_0018: cpobj 0x7D0A0000
    IL_0019: conv.u4
    IL_001A: IL_01
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ldarg.0
    IL_0022: call 0x0A00000A
    IL_0023: ldc.i4.0
    IL_0024: conv.r8
    IL_0025: stloc.1
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000173
    IL_000A: call 0x0A00001B
    IL_000B: conv.r8
    IL_000C: IL_AF
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_C0
    IL_001A: stfld 0x04000171
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: IL_CD
    IL_001E: IL_CC
    IL_001F: IL_4C
    IL_0020: IL_3E
    IL_0021: IL_22
    IL_0022: IL_CD
    IL_0023: IL_CC
    IL_0024: IL_CC
    IL_0025: IL_BD
    IL_0026: IL_22
    IL_0027: IL_CD
    IL_0028: IL_CC
    IL_0029: IL_CC
    IL_002A: IL_3D
    IL_002F: call 0x0A000075
    IL_0030: IL_58
    IL_0035: stfld 0x04000172
    IL_0036: ldarg.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000173
    IL_003D: conv.r8
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0046: stfld 0x04000176
    IL_0047: ldarg.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000173
    IL_004E: conv.r8
    IL_004F: mul
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000178
    IL_0059: conv.i2
    IL_005E: call 0x0A000008
    IL_0063: stfld 0x04000177
    IL_0064: ret
    }

    public void Init() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000178
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000173
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x04000175
    IL_0011: ldarg.0
    IL_0012: dup
    IL_0017: ldfld 0x04000171
    IL_001C: call 0x0A000024
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_C0
    IL_1C5F5618D: switch (1904040026 cases)
    }

    }}
