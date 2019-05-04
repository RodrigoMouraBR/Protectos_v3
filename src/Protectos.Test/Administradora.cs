using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Protectos.Application.Interfaces.Administradoras;
using Protectos.Application.ViewModels.Administradoras;


namespace Protectos.Test
{
    [TestClass]
    public class Administradora
    {
        private readonly IAdministradoraApplicationService _administradoraApplicationService;


        public Administradora(IAdministradoraApplicationService administradoraApplicationService)
        {
            _administradoraApplicationService = administradoraApplicationService;
        }


        [TestMethod]
        public void AdicionarAdministradoraValidaTest()
        {

            var administradora = new AdministradoraViewModel
            {
                Cnpj = "20138220000193",
                RazaoSocial = "POTENCIAL ADMINSTRADORA DE BENEFICIOS LTDA",
                NomeFantasia = "POTENCIAL",
                InscricaoEstadual = "274764511950",
                InscricaoMunicipal = "",
                Site="http://www.potencial.com.br"
            };


           Guid guid = _administradoraApplicationService.AdministradoraAdicionar(administradora).Id;
            
            bool valido = !string.IsNullOrEmpty(guid.ToString()) ? true : false ;
            Assert.IsTrue(valido);

        }

        [TestMethod]
        public void AdicionarEndercoAdministradoraValidaTest()
        {
            var enderecoAdministradora = new AdministradoraEnderecoViewModel
            {
                Id = _administradoraApplicationService.AdministradoraObterPorCpf("20138220000193").Id,
                Logradouro = "Av. Paulista, 1890",
                Cidade = "São Paulo",
                Estado = "SP",
                Cep = "01000-000",
                Pais="Brasil"
            };

            Guid guid = _administradoraApplicationService.AdministradoraEnderecoAdicionar(enderecoAdministradora).Id;            
            bool valido = !string.IsNullOrEmpty(guid.ToString()) ? true : false;

            Assert.IsTrue(valido);

        }

        [TestMethod]
        public void AdicionarTelefoneAdministradoraValidaTest()
        {
            var telefoneAdministradora = new AdministradoraTelefoneViewModel
            {
                Id = _administradoraApplicationService.AdministradoraObterPorCpf("20138220000193").Id,
                Numero = "2222-7777",
                Prefixo="11",
                TipoTelefone="P"
            };

            Guid guid = _administradoraApplicationService.AdministradoraTelefoneAdicionar(telefoneAdministradora).Id;
            bool valido = !string.IsNullOrEmpty(guid.ToString()) ? true : false;

            Assert.IsTrue(valido);

        }
    }
}
