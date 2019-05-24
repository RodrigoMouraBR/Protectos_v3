using Protectos.Domain.Entities.Propostas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Propostas
{
    public class TipoVencimentoReferenciaMapping : EntityTypeConfiguration<TipoVencimentoReferencia>
    {
        public TipoVencimentoReferenciaMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Ativo);
            Property(c => c.DataCadastro)
                .IsRequired();
            Property(c => c.CadastradoPor)
                .IsRequired();
            Property(c => c.DataAlteracao)
                .IsOptional();
            Property(c => c.AlteradoPor)
                .IsOptional();

            Property(c => c.Descricao)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.Vigencia)
               .HasMaxLength(20)
               .HasColumnType("varchar")
               .IsRequired();

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("TipoVencimentoReferencia");

        }
    }
}
