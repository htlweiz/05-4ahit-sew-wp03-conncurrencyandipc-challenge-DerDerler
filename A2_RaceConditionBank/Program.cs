using System;
using System.Threading;
using System.Transactions;

namespace A2_RaceConditionBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 2: Race Condition – Bankkonto");
        Console.WriteLine("==========================================\n");
        
        // Bankkonto mit Startwert 1000 EUR erstellen
        BankAccount account = new BankAccount(1000);
        Console.WriteLine($"Startkontostand: {account.GetBalance()} EUR\n");
        
        Thread thread1 = new Thread(() => PerformBankOperations(account));
        Thread thread2 = new Thread(() => PerformBankOperations(account));
        Thread thread3 = new Thread(() => PerformBankOperations(account));
        Thread thread4 = new Thread(() => PerformBankOperations(account));
        Thread thread5 = new Thread(() => PerformBankOperations(account));
        Thread thread6 = new Thread(() => PerformBankOperations(account));
        Thread thread7 = new Thread(() => PerformBankOperations(account));
        Thread thread8 = new Thread(() => PerformBankOperations(account));
        Thread thread9 = new Thread(() => PerformBankOperations(account));
        Thread thread0 = new Thread(() => PerformBankOperations(account));

        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();
        thread5.Start();
        thread6.Start();
        thread7.Start();
        thread8.Start();
        thread9.Start();
        thread0.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();
        thread4.Join();
        thread5.Join();
        thread6.Join();
        thread7.Join();
        thread8.Join();
        thread9.Join();
        thread0.Join();

        Console.WriteLine("Kontostand Ende: " + account.GetBalance() + " EUR");
    }
    
    private static void PerformBankOperations(BankAccount account)
    {
        Console.WriteLine("Transaction");
        account.Deposit(100);
        Thread.Sleep(100);
        account.Withdraw(150);
    }
}

