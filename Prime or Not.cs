using System;

class Program {
    static bool IsPrime(int n) {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++) {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main() {
        int num = 29;
        Console.WriteLine(num + (IsPrime(num) ? " is Prime" : " is Not Prime"));
    }
}