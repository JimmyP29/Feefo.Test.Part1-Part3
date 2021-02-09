namespace FeefoTechnical.models
{
    public class ArrayManipulatorStats
    {
        public int Median { get; }
        public int Mean { get; }
        public int Mode { get; }
        public int Range { get; }

        public ArrayManipulatorStats(int median, int mean, int mode, int range)
        {
            Median = median;
            Mean = mean;
            Mode = mode;
            Range = range;
        }

        public string Print() => $"Median: {Median}, Mean: {Mean}, Mode: {Mode}, Range: {Range}";
    }
}
