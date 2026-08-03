// Namespace: 
// Type: Login_again

    public class Login_again {{

    public Login_again() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A000001
    IL_0006: ret
    }

    private void Start() {
    IL_0000: ldarg.0
    IL_0005: call 0x0A00000A
    IL_000A: call 0x0A000090
    IL_000B: ret
    }

    private void Update() {
    IL_0000: ret
    }

    private void OnApplicationPause() {
    IL_0000: ldarg.1
    IL_0005: brtrue IL_0007
    IL_0006: ret
    IL_000B: call 0x0A0000EB
    IL_0010: ldstr 0x70022722
    IL_0015: call 0x0A0000A6
    IL_001A: brfalse IL_001B
    IL_001B: ret
    }

    }}
