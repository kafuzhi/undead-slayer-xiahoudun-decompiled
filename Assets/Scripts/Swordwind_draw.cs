// Namespace: 
// Type: Swordwind_draw

    public class Swordwind_draw {{

    private object current_delay;
    public object startdelay;
    private object myrenderer;
    private object show;

    public Swordwind_draw() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_000B: stfld 0x040009EE
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009EE
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: beq IL_2A0A000D
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040009EF
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x040009EC
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040009EE
    IL_0018: ldc.i4.0
    IL_0019: conv.r8
    IL_001E: beq IL_2A0A001F
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040009EC
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040009EC
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040009EF
    IL_001C: brtrue IL_004C
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040009EC
    IL_0023: ldarg.0
    IL_0028: ldfld 0x040009ED
    IL_0029: IL_43
    IL_002A: ldc.i4.8
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040009EE
    IL_0034: ldc.i4.1
    IL_0035: conv.r8
    IL_003A: beq IL_20A003B
    IL_003B: ldc.i4.1
    IL_0040: stfld 0x040009EF
    IL_0041: ldarg.0
    IL_0042: IL_22
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_004B: stfld 0x040009EC
    IL_004C: ret
    }

    }}
