using System;

namespace Protectos.Application.ViewModels.Beneficiarios
{
    public class BeneficiarioEnderecoViewModel
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
        public Guid BeneficiarioId { get;  set; }
        public virtual BeneficiarioViewModel Beneficiario { get; set; }
    }
}