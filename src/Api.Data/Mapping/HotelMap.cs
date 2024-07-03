using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class HotelMap : IEntityTypeConfiguration<HotelEntity>
    {
        public void Configure(EntityTypeBuilder<HotelEntity> builder)
        {
            builder.ToTable("Hotel");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Cnpj)
                .IsUnique();

            builder.Property(u => u.Cnpj)
                .HasMaxLength(18);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(60);

        }
    }
}