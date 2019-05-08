using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Entidades
{
    public class EntidadeViewModel
    {3
        public EntidadeViewModel()
        {
            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Site { get; set; }
        public virtual IEnumerable<EntidadeEnderecoViewModel> Enderecos { get; set; }
        public virtual IEnumerable<EntidadeTelefoneViewModel> Telefones { get; set; }
        public virtual IEnumerable<EntidadeEmailViewModel> Emails { get; set; }
    }
}
