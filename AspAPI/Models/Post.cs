using System.ComponentModel.DataAnnotations;

namespace AspAPI.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please write a Title")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Please write a description")]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
