// Namespace: 
// Type: Ef_forge_hammer

    public class Ef_forge_hammer {{

    private object framesPerSecond;
    private object uvAnimationTileX;
    private object uvAnimationTileY;
    private object index;
    private object oldindex;
    private object starttime;
    private object lastframe;
    private object mytransform;
    private object size;
    private object offset;
    private object uIndex;
    private object vIndex;
    private object mymaterial;
    private object anistart;
    private object impact;
    private object script_ui;

    public Ef_forge_hammer() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 20
    IL_0007: stfld 0x040005A2
    IL_0008: ldarg.0
    IL_0009: ldc.i4.4
    IL_000E: stfld 0x040005A3
    IL_000F: ldarg.0
    IL_0010: ldc.i4.4
    IL_0015: stfld 0x040005A4
    IL_0016: ldarg.0
    IL_0017: ldc.i4.m1
    IL_001C: stfld 0x040005A6
    IL_001D: ldarg.0
    IL_0022: call 0x0A000001
    IL_0023: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040005A9
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0013: conv.r8
    IL_0015: ldarg.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x040005AE
    IL_001D: ldarg.0
    IL_0022: ldstr 0x70000BD5
    IL_0027: call 0x0A000004
    IL_0028: conv.r8
    IL_002B: ldarga 0
    IL_002D: br.s IL_00AB
    IL_002E: IL_B1
    IL_002F: ldarg.3
    IL_0030: nop
    IL_0031: ldarg.2
    IL_0032: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x040005A7
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040005A3
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040005A4
    IL_0018: IL_5A
    IL_001D: stfld 0x040005A8
    IL_001E: ldarg.0
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0026: stsfld 0xA37B023F
    IL_0027: ldarg.3
    IL_0028: nop
    IL_0029: ldarg.2
    IL_002A: conv.i2
    IL_002B: add
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_0033: stsfld 0xA47B023F
    IL_0034: ldarg.3
    IL_0035: nop
    IL_0036: ldarg.2
    IL_0037: conv.i2
    IL_0038: add
    IL_003D: newobj 0x0A000038
    IL_0042: stfld 0x040005AA
    IL_0043: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040005A9
    IL_000A: call 0x0A00001B
    IL_000B: conv.r8
    IL_000C: IL_AF
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ret
    }

    public void HammerHit() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040005A5
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x040005A7
    IL_0012: ldarg.0
    IL_0013: ldc.i4.m1
    IL_0018: stfld 0x040005A6
    IL_0019: ldarg.0
    IL_001A: ldc.i4.0
    IL_001F: stfld 0x040005B0
    IL_0020: ldarg.0
    IL_0021: ldc.i4.1
    IL_0026: stfld 0x040005AF
    IL_0027: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040005A9
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040005A9
    IL_000C: conv.r8
    IL_0011: cpobj 0x280A0000
    IL_0012: localloc
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_20BE: switch (2088 cases)
    }

    }}
