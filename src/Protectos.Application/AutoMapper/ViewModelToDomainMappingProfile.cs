using AutoMapper;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Application.ViewModels.Beneficiarios;
using Protectos.Application.ViewModels.Corretoras;
using Protectos.Application.ViewModels.Entidades;
using Protectos.Application.ViewModels.Faturas;
using Protectos.Application.ViewModels.Operadoras;
using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Faturas;
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
            CreateMap<OperadoraCadastroViewModel, Operadora>();
            CreateMap<OperadoraCadastroViewModel, OperadoraEndereco>();
            CreateMap<OperadoraCadastroViewModel, OperadoraEmail>();
            CreateMap<OperadoraCadastroViewModel, OperadoraTelefone>();

            CreateMap<CorretoraViewModel, Corretora>();
            CreateMap<CorretoraEnderecoViewModel, CorretoraEndereco>();
            CreateMap<CorretoraEmailViewModel, CorretoraEmail>();
            CreateMap<CorretoraTelefoneViewModel, CorretoraTelefone>();
            CreateMap<CorretoraCadastroViewModel, Corretora>();
            CreateMap<CorretoraCadastroViewModel, CorretoraEndereco>();
            CreateMap<CorretoraCadastroViewModel, CorretoraEmail>();
            CreateMap<CorretoraCadastroViewModel, CorretoraTelefone>();

            CreateMap<AdministradoraViewModel, Administradora>();
            CreateMap<AdministradoraEnderecoViewModel, AdministradoraEndereco>();
            CreateMap<AdministradoraEmailViewModel, AdministradoraEmail>();
            CreateMap<AdministradoraTelefoneViewModel, AdministradoraTelefone>();
            CreateMap<AdministradoraCadastroViewModel, Administradora>();
            CreateMap<AdministradoraCadastroViewModel, AdministradoraEndereco>();
            CreateMap<AdministradoraCadastroViewModel, AdministradoraEmail>();
            CreateMap<AdministradoraCadastroViewModel, AdministradoraTelefone>();

            CreateMap<EntidadeViewModel, Entidade>();
            CreateMap<EntidadeEnderecoViewModel, EntidadeEndereco>();
            CreateMap<EntidadeEmailViewModel, EntidadeEmail>();
            CreateMap<EntidadeTelefoneViewModel, EntidadeTelefone>();
            CreateMap<EntidadeCadastroViewModel, Entidade>();
            CreateMap<EntidadeCadastroViewModel, EntidadeEndereco>();
            CreateMap<EntidadeCadastroViewModel, EntidadeEmail>();
            CreateMap<EntidadeCadastroViewModel, EntidadeTelefone>();

            CreateMap<FaturaViewModel, Fatura>();
            
        }
    }
}