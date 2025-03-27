namespace CSharp11.Features;

// Classe statique pour démontrer les motifs de liste
public static class ListPatterns
{
    // Méthode de démonstration
    public static void Demo()
    {
        int[] numbers = new[] { 1, 2, 3 };
        Console.WriteLine("\nList Patterns:");
        // Vérifie si le tableau correspond exactement à [1, 2, 3]
        Console.WriteLine(numbers is [1, 2, 3] ? "Full match" : "No match");
        // Vérifie si le tableau commence par 1
        Console.WriteLine(numbers is [1, ..] ? "Starts with 1" : "No");
    }
}