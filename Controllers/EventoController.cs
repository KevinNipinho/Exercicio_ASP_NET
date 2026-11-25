using Microsoft.AspNetCore.Mvc;
using ExercicioASP.NET.Models;
using ExercicioASP.NET.ViewModels;

namespace ExercicioASP.NET.Controllers
{
    public class EventosController : Controller
    {

        private static List<Evento> _eventos = new()
        {
        new Evento { Id = 1, Nome = "Show de Rock", Descricao = "Festival com bandas nacionais de rock.", Local = "São Paulo - SP", DataEvento = new DateTime(2026, 12, 15), QuantidadeVagas = 500, ValorIngresso = 50.00m },
        new Evento { Id = 2, Nome = "Feira de Tecnologia", Descricao = "Evento sobre novidades do mundo da tecnologia.", Local = "Centro de Convenções", DataEvento = new DateTime(2027, 1, 20), QuantidadeVagas = 300, ValorIngresso = 0m },
        new Evento { Id = 3, Nome = "Workshop de CSharp", Descricao = "Workshop introdutório sobre programação em CSharp.", Local = "Senac", DataEvento = new DateTime(2027, 2, 10), QuantidadeVagas = 50, ValorIngresso = 35.00m },
        new Evento { Id = 4, Nome = "Festival de Música", Descricao = "Festival com apresentações de diversos estilos musicais.", Local = "Parque Municipal", DataEvento = new DateTime(2027, 3, 5), QuantidadeVagas = 1000, ValorIngresso = 80.00m },
        new Evento { Id = 5, Nome = "Palestra de IA", Descricao = "Palestra sobre inteligência artificial e suas aplicações.", Local = "Auditório Central", DataEvento = new DateTime(2027, 4, 18), QuantidadeVagas = 200, ValorIngresso = 25.00m }
        };
        public IActionResult Index()
        {
            return View(_eventos);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Evento evento)
        {
            if (!ModelState.IsValid) // Verifica se as validações atribuidas na Model foram cumpridas
            {
                return View(evento); // Retorna com erros de validação
            }

            evento.Id = _eventos.Any() ? _eventos.Max(a => a.Id) + 1 : 1;

            _eventos.Add(evento);

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Buscar()
        {
            return View(new BuscaEventoViewModel());
        }


 
[HttpPost]
public IActionResult Buscar(BuscaEventoViewModel vm)
{
    var resultados = _eventos.AsEnumerable();

    if (!string.IsNullOrWhiteSpace(vm.NomeBusca))
    {
        resultados = resultados.Where(a =>
            a.Nome.Contains(vm.NomeBusca,
            StringComparison.OrdinalIgnoreCase));
    }

    if (!string.IsNullOrWhiteSpace(vm.LocalBusca))
    {
        resultados = resultados.Where(a =>
            a.Local.Contains(vm.LocalBusca,
            StringComparison.OrdinalIgnoreCase));
    }

    if (vm.DataInicial.HasValue)
    {
        resultados = resultados.Where(a =>
            a.DataEvento.Date >= vm.DataInicial.Value.Date);
    }

    vm.Resultados = resultados.ToList();

    return View(vm);
}

    }


}
