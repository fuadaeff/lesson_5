namespace Makulatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qrup sayini daxil edin:");
            int qrup_count = int.Parse(Console.ReadLine());
            double[] numbers = [qrup_count];
            for (int i = 0; i < qrup_count; i++)
            {
                double v = double.Parse(Console.ReadLine());
                numbers[i] = v;
            }
            double max = numbers[0];
            foreach (double num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("{0:0.00}",max);
        }
    }
}
