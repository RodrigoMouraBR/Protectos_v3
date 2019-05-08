using Protectos.Application.ApplicationServices.Administradoras;
using Protectos.Application.ApplicationServices.Beneficiarios;
using Protectos.Application.ApplicationServices.Corretoras;
using Protectos.Application.ApplicationServices.Operadoras;
using Protectos.Application.Interfaces.Administradoras;
using Protectos.Application.Interfaces.Beneficiarios;
using Protectos.Application.Interfaces.Corretoras;
using Protectos.Application.Interfaces.Operadoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Administradoras.Interfaces.Services;
using Protectos.Domain.Entities.Administradoras.Services;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Services;
using Protectos.Domain.Entities.Beneficiarios.Services;
using Protectos.Domain.Entities.Corretoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Corretoras.Interfaces.Services;
using Protectos.Domain.Entities.Corretoras.Services;
using Protectos.Domain.Entities.Entidades.Interfaces.Services;
using Protectos.Domain.Entities.Entidades.Services;
using Protectos.Domain.Entities.Operadoras.Interfaces;
using Protectos.Domain.Entities.Operadoras.Interfaces.Services;
using Protectos.Domain.Entities.Operadoras.Services;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Interfaces;
using Protectos.Infra.Data.Repositories.Administradoras;
using Protectos.Infra.Data.Repositories.Beneficiarios;
using Protectos.Infra.Data.Repositories.Corretoras;
using Protectos.Infra.Data.Repositories.Operadoras;
using Protectos.Infra.Data.UoW;
using SimpleInjector;
namespace Protectos.Infra.CrossCutting.IoC
{
    public class Bootstrap
    {
        public static void Register(Container container)
        {
            ////////////////////////////////Repositorio//////////////////////////////////////////////////////////

            //Administradora
            container.Register<IAdministradoraRepository, AdministradoraRepository>(Lifestyle.Scoped);
            container.Register<IAdministradoraEnderecoRepository, AdministradoraEnderecoRepository>(Lifestyle.Scoped);
            container.Register<IAdministradoraEmailRepository, AdministradoraEmailRepository>(Lifestyle.Scoped);
            container.Register<IAdministradoraTelefoneRepository, AdministradoraTelefoneRepository>(Lifestyle.Scoped);            
            //Operadora
            container.Register<IOperadoraRepository, OperadoraRepository>(Lifestyle.Scoped);
            container.Register<IOperadoraEnderecoRepository, OperadoraEnderecoRepository>(Lifestyle.Scoped);
            container.Register<IOperadoraEmailRepository, OperadoraEmailRepository>(Lifestyle.Scoped);
            container.Register<IOperadoraTelefoneRepository, OperadoraTelefoneRepository>(Lifestyle.Scoped);
            //Coretora
            container.Register<ICorretoraRepository, CorretoraRepository>(Lifestyle.Scoped);
            container.Register<ICorretoraEmailRepository, CorretoraEmailRepository>(Lifestyle.Scoped);
            container.Register<ICorretoraEnderecoRepository, CorretoraEnderecoRepository>(Lifestyle.Scoped);
            container.Register<ICorretoraTelefoneRepository, CorretoraTelefoneRepository>(Lifestyle.Scoped);
            //Beneficiario
            container.Register<IBeneficiarioRepository, BeneficiarioRepository>(Lifestyle.Scoped);            
            container.Register<IBeneficiarioEnderecoRepository, BeneficiarioEnderecoRepository>(Lifestyle.Scoped);
            container.Register<IBeneficiarioEmailRepository, BeneficiarioEmailRepository>(Lifestyle.Scoped);
            container.Register<IBeneficiarioTelefoneRepository, BeneficiarioTelefoneRepository>(Lifestyle.Scoped);            

            ////////////////////////////////Application//////////////////////////////////////////////////////////

            container.Register<IAdministradoraApplicationService, AdministradoraApplicationService>(Lifestyle.Scoped);
            container.Register<IOperadoraApplicationService, OperadoraApplicationService>(Lifestyle.Scoped);
            container.Register<IBeneficiarioApplicationService, BeneficiarioApplicationService>(Lifestyle.Scoped);
            container.Register<ICorretoraApplicationService, CorretoraApplicationService>(Lifestyle.Scoped);

            ////////////////////////////////Domain Service//////////////////////////////////////////////////////////
            container.Register<IAdministradoraService, AdministradoraService>(Lifestyle.Scoped);
            container.Register<IBeneficiarioService, BeneficiarioService>(Lifestyle.Scoped);
            container.Register<ICorretoraService, CorretoraService>(Lifestyle.Scoped);
            container.Register<IOperadoraService, OperadoraService>(Lifestyle.Scoped);
            container.Register<IEntidadeService, EntidadeService>(Lifestyle.Scoped);



            //UoC
            container.Register<IUnitOfWork, UnitOfWOrk>(Lifestyle.Scoped);
            //Context
            container.Register<ProtectosContext>(Lifestyle.Scoped);

        }
    }
}
