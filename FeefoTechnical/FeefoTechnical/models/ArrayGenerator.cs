using System;

namespace FeefoTechnical.models
{
    public class ArrayGenerator
    {
        private Random _random;

        public ArrayGenerator()
        {
            _random = new Random();
        }
        public int[] GenerateHugeArray()
        {
            var result = new int[10];

            for (int i = 0; i < 10; i++)
            {
                var number = _random.Next(100);
                result[i] = number;
            }

            return result;
        }
    }
}
