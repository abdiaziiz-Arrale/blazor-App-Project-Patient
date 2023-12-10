using BlazorForms.Pages;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorForms.Data
{
    public class Appoitment
    {
        public int Id { get; set; }
//        public int PatientId { get; set; }
 
 
        public DateTime AppoitmentDate { get; set; }
        /*    public int DoctorId { get; set; }*/

        /*      public virtual Patient pateint { get; set; }*/

        public int PatientId { get; set; }
        public int DoctorId { get; set; }
/*        public Patient patient { get; set; }
*/


    

    }
}
