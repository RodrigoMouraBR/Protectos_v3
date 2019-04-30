using Protectos.Domain.Entities.Administradoras;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Administradoras
{
    public class AdministradoraEnderecoMapping : EntityTypeConfiguration<AdministradoraEndereco>
    {
        public AdministradoraEnderecoMapping()
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
            HasRequired(c => c.Administradora)
                .WithMany(a => a.Enderecos)
                .HasForeignKey(c => c.AdministradoraId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("AdministradoraEndereco");

        }
    }
}
