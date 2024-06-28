namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car();
            newCar.Make = "Subaru";
            newCar.Model = "Outback";
            newCar.Year = 2050;
            newCar.Color = "turquoise";

            Console.WriteLine($"This is a {newCar.Color} {newCar.Make} {newCar.Model} made in the year {newCar.Year}.");
        }
    }
}
