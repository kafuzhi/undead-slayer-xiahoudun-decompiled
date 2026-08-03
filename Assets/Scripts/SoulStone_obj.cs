// Namespace: 
// Type: SoulStone_obj

    public class SoulStone_obj {{

    private object mytransform;
    public object obj_break;
    private object cha1;
    private object script_cha;

    public SoulStone_obj() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008FE
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000F: stfld 0x04000900
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000900
    IL_0017: conv.r8
    IL_0018: shl
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_009A
    IL_001D: IL_01
    IL_001E: ldloc.3
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0021: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000900
    IL_0007: conv.r8
    IL_0008: IL_FF
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: call 0x0A000061
    IL_0015: brfalse IL_0062
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040008FF
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040008FE
    IL_0022: conv.r8
    IL_0023: ldc.i4.2
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040008FE
    IL_002D: conv.r8
    IL_002E: pop
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0036: call 0x0A000014
    IL_0037: pop
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000901
    IL_003E: conv.r8
    IL_0043: castclass 0x02060001
    IL_0048: ldfld 0x040008FE
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_C0
    IL_0052: call 0x0A000042
    IL_0057: call 0x0A0000C2
    IL_0058: conv.r8
    IL_0059: ldloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_0061: br IL_00AF
    IL_0062: ldarg.1
    IL_0063: conv.r8
    IL_0064: stloc.0
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: conv.r8
    IL_0069: ldc.i4.8
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: ldc.i4.8
    IL_0162: switch (60 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: stloc.0
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A00005C
    IL_0013: IL_22
    IL_0014: ldelem.i
    IL_0015: IL_99
    IL_0016: ldc.i4.3
    IL_0017: IL_BF
    IL_0018: IL_43
    IL_0019: IL_34
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_0022: call 0x0A000002
    IL_0023: dup
    IL_0024: conv.r8
    IL_0025: ldc.i4.2
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: call 0x0A000042
    IL_002E: IL_22
    IL_002F: shr
    IL_0030: shr
    IL_0031: IL_E6
    IL_0032: IL_BF
    IL_0037: call 0x0A000008
    IL_003C: call 0x0A000024
    IL_0041: call 0x0A000008
    IL_0046: call 0x0A000029
    IL_0047: conv.r8
    IL_0048: ldloc.3
    IL_0049: nop
    IL_004A: nop
    IL_004B: stloc.0
    IL_0050: br IL_006B
    IL_0051: ldarg.0
    IL_0056: ldfld 0x040008FE
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: IL_C0
    IL_0060: call 0x0A000042
    IL_0065: call 0x0A0000C2
    IL_0066: conv.r8
    IL_0067: ldloc.3
    IL_0068: nop
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: ret
    }

    }}
