using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateExam.Data.Models
{
    public class RequestModel
    {
        public class Q1
        {
            public string q { get; set; }
            public string q1a1 { get; set; }
            public string q1a2 { get; set; }
            public string q1a3 { get; set; }
            public string q1a4 { get; set; }
        }

        public class Q2
        {
            public string q { get; set; }
            public string q2a1 { get; set; }
            public string q2a2 { get; set; }
            public string q2a3 { get; set; }
            public string q2a4 { get; set; }
        }

        public class Q3
        {
            public string q { get; set; }
            public string q3a1 { get; set; }
            public string q3a2 { get; set; }
            public string q3a3 { get; set; }
            public string q3a4 { get; set; }
        }

        public class Q4
        {
            public string q { get; set; }
            public string q4a1 { get; set; }
        }

        public class Request
        {
            public Q1 q1 { get; set; }
            public Q2 q2 { get; set; }
            public Q3 q3 { get; set; }
            public Q4 q4 { get; set; }
        }
    }
}
