using System.ComponentModel.DataAnnotations;

namespace OnlineCMS.Models
{
    public class Page
    {
        [Key]
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
