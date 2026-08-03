// Namespace: 
// Type: Ef_split1

    public class Ef_split1 {{

    private object destroydelay;
    private object alphadelay;
    private object mymesh;
    private object p_color;
    private object mytransform;
    private object temp;

    public Ef_split1() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00017C
    IL_000A: stfld 0x040005F6
    IL_000B: ldarg.0
    IL_000C: ldc.i4.4
    IL_0011: newarr 0x01000034
    IL_0016: stfld 0x040005F8
    IL_0017: ldarg.0
    IL_001C: call 0x0A000001
    IL_001D: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040005F7
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000016
    IL_0013: conv.r8
    IL_0014: IL_A9
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x040005F5
    IL_001D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    public void FinishNow() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: ldelem.r8
    IL_17CDFD: switch (390013 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040005F3
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040005F3
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040005F3
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001F: stsfld 0x007A4340
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040005F7
    IL_002C: call 0x0A00004B
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_20A134: switch (534592 cases)
    }

    }}
