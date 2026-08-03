// Namespace: 
// Type: Sk_meteo

    public class Sk_meteo {{

    private object mytransform;
    private object falldown;
    private object currentpos;
    private object directionVector;
    private object mycollider;
    private object finish_delay;
    private object script_boom;

    public Sk_meteo() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008F4
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040008F8
    IL_0018: ldarg.0
    IL_001D: ldstr 0x700229C8
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: xor
    IL_0025: nop
    IL_0026: nop
    IL_0028: br.s IL_00A6
    IL_0029: IL_FA
    IL_002A: ldloc.2
    IL_002B: nop
    IL_002C: ldarg.2
    IL_002D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008F4
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: brtrue IL_6F0A000D
    IL_000D: IL_B0
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldc.i4.1
    IL_0012: conv.r8
    IL_0013: IL_B6
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040008F4
    IL_001D: ldc.i4.1
    IL_001E: conv.r8
    IL_0023: brtrue IL_6F0A0024
    IL_0024: IL_B0
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ldc.i4.1
    IL_0029: conv.r8
    IL_002A: IL_B6
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_002F: ldc.i4.1
    IL_0034: stfld 0x040008F5
    IL_0035: ldarg.0
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003F: stfld 0x040008F9
    IL_0040: ldarg.0
    IL_0041: ldarg.0
    IL_0046: ldfld 0x040008F4
    IL_0047: conv.r8
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: stloc.0
    IL_0050: call 0x0A000007
    IL_0051: IL_22
    IL_0053: bne.un.s IL_0087
    IL_0055: bne.un.s IL_0095
    IL_005A: call 0x0A000008
    IL_005F: call 0x0A000019
    IL_0064: stfld 0x040008F7
    IL_0065: ldarg.0
    IL_006A: ldfld 0x040008F4
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040008F7
    IL_0075: call 0x0A000043
    IL_0076: conv.r8
    IL_0077: IL_CC
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldarg.0
    IL_007C: ldarg.0
    IL_0081: ldfld 0x040008F4
    IL_0082: conv.r8
    IL_0083: ldc.i4.2
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_008B: stfld 0x040008F6
    IL_008C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008F5
    IL_000A: brfalse IL_009B
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040008F4
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0024: pop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_0029: dup
    IL_002E: ldfld 0x040008F6
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040008F7
    IL_0035: IL_22
    IL_0036: stloc.0
    IL_0037: IL_D7
    IL_0038: stelem.i
    IL_0039: IL_3D
    IL_003E: call 0x0A000008
    IL_0043: call 0x0A000029
    IL_0048: stfld 0x040008F6
    IL_004D: br IL_0085
    IL_004E: ldarg.0
    IL_0053: ldfld 0x040008F8
    IL_0054: ldc.i4.1
    IL_0055: conv.r8
    IL_0057: ldc.i4.s 0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005B: ldc.i4.0
    IL_0060: stfld 0x040008F5
    IL_0061: ldarg.0
    IL_0066: ldflda 0x040008F6
    IL_0067: ldc.i4.1
    IL_0068: IL_22
    IL_0069: nop
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_0071: call 0x0A00001A
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040008FA
    IL_0078: ldc.i4.0
    IL_0079: ldarg.0
    IL_007E: ldfld 0x040008F6
    IL_007F: ldc.i4.1
    IL_0080: conv.r8
    IL_0081: ldind.ref
    IL_0082: ldarg.0
    IL_0083: nop
    IL_0084: ldloc.0
    IL_0085: ldarg.0
    IL_008A: ldfld 0x040008F4
    IL_008B: ldarg.0
    IL_0090: ldfld 0x040008F6
    IL_0091: conv.r8
    IL_0092: ldloc.3
    IL_0093: nop
    IL_0094: nop
    IL_0095: stloc.0
    IL_009A: br IL_0108
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x040008F9
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_12DB5: switch (19267 cases)
    }

    }}
