// Namespace: 
// Type: ChannelMgr

    public class ChannelMgr {{

    private object channelId;
    private static object instance;

    private ChannelMgr() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001BC9
    IL_000A: stfld 0x04000414
    IL_000B: ldarg.0
    IL_0010: call 0x0A000065
    IL_0011: ret
    }

    public static void GetInstance() {
    IL_0004: ldsfld 0x04000415
    IL_0009: brtrue IL_0014
    IL_000E: newobj 0x060001EE
    IL_0013: stsfld 0x04000415
    IL_0018: ldsfld 0x04000415
    IL_0019: ret
    }

    public void init() {
    IL_0004: ldstr 0x70001BD7
    IL_0009: newobj 0x0A000091
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: ldstr 0x70001C05
    IL_0011: ldc.i4.0
    IL_0016: newarr 0x01000020
    IL_0017: conv.r8
    IL_0018: ldc.i4.m1
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_0028
    IL_001D: ldloc.1
    IL_0022: call 0x06000592
    IL_0023: stloc.2
    IL_0024: ldarg.0
    IL_0025: ldloc.2
    IL_002A: ldstr 0x70001C21
    IL_002B: conv.r8
    IL_002C: IL_41
    IL_002D: nop
    IL_002E: nop
    IL_0030: br.s IL_00AE
    IL_0031: ldnull
    IL_0032: ldarg.2
    IL_0033: nop
    IL_0034: ldarg.2
    IL_0035: IL_DD
    IL_0036: stloc.3
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: ldloc.0
    IL_003F: brfalse IL_0046
    IL_0040: ldloc.0
    IL_0041: conv.r8
    IL_0042: ldelem.ref
    IL_0043: nop
    IL_0044: nop
    IL_0045: stloc.0
    IL_0046: IL_DC
    IL_0047: ret
    }

    public void IsCM() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000414
    IL_000A: ldstr 0x700009B3
    IL_000F: call 0x0A0000EC
    IL_0014: brfalse IL_0017
    IL_0015: ldc.i4.1
    IL_0016: ret
    IL_0017: ldc.i4.0
    IL_0018: ret
    }

    public void IsCT() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000414
    IL_000A: ldstr 0x700009DD
    IL_000F: call 0x0A0000EC
    IL_0014: brfalse IL_0017
    IL_0015: ldc.i4.1
    IL_0016: ret
    IL_0017: ldc.i4.0
    IL_0018: ret
    }

    public void IsCU() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000414
    IL_000A: ldstr 0x700009C1
    IL_000F: call 0x0A0000EC
    IL_0014: brfalse IL_0017
    IL_0015: ldc.i4.1
    IL_0016: ret
    IL_0017: ldc.i4.0
    IL_0018: ret
    }

    public void IsCMM() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000414
    IL_000A: ldstr 0x700009CF
    IL_000F: call 0x0A0000EC
    IL_0014: brfalse IL_0017
    IL_0015: ldc.i4.1
    IL_0016: ret
    IL_0017: ldc.i4.0
    IL_0018: ret
    }

    public void getChannelId() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000414
    IL_0006: ret
    }

    }}
