// Namespace: 
// Type: Wind_axe

    public class Wind_axe {{

    private object mytransform;
    private object cha1;
    private object originscale;
    private object finish_delay;

    public Wind_axe() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FFB
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000001
    IL_0016: call 0x0A000004
    IL_0017: conv.r8
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: stfld 0x04000FFC
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000FFB
    IL_0028: conv.r8
    IL_002D: cpobj 0x7D0A0000
    IL_002E: IL_FD
    IL_0030: ldarga.s 0
    IL_0031: ldarg.2
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000FFB
    IL_0038: ldc.i4.0
    IL_0039: conv.r8
    IL_003E: brtrue IL_6F0A003F
    IL_003F: ret
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: ldstr 0x70000B6F
    IL_0048: conv.r8
    IL_004A: bge.s IL_004B
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: IL_22
    IL_004E: IL_CD
    IL_004F: IL_CC
    IL_0050: IL_4C
    IL_0051: IL_3E
    IL_0052: conv.r8
    IL_0054: bgt.s IL_0055
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FFB
    IL_000A: call 0x0A00001B
    IL_000B: conv.r8
    IL_000C: IL_AF
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000FFB
    IL_0016: ldc.i4.0
    IL_0017: conv.r8
    IL_001C: brtrue IL_6F0A001D
    IL_001D: stloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldc.i4.1
    IL_0022: conv.r8
    IL_0023: stloc.1
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_0031: stfld 0x04000FFE
    IL_0032: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FFB
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000FFC
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: ldloc.3
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_0017: dup
    IL_001C: ldfld 0x04000FFE
    IL_0021: call 0x0A000024
    IL_0022: IL_58
    IL_0027: stfld 0x04000FFE
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000FFE
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: IL_C0
    IL_0032: IL_3F
    IL_0033: IL_43
    IL_0035: bgt.s IL_0036
    IL_0036: nop
    IL_0037: nop
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000FFB
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000FFB
    IL_0044: conv.r8
    IL_0049: cpobj 0x280A0000
    IL_004A: ldc.i4.5
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_0052: call 0x0A000024
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldelem.r8
    IL_2C8A1C3: switch (11675738 cases)
    }

    }}
