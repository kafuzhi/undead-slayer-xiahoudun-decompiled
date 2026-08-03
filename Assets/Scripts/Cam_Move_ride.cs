// Namespace: 
// Type: Cam_Move_ride

    public class Cam_Move_ride {{

    public object cha1;
    private object mytransform;
    private object camPos;
    private object dx;
    private object hit_shake1;
    private object mycamera;

    public Cam_Move_ride() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_0006: IL_22
    IL_0007: shr
    IL_0008: shr
    IL_000D: isinst 0xCCCD223F
    IL_000E: IL_4C
    IL_000F: IL_BF
    IL_0014: newobj 0x0A000076
    IL_0019: stfld 0x0400025B
    IL_001A: ldarg.0
    IL_001B: ldc.i4.1
    IL_0020: stfld 0x0400025C
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: IL_CD
    IL_0024: IL_CC
    IL_0025: IL_CC
    IL_0026: IL_3D
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_22
    IL_002D: IL_8F
    IL_002E: IL_C2
    IL_002F: conv.u8
    IL_0030: IL_3D
    IL_0035: newobj 0x0A000076
    IL_003A: stfld 0x0400025D
    IL_003B: ldarg.0
    IL_0040: call 0x0A000001
    IL_0041: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400025A
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A0000D0
    IL_0017: stfld 0x0400025E
    IL_0018: ret
    }

    public void Hitcam() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x0400025C
    IL_0007: shl
    IL_000C: stfld 0x0400025C
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400025A
    IL_0013: dup
    IL_0014: conv.r8
    IL_0015: ldc.i4.2
    IL_0016: nop
    IL_0017: nop
    IL_0018: stloc.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x0400025D
    IL_001F: ldarg.0
    IL_0024: ldfld 0x0400025C
    IL_0025: conv.i2
    IL_002A: call 0x0A000008
    IL_002F: call 0x0A000029
    IL_0030: conv.r8
    IL_0031: ldloc.3
    IL_0032: nop
    IL_0033: nop
    IL_0034: stloc.0
    IL_0035: ldarg.0
    IL_003A: ldfld 0x0400025E
    IL_003B: conv.r8
    IL_003C: IL_E7
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0043: IL_B8
    IL_0044: IL_41
    IL_0045: IL_43
    IL_0046: ldc.i4.1
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: ldarg.0
    IL_004F: ldfld 0x0400025E
    IL_0050: dup
    IL_0051: conv.r8
    IL_0052: IL_E7
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: IL_22
    IL_0057: nop
    IL_0058: nop
    IL_005D: stsfld 0xE66F593F
    IL_005E: nop
    IL_005F: nop
    IL_0060: stloc.0
    IL_0061: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400025A
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000259
    IL_000C: conv.r8
    IL_000D: IL_E8
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x0400025A
    IL_0017: ldarg.0
    IL_001C: ldfld 0x0400025B
    IL_0021: call 0x0A000062
    IL_0026: call 0x0A0000E9
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_3F
    IL_002C: IL_5A
    IL_0031: call 0x0A0000EA
    IL_0036: call 0x0A000008
    IL_0037: IL_22
    IL_0038: IL_CD
    IL_0039: IL_CC
    IL_003A: IL_4C
    IL_003B: IL_3F
    IL_0040: call 0x0A000008
    IL_0045: call 0x0A000029
    IL_0046: conv.r8
    IL_0047: ldloc.3
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: ldarg.0
    IL_0050: ldfld 0x0400025E
    IL_0051: conv.r8
    IL_0052: IL_E7
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: IL_22
    IL_0057: nop
    IL_0058: nop
    IL_0059: ldc.i4.2
    IL_005A: IL_42
    IL_005B: IL_41
    IL_005D: bgt.s IL_005E
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400025E
    IL_0066: ldarg.0
    IL_006B: ldfld 0x0400025E
    IL_006C: conv.r8
    IL_006D: IL_E7
    IL_006E: nop
    IL_006F: nop
    IL_0070: stloc.0
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: ldc.i4.2
    IL_0075: IL_42
    IL_007A: call 0x0A000024
    IL_007B: IL_22
    IL_007C: nop
    IL_007D: nop
    IL_94A16982: switch (623401536 cases)
    }

    }}
