// Namespace: 
// Type: Bullet_trigger

    public class Bullet_trigger {{

    public object bullet_speed;
    private object mytransform;
    public object bullet_splash;
    private object c_splash;
    private object delay_finish;

    public Bullet_trigger() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000207
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000208
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000207
    IL_000D: conv.r8
    IL_000E: ldc.i4.2
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0016: call 0x0A000013
    IL_001B: call 0x0A000014
    IL_001C: conv.u4
    IL_001D: ldarg.1
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000209
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000209
    IL_002C: conv.r8
    IL_002D: stloc.0
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: ldc.i4.0
    IL_0032: conv.r8
    IL_0033: stloc.1
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000209
    IL_003D: conv.r8
    IL_003E: IL_3D
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0047: call 0x0A00003D
    IL_0048: conv.r8
    IL_004B: ldarga 0
    IL_004C: stloc.0
    IL_004D: conv.r8
    IL_004E: IL_84
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.8
    IL_01AC: switch (103 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400020A
    IL_0006: IL_22
    IL_0007: IL_CD
    IL_0008: IL_CC
    IL_0009: IL_CC
    IL_000A: IL_3E
    IL_000B: IL_43
    IL_000C: ldc.i4.1
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: call 0x0A00000A
    IL_0016: ldc.i4.0
    IL_0017: conv.r8
    IL_0018: stloc.1
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0026: stfld 0x0400020A
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000207
    IL_002D: dup
    IL_002E: conv.r8
    IL_002F: ldc.i4.2
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000207
    IL_0039: conv.r8
    IL_003A: IL_22
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_0042: call 0x0A000024
    IL_0047: call 0x0A000008
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000206
    IL_0052: call 0x0A000008
    IL_0057: call 0x0A000029
    IL_0058: conv.r8
    IL_0059: ldloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ret
    }

    }}
