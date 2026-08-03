// Namespace: 
// Type: Shadow_eagle

    public class Shadow_eagle {{

    private object mytransform;
    private object shadowpos;

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008CE
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040008CE
    IL_0007: conv.r8
    IL_0008: ldc.i4.2
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x040008CF
    IL_0011: ldarg.0
    IL_0016: ldflda 0x040008CF
    IL_0017: ldc.i4.1
    IL_0018: IL_22
    IL_0019: conv.r8
    IL_001B: ldloca.s 3
    IL_0020: beq IL_1A49
    IL_0021: stloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040008CE
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040008CF
    IL_002E: conv.r8
    IL_002F: ldloc.3
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    public virtual void Add() {
    IL_0000: ret
    }

    public virtual void get_Item() {
    IL_0000: ldnull
    IL_0001: ret
    }

    public virtual void set_Item() {
    IL_0000: ret
    }

    public virtual void get_Item() {
    IL_0000: ldnull
    IL_0001: ret
    }

    public virtual void set_Item() {
    IL_0000: ret
    }

    public virtual void get_Value() {
    IL_0004: ldsfld 0x0A000099
    IL_0005: ret
    }

    public virtual void set_Value() {
    IL_0000: ret
    }

    public virtual void get_Count() {
    IL_0000: ldc.i4.0
    IL_0001: ret
    }

    public virtual void Add() {
    IL_0000: ldarg.0
    IL_0005: ldsfld 0x0A000099
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_3D
    IL_0009: ldarg.2
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ret
    }

    public virtual void Remove() {
    IL_0000: ldnull
    IL_0001: ret
    }

    public virtual void Remove() {
    IL_0000: ldnull
    IL_0001: ret
    }

    public virtual void Remove() {
    IL_0000: ldarg.1
    IL_0001: ret
    }

    public virtual void get_Childs() {
    IL_0004: newobj 0x06000773
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: dup
    IL_0009: ldc.i4.s -2
    IL_000E: stfld 0x04001059
    IL_000F: ret
    }

    public void get_DeepChilds() {
    IL_0004: newobj 0x0600077B
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001061
    IL_000D: ldloc.0
    IL_000E: dup
    IL_0010: ldc.i4.s -2
    IL_0015: stfld 0x0400105F
    IL_0016: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022AE6
    IL_0005: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022AE6
    IL_0005: ret
    }

    public virtual void get_AsInt() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: conv.r8
    IL_0004: IL_42
    IL_0005: ldarg.2
    IL_0006: nop
    IL_0007: ldloc.0
    IL_0009: ldloca.s 0
    IL_000E: call 0x0A000206
    IL_0013: brfalse IL_0016
    IL_0014: ldloc.0
    IL_0015: ret
    IL_0016: ldc.i4.0
    IL_0017: ret
    }

    public virtual void set_AsInt() {
    IL_0000: ldarg.0
    IL_0002: ldarga.s 1
    IL_0007: call 0x0A000010
    IL_0008: conv.r8
    IL_0009: IL_43
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public virtual void get_AsFloat() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_0007: conv.r8
    IL_0008: IL_42
    IL_0009: ldarg.2
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000D: ldloca.s 0
    IL_0012: call 0x0A000207
    IL_0017: brfalse IL_001A
    IL_0018: ldloc.0
    IL_0019: ret
    IL_001A: IL_22
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: ret
    }

    public virtual void set_AsFloat() {
    IL_0000: ldarg.0
    IL_0002: ldarga.s 1
    IL_0007: call 0x0A000208
    IL_0008: conv.r8
    IL_0009: IL_43
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public virtual void get_AsDouble() {
    IL_0000: IL_23
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_0006: nop
    IL_0007: nop
    IL_0008: nop
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: conv.r8
    IL_000C: IL_42
    IL_000D: ldarg.2
    IL_000E: nop
    IL_000F: ldloc.0
    IL_0011: ldloca.s 0
    IL_0016: call 0x0A000209
    IL_001B: brfalse IL_001E
    IL_001C: ldloc.0
    IL_001D: ret
    IL_001E: IL_23
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: ret
    }

    public virtual void set_AsDouble() {
    IL_0000: ldarg.0
    IL_0002: ldarga.s 1
    IL_0007: call 0x0A00020A
    IL_0008: conv.r8
    IL_0009: IL_43
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public virtual void get_AsBool() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: conv.r8
    IL_0004: IL_42
    IL_0005: ldarg.2
    IL_0006: nop
    IL_0007: ldloc.0
    IL_0009: ldloca.s 0
    IL_000E: call 0x0A00020B
    IL_0013: brfalse IL_0016
    IL_0014: ldloc.0
    IL_0015: ret
    IL_0016: ldarg.0
    IL_0017: conv.r8
    IL_0018: IL_42
    IL_0019: ldarg.2
    IL_001A: nop
    IL_001B: ldloc.0
    IL_0020: call 0x0A00020C
    IL_0021: ldc.i4.0
    IL_0023: ceq
    IL_0024: ret
    }

    public virtual void set_AsBool() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: brfalse IL_0011
    IL_000B: ldstr 0x70000583
    IL_0010: br IL_0016
    IL_0015: ldstr 0x70022ADA
    IL_0016: conv.r8
    IL_0017: IL_43
    IL_0018: ldarg.2
    IL_0019: nop
    IL_001A: ldloc.0
    IL_001B: ret
    }

    public virtual void get_AsArray() {
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: IL_D6
    IL_0003: nop
    IL_0004: nop
    IL_0005: ldarg.0
    IL_0006: ret
    }

    public virtual void get_AsObject() {
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: IL_D7
    IL_0003: nop
    IL_0004: nop
    IL_0005: ldarg.0
    IL_0006: ret
    }

    public virtual void Equals() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x0A000205
    IL_0007: ret
    }

    public virtual void GetHashCode() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00020D
    IL_0006: ret
    }

    private static void Escape() {
    IL_0004: ldsfld 0x0A000099
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_0007: stloc.2
    IL_0008: ldc.i4.0
    IL_0009: stloc.3
    IL_000E: br IL_00DF
    IL_000F: ldloc.2
    IL_0010: ldloc.3
    IL_0011: conv.r8
    IL_0012: IL_E2
    IL_0013: IL_01
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0019: stloc.s 4
    IL_001B: ldloc.s 4
    IL_001C: ldc.i4.8
    IL_001D: IL_59
    IL_0020: ldarg 6
    IL_0021: nop
    IL_0022: nop
    IL_0023: conv.i4
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: add
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002F: brfalse IL_0030
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0037: stfld 0x4A000000
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003C: ldloc.s 4
    IL_003E: ldc.i4.s 34
    IL_0043: beq IL_0063
    IL_0045: ldloc.s 4
    IL_0047: ldc.i4.s 92
    IL_004C: beq IL_0052
    IL_0051: br IL_00C9
    IL_0052: ldloc.0
    IL_0057: ldstr 0x70022AF8
    IL_005C: call 0x0A000011
    IL_005D: stloc.0
    IL_0062: br IL_00DB
    IL_0063: ldloc.0
    IL_0068: ldstr 0x70022AFE
    IL_006D: call 0x0A000011
    IL_006E: stloc.0
    IL_0073: br IL_00DB
    IL_0074: ldloc.0
    IL_0079: ldstr 0x70022B04
    IL_007E: call 0x0A000011
    IL_007F: stloc.0
    IL_0084: br IL_00DB
    IL_0085: ldloc.0
    IL_008A: ldstr 0x70022B0A
    IL_008F: call 0x0A000011
    IL_0090: stloc.0
    IL_0095: br IL_00DB
    IL_0096: ldloc.0
    IL_009B: ldstr 0x70022B10
    IL_00A0: call 0x0A000011
    IL_00A1: stloc.0
    IL_00A6: br IL_00DB
    IL_00A7: ldloc.0
    IL_00AC: ldstr 0x70022B16
    IL_00B1: call 0x0A000011
    IL_00B2: stloc.0
    IL_00B7: br IL_00DB
    IL_00B8: ldloc.0
    IL_00BD: ldstr 0x70022B1C
    IL_00C2: call 0x0A000011
    IL_00C3: stloc.0
    IL_00C8: br IL_00DB
    IL_00C9: ldloc.0
    IL_00CA: ldloc.1
    IL_00CF: newobj 0x0100002A
    IL_00D4: call 0x0A00009A
    IL_00D5: stloc.0
    IL_00DA: br IL_00DB
    IL_00DB: ldloc.3
    IL_00DC: ldc.i4.1
    IL_00DD: IL_58
    IL_00DE: stloc.3
    IL_00DF: ldloc.3
    IL_00E0: ldloc.2
    IL_00E1: conv.r8
    IL_00E2: ldelem.i1
    IL_00E3: nop
    IL_00E4: nop
    IL_00E5: stloc.0
    IL_00E6: IL_3F
    IL_00E7: IL_24
    IL_00E8: IL_FF
    IL_00E9: IL_FF
    IL_00EA: IL_FF
    IL_00EB: ldloc.0
    IL_00EC: ret
    }

    public static void Parse() {
    IL_0004: newobj 0x0A00020E
    IL_0005: stloc.0
    IL_0006: ldnull
    IL_0007: stloc.1
    IL_0008: ldc.i4.0
    IL_0009: stloc.2
    IL_000E: ldsfld 0x0A000099
    IL_000F: stloc.3
    IL_0014: ldsfld 0x0A000099
    IL_0016: stloc.s 4
    IL_0017: ldc.i4.0
    IL_0019: stloc.s 5
    IL_001E: br IL_046B
    IL_001F: ldarg.0
    IL_0020: ldloc.2
    IL_0021: conv.r8
    IL_0022: IL_E2
    IL_0023: IL_01
    IL_0024: nop
    IL_0025: stloc.0
    IL_0027: stloc.s 8
    IL_0029: ldloc.s 8
    IL_002B: ldc.i4.s 9
    IL_002C: IL_59
    IL_002F: ldarg 5
    IL_0030: nop
    IL_0031: nop
    IL_0032: IL_ED
    IL_0033: ldarg.0
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_E8
    IL_0037: ldarg.0
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: IL_E8
    IL_0043: ldarg.0
    IL_0044: nop
    IL_0045: nop
    IL_0047: ldloc.s 8
    IL_0049: ldc.i4.s 32
    IL_004A: IL_59
    IL_004D: ldarg 3
    IL_004E: nop
    IL_004F: nop
    IL_0050: IL_D7
    IL_0051: ldarg.0
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: nop
    IL_0057: nop
    IL_0058: localloc
    IL_0059: ldarg.0
    IL_005A: nop
    IL_005B: nop
    IL_005D: ldloc.s 8
    IL_005F: ldc.i4.s 91
    IL_0060: IL_59
    IL_0063: ldarg 3
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_C0
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_E0
    IL_006B: ldarg.0
    IL_006C: nop
    IL_006D: nop
    IL_006E: IL_53
    IL_006F: IL_01
    IL_0070: nop
    IL_0071: nop
    IL_0073: ldloc.s 8
    IL_0075: ldc.i4.s 123
    IL_0076: IL_59
    IL_0079: ldarg 3
    IL_007A: nop
    IL_007B: nop
    IL_007C: ldc.i4.1
    IL_007D: nop
    IL_007E: nop
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0082: nop
    IL_0083: nop
    IL_0084: IL_3D
    IL_0085: IL_01
    IL_0086: nop
    IL_0087: nop
    IL_0089: ldloc.s 8
    IL_008B: ldc.i4.s 44
    IL_0090: beq IL_02B2
    IL_0092: ldloc.s 8
    IL_0094: ldc.i4.s 58
    IL_0099: beq IL_027A
    IL_009E: br IL_044F
    IL_00A0: ldloc.s 5
    IL_00A5: brfalse IL_00BE
    IL_00A6: ldloc.3
    IL_00A7: ldarg.0
    IL_00A8: ldloc.2
    IL_00A9: conv.r8
    IL_00AA: IL_E2
    IL_00AB: IL_01
    IL_00AC: nop
    IL_00AD: stloc.0
    IL_00B2: newobj 0x0100002A
    IL_00B7: call 0x0A00009A
    IL_00B8: stloc.3
    IL_00BD: br IL_0467
    IL_00BE: ldloc.0
    IL_00C3: newobj 0x0600047B
    IL_00C4: conv.r8
    IL_00C6: ldarga.s 2
    IL_00C7: nop
    IL_00C8: stloc.0
    IL_00C9: ldloc.1
    IL_00CA: ldnull
    IL_00CF: call 0x0600046C
    IL_00D4: brfalse IL_0119
    IL_00D6: ldloc.s 4
    IL_00D7: conv.r8
    IL_00D9: starg.s 2
    IL_00DA: nop
    IL_00DB: stloc.0
    IL_00DD: stloc.s 4
    IL_00DE: ldloc.1
    IL_00DF: conv.u8
    IL_00E0: IL_D6
    IL_00E1: nop
    IL_00E2: nop
    IL_00E3: ldarg.0
    IL_00E8: brfalse IL_00FA
    IL_00E9: ldloc.1
    IL_00EA: ldloc.0
    IL_00EB: conv.r8
    IL_00ED: ldloc.s 2
    IL_00EE: nop
    IL_00EF: stloc.0
    IL_00F0: conv.r8
    IL_00F3: ldarg 4
    IL_00F4: ldloc.0
    IL_00F9: br IL_0119
    IL_00FB: ldloc.s 4
    IL_0100: ldsfld 0x0A000099
    IL_0105: call 0x0A0000A6
    IL_010A: brfalse IL_0119
    IL_010B: ldloc.1
    IL_010D: ldloc.s 4
    IL_010E: ldloc.0
    IL_010F: conv.r8
    IL_0111: ldloc.s 2
    IL_0112: nop
    IL_0113: stloc.0
    IL_0114: conv.r8
    IL_0115: IL_3D
    IL_0116: ldarg.2
    IL_0117: nop
    IL_0118: ldloc.0
    IL_011D: ldsfld 0x0A000099
    IL_011F: stloc.s 4
    IL_0124: ldsfld 0x0A000099
    IL_0125: stloc.3
    IL_0126: ldloc.0
    IL_0127: conv.r8
    IL_0129: ldloc.s 2
    IL_012A: nop
    IL_012B: stloc.0
    IL_012C: stloc.1
    IL_0131: br IL_0467
    IL_0133: ldloc.s 5
    IL_0138: brfalse IL_0151
    IL_0139: ldloc.3
    IL_013A: ldarg.0
    IL_013B: ldloc.2
    IL_013C: conv.r8
    IL_013D: IL_E2
    IL_013E: IL_01
    IL_013F: nop
    IL_0140: stloc.0
    IL_0145: newobj 0x0100002A
    IL_014A: call 0x0A00009A
    IL_014B: stloc.3
    IL_0150: br IL_0467
    IL_0151: ldloc.0
    IL_0156: newobj 0x0600046D
    IL_0157: conv.r8
    IL_0159: ldarga.s 2
    IL_015A: nop
    IL_015B: stloc.0
    IL_015C: ldloc.1
    IL_015D: ldnull
    IL_0162: call 0x0600046C
    IL_0167: brfalse IL_01AC
    IL_0169: ldloc.s 4
    IL_016A: conv.r8
    IL_016C: starg.s 2
    IL_016D: nop
    IL_016E: stloc.0
    IL_0170: stloc.s 4
    IL_0171: ldloc.1
    IL_0172: conv.u8
    IL_0173: IL_D6
    IL_0174: nop
    IL_0175: nop
    IL_0176: ldarg.0
    IL_017B: brfalse IL_018D
    IL_017C: ldloc.1
    IL_017D: ldloc.0
    IL_017E: conv.r8
    IL_0180: ldloc.s 2
    IL_0181: nop
    IL_0182: stloc.0
    IL_0183: conv.r8
    IL_0186: ldarg 4
    IL_0187: ldloc.0
    IL_018C: br IL_01AC
    IL_018E: ldloc.s 4
    IL_0193: ldsfld 0x0A000099
    IL_0198: call 0x0A0000A6
    IL_019D: brfalse IL_01AC
    IL_019E: ldloc.1
    IL_01A0: ldloc.s 4
    IL_01A1: ldloc.0
    IL_01A2: conv.r8
    IL_01A4: ldloc.s 2
    IL_01A5: nop
    IL_01A6: stloc.0
    IL_01A7: conv.r8
    IL_01A8: IL_3D
    IL_01A9: ldarg.2
    IL_01AA: nop
    IL_01AB: ldloc.0
    IL_01B0: ldsfld 0x0A000099
    IL_01B2: stloc.s 4
    IL_01B7: ldsfld 0x0A000099
    IL_01B8: stloc.3
    IL_01B9: ldloc.0
    IL_01BA: conv.r8
    IL_01BC: ldloc.s 2
    IL_01BD: nop
    IL_01BE: stloc.0
    IL_01BF: stloc.1
    IL_01C4: br IL_0467
    IL_01C6: ldloc.s 5
    IL_01CB: brfalse IL_01E4
    IL_01CC: ldloc.3
    IL_01CD: ldarg.0
    IL_01CE: ldloc.2
    IL_01CF: conv.r8
    IL_01D0: IL_E2
    IL_01D1: IL_01
    IL_01D2: nop
    IL_01D3: stloc.0
    IL_01D8: newobj 0x0100002A
    IL_01DD: call 0x0A00009A
    IL_01DE: stloc.3
    IL_01E3: br IL_0467
    IL_01E4: ldloc.0
    IL_01E5: conv.r8
    IL_01E7: ldloca.s 2
    IL_01E8: nop
    IL_01E9: stloc.0
    IL_01EE: brtrue IL_01FA
    IL_01F3: ldstr 0x70022B22
    IL_01F8: newobj 0x0A000213
    IL_01F9: throw
    IL_01FA: ldloc.0
    IL_01FB: conv.r8
    IL_01FC: ldnull
    IL_01FD: ldarg.0
    IL_01FE: nop
    IL_01FF: stloc.0
    IL_0200: pop
    IL_0201: ldloc.3
    IL_0206: ldsfld 0x0A000099
    IL_020B: call 0x0A0000A6
    IL_0210: brfalse IL_0255
    IL_0212: ldloc.s 4
    IL_0213: conv.r8
    IL_0215: starg.s 2
    IL_0216: nop
    IL_0217: stloc.0
    IL_0219: stloc.s 4
    IL_021A: ldloc.1
    IL_021B: conv.u8
    IL_021C: IL_D6
    IL_021D: nop
    IL_021E: nop
    IL_021F: ldarg.0
    IL_0224: brfalse IL_0236
    IL_0225: ldloc.1
    IL_0226: ldloc.3
    IL_022B: call 0x06000469
    IL_022C: conv.r8
    IL_022F: ldarg 4
    IL_0230: ldloc.0
    IL_0235: br IL_0255
    IL_0237: ldloc.s 4
    IL_023C: ldsfld 0x0A000099
    IL_0241: call 0x0A0000A6
    IL_0246: brfalse IL_0255
    IL_0247: ldloc.1
    IL_0249: ldloc.s 4
    IL_024A: ldloc.3
    IL_024F: call 0x06000469
    IL_0250: conv.r8
    IL_0251: IL_3D
    IL_0252: ldarg.2
    IL_0253: nop
    IL_0254: ldloc.0
    IL_0259: ldsfld 0x0A000099
    IL_025B: stloc.s 4
    IL_0260: ldsfld 0x0A000099
    IL_0261: stloc.3
    IL_0262: ldloc.0
    IL_0263: conv.r8
    IL_0265: ldloca.s 2
    IL_0266: nop
    IL_0267: stloc.0
    IL_0268: ldc.i4.0
    IL_0269: IL_3E
    IL_026A: ldloc.1
    IL_026B: nop
    IL_026C: nop
    IL_026D: nop
    IL_026E: ldloc.0
    IL_026F: conv.r8
    IL_0271: ldloc.s 2
    IL_0272: nop
    IL_0273: stloc.0
    IL_0274: stloc.1
    IL_0279: br IL_0467
    IL_027B: ldloc.s 5
    IL_0280: brfalse IL_0299
    IL_0281: ldloc.3
    IL_0282: ldarg.0
    IL_0283: ldloc.2
    IL_0284: conv.r8
    IL_0285: IL_E2
    IL_0286: IL_01
    IL_0287: nop
    IL_0288: stloc.0
    IL_028D: newobj 0x0100002A
    IL_0292: call 0x0A00009A
    IL_0293: stloc.3
    IL_0298: br IL_0467
    IL_0299: ldloc.3
    IL_029B: stloc.s 4
    IL_02A0: ldsfld 0x0A000099
    IL_02A1: stloc.3
    IL_02A6: br IL_0467
    IL_02A8: ldloc.s 5
    IL_02A9: ldc.i4.1
    IL_02AA: rem.un
    IL_02AC: stloc.s 5
    IL_02B1: br IL_0467
    IL_02B3: ldloc.s 5
    IL_02B8: brfalse IL_02D1
    IL_02B9: ldloc.3
    IL_02BA: ldarg.0
    IL_02BB: ldloc.2
    IL_02BC: conv.r8
    IL_02BD: IL_E2
    IL_02BE: IL_01
    IL_02BF: nop
    IL_02C0: stloc.0
    IL_02C5: newobj 0x0100002A
    IL_02CA: call 0x0A00009A
    IL_02CB: stloc.3
    IL_02D0: br IL_0467
    IL_02D1: ldloc.3
    IL_02D6: ldsfld 0x0A000099
    IL_02DB: call 0x0A0000A6
    IL_02E0: brfalse IL_031C
    IL_02E1: ldloc.1
    IL_02E2: conv.u8
    IL_02E3: IL_D6
    IL_02E4: nop
    IL_02E5: nop
    IL_02E6: ldarg.0
    IL_02EB: brfalse IL_02FD
    IL_02EC: ldloc.1
    IL_02ED: ldloc.3
    IL_02F2: call 0x06000469
    IL_02F3: conv.r8
    IL_02F6: ldarg 4
    IL_02F7: ldloc.0
    IL_02FC: br IL_031C
    IL_02FE: ldloc.s 4
    IL_0303: ldsfld 0x0A000099
    IL_0308: call 0x0A0000A6
    IL_030D: brfalse IL_031C
    IL_030E: ldloc.1
    IL_0310: ldloc.s 4
    IL_0311: ldloc.3
    IL_0316: call 0x06000469
    IL_0317: conv.r8
    IL_0318: IL_3D
    IL_0319: ldarg.2
    IL_031A: nop
    IL_031B: ldloc.0
    IL_0320: ldsfld 0x0A000099
    IL_0322: stloc.s 4
    IL_0327: ldsfld 0x0A000099
    IL_0328: stloc.3
    IL_032D: br IL_0467
    IL_0332: br IL_0467
    IL_0334: ldloc.s 5
    IL_0339: brfalse IL_034D
    IL_033A: ldloc.3
    IL_033B: ldarg.0
    IL_033C: ldloc.2
    IL_033D: conv.r8
    IL_033E: IL_E2
    IL_033F: IL_01
    IL_0340: nop
    IL_0341: stloc.0
    IL_0346: newobj 0x0100002A
    IL_034B: call 0x0A00009A
    IL_034C: stloc.3
    IL_0351: br IL_0467
    IL_0352: ldloc.2
    IL_0353: ldc.i4.1
    IL_0354: IL_58
    IL_0355: stloc.2
    IL_0357: ldloc.s 5
    IL_035C: brfalse IL_044A
    IL_035D: ldarg.0
    IL_035E: ldloc.2
    IL_035F: conv.r8
    IL_0360: IL_E2
    IL_0361: IL_01
    IL_0362: nop
    IL_0363: stloc.0
    IL_0365: stloc.s 6
    IL_0367: ldloc.s 6
    IL_0369: stloc.s 9
    IL_036B: ldloc.s 9
    IL_036D: ldc.i4.s 110
    IL_036E: IL_59
    IL_0371: ldarg 8
    IL_0372: nop
    IL_0373: nop
    IL_0374: IL_3D
    IL_0375: nop
    IL_0376: nop
    IL_0377: nop
    IL_0378: nop
    IL_0379: nop
    IL_037A: nop
    IL_037B: nop
    IL_037C: nop
    IL_037D: nop
    IL_037E: nop
    IL_037F: nop
    IL_0380: nop
    IL_0381: nop
    IL_0382: nop
    IL_0383: nop
    IL_0384: ret
    IL_0385: nop
    IL_0386: nop
    IL_0387: nop
    IL_0388: nop
    IL_0389: nop
    IL_038A: nop
    IL_038B: nop
    IL_038C: ldc.i4.1
    IL_038D: nop
    IL_038E: nop
    IL_038F: nop
    IL_0390: conv.u8
    IL_0391: nop
    IL_0392: nop
    IL_0393: nop
    IL_0395: ldloc.s 9
    IL_0397: ldc.i4.s 98
    IL_039C: beq IL_03E4
    IL_039E: ldloc.s 9
    IL_03A0: ldc.i4.s 102
    IL_03A5: beq IL_03F6
    IL_03AA: br IL_0437
    IL_03AB: ldloc.3
    IL_03AD: ldc.i4.s 9
    IL_03B2: newobj 0x0100002A
    IL_03B7: call 0x0A00009A
    IL_03B8: stloc.3
    IL_03BD: br IL_044A
    IL_03BE: ldloc.3
    IL_03C0: ldc.i4.s 13
    IL_03C5: newobj 0x0100002A
    IL_03CA: call 0x0A00009A
    IL_03CB: stloc.3
    IL_03D0: br IL_044A
    IL_03D1: ldloc.3
    IL_03D3: ldc.i4.s 10
    IL_03D8: newobj 0x0100002A
    IL_03DD: call 0x0A00009A
    IL_03DE: stloc.3
    IL_03E3: br IL_044A
    IL_03E4: ldloc.3
    IL_03E5: ldc.i4.8
    IL_03EA: newobj 0x0100002A
    IL_03EF: call 0x0A00009A
    IL_03F0: stloc.3
    IL_03F5: br IL_044A
    IL_03F6: ldloc.3
    IL_03F8: ldc.i4.s 12
    IL_03FD: newobj 0x0100002A
    IL_0402: call 0x0A00009A
    IL_0403: stloc.3
    IL_0408: br IL_044A
    IL_0409: ldarg.0
    IL_040A: ldloc.2
    IL_040B: ldc.i4.1
    IL_040C: IL_58
    IL_040D: ldc.i4.4
    IL_040E: conv.r8
    IL_040F: ldelem.i2
    IL_0410: nop
    IL_0411: nop
    IL_0412: stloc.0
    IL_0414: stloc.s 7
    IL_0415: ldloc.3
    IL_0417: ldloc.s 7
    IL_041C: ldc.i4 512
    IL_0421: call 0x0A000215
    IL_0422: IL_D1
    IL_0427: newobj 0x0100002A
    IL_042C: call 0x0A00009A
    IL_042D: stloc.3
    IL_042E: ldloc.2
    IL_042F: ldc.i4.4
    IL_0430: IL_58
    IL_0431: stloc.2
    IL_0436: br IL_044A
    IL_0437: ldloc.3
    IL_0439: ldloc.s 6
    IL_043E: newobj 0x0100002A
    IL_0443: call 0x0A00009A
    IL_0444: stloc.3
    IL_0449: br IL_044A
    IL_044E: br IL_0467
    IL_044F: ldloc.3
    IL_0450: ldarg.0
    IL_0451: ldloc.2
    IL_0452: conv.r8
    IL_0453: IL_E2
    IL_0454: IL_01
    IL_0455: nop
    IL_0456: stloc.0
    IL_045B: newobj 0x0100002A
    IL_0460: call 0x0A00009A
    IL_0461: stloc.3
    IL_0466: br IL_0467
    IL_0467: ldloc.2
    IL_0468: ldc.i4.1
    IL_0469: IL_58
    IL_046A: stloc.2
    IL_046B: ldloc.2
    IL_046C: ldarg.0
    IL_046D: conv.r8
    IL_046E: ldelem.i1
    IL_046F: nop
    IL_0470: nop
    IL_0471: stloc.0
    IL_0472: IL_3F
    IL_0473: IL_A8
    IL_0474: IL_FB
    IL_0475: IL_FF
    IL_0476: IL_FF
    IL_0478: ldloc.s 5
    IL_047D: brfalse IL_0489
    IL_0482: ldstr 0x70022B6E
    IL_0487: newobj 0x0A000213
    IL_0488: throw
    IL_0489: ldloc.1
    IL_048A: ret
    }

    public virtual void Serialize() {
    IL_0000: ret
    }

    public void SaveToStream() {
    IL_0000: ldarg.1
    IL_0005: newobj 0x0A000216
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldloc.0
    IL_0009: conv.r8
    IL_000A: add
    IL_000B: ldarg.2
    IL_000C: nop
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void SaveToCompressedStream() {
    IL_0004: ldstr 0x70022BD4
    IL_0009: newobj 0x0A000213
    IL_000A: throw
    }

    public void SaveToCompressedFile() {
    IL_0004: ldstr 0x70022BD4
    IL_0009: newobj 0x0A000213
    IL_000A: throw
    }

    public void SaveToCompressedBase64() {
    IL_0004: ldstr 0x70022BD4
    IL_0009: newobj 0x0A000213
    IL_000A: throw
    }

    public void SaveToFile() {
    IL_0000: ret
    }

    public void SaveToBase64() {
    IL_0004: newobj 0x0A00015D
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_0007: ldloc.0
    IL_000C: call 0x0600045C
    IL_000D: ldloc.0
    IL_000E: ldc.i4.0
    IL_000F: conv.i1
    IL_0010: conv.r8
    IL_0011: ldc.i4.1
    IL_0012: ldarg.0
    IL_0013: nop
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: conv.r8
    IL_0017: and
    IL_0018: IL_01
    IL_0019: nop
    IL_001A: stloc.0
    IL_001F: call 0x0A000163
    IL_0020: stloc.1
    IL_0021: IL_DD
    IL_0023: ldloca.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: IL_DD
    IL_0027: stloc.3
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldloc.0
    IL_0030: brfalse IL_0037
    IL_0031: ldloc.0
    IL_0032: conv.r8
    IL_0033: ldelem.ref
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: IL_DC
    IL_0038: ldloc.1
    IL_0039: ret
    }

    public static void Deserialize() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ldc.i4.2
    IL_0003: ldarg.0
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0009: stloc.s 9
    IL_000B: ldloc.s 9
    IL_000C: ldc.i4.1
    IL_000D: IL_59
    IL_0010: ldarg 7
    IL_0011: nop
    IL_0012: nop
    IL_0013: ldarg.3
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0018: blt.s IL_0019
    IL_0019: nop
    IL_001A: nop
    IL_001B: conv.r.un
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_82
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: len
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: ldelem.i
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002F: isinst 0x38000000
    IL_0030: IL_AD
    IL_0031: nop
    IL_0032: nop
    IL_0033: nop
    IL_0034: ldarg.0
    IL_0035: conv.r8
    IL_0036: ldc.i4.3
    IL_0037: ldarg.0
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: stloc.1
    IL_003F: newobj 0x0600046D
    IL_0040: stloc.2
    IL_0041: ldc.i4.0
    IL_0042: stloc.3
    IL_0047: br IL_0058
    IL_0048: ldloc.2
    IL_0049: ldarg.0
    IL_004E: call 0x06000462
    IL_004F: conv.r8
    IL_0052: ldarg 4
    IL_0053: ldloc.0
    IL_0054: ldloc.3
    IL_0055: ldc.i4.1
    IL_0056: IL_58
    IL_0057: stloc.3
    IL_0058: ldloc.3
    IL_0059: ldloc.1
    IL_005A: IL_3F
    IL_005B: IL_E9
    IL_005C: IL_FF
    IL_005D: IL_FF
    IL_005E: IL_FF
    IL_005F: ldloc.2
    IL_0060: ret
    IL_0061: ldarg.0
    IL_0062: conv.r8
    IL_0063: ldc.i4.3
    IL_0064: ldarg.0
    IL_0065: nop
    IL_0066: stloc.0
    IL_0068: stloc.s 4
    IL_006D: newobj 0x0600047B
    IL_006F: stloc.s 5
    IL_0070: ldc.i4.0
    IL_0072: stloc.s 6
    IL_0077: br IL_0099
    IL_0078: ldarg.0
    IL_0079: conv.r8
    IL_007A: ldc.i4.4
    IL_007B: ldarg.0
    IL_007C: nop
    IL_007D: stloc.0
    IL_007F: stloc.s 7
    IL_0080: ldarg.0
    IL_0085: call 0x06000462
    IL_0087: stloc.s 8
    IL_0089: ldloc.s 5
    IL_008B: ldloc.s 7
    IL_008D: ldloc.s 8
    IL_008E: conv.r8
    IL_008F: IL_83
    IL_0090: ldarg.2
    IL_0091: nop
    IL_0092: ldloc.0
    IL_0094: ldloc.s 6
    IL_0095: ldc.i4.1
    IL_0096: IL_58
    IL_0098: stloc.s 6
    IL_009A: ldloc.s 6
    IL_009C: ldloc.s 4
    IL_009D: IL_3F
    IL_009E: IL_D6
    IL_009F: IL_FF
    IL_00A0: IL_FF
    IL_00A1: IL_FF
    IL_00A3: ldloc.s 5
    IL_00A4: ret
    IL_00A5: ldarg.0
    IL_00A6: conv.r8
    IL_00A7: ldc.i4.4
    IL_00A8: ldarg.0
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AF: newobj 0x0600048C
    IL_00B0: ret
    IL_00B1: ldarg.0
    IL_00B2: conv.r8
    IL_00B3: ldc.i4.3
    IL_00B4: ldarg.0
    IL_00B5: nop
    IL_00B6: stloc.0
    IL_00BB: newobj 0x06000490
    IL_00BC: ret
    IL_00BD: ldarg.0
    IL_00BE: conv.r8
    IL_00BF: ldc.i4.5
    IL_00C0: ldarg.0
    IL_00C1: nop
    IL_00C2: stloc.0
    IL_00C7: newobj 0x0600048E
    IL_00C8: ret
    IL_00C9: ldarg.0
    IL_00CA: conv.r8
    IL_00CB: ldc.i4.6
    IL_00CC: ldarg.0
    IL_00CD: nop
    IL_00CE: stloc.0
    IL_00D3: newobj 0x0600048F
    IL_00D4: ret
    IL_00D5: ldarg.0
    IL_00D6: conv.r8
    IL_00D7: ldc.i4.7
    IL_00D8: ldarg.0
    IL_00D9: nop
    IL_00DA: stloc.0
    IL_00DF: newobj 0x0600048D
    IL_00E0: ret
    IL_00E5: ldstr 0x70022CBB
    IL_00E6: ldloc.0
    IL_00EB: newobj 0x020000D4
    IL_00F0: call 0x0A00009A
    IL_00F5: newobj 0x0A000213
    IL_00F6: throw
    }

    public static void LoadFromCompressedFile() {
    IL_0004: ldstr 0x70022BD4
    IL_0009: newobj 0x0A000213
    IL_000A: throw
    }

    public static void LoadFromCompressedStream() {
    IL_0004: ldstr 0x70022BD4
    IL_0009: newobj 0x0A000213
    IL_000A: throw
    }

    public static void LoadFromCompressedBase64() {
    IL_0004: ldstr 0x70022BD4
    IL_0009: newobj 0x0A000213
    IL_000A: throw
    }

    public static void LoadFromStream() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x0A00021E
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_000C: call 0x06000462
    IL_000D: stloc.1
    IL_000E: IL_DD
    IL_0010: ldloca.s 0
    IL_0011: nop
    IL_0012: nop
    IL_0013: IL_DD
    IL_0014: stloc.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldloc.0
    IL_001D: brfalse IL_0024
    IL_001E: ldloc.0
    IL_001F: conv.r8
    IL_0020: ldelem.ref
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: IL_DC
    IL_0025: ldloc.1
    IL_0026: ret
    }

    public static void LoadFromFile() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00021F
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_000C: call 0x06000466
    IL_000D: stloc.1
    IL_000E: IL_DD
    IL_0010: ldloca.s 0
    IL_0011: nop
    IL_0012: nop
    IL_0013: IL_DD
    IL_0014: stloc.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldloc.0
    IL_001D: brfalse IL_0024
    IL_001E: ldloc.0
    IL_001F: conv.r8
    IL_0020: ldelem.ref
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: IL_DC
    IL_0025: ldloc.1
    IL_0026: ret
    }

    public static void LoadFromBase64() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00014C
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_000C: newobj 0x0A000155
    IL_000D: stloc.1
    IL_000E: ldloc.1
    IL_000F: ldc.i4.0
    IL_0010: conv.i1
    IL_0011: conv.r8
    IL_0012: ldc.i4.1
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldloc.1
    IL_001B: call 0x06000466
    IL_001C: ret
    }

    public static void op_Implicit() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x0600048C
    IL_0006: ret
    }

    public static void op_Implicit() {
    IL_0000: ldarg.0
    IL_0001: ldnull
    IL_0006: call 0x0600046B
    IL_000B: brfalse IL_0012
    IL_000C: ldnull
    IL_0011: br IL_0018
    IL_0012: ldarg.0
    IL_0013: conv.r8
    IL_0014: IL_42
    IL_0015: ldarg.2
    IL_0016: nop
    IL_0017: ldloc.0
    IL_0018: ret
    }

    public static void op_Equality() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0013
    IL_0006: ldarg.0
    IL_0007: conv.u8
    IL_0008: IL_D9
    IL_0009: nop
    IL_000A: nop
    IL_000B: ldarg.0
    IL_0010: brfalse IL_0013
    IL_0011: ldc.i4.1
    IL_0012: ret
    IL_0013: ldarg.0
    IL_0014: ldarg.1
    IL_0019: call 0x0A000205
    IL_001A: ret
    }

    public static void op_Inequality() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x0600046B
    IL_0007: ldc.i4.0
    IL_0009: ceq
    IL_000A: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x0A000223
    IL_000A: stfld 0x040008D8
    IL_000B: ldarg.0
    IL_0010: call 0x0600043C
    IL_0011: ret
    }

    public virtual void get_Item() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D8
    IL_000E: conv.r8
    IL_000F: IL_24
    IL_0010: ldarg.0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0014: ldloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.0
    IL_001D: newobj 0x06000496
    IL_001E: ret
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040008D8
    IL_0025: ldarg.1
    IL_0026: conv.r8
    IL_0027: dup
    IL_0028: ldarg.0
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ret
    }

    public virtual void set_Item() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D8
    IL_000E: conv.r8
    IL_000F: IL_24
    IL_0010: ldarg.0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0015: ldloc.s 0
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040008D8
    IL_001E: ldarg.2
    IL_001F: conv.r8
    IL_0020: pop
    IL_0021: ldarg.0
    IL_0022: nop
    IL_0023: stloc.0
    IL_0028: br IL_0036
    IL_0029: ldarg.0
    IL_002E: ldfld 0x040008D8
    IL_002F: ldarg.1
    IL_0030: ldarg.2
    IL_0031: conv.r8
    IL_0032: IL_27
    IL_0033: ldarg.0
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ret
    }

    public virtual void get_Item() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x06000496
    IL_0006: ret
    }

    public virtual void set_Item() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D8
    IL_0006: ldarg.2
    IL_0007: conv.r8
    IL_0008: pop
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    public virtual void get_Count() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D8
    IL_0006: conv.r8
    IL_0007: IL_24
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ret
    }

    public virtual void Add() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D8
    IL_0006: ldarg.2
    IL_0007: conv.r8
    IL_0008: pop
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    public virtual void Remove() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D8
    IL_000E: conv.r8
    IL_000F: IL_24
    IL_0010: ldarg.0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0014: ldarg.0
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldnull
    IL_0019: ret
    IL_001A: ldarg.0
    IL_001F: ldfld 0x040008D8
    IL_0020: ldarg.1
    IL_0021: conv.r8
    IL_0022: dup
    IL_0023: ldarg.0
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040008D8
    IL_002D: ldarg.1
    IL_002E: conv.r8
    IL_0033: call 0x060A0002
    IL_0034: ret
    }

    public virtual void Remove() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D8
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_29
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: pop
    IL_000D: ldarg.1
    IL_000E: ret
    }

    public virtual void get_Childs() {
    IL_0004: newobj 0x06000783
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001066
    IL_000D: ldloc.0
    IL_000E: dup
    IL_0010: ldc.i4.s -2
    IL_0015: stfld 0x04001064
    IL_0016: ret
    }

    public virtual void GetEnumerator() {
    IL_0004: newobj 0x0600078B
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x0400106B
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022D0B
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008D8
    IL_000C: conv.r8
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: stloc.2
    IL_0016: br IL_0044
    IL_0018: ldloca.s 2
    IL_001D: call 0x0A00022B
    IL_001E: stloc.1
    IL_001F: ldloc.0
    IL_0020: conv.r8
    IL_0021: ldelem.i1
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldc.i4.2
    IL_0026: IL_3E
    IL_0027: stloc.2
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldloc.0
    IL_0030: ldstr 0x70022D11
    IL_0035: call 0x0A000011
    IL_0036: stloc.0
    IL_0037: ldloc.0
    IL_0038: ldloc.1
    IL_0039: conv.r8
    IL_003A: localloc
    IL_003B: ldarg.2
    IL_003C: nop
    IL_003D: ldloc.0
    IL_0042: call 0x0A000011
    IL_0043: stloc.0
    IL_0045: ldloca.s 2
    IL_004A: call 0x0A00022C
    IL_004F: brtrue IL_0017
    IL_0050: IL_DD
    IL_0051: stloc.2
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldloc.2
    IL_005A: newobj 0x1B00000D
    IL_005B: conv.r8
    IL_005C: ldelem.ref
    IL_005D: nop
    IL_005E: nop
    IL_005F: stloc.0
    IL_0060: IL_DC
    IL_0061: ldloc.0
    IL_0066: ldstr 0x70022D17
    IL_006B: call 0x0A000011
    IL_006C: stloc.0
    IL_006D: ldloc.0
    IL_006E: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022D0B
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008D8
    IL_000C: conv.r8
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: stloc.2
    IL_0016: br IL_0061
    IL_0018: ldloca.s 2
    IL_001D: call 0x0A00022B
    IL_001E: stloc.1
    IL_001F: ldloc.0
    IL_0020: conv.r8
    IL_0021: ldelem.i1
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldc.i4.3
    IL_0026: IL_3E
    IL_0027: stloc.2
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldloc.0
    IL_0030: ldstr 0x70022D11
    IL_0035: call 0x0A000011
    IL_0036: stloc.0
    IL_0037: ldloc.0
    IL_003C: ldstr 0x700229C4
    IL_003D: ldarg.1
    IL_0042: ldstr 0x700029FD
    IL_0047: call 0x0A0001EE
    IL_0048: stloc.0
    IL_0049: ldloc.0
    IL_004A: ldloc.1
    IL_004B: ldarg.1
    IL_0050: ldstr 0x700029FD
    IL_0055: call 0x0A000011
    IL_0056: conv.r8
    IL_0057: IL_4C
    IL_0058: ldarg.2
    IL_0059: nop
    IL_005A: ldloc.0
    IL_005F: call 0x0A000011
    IL_0060: stloc.0
    IL_0062: ldloca.s 2
    IL_0067: call 0x0A00022C
    IL_006C: brtrue IL_0017
    IL_006D: IL_DD
    IL_006E: stloc.2
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldloc.2
    IL_0077: newobj 0x1B00000D
    IL_0078: conv.r8
    IL_0079: ldelem.ref
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: IL_DC
    IL_007E: ldloc.0
    IL_0083: ldstr 0x700229C4
    IL_0084: ldarg.1
    IL_0089: ldstr 0x70022D1D
    IL_008E: call 0x0A0001EE
    IL_008F: stloc.0
    IL_0090: ldloc.0
    IL_0091: ret
    }

    public virtual void Serialize() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: conv.r8
    IL_0004: brtrue.s IL_0007
    IL_0005: nop
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D8
    IL_000E: conv.r8
    IL_000F: IL_24
    IL_0010: ldarg.0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: conv.r8
    IL_0015: beq.s IL_0018
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldc.i4.0
    IL_0019: stloc.0
    IL_001E: br IL_0035
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040008D8
    IL_0025: ldloc.0
    IL_0026: conv.r8
    IL_0027: dup
    IL_0028: ldarg.0
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.1
    IL_002C: conv.r8
    IL_002D: add
    IL_002E: ldarg.2
    IL_002F: nop
    IL_0030: ldloc.0
    IL_0031: ldloc.0
    IL_0032: ldc.i4.1
    IL_0033: IL_58
    IL_0034: stloc.0
    IL_0035: ldloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x040008D8
    IL_003C: conv.r8
    IL_003D: IL_24
    IL_003E: ldarg.0
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: IL_3F
    IL_0042: IL_D9
    IL_0043: IL_FF
    IL_0044: IL_FF
    IL_0045: IL_FF
    IL_0046: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x0A00022F
    IL_000A: stfld 0x040008D9
    IL_000B: ldarg.0
    IL_0010: call 0x0600043C
    IL_0011: ret
    }

    public virtual void get_Item() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0009: ble.s IL_000C
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: brfalse IL_001E
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040008D9
    IL_0017: ldarg.1
    IL_0018: conv.r8
    IL_001A: blt.s IL_001D
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ret
    IL_001E: ldarg.0
    IL_001F: ldarg.1
    IL_0024: newobj 0x06000497
    IL_0025: ret
    }

    public virtual void set_Item() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0009: ble.s IL_000C
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: brfalse IL_0023
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040008D9
    IL_0017: ldarg.1
    IL_0018: ldarg.2
    IL_0019: conv.r8
    IL_001B: bne.un.s IL_001E
    IL_001C: nop
    IL_001D: stloc.0
    IL_0022: br IL_0030
    IL_0023: ldarg.0
    IL_0028: ldfld 0x040008D9
    IL_0029: ldarg.1
    IL_002A: ldarg.2
    IL_002B: conv.r8
    IL_002C: IL_34
    IL_002D: ldarg.0
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ret
    }

    public void hasKey() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0009: ble.s IL_000C
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    public virtual void get_Item() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0014: ldarg.0
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldnull
    IL_0019: ret
    IL_001A: ldarg.0
    IL_001F: ldfld 0x040008D9
    IL_0020: ldarg.1
    IL_0025: call 0x2B000061
    IL_0026: stloc.0
    IL_0028: ldloca.s 0
    IL_002D: call 0x0A000236
    IL_002E: ret
    }

    public virtual void set_Item() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0014: IL_01
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ret
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040008D9
    IL_001F: ldarg.1
    IL_0024: call 0x2B000061
    IL_0025: stloc.1
    IL_0027: ldloca.s 1
    IL_002C: call 0x0A000237
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040008D9
    IL_0034: ldloc.0
    IL_0035: ldarg.2
    IL_0036: conv.r8
    IL_0038: bne.un.s IL_003B
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ret
    }

    public virtual void get_Count() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: conv.r8
    IL_0008: bgt.s IL_000B
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ret
    }

    public void key() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0014: ldarg.0
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldnull
    IL_0019: ret
    IL_001A: ldarg.0
    IL_001F: ldfld 0x040008D9
    IL_0020: ldarg.1
    IL_0025: call 0x2B000061
    IL_0026: stloc.0
    IL_0028: ldloca.s 0
    IL_002D: call 0x0A000237
    IL_002E: ret
    }

    public virtual void Add() {
    IL_0000: ldarg.1
    IL_0005: call 0x0A00020C
    IL_000A: brtrue IL_0040
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040008D9
    IL_0011: ldarg.1
    IL_0012: conv.r8
    IL_0014: ble.s IL_0017
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: brfalse IL_002E
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040008D9
    IL_0022: ldarg.1
    IL_0023: ldarg.2
    IL_0024: conv.r8
    IL_0026: bne.un.s IL_0029
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: br IL_003B
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040008D9
    IL_0034: ldarg.1
    IL_0035: ldarg.2
    IL_0036: conv.r8
    IL_0037: IL_34
    IL_0038: ldarg.0
    IL_0039: nop
    IL_003A: stloc.0
    IL_003F: br IL_0059
    IL_0040: ldarg.0
    IL_0045: ldfld 0x040008D9
    IL_004A: call 0x0A000238
    IL_004B: stloc.0
    IL_004D: ldloca.s 0
    IL_0052: call 0x0A000239
    IL_0053: ldarg.2
    IL_0054: conv.r8
    IL_0055: IL_34
    IL_0056: ldarg.0
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ret
    }

    public virtual void Remove() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008D9
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0009: ble.s IL_000C
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: brtrue IL_0013
    IL_0011: ldnull
    IL_0012: ret
    IL_0013: ldarg.0
    IL_0018: ldfld 0x040008D9
    IL_0019: ldarg.1
    IL_001A: conv.r8
    IL_001C: blt.s IL_001F
    IL_001D: nop
    IL_001E: stloc.0
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0025: ldfld 0x040008D9
    IL_0026: ldarg.1
    IL_0027: conv.r8
    IL_002C: brtrue IL_260A002F
    IL_002D: ldloc.0
    IL_002E: ret
    }

    public virtual void Remove() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: IL_3F
    IL_0004: ldloc.s 0
    IL_0005: nop
    IL_0006: nop
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: IL_3F
    IL_0014: ldarg.0
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldnull
    IL_0019: ret
    IL_001A: ldarg.0
    IL_001F: ldfld 0x040008D9
    IL_0020: ldarg.1
    IL_0025: call 0x2B000061
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040008D9
    IL_002E: ldloca.s 0
    IL_0033: call 0x0A000237
    IL_0034: conv.r8
    IL_0039: brtrue IL_260A003C
    IL_003B: ldloca.s 0
    IL_0040: call 0x0A000236
    IL_0041: ret
    }

    public virtual void Remove() {
    IL_0004: newobj 0x060007DC
    IL_0005: stloc.1
    IL_0006: ldloc.1
    IL_0007: ldarg.1
    IL_000C: stfld 0x040010D3
    IL_000D: ldarg.0
    IL_0012: ldfld 0x040008D9
    IL_0013: ldloc.1
    IL_0015: 0xFE 06
    IL_0016: IL_DD
    IL_0017: ldloc.1
    IL_0018: nop
    IL_0019: ldloc.0
    IL_001E: newobj 0x0A00023B
    IL_0023: call 0x2B000062
    IL_0028: call 0x2B000063
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040008D9
    IL_0031: ldloca.s 0
    IL_0036: call 0x0A000237
    IL_0037: conv.r8
    IL_003C: brtrue IL_260A003F
    IL_003D: ldloc.1
    IL_0042: ldfld 0x040010D3
    IL_0043: stloc.2
    IL_0044: IL_DD
    IL_0046: ldloca.s 0
    IL_0047: nop
    IL_0048: nop
    IL_0049: IL_DD
    IL_004A: stloc.3
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: pop
    IL_004F: ldnull
    IL_0050: stloc.2
    IL_0051: IL_DD
    IL_0052: ldarg.3
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: IL_DD
    IL_0057: nop
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: ldloc.2
    IL_005C: ret
    }

    public virtual void get_Childs() {
    IL_0004: newobj 0x06000791
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001070
    IL_000D: ldloc.0
    IL_000E: dup
    IL_0010: ldc.i4.s -2
    IL_0015: stfld 0x0400106E
    IL_0016: ret
    }

    public virtual void GetEnumerator() {
    IL_0004: newobj 0x06000799
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001075
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022D21
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008D9
    IL_000C: conv.r8
    IL_000D: IL_3E
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: stloc.2
    IL_0016: br IL_0077
    IL_0018: ldloca.s 2
    IL_001D: call 0x0A00023F
    IL_001E: stloc.1
    IL_001F: ldloc.0
    IL_0020: conv.r8
    IL_0021: ldelem.i1
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldc.i4.2
    IL_0026: IL_3E
    IL_0027: stloc.2
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldloc.0
    IL_0030: ldstr 0x70022D11
    IL_0035: call 0x0A000011
    IL_0036: stloc.0
    IL_0037: ldloc.0
    IL_0038: stloc.3
    IL_0039: ldc.i4.5
    IL_003E: newarr 0x0100000C
    IL_003F: dup
    IL_0040: ldc.i4.0
    IL_0041: ldloc.3
    IL_0046: stelem 0x25721725
    IL_0048: brtrue.s IL_004B
    IL_004D: cpobj 0x121825A2
    IL_004E: IL_01
    IL_0053: call 0x0A000237
    IL_0058: call 0x06000459
    IL_005D: stelem 0x29721925
    IL_005F: brtrue.s IL_0062
    IL_0064: cpobj 0x121A25A2
    IL_0065: IL_01
    IL_006A: call 0x0A000236
    IL_006B: conv.r8
    IL_006C: localloc
    IL_006D: ldarg.2
    IL_006E: nop
    IL_006F: ldloc.0
    IL_0074: stelem 0x00024028
    IL_0075: stloc.0
    IL_0076: stloc.0
    IL_0078: ldloca.s 2
    IL_007D: call 0x0A000241
    IL_0082: brtrue IL_0017
    IL_0083: IL_DD
    IL_0084: stloc.2
    IL_0085: nop
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldloc.2
    IL_008D: newobj 0x1B000011
    IL_008E: conv.r8
    IL_008F: ldelem.ref
    IL_0090: nop
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: IL_DC
    IL_0094: ldloc.0
    IL_0099: ldstr 0x70000503
    IL_009E: call 0x0A000011
    IL_009F: stloc.0
    IL_00A0: ldloc.0
    IL_00A1: ret
    }

    public virtual void ToString() {
    IL_0004: ldstr 0x70022D2F
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x040008D9
    IL_000C: conv.r8
    IL_000D: IL_3E
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: stloc.2
    IL_0016: br IL_0094
    IL_0018: ldloca.s 2
    IL_001D: call 0x0A00023F
    IL_001E: stloc.1
    IL_001F: ldloc.0
    IL_0020: conv.r8
    IL_0021: ldelem.i1
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldc.i4.3
    IL_0026: IL_3E
    IL_0027: stloc.2
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldloc.0
    IL_0030: ldstr 0x70022D11
    IL_0035: call 0x0A000011
    IL_0036: stloc.0
    IL_0037: ldloc.0
    IL_003C: ldstr 0x700229C4
    IL_003D: ldarg.1
    IL_0042: ldstr 0x700029FD
    IL_0047: call 0x0A0001EE
    IL_0048: stloc.0
    IL_0049: ldloc.0
    IL_004A: stloc.3
    IL_004B: ldc.i4.5
    IL_0050: newarr 0x0100000C
    IL_0051: dup
    IL_0052: ldc.i4.0
    IL_0053: ldloc.3
    IL_0058: stelem 0x25721725
    IL_005A: brtrue.s IL_005D
    IL_005F: cpobj 0x121825A2
    IL_0060: IL_01
    IL_0065: call 0x0A000237
    IL_006A: call 0x06000459
    IL_006F: stelem 0x35721925
    IL_0071: brtrue.s IL_0074
    IL_0076: cpobj 0x121A25A2
    IL_0077: IL_01
    IL_007C: call 0x0A000236
    IL_007D: ldarg.1
    IL_0082: ldstr 0x700029FD
    IL_0087: call 0x0A000011
    IL_0088: conv.r8
    IL_0089: IL_4C
    IL_008A: ldarg.2
    IL_008B: nop
    IL_008C: ldloc.0
    IL_0091: stelem 0x00024028
    IL_0092: stloc.0
    IL_0093: stloc.0
    IL_0095: ldloca.s 2
    IL_009A: call 0x0A000241
    IL_009F: brtrue IL_0017
    IL_00A0: IL_DD
    IL_00A1: stloc.2
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: ldloc.2
    IL_00AA: newobj 0x1B000011
    IL_00AB: conv.r8
    IL_00AC: ldelem.ref
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B0: IL_DC
    IL_00B1: ldloc.0
    IL_00B6: ldstr 0x700229C4
    IL_00B7: ldarg.1
    IL_00BC: ldstr 0x70000503
    IL_00C1: call 0x0A0001EE
    IL_00C2: stloc.0
    IL_00C3: ldloc.0
    IL_00C4: ret
    }

    public virtual void Serialize() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.2
    IL_0002: conv.r8
    IL_0004: brtrue.s IL_0007
    IL_0005: nop
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldarg.0
    IL_000D: ldfld 0x040008D9
    IL_000E: conv.r8
    IL_0010: bgt.s IL_0013
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: conv.r8
    IL_0015: beq.s IL_0018
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_001D: ldfld 0x040008D9
    IL_001E: conv.r8
    IL_001F: IL_42
    IL_0020: ldarg.0
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: conv.r8
    IL_0024: IL_43
    IL_0025: ldarg.0
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: stloc.1
    IL_002D: br IL_004F
    IL_002F: ldloca.s 1
    IL_0034: call 0x0A000244
    IL_0035: stloc.0
    IL_0036: ldarg.1
    IL_0037: ldloc.0
    IL_0038: conv.r8
    IL_003B: ldarg 2
    IL_003C: stloc.0
    IL_003D: ldarg.0
    IL_0042: ldfld 0x040008D9
    IL_0043: ldloc.0
    IL_0044: conv.r8
    IL_0046: blt.s IL_0049
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.1
    IL_004A: conv.r8
    IL_004B: add
    IL_004C: ldarg.2
    IL_004D: nop
    IL_004E: ldloc.0
    IL_0050: ldloca.s 1
    IL_0055: call 0x0A000246
    IL_005A: brtrue IL_002E
    IL_005B: IL_DD
    IL_005C: stloc.2
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldloc.1
    IL_0065: newobj 0x1B000013
    IL_0066: conv.r8
    IL_0067: ldelem.ref
    IL_0068: nop
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: IL_DC
    IL_006C: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x040008DA
    IL_000D: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_0009: IL_50
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_0009: IL_52
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_0009: IL_54
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_0009: IL_4E
    IL_000A: ldarg.2
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ret
    }

    public virtual void get_Value() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008DA
    IL_0006: ret
    }

    public virtual void set_Value() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x040008DA
    IL_0007: ret
    }

    public virtual void ToString() {
    IL_0000: ldarg.0
    IL_0005: ldsfld 0x0A000099
    IL_0006: conv.r8
    IL_0007: IL_94
    IL_0008: ldarg.2
    IL_0009: nop
    IL_000A: ldloc.0
    IL_000B: ret
    }

    public virtual void ToString() {
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040008DA
    IL_000B: call 0x06000459
    IL_000C: ldarg.1
    IL_0011: call 0x0A0000ED
    IL_0012: ret
    }

    public virtual void Serialize() {
    IL_0004: ldsfld 0x0A000099
    IL_0009: newobj 0x0600048C
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: conv.r8
    IL_000E: IL_4D
    IL_000F: ldarg.2
    IL_0010: nop
    IL_0011: ldloc.0
    IL_0012: conv.r8
    IL_0013: IL_4E
    IL_0014: ldarg.2
    IL_0015: nop
    IL_0016: ldloc.0
    IL_0017: ldloc.0
    IL_001C: ldfld 0x040008DA
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040008DA
    IL_0027: call 0x0A0000EC
    IL_002C: brfalse IL_0041
    IL_002D: ldarg.1
    IL_002E: ldc.i4.4
    IL_002F: conv.r8
    IL_0031: brtrue.s IL_0034
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.1
    IL_0035: ldarg.0
    IL_0036: conv.r8
    IL_0037: IL_4D
    IL_0038: ldarg.2
    IL_0039: nop
    IL_003A: ldloc.0
    IL_003B: conv.r8
    IL_003D: beq.s IL_0040
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ret
    IL_0041: ldloc.0
    IL_0042: ldarg.0
    IL_0043: conv.r8
    IL_0044: IL_4F
    IL_0045: ldarg.2
    IL_0046: nop
    IL_0047: ldloc.0
    IL_0048: conv.r8
    IL_0049: IL_50
    IL_004A: ldarg.2
    IL_004B: nop
    IL_004C: ldloc.0
    IL_004D: ldloc.0
    IL_0052: ldfld 0x040008DA
    IL_0053: ldarg.0
    IL_0058: ldfld 0x040008DA
    IL_005D: call 0x0A0000EC
    IL_0062: brfalse IL_0077
    IL_0063: ldarg.1
    IL_0064: ldc.i4.7
    IL_0065: conv.r8
    IL_0067: brtrue.s IL_006A
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: ldarg.1
    IL_006B: ldarg.0
    IL_006C: conv.r8
    IL_006D: IL_4F
    IL_006E: ldarg.2
    IL_006F: nop
    IL_0070: ldloc.0
    IL_0071: conv.r8
    IL_0074: starg 2
    IL_0075: stloc.0
    IL_0076: ret
    IL_0077: ldloc.0
    IL_0078: ldarg.0
    IL_0079: conv.r8
    IL_007A: IL_51
    IL_007B: ldarg.2
    IL_007C: nop
    IL_007D: ldloc.0
    IL_007E: conv.r8
    IL_007F: IL_52
    IL_0080: ldarg.2
    IL_0081: nop
    IL_0082: ldloc.0
    IL_0083: ldloc.0
    IL_0088: ldfld 0x040008DA
    IL_0089: ldarg.0
    IL_008E: ldfld 0x040008DA
    IL_0093: call 0x0A0000EC
    IL_0098: brfalse IL_00AD
    IL_0099: ldarg.1
    IL_009A: ldc.i4.5
    IL_009B: conv.r8
    IL_009D: brtrue.s IL_00A0
    IL_009E: nop
    IL_009F: stloc.0
    IL_00A0: ldarg.1
    IL_00A1: ldarg.0
    IL_00A2: conv.r8
    IL_00A3: IL_51
    IL_00A4: ldarg.2
    IL_00A5: nop
    IL_00A6: ldloc.0
    IL_00A7: conv.r8
    IL_00AA: ldloc 2
    IL_00AB: stloc.0
    IL_00AC: ret
    IL_00AD: ldloc.0
    IL_00AE: ldarg.0
    IL_00AF: conv.r8
    IL_00B0: IL_53
    IL_00B1: ldarg.2
    IL_00B2: nop
    IL_00B3: ldloc.0
    IL_00B4: conv.r8
    IL_00B5: IL_54
    IL_00B6: ldarg.2
    IL_00B7: nop
    IL_00B8: ldloc.0
    IL_00B9: ldloc.0
    IL_00BE: ldfld 0x040008DA
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x040008DA
    IL_00C9: call 0x0A0000EC
    IL_00CE: brfalse IL_00E3
    IL_00CF: ldarg.1
    IL_00D0: ldc.i4.6
    IL_00D1: conv.r8
    IL_00D3: brtrue.s IL_00D6
    IL_00D4: nop
    IL_00D5: stloc.0
    IL_00D6: ldarg.1
    IL_00D7: ldarg.0
    IL_00D8: conv.r8
    IL_00D9: IL_53
    IL_00DA: ldarg.2
    IL_00DB: nop
    IL_00DC: ldloc.0
    IL_00DD: conv.r8
    IL_00E0: ldloca 2
    IL_00E1: stloc.0
    IL_00E2: ret
    IL_00E3: ldarg.1
    IL_00E4: ldc.i4.3
    IL_00E5: conv.r8
    IL_00E7: brtrue.s IL_00EA
    IL_00E8: nop
    IL_00E9: stloc.0
    IL_00EA: ldarg.1
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x040008DA
    IL_00F1: conv.r8
    IL_00F4: ldarg 2
    IL_00F5: stloc.0
    IL_00F6: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x040008DB
    IL_000D: ldarg.0
    IL_000E: ldnull
    IL_0013: stfld 0x040008DC
    IL_0014: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600043C
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x040008DB
    IL_000D: ldarg.0
    IL_000E: ldarg.2
    IL_0013: stfld 0x040008DC
    IL_0014: ret
    }

    private void Set() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008DC
    IL_000A: brtrue IL_001C
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040008DB
    IL_0011: ldarg.1
    IL_0012: conv.r8
    IL_0015: ldarg 4
    IL_0016: ldloc.0
    IL_001B: br IL_002E
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040008DB
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040008DC
    IL_0028: ldarg.1
    IL_0029: conv.r8
    IL_002A: IL_3D
    IL_002B: ldarg.2
    IL_002C: nop
    IL_002D: ldloc.0
    IL_002E: ldarg.0
    IL_002F: ldnull
    IL_0034: stfld 0x040008DB
    IL_0035: ret
    }

    public virtual void get_Item() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x06000496
    IL_0006: ret
    }

    public virtual void set_Item() {
    IL_0004: newobj 0x0600046D
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.2
    IL_0008: conv.r8
    IL_000B: ldarg 4
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: ldloc.0
    IL_0013: call 0x06000498
    IL_0014: ret
    }

    public virtual void get_Item() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: newobj 0x06000497
    IL_0007: ret
    }

    public virtual void set_Item() {
    IL_0004: newobj 0x0600047B
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: conv.r8
    IL_000A: IL_83
    IL_000B: ldarg.2
    IL_000C: nop
    IL_000D: ldloc.0
    IL_000E: ldarg.0
    IL_000F: ldloc.0
    IL_0014: call 0x06000498
    IL_0015: ret
    }

    public virtual void Add() {
    IL_0004: newobj 0x0600046D
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_0008: conv.r8
    IL_000B: ldarg 4
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: ldloc.0
    IL_0013: call 0x06000498
    IL_0014: ret
    }

    public virtual void Add() {
    IL_0004: newobj 0x0600047B
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: conv.r8
    IL_000A: IL_83
    IL_000B: ldarg.2
    IL_000C: nop
    IL_000D: ldloc.0
    IL_000E: ldarg.0
    IL_000F: ldloc.0
    IL_0014: call 0x06000498
    IL_0015: ret
    }

    public virtual void Equals() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0008
    IL_0006: ldc.i4.1
    IL_0007: ret
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000E: call 0x0A000205
    IL_000F: ret
    }

    public virtual void GetHashCode() {
    IL_0000: ldarg.0
    IL_0005: call 0x06000458
    IL_0006: ret
    }

    public virtual void ToString() {
    IL_0004: ldsfld 0x0A000099
    IL_0005: ret
    }

    public virtual void ToString() {
    IL_0004: ldsfld 0x0A000099
    IL_0005: ret
    }

    public virtual void get_AsInt() {
    IL_0000: ldc.i4.0
    IL_0005: newobj 0x06000490
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldloc.0
    IL_000D: call 0x06000498
    IL_000E: ldc.i4.0
    IL_000F: ret
    }

    public virtual void set_AsInt() {
    IL_0000: ldarg.1
    IL_0005: newobj 0x06000490
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldloc.0
    IL_000D: call 0x06000498
    IL_000E: ret
    }

    public virtual void get_AsFloat() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0009: newobj 0x0600048D
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_000C: ldloc.0
    IL_0011: call 0x06000498
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: ret
    }

    public virtual void set_AsFloat() {
    IL_0000: ldarg.1
    IL_0005: newobj 0x0600048D
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldloc.0
    IL_000D: call 0x06000498
    IL_000E: ret
    }

    public virtual void get_AsDouble() {
    IL_0000: IL_23
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_0006: nop
    IL_0007: nop
    IL_0008: nop
    IL_000D: newobj 0x0600048E
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldloc.0
    IL_0015: call 0x06000498
    IL_0016: IL_23
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: ret
    }

    public virtual void set_AsDouble() {
    IL_0000: ldarg.1
    IL_0005: newobj 0x0600048E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldloc.0
    IL_000D: call 0x06000498
    IL_000E: ret
    }

    public virtual void get_AsBool() {
    IL_0000: ldc.i4.0
    IL_0005: newobj 0x0600048F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldloc.0
    IL_000D: call 0x06000498
    IL_000E: ldc.i4.0
    IL_000F: ret
    }

    public virtual void set_AsBool() {
    IL_0000: ldarg.1
    IL_0005: newobj 0x0600048F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldloc.0
    IL_000D: call 0x06000498
    IL_000E: ret
    }

    public virtual void get_AsArray() {
    IL_0004: newobj 0x0600046D
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_0007: ldloc.0
    IL_000C: call 0x06000498
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public virtual void get_AsObject() {
    IL_0004: newobj 0x0600047B
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_0007: ldloc.0
    IL_000C: call 0x06000498
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public static void op_Equality() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0008
    IL_0006: ldc.i4.1
    IL_0007: ret
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000E: call 0x0A000205
    IL_000F: ret
    }

    public static void op_Inequality() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x060004AD
    IL_0007: ldc.i4.0
    IL_0009: ceq
    IL_000A: ret
    }

    public static void Parse() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600045A
    IL_0006: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A0000B0
    IL_000B: stfld 0x040008DD
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000002
    IL_0017: stfld 0x040008DE
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A000003
    IL_0023: stfld 0x040008E3
    IL_0024: ldarg.0
    IL_0025: ldarg.0
    IL_002A: ldfld 0x040008DE
    IL_002B: ldc.i4.0
    IL_002C: conv.r8
    IL_0031: brtrue IL_7D0A0032
    IL_0032: IL_DF
    IL_0033: ldloc.2
    IL_0034: nop
    IL_0035: ldarg.2
    IL_0036: ldarg.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x040008DF
    IL_003D: conv.r8
    IL_003E: ldarg.1
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: conv.u8
    IL_0043: IL_35
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_01
    IL_004B: stfld 0x040008E2
    IL_004C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008DF
    IL_0006: conv.r8
    IL_0007: IL_3D
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: call 0x0A00003D
    IL_0011: conv.r8
    IL_0014: ldarga 0
    IL_0015: stloc.0
    IL_0016: conv.r8
    IL_0017: IL_84
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040008DF
    IL_0021: conv.r8
    IL_0022: stloc.0
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldc.i4.0
    IL_0027: conv.r8
    IL_0028: stloc.1
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_002C: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008DD
    IL_0006: conv.r8
    IL_0007: IL_BA
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040008E3
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0014: ldc.i4.s 0
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040008DD
    IL_001D: ldc.i4.1
    IL_001E: conv.r8
    IL_001F: IL_B6
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: ldarg.0
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_002D: stfld 0x040008E0
    IL_002E: ldarg.0
    IL_0033: ldstr 0x70022980
    IL_0034: IL_22
    IL_0035: IL_CD
    IL_0036: IL_CC
    IL_0037: IL_CC
    IL_0038: IL_3D
    IL_0039: IL_22
    IL_003A: IL_CD
    IL_003B: IL_CC
    IL_003C: IL_CC
    IL_003D: IL_3E
    IL_0042: call 0x0A000017
    IL_0043: ldarg.0
    IL_0044: ldc.i4.0
    IL_0049: stfld 0x040008E1
    IL_004A: ldarg.0
    IL_004F: call 0x0A00002B
    IL_0050: conv.r8
    IL_0051: IL_4D
    IL_0052: nop
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: ret
    }

    private void RepeatDamage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008E3
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008E3
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040008E0
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040008E0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008DE
    IL_0018: conv.r8
    IL_0019: ldc.i4.2
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: stloc.0
    IL_001F: ldloca.s 0
    IL_0024: ldfld 0x0A000023
    IL_0025: IL_22
    IL_0026: IL_CD
    IL_0027: IL_CC
    IL_0028: IL_CC
    IL_0029: IL_3D
    IL_002A: IL_41
    IL_002C: bge.s IL_002D
    IL_002D: nop
    IL_002E: nop
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040008DE
    IL_0035: dup
    IL_0036: conv.r8
    IL_0037: ldc.i4.2
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003F: call 0x0A000007
    IL_0040: IL_22
    IL_0041: ldelem.i
    IL_0042: IL_99
    IL_0043: ldc.i4.3
    IL_0044: IL_3F
    IL_0049: call 0x0A000008
    IL_004E: call 0x0A000024
    IL_0053: call 0x0A000008
    IL_0058: call 0x0A000029
    IL_0059: conv.r8
    IL_005A: ldloc.3
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040008E1
    IL_0064: ldc.i4.2
    IL_01B5: switch (83 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x0000223F
    IL_000D: stsfld 0xCCCD223F
    IL_000E: IL_CC
    IL_000F: IL_3D
    IL_0014: newobj 0x0A000076
    IL_0019: stfld 0x040008E8
    IL_001A: ldarg.0
    IL_001F: call 0x0A000001
    IL_0020: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008E5
    IL_000C: ldarg.0
    IL_0011: call 0x0A00002A
    IL_0016: ldstr 0x70022D3F
    IL_0017: conv.r8
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_22
    IL_001D: ldelem.i
    IL_001E: IL_99
    IL_001F: IL_99
    IL_0020: IL_3F
    IL_0021: conv.r8
    IL_0023: bgt.s IL_0024
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_002B: call 0x0A00002A
    IL_0030: ldstr 0x70022D49
    IL_0031: conv.r8
    IL_0033: bge.s IL_0034
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_003D: stsfld 0x00306F3E
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: call 0x0A00002A
    IL_004A: ldstr 0x70022D55
    IL_004B: conv.r8
    IL_004D: bge.s IL_004E
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x00306F3E
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005F: call 0x0A00002A
    IL_0064: ldstr 0x70022D65
    IL_0065: conv.r8
    IL_0067: bge.s IL_0068
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: IL_22
    IL_006B: IL_CD
    IL_006C: IL_CC
    IL_006D: IL_4C
    IL_006E: IL_3F
    IL_006F: conv.r8
    IL_0071: bgt.s IL_0072
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040008E4
    IL_007A: conv.r8
    IL_007B: stloc.0
    IL_007C: nop
    IL_007D: nop
    IL_007E: stloc.0
    IL_007F: ldc.i4.0
    IL_0080: conv.r8
    IL_0081: stloc.1
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0085: ldarg.0
    IL_0086: ldarg.0
    IL_008B: ldfld 0x040008E4
    IL_008C: conv.r8
    IL_008D: ldarg.1
    IL_008E: nop
    IL_008F: nop
    IL_0090: stloc.0
    IL_0091: conv.u4
    IL_0092: throw
    IL_0093: nop
    IL_0094: nop
    IL_0095: IL_01
    IL_009A: stfld 0x040008E7
    IL_009B: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008E4
    IL_0006: conv.r8
    IL_0007: IL_3D
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: call 0x0A00003D
    IL_0011: conv.r8
    IL_0014: ldarga 0
    IL_0015: stloc.0
    IL_0016: conv.r8
    IL_0017: IL_84
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008E5
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_C0
    IL_000F: IL_3F
    IL_0014: call 0x0A000008
    IL_0015: conv.r8
    IL_0016: IL_AF
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001B: ldc.i4.0
    IL_0020: stfld 0x040008E9
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040008E4
    IL_002B: call 0x0A00001B
    IL_002C: conv.r8
    IL_002D: IL_AF
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: ldarg.0
    IL_0032: IL_22
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_003B: stfld 0x040008E6
    IL_003C: ldarg.0
    IL_0041: ldfld 0x040008E7
    IL_0042: ldc.i4.0
    IL_0043: conv.r8
    IL_0045: ldc.i4.s 0
    IL_0046: nop
    IL_0047: stloc.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x040008E7
    IL_004E: IL_22
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: nop
    IL_0053: conv.r8
    IL_0056: stloc 2
    IL_0057: stloc.0
    IL_0058: ldarg.0
    IL_005D: ldstr 0x70022D6F
    IL_005E: IL_22
    IL_005F: IL_CD
    IL_0060: IL_CC
    IL_0061: IL_CC
    IL_0062: IL_3D
    IL_0063: IL_22
    IL_0064: IL_CD
    IL_0065: IL_CC
    IL_0066: IL_4C
    IL_0067: IL_3E
    IL_006C: call 0x0A000017
    IL_006D: ldarg.0
    IL_0072: ldfld 0x040008E4
    IL_0073: conv.r8
    IL_0074: stloc.0
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: ldc.i4.1
    IL_0079: conv.r8
    IL_007A: stloc.1
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: ldarg.0
    IL_0083: call 0x0A00002A
    IL_0088: ldstr 0x70022D3F
    IL_0089: conv.r8
    IL_008A: IL_3C
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: pop
    IL_008F: ret
    }

    public void Shoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008E6
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_3F
    IL_000B: IL_43
    IL_000C: ldc.i4.2
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040008E7
    IL_0016: ldc.i4.0
    IL_0017: conv.r8
    IL_0019: ldc.i4.s 0
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040008E7
    IL_0022: ldc.i4.1
    IL_0023: conv.r8
    IL_0025: ldc.i4.s 0
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040008E6
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040008E6
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008E6
    IL_0018: IL_22
    IL_0019: ldelem.i
    IL_001A: IL_99
    IL_001B: IL_59
    IL_F52C: switch (15683 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008EA
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040008EC
    IL_0018: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040008ED
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x040008EB
    IL_0012: ldarg.0
    IL_0017: ldstr 0x70022D6F
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_3F
    IL_001D: IL_22
    IL_001E: ldelem.i
    IL_001F: IL_99
    IL_0020: IL_99
    IL_0021: IL_3E
    IL_0026: call 0x0A000017
    IL_0027: ldarg.0
    IL_002C: call 0x0A0000B0
    IL_002D: ldc.i4.1
    IL_002E: conv.r8
    IL_002F: IL_B6
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040008EA
    IL_0039: ldc.i4.0
    IL_003A: conv.r8
    IL_003F: brtrue IL_6F0A0040
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
    IL_004F: ldfld 0x040008EC
    IL_0050: ldc.i4.0
    IL_0051: conv.r8
    IL_0053: ldc.i4.s 0
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ret
    }

    public void Shoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008EC
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008EC
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040008EB
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040008EB
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008EB
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_C0
    IL_A12C: switch (10307 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002A
    IL_0006: conv.r8
    IL_0007: IL_4C
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: pop
    IL_000C: ldarg.0
    IL_0011: call 0x0A000003
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70022D7B
    IL_001E: IL_22
    IL_001F: IL_CD
    IL_0020: IL_CC
    IL_0021: IL_CC
    IL_0022: IL_3E
    IL_0027: call 0x0A00003F
    IL_0028: ldarg.0
    IL_002D: ldstr 0x70022D9B
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_FCD6: switch (16168 cases)
    }

    private void ColliderDisable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000003
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    private void GameobjectDisable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_000E: IL_F0
    IL_000F: IL_41
    IL_0014: call 0x0A000008
    IL_0015: conv.r8
    IL_0016: ldloc.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: call 0x0A00000A
    IL_0020: ldc.i4.0
    IL_0021: conv.r8
    IL_0022: stloc.1
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_002B: call 0x0A00002A
    IL_002C: conv.r8
    IL_002F: ldloc 0
    IL_0030: stloc.0
    IL_0031: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008EE
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040008F0
    IL_0018: ldarg.0
    IL_001D: call 0x0A00002A
    IL_0022: ldstr 0x70022DBF
    IL_0023: conv.r8
    IL_0025: bge.s IL_0026
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: IL_22
    IL_0029: IL_CD
    IL_002A: IL_CC
    IL_002B: IL_4C
    IL_002C: IL_3E
    IL_002D: conv.r8
    IL_002F: bgt.s IL_0030
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0037: call 0x0A00002A
    IL_003C: ldstr 0x70022D49
    IL_003D: conv.r8
    IL_003F: bge.s IL_0040
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: IL_22
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_3F
    IL_0047: conv.r8
    IL_0049: bgt.s IL_004A
    IL_004A: nop
    IL_004B: stloc.0
    IL_004C: ldarg.0
    IL_0051: call 0x0A00002A
    IL_0056: ldstr 0x70022D55
    IL_0057: conv.r8
    IL_0059: bge.s IL_005A
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: IL_22
    IL_005D: IL_CD
    IL_005E: IL_CC
    IL_005F: IL_CC
    IL_0060: IL_3E
    IL_0061: conv.r8
    IL_0063: bgt.s IL_0064
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ret
    }

    private void Start() {
    IL_0000: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040008F1
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x040008EF
    IL_0012: ldarg.0
    IL_0017: ldstr 0x70022D6F
    IL_0018: IL_22
    IL_0019: IL_CD
    IL_001A: IL_CC
    IL_001B: IL_4C
    IL_001C: IL_3F
    IL_001D: IL_22
    IL_001E: IL_CD
    IL_001F: IL_CC
    IL_0020: IL_4C
    IL_0021: IL_3E
    IL_0026: call 0x0A000017
    IL_0027: ldarg.0
    IL_002C: call 0x0A00002A
    IL_0031: ldstr 0x70022D49
    IL_0032: conv.r8
    IL_0033: IL_3C
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: pop
    IL_0038: ldarg.0
    IL_003D: ldfld 0x040008F2
    IL_003E: conv.r8
    IL_003F: IL_B0
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ldc.i4.0
    IL_0044: conv.r8
    IL_0045: IL_B6
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x040008F3
    IL_004F: conv.r8
    IL_0050: IL_B0
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: ldc.i4.0
    IL_0055: conv.r8
    IL_0056: IL_B6
    IL_0057: nop
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x040008F0
    IL_0060: ldc.i4.0
    IL_0061: conv.r8
    IL_0063: ldc.i4.s 0
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ret
    }

    public void Shoot() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008F0
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008F0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040008EF
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040008EF
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008EF
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001F: ldobj 0x00374340
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040008EE
    IL_0038: call 0x0A00004B
    IL_0039: IL_22
    IL_003A: nop
    IL_003B: nop
    IL_0040: ldc.i4 534594
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: conv.r8
    IL_0044: ldloc.3
    IL_0045: nop
    IL_0046: nop
    IL_0047: stloc.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x040008EE
    IL_004E: ldnull
    IL_004F: conv.r8
    IL_0050: IL_4E
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0058: br IL_010D
    IL_0059: ldarg.0
    IL_005E: ldfld 0x040008EF
    IL_005F: IL_22
    IL_0060: nop
    IL_0061: nop
    IL_0066: stsfld 0x004F4340
    IL_0067: nop
    IL_0068: nop
    IL_0069: ldarg.0
    IL_006E: ldfld 0x040008F2
    IL_006F: conv.r8
    IL_0070: IL_B0
    IL_0071: nop
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldc.i4.0
    IL_0075: conv.r8
    IL_0076: IL_B6
    IL_0077: nop
    IL_0078: nop
    IL_0079: stloc.0
    IL_007A: ldarg.0
    IL_007F: ldfld 0x040008F3
    IL_0080: conv.r8
    IL_0081: IL_B0
    IL_0082: nop
    IL_0083: nop
    IL_0084: stloc.0
    IL_0085: ldc.i4.0
    IL_0086: conv.r8
    IL_0087: IL_B6
    IL_0088: nop
    IL_0089: nop
    IL_008A: stloc.0
    IL_008B: ldarg.0
    IL_0090: call 0x0A00002A
    IL_0095: ldstr 0x70022D55
    IL_0096: conv.r8
    IL_0097: IL_3C
    IL_0098: nop
    IL_0099: nop
    IL_009A: stloc.0
    IL_009B: pop
    IL_009C: ldarg.0
    IL_00A1: ldstr 0x70022D6F
    IL_00A6: call 0x0A00007B
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x040008F0
    IL_00AD: ldc.i4.0
    IL_00AE: conv.r8
    IL_00B0: ldc.i4.s 0
    IL_00B1: nop
    IL_00B2: stloc.0
    IL_00B7: br IL_010D
    IL_00B8: ldarg.0
    IL_00BD: ldfld 0x040008EF
    IL_00BE: IL_22
    IL_00BF: ldelem.i
    IL_00C0: IL_99
    IL_00C1: ldc.i4.3
    IL_00C2: IL_3F
    IL_00C3: IL_43
    IL_00C6: ldarg 0
    IL_00C7: nop
    IL_00C8: ldarg.0
    IL_00CD: ldfld 0x040008F1
    IL_00D2: brtrue IL_010D
    IL_00D3: ldarg.0
    IL_00D4: ldc.i4.1
    IL_00D9: stfld 0x040008F1
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x040008F2
    IL_00E0: conv.r8
    IL_00E1: IL_B0
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: stloc.0
    IL_00E5: ldc.i4.1
    IL_00E6: conv.r8
    IL_00E7: IL_B6
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: stloc.0
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x040008F3
    IL_00F1: conv.r8
    IL_00F2: IL_B0
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: stloc.0
    IL_00F6: ldc.i4.1
    IL_00F7: conv.r8
    IL_00F8: IL_B6
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: stloc.0
    IL_00FC: ldarg.0
    IL_0101: call 0x0A00002A
    IL_0106: ldstr 0x70022DBF
    IL_0107: conv.r8
    IL_0108: IL_3C
    IL_0109: nop
    IL_010A: nop
    IL_010B: stloc.0
    IL_010C: pop
    IL_010D: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008F4
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040008F8
    IL_0018: ldarg.0
    IL_001D: ldstr 0x700229C8
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: xor
    IL_0025: nop
    IL_0026: nop
    IL_0028: br.s IL_00A6
    IL_0029: IL_FA
    IL_002A: ldloc.2
    IL_002B: nop
    IL_002C: ldarg.2
    IL_002D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008F4
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: brtrue IL_6F0A000D
    IL_000D: IL_B0
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldc.i4.1
    IL_0012: conv.r8
    IL_0013: IL_B6
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040008F4
    IL_001D: ldc.i4.1
    IL_001E: conv.r8
    IL_0023: brtrue IL_6F0A0024
    IL_0024: IL_B0
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_0028: ldc.i4.1
    IL_0029: conv.r8
    IL_002A: IL_B6
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_002F: ldc.i4.1
    IL_0034: stfld 0x040008F5
    IL_0035: ldarg.0
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003F: stfld 0x040008F9
    IL_0040: ldarg.0
    IL_0041: ldarg.0
    IL_0046: ldfld 0x040008F4
    IL_0047: conv.r8
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: stloc.0
    IL_0050: call 0x0A000007
    IL_0051: IL_22
    IL_0053: bne.un.s IL_0087
    IL_0055: bne.un.s IL_0095
    IL_005A: call 0x0A000008
    IL_005F: call 0x0A000019
    IL_0064: stfld 0x040008F7
    IL_0065: ldarg.0
    IL_006A: ldfld 0x040008F4
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040008F7
    IL_0075: call 0x0A000043
    IL_0076: conv.r8
    IL_0077: IL_CC
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldarg.0
    IL_007C: ldarg.0
    IL_0081: ldfld 0x040008F4
    IL_0082: conv.r8
    IL_0083: ldc.i4.2
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_008B: stfld 0x040008F6
    IL_008C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008F5
    IL_000A: brfalse IL_009B
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040008F4
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0024: pop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_0029: dup
    IL_002E: ldfld 0x040008F6
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040008F7
    IL_0035: IL_22
    IL_0036: stloc.0
    IL_0037: IL_D7
    IL_0038: stelem.i
    IL_0039: IL_3D
    IL_003E: call 0x0A000008
    IL_0043: call 0x0A000029
    IL_0048: stfld 0x040008F6
    IL_004D: br IL_0085
    IL_004E: ldarg.0
    IL_0053: ldfld 0x040008F8
    IL_0054: ldc.i4.1
    IL_0055: conv.r8
    IL_0057: ldc.i4.s 0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005B: ldc.i4.0
    IL_0060: stfld 0x040008F5
    IL_0061: ldarg.0
    IL_0066: ldflda 0x040008F6
    IL_0067: ldc.i4.1
    IL_0068: IL_22
    IL_0069: nop
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_0071: call 0x0A00001A
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040008FA
    IL_0078: ldc.i4.0
    IL_0079: ldarg.0
    IL_007E: ldfld 0x040008F6
    IL_007F: ldc.i4.1
    IL_0080: conv.r8
    IL_0081: ldind.ref
    IL_0082: ldarg.0
    IL_0083: nop
    IL_0084: ldloc.0
    IL_0085: ldarg.0
    IL_008A: ldfld 0x040008F4
    IL_008B: ldarg.0
    IL_0090: ldfld 0x040008F6
    IL_0091: conv.r8
    IL_0092: ldloc.3
    IL_0093: nop
    IL_0094: nop
    IL_0095: stloc.0
    IL_009A: br IL_0108
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x040008F9
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_12DB5: switch (19267 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008FB
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040008FD
    IL_0018: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x040008FC
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040008FB
    IL_0015: call 0x0A00001B
    IL_0016: conv.r8
    IL_0017: IL_AF
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040008FB
    IL_0021: ldc.i4.0
    IL_0022: conv.r8
    IL_0027: brtrue IL_6F0A0028
    IL_0028: stloc.0
    IL_0029: nop
    IL_002A: nop
    IL_002B: stloc.0
    IL_002C: ldc.i4.1
    IL_002D: conv.r8
    IL_002E: stloc.1
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040008FB
    IL_0038: ldc.i4.1
    IL_0039: conv.r8
    IL_003E: brtrue IL_6F0A003F
    IL_003F: stloc.0
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0043: ldc.i4.1
    IL_0044: conv.r8
    IL_0045: stloc.1
    IL_0046: nop
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ldarg.0
    IL_004E: call 0x0A0000B0
    IL_004F: ldc.i4.1
    IL_0050: conv.r8
    IL_0051: IL_B6
    IL_0052: nop
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: ldarg.0
    IL_005A: ldstr 0x70000AAD
    IL_005B: IL_22
    IL_005C: ldelem.i
    IL_005D: IL_99
    IL_005E: IL_99
    IL_005F: IL_3E
    IL_0060: IL_22
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: IL_3F
    IL_0069: call 0x0A000017
    IL_006A: ret
    }

    private void ColliderOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040008FD
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040008FD
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040008FC
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040008FC
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040008FC
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_41
    IL_001D: IL_43
    IL_0020: ldarg 0
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040008FB
    IL_0034: ldc.i4.0
    IL_0035: conv.r8
    IL_003A: brtrue IL_6F0A003B
    IL_003B: stloc.0
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldc.i4.0
    IL_0040: conv.r8
    IL_0041: stloc.1
    IL_0042: nop
    IL_0043: nop
    IL_0044: stloc.0
    IL_0045: ldarg.0
    IL_004A: ldfld 0x040008FB
    IL_004B: ldc.i4.1
    IL_004C: conv.r8
    IL_0051: brtrue IL_6F0A0052
    IL_0052: stloc.0
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldc.i4.0
    IL_0057: conv.r8
    IL_0058: stloc.1
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ldarg.0
    IL_0061: call 0x0A000081
    IL_0066: br IL_00DE
    IL_0067: ldarg.0
    IL_006C: ldfld 0x040008FC
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0070: IL_C0
    IL_F181: switch (15427 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040008FE
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000F: stfld 0x04000900
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000900
    IL_0017: conv.r8
    IL_0018: shl
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_009A
    IL_001D: IL_01
    IL_001E: ldloc.3
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0021: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000900
    IL_0007: conv.r8
    IL_0008: IL_FF
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: call 0x0A000061
    IL_0015: brfalse IL_0062
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040008FF
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040008FE
    IL_0022: conv.r8
    IL_0023: ldc.i4.2
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040008FE
    IL_002D: conv.r8
    IL_002E: pop
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0036: call 0x0A000014
    IL_0037: pop
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000901
    IL_003E: conv.r8
    IL_0043: castclass 0x02060001
    IL_0048: ldfld 0x040008FE
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_C0
    IL_0052: call 0x0A000042
    IL_0057: call 0x0A0000C2
    IL_0058: conv.r8
    IL_0059: ldloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_0061: br IL_00AF
    IL_0062: ldarg.1
    IL_0063: conv.r8
    IL_0064: stloc.0
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: conv.r8
    IL_0069: ldc.i4.8
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: ldc.i4.8
    IL_0162: switch (60 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: stloc.0
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A00005C
    IL_0013: IL_22
    IL_0014: ldelem.i
    IL_0015: IL_99
    IL_0016: ldc.i4.3
    IL_0017: IL_BF
    IL_0018: IL_43
    IL_0019: IL_34
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_0022: call 0x0A000002
    IL_0023: dup
    IL_0024: conv.r8
    IL_0025: ldc.i4.2
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: call 0x0A000042
    IL_002E: IL_22
    IL_002F: shr
    IL_0030: shr
    IL_0031: IL_E6
    IL_0032: IL_BF
    IL_0037: call 0x0A000008
    IL_003C: call 0x0A000024
    IL_0041: call 0x0A000008
    IL_0046: call 0x0A000029
    IL_0047: conv.r8
    IL_0048: ldloc.3
    IL_0049: nop
    IL_004A: nop
    IL_004B: stloc.0
    IL_0050: br IL_006B
    IL_0051: ldarg.0
    IL_0056: ldfld 0x040008FE
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: IL_C0
    IL_0060: call 0x0A000042
    IL_0065: call 0x0A0000C2
    IL_0066: conv.r8
    IL_0067: ldloc.3
    IL_0068: nop
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000902
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000F: stfld 0x04000903
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000903
    IL_0017: conv.r8
    IL_0018: shl
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_009A
    IL_001D: ldarg.2
    IL_001E: ldloc.3
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000902
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: ldc.i4.0
    IL_0031: ldc.i4 360
    IL_0036: call 0x0A000045
    IL_0037: conv.i2
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_0041: call 0x0A000060
    IL_0042: conv.r8
    IL_0047: call 0x2A0A0000
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000903
    IL_0007: conv.r8
    IL_0008: IL_FF
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: call 0x0A000061
    IL_0015: brfalse IL_003C
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000904
    IL_001C: ldc.i4.1
    IL_001D: conv.r8
    IL_001E: IL_A4
    IL_001F: IL_01
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000902
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_C0
    IL_0031: call 0x0A000042
    IL_0036: call 0x0A0000C2
    IL_0037: conv.r8
    IL_0038: ldloc.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_003C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: stloc.0
    IL_000D: ldloca.s 0
    IL_0012: ldfld 0x0A00005C
    IL_0013: IL_22
    IL_0014: ldelem.i
    IL_0015: IL_99
    IL_0016: ldc.i4.3
    IL_0017: IL_BF
    IL_0018: IL_43
    IL_0019: IL_58
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_0022: call 0x0A000002
    IL_0023: dup
    IL_0024: conv.r8
    IL_0025: ldc.i4.2
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: call 0x0A000042
    IL_002E: IL_22
    IL_002F: shr
    IL_0030: shr
    IL_0031: IL_E6
    IL_0032: IL_BF
    IL_0037: call 0x0A000008
    IL_003C: call 0x0A000024
    IL_0041: call 0x0A000008
    IL_0046: call 0x0A000029
    IL_0047: conv.r8
    IL_0048: ldloc.3
    IL_0049: nop
    IL_004A: nop
    IL_004B: stloc.0
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000902
    IL_0056: call 0x0A000007
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: IL_FA
    IL_005B: IL_43
    IL_0060: call 0x0A000008
    IL_0065: call 0x0A000024
    IL_006A: call 0x0A000008
    IL_006B: conv.r8
    IL_006C: IL_B5
    IL_006D: nop
    IL_006E: nop
    IL_006F: stloc.0
    IL_0074: br IL_008F
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000902
    IL_007B: IL_22
    IL_007C: nop
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_C0
    IL_0084: call 0x0A000042
    IL_0089: call 0x0A0000C2
    IL_008A: conv.r8
    IL_008B: ldloc.3
    IL_008C: nop
    IL_008D: nop
    IL_008E: stloc.0
    IL_008F: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x090B7D40
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000906
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000909
    IL_0018: ret
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
    IL_0014: stfld 0x04000905
    IL_0015: ldarg.0
    IL_001A: call 0x0A00000A
    IL_001B: ldc.i4.0
    IL_001C: conv.r8
    IL_001D: stloc.1
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000007
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_20AE: switch (2088 cases)
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000C: ldc.i4.s 15
    IL_0109: switch (62 cases)
    }

    public void Finish() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000906
    IL_0016: call 0x0A00004B
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldloc.2
    IL_001B: IL_42
    IL_0020: call 0x0A000008
    IL_0021: conv.r8
    IL_0022: ldloc.3
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400090B
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_41
    IL_000C: ldc.i4.0
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: call 0x060004E3
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001E: stsfld 0x090B7D40
    IL_001F: nop
    IL_0020: ldarg.2
    IL_0025: br IL_0059
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400090B
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_450533: switch (1130816 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100001E
    IL_000B: stfld 0x0400090C
    IL_000C: ldarg.0
    IL_0011: call 0x0A000001
    IL_0012: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A000090
    IL_0010: ldarg.0
    IL_0015: call 0x0A00002B
    IL_001A: ldstr 0x70022774
    IL_001F: call 0x0A0001C1
    IL_0020: conv.r8
    IL_0021: IL_C9
    IL_0022: IL_01
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ret
    }

    public void SoundOn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: brtrue IL_6F0A000D
    IL_000E: br.s IL_000F
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x0400090C
    IL_0017: ldarg.1
    IL_0018: ldelem.i
    IL_0019: conv.r8
    IL_001A: ldind.ref
    IL_001B: nop
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ret
    }

    public void SetBGM() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_C9
    IL_0009: IL_01
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ret
    }

    private void Update() {
    IL_0000: ret
    }

    public Shadow_eagle() {
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

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 10
    IL_0007: newarr 0x01000003
    IL_000C: stfld 0x04000918
    IL_000D: ldarg.0
    IL_000E: ldc.i4.8
    IL_0013: newarr 0x0100002F
    IL_0014: dup
    IL_0019: ldtoken 0x040010BE
    IL_001E: call 0x0A00018C
    IL_0023: stfld 0x04000919
    IL_0024: ldarg.0
    IL_0025: ldc.i4.4
    IL_002A: newarr 0x01000003
    IL_002F: stfld 0x0400091A
    IL_0030: ldarg.0
    IL_0032: ldc.i4.s 16
    IL_0037: newarr 0x01000003
    IL_003C: stfld 0x0400091B
    IL_003D: ldarg.0
    IL_003F: ldc.i4.s 11
    IL_0044: newarr 0x01000003
    IL_0049: stfld 0x0400091C
    IL_004A: ldarg.0
    IL_004B: ldc.i4.6
    IL_0050: newarr 0x01000003
    IL_0055: stfld 0x04000929
    IL_0056: ldarg.0
    IL_0057: ldc.i4.6
    IL_005C: newarr 0x01000003
    IL_0061: stfld 0x0400092A
    IL_0062: ldarg.0
    IL_0063: ldc.i4.4
    IL_0068: newarr 0x01000003
    IL_006D: stfld 0x04000931
    IL_006E: ldarg.0
    IL_006F: ldc.i4.6
    IL_0074: newarr 0x01000003
    IL_0079: stfld 0x04000932
    IL_007A: ldarg.0
    IL_007B: ldc.i4.3
    IL_0080: newarr 0x01000003
    IL_0085: stfld 0x04000933
    IL_0086: ldarg.0
    IL_0088: ldc.i4.s 40
    IL_008D: stfld 0x04000939
    IL_008E: ldarg.0
    IL_0090: ldc.i4.s 15
    IL_0095: stfld 0x0400093B
    IL_0096: ldarg.0
    IL_0097: ldc.i4.m1
    IL_009C: stfld 0x0400093C
    IL_009D: ldarg.0
    IL_009E: ldc.i4.1
    IL_00A3: stfld 0x0400093D
    IL_00A4: ldarg.0
    IL_00A5: ldc.i4.3
    IL_00AA: stfld 0x0400093E
    IL_00AB: ldarg.0
    IL_00AC: IL_22
    IL_00AD: nop
    IL_00AE: nop
    IL_00B3: stsfld 0x093F7D3F
    IL_00B4: nop
    IL_00B5: ldarg.2
    IL_00B6: ldarg.0
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BE: stsfld 0x09407D3F
    IL_00BF: nop
    IL_00C0: ldarg.2
    IL_00C1: ldarg.0
    IL_00C2: ldc.i4.3
    IL_00C7: stfld 0x04000949
    IL_00C8: ldarg.0
    IL_00C9: ldc.i4.m1
    IL_00CE: stfld 0x0400094D
    IL_00CF: ldarg.0
    IL_00D4: call 0x0A00001B
    IL_00D9: stfld 0x04000951
    IL_00DA: ldarg.0
    IL_00DB: ldc.i4.m1
    IL_00E0: stfld 0x04000955
    IL_00E1: ldarg.0
    IL_00E2: ldc.i4.6
    IL_00E7: stfld 0x0400095A
    IL_00E8: ldarg.0
    IL_00E9: ldc.i4.6
    IL_00EE: stfld 0x0400095B
    IL_00EF: ldarg.0
    IL_00F0: ldc.i4.8
    IL_00F5: newarr 0x01000007
    IL_00FA: stfld 0x04000967
    IL_00FB: ldarg.0
    IL_00FD: ldc.i4.s 12
    IL_0102: newarr 0x0100000B
    IL_0107: stfld 0x04000968
    IL_0108: ldarg.0
    IL_0109: ldc.i4.3
    IL_010E: newarr 0x01000010
    IL_0113: stfld 0x04000969
    IL_0114: ldarg.0
    IL_0115: ldc.i4.1
    IL_011A: stfld 0x0400096A
    IL_011B: ldarg.0
    IL_011D: ldc.i4.s 12
    IL_0122: newarr 0x0100000B
    IL_0127: stfld 0x0400096C
    IL_0128: ldarg.0
    IL_0129: ldc.i4.m1
    IL_012E: stfld 0x0400096D
    IL_012F: ldarg.0
    IL_0130: IL_22
    IL_0131: nop
    IL_0132: nop
    IL_0133: IL_C8
    IL_0134: IL_42
    IL_0139: stfld 0x0400096F
    IL_013A: ldarg.0
    IL_013F: call 0x0A000001
    IL_0140: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001FEF
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x0400096C
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70001ED5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x0400094C
    IL_0020: ldarg.0
    IL_0021: ldarg.0
    IL_0026: call 0x2B000066
    IL_002B: stfld 0x0400095E
    IL_0030: ldstr 0x7000174B
    IL_0035: call 0x06000220
    IL_0036: stloc.0
    IL_0037: ldarg.0
    IL_003C: ldstr 0x70000CDD
    IL_0041: call 0x06000220
    IL_0042: neg
    IL_0047: stfld 0x04000946
    IL_0048: ldarg.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000946
    IL_0050: ldc.i4.s 90
    IL_0051: mul
    IL_0052: neg
    IL_0057: stfld 0x04000947
    IL_0058: ldarg.0
    IL_005D: ldstr 0x70000BDB
    IL_0062: call 0x06000220
    IL_0067: stfld 0x04000944
    IL_0068: ldarg.0
    IL_006D: ldstr 0x70001F2D
    IL_0072: call 0x06000220
    IL_0077: stfld 0x0400096D
    IL_007C: ldstr 0x70000001
    IL_0081: call 0x0A000004
    IL_0082: stloc.1
    IL_0083: ldarg.0
    IL_0084: ldloc.1
    IL_0085: conv.r8
    IL_0086: ldarg.2
    IL_0087: nop
    IL_0088: nop
    IL_008A: br.s IL_0108
    IL_008B: xor
    IL_008C: ldloc.3
    IL_008D: nop
    IL_008E: ldarg.2
    IL_008F: ldarg.0
    IL_0090: ldarg.0
    IL_0095: call 0x2B000067
    IL_009A: stfld 0x04000960
    IL_009B: ldarg.0
    IL_00A0: ldstr 0x70000311
    IL_00A5: call 0x0A000004
    IL_00A6: conv.r8
    IL_00AB: ldc.i4 2099970048
    IL_00AC: or
    IL_00AD: ldloc.3
    IL_00AE: nop
    IL_00AF: ldarg.2
    IL_00B0: ldloc.0
    IL_00B2: ldc.i4.s 11
    IL_032F: switch (158 cases)
    IL_0330: rem
    IL_0331: nop
    IL_0332: nop
    IL_0333: stloc.0
    IL_0338: call 0x0A000014
    IL_0339: conv.u4
    IL_033A: ldarg.1
    IL_033B: nop
    IL_033C: nop
    IL_033D: IL_01
    IL_0342: stelem 0x09297B02
    IL_0343: nop
    IL_0344: ldarg.2
    IL_0345: ldc.i4.2
    IL_0346: ldloc.3
    IL_0347: IL_5A
    IL_0348: ldc.i4.1
    IL_0349: IL_58
    IL_034A: ldarg.0
    IL_034F: ldfld 0x04000920
    IL_0354: call 0x0A000042
    IL_0355: ldloc.3
    IL_0356: ldc.i4.3
    IL_0357: IL_5A
    IL_0358: conv.i2
    IL_035D: call 0x0A000008
    IL_0362: call 0x0A000042
    IL_0363: IL_22
    IL_0364: nop
    IL_0365: nop
    IL_20A46A: switch (534592 cases)
    }

    private void Start() {
    IL_0000: ldc.i4.1
    IL_0001: ldc.i4.4
    IL_0006: call 0x0A000045
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_000D: call 0x0A00002B
    IL_0012: ldstr 0x70022E5F
    IL_0014: ldloca.s 0
    IL_0019: call 0x0A000010
    IL_001E: call 0x0A000011
    IL_0023: call 0x0A000012
    IL_0024: conv.u8
    IL_0025: ldc.i4.8
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_01
    IL_0029: conv.r8
    IL_002A: IL_4C
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: call 0x0A00002B
    IL_0034: conv.r8
    IL_0035: IL_4D
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldarg.0
    IL_003E: call 0x0A00002B
    IL_0043: ldstr 0x70022774
    IL_0048: call 0x0A0001C1
    IL_0049: conv.r8
    IL_004A: IL_C9
    IL_004B: IL_01
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldc.i4.0
    IL_004F: stloc.1
    IL_0054: br IL_00E3
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000932
    IL_005B: ldloc.1
    IL_005C: ldarg.0
    IL_0061: ldfld 0x0400091A
    IL_0062: ldloc.1
    IL_0063: ldelem.i
    IL_0068: call 0x0A00004B
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: IL_C0
    IL_2111: switch (2088 cases)
    }

    public void SetMapStory() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.2
    IL_0007: brfalse IL_000A
    IL_0008: ldc.i4.5
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000918
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: IL_59
    IL_0014: ldloc.0
    IL_0015: IL_58
    IL_0016: ldelem.i
    IL_001B: call 0x0A00001B
    IL_0020: call 0x0A000013
    IL_0025: call 0x0A000014
    IL_0026: conv.u4
    IL_0027: ldarg.1
    IL_0028: nop
    IL_0029: nop
    IL_002A: IL_01
    IL_002F: stfld 0x0400092F
    IL_0030: ldarg.0
    IL_0035: ldfld 0x0400092F
    IL_003A: ldstr 0x70022E73
    IL_003B: conv.r8
    IL_003C: IL_DC
    IL_003D: IL_01
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.2
    IL_0045: brtrue IL_0080
    IL_0046: ldc.i4.0
    IL_0047: stloc.1
    IL_004C: br IL_0079
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000967
    IL_0053: ldloc.1
    IL_0054: IL_8F
    IL_0055: ldloc.1
    IL_0056: nop
    IL_0057: nop
    IL_0058: IL_01
    IL_0059: ldarg.0
    IL_005E: ldfld 0x0400092F
    IL_005F: ldc.i4.0
    IL_0060: conv.r8
    IL_0065: brtrue IL_70A0066
    IL_0066: conv.r8
    IL_006B: brtrue IL_6F0A006C
    IL_006C: ldc.i4.2
    IL_006D: nop
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: IL_81
    IL_0071: ldloc.1
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_01
    IL_0075: ldloc.1
    IL_0076: ldc.i4.1
    IL_0077: IL_58
    IL_0078: stloc.1
    IL_0079: ldloc.1
    IL_007A: ldc.i4.8
    IL_007B: IL_3F
    IL_007C: IL_CD
    IL_007D: IL_FF
    IL_007E: IL_FF
    IL_007F: IL_FF
    IL_0080: ret
    }

    public void SetMapExtreme() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_003E
    IL_0006: ldc.i4.0
    IL_0007: stloc.0
    IL_000C: br IL_0023
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000932
    IL_0013: ldloc.0
    IL_0014: ldelem.i
    IL_0015: conv.r8
    IL_0016: not
    IL_0017: nop
    IL_0018: nop
    IL_001A: br.s IL_008A
    IL_001B: IL_A9
    IL_001C: ldarg.1
    IL_001D: nop
    IL_001E: ldloc.0
    IL_001F: ldloc.0
    IL_0020: ldc.i4.1
    IL_0021: IL_58
    IL_0022: stloc.0
    IL_0023: ldloc.0
    IL_0024: ldc.i4.6
    IL_0025: IL_3F
    IL_0026: IL_E3
    IL_0027: IL_FF
    IL_0028: IL_FF
    IL_0029: IL_FF
    IL_002E: ldstr 0x7000012D
    IL_0033: call 0x0A000004
    IL_0034: conv.r8
    IL_0035: ldloc.1
    IL_0036: nop
    IL_0037: nop
    IL_0039: br.s IL_00A9
    IL_003A: IL_B0
    IL_003B: ldarg.1
    IL_003C: nop
    IL_003D: ldloc.0
    IL_003E: ldc.i4.0
    IL_003F: stloc.1
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400093D
    IL_0046: ldc.i4.1
    IL_0047: IL_59
    IL_0048: ldc.i4.8
    IL_0049: add
    IL_004A: stloc.1
    IL_004B: ldloc.1
    IL_004C: ldarg.0
    IL_0051: ldfld 0x0400094D
    IL_00B2: switch (23 cases)
    IL_00B3: ldloc.0
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: IL_01
    IL_00B7: stloc.2
    IL_00B8: ldarg.0
    IL_00B9: ldloc.2
    IL_00BA: conv.r8
    IL_00BB: ldarg.3
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: stloc.0
    IL_00C3: call 0x0A00001B
    IL_00C4: IL_22
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: ldc.i4.0
    IL_00CE: ldc.i4 360
    IL_00D3: call 0x0A000045
    IL_00D4: conv.i2
    IL_00D5: IL_22
    IL_00D6: nop
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: nop
    IL_00DE: call 0x0A000060
    IL_00E3: call 0x0A000014
    IL_00E4: conv.u4
    IL_00E5: ldarg.1
    IL_00E6: nop
    IL_00E7: nop
    IL_00E8: IL_01
    IL_00ED: stfld 0x0400092F
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x0400092F
    IL_00F8: ldstr 0x70022E73
    IL_00F9: conv.r8
    IL_00FA: IL_DC
    IL_00FB: IL_01
    IL_00FC: nop
    IL_00FD: stloc.0
    IL_00FE: ldarg.0
    IL_0103: ldfld 0x0400092F
    IL_0104: conv.r8
    IL_0105: conv.i1
    IL_0106: nop
    IL_0107: nop
    IL_0109: br.s IL_010C
    IL_010E: ldfld 0x0400093D
    IL_010F: conv.r8
    IL_0110: ldelem.i8
    IL_0111: ldarg.1
    IL_0112: nop
    IL_0113: ldloc.0
    IL_0114: ldarg.0
    IL_0119: ldfld 0x0400092F
    IL_011A: conv.r8
    IL_011F: cpobj 0x130A0000
    IL_0120: ldloc.0
    IL_0122: ldloca.s 6
    IL_0127: ldfld 0x0A00005E
    IL_0128: stloc.3
    IL_0129: ldarg.0
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000919
    IL_0130: ldloc.1
    IL_0131: IL_98
    IL_0132: ldloc.3
    IL_0133: IL_5A
    IL_0138: stfld 0x0400096F
    IL_0139: ldarg.0
    IL_013E: ldfld 0x04000938
    IL_013F: ldarg.0
    IL_0144: ldfld 0x0400092F
    IL_0145: conv.r8
    IL_0146: IL_22
    IL_0147: nop
    IL_0148: nop
    IL_0149: stloc.0
    IL_014E: call 0x0A000043
    IL_014F: ldarg.0
    IL_0154: ldfld 0x0400096F
    IL_0159: call 0x0A000008
    IL_015A: conv.r8
    IL_015B: ldloc.3
    IL_015C: nop
    IL_015D: nop
    IL_015E: stloc.0
    IL_015F: ldarg.0
    IL_0164: ldfld 0x04000938
    IL_0165: ldarg.0
    IL_016A: ldfld 0x04000938
    IL_016B: conv.r8
    IL_016C: ldc.i4.2
    IL_016D: nop
    IL_016E: nop
    IL_016F: stloc.0
    IL_0174: call 0x0A000043
    IL_0179: call 0x0A00001D
    IL_017A: conv.r8
    IL_017F: call 0x020A0000
    IL_0184: ldfld 0x04000938
    IL_0185: conv.r8
    IL_0186: stloc.0
    IL_0187: nop
    IL_0188: nop
    IL_0189: stloc.0
    IL_018A: ldc.i4.0
    IL_018B: conv.r8
    IL_018C: stloc.1
    IL_018D: nop
    IL_018E: nop
    IL_018F: stloc.0
    IL_0190: ldarg.0
    IL_0195: ldfld 0x0400092F
    IL_019A: ldstr 0x70022E93
    IL_019B: conv.r8
    IL_019D: brfalse.s IL_019E
    IL_019E: nop
    IL_019F: stloc.0
    IL_01A0: IL_22
    IL_01A1: nop
    IL_01A2: nop
    IL_01A3: nop
    IL_01A4: nop
    IL_01A5: IL_22
    IL_01A6: nop
    IL_01A7: nop
    IL_01A8: IL_F0
    IL_01A9: IL_42
    IL_01AA: IL_22
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: nop
    IL_01AE: nop
    IL_01B3: call 0x0A000060
    IL_01B4: conv.r8
    IL_01B9: call 0x020A0000
    IL_01BA: ldloc.1
    IL_01BF: stfld 0x0400094D
    IL_01C0: ldarg.0
    IL_01C5: ldfld 0x04000964
    IL_01C6: ldarg.0
    IL_01CB: ldfld 0x0400096F
    IL_01CC: conv.r8
    IL_01CD: ldelem.i8
    IL_01CE: IL_01
    IL_01CF: nop
    IL_01D0: ldloc.0
    IL_01D1: ldc.i4.0
    IL_01D3: stloc.s 4
    IL_01D8: br IL_0209
    IL_01D9: ldarg.0
    IL_01DE: ldfld 0x04000967
    IL_01E0: ldloc.s 4
    IL_01E1: IL_8F
    IL_01E2: ldloc.1
    IL_01E3: nop
    IL_01E4: nop
    IL_01E5: IL_01
    IL_01E6: ldarg.0
    IL_01EB: ldfld 0x0400092F
    IL_01EC: ldc.i4.0
    IL_01ED: conv.r8
    IL_01F2: brtrue IL_110A01F3
    IL_01F3: ldarg.2
    IL_01F4: conv.r8
    IL_01F9: brtrue IL_6F0A01FA
    IL_01FA: ldc.i4.2
    IL_01FB: nop
    IL_01FC: nop
    IL_01FD: stloc.0
    IL_01FE: IL_81
    IL_01FF: ldloc.1
    IL_0200: nop
    IL_0201: nop
    IL_0202: IL_01
    IL_0204: ldloc.s 4
    IL_0205: ldc.i4.1
    IL_0206: IL_58
    IL_0208: stloc.s 4
    IL_020A: ldloc.s 4
    IL_020B: ldc.i4.8
    IL_020C: IL_3F
    IL_020D: IL_C8
    IL_020E: IL_FF
    IL_020F: IL_FF
    IL_0210: IL_FF
    IL_0211: ret
    }

    public void TowerBreak() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_001A
    IL_0006: ldarg.0
    IL_0007: dup
    IL_000C: ldfld 0x0400095B
    IL_000D: ldc.i4.1
    IL_000E: IL_59
    IL_000F: neg
    IL_0014: stfld 0x0400095B
    IL_0019: br IL_0029
    IL_001A: ldarg.0
    IL_001B: dup
    IL_0020: ldfld 0x0400095A
    IL_0021: ldc.i4.1
    IL_0022: IL_59
    IL_0023: neg
    IL_0028: stfld 0x0400095A
    IL_0029: ldarg.0
    IL_002E: ldfld 0x0400095B
    IL_002F: ldc.i4.0
    IL_0030: IL_3D
    IL_0031: ldc.i4.6
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0035: ldarg.0
    IL_003A: ldfld 0x0400095A
    IL_003B: ldc.i4.0
    IL_003C: IL_3D
    IL_003E: starg.s 0
    IL_003F: nop
    IL_0040: nop
    IL_0041: ldarg.0
    IL_0046: ldfld 0x0400092B
    IL_0047: conv.r8
    IL_0048: conv.i2
    IL_0049: nop
    IL_004A: nop
    IL_004C: br.s IL_00BC
    IL_004D: div.un
    IL_004E: ldarg.3
    IL_004F: nop
    IL_0050: ldloc.0
    IL_0051: ret
    }

    public void SetRndPoint() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000944
    IL_0006: ldc.i4.6
    IL_0177: switch (91 cases)
    IL_0178: nop
    IL_0179: ldarg.2
    IL_017A: ret
    }

    public void OpenDundoor() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000938
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ret
    }

    public void EnemyDead() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000935
    IL_0007: ldc.i4.1
    IL_0008: IL_59
    IL_000D: stfld 0x04000935
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000943
    IL_0018: brtrue IL_0073
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000935
    IL_001F: ldc.i4.0
    IL_0020: IL_3D
    IL_0021: IL_4E
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0025: ldarg.0
    IL_002A: ldfld 0x0400093C
    IL_002C: ldc.i4.s -2
    IL_0135: switch (65 cases)
    IL_0136: IL_22
    IL_0137: ldelem.i
    IL_0138: IL_99
    IL_0139: ldc.i4.3
    IL_013A: IL_3E
    IL_013F: call 0x0A000008
    IL_0144: call 0x0A000029
    IL_0145: conv.r8
    IL_0146: ldloc.3
    IL_0147: nop
    IL_0148: nop
    IL_0149: stloc.0
    IL_014A: ldarg.0
    IL_014F: ldfld 0x04000932
    IL_0150: ldarg.0
    IL_0155: ldfld 0x04000949
    IL_0156: ldelem.i
    IL_0157: IL_22
    IL_0158: nop
    IL_0159: nop
    IL_015A: nop
    IL_015B: nop
    IL_015C: ldc.i4.0
    IL_0161: ldc.i4 360
    IL_0166: call 0x0A000045
    IL_0167: conv.i2
    IL_0168: IL_22
    IL_0169: nop
    IL_016A: nop
    IL_016B: nop
    IL_016C: nop
    IL_0171: call 0x0A000060
    IL_0172: conv.r8
    IL_0177: call 0x020A0000
    IL_017C: ldfld 0x04000932
    IL_017D: ldarg.0
    IL_0182: ldfld 0x04000949
    IL_0183: ldelem.i
    IL_0184: conv.r8
    IL_0185: not
    IL_0186: nop
    IL_0187: nop
    IL_0189: br.s IL_018F
    IL_018B: ldarg.s 4
    IL_018C: ldarg.1
    IL_018D: conv.r8
    IL_018E: IL_AA
    IL_018F: ldarg.1
    IL_0190: nop
    IL_0191: ldloc.0
    IL_0192: ldarg.0
    IL_0197: ldfld 0x04000932
    IL_0198: ldarg.0
    IL_019D: ldfld 0x04000949
    IL_019E: ldelem.i
    IL_019F: conv.r8
    IL_01A0: stloc.0
    IL_01A1: nop
    IL_01A2: nop
    IL_01A3: stloc.0
    IL_01A4: ldc.i4.1
    IL_01A5: conv.r8
    IL_01A6: stloc.1
    IL_01A7: nop
    IL_01A8: nop
    IL_01A9: stloc.0
    IL_01AA: ldarg.0
    IL_01AB: ldarg.0
    IL_01B0: ldfld 0x04000949
    IL_01B1: ldc.i4.1
    IL_01B2: IL_58
    IL_01B3: ldc.i4.3
    IL_01B4: mul
    IL_01B5: ldc.i4.3
    IL_01B6: IL_58
    IL_01BB: stfld 0x04000949
    IL_01BC: ldarg.0
    IL_01BD: ldarg.0
    IL_01C2: ldfld 0x04000949
    IL_01C7: stfld 0x0400094A
    IL_01CC: br IL_0281
    IL_01CD: ldarg.1
    IL_01CE: ldc.i4.3
    IL_044F: switch (159 cases)
    }

    public void CallGeneral() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0049
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400091D
    IL_000C: conv.r8
    IL_000D: stloc.3
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0013: ldarg.s 0
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000926
    IL_001C: conv.r8
    IL_001E: ldarga.s 0
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000958
    IL_0027: ldc.i4.2
    IL_0028: IL_3F
    IL_0029: ldc.i4.1
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_0032: ldfld 0x0400091D
    IL_0033: ldc.i4.0
    IL_0034: conv.r8
    IL_0039: brtrue IL_6F0A003A
    IL_003A: stloc.0
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldc.i4.0
    IL_003F: conv.r8
    IL_0040: stloc.1
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0048: br IL_0087
    IL_0049: ldarg.0
    IL_004E: ldfld 0x0400091D
    IL_004F: conv.r8
    IL_0050: stloc.3
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: conv.r8
    IL_0056: ldarg.s 0
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000927
    IL_005F: conv.r8
    IL_0061: ldarga.s 0
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000958
    IL_006A: ldc.i4.2
    IL_006B: IL_3F
    IL_006C: ldc.i4.1
    IL_006D: nop
    IL_006E: nop
    IL_006F: nop
    IL_0070: ldarg.0
    IL_0075: ldfld 0x0400091D
    IL_0076: ldc.i4.0
    IL_0077: conv.r8
    IL_007C: brtrue IL_6F0A007D
    IL_007D: stloc.0
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ldc.i4.1
    IL_0082: conv.r8
    IL_0083: stloc.1
    IL_0084: nop
    IL_0085: nop
    IL_0086: stloc.0
    IL_0087: ldarg.0
    IL_008C: ldfld 0x0400094C
    IL_008D: ldc.i4.2
    IL_0092: beq IL_00C5
    IL_0093: ldarg.0
    IL_0094: IL_22
    IL_0095: nop
    IL_0096: nop
    IL_009B: stsfld 0x056B043F
    IL_009C: conv.i2
    IL_009D: add
    IL_009E: IL_59
    IL_009F: IL_22
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: IL_3E
    IL_00A4: IL_5A
    IL_00A9: stfld 0x04000941
    IL_00AA: ldarg.0
    IL_00AF: ldfld 0x04000961
    IL_00B4: call 0x0A000082
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x04000941
    IL_00BF: call 0x0A000083
    IL_00C0: conv.r8
    IL_00C1: IL_F3
    IL_00C2: ldarg.0
    IL_00C3: nop
    IL_00C4: ldloc.0
    IL_00C5: ret
    }

    public void SetBGM() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_C9
    IL_0009: IL_01
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: ldstr 0x70022774
    IL_0011: ldarg.1
    IL_0016: call 0x0A000255
    IL_0017: ret
    }

    public void ChangeBGM() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0025
    IL_0006: ldarg.0
    IL_000B: call 0x0A00002B
    IL_0010: ldstr 0x70022EA9
    IL_0015: call 0x0A000012
    IL_0016: conv.u8
    IL_0017: ldc.i4.8
    IL_0018: nop
    IL_0019: nop
    IL_001A: IL_01
    IL_001B: conv.r8
    IL_001C: IL_4C
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0024: br IL_0053
    IL_0025: ldc.i4.1
    IL_0026: ldc.i4.4
    IL_002B: call 0x0A000045
    IL_002C: stloc.0
    IL_002D: ldarg.0
    IL_0032: call 0x0A00002B
    IL_0037: ldstr 0x70022E5F
    IL_0039: ldloca.s 0
    IL_003E: call 0x0A000010
    IL_0043: call 0x0A000011
    IL_0048: call 0x0A000012
    IL_0049: conv.u8
    IL_004A: ldc.i4.8
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_01
    IL_004E: conv.r8
    IL_004F: IL_4C
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0058: call 0x0A00002B
    IL_0059: conv.r8
    IL_005A: IL_4D
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ret
    }

    public void RegenStart() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000935
    IL_0007: ldarg.0
    IL_0008: ldc.i4.0
    IL_000D: stfld 0x04000943
    IL_000E: ldarg.0
    IL_000F: ldarg.0
    IL_0014: ldfld 0x0400095E
    IL_0019: ldfld 0x04000512
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000947
    IL_0020: IL_8F
    IL_0021: not
    IL_0022: nop
    IL_0023: nop
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000507
    IL_002E: stfld 0x04000945
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000945
    IL_0035: ldc.i4.0
    IL_0036: IL_3E
    IL_0037: not
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000969
    IL_0041: ldc.i4.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x0400095E
    IL_004C: ldfld 0x04000512
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000947
    IL_0053: IL_8F
    IL_0054: not
    IL_0055: nop
    IL_0056: nop
    IL_0057: ldarg.0
    IL_005C: ldfld 0x0400050C
    IL_005D: ldelem.i4
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000969
    IL_0064: ldc.i4.1
    IL_0065: ldarg.0
    IL_006A: ldfld 0x0400095E
    IL_006F: ldfld 0x04000512
    IL_0070: ldarg.0
    IL_0075: ldfld 0x04000947
    IL_0076: IL_8F
    IL_0077: not
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldarg.0
    IL_007F: ldfld 0x0400050D
    IL_0080: ldelem.i4
    IL_0081: ldarg.0
    IL_0086: ldfld 0x04000969
    IL_0087: ldc.i4.2
    IL_0088: ldarg.0
    IL_008D: ldfld 0x0400095E
    IL_0092: ldfld 0x04000512
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04000947
    IL_0099: IL_8F
    IL_009A: not
    IL_009B: nop
    IL_009C: nop
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x0400050E
    IL_00A3: ldelem.i4
    IL_00A4: ldarg.0
    IL_00A5: ldarg.0
    IL_00AA: ldfld 0x04000939
    IL_00AF: stfld 0x0400093A
    IL_00B0: ldarg.0
    IL_00B1: ldc.i4.0
    IL_00B6: stfld 0x0400093C
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000931
    IL_00BD: ldc.i4.0
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x0400091B
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x0400095E
    IL_00CE: ldfld 0x04000512
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x04000947
    IL_00D5: IL_8F
    IL_00D6: not
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: ldarg.0
    IL_00DE: ldfld 0x04000508
    IL_00DF: ldelem.i
    IL_00E4: stelem 0x09317B02
    IL_00E5: nop
    IL_00E6: ldarg.2
    IL_00E7: ldc.i4.1
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x0400091B
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x0400095E
    IL_00F8: ldfld 0x04000512
    IL_00F9: ldarg.0
    IL_00FE: ldfld 0x04000947
    IL_00FF: IL_8F
    IL_0100: not
    IL_0101: nop
    IL_0102: nop
    IL_0103: ldarg.0
    IL_0108: ldfld 0x04000509
    IL_0109: ldelem.i
    IL_010E: stelem 0x09317B02
    IL_010F: nop
    IL_0110: ldarg.2
    IL_0111: ldc.i4.2
    IL_0112: ldarg.0
    IL_0117: ldfld 0x0400091B
    IL_0118: ldarg.0
    IL_011D: ldfld 0x0400095E
    IL_0122: ldfld 0x04000512
    IL_0123: ldarg.0
    IL_0128: ldfld 0x04000947
    IL_0129: IL_8F
    IL_012A: not
    IL_012B: nop
    IL_012C: nop
    IL_012D: ldarg.0
    IL_0132: ldfld 0x0400050A
    IL_0133: ldelem.i
    IL_0138: stelem 0x00000000
    }

    public void EnemyChange() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000940
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_3F
    IL_000B: IL_43
    IL_000D: ldloca.s 0
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: dup
    IL_0016: ldfld 0x04000940
    IL_0017: IL_22
    IL_0018: ldelem.i
    IL_0019: IL_99
    IL_001A: IL_99
    IL_001B: IL_3E
    IL_001C: IL_59
    IL_0021: stfld 0x04000940
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400093D
    IL_0028: ldc.i4.5
    IL_0029: IL_3C
    IL_002B: ldarg.s 0
    IL_002C: nop
    IL_002D: nop
    IL_002E: ldarg.0
    IL_002F: dup
    IL_0034: ldfld 0x0400093D
    IL_0035: ldc.i4.1
    IL_0036: IL_58
    IL_003B: stfld 0x0400093D
    IL_003C: ldc.i4.0
    IL_003D: stloc.0
    IL_0042: br IL_006C
    IL_0043: ldarg.0
    IL_0048: ldfld 0x0400093D
    IL_0049: ldloc.0
    IL_004A: IL_58
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000946
    IL_0052: ldc.i4.s 10
    IL_0053: mul
    IL_0054: IL_58
    IL_0055: ldc.i4.1
    IL_0056: IL_59
    IL_0057: stloc.1
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000931
    IL_005E: ldloc.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400091B
    IL_0065: ldloc.1
    IL_0066: ldelem.i
    IL_006B: stelem 0x0A581706
    IL_006C: ldloc.0
    IL_006D: ldc.i4.3
    IL_006E: IL_3F
    IL_0073: ldtoken 0x2AFFFFFF
    }

    public void ChangeBoss() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x0400091C
    IL_0007: ldc.i4.0
    IL_0008: ldelem.i
    IL_0009: ldarg.1
    IL_000A: ldarg.2
    IL_000F: call 0x0A000014
    IL_0010: conv.u4
    IL_0011: ldarg.1
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_01
    IL_0019: stfld 0x0400092E
    IL_001A: ldarg.0
    IL_001F: ldfld 0x0400092E
    IL_0020: conv.r8
    IL_0021: conv.i4
    IL_0022: nop
    IL_0023: nop
    IL_0025: br.s IL_0028
    IL_002A: ldfld 0x04000946
    IL_002B: ldarg.0
    IL_0030: ldfld 0x0400096F
    IL_0031: conv.r8
    IL_0033: starg.s 0
    IL_0034: nop
    IL_0035: ldloc.0
    IL_0036: ret
    }

    public void BossAppear() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x060004F4
    IL_000B: stfld 0x04000952
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x0400091C
    IL_0013: ldarg.1
    IL_0014: ldelem.i
    IL_0015: ldarg.0
    IL_001A: ldfld 0x04000952
    IL_001F: call 0x0A000013
    IL_0024: call 0x0A000014
    IL_0025: conv.u4
    IL_0026: ldarg.1
    IL_0027: nop
    IL_0028: nop
    IL_0029: IL_01
    IL_002E: stfld 0x0400092E
    IL_002F: ldarg.0
    IL_0034: ldfld 0x0400092E
    IL_0035: conv.r8
    IL_0036: conv.i4
    IL_0037: nop
    IL_0038: nop
    IL_003A: br.s IL_003D
    IL_003F: ldfld 0x04000946
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400096F
    IL_0046: conv.r8
    IL_0048: starg.s 0
    IL_0049: nop
    IL_004A: ldloc.0
    IL_004B: ldarg.0
    IL_004C: dup
    IL_0051: ldfld 0x04000935
    IL_0052: ldc.i4.1
    IL_0053: IL_58
    IL_0058: stfld 0x04000935
    IL_0059: ldarg.0
    IL_005A: ldc.i4.1
    IL_005F: stfld 0x04000942
    IL_0060: ret
    }

    public void BossCutin() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000934
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000934
    IL_0017: conv.r8
    IL_0018: conv.i8
    IL_0019: nop
    IL_001A: nop
    IL_001C: br.s IL_0020
    IL_001D: conv.r8
    IL_001F: beq.s IL_0022
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000934
    IL_0028: conv.r8
    IL_0029: stloc.0
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.1
    IL_002E: conv.r8
    IL_002F: stloc.1
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000934
    IL_0039: conv.r8
    IL_003A: conv.r4
    IL_003B: nop
    IL_003C: nop
    IL_003E: br.s IL_0061
    IL_003F: nop
    IL_0040: nop
    IL_8945: switch (8768 cases)
    }

    public void BossKill_Cheat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400092E
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_002F
    IL_0011: ldarg.0
    IL_0016: ldfld 0x0400092E
    IL_0017: conv.r8
    IL_0018: stloc.0
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000050
    IL_0021: ldarg.0
    IL_0022: dup
    IL_0027: ldfld 0x04000935
    IL_0028: ldc.i4.1
    IL_0029: IL_59
    IL_002E: stfld 0x04000935
    IL_002F: ret
    }

    public void Summon() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400094E
    IL_0006: ldc.i4.0
    IL_0007: IL_3D
    IL_0008: IL_23
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x0400094E
    IL_0013: ldarg.0
    IL_0014: ldarg.2
    IL_0019: stfld 0x04000951
    IL_001A: ldarg.0
    IL_001F: ldstr 0x70022EBB
    IL_0020: IL_22
    IL_0021: IL_CD
    IL_0022: IL_CC
    IL_0023: IL_CC
    IL_0024: IL_3D
    IL_0025: IL_22
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_0029: IL_3F
    IL_002E: call 0x0A000017
    IL_002F: ret
    }

    private void Summon_p() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000935
    IL_0006: ldc.i4.0
    IL_0007: IL_3E
    IL_0008: IL_DE
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000951
    IL_0016: call 0x0A00007E
    IL_0017: IL_22
    IL_0018: ldelem.i
    IL_0019: IL_99
    IL_001A: IL_99
    IL_001B: IL_3E
    IL_0020: call 0x0A000008
    IL_0025: call 0x0A000029
    IL_0026: stloc.0
    IL_0028: ldloca.s 0
    IL_0029: ldc.i4.1
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: nop
    IL_0033: call 0x0A00001A
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000937
    IL_003A: ldloc.0
    IL_003B: conv.r8
    IL_003C: ldloc.3
    IL_003D: nop
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000937
    IL_0046: conv.r8
    IL_0047: stloc.2
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004B: conv.r8
    IL_004C: IL_B9
    IL_004D: nop
    IL_004E: nop
    IL_004F: stloc.0
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000931
    IL_0057: ldc.i4.0
    IL_0058: ldc.i4.2
    IL_005D: call 0x0A000045
    IL_005E: ldelem.i
    IL_0063: stfld 0x0400092C
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x0400092C
    IL_006B: ldloc.0
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_006F: nop
    IL_0070: nop
    IL_0071: ldc.i4.0
    IL_0076: ldc.i4 360
    IL_007B: call 0x0A000045
    IL_007C: conv.i2
    IL_007D: IL_22
    IL_007E: nop
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0086: call 0x0A000060
    IL_008B: call 0x0A000014
    IL_008C: conv.u4
    IL_008D: ldarg.1
    IL_008E: nop
    IL_008F: nop
    IL_0090: IL_01
    IL_0095: stfld 0x0400092D
    IL_0096: ldarg.0
    IL_009B: ldfld 0x0400092D
    IL_00A0: ldstr 0x70022ECD
    IL_00A1: conv.r8
    IL_00A2: IL_DC
    IL_00A3: IL_01
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x0400092D
    IL_00AC: conv.r8
    IL_00AD: ldc.i4.8
    IL_00AE: nop
    IL_00AF: nop
    IL_00B1: br.s IL_00B4
    IL_00B6: ldfld 0x04000946
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000944
    IL_00BD: ldc.i4.1
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x0400096F
    IL_00C4: conv.r8
    IL_00C5: ldc.i4.8
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: ldloc.0
    IL_00C9: ldarg.0
    IL_00CA: dup
    IL_00CF: ldfld 0x04000935
    IL_00D0: ldc.i4.1
    IL_00D1: IL_58
    IL_00D6: stfld 0x04000935
    IL_00D7: ldarg.0
    IL_00D8: dup
    IL_00DD: ldfld 0x0400094E
    IL_00DE: ldc.i4.1
    IL_00DF: IL_59
    IL_00E4: stfld 0x0400094E
    IL_00E9: br IL_00FC
    IL_00EA: ldarg.0
    IL_00EB: ldc.i4.0
    IL_00F0: stfld 0x0400094E
    IL_00F1: ldarg.0
    IL_00F6: ldstr 0x70022EBB
    IL_00FB: call 0x0A00007B
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x0400094E
    IL_0102: ldc.i4.0
    IL_0103: IL_3D
    IL_0105: ldloca.s 0
    IL_0106: nop
    IL_0107: nop
    IL_0108: ldarg.0
    IL_0109: ldc.i4.0
    IL_010E: stfld 0x0400094E
    IL_010F: ldarg.0
    IL_0114: ldstr 0x70022EBB
    IL_0119: call 0x0A00007B
    IL_011A: ret
    }

    public void BossKill() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_001D
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400096C
    IL_000D: ldc.i4.s 9
    IL_000E: IL_8F
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: IL_01
    IL_0013: dup
    IL_0016: stloc 22551
    IL_0017: IL_54
    IL_001C: br IL_002E
    IL_001D: ldarg.0
    IL_0022: ldfld 0x0400096C
    IL_0023: ldarg.1
    IL_0024: IL_8F
    IL_0025: stloc.1
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_01
    IL_0029: dup
    IL_002C: stloc 22551
    IL_002D: IL_54
    IL_0032: ldstr 0x70001FEF
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400096C
    IL_003D: call 0x060003F8
    IL_003E: pop
    IL_003F: ldarg.0
    IL_0044: ldfld 0x0400095D
    IL_0049: brfalse IL_004F
    IL_004E: br IL_0083
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000945
    IL_0055: ldc.i4.0
    IL_0056: IL_3D
    IL_005B: call 0x02000000
    IL_005C: dup
    IL_0061: ldfld 0x0400096E
    IL_0062: ldc.i4.1
    IL_0063: IL_59
    IL_0064: neg
    IL_0069: stfld 0x0400096E
    IL_006A: ldarg.0
    IL_006F: ldfld 0x0400096E
    IL_0070: ldc.i4.0
    IL_0071: IL_3D
    IL_0072: stloc.3
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_0076: ldarg.0
    IL_007B: ldfld 0x0400095F
    IL_007D: ldc.i4.s 100
    IL_007E: conv.r8
    IL_0080: starg.s 6
    IL_0081: nop
    IL_0082: ldloc.0
    IL_0083: ldarg.0
    IL_0084: ldc.i4.0
    IL_0089: call 0x060004F9
    IL_008A: ret
    }

    public void FinalWave() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400095F
    IL_0006: ldarg.0
    IL_000B: ldfld 0x0400093E
    IL_000C: ldc.i4.1
    IL_000D: IL_59
    IL_000E: conv.r8
    IL_0010: starg.s 6
    IL_0011: nop
    IL_0012: ldloc.0
    IL_0013: ldarg.0
    IL_0014: ldarg.0
    IL_0019: ldfld 0x0400093E
    IL_001E: stfld 0x0400093D
    IL_001F: ret
    }

    public void GeneralHP() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400096D
    IL_0006: ldc.i4.m1
    IL_000B: beq IL_0075
    IL_000C: ldc.i4.1
    IL_0011: call 0x0600056F
    IL_0012: stloc.0
    IL_0013: ldc.i4.0
    IL_0014: stloc.1
    IL_0019: br IL_0038
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000968
    IL_0020: ldloc.1
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000968
    IL_0027: ldloc.1
    IL_0028: IL_94
    IL_0029: ldloc.0
    IL_002A: conv.i2
    IL_002B: IL_22
    IL_002C: IL_CD
    IL_002D: IL_CC
    IL_002E: IL_4C
    IL_002F: IL_3E
    IL_0030: IL_5A
    IL_0031: not
    IL_0032: IL_58
    IL_0033: ldelem.i8
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: IL_58
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_003A: ldc.i4.s 12
    IL_003B: IL_3F
    IL_003C: IL_DA
    IL_003D: IL_FF
    IL_003E: IL_FF
    IL_003F: IL_FF
    IL_0040: ldarg.1
    IL_0045: brtrue IL_005E
    IL_0046: ldarg.0
    IL_004B: ldfld 0x04000968
    IL_004C: ldarg.0
    IL_0051: ldfld 0x0400096D
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000964
    IL_005C: ldfld 0x040002CB
    IL_005D: ldelem.i8
    IL_0062: ldstr 0x70001F1D
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000968
    IL_006D: call 0x060003F8
    IL_006E: pop
    IL_006F: ldc.i4.1
    IL_0074: call 0x0600056B
    IL_0075: ret
    }

    public void GeneralDead() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000958
    IL_0006: ldc.i4.2
    IL_0007: IL_3F
    IL_0008: ldc.i4.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400091D
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0018: brtrue IL_6F0A0019
    IL_0019: stloc.0
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldc.i4.0
    IL_001E: conv.r8
    IL_001F: stloc.1
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: ldarg.0
    IL_0024: ldc.i4.0
    IL_0029: call 0x06000504
    IL_002A: ldarg.0
    IL_002F: ldfld 0x0400094C
    IL_0030: ldc.i4.2
    IL_0035: beq IL_0047
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000965
    IL_003C: conv.r8
    IL_003D: stloc.0
    IL_003E: nop
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: ldc.i4.0
    IL_0042: conv.r8
    IL_0043: stloc.1
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000966
    IL_004D: conv.r8
    IL_004E: stloc.0
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ldc.i4.1
    IL_0053: conv.r8
    IL_0054: stloc.1
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ret
    }

    public void RegenAlly() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000956
    IL_000A: brtrue IL_0058
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400092B
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0025: ldc.i4 2835521
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_002D: ldfld 0x0400092B
    IL_0032: call 0x0A000042
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: IL_BF
    IL_003C: call 0x0A000008
    IL_003D: conv.r8
    IL_003E: ldloc.3
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x0400092B
    IL_0048: conv.r8
    IL_0049: stloc.0
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldc.i4.1
    IL_004E: conv.r8
    IL_004F: stloc.1
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0057: br IL_00D6
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000956
    IL_005E: ldc.i4.8
    IL_005F: IL_3C
    IL_0060: div
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldarg.0
    IL_0065: dup
    IL_006A: ldfld 0x0400096A
    IL_006B: ldc.i4.m1
    IL_006C: IL_5A
    IL_006D: neg
    IL_0072: stfld 0x0400096A
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000924
    IL_007D: call 0x0A000062
    IL_007E: IL_22
    IL_007F: IL_CD
    IL_0080: IL_CC
    IL_0081: IL_CC
    IL_0082: IL_3D
    IL_0083: IL_22
    IL_0084: ldelem.i
    IL_0085: IL_99
    IL_0086: IL_99
    IL_0087: IL_3E
    IL_008C: call 0x0A000075
    IL_0091: call 0x0A000008
    IL_0092: ldarg.0
    IL_0097: ldfld 0x0400096A
    IL_0098: conv.i2
    IL_009D: call 0x0A000008
    IL_00A2: call 0x0A000042
    IL_00A3: IL_22
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: IL_3F
    IL_00AC: call 0x0A000008
    IL_00B1: call 0x0A000019
    IL_00B6: call 0x0A000013
    IL_00BB: call 0x0A000014
    IL_00BC: pop
    IL_00C1: br IL_00D6
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x04000956
    IL_00C9: ldc.i4.s 12
    IL_00CA: IL_3E
    IL_00CB: ldloc.1
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: ldarg.0
    IL_00D0: ldc.i4.m1
    IL_00D5: stfld 0x04000956
    IL_00D6: ldarg.0
    IL_00D7: dup
    IL_00DC: ldfld 0x04000956
    IL_00DD: ldc.i4.1
    IL_00DE: IL_58
    IL_00DF: neg
    IL_00E4: stfld 0x04000956
    IL_00E5: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400093C
    IL_000A: brtrue IL_00EB
    IL_000B: ldc.i4.0
    IL_000C: stloc.0
    IL_0011: br IL_00D1
    IL_0012: ldarg.0
    IL_0013: ldarg.0
    IL_0018: call 0x060004F4
    IL_001D: stfld 0x04000952
    IL_001E: ldarg.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000931
    IL_0025: ldloc.0
    IL_0026: ldelem.i
    IL_002B: stfld 0x0400092C
    IL_002C: ldarg.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x0400092C
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000952
    IL_003D: call 0x0A000013
    IL_0042: call 0x0A000014
    IL_0043: conv.u4
    IL_0044: ldarg.1
    IL_0045: nop
    IL_0046: nop
    IL_0047: IL_01
    IL_004C: stfld 0x0400092D
    IL_004D: ldarg.0
    IL_0052: ldfld 0x0400092D
    IL_0057: ldstr 0x70022ECD
    IL_0058: conv.r8
    IL_0059: IL_DC
    IL_005A: IL_01
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x0400092D
    IL_0063: conv.r8
    IL_0064: ldc.i4.8
    IL_0065: nop
    IL_0066: nop
    IL_0068: br.s IL_006B
    IL_006D: ldfld 0x04000946
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000944
    IL_0074: ldarg.0
    IL_0079: ldfld 0x0400095D
    IL_007A: ldarg.0
    IL_007F: ldfld 0x0400096F
    IL_0080: conv.r8
    IL_0081: ldc.i4.8
    IL_0082: nop
    IL_0083: nop
    IL_0084: ldloc.0
    IL_0085: ldarg.0
    IL_008A: ldfld 0x0400095D
    IL_008F: brfalse IL_00B1
    IL_0090: ldarg.0
    IL_0095: ldfld 0x04000937
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000952
    IL_009C: conv.r8
    IL_009D: ldloc.3
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000937
    IL_00A7: conv.r8
    IL_00A8: stloc.2
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: stloc.0
    IL_00AC: conv.r8
    IL_00AD: IL_B9
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: stloc.0
    IL_00B1: ldarg.0
    IL_00B2: dup
    IL_00B7: ldfld 0x04000935
    IL_00B8: ldc.i4.1
    IL_00B9: IL_58
    IL_00BE: stfld 0x04000935
    IL_00BF: ldarg.0
    IL_00C0: dup
    IL_00C5: ldfld 0x0400093A
    IL_00C6: ldc.i4.1
    IL_00C7: IL_59
    IL_00CC: stfld 0x0400093A
    IL_00CD: ldloc.0
    IL_00CE: ldc.i4.1
    IL_00CF: IL_58
    IL_00D0: stloc.0
    IL_00D1: ldloc.0
    IL_00D2: ldc.i4.3
    IL_00D3: IL_3F
    IL_00D8: brtrue IL_30000D8
    IL_00D9: ldc.i4.1
    IL_00DE: stfld 0x0400093C
    IL_00DF: ldarg.0
    IL_00E0: ldc.i4.0
    IL_00E5: stfld 0x04000942
    IL_00EA: br IL_0414
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x0400093C
    IL_00F1: ldc.i4.0
    IL_00F2: IL_3E
    IL_00F3: IL_B8
    IL_00F4: ldarg.0
    IL_00F5: nop
    IL_00F6: nop
    IL_00F7: ldarg.0
    IL_00FC: ldfld 0x0400093F
    IL_00FD: IL_22
    IL_00FE: nop
    IL_00FF: nop
    IL_0100: nop
    IL_0101: nop
    IL_0102: IL_43
    IL_0103: ldc.i4.1
    IL_0104: nop
    IL_0105: nop
    IL_0106: nop
    IL_0107: ldarg.0
    IL_0108: dup
    IL_010D: ldfld 0x0400093F
    IL_0112: call 0x0A000024
    IL_0113: IL_59
    IL_0118: stfld 0x0400093F
    IL_011D: br IL_03AA
    IL_011E: ldarg.0
    IL_0123: ldfld 0x0400093A
    IL_0124: ldc.i4.0
    IL_0125: IL_3E
    IL_0126: IL_29
    IL_0127: IL_01
    IL_0128: nop
    IL_0129: nop
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000935
    IL_0130: ldarg.0
    IL_0135: ldfld 0x0400093B
    IL_0136: IL_3C
    IL_0138: stloc.s 1
    IL_0139: nop
    IL_013A: nop
    IL_013B: ldarg.0
    IL_013C: ldarg.0
    IL_0141: call 0x060004F4
    IL_0146: stfld 0x04000952
    IL_0147: ldarg.0
    IL_0148: ldc.i4.0
    IL_014A: ldc.i4.s 100
    IL_014F: call 0x0A000045
    IL_0154: stfld 0x0400094B
    IL_0155: ldarg.0
    IL_015A: ldfld 0x0400094B
    IL_015C: ldc.i4.s 45
    IL_015D: IL_3C
    IL_015E: stloc.2
    IL_015F: nop
    IL_0160: nop
    IL_0161: nop
    IL_0162: ldarg.0
    IL_0163: ldc.i4.0
    IL_0168: stfld 0x0400094B
    IL_016D: br IL_018E
    IL_016E: ldarg.0
    IL_0173: ldfld 0x0400094B
    IL_0175: ldc.i4.s 80
    IL_0176: IL_3C
    IL_0177: stloc.2
    IL_0178: nop
    IL_0179: nop
    IL_017A: nop
    IL_017B: ldarg.0
    IL_017C: ldc.i4.1
    IL_0181: stfld 0x0400094B
    IL_0186: br IL_018E
    IL_0187: ldarg.0
    IL_0188: ldc.i4.2
    IL_018D: stfld 0x0400094B
    IL_018E: ldarg.0
    IL_018F: ldarg.0
    IL_0194: ldfld 0x04000931
    IL_0195: ldarg.0
    IL_019A: ldfld 0x0400094B
    IL_019B: ldelem.i
    IL_01A0: stfld 0x0400092C
    IL_01A1: ldarg.0
    IL_01A2: ldarg.0
    IL_01A7: ldfld 0x0400092C
    IL_01A8: ldarg.0
    IL_01AD: ldfld 0x04000952
    IL_01B2: call 0x0A000013
    IL_01B7: call 0x0A000014
    IL_01B8: conv.u4
    IL_01B9: ldarg.1
    IL_01BA: nop
    IL_01BB: nop
    IL_01BC: IL_01
    IL_01C1: stfld 0x0400092D
    IL_01C2: ldarg.0
    IL_01C7: ldfld 0x0400092D
    IL_01CC: ldstr 0x70022ECD
    IL_01CD: conv.r8
    IL_01CE: IL_DC
    IL_01CF: IL_01
    IL_01D0: nop
    IL_01D1: stloc.0
    IL_01D2: ldarg.0
    IL_01D7: ldfld 0x0400092D
    IL_01D8: conv.r8
    IL_01D9: ldc.i4.8
    IL_01DA: nop
    IL_01DB: nop
    IL_01DD: br.s IL_01E0
    IL_01E2: ldfld 0x04000946
    IL_01E3: ldarg.0
    IL_01E8: ldfld 0x04000944
    IL_01E9: ldarg.0
    IL_01EE: ldfld 0x0400095D
    IL_01EF: ldarg.0
    IL_01F4: ldfld 0x0400096F
    IL_01F5: conv.r8
    IL_01F6: ldc.i4.8
    IL_01F7: nop
    IL_01F8: nop
    IL_01F9: ldloc.0
    IL_01FA: ldarg.0
    IL_01FF: ldfld 0x0400095D
    IL_0204: brfalse IL_0226
    IL_0205: ldarg.0
    IL_020A: ldfld 0x04000937
    IL_020B: ldarg.0
    IL_0210: ldfld 0x04000952
    IL_0211: conv.r8
    IL_0212: ldloc.3
    IL_0213: nop
    IL_0214: nop
    IL_0215: stloc.0
    IL_0216: ldarg.0
    IL_021B: ldfld 0x04000937
    IL_021C: conv.r8
    IL_021D: stloc.2
    IL_021E: nop
    IL_021F: nop
    IL_0220: stloc.0
    IL_0221: conv.r8
    IL_0222: IL_B9
    IL_0223: nop
    IL_0224: nop
    IL_0225: stloc.0
    IL_0226: ldarg.0
    IL_0227: dup
    IL_022C: ldfld 0x04000935
    IL_022D: ldc.i4.1
    IL_022E: IL_58
    IL_0233: stfld 0x04000935
    IL_0234: ldarg.0
    IL_0235: dup
    IL_023A: ldfld 0x0400093A
    IL_023B: ldc.i4.1
    IL_023C: IL_59
    IL_0241: stfld 0x0400093A
    IL_0242: ldarg.0
    IL_0243: ldarg.0
    IL_0248: ldfld 0x04000940
    IL_024D: stfld 0x0400093F
    IL_0252: br IL_03AA
    IL_0253: ldarg.0
    IL_0258: ldfld 0x0400093A
    IL_0259: ldc.i4.0
    IL_025A: IL_3D
    IL_025B: localloc
    IL_025C: IL_01
    IL_025D: nop
    IL_025E: nop
    IL_025F: ldarg.0
    IL_0264: ldfld 0x0400093D
    IL_0265: ldarg.0
    IL_026A: ldfld 0x0400093E
    IL_026B: IL_3F
    IL_026C: throw
    IL_026D: nop
    IL_026E: nop
    IL_026F: nop
    IL_0270: ldarg.0
    IL_0275: ldfld 0x04000945
    IL_0276: ldc.i4.0
    IL_0277: IL_3E
    IL_0278: rem.un
    IL_0279: nop
    IL_027A: nop
    IL_027B: nop
    IL_027C: ldarg.0
    IL_027D: IL_22
    IL_027E: nop
    IL_027F: nop
    IL_0284: stsfld 0x093F7D3F
    IL_0285: nop
    IL_0286: ldarg.2
    IL_0287: ldarg.0
    IL_0288: ldarg.0
    IL_028D: ldfld 0x04000969
    IL_028E: ldarg.0
    IL_0293: ldfld 0x0400095E
    IL_0298: ldfld 0x04000512
    IL_0299: ldarg.0
    IL_029E: ldfld 0x04000947
    IL_029F: IL_8F
    IL_02A0: not
    IL_02A1: nop
    IL_02A2: nop
    IL_02A3: ldarg.0
    IL_02A8: ldfld 0x04000507
    IL_02A9: ldarg.0
    IL_02AE: ldfld 0x04000945
    IL_02AF: IL_59
    IL_02B0: IL_92
    IL_02B5: call 0x060004FD
    IL_02B6: ldarg.0
    IL_02B7: dup
    IL_02BC: ldfld 0x04000945
    IL_02BD: ldc.i4.1
    IL_02BE: IL_59
    IL_02C3: stfld 0x04000945
    IL_02C4: ldarg.0
    IL_02C9: ldfld 0x04000945
    IL_02CA: ldc.i4.0
    IL_02CB: IL_3D
    IL_02CC: ldloc.2
    IL_02CD: nop
    IL_02CE: nop
    IL_02CF: nop
    IL_02D0: ldarg.0
    IL_02D2: ldc.i4.s -2
    IL_02D7: stfld 0x0400093C
    IL_02DC: br IL_02E5
    IL_02DD: ldarg.0
    IL_02DF: ldc.i4.s -2
    IL_02E4: stfld 0x0400093C
    IL_02E9: br IL_03AA
    IL_02EA: ldarg.0
    IL_02EF: ldfld 0x0400095D
    IL_02F4: brfalse IL_03A2
    IL_02F5: ldarg.0
    IL_02FA: ldfld 0x04000945
    IL_02FB: ldc.i4.0
    IL_02FC: IL_3E
    IL_02FD: conv.u8
    IL_02FE: nop
    IL_02FF: nop
    IL_0300: nop
    IL_0301: ldarg.0
    IL_0302: ldarg.0
    IL_0307: ldfld 0x04000969
    IL_0308: ldarg.0
    IL_030D: ldfld 0x0400095E
    IL_0312: ldfld 0x04000512
    IL_0313: ldarg.0
    IL_0318: ldfld 0x04000947
    IL_0319: IL_8F
    IL_031A: not
    IL_031B: nop
    IL_031C: nop
    IL_031D: ldarg.0
    IL_0322: ldfld 0x04000507
    IL_0323: ldarg.0
    IL_0328: ldfld 0x04000945
    IL_0329: IL_59
    IL_032A: IL_92
    IL_032F: call 0x060004FD
    IL_0330: ldarg.0
    IL_0331: dup
    IL_0336: ldfld 0x04000945
    IL_0337: ldc.i4.1
    IL_0338: IL_59
    IL_033D: stfld 0x04000945
    IL_033E: ldarg.0
    IL_0343: ldfld 0x04000945
    IL_0344: ldc.i4.0
    IL_0345: IL_3D
    IL_0346: IL_27
    IL_0347: nop
    IL_0348: nop
    IL_0349: nop
    IL_034A: ldarg.0
    IL_034B: ldarg.0
    IL_0350: ldfld 0x04000946
    IL_0351: ldc.i4.3
    IL_0352: IL_58
    IL_0353: neg
    IL_0358: stfld 0x04000946
    IL_0359: ldarg.0
    IL_035A: ldarg.0
    IL_035F: ldfld 0x04000946
    IL_0361: ldc.i4.s 90
    IL_0362: mul
    IL_0363: neg
    IL_0368: stfld 0x04000947
    IL_0369: ldarg.0
    IL_036B: ldc.i4.s -2
    IL_0370: stfld 0x0400093C
    IL_0375: br IL_039D
    IL_0376: ldarg.0
    IL_0377: ldarg.0
    IL_037C: ldfld 0x04000946
    IL_037D: ldc.i4.3
    IL_037E: IL_58
    IL_037F: neg
    IL_0384: stfld 0x04000946
    IL_0385: ldarg.0
    IL_0386: ldarg.0
    IL_038B: ldfld 0x04000946
    IL_038D: ldc.i4.s 90
    IL_038E: mul
    IL_038F: neg
    IL_0394: stfld 0x04000947
    IL_0395: ldarg.0
    IL_0397: ldc.i4.s -2
    IL_039C: stfld 0x0400093C
    IL_03A1: br IL_03AA
    IL_03A2: ldarg.0
    IL_03A4: ldc.i4.s -2
    IL_03A9: stfld 0x0400093C
    IL_03AE: br IL_0414
    IL_03AF: ldarg.0
    IL_03B4: ldfld 0x04000935
    IL_03B5: ldc.i4.5
    IL_03B6: IL_3D
    IL_03B7: IL_59
    IL_03B8: nop
    IL_03B9: nop
    IL_03BA: nop
    IL_03BB: ldarg.0
    IL_03C0: ldfld 0x04000942
    IL_03C5: brtrue IL_0414
    IL_03C6: ldc.i4.0
    IL_03C7: stloc.1
    IL_03CC: br IL_0401
    IL_03CD: ldarg.0
    IL_03D2: ldstr 0x70022ECD
    IL_03D7: call 0x0A000077
    IL_03DC: stfld 0x0400095C
    IL_03DD: ldarg.0
    IL_03E2: ldfld 0x0400095C
    IL_03E3: conv.r8
    IL_03E4: conv.r8
    IL_03E5: nop
    IL_03E6: nop
    IL_03E8: br.s IL_0458
    IL_03E9: IL_29
    IL_03EA: nop
    IL_03EB: nop
    IL_03EC: ldloc.0
    IL_03ED: ldarg.0
    IL_03F2: ldfld 0x0400095C
    IL_03F7: ldstr 0x70022ED9
    IL_03F8: conv.r8
    IL_03F9: IL_DC
    IL_03FA: IL_01
    IL_03FB: nop
    IL_03FC: stloc.0
    IL_03FD: ldloc.1
    IL_03FE: ldc.i4.1
    IL_03FF: IL_58
    IL_0400: stloc.1
    IL_0401: ldloc.1
    IL_0402: ldarg.0
    IL_0407: ldfld 0x04000935
    IL_0408: IL_3F
    IL_0409: IL_C0
    IL_040A: IL_FF
    IL_040B: IL_FF
    IL_040C: IL_FF
    IL_040D: ldarg.0
    IL_040E: ldc.i4.1
    IL_0413: stfld 0x04000942
    IL_0414: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x04000970
    IL_000C: ldarg.0
    IL_000D: ldc.i4.3
    IL_0012: newarr 0x01000003
    IL_0017: stfld 0x04000971
    IL_0018: ldarg.0
    IL_0019: ldc.i4.3
    IL_001E: newarr 0x01000003
    IL_0023: stfld 0x04000974
    IL_0024: ldarg.0
    IL_0025: ldc.i4.6
    IL_002A: newarr 0x01000003
    IL_002F: stfld 0x04000975
    IL_0030: ldarg.0
    IL_0031: ldc.i4.3
    IL_0036: stfld 0x04000977
    IL_0037: ldarg.0
    IL_0038: ldc.i4.3
    IL_003D: stfld 0x04000979
    IL_003E: ldarg.0
    IL_0040: ldc.i4.s 10
    IL_0045: stfld 0x0400097A
    IL_0046: ldarg.0
    IL_0047: ldc.i4.m1
    IL_004C: stfld 0x0400097B
    IL_004D: ldarg.0
    IL_004E: ldc.i4.m1
    IL_0053: stfld 0x04000981
    IL_0054: ldarg.0
    IL_0055: ldc.i4.8
    IL_005A: newarr 0x01000007
    IL_005F: stfld 0x04000984
    IL_0060: ldarg.0
    IL_0061: ldc.i4.3
    IL_0066: stfld 0x04000985
    IL_0067: ldarg.0
    IL_0068: ldc.i4.m1
    IL_006D: stfld 0x04000986
    IL_006E: ldarg.0
    IL_0073: call 0x0A000001
    IL_0074: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700004DD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000986
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000986
    IL_0016: ldc.i4.m1
    IL_001B: beq IL_0023
    IL_001C: ldarg.0
    IL_001D: ldc.i4.0
    IL_0022: stfld 0x0400097A
    IL_0023: ret
    }

    private void Start() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0069
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000975
    IL_000D: ldloc.0
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000971
    IL_0014: ldloc.0
    IL_0015: ldelem.i
    IL_001A: call 0x0A00004B
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_C0
    IL_20C3: switch (2088 cases)
    }

    public void StoryEnemyDead() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000985
    IL_0007: ldc.i4.1
    IL_0008: IL_59
    IL_000D: stfld 0x04000985
    IL_000E: ret
    }

    public void EnemyDead() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400097E
    IL_000A: brtrue IL_0033
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000986
    IL_0011: ldc.i4.m1
    IL_006A: switch (21 cases)
    IL_006B: nop
    IL_006C: nop
    IL_151A2D: switch (345711 cases)
    }

    public void RegenStart() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x0400097B
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002B
    IL_000E: ldloc.0
    IL_000F: ldarg.0
    IL_0014: ldfld 0x0400097F
    IL_0015: IL_58
    IL_0016: stloc.1
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000974
    IL_001D: ldloc.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000970
    IL_0024: ldloc.1
    IL_0025: ldelem.i
    IL_002A: stelem 0x0A581706
    IL_002B: ldloc.0
    IL_002C: ldc.i4.3
    IL_002D: IL_3F
    IL_002E: IL_DC
    IL_002F: IL_FF
    IL_0030: IL_FF
    IL_0031: IL_FF
    IL_0032: ret
    }

    public void SetRndPoint() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.8
    IL_0007: call 0x0A000045
    IL_000C: stfld 0x04000980
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000980
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000981
    IL_005D: switch (16 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400097B
    IL_0006: ldc.i4.0
    IL_0007: IL_3F
    IL_0008: ldloc.3
    IL_0009: IL_01
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_0011: ldfld 0x0400097C
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_0017: IL_43
    IL_0018: ldc.i4.1
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.0
    IL_001D: dup
    IL_0022: ldfld 0x0400097C
    IL_0027: call 0x0A000024
    IL_0028: IL_59
    IL_002D: stfld 0x0400097C
    IL_0032: br IL_0110
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400097A
    IL_0039: ldc.i4.0
    IL_003A: IL_3E
    IL_003B: IL_BD
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_003F: ldarg.0
    IL_0044: ldfld 0x0400097C
    IL_0045: IL_22
    IL_0046: nop
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: IL_42
    IL_004B: IL_AD
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: ldarg.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000984
    IL_0056: ldarg.0
    IL_005B: call 0x0600050E
    IL_005C: IL_8F
    IL_005D: ldloc.1
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_01
    IL_0065: ldobj 0x01000007
    IL_006A: stfld 0x04000982
    IL_006B: ldc.i4.0
    IL_006C: ldc.i4.6
    IL_0071: call 0x0A000045
    IL_0072: stloc.0
    IL_0073: ldloc.0
    IL_0074: ldc.i4.2
    IL_0075: IL_3D
    IL_0076: ldloc.1
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldc.i4.0
    IL_007B: stloc.0
    IL_0080: br IL_0091
    IL_0081: ldloc.0
    IL_0082: ldc.i4.4
    IL_0083: IL_3D
    IL_0084: ldloc.1
    IL_0085: nop
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldc.i4.1
    IL_0089: stloc.0
    IL_008E: br IL_0091
    IL_008F: ldc.i4.2
    IL_0090: stloc.0
    IL_0091: ldarg.0
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000974
    IL_0098: ldloc.0
    IL_0099: ldelem.i
    IL_009E: stfld 0x04000972
    IL_009F: ldarg.0
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000972
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x04000982
    IL_00B0: call 0x0A000013
    IL_00B5: call 0x0A000014
    IL_00B6: conv.u4
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: IL_01
    IL_00BF: stfld 0x04000973
    IL_00C0: ldarg.0
    IL_00C5: ldfld 0x04000973
    IL_00CA: ldstr 0x70022ECD
    IL_00CB: conv.r8
    IL_00CC: IL_DC
    IL_00CD: IL_01
    IL_00CE: nop
    IL_00CF: stloc.0
    IL_00D0: ldarg.0
    IL_00D1: dup
    IL_00D6: ldfld 0x04000977
    IL_00D7: ldc.i4.1
    IL_00D8: IL_58
    IL_00DD: stfld 0x04000977
    IL_00DE: ldarg.0
    IL_00DF: dup
    IL_00E4: ldfld 0x0400097A
    IL_00E5: ldc.i4.1
    IL_00E6: IL_59
    IL_00EB: stfld 0x0400097A
    IL_00EC: ldarg.0
    IL_00ED: IL_22
    IL_00EE: IL_CD
    IL_00EF: IL_CC
    IL_00F0: IL_4C
    IL_00F1: IL_3E
    IL_00F6: stfld 0x0400097C
    IL_00FB: br IL_0110
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x0400097A
    IL_0102: ldc.i4.0
    IL_0103: IL_3D
    IL_0104: ldloc.2
    IL_0105: nop
    IL_0106: nop
    IL_0107: nop
    IL_0108: ldarg.0
    IL_010A: ldc.i4.s -2
    IL_010F: stfld 0x0400097B
    IL_0114: br IL_0195
    IL_0115: ldarg.0
    IL_011A: ldfld 0x04000977
    IL_011B: ldc.i4.5
    IL_011C: ldarg.0
    IL_0121: ldfld 0x04000985
    IL_0122: IL_58
    IL_0123: IL_3D
    IL_0124: conv.i8
    IL_0125: nop
    IL_0126: nop
    IL_0127: nop
    IL_0128: ldarg.0
    IL_012D: ldfld 0x0400097D
    IL_0132: brtrue IL_0195
    IL_0133: ldarg.0
    IL_0138: ldfld 0x0400097B
    IL_013A: ldc.i4.s -2
    IL_0293: switch (85 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.7
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x0400098A
    IL_000C: ldarg.0
    IL_000D: ldc.i4.1
    IL_0012: stfld 0x04000990
    IL_0013: ldarg.0
    IL_0018: call 0x0A000001
    IL_0019: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000988
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000989
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000001
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: ldarg.3
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x0400098F
    IL_002D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00003D
    IL_0007: conv.r8
    IL_000A: ldarga 0
    IL_000B: stloc.0
    IL_0010: stfld 0x0400098D
    IL_0011: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000989
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0016: stfld 0x0400098E
    IL_0017: ldarg.0
    IL_0018: ldc.i4.0
    IL_001D: stfld 0x0400098C
    IL_001E: ldarg.0
    IL_001F: ldc.i4.0
    IL_0024: stfld 0x0400098B
    IL_0025: ldarg.0
    IL_0026: ldc.i4.0
    IL_002B: stfld 0x04000991
    IL_002C: ldarg.0
    IL_002D: ldc.i4.0
    IL_0032: stfld 0x04000990
    IL_0033: ret
    }

    public void Init() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000989
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0016: stfld 0x0400098E
    IL_0017: ldarg.0
    IL_0018: ldc.i4.0
    IL_001D: stfld 0x0400098C
    IL_001E: ldarg.0
    IL_001F: ldc.i4.0
    IL_0024: stfld 0x0400098B
    IL_0025: ldarg.0
    IL_0026: ldc.i4.0
    IL_002B: stfld 0x04000991
    IL_002C: ldarg.0
    IL_002D: ldc.i4.0
    IL_0032: stfld 0x04000990
    IL_0033: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.8
    IL_02B4: switch (169 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000991
    IL_000A: brtrue IL_0263
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400098E
    IL_0011: IL_22
    IL_0012: IL_CD
    IL_0013: IL_CC
    IL_0014: IL_CC
    IL_0015: IL_3D
    IL_0016: IL_43
    IL_0018: ble.s IL_001B
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0025: stfld 0x0400098E
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400098A
    IL_002C: ldarg.0
    IL_0031: ldfld 0x0400098C
    IL_0032: ldelem.i
    IL_0033: ldnull
    IL_0038: call 0x0A000061
    IL_003D: brfalse IL_0125
    IL_003E: ldarg.0
    IL_0043: ldfld 0x0400098A
    IL_0044: ldarg.0
    IL_0049: ldfld 0x0400098C
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000987
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000988
    IL_0056: conv.r8
    IL_0057: ldc.i4.2
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: IL_22
    IL_005C: nop
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0061: ldc.i4.s 30
    IL_0062: ldarg.0
    IL_0067: ldfld 0x0400098C
    IL_0068: IL_5A
    IL_0069: conv.i2
    IL_006A: ldarg.0
    IL_006F: ldfld 0x04000988
    IL_0070: conv.r8
    IL_0071: div.un
    IL_0072: nop
    IL_0073: nop
    IL_0074: stloc.0
    IL_0075: stloc.0
    IL_0077: ldloca.s 0
    IL_007C: ldfld 0x0A000023
    IL_007D: IL_58
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: IL_87
    IL_0082: IL_43
    IL_0083: IL_59
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_0087: nop
    IL_0088: nop
    IL_008D: call 0x0A000060
    IL_0092: call 0x0A000014
    IL_0093: conv.u4
    IL_0094: ldarg.1
    IL_0095: nop
    IL_0096: nop
    IL_0097: IL_01
    IL_009C: stelem 0x098A7B02
    IL_009D: nop
    IL_009E: ldarg.2
    IL_009F: ldarg.0
    IL_00A4: ldfld 0x0400098C
    IL_00A5: ldelem.i
    IL_00A6: conv.r8
    IL_00A7: IL_3D
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x0400098D
    IL_00B1: conv.r8
    IL_00B2: IL_84
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x0400098A
    IL_00BC: ldarg.0
    IL_00C1: ldfld 0x0400098C
    IL_00C2: ldelem.i
    IL_00C3: dup
    IL_00C4: conv.r8
    IL_00C5: ldc.i4.2
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: stloc.0
    IL_00C9: ldarg.0
    IL_00CE: ldfld 0x0400098A
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x0400098C
    IL_00D5: ldelem.i
    IL_00D6: conv.r8
    IL_00D7: IL_22
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: stloc.0
    IL_00DB: IL_22
    IL_00DC: IL_CD
    IL_00DD: IL_CC
    IL_00DE: IL_CC
    IL_00DF: IL_3D
    IL_00E4: call 0x0A000008
    IL_00E9: call 0x0A000029
    IL_00EA: conv.r8
    IL_00EB: ldloc.3
    IL_00EC: nop
    IL_00ED: nop
    IL_00EE: stloc.0
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x0400098A
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x0400098C
    IL_00FB: ldelem.i
    IL_0100: call 0x0A000007
    IL_0101: ldarg.0
    IL_0106: ldfld 0x04000988
    IL_0107: conv.r8
    IL_0108: IL_22
    IL_0109: nop
    IL_010A: nop
    IL_010B: stloc.0
    IL_010C: IL_22
    IL_010D: ldelem.i
    IL_010E: IL_99
    IL_010F: ldc.i4.3
    IL_0110: IL_3F
    IL_0115: call 0x0A000008
    IL_011A: call 0x0A000029
    IL_011B: conv.r8
    IL_0120: ldc.i4 940179456
    IL_0121: IL_E4
    IL_0122: nop
    IL_0123: nop
    IL_0124: nop
    IL_0125: ldarg.0
    IL_012A: ldfld 0x0400098A
    IL_012B: ldarg.0
    IL_0130: ldfld 0x0400098C
    IL_0131: ldelem.i
    IL_0132: ldarg.0
    IL_0137: ldfld 0x04000988
    IL_0138: conv.r8
    IL_0139: ldc.i4.2
    IL_013A: nop
    IL_013B: nop
    IL_013C: stloc.0
    IL_013D: conv.r8
    IL_013E: ldloc.3
    IL_013F: nop
    IL_0140: nop
    IL_0141: stloc.0
    IL_0142: ldarg.0
    IL_0147: ldfld 0x0400098A
    IL_0148: ldarg.0
    IL_014D: ldfld 0x0400098C
    IL_014E: ldelem.i
    IL_014F: IL_22
    IL_0150: nop
    IL_0151: nop
    IL_0152: nop
    IL_0153: nop
    IL_0155: ldc.i4.s 30
    IL_0156: ldarg.0
    IL_015B: ldfld 0x0400098C
    IL_015C: IL_5A
    IL_015D: conv.i2
    IL_015E: ldarg.0
    IL_0163: ldfld 0x04000988
    IL_0164: conv.r8
    IL_0165: div.un
    IL_0166: nop
    IL_0167: nop
    IL_0168: stloc.0
    IL_0169: stloc.1
    IL_016B: ldloca.s 1
    IL_0170: ldfld 0x0A000023
    IL_0171: IL_58
    IL_0172: IL_22
    IL_0173: nop
    IL_0174: nop
    IL_0175: IL_87
    IL_0176: IL_43
    IL_0177: IL_59
    IL_0178: IL_22
    IL_0179: nop
    IL_017A: nop
    IL_017B: nop
    IL_017C: nop
    IL_0181: call 0x0A000060
    IL_0182: conv.r8
    IL_0187: call 0x020A0000
    IL_018C: ldfld 0x0400098A
    IL_018D: ldarg.0
    IL_0192: ldfld 0x0400098C
    IL_0193: ldelem.i
    IL_0194: conv.r8
    IL_0195: stloc.0
    IL_0196: nop
    IL_0197: nop
    IL_0198: stloc.0
    IL_0199: ldc.i4.1
    IL_019A: conv.r8
    IL_019B: stloc.1
    IL_019C: nop
    IL_019D: nop
    IL_019E: stloc.0
    IL_019F: ldarg.0
    IL_01A4: ldfld 0x0400098A
    IL_01A5: ldarg.0
    IL_01AA: ldfld 0x0400098C
    IL_01AB: ldelem.i
    IL_01AC: dup
    IL_01AD: conv.r8
    IL_01AE: ldc.i4.2
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: stloc.0
    IL_01B2: ldarg.0
    IL_01B7: ldfld 0x0400098A
    IL_01B8: ldarg.0
    IL_01BD: ldfld 0x0400098C
    IL_01BE: ldelem.i
    IL_01BF: conv.r8
    IL_01C0: IL_22
    IL_01C1: nop
    IL_01C2: nop
    IL_01C3: stloc.0
    IL_01C4: IL_22
    IL_01C5: IL_CD
    IL_01C6: IL_CC
    IL_01C7: IL_CC
    IL_01C8: IL_3D
    IL_01CD: call 0x0A000008
    IL_01D2: call 0x0A000029
    IL_01D3: conv.r8
    IL_01D4: ldloc.3
    IL_01D5: nop
    IL_01D6: nop
    IL_01D7: stloc.0
    IL_01D8: ldarg.0
    IL_01DD: ldfld 0x0400098A
    IL_01DE: ldarg.0
    IL_01E3: ldfld 0x0400098C
    IL_01E4: ldelem.i
    IL_01E9: call 0x0A000007
    IL_01EA: ldarg.0
    IL_01EF: ldfld 0x04000988
    IL_01F0: conv.r8
    IL_01F1: IL_22
    IL_01F2: nop
    IL_01F3: nop
    IL_01F4: stloc.0
    IL_01F5: IL_22
    IL_01F6: ldelem.i
    IL_01F7: IL_99
    IL_01F8: ldc.i4.3
    IL_01F9: IL_3F
    IL_01FE: call 0x0A000008
    IL_0203: call 0x0A000029
    IL_0204: conv.r8
    IL_0209: ldc.i4 34209792
    IL_020E: ldfld 0x0400098A
    IL_020F: ldarg.0
    IL_0214: ldfld 0x0400098C
    IL_0215: ldelem.i
    IL_0216: ldarg.0
    IL_021B: ldfld 0x04000988
    IL_021C: conv.r8
    IL_021D: IL_4E
    IL_021E: nop
    IL_021F: nop
    IL_0220: stloc.0
    IL_0221: ldarg.0
    IL_0226: ldfld 0x0400098C
    IL_0227: ldc.i4.6
    IL_0228: IL_3C
    IL_022A: stloc.s 0
    IL_022B: nop
    IL_022C: nop
    IL_022D: ldarg.0
    IL_022E: dup
    IL_0233: ldfld 0x0400098C
    IL_0234: ldc.i4.1
    IL_0235: IL_58
    IL_023A: stfld 0x0400098C
    IL_023F: br IL_0247
    IL_0240: ldarg.0
    IL_0241: ldc.i4.1
    IL_0246: stfld 0x04000991
    IL_024B: br IL_025E
    IL_024C: ldarg.0
    IL_024D: dup
    IL_0252: ldfld 0x0400098E
    IL_0257: call 0x0A000024
    IL_0258: IL_58
    IL_025D: stfld 0x0400098E
    IL_0262: br IL_02FE
    IL_0263: ldarg.0
    IL_0268: ldfld 0x0400098E
    IL_0269: IL_22
    IL_026A: IL_CD
    IL_026B: IL_CC
    IL_026C: IL_CC
    IL_026D: IL_3E
    IL_026E: IL_43
    IL_026F: IL_23
    IL_0270: nop
    IL_0271: nop
    IL_0272: nop
    IL_0273: ldarg.0
    IL_0274: ldc.i4.0
    IL_0279: stfld 0x04000990
    IL_027A: ldarg.0
    IL_027F: ldfld 0x04000989
    IL_0280: ldc.i4.1
    IL_0281: conv.r8
    IL_0283: ldc.i4.s 0
    IL_0284: nop
    IL_0285: stloc.0
    IL_0286: ldarg.0
    IL_0287: IL_22
    IL_0288: nop
    IL_0289: nop
    IL_028E: stsfld 0x098E7DBF
    IL_028F: nop
    IL_0290: ldarg.2
    IL_0295: br IL_02FE
    IL_0296: ldarg.0
    IL_029B: ldfld 0x0400098E
    IL_029C: IL_22
    IL_029D: nop
    IL_029E: nop
    IL_02A3: stsfld 0x001743BF
    IL_02A4: nop
    IL_02A5: nop
    IL_02A6: ldarg.0
    IL_02A7: dup
    IL_02AC: ldfld 0x0400098E
    IL_02B1: call 0x0A000024
    IL_02B2: IL_58
    IL_02B7: stfld 0x0400098E
    IL_02BC: br IL_02FE
    IL_02BD: ldarg.0
    IL_02BE: dup
    IL_02C3: ldfld 0x0400098E
    IL_02C8: call 0x0A000024
    IL_02C9: IL_59
    IL_02CE: stfld 0x0400098E
    IL_02CF: ldarg.0
    IL_02D4: ldfld 0x0400098E
    IL_02D5: IL_22
    IL_02D6: nop
    IL_02D7: nop
    IL_02D8: nop
    IL_02D9: IL_C0
    IL_02DA: IL_41
    IL_02DC: ldc.i4.s 0
    IL_02DD: nop
    IL_02DE: nop
    IL_02DF: ldarg.0
    IL_02E4: ldfld 0x04000989
    IL_02E5: ldc.i4.0
    IL_02E6: conv.r8
    IL_02E8: ldc.i4.s 0
    IL_02E9: nop
    IL_02EA: stloc.0
    IL_02EB: ldarg.0
    IL_02F0: ldfld 0x04000989
    IL_02F1: ldc.i4.1
    IL_02F2: conv.r8
    IL_02F4: ldc.i4.s 0
    IL_02F5: nop
    IL_02F6: stloc.0
    IL_02F7: ldarg.0
    IL_02F8: ldnull
    IL_02FD: stfld 0x04000992
    IL_02FE: ldarg.0
    IL_0303: ldfld 0x04000988
    IL_0304: ldarg.0
    IL_0309: ldfld 0x0400098F
    IL_030A: conv.r8
    IL_030B: ldc.i4.2
    IL_030C: nop
    IL_030D: nop
    IL_030E: stloc.0
    IL_0313: call 0x0A000007
    IL_0314: IL_22
    IL_0315: IL_CD
    IL_0316: IL_CC
    IL_0317: IL_4C
    IL_0318: IL_3E
    IL_031D: call 0x0A000008
    IL_0322: call 0x0A000029
    IL_0323: conv.r8
    IL_0324: ldloc.3
    IL_0325: nop
    IL_0326: nop
    IL_0327: stloc.0
    IL_0328: ldarg.0
    IL_032D: ldfld 0x04000988
    IL_032E: ldarg.0
    IL_0333: ldfld 0x04000988
    IL_0334: conv.r8
    IL_0335: pop
    IL_0336: nop
    IL_0337: nop
    IL_0338: stloc.0
    IL_0339: ldarg.0
    IL_033E: ldfld 0x0400098F
    IL_033F: conv.r8
    IL_0340: pop
    IL_0341: nop
    IL_0342: nop
    IL_0343: stloc.0
    IL_0348: call 0x0A000024
    IL_0349: IL_22
    IL_034A: nop
    IL_034B: nop
    IL_9CA16C50: switch (656955968 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x04000996
    IL_000C: ldarg.0
    IL_000D: ldc.i4.1
    IL_0012: stfld 0x0400099C
    IL_0013: ldarg.0
    IL_0018: call 0x0A000001
    IL_0019: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000994
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000995
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000001
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: ldarg.3
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x0400099B
    IL_002D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00003D
    IL_0007: conv.r8
    IL_000A: ldarga 0
    IL_000B: stloc.0
    IL_0010: stfld 0x04000999
    IL_0011: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000995
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0016: stfld 0x0400099A
    IL_0017: ldarg.0
    IL_0018: ldc.i4.0
    IL_001D: stfld 0x04000998
    IL_001E: ldarg.0
    IL_001F: ldc.i4.0
    IL_0024: stfld 0x04000997
    IL_0025: ldarg.0
    IL_0026: ldc.i4.0
    IL_002B: stfld 0x0400099D
    IL_002C: ldarg.0
    IL_002D: ldc.i4.0
    IL_0032: stfld 0x0400099C
    IL_0033: ldarg.0
    IL_0034: ldc.i4.0
    IL_0039: stfld 0x0400099F
    IL_003A: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.8
    IL_03A4: switch (229 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400099D
    IL_000A: brtrue IL_01A1
    IL_000B: ldarg.0
    IL_0010: ldfld 0x0400099A
    IL_0011: IL_22
    IL_0012: IL_CD
    IL_0013: IL_CC
    IL_0014: IL_4C
    IL_0015: IL_3E
    IL_0016: IL_43
    IL_0017: conv.r8
    IL_0018: IL_01
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0025: stfld 0x0400099A
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000996
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000998
    IL_0032: ldelem.i
    IL_0033: ldnull
    IL_0038: call 0x0A000061
    IL_003D: brfalse IL_00DC
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000996
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000998
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000993
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000994
    IL_0056: conv.r8
    IL_0057: ldc.i4.2
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000994
    IL_0061: conv.r8
    IL_0062: pop
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_006A: call 0x0A000014
    IL_006B: conv.u4
    IL_006C: ldarg.1
    IL_006D: nop
    IL_006E: nop
    IL_006F: IL_01
    IL_0074: stelem 0x09967B02
    IL_0075: nop
    IL_0076: ldarg.2
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000998
    IL_007D: ldelem.i
    IL_007E: conv.r8
    IL_007F: IL_3D
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000999
    IL_0089: conv.r8
    IL_008A: IL_84
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: ldarg.0
    IL_0093: ldfld 0x04000996
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000998
    IL_009A: ldelem.i
    IL_009F: call 0x0A000007
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000994
    IL_00A6: conv.r8
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_22
    IL_00AC: ldelem.i
    IL_00AD: IL_99
    IL_00AE: ldc.i4.3
    IL_00AF: IL_3F
    IL_00B4: call 0x0A000008
    IL_00B9: call 0x0A000029
    IL_00BA: conv.r8
    IL_00BF: ldc.i4 34209792
    IL_00C4: ldfld 0x04000996
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04000998
    IL_00CB: ldelem.i
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x04000994
    IL_00D2: conv.r8
    IL_00D3: IL_4E
    IL_00D4: nop
    IL_00D5: nop
    IL_00D6: stloc.0
    IL_00DB: br IL_015F
    IL_00DC: ldarg.0
    IL_00E1: ldfld 0x04000996
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x04000998
    IL_00E8: ldelem.i
    IL_00E9: ldarg.0
    IL_00EE: ldfld 0x04000994
    IL_00EF: conv.r8
    IL_00F0: ldc.i4.2
    IL_00F1: nop
    IL_00F2: nop
    IL_00F3: stloc.0
    IL_00F4: conv.r8
    IL_00F5: ldloc.3
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: stloc.0
    IL_00F9: ldarg.0
    IL_00FE: ldfld 0x04000996
    IL_00FF: ldarg.0
    IL_0104: ldfld 0x04000998
    IL_0105: ldelem.i
    IL_0106: ldarg.0
    IL_010B: ldfld 0x04000994
    IL_010C: conv.r8
    IL_010D: pop
    IL_010E: nop
    IL_010F: nop
    IL_0110: stloc.0
    IL_0111: conv.r8
    IL_0116: call 0x020A0000
    IL_011B: ldfld 0x04000996
    IL_011C: ldarg.0
    IL_0121: ldfld 0x04000998
    IL_0122: ldelem.i
    IL_0123: conv.r8
    IL_0124: stloc.0
    IL_0125: nop
    IL_0126: nop
    IL_0127: stloc.0
    IL_0128: ldc.i4.1
    IL_0129: conv.r8
    IL_012A: stloc.1
    IL_012B: nop
    IL_012C: nop
    IL_012D: stloc.0
    IL_012E: ldarg.0
    IL_0133: ldfld 0x04000996
    IL_0134: ldarg.0
    IL_0139: ldfld 0x04000998
    IL_013A: ldelem.i
    IL_013F: call 0x0A000007
    IL_0140: ldarg.0
    IL_0145: ldfld 0x04000994
    IL_0146: conv.r8
    IL_0147: IL_22
    IL_0148: nop
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: IL_22
    IL_014C: ldelem.i
    IL_014D: IL_99
    IL_014E: ldc.i4.3
    IL_014F: IL_3F
    IL_0154: call 0x0A000008
    IL_0159: call 0x0A000029
    IL_015A: conv.r8
    IL_015F: ldc.i4 34209792
    IL_0164: ldfld 0x04000998
    IL_0165: ldc.i4.1
    IL_0166: IL_3C
    IL_0168: stloc.s 0
    IL_0169: nop
    IL_016A: nop
    IL_016B: ldarg.0
    IL_016C: dup
    IL_0171: ldfld 0x04000998
    IL_0172: ldc.i4.1
    IL_0173: IL_58
    IL_0178: stfld 0x04000998
    IL_017D: br IL_0185
    IL_017E: ldarg.0
    IL_017F: ldc.i4.1
    IL_0184: stfld 0x0400099D
    IL_0189: br IL_019C
    IL_018A: ldarg.0
    IL_018B: dup
    IL_0190: ldfld 0x0400099A
    IL_0195: call 0x0A000024
    IL_0196: IL_58
    IL_019B: stfld 0x0400099A
    IL_01A0: br IL_023C
    IL_01A1: ldarg.0
    IL_01A6: ldfld 0x0400099A
    IL_01A7: IL_22
    IL_01A8: IL_CD
    IL_01A9: IL_CC
    IL_01AA: IL_CC
    IL_01AB: IL_3E
    IL_01AC: IL_43
    IL_01AD: IL_23
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: ldarg.0
    IL_01B2: ldc.i4.0
    IL_01B7: stfld 0x0400099C
    IL_01B8: ldarg.0
    IL_01BD: ldfld 0x04000995
    IL_01BE: ldc.i4.1
    IL_01BF: conv.r8
    IL_01C1: ldc.i4.s 0
    IL_01C2: nop
    IL_01C3: stloc.0
    IL_01C4: ldarg.0
    IL_01C5: IL_22
    IL_01C6: nop
    IL_01C7: nop
    IL_01CC: stsfld 0x099A7DBF
    IL_01CD: nop
    IL_01CE: ldarg.2
    IL_01D3: br IL_023C
    IL_01D4: ldarg.0
    IL_01D9: ldfld 0x0400099A
    IL_01DA: IL_22
    IL_01DB: nop
    IL_01DC: nop
    IL_01E1: stsfld 0x001743BF
    IL_01E2: nop
    IL_01E3: nop
    IL_01E4: ldarg.0
    IL_01E5: dup
    IL_01EA: ldfld 0x0400099A
    IL_01EF: call 0x0A000024
    IL_01F0: IL_58
    IL_01F5: stfld 0x0400099A
    IL_01FA: br IL_023C
    IL_01FB: ldarg.0
    IL_01FC: dup
    IL_0201: ldfld 0x0400099A
    IL_0206: call 0x0A000024
    IL_0207: IL_59
    IL_020C: stfld 0x0400099A
    IL_020D: ldarg.0
    IL_0212: ldfld 0x0400099A
    IL_0213: IL_22
    IL_0214: nop
    IL_0215: nop
    IL_0216: nop
    IL_0217: IL_C0
    IL_0218: IL_41
    IL_021A: ldc.i4.s 0
    IL_021B: nop
    IL_021C: nop
    IL_021D: ldarg.0
    IL_0222: ldfld 0x04000995
    IL_0223: ldc.i4.0
    IL_0224: conv.r8
    IL_0226: ldc.i4.s 0
    IL_0227: nop
    IL_0228: stloc.0
    IL_0229: ldarg.0
    IL_022E: ldfld 0x04000995
    IL_022F: ldc.i4.1
    IL_0230: conv.r8
    IL_0232: ldc.i4.s 0
    IL_0233: nop
    IL_0234: stloc.0
    IL_0235: ldarg.0
    IL_0236: ldnull
    IL_023B: stfld 0x0400099E
    IL_023C: ldarg.0
    IL_0241: ldfld 0x04000994
    IL_0242: ldarg.0
    IL_0247: ldfld 0x0400099B
    IL_0248: conv.r8
    IL_0249: ldc.i4.2
    IL_024A: nop
    IL_024B: nop
    IL_024C: stloc.0
    IL_0251: call 0x0A000007
    IL_0252: IL_22
    IL_0253: IL_CD
    IL_0254: IL_CC
    IL_0255: IL_4C
    IL_0256: IL_3E
    IL_025B: call 0x0A000008
    IL_0260: call 0x0A000029
    IL_0261: conv.r8
    IL_0262: ldloc.3
    IL_0263: nop
    IL_0264: nop
    IL_0265: stloc.0
    IL_0266: ldarg.0
    IL_026B: ldfld 0x04000994
    IL_026C: ldarg.0
    IL_0271: ldfld 0x04000994
    IL_0272: conv.r8
    IL_0273: pop
    IL_0274: nop
    IL_0275: nop
    IL_0276: stloc.0
    IL_0277: ldarg.0
    IL_027C: ldfld 0x0400099B
    IL_027D: conv.r8
    IL_027E: pop
    IL_027F: nop
    IL_0280: nop
    IL_0281: stloc.0
    IL_0286: call 0x0A000024
    IL_0287: IL_22
    IL_0288: nop
    IL_0289: nop
    IL_9CA16B8E: switch (656955968 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: newarr 0x01000003
    IL_000B: stfld 0x040009A3
    IL_000C: ldarg.0
    IL_000D: ldc.i4.1
    IL_0012: stfld 0x040009A9
    IL_0013: ldarg.0
    IL_0018: call 0x0A000001
    IL_0019: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009A1
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040009A2
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000001
    IL_0022: call 0x0A000004
    IL_0023: conv.r8
    IL_0024: ldarg.3
    IL_0025: nop
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: stfld 0x040009A8
    IL_002D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00003D
    IL_0007: conv.r8
    IL_000A: ldarga 0
    IL_000B: stloc.0
    IL_0010: stfld 0x040009A6
    IL_0011: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009A2
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0016: stfld 0x040009A7
    IL_0017: ldarg.0
    IL_0018: ldc.i4.0
    IL_001D: stfld 0x040009A5
    IL_001E: ldarg.0
    IL_001F: ldc.i4.0
    IL_0024: stfld 0x040009A4
    IL_0025: ldarg.0
    IL_0026: ldc.i4.0
    IL_002B: stfld 0x040009AA
    IL_002C: ldarg.0
    IL_002D: ldc.i4.0
    IL_0032: stfld 0x040009A9
    IL_0033: ldarg.0
    IL_0034: ldc.i4.0
    IL_0039: stfld 0x040009AC
    IL_003A: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.8
    IL_03A4: switch (229 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009AA
    IL_000A: brtrue IL_017C
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009A7
    IL_0011: IL_22
    IL_0012: IL_CD
    IL_0013: IL_CC
    IL_0014: IL_4C
    IL_0015: IL_3E
    IL_0016: IL_43
    IL_0019: stloc 1
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0025: stfld 0x040009A7
    IL_0026: ldarg.0
    IL_002B: ldfld 0x040009A3
    IL_002C: ldarg.0
    IL_0031: ldfld 0x040009A5
    IL_0032: ldelem.i
    IL_0033: ldnull
    IL_0038: call 0x0A000061
    IL_003D: brfalse IL_00D8
    IL_003E: ldarg.0
    IL_0043: ldfld 0x040009A3
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040009A5
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040009A0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x040009A1
    IL_0056: conv.r8
    IL_0057: ldc.i4.2
    IL_0058: nop
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x040009A1
    IL_0061: conv.r8
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_006A: call 0x0A000019
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040009A1
    IL_0071: conv.r8
    IL_0072: pop
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_007A: call 0x0A000014
    IL_007B: conv.u4
    IL_007C: ldarg.1
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_01
    IL_0084: stelem 0x09A37B02
    IL_0085: nop
    IL_0086: ldarg.2
    IL_0087: ldarg.0
    IL_008C: ldfld 0x040009A5
    IL_008D: ldelem.i
    IL_008E: conv.r8
    IL_008F: IL_3D
    IL_0090: nop
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: ldarg.0
    IL_0098: ldfld 0x040009A6
    IL_0099: conv.r8
    IL_009A: IL_84
    IL_009B: nop
    IL_009C: nop
    IL_009D: stloc.0
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x040009A3
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x040009A5
    IL_00AA: ldelem.i
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x040009A1
    IL_00B1: conv.r8
    IL_00B2: IL_4E
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x040009A3
    IL_00BC: ldarg.0
    IL_00C1: ldfld 0x040009A5
    IL_00C2: ldelem.i
    IL_00C3: conv.r8
    IL_00C8: ldstr 0x022B0000
    IL_00CD: ldfld 0x040009A5
    IL_00CE: conv.r8
    IL_00CF: IL_35
    IL_00D0: ldarg.3
    IL_00D1: nop
    IL_00D2: ldloc.0
    IL_00D7: br IL_013A
    IL_00D8: ldarg.0
    IL_00DD: ldfld 0x040009A3
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x040009A5
    IL_00E4: ldelem.i
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x040009A1
    IL_00EB: conv.r8
    IL_00EC: ldc.i4.2
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: stloc.0
    IL_00F0: ldarg.0
    IL_00F5: ldfld 0x040009A1
    IL_00F6: conv.r8
    IL_00F7: IL_22
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FF: call 0x0A000019
    IL_0100: conv.r8
    IL_0101: ldloc.3
    IL_0102: nop
    IL_0103: nop
    IL_0104: stloc.0
    IL_0105: ldarg.0
    IL_010A: ldfld 0x040009A3
    IL_010B: ldarg.0
    IL_0110: ldfld 0x040009A5
    IL_0111: ldelem.i
    IL_0112: ldarg.0
    IL_0117: ldfld 0x040009A1
    IL_0118: conv.r8
    IL_0119: pop
    IL_011A: nop
    IL_011B: nop
    IL_011C: stloc.0
    IL_011D: conv.r8
    IL_0122: call 0x020A0000
    IL_0127: ldfld 0x040009A3
    IL_0128: ldarg.0
    IL_012D: ldfld 0x040009A5
    IL_012E: ldelem.i
    IL_012F: conv.r8
    IL_0130: stloc.0
    IL_0131: nop
    IL_0132: nop
    IL_0133: stloc.0
    IL_0134: ldc.i4.1
    IL_0135: conv.r8
    IL_0136: stloc.1
    IL_0137: nop
    IL_0138: nop
    IL_0139: stloc.0
    IL_013A: ldarg.0
    IL_013F: ldfld 0x040009A5
    IL_0140: ldc.i4.3
    IL_0141: IL_3C
    IL_0143: stloc.s 0
    IL_0144: nop
    IL_0145: nop
    IL_0146: ldarg.0
    IL_0147: dup
    IL_014C: ldfld 0x040009A5
    IL_014D: ldc.i4.1
    IL_014E: IL_58
    IL_0153: stfld 0x040009A5
    IL_0158: br IL_0160
    IL_0159: ldarg.0
    IL_015A: ldc.i4.1
    IL_015F: stfld 0x040009AA
    IL_0164: br IL_0177
    IL_0165: ldarg.0
    IL_0166: dup
    IL_016B: ldfld 0x040009A7
    IL_0170: call 0x0A000024
    IL_0171: IL_58
    IL_0176: stfld 0x040009A7
    IL_017B: br IL_0217
    IL_017C: ldarg.0
    IL_0181: ldfld 0x040009A7
    IL_0182: IL_22
    IL_0183: ldelem.i
    IL_0184: IL_99
    IL_0185: IL_99
    IL_0186: IL_3E
    IL_0187: IL_43
    IL_0188: IL_23
    IL_0189: nop
    IL_018A: nop
    IL_018B: nop
    IL_018C: ldarg.0
    IL_018D: ldc.i4.0
    IL_0192: stfld 0x040009A9
    IL_0193: ldarg.0
    IL_0198: ldfld 0x040009A2
    IL_0199: ldc.i4.1
    IL_019A: conv.r8
    IL_019C: ldc.i4.s 0
    IL_019D: nop
    IL_019E: stloc.0
    IL_019F: ldarg.0
    IL_01A0: IL_22
    IL_01A1: nop
    IL_01A2: nop
    IL_01A7: stsfld 0x09A77DBF
    IL_01A8: nop
    IL_01A9: ldarg.2
    IL_01AE: br IL_0217
    IL_01AF: ldarg.0
    IL_01B4: ldfld 0x040009A7
    IL_01B5: IL_22
    IL_01B6: nop
    IL_01B7: nop
    IL_01BC: stsfld 0x001743BF
    IL_01BD: nop
    IL_01BE: nop
    IL_01BF: ldarg.0
    IL_01C0: dup
    IL_01C5: ldfld 0x040009A7
    IL_01CA: call 0x0A000024
    IL_01CB: IL_58
    IL_01D0: stfld 0x040009A7
    IL_01D5: br IL_0217
    IL_01D6: ldarg.0
    IL_01D7: dup
    IL_01DC: ldfld 0x040009A7
    IL_01E1: call 0x0A000024
    IL_01E2: IL_59
    IL_01E7: stfld 0x040009A7
    IL_01E8: ldarg.0
    IL_01ED: ldfld 0x040009A7
    IL_01EE: IL_22
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: nop
    IL_01F2: IL_C0
    IL_01F3: IL_41
    IL_01F5: ldc.i4.s 0
    IL_01F6: nop
    IL_01F7: nop
    IL_01F8: ldarg.0
    IL_01FD: ldfld 0x040009A2
    IL_01FE: ldc.i4.0
    IL_01FF: conv.r8
    IL_0201: ldc.i4.s 0
    IL_0202: nop
    IL_0203: stloc.0
    IL_0204: ldarg.0
    IL_0209: ldfld 0x040009A2
    IL_020A: ldc.i4.1
    IL_020B: conv.r8
    IL_020D: ldc.i4.s 0
    IL_020E: nop
    IL_020F: stloc.0
    IL_0210: ldarg.0
    IL_0211: ldnull
    IL_0216: stfld 0x040009AB
    IL_0217: ldarg.0
    IL_021C: ldfld 0x040009A1
    IL_021D: ldarg.0
    IL_0222: ldfld 0x040009A8
    IL_0223: conv.r8
    IL_0224: ldc.i4.2
    IL_0225: nop
    IL_0226: nop
    IL_0227: stloc.0
    IL_022C: call 0x0A000007
    IL_022D: IL_22
    IL_022E: IL_CD
    IL_022F: IL_CC
    IL_0230: IL_CC
    IL_0231: IL_3D
    IL_0236: call 0x0A000008
    IL_023B: call 0x0A000029
    IL_023C: conv.r8
    IL_023D: ldloc.3
    IL_023E: nop
    IL_023F: nop
    IL_0240: stloc.0
    IL_0241: ldarg.0
    IL_0246: ldfld 0x040009A1
    IL_0247: ldarg.0
    IL_024C: ldfld 0x040009A1
    IL_024D: conv.r8
    IL_024E: pop
    IL_024F: nop
    IL_0250: nop
    IL_0251: stloc.0
    IL_0252: ldarg.0
    IL_0257: ldfld 0x040009A8
    IL_0258: conv.r8
    IL_0259: pop
    IL_025A: nop
    IL_025B: nop
    IL_025C: stloc.0
    IL_0261: call 0x0A000024
    IL_0262: IL_22
    IL_0263: nop
    IL_0264: nop
    IL_9CA16B69: switch (656955968 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009AE
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040009B3
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x2B00004A
    IL_0023: stfld 0x040009B4
    IL_0024: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009AE
    IL_000A: call 0x0A000062
    IL_000F: call 0x0A000007
    IL_0014: call 0x0A000029
    IL_0015: conv.r8
    IL_0016: IL_AF
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x040009B3
    IL_0020: ldc.i4.0
    IL_0021: conv.r8
    IL_0023: ldc.i4.s 0
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_0030: stfld 0x040009B2
    IL_0031: ret
    }

    public void FireSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009B3
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040009AE
    IL_0012: ldnull
    IL_0013: conv.r8
    IL_0014: IL_4E
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_0019: ldc.i4.1
    IL_001E: stfld 0x040009AD
    IL_001F: ldarg.0
    IL_0020: ldarg.1
    IL_0025: stfld 0x040009AF
    IL_0026: ldarg.0
    IL_002B: ldfld 0x040009B4
    IL_002C: ldc.i4.1
    IL_002D: conv.r8
    IL_0032: beq IL_2A0A0033
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009AD
    IL_000A: brfalse IL_0144
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009AE
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0024: IL_EC
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040009B2
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0035: ldc.i4 1589569
    IL_0036: nop
    IL_0037: nop
    IL_0038: ldarg.0
    IL_0039: dup
    IL_003E: ldfld 0x040009B2
    IL_0043: call 0x0A000024
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_0047: ldelem.r8
    IL_2C9F561B4: switch (2994559066 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009B6
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040009BC
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x2B00004A
    IL_0023: stfld 0x040009BD
    IL_0024: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009BC
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: IL_22
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: nop
    IL_0016: stfld 0x040009BB
    IL_0017: ldarg.0
    IL_001C: ldfld 0x040009BD
    IL_001D: ldc.i4.1
    IL_001E: conv.r8
    IL_0023: beq IL_20A0024
    IL_0024: ldc.i4.1
    IL_0029: stfld 0x040009B5
    IL_002A: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040009B6
    IL_0007: conv.r8
    IL_0008: IL_CD
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x040009B8
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040009B8
    IL_001C: call 0x0600052C
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040009B6
    IL_0023: ldnull
    IL_0024: conv.r8
    IL_0025: IL_4E
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: ret
    }

    public void FireSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009BC
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x040009B7
    IL_0013: ret
    }

    public void FinishSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009BC
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldc.i4.0
    IL_0012: stfld 0x040009B5
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: nop
    IL_001D: stfld 0x040009BB
    IL_001E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009B5
    IL_000A: brfalse IL_01A8
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009B6
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0025: stloc.s 1
    IL_0026: nop
    IL_0027: nop
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040009B7
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040009B8
    IL_0038: call 0x0A000061
    IL_003D: brfalse IL_004E
    IL_003E: ldarg.0
    IL_003F: IL_22
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_26EE3B: switch (637821 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009BF
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x040009C5
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x2B00004A
    IL_0023: stfld 0x040009C6
    IL_0024: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040009C8
    IL_0007: ldarg.0
    IL_000C: ldfld 0x040009C5
    IL_000D: ldc.i4.0
    IL_000E: conv.r8
    IL_0010: ldc.i4.s 0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: IL_CD
    IL_0016: IL_CC
    IL_0017: IL_CC
    IL_0018: IL_3E
    IL_001D: stfld 0x040009C4
    IL_001E: ldarg.0
    IL_0023: ldfld 0x040009C6
    IL_0024: ldc.i4.1
    IL_0025: conv.r8
    IL_002A: beq IL_2A0A002B
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x040009BF
    IL_0007: conv.r8
    IL_0008: IL_CD
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x040009C1
    IL_0011: ldarg.0
    IL_0016: ldfld 0x040009BF
    IL_0017: ldnull
    IL_0018: conv.r8
    IL_0019: IL_4E
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ret
    }

    public void FireSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009C5
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_0012: stfld 0x040009C0
    IL_0013: ldarg.0
    IL_0014: ldarg.0
    IL_0019: ldfld 0x040009C0
    IL_001A: conv.r8
    IL_001B: ldc.i4.2
    IL_001C: nop
    IL_001D: nop
    IL_001E: stloc.0
    IL_0023: stfld 0x040009C2
    IL_0024: ldarg.0
    IL_0025: ldarg.0
    IL_002A: ldfld 0x040009C2
    IL_002B: ldarg.0
    IL_0030: ldfld 0x040009BF
    IL_0031: conv.r8
    IL_0032: ldc.i4.2
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_003A: call 0x0A000019
    IL_003F: stfld 0x040009C3
    IL_0040: ldarg.0
    IL_0045: ldflda 0x040009C3
    IL_0046: ldc.i4.1
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_0050: call 0x0A00001A
    IL_0051: ldarg.0
    IL_0056: ldfld 0x040009C3
    IL_005B: call 0x0A00001B
    IL_0060: call 0x0A00001C
    IL_0065: brfalse IL_0077
    IL_0066: ldarg.0
    IL_006B: ldfld 0x040009BF
    IL_006C: ldarg.0
    IL_0071: ldfld 0x040009C3
    IL_0072: conv.r8
    IL_0077: ldc.i4 34209792
    IL_0078: IL_22
    IL_0079: IL_CD
    IL_007A: IL_CC
    IL_007B: IL_CC
    IL_007C: IL_3E
    IL_0081: stfld 0x040009C4
    IL_0082: ldarg.0
    IL_0083: ldc.i4.1
    IL_0088: stfld 0x040009BE
    IL_0089: ret
    }

    public void FinishSword() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009C5
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_000D: ldc.i4.0
    IL_0012: stfld 0x040009BE
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: nop
    IL_001D: stfld 0x040009C4
    IL_001E: ldarg.0
    IL_001F: ldc.i4.1
    IL_0024: stfld 0x040009C8
    IL_0025: ret
    }

    public void SetPos() {
    IL_0000: ldarg.1
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0005: ldarg 4
    IL_0006: nop
    IL_0007: nop
    IL_0008: ldarg.3
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000D: beq.s IL_000E
    IL_000E: nop
    IL_000F: nop
    IL_0010: IL_57
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0018: stsfld 0x38000000
    IL_0019: IL_A4
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: ldarg.0
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0025: stsfld 0x0000223F
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002F: stsfld 0x0076733F
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: IL_22
    IL_0033: IL_B8
    IL_0034: ldc.i4.8
    IL_0035: ldarg.3
    IL_0036: IL_3E
    IL_003B: call 0x0A000008
    IL_0040: stfld 0x040009C7
    IL_0045: br IL_00C1
    IL_0046: ldarg.0
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004E: stsfld 0x0000223F
    IL_004F: nop
    IL_0050: nop
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0058: stsfld 0x007673BF
    IL_0059: nop
    IL_005A: stloc.0
    IL_005B: IL_22
    IL_005C: IL_B8
    IL_005D: ldc.i4.8
    IL_005E: ldarg.3
    IL_005F: IL_3E
    IL_0064: call 0x0A000008
    IL_0069: stfld 0x040009C7
    IL_006E: br IL_00C1
    IL_006F: ldarg.0
    IL_0070: IL_22
    IL_0071: nop
    IL_0072: nop
    IL_0077: stsfld 0x000022BF
    IL_0078: nop
    IL_0079: nop
    IL_007A: IL_22
    IL_007B: nop
    IL_007C: nop
    IL_0081: stsfld 0x0076733F
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: IL_22
    IL_0085: IL_B8
    IL_0086: ldc.i4.8
    IL_0087: ldarg.3
    IL_0088: IL_3E
    IL_008D: call 0x0A000008
    IL_0092: stfld 0x040009C7
    IL_0097: br IL_00C1
    IL_0098: ldarg.0
    IL_0099: IL_22
    IL_009A: nop
    IL_009B: nop
    IL_00A0: stsfld 0x000022BF
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: IL_22
    IL_00A4: nop
    IL_00A5: nop
    IL_00AA: stsfld 0x007673BF
    IL_00AB: nop
    IL_00AC: stloc.0
    IL_00AD: IL_22
    IL_00AE: IL_B8
    IL_00AF: ldc.i4.8
    IL_00B0: ldarg.3
    IL_00B1: IL_3E
    IL_00B6: call 0x0A000008
    IL_00BB: stfld 0x040009C7
    IL_00C0: br IL_00C1
    IL_00C1: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009C8
    IL_000A: brfalse IL_0081
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009BF
    IL_0011: dup
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A000007
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_20A123: switch (534592 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164330816
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009C9
    IL_000C: ldarg.0
    IL_0011: call 0x0A00000A
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x040009C9
    IL_001F: conv.r8
    IL_0024: cpobj 0x7D0A0000
    IL_0025: IL_CA
    IL_0026: ldloc.3
    IL_0027: nop
    IL_0028: ldarg.2
    IL_0029: ldarg.0
    IL_002A: ldarg.0
    IL_002F: ldfld 0x040009C9
    IL_0030: ldc.i4.0
    IL_0031: conv.r8
    IL_0036: brtrue IL_6F0A0037
    IL_0037: IL_B0
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003F: stfld 0x040009CC
    IL_0040: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x09CB7D3F
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009C9
    IL_0015: call 0x0A00001B
    IL_0016: conv.r8
    IL_0017: IL_AF
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x040009CC
    IL_0021: conv.r8
    IL_0022: IL_B1
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009CB
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_41
    IL_000C: conv.i8
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040009C9
    IL_0016: dup
    IL_0017: conv.r8
    IL_001C: cpobj 0x280A0000
    IL_001D: localloc
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: call 0x0A000024
    IL_002A: call 0x0A000008
    IL_002B: IL_22
    IL_002C: nop
    IL_002D: nop
    IL_20A132: switch (534592 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164592960
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009CD
    IL_000C: ldarg.0
    IL_0011: call 0x0A00000A
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164592960
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040009CD
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: stfld 0x040009CE
    IL_001C: ldarg.0
    IL_0021: ldfld 0x040009CE
    IL_0022: stloc.0
    IL_0024: ldloca.s 0
    IL_0025: IL_22
    IL_0026: IL_CD
    IL_0027: IL_CC
    IL_0028: IL_CC
    IL_0029: IL_BE
    IL_002E: stfld 0x0A000023
    IL_002F: ldarg.0
    IL_0034: ldfld 0x040009CD
    IL_0035: ldloc.0
    IL_0036: conv.r8
    IL_0037: ldloc.3
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009CF
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_41
    IL_000C: IL_77
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040009CD
    IL_0016: dup
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000007
    IL_0025: call 0x0A000024
    IL_002A: call 0x0A000008
    IL_002B: IL_22
    IL_002C: nop
    IL_002D: nop
    IL_002E: nop
    IL_20D3: switch (2088 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164724032
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009D0
    IL_000C: ldarg.0
    IL_0011: call 0x0A00000A
    IL_0012: ldc.i4.0
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: ldc.i4 164724032
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009D1
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_41
    IL_000C: mul
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040009D0
    IL_0016: dup
    IL_0017: conv.r8
    IL_0018: ldc.i4.2
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000007
    IL_0025: call 0x0A000024
    IL_002A: call 0x0A000008
    IL_002B: IL_22
    IL_002C: IL_CD
    IL_002D: IL_CC
    IL_002E: IL_4C
    IL_002F: IL_3D
    IL_0034: call 0x0A000008
    IL_0039: call 0x0A000019
    IL_003A: conv.r8
    IL_003B: ldloc.3
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x040009D0
    IL_0045: conv.r8
    IL_0046: ldc.i4.2
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: stloc.0
    IL_004C: ldloca.s 0
    IL_0051: ldfld 0x0A000023
    IL_0052: IL_22
    IL_0053: IL_CD
    IL_0054: IL_CC
    IL_0055: IL_4C
    IL_0056: IL_BD
    IL_0057: IL_41
    IL_0058: stloc.2
    IL_0059: nop
    IL_005A: nop
    IL_005B: nop
    IL_005C: ldarg.0
    IL_0061: call 0x0A00000A
    IL_0062: ldc.i4.0
    IL_0063: conv.r8
    IL_0064: stloc.1
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_006C: br IL_007F
    IL_006D: ldarg.0
    IL_006E: dup
    IL_0073: ldfld 0x040009D1
    IL_0078: call 0x0A000024
    IL_0079: IL_59
    IL_007E: stfld 0x040009D1
    IL_007F: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040009D3
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x040009D4
    IL_000E: ldarg.0
    IL_000F: IL_22
    IL_0010: nop
    IL_0011: nop
    IL_0012: nop
    IL_27560B: switch (644477 cases)
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000002
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A000090
    IL_0010: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x040009DE
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000001
    IL_001A: call 0x0A000004
    IL_001F: stfld 0x040009D8
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70022EF5
    IL_002A: call 0x0A000077
    IL_002F: stfld 0x040009D9
    IL_0030: ldarg.0
    IL_0031: ldarg.0
    IL_0036: ldfld 0x040009D8
    IL_0037: conv.r8
    IL_0038: ldarg.2
    IL_0039: nop
    IL_003A: nop
    IL_003C: br.s IL_00BA
    IL_003D: IL_DA
    IL_003E: ldloc.3
    IL_003F: nop
    IL_0040: ldarg.2
    IL_0041: ldarg.0
    IL_0046: ldstr 0x700004DD
    IL_004B: call 0x06000220
    IL_0050: stfld 0x040009DF
    IL_0051: ldarg.0
    IL_0056: ldfld 0x040009DF
    IL_0057: ldc.i4.m1
    IL_037C: switch (200 cases)
    }

    public void ScreenOn() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x040009D3
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x040009D5
    IL_000E: ret
    }

    public void Story_Contents() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009D7
    IL_0007: stloc.s 4
    IL_0009: ldloc.s 4
    IL_000C: ldarg 8
    IL_000D: nop
    IL_000E: nop
    IL_000F: ldarg.3
    IL_0010: nop
    IL_0011: nop
    IL_0012: nop
    IL_0014: ldloc.s 0
    IL_0015: nop
    IL_0016: nop
    IL_001B: call 0xA7000000
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_B6
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_ED
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_002B: call 0x5A000001
    IL_002C: IL_01
    IL_002D: nop
    IL_002E: nop
    IL_0033: br IL_0205
    IL_0034: ldarg.0
    IL_0035: ldc.i4.1
    IL_003A: stfld 0x040009D4
    IL_003F: br IL_0205
    IL_0040: ldarg.0
    IL_0041: ldc.i4.0
    IL_0046: stfld 0x040009D4
    IL_0047: ldarg.0
    IL_004C: call 0x0A00002B
    IL_004D: conv.r8
    IL_004E: IL_4D
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0056: br IL_0205
    IL_0057: ldarg.0
    IL_0058: ldc.i4.1
    IL_005D: stfld 0x040009D4
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040009D8
    IL_0064: conv.r8
    IL_0065: ldarg.3
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_006D: call 0x0A00001B
    IL_006E: conv.r8
    IL_006F: ldloc.3
    IL_0070: nop
    IL_0071: nop
    IL_0072: stloc.0
    IL_0077: ldstr 0x70022F0D
    IL_007C: call 0x0A000077
    IL_007D: stloc.0
    IL_007E: ldloc.0
    IL_007F: conv.r8
    IL_0080: ldarg.3
    IL_0081: nop
    IL_0082: nop
    IL_0083: stloc.0
    IL_0088: call 0x0A000062
    IL_0089: IL_22
    IL_008A: IL_CD
    IL_008B: IL_CC
    IL_008C: IL_CC
    IL_008D: IL_BD
    IL_0092: call 0x0A000008
    IL_0093: conv.r8
    IL_0094: ldloc.3
    IL_0095: nop
    IL_0096: nop
    IL_0097: stloc.0
    IL_009C: call 0x0A000035
    IL_009D: conv.r8
    IL_009E: ldloc.0
    IL_009F: nop
    IL_00A0: nop
    IL_00A2: br.s IL_00A9
    IL_00A3: conv.r8
    IL_00A4: ldarg.3
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: stloc.0
    IL_00A9: ldc.i4.s 25
    IL_00AA: IL_22
    IL_00AB: nop
    IL_00AC: nop
    IL_00B1: ldc.i4 19820353
    IL_00B2: nop
    IL_00B3: ldloc.0
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x040009DA
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x040009D9
    IL_00C0: conv.r8
    IL_00C1: ldarg.3
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: stloc.0
    IL_00C5: conv.r8
    IL_00C6: ldc.i4.2
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: stloc.0
    IL_00CA: ldc.i4.0
    IL_00CB: ldc.i4.1
    IL_00CC: conv.r8
    IL_00D1: stfld 0x38060001
    IL_00D3: bge.s IL_00D5
    IL_00D4: nop
    IL_00D5: nop
    IL_00DA: ldstr 0x70022F15
    IL_00DF: call 0x0A000128
    IL_00E4: br IL_0205
    IL_00E9: ldstr 0x700016D7
    IL_00EE: call 0x0A000077
    IL_00EF: conv.r8
    IL_00F4: newobj 0x6F2B0000
    IL_00F5: IL_AD
    IL_00F6: IL_01
    IL_00F7: nop
    IL_00F8: ldloc.0
    IL_00FD: ldstr 0x70000B91
    IL_0102: call 0x0A000077
    IL_0103: conv.r8
    IL_0104: conv.u4
    IL_0105: nop
    IL_0106: nop
    IL_0108: br.s IL_0178
    IL_0109: IL_BD
    IL_010A: IL_01
    IL_010B: nop
    IL_010C: ldloc.0
    IL_0111: ldstr 0x70001799
    IL_0116: call 0x0A000128
    IL_011B: br IL_0205
    IL_0120: ldstr 0x70000B91
    IL_0125: call 0x0A000077
    IL_012A: call 0x0A000050
    IL_012F: ldstr 0x700016D7
    IL_0134: call 0x0A000077
    IL_0135: stloc.1
    IL_0136: ldloc.1
    IL_0137: conv.r8
    IL_013C: newobj 0x282B0000
    IL_013D: IL_50
    IL_013E: nop
    IL_013F: nop
    IL_0140: stloc.0
    IL_0141: ldloc.1
    IL_0142: conv.r8
    IL_0143: conv.u8
    IL_0144: nop
    IL_0145: nop
    IL_0147: br.s IL_016E
    IL_014C: ldstr 0x70022F25
    IL_0151: call 0x0A000128
    IL_0156: br IL_0205
    IL_015B: ldstr 0x70022F35
    IL_0160: call 0x0A000077
    IL_0161: conv.r8
    IL_0162: conv.r.un
    IL_0163: nop
    IL_0164: nop
    IL_0166: br.s IL_01D6
    IL_0167: IL_43
    IL_0168: IL_01
    IL_0169: nop
    IL_016A: ldloc.0
    IL_016F: ldstr 0x700016D7
    IL_0174: call 0x0A000077
    IL_0179: call 0x0A000050
    IL_017E: ldstr 0x70000BEF
    IL_0183: call 0x0A000128
    IL_0188: br IL_0205
    IL_018D: ldstr 0x70022F35
    IL_0192: call 0x0A000077
    IL_0193: conv.r8
    IL_0194: IL_77
    IL_0195: nop
    IL_0196: nop
    IL_0198: br.s IL_0208
    IL_0199: IL_3E
    IL_019A: IL_01
    IL_019B: nop
    IL_019C: ldloc.0
    IL_019D: ldarg.0
    IL_01A2: ldfld 0x040009DF
    IL_01A3: ldc.i4.m1
    IL_0214: switch (27 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009D3
    IL_000A: brfalse IL_008B
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x040009D6
    IL_0016: call 0x0A000024
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_359F56187: switch (3598538842 cases)
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009DB
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldc.i4.m1
    IL_0046: call 0x0A0000EF
    IL_0047: ldarg.0
    IL_004C: ldfld 0x040009D4
    IL_0051: brfalse IL_009A
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: nop
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: nop
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_F0
    IL_0060: IL_43
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0068: stsfld 0x021D2842
    IL_0069: nop
    IL_006A: ldloc.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x040009D2
    IL_0075: call 0x0A0000E0
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_22
    IL_007C: nop
    IL_007D: nop
    IL_0082: stsfld 0x00002243
    IL_0083: IL_F0
    IL_0084: IL_43
    IL_0085: IL_22
    IL_0086: nop
    IL_0087: nop
    IL_0088: IL_94
    IL_0089: IL_42
    IL_008E: call 0x0600021D
    IL_008F: ldarg.0
    IL_0094: ldfld 0x040009D2
    IL_0099: call 0x0A0000E0
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040009D6
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_0245: switch (103 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x09E07D3F
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: IL_CD
    IL_000E: IL_CC
    IL_000F: IL_4C
    IL_0010: IL_3E
    IL_0015: stfld 0x040009E1
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: IL_CD
    IL_0019: IL_CC
    IL_001A: IL_CC
    IL_001B: IL_3D
    IL_0020: stfld 0x040009E2
    IL_0021: ldarg.0
    IL_0026: call 0x0A000001
    IL_0027: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_0007: conv.r8
    IL_0008: neg
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x040009E3
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: call 0x0A000003
    IL_001C: stfld 0x040009E4
    IL_001D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000057
    IL_000A: stfld 0x040009E5
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009E3
    IL_0015: call 0x0A000057
    IL_0016: conv.r8
    IL_0017: IL_B4
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_0020: ldstr 0x70000AC3
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040009E2
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040009E1
    IL_0031: call 0x0A000017
    IL_0032: ret
    }

    private void DanceHit() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009E4
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040009E4
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040009E5
    IL_000B: call 0x0A000082
    IL_0010: call 0x0A000024
    IL_0015: call 0x0A000083
    IL_0016: ldarg.0
    IL_001B: ldfld 0x040009E0
    IL_0020: call 0x0A000083
    IL_0025: call 0x0A0000AB
    IL_002A: stfld 0x040009E5
    IL_002B: ldarg.0
    IL_0030: ldflda 0x040009E5
    IL_0035: ldfld 0x0A000059
    IL_0036: IL_22
    IL_0037: shr
    IL_0038: shr
    IL_0039: shr
    IL_003A: IL_3F
    IL_003B: IL_44
    IL_003C: IL_3D
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: ldarg.0
    IL_0045: call 0x0A000081
    IL_0046: ldarg.0
    IL_004B: ldfld 0x040009E4
    IL_004C: ldc.i4.0
    IL_004D: conv.r8
    IL_004F: ldc.i4.s 0
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ldarg.0
    IL_0057: call 0x0A000002
    IL_005C: call 0x0A00004B
    IL_005D: IL_22
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldc.i4.2
    IL_0061: IL_42
    IL_0066: call 0x0A000008
    IL_0067: conv.r8
    IL_0068: ldloc.3
    IL_0069: nop
    IL_006A: nop
    IL_006B: stloc.0
    IL_006C: ldarg.0
    IL_0071: call 0x0A00000A
    IL_0072: ldc.i4.0
    IL_0073: conv.r8
    IL_0074: stloc.1
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_007C: br IL_008E
    IL_007D: ldarg.0
    IL_0082: ldfld 0x040009E3
    IL_0083: ldarg.0
    IL_0088: ldfld 0x040009E5
    IL_0089: conv.r8
    IL_008A: IL_B4
    IL_008B: nop
    IL_008C: nop
    IL_008D: stloc.0
    IL_008E: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x040009E8
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000001
    IL_0016: call 0x0A000004
    IL_0017: conv.r8
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: stfld 0x040009E9
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: call 0x0A000003
    IL_002C: stfld 0x040009EA
    IL_002D: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_C0
    IL_0005: IL_3F
    IL_000A: stfld 0x040009E6
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x040009E7
    IL_0012: ldarg.0
    IL_0017: call 0x0A00000A
    IL_0019: ldc.i4.s 16
    IL_001A: conv.r8
    IL_001B: ldc.i4.m1
    IL_001C: nop
    IL_001D: nop
    IL_001E: stloc.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x040009EA
    IL_0025: ldc.i4.1
    IL_0026: conv.r8
    IL_0028: ldc.i4.s 0
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x040009E8
    IL_0032: conv.r8
    IL_0033: ldc.i4.2
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: stfld 0x040009EB
    IL_003C: ret
    }

    public void SetPower() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00003D
    IL_0006: ldarg.1
    IL_0007: conv.i2
    IL_0008: IL_22
    IL_0009: IL_CD
    IL_000A: IL_CC
    IL_000B: IL_CC
    IL_000C: IL_3E
    IL_000D: IL_5A
    IL_000E: conv.i2
    IL_000F: conv.r8
    IL_0010: IL_84
    IL_0011: nop
    IL_0012: nop
    IL_0013: stloc.0
    IL_0014: ret
    }

    private void ColliderOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009EA
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_0009: ldc.i4.s 0
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x040009EA
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040009E6
    IL_000B: call 0x0A000024
    IL_000C: IL_59
    IL_0011: stfld 0x040009E6
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040009E6
    IL_0018: conv.i4
    IL_0019: IL_23
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_F8
    IL_0021: IL_BF
    IL_0022: IL_41
    IL_0023: ldc.i4.6
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: ldarg.0
    IL_002C: call 0x0A00000C
    IL_002D: conv.r8
    IL_002E: or
    IL_002F: ldarg.0
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0037: call 0x0A00000A
    IL_0038: ldc.i4.0
    IL_0039: conv.r8
    IL_003A: stloc.1
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_0042: br IL_011E
    IL_0043: ldarg.0
    IL_0048: ldfld 0x040009E6
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_0050: stsfld 0x000B41BF
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldarg.0
    IL_0058: call 0x0A000081
    IL_005D: br IL_011E
    IL_005E: ldarg.0
    IL_0063: ldfld 0x040009E6
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: IL_41
    IL_006A: ldelem.i
    IL_006B: nop
    IL_006C: nop
    IL_006D: nop
    IL_006E: ldarg.0
    IL_0073: ldfld 0x040009E8
    IL_0074: ldarg.0
    IL_0079: ldfld 0x040009E8
    IL_007A: conv.r8
    IL_007B: ldc.i4.2
    IL_007C: nop
    IL_007D: nop
    IL_007E: stloc.0
    IL_007F: ldarg.0
    IL_0084: ldfld 0x040009E9
    IL_0085: conv.r8
    IL_0086: ldc.i4.2
    IL_0087: nop
    IL_0088: nop
    IL_0089: stloc.0
    IL_008E: call 0x0A000007
    IL_008F: IL_22
    IL_0090: IL_CD
    IL_0091: IL_CC
    IL_0092: IL_4C
    IL_0093: IL_3E
    IL_0098: call 0x0A000008
    IL_009D: call 0x0A000029
    IL_00A2: call 0x0A000024
    IL_00A3: IL_22
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: rem
    IL_18CA213: switch (6498394 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_000B: stfld 0x040009EE
    IL_000C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009EE
    IL_0006: ldc.i4.0
    IL_0007: conv.r8
    IL_000C: beq IL_2A0A000D
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x040009EF
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x040009EC
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040009EE
    IL_0018: ldc.i4.0
    IL_0019: conv.r8
    IL_001E: beq IL_2A0A001F
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x040009EC
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x040009EC
    IL_0012: ldarg.0
    IL_0017: ldfld 0x040009EF
    IL_001C: brtrue IL_004C
    IL_001D: ldarg.0
    IL_0022: ldfld 0x040009EC
    IL_0023: ldarg.0
    IL_0028: ldfld 0x040009ED
    IL_0029: IL_43
    IL_002A: ldc.i4.8
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: ldarg.0
    IL_0033: ldfld 0x040009EE
    IL_0034: ldc.i4.1
    IL_0035: conv.r8
    IL_003A: beq IL_20A003B
    IL_003B: ldc.i4.1
    IL_0040: stfld 0x040009EF
    IL_0041: ldarg.0
    IL_0042: IL_22
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_004B: stfld 0x040009EC
    IL_004C: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: IL_CD
    IL_0003: IL_CC
    IL_0004: IL_CC
    IL_0005: IL_3D
    IL_000A: stfld 0x040009FC
    IL_000B: ldarg.0
    IL_000C: ldc.i4.1
    IL_0011: stfld 0x04000A00
    IL_0012: ldarg.0
    IL_0017: call 0x0A000001
    IL_0018: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000CDD
    IL_000A: call 0x06000220
    IL_000B: neg
    IL_0010: stfld 0x04000A03
    IL_0011: ldarg.0
    IL_0016: ldc.i4 200
    IL_0017: ldc.i4.3
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000A03
    IL_001E: IL_5A
    IL_001F: IL_58
    IL_0020: neg
    IL_0025: stfld 0x040009FE
    IL_0026: ldarg.0
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040009FE
    IL_0031: stfld 0x040009FF
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: call 0x0A000002
    IL_003D: stfld 0x040009F7
    IL_003E: ldarg.0
    IL_003F: ldarg.0
    IL_0044: call 0x0A00002A
    IL_0049: stfld 0x040009FA
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040009F7
    IL_0054: call 0x0A000042
    IL_0059: call 0x0A000043
    IL_005A: IL_22
    IL_005C: bne.un.s IL_0090
    IL_005E: bne.un.s IL_009E
    IL_0063: call 0x0A000008
    IL_0064: conv.r8
    IL_0065: ldloc.3
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: ldarg.0
    IL_006E: ldstr 0x7000012D
    IL_0073: call 0x0A000004
    IL_0074: conv.r8
    IL_0075: ldloc.1
    IL_0076: nop
    IL_0077: nop
    IL_0079: br.s IL_009C
    IL_007A: IL_CD
    IL_007B: IL_CC
    IL_007C: IL_CC
    IL_007D: IL_3D
    IL_007E: IL_22
    IL_007F: stloc.0
    IL_0080: IL_D7
    IL_0081: stelem.i
    IL_0082: IL_3C
    IL_0087: newobj 0x0A000038
    IL_0088: ldc.i4.0
    IL_0089: ldc.i4.1
    IL_008A: conv.r8
    IL_008B: IL_BE
    IL_008C: ldarg.1
    IL_008D: nop
    IL_008E: ldloc.0
    IL_0093: stfld 0x040009F8
    IL_0094: ldarg.0
    IL_0099: ldfld 0x040009F8
    IL_009A: ldarg.0
    IL_009F: ldfld 0x040009F7
    IL_00A0: conv.r8
    IL_00A1: ldc.i4.2
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A9: call 0x0A000007
    IL_00AA: IL_22
    IL_00AB: ldelem.i
    IL_00AC: IL_99
    IL_00AD: IL_99
    IL_00AE: IL_3E
    IL_00B3: call 0x0A000008
    IL_00B8: call 0x0A000029
    IL_00B9: conv.r8
    IL_00BA: ldloc.3
    IL_00BB: nop
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x040009F8
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x040009F7
    IL_00CA: conv.r8
    IL_00CB: IL_4E
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: stloc.0
    IL_00CF: ldarg.0
    IL_00D0: ldarg.0
    IL_00D5: ldfld 0x040009F8
    IL_00D6: conv.r8
    IL_00D7: ldloc.2
    IL_00D8: nop
    IL_00D9: nop
    IL_00DB: br.s IL_0159
    IL_00DC: IL_F0
    IL_00DD: ldloc.3
    IL_00DE: nop
    IL_00DF: ldarg.2
    IL_00E0: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000A00
    IL_0007: ldarg.0
    IL_000C: ldfld 0x040009F6
    IL_000D: conv.r8
    IL_000E: ldarg.1
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0015: ldc.i4.s 0
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009FA
    IL_000A: ldstr 0x70022F9F
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0011: IL_CD
    IL_0012: IL_CC
    IL_0013: IL_CC
    IL_0014: IL_3E
    IL_0015: conv.r8
    IL_0017: bgt.s IL_0018
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x040009FA
    IL_0024: ldstr 0x70022FB1
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
    IL_0039: ldfld 0x040009FA
    IL_003E: ldstr 0x70022FC9
    IL_003F: conv.r8
    IL_0041: bge.s IL_0042
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: IL_22
    IL_0045: ldelem.i
    IL_0046: IL_99
    IL_0047: IL_99
    IL_0048: IL_3E
    IL_0049: conv.r8
    IL_004B: bgt.s IL_004C
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: call 0x0A00002B
    IL_0054: conv.r8
    IL_0055: IL_4D
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005E: ldstr 0x70022DCB
    IL_0063: call 0x0A000004
    IL_0064: conv.r8
    IL_0065: IL_78
    IL_0066: nop
    IL_0067: nop
    IL_0069: br.s IL_00E7
    IL_006A: IL_F1
    IL_006B: ldloc.3
    IL_006C: nop
    IL_006D: ldarg.2
    IL_006E: ldarg.0
    IL_0073: call 0x0A000035
    IL_0074: conv.r8
    IL_0075: ldloc.0
    IL_0076: nop
    IL_0077: nop
    IL_0079: br.s IL_00F7
    IL_007A: ldarg.2
    IL_007B: stloc.0
    IL_007C: nop
    IL_007D: ldarg.2
    IL_007E: ret
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A00
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A01
    IL_0016: brfalse IL_0018
    IL_0017: ret
    IL_0018: ldarg.0
    IL_001A: ldarga.s 1
    IL_001F: ldfld 0x0A000023
    IL_0020: not
    IL_0025: stfld 0x040009FD
    IL_0027: ldarga.s 1
    IL_0028: ldc.i4.1
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_0032: call 0x0A00001A
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040009FA
    IL_0039: conv.r8
    IL_003C: ldloc 0
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x040009FA
    IL_0048: ldstr 0x70022FB1
    IL_0049: conv.r8
    IL_004A: IL_3C
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: pop
    IL_004F: ldarg.0
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: nop
    IL_27EE4C: switch (654205 cases)
    }

    public void HurryUp() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: IL_3F
    IL_000A: stfld 0x040009FC
    IL_000B: ldarg.0
    IL_0010: ldfld 0x040009FA
    IL_0015: ldstr 0x70022F9F
    IL_0016: conv.r8
    IL_0018: bge.s IL_0019
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: nop
    IL_C1DF: switch (12399 cases)
    }

    public void AttakCastle() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040009F1
    IL_0006: conv.r8
    IL_0007: IL_B8
    IL_0008: ldarg.3
    IL_0009: nop
    IL_000A: ldloc.0
    IL_000F: brtrue IL_0017
    IL_0010: ldarg.0
    IL_0011: ldc.i4.1
    IL_0016: stfld 0x04000A02
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000A04
    IL_001D: conv.r8
    IL_001E: IL_35
    IL_001F: IL_01
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: call 0x0A00002B
    IL_0028: ldarg.0
    IL_002D: ldfld 0x040009F3
    IL_002E: conv.r8
    IL_002F: ldind.ref
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A00
    IL_000A: brtrue IL_0010
    IL_000F: br IL_0106
    IL_0010: ldarg.0
    IL_0015: ldfld 0x040009FB
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_43
    IL_001C: neg
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: ldarg.0
    IL_0021: dup
    IL_0026: ldfld 0x040009FB
    IL_002B: call 0x0A000024
    IL_002C: IL_59
    IL_0031: stfld 0x040009FB
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040009FB
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: IL_42
    IL_0042: ldc.i4 33554432
    IL_0047: ldfld 0x040009FA
    IL_004C: ldstr 0x70022F9F
    IL_004D: conv.r8
    IL_004E: IL_55
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: ldarg.0
    IL_0057: call 0x0A00002B
    IL_0058: conv.r8
    IL_0059: IL_4D
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_0061: br IL_0083
    IL_0062: ldarg.0
    IL_0067: ldfld 0x040009FB
    IL_0068: IL_22
    IL_0069: nop
    IL_006A: nop
    IL_006B: IL_C0
    IL_006C: IL_3F
    IL_006D: IL_41
    IL_006F: ldloc.s 0
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldarg.0
    IL_0077: ldfld 0x040009F4
    IL_0078: conv.r8
    IL_0079: IL_B0
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: ldc.i4.0
    IL_007E: conv.r8
    IL_007F: IL_B6
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0087: br IL_0106
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04000A02
    IL_0092: brfalse IL_0098
    IL_0097: br IL_0106
    IL_0098: ldarg.0
    IL_009D: ldfld 0x040009F7
    IL_009E: conv.r8
    IL_009F: ldc.i4.2
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: stloc.0
    IL_00A5: ldloca.s 0
    IL_00AA: ldfld 0x0A00005C
    IL_00AB: IL_22
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: ldnull
    IL_00AF: IL_41
    IL_00B0: IL_43
    IL_00B1: ldc.i4.0
    IL_00B2: nop
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x040009FA
    IL_00BF: ldstr 0x70022FC9
    IL_00C0: conv.r8
    IL_00C1: IL_3C
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: stloc.0
    IL_00C5: pop
    IL_00CA: br IL_0106
    IL_00CB: ldarg.0
    IL_00D0: ldfld 0x04000A00
    IL_00D5: brfalse IL_0106
    IL_00D6: ldarg.0
    IL_00DB: ldfld 0x040009F7
    IL_00DC: dup
    IL_00DD: conv.r8
    IL_00DE: ldc.i4.2
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: stloc.0
    IL_00E6: call 0x0A000042
    IL_00EB: call 0x0A000024
    IL_00F0: call 0x0A000008
    IL_00F1: ldarg.0
    IL_00F6: ldfld 0x040009FC
    IL_00FB: call 0x0A000008
    IL_0100: call 0x0A000029
    IL_0101: conv.r8
    IL_0102: ldloc.3
    IL_0103: nop
    IL_0104: nop
    IL_0105: stloc.0
    IL_0106: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00002A
    IL_000B: stfld 0x04000A07
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A07
    IL_0016: ldstr 0x70022FE1
    IL_0017: conv.r8
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: stsfld 0x00306F3E
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A08
    IL_0006: conv.r8
    IL_0007: IL_B0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: IL_B6
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0016: nop
    IL_001B: stfld 0x04000A05
    IL_001C: ldarg.0
    IL_001D: ldc.i4.1
    IL_0022: stfld 0x04000A06
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000A07
    IL_0029: conv.r8
    IL_002C: ldloc 0
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000A07
    IL_0038: ldstr 0x70022FE1
    IL_0039: conv.r8
    IL_003A: IL_3C
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: pop
    IL_003F: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A05
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000D: ldc.i4 2507584
    IL_000E: nop
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0015: call 0x0A000002
    IL_001A: call 0x0A000007
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_C8
    IL_001F: IL_41
    IL_0024: call 0x0A000008
    IL_0025: conv.r8
    IL_0026: ldloc.3
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldarg.0
    IL_002F: call 0x0A00000A
    IL_0030: ldc.i4.0
    IL_0031: conv.r8
    IL_0032: stloc.1
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000A05
    IL_003C: IL_22
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: IL_3F
    IL_0041: IL_43
    IL_0042: IL_23
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: ldarg.0
    IL_004B: ldfld 0x04000A06
    IL_0050: brfalse IL_0069
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000A08
    IL_0057: conv.r8
    IL_0058: IL_B0
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ldc.i4.0
    IL_005D: conv.r8
    IL_005E: IL_B6
    IL_005F: nop
    IL_0060: nop
    IL_0061: stloc.0
    IL_0062: ldarg.0
    IL_0063: ldc.i4.0
    IL_0068: stfld 0x04000A06
    IL_0069: ldarg.0
    IL_006A: dup
    IL_006F: ldfld 0x04000A05
    IL_0074: call 0x0A000024
    IL_0075: IL_58
    IL_007A: stfld 0x04000A05
    IL_007B: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000A09
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x04000A0A
    IL_000E: ldarg.0
    IL_0013: call 0x0A00017C
    IL_0018: stfld 0x04000A0B
    IL_0019: ldarg.0
    IL_001E: newobj 0x0A000265
    IL_0023: stfld 0x04000A0C
    IL_0024: ldarg.0
    IL_0029: newobj 0x0A000266
    IL_002E: stfld 0x04000A0D
    IL_002F: ldarg.0
    IL_0034: newobj 0x0A000267
    IL_0039: stfld 0x04000A0E
    IL_003A: ldarg.0
    IL_003F: newobj 0x0A000267
    IL_0044: stfld 0x04000A0F
    IL_0045: ldarg.0
    IL_004A: call 0x0A000001
    IL_004B: ret
    }

    private void Start() {
    IL_0004: newobj 0x0A000268
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: ldtoken 0x01000030
    IL_0011: call 0x0A0000A2
    IL_0016: call 0x0A000269
    IL_0017: conv.r8
    IL_0018: conv.i1
    IL_0019: ldarg.0
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.3
    IL_0022: br IL_0339
    IL_0023: ldloc.0
    IL_0024: ldloc.3
    IL_0025: conv.r8
    IL_0026: conv.i2
    IL_0027: ldarg.0
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: conv.r8
    IL_002B: stloc.3
    IL_002C: nop
    IL_002D: nop
    IL_002E: stloc.0
    IL_0030: stloc.s 4
    IL_0031: ldloc.0
    IL_0032: ldloc.3
    IL_0033: conv.r8
    IL_0034: conv.i2
    IL_0035: ldarg.0
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: conv.u4
    IL_003A: bgt.s IL_003B
    IL_003B: nop
    IL_003C: IL_01
    IL_003D: conv.r8
    IL_003E: IL_A9
    IL_003F: nop
    IL_0040: nop
    IL_0041: stloc.0
    IL_0042: conv.r8
    IL_0043: conv.i4
    IL_0044: ldarg.0
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: stloc.2
    IL_0048: ldloc.2
    IL_004D: brfalse IL_0056
    IL_004E: ldloc.2
    IL_004F: len
    IL_0050: not
    IL_0055: brtrue IL_00A2
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04000A09
    IL_0060: brfalse IL_00A2
    IL_0061: ldloc.0
    IL_0062: ldloc.3
    IL_0063: conv.r8
    IL_0064: conv.i2
    IL_0065: ldarg.0
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: conv.u4
    IL_006A: bgt.s IL_006B
    IL_006B: nop
    IL_006C: IL_01
    IL_006D: conv.r8
    IL_006E: IL_A9
    IL_006F: nop
    IL_0070: nop
    IL_0071: stloc.0
    IL_0072: conv.r8
    IL_0073: IL_8F
    IL_0074: IL_01
    IL_0075: nop
    IL_0076: stloc.0
    IL_0077: stloc.1
    IL_0078: ldloc.1
    IL_0079: len
    IL_007A: not
    IL_007F: newarr 0x01000014
    IL_0080: stloc.2
    IL_0081: ldloc.1
    IL_0082: ldloc.2
    IL_0083: ldloc.1
    IL_0084: len
    IL_0085: not
    IL_008A: call 0x0A00026D
    IL_008B: ldloc.0
    IL_008C: ldloc.3
    IL_008D: conv.r8
    IL_008E: conv.i2
    IL_008F: ldarg.0
    IL_0090: nop
    IL_0091: stloc.0
    IL_0092: conv.u4
    IL_0094: bgt.s IL_0095
    IL_0095: nop
    IL_0096: IL_01
    IL_0097: conv.r8
    IL_0098: IL_A9
    IL_0099: nop
    IL_009A: nop
    IL_009B: stloc.0
    IL_009C: ldloc.2
    IL_009D: conv.r8
    IL_009E: conv.r4
    IL_009F: ldarg.0
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: ldc.i4.1
    IL_00A4: stloc.s 5
    IL_00A6: ldloc.s 4
    IL_00A7: ldnull
    IL_00AC: call 0x0A000021
    IL_00B1: brfalse IL_0335
    IL_00B3: ldloc.s 4
    IL_00B4: conv.r8
    IL_00B5: IL_C9
    IL_00B6: nop
    IL_00B7: nop
    IL_00B8: stloc.0
    IL_00BD: brfalse IL_0335
    IL_00BF: ldloc.s 4
    IL_00C0: conv.r8
    IL_00C2: ldarg.s 0
    IL_00C3: nop
    IL_00C4: stloc.0
    IL_00C5: ldnull
    IL_00CA: call 0x0A000021
    IL_00CF: brfalse IL_0335
    IL_00D1: ldloc.s 4
    IL_00D2: conv.r8
    IL_00D3: conv.r8
    IL_00D4: ldarg.0
    IL_00D5: nop
    IL_00D6: stloc.0
    IL_00D8: stloc.s 6
    IL_00DA: ldloc.s 6
    IL_00DF: brfalse IL_0335
    IL_00E1: ldloc.s 6
    IL_00E3: stloc.s 8
    IL_00E4: ldc.i4.0
    IL_00E6: stloc.s 9
    IL_00EB: br IL_02B2
    IL_00ED: ldloc.s 8
    IL_00EF: ldloc.s 9
    IL_00F0: ldelem.i
    IL_00F2: stloc.s 7
    IL_00F3: ldarg.0
    IL_00F8: ldfld 0x04000A0A
    IL_00FD: brfalse IL_018C
    IL_00FF: ldloc.s 7
    IL_0100: conv.r8
    IL_0102: blt.s IL_0103
    IL_0103: nop
    IL_0104: stloc.0
    IL_0105: ldnull
    IL_010A: call 0x0A000061
    IL_010F: brfalse IL_0189
    IL_0110: ldc.i4.4
    IL_0111: ldc.i4.4
    IL_0116: newobj 0x0A000270
    IL_0118: stloc.s 10
    IL_0119: ldc.i4.0
    IL_011B: stloc.s 11
    IL_0120: br IL_0155
    IL_0121: ldc.i4.0
    IL_0123: stloc.s 12
    IL_0128: br IL_0141
    IL_012A: ldloc.s 10
    IL_012C: ldloc.s 12
    IL_012E: ldloc.s 11
    IL_0130: ldloc.s 7
    IL_0131: conv.r8
    IL_0136: ldobj 0x6F0A0002
    IL_013B: ldstr 0x110A0002
    IL_013C: stloc.2
    IL_013D: ldc.i4.1
    IL_013E: IL_58
    IL_0140: stloc.s 12
    IL_0142: ldloc.s 12
    IL_0144: ldloc.s 10
    IL_0145: conv.r8
    IL_014A: newobj 0x3F0A0002
    IL_014B: IL_DA
    IL_014C: IL_FF
    IL_014D: IL_FF
    IL_014E: IL_FF
    IL_0150: ldloc.s 11
    IL_0151: ldc.i4.1
    IL_0152: IL_58
    IL_0154: stloc.s 11
    IL_0156: ldloc.s 11
    IL_0158: ldloc.s 10
    IL_0159: conv.r8
    IL_015A: conv.u4
    IL_015B: ldarg.0
    IL_015C: nop
    IL_015D: stloc.0
    IL_015E: IL_3F
    IL_015F: IL_BE
    IL_0160: IL_FF
    IL_0161: IL_FF
    IL_0162: IL_FF
    IL_0164: ldloc.s 10
    IL_0165: conv.r8
    IL_0166: conv.u8
    IL_0167: ldarg.0
    IL_0168: nop
    IL_0169: stloc.0
    IL_016B: ldloc.s 7
    IL_0170: ldstr 0x700023C1
    IL_0172: ldloc.s 10
    IL_0173: conv.r8
    IL_0174: conv.u8
    IL_0175: IL_01
    IL_0176: nop
    IL_0177: stloc.0
    IL_0179: ldloc.s 7
    IL_017E: call 0x0A00017C
    IL_017F: conv.r8
    IL_0180: IL_85
    IL_0181: IL_01
    IL_0182: nop
    IL_0183: stloc.0
    IL_0188: br IL_018C
    IL_0189: ldc.i4.0
    IL_018B: stloc.s 5
    IL_018D: ldloc.s 7
    IL_0192: ldstr 0x70022E0F
    IL_0193: conv.r8
    IL_0194: conv.r.un
    IL_0195: ldarg.0
    IL_0196: nop
    IL_0197: stloc.0
    IL_019C: brfalse IL_01DC
    IL_019D: ldloc.0
    IL_019E: ldloc.3
    IL_019F: conv.r8
    IL_01A0: conv.i2
    IL_01A1: ldarg.0
    IL_01A2: nop
    IL_01A3: stloc.0
    IL_01A4: conv.u4
    IL_01A6: bgt.s IL_01A7
    IL_01A7: nop
    IL_01A8: IL_01
    IL_01A9: conv.r8
    IL_01AA: IL_A9
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: stloc.0
    IL_01AE: conv.r8
    IL_01AF: conv.i4
    IL_01B0: ldarg.0
    IL_01B1: nop
    IL_01B2: stloc.0
    IL_01B3: len
    IL_01B4: not
    IL_01B9: brtrue IL_01C5
    IL_01BA: ldarg.0
    IL_01BF: ldfld 0x04000A09
    IL_01C4: brfalse IL_01DC
    IL_01C6: ldloc.s 7
    IL_01CB: ldstr 0x70022E0F
    IL_01CC: conv.r8
    IL_01CD: IL_77
    IL_01CE: ldarg.0
    IL_01CF: nop
    IL_01D0: stloc.0
    IL_01D1: ldnull
    IL_01D6: call 0x0A000021
    IL_01DB: brtrue IL_01ED
    IL_01DD: ldloc.s 7
    IL_01E2: ldstr 0x70022E0F
    IL_01E3: conv.r8
    IL_01E4: conv.r.un
    IL_01E5: ldarg.0
    IL_01E6: nop
    IL_01E7: stloc.0
    IL_01EC: brtrue IL_02AC
    IL_01EE: ldloc.s 7
    IL_01EF: conv.r8
    IL_01F0: IL_78
    IL_01F1: ldarg.0
    IL_01F2: nop
    IL_01F3: stloc.0
    IL_01F4: IL_22
    IL_01F5: nop
    IL_01F6: nop
    IL_01FB: stsfld 0x0000223F
    IL_0200: stsfld 0x0038733F
    IL_0201: nop
    IL_0202: stloc.0
    IL_0207: call 0x0A000279
    IL_020C: brfalse IL_02AC
    IL_020E: ldloc.s 7
    IL_020F: conv.r8
    IL_0214: newobj 0x280A0001
    IL_0215: IL_57
    IL_0216: nop
    IL_0217: nop
    IL_0218: stloc.0
    IL_021D: call 0x0A000279
    IL_0222: brfalse IL_02AC
    IL_0224: ldloc.s 7
    IL_0225: conv.r8
    IL_0226: throw
    IL_0227: ldarg.0
    IL_0228: nop
    IL_0229: stloc.0
    IL_022A: ldnull
    IL_022F: call 0x0A000021
    IL_0234: brfalse IL_02AC
    IL_0236: ldloc.s 7
    IL_0237: conv.r8
    IL_0239: blt.s IL_023A
    IL_023A: nop
    IL_023B: stloc.0
    IL_023C: ldnull
    IL_0241: call 0x0A000021
    IL_0246: brfalse IL_02AC
    IL_0247: ldarg.0
    IL_024C: ldfld 0x04000A0C
    IL_024E: ldloc.s 7
    IL_024F: conv.r8
    IL_0250: throw
    IL_0251: ldarg.0
    IL_0252: nop
    IL_0253: stloc.0
    IL_0254: conv.r8
    IL_0259: ldfld 0x390A0002
    IL_025A: ldc.i4.8
    IL_025B: nop
    IL_025C: nop
    IL_025D: nop
    IL_025E: ldarg.0
    IL_0263: ldfld 0x04000A0C
    IL_0265: ldloc.s 7
    IL_0266: conv.r8
    IL_0267: throw
    IL_0268: ldarg.0
    IL_0269: nop
    IL_026A: stloc.0
    IL_026B: conv.r8
    IL_0270: ldflda 0x110A0002
    IL_0271: ldloc.1
    IL_0272: conv.r8
    IL_0277: stfld 0x380A0002
    IL_0279: bgt.s IL_027A
    IL_027A: nop
    IL_027B: nop
    IL_027C: ldarg.0
    IL_0281: ldfld 0x04000A0C
    IL_0283: ldloc.s 7
    IL_0284: conv.r8
    IL_0285: throw
    IL_0286: ldarg.0
    IL_0287: nop
    IL_0288: stloc.0
    IL_028D: newobj 0x0A00027E
    IL_028E: conv.r8
    IL_0293: ldsflda 0x020A0002
    IL_0298: ldfld 0x04000A0C
    IL_029A: ldloc.s 7
    IL_029B: conv.r8
    IL_029C: throw
    IL_029D: ldarg.0
    IL_029E: nop
    IL_029F: stloc.0
    IL_02A0: conv.r8
    IL_02A5: ldflda 0x110A0002
    IL_02A6: ldloc.1
    IL_02A7: conv.r8
    IL_02AC: stfld 0x110A0002
    IL_02AD: ldloc.3
    IL_02AE: ldc.i4.1
    IL_02AF: IL_58
    IL_02B1: stloc.s 9
    IL_02B3: ldloc.s 9
    IL_02B5: ldloc.s 8
    IL_02B6: len
    IL_02B7: not
    IL_02B8: IL_3F
    IL_02BA: bge.s IL_02B9
    IL_02BB: IL_FF
    IL_02BC: IL_FF
    IL_02BD: ldarg.0
    IL_02C2: ldfld 0x04000A0A
    IL_02C7: brfalse IL_0335
    IL_02C9: ldloc.s 5
    IL_02CE: brfalse IL_0335
    IL_02CF: ldloc.0
    IL_02D0: ldloc.3
    IL_02D1: conv.r8
    IL_02D2: conv.i2
    IL_02D3: ldarg.0
    IL_02D4: nop
    IL_02D5: stloc.0
    IL_02D6: conv.u4
    IL_02D8: bgt.s IL_02D9
    IL_02D9: nop
    IL_02DA: IL_01
    IL_02DB: conv.r8
    IL_02DC: IL_A9
    IL_02DD: nop
    IL_02DE: nop
    IL_02DF: stloc.0
    IL_02E0: conv.r8
    IL_02E1: IL_8F
    IL_02E2: IL_01
    IL_02E3: nop
    IL_02E4: stloc.0
    IL_02E6: stloc.s 13
    IL_02E7: ldc.i4.0
    IL_02E9: stloc.s 14
    IL_02EE: br IL_0312
    IL_02F0: ldloc.s 13
    IL_02F2: ldloc.s 14
    IL_02F3: IL_8F
    IL_02F4: ldnull
    IL_02F5: nop
    IL_02F6: nop
    IL_02F7: IL_01
    IL_02F8: IL_22
    IL_02F9: nop
    IL_02FA: nop
    IL_02FB: nop
    IL_02FC: IL_3F
    IL_02FD: IL_22
    IL_02FE: nop
    IL_02FF: nop
    IL_0300: nop
    IL_0301: IL_3F
    IL_0306: newobj 0x0A000038
    IL_0307: IL_81
    IL_0308: ldnull
    IL_0309: nop
    IL_030A: nop
    IL_030B: IL_01
    IL_030D: ldloc.s 14
    IL_030E: ldc.i4.1
    IL_030F: IL_58
    IL_0311: stloc.s 14
    IL_0313: ldloc.s 14
    IL_0315: ldloc.s 13
    IL_0316: len
    IL_0317: not
    IL_0318: IL_3F
    IL_0319: IL_D2
    IL_031A: IL_FF
    IL_031B: IL_FF
    IL_031C: IL_FF
    IL_031D: ldloc.0
    IL_031E: ldloc.3
    IL_031F: conv.r8
    IL_0320: conv.i2
    IL_0321: ldarg.0
    IL_0322: nop
    IL_0323: stloc.0
    IL_0324: conv.u4
    IL_0326: bgt.s IL_0327
    IL_0327: nop
    IL_0328: IL_01
    IL_0329: conv.r8
    IL_032A: IL_A9
    IL_032B: nop
    IL_032C: nop
    IL_032D: stloc.0
    IL_032F: ldloc.s 13
    IL_0330: conv.r8
    IL_0331: IL_AC
    IL_0332: nop
    IL_0333: nop
    IL_0334: stloc.0
    IL_0335: ldloc.3
    IL_0336: ldc.i4.1
    IL_0337: IL_58
    IL_0338: stloc.3
    IL_0339: ldloc.3
    IL_033A: ldloc.0
    IL_033B: conv.r8
    IL_0340: stsfld 0x3F0A0002
    IL_0341: IL_DE
    IL_0342: IL_FC
    IL_0343: IL_FF
    IL_0344: IL_FF
    IL_0345: ldarg.0
    IL_034A: ldfld 0x04000A0C
    IL_034B: conv.r8
    IL_034C: IL_81
    IL_034D: ldarg.0
    IL_034E: nop
    IL_034F: stloc.0
    IL_0350: conv.r8
    IL_0351: IL_82
    IL_0352: ldarg.0
    IL_0353: nop
    IL_0354: stloc.0
    IL_0356: stloc.s 16
    IL_035B: br IL_057D
    IL_035D: ldloca.s 16
    IL_0362: call 0x0A000283
    IL_0364: stloc.s 15
    IL_0369: ldc.i4 1024
    IL_036E: ldc.i4 1024
    IL_0373: newobj 0x0A000270
    IL_0375: stloc.s 17
    IL_0376: ldarg.0
    IL_037B: ldfld 0x04000A0C
    IL_037D: ldloc.s 15
    IL_037E: conv.r8
    IL_0383: ldflda 0x6F0A0002
    IL_0384: IL_84
    IL_0385: ldarg.0
    IL_0386: nop
    IL_0387: stloc.0
    IL_038C: newarr 0x0100003C
    IL_038E: stloc.s 18
    IL_038F: ldarg.0
    IL_0394: ldfld 0x04000A0D
    IL_0396: ldloc.s 15
    IL_0398: ldloc.s 15
    IL_039D: newobj 0x0A000285
    IL_039E: conv.r8
    IL_039F: IL_86
    IL_03A0: ldarg.0
    IL_03A1: nop
    IL_03A2: stloc.0
    IL_03A3: ldc.i4.0
    IL_03A5: stloc.s 19
    IL_03AA: br IL_03D4
    IL_03AC: ldloc.s 18
    IL_03AE: ldloc.s 19
    IL_03AF: ldarg.0
    IL_03B4: ldfld 0x04000A0C
    IL_03B6: ldloc.s 15
    IL_03B7: conv.r8
    IL_03BC: ldflda 0x110A0002
    IL_03BE: stloc.s 111
    IL_03BF: IL_87
    IL_03C0: ldarg.0
    IL_03C1: nop
    IL_03C2: stloc.0
    IL_03C3: conv.r8
    IL_03C5: blt.s IL_03C6
    IL_03C6: nop
    IL_03C7: stloc.0
    IL_03C8: conv.u8
    IL_03C9: IL_3C
    IL_03CA: nop
    IL_03CB: nop
    IL_03CC: IL_01
    IL_03D1: stelem 0x58171311
    IL_03D3: stloc.s 19
    IL_03D5: ldloc.s 19
    IL_03D7: ldloc.s 18
    IL_03D8: len
    IL_03D9: not
    IL_03DA: IL_3F
    IL_03DB: IL_CC
    IL_03DC: IL_FF
    IL_03DD: IL_FF
    IL_03DE: IL_FF
    IL_03E0: ldloc.s 17
    IL_03E2: ldloc.s 18
    IL_03E3: ldc.i4.0
    IL_03E8: ldc.i4 2048
    IL_03E9: conv.r8
    IL_03EA: IL_88
    IL_03EB: ldarg.0
    IL_03EC: nop
    IL_03ED: stloc.0
    IL_03EF: stloc.s 20
    IL_03F1: ldloc.s 17
    IL_03F2: conv.r8
    IL_03F3: conv.u8
    IL_03F4: ldarg.0
    IL_03F5: nop
    IL_03F6: stloc.0
    IL_03F7: ldarg.0
    IL_03FC: ldfld 0x04000A0D
    IL_03FE: ldloc.s 15
    IL_03FF: conv.r8
    IL_0400: IL_89
    IL_0401: ldarg.0
    IL_0402: nop
    IL_0403: stloc.0
    IL_0404: ldarg.0
    IL_0409: ldfld 0x04000A0C
    IL_040B: ldloc.s 15
    IL_040C: conv.r8
    IL_0411: ldflda 0x160A0002
    IL_0412: conv.r8
    IL_0413: IL_87
    IL_0414: ldarg.0
    IL_0415: nop
    IL_0416: stloc.0
    IL_0417: conv.r8
    IL_0418: ldind.ref
    IL_0419: ldarg.0
    IL_041A: nop
    IL_041B: stloc.0
    IL_041C: ldarg.0
    IL_0421: ldfld 0x04000A0D
    IL_0423: ldloc.s 15
    IL_0424: conv.r8
    IL_0425: IL_89
    IL_0426: ldarg.0
    IL_0427: nop
    IL_0428: stloc.0
    IL_042A: ldloc.s 17
    IL_042B: conv.r8
    IL_042D: ldarga.s 0
    IL_042E: nop
    IL_042F: stloc.0
    IL_0430: ldarg.0
    IL_0435: ldfld 0x04000A0D
    IL_0437: ldloc.s 15
    IL_0438: conv.r8
    IL_0439: IL_89
    IL_043A: ldarg.0
    IL_043B: nop
    IL_043C: stloc.0
    IL_043D: ldarg.0
    IL_0442: ldfld 0x04000A0B
    IL_0443: conv.r8
    IL_0444: IL_85
    IL_0445: IL_01
    IL_0446: nop
    IL_0447: stloc.0
    IL_0448: ldc.i4.0
    IL_044A: stloc.s 21
    IL_044F: br IL_04A1
    IL_0450: ldarg.0
    IL_0455: ldfld 0x04000A0C
    IL_0457: ldloc.s 15
    IL_0458: conv.r8
    IL_045D: ldflda 0x110A0002
    IL_045E: ldc.i4.m1
    IL_045F: conv.r8
    IL_0460: IL_87
    IL_0461: ldarg.0
    IL_0462: nop
    IL_0463: stloc.0
    IL_0468: ldstr 0x70022E0F
    IL_0469: conv.r8
    IL_046A: conv.r.un
    IL_046B: ldarg.0
    IL_046C: nop
    IL_046D: stloc.0
    IL_0472: brfalse IL_049B
    IL_0474: ldloc.s 18
    IL_0476: ldloc.s 21
    IL_0477: ldarg.0
    IL_047C: ldfld 0x04000A0C
    IL_047E: ldloc.s 15
    IL_047F: conv.r8
    IL_0484: ldflda 0x110A0002
    IL_0485: ldc.i4.m1
    IL_0486: conv.r8
    IL_0487: IL_87
    IL_0488: ldarg.0
    IL_0489: nop
    IL_048A: stloc.0
    IL_048F: ldstr 0x70022E0F
    IL_0490: conv.r8
    IL_0491: IL_77
    IL_0492: ldarg.0
    IL_0493: nop
    IL_0494: stloc.0
    IL_0495: conv.u8
    IL_0496: IL_3C
    IL_0497: nop
    IL_0498: nop
    IL_0499: IL_01
    IL_049E: stelem 0x58171511
    IL_04A0: stloc.s 21
    IL_04A2: ldloc.s 21
    IL_04A4: ldloc.s 18
    IL_04A5: len
    IL_04A6: not
    IL_04A7: IL_3F
    IL_04A8: IL_A4
    IL_04A9: IL_FF
    IL_04AA: IL_FF
    IL_04AB: IL_FF
    IL_04B0: ldc.i4 1024
    IL_04B5: ldc.i4 1024
    IL_04BA: newobj 0x0A000270
    IL_04BC: stloc.s 17
    IL_04BE: ldloc.s 17
    IL_04C0: ldloc.s 18
    IL_04C1: ldc.i4.0
    IL_04C6: ldc.i4 2048
    IL_04C7: conv.r8
    IL_04C8: IL_88
    IL_04C9: ldarg.0
    IL_04CA: nop
    IL_04CB: stloc.0
    IL_04CD: stloc.s 22
    IL_04CF: ldloc.s 17
    IL_04D0: conv.r8
    IL_04D1: conv.u8
    IL_04D2: ldarg.0
    IL_04D3: nop
    IL_04D4: stloc.0
    IL_04D5: ldarg.0
    IL_04DA: ldfld 0x04000A0D
    IL_04DC: ldloc.s 15
    IL_04DD: conv.r8
    IL_04DE: IL_89
    IL_04DF: ldarg.0
    IL_04E0: nop
    IL_04E1: stloc.0
    IL_04E6: ldstr 0x70022E0F
    IL_04E7: conv.r8
    IL_04E8: conv.r.un
    IL_04E9: ldarg.0
    IL_04EA: nop
    IL_04EB: stloc.0
    IL_04F0: brfalse IL_050A
    IL_04F1: ldarg.0
    IL_04F6: ldfld 0x04000A0D
    IL_04F8: ldloc.s 15
    IL_04F9: conv.r8
    IL_04FA: IL_89
    IL_04FB: ldarg.0
    IL_04FC: nop
    IL_04FD: stloc.0
    IL_0502: ldstr 0x70022E0F
    IL_0504: ldloc.s 17
    IL_0505: conv.r8
    IL_0506: conv.u8
    IL_0507: IL_01
    IL_0508: nop
    IL_0509: stloc.0
    IL_050A: ldc.i4.0
    IL_050C: stloc.s 23
    IL_0511: br IL_0572
    IL_0512: ldarg.0
    IL_0517: ldfld 0x04000A0E
    IL_0518: ldarg.0
    IL_051D: ldfld 0x04000A0C
    IL_051F: ldloc.s 15
    IL_0520: conv.r8
    IL_0525: ldflda 0x110A0002
    IL_0526: ldc.i4.1
    IL_0527: conv.r8
    IL_0528: IL_87
    IL_0529: ldarg.0
    IL_052A: nop
    IL_052B: stloc.0
    IL_052D: ldloc.s 20
    IL_052F: ldloc.s 23
    IL_0530: IL_8F
    IL_0535: brtrue IL_71010536
    IL_053A: brtrue IL_6F01053B
    IL_053B: stind.i
    IL_053C: ldarg.0
    IL_053D: nop
    IL_053E: stloc.0
    IL_053F: ldarg.0
    IL_0544: ldfld 0x04000A0F
    IL_0545: ldarg.0
    IL_054A: ldfld 0x04000A0C
    IL_054C: ldloc.s 15
    IL_054D: conv.r8
    IL_0552: ldflda 0x110A0002
    IL_0553: ldc.i4.1
    IL_0554: conv.r8
    IL_0555: IL_87
    IL_0556: ldarg.0
    IL_0557: nop
    IL_0558: stloc.0
    IL_055A: ldloc.s 22
    IL_055C: ldloc.s 23
    IL_055D: IL_8F
    IL_0562: brtrue IL_71010563
    IL_0567: brtrue IL_6F010568
    IL_0568: stind.i
    IL_0569: ldarg.0
    IL_056A: nop
    IL_056B: stloc.0
    IL_056D: ldloc.s 23
    IL_056E: ldc.i4.1
    IL_056F: IL_58
    IL_0571: stloc.s 23
    IL_0573: ldloc.s 23
    IL_0575: ldloc.s 18
    IL_0576: len
    IL_0577: not
    IL_0578: IL_3F
    IL_0579: IL_95
    IL_057A: IL_FF
    IL_057B: IL_FF
    IL_057C: IL_FF
    IL_057E: ldloca.s 16
    IL_0583: call 0x0A00028C
    IL_0588: brtrue IL_035C
    IL_0589: IL_DD
    IL_058A: stloc.3
    IL_058B: nop
    IL_058C: nop
    IL_058D: nop
    IL_058F: ldloc.s 16
    IL_0594: newobj 0x1B00001A
    IL_0595: conv.r8
    IL_0596: ldelem.ref
    IL_0597: nop
    IL_0598: nop
    IL_0599: stloc.0
    IL_059A: IL_DC
    IL_059B: ldc.i4.0
    IL_059D: stloc.s 24
    IL_05A2: br IL_07D0
    IL_05A3: ldloc.0
    IL_05A5: ldloc.s 24
    IL_05A6: conv.r8
    IL_05A7: conv.i2
    IL_05A8: ldarg.0
    IL_05A9: nop
    IL_05AA: stloc.0
    IL_05AB: conv.u4
    IL_05AD: bgt.s IL_05AE
    IL_05AE: nop
    IL_05AF: IL_01
    IL_05B0: conv.r8
    IL_05B1: IL_A9
    IL_05B2: nop
    IL_05B3: nop
    IL_05B4: stloc.0
    IL_05B5: conv.r8
    IL_05BA: newarr 0x130A0002
    IL_05BB: ldc.i4.3
    IL_05BC: ldloc.0
    IL_05BE: ldloc.s 24
    IL_05BF: conv.r8
    IL_05C0: conv.i2
    IL_05C1: ldarg.0
    IL_05C2: nop
    IL_05C3: stloc.0
    IL_05C4: conv.r8
    IL_05C5: stloc.0
    IL_05C6: nop
    IL_05C7: nop
    IL_05C8: stloc.0
    IL_05C9: conv.r8
    IL_05CA: ldind.ref
    IL_05CB: IL_01
    IL_05CC: nop
    IL_05CD: stloc.0
    IL_05CE: conv.r8
    IL_05CF: conv.r8
    IL_05D0: ldarg.0
    IL_05D1: nop
    IL_05D2: stloc.0
    IL_05D4: stloc.s 26
    IL_05D5: ldloc.0
    IL_05D7: ldloc.s 24
    IL_05D8: conv.r8
    IL_05D9: conv.i2
    IL_05DA: ldarg.0
    IL_05DB: nop
    IL_05DC: stloc.0
    IL_05DD: conv.u4
    IL_05DF: bgt.s IL_05E0
    IL_05E0: nop
    IL_05E1: IL_01
    IL_05E2: conv.r8
    IL_05E3: IL_A9
    IL_05E4: nop
    IL_05E5: nop
    IL_05E6: stloc.0
    IL_05E7: conv.r8
    IL_05E8: IL_8F
    IL_05E9: IL_01
    IL_05EA: nop
    IL_05EB: stloc.0
    IL_05EC: stloc.1
    IL_05ED: ldloc.0
    IL_05EF: ldloc.s 24
    IL_05F0: conv.r8
    IL_05F1: conv.i2
    IL_05F2: ldarg.0
    IL_05F3: nop
    IL_05F4: stloc.0
    IL_05F5: conv.u4
    IL_05F7: bgt.s IL_05F8
    IL_05F8: nop
    IL_05F9: IL_01
    IL_05FA: conv.r8
    IL_05FB: IL_A9
    IL_05FC: nop
    IL_05FD: nop
    IL_05FE: stloc.0
    IL_05FF: conv.r8
    IL_0600: conv.i4
    IL_0601: ldarg.0
    IL_0602: nop
    IL_0603: stloc.0
    IL_0604: stloc.2
    IL_0605: ldc.i4.0
    IL_0607: stloc.s 27
    IL_060C: br IL_076A
    IL_060D: ldarg.0
    IL_0612: ldfld 0x04000A0E
    IL_0614: ldloc.s 26
    IL_0616: ldloc.s 27
    IL_0617: ldelem.i
    IL_0618: conv.r8
    IL_0619: len
    IL_061A: ldarg.0
    IL_061B: nop
    IL_061C: stloc.0
    IL_0621: brfalse IL_0764
    IL_0622: ldarg.0
    IL_0627: ldfld 0x04000A0E
    IL_0629: ldloc.s 26
    IL_062B: ldloc.s 27
    IL_062C: ldelem.i
    IL_062D: conv.r8
    IL_062E: IL_8F
    IL_062F: ldarg.0
    IL_0630: nop
    IL_0631: stloc.0
    IL_0633: stloc.s 28
    IL_0634: ldarg.0
    IL_0639: ldfld 0x04000A0F
    IL_063B: ldloc.s 26
    IL_063D: ldloc.s 27
    IL_063E: ldelem.i
    IL_063F: conv.r8
    IL_0640: IL_8F
    IL_0641: ldarg.0
    IL_0642: nop
    IL_0643: stloc.0
    IL_0645: stloc.s 29
    IL_0646: ldloc.0
    IL_0648: ldloc.s 24
    IL_0649: conv.r8
    IL_064A: conv.i2
    IL_064B: ldarg.0
    IL_064C: nop
    IL_064D: stloc.0
    IL_064E: conv.u4
    IL_0650: bgt.s IL_0651
    IL_0651: nop
    IL_0652: IL_01
    IL_0653: conv.r8
    IL_0654: IL_A9
    IL_0655: nop
    IL_0656: nop
    IL_0657: stloc.0
    IL_0659: ldloc.s 27
    IL_065A: conv.r8
    IL_065F: ldobj 0x280A0002
    IL_0660: neg
    IL_0661: ldarg.3
    IL_0662: nop
    IL_0663: ldloc.0
    IL_0664: conv.u8
    IL_0665: ldc.i4.5
    IL_0666: nop
    IL_0667: nop
    IL_0668: ldc.i4.5
    IL_066A: stloc.s 30
    IL_066C: ldloc.s 26
    IL_066E: ldloc.s 27
    IL_066F: ldarg.0
    IL_0674: ldfld 0x04000A0D
    IL_0675: ldloc.0
    IL_0677: ldloc.s 24
    IL_0678: conv.r8
    IL_0679: conv.i2
    IL_067A: ldarg.0
    IL_067B: nop
    IL_067C: stloc.0
    IL_067D: conv.r8
    IL_067E: stloc.0
    IL_067F: nop
    IL_0680: nop
    IL_0681: stloc.0
    IL_0682: conv.r8
    IL_0683: ldind.ref
    IL_0684: IL_01
    IL_0685: nop
    IL_0686: stloc.0
    IL_0687: conv.r8
    IL_0688: conv.r8
    IL_0689: ldarg.0
    IL_068A: nop
    IL_068B: stloc.0
    IL_068D: ldloc.s 27
    IL_068E: ldelem.i
    IL_068F: conv.r8
    IL_0690: throw
    IL_0691: ldarg.0
    IL_0692: nop
    IL_0693: stloc.0
    IL_0694: conv.r8
    IL_0695: IL_89
    IL_0696: ldarg.0
    IL_0697: nop
    IL_0698: stloc.0
    IL_069D: stelem 0x20131E11
    IL_069E: ldc.i4.0
    IL_06A0: stloc.s 33
    IL_06A5: br IL_0759
    IL_06A7: ldloc.s 32
    IL_06A9: ldloc.s 33
    IL_06AA: IL_94
    IL_06AC: stloc.s 31
    IL_06AD: ldloc.1
    IL_06AF: ldloc.s 31
    IL_06B0: IL_8F
    IL_06B1: ldnull
    IL_06B2: nop
    IL_06B3: nop
    IL_06B4: IL_01
    IL_06B5: ldloc.1
    IL_06B7: ldloc.s 31
    IL_06B8: IL_8F
    IL_06B9: ldnull
    IL_06BA: nop
    IL_06BB: nop
    IL_06BC: IL_01
    IL_06C1: ldfld 0x0A000059
    IL_06C3: ldloca.s 28
    IL_06C8: call 0x0A000291
    IL_06C9: IL_5A
    IL_06CB: ldloca.s 28
    IL_06D0: call 0x0A000292
    IL_06D1: IL_58
    IL_06D2: ldloc.1
    IL_06D4: ldloc.s 31
    IL_06D5: IL_8F
    IL_06D6: ldnull
    IL_06D7: nop
    IL_06D8: nop
    IL_06D9: IL_01
    IL_06DE: ldfld 0x0A00005A
    IL_06E0: ldloca.s 28
    IL_06E5: call 0x0A000293
    IL_06E6: IL_5A
    IL_06E8: ldloca.s 28
    IL_06ED: call 0x0A000294
    IL_06EE: IL_58
    IL_06F3: newobj 0x0A000038
    IL_06F4: IL_81
    IL_06F5: ldnull
    IL_06F6: nop
    IL_06F7: nop
    IL_06F8: IL_01
    IL_06F9: ldloc.2
    IL_06FE: brfalse IL_0753
    IL_06FF: ldloc.2
    IL_0700: len
    IL_0701: not
    IL_0706: brfalse IL_0753
    IL_0707: ldloc.2
    IL_0709: ldloc.s 31
    IL_070A: IL_8F
    IL_070B: ldnull
    IL_070C: nop
    IL_070D: nop
    IL_070E: IL_01
    IL_070F: ldloc.2
    IL_0711: ldloc.s 31
    IL_0712: IL_8F
    IL_0713: ldnull
    IL_0714: nop
    IL_0715: nop
    IL_0716: IL_01
    IL_071B: ldfld 0x0A000059
    IL_071D: ldloca.s 29
    IL_0722: call 0x0A000291
    IL_0723: IL_5A
    IL_0725: ldloca.s 29
    IL_072A: call 0x0A000292
    IL_072B: IL_58
    IL_072C: ldloc.2
    IL_072E: ldloc.s 31
    IL_072F: IL_8F
    IL_0730: ldnull
    IL_0731: nop
    IL_0732: nop
    IL_0733: IL_01
    IL_0738: ldfld 0x0A00005A
    IL_073A: ldloca.s 29
    IL_073F: call 0x0A000293
    IL_0740: IL_5A
    IL_0742: ldloca.s 29
    IL_0747: call 0x0A000294
    IL_0748: IL_58
    IL_074D: newobj 0x0A000038
    IL_074E: IL_81
    IL_074F: ldnull
    IL_0750: nop
    IL_0751: nop
    IL_0752: IL_01
    IL_0754: ldloc.s 33
    IL_0755: ldc.i4.1
    IL_0756: IL_58
    IL_0758: stloc.s 33
    IL_075A: ldloc.s 33
    IL_075C: ldloc.s 32
    IL_075D: len
    IL_075E: not
    IL_075F: IL_3F
    IL_0760: IL_42
    IL_0761: IL_FF
    IL_0762: IL_FF
    IL_0763: IL_FF
    IL_0765: ldloc.s 27
    IL_0766: ldc.i4.1
    IL_0767: IL_58
    IL_0769: stloc.s 27
    IL_076B: ldloc.s 27
    IL_076D: ldloc.s 25
    IL_076E: IL_3F
    IL_076F: ldelem.i
    IL_0771: 0xFE FF
    IL_0772: IL_FF
    IL_0773: ldloc.0
    IL_0775: ldloc.s 24
    IL_0776: conv.r8
    IL_0777: conv.i2
    IL_0778: ldarg.0
    IL_0779: nop
    IL_077A: stloc.0
    IL_077B: conv.r8
    IL_077C: stloc.0
    IL_077D: nop
    IL_077E: nop
    IL_077F: stloc.0
    IL_0780: conv.r8
    IL_0781: ldind.ref
    IL_0782: IL_01
    IL_0783: nop
    IL_0784: stloc.0
    IL_0786: ldloc.s 26
    IL_0787: conv.r8
    IL_0788: IL_95
    IL_0789: ldarg.0
    IL_078A: nop
    IL_078B: stloc.0
    IL_078C: ldloc.0
    IL_078E: ldloc.s 24
    IL_078F: conv.r8
    IL_0790: conv.i2
    IL_0791: ldarg.0
    IL_0792: nop
    IL_0793: stloc.0
    IL_0794: conv.u4
    IL_0796: bgt.s IL_0797
    IL_0797: nop
    IL_0798: IL_01
    IL_0799: conv.r8
    IL_079A: IL_A9
    IL_079B: nop
    IL_079C: nop
    IL_079D: stloc.0
    IL_079E: ldloc.1
    IL_079F: conv.r8
    IL_07A0: IL_AC
    IL_07A1: nop
    IL_07A2: nop
    IL_07A3: stloc.0
    IL_07A4: ldloc.2
    IL_07A9: brfalse IL_07CA
    IL_07AA: ldloc.2
    IL_07AB: len
    IL_07AC: not
    IL_07B1: brfalse IL_07CA
    IL_07B2: ldloc.0
    IL_07B4: ldloc.s 24
    IL_07B5: conv.r8
    IL_07B6: conv.i2
    IL_07B7: ldarg.0
    IL_07B8: nop
    IL_07B9: stloc.0
    IL_07BA: conv.u4
    IL_07BC: bgt.s IL_07BD
    IL_07BD: nop
    IL_07BE: IL_01
    IL_07BF: conv.r8
    IL_07C0: IL_A9
    IL_07C1: nop
    IL_07C2: nop
    IL_07C3: stloc.0
    IL_07C4: ldloc.2
    IL_07C5: conv.r8
    IL_07C6: conv.r4
    IL_07C7: ldarg.0
    IL_07C8: nop
    IL_07C9: stloc.0
    IL_07CB: ldloc.s 24
    IL_07CC: ldc.i4.1
    IL_07CD: IL_58
    IL_07CF: stloc.s 24
    IL_07D1: ldloc.s 24
    IL_07D2: ldloc.0
    IL_07D3: conv.r8
    IL_07D8: stsfld 0x3F0A0002
    IL_07D9: IL_C6
    IL_07DA: IL_FD
    IL_07DB: IL_FF
    IL_07DC: IL_FF
    IL_07DD: ret
    }

    public static void DeleteDuplicates() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_96
    IL_0003: ldarg.0
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldc.i4.1
    IL_000B: beq IL_0017
    IL_0010: ldstr 0x70022FFB
    IL_0015: newobj 0x0A000297
    IL_0016: throw
    IL_0017: ldarg.0
    IL_0018: conv.r8
    IL_0019: IL_98
    IL_001A: ldarg.0
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldc.i4.2
    IL_001E: IL_5A
    IL_0023: newobj 0x0A000299
    IL_0024: stloc.0
    IL_0029: newobj 0x0A00029A
    IL_002A: stloc.1
    IL_002B: ldarg.0
    IL_002C: conv.r8
    IL_002D: ldelem.i1
    IL_002E: ldarg.0
    IL_002F: nop
    IL_0030: stloc.0
    IL_0031: stloc.3
    IL_0036: br IL_005A
    IL_0037: ldloc.3
    IL_0038: conv.r8
    IL_0039: IL_98
    IL_003A: IL_01
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: stloc.2
    IL_003E: ldloc.0
    IL_003F: ldloc.2
    IL_0040: conv.r8
    IL_0041: ldelem.i2
    IL_0042: ldarg.0
    IL_0043: nop
    IL_0044: stloc.0
    IL_0049: brtrue IL_005A
    IL_004A: ldloc.1
    IL_004B: ldloc.2
    IL_004C: conv.r8
    IL_004D: ldelem.i4
    IL_004E: ldarg.0
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: pop
    IL_0052: ldloc.0
    IL_0053: ldloc.2
    IL_0054: ldnull
    IL_0055: conv.r8
    IL_0056: ldelem.i8
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldloc.3
    IL_005B: conv.r8
    IL_005C: IL_99
    IL_005D: IL_01
    IL_005E: nop
    IL_005F: stloc.0
    IL_0064: brtrue IL_0037
    IL_0065: IL_DD
    IL_0066: ldc.i4.m1
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: ldloc.3
    IL_006B: conv.u8
    IL_006D: brfalse.s IL_006E
    IL_006E: nop
    IL_006F: IL_01
    IL_0071: stloc.s 4
    IL_0073: ldloc.s 4
    IL_0075: brtrue.s IL_0077
    IL_0076: IL_DC
    IL_0078: ldloc.s 4
    IL_0079: conv.r8
    IL_007A: ldelem.ref
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: IL_DC
    IL_007F: ldloc.1
    IL_0080: ldarg.0
    IL_0081: conv.r8
    IL_0082: ldelem.r4
    IL_0083: ldarg.0
    IL_0084: nop
    IL_0085: stloc.0
    IL_0086: conv.r8
    IL_0087: ldelem.r8
    IL_0088: ldarg.0
    IL_0089: nop
    IL_008A: stloc.0
    IL_008B: conv.r8
    IL_008C: ldelem.ref
    IL_008D: ldarg.0
    IL_008E: nop
    IL_008F: stloc.0
    IL_0090: ret
    }

    static Shadow_eagle() {
    IL_0000: ldc.i4.2
    IL_0005: newarr 0x01000066
    IL_000A: stsfld 0x04000A11
    IL_000B: ldc.i4.2
    IL_0010: newarr 0x0100000C
    IL_0015: stsfld 0x04000A12
    IL_0016: ret
    }

    public static void InitStart() {
    IL_0004: ldstr 0x70023053
    IL_0009: call 0x06000401
    IL_000E: stsfld 0x04000A12
    IL_000F: ldc.i4.2
    IL_0014: newarr 0x01000045
    IL_0015: stloc.0
    IL_0016: ldc.i4.0
    IL_0017: stloc.1
    IL_001C: br IL_0068
    IL_001D: ldloc.0
    IL_001E: ldloc.1
    IL_0023: ldsfld 0x04000A12
    IL_0024: ldloc.1
    IL_0025: ldelem.i
    IL_002A: call 0x0A0002A2
    IL_002B: ldelem.r4
    IL_0030: ldsfld 0x04000A11
    IL_0031: ldloc.1
    IL_0032: IL_8F
    IL_0033: shr
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_01
    IL_0037: ldloc.0
    IL_0038: ldloc.1
    IL_0039: IL_96
    IL_003E: call 0x0A0002A3
    IL_003F: IL_81
    IL_0040: shr
    IL_0041: nop
    IL_0042: nop
    IL_0043: IL_01
    IL_0044: IL_DD
    IL_0045: ldc.i4.5
    IL_0046: nop
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.2
    IL_004E: ldsfld 0x04000A11
    IL_004F: ldloc.1
    IL_0050: IL_8F
    IL_0051: shr
    IL_0052: nop
    IL_0053: nop
    IL_0054: IL_01
    IL_0059: call 0x0A0001EC
    IL_005A: IL_81
    IL_005B: shr
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_01
    IL_005F: IL_DD
    IL_0060: nop
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldloc.1
    IL_0065: ldc.i4.1
    IL_0066: IL_58
    IL_0067: stloc.1
    IL_0068: ldloc.1
    IL_0069: ldc.i4.2
    IL_006A: IL_3F
    IL_006B: IL_AE
    IL_006C: IL_FF
    IL_006D: IL_FF
    IL_006E: IL_FF
    IL_006F: ret
    }

    public static void SetDelay() {
    IL_0004: ldsfld 0x04000A14
    IL_0006: ldloca.s 0
    IL_000D: constrained 0x01000066
    IL_0012: call 0x0A0002A4
    IL_0017: brfalse IL_0019
    IL_0018: ret
    IL_001D: ldsfld 0x04000A11
    IL_001E: ldarg.0
    IL_001F: IL_8F
    IL_0020: shr
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_01
    IL_0028: ldsfld 0x04000A14
    IL_0029: IL_81
    IL_002A: shr
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_01
    IL_0032: ldsfld 0x04000A12
    IL_0033: ldarg.0
    IL_0038: ldsfld 0x04000A11
    IL_0039: ldarg.0
    IL_003A: IL_8F
    IL_003B: shr
    IL_003C: nop
    IL_003D: nop
    IL_003E: IL_01
    IL_0043: call 0x0A0002A5
    IL_0044: stloc.1
    IL_0046: ldloca.s 1
    IL_004B: call 0x0A0002A6
    IL_0050: stelem 0x02305372
    IL_0055: cpobj 0x000A127E
    IL_0056: ldarg.2
    IL_005B: call 0x060003FF
    IL_005C: pop
    IL_005D: ret
    }

    public static void SetRemain() {
    IL_0004: ldstr 0x7002305B
    IL_0005: ldc.i4.1
    IL_000A: newarr 0x0100000B
    IL_000B: dup
    IL_000C: ldc.i4.0
    IL_000D: ldarg.0
    IL_000E: ldelem.i8
    IL_0013: call 0x060003F8
    IL_0014: pop
    IL_0015: ret
    }

    public static void EraseAll() {
    IL_0000: ldc.i4.2
    IL_0005: newarr 0x0100000C
    IL_000A: stsfld 0x04000A12
    IL_000B: ldc.i4.2
    IL_0010: newarr 0x01000066
    IL_0015: stsfld 0x04000A11
    IL_0016: ldc.i4.0
    IL_0017: stloc.0
    IL_001C: br IL_0087
    IL_0021: ldsfld 0x04000A14
    IL_0023: ldloca.s 1
    IL_002A: constrained 0x01000066
    IL_002F: call 0x0A0002A4
    IL_0034: brfalse IL_004F
    IL_0039: ldsfld 0x04000A11
    IL_003A: ldloc.0
    IL_003B: IL_8F
    IL_003C: shr
    IL_003D: nop
    IL_003E: nop
    IL_003F: IL_01
    IL_0044: call 0x0A0002A7
    IL_0045: IL_81
    IL_0046: shr
    IL_0047: nop
    IL_0048: nop
    IL_0049: IL_01
    IL_004E: br IL_0064
    IL_0053: ldsfld 0x04000A11
    IL_0054: ldloc.0
    IL_0055: IL_8F
    IL_0056: shr
    IL_0057: nop
    IL_0058: nop
    IL_0059: IL_01
    IL_005E: ldsfld 0x04000A14
    IL_005F: IL_81
    IL_0060: shr
    IL_0061: nop
    IL_0062: nop
    IL_0063: IL_01
    IL_0068: ldsfld 0x04000A12
    IL_0069: ldloc.0
    IL_006E: ldsfld 0x04000A11
    IL_006F: ldloc.0
    IL_0070: IL_8F
    IL_0071: shr
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_01
    IL_0079: call 0x0A0002A5
    IL_007A: stloc.2
    IL_007C: ldloca.s 2
    IL_0081: call 0x0A0002A6
    IL_0086: stelem 0x0A581706
    IL_0087: ldloc.0
    IL_0088: ldc.i4.2
    IL_0089: IL_3F
    IL_008A: IL_8F
    IL_008B: IL_FF
    IL_008C: IL_FF
    IL_008D: IL_FF
    IL_0092: ldstr 0x70023053
    IL_0097: ldsfld 0x04000A12
    IL_009C: call 0x060003FF
    IL_009D: pop
    IL_009E: ret
    }

    public static void RequestServerTime() {
    IL_0004: call 0x0A0001EC
    IL_0009: stsfld 0x04000A14
    IL_000A: ret
    }

    public static void SubtractDelay() {
    IL_0004: ldsfld 0x04000A14
    IL_0006: ldloca.s 1
    IL_000D: constrained 0x01000066
    IL_0012: call 0x0A0002A4
    IL_0017: brfalse IL_001A
    IL_0018: ldc.i4.0
    IL_0019: ret
    IL_001E: ldsflda 0x04000A14
    IL_0023: ldsfld 0x04000A11
    IL_0024: ldarg.0
    IL_0025: IL_8F
    IL_0026: shr
    IL_0027: nop
    IL_0028: nop
    IL_0029: IL_01
    IL_002E: ldobj 0x01000066
    IL_0033: call 0x0A0002A8
    IL_0038: stsfld 0x04000A13
    IL_0039: ldc.i4.0
    IL_003A: stloc.0
    IL_003F: ldsflda 0x04000A13
    IL_0044: call 0x0A0002A9
    IL_0045: not
    IL_0046: stloc.0
    IL_0047: ldloc.0
    IL_0048: ldc.i4.0
    IL_004D: ldc.i4 10000
    IL_0052: call 0x0A0002AA
    IL_0053: stloc.0
    IL_0054: ldloc.0
    IL_0055: ret
    }

    private static void GameQuit() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_002A
    IL_000B: ldsfld 0x04000A12
    IL_000C: ldloc.0
    IL_0011: ldsfld 0x04000A11
    IL_0012: ldloc.0
    IL_0013: IL_8F
    IL_0014: shr
    IL_0015: nop
    IL_0016: nop
    IL_0017: IL_01
    IL_001C: call 0x0A0002A5
    IL_001D: stloc.1
    IL_001F: ldloca.s 1
    IL_0024: call 0x0A0002A6
    IL_0029: stelem 0x0A581706
    IL_002A: ldloc.0
    IL_002B: ldc.i4.2
    IL_002C: IL_3F
    IL_002D: IL_D6
    IL_002E: IL_FF
    IL_002F: IL_FF
    IL_0030: IL_FF
    IL_0035: ldstr 0x70023053
    IL_003A: ldsfld 0x04000A12
    IL_003F: call 0x060003FF
    IL_0040: pop
    IL_0041: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0006: stfld 0x04000A15
    IL_0007: ldarg.0
    IL_0008: ldc.i4.5
    IL_000D: stfld 0x04000A16
    IL_000E: ldarg.0
    IL_0010: ldc.i4.s 20
    IL_0015: stfld 0x04000A17
    IL_0016: ldarg.0
    IL_0017: ldc.i4.m1
    IL_001C: stfld 0x04000A19
    IL_001D: ldarg.0
    IL_0022: call 0x0A000001
    IL_0023: ret
    }

    private void Awake() {
    IL_0000: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000A1A
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A15
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A16
    IL_0018: IL_5A
    IL_001D: stfld 0x04000A1B
    IL_001E: ldarg.0
    IL_001F: IL_22
    IL_0020: nop
    IL_0021: nop
    IL_0026: stsfld 0x157B023F
    IL_0027: stloc.0
    IL_0028: nop
    IL_0029: ldarg.2
    IL_002A: conv.i2
    IL_002B: add
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_0033: stsfld 0x167B023F
    IL_0034: stloc.0
    IL_0035: nop
    IL_0036: ldarg.2
    IL_0037: conv.i2
    IL_0038: add
    IL_003D: newobj 0x0A000038
    IL_0042: stfld 0x04000A1C
    IL_0043: ldarg.0
    IL_0044: ldarg.0
    IL_0049: call 0x0A00000D
    IL_004A: conv.r8
    IL_004C: ldarg.s 0
    IL_004D: nop
    IL_004E: stloc.0
    IL_0053: stfld 0x04000A23
    IL_0054: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000A20
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04000A20
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A22
    IL_001C: brfalse IL_00B8
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000A20
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_002A: stsfld 0x00304340
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000A24
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000A24
    IL_0039: conv.r8
    IL_003E: cpobj 0x280A0000
    IL_003F: ldc.i4.5
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: call 0x0A000024
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004D: ldloc 23108
    IL_0052: call 0x0A0000B2
    IL_0053: conv.r8
    IL_0054: IL_AF
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_005C: br IL_00B7
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000A20
    IL_0063: IL_22
    IL_0064: shr
    IL_0065: shr
    IL_0066: pop
    IL_12977: switch (19011 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    static Shadow_eagle() {
    IL_0004: newobj 0x0A0002AB
    IL_0009: stsfld 0x04000A26
    IL_000A: ret
    }

    public static void IsNumeric() {
    IL_0004: ldstr 0x70023063
    IL_0009: newobj 0x0A0002AC
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: conv.r8
    IL_000E: IL_AD
    IL_000F: ldarg.0
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ret
    }

    public static void GetFileData() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newobj 0x0A0002AE
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: conv.r8
    IL_000A: IL_AF
    IL_000B: ldarg.0
    IL_000C: nop
    IL_000D: stloc.0
    IL_000E: IL_D4
    IL_0013: newarr 0x01000083
    IL_0014: stloc.1
    IL_0015: ldloc.0
    IL_0016: ldloc.1
    IL_0017: ldc.i4.0
    IL_0018: ldloc.1
    IL_0019: len
    IL_001A: not
    IL_001B: conv.r8
    IL_001C: IL_B0
    IL_001D: ldarg.0
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: pop
    IL_0021: ldloc.0
    IL_0022: conv.r8
    IL_0023: xor
    IL_0024: IL_01
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: ldloc.1
    IL_0028: ret
    }

    public static void IsEmpty() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00020C
    IL_0006: stloc.1
    IL_0007: IL_DD
    IL_0008: ldc.i4.7
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: IL_DD
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldloc.0
    IL_0013: conv.r8
    IL_0014: shl
    IL_0015: IL_01
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: call 0x0A0002B1
    IL_001D: ldc.i4.1
    IL_001E: stloc.1
    IL_001F: IL_DD
    IL_0020: ldarg.3
    IL_0021: nop
    IL_0022: nop
    IL_0023: nop
    IL_0024: IL_DD
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_0029: ldloc.1
    IL_002A: ret
    }

    public static void ToString() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x0A0002B2
    IL_0007: ret
    }

    public static void EqualsIgnoreCase() {
    IL_0000: ldarg.0
    IL_0005: brfalse IL_000C
    IL_0006: ldarg.1
    IL_000B: brtrue IL_000E
    IL_000C: ldc.i4.0
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: conv.r8
    IL_0010: conv.ovf.i4.un
    IL_0011: ldarg.0
    IL_0012: nop
    IL_0013: stloc.0
    IL_0014: ldarg.1
    IL_0015: conv.r8
    IL_0016: conv.ovf.i4.un
    IL_0017: ldarg.0
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: conv.r8
    IL_001B: IL_B4
    IL_001C: ldarg.0
    IL_001D: nop
    IL_001E: stloc.0
    IL_001F: ret
    }

    public static void ParseInt16() {
    IL_0000: ldarg.0
    IL_0005: call 0x06000579
    IL_000A: brfalse IL_000D
    IL_000B: ldc.i4.0
    IL_000C: ret
    IL_000D: ldc.i4.0
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0014: ldc.i4 515
    IL_0019: call 0x0A000215
    IL_001A: stloc.0
    IL_001B: IL_DD
    IL_001C: ldloc.0
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: pop
    IL_0021: IL_DD
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public static void ParseInt() {
    IL_0000: ldarg.0
    IL_0005: call 0x06000579
    IL_000A: brfalse IL_000D
    IL_000B: ldc.i4.0
    IL_000C: ret
    IL_000D: ldarg.0
    IL_0012: call 0x0A00009E
    IL_0013: ret
    }

    public static void ParseBool() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70023085
    IL_000A: call 0x0A0000EC
    IL_000B: ret
    }

    public static void ParseFloat() {
    IL_0000: ldarg.0
    IL_0005: call 0x06000579
    IL_000A: brfalse IL_0011
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: ret
    IL_0011: ldarg.0
    IL_0016: call 0x0A0002B5
    IL_0017: ret
    }

    public static void GetVal() {
    IL_0001: ldloca.s 6
    IL_0008: constrained 0x1B00001C
    IL_0009: ldloc.0
    IL_000E: newobj 0x1B00001C
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: brfalse IL_00D1
    IL_0016: ldarg.0
    IL_0017: ldarg.1
    IL_0018: conv.r8
    IL_0019: IL_B6
    IL_001A: ldarg.0
    IL_001B: nop
    IL_001C: stloc.0
    IL_0021: brfalse IL_00D1
    IL_0022: ldarg.0
    IL_0023: ldarg.1
    IL_0024: conv.r8
    IL_0025: IL_B7
    IL_0026: ldarg.0
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: stloc.1
    IL_002A: ldloc.1
    IL_002F: brfalse IL_00D1
    IL_0030: ldloc.1
    IL_0031: conv.r8
    IL_0032: IL_B8
    IL_0033: ldarg.0
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: stloc.2
    IL_0037: IL_22
    IL_0038: nop
    IL_0039: nop
    IL_003E: stsfld 0x13170D3F
    IL_003F: ldarg.2
    IL_0041: ldloca.s 4
    IL_0046: call 0x0A0002B9
    IL_0048: stloc.s 5
    IL_0049: ldloc.0
    IL_004E: brfalse IL_00CF
    IL_004F: ldloc.2
    IL_0054: call 0x0A00020C
    IL_0059: brtrue IL_00CF
    IL_005A: ldloc.0
    IL_005B: conv.u8
    IL_005C: stloc.1
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_01
    IL_0064: brfalse IL_0076
    IL_0065: ldloc.2
    IL_006A: call 0x0600057D
    IL_006F: newobj 0x0100000B
    IL_0070: stloc.0
    IL_0075: br IL_00CA
    IL_0076: ldloc.0
    IL_0077: conv.u8
    IL_0079: bge.s IL_007A
    IL_007A: nop
    IL_007B: IL_01
    IL_0080: brfalse IL_0092
    IL_0081: ldloc.2
    IL_0086: call 0x0A0002B5
    IL_008B: newobj 0x0100002F
    IL_008C: stloc.0
    IL_0091: br IL_00CA
    IL_0092: ldloc.0
    IL_0093: conv.u8
    IL_0095: stloc.s 0
    IL_0096: nop
    IL_0097: IL_01
    IL_009C: brfalse IL_00B3
    IL_009D: ldloc.2
    IL_00A2: ldstr 0x70023089
    IL_00A7: call 0x0A0000EC
    IL_00AC: newobj 0x01000013
    IL_00AD: stloc.0
    IL_00B2: br IL_00CA
    IL_00B3: ldloc.0
    IL_00B4: conv.u8
    IL_00B5: shr
    IL_00B6: nop
    IL_00B7: nop
    IL_00B8: IL_01
    IL_00BD: brfalse IL_00CA
    IL_00BE: ldloc.2
    IL_00C3: call 0x0A0002BA
    IL_00C8: newobj 0x01000066
    IL_00C9: stloc.0
    IL_00CE: br IL_00D1
    IL_00CF: ldloc.1
    IL_00D0: stloc.0
    IL_00D1: ldloc.0
    IL_00D6: castclass 0x1B00001C
    IL_00D7: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    public static void GetInt() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x0A0002BB
    IL_0007: ret
    }

    public static void GetString() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x0A00008D
    IL_0007: ret
    }

    public static void SetInt() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x0A00009F
    IL_0007: ret
    }

    public static void SetString() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x0A00008F
    IL_0007: ret
    }

    public static void DeleteKey() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0002BC
    IL_0006: ret
    }

    public static void HasKey() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0001E1
    IL_0006: ret
    }

    public static void Save() {
    IL_0004: call 0x0A0002BD
    IL_0005: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ldarg.0
    IL_000B: call 0x0600058B
    IL_000C: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_000C: call 0x0600058C
    IL_000D: ret
    }

    private void Init() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x0A0002BE
    IL_000A: stfld 0x04000A27
    IL_000B: ret
    }

    private void ParseString() {
    IL_0000: ldarg.1
    IL_0005: call 0x06000593
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_000C: brtrue IL_0013
    IL_000D: ldarg.0
    IL_0012: call 0x0600058B
    IL_0013: ldloc.0
    IL_0014: conv.u8
    IL_0015: ldc.i4.7
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldc.i4.5
    IL_001D: brfalse IL_0023
    IL_0022: br IL_002E
    IL_0023: ldloc.0
    IL_0024: conv.u8
    IL_0029: ldsfld 0x39010000
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: ldarg.0
    IL_002F: ldloc.0
    IL_0030: conv.u8
    IL_0031: ldc.i4.7
    IL_0032: nop
    IL_0033: nop
    IL_0034: ldc.i4.5
    IL_0039: stfld 0x04000A27
    IL_003A: ret
    }

    public void Add() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0011
    IL_000A: ldstr 0x70023093
    IL_000F: call 0x0A0002BF
    IL_0010: ret
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000A27
    IL_0017: ldarg.1
    IL_0018: ldarg.2
    IL_0019: conv.r8
    IL_001A: IL_C0
    IL_001B: ldarg.0
    IL_001C: nop
    IL_001D: stloc.0
    IL_001E: ret
    }

    public void Get() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A27
    IL_0006: ldarg.1
    IL_000B: call 0x2B000079
    IL_000C: ret
    }

    public void ContainKey() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0008
    IL_0006: ldc.i4.0
    IL_0007: ret
    IL_0008: ldarg.0
    IL_000D: ldfld 0x04000A27
    IL_000E: ldarg.1
    IL_000F: conv.r8
    IL_0010: IL_B6
    IL_0011: ldarg.0
    IL_0012: nop
    IL_0013: stloc.0
    IL_0014: ret
    }

    public virtual void ToString() {
    IL_0000: ldarg.0
    IL_0005: call 0x06000591
    IL_0006: ret
    }

    public void get_hashtableStr() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A27
    IL_000A: call 0x06000594
    IL_000B: ret
    }

    public static void Parse() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x0600058A
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ret
    }

    public static void Deserialize() {
    IL_0000: ldarg.0
    IL_0005: brtrue IL_0008
    IL_0006: ldnull
    IL_0007: ret
    IL_0008: ldarg.0
    IL_000D: call 0x06000597
    IL_000E: ret
    }

    public static void Serialize() {
    IL_0000: ldarg.0
    IL_0005: call 0x060005A5
    IL_0006: ret
    }

    private Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_000C: newobj 0x0A0002C2
    IL_0011: stfld 0x04000A29
    IL_0012: ret
    }

    public static void IsWordBreak() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0002CA
    IL_000A: brtrue IL_001E
    IL_000F: ldstr 0x700230F5
    IL_0010: ldarg.0
    IL_0011: conv.r8
    IL_0012: IL_CB
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldc.i4.m1
    IL_0018: ceq
    IL_0019: ldc.i4.0
    IL_001B: ceq
    IL_001D: br.s IL_001F
    IL_001E: ldc.i4.1
    IL_001F: ret
    }

    public static void Parse() {
    IL_0000: ldarg.0
    IL_0005: newobj 0x06000595
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: conv.r8
    IL_0009: ldelem.i1
    IL_000A: ldarg.3
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: stloc.1
    IL_000E: IL_DD
    IL_0010: ldloca.s 0
    IL_0011: nop
    IL_0012: nop
    IL_0013: IL_DD
    IL_0014: stloc.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldloc.0
    IL_001D: brfalse IL_0024
    IL_001E: ldloc.0
    IL_001F: conv.r8
    IL_0020: ldelem.ref
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: IL_DC
    IL_0025: ldloc.1
    IL_0026: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A29
    IL_0006: conv.r8
    IL_0007: IL_CC
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_000C: ldnull
    IL_0011: stfld 0x04000A29
    IL_0012: ret
    }

    private void ParseObject() {
    IL_0004: newobj 0x0A0002BE
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A29
    IL_000C: conv.r8
    IL_000D: IL_C5
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: pop
    IL_0012: ldarg.0
    IL_0017: call 0x060005A3
    IL_0018: stloc.2
    IL_0019: ldloc.2
    IL_001C: ldarg 3
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.2
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0028: stloc.s 0
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldloc.2
    IL_002C: ldc.i4.6
    IL_0031: beq IL_0039
    IL_0036: br IL_0040
    IL_0037: ldnull
    IL_0038: ret
    IL_003D: br IL_0012
    IL_003E: ldloc.0
    IL_003F: ret
    IL_0040: ldarg.0
    IL_0045: call 0x0600059D
    IL_0046: stloc.1
    IL_0047: ldloc.1
    IL_004C: brtrue IL_004F
    IL_004D: ldnull
    IL_004E: ret
    IL_004F: ldarg.0
    IL_0054: call 0x060005A3
    IL_0055: ldc.i4.5
    IL_005A: beq IL_005D
    IL_005B: ldnull
    IL_005C: ret
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000A29
    IL_0063: conv.r8
    IL_0064: IL_C5
    IL_0065: ldarg.0
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: pop
    IL_0069: ldloc.0
    IL_006A: ldloc.1
    IL_006B: ldarg.0
    IL_0070: call 0x0600059B
    IL_0071: conv.r8
    IL_0072: IL_C0
    IL_0073: ldarg.0
    IL_0074: nop
    IL_0075: stloc.0
    IL_007A: br IL_007B
    IL_007F: br IL_0012
    }

    private void ParseArray() {
    IL_0004: newobj 0x0A0002CD
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A29
    IL_000C: conv.r8
    IL_000D: IL_C5
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: pop
    IL_0012: ldc.i4.1
    IL_0013: stloc.1
    IL_0018: br IL_0066
    IL_0019: ldarg.0
    IL_001E: call 0x060005A3
    IL_001F: stloc.2
    IL_0020: ldloc.2
    IL_0022: stloc.s 4
    IL_0024: ldloc.s 4
    IL_0025: ldc.i4.4
    IL_0026: IL_59
    IL_0029: ldarg 3
    IL_002A: nop
    IL_002B: nop
    IL_002D: stloc.s 0
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: nop
    IL_0035: ldarg.s 0
    IL_0036: nop
    IL_0037: nop
    IL_0039: ldloc.s 4
    IL_003E: brfalse IL_0044
    IL_0043: br IL_0052
    IL_0044: ldnull
    IL_0045: ret
    IL_004A: br IL_0066
    IL_004B: ldc.i4.0
    IL_004C: stloc.1
    IL_0051: br IL_0066
    IL_0052: ldarg.0
    IL_0053: ldloc.2
    IL_0058: call 0x0600059C
    IL_0059: stloc.3
    IL_005A: ldloc.0
    IL_005B: ldloc.3
    IL_005C: conv.r8
    IL_005D: IL_CE
    IL_005E: ldarg.0
    IL_005F: nop
    IL_0060: stloc.0
    IL_0065: br IL_0066
    IL_0066: ldloc.1
    IL_006B: brtrue IL_0019
    IL_006C: ldloc.0
    IL_006D: ret
    }

    private void ParseValue() {
    IL_0000: ldarg.0
    IL_0005: call 0x060005A3
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldloc.0
    IL_000D: call 0x0600059C
    IL_000E: ret
    }

    private void ParseByToken() {
    IL_0000: ldarg.1
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0003: ldc.i4.1
    IL_0004: IL_59
    IL_0007: ldarg 11
    IL_0008: nop
    IL_0009: nop
    IL_000B: stloc.s 0
    IL_000C: nop
    IL_000D: nop
    IL_000F: ble.s IL_0010
    IL_0010: nop
    IL_0011: nop
    IL_0012: ldc.i4.4
    IL_0013: nop
    IL_0014: nop
    IL_0015: nop
    IL_0017: ble.s IL_0018
    IL_0018: nop
    IL_0019: nop
    IL_001B: ble.s IL_001C
    IL_001C: nop
    IL_001D: nop
    IL_001F: ble.s IL_0020
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.3
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.2
    IL_0027: nop
    IL_0028: nop
    IL_0029: nop
    IL_0032: ldc.i8 3386706920453701632
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_003A: br IL_0067
    IL_003B: ldarg.0
    IL_0040: call 0x0600059D
    IL_0041: ret
    IL_0042: ldarg.0
    IL_0047: call 0x0600059E
    IL_0048: ret
    IL_0049: ldarg.0
    IL_004E: call 0x06000599
    IL_004F: ret
    IL_0050: ldarg.0
    IL_0055: call 0x0600059A
    IL_0056: ret
    IL_0057: ldc.i4.1
    IL_005C: newobj 0x01000013
    IL_005D: ret
    IL_005E: ldc.i4.0
    IL_0063: newobj 0x01000013
    IL_0064: ret
    IL_0065: ldnull
    IL_0066: ret
    IL_0067: ldnull
    IL_0068: ret
    }

    private void ParseString() {
    IL_0004: newobj 0x0A0001DD
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A29
    IL_000C: conv.r8
    IL_000D: IL_C5
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: pop
    IL_0012: ldc.i4.1
    IL_0013: stloc.2
    IL_0018: br IL_017C
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000A29
    IL_001F: conv.r8
    IL_0020: IL_C3
    IL_0021: ldarg.0
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ldc.i4.m1
    IL_0045: switch (7 cases)
    IL_0047: ldc.i4.s 92
    IL_004C: beq IL_0059
    IL_0051: br IL_016F
    IL_0052: ldc.i4.0
    IL_0053: stloc.2
    IL_0058: br IL_017C
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000A29
    IL_005F: conv.r8
    IL_0060: IL_C3
    IL_0061: ldarg.0
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldc.i4.m1
    IL_0085: switch (7 cases)
    IL_0086: nop
    IL_0087: nop
    IL_0088: nop
    IL_0089: nop
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: nop
    IL_008E: nop
    IL_008F: nop
    IL_0090: nop
    IL_0091: nop
    IL_0092: nop
    IL_0093: nop
    IL_0094: nop
    IL_0095: neg
    IL_0096: nop
    IL_0097: nop
    IL_0098: nop
    IL_0099: nop
    IL_009A: nop
    IL_009B: nop
    IL_009C: nop
    IL_009D: conv.r.un
    IL_009E: nop
    IL_009F: nop
    IL_00A0: nop
    IL_00A1: IL_84
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_00A6: ldloc.s 6
    IL_00A8: ldc.i4.s 34
    IL_00AD: beq IL_00D7
    IL_00AF: ldloc.s 6
    IL_00B1: ldc.i4.s 47
    IL_00B6: beq IL_00D7
    IL_00B8: ldloc.s 6
    IL_00BA: ldc.i4.s 92
    IL_00BF: beq IL_00D7
    IL_00C1: ldloc.s 6
    IL_00C3: ldc.i4.s 98
    IL_00C8: beq IL_00E4
    IL_00CA: ldloc.s 6
    IL_00CC: ldc.i4.s 102
    IL_00D1: beq IL_00F1
    IL_00D6: br IL_016A
    IL_00D7: ldloc.0
    IL_00D8: ldloc.1
    IL_00D9: conv.r8
    IL_00DA: IL_C6
    IL_00DB: ldarg.0
    IL_00DC: nop
    IL_00DD: stloc.0
    IL_00DE: pop
    IL_00E3: br IL_016A
    IL_00E4: ldloc.0
    IL_00E5: ldc.i4.8
    IL_00E6: conv.r8
    IL_00E7: IL_C6
    IL_00E8: ldarg.0
    IL_00E9: nop
    IL_00EA: stloc.0
    IL_00EB: pop
    IL_00F0: br IL_016A
    IL_00F1: ldloc.0
    IL_00F3: ldc.i4.s 12
    IL_00F4: conv.r8
    IL_00F5: IL_C6
    IL_00F6: ldarg.0
    IL_00F7: nop
    IL_00F8: stloc.0
    IL_00F9: pop
    IL_00FE: br IL_016A
    IL_00FF: ldloc.0
    IL_0101: ldc.i4.s 10
    IL_0102: conv.r8
    IL_0103: IL_C6
    IL_0104: ldarg.0
    IL_0105: nop
    IL_0106: stloc.0
    IL_0107: pop
    IL_010C: br IL_016A
    IL_010D: ldloc.0
    IL_010F: ldc.i4.s 13
    IL_0110: conv.r8
    IL_0111: IL_C6
    IL_0112: ldarg.0
    IL_0113: nop
    IL_0114: stloc.0
    IL_0115: pop
    IL_011A: br IL_016A
    IL_011B: ldloc.0
    IL_011D: ldc.i4.s 9
    IL_011E: conv.r8
    IL_011F: IL_C6
    IL_0120: ldarg.0
    IL_0121: nop
    IL_0122: stloc.0
    IL_0123: pop
    IL_0128: br IL_016A
    IL_0129: ldc.i4.4
    IL_012E: newarr 0x0100002A
    IL_012F: stloc.3
    IL_0130: ldc.i4.0
    IL_0132: stloc.s 4
    IL_0137: br IL_0148
    IL_0138: ldloc.3
    IL_013A: ldloc.s 4
    IL_013B: ldarg.0
    IL_0140: call 0x060005A1
    IL_0141: ldelem.i4
    IL_0143: ldloc.s 4
    IL_0144: ldc.i4.1
    IL_0145: IL_58
    IL_0147: stloc.s 4
    IL_0149: ldloc.s 4
    IL_014A: ldc.i4.4
    IL_014B: IL_3F
    IL_014C: IL_E8
    IL_014D: IL_FF
    IL_014E: IL_FF
    IL_014F: IL_FF
    IL_0150: ldloc.0
    IL_0151: ldloc.3
    IL_0156: newobj 0x0A0002CF
    IL_0158: ldc.i4.s 16
    IL_015D: call 0x0A0002D0
    IL_015E: IL_D1
    IL_015F: conv.r8
    IL_0160: IL_C6
    IL_0161: ldarg.0
    IL_0162: nop
    IL_0163: stloc.0
    IL_0164: pop
    IL_0169: br IL_016A
    IL_016E: br IL_017C
    IL_016F: ldloc.0
    IL_0170: ldloc.1
    IL_0171: conv.r8
    IL_0172: IL_C6
    IL_0173: ldarg.0
    IL_0174: nop
    IL_0175: stloc.0
    IL_0176: pop
    IL_017B: br IL_017C
    IL_017C: ldloc.2
    IL_0181: brtrue IL_0019
    IL_0182: ldloc.0
    IL_0183: conv.r8
    IL_0184: IL_E0
    IL_0185: IL_01
    IL_0186: nop
    IL_0187: stloc.0
    IL_0188: ret
    }

    private void ParseNumber() {
    IL_0000: ldarg.0
    IL_0005: call 0x060005A2
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0009: ldc.i4.s 46
    IL_000A: conv.r8
    IL_000B: IL_CB
    IL_000C: ldarg.0
    IL_000D: nop
    IL_000E: stloc.0
    IL_000F: ldc.i4.m1
    IL_0054: switch (16 cases)
    }

    private void EatWhitespace() {
    IL_0004: br IL_0027
    IL_0005: ldarg.0
    IL_000A: ldfld 0x04000A29
    IL_000B: conv.r8
    IL_000C: IL_C5
    IL_000D: ldarg.0
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: pop
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000A29
    IL_0017: conv.r8
    IL_0018: IL_C3
    IL_0019: ldarg.0
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldc.i4.m1
    IL_0035: switch (5 cases)
    IL_0036: IL_FF
    IL_0037: ret
    }

    private void get_PeekChar() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A29
    IL_0006: conv.r8
    IL_0007: IL_C3
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A0002C4
    IL_0010: ret
    }

    private void get_NextChar() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A29
    IL_0006: conv.r8
    IL_0007: IL_C5
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A0002C4
    IL_0010: ret
    }

    private void get_NextWord() {
    IL_0004: newobj 0x0A0001DD
    IL_0005: stloc.0
    IL_000A: br IL_002E
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_0011: call 0x060005A1
    IL_0012: conv.r8
    IL_0013: IL_C6
    IL_0014: ldarg.0
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: pop
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000A29
    IL_001E: conv.r8
    IL_001F: IL_C3
    IL_0020: ldarg.0
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: ldc.i4.m1
    IL_003C: switch (5 cases)
    IL_003D: IL_FF
    IL_003E: ldloc.0
    IL_003F: conv.r8
    IL_0040: IL_E0
    IL_0041: IL_01
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ret
    }

    private void get_NextToken() {
    IL_0000: ldarg.0
    IL_0005: call 0x0600059F
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A29
    IL_000C: conv.r8
    IL_000D: IL_C3
    IL_000E: ldarg.0
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldc.i4.m1
    IL_001E: switch (2 cases)
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0022: ldc.i4.s 34
    IL_0023: IL_59
    IL_0026: ldarg 25
    IL_0027: nop
    IL_0028: nop
    IL_0029: mul
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: IL_4F
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: rem.un
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: nop
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: nop
    IL_0061: rem.un
    IL_0062: nop
    IL_0063: nop
    IL_0064: nop
    IL_0065: rem.un
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: rem.un
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: rem.un
    IL_006E: nop
    IL_006F: nop
    IL_0070: nop
    IL_0071: rem.un
    IL_0072: nop
    IL_0073: nop
    IL_0074: nop
    IL_0075: rem.un
    IL_0076: nop
    IL_0077: nop
    IL_0078: nop
    IL_0079: rem.un
    IL_007A: nop
    IL_007B: nop
    IL_007C: nop
    IL_007D: rem.un
    IL_007E: nop
    IL_007F: nop
    IL_0080: nop
    IL_0081: rem.un
    IL_0082: nop
    IL_0083: nop
    IL_0084: nop
    IL_0085: rem.un
    IL_0086: nop
    IL_0087: nop
    IL_0088: nop
    IL_0089: div.un
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: ldloc.0
    IL_008F: ldc.i4.s 91
    IL_0090: IL_59
    IL_0093: ldarg 3
    IL_0094: nop
    IL_0095: nop
    IL_0096: ret
    IL_0097: nop
    IL_0098: nop
    IL_0099: nop
    IL_009A: nop
    IL_009B: nop
    IL_009C: nop
    IL_009D: nop
    IL_009F: brfalse.s IL_00A0
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: ldloc.0
    IL_00A4: ldc.i4.s 123
    IL_00A5: IL_59
    IL_00A8: ldarg 3
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: ldarg.3
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: nop
    IL_00B3: brfalse IL_70000B4
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: nop
    IL_00BB: br IL_00F0
    IL_00BC: ldc.i4.1
    IL_00BD: ret
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x04000A29
    IL_00C4: conv.r8
    IL_00C5: IL_C5
    IL_00C6: ldarg.0
    IL_00C7: nop
    IL_00C8: stloc.0
    IL_00C9: pop
    IL_00CA: ldc.i4.2
    IL_00CB: ret
    IL_00CC: ldc.i4.3
    IL_00CD: ret
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x04000A29
    IL_00D4: conv.r8
    IL_00D5: IL_C5
    IL_00D6: ldarg.0
    IL_00D7: nop
    IL_00D8: stloc.0
    IL_00D9: pop
    IL_00DA: ldc.i4.4
    IL_00DB: ret
    IL_00DC: ldarg.0
    IL_00E1: ldfld 0x04000A29
    IL_00E2: conv.r8
    IL_00E3: IL_C5
    IL_00E4: ldarg.0
    IL_00E5: nop
    IL_00E6: stloc.0
    IL_00E7: pop
    IL_00E8: ldc.i4.6
    IL_00E9: ret
    IL_00EA: ldc.i4.7
    IL_00EB: ret
    IL_00EC: ldc.i4.5
    IL_00ED: ret
    IL_00EE: ldc.i4.8
    IL_00EF: ret
    IL_00F0: ldarg.0
    IL_00F5: call 0x060005A2
    IL_00F6: stloc.1
    IL_00F7: ldloc.1
    IL_00FC: brfalse IL_016A
    IL_0101: ldsfld 0x04000A2A
    IL_0106: brtrue IL_0138
    IL_0107: ldc.i4.3
    IL_010C: newobj 0x0A0002C7
    IL_010D: stloc.2
    IL_010E: ldloc.2
    IL_0113: ldstr 0x70022ADA
    IL_0114: ldc.i4.0
    IL_0115: conv.r8
    IL_0116: IL_C8
    IL_0117: ldarg.0
    IL_0118: nop
    IL_0119: stloc.0
    IL_011A: ldloc.2
    IL_011F: ldstr 0x70000583
    IL_0120: ldc.i4.1
    IL_0121: conv.r8
    IL_0122: IL_C8
    IL_0123: ldarg.0
    IL_0124: nop
    IL_0125: stloc.0
    IL_0126: ldloc.2
    IL_012B: ldstr 0x700230EB
    IL_012C: ldc.i4.2
    IL_012D: conv.r8
    IL_012E: IL_C8
    IL_012F: ldarg.0
    IL_0130: nop
    IL_0131: stloc.0
    IL_0132: ldloc.2
    IL_0137: stsfld 0x04000A2A
    IL_013C: ldsfld 0x04000A2A
    IL_013D: ldloc.1
    IL_013F: ldloca.s 3
    IL_0140: conv.r8
    IL_0141: IL_C9
    IL_0142: ldarg.0
    IL_0143: nop
    IL_0144: stloc.0
    IL_0149: brfalse IL_016A
    IL_014A: ldloc.3
    IL_014D: ldarg 3
    IL_014E: nop
    IL_014F: nop
    IL_0150: ldarg.3
    IL_0151: nop
    IL_0152: nop
    IL_0153: nop
    IL_0154: ldloc.2
    IL_0155: nop
    IL_0156: nop
    IL_0157: nop
    IL_0158: stloc.1
    IL_0159: nop
    IL_015A: nop
    IL_015B: nop
    IL_0160: br IL_016A
    IL_0162: ldc.i4.s 10
    IL_0163: ret
    IL_0165: ldc.i4.s 9
    IL_0166: ret
    IL_0168: ldc.i4.s 11
    IL_0169: ret
    IL_016A: ldc.i4.0
    IL_016B: ret
    }

    private Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ldarg.0
    IL_000B: newobj 0x0A0001DD
    IL_0010: stfld 0x04000A38
    IL_0011: ret
    }

    public static void Serialize() {
    IL_0004: newobj 0x060005A4
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_0008: conv.r8
    IL_000D: isinst 0x06060005
    IL_0012: ldfld 0x04000A38
    IL_0013: conv.r8
    IL_0014: IL_E0
    IL_0015: IL_01
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    private void SerializeValue() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_001C
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A38
    IL_0010: ldstr 0x700230EB
    IL_0011: conv.r8
    IL_0012: IL_DF
    IL_0013: IL_01
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: pop
    IL_001B: br IL_00C6
    IL_001C: ldarg.1
    IL_001D: conv.u8
    IL_001E: stloc.2
    IL_001F: nop
    IL_0020: nop
    IL_0021: IL_01
    IL_0022: dup
    IL_0023: stloc.2
    IL_0028: brfalse IL_0035
    IL_0029: ldarg.0
    IL_002A: ldloc.2
    IL_002F: call 0x060005A9
    IL_0034: br IL_00C6
    IL_0035: ldarg.1
    IL_0036: conv.u8
    IL_0038: stloc.s 0
    IL_0039: nop
    IL_003A: IL_01
    IL_003F: brfalse IL_006B
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000A38
    IL_0046: ldarg.1
    IL_004B: castclass 0x01000013
    IL_0050: brfalse IL_005B
    IL_0055: ldstr 0x70000583
    IL_005A: br IL_0060
    IL_005F: ldstr 0x70022ADA
    IL_0060: conv.r8
    IL_0061: IL_DF
    IL_0062: IL_01
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: pop
    IL_006A: br IL_00C6
    IL_006B: ldarg.1
    IL_006C: conv.u8
    IL_006D: IL_86
    IL_006E: nop
    IL_006F: nop
    IL_0070: IL_01
    IL_0071: dup
    IL_0072: stloc.0
    IL_0077: brfalse IL_0084
    IL_0078: ldarg.0
    IL_0079: ldloc.0
    IL_007E: call 0x060005A8
    IL_0083: br IL_00C6
    IL_0084: ldarg.1
    IL_0085: conv.u8
    IL_0086: IL_87
    IL_0087: nop
    IL_0088: nop
    IL_0089: IL_01
    IL_008A: dup
    IL_008B: stloc.1
    IL_0090: brfalse IL_009D
    IL_0091: ldarg.0
    IL_0092: ldloc.1
    IL_0097: call 0x060005A7
    IL_009C: br IL_00C6
    IL_009D: ldarg.1
    IL_009E: conv.u8
    IL_009F: ret
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: IL_01
    IL_00A7: brfalse IL_00BF
    IL_00A8: ldarg.0
    IL_00A9: ldarg.1
    IL_00AE: castclass 0x0100002A
    IL_00AF: ldc.i4.1
    IL_00B4: newobj 0x0A0002D2
    IL_00B9: call 0x060005A9
    IL_00BE: br IL_00C6
    IL_00BF: ldarg.0
    IL_00C0: ldarg.1
    IL_00C5: call 0x060005AA
    IL_00C6: ret
    }

    private void SerializeObject() {
    IL_0000: ldc.i4.1
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0007: ldfld 0x04000A38
    IL_0009: ldc.i4.s 123
    IL_000A: conv.r8
    IL_000B: IL_C6
    IL_000C: ldarg.0
    IL_000D: nop
    IL_000E: stloc.0
    IL_000F: pop
    IL_0010: ldarg.1
    IL_0011: conv.r8
    IL_0012: IL_D3
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: conv.r8
    IL_0017: IL_D4
    IL_0018: ldarg.0
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: stloc.2
    IL_0020: br IL_0065
    IL_0021: ldloc.2
    IL_0022: conv.r8
    IL_0023: IL_98
    IL_0024: IL_01
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: stloc.1
    IL_0028: ldloc.0
    IL_002D: brtrue IL_003C
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000A38
    IL_0035: ldc.i4.s 44
    IL_0036: conv.r8
    IL_0037: IL_C6
    IL_0038: ldarg.0
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: pop
    IL_003C: ldarg.0
    IL_003D: ldloc.1
    IL_003E: conv.r8
    IL_003F: IL_B8
    IL_0040: ldarg.0
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: call 0x060005A9
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000A38
    IL_004F: ldc.i4.s 58
    IL_0050: conv.r8
    IL_0051: IL_C6
    IL_0052: ldarg.0
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: pop
    IL_0056: ldarg.0
    IL_0057: ldarg.1
    IL_0058: ldloc.1
    IL_0059: conv.r8
    IL_005A: IL_D5
    IL_005B: ldarg.0
    IL_005C: nop
    IL_005D: stloc.0
    IL_0062: call 0x060005A6
    IL_0063: ldc.i4.0
    IL_0064: stloc.0
    IL_0065: ldloc.2
    IL_0066: conv.r8
    IL_0067: IL_99
    IL_0068: IL_01
    IL_0069: nop
    IL_006A: stloc.0
    IL_006F: brtrue IL_0021
    IL_0070: IL_DD
    IL_0072: ldloca.s 0
    IL_0073: nop
    IL_0074: nop
    IL_0075: ldloc.2
    IL_0076: conv.u8
    IL_0078: brfalse.s IL_0079
    IL_0079: nop
    IL_007A: IL_01
    IL_007B: stloc.3
    IL_007C: ldloc.3
    IL_007E: brtrue.s IL_0080
    IL_007F: IL_DC
    IL_0080: ldloc.3
    IL_0081: conv.r8
    IL_0082: ldelem.ref
    IL_0083: nop
    IL_0084: nop
    IL_0085: stloc.0
    IL_0086: IL_DC
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000A38
    IL_008E: ldc.i4.s 125
    IL_008F: conv.r8
    IL_0090: IL_C6
    IL_0091: ldarg.0
    IL_0092: nop
    IL_0093: stloc.0
    IL_0094: pop
    IL_0095: ret
    }

    private void SerializeArray() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A38
    IL_0007: ldc.i4.s 91
    IL_0008: conv.r8
    IL_0009: IL_C6
    IL_000A: ldarg.0
    IL_000B: nop
    IL_000C: stloc.0
    IL_000D: pop
    IL_000E: ldc.i4.1
    IL_000F: stloc.0
    IL_0010: ldarg.1
    IL_0011: conv.r8
    IL_0012: IL_D4
    IL_0013: ldarg.0
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.2
    IL_001B: br IL_0040
    IL_001C: ldloc.2
    IL_001D: conv.r8
    IL_001E: IL_98
    IL_001F: IL_01
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: stloc.1
    IL_0023: ldloc.0
    IL_0028: brtrue IL_0037
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000A38
    IL_0030: ldc.i4.s 44
    IL_0031: conv.r8
    IL_0032: IL_C6
    IL_0033: ldarg.0
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: pop
    IL_0037: ldarg.0
    IL_0038: ldloc.1
    IL_003D: call 0x060005A6
    IL_003E: ldc.i4.0
    IL_003F: stloc.0
    IL_0040: ldloc.2
    IL_0041: conv.r8
    IL_0042: IL_99
    IL_0043: IL_01
    IL_0044: nop
    IL_0045: stloc.0
    IL_004A: brtrue IL_001C
    IL_004B: IL_DD
    IL_004D: ldloca.s 0
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldloc.2
    IL_0051: conv.u8
    IL_0053: brfalse.s IL_0054
    IL_0054: nop
    IL_0055: IL_01
    IL_0056: stloc.3
    IL_0057: ldloc.3
    IL_0059: brtrue.s IL_005B
    IL_005A: IL_DC
    IL_005B: ldloc.3
    IL_005C: conv.r8
    IL_005D: ldelem.ref
    IL_005E: nop
    IL_005F: nop
    IL_0060: stloc.0
    IL_0061: IL_DC
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000A38
    IL_0069: ldc.i4.s 93
    IL_006A: conv.r8
    IL_006B: IL_C6
    IL_006C: ldarg.0
    IL_006D: nop
    IL_006E: stloc.0
    IL_006F: pop
    IL_0070: ret
    }

    private void SerializeString() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A38
    IL_0007: ldc.i4.s 34
    IL_0008: conv.r8
    IL_0009: IL_C6
    IL_000A: ldarg.0
    IL_000B: nop
    IL_000C: stloc.0
    IL_000D: pop
    IL_000E: ldarg.1
    IL_000F: conv.r8
    IL_0012: ldloc 1
    IL_0013: stloc.0
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: stloc.2
    IL_0017: ldc.i4.0
    IL_0018: stloc.3
    IL_001D: br IL_0155
    IL_001E: ldloc.2
    IL_001F: ldloc.3
    IL_0020: IL_93
    IL_0021: stloc.1
    IL_0022: ldloc.1
    IL_0024: stloc.s 5
    IL_0026: ldloc.s 5
    IL_0027: ldc.i4.8
    IL_0028: IL_59
    IL_002B: ldarg 6
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_43
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldelem.i1
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: conv.r8
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_003E: IL_59
    IL_003F: nop
    IL_0040: nop
    IL_0041: nop
    IL_0042: IL_85
    IL_0043: nop
    IL_0044: nop
    IL_0045: nop
    IL_0047: ldloc.s 5
    IL_0049: ldc.i4.s 34
    IL_004E: beq IL_005D
    IL_0050: ldloc.s 5
    IL_0052: ldc.i4.s 92
    IL_0057: beq IL_0073
    IL_005C: br IL_00F7
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000A38
    IL_0067: ldstr 0x70022AFE
    IL_0068: conv.r8
    IL_0069: IL_DF
    IL_006A: IL_01
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: pop
    IL_0072: br IL_0151
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000A38
    IL_007D: ldstr 0x70022AF8
    IL_007E: conv.r8
    IL_007F: IL_DF
    IL_0080: IL_01
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: pop
    IL_0088: br IL_0151
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000A38
    IL_0093: ldstr 0x70022B16
    IL_0094: conv.r8
    IL_0095: IL_DF
    IL_0096: IL_01
    IL_0097: nop
    IL_0098: stloc.0
    IL_0099: pop
    IL_009E: br IL_0151
    IL_009F: ldarg.0
    IL_00A4: ldfld 0x04000A38
    IL_00A9: ldstr 0x70022B1C
    IL_00AA: conv.r8
    IL_00AB: IL_DF
    IL_00AC: IL_01
    IL_00AD: nop
    IL_00AE: stloc.0
    IL_00AF: pop
    IL_00B4: br IL_0151
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x04000A38
    IL_00BF: ldstr 0x70022B04
    IL_00C0: conv.r8
    IL_00C1: IL_DF
    IL_00C2: IL_01
    IL_00C3: nop
    IL_00C4: stloc.0
    IL_00C5: pop
    IL_00CA: br IL_0151
    IL_00CB: ldarg.0
    IL_00D0: ldfld 0x04000A38
    IL_00D5: ldstr 0x70022B0A
    IL_00D6: conv.r8
    IL_00D7: IL_DF
    IL_00D8: IL_01
    IL_00D9: nop
    IL_00DA: stloc.0
    IL_00DB: pop
    IL_00E0: br IL_0151
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x04000A38
    IL_00EB: ldstr 0x70022B10
    IL_00EC: conv.r8
    IL_00ED: IL_DF
    IL_00EE: IL_01
    IL_00EF: nop
    IL_00F0: stloc.0
    IL_00F1: pop
    IL_00F6: br IL_0151
    IL_00F7: ldloc.1
    IL_00FC: call 0x0A0002D6
    IL_00FE: stloc.s 4
    IL_0100: ldloc.s 4
    IL_0102: ldc.i4.s 32
    IL_0103: IL_3F
    IL_0104: ldc.i4.5
    IL_0105: nop
    IL_0106: nop
    IL_0107: nop
    IL_0109: ldloc.s 4
    IL_010B: ldc.i4.s 126
    IL_010C: IL_3D
    IL_010E: ldloca.s 0
    IL_010F: nop
    IL_0110: nop
    IL_0111: ldarg.0
    IL_0116: ldfld 0x04000A38
    IL_0117: ldloc.1
    IL_0118: conv.r8
    IL_0119: IL_C6
    IL_011A: ldarg.0
    IL_011B: nop
    IL_011C: stloc.0
    IL_011D: pop
    IL_0122: br IL_014C
    IL_0123: ldarg.0
    IL_0128: ldfld 0x04000A38
    IL_012D: ldstr 0x70023105
    IL_012E: conv.r8
    IL_012F: IL_DF
    IL_0130: IL_01
    IL_0131: nop
    IL_0132: stloc.0
    IL_0133: pop
    IL_0134: ldarg.0
    IL_0139: ldfld 0x04000A38
    IL_013B: ldloca.s 4
    IL_0140: ldstr 0x7002310B
    IL_0145: call 0x0A0002D7
    IL_0146: conv.r8
    IL_0147: IL_DF
    IL_0148: IL_01
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: pop
    IL_0150: br IL_0151
    IL_0151: ldloc.3
    IL_0152: ldc.i4.1
    IL_0153: IL_58
    IL_0154: stloc.3
    IL_0155: ldloc.3
    IL_0156: ldloc.2
    IL_0157: len
    IL_0158: not
    IL_0159: IL_3F
    IL_015A: IL_C0
    IL_015C: 0xFE FF
    IL_015D: IL_FF
    IL_015E: ldarg.0
    IL_0163: ldfld 0x04000A38
    IL_0165: ldc.i4.s 34
    IL_0166: conv.r8
    IL_0167: IL_C6
    IL_0168: ldarg.0
    IL_0169: nop
    IL_016A: stloc.0
    IL_016B: pop
    IL_016C: ret
    }

    private void SerializeOther() {
    IL_0000: ldarg.1
    IL_0001: conv.u8
    IL_0003: bge.s IL_0004
    IL_0004: nop
    IL_0005: IL_01
    IL_000A: brfalse IL_002F
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000A38
    IL_0011: ldarg.1
    IL_0016: castclass 0x0100002F
    IL_0017: stloc.0
    IL_0019: ldloca.s 0
    IL_001E: ldstr 0x70023111
    IL_0023: call 0x0A0001BB
    IL_0024: conv.r8
    IL_0025: IL_DF
    IL_0026: IL_01
    IL_0027: nop
    IL_0028: stloc.0
    IL_0029: pop
    IL_002E: br IL_00DF
    IL_002F: ldarg.1
    IL_0030: conv.u8
    IL_0031: stloc.1
    IL_0032: nop
    IL_0033: nop
    IL_0034: IL_01
    IL_0039: brtrue IL_0087
    IL_003A: ldarg.1
    IL_003B: conv.u8
    IL_003C: ldind.ref
    IL_003D: nop
    IL_003E: nop
    IL_003F: IL_01
    IL_0044: brtrue IL_0087
    IL_0045: ldarg.1
    IL_0046: conv.u8
    IL_0049: ldarg 0
    IL_004A: IL_01
    IL_004F: brtrue IL_0087
    IL_0050: ldarg.1
    IL_0051: conv.u8
    IL_0052: stind.i
    IL_0053: nop
    IL_0054: nop
    IL_0055: IL_01
    IL_005A: brtrue IL_0087
    IL_005B: ldarg.1
    IL_005C: conv.u8
    IL_005D: IL_83
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_01
    IL_0065: brtrue IL_0087
    IL_0066: ldarg.1
    IL_0067: conv.u8
    IL_0069: starg.s 0
    IL_006A: nop
    IL_006B: IL_01
    IL_0070: brtrue IL_0087
    IL_0071: ldarg.1
    IL_0072: conv.u8
    IL_0077: newobj 0x3A010000
    IL_0078: stloc.1
    IL_0079: nop
    IL_007A: nop
    IL_007B: nop
    IL_007C: ldarg.1
    IL_007D: conv.u8
    IL_0082: newarr 0x39010000
    IL_0084: ldloca.s 0
    IL_0085: nop
    IL_0086: nop
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000A38
    IL_008D: ldarg.1
    IL_008E: conv.r8
    IL_008F: IL_D8
    IL_0090: ldarg.0
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: pop
    IL_0098: br IL_00DF
    IL_0099: ldarg.1
    IL_009A: conv.u8
    IL_009B: not
    IL_009C: nop
    IL_009D: nop
    IL_009E: IL_01
    IL_00A3: brtrue IL_00AF
    IL_00A4: ldarg.1
    IL_00A5: conv.u8
    IL_00A6: len
    IL_00A7: nop
    IL_00A8: nop
    IL_00A9: IL_01
    IL_00AE: brfalse IL_00D3
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000A38
    IL_00B5: ldarg.1
    IL_00BA: call 0x0A0002D9
    IL_00BB: stloc.1
    IL_00BD: ldloca.s 1
    IL_00C2: ldstr 0x70023111
    IL_00C7: call 0x0A0002DA
    IL_00C8: conv.r8
    IL_00C9: IL_DF
    IL_00CA: IL_01
    IL_00CB: nop
    IL_00CC: stloc.0
    IL_00CD: pop
    IL_00D2: br IL_00DF
    IL_00D3: ldarg.0
    IL_00D4: ldarg.1
    IL_00D5: conv.r8
    IL_00D6: IL_B8
    IL_00D7: ldarg.0
    IL_00D8: nop
    IL_00D9: stloc.0
    IL_00DE: call 0x060005A9
    IL_00DF: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B00007A
    IL_000B: stfld 0x04000A3A
    IL_000C: ret
    }

    private void Update() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.1
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A39
    IL_0016: brfalse IL_0018
    IL_0017: ret
    IL_001C: call 0x0A0002DC
    IL_001D: ldc.i4.2
    IL_03C6: switch (233 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A3C
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000A3E
    IL_0018: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000CDD
    IL_000A: call 0x06000220
    IL_000B: neg
    IL_0010: stfld 0x04000A41
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A3B
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000A3C
    IL_001E: conv.r8
    IL_001F: ldc.i4.2
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0027: call 0x0A000013
    IL_002C: call 0x0A000014
    IL_002D: conv.u4
    IL_002E: ldarg.1
    IL_002F: nop
    IL_0030: nop
    IL_0031: IL_01
    IL_0036: stfld 0x04000A3D
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000A3D
    IL_003D: conv.r8
    IL_003E: stloc.0
    IL_003F: nop
    IL_0040: nop
    IL_0042: br.s IL_0045
    IL_0047: ldfld 0x04000A41
    IL_0048: ldc.i4.1
    IL_0049: IL_58
    IL_004A: conv.r8
    IL_004B: IL_F1
    IL_004C: ldloc.0
    IL_004D: nop
    IL_004E: ldloc.0
    IL_004F: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000C: ldc.i4.s 15
    IL_0281: switch (156 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A40
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_43
    IL_0010: brfalse IL_2000011
    IL_0011: dup
    IL_0016: ldfld 0x04000A40
    IL_001B: call 0x0A000024
    IL_001C: IL_59
    IL_0021: stfld 0x04000A40
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000A40
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_41
    IL_002E: ldc.i4.1
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldarg.0
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_003C: stfld 0x04000A40
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000A3E
    IL_0043: ldc.i4.1
    IL_0044: conv.r8
    IL_0046: ldc.i4.s 0
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000A49
    IL_0007: ldarg.0
    IL_000C: call 0x0A000001
    IL_000D: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A46
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A46
    IL_0012: conv.r8
    IL_0013: IL_B8
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: brfalse IL_0023
    IL_001C: ldarg.0
    IL_001D: ldc.i4.1
    IL_0022: stfld 0x04000A4F
    IL_0023: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000CDD
    IL_000A: call 0x06000220
    IL_000B: neg
    IL_0010: stfld 0x04000A4C
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000A4D
    IL_001B: brfalse IL_005F
    IL_001C: ldarg.0
    IL_001D: dup
    IL_0022: ldfld 0x04000A4A
    IL_0023: IL_22
    IL_0024: IL_CF
    IL_0025: IL_F7
    IL_0027: stloc.s 62
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000A4C
    IL_002E: conv.i2
    IL_002F: IL_5A
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000A4C
    IL_0036: conv.i2
    IL_0037: IL_5A
    IL_0038: IL_22
    IL_0039: IL_C3
    IL_003A: xor
    IL_003B: IL_CC
    IL_2931EC48: switch (172784386 cases)
    }

    public void Grabed() {
    IL_0000: ret
    }

    public void CastleBreak() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000A49
    IL_0007: ldarg.0
    IL_000C: call 0x0A000003
    IL_000D: ldc.i4.0
    IL_000E: conv.r8
    IL_0010: ldc.i4.s 0
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000A45
    IL_0019: conv.r8
    IL_001A: stloc.0
    IL_001B: nop
    IL_001C: nop
    IL_001D: stloc.0
    IL_0022: call 0x0A000050
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000A46
    IL_0029: ldc.i4.0
    IL_002A: conv.r8
    IL_002F: brtrue IL_6F0A0030
    IL_0030: stloc.0
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: call 0x0A000050
    IL_0039: ldarg.0
    IL_003E: ldfld 0x04000A4D
    IL_0043: brfalse IL_005A
    IL_0048: ldstr 0x70000BD5
    IL_004D: call 0x0A000004
    IL_004E: conv.r8
    IL_0057: ldc.i8 436971639665262592
    IL_0058: nop
    IL_0059: ldloc.0
    IL_005A: ret
    }

    public void TankDamage() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000A4B
    IL_0007: conv.i2
    IL_0008: ldarg.0
    IL_000D: ldfld 0x04000A4A
    IL_000E: conv.i2
    IL_000F: IL_22
    IL_0010: IL_CD
    IL_0011: IL_CC
    IL_0012: IL_CC
    IL_0013: IL_3D
    IL_0014: IL_5A
    IL_0015: IL_59
    IL_0016: neg
    IL_001B: stfld 0x04000A4B
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000A42
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000A4A
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000A4B
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000A46
    IL_0034: IL_22
    IL_0035: IL_CD
    IL_0036: IL_CC
    IL_0037: IL_4C
    IL_0038: IL_3E
    IL_0039: ldc.i4.m1
    IL_003A: conv.r8
    IL_003B: ldc.i4.3
    IL_003C: ldarg.1
    IL_003D: nop
    IL_003E: ldloc.0
    IL_003F: ldarg.0
    IL_0044: call 0x0A00002B
    IL_0045: conv.r8
    IL_0046: IL_4D
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000A4B
    IL_0050: ldc.i4.0
    IL_0051: IL_3D
    IL_0053: ldloc.s 0
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04000A49
    IL_0060: brfalse IL_0067
    IL_0061: ldarg.0
    IL_0066: call 0x060005B7
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000A49
    IL_006D: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000C: ldc.i4.s 20
    IL_000D: IL_3F
    IL_000E: IL_57
    IL_000F: ldarg.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: ldarg.1
    IL_0013: conv.r8
    IL_0014: stloc.0
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: conv.r8
    IL_0019: ldc.i4.8
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: stloc.1
    IL_001E: ldloc.1
    IL_0020: ldc.i4.s 18
    IL_0021: IL_59
    IL_0024: ldarg 14
    IL_0025: nop
    IL_0026: nop
    IL_0027: IL_D3
    IL_0028: IL_01
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_EA
    IL_002C: IL_01
    IL_002D: nop
    IL_002E: nop
    IL_002F: ldarg.3
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_8F
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: IL_B6
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_D7
    IL_003C: nop
    IL_003D: nop
    IL_003E: nop
    IL_0040: 0xFE 00
    IL_0041: nop
    IL_0042: nop
    IL_0044: ldc.i4.s 1
    IL_0045: nop
    IL_0046: nop
    IL_0047: IL_36
    IL_0048: IL_01
    IL_0049: nop
    IL_004A: nop
    IL_004B: rem.un
    IL_004C: IL_01
    IL_004D: nop
    IL_004E: nop
    IL_0053: ldobj 0x88000001
    IL_0054: IL_01
    IL_0055: nop
    IL_0056: nop
    IL_005B: castclass 0xBC000001
    IL_005C: IL_01
    IL_005D: nop
    IL_005E: nop
    IL_0063: br IL_0260
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000A46
    IL_006B: conv.r8
    IL_006C: ldc.i4.2
    IL_006D: nop
    IL_006E: nop
    IL_006F: stloc.0
    IL_0070: ldarg.1
    IL_0071: conv.r8
    IL_0072: ldarg.0
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: conv.r8
    IL_0077: ldc.i4.2
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007F: call 0x0A000019
    IL_0084: stfld 0x04000A47
    IL_0085: ldarg.0
    IL_008A: ldflda 0x04000A47
    IL_008B: ldc.i4.1
    IL_008C: IL_22
    IL_008D: nop
    IL_008E: nop
    IL_008F: nop
    IL_0090: nop
    IL_0095: call 0x0A00001A
    IL_0096: ldarg.0
    IL_0097: ldarg.0
    IL_009C: ldfld 0x04000A47
    IL_00A1: call 0x0A000040
    IL_00A6: stfld 0x04000A47
    IL_00A7: ldarg.1
    IL_00A8: conv.r8
    IL_00A9: ldarg.0
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: stloc.0
    IL_00AD: conv.r8
    IL_00AE: IL_44
    IL_00AF: nop
    IL_00B0: nop
    IL_00B1: stloc.0
    IL_00B2: conv.r8
    IL_00B3: IL_3D
    IL_00B4: nop
    IL_00B5: nop
    IL_00B6: stloc.0
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000A47
    IL_00BD: IL_22
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: IL_B4
    IL_00C1: IL_C2
    IL_00C6: call 0x0A000008
    IL_00C7: conv.r8
    IL_00C8: IL_3E
    IL_00C9: nop
    IL_00CA: nop
    IL_00CB: stloc.0
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000A43
    IL_00D7: ldfld 0x040002C6
    IL_00D8: conv.i2
    IL_00DD: stfld 0x04000A48
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x04000A44
    IL_00E4: conv.r8
    IL_00E5: IL_35
    IL_00E6: IL_01
    IL_00E7: nop
    IL_00E8: ldloc.0
    IL_00ED: br IL_0260
    IL_00EE: ldarg.0
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000A43
    IL_00F9: ldfld 0x040002C6
    IL_00FA: conv.i2
    IL_00FF: stfld 0x04000A48
    IL_0100: ldarg.0
    IL_0105: ldfld 0x04000A44
    IL_0106: IL_22
    IL_0107: nop
    IL_0108: nop
    IL_010D: stsfld 0x01366F3F
    IL_010E: nop
    IL_010F: ldloc.0
    IL_0114: br IL_0260
    IL_0115: ldarg.0
    IL_0116: ldarg.1
    IL_0117: conv.r8
    IL_0118: IL_3D
    IL_0119: nop
    IL_011A: nop
    IL_011B: stloc.0
    IL_011C: conv.r8
    IL_011F: ldarga 0
    IL_0120: stloc.0
    IL_0125: stfld 0x04000A48
    IL_0126: ldarg.0
    IL_012B: ldfld 0x04000A44
    IL_012C: conv.r8
    IL_012D: IL_35
    IL_012E: IL_01
    IL_012F: nop
    IL_0130: ldloc.0
    IL_0135: br IL_0260
    IL_0136: ldarg.0
    IL_0137: ldarg.1
    IL_0138: conv.r8
    IL_0139: IL_3D
    IL_013A: nop
    IL_013B: nop
    IL_013C: stloc.0
    IL_013D: conv.r8
    IL_0140: ldarga 0
    IL_0141: stloc.0
    IL_0142: IL_22
    IL_0143: nop
    IL_0144: nop
    IL_0145: nop
    IL_2921F6B2: switch (172522842 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A51
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000001
    IL_0016: call 0x0A000004
    IL_0017: conv.r8
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: stfld 0x04000A50
    IL_0021: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A51
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A50
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: ldloc.3
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x0A547D40
    IL_0009: nop
    IL_000A: ldarg.2
    IL_000B: ldarg.0
    IL_000C: IL_22
    IL_000D: nop
    IL_000E: nop
    IL_0013: stsfld 0x0A557D3F
    IL_0014: nop
    IL_0015: ldarg.2
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_3F
    IL_0020: stfld 0x04000A56
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: IL_CD
    IL_0024: IL_CC
    IL_0025: IL_CC
    IL_0026: IL_3D
    IL_002B: stfld 0x04000A5C
    IL_002C: ldarg.0
    IL_002D: ldc.i4.1
    IL_0032: stfld 0x04000A65
    IL_0033: ldarg.0
    IL_0038: call 0x0A000001
    IL_0039: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A52
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000A53
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000A52
    IL_001F: conv.r8
    IL_0024: cpobj 0x7D0A0000
    IL_0025: rem
    IL_0026: stloc.0
    IL_0027: nop
    IL_0028: ldarg.2
    IL_0029: ldarg.0
    IL_002E: ldstr 0x70000001
    IL_0033: call 0x0A000004
    IL_0034: conv.r8
    IL_0035: ldarg.3
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_003D: stfld 0x04000A61
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000A52
    IL_0048: call 0x0A000007
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: rem
    IL_004D: IL_42
    IL_0052: call 0x0A000008
    IL_0053: conv.r8
    IL_0054: ldloc.3
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000A52
    IL_0062: call 0x0A000013
    IL_0063: conv.r8
    IL_0068: call 0x020A0000
    IL_006D: ldfld 0x04000A53
    IL_006E: ldc.i4.0
    IL_006F: conv.r8
    IL_0071: ldc.i4.s 0
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ret
    }

    public void StopActive() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5E
    IL_000A: call 0x0A00004A
    IL_000F: brfalse IL_0020
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000A5E
    IL_001A: ldstr 0x70023131
    IL_001B: conv.r8
    IL_001C: IL_CD
    IL_001D: IL_01
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0025: call 0x0A000081
    IL_0026: ldarg.0
    IL_0027: ldc.i4.0
    IL_002C: stfld 0x04000A5F
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000A62
    IL_0034: ldarg.0
    IL_0035: ldc.i4.0
    IL_003A: stfld 0x04000A63
    IL_003B: ldarg.0
    IL_003C: ldc.i4.0
    IL_0041: stfld 0x04000A64
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000A53
    IL_0048: ldc.i4.0
    IL_0049: conv.r8
    IL_004B: ldc.i4.s 0
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000A52
    IL_0058: call 0x0A000007
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: IL_34
    IL_005D: IL_42
    IL_0062: call 0x0A000008
    IL_0063: conv.r8
    IL_0064: ldloc.3
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ret
    }

    public void SetDamage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5E
    IL_000A: call 0x0A00004A
    IL_000F: brfalse IL_0026
    IL_0010: ldarg.0
    IL_0015: ldstr 0x7002314B
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_151EC091D: switch (1417347648 cases)
    }

    private void LiveObjOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5E
    IL_000A: ldstr 0x70023175
    IL_000B: conv.r8
    IL_000C: IL_CD
    IL_000D: IL_01
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000C: ldc.i4.s 15
    IL_01B5: switch (105 cases)
    }

    public void DirectFire() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5F
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A52
    IL_0012: ldarg.1
    IL_0013: conv.r8
    IL_0014: ldloc.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_001D: call 0x060005C4
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000A57
    IL_0028: brfalse IL_004F
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000A52
    IL_002F: IL_22
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: nop
    IL_0034: ldc.i4.0
    IL_0039: ldc.i4 360
    IL_003E: call 0x0A000045
    IL_003F: conv.i2
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0043: nop
    IL_0044: nop
    IL_0049: call 0x0A000060
    IL_004A: conv.r8
    IL_004F: call 0x2A0A0000
    }

    private void Emit_trap() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5F
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A52
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A60
    IL_0018: conv.r8
    IL_0019: IL_AF
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000A5A
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_002C: beq IL_0034
    IL_002D: ldarg.0
    IL_002E: ldc.i4.1
    IL_0033: stfld 0x04000A62
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000A5B
    IL_003E: call 0x0A00001B
    IL_0043: call 0x0A00001C
    IL_0048: brfalse IL_0050
    IL_0049: ldarg.0
    IL_004A: ldc.i4.1
    IL_004F: stfld 0x04000A64
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000A53
    IL_0056: ldc.i4.1
    IL_0057: conv.r8
    IL_0059: ldc.i4.s 0
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ldarg.0
    IL_0061: ldstr 0x7002319B
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000A55
    IL_006C: call 0x0A00003F
    IL_006D: ret
    }

    private void Disappear_trap() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5F
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_000D: ldc.i4.0
    IL_0012: stfld 0x04000A62
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0019: stfld 0x04000A63
    IL_001A: ldarg.0
    IL_001B: ldc.i4.0
    IL_0020: stfld 0x04000A64
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000A5D
    IL_002B: brfalse IL_004D
    IL_002C: ldarg.0
    IL_0031: ldstr 0x7002315F
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000A54
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_1D4E5: switch (29992 cases)
    }

    private void Ready_trap() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A5F
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A61
    IL_0012: conv.r8
    IL_0013: ldc.i4.2
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_001B: call 0x0A00007E
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000A5C
    IL_0026: call 0x0A000008
    IL_002B: call 0x0A000029
    IL_002C: stloc.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000A58
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: nop
    IL_0037: nop
    IL_003C: beq IL_004F
    IL_003E: ldloca.s 0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000A58
    IL_0049: stfld 0x0A000023
    IL_004E: br IL_005B
    IL_0050: ldloca.s 0
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_005A: stfld 0x0A000023
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000A52
    IL_0061: ldloc.0
    IL_0062: conv.r8
    IL_0063: ldloc.3
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000A52
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000A59
    IL_0073: conv.r8
    IL_0074: IL_AF
    IL_0075: nop
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000A57
    IL_0082: brfalse IL_00A9
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000A52
    IL_0089: IL_22
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: nop
    IL_008E: ldc.i4.0
    IL_0093: ldc.i4 360
    IL_0098: call 0x0A000045
    IL_0099: conv.i2
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_009D: nop
    IL_009E: nop
    IL_00A3: call 0x0A000060
    IL_00A4: conv.r8
    IL_00A9: call 0x020A0000
    IL_00AE: ldstr 0x700231B9
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000A56
    IL_00B9: call 0x0A00003F
    IL_00BA: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A62
    IL_000A: brfalse IL_003D
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000A52
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000A52
    IL_0017: conv.r8
    IL_001C: cpobj 0x020A0000
    IL_0021: ldfld 0x04000A60
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000A5A
    IL_002C: call 0x0A000024
    IL_002D: IL_5A
    IL_0032: call 0x0A0000B2
    IL_0033: conv.r8
    IL_0034: IL_AF
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_003C: br IL_00AB
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000A63
    IL_0047: brfalse IL_00AB
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000A52
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000A52
    IL_0054: conv.r8
    IL_0059: cpobj 0x280A0000
    IL_005A: ldc.i4.5
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_0062: call 0x0A000024
    IL_0067: call 0x0A0000B2
    IL_0068: conv.r8
    IL_0069: IL_AF
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000A52
    IL_0073: conv.r8
    IL_0078: cpobj 0x0A0A0000
    IL_007A: ldloca.s 0
    IL_007F: ldfld 0x0A00005E
    IL_0080: IL_22
    IL_0081: stloc.0
    IL_0082: IL_D7
    IL_0083: IL_23
    IL_0084: IL_3C
    IL_0085: IL_41
    IL_008E: ldc.i8 2905438035116032
    IL_008F: ldarg.2
    IL_0094: call 0x0A000007
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: IL_34
    IL_0099: IL_42
    IL_009E: call 0x0A000008
    IL_009F: conv.r8
    IL_00A0: ldloc.3
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A4: ldarg.0
    IL_00A5: ldc.i4.0
    IL_00AA: stfld 0x04000A63
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x04000A64
    IL_00B5: brfalse IL_00F9
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x04000A52
    IL_00BC: conv.r8
    IL_00BD: ldc.i4.2
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: stloc.0
    IL_00C1: stloc.1
    IL_00C3: ldloca.s 1
    IL_00C8: ldfld 0x0A000023
    IL_00C9: IL_22
    IL_00CA: nop
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: IL_43
    IL_00CF: pop
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000A52
    IL_00D9: dup
    IL_00DA: conv.r8
    IL_00DB: ldc.i4.2
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: stloc.0
    IL_00DF: ldarg.0
    IL_00E4: ldfld 0x04000A5B
    IL_00E9: call 0x0A000024
    IL_00EE: call 0x0A000008
    IL_00F3: call 0x0A000029
    IL_00F4: conv.r8
    IL_00F5: ldloc.3
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: stloc.0
    IL_00F9: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700231CD
    IL_0006: ldarg.0
    IL_000B: ldflda 0x04000A68
    IL_0010: call 0x0A000010
    IL_0015: call 0x0A000011
    IL_001A: call 0x0A000012
    IL_001B: conv.u8
    IL_001C: IL_3C
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_01
    IL_0024: stfld 0x04000A66
    IL_0025: ldarg.0
    IL_002A: ldstr 0x70000BB3
    IL_002F: call 0x0A000095
    IL_0034: stfld 0x04000A69
    IL_0035: ret
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000A6A
    IL_0040: call 0x0A0000DF
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_E0
    IL_0045: IL_42
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: IL_C0
    IL_004A: IL_42
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_0052: stsfld 0x00002243
    IL_0053: nop
    IL_0054: IL_43
    IL_0059: call 0x0600021D
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000A67
    IL_0064: call 0x0A0000E0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000A68
    IL_006F: newobj 0x0100000B
    IL_0074: call 0x0A00013D
    IL_0075: IL_22
    IL_0076: nop
    IL_0077: nop
    IL_0078: IL_F8
    IL_0079: IL_42
    IL_007A: IL_22
    IL_007B: nop
    IL_007C: nop
    IL_007D: IL_CC
    IL_007E: IL_42
    IL_007F: IL_22
    IL_0080: nop
    IL_0081: nop
    IL_0082: neg
    IL_0083: IL_43
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_0088: starg.s 66
    IL_008D: call 0x0600021D
    IL_0092: ldsfld 0x0A000099
    IL_0097: ldsfld 0x040007B2
    IL_0098: ldarg.0
    IL_009D: ldfld 0x04000A69
    IL_00A2: ldc.i4 389
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04000A68
    IL_00A9: IL_58
    IL_00AE: call 0x0A0000E1
    IL_00B3: call 0x0A000011
    IL_00B8: ldstr 0x70000C43
    IL_00BD: call 0x0A0000E2
    IL_00C2: call 0x0A0000E3
    IL_00C3: IL_22
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: IL_F8
    IL_00C7: IL_42
    IL_00C8: IL_22
    IL_00C9: nop
    IL_00CA: nop
    IL_00CD: ldloc 8771
    IL_00CE: nop
    IL_00CF: nop
    IL_00D0: neg
    IL_00D1: IL_43
    IL_00D2: IL_22
    IL_00D3: nop
    IL_00D4: nop
    IL_00D5: rem
    IL_00D6: IL_41
    IL_00DB: call 0x0600021D
    IL_00E0: ldsfld 0x0A000099
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x04000A68
    IL_00E7: ldc.i4.1
    IL_00E8: IL_58
    IL_00ED: newobj 0x0100000B
    IL_00F2: ldstr 0x700231DB
    IL_00F7: call 0x0A000098
    IL_00FC: ldstr 0x70000C43
    IL_0101: call 0x0A0000E2
    IL_0106: call 0x0A0000E3
    IL_0107: IL_22
    IL_0108: nop
    IL_0109: nop
    IL_010A: ret
    IL_010B: IL_43
    IL_010C: IL_22
    IL_010D: nop
    IL_010E: nop
    IL_010F: ldloc.0
    IL_0110: IL_43
    IL_0111: IL_22
    IL_0112: nop
    IL_0113: nop
    IL_0114: nop
    IL_0115: IL_43
    IL_0116: IL_22
    IL_0117: nop
    IL_0118: nop
    IL_011D: stsfld 0x021D2842
    IL_011E: nop
    IL_011F: ldloc.0
    IL_0120: ldarg.0
    IL_0125: ldfld 0x04000A66
    IL_012A: call 0x0A0000E0
    IL_012B: ldarg.0
    IL_0130: ldfld 0x04000A68
    IL_0131: ldc.i4.1
    IL_0132: IL_3F
    IL_0137: ldsflda 0x7E000000
    IL_0138: IL_B2
    IL_0139: ldloc.1
    IL_013A: nop
    IL_013B: ldarg.2
    IL_013C: ldarg.0
    IL_0141: ldfld 0x04000A69
    IL_0142: ldc.i4.4
    IL_0147: call 0x0A0000E1
    IL_014C: call 0x0A00013D
    IL_014D: IL_22
    IL_014E: nop
    IL_014F: nop
    IL_0150: IL_91
    IL_0151: IL_43
    IL_0152: IL_22
    IL_0153: nop
    IL_0154: nop
    IL_0159: br IL_239D
    IL_015E: stsfld 0x00002242
    IL_015F: nop
    IL_0160: IL_42
    IL_0165: call 0x0600021D
    IL_016A: ldsfld 0x040007B2
    IL_016B: ldarg.0
    IL_0170: ldfld 0x04000A69
    IL_0171: ldc.i4.4
    IL_0176: call 0x0A0000E1
    IL_0177: ldarg.0
    IL_017C: ldfld 0x04000A6B
    IL_0181: call 0x0A0000F1
    IL_0186: brfalse IL_01B1
    IL_0187: IL_22
    IL_0188: nop
    IL_0189: nop
    IL_018E: stsfld 0x0111283F
    IL_018F: nop
    IL_0190: stloc.0
    IL_0191: ldarg.0
    IL_0196: call 0x0A00000A
    IL_0197: ldc.i4.0
    IL_0198: conv.r8
    IL_0199: stloc.1
    IL_019A: nop
    IL_019B: nop
    IL_019C: stloc.0
    IL_01A1: ldstr 0x70000231
    IL_01A6: call 0x0A000004
    IL_01A7: conv.r8
    IL_01A8: IL_C8
    IL_01A9: IL_01
    IL_01AA: nop
    IL_01AB: stloc.0
    IL_01AC: conv.r8
    IL_01AD: IL_4D
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: stloc.0
    IL_01B5: br IL_023B
    IL_01BA: ldsfld 0x040007B2
    IL_01BB: ldarg.0
    IL_01C0: ldfld 0x04000A69
    IL_01C2: ldc.i4.s 47
    IL_01C7: call 0x0A0000E1
    IL_01CC: call 0x0A00013D
    IL_01CD: IL_22
    IL_01CE: nop
    IL_01CF: nop
    IL_01D0: IL_91
    IL_01D1: IL_43
    IL_01D2: IL_22
    IL_01D3: nop
    IL_01D4: nop
    IL_01D9: br IL_241D
    IL_01DE: stsfld 0x00002242
    IL_01DF: nop
    IL_01E0: IL_42
    IL_01E5: call 0x0600021D
    IL_01EA: ldsfld 0x040007B2
    IL_01EB: ldarg.0
    IL_01F0: ldfld 0x04000A69
    IL_01F2: ldc.i4.s 47
    IL_01F7: call 0x0A0000E1
    IL_01F8: ldarg.0
    IL_01FD: ldfld 0x04000A6B
    IL_0202: call 0x0A0000F1
    IL_0207: brfalse IL_023B
    IL_0208: ldarg.0
    IL_0209: dup
    IL_020E: ldfld 0x04000A68
    IL_020F: ldc.i4.1
    IL_0210: IL_58
    IL_0215: stfld 0x04000A68
    IL_0216: ldarg.0
    IL_021B: ldstr 0x700231CD
    IL_021C: ldarg.0
    IL_0221: ldflda 0x04000A68
    IL_0226: call 0x0A000010
    IL_022B: call 0x0A000011
    IL_0230: call 0x0A000012
    IL_0231: conv.u8
    IL_0232: IL_3C
    IL_0233: nop
    IL_0234: nop
    IL_0235: IL_01
    IL_023A: stfld 0x04000A66
    IL_023B: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x00002240
    IL_000D: stsfld 0x0000223F
    IL_000E: nop
    IL_000F: nop
    IL_0014: newobj 0x0A000076
    IL_0019: stfld 0x04000A6F
    IL_001A: ldarg.0
    IL_001F: call 0x0A000001
    IL_0020: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A00000D
    IL_0007: conv.r8
    IL_0008: neg
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_0010: stfld 0x04000A6C
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: call 0x0A000002
    IL_001C: stfld 0x04000A6D
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000A6D
    IL_0024: conv.r8
    IL_0029: cpobj 0x7D0A0000
    IL_002A: conv.r4
    IL_002B: stloc.0
    IL_002C: nop
    IL_002D: ldarg.2
    IL_002E: ret
    }

    public void TxtEfOn() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_0006: ldc.i4.1
    IL_0007: conv.r8
    IL_0008: stloc.1
    IL_0009: nop
    IL_000A: nop
    IL_000B: stloc.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000A6D
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A6E
    IL_0018: conv.r8
    IL_0019: IL_AF
    IL_001A: nop
    IL_001B: nop
    IL_001C: stloc.0
    IL_001D: ldarg.0
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0027: stfld 0x04000A70
    IL_0028: ldarg.1
    IL_0029: ldc.i4.2
    IL_008A: switch (23 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000A70
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04000A70
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000A70
    IL_0018: IL_22
    IL_001A: bne.un.s IL_004E
    IL_001C: bne.un.s IL_005C
    IL_001D: IL_43
    IL_001F: ldloc.s 0
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_0032: br IL_0097
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000A71
    IL_003D: brfalse IL_006B
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000A70
    IL_0044: IL_22
    IL_0045: IL_CD
    IL_0046: IL_CC
    IL_0047: IL_4C
    IL_0048: IL_3E
    IL_0049: IL_43
    IL_004A: ldc.i4.2
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000A6D
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000A6E
    IL_005A: conv.r8
    IL_005B: IL_AF
    IL_005C: nop
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: ldarg.0
    IL_0060: ldc.i4.0
    IL_0065: stfld 0x04000A71
    IL_006A: br IL_0097
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04000A6D
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000A6D
    IL_0077: conv.r8
    IL_007C: cpobj 0x020A0000
    IL_0081: ldfld 0x04000A6F
    IL_0086: call 0x0A000024
    IL_0087: IL_22
    IL_0088: nop
    IL_0089: nop
    IL_008E: cpobj 0x63285A41
    IL_008F: nop
    IL_0090: nop
    IL_0091: stloc.0
    IL_0092: conv.r8
    IL_0093: IL_AF
    IL_0094: nop
    IL_0095: nop
    IL_0096: stloc.0
    IL_0097: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A75
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000016
    IL_0013: conv.r8
    IL_0014: IL_A9
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000A72
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000A75
    IL_0024: conv.r8
    IL_0025: ldc.i4.2
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: stfld 0x04000A74
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000A75
    IL_0035: conv.r8
    IL_003A: cpobj 0x7D0A0000
    IL_003B: conv.r.un
    IL_003C: stloc.0
    IL_003D: nop
    IL_003E: ldarg.2
    IL_003F: ret
    }

    private void Start() {
    IL_0000: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000A73
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000A75
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000A74
    IL_0017: conv.r8
    IL_0018: ldloc.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000A75
    IL_0026: call 0x0A00004B
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_20A12E: switch (534592 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A75
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000A75
    IL_000C: conv.r8
    IL_0011: cpobj 0x020A0000
    IL_0016: ldfld 0x04000A76
    IL_001B: call 0x0A000024
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_18CA16927: switch (1663588929 cases)
    }

    public void UvMove() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A72
    IL_0006: ldc.i4.4
    IL_000B: newarr 0x01000014
    IL_000C: dup
    IL_000D: ldc.i4.0
    IL_000E: IL_8F
    IL_000F: ldnull
    IL_0010: nop
    IL_0011: nop
    IL_0012: IL_01
    IL_0013: ldarg.1
    IL_0018: call 0x0A0000AA
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_0020: stsfld 0x0083283E
    IL_0021: nop
    IL_0022: stloc.0
    IL_0027: call 0x0A0000AB
    IL_0028: IL_81
    IL_0029: ldnull
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_01
    IL_002D: dup
    IL_002E: ldc.i4.1
    IL_002F: IL_8F
    IL_0030: ldnull
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_01
    IL_0034: ldarg.1
    IL_0039: call 0x0A000082
    IL_003E: call 0x0A0000AB
    IL_0043: call 0x0A0000AA
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_004B: stsfld 0x0083283E
    IL_004C: nop
    IL_004D: stloc.0
    IL_0052: call 0x0A0000AB
    IL_0053: IL_81
    IL_0054: ldnull
    IL_0055: nop
    IL_0056: nop
    IL_0057: IL_01
    IL_0058: dup
    IL_0059: ldc.i4.2
    IL_005A: IL_8F
    IL_005B: ldnull
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_01
    IL_005F: ldarg.1
    IL_0060: IL_81
    IL_0061: ldnull
    IL_0062: nop
    IL_0063: nop
    IL_0064: IL_01
    IL_0065: dup
    IL_0066: ldc.i4.3
    IL_0067: IL_8F
    IL_0068: ldnull
    IL_0069: nop
    IL_006A: nop
    IL_006B: IL_01
    IL_006C: ldarg.1
    IL_0071: call 0x0A000082
    IL_0076: call 0x0A0000AB
    IL_0077: IL_81
    IL_0078: ldnull
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_01
    IL_007C: conv.r8
    IL_007D: IL_AC
    IL_007E: nop
    IL_007F: nop
    IL_0080: stloc.0
    IL_0081: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000A7A
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000016
    IL_0013: conv.r8
    IL_0014: IL_A9
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000A77
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000A7A
    IL_0024: conv.r8
    IL_0025: ldc.i4.2
    IL_0026: nop
    IL_0027: nop
    IL_0028: stloc.0
    IL_002D: stfld 0x04000A79
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000A7A
    IL_0035: conv.r8
    IL_003A: cpobj 0x7D0A0000
    IL_003F: ldfld 0x2A04000A
    }

    private void Start() {
    IL_0000: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A7C
    IL_000A: brfalse IL_0096
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000A7A
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000A7A
    IL_0017: conv.r8
    IL_001C: cpobj 0x020A0000
    IL_0021: ldfld 0x04000A7B
    IL_0026: call 0x0A000024
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_41
    IL_002C: IL_5A
    IL_0031: call 0x0A000063
    IL_0032: conv.r8
    IL_0033: IL_AF
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000A78
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0040: nop
    IL_5D49: switch (5953 cases)
    }

    public void SetStar() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000A77
    IL_0006: ldc.i4.4
    IL_000B: newarr 0x01000014
    IL_000C: dup
    IL_000D: ldc.i4.0
    IL_000E: IL_8F
    IL_000F: ldnull
    IL_0010: nop
    IL_0011: nop
    IL_0012: IL_01
    IL_0017: call 0x0A0000AA
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001F: stsfld 0x0083283E
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: IL_81
    IL_0023: ldnull
    IL_0024: nop
    IL_0025: nop
    IL_0026: IL_01
    IL_0027: dup
    IL_0028: ldc.i4.1
    IL_0029: IL_8F
    IL_002A: ldnull
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_01
    IL_002E: IL_22
    IL_002F: IL_4C
    IL_0034: isinst 0x6B033EAA
    IL_0035: IL_5A
    IL_0036: IL_22
    IL_0037: nop
    IL_0038: nop
    IL_003D: stsfld 0x0038733E
    IL_003E: nop
    IL_003F: stloc.0
    IL_0040: IL_81
    IL_0041: ldnull
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_01
    IL_0045: dup
    IL_0046: ldc.i4.2
    IL_0047: IL_8F
    IL_0048: ldnull
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_01
    IL_0050: call 0x0A000057
    IL_0051: IL_81
    IL_0052: ldnull
    IL_0053: nop
    IL_0054: nop
    IL_0055: IL_01
    IL_0056: dup
    IL_0057: ldc.i4.3
    IL_0058: IL_8F
    IL_0059: ldnull
    IL_005A: nop
    IL_005B: nop
    IL_005C: IL_01
    IL_0061: call 0x0A000082
    IL_0062: IL_22
    IL_0063: IL_4C
    IL_0068: isinst 0x83283EAA
    IL_0069: nop
    IL_006A: nop
    IL_006B: stloc.0
    IL_006C: ldarg.1
    IL_006D: conv.i2
    IL_0072: call 0x0A000083
    IL_0073: IL_81
    IL_0074: ldnull
    IL_0075: nop
    IL_0076: nop
    IL_0077: IL_01
    IL_0078: conv.r8
    IL_0079: IL_AC
    IL_007A: nop
    IL_007B: nop
    IL_007C: stloc.0
    IL_007D: ldarg.0
    IL_007E: IL_22
    IL_007F: IL_4C
    IL_0084: isinst 0x6B033EAA
    IL_0085: IL_5A
    IL_0086: IL_22
    IL_0087: nop
    IL_0088: nop
    IL_008D: stsfld 0x0000223F
    IL_0092: stsfld 0x0076733F
    IL_0093: nop
    IL_0094: stloc.0
    IL_0099: stfld 0x04000A7B
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000A7A
    IL_00A0: ldc.i4.2
    IL_00A1: ldarg.1
    IL_00A2: IL_5A
    IL_00A3: conv.i2
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: IL_C0
    IL_300000134: switch (3221225506 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0004: ldstr 0x70022F5F
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_0010: brtrue IL_00A4
    IL_0015: ldstr 0x700231E5
    IL_001A: call 0x0A000077
    IL_001B: ldnull
    IL_0020: call 0x0A000061
    IL_0025: brfalse IL_005C
    IL_002A: ldstr 0x700231E5
    IL_002F: call 0x0A000012
    IL_0030: conv.u8
    IL_0031: ldloc.0
    IL_0032: nop
    IL_0033: nop
    IL_0034: IL_01
    IL_0035: stloc.1
    IL_0036: ldloc.1
    IL_0037: conv.r8
    IL_0038: ldarg.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_0040: call 0x0A00001B
    IL_0045: call 0x0A000013
    IL_004A: call 0x0A000014
    IL_004B: conv.u4
    IL_004C: ldarg.1
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_01
    IL_0050: stloc.2
    IL_0051: ldloc.2
    IL_0056: ldstr 0x700231E5
    IL_0057: conv.r8
    IL_0058: IL_DC
    IL_0059: IL_01
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ldarg.0
    IL_0061: call 0x0A0000D0
    IL_0062: IL_22
    IL_0063: shr
    IL_0064: shr
    IL_0065: IL_E6
    IL_0066: IL_BF
    IL_0067: IL_22
    IL_0068: shr
    IL_0069: shr
    IL_006A: IL_E6
    IL_006B: IL_3F
    IL_006C: IL_22
    IL_006D: ldelem.i
    IL_006E: IL_99
    IL_006F: IL_99
    IL_0070: IL_BF
    IL_0071: IL_22
    IL_0072: ldelem.i
    IL_0073: IL_99
    IL_0074: IL_99
    IL_0075: IL_3F
    IL_0076: IL_22
    IL_0077: ldelem.i
    IL_0078: IL_99
    IL_0079: IL_99
    IL_007A: IL_3E
    IL_007B: IL_22
    IL_007C: nop
    IL_007D: nop
    IL_007E: ldelem.r8
    IL_34523: switch (53544 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 50
    IL_0007: stfld 0x04000A7F
    IL_0008: ldarg.0
    IL_0009: ldc.i4.3
    IL_000E: newarr 0x01000003
    IL_0013: stfld 0x04000A84
    IL_0014: ldarg.0
    IL_0016: ldc.i4.s 100
    IL_001B: newarr 0x0100000B
    IL_0020: stfld 0x04000A85
    IL_0021: ldarg.0
    IL_0022: ldc.i4.5
    IL_0027: newarr 0x0100003C
    IL_002C: stfld 0x04000A9C
    IL_002D: ldarg.0
    IL_002E: ldc.i4.6
    IL_0033: newarr 0x0100003C
    IL_0038: stfld 0x04000A9D
    IL_0039: ldarg.0
    IL_003A: ldc.i4.3
    IL_003F: newarr 0x0100003C
    IL_0044: stfld 0x04000AA0
    IL_0045: ldarg.0
    IL_0046: ldc.i4.3
    IL_004B: newarr 0x0100003C
    IL_0050: stfld 0x04000AA2
    IL_0051: ldarg.0
    IL_0052: ldc.i4.3
    IL_0057: newarr 0x0100003C
    IL_005C: stfld 0x04000AB8
    IL_005D: ldarg.0
    IL_005E: ldc.i4.5
    IL_0063: newarr 0x0100003C
    IL_0068: stfld 0x04000ABB
    IL_0069: ldarg.0
    IL_006A: ldc.i4.5
    IL_006F: newarr 0x0100000B
    IL_0070: dup
    IL_0075: ldtoken 0x040010BF
    IL_007A: call 0x0A00018C
    IL_007F: stfld 0x04000ABC
    IL_0080: ldarg.0
    IL_0081: ldc.i4.6
    IL_0086: newarr 0x0100000B
    IL_0087: dup
    IL_008C: ldtoken 0x040010C0
    IL_0091: call 0x0A00018C
    IL_0096: stfld 0x04000ABD
    IL_0097: ldarg.0
    IL_0098: ldc.i4.5
    IL_009D: newarr 0x0100000B
    IL_00A2: stfld 0x04000ABE
    IL_00A3: ldarg.0
    IL_00A4: ldc.i4.3
    IL_00A9: newarr 0x0100000B
    IL_00AE: stfld 0x04000ABF
    IL_00AF: ldarg.0
    IL_00B4: ldsfld 0x0A000099
    IL_00B9: stfld 0x04000AD1
    IL_00BA: ldarg.0
    IL_00BB: ldc.i4.1
    IL_00C0: stfld 0x04000AD7
    IL_00C1: ldarg.0
    IL_00C6: call 0x0A000057
    IL_00CB: stfld 0x04000AE6
    IL_00CC: ldarg.0
    IL_00D1: call 0x0A000057
    IL_00D6: stfld 0x04000AE7
    IL_00D7: ldarg.0
    IL_00D8: IL_22
    IL_00D9: nop
    IL_00DA: nop
    IL_00DB: IL_A8
    IL_00DC: IL_42
    IL_00DD: IL_22
    IL_00DE: nop
    IL_00DF: nop
    IL_00E0: IL_EC
    IL_00E1: IL_42
    IL_00E2: IL_22
    IL_00E3: nop
    IL_00E4: nop
    IL_00E5: ldelem.r8
    IL_00E6: IL_43
    IL_00E7: IL_22
    IL_00E8: nop
    IL_00E9: nop
    IL_00EA: IL_34
    IL_00EB: IL_43
    IL_00F0: newobj 0x0A000147
    IL_00F5: stfld 0x04000AE8
    IL_00F6: ldarg.0
    IL_00F7: ldc.i4.1
    IL_00FC: stfld 0x04000AF0
    IL_00FD: ldarg.0
    IL_00FE: ldc.i4.m1
    IL_0103: stfld 0x04000AF8
    IL_0104: ldarg.0
    IL_0105: ldc.i4.1
    IL_010A: stfld 0x04000AFA
    IL_010B: ldarg.0
    IL_010C: ldc.i4.m1
    IL_0111: stfld 0x04000AFF
    IL_0112: ldarg.0
    IL_0113: ldc.i4.m1
    IL_0118: stfld 0x04000B00
    IL_0119: ldarg.0
    IL_011A: ldc.i4.2
    IL_011F: newarr 0x0100000B
    IL_0124: stfld 0x04000B03
    IL_0125: ldarg.0
    IL_0126: ldc.i4.m1
    IL_012B: stfld 0x04000B07
    IL_012C: ldarg.0
    IL_012D: IL_22
    IL_012E: nop
    IL_0133: stsfld 0x087D44BB
    IL_0134: stloc.1
    IL_0135: nop
    IL_0136: ldarg.2
    IL_0137: ldarg.0
    IL_0138: ldc.i4.1
    IL_013D: stfld 0x04000B10
    IL_013E: ldarg.0
    IL_0143: newobj 0x0A0002E2
    IL_0148: stfld 0x04000B15
    IL_0149: ldarg.0
    IL_014A: ldc.i4.1
    IL_014F: stfld 0x04000B19
    IL_0150: ldarg.0
    IL_0151: ldc.i4.1
    IL_0156: stfld 0x04000B1A
    IL_0157: ldarg.0
    IL_0158: ldc.i4.1
    IL_015D: stfld 0x04000B1B
    IL_015E: ldarg.0
    IL_0163: call 0x0A000001
    IL_0164: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000AE9
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70001F2D
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000B07
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000B07
    IL_0026: ldc.i4.0
    IL_0027: IL_3F
    IL_0029: blt.s IL_002A
    IL_002A: nop
    IL_002B: nop
    IL_0030: ldstr 0x70001F15
    IL_0035: call 0x060003F9
    IL_0036: stloc.0
    IL_0037: ldarg.0
    IL_0038: ldloc.0
    IL_0039: ldarg.0
    IL_003E: ldfld 0x04000B07
    IL_003F: IL_94
    IL_0044: stfld 0x04000B09
    IL_0049: ldstr 0x70001F1D
    IL_004E: call 0x060003F9
    IL_004F: stloc.1
    IL_0050: ldarg.0
    IL_0051: ldloc.1
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000B07
    IL_0058: IL_94
    IL_005D: stfld 0x04000B0A
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: call 0x2B000067
    IL_0069: stfld 0x04000B16
    IL_006A: ldarg.0
    IL_006F: ldstr 0x7002323F
    IL_0074: call 0x060003F9
    IL_0079: stfld 0x04000A85
    IL_007A: ldarg.0
    IL_007F: ldstr 0x70023247
    IL_0084: call 0x06000220
    IL_0089: stfld 0x04000AF0
    IL_008A: ldarg.0
    IL_008B: ldarg.0
    IL_0090: ldfld 0x04000AF0
    IL_0091: ldc.i4.1
    IL_0093: ldc.i4.s 64
    IL_0098: call 0x0A0002AA
    IL_009D: stfld 0x04000AF0
    IL_009E: ldarg.0
    IL_00A3: ldstr 0x70022DD9
    IL_00A8: call 0x06000220
    IL_00AD: stfld 0x04000AF1
    IL_00AE: ldarg.0
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000AF1
    IL_00B5: ldc.i4.1
    IL_00BA: call 0x0A000080
    IL_00BF: stfld 0x04000AF1
    IL_00C0: ldarg.0
    IL_00C5: ldstr 0x7002324F
    IL_00CA: call 0x06000220
    IL_00CF: stfld 0x04000B06
    IL_00D0: ldarg.0
    IL_00D5: ldstr 0x70001F9B
    IL_00DA: call 0x060003F9
    IL_00DF: stfld 0x04000ABE
    IL_00E0: ldarg.0
    IL_00E1: IL_22
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: IL_A8
    IL_00E5: IL_42
    IL_00EA: stfld 0x04000AEA
    IL_00EB: ldarg.0
    IL_00EC: IL_22
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: IL_F0
    IL_00F0: IL_43
    IL_00F5: stfld 0x04000AEB
    IL_00F6: ldarg.0
    IL_00F7: IL_22
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: IL_C8
    IL_00FB: IL_C2
    IL_0100: stfld 0x04000AEC
    IL_0101: ldarg.0
    IL_0106: ldstr 0x70000557
    IL_0107: ldc.i4.0
    IL_010C: call 0x0A0002BB
    IL_0111: stfld 0x04000B14
    IL_0112: ldarg.0
    IL_0117: call 0x0A000035
    IL_0118: conv.r8
    IL_011D: ldflda 0x7D2B0000
    IL_011E: IL_FC
    IL_011F: stloc.0
    IL_0120: nop
    IL_0121: ldarg.2
    IL_0122: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000AED
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000AEE
    IL_0020: ldarg.0
    IL_0025: ldstr 0x7000066F
    IL_002A: call 0x06000220
    IL_002F: stfld 0x04000AFD
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000AFC
    IL_0036: conv.r8
    IL_0037: ldc.i4.8
    IL_0038: IL_01
    IL_0039: nop
    IL_003A: ldloc.0
    IL_003B: ret
    }

    private void Start() {
    IL_0004: ldstr 0x70023257
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000F: ldstr 0x7002325F
    IL_0014: call 0x06000220
    IL_0015: stloc.1
    IL_0016: ldloc.0
    IL_001B: brfalse IL_0034
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_0022: call 0x0600021E
    IL_0023: pop
    IL_0028: ldstr 0x70023257
    IL_0029: ldc.i4.0
    IL_002E: call 0x0600021F
    IL_0033: br IL_004D
    IL_0034: ldloc.1
    IL_0039: brfalse IL_004D
    IL_003A: ldloc.1
    IL_003B: ldc.i4.0
    IL_0040: call 0x0600021E
    IL_0041: pop
    IL_0046: ldstr 0x7002325F
    IL_0047: ldc.i4.0
    IL_004C: call 0x0600021F
    IL_004D: ldarg.0
    IL_0052: ldstr 0x70022DCB
    IL_0057: call 0x0A000004
    IL_0058: conv.r8
    IL_005D: stfld 0x7D2B0000
    IL_005E: IL_DE
    IL_005F: stloc.0
    IL_0060: nop
    IL_0061: ldarg.2
    IL_0062: ldarg.0
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000ADE
    IL_0069: conv.r8
    IL_006A: IL_91
    IL_006B: ldarg.1
    IL_006C: nop
    IL_006D: ldloc.0
    IL_0072: stfld 0x04000ADA
    IL_0073: ldarg.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x04000ADE
    IL_007A: conv.r8
    IL_007B: IL_92
    IL_007C: ldarg.1
    IL_007D: nop
    IL_007E: ldloc.0
    IL_0083: stfld 0x04000ADB
    IL_0088: ldstr 0x700231FD
    IL_008D: call 0x0A000077
    IL_008E: stloc.2
    IL_0093: call 0x0A00001B
    IL_0094: stloc.3
    IL_0095: ldc.i4.0
    IL_0097: stloc.s 4
    IL_0098: ldloc.2
    IL_0099: ldnull
    IL_009E: call 0x0A000061
    IL_00A3: brfalse IL_0213
    IL_00A8: ldstr 0x700231FD
    IL_00AD: call 0x0A000012
    IL_00AE: conv.u8
    IL_00AF: ldloc.0
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: IL_01
    IL_00B4: stloc.s 5
    IL_00B9: ldstr 0x7002320B
    IL_00BE: call 0x0A000012
    IL_00BF: conv.u8
    IL_00C0: ldloc.0
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: IL_01
    IL_00C5: stloc.s 6
    IL_00CA: ldstr 0x70023225
    IL_00CF: call 0x0A000012
    IL_00D0: conv.u8
    IL_00D1: ldloc.0
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: IL_01
    IL_00D6: stloc.s 7
    IL_00D7: ldarg.0
    IL_00D9: ldloc.s 5
    IL_00DA: conv.r8
    IL_00DB: ldarg.3
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: stloc.0
    IL_00DF: IL_22
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: IL_22
    IL_00E5: ldelem.i
    IL_00E6: IL_99
    IL_00E7: ldc.i4.3
    IL_00E8: IL_BE
    IL_00E9: IL_22
    IL_00EA: nop
    IL_00EB: nop
    IL_00F0: stsfld 0x007673BF
    IL_00F1: nop
    IL_00F2: stloc.0
    IL_00F7: call 0x0A000013
    IL_00FC: call 0x0A000014
    IL_00FD: conv.u4
    IL_00FE: ldarg.1
    IL_00FF: nop
    IL_0100: nop
    IL_0101: IL_01
    IL_0106: stfld 0x04000A81
    IL_0107: ldarg.0
    IL_0109: ldloc.s 6
    IL_010A: conv.r8
    IL_010B: ldarg.3
    IL_010C: nop
    IL_010D: nop
    IL_010E: stloc.0
    IL_010F: IL_22
    IL_0110: nop
    IL_0111: nop
    IL_0112: nop
    IL_0113: nop
    IL_0114: IL_22
    IL_0115: ldelem.i
    IL_0116: IL_99
    IL_0117: ldc.i4.3
    IL_0118: IL_BE
    IL_0119: IL_22
    IL_011A: nop
    IL_011B: nop
    IL_011C: nop
    IL_011D: IL_BF
    IL_0122: newobj 0x0A000076
    IL_0127: call 0x0A000013
    IL_012C: call 0x0A000014
    IL_012D: conv.u4
    IL_012E: ldarg.1
    IL_012F: nop
    IL_0130: nop
    IL_0131: IL_01
    IL_0136: stfld 0x04000A82
    IL_0137: ldarg.0
    IL_0139: ldloc.s 7
    IL_013A: conv.r8
    IL_013B: ldarg.3
    IL_013C: nop
    IL_013D: nop
    IL_013E: stloc.0
    IL_013F: IL_22
    IL_0140: nop
    IL_0141: nop
    IL_0142: nop
    IL_0143: nop
    IL_0144: IL_22
    IL_0145: ldelem.i
    IL_0146: IL_99
    IL_0147: ldc.i4.3
    IL_0148: IL_BE
    IL_0149: IL_22
    IL_014A: nop
    IL_014B: nop
    IL_0150: stsfld 0x007673BF
    IL_0151: nop
    IL_0152: stloc.0
    IL_0157: call 0x0A000013
    IL_015C: call 0x0A000014
    IL_015D: conv.u4
    IL_015E: ldarg.1
    IL_015F: nop
    IL_0160: nop
    IL_0161: IL_01
    IL_0166: stfld 0x04000A83
    IL_0167: ldarg.0
    IL_016C: ldfld 0x04000A81
    IL_0171: ldstr 0x700231FD
    IL_0172: conv.r8
    IL_0173: IL_DC
    IL_0174: IL_01
    IL_0175: nop
    IL_0176: stloc.0
    IL_0177: ldarg.0
    IL_017C: ldfld 0x04000A82
    IL_0181: ldstr 0x7002320B
    IL_0182: conv.r8
    IL_0183: IL_DC
    IL_0184: IL_01
    IL_0185: nop
    IL_0186: stloc.0
    IL_0187: ldarg.0
    IL_018C: ldfld 0x04000A83
    IL_0191: ldstr 0x70023225
    IL_0192: conv.r8
    IL_0193: IL_DC
    IL_0194: IL_01
    IL_0195: nop
    IL_0196: stloc.0
    IL_0197: ldarg.0
    IL_019C: ldfld 0x04000AF0
    IL_019E: ldc.i4.s 64
    IL_019F: IL_3C
    IL_01A0: IL_35
    IL_01A1: nop
    IL_01A2: nop
    IL_01A3: nop
    IL_01A5: ldloca.s 3
    IL_01A6: ldarg.0
    IL_01AB: ldfld 0x04000A86
    IL_01AC: ldarg.0
    IL_01B1: ldfld 0x04000AF0
    IL_01B2: conv.r8
    IL_01B7: brtrue IL_6F0A01B8
    IL_01B8: ldc.i4.2
    IL_01B9: nop
    IL_01BA: nop
    IL_01BB: stloc.0
    IL_01BD: stloc.s 16
    IL_01BF: ldloca.s 16
    IL_01C4: ldfld 0x0A00005E
    IL_01C5: IL_22
    IL_01C6: nop
    IL_01C7: nop
    IL_01C8: nop
    IL_01C9: nop
    IL_01CA: IL_22
    IL_01CB: nop
    IL_01CC: nop
    IL_01D1: stsfld 0x0076283F
    IL_01D2: nop
    IL_01D3: stloc.0
    IL_01D8: br IL_020B
    IL_01DA: ldloca.s 3
    IL_01DB: ldarg.0
    IL_01E0: ldfld 0x04000A86
    IL_01E1: ldarg.0
    IL_01E6: ldfld 0x04000AF0
    IL_01E7: ldc.i4.1
    IL_01E8: IL_59
    IL_01E9: conv.r8
    IL_01EE: brtrue IL_6F0A01EF
    IL_01EF: ldc.i4.2
    IL_01F0: nop
    IL_01F1: nop
    IL_01F2: stloc.0
    IL_01F4: stloc.s 17
    IL_01F6: ldloca.s 17
    IL_01FB: ldfld 0x0A00005E
    IL_01FC: IL_22
    IL_01FD: nop
    IL_01FE: nop
    IL_01FF: nop
    IL_0200: nop
    IL_0201: IL_22
    IL_0202: nop
    IL_0203: nop
    IL_0208: stsfld 0x0076283F
    IL_0209: nop
    IL_020A: stloc.0
    IL_020B: ldc.i4.1
    IL_020D: stloc.s 4
    IL_0212: br IL_0257
    IL_0217: ldstr 0x70000C8F
    IL_021C: call 0x060003F4
    IL_021D: stloc.3
    IL_021E: ldarg.0
    IL_021F: ldloc.2
    IL_0220: conv.r8
    IL_0221: ldarg.3
    IL_0222: nop
    IL_0223: nop
    IL_0224: stloc.0
    IL_0229: stfld 0x04000A81
    IL_022A: ldarg.0
    IL_022F: ldstr 0x7002320B
    IL_0234: call 0x0A000077
    IL_0235: conv.r8
    IL_0236: ldarg.3
    IL_0237: nop
    IL_0238: nop
    IL_0239: stloc.0
    IL_023E: stfld 0x04000A82
    IL_023F: ldarg.0
    IL_0244: ldstr 0x70023225
    IL_0249: call 0x0A000077
    IL_024A: conv.r8
    IL_024B: ldarg.3
    IL_024C: nop
    IL_024D: nop
    IL_024E: stloc.0
    IL_0253: stfld 0x04000A83
    IL_0254: ldc.i4.0
    IL_0256: stloc.s 4
    IL_0257: ldarg.0
    IL_025C: ldfld 0x04000AFC
    IL_025D: ldarg.0
    IL_0262: ldfld 0x04000A82
    IL_0263: ldarg.0
    IL_0268: ldfld 0x04000A83
    IL_026A: ldloca.s 3
    IL_026F: ldfld 0x0A00005E
    IL_0271: ldloc.s 4
    IL_0272: IL_22
    IL_0274: bne.un.s IL_02A8
    IL_0275: conv.ovf.i4.un
    IL_0276: IL_3F
    IL_0277: ldarg.0
    IL_027C: ldfld 0x04000AF0
    IL_027D: conv.i2
    IL_027E: IL_22
    IL_027F: IL_CD
    IL_0280: IL_CC
    IL_0281: IL_4C
    IL_0282: IL_3D
    IL_0283: IL_5A
    IL_0284: IL_58
    IL_0285: conv.r8
    IL_0286: ldc.i4.6
    IL_0287: IL_01
    IL_0288: nop
    IL_0289: ldloc.0
    IL_028A: ldarg.0
    IL_028F: ldstr 0x70022A18
    IL_0294: call 0x0A000004
    IL_0299: stfld 0x04000AF7
    IL_029A: ldarg.0
    IL_029F: ldfld 0x04000AF7
    IL_02A0: ldnull
    IL_02A5: call 0x0A000061
    IL_02AA: brfalse IL_02D8
    IL_02AF: ldstr 0x70023267
    IL_02B4: call 0x0A000012
    IL_02B5: conv.u8
    IL_02B6: ldloc.0
    IL_02B7: nop
    IL_02B8: nop
    IL_02B9: IL_01
    IL_02BB: stloc.s 8
    IL_02BC: ldarg.0
    IL_02BE: ldloc.s 8
    IL_02C3: call 0x0A00001B
    IL_02C8: call 0x0A000013
    IL_02CD: call 0x0A000014
    IL_02CE: conv.u4
    IL_02CF: ldloc.0
    IL_02D0: nop
    IL_02D1: nop
    IL_02D2: IL_01
    IL_02D7: stfld 0x04000AF7
    IL_02DC: ldstr 0x70000121
    IL_02E1: call 0x0A000004
    IL_02E2: ldnull
    IL_02E7: call 0x0A000061
    IL_02EC: brfalse IL_0312
    IL_02ED: ldarg.0
    IL_02EE: ldarg.0
    IL_02F3: ldfld 0x04000A80
    IL_02F8: call 0x0A00001B
    IL_02FD: call 0x0A000013
    IL_0302: call 0x0A000014
    IL_0303: conv.u4
    IL_0304: ldarg.1
    IL_0305: nop
    IL_0306: nop
    IL_0307: IL_01
    IL_030C: stfld 0x04000AF4
    IL_0311: br IL_0327
    IL_0312: ldarg.0
    IL_0317: ldstr 0x70000121
    IL_031C: call 0x0A000004
    IL_031D: conv.r8
    IL_031E: ldarg.3
    IL_031F: nop
    IL_0320: nop
    IL_0321: stloc.0
    IL_0326: stfld 0x04000AF4
    IL_0327: ldarg.0
    IL_0328: ldarg.0
    IL_032D: ldfld 0x04000AF4
    IL_032E: conv.r8
    IL_0333: ldsfld 0x7D2B0000
    IL_0334: IL_FB
    IL_0335: stloc.0
    IL_0336: nop
    IL_0337: ldarg.2
    IL_0338: ldarg.0
    IL_033D: ldstr 0x70022774
    IL_0342: call 0x0A0001C1
    IL_0347: stfld 0x04000ADD
    IL_0348: ldarg.0
    IL_034D: ldstr 0x7002270C
    IL_0352: call 0x0A0001C1
    IL_0357: stfld 0x04000ADC
    IL_0358: ldarg.0
    IL_035D: ldfld 0x04000ADC
    IL_0362: call 0x0A0001C2
    IL_0367: call 0x0600056A
    IL_0368: ldarg.0
    IL_036D: ldstr 0x70000DDD
    IL_0372: call 0x06000220
    IL_0377: stfld 0x04000AEF
    IL_037C: ldstr 0x70000DE5
    IL_0381: call 0x06000220
    IL_0383: stloc.s 9
    IL_0384: ldarg.0
    IL_0386: ldloc.s 9
    IL_0387: conv.i2
    IL_0388: ldarg.0
    IL_038D: ldfld 0x04000AEF
    IL_038F: ldc.i4.s 100
    IL_0390: IL_5A
    IL_0391: conv.i2
    IL_0392: add
    IL_0393: IL_22
    IL_0394: nop
    IL_0395: nop
    IL_0398: ldloc 23106
    IL_039D: stfld 0x04000AF3
    IL_039E: ldc.i4.0
    IL_03A0: stloc.s 10
    IL_03A5: br IL_04B8
    IL_03A7: ldloc.s 10
    IL_03A9: ldc.i4.s 64
    IL_03AA: IL_3F
    IL_03AB: ldarg.3
    IL_03AC: nop
    IL_03AD: nop
    IL_03AE: nop
    IL_03B3: br IL_04C5
    IL_03B4: ldarg.0
    IL_03B9: ldfld 0x04000A86
    IL_03BB: ldloc.s 10
    IL_03BC: conv.r8
    IL_03C1: brtrue IL_6F0A03C2
    IL_03C2: ldc.i4.2
    IL_03C3: nop
    IL_03C4: nop
    IL_03C5: stloc.0
    IL_03C7: stloc.s 11
    IL_03C8: ldarg.0
    IL_03CD: ldfld 0x04000A88
    IL_03CF: ldloc.s 11
    IL_03D0: ldarg.0
    IL_03D5: ldfld 0x04000A88
    IL_03D6: conv.r8
    IL_03D7: pop
    IL_03D8: nop
    IL_03D9: nop
    IL_03DA: stloc.0
    IL_03DF: call 0x0A000014
    IL_03E0: conv.u4
    IL_03E1: ldarg.1
    IL_03E2: nop
    IL_03E3: nop
    IL_03E4: IL_01
    IL_03E6: stloc.s 12
    IL_03E8: ldloc.s 12
    IL_03E9: conv.r8
    IL_03EA: IL_24
    IL_03EB: nop
    IL_03EC: nop
    IL_03EE: br.s IL_0400
    IL_03EF: stloc.0
    IL_03F0: ldc.i4.1
    IL_03F1: IL_58
    IL_03F3: stloc.s 18
    IL_03F5: ldloca.s 18
    IL_03FA: call 0x0A000010
    IL_03FB: conv.r8
    IL_03FC: IL_FD
    IL_03FD: nop
    IL_03FE: nop
    IL_03FF: stloc.0
    IL_0400: ldarg.0
    IL_0405: ldfld 0x04000A85
    IL_0407: ldloc.s 10
    IL_0408: IL_94
    IL_0409: ldc.i4.0
    IL_040A: IL_3E
    IL_040B: IL_3D
    IL_040C: nop
    IL_040D: nop
    IL_040E: nop
    IL_040F: ldarg.0
    IL_0414: ldfld 0x04000A84
    IL_0415: ldarg.0
    IL_041A: ldfld 0x04000A85
    IL_041C: ldloc.s 10
    IL_041D: IL_94
    IL_041E: ldc.i4.1
    IL_041F: IL_59
    IL_0420: ldelem.i
    IL_0422: ldloc.s 11
    IL_0423: IL_22
    IL_0424: nop
    IL_0425: nop
    IL_0426: nop
    IL_0427: nop
    IL_0428: IL_22
    IL_0429: IL_8F
    IL_042A: IL_C2
    IL_042B: IL_F5
    IL_042C: IL_3D
    IL_042D: IL_22
    IL_042E: IL_CD
    IL_042F: IL_CC
    IL_0430: IL_CC
    IL_0431: IL_BD
    IL_0436: newobj 0x0A000076
    IL_043B: call 0x0A000029
    IL_0440: call 0x0A000013
    IL_0445: call 0x0A000014
    IL_0446: pop
    IL_044B: br IL_04B2
    IL_044C: ldarg.0
    IL_0451: ldfld 0x04000A86
    IL_0453: ldloc.s 10
    IL_0454: conv.r8
    IL_0459: brtrue IL_6F0A045A
    IL_045A: stloc.3
    IL_045B: nop
    IL_045C: nop
    IL_045D: stloc.0
    IL_045E: conv.r8
    IL_0460: ldarg.s 0
    IL_0461: nop
    IL_0462: stloc.0
    IL_0463: ldarg.0
    IL_0468: ldfld 0x04000AAC
    IL_0469: conv.r8
    IL_046B: ldarga.s 0
    IL_046C: nop
    IL_046D: stloc.0
    IL_046E: ldarg.0
    IL_0473: ldfld 0x04000A89
    IL_0475: ldloc.s 11
    IL_0476: IL_22
    IL_0477: nop
    IL_0478: nop
    IL_0479: nop
    IL_047A: nop
    IL_047B: IL_22
    IL_047C: IL_58
    IL_0481: brfalse IL_-32DD3E4A
    IL_0482: IL_CC
    IL_0483: IL_CC
    IL_0484: IL_BD
    IL_0489: newobj 0x0A000076
    IL_048E: call 0x0A000029
    IL_048F: conv.r8
    IL_0490: ldloc.3
    IL_0491: nop
    IL_0492: nop
    IL_0493: stloc.0
    IL_0495: ldloc.s 10
    IL_0496: ldc.i4.1
    IL_0497: IL_58
    IL_0498: ldc.i4.8
    IL_0499: mul
    IL_049E: brtrue IL_04B2
    IL_049F: ldarg.0
    IL_04A4: ldfld 0x04000A8A
    IL_04A6: ldloc.s 11
    IL_04AB: call 0x0A000013
    IL_04B0: call 0x0A000014
    IL_04B1: pop
    IL_04B3: ldloc.s 10
    IL_04B4: ldc.i4.1
    IL_04B5: IL_58
    IL_04B7: stloc.s 10
    IL_04B9: ldloc.s 10
    IL_04BA: ldarg.0
    IL_04BF: ldfld 0x04000AF0
    IL_04C0: IL_3F
    IL_04C1: IL_E1
    IL_04C3: 0xFE FF
    IL_04C4: IL_FF
    IL_04C5: ldarg.0
    IL_04CA: ldfld 0x04000AF0
    IL_04CC: stloc.s 13
    IL_04D1: br IL_0521
    IL_04D2: ldarg.0
    IL_04D7: ldfld 0x04000A86
    IL_04D9: ldloc.s 13
    IL_04DA: conv.r8
    IL_04DF: brtrue IL_280A04E0
    IL_04E0: ldc.i4.5
    IL_04E1: nop
    IL_04E2: nop
    IL_04E3: stloc.0
    IL_04E4: conv.r8
    IL_04E5: IL_AF
    IL_04E6: nop
    IL_04E7: nop
    IL_04E8: stloc.0
    IL_04EA: ldloc.s 13
    IL_04EB: ldc.i4.1
    IL_04EC: IL_58
    IL_04ED: ldc.i4.8
    IL_04EE: mul
    IL_04F3: brtrue IL_051B
    IL_04F4: ldarg.0
    IL_04F9: ldfld 0x04000A86
    IL_04FB: ldloc.s 13
    IL_04FC: conv.r8
    IL_0501: brtrue IL_6F0A0502
    IL_0502: ldc.i4.2
    IL_0503: nop
    IL_0504: nop
    IL_0505: stloc.0
    IL_0507: stloc.s 14
    IL_0508: ldarg.0
    IL_050D: ldfld 0x04000A8A
    IL_050F: ldloc.s 14
    IL_0514: call 0x0A000013
    IL_0519: call 0x0A000014
    IL_051A: pop
    IL_051C: ldloc.s 13
    IL_051D: ldc.i4.1
    IL_051E: IL_58
    IL_0520: stloc.s 13
    IL_0522: ldloc.s 13
    IL_0524: ldc.i4.s 64
    IL_0525: IL_3F
    IL_0526: IL_A8
    IL_0527: IL_FF
    IL_0528: IL_FF
    IL_0529: IL_FF
    IL_052A: ldarg.0
    IL_052F: call 0x060005E6
    IL_0530: ldarg.0
    IL_0531: ldc.i4.1
    IL_0536: call 0x060005E5
    IL_0537: ldarg.0
    IL_053C: call 0x060005E2
    IL_053D: ldarg.0
    IL_0542: call 0x060005E7
    IL_0543: ldarg.0
    IL_0548: ldstr 0x70023285
    IL_0549: IL_22
    IL_054A: nop
    IL_054B: nop
    IL_0550: stsfld 0x147B223F
    IL_0551: IL_AE
    IL_0552: IL_3E
    IL_0557: call 0x0A000017
    IL_0558: ldarg.0
    IL_055D: ldstr 0x700232A7
    IL_055E: IL_22
    IL_055F: nop
    IL_0560: nop
    IL_0561: IL_E8
    IL_0562: IL_41
    IL_0563: IL_22
    IL_0564: nop
    IL_0565: nop
    IL_0566: IL_F0
    IL_0567: IL_41
    IL_056C: call 0x0A000017
    IL_056D: ldc.i4.0
    IL_056F: stloc.s 15
    IL_0574: br IL_05BB
    IL_0575: ldarg.0
    IL_057A: ldfld 0x04000ABE
    IL_057C: ldloc.s 15
    IL_057D: IL_94
    IL_057E: ldc.i4.0
    IL_057F: IL_3F
    IL_0581: ble.s IL_0582
    IL_0582: nop
    IL_0583: nop
    IL_0584: ldarg.0
    IL_0589: ldfld 0x04000ABB
    IL_058B: ldloc.s 15
    IL_0590: ldstr 0x700232C3
    IL_0591: ldarg.0
    IL_0596: ldfld 0x04000ABE
    IL_0598: ldloc.s 15
    IL_0599: IL_94
    IL_059A: ldc.i4.1
    IL_059B: IL_58
    IL_059D: stloc.s 19
    IL_059F: ldloca.s 19
    IL_05A4: call 0x0A000010
    IL_05A9: call 0x0A000011
    IL_05AE: call 0x0A000012
    IL_05AF: conv.u8
    IL_05B0: IL_3C
    IL_05B1: nop
    IL_05B2: nop
    IL_05B3: IL_01
    IL_05B8: stelem 0x58170F11
    IL_05BA: stloc.s 15
    IL_05BC: ldloc.s 15
    IL_05BD: ldc.i4.5
    IL_05BE: IL_3F
    IL_05BF: IL_B2
    IL_05C0: IL_FF
    IL_05C1: IL_FF
    IL_05C2: IL_FF
    IL_05C3: ldarg.0
    IL_05C8: call 0x060005E2
    IL_05CD: call 0x0600004E
    IL_05CE: conv.r8
    IL_05CF: shr.un
    IL_05D0: nop
    IL_05D1: nop
    IL_05D2: ldloc.0
    IL_05D3: ret
    }

    private void ImageLoading() {
    IL_0004: newobj 0x0600079F
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x04001076
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x0400107A
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_001A: stfld 0x0400107B
    IL_001B: ldloc.0
    IL_001C: ret
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000B0F
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000B0F
    IL_0010: ret
    }

    public void SetMenuOpen() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700004DD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000AF2
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000AF2
    IL_0016: ldc.i4.7
    IL_0017: IL_3F
    IL_0018: stloc.2
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.0
    IL_001D: ldc.i4.5
    IL_0022: stfld 0x04000AFA
    IL_0027: br IL_00A7
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000AF2
    IL_002E: ldc.i4.6
    IL_002F: IL_3F
    IL_0030: stloc.2
    IL_0031: nop
    IL_0032: nop
    IL_0033: nop
    IL_0034: ldarg.0
    IL_0035: ldc.i4.5
    IL_003A: stfld 0x04000AFA
    IL_003F: br IL_00A7
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000AF2
    IL_0046: ldc.i4.4
    IL_0047: IL_3F
    IL_0048: stloc.2
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: ldarg.0
    IL_004D: ldc.i4.4
    IL_0052: stfld 0x04000AFA
    IL_0057: br IL_00A7
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000AF2
    IL_005E: ldc.i4.3
    IL_005F: IL_3F
    IL_0060: stloc.2
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldarg.0
    IL_0065: ldc.i4.4
    IL_006A: stfld 0x04000AFA
    IL_006F: br IL_00A7
    IL_0070: ldarg.0
    IL_0075: ldfld 0x04000AF2
    IL_0076: ldc.i4.2
    IL_0077: IL_3F
    IL_0078: stloc.2
    IL_0079: nop
    IL_007A: nop
    IL_007B: nop
    IL_007C: ldarg.0
    IL_007D: ldc.i4.3
    IL_0082: stfld 0x04000AFA
    IL_0087: br IL_00A7
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04000AF2
    IL_008E: ldc.i4.1
    IL_008F: IL_3F
    IL_0090: stloc.2
    IL_0091: nop
    IL_0092: nop
    IL_0093: nop
    IL_0094: ldarg.0
    IL_0095: ldc.i4.2
    IL_009A: stfld 0x04000AFA
    IL_009F: br IL_00A7
    IL_00A0: ldarg.0
    IL_00A1: ldc.i4.1
    IL_00A6: stfld 0x04000AFA
    IL_00A7: ret
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_005D
    IL_000A: ldstr 0x70022F5F
    IL_000B: ldc.i4.0
    IL_0010: call 0x0600021F
    IL_0015: ldstr 0x70022F87
    IL_001A: call 0x0A000128
    IL_001B: ldarg.0
    IL_001C: ldc.i4.1
    IL_0021: stfld 0x04000AD8
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000AF7
    IL_002C: call 0x0A000050
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000A81
    IL_0033: conv.r8
    IL_0034: stloc.0
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_003C: call 0x0A000050
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000A82
    IL_0043: conv.r8
    IL_0044: stloc.0
    IL_0045: nop
    IL_0046: nop
    IL_0047: stloc.0
    IL_004C: call 0x0A000050
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000A83
    IL_0053: conv.r8
    IL_0054: stloc.0
    IL_0055: nop
    IL_0056: nop
    IL_0057: stloc.0
    IL_005C: call 0x0A000050
    IL_005D: ret
    }

    public void PopUpOff() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000AF9
    IL_0007: ret
    }

    public void CurGeneralStat() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0035
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000B07
    IL_000C: ldc.i4.m1
    IL_0011: beq IL_0035
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000B16
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000B09
    IL_001E: conv.r8
    IL_001F: IL_F5
    IL_0020: ldarg.0
    IL_0021: nop
    IL_0022: ldloc.0
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000B16
    IL_002E: ldfld 0x04000677
    IL_002F: conv.i2
    IL_0034: stfld 0x04000B08
    IL_0035: ret
    }

    public void GeneralKindOnly() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B09
    IL_000A: ldc.i4 10000000
    IL_000B: mul
    IL_0010: ldc.i4 100000
    IL_0011: add
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldstr 0x70022E37
    IL_0019: ldloc.0
    IL_001A: ldc.i4.1
    IL_001B: IL_58
    IL_001C: stloc.1
    IL_001E: ldloca.s 1
    IL_0023: call 0x0A000010
    IL_0028: call 0x0A000011
    IL_002D: call 0x0A000012
    IL_002E: conv.u8
    IL_002F: IL_3C
    IL_0030: nop
    IL_0031: nop
    IL_0032: IL_01
    IL_0037: stfld 0x04000B0C
    IL_0038: ret
    }

    private void SetServerTime() {
    IL_0004: call 0x0600056E
    IL_0005: ldarg.0
    IL_000A: call 0x060005E8
    IL_000B: ret
    }

    public void DelayWorkTime() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0019
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B03
    IL_000D: ldloc.0
    IL_000E: ldloc.0
    IL_0013: call 0x0600056F
    IL_0014: ldelem.i8
    IL_0015: ldloc.0
    IL_0016: ldc.i4.1
    IL_0017: IL_58
    IL_0018: stloc.0
    IL_0019: ldloc.0
    IL_001A: ldc.i4.2
    IL_001B: IL_3F
    IL_001C: IL_E7
    IL_001D: IL_FF
    IL_001E: IL_FF
    IL_001F: IL_FF
    IL_0020: ldarg.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000B0A
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000B03
    IL_002D: ldc.i4.1
    IL_002E: IL_94
    IL_002F: conv.i2
    IL_0030: IL_22
    IL_0031: IL_CD
    IL_0032: IL_CC
    IL_0033: IL_4C
    IL_0034: IL_3E
    IL_0035: IL_5A
    IL_0036: not
    IL_0037: IL_58
    IL_003C: stfld 0x04000B0B
    IL_003D: ldarg.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000B0B
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000B08
    IL_004A: not
    IL_004F: call 0x0A00010B
    IL_0054: stfld 0x04000B0B
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000B03
    IL_005B: ldc.i4.0
    IL_005C: IL_94
    IL_0061: ldc.i4 360
    IL_0062: IL_3E
    IL_0065: stloc 0
    IL_0066: nop
    IL_0067: ldarg.0
    IL_0068: dup
    IL_006D: ldfld 0x04000AFD
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000B03
    IL_0074: ldc.i4.0
    IL_0075: IL_94
    IL_007A: ldc.i4 360
    IL_007B: add
    IL_007C: IL_58
    IL_0081: stfld 0x04000AFD
    IL_0082: ldarg.0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000AFD
    IL_0089: ldc.i4.0
    IL_008A: ldc.i4.5
    IL_008F: call 0x0A0002AA
    IL_0094: stfld 0x04000AFD
    IL_0095: ldc.i4.0
    IL_009A: call 0x0600056B
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000B03
    IL_00A1: ldc.i4.0
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000B03
    IL_00A8: ldc.i4.0
    IL_00A9: IL_94
    IL_00AE: ldc.i4 360
    IL_00AF: mul
    IL_00B0: ldelem.i8
    IL_00B1: ldarg.0
    IL_00B6: ldc.i4 360
    IL_00B7: ldarg.0
    IL_00BC: ldfld 0x04000B03
    IL_00BD: ldc.i4.0
    IL_00BE: IL_94
    IL_00BF: IL_59
    IL_00C1: ldc.i4.s 60
    IL_00C2: add
    IL_00C7: stfld 0x04000B04
    IL_00C8: ldarg.0
    IL_00CD: ldc.i4 360
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x04000B03
    IL_00D4: ldc.i4.0
    IL_00D5: IL_94
    IL_00D6: IL_59
    IL_00D8: ldc.i4.s 60
    IL_00D9: mul
    IL_00DE: stfld 0x04000B05
    IL_00DF: ret
    }

    public void BattleStart() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000AF4
    IL_0006: ldnull
    IL_000B: call 0x0A000021
    IL_0010: brfalse IL_0021
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000AF4
    IL_0017: conv.r8
    IL_0018: stloc.0
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: call 0x0A000050
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000AF7
    IL_002B: call 0x0A000050
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000A81
    IL_0032: conv.r8
    IL_0033: stloc.0
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A000050
    IL_003C: ldarg.0
    IL_0041: ldfld 0x04000A82
    IL_0042: conv.r8
    IL_0043: stloc.0
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_004B: call 0x0A000050
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000A83
    IL_0052: conv.r8
    IL_0053: stloc.0
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_005B: call 0x0A000050
    IL_0060: ldstr 0x70022DD9
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000AF1
    IL_006B: call 0x0600021F
    IL_0070: ldstr 0x70001F71
    IL_0075: call 0x06000220
    IL_0076: stloc.0
    IL_0077: ldloc.0
    IL_0078: ldc.i4.1
    IL_0079: IL_58
    IL_007A: stloc.0
    IL_007F: ldstr 0x70001F71
    IL_0080: ldloc.0
    IL_0085: call 0x0600021F
    IL_0086: ldarg.0
    IL_0087: dup
    IL_008C: ldfld 0x04000AFD
    IL_008D: ldc.i4.1
    IL_008E: IL_59
    IL_0093: stfld 0x04000AFD
    IL_0098: ldstr 0x7000066F
    IL_0099: ldarg.0
    IL_009E: ldfld 0x04000AFD
    IL_00A3: call 0x0600021F
    IL_00A4: ldarg.0
    IL_00A5: ldc.i4.1
    IL_00AA: stfld 0x04000AD8
    IL_00AF: ldstr 0x700232CB
    IL_00B4: call 0x0A000128
    IL_00B5: ldarg.0
    IL_00BA: ldfld 0x04000AFD
    IL_00BB: ldc.i4.5
    IL_00BC: IL_3F
    IL_00BD: ldloc.0
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldc.i4.0
    IL_00C6: call 0x0600056B
    IL_00CB: ldstr 0x70000CDD
    IL_00CD: ldc.i4.s 100
    IL_00D2: call 0x0600021F
    IL_00D7: ldstr 0x7000174B
    IL_00D9: ldc.i4.s 11
    IL_00DE: call 0x0600021F
    IL_00E3: ldstr 0x70000BDB
    IL_00E4: ldc.i4.0
    IL_00E9: call 0x0600021F
    IL_00EE: ldstr 0x700028DD
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000ABF
    IL_00F9: call 0x060003F8
    IL_00FA: pop
    IL_00FB: ret
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000AFC
    IL_0006: conv.r8
    IL_0007: ldc.i4.7
    IL_0008: IL_01
    IL_0009: nop
    IL_000A: ldloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000AF6
    IL_0011: ldnull
    IL_0016: call 0x0A000061
    IL_001B: brfalse IL_0031
    IL_001C: ldarg.0
    IL_0021: ldstr 0x700232DD
    IL_0026: call 0x0A000012
    IL_0027: conv.u8
    IL_0028: ldloc.0
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_01
    IL_0030: stfld 0x04000AF6
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000AF6
    IL_0037: conv.r8
    IL_0038: ldarg.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_0040: call 0x0A00001B
    IL_0045: call 0x0A000013
    IL_004A: call 0x0A000014
    IL_004B: pop
    IL_004C: ret
    }

    public void ItemKeep() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0008: br IL_0041
    IL_0009: ldarg.0
    IL_000E: ldfld 0x04000ABF
    IL_000F: ldloc.1
    IL_0010: IL_94
    IL_0015: brtrue IL_003D
    IL_0016: ldarg.0
    IL_001B: ldfld 0x04000ABF
    IL_001C: ldloc.1
    IL_001D: ldarg.1
    IL_001E: ldc.i4.1
    IL_001F: IL_58
    IL_0020: ldelem.i8
    IL_0021: ldc.i4.1
    IL_0022: stloc.0
    IL_0023: ldarg.0
    IL_0024: dup
    IL_0029: ldfld 0x04000AFE
    IL_002A: ldarg.0
    IL_002F: ldfld 0x04000ABD
    IL_0030: ldarg.1
    IL_0031: IL_94
    IL_0032: IL_58
    IL_0037: stfld 0x04000AFE
    IL_003C: br IL_0048
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: IL_58
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldc.i4.3
    IL_0043: IL_3F
    IL_0044: IL_C1
    IL_0045: IL_FF
    IL_0046: IL_FF
    IL_0047: IL_FF
    IL_0048: ldloc.0
    IL_0049: ret
    }

    private void ItemOver() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0008: br IL_0024
    IL_0009: ldarg.0
    IL_000E: ldfld 0x04000ABF
    IL_000F: ldloc.1
    IL_0010: IL_94
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: IL_58
    IL_0034: switch (7 cases)
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B12
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000B13
    IL_000E: ret
    }

    public void SetStage() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100000B
    IL_000B: stfld 0x04000ABF
    IL_000C: ldarg.0
    IL_000D: ldc.i4.1
    IL_0012: stfld 0x04000AD2
    IL_0013: ldarg.0
    IL_0014: IL_22
    IL_0015: nop
    IL_0016: nop
    IL_001B: ldc.i4 8769
    IL_001C: IL_F0
    IL_001D: IL_42
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0025: ldstr 0x00002243
    IL_0026: IL_34
    IL_0027: IL_43
    IL_002C: newobj 0x0A000147
    IL_0031: stfld 0x04000AE8
    IL_0032: ldarg.0
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0038: ldloc 32195
    IL_0039: IL_EA
    IL_003A: stloc.0
    IL_003B: nop
    IL_003C: ldarg.2
    IL_003D: ldarg.0
    IL_003E: IL_22
    IL_003F: nop
    IL_0044: stsfld 0xEB7D4409
    IL_0045: stloc.0
    IL_0046: nop
    IL_0047: ldarg.2
    IL_0048: ldarg.0
    IL_0049: ldarg.1
    IL_004A: ldc.i4.1
    IL_004B: IL_58
    IL_0050: stfld 0x04000AF1
    IL_0051: ret
    }

    private void Update() {
    IL_0004: ldstr 0x7000064F
    IL_0009: call 0x0A000095
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_00BD: switch (43 cases)
    IL_00BE: nop
    IL_00BF: ldarg.0
    IL_00C1: ldloca.s 1
    IL_00C6: call 0x0A000118
    IL_00CB: stfld 0x04000AF5
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x04000AF5
    IL_00D6: call 0x0A00004B
    IL_00D7: IL_22
    IL_00D8: IL_CD
    IL_00D9: IL_CC
    IL_00DA: IL_4C
    IL_00DB: IL_3F
    IL_00E0: call 0x0A000008
    IL_00E1: conv.r8
    IL_00E2: IL_AF
    IL_00E3: nop
    IL_00E4: nop
    IL_00E5: stloc.0
    IL_00EA: br IL_0148
    IL_00EB: ldc.i4.0
    IL_00F0: call 0x0A0000D8
    IL_00F5: brfalse IL_0148
    IL_00F6: ldarg.0
    IL_00FB: ldfld 0x04000AF5
    IL_00FC: ldnull
    IL_0101: call 0x0A000021
    IL_0106: brfalse IL_0148
    IL_0107: ldarg.0
    IL_010C: ldfld 0x04000AFC
    IL_0111: ldfld 0x04000226
    IL_0116: brtrue IL_0127
    IL_0117: ldarg.0
    IL_011C: ldfld 0x04000AF5
    IL_011D: conv.r8
    IL_0122: ldsflda 0x6F2B0000
    IL_0123: IL_50
    IL_0124: ldarg.1
    IL_0125: nop
    IL_0126: ldloc.0
    IL_0127: ldarg.0
    IL_012C: ldfld 0x04000AF5
    IL_0131: call 0x0A00004B
    IL_0132: IL_22
    IL_0134: bne.un.s IL_0168
    IL_0136: bne.un.s IL_0176
    IL_013B: call 0x0A000008
    IL_013C: conv.r8
    IL_013D: IL_AF
    IL_013E: nop
    IL_013F: nop
    IL_0140: stloc.0
    IL_0141: ldarg.0
    IL_0142: ldnull
    IL_0147: stfld 0x04000AF5
    IL_0148: ldarg.0
    IL_0149: ldarg.0
    IL_014E: ldfld 0x04000AEA
    IL_014F: IL_22
    IL_0150: nop
    IL_0151: nop
    IL_0152: IL_A8
    IL_0153: IL_42
    IL_0158: call 0x0A000024
    IL_0159: IL_22
    IL_015A: nop
    IL_015B: nop
    IL_015C: throw
    IL_015D: IL_44
    IL_015E: IL_5A
    IL_0163: call 0x0A0000C0
    IL_0168: stfld 0x04000AEA
    IL_0169: ldarg.0
    IL_016A: ldarg.0
    IL_016F: ldfld 0x04000AEB
    IL_0170: IL_22
    IL_0171: nop
    IL_0172: nop
    IL_0177: newobj 0x00242843
    IL_0178: nop
    IL_0179: stloc.0
    IL_017A: IL_22
    IL_017B: nop
    IL_017C: nop
    IL_017D: throw
    IL_017E: IL_44
    IL_017F: IL_5A
    IL_0184: call 0x0A0000C0
    IL_0189: stfld 0x04000AEB
    IL_018A: ldarg.0
    IL_018B: ldarg.0
    IL_0190: ldfld 0x04000AEC
    IL_0191: IL_22
    IL_0192: nop
    IL_0193: nop
    IL_0194: IL_E4
    IL_0195: IL_42
    IL_019A: call 0x0A000024
    IL_019B: IL_22
    IL_019C: nop
    IL_019D: nop
    IL_019E: throw
    IL_019F: IL_44
    IL_01A0: IL_5A
    IL_01A5: call 0x0A0000C0
    IL_01AA: stfld 0x04000AEC
    IL_01AB: ldarg.0
    IL_01B0: ldstr 0x70000557
    IL_01B1: ldc.i4.0
    IL_01B6: call 0x0A0002BB
    IL_01BB: stfld 0x04000B14
    IL_01C0: ldstr 0x70000575
    IL_01C5: call 0x0A000097
    IL_01C6: stloc.3
    IL_01C7: ldloc.3
    IL_01CC: ldstr 0x70000583
    IL_01CD: conv.r8
    IL_01CE: len
    IL_01CF: nop
    IL_01D0: nop
    IL_01D1: stloc.0
    IL_01D6: brtrue IL_0206
    IL_01D7: ldarg.0
    IL_01DC: ldstr 0x70001EA5
    IL_01E1: call 0x06000220
    IL_01E6: stfld 0x04000AED
    IL_01E7: ldarg.0
    IL_01EC: ldstr 0x700004D5
    IL_01F1: call 0x06000220
    IL_01F6: stfld 0x04000AEE
    IL_01FB: ldstr 0x70000575
    IL_0200: ldstr 0x70022ADA
    IL_0205: call 0x0A00008F
    IL_0206: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000ADF
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_E0
    IL_0045: IL_42
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_0052: stsfld 0x00002243
    IL_0053: nop
    IL_0054: IL_42
    IL_0059: call 0x0600021D
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000A91
    IL_0064: call 0x0A0000E0
    IL_0065: IL_22
    IL_0066: nop
    IL_0067: nop
    IL_0069: ldloca.s 67
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_C0
    IL_2800000FA: switch (2684354594 cases)
    }

    private void Text_Length() {
    IL_0004: ldsfld 0x0A000099
    IL_0005: stloc.0
    IL_0006: ldc.i4.0
    IL_0007: stloc.1
    IL_0008: ldc.i4.0
    IL_0009: stloc.2
    IL_000A: ldc.i4.m1
    IL_000B: stloc.3
    IL_000C: ldc.i4.0
    IL_000E: stloc.s 4
    IL_0013: br IL_0058
    IL_0018: call 0x0A0002EE
    IL_0019: ldarg.1
    IL_001B: ldloc.s 4
    IL_001C: ldc.i4.1
    IL_001D: conv.r8
    IL_001E: ldelem.i2
    IL_001F: nop
    IL_0020: nop
    IL_0021: stloc.0
    IL_0022: conv.r8
    IL_0023: IL_4E
    IL_0024: IL_01
    IL_0025: nop
    IL_0026: stloc.0
    IL_0028: stloc.s 5
    IL_002A: ldloc.s 5
    IL_002B: len
    IL_002C: not
    IL_002D: ldc.i4.1
    IL_002E: IL_3E
    IL_002F: ldloc.3
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0033: ldloc.1
    IL_0034: ldc.i4.2
    IL_0035: IL_58
    IL_0036: stloc.1
    IL_003B: br IL_0040
    IL_003C: ldloc.1
    IL_003D: ldc.i4.1
    IL_003E: IL_58
    IL_003F: stloc.1
    IL_0041: ldloc.s 4
    IL_0042: stloc.3
    IL_0043: ldloc.1
    IL_0045: ldc.i4.s 10
    IL_0046: IL_3E
    IL_0047: ldloc.1
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: ldc.i4.1
    IL_004C: stloc.2
    IL_0051: br IL_0065
    IL_0053: ldloc.s 4
    IL_0054: ldc.i4.1
    IL_0055: IL_58
    IL_0057: stloc.s 4
    IL_0059: ldloc.s 4
    IL_005A: ldarg.1
    IL_005B: conv.r8
    IL_005C: ldelem.i1
    IL_005D: nop
    IL_005E: nop
    IL_005F: stloc.0
    IL_0060: IL_3F
    IL_0061: IL_AF
    IL_0062: IL_FF
    IL_0063: IL_FF
    IL_0064: IL_FF
    IL_0065: ldloc.2
    IL_006A: brfalse IL_0079
    IL_006B: ldarg.1
    IL_006C: ldc.i4.0
    IL_006D: ldloc.3
    IL_006E: conv.r8
    IL_006F: ldelem.i2
    IL_0070: nop
    IL_0071: nop
    IL_0072: stloc.0
    IL_0073: stloc.0
    IL_0078: br IL_007B
    IL_0079: ldarg.1
    IL_007A: stloc.0
    IL_007B: ldloc.0
    IL_007C: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: ldc.i4 5000
    IL_000A: newarr 0x0200010E
    IL_000F: stfld 0x04000B20
    IL_0010: ldarg.0
    IL_0012: ldc.i4.s 100
    IL_0017: newarr 0x0200010F
    IL_001C: stfld 0x04000B21
    IL_001D: ldarg.0
    IL_001F: ldc.i4.s 100
    IL_0024: newarr 0x02000110
    IL_0029: stfld 0x04000B22
    IL_002A: ldarg.0
    IL_002B: ldc.i4.5
    IL_0030: stfld 0x04000B23
    IL_0031: ldarg.0
    IL_0032: ldc.i4.5
    IL_0037: newarr 0x0100003C
    IL_003C: stfld 0x04000B2B
    IL_003D: ldarg.0
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: IL_C8
    IL_0042: IL_C2
    IL_0047: stfld 0x04000B3A
    IL_0048: ldarg.0
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: IL_FA
    IL_004D: IL_43
    IL_0052: stfld 0x04000B3B
    IL_0053: ldarg.0
    IL_0054: IL_22
    IL_0055: nop
    IL_0056: nop
    IL_0057: IL_E4
    IL_0058: IL_42
    IL_005D: stfld 0x04000B3C
    IL_005E: ldarg.0
    IL_0063: ldstr 0x7002342B
    IL_0068: stfld 0x04000B48
    IL_0069: ldarg.0
    IL_006E: call 0x0A000001
    IL_006F: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000B39
    IL_0010: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x060005FE
    IL_0006: ldarg.0
    IL_0007: ldc.i4.0
    IL_000C: call 0x060005F6
    IL_000D: ldarg.0
    IL_0012: ldstr 0x70023285
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_001A: stsfld 0x147B223F
    IL_001B: IL_AE
    IL_001C: IL_3E
    IL_0021: call 0x0A000017
    IL_0022: ret
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000B45
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000B45
    IL_0010: ret
    }

    public void SetMyImage() {
    IL_0000: ret
    }

    private void MyImageLoading() {
    IL_0004: newobj 0x060007A5
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x0400107C
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x04001080
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_001A: stfld 0x04001081
    IL_001B: ldloc.0
    IL_001C: ret
    }

    public void FaceLoginFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B3F
    IL_0007: ldarg.0
    IL_0008: ldarg.0
    IL_000D: call 0x060005FB
    IL_0012: call 0x0A000047
    IL_0013: pop
    IL_0014: ret
    }

    private void GetFaceBookMe() {
    IL_0004: newobj 0x060007AB
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001088
    IL_000D: ldloc.0
    IL_000E: ret
    }

    private void GetMyFacebookImg() {
    IL_0004: newobj 0x060007B1
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x04001089
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x0400108D
    IL_0014: ldloc.0
    IL_0015: ret
    }

    private void GetFaceBookFriends() {
    IL_0004: newobj 0x060007B7
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x04001096
    IL_000D: ldloc.0
    IL_000E: ret
    }

    private void GetFacebookImg() {
    IL_0004: newobj 0x060007BD
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x04001097
    IL_000D: ldloc.0
    IL_000E: ldarg.2
    IL_0013: stfld 0x04001099
    IL_0014: ldloc.0
    IL_0015: ldarg.1
    IL_001A: stfld 0x0400109C
    IL_001B: ldloc.0
    IL_001C: ldarg.2
    IL_0021: stfld 0x0400109D
    IL_0022: ldloc.0
    IL_0023: ldarg.0
    IL_0028: stfld 0x0400109E
    IL_0029: ldloc.0
    IL_002A: ret
    }

    public void ChangeNickName() {
    IL_0000: ret
    }

    public void GetHSPFriends() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: newarr 0x0200010F
    IL_000C: stfld 0x04000B21
    IL_000D: ldarg.0
    IL_000E: ldc.i4.1
    IL_0013: stfld 0x04000B3E
    IL_0014: ret
    }

    public void RemoveHSPFriends() {
    IL_0000: ldc.i4.1
    IL_0005: newobj 0x0A0002EF
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldarg.1
    IL_0009: conv.r8
    IL_000A: IL_F0
    IL_000B: ldarg.0
    IL_000C: nop
    IL_000D: stloc.0
    IL_000E: ret
    }

    public void SetMemberNos() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: newarr 0x02000110
    IL_000C: stfld 0x04000B22
    IL_000D: ldarg.0
    IL_000E: ldc.i4.0
    IL_0013: stfld 0x04000B25
    IL_0014: ldc.i4.0
    IL_0015: stloc.0
    IL_0016: ldarg.1
    IL_0017: conv.r8
    IL_0018: IL_F1
    IL_0019: ldarg.0
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: stloc.2
    IL_0021: br IL_0081
    IL_0023: ldloca.s 2
    IL_0028: call 0x0A0002F2
    IL_0029: stloc.1
    IL_002A: ldarg.0
    IL_002F: ldfld 0x04000B44
    IL_0030: stloc.3
    IL_0031: ldloc.3
    IL_0032: ldc.i4.0
    IL_0037: beq IL_003D
    IL_003C: br IL_005F
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000B21
    IL_0043: ldloc.0
    IL_0044: IL_8F
    IL_0046: ldarga.s 1
    IL_0047: nop
    IL_0048: ldarg.0
    IL_0049: ldloc.1
    IL_004E: stfld 0x04000B4F
    IL_004F: ldloc.0
    IL_0050: ldc.i4.1
    IL_0051: IL_58
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0054: ldloc.0
    IL_0059: stfld 0x04000B24
    IL_005E: br IL_0081
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000B22
    IL_0065: ldloc.0
    IL_0066: IL_8F
    IL_0068: starg.s 1
    IL_0069: nop
    IL_006A: ldarg.0
    IL_006B: ldloc.1
    IL_0070: stfld 0x04000B52
    IL_0071: ldloc.0
    IL_0072: ldc.i4.1
    IL_0073: IL_58
    IL_0074: stloc.0
    IL_0075: ldarg.0
    IL_0076: ldloc.0
    IL_007B: stfld 0x04000B25
    IL_0080: br IL_0081
    IL_0082: ldloca.s 2
    IL_0087: call 0x0A0002F3
    IL_008C: brtrue IL_0022
    IL_008D: IL_DD
    IL_008E: stloc.2
    IL_008F: nop
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldloc.2
    IL_0097: newobj 0x1B000021
    IL_0098: conv.r8
    IL_0099: ldelem.ref
    IL_009A: nop
    IL_009B: nop
    IL_009C: stloc.0
    IL_009D: IL_DC
    IL_009E: ret
    }

    public void JudgeFriend() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B22
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000B49
    IL_000C: IL_8F
    IL_000E: starg.s 1
    IL_000F: nop
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0016: stfld 0x04000B55
    IL_0017: ldarg.0
    IL_0018: dup
    IL_001D: ldfld 0x04000B49
    IL_001E: ldc.i4.1
    IL_001F: IL_58
    IL_0024: stfld 0x04000B49
    IL_0025: ret
    }

    public void HSPFriendsImg() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.1
    IL_0003: conv.r8
    IL_0004: IL_F4
    IL_0005: ldarg.0
    IL_0006: nop
    IL_0007: stloc.0
    IL_0008: stloc.2
    IL_000D: br IL_0029
    IL_000F: ldloca.s 2
    IL_0014: call 0x0A0002F5
    IL_0015: stloc.1
    IL_0016: ldarg.0
    IL_0017: ldarg.0
    IL_0018: ldloc.1
    IL_0019: ldloc.0
    IL_001E: call 0x06000603
    IL_0023: call 0x0A000047
    IL_0024: pop
    IL_0025: ldloc.0
    IL_0026: ldc.i4.1
    IL_0027: IL_58
    IL_0028: stloc.0
    IL_002A: ldloca.s 2
    IL_002F: call 0x0A0002F6
    IL_0034: brtrue IL_000E
    IL_0035: IL_DD
    IL_0036: stloc.2
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003A: ldloc.2
    IL_003F: newobj 0x1B000023
    IL_0040: conv.r8
    IL_0041: ldelem.ref
    IL_0042: nop
    IL_0043: nop
    IL_0044: stloc.0
    IL_0045: IL_DC
    IL_0046: ret
    }

    private void GetProfileImg() {
    IL_0004: newobj 0x060007C3
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x0400109F
    IL_000D: ldloc.0
    IL_000E: ldarg.2
    IL_0013: stfld 0x040010A1
    IL_0014: ldloc.0
    IL_0015: ldarg.1
    IL_001A: stfld 0x040010A4
    IL_001B: ldloc.0
    IL_001C: ldarg.2
    IL_0021: stfld 0x040010A5
    IL_0022: ldloc.0
    IL_0023: ldarg.0
    IL_0028: stfld 0x040010A6
    IL_0029: ldloc.0
    IL_002A: ret
    }

    private void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000B46
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000B3A
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_C8
    IL_000B: IL_42
    IL_0010: call 0x0A000024
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: throw
    IL_0015: IL_44
    IL_0016: IL_5A
    IL_001B: call 0x0A0000C0
    IL_0020: stfld 0x04000B3A
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000B3B
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: len
    IL_002C: IL_43
    IL_0031: call 0x0A000024
    IL_0032: IL_22
    IL_0033: nop
    IL_0034: nop
    IL_0035: throw
    IL_0036: IL_44
    IL_0037: IL_5A
    IL_003C: call 0x0A0000C0
    IL_0041: stfld 0x04000B3B
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000B41
    IL_0048: ldc.i4.0
    IL_0049: IL_3E
    IL_004A: IL_BA
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000B1F
    IL_0054: conv.r8
    IL_0055: IL_F7
    IL_0056: ldarg.0
    IL_0057: nop
    IL_0058: stloc.0
    IL_005D: brfalse IL_0108
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000B1F
    IL_0064: conv.r8
    IL_0065: IL_F8
    IL_0066: ldarg.0
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: stloc.0
    IL_006E: call 0x0A0002EE
    IL_006F: ldloc.0
    IL_0070: conv.r8
    IL_0071: IL_4E
    IL_0072: IL_01
    IL_0073: nop
    IL_0074: stloc.0
    IL_0075: len
    IL_0076: not
    IL_0077: stloc.1
    IL_0078: ldloc.1
    IL_0079: ldc.i4.4
    IL_007A: IL_3C
    IL_007C: bge.s IL_007D
    IL_007D: nop
    IL_007E: nop
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000B41
    IL_0085: ldc.i4.2
    IL_00A6: switch (7 cases)
    IL_00A7: nop
    IL_00A8: stloc.0
    IL_00AD: br IL_0101
    IL_00AE: ldloc.0
    IL_00B3: ldsfld 0x0A000099
    IL_00B8: call 0x0A0000A6
    IL_00BD: brfalse IL_00EE
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x04000B41
    IL_00C4: stloc.2
    IL_00C5: ldloc.2
    IL_00C6: ldc.i4.1
    IL_00CB: beq IL_00D8
    IL_00CC: ldloc.2
    IL_00CD: ldc.i4.2
    IL_00D2: beq IL_00E4
    IL_00D7: br IL_00E9
    IL_00D8: ldarg.0
    IL_00D9: ldloc.0
    IL_00DE: stfld 0x04000B42
    IL_00E3: br IL_00E9
    IL_00E8: br IL_00E9
    IL_00ED: br IL_0101
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x04000B41
    IL_00F4: ldc.i4.2
    IL_0115: switch (7 cases)
    }

    private void OnGUI() {
    IL_0001: ldc.i4.s -8
    IL_0006: call 0x0A0000EF
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B34
    IL_0011: call 0x0A0000DF
    IL_0016: call 0x0A00001B
    IL_001B: call 0x0A000013
    IL_0020: call 0x0A0000D9
    IL_0021: conv.i2
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: cpobj 0xDA285B44
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: conv.i2
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0035: ldc.i4 2251588
    IL_0036: nop
    IL_003B: stsfld 0x0076733F
    IL_003C: nop
    IL_003D: stloc.0
    IL_0042: call 0x0A0000DD
    IL_0047: call 0x0A0000DE
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000B46
    IL_004E: ldc.i4.0
    IL_004F: IL_3E
    IL_0050: ldloc.0
    IL_0051: nop
    IL_0052: nop
    IL_0053: nop
    IL_0054: ldc.i4.0
    IL_0059: call 0x0A0001B9
    IL_005A: IL_22
    IL_005B: nop
    IL_005C: nop
    IL_0061: ldtoken 0x00002243
    IL_0062: nop
    IL_0063: nop
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_006B: stsfld 0x00002242
    IL_0070: stsfld 0x021D2842
    IL_0071: nop
    IL_0072: ldloc.0
    IL_0077: ldsfld 0x0A000099
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000B30
    IL_0082: call 0x0A0000F1
    IL_0087: brfalse IL_0092
    IL_008C: ldstr 0x70022F8F
    IL_0091: call 0x0A000128
    IL_0096: call 0x0A000115
    IL_009B: brfalse IL_0100
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x04000B3B
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: IL_94
    IL_00A6: IL_42
    IL_00A7: IL_59
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x04000B3C
    IL_00AE: IL_22
    IL_00AF: nop
    IL_00B0: nop
    IL_00B5: ldtoken 0x00225941
    IL_00B6: nop
    IL_00B7: IL_81
    IL_00B8: IL_43
    IL_00B9: IL_22
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: IL_5A
    IL_00BD: IL_43
    IL_00C2: call 0x0600021D
    IL_00C4: stloc.s 7
    IL_00C6: ldloca.s 7
    IL_00CB: call 0x0A0001FE
    IL_00CC: conv.r8
    IL_00CD: IL_FF
    IL_00CE: IL_01
    IL_00CF: nop
    IL_00D0: stloc.0
    IL_00D5: call 0x0A000200
    IL_00DA: brfalse IL_00FB
    IL_00DB: ldarg.0
    IL_00E0: call 0x0A0000D7
    IL_00E2: stloc.s 8
    IL_00E4: ldloca.s 8
    IL_00E9: ldfld 0x0A000023
    IL_00EE: stfld 0x04000B36
    IL_00EF: ldarg.0
    IL_00F0: ldarg.0
    IL_00F5: ldfld 0x04000B37
    IL_00FA: stfld 0x04000B38
    IL_00FF: br IL_0196
    IL_0104: call 0x0A00011A
    IL_0109: brfalse IL_0196
    IL_010A: ldarg.0
    IL_010F: ldfld 0x04000B3B
    IL_0110: IL_22
    IL_0111: nop
    IL_0112: nop
    IL_0113: IL_94
    IL_0114: IL_42
    IL_0115: IL_59
    IL_0116: ldarg.0
    IL_011B: ldfld 0x04000B3C
    IL_011C: IL_22
    IL_011D: nop
    IL_011E: nop
    IL_0123: ldtoken 0x00225941
    IL_0124: nop
    IL_0125: IL_81
    IL_0126: IL_43
    IL_0127: IL_22
    IL_0128: nop
    IL_0129: nop
    IL_012A: IL_5A
    IL_012B: IL_43
    IL_0130: call 0x0600021D
    IL_0132: stloc.s 9
    IL_0134: ldloca.s 9
    IL_0139: call 0x0A0001FE
    IL_013A: conv.r8
    IL_013B: IL_FF
    IL_013C: IL_01
    IL_013D: nop
    IL_013E: stloc.0
    IL_0143: call 0x0A000200
    IL_0148: brfalse IL_0196
    IL_0149: ldarg.0
    IL_014E: call 0x0A0000D7
    IL_0150: stloc.s 10
    IL_0152: ldloca.s 10
    IL_0157: ldfld 0x0A000023
    IL_015C: stfld 0x04000B35
    IL_015D: ldarg.0
    IL_015E: ldarg.0
    IL_0163: ldfld 0x04000B38
    IL_0168: call 0x0A0000AA
    IL_0169: ldarg.0
    IL_016E: ldfld 0x04000B35
    IL_016F: ldarg.0
    IL_0174: ldfld 0x04000B36
    IL_0175: IL_59
    IL_017A: call 0x0A000083
    IL_017B: IL_22
    IL_017C: nop
    IL_017D: nop
    IL_0182: ldc.i4 14297156
    IL_0183: nop
    IL_0184: stloc.0
    IL_0185: conv.i2
    IL_0186: add
    IL_018B: call 0x0A000083
    IL_0190: call 0x0A0000AB
    IL_0195: stfld 0x04000B37
    IL_0196: ldarg.0
    IL_019B: ldfld 0x04000B3B
    IL_019C: IL_22
    IL_019D: nop
    IL_019E: nop
    IL_019F: IL_94
    IL_01A0: IL_42
    IL_01A1: IL_59
    IL_01A2: ldarg.0
    IL_01A7: ldfld 0x04000B3C
    IL_01A8: IL_22
    IL_01A9: nop
    IL_01AA: nop
    IL_01AF: call 0x00225942
    IL_01B0: nop
    IL_01B1: IL_83
    IL_01B2: IL_43
    IL_01B3: IL_22
    IL_01B4: nop
    IL_01B5: nop
    IL_01BA: cpobj 0x021D2843
    IL_01BB: nop
    IL_01BC: ldloc.0
    IL_01C1: ldsfld 0x0A000099
    IL_01C6: ldstr 0x70022A46
    IL_01CB: call 0x0A0000E2
    IL_01D0: call 0x0A0001BA
    IL_01D1: ldarg.0
    IL_01D6: ldfld 0x04000B3B
    IL_01D7: IL_22
    IL_01D8: nop
    IL_01D9: nop
    IL_01DA: ldind.ref
    IL_01DB: IL_42
    IL_01DC: IL_59
    IL_01DD: ldarg.0
    IL_01E2: ldfld 0x04000B3C
    IL_01E3: IL_22
    IL_01E4: nop
    IL_01E5: nop
    IL_01E6: IL_94
    IL_01E7: IL_42
    IL_01E8: IL_59
    IL_01E9: IL_22
    IL_01EA: nop
    IL_01EB: nop
    IL_01EC: IL_C0
    IL_01ED: IL_42
    IL_01EE: IL_22
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: nop
    IL_01F2: IL_42
    IL_01F7: call 0x0600021D
    IL_01FC: ldsfld 0x0A000099
    IL_0201: ldstr 0x70022A6C
    IL_0206: call 0x0A0000E2
    IL_020B: call 0x0A0001BA
    IL_020C: ldarg.0
    IL_0211: ldfld 0x04000B3B
    IL_0212: IL_22
    IL_0213: nop
    IL_0214: nop
    IL_0215: ldind.ref
    IL_0216: IL_42
    IL_0217: IL_59
    IL_0218: ldarg.0
    IL_021D: ldfld 0x04000B3C
    IL_021E: IL_22
    IL_021F: nop
    IL_0220: nop
    IL_0221: IL_94
    IL_0222: IL_42
    IL_0223: IL_59
    IL_0224: IL_22
    IL_0225: nop
    IL_0226: nop
    IL_0227: IL_C0
    IL_0228: IL_42
    IL_0229: IL_22
    IL_022A: nop
    IL_022B: nop
    IL_022C: nop
    IL_022D: IL_42
    IL_0232: call 0x0600021D
    IL_0237: ldsfld 0x0A000099
    IL_0238: ldarg.0
    IL_023D: ldfld 0x04000B2E
    IL_0242: call 0x0A0000F1
    IL_0247: brfalse IL_0260
    IL_0248: ldarg.0
    IL_0249: ldc.i4.0
    IL_024E: stfld 0x04000B44
    IL_024F: ldarg.0
    IL_0254: ldfld 0x04000B3E
    IL_0259: brtrue IL_0260
    IL_025A: ldarg.0
    IL_025F: call 0x060005FE
    IL_0260: ldarg.0
    IL_0265: ldfld 0x04000B44
    IL_026A: brtrue IL_0444
    IL_026B: ldarg.0
    IL_026C: ldarg.0
    IL_0271: ldfld 0x04000B3B
    IL_0272: IL_22
    IL_0273: nop
    IL_0274: nop
    IL_0275: IL_94
    IL_0276: IL_42
    IL_0277: IL_59
    IL_0278: ldarg.0
    IL_027D: ldfld 0x04000B3C
    IL_027E: IL_22
    IL_027F: nop
    IL_0280: nop
    IL_0285: ldtoken 0x00225941
    IL_0286: nop
    IL_0287: IL_81
    IL_0288: IL_43
    IL_0289: IL_22
    IL_028A: nop
    IL_028B: nop
    IL_028C: IL_5A
    IL_028D: IL_43
    IL_0292: call 0x0600021D
    IL_0293: ldarg.0
    IL_0298: ldfld 0x04000B37
    IL_0299: IL_22
    IL_029A: nop
    IL_029B: nop
    IL_029C: nop
    IL_029D: nop
    IL_029E: IL_22
    IL_029F: nop
    IL_02A0: nop
    IL_02A1: nop
    IL_02A2: nop
    IL_02A3: IL_22
    IL_02A4: nop
    IL_02A5: nop
    IL_02AA: ldstr 0x247B0243
    IL_02AB: stloc.1
    IL_02AC: nop
    IL_02AD: ldarg.2
    IL_02AF: ldc.i4.s 44
    IL_02B0: IL_5A
    IL_02B1: conv.i2
    IL_02B6: call 0x0600021D
    IL_02BB: call 0x0A000201
    IL_02C0: stfld 0x04000B37
    IL_02C1: ldc.i4.0
    IL_02C2: stloc.0
    IL_02C7: br IL_03FC
    IL_02C8: ldarg.0
    IL_02CD: ldflda 0x04000B37
    IL_02D2: ldfld 0x0A00005A
    IL_02D3: ldloc.0
    IL_02D5: ldc.i4.s 88
    IL_02D6: IL_5A
    IL_02D7: conv.i2
    IL_02D8: IL_59
    IL_02D9: IL_22
    IL_02DA: nop
    IL_02DB: nop
    IL_02DC: ldelem.r8
    IL_02DD: IL_42
    IL_02DE: IL_3D
    IL_02DF: ldc.i4.5
    IL_02E0: nop
    IL_02E1: nop
    IL_02E2: nop
    IL_02E3: ldarg.0
    IL_02E8: ldflda 0x04000B37
    IL_02ED: ldfld 0x0A00005A
    IL_02EE: ldloc.0
    IL_02F0: ldc.i4.s 88
    IL_02F1: IL_5A
    IL_02F2: conv.i2
    IL_02F3: IL_59
    IL_02F4: IL_22
    IL_02F5: nop
    IL_02F6: nop
    IL_02F7: IL_DB
    IL_02F8: IL_C3
    IL_02F9: IL_41
    IL_02FA: ldarg.3
    IL_02FB: nop
    IL_02FC: nop
    IL_02FD: nop
    IL_0302: br IL_03F7
    IL_0303: IL_22
    IL_0304: nop
    IL_0305: nop
    IL_B07C1C0E: switch (740230721 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: stfld 0x04000B56
    IL_0008: ldarg.0
    IL_000A: ldc.i4.s 100
    IL_000F: stfld 0x04000B57
    IL_0010: ldarg.0
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_C8
    IL_0015: IL_42
    IL_001A: stfld 0x04000B58
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_C8
    IL_0020: IL_42
    IL_0025: stfld 0x04000B59
    IL_0026: ldarg.0
    IL_0027: ldc.i4.1
    IL_002C: stfld 0x04000B5B
    IL_002D: ldarg.0
    IL_002E: ldc.i4.1
    IL_0033: stfld 0x04000B63
    IL_0034: ldarg.0
    IL_0035: ldc.i4.2
    IL_003A: newarr 0x01000003
    IL_003F: stfld 0x04000B70
    IL_0040: ldarg.0
    IL_0041: ldc.i4.3
    IL_0046: newarr 0x0100003C
    IL_004B: stfld 0x04000B71
    IL_004C: ldarg.0
    IL_004D: ldc.i4.m1
    IL_0052: stfld 0x04000B8C
    IL_0053: ldarg.0
    IL_0054: ldc.i4.m1
    IL_0059: stfld 0x04000B9B
    IL_005A: ldarg.0
    IL_005B: ldc.i4.1
    IL_0060: stfld 0x04000BAE
    IL_0061: ldarg.0
    IL_0066: call 0x0A000001
    IL_0067: ret
    }

    private void OnApplicationPause() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0007
    IL_0006: ret
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BA5
    IL_000D: ldnull
    IL_0012: call 0x0A000021
    IL_0017: brfalse IL_0033
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000B72
    IL_001E: conv.r8
    IL_001F: stloc.0
    IL_0020: nop
    IL_0021: nop
    IL_0022: stloc.0
    IL_0023: conv.r8
    IL_0024: IL_CA
    IL_0025: IL_01
    IL_0026: nop
    IL_0027: stloc.0
    IL_002C: brtrue IL_0033
    IL_002D: ldarg.0
    IL_0032: call 0x06000626
    IL_0033: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700004DD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000B99
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000DDD
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000B5B
    IL_0020: ldarg.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000B5B
    IL_002B: stfld 0x04000B80
    IL_002C: ldarg.0
    IL_0031: ldstr 0x70000DE5
    IL_0036: call 0x06000220
    IL_0037: conv.i2
    IL_003C: stfld 0x04000B5A
    IL_003D: ldarg.0
    IL_0042: ldstr 0x70023585
    IL_0047: call 0x0A000095
    IL_004C: stfld 0x04000BA0
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000B72
    IL_0054: conv.r8
    IL_0059: stsfld 0x7D2B0000
    IL_005E: castclass 0x0204000B
    IL_0063: ldstr 0x70000001
    IL_0068: call 0x0A000004
    IL_0069: conv.r8
    IL_006A: ldarg.3
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_0072: stfld 0x04000B7E
    IL_0073: ldarg.0
    IL_0074: ldarg.0
    IL_0079: ldfld 0x04000B7E
    IL_007A: conv.r8
    IL_007B: stloc.2
    IL_007C: nop
    IL_007D: nop
    IL_007F: br.s IL_00FD
    IL_0084: stelem 0x0204000B
    IL_0089: ldstr 0x70000311
    IL_008E: call 0x0A000004
    IL_008F: conv.r8
    IL_0094: ldc.i4 2099970048
    IL_0099: isinst 0x0204000B
    IL_009E: ldstr 0x70000063
    IL_00A3: call 0x0A000004
    IL_00A4: conv.r8
    IL_00A5: ldarg.0
    IL_00A6: nop
    IL_00A7: nop
    IL_00A9: br.s IL_0127
    IL_00AA: IL_A4
    IL_00AB: stloc.1
    IL_00AC: nop
    IL_00AD: ldarg.2
    IL_00AE: ldarg.0
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000B6C
    IL_00B5: conv.r8
    IL_00B6: IL_37
    IL_00B7: nop
    IL_00B8: nop
    IL_00BA: br.s IL_0138
    IL_00BB: stelem.i
    IL_00BC: stloc.1
    IL_00BD: nop
    IL_00BE: ldarg.2
    IL_00BF: ldarg.0
    IL_00C0: ldarg.0
    IL_00C5: ldfld 0x04000BA4
    IL_00CA: ldfld 0x0400095D
    IL_00CF: stfld 0x04000B61
    IL_00D0: ldarg.0
    IL_00D1: ldarg.0
    IL_00D6: ldfld 0x04000BA4
    IL_00DB: ldfld 0x0400093E
    IL_00E0: stfld 0x04000B97
    IL_00E1: ldarg.0
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x04000B5B
    IL_00E8: conv.i2
    IL_00E9: IL_22
    IL_00EE: isinst 0x5A3B449B
    IL_00EF: IL_22
    IL_00F0: IL_CD
    IL_00F1: IL_CC
    IL_00F2: IL_4C
    IL_00F3: IL_3D
    IL_00F4: IL_58
    IL_00F9: stfld 0x04000B6B
    IL_00FA: ldarg.0
    IL_00FF: ldstr 0x70000BDB
    IL_0104: call 0x06000220
    IL_0109: stfld 0x04000B90
    IL_010A: ldarg.0
    IL_010F: ldstr 0x70001ED5
    IL_0114: call 0x06000220
    IL_0119: stfld 0x04000B8D
    IL_011E: ldstr 0x70001655
    IL_0123: call 0x0A000012
    IL_0124: conv.u8
    IL_0125: ldloc.0
    IL_0126: nop
    IL_0127: nop
    IL_0128: IL_01
    IL_0129: stloc.0
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000B61
    IL_0134: brfalse IL_0408
    IL_0135: ldarg.0
    IL_013A: ldstr 0x70022DD9
    IL_013F: call 0x06000220
    IL_0144: stfld 0x04000B94
    IL_0145: ldloc.0
    IL_0146: conv.r8
    IL_0147: ldarg.3
    IL_0148: nop
    IL_0149: nop
    IL_014A: stloc.0
    IL_014B: ldloc.0
    IL_014C: conv.r8
    IL_014D: ldarg.3
    IL_014E: nop
    IL_014F: nop
    IL_0150: stloc.0
    IL_0151: conv.r8
    IL_0152: add
    IL_0153: nop
    IL_0154: nop
    IL_0155: stloc.0
    IL_0156: IL_22
    IL_0157: IL_8F
    IL_0158: IL_C2
    IL_0159: IL_F5
    IL_015A: IL_3C
    IL_015B: IL_22
    IL_015C: stloc.0
    IL_015D: IL_D7
    IL_015E: stelem.i
    IL_015F: IL_BC
    IL_0160: IL_22
    IL_0161: nop
    IL_0162: nop
    IL_0163: nop
    IL_0164: nop
    IL_0169: newobj 0x0A000076
    IL_016E: call 0x0A000029
    IL_0173: call 0x0A000013
    IL_0178: call 0x0A000014
    IL_0179: conv.u4
    IL_017A: ldarg.1
    IL_017B: nop
    IL_017C: nop
    IL_017D: IL_01
    IL_017E: stloc.1
    IL_017F: ldarg.0
    IL_0180: ldloc.1
    IL_0181: conv.r8
    IL_0182: IL_24
    IL_0183: nop
    IL_0184: nop
    IL_0186: br.s IL_0204
    IL_018B: ldfld 0x0204000B
    IL_0190: ldfld 0x04000B7B
    IL_0191: IL_22
    IL_0192: IL_8F
    IL_0193: IL_C2
    IL_0194: IL_F5
    IL_0195: IL_3C
    IL_0196: conv.r8
    IL_0197: IL_B2
    IL_0198: IL_01
    IL_0199: nop
    IL_019A: stloc.0
    IL_019B: ldarg.0
    IL_01A0: ldfld 0x04000B7B
    IL_01A1: ldarg.0
    IL_01A6: ldflda 0x04000B94
    IL_01AB: call 0x0A000010
    IL_01AC: conv.r8
    IL_01AD: IL_FD
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: stloc.0
    IL_01B5: ldstr 0x70023599
    IL_01BA: call 0x0A000012
    IL_01BB: conv.u8
    IL_01BC: ldloc.0
    IL_01BD: nop
    IL_01BE: nop
    IL_01BF: IL_01
    IL_01C0: stloc.2
    IL_01C1: ldarg.0
    IL_01C2: ldloc.2
    IL_01C3: conv.r8
    IL_01C4: ldarg.3
    IL_01C5: nop
    IL_01C6: nop
    IL_01C7: stloc.0
    IL_01C8: ldloc.2
    IL_01C9: conv.r8
    IL_01CA: ldarg.3
    IL_01CB: nop
    IL_01CC: nop
    IL_01CD: stloc.0
    IL_01CE: conv.r8
    IL_01CF: add
    IL_01D0: nop
    IL_01D1: nop
    IL_01D2: stloc.0
    IL_01D7: call 0x0A000013
    IL_01DC: call 0x0A000014
    IL_01DD: conv.u4
    IL_01DE: ldarg.1
    IL_01DF: nop
    IL_01E0: nop
    IL_01E1: IL_01
    IL_01E6: stfld 0x04000B7C
    IL_01E7: ldarg.0
    IL_01E8: ldc.i4.0
    IL_01ED: stfld 0x04000B8D
    IL_01EE: ldarg.0
    IL_01F3: ldfld 0x04000BA3
    IL_01F4: IL_22
    IL_01F5: IL_EC
    IL_01F6: IL_51
    IL_01FB: br IL_-28F5DBC5
    IL_01FC: IL_23
    IL_01FD: IL_3E
    IL_0202: newobj 0x0A000038
    IL_0203: IL_22
    IL_0204: nop
    IL_0205: nop
    IL_0206: nop
    IL_0207: nop
    IL_0208: IL_22
    IL_0209: shr
    IL_020A: shr
    IL_020B: shr
    IL_020C: IL_3F
    IL_020D: IL_22
    IL_020E: stloc.0
    IL_020F: IL_D7
    IL_0211: bne.un.s IL_0252
    IL_0212: IL_22
    IL_0213: shr
    IL_0214: shr
    IL_0215: ldloc.0
    IL_1DBE6: switch (30323 cases)
    }

    public void SkillPlus() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BA6
    IL_0006: ldarg.1
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B89
    IL_000D: conv.r8
    IL_0012: beq IL_26060016
    IL_0013: ret
    }

    public void ResetTime() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B7B
    IL_0006: ldarg.0
    IL_000B: ldflda 0x04000B94
    IL_0010: call 0x0A000010
    IL_0011: conv.r8
    IL_0012: IL_FD
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: stfld 0x04000B88
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0027: stfld 0x04000B81
    IL_0028: ldarg.0
    IL_002D: ldstr 0x700235C7
    IL_002E: IL_22
    IL_002F: IL_CD
    IL_0030: IL_CC
    IL_0031: IL_CC
    IL_0032: IL_3D
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_003A: stsfld 0x0017283F
    IL_003B: nop
    IL_003C: stloc.0
    IL_003D: ldarg.0
    IL_003E: ldc.i4.1
    IL_0043: stfld 0x04000BAE
    IL_0044: ret
    }

    private void CountDown() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B88
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_000D: cpobj 0x0A695B42
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000B88
    IL_0014: not
    IL_0016: ldc.i4.s 60
    IL_0017: mul
    IL_0018: stloc.1
    IL_001D: ldstr 0x7002369F
    IL_001E: stloc.2
    IL_001F: ldloc.1
    IL_0021: ldc.i4.s 10
    IL_0022: IL_3C
    IL_0023: ldloc.0
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_002B: ldstr 0x700236A7
    IL_002C: stloc.2
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000B79
    IL_0033: ldloc.0
    IL_0038: newobj 0x0100000B
    IL_0039: ldloc.2
    IL_003A: ldloc.1
    IL_003F: newobj 0x0100000B
    IL_0044: call 0x0A000098
    IL_0045: conv.r8
    IL_0046: IL_FD
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004A: ret
    }

    public void SoulStartplus() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.5
    IL_0006: stfld 0x04000B63
    IL_0007: ret
    }

    public void CallGeneral() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B8C
    IL_0006: ldc.i4.0
    IL_0007: IL_3C
    IL_0008: ldarg.0
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldc.i4.0
    IL_000D: ret
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000BA2
    IL_0018: ldfld 0x04000352
    IL_001D: brfalse IL_0029
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000B8A
    IL_0028: brfalse IL_002B
    IL_0029: ldc.i4.0
    IL_002A: ret
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000B58
    IL_0031: IL_22
    IL_0032: nop
    IL_0033: nop
    IL_0038: ldc.i4 11748417
    IL_0039: nop
    IL_003A: nop
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000B89
    IL_0045: brtrue IL_0076
    IL_0046: ldarg.0
    IL_0047: ldc.i4.1
    IL_004C: stfld 0x04000B89
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000BA6
    IL_0053: ldc.i4.1
    IL_0054: conv.r8
    IL_0055: IL_42
    IL_0056: ldarg.1
    IL_0057: nop
    IL_0058: ldloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000BA6
    IL_005F: ldc.i4.1
    IL_0060: conv.r8
    IL_0061: IL_43
    IL_0062: ldarg.1
    IL_0063: nop
    IL_0064: ldloc.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000BA6
    IL_006B: ldc.i4.1
    IL_006C: conv.r8
    IL_006F: ldarg 3
    IL_0070: ldloc.0
    IL_0075: br IL_00A1
    IL_0076: ldarg.0
    IL_0077: ldc.i4.0
    IL_007C: stfld 0x04000B89
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000BA6
    IL_0083: ldc.i4.0
    IL_0084: conv.r8
    IL_0085: IL_42
    IL_0086: ldarg.1
    IL_0087: nop
    IL_0088: ldloc.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000BA6
    IL_008F: ldc.i4.0
    IL_0090: conv.r8
    IL_0091: IL_43
    IL_0092: ldarg.1
    IL_0093: nop
    IL_0094: ldloc.0
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000BA6
    IL_009B: ldc.i4.0
    IL_009C: conv.r8
    IL_009F: ldarg 3
    IL_00A0: ldloc.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000B77
    IL_00AB: call 0x0A00004B
    IL_00B0: call 0x0A000043
    IL_00B1: conv.r8
    IL_00B2: IL_AF
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: stloc.0
    IL_00B6: ldarg.0
    IL_00B7: ldc.i4.1
    IL_00BC: stfld 0x04000B8B
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x04000BA4
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000B89
    IL_00C9: ldarg.0
    IL_00CE: ldfld 0x04000B57
    IL_00CF: ldarg.0
    IL_00D4: ldfld 0x04000B56
    IL_00D5: conv.r8
    IL_00D6: IL_F7
    IL_00D7: ldarg.2
    IL_00D8: nop
    IL_00D9: ldloc.0
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000BA2
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000B89
    IL_00E6: ldarg.1
    IL_00E7: conv.r8
    IL_00EC: ldobj 0x17060001
    IL_00ED: ret
    IL_00EE: ldc.i4.0
    IL_00EF: ret
    }

    public void GeneralDead() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000B89
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_000D: stfld 0x04000B8A
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000BA6
    IL_0014: ldc.i4.0
    IL_0015: conv.r8
    IL_0016: IL_42
    IL_0017: ldarg.1
    IL_0018: nop
    IL_0019: ldloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000BA6
    IL_0020: ldc.i4.0
    IL_0021: conv.r8
    IL_0022: IL_43
    IL_0023: ldarg.1
    IL_0024: nop
    IL_0025: ldloc.0
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000BA6
    IL_002C: ldc.i4.0
    IL_002D: conv.r8
    IL_0030: ldarg 3
    IL_0031: ldloc.0
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000BA6
    IL_0038: conv.r8
    IL_0039: IL_44
    IL_003A: ldarg.1
    IL_003B: nop
    IL_003C: ldloc.0
    IL_003D: ret
    }

    public void WaveSet() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000BA4
    IL_000B: ldfld 0x0400094F
    IL_0010: stfld 0x04000B95
    IL_0011: ldarg.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BA4
    IL_001C: ldfld 0x04000950
    IL_0021: stfld 0x04000B96
    IL_0022: ldarg.0
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000BA2
    IL_002D: ldfld 0x04000354
    IL_0032: stfld 0x04000B98
    IL_0037: ldstr 0x70002031
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000B95
    IL_0042: call 0x0600021F
    IL_0047: ldstr 0x70002045
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000B96
    IL_0052: call 0x0600021F
    IL_0057: ldstr 0x70000EC9
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000B98
    IL_0062: call 0x0600021F
    IL_0067: ldstr 0x70023257
    IL_0068: ldarg.0
    IL_006D: ldfld 0x04000B69
    IL_0072: call 0x0600021F
    IL_0077: ldstr 0x7002325F
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000B68
    IL_0082: call 0x0600021F
    IL_0087: ldstr 0x70000DDD
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04000B5B
    IL_0092: call 0x0600021F
    IL_0097: ldstr 0x7000052B
    IL_0098: ldc.i4.1
    IL_009D: call 0x0A00009F
    IL_00A2: ldstr 0x70000DE5
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04000B5A
    IL_00A9: not
    IL_00AE: call 0x0600021F
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000BA6
    IL_00B5: conv.r8
    IL_00B6: IL_41
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: ldloc.0
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000BA4
    IL_00C0: ldc.i4.0
    IL_00C1: conv.r8
    IL_00C2: ldarg.2
    IL_00C3: ldarg.3
    IL_00C4: nop
    IL_00C5: ldloc.0
    IL_00C6: ldarg.1
    IL_00C7: ldc.i4.m1
    IL_0310: switch (145 cases)
    IL_0311: ldarg.3
    IL_0316: call 0x060003F8
    IL_0317: pop
    IL_0318: ldarg.0
    IL_0319: ldc.i4.0
    IL_031E: stfld 0x04000BA1
    IL_031F: ldarg.0
    IL_0320: ldc.i4.0
    IL_0325: stfld 0x04000B9D
    IL_0326: ldarg.0
    IL_0327: ldarg.1
    IL_0328: ldc.i4.1
    IL_0329: IL_58
    IL_032E: stfld 0x04000B94
    IL_0333: ldstr 0x70023247
    IL_0338: call 0x06000220
    IL_033A: stloc.s 6
    IL_033B: ldarg.0
    IL_0340: ldfld 0x04000B94
    IL_0342: ldloc.s 6
    IL_0343: IL_3E
    IL_0344: IL_4E
    IL_0345: nop
    IL_0346: nop
    IL_0347: nop
    IL_0348: ldarg.0
    IL_034D: ldfld 0x04000B94
    IL_034E: ldc.i4.1
    IL_034F: IL_59
    IL_0350: ldc.i4.8
    IL_0351: mul
    IL_0356: brtrue IL_037F
    IL_0357: ldarg.0
    IL_035C: ldfld 0x04000B94
    IL_035D: ldc.i4.1
    IL_0362: beq IL_037A
    IL_0363: ldarg.0
    IL_0364: ldc.i4.1
    IL_0369: stfld 0x04000B8E
    IL_036A: ldarg.0
    IL_036B: ldarg.0
    IL_0370: ldfld 0x04000B94
    IL_0371: ldc.i4.1
    IL_0372: IL_59
    IL_0373: ldc.i4.8
    IL_0374: add
    IL_0379: stfld 0x04000B8F
    IL_037E: br IL_0386
    IL_037F: ldarg.0
    IL_0380: ldc.i4.0
    IL_0385: stfld 0x04000B8E
    IL_038A: ldstr 0x70023247
    IL_038B: ldarg.0
    IL_0390: ldfld 0x04000B94
    IL_0395: call 0x0600021F
    IL_0396: ldarg.0
    IL_0397: ldc.i4.0
    IL_039C: call 0x06000619
    IL_039D: ldarg.0
    IL_03A2: ldstr 0x700235C7
    IL_03A7: call 0x0A00007B
    IL_03A8: ldarg.0
    IL_03A9: ldc.i4.0
    IL_03AE: stfld 0x04000BAE
    IL_03AF: ldarg.0
    IL_03B0: ldarg.0
    IL_03B5: call 0x0600061C
    IL_03BA: call 0x0A000047
    IL_03BB: pop
    IL_03BC: ret
    }

    public void GetAngel() {
    IL_0004: ldstr 0x700236C9
    IL_0005: ldarg.0
    IL_000A: ldflda 0x04000B8F
    IL_000F: call 0x0A000010
    IL_0014: call 0x0A000011
    IL_0019: call 0x0A000012
    IL_001A: conv.u8
    IL_001B: IL_01
    IL_001C: nop
    IL_001D: nop
    IL_001E: IL_01
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000B6F
    IL_0026: conv.r8
    IL_0027: stloc.3
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: conv.r8
    IL_002D: ldarg.s 0
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldloc.0
    IL_0031: conv.r8
    IL_0033: ldarga.s 0
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000B6F
    IL_003C: conv.r8
    IL_003D: stloc.0
    IL_003E: nop
    IL_003F: nop
    IL_0040: stloc.0
    IL_0041: ldc.i4.1
    IL_0042: conv.r8
    IL_0043: stloc.1
    IL_0044: nop
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000B6F
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldelem.r8
    IL_3000000E2: switch (3221225506 cases)
    }

    private void GetAngel_GUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B72
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000BA5
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000B8F
    IL_001D: conv.r8
    IL_001F: blt.s IL_0026
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ret
    }

    public void ComboPlus() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B93
    IL_000A: brtrue IL_00E4
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000B87
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_3F
    IL_0016: IL_41
    IL_0017: IL_C9
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x04000B87
    IL_0022: ldarg.1
    IL_0023: IL_58
    IL_0028: stfld 0x04000B87
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000BAD
    IL_0033: call 0x0A000082
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000B87
    IL_003A: shl
    IL_003F: call 0x0A000083
    IL_0040: conv.r8
    IL_0041: IL_F3
    IL_0042: ldarg.0
    IL_0043: nop
    IL_0044: ldloc.0
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000B87
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_3F
    IL_0050: IL_44
    IL_0051: IL_8F
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldarg.0
    IL_0056: ldc.i4.1
    IL_005B: stfld 0x04000B93
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000B73
    IL_0062: conv.r8
    IL_0063: stloc.0
    IL_0064: nop
    IL_0065: nop
    IL_0066: stloc.0
    IL_0067: ldc.i4.1
    IL_0068: conv.r8
    IL_0069: stloc.1
    IL_006A: nop
    IL_006B: nop
    IL_006C: stloc.0
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000B73
    IL_0073: ldc.i4.0
    IL_0074: conv.r8
    IL_0079: brtrue IL_6F0A007A
    IL_007A: stloc.0
    IL_007B: nop
    IL_007C: nop
    IL_007D: stloc.0
    IL_007E: ldc.i4.1
    IL_007F: conv.r8
    IL_0080: stloc.1
    IL_0081: nop
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000B7F
    IL_008E: call 0x0A000007
    IL_008F: IL_22
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldelem.r8
    IL_2137: switch (2088 cases)
    }

    public void SuperModeOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B70
    IL_0006: ldc.i4.0
    IL_0007: ldelem.i
    IL_0008: conv.r8
    IL_0009: stloc.0
    IL_000A: nop
    IL_000B: nop
    IL_000C: stloc.0
    IL_000D: ldc.i4.1
    IL_000E: conv.r8
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000B70
    IL_0019: ldc.i4.1
    IL_001A: ldelem.i
    IL_001B: conv.r8
    IL_001C: stloc.0
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ldc.i4.1
    IL_0021: conv.r8
    IL_0022: stloc.1
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ldarg.0
    IL_0027: ldc.i4.0
    IL_002C: stfld 0x04000B93
    IL_002D: ldarg.0
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0037: stfld 0x04000B87
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000BAD
    IL_0042: call 0x0A000082
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000B87
    IL_0049: shl
    IL_004E: call 0x0A000083
    IL_004F: conv.r8
    IL_0050: IL_F3
    IL_0051: ldarg.0
    IL_0052: nop
    IL_0053: ldloc.0
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000B73
    IL_005A: conv.r8
    IL_005B: stloc.0
    IL_005C: nop
    IL_005D: nop
    IL_005E: stloc.0
    IL_005F: ldc.i4.0
    IL_0060: conv.r8
    IL_0061: stloc.1
    IL_0062: nop
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000B73
    IL_006B: ldc.i4.0
    IL_006C: conv.r8
    IL_0071: brtrue IL_6F0A0072
    IL_0072: stloc.0
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: ldc.i4.1
    IL_0077: conv.r8
    IL_0078: stloc.1
    IL_0079: nop
    IL_007A: nop
    IL_007B: stloc.0
    IL_007C: ret
    }

    public void GetCoin() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B9C
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B94
    IL_000D: ldc.i4.4
    IL_000E: IL_5A
    IL_0010: ldc.i4.s 80
    IL_0011: IL_58
    IL_0012: conv.i2
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000B6A
    IL_0019: conv.i2
    IL_001A: IL_22
    IL_001B: IL_CD
    IL_001C: IL_CC
    IL_001D: IL_CC
    IL_001E: IL_3D
    IL_001F: IL_5A
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0x695A583F
    IL_0028: IL_58
    IL_002D: stfld 0x04000B9C
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000B9C
    IL_0034: ldc.i4.0
    IL_0039: call 0x0600021E
    IL_003A: pop
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000B7C
    IL_0041: conv.r8
    IL_0042: IL_81
    IL_0043: nop
    IL_0044: nop
    IL_0046: br.s IL_0049
    IL_004B: ldfld 0x04000B9C
    IL_004C: conv.r8
    IL_004D: div.un
    IL_004E: IL_01
    IL_004F: nop
    IL_0050: ldloc.0
    IL_0051: ret
    }

    public void GetGeneral() {
    IL_0004: ldstr 0x700236FF
    IL_0009: call 0x060003F9
    IL_000A: stloc.0
    IL_000B: ldc.i4.m1
    IL_000C: stloc.1
    IL_000D: ldc.i4.0
    IL_0012: ldc.i4 720
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000B94
    IL_001A: ldc.i4.s 12
    IL_001B: IL_5A
    IL_001C: IL_58
    IL_0021: call 0x0A000045
    IL_0022: stloc.2
    IL_0023: ldloc.2
    IL_0028: ldc.i4 990
    IL_0029: IL_3E
    IL_002A: ldloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: ldc.i4.4
    IL_002F: stloc.2
    IL_0034: br IL_006D
    IL_0035: ldloc.2
    IL_003A: ldc.i4 970
    IL_003B: IL_3E
    IL_003C: ldloc.1
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: ldc.i4.3
    IL_0041: stloc.2
    IL_0046: br IL_006D
    IL_0047: ldloc.2
    IL_004C: ldc.i4 800
    IL_004D: IL_3E
    IL_004E: ldloc.1
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: ldc.i4.2
    IL_0053: stloc.2
    IL_0058: br IL_006D
    IL_0059: ldloc.2
    IL_005E: ldc.i4 500
    IL_005F: IL_3E
    IL_0060: ldloc.1
    IL_0061: nop
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldc.i4.1
    IL_0065: stloc.2
    IL_006A: br IL_006D
    IL_006B: ldc.i4.0
    IL_006C: stloc.2
    IL_006D: ldc.i4.0
    IL_006E: stloc.3
    IL_006F: ldloc.2
    IL_0074: ldc.i4 850
    IL_0075: IL_3E
    IL_0076: ldloc.1
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldc.i4.3
    IL_007B: stloc.3
    IL_0080: br IL_0095
    IL_0081: ldloc.2
    IL_0086: ldc.i4 600
    IL_0087: IL_3E
    IL_0088: ldloc.1
    IL_0089: nop
    IL_008A: nop
    IL_008B: nop
    IL_008C: ldc.i4.2
    IL_008D: stloc.3
    IL_0092: br IL_0095
    IL_0093: ldc.i4.1
    IL_0094: stloc.3
    IL_0095: ldc.i4.0
    IL_0097: ldc.i4.s 90
    IL_009C: call 0x0A000045
    IL_009E: stloc.s 4
    IL_009F: ldloc.2
    IL_00A0: ldc.i4.2
    IL_00A1: IL_3F
    IL_00A2: stloc.2
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_00A7: ldloc.s 4
    IL_00A9: ldc.i4.s 20
    IL_00AA: mul
    IL_00AC: stloc.s 4
    IL_00B1: br IL_00B9
    IL_00B3: ldloc.s 4
    IL_00B5: ldc.i4.s 30
    IL_00B6: mul
    IL_00B8: stloc.s 4
    IL_00BA: ldloc.s 4
    IL_00BF: ldc.i4 100000
    IL_00C0: IL_5A
    IL_00C2: stloc.s 4
    IL_00C3: ldc.i4.0
    IL_00C8: ldc.i4 10000
    IL_00CD: call 0x0A000045
    IL_00CE: ldloc.2
    IL_00D3: ldc.i4 10000
    IL_00D4: IL_5A
    IL_00D5: IL_58
    IL_00D6: ldloc.3
    IL_00DB: ldc.i4 10000000
    IL_00DC: IL_5A
    IL_00DD: IL_58
    IL_00DF: ldloc.s 4
    IL_00E0: IL_58
    IL_00E2: stloc.s 5
    IL_00E3: ldc.i4.0
    IL_00E5: stloc.s 6
    IL_00EA: br IL_0114
    IL_00EB: ldloc.0
    IL_00ED: ldloc.s 6
    IL_00EE: IL_94
    IL_00F3: brtrue IL_010E
    IL_00F5: ldloc.s 6
    IL_00F6: stloc.1
    IL_00F7: ldloc.0
    IL_00F9: ldloc.s 6
    IL_00FB: ldloc.s 5
    IL_00FC: ldelem.i8
    IL_0101: ldstr 0x700236FF
    IL_0102: ldloc.0
    IL_0107: call 0x060003F8
    IL_0108: pop
    IL_010D: br IL_011D
    IL_010F: ldloc.s 6
    IL_0110: ldc.i4.1
    IL_0111: IL_58
    IL_0113: stloc.s 6
    IL_0115: ldloc.s 6
    IL_0117: ldc.i4.s 50
    IL_0118: IL_3F
    IL_0119: IL_CE
    IL_011A: IL_FF
    IL_011B: IL_FF
    IL_011C: IL_FF
    IL_011D: ldarg.0
    IL_0122: ldfld 0x04000B6F
    IL_0123: conv.r8
    IL_0124: stloc.3
    IL_0125: nop
    IL_0126: nop
    IL_0127: stloc.0
    IL_0128: conv.r8
    IL_012A: ldarg.s 0
    IL_012B: nop
    IL_012C: stloc.0
    IL_012D: ldarg.0
    IL_0132: ldfld 0x04000B71
    IL_0133: ldloc.3
    IL_0134: ldc.i4.1
    IL_0135: IL_59
    IL_0136: ldelem.i
    IL_0137: conv.r8
    IL_0139: ldarga.s 0
    IL_013A: nop
    IL_013B: stloc.0
    IL_013C: ldarg.0
    IL_0141: ldfld 0x04000B6F
    IL_0142: conv.r8
    IL_0143: stloc.0
    IL_0144: nop
    IL_0145: nop
    IL_0146: stloc.0
    IL_0147: ldc.i4.1
    IL_0148: conv.r8
    IL_0149: stloc.1
    IL_014A: nop
    IL_014B: nop
    IL_014C: stloc.0
    IL_014D: ldarg.0
    IL_0152: ldfld 0x04000B6F
    IL_0153: IL_22
    IL_0154: nop
    IL_0155: nop
    IL_0156: nop
    IL_0157: nop
    IL_0158: IL_22
    IL_0159: nop
    IL_015A: nop
    IL_015B: ldelem.r8
    IL_3000001E8: switch (3221225506 cases)
    }

    public void IntermissionOff() {
    IL_0004: call 0x0A000303
    IL_0005: ldarg.0
    IL_000A: ldfld 0x04000BA4
    IL_000B: conv.r8
    IL_000C: IL_F5
    IL_000D: ldarg.2
    IL_000E: nop
    IL_000F: ldloc.0
    IL_0010: ret
    }

    public void ResetExtreme() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B7D
    IL_0006: conv.r8
    IL_0007: ldarg.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000F: call 0x0A000007
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0x00082842
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: conv.r8
    IL_001B: ldloc.3
    IL_001C: nop
    IL_001D: nop
    IL_001E: stloc.0
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000B7D
    IL_0025: conv.r8
    IL_0026: stloc.0
    IL_0027: nop
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: ldc.i4.0
    IL_002B: conv.r8
    IL_002C: stloc.1
    IL_002D: nop
    IL_002E: nop
    IL_002F: stloc.0
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000BAC
    IL_003A: call 0x0A000057
    IL_003B: conv.r8
    IL_003C: IL_F3
    IL_003D: ldarg.0
    IL_003E: nop
    IL_003F: ldloc.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000BA6
    IL_0046: conv.r8
    IL_0047: IL_35
    IL_0048: ldarg.1
    IL_0049: nop
    IL_004A: ldloc.0
    IL_004B: ret
    }

    public void ShowTxt() {
    IL_0004: call 0x0A0000AA
    IL_0005: IL_22
    IL_0006: nop
    IL_0007: nop
    IL_0008: nop
    IL_0009: IL_3F
    IL_000E: call 0x0A000083
    IL_0013: call 0x0A0000AA
    IL_0014: ldarg.1
    IL_0015: conv.i2
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_001D: stsfld 0x83285A3E
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: call 0x0A0000AB
    IL_0026: stloc.0
    IL_0027: ldarg.1
    IL_002C: brtrue IL_00EA
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000B75
    IL_0033: conv.r8
    IL_0034: stloc.0
    IL_0035: nop
    IL_0036: nop
    IL_0037: stloc.0
    IL_0038: ldc.i4.1
    IL_0039: conv.r8
    IL_003A: stloc.1
    IL_003B: nop
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000B75
    IL_0044: conv.r8
    IL_0045: IL_82
    IL_0046: nop
    IL_0047: nop
    IL_0049: br.s IL_004C
    IL_004E: ldfld 0x04000B6A
    IL_004F: conv.r8
    IL_0050: IL_D9
    IL_0051: ldarg.3
    IL_0052: nop
    IL_0053: ldloc.0
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000B94
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000B6A
    IL_0060: IL_5A
    IL_0062: ldc.i4.s 15
    IL_0063: IL_5A
    IL_0064: stloc.1
    IL_0065: ldarg.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000B67
    IL_006C: conv.i2
    IL_0071: stfld 0x04000BAF
    IL_0072: ldarg.0
    IL_0073: dup
    IL_0078: ldfld 0x04000B67
    IL_0079: ldloc.1
    IL_007A: IL_58
    IL_007F: stfld 0x04000B67
    IL_0080: ldarg.0
    IL_0085: ldstr 0x70023707
    IL_0086: IL_22
    IL_0087: nop
    IL_0088: nop
    IL_0089: nop
    IL_008A: IL_3F
    IL_008B: IL_22
    IL_008C: IL_CD
    IL_008D: IL_CC
    IL_008E: IL_4C
    IL_008F: IL_3D
    IL_0094: call 0x0A000017
    IL_0099: ldstr 0x70002687
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000B7B
    IL_00A0: conv.r8
    IL_00A1: ldarg.3
    IL_00A2: ldarg.1
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A9: call 0x06000221
    IL_00AE: ldstr 0x700026AB
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000B7A
    IL_00B5: conv.r8
    IL_00B6: ldarg.3
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: stloc.0
    IL_00BE: call 0x06000221
    IL_00C3: ldstr 0x7000269B
    IL_00C4: ldarg.0
    IL_00C9: ldfld 0x04000B79
    IL_00CA: conv.r8
    IL_00CB: ldarg.3
    IL_00CC: ldarg.1
    IL_00CD: nop
    IL_00CE: stloc.0
    IL_00D3: call 0x06000221
    IL_00D8: ldstr 0x7002371B
    IL_00D9: ldc.i4.1
    IL_00DE: call 0x0A00009F
    IL_00E3: ldstr 0x7000052B
    IL_00E4: ldc.i4.1
    IL_00E9: call 0x0A00009F
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000B74
    IL_00F0: conv.r8
    IL_00F1: stloc.0
    IL_00F2: nop
    IL_00F3: nop
    IL_00F4: stloc.0
    IL_00F5: ldc.i4.1
    IL_00F6: conv.r8
    IL_00F7: stloc.1
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FB: ldarg.0
    IL_0100: ldfld 0x04000B74
    IL_0101: conv.r8
    IL_0102: IL_83
    IL_0103: nop
    IL_0104: nop
    IL_0106: br.s IL_010D
    IL_0107: conv.r8
    IL_0108: IL_D4
    IL_0109: ldarg.3
    IL_010A: nop
    IL_010B: ldloc.0
    IL_010C: ret
    }

    private void ScorePlus() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B67
    IL_0006: conv.i2
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BAF
    IL_000D: IL_59
    IL_000E: stloc.0
    IL_000F: ldloc.0
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: stsfld 0x0057433F
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04000BAF
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000B67
    IL_0027: conv.i2
    IL_002C: call 0x0A000024
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_0030: ldelem.r8
    IL_94A19D: switch (2435162 cases)
    }

    public void Stagefinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B62
    IL_0007: ret
    }

    public void WaveClear() {
    IL_0004: newobj 0x060007C9
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.0
    IL_000C: stfld 0x040010A9
    IL_000D: ldloc.0
    IL_000E: ret
    }

    public void IntermissionOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B7E
    IL_0006: conv.r8
    IL_0007: ldc.i4.2
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000B7E
    IL_0011: conv.r8
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: IL_22
    IL_0017: IL_CD
    IL_0018: IL_CC
    IL_0019: IL_4C
    IL_001A: IL_3D
    IL_001F: call 0x0A000008
    IL_0024: call 0x0A000029
    IL_0025: stloc.0
    IL_0026: ldloc.0
    IL_002B: call 0x0A000064
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_0033: stsfld 0x0011433F
    IL_0034: nop
    IL_0035: nop
    IL_0036: ldloc.0
    IL_003B: call 0x0A000040
    IL_003C: IL_22
    IL_003E: bne.un.s IL_0072
    IL_0043: newobj 0x0008283F
    IL_0044: nop
    IL_0045: stloc.0
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000B7D
    IL_004D: conv.r8
    IL_004E: stloc.0
    IL_004F: nop
    IL_0050: nop
    IL_0051: stloc.0
    IL_0052: conv.r8
    IL_0053: ldarg.3
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: ldloc.0
    IL_0058: conv.r8
    IL_0059: ldloc.3
    IL_005A: nop
    IL_005B: nop
    IL_005C: stloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000B7D
    IL_0063: conv.r8
    IL_0064: stloc.0
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ldc.i4.1
    IL_0069: conv.r8
    IL_006A: stloc.1
    IL_006B: nop
    IL_006C: nop
    IL_006D: stloc.0
    IL_006E: ret
    }

    public void LoadingFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B92
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BA2
    IL_000D: conv.r8
    IL_000E: xor
    IL_000F: IL_01
    IL_0010: nop
    IL_0011: ldloc.0
    IL_0012: ldarg.0
    IL_0013: IL_22
    IL_0014: nop
    IL_0015: nop
    IL_001A: stsfld 0x5A7B023F
    IL_001B: stloc.1
    IL_001C: nop
    IL_001D: ldarg.2
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000B5B
    IL_0025: ldc.i4.s 100
    IL_0026: IL_5A
    IL_0027: conv.i2
    IL_0028: add
    IL_0029: IL_59
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_3E
    IL_002F: IL_5A
    IL_0034: stfld 0x04000B86
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000BAA
    IL_003F: call 0x0A0000AA
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000B86
    IL_004A: call 0x0A000083
    IL_004B: conv.r8
    IL_004C: IL_F3
    IL_004D: ldarg.0
    IL_004E: nop
    IL_004F: ldloc.0
    IL_0050: ldarg.0
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0058: stsfld 0x647B023F
    IL_0059: stloc.1
    IL_005A: nop
    IL_005B: ldarg.2
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_41
    IL_0061: add
    IL_0062: IL_59
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: nop
    IL_0067: IL_3F
    IL_0068: IL_5A
    IL_006D: stfld 0x04000B85
    IL_006E: ldarg.0
    IL_0073: ldfld 0x04000B6E
    IL_0074: conv.r8
    IL_0075: IL_24
    IL_0076: nop
    IL_0077: nop
    IL_0079: br.s IL_007C
    IL_007E: ldflda 0x04000B5B
    IL_0083: call 0x0A000010
    IL_0084: conv.r8
    IL_0085: IL_FD
    IL_0086: nop
    IL_0087: nop
    IL_0088: stloc.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04000B61
    IL_0093: brtrue IL_015E
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000B76
    IL_009E: call 0x0A00004B
    IL_009F: conv.r8
    IL_00A0: IL_AF
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x04000BA9
    IL_00AE: call 0x0A000082
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04000B85
    IL_00B9: call 0x0A000083
    IL_00BA: conv.r8
    IL_00BB: IL_F3
    IL_00BC: ldarg.0
    IL_00BD: nop
    IL_00BE: ldloc.0
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x04000BA4
    IL_00C5: conv.r8
    IL_00C6: IL_FA
    IL_00C7: ldarg.2
    IL_00C8: nop
    IL_00C9: ldloc.0
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04000B9B
    IL_00D0: stloc.0
    IL_00D1: ldloc.0
    IL_00D2: ldc.i4.4
    IL_00D3: IL_58
    IL_00D6: ldarg 3
    IL_00D7: nop
    IL_00D8: nop
    IL_00DD: call 0x4B000000
    IL_00DE: nop
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: ldarg.3
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: nop
    IL_00E9: br IL_0153
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000B72
    IL_00F0: conv.r8
    IL_00F1: stloc.0
    IL_00F2: nop
    IL_00F3: nop
    IL_00F4: stloc.0
    IL_00F5: ldc.i4.1
    IL_00F6: conv.r8
    IL_00F7: stloc.1
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: stloc.0
    IL_00FB: ldarg.0
    IL_0100: ldfld 0x04000BA5
    IL_0101: ldc.i4.1
    IL_0102: ldc.i4.0
    IL_0103: conv.r8
    IL_0104: IL_36
    IL_0105: ldloc.0
    IL_0106: nop
    IL_0107: ldloc.0
    IL_010C: br IL_0153
    IL_010D: ldarg.0
    IL_0112: ldfld 0x04000B72
    IL_0113: conv.r8
    IL_0114: stloc.0
    IL_0115: nop
    IL_0116: nop
    IL_0117: stloc.0
    IL_0118: ldc.i4.1
    IL_0119: conv.r8
    IL_011A: stloc.1
    IL_011B: nop
    IL_011C: nop
    IL_011D: stloc.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x04000BA5
    IL_0124: ldc.i4.5
    IL_0125: ldc.i4.0
    IL_0126: conv.r8
    IL_0127: IL_36
    IL_0128: ldloc.0
    IL_0129: nop
    IL_012A: ldloc.0
    IL_012F: br IL_0153
    IL_0130: ldarg.0
    IL_0135: ldfld 0x04000B72
    IL_0136: conv.r8
    IL_0137: stloc.0
    IL_0138: nop
    IL_0139: nop
    IL_013A: stloc.0
    IL_013B: ldc.i4.1
    IL_013C: conv.r8
    IL_013D: stloc.1
    IL_013E: nop
    IL_013F: nop
    IL_0140: stloc.0
    IL_0141: ldarg.0
    IL_0146: ldfld 0x04000BA5
    IL_0147: ldc.i4.6
    IL_0148: ldc.i4.0
    IL_0149: conv.r8
    IL_014A: IL_36
    IL_014B: ldloc.0
    IL_014C: nop
    IL_014D: ldloc.0
    IL_0152: br IL_0153
    IL_0157: ldstr 0x70002093
    IL_0158: ldc.i4.m1
    IL_015D: call 0x0600021F
    IL_015E: ret
    }

    public void ResetPower() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000B60
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x04000B91
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BAB
    IL_001C: call 0x0A000057
    IL_001D: conv.r8
    IL_001E: IL_F3
    IL_001F: ldarg.0
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000B78
    IL_0028: conv.r8
    IL_0029: stloc.0
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.0
    IL_002E: conv.r8
    IL_002F: stloc.1
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ret
    }

    public void PowerCharge() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000B60
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000B78
    IL_000D: conv.r8
    IL_000E: stloc.0
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    public void GrabCharge() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B78
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0012: dup
    IL_0017: ldfld 0x04000B91
    IL_0018: IL_22
    IL_0019: stloc.0
    IL_001A: IL_D7
    IL_001B: stelem.i
    IL_001C: IL_3C
    IL_001D: IL_58
    IL_0022: stfld 0x04000B91
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000BAB
    IL_002D: call 0x0A000082
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000B91
    IL_0034: shl
    IL_0039: call 0x0A000083
    IL_003A: conv.r8
    IL_003B: IL_F3
    IL_003C: ldarg.0
    IL_003D: nop
    IL_003E: ldloc.0
    IL_003F: ret
    }

    public void GainCoin() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B66
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000B66
    IL_000E: ldarg.0
    IL_000F: dup
    IL_0014: ldfld 0x04000B68
    IL_0015: ldarg.1
    IL_0016: IL_58
    IL_001B: stfld 0x04000B68
    IL_001C: ldarg.1
    IL_001D: ldc.i4.0
    IL_0022: call 0x0600021E
    IL_0023: pop
    IL_0024: ret
    }

    public void GainJade() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B65
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000B65
    IL_000E: ldarg.0
    IL_000F: dup
    IL_0014: ldfld 0x04000B69
    IL_0015: ldarg.1
    IL_0016: IL_58
    IL_001B: stfld 0x04000B69
    IL_001C: ldarg.1
    IL_001D: ldc.i4.1
    IL_0022: call 0x0600021E
    IL_0023: pop
    IL_0024: ret
    }

    public void GainSoul() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: dup
    IL_0008: ldfld 0x04000B64
    IL_0009: ldarg.1
    IL_000A: IL_58
    IL_000F: stfld 0x04000B64
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000B61
    IL_001A: brtrue IL_0036
    IL_001B: ldarg.0
    IL_001C: ldarg.0
    IL_0021: ldfld 0x04000B64
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_41
    IL_0030: call 0x0A0000D4
    IL_0035: stfld 0x04000B64
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000B64
    IL_003C: not
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000B63
    IL_0047: beq IL_009C
    IL_0048: ldarg.0
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000B64
    IL_004F: not
    IL_0054: stfld 0x04000B63
    IL_0055: ldarg.0
    IL_0056: IL_22
    IL_0057: nop
    IL_0058: nop
    IL_005D: stsfld 0x637B023F
    IL_005E: stloc.1
    IL_005F: nop
    IL_0060: ldarg.2
    IL_0061: conv.i2
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_41
    IL_0067: add
    IL_0068: IL_59
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_3F
    IL_006E: IL_5A
    IL_0073: stfld 0x04000B85
    IL_0074: ldarg.0
    IL_0079: ldfld 0x04000B61
    IL_007E: brtrue IL_009A
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000BA9
    IL_0089: call 0x0A000082
    IL_008A: ldarg.0
    IL_008F: ldfld 0x04000B85
    IL_0094: call 0x0A000083
    IL_0095: conv.r8
    IL_0096: IL_F3
    IL_0097: ldarg.0
    IL_0098: nop
    IL_0099: ldloc.0
    IL_009A: ldc.i4.1
    IL_009B: stloc.0
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x04000BA6
    IL_00A2: ldarg.0
    IL_00A7: ldfld 0x04000B63
    IL_00A8: conv.r8
    IL_00A9: IL_3D
    IL_00AA: ldarg.1
    IL_00AB: nop
    IL_00AC: ldloc.0
    IL_00AD: ldloc.0
    IL_00AE: ret
    }

    public void GetExp() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0007: ldfld 0x04000BA2
    IL_0008: conv.r8
    IL_0009: IL_99
    IL_000A: IL_01
    IL_000B: nop
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000B61
    IL_0017: brtrue IL_002A
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000B6B
    IL_0023: call 0x06000624
    IL_0024: stloc.0
    IL_0029: br IL_0059
    IL_002A: ldarg.0
    IL_002B: dup
    IL_0030: ldfld 0x04000B67
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000B94
    IL_003B: ldc.i4 200
    IL_003C: IL_5A
    IL_003D: IL_58
    IL_0042: stfld 0x04000B67
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000B7A
    IL_0049: ldarg.0
    IL_004E: ldflda 0x04000B67
    IL_0053: call 0x0A000010
    IL_0054: conv.r8
    IL_0055: IL_FD
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000BA2
    IL_0064: ldfld 0x040002EF
    IL_0069: stfld 0x04000B5A
    IL_006A: ldarg.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04000BA2
    IL_0075: ldfld 0x040002EE
    IL_007A: stfld 0x04000B5B
    IL_007B: ldarg.0
    IL_007C: dup
    IL_0081: ldfld 0x04000B9D
    IL_0082: ldc.i4.1
    IL_0083: IL_58
    IL_0084: neg
    IL_0089: stfld 0x04000B9D
    IL_008A: ldarg.0
    IL_008B: dup
    IL_0090: ldfld 0x04000B9F
    IL_0091: ldc.i4.1
    IL_0092: IL_58
    IL_0097: stfld 0x04000B9F
    IL_0098: ldarg.0
    IL_009D: ldfld 0x04000B90
    IL_009E: ldc.i4.5
    IL_009F: IL_3E
    IL_00A0: ldarg.3
    IL_00A1: nop
    IL_00A2: nop
    IL_00A3: nop
    IL_00A8: br IL_014B
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000B61
    IL_00B3: brfalse IL_0102
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x04000B9D
    IL_00BB: ldc.i4.s 10
    IL_00BC: IL_3F
    IL_00BD: IL_3C
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: dup
    IL_00C7: ldfld 0x04000BA1
    IL_00C8: ldc.i4.1
    IL_00C9: IL_59
    IL_00CA: neg
    IL_00CF: stfld 0x04000BA1
    IL_00D0: ldarg.0
    IL_00D5: ldfld 0x04000BAC
    IL_00DA: call 0x0A000082
    IL_00DB: IL_22
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: IL_3D
    IL_00E4: call 0x0A000083
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x04000BA1
    IL_00EB: conv.i2
    IL_00F0: call 0x0A000083
    IL_00F1: conv.r8
    IL_00F2: IL_F3
    IL_00F3: ldarg.0
    IL_00F4: nop
    IL_00F5: ldloc.0
    IL_00F6: ldarg.0
    IL_00F7: ldc.i4.0
    IL_00FC: stfld 0x04000B9D
    IL_0101: br IL_014B
    IL_0102: ldarg.0
    IL_0107: ldfld 0x04000B9D
    IL_0109: ldc.i4.s 15
    IL_010A: IL_3F
    IL_010B: IL_3C
    IL_010C: nop
    IL_010D: nop
    IL_010E: nop
    IL_010F: ldarg.0
    IL_0110: dup
    IL_0115: ldfld 0x04000BA1
    IL_0116: ldc.i4.1
    IL_0117: IL_59
    IL_0118: neg
    IL_011D: stfld 0x04000BA1
    IL_011E: ldarg.0
    IL_0123: ldfld 0x04000BAC
    IL_0128: call 0x0A000082
    IL_0129: IL_22
    IL_012A: nop
    IL_012B: nop
    IL_012C: nop
    IL_012D: IL_3D
    IL_0132: call 0x0A000083
    IL_0133: ldarg.0
    IL_0138: ldfld 0x04000BA1
    IL_0139: conv.i2
    IL_013E: call 0x0A000083
    IL_013F: conv.r8
    IL_0140: IL_F3
    IL_0141: ldarg.0
    IL_0142: nop
    IL_0143: ldloc.0
    IL_0144: ldarg.0
    IL_0145: ldc.i4.0
    IL_014A: stfld 0x04000B9D
    IL_014B: ldarg.0
    IL_014C: IL_22
    IL_014D: nop
    IL_014E: nop
    IL_0153: stsfld 0x5A7B023F
    IL_0154: stloc.1
    IL_0155: nop
    IL_0156: ldarg.2
    IL_0157: conv.i2
    IL_0158: ldarg.0
    IL_015D: ldfld 0x04000B5B
    IL_015F: ldc.i4.s 100
    IL_0160: IL_5A
    IL_0161: conv.i2
    IL_0162: add
    IL_0163: IL_59
    IL_0164: IL_22
    IL_0165: nop
    IL_0166: nop
    IL_0167: nop
    IL_0168: IL_3E
    IL_0169: IL_5A
    IL_016E: stfld 0x04000B86
    IL_016F: ldarg.0
    IL_0174: ldfld 0x04000BAA
    IL_0179: call 0x0A0000AA
    IL_017A: ldarg.0
    IL_017F: ldfld 0x04000B86
    IL_0184: call 0x0A000083
    IL_0185: conv.r8
    IL_0186: IL_F3
    IL_0187: ldarg.0
    IL_0188: nop
    IL_0189: ldloc.0
    IL_018A: ldarg.0
    IL_018F: ldfld 0x04000B5B
    IL_0190: ldarg.0
    IL_0195: ldfld 0x04000B80
    IL_019A: beq IL_01F2
    IL_019B: ldarg.0
    IL_01A0: ldfld 0x04000B6D
    IL_01A1: IL_22
    IL_01A2: IL_CD
    IL_01A3: IL_CC
    IL_01A4: IL_AC
    IL_01A5: IL_BF
    IL_01A6: IL_22
    IL_01A7: IL_8F
    IL_01A8: IL_C2
    IL_01A9: IL_35
    IL_200000236: switch (2147483682 cases)
    }

    public void PauseOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B92
    IL_000A: brfalse IL_0016
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000BA5
    IL_0011: conv.r8
    IL_0012: IL_35
    IL_0013: ldloc.0
    IL_0014: nop
    IL_0015: ldloc.0
    IL_0016: ret
    }

    public void Resurrection() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000B66
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000B65
    IL_0020: ret
    }

    public void Damaged_Extreme() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000B81
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000B81
    IL_000E: ret
    }

    public void Damaged() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000B83
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000E: stsfld 0x837D583D
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: ldarg.2
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BA7
    IL_001C: call 0x0A000082
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000B83
    IL_0027: call 0x0A000083
    IL_0028: conv.r8
    IL_0029: IL_F3
    IL_002A: ldarg.0
    IL_002B: nop
    IL_002C: ldloc.0
    IL_002D: ldarg.0
    IL_002E: dup
    IL_0033: ldfld 0x04000B81
    IL_0034: ldc.i4.1
    IL_0035: IL_58
    IL_003A: stfld 0x04000B81
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000B81
    IL_0041: ldc.i4.3
    IL_0042: IL_3F
    IL_0043: ldc.i4.7
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: ldarg.0
    IL_0048: ldc.i4.m1
    IL_004D: call 0x06000610
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000BA2
    IL_0054: conv.r8
    IL_0059: cpobj 0x02060001
    IL_005E: ldfld 0x04000BA2
    IL_005F: conv.r8
    IL_0064: newobj 0x2A060001
    }

    public void GameOver() {
    IL_0004: ldstr 0x70002059
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_000D: IL_58
    IL_000E: stloc.0
    IL_0013: ldstr 0x70002059
    IL_0014: ldloc.0
    IL_0019: call 0x0600021F
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04000B72
    IL_0020: conv.r8
    IL_0021: stloc.0
    IL_0022: nop
    IL_0023: nop
    IL_0024: stloc.0
    IL_0025: ldc.i4.1
    IL_0026: conv.r8
    IL_0027: stloc.1
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000BA5
    IL_0031: conv.r8
    IL_0032: IL_34
    IL_0033: ldloc.0
    IL_0034: nop
    IL_0035: ldloc.0
    IL_0036: ret
    }

    public void StatUpdate_sp() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000B58
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000F: stsfld 0x587B023F
    IL_0010: stloc.1
    IL_0011: nop
    IL_0012: ldarg.2
    IL_0013: conv.i2
    IL_0014: ldarg.0
    IL_0019: ldfld 0x04000B59
    IL_001A: conv.i2
    IL_001B: add
    IL_001C: IL_59
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: IL_3F
    IL_0022: IL_5A
    IL_0027: stfld 0x04000B84
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000B58
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0033: ldloc 17474
    IL_0038: ldc.i4 33554432
    IL_003D: ldfld 0x04000BA8
    IL_0042: call 0x0A000082
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000B84
    IL_004D: call 0x0A000083
    IL_004E: conv.r8
    IL_004F: IL_F3
    IL_0050: ldarg.0
    IL_0051: nop
    IL_0052: ldloc.0
    IL_0057: br IL_0087
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000BA8
    IL_0062: call 0x0A000082
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000B84
    IL_006D: call 0x0A000083
    IL_0072: call 0x0A0000AA
    IL_0073: IL_22
    IL_0074: nop
    IL_0075: nop
    IL_0076: nop
    IL_0077: IL_3D
    IL_007C: call 0x0A000083
    IL_0081: call 0x0A000174
    IL_0082: conv.r8
    IL_0083: IL_F3
    IL_0084: ldarg.0
    IL_0085: nop
    IL_0086: ldloc.0
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000B8C
    IL_008D: ldc.i4.m1
    IL_0092: beq IL_00AF
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04000B8A
    IL_009D: brtrue IL_00AF
    IL_009E: ldarg.0
    IL_00A3: ldfld 0x04000BA6
    IL_00A4: ldarg.0
    IL_00A9: ldfld 0x04000B58
    IL_00AA: conv.r8
    IL_00AB: IL_36
    IL_00AC: ldarg.1
    IL_00AD: nop
    IL_00AE: ldloc.0
    IL_00AF: ret
    }

    public void StatUpdate_hp() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000B8D
    IL_000C: ldc.i4.2
    IL_0011: beq IL_005E
    IL_0012: ldarg.0
    IL_0013: ldarg.1
    IL_0018: stfld 0x04000B57
    IL_0019: ldarg.0
    IL_001A: ldarg.2
    IL_001F: stfld 0x04000B56
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0x577B023F
    IL_0028: stloc.1
    IL_0029: nop
    IL_002A: ldarg.2
    IL_002B: conv.i2
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000B56
    IL_0032: conv.i2
    IL_0033: add
    IL_0034: IL_59
    IL_0035: stloc.0
    IL_0036: ldarg.0
    IL_0037: ldloc.0
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: IL_3F
    IL_003D: IL_5A
    IL_0042: stfld 0x04000B83
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000BA7
    IL_004D: call 0x0A000082
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000B83
    IL_0058: call 0x0A000083
    IL_0059: conv.r8
    IL_005A: IL_F3
    IL_005B: ldarg.0
    IL_005C: nop
    IL_005D: ldloc.0
    IL_005E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000B93
    IL_000A: brfalse IL_0010
    IL_000F: br IL_009D
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000B87
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_43
    IL_001C: or
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000BAE
    IL_002A: brfalse IL_007E
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000B7F
    IL_0031: IL_22
    IL_0032: nop
    IL_0033: nop
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_22
    IL_0037: IL_29
    IL_0038: sub
    IL_003A: bge.s IL_007B
    IL_003B: IL_22
    IL_003C: shr
    IL_003D: shr
    IL_003E: ldloc.0
    IL_1DA0F: switch (30323 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000BBA
    IL_0007: ldarg.0
    IL_000C: call 0x0A000057
    IL_0011: stfld 0x04000BBE
    IL_0012: ldarg.0
    IL_0014: ldc.i4.s 10
    IL_0019: stfld 0x04000BD3
    IL_001A: ldarg.0
    IL_001B: ldc.i4.1
    IL_0020: stfld 0x04000BD4
    IL_0021: ldarg.0
    IL_0026: call 0x0A000001
    IL_0027: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x700004D5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000BD5
    IL_0010: ret
    }

    private void Start() {
    IL_0000: ldc.i4.0
    IL_0005: call 0x0A0002E9
    IL_0006: ldarg.0
    IL_000B: ldstr 0x70000BB3
    IL_0010: call 0x0A000095
    IL_0015: stfld 0x04000BD9
    IL_0016: ldarg.0
    IL_001B: ldstr 0x70000BD5
    IL_0020: call 0x0A000004
    IL_0021: conv.r8
    IL_002A: ldc.i8 288243409182457856
    IL_002B: ldarg.0
    IL_0030: ldstr 0x70000001
    IL_0035: call 0x0A000004
    IL_0036: conv.r8
    IL_0037: ldarg.2
    IL_0038: nop
    IL_0039: nop
    IL_003B: br.s IL_00B9
    IL_003C: IL_CE
    IL_003D: stloc.1
    IL_003E: nop
    IL_003F: ldarg.2
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70000063
    IL_004A: call 0x0A000004
    IL_004B: conv.r8
    IL_004C: ldarg.0
    IL_004D: nop
    IL_004E: nop
    IL_0050: br.s IL_00CE
    IL_0051: IL_CF
    IL_0052: stloc.1
    IL_0053: nop
    IL_0054: ldarg.2
    IL_0055: ldarg.0
    IL_005A: ldstr 0x70022774
    IL_005F: call 0x0A0001C1
    IL_0064: stfld 0x04000BC7
    IL_0065: ldarg.0
    IL_006A: ldstr 0x7002270C
    IL_006F: call 0x0A0001C1
    IL_0074: stfld 0x04000BC8
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000BC8
    IL_007F: call 0x0A0001C2
    IL_0080: ldarg.0
    IL_0081: ldarg.0
    IL_0086: ldfld 0x04000BCF
    IL_008B: ldfld 0x0400095D
    IL_0090: stfld 0x04000BC5
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000BC5
    IL_009B: brfalse IL_00A3
    IL_009C: ldarg.0
    IL_009D: ldc.i4.3
    IL_00A2: stfld 0x04000BD4
    IL_00A3: ldarg.0
    IL_00A8: ldstr 0x70001E7D
    IL_00AD: call 0x06000220
    IL_00B2: stfld 0x04000BDC
    IL_00B7: call 0x0A000035
    IL_00B8: conv.r8
    IL_00B9: ldloc.0
    IL_00BA: nop
    IL_00BB: nop
    IL_00BD: br.s IL_00C0
    IL_00C2: ldfld 0x04000BDC
    IL_00C4: ldc.i4.s -2
    IL_00C5: IL_5A
    IL_00C7: ldc.i4.s 30
    IL_00C8: IL_58
    IL_00C9: conv.i2
    IL_00CA: conv.r8
    IL_00CC: blt.s IL_00CE
    IL_00CD: nop
    IL_00CE: ldloc.0
    IL_00CF: ldarg.0
    IL_00D4: call 0x0A00000A
    IL_00D5: ldc.i4.0
    IL_00D6: conv.r8
    IL_00D7: stloc.1
    IL_00D8: nop
    IL_00D9: nop
    IL_00DA: stloc.0
    IL_00DF: call 0x0600004E
    IL_00E0: conv.r8
    IL_00E1: neg
    IL_00E2: nop
    IL_00E3: nop
    IL_00E4: ldloc.0
    IL_00E5: ret
    }

    public void CountDown() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BD3
    IL_0007: ldc.i4.1
    IL_0008: IL_59
    IL_000D: stfld 0x04000BD3
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000BD3
    IL_0014: ldc.i4.0
    IL_0015: IL_3D
    IL_0016: ldc.i4.7
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldarg.0
    IL_001B: ldc.i4.0
    IL_0020: stfld 0x04000BD8
    IL_0021: IL_22
    IL_0022: nop
    IL_0023: nop
    IL_0028: stsfld 0x0111283F
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000BDA
    IL_0031: ldc.i4.m1
    IL_0032: conv.r8
    IL_0034: starg.s 6
    IL_0035: nop
    IL_0036: ldloc.0
    IL_0037: ret
    }

    public void GetAngel() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000BC0
    IL_000B: ldstr 0x7000000F
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000BC0
    IL_0016: call 0x0600021F
    IL_0017: ldarg.0
    IL_0018: ldc.i4.1
    IL_001D: stfld 0x04000BCC
    IL_001E: ldarg.0
    IL_0023: ldstr 0x7002374B
    IL_0024: IL_22
    IL_0025: ldelem.i
    IL_0026: IL_99
    IL_0027: ldc.i4.3
    IL_FCCC: switch (16168 cases)
    }

    private void GetAngelFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000BCC
    IL_0007: ldarg.0
    IL_000C: call 0x0A00000A
    IL_000D: ldc.i4.0
    IL_000E: conv.r8
    IL_000F: stloc.1
    IL_0010: nop
    IL_0011: nop
    IL_0012: stloc.0
    IL_0017: call 0x0A000303
    IL_0018: ret
    }

    public void ChanceOn() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: IL_3F
    IL_0009: call 0x0A000111
    IL_000A: ldarg.0
    IL_000B: ldc.i4.1
    IL_0010: stfld 0x04000BD8
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700235C7
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_3F
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_3F
    IL_0025: call 0x0A000017
    IL_0026: ret
    }

    public void PauseOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BD2
    IL_000A: brfalse IL_0018
    IL_000B: ldarg.0
    IL_0010: call 0x0A00000A
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0013: stloc.1
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ret
    IL_0018: ldarg.0
    IL_001D: call 0x0A00000A
    IL_001E: ldc.i4.1
    IL_001F: conv.r8
    IL_0020: stloc.1
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: IL_22
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_002D: call 0x0A000111
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000BCE
    IL_0034: conv.r8
    IL_0039: newobj 0x02060001
    IL_003A: ldc.i4.1
    IL_003F: stfld 0x04000BD6
    IL_0044: call 0x060001EF
    IL_0045: conv.r8
    IL_0046: IL_F5
    IL_0047: IL_01
    IL_0048: nop
    IL_0049: ldloc.0
    IL_004A: stloc.0
    IL_004B: ldloc.0
    IL_0050: ldstr 0x700233A9
    IL_0055: call 0x0A0000EC
    IL_005A: brfalse IL_006C
    IL_005F: call 0x0600004E
    IL_0060: conv.r8
    IL_0061: or
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldloc.0
    IL_0065: ldarg.0
    IL_0066: ldc.i4.0
    IL_006B: stfld 0x04000BCD
    IL_006C: ret
    }

    public void SetTutorial() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0009: call 0x0A000111
    IL_000A: ldarg.0
    IL_000F: ldfld 0x04000BCE
    IL_0010: conv.r8
    IL_0015: newobj 0x02060001
    IL_0016: ldc.i4.1
    IL_001B: stfld 0x04000BB8
    IL_001C: ldarg.0
    IL_001D: ldc.i4.0
    IL_0022: stfld 0x04000BBC
    IL_0023: ldarg.0
    IL_0024: ldarg.2
    IL_0029: stfld 0x04000BBB
    IL_002A: ldarg.0
    IL_002B: ldarg.1
    IL_0030: stfld 0x04000BB9
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000BB9
    IL_0038: ldc.i4.s 10
    IL_0039: IL_5A
    IL_003A: ldarg.0
    IL_003F: ldfld 0x04000BBB
    IL_0040: IL_58
    IL_0041: stloc.0
    IL_0042: ldarg.0
    IL_0047: ldstr 0x70023769
    IL_0049: ldloca.s 0
    IL_004E: call 0x0A000010
    IL_0053: call 0x0A000011
    IL_0058: call 0x0A000012
    IL_0059: conv.u8
    IL_005A: IL_3C
    IL_005B: nop
    IL_005C: nop
    IL_005D: IL_01
    IL_0062: stfld 0x04000BB7
    IL_0063: ldloc.0
    IL_0064: stloc.1
    IL_0065: ldloc.1
    IL_0067: ldc.i4.s 10
    IL_0068: IL_59
    IL_006B: ldarg 3
    IL_006C: nop
    IL_006D: nop
    IL_006E: and
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldelem.r4
    IL_0073: nop
    IL_0074: nop
    IL_0075: nop
    IL_0076: IL_D5
    IL_0077: nop
    IL_0078: nop
    IL_0079: nop
    IL_007A: ldloc.1
    IL_007C: ldc.i4.s 50
    IL_007D: IL_59
    IL_0080: ldarg 3
    IL_0081: nop
    IL_0082: nop
    IL_0083: IL_5A
    IL_0084: ldarg.0
    IL_0085: nop
    IL_0086: nop
    IL_0087: IL_AC
    IL_0088: ldarg.0
    IL_0089: nop
    IL_008A: nop
    IL_008B: IL_E2
    IL_008C: ldarg.0
    IL_008D: nop
    IL_008E: nop
    IL_008F: ldloc.1
    IL_0091: ldc.i4.s 20
    IL_0096: beq IL_0185
    IL_0097: ldloc.1
    IL_0099: ldc.i4.s 21
    IL_009E: beq IL_01C2
    IL_009F: ldloc.1
    IL_00A1: ldc.i4.s 30
    IL_00A6: beq IL_01F1
    IL_00A7: ldloc.1
    IL_00A9: ldc.i4.s 31
    IL_00AE: beq IL_022B
    IL_00AF: ldloc.1
    IL_00B1: ldc.i4.s 40
    IL_00B6: beq IL_0261
    IL_00B7: ldloc.1
    IL_00B9: ldc.i4.s 41
    IL_00BE: beq IL_02B3
    IL_00BF: ldloc.1
    IL_00C1: ldc.i4.s 60
    IL_00C6: beq IL_03A7
    IL_00C7: ldloc.1
    IL_00C9: ldc.i4.s 61
    IL_00CE: beq IL_03E4
    IL_00CF: ldloc.1
    IL_00D1: ldc.i4.s 70
    IL_00D6: beq IL_041A
    IL_00DB: br IL_0457
    IL_00DC: ldarg.0
    IL_00E1: ldc.i4 338
    IL_00E6: stfld 0x04000BBC
    IL_00E7: ldarg.0
    IL_00E8: ldc.i4.3
    IL_00ED: stfld 0x04000BBA
    IL_00EE: ldarg.0
    IL_00EF: ldc.i4.0
    IL_00F4: stfld 0x04000BBD
    IL_00F5: ldarg.0
    IL_00F6: IL_22
    IL_00F7: nop
    IL_00F8: nop
    IL_00F9: ret
    IL_00FA: IL_43
    IL_00FB: IL_22
    IL_00FC: nop
    IL_00FD: nop
    IL_00FE: ldloc.0
    IL_00FF: IL_43
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: nop
    IL_0104: IL_43
    IL_0105: IL_22
    IL_0106: nop
    IL_0107: nop
    IL_010C: stsfld 0x021D2842
    IL_010D: nop
    IL_010E: ldloc.0
    IL_0113: stfld 0x04000BBF
    IL_0118: br IL_0457
    IL_0119: ldarg.0
    IL_011E: ldc.i4 339
    IL_0123: stfld 0x04000BBC
    IL_0124: ldarg.0
    IL_0125: ldc.i4.0
    IL_012A: stfld 0x04000BBD
    IL_012B: ldarg.0
    IL_012C: IL_22
    IL_012D: nop
    IL_012E: nop
    IL_012F: ret
    IL_0130: IL_43
    IL_0131: IL_22
    IL_0132: nop
    IL_0133: nop
    IL_0134: ldloc.0
    IL_0135: IL_43
    IL_0136: IL_22
    IL_0137: nop
    IL_0138: nop
    IL_0139: nop
    IL_013A: IL_43
    IL_013B: IL_22
    IL_013C: nop
    IL_013D: nop
    IL_0142: stsfld 0x021D2842
    IL_0143: nop
    IL_0144: ldloc.0
    IL_0149: stfld 0x04000BBF
    IL_014E: br IL_0457
    IL_014F: ldarg.0
    IL_0154: ldc.i4 340
    IL_0159: stfld 0x04000BBC
    IL_015A: ldarg.0
    IL_015B: ldc.i4.0
    IL_0160: stfld 0x04000BBD
    IL_0161: ldarg.0
    IL_0162: IL_22
    IL_0163: nop
    IL_0164: nop
    IL_0165: ret
    IL_0166: IL_43
    IL_0167: IL_22
    IL_0168: nop
    IL_0169: nop
    IL_016A: ldloc.0
    IL_016B: IL_43
    IL_016C: IL_22
    IL_016D: nop
    IL_016E: nop
    IL_016F: nop
    IL_0170: IL_43
    IL_0171: IL_22
    IL_0172: nop
    IL_0173: nop
    IL_0178: stsfld 0x021D2842
    IL_0179: nop
    IL_017A: ldloc.0
    IL_017F: stfld 0x04000BBF
    IL_0184: br IL_0457
    IL_0185: ldarg.0
    IL_018A: ldc.i4 341
    IL_018F: stfld 0x04000BBC
    IL_0190: ldarg.0
    IL_0191: ldc.i4.2
    IL_0196: stfld 0x04000BBA
    IL_0197: ldarg.0
    IL_0198: ldc.i4.0
    IL_019D: stfld 0x04000BBD
    IL_019E: ldarg.0
    IL_019F: IL_22
    IL_01A0: nop
    IL_01A1: nop
    IL_01A2: ret
    IL_01A3: IL_43
    IL_01A4: IL_22
    IL_01A5: nop
    IL_01A6: nop
    IL_01A7: ldloc.0
    IL_01A8: IL_43
    IL_01A9: IL_22
    IL_01AA: nop
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: IL_43
    IL_01AE: IL_22
    IL_01AF: nop
    IL_01B0: nop
    IL_01B5: stsfld 0x021D2842
    IL_01B6: nop
    IL_01B7: ldloc.0
    IL_01BC: stfld 0x04000BBF
    IL_01C1: br IL_0457
    IL_01C2: ldarg.0
    IL_01C7: ldc.i4 342
    IL_01CC: stfld 0x04000BBC
    IL_01CD: ldarg.0
    IL_01CE: IL_22
    IL_01CF: nop
    IL_01D0: nop
    IL_01D1: ldc.i4.0
    IL_01D2: IL_43
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01D6: IL_DC
    IL_01D7: IL_42
    IL_01D8: IL_22
    IL_01D9: nop
    IL_01DA: nop
    IL_01DF: ldc.i4 8770
    IL_01E0: ldelem.r8
    IL_01E1: IL_42
    IL_01E6: call 0x0600021D
    IL_01EB: stfld 0x04000BBF
    IL_01F0: br IL_0457
    IL_01F1: ldarg.0
    IL_01F3: ldc.i4.s 36
    IL_01F8: stfld 0x04000BBC
    IL_01F9: ldarg.0
    IL_01FA: ldc.i4.2
    IL_01FF: stfld 0x04000BBA
    IL_0200: ldarg.0
    IL_0201: ldc.i4.0
    IL_0206: stfld 0x04000BBD
    IL_0207: ldarg.0
    IL_0208: IL_22
    IL_0209: nop
    IL_020A: nop
    IL_020B: ret
    IL_020C: IL_43
    IL_020D: IL_22
    IL_020E: nop
    IL_020F: nop
    IL_0210: ldloc.0
    IL_0211: IL_43
    IL_0212: IL_22
    IL_0213: nop
    IL_0214: nop
    IL_0215: nop
    IL_0216: IL_43
    IL_0217: IL_22
    IL_0218: nop
    IL_0219: nop
    IL_021E: stsfld 0x021D2842
    IL_021F: nop
    IL_0220: ldloc.0
    IL_0225: stfld 0x04000BBF
    IL_022A: br IL_0457
    IL_022B: ldarg.0
    IL_0230: ldc.i4 359
    IL_0235: stfld 0x04000BBC
    IL_0236: ldarg.0
    IL_0237: ldc.i4.0
    IL_023C: stfld 0x04000BBD
    IL_023D: ldarg.0
    IL_023E: IL_22
    IL_023F: nop
    IL_0240: nop
    IL_0241: ret
    IL_0242: IL_43
    IL_0243: IL_22
    IL_0244: nop
    IL_0245: nop
    IL_0246: ldloc.0
    IL_0247: IL_43
    IL_0248: IL_22
    IL_0249: nop
    IL_024A: nop
    IL_024B: nop
    IL_024C: IL_43
    IL_024D: IL_22
    IL_024E: nop
    IL_024F: nop
    IL_0254: stsfld 0x021D2842
    IL_0255: nop
    IL_0256: ldloc.0
    IL_025B: stfld 0x04000BBF
    IL_0260: br IL_0457
    IL_0261: ldarg.0
    IL_0266: ldc.i4 346
    IL_026B: stfld 0x04000BBC
    IL_026C: ldarg.0
    IL_026D: ldc.i4.2
    IL_0272: stfld 0x04000BBA
    IL_0273: ldarg.0
    IL_0274: ldc.i4.1
    IL_0279: stfld 0x04000BBD
    IL_027A: ldarg.0
    IL_027B: IL_22
    IL_027C: nop
    IL_027D: nop
    IL_0282: ldc.i4 8769
    IL_0287: ldc.i4 3699522
    IL_0288: nop
    IL_0289: stloc.0
    IL_028E: stfld 0x04000BBE
    IL_028F: ldarg.0
    IL_0290: IL_22
    IL_0291: nop
    IL_0292: nop
    IL_0293: ret
    IL_0294: IL_43
    IL_0295: IL_22
    IL_0296: nop
    IL_0297: nop
    IL_0298: ldloc.0
    IL_0299: IL_43
    IL_029A: IL_22
    IL_029B: nop
    IL_029C: nop
    IL_029D: nop
    IL_029E: IL_43
    IL_029F: IL_22
    IL_02A0: nop
    IL_02A1: nop
    IL_02A6: stsfld 0x021D2842
    IL_02A7: nop
    IL_02A8: ldloc.0
    IL_02AD: stfld 0x04000BBF
    IL_02B2: br IL_0457
    IL_02B3: ldarg.0
    IL_02B8: ldc.i4 347
    IL_02BD: stfld 0x04000BBC
    IL_02BE: ldarg.0
    IL_02BF: ldc.i4.0
    IL_02C4: stfld 0x04000BBD
    IL_02C5: ldarg.0
    IL_02C6: IL_22
    IL_02C7: nop
    IL_02C8: nop
    IL_02C9: ret
    IL_02CA: IL_43
    IL_02CB: IL_22
    IL_02CC: nop
    IL_02CD: nop
    IL_02CE: ldloc.0
    IL_02CF: IL_43
    IL_02D0: IL_22
    IL_02D1: nop
    IL_02D2: nop
    IL_02D3: nop
    IL_02D4: IL_43
    IL_02D5: IL_22
    IL_02D6: nop
    IL_02D7: nop
    IL_02DC: stsfld 0x021D2842
    IL_02DD: nop
    IL_02DE: ldloc.0
    IL_02E3: stfld 0x04000BBF
    IL_02E8: br IL_0457
    IL_02E9: ldarg.0
    IL_02EE: ldc.i4 343
    IL_02F3: stfld 0x04000BBC
    IL_02F4: ldarg.0
    IL_02F5: ldc.i4.3
    IL_02FA: stfld 0x04000BBA
    IL_02FB: ldarg.0
    IL_02FC: ldc.i4.0
    IL_0301: stfld 0x04000BBD
    IL_0302: ldarg.0
    IL_0303: IL_22
    IL_0304: nop
    IL_0305: nop
    IL_030A: ldc.i4 8769
    IL_030F: ldc.i4 3699522
    IL_0310: nop
    IL_0311: stloc.0
    IL_0316: stfld 0x04000BBE
    IL_0317: ldarg.0
    IL_0318: IL_22
    IL_0319: nop
    IL_031A: nop
    IL_031B: ret
    IL_031C: IL_43
    IL_031D: IL_22
    IL_031E: nop
    IL_031F: nop
    IL_0320: ldloc.0
    IL_0321: IL_43
    IL_0322: IL_22
    IL_0323: nop
    IL_0324: nop
    IL_0325: nop
    IL_0326: IL_43
    IL_0327: IL_22
    IL_0328: nop
    IL_0329: nop
    IL_032E: stsfld 0x021D2842
    IL_032F: nop
    IL_0330: ldloc.0
    IL_0335: stfld 0x04000BBF
    IL_033A: br IL_0457
    IL_033B: ldarg.0
    IL_0340: ldc.i4 344
    IL_0345: stfld 0x04000BBC
    IL_0346: ldarg.0
    IL_0347: ldc.i4.0
    IL_034C: stfld 0x04000BBD
    IL_034D: ldarg.0
    IL_034E: IL_22
    IL_034F: nop
    IL_0350: nop
    IL_0351: ret
    IL_0352: IL_43
    IL_0353: IL_22
    IL_0354: nop
    IL_0355: nop
    IL_0356: ldloc.0
    IL_0357: IL_43
    IL_0358: IL_22
    IL_0359: nop
    IL_035A: nop
    IL_035B: nop
    IL_035C: IL_43
    IL_035D: IL_22
    IL_035E: nop
    IL_035F: nop
    IL_0364: stsfld 0x021D2842
    IL_0365: nop
    IL_0366: ldloc.0
    IL_036B: stfld 0x04000BBF
    IL_0370: br IL_0457
    IL_0371: ldarg.0
    IL_0376: ldc.i4 345
    IL_037B: stfld 0x04000BBC
    IL_037C: ldarg.0
    IL_037D: ldc.i4.0
    IL_0382: stfld 0x04000BBD
    IL_0383: ldarg.0
    IL_0384: IL_22
    IL_0385: nop
    IL_0386: nop
    IL_0387: ret
    IL_0388: IL_43
    IL_0389: IL_22
    IL_038A: nop
    IL_038B: nop
    IL_038C: ldloc.0
    IL_038D: IL_43
    IL_038E: IL_22
    IL_038F: nop
    IL_0390: nop
    IL_0391: nop
    IL_0392: IL_43
    IL_0393: IL_22
    IL_0394: nop
    IL_0395: nop
    IL_039A: stsfld 0x021D2842
    IL_039B: nop
    IL_039C: ldloc.0
    IL_03A1: stfld 0x04000BBF
    IL_03A6: br IL_0457
    IL_03A7: ldarg.0
    IL_03AC: ldc.i4 348
    IL_03B1: stfld 0x04000BBC
    IL_03B2: ldarg.0
    IL_03B3: ldc.i4.2
    IL_03B8: stfld 0x04000BBA
    IL_03B9: ldarg.0
    IL_03BA: ldc.i4.0
    IL_03BF: stfld 0x04000BBD
    IL_03C0: ldarg.0
    IL_03C1: IL_22
    IL_03C2: nop
    IL_03C3: nop
    IL_03C4: ret
    IL_03C5: IL_43
    IL_03C6: IL_22
    IL_03C7: nop
    IL_03C8: nop
    IL_03C9: ldloc.0
    IL_03CA: IL_43
    IL_03CB: IL_22
    IL_03CC: nop
    IL_03CD: nop
    IL_03CE: nop
    IL_03CF: IL_43
    IL_03D0: IL_22
    IL_03D1: nop
    IL_03D2: nop
    IL_03D7: stsfld 0x021D2842
    IL_03D8: nop
    IL_03D9: ldloc.0
    IL_03DE: stfld 0x04000BBF
    IL_03E3: br IL_0457
    IL_03E4: ldarg.0
    IL_03E9: ldc.i4 349
    IL_03EE: stfld 0x04000BBC
    IL_03EF: ldarg.0
    IL_03F0: ldc.i4.0
    IL_03F5: stfld 0x04000BBD
    IL_03F6: ldarg.0
    IL_03F7: IL_22
    IL_03F8: nop
    IL_03F9: nop
    IL_03FA: ret
    IL_03FB: IL_43
    IL_03FC: IL_22
    IL_03FD: nop
    IL_03FE: nop
    IL_03FF: ldloc.0
    IL_0400: IL_43
    IL_0401: IL_22
    IL_0402: nop
    IL_0403: nop
    IL_0404: nop
    IL_0405: IL_43
    IL_0406: IL_22
    IL_0407: nop
    IL_0408: nop
    IL_040D: stsfld 0x021D2842
    IL_040E: nop
    IL_040F: ldloc.0
    IL_0414: stfld 0x04000BBF
    IL_0419: br IL_0457
    IL_041A: ldarg.0
    IL_041F: ldc.i4 433
    IL_0424: stfld 0x04000BBC
    IL_0425: ldarg.0
    IL_0426: ldc.i4.1
    IL_042B: stfld 0x04000BBA
    IL_042C: ldarg.0
    IL_042D: ldc.i4.0
    IL_0432: stfld 0x04000BBD
    IL_0433: ldarg.0
    IL_0434: IL_22
    IL_0435: nop
    IL_0436: nop
    IL_0437: ret
    IL_0438: IL_43
    IL_0439: IL_22
    IL_043A: nop
    IL_043B: nop
    IL_043C: ldloc.0
    IL_043D: IL_43
    IL_043E: IL_22
    IL_043F: nop
    IL_0440: nop
    IL_0441: nop
    IL_0442: IL_43
    IL_0443: IL_22
    IL_0444: nop
    IL_0445: nop
    IL_044A: stsfld 0x021D2842
    IL_044B: nop
    IL_044C: ldloc.0
    IL_0451: stfld 0x04000BBF
    IL_0456: br IL_0457
    IL_0457: ret
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000BDB
    IL_0040: call 0x0A0000DF
    IL_0041: ldc.i4.0
    IL_0046: call 0x0A0000EF
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000BD8
    IL_0051: brfalse IL_050B
    IL_0052: ldarg.0
    IL_0057: ldfld 0x04000BC5
    IL_005C: brfalse IL_0088
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000BD4
    IL_0064: ldc.i4.s 15
    IL_0065: IL_3E
    IL_0066: ldc.i4.8
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: ldarg.0
    IL_006B: ldc.i4.0
    IL_0070: stfld 0x04000BD8
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0078: stsfld 0x0111283F
    IL_0079: nop
    IL_007A: stloc.0
    IL_007B: ldarg.0
    IL_0080: ldfld 0x04000BDA
    IL_0081: ldc.i4.m1
    IL_0082: conv.r8
    IL_0084: starg.s 6
    IL_0085: nop
    IL_0086: ldloc.0
    IL_0087: ret
    IL_0088: ldarg.0
    IL_0089: dup
    IL_008E: ldfld 0x04000BC9
    IL_0093: call 0x0A000024
    IL_0094: IL_58
    IL_0099: stfld 0x04000BC9
    IL_009A: ldarg.0
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000BC9
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: IL_22
    IL_00A7: nop
    IL_00A8: nop
    IL_00AD: stsfld 0x00D4283F
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B4: stfld 0x04000BC9
    IL_00B9: call 0x0A0000F4
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000BC9
    IL_00C4: call 0x0A000307
    IL_00C9: call 0x0A0000F0
    IL_00CA: IL_22
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: IL_22
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: IL_F0
    IL_00D8: IL_43
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: ldelem.r8
    IL_00DD: IL_43
    IL_00E2: call 0x0600021D
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000BB1
    IL_00ED: call 0x0A0000E0
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x04000BD3
    IL_00F5: ldc.i4.s 9
    IL_00F6: IL_3D
    IL_00F7: stloc.1
    IL_00F8: ldarg.2
    IL_00F9: nop
    IL_00FA: nop
    IL_00FF: call 0x0A00017C
    IL_0104: call 0x0A0000F0
    IL_0105: IL_22
    IL_0106: nop
    IL_0107: nop
    IL_0108: nop
    IL_0109: nop
    IL_010A: IL_22
    IL_010B: nop
    IL_010C: nop
    IL_010D: ldarg.0
    IL_010E: IL_43
    IL_010F: IL_22
    IL_0110: nop
    IL_0111: nop
    IL_0112: IL_F0
    IL_0113: IL_43
    IL_0114: IL_22
    IL_0115: nop
    IL_0116: nop
    IL_011B: stsfld 0x021D2841
    IL_011C: nop
    IL_011D: ldloc.0
    IL_0122: ldsfld 0x040007B2
    IL_0123: ldarg.0
    IL_0128: ldfld 0x04000BD9
    IL_012D: ldc.i4 203
    IL_0132: call 0x0A0000E1
    IL_0137: ldstr 0x70023775
    IL_0138: ldarg.0
    IL_013D: ldfld 0x04000BD3
    IL_0142: newobj 0x0100000B
    IL_0147: call 0x0A000098
    IL_014C: ldstr 0x70002225
    IL_0151: call 0x0A0000E2
    IL_0156: call 0x0A0000E3
    IL_0157: IL_22
    IL_0158: nop
    IL_0159: nop
    IL_015A: conv.r.un
    IL_015B: IL_43
    IL_015C: IL_22
    IL_015D: nop
    IL_015E: nop
    IL_015F: ldc.i4.0
    IL_0160: IL_43
    IL_0161: IL_22
    IL_0162: nop
    IL_0163: nop
    IL_0164: nop
    IL_0165: IL_42
    IL_0166: IL_22
    IL_0167: nop
    IL_0168: nop
    IL_016D: stsfld 0x021D2841
    IL_016E: nop
    IL_016F: ldloc.0
    IL_0174: ldsfld 0x0A000099
    IL_0175: ldarg.0
    IL_017A: ldfld 0x04000BD4
    IL_017F: newobj 0x0100000B
    IL_0184: call 0x0A00009A
    IL_0189: ldstr 0x70002225
    IL_018E: call 0x0A0000E2
    IL_0193: call 0x0A0000E3
    IL_0194: IL_22
    IL_0195: nop
    IL_0196: nop
    IL_0197: shr
    IL_0198: IL_43
    IL_0199: IL_22
    IL_019A: nop
    IL_019B: nop
    IL_019C: ldc.i4.0
    IL_019D: IL_43
    IL_019E: IL_22
    IL_019F: nop
    IL_01A0: nop
    IL_01A5: stsfld 0x00002241
    IL_01AA: stsfld 0x021D2841
    IL_01AB: nop
    IL_01AC: ldloc.0
    IL_01AD: ldarg.0
    IL_01B2: ldfld 0x04000BB4
    IL_01B7: call 0x0A0000E0
    IL_01B8: ldarg.0
    IL_01BD: ldfld 0x04000BD5
    IL_01BE: ldarg.0
    IL_01C3: ldfld 0x04000BD4
    IL_01C4: IL_3F
    IL_01C5: IL_E4
    IL_01C6: IL_01
    IL_01C7: nop
    IL_01C8: nop
    IL_01C9: IL_22
    IL_01CA: nop
    IL_01CB: nop
    IL_01CC: IL_E0
    IL_01CD: IL_42
    IL_01CE: IL_22
    IL_01CF: nop
    IL_01D0: nop
    IL_01D1: ret
    IL_01D2: IL_43
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01DA: stsfld 0x00002243
    IL_01DF: stsfld 0x021D2841
    IL_01E0: nop
    IL_01E1: ldloc.0
    IL_01E2: ldc.i4.5
    IL_01E7: newarr 0x01000020
    IL_01E8: dup
    IL_01E9: ldc.i4.0
    IL_01EE: ldstr 0x70023781
    IL_01F3: stelem 0xB27E1725
    IL_01F4: ldloc.1
    IL_01F5: nop
    IL_01F6: ldarg.2
    IL_01F7: ldarg.0
    IL_01FC: ldfld 0x04000BD9
    IL_0201: ldc.i4 204
    IL_0206: call 0x0A0000E1
    IL_020B: stelem 0x80721825
    IL_020C: ret
    IL_020D: ldarg.0
    IL_0212: cpobj 0x021925A2
    IL_0217: ldfld 0x04000BD5
    IL_021C: newobj 0x0100000B
    IL_0221: stelem 0x85721A25
    IL_0222: IL_37
    IL_0223: ldarg.0
    IL_0228: cpobj 0x009628A2
    IL_0229: nop
    IL_022A: stloc.0
    IL_022F: ldstr 0x70000BC5
    IL_0234: call 0x0A0000E2
    IL_0239: call 0x0A0000E3
    IL_023A: IL_22
    IL_023B: nop
    IL_023C: nop
    IL_023D: ret
    IL_023E: IL_43
    IL_023F: IL_22
    IL_0240: nop
    IL_0241: nop
    IL_0242: IL_3E
    IL_0243: IL_43
    IL_0244: IL_22
    IL_0245: nop
    IL_0246: nop
    IL_024B: stsfld 0x00002242
    IL_024C: nop
    IL_024D: IL_42
    IL_0252: call 0x0600021D
    IL_0257: ldsfld 0x040007B2
    IL_0258: ldarg.0
    IL_025D: ldfld 0x04000BD9
    IL_025E: ldc.i4.1
    IL_0263: call 0x0A0000E1
    IL_0264: ldarg.0
    IL_0269: ldfld 0x04000BC4
    IL_026E: call 0x0A0000F1
    IL_0273: brfalse IL_03A8
    IL_0274: ldarg.0
    IL_0279: ldfld 0x04000BD4
    IL_027A: shl
    IL_027B: ldc.i4.1
    IL_0280: call 0x0600021E
    IL_0285: brfalse IL_03A3
    IL_0286: ldarg.0
    IL_0287: ldc.i4.0
    IL_028C: stfld 0x04000BD8
    IL_028D: ldarg.0
    IL_028E: IL_22
    IL_028F: nop
    IL_0290: nop
    IL_0291: nop
    IL_0292: nop
    IL_0297: stfld 0x04000BC9
    IL_0298: ldarg.0
    IL_029A: ldc.i4.s 10
    IL_029F: stfld 0x04000BD3
    IL_02A0: IL_22
    IL_02A1: nop
    IL_02A2: nop
    IL_02A7: stsfld 0x0111283F
    IL_02A8: nop
    IL_02A9: stloc.0
    IL_02AA: ldarg.0
    IL_02AF: ldfld 0x04000BCE
    IL_02B0: conv.r8
    IL_02B1: conv.u8
    IL_02B2: IL_01
    IL_02B3: nop
    IL_02B4: ldloc.0
    IL_02B5: ldarg.0
    IL_02BA: ldfld 0x04000BDA
    IL_02BB: conv.r8
    IL_02BC: IL_27
    IL_02BD: ldloc.0
    IL_02BE: nop
    IL_02BF: ldloc.0
    IL_02C0: ldarg.0
    IL_02C5: call 0x0A00000A
    IL_02C6: ldc.i4.0
    IL_02C7: conv.r8
    IL_02C8: stloc.1
    IL_02C9: nop
    IL_02CA: nop
    IL_02CB: stloc.0
    IL_02CC: ldarg.0
    IL_02CD: ldc.i4.0
    IL_02D2: stfld 0x04000BD2
    IL_02D3: ldarg.0
    IL_02D8: call 0x0A000081
    IL_02D9: ldarg.0
    IL_02DE: ldfld 0x04000BD4
    IL_02DF: stloc.0
    IL_02E0: ldc.i4.5
    IL_02E5: newarr 0x0100000C
    IL_02E6: dup
    IL_02E7: ldc.i4.0
    IL_02EC: ldsfld 0x040007B2
    IL_02ED: ldarg.0
    IL_02F2: ldfld 0x04000BD9
    IL_02F7: ldc.i4 234
    IL_02FC: call 0x0A0000E1
    IL_0301: stelem 0x89721725
    IL_0302: IL_37
    IL_0303: ldarg.0
    IL_0308: cpobj 0x021825A2
    IL_030D: ldflda 0x04000BD4
    IL_0312: call 0x0A000010
    IL_0317: stelem 0x8F721925
    IL_0318: IL_37
    IL_0319: ldarg.0
    IL_031E: cpobj 0x7E1A25A2
    IL_031F: IL_B2
    IL_0320: ldloc.1
    IL_0321: nop
    IL_0322: ldarg.2
    IL_0323: ldarg.0
    IL_0328: ldfld 0x04000BD9
    IL_032D: ldc.i4 239
    IL_0332: call 0x0A0000E1
    IL_0337: stelem 0x00024028
    IL_0338: stloc.0
    IL_033D: call 0x0600040D
    IL_033E: ldarg.0
    IL_033F: dup
    IL_0344: ldfld 0x04000BD5
    IL_0345: ldarg.0
    IL_034A: ldfld 0x04000BD4
    IL_034B: IL_59
    IL_0350: stfld 0x04000BD5
    IL_0351: ldarg.0
    IL_0356: ldfld 0x04000BC5
    IL_035B: brfalse IL_036F
    IL_035C: ldarg.0
    IL_035D: ldarg.0
    IL_0362: ldfld 0x04000BD4
    IL_0363: ldc.i4.3
    IL_0364: IL_58
    IL_0369: stfld 0x04000BD4
    IL_036E: br IL_037D
    IL_036F: ldarg.0
    IL_0370: ldarg.0
    IL_0375: ldfld 0x04000BD4
    IL_0376: ldc.i4.2
    IL_0377: IL_5A
    IL_037C: stfld 0x04000BD4
    IL_0381: ldstr 0x700004E5
    IL_0382: ldloc.0
    IL_0387: newobj 0x0100000B
    IL_038C: ldstr 0x70023795
    IL_0391: call 0x0A000098
    IL_0392: stloc.1
    IL_0397: call 0x0600004E
    IL_039C: ldstr 0x700237B3
    IL_039D: ldloc.1
    IL_039E: conv.r8
    IL_039F: IL_59
    IL_03A0: nop
    IL_03A1: nop
    IL_03A2: ldloc.0
    IL_03A7: call 0x0A000303
    IL_03AC: br IL_04AF
    IL_03AD: IL_22
    IL_03AE: nop
    IL_03AF: nop
    IL_03B0: IL_E0
    IL_03B1: IL_42
    IL_03B2: IL_22
    IL_03B3: nop
    IL_03B4: nop
    IL_03B5: ret
    IL_03B6: IL_43
    IL_03B7: IL_22
    IL_03B8: nop
    IL_03B9: nop
    IL_03BE: stsfld 0x00002243
    IL_03C3: stsfld 0x021D2841
    IL_03C4: nop
    IL_03C5: ldloc.0
    IL_03C6: ldc.i4.5
    IL_03CB: newarr 0x01000020
    IL_03CC: dup
    IL_03CD: ldc.i4.0
    IL_03D2: ldstr 0x70023781
    IL_03D7: stelem 0xB27E1725
    IL_03D8: ldloc.1
    IL_03D9: nop
    IL_03DA: ldarg.2
    IL_03DB: ldarg.0
    IL_03E0: ldfld 0x04000BD9
    IL_03E5: ldc.i4 204
    IL_03EA: call 0x0A0000E1
    IL_03EF: stelem 0x80721825
    IL_03F0: ret
    IL_03F1: ldarg.0
    IL_03F6: cpobj 0x021925A2
    IL_03FB: ldfld 0x04000BD5
    IL_0400: newobj 0x0100000B
    IL_0405: stelem 0x85721A25
    IL_0406: IL_37
    IL_0407: ldarg.0
    IL_040C: cpobj 0x009628A2
    IL_040D: nop
    IL_040E: stloc.0
    IL_0413: ldstr 0x70023389
    IL_0418: call 0x0A0000E2
    IL_041D: call 0x0A0000E3
    IL_041E: IL_22
    IL_041F: nop
    IL_0420: nop
    IL_0421: ret
    IL_0422: IL_43
    IL_0423: IL_22
    IL_0424: nop
    IL_0425: nop
    IL_0426: IL_3E
    IL_0427: IL_43
    IL_0428: IL_22
    IL_0429: nop
    IL_042A: nop
    IL_042F: stsfld 0x00002242
    IL_0430: nop
    IL_0431: IL_42
    IL_0436: call 0x0600021D
    IL_043B: ldsfld 0x040007B2
    IL_043C: ldarg.0
    IL_0441: ldfld 0x04000BD9
    IL_0446: ldc.i4 207
    IL_044B: call 0x0A0000E1
    IL_044C: ldarg.0
    IL_0451: ldfld 0x04000BC4
    IL_0456: call 0x0A0000F1
    IL_045B: brfalse IL_04AF
    IL_0460: ldstr 0x70001E8B
    IL_0461: ldc.i4.1
    IL_0466: call 0x0600021F
    IL_0467: ldarg.0
    IL_046C: ldfld 0x04000BD1
    IL_046D: ldnull
    IL_0472: call 0x0A000061
    IL_0477: brfalse IL_048D
    IL_0478: ldarg.0
    IL_047D: ldstr 0x700232DD
    IL_0482: call 0x0A000012
    IL_0483: conv.u8
    IL_0484: ldloc.0
    IL_0485: nop
    IL_0486: nop
    IL_0487: IL_01
    IL_048C: stfld 0x04000BD1
    IL_048D: ldarg.0
    IL_0492: ldfld 0x04000BD1
    IL_0493: conv.r8
    IL_0494: ldarg.3
    IL_0495: nop
    IL_0496: nop
    IL_0497: stloc.0
    IL_049C: call 0x0A00001B
    IL_04A1: call 0x0A000013
    IL_04A6: call 0x0A000014
    IL_04A7: pop
    IL_04A8: ldarg.0
    IL_04A9: ldc.i4.1
    IL_04AE: stfld 0x04000BD2
    IL_04AF: IL_22
    IL_04B0: nop
    IL_04B1: nop
    IL_04B2: conv.r.un
    IL_04B3: IL_43
    IL_04B4: IL_22
    IL_04B5: nop
    IL_04B6: nop
    IL_04B7: IL_3E
    IL_04B8: IL_43
    IL_04B9: IL_22
    IL_04BA: nop
    IL_04BB: nop
    IL_04C0: stsfld 0x00002242
    IL_04C1: nop
    IL_04C2: IL_42
    IL_04C7: call 0x0600021D
    IL_04CC: ldsfld 0x040007B2
    IL_04CD: ldarg.0
    IL_04D2: ldfld 0x04000BD9
    IL_04D3: ldc.i4.2
    IL_04D8: call 0x0A0000E1
    IL_04D9: ldarg.0
    IL_04DE: ldfld 0x04000BC4
    IL_04E3: call 0x0A0000F1
    IL_04E8: brfalse IL_0506
    IL_04E9: ldarg.0
    IL_04EA: ldc.i4.0
    IL_04EF: stfld 0x04000BD8
    IL_04F0: IL_22
    IL_04F1: nop
    IL_04F2: nop
    IL_04F7: stsfld 0x0111283F
    IL_04F8: nop
    IL_04F9: stloc.0
    IL_04FA: ldarg.0
    IL_04FF: ldfld 0x04000BDA
    IL_0500: ldc.i4.m1
    IL_0501: conv.r8
    IL_0503: starg.s 6
    IL_0504: nop
    IL_0505: ldloc.0
    IL_050A: br IL_0BB0
    IL_050B: ldarg.0
    IL_0510: ldfld 0x04000BCC
    IL_0515: brfalse IL_0581
    IL_0516: IL_22
    IL_0517: nop
    IL_0518: nop
    IL_0519: IL_E0
    IL_051A: IL_42
    IL_051B: IL_22
    IL_051C: nop
    IL_051D: nop
    IL_051E: IL_B4
    IL_051F: IL_42
    IL_0520: IL_22
    IL_0521: nop
    IL_0522: nop
    IL_0527: stsfld 0x00002243
    IL_0528: rem
    IL_0529: IL_41
    IL_052E: call 0x0600021D
    IL_0533: ldsfld 0x040007B2
    IL_0534: ldarg.0
    IL_0539: ldfld 0x04000BD9
    IL_053E: ldc.i4 434
    IL_0543: call 0x0A0000E1
    IL_0548: call 0x0A0002EA
    IL_0549: IL_22
    IL_054A: nop
    IL_054B: nop
    IL_054C: IL_E0
    IL_054D: IL_42
    IL_054E: IL_22
    IL_054F: nop
    IL_0550: nop
    IL_0552: bgt.s IL_0596
    IL_0553: IL_22
    IL_0554: nop
    IL_0555: nop
    IL_055A: stsfld 0x00002243
    IL_055C: starg.s 66
    IL_0561: call 0x0600021D
    IL_0566: ldsfld 0x040007B2
    IL_0567: ldarg.0
    IL_056C: ldfld 0x04000BD9
    IL_0571: ldc.i4 435
    IL_0576: call 0x0A0000E1
    IL_057B: call 0x0A0002EA
    IL_0580: br IL_0BB0
    IL_0581: ldarg.0
    IL_0586: ldfld 0x04000BD7
    IL_058B: brfalse IL_0A75
    IL_058C: ldarg.0
    IL_0591: ldfld 0x04000BCA
    IL_0596: brfalse IL_05E3
    IL_0597: ldarg.0
    IL_059C: call 0x0A0000D7
    IL_059D: stloc.3
    IL_059F: ldloca.s 3
    IL_05A4: ldfld 0x0A00005E
    IL_05A5: IL_22
    IL_05A6: nop
    IL_05A7: nop
    IL_05A8: IL_F0
    IL_05A9: IL_43
    IL_05AE: call 0x0A0000D9
    IL_05AF: conv.i2
    IL_05B0: add
    IL_05B1: IL_5A
    IL_05B2: IL_22
    IL_05B3: nop
    IL_05B4: nop
    IL_05B5: IL_56
    IL_05B6: IL_43
    IL_05B7: IL_59
    IL_05B8: IL_22
    IL_05B9: nop
    IL_05BA: nop
    IL_05BB: IL_FC
    IL_05BC: IL_42
    IL_05BD: add
    IL_05C2: stfld 0x04000BC7
    IL_05C3: ldarg.0
    IL_05C4: ldarg.0
    IL_05C9: ldfld 0x04000BC7
    IL_05CA: IL_22
    IL_05CB: nop
    IL_05CC: nop
    IL_05CD: nop
    IL_05CE: nop
    IL_05CF: IL_22
    IL_05D0: nop
    IL_05D1: nop
    IL_05D6: stsfld 0x00D4283F
    IL_05D7: nop
    IL_05D8: stloc.0
    IL_05DD: stfld 0x04000BC7
    IL_05E2: br IL_0636
    IL_05E3: ldarg.0
    IL_05E8: ldfld 0x04000BCB
    IL_05ED: brfalse IL_0636
    IL_05EE: ldarg.0
    IL_05F3: call 0x0A0000D7
    IL_05F5: stloc.s 4
    IL_05F7: ldloca.s 4
    IL_05FC: ldfld 0x0A00005E
    IL_05FD: IL_22
    IL_05FE: nop
    IL_05FF: nop
    IL_0600: IL_F0
    IL_0601: IL_43
    IL_0606: call 0x0A0000D9
    IL_0607: conv.i2
    IL_0608: add
    IL_0609: IL_5A
    IL_060A: IL_22
    IL_060B: nop
    IL_060C: nop
    IL_060D: IL_56
    IL_060E: IL_43
    IL_060F: IL_59
    IL_0610: IL_22
    IL_0611: nop
    IL_0612: nop
    IL_0613: IL_FC
    IL_0614: IL_42
    IL_0615: add
    IL_061A: stfld 0x04000BC8
    IL_061B: ldarg.0
    IL_061C: ldarg.0
    IL_0621: ldfld 0x04000BC8
    IL_0622: IL_22
    IL_0623: nop
    IL_0624: nop
    IL_0625: nop
    IL_0626: nop
    IL_0627: IL_22
    IL_0628: nop
    IL_0629: nop
    IL_062E: stsfld 0x00D4283F
    IL_062F: nop
    IL_0630: stloc.0
    IL_0635: stfld 0x04000BC8
    IL_0636: IL_22
    IL_0637: nop
    IL_0638: nop
    IL_0639: nop
    IL_063A: nop
    IL_063B: IL_22
    IL_063C: nop
    IL_063D: nop
    IL_063E: nop
    IL_063F: nop
    IL_0640: IL_22
    IL_0641: nop
    IL_0642: nop
    IL_0643: IL_F0
    IL_0644: IL_43
    IL_0645: IL_22
    IL_0646: nop
    IL_0647: nop
    IL_0648: ldelem.r8
    IL_0649: IL_43
    IL_064E: call 0x0600021D
    IL_064F: ldarg.0
    IL_0654: ldfld 0x04000BB1
    IL_0659: call 0x0A0000E0
    IL_065A: IL_22
    IL_065B: nop
    IL_065C: nop
    IL_065D: IL_E0
    IL_065E: IL_42
    IL_065F: IL_22
    IL_0660: nop
    IL_0661: nop
    IL_0666: cpobj 0x00002242
    IL_066B: stsfld 0x00002243
    IL_0670: stsfld 0x021D2843
    IL_0671: nop
    IL_0672: ldloc.0
    IL_0673: ldarg.0
    IL_0678: ldfld 0x04000BB2
    IL_067D: call 0x0A0000E0
    IL_067E: IL_22
    IL_067F: nop
    IL_0680: nop
    IL_0681: nop
    IL_0682: IL_43
    IL_0683: IL_22
    IL_0684: nop
    IL_0685: nop
    IL_068A: isinst 0x00002242
    IL_068F: newobj 0x00002242
    IL_0694: stsfld 0x021D2841
    IL_0695: nop
    IL_0696: ldloc.0
    IL_069B: ldsfld 0x040007B2
    IL_069C: ldarg.0
    IL_06A1: ldfld 0x04000BD9
    IL_06A6: ldc.i4 302
    IL_06AB: call 0x0A0000E1
    IL_06B0: ldstr 0x70000BC5
    IL_06B5: call 0x0A0000E2
    IL_06BA: call 0x0A0000E3
    IL_06BB: IL_22
    IL_06BC: nop
    IL_06BD: nop
    IL_06BE: nop
    IL_06BF: IL_43
    IL_06C0: IL_22
    IL_06C1: nop
    IL_06C2: nop
    IL_06C3: IL_EC
    IL_06C4: IL_42
    IL_06C5: IL_22
    IL_06C6: nop
    IL_06C7: nop
    IL_06CC: newobj 0x00002242
    IL_06D1: stsfld 0x021D2841
    IL_06D2: nop
    IL_06D3: ldloc.0
    IL_06D8: ldsfld 0x040007B2
    IL_06D9: ldarg.0
    IL_06DE: ldfld 0x04000BD9
    IL_06E3: ldc.i4 244
    IL_06E8: call 0x0A0000E1
    IL_06ED: ldstr 0x70000BC5
    IL_06F2: call 0x0A0000E2
    IL_06F7: call 0x0A0000E3
    IL_06F8: IL_22
    IL_06F9: nop
    IL_06FA: nop
    IL_06FB: nop
    IL_06FC: IL_43
    IL_06FD: IL_22
    IL_06FE: nop
    IL_06FF: nop
    IL_0700: ldc.i4.5
    IL_0701: IL_43
    IL_0702: IL_22
    IL_0703: nop
    IL_0704: nop
    IL_0709: newobj 0x00002242
    IL_070E: stsfld 0x021D2841
    IL_070F: nop
    IL_0710: ldloc.0
    IL_0715: ldsfld 0x040007B2
    IL_0716: ldarg.0
    IL_071B: ldfld 0x04000BD9
    IL_071D: ldc.i4.s 90
    IL_0722: call 0x0A0000E1
    IL_0727: ldstr 0x70000BC5
    IL_072C: call 0x0A0000E2
    IL_0731: call 0x0A0000E3
    IL_0732: IL_22
    IL_0733: nop
    IL_0734: nop
    IL_0735: nop
    IL_0736: IL_43
    IL_0737: IL_22
    IL_0738: nop
    IL_0739: nop
    IL_073A: IL_42
    IL_073B: IL_43
    IL_073C: IL_22
    IL_073D: nop
    IL_073E: nop
    IL_0743: newobj 0x00002242
    IL_0748: stsfld 0x021D2841
    IL_0749: nop
    IL_074A: ldloc.0
    IL_074F: ldsfld 0x040007B2
    IL_0750: ldarg.0
    IL_0755: ldfld 0x04000BD9
    IL_075A: ldc.i4 245
    IL_075F: call 0x0A0000E1
    IL_0764: ldstr 0x70000BC5
    IL_0769: call 0x0A0000E2
    IL_076E: call 0x0A0000E3
    IL_076F: IL_22
    IL_0770: nop
    IL_0771: nop
    IL_0772: IL_54
    IL_0773: IL_43
    IL_0774: IL_22
    IL_0775: nop
    IL_0776: nop
    IL_077B: brtrue IL_29BF
    IL_077C: nop
    IL_077D: IL_43
    IL_077E: IL_22
    IL_077F: nop
    IL_0780: nop
    IL_0781: nop
    IL_0782: IL_42
    IL_0787: call 0x0600021D
    IL_078C: ldsfld 0x040007B2
    IL_078D: ldarg.0
    IL_0792: ldfld 0x04000BD9
    IL_0797: ldc.i4 246
    IL_079C: call 0x0A0000E1
    IL_079D: ldarg.0
    IL_07A2: ldfld 0x04000BC2
    IL_07A7: call 0x0A0000F1
    IL_07AC: brfalse IL_07CF
    IL_07AD: ldc.i4.2
    IL_07AE: stloc.2
    IL_07AF: ldarg.0
    IL_07B0: ldarg.0
    IL_07B5: ldfld 0x04000BD9
    IL_07B6: ldc.i4.1
    IL_07B7: IL_58
    IL_07B8: ldloc.2
    IL_07B9: mul
    IL_07BE: stfld 0x04000BD9
    IL_07C3: ldstr 0x70000BB3
    IL_07C4: ldarg.0
    IL_07C9: ldfld 0x04000BD9
    IL_07CE: call 0x0A00009F
    IL_07CF: IL_22
    IL_07D0: nop
    IL_07D1: nop
    IL_07D4: ldloc 8771
    IL_07D5: nop
    IL_07D6: nop
    IL_07D7: IL_98
    IL_07D8: IL_42
    IL_07D9: IL_22
    IL_07DA: nop
    IL_07DB: nop
    IL_07DC: ldc.i4.2
    IL_07DD: IL_43
    IL_07DE: IL_22
    IL_07DF: nop
    IL_07E0: nop
    IL_07E1: nop
    IL_07E2: IL_42
    IL_07E7: call 0x0600021D
    IL_07EC: ldsfld 0x0A000099
    IL_07ED: ldarg.0
    IL_07F2: ldfld 0x04000BC3
    IL_07F7: call 0x0A0002E8
    IL_07FC: brfalse IL_0809
    IL_07FD: ldarg.0
    IL_07FE: ldc.i4.1
    IL_0803: stfld 0x04000BCB
    IL_0808: br IL_0826
    IL_0809: ldarg.0
    IL_080E: ldfld 0x04000BCB
    IL_0813: brfalse IL_0826
    IL_0814: ldarg.0
    IL_0819: ldfld 0x04000BC8
    IL_081E: call 0x0A0001C2
    IL_081F: ldarg.0
    IL_0820: ldc.i4.0
    IL_0825: stfld 0x04000BCB
    IL_0826: ldarg.0
    IL_082B: ldfld 0x04000BC8
    IL_082C: IL_22
    IL_082D: nop
    IL_082E: nop
    IL_082F: IL_FC
    IL_0830: IL_42
    IL_0831: IL_5A
    IL_0832: IL_22
    IL_0833: nop
    IL_0834: nop
    IL_0835: IL_4E
    IL_0836: IL_43
    IL_0837: IL_58
    IL_0838: IL_22
    IL_0839: nop
    IL_083A: nop
    IL_083B: IL_A8
    IL_083C: IL_42
    IL_083D: IL_22
    IL_083E: nop
    IL_083F: nop
    IL_0844: stsfld 0x00002241
    IL_0849: stsfld 0x021D2841
    IL_084A: nop
    IL_084B: ldloc.0
    IL_084C: ldarg.0
    IL_0851: ldfld 0x04000BB3
    IL_0856: call 0x0A0000E0
    IL_0857: IL_22
    IL_0858: nop
    IL_0859: nop
    IL_085C: ldloc 8771
    IL_085D: nop
    IL_085E: nop
    IL_085F: IL_DE
    IL_0860: IL_42
    IL_0861: IL_22
    IL_0862: nop
    IL_0863: nop
    IL_0864: ldc.i4.2
    IL_0865: IL_43
    IL_0866: IL_22
    IL_0867: nop
    IL_0868: nop
    IL_0869: nop
    IL_086A: IL_42
    IL_086F: call 0x0600021D
    IL_0874: ldsfld 0x0A000099
    IL_0875: ldarg.0
    IL_087A: ldfld 0x04000BC3
    IL_087F: call 0x0A0002E8
    IL_0884: brfalse IL_0891
    IL_0885: ldarg.0
    IL_0886: ldc.i4.1
    IL_088B: stfld 0x04000BCA
    IL_0890: br IL_08B4
    IL_0891: ldarg.0
    IL_0896: ldfld 0x04000BCA
    IL_089B: brfalse IL_08B4
    IL_089C: ldarg.0
    IL_08A1: ldfld 0x04000BCF
    IL_08A2: ldarg.0
    IL_08A7: ldfld 0x04000BC7
    IL_08A8: conv.r8
    IL_08A9: IL_F8
    IL_08AA: ldarg.2
    IL_08AB: nop
    IL_08AC: ldloc.0
    IL_08AD: ldarg.0
    IL_08AE: ldc.i4.0
    IL_08B3: stfld 0x04000BCA
    IL_08B4: ldarg.0
    IL_08B9: ldfld 0x04000BC7
    IL_08BA: IL_22
    IL_08BB: nop
    IL_08BC: nop
    IL_08BD: IL_FC
    IL_08BE: IL_42
    IL_08BF: IL_5A
    IL_08C0: IL_22
    IL_08C1: nop
    IL_08C2: nop
    IL_08C3: IL_4E
    IL_08C4: IL_43
    IL_08C5: IL_58
    IL_08C6: IL_22
    IL_08C7: nop
    IL_08C8: nop
    IL_08C9: IL_EE
    IL_08CA: IL_42
    IL_08CB: IL_22
    IL_08CC: nop
    IL_08CD: nop
    IL_08D2: stsfld 0x00002241
    IL_08D7: stsfld 0x021D2841
    IL_08D8: nop
    IL_08D9: ldloc.0
    IL_08DA: ldarg.0
    IL_08DF: ldfld 0x04000BB3
    IL_08E4: call 0x0A0000E0
    IL_08E5: IL_22
    IL_08E6: nop
    IL_08E7: nop
    IL_08E8: IL_50
    IL_08E9: IL_43
    IL_08EA: IL_22
    IL_08EB: nop
    IL_08EC: nop
    IL_08ED: div.un
    IL_08EE: IL_43
    IL_08EF: IL_22
    IL_08F0: nop
    IL_08F1: nop
    IL_08F6: stsfld 0x00002242
    IL_08F7: nop
    IL_08F8: IL_42
    IL_08FD: call 0x0600021D
    IL_0902: ldsfld 0x040007B2
    IL_0903: ldarg.0
    IL_0908: ldfld 0x04000BD9
    IL_0909: ldc.i4.0
    IL_090E: call 0x0A0000E1
    IL_090F: ldarg.0
    IL_0914: ldfld 0x04000BC4
    IL_0919: call 0x0A0000F1
    IL_091E: brfalse IL_0946
    IL_091F: ldarg.0
    IL_0920: ldc.i4.0
    IL_0925: stfld 0x04000BD7
    IL_092A: ldstr 0x70022774
    IL_092B: ldarg.0
    IL_0930: ldfld 0x04000BC7
    IL_0935: call 0x0A000255
    IL_093A: ldstr 0x7002270C
    IL_093B: ldarg.0
    IL_0940: ldfld 0x04000BC8
    IL_0945: call 0x0A000255
    IL_0946: IL_22
    IL_0947: nop
    IL_0948: nop
    IL_0949: IL_56
    IL_094A: IL_43
    IL_094B: IL_22
    IL_094C: nop
    IL_094D: nop
    IL_094F: stloc.s 67
    IL_0950: IL_22
    IL_0951: nop
    IL_0952: nop
    IL_0953: nop
    IL_0954: IL_42
    IL_0955: IL_22
    IL_0956: nop
    IL_0957: nop
    IL_0958: nop
    IL_0959: IL_42
    IL_095E: call 0x0600021D
    IL_0963: ldstr 0x700237CB
    IL_0964: ldarg.0
    IL_0969: ldfld 0x04000BC1
    IL_096E: call 0x0A0000F1
    IL_0973: brfalse IL_09BF
    IL_0974: ldarg.0
    IL_0979: ldfld 0x04000BDC
    IL_097A: ldc.i4.0
    IL_097B: IL_3E
    IL_0980: brtrue IL_2000981
    IL_0981: dup
    IL_0986: ldfld 0x04000BDC
    IL_0987: ldc.i4.1
    IL_0988: IL_59
    IL_098D: stfld 0x04000BDC
    IL_0992: call 0x0A000035
    IL_0993: conv.r8
    IL_0994: ldloc.0
    IL_0995: nop
    IL_0996: nop
    IL_0998: br.s IL_099B
    IL_099D: ldfld 0x04000BDC
    IL_099F: ldc.i4.s -2
    IL_09A0: IL_5A
    IL_09A2: ldc.i4.s 30
    IL_09A3: IL_58
    IL_09A4: conv.i2
    IL_09A5: conv.r8
    IL_09A7: blt.s IL_09A9
    IL_09A8: nop
    IL_09A9: ldloc.0
    IL_09AE: ldstr 0x70001E7D
    IL_09AF: ldarg.0
    IL_09B4: ldfld 0x04000BDC
    IL_09B9: call 0x0600021F
    IL_09BE: br IL_0A33
    IL_09BF: IL_22
    IL_09C0: nop
    IL_09C1: nop
    IL_09C2: ldelem.i
    IL_09C3: IL_43
    IL_09C4: IL_22
    IL_09C5: nop
    IL_09C6: nop
    IL_09C8: stloc.s 67
    IL_09C9: IL_22
    IL_09CA: nop
    IL_09CB: nop
    IL_09CC: nop
    IL_09CD: IL_42
    IL_09CE: IL_22
    IL_09CF: nop
    IL_09D0: nop
    IL_09D1: nop
    IL_09D2: IL_42
    IL_09D7: call 0x0600021D
    IL_09DC: ldstr 0x700237CF
    IL_09DD: ldarg.0
    IL_09E2: ldfld 0x04000BC1
    IL_09E7: call 0x0A0000F1
    IL_09EC: brfalse IL_0A33
    IL_09ED: ldarg.0
    IL_09F2: ldfld 0x04000BDC
    IL_09F3: ldc.i4.5
    IL_09F4: IL_3C
    IL_09F9: brtrue IL_20009FA
    IL_09FA: dup
    IL_09FF: ldfld 0x04000BDC
    IL_0A00: ldc.i4.1
    IL_0A01: IL_58
    IL_0A06: stfld 0x04000BDC
    IL_0A0B: call 0x0A000035
    IL_0A0C: conv.r8
    IL_0A0D: ldloc.0
    IL_0A0E: nop
    IL_0A0F: nop
    IL_0A11: br.s IL_0A14
    IL_0A16: ldfld 0x04000BDC
    IL_0A18: ldc.i4.s -2
    IL_0A19: IL_5A
    IL_0A1B: ldc.i4.s 30
    IL_0A1C: IL_58
    IL_0A1D: conv.i2
    IL_0A1E: conv.r8
    IL_0A20: blt.s IL_0A22
    IL_0A21: nop
    IL_0A22: ldloc.0
    IL_0A27: ldstr 0x70001E7D
    IL_0A28: ldarg.0
    IL_0A2D: ldfld 0x04000BDC
    IL_0A32: call 0x0600021F
    IL_0A33: IL_22
    IL_0A34: nop
    IL_0A35: nop
    IL_0A36: IL_82
    IL_0A37: IL_43
    IL_0A38: IL_22
    IL_0A39: nop
    IL_0A3A: nop
    IL_0A3C: stloc.s 67
    IL_0A3D: IL_22
    IL_0A3E: nop
    IL_0A3F: nop
    IL_0A40: nop
    IL_0A41: IL_42
    IL_0A42: IL_22
    IL_0A43: nop
    IL_0A44: nop
    IL_0A45: nop
    IL_0A46: IL_42
    IL_0A4B: call 0x0600021D
    IL_0A50: ldstr 0x700237D3
    IL_0A51: ldarg.0
    IL_0A56: ldfld 0x04000BDC
    IL_0A5B: newobj 0x0100000B
    IL_0A60: call 0x0A00009A
    IL_0A65: ldstr 0x70000BC5
    IL_0A6A: call 0x0A0000E2
    IL_0A6F: call 0x0A0000E3
    IL_0A74: br IL_0BB0
    IL_0A75: ldarg.0
    IL_0A7A: ldfld 0x04000BD6
    IL_0A7F: brfalse IL_0BB0
    IL_0A80: IL_22
    IL_0A81: nop
    IL_0A82: nop
    IL_0A83: nop
    IL_0A84: nop
    IL_0A85: IL_22
    IL_0A86: nop
    IL_0A87: nop
    IL_0A88: nop
    IL_0A89: nop
    IL_0A8A: IL_22
    IL_0A8B: nop
    IL_0A8C: nop
    IL_0A8D: IL_F0
    IL_0A8E: IL_43
    IL_0A8F: IL_22
    IL_0A90: nop
    IL_0A91: nop
    IL_0A92: ldelem.r8
    IL_0A93: IL_43
    IL_0A98: call 0x0600021D
    IL_0A99: ldarg.0
    IL_0A9E: ldfld 0x04000BB1
    IL_0AA3: call 0x0A0000E0
    IL_0AA4: IL_22
    IL_0AA5: nop
    IL_0AA6: nop
    IL_0AA7: IL_E0
    IL_0AA8: IL_42
    IL_0AA9: IL_22
    IL_0AAA: nop
    IL_0AAB: nop
    IL_0AAC: ldelem.r8
    IL_0AAD: IL_42
    IL_0AAE: IL_22
    IL_0AAF: nop
    IL_0AB0: nop
    IL_0AB5: stsfld 0x00002243
    IL_0ABA: stsfld 0x021D2842
    IL_0ABB: nop
    IL_0ABC: ldloc.0
    IL_0AC1: ldsfld 0x040007B2
    IL_0AC2: ldarg.0
    IL_0AC7: ldfld 0x04000BD9
    IL_0AC9: ldc.i4.s 30
    IL_0ACE: call 0x0A0000E1
    IL_0ACF: ldarg.0
    IL_0AD4: ldfld 0x04000BB0
    IL_0AD9: call 0x0A0000F1
    IL_0ADE: brfalse IL_0B11
    IL_0ADF: IL_22
    IL_0AE0: nop
    IL_0AE1: nop
    IL_0AE6: stsfld 0x0111283F
    IL_0AE7: nop
    IL_0AE8: stloc.0
    IL_0AE9: ldarg.0
    IL_0AEA: ldc.i4.0
    IL_0AEF: stfld 0x04000BD6
    IL_0AF0: ldarg.0
    IL_0AF5: ldfld 0x04000BCE
    IL_0AF6: conv.r8
    IL_0AF7: conv.u4
    IL_0AF8: IL_01
    IL_0AF9: nop
    IL_0AFA: ldloc.0
    IL_0AFB: ldarg.0
    IL_0B00: call 0x0A00000A
    IL_0B01: ldc.i4.0
    IL_0B02: conv.r8
    IL_0B03: stloc.1
    IL_0B04: nop
    IL_0B05: nop
    IL_0B06: stloc.0
    IL_0B0B: call 0x0A000303
    IL_0B10: br IL_0BB0
    IL_0B11: IL_22
    IL_0B12: nop
    IL_0B13: nop
    IL_0B14: IL_E0
    IL_0B15: IL_42
    IL_0B16: IL_22
    IL_0B17: nop
    IL_0B18: nop
    IL_0B19: ldarg.0
    IL_0B1A: IL_43
    IL_0B1B: IL_22
    IL_0B1C: nop
    IL_0B1D: nop
    IL_0B22: stsfld 0x00002243
    IL_0B27: stsfld 0x021D2842
    IL_0B28: nop
    IL_0B29: ldloc.0
    IL_0B2E: ldsfld 0x040007B2
    IL_0B2F: ldarg.0
    IL_0B34: ldfld 0x04000BD9
    IL_0B36: ldc.i4.s 31
    IL_0B3B: call 0x0A0000E1
    IL_0B3C: ldarg.0
    IL_0B41: ldfld 0x04000BB0
    IL_0B46: call 0x0A0000F1
    IL_0B4B: brfalse IL_0B58
    IL_0B4C: ldarg.0
    IL_0B4D: ldc.i4.1
    IL_0B52: stfld 0x04000BD7
    IL_0B57: br IL_0BB0
    IL_0B58: IL_22
    IL_0B59: nop
    IL_0B5A: nop
    IL_0B5B: IL_E0
    IL_0B5C: IL_42
    IL_0B5D: IL_22
    IL_0B5E: nop
    IL_0B5F: nop
    IL_0B60: IL_34
    IL_0B61: IL_43
    IL_0B62: IL_22
    IL_0B63: nop
    IL_0B64: nop
    IL_0B69: stsfld 0x00002243
    IL_0B6E: stsfld 0x021D2842
    IL_0B6F: nop
    IL_0B70: ldloc.0
    IL_0B75: ldsfld 0x040007B2
    IL_0B76: ldarg.0
    IL_0B7B: ldfld 0x04000BD9
    IL_0B7D: ldc.i4.s 59
    IL_0B82: call 0x0A0000E1
    IL_0B83: ldarg.0
    IL_0B88: ldfld 0x04000BB0
    IL_0B8D: call 0x0A0000F1
    IL_0B92: brfalse IL_0BB0
    IL_0B93: IL_22
    IL_0B94: nop
    IL_0B95: nop
    IL_0B9A: stsfld 0x0111283F
    IL_0B9B: nop
    IL_0B9C: stloc.0
    IL_0B9D: ldarg.0
    IL_0B9E: ldc.i4.0
    IL_0BA3: stfld 0x04000BD6
    IL_0BA4: ldarg.0
    IL_0BA9: ldfld 0x04000BDA
    IL_0BAA: ldc.i4.m1
    IL_0BAB: conv.r8
    IL_0BAD: starg.s 6
    IL_0BAE: nop
    IL_0BAF: ldloc.0
    IL_0BB0: ldarg.0
    IL_0BB5: ldfld 0x04000BB8
    IL_0BBA: brfalse IL_0DA9
    IL_0BBB: IL_22
    IL_0BBC: nop
    IL_0BBD: nop
    IL_0BBE: IL_E0
    IL_0BBF: IL_42
    IL_0BC0: IL_22
    IL_0BC1: nop
    IL_0BC2: nop
    IL_0BC3: IL_C0
    IL_0BC4: IL_42
    IL_0BC5: IL_22
    IL_0BC6: nop
    IL_0BC7: nop
    IL_0BCC: stsfld 0x00002243
    IL_0BCD: nop
    IL_0BCE: IL_43
    IL_0BD3: call 0x0600021D
    IL_0BD4: ldarg.0
    IL_0BD9: ldfld 0x04000BB5
    IL_0BDE: call 0x0A0000E0
    IL_0BDF: IL_22
    IL_0BE0: nop
    IL_0BE1: nop
    IL_0BE2: IL_F0
    IL_0BE3: IL_42
    IL_0BE4: IL_22
    IL_0BE5: nop
    IL_0BE6: nop
    IL_0BE7: IL_CC
    IL_0BE8: IL_42
    IL_0BE9: IL_22
    IL_0BEA: nop
    IL_0BEB: nop
    IL_0BF0: cpobj 0x00002243
    IL_0BF2: starg.s 66
    IL_0BF7: call 0x0600021D
    IL_0BFC: ldsfld 0x0A000099
    IL_0C01: ldsfld 0x040007B2
    IL_0C02: ldarg.0
    IL_0C07: ldfld 0x04000BD9
    IL_0C08: ldarg.0
    IL_0C0D: ldfld 0x04000BBC
    IL_0C12: call 0x0A0000E1
    IL_0C17: call 0x0A000011
    IL_0C1C: ldstr 0x70000C43
    IL_0C21: call 0x0A0000E2
    IL_0C26: call 0x0A0000E3
    IL_0C27: IL_22
    IL_0C28: nop
    IL_0C29: nop
    IL_0C2A: IL_EC
    IL_0C2B: IL_42
    IL_0C2C: IL_22
    IL_0C2D: nop
    IL_0C2E: nop
    IL_0C31: ldloc 8771
    IL_0C32: nop
    IL_0C33: nop
    IL_0C34: conv.u4
    IL_0C35: IL_43
    IL_0C36: IL_22
    IL_0C37: nop
    IL_0C38: nop
    IL_0C39: rem
    IL_0C3A: IL_41
    IL_0C3F: call 0x0600021D
    IL_0C40: ldc.i4.4
    IL_0C45: newarr 0x01000020
    IL_0C46: dup
    IL_0C47: ldc.i4.0
    IL_0C4C: ldsfld 0x0A000099
    IL_0C51: stelem 0x7B021725
    IL_0C52: IL_BB
    IL_0C53: stloc.1
    IL_0C54: nop
    IL_0C55: ldarg.2
    IL_0C56: ldc.i4.1
    IL_0C57: IL_58
    IL_0C5C: newobj 0x0100000B
    IL_0C61: stelem 0xD9721825
    IL_0C62: IL_37
    IL_0C63: ldarg.0
    IL_0C68: cpobj 0x021925A2
    IL_0C6D: ldfld 0x04000BBA
    IL_0C72: newobj 0x0100000B
    IL_0C77: stelem 0x00009628
    IL_0C78: stloc.0
    IL_0C7D: ldstr 0x70000C43
    IL_0C82: call 0x0A0000E2
    IL_0C87: call 0x0A0000E3
    IL_0C88: ldarg.0
    IL_0C8D: ldfld 0x04000BBF
    IL_0C8E: ldarg.0
    IL_0C93: ldfld 0x04000BB7
    IL_0C98: call 0x0A0000E0
    IL_0C99: ldarg.0
    IL_0C9E: ldfld 0x04000BBD
    IL_0CA3: brfalse IL_0CD4
    IL_0CA4: ldarg.0
    IL_0CA9: ldflda 0x04000BBE
    IL_0CAE: ldfld 0x0A000059
    IL_0CAF: ldarg.0
    IL_0CB4: ldflda 0x04000BBE
    IL_0CB9: ldfld 0x0A00005A
    IL_0CBA: IL_22
    IL_0CBB: nop
    IL_0CBC: nop
    IL_0CC1: stsfld 0x00002242
    IL_0CC6: stsfld 0x021D2842
    IL_0CC7: nop
    IL_0CC8: ldloc.0
    IL_0CC9: ldarg.0
    IL_0CCE: ldfld 0x04000BB6
    IL_0CD3: call 0x0A0000E0
    IL_0CD4: ldarg.0
    IL_0CD9: ldfld 0x04000BBA
    IL_0CDA: ldc.i4.1
    IL_0CDB: IL_59
    IL_0CDC: ldarg.0
    IL_0CE1: ldfld 0x04000BBB
    IL_0CE2: IL_3D
    IL_0CE3: shr.un
    IL_0CE4: nop
    IL_0CE5: nop
    IL_0CE6: nop
    IL_0CE7: IL_22
    IL_0CE8: nop
    IL_0CE9: nop
    IL_0CEA: IL_91
    IL_0CEB: IL_43
    IL_0CEC: IL_22
    IL_0CED: nop
    IL_0CEE: nop
    IL_0CF3: br IL_2F37
    IL_0CF8: stsfld 0x00002242
    IL_0CF9: nop
    IL_0CFA: IL_42
    IL_0CFF: call 0x0600021D
    IL_0D04: ldsfld 0x040007B2
    IL_0D05: ldarg.0
    IL_0D0A: ldfld 0x04000BD9
    IL_0D0B: ldc.i4.4
    IL_0D10: call 0x0A0000E1
    IL_0D11: ldarg.0
    IL_0D16: ldfld 0x04000BC4
    IL_0D1B: call 0x0A0000F1
    IL_0D20: brfalse IL_0D49
    IL_0D21: ldarg.0
    IL_0D22: ldc.i4.0
    IL_0D27: stfld 0x04000BB8
    IL_0D28: IL_22
    IL_0D29: nop
    IL_0D2A: nop
    IL_0D2F: stsfld 0x0111283F
    IL_0D30: nop
    IL_0D31: stloc.0
    IL_0D32: ldarg.0
    IL_0D37: call 0x0A00000A
    IL_0D38: ldc.i4.0
    IL_0D39: conv.r8
    IL_0D3A: stloc.1
    IL_0D3B: nop
    IL_0D3C: nop
    IL_0D3D: stloc.0
    IL_0D3E: ldarg.0
    IL_0D43: ldfld 0x04000BCE
    IL_0D44: conv.r8
    IL_0D45: conv.u4
    IL_0D46: IL_01
    IL_0D47: nop
    IL_0D48: ldloc.0
    IL_0D4D: br IL_0DA9
    IL_0D4E: IL_22
    IL_0D4F: nop
    IL_0D50: nop
    IL_0D51: IL_91
    IL_0D52: IL_43
    IL_0D53: IL_22
    IL_0D54: nop
    IL_0D55: nop
    IL_0D5A: br IL_2F9E
    IL_0D5F: stsfld 0x00002242
    IL_0D60: nop
    IL_0D61: IL_42
    IL_0D66: call 0x0600021D
    IL_0D6B: ldsfld 0x040007B2
    IL_0D6C: ldarg.0
    IL_0D71: ldfld 0x04000BD9
    IL_0D73: ldc.i4.s 47
    IL_0D78: call 0x0A0000E1
    IL_0D79: ldarg.0
    IL_0D7E: ldfld 0x04000BC4
    IL_0D83: call 0x0A0000F1
    IL_0D88: brfalse IL_0DA9
    IL_0D89: ldarg.0
    IL_0D8A: dup
    IL_0D8F: ldfld 0x04000BBB
    IL_0D90: ldc.i4.1
    IL_0D91: IL_58
    IL_0D96: stfld 0x04000BBB
    IL_0D97: ldarg.0
    IL_0D98: ldarg.0
    IL_0D9D: ldfld 0x04000BB9
    IL_0D9E: ldarg.0
    IL_0DA3: ldfld 0x04000BBB
    IL_0DA8: call 0x06000636
    IL_0DA9: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 100
    IL_0007: stfld 0x04000BDE
    IL_0008: ldarg.0
    IL_0009: IL_22
    IL_000A: nop
    IL_000B: nop
    IL_000C: IL_C8
    IL_000D: IL_42
    IL_0012: stfld 0x04000BE0
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0019: stfld 0x04000BE2
    IL_001A: ldarg.0
    IL_001B: ldc.i4.m1
    IL_0020: stfld 0x04000BE5
    IL_0021: ldarg.0
    IL_0022: ldc.i4.4
    IL_0027: newarr 0x0100000C
    IL_002C: stfld 0x04000BEE
    IL_002D: ldarg.0
    IL_002E: ldc.i4.4
    IL_0033: newarr 0x0100003C
    IL_0038: stfld 0x04000BEF
    IL_0039: ldarg.0
    IL_003A: ldc.i4.1
    IL_003F: stfld 0x04000BF3
    IL_0040: ldarg.0
    IL_0045: call 0x0A000001
    IL_0046: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000BFA
    IL_0010: ldarg.0
    IL_0012: ldc.i4.s 100
    IL_0017: stfld 0x04000BDE
    IL_0018: ldarg.0
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_001C: IL_C8
    IL_001D: IL_42
    IL_0022: stfld 0x04000BE0
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000BE7
    IL_002A: conv.r8
    IL_002B: IL_37
    IL_002C: nop
    IL_002D: nop
    IL_002F: br.s IL_00AD
    IL_0030: IL_E9
    IL_0031: stloc.1
    IL_0032: nop
    IL_0033: ldarg.2
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000BE9
    IL_003A: IL_22
    IL_003B: nop
    IL_003C: nop
    IL_0041: stsfld 0x0000223E
    IL_0046: stsfld 0x0038733E
    IL_0047: nop
    IL_0048: stloc.0
    IL_0049: IL_22
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: nop
    IL_004E: IL_22
    IL_004F: IL_CD
    IL_0050: IL_CC
    IL_0051: IL_AC
    IL_0052: IL_BF
    IL_0053: IL_22
    IL_0054: shr
    IL_0055: shr
    IL_0056: IL_36
    IL_00E3: switch (34 cases)
    IL_00E4: IL_FF
    IL_00E5: ldarg.0
    IL_00E6: nop
    IL_00EB: cpobj 0x4CCCCD22
    IL_00EC: IL_3E
    IL_00ED: ldc.i4.0
    IL_00EE: conv.r8
    IL_00EF: IL_95
    IL_00F0: ldarg.1
    IL_00F1: nop
    IL_00F2: ldloc.0
    IL_00F3: stloc.0
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x04000BE9
    IL_00FA: IL_22
    IL_00FB: ldnull
    IL_00FC: IL_AE
    IL_00FD: IL_87
    IL_00FE: IL_3F
    IL_00FF: IL_22
    IL_0100: IL_CD
    IL_0101: IL_CC
    IL_0102: IL_4C
    IL_0103: IL_3D
    IL_0108: newobj 0x0A000038
    IL_0109: IL_22
    IL_010A: nop
    IL_010B: nop
    IL_010C: nop
    IL_010D: nop
    IL_010E: IL_22
    IL_010F: IL_A4
    IL_0114: cpobj 0x6622BF2D
    IL_0115: shr
    IL_0116: IL_36
    IL_3999999A3: switch (3865470498 cases)
    }

    public void ResetPower() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000BF5
    IL_0007: ldarg.0
    IL_0008: IL_22
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: nop
    IL_0011: stfld 0x04000BF4
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000BED
    IL_001C: call 0x0A000057
    IL_001D: conv.r8
    IL_001E: IL_F3
    IL_001F: ldarg.0
    IL_0020: nop
    IL_0021: ldloc.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000BE8
    IL_0028: conv.r8
    IL_0029: stloc.0
    IL_002A: nop
    IL_002B: nop
    IL_002C: stloc.0
    IL_002D: ldc.i4.0
    IL_002E: conv.r8
    IL_002F: stloc.1
    IL_0030: nop
    IL_0031: nop
    IL_0032: stloc.0
    IL_0033: ret
    }

    public void PowerCharge() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000BF5
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000BE8
    IL_000D: conv.r8
    IL_000E: stloc.0
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldc.i4.1
    IL_0013: conv.r8
    IL_0014: stloc.1
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_0018: ret
    }

    public void GainCoin() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BE4
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000BE4
    IL_000E: ret
    }

    public void GainSoul() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BE3
    IL_0007: ldarg.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000BE3
    IL_000E: ldarg.0
    IL_000F: ldarg.0
    IL_0014: ldfld 0x04000BF8
    IL_0019: ldfld 0x040002EF
    IL_001E: stfld 0x04000BE1
    IL_001F: ldarg.0
    IL_0020: IL_22
    IL_0021: nop
    IL_0022: nop
    IL_0027: stsfld 0xE17B023F
    IL_0028: stloc.1
    IL_0029: nop
    IL_002A: ldarg.2
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000BE2
    IL_0032: ldc.i4.s 100
    IL_0033: IL_5A
    IL_0034: conv.i2
    IL_0035: add
    IL_0036: IL_59
    IL_0037: IL_22
    IL_0038: nop
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_3E
    IL_003C: IL_5A
    IL_0041: stfld 0x04000BF1
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000BEC
    IL_004C: call 0x0A0000AA
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000BF1
    IL_0057: call 0x0A000083
    IL_0058: conv.r8
    IL_0059: IL_F3
    IL_005A: ldarg.0
    IL_005B: nop
    IL_005C: ldloc.0
    IL_005D: ret
    }

    public void StatUpdate() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000BDD
    IL_0007: ldarg.0
    IL_0008: ldarg.3
    IL_000D: stfld 0x04000BDF
    IL_000E: ldarg.0
    IL_000F: ldarg.2
    IL_0014: stfld 0x04000BDE
    IL_0015: IL_22
    IL_0016: nop
    IL_0017: nop
    IL_001C: stsfld 0xDD7B023F
    IL_001D: stloc.1
    IL_001E: nop
    IL_001F: ldarg.2
    IL_0020: conv.i2
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000BDE
    IL_0027: conv.i2
    IL_0028: add
    IL_0029: IL_59
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_002D: nop
    IL_002E: IL_3F
    IL_002F: IL_5A
    IL_0030: stloc.0
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000BEA
    IL_0037: ldloc.0
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_0041: newobj 0x0A000038
    IL_0042: conv.r8
    IL_0043: IL_F3
    IL_0044: ldarg.0
    IL_0045: nop
    IL_0046: ldloc.0
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004E: stsfld 0xDF7B023F
    IL_004F: stloc.1
    IL_0050: nop
    IL_0051: ldarg.2
    IL_0052: conv.i2
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000BE0
    IL_0059: conv.i2
    IL_005A: add
    IL_005B: IL_59
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: IL_3F
    IL_0061: IL_5A
    IL_0062: stloc.1
    IL_0063: ldarg.0
    IL_0068: ldfld 0x04000BDF
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006E: ldloc 17474
    IL_006F: ldc.i4.5
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000BEB
    IL_007D: call 0x0A000082
    IL_007E: ldloc.1
    IL_0083: call 0x0A000083
    IL_0084: conv.r8
    IL_0085: IL_F3
    IL_0086: ldarg.0
    IL_0087: nop
    IL_0088: ldloc.0
    IL_008D: br IL_00B8
    IL_008E: ldarg.0
    IL_0093: ldfld 0x04000BEB
    IL_0098: call 0x0A000082
    IL_0099: ldloc.1
    IL_009E: call 0x0A000083
    IL_00A3: call 0x0A0000AA
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: IL_3D
    IL_00AD: call 0x0A000083
    IL_00B2: call 0x0A000174
    IL_00B3: conv.r8
    IL_00B4: IL_F3
    IL_00B5: ldarg.0
    IL_00B6: nop
    IL_00B7: ldloc.0
    IL_00B8: ret
    }

    public void GuideOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BF8
    IL_0006: conv.r8
    IL_000B: newobj 0x22060001
    IL_000C: nop
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0014: call 0x0A000111
    IL_0015: ldarg.0
    IL_0016: ldarg.1
    IL_001B: stfld 0x04000BE5
    IL_001C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BF5
    IL_000A: brfalse IL_0082
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000BF4
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_3F
    IL_0016: IL_41
    IL_0017: ldc.i4.7
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldarg.0
    IL_001C: dup
    IL_0021: ldfld 0x04000BF4
    IL_0026: call 0x0A000024
    IL_0027: IL_22
    IL_0028: ldelem.i
    IL_0029: IL_99
    IL_002A: ldc.i4.3
    IL_002B: IL_3F
    IL_002C: IL_5A
    IL_002D: IL_58
    IL_0032: stfld 0x04000BF4
    IL_0037: br IL_0066
    IL_0038: ldarg.0
    IL_0039: IL_22
    IL_003A: nop
    IL_003B: nop
    IL_003C: nop
    IL_003D: nop
    IL_0042: stfld 0x04000BF4
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000BF8
    IL_0049: conv.r8
    IL_004A: ldelem.i1
    IL_004B: IL_01
    IL_004C: nop
    IL_004D: ldloc.0
    IL_004E: ldarg.0
    IL_004F: ldc.i4.0
    IL_0054: stfld 0x04000BF5
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000BE8
    IL_005B: conv.r8
    IL_005C: stloc.0
    IL_005D: nop
    IL_005E: nop
    IL_005F: stloc.0
    IL_0060: ldc.i4.0
    IL_0061: conv.r8
    IL_0062: stloc.1
    IL_0063: nop
    IL_0064: nop
    IL_0065: stloc.0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000BED
    IL_0070: call 0x0A000082
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000BF4
    IL_0077: shl
    IL_007C: call 0x0A000083
    IL_007D: conv.r8
    IL_007E: IL_F3
    IL_007F: ldarg.0
    IL_0080: nop
    IL_0081: ldloc.0
    IL_0082: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BF3
    IL_000A: brtrue IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000BF6
    IL_0016: call 0x0A0000DF
    IL_001B: call 0x0A00001B
    IL_0020: call 0x0A000013
    IL_0025: call 0x0A0000D9
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: cpobj 0xDA285B44
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: conv.i2
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_003A: ldc.i4 2251588
    IL_003B: nop
    IL_0040: stsfld 0x0076733F
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: call 0x0A0000DD
    IL_004C: call 0x0A0000DE
    IL_004D: ldc.i4.0
    IL_0052: call 0x0A0000EF
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000BE5
    IL_0059: ldc.i4.0
    IL_005A: IL_3F
    IL_005B: IL_82
    IL_005C: IL_01
    IL_005D: nop
    IL_005E: nop
    IL_005F: IL_22
    IL_0060: nop
    IL_0061: nop
    IL_0062: IL_E0
    IL_0063: IL_42
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_0067: IL_C0
    IL_0068: IL_42
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_0070: stsfld 0x00002243
    IL_0071: nop
    IL_0072: IL_43
    IL_0077: call 0x0600021D
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000BE6
    IL_0082: call 0x0A0000E0
    IL_0083: IL_22
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_F8
    IL_0087: IL_42
    IL_0088: IL_22
    IL_0089: nop
    IL_008A: nop
    IL_008F: ldtoken 0x00002242
    IL_0090: neg
    IL_0091: IL_43
    IL_0092: IL_22
    IL_0093: nop
    IL_0094: nop
    IL_0096: starg.s 66
    IL_009B: call 0x0600021D
    IL_00A0: ldsfld 0x0A000099
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000BEE
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000BE5
    IL_00AD: ldelem.i
    IL_00B2: call 0x0A000011
    IL_00B7: ldstr 0x70000C43
    IL_00BC: call 0x0A0000E2
    IL_00C1: call 0x0A0000E3
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_EC
    IL_00C6: IL_42
    IL_00C7: IL_22
    IL_00C8: nop
    IL_00C9: nop
    IL_00CC: ldloc 8771
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: conv.u4
    IL_00D0: IL_43
    IL_00D1: IL_22
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: rem
    IL_00D5: IL_41
    IL_00DA: call 0x0600021D
    IL_00DF: ldsfld 0x0A000099
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000BE5
    IL_00E6: ldc.i4.1
    IL_00E7: IL_58
    IL_00EC: newobj 0x0100000B
    IL_00F1: ldstr 0x700237E1
    IL_00F6: call 0x0A000098
    IL_00FB: ldstr 0x70000C43
    IL_0100: call 0x0A0000E2
    IL_0105: call 0x0A0000E3
    IL_0106: IL_22
    IL_0107: nop
    IL_0108: nop
    IL_0109: ret
    IL_010A: IL_43
    IL_010B: IL_22
    IL_010C: nop
    IL_010D: nop
    IL_010E: stloc.0
    IL_010F: IL_43
    IL_0110: IL_22
    IL_0111: nop
    IL_0112: nop
    IL_0113: nop
    IL_0114: IL_43
    IL_0115: IL_22
    IL_0116: nop
    IL_0117: nop
    IL_011C: stsfld 0x021D2842
    IL_011D: nop
    IL_011E: ldloc.0
    IL_011F: ldarg.0
    IL_0124: ldfld 0x04000BEF
    IL_0125: ldarg.0
    IL_012A: ldfld 0x04000BE5
    IL_012B: ldelem.i
    IL_0130: call 0x0A0000E0
    IL_0131: ldarg.0
    IL_0136: ldfld 0x04000BE5
    IL_0137: ldc.i4.3
    IL_02A8: switch (91 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: ldsfld 0x0A000099
    IL_000A: stfld 0x04000C0B
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000C00
    IL_0010: ret
    }

    private void Start() {
    IL_0004: call 0x0600021A
    IL_0009: ldstr 0x70022F71
    IL_000E: call 0x0A000095
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700237EB
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_3000000A6: switch (3221225506 cases)
    }

    private void NextScreen() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000BFF
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_000D: stfld 0x04000BFF
    IL_000E: ret
    }

    public void GetUsim() {
    IL_0000: ldarg.1
    IL_0005: call 0x0600021B
    IL_0006: ldarg.0
    IL_0007: ldc.i4.1
    IL_000C: stfld 0x04000C0C
    IL_000D: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000BFE
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000BFF
    IL_0047: ldc.i4.1
    IL_0134: switch (58 cases)
    IL_0135: nop
    IL_0136: nop
    IL_0137: nop
    IL_0138: IL_22
    IL_0139: nop
    IL_013A: nop
    IL_013B: nop
    IL_013C: nop
    IL_013D: IL_22
    IL_013E: nop
    IL_013F: nop
    IL_0140: IL_F0
    IL_0141: IL_43
    IL_0142: IL_22
    IL_0143: nop
    IL_0144: nop
    IL_0145: ldelem.r8
    IL_0146: IL_43
    IL_014B: call 0x0600021D
    IL_014C: ldarg.0
    IL_0151: ldfld 0x04000C04
    IL_0156: call 0x0A0000E0
    IL_015B: br IL_024F
    IL_015C: ldarg.0
    IL_0161: ldfld 0x04000C0B
    IL_0166: ldstr 0x7002382B
    IL_016B: call 0x0A0000EC
    IL_0170: brfalse IL_019A
    IL_0171: IL_22
    IL_0172: nop
    IL_0173: nop
    IL_0174: nop
    IL_0175: nop
    IL_0176: IL_22
    IL_0177: nop
    IL_0178: nop
    IL_0179: nop
    IL_017A: nop
    IL_017B: IL_22
    IL_017C: nop
    IL_017D: nop
    IL_017E: IL_F0
    IL_017F: IL_43
    IL_0180: IL_22
    IL_0181: nop
    IL_0182: nop
    IL_0183: ldelem.r8
    IL_0184: IL_43
    IL_0189: call 0x0600021D
    IL_018A: ldarg.0
    IL_018F: ldfld 0x04000C05
    IL_0194: call 0x0A0000E0
    IL_0199: br IL_024F
    IL_019A: ldarg.0
    IL_019F: ldfld 0x04000C0B
    IL_01A4: ldstr 0x70023839
    IL_01A9: call 0x0A0000EC
    IL_01AE: brfalse IL_01D8
    IL_01AF: IL_22
    IL_01B0: nop
    IL_01B1: nop
    IL_01B2: nop
    IL_01B3: nop
    IL_01B4: IL_22
    IL_01B5: nop
    IL_01B6: nop
    IL_01B7: nop
    IL_01B8: nop
    IL_01B9: IL_22
    IL_01BA: nop
    IL_01BB: nop
    IL_01BC: IL_F0
    IL_01BD: IL_43
    IL_01BE: IL_22
    IL_01BF: nop
    IL_01C0: nop
    IL_01C1: ldelem.r8
    IL_01C2: IL_43
    IL_01C7: call 0x0600021D
    IL_01C8: ldarg.0
    IL_01CD: ldfld 0x04000C06
    IL_01D2: call 0x0A0000E0
    IL_01D7: br IL_024F
    IL_01D8: ldarg.0
    IL_01DD: ldfld 0x04000C0B
    IL_01E2: ldstr 0x70000A4B
    IL_01E7: call 0x0A0000EC
    IL_01EC: brfalse IL_0216
    IL_01ED: IL_22
    IL_01EE: nop
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: nop
    IL_01F2: IL_22
    IL_01F3: nop
    IL_01F4: nop
    IL_01F5: nop
    IL_01F6: nop
    IL_01F7: IL_22
    IL_01F8: nop
    IL_01F9: nop
    IL_01FA: IL_F0
    IL_01FB: IL_43
    IL_01FC: IL_22
    IL_01FD: nop
    IL_01FE: nop
    IL_01FF: ldelem.r8
    IL_0200: IL_43
    IL_0205: call 0x0600021D
    IL_0206: ldarg.0
    IL_020B: ldfld 0x04000C07
    IL_0210: call 0x0A0000E0
    IL_0215: br IL_024F
    IL_0216: ldarg.0
    IL_021B: ldfld 0x04000C0B
    IL_0220: ldstr 0x70023847
    IL_0225: call 0x0A0000EC
    IL_022A: brfalse IL_024F
    IL_022B: IL_22
    IL_022C: nop
    IL_022D: nop
    IL_022E: nop
    IL_022F: nop
    IL_0230: IL_22
    IL_0231: nop
    IL_0232: nop
    IL_0233: nop
    IL_0234: nop
    IL_0235: IL_22
    IL_0236: nop
    IL_0237: nop
    IL_0238: IL_F0
    IL_0239: IL_43
    IL_023A: IL_22
    IL_023B: nop
    IL_023C: nop
    IL_023D: ldelem.r8
    IL_023E: IL_43
    IL_0243: call 0x0600021D
    IL_0244: ldarg.0
    IL_0249: ldfld 0x04000C0A
    IL_024E: call 0x0A0000E0
    IL_024F: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000C25
    IL_000C: ldarg.0
    IL_000E: ldc.i4.s 30
    IL_0013: newarr 0x0100003C
    IL_0018: stfld 0x04000C26
    IL_0019: ldarg.0
    IL_001B: ldc.i4.s 24
    IL_0020: newarr 0x0100003C
    IL_0025: stfld 0x04000C27
    IL_0026: ldarg.0
    IL_0027: ldc.i4.6
    IL_002C: newarr 0x0100003C
    IL_0031: stfld 0x04000C28
    IL_0032: ldarg.0
    IL_0033: ldc.i4.6
    IL_0038: newarr 0x01000013
    IL_003D: stfld 0x04000C29
    IL_003E: ldarg.0
    IL_003F: ldc.i4.m1
    IL_0044: stfld 0x04000C30
    IL_0045: ldarg.0
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_004E: nop
    IL_004F: nop
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: IL_3F
    IL_005E: newobj 0x0A0000C4
    IL_0063: stfld 0x04000C31
    IL_0064: ldarg.0
    IL_0069: call 0x0A000057
    IL_006E: stfld 0x04000C38
    IL_006F: ldarg.0
    IL_0074: call 0x0A000057
    IL_0079: stfld 0x04000C39
    IL_007A: ldarg.0
    IL_007B: ldc.i4.m1
    IL_0080: stfld 0x04000C43
    IL_0081: ldarg.0
    IL_0082: ldc.i4.m1
    IL_0087: stfld 0x04000C46
    IL_0088: ldarg.0
    IL_008A: ldc.i4.s 24
    IL_008F: newarr 0x0100000B
    IL_0094: stfld 0x04000C4D
    IL_0095: ldarg.0
    IL_0097: ldc.i4.s 30
    IL_009C: newarr 0x0100000B
    IL_00A1: stfld 0x04000C4E
    IL_00A2: ldarg.0
    IL_00A4: ldc.i4.s 76
    IL_00A9: newarr 0x0100000B
    IL_00AE: stfld 0x04000C4F
    IL_00AF: ldarg.0
    IL_00B1: ldc.i4.s 76
    IL_00B6: newarr 0x0100000B
    IL_00BB: stfld 0x04000C50
    IL_00BC: ldarg.0
    IL_00BE: ldc.i4.s 76
    IL_00C3: newarr 0x0100000B
    IL_00C8: stfld 0x04000C51
    IL_00C9: ldarg.0
    IL_00CB: ldc.i4.s 76
    IL_00D0: newarr 0x01000013
    IL_00D5: stfld 0x04000C52
    IL_00D6: ldarg.0
    IL_00D8: ldc.i4.s 20
    IL_00DD: newarr 0x0100000B
    IL_00E2: stfld 0x04000C55
    IL_00E3: ldarg.0
    IL_00E5: ldc.i4.s 12
    IL_00EA: newarr 0x0100000B
    IL_00EF: stfld 0x04000C56
    IL_00F0: ldarg.0
    IL_00F2: ldc.i4.s 20
    IL_00F7: newarr 0x0100000B
    IL_00FC: stfld 0x04000C57
    IL_00FD: ldarg.0
    IL_00FE: ldc.i4.2
    IL_0103: newarr 0x0100000B
    IL_0108: stfld 0x04000C58
    IL_0109: ldarg.0
    IL_010A: ldc.i4.m1
    IL_010F: stfld 0x04000C5F
    IL_0110: ldarg.0
    IL_0112: ldc.i4.s 20
    IL_0117: newarr 0x0100000B
    IL_011C: stfld 0x04000C64
    IL_011D: ldarg.0
    IL_0122: call 0x0A000001
    IL_0123: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000C44
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000C45
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000C49
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: call 0x2B000057
    IL_001B: stfld 0x04000C37
    IL_001C: ldarg.0
    IL_001D: IL_22
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_BE
    IL_0021: IL_C3
    IL_0026: stfld 0x04000C3C
    IL_0027: ldarg.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_F0
    IL_002C: IL_43
    IL_0031: stfld 0x04000C3D
    IL_0032: ldarg.0
    IL_0033: IL_22
    IL_0034: nop
    IL_0035: nop
    IL_0036: IL_AA
    IL_0037: IL_43
    IL_003C: stfld 0x04000C3E
    IL_003D: ldarg.0
    IL_0042: ldstr 0x70001FC1
    IL_0047: call 0x060003F9
    IL_004C: stfld 0x04000C4D
    IL_004D: ldarg.0
    IL_0052: ldstr 0x70001FD3
    IL_0057: call 0x060003F9
    IL_005C: stfld 0x04000C4E
    IL_005D: ldarg.0
    IL_0062: ldstr 0x70002093
    IL_0067: call 0x06000220
    IL_006C: stfld 0x04000C62
    IL_006D: ldarg.0
    IL_0072: ldstr 0x70000121
    IL_0077: call 0x0A000004
    IL_007C: stfld 0x04000C33
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000C33
    IL_0083: ldnull
    IL_0088: call 0x0A000021
    IL_008D: brfalse IL_009F
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000C33
    IL_0095: conv.r8
    IL_0096: IL_84
    IL_0097: nop
    IL_0098: nop
    IL_009A: br.s IL_0118
    IL_009B: IL_34
    IL_009C: stloc.2
    IL_009D: nop
    IL_009E: ldarg.2
    IL_009F: ldarg.0
    IL_00A0: ldarg.0
    IL_00A5: call 0x2B000085
    IL_00AA: stfld 0x04000C36
    IL_00AB: ldarg.0
    IL_00AC: ldarg.0
    IL_00B1: call 0x2B000086
    IL_00B6: stfld 0x04000C35
    IL_00B7: ldarg.0
    IL_00BC: ldstr 0x70001FDF
    IL_00C1: call 0x060003F9
    IL_00C6: stfld 0x04000C4F
    IL_00C7: ldarg.0
    IL_00CC: ldstr 0x70001FEF
    IL_00D1: call 0x060003F9
    IL_00D6: stfld 0x04000C56
    IL_00D7: ldarg.0
    IL_00DC: ldstr 0x70002001
    IL_00E1: call 0x060003F9
    IL_00E6: stfld 0x04000C57
    IL_00E7: ldarg.0
    IL_00EC: ldstr 0x70002015
    IL_00F1: call 0x060003F9
    IL_00F6: stfld 0x04000C58
    IL_00F7: ldarg.0
    IL_00FC: ldstr 0x70002031
    IL_0101: call 0x06000220
    IL_0106: stfld 0x04000C59
    IL_0107: ldarg.0
    IL_010C: ldstr 0x70002045
    IL_0111: call 0x06000220
    IL_0116: stfld 0x04000C5A
    IL_0117: ldarg.0
    IL_011C: ldstr 0x70000EC9
    IL_0121: call 0x06000220
    IL_0126: stfld 0x04000C5B
    IL_0127: ldarg.0
    IL_012C: ldstr 0x70002059
    IL_0131: call 0x06000220
    IL_0136: stfld 0x04000C5C
    IL_0137: ldarg.0
    IL_013C: ldstr 0x700015BF
    IL_0141: call 0x06000220
    IL_0146: stfld 0x04000C5D
    IL_0147: ldarg.0
    IL_014C: ldstr 0x700004DD
    IL_0151: call 0x06000220
    IL_0156: stfld 0x04000C5F
    IL_0157: ldarg.0
    IL_015C: ldstr 0x70001EE5
    IL_0161: call 0x060003F9
    IL_0166: stfld 0x04000C55
    IL_0167: ldarg.0
    IL_016C: ldstr 0x700020A5
    IL_0171: call 0x06000220
    IL_0176: stfld 0x04000C5E
    IL_0177: ldarg.0
    IL_017C: ldstr 0x70001F55
    IL_0181: call 0x06000220
    IL_0186: stfld 0x04000C63
    IL_0187: ldarg.0
    IL_018C: ldstr 0x7000054F
    IL_0191: call 0x060003F9
    IL_0196: stfld 0x04000C64
    IL_0197: ldarg.0
    IL_019C: ldstr 0x70001F71
    IL_01A1: call 0x06000220
    IL_01A6: stfld 0x04000C65
    IL_01A7: ldarg.0
    IL_01AC: ldstr 0x70001F83
    IL_01B1: call 0x06000220
    IL_01B6: stfld 0x04000C66
    IL_01B7: ldc.i4.0
    IL_01B8: stloc.0
    IL_01BD: br IL_0AD3
    IL_01BE: ldarg.0
    IL_01C3: ldfld 0x04000C4F
    IL_01C4: ldloc.0
    IL_01C5: IL_94
    IL_01CA: brtrue IL_0ACF
    IL_01CB: ldarg.0
    IL_01CC: dup
    IL_01D1: ldfld 0x04000C60
    IL_01D2: ldc.i4.1
    IL_01D3: IL_58
    IL_01D8: stfld 0x04000C60
    IL_01D9: ldarg.0
    IL_01DE: ldfld 0x04000C37
    IL_01E3: ldfld 0x0400049F
    IL_01E4: ldloc.0
    IL_01E5: IL_8F
    IL_01E6: IL_57
    IL_01E7: nop
    IL_01E8: nop
    IL_01E9: ldarg.0
    IL_01EE: ldfld 0x0400049C
    IL_01F0: stloc.s 10
    IL_01F2: ldloc.s 10
    IL_01F3: ldc.i4.1
    IL_01F4: IL_59
    IL_01F7: ldarg 20
    IL_01F8: nop
    IL_01F9: nop
    IL_01FA: ldarg.3
    IL_01FB: nop
    IL_01FC: nop
    IL_01FD: nop
    IL_01FE: conv.r4
    IL_01FF: nop
    IL_0200: nop
    IL_0201: nop
    IL_0202: IL_D7
    IL_0203: nop
    IL_0204: nop
    IL_0205: nop
    IL_2A400020E: switch (2835349505 cases)
    }

    public void FindNewTreasure() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0008: br IL_0085
    IL_0009: ldc.i4.0
    IL_000A: stloc.2
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000C4D
    IL_0011: ldc.i4.4
    IL_0012: ldloc.1
    IL_0013: IL_5A
    IL_0014: IL_94
    IL_0015: ldc.i4.0
    IL_0016: IL_3E
    IL_0017: ldarg.2
    IL_0018: nop
    IL_0019: nop
    IL_001A: nop
    IL_001B: ldloc.2
    IL_001C: ldc.i4.1
    IL_001D: IL_58
    IL_001E: stloc.2
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000C4D
    IL_0025: ldc.i4.4
    IL_0026: ldloc.1
    IL_0027: IL_5A
    IL_0028: ldc.i4.1
    IL_0029: IL_58
    IL_002A: IL_94
    IL_002B: ldc.i4.0
    IL_002C: IL_3E
    IL_002D: ldarg.2
    IL_002E: nop
    IL_002F: nop
    IL_0030: nop
    IL_0031: ldloc.2
    IL_0032: ldc.i4.1
    IL_0033: IL_58
    IL_0034: stloc.2
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000C4D
    IL_003B: ldc.i4.4
    IL_003C: ldloc.1
    IL_003D: IL_5A
    IL_003E: ldc.i4.2
    IL_003F: IL_58
    IL_0040: IL_94
    IL_0041: ldc.i4.0
    IL_0042: IL_3E
    IL_0043: ldarg.2
    IL_0044: nop
    IL_0045: nop
    IL_0046: nop
    IL_0047: ldloc.2
    IL_0048: ldc.i4.1
    IL_0049: IL_58
    IL_004A: stloc.2
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000C4D
    IL_0051: ldc.i4.4
    IL_0052: ldloc.1
    IL_0053: IL_5A
    IL_0054: ldc.i4.3
    IL_0055: IL_58
    IL_0056: IL_94
    IL_0057: ldc.i4.0
    IL_0058: IL_3E
    IL_0059: ldarg.2
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: ldloc.2
    IL_005E: ldc.i4.1
    IL_005F: IL_58
    IL_0060: stloc.2
    IL_0061: ldloc.2
    IL_0062: ldc.i4.4
    IL_00A7: switch (16 cases)
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000C61
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000C61
    IL_0010: ret
    }

    public void IsWarning() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_001A
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000C52
    IL_000D: ldloc.0
    IL_000E: IL_91
    IL_0013: brfalse IL_0016
    IL_0014: ldc.i4.1
    IL_0015: ret
    IL_0016: ldloc.0
    IL_0017: ldc.i4.1
    IL_0018: IL_58
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001C: ldc.i4.s 76
    IL_001D: IL_3F
    IL_001E: IL_E5
    IL_001F: IL_FF
    IL_0020: IL_FF
    IL_0021: IL_FF
    IL_0022: ldc.i4.0
    IL_0023: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000C40
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000C41
    IL_000E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000C40
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000C41
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000C41
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000C41
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_42
    IL_002A: ldloca.s 0
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000C40
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000C41
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000C3F
    IL_0049: brtrue IL_0111
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000C3C
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x002941C2
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000C3C
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000C3C
    IL_0067: shl
    IL_006C: call 0x0A000024
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0070: ldc.i4.0
    IL_0071: IL_44
    IL_0072: IL_5A
    IL_0077: call 0x0A000114
    IL_0078: IL_58
    IL_007D: stfld 0x04000C3C
    IL_0082: br IL_0111
    IL_0083: ldarg.0
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_008B: stsfld 0x0C3C7DC2
    IL_008C: nop
    IL_008D: ldarg.2
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000C3D
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000C3D
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00B0: stfld 0x04000C3D
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000C3D
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: IL_42
    IL_00BD: IL_50
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: nop
    IL_00CB: stfld 0x04000C3D
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000C3E
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000C3E
    IL_00DD: call 0x0A000024
    IL_00DE: IL_22
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_FA
    IL_00E2: IL_43
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000114
    IL_00E9: IL_59
    IL_00EE: stfld 0x04000C3E
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000C3E
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: shr
    IL_00F9: IL_43
    IL_00FA: IL_42
    IL_00FC: ldloca.s 0
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: ldarg.0
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: shr
    IL_0104: IL_43
    IL_0109: stfld 0x04000C3E
    IL_010A: ldarg.0
    IL_010B: ldc.i4.1
    IL_0110: stfld 0x04000C3F
    IL_0115: ldstr 0x7000064F
    IL_011A: call 0x0A000095
    IL_011B: stloc.0
    IL_011C: ldloc.0
    IL_011D: ldc.i4.1
    IL_01CE: switch (43 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000C32
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000C32
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000C32
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
    }

    public void sortAchieve() {
    IL_0001: ldc.i4.s 76
    IL_0006: newarr 0x0100000B
    IL_0007: stloc.0
    IL_000C: newobj 0x0A00030B
    IL_000D: stloc.1
    IL_0012: newobj 0x0A00030B
    IL_0013: stloc.2
    IL_0018: newobj 0x0A00030B
    IL_0019: stloc.3
    IL_001A: ldc.i4.0
    IL_001C: stloc.s 4
    IL_0021: br IL_0067
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000C52
    IL_0029: ldloc.s 4
    IL_002A: IL_91
    IL_002F: brfalse IL_003D
    IL_0030: ldloc.1
    IL_0032: ldloc.s 4
    IL_0033: conv.r8
    IL_0034: stloc.2
    IL_0035: ldarg.1
    IL_0036: nop
    IL_0037: stloc.0
    IL_003C: br IL_0061
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000C4F
    IL_0044: ldloc.s 4
    IL_0045: IL_94
    IL_0046: ldc.i4.1
    IL_007F: switch (13 cases)
    IL_0081: ldarg.s 3
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldloc.3
    IL_0085: conv.r8
    IL_0087: ldarg.s 3
    IL_0088: nop
    IL_0089: stloc.0
    IL_008A: ldarg.0
    IL_008B: ldloc.1
    IL_008C: conv.r8
    IL_008E: ldarga.s 3
    IL_008F: nop
    IL_0090: stloc.0
    IL_0095: stfld 0x04000C50
    IL_0096: ldloc.1
    IL_0097: conv.r8
    IL_0099: ldarg.s 3
    IL_009A: nop
    IL_009B: stloc.0
    IL_009C: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000C2F
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000C42
    IL_0047: ldc.i4.0
    IL_0048: IL_3E
    IL_0049: ldloc.0
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldc.i4.0
    IL_0052: call 0x0A0001B9
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000C3C
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_22
    IL_005F: nop
    IL_0060: nop
    IL_0061: ldelem.r8
    IL_0062: IL_43
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: ldelem.r8
    IL_0067: IL_43
    IL_006C: call 0x0600021D
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000C12
    IL_0077: call 0x0A0000E0
    IL_0078: IL_22
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_F0
    IL_007C: IL_42
    IL_007D: IL_22
    IL_007E: nop
    IL_007F: nop
    IL_0080: IL_F0
    IL_0081: IL_41
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0085: IL_C8
    IL_0086: IL_42
    IL_0087: IL_22
    IL_0088: nop
    IL_0089: nop
    IL_008C: ldloc 10306
    IL_008D: ldc.i4.7
    IL_008E: ldarg.0
    IL_008F: nop
    IL_0090: ldloc.0
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000C13
    IL_009B: call 0x0A0000E0
    IL_009C: IL_22
    IL_009D: nop
    IL_009E: nop
    IL_009F: IL_58
    IL_00A0: IL_43
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: IL_50
    IL_00A5: IL_42
    IL_00A6: IL_22
    IL_00A7: nop
    IL_00A8: nop
    IL_00A9: ldelem.r8
    IL_00AA: IL_42
    IL_00AB: IL_22
    IL_00AC: nop
    IL_00AD: nop
    IL_00AE: IL_C0
    IL_00AF: IL_41
    IL_00B4: call 0x0600021D
    IL_00B9: ldsfld 0x040007B2
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04000C49
    IL_00C4: ldc.i4 195
    IL_00C9: call 0x0A0000E1
    IL_00CE: call 0x0A0002EA
    IL_00CF: IL_22
    IL_00D0: nop
    IL_00D1: nop
    IL_00D2: IL_E0
    IL_00D3: IL_42
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: nop
    IL_00D8: nop
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00E0: stsfld 0x00002243
    IL_00E1: nop
    IL_00E2: IL_42
    IL_00E7: call 0x0600021D
    IL_00E8: ldarg.0
    IL_00ED: ldfld 0x04000C1D
    IL_00F2: call 0x0A0000E0
    IL_00F3: IL_22
    IL_00F4: nop
    IL_00F5: nop
    IL_00F7: ldloca.s 67
    IL_00F8: IL_22
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: IL_C0
    IL_280000188: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000C6D
    IL_000C: ldarg.0
    IL_000D: ldc.i4.6
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000C6E
    IL_0018: ldarg.0
    IL_0019: ldc.i4.6
    IL_001E: newarr 0x0100003C
    IL_0023: stfld 0x04000C6F
    IL_0024: ldarg.0
    IL_0026: ldc.i4.s 10
    IL_002B: newarr 0x0100003C
    IL_0030: stfld 0x04000C70
    IL_0031: ldarg.0
    IL_0033: ldc.i4.s 10
    IL_0038: newarr 0x0100003C
    IL_003D: stfld 0x04000C71
    IL_003E: ldarg.0
    IL_003F: ldc.i4.7
    IL_0044: newarr 0x0100003C
    IL_0049: stfld 0x04000C72
    IL_004A: ldarg.0
    IL_004B: ldc.i4.6
    IL_0050: newarr 0x0100003C
    IL_0055: stfld 0x04000C73
    IL_0056: ldarg.0
    IL_0057: ldc.i4.6
    IL_005C: newarr 0x0100003C
    IL_0061: stfld 0x04000C74
    IL_0062: ldarg.0
    IL_0063: ldc.i4.3
    IL_0068: newarr 0x0100003C
    IL_006D: stfld 0x04000C88
    IL_006E: ldarg.0
    IL_006F: ldc.i4.8
    IL_0074: newarr 0x0100003C
    IL_0079: stfld 0x04000C8A
    IL_007A: ldarg.0
    IL_007C: ldc.i4.s 10
    IL_0081: stfld 0x04000C9A
    IL_0082: ldarg.0
    IL_0087: ldstr 0x700237B3
    IL_008C: stfld 0x04000C9B
    IL_008D: ldarg.0
    IL_008E: IL_22
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_BE
    IL_0092: IL_C3
    IL_0097: stfld 0x04000C9D
    IL_0098: ldarg.0
    IL_0099: IL_22
    IL_009A: nop
    IL_009B: nop
    IL_009C: IL_F0
    IL_009D: IL_43
    IL_00A2: stfld 0x04000C9E
    IL_00A3: ldarg.0
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: IL_AA
    IL_00A8: IL_43
    IL_00AD: stfld 0x04000C9F
    IL_00AE: ldarg.0
    IL_00B0: ldc.i4.s 9
    IL_00B5: newarr 0x0100000B
    IL_00B6: dup
    IL_00BB: ldtoken 0x040010C1
    IL_00C0: call 0x0A00018C
    IL_00C5: stfld 0x04000CA0
    IL_00C6: ldarg.0
    IL_00C8: ldc.i4.s 9
    IL_00CD: newarr 0x0100002F
    IL_00CE: dup
    IL_00D3: ldtoken 0x040010C2
    IL_00D8: call 0x0A00018C
    IL_00DD: stfld 0x04000CA1
    IL_00DE: ldarg.0
    IL_00DF: ldc.i4.8
    IL_00E4: newarr 0x0100000B
    IL_00E5: dup
    IL_00EA: ldtoken 0x040010C3
    IL_00EF: call 0x0A00018C
    IL_00F4: stfld 0x04000CA2
    IL_00F5: ldarg.0
    IL_00F6: ldc.i4.6
    IL_00FB: newarr 0x0100000B
    IL_00FC: dup
    IL_0101: ldtoken 0x040010C4
    IL_0106: call 0x0A00018C
    IL_010B: stfld 0x04000CA3
    IL_010C: ldarg.0
    IL_010D: ldc.i4.6
    IL_0112: newarr 0x0100000B
    IL_0113: dup
    IL_0118: ldtoken 0x040010C5
    IL_011D: call 0x0A00018C
    IL_0122: stfld 0x04000CA4
    IL_0123: ldarg.0
    IL_0124: ldc.i4.6
    IL_0129: newarr 0x0100000B
    IL_012A: dup
    IL_012F: ldtoken 0x040010C6
    IL_0134: call 0x0A00018C
    IL_0139: stfld 0x04000CA5
    IL_013A: ldarg.0
    IL_013C: ldc.i4.s 10
    IL_0141: newarr 0x0100000B
    IL_0146: stfld 0x04000CA6
    IL_0147: ldarg.0
    IL_0149: ldc.i4.s 10
    IL_014E: newarr 0x0100000B
    IL_014F: dup
    IL_0154: ldtoken 0x040010C7
    IL_0159: call 0x0A00018C
    IL_015E: stfld 0x04000CA7
    IL_015F: ldarg.0
    IL_0160: ldc.i4.6
    IL_0165: newarr 0x0100000B
    IL_0166: dup
    IL_016B: ldtoken 0x040010C8
    IL_0170: call 0x0A00018C
    IL_0175: stfld 0x04000CA8
    IL_0176: ldarg.0
    IL_0178: ldc.i4.s 10
    IL_017D: newarr 0x0100000B
    IL_017E: dup
    IL_0183: ldtoken 0x040010C9
    IL_0188: call 0x0A00018C
    IL_018D: stfld 0x04000CA9
    IL_018E: ldarg.0
    IL_0190: ldc.i4.s 10
    IL_0195: newarr 0x0100000B
    IL_0196: dup
    IL_019B: ldtoken 0x040010CA
    IL_01A0: call 0x0A00018C
    IL_01A5: stfld 0x04000CAA
    IL_01A6: ldarg.0
    IL_01A8: ldc.i4.s 9
    IL_01AD: newarr 0x0100000C
    IL_01B2: stfld 0x04000CAB
    IL_01B3: ldarg.0
    IL_01B5: ldc.i4.s 20
    IL_01BA: newarr 0x0100000B
    IL_01BF: stfld 0x04000CAC
    IL_01C0: ldarg.0
    IL_01C2: ldc.i4.s 20
    IL_01C7: newarr 0x0100000B
    IL_01CC: stfld 0x04000CAD
    IL_01CD: ldarg.0
    IL_01CE: ldc.i4.5
    IL_01D3: newarr 0x0100000B
    IL_01D8: stfld 0x04000CAE
    IL_01D9: ldarg.0
    IL_01DA: ldc.i4.6
    IL_01DF: newarr 0x0100000B
    IL_01E4: stfld 0x04000CAF
    IL_01E5: ldarg.0
    IL_01EA: call 0x0A000057
    IL_01EF: stfld 0x04000CB1
    IL_01F0: ldarg.0
    IL_01F5: call 0x0A000057
    IL_01FA: stfld 0x04000CB2
    IL_01FB: ldarg.0
    IL_01FC: ldc.i4.m1
    IL_0201: stfld 0x04000CBD
    IL_0202: ldarg.0
    IL_0203: ldc.i4.m1
    IL_0208: stfld 0x04000CBE
    IL_0209: ldarg.0
    IL_020A: ldc.i4.m1
    IL_020F: stfld 0x04000CBF
    IL_0210: ldarg.0
    IL_0211: ldc.i4.m1
    IL_0216: stfld 0x04000CC0
    IL_0217: ldarg.0
    IL_0219: ldc.i4.s 26
    IL_021E: newarr 0x0100000B
    IL_0223: stfld 0x04000CD3
    IL_0224: ldarg.0
    IL_0226: ldc.i4.s 26
    IL_022B: newarr 0x0100000B
    IL_0230: stfld 0x04000CD4
    IL_0231: ldarg.0
    IL_0236: ldstr 0x70023855
    IL_023B: stfld 0x04000CD6
    IL_023C: ldarg.0
    IL_023D: ldc.i4.1
    IL_0242: stfld 0x04000CD7
    IL_0243: ldarg.0
    IL_0248: call 0x0A000001
    IL_0249: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000053
    IL_000B: stfld 0x04000CD0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000052
    IL_0017: stfld 0x04000CCF
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: call 0x0A000002
    IL_001F: ldc.i4.0
    IL_0020: conv.r8
    IL_0025: brtrue IL_160A0026
    IL_0026: conv.r8
    IL_002B: brtrue IL_6F0A002C
    IL_002C: IL_87
    IL_002D: nop
    IL_002E: nop
    IL_0030: br.s IL_00AE
    IL_0031: IL_D1
    IL_0032: stloc.2
    IL_0033: nop
    IL_0034: ldarg.2
    IL_0035: ldarg.0
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000C8B
    IL_003C: conv.r8
    IL_003D: pop
    IL_003E: nop
    IL_003F: nop
    IL_0041: br.s IL_00BF
    IL_0042: IL_D2
    IL_0043: stloc.2
    IL_0044: nop
    IL_0045: ldarg.2
    IL_0046: ldarg.0
    IL_004B: ldstr 0x70000DD5
    IL_0050: call 0x06000220
    IL_0055: stfld 0x04000CBE
    IL_0056: ldarg.0
    IL_005B: ldstr 0x70000DB9
    IL_0060: call 0x06000220
    IL_0065: stfld 0x04000CBD
    IL_0066: ldarg.0
    IL_006B: ldstr 0x70000DDD
    IL_0070: call 0x06000220
    IL_0075: stfld 0x04000CC1
    IL_0076: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000131
    IL_000A: stfld 0x04000C9C
    IL_000B: ldarg.0
    IL_0010: call 0x0A000002
    IL_0011: ldc.i4.0
    IL_0012: conv.r8
    IL_0017: brtrue IL_160A0018
    IL_0018: conv.r8
    IL_001D: brtrue IL_220A001E
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_00B2: switch (34 cases)
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000DA
    IL_0006: conv.i2
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_C0
    IL_000B: IL_3E
    IL_000C: IL_5A
    IL_0011: stfld 0x04000C93
    IL_0012: ldarg.0
    IL_0017: ldstr 0x70001E8B
    IL_001C: call 0x06000220
    IL_001D: neg
    IL_0022: stfld 0x04000CB9
    IL_0023: ldarg.0
    IL_0028: ldstr 0x70000DCD
    IL_002D: call 0x060003F9
    IL_0032: stfld 0x04000CAF
    IL_0033: ldarg.0
    IL_0038: ldstr 0x70000BB3
    IL_003D: call 0x0A000095
    IL_0042: stfld 0x04000C96
    IL_0043: ldarg.0
    IL_0048: ldstr 0x700020A5
    IL_004D: call 0x06000220
    IL_0052: stfld 0x04000CB0
    IL_0053: ldarg.0
    IL_0058: ldsfld 0x040007B2
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04000C96
    IL_0060: ldc.i4.s 62
    IL_0065: call 0x0A0000E1
    IL_006A: stfld 0x04000CD6
    IL_006F: ldstr 0x70023859
    IL_0074: call 0x0A000077
    IL_0075: ldnull
    IL_007A: call 0x0A000021
    IL_007F: brfalse IL_009C
    IL_0080: ldarg.0
    IL_0085: ldstr 0x70023859
    IL_008A: call 0x0A000077
    IL_008F: stfld 0x04000C94
    IL_0090: ldarg.0
    IL_0091: ldc.i4.2
    IL_0096: stfld 0x04000CD5
    IL_009B: br IL_00EC
    IL_00A0: call 0x0A0000EB
    IL_00A5: ldstr 0x700017E3
    IL_00AA: call 0x0A0000EC
    IL_00AF: brfalse IL_00DC
    IL_00B0: ldarg.0
    IL_00B5: ldstr 0x70000BD5
    IL_00BA: call 0x0A000004
    IL_00BF: stfld 0x04000C94
    IL_00C0: ldarg.0
    IL_00C5: ldstr 0x70001675
    IL_00CA: call 0x0A000004
    IL_00CF: stfld 0x04000C95
    IL_00D0: ldarg.0
    IL_00D1: ldc.i4.2
    IL_00D6: stfld 0x04000CD5
    IL_00DB: br IL_00EC
    IL_00DC: ldarg.0
    IL_00E1: ldstr 0x70000BD5
    IL_00E6: call 0x0A000004
    IL_00EB: stfld 0x04000C94
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x04000C94
    IL_00F2: ldc.i4.0
    IL_00F3: conv.r8
    IL_00F4: stloc.1
    IL_00F5: nop
    IL_00F6: nop
    IL_00F7: stloc.0
    IL_00F8: ldarg.0
    IL_00FD: ldfld 0x04000C95
    IL_00FE: ldnull
    IL_0103: call 0x0A000021
    IL_0108: brfalse IL_0115
    IL_0109: ldarg.0
    IL_010E: ldfld 0x04000C95
    IL_010F: ldc.i4.0
    IL_0110: conv.r8
    IL_0111: stloc.1
    IL_0112: nop
    IL_0113: nop
    IL_0114: stloc.0
    IL_0115: ldarg.0
    IL_011A: ldstr 0x70001EA5
    IL_011F: call 0x06000220
    IL_0124: stfld 0x04000C98
    IL_0125: ldarg.0
    IL_012A: ldstr 0x700004D5
    IL_012F: call 0x06000220
    IL_0134: stfld 0x04000C99
    IL_0135: IL_22
    IL_0136: nop
    IL_0137: nop
    IL_0138: nop
    IL_0139: nop
    IL_013E: call 0x0A000111
    IL_013F: ldarg.0
    IL_0144: ldstr 0x70001EC5
    IL_0149: call 0x06000220
    IL_014E: stfld 0x04000CBA
    IL_014F: ldarg.0
    IL_0150: ldarg.0
    IL_0155: ldfld 0x04000C7E
    IL_015A: stfld 0x04000C84
    IL_015B: ldarg.0
    IL_0160: ldstr 0x70023875
    IL_0165: stfld 0x04000CBC
    IL_0166: ldarg.0
    IL_0168: ldc.i4.s 9
    IL_016D: newarr 0x0100000C
    IL_016E: dup
    IL_016F: ldc.i4.0
    IL_0174: ldstr 0x70023085
    IL_0179: stelem 0x00721725
    IL_017E: brfalse IL_25A27181
    IL_017F: ldc.i4.2
    IL_0184: ldstr 0x70002A2B
    IL_0189: stelem 0x27721925
    IL_018A: IL_34
    IL_018B: ldarg.0
    IL_0190: cpobj 0x721A25A2
    IL_0191: ldarg.2
    IL_0196: brfalse IL_25A27199
    IL_0197: ldc.i4.5
    IL_019C: ldstr 0x7000265B
    IL_01A1: stelem 0x08721C25
    IL_01A6: brfalse IL_25A271A9
    IL_01A7: ldc.i4.7
    IL_01AC: ldstr 0x7002390E
    IL_01B1: stelem 0x997E1E25
    IL_01B2: nop
    IL_01B3: nop
    IL_01B4: stloc.0
    IL_01B9: stelem 0x000CAB7D
    IL_01BA: ldarg.2
    IL_01BB: ldc.i4.0
    IL_01BC: stloc.0
    IL_01C1: br IL_01E3
    IL_01C2: ldarg.0
    IL_01C7: ldfld 0x04000CA6
    IL_01C8: ldloc.0
    IL_01C9: ldarg.0
    IL_01CE: ldfld 0x04000CD0
    IL_01CF: ldarg.0
    IL_01D4: ldfld 0x04000CD3
    IL_01D5: ldloc.0
    IL_01D6: ldc.i4.6
    IL_01D7: IL_58
    IL_01D8: IL_94
    IL_01D9: conv.r8
    IL_01DA: IL_FC
    IL_01DB: ldloc.0
    IL_01DC: nop
    IL_01DD: ldloc.0
    IL_01DE: ldelem.i8
    IL_01DF: ldloc.0
    IL_01E0: ldc.i4.1
    IL_01E1: IL_58
    IL_01E2: stloc.0
    IL_01E3: ldloc.0
    IL_01E5: ldc.i4.s 10
    IL_01E6: IL_3F
    IL_01E7: IL_D7
    IL_01E8: IL_FF
    IL_01E9: IL_FF
    IL_01EA: IL_FF
    IL_01EB: ldarg.0
    IL_01EC: ldarg.0
    IL_01F1: ldfld 0x04000CD3
    IL_01F2: ldarg.0
    IL_01F7: ldfld 0x04000CBD
    IL_01F8: IL_94
    IL_01FD: call 0x06000659
    IL_01FE: ldarg.0
    IL_01FF: ldarg.0
    IL_0204: ldfld 0x04000CD4
    IL_0205: ldarg.0
    IL_020A: ldfld 0x04000CBE
    IL_020B: IL_94
    IL_0210: call 0x0600065A
    IL_0211: ldarg.0
    IL_0212: ldarg.0
    IL_0217: ldfld 0x04000CBE
    IL_0218: ldc.i4.6
    IL_0219: IL_59
    IL_021E: stfld 0x04000CC0
    IL_021F: ldarg.0
    IL_0224: ldfld 0x04000CD2
    IL_0225: ldarg.0
    IL_022A: ldfld 0x04000CC2
    IL_022B: ldarg.0
    IL_0230: ldfld 0x04000CC3
    IL_0231: conv.r8
    IL_0232: IL_E8
    IL_0233: IL_01
    IL_0234: nop
    IL_0235: ldloc.0
    IL_0236: ldc.i4.0
    IL_0237: stloc.1
    IL_023C: br IL_0258
    IL_023D: ldarg.0
    IL_0242: ldfld 0x04000C8C
    IL_0243: ldloc.1
    IL_0244: conv.r8
    IL_0249: brtrue IL_6F0A024A
    IL_024A: stloc.0
    IL_024B: nop
    IL_024C: nop
    IL_024D: stloc.0
    IL_024E: ldc.i4.2
    IL_024F: conv.r8
    IL_0250: ldc.i4.m1
    IL_0251: nop
    IL_0252: nop
    IL_0253: stloc.0
    IL_0254: ldloc.1
    IL_0255: ldc.i4.1
    IL_0256: IL_58
    IL_0257: stloc.1
    IL_0258: ldloc.1
    IL_0259: ldarg.0
    IL_025E: ldfld 0x04000C8C
    IL_025F: conv.r8
    IL_0261: beq.s IL_0263
    IL_0262: nop
    IL_0263: stloc.0
    IL_0264: IL_3F
    IL_0265: IL_D4
    IL_0266: IL_FF
    IL_0267: IL_FF
    IL_0268: IL_FF
    IL_0269: ret
    }

    private void OnApplicationPause() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0026
    IL_0006: ldarg.0
    IL_000B: ldstr 0x70001EA5
    IL_0010: call 0x06000220
    IL_0015: stfld 0x04000C98
    IL_0016: ldarg.0
    IL_001B: ldstr 0x700004D5
    IL_0020: call 0x06000220
    IL_0025: stfld 0x04000C99
    IL_0026: ret
    }

    public void SetUpWeapon() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000CD0
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_FD
    IL_0009: ldloc.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000CD0
    IL_0017: ldfld 0x04000FED
    IL_001C: stfld 0x04000CC2
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000CD0
    IL_0028: ldfld 0x04000FEE
    IL_002D: stfld 0x04000CC3
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000CD0
    IL_0039: ldfld 0x04000FF4
    IL_003E: stfld 0x04000CC4
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000CD0
    IL_004A: ldfld 0x04000FEF
    IL_004F: stfld 0x04000CC5
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000CD0
    IL_005B: ldfld 0x04000FF0
    IL_0060: stfld 0x04000CC6
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000CD0
    IL_006C: ldfld 0x04000FF1
    IL_0071: stfld 0x04000CC7
    IL_0072: ldarg.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000CD0
    IL_007D: ldfld 0x04000FF2
    IL_0082: stfld 0x04000CC8
    IL_0083: ldarg.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000CD0
    IL_008E: ldfld 0x04000FF3
    IL_0093: stfld 0x04000CC9
    IL_0094: ldarg.0
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000CD0
    IL_009F: ldfld 0x04000FF6
    IL_00A4: stfld 0x04000CCA
    IL_00A5: ret
    }

    public void SetUpArmor() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0003: ldc.i4.s 100
    IL_0004: mul
    IL_0009: stfld 0x04000CCB
    IL_000A: ldarg.1
    IL_000C: ldc.i4.s 100
    IL_000D: add
    IL_000F: starg.s 1
    IL_0010: ldc.i4.2
    IL_0015: newarr 0x0100000B
    IL_0016: stloc.0
    IL_0017: ldc.i4.0
    IL_0018: stloc.1
    IL_001D: br IL_002F
    IL_001E: ldloc.0
    IL_001F: ldloc.1
    IL_0020: ldarg.1
    IL_0022: ldc.i4.s 10
    IL_0023: mul
    IL_0024: ldelem.i8
    IL_0025: ldarg.1
    IL_0027: ldc.i4.s 10
    IL_0028: add
    IL_002A: starg.s 1
    IL_002B: ldloc.1
    IL_002C: ldc.i4.1
    IL_002D: IL_58
    IL_002E: stloc.1
    IL_002F: ldloc.1
    IL_0030: ldc.i4.2
    IL_0031: IL_3F
    IL_0032: IL_E8
    IL_0033: IL_FF
    IL_0034: IL_FF
    IL_0035: IL_FF
    IL_0036: ldarg.0
    IL_0037: ldloc.0
    IL_0038: ldc.i4.1
    IL_0039: IL_94
    IL_003E: stfld 0x04000CCC
    IL_003F: ldarg.0
    IL_0040: ldarg.1
    IL_0045: stfld 0x04000CCD
    IL_0046: ret
    }

    public void OnBillingResult() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: call 0x0600065D
    IL_0007: ret
    }

    private void PayCallBack() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: conv.r8
    IL_0004: ldelem.i1
    IL_0005: nop
    IL_0006: nop
    IL_0007: stloc.0
    IL_0008: ldc.i4.2
    IL_0009: IL_59
    IL_000A: conv.r8
    IL_000B: ldelem.i2
    IL_000C: nop
    IL_000D: nop
    IL_000E: stloc.0
    IL_000F: stloc.0
    IL_0010: ldloc.0
    IL_0011: ldc.i4.1
    IL_0016: newarr 0x0100002A
    IL_0017: dup
    IL_0018: ldc.i4.0
    IL_001A: ldc.i4.s 44
    IL_001B: ldelem.i4
    IL_001C: conv.r8
    IL_001D: ldelem.i4
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: stloc.1
    IL_0022: ldloc.1
    IL_0023: ldc.i4.0
    IL_0024: ldelem.i
    IL_0025: stloc.2
    IL_0026: ldloc.2
    IL_0027: ldc.i4.1
    IL_002C: newarr 0x0100002A
    IL_002D: dup
    IL_002E: ldc.i4.0
    IL_0030: ldc.i4.s 58
    IL_0031: ldelem.i4
    IL_0032: conv.r8
    IL_0033: ldelem.i4
    IL_0034: nop
    IL_0035: nop
    IL_0036: stloc.0
    IL_0037: stloc.3
    IL_0038: ldloc.3
    IL_0039: ldc.i4.1
    IL_003A: ldelem.i
    IL_003B: ldc.i4.1
    IL_003C: ldloc.3
    IL_003D: ldc.i4.1
    IL_003E: ldelem.i
    IL_003F: conv.r8
    IL_0040: ldelem.i1
    IL_0041: nop
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: ldc.i4.2
    IL_0045: IL_59
    IL_0046: conv.r8
    IL_0047: ldelem.i2
    IL_0048: nop
    IL_0049: nop
    IL_004A: stloc.0
    IL_004F: call 0x0A00009E
    IL_0051: stloc.s 4
    IL_0052: ldloc.1
    IL_0053: ldc.i4.2
    IL_0054: ldelem.i
    IL_0056: stloc.s 5
    IL_0058: ldloc.s 5
    IL_0059: ldc.i4.1
    IL_005E: newarr 0x0100002A
    IL_005F: dup
    IL_0060: ldc.i4.0
    IL_0062: ldc.i4.s 58
    IL_0063: ldelem.i4
    IL_0064: conv.r8
    IL_0065: ldelem.i4
    IL_0066: nop
    IL_0067: nop
    IL_0068: stloc.0
    IL_006A: stloc.s 6
    IL_006C: ldloc.s 6
    IL_006D: ldc.i4.1
    IL_006E: ldelem.i
    IL_006F: ldc.i4.1
    IL_0071: ldloc.s 6
    IL_0072: ldc.i4.1
    IL_0073: ldelem.i
    IL_0074: conv.r8
    IL_0075: ldelem.i1
    IL_0076: nop
    IL_0077: nop
    IL_0078: stloc.0
    IL_0079: ldc.i4.2
    IL_007A: IL_59
    IL_007B: conv.r8
    IL_007C: ldelem.i2
    IL_007D: nop
    IL_007E: nop
    IL_007F: stloc.0
    IL_0084: call 0x0A00009E
    IL_0086: stloc.s 7
    IL_0088: ldloc.s 4
    IL_0089: ldc.i4.1
    IL_036E: switch (184 cases)
    }

    public void ItemDelivery() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_00DC
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000CAB
    IL_000D: ldloc.0
    IL_000E: ldelem.i
    IL_000F: ldarg.1
    IL_0014: call 0x0A0000EC
    IL_0019: brfalse IL_00D8
    IL_001A: ldarg.0
    IL_001B: dup
    IL_0020: ldfld 0x04000CB0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000CA1
    IL_0027: ldloc.0
    IL_0028: IL_98
    IL_0029: IL_22
    IL_002A: IL_CD
    IL_002B: IL_CC
    IL_002C: IL_CC
    IL_002D: IL_3D
    IL_002E: IL_58
    IL_002F: not
    IL_0030: IL_58
    IL_0035: stfld 0x04000CB0
    IL_003A: ldstr 0x700020A5
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000CB0
    IL_0045: call 0x0600021F
    IL_0046: ldarg.0
    IL_0047: dup
    IL_004C: ldfld 0x04000C99
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000CA0
    IL_0053: ldloc.0
    IL_0054: IL_94
    IL_0055: IL_58
    IL_005A: stfld 0x04000C99
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000CA0
    IL_0061: ldloc.0
    IL_0062: IL_94
    IL_0063: ldc.i4.1
    IL_0068: call 0x0600021E
    IL_0069: pop
    IL_006A: ldc.i4.6
    IL_006F: newarr 0x0100000C
    IL_0070: dup
    IL_0071: ldc.i4.0
    IL_0076: ldsfld 0x040007B2
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000C96
    IL_0081: ldc.i4 233
    IL_0086: call 0x0A0000E1
    IL_008B: stelem 0x89721725
    IL_008C: IL_37
    IL_008D: ldarg.0
    IL_0092: cpobj 0x021825A2
    IL_0097: ldfld 0x04000CA0
    IL_0098: ldloc.0
    IL_0099: IL_8F
    IL_009A: stloc.1
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_01
    IL_00A2: call 0x0A000010
    IL_00A7: stelem 0x8F721925
    IL_00A8: IL_37
    IL_00A9: ldarg.0
    IL_00AE: cpobj 0x021A25A2
    IL_00B3: ldfld 0x04000CA1
    IL_00B4: ldloc.0
    IL_00B5: IL_8F
    IL_00B7: bge.s IL_00B8
    IL_00B8: nop
    IL_00B9: IL_01
    IL_00BE: call 0x0A000208
    IL_00C3: stelem 0x7B021B25
    IL_00C4: IL_D6
    IL_00C5: stloc.2
    IL_00C6: nop
    IL_00C7: ldarg.2
    IL_00CC: stelem 0x00024028
    IL_00CD: stloc.0
    IL_00D2: call 0x0600040D
    IL_00D7: br IL_00E3
    IL_00D8: ldloc.0
    IL_00D9: ldc.i4.1
    IL_00DA: IL_58
    IL_00DB: stloc.0
    IL_00DC: ldloc.0
    IL_00DD: ldc.i4.6
    IL_00DE: IL_3F
    IL_00DF: IL_24
    IL_00E0: IL_FF
    IL_00E1: IL_FF
    IL_00E2: IL_FF
    IL_00E3: ret
    }

    public void closePage() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_000A: call 0x0A000050
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000C94
    IL_0011: ldc.i4.1
    IL_0012: conv.r8
    IL_0013: stloc.1
    IL_0014: nop
    IL_0015: nop
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_001C: ldfld 0x04000C95
    IL_001D: ldnull
    IL_0022: call 0x0A000021
    IL_0027: brfalse IL_0034
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000C95
    IL_002E: ldc.i4.1
    IL_002F: conv.r8
    IL_0030: stloc.1
    IL_0031: nop
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_003B: stsfld 0x0111283F
    IL_003C: nop
    IL_003D: stloc.0
    IL_003E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000C9D
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000E: stsfld 0x013128C2
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000C9C
    IL_0017: IL_59
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001B: IL_FA
    IL_001C: IL_43
    IL_001D: IL_5A
    IL_0022: call 0x0A0000C0
    IL_0027: stfld 0x04000C9D
    IL_0028: ldarg.0
    IL_0029: IL_22
    IL_002A: nop
    IL_002B: nop
    IL_002C: IL_F0
    IL_002D: IL_43
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: nop
    IL_0037: call 0x0A000131
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000C9C
    IL_003E: IL_59
    IL_003F: IL_22
    IL_0040: nop
    IL_0045: stsfld 0x285A44BB
    IL_0046: IL_C0
    IL_0047: nop
    IL_0048: nop
    IL_0049: stloc.0
    IL_004E: stfld 0x04000C9E
    IL_004F: ldarg.0
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: IL_AA
    IL_0054: IL_43
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_0058: shr
    IL_0059: IL_43
    IL_005E: call 0x0A000131
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000C9C
    IL_0065: IL_59
    IL_0066: IL_22
    IL_0067: nop
    IL_0068: nop
    IL_0069: IL_FA
    IL_006A: IL_43
    IL_006B: IL_5A
    IL_0070: call 0x0A0000C0
    IL_0075: stfld 0x04000C9F
    IL_0076: ldc.i4.0
    IL_007B: call 0x0A0000D6
    IL_0080: brfalse IL_00C4
    IL_0085: call 0x0A0000D7
    IL_0086: stloc.2
    IL_0088: ldloca.s 2
    IL_008D: ldfld 0x0A000023
    IL_008E: ldarg.0
    IL_0093: ldfld 0x04000C93
    IL_0094: IL_41
    IL_0095: pop
    IL_0096: nop
    IL_0097: nop
    IL_0098: nop
    IL_0099: ldarg.0
    IL_009A: ldc.i4.1
    IL_009F: stfld 0x04000C8E
    IL_00A0: ldarg.0
    IL_00A5: call 0x0A0000D7
    IL_00A6: stloc.3
    IL_00A8: ldloca.s 3
    IL_00AD: ldfld 0x0A00005E
    IL_00B2: stfld 0x04000C91
    IL_00B3: ldarg.0
    IL_00B4: ldarg.0
    IL_00B9: ldfld 0x04000C90
    IL_00BE: stfld 0x04000C92
    IL_00C3: br IL_00DD
    IL_00C4: ldc.i4.0
    IL_00C9: call 0x0A0000D8
    IL_00CE: brfalse IL_00DD
    IL_00CF: ldarg.0
    IL_00D0: ldc.i4.0
    IL_00D5: stfld 0x04000C8E
    IL_00D6: ldarg.0
    IL_00D7: ldc.i4.0
    IL_00DC: stfld 0x04000C8F
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x04000C8E
    IL_00E7: brfalse IL_016E
    IL_00EC: call 0x0A0000D7
    IL_00EE: stloc.s 4
    IL_00F0: ldloca.s 4
    IL_00F5: ldfld 0x0A00005E
    IL_00F6: ldarg.0
    IL_00FB: ldfld 0x04000C91
    IL_00FC: IL_59
    IL_0101: call 0x0A00007F
    IL_0102: IL_22
    IL_0103: nop
    IL_0104: nop
    IL_0107: ldloc 17219
    IL_0108: ldloc.1
    IL_0109: nop
    IL_010A: nop
    IL_010B: nop
    IL_010C: ldarg.0
    IL_010D: ldc.i4.1
    IL_0112: stfld 0x04000C8F
    IL_0113: ldarg.0
    IL_0118: call 0x0A0000D7
    IL_011A: stloc.s 5
    IL_011C: ldloca.s 5
    IL_0121: ldfld 0x0A00005E
    IL_0122: ldarg.0
    IL_0127: ldfld 0x04000C91
    IL_0128: IL_59
    IL_0129: IL_22
    IL_012A: nop
    IL_012B: nop
    IL_012C: IL_F0
    IL_012D: IL_43
    IL_0132: call 0x0A0000D9
    IL_0133: conv.i2
    IL_0134: add
    IL_0135: IL_5A
    IL_0136: ldarg.0
    IL_013B: ldfld 0x04000C92
    IL_013C: IL_58
    IL_0141: stfld 0x04000C90
    IL_0142: ldarg.0
    IL_0143: ldarg.0
    IL_0148: ldfld 0x04000C90
    IL_0149: IL_22
    IL_014A: nop
    IL_014B: nop
    IL_014C: nop
    IL_014D: nop
    IL_0152: call 0x0A000114
    IL_0157: stfld 0x04000C90
    IL_0158: ldarg.0
    IL_0159: ldarg.0
    IL_015E: ldfld 0x04000C90
    IL_015F: IL_22
    IL_0160: nop
    IL_0161: nop
    IL_0162: IL_96
    IL_0163: IL_C3
    IL_0168: call 0x0A00019C
    IL_016D: stfld 0x04000C90
    IL_0172: ldstr 0x70000575
    IL_0177: call 0x0A000097
    IL_0178: stloc.0
    IL_0179: ldloc.0
    IL_017E: ldstr 0x70000583
    IL_017F: conv.r8
    IL_0180: len
    IL_0181: nop
    IL_0182: nop
    IL_0183: stloc.0
    IL_0188: brtrue IL_01B8
    IL_0189: ldarg.0
    IL_018E: ldstr 0x70001EA5
    IL_0193: call 0x06000220
    IL_0198: stfld 0x04000C98
    IL_0199: ldarg.0
    IL_019E: ldstr 0x700004D5
    IL_01A3: call 0x06000220
    IL_01A8: stfld 0x04000C99
    IL_01AD: ldstr 0x70000575
    IL_01B2: ldstr 0x70022ADA
    IL_01B7: call 0x0A00008F
    IL_01BC: ldstr 0x7000064F
    IL_01C1: call 0x0A000095
    IL_01C2: stloc.1
    IL_01C3: ldloc.1
    IL_01C4: ldc.i4.1
    IL_0275: switch (43 cases)
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000C6B
    IL_0040: call 0x0A0000DF
    IL_0042: ldc.i4.s -10
    IL_0047: call 0x0A0000EF
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_E0
    IL_004C: IL_42
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: nop
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0059: stsfld 0x00002243
    IL_005A: nop
    IL_005B: IL_42
    IL_0060: call 0x0600021D
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000C76
    IL_006B: call 0x0A0000E0
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_0070: ldloca.s 67
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_C0
    IL_280000101: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000CED
    IL_000C: ldarg.0
    IL_000D: ldc.i4.5
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000CEE
    IL_0018: ldarg.0
    IL_0019: ldc.i4.4
    IL_001E: newarr 0x0100003C
    IL_0023: stfld 0x04000CF1
    IL_0024: ldarg.0
    IL_0026: ldc.i4.s 17
    IL_002B: newarr 0x0100003C
    IL_0030: stfld 0x04000CF9
    IL_0031: ldarg.0
    IL_0033: ldc.i4.s 35
    IL_0038: newarr 0x0100003C
    IL_003D: stfld 0x04000CFA
    IL_003E: ldarg.0
    IL_003F: ldc.i4.6
    IL_0044: newarr 0x0100000B
    IL_0049: stfld 0x04000CFB
    IL_004A: ldarg.0
    IL_004B: ldc.i4.6
    IL_0050: newarr 0x0100000B
    IL_0055: stfld 0x04000CFC
    IL_0056: ldarg.0
    IL_0057: ldc.i4.6
    IL_005C: newarr 0x01000010
    IL_0061: stfld 0x04000CFD
    IL_0062: ldarg.0
    IL_0063: ldc.i4.2
    IL_0068: newarr 0x0100003C
    IL_006D: stfld 0x04000CFE
    IL_006E: ldarg.0
    IL_006F: IL_22
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_22
    IL_0075: nop
    IL_0076: nop
    IL_0077: nop
    IL_0078: nop
    IL_0079: IL_22
    IL_007A: nop
    IL_007B: nop
    IL_007C: nop
    IL_007D: nop
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0082: IL_3F
    IL_0087: newobj 0x0A0000C4
    IL_008C: stfld 0x04000D0F
    IL_008D: ldarg.0
    IL_008E: IL_22
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_93
    IL_0092: IL_43
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_A4
    IL_0097: IL_42
    IL_009C: newobj 0x0A000038
    IL_00A1: stfld 0x04000D2F
    IL_00A2: ldarg.0
    IL_00A3: IL_22
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: ldelem.i1
    IL_00A7: IL_43
    IL_00A8: IL_22
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: IL_C0
    IL_00AC: IL_42
    IL_00B1: newobj 0x0A000038
    IL_00B6: stfld 0x04000D30
    IL_00B7: ldarg.0
    IL_00B9: ldc.i4.s 20
    IL_00BE: newarr 0x0100000B
    IL_00C3: stfld 0x04000D4C
    IL_00C4: ldarg.0
    IL_00C6: ldc.i4.s 20
    IL_00CB: newarr 0x0100000B
    IL_00D0: stfld 0x04000D4D
    IL_00D1: ldarg.0
    IL_00D3: ldc.i4.s 16
    IL_00D8: newarr 0x0100000B
    IL_00D9: dup
    IL_00DE: ldtoken 0x040010CB
    IL_00E3: call 0x0A00018C
    IL_00E8: stfld 0x04000D4E
    IL_00E9: ldarg.0
    IL_00EB: ldc.i4.s 10
    IL_00F0: newarr 0x0100000B
    IL_00F1: dup
    IL_00F6: ldtoken 0x040010CC
    IL_00FB: call 0x0A00018C
    IL_0100: stfld 0x04000D4F
    IL_0101: ldarg.0
    IL_0103: ldc.i4.s 10
    IL_0108: newarr 0x0100000B
    IL_0109: dup
    IL_010E: ldtoken 0x040010CD
    IL_0113: call 0x0A00018C
    IL_0118: stfld 0x04000D50
    IL_0119: ldarg.0
    IL_011B: ldc.i4.s 26
    IL_0120: newarr 0x0100000B
    IL_0125: stfld 0x04000D51
    IL_0126: ldarg.0
    IL_0128: ldc.i4.s 26
    IL_012D: newarr 0x0100000B
    IL_0132: stfld 0x04000D52
    IL_0133: ldarg.0
    IL_0135: ldc.i4.s 26
    IL_013A: newarr 0x0100000B
    IL_013F: stfld 0x04000D53
    IL_0140: ldarg.0
    IL_0141: ldc.i4.5
    IL_0146: newarr 0x0100000B
    IL_014B: stfld 0x04000D54
    IL_014C: ldarg.0
    IL_0151: call 0x0A000001
    IL_0152: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000001
    IL_000A: call 0x0A000004
    IL_000B: conv.r8
    IL_000C: ldarg.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: stfld 0x04000D08
    IL_0015: ldarg.0
    IL_001A: ldstr 0x70001FB1
    IL_001F: call 0x060003F9
    IL_0024: stfld 0x04000D51
    IL_0025: ldarg.0
    IL_002A: ldstr 0x70001563
    IL_002F: call 0x060003F9
    IL_0034: stfld 0x04000D52
    IL_0035: ldarg.0
    IL_003A: ldstr 0x70000DDD
    IL_003F: call 0x06000220
    IL_0044: stfld 0x04000D21
    IL_0045: ldarg.0
    IL_0046: ldarg.0
    IL_004B: ldfld 0x04000D0B
    IL_004C: conv.r8
    IL_004D: IL_88
    IL_004E: nop
    IL_004F: nop
    IL_0051: br.s IL_00CF
    IL_0053: ldloca.s 13
    IL_0054: nop
    IL_0055: ldarg.2
    IL_0056: ldarg.0
    IL_0057: ldarg.0
    IL_005C: call 0x2B000053
    IL_0061: stfld 0x04000D56
    IL_0062: ldarg.0
    IL_0063: ldarg.0
    IL_0068: call 0x2B000052
    IL_006D: stfld 0x04000D17
    IL_006E: ldarg.0
    IL_006F: ldarg.0
    IL_0074: ldfld 0x04000D08
    IL_0075: conv.r8
    IL_0077: blt.s IL_0078
    IL_0078: nop
    IL_007A: br.s IL_00F8
    IL_007C: starg.s 13
    IL_007D: nop
    IL_007E: ldarg.2
    IL_007F: ldarg.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000D0A
    IL_0086: conv.r8
    IL_0087: pop
    IL_0088: nop
    IL_0089: nop
    IL_008B: br.s IL_0109
    IL_008D: ldloc.s 13
    IL_008E: nop
    IL_008F: ldarg.2
    IL_0090: ldarg.0
    IL_0095: ldstr 0x70001EB5
    IL_009A: call 0x06000220
    IL_009F: stfld 0x04000D34
    IL_00A0: ldarg.0
    IL_00A5: ldstr 0x70001EBD
    IL_00AA: call 0x06000220
    IL_00AF: stfld 0x04000D35
    IL_00B0: ldarg.0
    IL_00B5: ldstr 0x70000BB3
    IL_00BA: call 0x0A000095
    IL_00BF: stfld 0x04000D31
    IL_00C0: ldarg.0
    IL_00C5: ldstr 0x70001FB9
    IL_00CA: call 0x060003F9
    IL_00CF: stfld 0x04000D53
    IL_00D0: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000D24
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000D25
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000667
    IL_002A: call 0x060003F9
    IL_002F: stfld 0x04000D54
    IL_0030: ldarg.0
    IL_0035: ldstr 0x70001EE5
    IL_003A: call 0x060003F9
    IL_003F: stfld 0x04000D4C
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70001EED
    IL_004A: call 0x060003F9
    IL_004F: stfld 0x04000D4D
    IL_0050: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70002093
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000D5B
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000D5B
    IL_0016: ldc.i4.3
    IL_006F: switch (21 cases)
    IL_0070: IL_94
    IL_0075: call 0x06000668
    IL_0076: ldarg.0
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000D52
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000D1E
    IL_0083: IL_94
    IL_0088: call 0x06000669
    IL_0089: ldarg.0
    IL_008A: ldarg.0
    IL_008F: ldfld 0x04000D3B
    IL_0094: stfld 0x04000D4A
    IL_0095: ldarg.0
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000D3C
    IL_00A0: stfld 0x04000D4B
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000D11
    IL_00A7: ldarg.0
    IL_00AC: ldfld 0x04000D3B
    IL_00AD: ldarg.0
    IL_00B2: ldfld 0x04000D3C
    IL_00B3: conv.r8
    IL_00B4: IL_E8
    IL_00B5: IL_01
    IL_00B6: nop
    IL_00B7: ldloc.0
    IL_00B8: ldarg.0
    IL_00BD: call 0x0A0000DA
    IL_00BE: conv.i2
    IL_00BF: IL_22
    IL_00C0: nop
    IL_00C1: nop
    IL_00C2: IL_C0
    IL_00C3: IL_3E
    IL_00C4: IL_5A
    IL_00C9: stfld 0x04000D38
    IL_00CA: ldarg.0
    IL_00CF: ldc.i4 -380
    IL_00D4: stfld 0x04000D18
    IL_00D5: ldarg.0
    IL_00DA: ldc.i4 480
    IL_00DF: stfld 0x04000D19
    IL_00E0: ldarg.0
    IL_00E5: ldc.i4 320
    IL_00EA: stfld 0x04000D1A
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x04000D08
    IL_00F1: conv.r8
    IL_00F2: ret
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: stloc.0
    IL_00FA: ldstr 0x70001805
    IL_00FB: conv.r8
    IL_00FC: IL_3C
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: stloc.0
    IL_0100: pop
    IL_0105: ldstr 0x70000121
    IL_010A: call 0x0A000004
    IL_010B: ldnull
    IL_0110: call 0x0A000061
    IL_0115: brfalse IL_013B
    IL_0116: ldarg.0
    IL_0117: ldarg.0
    IL_011C: ldfld 0x04000D15
    IL_0121: call 0x0A00001B
    IL_0126: call 0x0A000013
    IL_012B: call 0x0A000014
    IL_012C: conv.u4
    IL_012D: ldarg.1
    IL_012E: nop
    IL_012F: nop
    IL_0130: IL_01
    IL_0135: stfld 0x04000D14
    IL_013A: br IL_0150
    IL_013B: ldarg.0
    IL_0140: ldstr 0x70000121
    IL_0145: call 0x0A000004
    IL_0146: conv.r8
    IL_0147: ldarg.3
    IL_0148: nop
    IL_0149: nop
    IL_014A: stloc.0
    IL_014F: stfld 0x04000D14
    IL_0150: ldarg.0
    IL_0155: ldfld 0x04000D14
    IL_0156: ldnull
    IL_015B: call 0x0A000021
    IL_0160: brfalse IL_0172
    IL_0161: ldarg.0
    IL_0162: ldarg.0
    IL_0167: ldfld 0x04000D14
    IL_0168: conv.r8
    IL_016D: ldsfld 0x7D2B0000
    IL_016E: ldc.i4.0
    IL_016F: stloc.3
    IL_0170: nop
    IL_0171: ldarg.2
    IL_0172: ldc.i4.0
    IL_0173: stloc.0
    IL_0178: br IL_01B5
    IL_0179: ldarg.0
    IL_017E: ldfld 0x04000CFB
    IL_017F: ldloc.0
    IL_0180: ldarg.0
    IL_0185: ldfld 0x04000D56
    IL_0186: ldarg.0
    IL_018B: ldfld 0x04000D51
    IL_018C: ldloc.0
    IL_018D: IL_94
    IL_018E: conv.r8
    IL_018F: IL_FB
    IL_0190: ldloc.0
    IL_0191: nop
    IL_0192: ldloc.0
    IL_0193: ldelem.i8
    IL_0194: ldarg.0
    IL_0199: ldfld 0x04000CFD
    IL_019A: ldloc.0
    IL_019B: ldarg.0
    IL_01A0: ldfld 0x04000D51
    IL_01A1: ldloc.0
    IL_01A2: IL_94
    IL_01A7: ldc.i4 100000
    IL_01A8: mul
    IL_01AD: ldc.i4 10000
    IL_01AE: add
    IL_01AF: neg
    IL_01B0: ldelem.i4
    IL_01B1: ldloc.0
    IL_01B2: ldc.i4.1
    IL_01B3: IL_58
    IL_01B4: stloc.0
    IL_01B5: ldloc.0
    IL_01B6: ldarg.0
    IL_01BB: ldfld 0x04000D34
    IL_01BC: IL_3F
    IL_01BD: IL_B8
    IL_01BE: IL_FF
    IL_01BF: IL_FF
    IL_01C0: IL_FF
    IL_01C1: ldc.i4.0
    IL_01C2: stloc.1
    IL_01C7: br IL_01DF
    IL_01C8: ldarg.0
    IL_01CD: ldfld 0x04000CFC
    IL_01CE: ldloc.1
    IL_01CF: ldarg.0
    IL_01D4: ldfld 0x04000D52
    IL_01D5: ldloc.1
    IL_01D6: IL_94
    IL_01D8: ldc.i4.s 100
    IL_01D9: mul
    IL_01DA: ldelem.i8
    IL_01DB: ldloc.1
    IL_01DC: ldc.i4.1
    IL_01DD: IL_58
    IL_01DE: stloc.1
    IL_01DF: ldloc.1
    IL_01E0: ldarg.0
    IL_01E5: ldfld 0x04000D35
    IL_01E6: IL_3F
    IL_01E7: IL_DD
    IL_01E8: IL_FF
    IL_01E9: IL_FF
    IL_01EA: IL_FF
    IL_01EB: ldarg.0
    IL_01F0: ldfld 0x04000D09
    IL_01F5: call 0x0A00001B
    IL_01F6: conv.r8
    IL_01F7: IL_AF
    IL_01F8: nop
    IL_01F9: nop
    IL_01FA: stloc.0
    IL_01FF: ldstr 0x70000617
    IL_0200: ldc.i4.6
    IL_0205: call 0x0A00009F
    IL_0206: ret
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000D5C
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000D5C
    IL_0010: ret
    }

    public void Cost_upgrade() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D5B
    IL_0006: ldc.i4.3
    IL_000B: beq IL_0046
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000D39
    IL_0014: ldc.i4.s 12
    IL_0015: IL_5A
    IL_0016: ldc.i4.7
    IL_0017: IL_58
    IL_0018: conv.i2
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: IL_3F
    IL_001E: IL_5A
    IL_001F: IL_22
    IL_0020: IL_CD
    IL_0021: IL_CC
    IL_0022: IL_CC
    IL_0023: IL_3E
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04000D57
    IL_002A: ldc.i4.1
    IL_002B: IL_58
    IL_002C: conv.i2
    IL_002D: IL_5A
    IL_002E: IL_22
    IL_002F: ldelem.i
    IL_0030: IL_99
    IL_0031: ldc.i4.3
    IL_0032: IL_3F
    IL_0033: IL_58
    IL_0034: IL_5A
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: IL_50
    IL_0039: IL_41
    IL_003A: IL_5A
    IL_003B: not
    IL_0040: stfld 0x04000D55
    IL_0045: br IL_004D
    IL_0046: ldarg.0
    IL_0047: ldc.i4.0
    IL_004C: stfld 0x04000D55
    IL_004D: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000D36
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000D37
    IL_000E: ret
    }

    public void SetUpWeapon() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D56
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_FD
    IL_0009: ldloc.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000D56
    IL_0017: ldfld 0x04000FEC
    IL_001C: stfld 0x04000D39
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000D56
    IL_0028: ldfld 0x04000FF7
    IL_002D: stfld 0x04000D3A
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000D56
    IL_0039: ldfld 0x04000FED
    IL_003E: stfld 0x04000D3B
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000D56
    IL_004A: ldfld 0x04000FEE
    IL_004F: stfld 0x04000D3C
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000D56
    IL_005B: ldfld 0x04000FF4
    IL_0060: stfld 0x04000D3D
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000D56
    IL_006C: ldfld 0x04000FEF
    IL_0071: stfld 0x04000D3E
    IL_0072: ldarg.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000D56
    IL_007D: ldfld 0x04000FF0
    IL_007E: ldarg.0
    IL_0083: ldfld 0x04000D53
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000D1F
    IL_008A: IL_94
    IL_008B: IL_58
    IL_0090: stfld 0x04000D3F
    IL_0091: ldarg.0
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000D56
    IL_009C: ldfld 0x04000FF1
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x04000D53
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04000D1F
    IL_00A9: IL_94
    IL_00AA: IL_58
    IL_00AF: stfld 0x04000D40
    IL_00B0: ldarg.0
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000D56
    IL_00BB: ldfld 0x04000FF2
    IL_00C0: stfld 0x04000D41
    IL_00C1: ldarg.0
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x04000D56
    IL_00CC: ldfld 0x04000FF3
    IL_00D1: stfld 0x04000D42
    IL_00D2: ldarg.0
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000D56
    IL_00DD: ldfld 0x04000FF6
    IL_00E2: stfld 0x04000D43
    IL_00E3: ldarg.0
    IL_00E4: ldarg.0
    IL_00E9: ldfld 0x04000D56
    IL_00EE: ldfld 0x04000FF5
    IL_00F3: stfld 0x04000D44
    IL_00F4: ldarg.0
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x04000D3D
    IL_00FB: ldc.i4.2
    IL_00FC: IL_58
    IL_00FD: ldc.i4.6
    IL_0102: call 0x0A00010B
    IL_0107: stfld 0x04000D45
    IL_0108: ret
    }

    public void SetUpArmor() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0003: ldc.i4.s 100
    IL_0004: mul
    IL_0009: stfld 0x04000D47
    IL_000A: ldarg.0
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000D4E
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000D1D
    IL_0017: IL_94
    IL_001C: stfld 0x04000D46
    IL_001D: ldarg.1
    IL_001F: ldc.i4.s 100
    IL_0020: add
    IL_0022: starg.s 1
    IL_0023: ldc.i4.2
    IL_0028: newarr 0x0100000B
    IL_0029: stloc.0
    IL_002A: ldc.i4.0
    IL_002B: stloc.1
    IL_0030: br IL_0042
    IL_0031: ldloc.0
    IL_0032: ldloc.1
    IL_0033: ldarg.1
    IL_0035: ldc.i4.s 10
    IL_0036: mul
    IL_0037: ldelem.i8
    IL_0038: ldarg.1
    IL_003A: ldc.i4.s 10
    IL_003B: add
    IL_003D: starg.s 1
    IL_003E: ldloc.1
    IL_003F: ldc.i4.1
    IL_0040: IL_58
    IL_0041: stloc.1
    IL_0042: ldloc.1
    IL_0043: ldc.i4.2
    IL_0044: IL_3F
    IL_0045: IL_E8
    IL_0046: IL_FF
    IL_0047: IL_FF
    IL_0048: IL_FF
    IL_0049: ldarg.0
    IL_004A: ldloc.0
    IL_004B: ldc.i4.1
    IL_004C: IL_94
    IL_0051: stfld 0x04000D48
    IL_0052: ldarg.0
    IL_0053: ldarg.1
    IL_0058: stfld 0x04000D49
    IL_0059: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D2C
    IL_000A: brtrue IL_00CD
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000D18
    IL_0012: ldc.i4.s -64
    IL_0013: IL_3C
    IL_0015: brfalse.s IL_0016
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000D18
    IL_001F: conv.i2
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000D18
    IL_0026: shl
    IL_0027: conv.i2
    IL_002C: call 0x0A000024
    IL_002D: IL_22
    IL_002E: nop
    IL_002F: nop
    IL_0030: ldc.i4.0
    IL_0031: IL_44
    IL_0032: IL_5A
    IL_0037: call 0x0A000114
    IL_0038: IL_58
    IL_0039: not
    IL_003E: stfld 0x04000D18
    IL_0043: br IL_00CD
    IL_0044: ldarg.0
    IL_0046: ldc.i4.s -64
    IL_004B: stfld 0x04000D18
    IL_004C: ldarg.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000D19
    IL_0053: conv.i2
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000D19
    IL_005A: conv.i2
    IL_005F: call 0x0A000024
    IL_0060: IL_22
    IL_0061: nop
    IL_0066: stsfld 0x285A44BB
    IL_0067: ldnull
    IL_0068: IL_01
    IL_0069: nop
    IL_006A: stloc.0
    IL_006B: IL_59
    IL_006C: not
    IL_0071: stfld 0x04000D19
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04000D19
    IL_0078: ldc.i4.0
    IL_0079: IL_3D
    IL_007A: IL_4F
    IL_007B: nop
    IL_007C: nop
    IL_007D: nop
    IL_007E: ldarg.0
    IL_007F: ldc.i4.0
    IL_0084: stfld 0x04000D19
    IL_0085: ldarg.0
    IL_0086: ldarg.0
    IL_008B: ldfld 0x04000D1A
    IL_008C: conv.i2
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000D1A
    IL_0093: conv.i2
    IL_0098: call 0x0A000024
    IL_0099: IL_22
    IL_009A: nop
    IL_009B: nop
    IL_009C: IL_FA
    IL_009D: IL_43
    IL_009E: IL_5A
    IL_00A3: call 0x0A000114
    IL_00A4: IL_59
    IL_00A5: not
    IL_00AA: stfld 0x04000D1A
    IL_00AB: ldarg.0
    IL_00B0: ldfld 0x04000D1A
    IL_00B5: ldc.i4 240
    IL_00B6: IL_3D
    IL_00B8: ldloca.s 0
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: ldarg.0
    IL_00C0: ldc.i4 240
    IL_00C5: stfld 0x04000D1A
    IL_00C6: ldarg.0
    IL_00C7: ldc.i4.1
    IL_00CC: stfld 0x04000D2C
    IL_00CD: ldc.i4.0
    IL_00D2: call 0x0A0000D6
    IL_00D7: brfalse IL_011B
    IL_00DC: call 0x0A0000D7
    IL_00DD: stloc.1
    IL_00DF: ldloca.s 1
    IL_00E4: ldfld 0x0A000023
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x04000D38
    IL_00EB: IL_41
    IL_00EC: pop
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: ldarg.0
    IL_00F1: ldc.i4.1
    IL_00F6: stfld 0x04000D27
    IL_00F7: ldarg.0
    IL_00FC: call 0x0A0000D7
    IL_00FD: stloc.2
    IL_00FF: ldloca.s 2
    IL_0104: ldfld 0x0A00005E
    IL_0109: stfld 0x04000D2A
    IL_010A: ldarg.0
    IL_010B: ldarg.0
    IL_0110: ldfld 0x04000D29
    IL_0115: stfld 0x04000D2B
    IL_011A: br IL_0134
    IL_011B: ldc.i4.0
    IL_0120: call 0x0A0000D8
    IL_0125: brfalse IL_0134
    IL_0126: ldarg.0
    IL_0127: ldc.i4.0
    IL_012C: stfld 0x04000D27
    IL_012D: ldarg.0
    IL_012E: ldc.i4.0
    IL_0133: stfld 0x04000D28
    IL_0134: ldarg.0
    IL_0139: ldfld 0x04000D27
    IL_013E: brfalse IL_01C4
    IL_0143: call 0x0A0000D7
    IL_0144: stloc.3
    IL_0146: ldloca.s 3
    IL_014B: ldfld 0x0A00005E
    IL_014C: ldarg.0
    IL_0151: ldfld 0x04000D2A
    IL_0152: IL_59
    IL_0157: call 0x0A00007F
    IL_0158: IL_22
    IL_0159: nop
    IL_015A: nop
    IL_015B: nop
    IL_015C: IL_41
    IL_015D: IL_43
    IL_015E: ldloc.1
    IL_015F: nop
    IL_0160: nop
    IL_0161: nop
    IL_0162: ldarg.0
    IL_0163: ldc.i4.1
    IL_0168: stfld 0x04000D28
    IL_0169: ldarg.0
    IL_016E: call 0x0A0000D7
    IL_0170: stloc.s 4
    IL_0172: ldloca.s 4
    IL_0177: ldfld 0x0A00005E
    IL_0178: ldarg.0
    IL_017D: ldfld 0x04000D2A
    IL_017E: IL_59
    IL_017F: IL_22
    IL_0180: nop
    IL_0181: nop
    IL_0182: IL_F0
    IL_0183: IL_43
    IL_0188: call 0x0A0000D9
    IL_0189: conv.i2
    IL_018A: add
    IL_018B: IL_5A
    IL_018C: ldarg.0
    IL_0191: ldfld 0x04000D2B
    IL_0192: IL_58
    IL_0197: stfld 0x04000D29
    IL_0198: ldarg.0
    IL_0199: ldarg.0
    IL_019E: ldfld 0x04000D29
    IL_019F: IL_22
    IL_01A0: nop
    IL_01A1: nop
    IL_01A2: nop
    IL_01A3: nop
    IL_01A8: call 0x0A000114
    IL_01AD: stfld 0x04000D29
    IL_01AE: ldarg.0
    IL_01AF: ldarg.0
    IL_01B4: ldfld 0x04000D29
    IL_01B5: IL_22
    IL_01B6: nop
    IL_01B7: nop
    IL_01B8: IL_96
    IL_01B9: IL_C3
    IL_01BE: call 0x0A00019C
    IL_01C3: stfld 0x04000D29
    IL_01C4: ldarg.0
    IL_01C9: ldfld 0x04000D36
    IL_01CE: brfalse IL_0203
    IL_01CF: ldarg.0
    IL_01D0: dup
    IL_01D5: ldfld 0x04000D37
    IL_01DA: call 0x0A000024
    IL_01DB: IL_59
    IL_01E0: stfld 0x04000D37
    IL_01E1: ldarg.0
    IL_01E6: ldfld 0x04000D37
    IL_01E7: IL_22
    IL_01E8: nop
    IL_01E9: nop
    IL_01EA: nop
    IL_01EB: nop
    IL_01EC: IL_42
    IL_01EE: ldloca.s 0
    IL_01EF: nop
    IL_01F0: nop
    IL_01F1: ldarg.0
    IL_01F2: ldc.i4.0
    IL_01F7: stfld 0x04000D36
    IL_01F8: ldarg.0
    IL_01F9: IL_22
    IL_01FA: nop
    IL_01FB: nop
    IL_01FC: nop
    IL_01FD: nop
    IL_0202: stfld 0x04000D37
    IL_0203: ldarg.0
    IL_0208: ldfld 0x04000D1B
    IL_0209: ldc.i4.1
    IL_02AA: switch (39 cases)
    IL_02AB: IL_58
    IL_02B0: stfld 0x04000D58
    IL_02B1: ldarg.0
    IL_02B2: IL_22
    IL_02B3: ldelem.i
    IL_02B4: IL_99
    IL_02B5: IL_99
    IL_02B6: IL_3F
    IL_02BB: stfld 0x04000D37
    IL_02C0: br IL_03AC
    IL_02C1: ldarg.0
    IL_02C6: ldfld 0x04000D0C
    IL_02C7: conv.r8
    IL_02C8: stloc.0
    IL_02C9: nop
    IL_02CA: nop
    IL_02CB: stloc.0
    IL_02CC: ldc.i4.1
    IL_02CD: conv.r8
    IL_02CE: stloc.1
    IL_02CF: nop
    IL_02D0: nop
    IL_02D1: stloc.0
    IL_02D2: ldarg.0
    IL_02D7: ldfld 0x04000D0C
    IL_02DC: call 0x0A00001B
    IL_02DD: conv.r8
    IL_02DE: IL_AF
    IL_02DF: nop
    IL_02E0: nop
    IL_02E1: stloc.0
    IL_02E2: ldarg.0
    IL_02E3: ldc.i4.4
    IL_02E8: stfld 0x04000D1B
    IL_02E9: ldarg.0
    IL_02EA: ldc.i4.0
    IL_02EF: stfld 0x04000D58
    IL_02F0: ldarg.0
    IL_02F1: IL_22
    IL_02F2: nop
    IL_02F3: nop
    IL_02F4: nop
    IL_02F5: nop
    IL_02FA: stfld 0x04000D37
    IL_02FB: ldarg.0
    IL_02FC: IL_22
    IL_02FD: nop
    IL_02FE: nop
    IL_0303: stsfld 0x0667283F
    IL_0304: nop
    IL_0305: ldloc.0
    IL_0306: ldarg.0
    IL_030B: ldfld 0x04000D53
    IL_030C: ldarg.0
    IL_0311: ldfld 0x04000D1F
    IL_0312: IL_8F
    IL_0313: stloc.1
    IL_0314: nop
    IL_0315: nop
    IL_0316: IL_01
    IL_0317: dup
    IL_031A: stloc 31490
    IL_031C: blt.s IL_032A
    IL_031D: nop
    IL_031E: ldarg.2
    IL_031F: IL_58
    IL_0320: IL_54
    IL_0321: ldarg.0
    IL_0326: ldfld 0x04000D51
    IL_0327: ldarg.0
    IL_032C: ldfld 0x04000D1F
    IL_032D: IL_8F
    IL_032E: stloc.1
    IL_032F: nop
    IL_0330: nop
    IL_0331: IL_01
    IL_0332: dup
    IL_0335: stloc 40992
    IL_0336: IL_86
    IL_0337: IL_01
    IL_0338: nop
    IL_0339: IL_58
    IL_033A: IL_54
    IL_033B: ldarg.0
    IL_033C: ldarg.0
    IL_0341: ldfld 0x04000D51
    IL_0342: ldarg.0
    IL_0347: ldfld 0x04000D1F
    IL_0348: IL_94
    IL_034D: call 0x06000668
    IL_0352: ldstr 0x70001FB9
    IL_0353: ldarg.0
    IL_0358: ldfld 0x04000D53
    IL_035D: call 0x060003F8
    IL_035E: pop
    IL_0363: ldstr 0x70001FB1
    IL_0364: ldarg.0
    IL_0369: ldfld 0x04000D51
    IL_036E: call 0x060003F8
    IL_036F: pop
    IL_0370: ldarg.0
    IL_0375: ldfld 0x04000D1F
    IL_0376: ldarg.0
    IL_037B: ldfld 0x04000D20
    IL_042C: switch (43 cases)
    IL_042D: IL_22
    IL_042E: stloc.3
    IL_042F: nop
    IL_0430: ldarg.2
    IL_0431: ldc.i4.1
    IL_051E: switch (58 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    public void Impact() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_0006: conv.r8
    IL_0007: IL_4D
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_000C: ldc.i4.6
    IL_000E: ldc.i4.s 32
    IL_0013: call 0x0A000045
    IL_0014: conv.i2
    IL_0015: ldarg.0
    IL_001A: ldfld 0x04000D59
    IL_001B: IL_58
    IL_0020: stfld 0x04000D5A
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000D5A
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_50
    IL_002C: IL_43
    IL_0031: call 0x0A000114
    IL_0036: stfld 0x04000D5A
    IL_0037: ret
    }

    public void HideCha() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_003A
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000D08
    IL_000C: IL_22
    IL_000D: IL_8F
    IL_000E: IL_C2
    IL_000F: IL_F5
    IL_0010: IL_BC
    IL_0011: IL_22
    IL_0012: IL_29
    IL_0013: sub
    IL_0014: IL_8F
    IL_0015: IL_BE
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_1D9EA: switch (30323 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D13
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000D13
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000D13
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000D0E
    IL_0040: call 0x0A0000DF
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000D18
    IL_0047: conv.i2
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldelem.r8
    IL_0051: IL_43
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldelem.r8
    IL_0056: IL_43
    IL_005B: call 0x0600021D
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000CD8
    IL_0066: call 0x0A0000E0
    IL_0067: IL_22
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_F0
    IL_006B: IL_42
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_006F: IL_F0
    IL_0070: IL_41
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_C8
    IL_0075: IL_42
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_007B: ldloc 10306
    IL_007C: ldc.i4.7
    IL_007D: ldarg.0
    IL_007E: nop
    IL_007F: ldloc.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000CD9
    IL_008A: call 0x0A0000E0
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_54
    IL_008F: IL_43
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0093: stloc.2
    IL_0094: IL_42
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: ldelem.r8
    IL_0099: IL_42
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_C0
    IL_009E: IL_41
    IL_00A3: call 0x0600021D
    IL_00A8: ldsfld 0x040007B2
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000D31
    IL_00B0: ldc.i4.s 73
    IL_00B5: call 0x0A0000E1
    IL_00BA: call 0x0A0002EA
    IL_00BB: IL_22
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: IL_E0
    IL_00BF: IL_42
    IL_00C0: IL_22
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00CC: stsfld 0x00002243
    IL_00CD: nop
    IL_00CE: IL_42
    IL_00D3: call 0x0600021D
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000CE7
    IL_00DE: call 0x0A0000E0
    IL_00DF: IL_22
    IL_00E0: nop
    IL_00E1: nop
    IL_00E3: ldloca.s 67
    IL_00E4: IL_22
    IL_00E5: nop
    IL_00E6: nop
    IL_00E7: IL_C0
    IL_280000174: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000D63
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04000D64
    IL_000E: ldarg.0
    IL_000F: ldc.i4.m1
    IL_0014: stfld 0x04000D65
    IL_0015: ldarg.0
    IL_0017: ldc.i4.s 12
    IL_001C: newarr 0x0100003C
    IL_0021: stfld 0x04000D6A
    IL_0022: ldarg.0
    IL_0024: ldc.i4.s 12
    IL_0029: newarr 0x0100000B
    IL_002E: stfld 0x04000D6C
    IL_002F: ldarg.0
    IL_0031: ldc.i4.s 12
    IL_0036: newarr 0x0100000B
    IL_003B: stfld 0x04000D6D
    IL_003C: ldarg.0
    IL_003E: ldc.i4.s 12
    IL_0043: newarr 0x0100000B
    IL_0048: stfld 0x04000D6E
    IL_0049: ldarg.0
    IL_004B: ldc.i4.s 12
    IL_0050: newarr 0x0100000B
    IL_0055: stfld 0x04000D6F
    IL_0056: ldarg.0
    IL_0058: ldc.i4.s 12
    IL_005D: newarr 0x01000010
    IL_0062: stfld 0x04000D70
    IL_0063: ldarg.0
    IL_0065: ldc.i4.s 12
    IL_006A: newarr 0x01000010
    IL_006F: stfld 0x04000D71
    IL_0070: ldarg.0
    IL_0072: ldc.i4.s 12
    IL_0077: newarr 0x01000013
    IL_007C: stfld 0x04000D72
    IL_007D: ldarg.0
    IL_007E: ldc.i4.2
    IL_0083: newarr 0x0100000B
    IL_0088: stfld 0x04000D73
    IL_0089: ldarg.0
    IL_008B: ldc.i4.s 50
    IL_0090: newarr 0x0100000B
    IL_0095: stfld 0x04000D74
    IL_0096: ldarg.0
    IL_0097: ldc.i4.3
    IL_009C: newarr 0x0100000B
    IL_00A1: stfld 0x04000D75
    IL_00A2: ldarg.0
    IL_00A4: ldc.i4.s 50
    IL_00A9: newarr 0x0100000B
    IL_00AE: stfld 0x04000D76
    IL_00AF: ldarg.0
    IL_00B0: ldc.i4.5
    IL_00B5: newarr 0x0100003C
    IL_00BA: stfld 0x04000D77
    IL_00BB: ldarg.0
    IL_00BC: ldc.i4.3
    IL_00C1: newarr 0x0100003C
    IL_00C6: stfld 0x04000D78
    IL_00C7: ldarg.0
    IL_00C8: ldc.i4.3
    IL_00CD: newarr 0x0100003C
    IL_00D2: stfld 0x04000D91
    IL_00D3: ldarg.0
    IL_00D4: IL_22
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: IL_F0
    IL_00D8: IL_43
    IL_00DD: stfld 0x04000DBD
    IL_00DE: ldarg.0
    IL_00DF: IL_22
    IL_00E0: nop
    IL_00E1: nop
    IL_00E2: IL_AA
    IL_00E3: IL_43
    IL_00E8: stfld 0x04000DBE
    IL_00E9: ldarg.0
    IL_00EA: IL_22
    IL_00EB: nop
    IL_00F0: stsfld 0xC17D44BB
    IL_00F1: stloc.3
    IL_00F2: nop
    IL_00F3: ldarg.2
    IL_00F4: ldarg.0
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: IL_C8
    IL_00F9: IL_C2
    IL_00FE: stfld 0x04000DC3
    IL_00FF: ldarg.0
    IL_0100: ldc.i4.m1
    IL_0105: stfld 0x04000DD2
    IL_0106: ldarg.0
    IL_0107: ldc.i4.m1
    IL_010C: stfld 0x04000DD5
    IL_010D: ldarg.0
    IL_0112: call 0x0A000001
    IL_0113: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000085
    IL_000B: stfld 0x04000DC9
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000067
    IL_0017: stfld 0x04000DCA
    IL_0018: ldarg.0
    IL_001D: ldstr 0x70000BB3
    IL_0022: call 0x0A000095
    IL_0027: stfld 0x04000D6B
    IL_0028: ldarg.0
    IL_002D: ldstr 0x70001F2D
    IL_0032: call 0x06000220
    IL_0037: stfld 0x04000D63
    IL_0038: ldarg.0
    IL_003D: ldstr 0x70001F15
    IL_0042: call 0x060003F9
    IL_0047: stfld 0x04000D6C
    IL_0048: ldarg.0
    IL_004D: ldstr 0x70001F25
    IL_0052: call 0x060003F9
    IL_0057: stfld 0x04000D6F
    IL_0058: ldarg.0
    IL_005D: ldstr 0x70001F1D
    IL_0062: call 0x060003F9
    IL_0067: stfld 0x04000D6D
    IL_0068: ldarg.0
    IL_006D: ldstr 0x70001EAD
    IL_0072: call 0x06000220
    IL_0077: stfld 0x04000D69
    IL_0078: ldarg.0
    IL_007D: ldstr 0x70002093
    IL_0082: call 0x06000220
    IL_0087: stfld 0x04000DD2
    IL_0088: ldarg.0
    IL_008D: ldstr 0x700236FF
    IL_0092: call 0x060003F9
    IL_0097: stfld 0x04000D74
    IL_0098: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000D67
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000D66
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A0000DA
    IL_0006: conv.i2
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_C0
    IL_000B: IL_3E
    IL_000C: IL_5A
    IL_0011: stfld 0x04000DD1
    IL_0016: ldstr 0x70000121
    IL_001B: call 0x0A000004
    IL_001C: ldnull
    IL_0021: call 0x0A000061
    IL_0026: brfalse IL_004C
    IL_0027: ldarg.0
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000D9C
    IL_0032: call 0x0A00001B
    IL_0037: call 0x0A000013
    IL_003C: call 0x0A000014
    IL_003D: conv.u4
    IL_003E: ldarg.1
    IL_003F: nop
    IL_0040: nop
    IL_0041: IL_01
    IL_0046: stfld 0x04000DA4
    IL_004B: br IL_0061
    IL_004C: ldarg.0
    IL_0051: ldstr 0x70000121
    IL_0056: call 0x0A000004
    IL_0057: conv.r8
    IL_0058: ldarg.3
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_0060: stfld 0x04000DA4
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000DA4
    IL_0068: conv.r8
    IL_006D: ldsfld 0x7D2B0000
    IL_006E: IL_CB
    IL_006F: stloc.3
    IL_0070: nop
    IL_0071: ldarg.2
    IL_0072: ldarg.0
    IL_0077: call 0x0600067B
    IL_0078: ldarg.0
    IL_0079: ldc.i4.1
    IL_007E: call 0x06000679
    IL_007F: ldarg.0
    IL_0084: call 0x06000674
    IL_0085: ldarg.0
    IL_008A: ldstr 0x700232A7
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_E8
    IL_008F: IL_41
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0093: IL_F0
    IL_0094: IL_41
    IL_0099: call 0x0A000017
    IL_009E: ldstr 0x70023EF1
    IL_00A3: call 0x0A000095
    IL_00A4: stloc.0
    IL_00A5: ldloc.0
    IL_00A6: ldc.i4.1
    IL_0107: switch (23 cases)
    IL_0108: IL_CC
    IL_0109: IL_CC
    IL_010A: IL_3E
    IL_010F: newobj 0x0A000076
    IL_0110: conv.r8
    IL_0111: conv.ovf.i4.un
    IL_0112: IL_01
    IL_0113: nop
    IL_0114: stloc.0
    IL_0115: ldarg.0
    IL_011A: ldfld 0x04000D9D
    IL_011F: call 0x0A00004B
    IL_0120: IL_22
    IL_0121: shr
    IL_0122: shr
    IL_0127: isinst 0x00082840
    IL_0128: nop
    IL_0129: stloc.0
    IL_012A: conv.r8
    IL_012B: IL_AF
    IL_012C: nop
    IL_012D: nop
    IL_012E: stloc.0
    IL_012F: ldarg.0
    IL_0134: ldstr 0x70023285
    IL_0135: IL_22
    IL_0136: nop
    IL_0137: nop
    IL_013C: stsfld 0x147B223F
    IL_013D: IL_AE
    IL_013E: IL_3E
    IL_0143: call 0x0A000017
    IL_0144: ldarg.0
    IL_0149: call 0x0600067D
    IL_014E: ldstr 0x70000617
    IL_014F: ldc.i4.8
    IL_0154: call 0x0A00009F
    IL_0155: ret
    }

    private void SetServerTime() {
    IL_0004: call 0x0600056E
    IL_0005: ldarg.0
    IL_000A: call 0x06000675
    IL_000B: ret
    }

    public void DelayWorkTime() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0019
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000D73
    IL_000D: ldloc.0
    IL_000E: ldloc.0
    IL_0013: call 0x0600056F
    IL_0014: ldelem.i8
    IL_0015: ldloc.0
    IL_0016: ldc.i4.1
    IL_0017: IL_58
    IL_0018: stloc.0
    IL_0019: ldloc.0
    IL_001A: ldc.i4.2
    IL_001B: IL_3F
    IL_001C: IL_E7
    IL_001D: IL_FF
    IL_001E: IL_FF
    IL_001F: IL_FF
    IL_0020: ldc.i4.0
    IL_0021: stloc.1
    IL_0026: br IL_0059
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000D72
    IL_002D: ldloc.1
    IL_002E: IL_91
    IL_0033: brtrue IL_0055
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000D6E
    IL_003A: ldloc.1
    IL_003B: ldarg.0
    IL_0040: ldfld 0x04000D6D
    IL_0041: ldloc.1
    IL_0042: IL_94
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000D73
    IL_0049: ldc.i4.1
    IL_004A: IL_94
    IL_004B: conv.i2
    IL_004C: IL_22
    IL_004D: IL_CD
    IL_004E: IL_CC
    IL_004F: IL_4C
    IL_0050: IL_3E
    IL_0051: IL_5A
    IL_0052: not
    IL_0053: IL_58
    IL_0054: ldelem.i8
    IL_0055: ldloc.1
    IL_0056: ldc.i4.1
    IL_0057: IL_58
    IL_0058: stloc.1
    IL_0059: ldloc.1
    IL_005B: ldc.i4.s 12
    IL_005C: IL_3F
    IL_005D: IL_C6
    IL_005E: IL_FF
    IL_005F: IL_FF
    IL_0060: IL_FF
    IL_0061: ret
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000DD3
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000DD3
    IL_0010: ret
    }

    public void GeneralStat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DCA
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_F5
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000DCA
    IL_0017: ldfld 0x04000675
    IL_001C: stfld 0x04000DA8
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000DCA
    IL_0028: ldfld 0x04000676
    IL_002D: stfld 0x04000DA9
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000DCA
    IL_0039: ldfld 0x04000678
    IL_003E: stfld 0x04000DAA
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000DCA
    IL_004A: ldfld 0x04000679
    IL_004F: stfld 0x04000DAB
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000DCA
    IL_005B: ldfld 0x04000677
    IL_0060: stfld 0x04000DAC
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000DCA
    IL_006C: ldfld 0x0400067A
    IL_0071: stfld 0x04000DB7
    IL_0072: ldarg.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000DCA
    IL_007D: ldfld 0x0400067D
    IL_0082: stfld 0x04000DAD
    IL_0083: ldarg.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000DCA
    IL_008E: ldfld 0x0400067C
    IL_0093: stfld 0x04000DAE
    IL_0094: ldarg.2
    IL_0099: brtrue IL_0110
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000D6D
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000D68
    IL_00A6: ldarg.0
    IL_00AB: ldfld 0x04000DAC
    IL_00AC: ldelem.i8
    IL_00AD: ldarg.0
    IL_00B2: ldfld 0x04000D6E
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x04000D68
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x04000DAC
    IL_00BF: ldelem.i8
    IL_00C4: ldstr 0x70001F1D
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04000D6E
    IL_00CF: call 0x060003F8
    IL_00D0: pop
    IL_00D1: ldc.i4.1
    IL_00D6: call 0x0600056B
    IL_00DB: ldstr 0x70001FD3
    IL_00E0: call 0x060003F9
    IL_00E1: stloc.0
    IL_00E2: ldloc.0
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000DA8
    IL_00E9: ldloc.0
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000DA8
    IL_00F0: IL_94
    IL_00F1: ldarg.0
    IL_00F6: ldfld 0x04000DAD
    IL_00F7: ldc.i4.1
    IL_00F8: IL_58
    IL_00FD: call 0x0A000080
    IL_00FE: ldelem.i8
    IL_0103: ldstr 0x70001FD3
    IL_0104: ldloc.0
    IL_0109: call 0x060003F8
    IL_010A: pop
    IL_010F: br IL_01A7
    IL_0110: ldarg.0
    IL_0115: ldfld 0x04000D6E
    IL_0116: ldarg.0
    IL_011B: ldfld 0x04000D64
    IL_011C: IL_94
    IL_011D: ldarg.0
    IL_0122: ldfld 0x04000DAC
    IL_0123: IL_3F
    IL_0124: pop
    IL_0125: nop
    IL_0126: nop
    IL_0127: nop
    IL_0128: ldarg.0
    IL_012D: ldfld 0x04000D6E
    IL_012E: ldarg.0
    IL_0133: ldfld 0x04000D64
    IL_0134: ldarg.0
    IL_0139: ldfld 0x04000DAC
    IL_013A: ldelem.i8
    IL_013B: ldarg.0
    IL_0140: ldfld 0x04000D72
    IL_0141: ldarg.0
    IL_0146: ldfld 0x04000D64
    IL_0147: ldc.i4.1
    IL_0148: ldelem.i2
    IL_014D: br IL_016F
    IL_014E: ldarg.0
    IL_0153: ldfld 0x04000D6E
    IL_0154: ldarg.0
    IL_0159: ldfld 0x04000D64
    IL_015A: IL_94
    IL_015B: ldc.i4.0
    IL_015C: IL_3D
    IL_015E: ldarg.s 0
    IL_015F: nop
    IL_0160: nop
    IL_0161: ldarg.0
    IL_0166: ldfld 0x04000D6E
    IL_0167: ldarg.0
    IL_016C: ldfld 0x04000D64
    IL_016D: ldc.i4.1
    IL_016E: ldelem.i8
    IL_016F: ldarg.0
    IL_0170: ldarg.0
    IL_0175: ldfld 0x04000D6F
    IL_0176: ldarg.0
    IL_017B: ldfld 0x04000D64
    IL_017C: IL_94
    IL_017E: ldc.i4.s 58
    IL_017F: IL_5A
    IL_0180: conv.i2
    IL_0182: ldc.i4.s 100
    IL_0183: ldarg.0
    IL_0188: ldfld 0x04000DAE
    IL_0189: ldc.i4.6
    IL_018A: IL_5A
    IL_018B: IL_58
    IL_018C: conv.i2
    IL_018D: IL_22
    IL_018E: nop
    IL_018F: nop
    IL_0194: stsfld 0xAD7B023F
    IL_0195: stloc.3
    IL_0196: nop
    IL_0197: ldarg.2
    IL_0198: conv.i2
    IL_0199: IL_22
    IL_019A: IL_CD
    IL_019B: IL_CC
    IL_019C: IL_4C
    IL_019D: IL_3E
    IL_019E: IL_5A
    IL_019F: IL_58
    IL_01A0: IL_5A
    IL_01A1: add
    IL_01A6: stfld 0x04000DB9
    IL_01A7: ret
    }

    public void FortuneTell() {
    IL_0000: ldc.i4.4
    IL_0005: newarr 0x0100000B
    IL_0006: stloc.0
    IL_0007: ldc.i4.4
    IL_000C: newarr 0x0100000B
    IL_000D: stloc.1
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000D6C
    IL_0014: ldarg.0
    IL_0019: ldfld 0x04000D64
    IL_001A: IL_94
    IL_001B: stloc.2
    IL_001C: ldc.i4.0
    IL_001D: stloc.3
    IL_0022: br IL_004C
    IL_0023: ldloc.1
    IL_0024: ldloc.3
    IL_0025: ldloc.2
    IL_0027: ldc.i4.s 10
    IL_0028: mul
    IL_0029: ldelem.i8
    IL_002A: ldloc.2
    IL_002C: ldc.i4.s 10
    IL_002D: add
    IL_002E: stloc.2
    IL_002F: ldloc.0
    IL_0030: ldloc.1
    IL_0031: ldloc.3
    IL_0032: ldc.i4.4
    IL_0033: mul
    IL_0034: IL_94
    IL_0035: ldarg.0
    IL_003A: ldfld 0x04000DA8
    IL_003B: IL_58
    IL_003C: ldc.i4.4
    IL_003D: mul
    IL_003E: IL_8F
    IL_003F: stloc.1
    IL_0040: nop
    IL_0041: nop
    IL_0042: IL_01
    IL_0043: dup
    IL_0046: stloc 22551
    IL_0047: IL_54
    IL_0048: ldloc.3
    IL_0049: ldc.i4.1
    IL_004A: IL_58
    IL_004B: stloc.3
    IL_004C: ldloc.3
    IL_004D: ldc.i4.4
    IL_004E: IL_3F
    IL_0053: ldtoken 0x02FFFFFF
    IL_0058: ldfld 0x04000D9B
    IL_0059: conv.r8
    IL_005A: stloc.0
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ldc.i4.1
    IL_005F: conv.r8
    IL_0060: stloc.1
    IL_0061: nop
    IL_0062: nop
    IL_0063: stloc.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000D9B
    IL_006A: conv.r8
    IL_006B: IL_89
    IL_006C: nop
    IL_006D: nop
    IL_006F: br.s IL_0076
    IL_0070: ldc.i4.0
    IL_0071: IL_94
    IL_0072: ldc.i4.1
    IL_0073: IL_58
    IL_0074: ldloc.0
    IL_0075: ldc.i4.1
    IL_0076: IL_94
    IL_0077: ldc.i4.1
    IL_0078: IL_58
    IL_0079: ldloc.0
    IL_007A: ldc.i4.2
    IL_007B: IL_94
    IL_007C: ldc.i4.1
    IL_007D: IL_58
    IL_007E: ldloc.0
    IL_007F: ldc.i4.3
    IL_0080: IL_94
    IL_0081: ldc.i4.1
    IL_0082: IL_58
    IL_0083: conv.r8
    IL_0084: IL_EF
    IL_0085: ldarg.0
    IL_0086: nop
    IL_0087: ldloc.0
    IL_0088: ret
    }

    public void CurGeneralStat() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0041
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000D63
    IL_000C: ldc.i4.m1
    IL_0011: beq IL_003C
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000DCA
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000D6C
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000D63
    IL_0024: IL_94
    IL_0025: conv.r8
    IL_0026: IL_F5
    IL_0027: ldarg.0
    IL_0028: nop
    IL_0029: ldloc.0
    IL_002A: ldarg.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000DCA
    IL_0035: ldfld 0x04000677
    IL_0036: conv.i2
    IL_003B: stfld 0x04000DC1
    IL_0040: br IL_004E
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000DAC
    IL_0048: conv.i2
    IL_004D: stfld 0x04000DC1
    IL_004E: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000DC7
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000DC2
    IL_000E: ret
    }

    public void GeneralKindOnly() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0008: br IL_008C
    IL_0009: ldarg.0
    IL_000E: ldfld 0x04000D6C
    IL_000F: ldloc.1
    IL_0010: IL_94
    IL_0011: ldc.i4.0
    IL_0012: IL_3E
    IL_0017: ldobj 0x02000000
    IL_001C: ldfld 0x04000D6C
    IL_001D: ldloc.1
    IL_001E: IL_94
    IL_0023: ldc.i4 10000000
    IL_0024: mul
    IL_0029: ldc.i4 100000
    IL_002A: add
    IL_002B: stloc.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000D70
    IL_0032: ldloc.1
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04000D6C
    IL_0039: ldloc.1
    IL_003A: IL_94
    IL_003F: ldc.i4 100000
    IL_0040: mul
    IL_0045: ldc.i4 10000
    IL_0046: add
    IL_0047: neg
    IL_0048: ldelem.i4
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04000D71
    IL_004F: ldloc.1
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000D6C
    IL_0056: ldloc.1
    IL_0057: IL_94
    IL_0058: conv.i2
    IL_0059: IL_22
    IL_005E: stsfld 0x5B4B1896
    IL_005F: neg
    IL_0060: ldelem.i4
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000D6A
    IL_0067: ldloc.1
    IL_006C: ldstr 0x70022E37
    IL_006D: ldloc.0
    IL_006E: ldc.i4.1
    IL_006F: IL_58
    IL_0070: stloc.2
    IL_0072: ldloca.s 2
    IL_0077: call 0x0A000010
    IL_007C: call 0x0A000011
    IL_0081: call 0x0A000012
    IL_0082: conv.u8
    IL_0083: IL_3C
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_01
    IL_008B: stelem 0x0B581707
    IL_008C: ldloc.1
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000D69
    IL_0093: IL_3F
    IL_0098: ldobj 0x2AFFFFFF
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DC7
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000DC2
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000DC2
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000DC2
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_42
    IL_002A: ldloca.s 0
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000DC7
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000DC2
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000DD7
    IL_0045: ldc.i4.0
    IL_0046: IL_3E
    IL_0047: IL_F6
    IL_0048: IL_01
    IL_0049: nop
    IL_004A: nop
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04000DD7
    IL_0051: ldc.i4.3
    IL_03FA: switch (233 cases)
    IL_03FB: IL_22
    IL_03FC: nop
    IL_03FD: nop
    IL_03FE: nop
    IL_03FF: nop
    IL_0784: switch (224 cases)
    IL_0785: nop
    IL_0786: ldarg.2
    IL_0787: ldc.i4.1
    IL_0788: IL_58
    IL_078A: ldc.i4.s 20
    IL_078B: IL_5A
    IL_078C: IL_3F
    IL_078D: stloc.1
    IL_078E: nop
    IL_078F: nop
    IL_0790: nop
    IL_0791: ldarg.0
    IL_0792: IL_22
    IL_0793: nop
    IL_0794: nop
    IL_0795: nop
    IL_0796: nop
    IL_079B: stfld 0x04000DBC
    IL_079C: ldarg.0
    IL_07A1: ldfld 0x04000DBC
    IL_07A2: IL_22
    IL_07A3: nop
    IL_07A4: nop
    IL_07A5: nop
    IL_07A6: nop
    IL_07A7: IL_42
    IL_07A8: IL_3C
    IL_07A9: nop
    IL_07AA: nop
    IL_07AB: nop
    IL_07AC: ldarg.0
    IL_07B1: ldfld 0x04000D6F
    IL_07B2: ldarg.0
    IL_07B7: ldfld 0x04000D65
    IL_07B8: ldarg.0
    IL_07BD: ldfld 0x04000DBB
    IL_07BE: not
    IL_07BF: ldelem.i8
    IL_07C0: ldarg.0
    IL_07C5: ldfld 0x04000D6C
    IL_07C6: ldarg.0
    IL_07CB: ldfld 0x04000D65
    IL_07CC: IL_8F
    IL_07CD: stloc.1
    IL_07CE: nop
    IL_07CF: nop
    IL_07D0: IL_01
    IL_07D1: dup
    IL_07D4: stloc 32800
    IL_07D5: IL_96
    IL_07D6: IL_98
    IL_07D7: nop
    IL_07D8: ldarg.0
    IL_07DD: ldfld 0x04000DB4
    IL_07DE: IL_5A
    IL_07DF: IL_58
    IL_07E0: IL_54
    IL_07E1: ldarg.0
    IL_07E2: ldc.i4.1
    IL_07E7: stfld 0x04000DC5
    IL_07E8: ldarg.0
    IL_07E9: ldarg.0
    IL_07EE: ldfld 0x04000DBB
    IL_07EF: IL_22
    IL_07F0: nop
    IL_07F1: nop
    IL_07F2: neg
    IL_07F3: IL_42
    IL_07F4: IL_5A
    IL_07F6: ldc.i4.s 100
    IL_07F7: ldarg.0
    IL_07FC: ldfld 0x04000DB0
    IL_07FD: ldc.i4.6
    IL_07FE: IL_5A
    IL_07FF: IL_58
    IL_0800: conv.i2
    IL_0801: IL_22
    IL_0802: nop
    IL_0803: nop
    IL_0808: stsfld 0xAF7B023F
    IL_0809: stloc.3
    IL_080A: nop
    IL_080B: ldarg.2
    IL_080C: conv.i2
    IL_080D: IL_22
    IL_080E: IL_CD
    IL_080F: IL_CC
    IL_0810: IL_4C
    IL_0811: IL_3E
    IL_0812: IL_5A
    IL_0813: IL_58
    IL_0814: IL_5A
    IL_0815: add
    IL_081A: stfld 0x04000DBA
    IL_081B: ldarg.0
    IL_0820: ldfld 0x04000DC2
    IL_0821: IL_22
    IL_0822: nop
    IL_0823: nop
    IL_0824: nop
    IL_0825: nop
    IL_0A1E: switch (125 cases)
    }

    private void SetGiftCount() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000DD6
    IL_0007: ldarg.0
    IL_0009: ldc.i4.s 50
    IL_000E: newarr 0x0100000B
    IL_0013: stfld 0x04000D76
    IL_0014: ldarg.0
    IL_0015: ldc.i4.3
    IL_001A: newarr 0x0100000B
    IL_001F: stfld 0x04000D75
    IL_0020: ldc.i4.0
    IL_0021: stloc.0
    IL_0026: br IL_0071
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000D74
    IL_002D: ldloc.0
    IL_002E: IL_94
    IL_0033: brfalse IL_006D
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04000D74
    IL_003A: ldloc.0
    IL_003B: IL_94
    IL_0040: ldc.i4 10000000
    IL_0041: add
    IL_0042: stloc.1
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000D76
    IL_0049: ldloc.0
    IL_004A: ldloc.1
    IL_004B: ldelem.i8
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000D75
    IL_0052: ldloc.1
    IL_0053: ldc.i4.1
    IL_0054: IL_59
    IL_0055: IL_8F
    IL_0056: stloc.1
    IL_0057: nop
    IL_0058: nop
    IL_0059: IL_01
    IL_005A: dup
    IL_005D: stloc 22551
    IL_005E: IL_54
    IL_005F: ldarg.0
    IL_0060: dup
    IL_0065: ldfld 0x04000DD6
    IL_0066: ldc.i4.1
    IL_0067: IL_58
    IL_006C: stfld 0x04000DD6
    IL_006D: ldloc.0
    IL_006E: ldc.i4.1
    IL_006F: IL_58
    IL_0070: stloc.0
    IL_0071: ldloc.0
    IL_0073: ldc.i4.s 50
    IL_0074: IL_3F
    IL_0075: IL_AE
    IL_0076: IL_FF
    IL_0077: IL_FF
    IL_0078: IL_FF
    IL_0079: ret
    }

    private void FindCardType() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000DD5
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002C
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000D76
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_0016: ldarg.1
    IL_004B: switch (12 cases)
    }

    private void GiftMode() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0003: IL_DC
    IL_0004: IL_42
    IL_0005: ldarg.0
    IL_000A: ldfld 0x04000DC3
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_0012: ldc.i4 2251074
    IL_0013: nop
    IL_0014: IL_82
    IL_0015: IL_43
    IL_0016: IL_22
    IL_0017: nop
    IL_0018: nop
    IL_0019: ldloc.2
    IL_001A: IL_42
    IL_001F: call 0x0600021D
    IL_0020: ldc.i4.4
    IL_0025: newarr 0x01000020
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_002C: ldsfld 0x040007B2
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04000D6B
    IL_0037: ldc.i4 421
    IL_003C: call 0x0A0000E1
    IL_0041: stelem 0xF9721725
    IL_0042: IL_3E
    IL_0043: ldarg.0
    IL_0048: cpobj 0x021825A2
    IL_004D: ldfld 0x04000DD6
    IL_0052: newobj 0x0100000B
    IL_0057: stelem 0x01721925
    IL_0058: IL_3F
    IL_0059: ldarg.0
    IL_005E: cpobj 0x009628A2
    IL_005F: nop
    IL_0060: stloc.0
    IL_0065: ldstr 0x70023325
    IL_006A: call 0x0A0000E2
    IL_006F: call 0x0A0000E3
    IL_0070: ldc.i4.0
    IL_0071: stloc.0
    IL_0076: br IL_0229
    IL_0078: ldc.i4.s 90
    IL_0079: ldloc.0
    IL_007B: ldc.i4.s 110
    IL_007C: IL_5A
    IL_007D: IL_58
    IL_007E: conv.i2
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000DC3
    IL_0085: IL_22
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldelem.r8
    IL_0089: IL_42
    IL_008A: IL_22
    IL_008B: nop
    IL_008C: nop
    IL_008D: ldelem.r8
    IL_008E: IL_42
    IL_0093: call 0x0600021D
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000D91
    IL_009A: ldloc.0
    IL_009B: ldelem.i
    IL_00A0: call 0x0A0000E0
    IL_00A2: ldc.i4.s 90
    IL_00A3: ldloc.0
    IL_00A5: ldc.i4.s 110
    IL_00A6: IL_5A
    IL_00A7: IL_58
    IL_00A8: conv.i2
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000DC3
    IL_00AF: IL_22
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: ldelem.r8
    IL_00B3: IL_42
    IL_00B4: IL_22
    IL_00B5: nop
    IL_00B6: nop
    IL_00B7: ldelem.r8
    IL_00B8: IL_42
    IL_00BD: call 0x0600021D
    IL_00C2: ldsfld 0x0A000099
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000D98
    IL_00CD: call 0x0A0000F1
    IL_00D2: brfalse IL_01A5
    IL_00D3: ldarg.0
    IL_00D4: ldarg.0
    IL_00D5: ldloc.0
    IL_00D6: ldc.i4.1
    IL_00D7: IL_58
    IL_00DC: call 0x0600067E
    IL_00E1: stfld 0x04000DD5
    IL_00E2: ldarg.0
    IL_00E7: ldfld 0x04000DD5
    IL_00E8: ldc.i4.m1
    IL_00ED: beq IL_01A5
    IL_00EE: ldarg.0
    IL_00F3: call 0x06000680
    IL_00F4: ldc.i4.m1
    IL_00F9: beq IL_016E
    IL_00FA: ldarg.0
    IL_00FF: ldfld 0x04000D9E
    IL_0100: conv.r8
    IL_0101: stloc.3
    IL_0102: nop
    IL_0103: nop
    IL_0104: stloc.0
    IL_0105: conv.r8
    IL_0107: ldarg.s 0
    IL_0108: nop
    IL_0109: stloc.0
    IL_010A: ldarg.0
    IL_010F: ldfld 0x04000D91
    IL_0110: ldloc.0
    IL_0111: ldelem.i
    IL_0112: conv.r8
    IL_0114: ldarga.s 0
    IL_0115: nop
    IL_0116: stloc.0
    IL_0117: ldarg.0
    IL_011C: ldfld 0x04000D9E
    IL_011D: conv.r8
    IL_011E: stloc.0
    IL_011F: nop
    IL_0120: nop
    IL_0121: stloc.0
    IL_0122: ldc.i4.1
    IL_0123: conv.r8
    IL_0124: stloc.1
    IL_0125: nop
    IL_0126: nop
    IL_0127: stloc.0
    IL_0128: ldarg.0
    IL_012D: ldfld 0x04000D9E
    IL_012E: ldloc.0
    IL_012F: ldc.i4.1
    IL_0130: IL_59
    IL_0131: conv.i2
    IL_0132: IL_22
    IL_0133: nop
    IL_0134: nop
    IL_0135: nop
    IL_0136: IL_BF
    IL_0137: IL_5A
    IL_0138: IL_22
    IL_0139: IL_CD
    IL_013A: IL_CC
    IL_013B: IL_4C
    IL_013C: IL_3D
    IL_013D: IL_22
    IL_013E: nop
    IL_013F: nop
    IL_0140: nop
    IL_0141: IL_3F
    IL_0146: newobj 0x0A000076
    IL_0147: conv.r8
    IL_0148: ldloc.3
    IL_0149: nop
    IL_014A: nop
    IL_014B: stloc.0
    IL_014C: ldarg.0
    IL_014D: IL_22
    IL_014E: nop
    IL_014F: nop
    IL_0150: IL_C8
    IL_0151: IL_C2
    IL_0156: stfld 0x04000DC3
    IL_0157: ldarg.0
    IL_0158: ldc.i4.1
    IL_015D: stfld 0x04000DD7
    IL_015E: ldarg.0
    IL_015F: IL_22
    IL_0160: nop
    IL_0161: nop
    IL_0162: nop
    IL_0163: IL_3F
    IL_0168: stfld 0x04000DC4
    IL_016D: br IL_0230
    IL_016E: ldarg.0
    IL_0173: ldfld 0x04000D69
    IL_0175: ldc.i4.s 12
    IL_0176: IL_3F
    IL_0177: ldc.i4.2
    IL_0178: nop
    IL_0179: nop
    IL_017A: nop
    IL_017B: ldarg.0
    IL_017D: ldc.i4.s 9
    IL_0182: stfld 0x04000DB6
    IL_0183: ldarg.0
    IL_0184: IL_22
    IL_0185: nop
    IL_0186: nop
    IL_018B: stsfld 0x067A283F
    IL_018C: nop
    IL_018D: ldloc.0
    IL_0192: br IL_01A5
    IL_0193: ldarg.0
    IL_0194: IL_22
    IL_0195: nop
    IL_0196: nop
    IL_019B: stsfld 0x067A283F
    IL_019C: nop
    IL_019D: ldloc.0
    IL_019E: ldarg.0
    IL_019F: ldc.i4.3
    IL_01A4: stfld 0x04000DB6
    IL_01A6: ldc.i4.s 94
    IL_01A7: ldloc.0
    IL_01A9: ldc.i4.s 110
    IL_01AA: IL_5A
    IL_01AB: IL_58
    IL_01AC: conv.i2
    IL_01AD: ldarg.0
    IL_01B2: ldfld 0x04000DC3
    IL_01B3: IL_22
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: ldelem.r8
    IL_01B7: IL_42
    IL_01B8: IL_58
    IL_01B9: IL_22
    IL_01BA: nop
    IL_01BB: nop
    IL_01C0: ldobj 0x00002242
    IL_01C1: IL_C0
    IL_01C2: IL_41
    IL_01C7: call 0x0600021D
    IL_01CC: ldsfld 0x0A000099
    IL_01D1: ldstr 0x70022A46
    IL_01D6: call 0x0A0000E2
    IL_01DB: call 0x0A0001BA
    IL_01DD: ldc.i4.s 90
    IL_01DE: ldloc.0
    IL_01E0: ldc.i4.s 110
    IL_01E1: IL_5A
    IL_01E2: IL_58
    IL_01E3: conv.i2
    IL_01E4: ldarg.0
    IL_01E9: ldfld 0x04000DC3
    IL_01EA: IL_22
    IL_01EB: nop
    IL_01EC: nop
    IL_01ED: IL_98
    IL_01EE: IL_42
    IL_01EF: IL_58
    IL_01F0: IL_22
    IL_01F1: nop
    IL_01F2: nop
    IL_01F3: ldelem.r8
    IL_01F4: IL_42
    IL_01F5: IL_22
    IL_01F6: nop
    IL_01F7: nop
    IL_01F8: nop
    IL_01F9: IL_42
    IL_01FE: call 0x0600021D
    IL_0203: ldsfld 0x0A000099
    IL_0204: ldarg.0
    IL_0209: ldfld 0x04000D75
    IL_020A: ldloc.0
    IL_020B: IL_94
    IL_0210: newobj 0x0100000B
    IL_0215: call 0x0A00009A
    IL_021A: ldstr 0x70022A5A
    IL_021F: call 0x0A0000E2
    IL_0224: call 0x0A0000E3
    IL_0225: ldloc.0
    IL_0226: ldc.i4.1
    IL_0227: IL_58
    IL_0228: stloc.0
    IL_0229: ldloc.0
    IL_022A: ldc.i4.3
    IL_022B: IL_3F
    IL_022E: starg 65534
    IL_022F: IL_FF
    IL_0230: ret
    }

    private void GetGeneral() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000D68
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002B
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000D6C
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_001A: brtrue IL_0027
    IL_001B: ldarg.0
    IL_001C: ldloc.0
    IL_0021: stfld 0x04000D68
    IL_0026: br IL_0037
    IL_0027: ldloc.0
    IL_0028: ldc.i4.1
    IL_0029: IL_58
    IL_002A: stloc.0
    IL_002B: ldloc.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000D69
    IL_0032: IL_3F
    IL_0033: IL_D7
    IL_0034: IL_FF
    IL_0035: IL_FF
    IL_0036: IL_FF
    IL_0037: ldarg.0
    IL_003C: ldfld 0x04000D68
    IL_003D: ret
    }

    private void GeneralMode() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D64
    IL_0006: ldc.i4.0
    IL_0007: IL_3C
    IL_0009: ldloc.s 0
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000D63
    IL_0017: stfld 0x04000D64
    IL_001C: br IL_0047
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000D6C
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000D64
    IL_0029: IL_94
    IL_002E: brtrue IL_0047
    IL_002F: ldarg.0
    IL_0030: ldc.i4.0
    IL_0035: stfld 0x04000DA7
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000D9D
    IL_0040: call 0x0A00001B
    IL_0041: conv.r8
    IL_0042: IL_AF
    IL_0043: nop
    IL_0044: nop
    IL_0045: stloc.0
    IL_0046: ret
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000DA7
    IL_004D: ldc.i4.4
    IL_004E: IL_3C
    IL_0050: blt.s IL_0061
    IL_0051: nop
    IL_0052: nop
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldarg.0
    IL_0057: IL_43
    IL_0058: IL_22
    IL_0059: nop
    IL_005A: nop
    IL_005B: IL_58
    IL_005C: IL_42
    IL_005D: IL_22
    IL_005E: nop
    IL_005F: nop
    IL_0060: sub
    IL_0061: IL_43
    IL_0062: IL_22
    IL_0063: nop
    IL_0064: nop
    IL_0069: ldobj 0x021D2841
    IL_006A: nop
    IL_006B: ldloc.0
    IL_006C: ldarg.0
    IL_0071: ldfld 0x04000D79
    IL_0076: call 0x0A0000E0
    IL_0077: IL_22
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.2
    IL_007B: IL_43
    IL_007C: IL_22
    IL_007D: nop
    IL_007E: nop
    IL_007F: IL_C2
    IL_0080: IL_42
    IL_0081: IL_22
    IL_0082: nop
    IL_0083: nop
    IL_0088: stsfld 0x00002242
    IL_008D: stsfld 0x021D2842
    IL_008E: nop
    IL_008F: ldloc.0
    IL_0090: ldarg.0
    IL_0095: ldfld 0x04000D6A
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000D64
    IL_009C: ldelem.i
    IL_00A1: call 0x0A0000E0
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.2
    IL_00A6: IL_43
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AA: IL_A4
    IL_00AB: IL_42
    IL_00AC: IL_22
    IL_00AD: nop
    IL_00AE: nop
    IL_00B3: stsfld 0x00002242
    IL_00B4: IL_DC
    IL_00B5: IL_42
    IL_00BA: call 0x0600021D
    IL_00BB: ldarg.0
    IL_00C0: ldfld 0x04000D7A
    IL_00C5: call 0x0A0000E0
    IL_00C6: IL_22
    IL_00C7: nop
    IL_00C8: nop
    IL_00CA: starg.s 67
    IL_00CB: IL_22
    IL_00CC: nop
    IL_00CD: nop
    IL_00CE: IL_23
    IL_00CF: IL_43
    IL_00D0: IL_22
    IL_00D1: nop
    IL_00D2: nop
    IL_00D7: newobj 0x00002242
    IL_00DC: stsfld 0x021D2841
    IL_00DD: nop
    IL_00DE: ldloc.0
    IL_00DF: ldc.i4.4
    IL_00E4: newarr 0x01000020
    IL_00E5: dup
    IL_00E6: ldc.i4.0
    IL_00EB: ldsfld 0x0A000099
    IL_00F0: stelem 0x7B021725
    IL_00F1: IL_AE
    IL_00F2: stloc.3
    IL_00F3: nop
    IL_00F4: ldarg.2
    IL_00F9: newobj 0x01000010
    IL_00FE: stelem 0xD9721825
    IL_00FF: IL_37
    IL_0100: ldarg.0
    IL_0105: cpobj 0x021925A2
    IL_010A: ldfld 0x04000DAD
    IL_010B: ldc.i4.1
    IL_010C: IL_58
    IL_010E: ldc.i4.s 20
    IL_010F: IL_5A
    IL_0114: newobj 0x0100000B
    IL_0119: stelem 0x00009628
    IL_011A: stloc.0
    IL_011F: ldstr 0x70000BC5
    IL_0124: call 0x0A0000E2
    IL_0129: call 0x0A0000E3
    IL_012A: IL_22
    IL_012B: nop
    IL_012C: nop
    IL_012E: ldarga.s 67
    IL_012F: IL_22
    IL_0130: nop
    IL_0131: nop
    IL_0136: br IL_-4684FC86
    IL_0137: stloc.3
    IL_0138: nop
    IL_0139: ldarg.2
    IL_013A: IL_22
    IL_013B: nop
    IL_013C: nop
    IL_013D: ldelem.r8
    IL_875E2: switch (138536 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DA5
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000DA5
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000DA5
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000D9D
    IL_004B: call 0x0A00001B
    IL_004C: conv.r8
    IL_004D: IL_AF
    IL_004E: nop
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: ret
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000D62
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000DBD
    IL_0047: IL_22
    IL_0048: nop
    IL_0049: nop
    IL_004E: cpobj 0x00002243
    IL_004F: IL_F0
    IL_0050: IL_43
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0054: IL_C8
    IL_0055: IL_42
    IL_005A: call 0x0600021D
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000D84
    IL_0065: call 0x0A0000E0
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04000DB6
    IL_006C: ldc.i4.0
    IL_006D: IL_3E
    IL_006E: ldloc.0
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: ldc.i4.0
    IL_0077: call 0x0A0001B9
    IL_0078: IL_22
    IL_0079: nop
    IL_007A: nop
    IL_007B: IL_E0
    IL_007C: IL_42
    IL_007D: IL_22
    IL_007E: nop
    IL_007F: nop
    IL_0080: nop
    IL_0081: nop
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0089: stsfld 0x00002243
    IL_008A: nop
    IL_008B: IL_42
    IL_0090: call 0x0600021D
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000D93
    IL_009B: call 0x0A0000E0
    IL_009C: IL_22
    IL_009D: nop
    IL_009E: nop
    IL_00A0: ldloca.s 67
    IL_00A1: IL_22
    IL_00A2: nop
    IL_00A3: nop
    IL_00A4: IL_C0
    IL_280000131: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000E05
    IL_000C: ldarg.0
    IL_000E: ldc.i4.s 20
    IL_0013: newarr 0x0100000B
    IL_0018: stfld 0x04000E16
    IL_0019: ldarg.0
    IL_001E: ldsfld 0x0A000099
    IL_0023: stfld 0x04000E18
    IL_0024: ldarg.0
    IL_0025: ldc.i4.1
    IL_002A: stfld 0x04000E1A
    IL_002B: ldarg.0
    IL_002C: ldc.i4.1
    IL_0031: stfld 0x04000E1B
    IL_0032: ldarg.0
    IL_0037: ldsfld 0x0A000099
    IL_003C: stfld 0x04000E1D
    IL_003D: ldarg.0
    IL_0042: call 0x0A000001
    IL_0043: ret
    }

    private void Start() {
    IL_0000: ldc.i4.0
    IL_0005: call 0x0A0002E9
    IL_0007: ldc.i4.s 60
    IL_000C: call 0x0A000318
    IL_000D: ldarg.0
    IL_0012: ldstr 0x70022F71
    IL_0017: call 0x0A000095
    IL_001C: stfld 0x04000DDF
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000DDF
    IL_0023: ldc.i4.0
    IL_0024: IL_3E
    IL_0025: IL_AA
    IL_0026: nop
    IL_0027: nop
    IL_0028: nop
    IL_0029: ldarg.0
    IL_002E: ldstr 0x70022774
    IL_0033: call 0x0A0001C1
    IL_0038: stfld 0x04000DE0
    IL_0039: ldarg.0
    IL_003E: ldstr 0x7002270C
    IL_0043: call 0x0A0001C1
    IL_0048: stfld 0x04000DE1
    IL_0049: ldarg.0
    IL_004E: call 0x0A00002B
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000DE0
    IL_0055: conv.r8
    IL_0056: IL_C9
    IL_0057: IL_01
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000DE1
    IL_0064: call 0x0A0001C2
    IL_0065: ldarg.0
    IL_006A: ldstr 0x70000BB3
    IL_006F: call 0x0A000095
    IL_0074: stfld 0x04000DE2
    IL_0079: ldsfld 0x040007B2
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000DE2
    IL_0080: ldc.i4.1
    IL_0085: call 0x0A0000E1
    IL_0086: stloc.0
    IL_0087: IL_DD
    IL_0088: ldc.i4.7
    IL_0089: nop
    IL_008A: nop
    IL_008B: nop
    IL_008C: stloc.1
    IL_008D: ldarg.0
    IL_008E: ldc.i4.0
    IL_0093: stfld 0x04000DE2
    IL_0098: ldstr 0x70000BB3
    IL_0099: ldarg.0
    IL_009E: ldfld 0x04000DE2
    IL_00A3: call 0x0A00009F
    IL_00A4: IL_DD
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: nop
    IL_00A8: nop
    IL_00AD: call 0x060001EF
    IL_00AE: conv.r8
    IL_00AF: IL_F5
    IL_00B0: IL_01
    IL_00B1: nop
    IL_00B2: ldloc.0
    IL_00B3: stloc.2
    IL_00B4: ldloc.2
    IL_00B9: ldstr 0x70000A3D
    IL_00BE: call 0x0A0000EC
    IL_00C3: brfalse IL_00CE
    IL_00C8: call 0x0600004E
    IL_00C9: conv.r8
    IL_00CA: mul
    IL_00CB: nop
    IL_00CC: nop
    IL_00CD: ldloc.0
    IL_00D2: br IL_0134
    IL_00D7: call 0x060001EF
    IL_00D8: conv.r8
    IL_00D9: IL_F5
    IL_00DA: IL_01
    IL_00DB: nop
    IL_00DC: ldloc.0
    IL_00DD: stloc.3
    IL_00DE: ldloc.3
    IL_00E3: ldstr 0x70000A3D
    IL_00E8: call 0x0A0000EC
    IL_00ED: brfalse IL_00F8
    IL_00F2: call 0x0600004E
    IL_00F3: conv.r8
    IL_00F4: mul
    IL_00F5: nop
    IL_00F6: nop
    IL_00F7: ldloc.0
    IL_00F8: ldarg.0
    IL_00F9: ldc.i4.1
    IL_00FE: stfld 0x04000DE2
    IL_0103: ldstr 0x70000BB3
    IL_0104: ldarg.0
    IL_0109: ldfld 0x04000DE2
    IL_010E: call 0x0A00009F
    IL_010F: ldloc.3
    IL_0114: ldstr 0x700009B3
    IL_0119: call 0x0A0000EC
    IL_011E: brfalse IL_0134
    IL_011F: ldarg.0
    IL_0124: call 0x0A00002B
    IL_0129: ldstr 0x70022774
    IL_012E: call 0x0A0001C1
    IL_012F: conv.r8
    IL_0130: IL_C9
    IL_0131: IL_01
    IL_0132: nop
    IL_0133: stloc.0
    IL_0138: ldstr 0x70023F1D
    IL_013D: call 0x0A000012
    IL_013E: conv.u8
    IL_013F: IL_91
    IL_0140: nop
    IL_0141: nop
    IL_0142: IL_01
    IL_0144: stloc.s 4
    IL_0145: ldarg.0
    IL_0147: ldloc.s 4
    IL_0148: conv.r8
    IL_0149: IL_EC
    IL_014A: ldarg.0
    IL_014B: nop
    IL_014C: stloc.0
    IL_0151: stfld 0x04000E18
    IL_0156: ldstr 0x700026F3
    IL_015B: call 0x06000220
    IL_015D: stloc.s 5
    IL_015E: IL_DD
    IL_0160: ldloca.s 0
    IL_0161: nop
    IL_0162: nop
    IL_0164: stloc.s 6
    IL_0169: ldstr 0x700026F3
    IL_016A: ldc.i4.0
    IL_016F: call 0x0600021F
    IL_0170: IL_DD
    IL_0171: nop
    IL_0172: nop
    IL_0173: nop
    IL_0174: nop
    IL_0179: call 0x0600004E
    IL_017A: conv.r8
    IL_017B: shr
    IL_017C: nop
    IL_017D: nop
    IL_017E: ldloc.0
    IL_0183: ldstr 0x70000617
    IL_0184: ldc.i4.0
    IL_0189: call 0x0A00009F
    IL_018A: ret
    }

    private void OnApplicationPause() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0007
    IL_0006: ret
    IL_0007: ret
    }

    public void CGPButtonLoadStart() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0007: call 0x0600068A
    IL_000C: call 0x0A000047
    IL_000D: pop
    IL_000E: ret
    }

    public void GetCGPReward() {
    IL_0000: ldarg.1
    IL_0005: ldstr 0x70023F35
    IL_000A: call 0x0A0000EC
    IL_000F: brfalse IL_001D
    IL_0010: ldarg.2
    IL_0011: ldc.i4.0
    IL_0016: call 0x0600021E
    IL_0017: pop
    IL_001C: br IL_0035
    IL_001D: ldarg.1
    IL_0022: ldstr 0x70023F3F
    IL_0027: call 0x0A0000EC
    IL_002C: brfalse IL_0035
    IL_002D: ldarg.2
    IL_002E: ldc.i4.1
    IL_0033: call 0x0600021E
    IL_0034: pop
    IL_0035: ret
    }

    private void ImageLoading() {
    IL_0004: newobj 0x060007CF
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x040010AA
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x040010AE
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_001A: stfld 0x040010AF
    IL_001B: ldloc.0
    IL_001C: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DE3
    IL_000A: brfalse IL_002C
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000E15
    IL_0016: call 0x0A00017C
    IL_001B: call 0x0A000024
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_320A16923: switch (3358087744 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0056
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000DDF
    IL_0010: brtrue IL_0031
    IL_0011: ldarg.0
    IL_0016: call 0x0600068D
    IL_001B: ldstr 0x70022F5F
    IL_001C: ldc.i4.0
    IL_0021: call 0x0600021F
    IL_0026: ldstr 0x70000DC1
    IL_002B: call 0x0A000128
    IL_0030: br IL_0051
    IL_0031: ldarg.0
    IL_0036: call 0x0600068F
    IL_003B: brfalse IL_0051
    IL_0040: ldstr 0x70022F5F
    IL_0041: ldc.i4.0
    IL_0046: call 0x0600021F
    IL_004B: ldstr 0x70022F87
    IL_0050: call 0x0A000128
    IL_0055: br IL_00A8
    IL_0056: ldarg.1
    IL_0057: ldc.i4.1
    IL_0188: switch (75 cases)
    }

    public void InitStat() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000DDF
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_001C
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000E16
    IL_0014: ldloc.0
    IL_0016: ldc.i4.s -2
    IL_0017: ldelem.i8
    IL_0018: ldloc.0
    IL_0019: ldc.i4.1
    IL_001A: IL_58
    IL_001B: stloc.0
    IL_001C: ldloc.0
    IL_001E: ldc.i4.s 20
    IL_001F: IL_3F
    IL_0020: IL_EA
    IL_0021: IL_FF
    IL_0022: IL_FF
    IL_0023: IL_FF
    IL_0028: ldstr 0x700004AB
    IL_0029: ldc.i4.1
    IL_002E: call 0x0A00009F
    IL_0033: ldstr 0x70023F55
    IL_0038: ldstr 0x70023F63
    IL_003D: call 0x0A00008F
    IL_0042: ldstr 0x7002270C
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_004A: stsfld 0x0255283F
    IL_004B: nop
    IL_004C: stloc.0
    IL_0051: ldstr 0x70022774
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0059: stsfld 0x0255283F
    IL_005A: nop
    IL_005B: stloc.0
    IL_0060: ldstr 0x70000575
    IL_0065: ldstr 0x70022ADA
    IL_006A: call 0x0A00008F
    IL_006F: ldstr 0x70000541
    IL_0070: ldc.i4.0
    IL_0075: call 0x0A00009F
    IL_007A: ldstr 0x70001E7D
    IL_007B: ldc.i4.0
    IL_0080: call 0x0600021F
    IL_0085: ldstr 0x70001E8B
    IL_0086: ldc.i4.0
    IL_008B: call 0x0600021F
    IL_0090: ldstr 0x70000B7F
    IL_0091: IL_22
    IL_0092: nop
    IL_0093: nop
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_22
    IL_0097: ldelem.i
    IL_0098: IL_99
    IL_0099: ldc.i4.3
    IL_009A: IL_3F
    IL_009B: IL_22
    IL_009C: nop
    IL_009D: nop
    IL_00A2: stsfld 0x0076733F
    IL_00A3: nop
    IL_00A4: stloc.0
    IL_00A9: call 0x060003F3
    IL_00AA: pop
    IL_00AF: ldstr 0x70000C8F
    IL_00B4: call 0x0A00001B
    IL_00B9: call 0x060003F3
    IL_00BA: pop
    IL_00BF: ldstr 0x70022F71
    IL_00C0: ldc.i4.0
    IL_00C5: call 0x0A00009F
    IL_00CA: ldstr 0x70000DDD
    IL_00CB: ldc.i4.1
    IL_00D0: call 0x0600021F
    IL_00D5: ldstr 0x70000DE5
    IL_00D6: ldc.i4.0
    IL_00DB: call 0x0600021F
    IL_00E0: ldstr 0x70001EA5
    IL_00E5: ldc.i4 1200
    IL_00EA: call 0x0600021F
    IL_00EF: ldstr 0x700004D5
    IL_00F0: ldc.i4.5
    IL_00F5: call 0x0600021F
    IL_00FA: ldstr 0x70001EAD
    IL_00FB: ldc.i4.4
    IL_0100: call 0x0600021F
    IL_0105: ldstr 0x70001EB5
    IL_0106: ldc.i4.3
    IL_010B: call 0x0600021F
    IL_0110: ldstr 0x70001EBD
    IL_0111: ldc.i4.3
    IL_0116: call 0x0600021F
    IL_011B: ldstr 0x700004DD
    IL_011C: ldc.i4.m1
    IL_0121: call 0x0600021F
    IL_0126: ldstr 0x7000066F
    IL_0127: ldc.i4.5
    IL_012C: call 0x0600021F
    IL_0131: ldstr 0x70001EC5
    IL_0132: ldc.i4.1
    IL_0137: call 0x0600021F
    IL_013C: ldstr 0x70001ECD
    IL_013D: ldc.i4.3
    IL_0142: call 0x0600021F
    IL_0147: ldstr 0x70001ED5
    IL_0148: ldc.i4.0
    IL_014D: call 0x0600021F
    IL_0152: ldstr 0x70001EDD
    IL_0154: ldc.i4.s 90
    IL_0159: newarr 0x0100000B
    IL_015E: call 0x060003F8
    IL_015F: pop
    IL_0164: ldstr 0x70001EE5
    IL_0166: ldc.i4.s 20
    IL_016B: newarr 0x0100000B
    IL_0170: call 0x060003F8
    IL_0171: pop
    IL_0176: ldstr 0x70001EED
    IL_0178: ldc.i4.s 20
    IL_017D: newarr 0x0100000B
    IL_0182: call 0x060003F8
    IL_0183: pop
    IL_0188: ldstr 0x70001EF5
    IL_0189: ldc.i4.6
    IL_018E: newarr 0x0100000B
    IL_0193: call 0x060003F8
    IL_0194: pop
    IL_0199: ldstr 0x7000054F
    IL_019A: ldarg.0
    IL_019F: ldfld 0x04000E16
    IL_01A4: call 0x060003F8
    IL_01A5: pop
    IL_01AA: ldstr 0x70001EFD
    IL_01AB: ldc.i4.2
    IL_01B0: newarr 0x0100000B
    IL_01B5: call 0x060003F8
    IL_01B6: pop
    IL_01BB: ldstr 0x70001F05
    IL_01BC: ldc.i4.2
    IL_01C1: newarr 0x0100000B
    IL_01C6: call 0x060003F8
    IL_01C7: pop
    IL_01CC: ldstr 0x70001F0D
    IL_01CD: ldc.i4.2
    IL_01D2: newarr 0x0100000B
    IL_01D7: call 0x060003F8
    IL_01D8: pop
    IL_01DD: ldstr 0x70000E0D
    IL_01DE: ldc.i4.1
    IL_01E3: call 0x0600021F
    IL_01E8: ldstr 0x70000E05
    IL_01E9: ldc.i4.1
    IL_01EE: call 0x0600021F
    IL_01F3: ldstr 0x70000E25
    IL_01F4: ldc.i4.1
    IL_01F9: call 0x0600021F
    IL_01FE: ldstr 0x70000E15
    IL_0200: ldc.i4.s 100
    IL_0205: call 0x0600021F
    IL_020A: ldstr 0x70000E1D
    IL_020B: ldc.i4.1
    IL_0210: call 0x0600021F
    IL_0215: ldstr 0x70000E2D
    IL_0216: ldc.i4.5
    IL_021B: call 0x0600021F
    IL_0220: ldstr 0x70000DD5
    IL_0221: ldc.i4.0
    IL_0226: call 0x0600021F
    IL_022B: ldstr 0x70000DB9
    IL_022C: ldc.i4.0
    IL_0231: call 0x0600021F
    IL_0236: ldstr 0x700017DB
    IL_0237: ldc.i4.0
    IL_023C: call 0x0600021F
    IL_0241: ldstr 0x70001F15
    IL_0243: ldc.i4.s 12
    IL_0248: newarr 0x0100000B
    IL_0249: dup
    IL_024A: ldc.i4.0
    IL_024F: ldc.i4 12707979
    IL_0250: ldelem.i8
    IL_0255: call 0x060003F8
    IL_0256: pop
    IL_025B: ldstr 0x70001F1D
    IL_025D: ldc.i4.s 12
    IL_0262: newarr 0x0100000B
    IL_0263: dup
    IL_0264: ldc.i4.0
    IL_0266: ldc.i4.s 100
    IL_0267: ldelem.i8
    IL_026C: call 0x060003F8
    IL_026D: pop
    IL_0272: ldstr 0x70001F25
    IL_0274: ldc.i4.s 12
    IL_0279: newarr 0x0100000B
    IL_027E: call 0x060003F8
    IL_027F: pop
    IL_0284: ldstr 0x70000DCD
    IL_0285: ldc.i4.6
    IL_028A: newarr 0x0100000B
    IL_028F: call 0x060003F8
    IL_0290: pop
    IL_0295: ldstr 0x70001F2D
    IL_0296: ldc.i4.0
    IL_029B: call 0x0600021F
    IL_02A0: ldstr 0x700014B5
    IL_02A1: ldc.i4.0
    IL_02A6: call 0x0600021F
    IL_02AB: ldstr 0x70000DED
    IL_02AD: ldc.i4.s 10
    IL_02B2: call 0x0600021F
    IL_02B7: ldstr 0x70000DF5
    IL_02B8: ldc.i4.8
    IL_02BD: call 0x0600021F
    IL_02C2: ldstr 0x70000DFD
    IL_02C3: ldc.i4.2
    IL_02C8: call 0x0600021F
    IL_02CD: ldstr 0x700014BD
    IL_02CE: ldc.i4.0
    IL_02D3: call 0x0600021F
    IL_02D8: ldstr 0x70000CDD
    IL_02D9: ldc.i4.0
    IL_02DE: call 0x0600021F
    IL_02E3: ldstr 0x70000BDB
    IL_02E4: ldc.i4.0
    IL_02E9: call 0x0600021F
    IL_02EE: ldstr 0x70001F45
    IL_02EF: ldc.i4.m1
    IL_02F4: call 0x0600021F
    IL_02F9: ldstr 0x70001F4D
    IL_02FA: ldc.i4.3
    IL_02FF: call 0x0600021F
    IL_0304: ldstr 0x70023247
    IL_0305: ldc.i4.1
    IL_030A: call 0x0600021F
    IL_030F: ldstr 0x70022DD9
    IL_0310: ldc.i4.1
    IL_0315: call 0x0600021F
    IL_031A: ldstr 0x700026F3
    IL_031B: ldc.i4.0
    IL_0320: call 0x0600021F
    IL_0325: ldstr 0x700028DD
    IL_0326: ldc.i4.3
    IL_032B: newarr 0x0100000B
    IL_0330: call 0x060003F8
    IL_0331: pop
    IL_0336: ldstr 0x7002305B
    IL_0337: ldc.i4.2
    IL_033C: newarr 0x0100000B
    IL_0341: call 0x060003F8
    IL_0342: pop
    IL_0347: ldstr 0x7002323F
    IL_0349: ldc.i4.s 100
    IL_034E: newarr 0x0100000B
    IL_0353: call 0x060003F8
    IL_0354: pop
    IL_0359: ldstr 0x700236FF
    IL_035B: ldc.i4.s 50
    IL_0360: newarr 0x0100000B
    IL_0365: call 0x060003F8
    IL_0366: pop
    IL_036B: ldstr 0x7002324F
    IL_036C: ldc.i4.0
    IL_0371: call 0x0600021F
    IL_0376: ldstr 0x70024004
    IL_0377: ldc.i4.0
    IL_037C: call 0x0600021F
    IL_0381: ldstr 0x7002400C
    IL_0382: ldc.i4.0
    IL_0387: call 0x0600021F
    IL_038C: ldstr 0x70023257
    IL_038D: ldc.i4.0
    IL_0392: call 0x0600021F
    IL_0397: ldstr 0x7002325F
    IL_0398: ldc.i4.0
    IL_039D: call 0x0600021F
    IL_03A2: ldstr 0x7000000F
    IL_03A3: ldc.i4.0
    IL_03A8: call 0x0600021F
    IL_03AD: ldstr 0x70001F55
    IL_03AE: ldc.i4.0
    IL_03B3: call 0x0600021F
    IL_03B8: ldstr 0x70001F71
    IL_03B9: ldc.i4.0
    IL_03BE: call 0x0600021F
    IL_03C3: ldstr 0x70001F83
    IL_03C4: ldc.i4.0
    IL_03C9: call 0x0600021F
    IL_03CE: ldstr 0x70001F9B
    IL_03CF: ldc.i4.5
    IL_03D4: newarr 0x0100000B
    IL_03D5: dup
    IL_03DA: ldtoken 0x040010CE
    IL_03DF: call 0x0A00018C
    IL_03E4: call 0x060003F8
    IL_03E5: pop
    IL_03EA: ldstr 0x70001FB1
    IL_03EC: ldc.i4.s 26
    IL_03F1: newarr 0x0100000B
    IL_03F2: dup
    IL_03F7: ldtoken 0x040010CF
    IL_03FC: call 0x0A00018C
    IL_0401: call 0x060003F8
    IL_0402: pop
    IL_0407: ldstr 0x70001563
    IL_0409: ldc.i4.s 26
    IL_040E: newarr 0x0100000B
    IL_040F: dup
    IL_0414: ldtoken 0x040010D0
    IL_0419: call 0x0A00018C
    IL_041E: call 0x060003F8
    IL_041F: pop
    IL_0424: ldstr 0x70001FB9
    IL_0426: ldc.i4.s 26
    IL_042B: newarr 0x0100000B
    IL_0430: call 0x060003F8
    IL_0431: pop
    IL_0436: ldstr 0x70000667
    IL_0437: ldc.i4.5
    IL_043C: newarr 0x0100000B
    IL_043D: dup
    IL_043E: ldc.i4.0
    IL_043F: ldc.i4.1
    IL_0440: ldelem.i8
    IL_0445: call 0x060003F8
    IL_0446: pop
    IL_044B: ldstr 0x70001FC1
    IL_044D: ldc.i4.s 24
    IL_0452: newarr 0x0100000B
    IL_0457: call 0x060003F8
    IL_0458: pop
    IL_045D: ldstr 0x70001FD3
    IL_045F: ldc.i4.s 30
    IL_0464: newarr 0x0100000B
    IL_0465: dup
    IL_0467: ldc.i4.s 27
    IL_0468: ldc.i4.1
    IL_0469: ldelem.i8
    IL_046E: call 0x060003F8
    IL_046F: pop
    IL_0474: ldstr 0x70001FDF
    IL_0476: ldc.i4.s 76
    IL_047B: newarr 0x0100000B
    IL_0480: call 0x060003F8
    IL_0481: pop
    IL_0486: ldstr 0x70001FEF
    IL_0488: ldc.i4.s 12
    IL_048D: newarr 0x0100000B
    IL_0492: call 0x060003F8
    IL_0493: pop
    IL_0498: ldstr 0x70002001
    IL_049A: ldc.i4.s 20
    IL_049F: newarr 0x0100000B
    IL_04A4: call 0x060003F8
    IL_04A5: pop
    IL_04AA: ldstr 0x70002015
    IL_04AB: ldc.i4.2
    IL_04B0: newarr 0x0100000B
    IL_04B5: call 0x060003F8
    IL_04B6: pop
    IL_04BB: ldstr 0x70002031
    IL_04BC: ldc.i4.0
    IL_04C1: call 0x0600021F
    IL_04C6: ldstr 0x70002045
    IL_04C7: ldc.i4.0
    IL_04CC: call 0x0600021F
    IL_04D1: ldstr 0x70000EC9
    IL_04D2: ldc.i4.0
    IL_04D7: call 0x0600021F
    IL_04DC: ldstr 0x70002059
    IL_04DD: ldc.i4.0
    IL_04E2: call 0x0600021F
    IL_04E7: ldstr 0x700015BF
    IL_04E8: ldc.i4.0
    IL_04ED: call 0x0600021F
    IL_04F2: ldstr 0x70002065
    IL_04F3: ldc.i4.0
    IL_04F8: call 0x0600021F
    IL_04FD: ldstr 0x7000207D
    IL_04FE: ldc.i4.2
    IL_0503: call 0x0600021F
    IL_0508: ldstr 0x70002093
    IL_0509: ldc.i4.0
    IL_050E: call 0x0600021F
    IL_0513: ldstr 0x700020A5
    IL_0514: ldc.i4.0
    IL_0519: call 0x0600021F
    IL_051E: call 0x0600056D
    IL_0523: call 0x0600056A
    IL_0528: call 0x0600040C
    IL_052D: ldstr 0x70000541
    IL_052E: ldc.i4.0
    IL_0533: call 0x0A00009F
    IL_0538: ldstr 0x70000541
    IL_053D: call 0x0A000095
    IL_0542: newobj 0x0100000B
    IL_0547: call 0x0A00013D
    IL_054C: ldstr 0x7000263B
    IL_0551: ldsfld 0x0A000099
    IL_0556: call 0x0A00008F
    IL_055B: ldstr 0x70002687
    IL_0560: ldstr 0x70001671
    IL_0565: call 0x06000221
    IL_056A: ldstr 0x700026AB
    IL_056F: ldstr 0x70001671
    IL_0574: call 0x06000221
    IL_0579: ldstr 0x7000269B
    IL_057E: ldstr 0x7002341D
    IL_0583: call 0x06000221
    IL_0588: ldstr 0x7000052B
    IL_0589: ldc.i4.0
    IL_058E: call 0x0A00009F
    IL_058F: ldarg.0
    IL_0590: ldc.i4.0
    IL_0595: stfld 0x04000E12
    IL_0596: ret
    }

    public void StartGUI() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000DE3
    IL_0007: ret
    }

    public void SetVersionStart() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000DDF
    IL_0006: ldc.i4.3
    IL_0007: IL_3C
    IL_0008: mul
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_000D: ldc.i4.3
    IL_0012: stfld 0x04000DDF
    IL_0017: ldstr 0x70001F4D
    IL_0018: ldc.i4.3
    IL_001D: call 0x0600021F
    IL_0022: ldstr 0x70022F71
    IL_0023: ldc.i4.3
    IL_0028: call 0x0A00009F
    IL_002D: ldstr 0x70024014
    IL_0032: call 0x06000220
    IL_0033: stloc.0
    IL_0034: ldloc.0
    IL_0036: ldc.i4.s 99
    IL_0037: IL_3E
    IL_0038: ldc.i4.1
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003D: ldc.i4.s 99
    IL_003E: ldloc.0
    IL_0040: ldc.i4.s 99
    IL_0041: IL_59
    IL_0043: ldc.i4.s 100
    IL_0044: add
    IL_0045: IL_58
    IL_0046: stloc.0
    IL_0047: ldloc.0
    IL_004C: ldc.i4 199
    IL_0051: call 0x0A00010B
    IL_0052: stloc.0
    IL_0057: ldstr 0x70000DDD
    IL_0058: ldloc.0
    IL_005D: call 0x0600021F
    IL_0062: ldstr 0x7000052B
    IL_0063: ldc.i4.1
    IL_0068: call 0x0A00009F
    IL_0069: ldarg.0
    IL_006E: ldfld 0x04000DDF
    IL_006F: ldc.i4.4
    IL_0070: IL_3C
    IL_0071: IL_C5
    IL_0072: nop
    IL_0073: nop
    IL_0074: nop
    IL_0075: ldarg.0
    IL_0076: ldc.i4.4
    IL_007B: stfld 0x04000DDF
    IL_0080: ldstr 0x70023247
    IL_0081: ldc.i4.1
    IL_0086: call 0x0600021F
    IL_008B: ldstr 0x70022DD9
    IL_008C: ldc.i4.1
    IL_0091: call 0x0600021F
    IL_0096: ldstr 0x700028DD
    IL_0097: ldc.i4.3
    IL_009C: newarr 0x0100000B
    IL_00A1: call 0x060003F8
    IL_00A2: pop
    IL_00A7: ldstr 0x7002305B
    IL_00A8: ldc.i4.2
    IL_00AD: newarr 0x0100000B
    IL_00B2: call 0x060003F8
    IL_00B3: pop
    IL_00B8: ldstr 0x70000C8F
    IL_00BD: call 0x0A00001B
    IL_00C2: call 0x060003F3
    IL_00C3: pop
    IL_00C8: ldstr 0x7002323F
    IL_00CA: ldc.i4.s 100
    IL_00CF: newarr 0x0100000B
    IL_00D4: call 0x060003F8
    IL_00D5: pop
    IL_00DA: ldstr 0x700236FF
    IL_00DC: ldc.i4.s 50
    IL_00E1: newarr 0x0100000B
    IL_00E6: call 0x060003F8
    IL_00E7: pop
    IL_00EC: ldstr 0x7002324F
    IL_00ED: ldc.i4.0
    IL_00F2: call 0x0600021F
    IL_00F7: ldstr 0x70024004
    IL_00F8: ldc.i4.0
    IL_00FD: call 0x0600021F
    IL_0102: ldstr 0x7002400C
    IL_0103: ldc.i4.0
    IL_0108: call 0x0600021F
    IL_010D: ldstr 0x70023257
    IL_010E: ldc.i4.0
    IL_0113: call 0x0600021F
    IL_0118: ldstr 0x7002325F
    IL_0119: ldc.i4.0
    IL_011E: call 0x0600021F
    IL_0123: call 0x0600056D
    IL_0128: ldstr 0x70022F71
    IL_0129: ldc.i4.4
    IL_012E: call 0x0A00009F
    IL_0133: ldstr 0x70022F71
    IL_0134: ldc.i4.4
    IL_0139: call 0x0A00009F
    IL_013A: ldarg.0
    IL_013F: ldfld 0x04000DDF
    IL_0140: ldc.i4.6
    IL_0141: IL_3C
    IL_0142: IL_C9
    IL_0143: nop
    IL_0144: nop
    IL_0145: nop
    IL_014A: ldstr 0x70023247
    IL_014B: ldc.i4.1
    IL_0150: call 0x0600021F
    IL_0155: ldstr 0x70022DD9
    IL_0156: ldc.i4.1
    IL_015B: call 0x0600021F
    IL_0160: ldstr 0x700028DD
    IL_0161: ldc.i4.3
    IL_0166: newarr 0x0100000B
    IL_016B: call 0x060003F8
    IL_016C: pop
    IL_0171: ldstr 0x7002305B
    IL_0172: ldc.i4.2
    IL_0177: newarr 0x0100000B
    IL_017C: call 0x060003F8
    IL_017D: pop
    IL_0182: ldstr 0x70000C8F
    IL_0187: call 0x0A00001B
    IL_018C: call 0x060003F3
    IL_018D: pop
    IL_0192: ldstr 0x7002323F
    IL_0194: ldc.i4.s 100
    IL_0199: newarr 0x0100000B
    IL_019E: call 0x060003F8
    IL_019F: pop
    IL_01A4: ldstr 0x700236FF
    IL_01A6: ldc.i4.s 50
    IL_01AB: newarr 0x0100000B
    IL_01B0: call 0x060003F8
    IL_01B1: pop
    IL_01B6: ldstr 0x7002324F
    IL_01B7: ldc.i4.0
    IL_01BC: call 0x0600021F
    IL_01C1: ldstr 0x70024004
    IL_01C2: ldc.i4.0
    IL_01C7: call 0x0600021F
    IL_01CC: ldstr 0x7002400C
    IL_01CD: ldc.i4.0
    IL_01D2: call 0x0600021F
    IL_01D7: ldstr 0x70023257
    IL_01D8: ldc.i4.0
    IL_01DD: call 0x0600021F
    IL_01E2: ldstr 0x7002325F
    IL_01E3: ldc.i4.0
    IL_01E8: call 0x0600021F
    IL_01ED: ldstr 0x7000000F
    IL_01EE: ldc.i4.0
    IL_01F3: call 0x0600021F
    IL_01F8: ldstr 0x70001ECD
    IL_01F9: ldc.i4.3
    IL_01FE: call 0x0600021F
    IL_0203: call 0x0600056D
    IL_0208: ldstr 0x70022F71
    IL_0209: ldc.i4.6
    IL_020E: call 0x0A00009F
    IL_0213: call 0x0600056A
    IL_0214: ldc.i4.1
    IL_0215: ret
    }

    public void ItemDelivery() {
    IL_0000: ldc.i4.7
    IL_0005: newarr 0x0100000C
    IL_0006: dup
    IL_0007: ldc.i4.0
    IL_000C: ldstr 0x7002401C
    IL_0011: stelem 0x28721725
    IL_9689C01E: switch (631402498 cases)
    }

    private void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000E19
    IL_0007: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000E06
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000DE3
    IL_004B: brtrue IL_004D
    IL_004C: ret
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000E19
    IL_0053: ldc.i4.0
    IL_0054: IL_3E
    IL_0055: ldloc.0
    IL_0056: nop
    IL_0057: nop
    IL_0058: nop
    IL_0059: ldc.i4.0
    IL_005E: call 0x0A0001B9
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000E15
    IL_0069: call 0x0A0000F0
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_D8
    IL_006E: IL_42
    IL_006F: IL_22
    IL_0070: nop
    IL_0071: nop
    IL_0072: IL_C0
    IL_2000000FF: switch (2147483682 cases)
    }

    private void getTexture() {
    IL_0000: ldarg.1
    IL_0002: ldc.i4.s 49
    IL_0023: switch (7 cases)
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000DFB
    IL_002C: ret
    IL_002D: ldarg.1
    IL_002F: ldc.i4.s 52
    IL_0050: switch (7 cases)
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000DFE
    IL_0059: ret
    IL_005A: ldarg.1
    IL_005C: ldc.i4.s 55
    IL_007D: switch (7 cases)
    IL_007E: nop
    IL_007F: nop
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000E01
    IL_0086: ret
    IL_0087: ldarg.0
    IL_008C: ldfld 0x04000DF8
    IL_008D: ret
    }

    private static void ValidateMobile() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00020C
    IL_000A: brfalse IL_000D
    IL_000B: ldc.i4.0
    IL_000C: ret
    IL_000D: ldarg.0
    IL_0012: ldstr 0x70024074
    IL_0017: call 0x0A00031D
    IL_0018: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00002B
    IL_000A: ldstr 0x70022774
    IL_000F: call 0x0A0001C1
    IL_0010: conv.r8
    IL_0011: IL_C9
    IL_0012: IL_01
    IL_0013: nop
    IL_0014: stloc.0
    IL_0015: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000E34
    IL_000C: ldarg.0
    IL_000D: ldc.i4.5
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000E3B
    IL_0018: ldarg.0
    IL_0019: ldc.i4.5
    IL_001E: newarr 0x0100003C
    IL_0023: stfld 0x04000E49
    IL_0024: ldarg.0
    IL_0025: ldc.i4.5
    IL_002A: newarr 0x0100003C
    IL_002F: stfld 0x04000E4A
    IL_0030: ldarg.0
    IL_0031: ldc.i4.2
    IL_0036: newarr 0x0100003C
    IL_003B: stfld 0x04000E4D
    IL_003C: ldarg.0
    IL_003D: ldc.i4.5
    IL_0042: newarr 0x0100003C
    IL_0047: stfld 0x04000E58
    IL_0048: ldarg.0
    IL_0049: ldc.i4.3
    IL_004E: newarr 0x01000003
    IL_0053: stfld 0x04000E5C
    IL_0054: ldarg.0
    IL_0055: ldc.i4.1
    IL_005A: stfld 0x04000E7F
    IL_005B: ldarg.0
    IL_005C: ldc.i4.m1
    IL_0061: stfld 0x04000E96
    IL_0062: ldarg.0
    IL_0063: ldc.i4.m1
    IL_0068: stfld 0x04000E97
    IL_0069: ldarg.0
    IL_006E: ldc.i4 480
    IL_0073: stfld 0x04000E9A
    IL_0074: ldarg.0
    IL_0075: IL_22
    IL_0076: nop
    IL_007B: stsfld 0x9C7D44BB
    IL_007D: ldarg.s 0
    IL_007E: ldarg.2
    IL_007F: ldarg.0
    IL_0081: ldc.i4.s 90
    IL_0086: newarr 0x0100000B
    IL_008B: stfld 0x04000EB6
    IL_008C: ldarg.0
    IL_008E: ldc.i4.s 12
    IL_0093: newarr 0x0100000B
    IL_0098: stfld 0x04000EB7
    IL_0099: ldarg.0
    IL_009A: ldc.i4.m1
    IL_009F: stfld 0x04000EBC
    IL_00A0: ldarg.0
    IL_00A1: ldc.i4.1
    IL_00A6: stfld 0x04000EBE
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4.5
    IL_00AD: newarr 0x0100000B
    IL_00AE: dup
    IL_00B3: ldtoken 0x040010D2
    IL_00B8: call 0x0A00018C
    IL_00BD: stfld 0x04000EBF
    IL_00BE: ldarg.0
    IL_00BF: ldc.i4.2
    IL_00C4: newarr 0x0100000B
    IL_00C9: stfld 0x04000EC0
    IL_00CA: ldarg.0
    IL_00CB: ldc.i4.2
    IL_00D0: newarr 0x0100000B
    IL_00D5: stfld 0x04000EC1
    IL_00D6: ldarg.0
    IL_00D7: ldc.i4.5
    IL_00DC: newarr 0x0100000B
    IL_00E1: stfld 0x04000EC2
    IL_00E2: ldarg.0
    IL_00E3: ldc.i4.m1
    IL_00E8: stfld 0x04000ECA
    IL_00E9: ldarg.0
    IL_00EE: call 0x0A000001
    IL_00EF: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70022774
    IL_000A: call 0x0A0001C1
    IL_000F: stfld 0x04000EAB
    IL_0010: ldarg.0
    IL_0015: ldstr 0x7002270C
    IL_001A: call 0x0A0001C1
    IL_001F: stfld 0x04000EAC
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000EAC
    IL_002A: call 0x0A0001C2
    IL_002F: call 0x0600056A
    IL_0030: ldarg.0
    IL_0035: call 0x0A000035
    IL_0036: conv.r8
    IL_0037: ldarg.0
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003F: stfld 0x04000E76
    IL_0040: ldarg.0
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000E76
    IL_0047: conv.r8
    IL_0048: ldind.ref
    IL_0049: nop
    IL_004A: nop
    IL_004C: br.s IL_00CA
    IL_004D: IL_78
    IL_004F: ldarg.s 0
    IL_0050: ldarg.2
    IL_0051: ldarg.0
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: IL_E0
    IL_0056: IL_42
    IL_0057: IL_22
    IL_0058: nop
    IL_0059: nop
    IL_005A: IL_4C
    IL_005B: IL_43
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_0063: stsfld 0x00002243
    IL_0064: IL_C8
    IL_0065: IL_42
    IL_006A: call 0x0600021D
    IL_006F: stfld 0x04000ECF
    IL_0070: ldarg.0
    IL_0075: ldstr 0x70022DCB
    IL_007A: call 0x0A000004
    IL_007B: conv.r8
    IL_0080: stfld 0x7D2B0000
    IL_0085: ldfld 0x0204000E
    IL_008A: ldstr 0x70000557
    IL_008B: ldc.i4.0
    IL_0090: call 0x0A0002BB
    IL_0095: stfld 0x04000ECB
    IL_0096: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x7000066F
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000EA3
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70001EA5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000EA2
    IL_0020: ldarg.0
    IL_0025: ldstr 0x700004D5
    IL_002A: call 0x06000220
    IL_002F: stfld 0x04000EA1
    IL_0030: ldarg.0
    IL_0035: ldfld 0x04000E90
    IL_0036: ldc.i4.2
    IL_0037: IL_3F
    IL_0038: IL_3E
    IL_0039: nop
    IL_003A: nop
    IL_003B: nop
    IL_003C: ldarg.0
    IL_0041: ldfld 0x04000E60
    IL_0046: call 0x0A00004B
    IL_0047: IL_22
    IL_0048: shr
    IL_0049: shr
    IL_004E: isinst 0x00082840
    IL_004F: nop
    IL_0050: stloc.0
    IL_0051: conv.r8
    IL_0052: IL_AF
    IL_0053: nop
    IL_0054: nop
    IL_0055: stloc.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04000E60
    IL_005C: IL_22
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: nop
    IL_0061: IL_22
    IL_0062: IL_8F
    IL_0063: IL_C2
    IL_0064: conv.u8
    IL_0065: IL_BE
    IL_0066: IL_22
    IL_0067: nop
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_3F
    IL_006F: newobj 0x0A000076
    IL_0070: conv.r8
    IL_0071: conv.ovf.i4.un
    IL_0072: IL_01
    IL_0073: nop
    IL_0074: stloc.0
    IL_0079: br IL_0085
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000E78
    IL_0080: conv.r8
    IL_0081: ldnull
    IL_0082: IL_01
    IL_0083: nop
    IL_0084: ldloc.0
    IL_0085: ret
    }

    private void Start() {
    IL_0004: ldstr 0x70023257
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000F: ldstr 0x7002325F
    IL_0014: call 0x06000220
    IL_0015: stloc.1
    IL_0016: ldloc.0
    IL_001B: brfalse IL_0034
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_0022: call 0x0600021E
    IL_0023: pop
    IL_0028: ldstr 0x70023257
    IL_0029: ldc.i4.0
    IL_002E: call 0x0600021F
    IL_0033: br IL_004D
    IL_0034: ldloc.1
    IL_0039: brfalse IL_004D
    IL_003A: ldloc.1
    IL_003B: ldc.i4.0
    IL_0040: call 0x0600021E
    IL_0041: pop
    IL_0046: ldstr 0x7002325F
    IL_0047: ldc.i4.0
    IL_004C: call 0x0600021F
    IL_0051: ldstr 0x700231E5
    IL_0056: call 0x0A000077
    IL_0057: stloc.2
    IL_0058: ldloc.2
    IL_0059: ldnull
    IL_005E: call 0x0A000061
    IL_0063: brfalse IL_00A9
    IL_0068: ldstr 0x700231E5
    IL_006D: call 0x0A000012
    IL_006E: conv.u8
    IL_006F: ldloc.0
    IL_0070: nop
    IL_0071: nop
    IL_0072: IL_01
    IL_0073: stloc.3
    IL_0074: ldarg.0
    IL_0075: ldloc.3
    IL_0076: conv.r8
    IL_0077: ldarg.3
    IL_0078: nop
    IL_0079: nop
    IL_007A: stloc.0
    IL_007F: call 0x0A00001B
    IL_0084: call 0x0A000013
    IL_0089: call 0x0A000014
    IL_008A: conv.u4
    IL_008B: ldarg.1
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_01
    IL_0093: stfld 0x04000E62
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000E62
    IL_009E: ldstr 0x700231E5
    IL_009F: conv.r8
    IL_00A0: IL_DC
    IL_00A1: IL_01
    IL_00A2: nop
    IL_00A3: stloc.0
    IL_00A8: br IL_00B5
    IL_00A9: ldarg.0
    IL_00AA: ldloc.2
    IL_00AB: conv.r8
    IL_00AC: ldarg.3
    IL_00AD: nop
    IL_00AE: nop
    IL_00AF: stloc.0
    IL_00B4: stfld 0x04000E62
    IL_00B5: ldarg.0
    IL_00BA: ldstr 0x70001EDD
    IL_00BF: call 0x060003F9
    IL_00C4: stfld 0x04000EB6
    IL_00C5: ldarg.0
    IL_00C6: ldarg.0
    IL_00CB: call 0x2B000085
    IL_00D0: stfld 0x04000E79
    IL_00D1: ldarg.0
    IL_00D2: ldarg.0
    IL_00D7: call 0x2B000067
    IL_00DC: stfld 0x04000E7A
    IL_00DD: ldarg.0
    IL_00E2: ldstr 0x70000BB3
    IL_00E7: call 0x0A000095
    IL_00EC: stfld 0x04000EA8
    IL_00ED: ldarg.0
    IL_00F2: ldstr 0x70002093
    IL_00F7: call 0x06000220
    IL_00FC: stfld 0x04000ECA
    IL_00FD: ldarg.0
    IL_0102: ldstr 0x70000DDD
    IL_0107: call 0x06000220
    IL_010C: stfld 0x04000EBB
    IL_010D: ldarg.0
    IL_0112: ldstr 0x70000DE5
    IL_0117: call 0x06000220
    IL_011C: stfld 0x04000ECE
    IL_011D: ldarg.0
    IL_0122: ldstr 0x70001F9B
    IL_0127: call 0x060003F9
    IL_012C: stfld 0x04000EC2
    IL_012D: ldarg.0
    IL_0132: ldstr 0x70001EAD
    IL_0137: call 0x06000220
    IL_013C: stfld 0x04000EA7
    IL_013D: ldarg.0
    IL_0142: ldstr 0x70001F0D
    IL_0147: call 0x060003F9
    IL_014C: stfld 0x04000EC1
    IL_014D: ldarg.0
    IL_0152: ldstr 0x700004DD
    IL_0157: call 0x06000220
    IL_015C: stfld 0x04000E93
    IL_015D: ldarg.0
    IL_0162: ldstr 0x7000207D
    IL_0167: call 0x06000220
    IL_016C: stfld 0x04000E8C
    IL_016D: ldarg.0
    IL_0172: ldstr 0x70001F2D
    IL_0177: call 0x06000220
    IL_017C: stfld 0x04000E96
    IL_017D: ldarg.0
    IL_0182: ldstr 0x70001F15
    IL_0187: call 0x060003F9
    IL_018C: stfld 0x04000EB7
    IL_018D: ldarg.0
    IL_0192: ldfld 0x04000E96
    IL_0193: ldc.i4.0
    IL_0194: IL_3F
    IL_0199: call 0x72000000
    IL_019A: ldc.i4.7
    IL_019C: ldc.i4.s 0
    IL_01A1: cpobj 0x0003F928
    IL_01A2: ldloc.0
    IL_01A4: stloc.s 4
    IL_01A5: ldarg.0
    IL_01A7: ldloc.s 4
    IL_01A8: ldarg.0
    IL_01AD: ldfld 0x04000E96
    IL_01AE: IL_94
    IL_01B3: stfld 0x04000EB8
    IL_01B4: ldarg.0
    IL_01B9: call 0x0600069D
    IL_01BA: ldarg.0
    IL_01BB: ldc.i4.1
    IL_01C0: call 0x0600069C
    IL_01C1: ldarg.0
    IL_01C2: ldarg.0
    IL_01C7: ldfld 0x04000ECE
    IL_01C8: conv.i2
    IL_01C9: ldarg.0
    IL_01CE: ldfld 0x04000EBB
    IL_01D0: ldc.i4.s 100
    IL_01D1: IL_5A
    IL_01D2: conv.i2
    IL_01D3: add
    IL_01D4: IL_22
    IL_01D5: nop
    IL_01D6: nop
    IL_01D9: ldloc 23106
    IL_01DE: stfld 0x04000EBD
    IL_01DF: ldc.i4.0
    IL_01E1: stloc.s 5
    IL_01E6: br IL_022D
    IL_01E7: ldarg.0
    IL_01EC: ldfld 0x04000EC2
    IL_01EE: ldloc.s 5
    IL_01EF: IL_94
    IL_01F0: ldc.i4.0
    IL_01F1: IL_3F
    IL_01F3: ble.s IL_01F4
    IL_01F4: nop
    IL_01F5: nop
    IL_01F6: ldarg.0
    IL_01FB: ldfld 0x04000E3B
    IL_01FD: ldloc.s 5
    IL_0202: ldstr 0x700232C3
    IL_0203: ldarg.0
    IL_0208: ldfld 0x04000EC2
    IL_020A: ldloc.s 5
    IL_020B: IL_94
    IL_020C: ldc.i4.1
    IL_020D: IL_58
    IL_020F: stloc.s 10
    IL_0211: ldloca.s 10
    IL_0216: call 0x0A000010
    IL_021B: call 0x0A000011
    IL_0220: call 0x0A000012
    IL_0221: conv.u8
    IL_0222: IL_3C
    IL_0223: nop
    IL_0224: nop
    IL_0225: IL_01
    IL_022A: stelem 0x58170511
    IL_022C: stloc.s 5
    IL_022E: ldloc.s 5
    IL_022F: ldc.i4.5
    IL_0230: IL_3F
    IL_0231: IL_B2
    IL_0232: IL_FF
    IL_0233: IL_FF
    IL_0234: IL_FF
    IL_0235: ldarg.0
    IL_023A: ldfld 0x04000E93
    IL_023B: ldc.i4.6
    IL_023C: IL_3E
    IL_023E: br.s IL_023F
    IL_023F: nop
    IL_0240: nop
    IL_0241: ldc.i4.0
    IL_0243: stloc.s 6
    IL_0248: br IL_0264
    IL_0249: ldarg.0
    IL_024E: ldfld 0x04000EC1
    IL_0250: ldloc.s 6
    IL_0251: IL_94
    IL_0256: brtrue IL_025E
    IL_0257: ldarg.0
    IL_0258: ldc.i4.1
    IL_025D: stfld 0x04000E85
    IL_025F: ldloc.s 6
    IL_0260: ldc.i4.1
    IL_0261: IL_58
    IL_0263: stloc.s 6
    IL_0265: ldloc.s 6
    IL_0266: ldc.i4.2
    IL_0267: IL_3F
    IL_0268: IL_DD
    IL_0269: IL_FF
    IL_026A: IL_FF
    IL_026B: IL_FF
    IL_0270: ldstr 0x70000121
    IL_0275: call 0x0A000004
    IL_0276: ldnull
    IL_027B: call 0x0A000061
    IL_0280: brfalse IL_02A6
    IL_0281: ldarg.0
    IL_0282: ldarg.0
    IL_0287: ldfld 0x04000E5D
    IL_028C: call 0x0A00001B
    IL_0291: call 0x0A000013
    IL_0296: call 0x0A000014
    IL_0297: conv.u4
    IL_0298: ldarg.1
    IL_0299: nop
    IL_029A: nop
    IL_029B: IL_01
    IL_02A0: stfld 0x04000E75
    IL_02A5: br IL_02BB
    IL_02A6: ldarg.0
    IL_02AB: ldstr 0x70000121
    IL_02B0: call 0x0A000004
    IL_02B1: conv.r8
    IL_02B2: ldarg.3
    IL_02B3: nop
    IL_02B4: nop
    IL_02B5: stloc.0
    IL_02BA: stfld 0x04000E75
    IL_02BB: ldarg.0
    IL_02C0: ldfld 0x04000E8C
    IL_02C1: ldc.i4.0
    IL_02C2: IL_3E
    IL_02C3: IL_27
    IL_02C4: nop
    IL_02C5: nop
    IL_02C6: nop
    IL_02C7: ldarg.0
    IL_02CC: ldstr 0x700240AA
    IL_02CD: IL_22
    IL_02CE: nop
    IL_02CF: nop
    IL_02D4: stsfld 0x003F283F
    IL_02D5: nop
    IL_02D6: stloc.0
    IL_02D7: ldarg.0
    IL_02D8: ldc.i4.1
    IL_02DD: stfld 0x04000E8D
    IL_02DE: ldarg.0
    IL_02E3: ldfld 0x04000E78
    IL_02E4: conv.r8
    IL_02E6: stloc.s 1
    IL_02E7: nop
    IL_02E8: ldloc.0
    IL_02ED: br IL_030B
    IL_02EE: ldarg.0
    IL_02F3: ldfld 0x04000E93
    IL_02F4: ldc.i4.1
    IL_02F5: IL_3F
    IL_02F7: ldloc.s 0
    IL_02F8: nop
    IL_02F9: nop
    IL_02FA: ldarg.0
    IL_02FB: ldarg.0
    IL_0300: ldfld 0x04000E7B
    IL_0301: conv.r8
    IL_0302: IL_91
    IL_0303: ldarg.1
    IL_0304: nop
    IL_0305: ldloc.0
    IL_030A: stfld 0x04000E87
    IL_030B: ldarg.0
    IL_0310: ldstr 0x70001F45
    IL_0315: call 0x06000220
    IL_031A: stfld 0x04000EBC
    IL_031B: ldarg.0
    IL_0320: ldfld 0x04000ECA
    IL_0321: ldc.i4.5
    IL_0342: switch (7 cases)
    IL_0344: ldloc.s 9
    IL_0345: conv.r8
    IL_034A: brtrue IL_6F0A034B
    IL_034B: ldc.i4.2
    IL_034C: nop
    IL_034D: nop
    IL_034E: stloc.0
    IL_0353: call 0x0A000042
    IL_0354: IL_22
    IL_0355: IL_CD
    IL_0356: IL_CC
    IL_0357: IL_4C
    IL_0358: IL_3E
    IL_035D: call 0x0A000008
    IL_0362: call 0x0A000029
    IL_0367: call 0x0A000007
    IL_0368: IL_22
    IL_0369: IL_EC
    IL_036A: IL_51
    IL_036B: IL_B8
    IL_036C: IL_3D
    IL_0371: call 0x0A000008
    IL_0376: call 0x0A000029
    IL_037B: stfld 0x04000E7D
    IL_037D: ldloc.s 9
    IL_037E: ldarg.0
    IL_0383: ldfld 0x04000E93
    IL_06BC: switch (205 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_00B6: switch (44 cases)
    }

    public void CurGeneralStat() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_0041
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000E96
    IL_000C: ldc.i4.m1
    IL_0011: beq IL_003C
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000E7A
    IL_0018: ldarg.0
    IL_001D: ldfld 0x04000EB7
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000E96
    IL_0024: IL_94
    IL_0025: conv.r8
    IL_0026: IL_F5
    IL_0027: ldarg.0
    IL_0028: nop
    IL_0029: ldloc.0
    IL_002A: ldarg.0
    IL_002B: ldarg.0
    IL_0030: ldfld 0x04000E7A
    IL_0035: ldfld 0x04000677
    IL_0036: conv.i2
    IL_003B: stfld 0x04000E9C
    IL_0040: br IL_004E
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x04000EB2
    IL_0048: conv.i2
    IL_004D: stfld 0x04000E9C
    IL_004E: ret
    }

    public void GeneralKindOnly() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000EB7
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000E96
    IL_000C: IL_94
    IL_0011: ldc.i4 10000000
    IL_0012: mul
    IL_0017: ldc.i4 100000
    IL_0018: add
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldstr 0x70022E37
    IL_0020: ldloc.0
    IL_0021: ldc.i4.1
    IL_0022: IL_58
    IL_0023: stloc.1
    IL_0025: ldloca.s 1
    IL_002A: call 0x0A000010
    IL_002F: call 0x0A000011
    IL_0034: call 0x0A000012
    IL_0035: conv.u8
    IL_0036: IL_3C
    IL_0037: nop
    IL_0038: nop
    IL_0039: IL_01
    IL_003E: stfld 0x04000E39
    IL_003F: ret
    }

    public void GeneralStat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000E7A
    IL_0006: ldarg.1
    IL_0007: conv.r8
    IL_0008: IL_F5
    IL_0009: ldarg.0
    IL_000A: nop
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000E7A
    IL_0017: ldfld 0x04000675
    IL_001C: stfld 0x04000EAE
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_0023: ldfld 0x04000E7A
    IL_0028: ldfld 0x04000676
    IL_002D: stfld 0x04000EAF
    IL_002E: ldarg.0
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000E7A
    IL_0039: ldfld 0x04000678
    IL_003E: stfld 0x04000EB0
    IL_003F: ldarg.0
    IL_0040: ldarg.0
    IL_0045: ldfld 0x04000E7A
    IL_004A: ldfld 0x04000679
    IL_004F: stfld 0x04000EB1
    IL_0050: ldarg.0
    IL_0051: ldarg.0
    IL_0056: ldfld 0x04000E7A
    IL_005B: ldfld 0x04000677
    IL_0060: stfld 0x04000EB2
    IL_0061: ldarg.0
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04000E7A
    IL_006C: ldfld 0x0400067A
    IL_0071: stfld 0x04000EB5
    IL_0072: ldarg.0
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04000E7A
    IL_007D: ldfld 0x0400067D
    IL_0082: stfld 0x04000EB3
    IL_0083: ldarg.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000E7A
    IL_008E: ldfld 0x0400067C
    IL_0093: stfld 0x04000EB4
    IL_0094: ldarg.2
    IL_0099: brtrue IL_0132
    IL_009A: ldarg.0
    IL_009F: ldfld 0x04000EB7
    IL_00A0: ldarg.0
    IL_00A5: ldfld 0x04000E9B
    IL_00A6: IL_94
    IL_00AB: ldc.i4 10000000
    IL_00AC: mul
    IL_00B1: ldc.i4 100000
    IL_00B2: add
    IL_00B3: stloc.0
    IL_00B4: ldarg.0
    IL_00B9: ldstr 0x70022E37
    IL_00BA: ldloc.0
    IL_00BB: ldc.i4.1
    IL_00BC: IL_58
    IL_00BD: stloc.3
    IL_00BF: ldloca.s 3
    IL_00C4: call 0x0A000010
    IL_00C9: call 0x0A000011
    IL_00CE: call 0x0A000012
    IL_00CF: conv.u8
    IL_00D0: IL_3C
    IL_00D1: nop
    IL_00D2: nop
    IL_00D3: IL_01
    IL_00D8: stfld 0x04000E3A
    IL_00DD: ldstr 0x70001F1D
    IL_00E2: call 0x060003F9
    IL_00E3: stloc.1
    IL_00E4: ldloc.1
    IL_00E5: ldarg.0
    IL_00EA: ldfld 0x04000E9B
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x04000EB2
    IL_00F1: ldelem.i8
    IL_00F6: ldstr 0x70001F1D
    IL_00F7: ldloc.1
    IL_00FC: call 0x060003F8
    IL_00FD: pop
    IL_0102: ldstr 0x70001FD3
    IL_0107: call 0x060003F9
    IL_0108: stloc.2
    IL_0109: ldloc.2
    IL_010A: ldarg.0
    IL_010F: ldfld 0x04000EAE
    IL_0110: ldloc.2
    IL_0111: ldarg.0
    IL_0116: ldfld 0x04000EAE
    IL_0117: IL_94
    IL_0118: ldarg.0
    IL_011D: ldfld 0x04000EB3
    IL_011E: ldc.i4.1
    IL_011F: IL_58
    IL_0124: call 0x0A000080
    IL_0125: ldelem.i8
    IL_012A: ldstr 0x70001FD3
    IL_012B: ldloc.2
    IL_0130: call 0x060003F8
    IL_0131: pop
    IL_0132: ret
    }

    private void SetServerTime() {
    IL_0004: call 0x0600056E
    IL_0005: ldarg.0
    IL_000A: call 0x060006A0
    IL_000B: ret
    }

    public void DelayWorkTime() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_0019
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000EC0
    IL_000D: ldloc.0
    IL_000E: ldloc.0
    IL_0013: call 0x0600056F
    IL_0014: ldelem.i8
    IL_0015: ldloc.0
    IL_0016: ldc.i4.1
    IL_0017: IL_58
    IL_0018: stloc.0
    IL_0019: ldloc.0
    IL_001A: ldc.i4.2
    IL_001B: IL_3F
    IL_001C: IL_E7
    IL_001D: IL_FF
    IL_001E: IL_FF
    IL_001F: IL_FF
    IL_0020: ldarg.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000EB8
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04000EC0
    IL_002D: ldc.i4.1
    IL_002E: IL_94
    IL_002F: conv.i2
    IL_0030: IL_22
    IL_0031: IL_CD
    IL_0032: IL_CC
    IL_0033: IL_4C
    IL_0034: IL_3E
    IL_0035: IL_5A
    IL_0036: not
    IL_0037: IL_58
    IL_003C: stfld 0x04000EB9
    IL_003D: ldarg.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000EB9
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000E9C
    IL_004A: not
    IL_004F: call 0x0A00010B
    IL_0054: stfld 0x04000EB9
    IL_0055: ret
    }

    public void Zoom_finger() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_000B
    IL_000A: br IL_000B
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x04000E7E
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000E78
    IL_0018: ldarg.1
    IL_0019: ldarg.2
    IL_001A: conv.r8
    IL_001B: ldc.i4.m1
    IL_001C: IL_01
    IL_001D: nop
    IL_001E: ldloc.0
    IL_001F: ret
    }

    public void ExploreIconArray() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000E8E
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000EC3
    IL_0011: call 0x0A00004B
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0019: ldc.i4 534593
    IL_001A: nop
    IL_001B: stloc.0
    IL_001C: conv.r8
    IL_001D: ldloc.3
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000EC5
    IL_002B: call 0x0A00004B
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_002F: ldelem.r8
    IL_0030: IL_41
    IL_0035: call 0x0A000008
    IL_0036: conv.r8
    IL_0037: ldloc.3
    IL_0038: nop
    IL_0039: nop
    IL_003A: stloc.0
    IL_003B: ldarg.0
    IL_003C: ldc.i4.1
    IL_0041: call 0x0A00001B
    IL_0046: call 0x060006A1
    IL_0047: ldarg.0
    IL_004C: ldfld 0x04000EC4
    IL_0051: call 0x0A00001B
    IL_0052: conv.r8
    IL_0053: ldloc.3
    IL_0054: nop
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: ret
    }

    public void ExploreIconFinish() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000EC3
    IL_000A: call 0x0A00001B
    IL_000B: conv.r8
    IL_000C: ldloc.3
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000EC5
    IL_001A: call 0x0A00001B
    IL_001B: conv.r8
    IL_001C: ldloc.3
    IL_001D: nop
    IL_001E: nop
    IL_001F: stloc.0
    IL_0020: ldarg.0
    IL_0021: ldc.i4.0
    IL_0026: stfld 0x04000E8E
    IL_0027: ldarg.0
    IL_0028: ldc.i4.0
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000EC3
    IL_002F: ldarg.0
    IL_0034: ldfld 0x04000E93
    IL_0035: conv.r8
    IL_003A: brtrue IL_6F0A003B
    IL_003B: ldc.i4.2
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_0043: call 0x060006A1
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000EC4
    IL_004E: call 0x0A00004B
    IL_004F: IL_22
    IL_0050: nop
    IL_0051: nop
    IL_0054: ldloc 10306
    IL_0055: ldloc.2
    IL_0056: nop
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: conv.r8
    IL_005A: ldloc.3
    IL_005B: nop
    IL_005C: nop
    IL_005D: stloc.0
    IL_005E: ret
    }

    public void AniFinish() {
    IL_0000: ldarg.1
    IL_0005: brfalse IL_002C
    IL_0006: ldarg.0
    IL_0007: IL_22
    IL_0008: nop
    IL_0009: nop
    IL_000A: IL_C0
    IL_000B: IL_3F
    IL_0010: call 0x060006A8
    IL_0011: ldarg.0
    IL_0012: ldc.i4.5
    IL_0017: stfld 0x04000E90
    IL_0018: ldarg.0
    IL_001A: ldc.i4.s 92
    IL_001C: ldc.i4.s 96
    IL_0021: call 0x0A000045
    IL_0026: stfld 0x04000EA4
    IL_002B: br IL_0033
    IL_002C: ldarg.0
    IL_002D: ldc.i4.7
    IL_0032: stfld 0x04000E90
    IL_0033: ret
    }

    public void SetStage() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000ECA
    IL_0006: ldc.i4.5
    IL_007F: switch (29 cases)
    IL_0084: call 0x0A0000E1
    IL_0089: stfld 0x04000E98
    IL_008A: ldarg.0
    IL_008B: ldc.i4.1
    IL_0090: stfld 0x04000E90
    IL_0095: br IL_018D
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000EBC
    IL_009C: ldarg.1
    IL_0165: switch (49 cases)
    IL_0166: IL_79
    IL_0168: ldarg.s 0
    IL_0169: ldarg.2
    IL_016E: ldfld 0x040007B5
    IL_016F: ldarg.0
    IL_0174: ldfld 0x04000EA8
    IL_0176: ldc.i4.s 63
    IL_017B: call 0x0A0000E1
    IL_0180: stfld 0x04000E98
    IL_0185: br IL_0186
    IL_0186: ldarg.0
    IL_0187: ldc.i4.1
    IL_018C: stfld 0x04000E7E
    IL_0191: br IL_01BE
    IL_0192: ldarg.0
    IL_0193: ldc.i4.1
    IL_0198: stfld 0x04000E8F
    IL_0199: ldarg.0
    IL_019E: ldfld 0x04000E62
    IL_019F: conv.r8
    IL_01A0: stloc.0
    IL_01A1: nop
    IL_01A2: nop
    IL_01A3: stloc.0
    IL_01A8: call 0x0A000050
    IL_01AD: ldstr 0x70022F5F
    IL_01AE: ldc.i4.1
    IL_01B3: call 0x0600021F
    IL_01B8: ldstr 0x70022F8F
    IL_01BD: call 0x0A000128
    IL_01BE: ret
    }

    public void GetGeneral() {
    IL_0004: ldstr 0x70001F55
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_000D: IL_58
    IL_000E: stloc.0
    IL_0013: ldstr 0x70001F55
    IL_0014: ldloc.0
    IL_0019: call 0x0600021F
    IL_001A: ldc.i4.0
    IL_001F: ldc.i4 1000
    IL_0024: call 0x0A000045
    IL_0025: stloc.1
    IL_0026: ldc.i4.0
    IL_0027: stloc.2
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000ECA
    IL_002E: ldc.i4.4
    IL_00BF: switch (35 cases)
    IL_00C0: nop
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: IL_3E
    IL_00C4: ldloc.1
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: ldc.i4.0
    IL_00C9: stloc.1
    IL_00CE: br IL_00D1
    IL_00CF: ldc.i4.0
    IL_00D0: ret
    IL_00D1: ldc.i4.0
    IL_00D3: ldc.i4.s 90
    IL_00D8: call 0x0A000045
    IL_00D9: stloc.3
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000EA5
    IL_00E0: ldc.i4.1
    IL_010D: switch (10 cases)
    IL_010E: ldc.i4.0
    IL_0113: ldc.i4 10000
    IL_0118: call 0x0A000045
    IL_0119: ldloc.1
    IL_011E: ldc.i4 10000
    IL_011F: IL_5A
    IL_0120: IL_58
    IL_0125: ldc.i4 10000000
    IL_0126: IL_58
    IL_0127: ldloc.3
    IL_0128: IL_58
    IL_0129: stloc.2
    IL_012A: ldc.i4.0
    IL_012C: stloc.s 4
    IL_0131: br IL_0176
    IL_0132: ldarg.0
    IL_0137: ldfld 0x04000EB7
    IL_0139: ldloc.s 4
    IL_013A: IL_94
    IL_013F: brtrue IL_0170
    IL_0140: ldarg.0
    IL_0142: ldloc.s 4
    IL_0147: stfld 0x04000E9B
    IL_0148: ldarg.0
    IL_014D: ldfld 0x04000EB7
    IL_014F: ldloc.s 4
    IL_0150: ldloc.2
    IL_0151: ldelem.i8
    IL_0156: ldstr 0x70001F15
    IL_0157: ldarg.0
    IL_015C: ldfld 0x04000EB7
    IL_0161: call 0x060003F8
    IL_0162: pop
    IL_0163: ldarg.0
    IL_0164: ldloc.2
    IL_0165: ldc.i4.0
    IL_016A: call 0x0600069E
    IL_016F: br IL_0183
    IL_0171: ldloc.s 4
    IL_0172: ldc.i4.1
    IL_0173: IL_58
    IL_0175: stloc.s 4
    IL_0177: ldloc.s 4
    IL_0178: ldarg.0
    IL_017D: ldfld 0x04000EA7
    IL_017E: IL_3F
    IL_017F: IL_AF
    IL_0180: IL_FF
    IL_0181: IL_FF
    IL_0182: IL_FF
    IL_0183: ldarg.0
    IL_0184: ldarg.0
    IL_0189: ldfld 0x04000E7B
    IL_018A: conv.r8
    IL_018B: IL_91
    IL_018C: ldarg.1
    IL_018D: nop
    IL_018E: ldloc.0
    IL_0193: stfld 0x04000E87
    IL_0194: ldc.i4.1
    IL_0195: ret
    }

    public void GetTreasure() {
    IL_0000: ldc.i4.0
    IL_0002: ldc.i4.s 100
    IL_0007: call 0x0A000045
    IL_0008: stloc.0
    IL_0009: ldloc.0
    IL_000B: ldc.i4.s 55
    IL_000C: IL_3C
    IL_000D: IL_95
    IL_000E: nop
    IL_000F: nop
    IL_0010: nop
    IL_0011: ldarg.0
    IL_0012: ldc.i4.1
    IL_0017: stfld 0x04000E92
    IL_0018: ldarg.0
    IL_0019: ldc.i4.0
    IL_001B: ldc.i4.s 24
    IL_0020: call 0x0A000045
    IL_0025: stfld 0x04000E9F
    IL_0026: ldarg.0
    IL_002B: ldstr 0x70001FC1
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000E9F
    IL_0032: ldc.i4.1
    IL_0033: IL_58
    IL_0034: stloc.2
    IL_0036: ldloca.s 2
    IL_003B: call 0x0A000010
    IL_0040: call 0x0A000011
    IL_0045: call 0x0A000012
    IL_0046: conv.u8
    IL_0047: IL_3C
    IL_0048: nop
    IL_0049: nop
    IL_004A: IL_01
    IL_004F: stfld 0x04000E38
    IL_0054: ldstr 0x70001FC1
    IL_0059: call 0x060003F9
    IL_005A: stloc.1
    IL_005B: ldloc.1
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000E9F
    IL_0062: IL_8F
    IL_0063: stloc.1
    IL_0064: nop
    IL_0065: nop
    IL_0066: IL_01
    IL_0067: dup
    IL_006A: stloc 22551
    IL_006B: IL_54
    IL_0070: ldstr 0x70001FC1
    IL_0071: ldloc.1
    IL_0076: call 0x060003F8
    IL_0077: pop
    IL_0078: ldarg.0
    IL_0079: ldc.i4.4
    IL_007E: stfld 0x04000E90
    IL_007F: ldarg.0
    IL_0084: ldfld 0x04000E61
    IL_0085: conv.r8
    IL_0086: stind.i
    IL_0087: nop
    IL_0088: nop
    IL_008A: br.s IL_00A5
    IL_008B: conv.r8
    IL_0090: stfld 0x02060002
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04000E7B
    IL_0097: conv.r8
    IL_0098: IL_92
    IL_0099: ldarg.1
    IL_009A: nop
    IL_009B: ldloc.0
    IL_00A0: stfld 0x04000E88
    IL_00A5: br IL_015D
    IL_00A6: ldloc.0
    IL_00A8: ldc.i4.s 57
    IL_00A9: IL_3C
    IL_00AC: ldarga 0
    IL_00AD: nop
    IL_00AE: ldarg.0
    IL_00AF: ldc.i4.2
    IL_00B4: stfld 0x04000E92
    IL_00B5: ldarg.0
    IL_00B6: ldc.i4.1
    IL_00BB: stfld 0x04000E9F
    IL_00BC: ldarg.0
    IL_00BD: dup
    IL_00C2: ldfld 0x04000EA1
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04000E9F
    IL_00C9: IL_58
    IL_00CE: stfld 0x04000EA1
    IL_00CF: ldc.i4.1
    IL_00D0: ldc.i4.1
    IL_00D5: call 0x0600021E
    IL_00D6: pop
    IL_00D7: ldarg.0
    IL_00D8: ldc.i4.4
    IL_00DD: stfld 0x04000E90
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x04000E61
    IL_00E4: conv.r8
    IL_00E5: stind.i
    IL_00E6: nop
    IL_00E7: nop
    IL_00E9: br.s IL_0104
    IL_00EA: conv.r8
    IL_00EF: stfld 0x38060002
    IL_00F0: not
    IL_00F1: nop
    IL_00F2: nop
    IL_00F3: nop
    IL_00F4: ldloc.0
    IL_00F6: ldc.i4.s 70
    IL_00F7: IL_3C
    IL_00FA: ldloca 0
    IL_00FB: nop
    IL_00FC: ldarg.0
    IL_00FD: ldc.i4.3
    IL_0102: stfld 0x04000E92
    IL_0103: ldarg.0
    IL_0104: ldc.i4.1
    IL_0109: stfld 0x04000E9F
    IL_010A: ldarg.0
    IL_010B: dup
    IL_0110: ldfld 0x04000EA3
    IL_0111: ldc.i4.1
    IL_0112: IL_58
    IL_0117: stfld 0x04000EA3
    IL_011C: ldstr 0x7000066F
    IL_011D: ldarg.0
    IL_0122: ldfld 0x04000EA3
    IL_0127: call 0x0600021F
    IL_0128: ldarg.0
    IL_0129: ldc.i4.4
    IL_012E: stfld 0x04000E90
    IL_012F: ldarg.0
    IL_0134: ldfld 0x04000E61
    IL_0135: conv.r8
    IL_0136: stind.i
    IL_0137: nop
    IL_0138: nop
    IL_013A: br.s IL_0155
    IL_013B: conv.r8
    IL_0140: stfld 0x38060002
    IL_0141: ldc.i4.2
    IL_0142: nop
    IL_0143: nop
    IL_0144: nop
    IL_0145: ldarg.0
    IL_0146: ldc.i4.8
    IL_014B: stfld 0x04000E90
    IL_014C: ldarg.0
    IL_0151: ldfld 0x04000E61
    IL_0152: conv.r8
    IL_0153: stloc.0
    IL_0154: nop
    IL_0155: nop
    IL_0156: stloc.0
    IL_0157: ldc.i4.0
    IL_0158: conv.r8
    IL_0159: stloc.1
    IL_015A: nop
    IL_015B: nop
    IL_015C: stloc.0
    IL_015D: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000EA9
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000EAA
    IL_000E: ret
    }

    public void ScenarioFinish() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000E8D
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000EBA
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000E8C
    IL_0014: ldc.i4.1
    IL_0049: switch (12 cases)
    IL_004A: nop
    IL_004B: stloc.0
    IL_0050: call 0x0A000007
    IL_0051: IL_22
    IL_0052: IL_EC
    IL_0053: IL_51
    IL_0054: IL_B8
    IL_0055: IL_3D
    IL_005A: call 0x0A000008
    IL_005F: call 0x0A000029
    IL_0064: stfld 0x04000E7D
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000EC3
    IL_006B: ldc.i4.0
    IL_006C: conv.r8
    IL_0071: brtrue IL_6F0A0072
    IL_0072: ldarg.1
    IL_0073: nop
    IL_0074: nop
    IL_0075: stloc.0
    IL_0076: ldc.i4.1
    IL_0077: conv.r8
    IL_0079: ldc.i4.s 0
    IL_007A: nop
    IL_007B: stloc.0
    IL_007C: ldarg.0
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04000E5B
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000E7D
    IL_008D: call 0x0A000007
    IL_008E: IL_22
    IL_008F: stloc.0
    IL_0090: IL_D7
    IL_0091: stelem.i
    IL_0092: IL_3D
    IL_0097: call 0x0A000008
    IL_009C: call 0x0A000019
    IL_00A1: call 0x0A000013
    IL_00A6: call 0x0A000014
    IL_00A7: conv.u4
    IL_00A8: ldarg.1
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: IL_01
    IL_00B0: stfld 0x04000E71
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000EC3
    IL_00B7: ldc.i4.0
    IL_00B8: conv.r8
    IL_00BD: brtrue IL_280A00BE
    IL_00BE: localloc
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: stloc.0
    IL_00C2: conv.r8
    IL_00C3: IL_AF
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: stloc.0
    IL_00C7: ldarg.0
    IL_00CC: ldfld 0x04000E78
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000EC3
    IL_00D3: ldc.i4.0
    IL_00D4: conv.r8
    IL_00D9: brtrue IL_160A00DA
    IL_00DA: conv.r8
    IL_00DB: ldc.i4.0
    IL_00DC: IL_01
    IL_00DD: nop
    IL_00DE: ldloc.0
    IL_00DF: ldarg.0
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04000E59
    IL_00E6: ldarg.0
    IL_00EB: ldfld 0x04000E7D
    IL_00EC: IL_22
    IL_00ED: nop
    IL_00EE: nop
    IL_00EF: nop
    IL_00F0: nop
    IL_00F1: IL_22
    IL_00F2: IL_CD
    IL_00F3: IL_CC
    IL_00F4: IL_CC
    IL_00F5: IL_BD
    IL_00F6: IL_22
    IL_00F7: ldelem.i
    IL_00F8: IL_99
    IL_00F9: IL_99
    IL_00FA: IL_BE
    IL_00FF: newobj 0x0A000076
    IL_0104: call 0x0A000029
    IL_0109: call 0x0A000013
    IL_010E: call 0x0A000014
    IL_010F: conv.u4
    IL_0110: ldarg.1
    IL_0111: nop
    IL_0112: nop
    IL_0113: IL_01
    IL_0118: stfld 0x04000E72
    IL_0119: ldarg.0
    IL_011A: ldc.i4.0
    IL_011F: stfld 0x04000E8A
    IL_0120: ldarg.0
    IL_0125: ldfld 0x04000E78
    IL_0126: conv.r8
    IL_0127: ldnull
    IL_0128: IL_01
    IL_0129: nop
    IL_012A: ldloc.0
    IL_012B: ldarg.0
    IL_012C: dup
    IL_0131: ldfld 0x04000E93
    IL_0132: ldc.i4.1
    IL_0133: IL_58
    IL_0138: stfld 0x04000E93
    IL_013D: ldstr 0x700004DD
    IL_013E: ldarg.0
    IL_0143: ldfld 0x04000E93
    IL_0148: call 0x0600021F
    IL_014D: ldstr 0x7000207D
    IL_014E: ldc.i4.0
    IL_0153: call 0x0600021F
    IL_0154: ldarg.0
    IL_0159: call 0x060006AB
    IL_015A: ldarg.0
    IL_015C: ldc.i4.s 14
    IL_0161: stfld 0x04000E91
    IL_0162: ldarg.0
    IL_0163: IL_22
    IL_0164: nop
    IL_0165: nop
    IL_0166: nop
    IL_1AA20B: switch (436264 cases)
    }

    private void SceneStart_Delay() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000EC6
    IL_0006: conv.r8
    IL_000B: newobj 0x022B0000
    IL_0010: ldfld 0x04000E93
    IL_0011: ldc.i4.1
    IL_0012: IL_58
    IL_0013: conv.r8
    IL_0014: IL_29
    IL_0015: ldarg.2
    IL_0016: nop
    IL_0017: ldloc.0
    IL_0018: ret
    }

    public void SetMenuOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000E93
    IL_0006: ldc.i4.7
    IL_0007: IL_3F
    IL_0009: stloc.s 0
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldarg.0
    IL_000D: ldc.i4.5
    IL_0012: stfld 0x04000EBE
    IL_0013: ldarg.0
    IL_0014: ldc.i4.0
    IL_0019: stfld 0x04000E86
    IL_001E: br IL_00C8
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000E93
    IL_0025: ldc.i4.6
    IL_0026: IL_3F
    IL_0028: stloc.s 0
    IL_0029: nop
    IL_002A: nop
    IL_002B: ldarg.0
    IL_002C: ldc.i4.5
    IL_0031: stfld 0x04000EBE
    IL_0032: ldarg.0
    IL_0033: ldc.i4.1
    IL_0038: stfld 0x04000E86
    IL_003D: br IL_00C8
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000E93
    IL_0044: ldc.i4.4
    IL_0045: IL_3F
    IL_0047: stloc.s 0
    IL_0048: nop
    IL_0049: nop
    IL_004A: ldarg.0
    IL_004B: ldc.i4.4
    IL_0050: stfld 0x04000EBE
    IL_0051: ldarg.0
    IL_0052: ldc.i4.0
    IL_0057: stfld 0x04000E86
    IL_005C: br IL_00C8
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000E93
    IL_0063: ldc.i4.3
    IL_0064: IL_3F
    IL_0066: stloc.s 0
    IL_0067: nop
    IL_0068: nop
    IL_0069: ldarg.0
    IL_006A: ldc.i4.4
    IL_006F: stfld 0x04000EBE
    IL_0070: ldarg.0
    IL_0071: ldc.i4.0
    IL_0076: stfld 0x04000E86
    IL_007B: br IL_00C8
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04000E93
    IL_0082: ldc.i4.2
    IL_0083: IL_3F
    IL_0085: stloc.s 0
    IL_0086: nop
    IL_0087: nop
    IL_0088: ldarg.0
    IL_0089: ldc.i4.3
    IL_008E: stfld 0x04000EBE
    IL_008F: ldarg.0
    IL_0090: ldc.i4.1
    IL_0095: stfld 0x04000E86
    IL_009A: br IL_00C8
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000E93
    IL_00A1: ldc.i4.1
    IL_00A2: IL_3F
    IL_00A4: stloc.s 0
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4.2
    IL_00AD: stfld 0x04000EBE
    IL_00AE: ldarg.0
    IL_00AF: ldc.i4.0
    IL_00B4: stfld 0x04000E86
    IL_00B9: br IL_00C8
    IL_00BA: ldarg.0
    IL_00BB: ldc.i4.1
    IL_00C0: stfld 0x04000EBE
    IL_00C1: ldarg.0
    IL_00C2: ldc.i4.0
    IL_00C7: stfld 0x04000E86
    IL_00C8: ret
    }

    private void Update() {
    IL_0004: ldstr 0x7000064F
    IL_0009: call 0x0A000095
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_00BD: switch (43 cases)
    IL_00BF: ldarg.s 0
    IL_00C0: ldarg.2
    IL_00C1: ldc.i4.0
    IL_00C2: IL_3E
    IL_00C3: IL_F8
    IL_00C4: ldarg.1
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: ldarg.0
    IL_00CC: ldfld 0x04000E9D
    IL_00CD: IL_22
    IL_00CE: nop
    IL_00CF: nop
    IL_00D4: stsfld 0x0017413F
    IL_00D5: nop
    IL_00D6: nop
    IL_00D7: ldarg.0
    IL_00D8: dup
    IL_00DD: ldfld 0x04000E9D
    IL_00E2: call 0x0A000024
    IL_00E3: IL_58
    IL_00E8: stfld 0x04000E9D
    IL_00ED: br IL_0108
    IL_00EE: ldarg.0
    IL_00EF: IL_22
    IL_00F0: nop
    IL_00F1: nop
    IL_00F2: nop
    IL_00F3: nop
    IL_00F8: stfld 0x04000E9D
    IL_00F9: ldarg.0
    IL_00FA: dup
    IL_00FF: ldfld 0x04000E8A
    IL_0100: ldc.i4.1
    IL_0101: IL_58
    IL_0102: neg
    IL_0107: stfld 0x04000E8A
    IL_0108: ldarg.0
    IL_010D: ldfld 0x04000E8A
    IL_010E: ldc.i4.2
    IL_07FF: switch (443 cases)
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000EA0
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000EA0
    IL_0010: ret
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000ECC
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000ECC
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000ECC
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000E78
    IL_0047: conv.r8
    IL_0049: stloc.s 1
    IL_004A: nop
    IL_004B: ldloc.0
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000E60
    IL_0056: call 0x0A00001B
    IL_0057: conv.r8
    IL_0058: IL_AF
    IL_0059: nop
    IL_005A: nop
    IL_005B: stloc.0
    IL_005C: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000E8D
    IL_000A: brfalse IL_000C
    IL_000B: ret
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000E8A
    IL_0012: ldc.i4.0
    IL_0013: IL_3E
    IL_0014: IL_01
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ret
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000E25
    IL_0023: call 0x0A0000DF
    IL_0028: call 0x0A00001B
    IL_002D: call 0x0A000013
    IL_0032: call 0x0A0000D9
    IL_0033: conv.i2
    IL_0034: IL_22
    IL_0035: nop
    IL_0036: nop
    IL_003B: cpobj 0xDA285B44
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: conv.i2
    IL_0040: IL_22
    IL_0041: nop
    IL_0042: nop
    IL_0047: ldc.i4 2251588
    IL_0048: nop
    IL_004D: stsfld 0x0076733F
    IL_004E: nop
    IL_004F: stloc.0
    IL_0054: call 0x0A0000DD
    IL_0059: call 0x0A0000DE
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000E89
    IL_0060: ldc.i4.0
    IL_0061: IL_3E
    IL_0062: IL_01
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_0066: ret
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000E91
    IL_006D: ldc.i4.0
    IL_006E: IL_3E
    IL_006F: stloc.3
    IL_0070: nop
    IL_0071: nop
    IL_0072: nop
    IL_0073: ldarg.0
    IL_0074: ldc.i4.0
    IL_0079: stfld 0x04000E7F
    IL_007A: ldc.i4.0
    IL_007F: call 0x0A0001B9
    IL_0080: IL_22
    IL_0081: nop
    IL_0082: nop
    IL_0083: IL_E0
    IL_0084: IL_42
    IL_0085: IL_22
    IL_0086: nop
    IL_0087: nop
    IL_0088: nop
    IL_0089: nop
    IL_008A: IL_22
    IL_008B: nop
    IL_008C: nop
    IL_0091: stsfld 0x00002243
    IL_0092: nop
    IL_0093: IL_42
    IL_0098: call 0x0600021D
    IL_0099: ldarg.0
    IL_009E: ldfld 0x04000E46
    IL_00A3: call 0x0A0000E0
    IL_00A4: IL_22
    IL_00A5: nop
    IL_00A6: nop
    IL_00A8: ldloca.s 67
    IL_00A9: IL_22
    IL_00AA: nop
    IL_00AB: nop
    IL_00AC: IL_C0
    IL_280000139: switch (2684354594 cases)
    }

    public void BattleStart() {
    IL_0004: ldstr 0x70000B7F
    IL_0005: ldarg.0
    IL_000A: ldfld 0x04000E76
    IL_000B: conv.r8
    IL_000C: ldc.i4.2
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0014: call 0x060003F3
    IL_0015: pop
    IL_0016: ldc.i4.1
    IL_001B: call 0x0600056B
    IL_0020: ldstr 0x70000CDD
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04000E95
    IL_002B: call 0x0600021F
    IL_0030: ldstr 0x7000174B
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000E99
    IL_003B: call 0x0600021F
    IL_0040: ldstr 0x70001F45
    IL_0041: ldc.i4.m1
    IL_0046: call 0x0600021F
    IL_004B: ldstr 0x70000BDB
    IL_004C: ldarg.0
    IL_0051: ldfld 0x04000EC9
    IL_0056: call 0x0600021F
    IL_0057: ldarg.0
    IL_005C: ldfld 0x04000E75
    IL_005D: conv.r8
    IL_005E: stloc.0
    IL_005F: nop
    IL_0060: nop
    IL_0061: stloc.0
    IL_0066: call 0x0A000050
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04000E62
    IL_006D: conv.r8
    IL_006E: stloc.0
    IL_006F: nop
    IL_0070: nop
    IL_0071: stloc.0
    IL_0076: call 0x0A000050
    IL_0077: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000EDC
    IL_000C: ldarg.0
    IL_000D: ldc.i4.4
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000EDD
    IL_0018: ldarg.0
    IL_0019: ldc.i4.8
    IL_001E: newarr 0x0100003C
    IL_0023: stfld 0x04000EDE
    IL_0024: ldarg.0
    IL_0025: ldc.i4.3
    IL_002A: newarr 0x0100003C
    IL_002F: stfld 0x04000EEE
    IL_0030: ldarg.0
    IL_0031: ldc.i4.2
    IL_0033: ldc.i4.s 10
    IL_0038: newobj 0x0A000169
    IL_003D: stfld 0x04000EF5
    IL_003E: ldarg.0
    IL_003F: ldc.i4.2
    IL_0044: newarr 0x01000003
    IL_0049: stfld 0x04000F00
    IL_004A: ldarg.0
    IL_004B: ldc.i4.2
    IL_0050: newarr 0x0100000B
    IL_0055: stfld 0x04000F02
    IL_0056: ldarg.0
    IL_0057: ldc.i4.2
    IL_005C: newarr 0x0100000B
    IL_0061: stfld 0x04000F03
    IL_0062: ldarg.0
    IL_0063: ldc.i4.2
    IL_0068: newarr 0x0100000B
    IL_006D: stfld 0x04000F04
    IL_006E: ldarg.0
    IL_006F: ldc.i4.1
    IL_0074: stfld 0x04000F0F
    IL_0075: ldarg.0
    IL_007A: ldsfld 0x0A000099
    IL_007F: stfld 0x04000F13
    IL_0080: ldarg.0
    IL_0085: ldsfld 0x0A000099
    IL_008A: stfld 0x04000F14
    IL_008B: ldarg.0
    IL_0090: call 0x0A000001
    IL_0091: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000EFC
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000EFD
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70023247
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F0F
    IL_0010: ldarg.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04000F0F
    IL_0017: ldc.i4.1
    IL_0018: IL_59
    IL_0019: ldc.i4.8
    IL_001A: add
    IL_001F: stfld 0x04000F0F
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000BB3
    IL_002A: call 0x0A000095
    IL_002F: stfld 0x04000F01
    IL_0030: ldarg.0
    IL_0031: ldarg.0
    IL_0036: call 0x2B00008D
    IL_003B: ldfld 0x040004F3
    IL_0040: stfld 0x04000EF5
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: call 0x2B000001
    IL_004C: stfld 0x04000EF1
    IL_004D: ldarg.0
    IL_0052: ldstr 0x7000000F
    IL_0057: call 0x06000220
    IL_005C: stfld 0x04000F10
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04000F10
    IL_0067: brfalse IL_0082
    IL_0068: ldarg.0
    IL_0069: ldarg.0
    IL_006E: ldfld 0x04000F10
    IL_0073: stfld 0x04000F11
    IL_0074: ldarg.0
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000F11
    IL_007B: ldc.i4.1
    IL_007C: IL_59
    IL_0081: call 0x060006B6
    IL_0082: ldarg.0
    IL_0087: ldc.i4 -380
    IL_008C: stfld 0x04000EF6
    IL_008D: ldarg.0
    IL_0092: ldc.i4 480
    IL_0097: stfld 0x04000EF7
    IL_0098: ldarg.0
    IL_009D: ldc.i4 340
    IL_00A2: stfld 0x04000EF8
    IL_00A3: ldarg.0
    IL_00A5: ldc.i4.s 20
    IL_00AA: stfld 0x04000EFE
    IL_00AB: ldarg.0
    IL_00B0: call 0x0A0000DA
    IL_00B1: conv.i2
    IL_00B2: IL_22
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: IL_C0
    IL_00B6: IL_3E
    IL_00B7: IL_5A
    IL_00BC: stfld 0x04000F0D
    IL_00BD: ldarg.0
    IL_00C2: ldstr 0x70001EFD
    IL_00C7: call 0x060003F9
    IL_00CC: stfld 0x04000F02
    IL_00CD: ldarg.0
    IL_00D2: ldstr 0x70001F05
    IL_00D7: call 0x060003F9
    IL_00DC: stfld 0x04000F03
    IL_00DD: ldarg.0
    IL_00E2: ldstr 0x70001F0D
    IL_00E7: call 0x060003F9
    IL_00EC: stfld 0x04000F04
    IL_00ED: ldc.i4.0
    IL_00EE: stloc.0
    IL_00F3: br IL_010D
    IL_00F4: ldarg.0
    IL_00F9: ldfld 0x04000F04
    IL_00FA: ldloc.0
    IL_00FB: IL_94
    IL_00FC: ldc.i4.0
    IL_00FD: IL_3D
    IL_00FE: ldloc.1
    IL_00FF: nop
    IL_0100: nop
    IL_0101: nop
    IL_0102: ldarg.0
    IL_0103: ldc.i4.1
    IL_0108: stfld 0x04000F07
    IL_0109: ldloc.0
    IL_010A: ldc.i4.1
    IL_010B: IL_58
    IL_010C: stloc.0
    IL_010D: ldloc.0
    IL_010E: ldc.i4.2
    IL_010F: IL_3F
    IL_0110: IL_E0
    IL_0111: IL_FF
    IL_0112: IL_FF
    IL_0113: IL_FF
    IL_0114: ldarg.0
    IL_0119: ldstr 0x70023285
    IL_011A: IL_22
    IL_011B: nop
    IL_011C: nop
    IL_011D: nop
    IL_011E: IL_3F
    IL_011F: IL_22
    IL_0124: ldfld 0x283EAE14
    IL_0125: ldc.i4.1
    IL_0126: nop
    IL_0127: nop
    IL_0128: stloc.0
    IL_0129: ldarg.0
    IL_012E: ldstr 0x70000121
    IL_0133: call 0x0A000004
    IL_0138: stfld 0x04000EF3
    IL_0139: ldarg.0
    IL_013E: ldfld 0x04000EF3
    IL_013F: ldnull
    IL_0144: call 0x0A000021
    IL_0149: brfalse IL_015B
    IL_014A: ldarg.0
    IL_014B: ldarg.0
    IL_0150: ldfld 0x04000EF3
    IL_0151: conv.r8
    IL_0152: IL_84
    IL_0153: nop
    IL_0154: nop
    IL_0156: br.s IL_01D4
    IL_0157: IL_F4
    IL_0159: ldarg.s 0
    IL_015A: ldarg.2
    IL_015B: ldarg.0
    IL_0160: ldstr 0x70022F5F
    IL_0165: call 0x06000220
    IL_016A: stfld 0x04000F08
    IL_016F: ldstr 0x70000617
    IL_0170: ldc.i4.7
    IL_0175: call 0x0A00009F
    IL_0176: ret
    }

    private void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000EFB
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000EFB
    IL_0010: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F05
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000F06
    IL_000E: ret
    }

    private void SetAngel() {
    IL_0000: ldarg.0
    IL_0005: ldsfld 0x040007B2
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000F01
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000EF1
    IL_0016: ldfld 0x04000521
    IL_0017: ldarg.1
    IL_0018: IL_8F
    IL_0019: conv.i8
    IL_001A: nop
    IL_001B: nop
    IL_001C: ldarg.0
    IL_0021: ldfld 0x0400051B
    IL_0026: call 0x0A0000E1
    IL_002B: stfld 0x04000F13
    IL_002C: ldarg.0
    IL_0031: ldsfld 0x040007B2
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000F01
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000EF1
    IL_0042: ldfld 0x04000521
    IL_0043: ldarg.1
    IL_0044: IL_8F
    IL_0045: conv.i8
    IL_0046: nop
    IL_0047: nop
    IL_0048: ldarg.0
    IL_004D: ldfld 0x0400051C
    IL_0052: call 0x0A0000E1
    IL_0057: stfld 0x04000F14
    IL_0058: ldarg.0
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_0060: ldc.i4 -243596735
    IL_0062: ldarg.s 0
    IL_0063: ldarg.2
    IL_0068: ldfld 0x04000521
    IL_0069: ldarg.1
    IL_006A: IL_8F
    IL_006B: conv.i8
    IL_006C: nop
    IL_006D: nop
    IL_006E: ldarg.0
    IL_0073: ldfld 0x0400051D
    IL_0074: IL_59
    IL_0079: stfld 0x04000F12
    IL_007A: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F05
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000F06
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000F06
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000F06
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_42
    IL_002A: ldloca.s 0
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000F05
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000F06
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000EF6
    IL_0046: ldc.i4.s -64
    IL_0047: IL_3C
    IL_0049: brfalse.s IL_004A
    IL_004A: nop
    IL_004B: nop
    IL_004C: ldarg.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000EF6
    IL_0053: conv.i2
    IL_0054: ldarg.0
    IL_0059: ldfld 0x04000EF6
    IL_005A: shl
    IL_005B: conv.i2
    IL_0060: call 0x0A000024
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0064: ldc.i4.0
    IL_0065: IL_44
    IL_0066: IL_5A
    IL_006B: call 0x0A000114
    IL_006C: IL_58
    IL_006D: not
    IL_0072: stfld 0x04000EF6
    IL_0077: br IL_0080
    IL_0078: ldarg.0
    IL_007A: ldc.i4.s -64
    IL_007F: stfld 0x04000EF6
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000EFF
    IL_0086: ldc.i4.0
    IL_0087: IL_3E
    IL_008C: ldsflda 0x02000000
    IL_008D: ldarg.0
    IL_0092: ldfld 0x04000EF7
    IL_0093: conv.i2
    IL_0094: ldarg.0
    IL_0099: ldfld 0x04000EF7
    IL_009A: conv.i2
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00AC: not
    IL_00B1: stfld 0x04000EF7
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x04000EF7
    IL_00B8: ldc.i4.0
    IL_00B9: IL_3D
    IL_00BC: ldloc 0
    IL_00BD: nop
    IL_00BE: ldarg.0
    IL_00BF: ldc.i4.0
    IL_00C4: stfld 0x04000EF7
    IL_00C5: ldarg.0
    IL_00C6: ldarg.0
    IL_00CB: ldfld 0x04000EF8
    IL_00CC: conv.i2
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000EF8
    IL_00D3: conv.i2
    IL_00D8: call 0x0A000024
    IL_00D9: IL_22
    IL_00DA: nop
    IL_00DB: nop
    IL_00DC: IL_FA
    IL_00DD: IL_43
    IL_00DE: IL_5A
    IL_00E3: call 0x0A000114
    IL_00E4: IL_59
    IL_00E5: not
    IL_00EA: stfld 0x04000EF8
    IL_00EB: ldarg.0
    IL_00F0: ldfld 0x04000EF8
    IL_00F5: ldc.i4 230
    IL_00F6: IL_3D
    IL_00F7: stloc.1
    IL_00F8: nop
    IL_00F9: nop
    IL_00FA: nop
    IL_00FB: ldarg.0
    IL_0100: ldc.i4 230
    IL_0105: stfld 0x04000EF8
    IL_010A: br IL_0121
    IL_010B: ldarg.0
    IL_0110: ldc.i4 480
    IL_0115: stfld 0x04000EF7
    IL_0116: ldarg.0
    IL_011B: ldc.i4 340
    IL_0120: stfld 0x04000EF8
    IL_0121: ldc.i4.0
    IL_0126: call 0x0A0000D6
    IL_012B: brfalse IL_016F
    IL_0130: call 0x0A0000D7
    IL_0131: stloc.1
    IL_0133: ldloca.s 1
    IL_0138: ldfld 0x0A000023
    IL_0139: ldarg.0
    IL_013E: ldfld 0x04000F0D
    IL_013F: IL_41
    IL_0140: pop
    IL_0141: nop
    IL_0142: nop
    IL_0143: nop
    IL_0144: ldarg.0
    IL_0145: ldc.i4.1
    IL_014A: stfld 0x04000F09
    IL_014B: ldarg.0
    IL_0150: call 0x0A0000D7
    IL_0151: stloc.2
    IL_0153: ldloca.s 2
    IL_0158: ldfld 0x0A00005E
    IL_015D: stfld 0x04000F0B
    IL_015E: ldarg.0
    IL_015F: ldarg.0
    IL_0164: ldfld 0x04000F0E
    IL_0169: stfld 0x04000F0C
    IL_016E: br IL_0188
    IL_016F: ldc.i4.0
    IL_0174: call 0x0A0000D8
    IL_0179: brfalse IL_0188
    IL_017A: ldarg.0
    IL_017B: ldc.i4.0
    IL_0180: stfld 0x04000F09
    IL_0181: ldarg.0
    IL_0182: ldc.i4.0
    IL_0187: stfld 0x04000F0A
    IL_0188: ldarg.0
    IL_018D: ldfld 0x04000F09
    IL_0192: brfalse IL_0218
    IL_0197: call 0x0A0000D7
    IL_0198: stloc.3
    IL_019A: ldloca.s 3
    IL_019F: ldfld 0x0A00005E
    IL_01A0: ldarg.0
    IL_01A5: ldfld 0x04000F0B
    IL_01A6: IL_59
    IL_01AB: call 0x0A00007F
    IL_01AC: IL_22
    IL_01AD: nop
    IL_01AE: nop
    IL_01AF: nop
    IL_01B0: IL_41
    IL_01B1: IL_43
    IL_01B2: ldloc.1
    IL_01B3: nop
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: ldarg.0
    IL_01B7: ldc.i4.1
    IL_01BC: stfld 0x04000F0A
    IL_01BD: ldarg.0
    IL_01C2: call 0x0A0000D7
    IL_01C4: stloc.s 4
    IL_01C6: ldloca.s 4
    IL_01CB: ldfld 0x0A00005E
    IL_01CC: ldarg.0
    IL_01D1: ldfld 0x04000F0B
    IL_01D2: IL_59
    IL_01D3: IL_22
    IL_01D4: nop
    IL_01D5: nop
    IL_01D6: IL_F0
    IL_01D7: IL_43
    IL_01DC: call 0x0A0000D9
    IL_01DD: conv.i2
    IL_01DE: add
    IL_01DF: IL_5A
    IL_01E0: ldarg.0
    IL_01E5: ldfld 0x04000F0C
    IL_01E6: IL_58
    IL_01EB: stfld 0x04000F0E
    IL_01EC: ldarg.0
    IL_01ED: ldarg.0
    IL_01F2: ldfld 0x04000F0E
    IL_01F3: IL_22
    IL_01F4: nop
    IL_01F5: nop
    IL_01F6: nop
    IL_01F7: nop
    IL_01FC: call 0x0A000114
    IL_0201: stfld 0x04000F0E
    IL_0202: ldarg.0
    IL_0203: ldarg.0
    IL_0208: ldfld 0x04000F0E
    IL_0209: IL_22
    IL_020A: nop
    IL_020B: nop
    IL_020C: ldc.i4.0
    IL_020D: IL_C3
    IL_0212: call 0x0A00019C
    IL_0217: stfld 0x04000F0E
    IL_021C: ldstr 0x7000064F
    IL_0221: call 0x0A000095
    IL_0222: stloc.0
    IL_0223: ldloc.0
    IL_0224: ldc.i4.1
    IL_02D5: switch (43 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000EF2
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000EF2
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000EF2
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000EEF
    IL_0040: call 0x0A0000DF
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000EF6
    IL_0047: conv.i2
    IL_0048: IL_22
    IL_0049: nop
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: IL_22
    IL_004E: nop
    IL_004F: nop
    IL_0050: ldelem.r8
    IL_0051: IL_43
    IL_0052: IL_22
    IL_0053: nop
    IL_0054: nop
    IL_0055: ldelem.r8
    IL_0056: IL_43
    IL_005B: call 0x0600021D
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000ED5
    IL_0066: call 0x0A0000E0
    IL_0067: IL_22
    IL_0068: nop
    IL_0069: nop
    IL_006A: IL_FC
    IL_006B: IL_42
    IL_006C: IL_22
    IL_006D: nop
    IL_006E: nop
    IL_006F: IL_F0
    IL_0070: IL_41
    IL_0071: IL_22
    IL_0072: nop
    IL_0073: nop
    IL_0074: IL_C8
    IL_0075: IL_42
    IL_0076: IL_22
    IL_0077: nop
    IL_0078: nop
    IL_007B: ldloc 10306
    IL_007C: ldc.i4.7
    IL_007D: ldarg.0
    IL_007E: nop
    IL_007F: ldloc.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000ED6
    IL_008A: call 0x0A0000E0
    IL_008B: IL_22
    IL_008C: nop
    IL_008D: nop
    IL_008E: IL_58
    IL_008F: IL_43
    IL_0090: IL_22
    IL_0091: nop
    IL_0092: nop
    IL_0093: IL_50
    IL_0094: IL_42
    IL_0095: IL_22
    IL_0096: nop
    IL_0097: nop
    IL_0098: ldelem.r8
    IL_0099: IL_42
    IL_009A: IL_22
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_C0
    IL_009E: IL_41
    IL_00A3: call 0x0600021D
    IL_00A8: ldsfld 0x040007B2
    IL_00A9: ldarg.0
    IL_00AE: ldfld 0x04000F01
    IL_00B0: ldc.i4.s 74
    IL_00B5: call 0x0A0000E1
    IL_00BA: call 0x0A0002EA
    IL_00BB: IL_22
    IL_00BC: nop
    IL_00BD: nop
    IL_00BE: IL_E0
    IL_00BF: IL_42
    IL_00C0: IL_22
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00CC: stsfld 0x00002243
    IL_00CD: nop
    IL_00CE: IL_42
    IL_00D3: call 0x0600021D
    IL_00D4: ldarg.0
    IL_00D9: ldfld 0x04000EE4
    IL_00DE: call 0x0A0000E0
    IL_00DF: IL_22
    IL_00E0: nop
    IL_00E1: nop
    IL_00E3: ldloca.s 67
    IL_00E4: IL_22
    IL_00E5: nop
    IL_00E6: nop
    IL_00E7: IL_C0
    IL_280000174: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F17
    IL_0007: ldarg.0
    IL_0008: ldc.i4.5
    IL_000D: newarr 0x0100003C
    IL_0012: stfld 0x04000F33
    IL_0013: ldarg.0
    IL_0014: ldc.i4.3
    IL_0019: newarr 0x0100003C
    IL_001E: stfld 0x04000F34
    IL_001F: ldarg.0
    IL_0020: ldc.i4.3
    IL_0025: newarr 0x0100002F
    IL_0026: dup
    IL_0027: ldc.i4.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_96
    IL_002C: IL_43
    IL_002D: ldelem.r8
    IL_002E: dup
    IL_002F: ldc.i4.1
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0033: IL_96
    IL_0034: IL_43
    IL_0035: ldelem.r8
    IL_0036: dup
    IL_0037: ldc.i4.2
    IL_0038: IL_22
    IL_0039: nop
    IL_003A: nop
    IL_003B: IL_96
    IL_003C: IL_43
    IL_003D: ldelem.r8
    IL_0042: stfld 0x04000F38
    IL_0043: ldarg.0
    IL_0044: IL_22
    IL_0045: nop
    IL_0046: nop
    IL_0047: throw
    IL_0048: IL_44
    IL_004D: stfld 0x04000F39
    IL_004E: ldarg.0
    IL_004F: ldc.i4.3
    IL_0054: newarr 0x01000010
    IL_0059: stfld 0x04000F41
    IL_005A: ldarg.0
    IL_005B: ldc.i4.3
    IL_0060: newarr 0x01000010
    IL_0065: stfld 0x04000F42
    IL_0066: ldarg.0
    IL_0067: ldc.i4.3
    IL_006C: newarr 0x01000013
    IL_0071: stfld 0x04000F43
    IL_0072: ldarg.0
    IL_0073: ldc.i4.6
    IL_0078: newarr 0x0100000B
    IL_007D: stfld 0x04000F44
    IL_007E: ldarg.0
    IL_0083: call 0x0A000001
    IL_0084: ret
    }

    private void Awake() {
    IL_0004: ldstr 0x700236B1
    IL_0009: call 0x06000220
    IL_000A: stloc.0
    IL_000B: ldarg.0
    IL_0010: ldstr 0x70001ED5
    IL_0015: call 0x06000220
    IL_001A: stfld 0x04000F48
    IL_001B: ldarg.0
    IL_001C: ldloc.0
    IL_0021: ldc.i4 1000
    IL_0022: add
    IL_0023: neg
    IL_0028: stfld 0x04000F19
    IL_0029: ldarg.0
    IL_002A: ldloc.0
    IL_002F: ldc.i4 1000
    IL_0030: mul
    IL_0035: stfld 0x04000F1A
    IL_0036: ldc.i4.0
    IL_0037: stloc.1
    IL_003C: br IL_0062
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04000F41
    IL_0043: ldloc.1
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000F1A
    IL_004B: ldc.i4.s 10
    IL_004C: mul
    IL_004D: neg
    IL_004E: ldelem.i4
    IL_004F: ldarg.0
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000F1A
    IL_0057: ldc.i4.s 10
    IL_0058: add
    IL_005D: stfld 0x04000F1A
    IL_005E: ldloc.1
    IL_005F: ldc.i4.1
    IL_0060: IL_58
    IL_0061: stloc.1
    IL_0062: ldloc.1
    IL_0063: ldc.i4.3
    IL_0064: IL_3F
    IL_0065: IL_D4
    IL_0066: IL_FF
    IL_0067: IL_FF
    IL_0068: IL_FF
    IL_006D: ldstr 0x70001EDD
    IL_0072: call 0x060003F9
    IL_0073: stloc.2
    IL_0074: ldarg.0
    IL_0079: ldstr 0x70000CDD
    IL_007E: call 0x06000220
    IL_0083: stfld 0x04000F1B
    IL_0084: ldarg.0
    IL_0089: ldstr 0x700004DD
    IL_008E: call 0x06000220
    IL_0093: stfld 0x04000F1C
    IL_0094: ldc.i4.0
    IL_0095: stloc.3
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04000F1C
    IL_009C: ldc.i4.5
    IL_009D: IL_3C
    IL_009F: ldarga.s 0
    IL_00A0: nop
    IL_00A1: nop
    IL_00A6: ldstr 0x70024190
    IL_00AB: call 0x0A000077
    IL_00B0: call 0x0A000050
    IL_00B1: ldloc.2
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x04000F1B
    IL_00B8: IL_94
    IL_00B9: stloc.3
    IL_00BA: ldc.i4.0
    IL_00BC: stloc.s 4
    IL_00C1: br IL_00DB
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x04000F42
    IL_00C9: ldloc.s 4
    IL_00CA: ldloc.3
    IL_00CC: ldc.i4.s 10
    IL_00CD: mul
    IL_00CE: neg
    IL_00CF: ldelem.i4
    IL_00D0: ldloc.3
    IL_00D2: ldc.i4.s 10
    IL_00D3: add
    IL_00D4: stloc.3
    IL_00D6: ldloc.s 4
    IL_00D7: ldc.i4.1
    IL_00D8: IL_58
    IL_00DA: stloc.s 4
    IL_00DC: ldloc.s 4
    IL_00DD: ldc.i4.3
    IL_00DE: IL_3F
    IL_00DF: IL_DF
    IL_00E0: IL_FF
    IL_00E1: IL_FF
    IL_00E2: IL_FF
    IL_00E3: ldc.i4.0
    IL_00E5: stloc.s 5
    IL_00E6: ldarg.0
    IL_00EB: ldfld 0x04000F42
    IL_00EC: ldc.i4.2
    IL_00ED: IL_92
    IL_00EE: ldarg.0
    IL_00F3: ldfld 0x04000F41
    IL_00F4: ldc.i4.2
    IL_00F5: IL_92
    IL_00F6: IL_58
    IL_00F7: ldc.i4.0
    IL_00F8: IL_3E
    IL_00F9: ldloc.1
    IL_00FA: nop
    IL_00FB: nop
    IL_00FC: nop
    IL_00FE: ldloc.s 5
    IL_0100: ldc.i4.s 100
    IL_0101: IL_58
    IL_0103: stloc.s 5
    IL_0104: ldarg.0
    IL_0109: ldfld 0x04000F42
    IL_010A: ldc.i4.1
    IL_010B: IL_92
    IL_010C: ldarg.0
    IL_0111: ldfld 0x04000F41
    IL_0112: ldc.i4.1
    IL_0113: IL_92
    IL_0114: IL_58
    IL_0115: ldc.i4.0
    IL_0116: IL_3E
    IL_0117: ldloc.1
    IL_0118: nop
    IL_0119: nop
    IL_011A: nop
    IL_011C: ldloc.s 5
    IL_011E: ldc.i4.s 10
    IL_011F: IL_58
    IL_0121: stloc.s 5
    IL_0122: ldarg.0
    IL_0127: ldfld 0x04000F42
    IL_0128: ldc.i4.0
    IL_0129: IL_92
    IL_012A: ldarg.0
    IL_012F: ldfld 0x04000F41
    IL_0130: ldc.i4.0
    IL_0131: IL_92
    IL_0132: IL_58
    IL_0133: ldc.i4.0
    IL_0134: IL_3E
    IL_0135: ldloc.0
    IL_0136: nop
    IL_0137: nop
    IL_0138: nop
    IL_013A: ldloc.s 5
    IL_013B: ldc.i4.1
    IL_013C: IL_58
    IL_013E: stloc.s 5
    IL_013F: ldloc.2
    IL_0140: ldarg.0
    IL_0145: ldfld 0x04000F1B
    IL_0147: ldloc.s 5
    IL_0148: ldelem.i8
    IL_014D: ldstr 0x70001EDD
    IL_014E: ldloc.2
    IL_0153: call 0x060003F8
    IL_0154: pop
    IL_0155: IL_22
    IL_0156: nop
    IL_0157: nop
    IL_015C: stsfld 0x0111283F
    IL_015D: nop
    IL_015E: stloc.0
    IL_015F: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F1D
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F1F
    IL_0020: ldarg.0
    IL_0025: ldfld 0x04000F37
    IL_0026: conv.r8
    IL_0027: stloc.0
    IL_0028: nop
    IL_0029: nop
    IL_002A: stloc.0
    IL_002B: conv.r8
    IL_002C: len
    IL_002D: nop
    IL_002E: nop
    IL_0030: br.s IL_00A0
    IL_0031: rem
    IL_0032: ldarg.1
    IL_0033: nop
    IL_0034: ldloc.0
    IL_0035: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000F25
    IL_0010: ldarg.0
    IL_0015: call 0x0A00002B
    IL_001A: ldstr 0x70022774
    IL_001F: call 0x0A0001C1
    IL_0020: conv.r8
    IL_0021: IL_C9
    IL_0022: IL_01
    IL_0023: nop
    IL_0024: stloc.0
    IL_0029: ldstr 0x7002270C
    IL_002E: call 0x0A0001C1
    IL_0033: call 0x0A0001C2
    IL_0034: ldarg.0
    IL_0039: ldstr 0x70023257
    IL_003E: call 0x06000220
    IL_0043: stfld 0x04000F20
    IL_0044: ldarg.0
    IL_0049: ldstr 0x7002325F
    IL_004E: call 0x06000220
    IL_0053: stfld 0x04000F1E
    IL_0058: ldstr 0x70023257
    IL_0059: ldc.i4.0
    IL_005E: call 0x0600021F
    IL_0063: ldstr 0x7002325F
    IL_0064: ldc.i4.0
    IL_0069: call 0x0600021F
    IL_006A: ldarg.0
    IL_006B: dup
    IL_0070: ldfld 0x04000F1D
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000F1E
    IL_0077: IL_59
    IL_007C: stfld 0x04000F1D
    IL_007D: ldarg.0
    IL_007E: dup
    IL_0083: ldfld 0x04000F1F
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04000F20
    IL_008A: IL_59
    IL_008F: stfld 0x04000F1F
    IL_0090: ldarg.0
    IL_0095: ldstr 0x70000DDD
    IL_009A: call 0x06000220
    IL_009F: stfld 0x04000F23
    IL_00A0: ldarg.0
    IL_00A5: ldstr 0x70000DE5
    IL_00AA: call 0x06000220
    IL_00AF: stfld 0x04000F24
    IL_00B0: ldarg.0
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000F24
    IL_00B7: conv.i2
    IL_00BC: stfld 0x04000F27
    IL_00BD: ldarg.0
    IL_00C2: ldfld 0x04000F23
    IL_00C4: ldc.i4.s 19
    IL_00C5: IL_3C
    IL_00C6: IL_3D
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: nop
    IL_00CA: ldarg.0
    IL_00CF: ldstr 0x70002065
    IL_00D4: call 0x06000220
    IL_00D9: stfld 0x04000F3D
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000F3D
    IL_00E0: ldc.i4.1
    IL_014D: switch (26 cases)
    IL_014E: IL_F9
    IL_014F: ldarg.1
    IL_0150: nop
    IL_0151: ldloc.0
    IL_0156: stfld 0x04000F44
    IL_0157: ldc.i4.0
    IL_0158: stloc.0
    IL_0159: ldc.i4.0
    IL_015A: stloc.1
    IL_015F: br IL_0181
    IL_0160: ldarg.0
    IL_0165: ldfld 0x04000F44
    IL_0166: ldloc.1
    IL_0167: IL_94
    IL_0169: ldc.i4.s 10
    IL_016A: IL_3F
    IL_016B: ldloc.3
    IL_016C: nop
    IL_016D: nop
    IL_016E: nop
    IL_016F: ldloc.0
    IL_0170: ldc.i4.1
    IL_0171: IL_58
    IL_0172: stloc.0
    IL_0177: br IL_017D
    IL_017C: br IL_0188
    IL_017D: ldloc.1
    IL_017E: ldc.i4.1
    IL_017F: IL_58
    IL_0180: stloc.1
    IL_0181: ldloc.1
    IL_0182: ldc.i4.6
    IL_0183: IL_3F
    IL_0184: IL_D8
    IL_0185: IL_FF
    IL_0186: IL_FF
    IL_0187: IL_FF
    IL_0188: ldloc.0
    IL_0189: ldc.i4.6
    IL_01AA: switch (7 cases)
    IL_01AB: nop
    IL_01AC: nop
    IL_01AD: nop
    IL_01AE: ldarg.3
    IL_01AF: nop
    IL_01B0: nop
    IL_01B1: nop
    IL_01B3: starg.s 0
    IL_01B4: nop
    IL_01B5: nop
    IL_01B6: ldc.i4.5
    IL_01B7: nop
    IL_01B8: nop
    IL_01B9: nop
    IL_01BE: br IL_01E0
    IL_01BF: IL_22
    IL_01C0: nop
    IL_01C1: nop
    IL_01C6: stsfld 0x16380C3F
    IL_01C7: nop
    IL_01C8: nop
    IL_01C9: nop
    IL_01CA: IL_22
    IL_01CB: IL_CD
    IL_01CC: IL_CC
    IL_01D1: newobj 0x0B380C3F
    IL_01D2: nop
    IL_01D3: nop
    IL_01D4: nop
    IL_01D5: IL_22
    IL_01D6: nop
    IL_01D7: nop
    IL_01D8: IL_C0
    IL_01D9: IL_3F
    IL_01DA: stloc.2
    IL_01DF: br IL_01E0
    IL_01E0: ldarg.0
    IL_01E1: ldarg.0
    IL_01E6: ldfld 0x04000F1B
    IL_01E7: ldc.i4.2
    IL_01E8: IL_5A
    IL_01EA: ldc.i4.s 100
    IL_01EB: IL_58
    IL_01EC: conv.i2
    IL_01ED: ldloc.2
    IL_01EE: IL_5A
    IL_01EF: not
    IL_01F4: stfld 0x04000F21
    IL_01F5: ldarg.0
    IL_01F6: ldarg.0
    IL_01FB: ldfld 0x04000F1B
    IL_01FC: ldc.i4.5
    IL_01FD: IL_58
    IL_01FF: ldc.i4.s 20
    IL_0200: IL_5A
    IL_0205: stfld 0x04000F22
    IL_0206: ldarg.0
    IL_020B: call 0x0A00002B
    IL_020C: ldarg.0
    IL_0211: ldfld 0x04000F46
    IL_0212: conv.r8
    IL_0213: IL_4C
    IL_0214: nop
    IL_0215: nop
    IL_0216: stloc.0
    IL_0217: ldarg.0
    IL_021C: call 0x0A00002B
    IL_021D: conv.r8
    IL_021E: IL_4D
    IL_021F: nop
    IL_0220: nop
    IL_0221: stloc.0
    IL_0222: ret
    }

    public void GoNext() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F28
    IL_0007: ret
    }

    public void AmountJade() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000F1F
    IL_0007: ret
    }

    public void AmountCoin() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000F1D
    IL_0007: ret
    }

    public void GetGem() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F3C
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F3B
    IL_000A: brtrue IL_0202
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_0011: ldfld 0x04000F39
    IL_0012: IL_22
    IL_0013: nop
    IL_0014: nop
    IL_0015: IL_87
    IL_0016: IL_43
    IL_001B: call 0x0A000024
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_96
    IL_0020: IL_44
    IL_0021: IL_5A
    IL_0026: call 0x0A0000C0
    IL_002B: stfld 0x04000F39
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000F39
    IL_0032: IL_22
    IL_0033: nop
    IL_0034: nop
    IL_0035: IL_87
    IL_0036: IL_43
    IL_0753: switch (454 cases)
    }

    public void CashshopOpen() {
    IL_0004: ldstr 0x70001E8B
    IL_0005: ldarg.1
    IL_000A: call 0x0600021F
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000F3A
    IL_0011: ldnull
    IL_0016: call 0x0A000061
    IL_001B: brfalse IL_0031
    IL_001C: ldarg.0
    IL_0021: ldstr 0x700232DD
    IL_0026: call 0x0A000012
    IL_0027: conv.u8
    IL_0028: ldloc.0
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_01
    IL_0030: stfld 0x04000F3A
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000F3A
    IL_0037: conv.r8
    IL_0038: ldarg.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_0040: call 0x0A00001B
    IL_0045: call 0x0A000013
    IL_004A: call 0x0A000014
    IL_004B: pop
    IL_004C: ret
    }

    public void OpenShop() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F40
    IL_0007: ret
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000F2A
    IL_0040: call 0x0A0000DF
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_BE
    IL_0045: IL_43
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_004D: stsfld 0x00002240
    IL_004E: ldelem.r8
    IL_004F: IL_42
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0053: ldelem.r8
    IL_0054: IL_41
    IL_0059: call 0x0600021D
    IL_005E: ldsfld 0x040007B2
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04000F25
    IL_0066: ldc.i4.s 64
    IL_006B: call 0x0A0000E1
    IL_0070: ldstr 0x70022F09
    IL_0071: ldarg.0
    IL_0076: ldfld 0x04000F1B
    IL_0077: ldc.i4.1
    IL_0078: IL_58
    IL_007D: newobj 0x0100000B
    IL_0082: call 0x0A000098
    IL_0087: call 0x0A0002EA
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04000F40
    IL_0092: brfalse IL_019B
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_E0
    IL_0097: IL_42
    IL_0098: IL_22
    IL_0099: nop
    IL_009A: nop
    IL_009B: nop
    IL_009C: nop
    IL_009D: IL_22
    IL_009E: nop
    IL_009F: nop
    IL_00A4: stsfld 0x00002243
    IL_00A5: nop
    IL_00A6: IL_42
    IL_00AB: call 0x0600021D
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x04000F2B
    IL_00B6: call 0x0A0000E0
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BB: ldloca.s 67
    IL_00BC: IL_22
    IL_00BD: nop
    IL_00BE: nop
    IL_00BF: IL_C0
    IL_28000014C: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F4F
    IL_0007: ldarg.0
    IL_0008: ldc.i4.5
    IL_000D: newarr 0x0100003C
    IL_0012: stfld 0x04000F52
    IL_0013: ldarg.0
    IL_0018: call 0x0A000001
    IL_0019: ret
    }

    private void Awake() {
    IL_0000: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F4B
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F4C
    IL_0020: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000F4E
    IL_0010: ldarg.0
    IL_0015: call 0x0A00002B
    IL_001A: ldstr 0x70022774
    IL_001F: call 0x0A0001C1
    IL_0020: conv.r8
    IL_0021: IL_C9
    IL_0022: IL_01
    IL_0023: nop
    IL_0024: stloc.0
    IL_0029: ldstr 0x7002270C
    IL_002E: call 0x0A0001C1
    IL_0033: call 0x0A0001C2
    IL_0034: ldarg.0
    IL_0039: ldstr 0x70000DDD
    IL_003E: call 0x06000220
    IL_0043: stfld 0x04000F4D
    IL_0044: ldarg.0
    IL_0049: ldfld 0x04000F4D
    IL_004B: ldc.i4.s 19
    IL_004C: IL_3C
    IL_004D: IL_3D
    IL_004E: nop
    IL_004F: nop
    IL_0050: nop
    IL_0051: ldarg.0
    IL_0056: ldstr 0x70002065
    IL_005B: call 0x06000220
    IL_0060: stfld 0x04000F55
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000F55
    IL_0067: ldc.i4.1
    IL_00D4: switch (26 cases)
    }

    private void GoNext() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F4F
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ret
    }

    public void CashshopOpen() {
    IL_0004: ldstr 0x70001E8B
    IL_0005: ldarg.1
    IL_000A: call 0x0600021F
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000F54
    IL_0011: ldnull
    IL_0016: call 0x0A000061
    IL_001B: brfalse IL_0031
    IL_001C: ldarg.0
    IL_0021: ldstr 0x700232DD
    IL_0026: call 0x0A000012
    IL_0027: conv.u8
    IL_0028: ldloc.0
    IL_0029: nop
    IL_002A: nop
    IL_002B: IL_01
    IL_0030: stfld 0x04000F54
    IL_0031: ldarg.0
    IL_0036: ldfld 0x04000F54
    IL_0037: conv.r8
    IL_0038: ldarg.3
    IL_0039: nop
    IL_003A: nop
    IL_003B: stloc.0
    IL_0040: call 0x0A00001B
    IL_0045: call 0x0A000013
    IL_004A: call 0x0A000014
    IL_004B: pop
    IL_004C: ret
    }

    public void OpenShop() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F57
    IL_0007: ret
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000F50
    IL_0040: call 0x0A0000DF
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000F57
    IL_004B: brfalse IL_0154
    IL_004C: IL_22
    IL_004D: nop
    IL_004E: nop
    IL_004F: IL_E0
    IL_0050: IL_42
    IL_0051: IL_22
    IL_0052: nop
    IL_0053: nop
    IL_0054: nop
    IL_0055: nop
    IL_0056: IL_22
    IL_0057: nop
    IL_0058: nop
    IL_005D: stsfld 0x00002243
    IL_005E: nop
    IL_005F: IL_42
    IL_0064: call 0x0600021D
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000F51
    IL_006F: call 0x0A0000E0
    IL_0070: IL_22
    IL_0071: nop
    IL_0072: nop
    IL_0074: ldloca.s 67
    IL_0075: IL_22
    IL_0076: nop
    IL_0077: nop
    IL_0078: IL_C0
    IL_280000105: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: throw
    IL_0005: IL_44
    IL_000A: stfld 0x04000F59
    IL_000B: ldarg.0
    IL_000C: ldc.i4.2
    IL_0011: newarr 0x0100000B
    IL_0016: stfld 0x04000F6D
    IL_0017: ldarg.0
    IL_001C: call 0x0A000001
    IL_001D: ret
    }

    private void Awake() {
    IL_0000: IL_22
    IL_0001: nop
    IL_0002: nop
    IL_0007: stsfld 0x0111283F
    IL_0008: nop
    IL_0009: stloc.0
    IL_000A: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001F05
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x04000F6D
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000BB3
    IL_001A: call 0x0A000095
    IL_001F: stfld 0x04000F66
    IL_0020: ldarg.0
    IL_0025: call 0x0A00002B
    IL_002A: ldstr 0x70022774
    IL_002F: call 0x0A0001C1
    IL_0030: conv.r8
    IL_0031: IL_C9
    IL_0032: IL_01
    IL_0033: nop
    IL_0034: stloc.0
    IL_0039: ldstr 0x7002270C
    IL_003E: call 0x0A0001C1
    IL_0043: call 0x0A0001C2
    IL_0044: ldarg.0
    IL_0049: ldstr 0x70001EA5
    IL_004E: call 0x06000220
    IL_0053: stfld 0x04000F5D
    IL_0054: ldarg.0
    IL_0059: ldstr 0x700004D5
    IL_005E: call 0x06000220
    IL_0063: stfld 0x04000F5E
    IL_0064: ldarg.0
    IL_0069: ldstr 0x70000001
    IL_006E: call 0x0A000004
    IL_006F: conv.r8
    IL_0070: shl
    IL_0071: nop
    IL_0072: nop
    IL_0074: br.s IL_00F2
    IL_0075: conv.r4
    IL_0077: ldarga.s 0
    IL_0078: ldarg.2
    IL_0079: ldarg.0
    IL_007A: ldarg.0
    IL_007F: ldfld 0x04000F6E
    IL_0084: ldfld 0x04000380
    IL_0089: stfld 0x04000F5F
    IL_008A: ldarg.0
    IL_008B: ldarg.0
    IL_0090: ldfld 0x04000F5F
    IL_0095: stfld 0x04000F60
    IL_0096: ldarg.0
    IL_0097: ldarg.0
    IL_009C: ldfld 0x04000F6E
    IL_00A1: ldfld 0x04000382
    IL_00A6: stfld 0x04000F62
    IL_00A7: ldarg.0
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x04000F6E
    IL_00B2: ldfld 0x04000381
    IL_00B7: stfld 0x04000F61
    IL_00B8: ldarg.0
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x04000F6E
    IL_00C3: ldfld 0x04000383
    IL_00C8: stfld 0x04000F63
    IL_00C9: ldarg.0
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04000F62
    IL_00D0: ldc.i4.3
    IL_00D1: IL_5A
    IL_00D2: ldarg.0
    IL_00D7: ldfld 0x04000F61
    IL_00D8: IL_58
    IL_00D9: ldarg.0
    IL_00DE: ldfld 0x04000F5F
    IL_00DF: IL_59
    IL_00E4: stfld 0x04000F64
    IL_00E5: ldarg.0
    IL_00E6: ldc.i4.0
    IL_00E7: ldarg.0
    IL_00EC: ldfld 0x04000F64
    IL_00F1: call 0x0A000080
    IL_00F6: stfld 0x04000F64
    IL_00F7: ldarg.0
    IL_00F8: dup
    IL_00FD: ldfld 0x04000F5F
    IL_00FE: ldarg.0
    IL_0103: ldfld 0x04000F5F
    IL_0104: ldarg.0
    IL_0109: ldfld 0x04000F6D
    IL_010A: ldc.i4.0
    IL_010B: IL_94
    IL_010C: IL_5A
    IL_010D: conv.i2
    IL_010E: IL_22
    IL_010F: IL_CD
    IL_0110: IL_CC
    IL_0111: IL_CC
    IL_0112: IL_3D
    IL_0113: IL_5A
    IL_0114: not
    IL_0115: IL_58
    IL_011A: stfld 0x04000F5F
    IL_011B: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F5B
    IL_000A: brfalse IL_0075
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000F65
    IL_0016: call 0x0A000024
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldelem.r8
    IL_001B: IL_41
    IL_001C: IL_5A
    IL_001D: IL_58
    IL_0022: stfld 0x04000F65
    IL_0023: ldarg.0
    IL_0028: ldfld 0x04000F65
    IL_0029: ldarg.0
    IL_002E: ldfld 0x04000F5F
    IL_002F: conv.i2
    IL_0030: IL_44
    IL_0035: beq IL_2000036
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000F5F
    IL_003C: conv.i2
    IL_0041: stfld 0x04000F65
    IL_0042: ldarg.0
    IL_0043: ldc.i4.0
    IL_0048: stfld 0x04000F5B
    IL_0049: ldarg.0
    IL_004A: dup
    IL_004F: ldfld 0x04000F5D
    IL_0050: ldarg.0
    IL_0055: ldfld 0x04000F5F
    IL_0056: IL_58
    IL_005B: stfld 0x04000F5D
    IL_005C: ldarg.0
    IL_0061: ldfld 0x04000F5F
    IL_0062: ldc.i4.0
    IL_0067: call 0x0600021E
    IL_0068: pop
    IL_0069: ldarg.0
    IL_006A: ldc.i4.1
    IL_006F: stfld 0x04000F67
    IL_0074: br IL_00B0
    IL_0075: ldarg.0
    IL_007A: ldfld 0x04000F5A
    IL_007F: brtrue IL_00B0
    IL_0080: ldarg.0
    IL_0081: dup
    IL_0086: ldfld 0x04000F58
    IL_008B: call 0x0A000024
    IL_008C: IL_58
    IL_0091: stfld 0x04000F58
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000F58
    IL_0098: IL_22
    IL_0099: nop
    IL_009A: nop
    IL_009F: stsfld 0x000E433F
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: ldarg.0
    IL_00A3: ldc.i4.1
    IL_00A8: stfld 0x04000F5B
    IL_00A9: ldarg.0
    IL_00AA: ldc.i4.1
    IL_00AF: stfld 0x04000F5A
    IL_00B0: ldarg.0
    IL_00B5: ldfld 0x04000F5C
    IL_00BA: brtrue IL_00F3
    IL_00BB: ldarg.0
    IL_00BC: ldarg.0
    IL_00C1: ldfld 0x04000F59
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: IL_87
    IL_00C6: IL_43
    IL_00CB: call 0x0A000024
    IL_00CC: IL_22
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: IL_96
    IL_00D0: IL_44
    IL_00D1: IL_5A
    IL_00D6: call 0x0A0000C0
    IL_00DB: stfld 0x04000F59
    IL_00DC: ldarg.0
    IL_00E1: ldfld 0x04000F59
    IL_00E2: IL_22
    IL_00E3: nop
    IL_00E4: nop
    IL_00E5: IL_87
    IL_00E6: IL_43
    IL_0107: switch (7 cases)
    }

    private void OnGUI() {
    IL_0004: call 0x0A00001B
    IL_0009: call 0x0A000013
    IL_000E: call 0x0A0000D9
    IL_000F: conv.i2
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0017: cpobj 0xDA285B44
    IL_0018: nop
    IL_0019: nop
    IL_001A: stloc.0
    IL_001B: conv.i2
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_0023: ldc.i4 2251588
    IL_0024: nop
    IL_0029: stsfld 0x0076733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: call 0x0A0000DD
    IL_0035: call 0x0A0000DE
    IL_0036: ldarg.0
    IL_003B: ldfld 0x04000F68
    IL_0040: call 0x0A0000DF
    IL_0041: IL_22
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_E0
    IL_0045: IL_42
    IL_0046: IL_22
    IL_0047: nop
    IL_0048: nop
    IL_0049: nop
    IL_004A: nop
    IL_004B: IL_22
    IL_004C: nop
    IL_004D: nop
    IL_0052: stsfld 0x00002243
    IL_0053: nop
    IL_0054: IL_42
    IL_0059: call 0x0600021D
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04000F69
    IL_0064: call 0x0A0000E0
    IL_0065: IL_22
    IL_0066: nop
    IL_0067: nop
    IL_0069: ldloca.s 67
    IL_006A: IL_22
    IL_006B: nop
    IL_006C: nop
    IL_006D: IL_C0
    IL_2800000FA: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 20
    IL_0007: newarr 0x0100003C
    IL_000C: stfld 0x04000F81
    IL_000D: ldarg.0
    IL_000E: ldc.i4.3
    IL_0013: newarr 0x0100003C
    IL_0018: stfld 0x04000F82
    IL_0019: ldarg.0
    IL_001B: ldc.i4.s 20
    IL_0020: newarr 0x0100000B
    IL_0025: stfld 0x04000FA0
    IL_0026: ldarg.0
    IL_0028: ldc.i4.s 20
    IL_0029: ldc.i4.5
    IL_002E: newobj 0x0A00016D
    IL_0033: stfld 0x04000FA1
    IL_0034: ldarg.0
    IL_0035: ldc.i4.5
    IL_003A: newarr 0x0100000B
    IL_003F: stfld 0x04000FA2
    IL_0040: ldarg.0
    IL_0041: ldc.i4.m1
    IL_0046: stfld 0x04000FA4
    IL_0047: ldarg.0
    IL_0049: ldc.i4.s 20
    IL_004E: newarr 0x0100000C
    IL_0053: stfld 0x04000FA7
    IL_0054: ldarg.0
    IL_0059: call 0x0A000001
    IL_005A: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FA7
    IL_0006: ldc.i4.0
    IL_000B: ldstr 0x700241C6
    IL_0010: stelem 0x0FA77B02
    IL_0011: nop
    IL_0012: ldarg.2
    IL_0013: ldc.i4.1
    IL_0018: ldstr 0x70024234
    IL_001D: stelem 0x0FA77B02
    IL_001E: nop
    IL_001F: ldarg.2
    IL_0020: ldc.i4.2
    IL_0025: ldstr 0x700242A2
    IL_002A: stelem 0x0FA77B02
    IL_002B: nop
    IL_002C: ldarg.2
    IL_002D: ldc.i4.3
    IL_0032: ldstr 0x70024310
    IL_0037: stelem 0x0FA77B02
    IL_0038: nop
    IL_0039: ldarg.2
    IL_003A: ldc.i4.4
    IL_003F: ldstr 0x7002437E
    IL_0044: stelem 0x0FA77B02
    IL_0045: nop
    IL_0046: ldarg.2
    IL_0047: ldc.i4.5
    IL_004C: ldstr 0x700243EC
    IL_0051: stelem 0x0FA77B02
    IL_0052: nop
    IL_0053: ldarg.2
    IL_0054: ldc.i4.6
    IL_0059: ldstr 0x7002445A
    IL_005E: stelem 0x0FA77B02
    IL_005F: nop
    IL_0060: ldarg.2
    IL_0061: ldc.i4.7
    IL_0066: ldstr 0x700244C8
    IL_006B: stelem 0x0FA77B02
    IL_006C: nop
    IL_006D: ldarg.2
    IL_006E: ldc.i4.8
    IL_0073: ldstr 0x70024536
    IL_0078: stelem 0x0FA77B02
    IL_0079: nop
    IL_007A: ldarg.2
    IL_007C: ldc.i4.s 9
    IL_0081: ldstr 0x700245A4
    IL_0086: stelem 0x0FA77B02
    IL_0087: nop
    IL_0088: ldarg.2
    IL_008A: ldc.i4.s 10
    IL_008F: ldstr 0x70024612
    IL_0094: stelem 0x0FA77B02
    IL_0095: nop
    IL_0096: ldarg.2
    IL_0098: ldc.i4.s 11
    IL_009D: ldstr 0x70024680
    IL_00A2: stelem 0x0FA77B02
    IL_00A3: nop
    IL_00A4: ldarg.2
    IL_00A6: ldc.i4.s 12
    IL_00AB: ldstr 0x700246EE
    IL_00B0: stelem 0x0FA77B02
    IL_00B1: nop
    IL_00B2: ldarg.2
    IL_00B4: ldc.i4.s 13
    IL_00B9: ldstr 0x7002475C
    IL_00BE: stelem 0x0FA77B02
    IL_00BF: nop
    IL_00C0: ldarg.2
    IL_00C2: ldc.i4.s 14
    IL_00C7: ldstr 0x700247CA
    IL_00CC: stelem 0x0FA77B02
    IL_00CD: nop
    IL_00CE: ldarg.2
    IL_00D0: ldc.i4.s 15
    IL_00D5: ldstr 0x70024838
    IL_00DA: stelem 0x0FA77B02
    IL_00DB: nop
    IL_00DC: ldarg.2
    IL_00DE: ldc.i4.s 16
    IL_00E3: ldstr 0x700248A6
    IL_00E8: stelem 0x0FA77B02
    IL_00E9: nop
    IL_00EA: ldarg.2
    IL_00EC: ldc.i4.s 17
    IL_00F1: ldstr 0x70024914
    IL_00F6: stelem 0x0FA77B02
    IL_00F7: nop
    IL_00F8: ldarg.2
    IL_00FA: ldc.i4.s 18
    IL_00FF: ldstr 0x70024982
    IL_0104: stelem 0x0FA77B02
    IL_0105: nop
    IL_0106: ldarg.2
    IL_0108: ldc.i4.s 19
    IL_010D: ldstr 0x700249F0
    IL_0112: stelem 0x00000000
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000F9C
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F9D
    IL_0020: ret
    }

    private void ShotLoading() {
    IL_0004: newobj 0x060007D5
    IL_0005: stloc.0
    IL_0006: ldloc.0
    IL_0007: ldarg.1
    IL_000C: stfld 0x040010B0
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0013: stfld 0x040010B3
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_001A: stfld 0x040010B4
    IL_001B: ldloc.0
    IL_001C: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001F9B
    IL_000A: call 0x060003F9
    IL_000F: stfld 0x04000FA2
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000DDD
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000F9B
    IL_0020: ldarg.0
    IL_0025: call 0x0A0000DA
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: IL_C0
    IL_002B: IL_3E
    IL_002C: IL_5A
    IL_0031: stfld 0x04000F9A
    IL_0032: ldarg.0
    IL_0037: ldstr 0x70000BB3
    IL_003C: call 0x0A000095
    IL_0041: stfld 0x04000FA3
    IL_0042: ldarg.0
    IL_0043: IL_22
    IL_0044: nop
    IL_0045: nop
    IL_0046: IL_BE
    IL_0047: IL_C3
    IL_004C: stfld 0x04000F8D
    IL_004D: ldarg.0
    IL_004E: IL_22
    IL_004F: nop
    IL_0050: nop
    IL_0051: IL_F0
    IL_0052: IL_43
    IL_0057: stfld 0x04000F8E
    IL_0058: ldarg.0
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: IL_AA
    IL_005D: IL_43
    IL_0062: stfld 0x04000F8F
    IL_0063: ldarg.0
    IL_0064: ldarg.0
    IL_0069: call 0x2B00008F
    IL_006E: ldfld 0x04000505
    IL_0073: stfld 0x04000FA1
    IL_0074: ldarg.0
    IL_0079: ldstr 0x70002093
    IL_007E: call 0x06000220
    IL_0083: stfld 0x04000FA5
    IL_0084: ldarg.0
    IL_0089: ldstr 0x7000054F
    IL_008E: call 0x060003F9
    IL_0093: stfld 0x04000FA0
    IL_0098: ldstr 0x70000121
    IL_009D: call 0x0A000004
    IL_009E: ldnull
    IL_00A3: call 0x0A000061
    IL_00A8: brfalse IL_00CE
    IL_00A9: ldarg.0
    IL_00AA: ldarg.0
    IL_00AF: ldfld 0x04000F89
    IL_00B4: call 0x0A00001B
    IL_00B9: call 0x0A000013
    IL_00BE: call 0x0A000014
    IL_00BF: conv.u4
    IL_00C0: ldarg.1
    IL_00C1: nop
    IL_00C2: nop
    IL_00C3: IL_01
    IL_00C8: stfld 0x04000F8B
    IL_00CD: br IL_00E3
    IL_00CE: ldarg.0
    IL_00D3: ldstr 0x70000121
    IL_00D8: call 0x0A000004
    IL_00D9: conv.r8
    IL_00DA: ldarg.3
    IL_00DB: nop
    IL_00DC: nop
    IL_00DD: stloc.0
    IL_00E2: stfld 0x04000F8B
    IL_00E3: ldarg.0
    IL_00E8: ldfld 0x04000F8B
    IL_00E9: ldnull
    IL_00EE: call 0x0A000021
    IL_00F3: brfalse IL_0105
    IL_00F4: ldarg.0
    IL_00F5: ldarg.0
    IL_00FA: ldfld 0x04000F8B
    IL_00FB: conv.r8
    IL_0100: ldsfld 0x7D2B0000
    IL_0105: newobj 0x1604000F
    IL_0106: stloc.0
    IL_010B: br IL_0145
    IL_010C: ldarg.0
    IL_0111: ldfld 0x04000FA0
    IL_0112: ldloc.0
    IL_0113: IL_94
    IL_0115: ldc.i4.s -2
    IL_01B2: switch (38 cases)
    }

    public void UpdateSkillStat() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FA1
    IL_0006: ldarg.1
    IL_0007: ldc.i4.0
    IL_000C: call 0x0A000134
    IL_0011: ldfld 0x040004FC
    IL_0012: stloc.0
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000FA0
    IL_0019: ldarg.1
    IL_001A: IL_94
    IL_001B: ldc.i4.4
    IL_001C: IL_3F
    IL_001D: IL_01
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ret
    IL_0022: ldloc.0
    IL_0023: ldc.i4.1
    IL_00A8: switch (32 cases)
    }

    public void Warning_iconsize() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: ldfld 0x04000FA6
    IL_0007: ldc.i4.1
    IL_0008: IL_58
    IL_0009: ldc.i4.2
    IL_000A: mul
    IL_000F: stfld 0x04000FA6
    IL_0010: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000F92
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000F93
    IL_000E: ret
    }

    public void FindEmptySlot() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04000FA4
    IL_0007: ldc.i4.0
    IL_0008: stloc.0
    IL_000D: br IL_002C
    IL_000E: ldarg.0
    IL_0013: ldfld 0x04000FA2
    IL_0014: ldloc.0
    IL_0015: IL_94
    IL_0016: ldc.i4.m1
    IL_004B: switch (12 cases)
    }

    public void ShortCut() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F90
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000FA2
    IL_000C: ldarg.1
    IL_000D: IL_94
    IL_00C6: switch (45 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F92
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000F93
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000F93
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000F93
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_42
    IL_002A: ldloca.s 0
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000F92
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000F93
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000F9F
    IL_0049: brtrue IL_0111
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000F8D
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x002941C2
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000F8D
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000F8D
    IL_0067: shl
    IL_006C: call 0x0A000024
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0070: ldc.i4.0
    IL_0071: IL_44
    IL_0072: IL_5A
    IL_0077: call 0x0A000114
    IL_0078: IL_58
    IL_007D: stfld 0x04000F8D
    IL_0082: br IL_0111
    IL_0083: ldarg.0
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_008B: stsfld 0x0F8D7DC2
    IL_008C: nop
    IL_008D: ldarg.2
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000F8E
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000F8E
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00B0: stfld 0x04000F8E
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000F8E
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: IL_42
    IL_00BD: IL_50
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: nop
    IL_00CB: stfld 0x04000F8E
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000F8F
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000F8F
    IL_00DD: call 0x0A000024
    IL_00DE: IL_22
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_FA
    IL_00E2: IL_43
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000114
    IL_00E9: IL_59
    IL_00EE: stfld 0x04000F8F
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000F8F
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: shr
    IL_00F9: IL_43
    IL_00FA: IL_42
    IL_00FC: ldloca.s 0
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: ldarg.0
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: shr
    IL_0104: IL_43
    IL_0109: stfld 0x04000F8F
    IL_010A: ldarg.0
    IL_010B: ldc.i4.1
    IL_0110: stfld 0x04000F9F
    IL_0111: ldc.i4.0
    IL_0116: call 0x0A0000D6
    IL_011B: brfalse IL_015F
    IL_0120: call 0x0A0000D7
    IL_0121: stloc.1
    IL_0123: ldloca.s 1
    IL_0128: ldfld 0x0A000023
    IL_0129: ldarg.0
    IL_012E: ldfld 0x04000F9A
    IL_012F: IL_41
    IL_0130: pop
    IL_0131: nop
    IL_0132: nop
    IL_0133: nop
    IL_0134: ldarg.0
    IL_0135: ldc.i4.1
    IL_013A: stfld 0x04000F95
    IL_013B: ldarg.0
    IL_0140: call 0x0A0000D7
    IL_0141: stloc.2
    IL_0143: ldloca.s 2
    IL_0148: ldfld 0x0A00005E
    IL_014D: stfld 0x04000F98
    IL_014E: ldarg.0
    IL_014F: ldarg.0
    IL_0154: ldfld 0x04000F97
    IL_0159: stfld 0x04000F99
    IL_015E: br IL_0178
    IL_015F: ldc.i4.0
    IL_0164: call 0x0A0000D8
    IL_0169: brfalse IL_0178
    IL_016A: ldarg.0
    IL_016B: ldc.i4.0
    IL_0170: stfld 0x04000F95
    IL_0171: ldarg.0
    IL_0172: ldc.i4.0
    IL_0177: stfld 0x04000F96
    IL_0178: ldarg.0
    IL_017D: ldfld 0x04000F95
    IL_0182: brfalse IL_0208
    IL_0187: call 0x0A0000D7
    IL_0188: stloc.3
    IL_018A: ldloca.s 3
    IL_018F: ldfld 0x0A00005E
    IL_0190: ldarg.0
    IL_0195: ldfld 0x04000F98
    IL_0196: IL_59
    IL_019B: call 0x0A00007F
    IL_019C: IL_22
    IL_019D: nop
    IL_019E: nop
    IL_019F: nop
    IL_01A0: IL_41
    IL_01A1: IL_43
    IL_01A2: ldloc.1
    IL_01A3: nop
    IL_01A4: nop
    IL_01A5: nop
    IL_01A6: ldarg.0
    IL_01A7: ldc.i4.1
    IL_01AC: stfld 0x04000F96
    IL_01AD: ldarg.0
    IL_01B2: call 0x0A0000D7
    IL_01B4: stloc.s 4
    IL_01B6: ldloca.s 4
    IL_01BB: ldfld 0x0A00005E
    IL_01BC: ldarg.0
    IL_01C1: ldfld 0x04000F98
    IL_01C2: IL_59
    IL_01C3: IL_22
    IL_01C4: nop
    IL_01C5: nop
    IL_01C6: IL_F0
    IL_01C7: IL_43
    IL_01CC: call 0x0A0000D9
    IL_01CD: conv.i2
    IL_01CE: add
    IL_01CF: IL_5A
    IL_01D0: ldarg.0
    IL_01D5: ldfld 0x04000F99
    IL_01D6: IL_58
    IL_01DB: stfld 0x04000F97
    IL_01DC: ldarg.0
    IL_01DD: ldarg.0
    IL_01E2: ldfld 0x04000F97
    IL_01E3: IL_22
    IL_01E4: nop
    IL_01E5: nop
    IL_01E6: nop
    IL_01E7: nop
    IL_01EC: call 0x0A000114
    IL_01F1: stfld 0x04000F97
    IL_01F2: ldarg.0
    IL_01F3: ldarg.0
    IL_01F8: ldfld 0x04000F97
    IL_01F9: IL_22
    IL_01FA: nop
    IL_01FF: stsfld 0x9C28C484
    IL_0200: IL_01
    IL_0201: nop
    IL_0202: stloc.0
    IL_0207: stfld 0x04000F97
    IL_020C: ldstr 0x7000064F
    IL_0211: call 0x0A000095
    IL_0212: stloc.0
    IL_0213: ldloc.0
    IL_0214: ldc.i4.1
    IL_02C5: switch (43 cases)
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F8A
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000F8A
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000F8A
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
    }

    public void jumpSence() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0006: stfld 0x04000F91
    IL_0007: ldarg.1
    IL_000C: brtrue IL_001C
    IL_0011: ldstr 0x70022F87
    IL_0016: call 0x0A000128
    IL_001B: br IL_002D
    IL_001C: ldarg.1
    IL_001D: ldc.i4.1
    IL_004A: switch (10 cases)
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000F88
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000F94
    IL_0047: ldc.i4.0
    IL_0048: IL_3D
    IL_0049: stloc.1
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04000FAA
    IL_0057: brfalse IL_005E
    IL_0058: ldc.i4.0
    IL_005D: call 0x0A0001B9
    IL_005E: ldarg.0
    IL_0063: ldfld 0x04000F8D
    IL_0064: IL_22
    IL_0065: nop
    IL_0066: nop
    IL_0067: nop
    IL_0068: nop
    IL_0069: IL_22
    IL_006A: nop
    IL_006B: nop
    IL_006C: ldelem.r8
    IL_006D: IL_43
    IL_006E: IL_22
    IL_006F: nop
    IL_0070: nop
    IL_0071: ldelem.r8
    IL_0072: IL_43
    IL_0077: call 0x0600021D
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000F70
    IL_0082: call 0x0A0000E0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04000F8E
    IL_0089: IL_22
    IL_008A: nop
    IL_008B: nop
    IL_008C: rem
    IL_008D: IL_43
    IL_008E: IL_22
    IL_008F: nop
    IL_0090: nop
    IL_0091: IL_F0
    IL_0092: IL_43
    IL_0093: IL_22
    IL_0094: nop
    IL_0095: nop
    IL_0096: IL_C8
    IL_0097: IL_42
    IL_009C: call 0x0600021D
    IL_009D: ldarg.0
    IL_00A2: ldfld 0x04000F72
    IL_00A7: call 0x0A0000E0
    IL_00A8: IL_22
    IL_00A9: nop
    IL_00AA: nop
    IL_00AB: IL_F0
    IL_00AC: IL_42
    IL_00AD: IL_22
    IL_00AE: nop
    IL_00AF: nop
    IL_00B0: IL_F0
    IL_00B1: IL_41
    IL_00B2: IL_22
    IL_00B3: nop
    IL_00B4: nop
    IL_00B5: IL_C8
    IL_00B6: IL_42
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BC: ldloc 10306
    IL_00BD: ldc.i4.7
    IL_00BE: ldarg.0
    IL_00BF: nop
    IL_00C0: ldloc.0
    IL_00C1: ldarg.0
    IL_00C6: ldfld 0x04000F71
    IL_00CB: call 0x0A0000E0
    IL_00CC: IL_22
    IL_00CD: nop
    IL_00CE: nop
    IL_00CF: IL_3E
    IL_00D0: IL_43
    IL_00D1: IL_22
    IL_00D2: nop
    IL_00D3: nop
    IL_00D8: newobj 0x00002242
    IL_00D9: ldelem.r8
    IL_00DA: IL_42
    IL_00DB: IL_22
    IL_00DC: nop
    IL_00DD: nop
    IL_00DE: IL_C0
    IL_00DF: IL_41
    IL_00E4: call 0x0600021D
    IL_00E9: ldsfld 0x040007B2
    IL_00EA: ldarg.0
    IL_00EF: ldfld 0x04000FA3
    IL_00F1: ldc.i4.s 68
    IL_00F6: call 0x0A0000E1
    IL_00FB: call 0x0A0002EA
    IL_00FC: IL_22
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: IL_E0
    IL_0100: IL_42
    IL_0101: IL_22
    IL_0102: nop
    IL_0103: nop
    IL_0104: nop
    IL_0105: nop
    IL_0106: IL_22
    IL_0107: nop
    IL_0108: nop
    IL_010D: stsfld 0x00002243
    IL_010E: nop
    IL_010F: IL_42
    IL_0114: call 0x0600021D
    IL_0115: ldarg.0
    IL_011A: ldfld 0x04000F78
    IL_011F: call 0x0A0000E0
    IL_0120: IL_22
    IL_0121: nop
    IL_0122: nop
    IL_0124: ldloca.s 67
    IL_0125: IL_22
    IL_0126: nop
    IL_0127: nop
    IL_0128: IL_C0
    IL_2800001B5: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.6
    IL_0006: newarr 0x0100003C
    IL_000B: stfld 0x04000FB6
    IL_000C: ldarg.0
    IL_000D: ldc.i4.6
    IL_0012: newarr 0x0100003C
    IL_0017: stfld 0x04000FB7
    IL_0018: ldarg.0
    IL_0019: ldc.i4.6
    IL_001E: newarr 0x0100000C
    IL_0023: stfld 0x04000FD3
    IL_0024: ldarg.0
    IL_0025: ldc.i4.6
    IL_002A: newarr 0x0100000B
    IL_002F: stfld 0x04000FD6
    IL_0030: ldarg.0
    IL_0031: ldc.i4.6
    IL_0033: ldc.i4.s 11
    IL_0038: newobj 0x0A000167
    IL_003D: stfld 0x04000FD7
    IL_003E: ldarg.0
    IL_0043: ldc.i4 161
    IL_0048: stfld 0x04000FD9
    IL_0049: ldarg.0
    IL_004A: ldc.i4.6
    IL_004F: newarr 0x0100000B
    IL_0054: stfld 0x04000FE0
    IL_0055: ldarg.0
    IL_005A: call 0x0A000001
    IL_005B: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000DDD
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000FCF
    IL_0010: ldarg.0
    IL_0015: ldstr 0x70000E05
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000FDB
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000E0D
    IL_002A: call 0x06000220
    IL_002F: stfld 0x04000FDC
    IL_0030: ldarg.0
    IL_0035: ldstr 0x70000E1D
    IL_003A: call 0x06000220
    IL_003F: stfld 0x04000FDD
    IL_0040: ldarg.0
    IL_0045: ldstr 0x70000E25
    IL_004A: call 0x06000220
    IL_004F: stfld 0x04000FDE
    IL_0050: ldarg.0
    IL_0055: ldstr 0x70000E2D
    IL_005A: call 0x06000220
    IL_005F: stfld 0x04000FDF
    IL_0060: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70001EA5
    IL_000A: call 0x06000220
    IL_000F: stfld 0x04000FCC
    IL_0010: ldarg.0
    IL_0015: ldstr 0x700004D5
    IL_001A: call 0x06000220
    IL_001F: stfld 0x04000FCD
    IL_0020: ldarg.0
    IL_0025: ldstr 0x70000DCD
    IL_002A: call 0x060003F9
    IL_002F: stfld 0x04000FE0
    IL_0030: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70000BB3
    IL_000A: call 0x0A000095
    IL_000F: stfld 0x04000FD8
    IL_0010: ldarg.0
    IL_0011: IL_22
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_BE
    IL_0015: IL_C3
    IL_001A: stfld 0x04000FC5
    IL_001B: ldarg.0
    IL_001C: IL_22
    IL_001D: nop
    IL_001E: nop
    IL_001F: IL_F0
    IL_0020: IL_43
    IL_0025: stfld 0x04000FC6
    IL_0026: ldarg.0
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002A: IL_AA
    IL_002B: IL_43
    IL_0030: stfld 0x04000FC7
    IL_0031: ldarg.0
    IL_0032: ldarg.0
    IL_0037: call 0x2B000090
    IL_003C: ldfld 0x040004CF
    IL_0041: stfld 0x04000FD7
    IL_0042: ldarg.0
    IL_0044: ldc.i4.s 95
    IL_0045: ldarg.0
    IL_004A: ldfld 0x04000FCF
    IL_004B: ldc.i4.5
    IL_004C: IL_5A
    IL_004D: IL_58
    IL_0052: stfld 0x04000FD0
    IL_0053: ldarg.0
    IL_0058: ldstr 0x70000DE5
    IL_005D: call 0x06000220
    IL_005E: conv.i2
    IL_0063: stfld 0x04000FD1
    IL_0064: ldarg.0
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04000FD1
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04000FCF
    IL_0072: ldc.i4.s 100
    IL_0073: IL_5A
    IL_0074: conv.i2
    IL_0075: add
    IL_007A: stfld 0x04000FD1
    IL_007B: ldarg.0
    IL_0080: ldstr 0x70001EF5
    IL_0085: call 0x060003F9
    IL_008A: stfld 0x04000FD6
    IL_008F: ldstr 0x70000121
    IL_0094: call 0x0A000004
    IL_0095: ldnull
    IL_009A: call 0x0A000061
    IL_009F: brfalse IL_00C5
    IL_00A0: ldarg.0
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04000FC3
    IL_00AB: call 0x0A00001B
    IL_00B0: call 0x0A000013
    IL_00B5: call 0x0A000014
    IL_00B6: conv.u4
    IL_00B7: ldarg.1
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: IL_01
    IL_00BF: stfld 0x04000FC2
    IL_00C4: br IL_00DA
    IL_00C5: ldarg.0
    IL_00CA: ldstr 0x70000121
    IL_00CF: call 0x0A000004
    IL_00D0: conv.r8
    IL_00D1: ldarg.3
    IL_00D2: nop
    IL_00D3: nop
    IL_00D4: stloc.0
    IL_00D9: stfld 0x04000FC2
    IL_00DA: ldarg.0
    IL_00DF: ldfld 0x04000FC2
    IL_00E0: ldnull
    IL_00E5: call 0x0A000021
    IL_00EA: brfalse IL_00FC
    IL_00EB: ldarg.0
    IL_00EC: ldarg.0
    IL_00F1: ldfld 0x04000FC2
    IL_00F2: conv.r8
    IL_00F7: ldsfld 0x7D2B0000
    IL_00F8: IL_C4
    IL_00FA: ldarga.s 0
    IL_00FB: ldarg.2
    IL_00FC: ldarg.0
    IL_0101: ldfld 0x04000FD3
    IL_0102: ldc.i4.0
    IL_0107: ldsfld 0x040007B2
    IL_0108: ldarg.0
    IL_010D: ldfld 0x04000FD8
    IL_0112: ldc.i4 143
    IL_0117: call 0x0A0000E1
    IL_011C: stelem 0x0FD37B02
    IL_011D: nop
    IL_011E: ldarg.2
    IL_011F: ldc.i4.1
    IL_0124: ldsfld 0x040007B2
    IL_0125: ldarg.0
    IL_012A: ldfld 0x04000FD8
    IL_012F: ldc.i4 147
    IL_0134: call 0x0A0000E1
    IL_0139: stelem 0x0FD37B02
    IL_013A: nop
    IL_013B: ldarg.2
    IL_013C: ldc.i4.2
    IL_0141: ldsfld 0x040007B2
    IL_0142: ldarg.0
    IL_0147: ldfld 0x04000FD8
    IL_014C: ldc.i4 148
    IL_0151: call 0x0A0000E1
    IL_0156: stelem 0x0FD37B02
    IL_0157: nop
    IL_0158: ldarg.2
    IL_0159: ldc.i4.3
    IL_015E: ldsfld 0x040007B2
    IL_015F: ldarg.0
    IL_0164: ldfld 0x04000FD8
    IL_0169: ldc.i4 146
    IL_016E: call 0x0A0000E1
    IL_0173: stelem 0x0FD37B02
    IL_0174: nop
    IL_0175: ldarg.2
    IL_0176: ldc.i4.4
    IL_017B: ldsfld 0x040007B2
    IL_017C: ldarg.0
    IL_0181: ldfld 0x04000FD8
    IL_0186: ldc.i4 154
    IL_018B: call 0x0A0000E1
    IL_0190: stelem 0x0FD37B02
    IL_0191: nop
    IL_0192: ldarg.2
    IL_0193: ldc.i4.5
    IL_0198: ldsfld 0x040007B2
    IL_0199: ldarg.0
    IL_019E: ldfld 0x04000FD8
    IL_01A3: ldc.i4 145
    IL_01A8: call 0x0A0000E1
    IL_01AD: stelem 0x00061772
    IL_01B2: cpobj 0x009F281B
    IL_01B3: nop
    IL_01B4: stloc.0
    IL_01B5: ret
    }

    public void Delay() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0006: stfld 0x04000FD4
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_000D: stfld 0x04000FD5
    IL_000E: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FD4
    IL_000A: brfalse IL_003F
    IL_000B: ldarg.0
    IL_000C: dup
    IL_0011: ldfld 0x04000FD5
    IL_0016: call 0x0A000024
    IL_0017: IL_59
    IL_001C: stfld 0x04000FD5
    IL_001D: ldarg.0
    IL_0022: ldfld 0x04000FD5
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_0028: IL_42
    IL_002A: ldloca.s 0
    IL_002B: nop
    IL_002C: nop
    IL_002D: ldarg.0
    IL_002E: ldc.i4.0
    IL_0033: stfld 0x04000FD4
    IL_0034: ldarg.0
    IL_0035: IL_22
    IL_0036: nop
    IL_0037: nop
    IL_0038: nop
    IL_0039: nop
    IL_003E: stfld 0x04000FD5
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04000FCB
    IL_0049: brtrue IL_0111
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04000FC5
    IL_0050: IL_22
    IL_0051: nop
    IL_0052: nop
    IL_0057: stsfld 0x002941C2
    IL_0058: nop
    IL_0059: nop
    IL_005A: ldarg.0
    IL_005B: ldarg.0
    IL_0060: ldfld 0x04000FC5
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04000FC5
    IL_0067: shl
    IL_006C: call 0x0A000024
    IL_006D: IL_22
    IL_006E: nop
    IL_006F: nop
    IL_0070: ldc.i4.0
    IL_0071: IL_44
    IL_0072: IL_5A
    IL_0077: call 0x0A000114
    IL_0078: IL_58
    IL_007D: stfld 0x04000FC5
    IL_0082: br IL_0111
    IL_0083: ldarg.0
    IL_0084: IL_22
    IL_0085: nop
    IL_0086: nop
    IL_008B: stsfld 0x0FC57DC2
    IL_008C: nop
    IL_008D: ldarg.2
    IL_008E: ldarg.0
    IL_008F: ldarg.0
    IL_0094: ldfld 0x04000FC6
    IL_0095: ldarg.0
    IL_009A: ldfld 0x04000FC6
    IL_009F: call 0x0A000024
    IL_00A0: IL_22
    IL_00A1: nop
    IL_00A6: stsfld 0x285A44BB
    IL_00A7: ldnull
    IL_00A8: IL_01
    IL_00A9: nop
    IL_00AA: stloc.0
    IL_00AB: IL_59
    IL_00B0: stfld 0x04000FC6
    IL_00B1: ldarg.0
    IL_00B6: ldfld 0x04000FC6
    IL_00B7: IL_22
    IL_00B8: nop
    IL_00B9: nop
    IL_00BA: nop
    IL_00BB: nop
    IL_00BC: IL_42
    IL_00BD: IL_50
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: nop
    IL_00C1: ldarg.0
    IL_00C2: IL_22
    IL_00C3: nop
    IL_00C4: nop
    IL_00C5: nop
    IL_00C6: nop
    IL_00CB: stfld 0x04000FC6
    IL_00CC: ldarg.0
    IL_00CD: ldarg.0
    IL_00D2: ldfld 0x04000FC7
    IL_00D3: ldarg.0
    IL_00D8: ldfld 0x04000FC7
    IL_00DD: call 0x0A000024
    IL_00DE: IL_22
    IL_00DF: nop
    IL_00E0: nop
    IL_00E1: IL_FA
    IL_00E2: IL_43
    IL_00E3: IL_5A
    IL_00E8: call 0x0A000114
    IL_00E9: IL_59
    IL_00EE: stfld 0x04000FC7
    IL_00EF: ldarg.0
    IL_00F4: ldfld 0x04000FC7
    IL_00F5: IL_22
    IL_00F6: nop
    IL_00F7: nop
    IL_00F8: shr
    IL_00F9: IL_43
    IL_00FA: IL_42
    IL_00FC: ldloca.s 0
    IL_00FD: nop
    IL_00FE: nop
    IL_00FF: ldarg.0
    IL_0100: IL_22
    IL_0101: nop
    IL_0102: nop
    IL_0103: shr
    IL_0104: IL_43
    IL_0109: stfld 0x04000FC7
    IL_010A: ldarg.0
    IL_010B: ldc.i4.1
    IL_0110: stfld 0x04000FCB
    IL_0115: ldstr 0x7000064F
    IL_011A: call 0x0A000095
    IL_011B: stloc.0
    IL_011C: ldloc.0
    IL_011D: ldc.i4.1
    IL_01CE: switch (43 cases)
    }

    public void jumpSence() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0015
    IL_000A: ldstr 0x70022F87
    IL_000F: call 0x0A000128
    IL_0014: br IL_0026
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0043: switch (10 cases)
    }

    public void StatInfo_detail() {
    IL_0000: ldarg.1
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0005: ldarg 6
    IL_0006: nop
    IL_0007: nop
    IL_0008: ldarg.3
    IL_0009: nop
    IL_000A: nop
    IL_000B: nop
    IL_000C: ldc.i4.m1
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_0010: dup
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_35
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_001A: ldarg 0
    IL_001B: nop
    IL_001C: IL_55
    IL_001D: nop
    IL_001E: nop
    IL_001F: nop
    IL_0024: br IL_0085
    IL_0025: ldarg.0
    IL_002A: ldc.i4 163
    IL_002F: stfld 0x04000FD9
    IL_0034: br IL_0085
    IL_0035: ldarg.0
    IL_003A: ldc.i4 162
    IL_003F: stfld 0x04000FD9
    IL_0044: br IL_0085
    IL_0045: ldarg.0
    IL_004A: ldc.i4 167
    IL_004F: stfld 0x04000FD9
    IL_0054: br IL_0085
    IL_0055: ldarg.0
    IL_005A: ldc.i4 165
    IL_005F: stfld 0x04000FD9
    IL_0064: br IL_0085
    IL_0065: ldarg.0
    IL_006A: ldc.i4 161
    IL_006F: stfld 0x04000FD9
    IL_0074: br IL_0085
    IL_0075: ldarg.0
    IL_007A: ldc.i4 170
    IL_007F: stfld 0x04000FD9
    IL_0084: br IL_0085
    IL_0085: ret
    }

    public void CashshopOpen() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FC1
    IL_0006: ldnull
    IL_000B: call 0x0A000061
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: ldstr 0x700232DD
    IL_001B: call 0x0A000012
    IL_001C: conv.u8
    IL_001D: ldloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: IL_01
    IL_0025: stfld 0x04000FC1
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04000FC1
    IL_002C: conv.r8
    IL_002D: ldarg.3
    IL_002E: nop
    IL_002F: nop
    IL_0030: stloc.0
    IL_0035: call 0x0A00001B
    IL_003A: call 0x0A000013
    IL_003F: call 0x0A000014
    IL_0040: pop
    IL_0041: ret
    }

    private void OnGUI() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FC0
    IL_000A: call 0x0A0000DF
    IL_000F: call 0x0A00001B
    IL_0014: call 0x0A000013
    IL_0019: call 0x0A0000D9
    IL_001A: conv.i2
    IL_001B: IL_22
    IL_001C: nop
    IL_001D: nop
    IL_0022: cpobj 0xDA285B44
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: conv.i2
    IL_0027: IL_22
    IL_0028: nop
    IL_0029: nop
    IL_002E: ldc.i4 2251588
    IL_002F: nop
    IL_0034: stsfld 0x0076733F
    IL_0035: nop
    IL_0036: stloc.0
    IL_003B: call 0x0A0000DD
    IL_0040: call 0x0A0000DE
    IL_0041: ldarg.0
    IL_0046: ldfld 0x04000FC9
    IL_0047: ldc.i4.0
    IL_0048: IL_3E
    IL_0049: ldloc.0
    IL_004A: nop
    IL_004B: nop
    IL_004C: nop
    IL_004D: ldc.i4.0
    IL_0052: call 0x0A0001B9
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04000FC5
    IL_0059: IL_22
    IL_005A: nop
    IL_005B: nop
    IL_005C: nop
    IL_005D: nop
    IL_005E: IL_22
    IL_005F: nop
    IL_0060: nop
    IL_0061: ldelem.r8
    IL_0062: IL_43
    IL_0063: IL_22
    IL_0064: nop
    IL_0065: nop
    IL_0066: ldelem.r8
    IL_0067: IL_43
    IL_006C: call 0x0600021D
    IL_006D: ldarg.0
    IL_0072: ldfld 0x04000FAC
    IL_0077: call 0x0A0000E0
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04000FC6
    IL_007E: IL_22
    IL_007F: nop
    IL_0080: nop
    IL_0081: IL_54
    IL_0082: IL_43
    IL_0083: IL_22
    IL_0084: nop
    IL_0085: nop
    IL_0086: IL_F0
    IL_0087: IL_43
    IL_0088: IL_22
    IL_0089: nop
    IL_008A: nop
    IL_008B: IL_C8
    IL_008C: IL_42
    IL_0091: call 0x0600021D
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04000FAD
    IL_009C: call 0x0A0000E0
    IL_009D: IL_22
    IL_009E: nop
    IL_009F: nop
    IL_00A0: IL_E0
    IL_00A1: IL_42
    IL_00A2: IL_22
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: nop
    IL_00A6: nop
    IL_00A7: IL_22
    IL_00A8: nop
    IL_00A9: nop
    IL_00AE: stsfld 0x00002243
    IL_00AF: nop
    IL_00B0: IL_42
    IL_00B5: call 0x0600021D
    IL_00B6: ldarg.0
    IL_00BB: ldfld 0x04000FB2
    IL_00C0: call 0x0A0000E0
    IL_00C1: IL_22
    IL_00C2: nop
    IL_00C3: nop
    IL_00C5: ldloca.s 67
    IL_00C6: IL_22
    IL_00C7: nop
    IL_00C8: nop
    IL_00C9: IL_C0
    IL_280000156: switch (2684354594 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FE1
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A000003
    IL_0017: stfld 0x04000FE7
    IL_0018: ldarg.0
    IL_0019: IL_22
    IL_001A: nop
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: stfld 0x04000FE6
    IL_0023: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0004: nop
    IL_0005: nop
    IL_000A: stfld 0x04000FE6
    IL_000B: ret
    }

    private void OnTriggerEnter() {
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: stloc.0
    IL_0003: nop
    IL_0004: nop
    IL_0005: stloc.0
    IL_0006: conv.r8
    IL_0007: ldc.i4.8
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000C: ldc.i4.s 15
    IL_0225: switch (133 cases)
    }

    public void PressDamage() {
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0006: stfld 0x04000FE2
    IL_0007: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FE4
    IL_0006: IL_22
    IL_0007: nop
    IL_0008: nop
    IL_0009: nop
    IL_000A: nop
    IL_000B: IL_43
    IL_0010: newarr 0x02000000
    IL_0011: dup
    IL_0016: ldfld 0x04000FE6
    IL_001B: call 0x0A000024
    IL_001C: IL_58
    IL_0021: stfld 0x04000FE6
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000FE5
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_002D: IL_43
    IL_002E: ldc.i4.7
    IL_002F: nop
    IL_0030: nop
    IL_0031: nop
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000FE6
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000FE5
    IL_003E: IL_44
    IL_003F: stloc.2
    IL_0040: nop
    IL_0041: nop
    IL_0042: nop
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04000FE7
    IL_0049: ldc.i4.0
    IL_004A: conv.r8
    IL_004C: ldc.i4.s 0
    IL_004D: nop
    IL_004E: stloc.0
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04000FE6
    IL_0055: ldarg.0
    IL_005A: ldfld 0x04000FE4
    IL_005B: IL_44
    IL_005C: IL_3D
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0061: IL_22
    IL_0062: nop
    IL_0063: nop
    IL_0064: nop
    IL_0065: nop
    IL_006A: stfld 0x04000FE6
    IL_006B: ldarg.0
    IL_0070: call 0x0A00000A
    IL_0071: ldc.i4.0
    IL_0072: conv.r8
    IL_0073: stloc.1
    IL_0074: nop
    IL_0075: nop
    IL_0076: stloc.0
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04000FE1
    IL_0081: call 0x0A00004B
    IL_0082: IL_22
    IL_0083: nop
    IL_0084: nop
    IL_0085: ldelem.r8
    IL_212A: switch (2088 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: ldelem.i
    IL_0003: IL_99
    IL_0004: IL_D9
    IL_0005: IL_3F
    IL_000A: stfld 0x04000FE9
    IL_000B: ldarg.0
    IL_0010: call 0x0A000001
    IL_0011: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FE8
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: ldfld 0x04000FE8
    IL_0013: conv.r8
    IL_0014: mul
    IL_0015: nop
    IL_0016: nop
    IL_0017: stloc.0
    IL_001C: stfld 0x04000FEB
    IL_001D: ret
    }

    public void DropCancel() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70024A98
    IL_000A: call 0x0A00007B
    IL_000B: ldarg.0
    IL_000C: ldc.i4.0
    IL_0011: stfld 0x04000FEA
    IL_0012: ret
    }

    public void Drop() {
    IL_0000: ldarg.0
    IL_0005: ldstr 0x70024A98
    IL_000A: call 0x0A00007B
    IL_000B: ldarg.1
    IL_0010: brfalse IL_0026
    IL_0011: ldarg.0
    IL_0016: call 0x0A00000A
    IL_0017: IL_22
    IL_0018: nop
    IL_0019: nop
    IL_001E: ldc.i4 7415872
    IL_001F: nop
    IL_0020: stloc.0
    IL_0025: br IL_0036
    IL_0026: ldarg.0
    IL_002B: ldstr 0x70024A98
    IL_002C: IL_22
    IL_002D: nop
    IL_002E: nop
    IL_002F: rem
    IL_FCD4: switch (16168 cases)
    }

    private void Disappear() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FE8
    IL_000A: call 0x0A00004B
    IL_000B: IL_22
    IL_000C: nop
    IL_000D: nop
    IL_0012: stsfld 0x00082840
    IL_0013: nop
    IL_0014: stloc.0
    IL_0015: conv.r8
    IL_0016: ldloc.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: call 0x0A00000A
    IL_0020: ldc.i4.0
    IL_0021: conv.r8
    IL_0022: stloc.1
    IL_0023: nop
    IL_0024: nop
    IL_0025: stloc.0
    IL_0026: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FEA
    IL_000A: brfalse IL_00EB
    IL_000B: ldarg.0
    IL_0010: ldfld 0x04000FE8
    IL_0011: conv.r8
    IL_0012: ldc.i4.2
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: stloc.0
    IL_0018: ldloca.s 0
    IL_001D: ldfld 0x0A000023
    IL_001E: IL_22
    IL_001F: nop
    IL_0020: nop
    IL_0021: nop
    IL_0022: nop
    IL_0023: IL_43
    IL_0028: ldstr 0x02000000
    IL_002D: ldfld 0x04000FE8
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04000FEB
    IL_0038: call 0x0A000024
    IL_003D: call 0x0A000008
    IL_003E: IL_22
    IL_003F: nop
    IL_0040: nop
    IL_0041: IL_34
    IL_0042: IL_44
    IL_0047: call 0x0A000008
    IL_0048: conv.r8
    IL_0049: IL_B5
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldarg.0
    IL_004E: dup
    IL_0053: ldfld 0x04000FE9
    IL_0054: IL_22
    IL_0055: nop
    IL_0056: nop
    IL_0057: rem
    IL_90FC: switch (9256 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0002: ldc.i4.s 25
    IL_0007: newarr 0x0200006B
    IL_000C: stfld 0x04000FF9
    IL_000D: ldarg.0
    IL_000E: ldc.i4.6
    IL_0013: newarr 0x0100000B
    IL_0018: stfld 0x04000FFA
    IL_0019: ldarg.0
    IL_001E: call 0x0A000001
    IL_001F: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x2B000091
    IL_000B: ldfld 0x0400051A
    IL_0010: stfld 0x04000FF9
    IL_0011: ret
    }

    public void IconImage_Only() {
    IL_0000: ldarg.1
    IL_0005: ldc.i4 1000000
    IL_0006: add
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldarg.0
    IL_000E: ldfld 0x04000FF9
    IL_000F: ldloc.0
    IL_0010: IL_8F
    IL_0011: conv.i2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.0
    IL_0019: ldfld 0x04000517
    IL_001E: stfld 0x04000FF8
    IL_001F: ldarg.0
    IL_0024: ldfld 0x04000FF8
    IL_0025: ret
    }

    public void Cost_only() {
    IL_0000: ldarg.1
    IL_0005: ldc.i4 1000000
    IL_0006: add
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_000D: ldfld 0x04000FF9
    IL_000E: ldloc.0
    IL_000F: IL_8F
    IL_0010: conv.i2
    IL_0011: nop
    IL_0012: nop
    IL_0013: ldarg.0
    IL_0018: ldfld 0x04000519
    IL_0019: stloc.1
    IL_001A: ldloc.1
    IL_001B: ret
    }

    public void SetStat() {
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0006: br IL_001D
    IL_0007: ldarg.0
    IL_000C: ldfld 0x04000FFA
    IL_000D: ldloc.0
    IL_000E: ldarg.1
    IL_0010: ldc.i4.s 10
    IL_0011: mul
    IL_0012: ldelem.i8
    IL_0013: ldarg.1
    IL_0015: ldc.i4.s 10
    IL_0016: add
    IL_0018: starg.s 1
    IL_0019: ldloc.0
    IL_001A: ldc.i4.1
    IL_001B: IL_58
    IL_001C: stloc.0
    IL_001D: ldloc.0
    IL_001E: ldc.i4.6
    IL_001F: IL_3F
    IL_0020: IL_E3
    IL_0021: IL_FF
    IL_0022: IL_FF
    IL_0023: IL_FF
    IL_0024: ldarg.0
    IL_0025: ldarg.1
    IL_002A: stfld 0x04000FEC
    IL_002B: ldarg.0
    IL_002C: ldarg.0
    IL_0031: ldfld 0x04000FF9
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000FEC
    IL_0038: IL_8F
    IL_0039: conv.i2
    IL_003A: nop
    IL_003B: nop
    IL_003C: ldarg.0
    IL_0041: ldfld 0x04000517
    IL_0046: stfld 0x04000FED
    IL_0047: ldarg.0
    IL_0048: ldarg.0
    IL_004D: ldfld 0x04000FF9
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04000FEC
    IL_0054: IL_8F
    IL_0055: conv.i2
    IL_0056: nop
    IL_0057: nop
    IL_0058: ldarg.0
    IL_005D: ldfld 0x04000518
    IL_0062: stfld 0x04000FEE
    IL_0063: ldarg.0
    IL_0064: ldarg.0
    IL_0069: ldfld 0x04000FFA
    IL_006A: ldc.i4.4
    IL_006B: IL_94
    IL_0070: stfld 0x04000FF4
    IL_0071: ldarg.0
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04000FFA
    IL_0078: ldc.i4.5
    IL_0079: IL_94
    IL_007E: stfld 0x04000FF5
    IL_007F: ldarg.0
    IL_0080: ldarg.0
    IL_0085: ldfld 0x04000FF9
    IL_0086: ldarg.0
    IL_008B: ldfld 0x04000FEC
    IL_008C: IL_8F
    IL_008D: conv.i2
    IL_008E: nop
    IL_008F: nop
    IL_0090: ldarg.0
    IL_0095: ldfld 0x04000513
    IL_009A: stfld 0x04000FEF
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04000FF4
    IL_00A1: ldc.i4.4
    IL_00A6: beq IL_00FD
    IL_00A7: ldarg.0
    IL_00A8: ldarg.0
    IL_00AD: ldfld 0x04000FFA
    IL_00AE: ldc.i4.0
    IL_00AF: IL_94
    IL_00B0: ldarg.0
    IL_00B5: ldfld 0x04000FEC
    IL_00B6: IL_5A
    IL_00B7: conv.i2
    IL_00B8: IL_22
    IL_00B9: IL_CD
    IL_00BA: IL_CC
    IL_00BB: IL_4C
    IL_00BC: IL_3D
    IL_00BD: IL_5A
    IL_00BE: ldarg.0
    IL_00C3: ldfld 0x04000FF4
    IL_00C4: conv.i2
    IL_00C5: IL_22
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: nop
    IL_3FB1ECD5: switch (267156226 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FFB
    IL_000C: ldarg.0
    IL_0011: ldstr 0x70000001
    IL_0016: call 0x0A000004
    IL_0017: conv.r8
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: stloc.0
    IL_0020: stfld 0x04000FFC
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04000FFB
    IL_0028: conv.r8
    IL_002D: cpobj 0x7D0A0000
    IL_002E: IL_FD
    IL_0030: ldarga.s 0
    IL_0031: ldarg.2
    IL_0032: ldarg.0
    IL_0037: ldfld 0x04000FFB
    IL_0038: ldc.i4.0
    IL_0039: conv.r8
    IL_003E: brtrue IL_6F0A003F
    IL_003F: ret
    IL_0040: nop
    IL_0041: nop
    IL_0042: stloc.0
    IL_0047: ldstr 0x70000B6F
    IL_0048: conv.r8
    IL_004A: bge.s IL_004B
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: IL_22
    IL_004E: IL_CD
    IL_004F: IL_CC
    IL_0050: IL_4C
    IL_0051: IL_3E
    IL_0052: conv.r8
    IL_0054: bgt.s IL_0055
    IL_0055: nop
    IL_0056: stloc.0
    IL_0057: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FFB
    IL_000A: call 0x0A00001B
    IL_000B: conv.r8
    IL_000C: IL_AF
    IL_000D: nop
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0015: ldfld 0x04000FFB
    IL_0016: ldc.i4.0
    IL_0017: conv.r8
    IL_001C: brtrue IL_6F0A001D
    IL_001D: stloc.0
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: ldc.i4.1
    IL_0022: conv.r8
    IL_0023: stloc.1
    IL_0024: nop
    IL_0025: nop
    IL_0026: stloc.0
    IL_0027: ldarg.0
    IL_0028: IL_22
    IL_0029: nop
    IL_002A: nop
    IL_002B: nop
    IL_002C: nop
    IL_0031: stfld 0x04000FFE
    IL_0032: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000FFB
    IL_0006: ldarg.0
    IL_000B: ldfld 0x04000FFC
    IL_000C: conv.r8
    IL_000D: ldc.i4.2
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: conv.r8
    IL_0012: ldloc.3
    IL_0013: nop
    IL_0014: nop
    IL_0015: stloc.0
    IL_0016: ldarg.0
    IL_0017: dup
    IL_001C: ldfld 0x04000FFE
    IL_0021: call 0x0A000024
    IL_0022: IL_58
    IL_0027: stfld 0x04000FFE
    IL_0028: ldarg.0
    IL_002D: ldfld 0x04000FFE
    IL_002E: IL_22
    IL_002F: nop
    IL_0030: nop
    IL_0031: IL_C0
    IL_0032: IL_3F
    IL_0033: IL_43
    IL_0035: bgt.s IL_0036
    IL_0036: nop
    IL_0037: nop
    IL_0038: ldarg.0
    IL_003D: ldfld 0x04000FFB
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04000FFB
    IL_0044: conv.r8
    IL_0049: cpobj 0x280A0000
    IL_004A: ldc.i4.5
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_0052: call 0x0A000024
    IL_0053: IL_22
    IL_0054: nop
    IL_0055: nop
    IL_0056: ldelem.r8
    IL_2C8A1C3: switch (11675738 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Awake() {
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0006: call 0x0A000002
    IL_000B: stfld 0x04000FFF
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x0A00002A
    IL_0017: stfld 0x04001002
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001E: ldfld 0x04000FFF
    IL_001F: ldc.i4.2
    IL_0020: conv.r8
    IL_0025: brtrue IL_7D0A0026
    IL_0026: nop
    IL_0028: starg.s 0
    IL_0029: ldarg.2
    IL_002A: ret
    }

    private void OnEnable() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001000
    IL_0006: conv.r8
    IL_0007: stloc.0
    IL_0008: nop
    IL_0009: nop
    IL_000A: stloc.0
    IL_000B: ldc.i4.1
    IL_000C: conv.r8
    IL_000D: stloc.1
    IL_000E: nop
    IL_000F: nop
    IL_0010: stloc.0
    IL_0011: ldarg.0
    IL_0016: ldfld 0x04001002
    IL_001B: ldstr 0x70024AAC
    IL_001C: conv.r8
    IL_001D: IL_3C
    IL_001E: nop
    IL_001F: nop
    IL_0020: stloc.0
    IL_0021: pop
    IL_0022: ldarg.0
    IL_0023: IL_22
    IL_0024: nop
    IL_0025: nop
    IL_0026: nop
    IL_0027: nop
    IL_002C: stfld 0x04001001
    IL_002D: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001002
    IL_000A: ldstr 0x70000AD5
    IL_000B: conv.r8
    IL_000D: bge.s IL_000E
    IL_000E: nop
    IL_000F: stloc.0
    IL_0010: IL_22
    IL_0011: nop
    IL_0012: nop
    IL_0013: nop
    IL_0014: IL_3F
    IL_0015: conv.r8
    IL_0017: bgt.s IL_0018
    IL_0018: nop
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001F: ldfld 0x04001002
    IL_0024: ldstr 0x70000AE7
    IL_0025: conv.r8
    IL_0027: bge.s IL_0028
    IL_0028: nop
    IL_0029: stloc.0
    IL_002A: IL_22
    IL_002B: nop
    IL_002C: nop
    IL_0031: stsfld 0x00306F3E
    IL_0032: nop
    IL_0033: stloc.0
    IL_0034: ldarg.0
    IL_0039: ldfld 0x04001002
    IL_003E: ldstr 0x70024AAC
    IL_003F: conv.r8
    IL_0041: bge.s IL_0042
    IL_0042: nop
    IL_0043: stloc.0
    IL_0044: IL_22
    IL_0045: IL_CD
    IL_0046: IL_CC
    IL_0047: stloc.2
    IL_C208: switch (12399 cases)
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04001001
    IL_000B: call 0x0A000024
    IL_000C: IL_58
    IL_0011: stfld 0x04001001
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04001001
    IL_0018: IL_22
    IL_0019: nop
    IL_001A: nop
    IL_001F: stsfld 0x002D4340
    IL_0020: nop
    IL_0021: nop
    IL_0022: ldarg.0
    IL_0027: call 0x0A00000A
    IL_0028: ldc.i4.0
    IL_0029: conv.r8
    IL_002A: stloc.1
    IL_002B: nop
    IL_002C: nop
    IL_002D: stloc.0
    IL_002E: ldarg.0
    IL_0033: ldfld 0x04001000
    IL_0034: conv.r8
    IL_0035: stloc.0
    IL_0036: nop
    IL_0037: nop
    IL_0038: stloc.0
    IL_0039: ldc.i4.0
    IL_003A: conv.r8
    IL_003B: stloc.1
    IL_003C: nop
    IL_003D: nop
    IL_003E: stloc.0
    IL_003F: ldarg.0
    IL_0044: ldfld 0x04001002
    IL_0045: conv.r8
    IL_0048: ldloc 0
    IL_0049: stloc.0
    IL_004E: br IL_0095
    IL_004F: ldarg.0
    IL_0054: ldfld 0x04001001
    IL_0055: IL_22
    IL_0056: nop
    IL_0057: nop
    IL_550D5C: switch (1393472 cases)
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001004
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001004
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001003
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001003
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 275817431040
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001003
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001008
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001008
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001007
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001007
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00FD
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0024: ldc.i4.s 100
    IL_0029: call 0x0A000045
    IL_002E: stfld 0x04001006
    IL_002F: ldarg.0
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0037: ldc.i4 6714176
    IL_0038: nop
    IL_0039: stloc.0
    IL_003E: stfld 0x04001008
    IL_003F: ldarg.0
    IL_0040: ldc.i4.1
    IL_0045: stfld 0x04001007
    IL_004A: br IL_00FF
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04001009
    IL_0055: ldfld 0x04000032
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04001006
    IL_005C: conv.i2
    IL_005D: IL_43
    IL_005F: ldloc.s 0
    IL_0060: nop
    IL_0061: nop
    IL_0062: ldarg.0
    IL_0067: ldfld 0x04001009
    IL_0068: ldc.i4.0
    IL_006D: call 0x06000013
    IL_0072: br IL_00F6
    IL_0073: ldarg.0
    IL_0078: ldfld 0x04001009
    IL_007D: call 0x0A00000A
    IL_007E: ldc.i4.8
    IL_007F: conv.r8
    IL_0080: ldc.i4.m1
    IL_0081: nop
    IL_0082: nop
    IL_0083: stloc.0
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04001009
    IL_008E: ldfld 0x0400001E
    IL_0093: ldstr 0x7000005B
    IL_0094: conv.r8
    IL_0096: brfalse.s IL_0097
    IL_0097: nop
    IL_0098: stloc.0
    IL_0099: conv.r8
    IL_009A: stloc.3
    IL_009B: nop
    IL_009C: nop
    IL_009D: stloc.0
    IL_009E: conv.r8
    IL_009F: neg
    IL_00A0: nop
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04001009
    IL_00AD: ldfld 0x04000016
    IL_00AE: conv.r8
    IL_00B0: ldarga.s 0
    IL_00B1: nop
    IL_00B2: stloc.0
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x04001009
    IL_00B9: ldc.i4.1
    IL_00BE: stfld 0x04000022
    IL_00BF: ldarg.0
    IL_00C4: ldfld 0x04001009
    IL_00C9: ldfld 0x0400005B
    IL_00CA: ldarg.0
    IL_00CF: ldfld 0x04001009
    IL_00D4: ldfld 0x0400002B
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x04001009
    IL_00DF: ldfld 0x0400002C
    IL_00E0: ldarg.0
    IL_00E5: ldfld 0x04001009
    IL_00EA: ldfld 0x0400001E
    IL_00EB: IL_22
    IL_00EC: IL_CD
    IL_00ED: IL_CC
    IL_00EE: IL_CC
    IL_00EF: IL_3E
    IL_00F0: ldc.i4.0
    IL_00F1: conv.r8
    IL_00F2: ldnull
    IL_00F3: ldarg.1
    IL_00F4: nop
    IL_00F5: ldloc.0
    IL_00F6: ldarg.0
    IL_00F7: ldc.i4.m1
    IL_00FC: stfld 0x04001007
    IL_00FD: ldc.i4.0
    IL_00FE: ret
    IL_00FF: ldc.i4.1
    IL_0100: ret
    IL_0101: ldloc.1
    IL_0102: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001007
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100B
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100B
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100A
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400100A
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 413256384512
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400100A
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100E
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100E
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400100D
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400100D
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 408961417216
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_199CD29: switch (6714176 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400100D
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001011
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001011
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001010
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001010
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 408961417216
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: ldelem.i
    IL_0024: IL_99
    IL_0025: IL_99
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001011
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001010
    IL_003C: br IL_0082
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001012
    IL_0043: ldc.i4.0
    IL_0048: stfld 0x040000AB
    IL_0049: ldarg.0
    IL_004E: ldfld 0x04001012
    IL_0053: ldfld 0x040000AA
    IL_0054: conv.r8
    IL_0056: ldarg.s 0
    IL_0057: nop
    IL_0058: stloc.0
    IL_0059: ldarg.0
    IL_005E: ldfld 0x04001012
    IL_0063: ldfld 0x0400006B
    IL_0064: conv.r8
    IL_0066: ldarga.s 0
    IL_0067: nop
    IL_0068: stloc.0
    IL_0069: ldarg.0
    IL_006E: ldfld 0x04001012
    IL_0073: ldstr 0x700001F1
    IL_0078: call 0x0A00007B
    IL_0079: ldarg.0
    IL_007A: ldc.i4.m1
    IL_007F: stfld 0x04001010
    IL_0080: ldc.i4.0
    IL_0081: ret
    IL_0082: ldc.i4.1
    IL_0083: ret
    IL_0084: ldloc.1
    IL_0085: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001010
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001014
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001014
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001013
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001013
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 340241940480
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001013
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001018
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001018
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001017
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001017
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: bge.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00F3
    IL_0021: ldarg.0
    IL_0022: ldc.i4.0
    IL_0024: ldc.i4.s 100
    IL_0029: call 0x0A000045
    IL_002E: stfld 0x04001016
    IL_002F: ldarg.0
    IL_0030: IL_22
    IL_0031: nop
    IL_0032: nop
    IL_0037: ldc.i4 6714176
    IL_0038: nop
    IL_0039: stloc.0
    IL_003E: stfld 0x04001018
    IL_003F: ldarg.0
    IL_0040: ldc.i4.1
    IL_0045: stfld 0x04001017
    IL_004A: br IL_00F5
    IL_004B: ldarg.0
    IL_0050: ldfld 0x04001019
    IL_0055: ldfld 0x0400007D
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04001016
    IL_005C: IL_3E
    IL_005E: ldloc.s 0
    IL_005F: nop
    IL_0060: nop
    IL_0061: ldarg.0
    IL_0066: ldfld 0x04001019
    IL_0067: ldc.i4.0
    IL_006C: call 0x06000027
    IL_0071: br IL_00EC
    IL_0072: ldarg.0
    IL_0077: ldfld 0x04001019
    IL_007C: call 0x0A00000A
    IL_007D: ldc.i4.8
    IL_007E: conv.r8
    IL_007F: ldc.i4.m1
    IL_0080: nop
    IL_0081: nop
    IL_0082: stloc.0
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04001019
    IL_008D: ldfld 0x040000AA
    IL_008E: conv.r8
    IL_0090: ldarg.s 0
    IL_0091: nop
    IL_0092: stloc.0
    IL_0093: ldarg.0
    IL_0098: ldfld 0x04001019
    IL_009D: ldfld 0x0400006B
    IL_009E: conv.r8
    IL_00A0: ldarga.s 0
    IL_00A1: nop
    IL_00A2: stloc.0
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x04001019
    IL_00A9: ldc.i4.1
    IL_00AE: stfld 0x0400006C
    IL_00AF: ldarg.0
    IL_00B4: ldfld 0x04001019
    IL_00B9: ldfld 0x0400009E
    IL_00BA: ldarg.0
    IL_00BF: ldfld 0x04001019
    IL_00C4: ldfld 0x04000084
    IL_00C5: ldarg.0
    IL_00CA: ldfld 0x04001019
    IL_00CF: ldfld 0x04000082
    IL_00D0: ldarg.0
    IL_00D5: ldfld 0x04001019
    IL_00DA: ldfld 0x040000A7
    IL_00DB: ldarg.0
    IL_00E0: ldfld 0x04001019
    IL_00E5: ldfld 0x04000080
    IL_00E6: ldc.i4.0
    IL_00E7: conv.r8
    IL_00E8: ldnull
    IL_00E9: ldarg.1
    IL_00EA: nop
    IL_00EB: ldloc.0
    IL_00EC: ldarg.0
    IL_00ED: ldc.i4.m1
    IL_00F2: stfld 0x04001017
    IL_00F3: ldc.i4.0
    IL_00F4: ret
    IL_00F5: ldc.i4.1
    IL_00F6: ret
    IL_00F7: ldloc.1
    IL_00F8: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001017
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101B
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101B
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101A
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400101A
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 1242185072640
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: stsfld 0x00667340
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: stfld 0x0400101B
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x0400101A
    IL_003C: br IL_0144
    IL_003D: ldarg.0
    IL_0042: ldfld 0x0400101C
    IL_0047: ldfld 0x04000082
    IL_0048: ldc.i4.0
    IL_0049: IL_3D
    IL_004B: ldloc.s 0
    IL_004C: nop
    IL_004D: nop
    IL_004E: ldarg.0
    IL_0053: ldfld 0x0400101C
    IL_0054: ldc.i4.0
    IL_0059: call 0x06000027
    IL_005E: br IL_009C
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400101C
    IL_0069: ldfld 0x0400009E
    IL_006A: ldarg.0
    IL_006F: ldfld 0x0400101C
    IL_0074: ldfld 0x04000084
    IL_0075: ldarg.0
    IL_007A: ldfld 0x0400101C
    IL_007F: ldfld 0x04000082
    IL_0080: ldarg.0
    IL_0085: ldfld 0x0400101C
    IL_008A: ldfld 0x040000A7
    IL_008B: ldarg.0
    IL_0090: ldfld 0x0400101C
    IL_0095: ldfld 0x04000080
    IL_0096: ldc.i4.0
    IL_0097: conv.r8
    IL_0098: ldnull
    IL_0099: ldarg.1
    IL_009A: nop
    IL_009B: ldloc.0
    IL_009C: ldarg.0
    IL_00A1: ldfld 0x0400101C
    IL_00A6: ldfld 0x040000A8
    IL_00A7: conv.r8
    IL_00AA: ldloc 0
    IL_00AB: stloc.0
    IL_00AC: ldarg.0
    IL_00B1: ldfld 0x0400101C
    IL_00B6: ldfld 0x040000A8
    IL_00BB: ldstr 0x70000177
    IL_00BC: conv.r8
    IL_00BD: IL_3C
    IL_00BE: nop
    IL_00BF: nop
    IL_00C0: stloc.0
    IL_00C1: pop
    IL_00C2: ldarg.0
    IL_00C7: ldfld 0x0400101C
    IL_00CC: ldfld 0x0400009D
    IL_00CD: conv.r8
    IL_00CE: IL_35
    IL_00CF: IL_01
    IL_00D0: nop
    IL_00D1: ldloc.0
    IL_00D2: ldarg.0
    IL_00D7: ldfld 0x0400101C
    IL_00DC: ldfld 0x0400009F
    IL_00DD: ldarg.0
    IL_00E2: ldfld 0x0400101C
    IL_00E7: ldfld 0x040000A7
    IL_00E8: conv.r8
    IL_00E9: ldc.i4.2
    IL_00EA: nop
    IL_00EB: nop
    IL_00EC: stloc.0
    IL_00ED: ldarg.0
    IL_00F2: ldfld 0x0400101C
    IL_00F7: ldfld 0x04000095
    IL_00F8: conv.r8
    IL_00F9: IL_B9
    IL_00FA: ldarg.1
    IL_00FB: nop
    IL_00FC: ldloc.0
    IL_00FD: ldarg.0
    IL_0102: ldfld 0x0400101C
    IL_0103: IL_22
    IL_0104: nop
    IL_0105: nop
    IL_0106: nop
    IL_0107: nop
    IL_010C: stfld 0x0400007E
    IL_010D: ldarg.0
    IL_0112: ldfld 0x0400101C
    IL_0117: ldfld 0x0400009C
    IL_0118: ldc.i4.1
    IL_0119: conv.r8
    IL_011A: IL_EC
    IL_011B: ldarg.2
    IL_011C: nop
    IL_011D: ldloc.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x0400101C
    IL_0128: call 0x0A000003
    IL_0129: ldc.i4.1
    IL_012A: conv.r8
    IL_012C: ldc.i4.s 0
    IL_012D: nop
    IL_012E: stloc.0
    IL_012F: ldarg.0
    IL_0134: ldfld 0x0400101C
    IL_0135: ldc.i4.1
    IL_013A: stfld 0x0400006C
    IL_013B: ldarg.0
    IL_013C: ldc.i4.m1
    IL_0141: stfld 0x0400101A
    IL_0142: ldc.i4.0
    IL_0143: ret
    IL_0144: ldc.i4.1
    IL_0145: ret
    IL_0146: ldloc.1
    IL_0147: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400101A
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101E
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101E
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400101D
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400101D
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_37
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_005A
    IL_0021: ldarg.0
    IL_0026: ldfld 0x0400101F
    IL_002B: ldstr 0x70000CD1
    IL_0030: call 0x0A0000F9
    IL_0035: stfld 0x04000282
    IL_0036: ldarg.0
    IL_0037: ldarg.0
    IL_003C: ldfld 0x0400101F
    IL_0041: ldfld 0x04000282
    IL_0046: stfld 0x0400101E
    IL_0047: ldarg.0
    IL_0048: ldc.i4.1
    IL_004D: stfld 0x0400101D
    IL_0052: br IL_005C
    IL_0053: ldarg.0
    IL_0054: ldc.i4.m1
    IL_0059: stfld 0x0400101D
    IL_005A: ldc.i4.0
    IL_005B: ret
    IL_005C: ldc.i4.1
    IL_005D: ret
    IL_005E: ldloc.1
    IL_005F: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400101D
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001021
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001021
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001020
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001020
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 245752659968
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: ldelem.i
    IL_0024: IL_99
    IL_0025: IL_99
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001021
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001020
    IL_003C: br IL_005C
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001022
    IL_0047: ldfld 0x040002E1
    IL_0048: conv.r8
    IL_0049: IL_B0
    IL_004A: nop
    IL_004B: nop
    IL_004C: stloc.0
    IL_004D: ldc.i4.0
    IL_004E: conv.r8
    IL_004F: IL_B6
    IL_0050: nop
    IL_0051: nop
    IL_0052: stloc.0
    IL_0053: ldarg.0
    IL_0054: ldc.i4.m1
    IL_0059: stfld 0x04001020
    IL_005A: ldc.i4.0
    IL_005B: ret
    IL_005C: ldc.i4.1
    IL_005D: ret
    IL_005E: ldloc.1
    IL_005F: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001020
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001025
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001025
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001024
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001024
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_27
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_005B
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001027
    IL_002C: ldfld 0x040003C0
    IL_0031: newobj 0x0A000066
    IL_0036: stfld 0x04001025
    IL_0037: ldarg.0
    IL_0038: ldc.i4.1
    IL_003D: stfld 0x04001024
    IL_0042: br IL_005D
    IL_0043: ldarg.0
    IL_0048: ldfld 0x04001023
    IL_0049: conv.r8
    IL_004A: IL_B0
    IL_004B: nop
    IL_004C: nop
    IL_004D: stloc.0
    IL_004E: ldc.i4.0
    IL_004F: conv.r8
    IL_0050: IL_B6
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: ldarg.0
    IL_0055: ldc.i4.m1
    IL_005A: stfld 0x04001024
    IL_005B: ldc.i4.0
    IL_005C: ret
    IL_005D: ldc.i4.1
    IL_005E: ret
    IL_005F: ldloc.1
    IL_0060: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001024
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001029
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001029
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001028
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001028
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 361716776960
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001029
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001028
    IL_003C: br IL_0077
    IL_003D: IL_22
    IL_003E: nop
    IL_003F: nop
    IL_0044: stsfld 0x0111283F
    IL_0045: nop
    IL_0046: stloc.0
    IL_0047: ldarg.0
    IL_004C: ldfld 0x0400102A
    IL_0051: ldfld 0x040003CC
    IL_0052: conv.r8
    IL_0053: IL_3E
    IL_0054: nop
    IL_0055: nop
    IL_0057: br.s IL_006E
    IL_0058: ldarg.0
    IL_005D: ldfld 0x0400102A
    IL_0062: ldfld 0x040003E3
    IL_0063: conv.r8
    IL_0064: ldc.i4.2
    IL_0065: nop
    IL_0066: nop
    IL_0067: stloc.0
    IL_0068: ldc.i4.0
    IL_0069: conv.r8
    IL_006A: ldind.ref
    IL_006B: ldarg.0
    IL_006C: nop
    IL_006D: ldloc.0
    IL_006E: ldarg.0
    IL_006F: ldc.i4.m1
    IL_0074: stfld 0x04001028
    IL_0075: ldc.i4.0
    IL_0076: ret
    IL_0077: ldc.i4.1
    IL_0078: ret
    IL_0079: ldloc.1
    IL_007A: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001028
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400102C
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400102C
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400102B
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400102B
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 340241940480
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: rem
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400102B
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001030
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001030
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400102F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400102F
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 542105403392
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: IL_3F
    IL_002B: newobj 0x0A000066
    IL_0030: stfld 0x04001030
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x0400102F
    IL_003C: br IL_00A1
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001031
    IL_0047: ldfld 0x040003E4
    IL_0048: conv.r8
    IL_004B: ldloc 0
    IL_004C: stloc.0
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x04001031
    IL_0058: ldfld 0x040003E4
    IL_005D: ldstr 0x70000F3F
    IL_005E: conv.r8
    IL_0063: newobj 0x7D0A0000
    IL_0065: beq.s IL_0076
    IL_0066: nop
    IL_0067: ldarg.2
    IL_0068: ldarg.0
    IL_006D: ldfld 0x0400102E
    IL_006E: IL_22
    IL_006F: nop
    IL_0070: nop
    IL_0071: nop
    IL_0072: IL_3F
    IL_0073: conv.r8
    IL_0075: bgt.s IL_0076
    IL_0076: nop
    IL_0077: stloc.0
    IL_0078: ldarg.0
    IL_007D: ldfld 0x04001031
    IL_0082: ldfld 0x040003B1
    IL_0083: conv.r8
    IL_0084: IL_C7
    IL_0085: IL_01
    IL_0086: nop
    IL_0087: ldloc.0
    IL_0088: ldarg.0
    IL_008D: ldfld 0x04001031
    IL_0092: ldfld 0x040003B0
    IL_0093: conv.r8
    IL_0094: conv.u4
    IL_0095: IL_01
    IL_0096: nop
    IL_0097: ldloc.0
    IL_0098: ldarg.0
    IL_0099: ldc.i4.m1
    IL_009E: stfld 0x0400102F
    IL_009F: ldc.i4.0
    IL_00A0: ret
    IL_00A1: ldc.i4.1
    IL_00A2: ret
    IL_00A3: ldloc.1
    IL_00A4: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400102F
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001033
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001033
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001032
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001032
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 383191613440
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0029: stsfld 0x0066733F
    IL_002A: nop
    IL_002B: stloc.0
    IL_0030: stfld 0x04001033
    IL_0031: ldarg.0
    IL_0032: ldc.i4.1
    IL_0037: stfld 0x04001032
    IL_003C: br IL_007C
    IL_003D: ldarg.0
    IL_0042: ldfld 0x04001034
    IL_0047: ldfld 0x040003B1
    IL_0048: conv.r8
    IL_0049: IL_C7
    IL_004A: IL_01
    IL_004B: nop
    IL_004C: ldloc.0
    IL_004D: ldarg.0
    IL_0052: ldfld 0x04001034
    IL_0057: ldfld 0x040003B0
    IL_0058: conv.r8
    IL_0059: conv.u4
    IL_005A: IL_01
    IL_005B: nop
    IL_005C: ldloc.0
    IL_005D: ldarg.0
    IL_0062: ldfld 0x04001034
    IL_0067: call 0x0A00002A
    IL_006C: ldstr 0x700011D1
    IL_006D: conv.r8
    IL_006E: IL_3C
    IL_006F: nop
    IL_0070: nop
    IL_0071: stloc.0
    IL_0072: pop
    IL_0073: ldarg.0
    IL_0074: ldc.i4.m1
    IL_0079: stfld 0x04001032
    IL_007A: ldc.i4.0
    IL_007B: ret
    IL_007C: ldc.i4.1
    IL_007D: ret
    IL_007E: ldloc.1
    IL_007F: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001032
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104A
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104A
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001049
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001049
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_AD
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_043E
    IL_0021: ldarg.0
    IL_0026: newobj 0x0A0001A5
    IL_002B: stfld 0x04001035
    IL_002C: ldarg.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04001036
    IL_0033: conv.r8
    IL_0038: isinst 0x7D0A0001
    IL_0039: IL_37
    IL_003B: starg.s 0
    IL_003C: ldarg.2
    IL_0041: br IL_0074
    IL_0042: ldarg.0
    IL_0043: ldarg.0
    IL_0048: ldflda 0x04001037
    IL_004D: call 0x0A0001A7
    IL_0052: stfld 0x04001038
    IL_0053: ldarg.0
    IL_0058: ldfld 0x04001035
    IL_0059: ldarg.0
    IL_005E: ldflda 0x04001038
    IL_0063: call 0x0A0001A8
    IL_0064: ldarg.0
    IL_0069: ldflda 0x04001038
    IL_006E: call 0x0A0001A9
    IL_006F: conv.r8
    IL_0070: IL_AA
    IL_0071: IL_01
    IL_0072: nop
    IL_0073: stloc.0
    IL_0074: ldarg.0
    IL_0079: ldflda 0x04001037
    IL_007E: call 0x0A0001AB
    IL_0083: brtrue IL_0042
    IL_0084: IL_DD
    IL_0086: ldloc.s 0
    IL_0087: nop
    IL_0088: nop
    IL_0089: ldarg.0
    IL_008E: ldfld 0x04001037
    IL_0093: newobj 0x1B000007
    IL_0094: conv.r8
    IL_0095: ldelem.ref
    IL_0096: nop
    IL_0097: nop
    IL_0098: stloc.0
    IL_0099: IL_DC
    IL_009A: ldarg.0
    IL_009B: ldarg.0
    IL_00A0: ldfld 0x04001039
    IL_00A1: ldarg.0
    IL_00A6: ldfld 0x04001035
    IL_00AB: newobj 0x0A0001AC
    IL_00B0: stfld 0x0400103A
    IL_00B1: ldarg.0
    IL_00B2: ldarg.0
    IL_00B7: ldfld 0x0400103A
    IL_00BC: stfld 0x0400104A
    IL_00BD: ldarg.0
    IL_00BE: ldc.i4.1
    IL_00C3: stfld 0x04001049
    IL_00C8: br IL_0440
    IL_00C9: ldarg.0
    IL_00CE: ldfld 0x0400103A
    IL_00CF: conv.r8
    IL_00D0: IL_AD
    IL_00D1: IL_01
    IL_00D2: nop
    IL_00D3: stloc.0
    IL_00D8: brfalse IL_0107
    IL_00DD: ldstr 0x70002783
    IL_00DE: ldarg.0
    IL_00E3: ldfld 0x0400103A
    IL_00E4: conv.r8
    IL_00E5: IL_AD
    IL_00E6: IL_01
    IL_00E7: nop
    IL_00E8: stloc.0
    IL_00ED: call 0x0A000011
    IL_00F2: call 0x0A00013D
    IL_00F7: call 0x0600004E
    IL_00FC: ldstr 0x70002799
    IL_00FD: conv.r8
    IL_00FE: xor
    IL_00FF: nop
    IL_0100: nop
    IL_0101: ldloc.0
    IL_0106: br IL_0437
    IL_0107: ldarg.0
    IL_0108: ldarg.0
    IL_010D: ldfld 0x0400103A
    IL_010E: conv.r8
    IL_010F: IL_AE
    IL_0110: IL_01
    IL_0111: nop
    IL_0112: stloc.0
    IL_0117: call 0x060004AF
    IL_011C: stfld 0x0400103B
    IL_011D: ldarg.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x0400103B
    IL_0128: ldstr 0x7000279D
    IL_0129: conv.r8
    IL_1BC18013E: switch (1862664196 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001049
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104F
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400104E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400104E
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: and
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0085
    IL_0021: ldarg.0
    IL_0026: ldfld 0x04001050
    IL_002B: ldfld 0x040007BE
    IL_002C: ldc.i4.4
    IL_0099: switch (26 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400104E
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001055
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001055
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001054
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001054
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00A2
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001051
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x04001052
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04001052
    IL_003D: stfld 0x04001055
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x04001054
    IL_0049: br IL_00A4
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04001052
    IL_0050: conv.r8
    IL_0051: IL_AD
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0059: brtrue IL_0077
    IL_005A: ldarg.0
    IL_005F: ldfld 0x04001058
    IL_0064: ldfld 0x04000882
    IL_0065: ldarg.0
    IL_006A: ldfld 0x04001053
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04001052
    IL_0071: conv.r8
    IL_0072: IL_FC
    IL_0073: IL_01
    IL_0074: nop
    IL_0075: stloc.0
    IL_007A: stelem 0x10587B02
    IL_007B: nop
    IL_007C: ldarg.2
    IL_0081: ldfld 0x04000888
    IL_0082: ldc.i4.1
    IL_0083: IL_59
    IL_0084: ldarg.0
    IL_0089: ldfld 0x04001053
    IL_00BE: switch (12 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001054
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105A
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105A
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_77
    IL_0003: ldloc.1
    IL_0004: nop
    IL_0005: ldloc.0
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x04001059
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x06000773
    IL_0019: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001059
    IL_0006: ldarg.0
    IL_0007: ldc.i4.m1
    IL_000C: stfld 0x04001059
    IL_0011: brtrue IL_0017
    IL_0016: br IL_0017
    IL_0017: ldc.i4.0
    IL_0018: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001059
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001060
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001060
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0006: ldsflda 0x2A060007
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x0400105F
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x0600077B
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04001061
    IL_0025: stfld 0x04001061
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400105F
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_0116
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001061
    IL_002A: conv.r8
    IL_002D: ldloca 4
    IL_002E: ldloc.0
    IL_002F: conv.r8
    IL_0038: ldc.i8 288248361277587458
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0045: bge.s IL_0046
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_00E1
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldfld 0x0400105B
    IL_0054: conv.r8
    IL_0055: IL_22
    IL_0056: ldarg.0
    IL_0057: nop
    IL_0058: stloc.0
    IL_005D: stfld 0x0400105C
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x0400105C
    IL_0065: conv.r8
    IL_0068: stloc 4
    IL_0069: ldloc.0
    IL_006A: conv.r8
    IL_0073: ldc.i8 288248369867522050
    IL_0075: ldc.i4.s -3
    IL_0076: stloc.0
    IL_0077: ldloc.0
    IL_0078: ldc.i4.1
    IL_0079: IL_59
    IL_007C: ldarg 1
    IL_007D: nop
    IL_007E: nop
    IL_0080: bgt.s IL_0081
    IL_0081: nop
    IL_0082: nop
    IL_0087: br IL_00B3
    IL_0088: ldarg.0
    IL_0089: ldarg.0
    IL_008E: ldfld 0x0400105D
    IL_008F: conv.r8
    IL_0090: IL_22
    IL_0091: ldarg.0
    IL_0092: nop
    IL_0093: stloc.0
    IL_0098: stfld 0x0400105E
    IL_0099: ldarg.0
    IL_009A: ldarg.0
    IL_009F: ldfld 0x0400105E
    IL_00A4: stfld 0x04001060
    IL_00A5: ldarg.0
    IL_00A6: ldc.i4.1
    IL_00AB: stfld 0x0400105F
    IL_00AC: ldc.i4.1
    IL_00AD: stloc.1
    IL_00AE: IL_DD
    IL_00AF: shl
    IL_00B0: nop
    IL_00B1: nop
    IL_00B2: nop
    IL_00B3: ldarg.0
    IL_00B8: ldfld 0x0400105D
    IL_00B9: conv.r8
    IL_00BA: IL_99
    IL_00BB: IL_01
    IL_00BC: nop
    IL_00BD: stloc.0
    IL_00C2: brtrue IL_0088
    IL_00C3: IL_DD
    IL_00C4: ldc.i4.3
    IL_00C5: nop
    IL_00C6: nop
    IL_00C7: nop
    IL_00C8: ldloc.1
    IL_00CA: brfalse.s IL_00CC
    IL_00CB: IL_DC
    IL_00CC: ldarg.0
    IL_00D1: ldfld 0x0400105D
    IL_00D3: brtrue.s IL_00D5
    IL_00D4: IL_DC
    IL_00D5: ldarg.0
    IL_00DA: ldfld 0x0400105D
    IL_00DB: conv.r8
    IL_00DC: ldelem.ref
    IL_00DD: nop
    IL_00DE: nop
    IL_00DF: stloc.0
    IL_00E0: IL_DC
    IL_00E1: ldarg.0
    IL_00E6: ldfld 0x0400105B
    IL_00E7: conv.r8
    IL_00E8: IL_99
    IL_00E9: IL_01
    IL_00EA: nop
    IL_00EB: stloc.0
    IL_00F0: brtrue IL_004D
    IL_00F1: IL_DD
    IL_00F2: ldc.i4.3
    IL_00F3: nop
    IL_00F4: nop
    IL_00F5: nop
    IL_00F6: ldloc.1
    IL_00F8: brfalse.s IL_00FA
    IL_00F9: IL_DC
    IL_00FA: ldarg.0
    IL_00FF: ldfld 0x0400105B
    IL_0101: brtrue.s IL_0103
    IL_0102: IL_DC
    IL_0103: ldarg.0
    IL_0108: ldfld 0x0400105B
    IL_0109: conv.r8
    IL_010A: ldelem.ref
    IL_010B: nop
    IL_010C: nop
    IL_010D: stloc.0
    IL_010E: IL_DC
    IL_010F: ldarg.0
    IL_0110: ldc.i4.m1
    IL_0115: stfld 0x0400105F
    IL_0116: ldc.i4.0
    IL_0117: ret
    IL_0118: ldc.i4.1
    IL_0119: ret
    IL_011A: ldloc.2
    IL_011B: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400105F
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400105F
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0018: brfalse IL_5000019
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0055
    IL_0021: IL_DD
    IL_0022: ldc.i4.m1
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400105D
    IL_002D: brtrue.s IL_002F
    IL_002E: IL_DC
    IL_002F: ldarg.0
    IL_0034: ldfld 0x0400105D
    IL_0035: conv.r8
    IL_0036: ldelem.ref
    IL_0037: nop
    IL_0038: nop
    IL_0039: stloc.0
    IL_003A: IL_DC
    IL_003B: IL_DD
    IL_003C: ldc.i4.m1
    IL_003D: nop
    IL_003E: nop
    IL_003F: nop
    IL_0040: ldarg.0
    IL_0045: ldfld 0x0400105B
    IL_0047: brtrue.s IL_0049
    IL_0048: IL_DC
    IL_0049: ldarg.0
    IL_004E: ldfld 0x0400105B
    IL_004F: conv.r8
    IL_0050: ldelem.ref
    IL_0051: nop
    IL_0052: nop
    IL_0053: stloc.0
    IL_0054: IL_DC
    IL_0055: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001065
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001065
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_87
    IL_0003: ldloc.1
    IL_0004: nop
    IL_0005: ldloc.0
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x04001064
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x06000783
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04001066
    IL_0025: stfld 0x04001066
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001064
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001064
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_00A9
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001066
    IL_002E: ldfld 0x040008D8
    IL_002F: conv.r8
    IL_0030: ret
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x04001062
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0045: bgt.s IL_0046
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_0078
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x04001062
    IL_0058: call 0x0A00022B
    IL_005D: stfld 0x04001063
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04001063
    IL_0069: stfld 0x04001065
    IL_006A: ldarg.0
    IL_006B: ldc.i4.1
    IL_0070: stfld 0x04001064
    IL_0071: ldc.i4.1
    IL_0072: stloc.1
    IL_0073: IL_DD
    IL_0075: bne.un.s IL_0076
    IL_0076: nop
    IL_0077: nop
    IL_0078: ldarg.0
    IL_007D: ldflda 0x04001062
    IL_0082: call 0x0A00022C
    IL_0087: brtrue IL_004D
    IL_0088: IL_DD
    IL_0089: ldc.i4.m1
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: ldloc.1
    IL_008F: brfalse.s IL_0091
    IL_0090: IL_DC
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04001062
    IL_009B: newobj 0x1B00000D
    IL_009C: conv.r8
    IL_009D: ldelem.ref
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: IL_DC
    IL_00A2: ldarg.0
    IL_00A3: ldc.i4.m1
    IL_00A8: stfld 0x04001064
    IL_00A9: ldc.i4.0
    IL_00AA: ret
    IL_00AB: ldc.i4.1
    IL_00AC: ret
    IL_00AD: ldloc.2
    IL_00AE: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001064
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001064
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.5
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0037
    IL_0021: IL_DD
    IL_0023: ldloc.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04001062
    IL_0030: newobj 0x1B00000D
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106A
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106A
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001069
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001069
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_00A9
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x0400106B
    IL_002E: ldfld 0x040008D8
    IL_002F: conv.r8
    IL_0030: ret
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x04001067
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0045: bgt.s IL_0046
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_0078
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x04001067
    IL_0058: call 0x0A00022B
    IL_005D: stfld 0x04001068
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04001068
    IL_0069: stfld 0x0400106A
    IL_006A: ldarg.0
    IL_006B: ldc.i4.1
    IL_0070: stfld 0x04001069
    IL_0071: ldc.i4.1
    IL_0072: stloc.1
    IL_0073: IL_DD
    IL_0075: bne.un.s IL_0076
    IL_0076: nop
    IL_0077: nop
    IL_0078: ldarg.0
    IL_007D: ldflda 0x04001067
    IL_0082: call 0x0A00022C
    IL_0087: brtrue IL_004D
    IL_0088: IL_DD
    IL_0089: ldc.i4.m1
    IL_008A: nop
    IL_008B: nop
    IL_008C: nop
    IL_008D: ldloc.1
    IL_008F: brfalse.s IL_0091
    IL_0090: IL_DC
    IL_0091: ldarg.0
    IL_0096: ldfld 0x04001067
    IL_009B: newobj 0x1B00000D
    IL_009C: conv.r8
    IL_009D: ldelem.ref
    IL_009E: nop
    IL_009F: nop
    IL_00A0: stloc.0
    IL_00A1: IL_DC
    IL_00A2: ldarg.0
    IL_00A3: ldc.i4.m1
    IL_00A8: stfld 0x04001069
    IL_00A9: ldc.i4.0
    IL_00AA: ret
    IL_00AB: ldc.i4.1
    IL_00AC: ret
    IL_00AD: ldloc.2
    IL_00AE: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001069
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001069
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.5
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0037
    IL_0021: IL_DD
    IL_0023: ldloc.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04001067
    IL_0030: newobj 0x1B00000D
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<LitJson.JSONNode>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerable.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: IL_95
    IL_0003: ldloc.1
    IL_0004: nop
    IL_0005: ldloc.0
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerable<LitJson.JSONNode>.GetEnumerator() {
    IL_0000: ldarg.0
    IL_0005: ldflda 0x0400106E
    IL_0006: ldc.i4.0
    IL_0008: ldc.i4.s -2
    IL_000D: call 0x0A000220
    IL_000F: ldc.i4.s -2
    IL_0011: bne.un.s IL_0014
    IL_0012: ldarg.0
    IL_0013: ret
    IL_0018: newobj 0x06000791
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_0020: ldfld 0x04001070
    IL_0025: stfld 0x04001070
    IL_0026: ldloc.0
    IL_0027: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400106E
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_00AE
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001070
    IL_002E: ldfld 0x040008D9
    IL_002F: conv.r8
    IL_0030: IL_3E
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x0400106C
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_35
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_007D
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x0400106C
    IL_0058: call 0x0A00023F
    IL_005D: stfld 0x0400106D
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldflda 0x0400106D
    IL_0069: call 0x0A000236
    IL_006E: stfld 0x0400106F
    IL_006F: ldarg.0
    IL_0070: ldc.i4.1
    IL_0075: stfld 0x0400106E
    IL_0076: ldc.i4.1
    IL_0077: stloc.1
    IL_0078: IL_DD
    IL_007A: bne.un.s IL_007B
    IL_007B: nop
    IL_007C: nop
    IL_007D: ldarg.0
    IL_0082: ldflda 0x0400106C
    IL_0087: call 0x0A000241
    IL_008C: brtrue IL_004D
    IL_008D: IL_DD
    IL_008E: ldc.i4.m1
    IL_008F: nop
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldloc.1
    IL_0094: brfalse.s IL_0096
    IL_0095: IL_DC
    IL_0096: ldarg.0
    IL_009B: ldfld 0x0400106C
    IL_00A0: newobj 0x1B000011
    IL_00A1: conv.r8
    IL_00A2: ldelem.ref
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00A6: IL_DC
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4.m1
    IL_00AD: stfld 0x0400106E
    IL_00AE: ldc.i4.0
    IL_00AF: ret
    IL_00B0: ldc.i4.1
    IL_00B1: ret
    IL_00B2: ldloc.2
    IL_00B3: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400106E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400106E
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.5
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0037
    IL_0021: IL_DD
    IL_0023: ldloc.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x0400106C
    IL_0030: newobj 0x1B000011
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001074
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001074
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001073
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001073
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0013: ldarg 2
    IL_0014: nop
    IL_0015: nop
    IL_0016: ldarg.3
    IL_0017: nop
    IL_0018: nop
    IL_0019: nop
    IL_001A: ldc.i4.8
    IL_001B: nop
    IL_001C: nop
    IL_001D: nop
    IL_0022: br IL_00AE
    IL_0023: ldarg.0
    IL_0024: ldarg.0
    IL_0029: ldfld 0x04001075
    IL_002E: ldfld 0x040008D9
    IL_002F: conv.r8
    IL_0030: IL_3E
    IL_0031: ldarg.0
    IL_0032: nop
    IL_0033: stloc.0
    IL_0038: stfld 0x04001071
    IL_003A: ldc.i4.s -3
    IL_003B: stloc.0
    IL_003C: ldloc.0
    IL_003D: ldc.i4.1
    IL_003E: IL_59
    IL_0041: ldarg 1
    IL_0042: nop
    IL_0043: nop
    IL_0044: IL_35
    IL_0045: nop
    IL_0046: nop
    IL_0047: nop
    IL_004C: br IL_007D
    IL_004D: ldarg.0
    IL_004E: ldarg.0
    IL_0053: ldflda 0x04001071
    IL_0058: call 0x0A00023F
    IL_005D: stfld 0x04001072
    IL_005E: ldarg.0
    IL_005F: ldarg.0
    IL_0064: ldfld 0x04001072
    IL_0069: newobj 0x1B00000F
    IL_006E: stfld 0x04001074
    IL_006F: ldarg.0
    IL_0070: ldc.i4.1
    IL_0075: stfld 0x04001073
    IL_0076: ldc.i4.1
    IL_0077: stloc.1
    IL_0078: IL_DD
    IL_007A: bne.un.s IL_007B
    IL_007B: nop
    IL_007C: nop
    IL_007D: ldarg.0
    IL_0082: ldflda 0x04001071
    IL_0087: call 0x0A000241
    IL_008C: brtrue IL_004D
    IL_008D: IL_DD
    IL_008E: ldc.i4.m1
    IL_008F: nop
    IL_0090: nop
    IL_0091: nop
    IL_0092: ldloc.1
    IL_0094: brfalse.s IL_0096
    IL_0095: IL_DC
    IL_0096: ldarg.0
    IL_009B: ldfld 0x04001071
    IL_00A0: newobj 0x1B000011
    IL_00A1: conv.r8
    IL_00A2: ldelem.ref
    IL_00A3: nop
    IL_00A4: nop
    IL_00A5: stloc.0
    IL_00A6: IL_DC
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4.m1
    IL_00AD: stfld 0x04001073
    IL_00AE: ldc.i4.0
    IL_00AF: ret
    IL_00B0: ldc.i4.1
    IL_00B1: ret
    IL_00B2: ldloc.2
    IL_00B3: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001073
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001073
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldc.i4.5
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: ldarg.3
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0037
    IL_0021: IL_DD
    IL_0023: ldloc.s 0
    IL_0024: nop
    IL_0025: nop
    IL_0026: ldarg.0
    IL_002B: ldfld 0x04001071
    IL_0030: newobj 0x1B000011
    IL_0031: conv.r8
    IL_0032: ldelem.ref
    IL_0033: nop
    IL_0034: nop
    IL_0035: stloc.0
    IL_0036: IL_DC
    IL_0037: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001079
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001079
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001078
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001078
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_007D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001076
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x04001077
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04001077
    IL_003D: stfld 0x04001079
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x04001078
    IL_0049: br IL_007F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04001077
    IL_0050: conv.r8
    IL_0051: IL_FC
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_0056: conv.u4
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldc.i4.8
    IL_005B: IL_3E
    IL_005C: ldc.i4.0
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400107B
    IL_0066: ldarg.0
    IL_006B: ldfld 0x04001077
    IL_006C: conv.r8
    IL_006D: IL_FC
    IL_006E: IL_01
    IL_006F: nop
    IL_0070: stloc.0
    IL_0075: stfld 0x04000ABA
    IL_0076: ldarg.0
    IL_0077: ldc.i4.m1
    IL_007C: stfld 0x04001078
    IL_007D: ldc.i4.0
    IL_007E: ret
    IL_007F: ldc.i4.1
    IL_0080: ret
    IL_0081: ldloc.1
    IL_0082: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001078
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400107F
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400107F
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400107E
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400107E
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_007D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400107C
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x0400107D
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400107D
    IL_003D: stfld 0x0400107F
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x0400107E
    IL_0049: br IL_007F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x0400107D
    IL_0050: conv.r8
    IL_0051: IL_FC
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_0056: conv.u4
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldc.i4.8
    IL_005B: IL_3E
    IL_005C: ldc.i4.0
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x04001081
    IL_0066: ldarg.0
    IL_006B: ldfld 0x0400107D
    IL_006C: conv.r8
    IL_006D: IL_FC
    IL_006E: IL_01
    IL_006F: nop
    IL_0070: stloc.0
    IL_0075: stfld 0x04000B2D
    IL_0076: ldarg.0
    IL_0077: ldc.i4.m1
    IL_007C: stfld 0x0400107E
    IL_007D: ldc.i4.0
    IL_007E: ret
    IL_007F: ldc.i4.1
    IL_0080: ret
    IL_0081: ldloc.1
    IL_0082: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400107E
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001087
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001087
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001086
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001086
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_001C: brfalse IL_3800001D
    IL_001D: ldelem.i4
    IL_001E: nop
    IL_001F: nop
    IL_0020: nop
    IL_0021: ldarg.0
    IL_0026: ldstr 0x70023451
    IL_002B: stfld 0x04001082
    IL_002C: ldarg.0
    IL_002D: ldarg.0
    IL_0032: ldfld 0x04001082
    IL_0037: newobj 0x0A0001FB
    IL_003C: stfld 0x04001083
    IL_003D: ldarg.0
    IL_003E: ldarg.0
    IL_0043: ldfld 0x04001083
    IL_0048: stfld 0x04001087
    IL_0049: ldarg.0
    IL_004A: ldc.i4.1
    IL_004F: stfld 0x04001086
    IL_0054: br IL_00C0
    IL_0055: ldarg.0
    IL_0056: ldarg.0
    IL_005B: ldfld 0x04001083
    IL_005C: conv.r8
    IL_005D: IL_AE
    IL_005E: IL_01
    IL_005F: nop
    IL_0060: stloc.0
    IL_0065: stfld 0x04001084
    IL_0066: ldarg.0
    IL_0067: ldarg.0
    IL_006C: ldfld 0x04001084
    IL_0071: call 0x0A0002FC
    IL_0076: stfld 0x04001085
    IL_0077: ldarg.0
    IL_007C: ldfld 0x04001088
    IL_007D: ldarg.0
    IL_0082: ldfld 0x04001088
    IL_0083: ldarg.0
    IL_0088: ldfld 0x04001085
    IL_008D: ldstr 0x700234BB
    IL_008E: conv.r8
    IL_008F: IL_FD
    IL_0090: ldarg.0
    IL_0091: nop
    IL_0092: stloc.0
    IL_0097: ldstr 0x700234CB
    IL_0098: conv.r8
    IL_0099: IL_FD
    IL_009A: ldarg.0
    IL_009B: nop
    IL_009C: stloc.0
    IL_00A1: ldstr 0x700234D5
    IL_00A2: conv.r8
    IL_00A3: IL_FD
    IL_00A4: ldarg.0
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00AB: call 0x0A0002FE
    IL_00B0: call 0x060005FA
    IL_00B5: call 0x0A000047
    IL_00B6: pop
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4.m1
    IL_00BD: stfld 0x04001086
    IL_00BE: ldc.i4.0
    IL_00BF: ret
    IL_00C0: ldc.i4.1
    IL_00C1: ret
    IL_00C2: ldloc.1
    IL_00C3: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001086
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400108C
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400108C
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400108B
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400108B
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_0051
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001089
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x0400108A
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x0400108A
    IL_003D: stfld 0x0400108C
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x0400108B
    IL_0049: br IL_0053
    IL_004A: ldarg.0
    IL_004B: ldc.i4.m1
    IL_0050: stfld 0x0400108B
    IL_0051: ldc.i4.0
    IL_0052: ret
    IL_0053: ldc.i4.1
    IL_0054: ret
    IL_0055: ldloc.1
    IL_0056: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400108B
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001095
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001095
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04001094
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x04001094
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_4E
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_01F9
    IL_0021: ldarg.0
    IL_0026: ldstr 0x700234DD
    IL_0027: ldarg.0
    IL_002C: ldfld 0x04001096
    IL_0031: ldfld 0x04000B48
    IL_0036: ldstr 0x70023545
    IL_003B: call 0x0A0000ED
    IL_0040: stfld 0x0400108E
    IL_0041: ldarg.0
    IL_0042: ldarg.0
    IL_0047: ldfld 0x0400108E
    IL_004C: newobj 0x0A0001FB
    IL_0051: stfld 0x0400108F
    IL_0052: ldarg.0
    IL_0053: ldarg.0
    IL_0058: ldfld 0x0400108F
    IL_005D: stfld 0x04001095
    IL_005E: ldarg.0
    IL_005F: ldc.i4.1
    IL_0064: stfld 0x04001094
    IL_0069: br IL_01FB
    IL_006A: ldarg.0
    IL_006B: ldarg.0
    IL_0070: ldfld 0x0400108F
    IL_0071: conv.r8
    IL_0072: IL_AE
    IL_0073: IL_01
    IL_0074: nop
    IL_0075: stloc.0
    IL_007A: stfld 0x04001090
    IL_007B: ldarg.0
    IL_007C: ldarg.0
    IL_0081: ldfld 0x04001090
    IL_0086: call 0x0A0002FC
    IL_008B: stfld 0x04001091
    IL_008C: ldarg.0
    IL_0091: ldfld 0x04001096
    IL_0092: ldarg.0
    IL_0097: ldfld 0x04001091
    IL_009C: ldstr 0x700234CB
    IL_009D: conv.r8
    IL_009E: IL_FD
    IL_009F: ldarg.0
    IL_00A0: nop
    IL_00A1: stloc.0
    IL_00A2: conv.r8
    IL_00A3: IL_FF
    IL_00A4: ldarg.0
    IL_00A5: nop
    IL_00A6: stloc.0
    IL_00AB: stfld 0x04000B23
    IL_00AC: ldarg.0
    IL_00B1: newobj 0x0A0002F9
    IL_00B6: stfld 0x04001092
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4.0
    IL_00BD: stfld 0x04001093
    IL_00C2: br IL_01DC
    IL_00C3: ldarg.0
    IL_00C8: ldfld 0x04001096
    IL_00CD: ldfld 0x04000B20
    IL_00CE: ldarg.0
    IL_00D3: ldfld 0x04001093
    IL_00D4: IL_8F
    IL_00D6: ldarg.s 1
    IL_00D7: nop
    IL_00D8: ldarg.0
    IL_00D9: ldarg.0
    IL_00DE: ldfld 0x04001091
    IL_00E3: ldstr 0x700234CB
    IL_00E4: conv.r8
    IL_00E5: IL_FD
    IL_00E6: ldarg.0
    IL_00E7: nop
    IL_00E8: stloc.0
    IL_00E9: ldarg.0
    IL_00EE: ldfld 0x04001093
    IL_00EF: conv.r8
    IL_00F0: nop
    IL_00F1: ldarg.1
    IL_00F2: nop
    IL_00F3: stloc.0
    IL_00F8: ldstr 0x70023575
    IL_00F9: conv.r8
    IL_00FA: IL_FD
    IL_00FB: ldarg.0
    IL_00FC: nop
    IL_00FD: stloc.0
    IL_0102: call 0x0A0002FE
    IL_0107: stfld 0x04000B4A
    IL_0108: ldarg.0
    IL_010D: ldfld 0x04001096
    IL_0112: ldfld 0x04000B20
    IL_0113: ldarg.0
    IL_0118: ldfld 0x04001093
    IL_0119: IL_8F
    IL_011B: ldarg.s 1
    IL_011C: nop
    IL_011D: ldarg.0
    IL_011E: ldarg.0
    IL_0123: ldfld 0x04001091
    IL_0128: ldstr 0x700234CB
    IL_0129: conv.r8
    IL_012A: IL_FD
    IL_012B: ldarg.0
    IL_012C: nop
    IL_012D: stloc.0
    IL_012E: ldarg.0
    IL_0133: ldfld 0x04001093
    IL_0134: conv.r8
    IL_0135: nop
    IL_0136: ldarg.1
    IL_0137: nop
    IL_0138: stloc.0
    IL_013D: ldstr 0x7002357B
    IL_013E: conv.r8
    IL_013F: IL_FD
    IL_0140: ldarg.0
    IL_0141: nop
    IL_0142: stloc.0
    IL_0147: call 0x0A0002FE
    IL_014C: stfld 0x04000B4C
    IL_014D: ldarg.0
    IL_0152: ldfld 0x04001096
    IL_0153: ldarg.0
    IL_0158: ldfld 0x04001096
    IL_0159: ldarg.0
    IL_015E: ldfld 0x04001091
    IL_0163: ldstr 0x700234CB
    IL_0164: conv.r8
    IL_0165: IL_FD
    IL_0166: ldarg.0
    IL_0167: nop
    IL_0168: stloc.0
    IL_0169: ldarg.0
    IL_016E: ldfld 0x04001093
    IL_016F: conv.r8
    IL_0170: nop
    IL_0171: ldarg.1
    IL_0172: nop
    IL_0173: stloc.0
    IL_0178: ldstr 0x700234BB
    IL_0179: conv.r8
    IL_017A: IL_FD
    IL_017B: ldarg.0
    IL_017C: nop
    IL_017D: stloc.0
    IL_0182: ldstr 0x700234CB
    IL_0183: conv.r8
    IL_0184: IL_FD
    IL_0185: ldarg.0
    IL_0186: nop
    IL_0187: stloc.0
    IL_018C: ldstr 0x700234D5
    IL_018D: conv.r8
    IL_018E: IL_FD
    IL_018F: ldarg.0
    IL_0190: nop
    IL_0191: stloc.0
    IL_0196: call 0x0A0002FE
    IL_0197: ldarg.0
    IL_019C: ldfld 0x04001093
    IL_01A1: call 0x060005FC
    IL_01A6: call 0x0A000047
    IL_01A7: pop
    IL_01A8: ldarg.0
    IL_01AD: ldfld 0x04001092
    IL_01AE: ldarg.0
    IL_01B3: ldfld 0x04001096
    IL_01B8: ldfld 0x04000B20
    IL_01B9: ldarg.0
    IL_01BE: ldfld 0x04001093
    IL_01BF: IL_8F
    IL_01C1: ldarg.s 1
    IL_01C2: nop
    IL_01C3: ldarg.0
    IL_01C8: ldfld 0x04000B4A
    IL_01C9: conv.r8
    IL_01CA: IL_FA
    IL_01CB: ldarg.0
    IL_01CC: nop
    IL_01CD: stloc.0
    IL_01CE: ldarg.0
    IL_01CF: ldarg.0
    IL_01D4: ldfld 0x04001093
    IL_01D5: ldc.i4.1
    IL_01D6: IL_58
    IL_01DB: stfld 0x04001093
    IL_01DC: ldarg.0
    IL_01E1: ldfld 0x04001093
    IL_01E2: ldarg.0
    IL_01E7: ldfld 0x04001096
    IL_01EC: ldfld 0x04000B23
    IL_01ED: IL_3F
    IL_01EE: IL_D1
    IL_01F0: 0xFE FF
    IL_01F1: IL_FF
    IL_01F2: ldarg.0
    IL_01F3: ldc.i4.m1
    IL_01F8: stfld 0x04001094
    IL_01F9: ldc.i4.0
    IL_01FA: ret
    IL_01FB: ldc.i4.1
    IL_01FC: ret
    IL_01FD: ldloc.1
    IL_01FE: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x04001094
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400109B
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400109B
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x0400109A
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x0400109A
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_008D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x04001097
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x04001098
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x04001098
    IL_003D: stfld 0x0400109B
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x0400109A
    IL_0049: br IL_008F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x04001098
    IL_0050: conv.r8
    IL_0051: IL_FC
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_0056: conv.u4
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldc.i4.8
    IL_005B: IL_3E
    IL_005C: pop
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x0400109E
    IL_006A: ldfld 0x04000B20
    IL_006B: ldarg.0
    IL_0070: ldfld 0x04001099
    IL_0071: IL_8F
    IL_0073: ldarg.s 1
    IL_0074: nop
    IL_0075: ldarg.0
    IL_0076: ldarg.0
    IL_007B: ldfld 0x04001098
    IL_007C: conv.r8
    IL_007D: IL_FC
    IL_007E: IL_01
    IL_007F: nop
    IL_0080: stloc.0
    IL_0085: stfld 0x04000B4D
    IL_0086: ldarg.0
    IL_0087: ldc.i4.m1
    IL_008C: stfld 0x0400109A
    IL_008D: ldc.i4.0
    IL_008E: ret
    IL_008F: ldc.i4.1
    IL_0090: ret
    IL_0091: ldloc.1
    IL_0092: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x0400109A
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A3
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A3
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A2
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010A2
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00D5
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x0400109F
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x040010A0
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040010A0
    IL_003D: stfld 0x040010A3
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x040010A2
    IL_0049: br IL_00D7
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040010A0
    IL_0050: conv.r8
    IL_0051: IL_FC
    IL_0052: IL_01
    IL_0053: nop
    IL_0054: stloc.0
    IL_0055: conv.r8
    IL_0056: conv.u4
    IL_0057: ldarg.0
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldc.i4.8
    IL_005B: IL_3E
    IL_005C: conv.r4
    IL_005D: nop
    IL_005E: nop
    IL_005F: nop
    IL_0060: ldarg.0
    IL_0065: ldfld 0x040010A6
    IL_006A: ldfld 0x04000B44
    IL_006B: stloc.1
    IL_006C: ldloc.1
    IL_006D: ldc.i4.0
    IL_0072: beq IL_0078
    IL_0077: br IL_00A3
    IL_0078: ldarg.0
    IL_007D: ldfld 0x040010A6
    IL_0082: ldfld 0x04000B21
    IL_0083: ldarg.0
    IL_0088: ldfld 0x040010A1
    IL_0089: IL_8F
    IL_008B: ldarga.s 1
    IL_008C: nop
    IL_008D: ldarg.0
    IL_008E: ldarg.0
    IL_0093: ldfld 0x040010A0
    IL_0094: conv.r8
    IL_0095: IL_FC
    IL_0096: IL_01
    IL_0097: nop
    IL_0098: stloc.0
    IL_009D: stfld 0x04000B51
    IL_00A2: br IL_00CE
    IL_00A3: ldarg.0
    IL_00A8: ldfld 0x040010A6
    IL_00AD: ldfld 0x04000B22
    IL_00AE: ldarg.0
    IL_00B3: ldfld 0x040010A1
    IL_00B4: IL_8F
    IL_00B6: starg.s 1
    IL_00B7: nop
    IL_00B8: ldarg.0
    IL_00B9: ldarg.0
    IL_00BE: ldfld 0x040010A0
    IL_00BF: conv.r8
    IL_00C0: IL_FC
    IL_00C1: IL_01
    IL_00C2: nop
    IL_00C3: stloc.0
    IL_00C8: stfld 0x04000B54
    IL_00CD: br IL_00CE
    IL_00CE: ldarg.0
    IL_00CF: ldc.i4.m1
    IL_00D4: stfld 0x040010A2
    IL_00D5: ldc.i4.0
    IL_00D6: ret
    IL_00D7: ldc.i4.1
    IL_00D8: ret
    IL_00D9: ldloc.2
    IL_00DA: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010A2
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A8
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A8
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010A7
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010A7
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0020: ldc.i8 1096156184576
    IL_0021: ldarg.0
    IL_0022: IL_22
    IL_0023: nop
    IL_0024: nop
    IL_0025: nop
    IL_199F6: switch (26227 cases)
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010A7
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010AD
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010AD
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010AC
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010AC
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0019: beq.s IL_001A
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_007D
    IL_0021: ldarg.0
    IL_0022: ldarg.0
    IL_0027: ldfld 0x040010AA
    IL_002C: newobj 0x0A0001FB
    IL_0031: stfld 0x040010AB
    IL_0032: ldarg.0
    IL_0033: ldarg.0
    IL_0038: ldfld 0x040010AB
    IL_003D: stfld 0x040010AD
    IL_003E: ldarg.0
    IL_003F: ldc.i4.1
    IL_0044: stfld 0x040010AC
    IL_0049: br IL_007F
    IL_004A: ldarg.0
    IL_004F: ldfld 0x040010AF
    IL_0054: ldfld 0x04000E0E
    IL_0055: conv.r8
    IL_0056: ldc.i4.8
    IL_0057: ldarg.1
    IL_0058: nop
    IL_0059: stloc.0
    IL_005A: ldarg.0
    IL_005F: ldfld 0x040010AB
    IL_0060: conv.r8
    IL_0061: IL_FC
    IL_0062: IL_01
    IL_0063: nop
    IL_0064: stloc.0
    IL_0065: conv.r8
    IL_0067: ldc.i4.s 3
    IL_0068: nop
    IL_0069: stloc.0
    IL_006A: ldarg.0
    IL_006F: ldfld 0x040010AF
    IL_0070: ldc.i4.1
    IL_0075: stfld 0x04000E14
    IL_0076: ldarg.0
    IL_0077: ldc.i4.m1
    IL_007C: stfld 0x040010AC
    IL_007D: ldc.i4.0
    IL_007E: ret
    IL_007F: ldc.i4.1
    IL_0080: ret
    IL_0081: ldloc.1
    IL_0082: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010AC
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private virtual void System.Collections.Generic.IEnumerator<object>.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010B2
    IL_0006: ret
    }

    private virtual void System.Collections.IEnumerator.get_Current() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010B2
    IL_0006: ret
    }

    public virtual void MoveNext() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x040010B1
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldc.i4.m1
    IL_000D: stfld 0x040010B1
    IL_000E: ldloc.0
    IL_0011: ldarg 2
    IL_0012: nop
    IL_0013: nop
    IL_0014: ldarg.3
    IL_0015: nop
    IL_0016: nop
    IL_0017: nop
    IL_0018: IL_44
    IL_0019: nop
    IL_001A: nop
    IL_001B: nop
    IL_0020: br IL_00A3
    IL_0021: ldarg.0
    IL_0026: ldfld 0x040010B4
    IL_0027: ldarg.0
    IL_002C: ldfld 0x040010B4
    IL_0031: ldfld 0x04000FA7
    IL_0032: ldarg.0
    IL_0037: ldfld 0x040010B0
    IL_0038: ldelem.i
    IL_003D: newobj 0x0A0001FB
    IL_0042: stfld 0x04000FAB
    IL_0043: ldarg.0
    IL_0044: ldarg.0
    IL_0049: ldfld 0x040010B4
    IL_004E: ldfld 0x04000FAB
    IL_0053: stfld 0x040010B2
    IL_0054: ldarg.0
    IL_0055: ldc.i4.1
    IL_005A: stfld 0x040010B1
    IL_005F: br IL_00A5
    IL_0060: ldarg.0
    IL_0065: ldfld 0x040010B4
    IL_006A: ldfld 0x04000FAB
    IL_006B: conv.r8
    IL_006C: IL_AD
    IL_006D: IL_01
    IL_006E: nop
    IL_006F: stloc.0
    IL_0074: brtrue IL_0090
    IL_0075: ldarg.0
    IL_007A: ldfld 0x040010B4
    IL_007B: ldarg.0
    IL_0080: ldfld 0x040010B4
    IL_0085: ldfld 0x04000FAB
    IL_0086: conv.r8
    IL_0087: IL_FC
    IL_0088: IL_01
    IL_0089: nop
    IL_008A: stloc.0
    IL_008F: stfld 0x04000FA8
    IL_0090: ldarg.0
    IL_0095: ldfld 0x040010B4
    IL_0096: ldc.i4.1
    IL_009B: stfld 0x04000FA9
    IL_009C: ldarg.0
    IL_009D: ldc.i4.m1
    IL_00A2: stfld 0x040010B1
    IL_00A3: ldc.i4.0
    IL_00A4: ret
    IL_00A5: ldc.i4.1
    IL_00A6: ret
    IL_00A7: ldloc.1
    IL_00A8: ret
    }

    public virtual void Dispose() {
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0006: stfld 0x040010B1
    IL_0007: ret
    }

    public virtual void Reset() {
    IL_0004: newobj 0x0A000067
    IL_0005: throw
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    public Shadow_eagle() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000065
    IL_0006: ret
    }

    private void <>m__0() {
    IL_0001: ldarga.s 1
    IL_0006: call 0x0A000236
    IL_0007: ldarg.0
    IL_000C: ldfld 0x040010D3
    IL_0011: call 0x0600046B
    IL_0012: ret
    }

    }}
