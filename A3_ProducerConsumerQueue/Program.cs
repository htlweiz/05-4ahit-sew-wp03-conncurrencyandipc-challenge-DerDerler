using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace A3_ProducerConsumerQueue;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 3: Producer-Consumer");
        Console.WriteLine("==========================================\n");

        ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

        // TODO
        for (int i = 0; i < 5; i++)
        {
            new Producer(i);
        }
        Console.WriteLine("Producer und Consumer gestartet...\n");

        // Überwachung: Jede Sekunde Queue-Füllstand ausgeben und auf >50 prüfen

        // TODO


        // Alle Producer stoppen


        // Consumer stoppen


    }
}
