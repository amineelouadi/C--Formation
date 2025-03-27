namespace CSharp13.Features;

// Interface pour les structures de référence
public interface IDisposableRef : IDisposable { }

// Structure de référence implémentant l'interface
public ref struct ResourceManager : IDisposableRef
{
    public void Dispose() => Console.WriteLine("Ref struct disposed"); // Méthode de nettoyage
}

// Classe statique pour démontrer les interfaces de structures de référence
public static class RefStructInterfaces
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nRef Struct Interfaces:");
        using var manager = new ResourceManager(); // Utilisation de la structure de référence
    }
}