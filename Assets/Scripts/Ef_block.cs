// Namespace: 
// Type: Ef_block

    public class Ef_block {{

    private object mytransform;

    public Ef_block() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000582
    IL_000C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000582
    IL_0006: conv.r8
    IL_000B: cpobj 0x0A0A0000
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A00005E
    IL_0013: IL_22
    IL_0015: bne.un.s IL_0049
    IL_0016: conv.ovf.i4.un
    IL_0017: IL_3F
    IL_0018: IL_41
    IL_0019: IL_34
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000582
    IL_0023: dup
    IL_0024: conv.r8
    IL_0029: cpobj 0x280A0000
    IL_002A: localloc
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_20D6: switch (2088 cases)
    }

    }}
