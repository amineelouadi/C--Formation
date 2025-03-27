namespace CSharp11.Features;

// Classe statique pour démontrer les littéraux de chaîne bruts
public static class RawStringLiterals
{
    // Méthode de démonstration
    public static void Demo()
    {
        // Déclaration d'une chaîne JSON en utilisant un littéral brut
        var json = """
            {
                "name": "John",
                "age": 30,
                "cars": ["Ford", "BMW", "Fiat"]
            }
            """;
        // Affiche le littéral de chaîne brut
        Console.WriteLine("Raw String Literal:\n" + json);
    }
}