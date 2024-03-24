using JapanCarsApp;
{

    Console.WriteLine("Witamy w programie rynkowe ceny samochodów Japońskich.");
    Console.WriteLine("======================================================");
    Console.WriteLine();
    Console.WriteLine("Gdzie chcesz zapisywać dane");
    Console.WriteLine("1 - Do pamięci");
    Console.WriteLine("2 - Do pliku");
    Console.WriteLine("Q - Opuść program");

    var input = Console.ReadLine();
    Console.Clear();

    string price;
    string brand;

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
                Console.Write("Podaj markę samochodu żeby zapisać cenę lub naciśnij q żeby opuścić program   : ");
                brand = Console.ReadLine();

                switch (brand)
                {
                    case "L":
                    case "l":
                    case "Lexus":
                        Console.Write("Podaj kolejna cenę samochodu marki Lexus :");
                        
                        price = Console.ReadLine();
                        if (price == "q" && price == "Q")
                        {
                            break;
                        }
                        try
                        {
                            lexusInMemory.AddPrice(price);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exeption catched : {ex.Message}");
                        }
                        break;
                    case "M":
                    case "m":
                    case "Mitsubishi":
                        Console.Write("Podaj kolejna cenę samochodu marki Mitsubishi :");
                        price = Console.ReadLine();
                        if (price == "q" && price == "Q")
                        {
                            break;
                        }
                        try
                        {
                            mitsubishiInMemory.AddPrice(price);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exeption catched : {ex.Message}");
                        }
                        break;
                    case "S":
                    case "s":
                    case "Subaru":
                        Console.Write("Podaj kolejna cenę samochodu marki Subaru :");
                        price = Console.ReadLine();
                        if (price == "q" && price == "Q")
                        {
                            break;
                        }
                        try
                        {
                            subaruInMemory.AddPrice(price);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exeption catched : {ex.Message}");
                        }
                        break;
                    case "T":
                    case "t":
                    case "Toyota":
                        Console.Write("Podaj kolejna cenę samochodu marki Toyota :");
                        price = Console.ReadLine();
                        if (price == "q" && price == "Q")
                        {
                            break;
                        }
                        try
                        {
                            toyotaInMemory.AddPrice(price);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exeption catched : {ex.Message}");
                        }
                        break;
                    case "Q":
                    case "q":
                        Console.Clear();

                        Console.WriteLine("Statystyki cen samochodów:");
                        var statisticsInMemory = lexusInMemory.GetStatistics();
                        Console.WriteLine();
                        if (statisticsInMemory.Count != 0)
                        {
                            Console.WriteLine($"Ceny somochodów Lexus {lexusInMemory.Model} {lexusInMemory.YearOfProduction} wyliczone na podstawie {statisticsInMemory.Count} cen");
                            Console.WriteLine($"Minimalna :{statisticsInMemory.Min:N2}");
                            Console.WriteLine($"Średnia :{statisticsInMemory.Average:N2}");
                            Console.WriteLine($"Maksymalna  :{statisticsInMemory.Max:N2}");

                        }
                        Console.WriteLine();
                        statisticsInMemory = mitsubishiInMemory.GetStatistics();
                        if(statisticsInMemory.Count != 0)
                        {
                            Console.WriteLine($"Ceny somochodów Mitsubish {mitsubishiInMemory.Model} {mitsubishiInMemory.YearOfProduction} wyliczone na podstawie {statisticsInMemory.Count} cen");
                            Console.WriteLine($"Minimalna :{statisticsInMemory.Min:N2}");
                            Console.WriteLine($"Średnia :{statisticsInMemory.Average:N2}");
                            Console.WriteLine($"Maksymalna  :{statisticsInMemory.Max:N2}");
                        }
                        Console.WriteLine();
                        statisticsInMemory = subaruInMemory.GetStatistics();
                        if(statisticsInMemory.Count != 0)
                        {
                            Console.WriteLine($"Ceny somochodów Subaru {subaruInMemory.Model} {subaruInMemory.YearOfProduction} wyliczone na podstawie {statisticsInMemory.Count} cen");
                            Console.WriteLine($"Minimalna :{statisticsInMemory.Min:N2}");
                            Console.WriteLine($"Średnia :{statisticsInMemory.Average:N2}");
                            Console.WriteLine($"Maksymalna  :{statisticsInMemory.Max:N2}");
                        }
                        Console.WriteLine();
                        statisticsInMemory = toyotaInMemory.GetStatistics();
                        if (statisticsInMemory.Count != 0)
                        {
                            Console.WriteLine($"Ceny somochodów Subaru {toyotaInMemory.Model} {toyotaInMemory.YearOfProduction} wyliczone na podstawie {statisticsInMemory.Count} cen");
                            Console.WriteLine($"Minimalna :{statisticsInMemory.Min:N2}");
                            Console.WriteLine($"Średnia :{statisticsInMemory.Average:N2}");
                            Console.WriteLine($"Maksymalna  :{statisticsInMemory.Max:N2}");
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
                Console.Write("Podaj markę samochodu żeby zapisać cenę lub naciśnij q żeby opuścić program   : ");
                brand = Console.ReadLine();
                switch (brand)
                {
                    case "L":
                    case "l":
                    case "Lexus":
                        Console.Write("Podaj kolejna cenę samochodu marki Lexus :");
                        price = Console.ReadLine();
                        if (price == "q" && price == "Q")
                        {
                            break;
                        }
                        try
                        {
                            lexusInFile.AddPrice(price);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exeption catched : {ex.Message}");
                        }
                        break;
                    case "M":
                    case "m":
                    case "Mitsubishi":
                        Console.Write("Podaj kolejna cenę samochodu marki Mitsubishi :");
                        price = Console.ReadLine();
                        if (price == "q" && price == "Q")
                        {
                            break;
                        }
                        try
                        {
                            mitsubishiInFile.AddPrice(price);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exeption catched : {ex.Message}");
                        }
                        break;
                    case "S":
                    case "s":
                    case "Subaru":
                        Console.Write("Podaj kolejna cenę samochodu marki Subaru :");
                        price = Console.ReadLine();
                        if (price == "q" && price == "Q")
                        {
                            break;
                        }
                        try
                        {
                            subaruInFile.AddPrice(price);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exeption catched : {ex.Message}");
                        }
                        break;
                    case "T":
                    case "t":
                    case "Toyota":
                        Console.Write("Podaj kolejna cenę samochodu marki Toyota :");
                        price = Console.ReadLine();
                        if (price == "q" && price == "Q")
                        {
                            break;
                        }
                        try
                        {
                            toyotaInFile.AddPrice(price);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exeption catched : {ex.Message}");
                        }
                        break;
                    case "Q":
                    case "q":
                        Console.Clear();
                        Console.WriteLine("Statystyki cen samochodów:");
                        var statisticsInFiles = lexusInFile.GetStatistics();
                        Console.WriteLine();
                        if(statisticsInFiles.Count != 0)
                        {
                            Console.WriteLine($"Ceny somochodów Lexus {lexusInFile.Model} {lexusInFile.YearOfProduction} wyliczone na podstawie {statisticsInFiles.Count} cen");
                            Console.WriteLine($"Minimalna :{statisticsInFiles.Min:N2}");
                            Console.WriteLine($"Średnia :{statisticsInFiles.Average:N2}");
                            Console.WriteLine($"Maksymalna  :{statisticsInFiles.Max:N2}");
                        }
                        statisticsInFiles = mitsubishiInFile.GetStatistics();
                        Console.WriteLine();
                        if (statisticsInFiles.Count != 0)
                        {
                            Console.WriteLine($"Ceny somochodów Mitsubishi {mitsubishiInFile.Model} {mitsubishiInFile.YearOfProduction} wyliczone na podstawie {statisticsInFiles.Count} cen");
                            Console.WriteLine($"Minimalna :{statisticsInFiles.Min:N2}");
                            Console.WriteLine($"Średnia :{statisticsInFiles.Average:N2}");
                            Console.WriteLine($"Maksymalna :{statisticsInFiles.Max:N2}");
                        }
                        statisticsInFiles = subaruInFile.GetStatistics();
                        Console.WriteLine();
                        if (statisticsInFiles.Count != 0)
                        {
                            Console.WriteLine($"Ceny somochodów Subaru {subaruInFile.Model} {subaruInFile.YearOfProduction} wyliczone na podstawie {statisticsInFiles.Count} cen");
                            Console.WriteLine($"Minimalna :{statisticsInFiles.Min:N2}");
                            Console.WriteLine($"Średnia :{statisticsInFiles.Average:N2}");
                            Console.WriteLine($"Maksymalna :{statisticsInFiles.Max:N2}");
                        }
                        statisticsInFiles = toyotaInFile.GetStatistics();
                        Console.WriteLine();
                        if (statisticsInFiles.Count != 0)
                        {
                            Console.WriteLine($"Ceny somochodów Toyota {toyotaInFile.Model} {toyotaInFile.YearOfProduction} wyliczone na podstawie {statisticsInFiles.Count} cen");
                            Console.WriteLine($"Minimalna :{statisticsInFiles.Min:N2}");
                            Console.WriteLine($"Średnia :{statisticsInFiles.Average:N2}");
                            Console.WriteLine($"Maksymalna :{statisticsInFiles.Max:N2}");
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