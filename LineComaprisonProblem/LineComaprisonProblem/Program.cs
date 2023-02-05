using System;

namespace LineComaprisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            CompareTwoLines length_One = new CompareTwoLines(4, 2, 7, 3);
            double length = length_One.CalculateOne();

            CompareTwoLines length_Two = new CompareTwoLines(5, 4, 5, 6);
            double length_ = length_Two.CalculateTwo();

            if (length.CompareTo(length_) == 0)
                Console.WriteLine("Both lines are equal ");
            else if (length.CompareTo(length_) > 0)
                Console.WriteLine("Line one is greater");
            else
                Console.WriteLine("Line two is greater");
            Console.ReadLine();
        }
    }
}
