// Namespace: 
// Type: Cam_Loading_Story

    public class Cam_Loading_Story {{

    private object stopCam;
    private object horse;

    public Cam_Loading_Story() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000D0
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000B: ldloc 8770
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_C0
    IL_000F: IL_3F
    IL_0010: IL_22
    IL_0011: stloc.0
    IL_0012: IL_D7
    IL_0013: IL_23
    IL_0014: IL_3C
    IL_0015: IL_22
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldelem.r8
    IL_0019: IL_41
    IL_001E: call 0x0A0000DB
    IL_001F: conv.r8
    IL_0020: IL_D2
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ldarg.0
    IL_0029: ldstr 0x70000B91
    IL_002E: call 0x0A000077
    IL_002F: conv.r8
    IL_0030: ldarg.3
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x04000238
    IL_0039: ret
    }

    public void DisappearCam() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000237
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000237
    IL_000A: brtrue IL_003A
    IL_000B: ldarg.0
    IL_0010: call 0x0A000002
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000238
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_22
    IL_001D: IL_CD
    IL_001E: IL_CC
    IL_001F: IL_CC
    IL_0020: IL_BE
    IL_0021: IL_22
    IL_0022: stloc.0
    IL_0023: IL_D7
    IL_0024: IL_23
    IL_0025: IL_3E
    IL_0026: IL_22
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002F: newobj 0x0A000076
    IL_0034: call 0x0A000029
    IL_0035: conv.r8
    IL_0036: IL_DC
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: ret
    }

    }}
