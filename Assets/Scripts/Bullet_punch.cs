// Namespace: 
// Type: Bullet_punch

    public class Bullet_punch {{

    public object pt_thrust;
    private object mytransform;
    private object originScale;
    private object growVector;
    private object currentColor;
    private object transColor;
    private object targetColor;
    private object myrenderer;
    private object mymaterial;
    private object mycollider;
    private object script_cha;
    private object efon;
    private object delay;
    private object addforce;
    private object cha1;
    private object enemy;
    private object directionVector;
    private object stepfactor;
    private object upangle;
    private object boom;

    public Bullet_punch() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: IL_3F
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_0096: switch (34 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001DA
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0017: stfld 0x040001E0
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040001E0
    IL_001F: conv.r8
    IL_0021: ldarg.s 0
    IL_0022: nop
    IL_0023: stloc.0
    IL_0028: stfld 0x040001E1
    IL_0029: ldarg.0
    IL_002A: ldarg.0
    IL_002F: call 0x0A000003
    IL_0030: conv.u8
    IL_0031: IL_35
    IL_0032: nop
    IL_0033: nop
    IL_0034: IL_01
    IL_0039: stfld 0x040001E2
    IL_003A: ldarg.0
    IL_003F: ldstr 0x70000001
    IL_0044: call 0x0A000004
    IL_0045: conv.r8
    IL_0046: ldarg.3
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004E: stfld 0x040001E7
    IL_004F: ldarg.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x040001E7
    IL_0056: conv.r8
    IL_0057: ldc.i4.7
    IL_0058: nop
    IL_0059: nop
    IL_005B: br.s IL_00D9
    IL_005C: IL_E3
    IL_005D: IL_01
    IL_005E: nop
    IL_005F: ldarg.2
    IL_0060: ldarg.0
    IL_0065: call 0x0A00000A
    IL_0066: ldc.i4.0
    IL_0067: conv.r8
    IL_0068: stloc.1
    IL_0069: nop
    IL_006A: nop
    IL_006B: stloc.0
    IL_006C: ret
    }

    public void PunchOff() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x01E57D40
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x040001E4
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040001E2
    IL_0018: ldc.i4.0
    IL_0019: conv.r8
    IL_001B: ldc.i4.s 0
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040001E0
    IL_0024: ldc.i4.0
    IL_0025: conv.r8
    IL_002A: beq IL_20A002B
    IL_002F: call 0x0A00000A
    IL_0030: ldc.i4.0
    IL_0031: conv.r8
    IL_0032: stloc.1
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x040001DA
    IL_003C: ldarg.0
    IL_0041: ldfld 0x040001DB
    IL_0042: conv.r8
    IL_0043: IL_AF
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x040001D9
    IL_004D: conv.r8
    IL_004E: IL_B0
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ldc.i4.0
    IL_0053: conv.r8
    IL_0054: IL_B6
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ret
    }

    public void PunchShoot() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x040001E5
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0019: stfld 0x040001E4
    IL_001A: ldarg.0
    IL_001B: ldarg.3
    IL_0020: stfld 0x040001E8
    IL_0021: ldarg.0
    IL_0022: ldarg.2
    IL_0027: stfld 0x040001E6
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040001E2
    IL_002E: ldc.i4.0
    IL_002F: conv.r8
    IL_0031: ldc.i4.s 0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0036: ldarg.s 4
    IL_003B: stfld 0x040001EA
    IL_003C: ldarg.0
    IL_003E: ldarg.s 5
    IL_0043: stfld 0x040001EB
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040001E2
    IL_004B: ldarg.s 6
    IL_004C: conv.r8
    IL_004D: IL_CB
    IL_004E: nop
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: ldarg.0
    IL_0053: ldarg.s 7
    IL_0058: stfld 0x040001EC
    IL_0059: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001E4
    IL_0006: ldc.i4.0
    IL_0007: IL_3E
    IL_0008: IL_50
    IL_0009: ldarg.1
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040001E4
    IL_0012: ldc.i4.1
    IL_08AB: switch (549 cases)
    }

    }}
