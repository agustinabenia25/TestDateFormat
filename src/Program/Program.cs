namespace TestDateFormat;

/// El programa principal.
public static class Program
{
    /// Punto de entrada al programa principal.
    public static void Main()
    {
        string testDate = "10/11/1997";
        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
    }
}