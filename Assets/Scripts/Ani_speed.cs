// Namespace: 
// Type: Ani_speed

    public class Ani_speed {{

    public object aniname;
    public object speed;

    public Ani_speed() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: stloc.0
    IL_0003: IL_D7
    IL_0004: IL_23
    IL_0005: IL_3D
    IL_000A: stfld 0x04000138
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000137
    IL_000C: conv.r8
    IL_000E: bge.s IL_000F
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000138
    IL_0017: conv.r8
    IL_0019: bgt.s IL_001A
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ret
    }

    }}
