// Namespace: 
// Type: Obj_Pocket

    public class Obj_Pocket {{

    private object mytransform;
    private object hand;
    private object pick;

    public Obj_Pocket() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000843
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000843
    IL_0016: call 0x0A00001B
    IL_0017: conv.r8
    IL_0018: IL_AF
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ret
    }

    public void PickPocket() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70022904
    IL_000A: call 0x0A000077
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x04000844
    IL_0015: ldarg.0
    IL_0016: ldc.i4.1
    IL_001B: stfld 0x04000845
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000843
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000844
    IL_0028: conv.r8
    IL_0029: ldc.i4.2
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: conv.r8
    IL_002E: ldloc.3
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000843
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000844
    IL_003E: conv.r8
    IL_003F: IL_4E
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000845
    IL_000A: brfalse IL_0050
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000843
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000843
    IL_0017: conv.r8
    IL_001C: cpobj 0x280A0000
    IL_001D: localloc
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: IL_22
    IL_0022: ldelem.i
    IL_0023: IL_99
    IL_0024: ldc.i4.3
    IL_0025: IL_3F
    IL_002A: call 0x0A000008
    IL_002F: call 0x0A000024
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_E0
    IL_18CA1A0: switch (6498394 cases)
    }

    }}
