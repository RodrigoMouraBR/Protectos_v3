using Protectos.Domain.Entities.Cobrancas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Cobrancas
{
    public class BancoMapping : EntityTypeConfiguration<Banco>
    {
        public BancoMapping()
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

            Property(c => c.NumeroBanco)
                .HasColumnType("varchar")
                .HasMaxLength(40)
                .IsRequired();
            Property(c => c.DescricaoBanco)
                .HasColumnType("varchar")
                .HasMaxLength(40)
                .IsRequired();

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Banco");
        }
    }
}
