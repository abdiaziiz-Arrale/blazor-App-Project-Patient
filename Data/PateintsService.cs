
using Microsoft.EntityFrameworkCore;
namespace BlazorForms.Data
{
    public class CustomerService
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Patient>> GetCustomersAsync()
        {
            return await _dbContext.patients.ToListAsync();
        }
    }
}