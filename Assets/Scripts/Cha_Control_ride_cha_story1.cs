// Namespace: 
// Type: Cha_Control_ride_cha_story1

    public class Cha_Control_ride_cha_story1 {{

    public object horseSpine;
    public object horse;
    private object mytransform;
    private object myanimation;

    public Cha_Control_ride_cha_story1() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_000A: call 0x0A000090
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: call 0x0A000002
    IL_0016: stfld 0x04000386
    IL_0017: ldarg.0
    IL_0018: ldarg.0
    IL_001D: call 0x0A00002A
    IL_0022: stfld 0x04000387
    IL_0023: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000387
    IL_000A: ldstr 0x70001681
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0012: bne.un.s IL_0046
    IL_0014: bne.un.s IL_0054
    IL_0015: conv.r8
    IL_0017: bgt.s IL_0018
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000387
    IL_0024: ldstr 0x70001681
    IL_0025: conv.r8
    IL_0026: IL_3C
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: pop
    IL_002B: ret
    }

    public void CrynStop() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000387
    IL_0006: conv.r8
    IL_0009: ldloc 0
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000387
    IL_0015: ldstr 0x70001681
    IL_0016: conv.r8
    IL_0018: bge.s IL_0019
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: IL_22
    IL_001C: stloc.0
    IL_001D: IL_D7
    IL_001E: IL_23
    IL_001F: IL_3E
    IL_0020: conv.r8
    IL_0022: bgt.s IL_0023
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldarg.0
    IL_002A: ldfld 0x04000387
    IL_002F: ldstr 0x70001681
    IL_0030: conv.r8
    IL_0032: bge.s IL_0033
    IL_0033: nop
    IL_0034: stloc.0
    IL_0035: ldc.i4.1
    IL_0036: conv.r8
    IL_003B: ldstr 0x020A0000
    IL_0040: ldfld 0x04000387
    IL_0045: ldstr 0x70001681
    IL_0046: conv.r8
    IL_0047: IL_3C
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: pop
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000387
    IL_0056: ldstr 0x7000168D
    IL_0057: conv.r8
    IL_005C: newobj 0x0A0A0000
    IL_005D: ldloc.0
    IL_005E: ldc.i4.8
    IL_005F: conv.r8
    IL_0064: ldstr 0x060A0000
    IL_0065: IL_22
    IL_0066: ldelem.i
    IL_0067: IL_99
    IL_0068: ldc.i4.3
    IL_0069: IL_3E
    IL_006A: conv.r8
    IL_006C: bgt.s IL_006D
    IL_006D: nop
    IL_006E: stloc.0
    IL_006F: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000386
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000384
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: call 0x0A000007
    IL_0016: IL_22
    IL_001B: ldfld 0x28BDAE14
    IL_001C: ldloc.2
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0024: call 0x0A000029
    IL_0025: conv.r8
    IL_0026: ldloc.3
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x04000386
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000385
    IL_0036: conv.r8
    IL_0037: pop
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: conv.r8
    IL_0040: call 0x2A0A0000
    }

    }}
