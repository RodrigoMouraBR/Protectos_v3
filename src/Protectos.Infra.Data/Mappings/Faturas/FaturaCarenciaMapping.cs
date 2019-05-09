using Protectos.Domain.Entities.Faturas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Faturas
{
    public class FaturaCarenciaMapping : EntityTypeConfiguration<FaturaCarencia>
    {
        public FaturaCarenciaMapping()
        {
            HasKey(c => c.Id);
        }
    }
}