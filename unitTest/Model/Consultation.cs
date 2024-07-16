using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendarConsultas.Model
{
    public class Consultation
    {
        [Key]
        public int Id { get; set; }

        [Column("uuid")]
        public Guid Uuid { get; set; } = Guid.NewGuid();
        public Dictionary<string, DateTime> Schedule { get; set; } = default!;

        public int PetId { get; set; }
        public Pet Pet { get; set; } = default!;
        public int VeterinaryId { get; set; }
        public Veterinary Veterinary { get; set; } = default!;
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; } = default!;
    }
}