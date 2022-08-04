using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Application.Dtos
{
    public class RedeSocialDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public string Nome { get; set; }
        public string URL { get; set; }
        public int? EventoId { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public EventoDto Evento { get; set; }
        public int? PalestranteId { get; set; }
        
        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public PalestranteDto Palestrante { get; set; }
    }
}