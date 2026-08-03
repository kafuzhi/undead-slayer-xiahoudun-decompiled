// Namespace: 
// Type: Snake_base

    public class Snake_base {{

    private object mytransform;
    private object finish_delay;
    private object mycollider;

    public Snake_base() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008FB
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040008FD
    IL_0018: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x040008FC
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040008FB
    IL_0015: call 0x0A00001B
    IL_0016: conv.r8
    IL_0017: IL_AF
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040008FB
    IL_0021: ldc.i4.0
    IL_0022: conv.r8
    IL_0027: brtrue IL_6F0A0028
    IL_0028: stloc.0
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_002C: ldc.i4.1
    IL_002D: conv.r8
    IL_002E: stloc.1
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040008FB
    IL_0038: ldc.i4.1
    IL_0039: conv.r8
    IL_003E: brtrue IL_6F0A003F
    IL_003F: stloc.0
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ldc.i4.1
    IL_0044: conv.r8
    IL_0045: stloc.1
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: call 0x0A0000B0
    IL_004F: ldc.i4.1
    IL_0050: conv.r8
    IL_0051: IL_B6
    IL_0052: nop
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: ldarg.0
    IL_005A: ldstr 0x70000AAD
    IL_005B: IL_22
    IL_005C: ldelem.i
    IL_005D: IL_99
    IL_005E: IL_99
    IL_005F: IL_3E
    IL_0060: IL_22
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: IL_3F
    IL_0069: call 0x0A000017
    IL_006A: ret
    }

    private void ColliderOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008FD
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008FD
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
    IL_0006: ldfld 0x040008FC
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040008FC
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008FC
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_41
    IL_001D: IL_43
    IL_0020: ldarg 0
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040008FB
    IL_0034: ldc.i4.0
    IL_0035: conv.r8
    IL_003A: brtrue IL_6F0A003B
    IL_003B: stloc.0
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldc.i4.0
    IL_0040: conv.r8
    IL_0041: stloc.1
    IL_0042: nop
    IL_0043: nop
    IL_0044: stloc.0
    IL_0045: ldarg.0
    IL_004A: ldfld 0x040008FB
    IL_004B: ldc.i4.1
    IL_004C: conv.r8
    IL_0051: brtrue IL_6F0A0052
    IL_0052: stloc.0
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldc.i4.0
    IL_0057: conv.r8
    IL_0058: stloc.1
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ldarg.0
    IL_0061: call 0x0A000081
    IL_0066: br IL_00DE
    IL_0067: ldarg.0
    IL_006C: ldfld 0x040008FC
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0070: IL_C0
    IL_F181: switch (15427 cases)
    }

    }}
