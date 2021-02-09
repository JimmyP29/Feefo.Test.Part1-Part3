using System;
using System.Collections.Generic;
using System.Text;

namespace FeefoTechnical.models
{
    public class ArrayManipulator
    {
        private Random _random;

        public ArrayManipulator()
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
