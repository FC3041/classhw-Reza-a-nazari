using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_EX
{
    enum LifeExpectancyType { AtBirth, At60 }
    enum DataGender { Male, Female, Both }

    class Data
    {
        public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
        {
            LEType = leType;
            Year = year;
            Territory = territory;
            Country = country;
            DataGender = dg;
            Value = value;
        }

        public LifeExpectancyType LEType { get; }
        public int Year { get; }
        public string Territory { get; }  
        public string Country { get; }
        public DataGender DataGender { get; }
        public double Value { get; }

        public override string ToString() =>
            $"{Country}, {Year}, {LEType}, {DataGender}, {Value}";

        public static Data Parse(string line)
        {
            var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();
            LifeExpectancyType leType = toks[0].Contains("60") ? LifeExpectancyType.At60 : LifeExpectancyType.AtBirth;
            int year = int.Parse(toks[1]);
            string territory = toks[2].ToLower();
            string country = toks[3].ToLower();
            DataGender dg = toks[4].Contains("Both") ? DataGender.Both : (toks[4].Contains("Male") ? DataGender.Male : DataGender.Female);
            double value = double.Parse(toks[5]);
            return new Data(leType, year, territory, country, dg, value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("data.csv").Skip(1);
            var dataList = lines.Select(line => Data.Parse(line)).ToList();

            Console.WriteLine("Query 1");

            var query1 = dataList
                .Where(d =>
                    d.Country.ToLower() == "iran (islamic republic of)" &&
                    d.LEType == LifeExpectancyType.AtBirth &&
                    d.DataGender == DataGender.Both)
                .OrderBy(d => d.Value);

            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            
            Console.WriteLine("Query 2");
            
            double minimum = query1.Min(d=>d.Value);
            double maximum = query1.Max(d=>d.Value);
            double delta = maximum - minimum ;

            System.Console.WriteLine(delta);


            Console.WriteLine();
            
            
            Console.WriteLine("Query 3");

            var query3 = dataList
            .Where(d=>d.DataGender == DataGender.Both &&
            d.LEType == LifeExpectancyType.AtBirth)
            .GroupBy(d=>d.Country)
            .Select(g => new
            {
                Country = g.Key,
                minyear =g.OrderBy(d => d.Value).First().Year, 
                minval =g.Min(d => d.Value),                     
                MaxValue =g.Max(d => d.Value),                     
                behboodi =g.Max(d => d.Value)-g.Min(d => d.Value) 
            })
            .OrderByDescending(x=>x.behboodi)
            .Select((item,index)=> new{
                rotbe = index + 1,
                item.Country,
                item.minyear,
                item.minval,
                item.behboodi
            });


        
            foreach(var item in query3)
            {
                System.Console.WriteLine($"{item.rotbe} , {item.Country} , {item.minyear} , {item.minval} , {item.behboodi}");
            }
            







            Console.WriteLine();

            Console.WriteLine("Query 4");
            
            var query4 = dataList
            .Where(d=>d.LEType == LifeExpectancyType.AtBirth && (d.DataGender == DataGender.Male || d.DataGender ==DataGender.Female))
            .GroupBy(d=> new {d.Country , d.Year})
            .Where(g => g.Count() >= 2 && g.Any(x => x.DataGender == DataGender.Male) && g.Any(x => x.DataGender == DataGender.Female))
            .Select(g=>
            {
                var maleval = g.First(x=>x.DataGender == DataGender.Male).Value ;
                var femaleval = g.First(x=>x.DataGender == DataGender.Female).Value ;
                return new 
                {
                    g.Key.Country,
                    g.Key.Year,
                    male = maleval ,
                    female = femaleval ,
                    ekhtelaf = Math.Abs(maleval - femaleval)
                };

            })
            .GroupBy(x=>x.Country)
            .Select(g=>g.OrderByDescending(x => x.ekhtelaf).First())
            .OrderByDescending(x => x.ekhtelaf)
            .Select((x,index) =>  new 
            {
                rotbe = index + 1 ,
                x.Country ,
                x.Year ,
                x.male ,
                x.female ,
                x.ekhtelaf
            });


            foreach(var item in query4)
            {
                System.Console.WriteLine($"{item.rotbe} , {item.Country} , { item.male} , {item.female}, {item.ekhtelaf}");
            }




            Console.WriteLine();
        }
    }
}
