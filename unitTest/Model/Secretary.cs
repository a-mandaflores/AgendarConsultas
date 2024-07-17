using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendarConsultas.Model
{
    [Table("secretary")]
    public class Secretary
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public Guid Uuid { get; set; } = Guid.NewGuid();

        [Column("name")]
        public string Name { get; set; } = string.Empty!;

        [Column("cell")]
        public string? Cell { get; set; }

        [Column("email")]
        public string Email { get; set; } = string.Empty!;

        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; } = default!;
    }
}