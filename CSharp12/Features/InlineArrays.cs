using System.Runtime.CompilerServices;

namespace CSharp12.Features;

// Structure utilisant des tableaux en ligne
[InlineArray(10)]
public struct Buffer<T>
{
    private T _element0; // Élément de tableau en ligne
}

// Classe statique pour démontrer l'utilisation de Buffer
public static class InlineArrays
{
    // Méthode de démonstration
    public static void Demo()
    {
        var buffer = new Buffer<int>();
        // Remplit le buffer avec des valeurs
        for (int i = 0; i < 10; i++)
            buffer[i] = i;

        // Affiche un élément du tableau en ligne
        Console.WriteLine($"Inline Array: {buffer[5]}");
    }
}