// Namespace: 
// Type: Ef_meteospash

    public class Ef_meteospash {{

    private object uvAnimationTileX;
    private object uvAnimationTileY;
    private object framesPerSecond;
    private object index;
    private object starttime;
    private object currenttime;
    private object lastframe;
    private object var;

    public Ef_meteospash() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: stfld 0x040005B9
    IL_0007: ldarg.0
    IL_0008: ldc.i4.4
    IL_000D: stfld 0x040005BA
    IL_000E: ldarg.0
    IL_0010: ldc.i4.s 22
    IL_0015: stfld 0x040005BB
    IL_0016: ldarg.0
    IL_001B: call 0x0A000001
    IL_001C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000E9
    IL_000A: stfld 0x040005BD
    IL_000B: ldarg.0
    IL_0010: call 0x0A0000E9
    IL_0015: stfld 0x040005BE
    IL_0016: ldarg.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040005B9
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040005BA
    IL_0023: IL_5A
    IL_0028: stfld 0x040005BF
    IL_0029: ldarg.0
    IL_002E: call 0x0A000002
    IL_002F: IL_22
    IL_0030: shr
    IL_0031: shr
    IL_0036: isinst 0x6666223F
    IL_003B: isinst 0x6666223F
    IL_0040: isinst 0x0076733F
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: conv.r8
    IL_0044: IL_AF
    IL_0045: nop
    IL_0046: nop
    IL_0047: stloc.0
    IL_0048: ldarg.0
    IL_004D: call 0x0A000002
    IL_0052: ldstr 0x700024AD
    IL_0057: call 0x0A000077
    IL_0058: conv.r8
    IL_0059: ldarg.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: conv.r8
    IL_005E: IL_4E
    IL_005F: nop
    IL_0060: nop
    IL_0061: stloc.0
    IL_0062: ldarg.0
    IL_0067: call 0x0A000003
    IL_0068: ldc.i4.1
    IL_0069: conv.r8
    IL_006A: conv.ovf.i4.un
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_006E: ldarg.0
    IL_0073: call 0x0A00000D
    IL_0074: ldc.i4.1
    IL_0075: conv.r8
    IL_007A: beq IL_2A0A007B
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000D
    IL_0006: conv.r8
    IL_0007: IL_C9
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: brfalse IL_019E
    IL_0010: ldarg.0
    IL_0015: call 0x0A000002
    IL_0016: conv.r8
    IL_001B: cpobj 0x130A0000
    IL_001C: ldarg.2
    IL_001E: ldloca.s 4
    IL_0023: ldfld 0x0A00005E
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_0027: rem
    IL_D130: switch (13377 cases)
    }

    }}
