// Namespace: 
// Type: Icon_FillBox

    public class Icon_FillBox {{

    private object slotindex;
    private object max_cooltime;
    private object cur_cooltime;
    private object scaleratio;
    private object cur_moveUV;
    private object prev_moveUV;
    private object isthisready;
    private object originPos;
    private object script_skillcontrol;
    private object thismesh;
    private object originUV;
    private object resetUV;

    public Icon_FillBox() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_C8
    IL_0005: IL_42
    IL_000A: stfld 0x040006D8
    IL_000B: ldarg.0
    IL_000C: ldc.i4.4
    IL_0011: newarr 0x01000014
    IL_0016: stfld 0x040006E1
    IL_0017: ldarg.0
    IL_0018: ldc.i4.4
    IL_001D: newarr 0x01000014
    IL_0022: stfld 0x040006E2
    IL_0023: ldarg.0
    IL_0028: call 0x0A000001
    IL_0029: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000311
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_0010: ldc.i4 2099970048
    IL_0011: IL_DF
    IL_0012: ldloc.0
    IL_0013: nop
    IL_0014: ldarg.2
    IL_0015: ldarg.0
    IL_0016: ldarg.0
    IL_001B: call 0x2B000016
    IL_001C: conv.r8
    IL_001D: IL_A9
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: stfld 0x040006E0
    IL_0026: ldarg.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040006E0
    IL_002D: conv.r8
    IL_002E: IL_8F
    IL_002F: IL_01
    IL_0030: nop
    IL_0031: stloc.0
    IL_0036: stfld 0x040006E1
    IL_0037: ldarg.0
    IL_0038: ldc.i4.4
    IL_003D: newarr 0x01000014
    IL_003E: dup
    IL_003F: ldc.i4.0
    IL_0040: IL_8F
    IL_0041: ldnull
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_01
    IL_0045: IL_22
    IL_0046: nop
    IL_0047: nop
    IL_0049: bgt.s IL_0089
    IL_004A: IL_22
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_C0
    IL_004E: IL_3E
    IL_0053: newobj 0x0A000038
    IL_0054: IL_81
    IL_0055: ldnull
    IL_0056: nop
    IL_0057: nop
    IL_0058: IL_01
    IL_0059: dup
    IL_005A: ldc.i4.1
    IL_005B: IL_8F
    IL_005C: ldnull
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_01
    IL_0060: IL_22
    IL_0061: nop
    IL_0062: nop
    IL_8963: switch (8767 cases)
    }

    public void SkillKind() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040006D7
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_000D: stfld 0x040006D8
    IL_000E: ldarg.0
    IL_000F: IL_22
    IL_0010: nop
    IL_0011: nop
    IL_0016: stsfld 0xD87B023D
    IL_0017: ldloc.0
    IL_0018: nop
    IL_0019: ldarg.2
    IL_001A: add
    IL_001B: conv.i2
    IL_0020: stfld 0x040006DA
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040006D8
    IL_002C: stfld 0x040006D9
    IL_002D: ret
    }

    public void SoulLack() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006E0
    IL_0006: ldc.i4.4
    IL_000B: newarr 0x01000014
    IL_000C: dup
    IL_000D: ldc.i4.0
    IL_000E: IL_8F
    IL_000F: ldnull
    IL_0010: nop
    IL_0011: nop
    IL_0012: IL_01
    IL_0013: ldarg.0
    IL_0018: ldfld 0x040006E2
    IL_0019: ldc.i4.0
    IL_001A: IL_8F
    IL_001B: ldnull
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_01
    IL_0023: ldobj 0x01000014
    IL_0028: call 0x0A000082
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_0030: stsfld 0x0083283D
    IL_0031: nop
    IL_0032: stloc.0
    IL_0037: call 0x0A000174
    IL_0038: IL_81
    IL_0039: ldnull
    IL_003A: nop
    IL_003B: nop
    IL_003C: IL_01
    IL_003D: dup
    IL_003E: ldc.i4.1
    IL_003F: IL_8F
    IL_0040: ldnull
    IL_0041: nop
    IL_0042: nop
    IL_0043: IL_01
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040006E2
    IL_004A: ldc.i4.1
    IL_004B: IL_8F
    IL_004C: ldnull
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_01
    IL_0054: ldobj 0x01000014
    IL_0059: call 0x0A000082
    IL_005A: IL_22
    IL_005B: nop
    IL_005C: nop
    IL_0061: stsfld 0x0083283D
    IL_0062: nop
    IL_0063: stloc.0
    IL_0068: call 0x0A000174
    IL_0069: IL_81
    IL_006A: ldnull
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_01
    IL_006E: dup
    IL_006F: ldc.i4.2
    IL_0070: IL_8F
    IL_0071: ldnull
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_01
    IL_0075: ldarg.0
    IL_007A: ldfld 0x040006E2
    IL_007B: ldc.i4.2
    IL_007C: IL_8F
    IL_007D: ldnull
    IL_007E: nop
    IL_007F: nop
    IL_0080: IL_01
    IL_0085: ldobj 0x01000014
    IL_008A: call 0x0A000082
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_0092: stsfld 0x0083283D
    IL_0093: nop
    IL_0094: stloc.0
    IL_0099: call 0x0A000174
    IL_009A: IL_81
    IL_009B: ldnull
    IL_009C: nop
    IL_009D: nop
    IL_009E: IL_01
    IL_009F: dup
    IL_00A0: ldc.i4.3
    IL_00A1: IL_8F
    IL_00A2: ldnull
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: IL_01
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x040006E2
    IL_00AC: ldc.i4.3
    IL_00AD: IL_8F
    IL_00AE: ldnull
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: IL_01
    IL_00B6: ldobj 0x01000014
    IL_00BB: call 0x0A000082
    IL_00BC: IL_22
    IL_00BD: nop
    IL_00BE: nop
    IL_00C3: stsfld 0x0083283D
    IL_00C4: nop
    IL_00C5: stloc.0
    IL_00CA: call 0x0A000174
    IL_00CB: IL_81
    IL_00CC: ldnull
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: IL_01
    IL_00D0: conv.r8
    IL_00D1: IL_AC
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: stloc.0
    IL_00D5: ret
    }

    public void SoulFull() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006E0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040006E1
    IL_000C: conv.r8
    IL_000D: IL_AC
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ret
    }

    public void ResetScale() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x040006D9
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040006E0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040006E2
    IL_0017: conv.r8
    IL_0018: IL_AC
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040006D9
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040006D8
    IL_000C: IL_41
    IL_000E: bne.un.s IL_0010
    IL_000F: nop
    IL_0010: nop
    IL_0011: ldarg.0
    IL_0012: dup
    IL_0017: ldfld 0x040006DB
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040006DA
    IL_0022: call 0x0A000024
    IL_0023: IL_5A
    IL_0024: IL_58
    IL_0029: stfld 0x040006DB
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040006DB
    IL_0030: ldarg.0
    IL_0035: ldfld 0x040006DC
    IL_0036: IL_59
    IL_0037: IL_22
    IL_0038: conv.r8
    IL_003A: ldloca.s 3
    IL_003F: beq IL_E583
    IL_0040: nop
    IL_0041: ldarg.0
    IL_0046: ldfld 0x040006E0
    IL_0047: ldc.i4.4
    IL_004C: newarr 0x01000014
    IL_004D: dup
    IL_004E: ldc.i4.0
    IL_004F: IL_8F
    IL_0050: ldnull
    IL_0051: nop
    IL_0052: nop
    IL_0053: IL_01
    IL_0054: ldarg.0
    IL_0059: ldfld 0x040006E2
    IL_005A: ldc.i4.0
    IL_005B: IL_8F
    IL_005C: ldnull
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_01
    IL_0064: ldobj 0x01000014
    IL_0065: IL_22
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: ldarg.0
    IL_006F: ldfld 0x040006DB
    IL_0074: newobj 0x0A000038
    IL_0079: call 0x0A000174
    IL_007A: IL_81
    IL_007B: ldnull
    IL_007C: nop
    IL_007D: nop
    IL_007E: IL_01
    IL_007F: dup
    IL_0080: ldc.i4.1
    IL_0081: IL_8F
    IL_0082: ldnull
    IL_0083: nop
    IL_0084: nop
    IL_0085: IL_01
    IL_0086: ldarg.0
    IL_008B: ldfld 0x040006E2
    IL_008C: ldc.i4.1
    IL_008D: IL_8F
    IL_008E: ldnull
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_01
    IL_0096: ldobj 0x01000014
    IL_0097: IL_22
    IL_0098: nop
    IL_0099: nop
    IL_009A: nop
    IL_009B: nop
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x040006DB
    IL_00A6: newobj 0x0A000038
    IL_00AB: call 0x0A000174
    IL_00AC: IL_81
    IL_00AD: ldnull
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: IL_01
    IL_00B1: dup
    IL_00B2: ldc.i4.2
    IL_00B3: IL_8F
    IL_00B4: ldnull
    IL_00B5: nop
    IL_00B6: nop
    IL_00B7: IL_01
    IL_00B8: ldarg.0
    IL_00BD: ldfld 0x040006E2
    IL_00BE: ldc.i4.2
    IL_00BF: IL_8F
    IL_00C0: ldnull
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: IL_01
    IL_00C8: ldobj 0x01000014
    IL_00C9: IL_22
    IL_00CA: nop
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x040006DB
    IL_00D8: newobj 0x0A000038
    IL_00DD: call 0x0A000174
    IL_00DE: IL_81
    IL_00DF: ldnull
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: IL_01
    IL_00E3: dup
    IL_00E4: ldc.i4.3
    IL_00E5: IL_8F
    IL_00E6: ldnull
    IL_00E7: nop
    IL_00E8: nop
    IL_00E9: IL_01
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x040006E2
    IL_00F0: ldc.i4.3
    IL_00F1: IL_8F
    IL_00F2: ldnull
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: IL_01
    IL_00FA: ldobj 0x01000014
    IL_00FB: IL_22
    IL_00FC: nop
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: nop
    IL_0100: ldarg.0
    IL_0105: ldfld 0x040006DB
    IL_010A: newobj 0x0A000038
    IL_010F: call 0x0A000174
    IL_0110: IL_81
    IL_0111: ldnull
    IL_0112: nop
    IL_0113: nop
    IL_0114: IL_01
    IL_0115: conv.r8
    IL_0116: IL_AC
    IL_0117: nop
    IL_0118: nop
    IL_0119: stloc.0
    IL_011A: ldarg.0
    IL_011B: ldarg.0
    IL_0120: ldfld 0x040006DB
    IL_0125: stfld 0x040006DC
    IL_0126: ldarg.0
    IL_0127: dup
    IL_012C: ldfld 0x040006D9
    IL_0131: call 0x0A000024
    IL_0132: IL_58
    IL_0137: stfld 0x040006D9
    IL_0138: ldarg.0
    IL_0139: ldc.i4.0
    IL_013E: stfld 0x040006DD
    IL_0143: br IL_019A
    IL_0144: ldarg.0
    IL_0149: ldfld 0x040006DD
    IL_014E: brtrue IL_019A
    IL_014F: ldarg.0
    IL_0150: IL_22
    IL_0151: nop
    IL_0152: nop
    IL_0153: nop
    IL_0154: nop
    IL_0159: stfld 0x040006DB
    IL_015A: ldarg.0
    IL_015B: IL_22
    IL_015C: nop
    IL_015D: nop
    IL_015E: nop
    IL_015F: nop
    IL_0164: stfld 0x040006DC
    IL_0165: ldarg.0
    IL_016A: ldfld 0x040006E0
    IL_016B: ldarg.0
    IL_0170: ldfld 0x040006E1
    IL_0171: conv.r8
    IL_0172: IL_AC
    IL_0173: nop
    IL_0174: nop
    IL_0175: stloc.0
    IL_0176: ldarg.0
    IL_0177: ldarg.0
    IL_017C: ldfld 0x040006D8
    IL_0181: stfld 0x040006D9
    IL_0182: ldarg.0
    IL_0183: ldc.i4.1
    IL_0188: stfld 0x040006DD
    IL_0189: ldarg.0
    IL_018E: ldfld 0x040006DF
    IL_018F: ldarg.0
    IL_0194: ldfld 0x040006D7
    IL_0195: conv.r8
    IL_019A: brfalse IL_2A06019E
    }

    }}
