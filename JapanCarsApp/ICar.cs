using static JapanCarsApp.CarBase;

namespace JapanCarsApp
{
    public interface ICar
    {
        string Brand { get; }
        string Model { get; }
        int YearOfProduction { get; }

        void AddPrice(float price);
        void AddPrice(string price);

        event PriceAddedDelegate PriceAdded;

        Statistics GetStatistics();
    }
}

