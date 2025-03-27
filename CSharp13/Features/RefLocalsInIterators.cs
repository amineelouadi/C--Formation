namespace CSharp13.Features;

// Classe statique pour démontrer les références locales dans les itérateurs
public static class RefLocalsInIterators
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nRef Locals in Iterators:");
        // Itération sur les nombres et incrémentation par référence
        foreach (ref int value in GetNumbers())
            value++;
    }

    // Méthode pour obtenir des nombres en tant que références
    private static IEnumerable<ref int> GetNumbers()
    {
        int[] numbers = [1, 2, 3]; // Tableau de nombres
        foreach (ref int num in numbers.AsSpan())
            yield return ref num; // Retourne chaque nombre par référence
    }
}