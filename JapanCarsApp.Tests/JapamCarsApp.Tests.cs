using JapanCarsApp;

namespace JapanCars.Tests
{
    public class Tests
    {
        [Test]
        public void WhenSomePricesIsAddedForLexusInMemory_ThenStatisticsMustBeCorect()
        {
            // arrange
            var lexusInMemory = new CarInMemory("Lexus", "CT200h", 2013);
            lexusInMemory.AddPrice(40000);
            lexusInMemory.AddPrice(60600);
            lexusInMemory.AddPrice(1075);

            // act
            var statisticsInMemory = lexusInMemory.GetStatistics();

            // assert
            Assert.AreEqual(101675, statisticsInMemory.Sum);
            Assert.AreEqual(1075, statisticsInMemory.Min);
            Assert.AreEqual(60600, statisticsInMemory.Max);
            Assert.AreEqual(3, statisticsInMemory.Count);
        }

        [Test]
        public void WhenSomePricesIsAddedForMitsubishiInMemory_ThenStatisticsMustBeCorect()
        {
            // arrange
            var mitsubishiInMemory = new CarInMemory("Mitsubish", "Outlander", 2022);
            mitsubishiInMemory.AddPrice(40000);
            mitsubishiInMemory.AddPrice(60600);
            mitsubishiInMemory.AddPrice(1075);

            // act
            var statisticsInMemory = mitsubishiInMemory.GetStatistics();

            // assert
            Assert.AreEqual(101675, statisticsInMemory.Sum);
            Assert.AreEqual(1075, statisticsInMemory.Min);
            Assert.AreEqual(60600, statisticsInMemory.Max);
            Assert.AreEqual(3, statisticsInMemory.Count);
        }

        [Test]
        public void WhenSomePricesIsAddedForSubaruInMemory_ThenStatisticsMustBeCorect()
        {
            // arrange
            var subaruInMemory = new CarInMemory(" Subaru", "Impreza", 2007);
            subaruInMemory.AddPrice(40000);
            subaruInMemory.AddPrice(60600);
            subaruInMemory.AddPrice(1075);

            // act
            var statisticsInMemory = subaruInMemory.GetStatistics();

            // assert
            Assert.AreEqual(101675, statisticsInMemory.Sum);
            Assert.AreEqual(1075, statisticsInMemory.Min);
            Assert.AreEqual(60600, statisticsInMemory.Max);
            Assert.AreEqual(3, statisticsInMemory.Count);
        }

        [Test]
        public void WhenSomePricesIsAddedForToyotaInMemory_ThenStatisticsMustBeCorect()
        {
            // arrange
            var toyotaInMemory = new CarInMemory("Toyota", "Prius", 2010);
            toyotaInMemory.AddPrice(40000);
            toyotaInMemory.AddPrice(60600);
            toyotaInMemory.AddPrice(1075);

            // act
            var statisticsInMemory = toyotaInMemory.GetStatistics();

            // assert
            Assert.AreEqual(101675, statisticsInMemory.Sum);
            Assert.AreEqual(1075, statisticsInMemory.Min);
            Assert.AreEqual(60600, statisticsInMemory.Max);
            Assert.AreEqual(3, statisticsInMemory.Count);
        }

        [Test]
        public void WhenSomePricesIsAddedForLexusInFiles_ThenStatisticsMustBeCorect()
        {
            // arrange
            var lexusInFile = new CarInFiles("Lexus", "CT200h", 2013);
            lexusInFile.AddPrice(40000);
            lexusInFile.AddPrice(60600);
            lexusInFile.AddPrice(1075);

            // act
            var statisticsInFiles = lexusInFile.GetStatistics();

            // assert
            Assert.AreEqual(101675, statisticsInFiles.Sum);
            Assert.AreEqual(1075, statisticsInFiles.Min);
            Assert.AreEqual(60600, statisticsInFiles.Max);
            Assert.AreEqual(3, statisticsInFiles.Count);
        }

        [Test]
        public void WhenSomePricesIsAddedForMitsubishiInFiles_ThenStatisticsMustBeCorect()
        {
            // arrange
            var mitsubishiInFile = new CarInFiles("Mitsubish", "Outlander", 2022);
            mitsubishiInFile.AddPrice(40000);
            mitsubishiInFile.AddPrice(60600);
            mitsubishiInFile.AddPrice(1075);

            // act
            var statisticsInFiles = mitsubishiInFile.GetStatistics();

            // assert
            Assert.AreEqual(101675, statisticsInFiles.Sum);
            Assert.AreEqual(1075, statisticsInFiles.Min);
            Assert.AreEqual(60600, statisticsInFiles.Max);
            Assert.AreEqual(3, statisticsInFiles.Count);
        }

        [Test]
        public void WhenSomePricesIsAddedForSubaruInFiles_ThenStatisticsMustBeCorect()
        {
            // arrange
            var subaruInFile = new CarInFiles(" Subaru", "Impreza", 2007);
            subaruInFile.AddPrice(40000);
            subaruInFile.AddPrice(60600);
            subaruInFile.AddPrice(1075);

            // act
            var statisticsInFiles = subaruInFile.GetStatistics();

            // assert
            Assert.AreEqual(101675, statisticsInFiles.Sum);
            Assert.AreEqual(1075, statisticsInFiles.Min);
            Assert.AreEqual(60600, statisticsInFiles.Max);
            Assert.AreEqual(3, statisticsInFiles.Count);
        }

        [Test]
        public void WhenSomePricesIsAddedForToyotaInFiles_ThenStatisticsMustBeCorect()
        {
            // arrange
            var toyotaInFile = new CarInFiles("Toyota", "Prius", 2010);
            toyotaInFile.AddPrice(40000);
            toyotaInFile.AddPrice(60600);
            toyotaInFile.AddPrice(1075);

            // act
            var statisticsInFiles = toyotaInFile.GetStatistics();

            // assert
            Assert.AreEqual(101675, statisticsInFiles.Sum);
            Assert.AreEqual(1075, statisticsInFiles.Min);
            Assert.AreEqual(60600, statisticsInFiles.Max);
            Assert.AreEqual(3, statisticsInFiles.Count);
        }
    }
}