namespace Infrastructure.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? ProjectName { get; set; }
        public string? CustomerCompanyName { get; set; }
        public string? PerformingCompanyName { get; set; }        
        public Employee? ProjectOwner { get; set;}
        public int? ProjectPriority { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? StartDate { get; set; }
        public List<Employee> Employees { get; set; } = new();
    }
}
