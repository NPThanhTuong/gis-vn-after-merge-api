using AutoMapper;
using gis_vn_after_merge_api.DTOs.Request;
using gis_vn_after_merge_api.DTOs.Response;
using gis_vn_after_merge_api.Helpers;
using gis_vn_after_merge_api.Models;
using NetTopologySuite.IO;

namespace gis_vn_after_merge_api.MappingProfiles;

public class CommuneProfile: Profile
{
	public CommuneProfile()
	{
		CreateMap<Commune, CommuneDtoRes>();
		
		CreateMap<CommuneDtoReq, Commune>()
			.ForMember(
				dest => dest.Boundary,
				opt => opt.ConvertUsing(new GeoJsonToGeometryConverter(), src => src.Boundary));
	}
}