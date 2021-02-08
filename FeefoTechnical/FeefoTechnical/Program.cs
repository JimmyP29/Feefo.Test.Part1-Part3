using FeefoTechnical.models;
using System;

namespace FeefoTechnical
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var nor = new Normaliser();
            var result = nor.Normalise("Chief architect");
            Console.WriteLine(result);
        }
    }
}
