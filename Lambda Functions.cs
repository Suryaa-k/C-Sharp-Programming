using System;

class Program {
    static void Main() {
        // Lambda assigned to a Func delegate
        Func<int, int> square = x => x * x;
        Func<int, int, int> add = (a, b) => a + b;

        Console.WriteLine("Square: " + square(5));
        Console.WriteLine("Add: " + add(3, 4));

        // Lambda capturing outer variable (closure)
        int factor = 10;
        Func<int, int> multiplyByFactor = x => x * factor;
        Console.WriteLine("Multiply: " + multiplyByFactor(5));
    }
}