using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
        
        //
        // GET: /HelloWorld/Welcom/

        public string Welcome(string nome, int vezes = 1, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Oi {nome}, vezes: {vezes}. ID: {id}");
            //return "Bem-vindo ao meu método de boas vindas do meu controller";
        }

        //
        // GET: /HelloWorld/Teste

        public string Teste()
        {
            return "Aqui é só pra mostrar como funciona a relação rota x método dentro da controller";
        }
    }
}
