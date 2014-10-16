/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem1dll
 * File/Module: setele.cs
 * Author: Christopher Anzalone
 * 
 */

using System;

namespace canzalon_problem1dll
{
    /* A Set element must have a CmpKey and a Print method.  This is
    enforced by having the type of any Set element implement the 
    SetEle interface. */

    public interface SetEle<K>
    { 
        bool CmpKey ( K key );
        void Print();
    }
}
