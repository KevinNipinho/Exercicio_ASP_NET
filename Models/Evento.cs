using System.ComponentModel.DataAnnotations;

namespace ExercicioASP.NET.Models
{
    public class Evento
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "O nome é obrigatório")]
        [Range(5, 80, ErrorMessage = "Nome deve ser entre 5 e 80 caractéres")]
        public string Nome {get; set;} = "";

        [Required(ErrorMessage = "A descricação é obrigatório")]
        [MinLength(2, ErrorMessage = "Descrião deve ter no minímo 10 caracteres")]
        public string Descricao {get; set;} = ""; 

        [Required(ErrorMessage = "O local é obrigatório")]
        [Range(3, 100, ErrorMessage = "Local deve ser entre 3 e 100 caractéres")]
        public string Local {get; set;} = ""; 

        [Required(ErrorMessage = "O nome é obrigatório")]
        public DateTime DataEvento {get; set;}

        public int QuantidadeVagas {get; set;}

        public decimal ValorIngresso {get; set;}
    }
}