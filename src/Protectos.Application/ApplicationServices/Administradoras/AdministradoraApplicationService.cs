using AutoMapper;
using Protectos.Application.Interfaces.Administradoras;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Administradoras.Interfaces.Services;
using Protectos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web;

namespace Protectos.Application.ApplicationServices.Administradoras
{
    public class AdministradoraApplicationService : ApplicationService, IAdministradoraApplicationService
    {
        private readonly IAdministradoraRepository _administradoraRepository;
        private readonly IAdministradoraEmailRepository _administradoraEmailRepository;
        private readonly IAdministradoraTelefoneRepository _administradoraTelefoneRepository;
        private readonly IAdministradoraEnderecoRepository _administradoraEndrecoRepository;
        private readonly IAdministradoraService _administradoraService;
        public AdministradoraApplicationService(IAdministradoraRepository administradoraRepository,
                                                IAdministradoraEmailRepository administradoraEmailRepository,
                                                IAdministradoraTelefoneRepository administradoraTelefoneRepository,
                                                IAdministradoraEnderecoRepository administradoraEndrecoRepository,
                                                IAdministradoraService administradoraService,
                                                IUnitOfWork uow) : base(uow)
        {
            _administradoraRepository = administradoraRepository;
            _administradoraEmailRepository = administradoraEmailRepository;
            _administradoraTelefoneRepository = administradoraTelefoneRepository;
            _administradoraEndrecoRepository = administradoraEndrecoRepository;
            _administradoraService = administradoraService;
        }

