using ApiHospitales.Data;
using ApiHospitales.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiHospitales.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            return await context.Hospitales.ToListAsync();
        }

        public async Task<Hospital> FindHospitalAsync(int id)
        {
            return await context.Hospitales.FirstOrDefaultAsync(z => z.IdHospital == id);
        }
    }
}
