namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nums = "Ededler: ";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    nums += i;
                    nums += ", ";
                }
            }
            Console.WriteLine(nums);
        }
    }
}
