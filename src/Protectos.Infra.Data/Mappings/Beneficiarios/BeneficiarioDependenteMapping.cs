using Protectos.Domain.Entities.Beneficiarios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Beneficiarios
{
    public class BeneficiarioDependenteMapping : EntityTypeConfiguration<BeneficiarioDependente>
    {
        public BeneficiarioDependenteMapping()
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

            HasRequired(c => c.Beneficiarios)
                    .WithMany(a => a.Dependentes)
                    .HasForeignKey(c => c.BeneficiarioId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("BeneficiarioDependente");
        }
    }
}
