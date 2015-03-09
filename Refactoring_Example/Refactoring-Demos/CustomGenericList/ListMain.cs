
namespace CustomGenericList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using GenericList;

    class ListMain
    {
        static void Main()
        {
            // Test method ToString()
            GenericList<int> numbers = new GenericList<int>();
            for (int number = 0; number < 5; number++)
            {
                numbers.Add(number);
            }

            Console.WriteLine(numbers);
        }
    }
}
