/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem2
 * File/Module: IntStackUser.cs
 * Author: Christopher Anzalone
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canzalon_problem2
{
    class IntStackUser
    {
        static void Main()
        {
            Console.WriteLine("B. Creates a GenericStack2<int> object.");
            GenericStack2<int> theStack = new GenericStack2<int>(10);

            Console.WriteLine("A. Registers an anonymous method as a handler for the OutofRange event.");
            theStack.OutofRange += delegate(object sender, OutofRangeArgs e)
            {
                Console.Write("Index " + e.Index + " is out of range.");
                Console.WriteLine("Terminating the program due to index out of range.");
                System.Environment.Exit(0);
            };

            Console.WriteLine("C.Pushes 3, 5, and 7 onto the stack.");
            theStack.Push(3);
            theStack.Push(5);
            theStack.Push(7);

            Console.WriteLine("D. Uses a foreach statement to print the stack elements in reverse.");
            foreach (int i in theStack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("E. Prints the element two positions below the top of the stack.");
            Console.WriteLine(theStack[2]);

            Console.WriteLine("F.Pops all the elements off the stack.");
            theStack.Pop();
            theStack.Pop();
            theStack.Pop();

            Console.WriteLine("G.Tries to print the element two positions below the top of the stack.");
            Console.WriteLine(theStack[2]);
        }
    }
}
