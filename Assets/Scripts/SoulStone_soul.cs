// Namespace: 
// Type: SoulStone_soul

    public class SoulStone_soul {{

    private object mytransform;
    private object cha1;
    private object script_cha;

    public SoulStone_soul() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000902
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000F: stfld 0x04000903
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000903
    IL_0017: conv.r8
    IL_0018: shl
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_009A
    IL_001D: ldarg.2
    IL_001E: ldloc.3
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000902
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: ldc.i4.0
    IL_0031: ldc.i4 360
    IL_0036: call 0x0A000045
    IL_0037: conv.i2
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_0041: call 0x0A000060
    IL_0042: conv.r8
    IL_0047: call 0x2A0A0000
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000903
    IL_0007: conv.r8
    IL_0008: IL_FF
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: call 0x0A000061
    IL_0015: brfalse IL_003C
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000904
    IL_001C: ldc.i4.1
    IL_001D: conv.r8
    IL_001E: IL_A4
    IL_001F: IL_01
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000902
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_C0
    IL_0031: call 0x0A000042
    IL_0036: call 0x0A0000C2
    IL_0037: conv.r8
    IL_0038: ldloc.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_003C: ret
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
    IL_0019: IL_58
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
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000902
    IL_0056: call 0x0A000007
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: IL_FA
    IL_005B: IL_43
    IL_0060: call 0x0A000008
    IL_0065: call 0x0A000024
    IL_006A: call 0x0A000008
    IL_006B: conv.r8
    IL_006C: IL_B5
    IL_006D: nop
    IL_006E: nop
    IL_006F: stloc.0
    IL_0074: br IL_008F
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000902
    IL_007B: IL_22
    IL_007C: nop
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_C0
    IL_0084: call 0x0A000042
    IL_0089: call 0x0A0000C2
    IL_008A: conv.r8
    IL_008B: ldloc.3
    IL_008C: nop
    IL_008D: nop
    IL_008E: stloc.0
    IL_008F: ret
    }

    }}
