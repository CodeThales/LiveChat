using System;
using System.Collections.Generic;
using System.Linq;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public class ClienteStaticService : IClienteService
    {
        List<Cliente> getCliente()
        {
            List<Cliente> clientes = new();
            clientes.Add(new Cliente { Id = 1, Nome = "Juliane", Telefone = "91111-1111", Nasc = new DateTime(2001, 01, 01) });
            clientes.Add(new Cliente { Id = 2, Nome = "Bárbara", Telefone = "92222-2222", Nasc = new DateTime(2002, 02, 02) });
            clientes.Add(new Cliente { Id = 3, Nome = "Letícia", Telefone = "93333-3333", Nasc = new DateTime(2003, 03, 03) });
            clientes.Add(new Cliente { Id = 4, Nome = "Débora", Telefone = "94444-4444", Nasc = new DateTime(2004, 04, 04) });
            clientes.Add(new Cliente { Id = 5, Nome = "Jessy", Telefone = "95555-5555", Nasc = new DateTime(2005, 05, 05) });
            clientes.Add(new Cliente { Id = 6, Nome = "Flávia", Telefone = "96666-6666", Nasc = new DateTime(2006, 06, 06) });
            clientes.Add(new Cliente { Id = 7, Nome = "Mariana", Telefone = "97777-7777", Nasc = new DateTime(2007, 07, 07) });
            clientes.Add(new Cliente { Id = 8, Nome = "Ingrid", Telefone = "98888-8888", Nasc = new DateTime(2008, 08, 08) });
            clientes.Add(new Cliente { Id = 9, Nome = "Simone", Telefone = "99999-9999", Nasc = new DateTime(2009, 09, 09) });
            clientes.Add(new Cliente { Id = 10, Nome = "Rosangela", Telefone = "91010-1010", Nasc = new DateTime(2010, 10, 10) });
            return clientes;
        }

        public List<Cliente> GetAll(string busca, bool sort = false)
        {
            var lista = getCliente();
            if (busca != null)
            {
                return lista.FindAll(c => c.Nome.ToLower().Contains(busca.ToLower()));
            }

            if (sort)
            {
                lista = lista.OrderBy(c => c.Nome).ToList();
                return lista;
            }

            return lista;
        }

        public Cliente GetSingle(int? id)
        {
            return getCliente().FirstOrDefault(c => c.Id == id);
        }

        public bool Create(Cliente cliente)
        {
            try
            {
                List<Cliente> clientes = getCliente();
                cliente.Id = clientes.Max(c => c.Id) + 1;
                clientes.Add(cliente);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Cliente cliente)
        {
            return false;
        }

        public bool Delete(int? id)
        {
            return false;
        }

    }
}
