using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreateExam.Data.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

    }
}
