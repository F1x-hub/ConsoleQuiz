﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Exam
    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string CorrectAnswer { get; set; }
        public override string ToString()
        {
            return $"Question: {Question} \n1. {Answer1}\n2. {Answer2}\n3. {Answer3}\n4. {Answer4}";
        }
    }
}
