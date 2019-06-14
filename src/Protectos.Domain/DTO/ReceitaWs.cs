using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Domain.DTO
{
    public class ReceitaWs
    {
        public DateTime DataCadastro { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string Cnpj { get; set; }
        public string Tipo { get; set; }
        public string Abertura { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public ICollection<AtividadePrincipal> Atividade_principal { get; set; }
        public string Atividade_Principalcode { get; set; }
        public string Atividade_Principaltext { get; set; }
        public ICollection<AtividadeSecundaria> Atividades_secundarias { get; set; }
        public string Atividades_Secundariascode { get; set; }
        public string Atividades_Secundariastext { get; set; }
        public string Natureza_Juridica { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Efr { get; set; }
        public string Situacao { get; set; }
        public string Data_Situacao { get; set; }
        public string Motivo_Situacao { get; set; }
        public string Situacao_Especial { get; set; }
        public string Data_Situacao_Especial { get; set; }
        public string Capital_Social { get; set; }
        //public ICollection<Qsa> Qsa { get; set; }
        public string QsaNome { get; set; }
        public string QsaQual { get; set; }
        public string QsaPais_Origem { get; set; }
        public string QsaNome_Rep_Legal { get; set; }
        public string QsaQual_Rep_Legal { get; set; }
    }
}
