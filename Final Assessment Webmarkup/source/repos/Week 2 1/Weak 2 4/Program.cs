using System.Net.Security;

namespace Weak_2_4
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
            Console.WriteLine("Write the two numbers to calculate:");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Enter a symbol to calculate accordingly +,-,*,%");
            string nam =Console.ReadLine();
            double heeaa = 0;

            getsign(num1, num2, nam, heeaa);
            Console.WriteLine(heeaa);

           
            

            
            
        }
         double getsign(double num, double nuum,string Sristi,double hello)
        {
            string huhu;
            switch (Sristi)
            {
                case "+":
                    hello = num + nuum;
                    return hello;
                   
                case "-":
                    hello = num - nuum;
                    return hello;
                    
                case "*":
                    hello = num * nuum;
                    return hello;
                   
                case "%":
                    hello = num % nuum;
                    return hello;
                    
                default :
                    huhu = "Your symbol is invalid";
                    break;

                    
                





            }
            

        }

    }
}
