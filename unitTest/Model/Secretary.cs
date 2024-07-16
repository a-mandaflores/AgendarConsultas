using System.ComponentModel.DataAnnotations.Schema;

namespace AgendarConsultas.Model
{
    public class Secretary
    {
        public int id { get; set; }
        public Guid Uuid { get; set; } = Guid.NewGuid();

        [Column("name")]
        public string Name { get; set; } = string.Empty!;

        [Column("cell")]
        public string? Cell { get; set; }

        [Column("email")]
        public string Email { get; set; } = string.Empty!;
    }
}