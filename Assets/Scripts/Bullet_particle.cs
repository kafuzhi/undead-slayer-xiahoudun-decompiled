// Namespace: 
// Type: Bullet_particle

    public class Bullet_particle {{

    public object start_delay;
    public object active_delay;
    public object disable_delay;
    private object current_time;
    private object myemitter;
    private object mycollider;
    private object colliderexist;

    public Bullet_particle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A0000B0
    IL_000B: stfld 0x040001D1
    IL_000C: ldarg.0
    IL_0011: call 0x0A000003
    IL_0016: call 0x0A00004A
    IL_001B: brfalse IL_002F
    IL_001C: ldarg.0
    IL_001D: ldarg.0
    IL_0022: call 0x0A000003
    IL_0027: stfld 0x040001D2
    IL_0028: ldarg.0
    IL_0029: ldc.i4.1
    IL_002E: stfld 0x040001D3
    IL_002F: ldarg.0
    IL_0034: call 0x0A00000A
    IL_0035: ldc.i4.0
    IL_0036: conv.r8
    IL_0037: stloc.1
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x040001D0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040001D1
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0013: IL_B6
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040001D3
    IL_0021: brfalse IL_002E
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040001D2
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002B: ldc.i4.s 0
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040001D0
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040001D0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040001D0
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040001CF
    IL_001E: IL_44
    IL_001F: stloc.2
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
    IL_0034: ldfld 0x040001D0
    IL_0035: ldarg.0
    IL_003A: ldfld 0x040001CE
    IL_003B: IL_44
    IL_0040: call 0x02000000
    IL_0045: ldfld 0x040001D1
    IL_0046: ldc.i4.0
    IL_0047: conv.r8
    IL_0048: IL_B6
    IL_0049: nop
    IL_004A: nop
    IL_004B: stloc.0
    IL_004C: ldarg.0
    IL_0051: ldfld 0x040001D3
    IL_0056: brfalse IL_0063
    IL_0057: ldarg.0
    IL_005C: ldfld 0x040001D2
    IL_005D: ldc.i4.0
    IL_005E: conv.r8
    IL_0060: ldc.i4.s 0
    IL_0061: nop
    IL_0062: stloc.0
    IL_0067: br IL_009C
    IL_0068: ldarg.0
    IL_006D: ldfld 0x040001D0
    IL_006E: ldarg.0
    IL_0073: ldfld 0x040001CD
    IL_0074: IL_44
    IL_0075: IL_23
    IL_0076: nop
    IL_0077: nop
    IL_0078: nop
    IL_0079: ldarg.0
    IL_007E: ldfld 0x040001D1
    IL_007F: ldc.i4.1
    IL_0080: conv.r8
    IL_0081: IL_B6
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0085: ldarg.0
    IL_008A: ldfld 0x040001D3
    IL_008F: brfalse IL_009C
    IL_0090: ldarg.0
    IL_0095: ldfld 0x040001D2
    IL_0096: ldc.i4.1
    IL_0097: conv.r8
    IL_0099: ldc.i4.s 0
    IL_009A: nop
    IL_009B: stloc.0
    IL_009C: ret
    }

    }}
