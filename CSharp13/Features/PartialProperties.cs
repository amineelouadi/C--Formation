namespace CSharp13.Features;

// Classe partielle démontrant les propriétés partielles
public partial class PartialClass
{
    public partial int Value { get; set; } // Déclaration partielle de la propriété
}

// Autre partie de la classe partielle
public partial class PartialClass
{
    private int _value; // Champ privé

    // Implémentation de la propriété partielle
    public partial int Value
    {
        get => _value; // Getter
        set => _value = value * 2; // Setter qui double la valeur
    }
}

// Classe statique pour démontrer les propriétés partielles
public static class PartialProperties
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nPartial Properties:");
        var obj = new PartialClass { Value = 5 }; // Création d'un objet avec une valeur
        Console.WriteLine($"Value: {obj.Value}"); // Affiche la valeur
    }
}