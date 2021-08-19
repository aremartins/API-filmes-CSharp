using System;
using System.ComponentModel.DataAnnotations;


namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {

        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatórtio")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O genêro deve ter no máximo 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duração deve ter no´mínimo 1 e no maximo 800")]
        public int Duracao { get; set; }
    }
}
