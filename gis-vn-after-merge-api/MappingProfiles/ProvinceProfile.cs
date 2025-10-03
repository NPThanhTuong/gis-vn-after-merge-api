using AutoMapper;
using gis_vn_after_merge_api.DTOs.Request;
using gis_vn_after_merge_api.DTOs.Response;
using gis_vn_after_merge_api.Helpers;
using gis_vn_after_merge_api.Models;
using NetTopologySuite.IO;

namespace gis_vn_after_merge_api.MappingProfiles;

public class ProvinceProfile : Profile
{
	public ProvinceProfile()
	{
		CreateMap<ProvinceDtoReq, Province>()
			.ForMember(
				dest => dest.Boundary,
				opt => opt.ConvertUsing(new GeoJsonToGeometryConverter(), src => src.Boundary));

		CreateMap<Province, ProvinceDtoRes>()
			.ForMember(
				dest => dest.Boundary,
				opt => opt.MapFrom(src => new GeoJsonWriter().Write(src.Boundary)));
	}
}