using BudgetService.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetService.Data
{
    public class CompteContext :DbContext
    {

        public CompteContext(DbContextOptions<CompteContext> options) : base (options) { }

        public DbSet<Compte> Comptes { get; set; }

    }
}
