// Namespace: 
// Type: Loading_cha

    public class Loading_cha {{

    public object horseSpine;
    public object horse;
    private object mytransform;

    public Loading_cha() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040007B9
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
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
    IL_001F: call 0x0A00002A
    IL_0024: ldstr 0x70001681
    IL_0025: conv.r8
    IL_0026: IL_3C
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: pop
    IL_002B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040007B9
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040007B7
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
    IL_002F: ldfld 0x040007B9
    IL_0030: ldarg.0
    IL_0035: ldfld 0x040007B8
    IL_0036: conv.r8
    IL_0037: pop
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: conv.r8
    IL_0040: call 0x2A0A0000
    }

    }}
