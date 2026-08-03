// Namespace: 
// Type: Cha_Control_ride_horse

    public class Cha_Control_ride_horse {{

    public object map;
    private object mytransform;
    private object pickPoint;
    private object prevPoint;
    private object startdelay;
    private object isintro;
    private object dubbleclick;
    private object movespeed;
    private object action_delay;
    private object finish;
    private object changeScene;
    public object run;
    public object behit;
    public object jump;
    public object pt_stepfog;
    private object monmovestat;
    private object dragStartpos;
    private object dragSumposY;
    private object dragdistanceY;
    private object keydown;
    private object casthit;
    private object rightlean;
    private object leftlean;
    public object tex_stepfog;
    public object cha1;
    private object script_cha;

    public Cha_Control_ride_horse() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x0400038E
    IL_0007: ldarg.0
    IL_000C: call 0x0A000057
    IL_0011: stfld 0x04000399
    IL_0012: ldarg.0
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_001A: stsfld 0x0000223F
    IL_001B: nop
    IL_001C: nop
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_1D9F1: switch (30323 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_000A: call 0x0A000090
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: call 0x0A000002
    IL_0016: stfld 0x0400038A
    IL_0017: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040003A1
    IL_0007: conv.r8
    IL_0009: starg.s 0
    IL_000A: nop
    IL_000C: br.s IL_008A
    IL_0011: stelem 0x02040003
    IL_0016: ldfld 0x0400038A
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: IL_22
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0025: IL_BF
    IL_002A: newobj 0x0A000076
    IL_002B: conv.r8
    IL_002C: ldloc.3
    IL_002D: nop
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldarg.0
    IL_0035: call 0x0A00002A
    IL_003A: ldstr 0x70000DA5
    IL_003B: conv.r8
    IL_003D: bge.s IL_003E
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: IL_22
    IL_0042: bne.un.s IL_0076
    IL_0044: bne.un.s IL_0084
    IL_0045: conv.r8
    IL_0047: bgt.s IL_0048
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ldarg.0
    IL_004F: call 0x0A00002A
    IL_0054: ldstr 0x70001721
    IL_0055: conv.r8
    IL_0057: bge.s IL_0058
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: IL_22
    IL_005F: ldfld 0x6F3EAE14
    IL_0061: bgt.s IL_0062
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldarg.0
    IL_0069: call 0x0A00002A
    IL_006E: ldstr 0x70001737
    IL_006F: conv.r8
    IL_0071: bge.s IL_0072
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: IL_22
    IL_0075: nop
    IL_0076: nop
    IL_0077: nop
    IL_0078: IL_3F
    IL_0079: conv.r8
    IL_007B: bgt.s IL_007C
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: ldarg.0
    IL_0083: call 0x0A00002A
    IL_0088: ldstr 0x70001721
    IL_0089: conv.r8
    IL_008B: bge.s IL_008C
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: ldc.i4.1
    IL_008F: conv.r8
    IL_0091: ble.s IL_0092
    IL_0092: nop
    IL_0093: stloc.0
    IL_0094: ldarg.0
    IL_0099: call 0x0A00002A
    IL_009E: ldstr 0x70001737
    IL_009F: conv.r8
    IL_00A1: bge.s IL_00A2
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A4: ldc.i4.2
    IL_00A5: conv.r8
    IL_00A7: ble.s IL_00A8
    IL_00A8: nop
    IL_00A9: stloc.0
    IL_00AA: ldarg.0
    IL_00AF: call 0x0A00002A
    IL_00B4: ldstr 0x70000DA5
    IL_00B5: conv.r8
    IL_00B6: IL_3C
    IL_00B7: nop
    IL_00B8: nop
    IL_00B9: stloc.0
    IL_00BA: pop
    IL_00BF: ldstr 0x7000174B
    IL_00C4: call 0x06000220
    IL_00C5: stloc.0
    IL_00C6: ldarg.0
    IL_00CB: ldfld 0x04000397
    IL_00CC: conv.r8
    IL_00CD: stloc.3
    IL_00CE: nop
    IL_00CF: nop
    IL_00D0: stloc.0
    IL_00D1: conv.r8
    IL_00D2: neg
    IL_00D3: nop
    IL_00D4: nop
    IL_00D5: stloc.0
    IL_00D6: ldarg.0
    IL_00DB: ldfld 0x040003A0
    IL_00DC: ldloc.0
    IL_00DD: ldc.i4.1
    IL_00DE: IL_59
    IL_00DF: ldelem.i
    IL_00E0: conv.r8
    IL_00E2: ldarga.s 0
    IL_00E3: nop
    IL_00E4: stloc.0
    IL_00E5: ret
    }

    public void RidingFinish() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000394
    IL_000C: conv.r8
    IL_000D: IL_4C
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: call 0x0A00002B
    IL_0017: conv.r8
    IL_0018: IL_4D
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_001D: ldc.i4.1
    IL_0022: stfld 0x0400038E
    IL_0023: ldarg.0
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_002D: stfld 0x0400038D
    IL_002E: ldarg.0
    IL_002F: ldc.i4.1
    IL_0034: stfld 0x04000392
    IL_0035: ldarg.0
    IL_003A: ldfld 0x040003A2
    IL_003B: conv.r8
    IL_0040: isinst 0x2A060001
    }

    public void FallDown() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000392
    IL_000A: brtrue IL_0036
    IL_000B: ldarg.0
    IL_0010: call 0x0A00003D
    IL_0015: call 0x0A000042
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: ldarg.0
    IL_001A: IL_C3
    IL_001F: call 0x0A000008
    IL_0020: conv.r8
    IL_0021: IL_3E
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldarg.0
    IL_002A: call 0x0A00002A
    IL_002F: ldstr 0x70001737
    IL_0030: conv.r8
    IL_0031: IL_3C
    IL_0032: nop
    IL_0033: nop
    IL_0034: stloc.0
    IL_0035: pop
    IL_0036: ret
    }

    public void HorseJump() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000396
    IL_000C: conv.r8
    IL_000D: IL_4C
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: call 0x0A00002B
    IL_0017: conv.r8
    IL_0018: IL_4D
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: call 0x0A00002A
    IL_0026: ldstr 0x70001721
    IL_0027: conv.r8
    IL_0028: IL_3C
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_002C: pop
    IL_002D: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400038E
    IL_000A: brfalse IL_0208
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000392
    IL_0015: brfalse IL_0188
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000393
    IL_001C: ldc.i4.2
    IL_0035: switch (5 cases)
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_003D: call 0x0A00001B
    IL_003E: conv.r8
    IL_003F: ldloc.3
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ldarg.0
    IL_0048: call 0x0A00002A
    IL_004D: ldstr 0x70001769
    IL_004E: conv.r8
    IL_004F: IL_3C
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: pop
    IL_0054: ldarg.0
    IL_0059: call 0x0A00002B
    IL_005A: conv.r8
    IL_005B: IL_FB
    IL_005C: nop
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: ldarg.0
    IL_0064: call 0x0A00002A
    IL_0065: conv.r8
    IL_0068: ldloc 0
    IL_0069: stloc.0
    IL_006A: ldarg.0
    IL_006F: call 0x0A00002A
    IL_0074: ldstr 0x70001737
    IL_0075: conv.r8
    IL_0077: bge.s IL_0078
    IL_0078: nop
    IL_0079: stloc.0
    IL_007A: IL_22
    IL_007B: nop
    IL_007C: nop
    IL_0081: stsfld 0x00306F3E
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0089: call 0x0A00002A
    IL_008E: ldstr 0x70001737
    IL_008F: conv.r8
    IL_0090: IL_3C
    IL_0091: nop
    IL_0092: nop
    IL_0093: stloc.0
    IL_0094: pop
    IL_0095: ldarg.0
    IL_009A: call 0x0A00002B
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000395
    IL_00A1: conv.r8
    IL_00A2: ldind.ref
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00A6: ldarg.0
    IL_00AB: call 0x0A00002A
    IL_00B0: ldstr 0x70001769
    IL_00B1: conv.r8
    IL_00B6: newobj 0x0A0A0000
    IL_00B7: ldloc.0
    IL_00B8: ldc.i4.2
    IL_00B9: conv.r8
    IL_00BB: ble.s IL_00BC
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00BE: ldloc.0
    IL_00BF: IL_22
    IL_00C0: IL_CD
    IL_00C1: IL_CC
    IL_00C2: IL_CC
    IL_00C3: IL_3D
    IL_00C4: conv.r8
    IL_00C6: bgt.s IL_00C7
    IL_00C7: nop
    IL_00C8: stloc.0
    IL_00C9: ldarg.0
    IL_00CA: ldc.i4.2
    IL_00CF: stfld 0x04000393
    IL_00D4: br IL_0183
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x04000393
    IL_00DF: brtrue IL_0183
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x0400038A
    IL_00E6: conv.r8
    IL_00E7: ldc.i4.2
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: stloc.0
    IL_00EB: stloc.3
    IL_00ED: ldloca.s 3
    IL_00F2: ldfld 0x0A00005C
    IL_00F3: IL_22
    IL_00F4: nop
    IL_00F5: nop
    IL_00F6: nop
    IL_C607: switch (12611 cases)
    }

    }}
