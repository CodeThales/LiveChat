using Microsoft.AspNetCore.Mvc;
using ThayNailDesign.Models;
using ThayNailDesign.Services;

namespace ThayNailDesign.Controllers
{
    public class ServicosController : Controller
    {
        IServicoService service;

        public ServicosController(IServicoService service)
        {
            this.service = service;

        }

        public IActionResult Index()
        {
            return View(service.getAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Servico servico)
        {
            if (!ModelState.IsValid) return View(servico);

            if (service.create(servico))
            {
                TempData["Adicionado"] = "Serviço adicionado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(servico);
            }
        }


        public IActionResult Read(int? id)
        {
            Servico servico = service.get(id);
            return servico != null ?
                View(servico) :
                NotFound();
        }

        public IActionResult Update(int? id)
        {
            Servico servico = service.get(id);
            return servico != null ?
                View(servico) :
                NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Servico servico)
        {
            if (!ModelState.IsValid) return View(servico);

            if (service.update(servico))
            {
                TempData["Atualizado"] = "Serviço atualizado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(servico);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (service.delete(id))
            {
                TempData["Excluido"] = "Serviço excluido com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Confirm(int? id)
        {
            Servico servico = service.get(id);
            if (servico != null)
            {
                return View(nameof(Confirm));
            }
            return NotFound();
        }

    }
}
