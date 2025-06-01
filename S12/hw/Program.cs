namespace hw;

class Program
{
    static void Main(string[] args)
    {
        var myCar = new car("Pride", 4, 5, true);
        Console.WriteLine("--- Car ---");
        Console.WriteLine($"Name: {myCar.NameFunc()}");
        Console.WriteLine($"tedad   Tiers: {myCar.Tier()}");
        Console.WriteLine($"tedad   Seats: {myCar.sandali()}");
        Console.WriteLine($"sokht fossili estefade mikonad? {myCar.use_gasoline_benzin()}");
        Console.WriteLine();

        var myBus = new bus("qatar busway", 6, 30, true);
        Console.WriteLine("--- Bus Information ---");
        Console.WriteLine($"Name: {myBus.NameFunc()}");
        Console.WriteLine($"tedad   Tiers: {myBus.Tier()}");
        Console.WriteLine($"tedad   Seats: {myBus.sandali()}");
        Console.WriteLine($"sokht fossili estefade mikonad? {myBus.use_gasoline_benzin()}");
        Console.WriteLine();

        var myBicycle = new bicycle("orbea", 2, 1, false);
        Console.WriteLine("--- Bicycle ---");
        Console.WriteLine($"Name: {myBicycle.NameFunc()}");
        Console.WriteLine($"tedad   Tiers: {myBicycle.Tier()}");
        Console.WriteLine($"tedad   Seats: {myBicycle.sandali()}");
        Console.WriteLine($"sokht fossili estefade mikonad? {myBicycle.use_gasoline_benzin()}");
    }
}
