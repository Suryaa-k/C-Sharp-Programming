using System;

// Custom exception class inheriting from Exception
class InsufficientBalanceException : Exception {
    public InsufficientBalanceException(string message) : base(message) { }
}

class Program {
    static void Withdraw(int balance, int amount) {
        if (amount > balance) {
            throw new InsufficientBalanceException($"Insufficient balance: cannot withdraw {amount} from {balance}");
        }
        Console.WriteLine("Withdrawal successful");
    }

    static void Main() {
        try {
            Withdraw(500, 700);
        }
        catch (InsufficientBalanceException e) {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}