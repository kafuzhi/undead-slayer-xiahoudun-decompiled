// Namespace: 
// Type: Bullet_jumpsplash

    public class Bullet_jumpsplash {{

    private object mytransform;
    public object postune;
    private object originScale;
    private object growVector;
    private object currentColor;
    private object transColor;
    private object targetColor;
    private object myrenderer;
    private object mycollider;

    public Bullet_jumpsplash() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x0000223F
    IL_0009: nop
    IL_000A: IL_41
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_0012: stsfld 0x0076733F
    IL_0013: nop
    IL_0014: stloc.0
    IL_0019: stfld 0x040001BA
    IL_001A: ldarg.0
    IL_001B: IL_22
    IL_001C: IL_CD
    IL_001D: IL_CC
    IL_001E: IL_4C
    IL_001F: IL_3F
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0023: nop
    IL_0024: IL_C0
    IL_0025: IL_22
    IL_0026: IL_CD
    IL_0027: IL_CC
    IL_0028: IL_4C
    IL_0029: IL_3F
    IL_002E: newobj 0x0A000076
    IL_0033: stfld 0x040001BB
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: IL_3F
    IL_003A: IL_22
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: IL_3F
    IL_003F: IL_22
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0043: IL_3F
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: nop
    IL_004D: newobj 0x0A0000C4
    IL_0052: stfld 0x040001BE
    IL_0053: ldarg.0
    IL_0058: call 0x0A000001
    IL_0059: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001B8
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0017: stfld 0x040001BF
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A000003
    IL_0023: stfld 0x040001C0
    IL_0024: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001B8
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040001BA
    IL_000C: conv.r8
    IL_000D: IL_AF
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040001B8
    IL_0017: dup
    IL_0018: conv.r8
    IL_0019: ldc.i4.2
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040001B8
    IL_0023: conv.r8
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040001B9
    IL_0032: call 0x0A000008
    IL_0037: call 0x0A000029
    IL_0038: conv.r8
    IL_0039: ldloc.3
    IL_003A: nop
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: ldarg.0
    IL_0042: ldfld 0x040001BF
    IL_0043: conv.r8
    IL_0045: ldarg.s 0
    IL_0046: nop
    IL_0047: stloc.0
    IL_004C: ldstr 0x70000B47
    IL_0051: call 0x0A0000C5
    IL_0052: conv.r8
    IL_0053: IL_C6
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: ldarg.0
    IL_005C: ldfld 0x040001C0
    IL_005D: ldc.i4.1
    IL_005E: conv.r8
    IL_0060: ldc.i4.s 0
    IL_0061: nop
    IL_0062: stloc.0
    IL_0063: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001B8
    IL_0006: dup
    IL_0007: conv.r8
    IL_000C: cpobj 0x020A0000
    IL_0011: ldfld 0x040001BB
    IL_0016: call 0x0A000024
    IL_001B: call 0x0A000008
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_E0
    IL_20C4: switch (2088 cases)
    }

    }}
