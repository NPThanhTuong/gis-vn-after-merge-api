using gis_vn_after_merge_api.Data;
using gis_vn_after_merge_api.Models;
using Microsoft.EntityFrameworkCore;

namespace gis_vn_after_merge_api.Repositories.Implement;

public class CommuneRepository(ApplicationDbContext context) : ICommuneRepository
{
	public async Task<Commune?> GetById(int id)
	{
		var commune = await context.Communes.FirstOrDefaultAsync(c => c.Id == id);
		
		return commune;
	}

	public async Task<List<Commune>> GetAll()
	{
		var communes = await context.Communes.ToListAsync();
		
		return communes;
	}

	public Task<int> Create(Commune entity)
	{
		throw new NotImplementedException();
	}

	public Task<int> Update(Commune entity)
	{
		throw new NotImplementedException();
	}

	public Task<int> Delete(Commune entity)
	{
		throw new NotImplementedException();
	}
}