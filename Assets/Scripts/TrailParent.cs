// Namespace: 
// Type: TrailParent

    public class TrailParent {{

    private object parent_cha;
    private object mytransform;

    public TrailParent() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A51
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000001
    IL_0016: call 0x0A000004
    IL_0017: conv.r8
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: stfld 0x04000A50
    IL_0021: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A51
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A50
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: ldloc.3
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ret
    }

    }}
