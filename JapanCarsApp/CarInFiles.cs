namespace JapanCarsApp
{
    public class CarInFiles : CarBase
    {
        private const string partFileName = "_Prices.txt";

        private string fileName;

        public CarInFiles(string brand, string model, int yearOfProduction):
            base (brand, model, yearOfProduction)
        {
            fileName = $"{brand}_{model}_{yearOfProduction}{fileName}";
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
                throw new Exception($"File {fileName} dos not exists");
            }
            return statistics;
        }

    }
}
