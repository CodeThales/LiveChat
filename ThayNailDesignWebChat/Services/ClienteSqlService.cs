using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThayNailDesign.Data;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public class ClienteSqlService : IClienteService
    {
        ThayNailDesignContext _context; 
        public ClienteSqlService(ThayNailDesignContext context)
        {
            _context = context;
        }
        public List<Cliente> GetAll(string busca, bool sort = false)
        {
            List<Cliente> lista = _context.Cliente.Include(c => c.Agendas).ToList();
            if (busca != null)
                lista = lista.FindAll(c => c.Nome.ToLower().Contains(busca.ToLower()));

            if (sort)
                lista = lista.OrderBy(c => c.Nome).ToList();

            return lista;
        }

        public Cliente GetSingle(int? id)
        {
            return _context.Cliente.Include($"{nameof(Cliente.Agendas)}.{nameof(Agenda.servico)}").FirstOrDefault(c => c.Id == id);
        }

        public bool Create(Cliente cliente)
        {
            try
            {
                _context.Add(cliente);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Cliente cliente)
        {
            try
            {
                if (!_context.Cliente.Any(c => c.Id == cliente.Id)) throw new Exception("Não existe nenhum cliente com o id informado!");
                _context.Cliente.Update(cliente);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }            
        }

        public bool Delete(int? id)
        {
            try
            {
                _context.Cliente.Remove(GetSingle(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

