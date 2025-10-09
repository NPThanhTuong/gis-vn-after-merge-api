using AutoMapper;
using gis_vn_after_merge_api.Models;

namespace gis_vn_after_merge_api.Helpers;

public class CommuneMultiPolygonToGeoJsonConverter : IValueConverter<Commune, string>
{
	public string Convert(Commune sourceMember, ResolutionContext context)
	{
		throw new NotImplementedException();
	}
}