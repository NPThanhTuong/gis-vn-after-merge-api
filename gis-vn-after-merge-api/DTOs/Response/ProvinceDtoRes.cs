namespace gis_vn_after_merge_api.DTOs.Response;

public class ProvinceDtoRes
{
	public int Id { get; set; }
	public int LegacyId { get; set; }
	public string Name { get; set; } = string.Empty;
	public double Area { get; set; }
	public int Population { get; set; }
	public string MergeFrom { get; set; } = string.Empty;
	public string AdministrativeCenter { get; set; } = string.Empty;
}