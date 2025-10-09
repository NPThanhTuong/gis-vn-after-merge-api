using AutoMapper;
using gis_vn_after_merge_api.Models;
using NetTopologySuite.Features;
using NetTopologySuite.IO;	
using Newtonsoft.Json;

namespace gis_vn_after_merge_api.Helpers;

public class ProvinceMultiPolygonToGeoJsonConverter : IValueConverter<Province, string>
{
	public string Convert(Province sourceMember, ResolutionContext context)
	{
		// Tạo Feature với Geometry là MultiPolygon và Properties chứa thông tin tỉnh
		var feature = new Feature()
		{
			Geometry = sourceMember.Boundary,
			Attributes = new AttributesTable(new Dictionary<string, object>
			{
				{ "id", sourceMember.Id },
				{ "name", sourceMember.Name },
				{ "legacyId", sourceMember.LegacyId },
			})
		};

		// Serialize thành GeoJSON
		var serializer = GeoJsonSerializer.Create();
		using var stringWriter = new StringWriter();
		using var jsonWriter = new JsonTextWriter(stringWriter);

		serializer.Serialize(jsonWriter, feature);

		return stringWriter.ToString();
	}
}