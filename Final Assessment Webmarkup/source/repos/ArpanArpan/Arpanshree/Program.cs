namespace Arpanshree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your age:")
            string input = Console.ReadLine();

            int age = int.Parse(input);



            age = age + 1;


            string output = age.ToString();


            Console.Write("Next year you will  be " + age + "years");



        }
    }
}
