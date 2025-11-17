using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Cursos.Data;
using Sistema_de_Cursos.Models;

namespace Sistema_de_Cursos.Controllers
{
    public class CursoController : Controller
    {
        private readonly AppDbContext _context;

        public CursoController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaCurso.ToListAsync();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string NomeConstrutor, int HorasConstrutor, string TipoConstrutor)
        {
            //? ? serve para poder deixar o inicializador como nulo
            Curso? novoCurso = null;

            if(TipoConstrutor == "Tecnico")
            {
                novoCurso = new Tecnico(NomeConstrutor, HorasConstrutor);
            }

            else if(TipoConstrutor == "Superior")
            {
                novoCurso = new Superior(NomeConstrutor, HorasConstrutor);
            }

            else
            {
                return BadRequest("Tipo de curso invalido");
            }
            _context.TabelaCurso.Add(novoCurso);
            await _context.SaveChangesAsync();

            //* RedirectToAction() redireciona o conteudo para uma action, no caso foi criado uma Action Index, assim, mandamos conteudo a ela
            return RedirectToAction("Index");
        }
        //*Pois o id para identificar o objeto pelo Id
        public async Task<ActionResult> Deletar(int Id)
        {
            var Curso = await _context.TabelaCurso.FindAsync(Id);

            if(Curso == null) return NotFound();

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}