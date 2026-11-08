namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // read first name of user
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();

            // read last name of user
            Console.Write("Enter your last name");
            string lastname = Console.ReadLine();

            // option 1 to display the name
            Console.WriteLine("Your full name is " +firstname+ " " +lastname); 

            //option 2 to display your name
            Console.WriteLine("Your full name is   {0} {1}", firstname, lastname);


            // ooption 3 toop display the name (string interpolation)
            Console.WriteLine($"your full name is {firstname} {lastname}");



        }
    }
}
