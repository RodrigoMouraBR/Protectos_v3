﻿using Protectos.Domain.Entities.Administradoras;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Administradoras
{
    public class AdministradoraTelefoneMapping : EntityTypeConfiguration<AdministradoraTelefone>
    {
        public AdministradoraTelefoneMapping()
        {
            HasKey(c => c.Id);

            Property(c => c.Ativo)
                .IsRequired();

            Property(c => c.DataCadastro)
                .HasColumnType("DateTime")
                .IsRequired();

            Property(c => c.CadastradoPor)
                .IsRequired();

            Property(c => c.DataAlteracao)
                .HasColumnType("DateTime")
                .IsOptional();

            Property(c => c.AlteradoPor)
                .IsOptional();

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

            HasRequired(c => c.Administradora)
                .WithMany(a => a.Telefones)
                .HasForeignKey(c => c.AdministradoraId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("AdministradoraTelefone");
        }
    }
}
