// Namespace: 
// Type: SoundEf_UI

    public class SoundEf_UI {{

    public object s_click;

    public SoundEf_UI() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100001E
    IL_000B: stfld 0x0400090C
    IL_000C: ldarg.0
    IL_0011: call 0x0A000001
    IL_0012: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A000090
    IL_0010: ldarg.0
    IL_0015: call 0x0A00002B
    IL_001A: ldstr 0x70022774
    IL_001F: call 0x0A0001C1
    IL_0020: conv.r8
    IL_0021: IL_C9
    IL_0022: IL_01
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ret
    }

    public void SoundOn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: brtrue IL_6F0A000D
    IL_000E: br.s IL_000F
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x0400090C
    IL_0017: ldarg.1
    IL_0018: ldelem.i
    IL_0019: conv.r8
    IL_001A: ldind.ref
    IL_001B: nop
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ret
    }

    public void SetBGM() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_C9
    IL_0009: IL_01
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    private void Update() {
    IL_0000: ret
    }

    }}
