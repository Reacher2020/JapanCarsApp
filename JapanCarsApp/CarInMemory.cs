namespace JapanCarsApp
{
    public class CarInMemory : CarBase
    {
        private List<float> prices = new List<float>();

        public CarInMemory(string mark, string model, int yearOfProduction)
            : base(mark, model, yearOfProduction)
        {
        }

        public override event PriceAddedDelegate PriceAdded;

        public override void AddPrice(float price)       
        {
            this.prices.Add(price);

            if (PriceAdded != null)
            {
                PriceAdded(this, new EventArgs());
            }

        }

public override Statistics GetStatistics()
        {
            var statistics = new Statistics();


            foreach (var price in this.prices)
            {
                statistics.AddPrice(price);
            }

            return statistics;
        }

    }
}