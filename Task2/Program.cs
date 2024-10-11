namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var = 85;
            if (var < 65)
            {
                Console.WriteLine("Kəsildin");
            }
            else if (var < 85)
            {
                Console.WriteLine("Adi Diplom");
            }
            else if (var < 95)
            {
                Console.WriteLine("Şərəf Diplomu");
            }
            else
            {
                Console.WriteLine("Yüksək Şərəf Diplomu");
            }
        }
    }
}
