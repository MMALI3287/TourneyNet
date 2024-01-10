using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class Stream
    {
        [Key]
        public int Stream_id { get; set; }
        [Required]
        public string Stream_link { get; set; }
        public string Stream_description { get; set; }

    }
}
