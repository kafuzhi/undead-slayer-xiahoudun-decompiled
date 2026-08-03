// Namespace: 
// Type: Bullet_arrowshower

    public class Bullet_arrowshower {{

    private object mytransform;
    private object cha1;
    public object sub_arrow;
    private object subarrowPos;
    private object damage;
    private object c_arrow;

    public Bullet_arrowshower() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000192
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000001
    IL_0016: call 0x0A000004
    IL_0017: conv.r8
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: stfld 0x04000193
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: call 0x2B00000A
    IL_002C: ldfld 0x04000FE2
    IL_0031: stfld 0x04000196
    IL_0032: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000192
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000193
    IL_000C: conv.r8
    IL_000D: ldarg.0
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: IL_22
    IL_0017: stloc.0
    IL_0018: IL_D7
    IL_0019: IL_23
    IL_001A: IL_BD
    IL_001B: IL_22
    IL_001C: stloc.0
    IL_001D: IL_D7
    IL_001E: IL_23
    IL_001F: IL_3D
    IL_0024: call 0x0A000075
    IL_0025: IL_22
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_8F5C28B5: switch (601295394 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000192
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: stloc.0
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A000023
    IL_0013: IL_22
    IL_0014: IL_CD
    IL_0015: IL_CC
    IL_0016: IL_4C
    IL_0017: IL_3E
    IL_0018: IL_43
    IL_0019: IL_34
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000192
    IL_0023: dup
    IL_0024: conv.r8
    IL_0025: ldc.i4.2
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: call 0x0A000007
    IL_0032: call 0x0A000024
    IL_0037: call 0x0A000008
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_20A13F: switch (534592 cases)
    }

    }}
