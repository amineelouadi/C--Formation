namespace CSharp13.Features;

// Classe statique pour démontrer les séquences d'échappement
public static class EscapeSequence
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nEscape Sequence:");
        // Affiche un texte avec une séquence d'échappement ANSI
        Console.WriteLine("ANSI Escape:\e[31mRed Text\e[0m");
    }
}