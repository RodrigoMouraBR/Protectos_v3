using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Beneficiarios;
using System;
namespace Protectos.Domain.Entities.Clientes
{
    public class ClienteBeneficiario : Entity<ClienteBeneficiario>
    {
        public ClienteBeneficiario(Guid clienteId, Guid beneficiarioId)
        {
            ClienteId = clienteId;
            BeneficiarioId = beneficiarioId;
        }
        protected ClienteBeneficiario()
        {
        }
        public Guid ClienteId { get; private set; }
        public Guid BeneficiarioId { get; private set; }
        public virtual Beneficiario Beneficiario { get; private set; }
        public virtual Cliente Cliente { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
