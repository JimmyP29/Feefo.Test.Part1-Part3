using FeefoTechnical.models;
using System;

namespace FeefoTechnical
{
    class Program
    {
        static void Main(string[] args)
        {
            /* --- Problem 1 --- */
            var nonNormalisedTitle1 = "Java engineer";
            var nonNormalisedTitle2 = "C# engineer";
            var nonNormalisedTitle3 = "Accountant";
            var nonNormalisedTitle4 = "Chief Accountant";
            var normaliser = new Normaliser();

            var normalisedTitle1 = normaliser.Normalise(nonNormalisedTitle1);
            var normalisedTitle2 = normaliser.Normalise(nonNormalisedTitle2);
            var normalisedTitle3 = normaliser.Normalise(nonNormalisedTitle3);
            var normalisedTitle4 = normaliser.Normalise(nonNormalisedTitle4);

            Console.WriteLine("--- Problem 1 ---");
            Console.WriteLine("Input: {0}, Output: {1}", nonNormalisedTitle1, normalisedTitle1);
            Console.WriteLine("Input: {0}, Output: {1}", nonNormalisedTitle2, normalisedTitle2);
            Console.WriteLine("Input: {0}, Output: {1}", nonNormalisedTitle3, normalisedTitle3);
            Console.WriteLine("Input: {0}, Output: {1}", nonNormalisedTitle4, normalisedTitle4);
            Console.WriteLine("");



            /* --- Problem 2 --- */
            var arrayGenerator = new ArrayGenerator();
            var array = arrayGenerator.GenerateHugeArray(1000);
            var arrayManipulator = new ArrayManipulator();
            arrayManipulator.GetStats(array);

            Console.ReadLine();
        }
    }
}
