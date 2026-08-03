// Namespace: 
// Type: Shadow

    public class Shadow {{

    private object pickparent;
    private object mytransform;
    private object shadowpos;

    public Shadow() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008CC
    IL_000C: ldarg.0
    IL_0011: call 0x0A00000D
    IL_0012: conv.r8
    IL_0013: neg
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: ldc.i4 2001
    IL_001C: conv.r8
    IL_001D: IL_77
    IL_001E: IL_01
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ret
    }

    public void Pickparent() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040008CB
    IL_0007: ldarg.2
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000F: stsfld 0x0016433F
    IL_0010: nop
    IL_0011: nop
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008CC
    IL_001C: call 0x0A00004B
    IL_001D: ldarg.2
    IL_0022: call 0x0A000008
    IL_0023: conv.r8
    IL_0024: IL_AF
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ret
    }

    public void Finish() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008CC
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_20A112: switch (534592 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008CB
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_0049
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008CB
    IL_0018: conv.r8
    IL_0019: ldc.i4.2
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_0021: stfld 0x040008CD
    IL_0022: ldarg.0
    IL_0027: ldflda 0x040008CD
    IL_0028: ldc.i4.1
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_0032: call 0x0A00001A
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040008CC
    IL_0039: ldarg.0
    IL_003E: ldfld 0x040008CD
    IL_003F: conv.r8
    IL_0040: ldloc.3
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0048: br IL_004F
    IL_0049: ldarg.0
    IL_004E: call 0x06000436
    IL_004F: ret
    }

    }}
