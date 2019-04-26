using System;

namespace Protectos.Application.ViewModels.Beneficiarios
{
    public class BeneficiarioEmailViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public Guid BeneficiarioId { get; set; }
        public string TipoEmail { get; set; }
        public virtual BeneficiarioViewModel Beneficiario { get; set; }
    }
}