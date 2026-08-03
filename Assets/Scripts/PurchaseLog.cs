// Namespace: 
// Type: PurchaseLog

    public sealed class PurchaseLog /* abstract */ {{

    public static void FileCreat() {
    IL_0004: call 0x0A0001E9
    IL_0009: ldstr 0x700229D4
    IL_000E: call 0x0A000011
    IL_000F: ldc.i4.1
    IL_0014: newobj 0x0A0001EA
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_001B: ldstr 0x700229F6
    IL_001C: conv.r8
    IL_001D: IL_EB
    IL_001E: IL_01
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: IL_DD
    IL_0022: stloc.3
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldloc.0
    IL_002B: brfalse IL_0032
    IL_002C: ldloc.0
    IL_002D: conv.r8
    IL_002E: ldelem.ref
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: IL_DC
    IL_0033: ret
    }

    public static void LogOn() {
    IL_0004: call 0x0A0001E9
    IL_0009: ldstr 0x700229D4
    IL_000E: call 0x0A000011
    IL_000F: ldc.i4.1
    IL_0014: newobj 0x0A0001EA
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_001B: call 0x0A0001EC
    IL_001C: stloc.1
    IL_001E: ldloca.s 1
    IL_0023: call 0x0A0001ED
    IL_0028: ldstr 0x700229FC
    IL_0029: ldarg.0
    IL_002E: ldstr 0x700229F6
    IL_0033: call 0x0A0001EE
    IL_0034: conv.r8
    IL_0035: IL_EB
    IL_0036: IL_01
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldloc.0
    IL_003A: conv.r8
    IL_003B: rem.un
    IL_003C: IL_01
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: IL_DD
    IL_0040: stloc.3
    IL_0041: nop
    IL_0042: nop
    IL_0043: nop
    IL_0044: ldloc.0
    IL_0049: brfalse IL_0050
    IL_004A: ldloc.0
    IL_004B: conv.r8
    IL_004C: ldelem.ref
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: IL_DC
    IL_0051: ret
    }

    }}
