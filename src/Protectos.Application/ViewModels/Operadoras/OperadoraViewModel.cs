using System;
using System.Collections.Generic;
namespace Protectos.Application.ViewModels.Operadoras
{
    public class OperadoraViewModel
    {
        public Guid Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Site { get; set; }
        public virtual IEnumerable<OperadoraEnderecoViewModel> Enderecos { get; set; }
        public virtual IEnumerable<OperadoraTelefoneViewModel> Telefones { get; set; }
        public virtual IEnumerable<OperadoraEmailViewModel> Emails { get; set; }
    }
}
