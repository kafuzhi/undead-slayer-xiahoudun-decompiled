// Namespace: 
// Type: SpiritSword_p2

    public class SpiritSword_p2 {{

    private object fireon;
    private object mytransform;
    private object target;
    private object myparent;
    private object targetpos;
    private object directionVector;
    private object dt;
    private object mycollider;
    private object mytrail;

    public SpiritSword_p2() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009B6
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040009BC
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x2B00004A
    IL_0023: stfld 0x040009BD
    IL_0024: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009BC
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0016: stfld 0x040009BB
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040009BD
    IL_001D: ldc.i4.1
    IL_001E: conv.r8
    IL_0023: beq IL_20A0024
    IL_0024: ldc.i4.1
    IL_0029: stfld 0x040009B5
    IL_002A: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040009B6
    IL_0007: conv.r8
    IL_0008: IL_CD
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x040009B8
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040009B8
    IL_001C: call 0x0600052C
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040009B6
    IL_0023: ldnull
    IL_0024: conv.r8
    IL_0025: IL_4E
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: ret
    }

    public void FireSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009BC
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x040009B7
    IL_0013: ret
    }

    public void FinishSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009BC
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldc.i4.0
    IL_0012: stfld 0x040009B5
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: nop
    IL_001D: stfld 0x040009BB
    IL_001E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009B5
    IL_000A: brfalse IL_01A8
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009B6
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0025: stloc.s 1
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040009B7
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040009B8
    IL_0038: call 0x0A000061
    IL_003D: brfalse IL_004E
    IL_003E: ldarg.0
    IL_003F: IL_22
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_26EE3B: switch (637821 cases)
    }

    }}
