using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Assignment7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Console.WriteLine("Enter the dimension");
            int dimension = int.Parse(Console.ReadLine());
            PrintSquare(dimension);
        }
        public void PrintSquare(int dimensionSize)
        {
            for (int i = 0; i < dimensionSize; i++)
            {
                for (int j = 1; j < dimensionSize; j++)
                {
                    
                    if (i >=0 && i<= (dimensionSize -1) && j==0&&j== (dimensionSize-1))
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.WriteLine("X");
                    }
                    
                }
              
                
                    Console.WriteLine();
                




            }

        }

    }
}



