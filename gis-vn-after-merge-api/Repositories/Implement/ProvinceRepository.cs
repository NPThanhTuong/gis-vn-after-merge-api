using gis_vn_after_merge_api.Data;
using gis_vn_after_merge_api.Models;
using Microsoft.EntityFrameworkCore;

namespace gis_vn_after_merge_api.Repositories.Implement;

public class ProvinceRepository(ApplicationDbContext context) : IProvinceRepository
{
	public async Task<Province?> GetById(int id)
	{
		return await context.Provinces
			.Include(p => p.Communes)
			.FirstOrDefaultAsync(p => p.Id == id);
	}

	public async Task<List<Province>> GetAll()
	{
		return await context.Provinces
			.ToListAsync();
	}

	public async Task<int> Create(Province entity)
	{
		await context.Provinces.AddAsync(entity);

		return await context.SaveChangesAsync();
	}

	public async Task<int> Update(Province entity)
	{
		context.Provinces.Update(entity);

		return await context.SaveChangesAsync();
	}

	public async Task<int> Delete(Province entity)
	{
		context.Provinces.Remove(entity);

		return await context.SaveChangesAsync();
	}
}