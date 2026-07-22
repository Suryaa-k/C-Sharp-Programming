using System;

class Program {
    static void Main() {
        // For loop
        for (int i = 1; i <= 5; i++) {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // While loop
        int j = 1;
        while (j <= 5) {
            Console.Write(j + " ");
            j++;
        }
        Console.WriteLine();

        // Do-while loop
        int k = 1;
        do {
            Console.Write(k + " ");
            k++;
        } while (k <= 5);
        Console.WriteLine();
    }
}