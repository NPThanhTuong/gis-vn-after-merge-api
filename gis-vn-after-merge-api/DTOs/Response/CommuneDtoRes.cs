namespace gis_vn_after_merge_api.DTOs.Response;

public class CommuneDtoRes
{
	public int Id { get; set; }
	public int LegacyId { get; set; }
	public string Name { get; set; } = string.Empty;
	public double Area { get; set; }

	public int Population { get; set; }
	public string Boundary { get; set; } = string.Empty;
}