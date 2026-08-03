// Namespace: 
// Type: Bullet_tornado_b

    public class Bullet_tornado_b {{

    private object mytransform;
    private object originscale;

    public Bullet_tornado_b() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000204
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000204
    IL_0013: conv.r8
    IL_0018: cpobj 0x7D0A0000
    IL_0019: ldarg.3
    IL_001A: ldarg.0
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000204
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000205
    IL_000C: conv.r8
    IL_000D: IL_AF
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_000A: ldstr 0x70000B6F
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0011: ldelem.i
    IL_0012: IL_99
    IL_0013: IL_99
    IL_0014: IL_3E
    IL_0015: conv.r8
    IL_0017: bgt.s IL_0018
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000204
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000204
    IL_0026: conv.r8
    IL_0027: ldc.i4.2
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000204
    IL_0031: conv.r8
    IL_0032: IL_22
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_22
    IL_0037: IL_CD
    IL_0038: IL_CC
    IL_0039: IL_CC
    IL_003A: IL_3D
    IL_003F: call 0x0A000008
    IL_0044: call 0x0A000029
    IL_0045: conv.r8
    IL_0046: ldloc.3
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ret
    }

    private void Update() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_3F
    IL_0009: call 0x0A000024
    IL_000A: IL_5A
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000204
    IL_0012: dup
    IL_0013: conv.r8
    IL_0018: cpobj 0x220A0000
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldelem.r8
    IL_001C: IL_C0
    IL_001D: ldloc.0
    IL_001E: IL_5A
    IL_001F: ldloc.0
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0023: ldelem.r8
    IL_0024: IL_C0
    IL_0025: ldloc.0
    IL_0026: IL_5A
    IL_002B: newobj 0x0A000076
    IL_0030: call 0x0A000029
    IL_0031: conv.r8
    IL_0032: IL_AF
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000204
    IL_003C: dup
    IL_003D: conv.r8
    IL_003E: ldc.i4.2
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000204
    IL_0048: conv.r8
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldloc.0
    IL_0052: call 0x0A000008
    IL_0057: call 0x0A000029
    IL_0058: conv.r8
    IL_0059: ldloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000204
    IL_0063: conv.r8
    IL_0068: cpobj 0x0B0A0000
    IL_006A: ldloca.s 1
    IL_006F: ldfld 0x0A000023
    IL_0070: IL_22
    IL_0071: nop
    IL_0072: nop
    IL_0077: stsfld 0x00264340
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldarg.0
    IL_007F: call 0x0A00000A
    IL_0080: ldc.i4.0
    IL_0081: conv.r8
    IL_0082: stloc.1
    IL_0083: nop
    IL_0084: nop
    IL_0085: stloc.0
    IL_0086: ldarg.0
    IL_008B: ldfld 0x04000204
    IL_0090: call 0x0A00004B
    IL_0091: IL_22
    IL_0092: nop
    IL_0093: nop
    IL_0094: ldelem.r8
    IL_2139: switch (2088 cases)
    }

    }}
