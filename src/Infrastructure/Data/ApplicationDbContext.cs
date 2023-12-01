using Microsoft.EntityFrameworkCore;
using Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data;
public class ApplicationDbContext : IdentityDbContext<Employee>
{
    private readonly IConfiguration _configuration;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option, IConfiguration configuration) : base(option)
    {
        _configuration = configuration;
    }

    public DbSet<Project> Projects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"), o => o.MigrationsHistoryTable(
            tableName: HistoryRepository.DefaultTableName,
            schema: "AppUser"));
    }
}
