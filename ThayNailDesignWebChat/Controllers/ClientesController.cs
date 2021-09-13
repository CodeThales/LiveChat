using ThayNailDesign.Models;
using Microsoft.AspNetCore.Mvc;
using ThayNailDesign.Services;
using System.Linq;

namespace ThayNailDesign.Controllers
{
    public class ClientesController : Controller
    {
        IClienteService _serviceStatic, _serviceSql, _service;
       
        public ClientesController(ClienteSqlService serviceSql, ClienteStaticService serviceStatic)
        {
            _serviceStatic = serviceStatic;
            _serviceSql = serviceSql;
            _service = serviceSql;
        }

        private void SelectService(string service = "sql")
        {
            switch (service)
            {
                case "sql": 
                    this._service = this._serviceSql;
                    break;
                case "static":
                    this._service = this._serviceStatic;
                    break;
                default:
                    this._service = this._serviceSql;
                    break;
            }
        }

        public IActionResult Index(string nome, bool sort = false, string service="sql")
        {
            SelectService(service);

            if (service == "sql") SetViewBag(source: "sql");
            if (service == "static") SetViewBag(source: "static");
            ViewBag.selectedService = service;

            ViewBag.sorted = sort;
            var lista = _service.GetAll(nome, sort);          
            
            ViewBag.totClientes = lista.Count();
            return View(_service.GetAll(nome, sort));
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente cliente)
        {            
            if (!ModelState.IsValid) return View(cliente);

            if (_service.Create(cliente))
            {
                TempData["Adicionado"] = "Cliente adicionado com sucesso";                
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(cliente);
            }            
        }

        public IActionResult Read(int? id)
        {
            Cliente cliente = _service.GetSingle(id);
            return cliente != null ?
                View(cliente) :
                NotFound();            
        }


        [HttpGet]
        public IActionResult Update(int? id)
        {
            Cliente cliente = _service.GetSingle(id);           
            if (cliente != null) return View(cliente);
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);
            if (_service.Update(cliente)) 
            {
                TempData["Atualizado"] = "Cliente atualizado com sucesso";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(cliente);
            }
        }

        public IActionResult Delete(int? id)
        {            
            //ViewBag.msg = "Cliente excluído com sucesso!";
            if (_service.Delete(id))
            {
                TempData["Excluido"] = "Cliente excluído com sucesso";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Confirm(int? id)
        {
            Cliente cliente = _service.GetSingle(id);
            if (cliente != null)
            {
                return View(nameof(Confirm));
            }
            return NotFound();
        }

        private void SetViewBag(string source = null)
        {
            ViewBag.source = source;
        }
    }
}
    