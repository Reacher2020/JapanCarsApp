namespace JapanCarsApp
{
    public class Statistics
    {

        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public void AddPrice(float price)
        {
            this.Count++;
            this.Sum += price;
            this.Min = Math.Min(this.Min, price);
            this.Max = Math.Max(this.Max, price);
        }

    }
}
