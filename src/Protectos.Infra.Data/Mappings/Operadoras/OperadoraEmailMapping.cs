﻿using Protectos.Domain.Entities.Operadoras;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Operadoras
{
    public class OperadoraEmailMapping : EntityTypeConfiguration<OperadoraEmail>
    {
        public OperadoraEmailMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Ativo);
            Property(c => c.DataCadastro)
                .IsRequired();
            Property(c => c.CadastradoPor)
                .IsRequired();
            Property(c => c.DataAlteracao);
            Property(c => c.AlteradoPor);
            Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.TipoEmail)                
                .IsRequired();
            HasRequired(c => c.Operadora)
                .WithMany(a => a.Emails)
                .HasForeignKey(c => c.OperadoraId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("OperadoraEmail");
        }
    }
}
