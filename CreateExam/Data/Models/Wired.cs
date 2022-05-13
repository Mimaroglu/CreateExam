using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateExam.Data.Models
{
    public class Wired
    {
        public int Id { get; set; }
        public List<News> NewsList { get; set; }

    }

    public class News
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
