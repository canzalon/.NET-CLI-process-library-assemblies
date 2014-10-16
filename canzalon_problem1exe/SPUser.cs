/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem1exe
 * File/Module: SPUser.cs
 * Author: Christopher Anzalone
 * 
 */

using System;
using System.Collections.Generic;
using canzalon_problem1dll;

namespace canzalon_problem1exe
{
    class SPUser
    {
        static void Main()
        {
            Console.WriteLine("a. Creating an ActiveS objects for suppliers S2 and S3.");
            ActiveS supplierOne;
            supplierOne = new ActiveS("S2", "Smith", 20, "Paris");
            ActiveS supplierTwo;
            supplierTwo = new ActiveS("S3", "Jones", 100, "London");

            Console.WriteLine("b. Creating an ActiveS objects for supplier S1.");
            S sObject;
            sObject = new S("S1", "Jones", 10, "Boston");

            Console.WriteLine("c. Creating P objects P1, P2 and P3.");
            P pObjOne;
            pObjOne = new P("P1", "Bolt", "Paris", "Red", 12.8);
            P pObjTwo;
            pObjTwo = new P("P2", "Nut", "Boston", "Red", 10.1);
            P pObjThree;
            pObjThree = new P("P3", "Cog", "London", "Brown", 17.5);

            Console.WriteLine("d. Printing all S objects with PrintAll");
            S.PrintAll();
            Console.WriteLine("d. Printing all P objects with PrintAll");
            P.PrintAll();

            Console.WriteLine("e. Adding references to the P objects in c, to the sp set of S2 ActiveS obj.");
            supplierOne.InsertP("P1");
            supplierOne.InsertP("P2");

            Console.WriteLine("f. Printing all S objects with PrintAll");
            S.PrintAll();
            Console.WriteLine("f. Printing all P objects with PrintAll");
            P.PrintAll();

            Console.WriteLine("g. Using PrintP to print P objects for parts supplied by S2");
            supplierOne.PrintP();

            Console.WriteLine("h. Using SelectP to print the P2 object.");
            supplierOne.SelectP("P2");

            Console.WriteLine("i. Deleting the ref to the P2 obj from sp set for S2.");
            supplierOne.DeleteP("P2");

            Console.WriteLine("j. Using PrintP to print P objects for parts supplied by S2");
            supplierOne.PrintP();

            Console.WriteLine("k. Deleting the ref to the S2 obj from the S allset");
            supplierOne.Del();

            Console.WriteLine("l. Printing all S objects with PrintAll");
            S.PrintAll();
            Console.WriteLine("l. Printing all P objects with PrintAll");
            P.PrintAll();
        }
    }
}
