using ApiHospitales.Models;
using ApiHospitales.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHospitales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalesController : ControllerBase
    {
        private RepositoryHospital repo;

        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hospital>>> GetHospitales()
        {
            return await repo.GetHospitalesAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hospital>> FindHospital(int id)
        {
            return await repo.FindHospitalAsync(id);
        }
    }
}
