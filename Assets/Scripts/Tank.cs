// Namespace: 
// Type: Tank

    public class Tank {{

    private object script_hpbar;
    private object script_castle;
    public object snd_break;
    public object snd_hit;
    public object pt_hit;
    public object tank_destroy;
    public object behit_collider;
    private object mytransform;
    private object hpbar;
    private object c_destroy;
    private object myanimation;
    private object delay;
    private object movespeed;
    private object damage;
    private object maxhp;
    private object hp;
    private object life;
    private object super;
    private object stophit;
    private object cur_stage_index;
    private object script_cam;

    public Tank() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: IL_CD
    IL_0003: IL_CC
    IL_0004: IL_CC
    IL_0005: IL_3D
    IL_000A: stfld 0x040009FC
    IL_000B: ldarg.0
    IL_000C: ldc.i4.1
    IL_0011: stfld 0x04000A00
    IL_0012: ldarg.0
    IL_0017: call 0x0A000001
    IL_0018: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000CDD
    IL_000A: call 0x06000220
    IL_000B: neg
    IL_0010: stfld 0x04000A03
    IL_0011: ldarg.0
    IL_0016: ldc.i4 200
    IL_0017: ldc.i4.3
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000A03
    IL_001E: IL_5A
    IL_001F: IL_58
    IL_0020: neg
    IL_0025: stfld 0x040009FE
    IL_0026: ldarg.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040009FE
    IL_0031: stfld 0x040009FF
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: call 0x0A000002
    IL_003D: stfld 0x040009F7
    IL_003E: ldarg.0
    IL_003F: ldarg.0
    IL_0044: call 0x0A00002A
    IL_0049: stfld 0x040009FA
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040009F7
    IL_0054: call 0x0A000042
    IL_0059: call 0x0A000043
    IL_005A: IL_22
    IL_005C: bne.un.s IL_0090
    IL_005E: bne.un.s IL_009E
    IL_0063: call 0x0A000008
    IL_0064: conv.r8
    IL_0065: ldloc.3
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: ldarg.0
    IL_006E: ldstr 0x7000012D
    IL_0073: call 0x0A000004
    IL_0074: conv.r8
    IL_0075: ldloc.1
    IL_0076: nop
    IL_0077: nop
    IL_0079: br.s IL_009C
    IL_007A: IL_CD
    IL_007B: IL_CC
    IL_007C: IL_CC
    IL_007D: IL_3D
    IL_007E: IL_22
    IL_007F: stloc.0
    IL_0080: IL_D7
    IL_0081: stelem.i
    IL_0082: IL_3C
    IL_0087: newobj 0x0A000038
    IL_0088: ldc.i4.0
    IL_0089: ldc.i4.1
    IL_008A: conv.r8
    IL_008B: IL_BE
    IL_008C: ldarg.1
    IL_008D: nop
    IL_008E: ldloc.0
    IL_0093: stfld 0x040009F8
    IL_0094: ldarg.0
    IL_0099: ldfld 0x040009F8
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040009F7
    IL_00A0: conv.r8
    IL_00A1: ldc.i4.2
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A9: call 0x0A000007
    IL_00AA: IL_22
    IL_00AB: ldelem.i
    IL_00AC: IL_99
    IL_00AD: IL_99
    IL_00AE: IL_3E
    IL_00B3: call 0x0A000008
    IL_00B8: call 0x0A000029
    IL_00B9: conv.r8
    IL_00BA: ldloc.3
    IL_00BB: nop
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x040009F8
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x040009F7
    IL_00CA: conv.r8
    IL_00CB: IL_4E
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: stloc.0
    IL_00CF: ldarg.0
    IL_00D0: ldarg.0
    IL_00D5: ldfld 0x040009F8
    IL_00D6: conv.r8
    IL_00D7: ldloc.2
    IL_00D8: nop
    IL_00D9: nop
    IL_00DB: br.s IL_0159
    IL_00DC: IL_F0
    IL_00DD: ldloc.3
    IL_00DE: nop
    IL_00DF: ldarg.2
    IL_00E0: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000A00
    IL_0007: ldarg.0
    IL_000C: ldfld 0x040009F6
    IL_000D: conv.r8
    IL_000E: ldarg.1
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009FA
    IL_000A: ldstr 0x70022F9F
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0011: IL_CD
    IL_0012: IL_CC
    IL_0013: IL_CC
    IL_0014: IL_3E
    IL_0015: conv.r8
    IL_0017: bgt.s IL_0018
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x040009FA
    IL_0024: ldstr 0x70022FB1
    IL_0025: conv.r8
    IL_0027: bge.s IL_0028
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: IL_22
    IL_002B: ldelem.i
    IL_002C: IL_99
    IL_002D: IL_99
    IL_002E: IL_3E
    IL_002F: conv.r8
    IL_0031: bgt.s IL_0032
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: ldfld 0x040009FA
    IL_003E: ldstr 0x70022FC9
    IL_003F: conv.r8
    IL_0041: bge.s IL_0042
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: IL_22
    IL_0045: ldelem.i
    IL_0046: IL_99
    IL_0047: IL_99
    IL_0048: IL_3E
    IL_0049: conv.r8
    IL_004B: bgt.s IL_004C
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: call 0x0A00002B
    IL_0054: conv.r8
    IL_0055: IL_4D
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005E: ldstr 0x70022DCB
    IL_0063: call 0x0A000004
    IL_0064: conv.r8
    IL_0065: IL_78
    IL_0066: nop
    IL_0067: nop
    IL_0069: br.s IL_00E7
    IL_006A: IL_F1
    IL_006B: ldloc.3
    IL_006C: nop
    IL_006D: ldarg.2
    IL_006E: ldarg.0
    IL_0073: call 0x0A000035
    IL_0074: conv.r8
    IL_0075: ldloc.0
    IL_0076: nop
    IL_0077: nop
    IL_0079: br.s IL_00F7
    IL_007A: ldarg.2
    IL_007B: stloc.0
    IL_007C: nop
    IL_007D: ldarg.2
    IL_007E: ret
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A00
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A01
    IL_0016: brfalse IL_0018
    IL_0017: ret
    IL_0018: ldarg.0
    IL_001A: ldarga.s 1
    IL_001F: ldfld 0x0A000023
    IL_0020: not
    IL_0025: stfld 0x040009FD
    IL_0027: ldarga.s 1
    IL_0028: ldc.i4.1
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_0032: call 0x0A00001A
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040009FA
    IL_0039: conv.r8
    IL_003C: ldloc 0
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x040009FA
    IL_0048: ldstr 0x70022FB1
    IL_0049: conv.r8
    IL_004A: IL_3C
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: pop
    IL_004F: ldarg.0
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: nop
    IL_27EE4C: switch (654205 cases)
    }

    public void HurryUp() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: IL_3F
    IL_000A: stfld 0x040009FC
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009FA
    IL_0015: ldstr 0x70022F9F
    IL_0016: conv.r8
    IL_0018: bge.s IL_0019
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_C1DF: switch (12399 cases)
    }

    public void AttakCastle() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009F1
    IL_0006: conv.r8
    IL_0007: IL_B8
    IL_0008: ldarg.3
    IL_0009: nop
    IL_000A: ldloc.0
    IL_000F: brtrue IL_0017
    IL_0010: ldarg.0
    IL_0011: ldc.i4.1
    IL_0016: stfld 0x04000A02
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000A04
    IL_001D: conv.r8
    IL_001E: IL_35
    IL_001F: IL_01
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: call 0x0A00002B
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040009F3
    IL_002E: conv.r8
    IL_002F: ldind.ref
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A00
    IL_000A: brtrue IL_0010
    IL_000F: br IL_0106
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040009FB
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_43
    IL_001C: neg
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: ldarg.0
    IL_0021: dup
    IL_0026: ldfld 0x040009FB
    IL_002B: call 0x0A000024
    IL_002C: IL_59
    IL_0031: stfld 0x040009FB
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040009FB
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: IL_42
    IL_0042: ldc.i4 33554432
    IL_0047: ldfld 0x040009FA
    IL_004C: ldstr 0x70022F9F
    IL_004D: conv.r8
    IL_004E: IL_55
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ldarg.0
    IL_0057: call 0x0A00002B
    IL_0058: conv.r8
    IL_0059: IL_4D
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_0061: br IL_0083
    IL_0062: ldarg.0
    IL_0067: ldfld 0x040009FB
    IL_0068: IL_22
    IL_0069: nop
    IL_006A: nop
    IL_006B: IL_C0
    IL_006C: IL_3F
    IL_006D: IL_41
    IL_006F: ldloc.s 0
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040009F4
    IL_0078: conv.r8
    IL_0079: IL_B0
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: ldc.i4.0
    IL_007E: conv.r8
    IL_007F: IL_B6
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0087: br IL_0106
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04000A02
    IL_0092: brfalse IL_0098
    IL_0097: br IL_0106
    IL_0098: ldarg.0
    IL_009D: ldfld 0x040009F7
    IL_009E: conv.r8
    IL_009F: ldc.i4.2
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: stloc.0
    IL_00A5: ldloca.s 0
    IL_00AA: ldfld 0x0A00005C
    IL_00AB: IL_22
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: ldnull
    IL_00AF: IL_41
    IL_00B0: IL_43
    IL_00B1: ldc.i4.0
    IL_00B2: nop
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x040009FA
    IL_00BF: ldstr 0x70022FC9
    IL_00C0: conv.r8
    IL_00C1: IL_3C
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: stloc.0
    IL_00C5: pop
    IL_00CA: br IL_0106
    IL_00CB: ldarg.0
    IL_00D0: ldfld 0x04000A00
    IL_00D5: brfalse IL_0106
    IL_00D6: ldarg.0
    IL_00DB: ldfld 0x040009F7
    IL_00DC: dup
    IL_00DD: conv.r8
    IL_00DE: ldc.i4.2
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: stloc.0
    IL_00E6: call 0x0A000042
    IL_00EB: call 0x0A000024
    IL_00F0: call 0x0A000008
    IL_00F1: ldarg.0
    IL_00F6: ldfld 0x040009FC
    IL_00FB: call 0x0A000008
    IL_0100: call 0x0A000029
    IL_0101: conv.r8
    IL_0102: ldloc.3
    IL_0103: nop
    IL_0104: nop
    IL_0105: stloc.0
    IL_0106: ret
    }

    }}
