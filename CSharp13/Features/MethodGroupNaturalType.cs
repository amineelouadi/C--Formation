namespace CSharp13.Features;

// Classe statique pour démontrer le type naturel des groupes de méthodes
public static class MethodGroupNaturalType
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nMethod Group Natural Type:");
        // Assignation d'un groupe de méthodes à une action
        Action action = PrintMessage;
        action(); // Appel de l'action
    }

    // Méthode à appeler
    private static void PrintMessage() => Console.WriteLine("Method group assigned directly");
}