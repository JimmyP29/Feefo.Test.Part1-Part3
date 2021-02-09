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
        public int[] GenerateHugeArray(int size)
        {
            var result = new int[size];

            for (int i = 0; i < size; i++)
            {
                var number = _random.Next(size);
                result[i] = number;
            }

            return result;
        }
    }
}
