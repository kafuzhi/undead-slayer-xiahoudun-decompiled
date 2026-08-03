// Namespace: 
// Type: Wing

    public class Wing {{

    private object mytransform;
    private object wingmesh;
    private object delay;
    private object myanimation;

    public Wing() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FFF
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00002A
    IL_0017: stfld 0x04001002
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000FFF
    IL_001F: ldc.i4.2
    IL_0020: conv.r8
    IL_0025: brtrue IL_7D0A0026
    IL_0026: nop
    IL_0028: starg.s 0
    IL_0029: ldarg.2
    IL_002A: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001000
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04001002
    IL_001B: ldstr 0x70024AAC
    IL_001C: conv.r8
    IL_001D: IL_3C
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: pop
    IL_0022: ldarg.0
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_002C: stfld 0x04001001
    IL_002D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001002
    IL_000A: ldstr 0x70000AD5
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_3F
    IL_0015: conv.r8
    IL_0017: bgt.s IL_0018
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04001002
    IL_0024: ldstr 0x70000AE7
    IL_0025: conv.r8
    IL_0027: bge.s IL_0028
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_0031: stsfld 0x00306F3E
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04001002
    IL_003E: ldstr 0x70024AAC
    IL_003F: conv.r8
    IL_0041: bge.s IL_0042
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: IL_22
    IL_0045: IL_CD
    IL_0046: IL_CC
    IL_0047: stloc.2
    IL_C208: switch (12399 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04001001
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04001001
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04001001
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001F: stsfld 0x002D4340
    IL_0020: nop
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
    IL_0033: ldfld 0x04001000
    IL_0034: conv.r8
    IL_0035: stloc.0
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldc.i4.0
    IL_003A: conv.r8
    IL_003B: stloc.1
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04001002
    IL_0045: conv.r8
    IL_0048: ldloc 0
    IL_0049: stloc.0
    IL_004E: br IL_0095
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04001001
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_550D5C: switch (1393472 cases)
    }

    }}
