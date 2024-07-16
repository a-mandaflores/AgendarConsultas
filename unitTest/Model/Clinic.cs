using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendarConsultas.Model
{
    public class Clinic
    {
        [Key]
        public int id { get; set; }

        [Column("uuid")]
        public Guid Uuid { get; set; } = Guid.NewGuid();

        [Column("name")]
        public string Name { get; set; } = string.Empty!;

        [Column("cell")]
        public string? Cell { get; set; }

        [Column("email")]
        public string Email { get; set; } = string.Empty!;
        public Secretary? Secretary { get; set; }

        public Dictionary<string ,DateTime> Schedule { get; set; } = default!;
    }
}