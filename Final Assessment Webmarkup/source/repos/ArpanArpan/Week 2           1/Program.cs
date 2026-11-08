namespace Week_2___________1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
            
        }
    void Start()
        { Console.WriteLine("Enter your age");
            
            string time = Console.ReadLine();
            int jan19 = int.Parse(time);
            IsAdult(jan19);
            Console.WriteLine("a" + );
            
        }
        bool IsAdult(int age) {


            bool sugam = (age >= 18);
            return sugam;
        }
        
    }
}
