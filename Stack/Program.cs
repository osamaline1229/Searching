using System;
using System.Collections;

namespace Stack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            stack mystack = new stack();
            mystack.push(100);


            Console.WriteLine("The Stack vlaue are :");
            printStackvalue(st);
            Console.WriteLine("The Lenght of My stack is:");
            Console.WriteLine(mystack.Count);
            Console.WriteLine();
            mystack.Pop();
            mystack.Peek();
            Console.WriteLine("The Stack vlaue are :" + mystack.Peek());
            printStackvalue(mystack);

            Console.WriteLine("The Stack vlaue are :");
            mystack.Push("the top of Stack");
            printStackvalue(mystack);

        }


    }


}
