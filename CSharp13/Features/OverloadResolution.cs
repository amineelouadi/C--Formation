namespace CSharp13.Features;

// Classe pour démontrer la résolution de surcharge
public class OverloadExample
{
    [PreferredOverload] // Attribut pour indiquer la surcharge préférée
    public static void Process(int value) => Console.WriteLine("Preferred int version");

    public static void Process(double value) => Console.WriteLine("Double version");
}

// Classe statique pour démontrer la résolution de surcharge
public static class OverloadResolution
{
    // Méthode de démonstration
    public static void Demo()
    {
        Console.WriteLine("\nOverload Resolution:");
        OverloadExample.Process(10); // Appel de la version int
        OverloadExample.Process(10.0); // Appel de la version double
    }
}

// Attribut pour marquer la surcharge préférée
[AttributeUsage(AttributeTargets.Method)]
public class PreferredOverloadAttribute : Attribute { }