using Protectos.Domain.Entities.Corretores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Corretores
{
    public class CorretorMapping : EntityTypeConfiguration<Corretor>
    {
        public CorretorMapping()
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

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Sobrenome)
               .HasColumnType("varchar")
               .HasMaxLength(100)
               .IsRequired();

            Property(c => c.DataNascimento)
               .IsRequired();

            Property(c => c.Sexo)
               .IsRequired();

            Property(c => c.Cpf)
              .HasMaxLength(11);


            Property(c => c.RG)
             .HasColumnType("char")
             .HasMaxLength(14);


            Property(c => c.OrgaoEmissor)
            .HasColumnType("char")
            .HasMaxLength(10);

            Property(c => c.EstadoCivil)
                .IsRequired();


            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Corretor");
        }
    }
}
