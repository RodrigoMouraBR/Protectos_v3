using System;
namespace Protectos.Application.ViewModels.Operadoras
{
    public class OperadoraEmailViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string TipoEmail { get; set; }
        public Guid OperadoraId { get; set; }
        public virtual OperadoraViewModel Operadora { get; set; }
    }
}