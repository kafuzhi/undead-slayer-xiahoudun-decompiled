// Namespace: 
// Type: Tank_Destroy

    public class Tank_Destroy {{

    private object delay;
    private object fogon;
    private object myanimation;
    public object pt_fog;

    public Tank_Destroy() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00002A
    IL_000B: stfld 0x04000A07
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A07
    IL_0016: ldstr 0x70022FE1
    IL_0017: conv.r8
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: stsfld 0x00306F3E
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A08
    IL_0006: conv.r8
    IL_0007: IL_B0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: IL_B6
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_001B: stfld 0x04000A05
    IL_001C: ldarg.0
    IL_001D: ldc.i4.1
    IL_0022: stfld 0x04000A06
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000A07
    IL_0029: conv.r8
    IL_002C: ldloc 0
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000A07
    IL_0038: ldstr 0x70022FE1
    IL_0039: conv.r8
    IL_003A: IL_3C
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: pop
    IL_003F: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A05
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000D: ldc.i4 2507584
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: call 0x0A000002
    IL_001A: call 0x0A000007
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_C8
    IL_001F: IL_41
    IL_0024: call 0x0A000008
    IL_0025: conv.r8
    IL_0026: ldloc.3
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: call 0x0A00000A
    IL_0030: ldc.i4.0
    IL_0031: conv.r8
    IL_0032: stloc.1
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000A05
    IL_003C: IL_22
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: IL_3F
    IL_0041: IL_43
    IL_0042: IL_23
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: ldarg.0
    IL_004B: ldfld 0x04000A06
    IL_0050: brfalse IL_0069
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000A08
    IL_0057: conv.r8
    IL_0058: IL_B0
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ldc.i4.0
    IL_005D: conv.r8
    IL_005E: IL_B6
    IL_005F: nop
    IL_0060: nop
    IL_0061: stloc.0
    IL_0062: ldarg.0
    IL_0063: ldc.i4.0
    IL_0068: stfld 0x04000A06
    IL_0069: ldarg.0
    IL_006A: dup
    IL_006F: ldfld 0x04000A05
    IL_0074: call 0x0A000024
    IL_0075: IL_58
    IL_007A: stfld 0x04000A05
    IL_007B: ret
    }

    }}
