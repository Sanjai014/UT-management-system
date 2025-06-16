using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
     public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }   // e.g., Lab 1, Hall A
        public string RoomType { get; set; }   // "Lab" or "Hall"
    }
}
