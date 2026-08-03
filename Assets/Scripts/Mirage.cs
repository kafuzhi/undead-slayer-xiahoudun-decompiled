// Namespace: 
// Type: Mirage

    public class Mirage {{

    private object mytransform;
    private object delay_finish;
    private object bouncescale;
    private object startscale;
    private object mypos;
    private object dropdown;
    private object bounce;
    private object move;
    private object directionVector;

    public Mirage() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x0000223F
    IL_000D: stsfld 0x0000223F
    IL_000E: nop
    IL_1D9DF: switch (30323 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040007F9
    IL_000C: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040007F9
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040007FC
    IL_000C: conv.r8
    IL_000D: IL_AF
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: IL_22
    IL_0013: IL_CD
    IL_0014: IL_CC
    IL_0015: IL_4C
    IL_0016: IL_3E
    IL_001B: stfld 0x040007FE
    IL_001C: ldarg.0
    IL_001D: ldc.i4.0
    IL_0022: stfld 0x04000800
    IL_0023: ldarg.0
    IL_0024: ldc.i4.0
    IL_0029: stfld 0x040007FF
    IL_002A: ldarg.0
    IL_002B: IL_22
    IL_002C: nop
    IL_002D: nop
    IL_002E: nop
    IL_002F: nop
    IL_0034: stfld 0x040007FA
    IL_0035: ldarg.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x040007F9
    IL_003C: conv.r8
    IL_003D: ldc.i4.2
    IL_003E: nop
    IL_003F: nop
    IL_0040: stloc.0
    IL_0045: stfld 0x040007FD
    IL_0046: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000800
    IL_000A: brfalse IL_0154
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x040007FD
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000801
    IL_001C: call 0x0A000024
    IL_0021: call 0x0A000008
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: IL_C0
    IL_0026: IL_3F
    IL_002B: call 0x0A000008
    IL_0030: call 0x0A000029
    IL_0035: stfld 0x040007FD
    IL_0036: ldarg.0
    IL_003B: ldfld 0x040007FF
    IL_0040: brtrue IL_009A
    IL_0041: ldarg.0
    IL_0042: dup
    IL_0047: ldfld 0x040007FE
    IL_004C: call 0x0A000024
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_1F5656954: switch (2103007808 cases)
    }

    }}
