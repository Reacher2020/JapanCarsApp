namespace JapanCarsApp
{
    public class LexusInFile:CarBase
    {
        private const string fileName = "LexusPrices.txt";
        public LexusInFile(string mark, string model, int yearOfProduction)
            : base(mark, model, yearOfProduction)
        {
        }

        public override event PriceAddedDelegate PriceAdded;

        public override void AddPrice(float price)
        {
            if (price <= 100000)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(price);
                }
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
            Statistics statistics = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.AddPrice(number);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new Exception("File prices.txt dos not exists");
            }
            return statistics;
        }

    }
}
