// Namespace: 
// Type: Cha_Control_ride_horse_story

    public class Cha_Control_ride_horse_story {{

    private object changeScene;
    public object cry;

    public Cha_Control_ride_horse_story() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040003A3
    IL_0007: ldarg.0
    IL_000C: call 0x0A000001
    IL_000D: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A000090
    IL_0010: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_000A: call 0x0A000042
    IL_000B: conv.r8
    IL_000C: ldloc.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: call 0x0A00002A
    IL_001A: ldstr 0x70000DA5
    IL_001B: conv.r8
    IL_001D: bge.s IL_001E
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: IL_22
    IL_0022: bne.un.s IL_0056
    IL_0024: bne.un.s IL_0064
    IL_0025: conv.r8
    IL_0027: bgt.s IL_0028
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: call 0x0A00002A
    IL_0034: ldstr 0x70001737
    IL_0035: conv.r8
    IL_0037: bge.s IL_0038
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: IL_22
    IL_003B: nop
    IL_003C: nop
    IL_0041: stsfld 0x00306F3E
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldarg.0
    IL_0049: call 0x0A00002A
    IL_004E: ldstr 0x70000DA5
    IL_004F: conv.r8
    IL_0050: IL_3C
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: pop
    IL_0055: ret
    }

    public void Scene_third() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: stfld 0x040003A3
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040003A3
    IL_0006: ldc.i4.2
    IL_0007: IL_3D
    IL_0008: ret
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: call 0x0A000002
    IL_0012: dup
    IL_0013: conv.r8
    IL_0014: ldc.i4.2
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: call 0x0A000042
    IL_0021: call 0x0A000024
    IL_0026: call 0x0A000008
    IL_002B: call 0x0A000029
    IL_002C: conv.r8
    IL_002D: ldloc.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: br IL_00D2
    IL_0036: ldarg.0
    IL_003B: ldfld 0x040003A3
    IL_003C: ldc.i4.3
    IL_0281: switch (144 cases)
    }

    }}
