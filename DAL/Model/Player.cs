using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class Player
    {
        [Key]
        public int player_Id { get; set; }
        public string gender { get; set; }
        public string nationality { get; set; }
        public int age { get; set; }

        [ForeignKey("Registration")]
        public int player_reg_id { get; set; }
        public virtual Registration Registration { get; set; }

        public virtual ICollection<PlayerGame> PlayerGames { get; set; }

        public Player()
        {
            PlayerGames = new List<PlayerGame>();
        }
    }
}
