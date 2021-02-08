using FeefoTechnical.models;
using System;

namespace FeefoTechnical
{
    class Program
    {
        static void Main(string[] args)
        {
            var normaliser = new Normaliser();
            var result = normaliser.Normalise("Java engineer");
            var result2 = normaliser.Normalise("C# engineer");
            var result3 = normaliser.Normalise("Accountant");
            var result4 = normaliser.Normalise("Chief Accountant");
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    }
}
