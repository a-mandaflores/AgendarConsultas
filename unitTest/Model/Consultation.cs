using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendarConsultas.Model
{
    [Table("consultation")]
    public class Consultation
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("uuid")]
        public Guid Uuid { get; set; } = Guid.NewGuid();

        [Column("schedule")]
        public DateTime Date { get; set; } = default!;

        [Column("pet_id")]
        public int PetId { get; set; }

        public Pet Pet { get; set; } = default!;

        [Column("veterinary_id")]
        public int VeterinaryId { get; set; }

        public Veterinary Veterinary { get; set; } = default!;

        [Column("clinic_id")]
        public int ClinicId { get; set; }

        public Clinic Clinic { get; set; } = default!;
    }
}