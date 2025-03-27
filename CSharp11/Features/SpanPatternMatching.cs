namespace CSharp11.Features;

// Classe statique pour démontrer le correspondance de motifs avec ReadOnlySpan
public static class SpanPatternMatching
{
    // Méthode de démonstration
    public static void Demo()
    {
        ReadOnlySpan<char> span = "World".AsSpan();
        Console.WriteLine("\nSpan<char> Pattern Matching:");
        // Utilise un switch pour faire correspondre le contenu du span
        Console.WriteLine(span switch
        {
            "Hello" => "Greeting",
            "World" => "Planet",
            _ => "Unknown"
        });
    }
}