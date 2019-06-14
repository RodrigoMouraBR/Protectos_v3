﻿using System;

namespace Protectos.Domain.DTO
{
    public class AtividadeSecundaria
    {
        public string text { get; set; }
        public string code { get; set; }
        public Guid EmpresaId { get; set; }
        public virtual ReceitaWs Empresa { get; set; }
    }
}