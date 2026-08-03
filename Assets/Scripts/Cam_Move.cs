// Namespace: 
// Type: Cam_Move

    public class Cam_Move {{

    private object dx;
    private object zoom;
    private object iconmove;
    private object z_speed;
    private object z_time;
    private object zoomdelay;
    private object fov;
    private object originfov;
    private object cha1;
    private object target;
    private object mytransform;
    private object distancetarget;
    private object chaposition;
    private object boundfactor;
    private object hit_shake1;
    private object hit_shake2;
    private object resetcam_delay;
    private object resetstart;
    private object fovchange;
    private object mycamera;
    public object limitpos;
    private object script_skillicon;
    private object fovbk_delay;
    private object limit_x;
    private object limit_y_b;
    private object limit_y_f;
    private object hidestop;
    private object topviewon;
    private object topviewdelay;
    private object movespeed;
    private object script_ui;
    private object story_scene;

    public Cam_Move() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000239
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_F0
    IL_000C: IL_41
    IL_0011: stfld 0x0400023F
    IL_0012: ldarg.0
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_0016: IL_F0
    IL_0017: IL_41
    IL_001C: stfld 0x04000240
    IL_001D: ldarg.0
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0025: stsfld 0x02467D3F
    IL_0026: nop
    IL_0027: ldarg.2
    IL_0028: ldarg.0
    IL_0029: IL_22
    IL_002A: IL_8F
    IL_002B: IL_C2
    IL_002C: conv.u8
    IL_002D: IL_3D
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_22
    IL_0034: IL_8F
    IL_0035: IL_C2
    IL_0036: IL_F5
    IL_0037: IL_3C
    IL_003C: newobj 0x0A000076
    IL_0041: stfld 0x04000247
    IL_0042: ldarg.0
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: IL_22
    IL_0049: IL_8F
    IL_004A: IL_C2
    IL_004B: IL_F5
    IL_004C: IL_3C
    IL_004D: IL_22
    IL_004E: stloc.0
    IL_004F: IL_D7
    IL_0050: stelem.i
    IL_0051: IL_3C
    IL_0056: newobj 0x0A000076
    IL_005B: stfld 0x04000248
    IL_005C: ldarg.0
    IL_005D: IL_22
    IL_005E: shr
    IL_005F: shr
    IL_0060: ldloc.0
    IL_94259: switch (151677 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000243
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A0000D0
    IL_0017: stfld 0x0400024C
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000001
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: ldarg.3
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x04000241
    IL_002D: ldarg.0
    IL_0032: ldstr 0x70000311
    IL_0037: call 0x0A000004
    IL_0038: conv.r8
    IL_003D: ldc.i4 2099970048
    IL_003E: IL_4E
    IL_003F: ldarg.0
    IL_0040: nop
    IL_0041: ldarg.2
    IL_0042: ldarg.0
    IL_0047: call 0x06000131
    IL_0048: ldarg.0
    IL_004D: ldstr 0x70000BD5
    IL_0052: call 0x0A000004
    IL_0053: conv.r8
    IL_005C: ldc.i8 288232950937092096
    IL_005D: ret
    }

    private void Start() {
    IL_0004: ldstr 0x70000BDB
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldc.i4.5
    IL_000D: IL_3E
    IL_0016: ldc.i8 146062442496
    IL_0017: IL_3F
    IL_001C: stfld 0x04000250
    IL_001D: ldarg.0
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0025: stsfld 0x02517DBF
    IL_0026: nop
    IL_0027: ldarg.2
    IL_0028: ldarg.0
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_78
    IL_002D: IL_41
    IL_0032: stfld 0x04000252
    IL_0033: ldarg.0
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: IL_22
    IL_003A: shr
    IL_003B: shr
    IL_0040: isinst 0x1EB8223F
    IL_0041: IL_85
    IL_0042: IL_BF
    IL_0047: newobj 0x0A000076
    IL_004C: stfld 0x04000244
    IL_004D: ret
    }

    public void Topview() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_0006: IL_22
    IL_0007: shr
    IL_0008: shr
    IL_000D: isinst 0xCCCD223F
    IL_000E: IL_CC
    IL_000F: IL_BD
    IL_0014: newobj 0x0A000076
    IL_0019: stfld 0x04000244
    IL_001A: ldarg.0
    IL_001B: ldc.i4.1
    IL_0020: stfld 0x04000254
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_955F529: switch (39157056 cases)
    }

    public void LookTarget() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000242
    IL_0007: ldarg.3
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_000D: IL_43
    IL_000F: ldarg.s 0
    IL_0010: nop
    IL_0011: nop
    IL_0012: ldarg.0
    IL_0013: ldc.i4.1
    IL_0018: stfld 0x0400024A
    IL_0019: ldarg.0
    IL_001A: ldarg.3
    IL_001F: stfld 0x04000249
    IL_0020: ldarg.2
    IL_0025: brfalse IL_002F
    IL_0026: ldarg.0
    IL_0027: ldc.i4.m1
    IL_0028: ldarg.2
    IL_0029: ldarg.3
    IL_002E: call 0x06000134
    IL_002F: ret
    }

    public void ThisIsStory() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000258
    IL_0007: ret
    }

    public void IconHideStop() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000253
    IL_0007: ret
    }

    public void ResetCam() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000241
    IL_000B: stfld 0x04000242
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000240
    IL_0017: stfld 0x0400023F
    IL_0018: ldarg.0
    IL_0019: ldc.i4.1
    IL_001E: stfld 0x0400024B
    IL_001F: ldarg.0
    IL_0020: ldc.i4.0
    IL_0025: stfld 0x0400024A
    IL_0026: ldarg.0
    IL_0027: ldc.i4.0
    IL_002C: stfld 0x0400023A
    IL_002D: ldarg.0
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0037: stfld 0x0400023E
    IL_0038: ret
    }

    public void FovTest() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000240
    IL_0007: ldarg.0
    IL_0008: ldarg.0
    IL_000D: ldfld 0x04000240
    IL_0012: stfld 0x0400023F
    IL_0013: ldarg.0
    IL_0018: ldfld 0x0400024C
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000240
    IL_001F: conv.r8
    IL_0020: IL_E6
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400024A
    IL_000A: brfalse IL_005A
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000249
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: IL_43
    IL_0017: ldc.i4.1
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x04000249
    IL_0026: call 0x0A000024
    IL_0027: IL_59
    IL_002C: stfld 0x04000249
    IL_0031: br IL_005A
    IL_0032: ldarg.0
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_003C: stfld 0x04000249
    IL_003D: ldarg.0
    IL_003E: ldc.i4.0
    IL_0043: stfld 0x0400024A
    IL_0044: ldarg.0
    IL_0049: call 0x06000131
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000241
    IL_0050: conv.r8
    IL_0051: stloc.2
    IL_0052: nop
    IL_0053: nop
    IL_0055: br.s IL_00C5
    IL_0056: conv.u4
    IL_0057: IL_01
    IL_0058: nop
    IL_0059: ldloc.0
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000242
    IL_0061: conv.r8
    IL_0062: ldc.i4.2
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000244
    IL_0070: call 0x0A000029
    IL_0075: stfld 0x04000245
    IL_0076: ldarg.0
    IL_007B: ldfld 0x04000243
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000243
    IL_0082: conv.r8
    IL_0083: ldc.i4.2
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000245
    IL_0091: call 0x0A000024
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000256
    IL_0098: conv.i2
    IL_0099: IL_5A
    IL_009E: call 0x0A000063
    IL_009F: conv.r8
    IL_00A0: ldloc.3
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A4: ldarg.0
    IL_00A5: ldarg.0
    IL_00AA: ldfld 0x04000243
    IL_00AB: conv.r8
    IL_00AC: ldc.i4.2
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B4: stfld 0x0400024D
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x04000254
    IL_00BB: ldc.i4.1
    IL_00C0: beq IL_00F8
    IL_00C1: ldarg.0
    IL_00C6: ldflda 0x0400024D
    IL_00C7: ldc.i4.2
    IL_00C8: ldarg.0
    IL_00CD: ldflda 0x0400024D
    IL_00CE: ldc.i4.2
    IL_00D3: call 0x0A0000D3
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000251
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000246
    IL_00E0: IL_5A
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x04000252
    IL_00E7: ldarg.0
    IL_00EC: ldfld 0x04000246
    IL_00ED: IL_5A
    IL_00F2: call 0x0A0000D4
    IL_00F7: call 0x0A00001A
    IL_00F8: ldarg.0
    IL_00FD: ldflda 0x0400024D
    IL_00FE: ldc.i4.0
    IL_00FF: ldarg.0
    IL_0104: ldflda 0x0400024D
    IL_0105: ldc.i4.0
    IL_010A: call 0x0A0000D3
    IL_010B: ldarg.0
    IL_0110: ldfld 0x04000250
    IL_0111: shl
    IL_0112: ldarg.0
    IL_0117: ldfld 0x04000246
    IL_0118: IL_5A
    IL_0119: ldarg.0
    IL_011E: ldfld 0x04000250
    IL_011F: ldarg.0
    IL_0124: ldfld 0x04000246
    IL_0125: IL_5A
    IL_012A: call 0x0A0000D4
    IL_012F: call 0x0A00001A
    IL_0130: ldarg.0
    IL_0135: ldfld 0x04000254
    IL_0136: ldc.i4.2
    IL_01FF: switch (49 cases)
    IL_0200: ldarg.2
    IL_0205: brfalse IL_0225
    IL_0206: ldarg.0
    IL_0207: ldc.i4.0
    IL_020C: stfld 0x0400023B
    IL_020D: ldarg.0
    IL_0212: ldfld 0x0400024E
    IL_0213: ldc.i4.0
    IL_0214: conv.r8
    IL_0215: IL_42
    IL_0216: ldarg.1
    IL_0217: nop
    IL_0218: ldloc.0
    IL_0219: ldarg.0
    IL_021E: ldfld 0x0400024E
    IL_021F: ldc.i4.0
    IL_0220: conv.r8
    IL_0221: IL_43
    IL_0222: ldarg.1
    IL_0223: nop
    IL_0224: ldloc.0
    IL_0225: ldarg.0
    IL_022A: ldfld 0x0400024B
    IL_022F: brfalse IL_036F
    IL_0230: ldarg.0
    IL_0231: IL_22
    IL_0232: IL_CD
    IL_0233: IL_CC
    IL_0234: IL_4C
    IL_0235: IL_3F
    IL_0236: IL_22
    IL_0237: IL_CD
    IL_0238: IL_CC
    IL_0239: IL_4C
    IL_023A: IL_3E
    IL_023B: ldarg.0
    IL_0240: ldfld 0x04000240
    IL_0241: IL_5A
    IL_0242: ldarg.0
    IL_0247: ldfld 0x0400024C
    IL_0248: conv.r8
    IL_0249: IL_E7
    IL_024A: nop
    IL_024B: nop
    IL_024C: stloc.0
    IL_024D: add
    IL_024E: IL_58
    IL_0253: stfld 0x04000246
    IL_0254: ldarg.0
    IL_0259: ldfld 0x0400023A
    IL_025E: brfalse IL_02F9
    IL_025F: ldarg.0
    IL_0264: ldfld 0x0400023C
    IL_0265: ldc.i4.m1
    IL_02C2: switch (22 cases)
    IL_02C3: IL_3E
    IL_02C4: ldarg.0
    IL_02C5: nop
    IL_02C6: ldarg.2
    IL_02CB: call 0x0A000024
    IL_02CC: IL_58
    IL_02D1: stfld 0x0400023E
    IL_02D6: br IL_02F4
    IL_02D7: ldarg.0
    IL_02D8: ldc.i4.0
    IL_02DD: stfld 0x0400023A
    IL_02DE: ldarg.0
    IL_02DF: IL_22
    IL_02E0: nop
    IL_02E1: nop
    IL_02E2: nop
    IL_02E3: nop
    IL_02E8: stfld 0x0400023E
    IL_02E9: ldarg.0
    IL_02EA: IL_22
    IL_02EB: nop
    IL_02EC: nop
    IL_02ED: nop
    IL_02EE: nop
    IL_02F3: stfld 0x0400024F
    IL_02F8: br IL_036F
    IL_02F9: ldarg.0
    IL_02FE: ldfld 0x0400024F
    IL_02FF: IL_22
    IL_0300: nop
    IL_0301: nop
    IL_0302: nop
    IL_1100B: switch (17217 cases)
    }

    public void ZoomIn() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x0400023A
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x0400023C
    IL_000E: ldarg.0
    IL_000F: ldarg.2
    IL_0010: conv.i2
    IL_0015: stfld 0x0400023F
    IL_0016: ldarg.0
    IL_0017: ldarg.3
    IL_001C: stfld 0x0400023D
    IL_001D: ldarg.0
    IL_001E: ldc.i4.1
    IL_0023: stfld 0x0400024B
    IL_0024: ret
    }

    public void Hitcam() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000258
    IL_000A: brtrue IL_001B
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000257
    IL_0011: IL_22
    IL_0012: stloc.0
    IL_0013: IL_D7
    IL_0014: IL_23
    IL_0015: IL_3C
    IL_0016: conv.r8
    IL_0018: stloc.s 6
    IL_0019: nop
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000239
    IL_0022: shl
    IL_0027: stfld 0x04000239
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000243
    IL_002E: dup
    IL_002F: conv.r8
    IL_0030: ldc.i4.2
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000247
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000239
    IL_0040: conv.i2
    IL_0045: call 0x0A000008
    IL_004A: call 0x0A000029
    IL_004B: conv.r8
    IL_004C: ldloc.3
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: ret
    }

    public void Hitcam2() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000243
    IL_0006: dup
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000248
    IL_0012: ldarg.1
    IL_0017: call 0x0A000008
    IL_001C: call 0x0A000029
    IL_001D: conv.r8
    IL_001E: ldloc.3
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: ret
    }

    }}
