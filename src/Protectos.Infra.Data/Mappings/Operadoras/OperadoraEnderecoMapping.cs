﻿using Protectos.Domain.Entities.Operadoras;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Operadoras
{
    public class OperadoraEnderecoMapping : EntityTypeConfiguration<OperadoraEndereco>
    {
        public OperadoraEnderecoMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Ativo);
            Property(c => c.DataCadastro)
                .IsRequired();
            Property(c => c.CadastradoPor)
                .IsRequired();
            Property(c => c.DataAlteracao);
            Property(c => c.AlteradoPor);
            Property(c => c.Logradouro)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.Bairro)
               .HasMaxLength(100)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Cep)
               .HasMaxLength(10)
               .HasColumnType("char")
               .IsRequired();
            Property(c => c.Complemento)
               .HasMaxLength(100)
               .HasColumnType("varchar");
            Property(c => c.Cidade)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Estado)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.UF)
               .HasMaxLength(2)
               .HasColumnType("char")
               .IsRequired();
            Property(c => c.Pais)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            HasRequired(c => c.Operadora)
                .WithMany(a => a.Enderecos)
                .HasForeignKey(c => c.OperadoraId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("OperadoraEndereco");
        }
    }
}
