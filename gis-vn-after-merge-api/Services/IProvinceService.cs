using gis_vn_after_merge_api.Models;

namespace gis_vn_after_merge_api.Services;

public interface IProvinceService
{
	Task<Province> GetById(int id);

	Task<List<Province>> GetAll();

	Task<Province> Create(Province province);

	Task<Province> Update(Province province);

	Task<Province> Delete(Province province);
}