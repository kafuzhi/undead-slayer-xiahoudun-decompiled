// Namespace: 
// Type: Cam_intro

    public class Cam_intro {{

    private object dx;
    private object startui;
    public object UI_intro;
    public object gate;
    public object cha;
    public object mon1;
    public object mon2;
    private object tintcolor;
    private object tintcolor2;

    public Cam_intro() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: IL_CD
    IL_0003: IL_CC
    IL_0004: IL_CC
    IL_0005: IL_3D
    IL_000A: stfld 0x04000276
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000D0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000276
    IL_000C: conv.r8
    IL_000D: IL_F2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: call 0x0A0000F3
    IL_001B: stfld 0x0400027D
    IL_001C: ldarg.0
    IL_0021: call 0x0A0000F4
    IL_0026: stfld 0x0400027E
    IL_0027: ldarg.0
    IL_002C: ldfld 0x0400027A
    IL_002D: conv.r8
    IL_002E: stloc.3
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: conv.r8
    IL_0034: ldarg.s 0
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: ldstr 0x70000B47
    IL_003C: ldarg.0
    IL_0041: ldfld 0x0400027D
    IL_0042: conv.r8
    IL_0043: IL_C6
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x0400027B
    IL_004D: conv.r8
    IL_004E: stloc.3
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: conv.r8
    IL_0054: ldarg.s 0
    IL_0055: nop
    IL_0056: stloc.0
    IL_005B: ldstr 0x70000B47
    IL_005C: ldarg.0
    IL_0061: ldfld 0x0400027E
    IL_0062: conv.r8
    IL_0063: IL_C6
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x0400027C
    IL_006D: conv.r8
    IL_006E: stloc.3
    IL_006F: nop
    IL_0070: nop
    IL_0071: stloc.0
    IL_0072: conv.r8
    IL_0074: ldarg.s 0
    IL_0075: nop
    IL_0076: stloc.0
    IL_007B: ldstr 0x70000B47
    IL_007C: ldarg.0
    IL_0081: ldfld 0x0400027E
    IL_0082: conv.r8
    IL_0083: IL_C6
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_0087: ret
    }

    private void StartGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000278
    IL_0006: conv.r8
    IL_0007: IL_23
    IL_0008: nop
    IL_0009: nop
    IL_000B: br.s IL_007B
    IL_000C: len
    IL_000D: ldloc.0
    IL_000E: nop
    IL_000F: ldloc.0
    IL_0010: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000276
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000E: stsfld 0x0024283F
    IL_000F: nop
    IL_0010: stloc.0
    IL_0015: call 0x0A000025
    IL_001A: stfld 0x04000276
    IL_001B: ldarg.0
    IL_0020: call 0x0A0000D0
    IL_0021: IL_22
    IL_0022: nop
    IL_0023: nop
    IL_0024: IL_C0
    IL_0025: IL_BF
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000276
    IL_002C: IL_5A
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_0030: IL_C0
    IL_0031: IL_3F
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000276
    IL_0038: IL_5A
    IL_0039: ldarg.0
    IL_003E: ldfld 0x04000276
    IL_003F: shl
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000276
    IL_0046: IL_22
    IL_0047: ldelem.i
    IL_0048: IL_99
    IL_0049: IL_99
    IL_004A: IL_3E
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_004E: ldelem.r8
    IL_344F3: switch (53544 cases)
    }

    }}
