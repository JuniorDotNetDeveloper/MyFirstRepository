using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectForGit.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }

        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now); 
        
        }
    }
}
