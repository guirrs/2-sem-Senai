using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Login_Simples.Models;

namespace Login_Simples.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        if(HttpContext.Session.GetString("UsuarioNome" )== null) 
        {
            return RedirectToAction("Index", "Login");
        }
        //* ViewBag carrega as informacoes para a view, nesse caso, carregando o Nome do Usuario
        ViewBag.usuario = HttpContext.Session.GetString("UsuarioNome");
        return View();
    }
}
