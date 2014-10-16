/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem2
 * File/Module: GenericStack2.cs
 * Author: Christopher Anzalone
 * 
 */

using System;
using System.Collections.Generic;

public class OutofRangeArgs : EventArgs
{
    private int index;
    public OutofRangeArgs(int index2)
    {
        index = index2;
    }
    public int Index
    {
        get { return index; }
    }
}

public class GenericStack2<T>
{
    private T[] s;
    private int top = -1;

    public delegate void OutofRangeHandler(object sender, OutofRangeArgs e);
    public event OutofRangeHandler OutofRange;

    public GenericStack2(int size)
    { s = new T[size]; }
    public int Push(T x)
    {
        if (top == s.Length - 1) return -1;
        s[++top] = x;
        return 0;
    }
    public int Pop()
    {
        if (top == -1) return -1;
        top--;
        return 0;
    }
    public int TopVal(out T x)
    {
        if (top == -1)
        { x = default(T); return -1; }
        x = s[top];
        return 0;
    }

    /**/
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = top; i >= 0; i--)
        {
            yield return s[i];
        }
    }

    public T this[int i]
    {
        get
        {
            if (i <= top && i >= 0)
            {
                return s[top - i];
            }
            else
            {
                OutofRangeArgs e = new OutofRangeArgs(i);
                OutofRange(this, e);
                return default(T);
            }
        }
    }
}
