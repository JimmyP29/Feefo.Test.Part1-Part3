using System;
using System.Collections.Generic;

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
            var orderedValues = SortArray(values);
            var length = orderedValues.Length;
            var middleElement = orderedValues[length / 2];

            if (length % 2 == 0)
            {
                // Even amount of values so the 2 middle ones are averaged.
                var middleElementMinusOne = orderedValues[length / 2 - 1];
                return (middleElementMinusOne + middleElement) / 2;
            }
            else
            {
                // Odd
                return middleElement;
            }
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
            var counter = new Dictionary<int, int>();

            for (int i = 0; i < values.Length; i++)
            {
                if(counter.ContainsKey(values[i]))
                    counter[values[i]]++;
                else
                    counter.Add(values[i], 1);
            }

            var mode = 0;
            var j = 0;

            foreach (var count in counter)
            {
                if (count.Value > j)
                {
                    mode = count.Key;
                    j = count.Value;
                }
            }

            return mode;
        }
        private int FindRange(int[] values)
        {
            var orderedValues = SortArray(values);
            return orderedValues[orderedValues.Length - 1] - orderedValues[0];
        }

        private int[] SortArray(int[] values)
        {
            var length = values.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (values[i] > values[j])
                    {
                        var temporaryValue = values[i];
                        values[i] = values[j];
                        values[j] = temporaryValue;
                    }
                }
            }

            return values;
        }
    }
}
