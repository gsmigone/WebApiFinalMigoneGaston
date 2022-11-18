using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebApiFinalMigoneGaston.Entidades
{
    [Table("Hospital")]
    public class Hospital
    {
        [Required]
        public int HospitalID { get; set; }

        //public int MedicoID { get; set; }
        public int NumCama { get; set; }

        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Nombre { get; set;}

        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Direccion { get; set; }

        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Telefono { get; set; }

        public List<Medico> Medicos { get; set; }




        //public Hospital(int hospitalID, int numCama, string nombre, string direccion, string telefono)
        //{
        //    HospitalID = hospitalID;
        //    NumCama = numCama;
        //    Nombre = nombre;
        //    Direccion = direccion;
        //    Telefono = telefono;

        //}
    }
}
