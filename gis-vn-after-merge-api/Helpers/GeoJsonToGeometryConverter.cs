using AutoMapper;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using Newtonsoft.Json.Linq;

namespace gis_vn_after_merge_api.Helpers;

public class GeoJsonToGeometryConverter : IValueConverter<string, MultiPolygon>
{
	public MultiPolygon Convert(string sourceMember, ResolutionContext context)
	{
		if (string.IsNullOrEmpty(sourceMember)) return null!;
		var reader = new GeoJsonReader();

		// Parse JSON and extract the `geometry` part of the first feature
		var featureCollection = JObject.Parse(sourceMember);
		var geometryToken = featureCollection["features"]?[0]?["geometry"];

		if (geometryToken == null) return null!;
		var geometryJson = geometryToken.ToString();
		var geometry = reader.Read<Geometry>(geometryJson);

		if (geometry is Polygon polygon)
			geometry = new MultiPolygon([polygon]);
		
		return (MultiPolygon)geometry;
	}
}