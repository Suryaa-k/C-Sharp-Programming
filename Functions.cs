using System;

class Program {
    static int globalVar = 100;

    static int Add(int a, int b) {
        int localVar = 10;
        return a + b + localVar - localVar;
    }

    static int Factorial(int n) {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    static void Main() {
        Console.WriteLine("Add: " + Add(5, 3));
        Console.WriteLine("Factorial: " + Factorial(5));
        Console.WriteLine("Global: " + globalVar);

        // Lambda expression assigned to a Func delegate
        Func<int, int> square = x => x * x;
        Console.WriteLine("Square via lambda: " + square(4));
    }
}