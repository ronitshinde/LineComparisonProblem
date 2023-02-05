using System;

namespace LineComaprisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            EqualityOfLines length_One = new EqualityOfLines(4, 2, 7, 3);
            double length = length_One.CalculateOne();

            EqualityOfLines length_Two = new EqualityOfLines(5, 8, 4, 6);
            double length_ = length_Two.CalculateTwo();

            if (length.Equals(length_))
                Console.WriteLine("Both line are equal");
            else
                Console.WriteLine("Both lines are not equal");

            Console.ReadLine();
        }
    }
}
