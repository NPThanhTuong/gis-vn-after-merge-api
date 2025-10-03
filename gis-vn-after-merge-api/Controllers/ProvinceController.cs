using AutoMapper;
using gis_vn_after_merge_api.DTOs.Response;
using gis_vn_after_merge_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace gis_vn_after_merge_api.Controllers;

[Route("api/v1/provinces")]
[ApiController]
public class ProvinceController(IProvinceService provinceService, IMapper mapper) : ControllerBase
{
	[HttpGet]
	public async Task<IActionResult> GetAllProvinces()
	{
		var result = await provinceService.GetAll();
		var response = mapper.Map<List<ProvinceDtoRes>>(result);
		return Ok(ApiResponse<List<ProvinceDtoRes>>.Success(response));
	}
	
	[HttpGet("{id}")]
	public async Task<IActionResult> GetProvinceById(int id)
	{
		var result = await provinceService.GetById(id);
		var response = mapper.Map<ProvinceDtoRes>(result);
		return Ok(ApiResponse<ProvinceDtoRes>.Success(response));
	}
}