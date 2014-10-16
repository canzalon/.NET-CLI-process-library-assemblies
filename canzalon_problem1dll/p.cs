/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem1dll
 * File/Module: p.cs
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
    /* P is a parts class that has an allset of type Set. */

    public class P : SetEle<string>
    {
        protected string pnum;
        protected string pname;
        protected string city;
        protected string color;
        protected double wt;
        internal static Set<string, P> pall = new Set<string, P>();
        public P(string pnumc, string pnamec, string cityc,
                   string colorc, double wtc)
        {
            pall.Insert(this);
            pnum = string.Copy(pnumc);
            pname = string.Copy(pnamec);
            city = string.Copy(cityc);
            color = string.Copy(colorc);
            wt = wtc;
        }
        public bool CmpKey(string key)
        { return pnum == key; }
        public void Print()
        {
            Console.WriteLine("pnum = " + pnum + " pname = " + pname +
                               " city = " + city + " color = " + color +
                               " wt = " + wt);
        }
        public static void PrintAll()
        { pall.PrintAll(); }
        public void Update(string pnumc, string pnamec, string cityc,
                           string colorc, double wtc)
        {
            if (pnumc != null) pnum = string.Copy(pnumc);
            if (pnamec != null) pname = string.Copy(pnamec);
            if (cityc != null) city = string.Copy(cityc);
            if (colorc != null) color = string.Copy(colorc);
            if (wtc != -1.0) wt = wtc;
        }
        public static int Select(string key)
        { return pall.Select(key); }
        public int Del()
        { return pall.Del(this); }
    }

}
