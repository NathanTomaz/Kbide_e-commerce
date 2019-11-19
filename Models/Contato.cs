using System.ComponentModel.DataAnnotations;

namespace Kbide_desenvolvimento.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório!</br>")]
        [MinLength(4, ErrorMessage = "O campo Nome deve ter no mínimo 4 caracteres</br>")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório!</br>")]
        [EmailAddress(ErrorMessage = "O campo E-Mail não é válido</br>")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Texto é obrigatório!</br>")]
        [MinLength(10, ErrorMessage = "O campo Texto deve ter no mínimo 10 caracteres</br>")]
        [MaxLength(1000, ErrorMessage = "O campo Texto deve ter no máximo 1000 caracteres</br>")]
        public string Texto { get; set; }
    }
}