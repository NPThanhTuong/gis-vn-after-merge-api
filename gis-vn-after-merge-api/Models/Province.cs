using NetTopologySuite.Geometries;

namespace gis_vn_after_merge_api.Models;

public class Province
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public required Polygon Boundary { get; set; }
	
	// TODO: add navigation prop to Commune
}