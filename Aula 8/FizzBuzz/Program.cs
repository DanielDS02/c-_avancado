using System;
using System.Threading;
class Program
{
    static object lockObject = new object();
    static int currentNumber = 1;
    static int maxNumber = 100;
    static void Main()
    {
        Thread fizzThread = new Thread(Fizz);
        Thread buzzThread = new Thread(Buzz);
        Thread fizzBuzzThread = new Thread(FizzBuzz);
        fizzThread.Start();
        buzzThread.Start();
        fizzBuzzThread.Start();
        fizzThread.Join();
        buzzThread.Join();
        fizzBuzzThread.Join();
    }
    static void Fizz()
    {
        while (true)
        {
            lock (lockObject)
            {
                if (currentNumber > maxNumber)
                    break;
                if (currentNumber % 3 == 0 && currentNumber % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                    currentNumber++;
                }
            }
            Thread.Sleep(10);
        }
    }
    static void Buzz()
    {
        while (true)
        {
            lock (lockObject)
            {
                if (currentNumber > maxNumber)
                    break;
                if (currentNumber % 3 != 0 && currentNumber % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    currentNumber++;
                }
            }
            Thread.Sleep(10);
        }
    }

    static void FizzBuzz()
    {
        while (true)
        {
            lock (lockObject)
            {
                if (currentNumber > maxNumber)
                    break;
                if (currentNumber % 3 == 0 && currentNumber % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    currentNumber++;
                }
            }
            Thread.Sleep(10);
        }
    }
}