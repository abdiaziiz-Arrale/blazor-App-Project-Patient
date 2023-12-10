using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorForms.Data
{
    public class Patient
    {
        [Key]
        public int Id {get; set; }
        public String PatientName { get; set; }
        [Required(ErrorMessage = "This PatientDiscription Is Required")]
        [StringLength(120,MinimumLength =10)]
        public String PatientDiscription { get; set; }
      
        public int SpecialityId { get; set; }
  
        public DateTime createAt { get; set; }
  
      


        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
   /*     public Doctor Doctor { get; set; }*/


        public List<Appoitment> appoitments { get; set; }

    }
}
