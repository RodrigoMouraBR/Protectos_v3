using Protectos.Domain.DTO;
using System;
namespace Protectos.Domain.Generics.Interfaces.Services
{
    public interface IViaCepExternalService
    {
        ViaCep ConsultarCEP(string cep);
    }
}
