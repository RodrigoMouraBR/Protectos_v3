using AutoMapper;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Application.ViewModels.Beneficiarios;
using Protectos.Application.ViewModels.Corretoras;
using Protectos.Application.ViewModels.Operadoras;
using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Operadoras;

namespace Protectos.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Beneficiario, BeneficiarioViewModel>();
            CreateMap<BeneficiarioEndereco, BeneficiarioEnderecoViewModel>();
            CreateMap<BeneficiarioEmail, BeneficiarioEmailViewModel>();
            CreateMap<BeneficiarioTelefone, BeneficiarioTelefoneViewModel>();

            CreateMap<Operadora, OperadoraViewModel>();
            CreateMap<OperadoraEndereco, OperadoraEnderecoViewModel>();
            CreateMap<OperadoraEmail, OperadoraEmailViewModel>();
            CreateMap<OperadoraTelefone, OperadoraTelefoneViewModel>();

            CreateMap<Corretora, CorretoraViewModel>();
            CreateMap<CorretoraEndereco, CorretoraEnderecoViewModel>();
            CreateMap<CorretoraEmail, CorretoraEmailViewModel>();
            CreateMap<CorretoraTelefone, CorretoraTelefoneViewModel>();

            CreateMap<Administradora, AdministradoraViewModel>();
            CreateMap<AdministradoraEndereco, AdministradoraEnderecoViewModel>();
            CreateMap<AdministradoraEmail, AdministradoraEmailViewModel>();
            CreateMap<AdministradoraTelefone, AdministradoraTelefoneViewModel>();
        }
    }
}