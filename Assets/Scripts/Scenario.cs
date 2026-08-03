// Namespace: 
// Type: Scenario

    public class Scenario {{

    private object script_db;
    private object script_scenetxt;
    public object black;
    public object txtbox1;
    public object basicSkin;
    private object portrait;
    private object temp;
    private object extraimg;
    private object script_uimap;
    private object cur_difficulty;
    private object startposX;
    private object targetposX;
    private object remainposX;
    private object currentposX;
    private object movetowardX;
    private object temptowardX;
    private object input_delay;
    private object txtboxscale;
    private object pos_idx;
    private object scenecount;
    private object f_delay;
    private object b_delay;
    private object shake;
    private object finish;
    private object disappear;
    private object dx;
    private object language;
    private object showef;
    private object extraimg_num;

    public Scenario() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x040008B2
    IL_000C: ldarg.0
    IL_000D: ldc.i4.2
    IL_0012: newarr 0x0100002F
    IL_0013: dup
    IL_0014: ldc.i4.0
    IL_0015: IL_22
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldelem.r8
    IL_0019: IL_C3
    IL_001A: ldelem.r8
    IL_001B: dup
    IL_001C: ldc.i4.1
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_F0
    IL_0021: IL_43
    IL_0022: ldelem.r8
    IL_0027: stfld 0x040008B7
    IL_0028: ldarg.0
    IL_0029: ldc.i4.2
    IL_002E: newarr 0x0100002F
    IL_002F: dup
    IL_0030: ldc.i4.0
    IL_0031: IL_22
    IL_0032: nop
    IL_0033: nop
    IL_0034: ldelem.r8
    IL_0035: IL_41
    IL_0036: ldelem.r8
    IL_0037: dup
    IL_0038: ldc.i4.1
    IL_0039: IL_22
    IL_003A: nop
    IL_003B: nop
    IL_003C: IL_34
    IL_003D: IL_43
    IL_003E: ldelem.r8
    IL_0043: stfld 0x040008B8
    IL_0044: ldarg.0
    IL_0045: ldc.i4.2
    IL_004A: newarr 0x0100002F
    IL_004B: dup
    IL_004C: ldc.i4.0
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldelem.r8
    IL_0051: IL_C2
    IL_0052: ldelem.r8
    IL_0053: dup
    IL_0054: ldc.i4.1
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_005C: cpobj 0xB97DA043
    IL_005D: ldloc.2
    IL_005E: nop
    IL_005F: ldarg.2
    IL_0060: ldarg.0
    IL_0061: ldc.i4.2
    IL_0066: newarr 0x0100002F
    IL_0067: dup
    IL_0068: ldc.i4.0
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: ldelem.r8
    IL_006D: IL_C3
    IL_006E: ldelem.r8
    IL_006F: dup
    IL_0070: ldc.i4.1
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_F0
    IL_0075: IL_43
    IL_0076: ldelem.r8
    IL_007B: stfld 0x040008BA
    IL_007C: ldarg.0
    IL_007D: ldc.i4.2
    IL_0082: newarr 0x0100002F
    IL_0087: stfld 0x040008BB
    IL_0088: ldarg.0
    IL_0089: IL_22
    IL_008A: IL_CD
    IL_008B: IL_CC
    IL_008C: IL_4C
    IL_008D: IL_3E
    IL_0092: stfld 0x040008BD
    IL_0093: ldarg.0
    IL_0094: ldc.i4.3
    IL_0099: stfld 0x040008C6
    IL_009A: ldarg.0
    IL_009B: ldc.i4.1
    IL_00A0: stfld 0x040008C8
    IL_00A1: ldarg.0
    IL_00A6: call 0x0A000001
    IL_00A7: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BD5
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000E: ldarg 0
    IL_0010: br.s IL_008E
    IL_0011: IL_B5
    IL_0012: ldloc.2
    IL_0013: nop
    IL_0014: ldarg.2
    IL_0015: ldarg.0
    IL_0016: ldarg.0
    IL_001B: call 0x2B00005F
    IL_0020: stfld 0x040008AD
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: call 0x2B000060
    IL_002C: stfld 0x040008AE
    IL_002D: ldarg.0
    IL_0032: ldstr 0x70000BB3
    IL_0037: call 0x0A000095
    IL_003C: stfld 0x040008C7
    IL_003D: ret
    }

    public void SceneStart() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x040008B6
    IL_0013: ldarg.0
    IL_0014: ldc.i4.0
    IL_0019: call 0x0600042A
    IL_001A: ldarg.0
    IL_001B: dup
    IL_0020: ldfld 0x040008C0
    IL_0021: ldc.i4.1
    IL_0022: IL_58
    IL_0023: neg
    IL_0028: stfld 0x040008C0
    IL_0029: ldarg.0
    IL_002A: ldc.i4.1
    IL_002F: stfld 0x040008C8
    IL_0030: ldarg.0
    IL_0031: ldc.i4.0
    IL_0036: stfld 0x040008C4
    IL_0037: ldarg.0
    IL_0038: ldc.i4.0
    IL_003D: stfld 0x040008C5
    IL_003E: ret
    }

    public void NextScene() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008B8
    IL_0006: ldc.i4.0
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: ldelem.r8
    IL_000B: IL_41
    IL_000C: ldelem.r8
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040008B8
    IL_0013: ldc.i4.1
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_0017: IL_34
    IL_0018: IL_43
    IL_0019: ldelem.r8
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040008AD
    IL_0025: ldfld 0x040004FA
    IL_0026: ldarg.0
    IL_002B: ldfld 0x040008B6
    IL_002C: ldarg.1
    IL_0031: call 0x0A00016C
    IL_0036: ldfld 0x040004F6
    IL_003B: stfld 0x040008BF
    IL_003C: ldarg.0
    IL_003D: ldarg.0
    IL_0042: ldfld 0x040008AD
    IL_0047: ldfld 0x040004FA
    IL_0048: ldarg.0
    IL_004D: ldfld 0x040008B6
    IL_004E: ldarg.1
    IL_0053: call 0x0A00016C
    IL_0058: ldfld 0x040004F7
    IL_005D: stfld 0x040008C8
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x040008AD
    IL_0069: ldfld 0x040004FA
    IL_006A: ldarg.0
    IL_006F: ldfld 0x040008B6
    IL_0070: ldarg.1
    IL_0075: call 0x0A00016C
    IL_007A: ldfld 0x040004F9
    IL_007F: stfld 0x040008C9
    IL_0080: ldarg.0
    IL_0085: ldfld 0x040008C9
    IL_008A: ldc.i4 1000
    IL_008B: IL_3E
    IL_008C: dup
    IL_008D: nop
    IL_008E: nop
    IL_008F: nop
    IL_0090: ldarg.0
    IL_0095: ldstr 0x70022AB6
    IL_0096: ldarg.0
    IL_009B: ldflda 0x040008C9
    IL_00A0: call 0x0A000016
    IL_00A5: call 0x0A000011
    IL_00AA: call 0x0A000012
    IL_00AB: conv.u8
    IL_00AC: IL_3C
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: IL_01
    IL_00B4: stfld 0x040008B4
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x040008B2
    IL_00BB: ldarg.0
    IL_00C0: ldfld 0x040008BF
    IL_00C1: ldc.i4.1
    IL_00C2: IL_58
    IL_00C3: ldc.i4.2
    IL_00C4: mul
    IL_00C5: ldelem.i
    IL_00C6: ldnull
    IL_00CB: call 0x0A000061
    IL_00D0: brfalse IL_00E3
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x040008B8
    IL_00D7: ldarg.0
    IL_00DC: ldfld 0x040008BF
    IL_00DD: IL_22
    IL_00DE: nop
    IL_00DF: nop
    IL_00E0: ldelem.r8
    IL_00E1: IL_42
    IL_00E2: ldelem.r8
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x040008C8
    IL_00E9: ldc.i4.4
    IL_00EA: IL_3F
    IL_00EB: IL_C8
    IL_00EC: nop
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: ldarg.0
    IL_00F0: ldc.i4.1
    IL_00F5: stfld 0x040008C4
    IL_00F6: ldarg.0
    IL_00FB: ldfld 0x040008BB
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x040008BF
    IL_0102: ldarg.0
    IL_0107: ldfld 0x040008B8
    IL_0108: ldarg.0
    IL_010D: ldfld 0x040008BF
    IL_010E: IL_98
    IL_010F: ldelem.r8
    IL_0110: ldarg.0
    IL_0115: ldfld 0x040008BB
    IL_0116: ldarg.0
    IL_011B: ldfld 0x040008BF
    IL_011C: ldc.i4.1
    IL_011D: IL_58
    IL_011E: ldc.i4.2
    IL_011F: mul
    IL_0120: ldarg.0
    IL_0125: ldfld 0x040008B9
    IL_0126: ldarg.0
    IL_012B: ldfld 0x040008BF
    IL_012C: ldc.i4.1
    IL_012D: IL_58
    IL_012E: ldc.i4.2
    IL_012F: mul
    IL_0130: IL_98
    IL_0131: ldelem.r8
    IL_0132: ldarg.0
    IL_0137: ldfld 0x040008C8
    IL_0138: ldc.i4.5
    IL_030D: switch (116 cases)
    IL_030E: ldarg.2
    IL_030F: ldarg.0
    IL_0314: ldfld 0x040008BF
    IL_0315: ldc.i4.1
    IL_0316: IL_58
    IL_0317: ldc.i4.2
    IL_0318: mul
    IL_0319: IL_98
    IL_031A: ldelem.r8
    IL_031B: ldarg.0
    IL_0320: ldfld 0x040008B2
    IL_0321: ldarg.0
    IL_0326: ldfld 0x040008BF
    IL_0327: ldelem.i
    IL_0328: ldnull
    IL_032D: call 0x0A000021
    IL_0332: brfalse IL_03A7
    IL_0333: ldarg.0
    IL_0334: IL_22
    IL_0335: ldelem.i
    IL_0336: IL_99
    IL_0337: IL_99
    IL_0338: IL_3E
    IL_033D: call 0x0600042B
    IL_033E: ldarg.0
    IL_0343: ldfld 0x040008BB
    IL_0344: ldarg.0
    IL_0349: ldfld 0x040008BF
    IL_034A: ldarg.0
    IL_034F: ldfld 0x040008B7
    IL_0350: ldarg.0
    IL_0355: ldfld 0x040008BF
    IL_0356: IL_98
    IL_0357: ldelem.r8
    IL_0358: ldarg.0
    IL_0359: ldarg.0
    IL_035E: ldfld 0x040008AD
    IL_0363: ldfld 0x040004FA
    IL_0364: ldarg.0
    IL_0369: ldfld 0x040008B6
    IL_036A: ldarg.1
    IL_036F: call 0x0A00016C
    IL_0374: ldfld 0x040004F4
    IL_0379: call 0x0A000012
    IL_037A: conv.u8
    IL_037B: IL_3C
    IL_037C: nop
    IL_037D: nop
    IL_037E: IL_01
    IL_0383: stfld 0x040008B3
    IL_0384: ldarg.0
    IL_0389: ldfld 0x040008BB
    IL_038A: ldarg.0
    IL_038F: ldfld 0x040008BF
    IL_0390: ldc.i4.1
    IL_0391: IL_58
    IL_0392: ldc.i4.2
    IL_0393: mul
    IL_0394: ldarg.0
    IL_0399: ldfld 0x040008B9
    IL_039A: ldarg.0
    IL_039F: ldfld 0x040008BF
    IL_03A0: ldc.i4.1
    IL_03A1: IL_58
    IL_03A2: ldc.i4.2
    IL_03A3: mul
    IL_03A4: IL_98
    IL_03A5: ldelem.r8
    IL_03A6: ret
    IL_03A7: ldarg.0
    IL_03AC: ldfld 0x040008BA
    IL_03AD: ldarg.0
    IL_03B2: ldfld 0x040008BF
    IL_03B3: ldarg.0
    IL_03B8: ldfld 0x040008B7
    IL_03B9: ldarg.0
    IL_03BE: ldfld 0x040008BF
    IL_03BF: IL_98
    IL_03C0: ldelem.r8
    IL_03C1: ldarg.0
    IL_03C6: ldfld 0x040008BB
    IL_03C7: ldarg.0
    IL_03CC: ldfld 0x040008BF
    IL_03CD: ldarg.0
    IL_03D2: ldfld 0x040008B8
    IL_03D3: ldarg.0
    IL_03D8: ldfld 0x040008BF
    IL_03D9: IL_98
    IL_03DA: ldelem.r8
    IL_03DB: ldarg.0
    IL_03E0: ldfld 0x040008BB
    IL_03E1: ldarg.0
    IL_03E6: ldfld 0x040008BF
    IL_03E7: ldc.i4.1
    IL_03E8: IL_58
    IL_03E9: ldc.i4.2
    IL_03EA: mul
    IL_03EB: ldarg.0
    IL_03F0: ldfld 0x040008B9
    IL_03F1: ldarg.0
    IL_03F6: ldfld 0x040008BF
    IL_03F7: ldc.i4.1
    IL_03F8: IL_58
    IL_03F9: ldc.i4.2
    IL_03FA: mul
    IL_03FB: IL_98
    IL_03FC: ldelem.r8
    IL_0401: br IL_0449
    IL_0402: ldarg.0
    IL_0407: ldfld 0x040008C8
    IL_040C: brtrue IL_0449
    IL_040D: ldarg.0
    IL_0412: ldfld 0x040008BB
    IL_0413: ldarg.0
    IL_0418: ldfld 0x040008BF
    IL_0419: ldarg.0
    IL_041E: ldfld 0x040008B8
    IL_041F: ldarg.0
    IL_0424: ldfld 0x040008BF
    IL_0425: IL_98
    IL_0426: ldelem.r8
    IL_0427: ldarg.0
    IL_042C: ldfld 0x040008BB
    IL_042D: ldarg.0
    IL_0432: ldfld 0x040008BF
    IL_0433: ldc.i4.1
    IL_0434: IL_58
    IL_0435: ldc.i4.2
    IL_0436: mul
    IL_0437: ldarg.0
    IL_043C: ldfld 0x040008B9
    IL_043D: ldarg.0
    IL_0442: ldfld 0x040008BF
    IL_0443: ldc.i4.1
    IL_0444: IL_58
    IL_0445: ldc.i4.2
    IL_0446: mul
    IL_0447: IL_98
    IL_0448: ldelem.r8
    IL_0449: ldarg.0
    IL_044E: ldfld 0x040008B2
    IL_044F: ldarg.0
    IL_0454: ldfld 0x040008BF
    IL_0455: ldarg.0
    IL_045A: ldfld 0x040008AD
    IL_045F: ldfld 0x040004FA
    IL_0460: ldarg.0
    IL_0465: ldfld 0x040008B6
    IL_0466: ldarg.1
    IL_046B: call 0x0A00016C
    IL_0470: ldfld 0x040004F4
    IL_0475: call 0x0A000012
    IL_0476: conv.u8
    IL_0477: IL_3C
    IL_0478: nop
    IL_0479: nop
    IL_047A: IL_01
    IL_047F: stelem 0x00000000
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040008C2
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x040008C1
    IL_000E: ret
    }

    private void ShakePos() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040008C6
    IL_0007: shl
    IL_000C: stfld 0x040008C6
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040008BB
    IL_0013: ldarg.0
    IL_0018: ldfld 0x040008BF
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040008BC
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040008C6
    IL_0025: conv.i2
    IL_0026: IL_58
    IL_0027: ldelem.r8
    IL_0028: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008BD
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_41
    IL_000C: conv.u8
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldc.i4.0
    IL_0015: call 0x0A0000D6
    IL_001A: brfalse IL_0080
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040008C4
    IL_0021: ldc.i4.2
    IL_003A: switch (5 cases)
    IL_003B: nop
    IL_003C: nop
    IL_003D: IL_3F
    IL_0042: call 0x0600042B
    IL_0043: ldarg.0
    IL_0044: ldc.i4.2
    IL_0049: stfld 0x040008C4
    IL_004E: br IL_0080
    IL_004F: ldarg.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x040008C0
    IL_005A: call 0x0600042A
    IL_005B: ldarg.0
    IL_005C: dup
    IL_0061: ldfld 0x040008C0
    IL_0062: ldc.i4.1
    IL_0063: IL_58
    IL_0064: neg
    IL_0069: stfld 0x040008C0
    IL_006A: ldarg.0
    IL_006B: IL_22
    IL_006C: IL_CD
    IL_006D: IL_CC
    IL_006E: IL_4C
    IL_006F: IL_3E
    IL_0074: stfld 0x040008BD
    IL_0075: ldarg.0
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: nop
    IL_007F: stfld 0x040008BE
    IL_0084: br IL_0097
    IL_0085: ldarg.0
    IL_0086: dup
    IL_008B: ldfld 0x040008BD
    IL_0090: call 0x0A000024
    IL_0091: IL_59
    IL_0096: stfld 0x040008BD
    IL_0097: ldarg.0
    IL_009C: ldfld 0x040008C2
    IL_00A1: brfalse IL_019E
    IL_00A2: ldarg.0
    IL_00A3: dup
    IL_00A8: ldfld 0x040008C1
    IL_00AD: call 0x0A000024
    IL_00AE: IL_59
    IL_00B3: stfld 0x040008C1
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x040008C1
    IL_00BA: IL_22
    IL_00BB: nop
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: IL_42
    IL_00C0: IL_DA
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: ldarg.0
    IL_00C5: ldc.i4.0
    IL_00CA: stfld 0x040008C2
    IL_00CB: ldarg.0
    IL_00CC: IL_22
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: nop
    IL_00D0: nop
    IL_00D5: stfld 0x040008C1
    IL_00D6: ldarg.0
    IL_00DB: ldfld 0x040008BB
    IL_00DC: ldarg.0
    IL_00E1: ldfld 0x040008BF
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x040008B8
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x040008BF
    IL_00EE: IL_98
    IL_00EF: ldelem.r8
    IL_00F0: ldarg.0
    IL_00F5: ldfld 0x040008C4
    IL_00F6: ldc.i4.2
    IL_020B: switch (68 cases)
    IL_0210: ldfld 0x040008BA
    IL_0211: ldloc.2
    IL_0212: IL_98
    IL_0213: ldarg.0
    IL_0218: ldfld 0x040008BB
    IL_0219: ldloc.2
    IL_021A: IL_98
    IL_021F: call 0x0A000024
    IL_0220: IL_22
    IL_0221: nop
    IL_0226: stsfld 0x285A44BB
    IL_0227: IL_C0
    IL_0228: nop
    IL_0229: nop
    IL_022A: stloc.0
    IL_022B: ldelem.r8
    IL_022C: ldloc.2
    IL_022D: ldc.i4.1
    IL_022E: IL_58
    IL_022F: stloc.2
    IL_0230: ldloc.2
    IL_0231: ldc.i4.2
    IL_0232: IL_3F
    IL_0233: IL_CD
    IL_0234: IL_FF
    IL_0235: IL_FF
    IL_0236: IL_FF
    IL_0237: ldarg.0
    IL_0238: ldarg.0
    IL_023D: ldfld 0x040008BE
    IL_023E: IL_22
    IL_023F: nop
    IL_0240: nop
    IL_0245: stsfld 0x00242842
    IL_0246: nop
    IL_0247: stloc.0
    IL_0248: IL_22
    IL_0249: nop
    IL_024A: nop
    IL_024B: IL_FA
    IL_024C: IL_43
    IL_024D: IL_5A
    IL_0252: call 0x0A0000C0
    IL_0257: stfld 0x040008BE
    IL_0258: ret
    }

    private void OnGUI() {
    IL_0000: ldc.i4.m1
    IL_0005: call 0x0A0000EF
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008B1
    IL_0010: call 0x0A0000DF
    IL_0015: call 0x0A0000D9
    IL_0016: conv.i2
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001E: cpobj 0xDA285B44
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: conv.i2
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_002A: ldc.i4 2251588
    IL_002B: nop
    IL_0030: stsfld 0x0076733F
    IL_0031: nop
    IL_0032: stloc.0
    IL_0037: call 0x0A0000F8
    IL_003C: call 0x0A0000DE
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: IL_22
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004A: IL_F0
    IL_004B: IL_43
    IL_004C: IL_22
    IL_004D: nop
    IL_004E: nop
    IL_0053: stsfld 0x021D2842
    IL_0054: nop
    IL_0055: ldloc.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x040008AF
    IL_0060: call 0x0A0000E0
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_22
    IL_0067: nop
    IL_0068: nop
    IL_006D: stsfld 0x00002243
    IL_006E: IL_F0
    IL_006F: IL_43
    IL_0070: IL_22
    IL_0071: nop
    IL_0072: nop
    IL_0073: IL_94
    IL_0074: IL_42
    IL_0079: call 0x0600021D
    IL_007A: ldarg.0
    IL_007F: ldfld 0x040008AF
    IL_0084: call 0x0A0000E0
    IL_0085: ldc.i4.0
    IL_0086: stloc.0
    IL_008B: br IL_00ED
    IL_008C: ldarg.0
    IL_0091: ldfld 0x040008B2
    IL_0092: ldloc.0
    IL_0093: ldelem.i
    IL_0094: ldnull
    IL_0099: call 0x0A000021
    IL_009E: brfalse IL_00DE
    IL_009F: ldloc.0
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x040008BF
    IL_00AA: beq IL_00B5
    IL_00AF: call 0x0A0000C5
    IL_00B4: call 0x0A0000F0
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x040008BA
    IL_00BB: ldloc.0
    IL_00BC: IL_98
    IL_00BD: IL_22
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: nop
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_96
    IL_00C6: IL_43
    IL_00C7: IL_22
    IL_00C8: nop
    IL_00C9: nop
    IL_00CA: IL_96
    IL_00CB: IL_43
    IL_00D0: call 0x0600021D
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x040008B2
    IL_00D7: ldloc.0
    IL_00D8: ldelem.i
    IL_00DD: call 0x0A0000E0
    IL_00E2: call 0x0A00017C
    IL_00E7: call 0x0A0000F0
    IL_00E8: ldloc.0
    IL_00E9: ldc.i4.1
    IL_00EA: IL_58
    IL_00EB: neg
    IL_00EC: stloc.0
    IL_00ED: ldloc.0
    IL_00EE: ldc.i4.2
    IL_00EF: IL_3F
    IL_00F0: IL_98
    IL_00F1: IL_FF
    IL_00F2: IL_FF
    IL_00F3: IL_FF
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x040008C9
    IL_00FE: ldc.i4 1000
    IL_00FF: IL_3E
    IL_0100: xor
    IL_0101: nop
    IL_0102: nop
    IL_0103: nop
    IL_0104: ldarg.0
    IL_0109: ldfld 0x040008B8
    IL_010A: ldarg.0
    IL_010F: ldfld 0x040008BF
    IL_0110: IL_98
    IL_0111: IL_22
    IL_0112: nop
    IL_0113: nop
    IL_0114: ldelem.r8
    IL_0115: IL_42
    IL_01BE: switch (41 cases)
    IL_01BF: ldarg.0
    IL_01C4: ldfld 0x040008AE
    IL_01C9: ldfld 0x040007B6
    IL_01CA: ldarg.0
    IL_01CF: ldfld 0x040008C7
    IL_01D0: ldarg.0
    IL_01D5: ldfld 0x040008AD
    IL_01DA: ldfld 0x040004FA
    IL_01DB: ldarg.0
    IL_01E0: ldfld 0x040008B6
    IL_01E1: ldarg.0
    IL_01E6: ldfld 0x040008C0
    IL_01E7: ldc.i4.1
    IL_01E8: IL_59
    IL_01ED: call 0x0A00016C
    IL_01F2: ldfld 0x040004F8
    IL_01F7: call 0x0A0000E1
    IL_01FC: ldstr 0x70000C43
    IL_0201: call 0x0A0000E2
    IL_0206: call 0x0A0000E3
    IL_0207: ret
    }

    }}
