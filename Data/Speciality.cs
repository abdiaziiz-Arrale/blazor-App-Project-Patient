
using BlazorForms.Data;
using System.ComponentModel.DataAnnotations;

public class Speciality
    {
    [Key]
    public int Id { get; set; }
        public String SpecialityName { get; set; }

        public DateTime createAt { get; set; }
/*    public List<Patient> patients { get; set; }
*/
}
