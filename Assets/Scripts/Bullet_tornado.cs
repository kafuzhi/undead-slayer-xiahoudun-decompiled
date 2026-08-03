// Namespace: 
// Type: Bullet_tornado

    public class Bullet_tornado {{

    private object movestart;
    private object rnddir;
    private object monmovestat;
    private object targetpod;
    private object script_mon;
    private object mytransform;
    private object myparent;
    private object originscale;
    private object sintime;
    private object movedelay;

    public Bullet_tornado() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001FF
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040001FF
    IL_0013: conv.r8
    IL_0014: IL_CD
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000200
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040001FF
    IL_0024: conv.r8
    IL_0029: cpobj 0x7D0A0000
    IL_002A: IL_01
    IL_002B: ldarg.0
    IL_002C: nop
    IL_002D: ldarg.2
    IL_002E: ret
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
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040001FF
    IL_0021: conv.r8
    IL_0022: IL_44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.r8
    IL_0027: ldc.i4.8
    IL_0028: nop
    IL_0029: nop
    IL_002B: br.s IL_00A9
    IL_002D: ceq
    IL_002E: nop
    IL_002F: ldarg.2
    IL_0030: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.2
    IL_0007: call 0x0A000045
    IL_000C: stfld 0x040001FB
    IL_000D: ldarg.0
    IL_000E: ldarg.0
    IL_0013: ldfld 0x040001FB
    IL_0014: ldc.i4.2
    IL_0015: IL_5A
    IL_0016: ldc.i4.1
    IL_0017: IL_59
    IL_001C: stfld 0x040001FB
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040001FF
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000201
    IL_0029: conv.r8
    IL_002A: IL_AF
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: call 0x0A00001B
    IL_0038: stfld 0x040001FD
    IL_0039: ldarg.0
    IL_003A: ldc.i4.0
    IL_003F: stfld 0x040001FA
    IL_0040: ldarg.0
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_004A: stfld 0x04000203
    IL_004B: ldarg.0
    IL_004C: IL_22
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0055: stfld 0x04000202
    IL_0056: ldarg.0
    IL_005B: ldfld 0x040001FF
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000200
    IL_0062: conv.r8
    IL_0063: IL_4E
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x040001FF
    IL_006D: ldarg.0
    IL_0072: ldfld 0x040001FF
    IL_0073: conv.r8
    IL_0074: ldc.i4.2
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_007C: call 0x0A000007
    IL_007D: IL_22
    IL_007E: IL_CD
    IL_007F: IL_CC
    IL_0080: IL_CC
    IL_0081: IL_3D
    IL_0086: call 0x0A000008
    IL_008B: call 0x0A000029
    IL_008C: conv.r8
    IL_008D: ldloc.3
    IL_008E: nop
    IL_008F: nop
    IL_0090: stloc.0
    IL_0091: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000203
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04000203
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040001FA
    IL_001C: brtrue IL_00B6
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040001FE
    IL_0028: ldfld 0x04000061
    IL_002D: stfld 0x040001FC
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000203
    IL_0034: IL_22
    IL_0035: ldelem.i
    IL_0036: IL_99
    IL_0037: IL_99
    IL_0038: IL_3F
    IL_0039: IL_41
    IL_003C: ldarga 0
    IL_003D: nop
    IL_003E: ldarg.0
    IL_0043: ldfld 0x040001FC
    IL_0044: ldc.i4.0
    IL_0045: IL_3D
    IL_0046: ldloc.0
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: ldarg.0
    IL_004F: call 0x06000101
    IL_0050: ldarg.0
    IL_0055: ldfld 0x040001FF
    IL_0056: dup
    IL_0057: conv.r8
    IL_005C: cpobj 0x280A0000
    IL_005D: localloc
    IL_005E: nop
    IL_005F: nop
    IL_0060: stloc.0
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0064: nop
    IL_0065: IL_3F
    IL_006A: call 0x0A000008
    IL_006F: call 0x0A000024
    IL_0074: call 0x0A000008
    IL_0079: call 0x0A000029
    IL_007A: conv.r8
    IL_007B: IL_AF
    IL_007C: nop
    IL_007D: nop
    IL_007E: stloc.0
    IL_0083: br IL_00B1
    IL_0084: ldarg.0
    IL_0089: ldfld 0x040001FF
    IL_008A: ldnull
    IL_008B: conv.r8
    IL_008C: IL_4E
    IL_008D: nop
    IL_008E: nop
    IL_008F: stloc.0
    IL_0090: ldarg.0
    IL_0091: ldc.i4.1
    IL_0096: stfld 0x040001FA
    IL_0097: ldarg.0
    IL_009C: ldfld 0x040001FF
    IL_00A1: call 0x0A00004B
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_214A: switch (2088 cases)
    }

    public void Disappear() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040001FF
    IL_0016: call 0x0A00004B
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldelem.r8
    IL_20BF: switch (2088 cases)
    }

    }}
