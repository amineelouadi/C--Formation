using System;

namespace CSharp14.Features;

// Classe statique pour démontrer les conversions de Span
public static class SpanConversions
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nSpan conversions:");
        ReadOnlySpan<char> span = "Hello".AsSpan(); // Création d'un ReadOnlySpan
        ProcessSpan(span); // Appel de la méthode pour traiter le span
    }

    // Méthode pour traiter un Span
    private static void ProcessSpan(Span<char> data)
    {
        data[0] = 'J'; // Modification du premier caractère
        Console.WriteLine(data.ToString()); // Affiche le span modifié
    }
}