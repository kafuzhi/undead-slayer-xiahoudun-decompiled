// Namespace: 
// Type: Tower

    public class Tower {{

    public object arrow;
    private object mytransform;
    private object c_arrow;
    private object mycollider;
    private object arrowdir;
    private object reload_delay;
    private object cur_stage_index;

    public Tower() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A3C
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000A3E
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000CDD
    IL_000A: call 0x06000220
    IL_000B: neg
    IL_0010: stfld 0x04000A41
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A3B
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000A3C
    IL_001E: conv.r8
    IL_001F: ldc.i4.2
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0027: call 0x0A000013
    IL_002C: call 0x0A000014
    IL_002D: conv.u4
    IL_002E: ldarg.1
    IL_002F: nop
    IL_0030: nop
    IL_0031: IL_01
    IL_0036: stfld 0x04000A3D
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000A3D
    IL_003D: conv.r8
    IL_003E: stloc.0
    IL_003F: nop
    IL_0040: nop
    IL_0042: br.s IL_0045
    IL_0047: ldfld 0x04000A41
    IL_0048: ldc.i4.1
    IL_0049: IL_58
    IL_004A: conv.r8
    IL_004B: IL_F1
    IL_004C: ldloc.0
    IL_004D: nop
    IL_004E: ldloc.0
    IL_004F: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000C: ldc.i4.s 15
    IL_0281: switch (156 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A40
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_43
    IL_0010: brfalse IL_2000011
    IL_0011: dup
    IL_0016: ldfld 0x04000A40
    IL_001B: call 0x0A000024
    IL_001C: IL_59
    IL_0021: stfld 0x04000A40
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000A40
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_41
    IL_002E: ldc.i4.1
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldarg.0
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_003C: stfld 0x04000A40
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000A3E
    IL_0043: ldc.i4.1
    IL_0044: conv.r8
    IL_0046: ldc.i4.s 0
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ret
    }

    }}
