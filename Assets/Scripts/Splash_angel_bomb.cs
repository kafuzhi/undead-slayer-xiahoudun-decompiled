// Namespace: 
// Type: Splash_angel_bomb

    public class Splash_angel_bomb {{

    private object mytransform;
    private object targetScale;
    private object delay;
    private object mychild;

    public Splash_angel_bomb() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164330816
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
    IL_000B: stfld 0x040009C9
    IL_000C: ldarg.0
    IL_0011: call 0x0A00000A
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040009C9
    IL_001F: conv.r8
    IL_0024: cpobj 0x7D0A0000
    IL_0025: IL_CA
    IL_0026: ldloc.3
    IL_0027: nop
    IL_0028: ldarg.2
    IL_0029: ldarg.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040009C9
    IL_0030: ldc.i4.0
    IL_0031: conv.r8
    IL_0036: brtrue IL_6F0A0037
    IL_0037: IL_B0
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003F: stfld 0x040009CC
    IL_0040: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x09CB7D3F
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009C9
    IL_0015: call 0x0A00001B
    IL_0016: conv.r8
    IL_0017: IL_AF
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040009CC
    IL_0021: conv.r8
    IL_0022: IL_B1
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009CB
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_41
    IL_000C: conv.i8
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040009C9
    IL_0016: dup
    IL_0017: conv.r8
    IL_001C: cpobj 0x280A0000
    IL_001D: localloc
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: call 0x0A000024
    IL_002A: call 0x0A000008
    IL_002B: IL_22
    IL_002C: nop
    IL_002D: nop
    IL_20A132: switch (534592 cases)
    }

    }}
