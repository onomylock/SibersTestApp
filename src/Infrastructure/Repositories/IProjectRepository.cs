using Infrastructure.Models;

namespace Infrastructure.Repository
{
    public interface IProjectRepository : IBaseRepository<Project>
    {
        Task<Project> CreateAsync(Project project);
        Task<Project> UpdateAsync(Project project);
        Task DeleteAsync(Project project);
        Task<List<Project>> GetAllProjectsAsync();
        Task<List<Employee>> GetEmployeesByProjectAsync(Project project);
        Task DeleteEmployeeByProjectAsync(Project project, Employee employee);

    }
}
