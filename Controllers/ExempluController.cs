using Microsoft.AspNetCore.Mvc;

namespace Ienei_Ioan_Lab1.Controllers
{
    public class ExempluController : Controller
    {
        public string Index()
        {
            return "Bun venit!";
        }
        public string Salut()
        {
            return "Salut!";
        }
        public string NumString(int a = 10, string b = "sir de caractere")
        {
            return "Numarul afisat este: " + a + ", iar string-ul afisat este: " + b;
        }
    }
}
