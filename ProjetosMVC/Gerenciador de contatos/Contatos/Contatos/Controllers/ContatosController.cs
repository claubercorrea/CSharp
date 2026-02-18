using Contatos.Data;
using Contatos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Contatos.Controllers
{
    public class ContatosController : Controller
    {

        private readonly ContatoContext _Context;
        public   ContatosController(ContatoContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            var lista = _Context.MeusContatos.ToList();
            return View(lista);
        }   
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CriarAsync(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _Context.MeusContatos.Add(contato);

                await _Context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int Id)

        {
            var contato = await _Context.MeusContatos.FindAsync(Id);
            if (contato == null)
            {
                 return NotFound();
            }
               

            return View(contato);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _Context.MeusContatos.Update(contato);
                await _Context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            

            return View(contato);
        }
        [HttpPost]

        public async Task<IActionResult> Excluir(int Id)
        {
            var contato = await _Context.MeusContatos.FindAsync(Id);
            if (contato != null)
            {
                _Context.MeusContatos.Remove(contato);
                await _Context.SaveChangesAsync();
           
            }
          return RedirectToAction(nameof(Index));
        }
    

    }
}