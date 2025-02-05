namespace MaxAndMinFerqi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = [length];
            for (int i = 0; i < length; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }
            int max = numbers[0];
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            if (min == 0)
            {
                Console.WriteLine("En kicik eded 0 oldugu ucun bolme emelliyyati yerine yetirmek mumkun deyil!");
                return;
            }
            int multiple = max * min;
            int division = max / min;
            int result = multiple / division;
            Console.WriteLine(result);
            
        }
    }
}
