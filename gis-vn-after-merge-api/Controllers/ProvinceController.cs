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
	public async Task<ActionResult> GetAllProvinces()
	{
		try
		{
			var result = await provinceService.GetAll();
			
			var response = mapper.Map<List<ProvinceDtoRes>>(result);
			
			return Ok(response);
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			return BadRequest("Bad");
		}
	}
}