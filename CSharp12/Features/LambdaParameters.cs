namespace CSharp12.Features;

// Classe statique pour démontrer les paramètres de lambda
public static class LambdaParametersDemo
{
    // Méthode de démonstration
    public static void Demo()
    {
        // Lambda avec un paramètre optionnel
        var addWithDefault = (int a, int b = 5) => a + b;
        Console.WriteLine($"\nLambda with optional params: {addWithDefault(10)}");
    }
}