// Namespace: 
// Type: Bullet_arrow_general

    public class Bullet_arrow_general {{

    public object accel_factor;
    public object bullet_speed;
    public object growspeed;
    private object mytransform;
    public object delay_finish;
    private object delay;
    private object accel_speed;
    private object originscale;
    private object startscale;

    public Bullet_arrow_general() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_5EDF508: switch (24870208 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400017E
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400017E
    IL_0013: conv.r8
    IL_0018: cpobj 0x7D0A0000
    IL_0019: IL_82
    IL_001A: IL_01
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000182
    IL_0028: stfld 0x04000183
    IL_0029: ldarg.0
    IL_002E: ldflda 0x04000183
    IL_002F: ldc.i4.2
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0039: call 0x0A00001A
    IL_003A: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400017E
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: brtrue IL_6F0A000D
    IL_000D: IL_B0
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldc.i4.1
    IL_0012: conv.r8
    IL_0013: IL_B6
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x0400017E
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000183
    IL_0023: conv.r8
    IL_0024: IL_AF
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ldarg.0
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_0030: stsfld 0x01817DBF
    IL_0031: nop
    IL_0032: ldarg.2
    IL_0033: ldarg.0
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_003D: stfld 0x04000180
    IL_003E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400017E
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400017E
    IL_000C: conv.r8
    IL_0011: cpobj 0x020A0000
    IL_0016: ldfld 0x04000182
    IL_001B: call 0x0A000024
    IL_001C: ldarg.0
    IL_0021: ldfld 0x0400017D
    IL_0022: conv.i2
    IL_0023: IL_5A
    IL_0028: call 0x0A0000B2
    IL_0029: conv.r8
    IL_002A: IL_AF
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000181
    IL_0035: ldarg.0
    IL_003A: ldfld 0x0400017C
    IL_003F: call 0x0A000024
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400017B
    IL_0046: IL_5A
    IL_004B: call 0x0A0000C0
    IL_0050: stfld 0x04000181
    IL_0051: ldarg.0
    IL_0052: dup
    IL_0057: ldfld 0x04000180
    IL_005C: call 0x0A000024
    IL_005D: IL_58
    IL_0062: stfld 0x04000180
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000180
    IL_0069: ldarg.0
    IL_006E: ldfld 0x0400017F
    IL_006F: IL_43
    IL_0071: beq.s IL_0072
    IL_0072: nop
    IL_0073: nop
    IL_0074: ldarg.0
    IL_0079: call 0x0A00000A
    IL_007A: ldc.i4.0
    IL_007B: conv.r8
    IL_007C: stloc.1
    IL_007D: nop
    IL_007E: nop
    IL_007F: stloc.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x0400017E
    IL_0086: ldc.i4.0
    IL_0087: conv.r8
    IL_008C: brtrue IL_6F0A008D
    IL_008D: IL_B0
    IL_008E: nop
    IL_008F: nop
    IL_0090: stloc.0
    IL_0091: ldc.i4.0
    IL_0092: conv.r8
    IL_0093: IL_B6
    IL_0094: nop
    IL_0095: nop
    IL_0096: stloc.0
    IL_0097: ldarg.0
    IL_0098: IL_22
    IL_0099: nop
    IL_009A: nop
    IL_009B: nop
    IL_009C: nop
    IL_00A1: stfld 0x04000180
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000181
    IL_00A8: IL_22
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: nop
    IL_00AD: IL_43
    IL_00AE: IL_36
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x0400017E
    IL_00B8: dup
    IL_00B9: conv.r8
    IL_00BA: ldc.i4.2
    IL_00BB: nop
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x0400017E
    IL_00C4: conv.r8
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: stloc.0
    IL_00CD: call 0x0A000024
    IL_00D2: call 0x0A000008
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000181
    IL_00DD: call 0x0A000008
    IL_00E2: call 0x0A000029
    IL_00E3: conv.r8
    IL_00E4: ldloc.3
    IL_00E5: nop
    IL_00E6: nop
    IL_00E7: stloc.0
    IL_00E8: ret
    }

    }}
