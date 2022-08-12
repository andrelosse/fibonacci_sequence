//Code by @andrelosse

using System;

namespace Fibonacci;

class Program{

    static void PrintFibonacci (int size){

        int min = 0, max = 1, now = 0;

        Console.Write("0 - 1 - ");

        for(int i=0; i<=size; i++){
            now = min + max;
            min = max;
            max = now;
            Console.Write($"{now} - ");
        }
    }
    static void Main(string[] args){

        Console.Write("Size of the sequence: ");
        int size = int.Parse(Console.ReadLine());

        PrintFibonacci(size);
    }
}