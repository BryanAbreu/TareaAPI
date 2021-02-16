using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Text;
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
using TareasList.Core.Entities;

namespace TareasList.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.IdUser);

            builder.ToTable("User");

<<<<<<< HEAD
            builder.Property(e => e.LastName)
                .HasColumnName("Apellido")
=======
            builder.Property(e => e.Apellido)
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

<<<<<<< HEAD
            builder.Property(e => e.Name)
                .HasColumnName("Nombre")
=======
            builder.Property(e => e.Nombre)
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

<<<<<<< HEAD
            builder.Property(e => e.UserName)
                .HasColumnName("NombreUsuario")
=======
            builder.Property(e => e.NombreUsuario)
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
