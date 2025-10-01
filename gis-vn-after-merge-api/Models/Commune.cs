using NetTopologySuite.Geometries;

namespace gis_vn_after_merge_api.Models;

public class Commune
{
	public int Id { get; set; }
	public int LegacyId { get; set; }
	public required string Name { get; set; }
	public required double Area { get; set; }
	public required int Population { get; set; }
	public required Polygon Boundary { get; set; }

	// TODO: add navigation prop to Province
}