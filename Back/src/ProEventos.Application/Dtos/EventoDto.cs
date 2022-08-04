using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public string Local { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public string DataEvento { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [MinLength(4, ErrorMessage ="O campo {0} deve ter no mínimo 4 caracteres."),
        MaxLength(50, ErrorMessage ="O campo {0} deve ter no máximo 50 caracteres.")]
        public string Tema { get; set; }
        
        [Display(Name = "Quantidade de Vagas")]
        [Range(1, 120000, ErrorMessage ="{0} deve ser entre 1 à 120.000")]
        public int QtdPessoas { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage ="Formatos aceitos. (gif, jpg, jpeg, bmp ou png)")]
        public string ImagemURL { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [Phone(ErrorMessage ="{0} Invalido.")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage ="{0} invalido.")]
        public string Email { get; set; }
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; } 
    }
}