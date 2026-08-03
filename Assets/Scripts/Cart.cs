// Namespace: 
// Type: Cart

    public class Cart {{

    private object script_ui;
    private object script_pack;
    private object gauge_hp;
    public object horse;
    public object snd_break;
    public object pt_hit;
    public object cart_destroy;
    private object mytransform;
    private object navi_gauge;
    private object myanimation;
    private object delay;
    private object damage;
    private object hp_length;
    private object maxhp;
    private object hp;
    private object life;
    private object super;
    private object cur_stage_index;

    public Cart() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000292
    IL_0007: ldarg.0
    IL_000C: call 0x0A000001
    IL_000D: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000CDD
    IL_000A: call 0x06000220
    IL_000B: neg
    IL_0010: stfld 0x04000294
    IL_0011: ldarg.0
    IL_0016: ldc.i4 2000
    IL_001B: ldc.i4 150
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000294
    IL_0022: IL_5A
    IL_0023: IL_58
    IL_0028: stfld 0x04000290
    IL_0029: ldarg.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x04000290
    IL_0034: stfld 0x04000291
    IL_0035: ldarg.0
    IL_0036: ldarg.0
    IL_003B: call 0x0A000002
    IL_0040: stfld 0x0400028A
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: call 0x0A00002A
    IL_004C: stfld 0x0400028C
    IL_004D: ldarg.0
    IL_0052: ldfld 0x0400028A
    IL_0057: call 0x0A000042
    IL_0058: IL_22
    IL_0059: nop
    IL_005A: nop
    IL_005B: nop
    IL_005C: IL_3F
    IL_0061: call 0x0A000008
    IL_0062: conv.r8
    IL_0063: ldloc.3
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldarg.0
    IL_006C: ldstr 0x70000BD5
    IL_0071: call 0x0A000004
    IL_0072: conv.r8
    IL_007B: ldc.i8 288233139915653120
    IL_007C: ldarg.0
    IL_0081: ldstr 0x700002DB
    IL_0086: call 0x0A000004
    IL_0087: conv.r8
    IL_0088: stloc.3
    IL_0089: nop
    IL_008A: nop
    IL_008C: br.s IL_010A
    IL_008D: IL_84
    IL_008E: ldarg.0
    IL_008F: nop
    IL_0090: ldarg.2
    IL_0091: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000284
    IL_0006: IL_22
    IL_0007: IL_CD
    IL_0008: IL_CC
    IL_0009: IL_4C
    IL_000A: IL_3E
    IL_000B: IL_22
    IL_000C: IL_8F
    IL_000D: IL_C2
    IL_000E: conv.u8
    IL_000F: IL_3D
    IL_0014: newobj 0x0A000038
    IL_0015: IL_22
    IL_0016: nop
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_22
    IL_001C: bne.un.s IL_0050
    IL_001D: conv.ovf.i4.un
    IL_001E: IL_BF
    IL_001F: IL_22
    IL_0020: IL_3D
    IL_0021: stloc.0
    IL_0022: ldc.i4.1
    IL_3999998AF: switch (3865470498 cases)
    }

    public void ShowDistance() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400028A
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: stloc.0
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A00005C
    IL_0013: IL_22
    IL_0014: shr
    IL_0015: shr
    IL_0016: IL_86
    IL_0017: IL_41
    IL_0018: IL_43
    IL_001A: ldc.i4.s 0
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000283
    IL_0024: ldc.i4.s 100
    IL_0025: conv.r8
    IL_0027: starg.s 6
    IL_0028: nop
    IL_0029: ldloc.0
    IL_002A: ldarg.0
    IL_002B: ldc.i4.1
    IL_0030: stfld 0x04000293
    IL_0031: ldarg.0
    IL_0036: ldstr 0x70000D5D
    IL_003B: call 0x0A00007B
    IL_003C: ret
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000292
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000293
    IL_0016: brfalse IL_0018
    IL_0017: ret
    IL_0018: ldarg.0
    IL_001A: ldarga.s 1
    IL_001F: ldfld 0x0A000023
    IL_0020: not
    IL_0025: stfld 0x0400028E
    IL_0027: ldarga.s 1
    IL_0028: ldc.i4.1
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_0032: call 0x0A00001A
    IL_0033: ldarg.0
    IL_0034: ldc.i4.0
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000291
    IL_003B: ldarg.0
    IL_0040: ldfld 0x0400028E
    IL_0041: IL_59
    IL_0046: call 0x0A000080
    IL_004B: stfld 0x04000291
    IL_004C: ldarg.0
    IL_0051: call 0x0600015A
    IL_0052: ldarg.0
    IL_0057: ldfld 0x0400028C
    IL_0058: conv.r8
    IL_005B: ldloc 0
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x0400028C
    IL_0067: ldstr 0x70000D2F
    IL_0068: conv.r8
    IL_0069: IL_3C
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: pop
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000286
    IL_0074: conv.r8
    IL_0075: ret
    IL_0076: nop
    IL_0077: nop
    IL_0078: stloc.0
    IL_0079: conv.r8
    IL_007C: ldloc 0
    IL_007D: stloc.0
    IL_007E: ldarg.0
    IL_007F: IL_22
    IL_0080: nop
    IL_0081: nop
    IL_0082: nop
    IL_A367B: switch (167293 cases)
    }

    private void FailStage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000283
    IL_0006: ldc.i4.m1
    IL_0007: conv.r8
    IL_0009: starg.s 6
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ret
    }

    public void HPgaugeSet() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x917B023F
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: ldarg.2
    IL_000C: conv.i2
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000290
    IL_0013: conv.i2
    IL_0014: add
    IL_0015: IL_59
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_3E
    IL_001B: IL_5A
    IL_0020: stfld 0x0400028F
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000285
    IL_002B: call 0x0A000082
    IL_002C: ldarg.0
    IL_0031: ldfld 0x0400028F
    IL_0036: call 0x0A000083
    IL_0037: conv.r8
    IL_0038: IL_F3
    IL_0039: ldarg.0
    IL_003A: nop
    IL_003B: ldloc.0
    IL_003C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000292
    IL_000A: brtrue IL_003F
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000286
    IL_0011: dup
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000042
    IL_0020: call 0x0A000024
    IL_0025: call 0x0A000008
    IL_0026: IL_22
    IL_0027: nop
    IL_0028: nop
    IL_002D: stsfld 0x0008283F
    IL_002E: nop
    IL_002F: stloc.0
    IL_0034: call 0x0A000029
    IL_0035: conv.r8
    IL_0036: ldloc.3
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003E: br IL_0135
    IL_003F: ldarg.0
    IL_0044: ldfld 0x0400028D
    IL_0045: IL_22
    IL_0046: nop
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: IL_43
    IL_004F: stfld 0x02000000
    IL_0050: dup
    IL_0055: ldfld 0x0400028D
    IL_005A: call 0x0A000024
    IL_005B: IL_59
    IL_0060: stfld 0x0400028D
    IL_0061: ldarg.0
    IL_0066: ldfld 0x0400028D
    IL_0067: IL_22
    IL_0068: nop
    IL_0069: nop
    IL_006A: nop
    IL_006B: nop
    IL_006C: IL_42
    IL_006D: IL_35
    IL_006E: nop
    IL_006F: nop
    IL_0070: nop
    IL_0071: ldarg.0
    IL_0076: ldfld 0x0400028C
    IL_007B: ldstr 0x70000D1D
    IL_007C: conv.r8
    IL_007D: IL_55
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ldarg.0
    IL_0086: ldfld 0x04000286
    IL_0087: conv.r8
    IL_0088: ret
    IL_0089: nop
    IL_008A: nop
    IL_008B: stloc.0
    IL_0090: ldstr 0x70000D47
    IL_0091: conv.r8
    IL_0092: IL_55
    IL_0093: nop
    IL_0094: nop
    IL_0095: stloc.0
    IL_0096: ldarg.0
    IL_009B: call 0x0A00002B
    IL_009C: conv.r8
    IL_009D: IL_4D
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A5: br IL_00C7
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x0400028D
    IL_00AC: IL_22
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: IL_C0
    IL_00B0: IL_3F
    IL_00B1: IL_41
    IL_00B3: ldloc.s 0
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x04000288
    IL_00BC: conv.r8
    IL_00BD: IL_B0
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: stloc.0
    IL_00C1: ldc.i4.0
    IL_00C2: conv.r8
    IL_00C3: IL_B6
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: stloc.0
    IL_00CB: br IL_0135
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x04000292
    IL_00D6: brfalse IL_0135
    IL_00D7: ldarg.0
    IL_00DC: ldfld 0x0400028A
    IL_00DD: dup
    IL_00DE: conv.r8
    IL_00DF: ldc.i4.2
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: stloc.0
    IL_00E7: call 0x0A000042
    IL_00EC: call 0x0A000024
    IL_00F1: call 0x0A000008
    IL_00F2: IL_22
    IL_00F3: IL_CD
    IL_00F4: IL_CC
    IL_00F5: IL_CC
    IL_00F6: IL_3D
    IL_00FB: call 0x0A000008
    IL_0100: call 0x0A000029
    IL_0101: conv.r8
    IL_0102: ldloc.3
    IL_0103: nop
    IL_0104: nop
    IL_0105: stloc.0
    IL_0106: ldarg.0
    IL_010B: ldfld 0x0400028B
    IL_010C: dup
    IL_010D: conv.r8
    IL_010E: ldc.i4.2
    IL_010F: nop
    IL_0110: nop
    IL_0111: stloc.0
    IL_0116: call 0x0A000062
    IL_011B: call 0x0A000024
    IL_0120: call 0x0A000008
    IL_0121: IL_22
    IL_0122: IL_BC
    IL_0123: conv.u4
    IL_0125: stloc.s 60
    IL_012A: call 0x0A000008
    IL_012F: call 0x0A000029
    IL_0130: conv.r8
    IL_0131: ldloc.3
    IL_0132: nop
    IL_0133: nop
    IL_0134: stloc.0
    IL_0135: ret
    }

    }}
