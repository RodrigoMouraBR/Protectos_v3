using Microsoft.VisualStudio.TestTools.UnitTesting;
using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.ValuesObjects;
using Rhino.Mocks;

namespace Protectos.Presentation.Test
{
    [TestClass]
    public class AdministradoraTest
    {

        [TestMethod]
        public void AdicionarAdministradoraValidaTest()
        {
            var empresa = new Empresa("POTENCIAL ADMINSTRADORA DE BENEFICIOS LTDA", "POTENCIAL", new CNPJ("20138220000193"), "274764511950", "", "http://www.potencial.com.br");
            var administradora = new Administradora(empresa);

            var repo = MockRepository.GenerateStub<IAdministradoraRepository>();
            repo.Stub(s => s.AdministradoraObterPorCpf("20138220000193")).Return(administradora);

            // Act
            var admReturn = repo.AdministradoraObterPorCpf("20138220000193");
            // Assert
            Assert.IsTrue(admReturn.IsValid());
        }


        [TestMethod]
        public void AdicionarAdministradoraValida2Test()
        {


            var empresa = new Empresa("POTENCIAL ADMINSTRADORA DE BENEFICIOS LTDA", "POTENCIAL", new CNPJ("20138220000193"), "274764511950", "", "http://www.potencial.com.br");
            var administradora = new Administradora(empresa);

            var repo = MockRepository.GenerateStub<IAdministradoraRepository>();
            repo.Stub(s => s.Add(administradora)).Return(administradora);

            // Act
            var admReturn = repo.AdministradoraObterPorCpf("20138220000193");
            // Assert
            Assert.IsTrue(admReturn.IsValid());
        }

    }
}
