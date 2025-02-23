namespace BudgetService.Models
{


    public class Compte
    {
        public int Id { get; set; }
        public required string Nom { get; set; }
        public decimal SoldeInitial { get; set; }
        public DateTime DateCreation { get; set; }
    }



}
