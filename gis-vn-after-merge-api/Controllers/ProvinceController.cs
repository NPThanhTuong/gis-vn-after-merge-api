using AutoMapper;
using gis_vn_after_merge_api.DTOs.Response;
using gis_vn_after_merge_api.Services;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Features;
using NetTopologySuite.IO;
using Newtonsoft.Json;

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

	[HttpGet("geojson")]
	public async Task<IActionResult> GetProvinceGeoJson()
	{
		var provinces = await provinceService.GetAll();
		var featureCollection = new FeatureCollection();

		foreach (var feature in provinces.Select(province => new Feature
		         {
			         Geometry = province.Boundary,
			         Attributes = new AttributesTable(new Dictionary<string, object>
			         {
				         {"id",  province.Id},
				         {"legacyId", province.LegacyId},
				         { "name", province.Name },
				         { "area", province.Communes.Sum(c => c.Area) },
				         { "population", province.Communes.Sum(c => c.Population) },
			         })
		         }))
		{
			featureCollection.Add(feature);
		}

		// Serialize FeatureCollection
		var serializer = GeoJsonSerializer.Create();
		await using var stringWriter = new StringWriter();
		await using var jsonWriter = new JsonTextWriter(stringWriter);
		serializer.Serialize(jsonWriter, featureCollection);

		return Ok(stringWriter.ToString());
	} 
}