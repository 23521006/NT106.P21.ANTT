using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace GameNT106
{
    [Table("history")]
    public class History : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }

        [Column("winner")]
        public string Winner { get; set; }

        [Column("loser")]
        public string Loser { get; set; }
    }
}