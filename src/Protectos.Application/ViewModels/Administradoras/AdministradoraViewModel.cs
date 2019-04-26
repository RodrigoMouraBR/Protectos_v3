using System;
using System.Collections.Generic;
namespace Protectos.Application.ViewModels.Administradoras
{
    public class AdministradoraViewModel
    {
        public Guid Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Site { get; set; }
        public virtual IEnumerable<AdministradoraEnderecoViewModel> Enderecos { get; set; }
        public virtual IEnumerable<AdministradoraTelefoneViewModel> Telefones { get; set; }
        public virtual IEnumerable<AdministradoraEmailViewModel> Emails { get; set; }
    }
}
