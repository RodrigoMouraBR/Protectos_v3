﻿using Protectos.Domain.Entities.Faturas;
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
            Property(c => c.Ativo);
            Property(c => c.DataCadastro)
                .IsRequired();
            Property(c => c.CadastradoPor)
                .IsRequired();
            Property(c => c.DataAlteracao);
            Property(c => c.AlteradoPor);
            HasRequired(c => c.Fatura)
               .WithMany(a => a.FaturaCarencia)
               .HasForeignKey(c => c.FaturaId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("FaturaCarencia");


        }
    }
}