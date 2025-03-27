using Microsoft.FSharp.Core;
using System.Diagnostics.CodeAnalysis;

namespace CSharp12.Attributes;

// Classe démontrant l'utilisation d'un attribut expérimental
public static class ExperimentalAttributeDemo
{
    // Méthode marquée comme expérimentale
    [Experimental("FEATURE123")]
    public static void ExperimentalMethod()
    {
        Console.WriteLine("\nExperimental method called");
    }

    // Méthode de démonstration
    public static void Demo()
    {
        // Appel de la méthode expérimentale
        ExperimentalMethod();
    }
}