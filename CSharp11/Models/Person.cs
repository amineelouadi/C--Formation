namespace CSharp11.Models;

// Classe représentant une personne avec des propriétés requises
public class Person
{
    // Propriété requise pour le prénom
    public required string FirstName { get; init; }
    // Propriété requise pour le nom de famille
    public required string LastName { get; init; }
}