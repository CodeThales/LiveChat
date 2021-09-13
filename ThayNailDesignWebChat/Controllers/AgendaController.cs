using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThayNailDesign.Models;
using ThayNailDesign.Services;

namespace ThayNailDesign.Controllers
{
    public class AgendaController : Controller
    {
        IAgendaService service;
        IClienteService clienteService;
        IServicoService servicoService;

        public AgendaController(IAgendaService service, IClienteService clienteService, IServicoService servicoService)
        {
            this.service = service;
            this.clienteService = clienteService;
            this.servicoService = servicoService;
        }

        public IActionResult Index()
        {
            return View(service.getAll());
        }
        
        [HttpGet]
        public IActionResult create()
        {
            var clientes = clienteService.GetAll();
            var servicos = servicoService.getAll();
            ViewBag.listaDeClientes = new SelectList(clientes, "Id", "Nome");
            ViewBag.listaDeServicos = new SelectList(servicos, "Id", "Nome");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(Agenda agenda)
        {
            var clientes = clienteService.GetAll();
            ViewBag.listaDeClientes = new SelectList(clientes, "Id", "Nome");

            var servicos = servicoService.getAll();
            ViewBag.listaDeServicos = new SelectList(servicos, "Id", "Nome");

            if (!ModelState.IsValid) return View(agenda);

            if (service.create(agenda))
            {
                TempData["Adicionado"] = "Atendimento agendado com sucesso";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(agenda);
            }
        }


        public IActionResult Read(int? id)
        {
            Agenda agenda = service.get(id);
            return agenda != null ? View(agenda) : NotFound();
        }

        public IActionResult Update(int? id)
        {
            var clientes = clienteService.GetAll();
            ViewBag.listaDeClientes = new SelectList(clientes, "Id", "Nome");

            var servicos = servicoService.getAll();
            ViewBag.listaDeServicos = new SelectList(servicos, "Id", "Nome");

            var agenda = service.get(id);
            return agenda != null ? View(agenda) : NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Agenda agenda)
        {

            if (!ModelState.IsValid)
            {
                var clientes = clienteService.GetAll();
                ViewBag.listaDeClientes = new SelectList(clientes, "Id", "Nome");

                var servicos = servicoService.getAll();
                ViewBag.listaDeServicos = new SelectList(servicos, "Id", "Nome");

                return View(agenda);
            }
            TempData["Atualizado"] = "Atendimento atualizado com sucesso";
            service.update(agenda);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (service.delete(id))
            {
                TempData["Excluido"] = "Atendimento excluído com sucesso";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Confirm(int? id)
        {
            Agenda agenda = service.get(id);
            if (agenda != null)
            {
                return View(nameof(Confirm));
            }
            return NotFound();
        }
    }
}
