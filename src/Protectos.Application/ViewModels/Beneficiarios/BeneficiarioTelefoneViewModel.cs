using System;

namespace Protectos.Application.ViewModels.Beneficiarios
{
    public class BeneficiarioTelefoneViewModel
    {
        public Guid Id { get; set; }
        public string Prefixo { get;  set; }
        public string Numero { get;  set; }
        public string TipoTelefone { get;  set; }
        public Guid BeneficiarioId { get; set; }
        public virtual BeneficiarioViewModel Beneficiario { get; set; }
    }
}