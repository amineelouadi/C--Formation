namespace CSharp13.Features;

// Classe statique pour démontrer les nouvelles sémantiques de verrouillage
public static class LockSemantics
{
    private static readonly object _syncRoot = new(); // Objet de synchronisation

    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nNew Lock Semantics:");
        // Utilisation du verrou pour protéger une section critique
        lock (_syncRoot)
        {
            Console.WriteLine("Critical section with new lock implementation");
        }
    }
}