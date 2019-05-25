using Protectos.Domain.Entities.Clientes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Clientes
{
    class ClienteEnderecoMapping : EntityTypeConfiguration<ClienteEndereco>
    {
        public ClienteEnderecoMapping()
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

            Property(c => c.Logradouro)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.Numero)
               .HasMaxLength(10)
               .HasColumnType("char")
               .IsRequired();

            Property(c => c.Bairro)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();

            Property(c => c.Cep)
               .HasMaxLength(10)
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

            Property(c => c.Pais)
                .HasMaxLength(50)
                .HasColumnType("char")
                .IsRequired();

            HasRequired(c => c.Cliente)
               .WithMany(a => a.Enderecos)
               .HasForeignKey(c => c.ClienteId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("ClienteEndereco");

        }
    }
}
