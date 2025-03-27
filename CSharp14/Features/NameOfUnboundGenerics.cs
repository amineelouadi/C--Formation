namespace CSharp14.Features;

// Classe statique pour démontrer l'utilisation de nameof avec des génériques non liés
public static class NameOfUnboundGenerics
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nnameof unbound generics:");
        // Affiche le nom de la méthode générique
        Console.WriteLine(nameof(MyGenericClass<>.Create)); // "Create"
    }
}

// Classe générique
public class MyGenericClass<T>
{
    public static void Create() { } // Méthode statique
}