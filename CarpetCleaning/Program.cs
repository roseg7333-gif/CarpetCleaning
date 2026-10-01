namespace CarpetCleaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small, large;
            double cost, tax, total;
            Console.WriteLine("Enter number of small carpets:");
            small = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of large carpets:");
            large = Convert.ToInt32(Console.ReadLine());
            cost = (small * 25) + (large * 35);
            tax = cost * 0.06;
            total = cost + tax;
            Console.WriteLine("Cost:$" + cost);
            Console.WriteLine("Tax:$" + tax);
            Console.WriteLine("Total estimate:$" + total);
        }
    }
}
