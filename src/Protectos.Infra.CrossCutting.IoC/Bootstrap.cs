using Protectos.Application.ApplicationServices.Administradoras;
using Protectos.Application.ApplicationServices.Beneficiarios;
using Protectos.Application.ApplicationServices.Clientes;
using Protectos.Application.ApplicationServices.Corretoras;
using Protectos.Application.ApplicationServices.Entidades;
using Protectos.Application.ApplicationServices.Faturas;
using Protectos.Application.ApplicationServices.Operadoras;
using Protectos.Application.Interfaces.Administradoras;
using Protectos.Application.Interfaces.Beneficiarios;
using Protectos.Application.Interfaces.Clientes;
using Protectos.Application.Interfaces.Corretoras;
using Protectos.Application.Interfaces.Entidades;
using Protectos.Application.Interfaces.Fatura;
using Protectos.Application.Interfaces.Operadoras;
using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Administradoras.Interfaces.Services;
using Protectos.Domain.Entities.Administradoras.Services;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Services;
using Protectos.Domain.Entities.Beneficiarios.Services;
using Protectos.Domain.Entities.Clientes.Interfaces.Repositories;
using Protectos.Domain.Entities.Clientes.Interfaces.Services;
using Protectos.Domain.Entities.Clientes.Services;
using Protectos.Domain.Entities.Corretoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Corretoras.Interfaces.Services;
using Protectos.Domain.Entities.Corretoras.Services;
using Protectos.Domain.Entities.Entidades.Interfaces.Repositories;
using Protectos.Domain.Entities.Entidades.Interfaces.Services;
using Protectos.Domain.Entities.Entidades.Services;
using Protectos.Domain.Entities.Faturas.Interfaces.Interfaces.Services;
using Protectos.Domain.Entities.Faturas.Interfaces.Repositories;
using Protectos.Domain.Entities.Faturas.Services;
using Protectos.Domain.Entities.Operadoras.Interfaces;
using Protectos.Domain.Entities.Operadoras.Interfaces.Services;
using Protectos.Domain.Entities.Operadoras.Services;
using Protectos.Domain.Generics.Interfaces;
using Protectos.Domain.Generics.Interfaces.Services;
using Protectos.Infra.CrossCutting.ExternalService.Services;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
using Protectos.Infra.Data.Interfaces;
using Protectos.Infra.Data.Repositories.Administradoras;
using Protectos.Infra.Data.Repositories.Beneficiarios;
using Protectos.Infra.Data.Repositories.Clientes;
using Protectos.Infra.Data.Repositories.Corretoras;
using Protectos.Infra.Data.Repositories.Entidades;
using Protectos.Infra.Data.Repositories.Faturas;
using Protectos.Infra.Data.Repositories.Operadoras;
using Protectos.Infra.Data.UoW;
using SimpleInjector;
namespace Protectos.Infra.CrossCutting.IoC
{
    public class Bootstrap
    {
        public static void Register(Container container)
        {
            //Repositorio            
            container.Register<IAdministradoraRepository, AdministradoraRepository>(Lifestyle.Scoped);
            container.Register<IAdministradoraEnderecoRepository, AdministradoraEnderecoRepository>(Lifestyle.Scoped);
            container.Register<IAdministradoraEmailRepository, AdministradoraEmailRepository>(Lifestyle.Scoped);
            container.Register<IAdministradoraTelefoneRepository, AdministradoraTelefoneRepository>(Lifestyle.Scoped);

            container.Register<IBeneficiarioRepository, BeneficiarioRepository>(Lifestyle.Scoped);
            container.Register<IBeneficiarioEnderecoRepository, BeneficiarioEnderecoRepository>(Lifestyle.Scoped);
            container.Register<IBeneficiarioEmailRepository, BeneficiarioEmailRepository>(Lifestyle.Scoped);
            container.Register<IBeneficiarioTelefoneRepository, BeneficiarioTelefoneRepository>(Lifestyle.Scoped);

            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);
            container.Register<IClienteEmailRepository, ClienteEmailRepository>(Lifestyle.Scoped);
            container.Register<IClienteEnderecoRepository, ClienteEnderecoRepository>(Lifestyle.Scoped);
            container.Register<IClienteTelefoneRepository, ClienteTelefoneRepository>(Lifestyle.Scoped);

            container.Register<ICorretoraRepository, CorretoraRepository>(Lifestyle.Scoped);
            container.Register<ICorretoraEmailRepository, CorretoraEmailRepository>(Lifestyle.Scoped);
            container.Register<ICorretoraEnderecoRepository, CorretoraEnderecoRepository>(Lifestyle.Scoped);
            container.Register<ICorretoraTelefoneRepository, CorretoraTelefoneRepository>(Lifestyle.Scoped);

            container.Register<IEntidadeRepository, EntidadeRepository>(Lifestyle.Scoped);
            container.Register<IEntidadeEmailRepository, EntidadeEmailRepository>(Lifestyle.Scoped);
            container.Register<IEntidadeEnderecoRepository, EntidadeEnderecoRepository>(Lifestyle.Scoped);
            container.Register<IEntidadeTelefoneRepository, EntidadeTelefoneRepository>(Lifestyle.Scoped);

            container.Register<IOperadoraRepository, OperadoraRepository>(Lifestyle.Scoped);
            container.Register<IOperadoraEnderecoRepository, OperadoraEnderecoRepository>(Lifestyle.Scoped);
            container.Register<IOperadoraEmailRepository, OperadoraEmailRepository>(Lifestyle.Scoped);
            container.Register<IOperadoraTelefoneRepository, OperadoraTelefoneRepository>(Lifestyle.Scoped);

            container.Register<IFaturaRepository, FaturaRepository>(Lifestyle.Scoped);


            //Application
            container.Register<IAdministradoraApplicationService, AdministradoraApplicationService>(Lifestyle.Scoped);
            container.Register<IOperadoraApplicationService, OperadoraApplicationService>(Lifestyle.Scoped);
            container.Register<IBeneficiarioApplicationService, BeneficiarioApplicationService>(Lifestyle.Scoped);
            container.Register<IClienteApplicationService, ClienteApplicationService>(Lifestyle.Scoped);
            container.Register<ICorretoraApplicationService, CorretoraApplicationService>(Lifestyle.Scoped);
            container.Register<IFaturaApplicationService, FaturaApplicationService>(Lifestyle.Scoped);
            container.Register<IEntidadeApplicationService, EntidadeApplicationService>(Lifestyle.Scoped);

            ///Domain Service
            container.Register<IAdministradoraService, AdministradoraService>(Lifestyle.Scoped);
            container.Register<IBeneficiarioService, BeneficiarioService>(Lifestyle.Scoped);
            container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);
            container.Register<ICorretoraService, CorretoraService>(Lifestyle.Scoped);
            container.Register<IOperadoraService, OperadoraService>(Lifestyle.Scoped);
            container.Register<IEntidadeService, EntidadeService>(Lifestyle.Scoped);
            container.Register<IFaturaService, FaturaService>(Lifestyle.Scoped);
            container.Register<IViaCepExternalService, ViaCepExternalService>(Lifestyle.Scoped);

            //UoC
            container.Register<IUnitOfWork, UnitOfWOrk>(Lifestyle.Scoped);
            //Context
            container.Register<ProtectosContext>(Lifestyle.Scoped);




        }
    }
}
