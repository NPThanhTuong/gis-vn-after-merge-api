using gis_vn_after_merge_api.Exceptions;
using gis_vn_after_merge_api.Models;
using gis_vn_after_merge_api.Repositories;

namespace gis_vn_after_merge_api.Services.Implement;

public class ProvinceService(IProvinceRepository provinceRepository) : IProvinceService
{
	public async Task<Province> GetById(int id)
	{
		if (id <= 0) throw new InvalidPathParamsException("Province's 'id' must be greater than zero");
		var result = await provinceRepository.GetById(id);
		
		return result ?? throw new NotFoundException($"Province with id {id} was not found");
	}

	public async Task<List<Province>> GetAll()
	{
		var result = await provinceRepository.GetAll();
		
		return result;
	}

	public Task<Province> Create(Province province)
	{
		throw new NotImplementedException();
	}

	public Task<Province> Update(Province province)
	{
		throw new NotImplementedException();
	}

	public Task<Province> Delete(Province province)
	{
		throw new NotImplementedException();
	}
}