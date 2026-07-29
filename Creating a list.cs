using System;

class Program {
    static void Main() {
        int[] list = new int[5];
        for (int i = 0; i < 5; i++) {
            list[i] = (i + 1) * 10;
        }
        for (int i = 0; i < 5; i++) {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }
}