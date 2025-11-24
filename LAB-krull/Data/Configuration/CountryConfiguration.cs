using LAB_krull.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LAB_krull.Data.Configuration;

/// <summary>
/// 
/// </summary>
public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
	public void Configure(EntityTypeBuilder<Country> builder)
	{
		builder.Property(x => x.CountryName).HasMaxLength(50);
		builder.Property(x => x.CountryCode).HasColumnName("ISO 3166 code").HasMaxLength(2);
	}
}