using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        //polymorphism project
        
        //running
        Running run1 = new Running(15,"12/12/2025",25);
        run1.GetSummary();

        //cycling
        Cycling cyc1 = new Cycling(80,"12/13/2025",10);
        cyc1.GetSummary();

        //swimming
        Swimming swi1 = new Swimming(8,"12/14/2025",35);
        swi1.GetSummary();


    }
}