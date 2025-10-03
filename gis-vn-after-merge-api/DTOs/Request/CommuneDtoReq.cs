namespace gis_vn_after_merge_api.DTOs.Request;

public class CommuneDtoReq
{
	public int Id { get; set; }
	public int LegacyId { get; set; }
	public string Name { get; set; } = string.Empty;
	public double Area { get; set; }
	public int Population { get; set; }
	public string Boundary { get; set; } = string.Empty;

	public int ProvinceId { get; set; }
}