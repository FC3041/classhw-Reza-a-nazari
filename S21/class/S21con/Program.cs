namespace S21con;

#region پیاده سازی دستی
public static class Ext
{
        public static IEnumerable<T> Mytake<T>(this IEnumerable<T> source , int count)
        {
            List<T> values = new List<T>();
            foreach(var item in source)
            {
                if(values.Count() < count)
                {
                    values.Add(item);
                }
                else
                {
                    break ;
                }
            }
            return values ;
        }
    }

    #endregion
class Program
{

    static void Main(string[]args)
    {
        var data = File.ReadAllLines("children-per-woman-UN.csv")
        .Skip(1)
        // .Where(l=>! l.ToLower().Contains("iran"))
        .Select(l=>{
            string [] tokens = l.Split(',');
            string country = tokens[0];
            int year = int.Parse(tokens[2]);
            double rate = double.Parse(tokens[3]);
            return (country:country , year :year , rate :rate);
        }) ;

        data.Join(data , (d1)=>(d1.country,d1.year),
                         (d2)=>(d2.country,d2.year) , 
                         (d1,d2)=>(country : d1.country , y1:d1.year , y2:d2.year , r1:d1.rate , r2:d2.rate))
        .GroupBy(t=>t.country)
        .Select(g=>
        {
            var maxdiff = g.MaxBy(t=>Math.Abs(t.r2 - t.r1)) ;
            return (country : g.Key , diff : Math.Abs(maxdiff.r2 - maxdiff.r1));

        })
        .ToList()
        .ForEach(l=>System.Console.WriteLine(l));
        
    }

    // static void Main(string[] args)
    // {// take method juuuust for ienumerable 
    //     // string [] lines = 
    //     File.ReadAllLines("children-per-woman-UN.csv")
    //     .Skip(1)
    //     // .Where(l=>! l.ToLower().Contains("iran"))
    //     .Select(l=>{
    //         string [] tokens = l.Split(',');
    //         string country = tokens[0];
    //         int year = int.Parse(tokens[2]);
    //         double rate = double.Parse(tokens[3]);
    //         return (country:country , year :year , rate :rate);
    //     }) // khoroji tupple
    //     .GroupBy(t=>t.country)
    //     // .Where(t=>(t.year > 2012) && (t.rate > 3))
    //     // .OrderBy(t=> t.rate)
    //     .Select(g=>{
    //         return (country : g.Key , rate : g.Average(t=>t.rate));
    //     })
    //     .ToList()
        
    //     .ForEach(l=>System.Console.WriteLine(l));

    //     // foreach(var item in lines.Take(10)) //dotnet run|more
    //     // {
    //     //     System.Console.WriteLine(item);
    //     // }
    // }
}
