using AutoMapper;
using Protectos.Application.Interfaces.Corretoras;
using Protectos.Application.ViewModels.Corretoras;
using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Corretoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Corretoras.Interfaces.Services;
using Protectos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web;

namespace Protectos.Application.ApplicationServices.Corretoras
{
    public class CorretoraApplicationService : ApplicationService, ICorretoraApplicationService
    {
        private readonly ICorretoraRepository _corretoraRepository;
        private readonly ICorretoraEmailRepository _corretoraEmailRepository;
        private readonly ICorretoraTelefoneRepository _corretoraTelefoneRepository;
        private readonly ICorretoraEnderecoRepository _corretoraEndrecoRepository;
        private readonly ICorretoraService _corretoraService;
        public CorretoraApplicationService(ICorretoraRepository corretoraRepository, 
            ICorretoraEmailRepository corretoraEmailRepository, 
            ICorretoraTelefoneRepository corretoraTelefoneRepository, 
            ICorretoraEnderecoRepository corretoraEndrecoRepository, 
            ICorretoraService corretoraService, IUnitOfWork uow) : base(uow)
        {
            _corretoraRepository = corretoraRepository;
            _corretoraEmailRepository = corretoraEmailRepository;
            _corretoraTelefoneRepository = corretoraTelefoneRepository;
            _corretoraEndrecoRepository = corretoraEndrecoRepository;
            _corretoraService = corretoraService;
        }

        public CorretoraCadastroViewModel CorretoraCadastroAdicionar(CorretoraCadastroViewModel corretoraCadastroViewModel)
        {
            //_corretoraService.ConsultaraServicoViaCEP("07263000");

            var corretora = Mapper.Map<Corretora>(corretoraCadastroViewModel.Corretora);
            var endereco = Mapper.Map<CorretoraEndereco>(corretoraCadastroViewModel.Endereco);
            var email = Mapper.Map<CorretoraEmail>(corretoraCadastroViewModel.Email);
            #region
            //var telefone = Mapper.Map<AdministradoraTelefone>(administradoraCadastroViewModel);

            #endregion
            corretora.Enderecos.Add(endereco);
            corretora.Emails.Add(email);


            var foto = corretoraCadastroViewModel.Foto;
            #region

       
            #endregion
            BeginTransaction();
            var corretoraReturn = _corretoraService.CorretoraAdicionar(corretora);
            corretoraCadastroViewModel = Mapper.Map<CorretoraCadastroViewModel>(corretoraReturn);
            if (!corretoraReturn.ValidationResult.IsValid)
            {
                return corretoraCadastroViewModel;
            }
            if (!SalvarImagem(foto, corretora.Id))
            {
                // Tomada de decisão caso a imagem não seja gravada.              
            }
            Commit();
            return corretoraCadastroViewModel;
        }






