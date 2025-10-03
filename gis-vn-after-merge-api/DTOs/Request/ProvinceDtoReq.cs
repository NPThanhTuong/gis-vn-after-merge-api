namespace gis_vn_after_merge_api.DTOs.Request;

public class ProvinceDtoReq
{
	public int Id { get; set; }
	public int LegacyId { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Boundary { get; set; } = string.Empty;

	public List<CommuneDtoReq> Communes { get; set; } = [];
}