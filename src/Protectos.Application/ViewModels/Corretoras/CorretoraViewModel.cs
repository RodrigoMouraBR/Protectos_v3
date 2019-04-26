using System;
using System.Collections.Generic;
namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraViewModel
    {
        public Guid Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Site { get; set; }
        public virtual IEnumerable<CorretoraEnderecoViewModel> Enderecos { get; set; }
        public virtual IEnumerable<CorretoraTelefoneViewModel> Telefones { get; set; }
        public virtual IEnumerable<CorretoraEmailViewModel> Emails { get; set; }
    }
}
