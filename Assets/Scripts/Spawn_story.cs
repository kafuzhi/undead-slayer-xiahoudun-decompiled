// Namespace: 
// Type: Spawn_story

    public class Spawn_story {{

    public object enemy_source;
    public object mon_destroy;
    private object spawnenemy;
    private object clone_enemy;
    private object enemyset;
    private object clone_destroy;
    private object stage;
    private object monnum;
    private object destroy_human_kind;
    private object destroy_beast_kind;
    private object totalEnemyNum;
    private object regen;
    private object spawndelay;
    private object countdown;
    private object guide;
    private object cur_difficulty;
    private object rndpoint;
    private object rndoldpoint;
    private object rndpos;
    private object last_mon;
    private object spawpoint;
    private object storymonnum;
    private object max_stage_index;

    public Spawn_story() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x04000970
    IL_000C: ldarg.0
    IL_000D: ldc.i4.3
    IL_0012: newarr 0x01000003
    IL_0017: stfld 0x04000971
    IL_0018: ldarg.0
    IL_0019: ldc.i4.3
    IL_001E: newarr 0x01000003
    IL_0023: stfld 0x04000974
    IL_0024: ldarg.0
    IL_0025: ldc.i4.6
    IL_002A: newarr 0x01000003
    IL_002F: stfld 0x04000975
    IL_0030: ldarg.0
    IL_0031: ldc.i4.3
    IL_0036: stfld 0x04000977
    IL_0037: ldarg.0
    IL_0038: ldc.i4.3
    IL_003D: stfld 0x04000979
    IL_003E: ldarg.0
    IL_0040: ldc.i4.s 10
    IL_0045: stfld 0x0400097A
    IL_0046: ldarg.0
    IL_0047: ldc.i4.m1
    IL_004C: stfld 0x0400097B
    IL_004D: ldarg.0
    IL_004E: ldc.i4.m1
    IL_0053: stfld 0x04000981
    IL_0054: ldarg.0
    IL_0055: ldc.i4.8
    IL_005A: newarr 0x01000007
    IL_005F: stfld 0x04000984
    IL_0060: ldarg.0
    IL_0061: ldc.i4.3
    IL_0066: stfld 0x04000985
    IL_0067: ldarg.0
    IL_0068: ldc.i4.m1
    IL_006D: stfld 0x04000986
    IL_006E: ldarg.0
    IL_0073: call 0x0A000001
    IL_0074: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700004DD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000986
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000986
    IL_0016: ldc.i4.m1
    IL_001B: beq IL_0023
    IL_001C: ldarg.0
    IL_001D: ldc.i4.0
    IL_0022: stfld 0x0400097A
    IL_0023: ret
    }

    private void Start() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0069
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000975
    IL_000D: ldloc.0
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000971
    IL_0014: ldloc.0
    IL_0015: ldelem.i
    IL_001A: call 0x0A00004B
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_C0
    IL_20C3: switch (2088 cases)
    }

    public void StoryEnemyDead() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000985
    IL_0007: ldc.i4.1
    IL_0008: IL_59
    IL_000D: stfld 0x04000985
    IL_000E: ret
    }

    public void EnemyDead() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400097E
    IL_000A: brtrue IL_0033
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000986
    IL_0011: ldc.i4.m1
    IL_006A: switch (21 cases)
    IL_006B: nop
    IL_006C: nop
    IL_151A2D: switch (345711 cases)
    }

    public void RegenStart() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x0400097B
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002B
    IL_000E: ldloc.0
    IL_000F: ldarg.0
    IL_0014: ldfld 0x0400097F
    IL_0015: IL_58
    IL_0016: stloc.1
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000974
    IL_001D: ldloc.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000970
    IL_0024: ldloc.1
    IL_0025: ldelem.i
    IL_002A: stelem 0x0A581706
    IL_002B: ldloc.0
    IL_002C: ldc.i4.3
    IL_002D: IL_3F
    IL_002E: IL_DC
    IL_002F: IL_FF
    IL_0030: IL_FF
    IL_0031: IL_FF
    IL_0032: ret
    }

    public void SetRndPoint() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.8
    IL_0007: call 0x0A000045
    IL_000C: stfld 0x04000980
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000980
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000981
    IL_005D: switch (16 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400097B
    IL_0006: ldc.i4.0
    IL_0007: IL_3F
    IL_0008: ldloc.3
    IL_0009: IL_01
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400097C
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: IL_43
    IL_0018: ldc.i4.1
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.0
    IL_001D: dup
    IL_0022: ldfld 0x0400097C
    IL_0027: call 0x0A000024
    IL_0028: IL_59
    IL_002D: stfld 0x0400097C
    IL_0032: br IL_0110
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400097A
    IL_0039: ldc.i4.0
    IL_003A: IL_3E
    IL_003B: IL_BD
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_003F: ldarg.0
    IL_0044: ldfld 0x0400097C
    IL_0045: IL_22
    IL_0046: nop
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: IL_42
    IL_004B: IL_AD
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: ldarg.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000984
    IL_0056: ldarg.0
    IL_005B: call 0x0600050E
    IL_005C: IL_8F
    IL_005D: ldloc.1
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_01
    IL_0065: ldobj 0x01000007
    IL_006A: stfld 0x04000982
    IL_006B: ldc.i4.0
    IL_006C: ldc.i4.6
    IL_0071: call 0x0A000045
    IL_0072: stloc.0
    IL_0073: ldloc.0
    IL_0074: ldc.i4.2
    IL_0075: IL_3D
    IL_0076: ldloc.1
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldc.i4.0
    IL_007B: stloc.0
    IL_0080: br IL_0091
    IL_0081: ldloc.0
    IL_0082: ldc.i4.4
    IL_0083: IL_3D
    IL_0084: ldloc.1
    IL_0085: nop
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldc.i4.1
    IL_0089: stloc.0
    IL_008E: br IL_0091
    IL_008F: ldc.i4.2
    IL_0090: stloc.0
    IL_0091: ldarg.0
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000974
    IL_0098: ldloc.0
    IL_0099: ldelem.i
    IL_009E: stfld 0x04000972
    IL_009F: ldarg.0
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000972
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x04000982
    IL_00B0: call 0x0A000013
    IL_00B5: call 0x0A000014
    IL_00B6: conv.u4
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: IL_01
    IL_00BF: stfld 0x04000973
    IL_00C0: ldarg.0
    IL_00C5: ldfld 0x04000973
    IL_00CA: ldstr 0x70022ECD
    IL_00CB: conv.r8
    IL_00CC: IL_DC
    IL_00CD: IL_01
    IL_00CE: nop
    IL_00CF: stloc.0
    IL_00D0: ldarg.0
    IL_00D1: dup
    IL_00D6: ldfld 0x04000977
    IL_00D7: ldc.i4.1
    IL_00D8: IL_58
    IL_00DD: stfld 0x04000977
    IL_00DE: ldarg.0
    IL_00DF: dup
    IL_00E4: ldfld 0x0400097A
    IL_00E5: ldc.i4.1
    IL_00E6: IL_59
    IL_00EB: stfld 0x0400097A
    IL_00EC: ldarg.0
    IL_00ED: IL_22
    IL_00EE: IL_CD
    IL_00EF: IL_CC
    IL_00F0: IL_4C
    IL_00F1: IL_3E
    IL_00F6: stfld 0x0400097C
    IL_00FB: br IL_0110
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x0400097A
    IL_0102: ldc.i4.0
    IL_0103: IL_3D
    IL_0104: ldloc.2
    IL_0105: nop
    IL_0106: nop
    IL_0107: nop
    IL_0108: ldarg.0
    IL_010A: ldc.i4.s -2
    IL_010F: stfld 0x0400097B
    IL_0114: br IL_0195
    IL_0115: ldarg.0
    IL_011A: ldfld 0x04000977
    IL_011B: ldc.i4.5
    IL_011C: ldarg.0
    IL_0121: ldfld 0x04000985
    IL_0122: IL_58
    IL_0123: IL_3D
    IL_0124: conv.i8
    IL_0125: nop
    IL_0126: nop
    IL_0127: nop
    IL_0128: ldarg.0
    IL_012D: ldfld 0x0400097D
    IL_0132: brtrue IL_0195
    IL_0133: ldarg.0
    IL_0138: ldfld 0x0400097B
    IL_013A: ldc.i4.s -2
    IL_0293: switch (85 cases)
    }

    }}
