// Brian Hodge
// C00170400
// CMPS 358
// Project #8

using System;
using System.Linq;

namespace World
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.Write("Enter a country name: ");
            //ListCities(Console.ReadLine());
            //Console.Write("Enter a continent name:  ");
            //CountriesInContinent(Console.ReadLine());
            //Console.Write("Enter first letter:   ");
            //ListByFirstLetter(Convert.ToChar(Console.ReadLine()!));
            //Console.Write("Enter city name:   ");
            //ListInfoAboutCity(Console.ReadLine());
            
            Console.WriteLine(1 + " - List Cities by Country");
            Console.WriteLine(2 + " - List Countries by Continent");
            Console.WriteLine(3 + " - List Countries by First Letter");
            Console.WriteLine(4 + " - List Information for a City");
            Console.WriteLine(0 + " - Exit");
            var userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput != 0)
            {
                if (userInput == 1)
                {
                    Console.Write("Enter Country:  ");
                    ListCities(Console.ReadLine());
                    Console.WriteLine();
                }
                else if (userInput == 2)
                {
                    Console.Write("Enter the Continent:  ");
                    CountriesInContinent(Console.ReadLine());
                    Console.WriteLine();
                }
                else if (userInput == 3)
                {
                    Console.Write("Enter the First Letter of Countries to List(In Uppercase):  ");
                    ListByFirstLetter(Convert.ToChar(Console.ReadLine()));
                    Console.WriteLine();
                }
                else if (userInput == 4)
                {
                    Console.Write("Enter City (With correct Uppercase letters):  ");
                    ListInfoAboutCity(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine(1 + " - List Cities by Country");
                Console.WriteLine(2 + " - List Countries by Continent");
                Console.WriteLine(3 + " - List Countries by First Letter");
                Console.WriteLine(4 + " - List Information for a City");
                Console.WriteLine(0 + " - Exit");
                userInput = Convert.ToInt32(Console.ReadLine());
            }


        }

        static void ListCities(string country)
        {
            using (var db = new World())
            {
                var results =
                    from ci in db.Cities
                    join co in db.Countries
                        on ci.CountryCode equals co.Code
                    orderby ci.Name
                    where co.Name == country
                    select ci.Name;

                if (results.Count() == 0)
                {
                    Console.WriteLine($"No cities in {country}");
                    return;
                }

                Console.WriteLine($"Cities in {country}");
                foreach (var c in results)
                    Console.WriteLine($"   {c}");
                Console.WriteLine();
            }
        }

        // static method 2(a) to find and list all countries in a continent in alphabetical order
        static void CountriesInContinent(string continent)
        {
            using (var db = new World())
            {
                var results =
                    from co in db.Countries
                    where co.Continent == continent
                    orderby co.Name
                    select co.Name;

                if (results.Count() == 0)
                {
                    Console.WriteLine($"No countries in {continent}");
                    return;
                }

                Console.WriteLine($"Countries in {continent}");
                foreach (var c in results)
                    Console.WriteLine($"    {c}");
                Console.WriteLine();
                {

                }
            }
        }

        // static method 2(b) to find then list the country, continent, region, and country code of all countries that begin with the letter entered by the user.
        static void ListByFirstLetter(char letter)
        {
            using (var db = new World())
            {
                var results =
                    from co in db.Countries.ToList()
                    where co.Name[0] == letter
                    orderby co.Name
                    select ($"{co.Name}, Continent: {co.Continent}, Region: {co.Region}, Code: {co.Code}");
                
                

                if (results.Count() == 0)
                {
                    Console.WriteLine($"No countries beginning with letter {letter}");
                    return;
                }

                Console.WriteLine($"Countries beginning with letter {letter}");
                foreach (var v in results)
                    Console.WriteLine($"    {v}");
                Console.WriteLine();



            }
        }
        // static method 2(c) find and list every instance of the city entered including the city name, population, district, country, and country code
        static void ListInfoAboutCity(string city)
        {
            using (var db = new World())
            {
                var results =
                    from ci in db.Cities
                    from co in db.Countries
                    where ci.CountryCode == co.Code
                    where ci.Name == city
                    orderby ci.Name
                    select ($"City: {ci.Name}, Population: {ci.Population}, District: {ci.District}, Country: {co.Name}, CountryCode: {ci.CountryCode}");

                if (results.Count() == 0)
                {
                    Console.WriteLine("No cities listed with this name.");
                    return;
                }

                foreach (var result in results)
                    Console.WriteLine($"     {result}");
                Console.WriteLine();
                

            }
        }

    }
}
    