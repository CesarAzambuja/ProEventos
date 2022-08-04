using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class PalestranteDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        public string Nome { get; set; }
        public string MiniCurriculo { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage ="Formatos aceitos. (gif, jpg, jpeg, bmp ou png)")]
        public string ImagemUrl { get; set; }


        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [Phone(ErrorMessage ="{0} Invalido.")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage ="{0} invalido.")]
        public string Email { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}