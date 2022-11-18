namespace WebApiFinalMigoneGaston.Models
{
    public class Medico
    {
        int DoctorID { get; set; }
        int HospitalID { get; set; }
        string Apellido { get; set; }
        string Especialidad { get; set; }

        
        Hospital hospital { get; set; }
    
        public Medico(int doctorID, int hospitalID, string apellido, string especialidad, Hospital hospital)
        {
            DoctorID = doctorID;
            HospitalID = hospitalID;
            Apellido = apellido;
            Especialidad = especialidad;
            this.hospital = hospital;
        }
    }
}
