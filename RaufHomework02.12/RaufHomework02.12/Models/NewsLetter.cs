using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaufHomework02._12.Models
{
    public class NewsLetter
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
