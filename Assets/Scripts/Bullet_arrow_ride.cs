// Namespace: 
// Type: Bullet_arrow_ride

    public class Bullet_arrow_ride {{

    public object bullet_speed;
    private object mytransform;
    private object cha1;
    private object script_cha;

    public Bullet_arrow_ride() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000185
    IL_000C: ret
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
    IL_0014: stfld 0x04000186
    IL_0015: ldarg.0
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000186
    IL_001C: conv.r8
    IL_001E: starg.s 0
    IL_001F: nop
    IL_0021: br.s IL_009F
    IL_0022: IL_87
    IL_0023: IL_01
    IL_0024: nop
    IL_0025: ldarg.2
    IL_0026: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: ldarg.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000186
    IL_000C: conv.r8
    IL_000D: IL_88
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: brfalse IL_0047
    IL_0016: ldarg.0
    IL_001B: call 0x0A00000A
    IL_001C: ldc.i4.0
    IL_001D: conv.r8
    IL_001E: stloc.1
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000185
    IL_002C: call 0x0A00004B
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_20A138: switch (534593 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000185
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000185
    IL_0012: conv.r8
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000024
    IL_0020: call 0x0A000008
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000184
    IL_002B: call 0x0A000008
    IL_0030: call 0x0A000029
    IL_0031: conv.r8
    IL_0032: ldloc.3
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ret
    }

    }}
