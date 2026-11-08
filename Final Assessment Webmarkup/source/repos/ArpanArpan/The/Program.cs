namespace The
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            program.Start();

        }
        void Start()
        {
            int end = 0;
           
            Console.WriteLine("Enter your target number:");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your  number:");
            int and = int.Parse(Console.ReadLine());
            while (and != 0)
            {
                if (and == target)
                
                    end = end +1;// we can also do end ++
                
                Console.WriteLine("Enter a number:");
                and  = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number of target number {end}");



        }
    }
}
