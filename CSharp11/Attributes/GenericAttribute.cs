namespace CSharp11.Attributes;

// Attribut générique pouvant être appliqué à des classes
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class GenericAttribute<T> : Attribute
{
    public T Value { get; } // Valeur de l'attribut
    public GenericAttribute(T value) => Value = value; // Constructeur
}

// Application de l'attribut générique à une classe
[GenericAttribute<int>(42)]
[GenericAttribute<string>("Example")]
public class GenericAttributeDemo { }