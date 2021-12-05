using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaufHomework02._12.Models
{
    public class GalleryHover
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }

        public  HoverToGallery HoverToGalleries{ get; set; }
        
    }
}
