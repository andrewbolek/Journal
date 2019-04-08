using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Help
{
    public class HelpUser
    {

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class HelpEntry
    {

        public int JournalID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Entry { get; set; }

    }
    public class UserContext
    {
        public static int UserId { get; set; }
    }
         

    
}
