namespace CSharp12.Models;

// Alias pour un type tuple représentant un point 3D
using Point3D = (int X, int Y, int Z);

public static class AliasAnyTypeDemo
{
    // Méthode de démonstration
    public static void Demo()
    {
        Point3D point = (10, 20, 30); // Création d'un point 3D
        Console.WriteLine($"\nType Alias: {point.X}, {point.Y}, {point.Z}");
    }
}