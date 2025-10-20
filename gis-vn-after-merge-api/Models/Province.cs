using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace gis_vn_after_merge_api.Models;

[Table("provinces")]
public class Province
{
	[Column("id")] public int Id { get; set; }

	[Column("legacy_id")] public int LegacyId { get; set; }

	[Column("name")] public required string Name { get; set; }

	[Column("boundary")] public required MultiPolygon Boundary { get; set; }
	
	[Column("merge_from")]
	[MaxLength(256)] 
	public required string MergeFrom { get; set; }
	
	[Column("administrative_center")]
	[MaxLength(256)] 
	public required string AdministrativeCenter { get; set; }

	public ICollection<Commune> Communes { get; set; } = new List<Commune>();
}