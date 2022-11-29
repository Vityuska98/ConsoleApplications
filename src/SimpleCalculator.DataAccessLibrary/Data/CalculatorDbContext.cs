using Microsoft.EntityFrameworkCore;
using SimpleCalculator.DataAccessLibrary.Model;
namespace SimpleCalculator.DataAccessLibrary.Data;

public class CalculatorDbContext : DbContext
{
    public CalculatorDbContext(DbContextOptions<CalculatorDbContext> options) : base(options)
    {

    }
    public DbSet<CalculatorMemory> CalculatorMemories { get; set; }
}

