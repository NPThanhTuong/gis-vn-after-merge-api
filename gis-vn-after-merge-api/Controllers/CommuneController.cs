using AutoMapper;
using gis_vn_after_merge_api.DTOs.Response;
using gis_vn_after_merge_api.Services;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Features;
using NetTopologySuite.IO;
using Newtonsoft.Json;

namespace gis_vn_after_merge_api.Controllers;

[Route("api/v1/communes")]
[ApiController]
public class CommuneController(ICommuneService communeService, IMapper mapper) : ControllerBase
{
	[HttpGet]
	public async Task<IActionResult> GetAll()
	{
		var communes = await communeService.GetAll();

		var communesResponse = mapper.Map<List<CommuneDtoRes>>(communes);

		return Ok(ApiResponse<List<CommuneDtoRes>>.Success(communesResponse));
	}

	[HttpGet("geojson")]
	public async Task<IActionResult> GetCommunesGeoJson()
	{
		var communes = await communeService.GetAll();
		var featureCollection = new FeatureCollection();

		foreach (var feature in communes.Select(commune => new Feature
		         {
			         Geometry = commune.Boundary,
			         Attributes = new AttributesTable(new Dictionary<string, object>
			         {
				         { "id", commune.Id },
				         { "legacyId", commune.LegacyId },
				         { "name", commune.Name },
				         { "area", commune.Area },
				         { "population", commune.Population },
				         { "mergeFrom", commune.MergeFrom },
				         { "administrativeCenter", commune.AdministrativeCenter }
			         })
		         }))
			featureCollection.Add(feature);

		// Serialize FeatureCollection
		var serializer = GeoJsonSerializer.Create();
		await using var stringWriter = new StringWriter();
		await using var jsonWriter = new JsonTextWriter(stringWriter);
		serializer.Serialize(jsonWriter, featureCollection);

		return Ok(stringWriter.ToString());
	}
}