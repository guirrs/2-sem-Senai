using Login_Simples.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Sistema_Login.Services;

namespace Login_Simples.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context) => _context = context;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(string email, string senha)
        {
            //* IsNullOrWhiteSpace() verifica se ha valor nulo ou branco onde foi inserido
            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                ViewBag.Erro = "Email ou senha incorreta.";
                return View("Index");
            }

            //* Hash da senha digitada
            byte[] senhaDigitadaHash = HashService.GerarHashBytes(senha);

            //* Busca no banco se ha um email igual
            //* FirstOrdDefault vai pegar a primeira validacao verdadeira, se nao retornar um valor padrao, que no caso eh nulo
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Email == email);

            if(usuario == null)
            {
                ViewBag.Erro = "Email ou senha incorretos";
                return View("Index");
            }

            //* Compara byte a vyte da senha
            //* SequenciaEqual => retorna false se qualquer byte estiver diferente
            if(!usuario.SenhaHash.SequenceEqual(senhaDigitadaHash))
            {
                ViewBag.Erro = "Email ou senha incorretos.";
                return View("Index");
            }

            //*Login estiver OK, salva na sessao
            HttpContext.Session.SetString("UsuarioNome", usuario.NomeCompleto);
            HttpContext.Session.SetInt32("Usuarioold", usuario.Id);

            //*
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Sair()
        {
            //* O Clear apaga o usuario, fazendo com que ao entrar novamente, ele faca o Login denovo
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}