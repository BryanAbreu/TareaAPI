using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TareasList.Core.Entities;
using TareasList.Core.Enumerations;

namespace TareasList.Infrastructure.Data.Configurations
{
    public class WorkConfiguration : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.ToTable("Tareas");
            builder.HasKey(e=>e.WorkID);

            builder.Property(e => e.WorkID)
                .HasColumnName("TareaId");

            builder.Property(e => e.Description)
                    .HasColumnName("Descripcion")
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            builder.Property(e => e.Status)
                .HasColumnName("Estado")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Title)
                .HasColumnName("Titulo")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.User)
                .WithMany(p => p.Works)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tareas_User");
        }
    }
}
