// Namespace: 
// Type: CmBillingAndroid

    public class CmBillingAndroid {{

    private object klass;
    private static object _instance;

    public CmBillingAndroid() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001C55
    IL_000A: newobj 0x0A000091
    IL_000F: stfld 0x04000423
    IL_0010: ldarg.0
    IL_0015: call 0x0A000065
    IL_0016: ret
    }

    public static void get_Instance() {
    IL_0004: ldsfld 0x04000424
    IL_0009: brtrue IL_0014
    IL_000E: newobj 0x060001FF
    IL_0013: stsfld 0x04000424
    IL_0018: ldsfld 0x04000424
    IL_0019: ret
    }

    public void InitializeApp() {
    IL_0004: ldstr 0x70001C9D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70001CDB
    IL_0011: conv.r8
    IL_0012: IL_42
    IL_0013: nop
    IL_0014: nop
    IL_0016: br.s IL_0022
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000423
    IL_0021: ldstr 0x70001CFB
    IL_0022: ldc.i4.3
    IL_0027: newarr 0x01000020
    IL_0028: dup
    IL_0029: ldc.i4.0
    IL_002A: ldarg.1
    IL_002F: stelem 0xA2041725
    IL_0030: dup
    IL_0031: ldc.i4.2
    IL_0032: ldarg.3
    IL_0037: stelem 0x0000A06F
    IL_0038: stloc.0
    IL_0039: IL_DD
    IL_003A: stloc.3
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: ldloc.1
    IL_0043: brfalse IL_004A
    IL_0044: ldloc.1
    IL_0045: conv.r8
    IL_0046: ldelem.ref
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: IL_DC
    IL_004B: IL_DD
    IL_004C: stloc.3
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldloc.0
    IL_0055: brfalse IL_005C
    IL_0056: ldloc.0
    IL_0057: conv.r8
    IL_0058: ldelem.ref
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: IL_DC
    IL_005D: ret
    }

    public void GetActivateFlag() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000423
    IL_000A: ldstr 0x70001D09
    IL_000B: ldc.i4.1
    IL_0010: newarr 0x01000020
    IL_0011: dup
    IL_0012: ldc.i4.0
    IL_0013: ldarg.1
    IL_0018: stelem 0x0000146F
    IL_001A: br.s IL_0045
    }

    public void SetActivateFlag() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000423
    IL_000A: ldstr 0x70001D29
    IL_000B: ldc.i4.2
    IL_0010: newarr 0x01000020
    IL_0011: dup
    IL_0012: ldc.i4.0
    IL_0013: ldarg.1
    IL_0018: stelem 0x8C041725
    IL_001A: stloc.s 0
    IL_001B: nop
    IL_001C: IL_01
    IL_0021: stelem 0x0000A06F
    IL_0022: stloc.0
    IL_0023: ret
    }

    public void IsMusicEnabled() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000423
    IL_000A: ldstr 0x70001D49
    IL_000B: ldc.i4.0
    IL_0010: newarr 0x01000020
    IL_0011: conv.r8
    IL_0012: ldnull
    IL_0013: nop
    IL_0014: nop
    IL_0016: br.s IL_0041
    }

    public void DoBilling() {
    IL_0004: ldstr 0x70001D67
    IL_0009: call 0x0A00013D
    IL_000E: ldstr 0x70001C9D
    IL_0013: newobj 0x0A000091
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_001A: ldstr 0x70001CDB
    IL_001B: conv.r8
    IL_001C: IL_42
    IL_001D: nop
    IL_001E: nop
    IL_0020: br.s IL_002C
    IL_0021: ldloc.1
    IL_0026: ldstr 0x70001D8B
    IL_0027: ldc.i4.5
    IL_002C: newarr 0x01000020
    IL_002D: dup
    IL_002E: ldc.i4.0
    IL_002F: ldarg.1
    IL_0034: stelem 0xA2041725
    IL_0035: dup
    IL_0036: ldc.i4.2
    IL_0037: ldarg.3
    IL_003C: stelem 0x040E1925
    IL_0041: newobj 0x0100000B
    IL_0046: stelem 0x050E1A25
    IL_004B: newobj 0x01000013
    IL_0050: stelem 0x0000A76F
    IL_0051: stloc.0
    IL_0052: IL_DD
    IL_0053: stloc.3
    IL_0054: nop
    IL_0055: nop
    IL_0056: nop
    IL_0057: ldloc.1
    IL_005C: brfalse IL_0063
    IL_005D: ldloc.1
    IL_005E: conv.r8
    IL_005F: ldelem.ref
    IL_0060: nop
    IL_0061: nop
    IL_0062: stloc.0
    IL_0063: IL_DC
    IL_0064: IL_DD
    IL_0065: stloc.3
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: ldloc.0
    IL_006E: brfalse IL_0075
    IL_006F: ldloc.0
    IL_0070: conv.r8
    IL_0071: ldelem.ref
    IL_0072: nop
    IL_0073: nop
    IL_0074: stloc.0
    IL_0075: IL_DC
    IL_007A: ldstr 0x70001DA9
    IL_007F: call 0x0A00013D
    IL_0080: ret
    }

    public void GetCash() {
    IL_0004: ldstr 0x70001C9D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70001CDB
    IL_0011: conv.r8
    IL_0012: IL_42
    IL_0013: nop
    IL_0014: nop
    IL_0016: br.s IL_0022
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000423
    IL_0021: ldstr 0x70001DCF
    IL_0022: ldc.i4.4
    IL_0027: newarr 0x01000020
    IL_0028: dup
    IL_0029: ldc.i4.0
    IL_002E: call 0x0A00013E
    IL_0033: stelem 0xA2031725
    IL_0034: dup
    IL_0035: ldc.i4.2
    IL_0036: ldarg.2
    IL_003B: stelem 0x8C051925
    IL_003C: stloc.1
    IL_003D: nop
    IL_003E: nop
    IL_003F: IL_01
    IL_0044: stelem 0x0000A06F
    IL_0045: stloc.0
    IL_0046: IL_DD
    IL_0047: stloc.3
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: ldloc.1
    IL_0050: brfalse IL_0057
    IL_0051: ldloc.1
    IL_0052: conv.r8
    IL_0053: ldelem.ref
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: IL_DC
    IL_0058: IL_DD
    IL_0059: stloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: ldloc.0
    IL_0062: brfalse IL_0069
    IL_0063: ldloc.0
    IL_0064: conv.r8
    IL_0065: ldelem.ref
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: IL_DC
    IL_006A: ret
    }

    public void UseCash() {
    IL_0004: ldstr 0x70001C9D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70001CDB
    IL_0011: conv.r8
    IL_0012: IL_42
    IL_0013: nop
    IL_0014: nop
    IL_0016: br.s IL_0022
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000423
    IL_0021: ldstr 0x70001DDF
    IL_0022: ldc.i4.4
    IL_0027: newarr 0x01000020
    IL_0028: dup
    IL_0029: ldc.i4.0
    IL_002E: call 0x0A00013E
    IL_0033: stelem 0xA2031725
    IL_0034: dup
    IL_0035: ldc.i4.2
    IL_0036: ldarg.2
    IL_003B: stelem 0x8C051925
    IL_003C: stloc.1
    IL_003D: nop
    IL_003E: nop
    IL_003F: IL_01
    IL_0044: stelem 0x0000A06F
    IL_0045: stloc.0
    IL_0046: IL_DD
    IL_0047: stloc.3
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: ldloc.1
    IL_0050: brfalse IL_0057
    IL_0051: ldloc.1
    IL_0052: conv.r8
    IL_0053: ldelem.ref
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: IL_DC
    IL_0058: IL_DD
    IL_0059: stloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: ldloc.0
    IL_0062: brfalse IL_0069
    IL_0063: ldloc.0
    IL_0064: conv.r8
    IL_0065: ldelem.ref
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: IL_DC
    IL_006A: ret
    }

    public void Redeem() {
    IL_0004: ldstr 0x70001C9D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70001CDB
    IL_0011: conv.r8
    IL_0012: IL_42
    IL_0013: nop
    IL_0014: nop
    IL_0016: br.s IL_0022
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000423
    IL_0021: ldstr 0x70001DEF
    IL_0022: ldc.i4.1
    IL_0027: newarr 0x01000020
    IL_0028: dup
    IL_0029: ldc.i4.0
    IL_002A: ldarg.1
    IL_002F: stelem 0x0000A06F
    IL_0030: stloc.0
    IL_0031: IL_DD
    IL_0032: stloc.3
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: ldloc.1
    IL_003B: brfalse IL_0042
    IL_003C: ldloc.1
    IL_003D: conv.r8
    IL_003E: ldelem.ref
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: IL_DC
    IL_0043: IL_DD
    IL_0044: stloc.3
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: ldloc.0
    IL_004D: brfalse IL_0054
    IL_004E: ldloc.0
    IL_004F: conv.r8
    IL_0050: ldelem.ref
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: IL_DC
    IL_0055: ret
    }

    public void Log_LogIn() {
    IL_0004: ldstr 0x70001C9D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70001CDB
    IL_0011: conv.r8
    IL_0012: IL_42
    IL_0013: nop
    IL_0014: nop
    IL_0016: br.s IL_0022
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000423
    IL_0021: ldstr 0x70001E0B
    IL_0022: ldc.i4.2
    IL_0027: newarr 0x01000020
    IL_0028: dup
    IL_0029: ldc.i4.0
    IL_002A: ldarg.1
    IL_002F: stelem 0x8C041725
    IL_0030: stloc.1
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_01
    IL_0038: stelem 0x0000A06F
    IL_0039: stloc.0
    IL_003A: IL_DD
    IL_003B: stloc.3
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_003F: ldloc.1
    IL_0044: brfalse IL_004B
    IL_0045: ldloc.1
    IL_0046: conv.r8
    IL_0047: ldelem.ref
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: IL_DC
    IL_004C: IL_DD
    IL_004D: stloc.3
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: ldloc.0
    IL_0056: brfalse IL_005D
    IL_0057: ldloc.0
    IL_0058: conv.r8
    IL_0059: ldelem.ref
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: IL_DC
    IL_005E: ret
    }

    public void Log_LogOut() {
    IL_0004: ldstr 0x70001C9D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70001CDB
    IL_0011: conv.r8
    IL_0012: IL_42
    IL_0013: nop
    IL_0014: nop
    IL_0016: br.s IL_0022
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000423
    IL_0021: ldstr 0x70001E1F
    IL_0022: ldc.i4.3
    IL_0027: newarr 0x01000020
    IL_0028: dup
    IL_0029: ldc.i4.0
    IL_002A: ldarg.1
    IL_002F: stelem 0x8C041725
    IL_0030: stloc.1
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_01
    IL_0038: stelem 0x8C051825
    IL_003B: ldarg 0
    IL_003C: IL_01
    IL_0041: stelem 0x0000A06F
    IL_0042: stloc.0
    IL_0043: IL_DD
    IL_0044: stloc.3
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: ldloc.1
    IL_004D: brfalse IL_0054
    IL_004E: ldloc.1
    IL_004F: conv.r8
    IL_0050: ldelem.ref
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: IL_DC
    IL_0055: IL_DD
    IL_0056: stloc.3
    IL_0057: nop
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldloc.0
    IL_005F: brfalse IL_0066
    IL_0060: ldloc.0
    IL_0061: conv.r8
    IL_0062: ldelem.ref
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: IL_DC
    IL_0067: ret
    }

    public void GetBillingResult() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000423
    IL_000A: ldstr 0x70001E35
    IL_000B: ldc.i4.1
    IL_0010: newarr 0x01000020
    IL_0011: dup
    IL_0012: ldc.i4.0
    IL_0013: ldarg.1
    IL_0018: stelem 0x0000156F
    IL_001A: br.s IL_0045
    }

    public void ExitWithUI() {
    IL_0004: ldstr 0x70001C9D
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70001CDB
    IL_0011: conv.r8
    IL_0012: IL_42
    IL_0013: nop
    IL_0014: nop
    IL_0016: br.s IL_0022
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000423
    IL_0021: ldstr 0x70001E57
    IL_0022: ldc.i4.1
    IL_0027: newarr 0x01000020
    IL_0028: dup
    IL_0029: ldc.i4.0
    IL_002A: ldloc.1
    IL_002F: stelem 0x0000A06F
    IL_0030: stloc.0
    IL_0031: IL_DD
    IL_0032: stloc.3
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: ldloc.1
    IL_003B: brfalse IL_0042
    IL_003C: ldloc.1
    IL_003D: conv.r8
    IL_003E: ldelem.ref
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: IL_DC
    IL_0043: IL_DD
    IL_0044: stloc.3
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: ldloc.0
    IL_004D: brfalse IL_0054
    IL_004E: ldloc.0
    IL_004F: conv.r8
    IL_0050: ldelem.ref
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: IL_DC
    IL_0055: ret
    }

    public void Exit() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000423
    IL_000A: ldstr 0x70001E61
    IL_000B: ldc.i4.0
    IL_0010: newarr 0x01000020
    IL_0011: conv.r8
    IL_0012: ldelem.r8
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ret
    }

    }}
