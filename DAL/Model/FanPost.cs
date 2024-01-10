using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class FanPost
    {
        [Key]
        public int FanPost_id { get; set; }
        public string PostContent { get; set; }
        public DateTime PostDate { get; set; }

        [ForeignKey("Registration")]
        public int Posted_by_Id { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
