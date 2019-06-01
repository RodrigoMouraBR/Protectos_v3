using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Clientes;
using Protectos.Domain.Entities.Cobrancas;
using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Corretores;
using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Filiais;
using Protectos.Domain.Entities.Fornecedores;
using Protectos.Domain.Entities.Operadoras;
using Protectos.Domain.Entities.Planos;
using Protectos.Domain.Entities.Propostas;
using Protectos.Infra.Data.Mappings.Administradoras;
using Protectos.Infra.Data.Mappings.Beneficiarios;
using Protectos.Infra.Data.Mappings.Clientes;
using Protectos.Infra.Data.Mappings.Cobrancas;
using Protectos.Infra.Data.Mappings.Corretoras;
using Protectos.Infra.Data.Mappings.Corretores;
using Protectos.Infra.Data.Mappings.Entidades;
using Protectos.Infra.Data.Mappings.Faturas;
using Protectos.Infra.Data.Mappings.Filiais;
using Protectos.Infra.Data.Mappings.Fornecedores;
using Protectos.Infra.Data.Mappings.Operadoras;
using Protectos.Infra.Data.Mappings.Planos;
using Protectos.Infra.Data.Mappings.Propostas;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Protectos.Infra.Data.Context
{
    public class ProtectosContext : DbContext
    {
        public ProtectosContext() : base("DefaultConnection")
        {            
        }     

        public virtual DbSet<Beneficiario> Beneficiario { get; set; }
        public virtual DbSet<BeneficiarioEmail> BeneficiarioEmail { get; set; }
        public virtual DbSet<BeneficiarioEndereco> BeneficiarioEndereco { get; set; }
        public virtual DbSet<BeneficiarioTelefone> BeneficiarioTelefone { get; set; }
        public virtual DbSet<BeneficiarioDependente> BeneficiarioDependente { get; set; }

        public virtual DbSet<Proposta> Proposta { get; set; }
        public virtual DbSet<TipoVencimentoReferencia> TipoVencimentoReferencia { get; set; }

        public virtual DbSet<BancoAgencia> BancoAgencia { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<MotivoExclusao> MotivoExclusao { get; set; }

        public virtual DbSet<Entidade> Entidade { get; set; }
        public virtual DbSet<EntidadeEmail> EntidadeEmail { get; set; }
        public virtual DbSet<EntidadeEndereco> EntidadeEndereco { get; set; }
        public virtual DbSet<EntidadeTelefone> EntidadeTelefone { get; set; }

        public virtual DbSet<Corretor> Corretor { get; set; }
        public virtual DbSet<CorretorEmail> CorretorEmail { get; set; }
        public virtual DbSet<CorretorEndereco> CorretorEndereco { get; set; }
        public virtual DbSet<CorretorTelefone> CorretorTelefone { get; set; }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ClienteEmail> ClienteEmail { get; set; }
        public virtual DbSet<ClienteEndereco> ClienteEndereco { get; set; }
        public virtual DbSet<ClienteTelefone> ClienteTelefone { get; set; }

        public virtual DbSet<Filial> Filial { get; set; }
        public virtual DbSet<FilialEmail> FilialEmail { get; set; }
        public virtual DbSet<FilialEndereco> FilialEndereco { get; set; }
        public virtual DbSet<FilialTelefone> FilialTelefone { get; set; }

        public virtual DbSet<Fatura> Fatura { get; set; }
        public virtual DbSet<FaturaCarencia> FaturaCarencia { get; set; }

        public virtual DbSet<Operadora> Operadora { get; set; }
        public virtual DbSet<OperadoraEmail> OperadoraEmail { get; set; }
        public virtual DbSet<OperadoraEndereco> OperadoraEndereco { get; set; }
        public virtual DbSet<OperadoraTelefone> OperadoraTelefone { get; set; }
        public virtual DbSet<OperadoraCongenere> OperadoraCongenere { get; set; }
        public virtual DbSet<OperadoraEntidade> OperadoraEntidade { get; set; }

        public virtual DbSet<Administradora> Administradora { get; set; }
        public virtual DbSet<AdministradoraEmail> AdministradoraEmail { get; set; }
        public virtual DbSet<AdministradoraEndereco> AdministradoraEndereco { get; set; }
        public virtual DbSet<AdministradoraTelefone> AdministradoraTelefone { get; set; }
        public virtual DbSet<Precificacao> Precificacao { get; set; }
        public virtual DbSet<Plano> Plano { get; set; }
        public virtual DbSet<FaturaPlano> FaturaPlano { get; set; }

        public virtual DbSet<Corretora> Corretora { get; set; }
        public virtual DbSet<CorretoraEmail> CorretoraEmail { get; set; }
        public virtual DbSet<CorretoraEndereco> CorretoraEndereco { get; set; }
        public virtual DbSet<CorretoraTelefone> CorretoraTelefone { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();           

            modelBuilder.Configurations.Add(new BeneficiarioMapping());
            modelBuilder.Configurations.Add(new BeneficiarioEmailMapping());
            modelBuilder.Configurations.Add(new BeneficiarioEnderecoMapping());
            modelBuilder.Configurations.Add(new BeneficiarioTelefoneMapping());
            modelBuilder.Configurations.Add(new BeneficiarioDependenteMapping());

            modelBuilder.Configurations.Add(new PropostaMapping());
            modelBuilder.Configurations.Add(new TipoVencimentoReferenciaMapping());
            modelBuilder.Configurations.Add(new MotivoExclusaoMapping());

            modelBuilder.Configurations.Add(new BancoAgenciaMapping());
            modelBuilder.Configurations.Add(new BancoMapping());

            modelBuilder.Configurations.Add(new EntidadeMapping());
            modelBuilder.Configurations.Add(new EntidadeEnderecoMapping());
            modelBuilder.Configurations.Add(new EntidadeEmailMapping());
            modelBuilder.Configurations.Add(new EntidadeTelefoneMapping());

            modelBuilder.Configurations.Add(new CorretorMapping());
            modelBuilder.Configurations.Add(new CorretorEnderecoMapping());
            modelBuilder.Configurations.Add(new CorretorEmailMapping());
            modelBuilder.Configurations.Add(new CorretorTelefoneMapping());

            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new ClienteEnderecoMapping());
            modelBuilder.Configurations.Add(new ClienteEmailMapping());
            modelBuilder.Configurations.Add(new ClienteTelefoneMapping());

            modelBuilder.Configurations.Add(new FilialMapping());
            modelBuilder.Configurations.Add(new FilialEnderecoMapping());
            modelBuilder.Configurations.Add(new FilialEmailMapping());
            modelBuilder.Configurations.Add(new FilialTelefoneMapping());

            modelBuilder.Configurations.Add(new FaturaMapping());
            modelBuilder.Configurations.Add(new FaturaCarenciaMapping());            

            modelBuilder.Configurations.Add(new OperadoraMapping());
            modelBuilder.Configurations.Add(new OperadoraEnderecoMapping());
            modelBuilder.Configurations.Add(new OperadoraTelefoneMapping());
            modelBuilder.Configurations.Add(new OperadoraEmailMapping());
            modelBuilder.Configurations.Add(new OperadoraCongenereMapping());
            modelBuilder.Configurations.Add(new OperadoraEntidadeMapping());

            modelBuilder.Configurations.Add(new AdministradoraMapping());
            modelBuilder.Configurations.Add(new AdministradoraEnderecoMapping());
            modelBuilder.Configurations.Add(new AdministradoraEmailMapping());
            modelBuilder.Configurations.Add(new AdministradoraTelefoneMapping());
            modelBuilder.Configurations.Add(new PrecificacaoMapping());
            modelBuilder.Configurations.Add(new PlanoMapping());
            modelBuilder.Configurations.Add(new FaturaPlanoMapping());

            modelBuilder.Configurations.Add(new CorretoraMapping());
            modelBuilder.Configurations.Add(new CorretoraEnderecoMapping());
            modelBuilder.Configurations.Add(new CorretoraEmailMapping());
            modelBuilder.Configurations.Add(new CorretoraTelefoneMapping());

            modelBuilder.Configurations.Add(new FornecedorMapping());

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
