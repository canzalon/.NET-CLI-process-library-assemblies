/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem1dll
 * File/Module: ActiveS.cs
 * Author: Christopher Anzalone 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canzalon_problem1dll
{
    public class ActiveS : S
    {
        private Set<string, P> sp;  //instance referencing P objects of particular suppliers

        /*Constructor creating new instance of ActiveS object, consequently creating sp set, initializing 
         * the S fields, and adding the ActiveS object to the S allset list (all by invoking base constructor)*/
        public ActiveS(string snum, string sname, int status, string city) : base (snum, sname, status, city)
        {
            sp = new Set<string, P>(); 
        }

        public void InsertP(string pnum)
        {
            P pref = P.pall.Find(pnum);  //get reference to a p record in the allset that matches pnum parameter
            
            /*if such a reference is found, check for duplicate in sp and insert it if there is none*/
            if (pref != null)  
            {
                P pref2 = sp.Find(pnum);
                if (pref2 == null) sp.Insert(pref);
            }
        }

        public override void Print()
        {
            base.Print();  //S.Print() prints supplier information
            sp.PrintAll();  //prints P information for parts referenced in the sp set
        }

        public void PrintP()
        {
            sp.PrintAll();  //prints P information for parts referenced in the sp set
        }

        /*Takes a pnum (string) as argument and deletes matched part from the sp set of the ActiveS object*/
        public int DeleteP(string pnum)
        {
            P partRef = sp.Find(pnum);  //find reference to part, indicated by pnum (K), in sp set of actives instance 
            
            if (partRef == null)  //part not found
            {
                return -1;
            }
            else //part found
            {
                sp.Del(partRef);  //pass part reference (E) to set.Del of sp/ActiveS instance
                return 0;  
            }
        }

        /*Takes a pnum string argument, finds all matches in the sp set of the ActiveS object and prints their P information.*/
        /* Also returns number of hits. */
        public int SelectP(string pnum)
        {
            int hits = 0;

            /*Calls Select method of Set object which takes pnum as argument and compares it against the list of suppliers 
             * in the sp set, if there are matches they are printed. A counter keeps track of the hits and is returned.*/
            //hits = sp.Select(pnum);
            hits = P.pall.Select(pnum);

            return hits;
        }
    }
}
