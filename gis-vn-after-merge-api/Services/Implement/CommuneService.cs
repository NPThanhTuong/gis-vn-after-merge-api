using gis_vn_after_merge_api.Exceptions;
using gis_vn_after_merge_api.Models;
using gis_vn_after_merge_api.Repositories;

namespace gis_vn_after_merge_api.Services.Implement;

public class CommuneService(ICommuneRepository communeRepository) : ICommuneService
{
	public async Task<Commune?> GetById(int id)
	{
		var commune = await communeRepository.GetById(id);
		return commune ?? throw new NotFoundException($"Commune with id={id} is not found");
	}

	public async Task<List<Commune>> GetAll()
	{
		var communes = await communeRepository.GetAll();

		return communes;
	}
}