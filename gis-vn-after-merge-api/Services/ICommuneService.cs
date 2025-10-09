using gis_vn_after_merge_api.Models;

namespace gis_vn_after_merge_api.Services;

public interface ICommuneService
{
	Task<Commune?> GetById(int id);

	Task<List<Commune>> GetAll();
}