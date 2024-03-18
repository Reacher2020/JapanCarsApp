using JapanCarsApp;
{

    Console.WriteLine("Witamy w programie rynkowe ceny samochodów Japońskich”");
    Console.WriteLine("======================================================");
    Console.WriteLine();
    Console.WriteLine("Gdzie chcesz zapisywać dane");
    Console.WriteLine("1 - Do pamięci");
    Console.WriteLine("2 - Do pliku");
    Console.WriteLine("Q - Opuść program");
    var input = Console.ReadLine();
    Console.Clear();

    string price;
    string mark;

    switch (input)
    {
        case "1":               // operacje na pamięci
            var lexusInMemory = new LexusInMemory("Lexus", "IS 300h", 2013);
            var mitsubishiInMemory = new MitsubishiInMemory("Mitsubish", "Outlander", 2022);
            var subaruInMemory = new SubaruInMemory(" Subaru", "Impreza", 2007);
            var toyotaInMemory = new ToyotaInMemory("Toyota", "Prius", 2010);

            lexusInMemory.PriceAdded += LexusCarPriceAdded;
            mitsubishiInMemory.PriceAdded += MitsubishiCarPriceAdded;
            subaruInMemory.PriceAdded += SubaruCarPriceAdded;
            toyotaInMemory.PriceAdded += ToyotaCarPriceAdded;

            do
            {
                Console.Write("Podaj markę samochodu żeby zapisać cenę lub naciśnij q żeby opuścić program   : ");
                mark = Console.ReadLine();

                switch (mark)
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
                        var statisticsInMemory = lexusInMemory.GetStatistics();
                        Console.Clear();
                        Console.WriteLine($"Minimalna cena samochodów marki Lexus :{statisticsInMemory.Min:N2}");
                        Console.WriteLine($"Średnia cena samochodów marki Lexus :{statisticsInMemory.Average:N2}");
                        Console.WriteLine($"Maksymalna cena samochodów marki Lexus :{statisticsInMemory.Max:N2}");
                        Console.WriteLine($"Ceny samochodów marki Lexus wyliczone na podstawie :{statisticsInMemory.Count}", " cen");

                        statisticsInMemory = mitsubishiInMemory.GetStatistics();
                        Console.WriteLine();
                        Console.WriteLine($"Minimalna cena samochodów marki Mitsubishi :{statisticsInMemory.Min:N2}");
                        Console.WriteLine($"Średnia cena samochodów marki Mitsubishi :{statisticsInMemory.Average:N2}");
                        Console.WriteLine($"Maksymalna cena samochodów marki Mitsubishi :{statisticsInMemory.Max:N2}");
                        Console.WriteLine($"Ceny samochodów marki Mitsubishi wyliczone na podstawie :{statisticsInMemory.Count}", " cen");

                        statisticsInMemory = subaruInMemory.GetStatistics();
                        Console.WriteLine();
                        Console.WriteLine($"Minimalna cena samochodów marki Subaru :{statisticsInMemory.Min:N2}");
                        Console.WriteLine($"Średnia cena samochodów marki Subaru :{statisticsInMemory.Average:N2}");
                        Console.WriteLine($"Maksymalna cena samochodów marki Subaru :{statisticsInMemory.Max:N2}");
                        Console.WriteLine($"Ceny samochodów marki Subaru wyliczone na podstawie :{statisticsInMemory.Count}", " cen");

                        statisticsInMemory = toyotaInMemory.GetStatistics();
                        Console.WriteLine();
                        Console.WriteLine($"Minimalna cena samochodów marki Toyota :{statisticsInMemory.Min:N2}");
                        Console.WriteLine($"Średnia cena samochodów marki Toyota :{statisticsInMemory.Average:N2}");
                        Console.WriteLine($"Maksymalna cena samochodów marki Toyota :{statisticsInMemory.Max:N2}");
                        Console.WriteLine($"Ceny samochodów marki Toyota wyliczone na podstawie :{statisticsInMemory.Count}", " cen");
                        break;
                }
            } while (mark != "Q" && mark != "q");
            break;
        case "2":               // operacje ne plikach
            var lexusInFile = new LexusInFile("Lexus", "IS 300h", 2013);
            var mitsubishiInFile = new MitsubishiInFile("Mitsubish", "Outlander", 2022);
            var subaruInFile = new SubaruInFile(" Subaru", "Impreza", 2007);
            var toyotaInFile = new ToyotaInFile("Toyota", "Prius", 2010);

            lexusInFile.PriceAdded += LexusCarPriceAdded;
            mitsubishiInFile.PriceAdded += MitsubishiCarPriceAdded;
            subaruInFile.PriceAdded += SubaruCarPriceAdded;
            toyotaInFile.PriceAdded += ToyotaCarPriceAdded;

            do
            {
                Console.Write("Podaj markę samochodu żeby zapisać cenę lub naciśnij q żeby opuścić program   : ");
                mark = Console.ReadLine();
                switch (mark)
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
                        var statisticsInFiles = lexusInFile.GetStatistics();
                        Console.Clear();
                        Console.WriteLine($"Minimalna cena samochodów marki Lexus :{statisticsInFiles.Min:N2}");
                        Console.WriteLine($"Średnia cena samochodów marki Lexus :{statisticsInFiles.Average:N2}");
                        Console.WriteLine($"Maksymalna cena samochodów marki Lexus :{statisticsInFiles.Max:N2}");
                        Console.WriteLine($"Ceny samochodów marki Lexus wyliczone na podstawie :{statisticsInFiles.Count}", " cen");

                        statisticsInFiles = mitsubishiInFile.GetStatistics();
                        Console.WriteLine();
                        Console.WriteLine($"Minimalna cena samochodów marki Mitsubishi :{statisticsInFiles.Min:N2}");
                        Console.WriteLine($"Średnia cena samochodów marki Mitsubishi :{statisticsInFiles.Average:N2}");
                        Console.WriteLine($"Maksymalna cena samochodów marki Mitsubishi :{statisticsInFiles.Max:N2}");
                        Console.WriteLine($"Ceny samochodów marki Mitsubishi wyliczone na podstawie :{statisticsInFiles.Count}", " cen");

                        statisticsInFiles = subaruInFile.GetStatistics();
                        Console.WriteLine();
                        Console.WriteLine($"Minimalna cena samochodów marki Subaru :{statisticsInFiles.Min:N2}");
                        Console.WriteLine($"Średnia cena samochodów marki Subaru :{statisticsInFiles.Average:N2}");
                        Console.WriteLine($"Maksymalna cena samochodów marki Subaru :{statisticsInFiles.Max:N2}");
                        Console.WriteLine($"Ceny samochodów marki Subaru wyliczone na podstawie :{statisticsInFiles.Count}", " cen");

                        statisticsInFiles = toyotaInFile.GetStatistics();
                        Console.WriteLine();
                        Console.WriteLine($"Minimalna cena samochodów marki Toyota :{statisticsInFiles.Min:N2}");
                        Console.WriteLine($"Średnia cena samochodów marki Toyota :{statisticsInFiles.Average:N2}");
                        Console.WriteLine($"Maksymalna cena samochodów marki Toyota :{statisticsInFiles.Max:N2}");
                        Console.WriteLine($"Ceny samochodów marki Toyota wyliczone na podstawie :{statisticsInFiles.Count}", " cen");
                        break;
                }
            } while (mark != "Q" && mark != "q");
            break;
        case "q":
        case "Q":
            Console.WriteLine("Nie dodano ceny żadnego samochody.");
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