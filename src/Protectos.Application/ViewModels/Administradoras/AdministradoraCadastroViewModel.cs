using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Administradoras
{
    public class AdministradoraCadastroViewModel
    {
        public AdministradoraViewModel Administradora { get; set; }
        public AdministradoraEnderecoViewModel Endereco { get; set; }
        //public AdministradoraEmailViewModel Email { get; set; }
        //public AdministradoraTelefoneViewModel Telefones { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }

        //public AdministradoraCadastroViewModel()
        //{
        //    AdministradoraId = Guid.NewGuid();
        //    EnderecoId = Guid.NewGuid();
        //}

        //[Key]
        //public Guid AdministradoraId { get; set; }
        //[Required(ErrorMessage = "Preencha o campo Nome")]
        //[MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string RazaoSocial { get; set; }
        //[Required(ErrorMessage = "Preencha o campo Nome")]
        //[MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string NomeFantasia { get; set; }
        //[Required(ErrorMessage = "Preencha o campo CPF")]
        //[MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        //[DisplayName("CNPJ")]
        //public string Cnpj { get; set; }
        //[DisplayName("Inscricao Estadual")]
        //public string InscricaoEstadual { get; set; }
        //[DisplayName("Inscricao Estadual")]
        //public string InscricaoMunicipal { get; set; }
        //public string Site { get; set; }
        //[ScaffoldColumn(false)]
        //public bool Ativo { get; set; }
        //[ScaffoldColumn(false)]
        //public DateTime DataCadastro { get; set; }       

        //[ScaffoldColumn(false)]
        //public FluentValidation.Results.ValidationResult ValidationResult { get; set; }


        //[Key]
        //public Guid EnderecoId { get; set; }
        //[Required(ErrorMessage = "Preencha o campo Logradouro")]
        //[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string Logradouro { get; set; }//
        //[Required(ErrorMessage = "Preencha o campo Numero")]
        //[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string Numero { get; set; }//
        //[Required(ErrorMessage = "Preencha o campo Bairro")]
        //[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string Bairro { get; set; }//
        //[Required(ErrorMessage = "Preencha o campo CEP")]
        //[MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        //public string Cep { get; set; }//
        //[MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string Complemento { get; set; }
        //[Required(ErrorMessage = "Preencha o campo Cidade")]
        //[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string Cidade { get; set; }
        //[Required(ErrorMessage = "Preencha o campo Estado")]
        //[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string Estado { get; set; }
        //[Required(ErrorMessage = "Preencha o campo UF")]
        //[MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string UF { get; set; }
        //[Required(ErrorMessage = "Preencha o campo País")]
        //[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        //public string Pais { get; set; }      
    }
}
