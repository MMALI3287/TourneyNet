using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class TeamCommunication
    {
        [Key]
        public int Communication_id { get; set; }
        [Required]
        public int Sender_id { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        [ForeignKey("Team")]
        public int Team_Id { get; set; }
        public virtual Team Team { get; set; }
    }
}
