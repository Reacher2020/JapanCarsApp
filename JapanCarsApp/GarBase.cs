namespace JapanCarsApp
{
    public abstract class CarBase : ICar
    {
        public delegate void PriceAddedDelegate(object sender, EventArgs args);

        public abstract event PriceAddedDelegate PriceAdded;

        public CarBase(string mark, string model, int yearOfProduction)
        {
            this.Mark = mark;
            this.Model = model;

            if (yearOfProduction >= 1990)
            {
                this.YearOfProduction = yearOfProduction;
            }
            else
            {
                throw new Exception("This car is too old");
            }
        }

        public string Mark { get; private set; }
        public string Model { get; private set; }
        public int YearOfProduction { get; private set; }

        public abstract void AddPrice(float grade);
        public abstract void AddPrice(string grade);
        public abstract Statistics GetStatistics();

    }
}

