﻿using Protectos.Domain.Entities.Entidades;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Entidades
{
    public class EntidadeEmailMapping : EntityTypeConfiguration<EntidadeEmail>
    {
        public EntidadeEmailMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.TipoEmail)
                .IsRequired();
            HasRequired(c => c.Entidade)
                .WithMany(a => a.Emails)
                .HasForeignKey(c => c.EntidadeId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("EntidadeEmail");
        }
    }
}
