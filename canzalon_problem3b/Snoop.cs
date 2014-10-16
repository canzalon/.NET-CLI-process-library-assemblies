/*
 * Solution: .NET-CLI-process-library-assemblies (assig2.doc)
 * Project: canzalon_problem3b
 * File/Module: Snoop.cs
 * Author: Christopher Anzalone
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using canzalon_problem3a;

namespace canzalon_problem3b
{
    class Snoop
    {
        static void Main()
        {
            Console.WriteLine("Please enter the name of the assembly file...");
            string assemblyFile = Console.ReadLine();

            /*Load the assembly file*/
            Assembly a = Assembly.LoadFrom(assemblyFile);
            AssemblyName an = a.GetName();

            /*Check to see whether the assembly is strongly-named or not*/
            byte[] b;
            b = a.GetName().GetPublicKey();
            if (b.Length > 0)
            {
                Console.WriteLine("The assembly is strongly-named.\n");
            }
            else
            {
                Console.WriteLine("\nThe assembly is not strongly-named.\n");
            }

            /*Detail the modules that make up the assembly*/
            Console.WriteLine("\nModules");
            Module[] modules = a.GetModules();
            foreach (Module module in modules)
            {
                Console.WriteLine("  " + module.Name);
            }

            /*List the types that are exported from the assembly*/
            Console.WriteLine("\nExported Types and UsedBy Assemblies");
            Type[] types = a.GetExportedTypes();
            foreach (Type type in types)
            {
                Console.WriteLine("  " + type.Name);
                MemberInfo info = type;
                object[] attributes = info.GetCustomAttributes(false);

                if (attributes.Length > 0)
                {
                    foreach (object attribute in attributes)
                    {
                        if (!(attribute is UsedByAttribute)) continue;
                        UsedByAttribute c = (UsedByAttribute)attribute;
                        Console.WriteLine("    SourceFile: {0}", c.SourceFile);
                        Console.WriteLine("    ClassName: {0}", c.ClassName);
                        if (c.ProjectName != null)
                            Console.WriteLine("    ProjectName: {0}", c.ProjectName);
                    }
                }
            }

            /*List referenced assemblies of the assembly*/
            Console.WriteLine("\nReferenced Assemblies");
            AssemblyName[] names = a.GetReferencedAssemblies();
            foreach (AssemblyName name in names)
            {
                Console.WriteLine("  " + name.Name);
            }

        }
    }
}
