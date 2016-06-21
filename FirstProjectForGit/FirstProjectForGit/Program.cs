using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass obj;
            Console.WriteLine("was defined a link on static class\n");

            Console.WriteLine("i will call static method");
            StaticClass.WriteTextMethod();
            Console.ReadLine();
        }
    }
}
