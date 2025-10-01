using gis_vn_after_merge_api.Models;
using Microsoft.EntityFrameworkCore;

namespace gis_vn_after_merge_api.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}
	
	public DbSet<Commune> Communes { get; set; }
	public DbSet<Province> Provinces { get; set; }
	
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasPostgresExtension("postgis"); // bật extension PostGIS
		
		modelBuilder.Entity<Commune>()
			.HasOne(c => c.Province)
			.WithMany(c => c.Communes)
			.HasForeignKey(c => c.ProvinceId)
			.OnDelete(DeleteBehavior.Cascade)
			.IsRequired();
		
		base.OnModelCreating(modelBuilder);
	}
}