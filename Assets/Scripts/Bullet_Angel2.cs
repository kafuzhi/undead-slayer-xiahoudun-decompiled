// Namespace: 
// Type: Bullet_Angel2

    public class Bullet_Angel2 {{

    public object delay_collision;
    public object delay_destroy;
    private object delay;
    private object mytransform;
    private object script_angel;
    private object mycollider;
    private object impactOn;

    public Bullet_Angel2() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: IL_CD
    IL_0003: IL_CC
    IL_0004: IL_4C
    IL_0005: IL_3E
    IL_000A: stfld 0x0400015B
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: ldelem.i
    IL_000E: IL_99
    IL_000F: ldc.i4.3
    IL_0010: IL_3F
    IL_0015: stfld 0x0400015C
    IL_0016: ldarg.0
    IL_001B: call 0x0A000001
    IL_001C: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400015E
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000160
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000AFF
    IL_0022: call 0x0A000077
    IL_0023: conv.r8
    IL_0024: ldc.i4.2
    IL_0025: nop
    IL_0026: nop
    IL_0028: br.s IL_00A6
    IL_0029: div.un
    IL_002A: IL_01
    IL_002B: nop
    IL_002C: ldarg.2
    IL_002D: ldarg.0
    IL_0032: call 0x0A00000A
    IL_0033: ldc.i4.0
    IL_0034: conv.r8
    IL_0035: stloc.1
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000003
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0016: stfld 0x0400015D
    IL_0017: ldarg.0
    IL_0018: ldc.i4.0
    IL_001D: stfld 0x04000161
    IL_001E: ldarg.0
    IL_0023: ldfld 0x0400015E
    IL_0024: ldarg.0
    IL_0029: ldfld 0x0400015E
    IL_002A: conv.r8
    IL_002B: IL_22
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_002F: stloc.0
    IL_0031: ldloca.s 0
    IL_0036: ldfld 0x0A00005E
    IL_0037: IL_22
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: ldarg.0
    IL_0041: ldfld 0x0400015E
    IL_0042: conv.r8
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: stloc.1
    IL_0049: ldloca.s 1
    IL_004E: ldfld 0x0A00005C
    IL_0053: newobj 0x0A000076
    IL_0058: call 0x0A00001D
    IL_0059: conv.r8
    IL_005E: call 0x020A0000
    IL_0063: call 0x0A0000B0
    IL_0064: conv.r8
    IL_0065: IL_B1
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400015D
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400015C
    IL_000C: IL_43
    IL_0011: call 0x02000000
    IL_0016: ldfld 0x04000160
    IL_0017: ldc.i4.0
    IL_0018: conv.r8
    IL_001A: ldc.i4.s 0
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_0022: call 0x0A0000B0
    IL_0023: conv.r8
    IL_0024: IL_BA
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ldarg.0
    IL_002D: call 0x0A00000A
    IL_002E: ldc.i4.0
    IL_002F: conv.r8
    IL_0030: stloc.1
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: br IL_0073
    IL_0039: ldarg.0
    IL_003E: ldfld 0x04000161
    IL_0043: brtrue IL_0073
    IL_0044: ldarg.0
    IL_0049: ldfld 0x0400015D
    IL_004A: ldarg.0
    IL_004F: ldfld 0x0400015B
    IL_0050: IL_43
    IL_0051: ldc.i4.8
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldarg.0
    IL_005A: ldfld 0x0400015F
    IL_005B: conv.r8
    IL_005C: ldloc.2
    IL_005D: nop
    IL_005E: nop
    IL_005F: ldloc.0
    IL_0060: ldarg.0
    IL_0065: ldfld 0x04000160
    IL_0066: ldc.i4.1
    IL_0067: conv.r8
    IL_0069: ldc.i4.s 0
    IL_006A: nop
    IL_006B: stloc.0
    IL_006C: ldarg.0
    IL_006D: ldc.i4.1
    IL_0072: stfld 0x04000161
    IL_0073: ldarg.0
    IL_0074: dup
    IL_0079: ldfld 0x0400015D
    IL_007E: call 0x0A000024
    IL_007F: IL_58
    IL_0084: stfld 0x0400015D
    IL_0085: ret
    }

    }}
