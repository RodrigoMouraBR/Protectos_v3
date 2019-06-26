using AutoMapper;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Application.ViewModels.Beneficiarios;
using Protectos.Application.ViewModels.Clientes;
using Protectos.Application.ViewModels.Corretoras;
using Protectos.Application.ViewModels.Entidades;
using Protectos.Application.ViewModels.Faturas;
using Protectos.Application.ViewModels.Operadoras;
using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Clientes;
using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Operadoras;

namespace Protectos.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Beneficiario, BeneficiarioViewModel>();
            CreateMap<BeneficiarioEndereco, BeneficiarioEnderecoViewModel>().ForMember(dest => dest.EnderecoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<BeneficiarioEmail, BeneficiarioEmailViewModel>()
                .ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoEmail, opt => opt.MapFrom(src => src.TipoEmail));
            CreateMap<BeneficiarioTelefone, BeneficiarioTelefoneViewModel>()
                .ForMember(dest => dest.TelefoneId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoTelefone, opt => opt.MapFrom(src => src.TipoTelefone));
            CreateMap<Administradora, AdministradoraViewModel>();
            CreateMap<AdministradoraEndereco, AdministradoraEnderecoViewModel>().ForMember(dest => dest.EnderecoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<AdministradoraEmail, AdministradoraEmailViewModel>()
                .ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoEmail, opt => opt.MapFrom(src => src.TipoEmail));
            CreateMap<AdministradoraTelefone, AdministradoraTelefoneViewModel>()
                .ForMember(dest => dest.TelefoneId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoTelefone, opt => opt.MapFrom(src => src.TipoTelefone));
            CreateMap<Administradora, AdministradoraCadastroViewModel>();
            CreateMap<AdministradoraEndereco, AdministradoraCadastroViewModel>();
            CreateMap<AdministradoraEmail, AdministradoraCadastroViewModel>();
            CreateMap<AdministradoraTelefone, AdministradoraCadastroViewModel>();
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<ClienteEndereco, ClienteEnderecoViewModel>().ForMember(dest => dest.EnderecoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<ClienteEmail, ClienteEmailViewModel>()
                .ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoEmail, opt => opt.MapFrom(src => src.TipoEmail));
            CreateMap<ClienteTelefone, ClienteTelefoneViewModel>()
                .ForMember(dest => dest.TelefoneId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoTelefone, opt => opt.MapFrom(src => src.TipoTelefone));
            CreateMap<Cliente, ClienteCadastroViewModel>();
            CreateMap<ClienteEndereco, ClienteCadastroViewModel>();
            CreateMap<ClienteEmail, ClienteCadastroViewModel>();
            CreateMap<ClienteTelefone, ClienteCadastroViewModel>();

            CreateMap<Corretora, CorretoraViewModel>();
            CreateMap<CorretoraEndereco, CorretoraEnderecoViewModel>().ForMember(dest => dest.EnderecoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<CorretoraEmail, CorretoraEmailViewModel>()
                .ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoEmail, opt => opt.MapFrom(src => src.TipoEmail));
            CreateMap<CorretoraTelefone, CorretoraTelefoneViewModel>()
                .ForMember(dest => dest.TelefoneId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoTelefone, opt => opt.MapFrom(src => src.TipoTelefone));
            CreateMap<Corretora, CorretoraCadastroViewModel>();
            CreateMap<CorretoraEndereco, CorretoraCadastroViewModel>();
            CreateMap<CorretoraEmail, CorretoraCadastroViewModel>();
            CreateMap<CorretoraTelefone, CorretoraCadastroViewModel>();

            CreateMap<Entidade, EntidadeViewModel>();
            CreateMap<EntidadeEndereco, EntidadeEnderecoViewModel>().ForMember(dest => dest.EnderecoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<EntidadeEmail, EntidadeEmailViewModel>()
                .ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoEmail, opt => opt.MapFrom(src => src.TipoEmail));
            CreateMap<EntidadeTelefone, EntidadeTelefoneViewModel>()
                .ForMember(dest => dest.TelefoneId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoTelefone, opt => opt.MapFrom(src => src.TipoTelefone));
            CreateMap<Entidade, EntidadeCadastroViewModel>();
            CreateMap<EntidadeEndereco, EntidadeCadastroViewModel>();
            CreateMap<EntidadeEmail, EntidadeCadastroViewModel>();
            CreateMap<EntidadeTelefone, EntidadeCadastroViewModel>();

            CreateMap<Operadora, OperadoraViewModel>();
            CreateMap<OperadoraEndereco, OperadoraEnderecoViewModel>().ForMember(dest => dest.EnderecoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<OperadoraEmail, OperadoraEmailViewModel>()
                .ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoEmail, opt => opt.MapFrom(src => src.TipoEmail));
            CreateMap<OperadoraTelefone, OperadoraTelefoneViewModel>()
                .ForMember(dest => dest.TelefoneId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoTelefone, opt => opt.MapFrom(src => src.TipoTelefone));
            CreateMap<Operadora, OperadoraCadastroViewModel>();
            CreateMap<OperadoraEndereco, OperadoraCadastroViewModel>();
            CreateMap<OperadoraEmail, OperadoraCadastroViewModel>();
            CreateMap<OperadoraTelefone, OperadoraCadastroViewModel>();

            CreateMap<Fatura, FaturaViewModel>();
        }
    }
}