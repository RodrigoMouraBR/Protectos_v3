using System;
using System.ComponentModel.DataAnnotations;
namespace Protectos.Application.ViewModels.Planos
{
    public class PlanoViewModel
    {
        public PlanoViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string CodigoPlano { get; set; }
        public string Descricao { get; set; }
        public string PlanoTipo { get; set; }
        public string CodigoPlanoANS { get; set; }
        public string Coparticipacao { get; set; }
        public string CodigoAcomodacao { get; set; }
        public string CodigoPlanoSuspenso { get; set; }      
    }
}


