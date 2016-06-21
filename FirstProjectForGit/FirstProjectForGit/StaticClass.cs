using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectForGit
{
    class StaticClass
    {
        static StaticClass()
        {
            Console.WriteLine("this is static constructor");
        }

        public StaticClass()
        {
            Console.WriteLine("this is the normal constructor");
        }

        public static void WriteTextMethod()
        {
            Console.WriteLine("you invoked static method");
        }

        public void ShowDate()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
