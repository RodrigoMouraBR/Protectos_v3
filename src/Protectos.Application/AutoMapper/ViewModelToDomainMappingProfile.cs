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
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<BeneficiarioViewModel, Beneficiario>();
            CreateMap<BeneficiarioEnderecoViewModel, BeneficiarioEndereco>();
            CreateMap<BeneficiarioEmailViewModel, BeneficiarioEmail>();
            CreateMap<BeneficiarioTelefoneViewModel, BeneficiarioTelefone>();

            CreateMap<OperadoraViewModel, Operadora>();
            CreateMap<OperadoraEnderecoViewModel, OperadoraEndereco>();
            CreateMap<OperadoraEmailViewModel, OperadoraEmail>();
            CreateMap<OperadoraTelefoneViewModel, OperadoraTelefone>();

            CreateMap<CorretoraViewModel, Corretora>();
            CreateMap<CorretoraEnderecoViewModel, CorretoraEndereco>();
            CreateMap<CorretoraEmailViewModel, CorretoraEmail>();
            CreateMap<CorretoraTelefoneViewModel, CorretoraTelefone>();

            CreateMap<AdministradoraViewModel, Administradora>();
            CreateMap<AdministradoraEnderecoViewModel, AdministradoraEndereco>();
            CreateMap<AdministradoraEmailViewModel, AdministradoraEmail>();
            CreateMap<AdministradoraTelefoneViewModel, AdministradoraTelefone>();
        }
    }
}