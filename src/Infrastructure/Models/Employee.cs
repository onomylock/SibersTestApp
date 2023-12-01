using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Models;

public class Employee : IdentityUser
{
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public List<Project> Projects { get; set; } = new();
}
