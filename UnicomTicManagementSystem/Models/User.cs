using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Plain text as per project scope
        public string Role { get; set; }     // Admin, Staff, Student, Lecturer
    }
}
