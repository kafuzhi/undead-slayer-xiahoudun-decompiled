// Namespace: 
// Type: ChildActive

    public class ChildActive {{

    private object firstchild;

    public ChildActive() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_0007: ldc.i4.0
    IL_0008: conv.r8
    IL_000D: brtrue IL_7D0A000E
    IL_000E: ldc.i4.0
    IL_000F: ldarg.2
    IL_0010: nop
    IL_0011: ldarg.2
    IL_0012: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000416
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
    IL_0011: ret
    }

    }}
