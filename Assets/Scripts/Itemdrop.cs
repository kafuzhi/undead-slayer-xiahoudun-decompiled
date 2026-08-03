// Namespace: 
// Type: Itemdrop

    public class Itemdrop {{

    private object script_cha;
    private object itemindex;
    private object itemlevel;
    private object mytransform;
    private object myrenderer;
    private object cha1;
    private object maxy;
    private object distime;
    private object drop;

    public Itemdrop() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0003: bne.un.s IL_0037
    IL_0004: conv.ovf.i4.un
    IL_0005: IL_3F
    IL_000A: stfld 0x0400079B
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000798
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0017: stfld 0x04000799
    IL_0018: ldarg.0
    IL_001D: call 0x0A00000D
    IL_001E: conv.r8
    IL_001F: neg
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0027: ldc.i4 4003
    IL_0028: conv.r8
    IL_0029: IL_77
    IL_002A: IL_01
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldarg.0
    IL_0032: ldstr 0x70000001
    IL_0037: call 0x0A000004
    IL_0038: conv.r8
    IL_0039: ldarg.3
    IL_003A: nop
    IL_003B: nop
    IL_003C: stloc.0
    IL_0041: stfld 0x0400079A
    IL_0042: ldarg.0
    IL_0043: ldarg.0
    IL_0048: ldfld 0x0400079A
    IL_0049: conv.r8
    IL_004A: stloc.2
    IL_004B: nop
    IL_004C: nop
    IL_004E: br.s IL_00CC
    IL_004F: IL_95
    IL_0050: ldloc.1
    IL_0051: nop
    IL_0052: ldarg.2
    IL_0053: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    public void Whatsindex() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000796
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_000D: stfld 0x04000797
    IL_000E: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: ldarg.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400079A
    IL_000C: conv.r8
    IL_000D: IL_88
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: brfalse IL_0033
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000795
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000796
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000797
    IL_0028: conv.r8
    IL_0029: IL_8F
    IL_002A: IL_01
    IL_002B: nop
    IL_002C: ldloc.0
    IL_002D: ldarg.0
    IL_0032: call 0x0600036D
    IL_0033: ret
    }

    public void Disappear() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000798
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_000E: ldelem.r8
    IL_20B3: switch (2088 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x0400079C
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x0400079C
    IL_0012: ldarg.0
    IL_0017: ldfld 0x0400079C
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: rem
    IL_001C: IL_41
    IL_001D: IL_43
    IL_001E: stloc.1
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0600036D
    IL_002C: br IL_0076
    IL_002D: ldarg.0
    IL_0032: ldfld 0x0400079C
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_003A: ldc.i4 3752769
    IL_003B: nop
    IL_003C: nop
    IL_003D: ldarg.0
    IL_0042: ldfld 0x0400079C
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_004A: ldc.i4 2251329
    IL_004B: nop
    IL_0050: stsfld 0x00225D40
    IL_0051: nop
    IL_0052: nop
    IL_4563: switch (4419 cases)
    }

    }}
