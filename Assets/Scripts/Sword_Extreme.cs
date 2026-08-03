// Namespace: 
// Type: Sword_Extreme

    public class Sword_Extreme {{

    private object delay;
    private object efOn;
    private object mytransform;
    private object cha1;
    private object mycollider;
    private object startPos;

    public Sword_Extreme() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009E8
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000001
    IL_0016: call 0x0A000004
    IL_0017: conv.r8
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: stfld 0x040009E9
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: call 0x0A000003
    IL_002C: stfld 0x040009EA
    IL_002D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_C0
    IL_0005: IL_3F
    IL_000A: stfld 0x040009E6
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x040009E7
    IL_0012: ldarg.0
    IL_0017: call 0x0A00000A
    IL_0019: ldc.i4.s 16
    IL_001A: conv.r8
    IL_001B: ldc.i4.m1
    IL_001C: nop
    IL_001D: nop
    IL_001E: stloc.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040009EA
    IL_0025: ldc.i4.1
    IL_0026: conv.r8
    IL_0028: ldc.i4.s 0
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x040009E8
    IL_0032: conv.r8
    IL_0033: ldc.i4.2
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: stfld 0x040009EB
    IL_003C: ret
    }

    public void SetPower() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00003D
    IL_0006: ldarg.1
    IL_0007: conv.i2
    IL_0008: IL_22
    IL_0009: IL_CD
    IL_000A: IL_CC
    IL_000B: IL_CC
    IL_000C: IL_3E
    IL_000D: IL_5A
    IL_000E: conv.i2
    IL_000F: conv.r8
    IL_0010: IL_84
    IL_0011: nop
    IL_0012: nop
    IL_0013: stloc.0
    IL_0014: ret
    }

    private void ColliderOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009EA
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040009EA
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040009E6
    IL_000B: call 0x0A000024
    IL_000C: IL_59
    IL_0011: stfld 0x040009E6
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040009E6
    IL_0018: conv.i4
    IL_0019: IL_23
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_F8
    IL_0021: IL_BF
    IL_0022: IL_41
    IL_0023: ldc.i4.6
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: ldarg.0
    IL_002C: call 0x0A00000C
    IL_002D: conv.r8
    IL_002E: or
    IL_002F: ldarg.0
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0037: call 0x0A00000A
    IL_0038: ldc.i4.0
    IL_0039: conv.r8
    IL_003A: stloc.1
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_0042: br IL_011E
    IL_0043: ldarg.0
    IL_0048: ldfld 0x040009E6
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_0050: stsfld 0x000B41BF
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldarg.0
    IL_0058: call 0x0A000081
    IL_005D: br IL_011E
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040009E6
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: IL_41
    IL_006A: ldelem.i
    IL_006B: nop
    IL_006C: nop
    IL_006D: nop
    IL_006E: ldarg.0
    IL_0073: ldfld 0x040009E8
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040009E8
    IL_007A: conv.r8
    IL_007B: ldc.i4.2
    IL_007C: nop
    IL_007D: nop
    IL_007E: stloc.0
    IL_007F: ldarg.0
    IL_0084: ldfld 0x040009E9
    IL_0085: conv.r8
    IL_0086: ldc.i4.2
    IL_0087: nop
    IL_0088: nop
    IL_0089: stloc.0
    IL_008E: call 0x0A000007
    IL_008F: IL_22
    IL_0090: IL_CD
    IL_0091: IL_CC
    IL_0092: IL_4C
    IL_0093: IL_3E
    IL_0098: call 0x0A000008
    IL_009D: call 0x0A000029
    IL_00A2: call 0x0A000024
    IL_00A3: IL_22
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: rem
    IL_18CA213: switch (6498394 cases)
    }

    }}
