using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorForms.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Doctor> doctors { get; set; }

        public DbSet<Speciality> specialities { get; set; }
        public DbSet<Appoitment> appoitments { get; set; }
     
    
}
   
    }