using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalMigoneGaston.Entidades
{
    [Table("Medico")]
    public class Medico
    {
        [Required]
        public int MedicoID { get; set; }

        [Required]
        public int HospitalID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Especialidad { get; set; }

        [ForeignKey("HospitalID")]
        public Hospital Hospital { get; set; }

        //public Medico(int medicoID, int hospitalID, string apellido, string especialidad)
        //{
        //    MedicoID = medicoID;
        //    Apellido = apellido;
        //    Especialidad = especialidad;
            
        //}
    }
}
