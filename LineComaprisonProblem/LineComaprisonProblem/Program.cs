using System;

namespace LineComaprisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculateLength length = new CalculateLength(4, 8, 3, 5);
            length.Calculate();
                                    
            Console.ReadLine(); 
        }
    }
}
