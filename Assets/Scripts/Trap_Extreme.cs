// Namespace: 
// Type: Trap_Extreme

    public class Trap_Extreme {{

    private object mytransform;
    private object mycollider;
    public object firerate;
    public object duration;
    public object startdelay;
    public object rndRotation;
    public object startPosY;
    public object startScale;
    public object growScaleSpeed;
    public object movedir;
    public object accuracy;
    public object playAutomatically;
    public object liveObj;
    private object trapOn;
    private object originTrapScale;
    private object target;
    private object scaleUp;
    private object scaleDown;
    private object moveOn;
    private object damage;

    public Trap_Extreme() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x0A547D40
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: nop
    IL_000E: nop
    IL_0013: stsfld 0x0A557D3F
    IL_0014: nop
    IL_0015: ldarg.2
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_3F
    IL_0020: stfld 0x04000A56
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: IL_CD
    IL_0024: IL_CC
    IL_0025: IL_CC
    IL_0026: IL_3D
    IL_002B: stfld 0x04000A5C
    IL_002C: ldarg.0
    IL_002D: ldc.i4.1
    IL_0032: stfld 0x04000A65
    IL_0033: ldarg.0
    IL_0038: call 0x0A000001
    IL_0039: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A52
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000A53
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000A52
    IL_001F: conv.r8
    IL_0024: cpobj 0x7D0A0000
    IL_0025: rem
    IL_0026: stloc.0
    IL_0027: nop
    IL_0028: ldarg.2
    IL_0029: ldarg.0
    IL_002E: ldstr 0x70000001
    IL_0033: call 0x0A000004
    IL_0034: conv.r8
    IL_0035: ldarg.3
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_003D: stfld 0x04000A61
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000A52
    IL_0048: call 0x0A000007
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: rem
    IL_004D: IL_42
    IL_0052: call 0x0A000008
    IL_0053: conv.r8
    IL_0054: ldloc.3
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000A52
    IL_0062: call 0x0A000013
    IL_0063: conv.r8
    IL_0068: call 0x020A0000
    IL_006D: ldfld 0x04000A53
    IL_006E: ldc.i4.0
    IL_006F: conv.r8
    IL_0071: ldc.i4.s 0
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ret
    }

    public void StopActive() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5E
    IL_000A: call 0x0A00004A
    IL_000F: brfalse IL_0020
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000A5E
    IL_001A: ldstr 0x70023131
    IL_001B: conv.r8
    IL_001C: IL_CD
    IL_001D: IL_01
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0025: call 0x0A000081
    IL_0026: ldarg.0
    IL_0027: ldc.i4.0
    IL_002C: stfld 0x04000A5F
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000A62
    IL_0034: ldarg.0
    IL_0035: ldc.i4.0
    IL_003A: stfld 0x04000A63
    IL_003B: ldarg.0
    IL_003C: ldc.i4.0
    IL_0041: stfld 0x04000A64
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000A53
    IL_0048: ldc.i4.0
    IL_0049: conv.r8
    IL_004B: ldc.i4.s 0
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000A52
    IL_0058: call 0x0A000007
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: IL_34
    IL_005D: IL_42
    IL_0062: call 0x0A000008
    IL_0063: conv.r8
    IL_0064: ldloc.3
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ret
    }

    public void SetDamage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5E
    IL_000A: call 0x0A00004A
    IL_000F: brfalse IL_0026
    IL_0010: ldarg.0
    IL_0015: ldstr 0x7002314B
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_151EC091D: switch (1417347648 cases)
    }

    private void LiveObjOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5E
    IL_000A: ldstr 0x70023175
    IL_000B: conv.r8
    IL_000C: IL_CD
    IL_000D: IL_01
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ret
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
    IL_000C: ldc.i4.s 15
    IL_01B5: switch (105 cases)
    }

    public void DirectFire() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5F
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A52
    IL_0012: ldarg.1
    IL_0013: conv.r8
    IL_0014: ldloc.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_001D: call 0x060005C4
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000A57
    IL_0028: brfalse IL_004F
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000A52
    IL_002F: IL_22
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: nop
    IL_0034: ldc.i4.0
    IL_0039: ldc.i4 360
    IL_003E: call 0x0A000045
    IL_003F: conv.i2
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0049: call 0x0A000060
    IL_004A: conv.r8
    IL_004F: call 0x2A0A0000
    }

    private void Emit_trap() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5F
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A52
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A60
    IL_0018: conv.r8
    IL_0019: IL_AF
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000A5A
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_002C: beq IL_0034
    IL_002D: ldarg.0
    IL_002E: ldc.i4.1
    IL_0033: stfld 0x04000A62
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000A5B
    IL_003E: call 0x0A00001B
    IL_0043: call 0x0A00001C
    IL_0048: brfalse IL_0050
    IL_0049: ldarg.0
    IL_004A: ldc.i4.1
    IL_004F: stfld 0x04000A64
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000A53
    IL_0056: ldc.i4.1
    IL_0057: conv.r8
    IL_0059: ldc.i4.s 0
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ldarg.0
    IL_0061: ldstr 0x7002319B
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000A55
    IL_006C: call 0x0A00003F
    IL_006D: ret
    }

    private void Disappear_trap() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5F
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_000D: ldc.i4.0
    IL_0012: stfld 0x04000A62
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0019: stfld 0x04000A63
    IL_001A: ldarg.0
    IL_001B: ldc.i4.0
    IL_0020: stfld 0x04000A64
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000A5D
    IL_002B: brfalse IL_004D
    IL_002C: ldarg.0
    IL_0031: ldstr 0x7002315F
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000A54
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_1D4E5: switch (29992 cases)
    }

    private void Ready_trap() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5F
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A61
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A00007E
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000A5C
    IL_0026: call 0x0A000008
    IL_002B: call 0x0A000029
    IL_002C: stloc.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000A58
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_003C: beq IL_004F
    IL_003E: ldloca.s 0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000A58
    IL_0049: stfld 0x0A000023
    IL_004E: br IL_005B
    IL_0050: ldloca.s 0
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_005A: stfld 0x0A000023
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000A52
    IL_0061: ldloc.0
    IL_0062: conv.r8
    IL_0063: ldloc.3
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000A52
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000A59
    IL_0073: conv.r8
    IL_0074: IL_AF
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000A57
    IL_0082: brfalse IL_00A9
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000A52
    IL_0089: IL_22
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: nop
    IL_008E: ldc.i4.0
    IL_0093: ldc.i4 360
    IL_0098: call 0x0A000045
    IL_0099: conv.i2
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_009D: nop
    IL_009E: nop
    IL_00A3: call 0x0A000060
    IL_00A4: conv.r8
    IL_00A9: call 0x020A0000
    IL_00AE: ldstr 0x700231B9
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000A56
    IL_00B9: call 0x0A00003F
    IL_00BA: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A62
    IL_000A: brfalse IL_003D
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000A52
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000A52
    IL_0017: conv.r8
    IL_001C: cpobj 0x020A0000
    IL_0021: ldfld 0x04000A60
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000A5A
    IL_002C: call 0x0A000024
    IL_002D: IL_5A
    IL_0032: call 0x0A0000B2
    IL_0033: conv.r8
    IL_0034: IL_AF
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_003C: br IL_00AB
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000A63
    IL_0047: brfalse IL_00AB
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000A52
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000A52
    IL_0054: conv.r8
    IL_0059: cpobj 0x280A0000
    IL_005A: ldc.i4.5
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_0062: call 0x0A000024
    IL_0067: call 0x0A0000B2
    IL_0068: conv.r8
    IL_0069: IL_AF
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000A52
    IL_0073: conv.r8
    IL_0078: cpobj 0x0A0A0000
    IL_007A: ldloca.s 0
    IL_007F: ldfld 0x0A00005E
    IL_0080: IL_22
    IL_0081: stloc.0
    IL_0082: IL_D7
    IL_0083: IL_23
    IL_0084: IL_3C
    IL_0085: IL_41
    IL_008E: ldc.i8 2905438035116032
    IL_008F: ldarg.2
    IL_0094: call 0x0A000007
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: IL_34
    IL_0099: IL_42
    IL_009E: call 0x0A000008
    IL_009F: conv.r8
    IL_00A0: ldloc.3
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A4: ldarg.0
    IL_00A5: ldc.i4.0
    IL_00AA: stfld 0x04000A63
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x04000A64
    IL_00B5: brfalse IL_00F9
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x04000A52
    IL_00BC: conv.r8
    IL_00BD: ldc.i4.2
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: stloc.0
    IL_00C1: stloc.1
    IL_00C3: ldloca.s 1
    IL_00C8: ldfld 0x0A000023
    IL_00C9: IL_22
    IL_00CA: nop
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: IL_43
    IL_00CF: pop
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000A52
    IL_00D9: dup
    IL_00DA: conv.r8
    IL_00DB: ldc.i4.2
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: stloc.0
    IL_00DF: ldarg.0
    IL_00E4: ldfld 0x04000A5B
    IL_00E9: call 0x0A000024
    IL_00EE: call 0x0A000008
    IL_00F3: call 0x0A000029
    IL_00F4: conv.r8
    IL_00F5: ldloc.3
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: stloc.0
    IL_00F9: ret
    }

    }}
