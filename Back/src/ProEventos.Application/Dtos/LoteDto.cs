using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Application.Dtos
{
    public class LoteDto
    {
         public int Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public string Nome { get; set; }
        [Display(Name = "Preço")]
        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public decimal Preco { get; set; }

        [Display(Name = "Data de Inicio")]
        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public string DataInicio { get; set; }

        [Display(Name = "Data de Termino")]
        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public string DataFim { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public int Quantidade { get; set; }
        public int EventoId { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public EventoDto Evento { get; set; }
    }
    
}