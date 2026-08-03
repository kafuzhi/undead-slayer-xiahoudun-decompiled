// Namespace: 
// Type: Bullet_runswing_b06

    public class Bullet_runswing_b06 {{

    public object ef_trail;
    private object mycollider;
    private object disable_delay;
    private object collideron_delay;
    private object current_time;

    public Bullet_runswing_b06() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000003
    IL_000B: stfld 0x040001EE
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: IL_CD
    IL_000F: IL_CC
    IL_0010: IL_4C
    IL_0011: IL_3E
    IL_0016: stfld 0x040001F0
    IL_0017: ldarg.0
    IL_0018: IL_22
    IL_0019: IL_CD
    IL_001A: IL_CC
    IL_001B: IL_CC
    IL_001C: IL_3E
    IL_0021: stfld 0x040001EF
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001ED
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040001EE
    IL_0017: ldc.i4.0
    IL_0018: conv.r8
    IL_001A: ldc.i4.s 0
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0027: stfld 0x040001F1
    IL_0028: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040001F1
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040001F1
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040001F1
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040001EF
    IL_001E: IL_43
    IL_0023: call 0x02000000
    IL_0028: call 0x0A00000A
    IL_0029: ldc.i4.0
    IL_002A: conv.r8
    IL_002B: stloc.1
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040001EE
    IL_0035: ldc.i4.0
    IL_0036: conv.r8
    IL_0038: ldc.i4.s 0
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ldarg.0
    IL_003C: IL_22
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0045: stfld 0x040001F1
    IL_004A: br IL_0068
    IL_004B: ldarg.0
    IL_0050: ldfld 0x040001F1
    IL_0051: ldarg.0
    IL_0056: ldfld 0x040001F0
    IL_0057: IL_43
    IL_0058: stloc.2
    IL_0059: nop
    IL_005A: nop
    IL_005B: nop
    IL_005C: ldarg.0
    IL_0061: ldfld 0x040001EE
    IL_0062: ldc.i4.1
    IL_0063: conv.r8
    IL_0065: ldc.i4.s 0
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ret
    }

    }}
