using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Indprowebbackend.DataModels
{
    public class NewsPosts
    {
        [Key]
        public int Id { get; set; }
        //public string pathname {get; set; } adda efter svenska har också kommit
        public string? Image { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Description { get; set; }
        public string? Quote { get; set; }
        public string? InternalLink { get; set; }
        public string? ExternalLink { get; set; }
        public string? Href { get; set; }
        public string? BlogPostHref { get; set; }
        public string? BlogPostBtnText { get; set; }
    }
}
