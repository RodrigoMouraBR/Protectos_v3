using Protectos.Domain.Entities.Corretoras;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Corretoras
{
    public class CorretoraEnderecoMapping : EntityTypeConfiguration<CorretoraEndereco>
    {
        public CorretoraEnderecoMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Endereco.Logradouro)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();
            Property(c => c.Endereco.Logradouro)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Endereco.Bairro)
               .HasMaxLength(100)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Endereco.Cep)
               .HasMaxLength(10)
               .HasColumnType("char")
               .IsRequired();
            Property(c => c.Endereco.Complemento)
               .HasMaxLength(100)
               .HasColumnType("varchar");
            Property(c => c.Endereco.Cidade)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Endereco.Estado)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Endereco.Logradouro)
               .HasMaxLength(2)
               .HasColumnType("char")
               .IsRequired();
            Property(c => c.Endereco.Pais)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            HasRequired(c => c.Corretora)
                .WithMany(a => a.Enderecos)
                .HasForeignKey(c => c.CorretoraId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("CorretoraEndereco");
        }
    }
}
