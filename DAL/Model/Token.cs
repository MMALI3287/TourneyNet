using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Repos
{
    public class Token
    {
        [Key]
        public int token_id { get; set; }
        [Required]
        public string Token_key { get; set; }
        [Required]
        public DateTime Created_at { get; set; }
        public DateTime? deleted_at { get; set; }

        [Required]
        public string User_id { get; set; }

        public string Type { get; set; }

        public int reg_id { get; set; }

    }
}
