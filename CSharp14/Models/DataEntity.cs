namespace CSharp14.Models;

// Classe partielle représentant une entité de données
public partial class DataEntity
{
    // Propriété soutenue par un champ avec validation
    public required string Name
    {
        get => field; // Getter pour le nom
        set => field = value?.Trim() ?? throw new ArgumentNullException(nameof(Name)); // Setter avec validation
    }

    // Propriété soutenue par un champ auto
    public required int Id { get; init => field = value > 0 ? value : 1; } // Propriété avec initialisation

    // Propriété permettant d'accéder à une vue en lecture seule du nom
    public ReadOnlySpan<char> NameSpan => Name.AsSpan(); // Propriété pour le span du nom

    // Constructeur partiel
    public partial DataEntity();
}

// Autre partie de la classe partielle
public partial class DataEntity
{
    // Implémentation du constructeur partiel
    public partial DataEntity()
    {
        Console.WriteLine("Partial constructor initialized"); // Message lors de l'initialisation
    }

    // Méthode partielle utilisant de nouvelles fonctionnalités
    partial void Validate() => Console.WriteLine("Validation complete"); // Méthode de validation

    // Événement avec une implémentation soutenue par un champ
    public event Action? OnSaved
    {
        add => field += value; // Ajout d'un abonné
        remove => field -= value; // Suppression d'un abonné
    }
}