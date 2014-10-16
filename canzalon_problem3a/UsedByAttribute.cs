/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem3a
 * File/Module: UsedByAttribute.cs
 * Author: Christopher Anzalone
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canzalon_problem3a
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]

    public class UsedByAttribute : Attribute
    {
        public string ClassName;
        public string SourceFile;
        public string ProjectName;

        public UsedByAttribute(string classname, string sourcefile)
        {
            ClassName = classname;
            SourceFile = sourcefile;
        }
    }
}
