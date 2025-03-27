using System.Numerics;

namespace CSharp11.Utilities;

public static class MathOperations
{
    public static T Multiply<T>(T a, T b) where T : INumber<T> => a * b;
}