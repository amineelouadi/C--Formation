using CSharp11.Features;
using CSharp11.Models;

Console.WriteLine("C# 11 Features Demo\n");

// Raw String Literals
RawStringLiterals.Demo();

// Generic Math
GenericMath.Demo();

// List Patterns
ListPatterns.Demo();

// Span Pattern Matching
SpanPatternMatching.Demo();

// Required Members
var person = new Person { FirstName = "John", LastName = "Doe" };
Console.WriteLine($"\nRequired Members: {person.FirstName} {person.LastName}");

// Auto-default Structs
var point = new Point2D(5);
Console.WriteLine($"Auto-default Struct: ({point.X}, {point.Y})");