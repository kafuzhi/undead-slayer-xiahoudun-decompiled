// Namespace: 
// Type: SpiritSword_p

    public class SpiritSword_p {{

    private object fireon;
    private object mytransform;
    private object target;
    private object targetpos;
    private object directionVector;
    private object dt;
    private object mycollider;
    private object mytrail;

    public SpiritSword_p() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009AE
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040009B3
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x2B00004A
    IL_0023: stfld 0x040009B4
    IL_0024: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009AE
    IL_000A: call 0x0A000062
    IL_000F: call 0x0A000007
    IL_0014: call 0x0A000029
    IL_0015: conv.r8
    IL_0016: IL_AF
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x040009B3
    IL_0020: ldc.i4.0
    IL_0021: conv.r8
    IL_0023: ldc.i4.s 0
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_0030: stfld 0x040009B2
    IL_0031: ret
    }

    public void FireSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009B3
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040009AE
    IL_0012: ldnull
    IL_0013: conv.r8
    IL_0014: IL_4E
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_0019: ldc.i4.1
    IL_001E: stfld 0x040009AD
    IL_001F: ldarg.0
    IL_0020: ldarg.1
    IL_0025: stfld 0x040009AF
    IL_0026: ldarg.0
    IL_002B: ldfld 0x040009B4
    IL_002C: ldc.i4.1
    IL_002D: conv.r8
    IL_0032: beq IL_2A0A0033
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009AD
    IL_000A: brfalse IL_0144
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009AE
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0024: IL_EC
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040009B2
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0035: ldc.i4 1589569
    IL_0036: nop
    IL_0037: nop
    IL_0038: ldarg.0
    IL_0039: dup
    IL_003E: ldfld 0x040009B2
    IL_0043: call 0x0A000024
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_0047: ldelem.r8
    IL_2C9F561B4: switch (2994559066 cases)
    }

    }}
