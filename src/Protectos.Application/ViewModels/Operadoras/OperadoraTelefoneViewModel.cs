using System;
namespace Protectos.Application.ViewModels.Operadoras
{
    public class OperadoraTelefoneViewModel
    {
        public Guid Id { get; set; }
        public string Prefixo { get; set; }
        public string Numero { get; set; }
        public string TipoTelefone { get; set; }
        public Guid OperadoraId { get; set; }
        public virtual OperadoraViewModel Operadora { get; set; }
    }
}