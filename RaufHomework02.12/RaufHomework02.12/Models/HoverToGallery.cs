using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RaufHomework02._12.Models
{
    public class HoverToGallery
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Gallery")]

        public int GalleryId { get; set; }
        public Gallery Gallery { get; set; }
        [ForeignKey("GalleryHover")]
        public int GalleryHoverId { get; set; }
        public GalleryHover GalleryHover { get; set; }
    }
}
