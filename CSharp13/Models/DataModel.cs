namespace CSharp13.Models;

// Classe partielle représentant un modèle de données
public partial class DataModel
{
    // Exemple avec des propriétés partielles
    public partial int Id { get; set; } // Propriété partielle pour l'ID

    // Exemple avec un indexeur implicite
    public Dictionary<string, object> Attributes { get; } = new(); // Dictionnaire pour les attributs
}

// Partie partielle pour la propriété
public partial class DataModel
{
    private int _id; // Champ privé pour l'ID

    // Implémentation de la propriété partielle
    public partial int Id
    {
        get => _id; // Getter
        set => _id = value > 0 ? value : throw new ArgumentException("Invalid ID"); // Setter avec validation
    }
}