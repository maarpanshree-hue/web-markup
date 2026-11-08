namespace ArpanArpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // varaible name is declared here
            string name;

            // read the name of the user and save it in varaible 'name'
            Console.Write("Enter your name:");
            name = Console.ReadLine();

            // read the age of the user and save it in varaible 'age'
            // (varaiable 'age' is declared here and immediately given a value 
            Console.Write("Enter your age");
            string age = Console.ReadLine();

            // display name and age 
            Console.WriteLine("Your name is" + name);
            Console.WriteLine("Your age is " + age);

            // wait for the user to enter a key 
            Console.ReadKey();
             




           
        }
    }
}
