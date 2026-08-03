// Namespace: 
// Type: DamageNum

    public class DamageNum {{

    private object mytransform;
    private object finishdelay;
    private object text_mesh;
    private object dir;

    public DamageNum() {
    IL_0000: ldarg.0
    IL_0001: IL_22
    IL_0002: nop
    IL_0003: nop
    IL_0008: stsfld 0x05237D3F
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
    IL_000B: stfld 0x04000522
    IL_000C: ldarg.0
    IL_000D: ldarg.0
    IL_0012: call 0x2B000024
    IL_0017: stfld 0x04000524
    IL_0018: ldarg.0
    IL_001D: call 0x0A00000A
    IL_001E: ldc.i4.0
    IL_001F: conv.r8
    IL_0020: stloc.1
    IL_0021: nop
    IL_0022: nop
    IL_0023: stloc.0
    IL_0024: ret
    }

    public void TextOn() {
    IL_0000: ldarg.0
    IL_0005: ldfld 0x04000524
    IL_0007: ldarga.s 2
    IL_000C: call 0x0A000016
    IL_000D: conv.r8
    IL_000E: IL_FD
    IL_000F: nop
    IL_0010: nop
    IL_0011: stloc.0
    IL_0012: ldarg.0
    IL_0017: ldfld 0x04000522
    IL_0018: ldarg.1
    IL_001D: call 0x0A000007
    IL_001E: IL_22
    IL_001F: IL_CD
    IL_0020: IL_CC
    IL_0021: IL_4C
    IL_0022: IL_3E
    IL_0027: call 0x0A000008
    IL_002C: call 0x0A000029
    IL_002D: conv.r8
    IL_002E: ldloc.3
    IL_002F: nop
    IL_0030: nop
    IL_0031: stloc.0
    IL_0032: ldarg.0
    IL_0033: ldarg.3
    IL_0038: stfld 0x04000525
    IL_0039: ldarg.0
    IL_003E: call 0x0A00000A
    IL_003F: ldc.i4.1
    IL_0040: conv.r8
    IL_0041: stloc.1
    IL_0042: nop
    IL_0043: nop
    IL_0044: stloc.0
    IL_0045: ret
    }

    private void Update() {
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0006: ldfld 0x04000523
    IL_000B: call 0x0A000024
    IL_000C: IL_22
    IL_000D: nop
    IL_000E: nop
    IL_000F: nop
    IL_8DF5657C: switch (595417434 cases)
    }

    }}
