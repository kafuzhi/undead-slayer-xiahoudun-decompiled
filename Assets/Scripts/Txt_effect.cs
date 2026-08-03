// Namespace: 
// Type: Txt_effect

    public class Txt_effect {{

    private object mymaterial;
    private object mytransform;
    private object startscale;
    private object targetscale;
    private object finish_delay;
    private object isdelay;

    public Txt_effect() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x00002240
    IL_000D: stsfld 0x0000223F
    IL_000E: nop
    IL_000F: nop
    IL_0014: newobj 0x0A000076
    IL_0019: stfld 0x04000A6F
    IL_001A: ldarg.0
    IL_001F: call 0x0A000001
    IL_0020: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_0007: conv.r8
    IL_0008: neg
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x04000A6C
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: call 0x0A000002
    IL_001C: stfld 0x04000A6D
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000A6D
    IL_0024: conv.r8
    IL_0029: cpobj 0x7D0A0000
    IL_002A: conv.r4
    IL_002B: stloc.0
    IL_002C: nop
    IL_002D: ldarg.2
    IL_002E: ret
    }

    public void TxtEfOn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A6D
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A6E
    IL_0018: conv.r8
    IL_0019: IL_AF
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0027: stfld 0x04000A70
    IL_0028: ldarg.1
    IL_0029: ldc.i4.2
    IL_008A: switch (23 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000A70
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04000A70
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A70
    IL_0018: IL_22
    IL_001A: bne.un.s IL_004E
    IL_001C: bne.un.s IL_005C
    IL_001D: IL_43
    IL_001F: ldloc.s 0
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_0032: br IL_0097
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000A71
    IL_003D: brfalse IL_006B
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000A70
    IL_0044: IL_22
    IL_0045: IL_CD
    IL_0046: IL_CC
    IL_0047: IL_4C
    IL_0048: IL_3E
    IL_0049: IL_43
    IL_004A: ldc.i4.2
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000A6D
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000A6E
    IL_005A: conv.r8
    IL_005B: IL_AF
    IL_005C: nop
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: ldarg.0
    IL_0060: ldc.i4.0
    IL_0065: stfld 0x04000A71
    IL_006A: br IL_0097
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04000A6D
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000A6D
    IL_0077: conv.r8
    IL_007C: cpobj 0x020A0000
    IL_0081: ldfld 0x04000A6F
    IL_0086: call 0x0A000024
    IL_0087: IL_22
    IL_0088: nop
    IL_0089: nop
    IL_008E: cpobj 0x63285A41
    IL_008F: nop
    IL_0090: nop
    IL_0091: stloc.0
    IL_0092: conv.r8
    IL_0093: IL_AF
    IL_0094: nop
    IL_0095: nop
    IL_0096: stloc.0
    IL_0097: ret
    }

    }}
