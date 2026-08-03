// Namespace: 
// Type: SpiritSword_p3

    public class SpiritSword_p3 {{

    private object fireon;
    private object mytransform;
    private object target;
    private object myparent;
    private object targetpos;
    private object directionVector;
    private object f_speed;
    private object mycollider;
    private object mytrail;
    private object n_pos;
    private object finish;

    public SpiritSword_p3() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009BF
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040009C5
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x2B00004A
    IL_0023: stfld 0x040009C6
    IL_0024: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040009C8
    IL_0007: ldarg.0
    IL_000C: ldfld 0x040009C5
    IL_000D: ldc.i4.0
    IL_000E: conv.r8
    IL_0010: ldc.i4.s 0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: IL_CD
    IL_0016: IL_CC
    IL_0017: IL_CC
    IL_0018: IL_3E
    IL_001D: stfld 0x040009C4
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040009C6
    IL_0024: ldc.i4.1
    IL_0025: conv.r8
    IL_002A: beq IL_2A0A002B
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040009BF
    IL_0007: conv.r8
    IL_0008: IL_CD
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x040009C1
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040009BF
    IL_0017: ldnull
    IL_0018: conv.r8
    IL_0019: IL_4E
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ret
    }

    public void FireSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009C5
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x040009C0
    IL_0013: ldarg.0
    IL_0014: ldarg.0
    IL_0019: ldfld 0x040009C0
    IL_001A: conv.r8
    IL_001B: ldc.i4.2
    IL_001C: nop
    IL_001D: nop
    IL_001E: stloc.0
    IL_0023: stfld 0x040009C2
    IL_0024: ldarg.0
    IL_0025: ldarg.0
    IL_002A: ldfld 0x040009C2
    IL_002B: ldarg.0
    IL_0030: ldfld 0x040009BF
    IL_0031: conv.r8
    IL_0032: ldc.i4.2
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_003A: call 0x0A000019
    IL_003F: stfld 0x040009C3
    IL_0040: ldarg.0
    IL_0045: ldflda 0x040009C3
    IL_0046: ldc.i4.1
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_0050: call 0x0A00001A
    IL_0051: ldarg.0
    IL_0056: ldfld 0x040009C3
    IL_005B: call 0x0A00001B
    IL_0060: call 0x0A00001C
    IL_0065: brfalse IL_0077
    IL_0066: ldarg.0
    IL_006B: ldfld 0x040009BF
    IL_006C: ldarg.0
    IL_0071: ldfld 0x040009C3
    IL_0072: conv.r8
    IL_0077: ldc.i4 34209792
    IL_0078: IL_22
    IL_0079: IL_CD
    IL_007A: IL_CC
    IL_007B: IL_CC
    IL_007C: IL_3E
    IL_0081: stfld 0x040009C4
    IL_0082: ldarg.0
    IL_0083: ldc.i4.1
    IL_0088: stfld 0x040009BE
    IL_0089: ret
    }

    public void FinishSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009C5
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldc.i4.0
    IL_0012: stfld 0x040009BE
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: nop
    IL_001D: stfld 0x040009C4
    IL_001E: ldarg.0
    IL_001F: ldc.i4.1
    IL_0024: stfld 0x040009C8
    IL_0025: ret
    }

    public void SetPos() {
    IL_0000: ldarg.1
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0005: ldarg 4
    IL_0006: nop
    IL_0007: nop
    IL_0008: ldarg.3
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000D: beq.s IL_000E
    IL_000E: nop
    IL_000F: nop
    IL_0010: IL_57
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0018: stsfld 0x38000000
    IL_0019: IL_A4
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0025: stsfld 0x0000223F
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002F: stsfld 0x0076733F
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: IL_22
    IL_0033: IL_B8
    IL_0034: ldc.i4.8
    IL_0035: ldarg.3
    IL_0036: IL_3E
    IL_003B: call 0x0A000008
    IL_0040: stfld 0x040009C7
    IL_0045: br IL_00C1
    IL_0046: ldarg.0
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004E: stsfld 0x0000223F
    IL_004F: nop
    IL_0050: nop
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0058: stsfld 0x007673BF
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: IL_22
    IL_005C: IL_B8
    IL_005D: ldc.i4.8
    IL_005E: ldarg.3
    IL_005F: IL_3E
    IL_0064: call 0x0A000008
    IL_0069: stfld 0x040009C7
    IL_006E: br IL_00C1
    IL_006F: ldarg.0
    IL_0070: IL_22
    IL_0071: nop
    IL_0072: nop
    IL_0077: stsfld 0x000022BF
    IL_0078: nop
    IL_0079: nop
    IL_007A: IL_22
    IL_007B: nop
    IL_007C: nop
    IL_0081: stsfld 0x0076733F
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: IL_22
    IL_0085: IL_B8
    IL_0086: ldc.i4.8
    IL_0087: ldarg.3
    IL_0088: IL_3E
    IL_008D: call 0x0A000008
    IL_0092: stfld 0x040009C7
    IL_0097: br IL_00C1
    IL_0098: ldarg.0
    IL_0099: IL_22
    IL_009A: nop
    IL_009B: nop
    IL_00A0: stsfld 0x000022BF
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: IL_22
    IL_00A4: nop
    IL_00A5: nop
    IL_00AA: stsfld 0x007673BF
    IL_00AB: nop
    IL_00AC: stloc.0
    IL_00AD: IL_22
    IL_00AE: IL_B8
    IL_00AF: ldc.i4.8
    IL_00B0: ldarg.3
    IL_00B1: IL_3E
    IL_00B6: call 0x0A000008
    IL_00BB: stfld 0x040009C7
    IL_00C0: br IL_00C1
    IL_00C1: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009C8
    IL_000A: brfalse IL_0081
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009BF
    IL_0011: dup
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000007
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_20A123: switch (534592 cases)
    }

    }}
