namespace CSharp13.Features;

// Classe statique pour démontrer les génériques de structures de référence
public static class RefStructGenerics
{
    // Méthode pour traiter des structures de référence
    public static void Process<T>(ref T value) where T : ref struct
    {
        Console.WriteLine($"Processing ref struct: {typeof(T)}");
    }

    // Méthode de démonstration
    public static void Demo()
    {
        Span<int> span = stackalloc int[5]; // Allocation de mémoire sur la pile
        Process(ref span); // Appel de la méthode avec une structure de référence
    }
}