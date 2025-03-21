﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class Option
    {
        public int OptionId { get; set; }
        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string? Option3 { get; set; }

        public string? Option4 { get; set; }

        public string IsCorrect { get; set; }

        // Foreign Key
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
