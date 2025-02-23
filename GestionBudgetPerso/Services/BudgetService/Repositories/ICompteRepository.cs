using BudgetService.Models;

namespace BudgetService.Repositories
{
    public interface ICompteRepository
    {
        Task<IEnumerable<Compte>> GetAllAsync();
        Task<Compte?> GetByIdAsync(int id);
        Task AddAsync(Compte compte);
        Task UpdateAsync(Compte compte);
        Task DeleteAsync(int id);
    }
}
