// Namespace: 
// Type: Map_extreme

    public class Map_extreme {{

    public object trap;

    public Map_extreme() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    public void SetWave() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040007F4
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_0029
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040007F4
    IL_001B: ldstr 0x70022784
    IL_001C: ldarg.1
    IL_001D: ldc.i4.5
    IL_001E: IL_5A
    IL_0023: newobj 0x0100000B
    IL_0024: conv.r8
    IL_0025: IL_CC
    IL_0026: IL_01
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: ret
    }

    public void TrapStop() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040007F4
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_0021
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040007F4
    IL_001B: ldstr 0x70022798
    IL_001C: conv.r8
    IL_001D: IL_CD
    IL_001E: IL_01
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ret
    }

    }}
