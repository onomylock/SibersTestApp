using Infrastructure.Models;

namespace Infrastructure.Repositories
{
    public interface IEnployeeRepository
    {
        Task DeleteAsync(Employee employee);
        Task<List<Employee>> GetEmployeesAsync();
        Task UpdateAsync(Employee employee);
    }
}
