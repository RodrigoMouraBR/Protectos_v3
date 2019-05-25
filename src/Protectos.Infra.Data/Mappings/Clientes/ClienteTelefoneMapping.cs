using Protectos.Domain.Entities.Clientes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Clientes
{
    public class ClienteTelefoneMapping : EntityTypeConfiguration<ClienteTelefone>
    {
        public ClienteTelefoneMapping()
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

            HasRequired(c => c.Cliente)
              .WithMany(a => a.Telefones)
              .HasForeignKey(c => c.ClienteId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("ClienteTelefone");

        }
    }
}
