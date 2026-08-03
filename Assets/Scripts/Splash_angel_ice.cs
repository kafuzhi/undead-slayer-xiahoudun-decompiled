// Namespace: 
// Type: Splash_angel_ice

    public class Splash_angel_ice {{

    private object mytransform;
    private object targetPos;
    private object delay;

    public Splash_angel_ice() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164592960
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
    IL_000B: stfld 0x040009CD
    IL_000C: ldarg.0
    IL_0011: call 0x0A00000A
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164592960
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040009CD
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: stfld 0x040009CE
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040009CE
    IL_0022: stloc.0
    IL_0024: ldloca.s 0
    IL_0025: IL_22
    IL_0026: IL_CD
    IL_0027: IL_CC
    IL_0028: IL_CC
    IL_0029: IL_BE
    IL_002E: stfld 0x0A000023
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040009CD
    IL_0035: ldloc.0
    IL_0036: conv.r8
    IL_0037: ldloc.3
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009CF
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_41
    IL_000C: IL_77
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040009CD
    IL_0016: dup
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000007
    IL_0025: call 0x0A000024
    IL_002A: call 0x0A000008
    IL_002B: IL_22
    IL_002C: nop
    IL_002D: nop
    IL_002E: nop
    IL_20D3: switch (2088 cases)
    }

    }}
