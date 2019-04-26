using System;
using System.Collections.Generic;
namespace Protectos.Application.ViewModels.Beneficiarios
{
    public class BeneficiarioViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public string RG { get; set; }
        public string OrgaoEmissor { get; set; }
        public string EstadoCivil { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<BeneficiarioEnderecoViewModel> BeneficiarioEndereco { get; set; }
        public virtual IEnumerable<BeneficiarioTelefoneViewModel> BeneficiarioTelefone { get; set; }
        public virtual IEnumerable<BeneficiarioEmailViewModel> BeneficiarioEmail { get; set; }
        public virtual IEnumerable<BeneficiarioDependenteViewModel> BeneficiarioDependente { get; set; }
    }
}
