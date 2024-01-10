using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class SocialMediaSharing
    {
        [Key]
        public int share_id { get; set; }

        public DateTime share_date { get; set; }

        public string platform { get; set; }

        public string share_description { get; set; }
    }
}
