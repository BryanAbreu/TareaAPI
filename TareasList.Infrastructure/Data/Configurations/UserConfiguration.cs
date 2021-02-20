using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Text;
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
>>>>>>> f0694bffa52d050b0edc9f338752aa7abac3884b
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
<<<<<<< HEAD
            builder.Property(e => e.LastName)
                .HasColumnName("Apellido")
=======
            builder.Property(e => e.Apellido)
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
>>>>>>> f0694bffa52d050b0edc9f338752aa7abac3884b
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
<<<<<<< HEAD
            builder.Property(e => e.Name)
                .HasColumnName("Nombre")
=======
            builder.Property(e => e.Nombre)
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
>>>>>>> f0694bffa52d050b0edc9f338752aa7abac3884b
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

<<<<<<< HEAD
            builder.Property(e => e.UserName)
                .HasColumnName("NombreUsuario")
=======
<<<<<<< HEAD
            builder.Property(e => e.UserName)
                .HasColumnName("NombreUsuario")
=======
            builder.Property(e => e.NombreUsuario)
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
>>>>>>> f0694bffa52d050b0edc9f338752aa7abac3884b
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
