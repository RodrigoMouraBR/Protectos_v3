﻿using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Operadoras;
using Protectos.Infra.Data.Mappings.Administradoras;
using Protectos.Infra.Data.Mappings.Beneficiarios;
using Protectos.Infra.Data.Mappings.Corretoras;
using Protectos.Infra.Data.Mappings.Operadoras;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Protectos.Infra.Data.Context
{
    public class ProtectosContext : DbContext
    {
        public ProtectosContext() : base("DefaultConnection")
        {
        }
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

            modelBuilder.Configurations.Add(new CorretoraMapping());
            modelBuilder.Configurations.Add(new CorretoraEnderecoMapping());
            modelBuilder.Configurations.Add(new CorretoraEmailMapping());
            modelBuilder.Configurations.Add(new CorretoraTelefoneMapping());
           
            modelBuilder.Configurations.Add(new AdministradoraMapping());
            modelBuilder.Configurations.Add(new AdministradoraEnderecoMapping());
            modelBuilder.Configurations.Add(new AdministradoraEmailMapping());
            modelBuilder.Configurations.Add(new AdministradoraTelefoneMapping());
            //modelBuilder.Configurations.Add(new ());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Beneficiario> Beneficiario { get; set; }
        public DbSet<BeneficiarioDependente> BeneficiarioDependente { get; set; }
        public DbSet<BeneficiarioEmail> BeneficiarioEmail { get; set; }
        public DbSet<BeneficiarioEndereco> BeneficiarioEndereco { get; set; }
        public DbSet<BeneficiarioTelefone> BeneficiarioTelefone { get; set; }

        public DbSet<Administradora> Administradora { get; set; }
        public DbSet<AdministradoraEmail> AdministradoraEmail { get; set; }
        public DbSet<AdministradoraEndereco> AdministradoraEndereco { get; set; }
        public DbSet<AdministradoraTelefone> AdministradoraTelefone { get; set; }

        public DbSet<Corretora> Corretora { get; set; }
        public DbSet<CorretoraEmail> CorretoraEmail { get; set; }
        public DbSet<CorretoraEndereco> CorretoraEndereco { get; set; }
        public DbSet<CorretoraTelefone> CorretoraTelefone { get; set; }

        public DbSet<Operadora> Operadora { get; set; }
        public DbSet<OperadoraEmail> OperadoraEmail { get; set; }
        public DbSet<OperadoraEndereco> OperadoraEndereco { get; set; }
        public DbSet<OperadoraTelefone> OperadoraTelefone { get; set; }
    }
}
