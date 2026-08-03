// Namespace: 
// Type: Ef_energy_gather

    public class Ef_energy_gather {{

    public object eftex;
    private object fogalpha;
    private object dt;
    private object finish_delay;
    private object show_delay;
    private object plustimescale;
    private object mymaterial;
    private object mytransform;
    private object anistart;
    private object growVector;
    private object smoothgrowVector;
    private object offset;
    private object currentColor;
    private object targetColor;
    private object transColor;
    private object whiteclear;

    public Ef_energy_gather() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x01000001
    IL_000B: stfld 0x04000592
    IL_000C: ldarg.0
    IL_000D: ldc.i4.2
    IL_0012: stfld 0x04000593
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: ldelem.i
    IL_0016: IL_99
    IL_0017: IL_99
    IL_0018: IL_3F
    IL_001D: stfld 0x04000595
    IL_001E: ldarg.0
    IL_001F: IL_22
    IL_0020: IL_CD
    IL_0021: IL_CC
    IL_0022: IL_CC
    IL_0023: IL_3D
    IL_0028: stfld 0x04000596
    IL_0029: ldarg.0
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_3F
    IL_002F: IL_22
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_3F
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: IL_3F
    IL_0039: IL_22
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_0042: newobj 0x0A0000C4
    IL_0047: stfld 0x040005A1
    IL_0048: ldarg.0
    IL_004D: call 0x0A000001
    IL_004E: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000599
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00000D
    IL_0013: conv.r8
    IL_0014: neg
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000598
    IL_001D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000C5
    IL_000A: stfld 0x0400059F
    IL_000B: ldarg.0
    IL_0010: call 0x0A00000A
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0013: stloc.1
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: call 0x0A000057
    IL_0021: stfld 0x0400059D
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000598
    IL_002C: ldstr 0x70000B47
    IL_002D: ldarg.0
    IL_0032: ldfld 0x040005A1
    IL_0033: conv.r8
    IL_0034: IL_C6
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ret
    }

    public void SetTex() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000598
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000592
    IL_000C: ldarg.1
    IL_000D: ldelem.i
    IL_000E: conv.r8
    IL_0010: ldarga.s 0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0014: ldarg.2
    IL_0019: stfld 0x04000595
    IL_001A: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000594
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000595
    IL_000C: IL_43
    IL_000D: not
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000599
    IL_001B: call 0x0A00004B
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: stsfld 0x00082840
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.r8
    IL_0027: ldloc.3
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_0030: call 0x0A00000A
    IL_0031: ldc.i4.0
    IL_0032: conv.r8
    IL_0033: stloc.1
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: ldarg.0
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_0041: stfld 0x04000594
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000598
    IL_004C: ldstr 0x70000B47
    IL_004D: ldarg.0
    IL_0052: ldfld 0x040005A1
    IL_0053: conv.r8
    IL_0054: IL_C6
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ldarg.0
    IL_005D: call 0x0A000057
    IL_0062: stfld 0x0400059D
    IL_0063: ldarg.0
    IL_0068: call 0x0A0000C5
    IL_006D: stfld 0x0400059F
    IL_006E: ldarg.0
    IL_006F: ldc.i4.0
    IL_0074: stfld 0x0400059A
    IL_0079: br IL_00B9
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000594
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000595
    IL_0086: IL_22
    IL_0087: IL_CD
    IL_0088: IL_CC
    IL_0089: IL_CC
    IL_008A: IL_3E
    IL_008B: IL_59
    IL_008C: IL_43
    IL_008E: starg.s 0
    IL_008F: nop
    IL_0090: nop
    IL_0091: ldarg.0
    IL_0096: call 0x0A0000F3
    IL_009B: stfld 0x0400059F
    IL_00A0: br IL_00B9
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000594
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000596
    IL_00AD: IL_43
    IL_00AE: ldloc.1
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: ldarg.0
    IL_00B3: ldc.i4.1
    IL_00B8: stfld 0x0400059A
    IL_00B9: ldarg.0
    IL_00BA: dup
    IL_00BF: ldfld 0x04000594
    IL_00C4: call 0x0A000024
    IL_00C5: IL_58
    IL_00CA: stfld 0x04000594
    IL_00CB: ldarg.0
    IL_00D0: ldfld 0x0400059A
    IL_00D5: brfalse IL_0183
    IL_00D6: ldarg.0
    IL_00D7: ldarg.0
    IL_00DC: ldfld 0x04000593
    IL_00DD: conv.i2
    IL_00E2: call 0x0A000093
    IL_00E3: add
    IL_00E8: stfld 0x04000597
    IL_00E9: ldarg.0
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000598
    IL_00F4: ldstr 0x70000B47
    IL_00F5: conv.r8
    IL_00F6: IL_C7
    IL_00F7: nop
    IL_00F8: nop
    IL_00F9: stloc.0
    IL_00FE: stfld 0x0400059E
    IL_00FF: ldarg.0
    IL_0100: ldarg.0
    IL_0105: ldfld 0x0400059E
    IL_0106: ldarg.0
    IL_010B: ldfld 0x0400059F
    IL_0110: call 0x0A000024
    IL_0111: ldarg.0
    IL_0116: ldfld 0x04000597
    IL_0117: IL_5A
    IL_011C: call 0x0A0000C8
    IL_0121: stfld 0x040005A0
    IL_0122: ldarg.0
    IL_0127: ldfld 0x04000598
    IL_012C: ldstr 0x70000B47
    IL_012D: ldarg.0
    IL_0132: ldfld 0x040005A0
    IL_0133: conv.r8
    IL_0134: IL_C6
    IL_0135: nop
    IL_0136: nop
    IL_0137: stloc.0
    IL_0138: ldarg.0
    IL_0139: dup
    IL_013E: ldfld 0x0400059D
    IL_0143: call 0x0A0000AA
    IL_0148: call 0x0A000024
    IL_014D: call 0x0A000083
    IL_014E: ldarg.0
    IL_0153: ldfld 0x04000597
    IL_0158: call 0x0A000083
    IL_0159: IL_22
    IL_015A: nop
    IL_015B: nop
    IL_015C: nop
    IL_015D: IL_3F
    IL_0162: call 0x0A000083
    IL_0167: call 0x0A000174
    IL_016C: stfld 0x0400059D
    IL_016D: ldarg.0
    IL_0172: ldfld 0x04000598
    IL_0177: ldstr 0x700023C1
    IL_0178: ldarg.0
    IL_017D: ldfld 0x0400059D
    IL_017E: conv.r8
    IL_0183: ldobj 0x2A0A0001
    }

    }}
