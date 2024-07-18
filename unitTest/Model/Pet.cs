using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendarConsultas.Model
{
    [Table("pet")]
    public class Pet
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("uuid")]
        public Guid Uuid { get; set; } = Guid.NewGuid();

        [Column("name")]
        public string Name { get; set; } = string.Empty!;

        [Column("race")]
        public string? Race { get; set; }

        [Column("year")]
        public int Year { get; set; }

        [Column("schedule_id")]
        public int ScheduleId { get; set; }

        [Column("clinic_id")]
        public int ClientId { get; set; }

        public Client Client { get; set; } = default!;
        public List<Consultation> Consultations { get; set; } = default!;
    }
}