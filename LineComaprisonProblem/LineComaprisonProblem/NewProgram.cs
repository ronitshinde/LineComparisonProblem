using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComaprisonProblem
{
    public class NewProgram
    {
        public void Compare()
        {
            CompareTwoLines length_One = new CompareTwoLines(7, 6, 4, 2);
            double length = length_One.CalculateOne();

            CompareTwoLines length_Two = new CompareTwoLines(4, 9, 2, 1);
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
