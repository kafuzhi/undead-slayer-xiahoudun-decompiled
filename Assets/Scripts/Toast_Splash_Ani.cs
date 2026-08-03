// Namespace: 
// Type: Toast_Splash_Ani

    public class Toast_Splash_Ani {{

    private object uvAnimationTileX;
    private object uvAnimationTileY;
    private object framesPerSecond;
    private object index;
    private object oldindex;
    private object starttime;
    private object lastframe;
    private object size;
    private object offset;
    private object uIndex;
    private object vIndex;
    private object ani_time;
    private object start_snd;
    private object finish_ani;
    private object mymaterial;
    public object ci_hidea;

    public Toast_Splash_Ani() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: stfld 0x04000A15
    IL_0007: ldarg.0
    IL_0008: ldc.i4.5
    IL_000D: stfld 0x04000A16
    IL_000E: ldarg.0
    IL_0010: ldc.i4.s 20
    IL_0015: stfld 0x04000A17
    IL_0016: ldarg.0
    IL_0017: ldc.i4.m1
    IL_001C: stfld 0x04000A19
    IL_001D: ldarg.0
    IL_0022: call 0x0A000001
    IL_0023: ret
    }

    private void Awake() {
    IL_0000: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000A1A
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A15
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A16
    IL_0018: IL_5A
    IL_001D: stfld 0x04000A1B
    IL_001E: ldarg.0
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0026: stsfld 0x157B023F
    IL_0027: stloc.0
    IL_0028: nop
    IL_0029: ldarg.2
    IL_002A: conv.i2
    IL_002B: add
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_0033: stsfld 0x167B023F
    IL_0034: stloc.0
    IL_0035: nop
    IL_0036: ldarg.2
    IL_0037: conv.i2
    IL_0038: add
    IL_003D: newobj 0x0A000038
    IL_0042: stfld 0x04000A1C
    IL_0043: ldarg.0
    IL_0044: ldarg.0
    IL_0049: call 0x0A00000D
    IL_004A: conv.r8
    IL_004C: ldarg.s 0
    IL_004D: nop
    IL_004E: stloc.0
    IL_0053: stfld 0x04000A23
    IL_0054: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000A20
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04000A20
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A22
    IL_001C: brfalse IL_00B8
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000A20
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_002A: stsfld 0x00304340
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000A24
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000A24
    IL_0039: conv.r8
    IL_003E: cpobj 0x280A0000
    IL_003F: ldc.i4.5
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: call 0x0A000024
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004D: ldloc 23108
    IL_0052: call 0x0A0000B2
    IL_0053: conv.r8
    IL_0054: IL_AF
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_005C: br IL_00B7
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000A20
    IL_0063: IL_22
    IL_0064: shr
    IL_0065: shr
    IL_0066: pop
    IL_12977: switch (19011 cases)
    }

    }}
