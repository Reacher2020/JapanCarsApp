namespace JapanCarsApp
{
    public abstract class CarBase : ICar
    {
        public delegate void PriceAddedDelegate(object sender, EventArgs args);

        public abstract event PriceAddedDelegate PriceAdded;

        public CarBase(string brand, string model, int yearOfProduction)
        {
            this.Brand = brand;
            this.Model = model;

            if (yearOfProduction >= 1990)
            {
                this.YearOfProduction = yearOfProduction;
            }
            else
            {
                throw new Exception("Ten samochód jest za stary.");
            }
        }

        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int YearOfProduction { get; private set; }

        public void AddPrice(string price)
        { 
            if (float.TryParse(price, out float result))
            {
                this.AddPrice(result);
            }
            else
            {
                throw new Exception("String nie jest float'em.");
            }
        }
        public abstract void AddPrice(float price);
        public abstract Statistics GetStatistics();

    }
}