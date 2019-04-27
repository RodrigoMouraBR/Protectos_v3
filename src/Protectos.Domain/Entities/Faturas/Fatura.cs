using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Domain.Entities.Faturas
{
    public class Fatura : Entity<Fatura>
    {
        public string NomeFatura { get; private set; }
        public string NumeroFatura { get; private set; }
        public int MesReajuste { get; private set; }
        public int Vigencia { get; private set; }
        public int VencimentoBoleto { get; private set; }
        public int VencimentoDBA { get; private set; }
        public int PermiteCobrancaDobrada { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public decimal TaxaMulta { get; private set; }
        public decimal TaxaBancaria { get; private set; }
        public EStatus Status { get; private set; }






        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
