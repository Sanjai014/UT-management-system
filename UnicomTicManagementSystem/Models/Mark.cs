﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Mark
    {
        public int MarkID { get; set; }
        public int StudentID { get; set; }
        public int ExamID { get; set; }
        public int Score { get; set; } // 0 - 100
    }
}
