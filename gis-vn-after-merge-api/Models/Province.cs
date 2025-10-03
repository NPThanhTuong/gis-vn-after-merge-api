using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace gis_vn_after_merge_api.Models;

[Table("provinces")]
public class Province
{
	[Column("id")] public int Id { get; set; }

	[Column("legacy_id")] public int LegacyId { get; set; }

	[Column("name")] public required string Name { get; set; }

	[Column("boundary")] public required Geometry Boundary { get; set; }

	public ICollection<Commune> Communes { get; set; } = new List<Commune>();
}