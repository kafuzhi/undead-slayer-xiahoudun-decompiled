// Namespace: 
// Type: Flower_cannon

    public class Flower_cannon {{

    private object myanimation;
    public object cannonball;
    public object trap;
    private object ballPos;
    private object targetPos;
    private object ballPosStartPos;
    private object target;
    private object dy;
    private object posY;
    private object cannonshot;
    private object script_trap;

    public Flower_cannon() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00002A
    IL_000B: stfld 0x0400065A
    IL_000C: ldarg.0
    IL_0011: call 0x0A00002A
    IL_0016: ldstr 0x70002561
    IL_0017: conv.r8
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_22
    IL_001D: IL_CD
    IL_001E: IL_CC
    IL_001F: IL_CC
    IL_0020: IL_3D
    IL_0021: conv.r8
    IL_0023: bgt.s IL_0024
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_002B: call 0x0A00002A
    IL_0030: ldstr 0x7000256F
    IL_0031: conv.r8
    IL_0033: bge.s IL_0034
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_22
    IL_0037: conv.r8
    IL_0039: ldloca.s 131
    IL_003E: brtrue IL_30AE
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70000001
    IL_004A: call 0x0A000004
    IL_004B: conv.r8
    IL_004C: ldarg.3
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0054: stfld 0x04000660
    IL_0055: ldarg.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x0400065C
    IL_005C: conv.r8
    IL_005D: IL_44
    IL_005E: nop
    IL_005F: nop
    IL_0061: br.s IL_00DF
    IL_0062: xor
    IL_0063: ldloc.0
    IL_0064: nop
    IL_0065: ldarg.2
    IL_0066: ldarg.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x0400065B
    IL_006D: conv.r8
    IL_006E: ldc.i4.2
    IL_006F: nop
    IL_0070: nop
    IL_0071: stloc.0
    IL_0076: stfld 0x0400065F
    IL_0077: ret
    }

    public void StartShoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400065A
    IL_000A: ldstr 0x70002561
    IL_000B: conv.r8
    IL_000C: IL_3C
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: pop
    IL_0011: ret
    }

    public void FisnishShoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400065A
    IL_0006: conv.r8
    IL_0009: ldloc 0
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400065A
    IL_0015: ldstr 0x7000256F
    IL_0016: conv.r8
    IL_0017: IL_3C
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: pop
    IL_001C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000663
    IL_000A: brfalse IL_00F2
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400065D
    IL_0012: ldarg.0
    IL_0017: ldfld 0x0400065E
    IL_001C: call 0x0A000024
    IL_0021: call 0x0A0000B2
    IL_0026: stfld 0x0400065D
    IL_0027: ldarg.0
    IL_0028: dup
    IL_002D: ldfld 0x04000662
    IL_0032: call 0x0A000024
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000661
    IL_0039: IL_5A
    IL_003A: IL_58
    IL_003F: stfld 0x04000662
    IL_0040: ldarg.0
    IL_0041: dup
    IL_0046: ldfld 0x04000661
    IL_004B: call 0x0A000024
    IL_004C: IL_22
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_185F565BC: switch (1635604826 cases)
    }

    public void CannonShot() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x0400065F
    IL_000B: stfld 0x0400065D
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000660
    IL_0013: conv.r8
    IL_0014: ldc.i4.2
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x0400065E
    IL_001D: ldarg.0
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: IL_C0
    IL_0022: IL_3F
    IL_0027: stfld 0x04000661
    IL_0028: ldarg.0
    IL_0029: ldarg.0
    IL_002E: ldflda 0x0400065F
    IL_0033: ldfld 0x0A000023
    IL_0038: stfld 0x04000662
    IL_0039: ldarg.0
    IL_003A: ldc.i4.1
    IL_003F: stfld 0x04000663
    IL_0040: ret
    }

    }}
