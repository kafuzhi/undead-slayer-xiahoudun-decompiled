// Namespace: 
// Type: Bullet_spear_Dash

    public class Bullet_spear_Dash {{

    private object mytransform;
    private object originscale;
    private object delay;
    private object shoot;

    public Bullet_spear_Dash() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040001F5
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040001F5
    IL_0013: conv.r8
    IL_0018: cpobj 0x7D0A0000
    IL_0019: IL_F6
    IL_001A: IL_01
    IL_001B: nop
    IL_001C: ldarg.2
    IL_001D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001F5
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040001F6
    IL_000C: conv.r8
    IL_000D: IL_AF
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_001B: stfld 0x040001F7
    IL_001C: ldarg.0
    IL_001D: ldc.i4.0
    IL_0022: stfld 0x040001F8
    IL_0023: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040001F7
    IL_0006: IL_22
    IL_0007: IL_CD
    IL_0008: IL_CC
    IL_0009: IL_CC
    IL_000A: IL_3E
    IL_000B: IL_41
    IL_000C: ldc.i4.1
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x040001F7
    IL_001B: call 0x0A000024
    IL_001C: IL_58
    IL_0021: stfld 0x040001F7
    IL_0026: br IL_0185
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040001F8
    IL_0031: brtrue IL_00ED
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040001F5
    IL_0038: dup
    IL_0039: conv.r8
    IL_003A: ldc.i4.2
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x040001F5
    IL_0044: conv.r8
    IL_0045: IL_22
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_004D: call 0x0A000024
    IL_0052: call 0x0A000008
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0056: IL_C0
    IL_0057: IL_3F
    IL_005C: call 0x0A000008
    IL_0061: call 0x0A000029
    IL_0062: conv.r8
    IL_0063: ldloc.3
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x040001F5
    IL_006D: dup
    IL_006E: conv.r8
    IL_0073: cpobj 0x280A0000
    IL_0074: IL_42
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: IL_22
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_F0
    IL_007C: IL_41
    IL_0081: call 0x0A000008
    IL_0086: call 0x0A000024
    IL_008B: call 0x0A000008
    IL_0090: call 0x0A000029
    IL_0091: conv.r8
    IL_0092: IL_AF
    IL_0093: nop
    IL_0094: nop
    IL_0095: stloc.0
    IL_0096: ldarg.0
    IL_009B: ldfld 0x040001F5
    IL_009C: conv.r8
    IL_00A1: cpobj 0x0A0A0000
    IL_00A3: ldloca.s 0
    IL_00A8: ldfld 0x0A00005C
    IL_00A9: IL_22
    IL_00AA: nop
    IL_00AB: nop
    IL_D50DB0: switch (3490624 cases)
    }

    }}
