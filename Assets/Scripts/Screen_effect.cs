// Namespace: 
// Type: Screen_effect

    public class Screen_effect {{

    private object mytransform;

    public Screen_effect() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008CA
    IL_000C: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008CA
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_0012: ldtoken 0x00082840
    IL_0013: nop
    IL_0014: stloc.0
    IL_0015: conv.r8
    IL_0016: IL_AF
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008CA
    IL_0006: conv.r8
    IL_000B: cpobj 0x0A0A0000
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A00005E
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_001A: ldc.i4 3424577
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040008CA
    IL_0023: dup
    IL_0024: conv.r8
    IL_0029: cpobj 0x280A0000
    IL_002A: localloc
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_0032: call 0x0A000024
    IL_0037: call 0x0A000008
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_C0
    IL_20E0: switch (2088 cases)
    }

    }}
