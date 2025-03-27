using System.Numerics;

namespace CSharp11.Features;

// Classe statique pour démontrer les mathématiques génériques
public static class GenericMath
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nGeneric Math Support:");
        // Affiche la somme d'entiers
        Console.WriteLine($"Integer sum: {Add(5, 3)}");
        // Affiche la somme de doubles
        Console.WriteLine($"Double sum: {Add(2.5, 3.7)}");
    }

    // Méthode privée pour additionner deux nombres génériques
    private static T Add<T>(T a, T b) where T : INumber<T> => a + b;
}