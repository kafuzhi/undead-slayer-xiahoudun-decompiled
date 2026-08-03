// Namespace: 
// Type: SoundEf_slash

    public class SoundEf_slash {{

    private object delay;
    private object myaudio;
    public object thrust;
    public object smash;
    public object slash;
    public object block;
    public object block_break;
    public object split;
    private object rndsound;

    public SoundEf_slash() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100001E
    IL_000B: stfld 0x04000911
    IL_000C: ldarg.0
    IL_0011: call 0x0A000001
    IL_0012: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00002B
    IL_000B: stfld 0x0400090E
    IL_000C: ret
    }

    public void SoundOn() {
    IL_0000: ldarg.1
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0003: ldc.i4.1
    IL_0004: IL_58
    IL_0007: ldarg 6
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_B8
    IL_000B: nop
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_97
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0012: IL_52
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: IL_3C
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.5
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_001E: ldarg.3
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0026: br IL_00F0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x0400090E
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000914
    IL_0033: conv.r8
    IL_0034: ldind.ref
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_003C: br IL_00F0
    IL_003D: ldarg.0
    IL_0042: ldfld 0x0400090E
    IL_0043: ldarg.0
    IL_0048: ldfld 0x0400090F
    IL_0049: conv.r8
    IL_004A: IL_4C
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x0400090E
    IL_0054: conv.r8
    IL_0055: IL_4D
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_005D: br IL_00F0
    IL_005E: ldarg.0
    IL_0063: ldfld 0x0400090E
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000910
    IL_006A: conv.r8
    IL_006B: ldind.ref
    IL_006C: nop
    IL_006D: nop
    IL_006E: stloc.0
    IL_0073: br IL_00F0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x0400090D
    IL_007A: IL_22
    IL_007B: nop
    IL_007C: nop
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_42
    IL_0081: bgt.s IL_0082
    IL_0082: nop
    IL_0083: nop
    IL_0084: ldarg.0
    IL_0085: ldc.i4.0
    IL_0086: ldc.i4.2
    IL_008B: call 0x0A000045
    IL_0090: stfld 0x04000915
    IL_0091: ldarg.0
    IL_0096: ldfld 0x0400090E
    IL_0097: ldarg.0
    IL_009C: ldfld 0x04000911
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x04000915
    IL_00A3: ldelem.i
    IL_00A4: conv.r8
    IL_00A5: IL_4C
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: stloc.0
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x0400090E
    IL_00AF: conv.r8
    IL_00B0: IL_4D
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: stloc.0
    IL_00B8: br IL_00F0
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x0400090E
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x04000912
    IL_00C5: conv.r8
    IL_00C6: IL_4C
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: stloc.0
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x0400090E
    IL_00D0: conv.r8
    IL_00D1: IL_4D
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: stloc.0
    IL_00D9: br IL_00F0
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x0400090E
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000913
    IL_00E6: conv.r8
    IL_00E7: ldind.ref
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: stloc.0
    IL_00EF: br IL_00F0
    IL_00F0: ldarg.0
    IL_00F1: IL_22
    IL_00F2: IL_CD
    IL_00F3: IL_CC
    IL_00F4: IL_4C
    IL_00F5: IL_3D
    IL_00FA: stfld 0x0400090D
    IL_00FB: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400090D
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_43
    IL_000D: ldloca.s 0
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x0400090D
    IL_001B: call 0x0A000024
    IL_001C: IL_59
    IL_0021: stfld 0x0400090D
    IL_0022: ret
    }

    }}
