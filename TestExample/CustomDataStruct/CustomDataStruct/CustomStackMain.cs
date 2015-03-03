
namespace CustomDataStruct
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomStackMain
    {
        static void Main()
        {
            CustomStack<int> customStack = new CustomStack<int>();

            customStack.Push(4);
            Console.WriteLine("After customStack.Push(4) -> ");
            Console.WriteLine("customStack.Peek(): {0}", customStack.Peek());
            Console.WriteLine("customStack.Pop(): {0}", customStack.Pop());
            Console.WriteLine("customStack.Contains(3): {0}", customStack.Contains(3));

            for (int i = 0; i < 10; i++)
            {
                customStack.Push(i);
                Console.WriteLine("After customStack.Push({0}) ->", i);
                Console.WriteLine("customStack.Contains({0}): {1}", 
                    i, customStack.Contains(i));
            }

            Console.WriteLine("customStack.Pop(): {0}", customStack.Pop());
            Console.WriteLine("customStack.Peek(): {0}", customStack.Peek());
            Console.WriteLine("customStack.Contains(3): {0}", customStack.Contains(3));
        }
    }
}
