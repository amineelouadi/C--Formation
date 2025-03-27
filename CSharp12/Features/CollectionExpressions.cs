namespace CSharp12.Features;

// Classe statique pour démontrer les expressions de collection
public static class CollectionExpressions
{
    // Méthode de démonstration
    public static void Demo()
    {
        // Syntaxe d'expression de collection pour créer des tableaux et des listes
        int[] array = [1, 2, 3];
        List<int> list = [4, 5, 6];
        Span<int> span = [7, 8, 9];

        Console.WriteLine("\nCollection Expressions:");
        // Affiche les éléments de chaque collection
        Console.WriteLine($"Array: {string.Join(",", array)}");
        Console.WriteLine($"List: {string.Join(",", list)}");
        Console.WriteLine($"Span: {string.Join(",", span.ToArray())}");
    }
}