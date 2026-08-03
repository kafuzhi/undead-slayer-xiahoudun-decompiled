// Namespace: 
// Type: NPC1

    public class NPC1 {{

    private object startcounter;
    private object neo_delay;
    private object ef_split;
    public object blood;
    private object script_mon;
    public object snd_scream;

    public NPC1() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_000A: ldstr 0x700228BC
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0012: bne.un.s IL_0046
    IL_0013: conv.ovf.i4.un
    IL_0014: IL_3E
    IL_0015: conv.r8
    IL_0017: bgt.s IL_0018
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: call 0x0A00002A
    IL_0024: ldstr 0x700228CC
    IL_0025: conv.r8
    IL_0027: bge.s IL_0028
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: IL_22
    IL_002B: ldelem.i
    IL_002C: IL_99
    IL_002D: IL_99
    IL_002E: IL_3E
    IL_002F: conv.r8
    IL_0031: bgt.s IL_0032
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: call 0x0A00002A
    IL_003E: ldstr 0x700228DC
    IL_003F: conv.r8
    IL_0041: bge.s IL_0042
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: IL_22
    IL_0045: IL_CD
    IL_0046: IL_CC
    IL_0047: IL_CC
    IL_0048: IL_3E
    IL_0049: conv.r8
    IL_004B: bgt.s IL_004C
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: call 0x0A00002A
    IL_0058: ldstr 0x700228DC
    IL_0059: conv.r8
    IL_005B: bge.s IL_005C
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ldc.i4.1
    IL_005F: conv.r8
    IL_0061: ble.s IL_0062
    IL_0062: nop
    IL_0063: stloc.0
    IL_0068: call 0x0A000035
    IL_0069: conv.r8
    IL_006A: ldloc.0
    IL_006B: nop
    IL_006C: nop
    IL_006E: br.s IL_0071
    IL_0073: call 0x0A000002
    IL_0075: ldc.i4.s 16
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_0079: IL_C8
    IL_007A: IL_42
    IL_007B: conv.r8
    IL_007D: beq.s IL_007F
    IL_007E: nop
    IL_007F: ldloc.0
    IL_0080: ldarg.0
    IL_0081: ldarg.0
    IL_0086: call 0x0A000002
    IL_008B: ldstr 0x700228F0
    IL_008C: conv.r8
    IL_008E: brfalse.s IL_008F
    IL_008F: nop
    IL_0090: stloc.0
    IL_0095: stfld 0x0400083F
    IL_0096: ldarg.0
    IL_009B: ldstr 0x7000012D
    IL_00A0: call 0x0A000004
    IL_00A1: conv.r8
    IL_00A2: ldloc.1
    IL_00A3: nop
    IL_00A4: nop
    IL_00A6: br.s IL_0124
    IL_00A7: IL_41
    IL_00A8: ldloc.2
    IL_00A9: nop
    IL_00AA: ldarg.2
    IL_00AB: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: conv.r8
    IL_0007: IL_FB
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: call 0x0A00002B
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000842
    IL_0017: conv.r8
    IL_0018: ldind.ref
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: call 0x0A00002A
    IL_0026: ldstr 0x700228BC
    IL_0027: conv.r8
    IL_0028: IL_56
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: brfalse IL_0063
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x0400083D
    IL_0038: ldarg.0
    IL_003D: call 0x0A00003D
    IL_003E: ldarg.0
    IL_0043: call 0x0A000002
    IL_0044: conv.r8
    IL_0045: IL_22
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: IL_F0
    IL_004D: IL_42
    IL_0052: call 0x0A000008
    IL_0053: conv.r8
    IL_0054: IL_3E
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ldarg.0
    IL_005D: call 0x0A000003
    IL_0062: call 0x0A000050
    IL_0063: ldarg.0
    IL_0068: call 0x0A00002A
    IL_006D: ldstr 0x700228CC
    IL_006E: conv.r8
    IL_006F: IL_3C
    IL_0070: nop
    IL_0071: nop
    IL_0072: stloc.0
    IL_0073: pop
    IL_0074: ret
    }

    public void Behit() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_000A: ldstr 0x700228DC
    IL_000B: conv.r8
    IL_000C: IL_3C
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: pop
    IL_0011: ldarg.0
    IL_0016: call 0x0A000002
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: call 0x0A000002
    IL_0022: conv.r8
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: IL_22
    IL_0028: stloc.0
    IL_0029: IL_D7
    IL_002A: stelem.i
    IL_002B: IL_3C
    IL_0030: call 0x0A000008
    IL_0035: call 0x0A000029
    IL_003A: call 0x0A000007
    IL_003B: IL_22
    IL_003C: IL_29
    IL_003D: sub
    IL_003E: IL_8F
    IL_003F: IL_3D
    IL_0044: call 0x0A000008
    IL_0049: call 0x0A000019
    IL_004A: stloc.0
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000841
    IL_0051: ldloc.0
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0059: newobj 0x68201642
    IL_005A: IL_01
    IL_005B: nop
    IL_005C: nop
    IL_0061: call 0x0A000045
    IL_0062: conv.i2
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: nop
    IL_0067: nop
    IL_006C: call 0x0A000060
    IL_006D: conv.r8
    IL_006E: IL_BA
    IL_006F: ldarg.1
    IL_0070: nop
    IL_0071: ldloc.0
    IL_0072: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_000A: ldstr 0x700228BC
    IL_000B: conv.r8
    IL_000C: IL_56
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: brfalse IL_0040
    IL_0015: ldarg.0
    IL_001A: call 0x0A000002
    IL_001B: ldarg.0
    IL_0020: call 0x0A000002
    IL_0021: conv.r8
    IL_0022: ldc.i4.2
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_002A: call 0x0A00001B
    IL_002F: call 0x0A000024
    IL_0030: IL_22
    IL_0031: stloc.0
    IL_0032: IL_D7
    IL_0033: stelem.i
    IL_0034: IL_3D
    IL_0035: IL_5A
    IL_003A: call 0x0A0000B2
    IL_003B: conv.r8
    IL_003C: ldloc.3
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400083D
    IL_004A: brfalse IL_00CF
    IL_004B: ldarg.0
    IL_004C: dup
    IL_0051: ldfld 0x0400083E
    IL_0056: call 0x0A000024
    IL_0057: IL_58
    IL_005C: stfld 0x0400083E
    IL_005D: ldarg.0
    IL_0062: ldfld 0x0400083E
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: nop
    IL_1897B: switch (25156 cases)
    }

    }}
