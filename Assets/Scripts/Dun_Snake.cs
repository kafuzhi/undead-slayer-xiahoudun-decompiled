// Namespace: 
// Type: Dun_Snake

    public class Dun_Snake {{

    private object mytransform;
    private object myanimation;
    private object startpos;
    private object targetpos;
    private object delay;
    private object speed;
    public object holes;
    public object trap1;
    public object trap2;
    private object script_trap1;
    private object script_trap2;

    public Dun_Snake() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_1511F508: switch (88374592 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000540
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00002A
    IL_0017: stfld 0x04000541
    IL_0018: ldarg.0
    IL_001D: call 0x0A00002A
    IL_0022: ldstr 0x7000239F
    IL_0023: conv.r8
    IL_0025: bge.s IL_0026
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: IL_22
    IL_0029: ldelem.i
    IL_002A: IL_99
    IL_002B: IL_99
    IL_002C: IL_3E
    IL_002D: conv.r8
    IL_002F: bgt.s IL_0030
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000547
    IL_0039: conv.r8
    IL_003A: IL_44
    IL_003B: nop
    IL_003C: nop
    IL_003E: br.s IL_00BC
    IL_0041: ldloca 5
    IL_0042: ldarg.2
    IL_0043: ldarg.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000548
    IL_004A: conv.r8
    IL_004B: IL_44
    IL_004C: nop
    IL_004D: nop
    IL_004F: br.s IL_00CD
    IL_0052: stloc 5
    IL_0053: ldarg.2
    IL_0054: ret
    }

    private void OnEnable() {
    IL_0000: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000540
    IL_000A: call 0x0A000007
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_C8
    IL_000F: IL_41
    IL_0014: call 0x0A000008
    IL_0015: conv.r8
    IL_0016: ldloc.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_151217: switch (345213 cases)
    }

    public void FisnishShoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000541
    IL_0006: conv.r8
    IL_0009: ldloc 0
    IL_000A: stloc.0
    IL_000B: ret
    }

    public void SetDamage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000549
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_C0
    IL_0009: ldarg.3
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400054A
    IL_0012: ldarg.1
    IL_0013: conv.r8
    IL_0014: IL_C0
    IL_0015: ldarg.3
    IL_0016: nop
    IL_0017: ldloc.0
    IL_0018: ret
    }

    public void StartShoot() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_199999891: switch (1717986850 cases)
    }

    private void PtOn2() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400054A
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000543
    IL_000C: conv.r8
    IL_000D: IL_C3
    IL_000E: ldarg.3
    IL_000F: nop
    IL_0010: ldloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000548
    IL_0017: ldc.i4.0
    IL_0018: conv.r8
    IL_001D: brtrue IL_6F0A001E
    IL_001E: IL_B0
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: ldc.i4.1
    IL_0023: conv.r8
    IL_0024: IL_B6
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ret
    }

    private void Update() {
    IL_0000: ret
    }

    }}
