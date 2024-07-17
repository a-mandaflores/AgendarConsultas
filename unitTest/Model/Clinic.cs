using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendarConsultas.Model
{
    [Table("clinic")]
    public class Clinic
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("uuid")]
        public Guid Uuid { get; set; } = Guid.NewGuid();

        [Column("name")]
        public string Name { get; set; } = string.Empty!;

        [Column("cell")]
        public string? Cell { get; set; }

        [Column("email")]
        public string Email { get; set; } = string.Empty!;

        [Column("schedule")]
        public List<DateTime> Schedule { get; set; } = default!;
        public int SecretaryId { get; set; }
        public Secretary Secretary { get; set; } = default!;

        public List<Consultation> Consultations { get; set; } = default!;
        public List<Client> Clients { get; set; } = default!;

    }
}