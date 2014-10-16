/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem1dll
 * File/Module: set.cs
 * Author: Christopher Anzalone
 * 
 */

using System;
using System.Collections.Generic;

namespace canzalon_problem1dll
{
    public class Set<K, E> where E : SetEle<K>
    {
        protected List<E> stab = new List<E>();
        public void Insert(E x)
        { stab.Add(x); }
        public E Find(K key)
        {
            foreach (E e in stab)
            { if (e.CmpKey(key)) return e; }
            return default(E);
        }
        public int Del(E e)
        {
            if (stab.Contains(e))
            {
                stab.Remove(e);
                return 0;
            }
            return -1;
        }
        public void PrintAll()
        {
            foreach (E e in stab)
                e.Print();
        }
        public int Select(K key)
        {
            int k = 0;
            foreach (E e in stab)
            {
                if (e.CmpKey(key))
                {
                    e.Print();
                    k++;
                }
            } return k;
        }
    }
}
