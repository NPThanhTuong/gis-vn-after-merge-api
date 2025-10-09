using gis_vn_after_merge_api.Configurations;
using gis_vn_after_merge_api.Models;
using Microsoft.EntityFrameworkCore;

namespace gis_vn_after_merge_api.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
	public DbSet<Commune> Communes { get; set; }
	public DbSet<Province> Provinces { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasPostgresExtension("postgis"); // bật extension PostGIS
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Commune>()
			.HasOne(c => c.Province)
			.WithMany(c => c.Communes)
			.HasForeignKey(c => c.ProvinceId)
			.OnDelete(DeleteBehavior.Cascade)
			.IsRequired();

		// Seed sample data
		// modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
		// modelBuilder.ApplyConfiguration(new CommuneConfiguration());
	}
}