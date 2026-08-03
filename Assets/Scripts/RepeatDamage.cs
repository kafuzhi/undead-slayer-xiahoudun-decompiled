// Namespace: 
// Type: RepeatDamage

    public class RepeatDamage {{

    private object mycollider;
    public object startdelay;
    public object repeatdelay;

    public RepeatDamage() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: IL_3F
    IL_000A: stfld 0x040008A6
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: IL_CD
    IL_000E: IL_CC
    IL_000F: IL_4C
    IL_0010: IL_3E
    IL_0015: stfld 0x040008A7
    IL_0016: ldarg.0
    IL_001B: call 0x0A000001
    IL_001C: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000003
    IL_000B: stfld 0x040008A5
    IL_000C: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70022A9A
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008A6
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008A7
    IL_0016: call 0x0A000017
    IL_0017: ret
    }

    public void DamageCancel() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000081
    IL_0006: ret
    }

    public void ColliderClick() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008A5
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    }}
