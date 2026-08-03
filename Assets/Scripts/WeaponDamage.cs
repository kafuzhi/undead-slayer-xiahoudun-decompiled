// Namespace: 
// Type: WeaponDamage

    public class WeaponDamage {{

    private object mytransform;
    public object damage;
    public object impactDestroy;
    public object destroytime;
    public object colliderofftime;
    private object currenttime;
    private object mycollider;

    public WeaponDamage() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FE1
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000FE7
    IL_0018: ldarg.0
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: stfld 0x04000FE6
    IL_0023: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000FE6
    IL_000B: ret
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
    IL_0225: switch (133 cases)
    }

    public void PressDamage() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000FE2
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FE4
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_43
    IL_0010: newarr 0x02000000
    IL_0011: dup
    IL_0016: ldfld 0x04000FE6
    IL_001B: call 0x0A000024
    IL_001C: IL_58
    IL_0021: stfld 0x04000FE6
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000FE5
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_43
    IL_002E: ldc.i4.7
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000FE6
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000FE5
    IL_003E: IL_44
    IL_003F: stloc.2
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000FE7
    IL_0049: ldc.i4.0
    IL_004A: conv.r8
    IL_004C: ldc.i4.s 0
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000FE6
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000FE4
    IL_005B: IL_44
    IL_005C: IL_3D
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_006A: stfld 0x04000FE6
    IL_006B: ldarg.0
    IL_0070: call 0x0A00000A
    IL_0071: ldc.i4.0
    IL_0072: conv.r8
    IL_0073: stloc.1
    IL_0074: nop
    IL_0075: nop
    IL_0076: stloc.0
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000FE1
    IL_0081: call 0x0A00004B
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0085: ldelem.r8
    IL_212A: switch (2088 cases)
    }

    }}
