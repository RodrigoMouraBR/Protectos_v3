using System;

namespace Protectos.Domain.ValuesObjects
{
    public class Empresa
    {
        public Empresa(string razaoSocial, string nomeFantasia, CNPJ cnpj, 
                       string inscricaoEstadual, string inscricaoMunicipal, string site, DateTime dataCadastro)

        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
            InscricaoMunicipal = inscricaoMunicipal;
            Site = site;
            DataCadastro = dataCadastro;
        }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public CNPJ Cnpj { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string InscricaoMunicipal { get; private set; }
        public string Site { get; private set; }
        public DateTime DataCadastro { get; set; }
    }
}