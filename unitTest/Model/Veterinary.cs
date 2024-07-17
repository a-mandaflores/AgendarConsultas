using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendarConsultas.Model
{
    [Table("veterinary")]
    public class Veterinary
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
        public int ConsultarionId { get; set; }
        public Consultation? Consultation { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; } = default!;
    }
}