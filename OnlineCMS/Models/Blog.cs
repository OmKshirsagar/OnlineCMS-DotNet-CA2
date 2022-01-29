using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineCMS.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string BlogContent { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
