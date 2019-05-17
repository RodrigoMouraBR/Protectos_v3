using System;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Beneficiarios
{
    public class BeneficiarioDependenteViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Sexo { get; private set; }
        public string Cpf { get; private set; }
        public string RG { get; private set; }
        public string OrgaoEmissor { get; private set; }
        public string EstadoCivil { get; private set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; private set; }
        public Guid BeneficiarioId { get; private set; }
        public string BeneficiarioParentesco { get; private set; }
        [ScaffoldColumn(false)]
        public Guid CadastradoPor { get; protected set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get; protected set; }
        [ScaffoldColumn(false)]
        public Guid AlteradoPor { get; protected set; }
        public virtual BeneficiarioViewModel Beneficiario { get; private set; }
    }
}