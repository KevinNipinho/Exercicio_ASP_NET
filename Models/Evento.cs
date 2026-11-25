using System.ComponentModel.DataAnnotations;

namespace ExercicioASP.NET.Models
{
    public class Evento
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "Nome deve ser entre 5 e 80 caractéres")]
        public string Nome {get; set;} = "";

        [Required(ErrorMessage = "A descricação é obrigatório")]
        [MinLength(10, ErrorMessage = "Descrição deve ter no mínimo 10 caracteres")]
        public string Descricao {get; set;} = ""; 

        [Required(ErrorMessage = "O local é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Local deve ser entre 3 e 100 caractéres")]
        public string Local {get; set;} = ""; 

        [Required(ErrorMessage = "A data é obrigatório")]
    
        public DateTime DataEvento {get; set;}
        
        [Range(1, 1000, ErrorMessage = "A quantidade de vagas deve ser entre 1 e 1000")]
        public int QuantidadeVagas {get; set;}

        [Range(0, double.MaxValue, ErrorMessage = "O valor do ingresso deve ser maior ou igual a zero.")]
        public decimal ValorIngresso {get; set;}
    }
}