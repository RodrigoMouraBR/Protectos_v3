using Protectos.Domain.Entities.Corretoras;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Corretoras
{
    public class CorretoraTelefoneMapping : EntityTypeConfiguration<CorretoraTelefone>
    {
        public CorretoraTelefoneMapping()
        {
            HasKey(c => c.Id);

            Property(c => c.Ativo)
                .IsRequired();

            Property(c => c.DataCadastro)
                .IsRequired();

            Property(c => c.CadastradoPor)
                .IsRequired();

            Property(c => c.DataAlteracao)
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

            HasRequired(c => c.Corretora)
                .WithMany(a => a.Telefones)
                .HasForeignKey(c => c.CorretoraId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("CorretoraTelefone");
        }
    }
}

