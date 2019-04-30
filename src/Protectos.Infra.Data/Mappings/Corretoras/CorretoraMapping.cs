﻿using Protectos.Domain.Entities.Corretoras;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Corretoras
{
    public class CorretoraMapping : EntityTypeConfiguration<Corretora>
    {
        public CorretoraMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Empresa.RazaoSocial)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.Empresa.NomeFantasia)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.Empresa.Cnpj.Numero)
               .IsRequired()
               .HasMaxLength(14)
               .IsFixedLength()
               .HasColumnAnnotation("Index", new IndexAnnotation(
                   new IndexAttribute("IX_CNPJ_Corretora") { IsUnique = true }));
            Property(c => c.Empresa.InscricaoEstadual)
                .HasColumnType("char")
                .HasMaxLength(14);
            Property(c => c.Empresa.InscricaoMunicipal)
                .HasColumnType("char")
                .HasMaxLength(14);
            Property(c => c.Empresa.Site)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Corretora");
        }

    }
}
