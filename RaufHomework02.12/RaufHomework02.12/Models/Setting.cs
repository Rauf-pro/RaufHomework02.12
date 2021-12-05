using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaufHomework02._12.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [MaxLength(250)]
        public string Location { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string BgImage{ get; set; }
        [MaxLength(100)]
        public string CopyRight { get; set; }

    }
}
