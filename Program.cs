
public class Program
{
    public static void Main()
    {
        Console.WriteLine(OldPhone.OldPhonePad("33#")); // E
        Console.WriteLine(OldPhone.OldPhonePad("227*#")); // B
        Console.WriteLine(OldPhone.OldPhonePad("4433555 555666#")); // HELLO
        Console.WriteLine(OldPhone.OldPhonePad("8 88777444666*664#")); // ????
    }
}
