namespace JapanCarsApp
{
    public class ToyotaInMemory : CarBase
    {
        private List<float> prices = new List<float>();

        public ToyotaInMemory(string mark, string model, int yearOfProduction)
            : base(mark, model, yearOfProduction)
        {
        }

        public override event PriceAddedDelegate PriceAdded;

        public override void AddPrice(float price)
        {
            if (price <= 100000)
            {
                this.prices.Add(price);

                if (PriceAdded != null)
                {
                    PriceAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Price value out of range");
            }
        }

        public override void AddPrice(string price)
        {
            if (float.TryParse(price, out float result))
            {
                this.AddPrice(result);
            }
            else
            {
                throw new Exception("String is'n float");
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


