using System;
namespace Protectos.Application.ViewModels.Operadoras
{
    public class OperadoraEnderecoViewModel
    {
        public Guid Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public Guid OperadoraId { get; set; }
        public virtual OperadoraViewModel Operadora { get; set; }
    }
}