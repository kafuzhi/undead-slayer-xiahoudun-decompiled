// Namespace: 
// Type: Junwui

    public class Junwui {{

    private object mytransform;
    private object mycollider;
    private object power;
    private object rndpos;
    private object rotate;
    private object cha1;
    public object ef_splash;
    private object c_splash;
    private object myanimation;
    private object attack_start;
    private object scalereduce;
    public object pt_body;
    private object attack_count;
    private object finish;
    public object snd_attack;

    public Junwui() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040007AC
    IL_0007: ldarg.0
    IL_000C: call 0x0A000001
    IL_000D: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040007A3
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040007A4
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A00002A
    IL_0023: stfld 0x040007AB
    IL_0024: ldarg.0
    IL_0029: ldfld 0x040007AB
    IL_002E: ldstr 0x70002A5D
    IL_002F: conv.r8
    IL_0031: bge.s IL_0032
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: IL_22
    IL_0035: IL_CD
    IL_0036: IL_CC
    IL_0037: IL_4C
    IL_0038: IL_3E
    IL_0039: conv.r8
    IL_003B: bgt.s IL_003C
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x040007AB
    IL_0048: ldstr 0x70002A79
    IL_0049: conv.r8
    IL_004B: bge.s IL_004C
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: IL_22
    IL_004F: ldelem.i
    IL_0050: IL_99
    IL_0051: IL_99
    IL_0052: IL_3E
    IL_0053: conv.r8
    IL_0055: bgt.s IL_0056
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ldarg.0
    IL_005D: ldfld 0x040007AB
    IL_0062: ldstr 0x70002A95
    IL_0063: conv.r8
    IL_0065: bge.s IL_0066
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: IL_22
    IL_0069: IL_CD
    IL_006A: IL_CC
    IL_006B: IL_4C
    IL_006C: IL_3E
    IL_006D: conv.r8
    IL_006F: bgt.s IL_0070
    IL_0070: nop
    IL_0071: stloc.0
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040007AB
    IL_007C: ldstr 0x70002AAD
    IL_007D: conv.r8
    IL_007F: bge.s IL_0080
    IL_0080: nop
    IL_0081: stloc.0
    IL_0082: IL_22
    IL_0083: IL_CD
    IL_0084: IL_CC
    IL_0085: IL_4C
    IL_0086: IL_3E
    IL_0087: conv.r8
    IL_0089: bgt.s IL_008A
    IL_008A: nop
    IL_008B: stloc.0
    IL_008C: ldarg.0
    IL_0091: ldfld 0x040007AB
    IL_0096: ldstr 0x70002A5D
    IL_0097: conv.r8
    IL_0099: bge.s IL_009A
    IL_009A: nop
    IL_009B: stloc.0
    IL_009C: ldc.i4.2
    IL_009D: conv.r8
    IL_009F: ble.s IL_00A0
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x040007AB
    IL_00AC: ldstr 0x70002A79
    IL_00AD: conv.r8
    IL_00AF: bge.s IL_00B0
    IL_00B0: nop
    IL_00B1: stloc.0
    IL_00B2: ldc.i4.1
    IL_00B3: conv.r8
    IL_00B5: ble.s IL_00B6
    IL_00B6: nop
    IL_00B7: stloc.0
    IL_00B8: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x040007A8
    IL_0015: ldarg.0
    IL_001A: ldstr 0x700002BD
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0023: nop
    IL_5CC8: switch (5928 cases)
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040007AB
    IL_0006: conv.r8
    IL_0009: ldloc 0
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040007A4
    IL_0011: ldc.i4.1
    IL_0012: conv.r8
    IL_0014: ldc.i4.s 0
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040007AB
    IL_0021: ldstr 0x70002A5D
    IL_0022: conv.r8
    IL_0023: IL_3C
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: pop
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040007AB
    IL_0032: ldstr 0x70002A95
    IL_0033: conv.r8
    IL_0034: IL_3C
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: pop
    IL_0039: ldarg.0
    IL_003E: ldfld 0x040007AE
    IL_003F: conv.r8
    IL_0040: IL_B0
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldc.i4.1
    IL_0045: conv.r8
    IL_0046: IL_B6
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040007A3
    IL_0054: call 0x0A00004B
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_0058: IL_C0
    IL_0059: IL_3F
    IL_005E: call 0x0A000008
    IL_005F: conv.r8
    IL_0060: IL_AF
    IL_0061: nop
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldarg.0
    IL_0065: ldc.i4.0
    IL_006A: stfld 0x040007AF
    IL_006B: ret
    }

    public void SetRndPosition() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00007E
    IL_0006: IL_22
    IL_0007: IL_CD
    IL_0008: IL_CC
    IL_0009: IL_CC
    IL_000A: IL_3E
    IL_000F: call 0x0A000008
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040007A8
    IL_0016: conv.r8
    IL_0017: ldc.i4.2
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001F: call 0x0A000029
    IL_0024: stfld 0x040007A6
    IL_0025: ldarg.0
    IL_002A: ldflda 0x040007A6
    IL_002B: ldc.i4.1
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0035: call 0x0A00001A
    IL_0036: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040007AC
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.1
    IL_000D: conv.r8
    IL_000E: stloc.0
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: conv.r8
    IL_0013: ldc.i4.8
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldc.i4.8
    IL_0114: switch (62 cases)
    }

    public void SetDamage() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040007A5
    IL_0007: ret
    }

    private void Attack() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040007B1
    IL_000C: conv.r8
    IL_000D: IL_4C
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: call 0x0A00002B
    IL_0017: conv.r8
    IL_0018: IL_4D
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040007AA
    IL_0022: ldnull
    IL_0027: call 0x0A000061
    IL_002C: brfalse IL_0074
    IL_002D: ldarg.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040007A9
    IL_0034: ldarg.0
    IL_0039: ldfld 0x040007A3
    IL_003A: conv.r8
    IL_003B: ldc.i4.2
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x040007A3
    IL_0045: conv.r8
    IL_0046: pop
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004E: call 0x0A000014
    IL_004F: conv.u4
    IL_0050: ldarg.1
    IL_0051: nop
    IL_0052: nop
    IL_0053: IL_01
    IL_0058: stfld 0x040007AA
    IL_0059: ldarg.0
    IL_005E: ldfld 0x040007AA
    IL_005F: conv.r8
    IL_0060: IL_3D
    IL_0061: nop
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x040007A5
    IL_006A: conv.r8
    IL_006B: IL_84
    IL_006C: nop
    IL_006D: nop
    IL_006E: stloc.0
    IL_0073: br IL_00B1
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040007AA
    IL_007A: ldarg.0
    IL_007F: ldfld 0x040007A3
    IL_0080: conv.r8
    IL_0081: ldc.i4.2
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0085: conv.r8
    IL_0086: ldloc.3
    IL_0087: nop
    IL_0088: nop
    IL_0089: stloc.0
    IL_008A: ldarg.0
    IL_008F: ldfld 0x040007AA
    IL_0090: ldarg.0
    IL_0095: ldfld 0x040007A3
    IL_0096: conv.r8
    IL_0097: pop
    IL_0098: nop
    IL_0099: nop
    IL_009A: stloc.0
    IL_009B: conv.r8
    IL_00A0: call 0x020A0000
    IL_00A5: ldfld 0x040007AA
    IL_00A6: conv.r8
    IL_00A7: stloc.0
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: ldc.i4.1
    IL_00AC: conv.r8
    IL_00AD: stloc.1
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: stloc.0
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x040007A4
    IL_00B7: ldc.i4.0
    IL_00B8: conv.r8
    IL_00BA: ldc.i4.s 0
    IL_00BB: nop
    IL_00BC: stloc.0
    IL_00BD: ldarg.0
    IL_00BE: dup
    IL_00C3: ldfld 0x040007AF
    IL_00C4: ldc.i4.1
    IL_00C5: IL_58
    IL_00CA: stfld 0x040007AF
    IL_00CB: ldarg.0
    IL_00D0: ldfld 0x040007AF
    IL_00D2: ldc.i4.s 12
    IL_00D3: IL_3F
    IL_00D5: blt.s IL_00D6
    IL_00D6: nop
    IL_00D7: nop
    IL_00D8: ldarg.0
    IL_00D9: ldarg.0
    IL_00DE: ldfld 0x040007AB
    IL_00E3: ldstr 0x70002AAD
    IL_00E4: conv.r8
    IL_00E9: newobj 0x7D0A0000
    IL_00EA: IL_B0
    IL_00EB: ldloc.1
    IL_00EC: nop
    IL_00ED: ldarg.2
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x040007B0
    IL_00F4: IL_22
    IL_00F5: IL_CD
    IL_00F6: IL_CC
    IL_00F7: IL_4C
    IL_00F8: IL_3E
    IL_00F9: conv.r8
    IL_00FB: bgt.s IL_00FC
    IL_00FC: nop
    IL_00FD: stloc.0
    IL_00FE: ldarg.0
    IL_0103: ldfld 0x040007B0
    IL_0104: ldc.i4.1
    IL_0105: conv.r8
    IL_0107: ble.s IL_0108
    IL_0108: nop
    IL_0109: stloc.0
    IL_010A: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040007AB
    IL_000A: ldstr 0x70002AAD
    IL_000B: conv.r8
    IL_000C: IL_56
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: brfalse IL_00A3
    IL_0015: ldarg.0
    IL_001A: ldfld 0x040007A3
    IL_001B: dup
    IL_001C: conv.r8
    IL_0021: cpobj 0x020A0000
    IL_0026: ldfld 0x040007AD
    IL_002B: call 0x0A000024
    IL_0030: call 0x0A000008
    IL_0031: IL_22
    IL_0032: nop
    IL_0033: nop
    IL_20A138: switch (534592 cases)
    }

    }}
