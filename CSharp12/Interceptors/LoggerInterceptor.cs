using System.Runtime.CompilerServices;

namespace CSharp12.Interceptors;

// Classe statique pour démontrer un intercepteur
public static class LoggerInterceptor
{
    // Méthode interceptée
    [InterceptsLocation("CSharp12/Program.cs", line: 15, character: 9)]
    public static void InterceptMethod()
    {
        Console.WriteLine("\nInterceptor activated!");
    }
}

// Attribut pour spécifier l'emplacement de l'interception
public class InterceptsLocationAttribute : Attribute
{
    public InterceptsLocationAttribute(string filePath, int line, int character)
    {
    }
}