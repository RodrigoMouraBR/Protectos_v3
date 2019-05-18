﻿using Protectos.Domain.Core.Models;
using System;

namespace Protectos.Domain.Entities.Cobrancas
{
    public class BancoAgencia : Entity<BancoAgencia>
    {
        public BancoAgencia(string codigoAgencia, 
                            string nomeAgenciaBanco, 
                            string logradouro, 
                            string complemento, 
                            string bairro, 
                            string cep, 
                            string cidade, 
                            string uF, 
                            string dDD, 
                            string fone, 
                            Guid bancoId)
        {
            CodigoAgencia = codigoAgencia;
            NomeAgenciaBanco = nomeAgenciaBanco;
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            UF = uF;
            DDD = dDD;
            Fone = fone;
            BancoId = bancoId;
        }
        protected BancoAgencia()
        {
        }
        public string CodigoAgencia { get; private set; }
        public string NomeAgenciaBanco { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string DDD { get; private set; }
        public string Fone { get; private set; }
        public Guid BancoId { get; private set; }
        public virtual Banco Banco { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
