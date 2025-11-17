using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Sistema_Funcionario.Data;
using Sistema_Funcionario.Models;

namespace Sistema_Funcionario.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly AppDbContext _context;

        public FuncionarioController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        //* LISTAR
        //* async / await -> executa a funcao de listar dentro do banco, mas permite que o sistema continue rodando enquanto isto
        public async Task<IActionResult> Index()
        {
            //* ToList - Lista as informacoes dentro da tabela funcionario
            var lista = await _context.TabelaFuncionario.ToListAsync();

            //* Retorna a view com a lista de funcionarios no index
            return View(lista);
        }

        //* Formulario de criacao - retorna a lista de formulario vazio
        [HttpGet] //* Get - Listar(Como se fosse o SELECT do banco)
        public IActionResult Criar() => View();

        //* Cadastrar as informacoes do formularios no Banco de dados
        [HttpPost]
        public async Task<IActionResult> Criar(string NomeConstrutor, double SalarioBaseConstrutor, string CargoConstrutor)
        {
            Funcionario? novoFuncionario = null;

            if (CargoConstrutor == "Gerente")
            {
                novoFuncionario = new Gerente(NomeConstrutor, SalarioBaseConstrutor);
            }
            else if (CargoConstrutor == "Vendedor")
            {
                novoFuncionario = new Vendedor(NomeConstrutor, SalarioBaseConstrutor);
            }
            else
            {
                return BadRequest("Cargo Invalido.");
            }

            _context.TabelaFuncionario.Add(novoFuncionario);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //*Excluir
        public async Task<IActionResult> Deletar(int Id)
        {
            //* Variavel que vai armazenar o registro de fncionario encontrado pelo id
            //*Find(id) -> busca o registro pelo id
            var funcionario = await _context.TabelaFuncionario.FindAsync(Id);

            if (funcionario == null) return NotFound();
            //*Remove() -> remove do banco de dados
            _context.TabelaFuncionario.Remove(funcionario);
            //*Salva as alteracoes
            await _context.SaveChangesAsync();

            //*Retorna para a Action: Index -> Mostra a lista atualizada de funcionarios
            return RedirectToAction("Index");
        }
    }
}
