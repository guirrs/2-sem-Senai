using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Sistema_de_Veiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Veiculos.Data;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Veiculos.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculoController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        public async Task<IActionResult> index()
        {
            var lista = await _context.TabelaVeiculos.ToListAsync();

            return View(lista);
        }

        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string ModeloConstrutor, int AnoConstrutor, string TipoConstrutor)
        {
            Veiculo? novoVeiculo = null;

            if (TipoConstrutor == "Carro")
            {
                novoVeiculo = new Carro(ModeloConstrutor, AnoConstrutor);
            }

            else if (TipoConstrutor == "Moto")
            {
                novoVeiculo = new Moto(ModeloConstrutor, AnoConstrutor);
            }


            else
            {
                return BadRequest("Tipo Invalido.");
            }

            _context.TabelaVeiculos.Add(novoVeiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

            public async Task<IActionResult> Deletar(int Id)
        {
            var veiculo = await _context.TabelaVeiculos.FindAsync(Id);
            if (veiculo == null) return NotFound();

            _context.TabelaVeiculos.Remove(veiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}