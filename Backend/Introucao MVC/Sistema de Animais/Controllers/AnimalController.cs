using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Sistema_de_Animais.Data;
using Sistema_de_Animais.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Animais.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AppDbContext _context;

        public AnimalController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaAnimal.ToListAsync();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string NomeConstrutor, string TipoConstrutor)
        {
            Animal? novoAnimal = null;

            if(TipoConstrutor == "Leao")
            {
                novoAnimal = new Leao(NomeConstrutor);
            }

            else if(TipoConstrutor == "Elefante")
            {
                novoAnimal = new Elefante(NomeConstrutor);
            }

            else
            {
                return BadRequest("Animal nao valido");
            }

            _context.TabelaAnimal.Add(novoAnimal);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Deletar(int Id)
        {
            var Animal = await _context.TabelaAnimal.FindAsync(Id);

            if(Animal == null) return NotFound();

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}