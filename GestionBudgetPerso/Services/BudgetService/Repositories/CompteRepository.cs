using BudgetService.Data;
using BudgetService.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BudgetService.Repositories
{
    public class CompteRepository : ICompteRepository
    {
        private readonly CompteContext _context;


        public CompteRepository(CompteContext context)
        {
            _context = context;
        }


        public Task AddAsync(Compte compte)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<IEnumerable<Compte>> GetAllAsync()
        {

             List<Compte> comptes = new List<Compte>();
            comptes.AddRange(new List<Compte>
            {
                 new Compte { Id = 1, Nom = "Compte Épargne", SoldeInitial = 5000.75m , DateCreation = DateTime.Now},
                new Compte { Id = 2, Nom = "Compte Business", SoldeInitial = 20000.00m,DateCreation =DateTime.Now }
            }
            
            
            );

            return await Task.FromResult(comptes);
                
        }

        public Task<Compte?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Compte compte)
        {
            throw new NotImplementedException();
        }
    }
}
