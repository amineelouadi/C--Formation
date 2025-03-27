namespace CSharp12.Features;

// Classe statique pour démontrer les paramètres en lecture seule par référence
public static class RefReadOnlyParameters
{
    // Méthode de démonstration
    public static void Demo()
    {
        int value = 42;
        PrintValue(in value); // Passe la valeur en lecture seule
    }

    // Méthode pour imprimer la valeur
    private static void PrintValue(ref readonly int value)
    {
        Console.WriteLine($"\nref readonly parameter: {value}");
    }
}