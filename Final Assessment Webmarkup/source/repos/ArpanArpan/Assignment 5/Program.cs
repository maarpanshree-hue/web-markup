namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int euta = rnd.Next(101,10000);
            int duita = rnd.Next(101, 10000);
            int tinta = rnd.Next(101, 10000);
            int chada = rnd.Next(101, 10000);
            Console.WriteLine($"Add these numbers {euta} {duita} {tinta} {chada}");
            string userlaehaneko = Console.ReadLine();
            int result = int.Parse(userlaehaneko);

            int actualchai = euta + duita + tinta + chada;
            bool hokihaina;
         
            hokihaina = (result == actualchai);
            Console.WriteLine($"Your result is {hokihaina}");

            

        }
    }
}