        public CorretoraViewModel CorretoraAtualizar(CorretoraViewModel corretoraViewModel)
        {
            var corretora = Mapper.Map<Corretora>(corretoraViewModel);
            _corretoraService.CorretoraAtualizar(corretora);
            Commit();
            return corretoraViewModel;
        }
        public CorretoraEmailViewModel CorretoraEmailAdicionar(CorretoraEmailViewModel corretoraEmailViewModel)
        {
            var corretora = Mapper.Map<CorretoraEmail>(corretoraEmailViewModel);
            _corretoraService.CorretoraEmailAdicionar(corretora);
            Commit();
            return corretoraEmailViewModel;
        }
        public CorretoraEmailViewModel CorretoraEmailAtualizar(CorretoraEmailViewModel corretoraEmailViewModel)
        {
            var corretora = Mapper.Map<CorretoraEmail>(corretoraEmailViewModel);
            _corretoraService.CorretoraEmailAtualizar(corretora);
            Commit();
            return corretoraEmailViewModel;
        }       
        public CorretoraEnderecoViewModel CorretoraEnderecoAdicionar(CorretoraEnderecoViewModel corretoraEnderecoViewModel)
        {
            var corretora = Mapper.Map<CorretoraEndereco>(corretoraEnderecoViewModel);
            _corretoraService.CorretoraEnderecoAdicionar(corretora);
            Commit();
            return corretoraEnderecoViewModel;
        }
        public CorretoraEnderecoViewModel CorretoraEnderecoAtualizar(CorretoraEnderecoViewModel corretoraEnderecoViewModel)
        {
            var corretora = Mapper.Map<CorretoraEndereco>(corretoraEnderecoViewModel);
            _corretoraService.CorretoraEnderecoAtualizar(corretora);
            Commit();
            return corretoraEnderecoViewModel;
        }
        public CorretoraTelefoneViewModel CorretoraTelefoneAdicionar(CorretoraTelefoneViewModel corretoraTelefoneViewModel)
        {
            var corretora = Mapper.Map<CorretoraTelefone>(corretoraTelefoneViewModel);
            _corretoraService.CorretoraTelefoneAdicionar(corretora);
            Commit();
            return corretoraTelefoneViewModel;
        }
        public CorretoraTelefoneViewModel CorretoraTelefoneAtualizar(CorretoraTelefoneViewModel corretoraTelefoneViewModel)
        {
            var corretora = Mapper.Map<CorretoraTelefone>(corretoraTelefoneViewModel);
            _corretoraService.CorretoraTelefoneAtualizar(corretora);
            Commit();
            return corretoraTelefoneViewModel;
        }
        public void DeleteCorretora(Guid id)
        {
            _corretoraService.DeleteCorretora(id);
        }
        public void DeleteCorretoraEmail(Guid id)
        {
            _corretoraService.DeleteCorretoraEmail(id);
        }
        public void DeleteCorretoraEndereco(Guid id)
        {
            _corretoraService.DeleteCorretoraEndereco(id);
        }
        public void DeleteCorretoraTelefone(Guid id)
        {
            _corretoraService.DeleteCorretoraTelefone(id);
        }
        public IEnumerable<CorretoraEmailViewModel> CorretoraEmailObterTodos()
        {
            return Mapper.Map<IEnumerable<CorretoraEmailViewModel>>(_corretoraEmailRepository.GetAll());
        }
        public IEnumerable<CorretoraEnderecoViewModel> CorretoraEnderecoObterTodos()
        {
            return Mapper.Map<IEnumerable<CorretoraEnderecoViewModel>>(_corretoraEndrecoRepository.GetAll());
        }
        public IEnumerable<CorretoraViewModel> CorretoraObterAtivo()
        {
            return Mapper.Map<IEnumerable<CorretoraViewModel>>(_corretoraRepository.CorretoraObterAtivo());
        }
        public IEnumerable<CorretoraViewModel> CorretoraObterInativo()
        {
            return Mapper.Map<IEnumerable<CorretoraViewModel>>(_corretoraRepository.CorretoraObterInativo());
        }
        public CorretoraViewModel CorretoraObterPorCnpj(string cnpj)
        {
            return Mapper.Map<CorretoraViewModel>(_corretoraRepository.CorretoraObterPorCnpj(cnpj));
        }
        public CorretoraViewModel CorretoraObterPorId(Guid id)
        {
            return Mapper.Map<CorretoraViewModel>(_corretoraRepository.GetbyId(id));
        }
        public IEnumerable<CorretoraViewModel> CorretoraObterTodos()
        {
            return Mapper.Map<IEnumerable<CorretoraViewModel>>(_corretoraRepository.GetAll());
        }  
        public IEnumerable<CorretoraTelefoneViewModel> CorretoraTelefoneObterTodos()
        {
            return Mapper.Map<IEnumerable<CorretoraTelefoneViewModel>>(_corretoraTelefoneRepository.GetAll());
        }
        public void Dispose()
        {
            _corretoraRepository.Dispose();
            _corretoraEmailRepository.Dispose();
            _corretoraTelefoneRepository.Dispose();
            _corretoraEndrecoRepository.Dispose();            
            _corretoraService.Dispose();
        }
        public CorretoraEnderecoViewModel CorretoraEnderecoObterPorId(Guid id)
        {
            return Mapper.Map<CorretoraEnderecoViewModel>(_corretoraEndrecoRepository.GetbyId(id));
        }
        public CorretoraEmailViewModel CorretoraEmailObterPorId(Guid id)
        {
            return Mapper.Map<CorretoraEmailViewModel>(_corretoraEmailRepository.GetbyId(id));
        }
        public CorretoraTelefoneViewModel CorretoraTelefoneObterPorId(Guid id)
        {
            return Mapper.Map<CorretoraTelefoneViewModel>(_corretoraTelefoneRepository.GetbyId(id));
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
