using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Operadoras;
using Protectos.Infra.Data.Mappings.Administradoras;
using Protectos.Infra.Data.Mappings.Beneficiarios;
using Protectos.Infra.Data.Mappings.Corretoras;
using Protectos.Infra.Data.Mappings.Entidades;
using Protectos.Infra.Data.Mappings.Faturas;
using Protectos.Infra.Data.Mappings.Operadoras;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;

namespace Protectos.Infra.Data.Context
{
    public class ProtectosContext : DbContext
    {
        public ProtectosContext() : base("DefaultConnection")
        {
            Database.SetInitializer<ProtectosContext>(null);
        }
        public virtual DbSet<Beneficiario> Beneficiario { get; set; }
        public virtual DbSet<BeneficiarioDependente> BeneficiarioDependente { get; set; }
        public virtual DbSet<BeneficiarioEmail> BeneficiarioEmail { get; set; }
        public virtual DbSet<BeneficiarioEndereco> BeneficiarioEndereco { get; set; }
        public virtual DbSet<BeneficiarioTelefone> BeneficiarioTelefone { get; set; }

        public virtual DbSet<Operadora> Operadora { get; set; }
        public virtual DbSet<OperadoraEmail> OperadoraEmail { get; set; }
        public virtual DbSet<OperadoraEndereco> OperadoraEndereco { get; set; }
        public virtual DbSet<OperadoraTelefone> OperadoraTelefone { get; set; }

        public virtual DbSet<Entidade> Entidade { get; set; }
        public virtual DbSet<EntidadeEmail> EntidadeEmail { get; set; }
        public virtual DbSet<EntidadeEndereco> EntidadeEndereco { get; set; }
        public virtual DbSet<EntidadeTelefone> EntidadeTelefone { get; set; }

        public virtual DbSet<Corretora> Corretora { get; set; }
        public virtual DbSet<CorretoraEmail> CorretoraEmail { get; set; }
        public virtual DbSet<CorretoraEndereco> CorretoraEndereco { get; set; }
        public virtual DbSet<CorretoraTelefone> CorretoraTelefone { get; set; }

        public virtual DbSet<Administradora> Administradora { get; set; }
        public virtual DbSet<AdministradoraEmail> AdministradoraEmail { get; set; }
        public virtual DbSet<AdministradoraEndereco> AdministradoraEndereco { get; set; }
        public virtual DbSet<AdministradoraTelefone> AdministradoraTelefone { get; set; }

        public virtual DbSet<Fatura> Fatura { get; set; }
        public virtual DbSet<FaturaCarencia> FaturaCarencia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new BeneficiarioMapping());
            modelBuilder.Configurations.Add(new BeneficiarioDependenteMapping());
            modelBuilder.Configurations.Add(new BeneficiarioEmailMapping());
            modelBuilder.Configurations.Add(new BeneficiarioEnderecoMapping());
            modelBuilder.Configurations.Add(new BeneficiarioTelefoneMapping());

            modelBuilder.Configurations.Add(new OperadoraMapping());
            modelBuilder.Configurations.Add(new OperadoraEnderecoMapping());
            modelBuilder.Configurations.Add(new OperadoraTelefoneMapping());
            modelBuilder.Configurations.Add(new OperadoraEmailMapping());

            modelBuilder.Configurations.Add(new EntidadeMapping());
            modelBuilder.Configurations.Add(new EntidadeEnderecoMapping());
            modelBuilder.Configurations.Add(new EntidadeEmailMapping());
            modelBuilder.Configurations.Add(new EntidadeTelefoneMapping());

            modelBuilder.Configurations.Add(new CorretoraMapping());
            modelBuilder.Configurations.Add(new CorretoraEnderecoMapping());
            modelBuilder.Configurations.Add(new CorretoraEmailMapping());
            modelBuilder.Configurations.Add(new CorretoraTelefoneMapping());

            modelBuilder.Configurations.Add(new AdministradoraMapping());
            modelBuilder.Configurations.Add(new AdministradoraEnderecoMapping());
            modelBuilder.Configurations.Add(new AdministradoraEmailMapping());
            modelBuilder.Configurations.Add(new AdministradoraTelefoneMapping());

            modelBuilder.Configurations.Add(new FaturaMapping());
            modelBuilder.Configurations.Add(new FaturaCarenciaMapping());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }



    }
}
