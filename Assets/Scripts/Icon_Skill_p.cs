// Namespace: 
// Type: Icon_Skill_p

    public class Icon_Skill_p {{

    private object script_IngameUI;
    private object script_chaskill;
    private object script_skillcontrol;
    private object currentSkill;
    private object slotindex;
    private object soulcost;
    private object isskillready;
    private object ispetready;
    private object pause;
    private object roll;
    public object general;
    public object g_skill;
    private object skill_pet_item;
    private object clickon;

    public Icon_Skill_p() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000717
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x04000719
    IL_000E: ldarg.0
    IL_0013: call 0x0A000001
    IL_0014: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: IL_50
    IL_000D: nop
    IL_000E: nop
    IL_0010: br.s IL_008E
    IL_0011: ldc.i4.m1
    IL_0012: ldloc.1
    IL_0013: nop
    IL_0014: ldarg.2
    IL_0015: ldarg.0
    IL_001A: ldstr 0x70000311
    IL_001F: call 0x0A000004
    IL_0020: conv.r8
    IL_0025: ldc.i4 2099970048
    IL_0026: ldc.i4.0
    IL_0027: ldloc.1
    IL_0028: nop
    IL_0029: ldarg.2
    IL_002A: ldarg.0
    IL_002F: ldstr 0x70000BD5
    IL_0034: call 0x0A000004
    IL_0035: conv.r8
    IL_003E: ldc.i8 288238160732422144
    IL_003F: ret
    }

    public void SkillKind() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000718
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_000D: stfld 0x04000717
    IL_000E: ldarg.0
    IL_000F: ldarg.3
    IL_0014: stfld 0x04000720
    IL_0015: ldarg.0
    IL_0017: ldarg.s 4
    IL_001C: stfld 0x04000719
    IL_001D: ret
    }

    public void ThisisPause() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x0400071C
    IL_0007: ret
    }

    public void ThisisRoll() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x0400071D
    IL_0007: ret
    }

    public void SkillColliderOn() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000721
    IL_0007: ldarg.0
    IL_000C: ldfld 0x0400071E
    IL_0011: brfalse IL_0029
    IL_0012: ldarg.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000714
    IL_0019: ldc.i4.0
    IL_001A: conv.r8
    IL_001C: ldarg.s 6
    IL_001D: nop
    IL_001E: ldloc.0
    IL_0023: stfld 0x04000721
    IL_0028: br IL_021C
    IL_0029: ldarg.0
    IL_002E: ldfld 0x0400071F
    IL_0033: brfalse IL_0096
    IL_0034: ldarg.0
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000716
    IL_003F: ldfld 0x040006F8
    IL_0041: ldc.i4.s 20
    IL_0042: IL_94
    IL_0047: stfld 0x0400071A
    IL_0048: ldarg.0
    IL_004D: ldfld 0x0400071A
    IL_004E: ldc.i4.2
    IL_0147: switch (61 cases)
    IL_0148: IL_24
    IL_0149: ldloc.0
    IL_014A: nop
    IL_014B: ldloc.0
    IL_014C: pop
    IL_014D: ldarg.0
    IL_0152: ldfld 0x04000715
    IL_0153: ldarg.0
    IL_0158: ldfld 0x04000717
    IL_0159: ldc.i4.0
    IL_015A: conv.r8
    IL_015B: IL_D4
    IL_015C: IL_01
    IL_015D: nop
    IL_015E: ldloc.0
    IL_015F: ldarg.0
    IL_0160: ldc.i4.1
    IL_0165: stfld 0x04000721
    IL_016A: br IL_021C
    IL_016B: ldarg.0
    IL_0170: ldfld 0x04000720
    IL_0171: ldc.i4.1
    IL_036E: switch (126 cases)
    }

    }}
