namespace CSharp13.Features;

// Classe représentant une collection personnalisée avec indexeurs implicites
public class CustomCollection
{
    public int this[int index] { get; set; } // Indexeur pour accéder aux éléments
}

// Classe statique pour démontrer les initialisateurs d'indexeurs implicites
public static class ImplicitIndexerInitializers
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nImplicit Indexer Initializers:");
        // Création d'une collection avec des valeurs via un indexeur implicite
        var collection = new CustomCollection
        {
            [0] = 10,
            [1] = 20  // Pas besoin de nom explicite pour l'indexeur
        };
        // Affiche les valeurs de la collection
        Console.WriteLine($"Values: {collection[0]}, {collection[1]}");
    }
}