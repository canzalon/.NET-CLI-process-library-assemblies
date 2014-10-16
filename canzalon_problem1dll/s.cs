/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem1dll
 * File/Module: s.cs
 * Author: Christopher Anzalone
 * 
 */

using System;

namespace canzalon_problem1dll
{
    /* S is a supplier class that has an allset field of type Set. */

    public class S : SetEle<string>
    {
        private string snum;
        private string sname;
        private int status;
        private string city;
        private static Set<string, S> sall = new Set<string, S>();
        public S(string snumc, string snamec,
                 int statusc, string cityc)
        {
            sall.Insert(this);
            snum = string.Copy(snumc);
            sname = string.Copy(snamec);
            city = string.Copy(cityc);
            status = statusc;
        }
        public bool CmpKey(string key)
        {
            return (snum == key);
        }
        public virtual void Print()
        {
            Console.WriteLine("snum = " + snum
                               + " sname = " + sname
                               + " status = " + status
                               + " city = " + city);
        }
        public void Update(string snumu, string snameu,
                            int statusu, string cityu)
        {
            if (snumu != null) snum = string.Copy(snumu);
            if (snameu != null) sname = string.Copy(snameu);
            if (statusu != -1) status = statusu;
            if (cityu != null) city = string.Copy(cityu);
        }
        public int Del()
        { return sall.Del(this); }
        public static void PrintAll()
        { sall.PrintAll(); }
        public static int Select(string key)
        {
            return sall.Select(key);
        }
    }

}
