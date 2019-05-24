using Protectos.Domain.Entities.Cobrancas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Cobrancas
{
    public class BancoAgenciaMapping : EntityTypeConfiguration<BancoAgencia>
    {
        public BancoAgenciaMapping()
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

            Property(c => c.CodigoAgencia)
               .HasMaxLength(20)
               .HasColumnType("varchar")
               .IsRequired();

            Property(c => c.NomeAgenciaBanco)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();

            Property(c => c.Logradouro)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.Numero)
               .HasMaxLength(10)
               .HasColumnType("char")
               .IsRequired();

            Property(c => c.Bairro)
               .HasMaxLength(100)
               .HasColumnType("varchar")
               .IsRequired();

            Property(c => c.Cep)
               .HasMaxLength(12)
               .HasColumnType("char")
               .IsRequired();

            Property(c => c.Complemento)
               .HasMaxLength(100)
               .HasColumnType("varchar")
               .IsOptional();

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

            Property(c => c.DDD)
               .HasMaxLength(8)
               .HasColumnType("varchar")
               .IsRequired();

            Property(c => c.Fone)
               .HasMaxLength(10)
               .HasColumnType("varchar")
               .IsRequired();

            HasRequired(c => c.Banco)
               .WithMany(a => a.BancoAgencia)
               .HasForeignKey(c => c.BancoId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("BancoAgencia");
        }
    }
}
