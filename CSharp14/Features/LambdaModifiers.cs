namespace CSharp14.Features;

// Classe statique pour démontrer les modificateurs de lambda
public static class LambdaModifiers
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nLambda modifiers:");
        // Lambda avec un paramètre passé par référence
        var increment = (ref int x) => x++;
        int value = 5; // Valeur initiale
        increment(ref value); // Incrémente la valeur
        Console.WriteLine(value); // Affiche la valeur incrémentée
    }
}