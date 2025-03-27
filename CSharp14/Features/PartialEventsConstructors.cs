namespace CSharp14.Features;

// Classe partielle pour démontrer les événements et les constructeurs partiels
public partial class EventExample
{
    public partial event Action? OnEvent; // Déclaration partielle de l'événement
    public partial EventExample(); // Déclaration partielle du constructeur
}

// Autre partie de la classe partielle
public partial class EventExample
{
    private Action? _onEvent; // Champ privé pour l'événement

    // Implémentation de l'événement partiel
    public partial event Action? OnEvent
    {
        add => _onEvent += value; // Ajout d'un abonné
        remove => _onEvent -= value; // Suppression d'un abonné
    }

    // Implémentation du constructeur partiel
    public partial EventExample()
    {
        Console.WriteLine("\nPartial constructor called");
    }

    // Méthode pour déclencher l'événement
    public void RaiseEvent() => _onEvent?.Invoke();
}

// Classe statique pour démontrer les événements et les constructeurs partiels
public static class PartialEventsConstructors
{
    // Méthode de démonstration
    public static void Demo()
    {
        var example = new EventExample(); // Création d'un exemple
        example.OnEvent += () => Console.WriteLine("Event raised"); // Abonnement à l'événement
        example.RaiseEvent(); // Déclenchement de l'événement
    }
}