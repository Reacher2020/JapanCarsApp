using JapanCarsApp;
{

    Console.WriteLine("Witamy w programie rynkowe ceny samochodów Japońskich.");
    Console.WriteLine("======================================================");
    Console.WriteLine();
    Console.WriteLine("Gdzie chcesz zapisywać dane");
    Console.WriteLine("1 - Do pamięci");
    Console.WriteLine("2 - Do pliku");
    Console.WriteLine("Q - Wyjdź z programu");

    var input = Console.ReadLine();
    Console.Clear();
    string price;
    string brand;

    var carStatistics = new Dictionary<string , Statistics >();
    
    switch (input)
    {
        case "1":               // operacje na pamięci
            var lexusInMemory = new CarInMemory("Lexus", "IS 300h", 2013);
            var mitsubishiInMemory = new CarInMemory("Mitsubish", "Outlander", 2022);
            var subaruInMemory = new CarInMemory(" Subaru", "Impreza", 2007);
            var toyotaInMemory = new CarInMemory("Toyota", "Prius", 2010);

            lexusInMemory.PriceAdded += LexusCarPriceAdded;
            mitsubishiInMemory.PriceAdded += MitsubishiCarPriceAdded;
            subaruInMemory.PriceAdded += SubaruCarPriceAdded;
            toyotaInMemory.PriceAdded += ToyotaCarPriceAdded;

            do
            {
                Console.Write("Podaj markę samochodu którego cenę chcesz zapisać lub naciśnij q lub Q żeby opuścić program   : ");
                brand = Console.ReadLine();

                switch (brand)
                {
                    case "L":
                    case "l":
                    case "Lexus":
                        price = ReadPrice($"Podaj kolejna cenę samochodu marki {lexusInMemory.Brand} :",
                            (price) =>
                            {
                                return price > 0 && price <= 100000;
                            }, "Niepoprawna cena.");
                        AddCarPriceAndCatchExeption(price, lexusInMemory);
                       break;
                    case "M":
                    case "m":
                    case "Mitsubishi":
                        price = ReadPrice($"Podaj kolejna cenę samochodu marki {mitsubishiInMemory.Brand} :",
                            (price) =>
                            {
                                return price > 0 && price <= 100000;
                            }, "Niepoprawna cena.");
                        AddCarPriceAndCatchExeption(price, mitsubishiInMemory);
                        break;
                    case "S":
                    case "s":
                    case "Subaru":
                        price = ReadPrice($"Podaj kolejna cenę samochodu marki {subaruInMemory.Brand} :",
                            (price) =>
                            {
                                return price > 0 && price <= 100000;
                            }, "Niepoprawna cena.");
                        AddCarPriceAndCatchExeption(price, subaruInMemory);
                        break;
                    case "T":
                    case "t":
                    case "Toyota":
                        price = ReadPrice($"Podaj kolejna cenę samochodu marki {toyotaInMemory.Brand} :",
                            (price) =>
                            {
                                return price > 0 && price <= 100000;
                            }, "Niepoprawna cena.");
                        AddCarPriceAndCatchExeption(price, toyotaInMemory);
                        break;
                    case "Q":
                    case "q":
                        Console.Clear();

                        carStatistics.Add($"{lexusInMemory.Brand} {lexusInMemory.Model} {lexusInMemory.YearOfProduction}", lexusInMemory.GetStatistics());
                        carStatistics.Add($"{mitsubishiInMemory.Brand} {mitsubishiInMemory.Model} {mitsubishiInMemory.YearOfProduction}", mitsubishiInMemory.GetStatistics());
                        carStatistics.Add($"{subaruInMemory.Brand} {subaruInMemory.Model} {subaruInMemory.YearOfProduction}", subaruInMemory.GetStatistics());
                        carStatistics.Add($"{toyotaInMemory.Brand} {toyotaInMemory.Model} {toyotaInMemory.YearOfProduction}", toyotaInMemory.GetStatistics());

                        Console.WriteLine("Statystyki cen samochodów:");
                        foreach (var car in carStatistics)
                        {
                            if (car.Value.Count != 0)
                                WritrCarsStatistics(car.Key, car.Value);
                            else
                                Console.WriteLine($"Brak danych dla samochodu {car.Key}");
                        }

                        break;
                }
            } while (brand != "Q" && brand != "q");
            break;
        case "2":               // operacje ne plikach
            var lexusInFile = new CarInFiles("Lexus", "IS_300h", 2013);
            var mitsubishiInFile = new CarInFiles("Mitsubish", "Outlander", 2022);
            var subaruInFile = new CarInFiles(" Subaru", "Impreza", 2007);
            var toyotaInFile = new CarInFiles("Toyota", "Prius", 2010);

            lexusInFile.PriceAdded += LexusCarPriceAdded;
            mitsubishiInFile.PriceAdded += MitsubishiCarPriceAdded;
            subaruInFile.PriceAdded += SubaruCarPriceAdded;
            toyotaInFile.PriceAdded += ToyotaCarPriceAdded;

            do
            {
                Console.Write("Podaj markę samochodu żeby zapisać cenę lub naciśnij q lub Q żeby opuścić program   : ");
                brand = Console.ReadLine();
                switch (brand)
                {
                    case "L":
                    case "l":
                    case "Lexus":
                        price = ReadPrice($"Podaj kolejna cenę samochodu marki {lexusInFile.Brand} :",
                            (price) =>
                            {
                                return price > 0 && price <= 100000;
                            }, "Niepoprawna cena.");
                        AddCarPriceAndCatchExeption(price, lexusInFile);
                        break;
                    case "M":
                    case "m":
                    case "Mitsubishi":
                        price = ReadPrice($"Podaj kolejna cenę samochodu marki {mitsubishiInFile.Brand} :",
                            (price) =>
                            {
                                return price > 0 && price <= 100000;
                            }, "Niepoprawna cena.");
                        AddCarPriceAndCatchExeption(price, mitsubishiInFile);
                        break;
                    case "S":
                    case "s":
                    case "Subaru":
                        price = ReadPrice($"Podaj kolejna cenę samochodu marki {subaruInFile.Brand} :",
                            (price) =>
                            {
                                return price > 0 && price <= 100000;
                            }, "Niepoprawna cena.");
                        AddCarPriceAndCatchExeption(price, subaruInFile);
                        break;
                    case "T":
                    case "t":
                    case "Toyota":
                        price = ReadPrice($"Podaj kolejna cenę samochodu marki {toyotaInFile.Brand} :",
                            (price) =>
                            {
                                return price > 0 && price <= 100000;
                            }, "Niepoprawna cena.");
                        AddCarPriceAndCatchExeption(price, toyotaInFile);
                        break;
                    case "Q":
                    case "q":
                        Console.Clear();

                        carStatistics.Add($"{lexusInFile.Brand} {lexusInFile.Model} {lexusInFile.YearOfProduction}", lexusInFile.GetStatistics());
                        carStatistics.Add($"{mitsubishiInFile.Brand} {mitsubishiInFile.Model} {mitsubishiInFile.YearOfProduction}", mitsubishiInFile.GetStatistics());
                        carStatistics.Add($"{subaruInFile.Brand} {subaruInFile.Model} {subaruInFile.YearOfProduction}", subaruInFile.GetStatistics());
                        carStatistics.Add($"{toyotaInFile.Brand} {toyotaInFile.Model} {toyotaInFile.YearOfProduction}", toyotaInFile.GetStatistics());

                        Console.WriteLine("Statystyki cen samochodów:");
                        foreach (var car in carStatistics)
                        {
                            if (car.Value.Count != 0)
                                WritrCarsStatistics(car.Key, car.Value);
                            else
                                Console.WriteLine($"Brak danych dla samochodu {car.Key}");
                        }
                        break;
                }
            } while (brand != "Q" && brand != "q");
            break;
        case "q":
        case "Q":
            Console.WriteLine("Nie dodano ceny żadnego samochodu.");
            break;
    }

    void WritrCarsStatistics(string brandModelYear, Statistics statistics)
    {
        Console.WriteLine();
        Console.WriteLine($"Ceny somochodów {brandModelYear} wyliczone na podstawie {statistics.Count} cen");
        Console.WriteLine($"Minimalna :{statistics.Min:N2}");
        Console.WriteLine($"Średnia :{statistics.Average:N2}");
        Console.WriteLine($"Maksymalna :{statistics.Max:N2}");
    }

    string ReadPrice(string message, Func<float, bool> validate, string errorMessage)
    {
        while (true)
        {
            Console.Write(message);
            var priceString = Console.ReadLine();

            if (float.TryParse(priceString, out var price) && validate(price))
            {
                return priceString;
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
    }

    void AddCarPriceAndCatchExeption(string price, CarBase car)
    {
        try
        {
            car.AddPrice(price);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exeption catched : {ex.Message}");
        }
    }

    void LexusCarPriceAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Nowa cena Lexusa została dodana.");
    }

    void MitsubishiCarPriceAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Nowa cena Mitsubishi została dodana.");
    }

    void SubaruCarPriceAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Nowa cena Subaru została dodana.");
    }

    void ToyotaCarPriceAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Nowa cena Toyoty została dodana.");
    }

}