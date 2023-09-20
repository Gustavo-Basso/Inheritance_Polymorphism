using InheritanceEx.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {

        Console.Write("How many workers? ");
        int N = int.Parse(Console.ReadLine());
        List<Worker> worker = new List<Worker>();
        
            


        for (int i = 1; i <= N; i++) {
            Console.WriteLine($"Woker #{i}");
            Console.Write("Outsorced? y/n ");
            char sc = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valueP = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (sc == 'y') {

                Console.Write("Additional charge: ");
                double additional = double.Parse(Console.ReadLine());
                worker.Add(new OutSorcedWorker(name, hour, valueP, additional));


            }
            else {
                worker.Add(new Worker(name, hour, valueP));
            }

        }
        Console.WriteLine();
        foreach (Worker worker1 in worker) {
            Console.WriteLine("Worker name: "+ " - " + worker1.Name + " Payment: " + worker1.Payment(), CultureInfo.InvariantCulture);
        }
        

    }
}