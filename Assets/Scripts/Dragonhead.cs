// Namespace: 
// Type: Dragonhead

    public class Dragonhead {{

    private object mytransform;
    private object mycollider;
    private object myanimation;
    private object active_delay;
    private object impact;
    public object pt_body;
    public object zwater;
    private object impact_ani;
    public object snd_water;
    public object snd_bite;

    public Dragonhead() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000532
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0013: conv.u4
    IL_0014: IL_35
    IL_0015: nop
    IL_0016: nop
    IL_0017: IL_01
    IL_001C: stfld 0x04000533
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: call 0x0A00002A
    IL_0028: stfld 0x04000534
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000534
    IL_0033: ldstr 0x70002371
    IL_0034: conv.r8
    IL_0036: bge.s IL_0037
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: IL_22
    IL_003A: ldelem.i
    IL_003B: IL_99
    IL_003C: ldc.i4.3
    IL_003D: IL_3E
    IL_003E: conv.r8
    IL_0040: bgt.s IL_0041
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000533
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000534
    IL_0016: ldstr 0x70002371
    IL_0017: conv.r8
    IL_0018: IL_3C
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: pop
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000534
    IL_0028: ldstr 0x70002387
    IL_0029: conv.r8
    IL_002E: newobj 0x7D0A0000
    IL_0033: brfalse IL_2040039
    IL_0038: ldfld 0x04000539
    IL_0039: IL_22
    IL_003A: ldelem.i
    IL_003B: IL_99
    IL_003C: ldc.i4.3
    IL_003D: IL_3E
    IL_003E: conv.r8
    IL_0040: bgt.s IL_0041
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ldarg.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000534
    IL_004E: ldstr 0x70002391
    IL_004F: conv.r8
    IL_0054: newobj 0x7D0A0000
    IL_0059: brfalse IL_204005F
    IL_005E: ldfld 0x04000539
    IL_005F: IL_22
    IL_0060: nop
    IL_0061: nop
    IL_0066: stsfld 0x00306F3E
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: ldarg.0
    IL_006A: ldc.i4.0
    IL_006F: stfld 0x04000536
    IL_0070: ldarg.0
    IL_0075: ldfld 0x04000537
    IL_0076: conv.r8
    IL_0077: IL_B0
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldc.i4.1
    IL_007C: conv.r8
    IL_007D: IL_B6
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ldarg.0
    IL_0086: ldfld 0x04000538
    IL_008B: call 0x0A00004B
    IL_008C: IL_22
    IL_008D: stloc.0
    IL_008E: IL_D7
    IL_008F: stelem.i
    IL_0090: IL_3E
    IL_0095: call 0x0A000008
    IL_0096: conv.r8
    IL_0097: IL_AF
    IL_0098: nop
    IL_0099: nop
    IL_009A: stloc.0
    IL_009B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000534
    IL_000A: ldstr 0x70002391
    IL_000B: conv.r8
    IL_000C: IL_56
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: brfalse IL_01A0
    IL_0015: ldarg.0
    IL_001A: ldfld 0x04000536
    IL_001B: ldc.i4.2
    IL_0020: beq IL_0091
    IL_0021: ldarg.0
    IL_0026: call 0x0A00003D
    IL_0027: dup
    IL_0028: conv.r8
    IL_002B: ldarga 0
    IL_002C: stloc.0
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_0034: stsfld 0x846F5A40
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000533
    IL_0042: call 0x0A000042
    IL_0043: IL_22
    IL_0044: IL_CD
    IL_0045: IL_CC
    IL_0046: IL_CC
    IL_0047: IL_3D
    IL_004C: call 0x0A000008
    IL_004D: conv.r8
    IL_004F: starg.s 1
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000533
    IL_0058: ldc.i4.1
    IL_0059: conv.r8
    IL_005B: ldc.i4.s 0
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ldarg.0
    IL_005F: ldc.i4.2
    IL_0064: stfld 0x04000536
    IL_0065: ldarg.0
    IL_0066: IL_22
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: nop
    IL_006F: stfld 0x04000535
    IL_0070: ldarg.0
    IL_0075: call 0x0A00002B
    IL_0076: ldarg.0
    IL_007B: ldfld 0x0400053B
    IL_007C: conv.r8
    IL_007D: IL_4C
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ldarg.0
    IL_0086: call 0x0A00002B
    IL_0087: conv.r8
    IL_0088: IL_4D
    IL_0089: nop
    IL_008A: nop
    IL_008B: stloc.0
    IL_0090: br IL_0166
    IL_0091: ldarg.0
    IL_0092: dup
    IL_0097: ldfld 0x04000535
    IL_009C: call 0x0A000024
    IL_009D: IL_58
    IL_00A2: stfld 0x04000535
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04000535
    IL_00A9: IL_22
    IL_00AA: nop
    IL_00AB: nop
    IL_14D0DB0: switch (5456704 cases)
    }

    }}
