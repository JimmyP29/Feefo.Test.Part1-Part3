using System;
using System.Collections.Generic;
using System.Text;

namespace FeefoTechnical.models
{
    public class ArrayManipulator
    {
        public void GetStats(int[] values)
        {
            var stats = new ArrayManipulatorStats(
                FindMedian(values),
                FindMean(values),
                FindMode(values),
                FindRange(values));

            Console.WriteLine("--- Problem 2 ---");
            Console.WriteLine(stats.Print());
        }

        private int FindMedian(int[] values)
        {
            return 0;
        }
        private int FindMean(int[] values)
        {
            var length = values.Length;
            var count = 0;

            for (int i = 0; i < length; i++)
                count += values[i];

            return count / length;
        }
        private int FindMode(int[] values)
        {
            return 0;
        }
        private int FindRange(int[] values)
        {
            return 0;
        }
    }
}
