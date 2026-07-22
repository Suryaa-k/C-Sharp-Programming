using System;

class Program {
    static void Main() {
        int score = 82;

        if (score >= 90) {
            Console.WriteLine("Grade: A");
        } else if (score >= 75) {
            Console.WriteLine("Grade: B");
        } else if (score >= 50) {
            Console.WriteLine("Grade: C");
        } else {
            Console.WriteLine("Grade: F");
        }

        int day = 3;
        switch (day) {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            default: Console.WriteLine("Invalid day"); break;
        }
    }
}