using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorForms.Data
{
    public class Doctor
    {
             [Key]
        public int Id { get; set; }
        public String DoctorName { get; set; }
        public String DoctorSpicality { get; set; }
        public String Education { get; set; }
        public DateTime createAt { get; set; }

        public int SpecialityId { get; set; }
 /*       public Speciality speciality { get; set; }


        public List<Appoitment> appoitments { get; set; }
        public List<Patient> patients { get; set; }*/
    }
}
