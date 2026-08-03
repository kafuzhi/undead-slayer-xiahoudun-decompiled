// Namespace: 
// Type: Ef_blood

    public class Ef_blood {{

    private object index;
    private object oldindex;
    private object starttime;
    private object myrenderer;
    private object mytransform;
    private object size;
    private object offset;
    private object uIndex;
    private object vIndex;

    public Ef_blood() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000584
    IL_0007: ldarg.0
    IL_000C: call 0x0A000001
    IL_000D: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000587
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0017: stfld 0x04000586
    IL_0018: ldarg.0
    IL_001D: call 0x0A0000FA
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0025: stsfld 0x0083283E
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x04000588
    IL_002D: ldarg.0
    IL_0032: call 0x0A00000A
    IL_0033: ldc.i4.0
    IL_0034: conv.r8
    IL_0035: stloc.1
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000587
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: stloc.0
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A000023
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_001A: stsfld 0x0112413F
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_001E: dup
    IL_0023: ldfld 0x04000585
    IL_0028: call 0x0A000024
    IL_0029: IL_58
    IL_002E: stfld 0x04000585
    IL_002F: ldarg.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000585
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_0039: IL_B0
    IL_003A: IL_41
    IL_003B: IL_5A
    IL_003C: not
    IL_0041: stfld 0x04000583
    IL_0042: ldarg.0
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000583
    IL_0049: ldc.i4.4
    IL_004A: mul
    IL_004B: conv.i2
    IL_0050: stfld 0x0400058A
    IL_0051: ldarg.0
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000583
    IL_0058: ldc.i4.4
    IL_0059: add
    IL_005E: stfld 0x0400058B
    IL_005F: ldarg.0
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400058A
    IL_0066: ldarg.0
    IL_006B: ldflda 0x04000588
    IL_0070: ldfld 0x0A000059
    IL_0071: IL_5A
    IL_0072: IL_22
    IL_0073: nop
    IL_0074: nop
    IL_0079: stsfld 0x887C023F
    IL_007A: ldarg.3
    IL_007B: nop
    IL_007C: ldarg.2
    IL_0081: ldfld 0x0A00005A
    IL_0082: IL_59
    IL_0083: ldarg.0
    IL_0088: ldfld 0x0400058B
    IL_0089: conv.i2
    IL_008A: ldarg.0
    IL_008F: ldflda 0x04000588
    IL_0094: ldfld 0x0A00005A
    IL_0095: IL_5A
    IL_0096: IL_59
    IL_009B: newobj 0x0A000038
    IL_00A0: stfld 0x04000589
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000583
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000584
    IL_00B1: beq IL_012F
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x04000583
    IL_00B9: ldc.i4.s 16
    IL_00BA: IL_3F
    IL_00BF: br IL_20000C0
    IL_00C4: ldfld 0x04000587
    IL_00C9: call 0x0A00004B
    IL_00CA: IL_22
    IL_00CB: nop
    IL_00CC: nop
    IL_20A1D1: switch (534592 cases)
    }

    }}
