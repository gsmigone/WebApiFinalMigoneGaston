using System.Collections.Generic;

namespace WebApiFinalMigoneGaston.Models
{
    public class Hospital
    {
        
        int HospitalID { get; set; }
        string Nombre { get; set; }

        string Direccion { get; set; }

        string Telefono { get; set; }
        int NumCama { get; set; }

        List<Medico> medicos { get; set; }

        public Hospital(int hospitalID, string nombre, string direccion, string telefono, int numCama, List<Medico> medicos)
        {
            HospitalID = hospitalID;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            NumCama = numCama;
            this.medicos = medicos;
        }
    }
}
