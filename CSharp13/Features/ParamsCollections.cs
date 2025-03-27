namespace CSharp13.Features;

// Classe statique pour démontrer les collections de paramètres
public static class ParamsCollections
{
    // Méthode pour traiter des éléments en tant que paramètres
    public static void ProcessItems(params List<string> items)
    {
        Console.WriteLine("\nParams Collections:");
        // Affiche chaque élément de la collection
        foreach (var item in items)
            Console.WriteLine(item);
    }

    // Méthode de démonstration
    public static void Demo()
    {
        ProcessItems(["First", "Second", "Third"]); // Appel avec une collection de chaînes
    }
}