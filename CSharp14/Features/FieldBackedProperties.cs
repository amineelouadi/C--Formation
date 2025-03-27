namespace CSharp14.Features;

// Classe statique pour démontrer les propriétés soutenues par des champs
public static class FieldBackedProperties
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nField-backed properties:");
        var entity = new DataEntity { Id = 42 }; // Création d'une entité avec un ID
        Console.WriteLine(entity.Id); // Affiche l'ID
    }
}

// Classe représentant une entité avec des propriétés soutenues par des champs
public class DataEntity
{
    public required int Id { get; set; } // Propriété requise pour l'ID

    // Propriété soutenue par un champ auto
    public string Name { get => field = value.Trim(); } // Getter et setter pour le nom
}