namespace KisedekiFiskalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fiskalarin sayini daxil edin:");
        Label1:
            bool is_integer = int.TryParse(Console.ReadLine(), out int n);
            if (!is_integer)
            {
                Console.WriteLine("Duzgun eded daxil edin!");
                goto Label1;
            }
            if (n == 0)
            {
                Console.WriteLine("Kise bosdur((");
                return;
            }
            int[] fiskalar = [n];
            Console.WriteLine("Fiskalari daxil edin:");
            for (int i = 0; i < n; i++) {
                int fiska = int.Parse(Console.ReadLine());
                fiskalar[i] = fiska;
            }
            Console.WriteLine("Tapmaq istediyiniz ededi daxil edin:");
            int bolen = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (int num in fiskalar)
            {
                if (num % bolen == 0)
                {
                    count++;
                }
            }
            int percentage = (n / count) * 100;
            Console.WriteLine(count);
            Console.WriteLine($"{percentage}%");
            
        }
    }
}
