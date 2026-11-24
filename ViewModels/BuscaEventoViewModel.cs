using ExercicioASP.NET.Models;

namespace ExercicioASP.NET.ViewModels
{
    public class BuscaEventoViewModel
    {
        public string? TermoBusca { get; set; }
        public List<Evento> Resultados { get; set; } = new();
    }
}