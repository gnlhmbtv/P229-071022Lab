namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ededi daxil edin");
            int num;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("ededin quvvetini daxil edin ");
            int power;
            power = int.Parse(Console.ReadLine());
            double result = Math.Pow(num, power);
            Console.WriteLine(result);
        }
    }
}