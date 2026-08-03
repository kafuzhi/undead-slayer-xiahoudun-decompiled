// Namespace: 
// Type: Bullet_magicmissile

    public class Bullet_magicmissile {{

    public object closetime;
    private object delay;
    public object homingrate;
    public object homingspeed;
    private object cha1;
    private object mytransform;
    private object directionVector;
    private object rotate;
    private object originscale;
    private object reduceVector;

    public Bullet_magicmissile() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_70DF508: switch (29588800 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001C8
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040001C8
    IL_0013: conv.r8
    IL_0018: cpobj 0x7D0A0000
    IL_0019: IL_CB
    IL_001A: IL_01
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x040001C7
    IL_0015: ldarg.0
    IL_001A: ldstr 0x7000015F
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_22
    IL_0021: IL_CD
    IL_0022: IL_CC
    IL_0023: IL_CC
    IL_0024: IL_3D
    IL_0029: call 0x0A000017
    IL_002A: ldarg.0
    IL_002B: IL_22
    IL_002C: nop
    IL_002D: nop
    IL_002E: nop
    IL_002F: IL_3F
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0037: stsfld 0x0000223F
    IL_003C: stsfld 0x0076733F
    IL_003D: nop
    IL_003E: stloc.0
    IL_0043: stfld 0x040001CC
    IL_0044: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x040001C4
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040001C8
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040001CB
    IL_0017: conv.r8
    IL_0018: IL_AF
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ret
    }

    public void SetDir() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040001C7
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040001C8
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000019
    IL_0020: stfld 0x040001C9
    IL_0021: ldarg.0
    IL_0026: ldflda 0x040001C9
    IL_0027: ldc.i4.1
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_0031: call 0x0A00001A
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040001C9
    IL_003C: call 0x0A00001B
    IL_0041: call 0x0A00001C
    IL_0046: brfalse IL_0058
    IL_0047: ldarg.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x040001C9
    IL_0052: call 0x0A00001D
    IL_0057: stfld 0x040001CA
    IL_0058: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001C8
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040001C8
    IL_000C: conv.r8
    IL_000D: pop
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040001CA
    IL_001B: call 0x0A000024
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040001C5
    IL_0022: IL_5A
    IL_0027: call 0x0A000027
    IL_0028: conv.r8
    IL_002D: call 0x020A0000
    IL_0032: ldfld 0x040001C8
    IL_0033: dup
    IL_0034: conv.r8
    IL_0035: ldc.i4.2
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldarg.0
    IL_003E: ldfld 0x040001C8
    IL_003F: conv.r8
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0048: call 0x0A000024
    IL_004D: call 0x0A000008
    IL_004E: ldarg.0
    IL_0053: ldfld 0x040001C6
    IL_0058: call 0x0A000008
    IL_005D: call 0x0A000029
    IL_005E: conv.r8
    IL_005F: ldloc.3
    IL_0060: nop
    IL_0061: nop
    IL_0062: stloc.0
    IL_0063: ldarg.0
    IL_0064: dup
    IL_0069: ldfld 0x040001C4
    IL_006E: call 0x0A000024
    IL_006F: IL_58
    IL_0074: stfld 0x040001C4
    IL_0075: ldarg.0
    IL_007A: ldfld 0x040001C4
    IL_007B: ldarg.0
    IL_0080: ldfld 0x040001C3
    IL_0081: IL_43
    IL_0086: newobj 0x02000000
    IL_008B: ldfld 0x040001C8
    IL_008C: dup
    IL_008D: conv.r8
    IL_0092: cpobj 0x020A0000
    IL_0097: ldfld 0x040001CC
    IL_009C: call 0x0A000024
    IL_00A1: call 0x0A000008
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: IL_C0
    IL_00A6: IL_3F
    IL_00AB: call 0x0A000008
    IL_00B0: call 0x0A000019
    IL_00B1: conv.r8
    IL_00B2: IL_AF
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x040001C8
    IL_00BC: conv.r8
    IL_00C1: cpobj 0x0A0A0000
    IL_00C3: ldloca.s 0
    IL_00C8: ldfld 0x0A00005C
    IL_00C9: IL_22
    IL_00CA: stloc.0
    IL_00CB: IL_D7
    IL_00CC: stelem.i
    IL_00CD: IL_3C
    IL_00CE: IL_41
    IL_00CF: pop
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: ldarg.0
    IL_00D8: call 0x0A00000A
    IL_00D9: ldc.i4.0
    IL_00DA: conv.r8
    IL_00DB: stloc.1
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: stloc.0
    IL_00DF: ldarg.0
    IL_00E4: ldfld 0x040001C8
    IL_00E9: call 0x0A00004B
    IL_00EA: IL_22
    IL_00EB: nop
    IL_00EC: nop
    IL_00F1: stsfld 0x00082840
    IL_00F2: nop
    IL_00F3: stloc.0
    IL_00F4: conv.r8
    IL_00F5: ldloc.3
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: stloc.0
    IL_00F9: ret
    }

    }}
