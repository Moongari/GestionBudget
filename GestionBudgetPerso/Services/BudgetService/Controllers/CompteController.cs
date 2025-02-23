using BudgetService.Data;
using BudgetService.Models;
using BudgetService.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BudgetService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComptesController : ControllerBase
    {
        private readonly ICompteRepository _compteRepository;


        public ComptesController(ICompteRepository compteRepository)
        {
            _compteRepository = compteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compte>>> GetComptes()
        {
            return Ok(await _compteRepository.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult> CreateCompte(Compte compte)
        {
            await _compteRepository.AddAsync(compte);
            return CreatedAtAction(nameof(Compte), new { id = compte.Id }, compte);
        }
    }
}
