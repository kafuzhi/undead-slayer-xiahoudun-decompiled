// Namespace: LitJson
// Type: LitJson.JSONNode

namespace LitJson {
    public class JSONNode {{

    public JSONNode() {
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

    }}
}}
