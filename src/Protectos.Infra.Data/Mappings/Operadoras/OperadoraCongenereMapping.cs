using Protectos.Domain.Entities.Operadoras;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Operadoras
{
    public class OperadoraCongenereMapping : EntityTypeConfiguration<OperadoraCongenere>
    {
        public OperadoraCongenereMapping()
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

            Property(c => c.Descricao)
                .IsOptional();

            HasRequired(c => c.Operadora)
                .WithMany(a => a.OperadoraCongeneres)
                .HasForeignKey(c => c.OperadoraId);


            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("OperadoraCongenere");
        }
    }
}
