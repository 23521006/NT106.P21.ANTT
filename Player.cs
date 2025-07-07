using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace GameNT106
{
    [Table("player")]
    public class Player : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("win")]
        public int Win { get; set; }

        [Column("lose")]
        public int Lose { get; set; }
    }
}