using Protectos.Domain.Entities.Clientes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Clientes
{
    public class ClienteEmailMapping : EntityTypeConfiguration<ClienteEmail>
    {
        public ClienteEmailMapping()
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

            Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.TipoEmail)
                .IsRequired();

            HasRequired(c => c.Cliente)
                    .WithMany(a => a.Emails)
                    .HasForeignKey(c => c.ClienteId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("ClienteEmail");
        }
    }
}
