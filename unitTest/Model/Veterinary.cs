using System.ComponentModel.DataAnnotations.Schema;

namespace AgendarConsultas.Model
{
    public class Veterinary
    {
        public int id { get; set; }

        [Column("uuid")]
        public Guid Uuid { get; set; } = Guid.NewGuid();

        [Column("name")]
        public string Name { get; set; } = string.Empty!;

        [Column("cell")]
        public string? Cell { get; set; }

        [Column("email")]
        public string Email { get; set; } = string.Empty!;

        public List<DateTime> DateOnly { get; set; } = default!;
    }
}