﻿using Protectos.Domain.Entities.Beneficiarios;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Beneficiarios
{
    public class BeneficiarioTelefoneMapping : EntityTypeConfiguration<BeneficiarioTelefone>
    {
        public BeneficiarioTelefoneMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Prefixo)
                    .HasColumnType("char")
                    .HasMaxLength(5)
                    .IsRequired();
            Property(c => c.Numero)
                    .HasMaxLength(10)
                    .HasColumnType("varchar")
                    .IsRequired();
            Property(c => c.TipoTelefone)                  
                    .IsRequired();
            HasRequired(c => c.Beneficiario)
                    .WithMany(a => a.Telefones)
                    .HasForeignKey(c => c.BeneficiarioId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("BeneficiarioTelefone");
        }
    }
}
