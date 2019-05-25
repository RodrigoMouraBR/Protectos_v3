using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Protectos.Application.ViewModels.Propostas
{
    public class PropostaViewModel
    {
        public PropostaViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [ScaffoldColumn(false)]
        public Guid CadastradoPor { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get; set; }
        [ScaffoldColumn(false)]
        public string AlteradoPor { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Numero Proposta")]
        public string NumeroProposta { get; set; }
        [ScaffoldColumn(false)]
        public Guid PropostaPai { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data Vigência")]
        public DateTime DataVigencia { get; set; }
        [ScaffoldColumn(false)]
        public Guid BeneficiarioId { get; set; }
        [ScaffoldColumn(false)]
        public Guid EntidadeId { get; set; }
        [ScaffoldColumn(false)]
        public Guid CorretorId { get; set; }
        public Guid TipoVencimentoReferenciaId { get; set; }
        [ScaffoldColumn(false)]
        public Guid BancoId { get; set; }
        [ScaffoldColumn(false)]
        public Guid MotivoExclusaoId { get; set; }
        [ScaffoldColumn(false)]
        public Guid PessoaIdPagadora { get; set; }
        [ScaffoldColumn(false)]
        public Guid ClienteIdPagadora { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string FormaPagamento { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public int DiaVencimentoReferencia { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Numero Agencia ")]
        public string NumeroAgenciaBanco { get; set; }
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("DV Agencia ")]
        public string DigitoAgenciaBanco { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Numero Conta Corrente ")]
        public string NumeroContaCorrente { get; set; }
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("DV Agencia ")]
        public string NumeroDigitoContaCorrente { get; set; }
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("CPF do pagador ")]
        public string CPFPagador { get; set; }
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("CNPJ do pagador ")]
        public string CNPJPagador { get; set; }
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Taxa Alvo Inválido; Máximo Dois Pontos Decimais.")]
        [DisplayName("Taxa de juros")]
        public Decimal TaxaJuros { get; set; }
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Taxa Alvo Inválido; Máximo Dois Pontos Decimais.")]
        [DisplayName("Taxa de Multa")]
        public Decimal TaxaMulta { get; set; }
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Taxa Alvo Inválido; Máximo Dois Pontos Decimais.")]
        [DisplayName("Taxa Bancaria")]
        public Decimal TaxaBancaria { get; set; }
    }
}
