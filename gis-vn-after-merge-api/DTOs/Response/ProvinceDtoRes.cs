namespace gis_vn_after_merge_api.DTOs.Response;

public class ProvinceDtoRes
{
	public int Id { get; set; }
	public int LegacyId { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Boundary { get; set; } = string.Empty;

	public List<CommuneDtoRes> Communes { get; set; }
}