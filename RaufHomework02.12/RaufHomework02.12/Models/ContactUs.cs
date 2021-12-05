using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaufHomework02._12.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
        [MaxLength]
        public string Message { get; set; }

    }
}