        // AdministradoraServices
        public AdministradoraViewModel AdministradoraAdicionar(AdministradoraViewModel administradoraViewModel)
        {
            var administradora = Mapper.Map<Administradora>(administradoraViewModel);
            BeginTransaction();
            var administradoraReturn = _administradoraService.AdministradoraAdicionar(administradora);
            if (!administradoraReturn.ValidationResult.IsValid)
            {
                return administradoraViewModel;
            }
            Commit();
            return administradoraViewModel;
        }
        public AdministradoraViewModel AdministradoraAtualizar(AdministradoraViewModel administradoraViewModel)
        {
            var administradora = Mapper.Map<Administradora>(administradoraViewModel);
            _administradoraService.AdministradoraAtualizar(administradora);
            Commit();
            return administradoraViewModel;
        }
        public void DeleteAdministradora(Guid id)
        {
            _administradoraService.DeleteAdministradora(id);
            Commit();
        }
        public AdministradoraEmailViewModel AdministradoraEmailAdicionar(AdministradoraEmailViewModel administradoraEmailViewModel)
        {
            var administradoraEmail = Mapper.Map<AdministradoraEmail>(administradoraEmailViewModel);
            _administradoraService.AdministradoraEmailAdicionar(administradoraEmail);
            Commit();
            return administradoraEmailViewModel;
        }
        public AdministradoraEmailViewModel AdministradoraEmailAtualizar(AdministradoraEmailViewModel administradoraEmailViewModel)
        {
            var administradoraEmail = Mapper.Map<AdministradoraEmail>(administradoraEmailViewModel);
            _administradoraService.AdministradoraEmailAtualizar(administradoraEmail);
            Commit();
            return administradoraEmailViewModel;
        }
        public void DeleteAdministradoraEmail(Guid id)
        {
            _administradoraService.DeleteAdministradoraEmail(id);
            Commit();
        }
        public AdministradoraEnderecoViewModel AdministradoraEnderecoAdicionar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel)
        {
            var administradoraEndereco = Mapper.Map<AdministradoraEndereco>(administradoraEnderecoViewModel);
            _administradoraService.AdministradoraEnderecoAdicionar(administradoraEndereco);
            Commit();
            return administradoraEnderecoViewModel;

        }
        public AdministradoraEnderecoViewModel AdministradoraEnderecoAtualizar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel)
        {
            var administradoraEndereco = Mapper.Map<AdministradoraEndereco>(administradoraEnderecoViewModel);
            _administradoraService.AdministradoraEnderecoAtualizar(administradoraEndereco);
            Commit();
            return administradoraEnderecoViewModel;
        }
        public void DeleteAdministradoraEndereco(Guid id)
        {
            _administradoraService.DeleteAdministradoraEndereco(id);
            Commit();
        }
        public AdministradoraTelefoneViewModel AdministradoraTelefoneAdicionar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel)
        {
            var administradoraTelefone = Mapper.Map<AdministradoraTelefone>(administradoraTelefoneViewModel);
            _administradoraService.AdministradoraTelefoneAdicionar(administradoraTelefone);
            Commit();
            return administradoraTelefoneViewModel;
        }
        public AdministradoraTelefoneViewModel AdministradoraTelefoneAtualizar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel)
        {
            var administradoraTelefone = Mapper.Map<AdministradoraTelefone>(administradoraTelefoneViewModel);
            _administradoraService.AdministradoraTelefoneAtualizar(administradoraTelefone);
            Commit();
            return administradoraTelefoneViewModel;
        }
        public void DeleteAdministradoraTelefone(Guid id)
        {
            _administradoraService.DeleteAdministradoraTelefone(id);
            Commit();
        }
        //AdministradoraRepositories
        public IEnumerable<AdministradoraEnderecoViewModel> AdministradoraEnderecoObterTodos()
        {
            return Mapper.Map<IEnumerable<AdministradoraEnderecoViewModel>>(_administradoraEndrecoRepository.GetAll());
        }
        public IEnumerable<AdministradoraTelefoneViewModel> AdministradoraTelefoneObterTodos()
        {
            return Mapper.Map<IEnumerable<AdministradoraTelefoneViewModel>>(_administradoraTelefoneRepository.GetAll());
        }
        public IEnumerable<AdministradoraEmailViewModel> AdministradoraEmailObterTodos()
        {
            return Mapper.Map<IEnumerable<AdministradoraEmailViewModel>>(_administradoraEmailRepository.GetAll());
        }
        public IEnumerable<AdministradoraViewModel> AdministradoraObterTodos()
        {
            return Mapper.Map<IEnumerable<AdministradoraViewModel>>(_administradoraRepository.GetAll());
        }
        public IEnumerable<AdministradoraViewModel> AdministradoraObterAtivo()
        {
            return Mapper.Map<IEnumerable<AdministradoraViewModel>>(_administradoraRepository.AdministradoraObterAtivo());
        }
        public IEnumerable<AdministradoraViewModel> AdministradoraObterInativo()
        {
            return Mapper.Map<IEnumerable<AdministradoraViewModel>>(_administradoraRepository.AdministradoraObterInativo());
        }
        public AdministradoraViewModel AdministradoraObterPorCnpj(string cnpj)
        {
            return Mapper.Map<AdministradoraViewModel>(_administradoraRepository.AdministradoraObterPorCnpj(cnpj));
        }
        public AdministradoraViewModel AdministradoraObterPorId(Guid id)
        {
            return Mapper.Map<AdministradoraViewModel>(_administradoraRepository.GetbyId(id));
        }
        public void Dispose()
        {
            _administradoraRepository.Dispose();
            _administradoraEmailRepository.Dispose();
            _administradoraTelefoneRepository.Dispose();
            _administradoraEndrecoRepository.Dispose();
            _administradoraService.Dispose();
        }
        public AdministradoraEnderecoViewModel AdministradoraEnderecoObterPorId(Guid id)
        {
            return Mapper.Map<AdministradoraEnderecoViewModel>(_administradoraEndrecoRepository.GetbyId(id));
        }
        public AdministradoraEmailViewModel AdministradoraEmailObterPorId(Guid id)
        {
            return Mapper.Map<AdministradoraEmailViewModel>(_administradoraEmailRepository.GetbyId(id));
        }
        public AdministradoraTelefoneViewModel AdministradoraTelefoneObterPorId(Guid id)
        {
            return Mapper.Map<AdministradoraTelefoneViewModel>(_administradoraTelefoneRepository.GetbyId(id));
        }
        public AdministradoraCadastroViewModel AdministradoraCadastroAdicionar(AdministradoraCadastroViewModel administradoraCadastroViewModel)
        {
            _administradoraService.ConsultaraServicoViaCEP("07263000");

            var administradora = Mapper.Map<Administradora>(administradoraCadastroViewModel.Administradora);
            var endereco = Mapper.Map<AdministradoraEndereco>(administradoraCadastroViewModel.Endereco);
            #region
            //var telefone = Mapper.Map<AdministradoraTelefone>(administradoraCadastroViewModel);
            //var email = Mapper.Map<AdministradoraEmail>(administradoraCadastroViewModel);
            #endregion
            administradora.Enderecos.Add(endereco);
            var foto = administradoraCadastroViewModel.Foto;
            #region

            //administradora.Telefones.Add(telefone);
            //administradora.Emails.Add(email);
            #endregion
            BeginTransaction();
            var administradoraReturn = _administradoraService.AdministradoraAdicionar(administradora);
            administradoraCadastroViewModel = Mapper.Map<AdministradoraCadastroViewModel>(administradoraReturn);
            if (!administradoraReturn.ValidationResult.IsValid)
            {
                return administradoraCadastroViewModel;
            }
            if (! SalvarImagem(foto, administradora.Id))
            {
                // Tomada de decisão caso a imagem não seja gravada.              
            }
            Commit();
            return administradoraCadastroViewModel;
        }
        private static bool SalvarImagem(HttpPostedFileBase img, Guid id)
        {
            if (img == null || img.ContentLength <= 0) return false;
            string directory = ConfigurationManager.AppSettings["Imagens"];
            var fileName = id + Path.GetExtension(img.FileName);
            img.SaveAs(Path.Combine(directory, fileName));
            return File.Exists(Path.Combine(directory, fileName));
        }
    }
}
