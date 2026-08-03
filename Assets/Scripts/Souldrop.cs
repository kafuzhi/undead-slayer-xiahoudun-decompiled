// Namespace: 
// Type: Souldrop

    public class Souldrop {{

    private object cha1;
    private object mytransform;
    private object directionVector;
    private object targetVector;
    private object mycollider;
    private object rotate;
    private object finish_delay;

    public Souldrop() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x090B7D40
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
    IL_000B: stfld 0x04000906
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000909
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x04000905
    IL_0015: ldarg.0
    IL_001A: call 0x0A00000A
    IL_001B: ldc.i4.0
    IL_001C: conv.r8
    IL_001D: stloc.1
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000007
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_20AE: switch (2088 cases)
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000C: ldc.i4.s 15
    IL_0109: switch (62 cases)
    }

    public void Finish() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000906
    IL_0016: call 0x0A00004B
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldloc.2
    IL_001B: IL_42
    IL_0020: call 0x0A000008
    IL_0021: conv.r8
    IL_0022: ldloc.3
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400090B
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_41
    IL_000C: ldc.i4.0
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: call 0x060004E3
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001E: stsfld 0x090B7D40
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0025: br IL_0059
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400090B
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_450533: switch (1130816 cases)
    }

    }}
