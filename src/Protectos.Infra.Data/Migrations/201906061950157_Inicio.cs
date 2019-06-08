namespace Protectos.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administradora",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeFantasia = c.String(nullable: false, maxLength: 100, unicode: false),
                        InscricaoEstadual = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        InscricaoMunicipal = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        Site = c.String(maxLength: 50, unicode: false),
                        CNPJ = c.String(nullable: false, maxLength: 14, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CNPJ, unique: true, name: "IX_CNPJ_Administradora");
            
            CreateTable(
                "dbo.AdministradoraEmail",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        TipoEmail = c.Int(nullable: false),
                        AdministradoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Administradora", t => t.AdministradoraId)
                .Index(t => t.AdministradoraId);
            
            CreateTable(
                "dbo.AdministradoraEndereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        AdministradoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Administradora", t => t.AdministradoraId)
                .Index(t => t.AdministradoraId);
            
            CreateTable(
                "dbo.AdministradoraTelefone",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Prefixo = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        TipoTelefone = c.Int(nullable: false),
                        AdministradoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Administradora", t => t.AdministradoraId)
                .Index(t => t.AdministradoraId);
            
            CreateTable(
                "dbo.Banco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NumeroBanco = c.String(nullable: false, maxLength: 40, unicode: false),
                        DescricaoBanco = c.String(nullable: false, maxLength: 40, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BancoAgencia",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CodigoAgencia = c.String(nullable: false, maxLength: 20, unicode: false),
                        NomeAgenciaBanco = c.String(nullable: false, maxLength: 50, unicode: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 12, fixedLength: true, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        DDD = c.String(nullable: false, maxLength: 8, unicode: false),
                        Fone = c.String(nullable: false, maxLength: 10, unicode: false),
                        BancoId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banco", t => t.BancoId)
                .Index(t => t.BancoId);
            
            CreateTable(
                "dbo.Proposta",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NumeroProposta = c.String(maxLength: 50, unicode: false),
                        PropostaPai = c.Guid(),
                        DataVigencia = c.DateTime(),
                        BeneficiarioId = c.Guid(nullable: false),
                        EntidadeId = c.Guid(nullable: false),
                        CorretorId = c.Guid(nullable: false),
                        TipoVencimentoReferenciaId = c.Guid(nullable: false),
                        BancoId = c.Guid(nullable: false),
                        MotivoExclusaoId = c.Guid(nullable: false),
                        PessoaIdPagadora = c.Guid(),
                        ClienteIdPagadora = c.Guid(nullable: false),
                        FormaPagamento = c.Int(),
                        DiaVencimentoReferencia = c.Int(),
                        NumeroAgenciaBanco = c.String(maxLength: 20, fixedLength: true, unicode: false),
                        DigitoAgenciaBanco = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        NumeroContaCorrente = c.String(maxLength: 20, fixedLength: true, unicode: false),
                        NumeroDigitoContaCorrente = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        CPFPagador = c.String(maxLength: 11, fixedLength: true, unicode: false),
                        CNPJPagador = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        TaxaJuros = c.Decimal(precision: 18, scale: 2),
                        TaxaMulta = c.Decimal(precision: 18, scale: 2),
                        TaxaBancaria = c.Decimal(precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banco", t => t.BancoId)
                .ForeignKey("dbo.Beneficiario", t => t.BeneficiarioId)
                .ForeignKey("dbo.Cliente", t => t.ClienteIdPagadora)
                .ForeignKey("dbo.Corretor", t => t.CorretorId)
                .ForeignKey("dbo.Entidade", t => t.EntidadeId)
                .ForeignKey("dbo.MotivoExclusao", t => t.MotivoExclusaoId)
                .ForeignKey("dbo.TipoVencimentoReferencia", t => t.TipoVencimentoReferenciaId)
                .Index(t => t.BeneficiarioId)
                .Index(t => t.EntidadeId)
                .Index(t => t.CorretorId)
                .Index(t => t.TipoVencimentoReferenciaId)
                .Index(t => t.BancoId)
                .Index(t => t.MotivoExclusaoId)
                .Index(t => t.ClienteIdPagadora);
            
            CreateTable(
                "dbo.Beneficiario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.Int(nullable: false),
                        Cpf = c.String(maxLength: 11, unicode: false),
                        RG = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        DataEmissaoRG = c.DateTime(nullable: false),
                        OrgaoEmissor = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        EstadoCivil = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BeneficiarioDependente",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.Int(nullable: false),
                        Cpf = c.String(maxLength: 11, unicode: false),
                        RG = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        DataEmissaoRG = c.DateTime(nullable: false),
                        OrgaoEmissor = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        EstadoCivil = c.Int(nullable: false),
                        BeneficiarioId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Beneficiario", t => t.BeneficiarioId)
                .Index(t => t.BeneficiarioId);
            
            CreateTable(
                "dbo.BeneficiarioEmail",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        BeneficiarioId = c.Guid(nullable: false),
                        TipoEmail = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Beneficiario", t => t.BeneficiarioId)
                .Index(t => t.BeneficiarioId);
            
            CreateTable(
                "dbo.BeneficiarioEndereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        BeneficiarioId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Beneficiario", t => t.BeneficiarioId)
                .Index(t => t.BeneficiarioId);
            
            CreateTable(
                "dbo.BeneficiarioTelefone",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Prefixo = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        TipoTelefone = c.Int(nullable: false),
                        BeneficiarioId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Beneficiario", t => t.BeneficiarioId)
                .Index(t => t.BeneficiarioId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeFantasia = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        InscricaoEstadual = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        InscricaoMunicipal = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        Site = c.String(maxLength: 50, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Cnpj, unique: true, name: "IX_CNPJ_Cliente");
            
            CreateTable(
                "dbo.ClienteEmail",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        TipoEmail = c.Int(nullable: false),
                        ClienteId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.ClienteEndereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        ClienteId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.ClienteTelefone",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Prefixo = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        TipoTelefone = c.Int(nullable: false),
                        ClienteId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Corretor",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.Int(nullable: false),
                        Cpf = c.String(maxLength: 11, unicode: false),
                        RG = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        DataEmissaoRG = c.DateTime(nullable: false),
                        OrgaoEmissor = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        EstadoCivil = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CorretorEmail",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        CorretorId = c.Guid(nullable: false),
                        TipoEmail = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Corretor", t => t.CorretorId)
                .Index(t => t.CorretorId);
            
            CreateTable(
                "dbo.CorretorEndereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        CorretorId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Corretor", t => t.CorretorId)
                .Index(t => t.CorretorId);
            
            CreateTable(
                "dbo.CorretorTelefone",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Prefixo = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        TipoTelefone = c.Int(nullable: false),
                        CorretorId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Corretor", t => t.CorretorId)
                .Index(t => t.CorretorId);
            
            CreateTable(
                "dbo.Entidade",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeFantasia = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        InscricaoEstadual = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        InscricaoMunicipal = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        Site = c.String(maxLength: 50, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Cnpj, unique: true, name: "IX_CNPJ_Entidade");
            
            CreateTable(
                "dbo.EntidadeEmail",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        TipoEmail = c.Int(nullable: false),
                        EntidadeId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entidade", t => t.EntidadeId)
                .Index(t => t.EntidadeId);
            
            CreateTable(
                "dbo.EntidadeEndereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        EntidadeId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entidade", t => t.EntidadeId)
                .Index(t => t.EntidadeId);
            
            CreateTable(
                "dbo.Fatura",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NomeFatura = c.String(nullable: false, maxLength: 100, unicode: false),
                        NumeroFatura = c.String(nullable: false, maxLength: 50, unicode: false),
                        MesReajuste = c.Int(nullable: false),
                        DiaVigencia = c.Int(nullable: false),
                        VencimentoBoleto = c.Int(nullable: false),
                        VencimentoDBA = c.Int(nullable: false),
                        PermiteCobrancaDobrada = c.Int(nullable: false),
                        TaxaJuros = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxaMulta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxaBancaria = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FaturaCaracteristicaTipo = c.Int(nullable: false),
                        FaturaTipo = c.Int(nullable: false),
                        AjustaPrecoMesAniversario = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        EntidadeId = c.Guid(nullable: false),
                        OperadoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entidade", t => t.EntidadeId)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId)
                .Index(t => t.EntidadeId)
                .Index(t => t.OperadoraId);
            
            CreateTable(
                "dbo.FaturaCarencia",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        numeroFaturaCarencia = c.String(maxLength: 100, unicode: false),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Status = c.Int(nullable: false),
                        FaturaId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fatura", t => t.FaturaId)
                .Index(t => t.FaturaId);
            
            CreateTable(
                "dbo.FaturaPlano",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FaturaId = c.Guid(nullable: false),
                        PlanoId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fatura", t => t.FaturaId)
                .ForeignKey("dbo.Plano", t => t.PlanoId)
                .Index(t => t.FaturaId)
                .Index(t => t.PlanoId);
            
            CreateTable(
                "dbo.Plano",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CodigoPlano = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        PlanoTipo = c.Int(nullable: false),
                        CodigoPlanoANS = c.String(nullable: false, maxLength: 100, unicode: false),
                        Coparticipacao = c.String(nullable: false, maxLength: 100, unicode: false),
                        CodigoAcomodacao = c.String(nullable: false, maxLength: 100, unicode: false),
                        CodigoPlanoSuspenso = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Precificacao",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IdadeInicial = c.Int(nullable: false),
                        IdadeFinal = c.Int(nullable: false),
                        ValorPlanoTitular = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPlanoDependente = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPlanoAgregado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPlanoTitularNet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPlanoDependenteNet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPlanoAgregadoNet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataInicio = c.DateTime(nullable: false),
                        ValorPorcentagemPFP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        PlanoId = c.Guid(nullable: false),
                        FaturaId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fatura", t => t.FaturaId)
                .ForeignKey("dbo.Plano", t => t.PlanoId)
                .Index(t => t.PlanoId)
                .Index(t => t.FaturaId);
            
            CreateTable(
                "dbo.Operadora",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeFantasia = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        InscricaoEstadual = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        InscricaoMunicipal = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        Site = c.String(maxLength: 50, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Cnpj, unique: true, name: "IX_CNPJ_Operadora");
            
            CreateTable(
                "dbo.OperadoraEmail",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        TipoEmail = c.Int(nullable: false),
                        OperadoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId)
                .Index(t => t.OperadoraId);
            
            CreateTable(
                "dbo.OperadoraEndereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        OperadoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId)
                .Index(t => t.OperadoraId);
            
            CreateTable(
                "dbo.OperadoraCongenere",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        OperadoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId)
                .Index(t => t.OperadoraId);
            
            CreateTable(
                "dbo.OperadoraEntidade",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OperadoraId = c.Guid(nullable: false),
                        EntidadeId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entidade", t => t.EntidadeId)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId)
                .Index(t => t.OperadoraId)
                .Index(t => t.EntidadeId);
            
            CreateTable(
                "dbo.OperadoraTelefone",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Prefixo = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        TipoTelefone = c.Int(nullable: false),
                        OperadoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId)
                .Index(t => t.OperadoraId);
            
            CreateTable(
                "dbo.EntidadeTelefone",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Prefixo = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        TipoTelefone = c.Int(nullable: false),
                        EntidadeId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entidade", t => t.EntidadeId)
                .Index(t => t.EntidadeId);
            
            CreateTable(
                "dbo.MotivoExclusao",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OperadoraId = c.Guid(nullable: false),
                        CodigoMotivoExclusao = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoVencimentoReferencia",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                        Vigencia = c.String(nullable: false, maxLength: 20, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Corretora",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeFantasia = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        InscricaoEstadual = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        InscricaoMunicipal = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        Site = c.String(maxLength: 50, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Cnpj, unique: true, name: "IX_CNPJ_Corretora");
            
            CreateTable(
                "dbo.CorretoraEmail",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        TipoEmail = c.Int(nullable: false),
                        CorretoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Corretora", t => t.CorretoraId)
                .Index(t => t.CorretoraId);
            
            CreateTable(
                "dbo.CorretoraEndereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        CorretoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Corretora", t => t.CorretoraId)
                .Index(t => t.CorretoraId);
            
            CreateTable(
                "dbo.CorretoraTelefone",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Prefixo = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        TipoTelefone = c.Int(nullable: false),
                        CorretoraId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Corretora", t => t.CorretoraId)
                .Index(t => t.CorretoraId);
            
            CreateTable(
                "dbo.Filial",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeFantasia = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        InscricaoEstadual = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        InscricaoMunicipal = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        Site = c.String(maxLength: 50, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Cnpj, unique: true, name: "IX_CNPJ_Filial");
            
            CreateTable(
                "dbo.FilialEmail",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        TipoEmail = c.Int(nullable: false),
                        FilialId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Filial", t => t.FilialId)
                .Index(t => t.FilialId);
            
            CreateTable(
                "dbo.FilialEndereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        FilialId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Filial", t => t.FilialId)
                .Index(t => t.FilialId);
            
            CreateTable(
                "dbo.FilialTelefone",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Prefixo = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        TipoTelefone = c.Int(nullable: false),
                        FilialId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Filial", t => t.FilialId)
                .Index(t => t.FilialId);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeFantasia = c.String(nullable: false, maxLength: 100, unicode: false),
                        InscricaoEstadual = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        InscricaoMunicipal = c.String(maxLength: 14, fixedLength: true, unicode: false),
                        Site = c.String(maxLength: 50, unicode: false),
                        CNPJ = c.String(nullable: false, maxLength: 14, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        CadastradoPor = c.Guid(nullable: false),
                        DataAlteracao = c.DateTime(),
                        AlteradoPor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CNPJ, unique: true, name: "IX_CNPJ_Fornecedor");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilialTelefone", "FilialId", "dbo.Filial");
            DropForeignKey("dbo.FilialEndereco", "FilialId", "dbo.Filial");
            DropForeignKey("dbo.FilialEmail", "FilialId", "dbo.Filial");
            DropForeignKey("dbo.CorretoraTelefone", "CorretoraId", "dbo.Corretora");
            DropForeignKey("dbo.CorretoraEndereco", "CorretoraId", "dbo.Corretora");
            DropForeignKey("dbo.CorretoraEmail", "CorretoraId", "dbo.Corretora");
            DropForeignKey("dbo.Proposta", "TipoVencimentoReferenciaId", "dbo.TipoVencimentoReferencia");
            DropForeignKey("dbo.Proposta", "MotivoExclusaoId", "dbo.MotivoExclusao");
            DropForeignKey("dbo.Proposta", "EntidadeId", "dbo.Entidade");
            DropForeignKey("dbo.EntidadeTelefone", "EntidadeId", "dbo.Entidade");
            DropForeignKey("dbo.Fatura", "OperadoraId", "dbo.Operadora");
            DropForeignKey("dbo.OperadoraTelefone", "OperadoraId", "dbo.Operadora");
            DropForeignKey("dbo.OperadoraEntidade", "OperadoraId", "dbo.Operadora");
            DropForeignKey("dbo.OperadoraEntidade", "EntidadeId", "dbo.Entidade");
            DropForeignKey("dbo.OperadoraCongenere", "OperadoraId", "dbo.Operadora");
            DropForeignKey("dbo.OperadoraEndereco", "OperadoraId", "dbo.Operadora");
            DropForeignKey("dbo.OperadoraEmail", "OperadoraId", "dbo.Operadora");
            DropForeignKey("dbo.FaturaPlano", "PlanoId", "dbo.Plano");
            DropForeignKey("dbo.Precificacao", "PlanoId", "dbo.Plano");
            DropForeignKey("dbo.Precificacao", "FaturaId", "dbo.Fatura");
            DropForeignKey("dbo.FaturaPlano", "FaturaId", "dbo.Fatura");
            DropForeignKey("dbo.FaturaCarencia", "FaturaId", "dbo.Fatura");
            DropForeignKey("dbo.Fatura", "EntidadeId", "dbo.Entidade");
            DropForeignKey("dbo.EntidadeEndereco", "EntidadeId", "dbo.Entidade");
            DropForeignKey("dbo.EntidadeEmail", "EntidadeId", "dbo.Entidade");
            DropForeignKey("dbo.Proposta", "CorretorId", "dbo.Corretor");
            DropForeignKey("dbo.CorretorTelefone", "CorretorId", "dbo.Corretor");
            DropForeignKey("dbo.CorretorEndereco", "CorretorId", "dbo.Corretor");
            DropForeignKey("dbo.CorretorEmail", "CorretorId", "dbo.Corretor");
            DropForeignKey("dbo.Proposta", "ClienteIdPagadora", "dbo.Cliente");
            DropForeignKey("dbo.ClienteTelefone", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.ClienteEndereco", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.ClienteEmail", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Proposta", "BeneficiarioId", "dbo.Beneficiario");
            DropForeignKey("dbo.BeneficiarioTelefone", "BeneficiarioId", "dbo.Beneficiario");
            DropForeignKey("dbo.BeneficiarioEndereco", "BeneficiarioId", "dbo.Beneficiario");
            DropForeignKey("dbo.BeneficiarioEmail", "BeneficiarioId", "dbo.Beneficiario");
            DropForeignKey("dbo.BeneficiarioDependente", "BeneficiarioId", "dbo.Beneficiario");
            DropForeignKey("dbo.Proposta", "BancoId", "dbo.Banco");
            DropForeignKey("dbo.BancoAgencia", "BancoId", "dbo.Banco");
            DropForeignKey("dbo.AdministradoraTelefone", "AdministradoraId", "dbo.Administradora");
            DropForeignKey("dbo.AdministradoraEndereco", "AdministradoraId", "dbo.Administradora");
            DropForeignKey("dbo.AdministradoraEmail", "AdministradoraId", "dbo.Administradora");
            DropIndex("dbo.Fornecedor", "IX_CNPJ_Fornecedor");
            DropIndex("dbo.FilialTelefone", new[] { "FilialId" });
            DropIndex("dbo.FilialEndereco", new[] { "FilialId" });
            DropIndex("dbo.FilialEmail", new[] { "FilialId" });
            DropIndex("dbo.Filial", "IX_CNPJ_Filial");
            DropIndex("dbo.CorretoraTelefone", new[] { "CorretoraId" });
            DropIndex("dbo.CorretoraEndereco", new[] { "CorretoraId" });
            DropIndex("dbo.CorretoraEmail", new[] { "CorretoraId" });
            DropIndex("dbo.Corretora", "IX_CNPJ_Corretora");
            DropIndex("dbo.EntidadeTelefone", new[] { "EntidadeId" });
            DropIndex("dbo.OperadoraTelefone", new[] { "OperadoraId" });
            DropIndex("dbo.OperadoraEntidade", new[] { "EntidadeId" });
            DropIndex("dbo.OperadoraEntidade", new[] { "OperadoraId" });
            DropIndex("dbo.OperadoraCongenere", new[] { "OperadoraId" });
            DropIndex("dbo.OperadoraEndereco", new[] { "OperadoraId" });
            DropIndex("dbo.OperadoraEmail", new[] { "OperadoraId" });
            DropIndex("dbo.Operadora", "IX_CNPJ_Operadora");
            DropIndex("dbo.Precificacao", new[] { "FaturaId" });
            DropIndex("dbo.Precificacao", new[] { "PlanoId" });
            DropIndex("dbo.FaturaPlano", new[] { "PlanoId" });
            DropIndex("dbo.FaturaPlano", new[] { "FaturaId" });
            DropIndex("dbo.FaturaCarencia", new[] { "FaturaId" });
            DropIndex("dbo.Fatura", new[] { "OperadoraId" });
            DropIndex("dbo.Fatura", new[] { "EntidadeId" });
            DropIndex("dbo.EntidadeEndereco", new[] { "EntidadeId" });
            DropIndex("dbo.EntidadeEmail", new[] { "EntidadeId" });
            DropIndex("dbo.Entidade", "IX_CNPJ_Entidade");
            DropIndex("dbo.CorretorTelefone", new[] { "CorretorId" });
            DropIndex("dbo.CorretorEndereco", new[] { "CorretorId" });
            DropIndex("dbo.CorretorEmail", new[] { "CorretorId" });
            DropIndex("dbo.ClienteTelefone", new[] { "ClienteId" });
            DropIndex("dbo.ClienteEndereco", new[] { "ClienteId" });
            DropIndex("dbo.ClienteEmail", new[] { "ClienteId" });
            DropIndex("dbo.Cliente", "IX_CNPJ_Cliente");
            DropIndex("dbo.BeneficiarioTelefone", new[] { "BeneficiarioId" });
            DropIndex("dbo.BeneficiarioEndereco", new[] { "BeneficiarioId" });
            DropIndex("dbo.BeneficiarioEmail", new[] { "BeneficiarioId" });
            DropIndex("dbo.BeneficiarioDependente", new[] { "BeneficiarioId" });
            DropIndex("dbo.Proposta", new[] { "ClienteIdPagadora" });
            DropIndex("dbo.Proposta", new[] { "MotivoExclusaoId" });
            DropIndex("dbo.Proposta", new[] { "BancoId" });
            DropIndex("dbo.Proposta", new[] { "TipoVencimentoReferenciaId" });
            DropIndex("dbo.Proposta", new[] { "CorretorId" });
            DropIndex("dbo.Proposta", new[] { "EntidadeId" });
            DropIndex("dbo.Proposta", new[] { "BeneficiarioId" });
            DropIndex("dbo.BancoAgencia", new[] { "BancoId" });
            DropIndex("dbo.AdministradoraTelefone", new[] { "AdministradoraId" });
            DropIndex("dbo.AdministradoraEndereco", new[] { "AdministradoraId" });
            DropIndex("dbo.AdministradoraEmail", new[] { "AdministradoraId" });
            DropIndex("dbo.Administradora", "IX_CNPJ_Administradora");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.FilialTelefone");
            DropTable("dbo.FilialEndereco");
            DropTable("dbo.FilialEmail");
            DropTable("dbo.Filial");
            DropTable("dbo.CorretoraTelefone");
            DropTable("dbo.CorretoraEndereco");
            DropTable("dbo.CorretoraEmail");
            DropTable("dbo.Corretora");
            DropTable("dbo.TipoVencimentoReferencia");
            DropTable("dbo.MotivoExclusao");
            DropTable("dbo.EntidadeTelefone");
            DropTable("dbo.OperadoraTelefone");
            DropTable("dbo.OperadoraEntidade");
            DropTable("dbo.OperadoraCongenere");
            DropTable("dbo.OperadoraEndereco");
            DropTable("dbo.OperadoraEmail");
            DropTable("dbo.Operadora");
            DropTable("dbo.Precificacao");
            DropTable("dbo.Plano");
            DropTable("dbo.FaturaPlano");
            DropTable("dbo.FaturaCarencia");
            DropTable("dbo.Fatura");
            DropTable("dbo.EntidadeEndereco");
            DropTable("dbo.EntidadeEmail");
            DropTable("dbo.Entidade");
            DropTable("dbo.CorretorTelefone");
            DropTable("dbo.CorretorEndereco");
            DropTable("dbo.CorretorEmail");
            DropTable("dbo.Corretor");
            DropTable("dbo.ClienteTelefone");
            DropTable("dbo.ClienteEndereco");
            DropTable("dbo.ClienteEmail");
            DropTable("dbo.Cliente");
            DropTable("dbo.BeneficiarioTelefone");
            DropTable("dbo.BeneficiarioEndereco");
            DropTable("dbo.BeneficiarioEmail");
            DropTable("dbo.BeneficiarioDependente");
            DropTable("dbo.Beneficiario");
            DropTable("dbo.Proposta");
            DropTable("dbo.BancoAgencia");
            DropTable("dbo.Banco");
            DropTable("dbo.AdministradoraTelefone");
            DropTable("dbo.AdministradoraEndereco");
            DropTable("dbo.AdministradoraEmail");
            DropTable("dbo.Administradora");
        }
    }
}
