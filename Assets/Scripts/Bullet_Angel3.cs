// Namespace: 
// Type: Bullet_Angel3

    public class Bullet_Angel3 {{

    private object mytransform;
    private object cha1;
    private object mychild;
    private object targetPos;
    private object dir;
    private object script_angel;
    private object myline;
    private object delay;

    public Bullet_Angel3() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000162
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000019
    IL_0017: stfld 0x04000168
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000AFF
    IL_0022: call 0x0A000077
    IL_0023: conv.r8
    IL_0024: ldarg.3
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x04000163
    IL_002D: ldarg.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000163
    IL_0034: conv.r8
    IL_0035: ldc.i4.4
    IL_0036: nop
    IL_0037: nop
    IL_0039: br.s IL_00B7
    IL_003A: shr.un
    IL_003B: IL_01
    IL_003C: nop
    IL_003D: ldarg.2
    IL_003E: ldarg.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000162
    IL_0045: ldc.i4.0
    IL_0046: conv.r8
    IL_004B: brtrue IL_7D0A004C
    IL_004C: xor
    IL_004D: IL_01
    IL_004E: nop
    IL_004F: ldarg.2
    IL_0050: ldarg.0
    IL_0055: call 0x0A00000A
    IL_0056: ldc.i4.0
    IL_0057: conv.r8
    IL_0058: stloc.1
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000162
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000162
    IL_0012: conv.r8
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: IL_22
    IL_0018: ldelem.i
    IL_0019: IL_99
    IL_001A: IL_99
    IL_001B: IL_3E
    IL_0020: call 0x0A000008
    IL_0025: call 0x0A000029
    IL_002A: stfld 0x04000165
    IL_002B: ldarg.0
    IL_0030: ldflda 0x04000165
    IL_0031: IL_22
    IL_0032: stloc.0
    IL_0033: IL_D7
    IL_0034: stelem.i
    IL_0039: beq IL_23B7
    IL_003A: stloc.0
    IL_003B: ldarg.0
    IL_003C: ldarg.0
    IL_0041: ldfld 0x04000162
    IL_0042: conv.r8
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_004B: stfld 0x04000166
    IL_004C: ldarg.0
    IL_0051: ldflda 0x04000166
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: nop
    IL_005B: stfld 0x0A000023
    IL_005C: ldarg.0
    IL_005D: IL_22
    IL_005F: bne.un.s IL_0093
    IL_0061: bne.un.s IL_00A2
    IL_0066: stfld 0x04000169
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000162
    IL_0071: call 0x0A000013
    IL_0072: conv.r8
    IL_0077: call 0x020A0000
    IL_007C: ldfld 0x04000164
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000166
    IL_0083: conv.r8
    IL_0088: ldc.i4 705298432
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000166
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000164
    IL_000D: conv.r8
    IL_000E: mul
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0016: call 0x0A000024
    IL_001B: call 0x0A000008
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_C0
    IL_20C4: switch (2088 cases)
    }

    }}
