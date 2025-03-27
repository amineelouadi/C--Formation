namespace CSharp12.Features;

// Classe utilisant des constructeurs principaux
public class PrimaryConstructors(string name, int age)
{
    public string Name { get; } = name; // Propriété pour le nom
    public int Age { get; } = age; // Propriété pour l'âge

    // Méthode de démonstration
    public static void Demo()
    {
        var person = new PrimaryConstructors("Alice", 30);
        Console.WriteLine($"Primary Constructor: {person.Name}, {person.Age}");
    }
}