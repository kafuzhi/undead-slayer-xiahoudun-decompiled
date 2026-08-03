// Namespace: 
// Type: Bullet_wheelwind

    public class Bullet_wheelwind {{

    private object monmovestat;
    private object mytransform;
    private object myparent;
    private object mycollider;
    private object script_mon;

    public Bullet_wheelwind() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x0400020C
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400020C
    IL_0013: conv.r8
    IL_0014: IL_44
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x0400020D
    IL_001D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x0400020C
    IL_0007: conv.r8
    IL_0008: IL_44
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x0400020D
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x0400020D
    IL_0018: conv.r8
    IL_0019: ldc.i4.8
    IL_001A: nop
    IL_001B: nop
    IL_001D: br.s IL_009B
    IL_001F: ldarga.s 2
    IL_0020: nop
    IL_0021: ldarg.2
    IL_0022: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400020C
    IL_000A: call 0x0A000007
    IL_000F: call 0x0A000024
    IL_0014: call 0x0A000008
    IL_0015: IL_22
    IL_0016: nop
    IL_0017: nop
    IL_0018: throw
    IL_0019: IL_C4
    IL_001E: call 0x0A000008
    IL_001F: conv.r8
    IL_0020: IL_B5
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ldarg.0
    IL_0025: ldarg.0
    IL_002A: ldfld 0x0400020F
    IL_002F: ldfld 0x04000061
    IL_0034: stfld 0x0400020B
    IL_0035: ldarg.0
    IL_003A: ldfld 0x0400020B
    IL_003B: ldc.i4.0
    IL_003C: IL_3D
    IL_003D: stloc.2
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0041: ldarg.0
    IL_0046: call 0x0A00000A
    IL_0047: ldc.i4.0
    IL_0048: conv.r8
    IL_0049: stloc.1
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ret
    }

    }}
