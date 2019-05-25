using Protectos.Domain.Entities.Administradoras;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Administradoras
{
    public class AdministradoraEnderecoMapping : EntityTypeConfiguration<AdministradoraEndereco>
    {
        public AdministradoraEnderecoMapping()
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

            HasRequired(c => c.Administradora)
                .WithMany(a => a.Enderecos)
                .HasForeignKey(c => c.AdministradoraId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("AdministradoraEndereco");
        }
    }
}
